using _4_DAL_CRM;

namespace __4_DAL_CRM
{
    /// <summary>
    /// Currency in which a financial transaction is carried out.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("transactioncurrency")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class TransactionCurrency : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public TransactionCurrency() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "transactioncurrency";

        public const int EntityTypeCode = 9105;

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
        /// Unique identifier of the user who created the transaction currency.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby"); }
        }

        /// <summary>
        /// Date and time when the transaction currency was created.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
        public System.Nullable<System.DateTime> CreatedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who created the transactioncurrency.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        /// Name of the transaction currency.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("currencyname")]
        public string CurrencyName
        {
            get { return this.GetAttributeValue<string>("currencyname"); }
            set
            {
                this.OnPropertyChanging("CurrencyName");
                this.SetAttributeValue("currencyname", value);
                this.OnPropertyChanged("CurrencyName");
            }
        }

        /// <summary>
        /// Number of decimal places that can be used for currency.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("currencyprecision")]
        public System.Nullable<int> CurrencyPrecision
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("currencyprecision"); }
            set
            {
                this.OnPropertyChanging("CurrencyPrecision");
                this.SetAttributeValue("currencyprecision", value);
                this.OnPropertyChanged("CurrencyPrecision");
            }
        }

        /// <summary>
        /// Symbol for the transaction currency.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("currencysymbol")]
        public string CurrencySymbol
        {
            get { return this.GetAttributeValue<string>("currencysymbol"); }
            set
            {
                this.OnPropertyChanging("CurrencySymbol");
                this.SetAttributeValue("currencysymbol", value);
                this.OnPropertyChanged("CurrencySymbol");
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
        /// Exchange rate between the transaction currency and the base currency.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("exchangerate")]
        public System.Nullable<decimal> ExchangeRate
        {
            get { return this.GetAttributeValue<System.Nullable<decimal>>("exchangerate"); }
            set
            {
                this.OnPropertyChanging("ExchangeRate");
                this.SetAttributeValue("exchangerate", value);
                this.OnPropertyChanged("ExchangeRate");
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
        /// ISO currency code for the transaction currency.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isocurrencycode")]
        public string ISOCurrencyCode
        {
            get { return this.GetAttributeValue<string>("isocurrencycode"); }
            set
            {
                this.OnPropertyChanging("ISOCurrencyCode");
                this.SetAttributeValue("isocurrencycode", value);
                this.OnPropertyChanged("ISOCurrencyCode");
            }
        }

        /// <summary>
        /// Unique identifier of the user who last modified the transaction currency.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby"); }
        }

        /// <summary>
        /// Date and time when the transaction currency was last modified.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
        public System.Nullable<System.DateTime> ModifiedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who last modified the transactioncurrency.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        /// Unique identifier of the organization associated with the transaction currency.
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
        /// Status of the transaction currency.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
        public System.Nullable<TransactionCurrencyState> StateCode
        {
            get
            {
                Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
                if ((optionSet != null))
                {
                    return ((TransactionCurrencyState) (System.Enum.ToObject(typeof(TransactionCurrencyState), optionSet.Value)));
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// Reason for the status of the transaction currency.
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
        /// Unique identifier of the transaction currency.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyid")]
        public System.Nullable<System.Guid> TransactionCurrencyId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("transactioncurrencyid"); }
            set
            {
                this.OnPropertyChanging("TransactionCurrencyId");
                this.SetAttributeValue("transactioncurrencyid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("TransactionCurrencyId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.TransactionCurrencyId = value; }
        }

        /// <summary>
        /// Version number of the transaction currency.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
        public System.Nullable<long> VersionNumber
        {
            get { return this.GetAttributeValue<System.Nullable<long>>("versionnumber"); }
        }

        /// <summary>
        /// 1:N basecurrency_organization
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("basecurrency_organization")]
        public System.Collections.Generic.IEnumerable<Organization> basecurrency_organization
        {
            get { return this.GetRelatedEntities<Organization>("basecurrency_organization", null); }
            set
            {
                this.OnPropertyChanging("basecurrency_organization");
                this.SetRelatedEntities<Organization>("basecurrency_organization", null, value);
                this.OnPropertyChanged("basecurrency_organization");
            }
        }

        /// <summary>
        /// 1:N DynamicPropertyAssociation_TransactionCurrency
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("DynamicPropertyAssociation_TransactionCurrency")]
        public System.Collections.Generic.IEnumerable<DynamicPropertyAssociation> DynamicPropertyAssociation_TransactionCurrency
        {
            get { return this.GetRelatedEntities<DynamicPropertyAssociation>("DynamicPropertyAssociation_TransactionCurrency", null); }
            set
            {
                this.OnPropertyChanging("DynamicPropertyAssociation_TransactionCurrency");
                this.SetRelatedEntities<DynamicPropertyAssociation>("DynamicPropertyAssociation_TransactionCurrency", null, value);
                this.OnPropertyChanged("DynamicPropertyAssociation_TransactionCurrency");
            }
        }

        /// <summary>
        /// 1:N DynamicPropertyOptionSetItem_TransactionCurrency
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("DynamicPropertyOptionSetItem_TransactionCurrency")]
        public System.Collections.Generic.IEnumerable<DynamicPropertyOptionSetItem> DynamicPropertyOptionSetItem_TransactionCurrency
        {
            get { return this.GetRelatedEntities<DynamicPropertyOptionSetItem>("DynamicPropertyOptionSetItem_TransactionCurrency", null); }
            set
            {
                this.OnPropertyChanging("DynamicPropertyOptionSetItem_TransactionCurrency");
                this.SetRelatedEntities<DynamicPropertyOptionSetItem>("DynamicPropertyOptionSetItem_TransactionCurrency", null, value);
                this.OnPropertyChanged("DynamicPropertyOptionSetItem_TransactionCurrency");
            }
        }

        /// <summary>
        /// 1:N transactioncurrency_account
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("transactioncurrency_account")]
        public System.Collections.Generic.IEnumerable<Account> transactioncurrency_account
        {
            get { return this.GetRelatedEntities<Account>("transactioncurrency_account", null); }
            set
            {
                this.OnPropertyChanging("transactioncurrency_account");
                this.SetRelatedEntities<Account>("transactioncurrency_account", null, value);
                this.OnPropertyChanged("transactioncurrency_account");
            }
        }

        /// <summary>
        /// 1:N TransactionCurrency_ActivityPointer
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("TransactionCurrency_ActivityPointer")]
        public System.Collections.Generic.IEnumerable<ActivityPointer> TransactionCurrency_ActivityPointer
        {
            get { return this.GetRelatedEntities<ActivityPointer>("TransactionCurrency_ActivityPointer", null); }
            set
            {
                this.OnPropertyChanging("TransactionCurrency_ActivityPointer");
                this.SetRelatedEntities<ActivityPointer>("TransactionCurrency_ActivityPointer", null, value);
                this.OnPropertyChanged("TransactionCurrency_ActivityPointer");
            }
        }

        /// <summary>
        /// 1:N transactioncurrency_annualfiscalcalendar
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("transactioncurrency_annualfiscalcalendar")]
        public System.Collections.Generic.IEnumerable<AnnualFiscalCalendar> transactioncurrency_annualfiscalcalendar
        {
            get { return this.GetRelatedEntities<AnnualFiscalCalendar>("transactioncurrency_annualfiscalcalendar", null); }
            set
            {
                this.OnPropertyChanging("transactioncurrency_annualfiscalcalendar");
                this.SetRelatedEntities<AnnualFiscalCalendar>("transactioncurrency_annualfiscalcalendar", null, value);
                this.OnPropertyChanged("transactioncurrency_annualfiscalcalendar");
            }
        }

        /// <summary>
        /// 1:N TransactionCurrency_Appointment
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("TransactionCurrency_Appointment")]
        public System.Collections.Generic.IEnumerable<Appointment> TransactionCurrency_Appointment
        {
            get { return this.GetRelatedEntities<Appointment>("TransactionCurrency_Appointment", null); }
            set
            {
                this.OnPropertyChanging("TransactionCurrency_Appointment");
                this.SetRelatedEntities<Appointment>("TransactionCurrency_Appointment", null, value);
                this.OnPropertyChanged("TransactionCurrency_Appointment");
            }
        }

        /// <summary>
        /// 1:N TransactionCurrency_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("TransactionCurrency_AsyncOperations")]
        public System.Collections.Generic.IEnumerable<AsyncOperation> TransactionCurrency_AsyncOperations
        {
            get { return this.GetRelatedEntities<AsyncOperation>("TransactionCurrency_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("TransactionCurrency_AsyncOperations");
                this.SetRelatedEntities<AsyncOperation>("TransactionCurrency_AsyncOperations", null, value);
                this.OnPropertyChanged("TransactionCurrency_AsyncOperations");
            }
        }

        /// <summary>
        /// 1:N TransactionCurrency_BusinessUnit
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("TransactionCurrency_BusinessUnit")]
        public System.Collections.Generic.IEnumerable<BusinessUnit> TransactionCurrency_BusinessUnit
        {
            get { return this.GetRelatedEntities<BusinessUnit>("TransactionCurrency_BusinessUnit", null); }
            set
            {
                this.OnPropertyChanging("TransactionCurrency_BusinessUnit");
                this.SetRelatedEntities<BusinessUnit>("TransactionCurrency_BusinessUnit", null, value);
                this.OnPropertyChanged("TransactionCurrency_BusinessUnit");
            }
        }

        /// <summary>
        /// 1:N transactioncurrency_campaign
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("transactioncurrency_campaign")]
        public System.Collections.Generic.IEnumerable<Campaign> transactioncurrency_campaign
        {
            get { return this.GetRelatedEntities<Campaign>("transactioncurrency_campaign", null); }
            set
            {
                this.OnPropertyChanging("transactioncurrency_campaign");
                this.SetRelatedEntities<Campaign>("transactioncurrency_campaign", null, value);
                this.OnPropertyChanged("transactioncurrency_campaign");
            }
        }

        /// <summary>
        /// 1:N transactioncurrency_campaignactivity
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("transactioncurrency_campaignactivity")]
        public System.Collections.Generic.IEnumerable<CampaignActivity> transactioncurrency_campaignactivity
        {
            get { return this.GetRelatedEntities<CampaignActivity>("transactioncurrency_campaignactivity", null); }
            set
            {
                this.OnPropertyChanging("transactioncurrency_campaignactivity");
                this.SetRelatedEntities<CampaignActivity>("transactioncurrency_campaignactivity", null, value);
                this.OnPropertyChanged("transactioncurrency_campaignactivity");
            }
        }

        /// <summary>
        /// 1:N TransactionCurrency_CampaignResponse
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("TransactionCurrency_CampaignResponse")]
        public System.Collections.Generic.IEnumerable<CampaignResponse> TransactionCurrency_CampaignResponse
        {
            get { return this.GetRelatedEntities<CampaignResponse>("TransactionCurrency_CampaignResponse", null); }
            set
            {
                this.OnPropertyChanging("TransactionCurrency_CampaignResponse");
                this.SetRelatedEntities<CampaignResponse>("TransactionCurrency_CampaignResponse", null, value);
                this.OnPropertyChanged("TransactionCurrency_CampaignResponse");
            }
        }

        /// <summary>
        /// 1:N transactioncurrency_competitor
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("transactioncurrency_competitor")]
        public System.Collections.Generic.IEnumerable<Competitor> transactioncurrency_competitor
        {
            get { return this.GetRelatedEntities<Competitor>("transactioncurrency_competitor", null); }
            set
            {
                this.OnPropertyChanging("transactioncurrency_competitor");
                this.SetRelatedEntities<Competitor>("transactioncurrency_competitor", null, value);
                this.OnPropertyChanged("transactioncurrency_competitor");
            }
        }

        /// <summary>
        /// 1:N TransactionCurrency_Connection
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("TransactionCurrency_Connection")]
        public System.Collections.Generic.IEnumerable<Connection> TransactionCurrency_Connection
        {
            get { return this.GetRelatedEntities<Connection>("TransactionCurrency_Connection", null); }
            set
            {
                this.OnPropertyChanging("TransactionCurrency_Connection");
                this.SetRelatedEntities<Connection>("TransactionCurrency_Connection", null, value);
                this.OnPropertyChanged("TransactionCurrency_Connection");
            }
        }

        /// <summary>
        /// 1:N transactioncurrency_contact
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("transactioncurrency_contact")]
        public System.Collections.Generic.IEnumerable<Contact> transactioncurrency_contact
        {
            get { return this.GetRelatedEntities<Contact>("transactioncurrency_contact", null); }
            set
            {
                this.OnPropertyChanging("transactioncurrency_contact");
                this.SetRelatedEntities<Contact>("transactioncurrency_contact", null, value);
                this.OnPropertyChanged("transactioncurrency_contact");
            }
        }

        /// <summary>
        /// 1:N transactioncurrency_contract
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("transactioncurrency_contract")]
        public System.Collections.Generic.IEnumerable<Contract> transactioncurrency_contract
        {
            get { return this.GetRelatedEntities<Contract>("transactioncurrency_contract", null); }
            set
            {
                this.OnPropertyChanging("transactioncurrency_contract");
                this.SetRelatedEntities<Contract>("transactioncurrency_contract", null, value);
                this.OnPropertyChanged("transactioncurrency_contract");
            }
        }

        /// <summary>
        /// 1:N transactioncurrency_contractdetail
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("transactioncurrency_contractdetail")]
        public System.Collections.Generic.IEnumerable<ContractDetail> transactioncurrency_contractdetail
        {
            get { return this.GetRelatedEntities<ContractDetail>("transactioncurrency_contractdetail", null); }
            set
            {
                this.OnPropertyChanging("transactioncurrency_contractdetail");
                this.SetRelatedEntities<ContractDetail>("transactioncurrency_contractdetail", null, value);
                this.OnPropertyChanged("transactioncurrency_contractdetail");
            }
        }

        /// <summary>
        /// 1:N TransactionCurrency_ConvertRule
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("TransactionCurrency_ConvertRule")]
        public System.Collections.Generic.IEnumerable<ConvertRule> TransactionCurrency_ConvertRule
        {
            get { return this.GetRelatedEntities<ConvertRule>("TransactionCurrency_ConvertRule", null); }
            set
            {
                this.OnPropertyChanging("TransactionCurrency_ConvertRule");
                this.SetRelatedEntities<ConvertRule>("TransactionCurrency_ConvertRule", null, value);
                this.OnPropertyChanged("TransactionCurrency_ConvertRule");
            }
        }

        /// <summary>
        /// 1:N transactioncurrency_convertruleitem
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("transactioncurrency_convertruleitem")]
        public System.Collections.Generic.IEnumerable<ConvertRuleItem> transactioncurrency_convertruleitem
        {
            get { return this.GetRelatedEntities<ConvertRuleItem>("transactioncurrency_convertruleitem", null); }
            set
            {
                this.OnPropertyChanging("transactioncurrency_convertruleitem");
                this.SetRelatedEntities<ConvertRuleItem>("transactioncurrency_convertruleitem", null, value);
                this.OnPropertyChanged("transactioncurrency_convertruleitem");
            }
        }

        /// <summary>
        /// 1:N TransactionCurrency_CustomerAddress
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("TransactionCurrency_CustomerAddress")]
        public System.Collections.Generic.IEnumerable<CustomerAddress> TransactionCurrency_CustomerAddress
        {
            get { return this.GetRelatedEntities<CustomerAddress>("TransactionCurrency_CustomerAddress", null); }
            set
            {
                this.OnPropertyChanging("TransactionCurrency_CustomerAddress");
                this.SetRelatedEntities<CustomerAddress>("TransactionCurrency_CustomerAddress", null, value);
                this.OnPropertyChanged("TransactionCurrency_CustomerAddress");
            }
        }

        /// <summary>
        /// 1:N transactioncurrency_discount
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("transactioncurrency_discount")]
        public System.Collections.Generic.IEnumerable<Discount> transactioncurrency_discount
        {
            get { return this.GetRelatedEntities<Discount>("transactioncurrency_discount", null); }
            set
            {
                this.OnPropertyChanging("transactioncurrency_discount");
                this.SetRelatedEntities<Discount>("transactioncurrency_discount", null, value);
                this.OnPropertyChanged("transactioncurrency_discount");
            }
        }

        /// <summary>
        /// 1:N transactioncurrency_discounttype
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("transactioncurrency_discounttype")]
        public System.Collections.Generic.IEnumerable<DiscountType> transactioncurrency_discounttype
        {
            get { return this.GetRelatedEntities<DiscountType>("transactioncurrency_discounttype", null); }
            set
            {
                this.OnPropertyChanging("transactioncurrency_discounttype");
                this.SetRelatedEntities<DiscountType>("transactioncurrency_discounttype", null, value);
                this.OnPropertyChanged("transactioncurrency_discounttype");
            }
        }

        /// <summary>
        /// 1:N TransactionCurrency_DuplicateBaseRecord
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("TransactionCurrency_DuplicateBaseRecord")]
        public System.Collections.Generic.IEnumerable<DuplicateRecord> TransactionCurrency_DuplicateBaseRecord
        {
            get { return this.GetRelatedEntities<DuplicateRecord>("TransactionCurrency_DuplicateBaseRecord", null); }
            set
            {
                this.OnPropertyChanging("TransactionCurrency_DuplicateBaseRecord");
                this.SetRelatedEntities<DuplicateRecord>("TransactionCurrency_DuplicateBaseRecord", null, value);
                this.OnPropertyChanged("TransactionCurrency_DuplicateBaseRecord");
            }
        }

        /// <summary>
        /// 1:N TransactionCurrency_DuplicateMatchingRecord
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("TransactionCurrency_DuplicateMatchingRecord")]
        public System.Collections.Generic.IEnumerable<DuplicateRecord> TransactionCurrency_DuplicateMatchingRecord
        {
            get { return this.GetRelatedEntities<DuplicateRecord>("TransactionCurrency_DuplicateMatchingRecord", null); }
            set
            {
                this.OnPropertyChanging("TransactionCurrency_DuplicateMatchingRecord");
                this.SetRelatedEntities<DuplicateRecord>("TransactionCurrency_DuplicateMatchingRecord", null, value);
                this.OnPropertyChanged("TransactionCurrency_DuplicateMatchingRecord");
            }
        }

        /// <summary>
        /// 1:N TransactionCurrency_Dynamicpropertyinsatance
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("TransactionCurrency_Dynamicpropertyinsatance")]
        public System.Collections.Generic.IEnumerable<DynamicPropertyInstance> TransactionCurrency_Dynamicpropertyinsatance
        {
            get { return this.GetRelatedEntities<DynamicPropertyInstance>("TransactionCurrency_Dynamicpropertyinsatance", null); }
            set
            {
                this.OnPropertyChanging("TransactionCurrency_Dynamicpropertyinsatance");
                this.SetRelatedEntities<DynamicPropertyInstance>("TransactionCurrency_Dynamicpropertyinsatance", null, value);
                this.OnPropertyChanged("TransactionCurrency_Dynamicpropertyinsatance");
            }
        }

        /// <summary>
        /// 1:N TransactionCurrency_Email
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("TransactionCurrency_Email")]
        public System.Collections.Generic.IEnumerable<Email> TransactionCurrency_Email
        {
            get { return this.GetRelatedEntities<Email>("TransactionCurrency_Email", null); }
            set
            {
                this.OnPropertyChanging("TransactionCurrency_Email");
                this.SetRelatedEntities<Email>("TransactionCurrency_Email", null, value);
                this.OnPropertyChanged("TransactionCurrency_Email");
            }
        }

        /// <summary>
        /// 1:N TransactionCurrency_Entitlement
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("TransactionCurrency_Entitlement")]
        public System.Collections.Generic.IEnumerable<Entitlement> TransactionCurrency_Entitlement
        {
            get { return this.GetRelatedEntities<Entitlement>("TransactionCurrency_Entitlement", null); }
            set
            {
                this.OnPropertyChanging("TransactionCurrency_Entitlement");
                this.SetRelatedEntities<Entitlement>("TransactionCurrency_Entitlement", null, value);
                this.OnPropertyChanged("TransactionCurrency_Entitlement");
            }
        }

        /// <summary>
        /// 1:N TransactionCurrency_entitlementchannel
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("TransactionCurrency_entitlementchannel")]
        public System.Collections.Generic.IEnumerable<EntitlementChannel> TransactionCurrency_entitlementchannel
        {
            get { return this.GetRelatedEntities<EntitlementChannel>("TransactionCurrency_entitlementchannel", null); }
            set
            {
                this.OnPropertyChanging("TransactionCurrency_entitlementchannel");
                this.SetRelatedEntities<EntitlementChannel>("TransactionCurrency_entitlementchannel", null, value);
                this.OnPropertyChanged("TransactionCurrency_entitlementchannel");
            }
        }

        /// <summary>
        /// 1:N TransactionCurrency_entitlementtemplate
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("TransactionCurrency_entitlementtemplate")]
        public System.Collections.Generic.IEnumerable<EntitlementTemplate> TransactionCurrency_entitlementtemplate
        {
            get { return this.GetRelatedEntities<EntitlementTemplate>("TransactionCurrency_entitlementtemplate", null); }
            set
            {
                this.OnPropertyChanging("TransactionCurrency_entitlementtemplate");
                this.SetRelatedEntities<EntitlementTemplate>("TransactionCurrency_entitlementtemplate", null, value);
                this.OnPropertyChanged("TransactionCurrency_entitlementtemplate");
            }
        }

        /// <summary>
        /// 1:N TransactionCurrency_entitlementtemplatechannel
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("TransactionCurrency_entitlementtemplatechannel")]
        public System.Collections.Generic.IEnumerable<EntitlementTemplateChannel> TransactionCurrency_entitlementtemplatechannel
        {
            get { return this.GetRelatedEntities<EntitlementTemplateChannel>("TransactionCurrency_entitlementtemplatechannel", null); }
            set
            {
                this.OnPropertyChanging("TransactionCurrency_entitlementtemplatechannel");
                this.SetRelatedEntities<EntitlementTemplateChannel>("TransactionCurrency_entitlementtemplatechannel", null, value);
                this.OnPropertyChanged("TransactionCurrency_entitlementtemplatechannel");
            }
        }

        /// <summary>
        /// 1:N TransactionCurrency_Equipment
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("TransactionCurrency_Equipment")]
        public System.Collections.Generic.IEnumerable<Equipment> TransactionCurrency_Equipment
        {
            get { return this.GetRelatedEntities<Equipment>("TransactionCurrency_Equipment", null); }
            set
            {
                this.OnPropertyChanging("TransactionCurrency_Equipment");
                this.SetRelatedEntities<Equipment>("TransactionCurrency_Equipment", null, value);
                this.OnPropertyChanged("TransactionCurrency_Equipment");
            }
        }

        /// <summary>
        /// 1:N TransactionCurrency_Fax
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("TransactionCurrency_Fax")]
        public System.Collections.Generic.IEnumerable<Fax> TransactionCurrency_Fax
        {
            get { return this.GetRelatedEntities<Fax>("TransactionCurrency_Fax", null); }
            set
            {
                this.OnPropertyChanging("TransactionCurrency_Fax");
                this.SetRelatedEntities<Fax>("TransactionCurrency_Fax", null, value);
                this.OnPropertyChanged("TransactionCurrency_Fax");
            }
        }

        /// <summary>
        /// 1:N transactioncurrency_fixedmonthlyfiscalcalendar
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("transactioncurrency_fixedmonthlyfiscalcalendar")]
        public System.Collections.Generic.IEnumerable<FixedMonthlyFiscalCalendar> transactioncurrency_fixedmonthlyfiscalcalendar
        {
            get { return this.GetRelatedEntities<FixedMonthlyFiscalCalendar>("transactioncurrency_fixedmonthlyfiscalcalendar", null); }
            set
            {
                this.OnPropertyChanging("transactioncurrency_fixedmonthlyfiscalcalendar");
                this.SetRelatedEntities<FixedMonthlyFiscalCalendar>("transactioncurrency_fixedmonthlyfiscalcalendar", null, value);
                this.OnPropertyChanged("transactioncurrency_fixedmonthlyfiscalcalendar");
            }
        }

        /// <summary>
        /// 1:N TransactionCurrency_Goal
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("TransactionCurrency_Goal")]
        public System.Collections.Generic.IEnumerable<Goal> TransactionCurrency_Goal
        {
            get { return this.GetRelatedEntities<Goal>("TransactionCurrency_Goal", null); }
            set
            {
                this.OnPropertyChanging("TransactionCurrency_Goal");
                this.SetRelatedEntities<Goal>("TransactionCurrency_Goal", null, value);
                this.OnPropertyChanged("TransactionCurrency_Goal");
            }
        }

        /// <summary>
        /// 1:N TransactionCurrency_Incident
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("TransactionCurrency_Incident")]
        public System.Collections.Generic.IEnumerable<Incident> TransactionCurrency_Incident
        {
            get { return this.GetRelatedEntities<Incident>("TransactionCurrency_Incident", null); }
            set
            {
                this.OnPropertyChanging("TransactionCurrency_Incident");
                this.SetRelatedEntities<Incident>("TransactionCurrency_Incident", null, value);
                this.OnPropertyChanged("TransactionCurrency_Incident");
            }
        }

        /// <summary>
        /// 1:N transactioncurrency_invoice
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("transactioncurrency_invoice")]
        public System.Collections.Generic.IEnumerable<Invoice> transactioncurrency_invoice
        {
            get { return this.GetRelatedEntities<Invoice>("transactioncurrency_invoice", null); }
            set
            {
                this.OnPropertyChanging("transactioncurrency_invoice");
                this.SetRelatedEntities<Invoice>("transactioncurrency_invoice", null, value);
                this.OnPropertyChanged("transactioncurrency_invoice");
            }
        }

        /// <summary>
        /// 1:N transactioncurrency_invoicedetail
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("transactioncurrency_invoicedetail")]
        public System.Collections.Generic.IEnumerable<InvoiceDetail> transactioncurrency_invoicedetail
        {
            get { return this.GetRelatedEntities<InvoiceDetail>("transactioncurrency_invoicedetail", null); }
            set
            {
                this.OnPropertyChanging("transactioncurrency_invoicedetail");
                this.SetRelatedEntities<InvoiceDetail>("transactioncurrency_invoicedetail", null, value);
                this.OnPropertyChanged("transactioncurrency_invoicedetail");
            }
        }

        /// <summary>
        /// 1:N TransactionCurrency_KbArticle
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("TransactionCurrency_KbArticle")]
        public System.Collections.Generic.IEnumerable<KbArticle> TransactionCurrency_KbArticle
        {
            get { return this.GetRelatedEntities<KbArticle>("TransactionCurrency_KbArticle", null); }
            set
            {
                this.OnPropertyChanging("TransactionCurrency_KbArticle");
                this.SetRelatedEntities<KbArticle>("TransactionCurrency_KbArticle", null, value);
                this.OnPropertyChanged("TransactionCurrency_KbArticle");
            }
        }

        /// <summary>
        /// 1:N transactioncurrency_lead
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("transactioncurrency_lead")]
        public System.Collections.Generic.IEnumerable<Lead> transactioncurrency_lead
        {
            get { return this.GetRelatedEntities<Lead>("transactioncurrency_lead", null); }
            set
            {
                this.OnPropertyChanging("transactioncurrency_lead");
                this.SetRelatedEntities<Lead>("transactioncurrency_lead", null, value);
                this.OnPropertyChanged("transactioncurrency_lead");
            }
        }

        /// <summary>
        /// 1:N TransactionCurrency_LeadAddress
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("TransactionCurrency_LeadAddress")]
        public System.Collections.Generic.IEnumerable<LeadAddress> TransactionCurrency_LeadAddress
        {
            get { return this.GetRelatedEntities<LeadAddress>("TransactionCurrency_LeadAddress", null); }
            set
            {
                this.OnPropertyChanging("TransactionCurrency_LeadAddress");
                this.SetRelatedEntities<LeadAddress>("TransactionCurrency_LeadAddress", null, value);
                this.OnPropertyChanged("TransactionCurrency_LeadAddress");
            }
        }

        /// <summary>
        /// 1:N TransactionCurrency_Letter
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("TransactionCurrency_Letter")]
        public System.Collections.Generic.IEnumerable<Letter> TransactionCurrency_Letter
        {
            get { return this.GetRelatedEntities<Letter>("TransactionCurrency_Letter", null); }
            set
            {
                this.OnPropertyChanging("TransactionCurrency_Letter");
                this.SetRelatedEntities<Letter>("TransactionCurrency_Letter", null, value);
                this.OnPropertyChanged("TransactionCurrency_Letter");
            }
        }

        /// <summary>
        /// 1:N transactioncurrency_list
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("transactioncurrency_list")]
        public System.Collections.Generic.IEnumerable<List> transactioncurrency_list
        {
            get { return this.GetRelatedEntities<List>("transactioncurrency_list", null); }
            set
            {
                this.OnPropertyChanging("transactioncurrency_list");
                this.SetRelatedEntities<List>("transactioncurrency_list", null, value);
                this.OnPropertyChanged("transactioncurrency_list");
            }
        }

        /// <summary>
        /// 1:N TransactionCurrency_MailMergeTemplate
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("TransactionCurrency_MailMergeTemplate")]
        public System.Collections.Generic.IEnumerable<MailMergeTemplate> TransactionCurrency_MailMergeTemplate
        {
            get { return this.GetRelatedEntities<MailMergeTemplate>("TransactionCurrency_MailMergeTemplate", null); }
            set
            {
                this.OnPropertyChanging("TransactionCurrency_MailMergeTemplate");
                this.SetRelatedEntities<MailMergeTemplate>("TransactionCurrency_MailMergeTemplate", null, value);
                this.OnPropertyChanged("TransactionCurrency_MailMergeTemplate");
            }
        }

        /// <summary>
        /// 1:N transactioncurrency_monthlyfiscalcalendar
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("transactioncurrency_monthlyfiscalcalendar")]
        public System.Collections.Generic.IEnumerable<MonthlyFiscalCalendar> transactioncurrency_monthlyfiscalcalendar
        {
            get { return this.GetRelatedEntities<MonthlyFiscalCalendar>("transactioncurrency_monthlyfiscalcalendar", null); }
            set
            {
                this.OnPropertyChanging("transactioncurrency_monthlyfiscalcalendar");
                this.SetRelatedEntities<MonthlyFiscalCalendar>("transactioncurrency_monthlyfiscalcalendar", null, value);
                this.OnPropertyChanged("transactioncurrency_monthlyfiscalcalendar");
            }
        }

        /// <summary>
        /// 1:N transactioncurrency_opportunity
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("transactioncurrency_opportunity")]
        public System.Collections.Generic.IEnumerable<Opportunity> transactioncurrency_opportunity
        {
            get { return this.GetRelatedEntities<Opportunity>("transactioncurrency_opportunity", null); }
            set
            {
                this.OnPropertyChanging("transactioncurrency_opportunity");
                this.SetRelatedEntities<Opportunity>("transactioncurrency_opportunity", null, value);
                this.OnPropertyChanged("transactioncurrency_opportunity");
            }
        }

        /// <summary>
        /// 1:N transactioncurrency_opportunityclose
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("transactioncurrency_opportunityclose")]
        public System.Collections.Generic.IEnumerable<OpportunityClose> transactioncurrency_opportunityclose
        {
            get { return this.GetRelatedEntities<OpportunityClose>("transactioncurrency_opportunityclose", null); }
            set
            {
                this.OnPropertyChanging("transactioncurrency_opportunityclose");
                this.SetRelatedEntities<OpportunityClose>("transactioncurrency_opportunityclose", null, value);
                this.OnPropertyChanged("transactioncurrency_opportunityclose");
            }
        }

        /// <summary>
        /// 1:N transactioncurrency_opportunityproduct
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("transactioncurrency_opportunityproduct")]
        public System.Collections.Generic.IEnumerable<OpportunityProduct> transactioncurrency_opportunityproduct
        {
            get { return this.GetRelatedEntities<OpportunityProduct>("transactioncurrency_opportunityproduct", null); }
            set
            {
                this.OnPropertyChanging("transactioncurrency_opportunityproduct");
                this.SetRelatedEntities<OpportunityProduct>("transactioncurrency_opportunityproduct", null, value);
                this.OnPropertyChanged("transactioncurrency_opportunityproduct");
            }
        }

        /// <summary>
        /// 1:N TransactionCurrency_PhoneCall
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("TransactionCurrency_PhoneCall")]
        public System.Collections.Generic.IEnumerable<PhoneCall> TransactionCurrency_PhoneCall
        {
            get { return this.GetRelatedEntities<PhoneCall>("TransactionCurrency_PhoneCall", null); }
            set
            {
                this.OnPropertyChanging("TransactionCurrency_PhoneCall");
                this.SetRelatedEntities<PhoneCall>("TransactionCurrency_PhoneCall", null, value);
                this.OnPropertyChanged("TransactionCurrency_PhoneCall");
            }
        }

        /// <summary>
        /// 1:N transactioncurrency_position
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("transactioncurrency_position")]
        public System.Collections.Generic.IEnumerable<Position> transactioncurrency_position
        {
            get { return this.GetRelatedEntities<Position>("transactioncurrency_position", null); }
            set
            {
                this.OnPropertyChanging("transactioncurrency_position");
                this.SetRelatedEntities<Position>("transactioncurrency_position", null, value);
                this.OnPropertyChanged("transactioncurrency_position");
            }
        }

        /// <summary>
        /// 1:N transactioncurrency_pricelevel
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("transactioncurrency_pricelevel")]
        public System.Collections.Generic.IEnumerable<PriceLevel> transactioncurrency_pricelevel
        {
            get { return this.GetRelatedEntities<PriceLevel>("transactioncurrency_pricelevel", null); }
            set
            {
                this.OnPropertyChanging("transactioncurrency_pricelevel");
                this.SetRelatedEntities<PriceLevel>("transactioncurrency_pricelevel", null, value);
                this.OnPropertyChanged("transactioncurrency_pricelevel");
            }
        }

        /// <summary>
        /// 1:N TransactionCurrency_ProcessSessions
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("TransactionCurrency_ProcessSessions")]
        public System.Collections.Generic.IEnumerable<ProcessSession> TransactionCurrency_ProcessSessions
        {
            get { return this.GetRelatedEntities<ProcessSession>("TransactionCurrency_ProcessSessions", null); }
            set
            {
                this.OnPropertyChanging("TransactionCurrency_ProcessSessions");
                this.SetRelatedEntities<ProcessSession>("TransactionCurrency_ProcessSessions", null, value);
                this.OnPropertyChanged("TransactionCurrency_ProcessSessions");
            }
        }

        /// <summary>
        /// 1:N transactioncurrency_product
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("transactioncurrency_product")]
        public System.Collections.Generic.IEnumerable<Product> transactioncurrency_product
        {
            get { return this.GetRelatedEntities<Product>("transactioncurrency_product", null); }
            set
            {
                this.OnPropertyChanging("transactioncurrency_product");
                this.SetRelatedEntities<Product>("transactioncurrency_product", null, value);
                this.OnPropertyChanged("transactioncurrency_product");
            }
        }

        /// <summary>
        /// 1:N transactioncurrency_ProductAssociation
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("transactioncurrency_ProductAssociation")]
        public System.Collections.Generic.IEnumerable<ProductAssociation> transactioncurrency_ProductAssociation
        {
            get { return this.GetRelatedEntities<ProductAssociation>("transactioncurrency_ProductAssociation", null); }
            set
            {
                this.OnPropertyChanging("transactioncurrency_ProductAssociation");
                this.SetRelatedEntities<ProductAssociation>("transactioncurrency_ProductAssociation", null, value);
                this.OnPropertyChanged("transactioncurrency_ProductAssociation");
            }
        }

        /// <summary>
        /// 1:N transactioncurrency_productpricelevel
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("transactioncurrency_productpricelevel")]
        public System.Collections.Generic.IEnumerable<ProductPriceLevel> transactioncurrency_productpricelevel
        {
            get { return this.GetRelatedEntities<ProductPriceLevel>("transactioncurrency_productpricelevel", null); }
            set
            {
                this.OnPropertyChanging("transactioncurrency_productpricelevel");
                this.SetRelatedEntities<ProductPriceLevel>("transactioncurrency_productpricelevel", null, value);
                this.OnPropertyChanged("transactioncurrency_productpricelevel");
            }
        }

        /// <summary>
        /// 1:N transactioncurrency_ProductSubstitute
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("transactioncurrency_ProductSubstitute")]
        public System.Collections.Generic.IEnumerable<ProductSubstitute> transactioncurrency_ProductSubstitute
        {
            get { return this.GetRelatedEntities<ProductSubstitute>("transactioncurrency_ProductSubstitute", null); }
            set
            {
                this.OnPropertyChanging("transactioncurrency_ProductSubstitute");
                this.SetRelatedEntities<ProductSubstitute>("transactioncurrency_ProductSubstitute", null, value);
                this.OnPropertyChanged("transactioncurrency_ProductSubstitute");
            }
        }

        /// <summary>
        /// 1:N transactioncurrency_quarterlyfiscalcalendar
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("transactioncurrency_quarterlyfiscalcalendar")]
        public System.Collections.Generic.IEnumerable<QuarterlyFiscalCalendar> transactioncurrency_quarterlyfiscalcalendar
        {
            get { return this.GetRelatedEntities<QuarterlyFiscalCalendar>("transactioncurrency_quarterlyfiscalcalendar", null); }
            set
            {
                this.OnPropertyChanging("transactioncurrency_quarterlyfiscalcalendar");
                this.SetRelatedEntities<QuarterlyFiscalCalendar>("transactioncurrency_quarterlyfiscalcalendar", null, value);
                this.OnPropertyChanged("transactioncurrency_quarterlyfiscalcalendar");
            }
        }

        /// <summary>
        /// 1:N TransactionCurrency_Queue
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("TransactionCurrency_Queue")]
        public System.Collections.Generic.IEnumerable<Queue> TransactionCurrency_Queue
        {
            get { return this.GetRelatedEntities<Queue>("TransactionCurrency_Queue", null); }
            set
            {
                this.OnPropertyChanging("TransactionCurrency_Queue");
                this.SetRelatedEntities<Queue>("TransactionCurrency_Queue", null, value);
                this.OnPropertyChanged("TransactionCurrency_Queue");
            }
        }

        /// <summary>
        /// 1:N TransactionCurrency_QueueItem
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("TransactionCurrency_QueueItem")]
        public System.Collections.Generic.IEnumerable<QueueItem> TransactionCurrency_QueueItem
        {
            get { return this.GetRelatedEntities<QueueItem>("TransactionCurrency_QueueItem", null); }
            set
            {
                this.OnPropertyChanging("TransactionCurrency_QueueItem");
                this.SetRelatedEntities<QueueItem>("TransactionCurrency_QueueItem", null, value);
                this.OnPropertyChanged("TransactionCurrency_QueueItem");
            }
        }

        /// <summary>
        /// 1:N transactioncurrency_quote
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("transactioncurrency_quote")]
        public System.Collections.Generic.IEnumerable<Quote> transactioncurrency_quote
        {
            get { return this.GetRelatedEntities<Quote>("transactioncurrency_quote", null); }
            set
            {
                this.OnPropertyChanging("transactioncurrency_quote");
                this.SetRelatedEntities<Quote>("transactioncurrency_quote", null, value);
                this.OnPropertyChanged("transactioncurrency_quote");
            }
        }

        /// <summary>
        /// 1:N transactioncurrency_quotedetail
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("transactioncurrency_quotedetail")]
        public System.Collections.Generic.IEnumerable<QuoteDetail> transactioncurrency_quotedetail
        {
            get { return this.GetRelatedEntities<QuoteDetail>("transactioncurrency_quotedetail", null); }
            set
            {
                this.OnPropertyChanging("transactioncurrency_quotedetail");
                this.SetRelatedEntities<QuoteDetail>("transactioncurrency_quotedetail", null, value);
                this.OnPropertyChanged("transactioncurrency_quotedetail");
            }
        }

        /// <summary>
        /// 1:N TransactionCurrency_RecurringAppointmentMaster
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("TransactionCurrency_RecurringAppointmentMaster")]
        public System.Collections.Generic.IEnumerable<RecurringAppointmentMaster> TransactionCurrency_RecurringAppointmentMaster
        {
            get { return this.GetRelatedEntities<RecurringAppointmentMaster>("TransactionCurrency_RecurringAppointmentMaster", null); }
            set
            {
                this.OnPropertyChanging("TransactionCurrency_RecurringAppointmentMaster");
                this.SetRelatedEntities<RecurringAppointmentMaster>("TransactionCurrency_RecurringAppointmentMaster", null, value);
                this.OnPropertyChanged("TransactionCurrency_RecurringAppointmentMaster");
            }
        }

        /// <summary>
        /// 1:N TransactionCurrency_ReportCategory
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("TransactionCurrency_ReportCategory")]
        public System.Collections.Generic.IEnumerable<ReportCategory> TransactionCurrency_ReportCategory
        {
            get { return this.GetRelatedEntities<ReportCategory>("TransactionCurrency_ReportCategory", null); }
            set
            {
                this.OnPropertyChanging("TransactionCurrency_ReportCategory");
                this.SetRelatedEntities<ReportCategory>("TransactionCurrency_ReportCategory", null, value);
                this.OnPropertyChanged("TransactionCurrency_ReportCategory");
            }
        }

        /// <summary>
        /// 1:N TransactionCurrency_Routingrule
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("TransactionCurrency_Routingrule")]
        public System.Collections.Generic.IEnumerable<RoutingRule> TransactionCurrency_Routingrule
        {
            get { return this.GetRelatedEntities<RoutingRule>("TransactionCurrency_Routingrule", null); }
            set
            {
                this.OnPropertyChanging("TransactionCurrency_Routingrule");
                this.SetRelatedEntities<RoutingRule>("TransactionCurrency_Routingrule", null, value);
                this.OnPropertyChanged("TransactionCurrency_Routingrule");
            }
        }

        /// <summary>
        /// 1:N TransactionCurrency_routingruleitem
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("TransactionCurrency_routingruleitem")]
        public System.Collections.Generic.IEnumerable<RoutingRuleItem> TransactionCurrency_routingruleitem
        {
            get { return this.GetRelatedEntities<RoutingRuleItem>("TransactionCurrency_routingruleitem", null); }
            set
            {
                this.OnPropertyChanging("TransactionCurrency_routingruleitem");
                this.SetRelatedEntities<RoutingRuleItem>("TransactionCurrency_routingruleitem", null, value);
                this.OnPropertyChanged("TransactionCurrency_routingruleitem");
            }
        }

        /// <summary>
        /// 1:N TransactionCurrency_SalesLiterature
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("TransactionCurrency_SalesLiterature")]
        public System.Collections.Generic.IEnumerable<SalesLiterature> TransactionCurrency_SalesLiterature
        {
            get { return this.GetRelatedEntities<SalesLiterature>("TransactionCurrency_SalesLiterature", null); }
            set
            {
                this.OnPropertyChanging("TransactionCurrency_SalesLiterature");
                this.SetRelatedEntities<SalesLiterature>("TransactionCurrency_SalesLiterature", null, value);
                this.OnPropertyChanged("TransactionCurrency_SalesLiterature");
            }
        }

        /// <summary>
        /// 1:N transactioncurrency_salesorder
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("transactioncurrency_salesorder")]
        public System.Collections.Generic.IEnumerable<SalesOrder> transactioncurrency_salesorder
        {
            get { return this.GetRelatedEntities<SalesOrder>("transactioncurrency_salesorder", null); }
            set
            {
                this.OnPropertyChanging("transactioncurrency_salesorder");
                this.SetRelatedEntities<SalesOrder>("transactioncurrency_salesorder", null, value);
                this.OnPropertyChanged("transactioncurrency_salesorder");
            }
        }

        /// <summary>
        /// 1:N transactioncurrency_salesorderdetail
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("transactioncurrency_salesorderdetail")]
        public System.Collections.Generic.IEnumerable<SalesOrderDetail> transactioncurrency_salesorderdetail
        {
            get { return this.GetRelatedEntities<SalesOrderDetail>("transactioncurrency_salesorderdetail", null); }
            set
            {
                this.OnPropertyChanging("transactioncurrency_salesorderdetail");
                this.SetRelatedEntities<SalesOrderDetail>("transactioncurrency_salesorderdetail", null, value);
                this.OnPropertyChanged("transactioncurrency_salesorderdetail");
            }
        }

        /// <summary>
        /// 1:N transactioncurrency_semiannualfiscalcalendar
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("transactioncurrency_semiannualfiscalcalendar")]
        public System.Collections.Generic.IEnumerable<SemiAnnualFiscalCalendar> transactioncurrency_semiannualfiscalcalendar
        {
            get { return this.GetRelatedEntities<SemiAnnualFiscalCalendar>("transactioncurrency_semiannualfiscalcalendar", null); }
            set
            {
                this.OnPropertyChanging("transactioncurrency_semiannualfiscalcalendar");
                this.SetRelatedEntities<SemiAnnualFiscalCalendar>("transactioncurrency_semiannualfiscalcalendar", null, value);
                this.OnPropertyChanged("transactioncurrency_semiannualfiscalcalendar");
            }
        }

        /// <summary>
        /// 1:N TransactionCurrency_ServiceAppointment
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("TransactionCurrency_ServiceAppointment")]
        public System.Collections.Generic.IEnumerable<ServiceAppointment> TransactionCurrency_ServiceAppointment
        {
            get { return this.GetRelatedEntities<ServiceAppointment>("TransactionCurrency_ServiceAppointment", null); }
            set
            {
                this.OnPropertyChanging("TransactionCurrency_ServiceAppointment");
                this.SetRelatedEntities<ServiceAppointment>("TransactionCurrency_ServiceAppointment", null, value);
                this.OnPropertyChanged("TransactionCurrency_ServiceAppointment");
            }
        }

        /// <summary>
        /// 1:N TransactionCurrency_SharePointDocument
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("TransactionCurrency_SharePointDocument")]
        public System.Collections.Generic.IEnumerable<SharePointDocument> TransactionCurrency_SharePointDocument
        {
            get { return this.GetRelatedEntities<SharePointDocument>("TransactionCurrency_SharePointDocument", null); }
            set
            {
                this.OnPropertyChanging("TransactionCurrency_SharePointDocument");
                this.SetRelatedEntities<SharePointDocument>("TransactionCurrency_SharePointDocument", null, value);
                this.OnPropertyChanged("TransactionCurrency_SharePointDocument");
            }
        }

        /// <summary>
        /// 1:N TransactionCurrency_SharePointDocumentLocation
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("TransactionCurrency_SharePointDocumentLocation")]
        public System.Collections.Generic.IEnumerable<SharePointDocumentLocation> TransactionCurrency_SharePointDocumentLocation
        {
            get { return this.GetRelatedEntities<SharePointDocumentLocation>("TransactionCurrency_SharePointDocumentLocation", null); }
            set
            {
                this.OnPropertyChanging("TransactionCurrency_SharePointDocumentLocation");
                this.SetRelatedEntities<SharePointDocumentLocation>("TransactionCurrency_SharePointDocumentLocation", null, value);
                this.OnPropertyChanged("TransactionCurrency_SharePointDocumentLocation");
            }
        }

        /// <summary>
        /// 1:N TransactionCurrency_SharePointSite
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("TransactionCurrency_SharePointSite")]
        public System.Collections.Generic.IEnumerable<SharePointSite> TransactionCurrency_SharePointSite
        {
            get { return this.GetRelatedEntities<SharePointSite>("TransactionCurrency_SharePointSite", null); }
            set
            {
                this.OnPropertyChanging("TransactionCurrency_SharePointSite");
                this.SetRelatedEntities<SharePointSite>("TransactionCurrency_SharePointSite", null, value);
                this.OnPropertyChanged("TransactionCurrency_SharePointSite");
            }
        }

        /// <summary>
        /// 1:N TransactionCurrency_SLA
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("TransactionCurrency_SLA")]
        public System.Collections.Generic.IEnumerable<SLA> TransactionCurrency_SLA
        {
            get { return this.GetRelatedEntities<SLA>("TransactionCurrency_SLA", null); }
            set
            {
                this.OnPropertyChanging("TransactionCurrency_SLA");
                this.SetRelatedEntities<SLA>("TransactionCurrency_SLA", null, value);
                this.OnPropertyChanged("TransactionCurrency_SLA");
            }
        }

        /// <summary>
        /// 1:N TransactionCurrency_SLAItem
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("TransactionCurrency_SLAItem")]
        public System.Collections.Generic.IEnumerable<SLAItem> TransactionCurrency_SLAItem
        {
            get { return this.GetRelatedEntities<SLAItem>("TransactionCurrency_SLAItem", null); }
            set
            {
                this.OnPropertyChanging("TransactionCurrency_SLAItem");
                this.SetRelatedEntities<SLAItem>("TransactionCurrency_SLAItem", null, value);
                this.OnPropertyChanged("TransactionCurrency_SLAItem");
            }
        }

        /// <summary>
        /// 1:N TransactionCurrency_slakpiinstance
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("TransactionCurrency_slakpiinstance")]
        public System.Collections.Generic.IEnumerable<SLAKPIInstance> TransactionCurrency_slakpiinstance
        {
            get { return this.GetRelatedEntities<SLAKPIInstance>("TransactionCurrency_slakpiinstance", null); }
            set
            {
                this.OnPropertyChanging("TransactionCurrency_slakpiinstance");
                this.SetRelatedEntities<SLAKPIInstance>("TransactionCurrency_slakpiinstance", null, value);
                this.OnPropertyChanged("TransactionCurrency_slakpiinstance");
            }
        }

        /// <summary>
        /// 1:N transactioncurrency_socialactivity
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("transactioncurrency_socialactivity")]
        public System.Collections.Generic.IEnumerable<SocialActivity> transactioncurrency_socialactivity
        {
            get { return this.GetRelatedEntities<SocialActivity>("transactioncurrency_socialactivity", null); }
            set
            {
                this.OnPropertyChanging("transactioncurrency_socialactivity");
                this.SetRelatedEntities<SocialActivity>("transactioncurrency_socialactivity", null, value);
                this.OnPropertyChanged("transactioncurrency_socialactivity");
            }
        }

        /// <summary>
        /// 1:N transactioncurrency_SocialProfile
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("transactioncurrency_SocialProfile")]
        public System.Collections.Generic.IEnumerable<SocialProfile> transactioncurrency_SocialProfile
        {
            get { return this.GetRelatedEntities<SocialProfile>("transactioncurrency_SocialProfile", null); }
            set
            {
                this.OnPropertyChanging("transactioncurrency_SocialProfile");
                this.SetRelatedEntities<SocialProfile>("transactioncurrency_SocialProfile", null, value);
                this.OnPropertyChanged("transactioncurrency_SocialProfile");
            }
        }

        /// <summary>
        /// 1:N TransactionCurrency_SystemUser
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("TransactionCurrency_SystemUser")]
        public System.Collections.Generic.IEnumerable<SystemUser> TransactionCurrency_SystemUser
        {
            get { return this.GetRelatedEntities<SystemUser>("TransactionCurrency_SystemUser", null); }
            set
            {
                this.OnPropertyChanging("TransactionCurrency_SystemUser");
                this.SetRelatedEntities<SystemUser>("TransactionCurrency_SystemUser", null, value);
                this.OnPropertyChanged("TransactionCurrency_SystemUser");
            }
        }

        /// <summary>
        /// 1:N TransactionCurrency_Task
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("TransactionCurrency_Task")]
        public System.Collections.Generic.IEnumerable<Task> TransactionCurrency_Task
        {
            get { return this.GetRelatedEntities<Task>("TransactionCurrency_Task", null); }
            set
            {
                this.OnPropertyChanging("TransactionCurrency_Task");
                this.SetRelatedEntities<Task>("TransactionCurrency_Task", null, value);
                this.OnPropertyChanged("TransactionCurrency_Task");
            }
        }

        /// <summary>
        /// 1:N TransactionCurrency_Team
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("TransactionCurrency_Team")]
        public System.Collections.Generic.IEnumerable<Team> TransactionCurrency_Team
        {
            get { return this.GetRelatedEntities<Team>("TransactionCurrency_Team", null); }
            set
            {
                this.OnPropertyChanging("TransactionCurrency_Team");
                this.SetRelatedEntities<Team>("TransactionCurrency_Team", null, value);
                this.OnPropertyChanged("TransactionCurrency_Team");
            }
        }

        /// <summary>
        /// 1:N TransactionCurrency_Territory
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("TransactionCurrency_Territory")]
        public System.Collections.Generic.IEnumerable<Territory> TransactionCurrency_Territory
        {
            get { return this.GetRelatedEntities<Territory>("TransactionCurrency_Territory", null); }
            set
            {
                this.OnPropertyChanging("TransactionCurrency_Territory");
                this.SetRelatedEntities<Territory>("TransactionCurrency_Territory", null, value);
                this.OnPropertyChanged("TransactionCurrency_Territory");
            }
        }

        /// <summary>
        /// 1:N transactioncurrency_usersettings
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("transactioncurrency_usersettings")]
        public System.Collections.Generic.IEnumerable<UserSettings> transactioncurrency_usersettings
        {
            get { return this.GetRelatedEntities<UserSettings>("transactioncurrency_usersettings", null); }
            set
            {
                this.OnPropertyChanging("transactioncurrency_usersettings");
                this.SetRelatedEntities<UserSettings>("transactioncurrency_usersettings", null, value);
                this.OnPropertyChanged("transactioncurrency_usersettings");
            }
        }

        /// <summary>
        /// 1:N userentityinstancedata_transactioncurrency
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_transactioncurrency")]
        public System.Collections.Generic.IEnumerable<UserEntityInstanceData> userentityinstancedata_transactioncurrency
        {
            get { return this.GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_transactioncurrency", null); }
            set
            {
                this.OnPropertyChanging("userentityinstancedata_transactioncurrency");
                this.SetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_transactioncurrency", null, value);
                this.OnPropertyChanged("userentityinstancedata_transactioncurrency");
            }
        }

        /// <summary>
        /// N:1 lk_transactioncurrency_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_transactioncurrency_createdonbehalfby")]
        public SystemUser lk_transactioncurrency_createdonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_transactioncurrency_createdonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_transactioncurrency_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_transactioncurrency_modifiedonbehalfby")]
        public SystemUser lk_transactioncurrency_modifiedonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_transactioncurrency_modifiedonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_transactioncurrencybase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_transactioncurrencybase_createdby")]
        public SystemUser lk_transactioncurrencybase_createdby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_transactioncurrencybase_createdby", null); }
        }

        /// <summary>
        /// N:1 lk_transactioncurrencybase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_transactioncurrencybase_modifiedby")]
        public SystemUser lk_transactioncurrencybase_modifiedby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_transactioncurrencybase_modifiedby", null); }
        }

        /// <summary>
        /// N:1 organization_transactioncurrencies
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_transactioncurrencies")]
        public Organization organization_transactioncurrencies
        {
            get { return this.GetRelatedEntity<Organization>("organization_transactioncurrencies", null); }
        }
    }
}