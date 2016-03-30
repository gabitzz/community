namespace DevExpress.DevAV.Modules {
    public partial class Portal {
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
            DevExpress.XtraEditors.TileItemElement tileItemElement1 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement2 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement3 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement4 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement5 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement6 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement7 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement8 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement9 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement10 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement11 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement12 = new DevExpress.XtraEditors.TileItemElement();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Portal));
            this.productsSource = new System.Windows.Forms.BindingSource(this.components);
            this.collapseButton = new DevExpress.XtraLayout.SimpleLabelItem();
            this.simpleLabelItem2 = new DevExpress.XtraLayout.SimpleLabelItem();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.portalWebBrowser = new System.Windows.Forms.WebBrowser();
            this.tileControl = new DevExpress.XtraEditors.TileControl();
            this.tileGroup = new DevExpress.XtraEditors.TileGroup();
            this.tileItemAll = new DevExpress.XtraEditors.TileItem();
            this.tileItemTelevisions = new DevExpress.XtraEditors.TileItem();
            this.tileItemMonitors = new DevExpress.XtraEditors.TileItem();
            this.tileItemVideoPlayers = new DevExpress.XtraEditors.TileItem();
            this.tileItemProjectors = new DevExpress.XtraEditors.TileItem();
            this.tileItemAutomation = new DevExpress.XtraEditors.TileItem();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.tileControlLCI = new DevExpress.XtraLayout.LayoutControlItem();
            this.hideButton = new DevExpress.XtraLayout.SimpleLabelItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.productsSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.collapseButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileControlLCI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hideButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // productsSource
            // 
            this.productsSource.DataSource = typeof(DevExpress.DevAV.Product);
            // 
            // collapseButton
            // 
            this.collapseButton.AllowHotTrack = false;
            this.collapseButton.CustomizationFormText = " ";
            this.collapseButton.Location = new System.Drawing.Point(168, 34);
            this.collapseButton.MaxSize = new System.Drawing.Size(28, 0);
            this.collapseButton.MinSize = new System.Drawing.Size(28, 1);
            this.collapseButton.Name = "collapseButton";
            this.collapseButton.Size = new System.Drawing.Size(28, 551);
            this.collapseButton.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.collapseButton.Text = " ";
            this.collapseButton.TextSize = new System.Drawing.Size(73, 28);
            // 
            // simpleLabelItem2
            // 
            this.simpleLabelItem2.AllowHotTrack = false;
            this.simpleLabelItem2.AppearanceItemCaption.FontSizeDelta = 5;
            this.simpleLabelItem2.AppearanceItemCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(81)))), ((int)(((byte)(165)))));
            this.simpleLabelItem2.AppearanceItemCaption.Options.UseFont = true;
            this.simpleLabelItem2.AppearanceItemCaption.Options.UseForeColor = true;
            this.simpleLabelItem2.CustomizationFormText = "PRODUCT";
            this.simpleLabelItem2.Location = new System.Drawing.Point(0, 0);
            this.simpleLabelItem2.Name = "simpleLabelItem1";
            this.simpleLabelItem2.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 10, 10);
            this.simpleLabelItem2.Size = new System.Drawing.Size(1044, 50);
            this.simpleLabelItem2.Text = "Categories";
            this.simpleLabelItem2.TextSize = new System.Drawing.Size(116, 30);
            // 
            // layoutControl1
            // 
            this.layoutControl1.AllowCustomization = false;
            this.layoutControl1.BackColor = System.Drawing.Color.White;
            this.layoutControl1.Controls.Add(this.portalWebBrowser);
            this.layoutControl1.Controls.Add(this.tileControl);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(593, 271, 930, 751);
            this.layoutControl1.OptionsView.UseParentAutoScaleFactor = true;
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(1104, 582);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // portalWebBrowser
            // 
            this.portalWebBrowser.Location = new System.Drawing.Point(172, 2);
            this.portalWebBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.portalWebBrowser.Name = "portalWebBrowser";
            this.portalWebBrowser.ScriptErrorsSuppressed = true;
            this.portalWebBrowser.Size = new System.Drawing.Size(890, 578);
            this.portalWebBrowser.TabIndex = 27;
            this.portalWebBrowser.Url = new System.Uri("http://portal.netrom.local", System.UriKind.Absolute);
            this.portalWebBrowser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.portalWebBrowser_DocumentCompleted);
            // 
            // tileControl
            // 
            this.tileControl.AllowDrag = false;
            this.tileControl.AllowGlyphSkinning = true;
            this.tileControl.AllowSelectedItem = true;
            this.tileControl.AppearanceItem.Hovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(114)))), ((int)(((byte)(191)))));
            this.tileControl.AppearanceItem.Hovered.Options.UseBackColor = true;
            this.tileControl.AppearanceItem.Normal.BackColor = System.Drawing.Color.White;
            this.tileControl.AppearanceItem.Normal.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.tileControl.AppearanceItem.Normal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            this.tileControl.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileControl.AppearanceItem.Normal.Options.UseBorderColor = true;
            this.tileControl.AppearanceItem.Normal.Options.UseForeColor = true;
            this.tileControl.AppearanceItem.Pressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(69)))), ((int)(((byte)(148)))));
            this.tileControl.AppearanceItem.Pressed.Options.UseBackColor = true;
            this.tileControl.AppearanceItem.Selected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(81)))), ((int)(((byte)(165)))));
            this.tileControl.AppearanceItem.Selected.BorderColor = System.Drawing.Color.Transparent;
            this.tileControl.AppearanceItem.Selected.ForeColor = System.Drawing.Color.White;
            this.tileControl.AppearanceItem.Selected.Options.UseBackColor = true;
            this.tileControl.AppearanceItem.Selected.Options.UseBorderColor = true;
            this.tileControl.AppearanceItem.Selected.Options.UseForeColor = true;
            this.tileControl.DragSize = new System.Drawing.Size(0, 0);
            this.tileControl.Groups.Add(this.tileGroup);
            this.tileControl.HorizontalContentAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.tileControl.IndentBetweenItems = 10;
            this.tileControl.ItemPadding = new System.Windows.Forms.Padding(7, 7, 7, 4);
            this.tileControl.ItemSize = 60;
            this.tileControl.Location = new System.Drawing.Point(40, 0);
            this.tileControl.Margin = new System.Windows.Forms.Padding(0);
            this.tileControl.MaxId = 8;
            this.tileControl.MaximumSize = new System.Drawing.Size(100, 0);
            this.tileControl.MinimumSize = new System.Drawing.Size(100, 0);
            this.tileControl.Name = "tileControl";
            this.tileControl.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tileControl.Padding = new System.Windows.Forms.Padding(0);
            this.tileControl.SelectedItem = this.tileItemAll;
            this.tileControl.Size = new System.Drawing.Size(100, 580);
            this.tileControl.TabIndex = 26;
            this.tileControl.Text = "tileControl";
            this.tileControl.VerticalContentAlignment = DevExpress.Utils.VertAlignment.Top;
            this.tileControl.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileControl_ItemClick);
            // 
            // tileGroup
            // 
            this.tileGroup.Items.Add(this.tileItemAll);
            this.tileGroup.Items.Add(this.tileItemTelevisions);
            this.tileGroup.Items.Add(this.tileItemMonitors);
            this.tileGroup.Items.Add(this.tileItemVideoPlayers);
            this.tileGroup.Items.Add(this.tileItemProjectors);
            this.tileGroup.Items.Add(this.tileItemAutomation);
            this.tileGroup.Name = "tileGroup";
            this.tileGroup.Text = null;
            // 
            // tileItemAll
            // 
            tileItemElement1.Appearance.Normal.FontSizeDelta = 128;
            tileItemElement1.Appearance.Normal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            tileItemElement1.Appearance.Normal.Options.UseFont = true;
            tileItemElement1.Appearance.Normal.Options.UseForeColor = true;
            tileItemElement1.Appearance.Selected.FontSizeDelta = 128;
            tileItemElement1.Appearance.Selected.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(168)))), ((int)(((byte)(209)))));
            tileItemElement1.Appearance.Selected.Options.UseFont = true;
            tileItemElement1.Appearance.Selected.Options.UseForeColor = true;
            tileItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopRight;
            tileItemElement1.TextLocation = new System.Drawing.Point(-2, -12);
            tileItemElement2.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopLeft;
            tileItemElement2.Text = "All";
            tileItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomLeft;
            this.tileItemAll.Elements.Add(tileItemElement1);
            this.tileItemAll.Elements.Add(tileItemElement2);
            this.tileItemAll.Id = 7;
            this.tileItemAll.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.tileItemAll.Name = "tileItemAll";
            this.tileItemAll.Tag = "!= null";
            // 
            // tileItemTelevisions
            // 
            tileItemElement3.Appearance.Normal.FontSizeDelta = 128;
            tileItemElement3.Appearance.Normal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            tileItemElement3.Appearance.Normal.Options.UseFont = true;
            tileItemElement3.Appearance.Normal.Options.UseForeColor = true;
            tileItemElement3.Appearance.Selected.FontSizeDelta = 128;
            tileItemElement3.Appearance.Selected.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(168)))), ((int)(((byte)(209)))));
            tileItemElement3.Appearance.Selected.Options.UseFont = true;
            tileItemElement3.Appearance.Selected.Options.UseForeColor = true;
            tileItemElement3.Text = "183";
            tileItemElement3.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopRight;
            tileItemElement3.TextLocation = new System.Drawing.Point(-2, -12);
            tileItemElement4.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopLeft;
            tileItemElement4.Text = "TVs";
            tileItemElement4.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomLeft;
            this.tileItemTelevisions.Elements.Add(tileItemElement3);
            this.tileItemTelevisions.Elements.Add(tileItemElement4);
            this.tileItemTelevisions.Id = 0;
            this.tileItemTelevisions.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.tileItemTelevisions.Name = "tileItemTelevisions";
            this.tileItemTelevisions.Tag = "Televisions";
            // 
            // tileItemMonitors
            // 
            tileItemElement5.Appearance.Normal.FontSizeDelta = 128;
            tileItemElement5.Appearance.Normal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            tileItemElement5.Appearance.Normal.Options.UseFont = true;
            tileItemElement5.Appearance.Normal.Options.UseForeColor = true;
            tileItemElement5.Appearance.Selected.FontSizeDelta = 128;
            tileItemElement5.Appearance.Selected.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(168)))), ((int)(((byte)(209)))));
            tileItemElement5.Appearance.Selected.Options.UseFont = true;
            tileItemElement5.Appearance.Selected.Options.UseForeColor = true;
            tileItemElement5.Text = "5";
            tileItemElement5.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopRight;
            tileItemElement5.TextLocation = new System.Drawing.Point(-2, -12);
            tileItemElement6.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopLeft;
            tileItemElement6.Text = "Monitors";
            tileItemElement6.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomLeft;
            this.tileItemMonitors.Elements.Add(tileItemElement5);
            this.tileItemMonitors.Elements.Add(tileItemElement6);
            this.tileItemMonitors.Id = 1;
            this.tileItemMonitors.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.tileItemMonitors.Name = "tileItemMonitors";
            this.tileItemMonitors.Tag = "Monitors";
            // 
            // tileItemVideoPlayers
            // 
            tileItemElement7.Appearance.Normal.FontSizeDelta = 128;
            tileItemElement7.Appearance.Normal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            tileItemElement7.Appearance.Normal.Options.UseFont = true;
            tileItemElement7.Appearance.Normal.Options.UseForeColor = true;
            tileItemElement7.Appearance.Selected.FontSizeDelta = 128;
            tileItemElement7.Appearance.Selected.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(168)))), ((int)(((byte)(209)))));
            tileItemElement7.Appearance.Selected.Options.UseFont = true;
            tileItemElement7.Appearance.Selected.Options.UseForeColor = true;
            tileItemElement7.Text = "5";
            tileItemElement7.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopRight;
            tileItemElement7.TextLocation = new System.Drawing.Point(-2, -12);
            tileItemElement8.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopLeft;
            tileItemElement8.Text = "Video Players";
            tileItemElement8.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomLeft;
            this.tileItemVideoPlayers.Elements.Add(tileItemElement7);
            this.tileItemVideoPlayers.Elements.Add(tileItemElement8);
            this.tileItemVideoPlayers.Id = 2;
            this.tileItemVideoPlayers.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.tileItemVideoPlayers.Name = "tileItemVideoPlayers";
            this.tileItemVideoPlayers.Tag = "VideoPlayers";
            // 
            // tileItemProjectors
            // 
            tileItemElement9.Appearance.Normal.FontSizeDelta = 128;
            tileItemElement9.Appearance.Normal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            tileItemElement9.Appearance.Normal.Options.UseFont = true;
            tileItemElement9.Appearance.Normal.Options.UseForeColor = true;
            tileItemElement9.Appearance.Selected.FontSizeDelta = 128;
            tileItemElement9.Appearance.Selected.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(168)))), ((int)(((byte)(209)))));
            tileItemElement9.Appearance.Selected.Options.UseFont = true;
            tileItemElement9.Appearance.Selected.Options.UseForeColor = true;
            tileItemElement9.Text = "5";
            tileItemElement9.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopRight;
            tileItemElement9.TextLocation = new System.Drawing.Point(-2, -12);
            tileItemElement10.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopLeft;
            tileItemElement10.Text = "Projectors";
            tileItemElement10.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomLeft;
            this.tileItemProjectors.Elements.Add(tileItemElement9);
            this.tileItemProjectors.Elements.Add(tileItemElement10);
            this.tileItemProjectors.Id = 3;
            this.tileItemProjectors.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.tileItemProjectors.Name = "tileItemProjectors";
            this.tileItemProjectors.Tag = "Projectors";
            // 
            // tileItemAutomation
            // 
            tileItemElement11.Appearance.Normal.FontSizeDelta = 128;
            tileItemElement11.Appearance.Normal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            tileItemElement11.Appearance.Normal.Options.UseFont = true;
            tileItemElement11.Appearance.Normal.Options.UseForeColor = true;
            tileItemElement11.Appearance.Selected.FontSizeDelta = 128;
            tileItemElement11.Appearance.Selected.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(168)))), ((int)(((byte)(209)))));
            tileItemElement11.Appearance.Selected.Options.UseFont = true;
            tileItemElement11.Appearance.Selected.Options.UseForeColor = true;
            tileItemElement11.Text = "5";
            tileItemElement11.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopRight;
            tileItemElement11.TextLocation = new System.Drawing.Point(-2, -12);
            tileItemElement12.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopLeft;
            tileItemElement12.Text = "Automation";
            tileItemElement12.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomLeft;
            this.tileItemAutomation.Elements.Add(tileItemElement11);
            this.tileItemAutomation.Elements.Add(tileItemElement12);
            this.tileItemAutomation.Id = 4;
            this.tileItemAutomation.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.tileItemAutomation.Name = "tileItemAutomation";
            this.tileItemAutomation.Tag = "Automation";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "Root";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.tileControlLCI,
            this.hideButton,
            this.layoutControlItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(40, 40, 0, 0);
            this.layoutControlGroup1.Size = new System.Drawing.Size(1104, 582);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // tileControlLCI
            // 
            this.tileControlLCI.BestFitWeight = 60;
            this.tileControlLCI.Control = this.tileControl;
            this.tileControlLCI.CustomizationFormText = "tileControlLCI";
            this.tileControlLCI.Location = new System.Drawing.Point(0, 0);
            this.tileControlLCI.Name = "tileControlLCI";
            this.tileControlLCI.OptionsPrint.AllowPrint = false;
            this.tileControlLCI.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 2, 0, 2);
            this.tileControlLCI.Size = new System.Drawing.Size(102, 582);
            this.tileControlLCI.TextSize = new System.Drawing.Size(0, 0);
            this.tileControlLCI.TextVisible = false;
            // 
            // hideButton
            // 
            this.hideButton.AllowHotTrack = false;
            this.hideButton.CustomizationFormText = " ";
            this.hideButton.Image = ((System.Drawing.Image)(resources.GetObject("hideButton.Image")));
            this.hideButton.Location = new System.Drawing.Point(102, 0);
            this.hideButton.MaxSize = new System.Drawing.Size(28, 0);
            this.hideButton.MinSize = new System.Drawing.Size(28, 1);
            this.hideButton.Name = "hideButton";
            this.hideButton.Size = new System.Drawing.Size(28, 582);
            this.hideButton.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.hideButton.Text = " ";
            this.hideButton.TextSize = new System.Drawing.Size(34, 25);
            this.hideButton.Click += new System.EventHandler(this.hideButton_Click);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.BestFitWeight = 800;
            this.layoutControlItem1.Control = this.portalWebBrowser;
            this.layoutControlItem1.ControlAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.layoutControlItem1.Location = new System.Drawing.Point(130, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(894, 582);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // Portal
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "Portal";
            this.Size = new System.Drawing.Size(1104, 582);
            ((System.ComponentModel.ISupportInitialize)(this.productsSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.collapseButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileControlLCI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hideButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private XtraLayout.LayoutControl layoutControl1;
        private XtraLayout.LayoutControlGroup layoutControlGroup1;
        private System.Windows.Forms.BindingSource productsSource;
        private XtraEditors.TileControl tileControl;
        private XtraEditors.TileGroup tileGroup;
        private XtraEditors.TileItem tileItemTelevisions;
        private XtraEditors.TileItem tileItemMonitors;
        private XtraEditors.TileItem tileItemVideoPlayers;
        private XtraEditors.TileItem tileItemProjectors;
        private XtraEditors.TileItem tileItemAutomation;
        private XtraLayout.LayoutControlItem tileControlLCI;
        private XtraLayout.SimpleLabelItem collapseButton;
        private XtraLayout.SimpleLabelItem hideButton;
        private XtraLayout.SimpleLabelItem simpleLabelItem2;
        private XtraEditors.TileItem tileItemAll;
        private XtraLayout.LayoutControlItem layoutControlItem1;
        private System.Windows.Forms.WebBrowser portalWebBrowser;
        //private XtraEditors.TileItemElement tileItemElement1;
        //private XtraEditors.TileItemElement tileItemElement2;
        //private XtraEditors.TileItemElement tileItemElement3;
        //private XtraEditors.TileItemElement tileItemElement4;
        // private XtraEditors.TileItemElement tileItemElement5;
        // private XtraEditors.TileItemElement tileItemElement6;
        // private XtraEditors.TileItemElement tileItemElement7;
        // private XtraEditors.TileItemElement tileItemElement8;
        // private XtraEditors.TileItemElement tileItemElement9;
        // private XtraEditors.TileItemElement tileItemElement10;
        // private XtraEditors.TileItemElement tileItemElement11;
        // private XtraEditors.TileItemElement tileItemElement12;

    }
}
