using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioMetier
{
    public class Pratique
    {
        public int IdSport;
        public string NomSport;
        public string Niveau;

        public Pratique(int idSport, string nomSport, string niveau)
        {
            this.IdSport = idSport;
            this.NomSport = nomSport;
            this.Niveau = niveau;
        }
    }
}
