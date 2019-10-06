namespace Tp8RemotingEx2Client
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
            this.label1 = new System.Windows.Forms.Label();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.DevinerButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.resultatTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nbTentativesTextBox = new System.Windows.Forms.TextBox();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.scoreButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Deviner le nombre";
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.Location = new System.Drawing.Point(181, 20);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(118, 20);
            this.nombreTextBox.TabIndex = 1;
            // 
            // DevinerButton
            // 
            this.DevinerButton.Location = new System.Drawing.Point(360, 17);
            this.DevinerButton.Name = "DevinerButton";
            this.DevinerButton.Size = new System.Drawing.Size(75, 23);
            this.DevinerButton.TabIndex = 2;
            this.DevinerButton.Text = "Deviner";
            this.DevinerButton.UseVisualStyleBackColor = true;
            this.DevinerButton.Click += new System.EventHandler(this.DevinerButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Resultat";
            // 
            // resultatTextBox
            // 
            this.resultatTextBox.Location = new System.Drawing.Point(181, 75);
            this.resultatTextBox.Name = "resultatTextBox";
            this.resultatTextBox.Size = new System.Drawing.Size(118, 20);
            this.resultatTextBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nombre de tentatives";
            // 
            // nbTentativesTextBox
            // 
            this.nbTentativesTextBox.Location = new System.Drawing.Point(181, 134);
            this.nbTentativesTextBox.Name = "nbTentativesTextBox";
            this.nbTentativesTextBox.Size = new System.Drawing.Size(118, 20);
            this.nbTentativesTextBox.TabIndex = 6;
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Location = new System.Drawing.Point(178, 203);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(0, 13);
            this.scoreLabel.TabIndex = 7;
            // 
            // scoreButton
            // 
            this.scoreButton.Location = new System.Drawing.Point(56, 193);
            this.scoreButton.Name = "scoreButton";
            this.scoreButton.Size = new System.Drawing.Size(75, 23);
            this.scoreButton.TabIndex = 8;
            this.scoreButton.Text = "Score";
            this.scoreButton.UseVisualStyleBackColor = true;
            this.scoreButton.Click += new System.EventHandler(this.scoreButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 251);
            this.Controls.Add(this.scoreButton);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.nbTentativesTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.resultatTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DevinerButton);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.Button DevinerButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox resultatTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nbTentativesTextBox;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Button scoreButton;
    }
}

