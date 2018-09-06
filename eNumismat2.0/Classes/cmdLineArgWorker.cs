using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eNumismat2.Properties;

namespace eNumismat2.Classes
{
    class CmdLineArgWorker
    {
        public static void CommandWorker(string[] args)
        {
            foreach (string arg in args)
            {
                if (arg.ToUpper() == "RESETPW")
                {
                    Settings.Default["UsePasswordProtection"] = false;
                    Settings.Default["CurrentUserPassword"] = string.Empty;

                    Settings.Default.Save();
                }
            }
        }
    }
}
