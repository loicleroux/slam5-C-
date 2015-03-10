using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SNCF.Dao
{
    public class Bdd
    {
        private MySqlConnection connection;

        // Constructeur
        public Bdd()
        {
            this.InitConnexion();
        }

        // Méthode pour initialiser la connexion
        private void InitConnexion()
        {
            // Création de la chaîne de connexion
            string connectionString = "SERVER=127.0.0.1; DATABASE=sncf; UID=root; PASSWORD=";
            this.connection = new MySqlConnection(connectionString);
        }

        // Méthode pour ajouter un contact
        /*public void AddContact(Contact contact)
        {
            try
            {
                // Ouverture de la connexion SQL
                this.connection.Open();

                // Création d'une commande SQL en fonction de l'objet connection
                MySqlCommand cmd = this.connection.CreateCommand();

                // Requête SQL
                cmd.CommandText = "INSERT INTO contact (id, name, tel) VALUES (@id, @name, @tel)";

                // utilisation de l'objet contact passé en paramètre
                cmd.Parameters.AddWithValue("@id", contact.Id);
                cmd.Parameters.AddWithValue("@name", contact.Name);
                cmd.Parameters.AddWithValue("@tel", contact.Tel);

                // Exécution de la commande SQL
                cmd.ExecuteNonQuery();

                // Fermeture de la connexion
                this.connection.Close();
            }
            catch
            {
                // Gestion des erreurs :
                // Possibilité de créer un Logger pour les exceptions SQL reçus
                // Possibilité de créer une méthode avec un booléan en retour pour savoir si le contact à été ajouté correctement.
            }
        }


        //methode pour ajouter un utilisateur
        public void addUser(Utilisateur unUser)
        {
            //DaoUtilisateur
        }*/
    }
}
