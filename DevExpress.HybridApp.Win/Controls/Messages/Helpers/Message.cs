using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DevExpress.Utils;
using System.IO;
using System.Drawing;
using DevExpress.XtraExport;
using System.Xml;
using DevExpress.XtraEditors.DXErrorProvider;
using System.ComponentModel;

namespace DevExpress.DevAV.Controls.Messages.Helpers
{
    public class Message : INotifyPropertyChanged
    {
        DataRow row;
        DateTime date;
        bool read, deleted, isReply, hasAttachment;
        int priority = 1;
        MailType mailType;
        int mailFolder;
        string from = String.Empty, subject = String.Empty, text = String.Empty, plainText = string.Empty;

        public Message()
        {
            this.date = DateTime.Now;
        }
        public Message(DataRow row)
        {
            this.row = row;
            this.date = ((DateTime)row["Date"]).Add(DateTime.Now - DataHelper.LastMailDate);
            this.from = string.Format("{0}", row["From"]);
            this.subject = string.Format("{0}", row["Subject"]);
            this.isReply = (bool)row["IsReply"];
            this.hasAttachment = (bool)row["HasAttachment"];
            this.read = Delay > TimeSpan.FromHours(6);
            if (Delay > TimeSpan.FromHours(50) && Delay < TimeSpan.FromHours(100)) read = false;
            this.text = string.Format("{0}", row["Text"]);
            this.deleted = false;
            if (!IsReply)
                priority = 2;
            else
                if (string.IsNullOrEmpty(Folder))
                priority = 0;
            mailType = MailType.Inbox;
            mailFolder = (int)GetFolder(row);
            DataTweaking();
        }

        public DateTime Date { get { return date; } set { date = value; } }
        public string From { get { return from; } set { from = value; } }
        public string Subject { get { return subject; } set { subject = value; } }
        public string SubjectDisplayText { get { return Subject; } }// string.Format("{1}{0}", Subject, IsReply ? "RE: " : ""); } }
        public int Attachment { get { return hasAttachment ? 1 : 0; } }
        public int Read { get { return read ? 1 : 0; } }
        public int Priority { get { return priority; } set { priority = value; } }
        internal bool IsReply { get { return isReply; } set { isReply = value; } }
        public bool IsUnread { get { return !read; } }
        internal string Folder { get { return string.Format("{0}", mailFolder); } }
        public string Text { get { return text; } set { text = value; } }
        public string PlainText { get { return GetPlainText(); } }

        string GetPlainText()
        {
            if (string.IsNullOrEmpty(plainText))
                plainText = ObjectHelper.GetPlainText(text.Substring(0, Math.Min(400, text.Length)));
            return plainText;
        }
        public MailType MailType { get { return mailType; } set { mailType = value; } }
        public int MailFolder
        {
            get { return mailFolder; }
            set
            {
                if (MailFolder == value) return;
                mailFolder = value;
                OnPropertyChanged("MailFolder");
            }
        }
        public bool Deleted
        {
            get { return deleted; }
            set { deleted = value; }
        }
        internal TimeSpan Delay { get { return DateTime.Now - date; } }

        public void ToggleRead()
        {
            read = !read;
        }
        void DataTweaking()
        {
            if (this.IsReply) return;
            if (this.Subject.IndexOf("IDataStore") > 0) read = false;
        }
        MailFolder GetFolder(DataRow row)
        {
            string ret = string.Format("{0}", row["Folder"]);
            if (string.IsNullOrEmpty(ret)) return DevExpress.DevAV.Controls.Messages.MailFolder.All;
            return (MailFolder)Enum.Parse(typeof(MailFolder), ret.Replace(" ", ""));
        }
        public void SetPlainText(string text) { plainText = text; }

        #region INotifyPropertyChanged Members
        PropertyChangedEventHandler propertyChanged;
        event PropertyChangedEventHandler INotifyPropertyChanged.PropertyChanged
        {
            add { propertyChanged += value; }
            remove { propertyChanged -= value; }
        }
        protected void OnPropertyChanged(string name)
        {
            if (propertyChanged != null) propertyChanged(this, new PropertyChangedEventArgs(name));
        }
        #endregion
    }
}