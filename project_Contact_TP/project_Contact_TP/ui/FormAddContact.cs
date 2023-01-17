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
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.CompilerServices.RuntimeHelpers;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace project_Contact_TP.ui
{
    public partial class FormAddContact : Form
    {


        string cs = "server=localhost;user=root;" +
   "database=northwindmysql;port=3306";


        public FormAddContact()
        {
            InitializeComponent();

            //Afficher les Contacts
            afficherlesContact();



        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {


            String cde;

            DaoContact dao = new DaoContact(cs);


            Console.WriteLine("================Insert table Contact======================");
            String nom, email;

            if (String.IsNullOrEmpty(txtNom.Text))
            {
                MessageBox.Show("Saisie Nom Obligatoire", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (String.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Saisie Email Obligatoire", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                nom = txtNom.Text;
                email = txtEmail.Text;
                Contact contact = new Contact(nom, email);
                cde = "insert into contact(nom, email)values(@nom," + "@email)";

                //Console.WriteLine(cde);
                int lignes = dao.ExecuterCommande(cde, contact);
                MessageBox.Show("Nombre de lignes ajouter = " + lignes, "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Afficher les Contact
                lBoxAfficher.Items.Clear();
                afficherlesContact();
                //pour  clear les textBox
                txtNom.Text = "";
                txtEmail.Text = "";
            }

            //message pour Update
            MessageBox.Show("S.V.P sélectionner la ligne à modifier ! \n Update s'applique juste Data-Vue-Grid !", "Information UPDATE", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void afficherlesContact()
        {

            Console.WriteLine("=============== SELECT table Contact ======================");
            DaoContact dao = new DaoContact(cs);
            string requete = "select nom,email from contact;";

            List<Contact> listing = dao.ExecuterRequete(requete);

            //Afficher sur le ListBox 
            print(listing);


            //Afficher Sur le DataGrid
            DGVContact.DataSource = listing;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            Console.WriteLine("=============== Delete table Contact ======================");
            DaoContact dao = new DaoContact(cs);
            string requete = "delete  from contact where nom='" + DGVContact.CurrentRow.Cells[0].Value + "' and email='" + DGVContact.CurrentRow.Cells[1].Value + "' ;";

            List<Contact> listing = dao.ExecuterRequete(requete);


            //Afficher les Contacts
            lBoxAfficher.Items.Clear();
            afficherlesContact();

            //pour  clear les textBox
            txtNom.Text = "";
            txtEmail.Text = "";
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {

            DaoContact dao = new DaoContact(cs);
            string requete = "update contact set nom='" + txtNom.Text + "', email='" + txtEmail.Text + "' where nom='" + DGVContact.CurrentRow.Cells[0].Value + "'  ;";

            List<Contact> listing = dao.ExecuterRequete(requete);

            lBoxAfficher.Items.Clear();
            afficherlesContact();
        }

        private void DGVContact_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNom.Text = DGVContact.CurrentRow.Cells[0].Value.ToString();
            txtEmail.Text = DGVContact.CurrentRow.Cells[1].Value.ToString();
        }

        private void print<T>(IEnumerable<T> resultat)
        {

            foreach (var tmp in resultat)
            {
                lBoxAfficher.Items.Add(tmp);

            }


        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lBoxAfficher_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
