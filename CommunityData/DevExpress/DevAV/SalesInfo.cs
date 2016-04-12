namespace DevExpress.DevAV
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    public class SalesInfo
    {
        public SalesInfo()
        {
            this.ListProductInfo = new List<SalesProductInfo>();
        }

        public string Caption { get; set; }

        public List<SalesProductInfo> ListProductInfo { get; set; }

        public DateTime time { get; set; }
    }
}

