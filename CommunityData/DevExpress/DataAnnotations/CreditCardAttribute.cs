namespace DevExpress.DataAnnotations
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;

    public sealed class CreditCardAttribute : DataTypeAttribute
    {
        private const string Message = "The {0} field is not a valid credit card number.";

        public CreditCardAttribute() : base(DataType.Custom)
        {
            base.ErrorMessage = "The {0} field is not a valid credit card number.";
        }

        public override bool IsValid(object value)
        {
            if (value == null)
            {
                return true;
            }
            string source = value as string;
            if (source == null)
            {
                return false;
            }
            source = source.Replace("-", "").Replace(" ", "");
            int num = 0;
            bool flag = false;
            foreach (char ch in source.Reverse<char>())
            {
                if ((ch < '0') || (ch > '9'))
                {
                    return false;
                }
                int num2 = (ch - '0') * (flag ? 2 : 1);
                flag = !flag;
                while (num2 > 0)
                {
                    num += num2 % 10;
                    num2 /= 10;
                }
            }
            return ((num % 10) == 0);
        }
    }
}

