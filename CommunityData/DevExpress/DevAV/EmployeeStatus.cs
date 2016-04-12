namespace DevExpress.DevAV
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public enum EmployeeStatus
    {
        [Display(Name="Commission")]
        Commission = 1,
        [Display(Name="Contract")]
        Contract = 2,
        [Display(Name="On Leave")]
        OnLeave = 4,
        [Display(Name="Salaried")]
        Salaried = 0,
        [Display(Name="Terminated")]
        Terminated = 3
    }
}

