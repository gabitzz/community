using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars;
using System.Net.Mail;
using DevExpress.Data.Helpers;
using DevExpress.DevAV.Controls.Messages.Helpers;
using DevExpress.DevAV.Helpers;
using DevExpress.XtraPrinting.Export;
using DevExpress.XtraRichEdit.Model;
using EmailSender = DevExpress.DevAV.Controls.Messages.Helpers.EmailSender;
using Message = DevExpress.DevAV.Controls.Messages.Helpers.Message;

namespace DevExpress.MailClient.Win {
    public partial class frmEditMail :RibbonForm {
        bool isMessageModified;
        bool newMessage = true;
        string messageFrom = string.Empty;
        readonly Message sourceMessage;
        private bool _messageSent;


        public frmEditMail() {
            InitializeComponent();
            DialogResult = DialogResult.Cancel;
        }
        public frmEditMail(DevExpress.DevAV.Controls.Messages.Helpers.Message message, bool newMessage, string caption) {
            InitializeComponent();
            //DictionaryHelper.InitDictionary(spellChecker1);
            this.newMessage = newMessage;
            DialogResult = DialogResult.Cancel;
            this.sourceMessage = message;
            edtSubject.Text = message.Subject;
            TokenEditHelper.InitializeHistory(edtTo);
            edtTo.EditValue = TokenEditHelper.GetValue(message.From);
            richEditControl.HtmlText = message.Text;
            this.isMessageModified = newMessage;
            if(string.IsNullOrEmpty(message.From))
                splitContainerControl1.PanelVisibility = SplitPanelVisibility.Panel1;
            splitContainerControl1.Collapsed = newMessage;
            ucMessageInfo1.Init(message, ribbonControl.Manager);
            this.sendToEditSize = edtTo.Size;
            this.messageFrom = message.From;
            if(!newMessage) {
                splitContainerControl1.Collapsed = LayoutOption.MailCollapsed;
                lblTo.Text = string.Format("{0}:", caption);
                edtTo.Properties.ReadOnly = true;
                edtSubject.Properties.ReadOnly = true;
                richEditControl.ReadOnly = true;
            }
        }
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
        }
        protected override void OnClosing(CancelEventArgs e) {
            base.OnClosing(e);
            if(!newMessage)
                LayoutOption.MailCollapsed = splitContainerControl1.Collapsed;
        }
        public DevExpress.DevAV.Controls.Messages.Helpers.Message SourceMessage { get { return sourceMessage; } }
        public bool IsMessageModified {
            get { return isMessageModified || richEditControl.Modified; }
            set {
                isMessageModified = value;
                richEditControl.Modified = value;
            }
        }
        #region SaveMessage event
        EventHandler onSaveMessage;
        public event EventHandler SaveMessage { add { onSaveMessage += value; } remove { onSaveMessage -= value; } }
        protected internal virtual void RaiseSaveMessage() {
            if(onSaveMessage != null)
                onSaveMessage(this, EventArgs.Empty);
        }
        #endregion

        void richEditControl_SelectionChanged(object sender, EventArgs e) {
            tableToolsRibbonPageCategory1.Visible = richEditControl.IsSelectionInTable();
            floatingPictureToolsRibbonPageCategory1.Visible = richEditControl.IsFloatingObjectSelected;
        }
        void edtTo_EditValueChanged(object sender, EventArgs e) {
            isMessageModified = true;
        }
        void edtTo_ValidateToken(object sender, TokenEditValidateTokenEventArgs e) {
            if(!string.IsNullOrEmpty(this.messageFrom) && string.Equals(this.messageFrom, e.Description, StringComparison.OrdinalIgnoreCase)) {
                e.IsValid = true;
                return;
            }
            e.IsValid = TextHelper.IsMailAddressValid(e.Description);
        }
        void edtTo_BeforeShowPopupPanel(object sender, TokenEditBeforeShowPopupPanelEventArgs e) {
            Contact contact = e.Value as Contact;
            this.lblMail.Text = (contact != null) ? contact.FullName.ToString() : e.Description;
            this.lblDescription.Text = e.Description;
            this.picContact.Image = (contact != null && contact.HasPhoto) ? contact.Photo : null;
        }
        void edtTo_CustomDrawGlyph(object sender, TokenEditCustomDrawTokenGlyphEventArgs e) {
            Image image = GetTagGlyphImage(e.Value);
            if(image != null) e.Cache.Paint.DrawImage(e.Graphics, image, e.GlyphBounds, new Rectangle(Point.Empty, image.Size), true);
            e.Handled = true;
        }
        Image GetTagGlyphImage(object tag) {
            Contact contact = tag as Contact;
            if(contact == null) return null;
            return contact.Icon;
        }
        Size sendToEditSize = Size.Empty;
        void edtTo_SizeChanged(object sender, EventArgs e) {
            Size newSize = ((TokenEdit)sender).Size;
            panelControl.Height += (newSize.Height - sendToEditSize.Height);
            this.sendToEditSize = newSize;
        }
        void edtSubject_EditValueChanged(object sender, EventArgs e) {
            isMessageModified = true;
        }
        void fileSaveItem1_ItemClick(object sender, ItemClickEventArgs e) {
            ApplyChanges();
        }
        //void frmEditMail_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e) {
        //    if (e.KeyCode == Keys.Escape) {
        //        if (QueryClose() != DialogResult.Cancel)
        //            Close();
        //    }
        //}
        private void richEditControl_KeyDown(object sender, KeyEventArgs e) {
            if((e.Modifiers & Keys.Control) != 0 && e.KeyCode == Keys.S) {
                ApplyChanges();
                e.Handled = true;
            }
        }

        private void frmEditMail_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_messageSent)
            {
                DialogResult result = QueryClose();
                e.Cancel = result == DialogResult.Cancel;
            }
        }

        private DialogResult QueryClose()
        {
            if(!IsMessageModified)
                return DialogResult.Yes;

            DialogResult result = XtraMessageBox.Show(this, "Do you want to save changes?", Application.ProductName, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
            switch(result) {
                case DialogResult.Cancel:
                    return DialogResult.Cancel;
                case DialogResult.No:
                    return DialogResult.No;
                default:
                case DialogResult.Yes:
                    ApplyChanges();
                    return DialogResult.Yes;
            }
        }

        private void ApplyChanges() {
            sourceMessage.Date = DateTime.Now;
            sourceMessage.Text = richEditControl.HtmlText;
            sourceMessage.SetPlainText(ObjectHelper.GetPlainText(richEditControl.Text.TrimStart()));
            sourceMessage.Subject = edtSubject.Text;
            sourceMessage.From = edtTo.EditValue == null ? null : edtTo.EditValue.ToString();
            IsMessageModified = false;
            RaiseSaveMessage();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                _messageSent = false;
                var message = CreateMessage();
                var emailSender = new EmailSender();
                emailSender.Send(message);
                _messageSent = true;
                this.Close();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show("Error - Cannot send email.\r\n" + ex.Message);
            }
        }

        private MailMessage CreateMessage()
        {
            MailMessage message = null;
            var receivers = GetEmailReceivers();
            if (!string.IsNullOrEmpty(receivers))
            {
                message = new MailMessage();
                message.From = new MailAddress("silentbusters@gmail.com");
                message.To.Add(receivers);
                message.Body = richEditControl.Text;
                message.Subject = edtSubject.Text;
            }
            return message;
        }

        private string GetEmailReceivers()
        {
            string receivers = string.Empty;
            var tokens = edtTo.GetTokenList();
            foreach (TokenEditToken token in tokens)
            {
                if(!string.IsNullOrEmpty(receivers))
                {
                    receivers += ",";
                }
                receivers += token.Description;
            }
            return receivers;
        }


        private void barButtonItemAttach_ItemClick(object sender, ItemClickEventArgs e)
        {
            var openFileDialog = new OpenFileDialog
            {
                RestoreDirectory = true,
                Multiselect = true
            };

            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                var tokenAttachements = new StringBuilder();
                var tokens = tokenEditAttachements.Properties.Tokens;
                var valueFiles = new BindingList<string>();
                foreach (TokenEditToken selectedToken in tokenEditAttachements.GetTokenList())
                {
                    valueFiles.Add(selectedToken.Value.ToString());
                }

                foreach (var fullFileName in openFileDialog.FileNames)
                {
                    var file = Path.GetFileName(fullFileName);
                    var token = new TokenEditToken { Description = file, Value = fullFileName };
                    if (tokens.FirstOrDefault(t => t.Description == token.Description) == null)
                    {
                        tokens.Add(token);
                    }
                    if (!valueFiles.Contains(fullFileName))
                    {
                        valueFiles.Add(fullFileName);
                    }
                }
                tokenEditAttachements.EditValue = valueFiles;
                //tokenEditAttachements.EditValue = tokenEditAttachements.Properties.Tokens.Last().Description;
            }
        }
    }
}
