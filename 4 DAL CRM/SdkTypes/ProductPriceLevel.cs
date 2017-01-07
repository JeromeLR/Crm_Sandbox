namespace __4_DAL_CRM
{
    /// <summary>
    /// Information about how to price a product in the specified price level, including pricing method, rounding option, and discount type based on a specified product unit.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("productpricelevel")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class ProductPriceLevel : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public ProductPriceLevel() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "productpricelevel";

        public const int EntityTypeCode = 1026;

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
        /// Monetary amount for the price list.
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
        /// Unique identifier of the user who created the price list.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby"); }
        }

        /// <summary>
        /// Date and time when the price list was created.
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
        /// Unique identifier of the discount list associated with the price list.
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
        /// Unique identifier of the user who last modified the price list.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby"); }
        }

        /// <summary>
        /// Date and time when the price list was last modified.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
        public System.Nullable<System.DateTime> ModifiedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon"); }
        }

        /// <summary>
        /// Shows who last updated the record on behalf of another user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        /// Unique identifier of the organization associated with the price list.
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
        /// Percentage for the price list.
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
        /// Unique identifier of the price level associated with this price list.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("pricelevelid")]
        public Microsoft.Xrm.Sdk.EntityReference PriceLevelId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("pricelevelid"); }
            set
            {
                this.OnPropertyChanging("PriceLevelId");
                this.SetAttributeValue("pricelevelid", value);
                this.OnPropertyChanged("PriceLevelId");
            }
        }

        /// <summary>
        /// Pricing method applied to the price list.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("pricingmethodcode")]
        public Microsoft.Xrm.Sdk.OptionSetValue PricingMethodCode
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("pricingmethodcode"); }
            set
            {
                this.OnPropertyChanging("PricingMethodCode");
                this.SetAttributeValue("pricingmethodcode", value);
                this.OnPropertyChanged("PricingMethodCode");
            }
        }

        /// <summary>
        /// Unique identifier of the Process.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("processid")]
        public System.Nullable<System.Guid> ProcessId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("processid"); }
            set
            {
                this.OnPropertyChanging("ProcessId");
                this.SetAttributeValue("processid", value);
                this.OnPropertyChanged("ProcessId");
            }
        }

        /// <summary>
        /// Product associated with the price list.
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
        /// User-defined product number.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("productnumber")]
        public string ProductNumber
        {
            get { return this.GetAttributeValue<string>("productnumber"); }
        }

        /// <summary>
        /// Unique identifier of the price list.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("productpricelevelid")]
        public System.Nullable<System.Guid> ProductPriceLevelId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("productpricelevelid"); }
            set
            {
                this.OnPropertyChanging("ProductPriceLevelId");
                this.SetAttributeValue("productpricelevelid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("ProductPriceLevelId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("productpricelevelid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.ProductPriceLevelId = value; }
        }

        /// <summary>
        /// Quantity of the product that must be sold for a given price level.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("quantitysellingcode")]
        public Microsoft.Xrm.Sdk.OptionSetValue QuantitySellingCode
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("quantitysellingcode"); }
            set
            {
                this.OnPropertyChanging("QuantitySellingCode");
                this.SetAttributeValue("quantitysellingcode", value);
                this.OnPropertyChanged("QuantitySellingCode");
            }
        }

        /// <summary>
        /// Rounding option amount for the price list.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("roundingoptionamount")]
        public Microsoft.Xrm.Sdk.Money RoundingOptionAmount
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("roundingoptionamount"); }
            set
            {
                this.OnPropertyChanging("RoundingOptionAmount");
                this.SetAttributeValue("roundingoptionamount", value);
                this.OnPropertyChanged("RoundingOptionAmount");
            }
        }

        /// <summary>
        /// Shows the Rounding Amount field converted to the system's default base currency for reporting purposes. The calculations use the exchange rate specified in the Currencies area.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("roundingoptionamount_base")]
        public Microsoft.Xrm.Sdk.Money RoundingOptionAmount_Base
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("roundingoptionamount_base"); }
        }

        /// <summary>
        /// Option for rounding the price list.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("roundingoptioncode")]
        public Microsoft.Xrm.Sdk.OptionSetValue RoundingOptionCode
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("roundingoptioncode"); }
            set
            {
                this.OnPropertyChanging("RoundingOptionCode");
                this.SetAttributeValue("roundingoptioncode", value);
                this.OnPropertyChanged("RoundingOptionCode");
            }
        }

        /// <summary>
        /// Policy for rounding the price list.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("roundingpolicycode")]
        public Microsoft.Xrm.Sdk.OptionSetValue RoundingPolicyCode
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("roundingpolicycode"); }
            set
            {
                this.OnPropertyChanging("RoundingPolicyCode");
                this.SetAttributeValue("roundingpolicycode", value);
                this.OnPropertyChanged("RoundingPolicyCode");
            }
        }

        /// <summary>
        /// Shows the ID of the stage.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("stageid")]
        public System.Nullable<System.Guid> StageId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("stageid"); }
            set
            {
                this.OnPropertyChanging("StageId");
                this.SetAttributeValue("stageid", value);
                this.OnPropertyChanged("StageId");
            }
        }

        /// <summary>
        /// Choose the local currency for the record to make sure budgets are reported in the correct currency.
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
        /// A comma separated list of string values representing the unique identifiers of stages in a Business Process Flow Instance in the order that they occur.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("traversedpath")]
        public string TraversedPath
        {
            get { return this.GetAttributeValue<string>("traversedpath"); }
            set
            {
                this.OnPropertyChanging("TraversedPath");
                this.SetAttributeValue("traversedpath", value);
                this.OnPropertyChanged("TraversedPath");
            }
        }

        /// <summary>
        /// Unique identifier of the unit for the price list.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("uomid")]
        public Microsoft.Xrm.Sdk.EntityReference UoMId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("uomid"); }
            set
            {
                this.OnPropertyChanging("UoMId");
                this.SetAttributeValue("uomid", value);
                this.OnPropertyChanged("UoMId");
            }
        }

        /// <summary>
        /// Unique identifier of the unit schedule for the price list.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("uomscheduleid")]
        public Microsoft.Xrm.Sdk.EntityReference UoMScheduleId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("uomscheduleid"); }
            set
            {
                this.OnPropertyChanging("UoMScheduleId");
                this.SetAttributeValue("uomscheduleid", value);
                this.OnPropertyChanged("UoMScheduleId");
            }
        }

        /// <summary>
        /// Version number of the price list.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
        public System.Nullable<long> VersionNumber
        {
            get { return this.GetAttributeValue<System.Nullable<long>>("versionnumber"); }
        }

        /// <summary>
        /// 1:N ProductPriceLevel_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ProductPriceLevel_AsyncOperations")]
        public System.Collections.Generic.IEnumerable<AsyncOperation> ProductPriceLevel_AsyncOperations
        {
            get { return this.GetRelatedEntities<AsyncOperation>("ProductPriceLevel_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("ProductPriceLevel_AsyncOperations");
                this.SetRelatedEntities<AsyncOperation>("ProductPriceLevel_AsyncOperations", null, value);
                this.OnPropertyChanged("ProductPriceLevel_AsyncOperations");
            }
        }

        /// <summary>
        /// 1:N ProductPriceLevel_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ProductPriceLevel_BulkDeleteFailures")]
        public System.Collections.Generic.IEnumerable<BulkDeleteFailure> ProductPriceLevel_BulkDeleteFailures
        {
            get { return this.GetRelatedEntities<BulkDeleteFailure>("ProductPriceLevel_BulkDeleteFailures", null); }
            set
            {
                this.OnPropertyChanging("ProductPriceLevel_BulkDeleteFailures");
                this.SetRelatedEntities<BulkDeleteFailure>("ProductPriceLevel_BulkDeleteFailures", null, value);
                this.OnPropertyChanged("ProductPriceLevel_BulkDeleteFailures");
            }
        }

        /// <summary>
        /// 1:N ProductPriceLevel_ProcessSessions
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ProductPriceLevel_ProcessSessions")]
        public System.Collections.Generic.IEnumerable<ProcessSession> ProductPriceLevel_ProcessSessions
        {
            get { return this.GetRelatedEntities<ProcessSession>("ProductPriceLevel_ProcessSessions", null); }
            set
            {
                this.OnPropertyChanging("ProductPriceLevel_ProcessSessions");
                this.SetRelatedEntities<ProcessSession>("ProductPriceLevel_ProcessSessions", null, value);
                this.OnPropertyChanged("ProductPriceLevel_ProcessSessions");
            }
        }

        /// <summary>
        /// 1:N userentityinstancedata_productpricelevel
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_productpricelevel")]
        public System.Collections.Generic.IEnumerable<UserEntityInstanceData> userentityinstancedata_productpricelevel
        {
            get { return this.GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_productpricelevel", null); }
            set
            {
                this.OnPropertyChanging("userentityinstancedata_productpricelevel");
                this.SetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_productpricelevel", null, value);
                this.OnPropertyChanged("userentityinstancedata_productpricelevel");
            }
        }

        /// <summary>
        /// N:1 discount_type_product_price_levels
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("discounttypeid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("discount_type_product_price_levels")]
        public DiscountType discount_type_product_price_levels
        {
            get { return this.GetRelatedEntity<DiscountType>("discount_type_product_price_levels", null); }
            set
            {
                this.OnPropertyChanging("discount_type_product_price_levels");
                this.SetRelatedEntity<DiscountType>("discount_type_product_price_levels", null, value);
                this.OnPropertyChanged("discount_type_product_price_levels");
            }
        }

        /// <summary>
        /// N:1 lk_productpricelevel_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_productpricelevel_createdonbehalfby")]
        public SystemUser lk_productpricelevel_createdonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_productpricelevel_createdonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_productpricelevel_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_productpricelevel_modifiedonbehalfby")]
        public SystemUser lk_productpricelevel_modifiedonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_productpricelevel_modifiedonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_productpricelevelbase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_productpricelevelbase_createdby")]
        public SystemUser lk_productpricelevelbase_createdby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_productpricelevelbase_createdby", null); }
        }

        /// <summary>
        /// N:1 lk_productpricelevelbase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_productpricelevelbase_modifiedby")]
        public SystemUser lk_productpricelevelbase_modifiedby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_productpricelevelbase_modifiedby", null); }
        }

        /// <summary>
        /// N:1 price_level_product_price_levels
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("pricelevelid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("price_level_product_price_levels")]
        public PriceLevel price_level_product_price_levels
        {
            get { return this.GetRelatedEntity<PriceLevel>("price_level_product_price_levels", null); }
            set
            {
                this.OnPropertyChanging("price_level_product_price_levels");
                this.SetRelatedEntity<PriceLevel>("price_level_product_price_levels", null, value);
                this.OnPropertyChanged("price_level_product_price_levels");
            }
        }

        /// <summary>
        /// N:1 processstage_productpricelevels
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("stageid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("processstage_productpricelevels")]
        public ProcessStage processstage_productpricelevels
        {
            get { return this.GetRelatedEntity<ProcessStage>("processstage_productpricelevels", null); }
            set
            {
                this.OnPropertyChanging("processstage_productpricelevels");
                this.SetRelatedEntity<ProcessStage>("processstage_productpricelevels", null, value);
                this.OnPropertyChanged("processstage_productpricelevels");
            }
        }

        /// <summary>
        /// N:1 product_price_levels
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("productid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("product_price_levels")]
        public Product product_price_levels
        {
            get { return this.GetRelatedEntity<Product>("product_price_levels", null); }
            set
            {
                this.OnPropertyChanging("product_price_levels");
                this.SetRelatedEntity<Product>("product_price_levels", null, value);
                this.OnPropertyChanged("product_price_levels");
            }
        }

        /// <summary>
        /// N:1 transactioncurrency_productpricelevel
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("transactioncurrency_productpricelevel")]
        public TransactionCurrency transactioncurrency_productpricelevel
        {
            get { return this.GetRelatedEntity<TransactionCurrency>("transactioncurrency_productpricelevel", null); }
            set
            {
                this.OnPropertyChanging("transactioncurrency_productpricelevel");
                this.SetRelatedEntity<TransactionCurrency>("transactioncurrency_productpricelevel", null, value);
                this.OnPropertyChanged("transactioncurrency_productpricelevel");
            }
        }

        /// <summary>
        /// N:1 unit_of_measure_schedule_product_price_level
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("uomscheduleid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("unit_of_measure_schedule_product_price_level")]
        public UoMSchedule unit_of_measure_schedule_product_price_level
        {
            get { return this.GetRelatedEntity<UoMSchedule>("unit_of_measure_schedule_product_price_level", null); }
            set
            {
                this.OnPropertyChanging("unit_of_measure_schedule_product_price_level");
                this.SetRelatedEntity<UoMSchedule>("unit_of_measure_schedule_product_price_level", null, value);
                this.OnPropertyChanged("unit_of_measure_schedule_product_price_level");
            }
        }

        /// <summary>
        /// N:1 unit_of_measurement_product_price_levels
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("uomid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("unit_of_measurement_product_price_levels")]
        public UoM unit_of_measurement_product_price_levels
        {
            get { return this.GetRelatedEntity<UoM>("unit_of_measurement_product_price_levels", null); }
            set
            {
                this.OnPropertyChanging("unit_of_measurement_product_price_levels");
                this.SetRelatedEntity<UoM>("unit_of_measurement_product_price_levels", null, value);
                this.OnPropertyChanged("unit_of_measurement_product_price_levels");
            }
        }
    }
}