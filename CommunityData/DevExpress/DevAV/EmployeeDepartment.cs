namespace DevExpress.DevAV
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public enum EmployeeDepartment
    {
        [Display(Name="Engineering")]
        Engineering = 4,
        [Display(Name="Human Resources")]
        HumanResources = 5,
        [Display(Name="IT")]
        IT = 7,
        [Display(Name="Management")]
        Management = 6,
        [Display(Name="Sales")]
        Sales = 1,
        [Display(Name="Shipping")]
        Shipping = 3,
        [Display(Name="Support")]
        Support = 2
    }
}

