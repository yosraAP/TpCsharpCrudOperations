using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_Contact_TP.modele
{
    internal class Contact
    {
        public string Nom { get; set; }
        public string Email { get; set; }

        public Contact(string nom, string email)
        {
            this.Nom = nom;
            this.Email = email;
        }

        public override string? ToString()
        {
            return   Nom + "-" + Email ;
        }

    }
}
