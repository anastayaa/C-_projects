namespace chronometre
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
            this.tourListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.demarrerButton = new System.Windows.Forms.Button();
            this.arreterButton = new System.Windows.Forms.Button();
            this.effacerButton = new System.Windows.Forms.Button();
            this.tourButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.minuteLabel = new System.Windows.Forms.Label();
            this.secondeLabel = new System.Windows.Forms.Label();
            this.centiemeSecondeLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tourListBox
            // 
            this.tourListBox.FormattingEnabled = true;
            this.tourListBox.Location = new System.Drawing.Point(403, 50);
            this.tourListBox.Name = "tourListBox";
            this.tourListBox.Size = new System.Drawing.Size(120, 160);
            this.tourListBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(401, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Captures";
            // 
            // demarrerButton
            // 
            this.demarrerButton.Location = new System.Drawing.Point(34, 178);
            this.demarrerButton.Name = "demarrerButton";
            this.demarrerButton.Size = new System.Drawing.Size(75, 23);
            this.demarrerButton.TabIndex = 2;
            this.demarrerButton.Text = "Demarrer";
            this.demarrerButton.UseVisualStyleBackColor = true;
            this.demarrerButton.Click += new System.EventHandler(this.demarrerButton_Click);
            // 
            // arreterButton
            // 
            this.arreterButton.Location = new System.Drawing.Point(126, 178);
            this.arreterButton.Name = "arreterButton";
            this.arreterButton.Size = new System.Drawing.Size(75, 23);
            this.arreterButton.TabIndex = 3;
            this.arreterButton.Text = "Arreter";
            this.arreterButton.UseVisualStyleBackColor = true;
            this.arreterButton.Click += new System.EventHandler(this.arreterButton_Click);
            // 
            // effacerButton
            // 
            this.effacerButton.Location = new System.Drawing.Point(222, 178);
            this.effacerButton.Name = "effacerButton";
            this.effacerButton.Size = new System.Drawing.Size(75, 23);
            this.effacerButton.TabIndex = 4;
            this.effacerButton.Text = "Effacer";
            this.effacerButton.UseVisualStyleBackColor = true;
            this.effacerButton.Click += new System.EventHandler(this.effacerButton_Click);
            // 
            // tourButton
            // 
            this.tourButton.Location = new System.Drawing.Point(312, 178);
            this.tourButton.Name = "tourButton";
            this.tourButton.Size = new System.Drawing.Size(75, 23);
            this.tourButton.TabIndex = 5;
            this.tourButton.Text = "Tour";
            this.tourButton.UseVisualStyleBackColor = true;
            this.tourButton.Click += new System.EventHandler(this.tourButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(24, 145);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(373, 67);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.centiemeSecondeLabel);
            this.groupBox2.Controls.Add(this.secondeLabel);
            this.groupBox2.Controls.Add(this.minuteLabel);
            this.groupBox2.Location = new System.Drawing.Point(62, 34);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(296, 101);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // minuteLabel
            // 
            this.minuteLabel.AutoSize = true;
            this.minuteLabel.Location = new System.Drawing.Point(38, 47);
            this.minuteLabel.Name = "minuteLabel";
            this.minuteLabel.Size = new System.Drawing.Size(19, 13);
            this.minuteLabel.TabIndex = 0;
            this.minuteLabel.Text = "00";
            // 
            // secondeLabel
            // 
            this.secondeLabel.AutoSize = true;
            this.secondeLabel.Location = new System.Drawing.Point(135, 47);
            this.secondeLabel.Name = "secondeLabel";
            this.secondeLabel.Size = new System.Drawing.Size(19, 13);
            this.secondeLabel.TabIndex = 1;
            this.secondeLabel.Text = "00";
            // 
            // centiemeSecondeLabel
            // 
            this.centiemeSecondeLabel.AutoSize = true;
            this.centiemeSecondeLabel.Location = new System.Drawing.Point(229, 47);
            this.centiemeSecondeLabel.Name = "centiemeSecondeLabel";
            this.centiemeSecondeLabel.Size = new System.Drawing.Size(19, 13);
            this.centiemeSecondeLabel.TabIndex = 2;
            this.centiemeSecondeLabel.Text = "00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(91, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(10, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = ":";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(185, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(10, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = ":";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 237);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tourButton);
            this.Controls.Add(this.effacerButton);
            this.Controls.Add(this.arreterButton);
            this.Controls.Add(this.demarrerButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tourListBox);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox tourListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button demarrerButton;
        private System.Windows.Forms.Button arreterButton;
        private System.Windows.Forms.Button effacerButton;
        private System.Windows.Forms.Button tourButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label centiemeSecondeLabel;
        private System.Windows.Forms.Label secondeLabel;
        private System.Windows.Forms.Label minuteLabel;
        private System.Windows.Forms.Timer timer1;
    }
}

