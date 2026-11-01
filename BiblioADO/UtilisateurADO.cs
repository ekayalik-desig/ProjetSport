using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BiblioMetier;

namespace BiblioADO
{
    public class UtilisateurADO
    {
        public static void Ajouter(string login, string motDePasse)
        {
            using (MySqlConnection cnx = ConnexionManager.GetConnection())
            {
                cnx.Open();

                string req =
                    "INSERT INTO Utilisateur (login, motDePasse) " +
                    "VALUES (@login, @motDePasse)";

                using (MySqlCommand cmd = new MySqlCommand(req, cnx))
                {
                    cmd.Parameters.AddWithValue("@login", login.Trim());
                    cmd.Parameters.AddWithValue("@motDePasse", motDePasse);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Vérifier le login et le mot de passe
        public static bool VerifierConnexion(
            string login, string motDePasse)
        {
            bool connexionValide = false;

            using (MySqlConnection cnx = ConnexionManager.GetConnection())
            {
                cnx.Open();

                string req =
                    "SELECT motDePasse FROM Utilisateur " +
                    "WHERE login = @login";

                using (MySqlCommand cmd = new MySqlCommand(req, cnx))
                {
                    cmd.Parameters.AddWithValue("@login", login.Trim());

                    using (MySqlDataReader lecteur = cmd.ExecuteReader())
                    {
                        if (lecteur.Read())
                        {
                            string motDePasseEnregistre =
                                lecteur.GetString(0);

                            if (motDePasse == motDePasseEnregistre)
                            {
                                connexionValide = true;
                            }
                        }
                    }
                }
            }

            return connexionValide;
        }

        // Changer le mot de passe
        public static bool ChangerMotDePasse(
            string login, string ancien, string nouveau)
        {
            bool modification = false;

            if (VerifierConnexion(login, ancien) == true)
            {
                using (MySqlConnection cnx = ConnexionManager.GetConnection())
                {
                    cnx.Open();

                    string req =
                        "UPDATE Utilisateur SET motDePasse = @nouveau " +
                        "WHERE login = @login";

                    using (MySqlCommand cmd = new MySqlCommand(req, cnx))
                    {
                        cmd.Parameters.AddWithValue("@nouveau", nouveau);
                        cmd.Parameters.AddWithValue("@login", login.Trim());

                        int nombre = cmd.ExecuteNonQuery();

                        if (nombre == 1)
                        {
                            modification = true;
                        }
                    }
                }
            }

            return modification;
        }
    }
}
    

