namespace Tp9DataBaseLinqToSQL
{
    partial class Form3
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
            this.virerButton = new System.Windows.Forms.Button();
            this.virementTextBox = new System.Windows.Forms.TextBox();
            this.virementLabel = new System.Windows.Forms.Label();
            this.soldeButton = new System.Windows.Forms.Button();
            this.soldeClient2TextBox = new System.Windows.Forms.TextBox();
            this.soldeClient1TextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.client2TextBox = new System.Windows.Forms.TextBox();
            this.client1TextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // virerButton
            // 
            this.virerButton.Location = new System.Drawing.Point(290, 198);
            this.virerButton.Name = "virerButton";
            this.virerButton.Size = new System.Drawing.Size(75, 23);
            this.virerButton.TabIndex = 23;
            this.virerButton.Text = "Virer";
            this.virerButton.UseVisualStyleBackColor = true;
            this.virerButton.Click += new System.EventHandler(this.virerButton_Click);
            // 
            // virementTextBox
            // 
            this.virementTextBox.Location = new System.Drawing.Point(121, 201);
            this.virementTextBox.Name = "virementTextBox";
            this.virementTextBox.Size = new System.Drawing.Size(131, 20);
            this.virementTextBox.TabIndex = 22;
            // 
            // virementLabel
            // 
            this.virementLabel.AutoSize = true;
            this.virementLabel.Location = new System.Drawing.Point(53, 208);
            this.virementLabel.Name = "virementLabel";
            this.virementLabel.Size = new System.Drawing.Size(48, 13);
            this.virementLabel.TabIndex = 21;
            this.virementLabel.Text = "Virement";
            // 
            // soldeButton
            // 
            this.soldeButton.Location = new System.Drawing.Point(121, 145);
            this.soldeButton.Name = "soldeButton";
            this.soldeButton.Size = new System.Drawing.Size(75, 23);
            this.soldeButton.TabIndex = 20;
            this.soldeButton.Text = "Afficher Solde";
            this.soldeButton.UseVisualStyleBackColor = true;
            this.soldeButton.Click += new System.EventHandler(this.soldeButton_Click);
            // 
            // soldeClient2TextBox
            // 
            this.soldeClient2TextBox.Location = new System.Drawing.Point(397, 102);
            this.soldeClient2TextBox.Name = "soldeClient2TextBox";
            this.soldeClient2TextBox.Size = new System.Drawing.Size(131, 20);
            this.soldeClient2TextBox.TabIndex = 19;
            // 
            // soldeClient1TextBox
            // 
            this.soldeClient1TextBox.Location = new System.Drawing.Point(397, 60);
            this.soldeClient1TextBox.Name = "soldeClient1TextBox";
            this.soldeClient1TextBox.Size = new System.Drawing.Size(131, 20);
            this.soldeClient1TextBox.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(296, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Solde Client2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(296, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Solde Client1";
            // 
            // client2TextBox
            // 
            this.client2TextBox.Location = new System.Drawing.Point(121, 106);
            this.client2TextBox.Name = "client2TextBox";
            this.client2TextBox.Size = new System.Drawing.Size(131, 20);
            this.client2TextBox.TabIndex = 15;
            // 
            // client1TextBox
            // 
            this.client1TextBox.Location = new System.Drawing.Point(121, 60);
            this.client1TextBox.Name = "client1TextBox";
            this.client1TextBox.Size = new System.Drawing.Size(131, 20);
            this.client1TextBox.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Client2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Client1";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 280);
            this.Controls.Add(this.virerButton);
            this.Controls.Add(this.virementTextBox);
            this.Controls.Add(this.virementLabel);
            this.Controls.Add(this.soldeButton);
            this.Controls.Add(this.soldeClient2TextBox);
            this.Controls.Add(this.soldeClient1TextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.client2TextBox);
            this.Controls.Add(this.client1TextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button virerButton;
        private System.Windows.Forms.TextBox virementTextBox;
        private System.Windows.Forms.Label virementLabel;
        private System.Windows.Forms.Button soldeButton;
        private System.Windows.Forms.TextBox soldeClient2TextBox;
        private System.Windows.Forms.TextBox soldeClient1TextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox client2TextBox;
        private System.Windows.Forms.TextBox client1TextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}