using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraSplashScreen;

namespace DevExpress.DevAV.Forms
{
    public partial class CommunitySplashScreen : SplashScreen
    {
        int dotCount = 0;
        public CommunitySplashScreen()
        {
            InitializeComponent();
            Timer tmr = new Timer();
            tmr.Interval = 400;
            tmr.Tick += Tmr_Tick;
            tmr.Start();
        }

        private void Tmr_Tick(object sender, EventArgs e)
        {
            if (++dotCount > 3) dotCount = 0;
            lblLoading.Text = string.Format("{1}{0}", GetDots(dotCount), "Loading");
        }

        string GetDots(int count)
        {
            string ret = string.Empty;
            for (int i = 0; i < count; i++) ret += ".";
            return ret;
        }
        
    }
}
