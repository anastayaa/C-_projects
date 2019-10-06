namespace calculetteClient
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
            this.pseudo = new System.Windows.Forms.TextBox();
            this.connectionButton = new System.Windows.Forms.Button();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.calculerButton = new System.Windows.Forms.Button();
            this.operaionEffectuer = new System.Windows.Forms.ListBox();
            this.resultatEleveichBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // pseudo
            // 
            this.pseudo.Location = new System.Drawing.Point(128, 23);
            this.pseudo.Name = "pseudo";
            this.pseudo.Size = new System.Drawing.Size(175, 20);
            this.pseudo.TabIndex = 6;
            // 
            // connectionButton
            // 
            this.connectionButton.Location = new System.Drawing.Point(349, 20);
            this.connectionButton.Name = "connectionButton";
            this.connectionButton.Size = new System.Drawing.Size(75, 23);
            this.connectionButton.TabIndex = 7;
            this.connectionButton.Text = "Connexion";
            this.connectionButton.UseVisualStyleBackColor = true;
            this.connectionButton.Click += new System.EventHandler(this.connectionButton_Click);
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.Location = new System.Drawing.Point(128, 51);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(175, 20);
            this.nombreTextBox.TabIndex = 8;
            // 
            // calculerButton
            // 
            this.calculerButton.Location = new System.Drawing.Point(349, 51);
            this.calculerButton.Name = "calculerButton";
            this.calculerButton.Size = new System.Drawing.Size(75, 23);
            this.calculerButton.TabIndex = 9;
            this.calculerButton.Text = "Calculer";
            this.calculerButton.UseVisualStyleBackColor = true;
            this.calculerButton.Click += new System.EventHandler(this.calculerButton_Click);
            // 
            // operaionEffectuer
            // 
            this.operaionEffectuer.FormattingEnabled = true;
            this.operaionEffectuer.Location = new System.Drawing.Point(371, 112);
            this.operaionEffectuer.Name = "operaionEffectuer";
            this.operaionEffectuer.Size = new System.Drawing.Size(156, 121);
            this.operaionEffectuer.TabIndex = 10;
            // 
            // resultatEleveichBox
            // 
            this.resultatEleveichBox.Location = new System.Drawing.Point(77, 112);
            this.resultatEleveichBox.Name = "resultatEleveichBox";
            this.resultatEleveichBox.Size = new System.Drawing.Size(175, 121);
            this.resultatEleveichBox.TabIndex = 11;
            this.resultatEleveichBox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 262);
            this.Controls.Add(this.resultatEleveichBox);
            this.Controls.Add(this.operaionEffectuer);
            this.Controls.Add(this.calculerButton);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(this.connectionButton);
            this.Controls.Add(this.pseudo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox pseudo;
        private System.Windows.Forms.Button connectionButton;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.Button calculerButton;
        private System.Windows.Forms.ListBox operaionEffectuer;
        private System.Windows.Forms.RichTextBox resultatEleveichBox;
    }
}

