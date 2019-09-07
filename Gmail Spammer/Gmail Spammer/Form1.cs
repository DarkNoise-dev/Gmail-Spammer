using MaterialSkin.Controls;
using System;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace Gmail_Spammer
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtbx_angreifer_adresse_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbx_angreifer_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbx_opfer_adresse_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbx_email_anzahl_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbx_email_text_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbx_email_betreff_TextChanged(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
           
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            int email_anzahl = Convert.ToInt16(txtbx_email_anzahl.Text);
            MessageBox.Show("Emails werden geschickt");
            for (int i = 0; i < email_anzahl; i++)
            {

               
                SmtpClient email = new SmtpClient();
                email.Host = "smtp.gmail.com";
                email.Credentials = new NetworkCredential(txtbx_angreifer_adresse.Text, txtbx_angreifer_password.Text);
                email.EnableSsl = true;
                //Schickt die Nachricht
                string HostName = Dns.GetHostName();
                MailMessage nachricht = new MailMessage(txtbx_angreifer_adresse.Text, txtbx_opfer_adresse.Text);
                nachricht.Subject = txtbx_email_betreff.Text;
                nachricht.Body = txtbx_email_text.Text;
                email.Send(nachricht);
            }
            MessageBox.Show("Emails erfolgreich geschickt");
        }

        private void materialRaisedButton1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Klicke auf den link und aktiviere weniger sichere apps zulassen https://myaccount.google.com/lesssecureapps?utm_source=google-account&utm_medium=web");
        }
    }
}
