namespace __4_DAL_CRM
{
    /// <summary>
    /// Monthly fiscal calendar of an organization. A span of time during which the financial activities of an organization are calculated.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("monthlyfiscalcalendar")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class MonthlyFiscalCalendar : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public MonthlyFiscalCalendar() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "monthlyfiscalcalendar";

        public const int EntityTypeCode = 2003;

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
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("businessunitid")]
        public Microsoft.Xrm.Sdk.EntityReference BusinessUnitId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("businessunitid"); }
        }

        /// <summary>
        /// Unique identifier of the user who created the fiscal calendar.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby"); }
        }

        /// <summary>
        /// Date and time when the quota for the monthly fiscal calendar was modified.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
        public System.Nullable<System.DateTime> CreatedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who created the monthlyfiscalcalendar.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        /// Date and time when the monthly fiscal calendar sales quota takes effect.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("effectiveon")]
        public System.Nullable<System.DateTime> EffectiveOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("effectiveon"); }
            set
            {
                this.OnPropertyChanging("EffectiveOn");
                this.SetAttributeValue("effectiveon", value);
                this.OnPropertyChanged("EffectiveOn");
            }
        }

        /// <summary>
        /// Exchange rate for the currency associated with the monthly fiscal calendar with respect to the base currency.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("exchangerate")]
        public System.Nullable<decimal> ExchangeRate
        {
            get { return this.GetAttributeValue<System.Nullable<decimal>>("exchangerate"); }
        }

        /// <summary>
        /// Type of fiscal period used in the sales quota.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("fiscalperiodtype")]
        public System.Nullable<int> FiscalPeriodType
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("fiscalperiodtype"); }
        }

        /// <summary>
        /// Unique identifier of the user who last modified the quota for the monthly fiscal calendar.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby"); }
        }

        /// <summary>
        /// Date and time when the quota for the monthly fiscal calendar was last modified.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
        public System.Nullable<System.DateTime> ModifiedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who last modified the monthlyfiscalcalendar.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        /// Sales quota for the first month in the fiscal year.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("month1")]
        public Microsoft.Xrm.Sdk.Money Month1
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("month1"); }
            set
            {
                this.OnPropertyChanging("Month1");
                this.SetAttributeValue("month1", value);
                this.OnPropertyChanged("Month1");
            }
        }

        /// <summary>
        /// Base currency equivalent of the sales quota for the first month in the fiscal year.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("month1_base")]
        public Microsoft.Xrm.Sdk.Money Month1_Base
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("month1_base"); }
        }

        /// <summary>
        /// Sales quota for the tenth month in the fiscal year.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("month10")]
        public Microsoft.Xrm.Sdk.Money Month10
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("month10"); }
            set
            {
                this.OnPropertyChanging("Month10");
                this.SetAttributeValue("month10", value);
                this.OnPropertyChanged("Month10");
            }
        }

        /// <summary>
        /// Base currency equivalent of the sales quota for the tenth month in the fiscal year.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("month10_base")]
        public Microsoft.Xrm.Sdk.Money Month10_Base
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("month10_base"); }
        }

        /// <summary>
        /// Sales quota for the eleventh month in the fiscal year.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("month11")]
        public Microsoft.Xrm.Sdk.Money Month11
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("month11"); }
            set
            {
                this.OnPropertyChanging("Month11");
                this.SetAttributeValue("month11", value);
                this.OnPropertyChanged("Month11");
            }
        }

        /// <summary>
        /// Base currency equivalent of the sales quota for the eleventh month in the fiscal year.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("month11_base")]
        public Microsoft.Xrm.Sdk.Money Month11_Base
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("month11_base"); }
        }

        /// <summary>
        /// Sales quota for the twelfth month in the fiscal year.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("month12")]
        public Microsoft.Xrm.Sdk.Money Month12
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("month12"); }
            set
            {
                this.OnPropertyChanging("Month12");
                this.SetAttributeValue("month12", value);
                this.OnPropertyChanged("Month12");
            }
        }

        /// <summary>
        /// Base currency equivalent of the sales quota for the twelfth month in the fiscal year.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("month12_base")]
        public Microsoft.Xrm.Sdk.Money Month12_Base
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("month12_base"); }
        }

        /// <summary>
        /// Sales quota for the second month in the fiscal year.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("month2")]
        public Microsoft.Xrm.Sdk.Money Month2
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("month2"); }
            set
            {
                this.OnPropertyChanging("Month2");
                this.SetAttributeValue("month2", value);
                this.OnPropertyChanged("Month2");
            }
        }

        /// <summary>
        /// Base currency equivalent of the sales quota for the second month in the fiscal year.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("month2_base")]
        public Microsoft.Xrm.Sdk.Money Month2_Base
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("month2_base"); }
        }

        /// <summary>
        /// Sales quota for the third month in the fiscal year.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("month3")]
        public Microsoft.Xrm.Sdk.Money Month3
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("month3"); }
            set
            {
                this.OnPropertyChanging("Month3");
                this.SetAttributeValue("month3", value);
                this.OnPropertyChanged("Month3");
            }
        }

        /// <summary>
        /// Base currency equivalent of the sales quota for the third month in the fiscal year.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("month3_base")]
        public Microsoft.Xrm.Sdk.Money Month3_Base
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("month3_base"); }
        }

        /// <summary>
        /// Sales quota for the fourth month in the fiscal year.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("month4")]
        public Microsoft.Xrm.Sdk.Money Month4
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("month4"); }
            set
            {
                this.OnPropertyChanging("Month4");
                this.SetAttributeValue("month4", value);
                this.OnPropertyChanged("Month4");
            }
        }

        /// <summary>
        /// Base currency equivalent of the sales quota for the fourth month in the fiscal year.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("month4_base")]
        public Microsoft.Xrm.Sdk.Money Month4_Base
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("month4_base"); }
        }

        /// <summary>
        /// Sales quota for the fifth month in the fiscal year.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("month5")]
        public Microsoft.Xrm.Sdk.Money Month5
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("month5"); }
            set
            {
                this.OnPropertyChanging("Month5");
                this.SetAttributeValue("month5", value);
                this.OnPropertyChanged("Month5");
            }
        }

        /// <summary>
        /// Base currency equivalent of the sales quota for the fifth month in the fiscal year.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("month5_base")]
        public Microsoft.Xrm.Sdk.Money Month5_Base
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("month5_base"); }
        }

        /// <summary>
        /// Sales quota for the sixth month in the fiscal year.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("month6")]
        public Microsoft.Xrm.Sdk.Money Month6
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("month6"); }
            set
            {
                this.OnPropertyChanging("Month6");
                this.SetAttributeValue("month6", value);
                this.OnPropertyChanged("Month6");
            }
        }

        /// <summary>
        /// Base currency equivalent of the sales quota for the sixth month in the fiscal year.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("month6_base")]
        public Microsoft.Xrm.Sdk.Money Month6_Base
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("month6_base"); }
        }

        /// <summary>
        /// Sales quota for the seventh month in the fiscal year.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("month7")]
        public Microsoft.Xrm.Sdk.Money Month7
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("month7"); }
            set
            {
                this.OnPropertyChanging("Month7");
                this.SetAttributeValue("month7", value);
                this.OnPropertyChanged("Month7");
            }
        }

        /// <summary>
        /// Base currency equivalent of the sales quota for the seventh month in the fiscal year.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("month7_base")]
        public Microsoft.Xrm.Sdk.Money Month7_Base
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("month7_base"); }
        }

        /// <summary>
        /// Sales quota for the eighth month in the fiscal year.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("month8")]
        public Microsoft.Xrm.Sdk.Money Month8
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("month8"); }
            set
            {
                this.OnPropertyChanging("Month8");
                this.SetAttributeValue("month8", value);
                this.OnPropertyChanged("Month8");
            }
        }

        /// <summary>
        /// Base currency equivalent of the sales quota for the eighth month in the fiscal year.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("month8_base")]
        public Microsoft.Xrm.Sdk.Money Month8_Base
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("month8_base"); }
        }

        /// <summary>
        /// Sales quota for the ninth month in the fiscal year.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("month9")]
        public Microsoft.Xrm.Sdk.Money Month9
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("month9"); }
            set
            {
                this.OnPropertyChanging("Month9");
                this.SetAttributeValue("month9", value);
                this.OnPropertyChanged("Month9");
            }
        }

        /// <summary>
        /// Base currency equivalent of the sales quota for the ninth month in the fiscal year.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("month9_base")]
        public Microsoft.Xrm.Sdk.Money Month9_Base
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("month9_base"); }
        }

        /// <summary>
        /// Unique identifier of the associated salesperson.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("salespersonid")]
        public Microsoft.Xrm.Sdk.EntityReference SalesPersonId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("salespersonid"); }
            set
            {
                this.OnPropertyChanging("SalesPersonId");
                this.SetAttributeValue("salespersonid", value);
                this.OnPropertyChanged("SalesPersonId");
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
        /// Unique identifier of the currency associated with the monthly fiscal calendar.
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
        /// Unique identifier of the monthly fiscal calendar.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("userfiscalcalendarid")]
        public System.Nullable<System.Guid> UserFiscalCalendarId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("userfiscalcalendarid"); }
            set
            {
                this.OnPropertyChanging("UserFiscalCalendarId");
                this.SetAttributeValue("userfiscalcalendarid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("UserFiscalCalendarId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("userfiscalcalendarid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.UserFiscalCalendarId = value; }
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
        /// 1:N MonthlyFiscalCalendar_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("MonthlyFiscalCalendar_AsyncOperations")]
        public System.Collections.Generic.IEnumerable<AsyncOperation> MonthlyFiscalCalendar_AsyncOperations
        {
            get { return this.GetRelatedEntities<AsyncOperation>("MonthlyFiscalCalendar_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("MonthlyFiscalCalendar_AsyncOperations");
                this.SetRelatedEntities<AsyncOperation>("MonthlyFiscalCalendar_AsyncOperations", null, value);
                this.OnPropertyChanged("MonthlyFiscalCalendar_AsyncOperations");
            }
        }

        /// <summary>
        /// 1:N MonthlyFiscalCalendar_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("MonthlyFiscalCalendar_BulkDeleteFailures")]
        public System.Collections.Generic.IEnumerable<BulkDeleteFailure> MonthlyFiscalCalendar_BulkDeleteFailures
        {
            get { return this.GetRelatedEntities<BulkDeleteFailure>("MonthlyFiscalCalendar_BulkDeleteFailures", null); }
            set
            {
                this.OnPropertyChanging("MonthlyFiscalCalendar_BulkDeleteFailures");
                this.SetRelatedEntities<BulkDeleteFailure>("MonthlyFiscalCalendar_BulkDeleteFailures", null, value);
                this.OnPropertyChanged("MonthlyFiscalCalendar_BulkDeleteFailures");
            }
        }

        /// <summary>
        /// N:1 lk_monthlyfiscalcalendar_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_monthlyfiscalcalendar_createdby")]
        public SystemUser lk_monthlyfiscalcalendar_createdby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_monthlyfiscalcalendar_createdby", null); }
        }

        /// <summary>
        /// N:1 lk_monthlyfiscalcalendar_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_monthlyfiscalcalendar_createdonbehalfby")]
        public SystemUser lk_monthlyfiscalcalendar_createdonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_monthlyfiscalcalendar_createdonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_monthlyfiscalcalendar_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_monthlyfiscalcalendar_modifiedby")]
        public SystemUser lk_monthlyfiscalcalendar_modifiedby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_monthlyfiscalcalendar_modifiedby", null); }
        }

        /// <summary>
        /// N:1 lk_monthlyfiscalcalendar_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_monthlyfiscalcalendar_modifiedonbehalfby")]
        public SystemUser lk_monthlyfiscalcalendar_modifiedonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_monthlyfiscalcalendar_modifiedonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_monthlyfiscalcalendar_salespersonid
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("salespersonid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_monthlyfiscalcalendar_salespersonid")]
        public SystemUser lk_monthlyfiscalcalendar_salespersonid
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_monthlyfiscalcalendar_salespersonid", null); }
            set
            {
                this.OnPropertyChanging("lk_monthlyfiscalcalendar_salespersonid");
                this.SetRelatedEntity<SystemUser>("lk_monthlyfiscalcalendar_salespersonid", null, value);
                this.OnPropertyChanged("lk_monthlyfiscalcalendar_salespersonid");
            }
        }

        /// <summary>
        /// N:1 transactioncurrency_monthlyfiscalcalendar
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("transactioncurrency_monthlyfiscalcalendar")]
        public TransactionCurrency transactioncurrency_monthlyfiscalcalendar
        {
            get { return this.GetRelatedEntity<TransactionCurrency>("transactioncurrency_monthlyfiscalcalendar", null); }
            set
            {
                this.OnPropertyChanging("transactioncurrency_monthlyfiscalcalendar");
                this.SetRelatedEntity<TransactionCurrency>("transactioncurrency_monthlyfiscalcalendar", null, value);
                this.OnPropertyChanged("transactioncurrency_monthlyfiscalcalendar");
            }
        }
    }
}