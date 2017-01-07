using _4_DAL_CRM;

namespace __4_DAL_CRM
{
    /// <summary>
    /// Territory represents sales regions.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("territory")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class Territory : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public Territory() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "territory";

        public const int EntityTypeCode = 2013;

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
        /// Unique identifier of the user who created the territory.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby"); }
        }

        /// <summary>
        /// Date and time when the territory was created.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
        public System.Nullable<System.DateTime> CreatedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who created the territory.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        /// Description of the territory.
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
        /// The default image for the entity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entityimage")]
        public byte[] EntityImage
        {
            get { return this.GetAttributeValue<byte[]>("entityimage"); }
            set
            {
                this.OnPropertyChanging("EntityImage");
                this.SetAttributeValue("entityimage", value);
                this.OnPropertyChanged("EntityImage");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entityimage_timestamp")]
        public System.Nullable<long> EntityImage_Timestamp
        {
            get { return this.GetAttributeValue<System.Nullable<long>>("entityimage_timestamp"); }
        }

        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entityimage_url")]
        public string EntityImage_URL
        {
            get { return this.GetAttributeValue<string>("entityimage_url"); }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entityimageid")]
        public System.Nullable<System.Guid> EntityImageId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("entityimageid"); }
        }

        /// <summary>
        /// Exchange rate for the currency associated with the territory with respect to the base currency.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("exchangerate")]
        public System.Nullable<decimal> ExchangeRate
        {
            get { return this.GetAttributeValue<System.Nullable<decimal>>("exchangerate"); }
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
        /// Unique identifier of the manager of the territory.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("managerid")]
        public Microsoft.Xrm.Sdk.EntityReference ManagerId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("managerid"); }
            set
            {
                this.OnPropertyChanging("ManagerId");
                this.SetAttributeValue("managerid", value);
                this.OnPropertyChanged("ManagerId");
            }
        }

        /// <summary>
        /// Unique identifier of the user who last modified the territory.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby"); }
        }

        /// <summary>
        /// Date and time when the territory was last modified.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
        public System.Nullable<System.DateTime> ModifiedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who last modified the territory.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        /// Name of the territory.
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
        /// Unique identifier of the organization associated with the territory.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
        public Microsoft.Xrm.Sdk.EntityReference OrganizationId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("organizationid"); }
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
        /// Unique identifier of the territory.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("territoryid")]
        public System.Nullable<System.Guid> TerritoryId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("territoryid"); }
            set
            {
                this.OnPropertyChanging("TerritoryId");
                this.SetAttributeValue("territoryid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("TerritoryId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("territoryid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.TerritoryId = value; }
        }

        /// <summary>
        /// Unique identifier of the currency associated with the territory.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyid")]
        public Microsoft.Xrm.Sdk.EntityReference TransactionCurrencyId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("transactioncurrencyid"); }
            set
            {
                this.OnPropertyChanging("TransactionCurrencyId");
                this.SetAttributeValue("transactioncurrencyid", value);
                this.OnPropertyChanged("TransactionCurrencyId");
            }
        }

        /// <summary>
        /// Version number of the territory.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
        public System.Nullable<long> VersionNumber
        {
            get { return this.GetAttributeValue<System.Nullable<long>>("versionnumber"); }
        }

        /// <summary>
        /// 1:N territory_accounts
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("territory_accounts")]
        public System.Collections.Generic.IEnumerable<Account> territory_accounts
        {
            get { return this.GetRelatedEntities<Account>("territory_accounts", null); }
            set
            {
                this.OnPropertyChanging("territory_accounts");
                this.SetRelatedEntities<Account>("territory_accounts", null, value);
                this.OnPropertyChanged("territory_accounts");
            }
        }

        /// <summary>
        /// 1:N Territory_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Territory_AsyncOperations")]
        public System.Collections.Generic.IEnumerable<AsyncOperation> Territory_AsyncOperations
        {
            get { return this.GetRelatedEntities<AsyncOperation>("Territory_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("Territory_AsyncOperations");
                this.SetRelatedEntities<AsyncOperation>("Territory_AsyncOperations", null, value);
                this.OnPropertyChanged("Territory_AsyncOperations");
            }
        }

        /// <summary>
        /// 1:N Territory_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Territory_BulkDeleteFailures")]
        public System.Collections.Generic.IEnumerable<BulkDeleteFailure> Territory_BulkDeleteFailures
        {
            get { return this.GetRelatedEntities<BulkDeleteFailure>("Territory_BulkDeleteFailures", null); }
            set
            {
                this.OnPropertyChanging("Territory_BulkDeleteFailures");
                this.SetRelatedEntities<BulkDeleteFailure>("Territory_BulkDeleteFailures", null, value);
                this.OnPropertyChanged("Territory_BulkDeleteFailures");
            }
        }

        /// <summary>
        /// 1:N territory_connections1
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("territory_connections1")]
        public System.Collections.Generic.IEnumerable<Connection> territory_connections1
        {
            get { return this.GetRelatedEntities<Connection>("territory_connections1", null); }
            set
            {
                this.OnPropertyChanging("territory_connections1");
                this.SetRelatedEntities<Connection>("territory_connections1", null, value);
                this.OnPropertyChanged("territory_connections1");
            }
        }

        /// <summary>
        /// 1:N territory_connections2
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("territory_connections2")]
        public System.Collections.Generic.IEnumerable<Connection> territory_connections2
        {
            get { return this.GetRelatedEntities<Connection>("territory_connections2", null); }
            set
            {
                this.OnPropertyChanging("territory_connections2");
                this.SetRelatedEntities<Connection>("territory_connections2", null, value);
                this.OnPropertyChanged("territory_connections2");
            }
        }

        /// <summary>
        /// 1:N Territory_DuplicateBaseRecord
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Territory_DuplicateBaseRecord")]
        public System.Collections.Generic.IEnumerable<DuplicateRecord> Territory_DuplicateBaseRecord
        {
            get { return this.GetRelatedEntities<DuplicateRecord>("Territory_DuplicateBaseRecord", null); }
            set
            {
                this.OnPropertyChanging("Territory_DuplicateBaseRecord");
                this.SetRelatedEntities<DuplicateRecord>("Territory_DuplicateBaseRecord", null, value);
                this.OnPropertyChanged("Territory_DuplicateBaseRecord");
            }
        }

        /// <summary>
        /// 1:N Territory_DuplicateMatchingRecord
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Territory_DuplicateMatchingRecord")]
        public System.Collections.Generic.IEnumerable<DuplicateRecord> Territory_DuplicateMatchingRecord
        {
            get { return this.GetRelatedEntities<DuplicateRecord>("Territory_DuplicateMatchingRecord", null); }
            set
            {
                this.OnPropertyChanging("Territory_DuplicateMatchingRecord");
                this.SetRelatedEntities<DuplicateRecord>("Territory_DuplicateMatchingRecord", null, value);
                this.OnPropertyChanged("Territory_DuplicateMatchingRecord");
            }
        }

        /// <summary>
        /// 1:N territory_principalobjectattributeaccess
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("territory_principalobjectattributeaccess")]
        public System.Collections.Generic.IEnumerable<PrincipalObjectAttributeAccess> territory_principalobjectattributeaccess
        {
            get { return this.GetRelatedEntities<PrincipalObjectAttributeAccess>("territory_principalobjectattributeaccess", null); }
            set
            {
                this.OnPropertyChanging("territory_principalobjectattributeaccess");
                this.SetRelatedEntities<PrincipalObjectAttributeAccess>("territory_principalobjectattributeaccess", null, value);
                this.OnPropertyChanged("territory_principalobjectattributeaccess");
            }
        }

        /// <summary>
        /// 1:N Territory_ProcessSessions
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Territory_ProcessSessions")]
        public System.Collections.Generic.IEnumerable<ProcessSession> Territory_ProcessSessions
        {
            get { return this.GetRelatedEntities<ProcessSession>("Territory_ProcessSessions", null); }
            set
            {
                this.OnPropertyChanging("Territory_ProcessSessions");
                this.SetRelatedEntities<ProcessSession>("Territory_ProcessSessions", null, value);
                this.OnPropertyChanged("Territory_ProcessSessions");
            }
        }

        /// <summary>
        /// 1:N territory_system_users
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("territory_system_users")]
        public System.Collections.Generic.IEnumerable<SystemUser> territory_system_users
        {
            get { return this.GetRelatedEntities<SystemUser>("territory_system_users", null); }
            set
            {
                this.OnPropertyChanging("territory_system_users");
                this.SetRelatedEntities<SystemUser>("territory_system_users", null, value);
                this.OnPropertyChanged("territory_system_users");
            }
        }

        /// <summary>
        /// 1:N userentityinstancedata_territory
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_territory")]
        public System.Collections.Generic.IEnumerable<UserEntityInstanceData> userentityinstancedata_territory
        {
            get { return this.GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_territory", null); }
            set
            {
                this.OnPropertyChanging("userentityinstancedata_territory");
                this.SetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_territory", null, value);
                this.OnPropertyChanged("userentityinstancedata_territory");
            }
        }

        /// <summary>
        /// N:1 lk_territory_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_territory_createdonbehalfby")]
        public SystemUser lk_territory_createdonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_territory_createdonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_territory_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_territory_modifiedonbehalfby")]
        public SystemUser lk_territory_modifiedonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_territory_modifiedonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_territorybase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_territorybase_createdby")]
        public SystemUser lk_territorybase_createdby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_territorybase_createdby", null); }
        }

        /// <summary>
        /// N:1 lk_territorybase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_territorybase_modifiedby")]
        public SystemUser lk_territorybase_modifiedby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_territorybase_modifiedby", null); }
        }

        /// <summary>
        /// N:1 organization_territories
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_territories")]
        public Organization organization_territories
        {
            get { return this.GetRelatedEntity<Organization>("organization_territories", null); }
        }

        /// <summary>
        /// N:1 system_user_territories
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("managerid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("system_user_territories")]
        public SystemUser system_user_territories
        {
            get { return this.GetRelatedEntity<SystemUser>("system_user_territories", null); }
            set
            {
                this.OnPropertyChanging("system_user_territories");
                this.SetRelatedEntity<SystemUser>("system_user_territories", null, value);
                this.OnPropertyChanged("system_user_territories");
            }
        }

        /// <summary>
        /// N:1 TransactionCurrency_Territory
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("TransactionCurrency_Territory")]
        public TransactionCurrency TransactionCurrency_Territory
        {
            get { return this.GetRelatedEntity<TransactionCurrency>("TransactionCurrency_Territory", null); }
            set
            {
                this.OnPropertyChanging("TransactionCurrency_Territory");
                this.SetRelatedEntity<TransactionCurrency>("TransactionCurrency_Territory", null, value);
                this.OnPropertyChanged("TransactionCurrency_Territory");
            }
        }
    }
}