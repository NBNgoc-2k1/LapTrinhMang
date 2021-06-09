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
using HtmlAgilityPack;
using System.IO;


namespace LAB4
{
    public partial class BAI4 : Form
    {
        public string URL;
        public BAI4()
        {
            InitializeComponent();
        }

        private void search_Click(object sender, EventArgs e)
        {
            URL = LocationBar.Text.Trim();
            if (String.IsNullOrWhiteSpace(URL) || URL.Equals("about:blank"))
            {
                MessageBox.Show("Enter a valid URL.");
                LocationBar.Focus();
                return;
            }
            NavigateToURL(URL);
        }

        private void NavigateToURL(string url)
        {
            if (!url.StartsWith("http://") && !url.StartsWith("https://"))
            {
                url += "http://";
            }

            try
            {
                myBrowser.Navigate(new Uri(url));
            }
            catch (System.UriFormatException)
            {
                return;
            }
        }

        private void viewSource_Click(object sender, EventArgs e)
        {
            ViewSourcePage vsp = new ViewSourcePage();
            vsp.url = URL;
            vsp.Show();
        }

        private void downPage_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.Cancel)
            {
                MessageBox.Show("User pressed Cancel!!!");
            }
            else
            {
                string filePath = sfd.FileName;
                DownloadWebPage(filePath);
            }
        }

        void DownloadWebPage(string filepath)
        {
            WebClient myClient = new WebClient();
            string folderHTMLFile = Path.GetDirectoryName(filepath);
            Stream response = myClient.OpenRead(URL);
            if (filepath != null)
            {
                myClient.DownloadFile(new Uri(URL), filepath);
            }

            HtmlAgilityPack.HtmlDocument document = new HtmlAgilityPack.HtmlDocument();
            document.Load(response);
            HtmlNodeCollection nodesimg = document.DocumentNode.SelectNodes("//img");
            string imageFolder = Path.Combine(@"" + folderHTMLFile, @"Images\");
            
            if (nodesimg != null)
            {
                if (!Directory.Exists(imageFolder))
                {
                    Directory.CreateDirectory(imageFolder);
                }
                foreach(HtmlNode node in nodesimg)
                {
                    WebClient client = new WebClient();
                    string sourceImg = Path.GetFileName(node.GetAttributeValue("src", ""));
                    string fileName = Path.Combine(@"" + folderHTMLFile, @"Images\", sourceImg);
                    string fileDown = URL + node.GetAttributeValue("src", "");
                    client.DownloadFile(fileDown, fileName);
                }
            }
            else
            {
                MessageBox.Show("Webpage doesn't contain any image", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            response.Close();
        }
    }
}
