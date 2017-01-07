using _4_DAL_CRM;

namespace __4_DAL_CRM
{
    /// <summary>
    /// Activity that represents work done to satisfy a customer's need.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("service")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class Service : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public Service() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "service";

        public const int EntityTypeCode = 4001;

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
        /// Used in conjunction with granularity to describes when services can be performed in relation to midnight on a given day.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("anchoroffset")]
        public System.Nullable<int> AnchorOffset
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("anchoroffset"); }
            set
            {
                this.OnPropertyChanging("AnchorOffset");
                this.SetAttributeValue("anchoroffset", value);
                this.OnPropertyChanged("AnchorOffset");
            }
        }

        /// <summary>
        /// Unique identifier of the calendar.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("calendarid")]
        public System.Nullable<System.Guid> CalendarId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("calendarid"); }
            set
            {
                this.OnPropertyChanging("CalendarId");
                this.SetAttributeValue("calendarid", value);
                this.OnPropertyChanged("CalendarId");
            }
        }

        /// <summary>
        /// Unique identifier of the user who created the service.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby"); }
        }

        /// <summary>
        /// Date and time when the service was created.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
        public System.Nullable<System.DateTime> CreatedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who created the service.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        /// Description of activity that represents work done to satisfy a customer's need.
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
        /// Duration of the service.
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
        /// Describes how often the service is performed.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("granularity")]
        public string Granularity
        {
            get { return this.GetAttributeValue<string>("granularity"); }
            set
            {
                this.OnPropertyChanging("Granularity");
                this.SetAttributeValue("granularity", value);
                this.OnPropertyChanged("Granularity");
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
        /// Initial status reason for the service activity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("initialstatuscode")]
        public Microsoft.Xrm.Sdk.OptionSetValue InitialStatusCode
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("initialstatuscode"); }
            set
            {
                this.OnPropertyChanging("InitialStatusCode");
                this.SetAttributeValue("initialstatuscode", value);
                this.OnPropertyChanged("InitialStatusCode");
            }
        }

        /// <summary>
        /// Information about whether the service can be scheduled.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isschedulable")]
        public System.Nullable<bool> IsSchedulable
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("isschedulable"); }
            set
            {
                this.OnPropertyChanging("IsSchedulable");
                this.SetAttributeValue("isschedulable", value);
                this.OnPropertyChanged("IsSchedulable");
            }
        }

        /// <summary>
        /// Information about whether the service is visible to users.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isvisible")]
        public System.Nullable<bool> IsVisible
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("isvisible"); }
            set
            {
                this.OnPropertyChanging("IsVisible");
                this.SetAttributeValue("isvisible", value);
                this.OnPropertyChanged("IsVisible");
            }
        }

        /// <summary>
        /// Unique identifier of the user who last modified the service.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby"); }
        }

        /// <summary>
        /// Date and time when the service was last modified.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
        public System.Nullable<System.DateTime> ModifiedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who last modified the service.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        /// Name of the service.
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
        /// Unique identifier of the organization with which the service is associated.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
        public Microsoft.Xrm.Sdk.EntityReference OrganizationId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("organizationid"); }
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
        /// Unique identifier of the resource specification with which the service is associated.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("resourcespecid")]
        public Microsoft.Xrm.Sdk.EntityReference ResourceSpecId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("resourcespecid"); }
            set
            {
                this.OnPropertyChanging("ResourceSpecId");
                this.SetAttributeValue("resourcespecid", value);
                this.OnPropertyChanged("ResourceSpecId");
            }
        }

        /// <summary>
        /// Unique identifier of the associated service.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("serviceid")]
        public System.Nullable<System.Guid> ServiceId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("serviceid"); }
            set
            {
                this.OnPropertyChanging("ServiceId");
                this.SetAttributeValue("serviceid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("ServiceId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("serviceid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.ServiceId = value; }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("showresources")]
        public System.Nullable<bool> ShowResources
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("showresources"); }
            set
            {
                this.OnPropertyChanging("ShowResources");
                this.SetAttributeValue("showresources", value);
                this.OnPropertyChanged("ShowResources");
            }
        }

        /// <summary>
        /// Value that is taken from PluginTypeId in the Plugin Type record for the scheduling strategy. This is the ID of the scheduling strategy plug-in associated with the service.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("strategyid")]
        public Microsoft.Xrm.Sdk.EntityReference StrategyId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("strategyid"); }
            set
            {
                this.OnPropertyChanging("StrategyId");
                this.SetAttributeValue("strategyid", value);
                this.OnPropertyChanged("StrategyId");
            }
        }

        /// <summary>
        /// Version number of the service.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
        public System.Nullable<long> VersionNumber
        {
            get { return this.GetAttributeValue<System.Nullable<long>>("versionnumber"); }
        }

        /// <summary>
        /// 1:N service_accounts
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("service_accounts")]
        public System.Collections.Generic.IEnumerable<Account> service_accounts
        {
            get { return this.GetRelatedEntities<Account>("service_accounts", null); }
            set
            {
                this.OnPropertyChanging("service_accounts");
                this.SetRelatedEntities<Account>("service_accounts", null, value);
                this.OnPropertyChanged("service_accounts");
            }
        }

        /// <summary>
        /// 1:N service_activity_pointers
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("service_activity_pointers")]
        public System.Collections.Generic.IEnumerable<ActivityPointer> service_activity_pointers
        {
            get { return this.GetRelatedEntities<ActivityPointer>("service_activity_pointers", null); }
            set
            {
                this.OnPropertyChanging("service_activity_pointers");
                this.SetRelatedEntities<ActivityPointer>("service_activity_pointers", null, value);
                this.OnPropertyChanged("service_activity_pointers");
            }
        }

        /// <summary>
        /// 1:N Service_Annotation
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Service_Annotation")]
        public System.Collections.Generic.IEnumerable<Annotation> Service_Annotation
        {
            get { return this.GetRelatedEntities<Annotation>("Service_Annotation", null); }
            set
            {
                this.OnPropertyChanging("Service_Annotation");
                this.SetRelatedEntities<Annotation>("Service_Annotation", null, value);
                this.OnPropertyChanged("Service_Annotation");
            }
        }

        /// <summary>
        /// 1:N service_appointments
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("service_appointments")]
        public System.Collections.Generic.IEnumerable<Appointment> service_appointments
        {
            get { return this.GetRelatedEntities<Appointment>("service_appointments", null); }
            set
            {
                this.OnPropertyChanging("service_appointments");
                this.SetRelatedEntities<Appointment>("service_appointments", null, value);
                this.OnPropertyChanged("service_appointments");
            }
        }

        /// <summary>
        /// 1:N Service_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Service_AsyncOperations")]
        public System.Collections.Generic.IEnumerable<AsyncOperation> Service_AsyncOperations
        {
            get { return this.GetRelatedEntities<AsyncOperation>("Service_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("Service_AsyncOperations");
                this.SetRelatedEntities<AsyncOperation>("Service_AsyncOperations", null, value);
                this.OnPropertyChanged("Service_AsyncOperations");
            }
        }

        /// <summary>
        /// 1:N Service_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Service_BulkDeleteFailures")]
        public System.Collections.Generic.IEnumerable<BulkDeleteFailure> Service_BulkDeleteFailures
        {
            get { return this.GetRelatedEntities<BulkDeleteFailure>("Service_BulkDeleteFailures", null); }
            set
            {
                this.OnPropertyChanging("Service_BulkDeleteFailures");
                this.SetRelatedEntities<BulkDeleteFailure>("Service_BulkDeleteFailures", null, value);
                this.OnPropertyChanged("Service_BulkDeleteFailures");
            }
        }

        /// <summary>
        /// 1:N service_calendar_rules
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("calendarrules")]
        public System.Collections.Generic.IEnumerable<CalendarRule> CalendarRules
        {
            get
            {
                Microsoft.Xrm.Sdk.EntityCollection collection = this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityCollection>("calendarrules");
                if (((collection != null)
                     && (collection.Entities != null)))
                {
                    return System.Linq.Enumerable.Cast<CalendarRule>(collection.Entities);
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.OnPropertyChanging("CalendarRules");
                if ((value == null))
                {
                    this.SetAttributeValue("calendarrules", value);
                }
                else
                {
                    this.SetAttributeValue("calendarrules", new Microsoft.Xrm.Sdk.EntityCollection(new System.Collections.Generic.List<Microsoft.Xrm.Sdk.Entity>(value)));
                }
                this.OnPropertyChanged("CalendarRules");
            }
        }

        /// <summary>
        /// 1:N service_contacts
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("service_contacts")]
        public System.Collections.Generic.IEnumerable<Contact> service_contacts
        {
            get { return this.GetRelatedEntities<Contact>("service_contacts", null); }
            set
            {
                this.OnPropertyChanging("service_contacts");
                this.SetRelatedEntities<Contact>("service_contacts", null, value);
                this.OnPropertyChanged("service_contacts");
            }
        }

        /// <summary>
        /// 1:N Service_DuplicateBaseRecord
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Service_DuplicateBaseRecord")]
        public System.Collections.Generic.IEnumerable<DuplicateRecord> Service_DuplicateBaseRecord
        {
            get { return this.GetRelatedEntities<DuplicateRecord>("Service_DuplicateBaseRecord", null); }
            set
            {
                this.OnPropertyChanging("Service_DuplicateBaseRecord");
                this.SetRelatedEntities<DuplicateRecord>("Service_DuplicateBaseRecord", null, value);
                this.OnPropertyChanged("Service_DuplicateBaseRecord");
            }
        }

        /// <summary>
        /// 1:N Service_DuplicateMatchingRecord
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Service_DuplicateMatchingRecord")]
        public System.Collections.Generic.IEnumerable<DuplicateRecord> Service_DuplicateMatchingRecord
        {
            get { return this.GetRelatedEntities<DuplicateRecord>("Service_DuplicateMatchingRecord", null); }
            set
            {
                this.OnPropertyChanging("Service_DuplicateMatchingRecord");
                this.SetRelatedEntities<DuplicateRecord>("Service_DuplicateMatchingRecord", null, value);
                this.OnPropertyChanged("Service_DuplicateMatchingRecord");
            }
        }

        /// <summary>
        /// 1:N service_emails
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("service_emails")]
        public System.Collections.Generic.IEnumerable<Email> service_emails
        {
            get { return this.GetRelatedEntities<Email>("service_emails", null); }
            set
            {
                this.OnPropertyChanging("service_emails");
                this.SetRelatedEntities<Email>("service_emails", null, value);
                this.OnPropertyChanged("service_emails");
            }
        }

        /// <summary>
        /// 1:N service_faxes
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("service_faxes")]
        public System.Collections.Generic.IEnumerable<Fax> service_faxes
        {
            get { return this.GetRelatedEntities<Fax>("service_faxes", null); }
            set
            {
                this.OnPropertyChanging("service_faxes");
                this.SetRelatedEntities<Fax>("service_faxes", null, value);
                this.OnPropertyChanged("service_faxes");
            }
        }

        /// <summary>
        /// 1:N service_incidentresolutions
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("service_incidentresolutions")]
        public System.Collections.Generic.IEnumerable<IncidentResolution> service_incidentresolutions
        {
            get { return this.GetRelatedEntities<IncidentResolution>("service_incidentresolutions", null); }
            set
            {
                this.OnPropertyChanging("service_incidentresolutions");
                this.SetRelatedEntities<IncidentResolution>("service_incidentresolutions", null, value);
                this.OnPropertyChanged("service_incidentresolutions");
            }
        }

        /// <summary>
        /// 1:N service_letters
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("service_letters")]
        public System.Collections.Generic.IEnumerable<Letter> service_letters
        {
            get { return this.GetRelatedEntities<Letter>("service_letters", null); }
            set
            {
                this.OnPropertyChanging("service_letters");
                this.SetRelatedEntities<Letter>("service_letters", null, value);
                this.OnPropertyChanged("service_letters");
            }
        }

        /// <summary>
        /// 1:N service_opportunityclose
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("service_opportunityclose")]
        public System.Collections.Generic.IEnumerable<OpportunityClose> service_opportunityclose
        {
            get { return this.GetRelatedEntities<OpportunityClose>("service_opportunityclose", null); }
            set
            {
                this.OnPropertyChanging("service_opportunityclose");
                this.SetRelatedEntities<OpportunityClose>("service_opportunityclose", null, value);
                this.OnPropertyChanged("service_opportunityclose");
            }
        }

        /// <summary>
        /// 1:N service_orderclose
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("service_orderclose")]
        public System.Collections.Generic.IEnumerable<OrderClose> service_orderclose
        {
            get { return this.GetRelatedEntities<OrderClose>("service_orderclose", null); }
            set
            {
                this.OnPropertyChanging("service_orderclose");
                this.SetRelatedEntities<OrderClose>("service_orderclose", null, value);
                this.OnPropertyChanged("service_orderclose");
            }
        }

        /// <summary>
        /// 1:N service_phonecalls
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("service_phonecalls")]
        public System.Collections.Generic.IEnumerable<PhoneCall> service_phonecalls
        {
            get { return this.GetRelatedEntities<PhoneCall>("service_phonecalls", null); }
            set
            {
                this.OnPropertyChanging("service_phonecalls");
                this.SetRelatedEntities<PhoneCall>("service_phonecalls", null, value);
                this.OnPropertyChanged("service_phonecalls");
            }
        }

        /// <summary>
        /// 1:N Service_ProcessSessions
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Service_ProcessSessions")]
        public System.Collections.Generic.IEnumerable<ProcessSession> Service_ProcessSessions
        {
            get { return this.GetRelatedEntities<ProcessSession>("Service_ProcessSessions", null); }
            set
            {
                this.OnPropertyChanging("Service_ProcessSessions");
                this.SetRelatedEntities<ProcessSession>("Service_ProcessSessions", null, value);
                this.OnPropertyChanged("Service_ProcessSessions");
            }
        }

        /// <summary>
        /// 1:N service_quoteclose
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("service_quoteclose")]
        public System.Collections.Generic.IEnumerable<QuoteClose> service_quoteclose
        {
            get { return this.GetRelatedEntities<QuoteClose>("service_quoteclose", null); }
            set
            {
                this.OnPropertyChanging("service_quoteclose");
                this.SetRelatedEntities<QuoteClose>("service_quoteclose", null, value);
                this.OnPropertyChanged("service_quoteclose");
            }
        }

        /// <summary>
        /// 1:N service_recurringappointmentmasters
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("service_recurringappointmentmasters")]
        public System.Collections.Generic.IEnumerable<RecurringAppointmentMaster> service_recurringappointmentmasters
        {
            get { return this.GetRelatedEntities<RecurringAppointmentMaster>("service_recurringappointmentmasters", null); }
            set
            {
                this.OnPropertyChanging("service_recurringappointmentmasters");
                this.SetRelatedEntities<RecurringAppointmentMaster>("service_recurringappointmentmasters", null, value);
                this.OnPropertyChanged("service_recurringappointmentmasters");
            }
        }

        /// <summary>
        /// 1:N service_service_appointments
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("service_service_appointments")]
        public System.Collections.Generic.IEnumerable<ServiceAppointment> service_service_appointments
        {
            get { return this.GetRelatedEntities<ServiceAppointment>("service_service_appointments", null); }
            set
            {
                this.OnPropertyChanging("service_service_appointments");
                this.SetRelatedEntities<ServiceAppointment>("service_service_appointments", null, value);
                this.OnPropertyChanged("service_service_appointments");
            }
        }

        /// <summary>
        /// 1:N service_socialactivities
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("service_socialactivities")]
        public System.Collections.Generic.IEnumerable<SocialActivity> service_socialactivities
        {
            get { return this.GetRelatedEntities<SocialActivity>("service_socialactivities", null); }
            set
            {
                this.OnPropertyChanging("service_socialactivities");
                this.SetRelatedEntities<SocialActivity>("service_socialactivities", null, value);
                this.OnPropertyChanged("service_socialactivities");
            }
        }

        /// <summary>
        /// 1:N service_tasks
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("service_tasks")]
        public System.Collections.Generic.IEnumerable<Task> service_tasks
        {
            get { return this.GetRelatedEntities<Task>("service_tasks", null); }
            set
            {
                this.OnPropertyChanging("service_tasks");
                this.SetRelatedEntities<Task>("service_tasks", null, value);
                this.OnPropertyChanged("service_tasks");
            }
        }

        /// <summary>
        /// 1:N userentityinstancedata_service
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_service")]
        public System.Collections.Generic.IEnumerable<UserEntityInstanceData> userentityinstancedata_service
        {
            get { return this.GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_service", null); }
            set
            {
                this.OnPropertyChanging("userentityinstancedata_service");
                this.SetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_service", null, value);
                this.OnPropertyChanged("userentityinstancedata_service");
            }
        }

        /// <summary>
        /// N:1 calendar_services
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("calendarid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("calendar_services")]
        public Calendar calendar_services
        {
            get { return this.GetRelatedEntity<Calendar>("calendar_services", null); }
            set
            {
                this.OnPropertyChanging("calendar_services");
                this.SetRelatedEntity<Calendar>("calendar_services", null, value);
                this.OnPropertyChanged("calendar_services");
            }
        }

        /// <summary>
        /// N:1 lk_service_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_service_createdby")]
        public SystemUser lk_service_createdby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_service_createdby", null); }
        }

        /// <summary>
        /// N:1 lk_service_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_service_createdonbehalfby")]
        public SystemUser lk_service_createdonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_service_createdonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_service_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_service_modifiedby")]
        public SystemUser lk_service_modifiedby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_service_modifiedby", null); }
        }

        /// <summary>
        /// N:1 lk_service_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_service_modifiedonbehalfby")]
        public SystemUser lk_service_modifiedonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_service_modifiedonbehalfby", null); }
        }

        /// <summary>
        /// N:1 organization_services
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_services")]
        public Organization organization_services
        {
            get { return this.GetRelatedEntity<Organization>("organization_services", null); }
        }

        /// <summary>
        /// N:1 plugin_type_service
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("strategyid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("plugin_type_service")]
        public PluginType plugin_type_service
        {
            get { return this.GetRelatedEntity<PluginType>("plugin_type_service", null); }
            set
            {
                this.OnPropertyChanging("plugin_type_service");
                this.SetRelatedEntity<PluginType>("plugin_type_service", null, value);
                this.OnPropertyChanged("plugin_type_service");
            }
        }

        /// <summary>
        /// N:1 resource_spec_services
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("resourcespecid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("resource_spec_services")]
        public ResourceSpec resource_spec_services
        {
            get { return this.GetRelatedEntity<ResourceSpec>("resource_spec_services", null); }
            set
            {
                this.OnPropertyChanging("resource_spec_services");
                this.SetRelatedEntity<ResourceSpec>("resource_spec_services", null, value);
                this.OnPropertyChanged("resource_spec_services");
            }
        }
    }
}