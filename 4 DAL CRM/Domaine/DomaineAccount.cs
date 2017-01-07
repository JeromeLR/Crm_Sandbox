using System;
using System.Collections.Generic;
using System.Linq;
using _4_DAL_CRM;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;
using Microsoft.Xrm.Sdk.Metadata;
using Microsoft.Xrm.Sdk.Messages;
using __4_DAL_CRM;

namespace _4_DAL_CRM
{
    public class DomaineAccount
    {
        // avec IOrganizationService, moquable (standard)
        #region create Moq
        /// <summary>
        /// Creates a new account with a given name using the supplied organization service
        /// </summary>
        /// <param name="accountName">account name</param>
        /// <param name="service">organization service</param>
        /// <returns>id of the new account</returns>
        public static Guid CreateCrmAccount(string accountName, IOrganizationService service)
        {
            // utilisation de l'entité générique
            Entity account = new Entity("account");
            account["name"] = accountName;
            Guid newId = service.Create(account);
            return newId;
        }
        #endregion create Moq

        

        public Guid AddAccount(Account a, IOrganizationService service)
        {
            // utilisation entité Account
            var newAccount = new Account
            {
                Name = a.Name,
                Id = a.Id,
                Address1_PostalCode = a.Address1_PostalCode,
                Address1_Line1 = a.Address2_Line1,
                Address1_Line2 = a.Address2_Line1,
                Address1_City = a.Address1_City
            };
            Guid newId = service.Create(a);
            return newId;
        }

        // Service context implemente IOrganizationService + linQ
        /// Retourne tous les clients
        /// </summary>
        /// <returns>liste de clients</returns>
        public List<Account> GetAllAccounts(ServiceContext serviceContext )
        {
            var service = (IOrganizationService) serviceContext;
            List<Account> accounts;
            accounts = serviceContext.AccountSet.ToList();
            return accounts;
        }

        // Service context implemente IOrganizationService + linQ
        /// Retourne tous les clients
        /// </summary>
        /// <returns>liste de clients</returns>
        public List<Account> GetAccountsCreatedSince(ServiceContext serviceContext,int periodicite)
        {
            var service = (IOrganizationService)serviceContext;
            List<Account> accounts;
            accounts = serviceContext.AccountSet.Where(soc => soc.CreatedOn > DateTime.UtcNow.AddMinutes(-periodicite)).ToList();
            return accounts;
        }


        // Service context implemente IOrganizationService + linQ
        /// Retourne tous les clients
        /// </summary>
        /// <returns>liste de clients</returns>
        public List<Account> GetAccountsModifiedSince(ServiceContext serviceContext, int periodicite)
        {
            var service = (IOrganizationService)serviceContext;
            List<Account> accounts;
            accounts = serviceContext.AccountSet.Where(a => a.ModifiedOn > DateTime.UtcNow.AddMinutes(-periodicite)).ToList();
            return accounts;
        }

        // Service context implemente IOrganizationService + linQ
        /// Retourne tous les clients
        /// </summary>
        /// <returns>liste de clients</returns>
        public List<Account> GetAccountsDesactivatedSince(ServiceContext serviceContext, int periodicite)
        {
            var service = (IOrganizationService)serviceContext;
            List<Account> accounts;
            accounts = serviceContext.AccountSet.Where(soc => soc.ModifiedOn > DateTime.UtcNow.AddMinutes(-periodicite) && soc.GetAttributeValue<OptionSetValue>("statecode").Value == 1).ToList();
            return accounts;
        }
    }
   
}
