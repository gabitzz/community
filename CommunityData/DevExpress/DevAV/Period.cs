namespace DevExpress.DevAV
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public enum Period
    {
        [Display(Name="Fixed Date")]
        FixedDate = 3,
        [Display(Name="Lifetime")]
        Lifetime = 0,
        [Display(Name="This Month")]
        ThisMonth = 2,
        [Display(Name="This Year")]
        ThisYear = 1
    }
}

