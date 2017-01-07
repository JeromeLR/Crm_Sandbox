using _4_DAL_CRM;

namespace __4_DAL_CRM
{
    /// <summary>
    /// Generic activity representing work needed to be done.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("task")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class Task : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public Task() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "task";

        public const int EntityTypeCode = 4212;

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
        /// Unique identifier of the task.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("activityid")]
        public System.Nullable<System.Guid> ActivityId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("activityid"); }
            set
            {
                this.OnPropertyChanging("ActivityId");
                this.SetAttributeValue("activityid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("ActivityId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("activityid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.ActivityId = value; }
        }

        /// <summary>
        /// Type of activity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("activitytypecode")]
        public string ActivityTypeCode
        {
            get { return this.GetAttributeValue<string>("activitytypecode"); }
        }

        /// <summary>
        /// Type the number of minutes spent on the task. The duration is used in reporting.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("actualdurationminutes")]
        public System.Nullable<int> ActualDurationMinutes
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("actualdurationminutes"); }
            set
            {
                this.OnPropertyChanging("ActualDurationMinutes");
                this.SetAttributeValue("actualdurationminutes", value);
                this.OnPropertyChanged("ActualDurationMinutes");
            }
        }

        /// <summary>
        /// Enter the actual end date and time of the task. By default, it displays when the activity was completed or canceled.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("actualend")]
        public System.Nullable<System.DateTime> ActualEnd
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("actualend"); }
            set
            {
                this.OnPropertyChanging("ActualEnd");
                this.SetAttributeValue("actualend", value);
                this.OnPropertyChanged("ActualEnd");
            }
        }

        /// <summary>
        /// Enter the actual start date and time for the task. By default, it displays when the task was created.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("actualstart")]
        public System.Nullable<System.DateTime> ActualStart
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("actualstart"); }
            set
            {
                this.OnPropertyChanging("ActualStart");
                this.SetAttributeValue("actualstart", value);
                this.OnPropertyChanged("ActualStart");
            }
        }

        /// <summary>
        /// Type a category to identify the task type, such as lead gathering or customer follow up, to tie the task to a business group or function.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("category")]
        public string Category
        {
            get { return this.GetAttributeValue<string>("category"); }
            set
            {
                this.OnPropertyChanging("Category");
                this.SetAttributeValue("category", value);
                this.OnPropertyChanged("Category");
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
        /// Assigned Task Unique Id
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("crmtaskassigneduniqueid")]
        public System.Nullable<System.Guid> CrmTaskAssignedUniqueId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("crmtaskassigneduniqueid"); }
            set
            {
                this.OnPropertyChanging("CrmTaskAssignedUniqueId");
                this.SetAttributeValue("crmtaskassigneduniqueid", value);
                this.OnPropertyChanged("CrmTaskAssignedUniqueId");
            }
        }

        /// <summary>
        /// Type additional information to describe the task.
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
        /// Shows the conversion rate of the record's currency. The exchange rate is used to convert all money fields in the record from the local currency to the system's default currency.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("exchangerate")]
        public System.Nullable<decimal> ExchangeRate
        {
            get { return this.GetAttributeValue<System.Nullable<decimal>>("exchangerate"); }
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
        /// Information which specifies whether the task was billed as part of resolving a case.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isbilled")]
        public System.Nullable<bool> IsBilled
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("isbilled"); }
            set
            {
                this.OnPropertyChanging("IsBilled");
                this.SetAttributeValue("isbilled", value);
                this.OnPropertyChanged("IsBilled");
            }
        }

        /// <summary>
        /// Information regarding whether the activity is a regular activity type or event type.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isregularactivity")]
        public System.Nullable<bool> IsRegularActivity
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("isregularactivity"); }
        }

        /// <summary>
        /// Information which specifies if the task was created from a workflow rule.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isworkflowcreated")]
        public System.Nullable<bool> IsWorkflowCreated
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("isworkflowcreated"); }
            set
            {
                this.OnPropertyChanging("IsWorkflowCreated");
                this.SetAttributeValue("isworkflowcreated", value);
                this.OnPropertyChanged("IsWorkflowCreated");
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
        /// Date and time that the record was migrated.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("overriddencreatedon")]
        public System.Nullable<System.DateTime> OverriddenCreatedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("overriddencreatedon"); }
            set
            {
                this.OnPropertyChanging("OverriddenCreatedOn");
                this.SetAttributeValue("overriddencreatedon", value);
                this.OnPropertyChanged("OverriddenCreatedOn");
            }
        }

        /// <summary>
        /// Enter the user or team who is assigned to manage the record. This field is updated every time the record is assigned to a different user.
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
        /// Shows the record owner's business unit.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
        public Microsoft.Xrm.Sdk.EntityReference OwningBusinessUnit
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningbusinessunit"); }
        }

        /// <summary>
        /// Unique identifier of the team that owns the task.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
        public Microsoft.Xrm.Sdk.EntityReference OwningTeam
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningteam"); }
        }

        /// <summary>
        /// Unique identifier of the user that owns the task.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
        public Microsoft.Xrm.Sdk.EntityReference OwningUser
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owninguser"); }
        }

        /// <summary>
        /// Type the percentage complete value for the task to track tasks to completion.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("percentcomplete")]
        public System.Nullable<int> PercentComplete
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("percentcomplete"); }
            set
            {
                this.OnPropertyChanging("PercentComplete");
                this.SetAttributeValue("percentcomplete", value);
                this.OnPropertyChanged("PercentComplete");
            }
        }

        /// <summary>
        /// Select the priority so that preferred customers or critical issues are handled quickly.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("prioritycode")]
        public Microsoft.Xrm.Sdk.OptionSetValue PriorityCode
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("prioritycode"); }
            set
            {
                this.OnPropertyChanging("PriorityCode");
                this.SetAttributeValue("prioritycode", value);
                this.OnPropertyChanged("PriorityCode");
            }
        }

        /// <summary>
        /// Shows the ID of the process.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("processid")]
        public System.Nullable<System.Guid> ProcessId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("processid"); }
            set
            {
                this.OnPropertyChanging("ProcessId");
                this.SetAttributeValue("processid", value);
                this.OnPropertyChanged("ProcessId");
            }
        }

        /// <summary>
        /// Unique identifier of the object with which the task is associated.
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
        /// Scheduled duration of the task, specified in minutes.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("scheduleddurationminutes")]
        public System.Nullable<int> ScheduledDurationMinutes
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("scheduleddurationminutes"); }
        }

        /// <summary>
        /// Enter the expected due date and time.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("scheduledend")]
        public System.Nullable<System.DateTime> ScheduledEnd
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("scheduledend"); }
            set
            {
                this.OnPropertyChanging("ScheduledEnd");
                this.SetAttributeValue("scheduledend", value);
                this.OnPropertyChanged("ScheduledEnd");
            }
        }

        /// <summary>
        /// Enter the expected due date and time.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("scheduledstart")]
        public System.Nullable<System.DateTime> ScheduledStart
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("scheduledstart"); }
            set
            {
                this.OnPropertyChanging("ScheduledStart");
                this.SetAttributeValue("scheduledstart", value);
                this.OnPropertyChanged("ScheduledStart");
            }
        }

        /// <summary>
        /// Choose the service that is associated with this activity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("serviceid")]
        public Microsoft.Xrm.Sdk.EntityReference ServiceId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("serviceid"); }
            set
            {
                this.OnPropertyChanging("ServiceId");
                this.SetAttributeValue("serviceid", value);
                this.OnPropertyChanged("ServiceId");
            }
        }

        /// <summary>
        /// Shows the ID of the stage.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("stageid")]
        public System.Nullable<System.Guid> StageId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("stageid"); }
            set
            {
                this.OnPropertyChanging("StageId");
                this.SetAttributeValue("stageid", value);
                this.OnPropertyChanged("StageId");
            }
        }

        /// <summary>
        /// Shows whether the task is open, completed, or canceled. Completed and canceled tasks are read-only and can't be edited.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
        public System.Nullable<TaskState> StateCode
        {
            get
            {
                Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
                if ((optionSet != null))
                {
                    return ((TaskState) (System.Enum.ToObject(typeof(TaskState), optionSet.Value)));
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// Select the task's status.
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
        /// Type a subcategory to identify the task type and relate the activity to a specific product, sales region, business group, or other function.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("subcategory")]
        public string Subcategory
        {
            get { return this.GetAttributeValue<string>("subcategory"); }
            set
            {
                this.OnPropertyChanging("Subcategory");
                this.SetAttributeValue("subcategory", value);
                this.OnPropertyChanged("Subcategory");
            }
        }

        /// <summary>
        /// Type a short description about the objective or primary topic of the task.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("subject")]
        public string Subject
        {
            get { return this.GetAttributeValue<string>("subject"); }
            set
            {
                this.OnPropertyChanging("Subject");
                this.SetAttributeValue("subject", value);
                this.OnPropertyChanged("Subject");
            }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("subscriptionid")]
        public System.Nullable<System.Guid> SubscriptionId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("subscriptionid"); }
            set
            {
                this.OnPropertyChanging("SubscriptionId");
                this.SetAttributeValue("subscriptionid", value);
                this.OnPropertyChanged("SubscriptionId");
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
        /// A comma separated list of string values representing the unique identifiers of stages in a Business Process Flow Instance in the order that they occur.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("traversedpath")]
        public string TraversedPath
        {
            get { return this.GetAttributeValue<string>("traversedpath"); }
            set
            {
                this.OnPropertyChanging("TraversedPath");
                this.SetAttributeValue("traversedpath", value);
                this.OnPropertyChanged("TraversedPath");
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
        /// Version number of the task.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
        public System.Nullable<long> VersionNumber
        {
            get { return this.GetAttributeValue<System.Nullable<long>>("versionnumber"); }
        }

        /// <summary>
        /// 1:N task_activity_parties
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("task_activity_parties")]
        public System.Collections.Generic.IEnumerable<ActivityParty> task_activity_parties
        {
            get { return this.GetRelatedEntities<ActivityParty>("task_activity_parties", null); }
            set
            {
                this.OnPropertyChanging("task_activity_parties");
                this.SetRelatedEntities<ActivityParty>("task_activity_parties", null, value);
                this.OnPropertyChanged("task_activity_parties");
            }
        }

        /// <summary>
        /// 1:N Task_Annotation
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Task_Annotation")]
        public System.Collections.Generic.IEnumerable<Annotation> Task_Annotation
        {
            get { return this.GetRelatedEntities<Annotation>("Task_Annotation", null); }
            set
            {
                this.OnPropertyChanging("Task_Annotation");
                this.SetRelatedEntities<Annotation>("Task_Annotation", null, value);
                this.OnPropertyChanged("Task_Annotation");
            }
        }

        /// <summary>
        /// 1:N Task_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Task_AsyncOperations")]
        public System.Collections.Generic.IEnumerable<AsyncOperation> Task_AsyncOperations
        {
            get { return this.GetRelatedEntities<AsyncOperation>("Task_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("Task_AsyncOperations");
                this.SetRelatedEntities<AsyncOperation>("Task_AsyncOperations", null, value);
                this.OnPropertyChanged("Task_AsyncOperations");
            }
        }

        /// <summary>
        /// 1:N Task_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Task_BulkDeleteFailures")]
        public System.Collections.Generic.IEnumerable<BulkDeleteFailure> Task_BulkDeleteFailures
        {
            get { return this.GetRelatedEntities<BulkDeleteFailure>("Task_BulkDeleteFailures", null); }
            set
            {
                this.OnPropertyChanging("Task_BulkDeleteFailures");
                this.SetRelatedEntities<BulkDeleteFailure>("Task_BulkDeleteFailures", null, value);
                this.OnPropertyChanged("Task_BulkDeleteFailures");
            }
        }

        /// <summary>
        /// 1:N task_connections1
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("task_connections1")]
        public System.Collections.Generic.IEnumerable<Connection> task_connections1
        {
            get { return this.GetRelatedEntities<Connection>("task_connections1", null); }
            set
            {
                this.OnPropertyChanging("task_connections1");
                this.SetRelatedEntities<Connection>("task_connections1", null, value);
                this.OnPropertyChanged("task_connections1");
            }
        }

        /// <summary>
        /// 1:N task_connections2
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("task_connections2")]
        public System.Collections.Generic.IEnumerable<Connection> task_connections2
        {
            get { return this.GetRelatedEntities<Connection>("task_connections2", null); }
            set
            {
                this.OnPropertyChanging("task_connections2");
                this.SetRelatedEntities<Connection>("task_connections2", null, value);
                this.OnPropertyChanged("task_connections2");
            }
        }

        /// <summary>
        /// 1:N Task_DuplicateBaseRecord
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Task_DuplicateBaseRecord")]
        public System.Collections.Generic.IEnumerable<DuplicateRecord> Task_DuplicateBaseRecord
        {
            get { return this.GetRelatedEntities<DuplicateRecord>("Task_DuplicateBaseRecord", null); }
            set
            {
                this.OnPropertyChanging("Task_DuplicateBaseRecord");
                this.SetRelatedEntities<DuplicateRecord>("Task_DuplicateBaseRecord", null, value);
                this.OnPropertyChanged("Task_DuplicateBaseRecord");
            }
        }

        /// <summary>
        /// 1:N Task_DuplicateMatchingRecord
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Task_DuplicateMatchingRecord")]
        public System.Collections.Generic.IEnumerable<DuplicateRecord> Task_DuplicateMatchingRecord
        {
            get { return this.GetRelatedEntities<DuplicateRecord>("Task_DuplicateMatchingRecord", null); }
            set
            {
                this.OnPropertyChanging("Task_DuplicateMatchingRecord");
                this.SetRelatedEntities<DuplicateRecord>("Task_DuplicateMatchingRecord", null, value);
                this.OnPropertyChanged("Task_DuplicateMatchingRecord");
            }
        }

        /// <summary>
        /// 1:N task_PostFollows
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("task_PostFollows")]
        public System.Collections.Generic.IEnumerable<PostFollow> task_PostFollows
        {
            get { return this.GetRelatedEntities<PostFollow>("task_PostFollows", null); }
            set
            {
                this.OnPropertyChanging("task_PostFollows");
                this.SetRelatedEntities<PostFollow>("task_PostFollows", null, value);
                this.OnPropertyChanged("task_PostFollows");
            }
        }

        /// <summary>
        /// 1:N task_principalobjectattributeaccess
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("task_principalobjectattributeaccess")]
        public System.Collections.Generic.IEnumerable<PrincipalObjectAttributeAccess> task_principalobjectattributeaccess
        {
            get { return this.GetRelatedEntities<PrincipalObjectAttributeAccess>("task_principalobjectattributeaccess", null); }
            set
            {
                this.OnPropertyChanging("task_principalobjectattributeaccess");
                this.SetRelatedEntities<PrincipalObjectAttributeAccess>("task_principalobjectattributeaccess", null, value);
                this.OnPropertyChanged("task_principalobjectattributeaccess");
            }
        }

        /// <summary>
        /// 1:N Task_ProcessSessions
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Task_ProcessSessions")]
        public System.Collections.Generic.IEnumerable<ProcessSession> Task_ProcessSessions
        {
            get { return this.GetRelatedEntities<ProcessSession>("Task_ProcessSessions", null); }
            set
            {
                this.OnPropertyChanging("Task_ProcessSessions");
                this.SetRelatedEntities<ProcessSession>("Task_ProcessSessions", null, value);
                this.OnPropertyChanged("Task_ProcessSessions");
            }
        }

        /// <summary>
        /// 1:N Task_QueueItem
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Task_QueueItem")]
        public System.Collections.Generic.IEnumerable<QueueItem> Task_QueueItem
        {
            get { return this.GetRelatedEntities<QueueItem>("Task_QueueItem", null); }
            set
            {
                this.OnPropertyChanging("Task_QueueItem");
                this.SetRelatedEntities<QueueItem>("Task_QueueItem", null, value);
                this.OnPropertyChanged("Task_QueueItem");
            }
        }

        /// <summary>
        /// 1:N userentityinstancedata_task
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_task")]
        public System.Collections.Generic.IEnumerable<UserEntityInstanceData> userentityinstancedata_task
        {
            get { return this.GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_task", null); }
            set
            {
                this.OnPropertyChanging("userentityinstancedata_task");
                this.SetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_task", null, value);
                this.OnPropertyChanged("userentityinstancedata_task");
            }
        }

        /// <summary>
        /// N:1 Account_Tasks
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Account_Tasks")]
        public Account Account_Tasks
        {
            get { return this.GetRelatedEntity<Account>("Account_Tasks", null); }
            set
            {
                this.OnPropertyChanging("Account_Tasks");
                this.SetRelatedEntity<Account>("Account_Tasks", null, value);
                this.OnPropertyChanged("Account_Tasks");
            }
        }

        /// <summary>
        /// N:1 activity_pointer_task
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("activityid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("activity_pointer_task")]
        public ActivityPointer activity_pointer_task
        {
            get { return this.GetRelatedEntity<ActivityPointer>("activity_pointer_task", null); }
            set
            {
                this.OnPropertyChanging("activity_pointer_task");
                this.SetRelatedEntity<ActivityPointer>("activity_pointer_task", null, value);
                this.OnPropertyChanged("activity_pointer_task");
            }
        }

        /// <summary>
        /// N:1 business_unit_task_activities
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_task_activities")]
        public BusinessUnit business_unit_task_activities
        {
            get { return this.GetRelatedEntity<BusinessUnit>("business_unit_task_activities", null); }
        }

        /// <summary>
        /// N:1 Campaign_Tasks
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Campaign_Tasks")]
        public Campaign Campaign_Tasks
        {
            get { return this.GetRelatedEntity<Campaign>("Campaign_Tasks", null); }
            set
            {
                this.OnPropertyChanging("Campaign_Tasks");
                this.SetRelatedEntity<Campaign>("Campaign_Tasks", null, value);
                this.OnPropertyChanged("Campaign_Tasks");
            }
        }

        /// <summary>
        /// N:1 CampaignActivity_Tasks
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("CampaignActivity_Tasks")]
        public CampaignActivity CampaignActivity_Tasks
        {
            get { return this.GetRelatedEntity<CampaignActivity>("CampaignActivity_Tasks", null); }
            set
            {
                this.OnPropertyChanging("CampaignActivity_Tasks");
                this.SetRelatedEntity<CampaignActivity>("CampaignActivity_Tasks", null, value);
                this.OnPropertyChanged("CampaignActivity_Tasks");
            }
        }

        /// <summary>
        /// N:1 Contact_Tasks
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Contact_Tasks")]
        public Contact Contact_Tasks
        {
            get { return this.GetRelatedEntity<Contact>("Contact_Tasks", null); }
            set
            {
                this.OnPropertyChanging("Contact_Tasks");
                this.SetRelatedEntity<Contact>("Contact_Tasks", null, value);
                this.OnPropertyChanged("Contact_Tasks");
            }
        }

        /// <summary>
        /// N:1 Contract_Tasks
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Contract_Tasks")]
        public Contract Contract_Tasks
        {
            get { return this.GetRelatedEntity<Contract>("Contract_Tasks", null); }
            set
            {
                this.OnPropertyChanging("Contract_Tasks");
                this.SetRelatedEntity<Contract>("Contract_Tasks", null, value);
                this.OnPropertyChanged("Contract_Tasks");
            }
        }

        /// <summary>
        /// N:1 entitlement_Tasks
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("entitlement_Tasks")]
        public Entitlement entitlement_Tasks
        {
            get { return this.GetRelatedEntity<Entitlement>("entitlement_Tasks", null); }
            set
            {
                this.OnPropertyChanging("entitlement_Tasks");
                this.SetRelatedEntity<Entitlement>("entitlement_Tasks", null, value);
                this.OnPropertyChanged("entitlement_Tasks");
            }
        }

        /// <summary>
        /// N:1 entitlementtemplate_Tasks
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("entitlementtemplate_Tasks")]
        public EntitlementTemplate entitlementtemplate_Tasks
        {
            get { return this.GetRelatedEntity<EntitlementTemplate>("entitlementtemplate_Tasks", null); }
            set
            {
                this.OnPropertyChanging("entitlementtemplate_Tasks");
                this.SetRelatedEntity<EntitlementTemplate>("entitlementtemplate_Tasks", null, value);
                this.OnPropertyChanged("entitlementtemplate_Tasks");
            }
        }

        /// <summary>
        /// N:1 Incident_Tasks
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Incident_Tasks")]
        public Incident Incident_Tasks
        {
            get { return this.GetRelatedEntity<Incident>("Incident_Tasks", null); }
            set
            {
                this.OnPropertyChanging("Incident_Tasks");
                this.SetRelatedEntity<Incident>("Incident_Tasks", null, value);
                this.OnPropertyChanged("Incident_Tasks");
            }
        }

        /// <summary>
        /// N:1 Invoice_Tasks
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Invoice_Tasks")]
        public Invoice Invoice_Tasks
        {
            get { return this.GetRelatedEntity<Invoice>("Invoice_Tasks", null); }
            set
            {
                this.OnPropertyChanging("Invoice_Tasks");
                this.SetRelatedEntity<Invoice>("Invoice_Tasks", null, value);
                this.OnPropertyChanged("Invoice_Tasks");
            }
        }

        /// <summary>
        /// N:1 Lead_Tasks
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Lead_Tasks")]
        public Lead Lead_Tasks
        {
            get { return this.GetRelatedEntity<Lead>("Lead_Tasks", null); }
            set
            {
                this.OnPropertyChanging("Lead_Tasks");
                this.SetRelatedEntity<Lead>("Lead_Tasks", null, value);
                this.OnPropertyChanged("Lead_Tasks");
            }
        }

        /// <summary>
        /// N:1 lk_task_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_task_createdby")]
        public SystemUser lk_task_createdby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_task_createdby", null); }
        }

        /// <summary>
        /// N:1 lk_task_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_task_createdonbehalfby")]
        public SystemUser lk_task_createdonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_task_createdonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_task_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_task_modifiedby")]
        public SystemUser lk_task_modifiedby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_task_modifiedby", null); }
        }

        /// <summary>
        /// N:1 lk_task_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_task_modifiedonbehalfby")]
        public SystemUser lk_task_modifiedonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_task_modifiedonbehalfby", null); }
        }

        /// <summary>
        /// N:1 msdyn_postalbum_Tasks
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_postalbum_Tasks")]
        public msdyn_PostAlbum msdyn_postalbum_Tasks
        {
            get { return this.GetRelatedEntity<msdyn_PostAlbum>("msdyn_postalbum_Tasks", null); }
            set
            {
                this.OnPropertyChanging("msdyn_postalbum_Tasks");
                this.SetRelatedEntity<msdyn_PostAlbum>("msdyn_postalbum_Tasks", null, value);
                this.OnPropertyChanged("msdyn_postalbum_Tasks");
            }
        }

        /// <summary>
        /// N:1 Opportunity_Tasks
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Opportunity_Tasks")]
        public Opportunity Opportunity_Tasks
        {
            get { return this.GetRelatedEntity<Opportunity>("Opportunity_Tasks", null); }
            set
            {
                this.OnPropertyChanging("Opportunity_Tasks");
                this.SetRelatedEntity<Opportunity>("Opportunity_Tasks", null, value);
                this.OnPropertyChanged("Opportunity_Tasks");
            }
        }

        /// <summary>
        /// N:1 processstage_tasks
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("stageid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("processstage_tasks")]
        public ProcessStage processstage_tasks
        {
            get { return this.GetRelatedEntity<ProcessStage>("processstage_tasks", null); }
            set
            {
                this.OnPropertyChanging("processstage_tasks");
                this.SetRelatedEntity<ProcessStage>("processstage_tasks", null, value);
                this.OnPropertyChanged("processstage_tasks");
            }
        }

        /// <summary>
        /// N:1 Quote_Tasks
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Quote_Tasks")]
        public Quote Quote_Tasks
        {
            get { return this.GetRelatedEntity<Quote>("Quote_Tasks", null); }
            set
            {
                this.OnPropertyChanging("Quote_Tasks");
                this.SetRelatedEntity<Quote>("Quote_Tasks", null, value);
                this.OnPropertyChanged("Quote_Tasks");
            }
        }

        /// <summary>
        /// N:1 SalesOrder_Tasks
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SalesOrder_Tasks")]
        public SalesOrder SalesOrder_Tasks
        {
            get { return this.GetRelatedEntity<SalesOrder>("SalesOrder_Tasks", null); }
            set
            {
                this.OnPropertyChanging("SalesOrder_Tasks");
                this.SetRelatedEntity<SalesOrder>("SalesOrder_Tasks", null, value);
                this.OnPropertyChanged("SalesOrder_Tasks");
            }
        }

        /// <summary>
        /// N:1 service_tasks
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("serviceid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("service_tasks")]
        public Service service_tasks
        {
            get { return this.GetRelatedEntity<Service>("service_tasks", null); }
            set
            {
                this.OnPropertyChanging("service_tasks");
                this.SetRelatedEntity<Service>("service_tasks", null, value);
                this.OnPropertyChanged("service_tasks");
            }
        }

        /// <summary>
        /// N:1 team_task
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_task")]
        public Team team_task
        {
            get { return this.GetRelatedEntity<Team>("team_task", null); }
        }

        /// <summary>
        /// N:1 TransactionCurrency_Task
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("TransactionCurrency_Task")]
        public TransactionCurrency TransactionCurrency_Task
        {
            get { return this.GetRelatedEntity<TransactionCurrency>("TransactionCurrency_Task", null); }
            set
            {
                this.OnPropertyChanging("TransactionCurrency_Task");
                this.SetRelatedEntity<TransactionCurrency>("TransactionCurrency_Task", null, value);
                this.OnPropertyChanged("TransactionCurrency_Task");
            }
        }

        /// <summary>
        /// N:1 user_task
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_task")]
        public SystemUser user_task
        {
            get { return this.GetRelatedEntity<SystemUser>("user_task", null); }
        }
    }
}