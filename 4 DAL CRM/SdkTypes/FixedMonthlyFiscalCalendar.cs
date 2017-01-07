namespace __4_DAL_CRM
{
    /// <summary>
    /// Fixed monthly fiscal calendar of an organization. A span of time during which the financial activities of an organization are calculated.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("fixedmonthlyfiscalcalendar")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class FixedMonthlyFiscalCalendar : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public FixedMonthlyFiscalCalendar() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "fixedmonthlyfiscalcalendar";

        public const int EntityTypeCode = 2004;

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
        /// Business unit responsible for the quota associated with this calendar.
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
        /// Date and time when the quota for the fixed monthly fiscal calendar was created.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
        public System.Nullable<System.DateTime> CreatedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who created the fixedmonthlyfiscalcalendar.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        /// Date and time when the fixed monthly fiscal calendar sales quota takes effect.
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
        /// Exchange rate for the currency associated with the fixed monthly fiscal calendar with respect to the base currency.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("exchangerate")]
        public System.Nullable<decimal> ExchangeRate
        {
            get { return this.GetAttributeValue<System.Nullable<decimal>>("exchangerate"); }
        }

        /// <summary>
        /// Type of fiscal period used in the fixed monthly fiscal calendar sales quota.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("fiscalperiodtype")]
        public System.Nullable<int> FiscalPeriodType
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("fiscalperiodtype"); }
        }

        /// <summary>
        /// Unique identifier of the user who last modified the fixed monthly fiscal calendar.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby"); }
        }

        /// <summary>
        /// Date and time when the fixed monthly fiscal calendar was last modified.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
        public System.Nullable<System.DateTime> ModifiedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who last modified the fixedmonthlyfiscalcalendar.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        /// Sales quota for the first period in the fiscal year.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("period1")]
        public Microsoft.Xrm.Sdk.Money Period1
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("period1"); }
            set
            {
                this.OnPropertyChanging("Period1");
                this.SetAttributeValue("period1", value);
                this.OnPropertyChanged("Period1");
            }
        }

        /// <summary>
        /// Base currency equivalent of the sales quota for the first period in the fiscal year.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("period1_base")]
        public Microsoft.Xrm.Sdk.Money Period1_Base
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("period1_base"); }
        }

        /// <summary>
        /// Sales quota for the tenth period in the fiscal year.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("period10")]
        public Microsoft.Xrm.Sdk.Money Period10
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("period10"); }
            set
            {
                this.OnPropertyChanging("Period10");
                this.SetAttributeValue("period10", value);
                this.OnPropertyChanged("Period10");
            }
        }

        /// <summary>
        /// Base currency equivalent of the sales quota for the tenth period in the fiscal year.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("period10_base")]
        public Microsoft.Xrm.Sdk.Money Period10_Base
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("period10_base"); }
        }

        /// <summary>
        /// Sales quota for the eleventh period in the fiscal year.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("period11")]
        public Microsoft.Xrm.Sdk.Money Period11
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("period11"); }
            set
            {
                this.OnPropertyChanging("Period11");
                this.SetAttributeValue("period11", value);
                this.OnPropertyChanged("Period11");
            }
        }

        /// <summary>
        /// Base currency equivalent of the sales quota for the eleventh period in the fiscal year.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("period11_base")]
        public Microsoft.Xrm.Sdk.Money Period11_Base
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("period11_base"); }
        }

        /// <summary>
        /// Sales quota for the twelfth period in the fiscal year.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("period12")]
        public Microsoft.Xrm.Sdk.Money Period12
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("period12"); }
            set
            {
                this.OnPropertyChanging("Period12");
                this.SetAttributeValue("period12", value);
                this.OnPropertyChanged("Period12");
            }
        }

        /// <summary>
        /// Base currency equivalent of the sales quota for the twelfth period in the fiscal year.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("period12_base")]
        public Microsoft.Xrm.Sdk.Money Period12_Base
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("period12_base"); }
        }

        /// <summary>
        /// Sales quota for the thirteenth period in the fiscal year.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("period13")]
        public Microsoft.Xrm.Sdk.Money Period13
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("period13"); }
            set
            {
                this.OnPropertyChanging("Period13");
                this.SetAttributeValue("period13", value);
                this.OnPropertyChanged("Period13");
            }
        }

        /// <summary>
        /// Base currency equivalent of the sales quota for the thirteenth period in the fiscal year.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("period13_base")]
        public Microsoft.Xrm.Sdk.Money Period13_Base
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("period13_base"); }
        }

        /// <summary>
        /// Sales quota for the second period in the fiscal year.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("period2")]
        public Microsoft.Xrm.Sdk.Money Period2
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("period2"); }
            set
            {
                this.OnPropertyChanging("Period2");
                this.SetAttributeValue("period2", value);
                this.OnPropertyChanged("Period2");
            }
        }

        /// <summary>
        /// Base currency equivalent of the sales quota for the second period in the fiscal year.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("period2_base")]
        public Microsoft.Xrm.Sdk.Money Period2_Base
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("period2_base"); }
        }

        /// <summary>
        /// Sales quota for the third period in the fiscal year.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("period3")]
        public Microsoft.Xrm.Sdk.Money Period3
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("period3"); }
            set
            {
                this.OnPropertyChanging("Period3");
                this.SetAttributeValue("period3", value);
                this.OnPropertyChanged("Period3");
            }
        }

        /// <summary>
        /// Base currency equivalent of the sales quota for the third period in the fiscal year.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("period3_base")]
        public Microsoft.Xrm.Sdk.Money Period3_Base
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("period3_base"); }
        }

        /// <summary>
        /// Sales quota for the fourth period in the fiscal year.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("period4")]
        public Microsoft.Xrm.Sdk.Money Period4
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("period4"); }
            set
            {
                this.OnPropertyChanging("Period4");
                this.SetAttributeValue("period4", value);
                this.OnPropertyChanged("Period4");
            }
        }

        /// <summary>
        /// Base currency equivalent of the sales quota for the fourth period in the fiscal year.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("period4_base")]
        public Microsoft.Xrm.Sdk.Money Period4_Base
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("period4_base"); }
        }

        /// <summary>
        /// Sales quota for the fifth period in the fiscal year.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("period5")]
        public Microsoft.Xrm.Sdk.Money Period5
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("period5"); }
            set
            {
                this.OnPropertyChanging("Period5");
                this.SetAttributeValue("period5", value);
                this.OnPropertyChanged("Period5");
            }
        }

        /// <summary>
        /// Base currency equivalent of the sales quota for the fifth period in the fiscal year.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("period5_base")]
        public Microsoft.Xrm.Sdk.Money Period5_Base
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("period5_base"); }
        }

        /// <summary>
        /// Sales quota for the sixth period in the fiscal year.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("period6")]
        public Microsoft.Xrm.Sdk.Money Period6
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("period6"); }
            set
            {
                this.OnPropertyChanging("Period6");
                this.SetAttributeValue("period6", value);
                this.OnPropertyChanged("Period6");
            }
        }

        /// <summary>
        /// Base currency equivalent of the sales quota for the sixth period in the fiscal year.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("period6_base")]
        public Microsoft.Xrm.Sdk.Money Period6_Base
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("period6_base"); }
        }

        /// <summary>
        /// Sales quota for the seventh period in the fiscal year.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("period7")]
        public Microsoft.Xrm.Sdk.Money Period7
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("period7"); }
            set
            {
                this.OnPropertyChanging("Period7");
                this.SetAttributeValue("period7", value);
                this.OnPropertyChanged("Period7");
            }
        }

        /// <summary>
        /// Base currency equivalent of the sales quota for the seventh period in the fiscal year.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("period7_base")]
        public Microsoft.Xrm.Sdk.Money Period7_Base
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("period7_base"); }
        }

        /// <summary>
        /// Sales quota for the eighth period in the fiscal year.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("period8")]
        public Microsoft.Xrm.Sdk.Money Period8
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("period8"); }
            set
            {
                this.OnPropertyChanging("Period8");
                this.SetAttributeValue("period8", value);
                this.OnPropertyChanged("Period8");
            }
        }

        /// <summary>
        /// Base currency equivalent of the sales quota for the eighth period in the fiscal year.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("period8_base")]
        public Microsoft.Xrm.Sdk.Money Period8_Base
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("period8_base"); }
        }

        /// <summary>
        /// Sales quota for the ninth period in the fiscal year.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("period9")]
        public Microsoft.Xrm.Sdk.Money Period9
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("period9"); }
            set
            {
                this.OnPropertyChanging("Period9");
                this.SetAttributeValue("period9", value);
                this.OnPropertyChanged("Period9");
            }
        }

        /// <summary>
        /// Base currency equivalent of the sales quota for the ninth period in the fiscal year.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("period9_base")]
        public Microsoft.Xrm.Sdk.Money Period9_Base
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("period9_base"); }
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
        /// Unique identifier of the currency associated with the fixed monthly fiscal calendar.
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
        /// Unique identifier of the user of the fiscal calendar.
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
        /// 1:N FixedMonthlyFiscalCalendar_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("FixedMonthlyFiscalCalendar_AsyncOperations")]
        public System.Collections.Generic.IEnumerable<AsyncOperation> FixedMonthlyFiscalCalendar_AsyncOperations
        {
            get { return this.GetRelatedEntities<AsyncOperation>("FixedMonthlyFiscalCalendar_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("FixedMonthlyFiscalCalendar_AsyncOperations");
                this.SetRelatedEntities<AsyncOperation>("FixedMonthlyFiscalCalendar_AsyncOperations", null, value);
                this.OnPropertyChanged("FixedMonthlyFiscalCalendar_AsyncOperations");
            }
        }

        /// <summary>
        /// 1:N FixedMonthlyFiscalCalendar_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("FixedMonthlyFiscalCalendar_BulkDeleteFailures")]
        public System.Collections.Generic.IEnumerable<BulkDeleteFailure> FixedMonthlyFiscalCalendar_BulkDeleteFailures
        {
            get { return this.GetRelatedEntities<BulkDeleteFailure>("FixedMonthlyFiscalCalendar_BulkDeleteFailures", null); }
            set
            {
                this.OnPropertyChanging("FixedMonthlyFiscalCalendar_BulkDeleteFailures");
                this.SetRelatedEntities<BulkDeleteFailure>("FixedMonthlyFiscalCalendar_BulkDeleteFailures", null, value);
                this.OnPropertyChanged("FixedMonthlyFiscalCalendar_BulkDeleteFailures");
            }
        }

        /// <summary>
        /// N:1 lk_fixedmonthlyfiscalcalendar_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_fixedmonthlyfiscalcalendar_createdby")]
        public SystemUser lk_fixedmonthlyfiscalcalendar_createdby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_fixedmonthlyfiscalcalendar_createdby", null); }
        }

        /// <summary>
        /// N:1 lk_fixedmonthlyfiscalcalendar_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_fixedmonthlyfiscalcalendar_createdonbehalfby")]
        public SystemUser lk_fixedmonthlyfiscalcalendar_createdonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_fixedmonthlyfiscalcalendar_createdonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_fixedmonthlyfiscalcalendar_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_fixedmonthlyfiscalcalendar_modifiedby")]
        public SystemUser lk_fixedmonthlyfiscalcalendar_modifiedby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_fixedmonthlyfiscalcalendar_modifiedby", null); }
        }

        /// <summary>
        /// N:1 lk_fixedmonthlyfiscalcalendar_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_fixedmonthlyfiscalcalendar_modifiedonbehalfby")]
        public SystemUser lk_fixedmonthlyfiscalcalendar_modifiedonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_fixedmonthlyfiscalcalendar_modifiedonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_fixedmonthlyfiscalcalendar_salespersonid
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("salespersonid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_fixedmonthlyfiscalcalendar_salespersonid")]
        public SystemUser lk_fixedmonthlyfiscalcalendar_salespersonid
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_fixedmonthlyfiscalcalendar_salespersonid", null); }
            set
            {
                this.OnPropertyChanging("lk_fixedmonthlyfiscalcalendar_salespersonid");
                this.SetRelatedEntity<SystemUser>("lk_fixedmonthlyfiscalcalendar_salespersonid", null, value);
                this.OnPropertyChanged("lk_fixedmonthlyfiscalcalendar_salespersonid");
            }
        }

        /// <summary>
        /// N:1 transactioncurrency_fixedmonthlyfiscalcalendar
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("transactioncurrency_fixedmonthlyfiscalcalendar")]
        public TransactionCurrency transactioncurrency_fixedmonthlyfiscalcalendar
        {
            get { return this.GetRelatedEntity<TransactionCurrency>("transactioncurrency_fixedmonthlyfiscalcalendar", null); }
            set
            {
                this.OnPropertyChanging("transactioncurrency_fixedmonthlyfiscalcalendar");
                this.SetRelatedEntity<TransactionCurrency>("transactioncurrency_fixedmonthlyfiscalcalendar", null, value);
                this.OnPropertyChanged("transactioncurrency_fixedmonthlyfiscalcalendar");
            }
        }
    }
}