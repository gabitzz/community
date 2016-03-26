using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.XtraEditors;
using DevExpress.XtraBars.Docking2010.Views.WindowsUI;
using DevExpress.DevAV.ViewModels;
using System.IO;
using DevExpress.DevAV.Helpers;
using DevExpress.DevAV;
using DevExpress.XtraLayout.Utils;

namespace DevExpress.DevAV.Modules {
    public partial class PortalEditableView : BaseModuleControl, ISupportNavigation {
        public PortalEditableView()
            : base(CreateViewModel<ProductViewModel>) {
            InitializeComponent();
            cbCategory.Properties.Items.AddEnum<ProductCategory>();
        }
        protected override void Return() {
            GetParentViewModel<MainViewModel>().SelectModule(ModuleType.Portal);
        }
        private void lciBackPicture_Click(object sender, EventArgs e) {
            if(CheckSave()) Return();
        }
        public ProductViewModel ViewModel {
            get {
                return GetViewModel<ProductViewModel>();
            }
        }
        public override void Refresh() {
            if (ViewModel.Entity != null) {
                UpdateNameLabelVisibility(ViewModel.IsNew());
                productBindingSource.DataSource = ViewModel.Entity;
                cbProductEngineer.Properties.DataSource = ViewModel.GetEmployees().ToList();
                cbSupport.Properties.DataSource = ViewModel.GetEmployees().ToList();
                LoadPdf(ViewModel.Entity.Brochure);
            }
            base.Refresh();
        }
        void UpdateNameLabelVisibility(bool isNew) {
            lcEditProductName.Visibility = isNew ? LayoutVisibility.Always : LayoutVisibility.Never;
            lcLabelProductName1.Visibility = isNew ? LayoutVisibility.Never : LayoutVisibility.Always;
            lcLabelProductName2.Visibility = isNew ? LayoutVisibility.Never : LayoutVisibility.Always;
            ViewModel.Entity.ProductionStart = isNew ? DateTime.Now : ViewModel.Entity.ProductionStart;
        }
        protected internal override void OnTransitionCompleted() {
            base.OnTransitionCompleted();
            InitializeButtonPanel();
        }
        private void InitializeButtonPanel() {
            var listBI = new List<ButtonInfo>();
            listBI.Add(new ButtonInfo() { Type = typeof(SimpleButton), Text = "Save", Name = "5", Image = ImageHelper.GetImageFromToolbarResource("Save"), mouseEventHandler = (e, s) => {
                Save();
            } });
            listBI.Add(new ButtonInfo() { Type = typeof(SimpleButton), Text = "Cancel", Name = "3", Image = ImageHelper.GetImageFromToolbarResource("Cancel"), mouseEventHandler = (e, s) => {
                Cancel();
            } });
            listBI.Add(new ButtonInfo());
            listBI.Add(new ButtonInfo() { Type = typeof(SimpleButton), Text = "Zoom In", Name = "1", Image = ImageHelper.GetImageFromToolbarResource("ZoomIn"), mouseEventHandler = zoomInClick });
            listBI.Add(new ButtonInfo() { Type = typeof(SimpleButton), Text = "Zoom Out", Name = "2", Image = ImageHelper.GetImageFromToolbarResource("ZoomOut"), mouseEventHandler = zoomOutClick });

            if(BottomPanel != null) BottomPanel.InitializeButtons(listBI, false);
        }
        void zoomOutClick(object sender, EventArgs e) {
            pdfViewer.ZoomFactor -= 10f;
        }
        private void zoomInClick(object sender, EventArgs e) {
            pdfViewer.ZoomFactor += 10f;
        }



        private void LoadPdf(Stream stream) {
            if (stream == null) {
                return;
            }
            pdfViewer.LoadDocument(stream);
        }
        public void OnNavigatedFrom(INavigationArgs args) {
        }

        public void OnNavigatedTo(INavigationArgs args) {
        }
    }
}
