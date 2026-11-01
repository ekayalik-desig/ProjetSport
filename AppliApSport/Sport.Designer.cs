namespace AppliApSport
{
    partial class Sport
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
            this.btnRechercher = new System.Windows.Forms.Button();
            this.lblNombreResultats = new System.Windows.Forms.Label();
            this.cboCritere = new System.Windows.Forms.ComboBox();
            this.txtValeur = new System.Windows.Forms.TextBox();
            this.btnReinitialise = new System.Windows.Forms.Button();
            this.lstResultats = new System.Windows.Forms.ListView();
            this.Nom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Prénom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ville = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NiveauXp = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nomSport = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnRechercher
            // 
            this.btnRechercher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRechercher.Location = new System.Drawing.Point(712, 242);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(138, 50);
            this.btnRechercher.TabIndex = 0;
            this.btnRechercher.Text = "Rechercher";
            this.btnRechercher.UseVisualStyleBackColor = true;
            this.btnRechercher.Click += new System.EventHandler(this.btnRechercher_Click);
            // 
            // lblNombreResultats
            // 
            this.lblNombreResultats.AutoSize = true;
            this.lblNombreResultats.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreResultats.Location = new System.Drawing.Point(509, 39);
            this.lblNombreResultats.Name = "lblNombreResultats";
            this.lblNombreResultats.Size = new System.Drawing.Size(195, 24);
            this.lblNombreResultats.TabIndex = 3;
            this.lblNombreResultats.Text = "nombre de résultats";
            // 
            // cboCritere
            // 
            this.cboCritere.FormattingEnabled = true;
            this.cboCritere.Location = new System.Drawing.Point(618, 172);
            this.cboCritere.Name = "cboCritere";
            this.cboCritere.Size = new System.Drawing.Size(234, 21);
            this.cboCritere.TabIndex = 4;
            this.cboCritere.SelectedIndexChanged += new System.EventHandler(this.comboBoxMenu_SelectedIndexChanged);
            // 
            // txtValeur
            // 
            this.txtValeur.Location = new System.Drawing.Point(34, 242);
            this.txtValeur.Name = "txtValeur";
            this.txtValeur.Size = new System.Drawing.Size(116, 20);
            this.txtValeur.TabIndex = 5;
            // 
            // btnReinitialise
            // 
            this.btnReinitialise.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReinitialise.Location = new System.Drawing.Point(712, 312);
            this.btnReinitialise.Name = "btnReinitialise";
            this.btnReinitialise.Size = new System.Drawing.Size(138, 49);
            this.btnReinitialise.TabIndex = 6;
            this.btnReinitialise.Text = "Reinitialise";
            this.btnReinitialise.UseVisualStyleBackColor = true;
            this.btnReinitialise.Click += new System.EventHandler(this.btnReinitialise_Click);
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
            this.lstResultats.Location = new System.Drawing.Point(221, 186);
            this.lstResultats.Name = "lstResultats";
            this.lstResultats.Size = new System.Drawing.Size(303, 97);
            this.lstResultats.TabIndex = 7;
            this.lstResultats.UseCompatibleStateImageBehavior = false;
            this.lstResultats.View = System.Windows.Forms.View.Details;
            this.lstResultats.SelectedIndexChanged += new System.EventHandler(this.lstResultats_SelectedIndexChanged);
            // 
            // Ville
            // 
            this.Ville.Width = 62;
            // 
            // Sport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 450);
            this.Controls.Add(this.lstResultats);
            this.Controls.Add(this.btnReinitialise);
            this.Controls.Add(this.txtValeur);
            this.Controls.Add(this.cboCritere);
            this.Controls.Add(this.lblNombreResultats);
            this.Controls.Add(this.btnRechercher);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Sport";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Sport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRechercher;
        private System.Windows.Forms.Label lblNombreResultats;
        private System.Windows.Forms.ComboBox cboCritere;
        private System.Windows.Forms.TextBox txtValeur;
        private System.Windows.Forms.Button btnReinitialise;
        private System.Windows.Forms.ListView lstResultats;
        private System.Windows.Forms.ColumnHeader Nom;
        private System.Windows.Forms.ColumnHeader Prénom;
        private System.Windows.Forms.ColumnHeader Ville;
        private System.Windows.Forms.ColumnHeader NiveauXp;
        private System.Windows.Forms.ColumnHeader nomSport;
    }
}

