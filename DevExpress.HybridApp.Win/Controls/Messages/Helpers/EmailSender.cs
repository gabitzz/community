using System;
using System.Net.Mail;
using DevExpress.XtraEditors;

namespace DevExpress.DevAV.Controls.Messages.Helpers
{
    public class EmailSender
    {
        public EmailSender()
        {

        }

        public void Send(MailMessage message)
        {
            try
            {
                SmtpClient client = new SmtpClient(host: "smtp.gmail.com", port: 587);

                client.UseDefaultCredentials = false;
                client.EnableSsl = true;
                client.Credentials = new System.Net.NetworkCredential("silentbusters@gmail.com", "silent123");
                client.Send(message);

            }
            catch (Exception)
            {
                XtraMessageBox.Show("Error - Cannot send email!");
                throw;
            }
        }
    }
}