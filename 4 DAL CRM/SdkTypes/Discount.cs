namespace __4_DAL_CRM
{
    /// <summary>
    /// Price reduction made from the list price of a product or service based on the quantity purchased.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("discount")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class Discount : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public Discount() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "discount";

        public const int EntityTypeCode = 1013;

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
        /// Amount of the discount, specified either as a percentage or as a monetary amount.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("amount")]
        public Microsoft.Xrm.Sdk.Money Amount
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("amount"); }
            set
            {
                this.OnPropertyChanging("Amount");
                this.SetAttributeValue("amount", value);
                this.OnPropertyChanged("Amount");
            }
        }

        /// <summary>
        /// Shows the Amount field converted to the system's default base currency, if specified as a fixed amount. The calculation uses the exchange rate specified in the Currencies area.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("amount_base")]
        public Microsoft.Xrm.Sdk.Money Amount_Base
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("amount_base"); }
        }

        /// <summary>
        /// Unique identifier of the user who created the discount.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby"); }
        }

        /// <summary>
        /// Date and time when the discount was created.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
        public System.Nullable<System.DateTime> CreatedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who created the discount.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        /// Unique identifier of the discount.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("discountid")]
        public System.Nullable<System.Guid> DiscountId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("discountid"); }
            set
            {
                this.OnPropertyChanging("DiscountId");
                this.SetAttributeValue("discountid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("DiscountId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("discountid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.DiscountId = value; }
        }

        /// <summary>
        /// Unique identifier of the discount list associated with the discount.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("discounttypeid")]
        public Microsoft.Xrm.Sdk.EntityReference DiscountTypeId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("discounttypeid"); }
            set
            {
                this.OnPropertyChanging("DiscountTypeId");
                this.SetAttributeValue("discounttypeid", value);
                this.OnPropertyChanged("DiscountTypeId");
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
        /// Upper boundary for the quantity range to which a particular discount can be applied.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("highquantity")]
        public System.Nullable<decimal> HighQuantity
        {
            get { return this.GetAttributeValue<System.Nullable<decimal>>("highquantity"); }
            set
            {
                this.OnPropertyChanging("HighQuantity");
                this.SetAttributeValue("highquantity", value);
                this.OnPropertyChanged("HighQuantity");
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
        /// Specifies whether the discount is specified as a monetary amount or a percentage.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isamounttype")]
        public System.Nullable<bool> IsAmountType
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("isamounttype"); }
        }

        /// <summary>
        /// Lower boundary for the quantity range to which a particular discount is applied.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("lowquantity")]
        public System.Nullable<decimal> LowQuantity
        {
            get { return this.GetAttributeValue<System.Nullable<decimal>>("lowquantity"); }
            set
            {
                this.OnPropertyChanging("LowQuantity");
                this.SetAttributeValue("lowquantity", value);
                this.OnPropertyChanged("LowQuantity");
            }
        }

        /// <summary>
        /// Unique identifier of the user who last modified the discount.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby"); }
        }

        /// <summary>
        /// Date and time when the discount was last modified.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
        public System.Nullable<System.DateTime> ModifiedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who last modified the discount.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        /// Unique identifier of the organization associated with the discount.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
        public System.Nullable<System.Guid> OrganizationId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("organizationid"); }
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
        /// Percentage discount value.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("percentage")]
        public System.Nullable<decimal> Percentage
        {
            get { return this.GetAttributeValue<System.Nullable<decimal>>("percentage"); }
            set
            {
                this.OnPropertyChanging("Percentage");
                this.SetAttributeValue("percentage", value);
                this.OnPropertyChanged("Percentage");
            }
        }

        /// <summary>
        /// Select the discount's status.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statuscode")]
        [System.ObsoleteAttribute()]
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
        /// Choose the local currency for the record to make sure budgets are reported in the correct currency.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyid")]
        public Microsoft.Xrm.Sdk.EntityReference TransactionCurrencyId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("transactioncurrencyid"); }
        }

        /// <summary>
        /// Version number of the discount.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
        public System.Nullable<long> VersionNumber
        {
            get { return this.GetAttributeValue<System.Nullable<long>>("versionnumber"); }
        }

        /// <summary>
        /// 1:N Discount_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Discount_AsyncOperations")]
        public System.Collections.Generic.IEnumerable<AsyncOperation> Discount_AsyncOperations
        {
            get { return this.GetRelatedEntities<AsyncOperation>("Discount_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("Discount_AsyncOperations");
                this.SetRelatedEntities<AsyncOperation>("Discount_AsyncOperations", null, value);
                this.OnPropertyChanged("Discount_AsyncOperations");
            }
        }

        /// <summary>
        /// 1:N Discount_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Discount_BulkDeleteFailures")]
        public System.Collections.Generic.IEnumerable<BulkDeleteFailure> Discount_BulkDeleteFailures
        {
            get { return this.GetRelatedEntities<BulkDeleteFailure>("Discount_BulkDeleteFailures", null); }
            set
            {
                this.OnPropertyChanging("Discount_BulkDeleteFailures");
                this.SetRelatedEntities<BulkDeleteFailure>("Discount_BulkDeleteFailures", null, value);
                this.OnPropertyChanged("Discount_BulkDeleteFailures");
            }
        }

        /// <summary>
        /// 1:N Discount_ProcessSessions
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Discount_ProcessSessions")]
        public System.Collections.Generic.IEnumerable<ProcessSession> Discount_ProcessSessions
        {
            get { return this.GetRelatedEntities<ProcessSession>("Discount_ProcessSessions", null); }
            set
            {
                this.OnPropertyChanging("Discount_ProcessSessions");
                this.SetRelatedEntities<ProcessSession>("Discount_ProcessSessions", null, value);
                this.OnPropertyChanged("Discount_ProcessSessions");
            }
        }

        /// <summary>
        /// 1:N userentityinstancedata_discount
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_discount")]
        public System.Collections.Generic.IEnumerable<UserEntityInstanceData> userentityinstancedata_discount
        {
            get { return this.GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_discount", null); }
            set
            {
                this.OnPropertyChanging("userentityinstancedata_discount");
                this.SetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_discount", null, value);
                this.OnPropertyChanged("userentityinstancedata_discount");
            }
        }

        /// <summary>
        /// N:1 discount_type_discounts
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("discounttypeid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("discount_type_discounts")]
        public DiscountType discount_type_discounts
        {
            get { return this.GetRelatedEntity<DiscountType>("discount_type_discounts", null); }
            set
            {
                this.OnPropertyChanging("discount_type_discounts");
                this.SetRelatedEntity<DiscountType>("discount_type_discounts", null, value);
                this.OnPropertyChanged("discount_type_discounts");
            }
        }

        /// <summary>
        /// N:1 lk_discount_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_discount_createdonbehalfby")]
        public SystemUser lk_discount_createdonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_discount_createdonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_discount_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_discount_modifiedonbehalfby")]
        public SystemUser lk_discount_modifiedonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_discount_modifiedonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_discountbase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_discountbase_createdby")]
        public SystemUser lk_discountbase_createdby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_discountbase_createdby", null); }
        }

        /// <summary>
        /// N:1 lk_discountbase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_discountbase_modifiedby")]
        public SystemUser lk_discountbase_modifiedby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_discountbase_modifiedby", null); }
        }

        /// <summary>
        /// N:1 transactioncurrency_discount
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("transactioncurrency_discount")]
        public TransactionCurrency transactioncurrency_discount
        {
            get { return this.GetRelatedEntity<TransactionCurrency>("transactioncurrency_discount", null); }
        }
    }
}