namespace DevExpress.DevAV
{
    using DevExpress.DataAnnotations;
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Drawing;
    using System.Runtime.CompilerServices;

    public class CustomerEmployee : DatabaseObject
    {
        private Image _photo;

        public override string ToString()
        {
            return this.FullName;
        }

        public DevExpress.DevAV.Address Address
        {
            get
            {
                if (this.CustomerStore == null)
                {
                    return null;
                }
                return this.CustomerStore.Address;
            }
        }

        public virtual DevExpress.DevAV.Customer Customer { get; set; }

        public long? CustomerId { get; set; }

        public virtual DevExpress.DevAV.CustomerStore CustomerStore { get; set; }

        public long? CustomerStoreId { get; set; }

        [Required, EmailAddress]
        public string Email { get; set; }

        [Display(Name="First Name"), Required]
        public string FirstName { get; set; }

        [Display(Name="Full Name")]
        public string FullName { get; set; }

        public bool IsPurchaseAuthority { get; set; }

        [Display(Name="Last Name"), Required]
        public string LastName { get; set; }

        [Required, Display(Name="Mobile Phone"), Phone]
        public string MobilePhone { get; set; }

        [NotMapped]
        public Image Photo
        {
            get
            {
                if (this._photo == null)
                {
                    this._photo = this.Picture.CreateImage(null);
                }
                return this._photo;
            }
            set
            {
                this._photo = value;
                this.Picture = PictureExtension.FromImage(value);
            }
        }

        public virtual DevExpress.DevAV.Picture Picture { get; set; }

        public long? PictureId { get; set; }

        public string Position { get; set; }

        public PersonPrefix Prefix { get; set; }
    }
}

