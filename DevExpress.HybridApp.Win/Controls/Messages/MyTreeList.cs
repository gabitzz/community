using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Nodes;

namespace DevExpress.DevAV.Controls.Messages{
    public class MyTreeList : TreeList {
        public DevExpress.XtraTreeList.Handler.StateData StateData {get {
                return this.Handler.StateData;
            }
        }
        protected internal TreeListNode DropTaget {
            get {
                if(StateData != null && StateData.DragInfo != null && StateData.DragInfo.RowInfo != null) return StateData.DragInfo.RowInfo.Node;
                return null;
            }
        }
    }
}