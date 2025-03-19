namespace IbmMQTestApp.Forms
{
    partial class AliasTextForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AliasTextForm));
            groupBox1 = new GroupBox();
            label2 = new Label();
            tbText = new TextBox();
            label1 = new Label();
            tbAlias = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(tbText);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(tbAlias);
            groupBox1.Location = new Point(14, 9);
            groupBox1.Margin = new Padding(1);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(1);
            groupBox1.Size = new Size(950, 302);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Data";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 83);
            label2.Margin = new Padding(1, 0, 1, 0);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 6;
            label2.Text = "Text:";
            // 
            // tbText
            // 
            tbText.Location = new Point(11, 109);
            tbText.Margin = new Padding(1);
            tbText.Multiline = true;
            tbText.Name = "tbText";
            tbText.Size = new Size(924, 177);
            tbText.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 21);
            label1.Margin = new Padding(1, 0, 1, 0);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 4;
            label1.Text = "Alias:";
            // 
            // tbAlias
            // 
            tbAlias.Location = new Point(11, 37);
            tbAlias.Margin = new Padding(1);
            tbAlias.Name = "tbAlias";
            tbAlias.Size = new Size(311, 23);
            tbAlias.TabIndex = 3;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(844, 324);
            btnSave.Margin = new Padding(1);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(120, 30);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(702, 324);
            btnCancel.Margin = new Padding(1);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(120, 30);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // AliasTextForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(974, 364);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(1);
            MaximizeBox = false;
            MaximumSize = new Size(990, 403);
            MinimizeBox = false;
            MinimumSize = new Size(990, 403);
            Name = "AliasTextForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Insert Values";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private TextBox tbText;
        private Label label1;
        private TextBox tbAlias;
        private Button btnSave;
        private Button btnCancel;
    }
}