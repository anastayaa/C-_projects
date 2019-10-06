namespace Tp9DataBaseDeconnecteEx1
{
    partial class Form2
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
            this.chercherButton = new System.Windows.Forms.Button();
            this.filiereTextBox = new System.Windows.Forms.TextBox();
            this.prenomTetBox = new System.Windows.Forms.TextBox();
            this.nomTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cneComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chercherButton
            // 
            this.chercherButton.Location = new System.Drawing.Point(361, 69);
            this.chercherButton.Name = "chercherButton";
            this.chercherButton.Size = new System.Drawing.Size(75, 23);
            this.chercherButton.TabIndex = 21;
            this.chercherButton.Text = "Chercher";
            this.chercherButton.UseVisualStyleBackColor = true;
            this.chercherButton.Click += new System.EventHandler(this.chercherButton_Click);
            // 
            // filiereTextBox
            // 
            this.filiereTextBox.Location = new System.Drawing.Point(212, 215);
            this.filiereTextBox.Name = "filiereTextBox";
            this.filiereTextBox.Size = new System.Drawing.Size(121, 20);
            this.filiereTextBox.TabIndex = 20;
            // 
            // prenomTetBox
            // 
            this.prenomTetBox.Location = new System.Drawing.Point(212, 178);
            this.prenomTetBox.Name = "prenomTetBox";
            this.prenomTetBox.Size = new System.Drawing.Size(121, 20);
            this.prenomTetBox.TabIndex = 19;
            // 
            // nomTextBox
            // 
            this.nomTextBox.Location = new System.Drawing.Point(212, 141);
            this.nomTextBox.Name = "nomTextBox";
            this.nomTextBox.Size = new System.Drawing.Size(121, 20);
            this.nomTextBox.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(134, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Filiere";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(134, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Prenom";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(134, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Nom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(134, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Resultat";
            // 
            // cneComboBox
            // 
            this.cneComboBox.FormattingEnabled = true;
            this.cneComboBox.Location = new System.Drawing.Point(212, 71);
            this.cneComboBox.Name = "cneComboBox";
            this.cneComboBox.Size = new System.Drawing.Size(121, 21);
            this.cneComboBox.TabIndex = 13;
            this.cneComboBox.SelectedIndexChanged += new System.EventHandler(this.cneComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "CNE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Rechercher";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 280);
            this.Controls.Add(this.chercherButton);
            this.Controls.Add(this.filiereTextBox);
            this.Controls.Add(this.prenomTetBox);
            this.Controls.Add(this.nomTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cneComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button chercherButton;
        private System.Windows.Forms.TextBox filiereTextBox;
        private System.Windows.Forms.TextBox prenomTetBox;
        private System.Windows.Forms.TextBox nomTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cneComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}