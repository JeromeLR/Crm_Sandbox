using _4_DAL_CRM;

namespace __4_DAL_CRM
{
    /// <summary>
    /// Activity to track a telephone call.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("phonecall")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class PhoneCall : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public PhoneCall() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "phonecall";

        public const int EntityTypeCode = 4210;

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
        /// Unique identifier of the phone call activity.
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
        /// Shows the type of activity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("activitytypecode")]
        public string ActivityTypeCode
        {
            get { return this.GetAttributeValue<string>("activitytypecode"); }
        }

        /// <summary>
        /// Type the number of minutes spent on the phone call. The duration is used in reporting.
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
        /// Enter the actual end date and time of the phone call. By default, it displays the date and time when the activity was completed or canceled, but can be edited to capture the actual duration of the phone call.
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
        /// Enter the actual start date and time for the phone call. By default, it displays the date and time when the activity was created, but can be edited to capture the actual duration of the phone call.
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
        /// Type a category to identify the phone call type, such as lead gathering or customer follow-up, to tie the phone call to a business group or function.
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
        /// Type additional information to describe the phone call, such as the primary message or the products and services discussed.
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
        /// Select the direction of the phone call as incoming or outbound.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("directioncode")]
        public System.Nullable<bool> DirectionCode
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("directioncode"); }
            set
            {
                this.OnPropertyChanging("DirectionCode");
                this.SetAttributeValue("directioncode", value);
                this.OnPropertyChanged("DirectionCode");
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
        /// Enter the account, contact, lead, or user who made the phone call.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("from")]
        public System.Collections.Generic.IEnumerable<ActivityParty> From
        {
            get
            {
                Microsoft.Xrm.Sdk.EntityCollection collection = this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityCollection>("from");
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
            set
            {
                this.OnPropertyChanging("From");
                if ((value == null))
                {
                    this.SetAttributeValue("from", value);
                }
                else
                {
                    this.SetAttributeValue("from", new Microsoft.Xrm.Sdk.EntityCollection(new System.Collections.Generic.List<Microsoft.Xrm.Sdk.Entity>(value)));
                }
                this.OnPropertyChanged("From");
            }
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
        /// Information which specifies whether the phone call activity was billed as part of resolving a case.
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
        /// Indication which specifies if the phone call activity was created by a workflow rule.
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
        /// Select whether a voice mail was left for the person.
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
        /// Unique identifier of the business unit that owns the phone call activity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
        public Microsoft.Xrm.Sdk.EntityReference OwningBusinessUnit
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningbusinessunit"); }
        }

        /// <summary>
        /// Unique identifier of the team that owns the phone call activity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
        public Microsoft.Xrm.Sdk.EntityReference OwningTeam
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningteam"); }
        }

        /// <summary>
        /// Unique identifier of the user that owns the phone call activity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
        public Microsoft.Xrm.Sdk.EntityReference OwningUser
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owninguser"); }
        }

        /// <summary>
        /// Type the phone number.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("phonenumber")]
        public string PhoneNumber
        {
            get { return this.GetAttributeValue<string>("phonenumber"); }
            set
            {
                this.OnPropertyChanging("PhoneNumber");
                this.SetAttributeValue("phonenumber", value);
                this.OnPropertyChanged("PhoneNumber");
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
        /// Unique identifier of the object with which the phone call activity is associated.
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
        /// Scheduled duration of the phone call activity, specified in minutes.
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
        /// Shows whether the phone call is open, completed, or canceled. Completed and canceled phone calls are read-only and can't be edited.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
        public System.Nullable<PhoneCallState> StateCode
        {
            get
            {
                Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
                if ((optionSet != null))
                {
                    return ((PhoneCallState) (System.Enum.ToObject(typeof(PhoneCallState), optionSet.Value)));
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// Select the phone call's status.
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
        /// Type a subcategory to identify the phone call type and relate the activity to a specific product, sales region, business group, or other function.
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
        /// Type a short description about the objective or primary topic of the phone call.
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
        /// Enter the account, contact, lead, or user recipients of the phone call.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("to")]
        public System.Collections.Generic.IEnumerable<ActivityParty> To
        {
            get
            {
                Microsoft.Xrm.Sdk.EntityCollection collection = this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityCollection>("to");
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
            set
            {
                this.OnPropertyChanging("To");
                if ((value == null))
                {
                    this.SetAttributeValue("to", value);
                }
                else
                {
                    this.SetAttributeValue("to", new Microsoft.Xrm.Sdk.EntityCollection(new System.Collections.Generic.List<Microsoft.Xrm.Sdk.Entity>(value)));
                }
                this.OnPropertyChanged("To");
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
        /// Version number of the phone call activity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
        public System.Nullable<long> VersionNumber
        {
            get { return this.GetAttributeValue<System.Nullable<long>>("versionnumber"); }
        }

        /// <summary>
        /// 1:N phonecall_activity_parties
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("phonecall_activity_parties")]
        public System.Collections.Generic.IEnumerable<ActivityParty> phonecall_activity_parties
        {
            get { return this.GetRelatedEntities<ActivityParty>("phonecall_activity_parties", null); }
            set
            {
                this.OnPropertyChanging("phonecall_activity_parties");
                this.SetRelatedEntities<ActivityParty>("phonecall_activity_parties", null, value);
                this.OnPropertyChanged("phonecall_activity_parties");
            }
        }

        /// <summary>
        /// 1:N PhoneCall_Annotation
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("PhoneCall_Annotation")]
        public System.Collections.Generic.IEnumerable<Annotation> PhoneCall_Annotation
        {
            get { return this.GetRelatedEntities<Annotation>("PhoneCall_Annotation", null); }
            set
            {
                this.OnPropertyChanging("PhoneCall_Annotation");
                this.SetRelatedEntities<Annotation>("PhoneCall_Annotation", null, value);
                this.OnPropertyChanged("PhoneCall_Annotation");
            }
        }

        /// <summary>
        /// 1:N PhoneCall_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("PhoneCall_AsyncOperations")]
        public System.Collections.Generic.IEnumerable<AsyncOperation> PhoneCall_AsyncOperations
        {
            get { return this.GetRelatedEntities<AsyncOperation>("PhoneCall_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("PhoneCall_AsyncOperations");
                this.SetRelatedEntities<AsyncOperation>("PhoneCall_AsyncOperations", null, value);
                this.OnPropertyChanged("PhoneCall_AsyncOperations");
            }
        }

        /// <summary>
        /// 1:N PhoneCall_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("PhoneCall_BulkDeleteFailures")]
        public System.Collections.Generic.IEnumerable<BulkDeleteFailure> PhoneCall_BulkDeleteFailures
        {
            get { return this.GetRelatedEntities<BulkDeleteFailure>("PhoneCall_BulkDeleteFailures", null); }
            set
            {
                this.OnPropertyChanging("PhoneCall_BulkDeleteFailures");
                this.SetRelatedEntities<BulkDeleteFailure>("PhoneCall_BulkDeleteFailures", null, value);
                this.OnPropertyChanged("PhoneCall_BulkDeleteFailures");
            }
        }

        /// <summary>
        /// 1:N phonecall_campaignresponse
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("phonecall_campaignresponse")]
        public System.Collections.Generic.IEnumerable<CampaignResponse> phonecall_campaignresponse
        {
            get { return this.GetRelatedEntities<CampaignResponse>("phonecall_campaignresponse", null); }
            set
            {
                this.OnPropertyChanging("phonecall_campaignresponse");
                this.SetRelatedEntities<CampaignResponse>("phonecall_campaignresponse", null, value);
                this.OnPropertyChanged("phonecall_campaignresponse");
            }
        }

        /// <summary>
        /// 1:N phonecall_connections1
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("phonecall_connections1")]
        public System.Collections.Generic.IEnumerable<Connection> phonecall_connections1
        {
            get { return this.GetRelatedEntities<Connection>("phonecall_connections1", null); }
            set
            {
                this.OnPropertyChanging("phonecall_connections1");
                this.SetRelatedEntities<Connection>("phonecall_connections1", null, value);
                this.OnPropertyChanged("phonecall_connections1");
            }
        }

        /// <summary>
        /// 1:N phonecall_connections2
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("phonecall_connections2")]
        public System.Collections.Generic.IEnumerable<Connection> phonecall_connections2
        {
            get { return this.GetRelatedEntities<Connection>("phonecall_connections2", null); }
            set
            {
                this.OnPropertyChanging("phonecall_connections2");
                this.SetRelatedEntities<Connection>("phonecall_connections2", null, value);
                this.OnPropertyChanged("phonecall_connections2");
            }
        }

        /// <summary>
        /// 1:N PhoneCall_DuplicateBaseRecord
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("PhoneCall_DuplicateBaseRecord")]
        public System.Collections.Generic.IEnumerable<DuplicateRecord> PhoneCall_DuplicateBaseRecord
        {
            get { return this.GetRelatedEntities<DuplicateRecord>("PhoneCall_DuplicateBaseRecord", null); }
            set
            {
                this.OnPropertyChanging("PhoneCall_DuplicateBaseRecord");
                this.SetRelatedEntities<DuplicateRecord>("PhoneCall_DuplicateBaseRecord", null, value);
                this.OnPropertyChanged("PhoneCall_DuplicateBaseRecord");
            }
        }

        /// <summary>
        /// 1:N PhoneCall_DuplicateMatchingRecord
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("PhoneCall_DuplicateMatchingRecord")]
        public System.Collections.Generic.IEnumerable<DuplicateRecord> PhoneCall_DuplicateMatchingRecord
        {
            get { return this.GetRelatedEntities<DuplicateRecord>("PhoneCall_DuplicateMatchingRecord", null); }
            set
            {
                this.OnPropertyChanging("PhoneCall_DuplicateMatchingRecord");
                this.SetRelatedEntities<DuplicateRecord>("PhoneCall_DuplicateMatchingRecord", null, value);
                this.OnPropertyChanged("PhoneCall_DuplicateMatchingRecord");
            }
        }

        /// <summary>
        /// 1:N phonecall_PostFollows
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("phonecall_PostFollows")]
        public System.Collections.Generic.IEnumerable<PostFollow> phonecall_PostFollows
        {
            get { return this.GetRelatedEntities<PostFollow>("phonecall_PostFollows", null); }
            set
            {
                this.OnPropertyChanging("phonecall_PostFollows");
                this.SetRelatedEntities<PostFollow>("phonecall_PostFollows", null, value);
                this.OnPropertyChanged("phonecall_PostFollows");
            }
        }

        /// <summary>
        /// 1:N phonecall_principalobjectattributeaccess
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("phonecall_principalobjectattributeaccess")]
        public System.Collections.Generic.IEnumerable<PrincipalObjectAttributeAccess> phonecall_principalobjectattributeaccess
        {
            get { return this.GetRelatedEntities<PrincipalObjectAttributeAccess>("phonecall_principalobjectattributeaccess", null); }
            set
            {
                this.OnPropertyChanging("phonecall_principalobjectattributeaccess");
                this.SetRelatedEntities<PrincipalObjectAttributeAccess>("phonecall_principalobjectattributeaccess", null, value);
                this.OnPropertyChanged("phonecall_principalobjectattributeaccess");
            }
        }

        /// <summary>
        /// 1:N PhoneCall_ProcessSessions
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("PhoneCall_ProcessSessions")]
        public System.Collections.Generic.IEnumerable<ProcessSession> PhoneCall_ProcessSessions
        {
            get { return this.GetRelatedEntities<ProcessSession>("PhoneCall_ProcessSessions", null); }
            set
            {
                this.OnPropertyChanging("PhoneCall_ProcessSessions");
                this.SetRelatedEntities<ProcessSession>("PhoneCall_ProcessSessions", null, value);
                this.OnPropertyChanged("PhoneCall_ProcessSessions");
            }
        }

        /// <summary>
        /// 1:N PhoneCall_QueueItem
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("PhoneCall_QueueItem")]
        public System.Collections.Generic.IEnumerable<QueueItem> PhoneCall_QueueItem
        {
            get { return this.GetRelatedEntities<QueueItem>("PhoneCall_QueueItem", null); }
            set
            {
                this.OnPropertyChanging("PhoneCall_QueueItem");
                this.SetRelatedEntities<QueueItem>("PhoneCall_QueueItem", null, value);
                this.OnPropertyChanged("PhoneCall_QueueItem");
            }
        }

        /// <summary>
        /// 1:N userentityinstancedata_phonecall
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_phonecall")]
        public System.Collections.Generic.IEnumerable<UserEntityInstanceData> userentityinstancedata_phonecall
        {
            get { return this.GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_phonecall", null); }
            set
            {
                this.OnPropertyChanging("userentityinstancedata_phonecall");
                this.SetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_phonecall", null, value);
                this.OnPropertyChanged("userentityinstancedata_phonecall");
            }
        }

        /// <summary>
        /// N:1 Account_Phonecalls
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Account_Phonecalls")]
        public Account Account_Phonecalls
        {
            get { return this.GetRelatedEntity<Account>("Account_Phonecalls", null); }
            set
            {
                this.OnPropertyChanging("Account_Phonecalls");
                this.SetRelatedEntity<Account>("Account_Phonecalls", null, value);
                this.OnPropertyChanged("Account_Phonecalls");
            }
        }

        /// <summary>
        /// N:1 activity_pointer_phonecall
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("activityid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("activity_pointer_phonecall")]
        public ActivityPointer activity_pointer_phonecall
        {
            get { return this.GetRelatedEntity<ActivityPointer>("activity_pointer_phonecall", null); }
            set
            {
                this.OnPropertyChanging("activity_pointer_phonecall");
                this.SetRelatedEntity<ActivityPointer>("activity_pointer_phonecall", null, value);
                this.OnPropertyChanged("activity_pointer_phonecall");
            }
        }

        /// <summary>
        /// N:1 BulkOperation_Phonecall
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("BulkOperation_Phonecall")]
        public BulkOperation BulkOperation_Phonecall
        {
            get { return this.GetRelatedEntity<BulkOperation>("BulkOperation_Phonecall", null); }
            set
            {
                this.OnPropertyChanging("BulkOperation_Phonecall");
                this.SetRelatedEntity<BulkOperation>("BulkOperation_Phonecall", null, value);
                this.OnPropertyChanged("BulkOperation_Phonecall");
            }
        }

        /// <summary>
        /// N:1 business_unit_phone_call_activities
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_phone_call_activities")]
        public BusinessUnit business_unit_phone_call_activities
        {
            get { return this.GetRelatedEntity<BusinessUnit>("business_unit_phone_call_activities", null); }
        }

        /// <summary>
        /// N:1 Campaign_Phonecalls
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Campaign_Phonecalls")]
        public Campaign Campaign_Phonecalls
        {
            get { return this.GetRelatedEntity<Campaign>("Campaign_Phonecalls", null); }
            set
            {
                this.OnPropertyChanging("Campaign_Phonecalls");
                this.SetRelatedEntity<Campaign>("Campaign_Phonecalls", null, value);
                this.OnPropertyChanged("Campaign_Phonecalls");
            }
        }

        /// <summary>
        /// N:1 CampaignActivity_Phonecalls
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("CampaignActivity_Phonecalls")]
        public CampaignActivity CampaignActivity_Phonecalls
        {
            get { return this.GetRelatedEntity<CampaignActivity>("CampaignActivity_Phonecalls", null); }
            set
            {
                this.OnPropertyChanging("CampaignActivity_Phonecalls");
                this.SetRelatedEntity<CampaignActivity>("CampaignActivity_Phonecalls", null, value);
                this.OnPropertyChanged("CampaignActivity_Phonecalls");
            }
        }

        /// <summary>
        /// N:1 Contact_Phonecalls
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Contact_Phonecalls")]
        public Contact Contact_Phonecalls
        {
            get { return this.GetRelatedEntity<Contact>("Contact_Phonecalls", null); }
            set
            {
                this.OnPropertyChanging("Contact_Phonecalls");
                this.SetRelatedEntity<Contact>("Contact_Phonecalls", null, value);
                this.OnPropertyChanged("Contact_Phonecalls");
            }
        }

        /// <summary>
        /// N:1 Contract_Phonecalls
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Contract_Phonecalls")]
        public Contract Contract_Phonecalls
        {
            get { return this.GetRelatedEntity<Contract>("Contract_Phonecalls", null); }
            set
            {
                this.OnPropertyChanging("Contract_Phonecalls");
                this.SetRelatedEntity<Contract>("Contract_Phonecalls", null, value);
                this.OnPropertyChanged("Contract_Phonecalls");
            }
        }

        /// <summary>
        /// N:1 entitlement_PhoneCalls
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("entitlement_PhoneCalls")]
        public Entitlement entitlement_PhoneCalls
        {
            get { return this.GetRelatedEntity<Entitlement>("entitlement_PhoneCalls", null); }
            set
            {
                this.OnPropertyChanging("entitlement_PhoneCalls");
                this.SetRelatedEntity<Entitlement>("entitlement_PhoneCalls", null, value);
                this.OnPropertyChanged("entitlement_PhoneCalls");
            }
        }

        /// <summary>
        /// N:1 entitlementtemplate_PhoneCalls
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("entitlementtemplate_PhoneCalls")]
        public EntitlementTemplate entitlementtemplate_PhoneCalls
        {
            get { return this.GetRelatedEntity<EntitlementTemplate>("entitlementtemplate_PhoneCalls", null); }
            set
            {
                this.OnPropertyChanging("entitlementtemplate_PhoneCalls");
                this.SetRelatedEntity<EntitlementTemplate>("entitlementtemplate_PhoneCalls", null, value);
                this.OnPropertyChanged("entitlementtemplate_PhoneCalls");
            }
        }

        /// <summary>
        /// N:1 Incident_Phonecalls
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Incident_Phonecalls")]
        public Incident Incident_Phonecalls
        {
            get { return this.GetRelatedEntity<Incident>("Incident_Phonecalls", null); }
            set
            {
                this.OnPropertyChanging("Incident_Phonecalls");
                this.SetRelatedEntity<Incident>("Incident_Phonecalls", null, value);
                this.OnPropertyChanged("Incident_Phonecalls");
            }
        }

        /// <summary>
        /// N:1 Invoice_Phonecalls
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Invoice_Phonecalls")]
        public Invoice Invoice_Phonecalls
        {
            get { return this.GetRelatedEntity<Invoice>("Invoice_Phonecalls", null); }
            set
            {
                this.OnPropertyChanging("Invoice_Phonecalls");
                this.SetRelatedEntity<Invoice>("Invoice_Phonecalls", null, value);
                this.OnPropertyChanged("Invoice_Phonecalls");
            }
        }

        /// <summary>
        /// N:1 Lead_Phonecalls
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Lead_Phonecalls")]
        public Lead Lead_Phonecalls
        {
            get { return this.GetRelatedEntity<Lead>("Lead_Phonecalls", null); }
            set
            {
                this.OnPropertyChanging("Lead_Phonecalls");
                this.SetRelatedEntity<Lead>("Lead_Phonecalls", null, value);
                this.OnPropertyChanged("Lead_Phonecalls");
            }
        }

        /// <summary>
        /// N:1 lk_phonecall_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_phonecall_createdby")]
        public SystemUser lk_phonecall_createdby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_phonecall_createdby", null); }
        }

        /// <summary>
        /// N:1 lk_phonecall_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_phonecall_createdonbehalfby")]
        public SystemUser lk_phonecall_createdonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_phonecall_createdonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_phonecall_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_phonecall_modifiedby")]
        public SystemUser lk_phonecall_modifiedby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_phonecall_modifiedby", null); }
        }

        /// <summary>
        /// N:1 lk_phonecall_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_phonecall_modifiedonbehalfby")]
        public SystemUser lk_phonecall_modifiedonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_phonecall_modifiedonbehalfby", null); }
        }

        /// <summary>
        /// N:1 msdyn_postalbum_PhoneCalls
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_postalbum_PhoneCalls")]
        public msdyn_PostAlbum msdyn_postalbum_PhoneCalls
        {
            get { return this.GetRelatedEntity<msdyn_PostAlbum>("msdyn_postalbum_PhoneCalls", null); }
            set
            {
                this.OnPropertyChanging("msdyn_postalbum_PhoneCalls");
                this.SetRelatedEntity<msdyn_PostAlbum>("msdyn_postalbum_PhoneCalls", null, value);
                this.OnPropertyChanged("msdyn_postalbum_PhoneCalls");
            }
        }

        /// <summary>
        /// N:1 Opportunity_Phonecalls
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Opportunity_Phonecalls")]
        public Opportunity Opportunity_Phonecalls
        {
            get { return this.GetRelatedEntity<Opportunity>("Opportunity_Phonecalls", null); }
            set
            {
                this.OnPropertyChanging("Opportunity_Phonecalls");
                this.SetRelatedEntity<Opportunity>("Opportunity_Phonecalls", null, value);
                this.OnPropertyChanged("Opportunity_Phonecalls");
            }
        }

        /// <summary>
        /// N:1 processstage_phonecalls
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("stageid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("processstage_phonecalls")]
        public ProcessStage processstage_phonecalls
        {
            get { return this.GetRelatedEntity<ProcessStage>("processstage_phonecalls", null); }
            set
            {
                this.OnPropertyChanging("processstage_phonecalls");
                this.SetRelatedEntity<ProcessStage>("processstage_phonecalls", null, value);
                this.OnPropertyChanged("processstage_phonecalls");
            }
        }

        /// <summary>
        /// N:1 Quote_Phonecalls
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Quote_Phonecalls")]
        public Quote Quote_Phonecalls
        {
            get { return this.GetRelatedEntity<Quote>("Quote_Phonecalls", null); }
            set
            {
                this.OnPropertyChanging("Quote_Phonecalls");
                this.SetRelatedEntity<Quote>("Quote_Phonecalls", null, value);
                this.OnPropertyChanged("Quote_Phonecalls");
            }
        }

        /// <summary>
        /// N:1 SalesOrder_Phonecalls
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SalesOrder_Phonecalls")]
        public SalesOrder SalesOrder_Phonecalls
        {
            get { return this.GetRelatedEntity<SalesOrder>("SalesOrder_Phonecalls", null); }
            set
            {
                this.OnPropertyChanging("SalesOrder_Phonecalls");
                this.SetRelatedEntity<SalesOrder>("SalesOrder_Phonecalls", null, value);
                this.OnPropertyChanged("SalesOrder_Phonecalls");
            }
        }

        /// <summary>
        /// N:1 service_phonecalls
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("serviceid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("service_phonecalls")]
        public Service service_phonecalls
        {
            get { return this.GetRelatedEntity<Service>("service_phonecalls", null); }
            set
            {
                this.OnPropertyChanging("service_phonecalls");
                this.SetRelatedEntity<Service>("service_phonecalls", null, value);
                this.OnPropertyChanged("service_phonecalls");
            }
        }

        /// <summary>
        /// N:1 team_phonecall
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_phonecall")]
        public Team team_phonecall
        {
            get { return this.GetRelatedEntity<Team>("team_phonecall", null); }
        }

        /// <summary>
        /// N:1 TransactionCurrency_PhoneCall
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("TransactionCurrency_PhoneCall")]
        public TransactionCurrency TransactionCurrency_PhoneCall
        {
            get { return this.GetRelatedEntity<TransactionCurrency>("TransactionCurrency_PhoneCall", null); }
            set
            {
                this.OnPropertyChanging("TransactionCurrency_PhoneCall");
                this.SetRelatedEntity<TransactionCurrency>("TransactionCurrency_PhoneCall", null, value);
                this.OnPropertyChanged("TransactionCurrency_PhoneCall");
            }
        }

        /// <summary>
        /// N:1 user_phonecall
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_phonecall")]
        public SystemUser user_phonecall
        {
            get { return this.GetRelatedEntity<SystemUser>("user_phonecall", null); }
        }
    }
}