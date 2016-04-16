using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.DevAV.ViewModels;
using DevExpress.DevAV.Helpers;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout.Utils;
using DevExpress.DevAV.Common.Utils;

namespace DevExpress.DevAV.Modules {
    public partial class Opportunities : BaseModuleControl {
        public Opportunities()
            : base(CreateViewModel<QuoteCollectionViewModel>) {
            InitializeComponent();
            InitializeData();
            //rangeControl.RangeChanged += new DevExpress.XtraEditors.RangeChangedEventHandler(rangeControl_RangeChanged);
            MakeGridVisible();
        }
        private void rangeControl_RangeChanged(object sender, RangeControlRangeEventArgs range) {
            //DateTime min, max;
            //min = (DateTime)range.Range.Minimum;
            //max = (DateTime)range.Range.Maximum;
            //ViewModel.FilterExpression = e => e.Date > min && e.Date < max;
            //opportunitiesBindingSource.SetItemsSource(ViewModel.Entities);
            //if (chartControl.Series.Count == 0) {
            //    return;
            //}
            //chartControl.DataSource = ViewModel.GetQuoteInfos();
            //if (ViewModel.Entities.Count > 0) {
            //    opportunitiesMapView1.Quote = ViewModel;
            //}
        }

        private void InitializeData() {
            //opportunitiesBindingSource.SetItemsSource(ViewModel.Entities);
            //if (ViewModel.Entities.Count > 0) {
            //    opportunitiesMapView1.Quote = ViewModel;
            //}
            //chartControl.DataSource = ViewModel.GetQuoteInfos();
            //chartControl.Series[0].ArgumentDataMember = "StageName";
            //chartControl.Series[0].ValueDataMembers.AddRange(new string[] { "Summary" });
            //dateTimeChartRangeControlClient1.DataProvider.DataSource = CreateViewModel<QuoteCollectionViewModel>().Entities.ToBindingList();
            //dateTimeChartRangeControlClient1.DataProvider.ValueDataMember = "Total";
            //dateTimeChartRangeControlClient1.DataProvider.ArgumentDataMember = "Date";
        }
        public QuoteCollectionViewModel ViewModel {
            get {
                return GetViewModel<QuoteCollectionViewModel>();
            }
        }
        protected internal override void OnTransitionCompleted() {
            base.OnTransitionCompleted();
            InitializeButtonPanel();
        }
        private void InitializeButtonPanel() {
            var listBI = new List<ButtonInfo>();
            listBI.Add(new ButtonInfo() { Type = typeof(SimpleButton), Text = "Refresh", Name = "1", Image = Properties.Resources.Refresh, mouseEventHandler = refreshPage });
            listBI.Add(new ButtonInfo());
            listBI.Add(new ButtonInfo() { Type = typeof(SimpleButton), Text = "LifeStyle", Name = "1", Image = Properties.Resources.lifestyle, mouseEventHandler = openLifeStyle });
            listBI.Add(new ButtonInfo() { Type = typeof(SimpleButton), Text = "Tehnic", Name = "1", Image = Properties.Resources.tehnic, mouseEventHandler = openTehnic });
            listBI.Add(new ButtonInfo());
            listBI.Add(new ButtonInfo() { Type = typeof(SimpleButton), Text = "Back", Name = "2", Image = Properties.Resources.ArrowLeft, mouseEventHandler = goToPreviousPage });
            listBI.Add(new ButtonInfo() { Type = typeof(SimpleButton), Text = "Next", Name = "3", Image = Properties.Resources.ArrowRight, mouseEventHandler = goToNextPage });
            listBI.Add(new ButtonInfo());
            listBI.Add(new ButtonInfo() { Type = typeof(SimpleButton), Text = "Open in browser", Name = "6", Image = Properties.Resources.browseropen, mouseEventHandler = openInBrowser });
            BottomPanel.InitializeButtons(listBI, false);
        }

        void refreshPage(object sender, EventArgs e)
        {
            shareWeb.Refresh();
        }

        void goToNextPage(object sender, EventArgs e)
        {
            shareWeb.GoForward();
        }

        void goToPreviousPage(object sender, EventArgs e)
        {
            shareWeb.GoBack();
        }

        void openLifeStyle(object sender, EventArgs e)
        {
            shareWeb.Source = new Uri("http://netvm-89:33526/sites/Lifestyle/SitePages/Categories.aspx/");
        }

        void openTehnic(object sender, EventArgs e)
        {
            shareWeb.Source = new Uri("http://netvm-89:33526/sites/Technic/SitePages/Categories.aspx");
        }


        void openInBrowser(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(shareWeb.Source.AbsoluteUri);
        }


        public void MakeMapVisible() {
            //pivotGridControl.Visible = false;
            //opportunitiesMapView1.Visible = true;

            ///pivotGridLCI.Visibility = XtraLayout.Utils.LayoutVisibility.Never;
        }
        public void MakeGridVisible() {
            //pivotGridControl.Visible = true;
            //opportunitiesMapView1.Visible = false;
        }
        private void pivotGridControl1_CustomCellValue(object sender, XtraPivotGrid.PivotCellValueEventArgs e) {
            //if (e.DataField == fieldPercentage) {
            //    e.Value = Convert.ToDouble(e.Value) * 100;
            //}
        }
        private void buttonHide_Click(object sender, EventArgs e) {
            //if (chartControlLCI.Visibility == XtraLayout.Utils.LayoutVisibility.Always) {
            //    ItemsHideHelper.HideCore(new object[] { chartControlLCI }, buttonHide, true);
            //    return;
            //}
            //if (chartControlLCI.Visibility == XtraLayout.Utils.LayoutVisibility.Never) {
            //    ItemsHideHelper.ExpandCore(new object[] { chartControlLCI }, buttonHide, true);
            //    return;
            //}
        }

        private void chartControl_CustomDrawSeriesPoint(object sender, XtraCharts.CustomDrawSeriesPointEventArgs e) {
            ChartControlLegendCustomPainter.Paint(e);
        }

        private void opportunities_Load(object sender, EventArgs e) {
        }
    }
}
