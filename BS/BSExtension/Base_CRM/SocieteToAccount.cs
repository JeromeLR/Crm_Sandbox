using _4_DAL_CRM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;
using Microsoft.Xrm.Sdk;
using TO;

namespace BS.BSExtension
{
    public static class MethodeExtentionToCRM
    {
        public static Account toAccount(this Societe societe)
        {
            var account = new Account
            {
                // Corespondance simple
                Name = societe.Nom,
                Address1_Line1 = societe.AdresseLigne1,
                Address1_Line2 = societe.AdresseLigne2,
                Address1_PostalCode = societe.CodePostal,
                Address1_City = societe.Ville,
                Address1_Telephone1 = societe.TelephoneStandard,
                Description = societe.Remarque,
                EMailAddress1 = societe.EMail,
                WebSiteURL = societe.SiteWeb,


            };

            return account;
        }
    }
}
