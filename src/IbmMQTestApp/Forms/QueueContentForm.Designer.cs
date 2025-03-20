namespace IbmMQTestApp.Forms
{
    partial class QueueContentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ColumnHeader colMsgNum;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QueueContentForm));
            groupBox1 = new GroupBox();
            btnDeleteMessage = new Button();
            btnCleanQueue = new Button();
            lvMessages = new ListView();
            colMsgTxt = new ColumnHeader();
            colMsgTimeStamp = new ColumnHeader();
            colMsgUser = new ColumnHeader();
            groupBox2 = new GroupBox();
            lblMessageId = new Label();
            label1 = new Label();
            lblMsgId = new Label();
            txtMessageContent = new TextBox();
            colMsgNum = new ColumnHeader();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // colMsgNum
            // 
            colMsgNum.Text = "Num";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnDeleteMessage);
            groupBox1.Controls.Add(btnCleanQueue);
            groupBox1.Controls.Add(lvMessages);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(950, 340);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Message List";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // btnDeleteMessage
            // 
            btnDeleteMessage.Location = new Point(658, 291);
            btnDeleteMessage.Name = "btnDeleteMessage";
            btnDeleteMessage.Size = new Size(120, 30);
            btnDeleteMessage.TabIndex = 1;
            btnDeleteMessage.Text = "Delete Message";
            btnDeleteMessage.UseVisualStyleBackColor = true;
            btnDeleteMessage.Click += btnDeleteMessage_Click;
            // 
            // btnCleanQueue
            // 
            btnCleanQueue.Location = new Point(812, 291);
            btnCleanQueue.Name = "btnCleanQueue";
            btnCleanQueue.Size = new Size(120, 30);
            btnCleanQueue.TabIndex = 1;
            btnCleanQueue.Text = "Clean Queue";
            btnCleanQueue.UseCompatibleTextRendering = true;
            btnCleanQueue.UseVisualStyleBackColor = true;
            btnCleanQueue.Click += btnCleanQueue_Click;
            // 
            // lvMessages
            // 
            lvMessages.Columns.AddRange(new ColumnHeader[] { colMsgNum, colMsgTxt, colMsgUser, colMsgTimeStamp });
            lvMessages.FullRowSelect = true;
            lvMessages.Location = new Point(17, 22);
            lvMessages.Name = "lvMessages";
            lvMessages.Size = new Size(915, 254);
            lvMessages.TabIndex = 0;
            lvMessages.UseCompatibleStateImageBehavior = false;
            lvMessages.View = View.Details;
            lvMessages.SelectedIndexChanged += lvMessages_SelectedIndexChanged;
            // 
            // colMsgTxt
            // 
            colMsgTxt.Text = "Message";
            colMsgTxt.Width = 400;
            // 
            // colMsgTimeStamp
            // 
            colMsgTimeStamp.Text = "Time Stamp";
            colMsgTimeStamp.Width = 200;
            // 
            // colMsgUser
            // 
            colMsgUser.Text = "User";
            colMsgUser.Width = 200;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblMessageId);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(lblMsgId);
            groupBox2.Controls.Add(txtMessageContent);
            groupBox2.Location = new Point(12, 358);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(950, 290);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Message Details";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // lblMessageId
            // 
            lblMessageId.AutoSize = true;
            lblMessageId.Location = new Point(19, 20);
            lblMessageId.Name = "lblMessageId";
            lblMessageId.Size = new Size(70, 15);
            lblMessageId.TabIndex = 3;
            lblMessageId.Text = "Message ID:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 63);
            label1.Name = "label1";
            label1.Size = new Size(102, 15);
            label1.TabIndex = 2;
            label1.Text = "Message Content:";
            // 
            // lblMsgId
            // 
            lblMsgId.AutoSize = true;
            lblMsgId.Location = new Point(17, 28);
            lblMsgId.Name = "lblMsgId";
            lblMsgId.Size = new Size(0, 15);
            lblMsgId.TabIndex = 1;
            // 
            // txtMessageContent
            // 
            txtMessageContent.BackColor = Color.White;
            txtMessageContent.Location = new Point(17, 84);
            txtMessageContent.Multiline = true;
            txtMessageContent.Name = "txtMessageContent";
            txtMessageContent.ReadOnly = true;
            txtMessageContent.ScrollBars = ScrollBars.Both;
            txtMessageContent.Size = new Size(915, 188);
            txtMessageContent.TabIndex = 0;
            // 
            // QueueContentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(974, 660);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(990, 699);
            MinimumSize = new Size(990, 699);
            Name = "QueueContentForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "QueueContentForm";
            FormClosing += QueueContentForm_FormClosing;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnDeleteMessage;
        private Button btnCleanQueue;
        private ListView lvMessages;
        private ColumnHeader colMsgTxt;
        private GroupBox groupBox2;
        private Label label1;
        private Label lblMsgId;
        private TextBox txtMessageContent;
        private Label lblMessageId;
        private ColumnHeader colMsgTimeStamp;
        private ColumnHeader colMsgUser;
    }
}