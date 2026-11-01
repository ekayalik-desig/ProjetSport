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
    public partial class FrmChangerMotDePasse : Form
    {
        public FrmChangerMotDePasse()
        {
            InitializeComponent();
            txtLogin.MaxLength = 50;

            txtAncien.UseSystemPasswordChar = true;
            txtNouveau.UseSystemPasswordChar = true;
            txtConfirmation.UseSystemPasswordChar = true;

            txtAncien.MaxLength = 128;
            txtNouveau.MaxLength = 128;
            txtConfirmation.MaxLength = 128;
        }

        private void FrmChangerMotDePasse_Load(object sender, EventArgs e)
        {

        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text.Trim() == "" ||
        txtAncien.Text == "" ||
        txtNouveau.Text == "" ||
        txtConfirmation.Text == "")
            {
                MessageBox.Show("Remplis tous les champs.");
            }
            else if (txtNouveau.Text != txtConfirmation.Text)
            {
                MessageBox.Show("Les nouveaux mots de passe sont différents.");
            }
            else if (txtNouveau.Text == txtAncien.Text)
            {
                MessageBox.Show("Choisis un mot de passe différent de l'ancien.");
            }
            else
            {
                try
                {
                    bool modification = UtilisateurADO.ChangerMotDePasse(
                        txtLogin.Text,
                        txtAncien.Text,
                        txtNouveau.Text
                    );

                    if (modification == true)
                    {
                        MessageBox.Show("Mot de passe modifié !");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Login ou ancien mot de passe incorrect.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
