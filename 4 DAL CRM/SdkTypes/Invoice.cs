using _4_DAL_CRM;

namespace __4_DAL_CRM
{
    /// <summary>
    /// Order that has been billed.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("invoice")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class Invoice : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public Invoice() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "invoice";

        public const int EntityTypeCode = 1090;

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
        /// Unique identifier of the account with which the invoice is associated.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("accountid")]
        public Microsoft.Xrm.Sdk.EntityReference AccountId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("accountid"); }
        }

        /// <summary>
        /// Type the city for the customer's billing address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("billto_city")]
        public string BillTo_City
        {
            get { return this.GetAttributeValue<string>("billto_city"); }
            set
            {
                this.OnPropertyChanging("BillTo_City");
                this.SetAttributeValue("billto_city", value);
                this.OnPropertyChanged("BillTo_City");
            }
        }

        /// <summary>
        /// Shows the complete Bill To address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("billto_composite")]
        public string BillTo_Composite
        {
            get { return this.GetAttributeValue<string>("billto_composite"); }
        }

        /// <summary>
        /// Type the country or region for the customer's billing address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("billto_country")]
        public string BillTo_Country
        {
            get { return this.GetAttributeValue<string>("billto_country"); }
            set
            {
                this.OnPropertyChanging("BillTo_Country");
                this.SetAttributeValue("billto_country", value);
                this.OnPropertyChanged("BillTo_Country");
            }
        }

        /// <summary>
        /// Type the fax number for the customer's billing address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("billto_fax")]
        public string BillTo_Fax
        {
            get { return this.GetAttributeValue<string>("billto_fax"); }
            set
            {
                this.OnPropertyChanging("BillTo_Fax");
                this.SetAttributeValue("billto_fax", value);
                this.OnPropertyChanged("BillTo_Fax");
            }
        }

        /// <summary>
        /// Type the first line of the customer's billing address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("billto_line1")]
        public string BillTo_Line1
        {
            get { return this.GetAttributeValue<string>("billto_line1"); }
            set
            {
                this.OnPropertyChanging("BillTo_Line1");
                this.SetAttributeValue("billto_line1", value);
                this.OnPropertyChanged("BillTo_Line1");
            }
        }

        /// <summary>
        /// Type the second line of the customer's billing address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("billto_line2")]
        public string BillTo_Line2
        {
            get { return this.GetAttributeValue<string>("billto_line2"); }
            set
            {
                this.OnPropertyChanging("BillTo_Line2");
                this.SetAttributeValue("billto_line2", value);
                this.OnPropertyChanged("BillTo_Line2");
            }
        }

        /// <summary>
        /// Type the third line of the billing address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("billto_line3")]
        public string BillTo_Line3
        {
            get { return this.GetAttributeValue<string>("billto_line3"); }
            set
            {
                this.OnPropertyChanging("BillTo_Line3");
                this.SetAttributeValue("billto_line3", value);
                this.OnPropertyChanged("BillTo_Line3");
            }
        }

        /// <summary>
        /// Type a name for the customer's billing address, such as "Headquarters" or "Field office", to identify the address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("billto_name")]
        public string BillTo_Name
        {
            get { return this.GetAttributeValue<string>("billto_name"); }
            set
            {
                this.OnPropertyChanging("BillTo_Name");
                this.SetAttributeValue("billto_name", value);
                this.OnPropertyChanged("BillTo_Name");
            }
        }

        /// <summary>
        /// Type the ZIP Code or postal code for the billing address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("billto_postalcode")]
        public string BillTo_PostalCode
        {
            get { return this.GetAttributeValue<string>("billto_postalcode"); }
            set
            {
                this.OnPropertyChanging("BillTo_PostalCode");
                this.SetAttributeValue("billto_postalcode", value);
                this.OnPropertyChanged("BillTo_PostalCode");
            }
        }

        /// <summary>
        /// Type the state or province for the billing address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("billto_stateorprovince")]
        public string BillTo_StateOrProvince
        {
            get { return this.GetAttributeValue<string>("billto_stateorprovince"); }
            set
            {
                this.OnPropertyChanging("BillTo_StateOrProvince");
                this.SetAttributeValue("billto_stateorprovince", value);
                this.OnPropertyChanged("BillTo_StateOrProvince");
            }
        }

        /// <summary>
        /// Type the phone number for the customer's billing address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("billto_telephone")]
        public string BillTo_Telephone
        {
            get { return this.GetAttributeValue<string>("billto_telephone"); }
            set
            {
                this.OnPropertyChanging("BillTo_Telephone");
                this.SetAttributeValue("billto_telephone", value);
                this.OnPropertyChanged("BillTo_Telephone");
            }
        }

        /// <summary>
        /// Unique identifier of the contact associated with the invoice.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("contactid")]
        public Microsoft.Xrm.Sdk.EntityReference ContactId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("contactid"); }
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
        /// Select the customer account or contact to provide a quick link to additional customer details, such as account information, activities, and opportunities.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("customerid")]
        public Microsoft.Xrm.Sdk.EntityReference CustomerId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("customerid"); }
            set
            {
                this.OnPropertyChanging("CustomerId");
                this.SetAttributeValue("customerid", value);
                this.OnPropertyChanged("CustomerId");
            }
        }

        /// <summary>
        /// Enter the date when the products included in the invoice were delivered.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("datedelivered")]
        public System.Nullable<System.DateTime> DateDelivered
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("datedelivered"); }
            set
            {
                this.OnPropertyChanging("DateDelivered");
                this.SetAttributeValue("datedelivered", value);
                this.OnPropertyChanged("DateDelivered");
            }
        }

        /// <summary>
        /// Type additional information to describe the invoice, such as shipping details or product substitutions.
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
        /// Type the discount amount for the invoice if the customer is eligible for special savings.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("discountamount")]
        public Microsoft.Xrm.Sdk.Money DiscountAmount
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("discountamount"); }
            set
            {
                this.OnPropertyChanging("DiscountAmount");
                this.SetAttributeValue("discountamount", value);
                this.OnPropertyChanged("DiscountAmount");
            }
        }

        /// <summary>
        /// Shows the Invoice Discount field converted to the system's default base currency for reporting purposes. The calculation uses the exchange rate specified in the Currencies area.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("discountamount_base")]
        public Microsoft.Xrm.Sdk.Money DiscountAmount_Base
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("discountamount_base"); }
        }

        /// <summary>
        /// Type the discount rate that should be applied to the Detail Amount field, for use in calculating the Pre-Freight Amount and Total Amount values for the invoice.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("discountpercentage")]
        public System.Nullable<decimal> DiscountPercentage
        {
            get { return this.GetAttributeValue<System.Nullable<decimal>>("discountpercentage"); }
            set
            {
                this.OnPropertyChanging("DiscountPercentage");
                this.SetAttributeValue("discountpercentage", value);
                this.OnPropertyChanged("DiscountPercentage");
            }
        }

        /// <summary>
        /// Enter the date by which the invoice should be paid by the customer.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("duedate")]
        public System.Nullable<System.DateTime> DueDate
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("duedate"); }
            set
            {
                this.OnPropertyChanging("DueDate");
                this.SetAttributeValue("duedate", value);
                this.OnPropertyChanged("DueDate");
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
        /// Type the cost of freight or shipping for the products included in the invoice for use in calculating the total amount due.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("freightamount")]
        public Microsoft.Xrm.Sdk.Money FreightAmount
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("freightamount"); }
            set
            {
                this.OnPropertyChanging("FreightAmount");
                this.SetAttributeValue("freightamount", value);
                this.OnPropertyChanged("FreightAmount");
            }
        }

        /// <summary>
        /// Shows the Freight Amount field converted to the system's default base currency for reporting purposes. The calculation uses the exchange rate specified in the Currencies area.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("freightamount_base")]
        public Microsoft.Xrm.Sdk.Money FreightAmount_Base
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("freightamount_base"); }
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
        /// Unique identifier of the invoice.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("invoiceid")]
        public System.Nullable<System.Guid> InvoiceId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("invoiceid"); }
            set
            {
                this.OnPropertyChanging("InvoiceId");
                this.SetAttributeValue("invoiceid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("InvoiceId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("invoiceid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.InvoiceId = value; }
        }

        /// <summary>
        /// Shows the identifying number or code of the invoice.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("invoicenumber")]
        public string InvoiceNumber
        {
            get { return this.GetAttributeValue<string>("invoicenumber"); }
            set
            {
                this.OnPropertyChanging("InvoiceNumber");
                this.SetAttributeValue("invoicenumber", value);
                this.OnPropertyChanged("InvoiceNumber");
            }
        }

        /// <summary>
        /// Select whether prices specified on the invoice are locked from any further updates.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ispricelocked")]
        public System.Nullable<bool> IsPriceLocked
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("ispricelocked"); }
            set
            {
                this.OnPropertyChanging("IsPriceLocked");
                this.SetAttributeValue("ispricelocked", value);
                this.OnPropertyChanged("IsPriceLocked");
            }
        }

        /// <summary>
        /// Enter the date and time when the invoice was last submitted to an accounting or ERP system for processing.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("lastbackofficesubmit")]
        public System.Nullable<System.DateTime> LastBackofficeSubmit
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("lastbackofficesubmit"); }
            set
            {
                this.OnPropertyChanging("LastBackofficeSubmit");
                this.SetAttributeValue("lastbackofficesubmit", value);
                this.OnPropertyChanged("LastBackofficeSubmit");
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
        /// Type a descriptive name for the invoice.
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
        /// Choose the opportunity that the invoice is related to for reporting and analytics.
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
            set
            {
                this.OnPropertyChanging("OwnerId");
                this.SetAttributeValue("ownerid", value);
                this.OnPropertyChanged("OwnerId");
            }
        }

        /// <summary>
        /// Unique identifier of the business unit that owns the invoice.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
        public Microsoft.Xrm.Sdk.EntityReference OwningBusinessUnit
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningbusinessunit"); }
        }

        /// <summary>
        /// Unique identifier of the team who owns the invoice.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
        public Microsoft.Xrm.Sdk.EntityReference OwningTeam
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningteam"); }
        }

        /// <summary>
        /// Unique identifier of the user who owns the invoice.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
        public Microsoft.Xrm.Sdk.EntityReference OwningUser
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owninguser"); }
        }

        /// <summary>
        /// Select the payment terms to indicate when the customer needs to pay the total amount.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("paymenttermscode")]
        public Microsoft.Xrm.Sdk.OptionSetValue PaymentTermsCode
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("paymenttermscode"); }
            set
            {
                this.OnPropertyChanging("PaymentTermsCode");
                this.SetAttributeValue("paymenttermscode", value);
                this.OnPropertyChanged("PaymentTermsCode");
            }
        }

        /// <summary>
        /// Choose the price list associated with this record to make sure the products associated with the campaign are offered at the correct prices.
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
        /// Type of pricing error for the invoice.
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
        /// Select the priority so that preferred customers or critical issues are handled quickly.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("prioritycode")]
        public Microsoft.Xrm.Sdk.OptionSetValue PriorityCode
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("prioritycode"); }
            set
            {
                this.OnPropertyChanging("PriorityCode");
                this.SetAttributeValue("prioritycode", value);
                this.OnPropertyChanged("PriorityCode");
            }
        }

        /// <summary>
        /// Shows the ID of the process.
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
        /// Choose the order related to the invoice to make sure the order is fulfilled and invoiced correctly.
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
        /// Select a shipping method for deliveries sent to this address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("shippingmethodcode")]
        public Microsoft.Xrm.Sdk.OptionSetValue ShippingMethodCode
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("shippingmethodcode"); }
            set
            {
                this.OnPropertyChanging("ShippingMethodCode");
                this.SetAttributeValue("shippingmethodcode", value);
                this.OnPropertyChanged("ShippingMethodCode");
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
        /// Shows the complete Ship To address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("shipto_composite")]
        public string ShipTo_Composite
        {
            get { return this.GetAttributeValue<string>("shipto_composite"); }
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
        /// Shows whether the invoice is active, paid, or canceled. Paid and canceled invoices are read-only and can't be edited unless they are reactivated.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
        public System.Nullable<InvoiceState> StateCode
        {
            get
            {
                Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
                if ((optionSet != null))
                {
                    return ((InvoiceState) (System.Enum.ToObject(typeof(InvoiceState), optionSet.Value)));
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// Select the invoice's status.
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
        /// Shows the total amount due, calculated as the sum of the products, discount, freight, and taxes for the invoice.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("totalamount")]
        public Microsoft.Xrm.Sdk.Money TotalAmount
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("totalamount"); }
            set
            {
                this.OnPropertyChanging("TotalAmount");
                this.SetAttributeValue("totalamount", value);
                this.OnPropertyChanged("TotalAmount");
            }
        }

        /// <summary>
        /// Shows the Total Amount field converted to the system's default base currency for reporting purposes. The calculation uses the exchange rate specified in the Currencies area.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("totalamount_base")]
        public Microsoft.Xrm.Sdk.Money TotalAmount_Base
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("totalamount_base"); }
        }

        /// <summary>
        /// Shows the total product amount due, minus any discounts. This value is added to freight and tax amounts in the calculation for the total amount due for the invoice.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("totalamountlessfreight")]
        public Microsoft.Xrm.Sdk.Money TotalAmountLessFreight
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("totalamountlessfreight"); }
            set
            {
                this.OnPropertyChanging("TotalAmountLessFreight");
                this.SetAttributeValue("totalamountlessfreight", value);
                this.OnPropertyChanged("TotalAmountLessFreight");
            }
        }

        /// <summary>
        /// Shows the Pre-Freight Amount field converted to the system's default base currency for reporting purposes. The calculation uses the exchange rate specified in the Currencies area.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("totalamountlessfreight_base")]
        public Microsoft.Xrm.Sdk.Money TotalAmountLessFreight_Base
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("totalamountlessfreight_base"); }
        }

        /// <summary>
        /// Shows the total discount amount, based on the discount price and rate entered on the invoice.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("totaldiscountamount")]
        public Microsoft.Xrm.Sdk.Money TotalDiscountAmount
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("totaldiscountamount"); }
            set
            {
                this.OnPropertyChanging("TotalDiscountAmount");
                this.SetAttributeValue("totaldiscountamount", value);
                this.OnPropertyChanged("TotalDiscountAmount");
            }
        }

        /// <summary>
        /// Shows the Total Discount Amount field converted to the system's default base currency for reporting purposes. The calculation uses the exchange rate specified in the Currencies area.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("totaldiscountamount_base")]
        public Microsoft.Xrm.Sdk.Money TotalDiscountAmount_Base
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("totaldiscountamount_base"); }
        }

        /// <summary>
        /// Shows the sum of all existing and write-in products included on the invoice, based on the specified price list and quantities.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("totallineitemamount")]
        public Microsoft.Xrm.Sdk.Money TotalLineItemAmount
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("totallineitemamount"); }
            set
            {
                this.OnPropertyChanging("TotalLineItemAmount");
                this.SetAttributeValue("totallineitemamount", value);
                this.OnPropertyChanged("TotalLineItemAmount");
            }
        }

        /// <summary>
        /// Shows the Detail Amount field converted to the system's default base currency. The calculation uses the exchange rate specified in the Currencies area.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("totallineitemamount_base")]
        public Microsoft.Xrm.Sdk.Money TotalLineItemAmount_Base
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("totallineitemamount_base"); }
        }

        /// <summary>
        /// Shows the Manual Discount amounts specified on all products included in the invoice. This value is reflected in the Detail Amount field on the invoice and is added to any discount amount or rate specified on the invoice.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("totallineitemdiscountamount")]
        public Microsoft.Xrm.Sdk.Money TotalLineItemDiscountAmount
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("totallineitemdiscountamount"); }
            set
            {
                this.OnPropertyChanging("TotalLineItemDiscountAmount");
                this.SetAttributeValue("totallineitemdiscountamount", value);
                this.OnPropertyChanged("TotalLineItemDiscountAmount");
            }
        }

        /// <summary>
        /// Shows the total of the Manual Discount amounts specified on all products included in the invoice. This value is reflected in the Detail Amount field on the invoice and is added to any discount amount or rate specified on the invoice.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("totallineitemdiscountamount_base")]
        public Microsoft.Xrm.Sdk.Money TotalLineItemDiscountAmount_Base
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("totallineitemdiscountamount_base"); }
        }

        /// <summary>
        /// Shows the total of the Tax amounts specified on all products included in the invoice, included in the Total Amount due calculation for the invoice.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("totaltax")]
        public Microsoft.Xrm.Sdk.Money TotalTax
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("totaltax"); }
            set
            {
                this.OnPropertyChanging("TotalTax");
                this.SetAttributeValue("totaltax", value);
                this.OnPropertyChanged("TotalTax");
            }
        }

        /// <summary>
        /// Shows the Total Tax field converted to the system's default base currency for reporting purposes. The calculation uses the exchange rate specified in the Currencies area.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("totaltax_base")]
        public Microsoft.Xrm.Sdk.Money TotalTax_Base
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("totaltax_base"); }
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
        /// Version number of the invoice.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
        public System.Nullable<long> VersionNumber
        {
            get { return this.GetAttributeValue<System.Nullable<long>>("versionnumber"); }
        }

        /// <summary>
        /// Select whether the products included in the invoice should be shipped to the specified address or held until the customer calls with further pick up or delivery instructions.
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
        /// 1:N invoice_activity_parties
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("invoice_activity_parties")]
        public System.Collections.Generic.IEnumerable<ActivityParty> invoice_activity_parties
        {
            get { return this.GetRelatedEntities<ActivityParty>("invoice_activity_parties", null); }
            set
            {
                this.OnPropertyChanging("invoice_activity_parties");
                this.SetRelatedEntities<ActivityParty>("invoice_activity_parties", null, value);
                this.OnPropertyChanged("invoice_activity_parties");
            }
        }

        /// <summary>
        /// 1:N Invoice_ActivityPointers
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Invoice_ActivityPointers")]
        public System.Collections.Generic.IEnumerable<ActivityPointer> Invoice_ActivityPointers
        {
            get { return this.GetRelatedEntities<ActivityPointer>("Invoice_ActivityPointers", null); }
            set
            {
                this.OnPropertyChanging("Invoice_ActivityPointers");
                this.SetRelatedEntities<ActivityPointer>("Invoice_ActivityPointers", null, value);
                this.OnPropertyChanged("Invoice_ActivityPointers");
            }
        }

        /// <summary>
        /// 1:N Invoice_Annotation
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Invoice_Annotation")]
        public System.Collections.Generic.IEnumerable<Annotation> Invoice_Annotation
        {
            get { return this.GetRelatedEntities<Annotation>("Invoice_Annotation", null); }
            set
            {
                this.OnPropertyChanging("Invoice_Annotation");
                this.SetRelatedEntities<Annotation>("Invoice_Annotation", null, value);
                this.OnPropertyChanged("Invoice_Annotation");
            }
        }

        /// <summary>
        /// 1:N Invoice_Appointments
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Invoice_Appointments")]
        public System.Collections.Generic.IEnumerable<Appointment> Invoice_Appointments
        {
            get { return this.GetRelatedEntities<Appointment>("Invoice_Appointments", null); }
            set
            {
                this.OnPropertyChanging("Invoice_Appointments");
                this.SetRelatedEntities<Appointment>("Invoice_Appointments", null, value);
                this.OnPropertyChanged("Invoice_Appointments");
            }
        }

        /// <summary>
        /// 1:N Invoice_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Invoice_AsyncOperations")]
        public System.Collections.Generic.IEnumerable<AsyncOperation> Invoice_AsyncOperations
        {
            get { return this.GetRelatedEntities<AsyncOperation>("Invoice_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("Invoice_AsyncOperations");
                this.SetRelatedEntities<AsyncOperation>("Invoice_AsyncOperations", null, value);
                this.OnPropertyChanged("Invoice_AsyncOperations");
            }
        }

        /// <summary>
        /// 1:N Invoice_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Invoice_BulkDeleteFailures")]
        public System.Collections.Generic.IEnumerable<BulkDeleteFailure> Invoice_BulkDeleteFailures
        {
            get { return this.GetRelatedEntities<BulkDeleteFailure>("Invoice_BulkDeleteFailures", null); }
            set
            {
                this.OnPropertyChanging("Invoice_BulkDeleteFailures");
                this.SetRelatedEntities<BulkDeleteFailure>("Invoice_BulkDeleteFailures", null, value);
                this.OnPropertyChanged("Invoice_BulkDeleteFailures");
            }
        }

        /// <summary>
        /// 1:N invoice_connections1
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("invoice_connections1")]
        public System.Collections.Generic.IEnumerable<Connection> invoice_connections1
        {
            get { return this.GetRelatedEntities<Connection>("invoice_connections1", null); }
            set
            {
                this.OnPropertyChanging("invoice_connections1");
                this.SetRelatedEntities<Connection>("invoice_connections1", null, value);
                this.OnPropertyChanged("invoice_connections1");
            }
        }

        /// <summary>
        /// 1:N invoice_connections2
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("invoice_connections2")]
        public System.Collections.Generic.IEnumerable<Connection> invoice_connections2
        {
            get { return this.GetRelatedEntities<Connection>("invoice_connections2", null); }
            set
            {
                this.OnPropertyChanging("invoice_connections2");
                this.SetRelatedEntities<Connection>("invoice_connections2", null, value);
                this.OnPropertyChanged("invoice_connections2");
            }
        }

        /// <summary>
        /// 1:N invoice_details
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("invoice_details")]
        public System.Collections.Generic.IEnumerable<InvoiceDetail> invoice_details
        {
            get { return this.GetRelatedEntities<InvoiceDetail>("invoice_details", null); }
            set
            {
                this.OnPropertyChanging("invoice_details");
                this.SetRelatedEntities<InvoiceDetail>("invoice_details", null, value);
                this.OnPropertyChanged("invoice_details");
            }
        }

        /// <summary>
        /// 1:N Invoice_Emails
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Invoice_Emails")]
        public System.Collections.Generic.IEnumerable<Email> Invoice_Emails
        {
            get { return this.GetRelatedEntities<Email>("Invoice_Emails", null); }
            set
            {
                this.OnPropertyChanging("Invoice_Emails");
                this.SetRelatedEntities<Email>("Invoice_Emails", null, value);
                this.OnPropertyChanged("Invoice_Emails");
            }
        }

        /// <summary>
        /// 1:N Invoice_Faxes
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Invoice_Faxes")]
        public System.Collections.Generic.IEnumerable<Fax> Invoice_Faxes
        {
            get { return this.GetRelatedEntities<Fax>("Invoice_Faxes", null); }
            set
            {
                this.OnPropertyChanging("Invoice_Faxes");
                this.SetRelatedEntities<Fax>("Invoice_Faxes", null, value);
                this.OnPropertyChanged("Invoice_Faxes");
            }
        }

        /// <summary>
        /// 1:N Invoice_Letters
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Invoice_Letters")]
        public System.Collections.Generic.IEnumerable<Letter> Invoice_Letters
        {
            get { return this.GetRelatedEntities<Letter>("Invoice_Letters", null); }
            set
            {
                this.OnPropertyChanging("Invoice_Letters");
                this.SetRelatedEntities<Letter>("Invoice_Letters", null, value);
                this.OnPropertyChanged("Invoice_Letters");
            }
        }

        /// <summary>
        /// 1:N Invoice_Phonecalls
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Invoice_Phonecalls")]
        public System.Collections.Generic.IEnumerable<PhoneCall> Invoice_Phonecalls
        {
            get { return this.GetRelatedEntities<PhoneCall>("Invoice_Phonecalls", null); }
            set
            {
                this.OnPropertyChanging("Invoice_Phonecalls");
                this.SetRelatedEntities<PhoneCall>("Invoice_Phonecalls", null, value);
                this.OnPropertyChanged("Invoice_Phonecalls");
            }
        }

        /// <summary>
        /// 1:N invoice_principalobjectattributeaccess
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("invoice_principalobjectattributeaccess")]
        public System.Collections.Generic.IEnumerable<PrincipalObjectAttributeAccess> invoice_principalobjectattributeaccess
        {
            get { return this.GetRelatedEntities<PrincipalObjectAttributeAccess>("invoice_principalobjectattributeaccess", null); }
            set
            {
                this.OnPropertyChanging("invoice_principalobjectattributeaccess");
                this.SetRelatedEntities<PrincipalObjectAttributeAccess>("invoice_principalobjectattributeaccess", null, value);
                this.OnPropertyChanged("invoice_principalobjectattributeaccess");
            }
        }

        /// <summary>
        /// 1:N Invoice_ProcessSessions
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Invoice_ProcessSessions")]
        public System.Collections.Generic.IEnumerable<ProcessSession> Invoice_ProcessSessions
        {
            get { return this.GetRelatedEntities<ProcessSession>("Invoice_ProcessSessions", null); }
            set
            {
                this.OnPropertyChanging("Invoice_ProcessSessions");
                this.SetRelatedEntities<ProcessSession>("Invoice_ProcessSessions", null, value);
                this.OnPropertyChanged("Invoice_ProcessSessions");
            }
        }

        /// <summary>
        /// 1:N Invoice_RecurringAppointmentMasters
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Invoice_RecurringAppointmentMasters")]
        public System.Collections.Generic.IEnumerable<RecurringAppointmentMaster> Invoice_RecurringAppointmentMasters
        {
            get { return this.GetRelatedEntities<RecurringAppointmentMaster>("Invoice_RecurringAppointmentMasters", null); }
            set
            {
                this.OnPropertyChanging("Invoice_RecurringAppointmentMasters");
                this.SetRelatedEntities<RecurringAppointmentMaster>("Invoice_RecurringAppointmentMasters", null, value);
                this.OnPropertyChanged("Invoice_RecurringAppointmentMasters");
            }
        }

        /// <summary>
        /// 1:N Invoice_ServiceAppointments
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Invoice_ServiceAppointments")]
        public System.Collections.Generic.IEnumerable<ServiceAppointment> Invoice_ServiceAppointments
        {
            get { return this.GetRelatedEntities<ServiceAppointment>("Invoice_ServiceAppointments", null); }
            set
            {
                this.OnPropertyChanging("Invoice_ServiceAppointments");
                this.SetRelatedEntities<ServiceAppointment>("Invoice_ServiceAppointments", null, value);
                this.OnPropertyChanged("Invoice_ServiceAppointments");
            }
        }

        /// <summary>
        /// 1:N Invoice_SocialActivities
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Invoice_SocialActivities")]
        public System.Collections.Generic.IEnumerable<SocialActivity> Invoice_SocialActivities
        {
            get { return this.GetRelatedEntities<SocialActivity>("Invoice_SocialActivities", null); }
            set
            {
                this.OnPropertyChanging("Invoice_SocialActivities");
                this.SetRelatedEntities<SocialActivity>("Invoice_SocialActivities", null, value);
                this.OnPropertyChanged("Invoice_SocialActivities");
            }
        }

        /// <summary>
        /// 1:N Invoice_Tasks
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Invoice_Tasks")]
        public System.Collections.Generic.IEnumerable<Task> Invoice_Tasks
        {
            get { return this.GetRelatedEntities<Task>("Invoice_Tasks", null); }
            set
            {
                this.OnPropertyChanging("Invoice_Tasks");
                this.SetRelatedEntities<Task>("Invoice_Tasks", null, value);
                this.OnPropertyChanged("Invoice_Tasks");
            }
        }

        /// <summary>
        /// 1:N userentityinstancedata_invoice
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_invoice")]
        public System.Collections.Generic.IEnumerable<UserEntityInstanceData> userentityinstancedata_invoice
        {
            get { return this.GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_invoice", null); }
            set
            {
                this.OnPropertyChanging("userentityinstancedata_invoice");
                this.SetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_invoice", null, value);
                this.OnPropertyChanged("userentityinstancedata_invoice");
            }
        }

        /// <summary>
        /// N:N contactinvoices_association
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("contactinvoices_association")]
        public System.Collections.Generic.IEnumerable<Contact> contactinvoices_association
        {
            get { return this.GetRelatedEntities<Contact>("contactinvoices_association", null); }
            set
            {
                this.OnPropertyChanging("contactinvoices_association");
                this.SetRelatedEntities<Contact>("contactinvoices_association", null, value);
                this.OnPropertyChanged("contactinvoices_association");
            }
        }

        /// <summary>
        /// N:1 business_unit_invoices
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_invoices")]
        public BusinessUnit business_unit_invoices
        {
            get { return this.GetRelatedEntity<BusinessUnit>("business_unit_invoices", null); }
        }

        /// <summary>
        /// N:1 invoice_customer_accounts
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("customerid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("invoice_customer_accounts")]
        public Account invoice_customer_accounts
        {
            get { return this.GetRelatedEntity<Account>("invoice_customer_accounts", null); }
            set
            {
                this.OnPropertyChanging("invoice_customer_accounts");
                this.SetRelatedEntity<Account>("invoice_customer_accounts", null, value);
                this.OnPropertyChanged("invoice_customer_accounts");
            }
        }

        /// <summary>
        /// N:1 invoice_customer_contacts
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("customerid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("invoice_customer_contacts")]
        public Contact invoice_customer_contacts
        {
            get { return this.GetRelatedEntity<Contact>("invoice_customer_contacts", null); }
            set
            {
                this.OnPropertyChanging("invoice_customer_contacts");
                this.SetRelatedEntity<Contact>("invoice_customer_contacts", null, value);
                this.OnPropertyChanged("invoice_customer_contacts");
            }
        }

        /// <summary>
        /// N:1 lk_invoice_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_invoice_createdonbehalfby")]
        public SystemUser lk_invoice_createdonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_invoice_createdonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_invoice_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_invoice_modifiedonbehalfby")]
        public SystemUser lk_invoice_modifiedonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_invoice_modifiedonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_invoicebase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_invoicebase_createdby")]
        public SystemUser lk_invoicebase_createdby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_invoicebase_createdby", null); }
        }

        /// <summary>
        /// N:1 lk_invoicebase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_invoicebase_modifiedby")]
        public SystemUser lk_invoicebase_modifiedby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_invoicebase_modifiedby", null); }
        }

        /// <summary>
        /// N:1 opportunity_invoices
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("opportunityid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("opportunity_invoices")]
        public Opportunity opportunity_invoices
        {
            get { return this.GetRelatedEntity<Opportunity>("opportunity_invoices", null); }
            set
            {
                this.OnPropertyChanging("opportunity_invoices");
                this.SetRelatedEntity<Opportunity>("opportunity_invoices", null, value);
                this.OnPropertyChanged("opportunity_invoices");
            }
        }

        /// <summary>
        /// N:1 order_invoices
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("salesorderid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("order_invoices")]
        public SalesOrder order_invoices
        {
            get { return this.GetRelatedEntity<SalesOrder>("order_invoices", null); }
            set
            {
                this.OnPropertyChanging("order_invoices");
                this.SetRelatedEntity<SalesOrder>("order_invoices", null, value);
                this.OnPropertyChanged("order_invoices");
            }
        }

        /// <summary>
        /// N:1 price_level_invoices
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("pricelevelid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("price_level_invoices")]
        public PriceLevel price_level_invoices
        {
            get { return this.GetRelatedEntity<PriceLevel>("price_level_invoices", null); }
            set
            {
                this.OnPropertyChanging("price_level_invoices");
                this.SetRelatedEntity<PriceLevel>("price_level_invoices", null, value);
                this.OnPropertyChanged("price_level_invoices");
            }
        }

        /// <summary>
        /// N:1 processstage_invoices
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("stageid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("processstage_invoices")]
        public ProcessStage processstage_invoices
        {
            get { return this.GetRelatedEntity<ProcessStage>("processstage_invoices", null); }
            set
            {
                this.OnPropertyChanging("processstage_invoices");
                this.SetRelatedEntity<ProcessStage>("processstage_invoices", null, value);
                this.OnPropertyChanged("processstage_invoices");
            }
        }

        /// <summary>
        /// N:1 system_user_invoices
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("system_user_invoices")]
        public SystemUser system_user_invoices
        {
            get { return this.GetRelatedEntity<SystemUser>("system_user_invoices", null); }
        }

        /// <summary>
        /// N:1 team_invoices
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_invoices")]
        public Team team_invoices
        {
            get { return this.GetRelatedEntity<Team>("team_invoices", null); }
        }

        /// <summary>
        /// N:1 transactioncurrency_invoice
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("transactioncurrency_invoice")]
        public TransactionCurrency transactioncurrency_invoice
        {
            get { return this.GetRelatedEntity<TransactionCurrency>("transactioncurrency_invoice", null); }
            set
            {
                this.OnPropertyChanging("transactioncurrency_invoice");
                this.SetRelatedEntity<TransactionCurrency>("transactioncurrency_invoice", null, value);
                this.OnPropertyChanged("transactioncurrency_invoice");
            }
        }
    }
}