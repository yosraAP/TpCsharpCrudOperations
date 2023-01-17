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
    public partial class FormEspaceContactBD : Form
    {
        public FormEspaceContactBD()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnReturn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void BtnFournisseur_Click(object sender, EventArgs e)
        {
            FormAddFournisseur formAddFournisseur = new FormAddFournisseur();
            formAddFournisseur.Visible=true;
        }

        private void BtnContact_Click(object sender, EventArgs e)
        {
            FormAddContact contact = new FormAddContact();
            contact.Visible=true;
        }
    }
}
