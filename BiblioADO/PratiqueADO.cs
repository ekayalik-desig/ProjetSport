using BiblioMetier;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioADO
{
    public class PratiqueADO
    {
        public static List<Pratique> GetBySportif(int idSportif)
        {

            List<Pratique> lesPratiques = new List<Pratique>();

            using (MySqlConnection cnx = ConnexionManager.GetConnection())
            {
                cnx.Open();

                string req =
                    "SELECT Sport.id, Sport.nom, Niveau.libelle " +
                    "FROM Pratiquer " +
                    "INNER JOIN Sport ON Pratiquer.idSport = Sport.id " +
                    "INNER JOIN Niveau ON Pratiquer.idNiveau = Niveau.id " +
                    "WHERE Pratiquer.idSportif = @idSportif";

                using (MySqlCommand cmd = new MySqlCommand(req, cnx))
                {
                    cmd.Parameters.AddWithValue("@idSportif", idSportif);

                    using (MySqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            Pratique pratique = new Pratique(
                                rdr.GetInt32(0),
                                rdr.GetString(1),
                                rdr.GetString(2)
                            );

                            lesPratiques.Add(pratique);
                        }
                    }
                }
            }

            return lesPratiques;
        }
        public static int Ajouter(int idSportif, string sport, string niveau)
        {
            using (MySqlConnection cnx = ConnexionManager.GetConnection())
            {
                cnx.Open();

                string req =
                    "INSERT INTO Pratiquer (idSportif, idSport, idNiveau) " +
                    "SELECT @idSportif, Sport.id, Niveau.id " +
                    "FROM Sport CROSS JOIN Niveau " +
                    "WHERE Sport.nom = @sport " +
                    "AND Niveau.libelle = @niveau";

                using (MySqlCommand cmd = new MySqlCommand(req, cnx))
                {
                    cmd.Parameters.AddWithValue("@idSportif", idSportif);
                    cmd.Parameters.AddWithValue("@sport", sport);
                    cmd.Parameters.AddWithValue("@niveau", niveau);

                    return cmd.ExecuteNonQuery();
                }
            }
        }
        public static int ModifierNiveau(
         int idSportif, int idSport, string niveau)
        {
            using (MySqlConnection cnx = ConnexionManager.GetConnection())
            {
                cnx.Open();

                string req =
                    "UPDATE Pratiquer " +
                    "INNER JOIN Niveau ON Niveau.libelle = @niveau " +
                    "SET Pratiquer.idNiveau = Niveau.id " +
                    "WHERE Pratiquer.idSportif = @idSportif " +
                    "AND Pratiquer.idSport = @idSport";

                using (MySqlCommand cmd = new MySqlCommand(req, cnx))
                {
                    cmd.Parameters.AddWithValue("@idSportif", idSportif);
                    cmd.Parameters.AddWithValue("@idSport", idSport);
                    cmd.Parameters.AddWithValue("@niveau", niveau);

                    return cmd.ExecuteNonQuery();
                }
            }

        }
        public static int Supprimer(int idSportif, int idSport)
        {
            using (MySqlConnection cnx = ConnexionManager.GetConnection())
            {
                cnx.Open();

                string req =
                    "DELETE FROM Pratiquer " +
                    "WHERE idSportif = @idSportif " +
                    "AND idSport = @idSport";

                using (MySqlCommand cmd = new MySqlCommand(req, cnx))
                {
                    cmd.Parameters.AddWithValue("@idSportif", idSportif);
                    cmd.Parameters.AddWithValue("@idSport", idSport);

                    return cmd.ExecuteNonQuery();
                }
            }
        }

    }
}