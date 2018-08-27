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

        private void buttonSpecAny2_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;

            foreach (Form fx in Application.OpenForms)
            {
                if (fx.Name == "Form2")
                {
                    IsOpen = true;

                    if (fx.WindowState == FormWindowState.Minimized)
                    {
                        fx.WindowState = FormWindowState.Normal;
                    }

                    fx.BringToFront();
                    break;
                }
            }

            if (IsOpen == false)
            {
                Form2 AddrBook = new Form2();
                AddrBook.Show();
            }
        }
    }
}
