using System;

namespace DevExpress.DevAV.Controls.Messages
{
    public enum MailType { Inbox, Deleted, Sent, Draft };
    [Flags]
    public enum MailFolder { All = 0, Announcements = 1, ASP = 2, WinForms = 4, IDETools = 8, Frameworks = 16, Deleted = 32, Custom = 1024 };
    public enum ContactTitle { None, Dr, Miss, Mr, Mrs, Ms, Prof };
    public enum ContactGender { Male, Female }
}