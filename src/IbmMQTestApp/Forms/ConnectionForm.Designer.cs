namespace IbmMQTestApp.Forms
{
    partial class ConnectionForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConnectionForm));
            gbConnections = new GroupBox();
            btnConnectionTest = new Button();
            label7 = new Label();
            btnConnectionCancel = new Button();
            btnConnectionSave = new Button();
            tbConnPassword = new TextBox();
            label6 = new Label();
            tbConnUser = new TextBox();
            groupBox1 = new GroupBox();
            btnQueueRemove = new Button();
            btnQueueAdd = new Button();
            lvQueues = new ListView();
            chQueueAlias = new ColumnHeader();
            chQueueAddress = new ColumnHeader();
            label5 = new Label();
            tbConnQueueManager = new TextBox();
            label4 = new Label();
            tbConnPort = new TextBox();
            label3 = new Label();
            tbConnChannel = new TextBox();
            label2 = new Label();
            tbConnHost = new TextBox();
            label1 = new Label();
            tbConnName = new TextBox();
            groupBox2 = new GroupBox();
            btnMessageRemove = new Button();
            btnMessageAdd = new Button();
            lvMessages = new ListView();
            chMessageAlias = new ColumnHeader();
            chMessageText = new ColumnHeader();
            gbConnections.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // gbConnections
            // 
            gbConnections.Controls.Add(btnConnectionTest);
            gbConnections.Controls.Add(label7);
            gbConnections.Controls.Add(btnConnectionCancel);
            gbConnections.Controls.Add(btnConnectionSave);
            gbConnections.Controls.Add(tbConnPassword);
            gbConnections.Controls.Add(label6);
            gbConnections.Controls.Add(tbConnUser);
            gbConnections.Controls.Add(groupBox1);
            gbConnections.Controls.Add(label5);
            gbConnections.Controls.Add(tbConnQueueManager);
            gbConnections.Controls.Add(label4);
            gbConnections.Controls.Add(tbConnPort);
            gbConnections.Controls.Add(label3);
            gbConnections.Controls.Add(tbConnChannel);
            gbConnections.Controls.Add(label2);
            gbConnections.Controls.Add(tbConnHost);
            gbConnections.Controls.Add(label1);
            gbConnections.Controls.Add(tbConnName);
            gbConnections.Location = new Point(10, 20);
            gbConnections.Margin = new Padding(1);
            gbConnections.Name = "gbConnections";
            gbConnections.Padding = new Padding(1);
            gbConnections.Size = new Size(954, 347);
            gbConnections.TabIndex = 0;
            gbConnections.TabStop = false;
            gbConnections.Text = "Connection";
            // 
            // btnConnectionTest
            // 
            btnConnectionTest.Location = new Point(314, 293);
            btnConnectionTest.Margin = new Padding(1);
            btnConnectionTest.Name = "btnConnectionTest";
            btnConnectionTest.Size = new Size(119, 30);
            btnConnectionTest.TabIndex = 5;
            btnConnectionTest.Text = "Test Connection";
            btnConnectionTest.UseVisualStyleBackColor = true;
            btnConnectionTest.Click += btnConnectionTest_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(15, 282);
            label7.Margin = new Padding(1, 0, 1, 0);
            label7.Name = "label7";
            label7.Size = new Size(60, 15);
            label7.TabIndex = 14;
            label7.Text = "Password:";
            // 
            // btnConnectionCancel
            // 
            btnConnectionCancel.Location = new Point(641, 293);
            btnConnectionCancel.Margin = new Padding(1);
            btnConnectionCancel.Name = "btnConnectionCancel";
            btnConnectionCancel.Size = new Size(119, 30);
            btnConnectionCancel.TabIndex = 3;
            btnConnectionCancel.Text = "Cancel";
            btnConnectionCancel.UseVisualStyleBackColor = true;
            btnConnectionCancel.Click += btnConnectionCancel_Click;
            // 
            // btnConnectionSave
            // 
            btnConnectionSave.Location = new Point(806, 293);
            btnConnectionSave.Margin = new Padding(1);
            btnConnectionSave.Name = "btnConnectionSave";
            btnConnectionSave.Size = new Size(119, 30);
            btnConnectionSave.TabIndex = 4;
            btnConnectionSave.Text = "Save";
            btnConnectionSave.UseVisualStyleBackColor = true;
            btnConnectionSave.Click += btnConnectionSave_Click;
            // 
            // tbConnPassword
            // 
            tbConnPassword.Location = new Point(15, 298);
            tbConnPassword.Margin = new Padding(1);
            tbConnPassword.Name = "tbConnPassword";
            tbConnPassword.PasswordChar = '●';
            tbConnPassword.Size = new Size(268, 23);
            tbConnPassword.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 234);
            label6.Margin = new Padding(1, 0, 1, 0);
            label6.Name = "label6";
            label6.Size = new Size(33, 15);
            label6.TabIndex = 12;
            label6.Text = "User:";
            // 
            // tbConnUser
            // 
            tbConnUser.Location = new Point(15, 250);
            tbConnUser.Margin = new Padding(1);
            tbConnUser.Name = "tbConnUser";
            tbConnUser.Size = new Size(268, 23);
            tbConnUser.TabIndex = 11;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnQueueRemove);
            groupBox1.Controls.Add(btnQueueAdd);
            groupBox1.Controls.Add(lvQueues);
            groupBox1.Location = new Point(305, 18);
            groupBox1.Margin = new Padding(1);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(1);
            groupBox1.Size = new Size(636, 255);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Queues";
            // 
            // btnQueueRemove
            // 
            btnQueueRemove.Location = new Point(336, 211);
            btnQueueRemove.Margin = new Padding(1);
            btnQueueRemove.Name = "btnQueueRemove";
            btnQueueRemove.Size = new Size(119, 30);
            btnQueueRemove.TabIndex = 2;
            btnQueueRemove.Text = "Remove Queue";
            btnQueueRemove.UseVisualStyleBackColor = true;
            btnQueueRemove.Click += btnQueueRemove_Click;
            // 
            // btnQueueAdd
            // 
            btnQueueAdd.Location = new Point(501, 211);
            btnQueueAdd.Margin = new Padding(1);
            btnQueueAdd.Name = "btnQueueAdd";
            btnQueueAdd.Size = new Size(119, 30);
            btnQueueAdd.TabIndex = 1;
            btnQueueAdd.Text = "Add Queue";
            btnQueueAdd.UseVisualStyleBackColor = true;
            btnQueueAdd.Click += btnQueueAdd_Click;
            // 
            // lvQueues
            // 
            lvQueues.Columns.AddRange(new ColumnHeader[] { chQueueAlias, chQueueAddress });
            lvQueues.FullRowSelect = true;
            lvQueues.Location = new Point(9, 25);
            lvQueues.Margin = new Padding(1);
            lvQueues.MultiSelect = false;
            lvQueues.Name = "lvQueues";
            lvQueues.Size = new Size(611, 175);
            lvQueues.TabIndex = 0;
            lvQueues.UseCompatibleStateImageBehavior = false;
            lvQueues.View = View.Details;
            lvQueues.MouseDoubleClick += lvQueues_MouseDoubleClick;
            // 
            // chQueueAlias
            // 
            chQueueAlias.Text = "Alias";
            chQueueAlias.Width = 200;
            // 
            // chQueueAddress
            // 
            chQueueAddress.Text = "Queue";
            chQueueAddress.Width = 450;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 188);
            label5.Margin = new Padding(1, 0, 1, 0);
            label5.Name = "label5";
            label5.Size = new Size(95, 15);
            label5.TabIndex = 10;
            label5.Text = "Queue Manager:";
            // 
            // tbConnQueueManager
            // 
            tbConnQueueManager.Location = new Point(15, 206);
            tbConnQueueManager.Margin = new Padding(1);
            tbConnQueueManager.Name = "tbConnQueueManager";
            tbConnQueueManager.Size = new Size(268, 23);
            tbConnQueueManager.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 101);
            label4.Margin = new Padding(1, 0, 1, 0);
            label4.Name = "label4";
            label4.Size = new Size(32, 15);
            label4.TabIndex = 8;
            label4.Text = "Port:";
            // 
            // tbConnPort
            // 
            tbConnPort.Location = new Point(15, 117);
            tbConnPort.Margin = new Padding(1);
            tbConnPort.Name = "tbConnPort";
            tbConnPort.Size = new Size(69, 23);
            tbConnPort.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 143);
            label3.Margin = new Padding(1, 0, 1, 0);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 6;
            label3.Text = "Channel:";
            // 
            // tbConnChannel
            // 
            tbConnChannel.Location = new Point(15, 159);
            tbConnChannel.Margin = new Padding(1);
            tbConnChannel.Name = "tbConnChannel";
            tbConnChannel.Size = new Size(268, 23);
            tbConnChannel.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 58);
            label2.Margin = new Padding(1, 0, 1, 0);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 4;
            label2.Text = "Host:";
            // 
            // tbConnHost
            // 
            tbConnHost.Location = new Point(15, 74);
            tbConnHost.Margin = new Padding(1);
            tbConnHost.Name = "tbConnHost";
            tbConnHost.Size = new Size(268, 23);
            tbConnHost.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 16);
            label1.Margin = new Padding(1, 0, 1, 0);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 2;
            label1.Text = "Name:";
            // 
            // tbConnName
            // 
            tbConnName.Location = new Point(15, 32);
            tbConnName.Margin = new Padding(1);
            tbConnName.Name = "tbConnName";
            tbConnName.Size = new Size(268, 23);
            tbConnName.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnMessageRemove);
            groupBox2.Controls.Add(btnMessageAdd);
            groupBox2.Controls.Add(lvMessages);
            groupBox2.Location = new Point(10, 380);
            groupBox2.Margin = new Padding(1);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(1);
            groupBox2.Size = new Size(954, 270);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Example Messages";
            // 
            // btnMessageRemove
            // 
            btnMessageRemove.Location = new Point(641, 227);
            btnMessageRemove.Margin = new Padding(1);
            btnMessageRemove.Name = "btnMessageRemove";
            btnMessageRemove.Size = new Size(119, 30);
            btnMessageRemove.TabIndex = 2;
            btnMessageRemove.Text = "Remove Message";
            btnMessageRemove.UseVisualStyleBackColor = true;
            btnMessageRemove.Click += btnMessageRemove_Click;
            // 
            // btnMessageAdd
            // 
            btnMessageAdd.Location = new Point(806, 227);
            btnMessageAdd.Margin = new Padding(1);
            btnMessageAdd.Name = "btnMessageAdd";
            btnMessageAdd.Size = new Size(119, 30);
            btnMessageAdd.TabIndex = 1;
            btnMessageAdd.Text = "Add Message";
            btnMessageAdd.UseVisualStyleBackColor = true;
            btnMessageAdd.Click += btnMessageAdd_Click;
            // 
            // lvMessages
            // 
            lvMessages.Columns.AddRange(new ColumnHeader[] { chMessageAlias, chMessageText });
            lvMessages.FullRowSelect = true;
            lvMessages.Location = new Point(9, 25);
            lvMessages.Margin = new Padding(1);
            lvMessages.MultiSelect = false;
            lvMessages.Name = "lvMessages";
            lvMessages.Size = new Size(916, 190);
            lvMessages.TabIndex = 0;
            lvMessages.UseCompatibleStateImageBehavior = false;
            lvMessages.View = View.Details;
            lvMessages.MouseDoubleClick += lvMessages_MouseDoubleClick;
            // 
            // chMessageAlias
            // 
            chMessageAlias.Text = "Alias";
            chMessageAlias.Width = 200;
            // 
            // chMessageText
            // 
            chMessageText.Text = "Message";
            chMessageText.Width = 450;
            // 
            // ConnectionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(974, 660);
            Controls.Add(groupBox2);
            Controls.Add(gbConnections);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(1);
            MaximizeBox = false;
            MaximumSize = new Size(990, 699);
            MinimumSize = new Size(990, 699);
            Name = "ConnectionForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Connection Settings";
            MouseDoubleClick += ConnectionForm_MouseDoubleClick;
            gbConnections.ResumeLayout(false);
            gbConnections.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbConnections;
        private TextBox tbConnName;
        private Label label1;
        private Label label2;
        private TextBox tbConnHost;
        private Label label5;
        private TextBox tbConnQueueManager;
        private Label label4;
        private TextBox tbConnPort;
        private Label label3;
        private TextBox tbConnChannel;
        private Label label6;
        private TextBox tbConnUser;
        private Label label7;
        private TextBox tbConnPassword;
        private GroupBox groupBox1;
        private ListView lvQueues;
        private Button btnQueueRemove;
        private Button btnQueueAdd;
        private ColumnHeader chQueueAlias;
        private ColumnHeader chQueueAddress;
        private GroupBox groupBox2;
        private Button btnMessageRemove;
        private Button btnMessageAdd;
        private ListView lvMessages;
        private Button btnConnectionCancel;
        private Button btnConnectionSave;
        private ColumnHeader chMessageAlias;
        private ColumnHeader chMessageText;
        private Button btnConnectionTest;
    }
}
