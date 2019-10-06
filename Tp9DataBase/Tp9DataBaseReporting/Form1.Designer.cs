namespace Tp9DataBaseReporting
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
            this.reportingButton = new System.Windows.Forms.Button();
            this.cneComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.statistiqueButton = new System.Windows.Forms.Button();
            this.etudiant_datagridview = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.etudiant_datagridview)).BeginInit();
            this.SuspendLayout();
            // 
            // reportingButton
            // 
            this.reportingButton.Location = new System.Drawing.Point(307, 49);
            this.reportingButton.Name = "reportingButton";
            this.reportingButton.Size = new System.Drawing.Size(75, 23);
            this.reportingButton.TabIndex = 36;
            this.reportingButton.Text = "Reporting";
            this.reportingButton.UseVisualStyleBackColor = true;
            this.reportingButton.Click += new System.EventHandler(this.reportingButton_Click);
            // 
            // cneComboBox
            // 
            this.cneComboBox.FormattingEnabled = true;
            this.cneComboBox.Location = new System.Drawing.Point(158, 51);
            this.cneComboBox.Name = "cneComboBox";
            this.cneComboBox.Size = new System.Drawing.Size(121, 21);
            this.cneComboBox.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "CNE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Rechercher";
            // 
            // statistiqueButton
            // 
            this.statistiqueButton.Location = new System.Drawing.Point(410, 49);
            this.statistiqueButton.Name = "statistiqueButton";
            this.statistiqueButton.Size = new System.Drawing.Size(75, 23);
            this.statistiqueButton.TabIndex = 37;
            this.statistiqueButton.Text = "Statistique";
            this.statistiqueButton.UseVisualStyleBackColor = true;
            // 
            // etudiant_datagridview
            // 
            this.etudiant_datagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.etudiant_datagridview.Location = new System.Drawing.Point(12, 99);
            this.etudiant_datagridview.Name = "etudiant_datagridview";
            this.etudiant_datagridview.Size = new System.Drawing.Size(402, 150);
            this.etudiant_datagridview.TabIndex = 38;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(430, 99);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(150, 150);
            this.crystalReportViewer1.TabIndex = 39;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 270);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.etudiant_datagridview);
            this.Controls.Add(this.statistiqueButton);
            this.Controls.Add(this.reportingButton);
            this.Controls.Add(this.cneComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.etudiant_datagridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button reportingButton;
        private System.Windows.Forms.ComboBox cneComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button statistiqueButton;
        private System.Windows.Forms.DataGridView etudiant_datagridview;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
    }
}

