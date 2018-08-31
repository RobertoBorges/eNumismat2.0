using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using vCardLib.Deserializers;

namespace eNumismat2._0
{
    public partial class _AddressBook : RibbonForm
    {
        Classes.DataBaseWork DBWorker = new Classes.DataBaseWork();

        public _AddressBook()
        {
            InitializeComponent();
        }

        private void _AddressBook_Load(object sender, EventArgs e)
        {
            try
            {
                toolStripStatusLabel1.Text = DBWorker.ContactCounter().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}