namespace ex6TP3
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lancementThreadsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exercice1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exercice2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pauseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reprendreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suppressionThreadsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tousLesThreadsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.threadSelectioneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quiterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.threadsListListBox = new System.Windows.Forms.ListBox();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.pauseToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lancementThreadsToolStripMenuItem,
            this.pauseToolStripMenuItem,
            this.suppressionThreadsToolStripMenuItem,
            this.quiterToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(564, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // lancementThreadsToolStripMenuItem
            // 
            this.lancementThreadsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exercice1ToolStripMenuItem,
            this.exercice2ToolStripMenuItem});
            this.lancementThreadsToolStripMenuItem.Name = "lancementThreadsToolStripMenuItem";
            this.lancementThreadsToolStripMenuItem.Size = new System.Drawing.Size(118, 20);
            this.lancementThreadsToolStripMenuItem.Text = "Lancement Thread";
            // 
            // exercice1ToolStripMenuItem
            // 
            this.exercice1ToolStripMenuItem.Name = "exercice1ToolStripMenuItem";
            this.exercice1ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exercice1ToolStripMenuItem.Text = "Exercice3";
            this.exercice1ToolStripMenuItem.Click += new System.EventHandler(this.exercice1ToolStripMenuItem_Click);
            // 
            // exercice2ToolStripMenuItem
            // 
            this.exercice2ToolStripMenuItem.Name = "exercice2ToolStripMenuItem";
            this.exercice2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exercice2ToolStripMenuItem.Text = "Exercice5";
            this.exercice2ToolStripMenuItem.Click += new System.EventHandler(this.exercice2ToolStripMenuItem_Click);
            // 
            // pauseToolStripMenuItem
            // 
            this.pauseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reprendreToolStripMenuItem,
            this.pauseToolStripMenuItem1});
            this.pauseToolStripMenuItem.Name = "pauseToolStripMenuItem";
            this.pauseToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.pauseToolStripMenuItem.Text = "Pause";
            // 
            // reprendreToolStripMenuItem
            // 
            this.reprendreToolStripMenuItem.Name = "reprendreToolStripMenuItem";
            this.reprendreToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.reprendreToolStripMenuItem.Text = "Reprendre";
            this.reprendreToolStripMenuItem.Click += new System.EventHandler(this.reprendreToolStripMenuItem_Click);
            // 
            // suppressionThreadsToolStripMenuItem
            // 
            this.suppressionThreadsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tousLesThreadsToolStripMenuItem,
            this.threadSelectioneToolStripMenuItem});
            this.suppressionThreadsToolStripMenuItem.Name = "suppressionThreadsToolStripMenuItem";
            this.suppressionThreadsToolStripMenuItem.Size = new System.Drawing.Size(128, 20);
            this.suppressionThreadsToolStripMenuItem.Text = "Suppression Threads";
            // 
            // tousLesThreadsToolStripMenuItem
            // 
            this.tousLesThreadsToolStripMenuItem.Name = "tousLesThreadsToolStripMenuItem";
            this.tousLesThreadsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tousLesThreadsToolStripMenuItem.Text = "Tous les threads";
            this.tousLesThreadsToolStripMenuItem.Click += new System.EventHandler(this.tousLesThreadsToolStripMenuItem_Click);
            // 
            // threadSelectioneToolStripMenuItem
            // 
            this.threadSelectioneToolStripMenuItem.Name = "threadSelectioneToolStripMenuItem";
            this.threadSelectioneToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.threadSelectioneToolStripMenuItem.Text = "Thread selectione";
            this.threadSelectioneToolStripMenuItem.Click += new System.EventHandler(this.threadSelectioneToolStripMenuItem_Click);
            // 
            // quiterToolStripMenuItem
            // 
            this.quiterToolStripMenuItem.Name = "quiterToolStripMenuItem";
            this.quiterToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.quiterToolStripMenuItem.Text = "Quitter";
            this.quiterToolStripMenuItem.Click += new System.EventHandler(this.quiterToolStripMenuItem_Click);
            // 
            // threadsListListBox
            // 
            this.threadsListListBox.FormattingEnabled = true;
            this.threadsListListBox.Location = new System.Drawing.Point(24, 71);
            this.threadsListListBox.Name = "threadsListListBox";
            this.threadsListListBox.Size = new System.Drawing.Size(149, 160);
            this.threadsListListBox.TabIndex = 1;
            this.threadsListListBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(24, 210);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(149, 21);
            this.hScrollBar1.TabIndex = 2;
            // 
            // pauseToolStripMenuItem1
            // 
            this.pauseToolStripMenuItem1.Name = "pauseToolStripMenuItem1";
            this.pauseToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.pauseToolStripMenuItem1.Text = "Pause";
            this.pauseToolStripMenuItem1.Click += new System.EventHandler(this.pauseToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 275);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.threadsListListBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem lancementThreadsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exercice1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exercice2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pauseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reprendreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suppressionThreadsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tousLesThreadsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem threadSelectioneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quiterToolStripMenuItem;
        private System.Windows.Forms.ListBox threadsListListBox;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.ToolStripMenuItem pauseToolStripMenuItem1;
    }
}

