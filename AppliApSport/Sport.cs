using MongoDB.Driver.Core.Configuration;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace AppliApSport

{
    public partial class Sport : Form
    {
        public Sport()
        {
            InitializeComponent();
        }

        private void Sport_Load(object sender, EventArgs e)
        {
            lstResultats.View = View.Details;
            lstResultats.FullRowSelect = true;
            lstResultats.GridLines = true;

            lstResultats.Columns.Add("Id", 40);
            lstResultats.Columns.Add("Nom", 90);
            lstResultats.Columns.Add("Prénom", 90);
            lstResultats.Columns.Add("Ville", 90);
            lstResultats.Columns.Add("Niveau", 90);
            lstResultats.Columns.Add("Sport", 90);

            cboCritere.Items.Add("ville");
            cboCritere.Items.Add("niveau_experience");
            cboCritere.Items.Add("nom_sport");
            cboCritere.SelectedIndex = 0;

            List<Sportif> lesSportifs = SportifADO.GetAll();
            AfficherListe(lesSportifs);
             private void AfficherListe(List<Sportif> lesSportifs)
        {
            lstResultats.Items.Clear();
            foreach (Sportif s in lesSportifs)
            {
                ListViewItem item = new ListViewItem(s.Id.ToString());
                item.SubItems.Add(s.Nom);
                item.SubItems.Add(s.Prenom);
                item.SubItems.Add(s.Ville);
                item.SubItems.Add(s.NiveauXp);
                item.SubItems.Add(s.NomSport);
                lstResultats.Items.Add(item);
            }
            lblNombreResultats.Text = lesSportifs.Count.ToString();
        }

        

        private void ChargerSportifs(string v)
        {
           

            
        }        

        private void lblNiveau_Click(object sender, EventArgs e)
        {


        }

        private void btnReinitialise_Click(object sender, EventArgs e)
        {
            txtValeur.Clear();
        }

        private void comboBoxMenu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstResultats_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            

        }
    }

    internal class Sportif
    {
    }
}
