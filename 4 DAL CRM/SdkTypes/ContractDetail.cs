using _4_DAL_CRM;

namespace __4_DAL_CRM
{
    /// <summary>
    /// Line item in a contract that specifies the type of service a customer is entitled to.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("contractdetail")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class ContractDetail : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public ContractDetail() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "contractdetail";

        public const int EntityTypeCode = 1011;

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
        /// Enter the date when the contract line becomes active.
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
        /// Shows the number of minutes over the Total Allotments field that have been spent on resolved cases related to the contract line.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("allotmentsoverage")]
        public System.Nullable<int> AllotmentsOverage
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("allotmentsoverage"); }
        }

        /// <summary>
        /// Shows the number of cases or minutes remaining, based on the resolved cases logged to the contract line.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("allotmentsremaining")]
        public System.Nullable<int> AllotmentsRemaining
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("allotmentsremaining"); }
        }

        /// <summary>
        /// Shows the number of cases or minutes used in the resolved cases on the contract line.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("allotmentsused")]
        public System.Nullable<int> AllotmentsUsed
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("allotmentsused"); }
        }

        /// <summary>
        /// Unique identifier for the contact associated with the contract line.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("contactid")]
        public Microsoft.Xrm.Sdk.EntityReference ContactId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("contactid"); }
        }

        /// <summary>
        /// Unique identifier of the contract line.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("contractdetailid")]
        public System.Nullable<System.Guid> ContractDetailId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("contractdetailid"); }
            set
            {
                this.OnPropertyChanging("ContractDetailId");
                this.SetAttributeValue("contractdetailid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("ContractDetailId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("contractdetailid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.ContractDetailId = value; }
        }

        /// <summary>
        /// Unique identifier of the contract associated with the contract line.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("contractid")]
        public Microsoft.Xrm.Sdk.EntityReference ContractId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("contractid"); }
            set
            {
                this.OnPropertyChanging("ContractId");
                this.SetAttributeValue("contractid", value);
                this.OnPropertyChanged("ContractId");
            }
        }

        /// <summary>
        /// Status of the contract.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("contractstatecode")]
        public Microsoft.Xrm.Sdk.OptionSetValue ContractStateCode
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("contractstatecode"); }
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
        /// Type the discount amount for the contract line to deduct any negotiated or other savings from the net amount due.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("discount")]
        public Microsoft.Xrm.Sdk.Money Discount
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("discount"); }
            set
            {
                this.OnPropertyChanging("Discount");
                this.SetAttributeValue("discount", value);
                this.OnPropertyChanged("Discount");
            }
        }

        /// <summary>
        /// Shows the Discount field converted to the system's default base currency. The calculation uses the exchange rate specified in the Currencies area.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("discount_base")]
        public Microsoft.Xrm.Sdk.Money Discount_Base
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("discount_base"); }
        }

        /// <summary>
        /// Type the discount rate that should be applied to the Total Price, for use in calculating the net amount due for the contract line.
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
        /// Days of the week and times for which the contract line item is effective.
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
        /// Shows the conversion rate of the record's currency. The exchange rate is used to convert all money fields in the record from the local currency to the system's default currency.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("exchangerate")]
        public System.Nullable<decimal> ExchangeRate
        {
            get { return this.GetAttributeValue<System.Nullable<decimal>>("exchangerate"); }
        }

        /// <summary>
        /// Enter the date when the contract line expires. The date is automatically filled with the contract date, but you can change it if required.
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
        /// Type the number of units of the specified product or service that are eligible for support on the contract line.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("initialquantity")]
        public System.Nullable<int> InitialQuantity
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("initialquantity"); }
            set
            {
                this.OnPropertyChanging("InitialQuantity");
                this.SetAttributeValue("initialquantity", value);
                this.OnPropertyChanged("InitialQuantity");
            }
        }

        /// <summary>
        /// Type the line item number for the contract line to easily identify the contract line and make sure it's listed in the correct order in the parent contract.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("lineitemorder")]
        public System.Nullable<int> LineItemOrder
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("lineitemorder"); }
            set
            {
                this.OnPropertyChanging("LineItemOrder");
                this.SetAttributeValue("lineitemorder", value);
                this.OnPropertyChanged("LineItemOrder");
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
        /// Shows the total charge to the customer for the contract line, calculated as the Total Price minus any discounts.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("net")]
        public Microsoft.Xrm.Sdk.Money Net
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("net"); }
        }

        /// <summary>
        /// Shows the Net field converted to the system's default base currency for reporting purposes. The calculation uses the exchange rate specified in the Currencies area.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("net_base")]
        public Microsoft.Xrm.Sdk.Money Net_Base
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("net_base"); }
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
        /// Unique identifier of the user or team who owns the contract detail.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ownerid")]
        public Microsoft.Xrm.Sdk.EntityReference OwnerId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("ownerid"); }
        }

        /// <summary>
        /// Unique identifier of the business unit that owns the contract line.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
        public System.Nullable<System.Guid> OwningBusinessUnit
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("owningbusinessunit"); }
        }

        /// <summary>
        /// Unique identifier of the user who owns the contract line.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
        public System.Nullable<System.Guid> OwningUser
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("owninguser"); }
        }

        /// <summary>
        /// Type the total service charge for the contract line before any discounts are credited.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("price")]
        public Microsoft.Xrm.Sdk.Money Price
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("price"); }
            set
            {
                this.OnPropertyChanging("Price");
                this.SetAttributeValue("price", value);
                this.OnPropertyChanged("Price");
            }
        }

        /// <summary>
        /// Shows the Total Price field converted to the system's default base currency for reporting purposes. The calculation uses the exchange rate specified in the Currencies area.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("price_base")]
        public Microsoft.Xrm.Sdk.Money Price_Base
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("price_base"); }
        }

        /// <summary>
        /// Choose the product that is eligible for services on the contract line.
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
        /// Type the serial number for the product that is eligible for services on the contract line.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("productserialnumber")]
        public string ProductSerialNumber
        {
            get { return this.GetAttributeValue<string>("productserialnumber"); }
            set
            {
                this.OnPropertyChanging("ProductSerialNumber");
                this.SetAttributeValue("productserialnumber", value);
                this.OnPropertyChanged("ProductSerialNumber");
            }
        }

        /// <summary>
        /// Shows the cost per case or minute, calculated by dividing the Total Price value by the total number of cases or minutes allocated to the contract line.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rate")]
        public Microsoft.Xrm.Sdk.Money Rate
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("rate"); }
        }

        /// <summary>
        /// Shows the Rate field converted to the system's default base currency for reporting purposes. The calculation uses the exchange rate specified in the Currencies area.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rate_base")]
        public Microsoft.Xrm.Sdk.Money Rate_Base
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("rate_base"); }
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
        /// Select the unit type allotted in the contract line, such as cases or minutes, to determine the level of support.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("servicecontractunitscode")]
        public Microsoft.Xrm.Sdk.OptionSetValue ServiceContractUnitsCode
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("servicecontractunitscode"); }
            set
            {
                this.OnPropertyChanging("ServiceContractUnitsCode");
                this.SetAttributeValue("servicecontractunitscode", value);
                this.OnPropertyChanged("ServiceContractUnitsCode");
            }
        }

        /// <summary>
        /// Shows whether the contract line is existing, renewed, canceled, or expired. You can't edit a contract line after it is saved, regardless of the status.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
        public System.Nullable<ContractDetailState> StateCode
        {
            get
            {
                Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
                if ((optionSet != null))
                {
                    return ((ContractDetailState) (System.Enum.ToObject(typeof(ContractDetailState), optionSet.Value)));
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// Select the contract line's status.
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
        /// Type a title or name that describes the contract line.
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
        /// Type the total number of minutes or cases allowed for the contract line.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("totalallotments")]
        public System.Nullable<int> TotalAllotments
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("totalallotments"); }
            set
            {
                this.OnPropertyChanging("TotalAllotments");
                this.SetAttributeValue("totalallotments", value);
                this.OnPropertyChanged("TotalAllotments");
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
        /// Unique identifier of the unit group associated with the contract line.
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
        /// Version number of the contract template.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
        public System.Nullable<long> VersionNumber
        {
            get { return this.GetAttributeValue<System.Nullable<long>>("versionnumber"); }
        }

        /// <summary>
        /// 1:N contract_detail_cases
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("contract_detail_cases")]
        public System.Collections.Generic.IEnumerable<Incident> contract_detail_cases
        {
            get { return this.GetRelatedEntities<Incident>("contract_detail_cases", null); }
            set
            {
                this.OnPropertyChanging("contract_detail_cases");
                this.SetRelatedEntities<Incident>("contract_detail_cases", null, value);
                this.OnPropertyChanged("contract_detail_cases");
            }
        }

        /// <summary>
        /// 1:N ContractDetail_Annotation
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ContractDetail_Annotation")]
        public System.Collections.Generic.IEnumerable<Annotation> ContractDetail_Annotation
        {
            get { return this.GetRelatedEntities<Annotation>("ContractDetail_Annotation", null); }
            set
            {
                this.OnPropertyChanging("ContractDetail_Annotation");
                this.SetRelatedEntities<Annotation>("ContractDetail_Annotation", null, value);
                this.OnPropertyChanged("ContractDetail_Annotation");
            }
        }

        /// <summary>
        /// 1:N ContractDetail_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ContractDetail_AsyncOperations")]
        public System.Collections.Generic.IEnumerable<AsyncOperation> ContractDetail_AsyncOperations
        {
            get { return this.GetRelatedEntities<AsyncOperation>("ContractDetail_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("ContractDetail_AsyncOperations");
                this.SetRelatedEntities<AsyncOperation>("ContractDetail_AsyncOperations", null, value);
                this.OnPropertyChanged("ContractDetail_AsyncOperations");
            }
        }

        /// <summary>
        /// 1:N ContractDetail_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ContractDetail_BulkDeleteFailures")]
        public System.Collections.Generic.IEnumerable<BulkDeleteFailure> ContractDetail_BulkDeleteFailures
        {
            get { return this.GetRelatedEntities<BulkDeleteFailure>("ContractDetail_BulkDeleteFailures", null); }
            set
            {
                this.OnPropertyChanging("ContractDetail_BulkDeleteFailures");
                this.SetRelatedEntities<BulkDeleteFailure>("ContractDetail_BulkDeleteFailures", null, value);
                this.OnPropertyChanged("ContractDetail_BulkDeleteFailures");
            }
        }

        /// <summary>
        /// 1:N contractdetail_principalobjectattributeaccess
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("contractdetail_principalobjectattributeaccess")]
        public System.Collections.Generic.IEnumerable<PrincipalObjectAttributeAccess> contractdetail_principalobjectattributeaccess
        {
            get { return this.GetRelatedEntities<PrincipalObjectAttributeAccess>("contractdetail_principalobjectattributeaccess", null); }
            set
            {
                this.OnPropertyChanging("contractdetail_principalobjectattributeaccess");
                this.SetRelatedEntities<PrincipalObjectAttributeAccess>("contractdetail_principalobjectattributeaccess", null, value);
                this.OnPropertyChanged("contractdetail_principalobjectattributeaccess");
            }
        }

        /// <summary>
        /// 1:N ContractDetail_ProcessSessions
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ContractDetail_ProcessSessions")]
        public System.Collections.Generic.IEnumerable<ProcessSession> ContractDetail_ProcessSessions
        {
            get { return this.GetRelatedEntities<ProcessSession>("ContractDetail_ProcessSessions", null); }
            set
            {
                this.OnPropertyChanging("ContractDetail_ProcessSessions");
                this.SetRelatedEntities<ProcessSession>("ContractDetail_ProcessSessions", null, value);
                this.OnPropertyChanged("ContractDetail_ProcessSessions");
            }
        }

        /// <summary>
        /// 1:N userentityinstancedata_contractdetail
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_contractdetail")]
        public System.Collections.Generic.IEnumerable<UserEntityInstanceData> userentityinstancedata_contractdetail
        {
            get { return this.GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_contractdetail", null); }
            set
            {
                this.OnPropertyChanging("userentityinstancedata_contractdetail");
                this.SetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_contractdetail", null, value);
                this.OnPropertyChanged("userentityinstancedata_contractdetail");
            }
        }

        /// <summary>
        /// N:1 contract_detail_unit_of_measure_schedule
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("uomscheduleid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("contract_detail_unit_of_measure_schedule")]
        public UoMSchedule contract_detail_unit_of_measure_schedule
        {
            get { return this.GetRelatedEntity<UoMSchedule>("contract_detail_unit_of_measure_schedule", null); }
            set
            {
                this.OnPropertyChanging("contract_detail_unit_of_measure_schedule");
                this.SetRelatedEntity<UoMSchedule>("contract_detail_unit_of_measure_schedule", null, value);
                this.OnPropertyChanged("contract_detail_unit_of_measure_schedule");
            }
        }

        /// <summary>
        /// N:1 contract_line_items
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("contractid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("contract_line_items")]
        public Contract contract_line_items
        {
            get { return this.GetRelatedEntity<Contract>("contract_line_items", null); }
            set
            {
                this.OnPropertyChanging("contract_line_items");
                this.SetRelatedEntity<Contract>("contract_line_items", null, value);
                this.OnPropertyChanged("contract_line_items");
            }
        }

        /// <summary>
        /// N:1 contractlineitem_customer_accounts
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("customerid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("contractlineitem_customer_accounts")]
        public Account contractlineitem_customer_accounts
        {
            get { return this.GetRelatedEntity<Account>("contractlineitem_customer_accounts", null); }
            set
            {
                this.OnPropertyChanging("contractlineitem_customer_accounts");
                this.SetRelatedEntity<Account>("contractlineitem_customer_accounts", null, value);
                this.OnPropertyChanged("contractlineitem_customer_accounts");
            }
        }

        /// <summary>
        /// N:1 contractlineitem_customer_contacts
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("customerid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("contractlineitem_customer_contacts")]
        public Contact contractlineitem_customer_contacts
        {
            get { return this.GetRelatedEntity<Contact>("contractlineitem_customer_contacts", null); }
            set
            {
                this.OnPropertyChanging("contractlineitem_customer_contacts");
                this.SetRelatedEntity<Contact>("contractlineitem_customer_contacts", null, value);
                this.OnPropertyChanged("contractlineitem_customer_contacts");
            }
        }

        /// <summary>
        /// N:1 customer_address_contract_line_items
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("serviceaddress")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("customer_address_contract_line_items")]
        public CustomerAddress customer_address_contract_line_items
        {
            get { return this.GetRelatedEntity<CustomerAddress>("customer_address_contract_line_items", null); }
            set
            {
                this.OnPropertyChanging("customer_address_contract_line_items");
                this.SetRelatedEntity<CustomerAddress>("customer_address_contract_line_items", null, value);
                this.OnPropertyChanged("customer_address_contract_line_items");
            }
        }

        /// <summary>
        /// N:1 lk_contractdetail_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_contractdetail_createdonbehalfby")]
        public SystemUser lk_contractdetail_createdonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_contractdetail_createdonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_contractdetail_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_contractdetail_modifiedonbehalfby")]
        public SystemUser lk_contractdetail_modifiedonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_contractdetail_modifiedonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_contractdetailbase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_contractdetailbase_createdby")]
        public SystemUser lk_contractdetailbase_createdby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_contractdetailbase_createdby", null); }
        }

        /// <summary>
        /// N:1 lk_contractdetailbase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_contractdetailbase_modifiedby")]
        public SystemUser lk_contractdetailbase_modifiedby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_contractdetailbase_modifiedby", null); }
        }

        /// <summary>
        /// N:1 product_contract_line_items
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("productid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("product_contract_line_items")]
        public Product product_contract_line_items
        {
            get { return this.GetRelatedEntity<Product>("product_contract_line_items", null); }
            set
            {
                this.OnPropertyChanging("product_contract_line_items");
                this.SetRelatedEntity<Product>("product_contract_line_items", null, value);
                this.OnPropertyChanged("product_contract_line_items");
            }
        }

        /// <summary>
        /// N:1 transactioncurrency_contractdetail
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("transactioncurrency_contractdetail")]
        public TransactionCurrency transactioncurrency_contractdetail
        {
            get { return this.GetRelatedEntity<TransactionCurrency>("transactioncurrency_contractdetail", null); }
        }

        /// <summary>
        /// N:1 unit_of_measurement_contract_line_items
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("uomid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("unit_of_measurement_contract_line_items")]
        public UoM unit_of_measurement_contract_line_items
        {
            get { return this.GetRelatedEntity<UoM>("unit_of_measurement_contract_line_items", null); }
            set
            {
                this.OnPropertyChanging("unit_of_measurement_contract_line_items");
                this.SetRelatedEntity<UoM>("unit_of_measurement_contract_line_items", null, value);
                this.OnPropertyChanged("unit_of_measurement_contract_line_items");
            }
        }
    }
}