using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Globalization;
using eNumismat2.Properties;
using System.Windows.Forms;

namespace eNumismat2.Classes
{
    class WriteConfig
    {
        private void SaveSettings<T>(string paramName, T paramValue) //(CultureInfo newCulture = null, string DBFilePath = null, string DBFile = null)
        {
            if (typeof(T) == typeof(Size))
            {
                if (paramName == "MainWindowHeight")
                {
                    Settings.Default[paramName] = paramValue;
                }
                else if (paramName == "MainWindowWidth")
                {
                    Settings.Default[paramName] = paramValue;
                }
            }
            else if (typeof(T) == typeof(FormWindowState))
            {
                if (paramName == "MainWindowState")
                {
                    Settings.Default[paramName] = paramValue;
                }
            }
            else if (typeof(T) == typeof(CultureInfo))
            {
                if (paramName == "UICulture")
                {
                    Settings.Default[paramName] = paramValue;
                }
            }
            else if (typeof(T) == typeof(string))
            {
                if (paramName == "DBFile")
                {
                    if (paramValue == null)
                    {
                        Settings.Default[paramName] = string.Empty;
                    }
                    Settings.Default[paramName] = paramValue;
                }

                if (paramName == "DBFilePath")
                {
                    if (paramValue == null)
                    {
                        Settings.Default[paramName] = string.Empty;
                    }
                    Settings.Default[paramName] = paramValue;
                }
            }

            Settings.Default.Save();
        }
    }
}
