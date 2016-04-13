using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.Utils.Design;
using DevExpress.Utils.Menu;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Controls;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting;
using DevExpress.XtraRichEdit;

namespace DevExpress.DevAV.Controls.Messages
{
    public class BaseControl : XtraUserControl
    {
        public BaseControl()
        {
            if (!DesignTimeTools.IsDesignMode)
                LookAndFeel.ActiveLookAndFeel.StyleChanged += new EventHandler(ActiveLookAndFeel_StyleChanged);
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (!DesignTimeTools.IsDesignMode)
                LookAndFeelStyleChanged();
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing && !DesignTimeTools.IsDesignMode)
                LookAndFeel.ActiveLookAndFeel.StyleChanged -= new EventHandler(ActiveLookAndFeel_StyleChanged);
            base.Dispose(disposing);
        }
        void ActiveLookAndFeel_StyleChanged(object sender, EventArgs e)
        {
            LookAndFeelStyleChanged();
        }
        protected virtual void LookAndFeelStyleChanged() { }
    }

    public class BaseModule : BaseControl
    {
        protected string partName = string.Empty;
        //internal frmMain OwnerForm { get { return this.FindForm() as frmMain; } }
        public BaseModule() { }
        internal virtual void ShowModule(bool firstShow)
        {
            //frmMain owner = OwnerForm;
            //if (owner == null) return;
            //owner.SaveAsMenuItem.Enabled = SaveAsEnable;
            //owner.SaveAttachmentMenuItem.Enabled = SaveAttachmentEnable;
            //owner.SaveCalendar.Visible = SaveCalendarVisible;
            //owner.EnableLayoutButtons(true);
            //ShowReminder();
            //ShowInfo();
            //owner.ZoomManager.ZoomFactor = (int)(ZoomFactor * 100);
            //SetZoomCaption();
            //owner.EnableZoomControl(AllowZoomControl);
        }
        internal virtual void FocusObject(object obj) { }
        //protected virtual void ShowReminder()
        //{
        //    if (OwnerForm != null)
        //        OwnerForm.ShowReminder(null);
        //}
        //internal void ShowInfo()
        //{
        //    if (OwnerForm == null) return;
        //    if (Grid == null)
        //    {
        //        OwnerForm.ShowInfo(null);
        //        return;
        //    }
        //    ICollection list = Grid.DataSource as ICollection;
        //    if (list == null)
        //        OwnerForm.ShowInfo(null);
        //    else OwnerForm.ShowInfo(list.Count);
        //}
        internal virtual void HideModule() { }
        internal virtual void InitModule(IDXMenuManager manager, object data)
        {
            SetMenuManager(this.Controls, manager);
            if (Grid != null && Grid.MainView is ColumnView)
            {
                ((ColumnView)Grid.MainView).ColumnFilterChanged += new EventHandler(BaseModule_ColumnFilterChanged);
            }
        }
        internal void ShowInfo(ColumnView view)
        {
            //if (OwnerForm == null) return;
            //ShowReminder();
            //OwnerForm.ShowInfo(view.DataRowCount);
        }
        void BaseModule_ColumnFilterChanged(object sender, EventArgs e)
        {
            ShowInfo(sender as ColumnView);
        }
        void SetMenuManager(ControlCollection controlCollection, IDXMenuManager manager)
        {
            foreach (Control ctrl in controlCollection)
            {
                GridControl grid = ctrl as GridControl;
                if (grid != null)
                {
                    grid.MenuManager = manager;
                    break;
                }
                BaseEdit edit = ctrl as BaseEdit;
                if (edit != null)
                {
                    edit.MenuManager = manager;
                    break;
                }
                SetMenuManager(ctrl.Controls, manager);
            }
        }
        protected virtual bool AllowZoomControl { get { return false; } }
        protected virtual void SetZoomCaption() { }
        public virtual float ZoomFactor
        {
            get { return 1; }
            set { }
        }
        public virtual IPrintable PrintableComponent { get { return Grid; } }
        public virtual IPrintable ExportComponent { get { return Grid; } }
        protected virtual GridControl Grid { get { return null; } }
        protected virtual bool SaveAsEnable { get { return false; } }
        protected virtual bool SaveAttachmentEnable { get { return false; } }
        protected virtual bool SaveCalendarVisible { get { return false; } }
        protected internal virtual void ButtonClick(string tag) { }
        protected internal virtual void MessagesDataChanged(DataSourceChangedEventArgs args) { }
        protected internal virtual void SendKeyDown(KeyEventArgs e) { }
        protected internal virtual RichEditControl CurrentRichEdit { get { return null; } }
        public virtual string ModuleName { get { return this.GetType().Name; } }
        public string PartName { get { return partName; } }
    }

    public class FindControlManager : IDisposable
    {
        RibbonControl ribbon;
        FindControl fControl;
        public FindControlManager(RibbonControl ribbon, FindControl control)
        {
            this.ribbon = ribbon;
            this.fControl = control;
            AddFindControlEvents();
        }
        void AddFindControlEvents()
        {
            fControl.FindButton.GotFocus += new EventHandler(FindControl_GotFocus);
            fControl.FindEdit.GotFocus += new EventHandler(FindControl_GotFocus);
            fControl.ClearButton.GotFocus += new EventHandler(FindControl_GotFocus);
            fControl.FindButton.Leave += new EventHandler(FindControl_Leave);
            fControl.FindEdit.Leave += new EventHandler(FindControl_Leave);
            fControl.ClearButton.Leave += new EventHandler(FindControl_Leave);
            //fControl.FindButton.Image = global::DevExpress.MailClient.Win.Properties.Resources.Search;
            //fControl.ClearButton.Image = global::DevExpress.MailClient.Win.Properties.Resources.Delete_16x16;
            fControl.FindButton.TabStop = false;
            fControl.ClearButton.TabStop = false;
            fControl.CalcButtonsBestFit();
        }
        void FindControl_Leave(object sender, EventArgs e)
        {
            fControl.BeginInvoke(new MethodInvoker(UpdateSearchTools));
        }
        void FindControl_GotFocus(object sender, EventArgs e)
        {
            UpdateSearchTools();
        }
        void UpdateSearchTools()
        {
            if (fControl.FindButton.Focused ||
                fControl.FindEdit.ContainsFocus ||
                fControl.ClearButton.Focused)
            {
                //ribbon.PageCategories[TagResources.SearchTools].Visible = true;
                //ribbon.SelectedPage = ribbon.PageCategories[TagResources.SearchTools].Pages[0];
            }
            else {
                //ribbon.PageCategories[TagResources.SearchTools].Visible = false;
                //ribbon.SelectedPage = ribbon.DefaultPageCategory.Pages[0];
            }
        }

        #region IDisposable Members
        public void Dispose()
        {
            fControl.FindButton.GotFocus -= new EventHandler(FindControl_GotFocus);
            fControl.FindEdit.GotFocus -= new EventHandler(FindControl_GotFocus);
            fControl.ClearButton.GotFocus -= new EventHandler(FindControl_GotFocus);
            fControl.FindButton.Leave -= new EventHandler(FindControl_Leave);
            fControl.FindEdit.Leave -= new EventHandler(FindControl_Leave);
            fControl.ClearButton.Leave -= new EventHandler(FindControl_Leave);
        }
        #endregion
    }
    public class FilterColumnsManager
    {
        List<BarButtonItem> items;
        GridView view;
        bool lockUpdate = false;
        public FilterColumnsManager(List<BarButtonItem> items)
        {
            this.items = items;
            foreach (BarButtonItem item in items)
                item.DownChanged += new ItemClickEventHandler(item_DownChanged);
        }
        BarButtonItem GetItemByName(string name)
        {
            foreach (BarButtonItem item in items)
                if (item.Tag.Equals(name)) return item;
            return null;
        }
        public void SetDefault()
        {
            lockUpdate = true;
            foreach (BarButtonItem item in items)
                if (item.CanDown)
                    item.Down = false;
            GetItemByName(TagResources.SubjectColumn).Down = true;
            GetItemByName(TagResources.PersonColumn).Down = true;
            lockUpdate = false;
            Update();
        }
        void Update()
        {
            string filterColumns = string.Empty;
            if (GetItemByName(TagResources.SubjectColumn).Down) filterColumns += "Subject;";
            if (GetItemByName(TagResources.PersonColumn).Down) filterColumns += "From;";
            if (GetItemByName(TagResources.DateColumn).Down) filterColumns += "Date;";
            if (GetItemByName(TagResources.PriorityColumn).Down) filterColumns += "Priority;";
            if (GetItemByName(TagResources.AttachmentColumn).Down) filterColumns += "Attachment;";
            view.OptionsFind.FindFilterColumns = filterColumns;
        }
        void item_DownChanged(object sender, ItemClickEventArgs e)
        {
            if (lockUpdate) return;
            Update();
        }
        public void InitGridView(DevExpress.XtraGrid.Views.Grid.GridView gridView)
        {
            if (view != null) return;
            view = gridView;
            SetDefault();
        }
        internal void UpdateColumnsCaption(string date, string person)
        {
            GetItemByName(TagResources.PersonColumn).Caption = person;
            GetItemByName(TagResources.DateColumn).Caption = date;
            GetItemByName(TagResources.DateFilterMenu).Caption = date;
        }
    }

    public class FilterCriteriaManager
    {
        GridView view;
        List<FilterCriteriaItem> itemList;
        BarButtonItem clearFilterItem;
        public FilterCriteriaManager(GridView view)
        {
            this.view = view;
            itemList = new List<FilterCriteriaItem>();
            view.ColumnFilterChanged += new EventHandler(view_ColumnFilterChanged);
        }
        public GridView View { get { return view; } }
        void view_ColumnFilterChanged(object sender, EventArgs e)
        {
            UpdateFilterInfo();
        }
        void UpdateFilterInfo()
        {
            foreach (FilterCriteriaItem item in itemList)
                item.UpdateDown();
            if (clearFilterItem != null)
                clearFilterItem.Enabled = !view.ActiveFilter.IsEmpty;
        }
        public void AddBarItem(BarButtonItem item, GridColumn column, string filterCriteria)
        {
            itemList.Add(new FilterCriteriaItem(this, item, column, filterCriteria));
        }
        public void AddClearFilterButton(BarButtonItem item)
        {
            clearFilterItem = item;
            UpdateFilterInfo();
        }
        internal string GetFilterCriteriaByColumn(GridColumn column)
        {
            string ret = string.Empty;
            foreach (FilterCriteriaItem item in itemList)
                if (item.Checked && item.IsColumnEquals(column))
                    ret = AddCriteria(ret, item.FilterCriteria);
            return ret;
        }

        string AddCriteria(string ret, string filterCriteria)
        {
            if (!string.IsNullOrEmpty(ret))
                ret = string.Format("{0} Or {1}", ret, filterCriteria);
            else ret = filterCriteria;
            return ret;
        }
    }
    public class FilterCriteriaItem
    {
        BarButtonItem item;
        string filterCriteria;
        GridColumn column;
        FilterCriteriaManager owner;
        public FilterCriteriaItem(FilterCriteriaManager owner, BarButtonItem item, GridColumn column, string filterCriteria)
        {
            this.item = item;
            this.column = column;
            this.filterCriteria = filterCriteria;
            this.owner = owner;
            item.ButtonStyle = BarButtonStyle.Check;
            item.ItemClick += new ItemClickEventHandler(item_ItemClick);
        }
        GridView View { get { return owner.View; } }
        public bool Checked { get { return item.Down; } }
        internal string FilterCriteria { get { return filterCriteria; } }
        internal bool IsColumnEquals(GridColumn column)
        {
            return this.column.Equals(column);
        }
        void item_ItemClick(object sender, ItemClickEventArgs e)
        {
            UpdateFilterCriteria(column);
        }
        void UpdateFilterCriteria(GridColumn column)
        {
            string filterCriteria = owner.GetFilterCriteriaByColumn(column);
            if (string.IsNullOrEmpty(filterCriteria)) View.ActiveFilter.Remove(column);
            else
                View.ActiveFilter.Add(column, new ColumnFilterInfo(filterCriteria));
        }
        internal void UpdateDown()
        {
            item.Down = View.ActiveFilterString.IndexOf(filterCriteria) >= 0;
        }
    }

    public class DateFilterMenu : PopupMenu
    {
        GridView view;
        FilterCriteriaManager filterManager;
        public DateFilterMenu(BarManager manager, GridView view, FilterCriteriaManager filterManager)
            : base(manager)
        {
            this.view = view;
            this.filterManager = filterManager;
            CreateBarItem("IsToday", "IsOutlookIntervalToday([Date])");
            CreateBarItem("IsYesterday", "IsOutlookIntervalYesterday([Date])");
            CreateBarItem("IsEarlierThisWeek", "IsOutlookIntervalEarlierThisWeek([Date])");
            CreateBarItem("IsLastWeek", "IsOutlookIntervalLastWeek([Date])");
            CreateBarItem("IsEarlierThisMonth", "IsOutlookIntervalEarlierThisMonth([Date])");
            CreateBarItem("IsEarlierThisYear", "IsOutlookIntervalEarlierThisYear([Date])");
        }
        void CreateBarItem(string caption, string filterString)
        {
            BarButtonItem item = new BarButtonItem(this.Manager, caption);
            item.Tag = filterString;
            item.CloseSubMenuOnClick = false;
            ItemLinks.Add(item);
            filterManager.AddBarItem(item, view.Columns["Date"], filterString);
        }
    }

    public class PriorityMenu : PopupMenu
    {
        GridView view;
        BarButtonItem lowPriority, mediumPriority, highPriority;
        public PriorityMenu(BarManager manager, GridView view, Image lowGlyph, Image highGlyph)
            : base(manager)
        {
            this.view = view;
            lowPriority = new BarButtonItem(manager, "Low");
            lowPriority.Glyph = lowGlyph;
            mediumPriority = new BarButtonItem(manager, "Medium");
            highPriority = new BarButtonItem(manager, "High");
            highPriority.Glyph = highGlyph;
            ItemLinks.AddRange(new BarItem[] { lowPriority, mediumPriority, highPriority });
            lowPriority.ItemClick += new ItemClickEventHandler(lowPriority_ItemClick);
            mediumPriority.ItemClick += new ItemClickEventHandler(mediumPriority_ItemClick);
            highPriority.ItemClick += new ItemClickEventHandler(highPriority_ItemClick);
            lowPriority.ButtonStyle = BarButtonStyle.Check;
            mediumPriority.ButtonStyle = BarButtonStyle.Check;
            highPriority.ButtonStyle = BarButtonStyle.Check;
        }
        protected override void OnBeforePopup(CancelEventArgs e)
        {
            base.OnBeforePopup(e);
            int priority = -1;
            foreach (int row in view.GetSelectedRows())
            {
                if (row >= 0)
                {
                    DevExpress.DevAV.Controls.Messages.Helpers.Message message = view.GetRow(row) as DevExpress.DevAV.Controls.Messages.Helpers.Message;
                    if (priority == -1)
                        priority = message.Priority;
                    if (priority != message.Priority)
                    {
                        priority = -1;
                        break;
                    }
                }
            }
            lowPriority.Down = priority == 0;
            mediumPriority.Down = priority == 1;
            highPriority.Down = priority == 2;
        }
        void SetPriority(int value)
        {
            foreach (int row in view.GetSelectedRows())
                if (row >= 0)
                    ((DevExpress.DevAV.Controls.Messages.Helpers.Message)view.GetRow(row)).Priority = value;
            view.LayoutChanged();
            view.MakeRowVisible(view.FocusedRowHandle);
        }
        void highPriority_ItemClick(object sender, ItemClickEventArgs e) { SetPriority(2); }
        void mediumPriority_ItemClick(object sender, ItemClickEventArgs e) { SetPriority(1); }
        void lowPriority_ItemClick(object sender, ItemClickEventArgs e) { SetPriority(0); }
    }

    public class TagResources
    {
        public const string RotateLayout = "RotateLayout";
        public const string FlipLayout = "FlipLayout";
        public const string DeleteItem = "DeleteItem";
        public const string NewMail = "NewMail";
        public const string Reply = "Reply";
        public const string ReplyAll = "ReplyAll";
        public const string Forward = "Forward";
        public const string UnreadRead = "Unread/Read";
        public const string SearchTools = "Search Tools";
        public const string CloseSearch = "CloseSearch";
        public const string ClearFilter = "ClearFilter";
        public const string SubjectColumn = "Subject";
        public const string PersonColumn = "Person";
        public const string DateColumn = "Date";
        public const string PriorityColumn = "Priority";
        public const string AttachmentColumn = "Attachment";
        public const string ResetColumnsToDefault = "ResetColumns";
        public const string DateFilterMenu = "DateFilterMenu";
        public const string ContactList = "List";
        public const string ContactAlphabetical = "Alphabetical";
        public const string ContactByState = "ByState";
        public const string ContactCard = "Card";
        public const string OpenCalendar = "OpenCalendar";
        public const string MenuSaveAs = "SaveAs";
        public const string MenuSaveAttachment = "SaveAttachment";
        public const string MenuSaveCalendar = "SaveCalendar";
        public const string FeedNew = "NewFeed";
        public const string FeedEdit = "EditFeed";
        public const string FeedDelete = "DeleteFeed";
        public const string FeedRefresh = "RefreshFeed";
        public const string TaskList = "TaskList";
        public const string TaskToDoList = "TaskToDoList";
        public const string TaskPrioritized = "TaskPrioritized";
        public const string TaskCompleted = "TaskCompleted";
        public const string TaskToday = "TaskToday";
        public const string TaskOverdue = "TaskOverdue";
        public const string TaskSimpleList = "TaskSimpleList";
        public const string TaskDeferred = "TaskDeferred";
        public const string ContactNew = "NewContact";
        public const string ContactEdit = "EditContact";
        public const string ContactDelete = "DeleteContact";
        public const string TaskNew = "NewTask";
        public const string TaskEdit = "EditTask";
        public const string TaskDelete = "DeleteTask";
        public const string Preview = "ShowPreview";
    }
}