using System;
using System.Linq;
using System.Windows.Forms;
using DevExpress.DevAV.Controls.Messages.Helpers;
using DevExpress.XtraEditors;

namespace DevExpress.DevAV.Forms
{
    public partial class EmailRulesForm : XtraForm
    {
        public EmailRule EmailRule
        {
            get
            {
                return new EmailRule
                {
                    From = txtFrom.Text,
                    To = txtTo.Text,
                    Subject = txtSubject.Text,
                    Folder = txtMoveTo.Text
                };
            }
            set
            {
                if (value == null) return;
                txtFrom.Text = value.From;
                txtTo.Text = value.To;
                txtSubject.Text = value.Subject;
                txtMoveTo.Text = value.Folder;
            }
        }

        public EmailRulesForm()
        {
            InitializeComponent();
            Load += OnLoad;
        }

        private void OnLoad(object sender, EventArgs e)
        {
            var firstRule = EmailRulesHelper.Instance.GetEmailRules().Rules.FirstOrDefault();
            EmailRule = firstRule;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            EmailRulesHelper.Instance.AddRule(EmailRule);

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}