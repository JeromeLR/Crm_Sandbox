namespace __4_DAL_CRM
{
    /// <summary>
    /// User's preferred settings.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("usersettings")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class UserSettings : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public UserSettings() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "usersettings";

        public const int EntityTypeCode = 150;

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
        /// Normal polling frequency used for address book synchronization in Microsoft Office Outlook.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("addressbooksyncinterval")]
        public System.Nullable<int> AddressBookSyncInterval
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("addressbooksyncinterval"); }
            set
            {
                this.OnPropertyChanging("AddressBookSyncInterval");
                this.SetAttributeValue("addressbooksyncinterval", value);
                this.OnPropertyChanged("AddressBookSyncInterval");
            }
        }

        /// <summary>
        /// Default mode, such as simple or detailed, for advanced find.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("advancedfindstartupmode")]
        public System.Nullable<int> AdvancedFindStartupMode
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("advancedfindstartupmode"); }
            set
            {
                this.OnPropertyChanging("AdvancedFindStartupMode");
                this.SetAttributeValue("advancedfindstartupmode", value);
                this.OnPropertyChanged("AdvancedFindStartupMode");
            }
        }

        /// <summary>
        /// This attribute is no longer used. The data is now in the Mailbox.AllowEmailConnectorToUseCredentials attribute.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("allowemailcredentials")]
        [System.ObsoleteAttribute()]
        public System.Nullable<bool> AllowEmailCredentials
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("allowemailcredentials"); }
        }

        /// <summary>
        /// AM designator to use in Microsoft Dynamics CRM.
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
        /// Auto-create contact on client promote
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("autocreatecontactonpromote")]
        public System.Nullable<int> AutoCreateContactOnPromote
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("autocreatecontactonpromote"); }
            set
            {
                this.OnPropertyChanging("AutoCreateContactOnPromote");
                this.SetAttributeValue("autocreatecontactonpromote", value);
                this.OnPropertyChanged("AutoCreateContactOnPromote");
            }
        }

        /// <summary>
        /// Unique identifier of the business unit with which the user is associated.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("businessunitid")]
        public System.Nullable<System.Guid> BusinessUnitId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("businessunitid"); }
            set
            {
                this.OnPropertyChanging("BusinessUnitId");
                this.SetAttributeValue("businessunitid", value);
                this.OnPropertyChanged("BusinessUnitId");
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
        /// Unique identifier of the user who created the user settings.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby"); }
        }

        /// <summary>
        /// Date and time when the user settings object was created.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
        public System.Nullable<System.DateTime> CreatedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who created the usersettings.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        /// Number of decimal places that can be used for currency.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("currencydecimalprecision")]
        [System.ObsoleteAttribute()]
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
        /// Information about how currency symbols are placed in Microsoft Dynamics CRM.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("currencyformatcode")]
        public System.Nullable<int> CurrencyFormatCode
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("currencyformatcode"); }
            set
            {
                this.OnPropertyChanging("CurrencyFormatCode");
                this.SetAttributeValue("currencyformatcode", value);
                this.OnPropertyChanged("CurrencyFormatCode");
            }
        }

        /// <summary>
        /// Symbol used for currency in Microsoft Dynamics CRM.
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
        /// Information that specifies the level of data validation in excel worksheets exported in a format suitable for import.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("datavalidationmodeforexporttoexcel")]
        public Microsoft.Xrm.Sdk.OptionSetValue DataValidationModeForExportToExcel
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("datavalidationmodeforexporttoexcel"); }
            set
            {
                this.OnPropertyChanging("DataValidationModeForExportToExcel");
                this.SetAttributeValue("datavalidationmodeforexporttoexcel", value);
                this.OnPropertyChanged("DataValidationModeForExportToExcel");
            }
        }

        /// <summary>
        /// Information about how the date is displayed in Microsoft Dynamics CRM.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("dateformatcode")]
        public System.Nullable<int> DateFormatCode
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("dateformatcode"); }
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
        /// Character used to separate the month, the day, and the year in dates in Microsoft Dynamics CRM.
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
        /// Default calendar view for the user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("defaultcalendarview")]
        public System.Nullable<int> DefaultCalendarView
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("defaultcalendarview"); }
            set
            {
                this.OnPropertyChanging("DefaultCalendarView");
                this.SetAttributeValue("defaultcalendarview", value);
                this.OnPropertyChanged("DefaultCalendarView");
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
        /// Unique identifier of the default dashboard.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("defaultdashboardid")]
        public System.Nullable<System.Guid> DefaultDashboardId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("defaultdashboardid"); }
            set
            {
                this.OnPropertyChanging("DefaultDashboardId");
                this.SetAttributeValue("defaultdashboardid", value);
                this.OnPropertyChanged("DefaultDashboardId");
            }
        }

        /// <summary>
        /// This attribute is no longer used. The data is now in the Mailbox.Password attribute.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("emailpassword")]
        [System.ObsoleteAttribute()]
        public string EmailPassword
        {
            get { return this.GetAttributeValue<string>("emailpassword"); }
        }

        /// <summary>
        /// This attribute is no longer used. The data is now in the Mailbox.UserName attribute.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("emailusername")]
        [System.ObsoleteAttribute()]
        public string EmailUsername
        {
            get { return this.GetAttributeValue<string>("emailusername"); }
        }

        /// <summary>
        /// Indicates the form mode to be used.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entityformmode")]
        public Microsoft.Xrm.Sdk.OptionSetValue EntityFormMode
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("entityformmode"); }
            set
            {
                this.OnPropertyChanging("EntityFormMode");
                this.SetAttributeValue("entityformmode", value);
                this.OnPropertyChanged("EntityFormMode");
            }
        }

        /// <summary>
        /// Order in which names are to be displayed in Microsoft Dynamics CRM.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("fullnameconventioncode")]
        public System.Nullable<int> FullNameConventionCode
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("fullnameconventioncode"); }
            set
            {
                this.OnPropertyChanging("FullNameConventionCode");
                this.SetAttributeValue("fullnameconventioncode", value);
                this.OnPropertyChanged("FullNameConventionCode");
            }
        }

        /// <summary>
        /// Information that specifies whether the Get Started pane in lists is enabled.
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
        /// Unique identifier of the Help language.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("helplanguageid")]
        public System.Nullable<int> HelpLanguageId
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("helplanguageid"); }
            set
            {
                this.OnPropertyChanging("HelpLanguageId");
                this.SetAttributeValue("helplanguageid", value);
                this.OnPropertyChanged("HelpLanguageId");
            }
        }

        /// <summary>
        /// Web site home page for the user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("homepagearea")]
        public string HomepageArea
        {
            get { return this.GetAttributeValue<string>("homepagearea"); }
            set
            {
                this.OnPropertyChanging("HomepageArea");
                this.SetAttributeValue("homepagearea", value);
                this.OnPropertyChanged("HomepageArea");
            }
        }

        /// <summary>
        /// Configuration of the home page layout.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("homepagelayout")]
        public string HomepageLayout
        {
            get { return this.GetAttributeValue<string>("homepagelayout"); }
            set
            {
                this.OnPropertyChanging("HomepageLayout");
                this.SetAttributeValue("homepagelayout", value);
                this.OnPropertyChanged("HomepageLayout");
            }
        }

        /// <summary>
        /// Web site page for the user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("homepagesubarea")]
        public string HomepageSubarea
        {
            get { return this.GetAttributeValue<string>("homepagesubarea"); }
            set
            {
                this.OnPropertyChanging("HomepageSubarea");
                this.SetAttributeValue("homepagesubarea", value);
                this.OnPropertyChanged("HomepageSubarea");
            }
        }

        /// <summary>
        /// Information that specifies whether a user account is to ignore unsolicited email (deprecated).
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ignoreunsolicitedemail")]
        public System.Nullable<bool> IgnoreUnsolicitedEmail
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("ignoreunsolicitedemail"); }
            set
            {
                this.OnPropertyChanging("IgnoreUnsolicitedEmail");
                this.SetAttributeValue("ignoreunsolicitedemail", value);
                this.OnPropertyChanged("IgnoreUnsolicitedEmail");
            }
        }

        /// <summary>
        /// Incoming email filtering method.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("incomingemailfilteringmethod")]
        public Microsoft.Xrm.Sdk.OptionSetValue IncomingEmailFilteringMethod
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("incomingemailfilteringmethod"); }
            set
            {
                this.OnPropertyChanging("IncomingEmailFilteringMethod");
                this.SetAttributeValue("incomingemailfilteringmethod", value);
                this.OnPropertyChanged("IncomingEmailFilteringMethod");
            }
        }

        /// <summary>
        /// Enable or disable country code selection .
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
        /// Indicates if duplicate detection is enabled when going online.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isduplicatedetectionenabledwhengoingonline")]
        public System.Nullable<bool> IsDuplicateDetectionEnabledWhenGoingOnline
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("isduplicatedetectionenabledwhengoingonline"); }
            set
            {
                this.OnPropertyChanging("IsDuplicateDetectionEnabledWhenGoingOnline");
                this.SetAttributeValue("isduplicatedetectionenabledwhengoingonline", value);
                this.OnPropertyChanged("IsDuplicateDetectionEnabledWhenGoingOnline");
            }
        }

        /// <summary>
        /// Indicates if send as other user privilege is enabled or not.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("issendasallowed")]
        public System.Nullable<bool> IsSendAsAllowed
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("issendasallowed"); }
            set
            {
                this.OnPropertyChanging("IsSendAsAllowed");
                this.SetAttributeValue("issendasallowed", value);
                this.OnPropertyChanged("IsSendAsAllowed");
            }
        }

        /// <summary>
        /// Shows the last time when the traces were read from the database.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("lastalertsviewedtime")]
        public System.Nullable<System.DateTime> LastAlertsViewedTime
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("lastalertsviewedtime"); }
            set
            {
                this.OnPropertyChanging("LastAlertsViewedTime");
                this.SetAttributeValue("lastalertsviewedtime", value);
                this.OnPropertyChanged("LastAlertsViewedTime");
            }
        }

        /// <summary>
        /// Unique identifier of the user locale.
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
        /// Information that specifies how Long Date is displayed throughout Microsoft CRM.
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
        /// Unique identifier of the user who last modified the user settings.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby"); }
        }

        /// <summary>
        /// Date and time when the user settings object was last modified.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
        public System.Nullable<System.DateTime> ModifiedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who last modified the usersettings.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        /// Information that specifies how negative currency numbers are displayed in Microsoft Dynamics CRM.
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
        /// Information that specifies how negative numbers are displayed in Microsoft Dynamics CRM.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("negativeformatcode")]
        public System.Nullable<int> NegativeFormatCode
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("negativeformatcode"); }
            set
            {
                this.OnPropertyChanging("NegativeFormatCode");
                this.SetAttributeValue("negativeformatcode", value);
                this.OnPropertyChanged("NegativeFormatCode");
            }
        }

        /// <summary>
        /// Next tracking number.
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
        /// Information that specifies how numbers are grouped in Microsoft Dynamics CRM.
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
        /// Normal polling frequency used for background offline synchronization in Microsoft Office Outlook.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("offlinesyncinterval")]
        public System.Nullable<int> OfflineSyncInterval
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("offlinesyncinterval"); }
            set
            {
                this.OnPropertyChanging("OfflineSyncInterval");
                this.SetAttributeValue("offlinesyncinterval", value);
                this.OnPropertyChanged("OfflineSyncInterval");
            }
        }

        /// <summary>
        /// Normal polling frequency used for record synchronization in Microsoft Office Outlook.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("outlooksyncinterval")]
        public System.Nullable<int> OutlookSyncInterval
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("outlooksyncinterval"); }
            set
            {
                this.OnPropertyChanging("OutlookSyncInterval");
                this.SetAttributeValue("outlooksyncinterval", value);
                this.OnPropertyChanged("OutlookSyncInterval");
            }
        }

        /// <summary>
        /// Information that specifies how many items to list on a page in list views.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("paginglimit")]
        public System.Nullable<int> PagingLimit
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("paginglimit"); }
            set
            {
                this.OnPropertyChanging("PagingLimit");
                this.SetAttributeValue("paginglimit", value);
                this.OnPropertyChanged("PagingLimit");
            }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("personalizationsettings")]
        public string PersonalizationSettings
        {
            get { return this.GetAttributeValue<string>("personalizationsettings"); }
            set
            {
                this.OnPropertyChanging("PersonalizationSettings");
                this.SetAttributeValue("personalizationsettings", value);
                this.OnPropertyChanged("PersonalizationSettings");
            }
        }

        /// <summary>
        /// PM designator to use in Microsoft Dynamics CRM.
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
        [System.ObsoleteAttribute()]
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
        /// Picklist for selecting the user preference for reporting scripting errors.
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
        /// Information that specifies whether to display the week number in calendar displays in Microsoft Dynamics CRM.
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
        /// Indicates if the company field in Microsoft Office Outlook items are set during Outlook synchronization.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("synccontactcompany")]
        public System.Nullable<bool> SyncContactCompany
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("synccontactcompany"); }
            set
            {
                this.OnPropertyChanging("SyncContactCompany");
                this.SetAttributeValue("synccontactcompany", value);
                this.OnPropertyChanged("SyncContactCompany");
            }
        }

        /// <summary>
        /// Unique identifier of the user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("systemuserid")]
        public System.Nullable<System.Guid> SystemUserId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("systemuserid"); }
            set
            {
                this.OnPropertyChanging("SystemUserId");
                this.SetAttributeValue("systemuserid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("SystemUserId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("systemuserid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.SystemUserId = value; }
        }

        /// <summary>
        /// Information that specifies how the time is displayed in Microsoft Dynamics CRM.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("timeformatcode")]
        public System.Nullable<int> TimeFormatCode
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("timeformatcode"); }
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
        /// Text for how time is displayed in Microsoft Dynamics CRM.
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
        /// Local time zone adjustment for the user. System calculated based on the time zone selected.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("timezonebias")]
        public System.Nullable<int> TimeZoneBias
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("timezonebias"); }
            set
            {
                this.OnPropertyChanging("TimeZoneBias");
                this.SetAttributeValue("timezonebias", value);
                this.OnPropertyChanged("TimeZoneBias");
            }
        }

        /// <summary>
        /// Local time zone for the user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("timezonecode")]
        public System.Nullable<int> TimeZoneCode
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("timezonecode"); }
            set
            {
                this.OnPropertyChanging("TimeZoneCode");
                this.SetAttributeValue("timezonecode", value);
                this.OnPropertyChanged("TimeZoneCode");
            }
        }

        /// <summary>
        /// Local time zone daylight adjustment for the user. System calculated based on the time zone selected.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("timezonedaylightbias")]
        public System.Nullable<int> TimeZoneDaylightBias
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("timezonedaylightbias"); }
            set
            {
                this.OnPropertyChanging("TimeZoneDaylightBias");
                this.SetAttributeValue("timezonedaylightbias", value);
                this.OnPropertyChanged("TimeZoneDaylightBias");
            }
        }

        /// <summary>
        /// Local time zone daylight day for the user. System calculated based on the time zone selected.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("timezonedaylightday")]
        public System.Nullable<int> TimeZoneDaylightDay
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("timezonedaylightday"); }
            set
            {
                this.OnPropertyChanging("TimeZoneDaylightDay");
                this.SetAttributeValue("timezonedaylightday", value);
                this.OnPropertyChanged("TimeZoneDaylightDay");
            }
        }

        /// <summary>
        /// Local time zone daylight day of week for the user. System calculated based on the time zone selected in Options.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("timezonedaylightdayofweek")]
        public System.Nullable<int> TimeZoneDaylightDayOfWeek
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("timezonedaylightdayofweek"); }
            set
            {
                this.OnPropertyChanging("TimeZoneDaylightDayOfWeek");
                this.SetAttributeValue("timezonedaylightdayofweek", value);
                this.OnPropertyChanged("TimeZoneDaylightDayOfWeek");
            }
        }

        /// <summary>
        /// Local time zone daylight hour for the user. System calculated based on the time zone selected.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("timezonedaylighthour")]
        public System.Nullable<int> TimeZoneDaylightHour
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("timezonedaylighthour"); }
            set
            {
                this.OnPropertyChanging("TimeZoneDaylightHour");
                this.SetAttributeValue("timezonedaylighthour", value);
                this.OnPropertyChanged("TimeZoneDaylightHour");
            }
        }

        /// <summary>
        /// Local time zone daylight minute for the user. System calculated based on the time zone selected.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("timezonedaylightminute")]
        public System.Nullable<int> TimeZoneDaylightMinute
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("timezonedaylightminute"); }
            set
            {
                this.OnPropertyChanging("TimeZoneDaylightMinute");
                this.SetAttributeValue("timezonedaylightminute", value);
                this.OnPropertyChanged("TimeZoneDaylightMinute");
            }
        }

        /// <summary>
        /// Local time zone daylight month for the user. System calculated based on the time zone selected.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("timezonedaylightmonth")]
        public System.Nullable<int> TimeZoneDaylightMonth
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("timezonedaylightmonth"); }
            set
            {
                this.OnPropertyChanging("TimeZoneDaylightMonth");
                this.SetAttributeValue("timezonedaylightmonth", value);
                this.OnPropertyChanged("TimeZoneDaylightMonth");
            }
        }

        /// <summary>
        /// Local time zone daylight second for the user. System calculated based on the time zone selected.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("timezonedaylightsecond")]
        public System.Nullable<int> TimeZoneDaylightSecond
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("timezonedaylightsecond"); }
            set
            {
                this.OnPropertyChanging("TimeZoneDaylightSecond");
                this.SetAttributeValue("timezonedaylightsecond", value);
                this.OnPropertyChanged("TimeZoneDaylightSecond");
            }
        }

        /// <summary>
        /// Local time zone daylight year for the user. System calculated based on the time zone selected.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("timezonedaylightyear")]
        public System.Nullable<int> TimeZoneDaylightYear
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("timezonedaylightyear"); }
            set
            {
                this.OnPropertyChanging("TimeZoneDaylightYear");
                this.SetAttributeValue("timezonedaylightyear", value);
                this.OnPropertyChanged("TimeZoneDaylightYear");
            }
        }

        /// <summary>
        /// Local time zone standard time bias for the user. System calculated based on the time zone selected.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("timezonestandardbias")]
        public System.Nullable<int> TimeZoneStandardBias
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("timezonestandardbias"); }
            set
            {
                this.OnPropertyChanging("TimeZoneStandardBias");
                this.SetAttributeValue("timezonestandardbias", value);
                this.OnPropertyChanged("TimeZoneStandardBias");
            }
        }

        /// <summary>
        /// Local time zone standard day for the user. System calculated based on the time zone selected.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("timezonestandardday")]
        public System.Nullable<int> TimeZoneStandardDay
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("timezonestandardday"); }
            set
            {
                this.OnPropertyChanging("TimeZoneStandardDay");
                this.SetAttributeValue("timezonestandardday", value);
                this.OnPropertyChanged("TimeZoneStandardDay");
            }
        }

        /// <summary>
        /// Local time zone standard day of week for the user. System calculated based on the time zone selected.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("timezonestandarddayofweek")]
        public System.Nullable<int> TimeZoneStandardDayOfWeek
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("timezonestandarddayofweek"); }
            set
            {
                this.OnPropertyChanging("TimeZoneStandardDayOfWeek");
                this.SetAttributeValue("timezonestandarddayofweek", value);
                this.OnPropertyChanged("TimeZoneStandardDayOfWeek");
            }
        }

        /// <summary>
        /// Local time zone standard hour for the user. System calculated based on the time zone selected.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("timezonestandardhour")]
        public System.Nullable<int> TimeZoneStandardHour
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("timezonestandardhour"); }
            set
            {
                this.OnPropertyChanging("TimeZoneStandardHour");
                this.SetAttributeValue("timezonestandardhour", value);
                this.OnPropertyChanged("TimeZoneStandardHour");
            }
        }

        /// <summary>
        /// Local time zone standard minute for the user. System calculated based on the time zone selected.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("timezonestandardminute")]
        public System.Nullable<int> TimeZoneStandardMinute
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("timezonestandardminute"); }
            set
            {
                this.OnPropertyChanging("TimeZoneStandardMinute");
                this.SetAttributeValue("timezonestandardminute", value);
                this.OnPropertyChanged("TimeZoneStandardMinute");
            }
        }

        /// <summary>
        /// Local time zone standard month for the user. System calculated based on the time zone selected.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("timezonestandardmonth")]
        public System.Nullable<int> TimeZoneStandardMonth
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("timezonestandardmonth"); }
            set
            {
                this.OnPropertyChanging("TimeZoneStandardMonth");
                this.SetAttributeValue("timezonestandardmonth", value);
                this.OnPropertyChanged("TimeZoneStandardMonth");
            }
        }

        /// <summary>
        /// Local time zone standard second for the user. System calculated based on the time zone selected.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("timezonestandardsecond")]
        public System.Nullable<int> TimeZoneStandardSecond
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("timezonestandardsecond"); }
            set
            {
                this.OnPropertyChanging("TimeZoneStandardSecond");
                this.SetAttributeValue("timezonestandardsecond", value);
                this.OnPropertyChanged("TimeZoneStandardSecond");
            }
        }

        /// <summary>
        /// Local time zone standard year for the user. System calculated based on the time zone selected.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("timezonestandardyear")]
        public System.Nullable<int> TimeZoneStandardYear
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("timezonestandardyear"); }
            set
            {
                this.OnPropertyChanging("TimeZoneStandardYear");
                this.SetAttributeValue("timezonestandardyear", value);
                this.OnPropertyChanged("TimeZoneStandardYear");
            }
        }

        /// <summary>
        /// Tracking token ID.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("trackingtokenid")]
        public System.Nullable<int> TrackingTokenId
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("trackingtokenid"); }
            set
            {
                this.OnPropertyChanging("TrackingTokenId");
                this.SetAttributeValue("trackingtokenid", value);
                this.OnPropertyChanged("TrackingTokenId");
            }
        }

        /// <summary>
        /// Unique identifier of the default currency of the user.
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
        /// Unique identifier of the language in which to view the user interface (UI).
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("uilanguageid")]
        public System.Nullable<int> UILanguageId
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("uilanguageid"); }
            set
            {
                this.OnPropertyChanging("UILanguageId");
                this.SetAttributeValue("uilanguageid", value);
                this.OnPropertyChanged("UILanguageId");
            }
        }

        /// <summary>
        /// Indicates whether to use the Microsoft Dynamics CRM appointment form within Microsoft Office Outlook for creating new appointments.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("usecrmformforappointment")]
        public System.Nullable<bool> UseCrmFormForAppointment
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("usecrmformforappointment"); }
            set
            {
                this.OnPropertyChanging("UseCrmFormForAppointment");
                this.SetAttributeValue("usecrmformforappointment", value);
                this.OnPropertyChanged("UseCrmFormForAppointment");
            }
        }

        /// <summary>
        /// Indicates whether to use the Microsoft Dynamics CRM contact form within Microsoft Office Outlook for creating new contacts.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("usecrmformforcontact")]
        public System.Nullable<bool> UseCrmFormForContact
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("usecrmformforcontact"); }
            set
            {
                this.OnPropertyChanging("UseCrmFormForContact");
                this.SetAttributeValue("usecrmformforcontact", value);
                this.OnPropertyChanged("UseCrmFormForContact");
            }
        }

        /// <summary>
        /// Indicates whether to use the Microsoft Dynamics CRM email form within Microsoft Office Outlook for creating new emails.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("usecrmformforemail")]
        public System.Nullable<bool> UseCrmFormForEmail
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("usecrmformforemail"); }
            set
            {
                this.OnPropertyChanging("UseCrmFormForEmail");
                this.SetAttributeValue("usecrmformforemail", value);
                this.OnPropertyChanged("UseCrmFormForEmail");
            }
        }

        /// <summary>
        /// Indicates whether to use the Microsoft Dynamics CRM task form within Microsoft Office Outlook for creating new tasks.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("usecrmformfortask")]
        public System.Nullable<bool> UseCrmFormForTask
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("usecrmformfortask"); }
            set
            {
                this.OnPropertyChanging("UseCrmFormForTask");
                this.SetAttributeValue("usecrmformfortask", value);
                this.OnPropertyChanged("UseCrmFormForTask");
            }
        }

        /// <summary>
        /// Indicates whether image strips are used to render images.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("useimagestrips")]
        public System.Nullable<bool> UseImageStrips
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("useimagestrips"); }
            set
            {
                this.OnPropertyChanging("UseImageStrips");
                this.SetAttributeValue("useimagestrips", value);
                this.OnPropertyChanged("UseImageStrips");
            }
        }

        /// <summary>
        /// Specifies user profile ids in comma separated list.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("userprofile")]
        public string UserProfile
        {
            get { return this.GetAttributeValue<string>("userprofile"); }
            set
            {
                this.OnPropertyChanging("UserProfile");
                this.SetAttributeValue("userprofile", value);
                this.OnPropertyChanged("UserProfile");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
        public System.Nullable<long> VersionNumber
        {
            get { return this.GetAttributeValue<System.Nullable<long>>("versionnumber"); }
        }

        /// <summary>
        /// The layout of the visualization pane.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("visualizationpanelayout")]
        public Microsoft.Xrm.Sdk.OptionSetValue VisualizationPaneLayout
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("visualizationpanelayout"); }
            set
            {
                this.OnPropertyChanging("VisualizationPaneLayout");
                this.SetAttributeValue("visualizationpanelayout", value);
                this.OnPropertyChanged("VisualizationPaneLayout");
            }
        }

        /// <summary>
        /// Workday start time for the user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("workdaystarttime")]
        public string WorkdayStartTime
        {
            get { return this.GetAttributeValue<string>("workdaystarttime"); }
            set
            {
                this.OnPropertyChanging("WorkdayStartTime");
                this.SetAttributeValue("workdaystarttime", value);
                this.OnPropertyChanged("WorkdayStartTime");
            }
        }

        /// <summary>
        /// Workday stop time for the user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("workdaystoptime")]
        public string WorkdayStopTime
        {
            get { return this.GetAttributeValue<string>("workdaystoptime"); }
            set
            {
                this.OnPropertyChanging("WorkdayStopTime");
                this.SetAttributeValue("workdaystoptime", value);
                this.OnPropertyChanged("WorkdayStopTime");
            }
        }

        /// <summary>
        /// N:1 business_unit_user_settings
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("businessunitid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_user_settings")]
        public BusinessUnit business_unit_user_settings
        {
            get { return this.GetRelatedEntity<BusinessUnit>("business_unit_user_settings", null); }
            set
            {
                this.OnPropertyChanging("business_unit_user_settings");
                this.SetRelatedEntity<BusinessUnit>("business_unit_user_settings", null, value);
                this.OnPropertyChanged("business_unit_user_settings");
            }
        }

        /// <summary>
        /// N:1 lk_usersettings_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_usersettings_createdonbehalfby")]
        public SystemUser lk_usersettings_createdonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_usersettings_createdonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_usersettings_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_usersettings_modifiedonbehalfby")]
        public SystemUser lk_usersettings_modifiedonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_usersettings_modifiedonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_usersettingsbase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_usersettingsbase_createdby")]
        public SystemUser lk_usersettingsbase_createdby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_usersettingsbase_createdby", null); }
        }

        /// <summary>
        /// N:1 lk_usersettingsbase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_usersettingsbase_modifiedby")]
        public SystemUser lk_usersettingsbase_modifiedby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_usersettingsbase_modifiedby", null); }
        }

        /// <summary>
        /// N:1 transactioncurrency_usersettings
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("transactioncurrency_usersettings")]
        public TransactionCurrency transactioncurrency_usersettings
        {
            get { return this.GetRelatedEntity<TransactionCurrency>("transactioncurrency_usersettings", null); }
            set
            {
                this.OnPropertyChanging("transactioncurrency_usersettings");
                this.SetRelatedEntity<TransactionCurrency>("transactioncurrency_usersettings", null, value);
                this.OnPropertyChanged("transactioncurrency_usersettings");
            }
        }

        /// <summary>
        /// N:1 user_settings
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("systemuserid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_settings")]
        public SystemUser user_settings
        {
            get { return this.GetRelatedEntity<SystemUser>("user_settings", null); }
            set
            {
                this.OnPropertyChanging("user_settings");
                this.SetRelatedEntity<SystemUser>("user_settings", null, value);
                this.OnPropertyChanged("user_settings");
            }
        }
    }
}