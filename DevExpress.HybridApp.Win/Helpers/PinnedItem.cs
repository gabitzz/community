using DevExpress.XtraBars.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DevExpress.DevAV.Helpers
{
    public class PinnedItem
    {
        public string Name { get; set; }
        public string URL { get; set; }
        public TileBarItem TileBarItem {get; set;}

        public PinnedItem(string name,string url)
        {
            Name = name;
            URL = url;
        }
    }
}
