namespace Tp8RemotingEx1Client
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
            this.nombre1Label = new System.Windows.Forms.Label();
            this.nombre2Label = new System.Windows.Forms.Label();
            this.operationComboBox = new System.Windows.Forms.ComboBox();
            this.nombre1TextBox = new System.Windows.Forms.TextBox();
            this.nombre2TextBox = new System.Windows.Forms.TextBox();
            this.resultatTextBox = new System.Windows.Forms.TextBox();
            this.calculButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nombreIncrementTextBox = new System.Windows.Forms.TextBox();
            this.incrementButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nombre1Label
            // 
            this.nombre1Label.AutoSize = true;
            this.nombre1Label.Location = new System.Drawing.Point(56, 25);
            this.nombre1Label.Name = "nombre1Label";
            this.nombre1Label.Size = new System.Drawing.Size(53, 13);
            this.nombre1Label.TabIndex = 0;
            this.nombre1Label.Text = "Nombre 1";
            // 
            // nombre2Label
            // 
            this.nombre2Label.AutoSize = true;
            this.nombre2Label.Location = new System.Drawing.Point(56, 75);
            this.nombre2Label.Name = "nombre2Label";
            this.nombre2Label.Size = new System.Drawing.Size(53, 13);
            this.nombre2Label.TabIndex = 1;
            this.nombre2Label.Text = "Nombre 2";
            // 
            // operationComboBox
            // 
            this.operationComboBox.FormattingEnabled = true;
            this.operationComboBox.Location = new System.Drawing.Point(59, 114);
            this.operationComboBox.Name = "operationComboBox";
            this.operationComboBox.Size = new System.Drawing.Size(50, 21);
            this.operationComboBox.TabIndex = 2;
            // 
            // nombre1TextBox
            // 
            this.nombre1TextBox.Location = new System.Drawing.Point(188, 18);
            this.nombre1TextBox.Name = "nombre1TextBox";
            this.nombre1TextBox.Size = new System.Drawing.Size(129, 20);
            this.nombre1TextBox.TabIndex = 3;
            // 
            // nombre2TextBox
            // 
            this.nombre2TextBox.Location = new System.Drawing.Point(188, 68);
            this.nombre2TextBox.Name = "nombre2TextBox";
            this.nombre2TextBox.Size = new System.Drawing.Size(129, 20);
            this.nombre2TextBox.TabIndex = 4;
            // 
            // resultatTextBox
            // 
            this.resultatTextBox.Location = new System.Drawing.Point(188, 181);
            this.resultatTextBox.Name = "resultatTextBox";
            this.resultatTextBox.Size = new System.Drawing.Size(129, 20);
            this.resultatTextBox.TabIndex = 5;
            // 
            // calculButton
            // 
            this.calculButton.Location = new System.Drawing.Point(188, 129);
            this.calculButton.Name = "calculButton";
            this.calculButton.Size = new System.Drawing.Size(129, 23);
            this.calculButton.TabIndex = 6;
            this.calculButton.Text = "Calcul";
            this.calculButton.UseVisualStyleBackColor = true;
            this.calculButton.Click += new System.EventHandler(this.calculButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(375, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nombre a incremente";
            // 
            // nombreIncrementTextBox
            // 
            this.nombreIncrementTextBox.Location = new System.Drawing.Point(363, 68);
            this.nombreIncrementTextBox.Name = "nombreIncrementTextBox";
            this.nombreIncrementTextBox.Size = new System.Drawing.Size(129, 20);
            this.nombreIncrementTextBox.TabIndex = 8;
            // 
            // incrementButton
            // 
            this.incrementButton.Location = new System.Drawing.Point(363, 112);
            this.incrementButton.Name = "incrementButton";
            this.incrementButton.Size = new System.Drawing.Size(129, 23);
            this.incrementButton.TabIndex = 9;
            this.incrementButton.Text = "Increment";
            this.incrementButton.UseVisualStyleBackColor = true;
            this.incrementButton.Click += new System.EventHandler(this.incrementButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 258);
            this.Controls.Add(this.incrementButton);
            this.Controls.Add(this.nombreIncrementTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calculButton);
            this.Controls.Add(this.resultatTextBox);
            this.Controls.Add(this.nombre2TextBox);
            this.Controls.Add(this.nombre1TextBox);
            this.Controls.Add(this.operationComboBox);
            this.Controls.Add(this.nombre2Label);
            this.Controls.Add(this.nombre1Label);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nombre1Label;
        private System.Windows.Forms.Label nombre2Label;
        private System.Windows.Forms.ComboBox operationComboBox;
        private System.Windows.Forms.TextBox nombre1TextBox;
        private System.Windows.Forms.TextBox nombre2TextBox;
        private System.Windows.Forms.TextBox resultatTextBox;
        private System.Windows.Forms.Button calculButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nombreIncrementTextBox;
        private System.Windows.Forms.Button incrementButton;
    }
}

