namespace __4_DAL_CRM
{
    /// <summary>
    /// Log used to track process execution.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("workflowlog")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class WorkflowLog : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public WorkflowLog() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "workflowlog";

        public const int EntityTypeCode = 4706;

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
        /// Name of the activity which the process step is currently processing.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("activityname")]
        public string ActivityName
        {
            get { return this.GetAttributeValue<string>("activityname"); }
            set
            {
                this.OnPropertyChanging("ActivityName");
                this.SetAttributeValue("activityname", value);
                this.OnPropertyChanged("ActivityName");
            }
        }

        /// <summary>
        /// Unique identifier of the parent record.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("asyncoperationid")]
        public Microsoft.Xrm.Sdk.EntityReference AsyncOperationId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("asyncoperationid"); }
            set
            {
                this.OnPropertyChanging("AsyncOperationId");
                this.SetAttributeValue("asyncoperationid", value);
                this.OnPropertyChanged("AsyncOperationId");
            }
        }

        /// <summary>
        /// Unique identifier of the system job.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("childworkflowinstanceid")]
        public Microsoft.Xrm.Sdk.EntityReference ChildWorkflowInstanceId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("childworkflowinstanceid"); }
            set
            {
                this.OnPropertyChanging("ChildWorkflowInstanceId");
                this.SetAttributeValue("childworkflowinstanceid", value);
                this.OnPropertyChanged("ChildWorkflowInstanceId");
            }
        }

        /// <summary>
        /// Date and time when the operation was completed.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("completedon")]
        public System.Nullable<System.DateTime> CompletedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("completedon"); }
            set
            {
                this.OnPropertyChanging("CompletedOn");
                this.SetAttributeValue("completedon", value);
                this.OnPropertyChanged("CompletedOn");
            }
        }

        /// <summary>
        /// Unique identifier of the user who created the process log entry.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby"); }
        }

        /// <summary>
        /// Date and time when the process log entry was created.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
        public System.Nullable<System.DateTime> CreatedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who created the process log.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        /// Description of the process step.
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
        /// Error code related to process.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("errorcode")]
        public System.Nullable<int> ErrorCode
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("errorcode"); }
            set
            {
                this.OnPropertyChanging("ErrorCode");
                this.SetAttributeValue("errorcode", value);
                this.OnPropertyChanged("ErrorCode");
            }
        }

        /// <summary>
        /// String specifying the result of an interaction activity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("interactionactivityresult")]
        public string InteractionActivityResult
        {
            get { return this.GetAttributeValue<string>("interactionactivityresult"); }
            set
            {
                this.OnPropertyChanging("InteractionActivityResult");
                this.SetAttributeValue("interactionactivityresult", value);
                this.OnPropertyChanged("InteractionActivityResult");
            }
        }

        /// <summary>
        /// Message related to process.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("message")]
        public string Message
        {
            get { return this.GetAttributeValue<string>("message"); }
            set
            {
                this.OnPropertyChanging("Message");
                this.SetAttributeValue("message", value);
                this.OnPropertyChanged("Message");
            }
        }

        /// <summary>
        /// Unique identifier of the user who last modified the process log entry.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby"); }
        }

        /// <summary>
        /// Date and time when the process log entry was last modified.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
        public System.Nullable<System.DateTime> ModifiedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who last modified the process log.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        /// Unique identifier of the user or team who owns the process log.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ownerid")]
        public Microsoft.Xrm.Sdk.EntityReference OwnerId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("ownerid"); }
        }

        /// <summary>
        /// Unique identifier of the business unit that owns the process.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
        public Microsoft.Xrm.Sdk.EntityReference OwningBusinessUnit
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningbusinessunit"); }
        }

        /// <summary>
        /// Unique identifier of the team who owns the process log.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
        public Microsoft.Xrm.Sdk.EntityReference OwningTeam
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningteam"); }
        }

        /// <summary>
        /// Unique identifier of the user who owns the process.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
        public Microsoft.Xrm.Sdk.EntityReference OwningUser
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owninguser"); }
        }

        /// <summary>
        /// Unique identifier of the associated record.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        public Microsoft.Xrm.Sdk.EntityReference RegardingObjectId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("regardingobjectid"); }
            set
            {
                this.OnPropertyChanging("RegardingObjectId");
                this.SetAttributeValue("regardingobjectid", value);
                this.OnPropertyChanged("RegardingObjectId");
            }
        }

        /// <summary>
        /// Name of the process stage.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("stagename")]
        public string StageName
        {
            get { return this.GetAttributeValue<string>("stagename"); }
            set
            {
                this.OnPropertyChanging("StageName");
                this.SetAttributeValue("stagename", value);
                this.OnPropertyChanged("StageName");
            }
        }

        /// <summary>
        /// Status of the process step for which process log record has been created: In Progress, Successfully Completed, or Failed.
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
        /// Name of the process step.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("stepname")]
        public string StepName
        {
            get { return this.GetAttributeValue<string>("stepname"); }
            set
            {
                this.OnPropertyChanging("StepName");
                this.SetAttributeValue("stepname", value);
                this.OnPropertyChanged("StepName");
            }
        }

        /// <summary>
        /// Unique identifier of the process log entry.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("workflowlogid")]
        public System.Nullable<System.Guid> WorkflowLogId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("workflowlogid"); }
            set
            {
                this.OnPropertyChanging("WorkflowLogId");
                this.SetAttributeValue("workflowlogid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("WorkflowLogId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("workflowlogid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.WorkflowLogId = value; }
        }

        /// <summary>
        /// 1:N userentityinstancedata_workflowlog
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_workflowlog")]
        public System.Collections.Generic.IEnumerable<UserEntityInstanceData> userentityinstancedata_workflowlog
        {
            get { return this.GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_workflowlog", null); }
            set
            {
                this.OnPropertyChanging("userentityinstancedata_workflowlog");
                this.SetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_workflowlog", null, value);
                this.OnPropertyChanged("userentityinstancedata_workflowlog");
            }
        }

        /// <summary>
        /// N:1 business_unit_workflowlogs
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_workflowlogs")]
        public BusinessUnit business_unit_workflowlogs
        {
            get { return this.GetRelatedEntity<BusinessUnit>("business_unit_workflowlogs", null); }
        }

        /// <summary>
        /// N:1 lk_workflowlog_asyncoperation_childworkflow
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("childworkflowinstanceid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_workflowlog_asyncoperation_childworkflow")]
        public AsyncOperation lk_workflowlog_asyncoperation_childworkflow
        {
            get { return this.GetRelatedEntity<AsyncOperation>("lk_workflowlog_asyncoperation_childworkflow", null); }
            set
            {
                this.OnPropertyChanging("lk_workflowlog_asyncoperation_childworkflow");
                this.SetRelatedEntity<AsyncOperation>("lk_workflowlog_asyncoperation_childworkflow", null, value);
                this.OnPropertyChanged("lk_workflowlog_asyncoperation_childworkflow");
            }
        }

        /// <summary>
        /// N:1 lk_workflowlog_asyncoperations
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("asyncoperationid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_workflowlog_asyncoperations")]
        public AsyncOperation lk_workflowlog_asyncoperations
        {
            get { return this.GetRelatedEntity<AsyncOperation>("lk_workflowlog_asyncoperations", null); }
            set
            {
                this.OnPropertyChanging("lk_workflowlog_asyncoperations");
                this.SetRelatedEntity<AsyncOperation>("lk_workflowlog_asyncoperations", null, value);
                this.OnPropertyChanged("lk_workflowlog_asyncoperations");
            }
        }

        /// <summary>
        /// N:1 lk_workflowlog_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_workflowlog_createdby")]
        public SystemUser lk_workflowlog_createdby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_workflowlog_createdby", null); }
        }

        /// <summary>
        /// N:1 lk_workflowlog_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_workflowlog_createdonbehalfby")]
        public SystemUser lk_workflowlog_createdonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_workflowlog_createdonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_workflowlog_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_workflowlog_modifiedby")]
        public SystemUser lk_workflowlog_modifiedby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_workflowlog_modifiedby", null); }
        }

        /// <summary>
        /// N:1 lk_workflowlog_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_workflowlog_modifiedonbehalfby")]
        public SystemUser lk_workflowlog_modifiedonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_workflowlog_modifiedonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_workflowlog_processsession
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("asyncoperationid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_workflowlog_processsession")]
        public ProcessSession lk_workflowlog_processsession
        {
            get { return this.GetRelatedEntity<ProcessSession>("lk_workflowlog_processsession", null); }
            set
            {
                this.OnPropertyChanging("lk_workflowlog_processsession");
                this.SetRelatedEntity<ProcessSession>("lk_workflowlog_processsession", null, value);
                this.OnPropertyChanged("lk_workflowlog_processsession");
            }
        }

        /// <summary>
        /// N:1 lk_workflowlog_processsession_childworkflow
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("childworkflowinstanceid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_workflowlog_processsession_childworkflow")]
        public ProcessSession lk_workflowlog_processsession_childworkflow
        {
            get { return this.GetRelatedEntity<ProcessSession>("lk_workflowlog_processsession_childworkflow", null); }
            set
            {
                this.OnPropertyChanging("lk_workflowlog_processsession_childworkflow");
                this.SetRelatedEntity<ProcessSession>("lk_workflowlog_processsession_childworkflow", null, value);
                this.OnPropertyChanged("lk_workflowlog_processsession_childworkflow");
            }
        }

        /// <summary>
        /// N:1 team_workflowlog
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_workflowlog")]
        public Team team_workflowlog
        {
            get { return this.GetRelatedEntity<Team>("team_workflowlog", null); }
        }
    }
}