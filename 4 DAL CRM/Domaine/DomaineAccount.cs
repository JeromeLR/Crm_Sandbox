using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Crm.Sdk.Messages;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;
using Microsoft.Xrm.Sdk.Query;
using __4_DAL_CRM;

namespace _4_DAL_CRM.Domaine
{
    public interface IDomaineAccount
    {
        Account  RetrieveByGuid(Guid guid, IOrganizationService service);
        void Update(Account entity, IOrganizationService service);

        Guid Create(string name, IOrganizationService service);
        EntityCollection RetrieveByName(string name, IOrganizationService service);

    }

    public class DomaineAccount : IDomaineAccount
    {
        public DomaineAccount(OrganizationServiceProxy service)
        {
            this.service = service;
        }

        public DomaineAccount()
        {
        }

        private readonly OrganizationServiceProxy service;

        public Account RetrieveByGuid(Guid guid, IOrganizationService service)
        {
            Entity e = service.Retrieve("account", guid, new ColumnSet(true));
            Account a = (Account)e;

            return a;
        }

        public void Update(Account entity, IOrganizationService service)
        {
            service.Update(entity);
        }
        
        public Guid Create(string name, IOrganizationService service)
        {
            var account = new Entity(entityName: "account");
            account.Attributes["name"] = name;
            var accountId = service.Create(account);
            return accountId;
        }
        
        public EntityCollection RetrieveByName(string name, IOrganizationService service)
        {
            var query = new QueryExpression("account");
            query.ColumnSet = new ColumnSet(true);
            query.Criteria.AddCondition(new ConditionExpression("name", ConditionOperator.Equal, name));
            var accounts = service.RetrieveMultiple(query);
            return accounts;
        }

        // pour desactivation
        public class CrmStatusModel
        {
            public Guid Id { get; set; }
            public string EntityName { get; set; }
            public int StateValue { get; set; }
            public int StatusValue { get; set; }
        }

        public void UpdateStatus(CrmStatusModel model, IOrganizationService service)
        {
            var stateRequest = new SetStateRequest();
            stateRequest.EntityMoniker = new EntityReference(model.EntityName, model.Id);
            stateRequest.State = new OptionSetValue(model.StateValue);
            stateRequest.Status = new OptionSetValue(model.StatusValue);

            service.Execute(stateRequest);
        }
    }
}
   

