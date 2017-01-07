namespace __4_DAL_CRM
{
    /// <summary>
    /// Contains predefined support terms for a channel to create entitlements for customers.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("entitlementtemplatechannel")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class EntitlementTemplateChannel : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public EntitlementTemplateChannel() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "entitlementtemplatechannel";

        public const int EntityTypeCode = 9703;

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
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entitlementtemplatechannelid")]
        public System.Nullable<System.Guid> EntitlementTemplateChannelId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("entitlementtemplatechannelid"); }
            set
            {
                this.OnPropertyChanging("EntitlementTemplateChannelId");
                this.SetAttributeValue("entitlementtemplatechannelid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("EntitlementTemplateChannelId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entitlementtemplatechannelid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.EntitlementTemplateChannelId = value; }
        }

        /// <summary>
        /// Unique identifier for Entitlement Template associated with Entitlement Template Channel.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entitlementtemplateid")]
        public Microsoft.Xrm.Sdk.EntityReference EntitlementTemplateId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("entitlementtemplateid"); }
            set
            {
                this.OnPropertyChanging("EntitlementTemplateId");
                this.SetAttributeValue("entitlementtemplateid", value);
                this.OnPropertyChanged("EntitlementTemplateId");
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
        /// Unique identifier of the organization with which the entitlement template channel is associated.
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
        /// Version number of the entitlement template channel item.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
        public System.Nullable<long> VersionNumber
        {
            get { return this.GetAttributeValue<System.Nullable<long>>("versionnumber"); }
        }

        /// <summary>
        /// N:1 entitlementtemplate_entitlementchannel_entitlementtemplateid
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entitlementtemplateid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("entitlementtemplate_entitlementchannel_entitlementtemplateid")]
        public EntitlementTemplate entitlementtemplate_entitlementchannel_entitlementtemplateid
        {
            get { return this.GetRelatedEntity<EntitlementTemplate>("entitlementtemplate_entitlementchannel_entitlementtemplateid", null); }
            set
            {
                this.OnPropertyChanging("entitlementtemplate_entitlementchannel_entitlementtemplateid");
                this.SetRelatedEntity<EntitlementTemplate>("entitlementtemplate_entitlementchannel_entitlementtemplateid", null, value);
                this.OnPropertyChanged("entitlementtemplate_entitlementchannel_entitlementtemplateid");
            }
        }

        /// <summary>
        /// N:1 entitlementtemplatechannel_organization
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("entitlementtemplatechannel_organization")]
        public Organization entitlementtemplatechannel_organization
        {
            get { return this.GetRelatedEntity<Organization>("entitlementtemplatechannel_organization", null); }
        }

        /// <summary>
        /// N:1 lk_entitlementtemplatechannel_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_entitlementtemplatechannel_createdby")]
        public SystemUser lk_entitlementtemplatechannel_createdby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_entitlementtemplatechannel_createdby", null); }
        }

        /// <summary>
        /// N:1 lk_entitlementtemplatechannel_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_entitlementtemplatechannel_createdonbehalfby")]
        public SystemUser lk_entitlementtemplatechannel_createdonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_entitlementtemplatechannel_createdonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_entitlementtemplatechannel_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_entitlementtemplatechannel_modifiedby")]
        public SystemUser lk_entitlementtemplatechannel_modifiedby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_entitlementtemplatechannel_modifiedby", null); }
        }

        /// <summary>
        /// N:1 lk_entitlementtemplatechannel_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_entitlementtemplatechannel_modifiedonbehalfby")]
        public SystemUser lk_entitlementtemplatechannel_modifiedonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_entitlementtemplatechannel_modifiedonbehalfby", null); }
        }

        /// <summary>
        /// N:1 TransactionCurrency_entitlementtemplatechannel
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("TransactionCurrency_entitlementtemplatechannel")]
        public TransactionCurrency TransactionCurrency_entitlementtemplatechannel
        {
            get { return this.GetRelatedEntity<TransactionCurrency>("TransactionCurrency_entitlementtemplatechannel", null); }
            set
            {
                this.OnPropertyChanging("TransactionCurrency_entitlementtemplatechannel");
                this.SetRelatedEntity<TransactionCurrency>("TransactionCurrency_entitlementtemplatechannel", null, value);
                this.OnPropertyChanged("TransactionCurrency_entitlementtemplatechannel");
            }
        }
    }
}