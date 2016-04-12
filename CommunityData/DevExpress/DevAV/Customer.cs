namespace DevExpress.DevAV
{
    using DevExpress.DataAnnotations;
    using DevExpress.Utils;
    using DevExpress.XtraEditors.Controls;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Drawing;
    using System.Runtime.CompilerServices;

    public class Customer : DatabaseObject
    {
        private System.Drawing.Image img;

        public Customer()
        {
            this.Employees = new List<CustomerEmployee>();
            this.Orders = new List<Order>();
            this.HomeOffice = new Address();
            this.BillingAddress = new Address();
        }

        internal static System.Drawing.Image CreateImage(byte[] data)
        {
            if (data == null)
            {
                return ResourceImageHelper.CreateImageFromResourcesEx("CommunityData.Resources.Unknown_user.png", typeof(Employee).Assembly);
            }
            return ByteImageConverter.FromByteArray(data);
        }

        [DataType(DataType.Currency)]
        public decimal AnnualRevenue { get; set; }

        public Address BillingAddress { get; set; }

        [InverseProperty("Customer")]
        public virtual List<CustomerStore> CustomerStores { get; set; }

        public virtual List<CustomerEmployee> Employees { get; set; }

        [Phone]
        public string Fax { get; set; }

        public Address HomeOffice { get; set; }

        public System.Drawing.Image Image
        {
            get
            {
                if (this.img == null)
                {
                    this.img = CreateImage(this.Logo);
                }
                return this.img;
            }
        }

        public byte[] Logo { get; set; }

        [Required]
        public string Name { get; set; }

        [InverseProperty("Customer")]
        public virtual List<Order> Orders { get; set; }

        [Phone]
        public string Phone { get; set; }

        public virtual string Profile { get; set; }

        [InverseProperty("Customer")]
        public virtual List<Quote> Quotes { get; set; }

        public CustomerStatus Status { get; set; }

        [Display(Name="Total Employees")]
        public int TotalEmployees { get; set; }

        [Display(Name="Total Stores")]
        public int TotalStores { get; set; }

        [Url]
        public string Website { get; set; }
    }
}

