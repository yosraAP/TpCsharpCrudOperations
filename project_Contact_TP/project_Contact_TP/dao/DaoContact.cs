using MySql.Data.MySqlClient;
using project_Contact_TP.modele;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace project_Contact_TP.ado
{
    internal class DaoContact
    {
        public MySqlConnection mySqlConnection { get; set; }
        public MySqlCommand command { get; set; }

        public DaoContact(String cs)
        {
            this.mySqlConnection = new MySqlConnection(cs);
        }

        public int ExecuterCommande(string cde,Contact contact)
        {
            int lignes;

            GetCommande(cde);
            //Mettre en relation
            MySqlParameter pNom = new MySqlParameter();
            pNom.ParameterName = "@nom";
            pNom.Value = contact.Nom;

            MySqlParameter pEmail=new MySqlParameter();
            pEmail.ParameterName = "@email";
            pEmail.Value = contact.Email;

            //Ajouter les params à la commande
            command.Parameters.Add(pNom);
            command.Parameters.Add(pEmail);
           
            //Execution
            lignes = command.ExecuteNonQuery();
            FermerConnexion();

            return lignes;
        }

        private void FermerConnexion()
        {
            mySqlConnection.Close();
        }

        private void GetCommande(string cde)
        {
            mySqlConnection.Open();
            command = new MySqlCommand(cde, mySqlConnection);
        }

        public List<Contact> ExecuterRequete(string requete)
        {
            GetCommande(requete);
            List<Contact> registre = new List<Contact>();
            ////DataReader
            MySqlDataReader reader = command.ExecuteReader();
            //Transformer le contenu du reader dans une List

           
            string nom, email;
            while (reader.Read())
            {
               
                nom = (string)reader[0];
                email = (string)reader[1];
                registre.Add(new Contact(nom, email));
            }

            FermerConnexion();
            return registre;
        }


        public void CreateTable(string requete)
        {
            GetCommande(requete);
            List<Contact> registre = new List<Contact>();
            ////DataReader
            MySqlDataReader reader = command.ExecuteReader();
                 
            FermerConnexion();
            
        }

    }
}
