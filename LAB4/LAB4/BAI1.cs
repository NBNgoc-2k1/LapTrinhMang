using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace LAB4
{
    public partial class BAI1 : Form
    {
        public BAI1()
        {
            InitializeComponent();
        }

        private void btn_Get_Click(object sender, EventArgs e)
        {
            WebRequest request = WebRequest.Create(txb_URL.Text);
            WebResponse respond = request.GetResponse();
            Stream str = respond.GetResponseStream();
            StreamReader sr = new StreamReader(str);
            richTextBox_Data_html.Text = sr.ReadToEnd();
            respond.Close();
        }
    }
}