using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using DevExpress.DevAV.ViewModels;
using DevExpress.XtraEditors;
using DevExpress.XtraCharts;
using DevExpress.DevAV.Common.Utils;
using DevExpress.DevAV.Controls.Messages;
using DevExpress.DevAV.Controls.Messages.Helpers;
using DevExpress.DevAV.Helpers;
using OpenPop.Pop3;

namespace DevExpress.DevAV.Modules {

    public enum Periods : int {
        Month = 1,
        Today = 2,
        Year = 0
    }
    public partial class Messages : BaseModuleControl {

        public Messages()
            : base(CreateViewModel<OrderCollectionViewModel>) {
            InitializeComponent();
            InitializeData();
        }
        private void InitializeData() {

        }
        
        protected internal override void OnTransitionCompleted() {
            base.OnTransitionCompleted();
            InitializeButtonPanel();
        }
        private void InitializeButtonPanel() {
            var buttons = new List<ButtonInfo>{
                new ButtonInfo
                {
                    Type = typeof (SimpleButton),
                    Text = "New",
                    Name = "1",
                    Image = Properties.Resources.mail,
                    mouseEventHandler = NewMessage
                },
                new ButtonInfo
                {
                    Type = typeof (SimpleButton),
                    Text = "Send/Receive",
                    Name = "2",
                    Image = Properties.Resources.Refresh,
                    mouseEventHandler = sendReceive
                }
            };

            BottomPanel.InitializeButtons(buttons, false);
        }

        private void NewMessage(object sender, EventArgs e)
        {
            
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


            //DataHelper.AddMessage(message);

            // TODO send receive
            using (var client = new Pop3Client())
            {
                // Connect to the server
                client.Connect("pop.gmail.com", 995, true);

                // Authenticate ourselves towards the server
                client.Authenticate("silentbusters@gmail.com", "silent123");

                // Get the number of messages in the inbox
                int messageCount = client.GetMessageCount();

                // Most servers give the latest message the highest number
                for (int i = messageCount; i > 0; i--)
                {
                    var msg = client.GetMessage(i);
                    var messageDate = DateTime.Parse(msg.Headers.Date);
                    var nessage = new Message
                    {
                        Date = messageDate,
                        From = msg.Headers.From.Address,
                        Subject = msg.Headers.Subject,
                        Text = msg.FindFirstHtmlVersion().GetBodyAsText(),
                        MailType = MailType.Inbox,
                        MailFolder = (int)MailFolder.Announcements
                    };
                    DataHelper.AddMessage(nessage);
                }
            }
            ucMailTree1.UpdateTreeViewMessages();


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
