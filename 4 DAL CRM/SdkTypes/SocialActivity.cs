using _4_DAL_CRM;

namespace __4_DAL_CRM
{
    /// <summary>
    /// For internal use only.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("socialactivity")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class SocialActivity : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public SocialActivity() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "socialactivity";

        public const int EntityTypeCode = 4216;

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
        /// Shows information about the social post content. This field is read-only.
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
        /// Select the direction of the post as incoming or outbound.
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
        /// Person who the activity is from.
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
        /// Sequence number of the import that created this record.
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
        /// Unique identifier for the responses to a post. For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("inresponseto")]
        public string InResponseTo
        {
            get { return this.GetAttributeValue<string>("inresponseto"); }
            set
            {
                this.OnPropertyChanging("InResponseTo");
                this.SetAttributeValue("inresponseto", value);
                this.OnPropertyChanged("InResponseTo");
            }
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
        /// For internal use only.
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
        /// For internal use only.
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
        /// Unique identifier of the user who owns the Activity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
        public Microsoft.Xrm.Sdk.EntityReference OwningUser
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owninguser"); }
        }

        /// <summary>
        /// Shows the contact or account that authored the post.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("postauthor")]
        public Microsoft.Xrm.Sdk.EntityReference PostAuthor
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("postauthor"); }
            set
            {
                this.OnPropertyChanging("PostAuthor");
                this.SetAttributeValue("postauthor", value);
                this.OnPropertyChanged("PostAuthor");
            }
        }

        /// <summary>
        /// Shows the parent account of the author of the post.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("postauthoraccount")]
        public Microsoft.Xrm.Sdk.EntityReference PostAuthorAccount
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("postauthoraccount"); }
            set
            {
                this.OnPropertyChanging("PostAuthorAccount");
                this.SetAttributeValue("postauthoraccount", value);
                this.OnPropertyChanged("PostAuthorAccount");
            }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("postedon")]
        public System.Nullable<System.DateTime> PostedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("postedon"); }
            set
            {
                this.OnPropertyChanging("PostedOn");
                this.SetAttributeValue("postedon", value);
                this.OnPropertyChanged("PostedOn");
            }
        }

        /// <summary>
        /// Shows the author of the post on the corresponding social channel.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("postfromprofileid")]
        public Microsoft.Xrm.Sdk.EntityReference PostFromProfileId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("postfromprofileid"); }
            set
            {
                this.OnPropertyChanging("PostFromProfileId");
                this.SetAttributeValue("postfromprofileid", value);
                this.OnPropertyChanged("PostFromProfileId");
            }
        }

        /// <summary>
        /// Unique identifier of the post. For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("postid")]
        public string PostId
        {
            get { return this.GetAttributeValue<string>("postid"); }
            set
            {
                this.OnPropertyChanging("PostId");
                this.SetAttributeValue("postid", value);
                this.OnPropertyChanged("PostId");
            }
        }

        /// <summary>
        /// Shows if the social post originated as a private or public message.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("postmessagetype")]
        public Microsoft.Xrm.Sdk.OptionSetValue PostMessageType
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("postmessagetype"); }
            set
            {
                this.OnPropertyChanging("PostMessageType");
                this.SetAttributeValue("postmessagetype", value);
                this.OnPropertyChanged("PostMessageType");
            }
        }

        /// <summary>
        /// Shows the recipients of the social post.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("posttoprofileid")]
        public string PostToProfileId
        {
            get { return this.GetAttributeValue<string>("posttoprofileid"); }
            set
            {
                this.OnPropertyChanging("PostToProfileId");
                this.SetAttributeValue("posttoprofileid", value);
                this.OnPropertyChanged("PostToProfileId");
            }
        }

        /// <summary>
        /// Shows the URL of the post.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("posturl")]
        public string PostURL
        {
            get { return this.GetAttributeValue<string>("posturl"); }
            set
            {
                this.OnPropertyChanging("PostURL");
                this.SetAttributeValue("posturl", value);
                this.OnPropertyChanged("PostURL");
            }
        }

        /// <summary>
        /// Shows the priority so that preferred customers or critical issues are handled quickly.
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
        /// Shows the record that the social activity relates to.
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
        /// Users or facility/equipment that are required for the activity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("resources")]
        public System.Collections.Generic.IEnumerable<ActivityParty> Resources
        {
            get
            {
                Microsoft.Xrm.Sdk.EntityCollection collection = this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityCollection>("resources");
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
                this.OnPropertyChanging("Resources");
                if ((value == null))
                {
                    this.SetAttributeValue("resources", value);
                }
                else
                {
                    this.SetAttributeValue("resources", new Microsoft.Xrm.Sdk.EntityCollection(new System.Collections.Generic.List<Microsoft.Xrm.Sdk.Entity>(value)));
                }
                this.OnPropertyChanged("Resources");
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
        /// Value derived after assessing words commonly associated with a negative, neutral, or positive sentiment that occurs in a social post. Sentiment information can also be reported as numeric values.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sentimentvalue")]
        public System.Nullable<double> SentimentValue
        {
            get { return this.GetAttributeValue<System.Nullable<double>>("sentimentvalue"); }
            set
            {
                this.OnPropertyChanging("SentimentValue");
                this.SetAttributeValue("sentimentvalue", value);
                this.OnPropertyChanged("SentimentValue");
            }
        }

        /// <summary>
        /// Unique identifier for the associated service.
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
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("socialadditionalparams")]
        public string SocialAdditionalParams
        {
            get { return this.GetAttributeValue<string>("socialadditionalparams"); }
            set
            {
                this.OnPropertyChanging("SocialAdditionalParams");
                this.SetAttributeValue("socialadditionalparams", value);
                this.OnPropertyChanged("SocialAdditionalParams");
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
        /// Shows whether the social activity completed. This field is read-only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
        public System.Nullable<SocialActivityState> StateCode
        {
            get
            {
                Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
                if ((optionSet != null))
                {
                    return ((SocialActivityState) (System.Enum.ToObject(typeof(SocialActivityState), optionSet.Value)));
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// Shows whether the social activity is completed, failed, or processing. This field is read-only.
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
        /// Unique identifier of the social conversation. For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("threadid")]
        public string ThreadId
        {
            get { return this.GetAttributeValue<string>("threadid"); }
            set
            {
                this.OnPropertyChanging("ThreadId");
                this.SetAttributeValue("threadid", value);
                this.OnPropertyChanged("ThreadId");
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
        /// Person who is the receiver of the activity.
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
        /// 1:N socialactivity_activity_parties
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("socialactivity_activity_parties")]
        public System.Collections.Generic.IEnumerable<ActivityParty> socialactivity_activity_parties
        {
            get { return this.GetRelatedEntities<ActivityParty>("socialactivity_activity_parties", null); }
            set
            {
                this.OnPropertyChanging("socialactivity_activity_parties");
                this.SetRelatedEntities<ActivityParty>("socialactivity_activity_parties", null, value);
                this.OnPropertyChanged("socialactivity_activity_parties");
            }
        }

        /// <summary>
        /// 1:N SocialActivity_Annotation
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SocialActivity_Annotation")]
        public System.Collections.Generic.IEnumerable<Annotation> SocialActivity_Annotation
        {
            get { return this.GetRelatedEntities<Annotation>("SocialActivity_Annotation", null); }
            set
            {
                this.OnPropertyChanging("SocialActivity_Annotation");
                this.SetRelatedEntities<Annotation>("SocialActivity_Annotation", null, value);
                this.OnPropertyChanged("SocialActivity_Annotation");
            }
        }

        /// <summary>
        /// 1:N SocialActivity_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SocialActivity_AsyncOperations")]
        public System.Collections.Generic.IEnumerable<AsyncOperation> SocialActivity_AsyncOperations
        {
            get { return this.GetRelatedEntities<AsyncOperation>("SocialActivity_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("SocialActivity_AsyncOperations");
                this.SetRelatedEntities<AsyncOperation>("SocialActivity_AsyncOperations", null, value);
                this.OnPropertyChanged("SocialActivity_AsyncOperations");
            }
        }

        /// <summary>
        /// 1:N SocialActivity_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SocialActivity_BulkDeleteFailures")]
        public System.Collections.Generic.IEnumerable<BulkDeleteFailure> SocialActivity_BulkDeleteFailures
        {
            get { return this.GetRelatedEntities<BulkDeleteFailure>("SocialActivity_BulkDeleteFailures", null); }
            set
            {
                this.OnPropertyChanging("SocialActivity_BulkDeleteFailures");
                this.SetRelatedEntities<BulkDeleteFailure>("SocialActivity_BulkDeleteFailures", null, value);
                this.OnPropertyChanged("SocialActivity_BulkDeleteFailures");
            }
        }

        /// <summary>
        /// 1:N socialactivity_connections1
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("socialactivity_connections1")]
        public System.Collections.Generic.IEnumerable<Connection> socialactivity_connections1
        {
            get { return this.GetRelatedEntities<Connection>("socialactivity_connections1", null); }
            set
            {
                this.OnPropertyChanging("socialactivity_connections1");
                this.SetRelatedEntities<Connection>("socialactivity_connections1", null, value);
                this.OnPropertyChanged("socialactivity_connections1");
            }
        }

        /// <summary>
        /// 1:N socialactivity_connections2
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("socialactivity_connections2")]
        public System.Collections.Generic.IEnumerable<Connection> socialactivity_connections2
        {
            get { return this.GetRelatedEntities<Connection>("socialactivity_connections2", null); }
            set
            {
                this.OnPropertyChanging("socialactivity_connections2");
                this.SetRelatedEntities<Connection>("socialactivity_connections2", null, value);
                this.OnPropertyChanged("socialactivity_connections2");
            }
        }

        /// <summary>
        /// 1:N SocialActivity_DuplicateBaseRecord
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SocialActivity_DuplicateBaseRecord")]
        public System.Collections.Generic.IEnumerable<DuplicateRecord> SocialActivity_DuplicateBaseRecord
        {
            get { return this.GetRelatedEntities<DuplicateRecord>("SocialActivity_DuplicateBaseRecord", null); }
            set
            {
                this.OnPropertyChanging("SocialActivity_DuplicateBaseRecord");
                this.SetRelatedEntities<DuplicateRecord>("SocialActivity_DuplicateBaseRecord", null, value);
                this.OnPropertyChanged("SocialActivity_DuplicateBaseRecord");
            }
        }

        /// <summary>
        /// 1:N SocialActivity_DuplicateMatchingRecord
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SocialActivity_DuplicateMatchingRecord")]
        public System.Collections.Generic.IEnumerable<DuplicateRecord> SocialActivity_DuplicateMatchingRecord
        {
            get { return this.GetRelatedEntities<DuplicateRecord>("SocialActivity_DuplicateMatchingRecord", null); }
            set
            {
                this.OnPropertyChanging("SocialActivity_DuplicateMatchingRecord");
                this.SetRelatedEntities<DuplicateRecord>("SocialActivity_DuplicateMatchingRecord", null, value);
                this.OnPropertyChanged("SocialActivity_DuplicateMatchingRecord");
            }
        }

        /// <summary>
        /// 1:N socialactivity_principalobjectattributeaccess
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("socialactivity_principalobjectattributeaccess")]
        public System.Collections.Generic.IEnumerable<PrincipalObjectAttributeAccess> socialactivity_principalobjectattributeaccess
        {
            get { return this.GetRelatedEntities<PrincipalObjectAttributeAccess>("socialactivity_principalobjectattributeaccess", null); }
            set
            {
                this.OnPropertyChanging("socialactivity_principalobjectattributeaccess");
                this.SetRelatedEntities<PrincipalObjectAttributeAccess>("socialactivity_principalobjectattributeaccess", null, value);
                this.OnPropertyChanged("socialactivity_principalobjectattributeaccess");
            }
        }

        /// <summary>
        /// 1:N SocialActivity_ProcessSessions
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SocialActivity_ProcessSessions")]
        public System.Collections.Generic.IEnumerable<ProcessSession> SocialActivity_ProcessSessions
        {
            get { return this.GetRelatedEntities<ProcessSession>("SocialActivity_ProcessSessions", null); }
            set
            {
                this.OnPropertyChanging("SocialActivity_ProcessSessions");
                this.SetRelatedEntities<ProcessSession>("SocialActivity_ProcessSessions", null, value);
                this.OnPropertyChanged("SocialActivity_ProcessSessions");
            }
        }

        /// <summary>
        /// 1:N SocialActivity_QueueItem
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SocialActivity_QueueItem")]
        public System.Collections.Generic.IEnumerable<QueueItem> SocialActivity_QueueItem
        {
            get { return this.GetRelatedEntities<QueueItem>("SocialActivity_QueueItem", null); }
            set
            {
                this.OnPropertyChanging("SocialActivity_QueueItem");
                this.SetRelatedEntities<QueueItem>("SocialActivity_QueueItem", null, value);
                this.OnPropertyChanged("SocialActivity_QueueItem");
            }
        }

        /// <summary>
        /// 1:N userentityinstancedata_socialactivity
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_socialactivity")]
        public System.Collections.Generic.IEnumerable<UserEntityInstanceData> userentityinstancedata_socialactivity
        {
            get { return this.GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_socialactivity", null); }
            set
            {
                this.OnPropertyChanging("userentityinstancedata_socialactivity");
                this.SetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_socialactivity", null, value);
                this.OnPropertyChanged("userentityinstancedata_socialactivity");
            }
        }

        /// <summary>
        /// N:1 Account_SocialActivities
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Account_SocialActivities")]
        public Account Account_SocialActivities
        {
            get { return this.GetRelatedEntity<Account>("Account_SocialActivities", null); }
            set
            {
                this.OnPropertyChanging("Account_SocialActivities");
                this.SetRelatedEntity<Account>("Account_SocialActivities", null, value);
                this.OnPropertyChanged("Account_SocialActivities");
            }
        }

        /// <summary>
        /// N:1 activity_pointer_socialactivity
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("activityid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("activity_pointer_socialactivity")]
        public ActivityPointer activity_pointer_socialactivity
        {
            get { return this.GetRelatedEntity<ActivityPointer>("activity_pointer_socialactivity", null); }
            set
            {
                this.OnPropertyChanging("activity_pointer_socialactivity");
                this.SetRelatedEntity<ActivityPointer>("activity_pointer_socialactivity", null, value);
                this.OnPropertyChanged("activity_pointer_socialactivity");
            }
        }

        /// <summary>
        /// N:1 AsyncOperation_SocialActivities
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("AsyncOperation_SocialActivities")]
        public AsyncOperation AsyncOperation_SocialActivities
        {
            get { return this.GetRelatedEntity<AsyncOperation>("AsyncOperation_SocialActivities", null); }
            set
            {
                this.OnPropertyChanging("AsyncOperation_SocialActivities");
                this.SetRelatedEntity<AsyncOperation>("AsyncOperation_SocialActivities", null, value);
                this.OnPropertyChanged("AsyncOperation_SocialActivities");
            }
        }

        /// <summary>
        /// N:1 BulkOperation_SocialActivity
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("BulkOperation_SocialActivity")]
        public BulkOperation BulkOperation_SocialActivity
        {
            get { return this.GetRelatedEntity<BulkOperation>("BulkOperation_SocialActivity", null); }
            set
            {
                this.OnPropertyChanging("BulkOperation_SocialActivity");
                this.SetRelatedEntity<BulkOperation>("BulkOperation_SocialActivity", null, value);
                this.OnPropertyChanged("BulkOperation_SocialActivity");
            }
        }

        /// <summary>
        /// N:1 business_unit_socialactivity
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_socialactivity")]
        public BusinessUnit business_unit_socialactivity
        {
            get { return this.GetRelatedEntity<BusinessUnit>("business_unit_socialactivity", null); }
        }

        /// <summary>
        /// N:1 Contact_SocialActivities
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Contact_SocialActivities")]
        public Contact Contact_SocialActivities
        {
            get { return this.GetRelatedEntity<Contact>("Contact_SocialActivities", null); }
            set
            {
                this.OnPropertyChanging("Contact_SocialActivities");
                this.SetRelatedEntity<Contact>("Contact_SocialActivities", null, value);
                this.OnPropertyChanged("Contact_SocialActivities");
            }
        }

        /// <summary>
        /// N:1 Contract_SocialActivities
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Contract_SocialActivities")]
        public Contract Contract_SocialActivities
        {
            get { return this.GetRelatedEntity<Contract>("Contract_SocialActivities", null); }
            set
            {
                this.OnPropertyChanging("Contract_SocialActivities");
                this.SetRelatedEntity<Contract>("Contract_SocialActivities", null, value);
                this.OnPropertyChanged("Contract_SocialActivities");
            }
        }

        /// <summary>
        /// N:1 entitlement_SocialActivities
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("entitlement_SocialActivities")]
        public Entitlement entitlement_SocialActivities
        {
            get { return this.GetRelatedEntity<Entitlement>("entitlement_SocialActivities", null); }
            set
            {
                this.OnPropertyChanging("entitlement_SocialActivities");
                this.SetRelatedEntity<Entitlement>("entitlement_SocialActivities", null, value);
                this.OnPropertyChanged("entitlement_SocialActivities");
            }
        }

        /// <summary>
        /// N:1 entitlementtemplate_SocialActivities
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("entitlementtemplate_SocialActivities")]
        public EntitlementTemplate entitlementtemplate_SocialActivities
        {
            get { return this.GetRelatedEntity<EntitlementTemplate>("entitlementtemplate_SocialActivities", null); }
            set
            {
                this.OnPropertyChanging("entitlementtemplate_SocialActivities");
                this.SetRelatedEntity<EntitlementTemplate>("entitlementtemplate_SocialActivities", null, value);
                this.OnPropertyChanged("entitlementtemplate_SocialActivities");
            }
        }

        /// <summary>
        /// N:1 Incident_SocialActivities
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Incident_SocialActivities")]
        public Incident Incident_SocialActivities
        {
            get { return this.GetRelatedEntity<Incident>("Incident_SocialActivities", null); }
            set
            {
                this.OnPropertyChanging("Incident_SocialActivities");
                this.SetRelatedEntity<Incident>("Incident_SocialActivities", null, value);
                this.OnPropertyChanged("Incident_SocialActivities");
            }
        }

        /// <summary>
        /// N:1 Invoice_SocialActivities
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Invoice_SocialActivities")]
        public Invoice Invoice_SocialActivities
        {
            get { return this.GetRelatedEntity<Invoice>("Invoice_SocialActivities", null); }
            set
            {
                this.OnPropertyChanging("Invoice_SocialActivities");
                this.SetRelatedEntity<Invoice>("Invoice_SocialActivities", null, value);
                this.OnPropertyChanged("Invoice_SocialActivities");
            }
        }

        /// <summary>
        /// N:1 Lead_SocialActivities
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Lead_SocialActivities")]
        public Lead Lead_SocialActivities
        {
            get { return this.GetRelatedEntity<Lead>("Lead_SocialActivities", null); }
            set
            {
                this.OnPropertyChanging("Lead_SocialActivities");
                this.SetRelatedEntity<Lead>("Lead_SocialActivities", null, value);
                this.OnPropertyChanged("Lead_SocialActivities");
            }
        }

        /// <summary>
        /// N:1 lk_socialactivity_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_socialactivity_createdby")]
        public SystemUser lk_socialactivity_createdby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_socialactivity_createdby", null); }
        }

        /// <summary>
        /// N:1 lk_socialactivity_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_socialactivity_modifiedby")]
        public SystemUser lk_socialactivity_modifiedby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_socialactivity_modifiedby", null); }
        }

        /// <summary>
        /// N:1 lk_socialactivitybase_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_socialactivitybase_createdonbehalfby")]
        public SystemUser lk_socialactivitybase_createdonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_socialactivitybase_createdonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_socialactivitybase_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_socialactivitybase_modifiedonbehalfby")]
        public SystemUser lk_socialactivitybase_modifiedonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_socialactivitybase_modifiedonbehalfby", null); }
        }

        /// <summary>
        /// N:1 msdyn_postalbum_SocialActivities
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_postalbum_SocialActivities")]
        public msdyn_PostAlbum msdyn_postalbum_SocialActivities
        {
            get { return this.GetRelatedEntity<msdyn_PostAlbum>("msdyn_postalbum_SocialActivities", null); }
            set
            {
                this.OnPropertyChanging("msdyn_postalbum_SocialActivities");
                this.SetRelatedEntity<msdyn_PostAlbum>("msdyn_postalbum_SocialActivities", null, value);
                this.OnPropertyChanged("msdyn_postalbum_SocialActivities");
            }
        }

        /// <summary>
        /// N:1 Opportunity_SocialActivities
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Opportunity_SocialActivities")]
        public Opportunity Opportunity_SocialActivities
        {
            get { return this.GetRelatedEntity<Opportunity>("Opportunity_SocialActivities", null); }
            set
            {
                this.OnPropertyChanging("Opportunity_SocialActivities");
                this.SetRelatedEntity<Opportunity>("Opportunity_SocialActivities", null, value);
                this.OnPropertyChanged("Opportunity_SocialActivities");
            }
        }

        /// <summary>
        /// N:1 Quote_SocialActivities
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Quote_SocialActivities")]
        public Quote Quote_SocialActivities
        {
            get { return this.GetRelatedEntity<Quote>("Quote_SocialActivities", null); }
            set
            {
                this.OnPropertyChanging("Quote_SocialActivities");
                this.SetRelatedEntity<Quote>("Quote_SocialActivities", null, value);
                this.OnPropertyChanged("Quote_SocialActivities");
            }
        }

        /// <summary>
        /// N:1 SalesOrder_SocialActivities
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SalesOrder_SocialActivities")]
        public SalesOrder SalesOrder_SocialActivities
        {
            get { return this.GetRelatedEntity<SalesOrder>("SalesOrder_SocialActivities", null); }
            set
            {
                this.OnPropertyChanging("SalesOrder_SocialActivities");
                this.SetRelatedEntity<SalesOrder>("SalesOrder_SocialActivities", null, value);
                this.OnPropertyChanged("SalesOrder_SocialActivities");
            }
        }

        /// <summary>
        /// N:1 service_socialactivities
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("serviceid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("service_socialactivities")]
        public Service service_socialactivities
        {
            get { return this.GetRelatedEntity<Service>("service_socialactivities", null); }
            set
            {
                this.OnPropertyChanging("service_socialactivities");
                this.SetRelatedEntity<Service>("service_socialactivities", null, value);
                this.OnPropertyChanged("service_socialactivities");
            }
        }

        /// <summary>
        /// N:1 SocialActivity_PostAuthor_accounts
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("postauthor")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SocialActivity_PostAuthor_accounts")]
        public Account SocialActivity_PostAuthor_accounts
        {
            get { return this.GetRelatedEntity<Account>("SocialActivity_PostAuthor_accounts", null); }
            set
            {
                this.OnPropertyChanging("SocialActivity_PostAuthor_accounts");
                this.SetRelatedEntity<Account>("SocialActivity_PostAuthor_accounts", null, value);
                this.OnPropertyChanged("SocialActivity_PostAuthor_accounts");
            }
        }

        /// <summary>
        /// N:1 socialactivity_postauthor_contacts
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("postauthor")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("socialactivity_postauthor_contacts")]
        public Contact socialactivity_postauthor_contacts
        {
            get { return this.GetRelatedEntity<Contact>("socialactivity_postauthor_contacts", null); }
            set
            {
                this.OnPropertyChanging("socialactivity_postauthor_contacts");
                this.SetRelatedEntity<Contact>("socialactivity_postauthor_contacts", null, value);
                this.OnPropertyChanged("socialactivity_postauthor_contacts");
            }
        }

        /// <summary>
        /// N:1 SocialActivity_PostAuthorAccount_accounts
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("postauthoraccount")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SocialActivity_PostAuthorAccount_accounts")]
        public Account SocialActivity_PostAuthorAccount_accounts
        {
            get { return this.GetRelatedEntity<Account>("SocialActivity_PostAuthorAccount_accounts", null); }
            set
            {
                this.OnPropertyChanging("SocialActivity_PostAuthorAccount_accounts");
                this.SetRelatedEntity<Account>("SocialActivity_PostAuthorAccount_accounts", null, value);
                this.OnPropertyChanged("SocialActivity_PostAuthorAccount_accounts");
            }
        }

        /// <summary>
        /// N:1 socialactivity_postauthoraccount_contacts
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("postauthoraccount")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("socialactivity_postauthoraccount_contacts")]
        public Contact socialactivity_postauthoraccount_contacts
        {
            get { return this.GetRelatedEntity<Contact>("socialactivity_postauthoraccount_contacts", null); }
            set
            {
                this.OnPropertyChanging("socialactivity_postauthoraccount_contacts");
                this.SetRelatedEntity<Contact>("socialactivity_postauthoraccount_contacts", null, value);
                this.OnPropertyChanged("socialactivity_postauthoraccount_contacts");
            }
        }

        /// <summary>
        /// N:1 Socialprofile_SocialActivities
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("postfromprofileid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Socialprofile_SocialActivities")]
        public SocialProfile Socialprofile_SocialActivities
        {
            get { return this.GetRelatedEntity<SocialProfile>("Socialprofile_SocialActivities", null); }
            set
            {
                this.OnPropertyChanging("Socialprofile_SocialActivities");
                this.SetRelatedEntity<SocialProfile>("Socialprofile_SocialActivities", null, value);
                this.OnPropertyChanged("Socialprofile_SocialActivities");
            }
        }

        /// <summary>
        /// N:1 team_socialactivity
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_socialactivity")]
        public Team team_socialactivity
        {
            get { return this.GetRelatedEntity<Team>("team_socialactivity", null); }
        }

        /// <summary>
        /// N:1 transactioncurrency_socialactivity
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("transactioncurrency_socialactivity")]
        public TransactionCurrency transactioncurrency_socialactivity
        {
            get { return this.GetRelatedEntity<TransactionCurrency>("transactioncurrency_socialactivity", null); }
            set
            {
                this.OnPropertyChanging("transactioncurrency_socialactivity");
                this.SetRelatedEntity<TransactionCurrency>("transactioncurrency_socialactivity", null, value);
                this.OnPropertyChanged("transactioncurrency_socialactivity");
            }
        }

        /// <summary>
        /// N:1 user_socialactivity
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_socialactivity")]
        public SystemUser user_socialactivity
        {
            get { return this.GetRelatedEntity<SystemUser>("user_socialactivity", null); }
        }
    }
}