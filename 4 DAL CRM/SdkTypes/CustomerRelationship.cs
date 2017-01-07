using _4_DAL_CRM;

namespace __4_DAL_CRM
{
    /// <summary>
    /// Relationship between a customer and a partner in which either can be an account or contact.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("customerrelationship")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class CustomerRelationship : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public CustomerRelationship() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "customerrelationship";

        public const int EntityTypeCode = 4502;

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
        /// Unique identifier of the converse relationship of the customer relationship.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("converserelationshipid")]
        public Microsoft.Xrm.Sdk.EntityReference ConverseRelationshipId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("converserelationshipid"); }
            set
            {
                this.OnPropertyChanging("ConverseRelationshipId");
                this.SetAttributeValue("converserelationshipid", value);
                this.OnPropertyChanged("ConverseRelationshipId");
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
        /// Shows the date and time when the customer relationship was created. The date and time are displayed in the time zone selected in Microsoft Dynamics CRM options.
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
        /// Select the primary account or contact involved in the customer relationship.
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
        /// Unique identifier of the customer relationship.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("customerrelationshipid")]
        public System.Nullable<System.Guid> CustomerRelationshipId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("customerrelationshipid"); }
            set
            {
                this.OnPropertyChanging("CustomerRelationshipId");
                this.SetAttributeValue("customerrelationshipid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("CustomerRelationshipId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("customerrelationshipid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.CustomerRelationshipId = value; }
        }

        /// <summary>
        /// Type additional information about the primary party's role in the customer relationship, such as the length or quality of the relationship.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("customerroledescription")]
        public string CustomerRoleDescription
        {
            get { return this.GetAttributeValue<string>("customerroledescription"); }
            set
            {
                this.OnPropertyChanging("CustomerRoleDescription");
                this.SetAttributeValue("customerroledescription", value);
                this.OnPropertyChanged("CustomerRoleDescription");
            }
        }

        /// <summary>
        /// Choose the primary party's role or nature of the relationship the customer has with the second party. The field is read-only until both parties have been selected. Administrators can configure role values under Business Management in the Settings area.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("customerroleid")]
        public Microsoft.Xrm.Sdk.EntityReference CustomerRoleId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("customerroleid"); }
            set
            {
                this.OnPropertyChanging("CustomerRoleId");
                this.SetAttributeValue("customerroleid", value);
                this.OnPropertyChanged("CustomerRoleId");
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
        /// Shows who created the record on behalf of another user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby"); }
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
        /// Enter the user or team who is assigned to manage the record. This field is updated every time the record is assigned to a different user.
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
        /// Unique identifier of the business unit that owns the customer relationship.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
        public Microsoft.Xrm.Sdk.EntityReference OwningBusinessUnit
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningbusinessunit"); }
        }

        /// <summary>
        /// Unique identifier of the team who owns the customer relationship.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
        public Microsoft.Xrm.Sdk.EntityReference OwningTeam
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningteam"); }
        }

        /// <summary>
        /// Unique identifier of the user who owns the customer relationship.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
        public Microsoft.Xrm.Sdk.EntityReference OwningUser
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owninguser"); }
        }

        /// <summary>
        /// Select the secondary account or contact involved in the customer relationship.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("partnerid")]
        public Microsoft.Xrm.Sdk.EntityReference PartnerId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("partnerid"); }
            set
            {
                this.OnPropertyChanging("PartnerId");
                this.SetAttributeValue("partnerid", value);
                this.OnPropertyChanged("PartnerId");
            }
        }

        /// <summary>
        /// Type additional information about the secondary party's role in the customer relationship, such as the length or quality of the relationship.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("partnerroledescription")]
        public string PartnerRoleDescription
        {
            get { return this.GetAttributeValue<string>("partnerroledescription"); }
            set
            {
                this.OnPropertyChanging("PartnerRoleDescription");
                this.SetAttributeValue("partnerroledescription", value);
                this.OnPropertyChanged("PartnerRoleDescription");
            }
        }

        /// <summary>
        /// Choose the secondary party's role or nature of the relationship the customer has with the primary party. The field is read-only until both parties have been selected. Administrators can configure role values under Business Management in the Settings area.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("partnerroleid")]
        public Microsoft.Xrm.Sdk.EntityReference PartnerRoleId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("partnerroleid"); }
            set
            {
                this.OnPropertyChanging("PartnerRoleId");
                this.SetAttributeValue("partnerroleid", value);
                this.OnPropertyChanged("PartnerRoleId");
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
        /// 1:N customer_relationship_converse_relationship
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("customer_relationship_converse_relationship", Microsoft.Xrm.Sdk.EntityRole.Referenced)]
        public System.Collections.Generic.IEnumerable<CustomerRelationship> Referencedcustomer_relationship_converse_relationship
        {
            get { return this.GetRelatedEntities<CustomerRelationship>("customer_relationship_converse_relationship", Microsoft.Xrm.Sdk.EntityRole.Referenced); }
            set
            {
                this.OnPropertyChanging("Referencedcustomer_relationship_converse_relationship");
                this.SetRelatedEntities<CustomerRelationship>("customer_relationship_converse_relationship", Microsoft.Xrm.Sdk.EntityRole.Referenced, value);
                this.OnPropertyChanged("Referencedcustomer_relationship_converse_relationship");
            }
        }

        /// <summary>
        /// 1:N CustomerRelationship_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("CustomerRelationship_AsyncOperations")]
        public System.Collections.Generic.IEnumerable<AsyncOperation> CustomerRelationship_AsyncOperations
        {
            get { return this.GetRelatedEntities<AsyncOperation>("CustomerRelationship_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("CustomerRelationship_AsyncOperations");
                this.SetRelatedEntities<AsyncOperation>("CustomerRelationship_AsyncOperations", null, value);
                this.OnPropertyChanged("CustomerRelationship_AsyncOperations");
            }
        }

        /// <summary>
        /// 1:N CustomerRelationship_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("CustomerRelationship_BulkDeleteFailures")]
        public System.Collections.Generic.IEnumerable<BulkDeleteFailure> CustomerRelationship_BulkDeleteFailures
        {
            get { return this.GetRelatedEntities<BulkDeleteFailure>("CustomerRelationship_BulkDeleteFailures", null); }
            set
            {
                this.OnPropertyChanging("CustomerRelationship_BulkDeleteFailures");
                this.SetRelatedEntities<BulkDeleteFailure>("CustomerRelationship_BulkDeleteFailures", null, value);
                this.OnPropertyChanged("CustomerRelationship_BulkDeleteFailures");
            }
        }

        /// <summary>
        /// 1:N CustomerRelationship_ProcessSessions
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("CustomerRelationship_ProcessSessions")]
        public System.Collections.Generic.IEnumerable<ProcessSession> CustomerRelationship_ProcessSessions
        {
            get { return this.GetRelatedEntities<ProcessSession>("CustomerRelationship_ProcessSessions", null); }
            set
            {
                this.OnPropertyChanging("CustomerRelationship_ProcessSessions");
                this.SetRelatedEntities<ProcessSession>("CustomerRelationship_ProcessSessions", null, value);
                this.OnPropertyChanged("CustomerRelationship_ProcessSessions");
            }
        }

        /// <summary>
        /// 1:N userentityinstancedata_customerrelationship
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_customerrelationship")]
        public System.Collections.Generic.IEnumerable<UserEntityInstanceData> userentityinstancedata_customerrelationship
        {
            get { return this.GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_customerrelationship", null); }
            set
            {
                this.OnPropertyChanging("userentityinstancedata_customerrelationship");
                this.SetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_customerrelationship", null, value);
                this.OnPropertyChanged("userentityinstancedata_customerrelationship");
            }
        }

        /// <summary>
        /// N:1 account_customer_relationship_customer
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("customerid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("account_customer_relationship_customer")]
        public Account account_customer_relationship_customer
        {
            get { return this.GetRelatedEntity<Account>("account_customer_relationship_customer", null); }
            set
            {
                this.OnPropertyChanging("account_customer_relationship_customer");
                this.SetRelatedEntity<Account>("account_customer_relationship_customer", null, value);
                this.OnPropertyChanged("account_customer_relationship_customer");
            }
        }

        /// <summary>
        /// N:1 account_customer_relationship_partner
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("partnerid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("account_customer_relationship_partner")]
        public Account account_customer_relationship_partner
        {
            get { return this.GetRelatedEntity<Account>("account_customer_relationship_partner", null); }
            set
            {
                this.OnPropertyChanging("account_customer_relationship_partner");
                this.SetRelatedEntity<Account>("account_customer_relationship_partner", null, value);
                this.OnPropertyChanged("account_customer_relationship_partner");
            }
        }

        /// <summary>
        /// N:1 business_unit_customer_relationship
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_customer_relationship")]
        public BusinessUnit business_unit_customer_relationship
        {
            get { return this.GetRelatedEntity<BusinessUnit>("business_unit_customer_relationship", null); }
        }

        /// <summary>
        /// N:1 contact_customer_relationship_customer
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("customerid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("contact_customer_relationship_customer")]
        public Contact contact_customer_relationship_customer
        {
            get { return this.GetRelatedEntity<Contact>("contact_customer_relationship_customer", null); }
            set
            {
                this.OnPropertyChanging("contact_customer_relationship_customer");
                this.SetRelatedEntity<Contact>("contact_customer_relationship_customer", null, value);
                this.OnPropertyChanged("contact_customer_relationship_customer");
            }
        }

        /// <summary>
        /// N:1 contact_customer_relationship_partner
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("partnerid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("contact_customer_relationship_partner")]
        public Contact contact_customer_relationship_partner
        {
            get { return this.GetRelatedEntity<Contact>("contact_customer_relationship_partner", null); }
            set
            {
                this.OnPropertyChanging("contact_customer_relationship_partner");
                this.SetRelatedEntity<Contact>("contact_customer_relationship_partner", null, value);
                this.OnPropertyChanged("contact_customer_relationship_partner");
            }
        }

        /// <summary>
        /// N:1 createdby_customer_relationship
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("createdby_customer_relationship")]
        public SystemUser createdby_customer_relationship
        {
            get { return this.GetRelatedEntity<SystemUser>("createdby_customer_relationship", null); }
        }

        /// <summary>
        /// N:1 createdonbehalfby_customer_relationship
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("createdonbehalfby_customer_relationship")]
        public SystemUser createdonbehalfby_customer_relationship
        {
            get { return this.GetRelatedEntity<SystemUser>("createdonbehalfby_customer_relationship", null); }
        }

        /// <summary>
        /// N:1 customer_relationship_converse_relationship
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("converserelationshipid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("customer_relationship_converse_relationship", Microsoft.Xrm.Sdk.EntityRole.Referencing)]
        public CustomerRelationship Referencingcustomer_relationship_converse_relationship
        {
            get { return this.GetRelatedEntity<CustomerRelationship>("customer_relationship_converse_relationship", Microsoft.Xrm.Sdk.EntityRole.Referencing); }
            set
            {
                this.OnPropertyChanging("Referencingcustomer_relationship_converse_relationship");
                this.SetRelatedEntity<CustomerRelationship>("customer_relationship_converse_relationship", Microsoft.Xrm.Sdk.EntityRole.Referencing, value);
                this.OnPropertyChanged("Referencingcustomer_relationship_converse_relationship");
            }
        }

        /// <summary>
        /// N:1 modifiedby_customer_relationship
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("modifiedby_customer_relationship")]
        public SystemUser modifiedby_customer_relationship
        {
            get { return this.GetRelatedEntity<SystemUser>("modifiedby_customer_relationship", null); }
        }

        /// <summary>
        /// N:1 modifiedonbehalfby_customer_relationship
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("modifiedonbehalfby_customer_relationship")]
        public SystemUser modifiedonbehalfby_customer_relationship
        {
            get { return this.GetRelatedEntity<SystemUser>("modifiedonbehalfby_customer_relationship", null); }
        }

        /// <summary>
        /// N:1 relationship_role_customer_role
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("customerroleid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("relationship_role_customer_role")]
        public RelationshipRole relationship_role_customer_role
        {
            get { return this.GetRelatedEntity<RelationshipRole>("relationship_role_customer_role", null); }
            set
            {
                this.OnPropertyChanging("relationship_role_customer_role");
                this.SetRelatedEntity<RelationshipRole>("relationship_role_customer_role", null, value);
                this.OnPropertyChanged("relationship_role_customer_role");
            }
        }

        /// <summary>
        /// N:1 relationship_role_partner_role
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("partnerroleid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("relationship_role_partner_role")]
        public RelationshipRole relationship_role_partner_role
        {
            get { return this.GetRelatedEntity<RelationshipRole>("relationship_role_partner_role", null); }
            set
            {
                this.OnPropertyChanging("relationship_role_partner_role");
                this.SetRelatedEntity<RelationshipRole>("relationship_role_partner_role", null, value);
                this.OnPropertyChanged("relationship_role_partner_role");
            }
        }

        /// <summary>
        /// N:1 team_customer_relationship
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_customer_relationship")]
        public Team team_customer_relationship
        {
            get { return this.GetRelatedEntity<Team>("team_customer_relationship", null); }
        }

        /// <summary>
        /// N:1 user_customer_relationship
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_customer_relationship")]
        public SystemUser user_customer_relationship
        {
            get { return this.GetRelatedEntity<SystemUser>("user_customer_relationship", null); }
        }
    }
}