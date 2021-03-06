﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace DevExpress.DevAV.Reports {
    internal class EmployeeDirectory : DevExpress.XtraReports.UI.XtraReport {
        private XtraReports.UI.TopMarginBand topMarginBand1;
        private XtraReports.UI.DetailBand detailBand1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.ComponentModel.IContainer components;
        private XtraReports.UI.XRPictureBox xrPictureBox1;
        private XtraReports.UI.BottomMarginBand bottomMarginBand1;
        private XtraReports.UI.XRPageInfo xrPageInfo1;
        private XtraReports.UI.PageHeaderBand PageHeader;
        private XtraReports.UI.XRPageInfo xrPageInfo2;
        private XtraReports.UI.XRTable xrTable1;
        private XtraReports.UI.XRTableRow xrTableRow1;
        private XtraReports.UI.XRTableCell xrTableCell1;
        private XtraReports.UI.XRTableCell xrTableCell2;
        private XtraReports.UI.XRTable xrTable2;
        private XtraReports.UI.XRTableRow xrTableRow2;
        private XtraReports.UI.XRTableCell xrTableCell4;
        private XtraReports.UI.XRTableRow xrTableRow3;
        private XtraReports.UI.XRTableCell xrTableCell5;
        private XtraReports.UI.XRTableRow xrTableRow4;
        private XtraReports.UI.XRTableCell xrTableCell6;
        private XtraReports.UI.XRLine xrLine1;
        private XtraReports.UI.XRTableRow xrTableRow5;
        private XtraReports.UI.XRTableCell xrTableCell7;
        private XtraReports.UI.XRTableCell xrTableCell8;
        private XtraReports.UI.XRTableRow xrTableRow6;
        private XtraReports.UI.XRTableCell xrTableCell9;
        private XtraReports.UI.XRTableCell xrTableCell10;
        private XtraReports.UI.XRTableRow xrTableRow7;
        private XtraReports.UI.XRTableCell xrTableCell11;
        private XtraReports.UI.XRTableCell xrTableCell12;
        private XtraReports.UI.XRTableRow xrTableRow8;
        private XtraReports.UI.XRTableCell xrTableCell13;
        private XtraReports.UI.XRTableRow xrTableRow9;
        private XtraReports.UI.XRTableCell xrTableCell14;
        private XtraReports.UI.XRTableCell xrTableCell15;
        private XtraReports.UI.XRTableRow xrTableRow10;
        private XtraReports.UI.XRTableCell xrTableCell16;
        private XtraReports.UI.XRTableCell xrTableCell17;
        private XtraReports.UI.XRLabel xrLabel1;
        private XtraReports.UI.CalculatedField FirstLetter;
        private XtraReports.UI.XRTableCell xrTableCell3;

        public EmployeeDirectory() {
            InitializeComponent();
        }

        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            var resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeDirectory));
            this.topMarginBand1 = new DevExpress.XtraReports.UI.TopMarginBand();
            this.xrPictureBox1 = new DevExpress.XtraReports.UI.XRPictureBox();
            this.detailBand1 = new DevExpress.XtraReports.UI.DetailBand();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTable2 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow3 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow4 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell6 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLine1 = new DevExpress.XtraReports.UI.XRLine();
            this.xrTableRow5 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell7 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell8 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow6 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell9 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell10 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow7 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell11 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell12 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow8 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell13 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow9 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell14 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell15 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableRow10 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell16 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell17 = new DevExpress.XtraReports.UI.XRTableCell();
            this.bottomMarginBand1 = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.xrPageInfo2 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.xrPageInfo1 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
            this.FirstLetter = new DevExpress.XtraReports.UI.CalculatedField();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.topMarginBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPictureBox1 });
            this.topMarginBand1.Dpi = 96F;
            this.topMarginBand1.HeightF = 120F;
            this.topMarginBand1.Name = "topMarginBand1";
            this.xrPictureBox1.Dpi = 96F;
            this.xrPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("xrPictureBox1.Image")));
            this.xrPictureBox1.LocationFloat = new DevExpress.Utils.PointFloat(448F, 50.11383F);
            this.xrPictureBox1.Name = "xrPictureBox1";
            this.xrPictureBox1.SizeF = new System.Drawing.SizeF(167F, 54.15536F);
            this.xrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.StretchImage;
            this.detailBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel1,
            this.xrTable2 });
            this.detailBand1.Dpi = 96F;
            this.detailBand1.HeightF = 215.2001F;
            this.detailBand1.KeepTogether = true;
            this.detailBand1.Name = "detailBand1";
            this.detailBand1.SortFields.AddRange(new DevExpress.XtraReports.UI.GroupField[] {
            new DevExpress.XtraReports.UI.GroupField("LastName", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending) });
            this.xrLabel1.CanGrow = false;
            this.xrLabel1.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "FirstLetter") });
            this.xrLabel1.Dpi = 96F;
            this.xrLabel1.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 16.58599F);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrLabel1.ProcessDuplicatesMode = DevExpress.XtraReports.UI.ProcessDuplicatesMode.Merge;
            this.xrLabel1.SizeF = new System.Drawing.SizeF(53.25F, 73.39456F);
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.StylePriority.UseTextAlignment = false;
            this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.xrLabel1.WordWrap = false;
            this.xrTable2.Dpi = 96F;
            this.xrTable2.LocationFloat = new DevExpress.Utils.PointFloat(172.8822F, 16.1875F);
            this.xrTable2.Name = "xrTable2";
            this.xrTable2.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow2,
            this.xrTableRow3,
            this.xrTableRow4,
            this.xrTableRow5,
            this.xrTableRow6,
            this.xrTableRow7,
            this.xrTableRow8,
            this.xrTableRow9,
            this.xrTableRow10 });
            this.xrTable2.SizeF = new System.Drawing.SizeF(441.6458F, 169.6342F);
            this.xrTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell4 });
            this.xrTableRow2.Dpi = 96F;
            this.xrTableRow2.Name = "xrTableRow2";
            this.xrTableRow2.Weight = 0.48150076635820022D;
            this.xrTableCell4.CanGrow = false;
            this.xrTableCell4.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "FullName") });
            this.xrTableCell4.Dpi = 96F;
            this.xrTableCell4.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(178)))), ((int)(((byte)(144)))));
            this.xrTableCell4.Name = "xrTableCell4";
            this.xrTableCell4.StylePriority.UseFont = false;
            this.xrTableCell4.StylePriority.UseForeColor = false;
            this.xrTableCell4.StylePriority.UsePadding = false;
            this.xrTableCell4.StylePriority.UseTextAlignment = false;
            this.xrTableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft;
            this.xrTableCell4.Weight = 3D;
            this.xrTableRow3.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell5 });
            this.xrTableRow3.Dpi = 96F;
            this.xrTableRow3.Name = "xrTableRow3";
            this.xrTableRow3.Weight = 0.34068025346384434D;
            this.xrTableCell5.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Title") });
            this.xrTableCell5.Dpi = 96F;
            this.xrTableCell5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.xrTableCell5.Name = "xrTableCell5";
            this.xrTableCell5.StylePriority.UseFont = false;
            this.xrTableCell5.StylePriority.UseForeColor = false;
            this.xrTableCell5.StylePriority.UsePadding = false;
            this.xrTableCell5.StylePriority.UseTextAlignment = false;
            this.xrTableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.xrTableCell5.Weight = 3D;
            this.xrTableRow4.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell6 });
            this.xrTableRow4.Dpi = 96F;
            this.xrTableRow4.Name = "xrTableRow4";
            this.xrTableRow4.Weight = 0.37828530166861157D;
            this.xrTableCell6.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLine1 });
            this.xrTableCell6.Dpi = 96F;
            this.xrTableCell6.Name = "xrTableCell6";
            this.xrTableCell6.Weight = 3D;
            this.xrLine1.Dpi = 96F;
            this.xrLine1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.xrLine1.LocationFloat = new DevExpress.Utils.PointFloat(1.525879E-05F, 0F);
            this.xrLine1.Name = "xrLine1";
            this.xrLine1.SizeF = new System.Drawing.SizeF(441.6458F, 12.20348F);
            this.xrLine1.StylePriority.UseForeColor = false;
            this.xrTableRow5.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell7,
            this.xrTableCell8 });
            this.xrTableRow5.Dpi = 96F;
            this.xrTableRow5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableRow5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.xrTableRow5.Name = "xrTableRow5";
            this.xrTableRow5.StylePriority.UseFont = false;
            this.xrTableRow5.StylePriority.UseForeColor = false;
            this.xrTableRow5.Weight = 0.21567219504415658D;
            this.xrTableCell7.CanGrow = false;
            this.xrTableCell7.Dpi = 96F;
            this.xrTableCell7.Name = "xrTableCell7";
            this.xrTableCell7.StylePriority.UseBorderColor = false;
            this.xrTableCell7.StylePriority.UseForeColor = false;
            this.xrTableCell7.StylePriority.UsePadding = false;
            this.xrTableCell7.Text = "HOME ADDRESS";
            this.xrTableCell7.Weight = 1.4868341453229292D;
            this.xrTableCell8.CanGrow = false;
            this.xrTableCell8.Dpi = 96F;
            this.xrTableCell8.Name = "xrTableCell8";
            this.xrTableCell8.Text = "PHONE";
            this.xrTableCell8.Weight = 1.5131658546770708D;
            this.xrTableRow6.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell9,
            this.xrTableCell10 });
            this.xrTableRow6.Dpi = 96F;
            this.xrTableRow6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableRow6.Name = "xrTableRow6";
            this.xrTableRow6.StylePriority.UseFont = false;
            this.xrTableRow6.Weight = 0.22076846350092508D;
            this.xrTableCell9.CanGrow = false;
            this.xrTableCell9.Dpi = 96F;
            this.xrTableCell9.Multiline = true;
            this.xrTableCell9.Name = "xrTableCell9";
            this.xrTableCell9.RowSpan = 2;
            this.xrTableCell9.Text = "[Address.Line]\r\n[Address.CityLine]";
            this.xrTableCell9.Weight = 1.4868341548048936D;
            this.xrTableCell9.WordWrap = false;
            this.xrTableCell10.CanGrow = false;
            this.xrTableCell10.Dpi = 96F;
            this.xrTableCell10.Name = "xrTableCell10";
            this.xrTableCell10.StylePriority.UsePadding = false;
            this.xrTableCell10.Text = "[MobilePhone] (Mobile)";
            this.xrTableCell10.Weight = 1.5131658451951064D;
            this.xrTableCell10.WordWrap = false;
            this.xrTableRow7.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell11,
            this.xrTableCell12 });
            this.xrTableRow7.Dpi = 96F;
            this.xrTableRow7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableRow7.Name = "xrTableRow7";
            this.xrTableRow7.StylePriority.UseFont = false;
            this.xrTableRow7.Weight = 0.25449824869166587D;
            this.xrTableCell11.Dpi = 96F;
            this.xrTableCell11.Name = "xrTableCell11";
            this.xrTableCell11.Text = "xrTableCell8";
            this.xrTableCell11.Weight = 1.4868341548048936D;
            this.xrTableCell12.CanGrow = false;
            this.xrTableCell12.Dpi = 96F;
            this.xrTableCell12.Name = "xrTableCell12";
            this.xrTableCell12.Text = "[HomePhone] (Home)";
            this.xrTableCell12.Weight = 1.5131658451951064D;
            this.xrTableCell12.WordWrap = false;
            this.xrTableRow8.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell13 });
            this.xrTableRow8.Dpi = 96F;
            this.xrTableRow8.Name = "xrTableRow8";
            this.xrTableRow8.Weight = 0.12622171748791217D;
            this.xrTableCell13.Dpi = 96F;
            this.xrTableCell13.Name = "xrTableCell13";
            this.xrTableCell13.Weight = 3D;
            this.xrTableRow9.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell14,
            this.xrTableCell15 });
            this.xrTableRow9.Dpi = 96F;
            this.xrTableRow9.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableRow9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.xrTableRow9.Name = "xrTableRow9";
            this.xrTableRow9.StylePriority.UseFont = false;
            this.xrTableRow9.StylePriority.UseForeColor = false;
            this.xrTableRow9.Weight = 0.22588296444312883D;
            this.xrTableCell14.Dpi = 96F;
            this.xrTableCell14.Name = "xrTableCell14";
            this.xrTableCell14.Text = "EMAIL";
            this.xrTableCell14.Weight = 1.486834109845256D;
            this.xrTableCell15.Dpi = 96F;
            this.xrTableCell15.Name = "xrTableCell15";
            this.xrTableCell15.Text = "SKYPE";
            this.xrTableCell15.Weight = 1.513165890154744D;
            this.xrTableRow10.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell16,
            this.xrTableCell17 });
            this.xrTableRow10.Dpi = 96F;
            this.xrTableRow10.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableRow10.Name = "xrTableRow10";
            this.xrTableRow10.StylePriority.UseFont = false;
            this.xrTableRow10.Weight = 0.34098411262588169D;
            this.xrTableCell16.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Email") });
            this.xrTableCell16.Dpi = 96F;
            this.xrTableCell16.Name = "xrTableCell16";
            this.xrTableCell16.Weight = 1.4868337384779746D;
            this.xrTableCell17.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Skype") });
            this.xrTableCell17.Dpi = 96F;
            this.xrTableCell17.Name = "xrTableCell17";
            this.xrTableCell17.Weight = 1.5131662615220254D;
            this.bottomMarginBand1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPageInfo2,
            this.xrPageInfo1 });
            this.bottomMarginBand1.Dpi = 96F;
            this.bottomMarginBand1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bottomMarginBand1.HeightF = 100F;
            this.bottomMarginBand1.Name = "bottomMarginBand1";
            this.bottomMarginBand1.StylePriority.UseFont = false;
            this.xrPageInfo2.Dpi = 96F;
            this.xrPageInfo2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.xrPageInfo2.Format = "{0:MMMM d, yyyy}";
            this.xrPageInfo2.LocationFloat = new DevExpress.Utils.PointFloat(466F, 0F);
            this.xrPageInfo2.Name = "xrPageInfo2";
            this.xrPageInfo2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrPageInfo2.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
            this.xrPageInfo2.SizeF = new System.Drawing.SizeF(150F, 22.08F);
            this.xrPageInfo2.StylePriority.UseForeColor = false;
            this.xrPageInfo2.StylePriority.UseTextAlignment = false;
            this.xrPageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.xrPageInfo1.Dpi = 96F;
            this.xrPageInfo1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.xrPageInfo1.Format = "Page {0} of {1}";
            this.xrPageInfo1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrPageInfo1.Name = "xrPageInfo1";
            this.xrPageInfo1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrPageInfo1.SizeF = new System.Drawing.SizeF(150F, 22.08F);
            this.xrPageInfo1.StylePriority.UseForeColor = false;
            this.bindingSource1.DataSource = typeof(DevExpress.DevAV.Employee);
            this.PageHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable1 });
            this.PageHeader.Dpi = 96F;
            this.PageHeader.HeightF = 29.5198F;
            this.PageHeader.Name = "PageHeader";
            this.PageHeader.StylePriority.UseFont = false;
            this.xrTable1.Dpi = 96F;
            this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrTable1.Name = "xrTable1";
            this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1 });
            this.xrTable1.SizeF = new System.Drawing.SizeF(616F, 28.50856F);
            this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell1,
            this.xrTableCell2,
            this.xrTableCell3 });
            this.xrTableRow1.Dpi = 96F;
            this.xrTableRow1.Name = "xrTableRow1";
            this.xrTableRow1.Weight = 1D;
            this.xrTableCell1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(128)))), ((int)(((byte)(71)))));
            this.xrTableCell1.Dpi = 96F;
            this.xrTableCell1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xrTableCell1.ForeColor = System.Drawing.Color.White;
            this.xrTableCell1.Multiline = true;
            this.xrTableCell1.Name = "xrTableCell1";
            this.xrTableCell1.Padding = new DevExpress.XtraPrinting.PaddingInfo(8, 0, 0, 0, 96F);
            this.xrTableCell1.StylePriority.UseBackColor = false;
            this.xrTableCell1.StylePriority.UseFont = false;
            this.xrTableCell1.StylePriority.UseForeColor = false;
            this.xrTableCell1.StylePriority.UsePadding = false;
            this.xrTableCell1.StylePriority.UseTextAlignment = false;
            this.xrTableCell1.Text = "Directory";
            this.xrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.xrTableCell1.Weight = 0.7808441558441559D;
            this.xrTableCell2.Dpi = 96F;
            this.xrTableCell2.Name = "xrTableCell2";
            this.xrTableCell2.Weight = 0.043932629870129913D;
            this.xrTableCell3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.xrTableCell3.Dpi = 96F;
            this.xrTableCell3.Name = "xrTableCell3";
            this.xrTableCell3.StylePriority.UseBackColor = false;
            this.xrTableCell3.Weight = 2.1752232142857144D;
            this.FirstLetter.Expression = "Substring([LastName], 0, 1)";
            this.FirstLetter.Name = "FirstLetter";
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.topMarginBand1,
            this.detailBand1,
            this.bottomMarginBand1,
            this.PageHeader });
            this.CalculatedFields.AddRange(new DevExpress.XtraReports.UI.CalculatedField[] {
            this.FirstLetter });
            this.DataSource = this.bindingSource1;
            this.Dpi = 96F;
            this.DrawWatermark = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margins = new System.Drawing.Printing.Margins(100, 100, 120, 100);
            this.PageHeight = 1056;
            this.PageWidth = 816;
            this.ReportUnit = DevExpress.XtraReports.UI.ReportUnit.Pixels;
            this.Version = "14.1";
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
        }
    }
}
