using System.Xml;

namespace DevExpress.DevAV.Helpers
{
    public class AccountWriter
    {
        public void Save(EmailAccount account)
        {
            XmlDocument xmlDoc = new XmlDocument();
            XmlNode rootNode = xmlDoc.CreateElement("accounts");
            xmlDoc.AppendChild(rootNode);

            var accountNode = xmlDoc.CreateElement("account");

            accountNode.CreateLeaf("account-type", account.Type);
            accountNode.CreateLeaf("name", account.Name);
            accountNode.CreateLeaf("email", account.Email);
            accountNode.CreateLeaf("incoming", account.Incoming);
            accountNode.CreateLeaf("outgoing", account.Outgoing);
            accountNode.CreateLeaf("username", account.Username);
            accountNode.CreateLeaf("password", account.Password);
            accountNode.CreateLeaf("port", account.Port.ToString());

            rootNode.AppendChild(accountNode);

            xmlDoc.Save(Constants.ACCOUNTS_FILE);
        }
    }
}