using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace eNumismat2._0
{
    public partial class Form1 : KryptonForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonSpecAny1_Click(object sender, EventArgs e)
        {
            if (OpenForm("Form3") == false)
            {
                Form3 ExchangeMon = new Form3();
                ExchangeMon.Show();
            }
        }

        private void buttonSpecAny2_Click(object sender, EventArgs e)
        {
            if (OpenForm("Form2") == false)
            {
                Form2 AddrBook = new Form2();
                AddrBook.Show();
            }
        }

        private bool OpenForm(string FrmName)
        {
            bool IsOpen = false;

            foreach (Form fx in Application.OpenForms)
            {
                if (fx.Name == FrmName)
                {
                    IsOpen = true;

                    if (fx.WindowState == FormWindowState.Minimized)
                    {
                        fx.WindowState = FormWindowState.Normal;
                    }

                    fx.BringToFront();
                }
            }
            return IsOpen;
        }
    }
}
