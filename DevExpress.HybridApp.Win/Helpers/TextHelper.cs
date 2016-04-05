using System.Text.RegularExpressions;

namespace DevExpress.DevAV.Helpers
{
    public class TextHelper
    {
        public static bool IsMailAddressValid(string mailAddress)
        {
            return MailRegex.IsMatch(mailAddress);
        }
        static Regex MailRegex = new Regex(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", RegexOptions.Compiled);
    }
}