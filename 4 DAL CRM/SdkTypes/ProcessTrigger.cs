namespace __4_DAL_CRM
{
    /// <summary>
    /// Trigger that invoke a rule.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("processtrigger")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class ProcessTrigger : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public ProcessTrigger() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "processtrigger";

        public const int EntityTypeCode = 4712;

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
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("componentstate")]
        public Microsoft.Xrm.Sdk.OptionSetValue ComponentState
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("componentstate"); }
        }

        /// <summary>
        /// Name of the control.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("controlname")]
        public string ControlName
        {
            get { return this.GetAttributeValue<string>("controlname"); }
            set
            {
                this.OnPropertyChanging("ControlName");
                this.SetAttributeValue("controlname", value);
                this.OnPropertyChanged("ControlName");
            }
        }

        /// <summary>
        /// Type of the control to which this trigger is bound
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("controltype")]
        public Microsoft.Xrm.Sdk.OptionSetValue ControlType
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("controltype"); }
            set
            {
                this.OnPropertyChanging("ControlType");
                this.SetAttributeValue("controltype", value);
                this.OnPropertyChanged("ControlType");
            }
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
        /// Indicates the event.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("event")]
        public string Event
        {
            get { return this.GetAttributeValue<string>("event"); }
            set
            {
                this.OnPropertyChanging("Event");
                this.SetAttributeValue("event", value);
                this.OnPropertyChanged("Event");
            }
        }

        /// <summary>
        /// Unique identifier of the form associated with the trigger.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("formid")]
        public Microsoft.Xrm.Sdk.EntityReference FormId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("formid"); }
            set
            {
                this.OnPropertyChanging("FormId");
                this.SetAttributeValue("formid", value);
                this.OnPropertyChanged("FormId");
            }
        }

        /// <summary>
        /// Indicates whether this component can be customized.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("iscustomizable")]
        public Microsoft.Xrm.Sdk.BooleanManagedProperty IsCustomizable
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.BooleanManagedProperty>("iscustomizable"); }
            set
            {
                this.OnPropertyChanging("IsCustomizable");
                this.SetAttributeValue("iscustomizable", value);
                this.OnPropertyChanged("IsCustomizable");
            }
        }

        /// <summary>
        /// Indicates whether the solution component is part of a managed solution.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ismanaged")]
        public System.Nullable<bool> IsManaged
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("ismanaged"); }
        }

        /// <summary>
        /// Displays StageID to which the PBL rule belongs to
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("methodid")]
        public System.Nullable<System.Guid> MethodId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("methodid"); }
            set
            {
                this.OnPropertyChanging("MethodId");
                this.SetAttributeValue("methodid", value);
                this.OnPropertyChanged("MethodId");
            }
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
        /// Shows who last updated the record on behalf of another user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby"); }
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
        /// Enter the user or team who is assigned to manage the record. This field is updated every time the record is assigned to a different user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ownerid")]
        public Microsoft.Xrm.Sdk.EntityReference OwnerId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("ownerid"); }
        }

        /// <summary>
        /// Select the business unit that owns the record.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
        public System.Nullable<System.Guid> OwningBusinessUnit
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("owningbusinessunit"); }
        }

        /// <summary>
        /// Unique identifier for the user that owns the record.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
        public System.Nullable<System.Guid> OwningUser
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("owninguser"); }
        }

        /// <summary>
        /// Primary entity for the process which is invoked by the event.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("primaryentitytypecode")]
        public string PrimaryEntityTypeCode
        {
            get { return this.GetAttributeValue<string>("primaryentitytypecode"); }
            set
            {
                this.OnPropertyChanging("PrimaryEntityTypeCode");
                this.SetAttributeValue("primaryentitytypecode", value);
                this.OnPropertyChanged("PrimaryEntityTypeCode");
            }
        }

        /// <summary>
        /// Shows the ID of the process.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("processid")]
        public Microsoft.Xrm.Sdk.EntityReference ProcessId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("processid"); }
            set
            {
                this.OnPropertyChanging("ProcessId");
                this.SetAttributeValue("processid", value);
                this.OnPropertyChanged("ProcessId");
            }
        }

        /// <summary>
        /// Unique identifier of the process trigger record.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("processtriggerid")]
        public System.Nullable<System.Guid> ProcessTriggerId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("processtriggerid"); }
            set
            {
                this.OnPropertyChanging("ProcessTriggerId");
                this.SetAttributeValue("processtriggerid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("ProcessTriggerId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("processtriggerid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.ProcessTriggerId = value; }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("processtriggeridunique")]
        public System.Nullable<System.Guid> ProcessTriggerIdUnique
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("processtriggeridunique"); }
        }

        /// <summary>
        /// Scope level for PBL rules.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("scope")]
        public Microsoft.Xrm.Sdk.OptionSetValue Scope
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("scope"); }
            set
            {
                this.OnPropertyChanging("Scope");
                this.SetAttributeValue("scope", value);
                this.OnPropertyChanged("Scope");
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
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
        public System.Nullable<long> VersionNumber
        {
            get { return this.GetAttributeValue<System.Nullable<long>>("versionnumber"); }
        }

        /// <summary>
        /// N:1 lk_processtriggerbase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_processtriggerbase_createdby")]
        public SystemUser lk_processtriggerbase_createdby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_processtriggerbase_createdby", null); }
        }

        /// <summary>
        /// N:1 lk_processtriggerbase_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_processtriggerbase_createdonbehalfby")]
        public SystemUser lk_processtriggerbase_createdonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_processtriggerbase_createdonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_processtriggerbase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_processtriggerbase_modifiedby")]
        public SystemUser lk_processtriggerbase_modifiedby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_processtriggerbase_modifiedby", null); }
        }

        /// <summary>
        /// N:1 lk_processtriggerbase_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_processtriggerbase_modifiedonbehalfby")]
        public SystemUser lk_processtriggerbase_modifiedonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_processtriggerbase_modifiedonbehalfby", null); }
        }

        /// <summary>
        /// N:1 process_processtrigger
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("processid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("process_processtrigger")]
        public Workflow process_processtrigger
        {
            get { return this.GetRelatedEntity<Workflow>("process_processtrigger", null); }
            set
            {
                this.OnPropertyChanging("process_processtrigger");
                this.SetRelatedEntity<Workflow>("process_processtrigger", null, value);
                this.OnPropertyChanged("process_processtrigger");
            }
        }

        /// <summary>
        /// N:1 processtrigger_systemform
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("formid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("processtrigger_systemform")]
        public SystemForm processtrigger_systemform
        {
            get { return this.GetRelatedEntity<SystemForm>("processtrigger_systemform", null); }
            set
            {
                this.OnPropertyChanging("processtrigger_systemform");
                this.SetRelatedEntity<SystemForm>("processtrigger_systemform", null, value);
                this.OnPropertyChanged("processtrigger_systemform");
            }
        }
    }
}