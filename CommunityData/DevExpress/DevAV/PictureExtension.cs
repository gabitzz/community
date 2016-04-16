using System.IO;
using Properties;

namespace DevExpress.DevAV
{
    using DevExpress.Utils;
    using DevExpress.XtraEditors.Controls;
    using System;
    using System.Drawing;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    internal static class PictureExtension
    {
        public const string DefaultPic = "CommunityData.Resources.Unknown_user.png";
        public const string DefaultUserPic = "CommunityData.Resources.Unknown_user.png";

        internal static Image CreateImage(this Picture picture, string defaultImage = null)
        {
            if (picture != null)
            {
                return ByteImageConverter.FromByteArray(picture.Data);
            }
            if (string.IsNullOrEmpty(defaultImage))
            {
                defaultImage = "CommunityData.Resources.Unknown_user.png";
            }
            return ResourceImageHelper.CreateImageFromResourcesEx(defaultImage, typeof(Picture).Assembly);
        }

        internal static Picture FromImage(Image image)
        {
            if (image != null)
            {
                return new Picture { Data = ByteImageConverter.ToByteArray(image, image.RawFormat) };
            }
            return null;
        }

        public static Image CreateImage(this Picture picture, string id, string defaultImage = null)
        {
            switch (id)
            {
                case "19":
                    return Resources.vio;
                case "14":
                    return Resources.miti;
                case "3":
                    return Resources.mihaita;
                case "37":
                    return Resources.gabi;
                case "22":
                    return Resources.george;
                case "36":
                    return Resources.raluca;

            }

            if (string.IsNullOrEmpty(defaultImage))
            {
                defaultImage = "CommunityData.Resources.Unknown_user.png";
            }
            return ResourceImageHelper.CreateImageFromResourcesEx(defaultImage, typeof(Picture).Assembly);
        }
    }
}

