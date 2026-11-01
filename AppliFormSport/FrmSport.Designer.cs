namespace AppliFormSport
{
    partial class FrmSport
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
            this.lstResultats = new System.Windows.Forms.ListView();
            this.Nom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Prénom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ville = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NiveauXp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nomSport = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnReinitialise = new System.Windows.Forms.Button();
            this.txtValeur = new System.Windows.Forms.TextBox();
            this.cboCritere = new System.Windows.Forms.ComboBox();
            this.lblNombreResultats = new System.Windows.Forms.Label();
            this.btnRechercher = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.cboSport = new System.Windows.Forms.ComboBox();
            this.cboNiveau = new System.Windows.Forms.ComboBox();
            this.txtVille = new System.Windows.Forms.TextBox();
            this.txtCp = new System.Windows.Forms.TextBox();
            this.txtRue = new System.Windows.Forms.TextBox();
            this.dtpDateNaiss = new System.Windows.Forms.DateTimePicker();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.lstSports = new System.Windows.Forms.ListView();
            this.btnAjouterSport = new System.Windows.Forms.Button();
            this.btnModifierNiveau = new System.Windows.Forms.Button();
            this.btnRetirerSport = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstResultats
            // 
            this.lstResultats.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nom,
            this.Prénom,
            this.Ville,
            this.NiveauXp,
            this.nomSport});
            this.lstResultats.HideSelection = false;
            this.lstResultats.Location = new System.Drawing.Point(20, 110);
            this.lstResultats.Name = "lstResultats";
            this.lstResultats.Size = new System.Drawing.Size(850, 280);
            this.lstResultats.TabIndex = 13;
            this.lstResultats.UseCompatibleStateImageBehavior = false;
            this.lstResultats.View = System.Windows.Forms.View.Details;
            // 
            // Ville
            // 
            this.Ville.Width = 62;
            // 
            // btnReinitialise
            // 
            this.btnReinitialise.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReinitialise.Location = new System.Drawing.Point(600, 10);
            this.btnReinitialise.Name = "btnReinitialise";
            this.btnReinitialise.Size = new System.Drawing.Size(138, 49);
            this.btnReinitialise.TabIndex = 12;
            this.btnReinitialise.Text = "Reinitialise";
            this.btnReinitialise.UseVisualStyleBackColor = true;
            this.btnReinitialise.Click += new System.EventHandler(this.btnReinitialise_Click);
            // 
            // txtValeur
            // 
            this.txtValeur.Location = new System.Drawing.Point(240, 20);
            this.txtValeur.Name = "txtValeur";
            this.txtValeur.Size = new System.Drawing.Size(180, 20);
            this.txtValeur.TabIndex = 11;
            // 
            // cboCritere
            // 
            this.cboCritere.FormattingEnabled = true;
            this.cboCritere.Location = new System.Drawing.Point(20, 20);
            this.cboCritere.Name = "cboCritere";
            this.cboCritere.Size = new System.Drawing.Size(200, 21);
            this.cboCritere.TabIndex = 10;
            // 
            // lblNombreResultats
            // 
            this.lblNombreResultats.AutoSize = true;
            this.lblNombreResultats.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreResultats.Location = new System.Drawing.Point(23, 73);
            this.lblNombreResultats.Name = "lblNombreResultats";
            this.lblNombreResultats.Size = new System.Drawing.Size(195, 24);
            this.lblNombreResultats.TabIndex = 9;
            this.lblNombreResultats.Text = "nombre de résultats";
            // 
            // btnRechercher
            // 
            this.btnRechercher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRechercher.Location = new System.Drawing.Point(440, 10);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(138, 50);
            this.btnRechercher.TabIndex = 8;
            this.btnRechercher.Text = "Rechercher";
            this.btnRechercher.UseVisualStyleBackColor = true;
            this.btnRechercher.Click += new System.EventHandler(this.btnRechercher_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-6, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(959, 478);
            this.tabControl1.TabIndex = 14;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lstResultats);
            this.tabPage1.Controls.Add(this.cboCritere);
            this.tabPage1.Controls.Add(this.txtValeur);
            this.tabPage1.Controls.Add(this.btnRechercher);
            this.tabPage1.Controls.Add(this.btnReinitialise);
            this.tabPage1.Controls.Add(this.lblNombreResultats);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(951, 452);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Consultation";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnRetirerSport);
            this.tabPage2.Controls.Add(this.btnModifierNiveau);
            this.tabPage2.Controls.Add(this.btnAjouterSport);
            this.tabPage2.Controls.Add(this.lstSports);
            this.tabPage2.Controls.Add(this.btnSupprimer);
            this.tabPage2.Controls.Add(this.btnModifier);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.btnAjouter);
            this.tabPage2.Controls.Add(this.cboSport);
            this.tabPage2.Controls.Add(this.cboNiveau);
            this.tabPage2.Controls.Add(this.txtVille);
            this.tabPage2.Controls.Add(this.txtCp);
            this.tabPage2.Controls.Add(this.txtRue);
            this.tabPage2.Controls.Add(this.dtpDateNaiss);
            this.tabPage2.Controls.Add(this.txtPrenom);
            this.tabPage2.Controls.Add(this.txtNom);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(951, 452);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimer.Location = new System.Drawing.Point(693, 211);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(147, 43);
            this.btnSupprimer.TabIndex = 18;
            this.btnSupprimer.Text = "SUPPRIMER";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifier.Location = new System.Drawing.Point(693, 146);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(147, 45);
            this.btnModifier.TabIndex = 17;
            this.btnModifier.Text = "MODIFIER";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(199, 362);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "sport pratique";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(202, 317);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "niveau d exp";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(205, 270);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "ville";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(202, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "code postal";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(202, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "adresse";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(185, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "date naissance";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(202, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "prenom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(202, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "nom";
            // 
            // btnAjouter
            // 
            this.btnAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.Location = new System.Drawing.Point(693, 83);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(147, 39);
            this.btnAjouter.TabIndex = 8;
            this.btnAjouter.Text = "AJOUTER";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // cboSport
            // 
            this.cboSport.FormattingEnabled = true;
            this.cboSport.Location = new System.Drawing.Point(291, 362);
            this.cboSport.Name = "cboSport";
            this.cboSport.Size = new System.Drawing.Size(121, 21);
            this.cboSport.TabIndex = 7;
            // 
            // cboNiveau
            // 
            this.cboNiveau.FormattingEnabled = true;
            this.cboNiveau.Location = new System.Drawing.Point(291, 317);
            this.cboNiveau.Name = "cboNiveau";
            this.cboNiveau.Size = new System.Drawing.Size(121, 21);
            this.cboNiveau.TabIndex = 6;
            // 
            // txtVille
            // 
            this.txtVille.Location = new System.Drawing.Point(291, 270);
            this.txtVille.Name = "txtVille";
            this.txtVille.Size = new System.Drawing.Size(100, 20);
            this.txtVille.TabIndex = 5;
            // 
            // txtCp
            // 
            this.txtCp.Location = new System.Drawing.Point(291, 227);
            this.txtCp.Name = "txtCp";
            this.txtCp.Size = new System.Drawing.Size(100, 20);
            this.txtCp.TabIndex = 4;
            // 
            // txtRue
            // 
            this.txtRue.Location = new System.Drawing.Point(291, 178);
            this.txtRue.Name = "txtRue";
            this.txtRue.Size = new System.Drawing.Size(100, 20);
            this.txtRue.TabIndex = 3;
            // 
            // dtpDateNaiss
            // 
            this.dtpDateNaiss.Location = new System.Drawing.Point(291, 130);
            this.dtpDateNaiss.Name = "dtpDateNaiss";
            this.dtpDateNaiss.Size = new System.Drawing.Size(200, 20);
            this.dtpDateNaiss.TabIndex = 2;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(291, 83);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(100, 20);
            this.txtPrenom.TabIndex = 1;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(291, 41);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(100, 20);
            this.txtNom.TabIndex = 0;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(127, 223);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(239, 64);
            this.listView1.TabIndex = 19;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Width = 62;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(648, 251);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 49);
            this.button1.TabIndex = 18;
            this.button1.Text = "Reinitialise";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(395, 267);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(116, 20);
            this.textBox1.TabIndex = 17;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(386, 223);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(234, 21);
            this.comboBox1.TabIndex = 16;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(152, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 24);
            this.label1.TabIndex = 15;
            this.label1.Text = "nombre de résultats";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(648, 195);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 50);
            this.button2.TabIndex = 14;
            this.button2.Text = "Rechercher";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnRechercher_Click);
            // 
            // lstSports
            // 
            this.lstSports.HideSelection = false;
            this.lstSports.Location = new System.Drawing.Point(493, 317);
            this.lstSports.Name = "lstSports";
            this.lstSports.Size = new System.Drawing.Size(347, 97);
            this.lstSports.TabIndex = 19;
            this.lstSports.UseCompatibleStateImageBehavior = false;
            // 
            // btnAjouterSport
            // 
            this.btnAjouterSport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouterSport.Location = new System.Drawing.Point(493, 191);
            this.btnAjouterSport.Name = "btnAjouterSport";
            this.btnAjouterSport.Size = new System.Drawing.Size(160, 31);
            this.btnAjouterSport.TabIndex = 20;
            this.btnAjouterSport.Text = "Ajouter ce sport";
            this.btnAjouterSport.UseVisualStyleBackColor = true;
            this.btnAjouterSport.Click += new System.EventHandler(this.btnAjouterSport_Click);
            // 
            // btnModifierNiveau
            // 
            this.btnModifierNiveau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifierNiveau.Location = new System.Drawing.Point(493, 230);
            this.btnModifierNiveau.Name = "btnModifierNiveau";
            this.btnModifierNiveau.Size = new System.Drawing.Size(160, 33);
            this.btnModifierNiveau.TabIndex = 21;
            this.btnModifierNiveau.Text = "Modifier le niveau";
            this.btnModifierNiveau.UseVisualStyleBackColor = true;
            this.btnModifierNiveau.Click += new System.EventHandler(this.btnModifierNiveau_Click);
            // 
            // btnRetirerSport
            // 
            this.btnRetirerSport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetirerSport.Location = new System.Drawing.Point(493, 266);
            this.btnRetirerSport.Name = "btnRetirerSport";
            this.btnRetirerSport.Size = new System.Drawing.Size(160, 37);
            this.btnRetirerSport.TabIndex = 22;
            this.btnRetirerSport.Text = "Retirer ce sport";
            this.btnRetirerSport.UseVisualStyleBackColor = true;
            this.btnRetirerSport.Click += new System.EventHandler(this.btnRetirerSport_Click);
            // 
            // FrmSport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 472);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmSport";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmSport_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstResultats;
        private System.Windows.Forms.ColumnHeader Nom;
        private System.Windows.Forms.ColumnHeader Prénom;
        private System.Windows.Forms.ColumnHeader Ville;
        private System.Windows.Forms.ColumnHeader NiveauXp;
        private System.Windows.Forms.ColumnHeader nomSport;
        private System.Windows.Forms.Button btnReinitialise;
        private System.Windows.Forms.TextBox txtValeur;
        private System.Windows.Forms.ComboBox cboCritere;
        private System.Windows.Forms.Label lblNombreResultats;
        private System.Windows.Forms.Button btnRechercher;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox cboSport;
        private System.Windows.Forms.ComboBox cboNiveau;
        private System.Windows.Forms.TextBox txtVille;
        private System.Windows.Forms.TextBox txtCp;
        private System.Windows.Forms.TextBox txtRue;
        private System.Windows.Forms.DateTimePicker dtpDateNaiss;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.ListView lstSports;
        private System.Windows.Forms.Button btnAjouterSport;
        private System.Windows.Forms.Button btnModifierNiveau;
        private System.Windows.Forms.Button btnRetirerSport;
    }
}

