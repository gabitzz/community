namespace DevExpress.DevAV.Modules {
    partial class Opportunities {
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
            DevExpress.XtraEditors.AreaChartRangeControlClientView areaChartRangeControlClientView1 = new DevExpress.XtraEditors.AreaChartRangeControlClientView();
            this.dateTimeChartRangeControlClient1 = new DevExpress.XtraEditors.DateTimeChartRangeControlClient();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.shareWeb = new Awesomium.Windows.Forms.WebControl(this.components);
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.opportunitiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shareWebControl = new Awesomium.Windows.Forms.WebControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeChartRangeControlClient1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.opportunitiesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimeChartRangeControlClient1
            // 
            areaChartRangeControlClientView1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(194)))), ((int)(((byte)(224)))));
            this.dateTimeChartRangeControlClient1.DataProvider.TemplateView = areaChartRangeControlClientView1;
            this.dateTimeChartRangeControlClient1.GridOptions.Auto = false;
            this.dateTimeChartRangeControlClient1.GridOptions.GridAlignment = DevExpress.XtraEditors.RangeControlDateTimeGridAlignment.Month;
            this.dateTimeChartRangeControlClient1.GridOptions.GridSpacing = 2D;
            this.dateTimeChartRangeControlClient1.GridOptions.SnapAlignment = DevExpress.XtraEditors.RangeControlDateTimeGridAlignment.Month;
            this.dateTimeChartRangeControlClient1.GridOptions.SnapSpacing = 2D;
            this.dateTimeChartRangeControlClient1.PaletteName = "NatureColors";
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.AllowCustomization = false;
            this.dataLayoutControl1.Controls.Add(this.shareWeb);
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 0);
            this.dataLayoutControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(-1359, 205, 938, 715);
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(1142, 624);
            this.dataLayoutControl1.TabIndex = 0;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // shareWeb
            // 
            this.shareWeb.Location = new System.Drawing.Point(42, 2);
            this.shareWeb.Size = new System.Drawing.Size(1058, 600);
            this.shareWeb.Source = new System.Uri("http://netvm-89:33526/sites/Community", System.UriKind.Absolute);
            this.shareWeb.TabIndex = 4;
            this.shareWeb.ViewType = Awesomium.Core.WebViewType.Offscreen;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.CustomizationFormText = "Root";
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(40, 40, 0, 20);
            this.layoutControlGroup1.Size = new System.Drawing.Size(1142, 624);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.shareWeb;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1062, 604);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // shareWebControl
            // 
            this.shareWebControl.Location = new System.Drawing.Point(173, 2);
            this.shareWebControl.Size = new System.Drawing.Size(927, 600);
            this.shareWebControl.TabIndex = 4;
            this.shareWebControl.Visible = false;
            // 
            // Opportunities
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataLayoutControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Opportunities";
            this.Size = new System.Drawing.Size(1142, 624);
            this.Load += new System.EventHandler(this.opportunities_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeChartRangeControlClient1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.opportunitiesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private XtraLayout.LayoutControlGroup layoutControlGroup1;
        private System.Windows.Forms.BindingSource opportunitiesBindingSource;
        private XtraEditors.DateTimeChartRangeControlClient dateTimeChartRangeControlClient1;
        private Awesomium.Windows.Forms.WebControl shareWebControl;
        private Awesomium.Windows.Forms.WebControl shareWeb;
        private XtraLayout.LayoutControlItem layoutControlItem1;
    }
}
