using _4_DAL_CRM;

namespace __4_DAL_CRM
{
    /// <summary>
    /// Process whose execution can proceed independently or in the background.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("asyncoperation")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class AsyncOperation : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public AsyncOperation() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "asyncoperation";

        public const int EntityTypeCode = 4700;

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
        /// Unique identifier of the system job.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("asyncoperationid")]
        public System.Nullable<System.Guid> AsyncOperationId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("asyncoperationid"); }
            set
            {
                this.OnPropertyChanging("AsyncOperationId");
                this.SetAttributeValue("asyncoperationid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("AsyncOperationId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("asyncoperationid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.AsyncOperationId = value; }
        }

        /// <summary>
        /// Date and time when the system job was completed.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("completedon")]
        public System.Nullable<System.DateTime> CompletedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("completedon"); }
        }

        /// <summary>
        /// Unique identifier used to correlate between multiple SDK requests and system jobs.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("correlationid")]
        public System.Nullable<System.Guid> CorrelationId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("correlationid"); }
            set
            {
                this.OnPropertyChanging("CorrelationId");
                this.SetAttributeValue("correlationid", value);
                this.OnPropertyChanged("CorrelationId");
            }
        }

        /// <summary>
        /// Last time the correlation depth was updated.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("correlationupdatedtime")]
        public System.Nullable<System.DateTime> CorrelationUpdatedTime
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("correlationupdatedtime"); }
            set
            {
                this.OnPropertyChanging("CorrelationUpdatedTime");
                this.SetAttributeValue("correlationupdatedtime", value);
                this.OnPropertyChanged("CorrelationUpdatedTime");
            }
        }

        /// <summary>
        /// Unique identifier of the user who created the system job.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby"); }
        }

        /// <summary>
        /// Date and time when the system job was created.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
        public System.Nullable<System.DateTime> CreatedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who created the asyncoperation.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        /// Unstructured data associated with the system job.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("data")]
        public string Data
        {
            get { return this.GetAttributeValue<string>("data"); }
            set
            {
                this.OnPropertyChanging("Data");
                this.SetAttributeValue("data", value);
                this.OnPropertyChanged("Data");
            }
        }

        /// <summary>
        /// Execution of all operations with the same dependency token is serialized.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("dependencytoken")]
        public string DependencyToken
        {
            get { return this.GetAttributeValue<string>("dependencytoken"); }
            set
            {
                this.OnPropertyChanging("DependencyToken");
                this.SetAttributeValue("dependencytoken", value);
                this.OnPropertyChanged("DependencyToken");
            }
        }

        /// <summary>
        /// Number of SDK calls made since the first call.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("depth")]
        public System.Nullable<int> Depth
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("depth"); }
            set
            {
                this.OnPropertyChanging("Depth");
                this.SetAttributeValue("depth", value);
                this.OnPropertyChanged("Depth");
            }
        }

        /// <summary>
        /// Error code returned from a canceled system job.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("errorcode")]
        public System.Nullable<int> ErrorCode
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("errorcode"); }
        }

        /// <summary>
        /// Time that the system job has taken to execute.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("executiontimespan")]
        public System.Nullable<double> ExecutionTimeSpan
        {
            get { return this.GetAttributeValue<System.Nullable<double>>("executiontimespan"); }
        }

        /// <summary>
        /// Message provided by the system job.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("friendlymessage")]
        public string FriendlyMessage
        {
            get { return this.GetAttributeValue<string>("friendlymessage"); }
            set
            {
                this.OnPropertyChanging("FriendlyMessage");
                this.SetAttributeValue("friendlymessage", value);
                this.OnPropertyChanged("FriendlyMessage");
            }
        }

        /// <summary>
        /// Unique identifier of the host that owns this system job.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("hostid")]
        public string HostId
        {
            get { return this.GetAttributeValue<string>("hostid"); }
            set
            {
                this.OnPropertyChanging("HostId");
                this.SetAttributeValue("hostid", value);
                this.OnPropertyChanged("HostId");
            }
        }

        /// <summary>
        /// Indicates that the system job is waiting for an event.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("iswaitingforevent")]
        public System.Nullable<bool> IsWaitingForEvent
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("iswaitingforevent"); }
        }

        /// <summary>
        /// Message related to the system job.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("message")]
        public string Message
        {
            get { return this.GetAttributeValue<string>("message"); }
        }

        /// <summary>
        /// Name of the message that started this system job.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("messagename")]
        public string MessageName
        {
            get { return this.GetAttributeValue<string>("messagename"); }
            set
            {
                this.OnPropertyChanging("MessageName");
                this.SetAttributeValue("messagename", value);
                this.OnPropertyChanged("MessageName");
            }
        }

        /// <summary>
        /// Unique identifier of the user who last modified the system job.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby"); }
        }

        /// <summary>
        /// Date and time when the system job was last modified.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
        public System.Nullable<System.DateTime> ModifiedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who last modified the asyncoperation.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        /// Name of the system job.
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
        /// Type of the system job.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("operationtype")]
        public Microsoft.Xrm.Sdk.OptionSetValue OperationType
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("operationtype"); }
            set
            {
                this.OnPropertyChanging("OperationType");
                this.SetAttributeValue("operationtype", value);
                this.OnPropertyChanged("OperationType");
            }
        }

        /// <summary>
        /// Unique identifier of the user or team who owns the system job.
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
        /// Unique identifier of the business unit that owns the system job.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
        public Microsoft.Xrm.Sdk.EntityReference OwningBusinessUnit
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningbusinessunit"); }
        }

        /// <summary>
        /// Unique identifier of the owning extension with which the system job is associated.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningextensionid")]
        public Microsoft.Xrm.Sdk.EntityReference OwningExtensionId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningextensionid"); }
            set
            {
                this.OnPropertyChanging("OwningExtensionId");
                this.SetAttributeValue("owningextensionid", value);
                this.OnPropertyChanged("OwningExtensionId");
            }
        }

        /// <summary>
        /// Unique identifier of the team who owns the record.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
        public Microsoft.Xrm.Sdk.EntityReference OwningTeam
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningteam"); }
        }

        /// <summary>
        /// Unique identifier of the user who owns the record.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
        public Microsoft.Xrm.Sdk.EntityReference OwningUser
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owninguser"); }
        }

        /// <summary>
        /// Indicates whether the system job should run only after the specified date and time.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("postponeuntil")]
        public System.Nullable<System.DateTime> PostponeUntil
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("postponeuntil"); }
            set
            {
                this.OnPropertyChanging("PostponeUntil");
                this.SetAttributeValue("postponeuntil", value);
                this.OnPropertyChanged("PostponeUntil");
            }
        }

        /// <summary>
        /// Type of entity with which the system job is primarily associated.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("primaryentitytype")]
        public string PrimaryEntityType
        {
            get { return this.GetAttributeValue<string>("primaryentitytype"); }
            set
            {
                this.OnPropertyChanging("PrimaryEntityType");
                this.SetAttributeValue("primaryentitytype", value);
                this.OnPropertyChanged("PrimaryEntityType");
            }
        }

        /// <summary>
        /// Pattern of the system job's recurrence.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("recurrencepattern")]
        public string RecurrencePattern
        {
            get { return this.GetAttributeValue<string>("recurrencepattern"); }
            set
            {
                this.OnPropertyChanging("RecurrencePattern");
                this.SetAttributeValue("recurrencepattern", value);
                this.OnPropertyChanged("RecurrencePattern");
            }
        }

        /// <summary>
        /// Starting time in UTC for the recurrence pattern.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("recurrencestarttime")]
        public System.Nullable<System.DateTime> RecurrenceStartTime
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("recurrencestarttime"); }
            set
            {
                this.OnPropertyChanging("RecurrenceStartTime");
                this.SetAttributeValue("recurrencestarttime", value);
                this.OnPropertyChanged("RecurrenceStartTime");
            }
        }

        /// <summary>
        /// Unique identifier of the object with which the system job is associated.
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
        /// Unique identifier of the request that generated the system job.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("requestid")]
        public System.Nullable<System.Guid> RequestId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("requestid"); }
            set
            {
                this.OnPropertyChanging("RequestId");
                this.SetAttributeValue("requestid", value);
                this.OnPropertyChanged("RequestId");
            }
        }

        /// <summary>
        /// Number of times to retry the system job.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("retrycount")]
        public System.Nullable<int> RetryCount
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("retrycount"); }
        }

        /// <summary>
        /// Order in which operations were submitted.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sequence")]
        public System.Nullable<long> Sequence
        {
            get { return this.GetAttributeValue<System.Nullable<long>>("sequence"); }
        }

        /// <summary>
        /// Date and time when the system job was started.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("startedon")]
        public System.Nullable<System.DateTime> StartedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("startedon"); }
        }

        /// <summary>
        /// Status of the system job.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
        public System.Nullable<AsyncOperationState> StateCode
        {
            get
            {
                Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
                if ((optionSet != null))
                {
                    return ((AsyncOperationState) (System.Enum.ToObject(typeof(AsyncOperationState), optionSet.Value)));
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
        /// Reason for the status of the system job.
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
        /// The Subtype of the Async Job
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("subtype")]
        public System.Nullable<int> Subtype
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("subtype"); }
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
        /// Unique identifier of the workflow activation related to the system job.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("workflowactivationid")]
        public Microsoft.Xrm.Sdk.EntityReference WorkflowActivationId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("workflowactivationid"); }
            set
            {
                this.OnPropertyChanging("WorkflowActivationId");
                this.SetAttributeValue("workflowactivationid", value);
                this.OnPropertyChanged("WorkflowActivationId");
            }
        }

        /// <summary>
        /// Name of a workflow stage.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("workflowstagename")]
        public string WorkflowStageName
        {
            get { return this.GetAttributeValue<string>("workflowstagename"); }
        }

        /// <summary>
        /// 1:N AsyncOperation_BulkDeleteOperation
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("AsyncOperation_BulkDeleteOperation")]
        public System.Collections.Generic.IEnumerable<BulkDeleteOperation> AsyncOperation_BulkDeleteOperation
        {
            get { return this.GetRelatedEntities<BulkDeleteOperation>("AsyncOperation_BulkDeleteOperation", null); }
            set
            {
                this.OnPropertyChanging("AsyncOperation_BulkDeleteOperation");
                this.SetRelatedEntities<BulkDeleteOperation>("AsyncOperation_BulkDeleteOperation", null, value);
                this.OnPropertyChanged("AsyncOperation_BulkDeleteOperation");
            }
        }

        /// <summary>
        /// 1:N AsyncOperation_DuplicateBaseRecord
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("AsyncOperation_DuplicateBaseRecord")]
        public System.Collections.Generic.IEnumerable<DuplicateRecord> AsyncOperation_DuplicateBaseRecord
        {
            get { return this.GetRelatedEntities<DuplicateRecord>("AsyncOperation_DuplicateBaseRecord", null); }
            set
            {
                this.OnPropertyChanging("AsyncOperation_DuplicateBaseRecord");
                this.SetRelatedEntities<DuplicateRecord>("AsyncOperation_DuplicateBaseRecord", null, value);
                this.OnPropertyChanged("AsyncOperation_DuplicateBaseRecord");
            }
        }

        /// <summary>
        /// 1:N AsyncOperation_Emails
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("AsyncOperation_Emails")]
        public System.Collections.Generic.IEnumerable<Email> AsyncOperation_Emails
        {
            get { return this.GetRelatedEntities<Email>("AsyncOperation_Emails", null); }
            set
            {
                this.OnPropertyChanging("AsyncOperation_Emails");
                this.SetRelatedEntities<Email>("AsyncOperation_Emails", null, value);
                this.OnPropertyChanged("AsyncOperation_Emails");
            }
        }

        /// <summary>
        /// 1:N AsyncOperation_SocialActivities
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("AsyncOperation_SocialActivities")]
        public System.Collections.Generic.IEnumerable<SocialActivity> AsyncOperation_SocialActivities
        {
            get { return this.GetRelatedEntities<SocialActivity>("AsyncOperation_SocialActivities", null); }
            set
            {
                this.OnPropertyChanging("AsyncOperation_SocialActivities");
                this.SetRelatedEntities<SocialActivity>("AsyncOperation_SocialActivities", null, value);
                this.OnPropertyChanged("AsyncOperation_SocialActivities");
            }
        }

        /// <summary>
        /// 1:N lk_workflowlog_asyncoperation_childworkflow
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_workflowlog_asyncoperation_childworkflow")]
        public System.Collections.Generic.IEnumerable<WorkflowLog> lk_workflowlog_asyncoperation_childworkflow
        {
            get { return this.GetRelatedEntities<WorkflowLog>("lk_workflowlog_asyncoperation_childworkflow", null); }
            set
            {
                this.OnPropertyChanging("lk_workflowlog_asyncoperation_childworkflow");
                this.SetRelatedEntities<WorkflowLog>("lk_workflowlog_asyncoperation_childworkflow", null, value);
                this.OnPropertyChanged("lk_workflowlog_asyncoperation_childworkflow");
            }
        }

        /// <summary>
        /// 1:N lk_workflowlog_asyncoperations
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_workflowlog_asyncoperations")]
        public System.Collections.Generic.IEnumerable<WorkflowLog> lk_workflowlog_asyncoperations
        {
            get { return this.GetRelatedEntities<WorkflowLog>("lk_workflowlog_asyncoperations", null); }
            set
            {
                this.OnPropertyChanging("lk_workflowlog_asyncoperations");
                this.SetRelatedEntities<WorkflowLog>("lk_workflowlog_asyncoperations", null, value);
                this.OnPropertyChanged("lk_workflowlog_asyncoperations");
            }
        }

        /// <summary>
        /// 1:N userentityinstancedata_asyncoperation
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_asyncoperation")]
        public System.Collections.Generic.IEnumerable<UserEntityInstanceData> userentityinstancedata_asyncoperation
        {
            get { return this.GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_asyncoperation", null); }
            set
            {
                this.OnPropertyChanging("userentityinstancedata_asyncoperation");
                this.SetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_asyncoperation", null, value);
                this.OnPropertyChanged("userentityinstancedata_asyncoperation");
            }
        }

        /// <summary>
        /// N:1 Account_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Account_AsyncOperations")]
        public Account Account_AsyncOperations
        {
            get { return this.GetRelatedEntity<Account>("Account_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("Account_AsyncOperations");
                this.SetRelatedEntity<Account>("Account_AsyncOperations", null, value);
                this.OnPropertyChanged("Account_AsyncOperations");
            }
        }

        /// <summary>
        /// N:1 ActivityMimeAttachment_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ActivityMimeAttachment_AsyncOperations")]
        public ActivityMimeAttachment ActivityMimeAttachment_AsyncOperations
        {
            get { return this.GetRelatedEntity<ActivityMimeAttachment>("ActivityMimeAttachment_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("ActivityMimeAttachment_AsyncOperations");
                this.SetRelatedEntity<ActivityMimeAttachment>("ActivityMimeAttachment_AsyncOperations", null, value);
                this.OnPropertyChanged("ActivityMimeAttachment_AsyncOperations");
            }
        }

        /// <summary>
        /// N:1 ActivityPointer_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ActivityPointer_AsyncOperations")]
        public ActivityPointer ActivityPointer_AsyncOperations
        {
            get { return this.GetRelatedEntity<ActivityPointer>("ActivityPointer_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("ActivityPointer_AsyncOperations");
                this.SetRelatedEntity<ActivityPointer>("ActivityPointer_AsyncOperations", null, value);
                this.OnPropertyChanged("ActivityPointer_AsyncOperations");
            }
        }

        /// <summary>
        /// N:1 Annotation_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Annotation_AsyncOperations")]
        public Annotation Annotation_AsyncOperations
        {
            get { return this.GetRelatedEntity<Annotation>("Annotation_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("Annotation_AsyncOperations");
                this.SetRelatedEntity<Annotation>("Annotation_AsyncOperations", null, value);
                this.OnPropertyChanged("Annotation_AsyncOperations");
            }
        }

        /// <summary>
        /// N:1 AnnualFiscalCalendar_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("AnnualFiscalCalendar_AsyncOperations")]
        public AnnualFiscalCalendar AnnualFiscalCalendar_AsyncOperations
        {
            get { return this.GetRelatedEntity<AnnualFiscalCalendar>("AnnualFiscalCalendar_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("AnnualFiscalCalendar_AsyncOperations");
                this.SetRelatedEntity<AnnualFiscalCalendar>("AnnualFiscalCalendar_AsyncOperations", null, value);
                this.OnPropertyChanged("AnnualFiscalCalendar_AsyncOperations");
            }
        }

        /// <summary>
        /// N:1 Appointment_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Appointment_AsyncOperations")]
        public Appointment Appointment_AsyncOperations
        {
            get { return this.GetRelatedEntity<Appointment>("Appointment_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("Appointment_AsyncOperations");
                this.SetRelatedEntity<Appointment>("Appointment_AsyncOperations", null, value);
                this.OnPropertyChanged("Appointment_AsyncOperations");
            }
        }

        /// <summary>
        /// N:1 AttributeMap_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("AttributeMap_AsyncOperations")]
        public AttributeMap AttributeMap_AsyncOperations
        {
            get { return this.GetRelatedEntity<AttributeMap>("AttributeMap_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("AttributeMap_AsyncOperations");
                this.SetRelatedEntity<AttributeMap>("AttributeMap_AsyncOperations", null, value);
                this.OnPropertyChanged("AttributeMap_AsyncOperations");
            }
        }

        /// <summary>
        /// N:1 BulkOperation_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("BulkOperation_AsyncOperations")]
        public BulkOperation BulkOperation_AsyncOperations
        {
            get { return this.GetRelatedEntity<BulkOperation>("BulkOperation_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("BulkOperation_AsyncOperations");
                this.SetRelatedEntity<BulkOperation>("BulkOperation_AsyncOperations", null, value);
                this.OnPropertyChanged("BulkOperation_AsyncOperations");
            }
        }

        /// <summary>
        /// N:1 BulkOperationLog_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("BulkOperationLog_AsyncOperations")]
        public BulkOperationLog BulkOperationLog_AsyncOperations
        {
            get { return this.GetRelatedEntity<BulkOperationLog>("BulkOperationLog_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("BulkOperationLog_AsyncOperations");
                this.SetRelatedEntity<BulkOperationLog>("BulkOperationLog_AsyncOperations", null, value);
                this.OnPropertyChanged("BulkOperationLog_AsyncOperations");
            }
        }

        /// <summary>
        /// N:1 business_unit_asyncoperation
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_asyncoperation")]
        public BusinessUnit business_unit_asyncoperation
        {
            get { return this.GetRelatedEntity<BusinessUnit>("business_unit_asyncoperation", null); }
        }

        /// <summary>
        /// N:1 BusinessUnit_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("BusinessUnit_AsyncOperations")]
        public BusinessUnit BusinessUnit_AsyncOperations
        {
            get { return this.GetRelatedEntity<BusinessUnit>("BusinessUnit_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("BusinessUnit_AsyncOperations");
                this.SetRelatedEntity<BusinessUnit>("BusinessUnit_AsyncOperations", null, value);
                this.OnPropertyChanged("BusinessUnit_AsyncOperations");
            }
        }

        /// <summary>
        /// N:1 BusinessUnitNewsArticle_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("BusinessUnitNewsArticle_AsyncOperations")]
        public BusinessUnitNewsArticle BusinessUnitNewsArticle_AsyncOperations
        {
            get { return this.GetRelatedEntity<BusinessUnitNewsArticle>("BusinessUnitNewsArticle_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("BusinessUnitNewsArticle_AsyncOperations");
                this.SetRelatedEntity<BusinessUnitNewsArticle>("BusinessUnitNewsArticle_AsyncOperations", null, value);
                this.OnPropertyChanged("BusinessUnitNewsArticle_AsyncOperations");
            }
        }

        /// <summary>
        /// N:1 Calendar_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Calendar_AsyncOperations")]
        public Calendar Calendar_AsyncOperations
        {
            get { return this.GetRelatedEntity<Calendar>("Calendar_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("Calendar_AsyncOperations");
                this.SetRelatedEntity<Calendar>("Calendar_AsyncOperations", null, value);
                this.OnPropertyChanged("Calendar_AsyncOperations");
            }
        }

        /// <summary>
        /// N:1 Campaign_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Campaign_AsyncOperations")]
        public Campaign Campaign_AsyncOperations
        {
            get { return this.GetRelatedEntity<Campaign>("Campaign_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("Campaign_AsyncOperations");
                this.SetRelatedEntity<Campaign>("Campaign_AsyncOperations", null, value);
                this.OnPropertyChanged("Campaign_AsyncOperations");
            }
        }

        /// <summary>
        /// N:1 CampaignActivity_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("CampaignActivity_AsyncOperations")]
        public CampaignActivity CampaignActivity_AsyncOperations
        {
            get { return this.GetRelatedEntity<CampaignActivity>("CampaignActivity_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("CampaignActivity_AsyncOperations");
                this.SetRelatedEntity<CampaignActivity>("CampaignActivity_AsyncOperations", null, value);
                this.OnPropertyChanged("CampaignActivity_AsyncOperations");
            }
        }

        /// <summary>
        /// N:1 CampaignResponse_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("CampaignResponse_AsyncOperations")]
        public CampaignResponse CampaignResponse_AsyncOperations
        {
            get { return this.GetRelatedEntity<CampaignResponse>("CampaignResponse_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("CampaignResponse_AsyncOperations");
                this.SetRelatedEntity<CampaignResponse>("CampaignResponse_AsyncOperations", null, value);
                this.OnPropertyChanged("CampaignResponse_AsyncOperations");
            }
        }

        /// <summary>
        /// N:1 Competitor_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Competitor_AsyncOperations")]
        public Competitor Competitor_AsyncOperations
        {
            get { return this.GetRelatedEntity<Competitor>("Competitor_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("Competitor_AsyncOperations");
                this.SetRelatedEntity<Competitor>("Competitor_AsyncOperations", null, value);
                this.OnPropertyChanged("Competitor_AsyncOperations");
            }
        }

        /// <summary>
        /// N:1 Connection_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Connection_AsyncOperations")]
        public Connection Connection_AsyncOperations
        {
            get { return this.GetRelatedEntity<Connection>("Connection_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("Connection_AsyncOperations");
                this.SetRelatedEntity<Connection>("Connection_AsyncOperations", null, value);
                this.OnPropertyChanged("Connection_AsyncOperations");
            }
        }

        /// <summary>
        /// N:1 Connection_Role_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Connection_Role_AsyncOperations")]
        public ConnectionRole Connection_Role_AsyncOperations
        {
            get { return this.GetRelatedEntity<ConnectionRole>("Connection_Role_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("Connection_Role_AsyncOperations");
                this.SetRelatedEntity<ConnectionRole>("Connection_Role_AsyncOperations", null, value);
                this.OnPropertyChanged("Connection_Role_AsyncOperations");
            }
        }

        /// <summary>
        /// N:1 ConstraintBasedGroup_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ConstraintBasedGroup_AsyncOperations")]
        public ConstraintBasedGroup ConstraintBasedGroup_AsyncOperations
        {
            get { return this.GetRelatedEntity<ConstraintBasedGroup>("ConstraintBasedGroup_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("ConstraintBasedGroup_AsyncOperations");
                this.SetRelatedEntity<ConstraintBasedGroup>("ConstraintBasedGroup_AsyncOperations", null, value);
                this.OnPropertyChanged("ConstraintBasedGroup_AsyncOperations");
            }
        }

        /// <summary>
        /// N:1 Contact_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Contact_AsyncOperations")]
        public Contact Contact_AsyncOperations
        {
            get { return this.GetRelatedEntity<Contact>("Contact_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("Contact_AsyncOperations");
                this.SetRelatedEntity<Contact>("Contact_AsyncOperations", null, value);
                this.OnPropertyChanged("Contact_AsyncOperations");
            }
        }

        /// <summary>
        /// N:1 Contract_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Contract_AsyncOperations")]
        public Contract Contract_AsyncOperations
        {
            get { return this.GetRelatedEntity<Contract>("Contract_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("Contract_AsyncOperations");
                this.SetRelatedEntity<Contract>("Contract_AsyncOperations", null, value);
                this.OnPropertyChanged("Contract_AsyncOperations");
            }
        }

        /// <summary>
        /// N:1 ContractDetail_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ContractDetail_AsyncOperations")]
        public ContractDetail ContractDetail_AsyncOperations
        {
            get { return this.GetRelatedEntity<ContractDetail>("ContractDetail_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("ContractDetail_AsyncOperations");
                this.SetRelatedEntity<ContractDetail>("ContractDetail_AsyncOperations", null, value);
                this.OnPropertyChanged("ContractDetail_AsyncOperations");
            }
        }

        /// <summary>
        /// N:1 ContractTemplate_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ContractTemplate_AsyncOperations")]
        public ContractTemplate ContractTemplate_AsyncOperations
        {
            get { return this.GetRelatedEntity<ContractTemplate>("ContractTemplate_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("ContractTemplate_AsyncOperations");
                this.SetRelatedEntity<ContractTemplate>("ContractTemplate_AsyncOperations", null, value);
                this.OnPropertyChanged("ContractTemplate_AsyncOperations");
            }
        }

        /// <summary>
        /// N:1 Convertrule_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Convertrule_AsyncOperations")]
        public ConvertRule Convertrule_AsyncOperations
        {
            get { return this.GetRelatedEntity<ConvertRule>("Convertrule_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("Convertrule_AsyncOperations");
                this.SetRelatedEntity<ConvertRule>("Convertrule_AsyncOperations", null, value);
                this.OnPropertyChanged("Convertrule_AsyncOperations");
            }
        }

        /// <summary>
        /// N:1 CustomerAddress_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("CustomerAddress_AsyncOperations")]
        public CustomerAddress CustomerAddress_AsyncOperations
        {
            get { return this.GetRelatedEntity<CustomerAddress>("CustomerAddress_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("CustomerAddress_AsyncOperations");
                this.SetRelatedEntity<CustomerAddress>("CustomerAddress_AsyncOperations", null, value);
                this.OnPropertyChanged("CustomerAddress_AsyncOperations");
            }
        }

        /// <summary>
        /// N:1 CustomerOpportunityRole_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("CustomerOpportunityRole_AsyncOperations")]
        public CustomerOpportunityRole CustomerOpportunityRole_AsyncOperations
        {
            get { return this.GetRelatedEntity<CustomerOpportunityRole>("CustomerOpportunityRole_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("CustomerOpportunityRole_AsyncOperations");
                this.SetRelatedEntity<CustomerOpportunityRole>("CustomerOpportunityRole_AsyncOperations", null, value);
                this.OnPropertyChanged("CustomerOpportunityRole_AsyncOperations");
            }
        }

        /// <summary>
        /// N:1 CustomerRelationship_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("CustomerRelationship_AsyncOperations")]
        public CustomerRelationship CustomerRelationship_AsyncOperations
        {
            get { return this.GetRelatedEntity<CustomerRelationship>("CustomerRelationship_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("CustomerRelationship_AsyncOperations");
                this.SetRelatedEntity<CustomerRelationship>("CustomerRelationship_AsyncOperations", null, value);
                this.OnPropertyChanged("CustomerRelationship_AsyncOperations");
            }
        }

        /// <summary>
        /// N:1 Discount_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Discount_AsyncOperations")]
        public Discount Discount_AsyncOperations
        {
            get { return this.GetRelatedEntity<Discount>("Discount_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("Discount_AsyncOperations");
                this.SetRelatedEntity<Discount>("Discount_AsyncOperations", null, value);
                this.OnPropertyChanged("Discount_AsyncOperations");
            }
        }

        /// <summary>
        /// N:1 DiscountType_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("DiscountType_AsyncOperations")]
        public DiscountType DiscountType_AsyncOperations
        {
            get { return this.GetRelatedEntity<DiscountType>("DiscountType_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("DiscountType_AsyncOperations");
                this.SetRelatedEntity<DiscountType>("DiscountType_AsyncOperations", null, value);
                this.OnPropertyChanged("DiscountType_AsyncOperations");
            }
        }

        /// <summary>
        /// N:1 DisplayString_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("DisplayString_AsyncOperations")]
        public DisplayString DisplayString_AsyncOperations
        {
            get { return this.GetRelatedEntity<DisplayString>("DisplayString_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("DisplayString_AsyncOperations");
                this.SetRelatedEntity<DisplayString>("DisplayString_AsyncOperations", null, value);
                this.OnPropertyChanged("DisplayString_AsyncOperations");
            }
        }

        /// <summary>
        /// N:1 Email_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Email_AsyncOperations")]
        public Email Email_AsyncOperations
        {
            get { return this.GetRelatedEntity<Email>("Email_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("Email_AsyncOperations");
                this.SetRelatedEntity<Email>("Email_AsyncOperations", null, value);
                this.OnPropertyChanged("Email_AsyncOperations");
            }
        }

        /// <summary>
        /// N:1 emailserverprofile_asyncoperations
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("emailserverprofile_asyncoperations")]
        public EmailServerProfile emailserverprofile_asyncoperations
        {
            get { return this.GetRelatedEntity<EmailServerProfile>("emailserverprofile_asyncoperations", null); }
            set
            {
                this.OnPropertyChanging("emailserverprofile_asyncoperations");
                this.SetRelatedEntity<EmailServerProfile>("emailserverprofile_asyncoperations", null, value);
                this.OnPropertyChanged("emailserverprofile_asyncoperations");
            }
        }

        /// <summary>
        /// N:1 entitlement_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("entitlement_AsyncOperations")]
        public Entitlement entitlement_AsyncOperations
        {
            get { return this.GetRelatedEntity<Entitlement>("entitlement_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("entitlement_AsyncOperations");
                this.SetRelatedEntity<Entitlement>("entitlement_AsyncOperations", null, value);
                this.OnPropertyChanged("entitlement_AsyncOperations");
            }
        }

        /// <summary>
        /// N:1 entitlementchannel_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("entitlementchannel_AsyncOperations")]
        public EntitlementChannel entitlementchannel_AsyncOperations
        {
            get { return this.GetRelatedEntity<EntitlementChannel>("entitlementchannel_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("entitlementchannel_AsyncOperations");
                this.SetRelatedEntity<EntitlementChannel>("entitlementchannel_AsyncOperations", null, value);
                this.OnPropertyChanged("entitlementchannel_AsyncOperations");
            }
        }

        /// <summary>
        /// N:1 entitlementtemplate_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("entitlementtemplate_AsyncOperations")]
        public EntitlementTemplate entitlementtemplate_AsyncOperations
        {
            get { return this.GetRelatedEntity<EntitlementTemplate>("entitlementtemplate_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("entitlementtemplate_AsyncOperations");
                this.SetRelatedEntity<EntitlementTemplate>("entitlementtemplate_AsyncOperations", null, value);
                this.OnPropertyChanged("entitlementtemplate_AsyncOperations");
            }
        }

        /// <summary>
        /// N:1 EntityMap_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("EntityMap_AsyncOperations")]
        public EntityMap EntityMap_AsyncOperations
        {
            get { return this.GetRelatedEntity<EntityMap>("EntityMap_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("EntityMap_AsyncOperations");
                this.SetRelatedEntity<EntityMap>("EntityMap_AsyncOperations", null, value);
                this.OnPropertyChanged("EntityMap_AsyncOperations");
            }
        }

        /// <summary>
        /// N:1 Equipment_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Equipment_AsyncOperations")]
        public Equipment Equipment_AsyncOperations
        {
            get { return this.GetRelatedEntity<Equipment>("Equipment_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("Equipment_AsyncOperations");
                this.SetRelatedEntity<Equipment>("Equipment_AsyncOperations", null, value);
                this.OnPropertyChanged("Equipment_AsyncOperations");
            }
        }

        /// <summary>
        /// N:1 Fax_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Fax_AsyncOperations")]
        public Fax Fax_AsyncOperations
        {
            get { return this.GetRelatedEntity<Fax>("Fax_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("Fax_AsyncOperations");
                this.SetRelatedEntity<Fax>("Fax_AsyncOperations", null, value);
                this.OnPropertyChanged("Fax_AsyncOperations");
            }
        }

        /// <summary>
        /// N:1 FixedMonthlyFiscalCalendar_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("FixedMonthlyFiscalCalendar_AsyncOperations")]
        public FixedMonthlyFiscalCalendar FixedMonthlyFiscalCalendar_AsyncOperations
        {
            get { return this.GetRelatedEntity<FixedMonthlyFiscalCalendar>("FixedMonthlyFiscalCalendar_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("FixedMonthlyFiscalCalendar_AsyncOperations");
                this.SetRelatedEntity<FixedMonthlyFiscalCalendar>("FixedMonthlyFiscalCalendar_AsyncOperations", null, value);
                this.OnPropertyChanged("FixedMonthlyFiscalCalendar_AsyncOperations");
            }
        }

        /// <summary>
        /// N:1 Goal_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Goal_AsyncOperations")]
        public Goal Goal_AsyncOperations
        {
            get { return this.GetRelatedEntity<Goal>("Goal_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("Goal_AsyncOperations");
                this.SetRelatedEntity<Goal>("Goal_AsyncOperations", null, value);
                this.OnPropertyChanged("Goal_AsyncOperations");
            }
        }

        /// <summary>
        /// N:1 goalrollupquery_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("goalrollupquery_AsyncOperations")]
        public GoalRollupQuery goalrollupquery_AsyncOperations
        {
            get { return this.GetRelatedEntity<GoalRollupQuery>("goalrollupquery_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("goalrollupquery_AsyncOperations");
                this.SetRelatedEntity<GoalRollupQuery>("goalrollupquery_AsyncOperations", null, value);
                this.OnPropertyChanged("goalrollupquery_AsyncOperations");
            }
        }

        /// <summary>
        /// N:1 Import_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Import_AsyncOperations")]
        public Import Import_AsyncOperations
        {
            get { return this.GetRelatedEntity<Import>("Import_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("Import_AsyncOperations");
                this.SetRelatedEntity<Import>("Import_AsyncOperations", null, value);
                this.OnPropertyChanged("Import_AsyncOperations");
            }
        }

        /// <summary>
        /// N:1 ImportFile_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ImportFile_AsyncOperations")]
        public ImportFile ImportFile_AsyncOperations
        {
            get { return this.GetRelatedEntity<ImportFile>("ImportFile_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("ImportFile_AsyncOperations");
                this.SetRelatedEntity<ImportFile>("ImportFile_AsyncOperations", null, value);
                this.OnPropertyChanged("ImportFile_AsyncOperations");
            }
        }

        /// <summary>
        /// N:1 ImportLog_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ImportLog_AsyncOperations")]
        public ImportLog ImportLog_AsyncOperations
        {
            get { return this.GetRelatedEntity<ImportLog>("ImportLog_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("ImportLog_AsyncOperations");
                this.SetRelatedEntity<ImportLog>("ImportLog_AsyncOperations", null, value);
                this.OnPropertyChanged("ImportLog_AsyncOperations");
            }
        }

        /// <summary>
        /// N:1 ImportMap_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ImportMap_AsyncOperations")]
        public ImportMap ImportMap_AsyncOperations
        {
            get { return this.GetRelatedEntity<ImportMap>("ImportMap_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("ImportMap_AsyncOperations");
                this.SetRelatedEntity<ImportMap>("ImportMap_AsyncOperations", null, value);
                this.OnPropertyChanged("ImportMap_AsyncOperations");
            }
        }

        /// <summary>
        /// N:1 Incident_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Incident_AsyncOperations")]
        public Incident Incident_AsyncOperations
        {
            get { return this.GetRelatedEntity<Incident>("Incident_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("Incident_AsyncOperations");
                this.SetRelatedEntity<Incident>("Incident_AsyncOperations", null, value);
                this.OnPropertyChanged("Incident_AsyncOperations");
            }
        }

        /// <summary>
        /// N:1 IncidentResolution_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("IncidentResolution_AsyncOperations")]
        public IncidentResolution IncidentResolution_AsyncOperations
        {
            get { return this.GetRelatedEntity<IncidentResolution>("IncidentResolution_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("IncidentResolution_AsyncOperations");
                this.SetRelatedEntity<IncidentResolution>("IncidentResolution_AsyncOperations", null, value);
                this.OnPropertyChanged("IncidentResolution_AsyncOperations");
            }
        }

        /// <summary>
        /// N:1 Invoice_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Invoice_AsyncOperations")]
        public Invoice Invoice_AsyncOperations
        {
            get { return this.GetRelatedEntity<Invoice>("Invoice_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("Invoice_AsyncOperations");
                this.SetRelatedEntity<Invoice>("Invoice_AsyncOperations", null, value);
                this.OnPropertyChanged("Invoice_AsyncOperations");
            }
        }

        /// <summary>
        /// N:1 InvoiceDetail_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("InvoiceDetail_AsyncOperations")]
        public InvoiceDetail InvoiceDetail_AsyncOperations
        {
            get { return this.GetRelatedEntity<InvoiceDetail>("InvoiceDetail_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("InvoiceDetail_AsyncOperations");
                this.SetRelatedEntity<InvoiceDetail>("InvoiceDetail_AsyncOperations", null, value);
                this.OnPropertyChanged("InvoiceDetail_AsyncOperations");
            }
        }

        /// <summary>
        /// N:1 IsvConfig_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("IsvConfig_AsyncOperations")]
        public IsvConfig IsvConfig_AsyncOperations
        {
            get { return this.GetRelatedEntity<IsvConfig>("IsvConfig_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("IsvConfig_AsyncOperations");
                this.SetRelatedEntity<IsvConfig>("IsvConfig_AsyncOperations", null, value);
                this.OnPropertyChanged("IsvConfig_AsyncOperations");
            }
        }

        /// <summary>
        /// N:1 KbArticle_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("KbArticle_AsyncOperations")]
        public KbArticle KbArticle_AsyncOperations
        {
            get { return this.GetRelatedEntity<KbArticle>("KbArticle_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("KbArticle_AsyncOperations");
                this.SetRelatedEntity<KbArticle>("KbArticle_AsyncOperations", null, value);
                this.OnPropertyChanged("KbArticle_AsyncOperations");
            }
        }

        /// <summary>
        /// N:1 KbArticleComment_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("KbArticleComment_AsyncOperations")]
        public KbArticleComment KbArticleComment_AsyncOperations
        {
            get { return this.GetRelatedEntity<KbArticleComment>("KbArticleComment_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("KbArticleComment_AsyncOperations");
                this.SetRelatedEntity<KbArticleComment>("KbArticleComment_AsyncOperations", null, value);
                this.OnPropertyChanged("KbArticleComment_AsyncOperations");
            }
        }

        /// <summary>
        /// N:1 KbArticleTemplate_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("KbArticleTemplate_AsyncOperations")]
        public KbArticleTemplate KbArticleTemplate_AsyncOperations
        {
            get { return this.GetRelatedEntity<KbArticleTemplate>("KbArticleTemplate_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("KbArticleTemplate_AsyncOperations");
                this.SetRelatedEntity<KbArticleTemplate>("KbArticleTemplate_AsyncOperations", null, value);
                this.OnPropertyChanged("KbArticleTemplate_AsyncOperations");
            }
        }

        /// <summary>
        /// N:1 Lead_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Lead_AsyncOperations")]
        public Lead Lead_AsyncOperations
        {
            get { return this.GetRelatedEntity<Lead>("Lead_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("Lead_AsyncOperations");
                this.SetRelatedEntity<Lead>("Lead_AsyncOperations", null, value);
                this.OnPropertyChanged("Lead_AsyncOperations");
            }
        }

        /// <summary>
        /// N:1 Letter_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Letter_AsyncOperations")]
        public Letter Letter_AsyncOperations
        {
            get { return this.GetRelatedEntity<Letter>("Letter_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("Letter_AsyncOperations");
                this.SetRelatedEntity<Letter>("Letter_AsyncOperations", null, value);
                this.OnPropertyChanged("Letter_AsyncOperations");
            }
        }

        /// <summary>
        /// N:1 List_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("List_AsyncOperations")]
        public List List_AsyncOperations
        {
            get { return this.GetRelatedEntity<List>("List_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("List_AsyncOperations");
                this.SetRelatedEntity<List>("List_AsyncOperations", null, value);
                this.OnPropertyChanged("List_AsyncOperations");
            }
        }

        /// <summary>
        /// N:1 lk_asyncoperation_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_asyncoperation_createdby")]
        public SystemUser lk_asyncoperation_createdby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_asyncoperation_createdby", null); }
        }

        /// <summary>
        /// N:1 lk_asyncoperation_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_asyncoperation_createdonbehalfby")]
        public SystemUser lk_asyncoperation_createdonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_asyncoperation_createdonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_asyncoperation_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_asyncoperation_modifiedby")]
        public SystemUser lk_asyncoperation_modifiedby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_asyncoperation_modifiedby", null); }
        }

        /// <summary>
        /// N:1 lk_asyncoperation_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_asyncoperation_modifiedonbehalfby")]
        public SystemUser lk_asyncoperation_modifiedonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_asyncoperation_modifiedonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_asyncoperation_workflowactivationid
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("workflowactivationid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_asyncoperation_workflowactivationid")]
        public Workflow lk_asyncoperation_workflowactivationid
        {
            get { return this.GetRelatedEntity<Workflow>("lk_asyncoperation_workflowactivationid", null); }
            set
            {
                this.OnPropertyChanging("lk_asyncoperation_workflowactivationid");
                this.SetRelatedEntity<Workflow>("lk_asyncoperation_workflowactivationid", null, value);
                this.OnPropertyChanged("lk_asyncoperation_workflowactivationid");
            }
        }

        /// <summary>
        /// N:1 mailbox_asyncoperations
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("mailbox_asyncoperations")]
        public Mailbox mailbox_asyncoperations
        {
            get { return this.GetRelatedEntity<Mailbox>("mailbox_asyncoperations", null); }
            set
            {
                this.OnPropertyChanging("mailbox_asyncoperations");
                this.SetRelatedEntity<Mailbox>("mailbox_asyncoperations", null, value);
                this.OnPropertyChanged("mailbox_asyncoperations");
            }
        }

        /// <summary>
        /// N:1 MailMergeTemplate_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("MailMergeTemplate_AsyncOperations")]
        public MailMergeTemplate MailMergeTemplate_AsyncOperations
        {
            get { return this.GetRelatedEntity<MailMergeTemplate>("MailMergeTemplate_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("MailMergeTemplate_AsyncOperations");
                this.SetRelatedEntity<MailMergeTemplate>("MailMergeTemplate_AsyncOperations", null, value);
                this.OnPropertyChanged("MailMergeTemplate_AsyncOperations");
            }
        }

        /// <summary>
        /// N:1 metric_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("metric_AsyncOperations")]
        public Metric metric_AsyncOperations
        {
            get { return this.GetRelatedEntity<Metric>("metric_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("metric_AsyncOperations");
                this.SetRelatedEntity<Metric>("metric_AsyncOperations", null, value);
                this.OnPropertyChanged("metric_AsyncOperations");
            }
        }

        /// <summary>
        /// N:1 MonthlyFiscalCalendar_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("MonthlyFiscalCalendar_AsyncOperations")]
        public MonthlyFiscalCalendar MonthlyFiscalCalendar_AsyncOperations
        {
            get { return this.GetRelatedEntity<MonthlyFiscalCalendar>("MonthlyFiscalCalendar_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("MonthlyFiscalCalendar_AsyncOperations");
                this.SetRelatedEntity<MonthlyFiscalCalendar>("MonthlyFiscalCalendar_AsyncOperations", null, value);
                this.OnPropertyChanged("MonthlyFiscalCalendar_AsyncOperations");
            }
        }

        /// <summary>
        /// N:1 msdyn_postalbum_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_postalbum_AsyncOperations")]
        public msdyn_PostAlbum msdyn_postalbum_AsyncOperations
        {
            get { return this.GetRelatedEntity<msdyn_PostAlbum>("msdyn_postalbum_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("msdyn_postalbum_AsyncOperations");
                this.SetRelatedEntity<msdyn_PostAlbum>("msdyn_postalbum_AsyncOperations", null, value);
                this.OnPropertyChanged("msdyn_postalbum_AsyncOperations");
            }
        }

        /// <summary>
        /// N:1 msdyn_postconfig_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_postconfig_AsyncOperations")]
        public msdyn_PostConfig msdyn_postconfig_AsyncOperations
        {
            get { return this.GetRelatedEntity<msdyn_PostConfig>("msdyn_postconfig_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("msdyn_postconfig_AsyncOperations");
                this.SetRelatedEntity<msdyn_PostConfig>("msdyn_postconfig_AsyncOperations", null, value);
                this.OnPropertyChanged("msdyn_postconfig_AsyncOperations");
            }
        }

        /// <summary>
        /// N:1 msdyn_postruleconfig_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_postruleconfig_AsyncOperations")]
        public msdyn_PostRuleConfig msdyn_postruleconfig_AsyncOperations
        {
            get { return this.GetRelatedEntity<msdyn_PostRuleConfig>("msdyn_postruleconfig_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("msdyn_postruleconfig_AsyncOperations");
                this.SetRelatedEntity<msdyn_PostRuleConfig>("msdyn_postruleconfig_AsyncOperations", null, value);
                this.OnPropertyChanged("msdyn_postruleconfig_AsyncOperations");
            }
        }

        /// <summary>
        /// N:1 msdyn_wallsavedquery_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_wallsavedquery_AsyncOperations")]
        public msdyn_wallsavedquery msdyn_wallsavedquery_AsyncOperations
        {
            get { return this.GetRelatedEntity<msdyn_wallsavedquery>("msdyn_wallsavedquery_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("msdyn_wallsavedquery_AsyncOperations");
                this.SetRelatedEntity<msdyn_wallsavedquery>("msdyn_wallsavedquery_AsyncOperations", null, value);
                this.OnPropertyChanged("msdyn_wallsavedquery_AsyncOperations");
            }
        }

        /// <summary>
        /// N:1 msdyn_wallsavedqueryusersettings_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_wallsavedqueryusersettings_AsyncOperations")]
        public msdyn_wallsavedqueryusersettings msdyn_wallsavedqueryusersettings_AsyncOperations
        {
            get { return this.GetRelatedEntity<msdyn_wallsavedqueryusersettings>("msdyn_wallsavedqueryusersettings_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("msdyn_wallsavedqueryusersettings_AsyncOperations");
                this.SetRelatedEntity<msdyn_wallsavedqueryusersettings>("msdyn_wallsavedqueryusersettings_AsyncOperations", null, value);
                this.OnPropertyChanged("msdyn_wallsavedqueryusersettings_AsyncOperations");
            }
        }

        /// <summary>
        /// N:1 Opportunity_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Opportunity_AsyncOperations")]
        public Opportunity Opportunity_AsyncOperations
        {
            get { return this.GetRelatedEntity<Opportunity>("Opportunity_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("Opportunity_AsyncOperations");
                this.SetRelatedEntity<Opportunity>("Opportunity_AsyncOperations", null, value);
                this.OnPropertyChanged("Opportunity_AsyncOperations");
            }
        }

        /// <summary>
        /// N:1 OpportunityClose_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("OpportunityClose_AsyncOperations")]
        public OpportunityClose OpportunityClose_AsyncOperations
        {
            get { return this.GetRelatedEntity<OpportunityClose>("OpportunityClose_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("OpportunityClose_AsyncOperations");
                this.SetRelatedEntity<OpportunityClose>("OpportunityClose_AsyncOperations", null, value);
                this.OnPropertyChanged("OpportunityClose_AsyncOperations");
            }
        }

        /// <summary>
        /// N:1 OpportunityProduct_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("OpportunityProduct_AsyncOperations")]
        public OpportunityProduct OpportunityProduct_AsyncOperations
        {
            get { return this.GetRelatedEntity<OpportunityProduct>("OpportunityProduct_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("OpportunityProduct_AsyncOperations");
                this.SetRelatedEntity<OpportunityProduct>("OpportunityProduct_AsyncOperations", null, value);
                this.OnPropertyChanged("OpportunityProduct_AsyncOperations");
            }
        }

        /// <summary>
        /// N:1 OrderClose_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("OrderClose_AsyncOperations")]
        public OrderClose OrderClose_AsyncOperations
        {
            get { return this.GetRelatedEntity<OrderClose>("OrderClose_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("OrderClose_AsyncOperations");
                this.SetRelatedEntity<OrderClose>("OrderClose_AsyncOperations", null, value);
                this.OnPropertyChanged("OrderClose_AsyncOperations");
            }
        }

        /// <summary>
        /// N:1 Organization_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Organization_AsyncOperations")]
        public Organization Organization_AsyncOperations
        {
            get { return this.GetRelatedEntity<Organization>("Organization_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("Organization_AsyncOperations");
                this.SetRelatedEntity<Organization>("Organization_AsyncOperations", null, value);
                this.OnPropertyChanged("Organization_AsyncOperations");
            }
        }

        /// <summary>
        /// N:1 PhoneCall_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("PhoneCall_AsyncOperations")]
        public PhoneCall PhoneCall_AsyncOperations
        {
            get { return this.GetRelatedEntity<PhoneCall>("PhoneCall_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("PhoneCall_AsyncOperations");
                this.SetRelatedEntity<PhoneCall>("PhoneCall_AsyncOperations", null, value);
                this.OnPropertyChanged("PhoneCall_AsyncOperations");
            }
        }

        /// <summary>
        /// N:1 position_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("position_AsyncOperations")]
        public Position position_AsyncOperations
        {
            get { return this.GetRelatedEntity<Position>("position_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("position_AsyncOperations");
                this.SetRelatedEntity<Position>("position_AsyncOperations", null, value);
                this.OnPropertyChanged("position_AsyncOperations");
            }
        }

        /// <summary>
        /// N:1 post_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("post_AsyncOperations")]
        public Post post_AsyncOperations
        {
            get { return this.GetRelatedEntity<Post>("post_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("post_AsyncOperations");
                this.SetRelatedEntity<Post>("post_AsyncOperations", null, value);
                this.OnPropertyChanged("post_AsyncOperations");
            }
        }

        /// <summary>
        /// N:1 PostFollow_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("PostFollow_AsyncOperations")]
        public PostFollow PostFollow_AsyncOperations
        {
            get { return this.GetRelatedEntity<PostFollow>("PostFollow_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("PostFollow_AsyncOperations");
                this.SetRelatedEntity<PostFollow>("PostFollow_AsyncOperations", null, value);
                this.OnPropertyChanged("PostFollow_AsyncOperations");
            }
        }

        /// <summary>
        /// N:1 PriceLevel_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("PriceLevel_AsyncOperations")]
        public PriceLevel PriceLevel_AsyncOperations
        {
            get { return this.GetRelatedEntity<PriceLevel>("PriceLevel_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("PriceLevel_AsyncOperations");
                this.SetRelatedEntity<PriceLevel>("PriceLevel_AsyncOperations", null, value);
                this.OnPropertyChanged("PriceLevel_AsyncOperations");
            }
        }

        /// <summary>
        /// N:1 Privilege_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Privilege_AsyncOperations")]
        public Privilege Privilege_AsyncOperations
        {
            get { return this.GetRelatedEntity<Privilege>("Privilege_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("Privilege_AsyncOperations");
                this.SetRelatedEntity<Privilege>("Privilege_AsyncOperations", null, value);
                this.OnPropertyChanged("Privilege_AsyncOperations");
            }
        }

        /// <summary>
        /// N:1 Product_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Product_AsyncOperations")]
        public Product Product_AsyncOperations
        {
            get { return this.GetRelatedEntity<Product>("Product_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("Product_AsyncOperations");
                this.SetRelatedEntity<Product>("Product_AsyncOperations", null, value);
                this.OnPropertyChanged("Product_AsyncOperations");
            }
        }

        /// <summary>
        /// N:1 ProductAssociation_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ProductAssociation_AsyncOperations")]
        public ProductAssociation ProductAssociation_AsyncOperations
        {
            get { return this.GetRelatedEntity<ProductAssociation>("ProductAssociation_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("ProductAssociation_AsyncOperations");
                this.SetRelatedEntity<ProductAssociation>("ProductAssociation_AsyncOperations", null, value);
                this.OnPropertyChanged("ProductAssociation_AsyncOperations");
            }
        }

        /// <summary>
        /// N:1 ProductPriceLevel_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ProductPriceLevel_AsyncOperations")]
        public ProductPriceLevel ProductPriceLevel_AsyncOperations
        {
            get { return this.GetRelatedEntity<ProductPriceLevel>("ProductPriceLevel_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("ProductPriceLevel_AsyncOperations");
                this.SetRelatedEntity<ProductPriceLevel>("ProductPriceLevel_AsyncOperations", null, value);
                this.OnPropertyChanged("ProductPriceLevel_AsyncOperations");
            }
        }

        /// <summary>
        /// N:1 ProductSubstitute_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ProductSubstitute_AsyncOperations")]
        public ProductSubstitute ProductSubstitute_AsyncOperations
        {
            get { return this.GetRelatedEntity<ProductSubstitute>("ProductSubstitute_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("ProductSubstitute_AsyncOperations");
                this.SetRelatedEntity<ProductSubstitute>("ProductSubstitute_AsyncOperations", null, value);
                this.OnPropertyChanged("ProductSubstitute_AsyncOperations");
            }
        }

        /// <summary>
        /// N:1 QuarterlyFiscalCalendar_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("QuarterlyFiscalCalendar_AsyncOperations")]
        public QuarterlyFiscalCalendar QuarterlyFiscalCalendar_AsyncOperations
        {
            get { return this.GetRelatedEntity<QuarterlyFiscalCalendar>("QuarterlyFiscalCalendar_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("QuarterlyFiscalCalendar_AsyncOperations");
                this.SetRelatedEntity<QuarterlyFiscalCalendar>("QuarterlyFiscalCalendar_AsyncOperations", null, value);
                this.OnPropertyChanged("QuarterlyFiscalCalendar_AsyncOperations");
            }
        }

        /// <summary>
        /// N:1 Queue_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Queue_AsyncOperations")]
        public Queue Queue_AsyncOperations
        {
            get { return this.GetRelatedEntity<Queue>("Queue_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("Queue_AsyncOperations");
                this.SetRelatedEntity<Queue>("Queue_AsyncOperations", null, value);
                this.OnPropertyChanged("Queue_AsyncOperations");
            }
        }

        /// <summary>
        /// N:1 QueueItem_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("QueueItem_AsyncOperations")]
        public QueueItem QueueItem_AsyncOperations
        {
            get { return this.GetRelatedEntity<QueueItem>("QueueItem_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("QueueItem_AsyncOperations");
                this.SetRelatedEntity<QueueItem>("QueueItem_AsyncOperations", null, value);
                this.OnPropertyChanged("QueueItem_AsyncOperations");
            }
        }

        /// <summary>
        /// N:1 Quote_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Quote_AsyncOperations")]
        public Quote Quote_AsyncOperations
        {
            get { return this.GetRelatedEntity<Quote>("Quote_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("Quote_AsyncOperations");
                this.SetRelatedEntity<Quote>("Quote_AsyncOperations", null, value);
                this.OnPropertyChanged("Quote_AsyncOperations");
            }
        }

        /// <summary>
        /// N:1 QuoteClose_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("QuoteClose_AsyncOperations")]
        public QuoteClose QuoteClose_AsyncOperations
        {
            get { return this.GetRelatedEntity<QuoteClose>("QuoteClose_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("QuoteClose_AsyncOperations");
                this.SetRelatedEntity<QuoteClose>("QuoteClose_AsyncOperations", null, value);
                this.OnPropertyChanged("QuoteClose_AsyncOperations");
            }
        }

        /// <summary>
        /// N:1 QuoteDetail_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("QuoteDetail_AsyncOperations")]
        public QuoteDetail QuoteDetail_AsyncOperations
        {
            get { return this.GetRelatedEntity<QuoteDetail>("QuoteDetail_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("QuoteDetail_AsyncOperations");
                this.SetRelatedEntity<QuoteDetail>("QuoteDetail_AsyncOperations", null, value);
                this.OnPropertyChanged("QuoteDetail_AsyncOperations");
            }
        }

        /// <summary>
        /// N:1 RecurringAppointmentMaster_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("RecurringAppointmentMaster_AsyncOperations")]
        public RecurringAppointmentMaster RecurringAppointmentMaster_AsyncOperations
        {
            get { return this.GetRelatedEntity<RecurringAppointmentMaster>("RecurringAppointmentMaster_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("RecurringAppointmentMaster_AsyncOperations");
                this.SetRelatedEntity<RecurringAppointmentMaster>("RecurringAppointmentMaster_AsyncOperations", null, value);
                this.OnPropertyChanged("RecurringAppointmentMaster_AsyncOperations");
            }
        }

        /// <summary>
        /// N:1 RelationshipRole_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("RelationshipRole_AsyncOperations")]
        public RelationshipRole RelationshipRole_AsyncOperations
        {
            get { return this.GetRelatedEntity<RelationshipRole>("RelationshipRole_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("RelationshipRole_AsyncOperations");
                this.SetRelatedEntity<RelationshipRole>("RelationshipRole_AsyncOperations", null, value);
                this.OnPropertyChanged("RelationshipRole_AsyncOperations");
            }
        }

        /// <summary>
        /// N:1 RelationshipRoleMap_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("RelationshipRoleMap_AsyncOperations")]
        public RelationshipRoleMap RelationshipRoleMap_AsyncOperations
        {
            get { return this.GetRelatedEntity<RelationshipRoleMap>("RelationshipRoleMap_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("RelationshipRoleMap_AsyncOperations");
                this.SetRelatedEntity<RelationshipRoleMap>("RelationshipRoleMap_AsyncOperations", null, value);
                this.OnPropertyChanged("RelationshipRoleMap_AsyncOperations");
            }
        }

        /// <summary>
        /// N:1 Report_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Report_AsyncOperations")]
        public Report Report_AsyncOperations
        {
            get { return this.GetRelatedEntity<Report>("Report_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("Report_AsyncOperations");
                this.SetRelatedEntity<Report>("Report_AsyncOperations", null, value);
                this.OnPropertyChanged("Report_AsyncOperations");
            }
        }

        /// <summary>
        /// N:1 Resource_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Resource_AsyncOperations")]
        public Resource Resource_AsyncOperations
        {
            get { return this.GetRelatedEntity<Resource>("Resource_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("Resource_AsyncOperations");
                this.SetRelatedEntity<Resource>("Resource_AsyncOperations", null, value);
                this.OnPropertyChanged("Resource_AsyncOperations");
            }
        }

        /// <summary>
        /// N:1 ResourceGroup_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ResourceGroup_AsyncOperations")]
        public ResourceGroup ResourceGroup_AsyncOperations
        {
            get { return this.GetRelatedEntity<ResourceGroup>("ResourceGroup_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("ResourceGroup_AsyncOperations");
                this.SetRelatedEntity<ResourceGroup>("ResourceGroup_AsyncOperations", null, value);
                this.OnPropertyChanged("ResourceGroup_AsyncOperations");
            }
        }

        /// <summary>
        /// N:1 ResourceSpec_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ResourceSpec_AsyncOperations")]
        public ResourceSpec ResourceSpec_AsyncOperations
        {
            get { return this.GetRelatedEntity<ResourceSpec>("ResourceSpec_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("ResourceSpec_AsyncOperations");
                this.SetRelatedEntity<ResourceSpec>("ResourceSpec_AsyncOperations", null, value);
                this.OnPropertyChanged("ResourceSpec_AsyncOperations");
            }
        }

        /// <summary>
        /// N:1 Role_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Role_AsyncOperations")]
        public Role Role_AsyncOperations
        {
            get { return this.GetRelatedEntity<Role>("Role_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("Role_AsyncOperations");
                this.SetRelatedEntity<Role>("Role_AsyncOperations", null, value);
                this.OnPropertyChanged("Role_AsyncOperations");
            }
        }

        /// <summary>
        /// N:1 rollupfield_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("rollupfield_AsyncOperations")]
        public RollupField rollupfield_AsyncOperations
        {
            get { return this.GetRelatedEntity<RollupField>("rollupfield_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("rollupfield_AsyncOperations");
                this.SetRelatedEntity<RollupField>("rollupfield_AsyncOperations", null, value);
                this.OnPropertyChanged("rollupfield_AsyncOperations");
            }
        }

        /// <summary>
        /// N:1 routingrule_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("routingrule_AsyncOperations")]
        public RoutingRule routingrule_AsyncOperations
        {
            get { return this.GetRelatedEntity<RoutingRule>("routingrule_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("routingrule_AsyncOperations");
                this.SetRelatedEntity<RoutingRule>("routingrule_AsyncOperations", null, value);
                this.OnPropertyChanged("routingrule_AsyncOperations");
            }
        }

        /// <summary>
        /// N:1 routingruleitem_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("routingruleitem_AsyncOperations")]
        public RoutingRuleItem routingruleitem_AsyncOperations
        {
            get { return this.GetRelatedEntity<RoutingRuleItem>("routingruleitem_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("routingruleitem_AsyncOperations");
                this.SetRelatedEntity<RoutingRuleItem>("routingruleitem_AsyncOperations", null, value);
                this.OnPropertyChanged("routingruleitem_AsyncOperations");
            }
        }

        /// <summary>
        /// N:1 SalesLiterature_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SalesLiterature_AsyncOperations")]
        public SalesLiterature SalesLiterature_AsyncOperations
        {
            get { return this.GetRelatedEntity<SalesLiterature>("SalesLiterature_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("SalesLiterature_AsyncOperations");
                this.SetRelatedEntity<SalesLiterature>("SalesLiterature_AsyncOperations", null, value);
                this.OnPropertyChanged("SalesLiterature_AsyncOperations");
            }
        }

        /// <summary>
        /// N:1 SalesLiteratureItem_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SalesLiteratureItem_AsyncOperations")]
        public SalesLiteratureItem SalesLiteratureItem_AsyncOperations
        {
            get { return this.GetRelatedEntity<SalesLiteratureItem>("SalesLiteratureItem_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("SalesLiteratureItem_AsyncOperations");
                this.SetRelatedEntity<SalesLiteratureItem>("SalesLiteratureItem_AsyncOperations", null, value);
                this.OnPropertyChanged("SalesLiteratureItem_AsyncOperations");
            }
        }

        /// <summary>
        /// N:1 SalesOrder_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SalesOrder_AsyncOperations")]
        public SalesOrder SalesOrder_AsyncOperations
        {
            get { return this.GetRelatedEntity<SalesOrder>("SalesOrder_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("SalesOrder_AsyncOperations");
                this.SetRelatedEntity<SalesOrder>("SalesOrder_AsyncOperations", null, value);
                this.OnPropertyChanged("SalesOrder_AsyncOperations");
            }
        }

        /// <summary>
        /// N:1 SalesOrderDetail_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SalesOrderDetail_AsyncOperations")]
        public SalesOrderDetail SalesOrderDetail_AsyncOperations
        {
            get { return this.GetRelatedEntity<SalesOrderDetail>("SalesOrderDetail_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("SalesOrderDetail_AsyncOperations");
                this.SetRelatedEntity<SalesOrderDetail>("SalesOrderDetail_AsyncOperations", null, value);
                this.OnPropertyChanged("SalesOrderDetail_AsyncOperations");
            }
        }

        /// <summary>
        /// N:1 SavedQuery_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SavedQuery_AsyncOperations")]
        public SavedQuery SavedQuery_AsyncOperations
        {
            get { return this.GetRelatedEntity<SavedQuery>("SavedQuery_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("SavedQuery_AsyncOperations");
                this.SetRelatedEntity<SavedQuery>("SavedQuery_AsyncOperations", null, value);
                this.OnPropertyChanged("SavedQuery_AsyncOperations");
            }
        }

        /// <summary>
        /// N:1 SdkMessageProcessingStep_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningextensionid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SdkMessageProcessingStep_AsyncOperations")]
        public SdkMessageProcessingStep SdkMessageProcessingStep_AsyncOperations
        {
            get { return this.GetRelatedEntity<SdkMessageProcessingStep>("SdkMessageProcessingStep_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("SdkMessageProcessingStep_AsyncOperations");
                this.SetRelatedEntity<SdkMessageProcessingStep>("SdkMessageProcessingStep_AsyncOperations", null, value);
                this.OnPropertyChanged("SdkMessageProcessingStep_AsyncOperations");
            }
        }

        /// <summary>
        /// N:1 SemiAnnualFiscalCalendar_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SemiAnnualFiscalCalendar_AsyncOperations")]
        public SemiAnnualFiscalCalendar SemiAnnualFiscalCalendar_AsyncOperations
        {
            get { return this.GetRelatedEntity<SemiAnnualFiscalCalendar>("SemiAnnualFiscalCalendar_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("SemiAnnualFiscalCalendar_AsyncOperations");
                this.SetRelatedEntity<SemiAnnualFiscalCalendar>("SemiAnnualFiscalCalendar_AsyncOperations", null, value);
                this.OnPropertyChanged("SemiAnnualFiscalCalendar_AsyncOperations");
            }
        }

        /// <summary>
        /// N:1 Service_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Service_AsyncOperations")]
        public Service Service_AsyncOperations
        {
            get { return this.GetRelatedEntity<Service>("Service_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("Service_AsyncOperations");
                this.SetRelatedEntity<Service>("Service_AsyncOperations", null, value);
                this.OnPropertyChanged("Service_AsyncOperations");
            }
        }

        /// <summary>
        /// N:1 ServiceAppointment_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ServiceAppointment_AsyncOperations")]
        public ServiceAppointment ServiceAppointment_AsyncOperations
        {
            get { return this.GetRelatedEntity<ServiceAppointment>("ServiceAppointment_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("ServiceAppointment_AsyncOperations");
                this.SetRelatedEntity<ServiceAppointment>("ServiceAppointment_AsyncOperations", null, value);
                this.OnPropertyChanged("ServiceAppointment_AsyncOperations");
            }
        }

        /// <summary>
        /// N:1 SharePointDocumentLocation_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SharePointDocumentLocation_AsyncOperations")]
        public SharePointDocumentLocation SharePointDocumentLocation_AsyncOperations
        {
            get { return this.GetRelatedEntity<SharePointDocumentLocation>("SharePointDocumentLocation_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("SharePointDocumentLocation_AsyncOperations");
                this.SetRelatedEntity<SharePointDocumentLocation>("SharePointDocumentLocation_AsyncOperations", null, value);
                this.OnPropertyChanged("SharePointDocumentLocation_AsyncOperations");
            }
        }

        /// <summary>
        /// N:1 SharePointSite_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SharePointSite_AsyncOperations")]
        public SharePointSite SharePointSite_AsyncOperations
        {
            get { return this.GetRelatedEntity<SharePointSite>("SharePointSite_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("SharePointSite_AsyncOperations");
                this.SetRelatedEntity<SharePointSite>("SharePointSite_AsyncOperations", null, value);
                this.OnPropertyChanged("SharePointSite_AsyncOperations");
            }
        }

        /// <summary>
        /// N:1 Site_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Site_AsyncOperations")]
        public Site Site_AsyncOperations
        {
            get { return this.GetRelatedEntity<Site>("Site_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("Site_AsyncOperations");
                this.SetRelatedEntity<Site>("Site_AsyncOperations", null, value);
                this.OnPropertyChanged("Site_AsyncOperations");
            }
        }

        /// <summary>
        /// N:1 slabase_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("slabase_AsyncOperations")]
        public SLA slabase_AsyncOperations
        {
            get { return this.GetRelatedEntity<SLA>("slabase_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("slabase_AsyncOperations");
                this.SetRelatedEntity<SLA>("slabase_AsyncOperations", null, value);
                this.OnPropertyChanged("slabase_AsyncOperations");
            }
        }

        /// <summary>
        /// N:1 SocialActivity_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SocialActivity_AsyncOperations")]
        public SocialActivity SocialActivity_AsyncOperations
        {
            get { return this.GetRelatedEntity<SocialActivity>("SocialActivity_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("SocialActivity_AsyncOperations");
                this.SetRelatedEntity<SocialActivity>("SocialActivity_AsyncOperations", null, value);
                this.OnPropertyChanged("SocialActivity_AsyncOperations");
            }
        }

        /// <summary>
        /// N:1 SocialProfile_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SocialProfile_AsyncOperations")]
        public SocialProfile SocialProfile_AsyncOperations
        {
            get { return this.GetRelatedEntity<SocialProfile>("SocialProfile_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("SocialProfile_AsyncOperations");
                this.SetRelatedEntity<SocialProfile>("SocialProfile_AsyncOperations", null, value);
                this.OnPropertyChanged("SocialProfile_AsyncOperations");
            }
        }

        /// <summary>
        /// N:1 Subject_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Subject_AsyncOperations")]
        public Subject Subject_AsyncOperations
        {
            get { return this.GetRelatedEntity<Subject>("Subject_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("Subject_AsyncOperations");
                this.SetRelatedEntity<Subject>("Subject_AsyncOperations", null, value);
                this.OnPropertyChanged("Subject_AsyncOperations");
            }
        }

        /// <summary>
        /// N:1 system_user_asyncoperation
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("system_user_asyncoperation")]
        public SystemUser system_user_asyncoperation
        {
            get { return this.GetRelatedEntity<SystemUser>("system_user_asyncoperation", null); }
        }

        /// <summary>
        /// N:1 SystemForm_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SystemForm_AsyncOperations")]
        public SystemForm SystemForm_AsyncOperations
        {
            get { return this.GetRelatedEntity<SystemForm>("SystemForm_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("SystemForm_AsyncOperations");
                this.SetRelatedEntity<SystemForm>("SystemForm_AsyncOperations", null, value);
                this.OnPropertyChanged("SystemForm_AsyncOperations");
            }
        }

        /// <summary>
        /// N:1 SystemUser_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SystemUser_AsyncOperations")]
        public SystemUser SystemUser_AsyncOperations
        {
            get { return this.GetRelatedEntity<SystemUser>("SystemUser_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("SystemUser_AsyncOperations");
                this.SetRelatedEntity<SystemUser>("SystemUser_AsyncOperations", null, value);
                this.OnPropertyChanged("SystemUser_AsyncOperations");
            }
        }

        /// <summary>
        /// N:1 Task_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Task_AsyncOperations")]
        public Task Task_AsyncOperations
        {
            get { return this.GetRelatedEntity<Task>("Task_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("Task_AsyncOperations");
                this.SetRelatedEntity<Task>("Task_AsyncOperations", null, value);
                this.OnPropertyChanged("Task_AsyncOperations");
            }
        }

        /// <summary>
        /// N:1 team_asyncoperation
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_asyncoperation")]
        public Team team_asyncoperation
        {
            get { return this.GetRelatedEntity<Team>("team_asyncoperation", null); }
        }

        /// <summary>
        /// N:1 Team_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Team_AsyncOperations")]
        public Team Team_AsyncOperations
        {
            get { return this.GetRelatedEntity<Team>("Team_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("Team_AsyncOperations");
                this.SetRelatedEntity<Team>("Team_AsyncOperations", null, value);
                this.OnPropertyChanged("Team_AsyncOperations");
            }
        }

        /// <summary>
        /// N:1 Template_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Template_AsyncOperations")]
        public Template Template_AsyncOperations
        {
            get { return this.GetRelatedEntity<Template>("Template_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("Template_AsyncOperations");
                this.SetRelatedEntity<Template>("Template_AsyncOperations", null, value);
                this.OnPropertyChanged("Template_AsyncOperations");
            }
        }

        /// <summary>
        /// N:1 Territory_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Territory_AsyncOperations")]
        public Territory Territory_AsyncOperations
        {
            get { return this.GetRelatedEntity<Territory>("Territory_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("Territory_AsyncOperations");
                this.SetRelatedEntity<Territory>("Territory_AsyncOperations", null, value);
                this.OnPropertyChanged("Territory_AsyncOperations");
            }
        }

        /// <summary>
        /// N:1 TransactionCurrency_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("TransactionCurrency_AsyncOperations")]
        public TransactionCurrency TransactionCurrency_AsyncOperations
        {
            get { return this.GetRelatedEntity<TransactionCurrency>("TransactionCurrency_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("TransactionCurrency_AsyncOperations");
                this.SetRelatedEntity<TransactionCurrency>("TransactionCurrency_AsyncOperations", null, value);
                this.OnPropertyChanged("TransactionCurrency_AsyncOperations");
            }
        }

        /// <summary>
        /// N:1 UoM_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("UoM_AsyncOperations")]
        public UoM UoM_AsyncOperations
        {
            get { return this.GetRelatedEntity<UoM>("UoM_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("UoM_AsyncOperations");
                this.SetRelatedEntity<UoM>("UoM_AsyncOperations", null, value);
                this.OnPropertyChanged("UoM_AsyncOperations");
            }
        }

        /// <summary>
        /// N:1 UoMSchedule_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("UoMSchedule_AsyncOperations")]
        public UoMSchedule UoMSchedule_AsyncOperations
        {
            get { return this.GetRelatedEntity<UoMSchedule>("UoMSchedule_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("UoMSchedule_AsyncOperations");
                this.SetRelatedEntity<UoMSchedule>("UoMSchedule_AsyncOperations", null, value);
                this.OnPropertyChanged("UoMSchedule_AsyncOperations");
            }
        }

        /// <summary>
        /// N:1 UserForm_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("UserForm_AsyncOperations")]
        public UserForm UserForm_AsyncOperations
        {
            get { return this.GetRelatedEntity<UserForm>("UserForm_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("UserForm_AsyncOperations");
                this.SetRelatedEntity<UserForm>("UserForm_AsyncOperations", null, value);
                this.OnPropertyChanged("UserForm_AsyncOperations");
            }
        }

        /// <summary>
        /// N:1 UserQuery_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("UserQuery_AsyncOperations")]
        public UserQuery UserQuery_AsyncOperations
        {
            get { return this.GetRelatedEntity<UserQuery>("UserQuery_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("UserQuery_AsyncOperations");
                this.SetRelatedEntity<UserQuery>("UserQuery_AsyncOperations", null, value);
                this.OnPropertyChanged("UserQuery_AsyncOperations");
            }
        }
    }
}