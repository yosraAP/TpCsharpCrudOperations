using project_Contact_TP.ado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_Contact_TP.modele
{
    internal class RegistreContacts
    {
        public List<Fournisseur> registreContact { get; set; }

        public RegistreContacts(List<Fournisseur> registreContact)
        {
            this.registreContact = registreContact;
        }

        public RegistreContacts()
        {
           this.registreContact=new List<Fournisseur>();
        }

        public void addContact(Fournisseur registre)
        {
            registreContact.Add(registre);

        }





        public override string? ToString()
        {
            StringBuilder t = new StringBuilder();

            foreach (Fournisseur e in this.registreContact)
                   t.AppendLine(string.Format("Nom: {0} - Email: {1}- Code_Scn: {2} ", e.Nom, e.Email, e.Code_Scn));
            return t.ToString();

           
        }
    }
}
