namespace __4_DAL_CRM
{
    /// <summary>
    /// Association of a property definition with another entity in the system.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("dynamicpropertyassociation")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class DynamicPropertyAssociation : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public DynamicPropertyAssociation() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "dynamicpropertyassociation";

        public const int EntityTypeCode = 1235;

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
        /// Shows the status of the property association.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("associationstatus")]
        public Microsoft.Xrm.Sdk.OptionSetValue AssociationStatus
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("associationstatus"); }
            set
            {
                this.OnPropertyChanging("AssociationStatus");
                this.SetAttributeValue("associationstatus", value);
                this.OnPropertyChanged("AssociationStatus");
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
        /// Shows the unique identifier of the property association.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("dynamicpropertyassociationid")]
        public System.Nullable<System.Guid> DynamicPropertyAssociationId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("dynamicpropertyassociationid"); }
            set
            {
                this.OnPropertyChanging("DynamicPropertyAssociationId");
                this.SetAttributeValue("dynamicpropertyassociationid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("DynamicPropertyAssociationId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("dynamicpropertyassociationid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.DynamicPropertyAssociationId = value; }
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
        /// Shows the inheritance state in relationship to the parent property.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("inheritancestate")]
        public Microsoft.Xrm.Sdk.OptionSetValue InheritanceState
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("inheritancestate"); }
            set
            {
                this.OnPropertyChanging("InheritanceState");
                this.SetAttributeValue("inheritancestate", value);
                this.OnPropertyChanged("InheritanceState");
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
        /// Shows the object that the property is associated with.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        public Microsoft.Xrm.Sdk.EntityReference RegardingObjectid
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("regardingobjectid"); }
            set
            {
                this.OnPropertyChanging("RegardingObjectid");
                this.SetAttributeValue("regardingobjectid", value);
                this.OnPropertyChanged("RegardingObjectid");
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
        /// Shows the version number of the property association.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
        public System.Nullable<long> VersionNumber
        {
            get { return this.GetAttributeValue<System.Nullable<long>>("versionnumber"); }
        }

        /// <summary>
        /// N:1 Dynamicproperty_DynamicPropertyAssociation
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("dynamicpropertyid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Dynamicproperty_DynamicPropertyAssociation")]
        public DynamicProperty Dynamicproperty_DynamicPropertyAssociation
        {
            get { return this.GetRelatedEntity<DynamicProperty>("Dynamicproperty_DynamicPropertyAssociation", null); }
            set
            {
                this.OnPropertyChanging("Dynamicproperty_DynamicPropertyAssociation");
                this.SetRelatedEntity<DynamicProperty>("Dynamicproperty_DynamicPropertyAssociation", null, value);
                this.OnPropertyChanged("Dynamicproperty_DynamicPropertyAssociation");
            }
        }

        /// <summary>
        /// N:1 DynamicPropertyAssociation_organization
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("DynamicPropertyAssociation_organization")]
        public Organization DynamicPropertyAssociation_organization
        {
            get { return this.GetRelatedEntity<Organization>("DynamicPropertyAssociation_organization", null); }
        }

        /// <summary>
        /// N:1 DynamicPropertyAssociation_TransactionCurrency
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("DynamicPropertyAssociation_TransactionCurrency")]
        public TransactionCurrency DynamicPropertyAssociation_TransactionCurrency
        {
            get { return this.GetRelatedEntity<TransactionCurrency>("DynamicPropertyAssociation_TransactionCurrency", null); }
            set
            {
                this.OnPropertyChanging("DynamicPropertyAssociation_TransactionCurrency");
                this.SetRelatedEntity<TransactionCurrency>("DynamicPropertyAssociation_TransactionCurrency", null, value);
                this.OnPropertyChanged("DynamicPropertyAssociation_TransactionCurrency");
            }
        }

        /// <summary>
        /// N:1 lk_DynamicPropertyAssociationattribute_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_DynamicPropertyAssociationattribute_createdby")]
        public SystemUser lk_DynamicPropertyAssociationattribute_createdby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_DynamicPropertyAssociationattribute_createdby", null); }
        }

        /// <summary>
        /// N:1 lk_DynamicPropertyAssociationattribute_CreatedOnBehalfBy
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_DynamicPropertyAssociationattribute_CreatedOnBehalfBy")]
        public SystemUser lk_DynamicPropertyAssociationattribute_CreatedOnBehalfBy
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_DynamicPropertyAssociationattribute_CreatedOnBehalfBy", null); }
        }

        /// <summary>
        /// N:1 lk_DynamicPropertyAssociationattribute_ModifiedBy
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_DynamicPropertyAssociationattribute_ModifiedBy")]
        public SystemUser lk_DynamicPropertyAssociationattribute_ModifiedBy
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_DynamicPropertyAssociationattribute_ModifiedBy", null); }
        }

        /// <summary>
        /// N:1 lk_DynamicPropertyAssociationattribute_ModifiedOnBehalfBy
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_DynamicPropertyAssociationattribute_ModifiedOnBehalfBy")]
        public SystemUser lk_DynamicPropertyAssociationattribute_ModifiedOnBehalfBy
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_DynamicPropertyAssociationattribute_ModifiedOnBehalfBy", null); }
        }

        /// <summary>
        /// N:1 Product_DynamicPropertyAssociation
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Product_DynamicPropertyAssociation")]
        public Product Product_DynamicPropertyAssociation
        {
            get { return this.GetRelatedEntity<Product>("Product_DynamicPropertyAssociation", null); }
            set
            {
                this.OnPropertyChanging("Product_DynamicPropertyAssociation");
                this.SetRelatedEntity<Product>("Product_DynamicPropertyAssociation", null, value);
                this.OnPropertyChanged("Product_DynamicPropertyAssociation");
            }
        }

        /// <summary>
        /// N:1 ProductAssociation_DynamicPropertyAssociation
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ProductAssociation_DynamicPropertyAssociation")]
        public ProductAssociation ProductAssociation_DynamicPropertyAssociation
        {
            get { return this.GetRelatedEntity<ProductAssociation>("ProductAssociation_DynamicPropertyAssociation", null); }
            set
            {
                this.OnPropertyChanging("ProductAssociation_DynamicPropertyAssociation");
                this.SetRelatedEntity<ProductAssociation>("ProductAssociation_DynamicPropertyAssociation", null, value);
                this.OnPropertyChanged("ProductAssociation_DynamicPropertyAssociation");
            }
        }
    }
}