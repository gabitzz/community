using System;
using System.Text.RegularExpressions;
using System.ComponentModel.DataAnnotations;

namespace DevExpress.DataAnnotations
{
    public sealed class ZipCodeAttribute : RegexAttributeBase
    {
        private const string Message = "The {0} field is not a valid ZIP code.";
        private static Regex regex = new Regex("^[0-9][0-9][0-9][0-9][0-9]$", RegexOptions.Compiled | RegexOptions.ExplicitCapture | RegexOptions.IgnoreCase);

        public ZipCodeAttribute() : base(regex, "The {0} field is not a valid ZIP code.", DataType.Url)
        {
        }
    }
}

