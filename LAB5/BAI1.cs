using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace LAB5
{
    public partial class BAI1 : Form
    {
        public BAI1()
        {
            InitializeComponent();
        }

        bool IsValidEmail(string mailname)
        {
            bool isValidEmail = System.Text.RegularExpressions.Regex.IsMatch(mailname, @"^[^@\s]+@[^@\s]+\.[^@\s]") ;
            if (string.IsNullOrWhiteSpace(mailname) || !isValidEmail)
                return false;
            else return true;
        }

        bool IsValidString(string str1)
        {
            return (string.IsNullOrWhiteSpace(str1));
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            bool isValidSenderEmail = IsValidEmail(senderEmail.Text);
            bool isValidRecverEmail = IsValidEmail(receiverEmail.Text);
            bool isBodyMailNull = IsValidString(bodyMail.Text);
            bool isSubjectMailNull = IsValidString(subjectMail.Text);
            bool isPasswordNull = IsValidString(senderPass.Text);
            string mailfrom = senderEmail.Text.ToString().Trim();
            string mailto = receiverEmail.Text.ToString().Trim();
            string password = senderPass.Text.ToString().Trim();

            if (isValidRecverEmail && isValidSenderEmail && !isBodyMailNull && !isSubjectMailNull && !isPasswordNull)
            {
                using (SmtpClient smtpClient = new SmtpClient("127.0.0.1"))
                {
                    var basicCredential = new NetworkCredential(mailfrom, password);
                    using (MailMessage message = new MailMessage())
                    {
                        MailAddress fromAddress = new MailAddress(mailfrom); 
                        smtpClient.UseDefaultCredentials = false; 
                        smtpClient.Credentials = basicCredential; 
                        message.From = fromAddress; 
                        message.Subject = subjectMail.Text.ToString().Trim();
                        // Set IsBodyHtml to true means you can send HTML email.
                        message.IsBodyHtml = false;
                        message.Body = bodyMail.Text.ToString();
                        message.To.Add(mailto);
                        try
                        {
                            smtpClient.Send(message);
                            MessageBox.Show("Email sent succeedly!!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Something wrong\n" + ex.Message, "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                if (isSubjectMailNull)
                {
                    MessageBox.Show("Please enter subject for your mail.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (isBodyMailNull)
                {
                    MessageBox.Show("Please enter body mail for your mail.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (!isValidRecverEmail || !isValidSenderEmail)
                {
                    MessageBox.Show("Please ensure email you entered existly ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                if (isPasswordNull)
                {
                    MessageBox.Show("Please enter password of sender mail.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
