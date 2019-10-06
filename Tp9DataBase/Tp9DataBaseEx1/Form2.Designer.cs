namespace Tp9DataBaseEx1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cneComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nomTextBox = new System.Windows.Forms.TextBox();
            this.prenomTetBox = new System.Windows.Forms.TextBox();
            this.filiereTextBox = new System.Windows.Forms.TextBox();
            this.chercherButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rechercher";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "CNE";
            // 
            // cneComboBox
            // 
            this.cneComboBox.FormattingEnabled = true;
            this.cneComboBox.Location = new System.Drawing.Point(237, 62);
            this.cneComboBox.Name = "cneComboBox";
            this.cneComboBox.Size = new System.Drawing.Size(121, 21);
            this.cneComboBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(159, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Resultat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(159, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nom";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(159, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Prenom";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(159, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Filiere";
            // 
            // nomTextBox
            // 
            this.nomTextBox.Location = new System.Drawing.Point(237, 132);
            this.nomTextBox.Name = "nomTextBox";
            this.nomTextBox.Size = new System.Drawing.Size(121, 20);
            this.nomTextBox.TabIndex = 7;
            // 
            // prenomTetBox
            // 
            this.prenomTetBox.Location = new System.Drawing.Point(237, 169);
            this.prenomTetBox.Name = "prenomTetBox";
            this.prenomTetBox.Size = new System.Drawing.Size(121, 20);
            this.prenomTetBox.TabIndex = 8;
            // 
            // filiereTextBox
            // 
            this.filiereTextBox.Location = new System.Drawing.Point(237, 206);
            this.filiereTextBox.Name = "filiereTextBox";
            this.filiereTextBox.Size = new System.Drawing.Size(121, 20);
            this.filiereTextBox.TabIndex = 9;
            // 
            // chercherButton
            // 
            this.chercherButton.Location = new System.Drawing.Point(386, 60);
            this.chercherButton.Name = "chercherButton";
            this.chercherButton.Size = new System.Drawing.Size(75, 23);
            this.chercherButton.TabIndex = 10;
            this.chercherButton.Text = "Chercher";
            this.chercherButton.UseVisualStyleBackColor = true;
            this.chercherButton.Click += new System.EventHandler(this.chercherButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 272);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cneComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox nomTextBox;
        private System.Windows.Forms.TextBox prenomTetBox;
        private System.Windows.Forms.TextBox filiereTextBox;
        private System.Windows.Forms.Button chercherButton;
    }
}