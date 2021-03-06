﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using DevExpress.DevAV.ViewModels;
using DevExpress.XtraEditors;
using DevExpress.XtraCharts;
using DevExpress.DevAV.Common.Utils;
using DevExpress.DevAV.Controls.Messages;
using DevExpress.DevAV.Controls.Messages.Helpers;
using DevExpress.DevAV.Helpers;
using DevExpress.MailClient.Win;
using DevExpress.XtraLayout.Utils;
using OpenPop.Pop3;
using Message = DevExpress.DevAV.Controls.Messages.Helpers.Message;
using Timer = System.Windows.Forms.Timer;

namespace DevExpress.DevAV.Modules {

    public enum Periods : int {
        Month = 1,
        Today = 2,
        Year = 0
    }
    public partial class Messages : BaseModuleControl
    {

        MailType currentMailType = MailType.Inbox;

        public Messages()
            : base(CreateViewModel<OrderCollectionViewModel>)
        {
            InitializeComponent();
            InitializeData();

            MessageReceiver.Instance.DoReceiveStarted += Instance_DoReceiveStarted;
            MessageReceiver.Instance.DoReceiveEnded += Instance_DoReceiveEnded;

            var timer = new Timer {Interval = AppContext.Instance.Settings.SendReceiveTimeInterval};
            timer.Tick += Timer_Tick;
            timer.Start();

            ucMailTree1.DataSourceChanged += UcMailTree1_DataSourceChanged;
        }

        private void UcMailTree1_DataSourceChanged(object sender, DataSourceChangedEventArgs e)
        {
            currentMailType = e.Type;
            mail1.MessagesDataChanged(e);
            //ShowInfo(e.List.Count);
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            MessageReceiver.Instance.Receive();
        }

        private void Instance_DoReceiveStarted(object sender, EventArgs e)
        {
            ShowProgress();
        }

        private void Instance_DoReceiveEnded(object sender, EventArgs e)
        {
            UpdateMessagesTree();
            HideProgress();}

        private void InitializeData() {

        }
        
        protected internal override void OnTransitionCompleted() {
            base.OnTransitionCompleted();
            InitializeButtonPanel();
        }
        private void InitializeButtonPanel()
        {
            var buttons = new List<ButtonInfo>{
                new ButtonInfo
                {
                    Type = typeof (SimpleButton),
                    Text = "New",
                    Name = "1",
                    Image = Properties.Resources.mail,
                    mouseEventHandler = NewMessage
                },
                new ButtonInfo(),
                new ButtonInfo
                {
                    Type = typeof (SimpleButton),
                    Text = "Reply",
                    Name = "2",
                    Image = Properties.Resources.reply,
                    mouseEventHandler = reply
                },

                new ButtonInfo
                {
                    Type = typeof (SimpleButton),
                    Text = "Reply all",
                    Name = "3",
                    Image = Properties.Resources.replyall,
                    mouseEventHandler = replyAll
                },
                new ButtonInfo(),
                new ButtonInfo
                {
                    Type = typeof (SimpleButton),
                    Text = "Forward",
                    Name = "4",
                    Image = Properties.Resources.forward,
                    mouseEventHandler = forward
                },
                new ButtonInfo(),
                new ButtonInfo
                {
                    Type = typeof (SimpleButton),
                    Text = "Delete",
                    Name = "4",
                    Image = Properties.Resources.delete,
                    mouseEventHandler = deleteMessage
                },
                new ButtonInfo(),
                new ButtonInfo
                {
                    Type = typeof (SimpleButton),
                    Text = "Send/Receive",
                    Name = "3",
                    Image = Properties.Resources.Refresh,
                    mouseEventHandler = sendReceive
                },

            };

            BottomPanel.InitializeButtons(buttons, false);
        }

        private void NewMessage(object sender, EventArgs e)
        {
            using (var frmMail = new frmEditMail())
            {
                frmMail.ShowDialog();}
        }

        private void reply(object sender, EventArgs e)
        {
            mail1.CreateReplyMailMessage();
        }

        private void forward(object sender, EventArgs e)
        {
            mail1.CreateForwardMailMessage();
        }

        private void replyAll(object sender, EventArgs e)
        {
            mail1.CreateReplyAllMailMessages();
        }

        private void deleteMessage(object sender, EventArgs e)
        {
            int[] rows = mail1.gridView1.GetSelectedRows();
            if (rows.Length != 1)
                return;
            var row = mail1.gridView1.GetDataRow(rows[0]);
            mail1.gridView1.DeleteRow(rows[0]);
        }

        private void sendReceive(object sender, EventArgs e)
        {
            //var message = new Message
            //{
            //    Date = DateTime.Now,
            //    From = "mihaita.vladut@gmail.com",
            //    Subject = "Test subject",
            //    Text = "Test text",
            //    MailType = MailType.Inbox,
            //    MailFolder = (int) MailFolder.Announcements
            //};


            MessageReceiver.Instance.Receive();
        }

        void ShowProgress()
        {
            if (sendReceiveProgress.InvokeRequired)
            {
                Invoke(new MethodInvoker(ShowProgress));
            }
            else
            {
                sendReceiveProgress.Visible = true;
                sendReceiveProgress.Properties.Stopped = false;
                sendReceiveProgress.Properties.ShowTitle = true;
            }
        }

        void HideProgress()
        {
            if (sendReceiveProgress.InvokeRequired)
            {
                Invoke(new MethodInvoker(HideProgress));
            }
            else
            {
                sendReceiveProgress.Visible = false;
                sendReceiveProgress.Properties.Stopped = true;
                sendReceiveProgress.Properties.ShowTitle = false;
            }
        }

        public void UpdateMessagesTree()
        {
            if (ucMailTree1.InvokeRequired)
            {
                Invoke(new MethodInvoker(UpdateMessagesTree));
            }
            else
            {
                ucMailTree1.UpdateTreeViewMessages();
            }
        }

        public OrderCollectionViewModel ViewModel {
            get {
                return GetViewModel<OrderCollectionViewModel>();
            }
        }
        private void SetRevenuesData(Periods period) {}
        private void SetCostData(Periods period) {
        }private void todayRevenuesSimpleButton_Click(object sender, EventArgs e) {
            SetRevenuesData(Periods.Today);
        }
        private void monthRevenuesSimpleButton_Click(object sender, EventArgs e) {
            SetRevenuesData(Periods.Month);
        }
        private void yearRevenuesSimpleButton_Click(object sender, EventArgs e) {
            SetRevenuesData(Periods.Year);
        }
        private void todayCostSimpleButton_Click(object sender, EventArgs e) {
            SetCostData(Periods.Today);
        }
        private void monthCostSimpleButton_Click(object sender, EventArgs e) {
            SetCostData(Periods.Month);
        }
        private void yearCostSimpleButton_Click(object sender, EventArgs e) {
            SetCostData(Periods.Year);
        }

        private void revenuesChartControl_CustomDrawSeriesPoint(object sender, CustomDrawSeriesPointEventArgs e) {
            ChartControlLegendCustomPainter.Paint(e);
        }

        private void opportunitiesChartControl_CustomDrawSeriesPoint(object sender, CustomDrawSeriesPointEventArgs e) {
            ChartControlLegendCustomPainter.Paint(e);
        }

        private void buttonHide_Click(object sender, EventArgs e)
        {
            if (layoutControlGroup3.Visibility == XtraLayout.Utils.LayoutVisibility.Always)
            {
                ItemsHideHelper.Hide(new object[] { layoutControlGroup3 }, buttonHide);
                return;
            }
            if (layoutControlGroup3.Visibility == XtraLayout.Utils.LayoutVisibility.Never)
            {
                ItemsHideHelper.Expand(new object[] { layoutControlGroup3 }, buttonHide);
            }
        }

    }
    public class ChartControlLegendCustomPainter {
        public static void Paint(CustomDrawSeriesPointEventArgs e) {
            int imageSizeW = 18, imageSizeH = 14;
            var image = new Bitmap(imageSizeW, imageSizeH);
            using (var graphics = Graphics.FromImage(image)) {
                graphics.FillRectangle(new SolidBrush(e.LegendDrawOptions.Color), new Rectangle(new Point(0, 0), new Size(imageSizeW, imageSizeH)));
            }
            e.LegendMarkerImage = image;
            e.DisposeLegendMarkerImage = true;
            e.LegendMarkerVisible = true;
        }
    }
}
