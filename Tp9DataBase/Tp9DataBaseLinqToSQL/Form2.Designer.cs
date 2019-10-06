namespace Tp9DataBaseLinqToSQL
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
            this.chercherButton.Location = new System.Drawing.Point(370, 74);
            this.chercherButton.Name = "chercherButton";
            this.chercherButton.Size = new System.Drawing.Size(75, 23);
            this.chercherButton.TabIndex = 32;
            this.chercherButton.Text = "Chercher";
            this.chercherButton.UseVisualStyleBackColor = true;
            this.chercherButton.Click += new System.EventHandler(this.chercherButton_Click);
            // 
            // filiereTextBox
            // 
            this.filiereTextBox.Location = new System.Drawing.Point(221, 220);
            this.filiereTextBox.Name = "filiereTextBox";
            this.filiereTextBox.Size = new System.Drawing.Size(121, 20);
            this.filiereTextBox.TabIndex = 31;
            // 
            // prenomTetBox
            // 
            this.prenomTetBox.Location = new System.Drawing.Point(221, 183);
            this.prenomTetBox.Name = "prenomTetBox";
            this.prenomTetBox.Size = new System.Drawing.Size(121, 20);
            this.prenomTetBox.TabIndex = 30;
            // 
            // nomTextBox
            // 
            this.nomTextBox.Location = new System.Drawing.Point(221, 146);
            this.nomTextBox.Name = "nomTextBox";
            this.nomTextBox.Size = new System.Drawing.Size(121, 20);
            this.nomTextBox.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(143, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Filiere";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(143, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Prenom";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(143, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Nom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(143, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Resultat";
            // 
            // cneComboBox
            // 
            this.cneComboBox.FormattingEnabled = true;
            this.cneComboBox.Location = new System.Drawing.Point(221, 76);
            this.cneComboBox.Name = "cneComboBox";
            this.cneComboBox.Size = new System.Drawing.Size(121, 21);
            this.cneComboBox.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "CNE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Rechercher";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 276);
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