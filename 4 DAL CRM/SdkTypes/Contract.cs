using _4_DAL_CRM;

namespace __4_DAL_CRM
{
    /// <summary>
    /// Agreement to provide customer service during a specified amount of time or number of cases.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("contract")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class Contract : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public Contract() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "contract";

        public const int EntityTypeCode = 1010;

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
        /// Unique identifier of the account with which the contract is associated.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("accountid")]
        public Microsoft.Xrm.Sdk.EntityReference AccountId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("accountid"); }
        }

        /// <summary>
        /// Enter the date when the contract becomes active.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("activeon")]
        public System.Nullable<System.DateTime> ActiveOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("activeon"); }
            set
            {
                this.OnPropertyChanging("ActiveOn");
                this.SetAttributeValue("activeon", value);
                this.OnPropertyChanged("ActiveOn");
            }
        }

        /// <summary>
        /// Type of allotment that the contract supports.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("allotmenttypecode")]
        public Microsoft.Xrm.Sdk.OptionSetValue AllotmentTypeCode
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("allotmenttypecode"); }
            set
            {
                this.OnPropertyChanging("AllotmentTypeCode");
                this.SetAttributeValue("allotmenttypecode", value);
                this.OnPropertyChanged("AllotmentTypeCode");
            }
        }

        /// <summary>
        /// Unique identifier of the account to which the contract is to be billed.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("billingaccountid")]
        public Microsoft.Xrm.Sdk.EntityReference BillingAccountId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("billingaccountid"); }
        }

        /// <summary>
        /// Unique identifier of the contact to whom the contract is to be billed.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("billingcontactid")]
        public Microsoft.Xrm.Sdk.EntityReference BillingContactId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("billingcontactid"); }
        }

        /// <summary>
        /// Select the customer account or contact to which the contract should be billed to provide a quick link to address and other customer details.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("billingcustomerid")]
        public Microsoft.Xrm.Sdk.EntityReference BillingCustomerId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("billingcustomerid"); }
            set
            {
                this.OnPropertyChanging("BillingCustomerId");
                this.SetAttributeValue("billingcustomerid", value);
                this.OnPropertyChanged("BillingCustomerId");
            }
        }

        /// <summary>
        /// Enter the end date for the contract's billing period to indicate the period for which the customer must pay for a service.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("billingendon")]
        public System.Nullable<System.DateTime> BillingEndOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("billingendon"); }
            set
            {
                this.OnPropertyChanging("BillingEndOn");
                this.SetAttributeValue("billingendon", value);
                this.OnPropertyChanged("BillingEndOn");
            }
        }

        /// <summary>
        /// Select the billing schedule of the contract to indicate how often the customer should be invoiced.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("billingfrequencycode")]
        public Microsoft.Xrm.Sdk.OptionSetValue BillingFrequencyCode
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("billingfrequencycode"); }
            set
            {
                this.OnPropertyChanging("BillingFrequencyCode");
                this.SetAttributeValue("billingfrequencycode", value);
                this.OnPropertyChanged("BillingFrequencyCode");
            }
        }

        /// <summary>
        /// Enter the start date for the contract's billing period to indicate the period for which the customer must pay for a service. This defaults to the same date that is selected in the Contract Start Date field.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("billingstarton")]
        public System.Nullable<System.DateTime> BillingStartOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("billingstarton"); }
            set
            {
                this.OnPropertyChanging("BillingStartOn");
                this.SetAttributeValue("billingstarton", value);
                this.OnPropertyChanged("BillingStartOn");
            }
        }

        /// <summary>
        /// Choose which address to send the invoice to.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("billtoaddress")]
        public Microsoft.Xrm.Sdk.EntityReference BillToAddress
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("billtoaddress"); }
            set
            {
                this.OnPropertyChanging("BillToAddress");
                this.SetAttributeValue("billtoaddress", value);
                this.OnPropertyChanged("BillToAddress");
            }
        }

        /// <summary>
        /// Shows the date and time when the contract was canceled.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("cancelon")]
        public System.Nullable<System.DateTime> CancelOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("cancelon"); }
        }

        /// <summary>
        /// Unique identifier of the contact specified for the contract.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("contactid")]
        public Microsoft.Xrm.Sdk.EntityReference ContactId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("contactid"); }
        }

        /// <summary>
        /// Unique identifier of the contract.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("contractid")]
        public System.Nullable<System.Guid> ContractId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("contractid"); }
            set
            {
                this.OnPropertyChanging("ContractId");
                this.SetAttributeValue("contractid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("ContractId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("contractid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.ContractId = value; }
        }

        /// <summary>
        /// Type additional information about the contract, such as the products or services provided to the customer.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("contractlanguage")]
        public string ContractLanguage
        {
            get { return this.GetAttributeValue<string>("contractlanguage"); }
            set
            {
                this.OnPropertyChanging("ContractLanguage");
                this.SetAttributeValue("contractlanguage", value);
                this.OnPropertyChanged("ContractLanguage");
            }
        }

        /// <summary>
        /// Shows the number for the contract for customer reference and searching capabilities. You cannot modify this number.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("contractnumber")]
        public string ContractNumber
        {
            get { return this.GetAttributeValue<string>("contractnumber"); }
            set
            {
                this.OnPropertyChanging("ContractNumber");
                this.SetAttributeValue("contractnumber", value);
                this.OnPropertyChanged("ContractNumber");
            }
        }

        /// <summary>
        /// Select the level of service that should be provided for the contract based on your company's definition of bronze, silver, or gold.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("contractservicelevelcode")]
        public Microsoft.Xrm.Sdk.OptionSetValue ContractServiceLevelCode
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("contractservicelevelcode"); }
            set
            {
                this.OnPropertyChanging("ContractServiceLevelCode");
                this.SetAttributeValue("contractservicelevelcode", value);
                this.OnPropertyChanged("ContractServiceLevelCode");
            }
        }

        /// <summary>
        /// Shows the abbreviation of the contract template selected when the contract is created.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("contracttemplateabbreviation")]
        public string ContractTemplateAbbreviation
        {
            get { return this.GetAttributeValue<string>("contracttemplateabbreviation"); }
        }

        /// <summary>
        /// Choose the contract template that should be used to determine the terms of the contract, such as allotment type, available hours, and billing frequency.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("contracttemplateid")]
        public Microsoft.Xrm.Sdk.EntityReference ContractTemplateId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("contracttemplateid"); }
            set
            {
                this.OnPropertyChanging("ContractTemplateId");
                this.SetAttributeValue("contracttemplateid", value);
                this.OnPropertyChanged("ContractTemplateId");
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
        /// Select the customer account or contact to provide a quick link to additional customer details, such as address, phone number, activities, and orders.
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
        /// Shows for the duration of the contract, in days, based on the contract start and end dates.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("duration")]
        public System.Nullable<int> Duration
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("duration"); }
        }

        /// <summary>
        /// Days of the week and times during which customer service support is available for the duration of the contract.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("effectivitycalendar")]
        public string EffectivityCalendar
        {
            get { return this.GetAttributeValue<string>("effectivitycalendar"); }
            set
            {
                this.OnPropertyChanging("EffectivityCalendar");
                this.SetAttributeValue("effectivitycalendar", value);
                this.OnPropertyChanged("EffectivityCalendar");
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
        /// Enter the date when the contract expires.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("expireson")]
        public System.Nullable<System.DateTime> ExpiresOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("expireson"); }
            set
            {
                this.OnPropertyChanging("ExpiresOn");
                this.SetAttributeValue("expireson", value);
                this.OnPropertyChanged("ExpiresOn");
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
        /// Shows the total charge to the customer for the service contract, calculated as the sum of values in the Net field for each existing contract line related to the contract.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("netprice")]
        public Microsoft.Xrm.Sdk.Money NetPrice
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("netprice"); }
        }

        /// <summary>
        /// Shows the Net Price field converted to the system's default base currency for reporting purposes. The calculations use the exchange rate specified in the Currencies area.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("netprice_base")]
        public Microsoft.Xrm.Sdk.Money NetPrice_Base
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("netprice_base"); }
        }

        /// <summary>
        /// Choose the original contract that this contract was created from. This information is used to track renewal history.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("originatingcontract")]
        public Microsoft.Xrm.Sdk.EntityReference OriginatingContract
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("originatingcontract"); }
            set
            {
                this.OnPropertyChanging("OriginatingContract");
                this.SetAttributeValue("originatingcontract", value);
                this.OnPropertyChanged("OriginatingContract");
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
        /// Unique identifier of the business unit that owns the contract.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
        public Microsoft.Xrm.Sdk.EntityReference OwningBusinessUnit
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningbusinessunit"); }
        }

        /// <summary>
        /// Unique identifier of the team who owns the contract.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
        public Microsoft.Xrm.Sdk.EntityReference OwningTeam
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningteam"); }
        }

        /// <summary>
        /// Unique identifier of the user who owns the contract.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
        public Microsoft.Xrm.Sdk.EntityReference OwningUser
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owninguser"); }
        }

        /// <summary>
        /// Choose the address for the customer account or contact where the services are provided.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("serviceaddress")]
        public Microsoft.Xrm.Sdk.EntityReference ServiceAddress
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("serviceaddress"); }
            set
            {
                this.OnPropertyChanging("ServiceAddress");
                this.SetAttributeValue("serviceaddress", value);
                this.OnPropertyChanged("ServiceAddress");
            }
        }

        /// <summary>
        /// Shows whether the contract is in draft, invoiced, active, on hold, canceled, or expired. You can edit only the contracts that are in draft status.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
        public System.Nullable<ContractState> StateCode
        {
            get
            {
                Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
                if ((optionSet != null))
                {
                    return ((ContractState) (System.Enum.ToObject(typeof(ContractState), optionSet.Value)));
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// Select the contract's status.
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
        /// Type a title or name for the contract that indicates the purpose of the contract.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("title")]
        public string Title
        {
            get { return this.GetAttributeValue<string>("title"); }
            set
            {
                this.OnPropertyChanging("Title");
                this.SetAttributeValue("title", value);
                this.OnPropertyChanged("Title");
            }
        }

        /// <summary>
        /// Shows the total discount applied to the contract's service charges, calculated as the sum of values in the Discount fields for each existing contract line related to the contract.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("totaldiscount")]
        public Microsoft.Xrm.Sdk.Money TotalDiscount
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("totaldiscount"); }
        }

        /// <summary>
        /// Shows the Total Discount field converted to the system's default base currency for reporting purposes. The calculations use the exchange rate specified in the Currencies area.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("totaldiscount_base")]
        public Microsoft.Xrm.Sdk.Money TotalDiscount_Base
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("totaldiscount_base"); }
        }

        /// <summary>
        /// Shows the total service charge for the contract, before any discounts are credited. This is calculated as the sum of values in the Total Price field for each existing contract line related to the contract.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("totalprice")]
        public Microsoft.Xrm.Sdk.Money TotalPrice
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("totalprice"); }
        }

        /// <summary>
        /// Shows the Total Price field converted to the system's default base currency for reporting purposes. The calculations use the exchange rate specified in the Currencies area.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("totalprice_base")]
        public Microsoft.Xrm.Sdk.Money TotalPrice_Base
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("totalprice_base"); }
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
        /// Select whether the discounts entered on contract lines for this contract should be entered as a percentage or a fixed dollar value.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("usediscountaspercentage")]
        public System.Nullable<bool> UseDiscountAsPercentage
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("usediscountaspercentage"); }
            set
            {
                this.OnPropertyChanging("UseDiscountAsPercentage");
                this.SetAttributeValue("usediscountaspercentage", value);
                this.OnPropertyChanged("UseDiscountAsPercentage");
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
        /// Version number of the contract.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
        public System.Nullable<long> VersionNumber
        {
            get { return this.GetAttributeValue<System.Nullable<long>>("versionnumber"); }
        }

        /// <summary>
        /// 1:N contract_activity_parties
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("contract_activity_parties")]
        public System.Collections.Generic.IEnumerable<ActivityParty> contract_activity_parties
        {
            get { return this.GetRelatedEntities<ActivityParty>("contract_activity_parties", null); }
            set
            {
                this.OnPropertyChanging("contract_activity_parties");
                this.SetRelatedEntities<ActivityParty>("contract_activity_parties", null, value);
                this.OnPropertyChanged("contract_activity_parties");
            }
        }

        /// <summary>
        /// 1:N Contract_ActivityPointers
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Contract_ActivityPointers")]
        public System.Collections.Generic.IEnumerable<ActivityPointer> Contract_ActivityPointers
        {
            get { return this.GetRelatedEntities<ActivityPointer>("Contract_ActivityPointers", null); }
            set
            {
                this.OnPropertyChanging("Contract_ActivityPointers");
                this.SetRelatedEntities<ActivityPointer>("Contract_ActivityPointers", null, value);
                this.OnPropertyChanged("Contract_ActivityPointers");
            }
        }

        /// <summary>
        /// 1:N Contract_Annotation
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Contract_Annotation")]
        public System.Collections.Generic.IEnumerable<Annotation> Contract_Annotation
        {
            get { return this.GetRelatedEntities<Annotation>("Contract_Annotation", null); }
            set
            {
                this.OnPropertyChanging("Contract_Annotation");
                this.SetRelatedEntities<Annotation>("Contract_Annotation", null, value);
                this.OnPropertyChanged("Contract_Annotation");
            }
        }

        /// <summary>
        /// 1:N Contract_Appointments
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Contract_Appointments")]
        public System.Collections.Generic.IEnumerable<Appointment> Contract_Appointments
        {
            get { return this.GetRelatedEntities<Appointment>("Contract_Appointments", null); }
            set
            {
                this.OnPropertyChanging("Contract_Appointments");
                this.SetRelatedEntities<Appointment>("Contract_Appointments", null, value);
                this.OnPropertyChanged("Contract_Appointments");
            }
        }

        /// <summary>
        /// 1:N Contract_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Contract_AsyncOperations")]
        public System.Collections.Generic.IEnumerable<AsyncOperation> Contract_AsyncOperations
        {
            get { return this.GetRelatedEntities<AsyncOperation>("Contract_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("Contract_AsyncOperations");
                this.SetRelatedEntities<AsyncOperation>("Contract_AsyncOperations", null, value);
                this.OnPropertyChanged("Contract_AsyncOperations");
            }
        }

        /// <summary>
        /// 1:N Contract_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Contract_BulkDeleteFailures")]
        public System.Collections.Generic.IEnumerable<BulkDeleteFailure> Contract_BulkDeleteFailures
        {
            get { return this.GetRelatedEntities<BulkDeleteFailure>("Contract_BulkDeleteFailures", null); }
            set
            {
                this.OnPropertyChanging("Contract_BulkDeleteFailures");
                this.SetRelatedEntities<BulkDeleteFailure>("Contract_BulkDeleteFailures", null, value);
                this.OnPropertyChanged("Contract_BulkDeleteFailures");
            }
        }

        /// <summary>
        /// 1:N contract_cases
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("contract_cases")]
        public System.Collections.Generic.IEnumerable<Incident> contract_cases
        {
            get { return this.GetRelatedEntities<Incident>("contract_cases", null); }
            set
            {
                this.OnPropertyChanging("contract_cases");
                this.SetRelatedEntities<Incident>("contract_cases", null, value);
                this.OnPropertyChanged("contract_cases");
            }
        }

        /// <summary>
        /// 1:N contract_connections1
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("contract_connections1")]
        public System.Collections.Generic.IEnumerable<Connection> contract_connections1
        {
            get { return this.GetRelatedEntities<Connection>("contract_connections1", null); }
            set
            {
                this.OnPropertyChanging("contract_connections1");
                this.SetRelatedEntities<Connection>("contract_connections1", null, value);
                this.OnPropertyChanged("contract_connections1");
            }
        }

        /// <summary>
        /// 1:N contract_connections2
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("contract_connections2")]
        public System.Collections.Generic.IEnumerable<Connection> contract_connections2
        {
            get { return this.GetRelatedEntities<Connection>("contract_connections2", null); }
            set
            {
                this.OnPropertyChanging("contract_connections2");
                this.SetRelatedEntities<Connection>("contract_connections2", null, value);
                this.OnPropertyChanged("contract_connections2");
            }
        }

        /// <summary>
        /// 1:N Contract_DuplicateBaseRecord
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Contract_DuplicateBaseRecord")]
        public System.Collections.Generic.IEnumerable<DuplicateRecord> Contract_DuplicateBaseRecord
        {
            get { return this.GetRelatedEntities<DuplicateRecord>("Contract_DuplicateBaseRecord", null); }
            set
            {
                this.OnPropertyChanging("Contract_DuplicateBaseRecord");
                this.SetRelatedEntities<DuplicateRecord>("Contract_DuplicateBaseRecord", null, value);
                this.OnPropertyChanged("Contract_DuplicateBaseRecord");
            }
        }

        /// <summary>
        /// 1:N Contract_DuplicateMatchingRecord
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Contract_DuplicateMatchingRecord")]
        public System.Collections.Generic.IEnumerable<DuplicateRecord> Contract_DuplicateMatchingRecord
        {
            get { return this.GetRelatedEntities<DuplicateRecord>("Contract_DuplicateMatchingRecord", null); }
            set
            {
                this.OnPropertyChanging("Contract_DuplicateMatchingRecord");
                this.SetRelatedEntities<DuplicateRecord>("Contract_DuplicateMatchingRecord", null, value);
                this.OnPropertyChanged("Contract_DuplicateMatchingRecord");
            }
        }

        /// <summary>
        /// 1:N Contract_Emails
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Contract_Emails")]
        public System.Collections.Generic.IEnumerable<Email> Contract_Emails
        {
            get { return this.GetRelatedEntities<Email>("Contract_Emails", null); }
            set
            {
                this.OnPropertyChanging("Contract_Emails");
                this.SetRelatedEntities<Email>("Contract_Emails", null, value);
                this.OnPropertyChanged("Contract_Emails");
            }
        }

        /// <summary>
        /// 1:N Contract_Faxes
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Contract_Faxes")]
        public System.Collections.Generic.IEnumerable<Fax> Contract_Faxes
        {
            get { return this.GetRelatedEntities<Fax>("Contract_Faxes", null); }
            set
            {
                this.OnPropertyChanging("Contract_Faxes");
                this.SetRelatedEntities<Fax>("Contract_Faxes", null, value);
                this.OnPropertyChanged("Contract_Faxes");
            }
        }

        /// <summary>
        /// 1:N Contract_Letters
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Contract_Letters")]
        public System.Collections.Generic.IEnumerable<Letter> Contract_Letters
        {
            get { return this.GetRelatedEntities<Letter>("Contract_Letters", null); }
            set
            {
                this.OnPropertyChanging("Contract_Letters");
                this.SetRelatedEntities<Letter>("Contract_Letters", null, value);
                this.OnPropertyChanged("Contract_Letters");
            }
        }

        /// <summary>
        /// 1:N contract_line_items
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("contract_line_items")]
        public System.Collections.Generic.IEnumerable<ContractDetail> contract_line_items
        {
            get { return this.GetRelatedEntities<ContractDetail>("contract_line_items", null); }
            set
            {
                this.OnPropertyChanging("contract_line_items");
                this.SetRelatedEntities<ContractDetail>("contract_line_items", null, value);
                this.OnPropertyChanged("contract_line_items");
            }
        }

        /// <summary>
        /// 1:N contract_originating_contract
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("contract_originating_contract", Microsoft.Xrm.Sdk.EntityRole.Referenced)]
        public System.Collections.Generic.IEnumerable<Contract> Referencedcontract_originating_contract
        {
            get { return this.GetRelatedEntities<Contract>("contract_originating_contract", Microsoft.Xrm.Sdk.EntityRole.Referenced); }
            set
            {
                this.OnPropertyChanging("Referencedcontract_originating_contract");
                this.SetRelatedEntities<Contract>("contract_originating_contract", Microsoft.Xrm.Sdk.EntityRole.Referenced, value);
                this.OnPropertyChanged("Referencedcontract_originating_contract");
            }
        }

        /// <summary>
        /// 1:N Contract_Phonecalls
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Contract_Phonecalls")]
        public System.Collections.Generic.IEnumerable<PhoneCall> Contract_Phonecalls
        {
            get { return this.GetRelatedEntities<PhoneCall>("Contract_Phonecalls", null); }
            set
            {
                this.OnPropertyChanging("Contract_Phonecalls");
                this.SetRelatedEntities<PhoneCall>("Contract_Phonecalls", null, value);
                this.OnPropertyChanged("Contract_Phonecalls");
            }
        }

        /// <summary>
        /// 1:N contract_principalobjectattributeaccess
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("contract_principalobjectattributeaccess")]
        public System.Collections.Generic.IEnumerable<PrincipalObjectAttributeAccess> contract_principalobjectattributeaccess
        {
            get { return this.GetRelatedEntities<PrincipalObjectAttributeAccess>("contract_principalobjectattributeaccess", null); }
            set
            {
                this.OnPropertyChanging("contract_principalobjectattributeaccess");
                this.SetRelatedEntities<PrincipalObjectAttributeAccess>("contract_principalobjectattributeaccess", null, value);
                this.OnPropertyChanged("contract_principalobjectattributeaccess");
            }
        }

        /// <summary>
        /// 1:N Contract_ProcessSessions
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Contract_ProcessSessions")]
        public System.Collections.Generic.IEnumerable<ProcessSession> Contract_ProcessSessions
        {
            get { return this.GetRelatedEntities<ProcessSession>("Contract_ProcessSessions", null); }
            set
            {
                this.OnPropertyChanging("Contract_ProcessSessions");
                this.SetRelatedEntities<ProcessSession>("Contract_ProcessSessions", null, value);
                this.OnPropertyChanged("Contract_ProcessSessions");
            }
        }

        /// <summary>
        /// 1:N Contract_RecurringAppointmentMasters
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Contract_RecurringAppointmentMasters")]
        public System.Collections.Generic.IEnumerable<RecurringAppointmentMaster> Contract_RecurringAppointmentMasters
        {
            get { return this.GetRelatedEntities<RecurringAppointmentMaster>("Contract_RecurringAppointmentMasters", null); }
            set
            {
                this.OnPropertyChanging("Contract_RecurringAppointmentMasters");
                this.SetRelatedEntities<RecurringAppointmentMaster>("Contract_RecurringAppointmentMasters", null, value);
                this.OnPropertyChanged("Contract_RecurringAppointmentMasters");
            }
        }

        /// <summary>
        /// 1:N Contract_ServiceAppointments
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Contract_ServiceAppointments")]
        public System.Collections.Generic.IEnumerable<ServiceAppointment> Contract_ServiceAppointments
        {
            get { return this.GetRelatedEntities<ServiceAppointment>("Contract_ServiceAppointments", null); }
            set
            {
                this.OnPropertyChanging("Contract_ServiceAppointments");
                this.SetRelatedEntities<ServiceAppointment>("Contract_ServiceAppointments", null, value);
                this.OnPropertyChanged("Contract_ServiceAppointments");
            }
        }

        /// <summary>
        /// 1:N Contract_SocialActivities
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Contract_SocialActivities")]
        public System.Collections.Generic.IEnumerable<SocialActivity> Contract_SocialActivities
        {
            get { return this.GetRelatedEntities<SocialActivity>("Contract_SocialActivities", null); }
            set
            {
                this.OnPropertyChanging("Contract_SocialActivities");
                this.SetRelatedEntities<SocialActivity>("Contract_SocialActivities", null, value);
                this.OnPropertyChanged("Contract_SocialActivities");
            }
        }

        /// <summary>
        /// 1:N Contract_Tasks
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Contract_Tasks")]
        public System.Collections.Generic.IEnumerable<Task> Contract_Tasks
        {
            get { return this.GetRelatedEntities<Task>("Contract_Tasks", null); }
            set
            {
                this.OnPropertyChanging("Contract_Tasks");
                this.SetRelatedEntities<Task>("Contract_Tasks", null, value);
                this.OnPropertyChanged("Contract_Tasks");
            }
        }

        /// <summary>
        /// 1:N userentityinstancedata_contract
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_contract")]
        public System.Collections.Generic.IEnumerable<UserEntityInstanceData> userentityinstancedata_contract
        {
            get { return this.GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_contract", null); }
            set
            {
                this.OnPropertyChanging("userentityinstancedata_contract");
                this.SetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_contract", null, value);
                this.OnPropertyChanged("userentityinstancedata_contract");
            }
        }

        /// <summary>
        /// N:N servicecontractcontacts_association
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("servicecontractcontacts_association")]
        public System.Collections.Generic.IEnumerable<Contact> servicecontractcontacts_association
        {
            get { return this.GetRelatedEntities<Contact>("servicecontractcontacts_association", null); }
            set
            {
                this.OnPropertyChanging("servicecontractcontacts_association");
                this.SetRelatedEntities<Contact>("servicecontractcontacts_association", null, value);
                this.OnPropertyChanged("servicecontractcontacts_association");
            }
        }

        /// <summary>
        /// N:1 business_unit_service_contracts
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_service_contracts")]
        public BusinessUnit business_unit_service_contracts
        {
            get { return this.GetRelatedEntity<BusinessUnit>("business_unit_service_contracts", null); }
        }

        /// <summary>
        /// N:1 contract_billingcustomer_accounts
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("billingcustomerid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("contract_billingcustomer_accounts")]
        public Account contract_billingcustomer_accounts
        {
            get { return this.GetRelatedEntity<Account>("contract_billingcustomer_accounts", null); }
            set
            {
                this.OnPropertyChanging("contract_billingcustomer_accounts");
                this.SetRelatedEntity<Account>("contract_billingcustomer_accounts", null, value);
                this.OnPropertyChanged("contract_billingcustomer_accounts");
            }
        }

        /// <summary>
        /// N:1 contract_billingcustomer_contacts
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("billingcustomerid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("contract_billingcustomer_contacts")]
        public Contact contract_billingcustomer_contacts
        {
            get { return this.GetRelatedEntity<Contact>("contract_billingcustomer_contacts", null); }
            set
            {
                this.OnPropertyChanging("contract_billingcustomer_contacts");
                this.SetRelatedEntity<Contact>("contract_billingcustomer_contacts", null, value);
                this.OnPropertyChanged("contract_billingcustomer_contacts");
            }
        }

        /// <summary>
        /// N:1 contract_customer_accounts
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("customerid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("contract_customer_accounts")]
        public Account contract_customer_accounts
        {
            get { return this.GetRelatedEntity<Account>("contract_customer_accounts", null); }
            set
            {
                this.OnPropertyChanging("contract_customer_accounts");
                this.SetRelatedEntity<Account>("contract_customer_accounts", null, value);
                this.OnPropertyChanged("contract_customer_accounts");
            }
        }

        /// <summary>
        /// N:1 contract_customer_contacts
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("customerid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("contract_customer_contacts")]
        public Contact contract_customer_contacts
        {
            get { return this.GetRelatedEntity<Contact>("contract_customer_contacts", null); }
            set
            {
                this.OnPropertyChanging("contract_customer_contacts");
                this.SetRelatedEntity<Contact>("contract_customer_contacts", null, value);
                this.OnPropertyChanged("contract_customer_contacts");
            }
        }

        /// <summary>
        /// N:1 contract_originating_contract
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("originatingcontract")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("contract_originating_contract", Microsoft.Xrm.Sdk.EntityRole.Referencing)]
        public Contract Referencingcontract_originating_contract
        {
            get { return this.GetRelatedEntity<Contract>("contract_originating_contract", Microsoft.Xrm.Sdk.EntityRole.Referencing); }
            set
            {
                this.OnPropertyChanging("Referencingcontract_originating_contract");
                this.SetRelatedEntity<Contract>("contract_originating_contract", Microsoft.Xrm.Sdk.EntityRole.Referencing, value);
                this.OnPropertyChanged("Referencingcontract_originating_contract");
            }
        }

        /// <summary>
        /// N:1 contract_template_contracts
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("contracttemplateid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("contract_template_contracts")]
        public ContractTemplate contract_template_contracts
        {
            get { return this.GetRelatedEntity<ContractTemplate>("contract_template_contracts", null); }
            set
            {
                this.OnPropertyChanging("contract_template_contracts");
                this.SetRelatedEntity<ContractTemplate>("contract_template_contracts", null, value);
                this.OnPropertyChanged("contract_template_contracts");
            }
        }

        /// <summary>
        /// N:1 customer_address_contracts_as_billing_address
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("billtoaddress")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("customer_address_contracts_as_billing_address")]
        public CustomerAddress customer_address_contracts_as_billing_address
        {
            get { return this.GetRelatedEntity<CustomerAddress>("customer_address_contracts_as_billing_address", null); }
            set
            {
                this.OnPropertyChanging("customer_address_contracts_as_billing_address");
                this.SetRelatedEntity<CustomerAddress>("customer_address_contracts_as_billing_address", null, value);
                this.OnPropertyChanged("customer_address_contracts_as_billing_address");
            }
        }

        /// <summary>
        /// N:1 customer_address_contracts_as_service_address
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("serviceaddress")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("customer_address_contracts_as_service_address")]
        public CustomerAddress customer_address_contracts_as_service_address
        {
            get { return this.GetRelatedEntity<CustomerAddress>("customer_address_contracts_as_service_address", null); }
            set
            {
                this.OnPropertyChanging("customer_address_contracts_as_service_address");
                this.SetRelatedEntity<CustomerAddress>("customer_address_contracts_as_service_address", null, value);
                this.OnPropertyChanged("customer_address_contracts_as_service_address");
            }
        }

        /// <summary>
        /// N:1 lk_contract_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_contract_createdonbehalfby")]
        public SystemUser lk_contract_createdonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_contract_createdonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_contract_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_contract_modifiedonbehalfby")]
        public SystemUser lk_contract_modifiedonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_contract_modifiedonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_contractbase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_contractbase_createdby")]
        public SystemUser lk_contractbase_createdby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_contractbase_createdby", null); }
        }

        /// <summary>
        /// N:1 lk_contractbase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_contractbase_modifiedby")]
        public SystemUser lk_contractbase_modifiedby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_contractbase_modifiedby", null); }
        }

        /// <summary>
        /// N:1 system_user_service_contracts
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("system_user_service_contracts")]
        public SystemUser system_user_service_contracts
        {
            get { return this.GetRelatedEntity<SystemUser>("system_user_service_contracts", null); }
        }

        /// <summary>
        /// N:1 team_service_contracts
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_service_contracts")]
        public Team team_service_contracts
        {
            get { return this.GetRelatedEntity<Team>("team_service_contracts", null); }
        }

        /// <summary>
        /// N:1 transactioncurrency_contract
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("transactioncurrency_contract")]
        public TransactionCurrency transactioncurrency_contract
        {
            get { return this.GetRelatedEntity<TransactionCurrency>("transactioncurrency_contract", null); }
            set
            {
                this.OnPropertyChanging("transactioncurrency_contract");
                this.SetRelatedEntity<TransactionCurrency>("transactioncurrency_contract", null, value);
                this.OnPropertyChanged("transactioncurrency_contract");
            }
        }
    }
}