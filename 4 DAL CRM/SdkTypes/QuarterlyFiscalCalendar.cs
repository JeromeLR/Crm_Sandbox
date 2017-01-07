namespace __4_DAL_CRM
{
    /// <summary>
    /// Quarterly fiscal calendar of an organization. A span of time during which the financial activities of an organization are calculated.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("quarterlyfiscalcalendar")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class QuarterlyFiscalCalendar : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public QuarterlyFiscalCalendar() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "quarterlyfiscalcalendar";

        public const int EntityTypeCode = 2002;

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
        /// Unique identifier of the user who created the quarterly fiscal calendar.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby"); }
        }

        /// <summary>
        /// Date and time when the quota for the quarterly fiscal calendar was created.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
        public System.Nullable<System.DateTime> CreatedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who created the quarterlyfiscalcalendar.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        /// Date and time when the quarterly fiscal calendar sales quota takes effect.
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
        /// Exchange rate for the currency associated with the quarterly fiscal calendar with respect to the base currency.
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
        /// Unique identifier of the user who last modified the quarterly fiscal calendar.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby"); }
        }

        /// <summary>
        /// Date and time when the quarterly fiscal calendar was last modified.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
        public System.Nullable<System.DateTime> ModifiedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who last modified the quarterlyfiscalcalendar.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        /// Sales quota for the first quarter in the fiscal year.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("quarter1")]
        public Microsoft.Xrm.Sdk.Money Quarter1
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("quarter1"); }
            set
            {
                this.OnPropertyChanging("Quarter1");
                this.SetAttributeValue("quarter1", value);
                this.OnPropertyChanged("Quarter1");
            }
        }

        /// <summary>
        /// Base currency equivalent of the sales quota for the first quarter in the fiscal year.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("quarter1_base")]
        public Microsoft.Xrm.Sdk.Money Quarter1_Base
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("quarter1_base"); }
        }

        /// <summary>
        /// Sales quota for the second quarter in the fiscal year.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("quarter2")]
        public Microsoft.Xrm.Sdk.Money Quarter2
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("quarter2"); }
            set
            {
                this.OnPropertyChanging("Quarter2");
                this.SetAttributeValue("quarter2", value);
                this.OnPropertyChanged("Quarter2");
            }
        }

        /// <summary>
        /// Base currency equivalent of the sales quota for the second quarter in the fiscal year
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("quarter2_base")]
        public Microsoft.Xrm.Sdk.Money Quarter2_Base
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("quarter2_base"); }
        }

        /// <summary>
        /// Sales quota for the third quarter in the fiscal year.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("quarter3")]
        public Microsoft.Xrm.Sdk.Money Quarter3
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("quarter3"); }
            set
            {
                this.OnPropertyChanging("Quarter3");
                this.SetAttributeValue("quarter3", value);
                this.OnPropertyChanged("Quarter3");
            }
        }

        /// <summary>
        /// Base currency equivalent of the sales quota for the third quarter in the fiscal year.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("quarter3_base")]
        public Microsoft.Xrm.Sdk.Money Quarter3_Base
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("quarter3_base"); }
        }

        /// <summary>
        /// Sales quota for the fourth quarter in the fiscal year.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("quarter4")]
        public Microsoft.Xrm.Sdk.Money Quarter4
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("quarter4"); }
            set
            {
                this.OnPropertyChanging("Quarter4");
                this.SetAttributeValue("quarter4", value);
                this.OnPropertyChanged("Quarter4");
            }
        }

        /// <summary>
        /// Base currency equivalent of the sales quota for the fourth quarter in the fiscal year.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("quarter4_base")]
        public Microsoft.Xrm.Sdk.Money Quarter4_Base
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("quarter4_base"); }
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
        /// Unique identifier of the currency associated with the quarterly fiscal calendar.
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
        /// Unique identifier of the quarterly fiscal calendar.
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
        /// 1:N QuarterlyFiscalCalendar_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("QuarterlyFiscalCalendar_AsyncOperations")]
        public System.Collections.Generic.IEnumerable<AsyncOperation> QuarterlyFiscalCalendar_AsyncOperations
        {
            get { return this.GetRelatedEntities<AsyncOperation>("QuarterlyFiscalCalendar_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("QuarterlyFiscalCalendar_AsyncOperations");
                this.SetRelatedEntities<AsyncOperation>("QuarterlyFiscalCalendar_AsyncOperations", null, value);
                this.OnPropertyChanged("QuarterlyFiscalCalendar_AsyncOperations");
            }
        }

        /// <summary>
        /// 1:N QuarterlyFiscalCalendar_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("QuarterlyFiscalCalendar_BulkDeleteFailures")]
        public System.Collections.Generic.IEnumerable<BulkDeleteFailure> QuarterlyFiscalCalendar_BulkDeleteFailures
        {
            get { return this.GetRelatedEntities<BulkDeleteFailure>("QuarterlyFiscalCalendar_BulkDeleteFailures", null); }
            set
            {
                this.OnPropertyChanging("QuarterlyFiscalCalendar_BulkDeleteFailures");
                this.SetRelatedEntities<BulkDeleteFailure>("QuarterlyFiscalCalendar_BulkDeleteFailures", null, value);
                this.OnPropertyChanged("QuarterlyFiscalCalendar_BulkDeleteFailures");
            }
        }

        /// <summary>
        /// N:1 lk_quarterlyfiscalcalendar_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_quarterlyfiscalcalendar_createdby")]
        public SystemUser lk_quarterlyfiscalcalendar_createdby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_quarterlyfiscalcalendar_createdby", null); }
        }

        /// <summary>
        /// N:1 lk_quarterlyfiscalcalendar_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_quarterlyfiscalcalendar_createdonbehalfby")]
        public SystemUser lk_quarterlyfiscalcalendar_createdonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_quarterlyfiscalcalendar_createdonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_quarterlyfiscalcalendar_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_quarterlyfiscalcalendar_modifiedby")]
        public SystemUser lk_quarterlyfiscalcalendar_modifiedby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_quarterlyfiscalcalendar_modifiedby", null); }
        }

        /// <summary>
        /// N:1 lk_quarterlyfiscalcalendar_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_quarterlyfiscalcalendar_modifiedonbehalfby")]
        public SystemUser lk_quarterlyfiscalcalendar_modifiedonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_quarterlyfiscalcalendar_modifiedonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_quarterlyfiscalcalendar_salespersonid
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("salespersonid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_quarterlyfiscalcalendar_salespersonid")]
        public SystemUser lk_quarterlyfiscalcalendar_salespersonid
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_quarterlyfiscalcalendar_salespersonid", null); }
            set
            {
                this.OnPropertyChanging("lk_quarterlyfiscalcalendar_salespersonid");
                this.SetRelatedEntity<SystemUser>("lk_quarterlyfiscalcalendar_salespersonid", null, value);
                this.OnPropertyChanged("lk_quarterlyfiscalcalendar_salespersonid");
            }
        }

        /// <summary>
        /// N:1 transactioncurrency_quarterlyfiscalcalendar
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("transactioncurrency_quarterlyfiscalcalendar")]
        public TransactionCurrency transactioncurrency_quarterlyfiscalcalendar
        {
            get { return this.GetRelatedEntity<TransactionCurrency>("transactioncurrency_quarterlyfiscalcalendar", null); }
            set
            {
                this.OnPropertyChanging("transactioncurrency_quarterlyfiscalcalendar");
                this.SetRelatedEntity<TransactionCurrency>("transactioncurrency_quarterlyfiscalcalendar", null, value);
                this.OnPropertyChanged("transactioncurrency_quarterlyfiscalcalendar");
            }
        }
    }
}