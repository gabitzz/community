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
            this.salesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.mail1 = new DevExpress.MailClient.Win.Mail();
            this.sendReceiveProgress = new DevExpress.XtraEditors.MarqueeProgressBarControl();
            this.ucMailTree1 = new DevExpress.DevAV.Controls.Messages.ucMailTree();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.buttonHide = new DevExpress.XtraLayout.SimpleLabelItem();
            this.layoutControlSendReceive = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sendReceiveProgress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonHide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlSendReceive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // salesBindingSource
            // 
            this.salesBindingSource.DataSource = typeof(DevExpress.DevAV.Order);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.mail1);
            this.layoutControl1.Controls.Add(this.sendReceiveProgress);
            this.layoutControl1.Controls.Add(this.ucMailTree1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(747, 158, 690, 527);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(968, 598);
            this.layoutControl1.TabIndex = 19;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // mail1
            // 
            this.mail1.Location = new System.Drawing.Point(210, 24);
            this.mail1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mail1.Name = "mail1";
            this.mail1.Size = new System.Drawing.Size(734, 528);
            this.mail1.TabIndex = 23;
            this.mail1.ZoomFactor = 1F;
            // 
            // sendReceiveProgress
            // 
            this.sendReceiveProgress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sendReceiveProgress.EditValue = "Send/Receive";
            this.sendReceiveProgress.Location = new System.Drawing.Point(741, 566);
            this.sendReceiveProgress.Margin = new System.Windows.Forms.Padding(0);
            this.sendReceiveProgress.MinimumSize = new System.Drawing.Size(0, 22);
            this.sendReceiveProgress.Name = "sendReceiveProgress";
            this.sendReceiveProgress.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.sendReceiveProgress.Properties.MarqueeAnimationSpeed = 150;
            this.sendReceiveProgress.Properties.ShowTitle = true;
            this.sendReceiveProgress.Properties.Stopped = true;
            this.sendReceiveProgress.Size = new System.Drawing.Size(217, 22);
            this.sendReceiveProgress.StyleController = this.layoutControl1;
            this.sendReceiveProgress.TabIndex = 20;
            // 
            // ucMailTree1
            // 
            this.ucMailTree1.Location = new System.Drawing.Point(24, 24);
            this.ucMailTree1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucMailTree1.Name = "ucMailTree1";
            this.ucMailTree1.Size = new System.Drawing.Size(120, 528);
            this.ucMailTree1.TabIndex = 19;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem1,
            this.layoutControlGroup2,
            this.layoutControlGroup3,
            this.buttonHide,
            this.layoutControlSendReceive,
            this.emptySpaceItem2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(968, 598);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(176, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(10, 556);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup2.Location = new System.Drawing.Point(186, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(762, 556);
            this.layoutControlGroup2.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.mail1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(738, 532);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem5});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(148, 556);
            this.layoutControlGroup3.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.ucMailTree1;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(124, 532);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // buttonHide
            // 
            this.buttonHide.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.buttonHide.AllowHotTrack = false;
            this.buttonHide.Image = global::DevExpress.DevAV.Properties.Resources.ArrowLeft;
            this.buttonHide.Location = new System.Drawing.Point(148, 0);
            this.buttonHide.MaxSize = new System.Drawing.Size(28, 0);
            this.buttonHide.MinSize = new System.Drawing.Size(28, 1);
            this.buttonHide.Name = "buttonHide";
            this.buttonHide.Size = new System.Drawing.Size(28, 556);
            this.buttonHide.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.buttonHide.Text = " ";
            this.buttonHide.TextSize = new System.Drawing.Size(34, 25);
            this.buttonHide.Click += new System.EventHandler(this.buttonHide_Click);
            // 
            // layoutControlSendReceive
            // 
            this.layoutControlSendReceive.Control = this.sendReceiveProgress;
            this.layoutControlSendReceive.Location = new System.Drawing.Point(731, 556);
            this.layoutControlSendReceive.Name = "layoutControlSendReceive";
            this.layoutControlSendReceive.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlSendReceive.Size = new System.Drawing.Size(217, 22);
            this.layoutControlSendReceive.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlSendReceive.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 556);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(731, 22);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // Messages
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.Controls.Add(this.layoutControl1);
            this.Name = "Messages";
            this.Size = new System.Drawing.Size(968, 598);
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sendReceiveProgress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonHide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlSendReceive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource salesBindingSource;
        private XtraLayout.LayoutControl layoutControl1;
        private XtraLayout.LayoutControlGroup layoutControlGroup1;
        private XtraLayout.EmptySpaceItem emptySpaceItem1;
        private Controls.Messages.ucMailTree ucMailTree1;
        private XtraLayout.LayoutControlItem layoutControlItem5;
        private XtraLayout.LayoutControlGroup layoutControlGroup2;
        private XtraLayout.LayoutControlGroup layoutControlGroup3;
        private XtraLayout.SimpleLabelItem buttonHide;
        private XtraEditors.MarqueeProgressBarControl sendReceiveProgress;
        private XtraLayout.LayoutControlItem layoutControlSendReceive;
        private XtraLayout.EmptySpaceItem emptySpaceItem2;
        private MailClient.Win.Mail mail1;
        private XtraLayout.LayoutControlItem layoutControlItem1;
    }
}
