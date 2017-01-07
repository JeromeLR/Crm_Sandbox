using _4_DAL_CRM;

namespace __4_DAL_CRM
{
    /// <summary>
    /// Task performed, or to be performed, by a user. An activity is any action for which an entry can be made on a calendar.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("activitypointer")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class ActivityPointer : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public ActivityPointer() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "activitypointer";

        public const int EntityTypeCode = 4200;

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
        /// Unique identifier of the activity.
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
        /// Actual duration of the activity in minutes.
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
        /// Actual end time of the activity.
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
        /// Actual start time of the activity.
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
        /// All activity parties associated with this activity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("allparties")]
        public System.Collections.Generic.IEnumerable<ActivityParty> allparties
        {
            get
            {
                Microsoft.Xrm.Sdk.EntityCollection collection = this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityCollection>("allparties");
                if (((collection != null)
                     && (collection.Entities != null)))
                {
                    return System.Linq.Enumerable.Cast<ActivityParty>(collection.Entities);
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// Shows how contact about the social activity originated, such as from Twitter or Facebook. This field is read-only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("community")]
        public Microsoft.Xrm.Sdk.OptionSetValue Community
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("community"); }
            set
            {
                this.OnPropertyChanging("Community");
                this.SetAttributeValue("community", value);
                this.OnPropertyChanged("Community");
            }
        }

        /// <summary>
        /// Unique identifier of the user who created the activity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby"); }
        }

        /// <summary>
        /// Date and time when the activity was created.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
        public System.Nullable<System.DateTime> CreatedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who created the activitypointer.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        /// Date and time when the delivery of the activity was last attempted.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("deliverylastattemptedon")]
        public System.Nullable<System.DateTime> DeliveryLastAttemptedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("deliverylastattemptedon"); }
        }

        /// <summary>
        /// Priority of delivery of the activity to the email server.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("deliveryprioritycode")]
        public Microsoft.Xrm.Sdk.OptionSetValue DeliveryPriorityCode
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("deliveryprioritycode"); }
            set
            {
                this.OnPropertyChanging("DeliveryPriorityCode");
                this.SetAttributeValue("deliveryprioritycode", value);
                this.OnPropertyChanged("DeliveryPriorityCode");
            }
        }

        /// <summary>
        /// Description of the activity.
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
        /// Exchange rate for the currency associated with the activitypointer with respect to the base currency.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("exchangerate")]
        public System.Nullable<decimal> ExchangeRate
        {
            get { return this.GetAttributeValue<System.Nullable<decimal>>("exchangerate"); }
        }

        /// <summary>
        /// Type of instance of a recurring series.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("instancetypecode")]
        public Microsoft.Xrm.Sdk.OptionSetValue InstanceTypeCode
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("instancetypecode"); }
        }

        /// <summary>
        /// Information regarding whether the activity was billed as part of resolving a case.
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
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ismapiprivate")]
        public System.Nullable<bool> IsMapiPrivate
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("ismapiprivate"); }
            set
            {
                this.OnPropertyChanging("IsMapiPrivate");
                this.SetAttributeValue("ismapiprivate", value);
                this.OnPropertyChanged("IsMapiPrivate");
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
        /// Information regarding whether the activity was created from a workflow rule.
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
        /// Left the voice mail
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("leftvoicemail")]
        public System.Nullable<bool> LeftVoiceMail
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("leftvoicemail"); }
            set
            {
                this.OnPropertyChanging("LeftVoiceMail");
                this.SetAttributeValue("leftvoicemail", value);
                this.OnPropertyChanged("LeftVoiceMail");
            }
        }

        /// <summary>
        /// Unique identifier of user who last modified the activity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby"); }
        }

        /// <summary>
        /// Date and time when activity was last modified.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
        public System.Nullable<System.DateTime> ModifiedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who last modified the activitypointer.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        /// Unique identifier of the user or team who owns the activity.
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
        /// Unique identifier of the business unit that owns the activity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
        public Microsoft.Xrm.Sdk.EntityReference OwningBusinessUnit
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningbusinessunit"); }
        }

        /// <summary>
        /// Unique identifier of the team that owns the activity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
        public Microsoft.Xrm.Sdk.EntityReference OwningTeam
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningteam"); }
        }

        /// <summary>
        /// Unique identifier of the user that owns the activity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
        public Microsoft.Xrm.Sdk.EntityReference OwningUser
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owninguser"); }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("postponeactivityprocessinguntil")]
        public System.Nullable<System.DateTime> PostponeActivityProcessingUntil
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("postponeactivityprocessinguntil"); }
        }

        /// <summary>
        /// Priority of the activity.
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
        /// Unique identifier of the Process.
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
        /// Unique identifier of the object with which the activity is associated.
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
        /// Scheduled duration of the activity, specified in minutes.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("scheduleddurationminutes")]
        public System.Nullable<int> ScheduledDurationMinutes
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("scheduleddurationminutes"); }
            set
            {
                this.OnPropertyChanging("ScheduledDurationMinutes");
                this.SetAttributeValue("scheduleddurationminutes", value);
                this.OnPropertyChanged("ScheduledDurationMinutes");
            }
        }

        /// <summary>
        /// Scheduled end time of the activity.
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
        /// Scheduled start time of the activity.
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
        /// Unique identifier of the mailbox associated with the sender of the email message.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sendermailboxid")]
        public Microsoft.Xrm.Sdk.EntityReference SenderMailboxId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("sendermailboxid"); }
        }

        /// <summary>
        /// Date and time when the activity was sent.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("senton")]
        public System.Nullable<System.DateTime> SentOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("senton"); }
        }

        /// <summary>
        /// Uniqueidentifier specifying the id of recurring series of an instance.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("seriesid")]
        public System.Nullable<System.Guid> SeriesId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("seriesid"); }
        }

        /// <summary>
        /// Unique identifier of an associated service.
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
        /// Unique identifier of the Stage.
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
        /// Status of the activity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
        public System.Nullable<ActivityPointerState> StateCode
        {
            get
            {
                Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
                if ((optionSet != null))
                {
                    return ((ActivityPointerState) (System.Enum.ToObject(typeof(ActivityPointerState), optionSet.Value)));
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// Reason for the status of the activity.
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
        /// Subject associated with the activity.
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
        /// Unique identifier of the currency associated with the activitypointer.
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
        /// Version number of the activity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
        public System.Nullable<long> VersionNumber
        {
            get { return this.GetAttributeValue<System.Nullable<long>>("versionnumber"); }
        }

        /// <summary>
        /// 1:N activity_campaignresponse
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("activity_campaignresponse")]
        public System.Collections.Generic.IEnumerable<CampaignResponse> activity_campaignresponse
        {
            get { return this.GetRelatedEntities<CampaignResponse>("activity_campaignresponse", null); }
            set
            {
                this.OnPropertyChanging("activity_campaignresponse");
                this.SetRelatedEntities<CampaignResponse>("activity_campaignresponse", null, value);
                this.OnPropertyChanged("activity_campaignresponse");
            }
        }

        /// <summary>
        /// 1:N activity_pointer_activity_mime_attachment
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("activity_pointer_activity_mime_attachment")]
        public System.Collections.Generic.IEnumerable<ActivityMimeAttachment> activity_pointer_activity_mime_attachment
        {
            get { return this.GetRelatedEntities<ActivityMimeAttachment>("activity_pointer_activity_mime_attachment", null); }
            set
            {
                this.OnPropertyChanging("activity_pointer_activity_mime_attachment");
                this.SetRelatedEntities<ActivityMimeAttachment>("activity_pointer_activity_mime_attachment", null, value);
                this.OnPropertyChanged("activity_pointer_activity_mime_attachment");
            }
        }

        /// <summary>
        /// 1:N activity_pointer_appointment
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("activity_pointer_appointment")]
        public System.Collections.Generic.IEnumerable<Appointment> activity_pointer_appointment
        {
            get { return this.GetRelatedEntities<Appointment>("activity_pointer_appointment", null); }
            set
            {
                this.OnPropertyChanging("activity_pointer_appointment");
                this.SetRelatedEntities<Appointment>("activity_pointer_appointment", null, value);
                this.OnPropertyChanged("activity_pointer_appointment");
            }
        }

        /// <summary>
        /// 1:N activity_pointer_BulkOperation
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("activity_pointer_BulkOperation")]
        public System.Collections.Generic.IEnumerable<BulkOperation> activity_pointer_BulkOperation
        {
            get { return this.GetRelatedEntities<BulkOperation>("activity_pointer_BulkOperation", null); }
            set
            {
                this.OnPropertyChanging("activity_pointer_BulkOperation");
                this.SetRelatedEntities<BulkOperation>("activity_pointer_BulkOperation", null, value);
                this.OnPropertyChanged("activity_pointer_BulkOperation");
            }
        }

        /// <summary>
        /// 1:N activity_pointer_BulkOperation_logs
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("activity_pointer_BulkOperation_logs")]
        public System.Collections.Generic.IEnumerable<BulkOperationLog> activity_pointer_BulkOperation_logs
        {
            get { return this.GetRelatedEntities<BulkOperationLog>("activity_pointer_BulkOperation_logs", null); }
            set
            {
                this.OnPropertyChanging("activity_pointer_BulkOperation_logs");
                this.SetRelatedEntities<BulkOperationLog>("activity_pointer_BulkOperation_logs", null, value);
                this.OnPropertyChanged("activity_pointer_BulkOperation_logs");
            }
        }

        /// <summary>
        /// 1:N activity_pointer_campaignactivity
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("activity_pointer_campaignactivity")]
        public System.Collections.Generic.IEnumerable<CampaignActivity> activity_pointer_campaignactivity
        {
            get { return this.GetRelatedEntities<CampaignActivity>("activity_pointer_campaignactivity", null); }
            set
            {
                this.OnPropertyChanging("activity_pointer_campaignactivity");
                this.SetRelatedEntities<CampaignActivity>("activity_pointer_campaignactivity", null, value);
                this.OnPropertyChanged("activity_pointer_campaignactivity");
            }
        }

        /// <summary>
        /// 1:N activity_pointer_campaignresponse
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("activity_pointer_campaignresponse")]
        public System.Collections.Generic.IEnumerable<CampaignResponse> activity_pointer_campaignresponse
        {
            get { return this.GetRelatedEntities<CampaignResponse>("activity_pointer_campaignresponse", null); }
            set
            {
                this.OnPropertyChanging("activity_pointer_campaignresponse");
                this.SetRelatedEntities<CampaignResponse>("activity_pointer_campaignresponse", null, value);
                this.OnPropertyChanged("activity_pointer_campaignresponse");
            }
        }

        /// <summary>
        /// 1:N activity_pointer_email
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("activity_pointer_email")]
        public System.Collections.Generic.IEnumerable<Email> activity_pointer_email
        {
            get { return this.GetRelatedEntities<Email>("activity_pointer_email", null); }
            set
            {
                this.OnPropertyChanging("activity_pointer_email");
                this.SetRelatedEntities<Email>("activity_pointer_email", null, value);
                this.OnPropertyChanged("activity_pointer_email");
            }
        }

        /// <summary>
        /// 1:N activity_pointer_fax
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("activity_pointer_fax")]
        public System.Collections.Generic.IEnumerable<Fax> activity_pointer_fax
        {
            get { return this.GetRelatedEntities<Fax>("activity_pointer_fax", null); }
            set
            {
                this.OnPropertyChanging("activity_pointer_fax");
                this.SetRelatedEntities<Fax>("activity_pointer_fax", null, value);
                this.OnPropertyChanged("activity_pointer_fax");
            }
        }

        /// <summary>
        /// 1:N activity_pointer_incident_resolution
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("activity_pointer_incident_resolution")]
        public System.Collections.Generic.IEnumerable<IncidentResolution> activity_pointer_incident_resolution
        {
            get { return this.GetRelatedEntities<IncidentResolution>("activity_pointer_incident_resolution", null); }
            set
            {
                this.OnPropertyChanging("activity_pointer_incident_resolution");
                this.SetRelatedEntities<IncidentResolution>("activity_pointer_incident_resolution", null, value);
                this.OnPropertyChanged("activity_pointer_incident_resolution");
            }
        }

        /// <summary>
        /// 1:N activity_pointer_letter
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("activity_pointer_letter")]
        public System.Collections.Generic.IEnumerable<Letter> activity_pointer_letter
        {
            get { return this.GetRelatedEntities<Letter>("activity_pointer_letter", null); }
            set
            {
                this.OnPropertyChanging("activity_pointer_letter");
                this.SetRelatedEntities<Letter>("activity_pointer_letter", null, value);
                this.OnPropertyChanged("activity_pointer_letter");
            }
        }

        /// <summary>
        /// 1:N activity_pointer_opportunity_close
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("activity_pointer_opportunity_close")]
        public System.Collections.Generic.IEnumerable<OpportunityClose> activity_pointer_opportunity_close
        {
            get { return this.GetRelatedEntities<OpportunityClose>("activity_pointer_opportunity_close", null); }
            set
            {
                this.OnPropertyChanging("activity_pointer_opportunity_close");
                this.SetRelatedEntities<OpportunityClose>("activity_pointer_opportunity_close", null, value);
                this.OnPropertyChanged("activity_pointer_opportunity_close");
            }
        }

        /// <summary>
        /// 1:N activity_pointer_order_close
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("activity_pointer_order_close")]
        public System.Collections.Generic.IEnumerable<OrderClose> activity_pointer_order_close
        {
            get { return this.GetRelatedEntities<OrderClose>("activity_pointer_order_close", null); }
            set
            {
                this.OnPropertyChanging("activity_pointer_order_close");
                this.SetRelatedEntities<OrderClose>("activity_pointer_order_close", null, value);
                this.OnPropertyChanged("activity_pointer_order_close");
            }
        }

        /// <summary>
        /// 1:N activity_pointer_phonecall
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("activity_pointer_phonecall")]
        public System.Collections.Generic.IEnumerable<PhoneCall> activity_pointer_phonecall
        {
            get { return this.GetRelatedEntities<PhoneCall>("activity_pointer_phonecall", null); }
            set
            {
                this.OnPropertyChanging("activity_pointer_phonecall");
                this.SetRelatedEntities<PhoneCall>("activity_pointer_phonecall", null, value);
                this.OnPropertyChanged("activity_pointer_phonecall");
            }
        }

        /// <summary>
        /// 1:N activity_pointer_quote_close
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("activity_pointer_quote_close")]
        public System.Collections.Generic.IEnumerable<QuoteClose> activity_pointer_quote_close
        {
            get { return this.GetRelatedEntities<QuoteClose>("activity_pointer_quote_close", null); }
            set
            {
                this.OnPropertyChanging("activity_pointer_quote_close");
                this.SetRelatedEntities<QuoteClose>("activity_pointer_quote_close", null, value);
                this.OnPropertyChanged("activity_pointer_quote_close");
            }
        }

        /// <summary>
        /// 1:N activity_pointer_recurrencerule
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("activity_pointer_recurrencerule")]
        public System.Collections.Generic.IEnumerable<RecurrenceRule> activity_pointer_recurrencerule
        {
            get { return this.GetRelatedEntities<RecurrenceRule>("activity_pointer_recurrencerule", null); }
            set
            {
                this.OnPropertyChanging("activity_pointer_recurrencerule");
                this.SetRelatedEntities<RecurrenceRule>("activity_pointer_recurrencerule", null, value);
                this.OnPropertyChanged("activity_pointer_recurrencerule");
            }
        }

        /// <summary>
        /// 1:N activity_pointer_recurringappointmentmaster
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("activity_pointer_recurringappointmentmaster")]
        public System.Collections.Generic.IEnumerable<RecurringAppointmentMaster> activity_pointer_recurringappointmentmaster
        {
            get { return this.GetRelatedEntities<RecurringAppointmentMaster>("activity_pointer_recurringappointmentmaster", null); }
            set
            {
                this.OnPropertyChanging("activity_pointer_recurringappointmentmaster");
                this.SetRelatedEntities<RecurringAppointmentMaster>("activity_pointer_recurringappointmentmaster", null, value);
                this.OnPropertyChanged("activity_pointer_recurringappointmentmaster");
            }
        }

        /// <summary>
        /// 1:N activity_pointer_service_appointment
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("activity_pointer_service_appointment")]
        public System.Collections.Generic.IEnumerable<ServiceAppointment> activity_pointer_service_appointment
        {
            get { return this.GetRelatedEntities<ServiceAppointment>("activity_pointer_service_appointment", null); }
            set
            {
                this.OnPropertyChanging("activity_pointer_service_appointment");
                this.SetRelatedEntities<ServiceAppointment>("activity_pointer_service_appointment", null, value);
                this.OnPropertyChanged("activity_pointer_service_appointment");
            }
        }

        /// <summary>
        /// 1:N activity_pointer_socialactivity
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("activity_pointer_socialactivity")]
        public System.Collections.Generic.IEnumerable<SocialActivity> activity_pointer_socialactivity
        {
            get { return this.GetRelatedEntities<SocialActivity>("activity_pointer_socialactivity", null); }
            set
            {
                this.OnPropertyChanging("activity_pointer_socialactivity");
                this.SetRelatedEntities<SocialActivity>("activity_pointer_socialactivity", null, value);
                this.OnPropertyChanged("activity_pointer_socialactivity");
            }
        }

        /// <summary>
        /// 1:N activity_pointer_task
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("activity_pointer_task")]
        public System.Collections.Generic.IEnumerable<Task> activity_pointer_task
        {
            get { return this.GetRelatedEntities<Task>("activity_pointer_task", null); }
            set
            {
                this.OnPropertyChanging("activity_pointer_task");
                this.SetRelatedEntities<Task>("activity_pointer_task", null, value);
                this.OnPropertyChanged("activity_pointer_task");
            }
        }

        /// <summary>
        /// 1:N activitypointer_activity_parties
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("activitypointer_activity_parties")]
        public System.Collections.Generic.IEnumerable<ActivityParty> activitypointer_activity_parties
        {
            get { return this.GetRelatedEntities<ActivityParty>("activitypointer_activity_parties", null); }
            set
            {
                this.OnPropertyChanging("activitypointer_activity_parties");
                this.SetRelatedEntities<ActivityParty>("activitypointer_activity_parties", null, value);
                this.OnPropertyChanged("activitypointer_activity_parties");
            }
        }

        /// <summary>
        /// 1:N ActivityPointer_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ActivityPointer_AsyncOperations")]
        public System.Collections.Generic.IEnumerable<AsyncOperation> ActivityPointer_AsyncOperations
        {
            get { return this.GetRelatedEntities<AsyncOperation>("ActivityPointer_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("ActivityPointer_AsyncOperations");
                this.SetRelatedEntities<AsyncOperation>("ActivityPointer_AsyncOperations", null, value);
                this.OnPropertyChanged("ActivityPointer_AsyncOperations");
            }
        }

        /// <summary>
        /// 1:N ActivityPointer_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ActivityPointer_BulkDeleteFailures")]
        public System.Collections.Generic.IEnumerable<BulkDeleteFailure> ActivityPointer_BulkDeleteFailures
        {
            get { return this.GetRelatedEntities<BulkDeleteFailure>("ActivityPointer_BulkDeleteFailures", null); }
            set
            {
                this.OnPropertyChanging("ActivityPointer_BulkDeleteFailures");
                this.SetRelatedEntities<BulkDeleteFailure>("ActivityPointer_BulkDeleteFailures", null, value);
                this.OnPropertyChanged("ActivityPointer_BulkDeleteFailures");
            }
        }

        /// <summary>
        /// 1:N ActivityPointer_CampaignActivityItems
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ActivityPointer_CampaignActivityItems")]
        public System.Collections.Generic.IEnumerable<CampaignActivityItem> ActivityPointer_CampaignActivityItems
        {
            get { return this.GetRelatedEntities<CampaignActivityItem>("ActivityPointer_CampaignActivityItems", null); }
            set
            {
                this.OnPropertyChanging("ActivityPointer_CampaignActivityItems");
                this.SetRelatedEntities<CampaignActivityItem>("ActivityPointer_CampaignActivityItems", null, value);
                this.OnPropertyChanged("ActivityPointer_CampaignActivityItems");
            }
        }

        /// <summary>
        /// 1:N activitypointer_connections1
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("activitypointer_connections1")]
        public System.Collections.Generic.IEnumerable<Connection> activitypointer_connections1
        {
            get { return this.GetRelatedEntities<Connection>("activitypointer_connections1", null); }
            set
            {
                this.OnPropertyChanging("activitypointer_connections1");
                this.SetRelatedEntities<Connection>("activitypointer_connections1", null, value);
                this.OnPropertyChanged("activitypointer_connections1");
            }
        }

        /// <summary>
        /// 1:N activitypointer_connections2
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("activitypointer_connections2")]
        public System.Collections.Generic.IEnumerable<Connection> activitypointer_connections2
        {
            get { return this.GetRelatedEntities<Connection>("activitypointer_connections2", null); }
            set
            {
                this.OnPropertyChanging("activitypointer_connections2");
                this.SetRelatedEntities<Connection>("activitypointer_connections2", null, value);
                this.OnPropertyChanged("activitypointer_connections2");
            }
        }

        /// <summary>
        /// 1:N ActivityPointer_QueueItem
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ActivityPointer_QueueItem")]
        public System.Collections.Generic.IEnumerable<QueueItem> ActivityPointer_QueueItem
        {
            get { return this.GetRelatedEntities<QueueItem>("ActivityPointer_QueueItem", null); }
            set
            {
                this.OnPropertyChanging("ActivityPointer_QueueItem");
                this.SetRelatedEntities<QueueItem>("ActivityPointer_QueueItem", null, value);
                this.OnPropertyChanged("ActivityPointer_QueueItem");
            }
        }

        /// <summary>
        /// 1:N CreatedActivity_BulkOperationLogs
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("CreatedActivity_BulkOperationLogs")]
        public System.Collections.Generic.IEnumerable<BulkOperationLog> CreatedActivity_BulkOperationLogs
        {
            get { return this.GetRelatedEntities<BulkOperationLog>("CreatedActivity_BulkOperationLogs", null); }
            set
            {
                this.OnPropertyChanging("CreatedActivity_BulkOperationLogs");
                this.SetRelatedEntities<BulkOperationLog>("CreatedActivity_BulkOperationLogs", null, value);
                this.OnPropertyChanged("CreatedActivity_BulkOperationLogs");
            }
        }

        /// <summary>
        /// N:1 Account_ActivityPointers
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Account_ActivityPointers")]
        public Account Account_ActivityPointers
        {
            get { return this.GetRelatedEntity<Account>("Account_ActivityPointers", null); }
            set
            {
                this.OnPropertyChanging("Account_ActivityPointers");
                this.SetRelatedEntity<Account>("Account_ActivityPointers", null, value);
                this.OnPropertyChanged("Account_ActivityPointers");
            }
        }

        /// <summary>
        /// N:1 activitypointer_sendermailboxid_mailbox
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sendermailboxid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("activitypointer_sendermailboxid_mailbox")]
        public Mailbox activitypointer_sendermailboxid_mailbox
        {
            get { return this.GetRelatedEntity<Mailbox>("activitypointer_sendermailboxid_mailbox", null); }
        }

        /// <summary>
        /// N:1 BulkOperation_ActivityPointers
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("BulkOperation_ActivityPointers")]
        public BulkOperation BulkOperation_ActivityPointers
        {
            get { return this.GetRelatedEntity<BulkOperation>("BulkOperation_ActivityPointers", null); }
            set
            {
                this.OnPropertyChanging("BulkOperation_ActivityPointers");
                this.SetRelatedEntity<BulkOperation>("BulkOperation_ActivityPointers", null, value);
                this.OnPropertyChanged("BulkOperation_ActivityPointers");
            }
        }

        /// <summary>
        /// N:1 business_unit_activitypointer
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_activitypointer")]
        public BusinessUnit business_unit_activitypointer
        {
            get { return this.GetRelatedEntity<BusinessUnit>("business_unit_activitypointer", null); }
        }

        /// <summary>
        /// N:1 Campaign_ActivityPointers
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Campaign_ActivityPointers")]
        public Campaign Campaign_ActivityPointers
        {
            get { return this.GetRelatedEntity<Campaign>("Campaign_ActivityPointers", null); }
            set
            {
                this.OnPropertyChanging("Campaign_ActivityPointers");
                this.SetRelatedEntity<Campaign>("Campaign_ActivityPointers", null, value);
                this.OnPropertyChanged("Campaign_ActivityPointers");
            }
        }

        /// <summary>
        /// N:1 CampaignActivity_ActivityPointers
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("CampaignActivity_ActivityPointers")]
        public CampaignActivity CampaignActivity_ActivityPointers
        {
            get { return this.GetRelatedEntity<CampaignActivity>("CampaignActivity_ActivityPointers", null); }
            set
            {
                this.OnPropertyChanging("CampaignActivity_ActivityPointers");
                this.SetRelatedEntity<CampaignActivity>("CampaignActivity_ActivityPointers", null, value);
                this.OnPropertyChanged("CampaignActivity_ActivityPointers");
            }
        }

        /// <summary>
        /// N:1 Contact_ActivityPointers
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Contact_ActivityPointers")]
        public Contact Contact_ActivityPointers
        {
            get { return this.GetRelatedEntity<Contact>("Contact_ActivityPointers", null); }
            set
            {
                this.OnPropertyChanging("Contact_ActivityPointers");
                this.SetRelatedEntity<Contact>("Contact_ActivityPointers", null, value);
                this.OnPropertyChanged("Contact_ActivityPointers");
            }
        }

        /// <summary>
        /// N:1 Contract_ActivityPointers
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Contract_ActivityPointers")]
        public Contract Contract_ActivityPointers
        {
            get { return this.GetRelatedEntity<Contract>("Contract_ActivityPointers", null); }
            set
            {
                this.OnPropertyChanging("Contract_ActivityPointers");
                this.SetRelatedEntity<Contract>("Contract_ActivityPointers", null, value);
                this.OnPropertyChanged("Contract_ActivityPointers");
            }
        }

        /// <summary>
        /// N:1 entitlement_ActivityPointers
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("entitlement_ActivityPointers")]
        public Entitlement entitlement_ActivityPointers
        {
            get { return this.GetRelatedEntity<Entitlement>("entitlement_ActivityPointers", null); }
            set
            {
                this.OnPropertyChanging("entitlement_ActivityPointers");
                this.SetRelatedEntity<Entitlement>("entitlement_ActivityPointers", null, value);
                this.OnPropertyChanged("entitlement_ActivityPointers");
            }
        }

        /// <summary>
        /// N:1 entitlementtemplate_ActivityPointers
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("entitlementtemplate_ActivityPointers")]
        public EntitlementTemplate entitlementtemplate_ActivityPointers
        {
            get { return this.GetRelatedEntity<EntitlementTemplate>("entitlementtemplate_ActivityPointers", null); }
            set
            {
                this.OnPropertyChanging("entitlementtemplate_ActivityPointers");
                this.SetRelatedEntity<EntitlementTemplate>("entitlementtemplate_ActivityPointers", null, value);
                this.OnPropertyChanged("entitlementtemplate_ActivityPointers");
            }
        }

        /// <summary>
        /// N:1 Incident_ActivityPointers
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Incident_ActivityPointers")]
        public Incident Incident_ActivityPointers
        {
            get { return this.GetRelatedEntity<Incident>("Incident_ActivityPointers", null); }
            set
            {
                this.OnPropertyChanging("Incident_ActivityPointers");
                this.SetRelatedEntity<Incident>("Incident_ActivityPointers", null, value);
                this.OnPropertyChanged("Incident_ActivityPointers");
            }
        }

        /// <summary>
        /// N:1 Invoice_ActivityPointers
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Invoice_ActivityPointers")]
        public Invoice Invoice_ActivityPointers
        {
            get { return this.GetRelatedEntity<Invoice>("Invoice_ActivityPointers", null); }
            set
            {
                this.OnPropertyChanging("Invoice_ActivityPointers");
                this.SetRelatedEntity<Invoice>("Invoice_ActivityPointers", null, value);
                this.OnPropertyChanged("Invoice_ActivityPointers");
            }
        }

        /// <summary>
        /// N:1 Lead_ActivityPointers
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Lead_ActivityPointers")]
        public Lead Lead_ActivityPointers
        {
            get { return this.GetRelatedEntity<Lead>("Lead_ActivityPointers", null); }
            set
            {
                this.OnPropertyChanging("Lead_ActivityPointers");
                this.SetRelatedEntity<Lead>("Lead_ActivityPointers", null, value);
                this.OnPropertyChanged("Lead_ActivityPointers");
            }
        }

        /// <summary>
        /// N:1 lk_activitypointer_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_activitypointer_createdby")]
        public SystemUser lk_activitypointer_createdby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_activitypointer_createdby", null); }
        }

        /// <summary>
        /// N:1 lk_activitypointer_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_activitypointer_createdonbehalfby")]
        public SystemUser lk_activitypointer_createdonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_activitypointer_createdonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_activitypointer_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_activitypointer_modifiedby")]
        public SystemUser lk_activitypointer_modifiedby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_activitypointer_modifiedby", null); }
        }

        /// <summary>
        /// N:1 lk_activitypointer_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_activitypointer_modifiedonbehalfby")]
        public SystemUser lk_activitypointer_modifiedonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_activitypointer_modifiedonbehalfby", null); }
        }

        /// <summary>
        /// N:1 msdyn_postalbum_ActivityPointers
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_postalbum_ActivityPointers")]
        public msdyn_PostAlbum msdyn_postalbum_ActivityPointers
        {
            get { return this.GetRelatedEntity<msdyn_PostAlbum>("msdyn_postalbum_ActivityPointers", null); }
            set
            {
                this.OnPropertyChanging("msdyn_postalbum_ActivityPointers");
                this.SetRelatedEntity<msdyn_PostAlbum>("msdyn_postalbum_ActivityPointers", null, value);
                this.OnPropertyChanged("msdyn_postalbum_ActivityPointers");
            }
        }

        /// <summary>
        /// N:1 Opportunity_ActivityPointers
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Opportunity_ActivityPointers")]
        public Opportunity Opportunity_ActivityPointers
        {
            get { return this.GetRelatedEntity<Opportunity>("Opportunity_ActivityPointers", null); }
            set
            {
                this.OnPropertyChanging("Opportunity_ActivityPointers");
                this.SetRelatedEntity<Opportunity>("Opportunity_ActivityPointers", null, value);
                this.OnPropertyChanged("Opportunity_ActivityPointers");
            }
        }

        /// <summary>
        /// N:1 Quote_ActivityPointers
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Quote_ActivityPointers")]
        public Quote Quote_ActivityPointers
        {
            get { return this.GetRelatedEntity<Quote>("Quote_ActivityPointers", null); }
            set
            {
                this.OnPropertyChanging("Quote_ActivityPointers");
                this.SetRelatedEntity<Quote>("Quote_ActivityPointers", null, value);
                this.OnPropertyChanged("Quote_ActivityPointers");
            }
        }

        /// <summary>
        /// N:1 SalesOrder_ActivityPointers
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SalesOrder_ActivityPointers")]
        public SalesOrder SalesOrder_ActivityPointers
        {
            get { return this.GetRelatedEntity<SalesOrder>("SalesOrder_ActivityPointers", null); }
            set
            {
                this.OnPropertyChanging("SalesOrder_ActivityPointers");
                this.SetRelatedEntity<SalesOrder>("SalesOrder_ActivityPointers", null, value);
                this.OnPropertyChanged("SalesOrder_ActivityPointers");
            }
        }

        /// <summary>
        /// N:1 service_activity_pointers
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("serviceid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("service_activity_pointers")]
        public Service service_activity_pointers
        {
            get { return this.GetRelatedEntity<Service>("service_activity_pointers", null); }
            set
            {
                this.OnPropertyChanging("service_activity_pointers");
                this.SetRelatedEntity<Service>("service_activity_pointers", null, value);
                this.OnPropertyChanged("service_activity_pointers");
            }
        }

        /// <summary>
        /// N:1 team_activity
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_activity")]
        public Team team_activity
        {
            get { return this.GetRelatedEntity<Team>("team_activity", null); }
        }

        /// <summary>
        /// N:1 TransactionCurrency_ActivityPointer
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("TransactionCurrency_ActivityPointer")]
        public TransactionCurrency TransactionCurrency_ActivityPointer
        {
            get { return this.GetRelatedEntity<TransactionCurrency>("TransactionCurrency_ActivityPointer", null); }
            set
            {
                this.OnPropertyChanging("TransactionCurrency_ActivityPointer");
                this.SetRelatedEntity<TransactionCurrency>("TransactionCurrency_ActivityPointer", null, value);
                this.OnPropertyChanged("TransactionCurrency_ActivityPointer");
            }
        }

        /// <summary>
        /// N:1 user_activity
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_activity")]
        public SystemUser user_activity
        {
            get { return this.GetRelatedEntity<SystemUser>("user_activity", null); }
        }
    }
}