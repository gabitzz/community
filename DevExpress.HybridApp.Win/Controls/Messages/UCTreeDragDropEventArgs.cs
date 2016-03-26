using System;
using DevExpress.DevAV.Controls.Messages.Helpers;
using DevExpress.XtraTreeList.Nodes;

namespace DevExpress.DevAV.Controls.Messages
{
    public delegate void UCTreeDragDropEventHandler(object sender, UCTreeDragDropEventArgs e);

    public class UCTreeDragDropEventArgs : EventArgs {
        public TreeListNode Node { get; set; }
        public DragSelection Selection { get; set; }
    }
}