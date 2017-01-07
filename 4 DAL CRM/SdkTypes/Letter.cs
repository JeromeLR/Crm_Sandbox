using _4_DAL_CRM;

namespace __4_DAL_CRM
{
    /// <summary>
    /// Activity that tracks the delivery of a letter. The activity can contain the electronic copy of the letter.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("letter")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class Letter : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public Letter() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "letter";

        public const int EntityTypeCode = 4207;

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
        /// Unique identifier of the letter activity.
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
        /// Type the number of minutes spent creating and sending the letter. The duration is used in reporting.
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
        /// Enter the actual end date and time of the letter. By default, it displays the date and time when the activity was completed or canceled, but can be edited to capture the actual time to create and send the letter.
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
        /// Enter the actual start date and time for the letter. By default, it displays the date and time when the activity was created, but can be edited to capture the actual time to create and send the letter.
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
        /// Type the complete recipient address for the letter to ensure timely delivery.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address")]
        public string Address
        {
            get { return this.GetAttributeValue<string>("address"); }
            set
            {
                this.OnPropertyChanging("Address");
                this.SetAttributeValue("address", value);
                this.OnPropertyChanged("Address");
            }
        }

        /// <summary>
        /// Enter the recipients that are included in the letter distribution, but are not displayed to other recipients.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("bcc")]
        public System.Collections.Generic.IEnumerable<ActivityParty> Bcc
        {
            get
            {
                Microsoft.Xrm.Sdk.EntityCollection collection = this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityCollection>("bcc");
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
                this.OnPropertyChanging("Bcc");
                if ((value == null))
                {
                    this.SetAttributeValue("bcc", value);
                }
                else
                {
                    this.SetAttributeValue("bcc", new Microsoft.Xrm.Sdk.EntityCollection(new System.Collections.Generic.List<Microsoft.Xrm.Sdk.Entity>(value)));
                }
                this.OnPropertyChanged("Bcc");
            }
        }

        /// <summary>
        /// Type a category to identify the letter type, such as sales offer or past due notice, to tie the letter to a business group or function.
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
        /// Enter the recipients that should be copied on the letter.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("cc")]
        public System.Collections.Generic.IEnumerable<ActivityParty> Cc
        {
            get
            {
                Microsoft.Xrm.Sdk.EntityCollection collection = this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityCollection>("cc");
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
                this.OnPropertyChanging("Cc");
                if ((value == null))
                {
                    this.SetAttributeValue("cc", value);
                }
                else
                {
                    this.SetAttributeValue("cc", new Microsoft.Xrm.Sdk.EntityCollection(new System.Collections.Generic.List<Microsoft.Xrm.Sdk.Entity>(value)));
                }
                this.OnPropertyChanged("Cc");
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
        /// Type the letter body or additional information to describe the letter, such as the primary message or the products and services described.
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
        /// Select the direction of the letter as incoming or outbound.
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
        /// Enter the account, contact, lead, or user who sent the letter.
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
        /// Shows whether the letter activity was billed as part of resolving a case.
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
        /// Shows whether the activity is a regular activity type or event type.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isregularactivity")]
        public System.Nullable<bool> IsRegularActivity
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("isregularactivity"); }
        }

        /// <summary>
        /// Shows whether the letter activity was created by a workflow rule.
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
        /// Unique identifier of the business unit that owns the letter activity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
        public Microsoft.Xrm.Sdk.EntityReference OwningBusinessUnit
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningbusinessunit"); }
        }

        /// <summary>
        /// Unique identifier of the team that owns the letter activity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
        public Microsoft.Xrm.Sdk.EntityReference OwningTeam
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningteam"); }
        }

        /// <summary>
        /// Unique identifier of the user that owns the letter activity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
        public Microsoft.Xrm.Sdk.EntityReference OwningUser
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owninguser"); }
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
        /// Unique identifier of the object with which the letter activity is associated.
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
        /// Scheduled duration of the letter activity, specified in minutes.
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
        /// Shows whether the letter is open, completed, or canceled. Completed and canceled letters are read-only and can't be edited.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
        public System.Nullable<LetterState> StateCode
        {
            get
            {
                Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
                if ((optionSet != null))
                {
                    return ((LetterState) (System.Enum.ToObject(typeof(LetterState), optionSet.Value)));
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// Select the letter's status.
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
        /// Type a subcategory to identify the letter type and relate the activity to a specific product, sales region, business group, or other function.
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
        /// Type a short description about the objective or primary topic of the letter.
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
        /// Enter the account, contact, lead, or user recipients for the letter.
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
        /// Version number of the letter.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
        public System.Nullable<long> VersionNumber
        {
            get { return this.GetAttributeValue<System.Nullable<long>>("versionnumber"); }
        }

        /// <summary>
        /// 1:N letter_activity_parties
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("letter_activity_parties")]
        public System.Collections.Generic.IEnumerable<ActivityParty> letter_activity_parties
        {
            get { return this.GetRelatedEntities<ActivityParty>("letter_activity_parties", null); }
            set
            {
                this.OnPropertyChanging("letter_activity_parties");
                this.SetRelatedEntities<ActivityParty>("letter_activity_parties", null, value);
                this.OnPropertyChanged("letter_activity_parties");
            }
        }

        /// <summary>
        /// 1:N Letter_Annotation
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Letter_Annotation")]
        public System.Collections.Generic.IEnumerable<Annotation> Letter_Annotation
        {
            get { return this.GetRelatedEntities<Annotation>("Letter_Annotation", null); }
            set
            {
                this.OnPropertyChanging("Letter_Annotation");
                this.SetRelatedEntities<Annotation>("Letter_Annotation", null, value);
                this.OnPropertyChanged("Letter_Annotation");
            }
        }

        /// <summary>
        /// 1:N Letter_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Letter_AsyncOperations")]
        public System.Collections.Generic.IEnumerable<AsyncOperation> Letter_AsyncOperations
        {
            get { return this.GetRelatedEntities<AsyncOperation>("Letter_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("Letter_AsyncOperations");
                this.SetRelatedEntities<AsyncOperation>("Letter_AsyncOperations", null, value);
                this.OnPropertyChanged("Letter_AsyncOperations");
            }
        }

        /// <summary>
        /// 1:N Letter_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Letter_BulkDeleteFailures")]
        public System.Collections.Generic.IEnumerable<BulkDeleteFailure> Letter_BulkDeleteFailures
        {
            get { return this.GetRelatedEntities<BulkDeleteFailure>("Letter_BulkDeleteFailures", null); }
            set
            {
                this.OnPropertyChanging("Letter_BulkDeleteFailures");
                this.SetRelatedEntities<BulkDeleteFailure>("Letter_BulkDeleteFailures", null, value);
                this.OnPropertyChanged("Letter_BulkDeleteFailures");
            }
        }

        /// <summary>
        /// 1:N letter_campaignresponse
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("letter_campaignresponse")]
        public System.Collections.Generic.IEnumerable<CampaignResponse> letter_campaignresponse
        {
            get { return this.GetRelatedEntities<CampaignResponse>("letter_campaignresponse", null); }
            set
            {
                this.OnPropertyChanging("letter_campaignresponse");
                this.SetRelatedEntities<CampaignResponse>("letter_campaignresponse", null, value);
                this.OnPropertyChanged("letter_campaignresponse");
            }
        }

        /// <summary>
        /// 1:N letter_connections1
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("letter_connections1")]
        public System.Collections.Generic.IEnumerable<Connection> letter_connections1
        {
            get { return this.GetRelatedEntities<Connection>("letter_connections1", null); }
            set
            {
                this.OnPropertyChanging("letter_connections1");
                this.SetRelatedEntities<Connection>("letter_connections1", null, value);
                this.OnPropertyChanged("letter_connections1");
            }
        }

        /// <summary>
        /// 1:N letter_connections2
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("letter_connections2")]
        public System.Collections.Generic.IEnumerable<Connection> letter_connections2
        {
            get { return this.GetRelatedEntities<Connection>("letter_connections2", null); }
            set
            {
                this.OnPropertyChanging("letter_connections2");
                this.SetRelatedEntities<Connection>("letter_connections2", null, value);
                this.OnPropertyChanged("letter_connections2");
            }
        }

        /// <summary>
        /// 1:N Letter_DuplicateBaseRecord
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Letter_DuplicateBaseRecord")]
        public System.Collections.Generic.IEnumerable<DuplicateRecord> Letter_DuplicateBaseRecord
        {
            get { return this.GetRelatedEntities<DuplicateRecord>("Letter_DuplicateBaseRecord", null); }
            set
            {
                this.OnPropertyChanging("Letter_DuplicateBaseRecord");
                this.SetRelatedEntities<DuplicateRecord>("Letter_DuplicateBaseRecord", null, value);
                this.OnPropertyChanged("Letter_DuplicateBaseRecord");
            }
        }

        /// <summary>
        /// 1:N Letter_DuplicateMatchingRecord
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Letter_DuplicateMatchingRecord")]
        public System.Collections.Generic.IEnumerable<DuplicateRecord> Letter_DuplicateMatchingRecord
        {
            get { return this.GetRelatedEntities<DuplicateRecord>("Letter_DuplicateMatchingRecord", null); }
            set
            {
                this.OnPropertyChanging("Letter_DuplicateMatchingRecord");
                this.SetRelatedEntities<DuplicateRecord>("Letter_DuplicateMatchingRecord", null, value);
                this.OnPropertyChanged("Letter_DuplicateMatchingRecord");
            }
        }

        /// <summary>
        /// 1:N letter_principalobjectattributeaccess
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("letter_principalobjectattributeaccess")]
        public System.Collections.Generic.IEnumerable<PrincipalObjectAttributeAccess> letter_principalobjectattributeaccess
        {
            get { return this.GetRelatedEntities<PrincipalObjectAttributeAccess>("letter_principalobjectattributeaccess", null); }
            set
            {
                this.OnPropertyChanging("letter_principalobjectattributeaccess");
                this.SetRelatedEntities<PrincipalObjectAttributeAccess>("letter_principalobjectattributeaccess", null, value);
                this.OnPropertyChanged("letter_principalobjectattributeaccess");
            }
        }

        /// <summary>
        /// 1:N Letter_ProcessSessions
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Letter_ProcessSessions")]
        public System.Collections.Generic.IEnumerable<ProcessSession> Letter_ProcessSessions
        {
            get { return this.GetRelatedEntities<ProcessSession>("Letter_ProcessSessions", null); }
            set
            {
                this.OnPropertyChanging("Letter_ProcessSessions");
                this.SetRelatedEntities<ProcessSession>("Letter_ProcessSessions", null, value);
                this.OnPropertyChanged("Letter_ProcessSessions");
            }
        }

        /// <summary>
        /// 1:N Letter_QueueItem
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Letter_QueueItem")]
        public System.Collections.Generic.IEnumerable<QueueItem> Letter_QueueItem
        {
            get { return this.GetRelatedEntities<QueueItem>("Letter_QueueItem", null); }
            set
            {
                this.OnPropertyChanging("Letter_QueueItem");
                this.SetRelatedEntities<QueueItem>("Letter_QueueItem", null, value);
                this.OnPropertyChanged("Letter_QueueItem");
            }
        }

        /// <summary>
        /// 1:N userentityinstancedata_letter
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_letter")]
        public System.Collections.Generic.IEnumerable<UserEntityInstanceData> userentityinstancedata_letter
        {
            get { return this.GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_letter", null); }
            set
            {
                this.OnPropertyChanging("userentityinstancedata_letter");
                this.SetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_letter", null, value);
                this.OnPropertyChanged("userentityinstancedata_letter");
            }
        }

        /// <summary>
        /// N:1 Account_Letters
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Account_Letters")]
        public Account Account_Letters
        {
            get { return this.GetRelatedEntity<Account>("Account_Letters", null); }
            set
            {
                this.OnPropertyChanging("Account_Letters");
                this.SetRelatedEntity<Account>("Account_Letters", null, value);
                this.OnPropertyChanged("Account_Letters");
            }
        }

        /// <summary>
        /// N:1 activity_pointer_letter
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("activityid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("activity_pointer_letter")]
        public ActivityPointer activity_pointer_letter
        {
            get { return this.GetRelatedEntity<ActivityPointer>("activity_pointer_letter", null); }
            set
            {
                this.OnPropertyChanging("activity_pointer_letter");
                this.SetRelatedEntity<ActivityPointer>("activity_pointer_letter", null, value);
                this.OnPropertyChanged("activity_pointer_letter");
            }
        }

        /// <summary>
        /// N:1 BulkOperation_Letter
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("BulkOperation_Letter")]
        public BulkOperation BulkOperation_Letter
        {
            get { return this.GetRelatedEntity<BulkOperation>("BulkOperation_Letter", null); }
            set
            {
                this.OnPropertyChanging("BulkOperation_Letter");
                this.SetRelatedEntity<BulkOperation>("BulkOperation_Letter", null, value);
                this.OnPropertyChanged("BulkOperation_Letter");
            }
        }

        /// <summary>
        /// N:1 business_unit_letter_activities
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_letter_activities")]
        public BusinessUnit business_unit_letter_activities
        {
            get { return this.GetRelatedEntity<BusinessUnit>("business_unit_letter_activities", null); }
        }

        /// <summary>
        /// N:1 Campaign_Letters
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Campaign_Letters")]
        public Campaign Campaign_Letters
        {
            get { return this.GetRelatedEntity<Campaign>("Campaign_Letters", null); }
            set
            {
                this.OnPropertyChanging("Campaign_Letters");
                this.SetRelatedEntity<Campaign>("Campaign_Letters", null, value);
                this.OnPropertyChanged("Campaign_Letters");
            }
        }

        /// <summary>
        /// N:1 CampaignActivity_Letters
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("CampaignActivity_Letters")]
        public CampaignActivity CampaignActivity_Letters
        {
            get { return this.GetRelatedEntity<CampaignActivity>("CampaignActivity_Letters", null); }
            set
            {
                this.OnPropertyChanging("CampaignActivity_Letters");
                this.SetRelatedEntity<CampaignActivity>("CampaignActivity_Letters", null, value);
                this.OnPropertyChanged("CampaignActivity_Letters");
            }
        }

        /// <summary>
        /// N:1 Contact_Letters
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Contact_Letters")]
        public Contact Contact_Letters
        {
            get { return this.GetRelatedEntity<Contact>("Contact_Letters", null); }
            set
            {
                this.OnPropertyChanging("Contact_Letters");
                this.SetRelatedEntity<Contact>("Contact_Letters", null, value);
                this.OnPropertyChanged("Contact_Letters");
            }
        }

        /// <summary>
        /// N:1 Contract_Letters
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Contract_Letters")]
        public Contract Contract_Letters
        {
            get { return this.GetRelatedEntity<Contract>("Contract_Letters", null); }
            set
            {
                this.OnPropertyChanging("Contract_Letters");
                this.SetRelatedEntity<Contract>("Contract_Letters", null, value);
                this.OnPropertyChanged("Contract_Letters");
            }
        }

        /// <summary>
        /// N:1 entitlement_Letters
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("entitlement_Letters")]
        public Entitlement entitlement_Letters
        {
            get { return this.GetRelatedEntity<Entitlement>("entitlement_Letters", null); }
            set
            {
                this.OnPropertyChanging("entitlement_Letters");
                this.SetRelatedEntity<Entitlement>("entitlement_Letters", null, value);
                this.OnPropertyChanged("entitlement_Letters");
            }
        }

        /// <summary>
        /// N:1 entitlementtemplate_Letters
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("entitlementtemplate_Letters")]
        public EntitlementTemplate entitlementtemplate_Letters
        {
            get { return this.GetRelatedEntity<EntitlementTemplate>("entitlementtemplate_Letters", null); }
            set
            {
                this.OnPropertyChanging("entitlementtemplate_Letters");
                this.SetRelatedEntity<EntitlementTemplate>("entitlementtemplate_Letters", null, value);
                this.OnPropertyChanged("entitlementtemplate_Letters");
            }
        }

        /// <summary>
        /// N:1 Incident_Letters
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Incident_Letters")]
        public Incident Incident_Letters
        {
            get { return this.GetRelatedEntity<Incident>("Incident_Letters", null); }
            set
            {
                this.OnPropertyChanging("Incident_Letters");
                this.SetRelatedEntity<Incident>("Incident_Letters", null, value);
                this.OnPropertyChanged("Incident_Letters");
            }
        }

        /// <summary>
        /// N:1 Invoice_Letters
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Invoice_Letters")]
        public Invoice Invoice_Letters
        {
            get { return this.GetRelatedEntity<Invoice>("Invoice_Letters", null); }
            set
            {
                this.OnPropertyChanging("Invoice_Letters");
                this.SetRelatedEntity<Invoice>("Invoice_Letters", null, value);
                this.OnPropertyChanged("Invoice_Letters");
            }
        }

        /// <summary>
        /// N:1 Lead_Letters
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Lead_Letters")]
        public Lead Lead_Letters
        {
            get { return this.GetRelatedEntity<Lead>("Lead_Letters", null); }
            set
            {
                this.OnPropertyChanging("Lead_Letters");
                this.SetRelatedEntity<Lead>("Lead_Letters", null, value);
                this.OnPropertyChanged("Lead_Letters");
            }
        }

        /// <summary>
        /// N:1 lk_letter_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_letter_createdby")]
        public SystemUser lk_letter_createdby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_letter_createdby", null); }
        }

        /// <summary>
        /// N:1 lk_letter_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_letter_createdonbehalfby")]
        public SystemUser lk_letter_createdonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_letter_createdonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_letter_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_letter_modifiedby")]
        public SystemUser lk_letter_modifiedby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_letter_modifiedby", null); }
        }

        /// <summary>
        /// N:1 lk_letter_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_letter_modifiedonbehalfby")]
        public SystemUser lk_letter_modifiedonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_letter_modifiedonbehalfby", null); }
        }

        /// <summary>
        /// N:1 msdyn_postalbum_Letters
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_postalbum_Letters")]
        public msdyn_PostAlbum msdyn_postalbum_Letters
        {
            get { return this.GetRelatedEntity<msdyn_PostAlbum>("msdyn_postalbum_Letters", null); }
            set
            {
                this.OnPropertyChanging("msdyn_postalbum_Letters");
                this.SetRelatedEntity<msdyn_PostAlbum>("msdyn_postalbum_Letters", null, value);
                this.OnPropertyChanged("msdyn_postalbum_Letters");
            }
        }

        /// <summary>
        /// N:1 Opportunity_Letters
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Opportunity_Letters")]
        public Opportunity Opportunity_Letters
        {
            get { return this.GetRelatedEntity<Opportunity>("Opportunity_Letters", null); }
            set
            {
                this.OnPropertyChanging("Opportunity_Letters");
                this.SetRelatedEntity<Opportunity>("Opportunity_Letters", null, value);
                this.OnPropertyChanged("Opportunity_Letters");
            }
        }

        /// <summary>
        /// N:1 processstage_letters
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("stageid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("processstage_letters")]
        public ProcessStage processstage_letters
        {
            get { return this.GetRelatedEntity<ProcessStage>("processstage_letters", null); }
            set
            {
                this.OnPropertyChanging("processstage_letters");
                this.SetRelatedEntity<ProcessStage>("processstage_letters", null, value);
                this.OnPropertyChanged("processstage_letters");
            }
        }

        /// <summary>
        /// N:1 Quote_Letters
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Quote_Letters")]
        public Quote Quote_Letters
        {
            get { return this.GetRelatedEntity<Quote>("Quote_Letters", null); }
            set
            {
                this.OnPropertyChanging("Quote_Letters");
                this.SetRelatedEntity<Quote>("Quote_Letters", null, value);
                this.OnPropertyChanged("Quote_Letters");
            }
        }

        /// <summary>
        /// N:1 SalesOrder_Letters
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SalesOrder_Letters")]
        public SalesOrder SalesOrder_Letters
        {
            get { return this.GetRelatedEntity<SalesOrder>("SalesOrder_Letters", null); }
            set
            {
                this.OnPropertyChanging("SalesOrder_Letters");
                this.SetRelatedEntity<SalesOrder>("SalesOrder_Letters", null, value);
                this.OnPropertyChanged("SalesOrder_Letters");
            }
        }

        /// <summary>
        /// N:1 service_letters
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("serviceid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("service_letters")]
        public Service service_letters
        {
            get { return this.GetRelatedEntity<Service>("service_letters", null); }
            set
            {
                this.OnPropertyChanging("service_letters");
                this.SetRelatedEntity<Service>("service_letters", null, value);
                this.OnPropertyChanged("service_letters");
            }
        }

        /// <summary>
        /// N:1 team_letter
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_letter")]
        public Team team_letter
        {
            get { return this.GetRelatedEntity<Team>("team_letter", null); }
        }

        /// <summary>
        /// N:1 TransactionCurrency_Letter
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("TransactionCurrency_Letter")]
        public TransactionCurrency TransactionCurrency_Letter
        {
            get { return this.GetRelatedEntity<TransactionCurrency>("TransactionCurrency_Letter", null); }
            set
            {
                this.OnPropertyChanging("TransactionCurrency_Letter");
                this.SetRelatedEntity<TransactionCurrency>("TransactionCurrency_Letter", null, value);
                this.OnPropertyChanged("TransactionCurrency_Letter");
            }
        }

        /// <summary>
        /// N:1 user_letter
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_letter")]
        public SystemUser user_letter
        {
            get { return this.GetRelatedEntity<SystemUser>("user_letter", null); }
        }
    }
}