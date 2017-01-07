namespace __4_DAL_CRM
{
    /// <summary>
    /// Product line item in a quote. The details include such information as product ID, description, quantity, and cost.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("quotedetail")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class QuoteDetail : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public QuoteDetail() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "quotedetail";

        public const int EntityTypeCode = 1085;

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
        /// Shows the total price of the quote product, based on the price per unit, volume discount, and quantity.
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
        /// Type additional information to describe the quote product, such as manufacturing details or acceptable substitutions.
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
        /// Shows the conversion rate of the record's currency. The exchange rate is used to convert all money fields in the record from the local currency to the system's default currency.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("exchangerate")]
        public System.Nullable<decimal> ExchangeRate
        {
            get { return this.GetAttributeValue<System.Nullable<decimal>>("exchangerate"); }
        }

        /// <summary>
        /// Shows the total amount due for the quote product, based on the sum of the unit price, quantity, discounts ,and tax.
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
        /// Select whether the price per unit is fixed at the value in the specified price list or can be overridden by users who have edit rights to the quote product.
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
        /// Select whether the product exists in the Microsoft Dynamics CRM product catalog or is a write-in product specific to the quote.
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
        /// Type the line item number for the quote product to easily identify the product in the quote and make sure it's listed in the correct order.
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
        /// Type the manual discount amount for the quote product to deduct any negotiated or other savings from the product total on the quote.
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
        /// Shows who last updated the record on behalf of another user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby"); }
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
        /// Unique identifier of the user or team who owns the quote detail.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ownerid")]
        public Microsoft.Xrm.Sdk.EntityReference OwnerId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("ownerid"); }
        }

        /// <summary>
        /// Unique identifier of the business unit that owns the quote detail.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
        public System.Nullable<System.Guid> OwningBusinessUnit
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("owningbusinessunit"); }
        }

        /// <summary>
        /// Unique identifier of the user who owns the quote detail.
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
        /// Type the price per unit of the quote product. The default is to the value in the price list specified on the quote for existing products.
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
        /// Select the type of pricing error, such as a missing or invalid product, or missing quantity.
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
        /// Unique identifier of the product line item association with bundle in the quote
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
        /// Type a name or description to identify the type of write-in product included in the quote.
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
        /// Choose the product to include on the quote to link the product's pricing and other information to the quote.
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
        /// Type the amount or quantity of the product requested by the customer.
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
        /// Unique identifier of the product line item in the quote.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("quotedetailid")]
        public System.Nullable<System.Guid> QuoteDetailId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("quotedetailid"); }
            set
            {
                this.OnPropertyChanging("QuoteDetailId");
                this.SetAttributeValue("quotedetailid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("QuoteDetailId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("quotedetailid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.QuoteDetailId = value; }
        }

        /// <summary>
        /// Unique identifier of the quote for the quote product.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("quoteid")]
        public Microsoft.Xrm.Sdk.EntityReference QuoteId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("quoteid"); }
            set
            {
                this.OnPropertyChanging("QuoteId");
                this.SetAttributeValue("quoteid", value);
                this.OnPropertyChanged("QuoteId");
            }
        }

        /// <summary>
        /// Status of the quote product.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("quotestatecode")]
        public Microsoft.Xrm.Sdk.OptionSetValue QuoteStateCode
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("quotestatecode"); }
        }

        /// <summary>
        /// Enter the delivery date requested by the customer for the quote product.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("requestdeliveryby")]
        public System.Nullable<System.DateTime> RequestDeliveryBy
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("requestdeliveryby"); }
            set
            {
                this.OnPropertyChanging("RequestDeliveryBy");
                this.SetAttributeValue("requestdeliveryby", value);
                this.OnPropertyChanged("RequestDeliveryBy");
            }
        }

        /// <summary>
        /// Choose the user responsible for the sale of the quote product.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("salesrepid")]
        public Microsoft.Xrm.Sdk.EntityReference SalesRepId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("salesrepid"); }
            set
            {
                this.OnPropertyChanging("SalesRepId");
                this.SetAttributeValue("salesrepid", value);
                this.OnPropertyChanged("SalesRepId");
            }
        }

        /// <summary>
        /// Unique identifier of the data that maintains the sequence.
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
        /// Unique identifier of the shipping address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("shipto_addressid")]
        public System.Nullable<System.Guid> ShipTo_AddressId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("shipto_addressid"); }
            set
            {
                this.OnPropertyChanging("ShipTo_AddressId");
                this.SetAttributeValue("shipto_addressid", value);
                this.OnPropertyChanged("ShipTo_AddressId");
            }
        }

        /// <summary>
        /// Type the city for the customer's shipping address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("shipto_city")]
        public string ShipTo_City
        {
            get { return this.GetAttributeValue<string>("shipto_city"); }
            set
            {
                this.OnPropertyChanging("ShipTo_City");
                this.SetAttributeValue("shipto_city", value);
                this.OnPropertyChanged("ShipTo_City");
            }
        }

        /// <summary>
        /// Type the primary contact name at the customer's shipping address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("shipto_contactname")]
        public string ShipTo_ContactName
        {
            get { return this.GetAttributeValue<string>("shipto_contactname"); }
            set
            {
                this.OnPropertyChanging("ShipTo_ContactName");
                this.SetAttributeValue("shipto_contactname", value);
                this.OnPropertyChanged("ShipTo_ContactName");
            }
        }

        /// <summary>
        /// Type the country or region for the customer's shipping address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("shipto_country")]
        public string ShipTo_Country
        {
            get { return this.GetAttributeValue<string>("shipto_country"); }
            set
            {
                this.OnPropertyChanging("ShipTo_Country");
                this.SetAttributeValue("shipto_country", value);
                this.OnPropertyChanged("ShipTo_Country");
            }
        }

        /// <summary>
        /// Type the fax number for the customer's shipping address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("shipto_fax")]
        public string ShipTo_Fax
        {
            get { return this.GetAttributeValue<string>("shipto_fax"); }
            set
            {
                this.OnPropertyChanging("ShipTo_Fax");
                this.SetAttributeValue("shipto_fax", value);
                this.OnPropertyChanged("ShipTo_Fax");
            }
        }

        /// <summary>
        /// Select the freight terms to make sure shipping orders are processed correctly.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("shipto_freighttermscode")]
        public Microsoft.Xrm.Sdk.OptionSetValue ShipTo_FreightTermsCode
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("shipto_freighttermscode"); }
            set
            {
                this.OnPropertyChanging("ShipTo_FreightTermsCode");
                this.SetAttributeValue("shipto_freighttermscode", value);
                this.OnPropertyChanged("ShipTo_FreightTermsCode");
            }
        }

        /// <summary>
        /// Type the first line of the customer's shipping address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("shipto_line1")]
        public string ShipTo_Line1
        {
            get { return this.GetAttributeValue<string>("shipto_line1"); }
            set
            {
                this.OnPropertyChanging("ShipTo_Line1");
                this.SetAttributeValue("shipto_line1", value);
                this.OnPropertyChanged("ShipTo_Line1");
            }
        }

        /// <summary>
        /// Type the second line of the customer's shipping address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("shipto_line2")]
        public string ShipTo_Line2
        {
            get { return this.GetAttributeValue<string>("shipto_line2"); }
            set
            {
                this.OnPropertyChanging("ShipTo_Line2");
                this.SetAttributeValue("shipto_line2", value);
                this.OnPropertyChanged("ShipTo_Line2");
            }
        }

        /// <summary>
        /// Type the third line of the shipping address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("shipto_line3")]
        public string ShipTo_Line3
        {
            get { return this.GetAttributeValue<string>("shipto_line3"); }
            set
            {
                this.OnPropertyChanging("ShipTo_Line3");
                this.SetAttributeValue("shipto_line3", value);
                this.OnPropertyChanged("ShipTo_Line3");
            }
        }

        /// <summary>
        /// Type a name for the customer's shipping address, such as "Headquarters" or "Field office", to identify the address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("shipto_name")]
        public string ShipTo_Name
        {
            get { return this.GetAttributeValue<string>("shipto_name"); }
            set
            {
                this.OnPropertyChanging("ShipTo_Name");
                this.SetAttributeValue("shipto_name", value);
                this.OnPropertyChanged("ShipTo_Name");
            }
        }

        /// <summary>
        /// Type the ZIP Code or postal code for the shipping address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("shipto_postalcode")]
        public string ShipTo_PostalCode
        {
            get { return this.GetAttributeValue<string>("shipto_postalcode"); }
            set
            {
                this.OnPropertyChanging("ShipTo_PostalCode");
                this.SetAttributeValue("shipto_postalcode", value);
                this.OnPropertyChanged("ShipTo_PostalCode");
            }
        }

        /// <summary>
        /// Type the state or province for the shipping address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("shipto_stateorprovince")]
        public string ShipTo_StateOrProvince
        {
            get { return this.GetAttributeValue<string>("shipto_stateorprovince"); }
            set
            {
                this.OnPropertyChanging("ShipTo_StateOrProvince");
                this.SetAttributeValue("shipto_stateorprovince", value);
                this.OnPropertyChanged("ShipTo_StateOrProvince");
            }
        }

        /// <summary>
        /// Type the phone number for the customer's shipping address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("shipto_telephone")]
        public string ShipTo_Telephone
        {
            get { return this.GetAttributeValue<string>("shipto_telephone"); }
            set
            {
                this.OnPropertyChanging("ShipTo_Telephone");
                this.SetAttributeValue("shipto_telephone", value);
                this.OnPropertyChanged("ShipTo_Telephone");
            }
        }

        /// <summary>
        /// Type the tax amount for the quote product.
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
        /// Version number of the quote detail.
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
        /// Shows the discount amount per unit if a specified volume is purchased. Configure volume discounts in the Product Catalog in the Settings area.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("volumediscountamount_base")]
        public Microsoft.Xrm.Sdk.Money VolumeDiscountAmount_Base
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("volumediscountamount_base"); }
        }

        /// <summary>
        /// Select whether the quote product should be shipped to the specified address or held until the customer calls with further pick up or delivery instructions.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("willcall")]
        public System.Nullable<bool> WillCall
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("willcall"); }
            set
            {
                this.OnPropertyChanging("WillCall");
                this.SetAttributeValue("willcall", value);
                this.OnPropertyChanged("WillCall");
            }
        }

        /// <summary>
        /// 1:N QuoteDetail_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("QuoteDetail_AsyncOperations")]
        public System.Collections.Generic.IEnumerable<AsyncOperation> QuoteDetail_AsyncOperations
        {
            get { return this.GetRelatedEntities<AsyncOperation>("QuoteDetail_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("QuoteDetail_AsyncOperations");
                this.SetRelatedEntities<AsyncOperation>("QuoteDetail_AsyncOperations", null, value);
                this.OnPropertyChanged("QuoteDetail_AsyncOperations");
            }
        }

        /// <summary>
        /// 1:N QuoteDetail_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("QuoteDetail_BulkDeleteFailures")]
        public System.Collections.Generic.IEnumerable<BulkDeleteFailure> QuoteDetail_BulkDeleteFailures
        {
            get { return this.GetRelatedEntities<BulkDeleteFailure>("QuoteDetail_BulkDeleteFailures", null); }
            set
            {
                this.OnPropertyChanging("QuoteDetail_BulkDeleteFailures");
                this.SetRelatedEntities<BulkDeleteFailure>("QuoteDetail_BulkDeleteFailures", null, value);
                this.OnPropertyChanged("QuoteDetail_BulkDeleteFailures");
            }
        }

        /// <summary>
        /// 1:N QuoteDetail_Dynamicpropertyinstance
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("QuoteDetail_Dynamicpropertyinstance")]
        public System.Collections.Generic.IEnumerable<DynamicPropertyInstance> QuoteDetail_Dynamicpropertyinstance
        {
            get { return this.GetRelatedEntities<DynamicPropertyInstance>("QuoteDetail_Dynamicpropertyinstance", null); }
            set
            {
                this.OnPropertyChanging("QuoteDetail_Dynamicpropertyinstance");
                this.SetRelatedEntities<DynamicPropertyInstance>("QuoteDetail_Dynamicpropertyinstance", null, value);
                this.OnPropertyChanged("QuoteDetail_Dynamicpropertyinstance");
            }
        }

        /// <summary>
        /// 1:N quotedetail_parent_quotedetail
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("quotedetail_parent_quotedetail", Microsoft.Xrm.Sdk.EntityRole.Referenced)]
        public System.Collections.Generic.IEnumerable<QuoteDetail> Referencedquotedetail_parent_quotedetail
        {
            get { return this.GetRelatedEntities<QuoteDetail>("quotedetail_parent_quotedetail", Microsoft.Xrm.Sdk.EntityRole.Referenced); }
            set
            {
                this.OnPropertyChanging("Referencedquotedetail_parent_quotedetail");
                this.SetRelatedEntities<QuoteDetail>("quotedetail_parent_quotedetail", Microsoft.Xrm.Sdk.EntityRole.Referenced, value);
                this.OnPropertyChanged("Referencedquotedetail_parent_quotedetail");
            }
        }

        /// <summary>
        /// 1:N quotedetail_principalobjectattributeaccess
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("quotedetail_principalobjectattributeaccess")]
        public System.Collections.Generic.IEnumerable<PrincipalObjectAttributeAccess> quotedetail_principalobjectattributeaccess
        {
            get { return this.GetRelatedEntities<PrincipalObjectAttributeAccess>("quotedetail_principalobjectattributeaccess", null); }
            set
            {
                this.OnPropertyChanging("quotedetail_principalobjectattributeaccess");
                this.SetRelatedEntities<PrincipalObjectAttributeAccess>("quotedetail_principalobjectattributeaccess", null, value);
                this.OnPropertyChanged("quotedetail_principalobjectattributeaccess");
            }
        }

        /// <summary>
        /// 1:N QuoteDetail_ProcessSessions
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("QuoteDetail_ProcessSessions")]
        public System.Collections.Generic.IEnumerable<ProcessSession> QuoteDetail_ProcessSessions
        {
            get { return this.GetRelatedEntities<ProcessSession>("QuoteDetail_ProcessSessions", null); }
            set
            {
                this.OnPropertyChanging("QuoteDetail_ProcessSessions");
                this.SetRelatedEntities<ProcessSession>("QuoteDetail_ProcessSessions", null, value);
                this.OnPropertyChanged("QuoteDetail_ProcessSessions");
            }
        }

        /// <summary>
        /// 1:N userentityinstancedata_quotedetail
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_quotedetail")]
        public System.Collections.Generic.IEnumerable<UserEntityInstanceData> userentityinstancedata_quotedetail
        {
            get { return this.GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_quotedetail", null); }
            set
            {
                this.OnPropertyChanging("userentityinstancedata_quotedetail");
                this.SetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_quotedetail", null, value);
                this.OnPropertyChanged("userentityinstancedata_quotedetail");
            }
        }

        /// <summary>
        /// N:1 lk_quotedetail_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_quotedetail_createdonbehalfby")]
        public SystemUser lk_quotedetail_createdonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_quotedetail_createdonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_quotedetail_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_quotedetail_modifiedonbehalfby")]
        public SystemUser lk_quotedetail_modifiedonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_quotedetail_modifiedonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_quotedetailbase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_quotedetailbase_createdby")]
        public SystemUser lk_quotedetailbase_createdby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_quotedetailbase_createdby", null); }
        }

        /// <summary>
        /// N:1 lk_quotedetailbase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_quotedetailbase_modifiedby")]
        public SystemUser lk_quotedetailbase_modifiedby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_quotedetailbase_modifiedby", null); }
        }

        /// <summary>
        /// N:1 product_quote_details
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("productid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("product_quote_details")]
        public Product product_quote_details
        {
            get { return this.GetRelatedEntity<Product>("product_quote_details", null); }
            set
            {
                this.OnPropertyChanging("product_quote_details");
                this.SetRelatedEntity<Product>("product_quote_details", null, value);
                this.OnPropertyChanged("product_quote_details");
            }
        }

        /// <summary>
        /// N:1 productAssociation_quote_details
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("productassociationid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("productAssociation_quote_details")]
        public ProductAssociation productAssociation_quote_details
        {
            get { return this.GetRelatedEntity<ProductAssociation>("productAssociation_quote_details", null); }
            set
            {
                this.OnPropertyChanging("productAssociation_quote_details");
                this.SetRelatedEntity<ProductAssociation>("productAssociation_quote_details", null, value);
                this.OnPropertyChanged("productAssociation_quote_details");
            }
        }

        /// <summary>
        /// N:1 quote_details
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("quoteid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("quote_details")]
        public Quote quote_details
        {
            get { return this.GetRelatedEntity<Quote>("quote_details", null); }
            set
            {
                this.OnPropertyChanging("quote_details");
                this.SetRelatedEntity<Quote>("quote_details", null, value);
                this.OnPropertyChanged("quote_details");
            }
        }

        /// <summary>
        /// N:1 quotedetail_parent_quotedetail
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("parentbundleid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("quotedetail_parent_quotedetail", Microsoft.Xrm.Sdk.EntityRole.Referencing)]
        public QuoteDetail Referencingquotedetail_parent_quotedetail
        {
            get { return this.GetRelatedEntity<QuoteDetail>("quotedetail_parent_quotedetail", Microsoft.Xrm.Sdk.EntityRole.Referencing); }
            set
            {
                this.OnPropertyChanging("Referencingquotedetail_parent_quotedetail");
                this.SetRelatedEntity<QuoteDetail>("quotedetail_parent_quotedetail", Microsoft.Xrm.Sdk.EntityRole.Referencing, value);
                this.OnPropertyChanged("Referencingquotedetail_parent_quotedetail");
            }
        }

        /// <summary>
        /// N:1 system_user_quotedetail
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("salesrepid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("system_user_quotedetail")]
        public SystemUser system_user_quotedetail
        {
            get { return this.GetRelatedEntity<SystemUser>("system_user_quotedetail", null); }
            set
            {
                this.OnPropertyChanging("system_user_quotedetail");
                this.SetRelatedEntity<SystemUser>("system_user_quotedetail", null, value);
                this.OnPropertyChanged("system_user_quotedetail");
            }
        }

        /// <summary>
        /// N:1 transactioncurrency_quotedetail
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("transactioncurrency_quotedetail")]
        public TransactionCurrency transactioncurrency_quotedetail
        {
            get { return this.GetRelatedEntity<TransactionCurrency>("transactioncurrency_quotedetail", null); }
        }

        /// <summary>
        /// N:1 unit_of_measurement_quote_details
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("uomid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("unit_of_measurement_quote_details")]
        public UoM unit_of_measurement_quote_details
        {
            get { return this.GetRelatedEntity<UoM>("unit_of_measurement_quote_details", null); }
            set
            {
                this.OnPropertyChanging("unit_of_measurement_quote_details");
                this.SetRelatedEntity<UoM>("unit_of_measurement_quote_details", null, value);
                this.OnPropertyChanged("unit_of_measurement_quote_details");
            }
        }
    }
}