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

namespace eNumismat2._0
{
    //=====================================================================================================================================================================
    public partial class _ExchangeMonitor : RibbonForm
    {
        //=====================================================================================================================================================================
        public _ExchangeMonitor()
        {
            InitializeComponent();

            if (Properties.Settings.Default.MainWindowState == FormWindowState.Normal)
            {
                Size = new Size(Properties.Settings.Default.ExchangeMonitorWindowWidth, Properties.Settings.Default.ExchangeMonitorWindowHight);
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
            Properties.Settings.Default.ExchangeMonitorWindowHight = Size.Height;
            Properties.Settings.Default.ExchangeMonitorWindowWidth = Size.Width;
            Properties.Settings.Default.ExchangeMonitorWindowState = WindowState;

            Properties.Settings.Default.Save();
        }
    }
}
