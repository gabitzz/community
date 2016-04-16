using DevExpress.XtraLayout;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication25 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            layoutControl1.Root.DefaultLayoutType = DevExpress.XtraLayout.Utils.LayoutType.Horizontal;//Columns group.

        }
        LayoutGroup currentGroup = null;
        private void button1_Click(object sender, EventArgs e) {
            layoutControl1.Root.ClearSelection();
            if(!AddFirstItemToEmptyGroup())
                currentGroup =layoutControl1.Root.AddGroup(FindUtmostItem(true), DevExpress.XtraLayout.Utils.InsertType.Left);
            currentGroup.Selected = true;
        }
        private void button2_Click(object sender, EventArgs e) {
            layoutControl1.Root.ClearSelection();
            if(!AddFirstItemToEmptyGroup())
                currentGroup = layoutControl1.Root.AddGroup(FindUtmostItem(false), DevExpress.XtraLayout.Utils.InsertType.Right);
            currentGroup.Selected = true;
        }
        protected BaseLayoutItem FindUtmostItem(bool findLeft) {
            BaseLayoutItem left = null, right = null;
            foreach(BaseLayoutItem item in layoutControl1.Root.Items) {
                if(left == null || left.X > item.X) left = item;
                if(right == null || right.Bounds.Right < item.Bounds.Right) right = item;
            }
            return findLeft ? left : right;
        }

        private bool AddFirstItemToEmptyGroup() {
            if(layoutControl1.Root.Count == 0) {
                currentGroup = layoutControl1.Root.AddGroup();
                currentGroup.DefaultLayoutType = DevExpress.XtraLayout.Utils.LayoutType.Vertical;//This is Column group
                return true;
            }
            return false;
        }

        

        private void button3_Click(object sender, EventArgs e) {
            if(currentGroup != null) {
                currentGroup.AddItem();
            }
        }

        private void button4_Click(object sender, EventArgs e) {
            List<LayoutGroup> groups = new List<LayoutGroup>();            
            foreach(BaseLayoutItem item in layoutControl1.Root.Items) groups.Add((LayoutGroup)item);
            layoutControl1.Root.ClearSelection();
            foreach(LayoutGroup group in groups) {
                group.Selected = true;
                group.Parent.UngroupSelected();
            }

        }

    }
}
