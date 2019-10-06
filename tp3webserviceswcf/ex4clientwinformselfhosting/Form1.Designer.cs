namespace ex4clientwinformselfhosting
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
            this.demarrer_button = new System.Windows.Forms.Button();
            this.arreterbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // demarrer_button
            // 
            this.demarrer_button.Location = new System.Drawing.Point(189, 38);
            this.demarrer_button.Name = "demarrer_button";
            this.demarrer_button.Size = new System.Drawing.Size(75, 23);
            this.demarrer_button.TabIndex = 0;
            this.demarrer_button.Text = "Demarrer";
            this.demarrer_button.UseVisualStyleBackColor = true;
            this.demarrer_button.Click += new System.EventHandler(this.demarrer_button_Click);
            // 
            // arreterbutton
            // 
            this.arreterbutton.Location = new System.Drawing.Point(189, 90);
            this.arreterbutton.Name = "arreterbutton";
            this.arreterbutton.Size = new System.Drawing.Size(75, 21);
            this.arreterbutton.TabIndex = 1;
            this.arreterbutton.Text = "arreter";
            this.arreterbutton.UseVisualStyleBackColor = true;
            this.arreterbutton.Click += new System.EventHandler(this.arreterbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 190);
            this.Controls.Add(this.arreterbutton);
            this.Controls.Add(this.demarrer_button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button demarrer_button;
        private System.Windows.Forms.Button arreterbutton;
    }
}

