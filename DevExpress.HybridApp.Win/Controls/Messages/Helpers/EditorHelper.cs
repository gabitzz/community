namespace DevExpress.DevAV.Controls.Messages.Helpers
{
    public class EditorHelper
    {
        public static string GetTitleNameByContactTitle(ContactTitle title)
        {
            switch (title)
            {
                case ContactTitle.Dr: return "Dr";
                case ContactTitle.Miss: return "Miss";
                case ContactTitle.Mr: return "Mr.";
                case ContactTitle.Mrs: return "Mrs.";
                case ContactTitle.Ms: return "Ms.";
                case ContactTitle.Prof: return "Prof.";
            }
            return string.Empty;
        }
    }
}