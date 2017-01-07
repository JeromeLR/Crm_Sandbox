namespace __4_DAL_CRM
{
    /// <summary>
    /// System operation used to perform lengthy and asynchronous operations on large data sets, such as distributing a campaign activity or quick campaign.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("bulkoperation")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class BulkOperation : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public BulkOperation() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "bulkoperation";

        public const int EntityTypeCode = 4406;

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
        /// Unique identifier of the bulk operation.
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
        /// Actual duration of the bulk operation in minutes.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("actualdurationminutes")]
        public System.Nullable<int> ActualDurationMinutes
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("actualdurationminutes"); }
        }

        /// <summary>
        /// Shows the date and time when the quick campaign was completed or canceled.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("actualend")]
        public System.Nullable<System.DateTime> ActualEnd
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("actualend"); }
        }

        /// <summary>
        /// Shows the date and time when the activity was started or created.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("actualstart")]
        public System.Nullable<System.DateTime> ActualStart
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("actualstart"); }
        }

        /// <summary>
        /// Shows the number for the quick campaign record, used to identify the quick campaign.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("bulkoperationnumber")]
        public string BulkOperationNumber
        {
            get { return this.GetAttributeValue<string>("bulkoperationnumber"); }
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
        /// Unique identifier of the delegate user who created the bulk operation.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        /// Choose the activity to create that determines how target prospects or customers in this quick campaign are contacted.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdrecordtypecode")]
        public Microsoft.Xrm.Sdk.OptionSetValue CreatedRecordTypeCode
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("createdrecordtypecode"); }
        }

        /// <summary>
        /// Type additional information to describe the quick campaign, such as the products or services offered.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("description")]
        public string Description
        {
            get { return this.GetAttributeValue<string>("description"); }
        }

        /// <summary>
        /// Shows the error code that is used to troubleshoot issues in the quick campaign.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("errornumber")]
        public System.Nullable<int> ErrorNumber
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("errornumber"); }
        }

        /// <summary>
        /// Number of records which failed in the bulk operation.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("failurecount")]
        public System.Nullable<int> FailureCount
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("failurecount"); }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isbilled")]
        public System.Nullable<bool> IsBilled
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("isbilled"); }
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
        /// Specifies if the bulk operation was created from a workflow rule.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isworkflowcreated")]
        public System.Nullable<bool> IsWorkflowCreated
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("isworkflowcreated"); }
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
        /// Date and time when the bulk operation was last modified.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
        public System.Nullable<System.DateTime> ModifiedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who last modified the bulk operation.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        /// Select the type of bulk operation process, such as quick campaign or campaign activity distribution.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("operationtypecode")]
        public Microsoft.Xrm.Sdk.OptionSetValue OperationTypeCode
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("operationtypecode"); }
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
        /// Unique identifier of the business unit that owns the bulk operation.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
        public Microsoft.Xrm.Sdk.EntityReference OwningBusinessUnit
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningbusinessunit"); }
        }

        /// <summary>
        /// Unique identifier of the team who owns the bulk operation.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
        public Microsoft.Xrm.Sdk.EntityReference OwningTeam
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningteam"); }
        }

        /// <summary>
        /// Unique identifier of the user who owns the bulk operation.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
        public Microsoft.Xrm.Sdk.EntityReference OwningUser
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owninguser"); }
        }

        /// <summary>
        /// XML string that contains the parameters to the bulk operation.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("parameters")]
        public string Parameters
        {
            get { return this.GetAttributeValue<string>("parameters"); }
        }

        /// <summary>
        /// Choose the campaign from which the campaign activities were bulk-distributed.
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
        /// Scheduled duration of the bulk operation, specified in minutes.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("scheduleddurationminutes")]
        public System.Nullable<int> ScheduledDurationMinutes
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("scheduleddurationminutes"); }
        }

        /// <summary>
        /// Scheduled end date and time of the bulk operation.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("scheduledend")]
        public System.Nullable<System.DateTime> ScheduledEnd
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("scheduledend"); }
        }

        /// <summary>
        /// Scheduled start date and time of the bulk operation.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("scheduledstart")]
        public System.Nullable<System.DateTime> ScheduledStart
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("scheduledstart"); }
        }

        /// <summary>
        /// Unique identifier for an associated service.
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
        /// Shows whether the quick campaign is open, closed, or canceled. Closed or canceled quick campaigns are read-only and can't be edited.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
        public System.Nullable<BulkOperationState> StateCode
        {
            get
            {
                Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
                if ((optionSet != null))
                {
                    return ((BulkOperationState) (System.Enum.ToObject(typeof(BulkOperationState), optionSet.Value)));
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// Select the quick campaign's status.
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
        /// Type a short description about the objective or primary topic of the quick campaign.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("subject")]
        public string Subject
        {
            get { return this.GetAttributeValue<string>("subject"); }
        }

        /// <summary>
        /// Number of records which succeeded in the bulk operation.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("successcount")]
        public System.Nullable<int> SuccessCount
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("successcount"); }
        }

        /// <summary>
        /// Select the type of records targeted in the quick campaign to identify the target audience.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("targetedrecordtypecode")]
        public Microsoft.Xrm.Sdk.OptionSetValue TargetedRecordTypeCode
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("targetedrecordtypecode"); }
        }

        /// <summary>
        /// Number of members to target.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("targetmemberscount")]
        public System.Nullable<int> TargetMembersCount
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("targetmemberscount"); }
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
        /// Version number of the bulk operation.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
        public System.Nullable<long> VersionNumber
        {
            get { return this.GetAttributeValue<System.Nullable<long>>("versionnumber"); }
        }

        /// <summary>
        /// 1:N bulkoperation_activity_parties
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("bulkoperation_activity_parties")]
        public System.Collections.Generic.IEnumerable<ActivityParty> bulkoperation_activity_parties
        {
            get { return this.GetRelatedEntities<ActivityParty>("bulkoperation_activity_parties", null); }
            set
            {
                this.OnPropertyChanging("bulkoperation_activity_parties");
                this.SetRelatedEntities<ActivityParty>("bulkoperation_activity_parties", null, value);
                this.OnPropertyChanged("bulkoperation_activity_parties");
            }
        }

        /// <summary>
        /// 1:N BulkOperation_ActivityPointers
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("BulkOperation_ActivityPointers")]
        public System.Collections.Generic.IEnumerable<ActivityPointer> BulkOperation_ActivityPointers
        {
            get { return this.GetRelatedEntities<ActivityPointer>("BulkOperation_ActivityPointers", null); }
            set
            {
                this.OnPropertyChanging("BulkOperation_ActivityPointers");
                this.SetRelatedEntities<ActivityPointer>("BulkOperation_ActivityPointers", null, value);
                this.OnPropertyChanged("BulkOperation_ActivityPointers");
            }
        }

        /// <summary>
        /// 1:N BulkOperation_Appointment
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("BulkOperation_Appointment")]
        public System.Collections.Generic.IEnumerable<Appointment> BulkOperation_Appointment
        {
            get { return this.GetRelatedEntities<Appointment>("BulkOperation_Appointment", null); }
            set
            {
                this.OnPropertyChanging("BulkOperation_Appointment");
                this.SetRelatedEntities<Appointment>("BulkOperation_Appointment", null, value);
                this.OnPropertyChanged("BulkOperation_Appointment");
            }
        }

        /// <summary>
        /// 1:N BulkOperation_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("BulkOperation_AsyncOperations")]
        public System.Collections.Generic.IEnumerable<AsyncOperation> BulkOperation_AsyncOperations
        {
            get { return this.GetRelatedEntities<AsyncOperation>("BulkOperation_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("BulkOperation_AsyncOperations");
                this.SetRelatedEntities<AsyncOperation>("BulkOperation_AsyncOperations", null, value);
                this.OnPropertyChanged("BulkOperation_AsyncOperations");
            }
        }

        /// <summary>
        /// 1:N BulkOperation_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("BulkOperation_BulkDeleteFailures")]
        public System.Collections.Generic.IEnumerable<BulkDeleteFailure> BulkOperation_BulkDeleteFailures
        {
            get { return this.GetRelatedEntities<BulkDeleteFailure>("BulkOperation_BulkDeleteFailures", null); }
            set
            {
                this.OnPropertyChanging("BulkOperation_BulkDeleteFailures");
                this.SetRelatedEntities<BulkDeleteFailure>("BulkOperation_BulkDeleteFailures", null, value);
                this.OnPropertyChanged("BulkOperation_BulkDeleteFailures");
            }
        }

        /// <summary>
        /// 1:N BulkOperation_CampaignResponse
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("BulkOperation_CampaignResponse")]
        public System.Collections.Generic.IEnumerable<CampaignResponse> BulkOperation_CampaignResponse
        {
            get { return this.GetRelatedEntities<CampaignResponse>("BulkOperation_CampaignResponse", null); }
            set
            {
                this.OnPropertyChanging("BulkOperation_CampaignResponse");
                this.SetRelatedEntities<CampaignResponse>("BulkOperation_CampaignResponse", null, value);
                this.OnPropertyChanged("BulkOperation_CampaignResponse");
            }
        }

        /// <summary>
        /// 1:N BulkOperation_Email
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("BulkOperation_Email")]
        public System.Collections.Generic.IEnumerable<Email> BulkOperation_Email
        {
            get { return this.GetRelatedEntities<Email>("BulkOperation_Email", null); }
            set
            {
                this.OnPropertyChanging("BulkOperation_Email");
                this.SetRelatedEntities<Email>("BulkOperation_Email", null, value);
                this.OnPropertyChanged("BulkOperation_Email");
            }
        }

        /// <summary>
        /// 1:N BulkOperation_Faxes
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("BulkOperation_Faxes")]
        public System.Collections.Generic.IEnumerable<Fax> BulkOperation_Faxes
        {
            get { return this.GetRelatedEntities<Fax>("BulkOperation_Faxes", null); }
            set
            {
                this.OnPropertyChanging("BulkOperation_Faxes");
                this.SetRelatedEntities<Fax>("BulkOperation_Faxes", null, value);
                this.OnPropertyChanged("BulkOperation_Faxes");
            }
        }

        /// <summary>
        /// 1:N BulkOperation_Letter
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("BulkOperation_Letter")]
        public System.Collections.Generic.IEnumerable<Letter> BulkOperation_Letter
        {
            get { return this.GetRelatedEntities<Letter>("BulkOperation_Letter", null); }
            set
            {
                this.OnPropertyChanging("BulkOperation_Letter");
                this.SetRelatedEntities<Letter>("BulkOperation_Letter", null, value);
                this.OnPropertyChanged("BulkOperation_Letter");
            }
        }

        /// <summary>
        /// 1:N BulkOperation_logs
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("BulkOperation_logs")]
        public System.Collections.Generic.IEnumerable<BulkOperationLog> BulkOperation_logs
        {
            get { return this.GetRelatedEntities<BulkOperationLog>("BulkOperation_logs", null); }
            set
            {
                this.OnPropertyChanging("BulkOperation_logs");
                this.SetRelatedEntities<BulkOperationLog>("BulkOperation_logs", null, value);
                this.OnPropertyChanged("BulkOperation_logs");
            }
        }

        /// <summary>
        /// 1:N BulkOperation_Phonecall
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("BulkOperation_Phonecall")]
        public System.Collections.Generic.IEnumerable<PhoneCall> BulkOperation_Phonecall
        {
            get { return this.GetRelatedEntities<PhoneCall>("BulkOperation_Phonecall", null); }
            set
            {
                this.OnPropertyChanging("BulkOperation_Phonecall");
                this.SetRelatedEntities<PhoneCall>("BulkOperation_Phonecall", null, value);
                this.OnPropertyChanged("BulkOperation_Phonecall");
            }
        }

        /// <summary>
        /// 1:N BulkOperation_QueueItem
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("BulkOperation_QueueItem")]
        public System.Collections.Generic.IEnumerable<QueueItem> BulkOperation_QueueItem
        {
            get { return this.GetRelatedEntities<QueueItem>("BulkOperation_QueueItem", null); }
            set
            {
                this.OnPropertyChanging("BulkOperation_QueueItem");
                this.SetRelatedEntities<QueueItem>("BulkOperation_QueueItem", null, value);
                this.OnPropertyChanged("BulkOperation_QueueItem");
            }
        }

        /// <summary>
        /// 1:N BulkOperation_RecurringAppointmentMaster
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("BulkOperation_RecurringAppointmentMaster")]
        public System.Collections.Generic.IEnumerable<RecurringAppointmentMaster> BulkOperation_RecurringAppointmentMaster
        {
            get { return this.GetRelatedEntities<RecurringAppointmentMaster>("BulkOperation_RecurringAppointmentMaster", null); }
            set
            {
                this.OnPropertyChanging("BulkOperation_RecurringAppointmentMaster");
                this.SetRelatedEntities<RecurringAppointmentMaster>("BulkOperation_RecurringAppointmentMaster", null, value);
                this.OnPropertyChanged("BulkOperation_RecurringAppointmentMaster");
            }
        }

        /// <summary>
        /// 1:N BulkOperation_SocialActivity
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("BulkOperation_SocialActivity")]
        public System.Collections.Generic.IEnumerable<SocialActivity> BulkOperation_SocialActivity
        {
            get { return this.GetRelatedEntities<SocialActivity>("BulkOperation_SocialActivity", null); }
            set
            {
                this.OnPropertyChanging("BulkOperation_SocialActivity");
                this.SetRelatedEntities<SocialActivity>("BulkOperation_SocialActivity", null, value);
                this.OnPropertyChanged("BulkOperation_SocialActivity");
            }
        }

        /// <summary>
        /// 1:N userentityinstancedata_bulkoperation
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_bulkoperation")]
        public System.Collections.Generic.IEnumerable<UserEntityInstanceData> userentityinstancedata_bulkoperation
        {
            get { return this.GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_bulkoperation", null); }
            set
            {
                this.OnPropertyChanging("userentityinstancedata_bulkoperation");
                this.SetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_bulkoperation", null, value);
                this.OnPropertyChanged("userentityinstancedata_bulkoperation");
            }
        }

        /// <summary>
        /// N:1 activity_pointer_BulkOperation
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("activityid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("activity_pointer_BulkOperation")]
        public ActivityPointer activity_pointer_BulkOperation
        {
            get { return this.GetRelatedEntity<ActivityPointer>("activity_pointer_BulkOperation", null); }
            set
            {
                this.OnPropertyChanging("activity_pointer_BulkOperation");
                this.SetRelatedEntity<ActivityPointer>("activity_pointer_BulkOperation", null, value);
                this.OnPropertyChanged("activity_pointer_BulkOperation");
            }
        }

        /// <summary>
        /// N:1 business_unit_BulkOperation_activities
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_BulkOperation_activities")]
        public BusinessUnit business_unit_BulkOperation_activities
        {
            get { return this.GetRelatedEntity<BusinessUnit>("business_unit_BulkOperation_activities", null); }
        }

        /// <summary>
        /// N:1 CampaignActivity_BulkOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("CampaignActivity_BulkOperations")]
        public CampaignActivity CampaignActivity_BulkOperations
        {
            get { return this.GetRelatedEntity<CampaignActivity>("CampaignActivity_BulkOperations", null); }
            set
            {
                this.OnPropertyChanging("CampaignActivity_BulkOperations");
                this.SetRelatedEntity<CampaignActivity>("CampaignActivity_BulkOperations", null, value);
                this.OnPropertyChanged("CampaignActivity_BulkOperations");
            }
        }

        /// <summary>
        /// N:1 List_BulkOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("List_BulkOperations")]
        public List List_BulkOperations
        {
            get { return this.GetRelatedEntity<List>("List_BulkOperations", null); }
            set
            {
                this.OnPropertyChanging("List_BulkOperations");
                this.SetRelatedEntity<List>("List_BulkOperations", null, value);
                this.OnPropertyChanged("List_BulkOperations");
            }
        }

        /// <summary>
        /// N:1 lk_BulkOperation_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_BulkOperation_createdby")]
        public SystemUser lk_BulkOperation_createdby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_BulkOperation_createdby", null); }
        }

        /// <summary>
        /// N:1 lk_BulkOperation_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_BulkOperation_createdonbehalfby")]
        public SystemUser lk_BulkOperation_createdonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_BulkOperation_createdonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_BulkOperation_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_BulkOperation_modifiedby")]
        public SystemUser lk_BulkOperation_modifiedby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_BulkOperation_modifiedby", null); }
        }

        /// <summary>
        /// N:1 lk_BulkOperation_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_BulkOperation_modifiedonbehalfby")]
        public SystemUser lk_BulkOperation_modifiedonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_BulkOperation_modifiedonbehalfby", null); }
        }

        /// <summary>
        /// N:1 team_BulkOperation
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_BulkOperation")]
        public Team team_BulkOperation
        {
            get { return this.GetRelatedEntity<Team>("team_BulkOperation", null); }
        }

        /// <summary>
        /// N:1 user_BulkOperation
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_BulkOperation")]
        public SystemUser user_BulkOperation
        {
            get { return this.GetRelatedEntity<SystemUser>("user_BulkOperation", null); }
        }
    }
}