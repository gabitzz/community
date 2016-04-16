using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using DevExpress.DevAV.Controls.Messages;
using DevExpress.DevAV.Controls.Messages.Helpers;
using DevExpress.DevAV.Helpers;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Mask;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;

namespace DevExpress.DevAV.Forms
{
    public partial class EmailRulesForm : XtraForm
    {
        private readonly DataSet _xmlDataSet = new DataSet();

        private static string EmailRulesFile => Path.Combine(Constants.BASE_DATA_PATH, "EmailRules.xml");

        public EmailRulesForm()
        {
            InitializeComponent();
            Load += OnLoad;
        }

        private void OnLoad(object sender, EventArgs e)
        {
            _xmlDataSet.ReadXml(EmailRulesFile);

            gridControl1.DataSource = _xmlDataSet.Tables["EmailRule"];

            gridView1.Columns["To"].Visible = false;
           
            SetFromEditor();

            SetMoveToEditor();

        }

        private void SetFromEditor()
        {
            var emailTextEdit = new RepositoryItemTextEdit();
            emailTextEdit.Mask.MaskType = MaskType.RegEx;
            emailTextEdit.Mask.EditMask = @"[A-Za-z0-9._%-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}";

            gridView1.Columns["From"].ColumnEdit = emailTextEdit;
            gridView1.Columns["From"].Width = 130;

        }

        private void SetMoveToEditor()
        {
            var folderDropDown = new RepositoryItemComboBox
            {
                TextEditStyle = TextEditStyles.DisableTextEditor
            };
            foreach (var mailFolder in Enum.GetValues(typeof (MailFolder)))
            {
                folderDropDown.Items.Add(mailFolder.ToString());
            }
            gridView1.Columns["Folder"].ColumnEdit = folderDropDown;
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            _xmlDataSet.WriteXml(EmailRulesFile);

            DialogResult = DialogResult.OK;
            Close();
        }

        private void gridControl1_ProcessGridKey(object sender, KeyEventArgs e)
        {
            var grid = sender as GridControl;
            var view = grid.FocusedView as GridView;
            if (e.KeyData == Keys.Delete)
            {
                view.DeleteSelectedRows();
                e.Handled = true;
            }
        }
    }
}