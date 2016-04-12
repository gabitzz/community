namespace DevExpress.DevAV
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public enum ProductCategory
    {
        [Display(Name="Automation")]
        Automation = 0,
        [Display(Name="Monitors")]
        Monitors = 1,
        [Display(Name="Projectors")]
        Projectors = 2,
        [Display(Name="Televisions")]
        Televisions = 3,
        [Display(Name="Video Players")]
        VideoPlayers = 4
    }
}

