namespace __4_DAL_CRM
{
    /// <summary>
    /// Contains information about the tracked service-level KPIs for cases that belong to different customers.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("sla")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class SLA : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public SLA() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "sla";

        public const int EntityTypeCode = 9750;

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
        /// Select whether this SLA will allow pausing and resuming during the time calculation.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("allowpauseresume")]
        public System.Nullable<bool> AllowPauseResume
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("allowpauseresume"); }
            set
            {
                this.OnPropertyChanging("AllowPauseResume");
                this.SetAttributeValue("allowpauseresume", value);
                this.OnPropertyChanged("AllowPauseResume");
            }
        }

        /// <summary>
        /// Select the field that specifies the date and time from which the SLA items will be calculated for the case record. For example, if you select the Case Created On field, SLA calculation will begin from the time the case is created. 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("applicablefrom")]
        public string ApplicableFrom
        {
            get { return this.GetAttributeValue<string>("applicablefrom"); }
            set
            {
                this.OnPropertyChanging("ApplicableFrom");
                this.SetAttributeValue("applicablefrom", value);
                this.OnPropertyChanged("ApplicableFrom");
            }
        }

        /// <summary>
        /// Select the field that specifies the date and time from which the SLA items will be calculated. For example, if you select the Case Created On field, SLA calculation will begin from the time the case is created.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("applicablefrompicklist")]
        public Microsoft.Xrm.Sdk.OptionSetValue ApplicableFromPickList
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("applicablefrompicklist"); }
            set
            {
                this.OnPropertyChanging("ApplicableFromPickList");
                this.SetAttributeValue("applicablefrompicklist", value);
                this.OnPropertyChanged("ApplicableFromPickList");
            }
        }

        /// <summary>
        /// Choose the business hours for calculating SLA item timelines.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("businesshoursid")]
        public Microsoft.Xrm.Sdk.EntityReference BusinessHoursId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("businesshoursid"); }
            set
            {
                this.OnPropertyChanging("BusinessHoursId");
                this.SetAttributeValue("businesshoursid", value);
                this.OnPropertyChanged("BusinessHoursId");
            }
        }

        /// <summary>
        /// Type additional information to describe the SLA
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("changedattributelist")]
        public string ChangedAttributeList
        {
            get { return this.GetAttributeValue<string>("changedattributelist"); }
            set
            {
                this.OnPropertyChanging("ChangedAttributeList");
                this.SetAttributeValue("changedattributelist", value);
                this.OnPropertyChanged("ChangedAttributeList");
            }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("componentstate")]
        public Microsoft.Xrm.Sdk.OptionSetValue ComponentState
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("componentstate"); }
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
        /// Type additional information to describe the SLA
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
        /// Exchange rate between the currency associated with the SLA record and the base currency.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("exchangerate")]
        public System.Nullable<decimal> ExchangeRate
        {
            get { return this.GetAttributeValue<System.Nullable<decimal>>("exchangerate"); }
        }

        /// <summary>
        /// Tells whether this SLA is the default one.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isdefault")]
        public System.Nullable<bool> IsDefault
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("isdefault"); }
            set
            {
                this.OnPropertyChanging("IsDefault");
                this.SetAttributeValue("isdefault", value);
                this.OnPropertyChanged("IsDefault");
            }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ismanaged")]
        public System.Nullable<bool> IsManaged
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("ismanaged"); }
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
        /// Shows who created the record on behalf of another user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        /// Type a descriptive name of the service level agreement (SLA).
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
        /// Choose the entity type that the SLA is defined.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objecttypecode")]
        public Microsoft.Xrm.Sdk.OptionSetValue ObjectTypeCode
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("objecttypecode"); }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("overwritetime")]
        public System.Nullable<System.DateTime> OverwriteTime
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("overwritetime"); }
        }

        /// <summary>
        /// Enter the user or team who owns the SLA. This field is updated every time the item is assigned to a different user.
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
        /// Unique identifier for the business unit that owns the record
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
        /// Unique identifier for the team that owns the record.
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
        /// Unique identifier for the user that owns the record.
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
        /// Unique identifier of the SLA.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("slaid")]
        public System.Nullable<System.Guid> SLAId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("slaid"); }
            set
            {
                this.OnPropertyChanging("SLAId");
                this.SetAttributeValue("slaid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("SLAId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("slaid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.SLAId = value; }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("slaidunique")]
        public System.Nullable<System.Guid> SLAIdUnique
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("slaidunique"); }
        }

        /// <summary>
        /// Select the type of service level agreement (SLA).
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("slatype")]
        public Microsoft.Xrm.Sdk.OptionSetValue SLAType
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("slatype"); }
            set
            {
                this.OnPropertyChanging("SLAType");
                this.SetAttributeValue("slatype", value);
                this.OnPropertyChanged("SLAType");
            }
        }

        /// <summary>
        /// Unique identifier of the associated solution.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("solutionid")]
        public System.Nullable<System.Guid> SolutionId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("solutionid"); }
        }

        /// <summary>
        /// Shows whether the Service Level Agreement (SLA) is active or inactive.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
        public System.Nullable<SLAState> StateCode
        {
            get
            {
                Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
                if ((optionSet != null))
                {
                    return ((SLAState) (System.Enum.ToObject(typeof(SLAState), optionSet.Value)));
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.OnPropertyChanging("StateCode");
                if ((value == null))
                {
                    this.SetAttributeValue("statecode", null);
                }
                else
                {
                    this.SetAttributeValue("statecode", new Microsoft.Xrm.Sdk.OptionSetValue(((int) (value))));
                }
                this.OnPropertyChanged("StateCode");
            }
        }

        /// <summary>
        /// Select the status of the service level agreement (SLA).
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
        /// Unique identifier of the currency associated with the SLA record.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyid")]
        public Microsoft.Xrm.Sdk.EntityReference TransactionCurrencyId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("transactioncurrencyid"); }
        }

        /// <summary>
        /// Version number of the SLA.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
        public System.Nullable<long> VersionNumber
        {
            get { return this.GetAttributeValue<System.Nullable<long>>("versionnumber"); }
        }

        /// <summary>
        /// Workflow associated with the SLA.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("workflowid")]
        public Microsoft.Xrm.Sdk.EntityReference WorkflowId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("workflowid"); }
            set
            {
                this.OnPropertyChanging("WorkflowId");
                this.SetAttributeValue("workflowid", value);
                this.OnPropertyChanged("WorkflowId");
            }
        }

        /// <summary>
        /// 1:N sla_Annotation
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("sla_Annotation")]
        public System.Collections.Generic.IEnumerable<Annotation> sla_Annotation
        {
            get { return this.GetRelatedEntities<Annotation>("sla_Annotation", null); }
            set
            {
                this.OnPropertyChanging("sla_Annotation");
                this.SetRelatedEntities<Annotation>("sla_Annotation", null, value);
                this.OnPropertyChanged("sla_Annotation");
            }
        }

        /// <summary>
        /// 1:N sla_cases
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("sla_cases")]
        public System.Collections.Generic.IEnumerable<Incident> sla_cases
        {
            get { return this.GetRelatedEntities<Incident>("sla_cases", null); }
            set
            {
                this.OnPropertyChanging("sla_cases");
                this.SetRelatedEntities<Incident>("sla_cases", null, value);
                this.OnPropertyChanged("sla_cases");
            }
        }

        /// <summary>
        /// 1:N sla_entitlement
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("sla_entitlement")]
        public System.Collections.Generic.IEnumerable<Entitlement> sla_entitlement
        {
            get { return this.GetRelatedEntities<Entitlement>("sla_entitlement", null); }
            set
            {
                this.OnPropertyChanging("sla_entitlement");
                this.SetRelatedEntities<Entitlement>("sla_entitlement", null, value);
                this.OnPropertyChanged("sla_entitlement");
            }
        }

        /// <summary>
        /// 1:N sla_entitlementtemplate
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("sla_entitlementtemplate")]
        public System.Collections.Generic.IEnumerable<EntitlementTemplate> sla_entitlementtemplate
        {
            get { return this.GetRelatedEntities<EntitlementTemplate>("sla_entitlementtemplate", null); }
            set
            {
                this.OnPropertyChanging("sla_entitlementtemplate");
                this.SetRelatedEntities<EntitlementTemplate>("sla_entitlementtemplate", null, value);
                this.OnPropertyChanged("sla_entitlementtemplate");
            }
        }

        /// <summary>
        /// 1:N sla_slaitem_slaId
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("sla_slaitem_slaId")]
        public System.Collections.Generic.IEnumerable<SLAItem> sla_slaitem_slaId
        {
            get { return this.GetRelatedEntities<SLAItem>("sla_slaitem_slaId", null); }
            set
            {
                this.OnPropertyChanging("sla_slaitem_slaId");
                this.SetRelatedEntities<SLAItem>("sla_slaitem_slaId", null, value);
                this.OnPropertyChanged("sla_slaitem_slaId");
            }
        }

        /// <summary>
        /// 1:N slabase_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("slabase_AsyncOperations")]
        public System.Collections.Generic.IEnumerable<AsyncOperation> slabase_AsyncOperations
        {
            get { return this.GetRelatedEntities<AsyncOperation>("slabase_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("slabase_AsyncOperations");
                this.SetRelatedEntities<AsyncOperation>("slabase_AsyncOperations", null, value);
                this.OnPropertyChanged("slabase_AsyncOperations");
            }
        }

        /// <summary>
        /// 1:N slabase_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("slabase_BulkDeleteFailures")]
        public System.Collections.Generic.IEnumerable<BulkDeleteFailure> slabase_BulkDeleteFailures
        {
            get { return this.GetRelatedEntities<BulkDeleteFailure>("slabase_BulkDeleteFailures", null); }
            set
            {
                this.OnPropertyChanging("slabase_BulkDeleteFailures");
                this.SetRelatedEntities<BulkDeleteFailure>("slabase_BulkDeleteFailures", null, value);
                this.OnPropertyChanged("slabase_BulkDeleteFailures");
            }
        }

        /// <summary>
        /// 1:N slabase_ProcessSessions
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("slabase_ProcessSessions")]
        public System.Collections.Generic.IEnumerable<ProcessSession> slabase_ProcessSessions
        {
            get { return this.GetRelatedEntities<ProcessSession>("slabase_ProcessSessions", null); }
            set
            {
                this.OnPropertyChanging("slabase_ProcessSessions");
                this.SetRelatedEntities<ProcessSession>("slabase_ProcessSessions", null, value);
                this.OnPropertyChanged("slabase_ProcessSessions");
            }
        }

        /// <summary>
        /// 1:N slabase_userentityinstancedatas
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("slabase_userentityinstancedatas")]
        public System.Collections.Generic.IEnumerable<UserEntityInstanceData> slabase_userentityinstancedatas
        {
            get { return this.GetRelatedEntities<UserEntityInstanceData>("slabase_userentityinstancedatas", null); }
            set
            {
                this.OnPropertyChanging("slabase_userentityinstancedatas");
                this.SetRelatedEntities<UserEntityInstanceData>("slabase_userentityinstancedatas", null, value);
                this.OnPropertyChanged("slabase_userentityinstancedatas");
            }
        }

        /// <summary>
        /// N:1 business_unit_slabase
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_slabase")]
        public BusinessUnit business_unit_slabase
        {
            get { return this.GetRelatedEntity<BusinessUnit>("business_unit_slabase", null); }
            set
            {
                this.OnPropertyChanging("business_unit_slabase");
                this.SetRelatedEntity<BusinessUnit>("business_unit_slabase", null, value);
                this.OnPropertyChanged("business_unit_slabase");
            }
        }

        /// <summary>
        /// N:1 lk_slabase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_slabase_createdby")]
        public SystemUser lk_slabase_createdby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_slabase_createdby", null); }
        }

        /// <summary>
        /// N:1 lk_slabase_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_slabase_createdonbehalfby")]
        public SystemUser lk_slabase_createdonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_slabase_createdonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_slabase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_slabase_modifiedby")]
        public SystemUser lk_slabase_modifiedby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_slabase_modifiedby", null); }
        }

        /// <summary>
        /// N:1 lk_slabase_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_slabase_modifiedonbehalfby")]
        public SystemUser lk_slabase_modifiedonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_slabase_modifiedonbehalfby", null); }
        }

        /// <summary>
        /// N:1 slabase_businesshoursid
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("businesshoursid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("slabase_businesshoursid")]
        public Calendar slabase_businesshoursid
        {
            get { return this.GetRelatedEntity<Calendar>("slabase_businesshoursid", null); }
            set
            {
                this.OnPropertyChanging("slabase_businesshoursid");
                this.SetRelatedEntity<Calendar>("slabase_businesshoursid", null, value);
                this.OnPropertyChanged("slabase_businesshoursid");
            }
        }

        /// <summary>
        /// N:1 slabase_workflowid
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("workflowid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("slabase_workflowid")]
        public Workflow slabase_workflowid
        {
            get { return this.GetRelatedEntity<Workflow>("slabase_workflowid", null); }
            set
            {
                this.OnPropertyChanging("slabase_workflowid");
                this.SetRelatedEntity<Workflow>("slabase_workflowid", null, value);
                this.OnPropertyChanged("slabase_workflowid");
            }
        }

        /// <summary>
        /// N:1 team_slaBase
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_slaBase")]
        public Team team_slaBase
        {
            get { return this.GetRelatedEntity<Team>("team_slaBase", null); }
            set
            {
                this.OnPropertyChanging("team_slaBase");
                this.SetRelatedEntity<Team>("team_slaBase", null, value);
                this.OnPropertyChanged("team_slaBase");
            }
        }

        /// <summary>
        /// N:1 TransactionCurrency_SLA
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("TransactionCurrency_SLA")]
        public TransactionCurrency TransactionCurrency_SLA
        {
            get { return this.GetRelatedEntity<TransactionCurrency>("TransactionCurrency_SLA", null); }
        }

        /// <summary>
        /// N:1 user_slabase
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_slabase")]
        public SystemUser user_slabase
        {
            get { return this.GetRelatedEntity<SystemUser>("user_slabase", null); }
            set
            {
                this.OnPropertyChanging("user_slabase");
                this.SetRelatedEntity<SystemUser>("user_slabase", null, value);
                this.OnPropertyChanged("user_slabase");
            }
        }
    }
}