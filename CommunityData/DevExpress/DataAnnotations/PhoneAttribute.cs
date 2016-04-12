using System;
using System.Text.RegularExpressions;
using System.ComponentModel.DataAnnotations;

namespace DevExpress.DataAnnotations
{
    public sealed class PhoneAttribute : RegexAttributeBase
    {
        private const string Message = "The {0} field is not a valid phone number.";
        private static readonly Regex regex = new Regex(@"^(\+\s?)?((?<!\+.*)\(\+?\d+([\s\-\.]?\d+)?\)|\d+)([\s\-\.]?(\(\d+([\s\-\.]?\d+)?\)|\d+))*(\s?(x|ext\.?)\s?\d+)?$", RegexOptions.Compiled | RegexOptions.ExplicitCapture | RegexOptions.IgnoreCase);

        public PhoneAttribute() : base(regex, "The {0} field is not a valid phone number.", DataType.PhoneNumber)
        {
        }
    }
}

