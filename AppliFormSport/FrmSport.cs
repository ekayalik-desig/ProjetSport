
using BiblioADO;
using BiblioMetier;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppliFormSport
{
    public partial class FrmSport : Form
    {
        private int idSportifSelectionne = 0;
        public FrmSport()
        {
            InitializeComponent();

            this.Load -= FrmSport_Load;
            this.Load += FrmSport_Load;

            btnRechercher.Click -= btnRechercher_Click;
            btnRechercher.Click += btnRechercher_Click;

            btnReinitialise.Click -= btnReinitialise_Click;
            btnReinitialise.Click += btnReinitialise_Click;

            lstResultats.MultiSelect = false;

            lstResultats.SelectedIndexChanged -= lstResultats_SelectedIndexChanged;
            lstResultats.SelectedIndexChanged += lstResultats_SelectedIndexChanged;
        }

        private void FrmSport_Load(object sender, EventArgs e)
        {
            lstSports.View = View.Details;
            lstSports.FullRowSelect = true;
            lstSports.GridLines = true;
            lstSports.MultiSelect = false;
            lstSports.HideSelection = false;

            lstSports.Columns.Clear();
            lstSports.Columns.Add("Sport", 150);
            lstSports.Columns.Add("Niveau", 150);


            lstResultats.View = View.Details;
            lstResultats.FullRowSelect = true;
            lstResultats.GridLines = true;

            lstResultats.Columns.Clear();
            lstResultats.Columns.Add("Id", 40);
            lstResultats.Columns.Add("Nom", 90);
            lstResultats.Columns.Add("Prénom", 90);
            lstResultats.Columns.Add("Ville", 90);
            lstResultats.Columns.Add("Niveau", 90);
            lstResultats.Columns.Add("Sport", 90);

            cboCritere.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCritere.Items.Clear();

            cboCritere.Items.Add("Ville");
            cboCritere.Items.Add("Niveau d'expérience");
            cboCritere.Items.Add("Nom du sport");
            cboCritere.SelectedIndex = 0;

            try
            {
                AfficherListe(SportifADO.GetAll());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur de chargement des sportifs :\n" + ex.Message);
            }

            try
            {
                InitialiserAjout();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur de préparation du formulaire d'ajout :\n"
                    + ex.Message);
            }
        }
        
        private void AfficherListe(List<Sportif> lesSportifs)
        {
            lstResultats.Items.Clear();
            idSportifSelectionne = 0;

            foreach (Sportif s in lesSportifs)
            {
                ListViewItem item = new ListViewItem(s.Id.ToString());
                item.SubItems.Add(s.Nom);
                item.SubItems.Add(s.Prenom);
                item.SubItems.Add(s.Ville);
                item.SubItems.Add(s.NiveauXp);
                item.SubItems.Add(s.NomSport);
                item.Tag = s;
                lstResultats.Items.Add(item);
            }

            lblNombreResultats.Text = lesSportifs.Count.ToString();
        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            try
            {
                ChargerSportifs();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur de recherche :\n" + ex.Message);
            }
        }

        private void btnReinitialise_Click(object sender, EventArgs e)
        {
            txtValeur.Clear();

            List<Sportif> lesSportifs = SportifADO.GetAll();
            AfficherListe(lesSportifs);
        }

        private void ChargerSportifs()
        {
            string valeur = txtValeur.Text.Trim();
            string colonne = "";

            if (valeur == "")
            {
                AfficherListe(SportifADO.GetAll());
            }
            else
            {
                if (cboCritere.SelectedIndex == 0)
                {
                    colonne = "ville";
                }
                else if (cboCritere.SelectedIndex == 1)
                {
                    colonne = "niveauXp";
                }
                else if (cboCritere.SelectedIndex == 2)
                {
                    colonne = "nomSport";
                }

                if (colonne == "")
                {
                    MessageBox.Show("Choisis un critère.");
                }
                else
                {
                    List<Sportif> lesSportifs =
                        SportifADO.SearchByCritere(colonne, valeur);

                    AfficherListe(lesSportifs);
                }
            }
        }


        

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
        private void InitialiserAjout()
        {
            cboNiveau.DropDownStyle = ComboBoxStyle.DropDownList;
            cboNiveau.Items.Clear();

            cboNiveau.Items.Add("Débutant");
            cboNiveau.Items.Add("Confirmé");
            cboNiveau.Items.Add("Avancé");
            cboNiveau.Items.Add("Professionnel");

            cboSport.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSport.Items.Clear();

            cboSport.Items.Add("Football");
            cboSport.Items.Add("Tennis");
            cboSport.Items.Add("Judo");
            cboSport.Items.Add("Natation");
            cboSport.Items.Add("Basketball");
            cboSport.Items.Add("Rugby");
            cboSport.Items.Add("Course");

            txtNom.MaxLength = 25;
            txtPrenom.MaxLength = 25;
            txtRue.MaxLength = 100;
            txtCp.MaxLength = 5;
            txtVille.MaxLength = 25;

            dtpDateNaiss.Format = DateTimePickerFormat.Short;
            dtpDateNaiss.MaxDate = DateTime.Today;
            dtpDateNaiss.ShowCheckBox = true;
            dtpDateNaiss.Checked = false;
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            string cp = txtCp.Text.Trim();
            bool codePostalValide = true;

            if (cp.Length != 5)
            {
                codePostalValide = false;
            }

            foreach (char caractere in cp)
            {
                if (caractere < '0' || caractere > '9')
                {
                    codePostalValide = false;
                }
            }

            if (txtNom.Text.Trim() == "" ||
                txtPrenom.Text.Trim() == "" ||
                txtRue.Text.Trim() == "" ||
                cp == "" ||
                txtVille.Text.Trim() == "")
            {
                MessageBox.Show("Remplis tous les champs.");
            }
            else if (cboNiveau.SelectedIndex == -1 ||
                     cboSport.SelectedIndex == -1)
            {
                MessageBox.Show("Choisis un niveau et un sport.");
            }
            else if (codePostalValide == false)
            {
                MessageBox.Show("Le code postal doit contenir 5 chiffres.");
            }
            else if (dtpDateNaiss.Checked == false ||
                     dtpDateNaiss.Value.Date > DateTime.Today)
            {
                MessageBox.Show("Choisis une date de naissance et coche sa case");
            }
            else
            {
                Sportif sportif = new Sportif(
                    0,
                    txtNom.Text.Trim(),
                    txtPrenom.Text.Trim(),
                    dtpDateNaiss.Value.Date,
                    txtRue.Text.Trim(),
                    cp,
                    txtVille.Text.Trim(),
                    cboNiveau.Text,
                    cboSport.Text
                );

                try
                {
                    SportifADO.Ajouter(sportif);
                    idSportifSelectionne = 0;

                    MessageBox.Show("Sportif ajouté !");

                    txtNom.Clear();
                    txtPrenom.Clear();
                    txtRue.Clear();
                    txtCp.Clear();
                    txtVille.Clear();

                    cboNiveau.SelectedIndex = -1;
                    cboSport.SelectedIndex = -1;

                    dtpDateNaiss.Value = DateTime.Today;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur : " + ex.Message);
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void lstResultats_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstResultats.SelectedItems.Count > 0)
            {
                Sportif sportif =
                    (Sportif)lstResultats.SelectedItems[0].Tag;

                idSportifSelectionne = sportif.Id;
                try
                {
                    AfficherSports(idSportifSelectionne);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur de chargement des sports : " + ex.Message);
                }

                txtNom.Text = sportif.Nom;
                txtPrenom.Text = sportif.Prenom;
                txtRue.Text = sportif.Rue;
                txtCp.Text = sportif.Cp;
                txtVille.Text = sportif.Ville;

                cboNiveau.SelectedItem = sportif.NiveauXp;
                cboSport.SelectedItem = sportif.NomSport;

                if (sportif.DateNaiss >= dtpDateNaiss.MinDate &&
                    sportif.DateNaiss <= dtpDateNaiss.MaxDate)
                {
                    dtpDateNaiss.Value = sportif.DateNaiss;
                    dtpDateNaiss.Checked = true;
                }
                else
                {
                    dtpDateNaiss.Value = DateTime.Today;
                    dtpDateNaiss.Checked = false;
                }

                tabControl1.SelectedTab = tabPage2;

               
            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            string cp = txtCp.Text.Trim();
            bool codePostalValide = true;

            if (cp.Length != 5)
            {
                codePostalValide = false;
            }

            foreach (char caractere in cp)
            {
                if (caractere < '0' || caractere > '9')
                {
                    codePostalValide = false;
                }
            }

            if (idSportifSelectionne == 0)
            {
                MessageBox.Show("Sélectionne un sportif dans Consultation.");
            }
            else if (txtNom.Text.Trim() == "" ||
                     txtPrenom.Text.Trim() == "" ||
                     txtRue.Text.Trim() == "" ||
                     cp == "" ||
                     txtVille.Text.Trim() == "")
            {
                MessageBox.Show("Remplis tous les champs.");
            }
           
            else if (codePostalValide == false)
            {
                MessageBox.Show("Le code postal doit contenir 5 chiffres.");
            }
            else if (!dtpDateNaiss.Checked ||
                     dtpDateNaiss.Value.Date > DateTime.Today)
            {
                MessageBox.Show("Renseigne une date de naissance valide et coche sa case.");
            }
            else
            {
                Sportif sportif = new Sportif(
                        idSportifSelectionne,
                        txtNom.Text.Trim(),
                        txtPrenom.Text.Trim(),
                        dtpDateNaiss.Value.Date,
                        txtRue.Text.Trim(),
                        cp,
                        txtVille.Text.Trim(),
                        "",
                    ""
                 );

                try
                {
                    int resultat = SportifADO.Modifier(sportif);

                    if (resultat > 0)
                    {
                        MessageBox.Show("Modification enregistrée !");
                    }
                    else
                    {
                        MessageBox.Show(
                            "Aucune ligne modifiée : les données sont identiques "
                            + "ou le sportif n'existe plus.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur de modification :\n" + ex.Message);
                }

            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (idSportifSelectionne == 0)
            {
                MessageBox.Show("Sélectionne un sportif.");
            }
            else
            {
                DialogResult choix = MessageBox.Show(
                    "Supprimer ce sportif ?",
                    "Confirmation",
                    MessageBoxButtons.YesNo);

                if (choix == DialogResult.Yes)
                {
                    try
                    {
                        int nombre = SportifADO.Supprimer(idSportifSelectionne);

                        idSportifSelectionne = 0;

                        if (nombre == 1)
                        {
                            MessageBox.Show("Sportif supprimé.");
                        }
                        else
                        {
                            MessageBox.Show("Ce sportif n'existe plus.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erreur : " + ex.Message);
                    }
                }
            }
        }
        private void AfficherSports(int idSportif)
        {
            lstSports.Items.Clear();

            List<Pratique> lesPratiques =
                PratiqueADO.GetBySportif(idSportif);
            

            foreach (Pratique pratique in lesPratiques)
            {
                ListViewItem ligne = new ListViewItem(pratique.NomSport);

                ligne.SubItems.Add(pratique.Niveau);
                ligne.Tag = pratique;

                lstSports.Items.Add(ligne);
            }
        }

        private void btnAjouterSport_Click(object sender, EventArgs e)
        {
            if (idSportifSelectionne == 0)
            {
                MessageBox.Show("Sélectionne un sportif dans Consultation.");
            }
            else if (cboSport.SelectedIndex == -1 ||
                     cboNiveau.SelectedIndex == -1)
            {
                MessageBox.Show("Choisis un sport et un niveau.");
            }
            else
            {
                try
                {
                    int nombre = PratiqueADO.Ajouter(
                        idSportifSelectionne,
                        cboSport.Text,
                        cboNiveau.Text
                    );

                    if (nombre == 1)
                    {
                        AfficherSports(idSportifSelectionne);
                        MessageBox.Show("Sport ajouté !");
                    }
                    else
                    {
                        MessageBox.Show("Sport ou niveau introuvable dans la base.");
                    }
                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {
                    if (ex.Number == 1062)
                    {
                        MessageBox.Show("Ce sportif pratique déjà ce sport.");
                    }
                    else
                    {
                        MessageBox.Show("Erreur : " + ex.Message);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur : " + ex.Message);
                }
            }
        }

        private void btnModifierNiveau_Click(object sender, EventArgs e)
        {
            if (idSportifSelectionne == 0)
            {
                MessageBox.Show("Sélectionne un sportif dans Consultation.");
            }
            else if (lstSports.SelectedItems.Count == 0)
            {
                MessageBox.Show("Sélectionne un sport dans le tableau.");
            }
            else if (cboNiveau.SelectedIndex == -1)
            {
                MessageBox.Show("Choisis un niveau.");
            }
            else
            {
                Pratique pratique =
                    (Pratique)lstSports.SelectedItems[0].Tag;

                try
                {
                    int nombre = PratiqueADO.ModifierNiveau(
                        idSportifSelectionne,
                        pratique.IdSport,
                        cboNiveau.Text
                    );

                    if (nombre > 0)
                    {
                        AfficherSports(idSportifSelectionne);
                        MessageBox.Show("Niveau enregistré !");
                    }
                    else
                    {
                        MessageBox.Show(
                            "Aucune modification : niveau identique ou pratique introuvable.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur : " + ex.Message);
                }
            }
        }

        private void btnRetirerSport_Click(object sender, EventArgs e)
        {
            if (idSportifSelectionne == 0)
            {
                MessageBox.Show("Sélectionne un sportif dans Consultation.");
            }
            else if (lstSports.SelectedItems.Count == 0)
            {
                MessageBox.Show("Sélectionne un sport dans le tableau.");
            }
            else
            {
                Pratique pratique =
                    (Pratique)lstSports.SelectedItems[0].Tag;

                DialogResult choix = MessageBox.Show(
                    "Retirer le sport " + pratique.NomSport + " à ce sportif ?",
                    "Confirmation",
                    MessageBoxButtons.YesNo
                );

                if (choix == DialogResult.Yes)
                {
                    try
                    {
                        int nombre = PratiqueADO.Supprimer(
                            idSportifSelectionne,
                            pratique.IdSport
                        );

                        AfficherSports(idSportifSelectionne);

                        if (nombre == 1)
                        {
                            MessageBox.Show("Sport retiré !");
                        }
                        else
                        {
                            MessageBox.Show("Ce sportif ne pratique plus ce sport.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erreur : " + ex.Message);
                    }
                }
            }
        }
    }
        
 }
    
    
