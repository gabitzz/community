using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;

using DevExpress.XtraExport;

namespace DevExpress.DevAV.Controls.Messages.Helpers
{
    public class Contact : IComparable
    {
        DataRow customer, person;
        Image photo;
        FullName name;
        string email, phone, note;
        ContactGender gender;
        DateTime? birthDate;
        Address address;
        bool hasPhoto = false;
        public Contact()
        {
            name = new FullName("First", string.Empty, "Last");
            address = new Address();
        }
        public Contact(Contact contact)
        {
            name = new FullName();
            address = new Address();
            this.Assign(contact);
        }
        public Contact(DataRow customer, DataRow person)
        {
            this.customer = customer;
            this.person = person;
            if (!(customer["Photo"] is DBNull))
            {
                photo = ByteImageConverter.FromByteArray((byte[])customer["Photo"]);
                hasPhoto = true;
            }
            //else photo = global::DevExpress.MailClient.Win.Properties.Resources.Unknown_user;
            name = new FullName(string.Format("{0}", person["FirstName"]), string.Format("{0}", customer["MiddleName"]), string.Format("{0}", person["LastName"]));
            email = string.Format("{0}", customer["Email"]).Replace("dxvideorent.com", "dxmail.net");
            gender = (ContactGender)person["Gender"];
            birthDate = (DateTime?)person["BirthDate"];
            phone = string.Format("{0}", customer["Phone"]);
            address = new Address(string.Format("{0}", customer["Address"]));
        }
        public string Name { get { return name.ToString(); } }
        public string FirstName { get { return name.FirstName; } }
        public string MiddleName { get { return name.MiddleName; } }
        public string LastName { get { return name.LastName; } }
        public string Email { get { return email; } set { email = value; } }
        public ContactGender Gender { get { return gender; } set { gender = value; } }
        public DateTime? BirthDate { get { return birthDate; } }
        public DateTime BindingBirthDate
        {
            get
            {
                if (BirthDate.HasValue)
                    return BirthDate.Value;
                return DateTime.MinValue;
            }
            set
            {
                birthDate = value;
            }
        }
        public string Phone { get { return phone; } set { phone = value; } }
        public string State { get { return address.State; } }
        public string City { get { return address.City; } }
        public string Zip { get { return address.Zip; } }
        public string AddressLine { get { return address.AddressLine; } }
        public Address Address { get { return address; } }
        public FullName FullName { get { return name; } }
        public Image Photo { get { return photo; } set { photo = value; } }
        public string Note { get { return note; } set { note = value; } }
        public const string BirthDateHtml = "&lt;br&gt;Birth Date: &lt;b&gt;{0:d}&lt;/b&gt;";
        public const string EmailHtml = "&lt;br&gt;Email: &lt;b&gt;{0}&lt;/b&gt;";
        public const string PhoneHtml = "&lt;br&gt;Phone: &lt;b&gt;{0}&lt;/b&gt;";
        public const string AddressHtml = "&lt;br&gt;&lt;br&gt;Address: &lt;b&gt;{0}&lt;/b&gt;";

        public string GetContactInfoHtml()
        {
            string ret = string.Format("<size=+2><b>{0}</b><size=-2>", Name);
            ret += "<br>";
            if (BirthDate != null && BirthDate != DateTime.MinValue) ret += string.Format(BirthDateHtml, BirthDate);
            if (!string.IsNullOrEmpty(Email)) ret += string.Format(EmailHtml, Email);
            if (!string.IsNullOrEmpty(Phone)) ret += string.Format(PhoneHtml, Phone);
            ret += string.Format(AddressHtml, Address);

            return ret;
        }
        public override string ToString() { return Name; }
        public Image Icon
        {
            get
            {
                //ContactTitle title = name.Title;
                //if (title == ContactTitle.None && gender == ContactGender.Female) title = ContactTitle.Mrs;
                //switch (title)
                //{
                //    case ContactTitle.Dr: return global::DevExpress.MailClient.Win.Properties.Resources.Doctor;
                //    case ContactTitle.Miss: return global::DevExpress.MailClient.Win.Properties.Resources.Miss;
                //    case ContactTitle.Mrs: return global::DevExpress.MailClient.Win.Properties.Resources.Mrs;
                //    case ContactTitle.Ms: return global::DevExpress.MailClient.Win.Properties.Resources.Ms;
                //    case ContactTitle.Prof: return global::DevExpress.MailClient.Win.Properties.Resources.Professor;
                //}
                return null;
            }
        }
        internal bool HasPhoto { get { return hasPhoto; } }
        public void Assign(Contact contact)
        {
            this.photo = contact.Photo;
            this.name.Assign(contact.FullName);
            this.address.Assign(contact.Address);
            this.email = contact.Email;
            this.gender = contact.Gender;
            this.birthDate = contact.BirthDate;
            this.phone = contact.Phone;
            this.note = contact.Note;
        }
        public Contact Clone()
        {
            return new Contact(this);
        }
        #region IComparable Members

        public int CompareTo(object obj)
        {
            return Comparer<string>.Default.Compare(Name, obj.ToString());
        }

        #endregion
    }

    public class FullName
    {
        ContactTitle title;
        string first, middle, last;
        public FullName() : this(string.Empty, string.Empty, string.Empty) { }
        public FullName(string first, string middle, string last) : this(ContactTitle.None, first, middle, last) { }
        public FullName(ContactTitle title, string first, string middle, string last)
        {
            this.title = title;
            this.first = first;
            this.middle = middle;
            this.last = last;
        }
        public ContactTitle Title { get { return title; } set { title = value; } }
        public string FirstName { get { return first; } set { first = value; } }
        public string MiddleName { get { return middle; } set { middle = value; } }
        public string LastName { get { return last; } set { last = value; } }
        public override string ToString()
        {
            return string.Format("{0}{1}{2}{3}", GetFormatString(EditorHelper.GetTitleNameByContactTitle(Title)),
                GetFormatString(FirstName), GetFormatString(MiddleName), LastName);
        }
        string GetFormatString(string name)
        {
            if (string.IsNullOrEmpty(name)) return string.Empty;
            return string.Format("{0} ", name);
        }
        public void Assign(FullName name)
        {
            this.title = name.Title;
            this.first = name.FirstName;
            this.middle = name.MiddleName;
            this.last = name.LastName;
        }
    }
}