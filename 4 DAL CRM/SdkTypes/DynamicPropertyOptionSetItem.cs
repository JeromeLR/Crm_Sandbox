namespace __4_DAL_CRM
{
    /// <summary>
    /// Item with a name and value in a property option set type.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("dynamicpropertyoptionsetitem")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class DynamicPropertyOptionSetItem : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public DynamicPropertyOptionSetItem() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "dynamicpropertyoptionsetitem";

        public const int EntityTypeCode = 1049;

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
        /// Shows the date and time when the record was created.
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
        /// Internal Use Only
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("dmtimportstate")]
        public System.Nullable<int> DMTImportState
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("dmtimportstate"); }
            set
            {
                this.OnPropertyChanging("DMTImportState");
                this.SetAttributeValue("dmtimportstate", value);
                this.OnPropertyChanged("DMTImportState");
            }
        }

        /// <summary>
        /// Shows the property that uses this option set item.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("dynamicpropertyid")]
        public Microsoft.Xrm.Sdk.EntityReference DynamicPropertyId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("dynamicpropertyid"); }
            set
            {
                this.OnPropertyChanging("DynamicPropertyId");
                this.SetAttributeValue("dynamicpropertyid", value);
                this.OnPropertyChanged("DynamicPropertyId");
            }
        }

        /// <summary>
        /// Type additional information about the property option set item.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("dynamicpropertyoptiondescription")]
        public string DynamicPropertyOptionDescription
        {
            get { return this.GetAttributeValue<string>("dynamicpropertyoptiondescription"); }
            set
            {
                this.OnPropertyChanging("DynamicPropertyOptionDescription");
                this.SetAttributeValue("dynamicpropertyoptiondescription", value);
                this.OnPropertyChanged("DynamicPropertyOptionDescription");
            }
        }

        /// <summary>
        /// Type the name of the property option set item.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("dynamicpropertyoptionname")]
        public string DynamicPropertyOptionName
        {
            get { return this.GetAttributeValue<string>("dynamicpropertyoptionname"); }
            set
            {
                this.OnPropertyChanging("DynamicPropertyOptionName");
                this.SetAttributeValue("dynamicpropertyoptionname", value);
                this.OnPropertyChanged("DynamicPropertyOptionName");
            }
        }

        /// <summary>
        /// Shows the unique identifier of the property option set item.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("dynamicpropertyoptionsetvalueid")]
        public System.Nullable<System.Guid> DynamicPropertyOptionSetValueId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("dynamicpropertyoptionsetvalueid"); }
            set
            {
                this.OnPropertyChanging("DynamicPropertyOptionSetValueId");
                this.SetAttributeValue("dynamicpropertyoptionsetvalueid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("DynamicPropertyOptionSetValueId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("dynamicpropertyoptionsetvalueid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.DynamicPropertyOptionSetValueId = value; }
        }

        /// <summary>
        /// Shows the sequence number of the property option set item in the option set. This value determines the order in which option set items are displayed to the user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("dynamicpropertyoptionsetvaluesequencenumber")]
        public System.Nullable<int> DynamicPropertyOptionSetValueSequenceNumber
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("dynamicpropertyoptionsetvaluesequencenumber"); }
            set
            {
                this.OnPropertyChanging("DynamicPropertyOptionSetValueSequenceNumber");
                this.SetAttributeValue("dynamicpropertyoptionsetvaluesequencenumber", value);
                this.OnPropertyChanged("DynamicPropertyOptionSetValueSequenceNumber");
            }
        }

        /// <summary>
        /// Shows the value of the property option set item.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("dynamicpropertyoptionvalue")]
        public System.Nullable<int> DynamicPropertyOptionValue
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("dynamicpropertyoptionvalue"); }
            set
            {
                this.OnPropertyChanging("DynamicPropertyOptionValue");
                this.SetAttributeValue("dynamicpropertyoptionvalue", value);
                this.OnPropertyChanged("DynamicPropertyOptionValue");
            }
        }

        /// <summary>
        /// Shows the conversion rate of the record's currency. The exchange rate is used to convert all money fields in the record from the local currency to the system's default currency.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("exchangerate")]
        public System.Nullable<decimal> ExchangeRate
        {
            get { return this.GetAttributeValue<System.Nullable<decimal>>("exchangerate"); }
        }

        /// <summary>
        /// Shows the data import or data migration that created this record.
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
        /// Shows the date and time when the record was last updated.
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
        /// Shows the organization associated with the record.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
        public Microsoft.Xrm.Sdk.EntityReference OrganizationId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("organizationid"); }
        }

        /// <summary>
        /// Shows the date and time that the record was migrated.
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
        /// Shows the currency associated with the record.
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
        /// Shows the version number of the property option set item.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
        public System.Nullable<long> VersionNumber
        {
            get { return this.GetAttributeValue<System.Nullable<long>>("versionnumber"); }
        }

        /// <summary>
        /// 1:N DefaultValueOptionSet_DynamicProperty
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("DefaultValueOptionSet_DynamicProperty")]
        public System.Collections.Generic.IEnumerable<DynamicProperty> DefaultValueOptionSet_DynamicProperty
        {
            get { return this.GetRelatedEntities<DynamicProperty>("DefaultValueOptionSet_DynamicProperty", null); }
            set
            {
                this.OnPropertyChanging("DefaultValueOptionSet_DynamicProperty");
                this.SetRelatedEntities<DynamicProperty>("DefaultValueOptionSet_DynamicProperty", null, value);
                this.OnPropertyChanged("DefaultValueOptionSet_DynamicProperty");
            }
        }

        /// <summary>
        /// N:1 DynamicProperty_DynamicPropertyOptionSetItem
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("dynamicpropertyid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("DynamicProperty_DynamicPropertyOptionSetItem")]
        public DynamicProperty DynamicProperty_DynamicPropertyOptionSetItem
        {
            get { return this.GetRelatedEntity<DynamicProperty>("DynamicProperty_DynamicPropertyOptionSetItem", null); }
            set
            {
                this.OnPropertyChanging("DynamicProperty_DynamicPropertyOptionSetItem");
                this.SetRelatedEntity<DynamicProperty>("DynamicProperty_DynamicPropertyOptionSetItem", null, value);
                this.OnPropertyChanged("DynamicProperty_DynamicPropertyOptionSetItem");
            }
        }

        /// <summary>
        /// N:1 DynamicPropertyOptionSetItem_organization
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("DynamicPropertyOptionSetItem_organization")]
        public Organization DynamicPropertyOptionSetItem_organization
        {
            get { return this.GetRelatedEntity<Organization>("DynamicPropertyOptionSetItem_organization", null); }
        }

        /// <summary>
        /// N:1 DynamicPropertyOptionSetItem_TransactionCurrency
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("DynamicPropertyOptionSetItem_TransactionCurrency")]
        public TransactionCurrency DynamicPropertyOptionSetItem_TransactionCurrency
        {
            get { return this.GetRelatedEntity<TransactionCurrency>("DynamicPropertyOptionSetItem_TransactionCurrency", null); }
            set
            {
                this.OnPropertyChanging("DynamicPropertyOptionSetItem_TransactionCurrency");
                this.SetRelatedEntity<TransactionCurrency>("DynamicPropertyOptionSetItem_TransactionCurrency", null, value);
                this.OnPropertyChanged("DynamicPropertyOptionSetItem_TransactionCurrency");
            }
        }

        /// <summary>
        /// N:1 lk_DynamicPropertyOptionSetItem_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_DynamicPropertyOptionSetItem_createdby")]
        public SystemUser lk_DynamicPropertyOptionSetItem_createdby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_DynamicPropertyOptionSetItem_createdby", null); }
        }

        /// <summary>
        /// N:1 lk_DynamicPropertyOptionSetItem_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_DynamicPropertyOptionSetItem_createdonbehalfby")]
        public SystemUser lk_DynamicPropertyOptionSetItem_createdonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_DynamicPropertyOptionSetItem_createdonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_DynamicPropertyOptionSetItem_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_DynamicPropertyOptionSetItem_modifiedby")]
        public SystemUser lk_DynamicPropertyOptionSetItem_modifiedby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_DynamicPropertyOptionSetItem_modifiedby", null); }
        }

        /// <summary>
        /// N:1 lk_DynamicPropertyOptionSetItem_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_DynamicPropertyOptionSetItem_modifiedonbehalfby")]
        public SystemUser lk_DynamicPropertyOptionSetItem_modifiedonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_DynamicPropertyOptionSetItem_modifiedonbehalfby", null); }
        }
    }
}