using _4_DAL_CRM;

namespace __4_DAL_CRM
{
    /// <summary>
    /// Commitment representing a time interval with start/end times and duration.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("appointment")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class Appointment : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public Appointment() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "appointment";

        public const int EntityTypeCode = 4201;

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
        /// Unique identifier of the appointment.
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
        /// Shows the value selected in the Duration field on the appointment at the time that the appointment is closed as completed. The duration is used to report the time spent on the activity.
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
        /// Enter the actual end date and time of the appointment. By default, it displays the date and time when the activity was completed or canceled, but can be edited to capture the actual duration of the appointment.
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
        /// Enter the actual start date and time for the appointment. By default, it displays the date and time when the activity was created, but can be edited to capture the actual duration of the appointment.
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
        /// Shows the number of attachments on the appointment.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("attachmentcount")]
        public System.Nullable<int> AttachmentCount
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("attachmentcount"); }
        }

        /// <summary>
        /// Select the error code to identify issues with the outlook item recipients or attachments, such as blocked attachments.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("attachmenterrors")]
        public Microsoft.Xrm.Sdk.OptionSetValue AttachmentErrors
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("attachmenterrors"); }
            set
            {
                this.OnPropertyChanging("AttachmentErrors");
                this.SetAttributeValue("attachmenterrors", value);
                this.OnPropertyChanged("AttachmentErrors");
            }
        }

        /// <summary>
        /// Type a category to identify the appointment type, such as sales demo, prospect call, or service call, to tie the appointment to a business group or function.
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
        /// Type additional information to describe the purpose of the appointment.
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
        /// Shows the ID of the appointment in Microsoft Office Outlook. The ID is used to synchronize the appointment between Microsoft Dynamics CRM and the correct Exchange account.
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
        /// Type of instance of a recurring series.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("instancetypecode")]
        public Microsoft.Xrm.Sdk.OptionSetValue InstanceTypeCode
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("instancetypecode"); }
        }

        /// <summary>
        /// Select whether the appointment is an all-day event to make sure that the required resources are scheduled for the full day.
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
        /// Information regarding whether the appointment was billed as part of resolving a case.
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
        /// Information regarding whether the appointment was created from a workflow rule.
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
        /// Type the location where the appointment will take place, such as a conference room or customer office.
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
        /// For internal use only. 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedfieldsmask")]
        public string ModifiedFieldsMask
        {
            get { return this.GetAttributeValue<string>("modifiedfieldsmask"); }
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
        /// Shows who created the record on behalf of another user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        /// Enter the account, contact, lead, user, or other equipment resources that are not needed at the appointment, but can optionally attend.
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
        /// Enter the user who is in charge of coordinating or leading the appointment to make sure the appointment is displayed in the user's My Activities view.
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
        /// The original start date of the appointment.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("originalstartdate")]
        public System.Nullable<System.DateTime> OriginalStartDate
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("originalstartdate"); }
        }

        /// <summary>
        /// Unique identifier of the Microsoft Office Outlook appointment owner that correlates to the PR_OWNER_APPT_ID MAPI property.
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
        /// Shows the business unit that the record owner belongs to.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
        public Microsoft.Xrm.Sdk.EntityReference OwningBusinessUnit
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningbusinessunit"); }
        }

        /// <summary>
        /// Unique identifier of the team that owns the appointment.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
        public Microsoft.Xrm.Sdk.EntityReference OwningTeam
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningteam"); }
        }

        /// <summary>
        /// Unique identifier of the user that owns the appointment.
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
        /// Unique identifier of the object with which the appointment is associated.
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
        /// Enter the account, contact, lead, user, or other equipment resources that are required to attend the appointment.
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
        /// Shows the expected duration of the appointment, in minutes.
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
        /// Enter the expected due date and time for the activity to be completed to provide details about the timing of the appointment.
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
        /// Enter the expected start date and time for the activity to provide details about the timing of the appointment.
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
        /// Shows the ID of the recurring series of an instance.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("seriesid")]
        public System.Nullable<System.Guid> SeriesId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("seriesid"); }
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
        /// Shows whether the appointment is open, completed, or canceled. Completed and canceled appointments are read-only and can't be edited.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
        public System.Nullable<AppointmentState> StateCode
        {
            get
            {
                Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
                if ((optionSet != null))
                {
                    return ((AppointmentState) (System.Enum.ToObject(typeof(AppointmentState), optionSet.Value)));
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// Select the appointment's status.
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
        /// Type a subcategory to identify the appointment type and relate the activity to a specific product, sales region, business group, or other function.
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
        /// Type a short description about the objective or primary topic of the appointment.
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
        /// Version number of the appointment.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
        public System.Nullable<long> VersionNumber
        {
            get { return this.GetAttributeValue<System.Nullable<long>>("versionnumber"); }
        }

        /// <summary>
        /// 1:N appointment_activity_mime_attachment
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("appointment_activity_mime_attachment")]
        public System.Collections.Generic.IEnumerable<ActivityMimeAttachment> appointment_activity_mime_attachment
        {
            get { return this.GetRelatedEntities<ActivityMimeAttachment>("appointment_activity_mime_attachment", null); }
            set
            {
                this.OnPropertyChanging("appointment_activity_mime_attachment");
                this.SetRelatedEntities<ActivityMimeAttachment>("appointment_activity_mime_attachment", null, value);
                this.OnPropertyChanged("appointment_activity_mime_attachment");
            }
        }

        /// <summary>
        /// 1:N appointment_activity_parties
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("appointment_activity_parties")]
        public System.Collections.Generic.IEnumerable<ActivityParty> appointment_activity_parties
        {
            get { return this.GetRelatedEntities<ActivityParty>("appointment_activity_parties", null); }
            set
            {
                this.OnPropertyChanging("appointment_activity_parties");
                this.SetRelatedEntities<ActivityParty>("appointment_activity_parties", null, value);
                this.OnPropertyChanged("appointment_activity_parties");
            }
        }

        /// <summary>
        /// 1:N Appointment_Annotation
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Appointment_Annotation")]
        public System.Collections.Generic.IEnumerable<Annotation> Appointment_Annotation
        {
            get { return this.GetRelatedEntities<Annotation>("Appointment_Annotation", null); }
            set
            {
                this.OnPropertyChanging("Appointment_Annotation");
                this.SetRelatedEntities<Annotation>("Appointment_Annotation", null, value);
                this.OnPropertyChanged("Appointment_Annotation");
            }
        }

        /// <summary>
        /// 1:N Appointment_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Appointment_AsyncOperations")]
        public System.Collections.Generic.IEnumerable<AsyncOperation> Appointment_AsyncOperations
        {
            get { return this.GetRelatedEntities<AsyncOperation>("Appointment_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("Appointment_AsyncOperations");
                this.SetRelatedEntities<AsyncOperation>("Appointment_AsyncOperations", null, value);
                this.OnPropertyChanged("Appointment_AsyncOperations");
            }
        }

        /// <summary>
        /// 1:N Appointment_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Appointment_BulkDeleteFailures")]
        public System.Collections.Generic.IEnumerable<BulkDeleteFailure> Appointment_BulkDeleteFailures
        {
            get { return this.GetRelatedEntities<BulkDeleteFailure>("Appointment_BulkDeleteFailures", null); }
            set
            {
                this.OnPropertyChanging("Appointment_BulkDeleteFailures");
                this.SetRelatedEntities<BulkDeleteFailure>("Appointment_BulkDeleteFailures", null, value);
                this.OnPropertyChanged("Appointment_BulkDeleteFailures");
            }
        }

        /// <summary>
        /// 1:N appointment_campaignresponse
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("appointment_campaignresponse")]
        public System.Collections.Generic.IEnumerable<CampaignResponse> appointment_campaignresponse
        {
            get { return this.GetRelatedEntities<CampaignResponse>("appointment_campaignresponse", null); }
            set
            {
                this.OnPropertyChanging("appointment_campaignresponse");
                this.SetRelatedEntities<CampaignResponse>("appointment_campaignresponse", null, value);
                this.OnPropertyChanged("appointment_campaignresponse");
            }
        }

        /// <summary>
        /// 1:N appointment_connections1
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("appointment_connections1")]
        public System.Collections.Generic.IEnumerable<Connection> appointment_connections1
        {
            get { return this.GetRelatedEntities<Connection>("appointment_connections1", null); }
            set
            {
                this.OnPropertyChanging("appointment_connections1");
                this.SetRelatedEntities<Connection>("appointment_connections1", null, value);
                this.OnPropertyChanged("appointment_connections1");
            }
        }

        /// <summary>
        /// 1:N appointment_connections2
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("appointment_connections2")]
        public System.Collections.Generic.IEnumerable<Connection> appointment_connections2
        {
            get { return this.GetRelatedEntities<Connection>("appointment_connections2", null); }
            set
            {
                this.OnPropertyChanging("appointment_connections2");
                this.SetRelatedEntities<Connection>("appointment_connections2", null, value);
                this.OnPropertyChanged("appointment_connections2");
            }
        }

        /// <summary>
        /// 1:N Appointment_DuplicateBaseRecord
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Appointment_DuplicateBaseRecord")]
        public System.Collections.Generic.IEnumerable<DuplicateRecord> Appointment_DuplicateBaseRecord
        {
            get { return this.GetRelatedEntities<DuplicateRecord>("Appointment_DuplicateBaseRecord", null); }
            set
            {
                this.OnPropertyChanging("Appointment_DuplicateBaseRecord");
                this.SetRelatedEntities<DuplicateRecord>("Appointment_DuplicateBaseRecord", null, value);
                this.OnPropertyChanged("Appointment_DuplicateBaseRecord");
            }
        }

        /// <summary>
        /// 1:N Appointment_DuplicateMatchingRecord
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Appointment_DuplicateMatchingRecord")]
        public System.Collections.Generic.IEnumerable<DuplicateRecord> Appointment_DuplicateMatchingRecord
        {
            get { return this.GetRelatedEntities<DuplicateRecord>("Appointment_DuplicateMatchingRecord", null); }
            set
            {
                this.OnPropertyChanging("Appointment_DuplicateMatchingRecord");
                this.SetRelatedEntities<DuplicateRecord>("Appointment_DuplicateMatchingRecord", null, value);
                this.OnPropertyChanged("Appointment_DuplicateMatchingRecord");
            }
        }

        /// <summary>
        /// 1:N appointment_PostFollows
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("appointment_PostFollows")]
        public System.Collections.Generic.IEnumerable<PostFollow> appointment_PostFollows
        {
            get { return this.GetRelatedEntities<PostFollow>("appointment_PostFollows", null); }
            set
            {
                this.OnPropertyChanging("appointment_PostFollows");
                this.SetRelatedEntities<PostFollow>("appointment_PostFollows", null, value);
                this.OnPropertyChanged("appointment_PostFollows");
            }
        }

        /// <summary>
        /// 1:N appointment_principalobjectattributeaccess
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("appointment_principalobjectattributeaccess")]
        public System.Collections.Generic.IEnumerable<PrincipalObjectAttributeAccess> appointment_principalobjectattributeaccess
        {
            get { return this.GetRelatedEntities<PrincipalObjectAttributeAccess>("appointment_principalobjectattributeaccess", null); }
            set
            {
                this.OnPropertyChanging("appointment_principalobjectattributeaccess");
                this.SetRelatedEntities<PrincipalObjectAttributeAccess>("appointment_principalobjectattributeaccess", null, value);
                this.OnPropertyChanged("appointment_principalobjectattributeaccess");
            }
        }

        /// <summary>
        /// 1:N Appointment_ProcessSessions
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Appointment_ProcessSessions")]
        public System.Collections.Generic.IEnumerable<ProcessSession> Appointment_ProcessSessions
        {
            get { return this.GetRelatedEntities<ProcessSession>("Appointment_ProcessSessions", null); }
            set
            {
                this.OnPropertyChanging("Appointment_ProcessSessions");
                this.SetRelatedEntities<ProcessSession>("Appointment_ProcessSessions", null, value);
                this.OnPropertyChanged("Appointment_ProcessSessions");
            }
        }

        /// <summary>
        /// 1:N Appointment_QueueItem
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Appointment_QueueItem")]
        public System.Collections.Generic.IEnumerable<QueueItem> Appointment_QueueItem
        {
            get { return this.GetRelatedEntities<QueueItem>("Appointment_QueueItem", null); }
            set
            {
                this.OnPropertyChanging("Appointment_QueueItem");
                this.SetRelatedEntities<QueueItem>("Appointment_QueueItem", null, value);
                this.OnPropertyChanged("Appointment_QueueItem");
            }
        }

        /// <summary>
        /// 1:N userentityinstancedata_appointment
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_appointment")]
        public System.Collections.Generic.IEnumerable<UserEntityInstanceData> userentityinstancedata_appointment
        {
            get { return this.GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_appointment", null); }
            set
            {
                this.OnPropertyChanging("userentityinstancedata_appointment");
                this.SetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_appointment", null, value);
                this.OnPropertyChanged("userentityinstancedata_appointment");
            }
        }

        /// <summary>
        /// N:1 Account_Appointments
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Account_Appointments")]
        public Account Account_Appointments
        {
            get { return this.GetRelatedEntity<Account>("Account_Appointments", null); }
            set
            {
                this.OnPropertyChanging("Account_Appointments");
                this.SetRelatedEntity<Account>("Account_Appointments", null, value);
                this.OnPropertyChanged("Account_Appointments");
            }
        }

        /// <summary>
        /// N:1 activity_pointer_appointment
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("activityid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("activity_pointer_appointment")]
        public ActivityPointer activity_pointer_appointment
        {
            get { return this.GetRelatedEntity<ActivityPointer>("activity_pointer_appointment", null); }
            set
            {
                this.OnPropertyChanging("activity_pointer_appointment");
                this.SetRelatedEntity<ActivityPointer>("activity_pointer_appointment", null, value);
                this.OnPropertyChanged("activity_pointer_appointment");
            }
        }

        /// <summary>
        /// N:1 BulkOperation_Appointment
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("BulkOperation_Appointment")]
        public BulkOperation BulkOperation_Appointment
        {
            get { return this.GetRelatedEntity<BulkOperation>("BulkOperation_Appointment", null); }
            set
            {
                this.OnPropertyChanging("BulkOperation_Appointment");
                this.SetRelatedEntity<BulkOperation>("BulkOperation_Appointment", null, value);
                this.OnPropertyChanged("BulkOperation_Appointment");
            }
        }

        /// <summary>
        /// N:1 business_unit_appointment_activities
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_appointment_activities")]
        public BusinessUnit business_unit_appointment_activities
        {
            get { return this.GetRelatedEntity<BusinessUnit>("business_unit_appointment_activities", null); }
        }

        /// <summary>
        /// N:1 Campaign_Appointments
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Campaign_Appointments")]
        public Campaign Campaign_Appointments
        {
            get { return this.GetRelatedEntity<Campaign>("Campaign_Appointments", null); }
            set
            {
                this.OnPropertyChanging("Campaign_Appointments");
                this.SetRelatedEntity<Campaign>("Campaign_Appointments", null, value);
                this.OnPropertyChanged("Campaign_Appointments");
            }
        }

        /// <summary>
        /// N:1 CampaignActivity_Appointments
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("CampaignActivity_Appointments")]
        public CampaignActivity CampaignActivity_Appointments
        {
            get { return this.GetRelatedEntity<CampaignActivity>("CampaignActivity_Appointments", null); }
            set
            {
                this.OnPropertyChanging("CampaignActivity_Appointments");
                this.SetRelatedEntity<CampaignActivity>("CampaignActivity_Appointments", null, value);
                this.OnPropertyChanged("CampaignActivity_Appointments");
            }
        }

        /// <summary>
        /// N:1 Contact_Appointments
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Contact_Appointments")]
        public Contact Contact_Appointments
        {
            get { return this.GetRelatedEntity<Contact>("Contact_Appointments", null); }
            set
            {
                this.OnPropertyChanging("Contact_Appointments");
                this.SetRelatedEntity<Contact>("Contact_Appointments", null, value);
                this.OnPropertyChanged("Contact_Appointments");
            }
        }

        /// <summary>
        /// N:1 Contract_Appointments
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Contract_Appointments")]
        public Contract Contract_Appointments
        {
            get { return this.GetRelatedEntity<Contract>("Contract_Appointments", null); }
            set
            {
                this.OnPropertyChanging("Contract_Appointments");
                this.SetRelatedEntity<Contract>("Contract_Appointments", null, value);
                this.OnPropertyChanged("Contract_Appointments");
            }
        }

        /// <summary>
        /// N:1 entitlement_Appointments
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("entitlement_Appointments")]
        public Entitlement entitlement_Appointments
        {
            get { return this.GetRelatedEntity<Entitlement>("entitlement_Appointments", null); }
            set
            {
                this.OnPropertyChanging("entitlement_Appointments");
                this.SetRelatedEntity<Entitlement>("entitlement_Appointments", null, value);
                this.OnPropertyChanged("entitlement_Appointments");
            }
        }

        /// <summary>
        /// N:1 entitlementtemplate_Appointments
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("entitlementtemplate_Appointments")]
        public EntitlementTemplate entitlementtemplate_Appointments
        {
            get { return this.GetRelatedEntity<EntitlementTemplate>("entitlementtemplate_Appointments", null); }
            set
            {
                this.OnPropertyChanging("entitlementtemplate_Appointments");
                this.SetRelatedEntity<EntitlementTemplate>("entitlementtemplate_Appointments", null, value);
                this.OnPropertyChanged("entitlementtemplate_Appointments");
            }
        }

        /// <summary>
        /// N:1 Incident_Appointments
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Incident_Appointments")]
        public Incident Incident_Appointments
        {
            get { return this.GetRelatedEntity<Incident>("Incident_Appointments", null); }
            set
            {
                this.OnPropertyChanging("Incident_Appointments");
                this.SetRelatedEntity<Incident>("Incident_Appointments", null, value);
                this.OnPropertyChanged("Incident_Appointments");
            }
        }

        /// <summary>
        /// N:1 Invoice_Appointments
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Invoice_Appointments")]
        public Invoice Invoice_Appointments
        {
            get { return this.GetRelatedEntity<Invoice>("Invoice_Appointments", null); }
            set
            {
                this.OnPropertyChanging("Invoice_Appointments");
                this.SetRelatedEntity<Invoice>("Invoice_Appointments", null, value);
                this.OnPropertyChanged("Invoice_Appointments");
            }
        }

        /// <summary>
        /// N:1 Lead_Appointments
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Lead_Appointments")]
        public Lead Lead_Appointments
        {
            get { return this.GetRelatedEntity<Lead>("Lead_Appointments", null); }
            set
            {
                this.OnPropertyChanging("Lead_Appointments");
                this.SetRelatedEntity<Lead>("Lead_Appointments", null, value);
                this.OnPropertyChanged("Lead_Appointments");
            }
        }

        /// <summary>
        /// N:1 lk_appointment_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_appointment_createdby")]
        public SystemUser lk_appointment_createdby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_appointment_createdby", null); }
        }

        /// <summary>
        /// N:1 lk_appointment_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_appointment_createdonbehalfby")]
        public SystemUser lk_appointment_createdonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_appointment_createdonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_appointment_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_appointment_modifiedby")]
        public SystemUser lk_appointment_modifiedby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_appointment_modifiedby", null); }
        }

        /// <summary>
        /// N:1 lk_appointment_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_appointment_modifiedonbehalfby")]
        public SystemUser lk_appointment_modifiedonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_appointment_modifiedonbehalfby", null); }
        }

        /// <summary>
        /// N:1 msdyn_postalbum_Appointments
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_postalbum_Appointments")]
        public msdyn_PostAlbum msdyn_postalbum_Appointments
        {
            get { return this.GetRelatedEntity<msdyn_PostAlbum>("msdyn_postalbum_Appointments", null); }
            set
            {
                this.OnPropertyChanging("msdyn_postalbum_Appointments");
                this.SetRelatedEntity<msdyn_PostAlbum>("msdyn_postalbum_Appointments", null, value);
                this.OnPropertyChanged("msdyn_postalbum_Appointments");
            }
        }

        /// <summary>
        /// N:1 Opportunity_Appointments
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Opportunity_Appointments")]
        public Opportunity Opportunity_Appointments
        {
            get { return this.GetRelatedEntity<Opportunity>("Opportunity_Appointments", null); }
            set
            {
                this.OnPropertyChanging("Opportunity_Appointments");
                this.SetRelatedEntity<Opportunity>("Opportunity_Appointments", null, value);
                this.OnPropertyChanged("Opportunity_Appointments");
            }
        }

        /// <summary>
        /// N:1 processstage_appointments
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("stageid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("processstage_appointments")]
        public ProcessStage processstage_appointments
        {
            get { return this.GetRelatedEntity<ProcessStage>("processstage_appointments", null); }
            set
            {
                this.OnPropertyChanging("processstage_appointments");
                this.SetRelatedEntity<ProcessStage>("processstage_appointments", null, value);
                this.OnPropertyChanged("processstage_appointments");
            }
        }

        /// <summary>
        /// N:1 Quote_Appointments
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Quote_Appointments")]
        public Quote Quote_Appointments
        {
            get { return this.GetRelatedEntity<Quote>("Quote_Appointments", null); }
            set
            {
                this.OnPropertyChanging("Quote_Appointments");
                this.SetRelatedEntity<Quote>("Quote_Appointments", null, value);
                this.OnPropertyChanged("Quote_Appointments");
            }
        }

        /// <summary>
        /// N:1 recurringappointmentmaster_appointment
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("seriesid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("recurringappointmentmaster_appointment")]
        public RecurringAppointmentMaster recurringappointmentmaster_appointment
        {
            get { return this.GetRelatedEntity<RecurringAppointmentMaster>("recurringappointmentmaster_appointment", null); }
        }

        /// <summary>
        /// N:1 SalesOrder_Appointments
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SalesOrder_Appointments")]
        public SalesOrder SalesOrder_Appointments
        {
            get { return this.GetRelatedEntity<SalesOrder>("SalesOrder_Appointments", null); }
            set
            {
                this.OnPropertyChanging("SalesOrder_Appointments");
                this.SetRelatedEntity<SalesOrder>("SalesOrder_Appointments", null, value);
                this.OnPropertyChanged("SalesOrder_Appointments");
            }
        }

        /// <summary>
        /// N:1 service_appointments
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("serviceid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("service_appointments")]
        public Service service_appointments
        {
            get { return this.GetRelatedEntity<Service>("service_appointments", null); }
            set
            {
                this.OnPropertyChanging("service_appointments");
                this.SetRelatedEntity<Service>("service_appointments", null, value);
                this.OnPropertyChanged("service_appointments");
            }
        }

        /// <summary>
        /// N:1 team_appointment
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_appointment")]
        public Team team_appointment
        {
            get { return this.GetRelatedEntity<Team>("team_appointment", null); }
        }

        /// <summary>
        /// N:1 TransactionCurrency_Appointment
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("TransactionCurrency_Appointment")]
        public TransactionCurrency TransactionCurrency_Appointment
        {
            get { return this.GetRelatedEntity<TransactionCurrency>("TransactionCurrency_Appointment", null); }
            set
            {
                this.OnPropertyChanging("TransactionCurrency_Appointment");
                this.SetRelatedEntity<TransactionCurrency>("TransactionCurrency_Appointment", null, value);
                this.OnPropertyChanged("TransactionCurrency_Appointment");
            }
        }

        /// <summary>
        /// N:1 user_appointment
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_appointment")]
        public SystemUser user_appointment
        {
            get { return this.GetRelatedEntity<SystemUser>("user_appointment", null); }
        }
    }
}