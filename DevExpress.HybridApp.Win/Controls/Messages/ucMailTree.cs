using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Skins;
using DevExpress.XtraTreeList.Nodes;
using DevExpress.XtraTreeList;
using DevExpress.Utils.Design;
using System.Collections;
using DevExpress.DevAV.Controls.Messages;
using DevExpress.DevAV.Controls.Messages.Helpers;
using Message = DevExpress.DevAV.Controls.Messages.Helpers.Message;


namespace DevExpress.DevAV.Controls.Messages
{
    public partial class ucMailTree : DevExpress.DevAV.Controls.Messages.BaseControl
    {
        public event DataSourceChangedEventHandler DataSourceChanged;
        public event MouseEventHandler ShowMenu;bool allowDataSourceChanged = false;
        public ucMailTree() {
            InitializeComponent();
            InitData();
            treeList1.RowHeight = Math.Max(Convert.ToInt32(treeList1.Font.GetHeight()), icFolders.ImageSize.Height) + 5;
        }
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            if(!DesignTimeTools.IsDesignMode)
                treeList1.FocusedNode = treeList1.Nodes[0].Nodes[0];
        }
        void InitData() {
            TreeListNode tlAnnouncements = treeList1.AppendNode(new object[] { "Announcements", MailType.Inbox, MailFolder.Announcements, 5 }, null);
            treeList1.AppendNode(new object[] { "Inbox", MailType.Inbox, MailFolder.Announcements }, tlAnnouncements);
            treeList1.AppendNode(new object[] { "SentItems", MailType.Sent, MailFolder.Announcements, 1 }, tlAnnouncements);
            //treeList1.AppendNode(new object[] { Properties.Resources.DeletedItems, MailType.Deleted, MailFolder.Deleted, 2 }, tlAnnouncements);
            TreeListNode tlPerson = treeList1.AppendNode(new object[] { "Viorels", MailType.Inbox, MailFolder.All, 4 }, null);
            TreeListNode tlPersonInbox = treeList1.AppendNode(new object[] { "Inbox", MailType.Inbox, MailFolder.All }, tlPerson);
            treeList1.AppendNode(new object[] { "ASP", MailType.Inbox, MailFolder.ASP, 6 }, tlPersonInbox);
            treeList1.AppendNode(new object[] { "WinForms", MailType.Inbox, MailFolder.WinForms, 9  }, tlPersonInbox);
            treeList1.AppendNode(new object[] { "IDETools", MailType.Inbox, MailFolder.IDETools, 7 }, tlPersonInbox);
            treeList1.AppendNode(new object[] { "Frameworks", MailType.Inbox, MailFolder.Frameworks, 8 }, tlPersonInbox);
            treeList1.AppendNode(new object[] { "SentItems", MailType.Sent, MailFolder.All, 1 }, tlPerson);
            treeList1.AppendNode(new object[] { "DeletedItems", MailType.Deleted, MailFolder.Deleted, 2 }, tlPerson);
            treeList1.AppendNode(new object[] { "Drafts", MailType.Draft, MailFolder.All, 3 }, tlPerson);

            treeList1.ExpandAll();
            if(!DesignTimeTools.IsDesignMode)
                CreateMessagesList(treeList1.Nodes);
            allowDataSourceChanged = true;
        }

        void CreateMessagesList(TreeListNodes nodes) {
            foreach(TreeListNode node in nodes) {
                CreateMessagesForNode(node);
                CreateMessagesList(node.Nodes);
                if(GetNodeMailFolder(node) >= (int)MailFolder.Custom) {
                    List<TreeListNode> children = new List<TreeListNode>();
                    children.Add(node);
                    GetAllChildren(node, children);
                    List<Message> list = new List<Message>();
                    foreach(var n in children) {
                        list.AddRange(((IEnumerable<Message>)n.GetValue(colData)));
                    }
                    node.SetValue(colData, list);

                }

            }
        }
        void GetAllChildren(TreeListNode node, List<TreeListNode> list) {
            if(!node.HasChildren) return;
            foreach(TreeListNode child in node.Nodes) {
                list.Add(child);
                GetAllChildren(child, list);
            }
        }
        internal MailType GetNodeMailType(TreeListNode node) {
            return (MailType)node.GetValue(colType);
        }
        internal int GetNodeMailFolder(TreeListNode node) {
            return (int)node.GetValue(colFolder);
        }
        void CreateMessagesForNode(TreeListNode node) {
            List<Message> messages = new List<Message>();
            MailType mailType = GetNodeMailType(node);
            int mailFolder = GetNodeMailFolder(node);
            foreach(DevExpress.DevAV.Controls.Messages.Helpers.Message message in DataHelper.Messages) {
                if(message.MailType == mailType && 
                    (message.MailFolder == mailFolder || mailFolder == (int)MailFolder.All || mailType == MailType.Deleted) &&
                    !message.Deleted)
                        messages.Add(message);
            }
            node.SetValue(colData, messages);
        }
        protected override void LookAndFeelStyleChanged() {
            base.LookAndFeelStyleChanged();
            Color controlColor = CommonSkins.GetSkin(DevExpress.LookAndFeel.UserLookAndFeel.Default).Colors.GetColor("Control");
            treeList1.Appearance.Empty.BackColor = controlColor;
            treeList1.Appearance.Row.BackColor = controlColor;
        }
        private void treeList1_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e) {
            RaiseDataSourceChanged(e.Node);
        }
        void RaiseDataSourceChanged(TreeListNode node) {
            if(DataSourceChanged != null && allowDataSourceChanged)
                DataSourceChanged(treeList1, new DataSourceChangedEventArgs(GetNodeCaption(node), node.GetValue(colData), node.GetValue(colType)));
        }
        string GetNodeCaption(TreeListNode node) { 
            string ret = string.Format("{0}", node.GetValue(colName));
            while(node.ParentNode != null) {
                node = node.ParentNode;
                ret = string.Format("{0} - {1}", node.GetValue(colName), ret);
            }
            return ret;
        }
        private void treeList1_CustomDrawNodeCell(object sender, CustomDrawNodeCellEventArgs e) {
            if(DesignTimeTools.IsDesignMode) return;
            if(e.Column == colName) {
                string textColor = GetHtmlTextColor(treeList1.FocusedNode.Equals(e.Node));
                object textValue = e.Node.GetValue(colName);
                e.CellText = string.Format("<Color={1}>{0}", textValue, textColor);
                if(e.Node.ParentNode == null || !(DataHelper.ShowAllMessageCount || DataHelper.ShowUnreadMessageCount)) return;
                List<Message> list = e.Node.GetValue(colData) as List<Message>;
                int unread = GetUnreadMessagesCount(list);
                if(unread > 0 && DataHelper.ShowUnreadMessageCount) {
                    if(DataHelper.ShowAllMessageCount)
                        e.CellText = string.Format("<Color={5}><b>{0}</b><Size=-1><Color={2}> [{1}/<Color={4}>{3}<Color={2}>]", textValue, unread, ColorHelper.HtmlQuestionColor, list.Count, ColorHelper.HtmlWarningColor, textColor);
                    else
                        e.CellText = string.Format("<Color={3}><b>{0}</b><Size=-1><Color={2}> [{1}]", textValue, unread, ColorHelper.HtmlQuestionColor, textColor);
                } else {
                    if(DataHelper.ShowAllMessageCount && list.Count > 0)
                        e.CellText = string.Format("<Color={3}>{0}<Size=-1><Color={2}> [{1}]", textValue, list.Count, ColorHelper.HtmlWarningColor, textColor);
                }
            }
        }
        static string GetHtmlTextColor(bool focused) {
            if(focused) 
                return ColorHelper.HtmlHighlightTextColor;
            return AllowControlTextColor ? ColorHelper.HtmlControlTextColor : ColorHelper.HtmlControlTextColor2;
        }
        static bool AllowControlTextColor {
            get {
                return DevExpress.LookAndFeel.UserLookAndFeel.Default.ActiveSkinName != "Glass Oceans";
            }
        }
        int GetUnreadMessagesCount(List<Message> list) {
            return list.Count(p => p.IsUnread);
        }
        internal bool IsDeletedFolderFocused() { return treeList1.FocusedNode != null && GetNodeMailFolder(treeList1.FocusedNode) == (int)MailFolder.Deleted; }
        static int CustomFolderId = (int)MailFolder.Custom;
        internal void CreateNewFolder() {
            if(treeList1.FocusedNode == null || IsDeletedFolderFocused()) return;
            var node = treeList1.FocusedNode.Nodes.Add(new object[] { "New Folder", MailType.Inbox, CustomFolderId++, 9, new List<Message>() });
            
            treeList1.FocusedNode = node;
            StartEditing();

        }
        internal void StartEditing() {
            if(treeList1.FocusedNode == null || IsDeletedFolderFocused()) return;
            treeList1.OptionsBehavior.Editable = true;
            treeList1.VisibleColumns[0].OptionsColumn.AllowFocus = true;
            treeList1.FocusedColumn = treeList1.VisibleColumns[0];
            treeList1.ShowEditor();
        }
        private void treeList1_HiddenEditor(object sender, EventArgs e) {
            treeList1.OptionsBehavior.Editable = false;
            treeList1.VisibleColumns[0].OptionsColumn.AllowFocus = false;
            treeList1.ClearFocusedColumn();
        }
        internal void RefreshTreeList() {
            treeList1.LayoutChanged();
        }
        private void treeList1_MouseDown(object sender, MouseEventArgs e) {
            if(e.Button == MouseButtons.Right && ShowMenu != null) ShowMenu(sender, e); 
        }

        internal void UpdateTreeViewMessages() {
            CreateMessagesList(treeList1.Nodes);
            RefreshTreeList();
            RaiseDataSourceChanged(treeList1.FocusedNode);
        }


        private void treeList1_DragEnter(object sender, DragEventArgs e) {
            DragSelection dragSelection = e.Data.GetData(typeof(DragSelection)) as DragSelection;
            if(dragSelection == null) return;
            e.Effect = DragDropEffects.Move;
        }

        private void treeList1_DragDrop(object sender, DragEventArgs e) {
            DragSelection dragSelection = e.Data.GetData(typeof(DragSelection)) as DragSelection;
            if(dragSelection == null) return;
            if(treeList1.DropTaget != null) OnTreeDragDrop(treeList1.DropTaget, dragSelection);
        }
        public event UCTreeDragDropEventHandler UCTreeDragDrop;
        void OnTreeDragDrop(TreeListNode node, DragSelection selection) {
            if(UCTreeDragDrop != null) UCTreeDragDrop(this, new UCTreeDragDropEventArgs() { Node = node, Selection = selection });

        }

        private void treeList1_CustomNodeCellEditForEditing(object sender, GetCustomNodeCellEditEventArgs e) {
            e.RepositoryItem = repositoryItemTextEdit1;
        }


    }
}
