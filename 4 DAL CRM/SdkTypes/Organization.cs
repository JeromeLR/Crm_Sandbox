namespace __4_DAL_CRM
{
    /// <summary>
    /// Top level of the Microsoft Dynamics CRM business hierarchy. The organization can be a specific business, holding company, or corporation.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("organization")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class Organization : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public Organization() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "organization";

        public const int EntityTypeCode = 1019;

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
        /// Unique identifier of the template to be used for acknowledgement when a user unsubscribes.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("acknowledgementtemplateid")]
        public Microsoft.Xrm.Sdk.EntityReference AcknowledgementTemplateId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("acknowledgementtemplateid"); }
            set
            {
                this.OnPropertyChanging("AcknowledgementTemplateId");
                this.SetAttributeValue("acknowledgementtemplateid", value);
                this.OnPropertyChanged("AcknowledgementTemplateId");
            }
        }

        /// <summary>
        /// Indicates whether background address book synchronization in Microsoft Office Outlook is allowed.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("allowaddressbooksyncs")]
        public System.Nullable<bool> AllowAddressBookSyncs
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("allowaddressbooksyncs"); }
            set
            {
                this.OnPropertyChanging("AllowAddressBookSyncs");
                this.SetAttributeValue("allowaddressbooksyncs", value);
                this.OnPropertyChanged("AllowAddressBookSyncs");
            }
        }

        /// <summary>
        /// Indicates whether automatic response creation is allowed.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("allowautoresponsecreation")]
        public System.Nullable<bool> AllowAutoResponseCreation
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("allowautoresponsecreation"); }
            set
            {
                this.OnPropertyChanging("AllowAutoResponseCreation");
                this.SetAttributeValue("allowautoresponsecreation", value);
                this.OnPropertyChanged("AllowAutoResponseCreation");
            }
        }

        /// <summary>
        /// Indicates whether automatic unsubscribe is allowed.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("allowautounsubscribe")]
        public System.Nullable<bool> AllowAutoUnsubscribe
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("allowautounsubscribe"); }
            set
            {
                this.OnPropertyChanging("AllowAutoUnsubscribe");
                this.SetAttributeValue("allowautounsubscribe", value);
                this.OnPropertyChanged("AllowAutoUnsubscribe");
            }
        }

        /// <summary>
        /// Indicates whether automatic unsubscribe acknowledgement email is allowed to send.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("allowautounsubscribeacknowledgement")]
        public System.Nullable<bool> AllowAutoUnsubscribeAcknowledgement
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("allowautounsubscribeacknowledgement"); }
            set
            {
                this.OnPropertyChanging("AllowAutoUnsubscribeAcknowledgement");
                this.SetAttributeValue("allowautounsubscribeacknowledgement", value);
                this.OnPropertyChanged("AllowAutoUnsubscribeAcknowledgement");
            }
        }

        /// <summary>
        /// Indicates whether Outlook Client message bar advertisement is allowed.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("allowclientmessagebarad")]
        public System.Nullable<bool> AllowClientMessageBarAd
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("allowclientmessagebarad"); }
            set
            {
                this.OnPropertyChanging("AllowClientMessageBarAd");
                this.SetAttributeValue("allowclientmessagebarad", value);
                this.OnPropertyChanged("AllowClientMessageBarAd");
            }
        }

        /// <summary>
        /// Indicates whether auditing of changes to entity is allowed when no attributes have changed.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("allowentityonlyaudit")]
        public System.Nullable<bool> AllowEntityOnlyAudit
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("allowentityonlyaudit"); }
            set
            {
                this.OnPropertyChanging("AllowEntityOnlyAudit");
                this.SetAttributeValue("allowentityonlyaudit", value);
                this.OnPropertyChanged("AllowEntityOnlyAudit");
            }
        }

        /// <summary>
        /// Indicates whether marketing emails execution is allowed.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("allowmarketingemailexecution")]
        public System.Nullable<bool> AllowMarketingEmailExecution
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("allowmarketingemailexecution"); }
            set
            {
                this.OnPropertyChanging("AllowMarketingEmailExecution");
                this.SetAttributeValue("allowmarketingemailexecution", value);
                this.OnPropertyChanged("AllowMarketingEmailExecution");
            }
        }

        /// <summary>
        /// Indicates whether background offline synchronization in Microsoft Office Outlook is allowed.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("allowofflinescheduledsyncs")]
        public System.Nullable<bool> AllowOfflineScheduledSyncs
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("allowofflinescheduledsyncs"); }
            set
            {
                this.OnPropertyChanging("AllowOfflineScheduledSyncs");
                this.SetAttributeValue("allowofflinescheduledsyncs", value);
                this.OnPropertyChanged("AllowOfflineScheduledSyncs");
            }
        }

        /// <summary>
        /// Indicates whether scheduled synchronizations to Outlook are allowed.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("allowoutlookscheduledsyncs")]
        public System.Nullable<bool> AllowOutlookScheduledSyncs
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("allowoutlookscheduledsyncs"); }
            set
            {
                this.OnPropertyChanging("AllowOutlookScheduledSyncs");
                this.SetAttributeValue("allowoutlookscheduledsyncs", value);
                this.OnPropertyChanged("AllowOutlookScheduledSyncs");
            }
        }

        /// <summary>
        /// Indicates whether users are allowed to send email to unresolved parties (parties must still have an email address).
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("allowunresolvedpartiesonemailsend")]
        public System.Nullable<bool> AllowUnresolvedPartiesOnEmailSend
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("allowunresolvedpartiesonemailsend"); }
            set
            {
                this.OnPropertyChanging("AllowUnresolvedPartiesOnEmailSend");
                this.SetAttributeValue("allowunresolvedpartiesonemailsend", value);
                this.OnPropertyChanged("AllowUnresolvedPartiesOnEmailSend");
            }
        }

        /// <summary>
        /// Indicates whether individuals can select their form mode preference in their personal options.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("allowuserformmodepreference")]
        public System.Nullable<bool> AllowUserFormModePreference
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("allowuserformmodepreference"); }
            set
            {
                this.OnPropertyChanging("AllowUserFormModePreference");
                this.SetAttributeValue("allowuserformmodepreference", value);
                this.OnPropertyChanged("AllowUserFormModePreference");
            }
        }

        /// <summary>
        /// Indicates whether the showing tablet application notification bars in a browser is allowed.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("allowusersseeappdownloadmessage")]
        public System.Nullable<bool> AllowUsersSeeAppdownloadMessage
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("allowusersseeappdownloadmessage"); }
            set
            {
                this.OnPropertyChanging("AllowUsersSeeAppdownloadMessage");
                this.SetAttributeValue("allowusersseeappdownloadmessage", value);
                this.OnPropertyChanged("AllowUsersSeeAppdownloadMessage");
            }
        }

        /// <summary>
        /// Indicates whether Web-based export of grids to Microsoft Office Excel is allowed.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("allowwebexcelexport")]
        public System.Nullable<bool> AllowWebExcelExport
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("allowwebexcelexport"); }
            set
            {
                this.OnPropertyChanging("AllowWebExcelExport");
                this.SetAttributeValue("allowwebexcelexport", value);
                this.OnPropertyChanged("AllowWebExcelExport");
            }
        }

        /// <summary>
        /// AM designator to use throughout Microsoft Dynamics CRM.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("amdesignator")]
        public string AMDesignator
        {
            get { return this.GetAttributeValue<string>("amdesignator"); }
            set
            {
                this.OnPropertyChanging("AMDesignator");
                this.SetAttributeValue("amdesignator", value);
                this.OnPropertyChanged("AMDesignator");
            }
        }

        /// <summary>
        /// Unique identifier of the base currency of the organization.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("basecurrencyid")]
        public Microsoft.Xrm.Sdk.EntityReference BaseCurrencyId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("basecurrencyid"); }
            set
            {
                this.OnPropertyChanging("BaseCurrencyId");
                this.SetAttributeValue("basecurrencyid", value);
                this.OnPropertyChanged("BaseCurrencyId");
            }
        }

        /// <summary>
        /// Number of decimal places that can be used for the base currency.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("basecurrencyprecision")]
        public System.Nullable<int> BaseCurrencyPrecision
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("basecurrencyprecision"); }
        }

        /// <summary>
        /// Symbol used for the base currency.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("basecurrencysymbol")]
        public string BaseCurrencySymbol
        {
            get { return this.GetAttributeValue<string>("basecurrencysymbol"); }
        }

        /// <summary>
        /// Api Key to be used in requests to Bing Maps services.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("bingmapsapikey")]
        public string BingMapsApiKey
        {
            get { return this.GetAttributeValue<string>("bingmapsapikey"); }
            set
            {
                this.OnPropertyChanging("BingMapsApiKey");
                this.SetAttributeValue("bingmapsapikey", value);
                this.OnPropertyChanged("BingMapsApiKey");
            }
        }

        /// <summary>
        /// Prevent upload or download of certain attachment types that are considered dangerous.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("blockedattachments")]
        public string BlockedAttachments
        {
            get { return this.GetAttributeValue<string>("blockedattachments"); }
            set
            {
                this.OnPropertyChanging("BlockedAttachments");
                this.SetAttributeValue("blockedattachments", value);
                this.OnPropertyChanged("BlockedAttachments");
            }
        }

        /// <summary>
        /// Prefix used for bulk operation numbering.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("bulkoperationprefix")]
        public string BulkOperationPrefix
        {
            get { return this.GetAttributeValue<string>("bulkoperationprefix"); }
            set
            {
                this.OnPropertyChanging("BulkOperationPrefix");
                this.SetAttributeValue("bulkoperationprefix", value);
                this.OnPropertyChanged("BulkOperationPrefix");
            }
        }

        /// <summary>
        /// Unique identifier of the business closure calendar of organization.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("businessclosurecalendarid")]
        public System.Nullable<System.Guid> BusinessClosureCalendarId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("businessclosurecalendarid"); }
            set
            {
                this.OnPropertyChanging("BusinessClosureCalendarId");
                this.SetAttributeValue("businessclosurecalendarid", value);
                this.OnPropertyChanged("BusinessClosureCalendarId");
            }
        }

        /// <summary>
        /// Calendar type for the system. Set to Gregorian US by default.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("calendartype")]
        public System.Nullable<int> CalendarType
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("calendartype"); }
            set
            {
                this.OnPropertyChanging("CalendarType");
                this.SetAttributeValue("calendartype", value);
                this.OnPropertyChanged("CalendarType");
            }
        }

        /// <summary>
        /// Prefix used for campaign numbering.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("campaignprefix")]
        public string CampaignPrefix
        {
            get { return this.GetAttributeValue<string>("campaignprefix"); }
            set
            {
                this.OnPropertyChanging("CampaignPrefix");
                this.SetAttributeValue("campaignprefix", value);
                this.OnPropertyChanged("CampaignPrefix");
            }
        }

        /// <summary>
        /// Flag to cascade Update on incident.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("cascadestatusupdate")]
        public System.Nullable<bool> CascadeStatusUpdate
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("cascadestatusupdate"); }
            set
            {
                this.OnPropertyChanging("CascadeStatusUpdate");
                this.SetAttributeValue("cascadestatusupdate", value);
                this.OnPropertyChanged("CascadeStatusUpdate");
            }
        }

        /// <summary>
        /// Prefix to use for all cases throughout Microsoft Dynamics CRM.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("caseprefix")]
        public string CasePrefix
        {
            get { return this.GetAttributeValue<string>("caseprefix"); }
            set
            {
                this.OnPropertyChanging("CasePrefix");
                this.SetAttributeValue("caseprefix", value);
                this.OnPropertyChanged("CasePrefix");
            }
        }

        /// <summary>
        /// Prefix to use for all contracts throughout Microsoft Dynamics CRM.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("contractprefix")]
        public string ContractPrefix
        {
            get { return this.GetAttributeValue<string>("contractprefix"); }
            set
            {
                this.OnPropertyChanging("ContractPrefix");
                this.SetAttributeValue("contractprefix", value);
                this.OnPropertyChanged("ContractPrefix");
            }
        }

        /// <summary>
        /// Unique identifier of the user who created the organization.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby"); }
        }

        /// <summary>
        /// Date and time when the organization was created.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
        public System.Nullable<System.DateTime> CreatedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who created the organization.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        /// Enable Initial state of newly created products to be Active instead of Draft
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createproductswithoutparentinactivestate")]
        public System.Nullable<bool> CreateProductsWithoutParentInActiveState
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("createproductswithoutparentinactivestate"); }
            set
            {
                this.OnPropertyChanging("CreateProductsWithoutParentInActiveState");
                this.SetAttributeValue("createproductswithoutparentinactivestate", value);
                this.OnPropertyChanged("CreateProductsWithoutParentInActiveState");
            }
        }

        /// <summary>
        /// Number of decimal places that can be used for currency.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("currencydecimalprecision")]
        public System.Nullable<int> CurrencyDecimalPrecision
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("currencydecimalprecision"); }
            set
            {
                this.OnPropertyChanging("CurrencyDecimalPrecision");
                this.SetAttributeValue("currencydecimalprecision", value);
                this.OnPropertyChanged("CurrencyDecimalPrecision");
            }
        }

        /// <summary>
        /// Indicates whether to display money fields with currency code or currency symbol.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("currencydisplayoption")]
        public Microsoft.Xrm.Sdk.OptionSetValue CurrencyDisplayOption
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("currencydisplayoption"); }
            set
            {
                this.OnPropertyChanging("CurrencyDisplayOption");
                this.SetAttributeValue("currencydisplayoption", value);
                this.OnPropertyChanged("CurrencyDisplayOption");
            }
        }

        /// <summary>
        /// Information about how currency symbols are placed throughout Microsoft Dynamics CRM.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("currencyformatcode")]
        public Microsoft.Xrm.Sdk.OptionSetValue CurrencyFormatCode
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("currencyformatcode"); }
            set
            {
                this.OnPropertyChanging("CurrencyFormatCode");
                this.SetAttributeValue("currencyformatcode", value);
                this.OnPropertyChanged("CurrencyFormatCode");
            }
        }

        /// <summary>
        /// Symbol used for currency throughout Microsoft Dynamics CRM.
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
        /// Current bulk operation number.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("currentbulkoperationnumber")]
        public System.Nullable<int> CurrentBulkOperationNumber
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("currentbulkoperationnumber"); }
            set
            {
                this.OnPropertyChanging("CurrentBulkOperationNumber");
                this.SetAttributeValue("currentbulkoperationnumber", value);
                this.OnPropertyChanged("CurrentBulkOperationNumber");
            }
        }

        /// <summary>
        /// Current campaign number.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("currentcampaignnumber")]
        public System.Nullable<int> CurrentCampaignNumber
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("currentcampaignnumber"); }
            set
            {
                this.OnPropertyChanging("CurrentCampaignNumber");
                this.SetAttributeValue("currentcampaignnumber", value);
                this.OnPropertyChanged("CurrentCampaignNumber");
            }
        }

        /// <summary>
        /// First case number to use.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("currentcasenumber")]
        public System.Nullable<int> CurrentCaseNumber
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("currentcasenumber"); }
            set
            {
                this.OnPropertyChanging("CurrentCaseNumber");
                this.SetAttributeValue("currentcasenumber", value);
                this.OnPropertyChanged("CurrentCaseNumber");
            }
        }

        /// <summary>
        /// First contract number to use.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("currentcontractnumber")]
        public System.Nullable<int> CurrentContractNumber
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("currentcontractnumber"); }
            set
            {
                this.OnPropertyChanging("CurrentContractNumber");
                this.SetAttributeValue("currentcontractnumber", value);
                this.OnPropertyChanged("CurrentContractNumber");
            }
        }

        /// <summary>
        /// Import sequence to use.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("currentimportsequencenumber")]
        public System.Nullable<int> CurrentImportSequenceNumber
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("currentimportsequencenumber"); }
        }

        /// <summary>
        /// First invoice number to use.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("currentinvoicenumber")]
        public System.Nullable<int> CurrentInvoiceNumber
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("currentinvoicenumber"); }
            set
            {
                this.OnPropertyChanging("CurrentInvoiceNumber");
                this.SetAttributeValue("currentinvoicenumber", value);
                this.OnPropertyChanged("CurrentInvoiceNumber");
            }
        }

        /// <summary>
        /// First article number to use.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("currentkbnumber")]
        public System.Nullable<int> CurrentKbNumber
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("currentkbnumber"); }
            set
            {
                this.OnPropertyChanging("CurrentKbNumber");
                this.SetAttributeValue("currentkbnumber", value);
                this.OnPropertyChanged("CurrentKbNumber");
            }
        }

        /// <summary>
        /// First order number to use.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("currentordernumber")]
        public System.Nullable<int> CurrentOrderNumber
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("currentordernumber"); }
            set
            {
                this.OnPropertyChanging("CurrentOrderNumber");
                this.SetAttributeValue("currentordernumber", value);
                this.OnPropertyChanged("CurrentOrderNumber");
            }
        }

        /// <summary>
        /// First parsed table number to use.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("currentparsedtablenumber")]
        public System.Nullable<int> CurrentParsedTableNumber
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("currentparsedtablenumber"); }
        }

        /// <summary>
        /// First quote number to use.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("currentquotenumber")]
        public System.Nullable<int> CurrentQuoteNumber
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("currentquotenumber"); }
            set
            {
                this.OnPropertyChanging("CurrentQuoteNumber");
                this.SetAttributeValue("currentquotenumber", value);
                this.OnPropertyChanged("CurrentQuoteNumber");
            }
        }

        /// <summary>
        /// Information about how the date is displayed throughout Microsoft CRM.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("dateformatcode")]
        public Microsoft.Xrm.Sdk.OptionSetValue DateFormatCode
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("dateformatcode"); }
            set
            {
                this.OnPropertyChanging("DateFormatCode");
                this.SetAttributeValue("dateformatcode", value);
                this.OnPropertyChanged("DateFormatCode");
            }
        }

        /// <summary>
        /// String showing how the date is displayed throughout Microsoft CRM.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("dateformatstring")]
        public string DateFormatString
        {
            get { return this.GetAttributeValue<string>("dateformatstring"); }
            set
            {
                this.OnPropertyChanging("DateFormatString");
                this.SetAttributeValue("dateformatstring", value);
                this.OnPropertyChanged("DateFormatString");
            }
        }

        /// <summary>
        /// Character used to separate the month, the day, and the year in dates throughout Microsoft Dynamics CRM.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("dateseparator")]
        public string DateSeparator
        {
            get { return this.GetAttributeValue<string>("dateseparator"); }
            set
            {
                this.OnPropertyChanging("DateSeparator");
                this.SetAttributeValue("dateseparator", value);
                this.OnPropertyChanged("DateSeparator");
            }
        }

        /// <summary>
        /// Symbol used for decimal in Microsoft Dynamics CRM.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("decimalsymbol")]
        public string DecimalSymbol
        {
            get { return this.GetAttributeValue<string>("decimalsymbol"); }
            set
            {
                this.OnPropertyChanging("DecimalSymbol");
                this.SetAttributeValue("decimalsymbol", value);
                this.OnPropertyChanged("DecimalSymbol");
            }
        }

        /// <summary>
        /// Text area to enter default country code.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("defaultcountrycode")]
        public string DefaultCountryCode
        {
            get { return this.GetAttributeValue<string>("defaultcountrycode"); }
            set
            {
                this.OnPropertyChanging("DefaultCountryCode");
                this.SetAttributeValue("defaultcountrycode", value);
                this.OnPropertyChanged("DefaultCountryCode");
            }
        }

        /// <summary>
        /// Unique identifier of the default email server profile.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("defaultemailserverprofileid")]
        public Microsoft.Xrm.Sdk.EntityReference DefaultEmailServerProfileId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("defaultemailserverprofileid"); }
            set
            {
                this.OnPropertyChanging("DefaultEmailServerProfileId");
                this.SetAttributeValue("defaultemailserverprofileid", value);
                this.OnPropertyChanged("DefaultEmailServerProfileId");
            }
        }

        /// <summary>
        /// XML string containing the default email settings that are applied when a user or queue is created.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("defaultemailsettings")]
        public string DefaultEmailSettings
        {
            get { return this.GetAttributeValue<string>("defaultemailsettings"); }
            set
            {
                this.OnPropertyChanging("DefaultEmailSettings");
                this.SetAttributeValue("defaultemailsettings", value);
                this.OnPropertyChanged("DefaultEmailSettings");
            }
        }

        /// <summary>
        /// Type of default recurrence end range date.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("defaultrecurrenceendrangetype")]
        public Microsoft.Xrm.Sdk.OptionSetValue DefaultRecurrenceEndRangeType
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("defaultrecurrenceendrangetype"); }
            set
            {
                this.OnPropertyChanging("DefaultRecurrenceEndRangeType");
                this.SetAttributeValue("defaultrecurrenceendrangetype", value);
                this.OnPropertyChanged("DefaultRecurrenceEndRangeType");
            }
        }

        /// <summary>
        /// Reason for disabling the organization.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("disabledreason")]
        public string DisabledReason
        {
            get { return this.GetAttributeValue<string>("disabledreason"); }
        }

        /// <summary>
        /// Indicates whether Social Care is disabled.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("disablesocialcare")]
        public System.Nullable<bool> DisableSocialCare
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("disablesocialcare"); }
            set
            {
                this.OnPropertyChanging("DisableSocialCare");
                this.SetAttributeValue("disablesocialcare", value);
                this.OnPropertyChanged("DisableSocialCare");
            }
        }

        /// <summary>
        /// Discount calculation method for the QOOI product.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("discountcalculationmethod")]
        public Microsoft.Xrm.Sdk.OptionSetValue DiscountCalculationMethod
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("discountcalculationmethod"); }
            set
            {
                this.OnPropertyChanging("DiscountCalculationMethod");
                this.SetAttributeValue("discountcalculationmethod", value);
                this.OnPropertyChanged("DiscountCalculationMethod");
            }
        }

        /// <summary>
        /// Indicates whether or not navigation tour is displayed.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("displaynavigationtour")]
        public System.Nullable<bool> DisplayNavigationTour
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("displaynavigationtour"); }
            set
            {
                this.OnPropertyChanging("DisplayNavigationTour");
                this.SetAttributeValue("displaynavigationtour", value);
                this.OnPropertyChanged("DisplayNavigationTour");
            }
        }

        /// <summary>
        /// Select if you want to use the Email Router or server-side synchronization for email processing.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("emailconnectionchannel")]
        public Microsoft.Xrm.Sdk.OptionSetValue EmailConnectionChannel
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("emailconnectionchannel"); }
            set
            {
                this.OnPropertyChanging("EmailConnectionChannel");
                this.SetAttributeValue("emailconnectionchannel", value);
                this.OnPropertyChanged("EmailConnectionChannel");
            }
        }

        /// <summary>
        /// Flag to turn email correlation on or off.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("emailcorrelationenabled")]
        public System.Nullable<bool> EmailCorrelationEnabled
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("emailcorrelationenabled"); }
            set
            {
                this.OnPropertyChanging("EmailCorrelationEnabled");
                this.SetAttributeValue("emailcorrelationenabled", value);
                this.OnPropertyChanged("EmailCorrelationEnabled");
            }
        }

        /// <summary>
        /// Normal polling frequency used for sending email in Microsoft Office Outlook.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("emailsendpollingperiod")]
        public System.Nullable<int> EmailSendPollingPeriod
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("emailsendpollingperiod"); }
            set
            {
                this.OnPropertyChanging("EmailSendPollingPeriod");
                this.SetAttributeValue("emailsendpollingperiod", value);
                this.OnPropertyChanged("EmailSendPollingPeriod");
            }
        }

        /// <summary>
        /// Enable Integration with Bing Maps
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("enablebingmapsintegration")]
        public System.Nullable<bool> EnableBingMapsIntegration
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("enablebingmapsintegration"); }
            set
            {
                this.OnPropertyChanging("EnableBingMapsIntegration");
                this.SetAttributeValue("enablebingmapsintegration", value);
                this.OnPropertyChanged("EnableBingMapsIntegration");
            }
        }

        /// <summary>
        /// Enable pricing calculations on a Create call.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("enablepricingoncreate")]
        public System.Nullable<bool> EnablePricingOnCreate
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("enablepricingoncreate"); }
            set
            {
                this.OnPropertyChanging("EnablePricingOnCreate");
                this.SetAttributeValue("enablepricingoncreate", value);
                this.OnPropertyChanged("EnablePricingOnCreate");
            }
        }

        /// <summary>
        /// Use Smart Matching.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("enablesmartmatching")]
        public System.Nullable<bool> EnableSmartMatching
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("enablesmartmatching"); }
            set
            {
                this.OnPropertyChanging("EnableSmartMatching");
                this.SetAttributeValue("enablesmartmatching", value);
                this.OnPropertyChanged("EnableSmartMatching");
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
        /// Maximum number of days before deleting inactive subscriptions.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("expiresubscriptionsindays")]
        public System.Nullable<int> ExpireSubscriptionsInDays
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("expiresubscriptionsindays"); }
            set
            {
                this.OnPropertyChanging("ExpireSubscriptionsInDays");
                this.SetAttributeValue("expiresubscriptionsindays", value);
                this.OnPropertyChanged("ExpireSubscriptionsInDays");
            }
        }

        /// <summary>
        /// Features to be enabled as an XML BLOB.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("featureset")]
        public string FeatureSet
        {
            get { return this.GetAttributeValue<string>("featureset"); }
            set
            {
                this.OnPropertyChanging("FeatureSet");
                this.SetAttributeValue("featureset", value);
                this.OnPropertyChanged("FeatureSet");
            }
        }

        /// <summary>
        /// Start date for the fiscal period that is to be used throughout Microsoft CRM.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("fiscalcalendarstart")]
        public System.Nullable<System.DateTime> FiscalCalendarStart
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("fiscalcalendarstart"); }
            set
            {
                this.OnPropertyChanging("FiscalCalendarStart");
                this.SetAttributeValue("fiscalcalendarstart", value);
                this.OnPropertyChanged("FiscalCalendarStart");
            }
        }

        /// <summary>
        /// Information that specifies how the name of the fiscal period is displayed throughout Microsoft CRM.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("fiscalperiodformat")]
        public string FiscalPeriodFormat
        {
            get { return this.GetAttributeValue<string>("fiscalperiodformat"); }
            set
            {
                this.OnPropertyChanging("FiscalPeriodFormat");
                this.SetAttributeValue("fiscalperiodformat", value);
                this.OnPropertyChanged("FiscalPeriodFormat");
            }
        }

        /// <summary>
        /// Format in which the fiscal period will be displayed.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("fiscalperiodformatperiod")]
        public Microsoft.Xrm.Sdk.OptionSetValue FiscalPeriodFormatPeriod
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("fiscalperiodformatperiod"); }
            set
            {
                this.OnPropertyChanging("FiscalPeriodFormatPeriod");
                this.SetAttributeValue("fiscalperiodformatperiod", value);
                this.OnPropertyChanged("FiscalPeriodFormatPeriod");
            }
        }

        /// <summary>
        /// Type of fiscal period used throughout Microsoft CRM.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("fiscalperiodtype")]
        public System.Nullable<int> FiscalPeriodType
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("fiscalperiodtype"); }
            set
            {
                this.OnPropertyChanging("FiscalPeriodType");
                this.SetAttributeValue("fiscalperiodtype", value);
                this.OnPropertyChanged("FiscalPeriodType");
            }
        }

        /// <summary>
        /// Information that specifies whether the fiscal settings have been updated.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("fiscalsettingsupdated")]
        [System.ObsoleteAttribute()]
        public System.Nullable<bool> FiscalSettingsUpdated
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("fiscalsettingsupdated"); }
        }

        /// <summary>
        /// Information that specifies whether the fiscal year should be displayed based on the start date or the end date of the fiscal year.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("fiscalyeardisplaycode")]
        public System.Nullable<int> FiscalYearDisplayCode
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("fiscalyeardisplaycode"); }
            set
            {
                this.OnPropertyChanging("FiscalYearDisplayCode");
                this.SetAttributeValue("fiscalyeardisplaycode", value);
                this.OnPropertyChanged("FiscalYearDisplayCode");
            }
        }

        /// <summary>
        /// Information that specifies how the name of the fiscal year is displayed throughout Microsoft CRM.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("fiscalyearformat")]
        public string FiscalYearFormat
        {
            get { return this.GetAttributeValue<string>("fiscalyearformat"); }
            set
            {
                this.OnPropertyChanging("FiscalYearFormat");
                this.SetAttributeValue("fiscalyearformat", value);
                this.OnPropertyChanged("FiscalYearFormat");
            }
        }

        /// <summary>
        /// Prefix for the display of the fiscal year.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("fiscalyearformatprefix")]
        public Microsoft.Xrm.Sdk.OptionSetValue FiscalYearFormatPrefix
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("fiscalyearformatprefix"); }
            set
            {
                this.OnPropertyChanging("FiscalYearFormatPrefix");
                this.SetAttributeValue("fiscalyearformatprefix", value);
                this.OnPropertyChanged("FiscalYearFormatPrefix");
            }
        }

        /// <summary>
        /// Suffix for the display of the fiscal year.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("fiscalyearformatsuffix")]
        public Microsoft.Xrm.Sdk.OptionSetValue FiscalYearFormatSuffix
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("fiscalyearformatsuffix"); }
            set
            {
                this.OnPropertyChanging("FiscalYearFormatSuffix");
                this.SetAttributeValue("fiscalyearformatsuffix", value);
                this.OnPropertyChanged("FiscalYearFormatSuffix");
            }
        }

        /// <summary>
        /// Format for the year.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("fiscalyearformatyear")]
        public Microsoft.Xrm.Sdk.OptionSetValue FiscalYearFormatYear
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("fiscalyearformatyear"); }
            set
            {
                this.OnPropertyChanging("FiscalYearFormatYear");
                this.SetAttributeValue("fiscalyearformatyear", value);
                this.OnPropertyChanged("FiscalYearFormatYear");
            }
        }

        /// <summary>
        /// Information that specifies how the names of the fiscal year and the fiscal period should be connected when displayed together.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("fiscalyearperiodconnect")]
        public string FiscalYearPeriodConnect
        {
            get { return this.GetAttributeValue<string>("fiscalyearperiodconnect"); }
            set
            {
                this.OnPropertyChanging("FiscalYearPeriodConnect");
                this.SetAttributeValue("fiscalyearperiodconnect", value);
                this.OnPropertyChanged("FiscalYearPeriodConnect");
            }
        }

        /// <summary>
        /// Order in which names are to be displayed throughout Microsoft CRM.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("fullnameconventioncode")]
        public Microsoft.Xrm.Sdk.OptionSetValue FullNameConventionCode
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("fullnameconventioncode"); }
            set
            {
                this.OnPropertyChanging("FullNameConventionCode");
                this.SetAttributeValue("fullnameconventioncode", value);
                this.OnPropertyChanged("FullNameConventionCode");
            }
        }

        /// <summary>
        /// Specifies the maximum number of months in future for which the recurring activities can be created.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("futureexpansionwindow")]
        public System.Nullable<int> FutureExpansionWindow
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("futureexpansionwindow"); }
            set
            {
                this.OnPropertyChanging("FutureExpansionWindow");
                this.SetAttributeValue("futureexpansionwindow", value);
                this.OnPropertyChanged("FutureExpansionWindow");
            }
        }

        /// <summary>
        /// Indicates whether alerts will be generated for errors.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("generatealertsforerrors")]
        public System.Nullable<bool> GenerateAlertsForErrors
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("generatealertsforerrors"); }
            set
            {
                this.OnPropertyChanging("GenerateAlertsForErrors");
                this.SetAttributeValue("generatealertsforerrors", value);
                this.OnPropertyChanged("GenerateAlertsForErrors");
            }
        }

        /// <summary>
        /// Indicates whether alerts will be generated for information.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("generatealertsforinformation")]
        public System.Nullable<bool> GenerateAlertsForInformation
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("generatealertsforinformation"); }
            set
            {
                this.OnPropertyChanging("GenerateAlertsForInformation");
                this.SetAttributeValue("generatealertsforinformation", value);
                this.OnPropertyChanged("GenerateAlertsForInformation");
            }
        }

        /// <summary>
        /// Indicates whether alerts will be generated for warnings.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("generatealertsforwarnings")]
        public System.Nullable<bool> GenerateAlertsForWarnings
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("generatealertsforwarnings"); }
            set
            {
                this.OnPropertyChanging("GenerateAlertsForWarnings");
                this.SetAttributeValue("generatealertsforwarnings", value);
                this.OnPropertyChanged("GenerateAlertsForWarnings");
            }
        }

        /// <summary>
        /// Indicates whether Get Started content is enabled for this organization.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("getstartedpanecontentenabled")]
        public System.Nullable<bool> GetStartedPaneContentEnabled
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("getstartedpanecontentenabled"); }
            set
            {
                this.OnPropertyChanging("GetStartedPaneContentEnabled");
                this.SetAttributeValue("getstartedpanecontentenabled", value);
                this.OnPropertyChanged("GetStartedPaneContentEnabled");
            }
        }

        /// <summary>
        /// Indicates whether the append URL parameters is enabled.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("globalappendurlparametersenabled")]
        public System.Nullable<bool> GlobalAppendUrlParametersEnabled
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("globalappendurlparametersenabled"); }
            set
            {
                this.OnPropertyChanging("GlobalAppendUrlParametersEnabled");
                this.SetAttributeValue("globalappendurlparametersenabled", value);
                this.OnPropertyChanged("GlobalAppendUrlParametersEnabled");
            }
        }

        /// <summary>
        /// URL for the web page global help.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("globalhelpurl")]
        public string GlobalHelpUrl
        {
            get { return this.GetAttributeValue<string>("globalhelpurl"); }
            set
            {
                this.OnPropertyChanging("GlobalHelpUrl");
                this.SetAttributeValue("globalhelpurl", value);
                this.OnPropertyChanged("GlobalHelpUrl");
            }
        }

        /// <summary>
        /// Indicates whether the customizable global help is enabled.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("globalhelpurlenabled")]
        public System.Nullable<bool> GlobalHelpUrlEnabled
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("globalhelpurlenabled"); }
            set
            {
                this.OnPropertyChanging("GlobalHelpUrlEnabled");
                this.SetAttributeValue("globalhelpurlenabled", value);
                this.OnPropertyChanged("GlobalHelpUrlEnabled");
            }
        }

        /// <summary>
        /// Number of days after the goal's end date after which the rollup of the goal stops automatically.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("goalrollupexpirytime")]
        public System.Nullable<int> GoalRollupExpiryTime
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("goalrollupexpirytime"); }
            set
            {
                this.OnPropertyChanging("GoalRollupExpiryTime");
                this.SetAttributeValue("goalrollupexpirytime", value);
                this.OnPropertyChanged("GoalRollupExpiryTime");
            }
        }

        /// <summary>
        /// Number of hours between automatic rollup jobs .
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("goalrollupfrequency")]
        public System.Nullable<int> GoalRollupFrequency
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("goalrollupfrequency"); }
            set
            {
                this.OnPropertyChanging("GoalRollupFrequency");
                this.SetAttributeValue("goalrollupfrequency", value);
                this.OnPropertyChanged("GoalRollupFrequency");
            }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("grantaccesstonetworkservice")]
        public System.Nullable<bool> GrantAccessToNetworkService
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("grantaccesstonetworkservice"); }
            set
            {
                this.OnPropertyChanging("GrantAccessToNetworkService");
                this.SetAttributeValue("grantaccesstonetworkservice", value);
                this.OnPropertyChanged("GrantAccessToNetworkService");
            }
        }

        /// <summary>
        /// Maximum difference allowed between subject keywords count of the email messaged to be correlated
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("hashdeltasubjectcount")]
        public System.Nullable<int> HashDeltaSubjectCount
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("hashdeltasubjectcount"); }
            set
            {
                this.OnPropertyChanging("HashDeltaSubjectCount");
                this.SetAttributeValue("hashdeltasubjectcount", value);
                this.OnPropertyChanged("HashDeltaSubjectCount");
            }
        }

        /// <summary>
        /// Filter Subject Keywords
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("hashfilterkeywords")]
        public string HashFilterKeywords
        {
            get { return this.GetAttributeValue<string>("hashfilterkeywords"); }
            set
            {
                this.OnPropertyChanging("HashFilterKeywords");
                this.SetAttributeValue("hashfilterkeywords", value);
                this.OnPropertyChanged("HashFilterKeywords");
            }
        }

        /// <summary>
        /// Maximum number of subject keywords or recipients used for correlation
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("hashmaxcount")]
        public System.Nullable<int> HashMaxCount
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("hashmaxcount"); }
            set
            {
                this.OnPropertyChanging("HashMaxCount");
                this.SetAttributeValue("hashmaxcount", value);
                this.OnPropertyChanged("HashMaxCount");
            }
        }

        /// <summary>
        /// Minimum number of recipients required to match for email messaged to be correlated
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("hashminaddresscount")]
        public System.Nullable<int> HashMinAddressCount
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("hashminaddresscount"); }
            set
            {
                this.OnPropertyChanging("HashMinAddressCount");
                this.SetAttributeValue("hashminaddresscount", value);
                this.OnPropertyChanged("HashMinAddressCount");
            }
        }

        /// <summary>
        /// Indicates whether incoming email sent by internal Microsoft Dynamics CRM users or queues should be tracked.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ignoreinternalemail")]
        public System.Nullable<bool> IgnoreInternalEmail
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("ignoreinternalemail"); }
            set
            {
                this.OnPropertyChanging("IgnoreInternalEmail");
                this.SetAttributeValue("ignoreinternalemail", value);
                this.OnPropertyChanged("IgnoreInternalEmail");
            }
        }

        /// <summary>
        /// Setting for the Async Service Mailbox Queue. Defines the retrieval batch size of exchange server.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("incomingemailexchangeemailretrievalbatchsize")]
        public System.Nullable<int> IncomingEmailExchangeEmailRetrievalBatchSize
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("incomingemailexchangeemailretrievalbatchsize"); }
            set
            {
                this.OnPropertyChanging("IncomingEmailExchangeEmailRetrievalBatchSize");
                this.SetAttributeValue("incomingemailexchangeemailretrievalbatchsize", value);
                this.OnPropertyChanged("IncomingEmailExchangeEmailRetrievalBatchSize");
            }
        }

        /// <summary>
        /// Initial version of the organization.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("initialversion")]
        public string InitialVersion
        {
            get { return this.GetAttributeValue<string>("initialversion"); }
            set
            {
                this.OnPropertyChanging("InitialVersion");
                this.SetAttributeValue("initialversion", value);
                this.OnPropertyChanged("InitialVersion");
            }
        }

        /// <summary>
        /// Unique identifier of the integration user for the organization.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("integrationuserid")]
        public System.Nullable<System.Guid> IntegrationUserId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("integrationuserid"); }
            set
            {
                this.OnPropertyChanging("IntegrationUserId");
                this.SetAttributeValue("integrationuserid", value);
                this.OnPropertyChanged("IntegrationUserId");
            }
        }

        /// <summary>
        /// Prefix to use for all invoice numbers throughout Microsoft Dynamics CRM.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("invoiceprefix")]
        public string InvoicePrefix
        {
            get { return this.GetAttributeValue<string>("invoiceprefix"); }
            set
            {
                this.OnPropertyChanging("InvoicePrefix");
                this.SetAttributeValue("invoiceprefix", value);
                this.OnPropertyChanged("InvoicePrefix");
            }
        }

        /// <summary>
        /// Indicates whether loading of Microsoft Dynamics CRM in a browser window that does not have address, tool, and menu bars is enabled.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isappmode")]
        public System.Nullable<bool> IsAppMode
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("isappmode"); }
            set
            {
                this.OnPropertyChanging("IsAppMode");
                this.SetAttributeValue("isappmode", value);
                this.OnPropertyChanged("IsAppMode");
            }
        }

        /// <summary>
        /// Enable or disable attachments sync for outlook and exchange.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isappointmentattachmentsyncenabled")]
        public System.Nullable<bool> IsAppointmentAttachmentSyncEnabled
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("isappointmentattachmentsyncenabled"); }
            set
            {
                this.OnPropertyChanging("IsAppointmentAttachmentSyncEnabled");
                this.SetAttributeValue("isappointmentattachmentsyncenabled", value);
                this.OnPropertyChanged("IsAppointmentAttachmentSyncEnabled");
            }
        }

        /// <summary>
        /// Enable or disable assigned tasks sync for outlook and exchange.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isassignedtaskssyncenabled")]
        public System.Nullable<bool> IsAssignedTasksSyncEnabled
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("isassignedtaskssyncenabled"); }
            set
            {
                this.OnPropertyChanging("IsAssignedTasksSyncEnabled");
                this.SetAttributeValue("isassignedtaskssyncenabled", value);
                this.OnPropertyChanged("IsAssignedTasksSyncEnabled");
            }
        }

        /// <summary>
        /// Enable or disable auditing of changes.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isauditenabled")]
        public System.Nullable<bool> IsAuditEnabled
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("isauditenabled"); }
            set
            {
                this.OnPropertyChanging("IsAuditEnabled");
                this.SetAttributeValue("isauditenabled", value);
                this.OnPropertyChanged("IsAuditEnabled");
            }
        }

        /// <summary>
        /// Information on whether auto save is enabled.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isautosaveenabled")]
        public System.Nullable<bool> IsAutoSaveEnabled
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("isautosaveenabled"); }
            set
            {
                this.OnPropertyChanging("IsAutoSaveEnabled");
                this.SetAttributeValue("isautosaveenabled", value);
                this.OnPropertyChanged("IsAutoSaveEnabled");
            }
        }

        /// <summary>
        /// Enable or disable mailing address sync for outlook and exchange.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("iscontactmailingaddresssyncenabled")]
        public System.Nullable<bool> IsContactMailingAddressSyncEnabled
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("iscontactmailingaddresssyncenabled"); }
            set
            {
                this.OnPropertyChanging("IsContactMailingAddressSyncEnabled");
                this.SetAttributeValue("iscontactmailingaddresssyncenabled", value);
                this.OnPropertyChanged("IsContactMailingAddressSyncEnabled");
            }
        }

        /// <summary>
        /// Enable or disable country code selection.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isdefaultcountrycodecheckenabled")]
        public System.Nullable<bool> IsDefaultCountryCodeCheckEnabled
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("isdefaultcountrycodecheckenabled"); }
            set
            {
                this.OnPropertyChanging("IsDefaultCountryCodeCheckEnabled");
                this.SetAttributeValue("isdefaultcountrycodecheckenabled", value);
                this.OnPropertyChanged("IsDefaultCountryCodeCheckEnabled");
            }
        }

        /// <summary>
        /// Information that specifies whether the organization is disabled.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isdisabled")]
        public System.Nullable<bool> IsDisabled
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("isdisabled"); }
        }

        /// <summary>
        /// Indicates whether duplicate detection of records is enabled.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isduplicatedetectionenabled")]
        public System.Nullable<bool> IsDuplicateDetectionEnabled
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("isduplicatedetectionenabled"); }
            set
            {
                this.OnPropertyChanging("IsDuplicateDetectionEnabled");
                this.SetAttributeValue("isduplicatedetectionenabled", value);
                this.OnPropertyChanged("IsDuplicateDetectionEnabled");
            }
        }

        /// <summary>
        /// Indicates whether duplicate detection of records during import is enabled.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isduplicatedetectionenabledforimport")]
        public System.Nullable<bool> IsDuplicateDetectionEnabledForImport
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("isduplicatedetectionenabledforimport"); }
            set
            {
                this.OnPropertyChanging("IsDuplicateDetectionEnabledForImport");
                this.SetAttributeValue("isduplicatedetectionenabledforimport", value);
                this.OnPropertyChanged("IsDuplicateDetectionEnabledForImport");
            }
        }

        /// <summary>
        /// Indicates whether duplicate detection of records during offline synchronization is enabled.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isduplicatedetectionenabledforofflinesync")]
        public System.Nullable<bool> IsDuplicateDetectionEnabledForOfflineSync
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("isduplicatedetectionenabledforofflinesync"); }
            set
            {
                this.OnPropertyChanging("IsDuplicateDetectionEnabledForOfflineSync");
                this.SetAttributeValue("isduplicatedetectionenabledforofflinesync", value);
                this.OnPropertyChanged("IsDuplicateDetectionEnabledForOfflineSync");
            }
        }

        /// <summary>
        /// Indicates whether duplicate detection during online create or update is enabled.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isduplicatedetectionenabledforonlinecreateupdate")]
        public System.Nullable<bool> IsDuplicateDetectionEnabledForOnlineCreateUpdate
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("isduplicatedetectionenabledforonlinecreateupdate"); }
            set
            {
                this.OnPropertyChanging("IsDuplicateDetectionEnabledForOnlineCreateUpdate");
                this.SetAttributeValue("isduplicatedetectionenabledforonlinecreateupdate", value);
                this.OnPropertyChanged("IsDuplicateDetectionEnabledForOnlineCreateUpdate");
            }
        }

        /// <summary>
        /// Indicates whether the fiscal period is displayed as the month number.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isfiscalperiodmonthbased")]
        public System.Nullable<bool> IsFiscalPeriodMonthBased
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("isfiscalperiodmonthbased"); }
            set
            {
                this.OnPropertyChanging("IsFiscalPeriodMonthBased");
                this.SetAttributeValue("isfiscalperiodmonthbased", value);
                this.OnPropertyChanged("IsFiscalPeriodMonthBased");
            }
        }

        /// <summary>
        /// Enable Hierarchical Security Model
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ishierarchicalsecuritymodelenabled")]
        public System.Nullable<bool> IsHierarchicalSecurityModelEnabled
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("ishierarchicalsecuritymodelenabled"); }
            set
            {
                this.OnPropertyChanging("IsHierarchicalSecurityModelEnabled");
                this.SetAttributeValue("ishierarchicalsecuritymodelenabled", value);
                this.OnPropertyChanged("IsHierarchicalSecurityModelEnabled");
            }
        }

        /// <summary>
        /// Enable or disable mailbox keep alive for Server Side Sync.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ismailboxinactivebackoffenabled")]
        public System.Nullable<bool> IsMailboxInactiveBackoffEnabled
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("ismailboxinactivebackoffenabled"); }
            set
            {
                this.OnPropertyChanging("IsMailboxInactiveBackoffEnabled");
                this.SetAttributeValue("ismailboxinactivebackoffenabled", value);
                this.OnPropertyChanged("IsMailboxInactiveBackoffEnabled");
            }
        }

        /// <summary>
        /// Information on whether IM presence is enabled.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ispresenceenabled")]
        public System.Nullable<bool> IsPresenceEnabled
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("ispresenceenabled"); }
            set
            {
                this.OnPropertyChanging("IsPresenceEnabled");
                this.SetAttributeValue("ispresenceenabled", value);
                this.OnPropertyChanged("IsPresenceEnabled");
            }
        }

        /// <summary>
        /// Enable sales order processing integration.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("issopintegrationenabled")]
        public System.Nullable<bool> IsSOPIntegrationEnabled
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("issopintegrationenabled"); }
            set
            {
                this.OnPropertyChanging("IsSOPIntegrationEnabled");
                this.SetAttributeValue("issopintegrationenabled", value);
                this.OnPropertyChanged("IsSOPIntegrationEnabled");
            }
        }

        /// <summary>
        /// Enable or disable auditing of user access.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isuseraccessauditenabled")]
        public System.Nullable<bool> IsUserAccessAuditEnabled
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("isuseraccessauditenabled"); }
            set
            {
                this.OnPropertyChanging("IsUserAccessAuditEnabled");
                this.SetAttributeValue("isuseraccessauditenabled", value);
                this.OnPropertyChanged("IsUserAccessAuditEnabled");
            }
        }

        /// <summary>
        /// Indicates whether loading of Microsoft Dynamics CRM in a browser window that does not have address, tool, and menu bars is enabled.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isvintegrationcode")]
        [System.ObsoleteAttribute()]
        public Microsoft.Xrm.Sdk.OptionSetValue ISVIntegrationCode
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("isvintegrationcode"); }
            set
            {
                this.OnPropertyChanging("ISVIntegrationCode");
                this.SetAttributeValue("isvintegrationcode", value);
                this.OnPropertyChanged("ISVIntegrationCode");
            }
        }

        /// <summary>
        /// Prefix to use for all articles in Microsoft Dynamics CRM.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("kbprefix")]
        public string KbPrefix
        {
            get { return this.GetAttributeValue<string>("kbprefix"); }
            set
            {
                this.OnPropertyChanging("KbPrefix");
                this.SetAttributeValue("kbprefix", value);
                this.OnPropertyChanged("KbPrefix");
            }
        }

        /// <summary>
        /// Preferred language for the organization.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("languagecode")]
        public System.Nullable<int> LanguageCode
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("languagecode"); }
            set
            {
                this.OnPropertyChanging("LanguageCode");
                this.SetAttributeValue("languagecode", value);
                this.OnPropertyChanged("LanguageCode");
            }
        }

        /// <summary>
        /// Unique identifier of the locale of the organization.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("localeid")]
        public System.Nullable<int> LocaleId
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("localeid"); }
            set
            {
                this.OnPropertyChanging("LocaleId");
                this.SetAttributeValue("localeid", value);
                this.OnPropertyChanged("LocaleId");
            }
        }

        /// <summary>
        /// Information that specifies how the Long Date format is displayed in Microsoft Dynamics CRM.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("longdateformatcode")]
        public System.Nullable<int> LongDateFormatCode
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("longdateformatcode"); }
            set
            {
                this.OnPropertyChanging("LongDateFormatCode");
                this.SetAttributeValue("longdateformatcode", value);
                this.OnPropertyChanged("LongDateFormatCode");
            }
        }

        /// <summary>
        /// Maximum number of days an appointment can last.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("maxappointmentdurationdays")]
        public System.Nullable<int> MaxAppointmentDurationDays
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("maxappointmentdurationdays"); }
            set
            {
                this.OnPropertyChanging("MaxAppointmentDurationDays");
                this.SetAttributeValue("maxappointmentdurationdays", value);
                this.OnPropertyChanged("MaxAppointmentDurationDays");
            }
        }

        /// <summary>
        /// Maximum depth for hierarchy security propagation.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("maxdepthforhierarchicalsecuritymodel")]
        public System.Nullable<int> MaxDepthForHierarchicalSecurityModel
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("maxdepthforhierarchicalsecuritymodel"); }
            set
            {
                this.OnPropertyChanging("MaxDepthForHierarchicalSecurityModel");
                this.SetAttributeValue("maxdepthforhierarchicalsecuritymodel", value);
                this.OnPropertyChanged("MaxDepthForHierarchicalSecurityModel");
            }
        }

        /// <summary>
        /// Maximum number of active business process flows allowed per entity
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("maximumactivebusinessprocessflowsallowedperentity")]
        public System.Nullable<int> MaximumActiveBusinessProcessFlowsAllowedPerEntity
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("maximumactivebusinessprocessflowsallowedperentity"); }
            set
            {
                this.OnPropertyChanging("MaximumActiveBusinessProcessFlowsAllowedPerEntity");
                this.SetAttributeValue("maximumactivebusinessprocessflowsallowedperentity", value);
                this.OnPropertyChanged("MaximumActiveBusinessProcessFlowsAllowedPerEntity");
            }
        }

        /// <summary>
        /// Restrict the maximum number of product properties for a product family/bundle
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("maximumdynamicpropertiesallowed")]
        public System.Nullable<int> MaximumDynamicPropertiesAllowed
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("maximumdynamicpropertiesallowed"); }
            set
            {
                this.OnPropertyChanging("MaximumDynamicPropertiesAllowed");
                this.SetAttributeValue("maximumdynamicpropertiesallowed", value);
                this.OnPropertyChanged("MaximumDynamicPropertiesAllowed");
            }
        }

        /// <summary>
        /// Maximum tracking number before recycling takes place.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("maximumtrackingnumber")]
        public System.Nullable<int> MaximumTrackingNumber
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("maximumtrackingnumber"); }
            set
            {
                this.OnPropertyChanging("MaximumTrackingNumber");
                this.SetAttributeValue("maximumtrackingnumber", value);
                this.OnPropertyChanged("MaximumTrackingNumber");
            }
        }

        /// <summary>
        /// Restrict the maximum no of items in a bundle
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("maxproductsinbundle")]
        public System.Nullable<int> MaxProductsInBundle
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("maxproductsinbundle"); }
            set
            {
                this.OnPropertyChanging("MaxProductsInBundle");
                this.SetAttributeValue("maxproductsinbundle", value);
                this.OnPropertyChanged("MaxProductsInBundle");
            }
        }

        /// <summary>
        /// Maximum number of records that will be exported to a static Microsoft Office Excel worksheet when exporting from the grid.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("maxrecordsforexporttoexcel")]
        public System.Nullable<int> MaxRecordsForExportToExcel
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("maxrecordsforexporttoexcel"); }
            set
            {
                this.OnPropertyChanging("MaxRecordsForExportToExcel");
                this.SetAttributeValue("maxrecordsforexporttoexcel", value);
                this.OnPropertyChanged("MaxRecordsForExportToExcel");
            }
        }

        /// <summary>
        /// Maximum number of lookup and picklist records that can be selected by user for filtering.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("maxrecordsforlookupfilters")]
        public System.Nullable<int> MaxRecordsForLookupFilters
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("maxrecordsforlookupfilters"); }
            set
            {
                this.OnPropertyChanging("MaxRecordsForLookupFilters");
                this.SetAttributeValue("maxrecordsforlookupfilters", value);
                this.OnPropertyChanged("MaxRecordsForLookupFilters");
            }
        }

        /// <summary>
        /// The maximum version of IE to run browser emulation for in Outlook client
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("maxsupportedinternetexplorerversion")]
        public System.Nullable<int> MaxSupportedInternetExplorerVersion
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("maxsupportedinternetexplorerversion"); }
        }

        /// <summary>
        /// Maximum allowed size of an attachment.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("maxuploadfilesize")]
        public System.Nullable<int> MaxUploadFileSize
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("maxuploadfilesize"); }
            set
            {
                this.OnPropertyChanging("MaxUploadFileSize");
                this.SetAttributeValue("maxuploadfilesize", value);
                this.OnPropertyChanged("MaxUploadFileSize");
            }
        }

        /// <summary>
        /// Normal polling frequency used for address book synchronization in Microsoft Office Outlook.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("minaddressbooksyncinterval")]
        public System.Nullable<int> MinAddressBookSyncInterval
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("minaddressbooksyncinterval"); }
            set
            {
                this.OnPropertyChanging("MinAddressBookSyncInterval");
                this.SetAttributeValue("minaddressbooksyncinterval", value);
                this.OnPropertyChanged("MinAddressBookSyncInterval");
            }
        }

        /// <summary>
        /// Normal polling frequency used for background offline synchronization in Microsoft Office Outlook.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("minofflinesyncinterval")]
        public System.Nullable<int> MinOfflineSyncInterval
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("minofflinesyncinterval"); }
            set
            {
                this.OnPropertyChanging("MinOfflineSyncInterval");
                this.SetAttributeValue("minofflinesyncinterval", value);
                this.OnPropertyChanged("MinOfflineSyncInterval");
            }
        }

        /// <summary>
        /// Minimum allowed time between scheduled Outlook synchronizations.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("minoutlooksyncinterval")]
        public System.Nullable<int> MinOutlookSyncInterval
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("minoutlooksyncinterval"); }
            set
            {
                this.OnPropertyChanging("MinOutlookSyncInterval");
                this.SetAttributeValue("minoutlooksyncinterval", value);
                this.OnPropertyChanged("MinOutlookSyncInterval");
            }
        }

        /// <summary>
        /// Indicates whether the mobile client mashup is enabled.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("mobileclientmashupenabled")]
        public System.Nullable<bool> MobileClientMashupEnabled
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("mobileclientmashupenabled"); }
            set
            {
                this.OnPropertyChanging("MobileClientMashupEnabled");
                this.SetAttributeValue("mobileclientmashupenabled", value);
                this.OnPropertyChanged("MobileClientMashupEnabled");
            }
        }

        /// <summary>
        /// Unique identifier of the user who last modified the organization.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby"); }
        }

        /// <summary>
        /// Date and time when the organization was last modified.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
        public System.Nullable<System.DateTime> ModifiedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who last modified the organization.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        /// Name of the organization. The name is set when Microsoft CRM is installed and should not be changed.
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
        /// Information that specifies how negative currency numbers are displayed throughout Microsoft Dynamics CRM.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("negativecurrencyformatcode")]
        public System.Nullable<int> NegativeCurrencyFormatCode
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("negativecurrencyformatcode"); }
            set
            {
                this.OnPropertyChanging("NegativeCurrencyFormatCode");
                this.SetAttributeValue("negativecurrencyformatcode", value);
                this.OnPropertyChanged("NegativeCurrencyFormatCode");
            }
        }

        /// <summary>
        /// Information that specifies how negative numbers are displayed throughout Microsoft CRM.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("negativeformatcode")]
        public Microsoft.Xrm.Sdk.OptionSetValue NegativeFormatCode
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("negativeformatcode"); }
            set
            {
                this.OnPropertyChanging("NegativeFormatCode");
                this.SetAttributeValue("negativeformatcode", value);
                this.OnPropertyChanged("NegativeFormatCode");
            }
        }

        /// <summary>
        /// Next token to be placed on the subject line of an email message.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("nexttrackingnumber")]
        public System.Nullable<int> NextTrackingNumber
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("nexttrackingnumber"); }
            set
            {
                this.OnPropertyChanging("NextTrackingNumber");
                this.SetAttributeValue("nexttrackingnumber", value);
                this.OnPropertyChanged("NextTrackingNumber");
            }
        }

        /// <summary>
        /// Indicates whether mailbox owners will be notified of email server profile level alerts.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("notifymailboxownerofemailserverlevelalerts")]
        public System.Nullable<bool> NotifyMailboxOwnerOfEmailServerLevelAlerts
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("notifymailboxownerofemailserverlevelalerts"); }
            set
            {
                this.OnPropertyChanging("NotifyMailboxOwnerOfEmailServerLevelAlerts");
                this.SetAttributeValue("notifymailboxownerofemailserverlevelalerts", value);
                this.OnPropertyChanged("NotifyMailboxOwnerOfEmailServerLevelAlerts");
            }
        }

        /// <summary>
        /// Specification of how numbers are displayed throughout Microsoft CRM.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("numberformat")]
        public string NumberFormat
        {
            get { return this.GetAttributeValue<string>("numberformat"); }
            set
            {
                this.OnPropertyChanging("NumberFormat");
                this.SetAttributeValue("numberformat", value);
                this.OnPropertyChanged("NumberFormat");
            }
        }

        /// <summary>
        /// Specifies how numbers are grouped in Microsoft Dynamics CRM.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("numbergroupformat")]
        public string NumberGroupFormat
        {
            get { return this.GetAttributeValue<string>("numbergroupformat"); }
            set
            {
                this.OnPropertyChanging("NumberGroupFormat");
                this.SetAttributeValue("numbergroupformat", value);
                this.OnPropertyChanged("NumberGroupFormat");
            }
        }

        /// <summary>
        /// Symbol used for number separation in Microsoft Dynamics CRM.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("numberseparator")]
        public string NumberSeparator
        {
            get { return this.GetAttributeValue<string>("numberseparator"); }
            set
            {
                this.OnPropertyChanging("NumberSeparator");
                this.SetAttributeValue("numberseparator", value);
                this.OnPropertyChanged("NumberSeparator");
            }
        }

        /// <summary>
        /// Enable OOB pricing calculation logic for Opportunity, Quote, Order and Invoice entities.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("oobpricecalculationenabled")]
        public System.Nullable<bool> OOBPriceCalculationEnabled
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("oobpricecalculationenabled"); }
            set
            {
                this.OnPropertyChanging("OOBPriceCalculationEnabled");
                this.SetAttributeValue("oobpricecalculationenabled", value);
                this.OnPropertyChanged("OOBPriceCalculationEnabled");
            }
        }

        /// <summary>
        /// Prefix to use for all orders throughout Microsoft Dynamics CRM.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("orderprefix")]
        public string OrderPrefix
        {
            get { return this.GetAttributeValue<string>("orderprefix"); }
            set
            {
                this.OnPropertyChanging("OrderPrefix");
                this.SetAttributeValue("orderprefix", value);
                this.OnPropertyChanged("OrderPrefix");
            }
        }

        /// <summary>
        /// Unique identifier of the organization.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
        public System.Nullable<System.Guid> OrganizationId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("organizationid"); }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { base.Id = value; }
        }

        /// <summary>
        /// Organization settings stored in Organization Database.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("orgdborgsettings")]
        public string OrgDbOrgSettings
        {
            get { return this.GetAttributeValue<string>("orgdborgsettings"); }
            set
            {
                this.OnPropertyChanging("OrgDbOrgSettings");
                this.SetAttributeValue("orgdborgsettings", value);
                this.OnPropertyChanged("OrgDbOrgSettings");
            }
        }

        /// <summary>
        /// Prefix used for parsed table columns.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("parsedtablecolumnprefix")]
        public string ParsedTableColumnPrefix
        {
            get { return this.GetAttributeValue<string>("parsedtablecolumnprefix"); }
        }

        /// <summary>
        /// Prefix used for parsed tables.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("parsedtableprefix")]
        public string ParsedTablePrefix
        {
            get { return this.GetAttributeValue<string>("parsedtableprefix"); }
        }

        /// <summary>
        /// Specifies the maximum number of months in past for which the recurring activities can be created.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("pastexpansionwindow")]
        public System.Nullable<int> PastExpansionWindow
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("pastexpansionwindow"); }
            set
            {
                this.OnPropertyChanging("PastExpansionWindow");
                this.SetAttributeValue("pastexpansionwindow", value);
                this.OnPropertyChanged("PastExpansionWindow");
            }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("picture")]
        public string Picture
        {
            get { return this.GetAttributeValue<string>("picture"); }
            set
            {
                this.OnPropertyChanging("Picture");
                this.SetAttributeValue("picture", value);
                this.OnPropertyChanged("Picture");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("pinpointlanguagecode")]
        public System.Nullable<int> PinpointLanguageCode
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("pinpointlanguagecode"); }
            set
            {
                this.OnPropertyChanging("PinpointLanguageCode");
                this.SetAttributeValue("pinpointlanguagecode", value);
                this.OnPropertyChanged("PinpointLanguageCode");
            }
        }

        /// <summary>
        /// PM designator to use throughout Microsoft Dynamics CRM.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("pmdesignator")]
        public string PMDesignator
        {
            get { return this.GetAttributeValue<string>("pmdesignator"); }
            set
            {
                this.OnPropertyChanging("PMDesignator");
                this.SetAttributeValue("pmdesignator", value);
                this.OnPropertyChanged("PMDesignator");
            }
        }

        /// <summary>
        /// Number of decimal places that can be used for prices.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("pricingdecimalprecision")]
        public System.Nullable<int> PricingDecimalPrecision
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("pricingdecimalprecision"); }
            set
            {
                this.OnPropertyChanging("PricingDecimalPrecision");
                this.SetAttributeValue("pricingdecimalprecision", value);
                this.OnPropertyChanged("PricingDecimalPrecision");
            }
        }

        /// <summary>
        /// Unique identifier of the default privilege for users in the organization.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("privilegeusergroupid")]
        public System.Nullable<System.Guid> PrivilegeUserGroupId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("privilegeusergroupid"); }
            set
            {
                this.OnPropertyChanging("PrivilegeUserGroupId");
                this.SetAttributeValue("privilegeusergroupid", value);
                this.OnPropertyChanged("PrivilegeUserGroupId");
            }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("privreportinggroupid")]
        public System.Nullable<System.Guid> PrivReportingGroupId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("privreportinggroupid"); }
            set
            {
                this.OnPropertyChanging("PrivReportingGroupId");
                this.SetAttributeValue("privreportinggroupid", value);
                this.OnPropertyChanged("PrivReportingGroupId");
            }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("privreportinggroupname")]
        public string PrivReportingGroupName
        {
            get { return this.GetAttributeValue<string>("privreportinggroupname"); }
            set
            {
                this.OnPropertyChanging("PrivReportingGroupName");
                this.SetAttributeValue("privreportinggroupname", value);
                this.OnPropertyChanged("PrivReportingGroupName");
            }
        }

        /// <summary>
        /// Indicates whether a quick find record limit should be enabled for this organization (allows for faster Quick Find queries but prevents overly broad searches).
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("quickfindrecordlimitenabled")]
        public System.Nullable<bool> QuickFindRecordLimitEnabled
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("quickfindrecordlimitenabled"); }
            set
            {
                this.OnPropertyChanging("QuickFindRecordLimitEnabled");
                this.SetAttributeValue("quickfindrecordlimitenabled", value);
                this.OnPropertyChanged("QuickFindRecordLimitEnabled");
            }
        }

        /// <summary>
        /// Prefix to use for all quotes throughout Microsoft Dynamics CRM.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("quoteprefix")]
        public string QuotePrefix
        {
            get { return this.GetAttributeValue<string>("quoteprefix"); }
            set
            {
                this.OnPropertyChanging("QuotePrefix");
                this.SetAttributeValue("quoteprefix", value);
                this.OnPropertyChanged("QuotePrefix");
            }
        }

        /// <summary>
        /// Specifies the default value for number of occurrences field in the recurrence dialog.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("recurrencedefaultnumberofoccurrences")]
        public System.Nullable<int> RecurrenceDefaultNumberOfOccurrences
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("recurrencedefaultnumberofoccurrences"); }
            set
            {
                this.OnPropertyChanging("RecurrenceDefaultNumberOfOccurrences");
                this.SetAttributeValue("recurrencedefaultnumberofoccurrences", value);
                this.OnPropertyChanged("RecurrenceDefaultNumberOfOccurrences");
            }
        }

        /// <summary>
        /// Specifies the interval (in seconds) for pausing expansion job.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("recurrenceexpansionjobbatchinterval")]
        public System.Nullable<int> RecurrenceExpansionJobBatchInterval
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("recurrenceexpansionjobbatchinterval"); }
            set
            {
                this.OnPropertyChanging("RecurrenceExpansionJobBatchInterval");
                this.SetAttributeValue("recurrenceexpansionjobbatchinterval", value);
                this.OnPropertyChanged("RecurrenceExpansionJobBatchInterval");
            }
        }

        /// <summary>
        /// Specifies the value for number of instances created in on demand job in one shot.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("recurrenceexpansionjobbatchsize")]
        public System.Nullable<int> RecurrenceExpansionJobBatchSize
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("recurrenceexpansionjobbatchsize"); }
            set
            {
                this.OnPropertyChanging("RecurrenceExpansionJobBatchSize");
                this.SetAttributeValue("recurrenceexpansionjobbatchsize", value);
                this.OnPropertyChanged("RecurrenceExpansionJobBatchSize");
            }
        }

        /// <summary>
        /// Specifies the maximum number of instances to be created synchronously after creating a recurring appointment.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("recurrenceexpansionsynchcreatemax")]
        public System.Nullable<int> RecurrenceExpansionSynchCreateMax
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("recurrenceexpansionsynchcreatemax"); }
            set
            {
                this.OnPropertyChanging("RecurrenceExpansionSynchCreateMax");
                this.SetAttributeValue("recurrenceexpansionsynchcreatemax", value);
                this.OnPropertyChanged("RecurrenceExpansionSynchCreateMax");
            }
        }

        /// <summary>
        /// XML string that defines the navigation structure for the application. This is the site map from the previously upgraded build and is used in a 3-way merge during upgrade.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("referencesitemapxml")]
        [System.ObsoleteAttribute()]
        public string ReferenceSiteMapXml
        {
            get { return this.GetAttributeValue<string>("referencesitemapxml"); }
            set
            {
                this.OnPropertyChanging("ReferenceSiteMapXml");
                this.SetAttributeValue("referencesitemapxml", value);
                this.OnPropertyChanged("ReferenceSiteMapXml");
            }
        }

        /// <summary>
        /// Flag to render the body of email in the Web form in an IFRAME with the security='restricted' attribute set. This is additional security but can cause a credentials prompt.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rendersecureiframeforemail")]
        public System.Nullable<bool> RenderSecureIFrameForEmail
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("rendersecureiframeforemail"); }
            set
            {
                this.OnPropertyChanging("RenderSecureIFrameForEmail");
                this.SetAttributeValue("rendersecureiframeforemail", value);
                this.OnPropertyChanged("RenderSecureIFrameForEmail");
            }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("reportinggroupid")]
        public System.Nullable<System.Guid> ReportingGroupId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("reportinggroupid"); }
            set
            {
                this.OnPropertyChanging("ReportingGroupId");
                this.SetAttributeValue("reportinggroupid", value);
                this.OnPropertyChanged("ReportingGroupId");
            }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("reportinggroupname")]
        public string ReportingGroupName
        {
            get { return this.GetAttributeValue<string>("reportinggroupname"); }
            set
            {
                this.OnPropertyChanging("ReportingGroupName");
                this.SetAttributeValue("reportinggroupname", value);
                this.OnPropertyChanged("ReportingGroupName");
            }
        }

        /// <summary>
        /// Picklist for selecting the organization preference for reporting scripting errors.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("reportscripterrors")]
        public Microsoft.Xrm.Sdk.OptionSetValue ReportScriptErrors
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("reportscripterrors"); }
            set
            {
                this.OnPropertyChanging("ReportScriptErrors");
                this.SetAttributeValue("reportscripterrors", value);
                this.OnPropertyChanged("ReportScriptErrors");
            }
        }

        /// <summary>
        /// Indicates whether Send As Other User privilege is enabled.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("requireapprovalforqueueemail")]
        public System.Nullable<bool> RequireApprovalForQueueEmail
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("requireapprovalforqueueemail"); }
            set
            {
                this.OnPropertyChanging("RequireApprovalForQueueEmail");
                this.SetAttributeValue("requireapprovalforqueueemail", value);
                this.OnPropertyChanged("RequireApprovalForQueueEmail");
            }
        }

        /// <summary>
        /// Indicates whether Send As Other User privilege is enabled.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("requireapprovalforuseremail")]
        public System.Nullable<bool> RequireApprovalForUserEmail
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("requireapprovalforuseremail"); }
            set
            {
                this.OnPropertyChanging("RequireApprovalForUserEmail");
                this.SetAttributeValue("requireapprovalforuseremail", value);
                this.OnPropertyChanged("RequireApprovalForUserEmail");
            }
        }

        /// <summary>
        /// Flag to restrict Update on incident.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("restrictstatusupdate")]
        public System.Nullable<bool> RestrictStatusUpdate
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("restrictstatusupdate"); }
            set
            {
                this.OnPropertyChanging("RestrictStatusUpdate");
                this.SetAttributeValue("restrictstatusupdate", value);
                this.OnPropertyChanged("RestrictStatusUpdate");
            }
        }

        /// <summary>
        /// Unique identifier of the sample data import job.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sampledataimportid")]
        public System.Nullable<System.Guid> SampleDataImportId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("sampledataimportid"); }
            set
            {
                this.OnPropertyChanging("SampleDataImportId");
                this.SetAttributeValue("sampledataimportid", value);
                this.OnPropertyChanged("SampleDataImportId");
            }
        }

        /// <summary>
        /// Prefix used for custom entities and attributes.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("schemanameprefix")]
        public string SchemaNamePrefix
        {
            get { return this.GetAttributeValue<string>("schemanameprefix"); }
            set
            {
                this.OnPropertyChanging("SchemaNamePrefix");
                this.SetAttributeValue("schemanameprefix", value);
                this.OnPropertyChanged("SchemaNamePrefix");
            }
        }

        /// <summary>
        /// Information that specifies whether to share to previous owner on assign.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sharetopreviousowneronassign")]
        public System.Nullable<bool> ShareToPreviousOwnerOnAssign
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("sharetopreviousowneronassign"); }
            set
            {
                this.OnPropertyChanging("ShareToPreviousOwnerOnAssign");
                this.SetAttributeValue("sharetopreviousowneronassign", value);
                this.OnPropertyChanged("ShareToPreviousOwnerOnAssign");
            }
        }

        /// <summary>
        /// Information that specifies whether to display the week number in calendar displays throughout Microsoft CRM.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("showweeknumber")]
        public System.Nullable<bool> ShowWeekNumber
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("showweeknumber"); }
            set
            {
                this.OnPropertyChanging("ShowWeekNumber");
                this.SetAttributeValue("showweeknumber", value);
                this.OnPropertyChanged("ShowWeekNumber");
            }
        }

        /// <summary>
        /// CRM for Outlook Download URL
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("signupoutlookdownloadfwlink")]
        public string SignupOutlookDownloadFWLink
        {
            get { return this.GetAttributeValue<string>("signupoutlookdownloadfwlink"); }
            set
            {
                this.OnPropertyChanging("SignupOutlookDownloadFWLink");
                this.SetAttributeValue("signupoutlookdownloadfwlink", value);
                this.OnPropertyChanged("SignupOutlookDownloadFWLink");
            }
        }

        /// <summary>
        /// XML string that defines the navigation structure for the application.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sitemapxml")]
        [System.ObsoleteAttribute()]
        public string SiteMapXml
        {
            get { return this.GetAttributeValue<string>("sitemapxml"); }
            set
            {
                this.OnPropertyChanging("SiteMapXml");
                this.SetAttributeValue("sitemapxml", value);
                this.OnPropertyChanged("SiteMapXml");
            }
        }

        /// <summary>
        /// Contains the on hold case status values.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("slapausestates")]
        public string SlaPauseStates
        {
            get { return this.GetAttributeValue<string>("slapausestates"); }
            set
            {
                this.OnPropertyChanging("SlaPauseStates");
                this.SetAttributeValue("slapausestates", value);
                this.OnPropertyChanged("SlaPauseStates");
            }
        }

        /// <summary>
        /// Flag for whether the organization is using Social Insights.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("socialinsightsenabled")]
        public System.Nullable<bool> SocialInsightsEnabled
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("socialinsightsenabled"); }
            set
            {
                this.OnPropertyChanging("SocialInsightsEnabled");
                this.SetAttributeValue("socialinsightsenabled", value);
                this.OnPropertyChanged("SocialInsightsEnabled");
            }
        }

        /// <summary>
        /// Identifier for the Social Insights instance for the organization.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("socialinsightsinstance")]
        public string SocialInsightsInstance
        {
            get { return this.GetAttributeValue<string>("socialinsightsinstance"); }
            set
            {
                this.OnPropertyChanging("SocialInsightsInstance");
                this.SetAttributeValue("socialinsightsinstance", value);
                this.OnPropertyChanged("SocialInsightsInstance");
            }
        }

        /// <summary>
        /// Flag for whether the organization has accepted the Social Insights terms of use.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("socialinsightstermsaccepted")]
        public System.Nullable<bool> SocialInsightsTermsAccepted
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("socialinsightstermsaccepted"); }
            set
            {
                this.OnPropertyChanging("SocialInsightsTermsAccepted");
                this.SetAttributeValue("socialinsightstermsaccepted", value);
                this.OnPropertyChanged("SocialInsightsTermsAccepted");
            }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sortid")]
        public System.Nullable<int> SortId
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("sortid"); }
            set
            {
                this.OnPropertyChanging("SortId");
                this.SetAttributeValue("sortid", value);
                this.OnPropertyChanged("SortId");
            }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sqlaccessgroupid")]
        public System.Nullable<System.Guid> SqlAccessGroupId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("sqlaccessgroupid"); }
            set
            {
                this.OnPropertyChanging("SqlAccessGroupId");
                this.SetAttributeValue("sqlaccessgroupid", value);
                this.OnPropertyChanged("SqlAccessGroupId");
            }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sqlaccessgroupname")]
        public string SqlAccessGroupName
        {
            get { return this.GetAttributeValue<string>("sqlaccessgroupname"); }
            set
            {
                this.OnPropertyChanging("SqlAccessGroupName");
                this.SetAttributeValue("sqlaccessgroupname", value);
                this.OnPropertyChanged("SqlAccessGroupName");
            }
        }

        /// <summary>
        /// Setting for SQM data collection, 0 no, 1 yes enabled
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sqmenabled")]
        public System.Nullable<bool> SQMEnabled
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("sqmenabled"); }
            set
            {
                this.OnPropertyChanging("SQMEnabled");
                this.SetAttributeValue("sqmenabled", value);
                this.OnPropertyChanged("SQMEnabled");
            }
        }

        /// <summary>
        /// Unique identifier of the support user for the organization.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("supportuserid")]
        public System.Nullable<System.Guid> SupportUserId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("supportuserid"); }
            set
            {
                this.OnPropertyChanging("SupportUserId");
                this.SetAttributeValue("supportuserid", value);
                this.OnPropertyChanged("SupportUserId");
            }
        }

        /// <summary>
        /// Indicates whether SLA is suppressed.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("suppresssla")]
        public System.Nullable<bool> SuppressSLA
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("suppresssla"); }
            set
            {
                this.OnPropertyChanging("SuppressSLA");
                this.SetAttributeValue("suppresssla", value);
                this.OnPropertyChanged("SuppressSLA");
            }
        }

        /// <summary>
        /// Unique identifier of the system user for the organization.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("systemuserid")]
        public System.Nullable<System.Guid> SystemUserId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("systemuserid"); }
            set
            {
                this.OnPropertyChanging("SystemUserId");
                this.SetAttributeValue("systemuserid", value);
                this.OnPropertyChanged("SystemUserId");
            }
        }

        /// <summary>
        /// Maximum number of aggressive polling cycles executed for email auto-tagging when a new email is received.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("tagmaxaggressivecycles")]
        public System.Nullable<int> TagMaxAggressiveCycles
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("tagmaxaggressivecycles"); }
            set
            {
                this.OnPropertyChanging("TagMaxAggressiveCycles");
                this.SetAttributeValue("tagmaxaggressivecycles", value);
                this.OnPropertyChanged("TagMaxAggressiveCycles");
            }
        }

        /// <summary>
        /// Normal polling frequency used for email receive auto-tagging in outlook.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("tagpollingperiod")]
        public System.Nullable<int> TagPollingPeriod
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("tagpollingperiod"); }
            set
            {
                this.OnPropertyChanging("TagPollingPeriod");
                this.SetAttributeValue("tagpollingperiod", value);
                this.OnPropertyChanged("TagPollingPeriod");
            }
        }

        /// <summary>
        /// Information that specifies how the time is displayed throughout Microsoft CRM.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("timeformatcode")]
        public Microsoft.Xrm.Sdk.OptionSetValue TimeFormatCode
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("timeformatcode"); }
            set
            {
                this.OnPropertyChanging("TimeFormatCode");
                this.SetAttributeValue("timeformatcode", value);
                this.OnPropertyChanged("TimeFormatCode");
            }
        }

        /// <summary>
        /// Text for how time is displayed in Microsoft Dynamics CRM.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("timeformatstring")]
        public string TimeFormatString
        {
            get { return this.GetAttributeValue<string>("timeformatstring"); }
            set
            {
                this.OnPropertyChanging("TimeFormatString");
                this.SetAttributeValue("timeformatstring", value);
                this.OnPropertyChanged("TimeFormatString");
            }
        }

        /// <summary>
        /// Text for how the time separator is displayed throughout Microsoft Dynamics CRM.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("timeseparator")]
        public string TimeSeparator
        {
            get { return this.GetAttributeValue<string>("timeseparator"); }
            set
            {
                this.OnPropertyChanging("TimeSeparator");
                this.SetAttributeValue("timeseparator", value);
                this.OnPropertyChanged("TimeSeparator");
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
        /// Duration used for token expiration.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("tokenexpiry")]
        public System.Nullable<int> TokenExpiry
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("tokenexpiry"); }
            set
            {
                this.OnPropertyChanging("TokenExpiry");
                this.SetAttributeValue("tokenexpiry", value);
                this.OnPropertyChanged("TokenExpiry");
            }
        }

        /// <summary>
        /// Token key.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("tokenkey")]
        public string TokenKey
        {
            get { return this.GetAttributeValue<string>("tokenkey"); }
            set
            {
                this.OnPropertyChanging("TokenKey");
                this.SetAttributeValue("tokenkey", value);
                this.OnPropertyChanged("TokenKey");
            }
        }

        /// <summary>
        /// History list of tracking token prefixes.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("trackingprefix")]
        public string TrackingPrefix
        {
            get { return this.GetAttributeValue<string>("trackingprefix"); }
            set
            {
                this.OnPropertyChanging("TrackingPrefix");
                this.SetAttributeValue("trackingprefix", value);
                this.OnPropertyChanged("TrackingPrefix");
            }
        }

        /// <summary>
        /// Base number used to provide separate tracking token identifiers to users belonging to different deployments.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("trackingtokenidbase")]
        public System.Nullable<int> TrackingTokenIdBase
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("trackingtokenidbase"); }
            set
            {
                this.OnPropertyChanging("TrackingTokenIdBase");
                this.SetAttributeValue("trackingtokenidbase", value);
                this.OnPropertyChanged("TrackingTokenIdBase");
            }
        }

        /// <summary>
        /// Number of digits used to represent a tracking token identifier.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("trackingtokeniddigits")]
        public System.Nullable<int> TrackingTokenIdDigits
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("trackingtokeniddigits"); }
            set
            {
                this.OnPropertyChanging("TrackingTokenIdDigits");
                this.SetAttributeValue("trackingtokeniddigits", value);
                this.OnPropertyChanged("TrackingTokenIdDigits");
            }
        }

        /// <summary>
        /// Number of characters appended to invoice, quote, and order numbers.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("uniquespecifierlength")]
        public System.Nullable<int> UniqueSpecifierLength
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("uniquespecifierlength"); }
            set
            {
                this.OnPropertyChanging("UniqueSpecifierLength");
                this.SetAttributeValue("uniquespecifierlength", value);
                this.OnPropertyChanged("UniqueSpecifierLength");
            }
        }

        /// <summary>
        /// Flag indicates whether to Use Inbuilt Rule For DefaultPricelist.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("useinbuiltrulefordefaultpricelistselection")]
        public System.Nullable<bool> UseInbuiltRuleForDefaultPricelistSelection
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("useinbuiltrulefordefaultpricelistselection"); }
            set
            {
                this.OnPropertyChanging("UseInbuiltRuleForDefaultPricelistSelection");
                this.SetAttributeValue("useinbuiltrulefordefaultpricelistselection", value);
                this.OnPropertyChanged("UseInbuiltRuleForDefaultPricelistSelection");
            }
        }

        /// <summary>
        /// Use position hierarchy
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("usepositionhierarchy")]
        public System.Nullable<bool> UsePositionHierarchy
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("usepositionhierarchy"); }
            set
            {
                this.OnPropertyChanging("UsePositionHierarchy");
                this.SetAttributeValue("usepositionhierarchy", value);
                this.OnPropertyChanged("UsePositionHierarchy");
            }
        }

        /// <summary>
        /// The interval at which user access is checked for auditing.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("useraccessauditinginterval")]
        public System.Nullable<int> UserAccessAuditingInterval
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("useraccessauditinginterval"); }
            set
            {
                this.OnPropertyChanging("UserAccessAuditingInterval");
                this.SetAttributeValue("useraccessauditinginterval", value);
                this.OnPropertyChanged("UserAccessAuditingInterval");
            }
        }

        /// <summary>
        /// Indicates whether the read-optimized form should be enabled for this organization.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("usereadform")]
        public System.Nullable<bool> UseReadForm
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("usereadform"); }
            set
            {
                this.OnPropertyChanging("UseReadForm");
                this.SetAttributeValue("usereadform", value);
                this.OnPropertyChanged("UseReadForm");
            }
        }

        /// <summary>
        /// Unique identifier of the default group of users in the organization.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("usergroupid")]
        public System.Nullable<System.Guid> UserGroupId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("usergroupid"); }
            set
            {
                this.OnPropertyChanging("UserGroupId");
                this.SetAttributeValue("usergroupid", value);
                this.OnPropertyChanged("UserGroupId");
            }
        }

        /// <summary>
        /// Indicates default protocol selected for organization.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("useskypeprotocol")]
        public System.Nullable<bool> UseSkypeProtocol
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("useskypeprotocol"); }
            set
            {
                this.OnPropertyChanging("UseSkypeProtocol");
                this.SetAttributeValue("useskypeprotocol", value);
                this.OnPropertyChanged("UseSkypeProtocol");
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
        /// Hash of the V3 callout configuration file.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("v3calloutconfighash")]
        public string V3CalloutConfigHash
        {
            get { return this.GetAttributeValue<string>("v3calloutconfighash"); }
        }

        /// <summary>
        /// Version number of the organization.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
        public System.Nullable<long> VersionNumber
        {
            get { return this.GetAttributeValue<System.Nullable<long>>("versionnumber"); }
        }

        /// <summary>
        /// Designated first day of the week throughout Microsoft Dynamics CRM.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("weekstartdaycode")]
        public Microsoft.Xrm.Sdk.OptionSetValue WeekStartDayCode
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("weekstartdaycode"); }
            set
            {
                this.OnPropertyChanging("WeekStartDayCode");
                this.SetAttributeValue("weekstartdaycode", value);
                this.OnPropertyChanged("WeekStartDayCode");
            }
        }

        /// <summary>
        /// Denotes the Yammer group ID
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("yammergroupid")]
        public System.Nullable<int> YammerGroupId
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("yammergroupid"); }
            set
            {
                this.OnPropertyChanging("YammerGroupId");
                this.SetAttributeValue("yammergroupid", value);
                this.OnPropertyChanged("YammerGroupId");
            }
        }

        /// <summary>
        /// Denotes the Yammer network permalink
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("yammernetworkpermalink")]
        public string YammerNetworkPermalink
        {
            get { return this.GetAttributeValue<string>("yammernetworkpermalink"); }
            set
            {
                this.OnPropertyChanging("YammerNetworkPermalink");
                this.SetAttributeValue("yammernetworkpermalink", value);
                this.OnPropertyChanged("YammerNetworkPermalink");
            }
        }

        /// <summary>
        /// Denotes whether the OAuth access token for Yammer network has expired
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("yammeroauthaccesstokenexpired")]
        public System.Nullable<bool> YammerOAuthAccessTokenExpired
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("yammeroauthaccesstokenexpired"); }
            set
            {
                this.OnPropertyChanging("YammerOAuthAccessTokenExpired");
                this.SetAttributeValue("yammeroauthaccesstokenexpired", value);
                this.OnPropertyChanged("YammerOAuthAccessTokenExpired");
            }
        }

        /// <summary>
        /// Internal Use Only
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("yammerpostmethod")]
        public Microsoft.Xrm.Sdk.OptionSetValue YammerPostMethod
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("yammerpostmethod"); }
            set
            {
                this.OnPropertyChanging("YammerPostMethod");
                this.SetAttributeValue("yammerpostmethod", value);
                this.OnPropertyChanged("YammerPostMethod");
            }
        }

        /// <summary>
        /// Information that specifies how the first week of the year is specified in Microsoft Dynamics CRM.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("yearstartweekcode")]
        public System.Nullable<int> YearStartWeekCode
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("yearstartweekcode"); }
            set
            {
                this.OnPropertyChanging("YearStartWeekCode");
                this.SetAttributeValue("yearstartweekcode", value);
                this.OnPropertyChanged("YearStartWeekCode");
            }
        }

        /// <summary>
        /// 1:N dynamicproperty_organization
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("dynamicproperty_organization")]
        public System.Collections.Generic.IEnumerable<DynamicProperty> dynamicproperty_organization
        {
            get { return this.GetRelatedEntities<DynamicProperty>("dynamicproperty_organization", null); }
            set
            {
                this.OnPropertyChanging("dynamicproperty_organization");
                this.SetRelatedEntities<DynamicProperty>("dynamicproperty_organization", null, value);
                this.OnPropertyChanged("dynamicproperty_organization");
            }
        }

        /// <summary>
        /// 1:N DynamicPropertyAssociation_organization
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("DynamicPropertyAssociation_organization")]
        public System.Collections.Generic.IEnumerable<DynamicPropertyAssociation> DynamicPropertyAssociation_organization
        {
            get { return this.GetRelatedEntities<DynamicPropertyAssociation>("DynamicPropertyAssociation_organization", null); }
            set
            {
                this.OnPropertyChanging("DynamicPropertyAssociation_organization");
                this.SetRelatedEntities<DynamicPropertyAssociation>("DynamicPropertyAssociation_organization", null, value);
                this.OnPropertyChanged("DynamicPropertyAssociation_organization");
            }
        }

        /// <summary>
        /// 1:N DynamicPropertyOptionSetItem_organization
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("DynamicPropertyOptionSetItem_organization")]
        public System.Collections.Generic.IEnumerable<DynamicPropertyOptionSetItem> DynamicPropertyOptionSetItem_organization
        {
            get { return this.GetRelatedEntities<DynamicPropertyOptionSetItem>("DynamicPropertyOptionSetItem_organization", null); }
            set
            {
                this.OnPropertyChanging("DynamicPropertyOptionSetItem_organization");
                this.SetRelatedEntities<DynamicPropertyOptionSetItem>("DynamicPropertyOptionSetItem_organization", null, value);
                this.OnPropertyChanged("DynamicPropertyOptionSetItem_organization");
            }
        }

        /// <summary>
        /// 1:N entitlementchannel_organization
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("entitlementchannel_organization")]
        public System.Collections.Generic.IEnumerable<EntitlementChannel> entitlementchannel_organization
        {
            get { return this.GetRelatedEntities<EntitlementChannel>("entitlementchannel_organization", null); }
            set
            {
                this.OnPropertyChanging("entitlementchannel_organization");
                this.SetRelatedEntities<EntitlementChannel>("entitlementchannel_organization", null, value);
                this.OnPropertyChanged("entitlementchannel_organization");
            }
        }

        /// <summary>
        /// 1:N entitlementtemplate_organization
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("entitlementtemplate_organization")]
        public System.Collections.Generic.IEnumerable<EntitlementTemplate> entitlementtemplate_organization
        {
            get { return this.GetRelatedEntities<EntitlementTemplate>("entitlementtemplate_organization", null); }
            set
            {
                this.OnPropertyChanging("entitlementtemplate_organization");
                this.SetRelatedEntities<EntitlementTemplate>("entitlementtemplate_organization", null, value);
                this.OnPropertyChanged("entitlementtemplate_organization");
            }
        }

        /// <summary>
        /// 1:N entitlementtemplatechannel_organization
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("entitlementtemplatechannel_organization")]
        public System.Collections.Generic.IEnumerable<EntitlementTemplateChannel> entitlementtemplatechannel_organization
        {
            get { return this.GetRelatedEntities<EntitlementTemplateChannel>("entitlementtemplatechannel_organization", null); }
            set
            {
                this.OnPropertyChanging("entitlementtemplatechannel_organization");
                this.SetRelatedEntities<EntitlementTemplateChannel>("entitlementtemplatechannel_organization", null, value);
                this.OnPropertyChanged("entitlementtemplatechannel_organization");
            }
        }

        /// <summary>
        /// 1:N lk_fieldsecurityprofile_organizationid
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_fieldsecurityprofile_organizationid")]
        public System.Collections.Generic.IEnumerable<FieldSecurityProfile> lk_fieldsecurityprofile_organizationid
        {
            get { return this.GetRelatedEntities<FieldSecurityProfile>("lk_fieldsecurityprofile_organizationid", null); }
            set
            {
                this.OnPropertyChanging("lk_fieldsecurityprofile_organizationid");
                this.SetRelatedEntities<FieldSecurityProfile>("lk_fieldsecurityprofile_organizationid", null, value);
                this.OnPropertyChanged("lk_fieldsecurityprofile_organizationid");
            }
        }

        /// <summary>
        /// 1:N lk_organizationui_organizationid
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_organizationui_organizationid")]
        public System.Collections.Generic.IEnumerable<OrganizationUI> lk_organizationui_organizationid
        {
            get { return this.GetRelatedEntities<OrganizationUI>("lk_organizationui_organizationid", null); }
            set
            {
                this.OnPropertyChanging("lk_organizationui_organizationid");
                this.SetRelatedEntities<OrganizationUI>("lk_organizationui_organizationid", null, value);
                this.OnPropertyChanged("lk_organizationui_organizationid");
            }
        }

        /// <summary>
        /// 1:N lk_principalobjectattributeaccess_organizationid
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_principalobjectattributeaccess_organizationid")]
        public System.Collections.Generic.IEnumerable<PrincipalObjectAttributeAccess> lk_principalobjectattributeaccess_organizationid
        {
            get { return this.GetRelatedEntities<PrincipalObjectAttributeAccess>("lk_principalobjectattributeaccess_organizationid", null); }
            set
            {
                this.OnPropertyChanging("lk_principalobjectattributeaccess_organizationid");
                this.SetRelatedEntities<PrincipalObjectAttributeAccess>("lk_principalobjectattributeaccess_organizationid", null, value);
                this.OnPropertyChanged("lk_principalobjectattributeaccess_organizationid");
            }
        }

        /// <summary>
        /// 1:N Organization_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Organization_AsyncOperations")]
        public System.Collections.Generic.IEnumerable<AsyncOperation> Organization_AsyncOperations
        {
            get { return this.GetRelatedEntities<AsyncOperation>("Organization_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("Organization_AsyncOperations");
                this.SetRelatedEntities<AsyncOperation>("Organization_AsyncOperations", null, value);
                this.OnPropertyChanged("Organization_AsyncOperations");
            }
        }

        /// <summary>
        /// 1:N organization_attributemap
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_attributemap")]
        public System.Collections.Generic.IEnumerable<AttributeMap> organization_attributemap
        {
            get { return this.GetRelatedEntities<AttributeMap>("organization_attributemap", null); }
            set
            {
                this.OnPropertyChanging("organization_attributemap");
                this.SetRelatedEntities<AttributeMap>("organization_attributemap", null, value);
                this.OnPropertyChanged("organization_attributemap");
            }
        }

        /// <summary>
        /// 1:N Organization_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Organization_BulkDeleteFailures")]
        public System.Collections.Generic.IEnumerable<BulkDeleteFailure> Organization_BulkDeleteFailures
        {
            get { return this.GetRelatedEntities<BulkDeleteFailure>("Organization_BulkDeleteFailures", null); }
            set
            {
                this.OnPropertyChanging("Organization_BulkDeleteFailures");
                this.SetRelatedEntities<BulkDeleteFailure>("Organization_BulkDeleteFailures", null, value);
                this.OnPropertyChanged("Organization_BulkDeleteFailures");
            }
        }

        /// <summary>
        /// 1:N organization_business_unit_news_articles
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_business_unit_news_articles")]
        public System.Collections.Generic.IEnumerable<BusinessUnitNewsArticle> organization_business_unit_news_articles
        {
            get { return this.GetRelatedEntities<BusinessUnitNewsArticle>("organization_business_unit_news_articles", null); }
            set
            {
                this.OnPropertyChanging("organization_business_unit_news_articles");
                this.SetRelatedEntities<BusinessUnitNewsArticle>("organization_business_unit_news_articles", null, value);
                this.OnPropertyChanged("organization_business_unit_news_articles");
            }
        }

        /// <summary>
        /// 1:N organization_business_units
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_business_units")]
        public System.Collections.Generic.IEnumerable<BusinessUnit> organization_business_units
        {
            get { return this.GetRelatedEntities<BusinessUnit>("organization_business_units", null); }
            set
            {
                this.OnPropertyChanging("organization_business_units");
                this.SetRelatedEntities<BusinessUnit>("organization_business_units", null, value);
                this.OnPropertyChanged("organization_business_units");
            }
        }

        /// <summary>
        /// 1:N organization_calendars
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_calendars")]
        public System.Collections.Generic.IEnumerable<Calendar> organization_calendars
        {
            get { return this.GetRelatedEntities<Calendar>("organization_calendars", null); }
            set
            {
                this.OnPropertyChanging("organization_calendars");
                this.SetRelatedEntities<Calendar>("organization_calendars", null, value);
                this.OnPropertyChanged("organization_calendars");
            }
        }

        /// <summary>
        /// 1:N organization_competitors
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_competitors")]
        public System.Collections.Generic.IEnumerable<Competitor> organization_competitors
        {
            get { return this.GetRelatedEntities<Competitor>("organization_competitors", null); }
            set
            {
                this.OnPropertyChanging("organization_competitors");
                this.SetRelatedEntities<Competitor>("organization_competitors", null, value);
                this.OnPropertyChanged("organization_competitors");
            }
        }

        /// <summary>
        /// 1:N organization_connection_roles
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_connection_roles")]
        public System.Collections.Generic.IEnumerable<ConnectionRole> organization_connection_roles
        {
            get { return this.GetRelatedEntities<ConnectionRole>("organization_connection_roles", null); }
            set
            {
                this.OnPropertyChanging("organization_connection_roles");
                this.SetRelatedEntities<ConnectionRole>("organization_connection_roles", null, value);
                this.OnPropertyChanged("organization_connection_roles");
            }
        }

        /// <summary>
        /// 1:N organization_constraint_based_groups
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_constraint_based_groups")]
        public System.Collections.Generic.IEnumerable<ConstraintBasedGroup> organization_constraint_based_groups
        {
            get { return this.GetRelatedEntities<ConstraintBasedGroup>("organization_constraint_based_groups", null); }
            set
            {
                this.OnPropertyChanging("organization_constraint_based_groups");
                this.SetRelatedEntities<ConstraintBasedGroup>("organization_constraint_based_groups", null, value);
                this.OnPropertyChanged("organization_constraint_based_groups");
            }
        }

        /// <summary>
        /// 1:N organization_contract_templates
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_contract_templates")]
        public System.Collections.Generic.IEnumerable<ContractTemplate> organization_contract_templates
        {
            get { return this.GetRelatedEntities<ContractTemplate>("organization_contract_templates", null); }
            set
            {
                this.OnPropertyChanging("organization_contract_templates");
                this.SetRelatedEntities<ContractTemplate>("organization_contract_templates", null, value);
                this.OnPropertyChanged("organization_contract_templates");
            }
        }

        /// <summary>
        /// 1:N organization_custom_displaystrings
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_custom_displaystrings")]
        public System.Collections.Generic.IEnumerable<DisplayString> organization_custom_displaystrings
        {
            get { return this.GetRelatedEntities<DisplayString>("organization_custom_displaystrings", null); }
            set
            {
                this.OnPropertyChanging("organization_custom_displaystrings");
                this.SetRelatedEntities<DisplayString>("organization_custom_displaystrings", null, value);
                this.OnPropertyChanged("organization_custom_displaystrings");
            }
        }

        /// <summary>
        /// 1:N organization_discount_types
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_discount_types")]
        public System.Collections.Generic.IEnumerable<DiscountType> organization_discount_types
        {
            get { return this.GetRelatedEntities<DiscountType>("organization_discount_types", null); }
            set
            {
                this.OnPropertyChanging("organization_discount_types");
                this.SetRelatedEntities<DiscountType>("organization_discount_types", null, value);
                this.OnPropertyChanged("organization_discount_types");
            }
        }

        /// <summary>
        /// 1:N organization_emailserverprofile
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_emailserverprofile")]
        public System.Collections.Generic.IEnumerable<EmailServerProfile> organization_emailserverprofile
        {
            get { return this.GetRelatedEntities<EmailServerProfile>("organization_emailserverprofile", null); }
            set
            {
                this.OnPropertyChanging("organization_emailserverprofile");
                this.SetRelatedEntities<EmailServerProfile>("organization_emailserverprofile", null, value);
                this.OnPropertyChanged("organization_emailserverprofile");
            }
        }

        /// <summary>
        /// 1:N organization_entitymap
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_entitymap")]
        public System.Collections.Generic.IEnumerable<EntityMap> organization_entitymap
        {
            get { return this.GetRelatedEntities<EntityMap>("organization_entitymap", null); }
            set
            {
                this.OnPropertyChanging("organization_entitymap");
                this.SetRelatedEntities<EntityMap>("organization_entitymap", null, value);
                this.OnPropertyChanged("organization_entitymap");
            }
        }

        /// <summary>
        /// 1:N organization_equipment
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_equipment")]
        public System.Collections.Generic.IEnumerable<Equipment> organization_equipment
        {
            get { return this.GetRelatedEntities<Equipment>("organization_equipment", null); }
            set
            {
                this.OnPropertyChanging("organization_equipment");
                this.SetRelatedEntities<Equipment>("organization_equipment", null, value);
                this.OnPropertyChanged("organization_equipment");
            }
        }

        /// <summary>
        /// 1:N organization_hierarchyrules
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_hierarchyrules")]
        public System.Collections.Generic.IEnumerable<HierarchyRule> organization_hierarchyrules
        {
            get { return this.GetRelatedEntities<HierarchyRule>("organization_hierarchyrules", null); }
            set
            {
                this.OnPropertyChanging("organization_hierarchyrules");
                this.SetRelatedEntities<HierarchyRule>("organization_hierarchyrules", null, value);
                this.OnPropertyChanged("organization_hierarchyrules");
            }
        }

        /// <summary>
        /// 1:N organization_importjob
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_importjob")]
        public System.Collections.Generic.IEnumerable<ImportJob> organization_importjob
        {
            get { return this.GetRelatedEntities<ImportJob>("organization_importjob", null); }
            set
            {
                this.OnPropertyChanging("organization_importjob");
                this.SetRelatedEntities<ImportJob>("organization_importjob", null, value);
                this.OnPropertyChanged("organization_importjob");
            }
        }

        /// <summary>
        /// 1:N organization_isvconfigs
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_isvconfigs")]
        public System.Collections.Generic.IEnumerable<IsvConfig> organization_isvconfigs
        {
            get { return this.GetRelatedEntities<IsvConfig>("organization_isvconfigs", null); }
            set
            {
                this.OnPropertyChanging("organization_isvconfigs");
                this.SetRelatedEntities<IsvConfig>("organization_isvconfigs", null, value);
                this.OnPropertyChanged("organization_isvconfigs");
            }
        }

        /// <summary>
        /// 1:N organization_kb_article_templates
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_kb_article_templates")]
        public System.Collections.Generic.IEnumerable<KbArticleTemplate> organization_kb_article_templates
        {
            get { return this.GetRelatedEntities<KbArticleTemplate>("organization_kb_article_templates", null); }
            set
            {
                this.OnPropertyChanging("organization_kb_article_templates");
                this.SetRelatedEntities<KbArticleTemplate>("organization_kb_article_templates", null, value);
                this.OnPropertyChanged("organization_kb_article_templates");
            }
        }

        /// <summary>
        /// 1:N organization_kb_articles
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_kb_articles")]
        public System.Collections.Generic.IEnumerable<KbArticle> organization_kb_articles
        {
            get { return this.GetRelatedEntities<KbArticle>("organization_kb_articles", null); }
            set
            {
                this.OnPropertyChanging("organization_kb_articles");
                this.SetRelatedEntities<KbArticle>("organization_kb_articles", null, value);
                this.OnPropertyChanged("organization_kb_articles");
            }
        }

        /// <summary>
        /// 1:N organization_licenses
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_licenses")]
        public System.Collections.Generic.IEnumerable<License> organization_licenses
        {
            get { return this.GetRelatedEntities<License>("organization_licenses", null); }
            set
            {
                this.OnPropertyChanging("organization_licenses");
                this.SetRelatedEntities<License>("organization_licenses", null, value);
                this.OnPropertyChanged("organization_licenses");
            }
        }

        /// <summary>
        /// 1:N organization_mailbox
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_mailbox")]
        public System.Collections.Generic.IEnumerable<Mailbox> organization_mailbox
        {
            get { return this.GetRelatedEntities<Mailbox>("organization_mailbox", null); }
            set
            {
                this.OnPropertyChanging("organization_mailbox");
                this.SetRelatedEntities<Mailbox>("organization_mailbox", null, value);
                this.OnPropertyChanged("organization_mailbox");
            }
        }

        /// <summary>
        /// 1:N organization_metric
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_metric")]
        public System.Collections.Generic.IEnumerable<Metric> organization_metric
        {
            get { return this.GetRelatedEntities<Metric>("organization_metric", null); }
            set
            {
                this.OnPropertyChanging("organization_metric");
                this.SetRelatedEntities<Metric>("organization_metric", null, value);
                this.OnPropertyChanged("organization_metric");
            }
        }

        /// <summary>
        /// 1:N organization_msdyn_postconfig
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_msdyn_postconfig")]
        public System.Collections.Generic.IEnumerable<msdyn_PostConfig> organization_msdyn_postconfig
        {
            get { return this.GetRelatedEntities<msdyn_PostConfig>("organization_msdyn_postconfig", null); }
            set
            {
                this.OnPropertyChanging("organization_msdyn_postconfig");
                this.SetRelatedEntities<msdyn_PostConfig>("organization_msdyn_postconfig", null, value);
                this.OnPropertyChanged("organization_msdyn_postconfig");
            }
        }

        /// <summary>
        /// 1:N organization_msdyn_postruleconfig
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_msdyn_postruleconfig")]
        public System.Collections.Generic.IEnumerable<msdyn_PostRuleConfig> organization_msdyn_postruleconfig
        {
            get { return this.GetRelatedEntities<msdyn_PostRuleConfig>("organization_msdyn_postruleconfig", null); }
            set
            {
                this.OnPropertyChanging("organization_msdyn_postruleconfig");
                this.SetRelatedEntities<msdyn_PostRuleConfig>("organization_msdyn_postruleconfig", null, value);
                this.OnPropertyChanged("organization_msdyn_postruleconfig");
            }
        }

        /// <summary>
        /// 1:N organization_msdyn_wallsavedquery
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_msdyn_wallsavedquery")]
        public System.Collections.Generic.IEnumerable<msdyn_wallsavedquery> organization_msdyn_wallsavedquery
        {
            get { return this.GetRelatedEntities<msdyn_wallsavedquery>("organization_msdyn_wallsavedquery", null); }
            set
            {
                this.OnPropertyChanging("organization_msdyn_wallsavedquery");
                this.SetRelatedEntities<msdyn_wallsavedquery>("organization_msdyn_wallsavedquery", null, value);
                this.OnPropertyChanged("organization_msdyn_wallsavedquery");
            }
        }

        /// <summary>
        /// 1:N organization_pluginassembly
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_pluginassembly")]
        public System.Collections.Generic.IEnumerable<PluginAssembly> organization_pluginassembly
        {
            get { return this.GetRelatedEntities<PluginAssembly>("organization_pluginassembly", null); }
            set
            {
                this.OnPropertyChanging("organization_pluginassembly");
                this.SetRelatedEntities<PluginAssembly>("organization_pluginassembly", null, value);
                this.OnPropertyChanged("organization_pluginassembly");
            }
        }

        /// <summary>
        /// 1:N organization_plugintype
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_plugintype")]
        public System.Collections.Generic.IEnumerable<PluginType> organization_plugintype
        {
            get { return this.GetRelatedEntities<PluginType>("organization_plugintype", null); }
            set
            {
                this.OnPropertyChanging("organization_plugintype");
                this.SetRelatedEntities<PluginType>("organization_plugintype", null, value);
                this.OnPropertyChanged("organization_plugintype");
            }
        }

        /// <summary>
        /// 1:N organization_plugintypestatistic
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_plugintypestatistic")]
        public System.Collections.Generic.IEnumerable<PluginTypeStatistic> organization_plugintypestatistic
        {
            get { return this.GetRelatedEntities<PluginTypeStatistic>("organization_plugintypestatistic", null); }
            set
            {
                this.OnPropertyChanging("organization_plugintypestatistic");
                this.SetRelatedEntities<PluginTypeStatistic>("organization_plugintypestatistic", null, value);
                this.OnPropertyChanged("organization_plugintypestatistic");
            }
        }

        /// <summary>
        /// 1:N organization_position
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_position")]
        public System.Collections.Generic.IEnumerable<Position> organization_position
        {
            get { return this.GetRelatedEntities<Position>("organization_position", null); }
            set
            {
                this.OnPropertyChanging("organization_position");
                this.SetRelatedEntities<Position>("organization_position", null, value);
                this.OnPropertyChanged("organization_position");
            }
        }

        /// <summary>
        /// 1:N organization_post
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_post")]
        public System.Collections.Generic.IEnumerable<Post> organization_post
        {
            get { return this.GetRelatedEntities<Post>("organization_post", null); }
            set
            {
                this.OnPropertyChanging("organization_post");
                this.SetRelatedEntities<Post>("organization_post", null, value);
                this.OnPropertyChanged("organization_post");
            }
        }

        /// <summary>
        /// 1:N organization_PostComment
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_PostComment")]
        public System.Collections.Generic.IEnumerable<PostComment> organization_PostComment
        {
            get { return this.GetRelatedEntities<PostComment>("organization_PostComment", null); }
            set
            {
                this.OnPropertyChanging("organization_PostComment");
                this.SetRelatedEntities<PostComment>("organization_PostComment", null, value);
                this.OnPropertyChanged("organization_PostComment");
            }
        }

        /// <summary>
        /// 1:N organization_postlike
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_postlike")]
        public System.Collections.Generic.IEnumerable<PostLike> organization_postlike
        {
            get { return this.GetRelatedEntities<PostLike>("organization_postlike", null); }
            set
            {
                this.OnPropertyChanging("organization_postlike");
                this.SetRelatedEntities<PostLike>("organization_postlike", null, value);
                this.OnPropertyChanged("organization_postlike");
            }
        }

        /// <summary>
        /// 1:N organization_price_levels
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_price_levels")]
        public System.Collections.Generic.IEnumerable<PriceLevel> organization_price_levels
        {
            get { return this.GetRelatedEntities<PriceLevel>("organization_price_levels", null); }
            set
            {
                this.OnPropertyChanging("organization_price_levels");
                this.SetRelatedEntities<PriceLevel>("organization_price_levels", null, value);
                this.OnPropertyChanged("organization_price_levels");
            }
        }

        /// <summary>
        /// 1:N organization_ProductAssociation
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_ProductAssociation")]
        public System.Collections.Generic.IEnumerable<ProductAssociation> organization_ProductAssociation
        {
            get { return this.GetRelatedEntities<ProductAssociation>("organization_ProductAssociation", null); }
            set
            {
                this.OnPropertyChanging("organization_ProductAssociation");
                this.SetRelatedEntities<ProductAssociation>("organization_ProductAssociation", null, value);
                this.OnPropertyChanged("organization_ProductAssociation");
            }
        }

        /// <summary>
        /// 1:N organization_products
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_products")]
        public System.Collections.Generic.IEnumerable<Product> organization_products
        {
            get { return this.GetRelatedEntities<Product>("organization_products", null); }
            set
            {
                this.OnPropertyChanging("organization_products");
                this.SetRelatedEntities<Product>("organization_products", null, value);
                this.OnPropertyChanged("organization_products");
            }
        }

        /// <summary>
        /// 1:N organization_ProductSubstitute
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_ProductSubstitute")]
        public System.Collections.Generic.IEnumerable<ProductSubstitute> organization_ProductSubstitute
        {
            get { return this.GetRelatedEntities<ProductSubstitute>("organization_ProductSubstitute", null); }
            set
            {
                this.OnPropertyChanging("organization_ProductSubstitute");
                this.SetRelatedEntities<ProductSubstitute>("organization_ProductSubstitute", null, value);
                this.OnPropertyChanged("organization_ProductSubstitute");
            }
        }

        /// <summary>
        /// 1:N organization_publisher
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_publisher")]
        public System.Collections.Generic.IEnumerable<Publisher> organization_publisher
        {
            get { return this.GetRelatedEntities<Publisher>("organization_publisher", null); }
            set
            {
                this.OnPropertyChanging("organization_publisher");
                this.SetRelatedEntities<Publisher>("organization_publisher", null, value);
                this.OnPropertyChanged("organization_publisher");
            }
        }

        /// <summary>
        /// 1:N organization_queueitems
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_queueitems")]
        public System.Collections.Generic.IEnumerable<QueueItem> organization_queueitems
        {
            get { return this.GetRelatedEntities<QueueItem>("organization_queueitems", null); }
            set
            {
                this.OnPropertyChanging("organization_queueitems");
                this.SetRelatedEntities<QueueItem>("organization_queueitems", null, value);
                this.OnPropertyChanged("organization_queueitems");
            }
        }

        /// <summary>
        /// 1:N organization_queues
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_queues")]
        public System.Collections.Generic.IEnumerable<Queue> organization_queues
        {
            get { return this.GetRelatedEntities<Queue>("organization_queues", null); }
            set
            {
                this.OnPropertyChanging("organization_queues");
                this.SetRelatedEntities<Queue>("organization_queues", null, value);
                this.OnPropertyChanged("organization_queues");
            }
        }

        /// <summary>
        /// 1:N organization_relationship_roles
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_relationship_roles")]
        public System.Collections.Generic.IEnumerable<RelationshipRole> organization_relationship_roles
        {
            get { return this.GetRelatedEntities<RelationshipRole>("organization_relationship_roles", null); }
            set
            {
                this.OnPropertyChanging("organization_relationship_roles");
                this.SetRelatedEntities<RelationshipRole>("organization_relationship_roles", null, value);
                this.OnPropertyChanged("organization_relationship_roles");
            }
        }

        /// <summary>
        /// 1:N organization_resource_groups
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_resource_groups")]
        public System.Collections.Generic.IEnumerable<ResourceGroup> organization_resource_groups
        {
            get { return this.GetRelatedEntities<ResourceGroup>("organization_resource_groups", null); }
            set
            {
                this.OnPropertyChanging("organization_resource_groups");
                this.SetRelatedEntities<ResourceGroup>("organization_resource_groups", null, value);
                this.OnPropertyChanged("organization_resource_groups");
            }
        }

        /// <summary>
        /// 1:N organization_resource_specs
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_resource_specs")]
        public System.Collections.Generic.IEnumerable<ResourceSpec> organization_resource_specs
        {
            get { return this.GetRelatedEntities<ResourceSpec>("organization_resource_specs", null); }
            set
            {
                this.OnPropertyChanging("organization_resource_specs");
                this.SetRelatedEntities<ResourceSpec>("organization_resource_specs", null, value);
                this.OnPropertyChanged("organization_resource_specs");
            }
        }

        /// <summary>
        /// 1:N organization_resources
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_resources")]
        public System.Collections.Generic.IEnumerable<Resource> organization_resources
        {
            get { return this.GetRelatedEntities<Resource>("organization_resources", null); }
            set
            {
                this.OnPropertyChanging("organization_resources");
                this.SetRelatedEntities<Resource>("organization_resources", null, value);
                this.OnPropertyChanged("organization_resources");
            }
        }

        /// <summary>
        /// 1:N organization_ribbon_customization
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_ribbon_customization")]
        public System.Collections.Generic.IEnumerable<RibbonCustomization> organization_ribbon_customization
        {
            get { return this.GetRelatedEntities<RibbonCustomization>("organization_ribbon_customization", null); }
            set
            {
                this.OnPropertyChanging("organization_ribbon_customization");
                this.SetRelatedEntities<RibbonCustomization>("organization_ribbon_customization", null, value);
                this.OnPropertyChanged("organization_ribbon_customization");
            }
        }

        /// <summary>
        /// 1:N organization_roles
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_roles")]
        public System.Collections.Generic.IEnumerable<Role> organization_roles
        {
            get { return this.GetRelatedEntities<Role>("organization_roles", null); }
            set
            {
                this.OnPropertyChanging("organization_roles");
                this.SetRelatedEntities<Role>("organization_roles", null, value);
                this.OnPropertyChanged("organization_roles");
            }
        }

        /// <summary>
        /// 1:N organization_routingruleitems
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_routingruleitems")]
        public System.Collections.Generic.IEnumerable<RoutingRuleItem> organization_routingruleitems
        {
            get { return this.GetRelatedEntities<RoutingRuleItem>("organization_routingruleitems", null); }
            set
            {
                this.OnPropertyChanging("organization_routingruleitems");
                this.SetRelatedEntities<RoutingRuleItem>("organization_routingruleitems", null, value);
                this.OnPropertyChanged("organization_routingruleitems");
            }
        }

        /// <summary>
        /// 1:N organization_RoutingRules
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_RoutingRules")]
        public System.Collections.Generic.IEnumerable<RoutingRule> organization_RoutingRules
        {
            get { return this.GetRelatedEntities<RoutingRule>("organization_RoutingRules", null); }
            set
            {
                this.OnPropertyChanging("organization_RoutingRules");
                this.SetRelatedEntities<RoutingRule>("organization_RoutingRules", null, value);
                this.OnPropertyChanged("organization_RoutingRules");
            }
        }

        /// <summary>
        /// 1:N organization_sales_literature
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_sales_literature")]
        public System.Collections.Generic.IEnumerable<SalesLiterature> organization_sales_literature
        {
            get { return this.GetRelatedEntities<SalesLiterature>("organization_sales_literature", null); }
            set
            {
                this.OnPropertyChanging("organization_sales_literature");
                this.SetRelatedEntities<SalesLiterature>("organization_sales_literature", null, value);
                this.OnPropertyChanged("organization_sales_literature");
            }
        }

        /// <summary>
        /// 1:N organization_saved_queries
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_saved_queries")]
        public System.Collections.Generic.IEnumerable<SavedQuery> organization_saved_queries
        {
            get { return this.GetRelatedEntities<SavedQuery>("organization_saved_queries", null); }
            set
            {
                this.OnPropertyChanging("organization_saved_queries");
                this.SetRelatedEntities<SavedQuery>("organization_saved_queries", null, value);
                this.OnPropertyChanged("organization_saved_queries");
            }
        }

        /// <summary>
        /// 1:N organization_saved_query_visualizations
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_saved_query_visualizations")]
        public System.Collections.Generic.IEnumerable<SavedQueryVisualization> organization_saved_query_visualizations
        {
            get { return this.GetRelatedEntities<SavedQueryVisualization>("organization_saved_query_visualizations", null); }
            set
            {
                this.OnPropertyChanging("organization_saved_query_visualizations");
                this.SetRelatedEntities<SavedQueryVisualization>("organization_saved_query_visualizations", null, value);
                this.OnPropertyChanged("organization_saved_query_visualizations");
            }
        }

        /// <summary>
        /// 1:N organization_sdkmessage
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_sdkmessage")]
        public System.Collections.Generic.IEnumerable<SdkMessage> organization_sdkmessage
        {
            get { return this.GetRelatedEntities<SdkMessage>("organization_sdkmessage", null); }
            set
            {
                this.OnPropertyChanging("organization_sdkmessage");
                this.SetRelatedEntities<SdkMessage>("organization_sdkmessage", null, value);
                this.OnPropertyChanged("organization_sdkmessage");
            }
        }

        /// <summary>
        /// 1:N organization_sdkmessagefilter
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_sdkmessagefilter")]
        public System.Collections.Generic.IEnumerable<SdkMessageFilter> organization_sdkmessagefilter
        {
            get { return this.GetRelatedEntities<SdkMessageFilter>("organization_sdkmessagefilter", null); }
            set
            {
                this.OnPropertyChanging("organization_sdkmessagefilter");
                this.SetRelatedEntities<SdkMessageFilter>("organization_sdkmessagefilter", null, value);
                this.OnPropertyChanged("organization_sdkmessagefilter");
            }
        }

        /// <summary>
        /// 1:N organization_sdkmessagepair
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_sdkmessagepair")]
        public System.Collections.Generic.IEnumerable<SdkMessagePair> organization_sdkmessagepair
        {
            get { return this.GetRelatedEntities<SdkMessagePair>("organization_sdkmessagepair", null); }
            set
            {
                this.OnPropertyChanging("organization_sdkmessagepair");
                this.SetRelatedEntities<SdkMessagePair>("organization_sdkmessagepair", null, value);
                this.OnPropertyChanged("organization_sdkmessagepair");
            }
        }

        /// <summary>
        /// 1:N organization_sdkmessageprocessingstep
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_sdkmessageprocessingstep")]
        public System.Collections.Generic.IEnumerable<SdkMessageProcessingStep> organization_sdkmessageprocessingstep
        {
            get { return this.GetRelatedEntities<SdkMessageProcessingStep>("organization_sdkmessageprocessingstep", null); }
            set
            {
                this.OnPropertyChanging("organization_sdkmessageprocessingstep");
                this.SetRelatedEntities<SdkMessageProcessingStep>("organization_sdkmessageprocessingstep", null, value);
                this.OnPropertyChanged("organization_sdkmessageprocessingstep");
            }
        }

        /// <summary>
        /// 1:N organization_sdkmessageprocessingstepimage
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_sdkmessageprocessingstepimage")]
        public System.Collections.Generic.IEnumerable<SdkMessageProcessingStepImage> organization_sdkmessageprocessingstepimage
        {
            get { return this.GetRelatedEntities<SdkMessageProcessingStepImage>("organization_sdkmessageprocessingstepimage", null); }
            set
            {
                this.OnPropertyChanging("organization_sdkmessageprocessingstepimage");
                this.SetRelatedEntities<SdkMessageProcessingStepImage>("organization_sdkmessageprocessingstepimage", null, value);
                this.OnPropertyChanged("organization_sdkmessageprocessingstepimage");
            }
        }

        /// <summary>
        /// 1:N organization_sdkmessageprocessingstepsecureconfig
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_sdkmessageprocessingstepsecureconfig")]
        public System.Collections.Generic.IEnumerable<SdkMessageProcessingStepSecureConfig> organization_sdkmessageprocessingstepsecureconfig
        {
            get { return this.GetRelatedEntities<SdkMessageProcessingStepSecureConfig>("organization_sdkmessageprocessingstepsecureconfig", null); }
            set
            {
                this.OnPropertyChanging("organization_sdkmessageprocessingstepsecureconfig");
                this.SetRelatedEntities<SdkMessageProcessingStepSecureConfig>("organization_sdkmessageprocessingstepsecureconfig", null, value);
                this.OnPropertyChanged("organization_sdkmessageprocessingstepsecureconfig");
            }
        }

        /// <summary>
        /// 1:N organization_sdkmessagerequest
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_sdkmessagerequest")]
        public System.Collections.Generic.IEnumerable<SdkMessageRequest> organization_sdkmessagerequest
        {
            get { return this.GetRelatedEntities<SdkMessageRequest>("organization_sdkmessagerequest", null); }
            set
            {
                this.OnPropertyChanging("organization_sdkmessagerequest");
                this.SetRelatedEntities<SdkMessageRequest>("organization_sdkmessagerequest", null, value);
                this.OnPropertyChanged("organization_sdkmessagerequest");
            }
        }

        /// <summary>
        /// 1:N organization_sdkmessagerequestfield
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_sdkmessagerequestfield")]
        public System.Collections.Generic.IEnumerable<SdkMessageRequestField> organization_sdkmessagerequestfield
        {
            get { return this.GetRelatedEntities<SdkMessageRequestField>("organization_sdkmessagerequestfield", null); }
            set
            {
                this.OnPropertyChanging("organization_sdkmessagerequestfield");
                this.SetRelatedEntities<SdkMessageRequestField>("organization_sdkmessagerequestfield", null, value);
                this.OnPropertyChanged("organization_sdkmessagerequestfield");
            }
        }

        /// <summary>
        /// 1:N organization_sdkmessageresponse
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_sdkmessageresponse")]
        public System.Collections.Generic.IEnumerable<SdkMessageResponse> organization_sdkmessageresponse
        {
            get { return this.GetRelatedEntities<SdkMessageResponse>("organization_sdkmessageresponse", null); }
            set
            {
                this.OnPropertyChanging("organization_sdkmessageresponse");
                this.SetRelatedEntities<SdkMessageResponse>("organization_sdkmessageresponse", null, value);
                this.OnPropertyChanged("organization_sdkmessageresponse");
            }
        }

        /// <summary>
        /// 1:N organization_sdkmessageresponsefield
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_sdkmessageresponsefield")]
        public System.Collections.Generic.IEnumerable<SdkMessageResponseField> organization_sdkmessageresponsefield
        {
            get { return this.GetRelatedEntities<SdkMessageResponseField>("organization_sdkmessageresponsefield", null); }
            set
            {
                this.OnPropertyChanging("organization_sdkmessageresponsefield");
                this.SetRelatedEntities<SdkMessageResponseField>("organization_sdkmessageresponsefield", null, value);
                this.OnPropertyChanged("organization_sdkmessageresponsefield");
            }
        }

        /// <summary>
        /// 1:N organization_serviceendpoint
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_serviceendpoint")]
        public System.Collections.Generic.IEnumerable<ServiceEndpoint> organization_serviceendpoint
        {
            get { return this.GetRelatedEntities<ServiceEndpoint>("organization_serviceendpoint", null); }
            set
            {
                this.OnPropertyChanging("organization_serviceendpoint");
                this.SetRelatedEntities<ServiceEndpoint>("organization_serviceendpoint", null, value);
                this.OnPropertyChanged("organization_serviceendpoint");
            }
        }

        /// <summary>
        /// 1:N organization_services
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_services")]
        public System.Collections.Generic.IEnumerable<Service> organization_services
        {
            get { return this.GetRelatedEntities<Service>("organization_services", null); }
            set
            {
                this.OnPropertyChanging("organization_services");
                this.SetRelatedEntities<Service>("organization_services", null, value);
                this.OnPropertyChanged("organization_services");
            }
        }

        /// <summary>
        /// 1:N organization_sharepointdata
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_sharepointdata")]
        public System.Collections.Generic.IEnumerable<SharePointData> organization_sharepointdata
        {
            get { return this.GetRelatedEntities<SharePointData>("organization_sharepointdata", null); }
            set
            {
                this.OnPropertyChanging("organization_sharepointdata");
                this.SetRelatedEntities<SharePointData>("organization_sharepointdata", null, value);
                this.OnPropertyChanged("organization_sharepointdata");
            }
        }

        /// <summary>
        /// 1:N organization_sharepointdocument
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_sharepointdocument")]
        public System.Collections.Generic.IEnumerable<SharePointDocument> organization_sharepointdocument
        {
            get { return this.GetRelatedEntities<SharePointDocument>("organization_sharepointdocument", null); }
            set
            {
                this.OnPropertyChanging("organization_sharepointdocument");
                this.SetRelatedEntities<SharePointDocument>("organization_sharepointdocument", null, value);
                this.OnPropertyChanged("organization_sharepointdocument");
            }
        }

        /// <summary>
        /// 1:N organization_sitemap
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_sitemap")]
        public System.Collections.Generic.IEnumerable<SiteMap> organization_sitemap
        {
            get { return this.GetRelatedEntities<SiteMap>("organization_sitemap", null); }
            set
            {
                this.OnPropertyChanging("organization_sitemap");
                this.SetRelatedEntities<SiteMap>("organization_sitemap", null, value);
                this.OnPropertyChanged("organization_sitemap");
            }
        }

        /// <summary>
        /// 1:N organization_sites
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_sites")]
        public System.Collections.Generic.IEnumerable<Site> organization_sites
        {
            get { return this.GetRelatedEntities<Site>("organization_sites", null); }
            set
            {
                this.OnPropertyChanging("organization_sites");
                this.SetRelatedEntities<Site>("organization_sites", null, value);
                this.OnPropertyChanged("organization_sites");
            }
        }

        /// <summary>
        /// 1:N organization_socialinsightsconfiguration
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_socialinsightsconfiguration")]
        public System.Collections.Generic.IEnumerable<SocialInsightsConfiguration> organization_socialinsightsconfiguration
        {
            get { return this.GetRelatedEntities<SocialInsightsConfiguration>("organization_socialinsightsconfiguration", null); }
            set
            {
                this.OnPropertyChanging("organization_socialinsightsconfiguration");
                this.SetRelatedEntities<SocialInsightsConfiguration>("organization_socialinsightsconfiguration", null, value);
                this.OnPropertyChanged("organization_socialinsightsconfiguration");
            }
        }

        /// <summary>
        /// 1:N organization_solution
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_solution")]
        public System.Collections.Generic.IEnumerable<Solution> organization_solution
        {
            get { return this.GetRelatedEntities<Solution>("organization_solution", null); }
            set
            {
                this.OnPropertyChanging("organization_solution");
                this.SetRelatedEntities<Solution>("organization_solution", null, value);
                this.OnPropertyChanged("organization_solution");
            }
        }

        /// <summary>
        /// 1:N organization_subjects
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_subjects")]
        public System.Collections.Generic.IEnumerable<Subject> organization_subjects
        {
            get { return this.GetRelatedEntities<Subject>("organization_subjects", null); }
            set
            {
                this.OnPropertyChanging("organization_subjects");
                this.SetRelatedEntities<Subject>("organization_subjects", null, value);
                this.OnPropertyChanged("organization_subjects");
            }
        }

        /// <summary>
        /// 1:N organization_system_users
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_system_users")]
        public System.Collections.Generic.IEnumerable<SystemUser> organization_system_users
        {
            get { return this.GetRelatedEntities<SystemUser>("organization_system_users", null); }
            set
            {
                this.OnPropertyChanging("organization_system_users");
                this.SetRelatedEntities<SystemUser>("organization_system_users", null, value);
                this.OnPropertyChanged("organization_system_users");
            }
        }

        /// <summary>
        /// 1:N organization_systemforms
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_systemforms")]
        public System.Collections.Generic.IEnumerable<SystemForm> organization_systemforms
        {
            get { return this.GetRelatedEntities<SystemForm>("organization_systemforms", null); }
            set
            {
                this.OnPropertyChanging("organization_systemforms");
                this.SetRelatedEntities<SystemForm>("organization_systemforms", null, value);
                this.OnPropertyChanged("organization_systemforms");
            }
        }

        /// <summary>
        /// 1:N organization_teams
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_teams")]
        public System.Collections.Generic.IEnumerable<Team> organization_teams
        {
            get { return this.GetRelatedEntities<Team>("organization_teams", null); }
            set
            {
                this.OnPropertyChanging("organization_teams");
                this.SetRelatedEntities<Team>("organization_teams", null, value);
                this.OnPropertyChanged("organization_teams");
            }
        }

        /// <summary>
        /// 1:N organization_territories
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_territories")]
        public System.Collections.Generic.IEnumerable<Territory> organization_territories
        {
            get { return this.GetRelatedEntities<Territory>("organization_territories", null); }
            set
            {
                this.OnPropertyChanging("organization_territories");
                this.SetRelatedEntities<Territory>("organization_territories", null, value);
                this.OnPropertyChanged("organization_territories");
            }
        }

        /// <summary>
        /// 1:N organization_tracelog
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_tracelog")]
        public System.Collections.Generic.IEnumerable<TraceLog> organization_tracelog
        {
            get { return this.GetRelatedEntities<TraceLog>("organization_tracelog", null); }
            set
            {
                this.OnPropertyChanging("organization_tracelog");
                this.SetRelatedEntities<TraceLog>("organization_tracelog", null, value);
                this.OnPropertyChanged("organization_tracelog");
            }
        }

        /// <summary>
        /// 1:N organization_transactioncurrencies
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_transactioncurrencies")]
        public System.Collections.Generic.IEnumerable<TransactionCurrency> organization_transactioncurrencies
        {
            get { return this.GetRelatedEntities<TransactionCurrency>("organization_transactioncurrencies", null); }
            set
            {
                this.OnPropertyChanging("organization_transactioncurrencies");
                this.SetRelatedEntities<TransactionCurrency>("organization_transactioncurrencies", null, value);
                this.OnPropertyChanged("organization_transactioncurrencies");
            }
        }

        /// <summary>
        /// 1:N organization_uof_schedules
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_uof_schedules")]
        public System.Collections.Generic.IEnumerable<UoMSchedule> organization_uof_schedules
        {
            get { return this.GetRelatedEntities<UoMSchedule>("organization_uof_schedules", null); }
            set
            {
                this.OnPropertyChanging("organization_uof_schedules");
                this.SetRelatedEntities<UoMSchedule>("organization_uof_schedules", null, value);
                this.OnPropertyChanged("organization_uof_schedules");
            }
        }

        /// <summary>
        /// 1:N userentityinstancedata_organization
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_organization")]
        public System.Collections.Generic.IEnumerable<UserEntityInstanceData> userentityinstancedata_organization
        {
            get { return this.GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_organization", null); }
            set
            {
                this.OnPropertyChanging("userentityinstancedata_organization");
                this.SetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_organization", null, value);
                this.OnPropertyChanged("userentityinstancedata_organization");
            }
        }

        /// <summary>
        /// 1:N webresource_organization
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("webresource_organization")]
        public System.Collections.Generic.IEnumerable<WebResource> webresource_organization
        {
            get { return this.GetRelatedEntities<WebResource>("webresource_organization", null); }
            set
            {
                this.OnPropertyChanging("webresource_organization");
                this.SetRelatedEntities<WebResource>("webresource_organization", null, value);
                this.OnPropertyChanged("webresource_organization");
            }
        }

        /// <summary>
        /// N:1 basecurrency_organization
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("basecurrencyid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("basecurrency_organization")]
        public TransactionCurrency basecurrency_organization
        {
            get { return this.GetRelatedEntity<TransactionCurrency>("basecurrency_organization", null); }
            set
            {
                this.OnPropertyChanging("basecurrency_organization");
                this.SetRelatedEntity<TransactionCurrency>("basecurrency_organization", null, value);
                this.OnPropertyChanged("basecurrency_organization");
            }
        }

        /// <summary>
        /// N:1 calendar_organization
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("businessclosurecalendarid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("calendar_organization")]
        public Calendar calendar_organization
        {
            get { return this.GetRelatedEntity<Calendar>("calendar_organization", null); }
            set
            {
                this.OnPropertyChanging("calendar_organization");
                this.SetRelatedEntity<Calendar>("calendar_organization", null, value);
                this.OnPropertyChanged("calendar_organization");
            }
        }

        /// <summary>
        /// N:1 EmailServerProfile_Organization
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("defaultemailserverprofileid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("EmailServerProfile_Organization")]
        public EmailServerProfile EmailServerProfile_Organization
        {
            get { return this.GetRelatedEntity<EmailServerProfile>("EmailServerProfile_Organization", null); }
            set
            {
                this.OnPropertyChanging("EmailServerProfile_Organization");
                this.SetRelatedEntity<EmailServerProfile>("EmailServerProfile_Organization", null, value);
                this.OnPropertyChanged("EmailServerProfile_Organization");
            }
        }

        /// <summary>
        /// N:1 lk_organization_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_organization_createdonbehalfby")]
        public SystemUser lk_organization_createdonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_organization_createdonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_organization_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_organization_modifiedonbehalfby")]
        public SystemUser lk_organization_modifiedonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_organization_modifiedonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_organizationbase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_organizationbase_createdby")]
        public SystemUser lk_organizationbase_createdby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_organizationbase_createdby", null); }
        }

        /// <summary>
        /// N:1 lk_organizationbase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_organizationbase_modifiedby")]
        public SystemUser lk_organizationbase_modifiedby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_organizationbase_modifiedby", null); }
        }

        /// <summary>
        /// N:1 Template_Organization
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("acknowledgementtemplateid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Template_Organization")]
        public Template Template_Organization
        {
            get { return this.GetRelatedEntity<Template>("Template_Organization", null); }
            set
            {
                this.OnPropertyChanging("Template_Organization");
                this.SetRelatedEntity<Template>("Template_Organization", null, value);
                this.OnPropertyChanged("Template_Organization");
            }
        }
    }
}