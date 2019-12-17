using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ratespiel
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LogIn());
            //Application.Run(new Registration());
            //User user = new User();
            //Spiel spiel = new Spiel();
            //spiel.UserId = 1;
            //Application.Run(new Hauptfenster(user));
            // Application.Run(new Highscore(spiel));
        }
    }
}
