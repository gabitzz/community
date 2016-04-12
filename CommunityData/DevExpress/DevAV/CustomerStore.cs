namespace DevExpress.DevAV
{
    using DevExpress.Utils;
    using DevExpress.XtraEditors.Controls;
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Drawing;
    using System.Runtime.CompilerServices;

    public class CustomerStore : DatabaseObject
    {
        private Image largeImg;
        private Image smallImg;

        private Image CreateImage(byte[] data)
        {
            if (data == null)
            {
                return ResourceImageHelper.CreateImageFromResourcesEx("CommunityData.Resources.Unknown_user.png", typeof(Employee).Assembly);
            }
            return ByteImageConverter.FromByteArray(data);
        }

        public DevExpress.DevAV.Address Address { get; set; }

        public string AddressLine
        {
            get
            {
                if (this.Address == null)
                {
                    return null;
                }
                return this.Address.ToString();
            }
        }

        public string AddressLines
        {
            get
            {
                if (this.Address == null)
                {
                    return null;
                }
                return string.Format("{0}\r\n{1} {2}", this.Address.Line, this.Address.State, this.Address.ZipCode);
            }
        }

        [DataType(DataType.Currency)]
        public decimal AnnualSales { get; set; }

        public string City
        {
            get
            {
                if (this.Address != null)
                {
                    return this.Address.City;
                }
                return "";
            }
        }

        public virtual DevExpress.DevAV.Crest Crest { get; set; }

        public string CrestCity
        {
            get
            {
                if (this.Crest == null)
                {
                    return null;
                }
                return this.Crest.CityName;
            }
        }

        public long? CrestId { get; set; }

        public Image CrestLargeImage
        {
            get
            {
                if ((this.largeImg == null) && (this.Crest != null))
                {
                    this.largeImg = this.CreateImage(this.Crest.LargeImage);
                }
                return this.largeImg;
            }
        }

        public Image CrestSmallImage
        {
            get
            {
                if ((this.smallImg == null) && (this.Crest != null))
                {
                    this.smallImg = this.CreateImage(this.Crest.SmallImage);
                }
                return this.smallImg;
            }
        }

        public virtual DevExpress.DevAV.Customer Customer { get; set; }

        public long? CustomerId { get; set; }

        public string CustomerName
        {
            get
            {
                if (this.Customer == null)
                {
                    return null;
                }
                return this.Customer.Name;
            }
        }

        public string Fax { get; set; }

        public string Location { get; set; }

        public string Phone { get; set; }

        public int SquereFootage { get; set; }

        public StateEnum State
        {
            get
            {
                if (this.Address != null)
                {
                    return this.Address.State;
                }
                return StateEnum.CA;
            }
        }

        public int TotalEmployees { get; set; }
    }
}

