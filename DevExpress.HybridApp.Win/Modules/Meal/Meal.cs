using System;
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
using System.Threading.Tasks;
using DevExpress.XtraLayout;
using DevExpress.XtraCharts;
using System.Drawing;

namespace DevExpress.DevAV.Modules
{
    public partial class Meal : BaseModuleControl
    {
        private List<MenuItemViewModel> _menuItemsViewModel;
        //BaseItemCollection hideItemCollection = new BaseItemCollection();
        TileBar productTileBar;
        public List<MenuItemViewModel> MenuItemsViewModel
        {
            get { return _menuItemsViewModel; }
            set { _menuItemsViewModel = value; }
        }

        public Meal()
            : base(CreateViewModel<ProductCollectionViewModel>) {
            _menuItemsViewModel = new List<MenuItemViewModel>();
            InitializeComponent();
            //LoadData();

            //((ITileControl)tileControl).Properties.LargeItemWidth = 200;
            //UpdateTileAndItems();
            ////viewProducts.DataController.Refreshed += DataController_Refreshed;
            //ItemsHideHelper.Hide(hideItemCollection, hideButton);
            //pins = new List<PinnedItem>();
        }
        bool lockRefreshed = false;
        void DataController_Refreshed(object sender, EventArgs e)
        {
            if (!lockRefreshed)
            {
                lockRefreshed = true;
                //UpdateTileFilter(tileItemAll);
                //UpdateTileFilter(tileItemAutomation);
                //UpdateTileFilter(tileItemMonitors);
                //UpdateTileFilter(tileItemProjectors);
                //UpdateTileFilter(tileItemTelevisions);
                //UpdateTileFilter(tileItemVideoPlayers);
                //UpdateTileFilter(tileControl.SelectedItem);
                lockRefreshed = false;
            }
        }

        void UpdateTileAndItems()
        {
            //tileItemAll.Text = ViewModel.AllCount.ToString();
            //tileItemAutomation.Text = ViewModel.AutomationCount.ToString();
            //tileItemMonitors.Text = ViewModel.MonitorsCount.ToString();
            //tileItemProjectors.Text = ViewModel.ProjectorsCount.ToString();
            //tileItemTelevisions.Text = ViewModel.TelevisionsCount.ToString();
            //tileItemVideoPlayers.Text = ViewModel.VideoPlayersCount.ToString();
            //hideItemCollection.Clear();
            //hideItemCollection.AddRange(new XtraLayout.BaseLayoutItem[] { tileControlLCI });

        }
        protected override void OnParentChanged(System.EventArgs e)
        {
            base.OnParentChanged(e);
            if (Parent != null)
            {
                SubscribeTileBarProductsFilter();
            }
            else
            {
                if (productTileBar != null) productTileBar.ItemClick -= ProductTileBar_ItemClick;
                //if(searchControl != null)searchControl.QueryIsSearchColumn -= searchControl_AllowSearchColumn;
            }
        }
        protected internal override void OnTransitionCompleted()
        {
            base.OnTransitionCompleted();
            InitializeButtonPanel();
            LoadData();
            BottomPanel.Visible = false;
        }

        void SubscribeTileBarProductsFilter()
        {
            if (ProductTileBar == null) return;
            productTileBar = ProductTileBar;
            productTileBar.Text = "FAV PINS";
            productTileBar.ItemClick += ProductTileBar_ItemClick;
            productTileBar.Groups[0].Items.Clear();  //TEMPORARY CODE UNTIL ALL PREVIOUS DATA IS REMOVED FROM DESIGNER ;)
        }

        void ProductTileBar_ItemClick(object sender, TileItemEventArgs e)
        {
            lockRefreshed = true;
            //if (e.Item.Tag is PinnedItem)
            //{
            //    portalWebBrowser.Navigate(((PinnedItem)e.Item.Tag).URL);
            //    currentPin = (PinnedItem)e.Item.Tag;
            //}


            lockRefreshed = false;
        }

        bool SetFilterString(string filterString)
        {
            //viewProducts.ActiveFilter.Clear();
            try
            {
                // viewProducts.ActiveFilterCriteria = CriteriaOperator.TryParse(filterString);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void SetCustomFilter(string temp, ProductCategory category)
        {
            //viewProducts.ActiveFilter.Clear();
            // viewProducts.ActiveFilter.Add(viewProducts.Columns["Name"], new ColumnFilterInfo(CriteriaOperator.Parse(String.Format("Name like '%{0}%'", temp))));
            //viewProducts.ActiveFilter.Add(viewProducts.Columns["Category"], new ColumnFilterInfo(CriteriaOperator.Parse("Category == ?", category)));
        }
        public ProductCollectionViewModel ViewModel
        {
            get
            {
                return GetViewModel<ProductCollectionViewModel>();
            }
        }
        void LoadData()
        {
            try
            {
                //productsSource.SetItemsSource(ViewModel.Entities);

                Task<List<ProviderMenuItem>> task = Task.Run(() => WebApiHelper.GetAllProducts());
                task.Wait();

                var list = task.Result;
                if (list == null) return;
                ChartControl[] chartsControl = { chartControl2, chartControl1, chartControl5, chartControl6, chartControl3, chartControl4 };
                string paletteName = "paletteName";
                PaletteEntry entry1 = new PaletteEntry(Color.Red, Color.Green);
                Palette palette = new Palette(paletteName, new PaletteEntry[] { entry1 });
                for (int i = 0; i < list.Count; i++)
                {
                    var item = list[i];
                    //LayoutControlItem item2 = layoutControl2.Root.AddItem();
                    // Set the item's Control and caption.
                    //item2.Name = item.Code ?? string.Empty;
                    //Control label = new LabelControl();
                    //label.Name = string.Format("label{0}", item.Code);
                    //label.Text = item.Name;
                    //item2.Control = label;
                    //item2.Text = item.Code;

                    // Create a doughnut series.
                    Series series1 = new Series("Doughnut Series 1", ViewType.Doughnut);
                    series1.Label.TextPattern = "{V}";
                    // Populate the series with points.
                    var likeSeriesPoint = new SeriesPoint("Like", item.LikeCount);
                    var dislikeSeriesPoint = new SeriesPoint("Dislike", item.DislikeCount);
                    likeSeriesPoint.Color = Color.Green;
                    dislikeSeriesPoint.Color = Color.Red;
                    series1.Points.Add(likeSeriesPoint);
                    series1.Points.Add(dislikeSeriesPoint);

                    // Add the series to the chart.
                    if (i < chartsControl.Length)
                    {
                        chartsControl[i].Titles.Clear();
                        var title = new ChartTitle();
                        title.Text = string.Format("{0}-{1}", item.Code.ToUpper(), item.Name);
                        title.Font = new Font(FontFamily.GenericSansSerif, 18.0F, FontStyle.Bold);
                        chartsControl[i].Titles.Add(title);
                        chartsControl[i].Series.Clear();
                        chartsControl[i].Series.Add(series1);
                    }


                }
            }
            catch (Exception)
            {
            }
            //XmlSerializer serializer = new XmlSerializer(typeof(List<PinnedItem>));
            //if (File.Exists(Path.Combine(Constants.BASE_DATA_PATH, "Pins.xml")))
            //{
            //    using (Stream stream = File.Open(serializationFile, FileMode.Open))
            //    {

            //        pins = (List<PinnedItem>)serializer.Deserialize(stream);

            //    }

            //    if (pins != null)
            //    {
            //        foreach (PinnedItem pin in pins)
            //        {
            //            TileBarItem newTileBarItem = new TileBarItem() { TextAlignment = TileItemContentAlignment.MiddleCenter, Text = pin.Name, Tag = pin };
            //            ProductTileBar.Groups[0].Items.Add(newTileBarItem);
            //            pin.TileBarItem = newTileBarItem;
            //        }

            //        if (pins.Count > 0)
            //        {
            //            currentPin = pins[0];
            //            portalWebBrowser.Navigate(currentPin.URL);
            //        }

            //    }
            //}
        }


        void gridView1_CustomUnboundColumnData(object sender, XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            //if(e.Column.ColumnEdit is RepositoryItemSparklineEdit) {
            //    var product = (Product)e.Row;
            //    var cached = cachedSales[product];
            //    if(cached == null) {
            //        cached = cachedSales[product] = ShapeUnboundDataForSparkline(ViewModel.GetMonthlySalesByProduct(product));
            //    }
            //    e.Value = cached;
            //}
        }
        void InitializeButtonPanel()
        {

            //listBI = new List<ButtonInfo>();
            //listBI.Add(new ButtonInfo() { Type = typeof(SimpleButton), Text = "Refresh", Name = "1", Image = Properties.Resources.Refresh, mouseEventHandler = refreshPage });
            //listBI.Add(new ButtonInfo());
            //listBI.Add(new ButtonInfo() { Type = typeof(SimpleButton), Text = "Back", Name = "2", Image = Properties.Resources.ArrowLeft, mouseEventHandler = goToPreviousPage });
            //listBI.Add(new ButtonInfo() { Type = typeof(SimpleButton), Text = "Next", Name = "3", Image = Properties.Resources.ArrowRight, mouseEventHandler = goToNextPage });
            //listBI.Add(new ButtonInfo());
            //pinBtn = new ButtonInfo() { Type = typeof(SimpleButton), Text = "Pin", Name = "4", Image = Properties.Resources.pin, mouseEventHandler = pinFavPage };
            //listBI.Add(pinBtn);
            //unpinBtn = new ButtonInfo() { Type = typeof(SimpleButton), Text = "Unpin", Name = "5", Image = Properties.Resources.unpin, mouseEventHandler = unpinFavPage };
            //listBI.Add(unpinBtn);
            //listBI.Add(new ButtonInfo());
            //listBI.Add(new ButtonInfo() { Type = typeof(SimpleButton), Text = "Open in browser", Name = "6", Image = Properties.Resources.browseropen, mouseEventHandler = openInBrowser });
            //BottomPanel.InitializeButtons(listBI, false);

        }

        private void pinFavPage(object sender, EventArgs e)
        {
            //FavItem newFavItem = new FavItem();
            //DialogResult result = FlyoutDialog.Show(FindForm(), newFavItem);
            //if (result == DialogResult.OK)
            //{
            //    PinnedItem newPin = new PinnedItem(newFavItem.textEdit1.Text, portalWebBrowser.Url.AbsoluteUri);
            //    pins.Add(newPin);
            //    TileBarItem newTileBarItem = new TileBarItem() { TextAlignment = TileItemContentAlignment.MiddleCenter, Text = newFavItem.textEdit1.Text, Tag = newPin };
            //    ProductTileBar.Groups[0].Items.Add(newTileBarItem);
            //    newPin.TileBarItem = newTileBarItem;
            //    updatePinButtons(portalWebBrowser.Url.AbsoluteUri);
            //    currentPin = newPin;
            //}


        }



        private void customFilterClick(object sender, EventArgs e)
        {
            PortalCustomFilterModule customFilter = new PortalCustomFilterModule(ViewModel.Entities.ToBindingList());
            DialogResult result = FlyoutDialog.Show(FindForm(), customFilter);
            if (result == DialogResult.OK)
            {
                if (customFilter.checkEdit.Checked)
                {
                    if (SetFilterString(customFilter.filterControl.FilterString))
                        ProductTileBar.Groups[0].Items.Add(new TileBarItem() { TextAlignment = TileItemContentAlignment.MiddleCenter, Text = customFilter.textEdit.Text, Tag = customFilter.filterControl.FilterString });
                }
                else
                {
                    SetFilterString(customFilter.filterControl.FilterString);
                }

            }
        }

        void refreshPage(object sender, EventArgs e)
        {
            //portalWebBrowser.Refresh();
        }

        void goToNextPage(object sender, EventArgs e)
        {
            //portalWebBrowser.GoForward();
        }

        void goToPreviousPage(object sender, EventArgs e)
        {
            //portalWebBrowser.GoBack();
        }


        void openInBrowser(object sender, EventArgs e)
        {
            //System.Diagnostics.Process.Start(portalWebBrowser.Url.AbsoluteUri);
        }

        void editProduct(object sender, EventArgs e)
        {
            ShowEditModuleForFocusedRow();
        }
        void newProduct(object sender, EventArgs e)
        {
            ShowEditModule(null);
            UpdateTileAndItems();
        }
        void ShowEditModuleForFocusedRow()
        {
            //var product = viewProducts.GetFocusedRow() as Product;
            // if(product == null) return;
            // ShowEditModule(product);
        }
        void viewProducts_RowClick(object sender, XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (e.Clicks > 1 && e.RowHandle >= 0)
            {
                ShowEditModuleForFocusedRow();
            }
        }

        void ShowEditModule(Product productToEdit)
        {
            var main = GetParentViewModel<MainViewModel>();
            main.SelectModule(ModuleType.PortalEditableView, (x) => {
                if (productToEdit != null)
                {
                    ViewModelHelper.EnsureModuleViewModel(main.SelectedModule, GetParentViewModel<MainViewModel>(), productToEdit.Id);
                }
                else
                {
                    ViewModelHelper.EnsureModuleViewModel(main.SelectedModule, GetParentViewModel<MainViewModel>(), new DefaultEntityInitializer<Product, DevAV.DevAVDbDataModel.IDevAVDbUnitOfWork>());
                }
                ((BaseModuleControl)main.SelectedModule).Refresh();
            });
        }


        void UpdateTileFilter(TileItem tileItem)
        {

        }
        private void tileControl_ItemClick(object sender, TileItemEventArgs e)
        {
            UpdateTileFilter(e.Item);
        }
        
        protected override void OnDisposing()
        {

        }

        private void chartControl4_Click(object sender, EventArgs e)
        {

        }

    }
}
