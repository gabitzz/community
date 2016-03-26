using System.Drawing;
using System.Windows.Forms;
using DevExpress.LookAndFeel;
using DevExpress.Skins;

namespace DevExpress.DevAV.Controls.Messages.Helpers
{
    public class ColorHelper
    {
        public static void UpdateColor(ImageList list, UserLookAndFeel lf)
        {
            for (int i = 0; i < list.Images.Count; i++)
                list.Images[i] = SetColor(list.Images[i] as Bitmap, GetHeaderForeColor(lf));
        }
        public static Color GetHeaderForeColor(UserLookAndFeel lf)
        {
            Color ret = SystemColors.ControlText;
            if (lf.ActiveStyle != ActiveLookAndFeelStyle.Skin) return ret;
            return GridSkins.GetSkin(lf)[GridSkins.SkinHeader].Color.GetForeColor();
        }
        static Bitmap SetColor(Bitmap bmp, Color color)
        {
            for (int i = 0; i < bmp.Width; i++)
                for (int j = 0; j < bmp.Height; j++)
                    if (bmp.GetPixel(i, j).Name != "0")
                        bmp.SetPixel(i, j, color);
            return bmp;
        }
        public static string HtmlHyperLinkTextColor
        {
            get
            {
                Color color = EditorsSkins.GetSkin(DevExpress.LookAndFeel.UserLookAndFeel.Default).Colors.GetColor("HyperLinkTextColor");
                return GetRGBColor(color);
            }
        }
        public static string HtmlHighlightTextColor
        {
            get
            {
                Color color = CommonSkins.GetSkin(DevExpress.LookAndFeel.UserLookAndFeel.Default).Colors.GetColor("HighlightText");
                return GetRGBColor(color);
            }
        }
        public static string HtmlControlTextColor
        {
            get
            {
                Color color = CommonSkins.GetSkin(DevExpress.LookAndFeel.UserLookAndFeel.Default).Colors.GetColor("ControlText");
                return GetRGBColor(color);
            }
        }
        public static string HtmlControlTextColor2
        {
            get
            {
                Color color = CommonSkins.GetSkin(DevExpress.LookAndFeel.UserLookAndFeel.Default).Colors.GetColor("WindowText");
                return GetRGBColor(color);
            }
        }
        public static string HtmlQuestionColor
        {
            get
            {
                Color color = CommonColors.GetQuestionColor(DevExpress.LookAndFeel.UserLookAndFeel.Default);
                return GetRGBColor(color);
            }
        }
        public static string HtmlWarningColor
        {
            get
            {
                Color color = CommonColors.GetWarningColor(DevExpress.LookAndFeel.UserLookAndFeel.Default);
                return GetRGBColor(color);
            }
        }
        public static Color DisabledTextColor
        {
            get
            {
                return CommonSkins.GetSkin(DevExpress.LookAndFeel.UserLookAndFeel.Default).Colors.GetColor("DisabledText");
            }
        }
        public static Color CriticalColor
        {
            get
            {
                return CommonColors.GetCriticalColor(DevExpress.LookAndFeel.UserLookAndFeel.Default);
            }
        }
        public static Color WarningColor
        {
            get
            {
                return CommonColors.GetWarningColor(DevExpress.LookAndFeel.UserLookAndFeel.Default);
            }
        }
        static string GetRGBColor(Color color)
        {
            return string.Format("{0},{1},{2}", color.R, color.G, color.B);
        }
    }
}