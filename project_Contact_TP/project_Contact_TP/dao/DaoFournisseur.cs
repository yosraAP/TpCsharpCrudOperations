using MySql.Data.MySqlClient;
using project_Contact_TP.modele;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_Contact_TP.ado
{
    internal class DaoFournisseur
    {
        public MySqlConnection mySqlConnection { get; set; }
        public MySqlCommand command { get; set; }

        public DaoFournisseur(String cs)
        {
            this.mySqlConnection = new MySqlConnection(cs);
        }

        public int PasserCommande(string cde, Fournisseur fournisseur)
        {
            int lignes;

            GetCommande(cde);
            //Mettre en relation
            MySqlParameter pNom = new MySqlParameter();
            pNom.ParameterName = "@nom";
            pNom.Value = fournisseur.Nom;

            MySqlParameter pEmail = new MySqlParameter();
            pEmail.ParameterName = "@email";
            pEmail.Value = fournisseur.Email;

            MySqlParameter pCodeScn = new MySqlParameter();
            pCodeScn.ParameterName = "@codeScn";
            pCodeScn.Value = fournisseur.Code_Scn;

            //Ajouter les params à la commande
            command.Parameters.Add(pNom);
            command.Parameters.Add(pEmail);
            command.Parameters.Add(pCodeScn);

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

        public List<Fournisseur> ExecuterRequete(string requete)
        {
            GetCommande(requete);
            List<Fournisseur> registre = new List<Fournisseur>();
            ////DataReader
            MySqlDataReader reader = command.ExecuteReader();
            //Transformer le contenu du reader dans une List

            string nom, email;
            int codeScn;
            while (reader.Read())
            {
                nom = (string)reader[0];
                email = (string)reader[1];
                if ( DBNull.Value.Equals(reader[2]) )
                    codeScn = 0;
                else
                codeScn =(int)reader[2];
                registre.Add(new Fournisseur(nom, email, codeScn));
            }

            FermerConnexion();
            return registre;
        }


        public void CreateTable(string requete)
        {
            GetCommande(requete);
            List<Fournisseur> registre = new List<Fournisseur>();
            ////DataReader
            MySqlDataReader reader = command.ExecuteReader();

            FermerConnexion();

        }


      

    }
}
