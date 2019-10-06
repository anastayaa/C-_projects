namespace ex3TP4
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.IPLabelSender = new System.Windows.Forms.Label();
            this.PortLabelSender = new System.Windows.Forms.Label();
            this.IPTextBoxSender = new System.Windows.Forms.TextBox();
            this.PortTextBoxSender = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.portTextBoxReceiver = new System.Windows.Forms.TextBox();
            this.IPTextBoxReceiver = new System.Windows.Forms.TextBox();
            this.PortLabelReceiver = new System.Windows.Forms.Label();
            this.IPLabelReceiver = new System.Windows.Forms.Label();
            this.connectButton = new System.Windows.Forms.Button();
            this.messageTextBox = new System.Windows.Forms.TextBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.messagesListBox = new System.Windows.Forms.ListBox();
            this.messagesReceiverListBox = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // IPLabelSender
            // 
            this.IPLabelSender.AutoSize = true;
            this.IPLabelSender.Location = new System.Drawing.Point(54, 62);
            this.IPLabelSender.Name = "IPLabelSender";
            this.IPLabelSender.Size = new System.Drawing.Size(17, 13);
            this.IPLabelSender.TabIndex = 0;
            this.IPLabelSender.Text = "IP";
            // 
            // PortLabelSender
            // 
            this.PortLabelSender.AutoSize = true;
            this.PortLabelSender.Location = new System.Drawing.Point(54, 95);
            this.PortLabelSender.Name = "PortLabelSender";
            this.PortLabelSender.Size = new System.Drawing.Size(26, 13);
            this.PortLabelSender.TabIndex = 1;
            this.PortLabelSender.Text = "Port";
            // 
            // IPTextBoxSender
            // 
            this.IPTextBoxSender.Location = new System.Drawing.Point(92, 62);
            this.IPTextBoxSender.Name = "IPTextBoxSender";
            this.IPTextBoxSender.Size = new System.Drawing.Size(127, 20);
            this.IPTextBoxSender.TabIndex = 2;
            // 
            // PortTextBoxSender
            // 
            this.PortTextBoxSender.Location = new System.Drawing.Point(92, 95);
            this.PortTextBoxSender.Name = "PortTextBoxSender";
            this.PortTextBoxSender.Size = new System.Drawing.Size(127, 20);
            this.PortTextBoxSender.TabIndex = 3;
            // 
            // portTextBoxReceiver
            // 
            this.portTextBoxReceiver.Location = new System.Drawing.Point(303, 95);
            this.portTextBoxReceiver.Name = "portTextBoxReceiver";
            this.portTextBoxReceiver.Size = new System.Drawing.Size(127, 20);
            this.portTextBoxReceiver.TabIndex = 8;
            // 
            // IPTextBoxReceiver
            // 
            this.IPTextBoxReceiver.Location = new System.Drawing.Point(303, 62);
            this.IPTextBoxReceiver.Name = "IPTextBoxReceiver";
            this.IPTextBoxReceiver.Size = new System.Drawing.Size(127, 20);
            this.IPTextBoxReceiver.TabIndex = 7;
            // 
            // PortLabelReceiver
            // 
            this.PortLabelReceiver.AutoSize = true;
            this.PortLabelReceiver.Location = new System.Drawing.Point(265, 95);
            this.PortLabelReceiver.Name = "PortLabelReceiver";
            this.PortLabelReceiver.Size = new System.Drawing.Size(26, 13);
            this.PortLabelReceiver.TabIndex = 6;
            this.PortLabelReceiver.Text = "Port";
            // 
            // IPLabelReceiver
            // 
            this.IPLabelReceiver.AutoSize = true;
            this.IPLabelReceiver.Location = new System.Drawing.Point(265, 62);
            this.IPLabelReceiver.Name = "IPLabelReceiver";
            this.IPLabelReceiver.Size = new System.Drawing.Size(17, 13);
            this.IPLabelReceiver.TabIndex = 5;
            this.IPLabelReceiver.Text = "IP";
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(460, 76);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(75, 23);
            this.connectButton.TabIndex = 10;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // messageTextBox
            // 
            this.messageTextBox.Location = new System.Drawing.Point(57, 312);
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.Size = new System.Drawing.Size(384, 20);
            this.messageTextBox.TabIndex = 12;
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(460, 310);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(75, 23);
            this.sendButton.TabIndex = 13;
            this.sendButton.Text = "Send";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox1.Location = new System.Drawing.Point(54, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(192, 100);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Moi";
            // 
            // groupBox2
            // 
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox2.Location = new System.Drawing.Point(216, -2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Amis";
            // 
            // groupBox3
            // 
            this.groupBox3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox3.Location = new System.Drawing.Point(265, 26);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(188, 100);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Amis";
            // 
            // messagesListBox
            // 
            this.messagesListBox.FormattingEnabled = true;
            this.messagesListBox.Location = new System.Drawing.Point(54, 136);
            this.messagesListBox.Name = "messagesListBox";
            this.messagesListBox.Size = new System.Drawing.Size(237, 160);
            this.messagesListBox.TabIndex = 16;
            // 
            // messagesReceiverListBox
            // 
            this.messagesReceiverListBox.FormattingEnabled = true;
            this.messagesReceiverListBox.Location = new System.Drawing.Point(303, 137);
            this.messagesReceiverListBox.Name = "messagesReceiverListBox";
            this.messagesReceiverListBox.Size = new System.Drawing.Size(232, 160);
            this.messagesReceiverListBox.TabIndex = 17;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(8, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 357);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.messagesReceiverListBox);
            this.Controls.Add(this.messagesListBox);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.messageTextBox);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.portTextBoxReceiver);
            this.Controls.Add(this.IPTextBoxReceiver);
            this.Controls.Add(this.PortLabelReceiver);
            this.Controls.Add(this.IPLabelReceiver);
            this.Controls.Add(this.PortTextBoxSender);
            this.Controls.Add(this.IPTextBoxSender);
            this.Controls.Add(this.PortLabelSender);
            this.Controls.Add(this.IPLabelSender);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Name = "Form1";
            this.Text = "Just CHAT";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IPLabelSender;
        private System.Windows.Forms.Label PortLabelSender;
        private System.Windows.Forms.TextBox IPTextBoxSender;
        private System.Windows.Forms.TextBox PortTextBoxSender;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox portTextBoxReceiver;
        private System.Windows.Forms.TextBox IPTextBoxReceiver;
        private System.Windows.Forms.Label PortLabelReceiver;
        private System.Windows.Forms.Label IPLabelReceiver;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.TextBox messageTextBox;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox messagesListBox;
        private System.Windows.Forms.ListBox messagesReceiverListBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

