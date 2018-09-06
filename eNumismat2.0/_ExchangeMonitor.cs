using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using eNumismat2.Properties;
using eNumismat2.Classes;

namespace eNumismat2
{
    //=====================================================================================================================================================================
    public partial class _ExchangeMonitor : RibbonForm
    {
        //=====================================================================================================================================================================
        public _ExchangeMonitor()
        {
            InitializeComponent();

            if (Settings.Default.MainWindowState == FormWindowState.Normal)
            {
                Size = new Size(Settings.Default.ExchangeMonitorWindowWidth, Settings.Default.ExchangeMonitorWindowHight);
            }
        }

        //=====================================================================================================================================================================
        private void _ExchangeMonitor_Load(object sender, EventArgs e)
        {

        }

        //=====================================================================================================================================================================
        private void _ExchangeMonitor_SizeChanged(object sender, EventArgs e)
        {
            SaveWindowSizeSettings();
        }

        //=====================================================================================================================================================================
        private void SaveWindowSizeSettings()
        {
            Settings.Default.ExchangeMonitorWindowHight = Size.Height;
            Settings.Default.ExchangeMonitorWindowWidth = Size.Width;
            Settings.Default.ExchangeMonitorWindowState = WindowState;

            Settings.Default.Save();
        }
    }
}
