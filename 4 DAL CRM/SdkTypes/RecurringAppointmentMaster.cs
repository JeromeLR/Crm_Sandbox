using _4_DAL_CRM;

namespace __4_DAL_CRM
{
    /// <summary>
    /// The Master appointment of a recurring appointment series.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("recurringappointmentmaster")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class RecurringAppointmentMaster : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public RecurringAppointmentMaster() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "recurringappointmentmaster";

        public const int EntityTypeCode = 4251;

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
        /// Unique identifier of the recurring appointment series.
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
        /// Type a category to identify the recurring appointment type, such as status meeting or service call, to tie the appointment to a business group or function.
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
        /// The day of the month on which the recurring appointment occurs.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("dayofmonth")]
        public System.Nullable<int> DayOfMonth
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("dayofmonth"); }
            set
            {
                this.OnPropertyChanging("DayOfMonth");
                this.SetAttributeValue("dayofmonth", value);
                this.OnPropertyChanged("DayOfMonth");
            }
        }

        /// <summary>
        /// Bitmask that represents the days of the week on which the recurring appointment occurs.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("daysofweekmask")]
        public System.Nullable<int> DaysOfWeekMask
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("daysofweekmask"); }
            set
            {
                this.OnPropertyChanging("DaysOfWeekMask");
                this.SetAttributeValue("daysofweekmask", value);
                this.OnPropertyChanged("DaysOfWeekMask");
            }
        }

        /// <summary>
        /// List of deleted instances of the recurring appointment series.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("deletedexceptionslist")]
        public string DeletedExceptionsList
        {
            get { return this.GetAttributeValue<string>("deletedexceptionslist"); }
        }

        /// <summary>
        /// Type additional information to describe the recurring appointment, such as key talking points or objectives.
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
        /// Duration of the recurring appointment series in minutes.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("duration")]
        public System.Nullable<int> Duration
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("duration"); }
            set
            {
                this.OnPropertyChanging("Duration");
                this.SetAttributeValue("duration", value);
                this.OnPropertyChanged("Duration");
            }
        }

        /// <summary>
        /// Actual end date of the recurring appointment series based on the specified end date and recurrence pattern.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("effectiveenddate")]
        public System.Nullable<System.DateTime> EffectiveEndDate
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("effectiveenddate"); }
            set
            {
                this.OnPropertyChanging("EffectiveEndDate");
                this.SetAttributeValue("effectiveenddate", value);
                this.OnPropertyChanged("EffectiveEndDate");
            }
        }

        /// <summary>
        /// Actual start date of the recurring appointment series based on the specified start date and recurrence pattern.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("effectivestartdate")]
        public System.Nullable<System.DateTime> EffectiveStartDate
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("effectivestartdate"); }
            set
            {
                this.OnPropertyChanging("EffectiveStartDate");
                this.SetAttributeValue("effectivestartdate", value);
                this.OnPropertyChanged("EffectiveStartDate");
            }
        }

        /// <summary>
        /// End time of the associated activity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("endtime")]
        public System.Nullable<System.DateTime> EndTime
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("endtime"); }
            set
            {
                this.OnPropertyChanging("EndTime");
                this.SetAttributeValue("endtime", value);
                this.OnPropertyChanged("EndTime");
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
        /// State code to indicate whether the recurring appointment series is expanded fully or partially.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("expansionstatecode")]
        public Microsoft.Xrm.Sdk.OptionSetValue ExpansionStateCode
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("expansionstatecode"); }
        }

        /// <summary>
        /// First day of week for the recurrence pattern.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("firstdayofweek")]
        public System.Nullable<int> FirstDayOfWeek
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("firstdayofweek"); }
            set
            {
                this.OnPropertyChanging("FirstDayOfWeek");
                this.SetAttributeValue("firstdayofweek", value);
                this.OnPropertyChanged("FirstDayOfWeek");
            }
        }

        /// <summary>
        /// Unique Outlook identifier to correlate recurring appointment series across Exchange mailboxes.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("globalobjectid")]
        public string GlobalObjectId
        {
            get { return this.GetAttributeValue<string>("globalobjectid"); }
            set
            {
                this.OnPropertyChanging("GlobalObjectId");
                this.SetAttributeValue("globalobjectid", value);
                this.OnPropertyChanged("GlobalObjectId");
            }
        }

        /// <summary>
        /// Unique identifier of the recurring appointment series for which the recurrence information was updated. 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("groupid")]
        public Microsoft.Xrm.Sdk.EntityReference GroupId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("groupid"); }
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
        /// Specifies the recurring appointment series to occur on every Nth day of a month. Valid for monthly and yearly recurrence patterns only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("instance")]
        public Microsoft.Xrm.Sdk.OptionSetValue Instance
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("instance"); }
            set
            {
                this.OnPropertyChanging("Instance");
                this.SetAttributeValue("instance", value);
                this.OnPropertyChanged("Instance");
            }
        }

        /// <summary>
        /// Type of instance of a recurring appointment series.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("instancetypecode")]
        public Microsoft.Xrm.Sdk.OptionSetValue InstanceTypeCode
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("instancetypecode"); }
        }

        /// <summary>
        /// Number of units of a given recurrence type between occurrences.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("interval")]
        public System.Nullable<int> Interval
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("interval"); }
            set
            {
                this.OnPropertyChanging("Interval");
                this.SetAttributeValue("interval", value);
                this.OnPropertyChanged("Interval");
            }
        }

        /// <summary>
        /// Select whether the recurring appointment is an all-day event to make sure that the required resources are scheduled for the full day.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isalldayevent")]
        public System.Nullable<bool> IsAllDayEvent
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("isalldayevent"); }
            set
            {
                this.OnPropertyChanging("IsAllDayEvent");
                this.SetAttributeValue("isalldayevent", value);
                this.OnPropertyChanged("IsAllDayEvent");
            }
        }

        /// <summary>
        /// Indicates whether the recurring appointment series was billed as part of resolving a case.
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
        /// Indicates whether the recurring appointment series should occur after every N months. Valid for monthly recurrence pattern only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isnthmonthly")]
        public System.Nullable<bool> IsNthMonthly
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("isnthmonthly"); }
            set
            {
                this.OnPropertyChanging("IsNthMonthly");
                this.SetAttributeValue("isnthmonthly", value);
                this.OnPropertyChanged("IsNthMonthly");
            }
        }

        /// <summary>
        /// Indicates whether the recurring appointment series should occur after every N years. Valid for yearly recurrence pattern only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isnthyearly")]
        public System.Nullable<bool> IsNthYearly
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("isnthyearly"); }
            set
            {
                this.OnPropertyChanging("IsNthYearly");
                this.SetAttributeValue("isnthyearly", value);
                this.OnPropertyChanged("IsNthYearly");
            }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isregenerate")]
        public System.Nullable<bool> IsRegenerate
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("isregenerate"); }
            set
            {
                this.OnPropertyChanging("IsRegenerate");
                this.SetAttributeValue("isregenerate", value);
                this.OnPropertyChanged("IsRegenerate");
            }
        }

        /// <summary>
        /// Indicates whether the activity is a regular activity type or event type.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isregularactivity")]
        public System.Nullable<bool> IsRegularActivity
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("isregularactivity"); }
        }

        /// <summary>
        /// Indicates whether the weekly recurrence pattern is a daily weekday pattern. Valid for weekly recurrence pattern only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isweekdaypattern")]
        public System.Nullable<bool> IsWeekDayPattern
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("isweekdaypattern"); }
            set
            {
                this.OnPropertyChanging("IsWeekDayPattern");
                this.SetAttributeValue("isweekdaypattern", value);
                this.OnPropertyChanged("IsWeekDayPattern");
            }
        }

        /// <summary>
        /// Indicates whether the recurring appointment series was created from a workflow rule.
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
        /// Date of last expanded instance of a recurring appointment series.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("lastexpandedinstancedate")]
        public System.Nullable<System.DateTime> LastExpandedInstanceDate
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("lastexpandedinstancedate"); }
        }

        /// <summary>
        /// Type the location where the recurring appointment will take place, such as a conference room or customer office.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("location")]
        public string Location
        {
            get { return this.GetAttributeValue<string>("location"); }
            set
            {
                this.OnPropertyChanging("Location");
                this.SetAttributeValue("location", value);
                this.OnPropertyChanged("Location");
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
        /// Indicates the month of the year for the recurrence pattern.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("monthofyear")]
        public Microsoft.Xrm.Sdk.OptionSetValue MonthOfYear
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("monthofyear"); }
            set
            {
                this.OnPropertyChanging("MonthOfYear");
                this.SetAttributeValue("monthofyear", value);
                this.OnPropertyChanged("MonthOfYear");
            }
        }

        /// <summary>
        /// Date of the next expanded instance of a recurring appointment series.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("nextexpansioninstancedate")]
        public System.Nullable<System.DateTime> NextExpansionInstanceDate
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("nextexpansioninstancedate"); }
        }

        /// <summary>
        /// Number of appointment occurrences in a recurring appointment series.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("occurrences")]
        public System.Nullable<int> Occurrences
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("occurrences"); }
            set
            {
                this.OnPropertyChanging("Occurrences");
                this.SetAttributeValue("occurrences", value);
                this.OnPropertyChanged("Occurrences");
            }
        }

        /// <summary>
        /// Enter the account, contact, lead, user, or other equipment resources that are not needed at the recurring appointment, but can optionally attend.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("optionalattendees")]
        public System.Collections.Generic.IEnumerable<ActivityParty> OptionalAttendees
        {
            get
            {
                Microsoft.Xrm.Sdk.EntityCollection collection = this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityCollection>("optionalattendees");
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
                this.OnPropertyChanging("OptionalAttendees");
                if ((value == null))
                {
                    this.SetAttributeValue("optionalattendees", value);
                }
                else
                {
                    this.SetAttributeValue("optionalattendees", new Microsoft.Xrm.Sdk.EntityCollection(new System.Collections.Generic.List<Microsoft.Xrm.Sdk.Entity>(value)));
                }
                this.OnPropertyChanged("OptionalAttendees");
            }
        }

        /// <summary>
        /// Enter the user who is in charge of coordinating or leading the recurring appointment to make sure the appointment is displayed in the user's My Activities view.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizer")]
        public System.Collections.Generic.IEnumerable<ActivityParty> Organizer
        {
            get
            {
                Microsoft.Xrm.Sdk.EntityCollection collection = this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityCollection>("organizer");
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
                this.OnPropertyChanging("Organizer");
                if ((value == null))
                {
                    this.SetAttributeValue("organizer", value);
                }
                else
                {
                    this.SetAttributeValue("organizer", new Microsoft.Xrm.Sdk.EntityCollection(new System.Collections.Generic.List<Microsoft.Xrm.Sdk.Entity>(value)));
                }
                this.OnPropertyChanged("Organizer");
            }
        }

        /// <summary>
        /// Unique identifier of the Microsoft Office Outlook recurring appointment series owner that correlates to the PR_OWNER_APPT_ID MAPI property.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("outlookownerapptid")]
        public System.Nullable<int> OutlookOwnerApptId
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("outlookownerapptid"); }
            set
            {
                this.OnPropertyChanging("OutlookOwnerApptId");
                this.SetAttributeValue("outlookownerapptid", value);
                this.OnPropertyChanged("OutlookOwnerApptId");
            }
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
        /// Unique identifier of the business unit that owns the recurring appointment series.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
        public Microsoft.Xrm.Sdk.EntityReference OwningBusinessUnit
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningbusinessunit"); }
        }

        /// <summary>
        /// Unique identifier of the team who owns the recurring appointment series.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
        public Microsoft.Xrm.Sdk.EntityReference OwningTeam
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningteam"); }
        }

        /// <summary>
        /// Unique identifier of the user who owns the recurring appointment series.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
        public Microsoft.Xrm.Sdk.EntityReference OwningUser
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owninguser"); }
        }

        /// <summary>
        /// End date of the recurrence range.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("patternenddate")]
        public System.Nullable<System.DateTime> PatternEndDate
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("patternenddate"); }
            set
            {
                this.OnPropertyChanging("PatternEndDate");
                this.SetAttributeValue("patternenddate", value);
                this.OnPropertyChanged("PatternEndDate");
            }
        }

        /// <summary>
        /// Select the type of end date for the recurring appointment, such as no end date or the number of occurrences.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("patternendtype")]
        public Microsoft.Xrm.Sdk.OptionSetValue PatternEndType
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("patternendtype"); }
            set
            {
                this.OnPropertyChanging("PatternEndType");
                this.SetAttributeValue("patternendtype", value);
                this.OnPropertyChanged("PatternEndType");
            }
        }

        /// <summary>
        /// Start date of the recurrence range.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("patternstartdate")]
        public System.Nullable<System.DateTime> PatternStartDate
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("patternstartdate"); }
            set
            {
                this.OnPropertyChanging("PatternStartDate");
                this.SetAttributeValue("patternstartdate", value);
                this.OnPropertyChanged("PatternStartDate");
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
        /// Select the pattern type for the recurring appointment to indicate whether the appointment occurs daily, weekly, monthly, or yearly.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("recurrencepatterntype")]
        public Microsoft.Xrm.Sdk.OptionSetValue RecurrencePatternType
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("recurrencepatterntype"); }
            set
            {
                this.OnPropertyChanging("RecurrencePatternType");
                this.SetAttributeValue("recurrencepatterntype", value);
                this.OnPropertyChanged("RecurrencePatternType");
            }
        }

        /// <summary>
        /// Unique identifier of the object with which the recurring appointment series is associated.
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
        /// Enter the account, contact, lead, user, or other equipment resources that are required to attend the recurring appointment.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("requiredattendees")]
        public System.Collections.Generic.IEnumerable<ActivityParty> RequiredAttendees
        {
            get
            {
                Microsoft.Xrm.Sdk.EntityCollection collection = this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityCollection>("requiredattendees");
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
                this.OnPropertyChanging("RequiredAttendees");
                if ((value == null))
                {
                    this.SetAttributeValue("requiredattendees", value);
                }
                else
                {
                    this.SetAttributeValue("requiredattendees", new Microsoft.Xrm.Sdk.EntityCollection(new System.Collections.Generic.List<Microsoft.Xrm.Sdk.Entity>(value)));
                }
                this.OnPropertyChanged("RequiredAttendees");
            }
        }

        /// <summary>
        /// Unique identifier of the recurrence rule that is associated with the recurring appointment series.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ruleid")]
        public Microsoft.Xrm.Sdk.EntityReference RuleId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("ruleid"); }
        }

        /// <summary>
        /// Scheduled end time of the recurring appointment series.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("scheduledend")]
        public System.Nullable<System.DateTime> ScheduledEnd
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("scheduledend"); }
        }

        /// <summary>
        /// Scheduled start time of the recurring appointment series.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("scheduledstart")]
        public System.Nullable<System.DateTime> ScheduledStart
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("scheduledstart"); }
        }

        /// <summary>
        /// Indicates whether the recurring appointment series is active or inactive.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("seriesstatus")]
        public System.Nullable<bool> SeriesStatus
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("seriesstatus"); }
            set
            {
                this.OnPropertyChanging("SeriesStatus");
                this.SetAttributeValue("seriesstatus", value);
                this.OnPropertyChanged("SeriesStatus");
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
        /// Start time of the recurring appointment series.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("starttime")]
        public System.Nullable<System.DateTime> StartTime
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("starttime"); }
            set
            {
                this.OnPropertyChanging("StartTime");
                this.SetAttributeValue("starttime", value);
                this.OnPropertyChanged("StartTime");
            }
        }

        /// <summary>
        /// Shows whether the recurring appointment is open, scheduled, completed, or canceled. Completed and canceled appointments are read-only and can't be edited.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
        public System.Nullable<RecurringAppointmentMasterState> StateCode
        {
            get
            {
                Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
                if ((optionSet != null))
                {
                    return ((RecurringAppointmentMasterState) (System.Enum.ToObject(typeof(RecurringAppointmentMasterState), optionSet.Value)));
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
        /// Select the recurring appointment's status.
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
        /// Type a subcategory to identify the recurring appointment type and relate the activity to a specific product, sales region, business group, or other function.
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
        /// Type a short description about the objective or primary topic of the recurring appointment.
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
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
        public System.Nullable<long> VersionNumber
        {
            get { return this.GetAttributeValue<System.Nullable<long>>("versionnumber"); }
        }

        /// <summary>
        /// 1:N recurringappointmentmaster_activity_parties
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("recurringappointmentmaster_activity_parties")]
        public System.Collections.Generic.IEnumerable<ActivityParty> recurringappointmentmaster_activity_parties
        {
            get { return this.GetRelatedEntities<ActivityParty>("recurringappointmentmaster_activity_parties", null); }
            set
            {
                this.OnPropertyChanging("recurringappointmentmaster_activity_parties");
                this.SetRelatedEntities<ActivityParty>("recurringappointmentmaster_activity_parties", null, value);
                this.OnPropertyChanged("recurringappointmentmaster_activity_parties");
            }
        }

        /// <summary>
        /// 1:N RecurringAppointmentMaster_Annotation
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("RecurringAppointmentMaster_Annotation")]
        public System.Collections.Generic.IEnumerable<Annotation> RecurringAppointmentMaster_Annotation
        {
            get { return this.GetRelatedEntities<Annotation>("RecurringAppointmentMaster_Annotation", null); }
            set
            {
                this.OnPropertyChanging("RecurringAppointmentMaster_Annotation");
                this.SetRelatedEntities<Annotation>("RecurringAppointmentMaster_Annotation", null, value);
                this.OnPropertyChanged("RecurringAppointmentMaster_Annotation");
            }
        }

        /// <summary>
        /// 1:N recurringappointmentmaster_appointment
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("recurringappointmentmaster_appointment")]
        public System.Collections.Generic.IEnumerable<Appointment> recurringappointmentmaster_appointment
        {
            get { return this.GetRelatedEntities<Appointment>("recurringappointmentmaster_appointment", null); }
            set
            {
                this.OnPropertyChanging("recurringappointmentmaster_appointment");
                this.SetRelatedEntities<Appointment>("recurringappointmentmaster_appointment", null, value);
                this.OnPropertyChanged("recurringappointmentmaster_appointment");
            }
        }

        /// <summary>
        /// 1:N RecurringAppointmentMaster_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("RecurringAppointmentMaster_AsyncOperations")]
        public System.Collections.Generic.IEnumerable<AsyncOperation> RecurringAppointmentMaster_AsyncOperations
        {
            get { return this.GetRelatedEntities<AsyncOperation>("RecurringAppointmentMaster_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("RecurringAppointmentMaster_AsyncOperations");
                this.SetRelatedEntities<AsyncOperation>("RecurringAppointmentMaster_AsyncOperations", null, value);
                this.OnPropertyChanged("RecurringAppointmentMaster_AsyncOperations");
            }
        }

        /// <summary>
        /// 1:N RecurringAppointmentMaster_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("RecurringAppointmentMaster_BulkDeleteFailures")]
        public System.Collections.Generic.IEnumerable<BulkDeleteFailure> RecurringAppointmentMaster_BulkDeleteFailures
        {
            get { return this.GetRelatedEntities<BulkDeleteFailure>("RecurringAppointmentMaster_BulkDeleteFailures", null); }
            set
            {
                this.OnPropertyChanging("RecurringAppointmentMaster_BulkDeleteFailures");
                this.SetRelatedEntities<BulkDeleteFailure>("RecurringAppointmentMaster_BulkDeleteFailures", null, value);
                this.OnPropertyChanged("RecurringAppointmentMaster_BulkDeleteFailures");
            }
        }

        /// <summary>
        /// 1:N recurringappointmentmaster_campaignresponse
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("recurringappointmentmaster_campaignresponse")]
        public System.Collections.Generic.IEnumerable<CampaignResponse> recurringappointmentmaster_campaignresponse
        {
            get { return this.GetRelatedEntities<CampaignResponse>("recurringappointmentmaster_campaignresponse", null); }
            set
            {
                this.OnPropertyChanging("recurringappointmentmaster_campaignresponse");
                this.SetRelatedEntities<CampaignResponse>("recurringappointmentmaster_campaignresponse", null, value);
                this.OnPropertyChanged("recurringappointmentmaster_campaignresponse");
            }
        }

        /// <summary>
        /// 1:N recurringappointmentmaster_connections1
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("recurringappointmentmaster_connections1")]
        public System.Collections.Generic.IEnumerable<Connection> recurringappointmentmaster_connections1
        {
            get { return this.GetRelatedEntities<Connection>("recurringappointmentmaster_connections1", null); }
            set
            {
                this.OnPropertyChanging("recurringappointmentmaster_connections1");
                this.SetRelatedEntities<Connection>("recurringappointmentmaster_connections1", null, value);
                this.OnPropertyChanged("recurringappointmentmaster_connections1");
            }
        }

        /// <summary>
        /// 1:N recurringappointmentmaster_connections2
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("recurringappointmentmaster_connections2")]
        public System.Collections.Generic.IEnumerable<Connection> recurringappointmentmaster_connections2
        {
            get { return this.GetRelatedEntities<Connection>("recurringappointmentmaster_connections2", null); }
            set
            {
                this.OnPropertyChanging("recurringappointmentmaster_connections2");
                this.SetRelatedEntities<Connection>("recurringappointmentmaster_connections2", null, value);
                this.OnPropertyChanged("recurringappointmentmaster_connections2");
            }
        }

        /// <summary>
        /// 1:N RecurringAppointmentMaster_DuplicateBaseRecord
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("RecurringAppointmentMaster_DuplicateBaseRecord")]
        public System.Collections.Generic.IEnumerable<DuplicateRecord> RecurringAppointmentMaster_DuplicateBaseRecord
        {
            get { return this.GetRelatedEntities<DuplicateRecord>("RecurringAppointmentMaster_DuplicateBaseRecord", null); }
            set
            {
                this.OnPropertyChanging("RecurringAppointmentMaster_DuplicateBaseRecord");
                this.SetRelatedEntities<DuplicateRecord>("RecurringAppointmentMaster_DuplicateBaseRecord", null, value);
                this.OnPropertyChanged("RecurringAppointmentMaster_DuplicateBaseRecord");
            }
        }

        /// <summary>
        /// 1:N RecurringAppointmentMaster_DuplicateMatchingRecord
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("RecurringAppointmentMaster_DuplicateMatchingRecord")]
        public System.Collections.Generic.IEnumerable<DuplicateRecord> RecurringAppointmentMaster_DuplicateMatchingRecord
        {
            get { return this.GetRelatedEntities<DuplicateRecord>("RecurringAppointmentMaster_DuplicateMatchingRecord", null); }
            set
            {
                this.OnPropertyChanging("RecurringAppointmentMaster_DuplicateMatchingRecord");
                this.SetRelatedEntities<DuplicateRecord>("RecurringAppointmentMaster_DuplicateMatchingRecord", null, value);
                this.OnPropertyChanged("RecurringAppointmentMaster_DuplicateMatchingRecord");
            }
        }

        /// <summary>
        /// 1:N recurringappointmentmaster_PostFollows
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("recurringappointmentmaster_PostFollows")]
        public System.Collections.Generic.IEnumerable<PostFollow> recurringappointmentmaster_PostFollows
        {
            get { return this.GetRelatedEntities<PostFollow>("recurringappointmentmaster_PostFollows", null); }
            set
            {
                this.OnPropertyChanging("recurringappointmentmaster_PostFollows");
                this.SetRelatedEntities<PostFollow>("recurringappointmentmaster_PostFollows", null, value);
                this.OnPropertyChanged("recurringappointmentmaster_PostFollows");
            }
        }

        /// <summary>
        /// 1:N recurringappointmentmaster_principalobjectattributeaccess
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("recurringappointmentmaster_principalobjectattributeaccess")]
        public System.Collections.Generic.IEnumerable<PrincipalObjectAttributeAccess> recurringappointmentmaster_principalobjectattributeaccess
        {
            get { return this.GetRelatedEntities<PrincipalObjectAttributeAccess>("recurringappointmentmaster_principalobjectattributeaccess", null); }
            set
            {
                this.OnPropertyChanging("recurringappointmentmaster_principalobjectattributeaccess");
                this.SetRelatedEntities<PrincipalObjectAttributeAccess>("recurringappointmentmaster_principalobjectattributeaccess", null, value);
                this.OnPropertyChanged("recurringappointmentmaster_principalobjectattributeaccess");
            }
        }

        /// <summary>
        /// 1:N RecurringAppointmentMaster_ProcessSessions
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("RecurringAppointmentMaster_ProcessSessions")]
        public System.Collections.Generic.IEnumerable<ProcessSession> RecurringAppointmentMaster_ProcessSessions
        {
            get { return this.GetRelatedEntities<ProcessSession>("RecurringAppointmentMaster_ProcessSessions", null); }
            set
            {
                this.OnPropertyChanging("RecurringAppointmentMaster_ProcessSessions");
                this.SetRelatedEntities<ProcessSession>("RecurringAppointmentMaster_ProcessSessions", null, value);
                this.OnPropertyChanged("RecurringAppointmentMaster_ProcessSessions");
            }
        }

        /// <summary>
        /// 1:N RecurringAppointmentMaster_QueueItem
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("RecurringAppointmentMaster_QueueItem")]
        public System.Collections.Generic.IEnumerable<QueueItem> RecurringAppointmentMaster_QueueItem
        {
            get { return this.GetRelatedEntities<QueueItem>("RecurringAppointmentMaster_QueueItem", null); }
            set
            {
                this.OnPropertyChanging("RecurringAppointmentMaster_QueueItem");
                this.SetRelatedEntities<QueueItem>("RecurringAppointmentMaster_QueueItem", null, value);
                this.OnPropertyChanged("RecurringAppointmentMaster_QueueItem");
            }
        }

        /// <summary>
        /// 1:N userentityinstancedata_recurringappointmentmaster
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_recurringappointmentmaster")]
        public System.Collections.Generic.IEnumerable<UserEntityInstanceData> userentityinstancedata_recurringappointmentmaster
        {
            get { return this.GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_recurringappointmentmaster", null); }
            set
            {
                this.OnPropertyChanging("userentityinstancedata_recurringappointmentmaster");
                this.SetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_recurringappointmentmaster", null, value);
                this.OnPropertyChanged("userentityinstancedata_recurringappointmentmaster");
            }
        }

        /// <summary>
        /// N:1 Account_RecurringAppointmentMasters
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Account_RecurringAppointmentMasters")]
        public Account Account_RecurringAppointmentMasters
        {
            get { return this.GetRelatedEntity<Account>("Account_RecurringAppointmentMasters", null); }
            set
            {
                this.OnPropertyChanging("Account_RecurringAppointmentMasters");
                this.SetRelatedEntity<Account>("Account_RecurringAppointmentMasters", null, value);
                this.OnPropertyChanged("Account_RecurringAppointmentMasters");
            }
        }

        /// <summary>
        /// N:1 activity_pointer_recurringappointmentmaster
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("activityid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("activity_pointer_recurringappointmentmaster")]
        public ActivityPointer activity_pointer_recurringappointmentmaster
        {
            get { return this.GetRelatedEntity<ActivityPointer>("activity_pointer_recurringappointmentmaster", null); }
            set
            {
                this.OnPropertyChanging("activity_pointer_recurringappointmentmaster");
                this.SetRelatedEntity<ActivityPointer>("activity_pointer_recurringappointmentmaster", null, value);
                this.OnPropertyChanged("activity_pointer_recurringappointmentmaster");
            }
        }

        /// <summary>
        /// N:1 BulkOperation_RecurringAppointmentMaster
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("BulkOperation_RecurringAppointmentMaster")]
        public BulkOperation BulkOperation_RecurringAppointmentMaster
        {
            get { return this.GetRelatedEntity<BulkOperation>("BulkOperation_RecurringAppointmentMaster", null); }
            set
            {
                this.OnPropertyChanging("BulkOperation_RecurringAppointmentMaster");
                this.SetRelatedEntity<BulkOperation>("BulkOperation_RecurringAppointmentMaster", null, value);
                this.OnPropertyChanged("BulkOperation_RecurringAppointmentMaster");
            }
        }

        /// <summary>
        /// N:1 business_unit_recurringappointmentmaster_activities
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_recurringappointmentmaster_activities")]
        public BusinessUnit business_unit_recurringappointmentmaster_activities
        {
            get { return this.GetRelatedEntity<BusinessUnit>("business_unit_recurringappointmentmaster_activities", null); }
        }

        /// <summary>
        /// N:1 Campaign_RecurringAppointmentMasters
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Campaign_RecurringAppointmentMasters")]
        public Campaign Campaign_RecurringAppointmentMasters
        {
            get { return this.GetRelatedEntity<Campaign>("Campaign_RecurringAppointmentMasters", null); }
            set
            {
                this.OnPropertyChanging("Campaign_RecurringAppointmentMasters");
                this.SetRelatedEntity<Campaign>("Campaign_RecurringAppointmentMasters", null, value);
                this.OnPropertyChanged("Campaign_RecurringAppointmentMasters");
            }
        }

        /// <summary>
        /// N:1 CampaignActivity_RecurringAppointmentMasters
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("CampaignActivity_RecurringAppointmentMasters")]
        public CampaignActivity CampaignActivity_RecurringAppointmentMasters
        {
            get { return this.GetRelatedEntity<CampaignActivity>("CampaignActivity_RecurringAppointmentMasters", null); }
            set
            {
                this.OnPropertyChanging("CampaignActivity_RecurringAppointmentMasters");
                this.SetRelatedEntity<CampaignActivity>("CampaignActivity_RecurringAppointmentMasters", null, value);
                this.OnPropertyChanged("CampaignActivity_RecurringAppointmentMasters");
            }
        }

        /// <summary>
        /// N:1 Contact_RecurringAppointmentMasters
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Contact_RecurringAppointmentMasters")]
        public Contact Contact_RecurringAppointmentMasters
        {
            get { return this.GetRelatedEntity<Contact>("Contact_RecurringAppointmentMasters", null); }
            set
            {
                this.OnPropertyChanging("Contact_RecurringAppointmentMasters");
                this.SetRelatedEntity<Contact>("Contact_RecurringAppointmentMasters", null, value);
                this.OnPropertyChanged("Contact_RecurringAppointmentMasters");
            }
        }

        /// <summary>
        /// N:1 Contract_RecurringAppointmentMasters
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Contract_RecurringAppointmentMasters")]
        public Contract Contract_RecurringAppointmentMasters
        {
            get { return this.GetRelatedEntity<Contract>("Contract_RecurringAppointmentMasters", null); }
            set
            {
                this.OnPropertyChanging("Contract_RecurringAppointmentMasters");
                this.SetRelatedEntity<Contract>("Contract_RecurringAppointmentMasters", null, value);
                this.OnPropertyChanged("Contract_RecurringAppointmentMasters");
            }
        }

        /// <summary>
        /// N:1 entitlement_RecurringAppointmentMasters
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("entitlement_RecurringAppointmentMasters")]
        public Entitlement entitlement_RecurringAppointmentMasters
        {
            get { return this.GetRelatedEntity<Entitlement>("entitlement_RecurringAppointmentMasters", null); }
            set
            {
                this.OnPropertyChanging("entitlement_RecurringAppointmentMasters");
                this.SetRelatedEntity<Entitlement>("entitlement_RecurringAppointmentMasters", null, value);
                this.OnPropertyChanged("entitlement_RecurringAppointmentMasters");
            }
        }

        /// <summary>
        /// N:1 entitlementtemplate_RecurringAppointmentMasters
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("entitlementtemplate_RecurringAppointmentMasters")]
        public EntitlementTemplate entitlementtemplate_RecurringAppointmentMasters
        {
            get { return this.GetRelatedEntity<EntitlementTemplate>("entitlementtemplate_RecurringAppointmentMasters", null); }
            set
            {
                this.OnPropertyChanging("entitlementtemplate_RecurringAppointmentMasters");
                this.SetRelatedEntity<EntitlementTemplate>("entitlementtemplate_RecurringAppointmentMasters", null, value);
                this.OnPropertyChanged("entitlementtemplate_RecurringAppointmentMasters");
            }
        }

        /// <summary>
        /// N:1 Incident_RecurringAppointmentMasters
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Incident_RecurringAppointmentMasters")]
        public Incident Incident_RecurringAppointmentMasters
        {
            get { return this.GetRelatedEntity<Incident>("Incident_RecurringAppointmentMasters", null); }
            set
            {
                this.OnPropertyChanging("Incident_RecurringAppointmentMasters");
                this.SetRelatedEntity<Incident>("Incident_RecurringAppointmentMasters", null, value);
                this.OnPropertyChanged("Incident_RecurringAppointmentMasters");
            }
        }

        /// <summary>
        /// N:1 Invoice_RecurringAppointmentMasters
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Invoice_RecurringAppointmentMasters")]
        public Invoice Invoice_RecurringAppointmentMasters
        {
            get { return this.GetRelatedEntity<Invoice>("Invoice_RecurringAppointmentMasters", null); }
            set
            {
                this.OnPropertyChanging("Invoice_RecurringAppointmentMasters");
                this.SetRelatedEntity<Invoice>("Invoice_RecurringAppointmentMasters", null, value);
                this.OnPropertyChanged("Invoice_RecurringAppointmentMasters");
            }
        }

        /// <summary>
        /// N:1 Lead_RecurringAppointmentMasters
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Lead_RecurringAppointmentMasters")]
        public Lead Lead_RecurringAppointmentMasters
        {
            get { return this.GetRelatedEntity<Lead>("Lead_RecurringAppointmentMasters", null); }
            set
            {
                this.OnPropertyChanging("Lead_RecurringAppointmentMasters");
                this.SetRelatedEntity<Lead>("Lead_RecurringAppointmentMasters", null, value);
                this.OnPropertyChanged("Lead_RecurringAppointmentMasters");
            }
        }

        /// <summary>
        /// N:1 lk_recurringappointmentmaster_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_recurringappointmentmaster_createdby")]
        public SystemUser lk_recurringappointmentmaster_createdby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_recurringappointmentmaster_createdby", null); }
        }

        /// <summary>
        /// N:1 lk_recurringappointmentmaster_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_recurringappointmentmaster_createdonbehalfby")]
        public SystemUser lk_recurringappointmentmaster_createdonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_recurringappointmentmaster_createdonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_recurringappointmentmaster_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_recurringappointmentmaster_modifiedby")]
        public SystemUser lk_recurringappointmentmaster_modifiedby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_recurringappointmentmaster_modifiedby", null); }
        }

        /// <summary>
        /// N:1 lk_recurringappointmentmaster_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_recurringappointmentmaster_modifiedonbehalfby")]
        public SystemUser lk_recurringappointmentmaster_modifiedonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_recurringappointmentmaster_modifiedonbehalfby", null); }
        }

        /// <summary>
        /// N:1 msdyn_postalbum_RecurringAppointmentMasters
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_postalbum_RecurringAppointmentMasters")]
        public msdyn_PostAlbum msdyn_postalbum_RecurringAppointmentMasters
        {
            get { return this.GetRelatedEntity<msdyn_PostAlbum>("msdyn_postalbum_RecurringAppointmentMasters", null); }
            set
            {
                this.OnPropertyChanging("msdyn_postalbum_RecurringAppointmentMasters");
                this.SetRelatedEntity<msdyn_PostAlbum>("msdyn_postalbum_RecurringAppointmentMasters", null, value);
                this.OnPropertyChanged("msdyn_postalbum_RecurringAppointmentMasters");
            }
        }

        /// <summary>
        /// N:1 Opportunity_RecurringAppointmentMasters
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Opportunity_RecurringAppointmentMasters")]
        public Opportunity Opportunity_RecurringAppointmentMasters
        {
            get { return this.GetRelatedEntity<Opportunity>("Opportunity_RecurringAppointmentMasters", null); }
            set
            {
                this.OnPropertyChanging("Opportunity_RecurringAppointmentMasters");
                this.SetRelatedEntity<Opportunity>("Opportunity_RecurringAppointmentMasters", null, value);
                this.OnPropertyChanged("Opportunity_RecurringAppointmentMasters");
            }
        }

        /// <summary>
        /// N:1 processstage_recurringappointmentmasters
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("stageid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("processstage_recurringappointmentmasters")]
        public ProcessStage processstage_recurringappointmentmasters
        {
            get { return this.GetRelatedEntity<ProcessStage>("processstage_recurringappointmentmasters", null); }
            set
            {
                this.OnPropertyChanging("processstage_recurringappointmentmasters");
                this.SetRelatedEntity<ProcessStage>("processstage_recurringappointmentmasters", null, value);
                this.OnPropertyChanged("processstage_recurringappointmentmasters");
            }
        }

        /// <summary>
        /// N:1 Quote_RecurringAppointmentMasters
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Quote_RecurringAppointmentMasters")]
        public Quote Quote_RecurringAppointmentMasters
        {
            get { return this.GetRelatedEntity<Quote>("Quote_RecurringAppointmentMasters", null); }
            set
            {
                this.OnPropertyChanging("Quote_RecurringAppointmentMasters");
                this.SetRelatedEntity<Quote>("Quote_RecurringAppointmentMasters", null, value);
                this.OnPropertyChanged("Quote_RecurringAppointmentMasters");
            }
        }

        /// <summary>
        /// N:1 recurrencerule_recurringappointmentmaster
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("activityid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("recurrencerule_recurringappointmentmaster")]
        public RecurrenceRule recurrencerule_recurringappointmentmaster
        {
            get { return this.GetRelatedEntity<RecurrenceRule>("recurrencerule_recurringappointmentmaster", null); }
            set
            {
                this.OnPropertyChanging("recurrencerule_recurringappointmentmaster");
                this.SetRelatedEntity<RecurrenceRule>("recurrencerule_recurringappointmentmaster", null, value);
                this.OnPropertyChanged("recurrencerule_recurringappointmentmaster");
            }
        }

        /// <summary>
        /// N:1 SalesOrder_RecurringAppointmentMasters
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SalesOrder_RecurringAppointmentMasters")]
        public SalesOrder SalesOrder_RecurringAppointmentMasters
        {
            get { return this.GetRelatedEntity<SalesOrder>("SalesOrder_RecurringAppointmentMasters", null); }
            set
            {
                this.OnPropertyChanging("SalesOrder_RecurringAppointmentMasters");
                this.SetRelatedEntity<SalesOrder>("SalesOrder_RecurringAppointmentMasters", null, value);
                this.OnPropertyChanged("SalesOrder_RecurringAppointmentMasters");
            }
        }

        /// <summary>
        /// N:1 service_recurringappointmentmasters
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("serviceid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("service_recurringappointmentmasters")]
        public Service service_recurringappointmentmasters
        {
            get { return this.GetRelatedEntity<Service>("service_recurringappointmentmasters", null); }
            set
            {
                this.OnPropertyChanging("service_recurringappointmentmasters");
                this.SetRelatedEntity<Service>("service_recurringappointmentmasters", null, value);
                this.OnPropertyChanged("service_recurringappointmentmasters");
            }
        }

        /// <summary>
        /// N:1 team_recurringappointmentmaster
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_recurringappointmentmaster")]
        public Team team_recurringappointmentmaster
        {
            get { return this.GetRelatedEntity<Team>("team_recurringappointmentmaster", null); }
        }

        /// <summary>
        /// N:1 TransactionCurrency_RecurringAppointmentMaster
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("TransactionCurrency_RecurringAppointmentMaster")]
        public TransactionCurrency TransactionCurrency_RecurringAppointmentMaster
        {
            get { return this.GetRelatedEntity<TransactionCurrency>("TransactionCurrency_RecurringAppointmentMaster", null); }
            set
            {
                this.OnPropertyChanging("TransactionCurrency_RecurringAppointmentMaster");
                this.SetRelatedEntity<TransactionCurrency>("TransactionCurrency_RecurringAppointmentMaster", null, value);
                this.OnPropertyChanged("TransactionCurrency_RecurringAppointmentMaster");
            }
        }

        /// <summary>
        /// N:1 user_recurringappointmentmaster
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_recurringappointmentmaster")]
        public SystemUser user_recurringappointmentmaster
        {
            get { return this.GetRelatedEntity<SystemUser>("user_recurringappointmentmaster", null); }
        }
    }
}