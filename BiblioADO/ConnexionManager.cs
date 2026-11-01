using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioADO
{
    public class ConnexionManager
    {
        public static MySqlConnection GetConnection()
        {
            string chaineConnexion = ConfigurationManager.ConnectionStrings["cnxBdSport"].ConnectionString;
            return new MySqlConnection(chaineConnexion);
        }

    }
}
