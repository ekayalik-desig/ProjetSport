using BiblioMetier;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace BiblioADO
{
    public class SportifADO
    {
        public static List<Sportif> GetAll()
        {
            return SearchByCritere("ville", "");
        }

        public static List<Sportif> SearchByCritere(
            string colonne, string valeur)
        {
            List<Sportif> lesSportifs = new List<Sportif>();

            string critere = "Sportif.ville";

            if (colonne == "niveauXp")
            {
                critere = "Niveau.libelle";
            }
            else if (colonne == "nomSport")
            {
                critere = "Sport.nom";
            }

            string req =
                "SELECT Sportif.id, Sportif.nom, Sportif.prenom, " +
                "Sportif.dateNaiss, Sportif.rue, Sportif.cp, Sportif.ville, " +
                "Sport.nom AS sport, Niveau.libelle AS niveau " +
                "FROM Sportif " +
                "LEFT JOIN Pratiquer ON Sportif.id = Pratiquer.idSportif " +
                "LEFT JOIN Sport ON Pratiquer.idSport = Sport.id " +
                "LEFT JOIN Niveau ON Pratiquer.idNiveau = Niveau.id ";

            if (valeur.Trim() != "")
            {
                req += "WHERE " + critere + " LIKE @valeur ";
            }

            req += "ORDER BY Sportif.nom, Sportif.prenom, Sport.nom";

            using (MySqlConnection cnx = ConnexionManager.GetConnection())
            {
                cnx.Open();

                using (MySqlCommand cmd = new MySqlCommand(req, cnx))
                {
                    if (valeur.Trim() != "")
                    {
                        cmd.Parameters.AddWithValue(
                            "@valeur", "%" + valeur.Trim() + "%");
                    }

                    using (MySqlDataReader rdr = cmd.ExecuteReader())
                    {
                        while (rdr.Read())
                        {
                            int id = Convert.ToInt32(rdr["id"]);
                            string nom = rdr["nom"].ToString();
                            string prenom = rdr["prenom"].ToString();
                            string rue = rdr["rue"].ToString();
                            string cp = rdr["cp"].ToString();
                            string ville = rdr["ville"].ToString();
                            string sport = rdr["sport"].ToString();
                            string niveau = rdr["niveau"].ToString();

                            DateTime dateNaiss = DateTime.MinValue;

                            if (rdr["dateNaiss"] != DBNull.Value)
                            {
                                dateNaiss =
                                    Convert.ToDateTime(rdr["dateNaiss"]);
                            }

                            Sportif sportif = new Sportif(
                                id, nom, prenom, dateNaiss,
                                rue, cp, ville, niveau, sport
                            );

                            lesSportifs.Add(sportif);
                        }
                    }
                }
            }

            return lesSportifs;
        }

        public static void Ajouter(Sportif sportif)
        {
            using (MySqlConnection cnx = ConnexionManager.GetConnection())
            {
                cnx.Open();

                using (MySqlTransaction transaction = cnx.BeginTransaction())
                {
                    string req =
                        "INSERT INTO Sportif " +
                        "(nom, prenom, dateNaiss, rue, cp, ville) " +
                        "VALUES (@nom, @prenom, @dateNaiss, @rue, @cp, @ville)";

                    int idSportif;

                    using (MySqlCommand cmd =
                        new MySqlCommand(req, cnx, transaction))
                    {
                        cmd.Parameters.AddWithValue("@nom", sportif.Nom);
                        cmd.Parameters.AddWithValue("@prenom", sportif.Prenom);
                        cmd.Parameters.AddWithValue("@dateNaiss", sportif.DateNaiss);
                        cmd.Parameters.AddWithValue("@rue", sportif.Rue);
                        cmd.Parameters.AddWithValue("@cp", sportif.Cp);
                        cmd.Parameters.AddWithValue("@ville", sportif.Ville);

                        cmd.ExecuteNonQuery();

                        idSportif = Convert.ToInt32(cmd.LastInsertedId);
                    }

                    string reqSport =
                        "INSERT INTO Pratiquer (idSportif, idSport, idNiveau) " +
                        "SELECT @idSportif, Sport.id, Niveau.id " +
                        "FROM Sport CROSS JOIN Niveau " +
                        "WHERE Sport.nom = @sport " +
                        "AND Niveau.libelle = @niveau";

                    using (MySqlCommand cmd =
                        new MySqlCommand(reqSport, cnx, transaction))
                    {
                        cmd.Parameters.AddWithValue("@idSportif", idSportif);
                        cmd.Parameters.AddWithValue("@sport", sportif.NomSport);
                        cmd.Parameters.AddWithValue("@niveau", sportif.NiveauXp);

                        int nombre = cmd.ExecuteNonQuery();

                        if (nombre != 1)
                        {
                            throw new Exception("Sport ou niveau incorrect.");
                        }
                    }

                    transaction.Commit();
                }
            }
        }

        public static int Modifier(Sportif sportif)
        {
            using (MySqlConnection cnx = ConnexionManager.GetConnection())
            {
                cnx.Open();

                string req =
                    "UPDATE Sportif SET " +
                    "nom = @nom, prenom = @prenom, " +
                    "dateNaiss = @dateNaiss, rue = @rue, " +
                    "cp = @cp, ville = @ville " +
                    "WHERE id = @id";

                using (MySqlCommand cmd = new MySqlCommand(req, cnx))
                {
                    cmd.Parameters.AddWithValue("@id", sportif.Id);
                    cmd.Parameters.AddWithValue("@nom", sportif.Nom);
                    cmd.Parameters.AddWithValue("@prenom", sportif.Prenom);
                    cmd.Parameters.AddWithValue("@dateNaiss", sportif.DateNaiss);
                    cmd.Parameters.AddWithValue("@rue", sportif.Rue);
                    cmd.Parameters.AddWithValue("@cp", sportif.Cp);
                    cmd.Parameters.AddWithValue("@ville", sportif.Ville);

                    return cmd.ExecuteNonQuery();
                }
            }
        }

        public static int Supprimer(int id)
        {
            using (MySqlConnection cnx = ConnexionManager.GetConnection())
            {
                cnx.Open();

                using (MySqlTransaction transaction = cnx.BeginTransaction())
                {
                    string reqPratiques =
                        "DELETE FROM Pratiquer WHERE idSportif = @id";

                    using (MySqlCommand cmd =
                        new MySqlCommand(reqPratiques, cnx, transaction))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                    }

                    string reqSportif =
                        "DELETE FROM Sportif WHERE id = @id";

                    int nombre;

                    using (MySqlCommand cmd =
                        new MySqlCommand(reqSportif, cnx, transaction))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        nombre = cmd.ExecuteNonQuery();
                    }

                    transaction.Commit();

                    return nombre;
                }
            }
        }
    }
}