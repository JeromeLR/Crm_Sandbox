namespace __4_DAL_CRM
{
    /// <summary>
    /// Instance of a property with its value.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("dynamicpropertyinstance")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class DynamicPropertyInstance : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public DynamicPropertyInstance() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "dynamicpropertyinstance";

        public const int EntityTypeCode = 1333;

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
        /// Shows the property that this record is associated with.
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
        /// Shows the unique identifier of the property instance.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("dynamicpropertyinstanceid")]
        public System.Nullable<System.Guid> DynamicPropertyInstanceid
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("dynamicpropertyinstanceid"); }
            set
            {
                this.OnPropertyChanging("DynamicPropertyInstanceid");
                this.SetAttributeValue("dynamicpropertyinstanceid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("DynamicPropertyInstanceid");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("dynamicpropertyinstanceid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.DynamicPropertyInstanceid = value; }
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
        /// Shows the business unit that the record owner belongs to.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
        public Microsoft.Xrm.Sdk.EntityReference OwningBusinessUnit
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningbusinessunit"); }
        }

        /// <summary>
        /// Shows the team who owns the property instance.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
        public Microsoft.Xrm.Sdk.EntityReference OwningTeam
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningteam"); }
        }

        /// <summary>
        /// Shows the user who owns the property instance.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
        public Microsoft.Xrm.Sdk.EntityReference OwningUser
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owninguser"); }
        }

        /// <summary>
        /// Shows the object that the property is associated with.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        public Microsoft.Xrm.Sdk.EntityReference RegardingObjectId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("regardingobjectid"); }
            set
            {
                this.OnPropertyChanging("RegardingObjectId");
                this.SetAttributeValue("regardingobjectid", value);
                this.OnPropertyChanged("RegardingObjectId");
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
        /// Shows whether the property value is valid.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("validationstatus")]
        public System.Nullable<bool> validationstatus
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("validationstatus"); }
            set
            {
                this.OnPropertyChanging("validationstatus");
                this.SetAttributeValue("validationstatus", value);
                this.OnPropertyChanged("validationstatus");
            }
        }

        /// <summary>
        /// Shows the decimal value of the property.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("valuedecimal")]
        public System.Nullable<decimal> ValueDecimal
        {
            get { return this.GetAttributeValue<System.Nullable<decimal>>("valuedecimal"); }
            set
            {
                this.OnPropertyChanging("ValueDecimal");
                this.SetAttributeValue("valuedecimal", value);
                this.OnPropertyChanged("ValueDecimal");
            }
        }

        /// <summary>
        /// Shows the double value of the property.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("valuedouble")]
        public System.Nullable<double> ValueDouble
        {
            get { return this.GetAttributeValue<System.Nullable<double>>("valuedouble"); }
            set
            {
                this.OnPropertyChanging("ValueDouble");
                this.SetAttributeValue("valuedouble", value);
                this.OnPropertyChanged("ValueDouble");
            }
        }

        /// <summary>
        /// Shows the integer value of the property.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("valueinteger")]
        public System.Nullable<int> ValueInteger
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("valueinteger"); }
            set
            {
                this.OnPropertyChanging("ValueInteger");
                this.SetAttributeValue("valueinteger", value);
                this.OnPropertyChanged("ValueInteger");
            }
        }

        /// <summary>
        /// Shows the string value of the property.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("valuestring")]
        public string ValueString
        {
            get { return this.GetAttributeValue<string>("valuestring"); }
            set
            {
                this.OnPropertyChanging("ValueString");
                this.SetAttributeValue("valuestring", value);
                this.OnPropertyChanged("ValueString");
            }
        }

        /// <summary>
        /// Shows the version number of the property instance.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
        public System.Nullable<long> VersionNumber
        {
            get { return this.GetAttributeValue<System.Nullable<long>>("versionnumber"); }
        }

        /// <summary>
        /// N:1 business_unit_dynamicproperyinstance
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_dynamicproperyinstance")]
        public BusinessUnit business_unit_dynamicproperyinstance
        {
            get { return this.GetRelatedEntity<BusinessUnit>("business_unit_dynamicproperyinstance", null); }
        }

        /// <summary>
        /// N:1 DynamicProperty_DynamicPropertyInstance
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("dynamicpropertyid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("DynamicProperty_DynamicPropertyInstance")]
        public DynamicProperty DynamicProperty_DynamicPropertyInstance
        {
            get { return this.GetRelatedEntity<DynamicProperty>("DynamicProperty_DynamicPropertyInstance", null); }
            set
            {
                this.OnPropertyChanging("DynamicProperty_DynamicPropertyInstance");
                this.SetRelatedEntity<DynamicProperty>("DynamicProperty_DynamicPropertyInstance", null, value);
                this.OnPropertyChanged("DynamicProperty_DynamicPropertyInstance");
            }
        }

        /// <summary>
        /// N:1 Dynamicpropertyinsatance_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Dynamicpropertyinsatance_createdby")]
        public SystemUser Dynamicpropertyinsatance_createdby
        {
            get { return this.GetRelatedEntity<SystemUser>("Dynamicpropertyinsatance_createdby", null); }
        }

        /// <summary>
        /// N:1 InvoiceDetail_Dynamicpropertyinstance
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("InvoiceDetail_Dynamicpropertyinstance")]
        public InvoiceDetail InvoiceDetail_Dynamicpropertyinstance
        {
            get { return this.GetRelatedEntity<InvoiceDetail>("InvoiceDetail_Dynamicpropertyinstance", null); }
            set
            {
                this.OnPropertyChanging("InvoiceDetail_Dynamicpropertyinstance");
                this.SetRelatedEntity<InvoiceDetail>("InvoiceDetail_Dynamicpropertyinstance", null, value);
                this.OnPropertyChanged("InvoiceDetail_Dynamicpropertyinstance");
            }
        }

        /// <summary>
        /// N:1 lk_Dynamicpropertyinsatanceattribute_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_Dynamicpropertyinsatanceattribute_createdonbehalfby")]
        public SystemUser lk_Dynamicpropertyinsatanceattribute_createdonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_Dynamicpropertyinsatanceattribute_createdonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_Dynamicpropertyinsatanceattribute_ModifiedBy
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_Dynamicpropertyinsatanceattribute_ModifiedBy")]
        public SystemUser lk_Dynamicpropertyinsatanceattribute_ModifiedBy
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_Dynamicpropertyinsatanceattribute_ModifiedBy", null); }
        }

        /// <summary>
        /// N:1 lk_Dynamicpropertyinsatanceattribute_ModifiedOnBehalfBy
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_Dynamicpropertyinsatanceattribute_ModifiedOnBehalfBy")]
        public SystemUser lk_Dynamicpropertyinsatanceattribute_ModifiedOnBehalfBy
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_Dynamicpropertyinsatanceattribute_ModifiedOnBehalfBy", null); }
        }

        /// <summary>
        /// N:1 OpportunityProduct_Dynamicpropertyinstance
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("OpportunityProduct_Dynamicpropertyinstance")]
        public OpportunityProduct OpportunityProduct_Dynamicpropertyinstance
        {
            get { return this.GetRelatedEntity<OpportunityProduct>("OpportunityProduct_Dynamicpropertyinstance", null); }
            set
            {
                this.OnPropertyChanging("OpportunityProduct_Dynamicpropertyinstance");
                this.SetRelatedEntity<OpportunityProduct>("OpportunityProduct_Dynamicpropertyinstance", null, value);
                this.OnPropertyChanged("OpportunityProduct_Dynamicpropertyinstance");
            }
        }

        /// <summary>
        /// N:1 OwningUser_Dynamicpropertyinsatance
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("dynamicpropertyinstanceid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("OwningUser_Dynamicpropertyinsatance")]
        public SystemUser OwningUser_Dynamicpropertyinsatance
        {
            get { return this.GetRelatedEntity<SystemUser>("OwningUser_Dynamicpropertyinsatance", null); }
            set
            {
                this.OnPropertyChanging("OwningUser_Dynamicpropertyinsatance");
                this.SetRelatedEntity<SystemUser>("OwningUser_Dynamicpropertyinsatance", null, value);
                this.OnPropertyChanged("OwningUser_Dynamicpropertyinsatance");
            }
        }

        /// <summary>
        /// N:1 QuoteDetail_Dynamicpropertyinstance
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("QuoteDetail_Dynamicpropertyinstance")]
        public QuoteDetail QuoteDetail_Dynamicpropertyinstance
        {
            get { return this.GetRelatedEntity<QuoteDetail>("QuoteDetail_Dynamicpropertyinstance", null); }
            set
            {
                this.OnPropertyChanging("QuoteDetail_Dynamicpropertyinstance");
                this.SetRelatedEntity<QuoteDetail>("QuoteDetail_Dynamicpropertyinstance", null, value);
                this.OnPropertyChanged("QuoteDetail_Dynamicpropertyinstance");
            }
        }

        /// <summary>
        /// N:1 SalesOrderDetail_Dynamicpropertyinstance
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SalesOrderDetail_Dynamicpropertyinstance")]
        public SalesOrderDetail SalesOrderDetail_Dynamicpropertyinstance
        {
            get { return this.GetRelatedEntity<SalesOrderDetail>("SalesOrderDetail_Dynamicpropertyinstance", null); }
            set
            {
                this.OnPropertyChanging("SalesOrderDetail_Dynamicpropertyinstance");
                this.SetRelatedEntity<SalesOrderDetail>("SalesOrderDetail_Dynamicpropertyinstance", null, value);
                this.OnPropertyChanged("SalesOrderDetail_Dynamicpropertyinstance");
            }
        }

        /// <summary>
        /// N:1 team_DynamicPropertyInstance
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_DynamicPropertyInstance")]
        public Team team_DynamicPropertyInstance
        {
            get { return this.GetRelatedEntity<Team>("team_DynamicPropertyInstance", null); }
        }

        /// <summary>
        /// N:1 TransactionCurrency_Dynamicpropertyinsatance
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("dynamicpropertyinstanceid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("TransactionCurrency_Dynamicpropertyinsatance")]
        public TransactionCurrency TransactionCurrency_Dynamicpropertyinsatance
        {
            get { return this.GetRelatedEntity<TransactionCurrency>("TransactionCurrency_Dynamicpropertyinsatance", null); }
            set
            {
                this.OnPropertyChanging("TransactionCurrency_Dynamicpropertyinsatance");
                this.SetRelatedEntity<TransactionCurrency>("TransactionCurrency_Dynamicpropertyinsatance", null, value);
                this.OnPropertyChanged("TransactionCurrency_Dynamicpropertyinsatance");
            }
        }
    }
}