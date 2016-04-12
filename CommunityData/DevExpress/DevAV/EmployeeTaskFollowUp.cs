namespace DevExpress.DevAV
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public enum EmployeeTaskFollowUp
    {
        [Display(Name="Custom")]
        Custom = 5,
        [Display(Name="Next Week")]
        NextWeek = 3,
        [Display(Name="No Date")]
        NoDate = 4,
        [Display(Name="This Week")]
        ThisWeek = 2,
        [Display(Name="Today")]
        Today = 0,
        [Display(Name="Tomorrow")]
        Tomorrow = 1
    }
}

