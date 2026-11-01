using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiblioMetier
{
    public class Sportif
    {
        public int Id;
        public string Nom;
        public string Prenom;
        public DateTime DateNaiss;
        public string Rue;
        public string Cp;
        public string Ville;
        public string NiveauXp;
        public string NomSport;

        public Sportif(int id, string nom, string prenom, DateTime dateNaiss,
                       string rue, string cp, string ville,
                       string niveauXp, string nomSport)
        {
            this.Id = id;
            this.Nom = nom;
            this.Prenom = prenom;
            this.DateNaiss = dateNaiss;
            this.Rue = rue;
            this.Cp = cp;
            this.Ville = ville;
            this.NiveauXp = niveauXp;
            this.NomSport = nomSport;
        }

        public Sportif(string nom, string prenom, string ville,
                       string niveauXp, string nomSport)
        {
            this.Nom = nom;
            this.Prenom = prenom;
            this.Ville = ville;
            this.NiveauXp = niveauXp;
            this.NomSport = nomSport;
        }

    }
}
