namespace DevExpress.MailClient.Win {
    partial class Mail {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mail));
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition1 = new DevExpress.XtraGrid.StyleFormatCondition();
            this.gcIcon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemImageComboBox2 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.icEditors = new DevExpress.Utils.ImageCollection(this.components);
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.MailClient.Win.MyGridView();
            this.gcPriority = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemImageComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.gcAttachment = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemImageComboBox3 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.gcSubject = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcFrom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcRead = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemImageComboBox4 = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.ilColumns = new System.Windows.Forms.ImageList(this.components);
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lcList = new DevExpress.XtraLayout.LayoutControlItem();
            this.splitterItem1 = new DevExpress.XtraLayout.SplitterItem();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icEditors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // gcIcon
            // 
            resources.ApplyResources(this.gcIcon, "gcIcon");
            this.gcIcon.ColumnEdit = this.repositoryItemImageComboBox2;
            this.gcIcon.FieldName = "Read";
            this.gcIcon.Name = "gcIcon";
            this.gcIcon.OptionsColumn.AllowEdit = false;
            this.gcIcon.OptionsColumn.AllowFocus = false;
            this.gcIcon.OptionsColumn.AllowSize = false;
            this.gcIcon.OptionsColumn.FixedWidth = true;
            this.gcIcon.OptionsColumn.ShowCaption = false;
            // 
            // repositoryItemImageComboBox2
            // 
            resources.ApplyResources(this.repositoryItemImageComboBox2, "repositoryItemImageComboBox2");
            this.repositoryItemImageComboBox2.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox2.Items"), ((object)(resources.GetObject("repositoryItemImageComboBox2.Items1"))), ((int)(resources.GetObject("repositoryItemImageComboBox2.Items2")))),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox2.Items3"), ((object)(resources.GetObject("repositoryItemImageComboBox2.Items4"))), ((int)(resources.GetObject("repositoryItemImageComboBox2.Items5"))))});
            this.repositoryItemImageComboBox2.Name = "repositoryItemImageComboBox2";
            this.repositoryItemImageComboBox2.SmallImages = this.icEditors;
            // 
            // icEditors
            // 
            resources.ApplyResources(this.icEditors, "icEditors");
            this.icEditors.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("icEditors.ImageStream")));
            this.icEditors.Images.SetKeyName(0, "Low.png");
            this.icEditors.Images.SetKeyName(1, "High.png");
            this.icEditors.Images.SetKeyName(2, "ReadMessage_13x13.png");
            this.icEditors.Images.SetKeyName(3, "UnreadMessage_13x13.png");
            this.icEditors.Images.SetKeyName(4, "Attachment.png");
            this.icEditors.Images.SetKeyName(5, "Unread.png");
            this.icEditors.Images.SetKeyName(6, "Read.png");
            // 
            // layoutControl1
            // 
            this.layoutControl1.AllowCustomization = false;
            this.layoutControl1.Controls.Add(this.gridControl1);
            resources.ApplyResources(this.layoutControl1, "layoutControl1");
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(694, 412, 450, 350);
            this.layoutControl1.Root = this.layoutControlGroup1;
            // 
            // gridControl1
            // 
            resources.ApplyResources(this.gridControl1, "gridControl1");
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemImageComboBox1,
            this.repositoryItemImageComboBox2,
            this.repositoryItemImageComboBox3,
            this.repositoryItemImageComboBox4});
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcPriority,
            this.gcIcon,
            this.gcAttachment,
            this.gcSubject,
            this.gcFrom,
            this.gcDate,
            this.gcRead});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            styleFormatCondition1.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("resource.Font")));
            styleFormatCondition1.Appearance.Options.UseFont = true;
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Column = this.gcIcon;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
            styleFormatCondition1.Value1 = 0;
            this.gridView1.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupCount = 1;
            resources.ApplyResources(this.gridView1, "gridView1");
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(((DevExpress.Data.SummaryItemType)(resources.GetObject("gridView1.GroupSummary"))), resources.GetString("gridView1.GroupSummary1"), ((DevExpress.XtraGrid.Columns.GridColumn)(resources.GetObject("gridView1.GroupSummary2"))), resources.GetString("gridView1.GroupSummary3"))});
            this.gridView1.Images = this.ilColumns;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowFixedGroups = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsBehavior.AllowPixelScrolling = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsPrint.PrintHorzLines = false;
            this.gridView1.OptionsPrint.PrintVertLines = false;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsView.GroupDrawMode = DevExpress.XtraGrid.Views.Grid.GroupDrawMode.Office;
            this.gridView1.OptionsView.ShowGroupedColumns = true;
            this.gridView1.OptionsView.ShowIndicator = false;
            this.gridView1.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.PreviewFieldName = "PlainText";
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.gcDate, DevExpress.Data.ColumnSortOrder.Descending)});
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            this.gridView1.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridView1_RowCellClick);
            this.gridView1.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.gridView1_CustomDrawCell);
            this.gridView1.CustomDrawGroupRow += new DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventHandler(this.gridView1_CustomDrawGroupRow);
            this.gridView1.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.gridView1_SelectionChanged);
            this.gridView1.ColumnPositionChanged += new System.EventHandler(this.gridView1_ColumnPositionChanged);
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            this.gridView1.ColumnFilterChanged += new System.EventHandler(this.gridView1_ColumnFilterChanged);
            this.gridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridView1_KeyDown);
            this.gridView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gridView1_MouseDown);
            this.gridView1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gridView1_MouseMove);
            // 
            // gcPriority
            // 
            resources.ApplyResources(this.gcPriority, "gcPriority");
            this.gcPriority.ColumnEdit = this.repositoryItemImageComboBox1;
            this.gcPriority.FieldName = "Priority";
            this.gcPriority.Name = "gcPriority";
            this.gcPriority.OptionsColumn.AllowFocus = false;
            this.gcPriority.OptionsColumn.AllowSize = false;
            this.gcPriority.OptionsColumn.FixedWidth = true;
            this.gcPriority.OptionsColumn.ShowCaption = false;
            // 
            // repositoryItemImageComboBox1
            // 
            resources.ApplyResources(this.repositoryItemImageComboBox1, "repositoryItemImageComboBox1");
            this.repositoryItemImageComboBox1.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox1.Items"), ((object)(resources.GetObject("repositoryItemImageComboBox1.Items1"))), ((int)(resources.GetObject("repositoryItemImageComboBox1.Items2")))),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox1.Items3"), ((object)(resources.GetObject("repositoryItemImageComboBox1.Items4"))), ((int)(resources.GetObject("repositoryItemImageComboBox1.Items5")))),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox1.Items6"), ((object)(resources.GetObject("repositoryItemImageComboBox1.Items7"))), ((int)(resources.GetObject("repositoryItemImageComboBox1.Items8"))))});
            this.repositoryItemImageComboBox1.Name = "repositoryItemImageComboBox1";
            this.repositoryItemImageComboBox1.SmallImages = this.icEditors;
            // 
            // gcAttachment
            // 
            resources.ApplyResources(this.gcAttachment, "gcAttachment");
            this.gcAttachment.ColumnEdit = this.repositoryItemImageComboBox3;
            this.gcAttachment.FieldName = "Attachment";
            this.gcAttachment.Name = "gcAttachment";
            this.gcAttachment.OptionsColumn.AllowEdit = false;
            this.gcAttachment.OptionsColumn.AllowFocus = false;
            this.gcAttachment.OptionsColumn.AllowSize = false;
            this.gcAttachment.OptionsColumn.FixedWidth = true;
            this.gcAttachment.OptionsColumn.ShowCaption = false;
            // 
            // repositoryItemImageComboBox3
            // 
            resources.ApplyResources(this.repositoryItemImageComboBox3, "repositoryItemImageComboBox3");
            this.repositoryItemImageComboBox3.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox3.Items"), ((object)(resources.GetObject("repositoryItemImageComboBox3.Items1"))), ((int)(resources.GetObject("repositoryItemImageComboBox3.Items2")))),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox3.Items3"), ((object)(resources.GetObject("repositoryItemImageComboBox3.Items4"))), ((int)(resources.GetObject("repositoryItemImageComboBox3.Items5"))))});
            this.repositoryItemImageComboBox3.Name = "repositoryItemImageComboBox3";
            this.repositoryItemImageComboBox3.SmallImages = this.icEditors;
            // 
            // gcSubject
            // 
            resources.ApplyResources(this.gcSubject, "gcSubject");
            this.gcSubject.FieldName = "Subject";
            this.gcSubject.Name = "gcSubject";
            this.gcSubject.OptionsColumn.AllowFocus = false;
            // 
            // gcFrom
            // 
            resources.ApplyResources(this.gcFrom, "gcFrom");
            this.gcFrom.FieldName = "From";
            this.gcFrom.Name = "gcFrom";
            this.gcFrom.OptionsColumn.AllowFocus = false;
            // 
            // gcDate
            // 
            resources.ApplyResources(this.gcDate, "gcDate");
            this.gcDate.FieldName = "Date";
            this.gcDate.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.DateRange;
            this.gcDate.Name = "gcDate";
            this.gcDate.OptionsColumn.AllowFocus = false;
            this.gcDate.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.DateAlt;
            // 
            // gcRead
            // 
            this.gcRead.ColumnEdit = this.repositoryItemImageComboBox4;
            this.gcRead.FieldName = "Read";
            resources.ApplyResources(this.gcRead, "gcRead");
            this.gcRead.Name = "gcRead";
            this.gcRead.OptionsColumn.AllowEdit = false;
            this.gcRead.OptionsColumn.AllowFocus = false;
            this.gcRead.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.gcRead.OptionsColumn.AllowShowHide = false;
            this.gcRead.OptionsColumn.AllowSize = false;
            this.gcRead.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.gcRead.OptionsColumn.FixedWidth = true;
            this.gcRead.OptionsColumn.ShowCaption = false;
            this.gcRead.OptionsFilter.AllowAutoFilter = false;
            this.gcRead.OptionsFilter.AllowFilter = false;
            // 
            // repositoryItemImageComboBox4
            // 
            resources.ApplyResources(this.repositoryItemImageComboBox4, "repositoryItemImageComboBox4");
            this.repositoryItemImageComboBox4.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox4.Items"), ((object)(resources.GetObject("repositoryItemImageComboBox4.Items1"))), ((int)(resources.GetObject("repositoryItemImageComboBox4.Items2")))),
            new DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox4.Items3"), ((object)(resources.GetObject("repositoryItemImageComboBox4.Items4"))), ((int)(resources.GetObject("repositoryItemImageComboBox4.Items5"))))});
            this.repositoryItemImageComboBox4.Name = "repositoryItemImageComboBox4";
            this.repositoryItemImageComboBox4.SmallImages = this.icEditors;
            // 
            // ilColumns
            // 
            this.ilColumns.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilColumns.ImageStream")));
            this.ilColumns.TransparentColor = System.Drawing.Color.Transparent;
            this.ilColumns.Images.SetKeyName(0, "Importance.png");
            this.ilColumns.Images.SetKeyName(1, "Icon.png");
            this.ilColumns.Images.SetKeyName(2, "Attach.png");
            this.ilColumns.Images.SetKeyName(3, "Whatched.png");
            // 
            // layoutControlGroup1
            // 
            resources.ApplyResources(this.layoutControlGroup1, "layoutControlGroup1");
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lcList,
            this.splitterItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(6, 6, 6, 6);
            this.layoutControlGroup1.Size = new System.Drawing.Size(1226, 621);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // lcList
            // 
            this.lcList.Control = this.gridControl1;
            resources.ApplyResources(this.lcList, "lcList");
            this.lcList.Location = new System.Drawing.Point(0, 0);
            this.lcList.Name = "lcList";
            this.lcList.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.lcList.Size = new System.Drawing.Size(1209, 609);
            this.lcList.TextSize = new System.Drawing.Size(0, 0);
            this.lcList.TextVisible = false;
            // 
            // splitterItem1
            // 
            this.splitterItem1.AllowHotTrack = true;
            resources.ApplyResources(this.splitterItem1, "splitterItem1");
            this.splitterItem1.Location = new System.Drawing.Point(1209, 0);
            this.splitterItem1.Name = "splitterItem1";
            this.splitterItem1.Size = new System.Drawing.Size(5, 609);
            // 
            // Mail
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "Mail";
            this.Load += new System.EventHandler(this.Mail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icEditors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemImageComboBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraLayout.LayoutControlItem lcList;
        private DevExpress.XtraLayout.SplitterItem splitterItem1;
        private DevExpress.XtraGrid.Columns.GridColumn gcPriority;
        private DevExpress.XtraGrid.Columns.GridColumn gcIcon;
        private DevExpress.XtraGrid.Columns.GridColumn gcAttachment;
        private DevExpress.XtraGrid.Columns.GridColumn gcSubject;
        private DevExpress.XtraGrid.Columns.GridColumn gcFrom;
        private DevExpress.XtraGrid.Columns.GridColumn gcDate;
        private DevExpress.XtraGrid.Columns.GridColumn gcRead;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox2;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox1;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox3;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox repositoryItemImageComboBox4;
        private DevExpress.Utils.ImageCollection icEditors;
        private System.Windows.Forms.ImageList ilColumns;
        protected internal MyGridView gridView1;
    }
}
