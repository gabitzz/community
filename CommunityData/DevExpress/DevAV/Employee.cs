namespace DevExpress.DevAV
{
    using DevExpress.DataAnnotations;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Drawing;
    using System.Runtime.CompilerServices;

    public class Employee : DatabaseObject
    {
        private Image _photo;
        private bool unsetFullName;
        private List<string> _users = new List<string>();

        public Employee()
        {
            this.AssignedTasks = new List<EmployeeTask>();
            this.OwnedTasks = new List<EmployeeTask>();
            this.Address = new DevExpress.DevAV.Address();
            this.AssignedEmployeeTasks = new List<EmployeeTask>();

            _users.Add("19");
            _users.Add("14");
            _users.Add("3");
            _users.Add("37");
            _users.Add("22");
            _users.Add("36");
        }

        private string GetFullName()
        {
            return string.Format("{0} {1}", this.FirstName, this.LastName);
        }

        public void ResetBindable()
        {
            if (this._photo != null)
            {
                this._photo.Dispose();
            }
            this._photo = null;
            this.unsetFullName = false;
        }

        public override string ToString()
        {
            return this.FullName;
        }

        public DevExpress.DevAV.Address Address { get; set; }

        [InverseProperty("AssignedEmployees")]
        public virtual List<EmployeeTask> AssignedEmployeeTasks { get; set; }

        [InverseProperty("AssignedEmployee")]
        public virtual List<EmployeeTask> AssignedTasks { get; set; }

        [Display(Name="Birth Date")]
        public DateTime? BirthDate { get; set; }

        public EmployeeDepartment Department { get; set; }

        [EmailAddress, Required]
        public string Email { get; set; }

        [InverseProperty("Employee")]
        public virtual List<Evaluation> Evaluations { get; set; }

        [Display(Name="First Name"), Required]
        public string FirstName { get; set; }

        [Display(Name="Full Name")]
        public string FullName { get; set; }

        [Display(Name="Full Name"), NotMapped]
        public string FullNameBindable
        {
            get
            {
                if (!string.IsNullOrEmpty(this.FullName) && !this.unsetFullName)
                {
                    return this.FullName;
                }
                return this.GetFullName();
            }
            set
            {
                this.unsetFullName = string.IsNullOrEmpty(value);
                if (this.unsetFullName)
                {
                    this.FullName = this.GetFullName();
                }
                else
                {
                    this.FullName = value;
                }
            }
        }

        [Display(Name="Hire Date")]
        public DateTime? HireDate { get; set; }

        [Display(Name="Home Phone"), Phone]
        public string HomePhone { get; set; }

        [Display(Name="Last Name"), Required]
        public string LastName { get; set; }

        [Display(Name="Mobile Phone"), Phone, Required]
        public string MobilePhone { get; set; }

        [InverseProperty("Owner")]
        public virtual List<EmployeeTask> OwnedTasks { get; set; }

        public string PersonalProfile { get; set; }

        [NotMapped]
        public Image Photo
        {
            get
            {
                if (this._photo == null)
                {
                    if (_users.Contains(PictureId.ToString()))
                    {
                        this._photo = this.Picture.CreateImage(PictureId.ToString(), null);
                    }
                    else
                    {
                        this._photo = this.Picture.CreateImage(null);
                    }
                }
                return this._photo;
            }
            set
            {
                if (this._photo != value)
                {
                    if (this._photo != null)
                    {
                        this._photo.Dispose();
                    }
                    this._photo = value;
                    this.Picture = PictureExtension.FromImage(value);
                }
            }
        }

        public virtual DevExpress.DevAV.Picture Picture { get; set; }

        public long? PictureId { get; set; }

        public PersonPrefix Prefix { get; set; }

        public virtual Probation ProbationReason { get; set; }

        public string Skype { get; set; }

        public EmployeeStatus Status { get; set; }

        [Required]
        public string Title { get; set; }
    }
}

