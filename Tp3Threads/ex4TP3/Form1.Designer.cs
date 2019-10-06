namespace ex4TP3
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
            this.textLabel = new System.Windows.Forms.Label();
            this.nombreTimer = new System.Windows.Forms.Timer(this.components);
            this.nombreLabel = new System.Windows.Forms.Label();
            this.startStopButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // textLabel
            // 
            this.textLabel.AutoSize = true;
            this.textLabel.Location = new System.Drawing.Point(173, 32);
            this.textLabel.Name = "textLabel";
            this.textLabel.Size = new System.Drawing.Size(77, 13);
            this.textLabel.TabIndex = 1;
            this.textLabel.Text = "Incrementation";
            // 
            // nombreTimer
            // 
            this.nombreTimer.Interval = 1000;
            this.nombreTimer.Tick += new System.EventHandler(this.numberTimer_Tick);
            // 
            // nombreLabel
            // 
            this.nombreLabel.AutoSize = true;
            this.nombreLabel.Location = new System.Drawing.Point(192, 83);
            this.nombreLabel.Name = "nombreLabel";
            this.nombreLabel.Size = new System.Drawing.Size(13, 13);
            this.nombreLabel.TabIndex = 2;
            this.nombreLabel.Text = "0";
            // 
            // startStopButton
            // 
            this.startStopButton.Location = new System.Drawing.Point(164, 130);
            this.startStopButton.Name = "startStopButton";
            this.startStopButton.Size = new System.Drawing.Size(75, 23);
            this.startStopButton.TabIndex = 3;
            this.startStopButton.Text = "Start";
            this.startStopButton.UseVisualStyleBackColor = true;
            this.startStopButton.Click += new System.EventHandler(this.startStopButton_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 174);
            this.Controls.Add(this.startStopButton);
            this.Controls.Add(this.nombreLabel);
            this.Controls.Add(this.textLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label textLabel;
        private System.Windows.Forms.Timer nombreTimer;
        private System.Windows.Forms.Label nombreLabel;
        private System.Windows.Forms.Button startStopButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

