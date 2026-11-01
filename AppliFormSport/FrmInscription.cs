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
    public partial class FrmInscription : Form
    {
        public FrmInscription()
        {
            InitializeComponent();

            txtLogin.MaxLength = 50;

            txtMotDePasse.MaxLength = 128;
            txtMotDePasse.UseSystemPasswordChar = true;

            txtConfirmation.MaxLength = 128;
            txtConfirmation.UseSystemPasswordChar = true;

            btnInscrire.Click -= btnInscrire_Click;
            btnInscrire.Click += btnInscrire_Click;
        }

        private void FrmInscription_Load(object sender, EventArgs e)
        {
        }

        private void btnInscrire_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text.Trim() == "" ||
                txtMotDePasse.Text == "" ||
                txtConfirmation.Text == "")
            {
                MessageBox.Show("Remplis tous les champs.");
            }
            else if (txtMotDePasse.Text != txtConfirmation.Text)
            {
                MessageBox.Show("Les mots de passe sont différents.");
            }
            else
            {
                try
                {
                    UtilisateurADO.Ajouter(
                        txtLogin.Text,
                        txtMotDePasse.Text
                    );

                    MessageBox.Show("Compte créé !");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}