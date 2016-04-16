using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Controls;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;

namespace DevExpress.DevAV.Controls.Messages.Helpers
{
    public class GridHelper
    {
        public static void GetChildDataRowHandles(GridView view, int rowHandle, List<Message> list)
        {
            for (int i = 0; i < view.GetChildRowCount(rowHandle); i++)
            {
                int row = view.GetChildRowHandle(rowHandle, i);
                if (row >= 0)
                    list.Add(view.GetRow(row) as Message);
                else
                    GetChildDataRowHandles(view, row, list);
            }
        }
        public static void SetFindControlImages(GridControl grid)
        {
            FindControl fControl = null;
            foreach (Control ctrl in grid.Controls)
            {
                fControl = ctrl as FindControl;
                if (fControl != null) break;
            }
            if (fControl != null)
            {
                //fControl.FindButton.Image = global::DevExpress.MailClient.Win.Properties.Resources.Search;
                //fControl.ClearButton.Image = global::DevExpress.MailClient.Win.Properties.Resources.Delete_16x16;
                fControl.CalcButtonsBestFit();
            }
        }
        public static void GridViewFocusObject(ColumnView cView, object obj)
        {
            if (obj == null) return;
            int oldFocusedRowHandle = cView.FocusedRowHandle;
            for (int i = 0; i < cView.DataRowCount; ++i)
            {
                object rowObj = cView.GetRow(i) as object;
                if (rowObj == null) continue;
                if (ReferenceEquals(obj, rowObj))
                {
                    if (i == oldFocusedRowHandle)
                        cView.FocusedRowHandle = GridControl.InvalidRowHandle;
                    cView.FocusedRowHandle = i;
                    break;
                }
            }
        }
    }
}