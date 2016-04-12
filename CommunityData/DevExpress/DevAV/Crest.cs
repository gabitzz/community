namespace DevExpress.DevAV
{
    using DevExpress.Utils;
    using DevExpress.XtraEditors.Controls;
    using System;
    using System.Drawing;
    using System.Runtime.CompilerServices;

    public class Crest : DatabaseObject
    {
        private Image img;

        public string CityName { get; set; }

        public byte[] LargeImage { get; set; }

        public Image LargeImageEx
        {
            get
            {
                if (this.img == null)
                {
                    if (this.LargeImage == null)
                    {
                        return ResourceImageHelper.CreateImageFromResourcesEx("CommunityData.Resources.Unknown_user.png", typeof(Employee).Assembly);
                    }
                    this.img = ByteImageConverter.FromByteArray(this.LargeImage);
                }
                return this.img;
            }
        }

        public byte[] SmallImage { get; set; }
    }
}

