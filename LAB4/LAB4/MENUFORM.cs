using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB4
{
    public partial class MENUFORM : Form
    {
        public MENUFORM()
        {
            InitializeComponent();
        }

        private void BAI1_Click(object sender, EventArgs e)
        {
            BAI1 ex1 = new BAI1();
            ex1.Show();
        }

        private void BAI2_Click(object sender, EventArgs e)
        {
            BAI2 ex2 = new BAI2();
            ex2.Show();
        }

        private void BAI3_Click(object sender, EventArgs e)
        {
            BAI3 ex3 = new BAI3();
            ex3.Show();
        }

        private void BAI4_Click(object sender, EventArgs e)
        {
            BAI4 ex4 = new BAI4();
            ex4.Show();
        }
    }
}