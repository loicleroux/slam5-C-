using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SNCF.Metier
{
    public class Utilisateur
    {
        public int id {get; set;}
        public String nom { get; set;}
        public String prenom { get; set; }
        public String mail { get; set; }
        public String login { get; set; }
        public String mdp { get; set; }

        public Utilisateur(int id, string nom, string prenom, string mail, string login, string mdp)
        {
            this.id = id;
            this.nom = nom;
            this.prenom = prenom;
            this.mail = mail;
            this.login = login;
            this.mdp = mdp;
        }

        public Utilisateur()
        {

        }
    }
}
