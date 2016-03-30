using System.Xml;

namespace DevExpress.DevAV.Helpers
{
    public static class XmlElementExtensions
    {
        public static XmlElement CreateLeaf(this XmlElement parent, string name, string value)
        {
            if (parent.OwnerDocument != null)
            {
                var elem = parent.OwnerDocument.CreateElement(name);
                elem.InnerText = value;
                parent.AppendChild(elem);
                return elem;
            }
            return null;
        }
    }
};