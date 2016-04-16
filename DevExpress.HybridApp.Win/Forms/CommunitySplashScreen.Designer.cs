namespace DevExpress.DevAV.Forms
{
    partial class CommunitySplashScreen
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.marqueeProgressBarControl1 = new DevExpress.XtraEditors.MarqueeProgressBarControl();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.lblLoading = new System.Windows.Forms.Label();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.marqueeProgressBarControl1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // marqueeProgressBarControl1
            // 
            this.marqueeProgressBarControl1.EditValue = 0;
            this.marqueeProgressBarControl1.Location = new System.Drawing.Point(17, 254);
            this.marqueeProgressBarControl1.Name = "marqueeProgressBarControl1";
            this.marqueeProgressBarControl1.Properties.LookAndFeel.SkinName = "Visual Studio 2013 Light";
            this.marqueeProgressBarControl1.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.marqueeProgressBarControl1.Properties.StartColor = System.Drawing.Color.CornflowerBlue;
            this.marqueeProgressBarControl1.Size = new System.Drawing.Size(411, 18);
            this.marqueeProgressBarControl1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(17, 279);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Powered by SilentBusters©";
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = global::DevExpress.DevAV.Properties.Resources.communityLogo2;
            this.pictureEdit1.Location = new System.Drawing.Point(17, 13);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(196)))));
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Size = new System.Drawing.Size(411, 205);
            this.pictureEdit1.TabIndex = 2;
            // 
            // lblLoading
            // 
            this.lblLoading.AutoSize = true;
            this.lblLoading.BackColor = System.Drawing.Color.Transparent;
            this.lblLoading.Location = new System.Drawing.Point(20, 235);
            this.lblLoading.Name = "lblLoading";
            this.lblLoading.Size = new System.Drawing.Size(45, 13);
            this.lblLoading.TabIndex = 3;
            this.lblLoading.Text = "Loading";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(196)))));
            this.labelControl1.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(115)))), ((int)(((byte)(196)))));
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.PaleGoldenrod;
            this.labelControl1.Location = new System.Drawing.Point(145, 190);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(160, 20);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "We are the community";
            // 
            // CommunitySplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 320);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.lblLoading);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.marqueeProgressBarControl1);
            this.Name = "CommunitySplashScreen";
            ((System.ComponentModel.ISupportInitialize)(this.marqueeProgressBarControl1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLoading;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.MarqueeProgressBarControl marqueeProgressBarControl1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
    }
}
