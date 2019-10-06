namespace ex5TP3
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.couleurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.greenToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.yellowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.greenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.greenToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.yellowToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.vitesseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grandeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moyenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cercleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rectangleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monTimer = new System.Windows.Forms.Timer(this.components);
            this.startStopButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.couleurToolStripMenuItem,
            this.vitesseToolStripMenuItem,
            this.formeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(620, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // couleurToolStripMenuItem
            // 
            this.couleurToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.redToolStripMenuItem,
            this.greenToolStripMenuItem});
            this.couleurToolStripMenuItem.Name = "couleurToolStripMenuItem";
            this.couleurToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.couleurToolStripMenuItem.Text = "Couleur";
            // 
            // redToolStripMenuItem
            // 
            this.redToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.redToolStripMenuItem1,
            this.greenToolStripMenuItem1,
            this.yellowToolStripMenuItem});
            this.redToolStripMenuItem.Name = "redToolStripMenuItem";
            this.redToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.redToolStripMenuItem.Text = "Font";
            this.redToolStripMenuItem.Click += new System.EventHandler(this.redToolStripMenuItem_Click_1);
            // 
            // redToolStripMenuItem1
            // 
            this.redToolStripMenuItem1.Name = "redToolStripMenuItem1";
            this.redToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.redToolStripMenuItem1.Text = "Red";
            this.redToolStripMenuItem1.Click += new System.EventHandler(this.redToolStripMenuItem_Click);
            // 
            // greenToolStripMenuItem1
            // 
            this.greenToolStripMenuItem1.Name = "greenToolStripMenuItem1";
            this.greenToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.greenToolStripMenuItem1.Text = "Green";
            this.greenToolStripMenuItem1.Click += new System.EventHandler(this.greenToolStripMenuItem1_Click);
            // 
            // yellowToolStripMenuItem
            // 
            this.yellowToolStripMenuItem.Name = "yellowToolStripMenuItem";
            this.yellowToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.yellowToolStripMenuItem.Text = "Yellow";
            this.yellowToolStripMenuItem.Click += new System.EventHandler(this.yellowToolStripMenuItem_Click);
            // 
            // greenToolStripMenuItem
            // 
            this.greenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.redToolStripMenuItem2,
            this.greenToolStripMenuItem2,
            this.yellowToolStripMenuItem1});
            this.greenToolStripMenuItem.Name = "greenToolStripMenuItem";
            this.greenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.greenToolStripMenuItem.Text = "Form";
            // 
            // redToolStripMenuItem2
            // 
            this.redToolStripMenuItem2.Name = "redToolStripMenuItem2";
            this.redToolStripMenuItem2.Size = new System.Drawing.Size(108, 22);
            this.redToolStripMenuItem2.Text = "Red";
            this.redToolStripMenuItem2.Click += new System.EventHandler(this.redToolStripMenuItem2_Click);
            // 
            // greenToolStripMenuItem2
            // 
            this.greenToolStripMenuItem2.Name = "greenToolStripMenuItem2";
            this.greenToolStripMenuItem2.Size = new System.Drawing.Size(108, 22);
            this.greenToolStripMenuItem2.Text = "Green";
            this.greenToolStripMenuItem2.Click += new System.EventHandler(this.greenToolStripMenuItem2_Click);
            // 
            // yellowToolStripMenuItem1
            // 
            this.yellowToolStripMenuItem1.Name = "yellowToolStripMenuItem1";
            this.yellowToolStripMenuItem1.Size = new System.Drawing.Size(108, 22);
            this.yellowToolStripMenuItem1.Text = "Yellow";
            this.yellowToolStripMenuItem1.Click += new System.EventHandler(this.yellowToolStripMenuItem1_Click);
            // 
            // vitesseToolStripMenuItem
            // 
            this.vitesseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.grandeToolStripMenuItem,
            this.moyenToolStripMenuItem,
            this.lenteToolStripMenuItem});
            this.vitesseToolStripMenuItem.Name = "vitesseToolStripMenuItem";
            this.vitesseToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.vitesseToolStripMenuItem.Text = "Vitesse";
            // 
            // grandeToolStripMenuItem
            // 
            this.grandeToolStripMenuItem.Name = "grandeToolStripMenuItem";
            this.grandeToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.grandeToolStripMenuItem.Text = "Grande";
            this.grandeToolStripMenuItem.Click += new System.EventHandler(this.grandeToolStripMenuItem_Click);
            // 
            // moyenToolStripMenuItem
            // 
            this.moyenToolStripMenuItem.Name = "moyenToolStripMenuItem";
            this.moyenToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.moyenToolStripMenuItem.Text = "Moyen";
            this.moyenToolStripMenuItem.Click += new System.EventHandler(this.moyenToolStripMenuItem_Click);
            // 
            // lenteToolStripMenuItem
            // 
            this.lenteToolStripMenuItem.Name = "lenteToolStripMenuItem";
            this.lenteToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.lenteToolStripMenuItem.Text = "Lente";
            this.lenteToolStripMenuItem.Click += new System.EventHandler(this.lenteToolStripMenuItem_Click);
            // 
            // formeToolStripMenuItem
            // 
            this.formeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cercleToolStripMenuItem,
            this.rectangleToolStripMenuItem});
            this.formeToolStripMenuItem.Name = "formeToolStripMenuItem";
            this.formeToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.formeToolStripMenuItem.Text = "Forme";
            // 
            // cercleToolStripMenuItem
            // 
            this.cercleToolStripMenuItem.Name = "cercleToolStripMenuItem";
            this.cercleToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.cercleToolStripMenuItem.Text = "Cercle";
            this.cercleToolStripMenuItem.Click += new System.EventHandler(this.cercleToolStripMenuItem_Click);
            // 
            // rectangleToolStripMenuItem
            // 
            this.rectangleToolStripMenuItem.Name = "rectangleToolStripMenuItem";
            this.rectangleToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.rectangleToolStripMenuItem.Text = "Rectangle";
            this.rectangleToolStripMenuItem.Click += new System.EventHandler(this.rectangleToolStripMenuItem_Click);
            // 
            // monTimer
            // 
            this.monTimer.Tick += new System.EventHandler(this.monTimer_Tick);
            // 
            // startStopButton
            // 
            this.startStopButton.Location = new System.Drawing.Point(279, 27);
            this.startStopButton.Name = "startStopButton";
            this.startStopButton.Size = new System.Drawing.Size(75, 23);
            this.startStopButton.TabIndex = 1;
            this.startStopButton.Text = "Start";
            this.startStopButton.UseVisualStyleBackColor = true;
            this.startStopButton.Click += new System.EventHandler(this.startStopButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 267);
            this.Controls.Add(this.startStopButton);
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
        private System.Windows.Forms.ToolStripMenuItem couleurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem greenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vitesseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grandeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moyenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cercleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rectangleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem redToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem greenToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem yellowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem greenToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem yellowToolStripMenuItem1;
        private System.Windows.Forms.Timer monTimer;
        private System.Windows.Forms.Button startStopButton;
    }
}

