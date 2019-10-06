namespace interfaceInscription
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
            this.nomPrenomTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.label3 = new System.Windows.Forms.Label();
            this.adresseRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ajouterButton = new System.Windows.Forms.Button();
            this.annulerButton = new System.Windows.Forms.Button();
            this.viderButton = new System.Windows.Forms.Button();
            this.personneListBox = new System.Windows.Forms.ListBox();
            this.telephoneTextBox = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom et prenom";
            // 
            // nomPrenomTextBox
            // 
            this.nomPrenomTextBox.Location = new System.Drawing.Point(135, 41);
            this.nomPrenomTextBox.Name = "nomPrenomTextBox";
            this.nomPrenomTextBox.Size = new System.Drawing.Size(226, 20);
            this.nomPrenomTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Date d\'inscription";
            // 
            // monthCalendar
            // 
            this.monthCalendar.Location = new System.Drawing.Point(134, 87);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Adresse";
            // 
            // adresseRichTextBox
            // 
            this.adresseRichTextBox.Location = new System.Drawing.Point(134, 275);
            this.adresseRichTextBox.Name = "adresseRichTextBox";
            this.adresseRichTextBox.Size = new System.Drawing.Size(227, 77);
            this.adresseRichTextBox.TabIndex = 5;
            this.adresseRichTextBox.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 378);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Telephone";
            // 
            // ajouterButton
            // 
            this.ajouterButton.Location = new System.Drawing.Point(125, 417);
            this.ajouterButton.Name = "ajouterButton";
            this.ajouterButton.Size = new System.Drawing.Size(75, 23);
            this.ajouterButton.TabIndex = 8;
            this.ajouterButton.Text = "Ajouter";
            this.ajouterButton.UseVisualStyleBackColor = true;
            this.ajouterButton.Click += new System.EventHandler(this.ajouterButton_Click);
            // 
            // annulerButton
            // 
            this.annulerButton.Location = new System.Drawing.Point(206, 417);
            this.annulerButton.Name = "annulerButton";
            this.annulerButton.Size = new System.Drawing.Size(75, 23);
            this.annulerButton.TabIndex = 9;
            this.annulerButton.Text = "Annuler";
            this.annulerButton.UseVisualStyleBackColor = true;
            this.annulerButton.Click += new System.EventHandler(this.annulerButton_Click);
            // 
            // viderButton
            // 
            this.viderButton.Location = new System.Drawing.Point(287, 417);
            this.viderButton.Name = "viderButton";
            this.viderButton.Size = new System.Drawing.Size(75, 23);
            this.viderButton.TabIndex = 10;
            this.viderButton.Text = "Vider";
            this.viderButton.UseVisualStyleBackColor = true;
            this.viderButton.Click += new System.EventHandler(this.viderButton_Click);
            // 
            // personneListBox
            // 
            this.personneListBox.FormattingEnabled = true;
            this.personneListBox.Location = new System.Drawing.Point(125, 459);
            this.personneListBox.Name = "personneListBox";
            this.personneListBox.Size = new System.Drawing.Size(237, 95);
            this.personneListBox.TabIndex = 11;
            // 
            // telephoneTextBox
            // 
            this.telephoneTextBox.Location = new System.Drawing.Point(134, 371);
            this.telephoneTextBox.Name = "telephoneTextBox";
            this.telephoneTextBox.Size = new System.Drawing.Size(227, 20);
            this.telephoneTextBox.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 579);
            this.Controls.Add(this.telephoneTextBox);
            this.Controls.Add(this.personneListBox);
            this.Controls.Add(this.viderButton);
            this.Controls.Add(this.annulerButton);
            this.Controls.Add(this.ajouterButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.adresseRichTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.monthCalendar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nomPrenomTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nomPrenomTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox adresseRichTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ajouterButton;
        private System.Windows.Forms.Button annulerButton;
        private System.Windows.Forms.Button viderButton;
        private System.Windows.Forms.ListBox personneListBox;
        private System.Windows.Forms.MaskedTextBox telephoneTextBox;
    }
}

