namespace DevExpress.DevAV.Modules {
    partial class Messages {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode2 = new DevExpress.XtraGrid.GridLevelNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Messages));
            this.orderItemsGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ProductGC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.unitsGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.unitPriceGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.totalGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.discountGridColumn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.salesGridControl = new DevExpress.XtraGrid.GridControl();
            this.salesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salesGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colInvoiceNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStore = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOrderDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.searchControl = new DevExpress.XtraEditors.SearchControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.ucMailTree1 = new DevExpress.DevAV.Controls.Messages.ucMailTree();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.orderItemsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // orderItemsGridView
            // 
            this.orderItemsGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ProductGC,
            this.unitsGridColumn,
            this.unitPriceGridColumn,
            this.totalGridColumn,
            this.discountGridColumn});
            this.orderItemsGridView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            this.orderItemsGridView.GridControl = this.salesGridControl;
            this.orderItemsGridView.Name = "orderItemsGridView";
            this.orderItemsGridView.OptionsBehavior.Editable = false;
            this.orderItemsGridView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.orderItemsGridView.OptionsView.ShowGroupPanel = false;
            this.orderItemsGridView.OptionsView.ShowIndicator = false;
            this.orderItemsGridView.PreviewFieldName = "OrderItems";
            // 
            // ProductGC
            // 
            this.ProductGC.Caption = "Product";
            this.ProductGC.FieldName = "Product.Name";
            this.ProductGC.Name = "ProductGC";
            this.ProductGC.Visible = true;
            this.ProductGC.VisibleIndex = 0;
            this.ProductGC.Width = 159;
            // 
            // unitsGridColumn
            // 
            this.unitsGridColumn.Caption = "Units";
            this.unitsGridColumn.FieldName = "ProductUnits";
            this.unitsGridColumn.Name = "unitsGridColumn";
            this.unitsGridColumn.OptionsColumn.FixedWidth = true;
            this.unitsGridColumn.Visible = true;
            this.unitsGridColumn.VisibleIndex = 1;
            this.unitsGridColumn.Width = 120;
            // 
            // unitPriceGridColumn
            // 
            this.unitPriceGridColumn.Caption = "Unit Price";
            this.unitPriceGridColumn.DisplayFormat.FormatString = "c";
            this.unitPriceGridColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.unitPriceGridColumn.FieldName = "ProductPrice";
            this.unitPriceGridColumn.Name = "unitPriceGridColumn";
            this.unitPriceGridColumn.OptionsColumn.FixedWidth = true;
            this.unitPriceGridColumn.Visible = true;
            this.unitPriceGridColumn.VisibleIndex = 2;
            this.unitPriceGridColumn.Width = 120;
            // 
            // totalGridColumn
            // 
            this.totalGridColumn.Caption = "Total";
            this.totalGridColumn.DisplayFormat.FormatString = "c";
            this.totalGridColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.totalGridColumn.FieldName = "Total";
            this.totalGridColumn.Name = "totalGridColumn";
            this.totalGridColumn.OptionsColumn.FixedWidth = true;
            this.totalGridColumn.Visible = true;
            this.totalGridColumn.VisibleIndex = 3;
            this.totalGridColumn.Width = 120;
            // 
            // discountGridColumn
            // 
            this.discountGridColumn.Caption = "Discount";
            this.discountGridColumn.DisplayFormat.FormatString = "c";
            this.discountGridColumn.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.discountGridColumn.FieldName = "Discount";
            this.discountGridColumn.Name = "discountGridColumn";
            this.discountGridColumn.OptionsColumn.FixedWidth = true;
            this.discountGridColumn.Visible = true;
            this.discountGridColumn.VisibleIndex = 4;
            this.discountGridColumn.Width = 120;
            // 
            // salesGridControl
            // 
            this.salesGridControl.DataSource = this.salesBindingSource;
            gridLevelNode1.LevelTemplate = this.orderItemsGridView;
            gridLevelNode1.RelationName = "OrderItems";
            gridLevelNode2.RelationName = "Level1";
            this.salesGridControl.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1,
            gridLevelNode2});
            this.salesGridControl.Location = new System.Drawing.Point(172, 72);
            this.salesGridControl.MainView = this.salesGridView;
            this.salesGridControl.Name = "salesGridControl";
            this.salesGridControl.Size = new System.Drawing.Size(697, 446);
            this.salesGridControl.TabIndex = 2;
            this.salesGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.salesGridView,
            this.gridView1,
            this.orderItemsGridView});
            // 
            // salesBindingSource
            // 
            this.salesBindingSource.DataSource = typeof(DevExpress.DevAV.Order);
            // 
            // salesGridView
            // 
            this.salesGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colInvoiceNumber,
            this.colCustomer,
            this.colStore,
            this.colOrderDate,
            this.colTotalAmount});
            this.salesGridView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            this.salesGridView.GridControl = this.salesGridControl;
            this.salesGridView.Name = "salesGridView";
            this.salesGridView.OptionsBehavior.AutoExpandAllGroups = true;
            this.salesGridView.OptionsBehavior.Editable = false;
            this.salesGridView.OptionsCustomization.AllowQuickHideColumns = false;
            this.salesGridView.OptionsDetail.EnableMasterViewMode = false;
            this.salesGridView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.salesGridView.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.salesGridView.OptionsView.ShowIndicator = false;
            this.salesGridView.RowHeight = 10;
            this.salesGridView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colInvoiceNumber, DevExpress.Data.ColumnSortOrder.Descending)});
            // 
            // colInvoiceNumber
            // 
            this.colInvoiceNumber.Caption = "Invoice";
            this.colInvoiceNumber.FieldName = "InvoiceNumber";
            this.colInvoiceNumber.Name = "colInvoiceNumber";
            this.colInvoiceNumber.OptionsColumn.FixedWidth = true;
            this.colInvoiceNumber.Visible = true;
            this.colInvoiceNumber.VisibleIndex = 0;
            this.colInvoiceNumber.Width = 20;
            // 
            // colCustomer
            // 
            this.colCustomer.Caption = "Company";
            this.colCustomer.FieldName = "Store.CustomerName";
            this.colCustomer.Name = "colCustomer";
            this.colCustomer.Visible = true;
            this.colCustomer.VisibleIndex = 2;
            this.colCustomer.Width = 24;
            // 
            // colStore
            // 
            this.colStore.Caption = "Store";
            this.colStore.FieldName = "Store.Address.City";
            this.colStore.Name = "colStore";
            this.colStore.Visible = true;
            this.colStore.VisibleIndex = 3;
            this.colStore.Width = 25;
            // 
            // colOrderDate
            // 
            this.colOrderDate.FieldName = "OrderDate";
            this.colOrderDate.Name = "colOrderDate";
            this.colOrderDate.OptionsColumn.FixedWidth = true;
            this.colOrderDate.Visible = true;
            this.colOrderDate.VisibleIndex = 1;
            this.colOrderDate.Width = 100;
            // 
            // colTotalAmount
            // 
            this.colTotalAmount.DisplayFormat.FormatString = "c";
            this.colTotalAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTotalAmount.FieldName = "TotalAmount";
            this.colTotalAmount.Name = "colTotalAmount";
            this.colTotalAmount.OptionsColumn.FixedWidth = true;
            this.colTotalAmount.Visible = true;
            this.colTotalAmount.VisibleIndex = 4;
            this.colTotalAmount.Width = 129;
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.salesGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // searchControl
            // 
            this.searchControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchControl.Client = this.salesGridControl;
            this.searchControl.EditValue = "";
            this.searchControl.Location = new System.Drawing.Point(569, 25);
            this.searchControl.MaximumSize = new System.Drawing.Size(300, 38);
            this.searchControl.MinimumSize = new System.Drawing.Size(100, 20);
            this.searchControl.Name = "searchControl";
            this.searchControl.Properties.AutoHeight = false;
            this.searchControl.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.SearchButton(40, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("searchControl.Properties.Buttons"))), true, true)});
            this.searchControl.Properties.Client = this.salesGridControl;
            this.searchControl.Properties.ShowClearButton = false;
            this.searchControl.Size = new System.Drawing.Size(300, 38);
            this.searchControl.StyleController = this.layoutControl1;
            this.searchControl.TabIndex = 18;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.ucMailTree1);
            this.layoutControl1.Controls.Add(this.searchControl);
            this.layoutControl1.Controls.Add(this.salesGridControl);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(795, 354, 250, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(893, 542);
            this.layoutControl1.TabIndex = 19;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // ucMailTree1
            // 
            this.ucMailTree1.Location = new System.Drawing.Point(24, 24);
            this.ucMailTree1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucMailTree1.Name = "ucMailTree1";
            this.ucMailTree1.Size = new System.Drawing.Size(110, 494);
            this.ucMailTree1.TabIndex = 19;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem1,
            this.layoutControlGroup2,
            this.layoutControlGroup3});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(893, 542);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(138, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(10, 522);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3,
            this.layoutControlItem4});
            this.layoutControlGroup2.Location = new System.Drawing.Point(148, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(725, 522);
            this.layoutControlGroup2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.salesGridControl;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem3.MinSize = new System.Drawing.Size(104, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(701, 450);
            this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.searchControl;
            this.layoutControlItem4.ControlAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.layoutControlItem4.FillControlToClientArea = false;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem4.MinSize = new System.Drawing.Size(104, 46);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(701, 48);
            this.layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem5});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(138, 522);
            this.layoutControlGroup3.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.ucMailTree1;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(114, 498);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.salesGridControl;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 46);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(304, 531);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // Messages
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.Controls.Add(this.layoutControl1);
            this.Name = "Messages";
            this.Size = new System.Drawing.Size(893, 542);
            ((System.ComponentModel.ISupportInitialize)(this.orderItemsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource salesBindingSource;
        private XtraGrid.GridControl salesGridControl;
        private XtraGrid.Views.Grid.GridView orderItemsGridView;
        private XtraGrid.Columns.GridColumn ProductGC;
        private XtraGrid.Columns.GridColumn unitsGridColumn;
        private XtraGrid.Columns.GridColumn unitPriceGridColumn;
        private XtraGrid.Columns.GridColumn totalGridColumn;
        private XtraGrid.Columns.GridColumn discountGridColumn;
        private XtraGrid.Views.Grid.GridView salesGridView;
        private XtraGrid.Columns.GridColumn colInvoiceNumber;
        private XtraGrid.Columns.GridColumn colCustomer;
        private XtraGrid.Columns.GridColumn colStore;
        private XtraGrid.Columns.GridColumn colOrderDate;
        private XtraGrid.Columns.GridColumn colTotalAmount;
        private XtraGrid.Views.Grid.GridView gridView1;
        public XtraEditors.SearchControl searchControl;
        private XtraLayout.LayoutControlItem layoutControlItem1;
        private XtraLayout.LayoutControl layoutControl1;
        private XtraLayout.LayoutControlGroup layoutControlGroup1;
        private XtraLayout.LayoutControlItem layoutControlItem3;
        private XtraLayout.EmptySpaceItem emptySpaceItem1;
        private XtraLayout.LayoutControlItem layoutControlItem4;
        private Controls.Messages.ucMailTree ucMailTree1;
        private XtraLayout.LayoutControlItem layoutControlItem5;
        private XtraLayout.LayoutControlGroup layoutControlGroup2;
        private XtraLayout.LayoutControlGroup layoutControlGroup3;
    }
}
