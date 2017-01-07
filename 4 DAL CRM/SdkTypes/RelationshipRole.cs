namespace __4_DAL_CRM
{
    /// <summary>
    /// Relationship between an account or contact and an opportunity.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("relationshiprole")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class RelationshipRole : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public RelationshipRole() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "relationshiprole";

        public const int EntityTypeCode = 4500;

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;

        private void OnPropertyChanged(string propertyName)
        {
            if ((this.PropertyChanged != null))
            {
                this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }

        private void OnPropertyChanging(string propertyName)
        {
            if ((this.PropertyChanging != null))
            {
                this.PropertyChanging(this, new System.ComponentModel.PropertyChangingEventArgs(propertyName));
            }
        }

        /// <summary>
        /// Unique Identifier of the user who created the relationship role.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby"); }
        }

        /// <summary>
        /// Date and time when the relationship role was created.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
        public System.Nullable<System.DateTime> CreatedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who created the relationshiprole.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        /// Description of the relationship role.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("description")]
        public string Description
        {
            get { return this.GetAttributeValue<string>("description"); }
            set
            {
                this.OnPropertyChanging("Description");
                this.SetAttributeValue("description", value);
                this.OnPropertyChanged("Description");
            }
        }

        /// <summary>
        /// Unique identifier of the data import or data migration that created this record.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("importsequencenumber")]
        public System.Nullable<int> ImportSequenceNumber
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("importsequencenumber"); }
            set
            {
                this.OnPropertyChanging("ImportSequenceNumber");
                this.SetAttributeValue("importsequencenumber", value);
                this.OnPropertyChanged("ImportSequenceNumber");
            }
        }

        /// <summary>
        /// Unique identifier of the user who last modified the relationship role.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby"); }
        }

        /// <summary>
        /// Date and time when the relationship role was last modified.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
        public System.Nullable<System.DateTime> ModifiedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who last modified the relationshiprole.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        /// Name of the relationship role.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("name")]
        public string Name
        {
            get { return this.GetAttributeValue<string>("name"); }
            set
            {
                this.OnPropertyChanging("Name");
                this.SetAttributeValue("name", value);
                this.OnPropertyChanged("Name");
            }
        }

        /// <summary>
        /// Unique Identifier of the organization that this relationship role belongs to.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
        public Microsoft.Xrm.Sdk.EntityReference OrganizationId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("organizationid"); }
        }

        /// <summary>
        /// Unique identifier of the relationship role.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("relationshiproleid")]
        public System.Nullable<System.Guid> RelationshipRoleId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("relationshiproleid"); }
            set
            {
                this.OnPropertyChanging("RelationshipRoleId");
                this.SetAttributeValue("relationshiproleid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("RelationshipRoleId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("relationshiproleid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.RelationshipRoleId = value; }
        }

        /// <summary>
        /// Status of the relationship role.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
        public System.Nullable<RelationshipRoleState> StateCode
        {
            get
            {
                Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
                if ((optionSet != null))
                {
                    return ((RelationshipRoleState) (System.Enum.ToObject(typeof(RelationshipRoleState), optionSet.Value)));
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// Reason for the status of the relationship role.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statuscode")]
        public Microsoft.Xrm.Sdk.OptionSetValue StatusCode
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statuscode"); }
            set
            {
                this.OnPropertyChanging("StatusCode");
                this.SetAttributeValue("statuscode", value);
                this.OnPropertyChanged("StatusCode");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
        public System.Nullable<long> VersionNumber
        {
            get { return this.GetAttributeValue<System.Nullable<long>>("versionnumber"); }
        }

        /// <summary>
        /// 1:N relationship_role_customer_opportunity_roles
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("relationship_role_customer_opportunity_roles")]
        public System.Collections.Generic.IEnumerable<CustomerOpportunityRole> relationship_role_customer_opportunity_roles
        {
            get { return this.GetRelatedEntities<CustomerOpportunityRole>("relationship_role_customer_opportunity_roles", null); }
            set
            {
                this.OnPropertyChanging("relationship_role_customer_opportunity_roles");
                this.SetRelatedEntities<CustomerOpportunityRole>("relationship_role_customer_opportunity_roles", null, value);
                this.OnPropertyChanged("relationship_role_customer_opportunity_roles");
            }
        }

        /// <summary>
        /// 1:N relationship_role_customer_role
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("relationship_role_customer_role")]
        public System.Collections.Generic.IEnumerable<CustomerRelationship> relationship_role_customer_role
        {
            get { return this.GetRelatedEntities<CustomerRelationship>("relationship_role_customer_role", null); }
            set
            {
                this.OnPropertyChanging("relationship_role_customer_role");
                this.SetRelatedEntities<CustomerRelationship>("relationship_role_customer_role", null, value);
                this.OnPropertyChanged("relationship_role_customer_role");
            }
        }

        /// <summary>
        /// 1:N relationship_role_partner_role
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("relationship_role_partner_role")]
        public System.Collections.Generic.IEnumerable<CustomerRelationship> relationship_role_partner_role
        {
            get { return this.GetRelatedEntities<CustomerRelationship>("relationship_role_partner_role", null); }
            set
            {
                this.OnPropertyChanging("relationship_role_partner_role");
                this.SetRelatedEntities<CustomerRelationship>("relationship_role_partner_role", null, value);
                this.OnPropertyChanged("relationship_role_partner_role");
            }
        }

        /// <summary>
        /// 1:N relationship_role_relationship_role_map
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("relationship_role_relationship_role_map")]
        public System.Collections.Generic.IEnumerable<RelationshipRoleMap> relationship_role_relationship_role_map
        {
            get { return this.GetRelatedEntities<RelationshipRoleMap>("relationship_role_relationship_role_map", null); }
            set
            {
                this.OnPropertyChanging("relationship_role_relationship_role_map");
                this.SetRelatedEntities<RelationshipRoleMap>("relationship_role_relationship_role_map", null, value);
                this.OnPropertyChanged("relationship_role_relationship_role_map");
            }
        }

        /// <summary>
        /// 1:N RelationshipRole_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("RelationshipRole_AsyncOperations")]
        public System.Collections.Generic.IEnumerable<AsyncOperation> RelationshipRole_AsyncOperations
        {
            get { return this.GetRelatedEntities<AsyncOperation>("RelationshipRole_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("RelationshipRole_AsyncOperations");
                this.SetRelatedEntities<AsyncOperation>("RelationshipRole_AsyncOperations", null, value);
                this.OnPropertyChanged("RelationshipRole_AsyncOperations");
            }
        }

        /// <summary>
        /// 1:N RelationshipRole_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("RelationshipRole_BulkDeleteFailures")]
        public System.Collections.Generic.IEnumerable<BulkDeleteFailure> RelationshipRole_BulkDeleteFailures
        {
            get { return this.GetRelatedEntities<BulkDeleteFailure>("RelationshipRole_BulkDeleteFailures", null); }
            set
            {
                this.OnPropertyChanging("RelationshipRole_BulkDeleteFailures");
                this.SetRelatedEntities<BulkDeleteFailure>("RelationshipRole_BulkDeleteFailures", null, value);
                this.OnPropertyChanged("RelationshipRole_BulkDeleteFailures");
            }
        }

        /// <summary>
        /// 1:N RelationshipRole_ProcessSessions
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("RelationshipRole_ProcessSessions")]
        public System.Collections.Generic.IEnumerable<ProcessSession> RelationshipRole_ProcessSessions
        {
            get { return this.GetRelatedEntities<ProcessSession>("RelationshipRole_ProcessSessions", null); }
            set
            {
                this.OnPropertyChanging("RelationshipRole_ProcessSessions");
                this.SetRelatedEntities<ProcessSession>("RelationshipRole_ProcessSessions", null, value);
                this.OnPropertyChanged("RelationshipRole_ProcessSessions");
            }
        }

        /// <summary>
        /// 1:N userentityinstancedata_relationshiprole
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_relationshiprole")]
        public System.Collections.Generic.IEnumerable<UserEntityInstanceData> userentityinstancedata_relationshiprole
        {
            get { return this.GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_relationshiprole", null); }
            set
            {
                this.OnPropertyChanging("userentityinstancedata_relationshiprole");
                this.SetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_relationshiprole", null, value);
                this.OnPropertyChanged("userentityinstancedata_relationshiprole");
            }
        }

        /// <summary>
        /// N:1 createdby_relationship_role
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("createdby_relationship_role")]
        public SystemUser createdby_relationship_role
        {
            get { return this.GetRelatedEntity<SystemUser>("createdby_relationship_role", null); }
        }

        /// <summary>
        /// N:1 lk_relationshiprole_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_relationshiprole_createdonbehalfby")]
        public SystemUser lk_relationshiprole_createdonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_relationshiprole_createdonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_relationshiprole_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_relationshiprole_modifiedonbehalfby")]
        public SystemUser lk_relationshiprole_modifiedonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_relationshiprole_modifiedonbehalfby", null); }
        }

        /// <summary>
        /// N:1 modifiedby_relationship_role
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("modifiedby_relationship_role")]
        public SystemUser modifiedby_relationship_role
        {
            get { return this.GetRelatedEntity<SystemUser>("modifiedby_relationship_role", null); }
        }

        /// <summary>
        /// N:1 organization_relationship_roles
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_relationship_roles")]
        public Organization organization_relationship_roles
        {
            get { return this.GetRelatedEntity<Organization>("organization_relationship_roles", null); }
        }
    }
}