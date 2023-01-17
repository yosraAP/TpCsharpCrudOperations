using project_Contact_TP.ui;
using System.Text;

namespace project_Contact_TP
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            //pour resoudre erreur No data is available for encoding 1252. For information on defining a custom encoding, see the documentation for the Encoding.RegisterProvider method
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            var enc1252 = Encoding.GetEncoding(1252);


            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new FormMenuApp());
        }
    }
}