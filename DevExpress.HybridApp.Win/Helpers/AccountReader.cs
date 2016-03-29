using System.Collections.Generic;
using System.IO;
using System.Xml;

namespace DevExpress.DevAV.Helpers
{
    public class AccountReader : IAccountReader
    {
        public List<EmailAccount> GetAccounts()
        {
            List<EmailAccount> accountList = new List<EmailAccount>();
            if (File.Exists(Constants.ACCOUNTS_FILE))
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(Constants.ACCOUNTS_FILE);
                var accountNodeList = doc.DocumentElement?.SelectNodes("account");
                if (accountNodeList != null)
                {
                    foreach (XmlNode accountNode in accountNodeList)
                    {
                        EmailAccount account = new EmailAccount();
                        account.Type = accountNode.SelectSingleNode("account-type")?.InnerText;
                        account.Name = accountNode.SelectSingleNode("name")?.InnerText;
                        account.Email = accountNode.SelectSingleNode("email")?.InnerText;
                        account.Incoming = accountNode.SelectSingleNode("incoming")?.InnerText;
                        account.Outgoing = accountNode.SelectSingleNode("outgoing")?.InnerText;
                        account.Username = accountNode.SelectSingleNode("username")?.InnerText;
                        account.Password = accountNode.SelectSingleNode("password")?.InnerText;

                        accountList.Add(account);
                    }
                }
            }
            return accountList;
        }
    }
}