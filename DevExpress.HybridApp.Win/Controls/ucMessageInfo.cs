using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;

using DevExpress.XtraEditors;
using DevExpress.Utils.Menu;
using System.Collections;
using DevExpress.DevAV.Controls.Messages;
using DevExpress.DevAV.Controls.Messages.Helpers;

namespace DevExpress.MailClient.Win.Controls {
    public partial class ucMessageInfo : XtraUserControl {
        public ucMessageInfo() {
            InitializeComponent();
            if(RightToLeft == System.Windows.Forms.RightToLeft.Yes) tabbedControlGroup1.TextLocation = Utils.Locations.Right;
        }
        public void Init(Message message, IDXMenuManager menuManager) {
            gridControl1.MenuManager = menuManager;
            lcName.Text = message.From;
            //pictureEdit1.Image = Properties.Resources.Unknown_user;
            gridControl1.DataSource = GetMailByContactData(message);
            lcgContact.Text = "Contact";
            lcgMail.Text = string.Format("{0} ({1})", "Mail", gridView1.DataRowCount);
        }
        object GetMailByContactData(Message messageMain) {
            IEnumerable ret = from message in DataHelper.Messages
                              where message.From == messageMain.From && message.MailType == MailType.Inbox
                              select message;
            return ret.Cast<Message>().ToList();
        }
    }
}
