using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using DevExpress.DevAV.Controls.Messages;
using DevExpress.DevAV.Controls.Messages.Helpers;
using DevExpress.XtraEditors;
using OpenPop.Pop3;

namespace DevExpress.DevAV.Helpers
{
    public class MessageReceiver
    {
        public event EventHandler DoReceiveStarted;
        public event EventHandler DoReceiveEnded;

        private readonly BackgroundWorker _backgroundWorker;

        public static MessageReceiver Instance { get; } = new MessageReceiver();

        private MessageReceiver()
        {
            _backgroundWorker = new BackgroundWorker();
            _backgroundWorker.DoWork += BackgroundWorker_DoWork;
        }

        public void Receive()
        {
            if (!_backgroundWorker.IsBusy)
            {
                _backgroundWorker.RunWorkerAsync();
            }
        }

        private void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            DoReceiveStarted?.Invoke(this, new EventArgs());

            try
            {
                DoReceive();
            }
            finally
            {
                DoReceiveEnded?.Invoke(this, new EventArgs());
            }
        }

        private void DoReceive()
        {
            var emailAccount = AppContext.Instance.Accounts.First();
            if (emailAccount != null)
            {
                PerformReceive(emailAccount);
            }
        }

        private static void PerformReceive(EmailAccount emailAccount)
        {
            try
            {
                using (var client = new Pop3Client())
                {
                    TryToConnect(emailAccount, client);

                    TryToAuthenticate(emailAccount, client);

                    // Get the number of messages in the inbox
                    var messageCount = client.GetMessageCount();

                    // Most servers give the latest message the highest number
                    for (var i = messageCount; i > 0; i--)
                    {
                        var msg = client.GetMessage(i);
                        var messageDate = DateTime.Parse(msg.Headers.Date);
                        var message = new Message
                        {
                            Date = messageDate,
                            From = msg.Headers.From.Address,
                            Subject = msg.Headers.Subject,
                            Text = msg.FindFirstHtmlVersion().GetBodyAsText(),
                            MailType = MailType.Inbox,
                            MailFolder = (int) MailFolder.Announcements
                        };
                        AddAttachements(msg, message);
                        DataHelper.AddMessage(message);
                    }
                }
            }
            catch (Exception e)
            {
               // TODO log exception
                var message = e.Message;
            }
        }

        private static void AddAttachements(OpenPop.Mime.Message msg, Message message)
        {
            var attachments = new StringBuilder();
            var attachementsFolder = Path.Combine(@"C:\Attachments", Guid.NewGuid().ToString());
            if (!Directory.Exists(attachementsFolder))
            {
                Directory.CreateDirectory(attachementsFolder);
            }
            foreach (var attachment in msg.FindAllAttachments())
            {

                var filePath = Path.Combine(attachementsFolder, attachment.FileName);
                attachments.Append(filePath).Append(",");
                var stream = new FileStream(filePath, FileMode.Create);
                var binaryWriter = new BinaryWriter(stream);
                binaryWriter.Write(attachment.Body);
                binaryWriter.Close();
            }
            message.Attachments = attachments.ToString().Substring(0, attachments.Length - 1);
        }

        private static void TryToAuthenticate(EmailAccount emailAccount, Pop3Client client)
        {
            try
            {
                // Authenticate towards the server
                client.Authenticate(emailAccount.Username, emailAccount.Password);
            }
            catch (Exception)
            {
                XtraMessageBox.Show("Email receive error - invalid username/password settings");
                throw;
            }
        }

        private static void TryToConnect(EmailAccount emailAccount, Pop3Client client)
        {
            try
            {
                // Connect to the server
                client.Connect(emailAccount.Incoming, emailAccount.Port, true);
            }
            catch (Exception)
            {
                XtraMessageBox.Show("Email receive error - invalid incoming/port settings");
                throw;
            }
        }
    }
}
