namespace projetCSharp
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.Reperporting = new System.Windows.Forms.TabPage();
            this.com_cne_reporting = new System.Windows.Forms.ComboBox();
            this.Btn_tt = new System.Windows.Forms.Button();
            this.Btn_Afficher = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.chart_etudiant = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_importer = new System.Windows.Forms.Button();
            this.btn_tri_croissant = new System.Windows.Forms.Button();
            this.btn_tri_decroissant = new System.Windows.Forms.Button();
            this.btn_charger_donnees = new System.Windows.Forms.Button();
            this.dataGridViewEtudiant = new System.Windows.Forms.DataGridView();
            this.Btn_Ajout_etudiant = new System.Windows.Forms.Button();
            this.btn_supprimer_etudiant = new System.Windows.Forms.Button();
            this.btn_modifier_etudiant = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_Telephone = new System.Windows.Forms.TextBox();
            this.txt_Adresse = new System.Windows.Forms.TextBox();
            this.txt_prenom = new System.Windows.Forms.TextBox();
            this.txt_nom = new System.Windows.Forms.TextBox();
            this.txt_Cne = new System.Windows.Forms.TextBox();
            this.com_Filiere = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.radio_Feminin = new System.Windows.Forms.RadioButton();
            this.radio_masculin = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.com_cne = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Btn_Modifier = new System.Windows.Forms.Button();
            this.btn_Supprimer = new System.Windows.Forms.Button();
            this.dataGridViewFiliere = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_Valider = new System.Windows.Forms.Button();
            this.txt_filiere_nv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Ajout = new System.Windows.Forms.Button();
            this.txt_Filiere = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Reperporting.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_etudiant)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEtudiant)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFiliere)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Reperporting
            // 
            this.Reperporting.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuItem;
            this.Reperporting.Controls.Add(this.com_cne_reporting);
            this.Reperporting.Controls.Add(this.Btn_tt);
            this.Reperporting.Controls.Add(this.Btn_Afficher);
            this.Reperporting.Controls.Add(this.label12);
            this.Reperporting.Location = new System.Drawing.Point(4, 22);
            this.Reperporting.Name = "Reperporting";
            this.Reperporting.Size = new System.Drawing.Size(797, 422);
            this.Reperporting.TabIndex = 3;
            this.Reperporting.Text = "Reperporting";
            this.Reperporting.UseVisualStyleBackColor = true;
            this.Reperporting.Click += new System.EventHandler(this.Reperporting_Click);
            // 
            // com_cne_reporting
            // 
            this.com_cne_reporting.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_cne_reporting.FormattingEnabled = true;
            this.com_cne_reporting.Location = new System.Drawing.Point(163, 129);
            this.com_cne_reporting.Name = "com_cne_reporting";
            this.com_cne_reporting.Size = new System.Drawing.Size(210, 21);
            this.com_cne_reporting.TabIndex = 4;
            // 
            // Btn_tt
            // 
            this.Btn_tt.Location = new System.Drawing.Point(459, 198);
            this.Btn_tt.Name = "Btn_tt";
            this.Btn_tt.Size = new System.Drawing.Size(164, 23);
            this.Btn_tt.TabIndex = 3;
            this.Btn_tt.Text = "Afficher tout";
            this.Btn_tt.UseVisualStyleBackColor = true;
            this.Btn_tt.Click += new System.EventHandler(this.Btn_tt_Click);
            // 
            // Btn_Afficher
            // 
            this.Btn_Afficher.Location = new System.Drawing.Point(163, 198);
            this.Btn_Afficher.Name = "Btn_Afficher";
            this.Btn_Afficher.Size = new System.Drawing.Size(164, 23);
            this.Btn_Afficher.TabIndex = 2;
            this.Btn_Afficher.Text = "Afficher";
            this.Btn_Afficher.UseVisualStyleBackColor = true;
            this.Btn_Afficher.Click += new System.EventHandler(this.Btn_Afficher_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(79, 137);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Saisir un CNE :";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.chart_etudiant);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(797, 422);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Statistique";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // chart_etudiant
            // 
            chartArea1.Name = "ChartArea1";
            this.chart_etudiant.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart_etudiant.Legends.Add(legend1);
            this.chart_etudiant.Location = new System.Drawing.Point(23, 53);
            this.chart_etudiant.Name = "chart_etudiant";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Etudiant";
            this.chart_etudiant.Series.Add(series1);
            this.chart_etudiant.Size = new System.Drawing.Size(725, 300);
            this.chart_etudiant.TabIndex = 0;
            this.chart_etudiant.Text = "chart1";
            title1.Name = "Title1";
            this.chart_etudiant.Titles.Add(title1);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_importer);
            this.tabPage2.Controls.Add(this.btn_tri_croissant);
            this.tabPage2.Controls.Add(this.btn_tri_decroissant);
            this.tabPage2.Controls.Add(this.btn_charger_donnees);
            this.tabPage2.Controls.Add(this.dataGridViewEtudiant);
            this.tabPage2.Controls.Add(this.Btn_Ajout_etudiant);
            this.tabPage2.Controls.Add(this.btn_supprimer_etudiant);
            this.tabPage2.Controls.Add(this.btn_modifier_etudiant);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.com_cne);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(797, 422);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Etudiant";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_importer
            // 
            this.btn_importer.Location = new System.Drawing.Point(358, 391);
            this.btn_importer.Name = "btn_importer";
            this.btn_importer.Size = new System.Drawing.Size(75, 23);
            this.btn_importer.TabIndex = 19;
            this.btn_importer.Text = "Importer";
            this.btn_importer.UseVisualStyleBackColor = true;
            this.btn_importer.Click += new System.EventHandler(this.btn_importer_Click_1);
            // 
            // btn_tri_croissant
            // 
            this.btn_tri_croissant.Location = new System.Drawing.Point(485, 24);
            this.btn_tri_croissant.Name = "btn_tri_croissant";
            this.btn_tri_croissant.Size = new System.Drawing.Size(111, 23);
            this.btn_tri_croissant.TabIndex = 18;
            this.btn_tri_croissant.Text = "Tri Croissant";
            this.btn_tri_croissant.UseVisualStyleBackColor = true;
            this.btn_tri_croissant.Click += new System.EventHandler(this.btn_tri_croissant_Click);
            // 
            // btn_tri_decroissant
            // 
            this.btn_tri_decroissant.Location = new System.Drawing.Point(623, 24);
            this.btn_tri_decroissant.Name = "btn_tri_decroissant";
            this.btn_tri_decroissant.Size = new System.Drawing.Size(151, 23);
            this.btn_tri_decroissant.TabIndex = 17;
            this.btn_tri_decroissant.Text = "Tri Decroissant";
            this.btn_tri_decroissant.UseVisualStyleBackColor = true;
            this.btn_tri_decroissant.Click += new System.EventHandler(this.btn_tri_decroissant_Click);
            // 
            // btn_charger_donnees
            // 
            this.btn_charger_donnees.Location = new System.Drawing.Point(333, 23);
            this.btn_charger_donnees.Name = "btn_charger_donnees";
            this.btn_charger_donnees.Size = new System.Drawing.Size(136, 23);
            this.btn_charger_donnees.TabIndex = 16;
            this.btn_charger_donnees.Text = "Charger  Les donnees";
            this.btn_charger_donnees.UseVisualStyleBackColor = true;
            this.btn_charger_donnees.Click += new System.EventHandler(this.btn_charger_donnees_Click);
            // 
            // dataGridViewEtudiant
            // 
            this.dataGridViewEtudiant.AllowUserToOrderColumns = true;
            this.dataGridViewEtudiant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEtudiant.Location = new System.Drawing.Point(333, 65);
            this.dataGridViewEtudiant.Name = "dataGridViewEtudiant";
            this.dataGridViewEtudiant.Size = new System.Drawing.Size(458, 309);
            this.dataGridViewEtudiant.TabIndex = 15;
            this.dataGridViewEtudiant.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            this.dataGridViewEtudiant.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            this.dataGridViewEtudiant.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellDoubleClick);
            // 
            // Btn_Ajout_etudiant
            // 
            this.Btn_Ajout_etudiant.Location = new System.Drawing.Point(44, 390);
            this.Btn_Ajout_etudiant.Name = "Btn_Ajout_etudiant";
            this.Btn_Ajout_etudiant.Size = new System.Drawing.Size(75, 23);
            this.Btn_Ajout_etudiant.TabIndex = 12;
            this.Btn_Ajout_etudiant.Text = "Ajouter";
            this.Btn_Ajout_etudiant.UseVisualStyleBackColor = true;
            this.Btn_Ajout_etudiant.Click += new System.EventHandler(this.Btn_Ajout_etudiant_Click);
            // 
            // btn_supprimer_etudiant
            // 
            this.btn_supprimer_etudiant.Location = new System.Drawing.Point(252, 391);
            this.btn_supprimer_etudiant.Name = "btn_supprimer_etudiant";
            this.btn_supprimer_etudiant.Size = new System.Drawing.Size(75, 23);
            this.btn_supprimer_etudiant.TabIndex = 13;
            this.btn_supprimer_etudiant.Text = "Supprimer";
            this.btn_supprimer_etudiant.UseVisualStyleBackColor = true;
            this.btn_supprimer_etudiant.Click += new System.EventHandler(this.btn_supprimer_etudiant_Click);
            // 
            // btn_modifier_etudiant
            // 
            this.btn_modifier_etudiant.Location = new System.Drawing.Point(144, 390);
            this.btn_modifier_etudiant.Name = "btn_modifier_etudiant";
            this.btn_modifier_etudiant.Size = new System.Drawing.Size(75, 23);
            this.btn_modifier_etudiant.TabIndex = 14;
            this.btn_modifier_etudiant.Text = "Modifier";
            this.btn_modifier_etudiant.UseVisualStyleBackColor = true;
            this.btn_modifier_etudiant.Click += new System.EventHandler(this.btn_modifier_etudiant_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_Telephone);
            this.groupBox2.Controls.Add(this.txt_Adresse);
            this.groupBox2.Controls.Add(this.txt_prenom);
            this.groupBox2.Controls.Add(this.txt_nom);
            this.groupBox2.Controls.Add(this.txt_Cne);
            this.groupBox2.Controls.Add(this.com_Filiere);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.dateTime);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.radio_Feminin);
            this.groupBox2.Controls.Add(this.radio_masculin);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(6, 56);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(321, 318);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Information Etudiant";
            // 
            // txt_Telephone
            // 
            this.txt_Telephone.Location = new System.Drawing.Point(93, 250);
            this.txt_Telephone.Name = "txt_Telephone";
            this.txt_Telephone.Size = new System.Drawing.Size(210, 20);
            this.txt_Telephone.TabIndex = 16;
            // 
            // txt_Adresse
            // 
            this.txt_Adresse.Location = new System.Drawing.Point(93, 216);
            this.txt_Adresse.Name = "txt_Adresse";
            this.txt_Adresse.Size = new System.Drawing.Size(210, 20);
            this.txt_Adresse.TabIndex = 15;
            // 
            // txt_prenom
            // 
            this.txt_prenom.Location = new System.Drawing.Point(93, 95);
            this.txt_prenom.Name = "txt_prenom";
            this.txt_prenom.Size = new System.Drawing.Size(210, 20);
            this.txt_prenom.TabIndex = 14;
            // 
            // txt_nom
            // 
            this.txt_nom.Location = new System.Drawing.Point(93, 60);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(210, 20);
            this.txt_nom.TabIndex = 13;
            // 
            // txt_Cne
            // 
            this.txt_Cne.Location = new System.Drawing.Point(93, 29);
            this.txt_Cne.Name = "txt_Cne";
            this.txt_Cne.Size = new System.Drawing.Size(210, 20);
            this.txt_Cne.TabIndex = 12;
            // 
            // com_Filiere
            // 
            this.com_Filiere.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_Filiere.FormattingEnabled = true;
            this.com_Filiere.Location = new System.Drawing.Point(93, 285);
            this.com_Filiere.Name = "com_Filiere";
            this.com_Filiere.Size = new System.Drawing.Size(210, 21);
            this.com_Filiere.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 288);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Filiere :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 253);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Telephone :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 219);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Adresse";
            // 
            // dateTime
            // 
            this.dateTime.Location = new System.Drawing.Point(119, 172);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(184, 20);
            this.dateTime.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 172);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Date de naissance :";
            // 
            // radio_Feminin
            // 
            this.radio_Feminin.AutoSize = true;
            this.radio_Feminin.Location = new System.Drawing.Point(157, 133);
            this.radio_Feminin.Name = "radio_Feminin";
            this.radio_Feminin.Size = new System.Drawing.Size(31, 17);
            this.radio_Feminin.TabIndex = 5;
            this.radio_Feminin.TabStop = true;
            this.radio_Feminin.Text = "F";
            this.radio_Feminin.UseVisualStyleBackColor = true;
            // 
            // radio_masculin
            // 
            this.radio_masculin.AutoSize = true;
            this.radio_masculin.Location = new System.Drawing.Point(93, 133);
            this.radio_masculin.Name = "radio_masculin";
            this.radio_masculin.Size = new System.Drawing.Size(34, 17);
            this.radio_masculin.TabIndex = 4;
            this.radio_masculin.TabStop = true;
            this.radio_masculin.Text = "M";
            this.radio_masculin.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Sexe :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Prenom:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "CNE:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nom:";
            // 
            // com_cne
            // 
            this.com_cne.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_cne.FormattingEnabled = true;
            this.com_cne.Location = new System.Drawing.Point(107, 26);
            this.com_cne.Name = "com_cne";
            this.com_cne.Size = new System.Drawing.Size(210, 21);
            this.com_cne.TabIndex = 1;
            this.com_cne.SelectedIndexChanged += new System.EventHandler(this.com_Cne_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Chercher etudiant ";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Btn_Modifier);
            this.tabPage1.Controls.Add(this.btn_Supprimer);
            this.tabPage1.Controls.Add(this.dataGridViewFiliere);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(797, 422);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Filiere";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Btn_Modifier
            // 
            this.Btn_Modifier.Location = new System.Drawing.Point(561, 341);
            this.Btn_Modifier.Name = "Btn_Modifier";
            this.Btn_Modifier.Size = new System.Drawing.Size(118, 23);
            this.Btn_Modifier.TabIndex = 3;
            this.Btn_Modifier.Text = "Modifier";
            this.Btn_Modifier.UseVisualStyleBackColor = true;
            this.Btn_Modifier.Click += new System.EventHandler(this.Btn_Modifier_Click);
            // 
            // btn_Supprimer
            // 
            this.btn_Supprimer.Location = new System.Drawing.Point(418, 342);
            this.btn_Supprimer.Name = "btn_Supprimer";
            this.btn_Supprimer.Size = new System.Drawing.Size(106, 23);
            this.btn_Supprimer.TabIndex = 2;
            this.btn_Supprimer.Text = "Supprimer";
            this.btn_Supprimer.UseVisualStyleBackColor = true;
            this.btn_Supprimer.Click += new System.EventHandler(this.btn_Supprimer_Click_1);
            // 
            // dataGridViewFiliere
            // 
            this.dataGridViewFiliere.AllowUserToAddRows = false;
            this.dataGridViewFiliere.AllowUserToDeleteRows = false;
            this.dataGridViewFiliere.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFiliere.Location = new System.Drawing.Point(433, 29);
            this.dataGridViewFiliere.Name = "dataGridViewFiliere";
            this.dataGridViewFiliere.ReadOnly = true;
            this.dataGridViewFiliere.Size = new System.Drawing.Size(235, 199);
            this.dataGridViewFiliere.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.btn_Ajout);
            this.groupBox1.Controls.Add(this.txt_Filiere);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(9, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(344, 396);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ajout Filiere";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.Btn_Valider);
            this.panel1.Controls.Add(this.txt_filiere_nv);
            this.panel1.Controls.Add(this.label2);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(40, 219);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(287, 144);
            this.panel1.TabIndex = 3;
            // 
            // Btn_Valider
            // 
            this.Btn_Valider.Location = new System.Drawing.Point(98, 99);
            this.Btn_Valider.Name = "Btn_Valider";
            this.Btn_Valider.Size = new System.Drawing.Size(163, 23);
            this.Btn_Valider.TabIndex = 2;
            this.Btn_Valider.Text = "Valider";
            this.Btn_Valider.UseVisualStyleBackColor = true;
            this.Btn_Valider.Click += new System.EventHandler(this.Btn_Valider_Click);
            // 
            // txt_filiere_nv
            // 
            this.txt_filiere_nv.Location = new System.Drawing.Point(105, 38);
            this.txt_filiere_nv.Name = "txt_filiere_nv";
            this.txt_filiere_nv.Size = new System.Drawing.Size(156, 20);
            this.txt_filiere_nv.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nouveau Nom :";
            // 
            // btn_Ajout
            // 
            this.btn_Ajout.Location = new System.Drawing.Point(77, 123);
            this.btn_Ajout.Name = "btn_Ajout";
            this.btn_Ajout.Size = new System.Drawing.Size(172, 23);
            this.btn_Ajout.TabIndex = 2;
            this.btn_Ajout.Text = "Ajouter";
            this.btn_Ajout.UseVisualStyleBackColor = true;
            this.btn_Ajout.Click += new System.EventHandler(this.btn_Ajout_Click);
            // 
            // txt_Filiere
            // 
            this.txt_Filiere.Location = new System.Drawing.Point(77, 64);
            this.txt_Filiere.Name = "txt_Filiere";
            this.txt_Filiere.Size = new System.Drawing.Size(172, 20);
            this.txt_Filiere.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom Filiere :";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.Reperporting);
            this.tabControl1.Location = new System.Drawing.Point(-1, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(805, 448);
            this.tabControl1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Reperporting.ResumeLayout(false);
            this.Reperporting.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart_etudiant)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEtudiant)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFiliere)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

		}

        #endregion

        private System.Windows.Forms.TabPage Reperporting;
        private System.Windows.Forms.Button Btn_tt;
        private System.Windows.Forms.Button Btn_Afficher;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_etudiant;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn_importer;
        private System.Windows.Forms.Button btn_tri_croissant;
        private System.Windows.Forms.Button btn_tri_decroissant;
        private System.Windows.Forms.Button btn_charger_donnees;
        private System.Windows.Forms.DataGridView dataGridViewEtudiant;
        private System.Windows.Forms.Button Btn_Ajout_etudiant;
        private System.Windows.Forms.Button btn_supprimer_etudiant;
        private System.Windows.Forms.Button btn_modifier_etudiant;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_Telephone;
        private System.Windows.Forms.TextBox txt_Adresse;
        private System.Windows.Forms.TextBox txt_prenom;
        private System.Windows.Forms.TextBox txt_nom;
        private System.Windows.Forms.TextBox txt_Cne;
        private System.Windows.Forms.ComboBox com_Filiere;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateTime;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton radio_Feminin;
        private System.Windows.Forms.RadioButton radio_masculin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox com_cne;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button Btn_Modifier;
        private System.Windows.Forms.Button btn_Supprimer;
        private System.Windows.Forms.DataGridView dataGridViewFiliere;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_Valider;
        private System.Windows.Forms.TextBox txt_filiere_nv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Ajout;
        private System.Windows.Forms.TextBox txt_Filiere;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.ComboBox com_cne_reporting;
    }
}

