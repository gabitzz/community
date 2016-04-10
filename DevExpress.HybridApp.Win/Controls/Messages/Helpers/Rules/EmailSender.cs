using System;
using System.Linq;
using System.Net.Mail;
using DevExpress.DevAV.Helpers;
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
                var account = AppContext.Instance.Accounts.FirstOrDefault();
                if (account != null)
                {
                    // if port 995 is not working, try port 587
                    SmtpClient client = new SmtpClient(host: account.Outgoing, port: 587);

                    client.UseDefaultCredentials = false;
                    client.EnableSsl = true;
                    client.Credentials = new System.Net.NetworkCredential(account.Email, account.Password);
                    client.Send(message);
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error - Cannot send email!");
                throw ex;
            }
        }
    }
}