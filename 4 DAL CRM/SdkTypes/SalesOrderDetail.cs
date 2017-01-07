namespace __4_DAL_CRM
{
    /// <summary>
    /// Line item in a sales order.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("salesorderdetail")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class SalesOrderDetail : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public SalesOrderDetail() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "salesorderdetail";

        public const int EntityTypeCode = 1089;

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
        /// Shows the total price of the order product, based on the price per unit, volume discount, and quantity.
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
        /// Type additional information to describe the order product, such as manufacturing details or acceptable substitutions.
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
        /// Shows the total amount due for the order product, based on the sum of the unit price, quantity, discounts, and tax.
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
        /// Select whether the invoice line item is copied from another item or data source.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("iscopied")]
        public System.Nullable<bool> IsCopied
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("iscopied"); }
            set
            {
                this.OnPropertyChanging("IsCopied");
                this.SetAttributeValue("iscopied", value);
                this.OnPropertyChanged("IsCopied");
            }
        }

        /// <summary>
        /// Select whether the price per unit is fixed at the value in the specified price list or can be overridden by users who have edit rights to the order product.
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
        /// Select whether the product exists in the Microsoft Dynamics CRM product catalog or is a write-in product specific to the order.
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
        /// Type the line item number for the order product to easily identify the product in the order and make sure it's listed in the correct sequence.
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
        /// Type the manual discount amount for the order product to deduct any negotiated or other savings from the product total on the order.
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
        /// Enter the user or team who is assigned to manage the record. This field is updated every time the record is assigned to a different user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ownerid")]
        public Microsoft.Xrm.Sdk.EntityReference OwnerId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("ownerid"); }
        }

        /// <summary>
        /// Unique identifier of the business unit that owns the order product.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
        public System.Nullable<System.Guid> OwningBusinessUnit
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("owningbusinessunit"); }
        }

        /// <summary>
        /// Unique identifier of the user who owns the order product.
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
        /// Type the price per unit of the order product. The default is the value in the price list specified on the order for existing products.
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
        /// Unique identifier of the product line item association with bundle in the sales order
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
        /// Type a name or description to identify the type of write-in product included in the order.
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
        /// Choose the product to include on the order to link the product's pricing and other information to the parent order.
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
        /// Type the amount or quantity of the product ordered by the customer.
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
        /// Type the amount or quantity of the product that is back ordered for the order.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("quantitybackordered")]
        public System.Nullable<decimal> QuantityBackordered
        {
            get { return this.GetAttributeValue<System.Nullable<decimal>>("quantitybackordered"); }
            set
            {
                this.OnPropertyChanging("QuantityBackordered");
                this.SetAttributeValue("quantitybackordered", value);
                this.OnPropertyChanged("QuantityBackordered");
            }
        }

        /// <summary>
        /// Type the amount or quantity of the product that was canceled.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("quantitycancelled")]
        public System.Nullable<decimal> QuantityCancelled
        {
            get { return this.GetAttributeValue<System.Nullable<decimal>>("quantitycancelled"); }
            set
            {
                this.OnPropertyChanging("QuantityCancelled");
                this.SetAttributeValue("quantitycancelled", value);
                this.OnPropertyChanged("QuantityCancelled");
            }
        }

        /// <summary>
        /// Type the amount or quantity of the product that was shipped for the order.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("quantityshipped")]
        public System.Nullable<decimal> QuantityShipped
        {
            get { return this.GetAttributeValue<System.Nullable<decimal>>("quantityshipped"); }
            set
            {
                this.OnPropertyChanging("QuantityShipped");
                this.SetAttributeValue("quantityshipped", value);
                this.OnPropertyChanged("QuantityShipped");
            }
        }

        /// <summary>
        /// Enter the delivery date requested by the customer for the order product.
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
        /// Unique identifier of the product specified in the order.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("salesorderdetailid")]
        public System.Nullable<System.Guid> SalesOrderDetailId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("salesorderdetailid"); }
            set
            {
                this.OnPropertyChanging("SalesOrderDetailId");
                this.SetAttributeValue("salesorderdetailid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("SalesOrderDetailId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("salesorderdetailid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.SalesOrderDetailId = value; }
        }

        /// <summary>
        /// Shows the order for the product. The ID is used to link product pricing and other details to the total amounts and other information on the order.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("salesorderid")]
        public Microsoft.Xrm.Sdk.EntityReference SalesOrderId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("salesorderid"); }
            set
            {
                this.OnPropertyChanging("SalesOrderId");
                this.SetAttributeValue("salesorderid", value);
                this.OnPropertyChanged("SalesOrderId");
            }
        }

        /// <summary>
        /// Tells whether product pricing is locked for the order.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("salesorderispricelocked")]
        public System.Nullable<bool> SalesOrderIsPriceLocked
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("salesorderispricelocked"); }
        }

        /// <summary>
        /// Shows the status of the order that the order detail is associated with.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("salesorderstatecode")]
        public Microsoft.Xrm.Sdk.OptionSetValue SalesOrderStateCode
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("salesorderstatecode"); }
        }

        /// <summary>
        /// Choose the user responsible for the sale of the order product.
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
        /// Type the tax amount for the order product.
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
        /// Version number of the sales order detail.
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
        /// Select whether the order product should be shipped to the specified address or held until the customer calls with further pick up or delivery instructions.
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
        /// 1:N SalesOrderDetail_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SalesOrderDetail_AsyncOperations")]
        public System.Collections.Generic.IEnumerable<AsyncOperation> SalesOrderDetail_AsyncOperations
        {
            get { return this.GetRelatedEntities<AsyncOperation>("SalesOrderDetail_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("SalesOrderDetail_AsyncOperations");
                this.SetRelatedEntities<AsyncOperation>("SalesOrderDetail_AsyncOperations", null, value);
                this.OnPropertyChanged("SalesOrderDetail_AsyncOperations");
            }
        }

        /// <summary>
        /// 1:N SalesOrderDetail_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SalesOrderDetail_BulkDeleteFailures")]
        public System.Collections.Generic.IEnumerable<BulkDeleteFailure> SalesOrderDetail_BulkDeleteFailures
        {
            get { return this.GetRelatedEntities<BulkDeleteFailure>("SalesOrderDetail_BulkDeleteFailures", null); }
            set
            {
                this.OnPropertyChanging("SalesOrderDetail_BulkDeleteFailures");
                this.SetRelatedEntities<BulkDeleteFailure>("SalesOrderDetail_BulkDeleteFailures", null, value);
                this.OnPropertyChanged("SalesOrderDetail_BulkDeleteFailures");
            }
        }

        /// <summary>
        /// 1:N SalesOrderDetail_Dynamicpropertyinstance
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SalesOrderDetail_Dynamicpropertyinstance")]
        public System.Collections.Generic.IEnumerable<DynamicPropertyInstance> SalesOrderDetail_Dynamicpropertyinstance
        {
            get { return this.GetRelatedEntities<DynamicPropertyInstance>("SalesOrderDetail_Dynamicpropertyinstance", null); }
            set
            {
                this.OnPropertyChanging("SalesOrderDetail_Dynamicpropertyinstance");
                this.SetRelatedEntities<DynamicPropertyInstance>("SalesOrderDetail_Dynamicpropertyinstance", null, value);
                this.OnPropertyChanged("SalesOrderDetail_Dynamicpropertyinstance");
            }
        }

        /// <summary>
        /// 1:N salesorderdetail_parent_salesorderdetail
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("salesorderdetail_parent_salesorderdetail", Microsoft.Xrm.Sdk.EntityRole.Referenced)]
        public System.Collections.Generic.IEnumerable<SalesOrderDetail> Referencedsalesorderdetail_parent_salesorderdetail
        {
            get { return this.GetRelatedEntities<SalesOrderDetail>("salesorderdetail_parent_salesorderdetail", Microsoft.Xrm.Sdk.EntityRole.Referenced); }
            set
            {
                this.OnPropertyChanging("Referencedsalesorderdetail_parent_salesorderdetail");
                this.SetRelatedEntities<SalesOrderDetail>("salesorderdetail_parent_salesorderdetail", Microsoft.Xrm.Sdk.EntityRole.Referenced, value);
                this.OnPropertyChanged("Referencedsalesorderdetail_parent_salesorderdetail");
            }
        }

        /// <summary>
        /// 1:N salesorderdetail_principalobjectattributeaccess
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("salesorderdetail_principalobjectattributeaccess")]
        public System.Collections.Generic.IEnumerable<PrincipalObjectAttributeAccess> salesorderdetail_principalobjectattributeaccess
        {
            get { return this.GetRelatedEntities<PrincipalObjectAttributeAccess>("salesorderdetail_principalobjectattributeaccess", null); }
            set
            {
                this.OnPropertyChanging("salesorderdetail_principalobjectattributeaccess");
                this.SetRelatedEntities<PrincipalObjectAttributeAccess>("salesorderdetail_principalobjectattributeaccess", null, value);
                this.OnPropertyChanged("salesorderdetail_principalobjectattributeaccess");
            }
        }

        /// <summary>
        /// 1:N SalesOrderDetail_ProcessSessions
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SalesOrderDetail_ProcessSessions")]
        public System.Collections.Generic.IEnumerable<ProcessSession> SalesOrderDetail_ProcessSessions
        {
            get { return this.GetRelatedEntities<ProcessSession>("SalesOrderDetail_ProcessSessions", null); }
            set
            {
                this.OnPropertyChanging("SalesOrderDetail_ProcessSessions");
                this.SetRelatedEntities<ProcessSession>("SalesOrderDetail_ProcessSessions", null, value);
                this.OnPropertyChanged("SalesOrderDetail_ProcessSessions");
            }
        }

        /// <summary>
        /// 1:N userentityinstancedata_salesorderdetail
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_salesorderdetail")]
        public System.Collections.Generic.IEnumerable<UserEntityInstanceData> userentityinstancedata_salesorderdetail
        {
            get { return this.GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_salesorderdetail", null); }
            set
            {
                this.OnPropertyChanging("userentityinstancedata_salesorderdetail");
                this.SetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_salesorderdetail", null, value);
                this.OnPropertyChanged("userentityinstancedata_salesorderdetail");
            }
        }

        /// <summary>
        /// N:1 lk_salesorderdetail_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_salesorderdetail_createdonbehalfby")]
        public SystemUser lk_salesorderdetail_createdonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_salesorderdetail_createdonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_salesorderdetail_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_salesorderdetail_modifiedonbehalfby")]
        public SystemUser lk_salesorderdetail_modifiedonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_salesorderdetail_modifiedonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_salesorderdetailbase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_salesorderdetailbase_createdby")]
        public SystemUser lk_salesorderdetailbase_createdby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_salesorderdetailbase_createdby", null); }
        }

        /// <summary>
        /// N:1 lk_salesorderdetailbase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_salesorderdetailbase_modifiedby")]
        public SystemUser lk_salesorderdetailbase_modifiedby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_salesorderdetailbase_modifiedby", null); }
        }

        /// <summary>
        /// N:1 order_details
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("salesorderid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("order_details")]
        public SalesOrder order_details
        {
            get { return this.GetRelatedEntity<SalesOrder>("order_details", null); }
            set
            {
                this.OnPropertyChanging("order_details");
                this.SetRelatedEntity<SalesOrder>("order_details", null, value);
                this.OnPropertyChanged("order_details");
            }
        }

        /// <summary>
        /// N:1 product_order_details
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("productid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("product_order_details")]
        public Product product_order_details
        {
            get { return this.GetRelatedEntity<Product>("product_order_details", null); }
            set
            {
                this.OnPropertyChanging("product_order_details");
                this.SetRelatedEntity<Product>("product_order_details", null, value);
                this.OnPropertyChanged("product_order_details");
            }
        }

        /// <summary>
        /// N:1 productAssociation_salesorder_details
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("productassociationid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("productAssociation_salesorder_details")]
        public ProductAssociation productAssociation_salesorder_details
        {
            get { return this.GetRelatedEntity<ProductAssociation>("productAssociation_salesorder_details", null); }
            set
            {
                this.OnPropertyChanging("productAssociation_salesorder_details");
                this.SetRelatedEntity<ProductAssociation>("productAssociation_salesorder_details", null, value);
                this.OnPropertyChanged("productAssociation_salesorder_details");
            }
        }

        /// <summary>
        /// N:1 salesorderdetail_parent_salesorderdetail
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("parentbundleid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("salesorderdetail_parent_salesorderdetail", Microsoft.Xrm.Sdk.EntityRole.Referencing)]
        public SalesOrderDetail Referencingsalesorderdetail_parent_salesorderdetail
        {
            get { return this.GetRelatedEntity<SalesOrderDetail>("salesorderdetail_parent_salesorderdetail", Microsoft.Xrm.Sdk.EntityRole.Referencing); }
            set
            {
                this.OnPropertyChanging("Referencingsalesorderdetail_parent_salesorderdetail");
                this.SetRelatedEntity<SalesOrderDetail>("salesorderdetail_parent_salesorderdetail", Microsoft.Xrm.Sdk.EntityRole.Referencing, value);
                this.OnPropertyChanged("Referencingsalesorderdetail_parent_salesorderdetail");
            }
        }

        /// <summary>
        /// N:1 system_user_salesorderdetail
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("salesrepid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("system_user_salesorderdetail")]
        public SystemUser system_user_salesorderdetail
        {
            get { return this.GetRelatedEntity<SystemUser>("system_user_salesorderdetail", null); }
            set
            {
                this.OnPropertyChanging("system_user_salesorderdetail");
                this.SetRelatedEntity<SystemUser>("system_user_salesorderdetail", null, value);
                this.OnPropertyChanged("system_user_salesorderdetail");
            }
        }

        /// <summary>
        /// N:1 transactioncurrency_salesorderdetail
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("transactioncurrency_salesorderdetail")]
        public TransactionCurrency transactioncurrency_salesorderdetail
        {
            get { return this.GetRelatedEntity<TransactionCurrency>("transactioncurrency_salesorderdetail", null); }
        }

        /// <summary>
        /// N:1 unit_of_measurement_order_details
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("uomid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("unit_of_measurement_order_details")]
        public UoM unit_of_measurement_order_details
        {
            get { return this.GetRelatedEntity<UoM>("unit_of_measurement_order_details", null); }
            set
            {
                this.OnPropertyChanging("unit_of_measurement_order_details");
                this.SetRelatedEntity<UoM>("unit_of_measurement_order_details", null, value);
                this.OnPropertyChanged("unit_of_measurement_order_details");
            }
        }
    }
}