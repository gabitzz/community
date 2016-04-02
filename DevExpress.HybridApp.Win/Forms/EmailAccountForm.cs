using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.DevAV.Helpers;
using DevExpress.XtraEditors;

namespace DevExpress.DevAV.Forms
{
    public partial class EmailAccountForm : DevExpress.XtraEditors.XtraForm
    {
        public EmailAccount EmailAccount { get; set; }

        public EmailAccountForm()
        {
            InitializeComponent();
            Load += EmailAccountForm_Load;
        }

        private void EmailAccountForm_Load(object sender, EventArgs e)
        {
            if (this.EmailAccount != null)
            {
                txtName.Text = EmailAccount.Name;
                txtEmailAddress.Text = EmailAccount.Email;
                txtIncoming.Text = EmailAccount.Incoming;
                txtOutgoing.Text = EmailAccount.Outgoing;
                txtUserName.Text = EmailAccount.Username;
                txtPass.Text = EmailAccount.Password;
                txtPort.EditValue = EmailAccount.Port;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            EmailAccount.Name = txtName.Text;
            EmailAccount.Email = txtEmailAddress.Text;
            EmailAccount.Incoming = txtIncoming.Text;
            EmailAccount.Outgoing = txtOutgoing.Text;
            EmailAccount.Username = txtUserName.Text;
            EmailAccount.Password = txtPass.Text;
            EmailAccount.Port = (int) txtPort.EditValue;
            AccountWriter writer = new AccountWriter();
            writer.Save(EmailAccount);

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}