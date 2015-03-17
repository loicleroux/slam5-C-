using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using SNCF.Metier;
using System.Data.SqlClient;

namespace SNCF.Dao
{
    class DaoUtilisateur
    {
        public DaoUtilisateur()
        {

        }

        public void insert(Utilisateur unUser, MySqlCommand cmd)
        {
            try
            {
                cmd.CommandText = "INSERT INTO utilisateur (nom,prenom,login,mdp,mail) VALUES ('" + unUser.nom + "', '" + unUser.prenom + "', '" + unUser.login + "' , '" + unUser.mdp + "' , '" + unUser.mail + "' )";
                //cmd.CommandText = "INSERT INTO utilisateur (nom,prenom,login,mdp,mail) VALUES (@nom , @prenom , @login , @mdp , @mail)";
                // utilisation de l'objet contact passé en paramètre
                cmd.Parameters.AddWithValue("@nom", unUser.nom);
                cmd.Parameters.AddWithValue("@prenom", unUser.prenom);
                cmd.Parameters.AddWithValue("@login", unUser.login);
                cmd.Parameters.AddWithValue("@mdp", unUser.mdp);
                cmd.Parameters.AddWithValue("@mail", unUser.mail);

                //Console.WriteLine("recuperation " + unUser.nom);

                Console.WriteLine("command text " + cmd.CommandText);
                

                cmd.ExecuteNonQuery();

                Console.WriteLine("fin query");
                Console.ReadLine();
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("Test error");
                Console.WriteLine("error : " + ex);
                Console.ReadLine();
            }




        }
    }
}
