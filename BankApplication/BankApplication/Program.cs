using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using Loginclasslibrary;

namespace BankApplication
{
    static class Program
    {
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try{
                Dns.GetHostEntry("www.google.com");
                var szyja = Page.Start();
                if (szyja == null) return;
                    Application.Run(new FormMainMenu(szyja));
            }catch{
                Application.Run(new FormMainMenu());
                MessageBox.Show("Brak połączenia z serwerem, proszę sprawdzić połączenie z internetem lub zaczekać chwilę.",
                    "Jäger Bänk", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

    }
}
