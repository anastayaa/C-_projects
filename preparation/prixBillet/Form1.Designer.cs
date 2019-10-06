namespace prixBillet
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
            this.label2 = new System.Windows.Forms.Label();
            this.prixTextBox = new System.Windows.Forms.TextBox();
            this.typeListBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.reductionComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.prixHTTextBox = new System.Windows.Forms.TextBox();
            this.TVATextBox = new System.Windows.Forms.TextBox();
            this.prixTCCTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.calculerButton = new System.Windows.Forms.Button();
            this.reinisialiserButton = new System.Windows.Forms.Button();
            this.quiterButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prix de billet";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Type de billet";
            // 
            // prixTextBox
            // 
            this.prixTextBox.Location = new System.Drawing.Point(217, 40);
            this.prixTextBox.Name = "prixTextBox";
            this.prixTextBox.Size = new System.Drawing.Size(145, 20);
            this.prixTextBox.TabIndex = 2;
            // 
            // typeListBox
            // 
            this.typeListBox.FormattingEnabled = true;
            this.typeListBox.Location = new System.Drawing.Point(217, 82);
            this.typeListBox.Name = "typeListBox";
            this.typeListBox.Size = new System.Drawing.Size(145, 56);
            this.typeListBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(126, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Reduction";
            // 
            // reductionComboBox
            // 
            this.reductionComboBox.FormattingEnabled = true;
            this.reductionComboBox.Location = new System.Drawing.Point(217, 157);
            this.reductionComboBox.Name = "reductionComboBox";
            this.reductionComboBox.Size = new System.Drawing.Size(145, 21);
            this.reductionComboBox.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.prixTCCTextBox);
            this.groupBox1.Controls.Add(this.TVATextBox);
            this.groupBox1.Controls.Add(this.prixHTTextBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(129, 199);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(233, 116);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Prix Ht";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "TVA";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Prix TCC";
            // 
            // prixHTTextBox
            // 
            this.prixHTTextBox.Location = new System.Drawing.Point(88, 23);
            this.prixHTTextBox.Name = "prixHTTextBox";
            this.prixHTTextBox.Size = new System.Drawing.Size(120, 20);
            this.prixHTTextBox.TabIndex = 3;
            // 
            // TVATextBox
            // 
            this.TVATextBox.Location = new System.Drawing.Point(88, 52);
            this.TVATextBox.Name = "TVATextBox";
            this.TVATextBox.Size = new System.Drawing.Size(120, 20);
            this.TVATextBox.TabIndex = 4;
            // 
            // prixTCCTextBox
            // 
            this.prixTCCTextBox.Location = new System.Drawing.Point(88, 81);
            this.prixTCCTextBox.Name = "prixTCCTextBox";
            this.prixTCCTextBox.Size = new System.Drawing.Size(120, 20);
            this.prixTCCTextBox.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.quiterButton);
            this.groupBox2.Controls.Add(this.reinisialiserButton);
            this.groupBox2.Controls.Add(this.calculerButton);
            this.groupBox2.Location = new System.Drawing.Point(118, 325);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(246, 53);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // calculerButton
            // 
            this.calculerButton.Location = new System.Drawing.Point(6, 19);
            this.calculerButton.Name = "calculerButton";
            this.calculerButton.Size = new System.Drawing.Size(75, 23);
            this.calculerButton.TabIndex = 0;
            this.calculerButton.Text = "Calculer";
            this.calculerButton.UseVisualStyleBackColor = true;
            this.calculerButton.Click += new System.EventHandler(this.calculerButton_Click);
            // 
            // reinisialiserButton
            // 
            this.reinisialiserButton.Location = new System.Drawing.Point(84, 19);
            this.reinisialiserButton.Name = "reinisialiserButton";
            this.reinisialiserButton.Size = new System.Drawing.Size(75, 23);
            this.reinisialiserButton.TabIndex = 1;
            this.reinisialiserButton.Text = "Reinisialiser";
            this.reinisialiserButton.UseVisualStyleBackColor = true;
            this.reinisialiserButton.Click += new System.EventHandler(this.reinisialiserButton_Click);
            // 
            // quiterButton
            // 
            this.quiterButton.Location = new System.Drawing.Point(163, 19);
            this.quiterButton.Name = "quiterButton";
            this.quiterButton.Size = new System.Drawing.Size(75, 23);
            this.quiterButton.TabIndex = 2;
            this.quiterButton.Text = "Quiter";
            this.quiterButton.UseVisualStyleBackColor = true;
            this.quiterButton.Click += new System.EventHandler(this.quiterButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 396);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.reductionComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.typeListBox);
            this.Controls.Add(this.prixTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox prixTextBox;
        private System.Windows.Forms.ListBox typeListBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox reductionComboBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox prixTCCTextBox;
        private System.Windows.Forms.TextBox TVATextBox;
        private System.Windows.Forms.TextBox prixHTTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button quiterButton;
        private System.Windows.Forms.Button reinisialiserButton;
        private System.Windows.Forms.Button calculerButton;
    }
}

