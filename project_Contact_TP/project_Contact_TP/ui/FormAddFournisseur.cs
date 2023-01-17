using MySql.Data.MySqlClient;
using project_Contact_TP.ado;
using project_Contact_TP.modele;
using project_Contact_TP.util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_Contact_TP.ui
{
    public partial class FormAddFournisseur : Form
    {
        string cs = "server=localhost;user=root;" +
            "database=northwindmysql;port=3306";

        public FormAddFournisseur()
        {
            InitializeComponent();
            afficherFournisseur();
        }

        private void BtnReturn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
         

            DaoFournisseur dao = new DaoFournisseur(cs);

            Console.WriteLine("================Insert table Contact======================");
            String nom, email;
            int codeScn;
            if (String.IsNullOrEmpty(txtNom.Text))
            {
                MessageBox.Show("Saisie Nom Obligatoire", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (String.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Saisie Email Obligatoire", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (String.IsNullOrEmpty(txtCode.Text))
            {
                MessageBox.Show("Saisie CodeScn Obligatoire", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                nom = txtNom.Text;
                email = txtEmail.Text;
                codeScn = Int32.Parse(txtCode.Text);
                Fournisseur fournisseur = new Fournisseur(nom, email, codeScn);
                string cde = "insert into contact(nom, email,codeScn)values(@nom," +
               "@email,@codeScn)";

                //Console.WriteLine(cde);
                int lignes = dao.PasserCommande(cde, fournisseur);
                MessageBox.Show("Nombre de lignes ajouter = " + lignes, "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Console.WriteLine("================select table Contact======================");
                afficherFournisseur();
            }
            //vider Les champs
            txtNom.Text = "";
            txtEmail.Text = "";
            txtCode.Text = "";


        }
       

        private void afficherFournisseur()
        {

            Console.WriteLine("=============== SELECT table Fournisseur ======================");
            DaoFournisseur dao = new DaoFournisseur(cs);
            string requete = "select nom,email,codeScn from contact;";

            List<Fournisseur> listing = dao.ExecuterRequete(requete);

            //Afficher sur le ListBox 
            print(listing);

                       
        }

       private void print<T>(IEnumerable<T> resultat)
        {

            foreach (var tmp in resultat)
            {
                lBoxAfficher.Items.Add(tmp);

            }


        }
    }
}
