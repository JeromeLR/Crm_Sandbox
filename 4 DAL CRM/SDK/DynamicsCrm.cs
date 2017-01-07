//-----------------------------------------------------------------------
// <copyright file="DynamicsCrm.cs" company="Gestform">
//     Copyright GESTFORM 2016
// </copyright>
//-----------------------------------------------------------------------

using System;
using System.Linq;
using Microsoft.Xrm.Sdk.Client;
using Microsoft.Xrm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Metadata;

namespace _4_DAL_CRM
{
    public static class DynamicsCrm
    {
        public static OptionSetMetadata GetGlobalOptionSetValues(this OrganizationServiceProxy connexion, string nomInterneListe)
        {
            var retrieveOptionSetRequest = new RetrieveOptionSetRequest();
            retrieveOptionSetRequest.Name = nomInterneListe;

            RetrieveOptionSetResponse retrieveOptionSetResponse = (RetrieveOptionSetResponse)connexion.Execute(retrieveOptionSetRequest);

            return (OptionSetMetadata)retrieveOptionSetResponse.OptionSetMetadata;
        }

        public static OptionSetMetadata GetLocalOptionSetValues(this OrganizationServiceProxy connexion, string entityName, string attributeName)
        {
            string EntityLogicalName = entityName;
            RetrieveEntityRequest retrieveDetails = new RetrieveEntityRequest
            {
                EntityFilters = EntityFilters.All,
                LogicalName = EntityLogicalName
            };
            RetrieveEntityResponse retrieveEntityResponseObj = (RetrieveEntityResponse)connexion.Execute(retrieveDetails);
            EntityMetadata metadata = retrieveEntityResponseObj.EntityMetadata;
            PicklistAttributeMetadata picklistMetadata = metadata.Attributes.FirstOrDefault(attribute => String.Equals(attribute.LogicalName, attributeName, StringComparison.OrdinalIgnoreCase)) as PicklistAttributeMetadata;
            OptionSetMetadata options = picklistMetadata.OptionSet;
            return options;
        }
    }
}
