using IbmMQTestApp.Common;
using IbmMQTestApp.Entities;
using IbmMQTestApp.Services;

namespace IbmMQTestApp.Forms
{
    public partial class QueueContentForm : Form
    {

        private MainForm mainForm { get; set; }
        private string queueName { get; set; }
        private List<SimpleMessage> messages { get; set; }

        public QueueContentForm()
        {
            InitializeComponent();
        }

        public QueueContentForm(MainForm main, string queue, List<SimpleMessage> messagess)
        {
            InitializeComponent();
            mainForm = main;
            queueName = queue;
            messages = messagess;
            Text = $"Queue: {queueName}";
            QueueContentForm_Load();
        }

        private void QueueContentForm_Load()
        {
            lvMessages.Items.Clear();
            foreach (var item in messages)
            {
                var id = BitConverter.ToString(item.Id).Replace("-", "");
                lvMessages.Items.Add(id).SubItems.AddRange(new string[] { (item.Content.Length < 100 ? item.Content : item.Content + "..."), item.TimeStamp, item.User });
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
                lblMessageId.Text = $"Message ID: {id}\nTimeStamp: {selectedMessage.TimeStamp}\nUser: {selectedMessage.User}";

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

                QueueTransientService queueService = new QueueTransientService(mainForm.CurrentSettings.QueueSettings);
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

            QueueContentForm_Load();
            txtMessageContent.Text = string.Empty;
            lblMessageId.Text = $"Message ID:";

        }

        private async void btnCleanQueue_Click(object sender, EventArgs e)
        {
            if(CommonFormActions.ShowAskInformationMessage("Do you really want to clean this queue?", "WARNING"))
            {
                QueueTransientService queueService = new QueueTransientService(mainForm.CurrentSettings.QueueSettings);
                queueService.CleanQueue(queueName);
                var msgs = await queueService.GetQueueMessages(queueName);
                messages = msgs.ToList();
                ResetFields();
            }
        }
    }
}
