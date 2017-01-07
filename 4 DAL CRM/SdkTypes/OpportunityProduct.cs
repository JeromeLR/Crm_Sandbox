namespace __4_DAL_CRM
{
    /// <summary>
    /// Association between an opportunity and a product.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("opportunityproduct")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class OpportunityProduct : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public OpportunityProduct() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "opportunityproduct";

        public const int EntityTypeCode = 1083;

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
        /// Shows the total price of the opportunity product, based on the price per unit, volume discount, and quantity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("baseamount")]
        public Microsoft.Xrm.Sdk.Money BaseAmount
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("baseamount"); }
            set
            {
                this.OnPropertyChanging("BaseAmount");
                this.SetAttributeValue("baseamount", value);
                this.OnPropertyChanged("BaseAmount");
            }
        }

        /// <summary>
        /// Shows the Amount field converted to the system's default base currency. The calculation uses the exchange rate specified in the Currencies area.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("baseamount_base")]
        public Microsoft.Xrm.Sdk.Money BaseAmount_Base
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("baseamount_base"); }
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
        /// Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics CRM options.
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
        /// Type additional information to describe the opportunity product, such as manufacturing details.
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
        /// Shows the conversion rate of the record's currency. The exchange rate is used to convert all money fields in the record from the local currency to the system's default currency.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("exchangerate")]
        public System.Nullable<decimal> ExchangeRate
        {
            get { return this.GetAttributeValue<System.Nullable<decimal>>("exchangerate"); }
        }

        /// <summary>
        /// Shows the total amount due for the opportunity product, calculated on the Amount value minus the Manual Discount amount.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("extendedamount")]
        public Microsoft.Xrm.Sdk.Money ExtendedAmount
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("extendedamount"); }
            set
            {
                this.OnPropertyChanging("ExtendedAmount");
                this.SetAttributeValue("extendedamount", value);
                this.OnPropertyChanged("ExtendedAmount");
            }
        }

        /// <summary>
        /// Shows the Extended Amount field converted to the system's default base currency. The calculation uses the exchange rate specified in the Currencies area.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("extendedamount_base")]
        public Microsoft.Xrm.Sdk.Money ExtendedAmount_Base
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("extendedamount_base"); }
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
        /// Select whether the pricing on the opportunity product reflects an override of the product catalog pricing.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ispriceoverridden")]
        public System.Nullable<bool> IsPriceOverridden
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("ispriceoverridden"); }
            set
            {
                this.OnPropertyChanging("IsPriceOverridden");
                this.SetAttributeValue("ispriceoverridden", value);
                this.OnPropertyChanged("IsPriceOverridden");
            }
        }

        /// <summary>
        /// For system use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isproductoverridden")]
        public System.Nullable<bool> IsProductOverridden
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("isproductoverridden"); }
            set
            {
                this.OnPropertyChanging("IsProductOverridden");
                this.SetAttributeValue("isproductoverridden", value);
                this.OnPropertyChanged("IsProductOverridden");
            }
        }

        /// <summary>
        /// Type the line item number for the opportunity product to easily identify the product in the opportunity documents and make sure it's listed in the correct order.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("lineitemnumber")]
        public System.Nullable<int> LineItemNumber
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("lineitemnumber"); }
            set
            {
                this.OnPropertyChanging("LineItemNumber");
                this.SetAttributeValue("lineitemnumber", value);
                this.OnPropertyChanged("LineItemNumber");
            }
        }

        /// <summary>
        /// Type the manual discount amount for the opportunity product to deduct any negotiated or other savings from the product total.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("manualdiscountamount")]
        public Microsoft.Xrm.Sdk.Money ManualDiscountAmount
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("manualdiscountamount"); }
            set
            {
                this.OnPropertyChanging("ManualDiscountAmount");
                this.SetAttributeValue("manualdiscountamount", value);
                this.OnPropertyChanged("ManualDiscountAmount");
            }
        }

        /// <summary>
        /// Shows the Manual Discount field converted to the system's default base currency for reporting purposes. The calculation uses the exchange rate specified in the Currencies area.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("manualdiscountamount_base")]
        public Microsoft.Xrm.Sdk.Money ManualDiscountAmount_Base
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("manualdiscountamount_base"); }
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
        /// Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics CRM options.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
        public System.Nullable<System.DateTime> ModifiedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who last modified the opportunityproduct.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        /// Unique identifier of the opportunity with which the opportunity product is associated.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("opportunityid")]
        public Microsoft.Xrm.Sdk.EntityReference OpportunityId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("opportunityid"); }
            set
            {
                this.OnPropertyChanging("OpportunityId");
                this.SetAttributeValue("opportunityid", value);
                this.OnPropertyChanged("OpportunityId");
            }
        }

        /// <summary>
        /// Unique identifier of the opportunity product.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("opportunityproductid")]
        public System.Nullable<System.Guid> OpportunityProductId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("opportunityproductid"); }
            set
            {
                this.OnPropertyChanging("OpportunityProductId");
                this.SetAttributeValue("opportunityproductid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("OpportunityProductId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("opportunityproductid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.OpportunityProductId = value; }
        }

        /// <summary>
        /// Select the status of the opportunity product.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("opportunitystatecode")]
        public Microsoft.Xrm.Sdk.OptionSetValue OpportunityStateCode
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("opportunitystatecode"); }
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
        /// Unique identifier of the user or team who owns the opportunity product.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ownerid")]
        public Microsoft.Xrm.Sdk.EntityReference OwnerId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("ownerid"); }
        }

        /// <summary>
        /// Unique identifier of the business unit that owns the opportunity product.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
        public System.Nullable<System.Guid> OwningBusinessUnit
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("owningbusinessunit"); }
        }

        /// <summary>
        /// Unique identifier of the user who owns the opportunity product.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
        public System.Nullable<System.Guid> OwningUser
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("owninguser"); }
        }

        /// <summary>
        /// Choose the parent bundle associated with this product
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("parentbundleid")]
        public System.Nullable<System.Guid> ParentBundleId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("parentbundleid"); }
            set
            {
                this.OnPropertyChanging("ParentBundleId");
                this.SetAttributeValue("parentbundleid", value);
                this.OnPropertyChanged("ParentBundleId");
            }
        }

        /// <summary>
        /// Shows the price per unit of the opportunity product, based on the price list specified on the parent opportunity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("priceperunit")]
        public Microsoft.Xrm.Sdk.Money PricePerUnit
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("priceperunit"); }
            set
            {
                this.OnPropertyChanging("PricePerUnit");
                this.SetAttributeValue("priceperunit", value);
                this.OnPropertyChanged("PricePerUnit");
            }
        }

        /// <summary>
        /// Shows the Price Per Unit field converted to the system's default base currency for reporting purposes. The calculation uses the exchange rate specified in the Currencies area.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("priceperunit_base")]
        public Microsoft.Xrm.Sdk.Money PricePerUnit_Base
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("priceperunit_base"); }
        }

        /// <summary>
        /// Select the pricing error for the opportunity product.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("pricingerrorcode")]
        public Microsoft.Xrm.Sdk.OptionSetValue PricingErrorCode
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("pricingerrorcode"); }
            set
            {
                this.OnPropertyChanging("PricingErrorCode");
                this.SetAttributeValue("pricingerrorcode", value);
                this.OnPropertyChanged("PricingErrorCode");
            }
        }

        /// <summary>
        /// Unique identifier of the product line item association with bundle in the opportunity
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("productassociationid")]
        public System.Nullable<System.Guid> ProductAssociationId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("productassociationid"); }
            set
            {
                this.OnPropertyChanging("ProductAssociationId");
                this.SetAttributeValue("productassociationid", value);
                this.OnPropertyChanged("ProductAssociationId");
            }
        }

        /// <summary>
        /// Type a detailed product description or additional notes about the opportunity product, such as talking points or product updates, that will assist the sales team when they discuss the product with the customer.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("productdescription")]
        public string ProductDescription
        {
            get { return this.GetAttributeValue<string>("productdescription"); }
            set
            {
                this.OnPropertyChanging("ProductDescription");
                this.SetAttributeValue("productdescription", value);
                this.OnPropertyChanged("ProductDescription");
            }
        }

        /// <summary>
        /// Choose the product to include on the opportunity to link the product's pricing and other information to the opportunity.
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
        /// Product Type
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("producttypecode")]
        public Microsoft.Xrm.Sdk.OptionSetValue ProductTypeCode
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("producttypecode"); }
            set
            {
                this.OnPropertyChanging("ProductTypeCode");
                this.SetAttributeValue("producttypecode", value);
                this.OnPropertyChanged("ProductTypeCode");
            }
        }

        /// <summary>
        /// Status of the property configuration.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("propertyconfigurationstatus")]
        public Microsoft.Xrm.Sdk.OptionSetValue PropertyConfigurationStatus
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("propertyconfigurationstatus"); }
            set
            {
                this.OnPropertyChanging("PropertyConfigurationStatus");
                this.SetAttributeValue("propertyconfigurationstatus", value);
                this.OnPropertyChanged("PropertyConfigurationStatus");
            }
        }

        /// <summary>
        /// Type the amount or quantity of the product the customer would like to purchase.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("quantity")]
        public System.Nullable<decimal> Quantity
        {
            get { return this.GetAttributeValue<System.Nullable<decimal>>("quantity"); }
            set
            {
                this.OnPropertyChanging("Quantity");
                this.SetAttributeValue("quantity", value);
                this.OnPropertyChanged("Quantity");
            }
        }

        /// <summary>
        /// Shows the ID of the data that maintains the sequence.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sequencenumber")]
        public System.Nullable<int> SequenceNumber
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("sequencenumber"); }
            set
            {
                this.OnPropertyChanging("SequenceNumber");
                this.SetAttributeValue("sequencenumber", value);
                this.OnPropertyChanged("SequenceNumber");
            }
        }

        /// <summary>
        /// Type the tax amount to be applied on the opportunity product.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("tax")]
        public Microsoft.Xrm.Sdk.Money Tax
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("tax"); }
            set
            {
                this.OnPropertyChanging("Tax");
                this.SetAttributeValue("tax", value);
                this.OnPropertyChanged("Tax");
            }
        }

        /// <summary>
        /// Shows the Tax field converted to the system's default base currency for reporting purposes. The calculation uses the exchange rate specified in the Currencies area.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("tax_base")]
        public Microsoft.Xrm.Sdk.Money Tax_Base
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("tax_base"); }
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
        /// Choose the local currency for the record to make sure budgets are reported in the correct currency.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyid")]
        public Microsoft.Xrm.Sdk.EntityReference TransactionCurrencyId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("transactioncurrencyid"); }
        }

        /// <summary>
        /// Choose the unit of measurement for the base unit quantity for this purchase, such as each or dozen.
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
        /// Version number of the opportunity product.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
        public System.Nullable<long> VersionNumber
        {
            get { return this.GetAttributeValue<System.Nullable<long>>("versionnumber"); }
        }

        /// <summary>
        /// Shows the discount amount per unit if a specified volume is purchased. Configure volume discounts in the Product Catalog in the Settings area.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("volumediscountamount")]
        public Microsoft.Xrm.Sdk.Money VolumeDiscountAmount
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("volumediscountamount"); }
        }

        /// <summary>
        /// Shows the Volume Discount field converted to the system's default base currency for reporting purposes. The calculation uses the exchange rate specified in the Currencies area.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("volumediscountamount_base")]
        public Microsoft.Xrm.Sdk.Money VolumeDiscountAmount_Base
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("volumediscountamount_base"); }
        }

        /// <summary>
        /// 1:N OpportunityProduct_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("OpportunityProduct_AsyncOperations")]
        public System.Collections.Generic.IEnumerable<AsyncOperation> OpportunityProduct_AsyncOperations
        {
            get { return this.GetRelatedEntities<AsyncOperation>("OpportunityProduct_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("OpportunityProduct_AsyncOperations");
                this.SetRelatedEntities<AsyncOperation>("OpportunityProduct_AsyncOperations", null, value);
                this.OnPropertyChanged("OpportunityProduct_AsyncOperations");
            }
        }

        /// <summary>
        /// 1:N OpportunityProduct_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("OpportunityProduct_BulkDeleteFailures")]
        public System.Collections.Generic.IEnumerable<BulkDeleteFailure> OpportunityProduct_BulkDeleteFailures
        {
            get { return this.GetRelatedEntities<BulkDeleteFailure>("OpportunityProduct_BulkDeleteFailures", null); }
            set
            {
                this.OnPropertyChanging("OpportunityProduct_BulkDeleteFailures");
                this.SetRelatedEntities<BulkDeleteFailure>("OpportunityProduct_BulkDeleteFailures", null, value);
                this.OnPropertyChanged("OpportunityProduct_BulkDeleteFailures");
            }
        }

        /// <summary>
        /// 1:N OpportunityProduct_Dynamicpropertyinstance
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("OpportunityProduct_Dynamicpropertyinstance")]
        public System.Collections.Generic.IEnumerable<DynamicPropertyInstance> OpportunityProduct_Dynamicpropertyinstance
        {
            get { return this.GetRelatedEntities<DynamicPropertyInstance>("OpportunityProduct_Dynamicpropertyinstance", null); }
            set
            {
                this.OnPropertyChanging("OpportunityProduct_Dynamicpropertyinstance");
                this.SetRelatedEntities<DynamicPropertyInstance>("OpportunityProduct_Dynamicpropertyinstance", null, value);
                this.OnPropertyChanged("OpportunityProduct_Dynamicpropertyinstance");
            }
        }

        /// <summary>
        /// 1:N opportunityproduct_parent_opportunityproduct
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("opportunityproduct_parent_opportunityproduct", Microsoft.Xrm.Sdk.EntityRole.Referenced)]
        public System.Collections.Generic.IEnumerable<OpportunityProduct> Referencedopportunityproduct_parent_opportunityproduct
        {
            get { return this.GetRelatedEntities<OpportunityProduct>("opportunityproduct_parent_opportunityproduct", Microsoft.Xrm.Sdk.EntityRole.Referenced); }
            set
            {
                this.OnPropertyChanging("Referencedopportunityproduct_parent_opportunityproduct");
                this.SetRelatedEntities<OpportunityProduct>("opportunityproduct_parent_opportunityproduct", Microsoft.Xrm.Sdk.EntityRole.Referenced, value);
                this.OnPropertyChanged("Referencedopportunityproduct_parent_opportunityproduct");
            }
        }

        /// <summary>
        /// 1:N opportunityproduct_principalobjectattributeaccess
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("opportunityproduct_principalobjectattributeaccess")]
        public System.Collections.Generic.IEnumerable<PrincipalObjectAttributeAccess> opportunityproduct_principalobjectattributeaccess
        {
            get { return this.GetRelatedEntities<PrincipalObjectAttributeAccess>("opportunityproduct_principalobjectattributeaccess", null); }
            set
            {
                this.OnPropertyChanging("opportunityproduct_principalobjectattributeaccess");
                this.SetRelatedEntities<PrincipalObjectAttributeAccess>("opportunityproduct_principalobjectattributeaccess", null, value);
                this.OnPropertyChanged("opportunityproduct_principalobjectattributeaccess");
            }
        }

        /// <summary>
        /// 1:N OpportunityProduct_ProcessSessions
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("OpportunityProduct_ProcessSessions")]
        public System.Collections.Generic.IEnumerable<ProcessSession> OpportunityProduct_ProcessSessions
        {
            get { return this.GetRelatedEntities<ProcessSession>("OpportunityProduct_ProcessSessions", null); }
            set
            {
                this.OnPropertyChanging("OpportunityProduct_ProcessSessions");
                this.SetRelatedEntities<ProcessSession>("OpportunityProduct_ProcessSessions", null, value);
                this.OnPropertyChanged("OpportunityProduct_ProcessSessions");
            }
        }

        /// <summary>
        /// 1:N userentityinstancedata_opportunityproduct
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_opportunityproduct")]
        public System.Collections.Generic.IEnumerable<UserEntityInstanceData> userentityinstancedata_opportunityproduct
        {
            get { return this.GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_opportunityproduct", null); }
            set
            {
                this.OnPropertyChanging("userentityinstancedata_opportunityproduct");
                this.SetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_opportunityproduct", null, value);
                this.OnPropertyChanged("userentityinstancedata_opportunityproduct");
            }
        }

        /// <summary>
        /// N:1 lk_opportunityproduct_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_opportunityproduct_createdonbehalfby")]
        public SystemUser lk_opportunityproduct_createdonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_opportunityproduct_createdonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_opportunityproduct_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_opportunityproduct_modifiedonbehalfby")]
        public SystemUser lk_opportunityproduct_modifiedonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_opportunityproduct_modifiedonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_opportunityproductbase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_opportunityproductbase_createdby")]
        public SystemUser lk_opportunityproductbase_createdby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_opportunityproductbase_createdby", null); }
        }

        /// <summary>
        /// N:1 lk_opportunityproductbase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_opportunityproductbase_modifiedby")]
        public SystemUser lk_opportunityproductbase_modifiedby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_opportunityproductbase_modifiedby", null); }
        }

        /// <summary>
        /// N:1 opportunity_products
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("productid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("opportunity_products")]
        public Product opportunity_products
        {
            get { return this.GetRelatedEntity<Product>("opportunity_products", null); }
            set
            {
                this.OnPropertyChanging("opportunity_products");
                this.SetRelatedEntity<Product>("opportunity_products", null, value);
                this.OnPropertyChanged("opportunity_products");
            }
        }

        /// <summary>
        /// N:1 opportunityproduct_parent_opportunityproduct
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("parentbundleid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("opportunityproduct_parent_opportunityproduct", Microsoft.Xrm.Sdk.EntityRole.Referencing)]
        public OpportunityProduct Referencingopportunityproduct_parent_opportunityproduct
        {
            get { return this.GetRelatedEntity<OpportunityProduct>("opportunityproduct_parent_opportunityproduct", Microsoft.Xrm.Sdk.EntityRole.Referencing); }
            set
            {
                this.OnPropertyChanging("Referencingopportunityproduct_parent_opportunityproduct");
                this.SetRelatedEntity<OpportunityProduct>("opportunityproduct_parent_opportunityproduct", Microsoft.Xrm.Sdk.EntityRole.Referencing, value);
                this.OnPropertyChanged("Referencingopportunityproduct_parent_opportunityproduct");
            }
        }

        /// <summary>
        /// N:1 product_opportunities
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("opportunityid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("product_opportunities")]
        public Opportunity product_opportunities
        {
            get { return this.GetRelatedEntity<Opportunity>("product_opportunities", null); }
            set
            {
                this.OnPropertyChanging("product_opportunities");
                this.SetRelatedEntity<Opportunity>("product_opportunities", null, value);
                this.OnPropertyChanged("product_opportunities");
            }
        }

        /// <summary>
        /// N:1 productAssociation_opportunity_product
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("productassociationid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("productAssociation_opportunity_product")]
        public ProductAssociation productAssociation_opportunity_product
        {
            get { return this.GetRelatedEntity<ProductAssociation>("productAssociation_opportunity_product", null); }
            set
            {
                this.OnPropertyChanging("productAssociation_opportunity_product");
                this.SetRelatedEntity<ProductAssociation>("productAssociation_opportunity_product", null, value);
                this.OnPropertyChanged("productAssociation_opportunity_product");
            }
        }

        /// <summary>
        /// N:1 transactioncurrency_opportunityproduct
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("transactioncurrency_opportunityproduct")]
        public TransactionCurrency transactioncurrency_opportunityproduct
        {
            get { return this.GetRelatedEntity<TransactionCurrency>("transactioncurrency_opportunityproduct", null); }
        }

        /// <summary>
        /// N:1 unit_of_measurement_opportunity_products
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("uomid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("unit_of_measurement_opportunity_products")]
        public UoM unit_of_measurement_opportunity_products
        {
            get { return this.GetRelatedEntity<UoM>("unit_of_measurement_opportunity_products", null); }
            set
            {
                this.OnPropertyChanging("unit_of_measurement_opportunity_products");
                this.SetRelatedEntity<UoM>("unit_of_measurement_opportunity_products", null, value);
                this.OnPropertyChanged("unit_of_measurement_opportunity_products");
            }
        }
    }
}