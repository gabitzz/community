using DevExpress.XtraEditors.Repository;

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

        public static void InitPriorityComboBox(RepositoryItemImageComboBox edit)
        {
            edit.Items.Clear();
            edit.Items.AddRange(new DevExpress.XtraEditors.Controls.ImageComboBoxItem[] {
                new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Low", 0, 0),
                new DevExpress.XtraEditors.Controls.ImageComboBoxItem("Medium", 1, -1),
                new DevExpress.XtraEditors.Controls.ImageComboBoxItem("High", 2, 1)});
        }
    }
}