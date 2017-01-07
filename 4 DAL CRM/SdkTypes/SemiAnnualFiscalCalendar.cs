namespace __4_DAL_CRM
{
    /// <summary>
    /// Calendar representing the semi-annual span of time during which the financial activities of an organization are calculated.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("semiannualfiscalcalendar")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class SemiAnnualFiscalCalendar : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public SemiAnnualFiscalCalendar() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "semiannualfiscalcalendar";

        public const int EntityTypeCode = 2001;

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
        /// Unique identifier of the business unit with which the calendar is associated.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("businessunitid")]
        public Microsoft.Xrm.Sdk.EntityReference BusinessUnitId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("businessunitid"); }
        }

        /// <summary>
        /// Unique identifier of the user who created the semiannual fiscal calendar.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby"); }
        }

        /// <summary>
        /// Date and time when the quota for the semiannual fiscal calendar was created.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
        public System.Nullable<System.DateTime> CreatedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who created the semiannualfiscalcalendar.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        /// Date and time when the semiannual fiscal calendar sales quota takes effect.
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
        /// Exchange rate for the currency associated with the semiannual fiscal calendar with respect to the base currency.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("exchangerate")]
        public System.Nullable<decimal> ExchangeRate
        {
            get { return this.GetAttributeValue<System.Nullable<decimal>>("exchangerate"); }
        }

        /// <summary>
        /// Sales quota for the first half of the fiscal year.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("firsthalf")]
        public Microsoft.Xrm.Sdk.Money FirstHalf
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("firsthalf"); }
            set
            {
                this.OnPropertyChanging("FirstHalf");
                this.SetAttributeValue("firsthalf", value);
                this.OnPropertyChanged("FirstHalf");
            }
        }

        /// <summary>
        /// Base currency equivalent for the sales quota for the first half of the fiscal year.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("firsthalf_base")]
        public Microsoft.Xrm.Sdk.Money FirstHalf_Base
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("firsthalf_base"); }
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
        /// Unique identifier of the user who last modified the semiannual fiscal calendar.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby"); }
        }

        /// <summary>
        /// Date and time when the semiannual fiscal calendar was last modified.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
        public System.Nullable<System.DateTime> ModifiedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who last modified the semiannualfiscalcalendar.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby"); }
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
        /// Sales quota for the second half of the fiscal year.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("secondhalf")]
        public Microsoft.Xrm.Sdk.Money SecondHalf
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("secondhalf"); }
            set
            {
                this.OnPropertyChanging("SecondHalf");
                this.SetAttributeValue("secondhalf", value);
                this.OnPropertyChanged("SecondHalf");
            }
        }

        /// <summary>
        /// Base currency equivalent of the sales quota for the second half of the fiscal year.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("secondhalf_base")]
        public Microsoft.Xrm.Sdk.Money SecondHalf_Base
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("secondhalf_base"); }
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
        /// Unique identifier of the currency associated with the semiannual fiscal calendar.
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
        /// Unique identifier for the user who created the semiannual fiscal calendar.
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
        /// 1:N SemiAnnualFiscalCalendar_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SemiAnnualFiscalCalendar_AsyncOperations")]
        public System.Collections.Generic.IEnumerable<AsyncOperation> SemiAnnualFiscalCalendar_AsyncOperations
        {
            get { return this.GetRelatedEntities<AsyncOperation>("SemiAnnualFiscalCalendar_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("SemiAnnualFiscalCalendar_AsyncOperations");
                this.SetRelatedEntities<AsyncOperation>("SemiAnnualFiscalCalendar_AsyncOperations", null, value);
                this.OnPropertyChanged("SemiAnnualFiscalCalendar_AsyncOperations");
            }
        }

        /// <summary>
        /// 1:N SemiAnnualFiscalCalendar_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SemiAnnualFiscalCalendar_BulkDeleteFailures")]
        public System.Collections.Generic.IEnumerable<BulkDeleteFailure> SemiAnnualFiscalCalendar_BulkDeleteFailures
        {
            get { return this.GetRelatedEntities<BulkDeleteFailure>("SemiAnnualFiscalCalendar_BulkDeleteFailures", null); }
            set
            {
                this.OnPropertyChanging("SemiAnnualFiscalCalendar_BulkDeleteFailures");
                this.SetRelatedEntities<BulkDeleteFailure>("SemiAnnualFiscalCalendar_BulkDeleteFailures", null, value);
                this.OnPropertyChanged("SemiAnnualFiscalCalendar_BulkDeleteFailures");
            }
        }

        /// <summary>
        /// N:1 lk_semiannualfiscalcalendar_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_semiannualfiscalcalendar_createdby")]
        public SystemUser lk_semiannualfiscalcalendar_createdby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_semiannualfiscalcalendar_createdby", null); }
        }

        /// <summary>
        /// N:1 lk_semiannualfiscalcalendar_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_semiannualfiscalcalendar_createdonbehalfby")]
        public SystemUser lk_semiannualfiscalcalendar_createdonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_semiannualfiscalcalendar_createdonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_semiannualfiscalcalendar_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_semiannualfiscalcalendar_modifiedby")]
        public SystemUser lk_semiannualfiscalcalendar_modifiedby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_semiannualfiscalcalendar_modifiedby", null); }
        }

        /// <summary>
        /// N:1 lk_semiannualfiscalcalendar_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_semiannualfiscalcalendar_modifiedonbehalfby")]
        public SystemUser lk_semiannualfiscalcalendar_modifiedonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_semiannualfiscalcalendar_modifiedonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_semiannualfiscalcalendar_salespersonid
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("salespersonid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_semiannualfiscalcalendar_salespersonid")]
        public SystemUser lk_semiannualfiscalcalendar_salespersonid
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_semiannualfiscalcalendar_salespersonid", null); }
            set
            {
                this.OnPropertyChanging("lk_semiannualfiscalcalendar_salespersonid");
                this.SetRelatedEntity<SystemUser>("lk_semiannualfiscalcalendar_salespersonid", null, value);
                this.OnPropertyChanged("lk_semiannualfiscalcalendar_salespersonid");
            }
        }

        /// <summary>
        /// N:1 transactioncurrency_semiannualfiscalcalendar
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("transactioncurrency_semiannualfiscalcalendar")]
        public TransactionCurrency transactioncurrency_semiannualfiscalcalendar
        {
            get { return this.GetRelatedEntity<TransactionCurrency>("transactioncurrency_semiannualfiscalcalendar", null); }
            set
            {
                this.OnPropertyChanging("transactioncurrency_semiannualfiscalcalendar");
                this.SetRelatedEntity<TransactionCurrency>("transactioncurrency_semiannualfiscalcalendar", null, value);
                this.OnPropertyChanged("transactioncurrency_semiannualfiscalcalendar");
            }
        }
    }
}