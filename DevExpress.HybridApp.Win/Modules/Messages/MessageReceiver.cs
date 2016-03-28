using System;
using System.ComponentModel;
using DevExpress.DevAV.Controls.Messages;
using DevExpress.DevAV.Controls.Messages.Helpers;
using OpenPop.Pop3;

namespace DevExpress.DevAV.Modules
{
    public class MessageReceiver
    {
        public event EventHandler DoReceiveStarted;
        public event EventHandler DoReceiveEnded;

        private BackgroundWorker _backgroundWorker;

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
            // TODO send receive
            using (var client = new Pop3Client())
            {
                // Connect to the server
                client.Connect("pop.gmail.com", 995, true);

                // Authenticate ourselves towards the server
                client.Authenticate("silentbusters@gmail.com", "silent123");

                // Get the number of messages in the inbox
                int messageCount = client.GetMessageCount();

                // Most servers give the latest message the highest number
                for (int i = messageCount; i > 0; i--)
                {
                    var msg = client.GetMessage(i);
                    var messageDate = DateTime.Parse(msg.Headers.Date);
                    var nessage = new Message
                    {
                        Date = messageDate,
                        From = msg.Headers.From.Address,
                        Subject = msg.Headers.Subject,
                        Text = msg.FindFirstHtmlVersion().GetBodyAsText(),
                        MailType = MailType.Inbox,
                        MailFolder = (int)MailFolder.Announcements
                    };
                    DataHelper.AddMessage(nessage);
                }
            }
        }
    }
}
