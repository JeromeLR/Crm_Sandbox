﻿namespace __4_DAL_CRM
{
    /// <summary>
    /// Year long fiscal calendar of an organization. A span of time during which the financial activities of an organization are calculated.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("annualfiscalcalendar")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class AnnualFiscalCalendar : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public AnnualFiscalCalendar() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "annualfiscalcalendar";

        public const int EntityTypeCode = 2000;

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
        /// Sales quota for the first period in the fiscal year.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("annual")]
        public Microsoft.Xrm.Sdk.Money Annual
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("annual"); }
            set
            {
                this.OnPropertyChanging("Annual");
                this.SetAttributeValue("annual", value);
                this.OnPropertyChanged("Annual");
            }
        }

        /// <summary>
        /// Base currency equivalent of the sales quota for the first period in the fiscal year.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("annual_base")]
        public Microsoft.Xrm.Sdk.Money Annual_Base
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("annual_base"); }
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
        /// Unique identifier of the user who created the quota for the annual fiscal calendar.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby"); }
        }

        /// <summary>
        /// Date and time when the quota for the annual fiscal calendar was created.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
        public System.Nullable<System.DateTime> CreatedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who created the annualfiscalcalendar.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        /// Date and time when the fiscal calendar sales quota takes effect.
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
        /// Exchange rate for the currency associated with the annual fiscal calendar with respect to the base currency.
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
        /// Unique identifier of the user who last modified the quota for the annual fiscal calendar.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby"); }
        }

        /// <summary>
        /// Date and time when the annual fiscal calendar was last modified.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
        public System.Nullable<System.DateTime> ModifiedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who last modified the annualfiscalcalendar.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        /// Unique identifier of the sales person associated with the sales quota.
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
        /// Unique identifier of the currency associated with the annual fiscal calendar.
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
        /// Unique identifier of the user associated with the annual fiscal calendar.
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
        /// 1:N AnnualFiscalCalendar_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("AnnualFiscalCalendar_AsyncOperations")]
        public System.Collections.Generic.IEnumerable<AsyncOperation> AnnualFiscalCalendar_AsyncOperations
        {
            get { return this.GetRelatedEntities<AsyncOperation>("AnnualFiscalCalendar_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("AnnualFiscalCalendar_AsyncOperations");
                this.SetRelatedEntities<AsyncOperation>("AnnualFiscalCalendar_AsyncOperations", null, value);
                this.OnPropertyChanged("AnnualFiscalCalendar_AsyncOperations");
            }
        }

        /// <summary>
        /// 1:N AnnualFiscalCalendar_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("AnnualFiscalCalendar_BulkDeleteFailures")]
        public System.Collections.Generic.IEnumerable<BulkDeleteFailure> AnnualFiscalCalendar_BulkDeleteFailures
        {
            get { return this.GetRelatedEntities<BulkDeleteFailure>("AnnualFiscalCalendar_BulkDeleteFailures", null); }
            set
            {
                this.OnPropertyChanging("AnnualFiscalCalendar_BulkDeleteFailures");
                this.SetRelatedEntities<BulkDeleteFailure>("AnnualFiscalCalendar_BulkDeleteFailures", null, value);
                this.OnPropertyChanged("AnnualFiscalCalendar_BulkDeleteFailures");
            }
        }

        /// <summary>
        /// N:1 lk_annualfiscalcalendar_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_annualfiscalcalendar_createdby")]
        public SystemUser lk_annualfiscalcalendar_createdby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_annualfiscalcalendar_createdby", null); }
        }

        /// <summary>
        /// N:1 lk_annualfiscalcalendar_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_annualfiscalcalendar_createdonbehalfby")]
        public SystemUser lk_annualfiscalcalendar_createdonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_annualfiscalcalendar_createdonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_annualfiscalcalendar_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_annualfiscalcalendar_modifiedby")]
        public SystemUser lk_annualfiscalcalendar_modifiedby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_annualfiscalcalendar_modifiedby", null); }
        }

        /// <summary>
        /// N:1 lk_annualfiscalcalendar_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_annualfiscalcalendar_modifiedonbehalfby")]
        public SystemUser lk_annualfiscalcalendar_modifiedonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_annualfiscalcalendar_modifiedonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_annualfiscalcalendar_salespersonid
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("salespersonid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_annualfiscalcalendar_salespersonid")]
        public SystemUser lk_annualfiscalcalendar_salespersonid
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_annualfiscalcalendar_salespersonid", null); }
            set
            {
                this.OnPropertyChanging("lk_annualfiscalcalendar_salespersonid");
                this.SetRelatedEntity<SystemUser>("lk_annualfiscalcalendar_salespersonid", null, value);
                this.OnPropertyChanged("lk_annualfiscalcalendar_salespersonid");
            }
        }

        /// <summary>
        /// N:1 transactioncurrency_annualfiscalcalendar
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("transactioncurrency_annualfiscalcalendar")]
        public TransactionCurrency transactioncurrency_annualfiscalcalendar
        {
            get { return this.GetRelatedEntity<TransactionCurrency>("transactioncurrency_annualfiscalcalendar", null); }
            set
            {
                this.OnPropertyChanging("transactioncurrency_annualfiscalcalendar");
                this.SetRelatedEntity<TransactionCurrency>("transactioncurrency_annualfiscalcalendar", null, value);
                this.OnPropertyChanged("transactioncurrency_annualfiscalcalendar");
            }
        }
    }
}