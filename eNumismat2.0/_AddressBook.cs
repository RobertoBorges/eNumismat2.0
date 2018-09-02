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
    public partial class _AddressBook : RibbonForm
    {
        Classes.DataBaseWork DBWorker;

        //=====================================================================================================================================================================
        public _AddressBook()
        {
            InitializeComponent();
        }

        //=====================================================================================================================================================================
        private void _AddressBook_Load(object sender, EventArgs e)
        {
            DBWorker = new Classes.DataBaseWork();
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
    }
}
