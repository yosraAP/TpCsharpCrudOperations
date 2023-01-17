using MySql.Data.MySqlClient;
using project_Contact_TP.ado;
using project_Contact_TP.modele;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_Contact_TP.util
{
    internal class Utilitaire
    {
       
        public static String afficherListBoxCollection(IEnumerable<Fournisseur> resultat)
        {
            StringBuilder str = new StringBuilder();
            foreach (Fournisseur tmp in resultat)
            {
                str.Append(tmp);
                str.Append("\n");
            }
            return str.ToString();
        }

        
    }
}
