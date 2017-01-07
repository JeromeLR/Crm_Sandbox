namespace __4_DAL_CRM
{
    /// <summary>
    /// Defines the amount and type of support for a channel.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("entitlementchannel")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class EntitlementChannel : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public EntitlementChannel() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "entitlementchannel";

        public const int EntityTypeCode = 9701;

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
        /// Select a channel for which you are defining the entitlement terms.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("channel")]
        public Microsoft.Xrm.Sdk.OptionSetValue Channel
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("channel"); }
            set
            {
                this.OnPropertyChanging("Channel");
                this.SetAttributeValue("channel", value);
                this.OnPropertyChanged("Channel");
            }
        }

        /// <summary>
        /// Unique identifier of the user who created the record.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby"); }
        }

        /// <summary>
        /// Date and time when the entitlement was created.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
        public System.Nullable<System.DateTime> CreatedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who created the record.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        /// Unique identifier for entity instances
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entitlementchannelid")]
        public System.Nullable<System.Guid> EntitlementChannelId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("entitlementchannelid"); }
            set
            {
                this.OnPropertyChanging("EntitlementChannelId");
                this.SetAttributeValue("entitlementchannelid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("EntitlementChannelId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entitlementchannelid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.EntitlementChannelId = value; }
        }

        /// <summary>
        /// Unique identifier for Entitlement associated with Entitlement Channel.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entitlementid")]
        public Microsoft.Xrm.Sdk.EntityReference EntitlementId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("entitlementid"); }
            set
            {
                this.OnPropertyChanging("EntitlementId");
                this.SetAttributeValue("entitlementid", value);
                this.OnPropertyChanged("EntitlementId");
            }
        }

        /// <summary>
        /// Exchange rate for the currency associated with the incident with respect to the base currency.
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
        /// Unique identifier of the user who modified the record.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby"); }
        }

        /// <summary>
        /// Date and time when the record was modified.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
        public System.Nullable<System.DateTime> ModifiedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who modified the record.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        /// The name of the custom entity.
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
        /// Unique identifier of the organization with which the entitlement channel is associated.
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
        /// Unique identifier of the user or team who owns the entitlement channel.
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
        /// Unique identifier for the business unit that owns the record
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
        public Microsoft.Xrm.Sdk.EntityReference OwningBusinessUnit
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningbusinessunit"); }
        }

        /// <summary>
        /// Unique identifier for the user that owns the record.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
        public Microsoft.Xrm.Sdk.EntityReference OwningUser
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owninguser"); }
        }

        /// <summary>
        /// Type the total number of entitlement terms that are left.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("remainingterms")]
        public System.Nullable<decimal> RemainingTerms
        {
            get { return this.GetAttributeValue<System.Nullable<decimal>>("remainingterms"); }
            set
            {
                this.OnPropertyChanging("RemainingTerms");
                this.SetAttributeValue("remainingterms", value);
                this.OnPropertyChanged("RemainingTerms");
            }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("timezoneruleversionnumber")]
        public System.Nullable<int> TimeZoneRuleVersionNumber
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("timezoneruleversionnumber"); }
            set
            {
                this.OnPropertyChanging("TimeZoneRuleVersionNumber");
                this.SetAttributeValue("timezoneruleversionnumber", value);
                this.OnPropertyChanged("TimeZoneRuleVersionNumber");
            }
        }

        /// <summary>
        /// Type the total number of entitlement terms.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("totalterms")]
        public System.Nullable<decimal> TotalTerms
        {
            get { return this.GetAttributeValue<System.Nullable<decimal>>("totalterms"); }
            set
            {
                this.OnPropertyChanging("TotalTerms");
                this.SetAttributeValue("totalterms", value);
                this.OnPropertyChanged("TotalTerms");
            }
        }

        /// <summary>
        /// Unique identifier of the currency associated with the incident.
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
        /// Time zone code that was in use when the record was created.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("utcconversiontimezonecode")]
        public System.Nullable<int> UTCConversionTimeZoneCode
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("utcconversiontimezonecode"); }
            set
            {
                this.OnPropertyChanging("UTCConversionTimeZoneCode");
                this.SetAttributeValue("utcconversiontimezonecode", value);
                this.OnPropertyChanged("UTCConversionTimeZoneCode");
            }
        }

        /// <summary>
        /// Version number of the entitlement channel item.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
        public System.Nullable<long> VersionNumber
        {
            get { return this.GetAttributeValue<System.Nullable<long>>("versionnumber"); }
        }

        /// <summary>
        /// 1:N entitlementchannel_Annotations
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("entitlementchannel_Annotations")]
        public System.Collections.Generic.IEnumerable<Annotation> entitlementchannel_Annotations
        {
            get { return this.GetRelatedEntities<Annotation>("entitlementchannel_Annotations", null); }
            set
            {
                this.OnPropertyChanging("entitlementchannel_Annotations");
                this.SetRelatedEntities<Annotation>("entitlementchannel_Annotations", null, value);
                this.OnPropertyChanged("entitlementchannel_Annotations");
            }
        }

        /// <summary>
        /// 1:N entitlementchannel_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("entitlementchannel_AsyncOperations")]
        public System.Collections.Generic.IEnumerable<AsyncOperation> entitlementchannel_AsyncOperations
        {
            get { return this.GetRelatedEntities<AsyncOperation>("entitlementchannel_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("entitlementchannel_AsyncOperations");
                this.SetRelatedEntities<AsyncOperation>("entitlementchannel_AsyncOperations", null, value);
                this.OnPropertyChanged("entitlementchannel_AsyncOperations");
            }
        }

        /// <summary>
        /// 1:N entitlementchannel_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("entitlementchannel_BulkDeleteFailures")]
        public System.Collections.Generic.IEnumerable<BulkDeleteFailure> entitlementchannel_BulkDeleteFailures
        {
            get { return this.GetRelatedEntities<BulkDeleteFailure>("entitlementchannel_BulkDeleteFailures", null); }
            set
            {
                this.OnPropertyChanging("entitlementchannel_BulkDeleteFailures");
                this.SetRelatedEntities<BulkDeleteFailure>("entitlementchannel_BulkDeleteFailures", null, value);
                this.OnPropertyChanged("entitlementchannel_BulkDeleteFailures");
            }
        }

        /// <summary>
        /// 1:N entitlementchannel_DuplicateBaseRecord
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("entitlementchannel_DuplicateBaseRecord")]
        public System.Collections.Generic.IEnumerable<DuplicateRecord> entitlementchannel_DuplicateBaseRecord
        {
            get { return this.GetRelatedEntities<DuplicateRecord>("entitlementchannel_DuplicateBaseRecord", null); }
            set
            {
                this.OnPropertyChanging("entitlementchannel_DuplicateBaseRecord");
                this.SetRelatedEntities<DuplicateRecord>("entitlementchannel_DuplicateBaseRecord", null, value);
                this.OnPropertyChanged("entitlementchannel_DuplicateBaseRecord");
            }
        }

        /// <summary>
        /// 1:N entitlementchannel_DuplicateMatchingRecord
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("entitlementchannel_DuplicateMatchingRecord")]
        public System.Collections.Generic.IEnumerable<DuplicateRecord> entitlementchannel_DuplicateMatchingRecord
        {
            get { return this.GetRelatedEntities<DuplicateRecord>("entitlementchannel_DuplicateMatchingRecord", null); }
            set
            {
                this.OnPropertyChanging("entitlementchannel_DuplicateMatchingRecord");
                this.SetRelatedEntities<DuplicateRecord>("entitlementchannel_DuplicateMatchingRecord", null, value);
                this.OnPropertyChanged("entitlementchannel_DuplicateMatchingRecord");
            }
        }

        /// <summary>
        /// 1:N entitlementchannel_ProcessSession
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("entitlementchannel_ProcessSession")]
        public System.Collections.Generic.IEnumerable<ProcessSession> entitlementchannel_ProcessSession
        {
            get { return this.GetRelatedEntities<ProcessSession>("entitlementchannel_ProcessSession", null); }
            set
            {
                this.OnPropertyChanging("entitlementchannel_ProcessSession");
                this.SetRelatedEntities<ProcessSession>("entitlementchannel_ProcessSession", null, value);
                this.OnPropertyChanged("entitlementchannel_ProcessSession");
            }
        }

        /// <summary>
        /// 1:N entitlementchannel_UserEntityInstanceDatas
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("entitlementchannel_UserEntityInstanceDatas")]
        public System.Collections.Generic.IEnumerable<UserEntityInstanceData> entitlementchannel_UserEntityInstanceDatas
        {
            get { return this.GetRelatedEntities<UserEntityInstanceData>("entitlementchannel_UserEntityInstanceDatas", null); }
            set
            {
                this.OnPropertyChanging("entitlementchannel_UserEntityInstanceDatas");
                this.SetRelatedEntities<UserEntityInstanceData>("entitlementchannel_UserEntityInstanceDatas", null, value);
                this.OnPropertyChanged("entitlementchannel_UserEntityInstanceDatas");
            }
        }

        /// <summary>
        /// N:1 entitlement_entitlementchannel_EntitlementId
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entitlementid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("entitlement_entitlementchannel_EntitlementId")]
        public Entitlement entitlement_entitlementchannel_EntitlementId
        {
            get { return this.GetRelatedEntity<Entitlement>("entitlement_entitlementchannel_EntitlementId", null); }
            set
            {
                this.OnPropertyChanging("entitlement_entitlementchannel_EntitlementId");
                this.SetRelatedEntity<Entitlement>("entitlement_entitlementchannel_EntitlementId", null, value);
                this.OnPropertyChanged("entitlement_entitlementchannel_EntitlementId");
            }
        }

        /// <summary>
        /// N:1 entitlementchannel_organization
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("entitlementchannel_organization")]
        public Organization entitlementchannel_organization
        {
            get { return this.GetRelatedEntity<Organization>("entitlementchannel_organization", null); }
        }

        /// <summary>
        /// N:1 lk_entitlementchannel_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_entitlementchannel_createdby")]
        public SystemUser lk_entitlementchannel_createdby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_entitlementchannel_createdby", null); }
        }

        /// <summary>
        /// N:1 lk_entitlementchannel_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_entitlementchannel_createdonbehalfby")]
        public SystemUser lk_entitlementchannel_createdonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_entitlementchannel_createdonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_entitlementchannel_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_entitlementchannel_modifiedby")]
        public SystemUser lk_entitlementchannel_modifiedby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_entitlementchannel_modifiedby", null); }
        }

        /// <summary>
        /// N:1 lk_entitlementchannel_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_entitlementchannel_modifiedonbehalfby")]
        public SystemUser lk_entitlementchannel_modifiedonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_entitlementchannel_modifiedonbehalfby", null); }
        }

        /// <summary>
        /// N:1 TransactionCurrency_entitlementchannel
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("TransactionCurrency_entitlementchannel")]
        public TransactionCurrency TransactionCurrency_entitlementchannel
        {
            get { return this.GetRelatedEntity<TransactionCurrency>("TransactionCurrency_entitlementchannel", null); }
            set
            {
                this.OnPropertyChanging("TransactionCurrency_entitlementchannel");
                this.SetRelatedEntity<TransactionCurrency>("TransactionCurrency_entitlementchannel", null, value);
                this.OnPropertyChanged("TransactionCurrency_entitlementchannel");
            }
        }
    }
}