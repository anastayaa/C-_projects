namespace calculetteDistanceClient
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
            this.chaineOperation = new System.Windows.Forms.TextBox();
            this.op1Button = new System.Windows.Forms.Button();
            this.op2Button = new System.Windows.Forms.Button();
            this.equalsButton = new System.Windows.Forms.Button();
            this.mulButton = new System.Windows.Forms.Button();
            this.plusButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chaineOperation
            // 
            this.chaineOperation.Location = new System.Drawing.Point(167, 27);
            this.chaineOperation.Name = "chaineOperation";
            this.chaineOperation.Size = new System.Drawing.Size(152, 20);
            this.chaineOperation.TabIndex = 0;
            // 
            // op1Button
            // 
            this.op1Button.Location = new System.Drawing.Point(108, 78);
            this.op1Button.Name = "op1Button";
            this.op1Button.Size = new System.Drawing.Size(75, 23);
            this.op1Button.TabIndex = 1;
            this.op1Button.Text = "1";
            this.op1Button.UseVisualStyleBackColor = true;
            this.op1Button.Click += new System.EventHandler(this.op1Button_Click);
            // 
            // op2Button
            // 
            this.op2Button.Location = new System.Drawing.Point(202, 78);
            this.op2Button.Name = "op2Button";
            this.op2Button.Size = new System.Drawing.Size(75, 23);
            this.op2Button.TabIndex = 2;
            this.op2Button.Text = "2";
            this.op2Button.UseVisualStyleBackColor = true;
            this.op2Button.Click += new System.EventHandler(this.op2Button_Click);
            // 
            // equalsButton
            // 
            this.equalsButton.Location = new System.Drawing.Point(294, 78);
            this.equalsButton.Name = "equalsButton";
            this.equalsButton.Size = new System.Drawing.Size(75, 23);
            this.equalsButton.TabIndex = 3;
            this.equalsButton.Text = "=";
            this.equalsButton.UseVisualStyleBackColor = true;
            // 
            // mulButton
            // 
            this.mulButton.Location = new System.Drawing.Point(154, 123);
            this.mulButton.Name = "mulButton";
            this.mulButton.Size = new System.Drawing.Size(75, 23);
            this.mulButton.TabIndex = 4;
            this.mulButton.Text = "*";
            this.mulButton.UseVisualStyleBackColor = true;
            this.mulButton.Click += new System.EventHandler(this.mulButton_Click);
            // 
            // plusButton
            // 
            this.plusButton.Location = new System.Drawing.Point(244, 123);
            this.plusButton.Name = "plusButton";
            this.plusButton.Size = new System.Drawing.Size(75, 23);
            this.plusButton.TabIndex = 5;
            this.plusButton.Text = "+";
            this.plusButton.UseVisualStyleBackColor = true;
            this.plusButton.Click += new System.EventHandler(this.plusButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 243);
            this.Controls.Add(this.plusButton);
            this.Controls.Add(this.mulButton);
            this.Controls.Add(this.equalsButton);
            this.Controls.Add(this.op2Button);
            this.Controls.Add(this.op1Button);
            this.Controls.Add(this.chaineOperation);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox chaineOperation;
        private System.Windows.Forms.Button op1Button;
        private System.Windows.Forms.Button op2Button;
        private System.Windows.Forms.Button equalsButton;
        private System.Windows.Forms.Button mulButton;
        private System.Windows.Forms.Button plusButton;
    }
}

