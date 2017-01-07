namespace __4_DAL_CRM
{
    /// <summary>
    /// Type of discount specified as either a percentage or an amount.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("discounttype")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class DiscountType : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public DiscountType() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "discounttype";

        public const int EntityTypeCode = 1080;

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
        /// Unique identifier of the user who created the discount list.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby"); }
        }

        /// <summary>
        /// Date and time when the discount list was created.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
        public System.Nullable<System.DateTime> CreatedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who created the discounttype.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        /// Description of the discount list.
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
        /// Unique identifier of the discount list.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("discounttypeid")]
        public System.Nullable<System.Guid> DiscountTypeId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("discounttypeid"); }
            set
            {
                this.OnPropertyChanging("DiscountTypeId");
                this.SetAttributeValue("discounttypeid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("DiscountTypeId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("discounttypeid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.DiscountTypeId = value; }
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
        /// Information about whether the discount list amounts are specified as monetary amounts or percentages.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isamounttype")]
        public System.Nullable<bool> IsAmountType
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("isamounttype"); }
            set
            {
                this.OnPropertyChanging("IsAmountType");
                this.SetAttributeValue("isamounttype", value);
                this.OnPropertyChanged("IsAmountType");
            }
        }

        /// <summary>
        /// Unique identifier of the user who last modified the discount list.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby"); }
        }

        /// <summary>
        /// Date and time when the discount list was last modified.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
        public System.Nullable<System.DateTime> ModifiedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who last modified the discounttype.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        /// Name of the discount list.
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
        /// Unique identifier of the organization associated with the discount list.
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
        /// Status of the discount list.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
        public System.Nullable<DiscountTypeState> StateCode
        {
            get
            {
                Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
                if ((optionSet != null))
                {
                    return ((DiscountTypeState) (System.Enum.ToObject(typeof(DiscountTypeState), optionSet.Value)));
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// Reason for the status of the discount list.
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
        /// Unique identifier of the currency associated with the discount type.
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
        /// Version number of the discount type.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
        public System.Nullable<long> VersionNumber
        {
            get { return this.GetAttributeValue<System.Nullable<long>>("versionnumber"); }
        }

        /// <summary>
        /// 1:N discount_type_discounts
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("discount_type_discounts")]
        public System.Collections.Generic.IEnumerable<Discount> discount_type_discounts
        {
            get { return this.GetRelatedEntities<Discount>("discount_type_discounts", null); }
            set
            {
                this.OnPropertyChanging("discount_type_discounts");
                this.SetRelatedEntities<Discount>("discount_type_discounts", null, value);
                this.OnPropertyChanged("discount_type_discounts");
            }
        }

        /// <summary>
        /// 1:N discount_type_product_price_levels
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("discount_type_product_price_levels")]
        public System.Collections.Generic.IEnumerable<ProductPriceLevel> discount_type_product_price_levels
        {
            get { return this.GetRelatedEntities<ProductPriceLevel>("discount_type_product_price_levels", null); }
            set
            {
                this.OnPropertyChanging("discount_type_product_price_levels");
                this.SetRelatedEntities<ProductPriceLevel>("discount_type_product_price_levels", null, value);
                this.OnPropertyChanged("discount_type_product_price_levels");
            }
        }

        /// <summary>
        /// 1:N DiscountType_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("DiscountType_AsyncOperations")]
        public System.Collections.Generic.IEnumerable<AsyncOperation> DiscountType_AsyncOperations
        {
            get { return this.GetRelatedEntities<AsyncOperation>("DiscountType_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("DiscountType_AsyncOperations");
                this.SetRelatedEntities<AsyncOperation>("DiscountType_AsyncOperations", null, value);
                this.OnPropertyChanged("DiscountType_AsyncOperations");
            }
        }

        /// <summary>
        /// 1:N DiscountType_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("DiscountType_BulkDeleteFailures")]
        public System.Collections.Generic.IEnumerable<BulkDeleteFailure> DiscountType_BulkDeleteFailures
        {
            get { return this.GetRelatedEntities<BulkDeleteFailure>("DiscountType_BulkDeleteFailures", null); }
            set
            {
                this.OnPropertyChanging("DiscountType_BulkDeleteFailures");
                this.SetRelatedEntities<BulkDeleteFailure>("DiscountType_BulkDeleteFailures", null, value);
                this.OnPropertyChanged("DiscountType_BulkDeleteFailures");
            }
        }

        /// <summary>
        /// 1:N DiscountType_ProcessSessions
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("DiscountType_ProcessSessions")]
        public System.Collections.Generic.IEnumerable<ProcessSession> DiscountType_ProcessSessions
        {
            get { return this.GetRelatedEntities<ProcessSession>("DiscountType_ProcessSessions", null); }
            set
            {
                this.OnPropertyChanging("DiscountType_ProcessSessions");
                this.SetRelatedEntities<ProcessSession>("DiscountType_ProcessSessions", null, value);
                this.OnPropertyChanged("DiscountType_ProcessSessions");
            }
        }

        /// <summary>
        /// 1:N userentityinstancedata_discounttype
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_discounttype")]
        public System.Collections.Generic.IEnumerable<UserEntityInstanceData> userentityinstancedata_discounttype
        {
            get { return this.GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_discounttype", null); }
            set
            {
                this.OnPropertyChanging("userentityinstancedata_discounttype");
                this.SetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_discounttype", null, value);
                this.OnPropertyChanged("userentityinstancedata_discounttype");
            }
        }

        /// <summary>
        /// N:1 lk_discounttype_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_discounttype_createdonbehalfby")]
        public SystemUser lk_discounttype_createdonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_discounttype_createdonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_discounttype_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_discounttype_modifiedonbehalfby")]
        public SystemUser lk_discounttype_modifiedonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_discounttype_modifiedonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_discounttypebase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_discounttypebase_createdby")]
        public SystemUser lk_discounttypebase_createdby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_discounttypebase_createdby", null); }
        }

        /// <summary>
        /// N:1 lk_discounttypebase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_discounttypebase_modifiedby")]
        public SystemUser lk_discounttypebase_modifiedby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_discounttypebase_modifiedby", null); }
        }

        /// <summary>
        /// N:1 organization_discount_types
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_discount_types")]
        public Organization organization_discount_types
        {
            get { return this.GetRelatedEntity<Organization>("organization_discount_types", null); }
        }

        /// <summary>
        /// N:1 transactioncurrency_discounttype
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("transactioncurrency_discounttype")]
        public TransactionCurrency transactioncurrency_discounttype
        {
            get { return this.GetRelatedEntity<TransactionCurrency>("transactioncurrency_discounttype", null); }
            set
            {
                this.OnPropertyChanging("transactioncurrency_discounttype");
                this.SetRelatedEntity<TransactionCurrency>("transactioncurrency_discounttype", null, value);
                this.OnPropertyChanged("transactioncurrency_discounttype");
            }
        }
    }
}