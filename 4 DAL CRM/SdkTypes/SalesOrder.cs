using _4_DAL_CRM;

namespace __4_DAL_CRM
{
    /// <summary>
    /// Quote that has been accepted.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("salesorder")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class SalesOrder : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public SalesOrder() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "salesorder";

        public const int EntityTypeCode = 1088;

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
        /// Shows the parent account related to the record. This information is used to link the sales order to the account selected in the Customer field for reporting and analytics.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("accountid")]
        public Microsoft.Xrm.Sdk.EntityReference AccountId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("accountid"); }
        }

        /// <summary>
        /// Unique identifier of the billing address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("billto_addressid")]
        public System.Nullable<System.Guid> BillTo_AddressId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("billto_addressid"); }
            set
            {
                this.OnPropertyChanging("BillTo_AddressId");
                this.SetAttributeValue("billto_addressid", value);
                this.OnPropertyChanged("BillTo_AddressId");
            }
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
        /// Type the primary contact name at the customer's billing address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("billto_contactname")]
        public string BillTo_ContactName
        {
            get { return this.GetAttributeValue<string>("billto_contactname"); }
            set
            {
                this.OnPropertyChanging("BillTo_ContactName");
                this.SetAttributeValue("billto_contactname", value);
                this.OnPropertyChanged("BillTo_ContactName");
            }
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
        /// Shows the campaign that the order was created from.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("campaignid")]
        public Microsoft.Xrm.Sdk.EntityReference CampaignId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("campaignid"); }
            set
            {
                this.OnPropertyChanging("CampaignId");
                this.SetAttributeValue("campaignid", value);
                this.OnPropertyChanged("CampaignId");
            }
        }

        /// <summary>
        /// Shows the parent contact related to the record. This information is used to link the contract to the contact selected in the Customer field for reporting and analytics.
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
        /// Enter the date that all or part of the order was shipped to the customer.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("datefulfilled")]
        public System.Nullable<System.DateTime> DateFulfilled
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("datefulfilled"); }
            set
            {
                this.OnPropertyChanging("DateFulfilled");
                this.SetAttributeValue("datefulfilled", value);
                this.OnPropertyChanged("DateFulfilled");
            }
        }

        /// <summary>
        /// Type additional information to describe the order, such as the products or services offered or details about the customer's product preferences.
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
        /// Type the discount amount for the order if the customer is eligible for special savings.
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
        /// Shows the Order Discount field converted to the system's default base currency for reporting purposes. The calculation uses the exchange rate specified in the Currencies area.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("discountamount_base")]
        public Microsoft.Xrm.Sdk.Money DiscountAmount_Base
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("discountamount_base"); }
        }

        /// <summary>
        /// Type the discount rate that should be applied to the Detail Amount field to include additional savings for the customer in the order.
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
        /// Type the cost of freight or shipping for the products included in the order for use in calculating the Total Amount field.
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
        /// Select the freight terms to make sure shipping charges are processed correctly.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("freighttermscode")]
        public Microsoft.Xrm.Sdk.OptionSetValue FreightTermsCode
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("freighttermscode"); }
            set
            {
                this.OnPropertyChanging("FreightTermsCode");
                this.SetAttributeValue("freighttermscode", value);
                this.OnPropertyChanged("FreightTermsCode");
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
        /// Enter the date and time when the order was last submitted to an accounting or ERP system for processing.
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
        /// Type a descriptive name for the order.
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
        /// Choose the related opportunity so that the data for the order and opportunity are linked for reporting and analytics.
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
        /// Shows the order number for customer reference and to use in search. The number cannot be modified.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ordernumber")]
        public string OrderNumber
        {
            get { return this.GetAttributeValue<string>("ordernumber"); }
            set
            {
                this.OnPropertyChanging("OrderNumber");
                this.SetAttributeValue("ordernumber", value);
                this.OnPropertyChanged("OrderNumber");
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
        /// Shows the business unit that the record owner belongs to.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
        public Microsoft.Xrm.Sdk.EntityReference OwningBusinessUnit
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningbusinessunit"); }
        }

        /// <summary>
        /// Unique identifier of the team who owns the order.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
        public Microsoft.Xrm.Sdk.EntityReference OwningTeam
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningteam"); }
        }

        /// <summary>
        /// Unique identifier of the user who owns the order.
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
        /// Choose the related quote so that order data and quote data are linked for reporting and analytics.
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
        /// Enter the delivery date requested by the customer for all products in the order.
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
        /// Unique identifier of the order.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("salesorderid")]
        public System.Nullable<System.Guid> SalesOrderId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("salesorderid"); }
            set
            {
                this.OnPropertyChanging("SalesOrderId");
                this.SetAttributeValue("salesorderid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("SalesOrderId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("salesorderid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.SalesOrderId = value; }
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
        /// Shows the complete Ship To address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("shipto_composite")]
        public string ShipTo_Composite
        {
            get { return this.GetAttributeValue<string>("shipto_composite"); }
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
        /// Shows whether the order is active, submitted, fulfilled, canceled, or invoiced. Only active orders can be edited.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
        public System.Nullable<SalesOrderState> StateCode
        {
            get
            {
                Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
                if ((optionSet != null))
                {
                    return ((SalesOrderState) (System.Enum.ToObject(typeof(SalesOrderState), optionSet.Value)));
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// Select the order's status.
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
        /// Enter the date when the order was submitted to the fulfillment or shipping center.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("submitdate")]
        public System.Nullable<System.DateTime> SubmitDate
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("submitdate"); }
            set
            {
                this.OnPropertyChanging("SubmitDate");
                this.SetAttributeValue("submitdate", value);
                this.OnPropertyChanged("SubmitDate");
            }
        }

        /// <summary>
        /// Type the code for the submitted status in the fulfillment or shipping center system.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("submitstatus")]
        public System.Nullable<int> SubmitStatus
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("submitstatus"); }
            set
            {
                this.OnPropertyChanging("SubmitStatus");
                this.SetAttributeValue("submitstatus", value);
                this.OnPropertyChanged("SubmitStatus");
            }
        }

        /// <summary>
        /// Type additional details or notes about the order for the fulfillment or shipping center.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("submitstatusdescription")]
        public string SubmitStatusDescription
        {
            get { return this.GetAttributeValue<string>("submitstatusdescription"); }
            set
            {
                this.OnPropertyChanging("SubmitStatusDescription");
                this.SetAttributeValue("submitstatusdescription", value);
                this.OnPropertyChanged("SubmitStatusDescription");
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
        /// Shows the total amount due, calculated as the sum of the products, discounts, freight, and taxes for the order.
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
        /// Shows the total product amount for the order, minus any discounts. This value is added to freight and tax amounts in the calculation for the total amount due for the order.
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
        /// Shows the total discount amount, based on the discount price and rate entered on the order.
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
        /// Shows the sum of all existing and write-in products included on the order, based on the specified price list and quantities.
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
        /// Shows the total of the Manual Discount amounts specified on all products included in the order. This value is reflected in the Detail Amount field on the order and is added to any discount amount or rate specified on the order.
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
        /// Shows the Total Line Item Discount Amount field converted to the system's default base currency for reporting purposes. The calculation uses the exchange rate specified in the Currencies area.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("totallineitemdiscountamount_base")]
        public Microsoft.Xrm.Sdk.Money TotalLineItemDiscountAmount_Base
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("totallineitemdiscountamount_base"); }
        }

        /// <summary>
        /// Shows the Tax amounts specified on all products included in the order, included in the Total Amount due calculation for the order.
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
        /// Version number of the order.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
        public System.Nullable<long> VersionNumber
        {
            get { return this.GetAttributeValue<System.Nullable<long>>("versionnumber"); }
        }

        /// <summary>
        /// Select whether the products included in the order should be shipped to the specified address or held until the customer calls with further pick-up or delivery instructions.
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
        /// 1:N order_details
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("order_details")]
        public System.Collections.Generic.IEnumerable<SalesOrderDetail> order_details
        {
            get { return this.GetRelatedEntities<SalesOrderDetail>("order_details", null); }
            set
            {
                this.OnPropertyChanging("order_details");
                this.SetRelatedEntities<SalesOrderDetail>("order_details", null, value);
                this.OnPropertyChanged("order_details");
            }
        }

        /// <summary>
        /// 1:N order_invoices
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("order_invoices")]
        public System.Collections.Generic.IEnumerable<Invoice> order_invoices
        {
            get { return this.GetRelatedEntities<Invoice>("order_invoices", null); }
            set
            {
                this.OnPropertyChanging("order_invoices");
                this.SetRelatedEntities<Invoice>("order_invoices", null, value);
                this.OnPropertyChanged("order_invoices");
            }
        }

        /// <summary>
        /// 1:N salesorder_activity_parties
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("salesorder_activity_parties")]
        public System.Collections.Generic.IEnumerable<ActivityParty> salesorder_activity_parties
        {
            get { return this.GetRelatedEntities<ActivityParty>("salesorder_activity_parties", null); }
            set
            {
                this.OnPropertyChanging("salesorder_activity_parties");
                this.SetRelatedEntities<ActivityParty>("salesorder_activity_parties", null, value);
                this.OnPropertyChanged("salesorder_activity_parties");
            }
        }

        /// <summary>
        /// 1:N SalesOrder_ActivityPointers
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SalesOrder_ActivityPointers")]
        public System.Collections.Generic.IEnumerable<ActivityPointer> SalesOrder_ActivityPointers
        {
            get { return this.GetRelatedEntities<ActivityPointer>("SalesOrder_ActivityPointers", null); }
            set
            {
                this.OnPropertyChanging("SalesOrder_ActivityPointers");
                this.SetRelatedEntities<ActivityPointer>("SalesOrder_ActivityPointers", null, value);
                this.OnPropertyChanged("SalesOrder_ActivityPointers");
            }
        }

        /// <summary>
        /// 1:N SalesOrder_Annotation
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SalesOrder_Annotation")]
        public System.Collections.Generic.IEnumerable<Annotation> SalesOrder_Annotation
        {
            get { return this.GetRelatedEntities<Annotation>("SalesOrder_Annotation", null); }
            set
            {
                this.OnPropertyChanging("SalesOrder_Annotation");
                this.SetRelatedEntities<Annotation>("SalesOrder_Annotation", null, value);
                this.OnPropertyChanged("SalesOrder_Annotation");
            }
        }

        /// <summary>
        /// 1:N SalesOrder_Appointments
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SalesOrder_Appointments")]
        public System.Collections.Generic.IEnumerable<Appointment> SalesOrder_Appointments
        {
            get { return this.GetRelatedEntities<Appointment>("SalesOrder_Appointments", null); }
            set
            {
                this.OnPropertyChanging("SalesOrder_Appointments");
                this.SetRelatedEntities<Appointment>("SalesOrder_Appointments", null, value);
                this.OnPropertyChanged("SalesOrder_Appointments");
            }
        }

        /// <summary>
        /// 1:N SalesOrder_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SalesOrder_AsyncOperations")]
        public System.Collections.Generic.IEnumerable<AsyncOperation> SalesOrder_AsyncOperations
        {
            get { return this.GetRelatedEntities<AsyncOperation>("SalesOrder_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("SalesOrder_AsyncOperations");
                this.SetRelatedEntities<AsyncOperation>("SalesOrder_AsyncOperations", null, value);
                this.OnPropertyChanged("SalesOrder_AsyncOperations");
            }
        }

        /// <summary>
        /// 1:N SalesOrder_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SalesOrder_BulkDeleteFailures")]
        public System.Collections.Generic.IEnumerable<BulkDeleteFailure> SalesOrder_BulkDeleteFailures
        {
            get { return this.GetRelatedEntities<BulkDeleteFailure>("SalesOrder_BulkDeleteFailures", null); }
            set
            {
                this.OnPropertyChanging("SalesOrder_BulkDeleteFailures");
                this.SetRelatedEntities<BulkDeleteFailure>("SalesOrder_BulkDeleteFailures", null, value);
                this.OnPropertyChanged("SalesOrder_BulkDeleteFailures");
            }
        }

        /// <summary>
        /// 1:N salesorder_connections1
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("salesorder_connections1")]
        public System.Collections.Generic.IEnumerable<Connection> salesorder_connections1
        {
            get { return this.GetRelatedEntities<Connection>("salesorder_connections1", null); }
            set
            {
                this.OnPropertyChanging("salesorder_connections1");
                this.SetRelatedEntities<Connection>("salesorder_connections1", null, value);
                this.OnPropertyChanged("salesorder_connections1");
            }
        }

        /// <summary>
        /// 1:N salesorder_connections2
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("salesorder_connections2")]
        public System.Collections.Generic.IEnumerable<Connection> salesorder_connections2
        {
            get { return this.GetRelatedEntities<Connection>("salesorder_connections2", null); }
            set
            {
                this.OnPropertyChanging("salesorder_connections2");
                this.SetRelatedEntities<Connection>("salesorder_connections2", null, value);
                this.OnPropertyChanged("salesorder_connections2");
            }
        }

        /// <summary>
        /// 1:N SalesOrder_Emails
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SalesOrder_Emails")]
        public System.Collections.Generic.IEnumerable<Email> SalesOrder_Emails
        {
            get { return this.GetRelatedEntities<Email>("SalesOrder_Emails", null); }
            set
            {
                this.OnPropertyChanging("SalesOrder_Emails");
                this.SetRelatedEntities<Email>("SalesOrder_Emails", null, value);
                this.OnPropertyChanged("SalesOrder_Emails");
            }
        }

        /// <summary>
        /// 1:N SalesOrder_Faxes
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SalesOrder_Faxes")]
        public System.Collections.Generic.IEnumerable<Fax> SalesOrder_Faxes
        {
            get { return this.GetRelatedEntities<Fax>("SalesOrder_Faxes", null); }
            set
            {
                this.OnPropertyChanging("SalesOrder_Faxes");
                this.SetRelatedEntities<Fax>("SalesOrder_Faxes", null, value);
                this.OnPropertyChanged("SalesOrder_Faxes");
            }
        }

        /// <summary>
        /// 1:N SalesOrder_Letters
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SalesOrder_Letters")]
        public System.Collections.Generic.IEnumerable<Letter> SalesOrder_Letters
        {
            get { return this.GetRelatedEntities<Letter>("SalesOrder_Letters", null); }
            set
            {
                this.OnPropertyChanging("SalesOrder_Letters");
                this.SetRelatedEntities<Letter>("SalesOrder_Letters", null, value);
                this.OnPropertyChanged("SalesOrder_Letters");
            }
        }

        /// <summary>
        /// 1:N SalesOrder_OrderClose
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SalesOrder_OrderClose")]
        public System.Collections.Generic.IEnumerable<OrderClose> SalesOrder_OrderClose
        {
            get { return this.GetRelatedEntities<OrderClose>("SalesOrder_OrderClose", null); }
            set
            {
                this.OnPropertyChanging("SalesOrder_OrderClose");
                this.SetRelatedEntities<OrderClose>("SalesOrder_OrderClose", null, value);
                this.OnPropertyChanged("SalesOrder_OrderClose");
            }
        }

        /// <summary>
        /// 1:N SalesOrder_Phonecalls
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SalesOrder_Phonecalls")]
        public System.Collections.Generic.IEnumerable<PhoneCall> SalesOrder_Phonecalls
        {
            get { return this.GetRelatedEntities<PhoneCall>("SalesOrder_Phonecalls", null); }
            set
            {
                this.OnPropertyChanging("SalesOrder_Phonecalls");
                this.SetRelatedEntities<PhoneCall>("SalesOrder_Phonecalls", null, value);
                this.OnPropertyChanged("SalesOrder_Phonecalls");
            }
        }

        /// <summary>
        /// 1:N salesorder_principalobjectattributeaccess
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("salesorder_principalobjectattributeaccess")]
        public System.Collections.Generic.IEnumerable<PrincipalObjectAttributeAccess> salesorder_principalobjectattributeaccess
        {
            get { return this.GetRelatedEntities<PrincipalObjectAttributeAccess>("salesorder_principalobjectattributeaccess", null); }
            set
            {
                this.OnPropertyChanging("salesorder_principalobjectattributeaccess");
                this.SetRelatedEntities<PrincipalObjectAttributeAccess>("salesorder_principalobjectattributeaccess", null, value);
                this.OnPropertyChanged("salesorder_principalobjectattributeaccess");
            }
        }

        /// <summary>
        /// 1:N SalesOrder_ProcessSessions
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SalesOrder_ProcessSessions")]
        public System.Collections.Generic.IEnumerable<ProcessSession> SalesOrder_ProcessSessions
        {
            get { return this.GetRelatedEntities<ProcessSession>("SalesOrder_ProcessSessions", null); }
            set
            {
                this.OnPropertyChanging("SalesOrder_ProcessSessions");
                this.SetRelatedEntities<ProcessSession>("SalesOrder_ProcessSessions", null, value);
                this.OnPropertyChanged("SalesOrder_ProcessSessions");
            }
        }

        /// <summary>
        /// 1:N SalesOrder_RecurringAppointmentMasters
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SalesOrder_RecurringAppointmentMasters")]
        public System.Collections.Generic.IEnumerable<RecurringAppointmentMaster> SalesOrder_RecurringAppointmentMasters
        {
            get { return this.GetRelatedEntities<RecurringAppointmentMaster>("SalesOrder_RecurringAppointmentMasters", null); }
            set
            {
                this.OnPropertyChanging("SalesOrder_RecurringAppointmentMasters");
                this.SetRelatedEntities<RecurringAppointmentMaster>("SalesOrder_RecurringAppointmentMasters", null, value);
                this.OnPropertyChanged("SalesOrder_RecurringAppointmentMasters");
            }
        }

        /// <summary>
        /// 1:N SalesOrder_ServiceAppointments
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SalesOrder_ServiceAppointments")]
        public System.Collections.Generic.IEnumerable<ServiceAppointment> SalesOrder_ServiceAppointments
        {
            get { return this.GetRelatedEntities<ServiceAppointment>("SalesOrder_ServiceAppointments", null); }
            set
            {
                this.OnPropertyChanging("SalesOrder_ServiceAppointments");
                this.SetRelatedEntities<ServiceAppointment>("SalesOrder_ServiceAppointments", null, value);
                this.OnPropertyChanged("SalesOrder_ServiceAppointments");
            }
        }

        /// <summary>
        /// 1:N SalesOrder_SocialActivities
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SalesOrder_SocialActivities")]
        public System.Collections.Generic.IEnumerable<SocialActivity> SalesOrder_SocialActivities
        {
            get { return this.GetRelatedEntities<SocialActivity>("SalesOrder_SocialActivities", null); }
            set
            {
                this.OnPropertyChanging("SalesOrder_SocialActivities");
                this.SetRelatedEntities<SocialActivity>("SalesOrder_SocialActivities", null, value);
                this.OnPropertyChanged("SalesOrder_SocialActivities");
            }
        }

        /// <summary>
        /// 1:N SalesOrder_Tasks
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SalesOrder_Tasks")]
        public System.Collections.Generic.IEnumerable<Task> SalesOrder_Tasks
        {
            get { return this.GetRelatedEntities<Task>("SalesOrder_Tasks", null); }
            set
            {
                this.OnPropertyChanging("SalesOrder_Tasks");
                this.SetRelatedEntities<Task>("SalesOrder_Tasks", null, value);
                this.OnPropertyChanged("SalesOrder_Tasks");
            }
        }

        /// <summary>
        /// 1:N userentityinstancedata_salesorder
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_salesorder")]
        public System.Collections.Generic.IEnumerable<UserEntityInstanceData> userentityinstancedata_salesorder
        {
            get { return this.GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_salesorder", null); }
            set
            {
                this.OnPropertyChanging("userentityinstancedata_salesorder");
                this.SetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_salesorder", null, value);
                this.OnPropertyChanged("userentityinstancedata_salesorder");
            }
        }

        /// <summary>
        /// N:N contactorders_association
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("contactorders_association")]
        public System.Collections.Generic.IEnumerable<Contact> contactorders_association
        {
            get { return this.GetRelatedEntities<Contact>("contactorders_association", null); }
            set
            {
                this.OnPropertyChanging("contactorders_association");
                this.SetRelatedEntities<Contact>("contactorders_association", null, value);
                this.OnPropertyChanged("contactorders_association");
            }
        }

        /// <summary>
        /// N:1 business_unit_orders
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_orders")]
        public BusinessUnit business_unit_orders
        {
            get { return this.GetRelatedEntity<BusinessUnit>("business_unit_orders", null); }
        }

        /// <summary>
        /// N:1 campaign_orders
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("campaignid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("campaign_orders")]
        public Campaign campaign_orders
        {
            get { return this.GetRelatedEntity<Campaign>("campaign_orders", null); }
            set
            {
                this.OnPropertyChanging("campaign_orders");
                this.SetRelatedEntity<Campaign>("campaign_orders", null, value);
                this.OnPropertyChanged("campaign_orders");
            }
        }

        /// <summary>
        /// N:1 lk_salesorder_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_salesorder_createdonbehalfby")]
        public SystemUser lk_salesorder_createdonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_salesorder_createdonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_salesorder_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_salesorder_modifiedonbehalfby")]
        public SystemUser lk_salesorder_modifiedonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_salesorder_modifiedonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_salesorderbase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_salesorderbase_createdby")]
        public SystemUser lk_salesorderbase_createdby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_salesorderbase_createdby", null); }
        }

        /// <summary>
        /// N:1 lk_salesorderbase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_salesorderbase_modifiedby")]
        public SystemUser lk_salesorderbase_modifiedby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_salesorderbase_modifiedby", null); }
        }

        /// <summary>
        /// N:1 opportunity_sales_orders
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("opportunityid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("opportunity_sales_orders")]
        public Opportunity opportunity_sales_orders
        {
            get { return this.GetRelatedEntity<Opportunity>("opportunity_sales_orders", null); }
            set
            {
                this.OnPropertyChanging("opportunity_sales_orders");
                this.SetRelatedEntity<Opportunity>("opportunity_sales_orders", null, value);
                this.OnPropertyChanged("opportunity_sales_orders");
            }
        }

        /// <summary>
        /// N:1 order_customer_accounts
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("customerid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("order_customer_accounts")]
        public Account order_customer_accounts
        {
            get { return this.GetRelatedEntity<Account>("order_customer_accounts", null); }
            set
            {
                this.OnPropertyChanging("order_customer_accounts");
                this.SetRelatedEntity<Account>("order_customer_accounts", null, value);
                this.OnPropertyChanged("order_customer_accounts");
            }
        }

        /// <summary>
        /// N:1 order_customer_contacts
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("customerid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("order_customer_contacts")]
        public Contact order_customer_contacts
        {
            get { return this.GetRelatedEntity<Contact>("order_customer_contacts", null); }
            set
            {
                this.OnPropertyChanging("order_customer_contacts");
                this.SetRelatedEntity<Contact>("order_customer_contacts", null, value);
                this.OnPropertyChanged("order_customer_contacts");
            }
        }

        /// <summary>
        /// N:1 price_level_orders
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("pricelevelid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("price_level_orders")]
        public PriceLevel price_level_orders
        {
            get { return this.GetRelatedEntity<PriceLevel>("price_level_orders", null); }
            set
            {
                this.OnPropertyChanging("price_level_orders");
                this.SetRelatedEntity<PriceLevel>("price_level_orders", null, value);
                this.OnPropertyChanged("price_level_orders");
            }
        }

        /// <summary>
        /// N:1 processstage_salesorders
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("stageid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("processstage_salesorders")]
        public ProcessStage processstage_salesorders
        {
            get { return this.GetRelatedEntity<ProcessStage>("processstage_salesorders", null); }
            set
            {
                this.OnPropertyChanging("processstage_salesorders");
                this.SetRelatedEntity<ProcessStage>("processstage_salesorders", null, value);
                this.OnPropertyChanged("processstage_salesorders");
            }
        }

        /// <summary>
        /// N:1 quote_orders
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("quoteid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("quote_orders")]
        public Quote quote_orders
        {
            get { return this.GetRelatedEntity<Quote>("quote_orders", null); }
            set
            {
                this.OnPropertyChanging("quote_orders");
                this.SetRelatedEntity<Quote>("quote_orders", null, value);
                this.OnPropertyChanged("quote_orders");
            }
        }

        /// <summary>
        /// N:1 system_user_orders
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("system_user_orders")]
        public SystemUser system_user_orders
        {
            get { return this.GetRelatedEntity<SystemUser>("system_user_orders", null); }
        }

        /// <summary>
        /// N:1 team_orders
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_orders")]
        public Team team_orders
        {
            get { return this.GetRelatedEntity<Team>("team_orders", null); }
        }

        /// <summary>
        /// N:1 transactioncurrency_salesorder
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("transactioncurrency_salesorder")]
        public TransactionCurrency transactioncurrency_salesorder
        {
            get { return this.GetRelatedEntity<TransactionCurrency>("transactioncurrency_salesorder", null); }
            set
            {
                this.OnPropertyChanging("transactioncurrency_salesorder");
                this.SetRelatedEntity<TransactionCurrency>("transactioncurrency_salesorder", null, value);
                this.OnPropertyChanged("transactioncurrency_salesorder");
            }
        }
    }
}