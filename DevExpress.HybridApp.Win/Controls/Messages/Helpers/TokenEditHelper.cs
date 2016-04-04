using System.Text;
using DevExpress.DevAV.Helpers;
using DevExpress.XtraEditors;

namespace DevExpress.DevAV.Controls.Messages.Helpers
{
    public class TokenEditHelper
    {
        public static void InitializeHistory(TokenEdit tokenEdit)
        {
            foreach (Contact contact in DataHelper.Contacts)
            {
                TokenEditToken item = new TokenEditToken(contact.Email, contact);
                tokenEdit.Properties.Tokens.Add(item);
            }
        }
        public static string GetValue(string value)
        {
            if (string.IsNullOrEmpty(value)) return null;
            StringBuilder builder = new StringBuilder();
            foreach (string name in value.Split(','))
            {
                builder.Append(GetEmailAddress(name.Trim()));
                builder.Append(", ");
            }
            return builder.ToString();
        }
        static string GetEmailAddress(string value)
        {
            if (TextHelper.IsMailAddressValid(value)) return value;
            Contact contact = DataHelper.FindByName(value);
            if (contact != null) return contact.Email;
            return FormatEmail(value);
        }
        static string FormatEmail(string value)
        {
            StringBuilder builder = new StringBuilder(value);
            builder.Replace(" (", "_");
            builder.Replace(')', '_');
            builder.Replace(' ', '_');
            builder.Replace('-', '_');
            builder.Append("@dxmail.net");
            return builder.ToString();
        }
    }
}