using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BiblioADO;

namespace AppliFormSport
{
    public partial class FrmConnexion : Form
    {
        public FrmConnexion()
        {
            InitializeComponent();
            txtMotDePasse.UseSystemPasswordChar = true;
            btnConnexion.Click -= btnConnexion_Click;
            btnConnexion.Click += btnConnexion_Click;

            txtMotDePasse.UseSystemPasswordChar = true;
            txtMotDePasse.MaxLength = 128;
            txtLogin.MaxLength = 50;
        }

        private void txtMotDePasse_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCreerCompte_Click(object sender, EventArgs e)
        {
            FrmInscription fenetre = new FrmInscription();
            fenetre.ShowDialog();
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text.Trim() == "" || txtMotDePasse.Text == "")
            {
                MessageBox.Show("Remplis le login et le mot de passe.");
            }
            else
            {
                try
                {
                    bool connexionValide = UtilisateurADO.VerifierConnexion(
                        txtLogin.Text,
                        txtMotDePasse.Text
                    );

                    if (connexionValide == true)
                    {
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("Login ou mot de passe incorrect.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connexion impossible : " + ex.Message);
                }
            }
        }

        private void btnChangerMotDePasse_Click(object sender, EventArgs e)
        {
            FrmChangerMotDePasse fenetre = new FrmChangerMotDePasse();
            fenetre.ShowDialog();
        }
    }
}