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
    public partial class FormEspaceManipCollection : Form
    {
        RegistreContacts listing = new RegistreContacts();
        public FormEspaceManipCollection()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            String nom = txtNom.Text;
            String email = txtEmail.Text;
            int codeScn = int.Parse(txtCodeScn.Text);

            Fournisseur fournisseur = new Fournisseur(nom, email, codeScn);
            listing.addContact(fournisseur);

            listBoxAffiche.Items.Clear();

            foreach (Fournisseur tmp in listing.registreContact)
            {
                listBoxAffiche.Items.Add(tmp);
            }
            //Vider Les textBox 
            txtNom.Text = "";
            txtEmail.Text = "";
            txtCodeScn.Text = "";
        }

        private void btnRecherche_Click(object sender, EventArgs e)
        {
            String nomR = TxtRecherche.Text;

            ListRecherche.Items.Clear();

            var resultat = from s in listing.registreContact
                           where s.Nom == nomR
                           select s;

            ListRecherche.Items.Add(Utilitaire.afficherListBoxCollection(resultat));
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            TxtRecherche.Text = "";
        }
    }
}
