namespace __4_DAL_CRM
{
    /// <summary>
    /// Information about the selling relationship between two products, including the relationship type, such as up-sell, cross-sell, substitute, or accessory.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("productsubstitute")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class ProductSubstitute : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public ProductSubstitute() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "productsubstitute";

        public const int EntityTypeCode = 1028;

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
        /// Select whether the relationship is unidirectional or bidirectional.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("direction")]
        public Microsoft.Xrm.Sdk.OptionSetValue Direction
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("direction"); }
            set
            {
                this.OnPropertyChanging("Direction");
                this.SetAttributeValue("direction", value);
                this.OnPropertyChanged("Direction");
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
        /// Shows the product that the relationship is defined for.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("productid")]
        public Microsoft.Xrm.Sdk.EntityReference ProductId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("productid"); }
            set
            {
                this.OnPropertyChanging("ProductId");
                this.SetAttributeValue("productid", value);
                this.OnPropertyChanged("ProductId");
            }
        }

        /// <summary>
        /// Shows the unique identifier of the product relationship.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("productsubstituteid")]
        public System.Nullable<System.Guid> ProductSubstituteId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("productsubstituteid"); }
            set
            {
                this.OnPropertyChanging("ProductSubstituteId");
                this.SetAttributeValue("productsubstituteid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("ProductSubstituteId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("productsubstituteid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.ProductSubstituteId = value; }
        }

        /// <summary>
        /// Select the type of the product relationship.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("salesrelationshiptype")]
        public Microsoft.Xrm.Sdk.OptionSetValue SalesRelationshipType
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("salesrelationshiptype"); }
            set
            {
                this.OnPropertyChanging("SalesRelationshipType");
                this.SetAttributeValue("salesrelationshiptype", value);
                this.OnPropertyChanged("SalesRelationshipType");
            }
        }

        /// <summary>
        /// Select the product relationship's status.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
        public System.Nullable<ProductSubstituteState> statecode
        {
            get
            {
                Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
                if ((optionSet != null))
                {
                    return ((ProductSubstituteState) (System.Enum.ToObject(typeof(ProductSubstituteState), optionSet.Value)));
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// Shows whether the product relationship is active or inactive.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statuscode")]
        public Microsoft.Xrm.Sdk.OptionSetValue statuscode
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statuscode"); }
            set
            {
                this.OnPropertyChanging("statuscode");
                this.SetAttributeValue("statuscode", value);
                this.OnPropertyChanged("statuscode");
            }
        }

        /// <summary>
        /// Select the related product that the relationship needs to be defined for.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("substitutedproductid")]
        public Microsoft.Xrm.Sdk.EntityReference SubstitutedProductId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("substitutedproductid"); }
            set
            {
                this.OnPropertyChanging("SubstitutedProductId");
                this.SetAttributeValue("substitutedproductid", value);
                this.OnPropertyChanged("SubstitutedProductId");
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
        /// Shows the time zone code that was in use when the record was created.
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
        /// Shows the version number of the product relationship.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
        public System.Nullable<long> VersionNumber
        {
            get { return this.GetAttributeValue<System.Nullable<long>>("versionnumber"); }
        }

        /// <summary>
        /// 1:N ProductSubstitute_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ProductSubstitute_AsyncOperations")]
        public System.Collections.Generic.IEnumerable<AsyncOperation> ProductSubstitute_AsyncOperations
        {
            get { return this.GetRelatedEntities<AsyncOperation>("ProductSubstitute_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("ProductSubstitute_AsyncOperations");
                this.SetRelatedEntities<AsyncOperation>("ProductSubstitute_AsyncOperations", null, value);
                this.OnPropertyChanged("ProductSubstitute_AsyncOperations");
            }
        }

        /// <summary>
        /// 1:N ProductSubstitute_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ProductSubstitute_BulkDeleteFailures")]
        public System.Collections.Generic.IEnumerable<BulkDeleteFailure> ProductSubstitute_BulkDeleteFailures
        {
            get { return this.GetRelatedEntities<BulkDeleteFailure>("ProductSubstitute_BulkDeleteFailures", null); }
            set
            {
                this.OnPropertyChanging("ProductSubstitute_BulkDeleteFailures");
                this.SetRelatedEntities<BulkDeleteFailure>("ProductSubstitute_BulkDeleteFailures", null, value);
                this.OnPropertyChanged("ProductSubstitute_BulkDeleteFailures");
            }
        }

        /// <summary>
        /// 1:N ProductSubstitute_PrincipalObjectAttributeAccess
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ProductSubstitute_PrincipalObjectAttributeAccess")]
        public System.Collections.Generic.IEnumerable<PrincipalObjectAttributeAccess> ProductSubstitute_PrincipalObjectAttributeAccess
        {
            get { return this.GetRelatedEntities<PrincipalObjectAttributeAccess>("ProductSubstitute_PrincipalObjectAttributeAccess", null); }
            set
            {
                this.OnPropertyChanging("ProductSubstitute_PrincipalObjectAttributeAccess");
                this.SetRelatedEntities<PrincipalObjectAttributeAccess>("ProductSubstitute_PrincipalObjectAttributeAccess", null, value);
                this.OnPropertyChanged("ProductSubstitute_PrincipalObjectAttributeAccess");
            }
        }

        /// <summary>
        /// 1:N ProductSubstitute_ProcessSession
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ProductSubstitute_ProcessSession")]
        public System.Collections.Generic.IEnumerable<ProcessSession> ProductSubstitute_ProcessSession
        {
            get { return this.GetRelatedEntities<ProcessSession>("ProductSubstitute_ProcessSession", null); }
            set
            {
                this.OnPropertyChanging("ProductSubstitute_ProcessSession");
                this.SetRelatedEntities<ProcessSession>("ProductSubstitute_ProcessSession", null, value);
                this.OnPropertyChanged("ProductSubstitute_ProcessSession");
            }
        }

        /// <summary>
        /// N:1 lk_ProductSubstitute_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ProductSubstitute_createdby")]
        public SystemUser lk_ProductSubstitute_createdby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_ProductSubstitute_createdby", null); }
        }

        /// <summary>
        /// N:1 lk_ProductSubstitute_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ProductSubstitute_createdonbehalfby")]
        public SystemUser lk_ProductSubstitute_createdonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_ProductSubstitute_createdonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_ProductSubstitute_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ProductSubstitute_modifiedby")]
        public SystemUser lk_ProductSubstitute_modifiedby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_ProductSubstitute_modifiedby", null); }
        }

        /// <summary>
        /// N:1 lk_ProductSubstitute_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ProductSubstitute_modifiedonbehalfby")]
        public SystemUser lk_ProductSubstitute_modifiedonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_ProductSubstitute_modifiedonbehalfby", null); }
        }

        /// <summary>
        /// N:1 organization_ProductSubstitute
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_ProductSubstitute")]
        public Organization organization_ProductSubstitute
        {
            get { return this.GetRelatedEntity<Organization>("organization_ProductSubstitute", null); }
        }

        /// <summary>
        /// N:1 product_ProductSubstitute_productid
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("productid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("product_ProductSubstitute_productid")]
        public Product product_ProductSubstitute_productid
        {
            get { return this.GetRelatedEntity<Product>("product_ProductSubstitute_productid", null); }
            set
            {
                this.OnPropertyChanging("product_ProductSubstitute_productid");
                this.SetRelatedEntity<Product>("product_ProductSubstitute_productid", null, value);
                this.OnPropertyChanged("product_ProductSubstitute_productid");
            }
        }

        /// <summary>
        /// N:1 product_ProductSubstitute_substitutedproductid
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("substitutedproductid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("product_ProductSubstitute_substitutedproductid")]
        public Product product_ProductSubstitute_substitutedproductid
        {
            get { return this.GetRelatedEntity<Product>("product_ProductSubstitute_substitutedproductid", null); }
            set
            {
                this.OnPropertyChanging("product_ProductSubstitute_substitutedproductid");
                this.SetRelatedEntity<Product>("product_ProductSubstitute_substitutedproductid", null, value);
                this.OnPropertyChanged("product_ProductSubstitute_substitutedproductid");
            }
        }

        /// <summary>
        /// N:1 transactioncurrency_ProductSubstitute
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("transactioncurrency_ProductSubstitute")]
        public TransactionCurrency transactioncurrency_ProductSubstitute
        {
            get { return this.GetRelatedEntity<TransactionCurrency>("transactioncurrency_ProductSubstitute", null); }
            set
            {
                this.OnPropertyChanging("transactioncurrency_ProductSubstitute");
                this.SetRelatedEntity<TransactionCurrency>("transactioncurrency_ProductSubstitute", null, value);
                this.OnPropertyChanged("transactioncurrency_ProductSubstitute");
            }
        }
    }
}