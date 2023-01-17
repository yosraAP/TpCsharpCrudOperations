using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_Contact_TP.modele
{
    internal class Fournisseur :Contact
    {
  
        public int Code_Scn { get; set; }


        // Constructor
        public Fournisseur(string nom, string email, int code_Scn) : base(nom, email)

        {
            // from base class
            this.Nom = nom;
            this.Email = email;


            // from derived class
            this.Code_Scn = code_Scn;
        }

   
        public override string? ToString()
        {
            
            return Nom + "-" + Email+"-"+ Code_Scn ;
        }
    }
}
