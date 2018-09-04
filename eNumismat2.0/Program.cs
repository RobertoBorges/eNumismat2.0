using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eNumismat2._0
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
            //try
            //{
                Application.Run(new _eNumismatMain());
            //}
            //catch(Exception ex)
            //{
                // Do nothing... ^^
            //}
        }
    }
}
