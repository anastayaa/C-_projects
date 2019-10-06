namespace Calculator
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
            this.ipTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.portTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.conectButton = new System.Windows.Forms.Button();
            this.op1TextBox = new System.Windows.Forms.TextBox();
            this.op2TextBox = new System.Windows.Forms.TextBox();
            this.calculButton = new System.Windows.Forms.Button();
            this.resultsListBox = new System.Windows.Forms.ListBox();
            this.operationTetBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ipTextBox
            // 
            this.ipTextBox.Location = new System.Drawing.Point(218, 42);
            this.ipTextBox.Name = "ipTextBox";
            this.ipTextBox.Size = new System.Drawing.Size(171, 20);
            this.ipTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(166, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Port";
            // 
            // portTextBox
            // 
            this.portTextBox.Location = new System.Drawing.Point(218, 83);
            this.portTextBox.Name = "portTextBox";
            this.portTextBox.Size = new System.Drawing.Size(171, 20);
            this.portTextBox.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.conectButton);
            this.groupBox1.Location = new System.Drawing.Point(142, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(365, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // conectButton
            // 
            this.conectButton.Location = new System.Drawing.Point(268, 47);
            this.conectButton.Name = "conectButton";
            this.conectButton.Size = new System.Drawing.Size(75, 23);
            this.conectButton.TabIndex = 0;
            this.conectButton.Text = "Connect";
            this.conectButton.UseVisualStyleBackColor = true;
            this.conectButton.Click += new System.EventHandler(this.conectButton_Click);
            // 
            // op1TextBox
            // 
            this.op1TextBox.Location = new System.Drawing.Point(93, 168);
            this.op1TextBox.Name = "op1TextBox";
            this.op1TextBox.Size = new System.Drawing.Size(159, 20);
            this.op1TextBox.TabIndex = 5;
            // 
            // op2TextBox
            // 
            this.op2TextBox.Location = new System.Drawing.Point(93, 205);
            this.op2TextBox.Name = "op2TextBox";
            this.op2TextBox.Size = new System.Drawing.Size(159, 20);
            this.op2TextBox.TabIndex = 6;
            // 
            // calculButton
            // 
            this.calculButton.Location = new System.Drawing.Point(128, 281);
            this.calculButton.Name = "calculButton";
            this.calculButton.Size = new System.Drawing.Size(75, 23);
            this.calculButton.TabIndex = 1;
            this.calculButton.Text = "Calcul";
            this.calculButton.UseVisualStyleBackColor = true;
            this.calculButton.Click += new System.EventHandler(this.calculButton_Click);
            // 
            // resultsListBox
            // 
            this.resultsListBox.FormattingEnabled = true;
            this.resultsListBox.Location = new System.Drawing.Point(373, 168);
            this.resultsListBox.Name = "resultsListBox";
            this.resultsListBox.Size = new System.Drawing.Size(182, 108);
            this.resultsListBox.TabIndex = 7;
            // 
            // operationTetBox
            // 
            this.operationTetBox.Location = new System.Drawing.Point(93, 240);
            this.operationTetBox.Name = "operationTetBox";
            this.operationTetBox.Size = new System.Drawing.Size(159, 20);
            this.operationTetBox.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "OP1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Operation";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "OP2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 335);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.operationTetBox);
            this.Controls.Add(this.resultsListBox);
            this.Controls.Add(this.calculButton);
            this.Controls.Add(this.op2TextBox);
            this.Controls.Add(this.op1TextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.portTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ipTextBox);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ipTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox portTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button conectButton;
        private System.Windows.Forms.TextBox op1TextBox;
        private System.Windows.Forms.TextBox op2TextBox;
        private System.Windows.Forms.Button calculButton;
        private System.Windows.Forms.ListBox resultsListBox;
        private System.Windows.Forms.TextBox operationTetBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

