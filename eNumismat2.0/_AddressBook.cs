using System;
using System.Drawing;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using eNumismat2.Properties;
using eNumismat2.Classes;
using Infralution.Localization;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace eNumismat2
{
    //=====================================================================================================================================================================
    public partial class _AddressBook : RibbonForm
    {
        DataBaseWork DBWorker;

        //=====================================================================================================================================================================
        public _AddressBook()
        {
            InitializeComponent();

            if (Settings.Default.MainWindowState == FormWindowState.Normal)
            {
                Size = new Size(Settings.Default.AddressBookWindowWidth, Settings.Default.AddressBookWindowHight);
            }
        }

        //=====================================================================================================================================================================
        private void _AddressBook_Load(object sender, EventArgs e)
        {
            DBWorker = new DataBaseWork();
            GetContactsCount();
        }

        //=====================================================================================================================================================================
        private void GetContactsCount()
        {
            int ContactCounter = 0;

            try
            {
                ContactCounter = DBWorker.ContactCounter();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (ContactCounter == 0 || ContactCounter > 1)
            {
                toolStripStatusLabel1.Text = ContactCounter.ToString() + " " + GlobalStrings._contactsAvailable;
            }
            else if (ContactCounter == 1)
            {
                toolStripStatusLabel1.Text = ContactCounter.ToString() + " " + GlobalStrings._contactAvailable;
            }
        }

        //=====================================================================================================================================================================
        private void _AddressBook_SizeChanged(object sender, EventArgs e)
        {
            SaveWindowSizeSettings();
        }

        //=====================================================================================================================================================================
        private void SaveWindowSizeSettings()
        {
            Settings.Default.AddressBookWindowHight = Size.Height;
            Settings.Default.AddressBookWindowWidth = Size.Width;
            Settings.Default.AddressBookWindowState = WindowState;

            Settings.Default.Save();
        }
    }
}
