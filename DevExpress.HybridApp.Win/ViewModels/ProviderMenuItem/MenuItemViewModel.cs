using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.DevAV;

namespace DevExpress.DevAV.ViewModels
{
    public class MenuItemViewModel
    {
        public MenuItemViewModel(ProviderMenuItem menuItem = null)
        {
        }

        public void Reset(ProviderMenuItem newObject)
        {
            if (newObject == null)
                return;

            Id = newObject.ProviderMenuItemID;
            Name = newObject.Name;
            LikeCount = newObject.LikeCount;
            DislikeCount = newObject.DislikeCount;
        }

        public String Name
        {
            get { return Name; }
            set { Name = value; }
        }

        public int LikeCount
        {
            get { return LikeCount; }
            set { LikeCount = value; }
        }

        public int DislikeCount
        {
            get { return DislikeCount; }
            set { DislikeCount = value; }
        }

        public long Id
        {
            get { return Id; }
            set { Id = value; }
        }
    }
}
