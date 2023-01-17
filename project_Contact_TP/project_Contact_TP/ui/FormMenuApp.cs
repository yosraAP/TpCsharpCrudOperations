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
    public partial class FormMenuApp : Form
    {
        public FormMenuApp()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnEspaceContactDB_Click(object sender, EventArgs e)
        {
            FormEspaceContactBD formEspaceContactBD = new FormEspaceContactBD();
            formEspaceContactBD.Visible = true;
        }

        private void BtnContactCollection_Click(object sender, EventArgs e)
        {
            FormEspaceManipCollection formEspaceManipCollection = new FormEspaceManipCollection();
            formEspaceManipCollection.Visible = true;
        }
    }
}
