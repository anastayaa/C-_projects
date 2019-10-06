namespace lampesColorees
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RRadioButton = new System.Windows.Forms.RadioButton();
            this.VRadioButton = new System.Windows.Forms.RadioButton();
            this.BRadioButton = new System.Windows.Forms.RadioButton();
            this.playButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.frequenceTrackBar = new System.Windows.Forms.TrackBar();
            this.frequenceLabel = new System.Windows.Forms.Label();
            this.frequence1slLbel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frequenceTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BRadioButton);
            this.groupBox1.Controls.Add(this.VRadioButton);
            this.groupBox1.Controls.Add(this.RRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(115, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(213, 88);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "La lampes coloree";
            // 
            // RRadioButton
            // 
            this.RRadioButton.AutoSize = true;
            this.RRadioButton.Location = new System.Drawing.Point(14, 29);
            this.RRadioButton.Name = "RRadioButton";
            this.RRadioButton.Size = new System.Drawing.Size(33, 17);
            this.RRadioButton.TabIndex = 0;
            this.RRadioButton.TabStop = true;
            this.RRadioButton.Text = "R";
            this.RRadioButton.UseVisualStyleBackColor = true;
            // 
            // VRadioButton
            // 
            this.VRadioButton.AutoSize = true;
            this.VRadioButton.Location = new System.Drawing.Point(93, 29);
            this.VRadioButton.Name = "VRadioButton";
            this.VRadioButton.Size = new System.Drawing.Size(32, 17);
            this.VRadioButton.TabIndex = 1;
            this.VRadioButton.TabStop = true;
            this.VRadioButton.Text = "V";
            this.VRadioButton.UseVisualStyleBackColor = true;
            // 
            // BRadioButton
            // 
            this.BRadioButton.AutoSize = true;
            this.BRadioButton.Location = new System.Drawing.Point(168, 29);
            this.BRadioButton.Name = "BRadioButton";
            this.BRadioButton.Size = new System.Drawing.Size(32, 17);
            this.BRadioButton.TabIndex = 2;
            this.BRadioButton.TabStop = true;
            this.BRadioButton.Text = "B";
            this.BRadioButton.UseVisualStyleBackColor = true;
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(129, 145);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(75, 23);
            this.playButton.TabIndex = 1;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Enabled = false;
            this.stopButton.Location = new System.Drawing.Point(225, 145);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(75, 23);
            this.stopButton.TabIndex = 2;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // frequenceTrackBar
            // 
            this.frequenceTrackBar.Location = new System.Drawing.Point(122, 185);
            this.frequenceTrackBar.Name = "frequenceTrackBar";
            this.frequenceTrackBar.Size = new System.Drawing.Size(200, 45);
            this.frequenceTrackBar.TabIndex = 3;
            this.frequenceTrackBar.Scroll += new System.EventHandler(this.frequenceTrackBar_Scroll);
            // 
            // frequenceLabel
            // 
            this.frequenceLabel.AutoSize = true;
            this.frequenceLabel.Location = new System.Drawing.Point(43, 187);
            this.frequenceLabel.Name = "frequenceLabel";
            this.frequenceLabel.Size = new System.Drawing.Size(80, 13);
            this.frequenceLabel.TabIndex = 4;
            this.frequenceLabel.Text = "Frequence 0ms";
            // 
            // frequence1slLbel
            // 
            this.frequence1slLbel.AutoSize = true;
            this.frequence1slLbel.Location = new System.Drawing.Point(321, 188);
            this.frequence1slLbel.Name = "frequence1slLbel";
            this.frequence1slLbel.Size = new System.Drawing.Size(18, 13);
            this.frequence1slLbel.TabIndex = 5;
            this.frequence1slLbel.Text = "1s";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 242);
            this.Controls.Add(this.frequence1slLbel);
            this.Controls.Add(this.frequenceLabel);
            this.Controls.Add(this.frequenceTrackBar);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frequenceTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton BRadioButton;
        private System.Windows.Forms.RadioButton VRadioButton;
        private System.Windows.Forms.RadioButton RRadioButton;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.TrackBar frequenceTrackBar;
        private System.Windows.Forms.Label frequenceLabel;
        private System.Windows.Forms.Label frequence1slLbel;
        private System.Windows.Forms.Timer timer1;
    }
}

