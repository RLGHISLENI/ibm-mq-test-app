using IBM.WMQ;
using System.Collections;
using IbmMQTestApp.Settings;
using IbmMQTestApp.Entities;
using Newtonsoft.Json.Converters;
using IbmMQTestApp.Utils;


namespace IbmMQTestApp.Services
{
    public class QueueTransientService
    {
        public QueueTransientService(QueueSettings settings)
        {
            Settings = settings;
        }
        public QueueSettings Settings { get; set; }
        private MQQueueManager mqQMgr;
        private MQQueue mqQueue;

        public void InitQueue(string queue)
        {
            if (mqQMgr != null)
            {
                if (mqQueue == null)
                {
                    mqQueue = mqQMgr.AccessQueue(Settings.Queues[queue], MQC.MQOO_INPUT_SHARED | MQC.MQOO_FAIL_IF_QUIESCING | MQC.MQOO_BROWSE);
                }
                return;
            }
            Hashtable props = new()
                {
                    { MQC.HOST_NAME_PROPERTY, Settings.Host },
                    { MQC.CHANNEL_PROPERTY, Settings.Channel },
                    { MQC.PORT_PROPERTY, Settings.Port },
                    { MQC.TRANSPORT_PROPERTY, MQC.TRANSPORT_MQSERIES_MANAGED },
                    { MQC.USER_ID_PROPERTY, Settings.Username },
                { MQC.PASSWORD_PROPERTY, Settings.Password }
                };
            try
            {
                mqQMgr = new MQQueueManager(Settings.QueueManagerName, props);
                mqQueue = mqQMgr.AccessQueue(Settings.Queues[queue], MQC.MQOO_INPUT_SHARED | MQC.MQOO_FAIL_IF_QUIESCING | MQC.MQOO_BROWSE | MQC.MQOO_INQUIRE);
            }
            catch (Exception e)
            {

                throw;
            }
        }

        public async Task<IEnumerable<SimpleMessage>> GetQueueMessages(string queue)
        {
            var messages = new List<SimpleMessage>();
            InitQueue(queue);

            if (IsQueueEmpty())
            {
                return messages;
            }

            // Options for browsing messages
            MQGetMessageOptions mqGetMsgOpts = new()
            {
                Options = MQC.MQGMO_BROWSE_FIRST + MQC.MQGMO_FAIL_IF_QUIESCING,
                WaitInterval = 0
            };

            while (true)
            {
                try
                {
                    MQMessage mqMsg = new();
                    mqQueue.Get(mqMsg, mqGetMsgOpts);

                    // Process the message
                    string stringMessage = mqMsg.ReadString(mqMsg.MessageLength);
                    var message = new SimpleMessage
                    {
                        Content = stringMessage,
                        Id = mqMsg.MessageId,
                        TimeStamp = mqMsg.PutDateTime.ConvertToLocalTime().ToString("yyyy-MM-dd HH:mm:ss"),
                        User = mqMsg.UserId,
                        Application = mqMsg.PutApplicationName,
                    };

                    messages.Add(message);

                    // Update options to browse next message
                    mqGetMsgOpts.Options = MQC.MQGMO_BROWSE_NEXT + MQC.MQGMO_FAIL_IF_QUIESCING;
                }
                catch (MQException mqe)
                {
                    if (mqe.Reason == MQC.MQRC_NO_MSG_AVAILABLE)
                    {
                        // No more messages to browse
                        break;
                    }
                    else
                    {
                        throw;
                    }
                }
            }

            return messages;
        }

        public async Task SendMessageToQueue(string queue, string message)
        {

            InitQueueForPut(queue);
            try
            {

                MQMessage mqMsg = new();

                mqMsg.WriteString(message);
                mqMsg.Format = MQC.MQFMT_STRING;


                MQPutMessageOptions mqPutMsgOpts = new();
                mqQueue.Put(mqMsg, mqPutMsgOpts);
                Console.WriteLine(message + " enviada");

                mqQueue?.Close();
                mqQMgr?.Disconnect();
            }
            catch (MQException e)
            {
                Console.Write(e);
                Console.Write(e.Message);
                Console.Write(e.Reason);
                Console.Write(e.StackTrace);
            }
        }

        private bool IsQueueEmpty()
        {
            return mqQueue.CurrentDepth == 0;
        }

        public int GetQueueDepth(string queue)
        {
            InitQueue(queue);
            return mqQueue.CurrentDepth;
        }

        private void InitQueueForPut(string queue)
        {
            if (mqQMgr != null)
            {
                if (mqQueue == null)
                {
                    mqQueue = mqQMgr.AccessQueue(queue, MQC.MQOO_OUTPUT | MQC.MQOO_FAIL_IF_QUIESCING);
                }
                return;
            }
            Hashtable props = new()
    {
        { MQC.HOST_NAME_PROPERTY, Settings.Host },
        { MQC.CHANNEL_PROPERTY, Settings.Channel },
        { MQC.PORT_PROPERTY, Settings.Port },
        { MQC.TRANSPORT_PROPERTY, MQC.TRANSPORT_MQSERIES_MANAGED },
        { MQC.USER_ID_PROPERTY, Settings.Username },
        { MQC.PASSWORD_PROPERTY, Settings.Password }
    };
            mqQMgr = new MQQueueManager(Settings.QueueManagerName, props);
            mqQueue = mqQMgr.AccessQueue(queue, MQC.MQOO_OUTPUT | MQC.MQOO_FAIL_IF_QUIESCING);
        }


        public void CleanQueue(string queue)
        {
            InitQueue(queue);

            while (!IsQueueEmpty())
            {
                try
                {
                    // First browse a message
                    MQGetMessageOptions mqBrowseOpts = new()
                    {
                        Options = MQC.MQGMO_BROWSE_FIRST + MQC.MQGMO_FAIL_IF_QUIESCING,
                        WaitInterval = 10
                    };

                    MQMessage mqMsg = new();
                    mqQueue.Get(mqMsg, mqBrowseOpts);

                    // Then do a destructive get with a separate options object
                    MQGetMessageOptions mqDeleteOpts = new()
                    {
                        Options = MQC.MQGMO_MSG_UNDER_CURSOR,
                        WaitInterval = 10
                    };

                    mqQueue.Get(new MQMessage(), mqDeleteOpts);
                }
                catch (MQException mqe)
                {
                    if (mqe.Reason == MQC.MQRC_NO_MSG_AVAILABLE)
                    {
                        break;
                    }
                    else
                    {
                        throw;
                    }
                }
            }
        }

        public void DeleteMessage(string queue, byte[] messageId)
        {
            InitQueue(queue);
            MQGetMessageOptions mqGetMsgOpts = new()
            {
                Options = MQC.MQGMO_BROWSE_FIRST + MQC.MQGMO_FAIL_IF_QUIESCING,
                WaitInterval = 10
            };

            while (!IsQueueEmpty())
            {
                try
                {
                    MQMessage mqMsg = new();
                    mqQueue.Get(mqMsg, mqGetMsgOpts);

                    var id = BitConverter.ToString(mqMsg.MessageId);

                    if (id == BitConverter.ToString(messageId))
                    {
                        // Create new options for destructive get
                        MQGetMessageOptions mqDeleteOpts = new()
                        {
                            Options = MQC.MQGMO_MSG_UNDER_CURSOR,
                            WaitInterval = 10
                        };

                        // Use the same message object for the destructive get
                        mqQueue.Get(mqMsg, mqDeleteOpts);
                        break;
                    }

                    // Move to next message
                    mqGetMsgOpts.Options = MQC.MQGMO_BROWSE_NEXT;
                }
                catch (MQException mqe)
                {
                    if (mqe.Reason == MQC.MQRC_NO_MSG_AVAILABLE)
                    {
                        break;
                    }
                    else
                    {
                        throw;
                    }
                }
            }
        }


    }
}
