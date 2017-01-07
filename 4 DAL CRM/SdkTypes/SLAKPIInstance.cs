namespace __4_DAL_CRM
{
    /// <summary>
    /// Service level agreement (SLA) key performance indicator (KPI) instance that is tracked for an individual case
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("slakpiinstance")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class SLAKPIInstance : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public SLAKPIInstance() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "slakpiinstance";

        public const int EntityTypeCode = 9752;

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
        /// Computed Failure Date and time
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("computedfailuretime")]
        public System.Nullable<System.DateTime> ComputedFailureTime
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("computedfailuretime"); }
            set
            {
                this.OnPropertyChanging("ComputedFailureTime");
                this.SetAttributeValue("computedfailuretime", value);
                this.OnPropertyChanged("ComputedFailureTime");
            }
        }

        /// <summary>
        /// Computed Warning Date and time
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("computedwarningtime")]
        public System.Nullable<System.DateTime> ComputedWarningTime
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("computedwarningtime"); }
            set
            {
                this.OnPropertyChanging("ComputedWarningTime");
                this.SetAttributeValue("computedwarningtime", value);
                this.OnPropertyChanged("ComputedWarningTime");
            }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby"); }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
        public System.Nullable<System.DateTime> CreatedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon"); }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("description")]
        public string Description
        {
            get { return this.GetAttributeValue<string>("description"); }
            set
            {
                this.OnPropertyChanging("Description");
                this.SetAttributeValue("description", value);
                this.OnPropertyChanged("Description");
            }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("exchangerate")]
        public System.Nullable<decimal> ExchangeRate
        {
            get { return this.GetAttributeValue<System.Nullable<decimal>>("exchangerate"); }
        }

        /// <summary>
        /// Enter the date and time when the service level agreement (SLA) key performance indicator (KPI) will expire.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("failuretime")]
        public System.Nullable<System.DateTime> FailureTime
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("failuretime"); }
            set
            {
                this.OnPropertyChanging("FailureTime");
                this.SetAttributeValue("failuretime", value);
                this.OnPropertyChanged("FailureTime");
            }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby"); }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
        public System.Nullable<System.DateTime> ModifiedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon"); }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        /// Type a descriptive name for the service level agreement (SLA) key performance indicator (KPI) instance.
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
        /// Enter the user or team who is assigned to manage the record. This field is updated every time the record is assigned to a different user or team.
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
        /// Owning Business Unit.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
        public Microsoft.Xrm.Sdk.EntityReference OwningBusinessUnit
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningbusinessunit"); }
            set
            {
                this.OnPropertyChanging("OwningBusinessUnit");
                this.SetAttributeValue("owningbusinessunit", value);
                this.OnPropertyChanged("OwningBusinessUnit");
            }
        }

        /// <summary>
        /// OwningTeam.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
        public Microsoft.Xrm.Sdk.EntityReference OwningTeam
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningteam"); }
            set
            {
                this.OnPropertyChanging("OwningTeam");
                this.SetAttributeValue("owningteam", value);
                this.OnPropertyChanged("OwningTeam");
            }
        }

        /// <summary>
        /// Owning User.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
        public Microsoft.Xrm.Sdk.EntityReference OwningUser
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owninguser"); }
            set
            {
                this.OnPropertyChanging("OwningUser");
                this.SetAttributeValue("owninguser", value);
                this.OnPropertyChanged("OwningUser");
            }
        }

        /// <summary>
        /// Unique identifier of the record that this service level agreement (SLA) key performance indicator (KPI) instance is associated with.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regarding")]
        public Microsoft.Xrm.Sdk.EntityReference Regarding
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("regarding"); }
            set
            {
                this.OnPropertyChanging("Regarding");
                this.SetAttributeValue("regarding", value);
                this.OnPropertyChanged("Regarding");
            }
        }

        /// <summary>
        /// Unique identifier of the SLA KPI Instance.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("slakpiinstanceid")]
        public System.Nullable<System.Guid> SLAKPIInstanceId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("slakpiinstanceid"); }
            set
            {
                this.OnPropertyChanging("SLAKPIInstanceId");
                this.SetAttributeValue("slakpiinstanceid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("SLAKPIInstanceId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("slakpiinstanceid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.SLAKPIInstanceId = value; }
        }

        /// <summary>
        /// Reason for the status of the service level agreement (SLA) key performance indicator (KPI) instance. For example, the SLA KPI could be Noncompliant or Succeeded.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("status")]
        public Microsoft.Xrm.Sdk.OptionSetValue Status
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("status"); }
            set
            {
                this.OnPropertyChanging("Status");
                this.SetAttributeValue("status", value);
                this.OnPropertyChanged("Status");
            }
        }

        /// <summary>
        /// Shows the date and time when the service level agreement (SLA) key performance indicator (KPI) success criteria was met.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("succeededon")]
        public System.Nullable<System.DateTime> SucceededOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("succeededon"); }
            set
            {
                this.OnPropertyChanging("SucceededOn");
                this.SetAttributeValue("succeededon", value);
                this.OnPropertyChanged("SucceededOn");
            }
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
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
        public System.Nullable<long> VersionNumber
        {
            get { return this.GetAttributeValue<System.Nullable<long>>("versionnumber"); }
        }

        /// <summary>
        /// Enter the date and time when the service level agreement (SLA) key performance indicator (KPI)will go to a warning state.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("warningtime")]
        public System.Nullable<System.DateTime> WarningTime
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("warningtime"); }
            set
            {
                this.OnPropertyChanging("WarningTime");
                this.SetAttributeValue("warningtime", value);
                this.OnPropertyChanged("WarningTime");
            }
        }

        /// <summary>
        /// Shows information about whether the case has reached its warning time.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("warningtimereached")]
        public Microsoft.Xrm.Sdk.OptionSetValue WarningTimeReached
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("warningtimereached"); }
            set
            {
                this.OnPropertyChanging("WarningTimeReached");
                this.SetAttributeValue("warningtimereached", value);
                this.OnPropertyChanged("WarningTimeReached");
            }
        }

        /// <summary>
        /// 1:N slakpiinstance_incident_firstresponsebykpi
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("slakpiinstance_incident_firstresponsebykpi")]
        public System.Collections.Generic.IEnumerable<Incident> slakpiinstance_incident_firstresponsebykpi
        {
            get { return this.GetRelatedEntities<Incident>("slakpiinstance_incident_firstresponsebykpi", null); }
            set
            {
                this.OnPropertyChanging("slakpiinstance_incident_firstresponsebykpi");
                this.SetRelatedEntities<Incident>("slakpiinstance_incident_firstresponsebykpi", null, value);
                this.OnPropertyChanged("slakpiinstance_incident_firstresponsebykpi");
            }
        }

        /// <summary>
        /// 1:N slakpiinstance_incident_resolvebykpi
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("slakpiinstance_incident_resolvebykpi")]
        public System.Collections.Generic.IEnumerable<Incident> slakpiinstance_incident_resolvebykpi
        {
            get { return this.GetRelatedEntities<Incident>("slakpiinstance_incident_resolvebykpi", null); }
            set
            {
                this.OnPropertyChanging("slakpiinstance_incident_resolvebykpi");
                this.SetRelatedEntities<Incident>("slakpiinstance_incident_resolvebykpi", null, value);
                this.OnPropertyChanged("slakpiinstance_incident_resolvebykpi");
            }
        }

        /// <summary>
        /// N:1 business_unit_slakpiinstance
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_slakpiinstance")]
        public BusinessUnit business_unit_slakpiinstance
        {
            get { return this.GetRelatedEntity<BusinessUnit>("business_unit_slakpiinstance", null); }
            set
            {
                this.OnPropertyChanging("business_unit_slakpiinstance");
                this.SetRelatedEntity<BusinessUnit>("business_unit_slakpiinstance", null, value);
                this.OnPropertyChanged("business_unit_slakpiinstance");
            }
        }

        /// <summary>
        /// N:1 lk_slakpiinstancebase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_slakpiinstancebase_createdby")]
        public SystemUser lk_slakpiinstancebase_createdby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_slakpiinstancebase_createdby", null); }
        }

        /// <summary>
        /// N:1 lk_slakpiinstancebase_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_slakpiinstancebase_createdonbehalfby")]
        public SystemUser lk_slakpiinstancebase_createdonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_slakpiinstancebase_createdonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_slakpiinstancebase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_slakpiinstancebase_modifiedby")]
        public SystemUser lk_slakpiinstancebase_modifiedby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_slakpiinstancebase_modifiedby", null); }
        }

        /// <summary>
        /// N:1 lk_slakpiinstancebase_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_slakpiinstancebase_modifiedonbehalfby")]
        public SystemUser lk_slakpiinstancebase_modifiedonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_slakpiinstancebase_modifiedonbehalfby", null); }
        }

        /// <summary>
        /// N:1 slakpiinstance_incident
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regarding")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("slakpiinstance_incident")]
        public Incident slakpiinstance_incident
        {
            get { return this.GetRelatedEntity<Incident>("slakpiinstance_incident", null); }
            set
            {
                this.OnPropertyChanging("slakpiinstance_incident");
                this.SetRelatedEntity<Incident>("slakpiinstance_incident", null, value);
                this.OnPropertyChanged("slakpiinstance_incident");
            }
        }

        /// <summary>
        /// N:1 TransactionCurrency_slakpiinstance
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("TransactionCurrency_slakpiinstance")]
        public TransactionCurrency TransactionCurrency_slakpiinstance
        {
            get { return this.GetRelatedEntity<TransactionCurrency>("TransactionCurrency_slakpiinstance", null); }
            set
            {
                this.OnPropertyChanging("TransactionCurrency_slakpiinstance");
                this.SetRelatedEntity<TransactionCurrency>("TransactionCurrency_slakpiinstance", null, value);
                this.OnPropertyChanged("TransactionCurrency_slakpiinstance");
            }
        }
    }
}