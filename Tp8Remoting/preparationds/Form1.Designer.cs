namespace preparationds
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
            this.prenomTetBox = new System.Windows.Forms.TextBox();
            this.nomTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cneComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ajouterButton = new System.Windows.Forms.Button();
            this.modifierButton = new System.Windows.Forms.Button();
            this.supprimerButton = new System.Windows.Forms.Button();
            this.validerAjoutButton = new System.Windows.Forms.Button();
            this.validerModification = new System.Windows.Forms.Button();
            this.filiereComboBox = new System.Windows.Forms.ComboBox();
            this.dateNaissanceDateTime = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // prenomTetBox
            // 
            this.prenomTetBox.Location = new System.Drawing.Point(169, 141);
            this.prenomTetBox.Name = "prenomTetBox";
            this.prenomTetBox.Size = new System.Drawing.Size(121, 20);
            this.prenomTetBox.TabIndex = 19;
            // 
            // nomTextBox
            // 
            this.nomTextBox.Location = new System.Drawing.Point(169, 104);
            this.nomTextBox.Name = "nomTextBox";
            this.nomTextBox.Size = new System.Drawing.Size(121, 20);
            this.nomTextBox.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(91, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Filiere";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(91, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Prenom";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(91, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Nom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Resultat";
            // 
            // cneComboBox
            // 
            this.cneComboBox.FormattingEnabled = true;
            this.cneComboBox.Location = new System.Drawing.Point(169, 34);
            this.cneComboBox.Name = "cneComboBox";
            this.cneComboBox.Size = new System.Drawing.Size(121, 21);
            this.cneComboBox.TabIndex = 13;
            this.cneComboBox.SelectedIndexChanged += new System.EventHandler(this.cneComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "CNE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Rechercher";
            // 
            // ajouterButton
            // 
            this.ajouterButton.Location = new System.Drawing.Point(323, 101);
            this.ajouterButton.Name = "ajouterButton";
            this.ajouterButton.Size = new System.Drawing.Size(75, 23);
            this.ajouterButton.TabIndex = 21;
            this.ajouterButton.Text = "Ajouter";
            this.ajouterButton.UseVisualStyleBackColor = true;
            this.ajouterButton.Click += new System.EventHandler(this.ajouterButton_Click);
            // 
            // modifierButton
            // 
            this.modifierButton.Location = new System.Drawing.Point(323, 139);
            this.modifierButton.Name = "modifierButton";
            this.modifierButton.Size = new System.Drawing.Size(75, 23);
            this.modifierButton.TabIndex = 22;
            this.modifierButton.Text = "Modifier";
            this.modifierButton.UseVisualStyleBackColor = true;
            this.modifierButton.Click += new System.EventHandler(this.modifierButton_Click);
            // 
            // supprimerButton
            // 
            this.supprimerButton.Location = new System.Drawing.Point(323, 175);
            this.supprimerButton.Name = "supprimerButton";
            this.supprimerButton.Size = new System.Drawing.Size(75, 23);
            this.supprimerButton.TabIndex = 23;
            this.supprimerButton.Text = "Supprimer";
            this.supprimerButton.UseVisualStyleBackColor = true;
            // 
            // validerAjoutButton
            // 
            this.validerAjoutButton.Location = new System.Drawing.Point(94, 219);
            this.validerAjoutButton.Name = "validerAjoutButton";
            this.validerAjoutButton.Size = new System.Drawing.Size(95, 23);
            this.validerAjoutButton.TabIndex = 24;
            this.validerAjoutButton.Text = "Valider l\'jout";
            this.validerAjoutButton.UseVisualStyleBackColor = true;
            this.validerAjoutButton.Click += new System.EventHandler(this.validerAjoutButton_Click);
            // 
            // validerModification
            // 
            this.validerModification.Location = new System.Drawing.Point(195, 219);
            this.validerModification.Name = "validerModification";
            this.validerModification.Size = new System.Drawing.Size(114, 23);
            this.validerModification.TabIndex = 25;
            this.validerModification.Text = "Valider modification";
            this.validerModification.UseVisualStyleBackColor = true;
            // 
            // filiereComboBox
            // 
            this.filiereComboBox.FormattingEnabled = true;
            this.filiereComboBox.Location = new System.Drawing.Point(169, 182);
            this.filiereComboBox.Name = "filiereComboBox";
            this.filiereComboBox.Size = new System.Drawing.Size(121, 21);
            this.filiereComboBox.TabIndex = 26;
            // 
            // dateNaissanceDateTime
            // 
            this.dateNaissanceDateTime.Location = new System.Drawing.Point(169, 75);
            this.dateNaissanceDateTime.Name = "dateNaissanceDateTime";
            this.dateNaissanceDateTime.Size = new System.Drawing.Size(121, 20);
            this.dateNaissanceDateTime.TabIndex = 27;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 268);
            this.Controls.Add(this.dateNaissanceDateTime);
            this.Controls.Add(this.filiereComboBox);
            this.Controls.Add(this.validerModification);
            this.Controls.Add(this.validerAjoutButton);
            this.Controls.Add(this.supprimerButton);
            this.Controls.Add(this.modifierButton);
            this.Controls.Add(this.ajouterButton);
            this.Controls.Add(this.prenomTetBox);
            this.Controls.Add(this.nomTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cneComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox prenomTetBox;
        private System.Windows.Forms.TextBox nomTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cneComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ajouterButton;
        private System.Windows.Forms.Button modifierButton;
        private System.Windows.Forms.Button supprimerButton;
        private System.Windows.Forms.Button validerAjoutButton;
        private System.Windows.Forms.Button validerModification;
        private System.Windows.Forms.ComboBox filiereComboBox;
        private System.Windows.Forms.DateTimePicker dateNaissanceDateTime;
    }
}

