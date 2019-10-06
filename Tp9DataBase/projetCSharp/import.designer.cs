namespace projetCSharp
{
    partial class import
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
            this.txt_file = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_charger = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_file
            // 
            this.txt_file.Location = new System.Drawing.Point(254, 37);
            this.txt_file.Name = "txt_file";
            this.txt_file.Size = new System.Drawing.Size(236, 20);
            this.txt_file.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(61, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Importer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_charger
            // 
            this.btn_charger.Location = new System.Drawing.Point(254, 87);
            this.btn_charger.Name = "btn_charger";
            this.btn_charger.Size = new System.Drawing.Size(75, 23);
            this.btn_charger.TabIndex = 2;
            this.btn_charger.Text = "Charger dans la BD";
            this.btn_charger.UseVisualStyleBackColor = true;
            this.btn_charger.Click += new System.EventHandler(this.btn_charger_Click);
            // 
            // import
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 151);
            this.Controls.Add(this.btn_charger);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_file);
            this.Name = "import";
            this.Text = "import";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_file;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_charger;
    }
}