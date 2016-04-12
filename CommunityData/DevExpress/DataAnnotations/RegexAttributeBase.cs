using System;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace DevExpress.DataAnnotations
{
    public abstract class RegexAttributeBase : DataTypeAttribute
    {
        protected const RegexOptions DefaultRegexOptions = (RegexOptions.Compiled | RegexOptions.ExplicitCapture | RegexOptions.IgnoreCase);
        private readonly Regex regex;

        public RegexAttributeBase(string regex, string defaultErrorMessage, DataType dataType) : this(new Regex(regex, RegexOptions.Compiled | RegexOptions.ExplicitCapture | RegexOptions.IgnoreCase), defaultErrorMessage, dataType)
        {
        }

        public RegexAttributeBase(Regex regex, string defaultErrorMessage, DataType dataType) : base(dataType)
        {
            this.regex = regex;
            base.ErrorMessage = defaultErrorMessage;
        }

        public sealed override bool IsValid(object value)
        {
            if (value == null)
            {
                return true;
            }
            string input = value as string;
            return ((input != null) && (this.regex.Match(input).Length > 0));
        }
    }
}

