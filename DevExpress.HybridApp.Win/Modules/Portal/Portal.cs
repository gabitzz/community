﻿using System;
using System.Linq;
using System.Collections.Generic;
using DevExpress.DevAV.Helpers;
using DevExpress.DevAV.ViewModels;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.DevAV;
using DevExpress.XtraLayout.Utils;
using DevExpress.XtraGrid.Columns;
using System.Collections;
using DevExpress.DevAV.Common.ViewModel;
using DevExpress.XtraGrid;
using DevExpress.Data.Filtering;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraBars.Docking2010.Customization;
using System.Windows.Forms;
using DevExpress.DevAV.Forms;
using System.IO;
using System.Xml.Serialization;

namespace DevExpress.DevAV.Modules {
    public enum ProductCustomFilter {
        HDVideoPlayer,
        Plasma,
        Monitor,
        RemoteControl,
        CdPlayer
    }


    public partial class Portal : BaseModuleControl {
        BaseItemCollection hideItemCollection = new BaseItemCollection();
        TileBar productTileBar;
        string currentFilter = null;
        private List<PinnedItem> pins;

        private PinnedItem currentPin;

        private List<ButtonInfo> listBI;
        private ButtonInfo pinBtn;
        private ButtonInfo unpinBtn;
        

        public Portal()
            : base(CreateViewModel<ProductCollectionViewModel>) {
            InitializeComponent();
            ((ITileControl)tileControl).Properties.LargeItemWidth = 200;
            UpdateTileAndItems();
            //viewProducts.DataController.Refreshed += DataController_Refreshed;
            ItemsHideHelper.Hide(hideItemCollection, hideButton);
            pins = new List<PinnedItem>();
        }
        bool lockRefreshed = false;
        void DataController_Refreshed(object sender, EventArgs e) {
            if(!lockRefreshed) {
                lockRefreshed = true;
                UpdateTileFilter(tileItemAll);
                UpdateTileFilter(tileItemAutomation);
                UpdateTileFilter(tileItemMonitors);
                UpdateTileFilter(tileItemProjectors);
                UpdateTileFilter(tileItemTelevisions);
                UpdateTileFilter(tileItemVideoPlayers);
                UpdateTileFilter(tileControl.SelectedItem);
                lockRefreshed = false;
            }
        }

        void UpdateTileAndItems() {
            tileItemAll.Text = ViewModel.AllCount.ToString();
            tileItemAutomation.Text = ViewModel.AutomationCount.ToString();
            tileItemMonitors.Text = ViewModel.MonitorsCount.ToString();
            tileItemProjectors.Text = ViewModel.ProjectorsCount.ToString();
            tileItemTelevisions.Text = ViewModel.TelevisionsCount.ToString();
            tileItemVideoPlayers.Text = ViewModel.VideoPlayersCount.ToString();
            hideItemCollection.Clear();
            hideItemCollection.AddRange(new XtraLayout.BaseLayoutItem[] { tileControlLCI });

        }
        protected override void OnParentChanged(System.EventArgs e) {
            base.OnParentChanged(e);
            if(Parent != null) {
                SubscribeTileBarProductsFilter();
            } else {
                if(productTileBar != null) productTileBar.ItemClick -= ProductTileBar_ItemClick;
                //if(searchControl != null)searchControl.QueryIsSearchColumn -= searchControl_AllowSearchColumn;
            }
        }
        protected internal override void OnTransitionCompleted() {
            base.OnTransitionCompleted();
            InitializeButtonPanel();
            LoadData();
        }

        void SubscribeTileBarProductsFilter() {
            if(ProductTileBar == null) return;
            productTileBar = ProductTileBar;
            productTileBar.Text = "FAV PINS";
            productTileBar.ItemClick += ProductTileBar_ItemClick;
            productTileBar.Groups[0].Items.Clear();  //TEMPORARY CODE UNTIL ALL PREVIOUS DATA IS REMOVED FROM DESIGNER ;)
        }

        void ProductTileBar_ItemClick(object sender, TileItemEventArgs e) {
            lockRefreshed = true;
            if (e.Item.Tag is PinnedItem)
            {
                portalWebBrowser.Navigate(((PinnedItem)e.Item.Tag).URL);
                currentPin = (PinnedItem) e.Item.Tag;
            }

   
            lockRefreshed = false;
        }

        bool SetFilterString(string filterString) {
            //viewProducts.ActiveFilter.Clear();
            try {
               // viewProducts.ActiveFilterCriteria = CriteriaOperator.TryParse(filterString);
                return true;
            } catch {
                return false;
            }
        }

        private void SetCustomFilter(string temp, ProductCategory category) {
            //viewProducts.ActiveFilter.Clear();
           // viewProducts.ActiveFilter.Add(viewProducts.Columns["Name"], new ColumnFilterInfo(CriteriaOperator.Parse(String.Format("Name like '%{0}%'", temp))));
            //viewProducts.ActiveFilter.Add(viewProducts.Columns["Category"], new ColumnFilterInfo(CriteriaOperator.Parse("Category == ?", category)));
        }
        public ProductCollectionViewModel ViewModel {
            get {
                return GetViewModel<ProductCollectionViewModel>();
            }
        }
        void LoadData() {
            //productsSource.SetItemsSource(ViewModel.Entities);

            string serializationFile = Path.Combine(Constants.BASE_DATA_PATH, "Pins.xml");

            XmlSerializer serializer = new XmlSerializer(typeof(List<PinnedItem>));
            if (File.Exists(Path.Combine(Constants.BASE_DATA_PATH, "Pins.xml")))
            {
                using (Stream stream = File.Open(serializationFile, FileMode.Open))
                {

                    pins = (List<PinnedItem>)serializer.Deserialize(stream);

                }

                if (pins != null)
                {
                    foreach (PinnedItem pin in pins)
                    {
                        TileBarItem newTileBarItem = new TileBarItem() { TextAlignment = TileItemContentAlignment.MiddleCenter, Text = pin.Name, Tag = pin };
                        ProductTileBar.Groups[0].Items.Add(newTileBarItem);
                        pin.TileBarItem = newTileBarItem;
                    }

                    if (pins.Count > 0) {
                        currentPin = pins[0];
                        portalWebBrowser.Navigate(currentPin.URL);
                    }

                }
            }
        }


        void gridView1_CustomUnboundColumnData(object sender, XtraGrid.Views.Base.CustomColumnDataEventArgs e) {
            //if(e.Column.ColumnEdit is RepositoryItemSparklineEdit) {
            //    var product = (Product)e.Row;
            //    var cached = cachedSales[product];
            //    if(cached == null) {
            //        cached = cachedSales[product] = ShapeUnboundDataForSparkline(ViewModel.GetMonthlySalesByProduct(product));
            //    }
            //    e.Value = cached;
            //}
        }
        void InitializeButtonPanel() {
           
            listBI = new List<ButtonInfo>();
            listBI.Add(new ButtonInfo() { Type = typeof(SimpleButton), Text = "Refresh", Name = "1", Image = Properties.Resources.Refresh, mouseEventHandler = refreshPage});
            listBI.Add(new ButtonInfo());
            listBI.Add(new ButtonInfo() { Type = typeof(SimpleButton), Text = "Back", Name = "2", Image= Properties.Resources.ArrowLeft, mouseEventHandler = goToPreviousPage });         
            listBI.Add(new ButtonInfo() { Type = typeof(SimpleButton), Text = "Next", Name = "3", Image = Properties.Resources.ArrowRight, mouseEventHandler = goToNextPage });
            listBI.Add(new ButtonInfo());
            pinBtn = new ButtonInfo() { Type = typeof(SimpleButton), Text = "Pin", Name = "4", Image = Properties.Resources.pin, mouseEventHandler = pinFavPage };
            listBI.Add(pinBtn);
            unpinBtn = new ButtonInfo() { Type = typeof(SimpleButton), Text = "Unpin", Name = "5", Image = Properties.Resources.unpin, mouseEventHandler = unpinFavPage };
            listBI.Add(unpinBtn);
            listBI.Add(new ButtonInfo());
            listBI.Add(new ButtonInfo() { Type = typeof(SimpleButton), Text = "Open in browser", Name = "6", Image = Properties.Resources.browseropen, mouseEventHandler = openInBrowser });
            BottomPanel.InitializeButtons(listBI, false);
            
        }

        private void pinFavPage(object sender, EventArgs e)
        {
            FavItem newFavItem = new FavItem();
            DialogResult result = FlyoutDialog.Show(FindForm(), newFavItem);
            if (result == DialogResult.OK)
            {
                PinnedItem newPin = new PinnedItem(newFavItem.textEdit1.Text, portalWebBrowser.Url.AbsoluteUri);
                pins.Add(newPin);
                TileBarItem newTileBarItem = new TileBarItem() { TextAlignment = TileItemContentAlignment.MiddleCenter, Text = newFavItem.textEdit1.Text, Tag = newPin };
                ProductTileBar.Groups[0].Items.Add(newTileBarItem);
                newPin.TileBarItem = newTileBarItem;
                updatePinButtons(portalWebBrowser.Url.AbsoluteUri);
                currentPin = newPin;
            }
            

        }


        private void unpinFavPage(object sender, EventArgs e)
        {
          if (currentPin != null)
            {
                if (currentPin.TileBarItem != null)
                {
                    ProductTileBar.Groups[0].Items.Remove(currentPin.TileBarItem);
                }
                pins.Remove(currentPin);
                currentPin = null;
                updatePinButtons(portalWebBrowser.Url.AbsoluteUri);
            }
        }

       private void customFilterClick(object sender, EventArgs e) {
            PortalCustomFilterModule customFilter = new PortalCustomFilterModule(ViewModel.Entities.ToBindingList());
            DialogResult result = FlyoutDialog.Show(FindForm(), customFilter);
            if(result == DialogResult.OK) {
                if(customFilter.checkEdit.Checked) {
                    if(SetFilterString(customFilter.filterControl.FilterString))
                        ProductTileBar.Groups[0].Items.Add(new TileBarItem() { TextAlignment = TileItemContentAlignment.MiddleCenter, Text = customFilter.textEdit.Text, Tag = customFilter.filterControl.FilterString });
                } else {
                    SetFilterString(customFilter.filterControl.FilterString);
                }

            }
        }

        void refreshPage(object sender, EventArgs e)
        {
            portalWebBrowser.Refresh(); 
        }

        void goToNextPage(object sender, EventArgs e)
        {
            portalWebBrowser.GoForward();
        }

        void goToPreviousPage(object sender, EventArgs e)
        {
            portalWebBrowser.GoBack();
        }


        void openInBrowser(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(portalWebBrowser.Url.AbsoluteUri); 
        }

        void editProduct(object sender, EventArgs e) {
            ShowEditModuleForFocusedRow();
        }
        void newProduct(object sender, EventArgs e) {
            ShowEditModule(null);
            UpdateTileAndItems();
        }
        void ShowEditModuleForFocusedRow() {
            //var product = viewProducts.GetFocusedRow() as Product;
           // if(product == null) return;
           // ShowEditModule(product);
        }
        void viewProducts_RowClick(object sender, XtraGrid.Views.Grid.RowClickEventArgs e) {
            if(e.Clicks > 1 && e.RowHandle >= 0) {
                ShowEditModuleForFocusedRow();
            }
        }

        void ShowEditModule(Product productToEdit) {
            var main = GetParentViewModel<MainViewModel>();
            main.SelectModule(ModuleType.PortalEditableView, (x) => {
                if(productToEdit != null) {
                    ViewModelHelper.EnsureModuleViewModel(main.SelectedModule, GetParentViewModel<MainViewModel>(), productToEdit.Id);
                }
                else {
                    ViewModelHelper.EnsureModuleViewModel(main.SelectedModule, GetParentViewModel<MainViewModel>(), new DefaultEntityInitializer<Product, DevAV.DevAVDbDataModel.IDevAVDbUnitOfWork>());
                }
                ((BaseModuleControl)main.SelectedModule).Refresh();
            });
        }
        

        void UpdateTileFilter(TileItem tileItem) {
            string filter = (string)tileItem.Tag;
            if(filter == currentFilter) return;
            currentFilter = filter;

            ProductCategory category = ProductCategory.Automation;
            if(!Enum.TryParse<ProductCategory>(currentFilter, out category)) {
                currentFilter = null;
            }
            //viewProducts.ActiveFilter.Clear();
          //  if(currentFilter != null) viewProducts.ActiveFilter.Add(viewProducts.Columns["Category"], new ColumnFilterInfo(CriteriaOperator.Parse("Category == ?", category)));
            //tileItem.Text = viewProducts.RowCount.ToString();
        }
        private void tileControl_ItemClick(object sender, TileItemEventArgs e) {
            UpdateTileFilter(e.Item);
        }


        void hideButton_Click(object sender, EventArgs e) {
            if(tileControlLCI.Visibility == XtraLayout.Utils.LayoutVisibility.Always) {
                ItemsHideHelper.Hide(hideItemCollection, hideButton);
                //productsSLI.Padding = new XtraLayout.Utils.Padding(hideButton.Width, 2, 10, 10);

                return;
            }
            if(tileControlLCI.Visibility == XtraLayout.Utils.LayoutVisibility.Never) {
                ItemsHideHelper.Expand(hideItemCollection, hideButton);
                //productsSLI.Padding = new XtraLayout.Utils.Padding(2, 2, 10, 10);
                return;
            }
        }

        private void viewProducts_FocusedRowObjectChanged(object sender, XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e) {
            ViewModel.SelectedEntity = e.Row as Product;
        }

        private void portalWebBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            updatePinButtons(portalWebBrowser.Url.AbsoluteUri);
        }

        private void updatePinButtons(string URL)
        {
            bool isAlreadyPinned = PinExists(URL);
            pinBtn.Button.Enabled = !isAlreadyPinned;
            unpinBtn.Button.Enabled = isAlreadyPinned;
        }

        private bool PinExists (string currentURL)
        {
            currentPin = null;
            bool exists = false;
            foreach (PinnedItem pin in pins)
            {
                if (pin.URL.Equals (currentURL))
                    {
                    exists = true;
                    currentPin = pin;
                    break;
                }
            }
            return exists;
        }

    protected override void OnDisposing()
        {
            string serializationFile = Path.Combine(Constants.BASE_DATA_PATH, "Pins.xml");
            XmlSerializer serializer = new XmlSerializer(typeof(List<PinnedItem>));

            using (Stream stream = File.Open(serializationFile, FileMode.Create))
            {
                serializer.Serialize(stream, pins);
            }
        }
    }

  
}
