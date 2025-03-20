using IbmMQTestApp.Common;
using IbmMQTestApp.Entities;
using IbmMQTestApp.Services;

namespace IbmMQTestApp.Forms
{
    public partial class QueueContentForm : Form
    {

        private MainForm mainForm { get; set; }
        private string queueName { get; set; }
        private string queueAddress { get; set; }
        private List<SimpleMessage> messages { get; set; }
        private QueueTransientService queueService { get; set; }

        public QueueContentForm()
        {
            InitializeComponent();
        }

        public QueueContentForm(MainForm main, string queue, string address)
        {
            InitializeComponent();
            mainForm = main;
            queueService = new QueueTransientService(mainForm.CurrentSettings.QueueSettings);
            queueName = queue;
            queueAddress = address;
            Text = $"Queue: {queueName} on {queueAddress}";
            QueueContentFormLoad();
        }

        private void QueueContentFormLoad()
        {
            messages = queueService.GetQueueMessages(queueName).Result.ToList();
            lvMessages.Items.Clear();
            foreach (var item in messages)
            {
                lvMessages.Items.Add(item.StringId).SubItems.AddRange(new string[] { item.ListViewContent, item.User, item.TimeStamp });
            }
            lvMessages.Refresh();
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void lvMessages_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvMessages.SelectedItems.Count > 0)
            {
                int selectedIndex = lvMessages.SelectedItems[0].Index;
                SimpleMessage selectedMessage = messages[selectedIndex];
                var id = BitConverter.ToString(selectedMessage.Id).Replace("-", "");
                txtMessageContent.Text = selectedMessage.Content;
                lblMessageId.Text = $"Message ID: {selectedMessage.StringId} TimeStamp: {selectedMessage.TimeStamp}\nUser: {selectedMessage.User} Application: {selectedMessage.Application}";
            }
        }

        private void QueueContentForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
            mainForm.Show();
        }

        private async void btnDeleteMessage_Click(object sender, EventArgs e)
        {
            if (lvMessages.SelectedItems.Count > 0)
            {
                int selectedIndex = lvMessages.SelectedItems[0].Index;
                SimpleMessage selectedMessage = messages[selectedIndex];

                queueService.DeleteMessage(queueName, selectedMessage.Id);
                var msgs = await queueService.GetQueueMessages(queueName);
                messages = msgs.ToList();

                ResetFields();
            }
            else
            {
                CommonFormActions.ShowWarningMessage("Please, select a message to delete.", "WARNING");
            }
        }
        private void ResetFields()
        {

            QueueContentFormLoad();
            txtMessageContent.Text = string.Empty;
            lblMessageId.Text = $"Message ID:";

        }

        private async void btnCleanQueue_Click(object sender, EventArgs e)
        {
            if(CommonFormActions.ShowAskInformationMessage("Do you really want to clean this queue?", "WARNING"))
            {
                queueService.CleanQueue(queueName);
                var msgs = await queueService.GetQueueMessages(queueName);
                messages = msgs.ToList();
                ResetFields();
            }
        }
    }
}
