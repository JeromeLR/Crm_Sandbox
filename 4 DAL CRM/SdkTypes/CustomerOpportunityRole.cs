using _4_DAL_CRM;

namespace __4_DAL_CRM
{
    /// <summary>
    /// Relationship between an account or contact and an opportunity.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("customeropportunityrole")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class CustomerOpportunityRole : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public CustomerOpportunityRole() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "customeropportunityrole";

        public const int EntityTypeCode = 4503;

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
        /// Shows who created the record.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby"); }
        }

        /// <summary>
        /// Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics CRM options.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
        public System.Nullable<System.DateTime> CreatedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon"); }
        }

        /// <summary>
        /// Shows who created the record on behalf of another user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        /// Select the account or contact associated to the opportunity, such as a strategic partner, third-party vendor, or key decision maker.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("customerid")]
        public Microsoft.Xrm.Sdk.EntityReference CustomerId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("customerid"); }
            set
            {
                this.OnPropertyChanging("CustomerId");
                this.SetAttributeValue("customerid", value);
                this.OnPropertyChanged("CustomerId");
            }
        }

        /// <summary>
        /// Unique identifier of the opportunity relationship.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("customeropportunityroleid")]
        public System.Nullable<System.Guid> CustomerOpportunityRoleId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("customeropportunityroleid"); }
            set
            {
                this.OnPropertyChanging("CustomerOpportunityRoleId");
                this.SetAttributeValue("customeropportunityroleid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("CustomerOpportunityRoleId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("customeropportunityroleid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.CustomerOpportunityRoleId = value; }
        }

        /// <summary>
        /// Type additional information to describe the opportunity relationship, such as the length or quality of the relationship.
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
        /// Shows who last updated the record.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby"); }
        }

        /// <summary>
        /// Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics CRM options.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
        public System.Nullable<System.DateTime> ModifiedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon"); }
        }

        /// <summary>
        /// Shows who last updated the record on behalf of another user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        /// Choose the opportunity that the specified account or contact is related to. The opportunity relationship will be displayed in the Relationships view on the selected opportunity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("opportunityid")]
        public Microsoft.Xrm.Sdk.EntityReference OpportunityId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("opportunityid"); }
            set
            {
                this.OnPropertyChanging("OpportunityId");
                this.SetAttributeValue("opportunityid", value);
                this.OnPropertyChanged("OpportunityId");
            }
        }

        /// <summary>
        /// Choose the role or nature of the relationship that the customer has with the opportunity. The field is read-only until a customer has been selected. Administrators can configure role values under Business Management in the Settings area.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("opportunityroleid")]
        public Microsoft.Xrm.Sdk.EntityReference OpportunityRoleId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("opportunityroleid"); }
            set
            {
                this.OnPropertyChanging("OpportunityRoleId");
                this.SetAttributeValue("opportunityroleid", value);
                this.OnPropertyChanged("OpportunityRoleId");
            }
        }

        /// <summary>
        /// Status of the opportunity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("opportunitystatecode")]
        public System.Nullable<int> OpportunityStateCode
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("opportunitystatecode"); }
        }

        /// <summary>
        /// Reason for the status of the opportunity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("opportunitystatuscode")]
        public System.Nullable<int> OpportunityStatusCode
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("opportunitystatuscode"); }
        }

        /// <summary>
        /// Date and time that the record was migrated.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("overriddencreatedon")]
        public System.Nullable<System.DateTime> OverriddenCreatedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("overriddencreatedon"); }
            set
            {
                this.OnPropertyChanging("OverriddenCreatedOn");
                this.SetAttributeValue("overriddencreatedon", value);
                this.OnPropertyChanged("OverriddenCreatedOn");
            }
        }

        /// <summary>
        /// Unique identifier of the user or team who owns the customer opportunity role.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ownerid")]
        public Microsoft.Xrm.Sdk.EntityReference OwnerId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("ownerid"); }
            set
            {
                this.OnPropertyChanging("OwnerId");
                this.SetAttributeValue("ownerid", value);
                this.OnPropertyChanged("OwnerId");
            }
        }

        /// <summary>
        /// Unique identifier for the business unit that owns the customer opportunity role.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
        public Microsoft.Xrm.Sdk.EntityReference OwningBusinessUnit
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningbusinessunit"); }
        }

        /// <summary>
        /// Unique identifier of the team who owns the customer opportunity role.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
        public Microsoft.Xrm.Sdk.EntityReference OwningTeam
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningteam"); }
        }

        /// <summary>
        /// Unique identifier of the user who owns the customer opportunity role.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
        public Microsoft.Xrm.Sdk.EntityReference OwningUser
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owninguser"); }
        }

        /// <summary>
        /// Version number of the customer opportunity role.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
        public System.Nullable<long> VersionNumber
        {
            get { return this.GetAttributeValue<System.Nullable<long>>("versionnumber"); }
        }

        /// <summary>
        /// 1:N CustomerOpportunityRole_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("CustomerOpportunityRole_AsyncOperations")]
        public System.Collections.Generic.IEnumerable<AsyncOperation> CustomerOpportunityRole_AsyncOperations
        {
            get { return this.GetRelatedEntities<AsyncOperation>("CustomerOpportunityRole_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("CustomerOpportunityRole_AsyncOperations");
                this.SetRelatedEntities<AsyncOperation>("CustomerOpportunityRole_AsyncOperations", null, value);
                this.OnPropertyChanged("CustomerOpportunityRole_AsyncOperations");
            }
        }

        /// <summary>
        /// 1:N CustomerOpportunityRole_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("CustomerOpportunityRole_BulkDeleteFailures")]
        public System.Collections.Generic.IEnumerable<BulkDeleteFailure> CustomerOpportunityRole_BulkDeleteFailures
        {
            get { return this.GetRelatedEntities<BulkDeleteFailure>("CustomerOpportunityRole_BulkDeleteFailures", null); }
            set
            {
                this.OnPropertyChanging("CustomerOpportunityRole_BulkDeleteFailures");
                this.SetRelatedEntities<BulkDeleteFailure>("CustomerOpportunityRole_BulkDeleteFailures", null, value);
                this.OnPropertyChanged("CustomerOpportunityRole_BulkDeleteFailures");
            }
        }

        /// <summary>
        /// 1:N CustomerOpportunityRole_ProcessSessions
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("CustomerOpportunityRole_ProcessSessions")]
        public System.Collections.Generic.IEnumerable<ProcessSession> CustomerOpportunityRole_ProcessSessions
        {
            get { return this.GetRelatedEntities<ProcessSession>("CustomerOpportunityRole_ProcessSessions", null); }
            set
            {
                this.OnPropertyChanging("CustomerOpportunityRole_ProcessSessions");
                this.SetRelatedEntities<ProcessSession>("CustomerOpportunityRole_ProcessSessions", null, value);
                this.OnPropertyChanged("CustomerOpportunityRole_ProcessSessions");
            }
        }

        /// <summary>
        /// 1:N userentityinstancedata_customeropportunityrole
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_customeropportunityrole")]
        public System.Collections.Generic.IEnumerable<UserEntityInstanceData> userentityinstancedata_customeropportunityrole
        {
            get { return this.GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_customeropportunityrole", null); }
            set
            {
                this.OnPropertyChanging("userentityinstancedata_customeropportunityrole");
                this.SetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_customeropportunityrole", null, value);
                this.OnPropertyChanged("userentityinstancedata_customeropportunityrole");
            }
        }

        /// <summary>
        /// N:1 account_customer_opportunity_roles
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("customerid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("account_customer_opportunity_roles")]
        public Account account_customer_opportunity_roles
        {
            get { return this.GetRelatedEntity<Account>("account_customer_opportunity_roles", null); }
            set
            {
                this.OnPropertyChanging("account_customer_opportunity_roles");
                this.SetRelatedEntity<Account>("account_customer_opportunity_roles", null, value);
                this.OnPropertyChanged("account_customer_opportunity_roles");
            }
        }

        /// <summary>
        /// N:1 business_customer_opportunity_roles
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_customer_opportunity_roles")]
        public BusinessUnit business_customer_opportunity_roles
        {
            get { return this.GetRelatedEntity<BusinessUnit>("business_customer_opportunity_roles", null); }
        }

        /// <summary>
        /// N:1 contact_customer_opportunity_roles
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("customerid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("contact_customer_opportunity_roles")]
        public Contact contact_customer_opportunity_roles
        {
            get { return this.GetRelatedEntity<Contact>("contact_customer_opportunity_roles", null); }
            set
            {
                this.OnPropertyChanging("contact_customer_opportunity_roles");
                this.SetRelatedEntity<Contact>("contact_customer_opportunity_roles", null, value);
                this.OnPropertyChanged("contact_customer_opportunity_roles");
            }
        }

        /// <summary>
        /// N:1 lk_customeropportunityrole_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_customeropportunityrole_createdby")]
        public SystemUser lk_customeropportunityrole_createdby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_customeropportunityrole_createdby", null); }
        }

        /// <summary>
        /// N:1 lk_customeropportunityrole_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_customeropportunityrole_createdonbehalfby")]
        public SystemUser lk_customeropportunityrole_createdonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_customeropportunityrole_createdonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_customeropportunityrole_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_customeropportunityrole_modifiedby")]
        public SystemUser lk_customeropportunityrole_modifiedby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_customeropportunityrole_modifiedby", null); }
        }

        /// <summary>
        /// N:1 lk_customeropportunityrole_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_customeropportunityrole_modifiedonbehalfby")]
        public SystemUser lk_customeropportunityrole_modifiedonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_customeropportunityrole_modifiedonbehalfby", null); }
        }

        /// <summary>
        /// N:1 opportunity_customer_opportunity_roles
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("opportunityid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("opportunity_customer_opportunity_roles")]
        public Opportunity opportunity_customer_opportunity_roles
        {
            get { return this.GetRelatedEntity<Opportunity>("opportunity_customer_opportunity_roles", null); }
            set
            {
                this.OnPropertyChanging("opportunity_customer_opportunity_roles");
                this.SetRelatedEntity<Opportunity>("opportunity_customer_opportunity_roles", null, value);
                this.OnPropertyChanged("opportunity_customer_opportunity_roles");
            }
        }

        /// <summary>
        /// N:1 relationship_role_customer_opportunity_roles
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("opportunityroleid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("relationship_role_customer_opportunity_roles")]
        public RelationshipRole relationship_role_customer_opportunity_roles
        {
            get { return this.GetRelatedEntity<RelationshipRole>("relationship_role_customer_opportunity_roles", null); }
            set
            {
                this.OnPropertyChanging("relationship_role_customer_opportunity_roles");
                this.SetRelatedEntity<RelationshipRole>("relationship_role_customer_opportunity_roles", null, value);
                this.OnPropertyChanged("relationship_role_customer_opportunity_roles");
            }
        }

        /// <summary>
        /// N:1 team_customer_opportunity_roles
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_customer_opportunity_roles")]
        public Team team_customer_opportunity_roles
        {
            get { return this.GetRelatedEntity<Team>("team_customer_opportunity_roles", null); }
        }

        /// <summary>
        /// N:1 user_customer_opportunity_roles
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_customer_opportunity_roles")]
        public SystemUser user_customer_opportunity_roles
        {
            get { return this.GetRelatedEntity<SystemUser>("user_customer_opportunity_roles", null); }
        }
    }
}