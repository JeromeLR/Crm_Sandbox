using _4_DAL_CRM;

namespace __4_DAL_CRM
{
    /// <summary>
    /// Activity offered by the organization to satisfy its customer's needs. Each service activity includes date, time, duration, and required resources.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("serviceappointment")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class ServiceAppointment : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public ServiceAppointment() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "serviceappointment";

        public const int EntityTypeCode = 4214;

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
        /// Unique identifier of the service activity.
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
        /// Shows the value selected in the Duration field on the service activity at the time the service activity is closed as completed. The duration is used to report the time spent on the activity.
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
        /// Enter the actual end date and time of the service activity. By default, it displays when the activity was closed or canceled.
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
        /// Enter the actual start date and time for the service activity. By default, it displays when the activity was created.
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
        /// Type a category to identify the service activity type, such as routine maintenance or service call, to tie the service activity to a business group or function.
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
        /// Enter the accounts and contacts for whom the service activity is being performed.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("customers")]
        public System.Collections.Generic.IEnumerable<ActivityParty> Customers
        {
            get
            {
                Microsoft.Xrm.Sdk.EntityCollection collection = this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityCollection>("customers");
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
                this.OnPropertyChanging("Customers");
                if ((value == null))
                {
                    this.SetAttributeValue("customers", value);
                }
                else
                {
                    this.SetAttributeValue("customers", new Microsoft.Xrm.Sdk.EntityCollection(new System.Collections.Generic.List<Microsoft.Xrm.Sdk.Entity>(value)));
                }
                this.OnPropertyChanged("Customers");
            }
        }

        /// <summary>
        /// Type additional information to describe the service activity, such as key talking points or objectives.
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
        /// Select whether the service activity is an all-day event to make sure the required resources are scheduled for the full day.
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
        /// Information which specifies whether the service activity was billed as part of resolving a case.
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
        /// Information which specifies if the service activity was created from a workflow rule.
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
        /// Type the location where the service activity will take place, such as a conference room, customer office, or other venue.
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
        /// Unique identifier of the team that owns the service activity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
        public Microsoft.Xrm.Sdk.EntityReference OwningTeam
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningteam"); }
        }

        /// <summary>
        /// Unique identifier of the user that owns the service activity.
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
        /// Unique identifier of the object with which the service activity is associated.
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
        /// Enter the user, facility, or equipment required to complete the service activity.
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
        /// Shows the expected duration of the service activity, in minutes.
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
        /// Choose the service scheduled to be performed during the service activity.
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
        /// Choose the site or location where the service activity will be performed.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("siteid")]
        public Microsoft.Xrm.Sdk.EntityReference SiteId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("siteid"); }
            set
            {
                this.OnPropertyChanging("SiteId");
                this.SetAttributeValue("siteid", value);
                this.OnPropertyChanged("SiteId");
            }
        }

        /// <summary>
        /// Shows whether the service activity is open, completed, or canceled. Completed and canceled service activities are read-only and can't be edited.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
        public System.Nullable<ServiceAppointmentState> StateCode
        {
            get
            {
                Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
                if ((optionSet != null))
                {
                    return ((ServiceAppointmentState) (System.Enum.ToObject(typeof(ServiceAppointmentState), optionSet.Value)));
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// Select the service activity's status.
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
        /// Type a subcategory to identify the service activity type and relate the activity to a specific product, service region, business group, or other function.
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
        /// Type a short description about the objective or primary topic of the service activity.
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
        /// Version number of the service activity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
        public System.Nullable<long> VersionNumber
        {
            get { return this.GetAttributeValue<System.Nullable<long>>("versionnumber"); }
        }

        /// <summary>
        /// 1:N serviceappointment_activity_parties
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("serviceappointment_activity_parties")]
        public System.Collections.Generic.IEnumerable<ActivityParty> serviceappointment_activity_parties
        {
            get { return this.GetRelatedEntities<ActivityParty>("serviceappointment_activity_parties", null); }
            set
            {
                this.OnPropertyChanging("serviceappointment_activity_parties");
                this.SetRelatedEntities<ActivityParty>("serviceappointment_activity_parties", null, value);
                this.OnPropertyChanged("serviceappointment_activity_parties");
            }
        }

        /// <summary>
        /// 1:N ServiceAppointment_Annotation
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ServiceAppointment_Annotation")]
        public System.Collections.Generic.IEnumerable<Annotation> ServiceAppointment_Annotation
        {
            get { return this.GetRelatedEntities<Annotation>("ServiceAppointment_Annotation", null); }
            set
            {
                this.OnPropertyChanging("ServiceAppointment_Annotation");
                this.SetRelatedEntities<Annotation>("ServiceAppointment_Annotation", null, value);
                this.OnPropertyChanged("ServiceAppointment_Annotation");
            }
        }

        /// <summary>
        /// 1:N ServiceAppointment_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ServiceAppointment_AsyncOperations")]
        public System.Collections.Generic.IEnumerable<AsyncOperation> ServiceAppointment_AsyncOperations
        {
            get { return this.GetRelatedEntities<AsyncOperation>("ServiceAppointment_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("ServiceAppointment_AsyncOperations");
                this.SetRelatedEntities<AsyncOperation>("ServiceAppointment_AsyncOperations", null, value);
                this.OnPropertyChanged("ServiceAppointment_AsyncOperations");
            }
        }

        /// <summary>
        /// 1:N ServiceAppointment_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ServiceAppointment_BulkDeleteFailures")]
        public System.Collections.Generic.IEnumerable<BulkDeleteFailure> ServiceAppointment_BulkDeleteFailures
        {
            get { return this.GetRelatedEntities<BulkDeleteFailure>("ServiceAppointment_BulkDeleteFailures", null); }
            set
            {
                this.OnPropertyChanging("ServiceAppointment_BulkDeleteFailures");
                this.SetRelatedEntities<BulkDeleteFailure>("ServiceAppointment_BulkDeleteFailures", null, value);
                this.OnPropertyChanged("ServiceAppointment_BulkDeleteFailures");
            }
        }

        /// <summary>
        /// 1:N serviceappointment_connections1
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("serviceappointment_connections1")]
        public System.Collections.Generic.IEnumerable<Connection> serviceappointment_connections1
        {
            get { return this.GetRelatedEntities<Connection>("serviceappointment_connections1", null); }
            set
            {
                this.OnPropertyChanging("serviceappointment_connections1");
                this.SetRelatedEntities<Connection>("serviceappointment_connections1", null, value);
                this.OnPropertyChanged("serviceappointment_connections1");
            }
        }

        /// <summary>
        /// 1:N serviceappointment_connections2
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("serviceappointment_connections2")]
        public System.Collections.Generic.IEnumerable<Connection> serviceappointment_connections2
        {
            get { return this.GetRelatedEntities<Connection>("serviceappointment_connections2", null); }
            set
            {
                this.OnPropertyChanging("serviceappointment_connections2");
                this.SetRelatedEntities<Connection>("serviceappointment_connections2", null, value);
                this.OnPropertyChanged("serviceappointment_connections2");
            }
        }

        /// <summary>
        /// 1:N serviceappointment_principalobjectattributeaccess
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("serviceappointment_principalobjectattributeaccess")]
        public System.Collections.Generic.IEnumerable<PrincipalObjectAttributeAccess> serviceappointment_principalobjectattributeaccess
        {
            get { return this.GetRelatedEntities<PrincipalObjectAttributeAccess>("serviceappointment_principalobjectattributeaccess", null); }
            set
            {
                this.OnPropertyChanging("serviceappointment_principalobjectattributeaccess");
                this.SetRelatedEntities<PrincipalObjectAttributeAccess>("serviceappointment_principalobjectattributeaccess", null, value);
                this.OnPropertyChanged("serviceappointment_principalobjectattributeaccess");
            }
        }

        /// <summary>
        /// 1:N ServiceAppointment_ProcessSessions
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ServiceAppointment_ProcessSessions")]
        public System.Collections.Generic.IEnumerable<ProcessSession> ServiceAppointment_ProcessSessions
        {
            get { return this.GetRelatedEntities<ProcessSession>("ServiceAppointment_ProcessSessions", null); }
            set
            {
                this.OnPropertyChanging("ServiceAppointment_ProcessSessions");
                this.SetRelatedEntities<ProcessSession>("ServiceAppointment_ProcessSessions", null, value);
                this.OnPropertyChanged("ServiceAppointment_ProcessSessions");
            }
        }

        /// <summary>
        /// 1:N ServiceAppointment_QueueItem
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ServiceAppointment_QueueItem")]
        public System.Collections.Generic.IEnumerable<QueueItem> ServiceAppointment_QueueItem
        {
            get { return this.GetRelatedEntities<QueueItem>("ServiceAppointment_QueueItem", null); }
            set
            {
                this.OnPropertyChanging("ServiceAppointment_QueueItem");
                this.SetRelatedEntities<QueueItem>("ServiceAppointment_QueueItem", null, value);
                this.OnPropertyChanged("ServiceAppointment_QueueItem");
            }
        }

        /// <summary>
        /// 1:N userentityinstancedata_serviceappointment
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_serviceappointment")]
        public System.Collections.Generic.IEnumerable<UserEntityInstanceData> userentityinstancedata_serviceappointment
        {
            get { return this.GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_serviceappointment", null); }
            set
            {
                this.OnPropertyChanging("userentityinstancedata_serviceappointment");
                this.SetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_serviceappointment", null, value);
                this.OnPropertyChanged("userentityinstancedata_serviceappointment");
            }
        }

        /// <summary>
        /// N:1 Account_ServiceAppointments
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Account_ServiceAppointments")]
        public Account Account_ServiceAppointments
        {
            get { return this.GetRelatedEntity<Account>("Account_ServiceAppointments", null); }
            set
            {
                this.OnPropertyChanging("Account_ServiceAppointments");
                this.SetRelatedEntity<Account>("Account_ServiceAppointments", null, value);
                this.OnPropertyChanged("Account_ServiceAppointments");
            }
        }

        /// <summary>
        /// N:1 activity_pointer_service_appointment
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("activityid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("activity_pointer_service_appointment")]
        public ActivityPointer activity_pointer_service_appointment
        {
            get { return this.GetRelatedEntity<ActivityPointer>("activity_pointer_service_appointment", null); }
            set
            {
                this.OnPropertyChanging("activity_pointer_service_appointment");
                this.SetRelatedEntity<ActivityPointer>("activity_pointer_service_appointment", null, value);
                this.OnPropertyChanged("activity_pointer_service_appointment");
            }
        }

        /// <summary>
        /// N:1 business_unit_service_appointments
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_service_appointments")]
        public BusinessUnit business_unit_service_appointments
        {
            get { return this.GetRelatedEntity<BusinessUnit>("business_unit_service_appointments", null); }
        }

        /// <summary>
        /// N:1 Campaign_ServiceAppointments
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Campaign_ServiceAppointments")]
        public Campaign Campaign_ServiceAppointments
        {
            get { return this.GetRelatedEntity<Campaign>("Campaign_ServiceAppointments", null); }
            set
            {
                this.OnPropertyChanging("Campaign_ServiceAppointments");
                this.SetRelatedEntity<Campaign>("Campaign_ServiceAppointments", null, value);
                this.OnPropertyChanged("Campaign_ServiceAppointments");
            }
        }

        /// <summary>
        /// N:1 Contact_ServiceAppointments
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Contact_ServiceAppointments")]
        public Contact Contact_ServiceAppointments
        {
            get { return this.GetRelatedEntity<Contact>("Contact_ServiceAppointments", null); }
            set
            {
                this.OnPropertyChanging("Contact_ServiceAppointments");
                this.SetRelatedEntity<Contact>("Contact_ServiceAppointments", null, value);
                this.OnPropertyChanged("Contact_ServiceAppointments");
            }
        }

        /// <summary>
        /// N:1 Contract_ServiceAppointments
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Contract_ServiceAppointments")]
        public Contract Contract_ServiceAppointments
        {
            get { return this.GetRelatedEntity<Contract>("Contract_ServiceAppointments", null); }
            set
            {
                this.OnPropertyChanging("Contract_ServiceAppointments");
                this.SetRelatedEntity<Contract>("Contract_ServiceAppointments", null, value);
                this.OnPropertyChanged("Contract_ServiceAppointments");
            }
        }

        /// <summary>
        /// N:1 entitlement_ServiceAppointments
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("entitlement_ServiceAppointments")]
        public Entitlement entitlement_ServiceAppointments
        {
            get { return this.GetRelatedEntity<Entitlement>("entitlement_ServiceAppointments", null); }
            set
            {
                this.OnPropertyChanging("entitlement_ServiceAppointments");
                this.SetRelatedEntity<Entitlement>("entitlement_ServiceAppointments", null, value);
                this.OnPropertyChanged("entitlement_ServiceAppointments");
            }
        }

        /// <summary>
        /// N:1 entitlementtemplate_ServiceAppointments
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("entitlementtemplate_ServiceAppointments")]
        public EntitlementTemplate entitlementtemplate_ServiceAppointments
        {
            get { return this.GetRelatedEntity<EntitlementTemplate>("entitlementtemplate_ServiceAppointments", null); }
            set
            {
                this.OnPropertyChanging("entitlementtemplate_ServiceAppointments");
                this.SetRelatedEntity<EntitlementTemplate>("entitlementtemplate_ServiceAppointments", null, value);
                this.OnPropertyChanged("entitlementtemplate_ServiceAppointments");
            }
        }

        /// <summary>
        /// N:1 Incident_ServiceAppointments
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Incident_ServiceAppointments")]
        public Incident Incident_ServiceAppointments
        {
            get { return this.GetRelatedEntity<Incident>("Incident_ServiceAppointments", null); }
            set
            {
                this.OnPropertyChanging("Incident_ServiceAppointments");
                this.SetRelatedEntity<Incident>("Incident_ServiceAppointments", null, value);
                this.OnPropertyChanged("Incident_ServiceAppointments");
            }
        }

        /// <summary>
        /// N:1 Invoice_ServiceAppointments
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Invoice_ServiceAppointments")]
        public Invoice Invoice_ServiceAppointments
        {
            get { return this.GetRelatedEntity<Invoice>("Invoice_ServiceAppointments", null); }
            set
            {
                this.OnPropertyChanging("Invoice_ServiceAppointments");
                this.SetRelatedEntity<Invoice>("Invoice_ServiceAppointments", null, value);
                this.OnPropertyChanged("Invoice_ServiceAppointments");
            }
        }

        /// <summary>
        /// N:1 Lead_ServiceAppointments
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Lead_ServiceAppointments")]
        public Lead Lead_ServiceAppointments
        {
            get { return this.GetRelatedEntity<Lead>("Lead_ServiceAppointments", null); }
            set
            {
                this.OnPropertyChanging("Lead_ServiceAppointments");
                this.SetRelatedEntity<Lead>("Lead_ServiceAppointments", null, value);
                this.OnPropertyChanged("Lead_ServiceAppointments");
            }
        }

        /// <summary>
        /// N:1 lk_serviceappointment_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_serviceappointment_createdby")]
        public SystemUser lk_serviceappointment_createdby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_serviceappointment_createdby", null); }
        }

        /// <summary>
        /// N:1 lk_serviceappointment_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_serviceappointment_createdonbehalfby")]
        public SystemUser lk_serviceappointment_createdonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_serviceappointment_createdonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_serviceappointment_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_serviceappointment_modifiedby")]
        public SystemUser lk_serviceappointment_modifiedby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_serviceappointment_modifiedby", null); }
        }

        /// <summary>
        /// N:1 lk_serviceappointment_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_serviceappointment_modifiedonbehalfby")]
        public SystemUser lk_serviceappointment_modifiedonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_serviceappointment_modifiedonbehalfby", null); }
        }

        /// <summary>
        /// N:1 msdyn_postalbum_ServiceAppointments
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_postalbum_ServiceAppointments")]
        public msdyn_PostAlbum msdyn_postalbum_ServiceAppointments
        {
            get { return this.GetRelatedEntity<msdyn_PostAlbum>("msdyn_postalbum_ServiceAppointments", null); }
            set
            {
                this.OnPropertyChanging("msdyn_postalbum_ServiceAppointments");
                this.SetRelatedEntity<msdyn_PostAlbum>("msdyn_postalbum_ServiceAppointments", null, value);
                this.OnPropertyChanged("msdyn_postalbum_ServiceAppointments");
            }
        }

        /// <summary>
        /// N:1 Opportunity_ServiceAppointments
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Opportunity_ServiceAppointments")]
        public Opportunity Opportunity_ServiceAppointments
        {
            get { return this.GetRelatedEntity<Opportunity>("Opportunity_ServiceAppointments", null); }
            set
            {
                this.OnPropertyChanging("Opportunity_ServiceAppointments");
                this.SetRelatedEntity<Opportunity>("Opportunity_ServiceAppointments", null, value);
                this.OnPropertyChanged("Opportunity_ServiceAppointments");
            }
        }

        /// <summary>
        /// N:1 Quote_ServiceAppointments
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Quote_ServiceAppointments")]
        public Quote Quote_ServiceAppointments
        {
            get { return this.GetRelatedEntity<Quote>("Quote_ServiceAppointments", null); }
            set
            {
                this.OnPropertyChanging("Quote_ServiceAppointments");
                this.SetRelatedEntity<Quote>("Quote_ServiceAppointments", null, value);
                this.OnPropertyChanged("Quote_ServiceAppointments");
            }
        }

        /// <summary>
        /// N:1 SalesOrder_ServiceAppointments
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SalesOrder_ServiceAppointments")]
        public SalesOrder SalesOrder_ServiceAppointments
        {
            get { return this.GetRelatedEntity<SalesOrder>("SalesOrder_ServiceAppointments", null); }
            set
            {
                this.OnPropertyChanging("SalesOrder_ServiceAppointments");
                this.SetRelatedEntity<SalesOrder>("SalesOrder_ServiceAppointments", null, value);
                this.OnPropertyChanged("SalesOrder_ServiceAppointments");
            }
        }

        /// <summary>
        /// N:1 service_service_appointments
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("serviceid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("service_service_appointments")]
        public Service service_service_appointments
        {
            get { return this.GetRelatedEntity<Service>("service_service_appointments", null); }
            set
            {
                this.OnPropertyChanging("service_service_appointments");
                this.SetRelatedEntity<Service>("service_service_appointments", null, value);
                this.OnPropertyChanged("service_service_appointments");
            }
        }

        /// <summary>
        /// N:1 site_service_appointments
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("siteid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("site_service_appointments")]
        public Site site_service_appointments
        {
            get { return this.GetRelatedEntity<Site>("site_service_appointments", null); }
            set
            {
                this.OnPropertyChanging("site_service_appointments");
                this.SetRelatedEntity<Site>("site_service_appointments", null, value);
                this.OnPropertyChanged("site_service_appointments");
            }
        }

        /// <summary>
        /// N:1 system_user_service_appointments
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("system_user_service_appointments")]
        public SystemUser system_user_service_appointments
        {
            get { return this.GetRelatedEntity<SystemUser>("system_user_service_appointments", null); }
        }

        /// <summary>
        /// N:1 team_service_appointments
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_service_appointments")]
        public Team team_service_appointments
        {
            get { return this.GetRelatedEntity<Team>("team_service_appointments", null); }
        }

        /// <summary>
        /// N:1 TransactionCurrency_ServiceAppointment
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("TransactionCurrency_ServiceAppointment")]
        public TransactionCurrency TransactionCurrency_ServiceAppointment
        {
            get { return this.GetRelatedEntity<TransactionCurrency>("TransactionCurrency_ServiceAppointment", null); }
            set
            {
                this.OnPropertyChanging("TransactionCurrency_ServiceAppointment");
                this.SetRelatedEntity<TransactionCurrency>("TransactionCurrency_ServiceAppointment", null, value);
                this.OnPropertyChanged("TransactionCurrency_ServiceAppointment");
            }
        }
    }
}