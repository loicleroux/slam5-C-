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
        MySqlCommand cmd;
        Bdd bdd;

        public DaoUtilisateur()
        {

        }

        private void openBdd()
        {
            bdd = new Bdd();
            cmd = bdd.connection.CreateCommand();
            bdd.connection.Open();
        }

        private void closeBdd(Bdd bdd)
        {
            bdd.connection.Close();
        }

        public Boolean verifLog(String log)
        {
            openBdd();

            Boolean test = true;

            cmd.CommandText = "SELECT id FROM utilisateur WHERE login='" + log + "'";
            MySqlDataReader reader = cmd.ExecuteReader();

            try
            {
                while (reader.Read())
                {
                    if (reader.GetString(0) != "")
                    {
                        test = false;
                    }
                }
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("select error");
                Console.WriteLine("error : " + ex);
                Console.ReadLine();
            }

            closeBdd(bdd);
            return test;
        }

        public Boolean verifMail(String mail)
        {
            bool test = true;
            openBdd();
            cmd.CommandText = "SELECT id FROM utilisateur WHERE mail='" + mail + "'";
            MySqlDataReader reader = cmd.ExecuteReader();

            try
            {
                while (reader.Read())
                {
                    if (reader.GetString(0) != "")
                    {
                        test = false;
                    }
                }
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("select error");
                Console.WriteLine("error : " + ex);
                Console.ReadLine();
            }

            closeBdd(bdd);
            return test;
        }

        public void insert(Utilisateur unUser)
        {
            bool test = verifLog(unUser.login);
            test &= verifMail(unUser.mdp);

            if (test)
        {
            try
            {
                    openBdd();
                cmd.CommandText = "INSERT INTO utilisateur (nom,prenom,login,mdp,mail) VALUES ('" + unUser.nom + "', '" + unUser.prenom + "', '" + unUser.login + "' , '" + unUser.mdp + "' , '" + unUser.mail + "' )";

                Console.WriteLine("command text " + cmd.CommandText);
                
                cmd.ExecuteNonQuery();

                    closeBdd(bdd);
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
}
