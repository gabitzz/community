﻿using System;
using System.Linq;
using System.Text;

namespace DevExpress.DevAV.Controls.Messages.Helpers
{
    public class EmailRule
    {
        public Guid Id { get; set; }
        public string From { get; set; }
        //public string To { get; set; }
        public string Subject { get; set; }
        public string Folder { get; set; }
    }
}
