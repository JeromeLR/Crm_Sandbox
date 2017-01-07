namespace __4_DAL_CRM
{
    /// <summary>
    /// Calendar used by the scheduling system to define when an appointment or activity is to occur.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("calendar")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class Calendar : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public Calendar() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "calendar";

        public const int EntityTypeCode = 4003;

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
        /// Unique identifier of the business unit with which the calendar is associated.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("businessunitid")]
        public Microsoft.Xrm.Sdk.EntityReference BusinessUnitId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("businessunitid"); }
            set
            {
                this.OnPropertyChanging("BusinessUnitId");
                this.SetAttributeValue("businessunitid", value);
                this.OnPropertyChanged("BusinessUnitId");
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
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("CalendarId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("calendarid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.CalendarId = value; }
        }

        /// <summary>
        /// Unique identifier of the user who created the calendar.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby"); }
        }

        /// <summary>
        /// Date and time when the calendar was created.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
        public System.Nullable<System.DateTime> CreatedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who created the calendar.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        /// Calendar used by the scheduling system to define when an appointment or activity is to occur.
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
        /// Holiday Schedule CalendarId
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("holidayschedulecalendarid")]
        public Microsoft.Xrm.Sdk.EntityReference HolidayScheduleCalendarId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("holidayschedulecalendarid"); }
            set
            {
                this.OnPropertyChanging("HolidayScheduleCalendarId");
                this.SetAttributeValue("holidayschedulecalendarid", value);
                this.OnPropertyChanged("HolidayScheduleCalendarId");
            }
        }

        /// <summary>
        /// Calendar is shared by other calendars, such as the organization calendar.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isshared")]
        public System.Nullable<bool> IsShared
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("isshared"); }
            set
            {
                this.OnPropertyChanging("IsShared");
                this.SetAttributeValue("isshared", value);
                this.OnPropertyChanged("IsShared");
            }
        }

        /// <summary>
        /// Unique identifier of the user who last modified the calendar.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby"); }
        }

        /// <summary>
        /// Date and time when the calendar was last modified.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
        public System.Nullable<System.DateTime> ModifiedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who last modified the calendar.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        /// Name of the calendar.
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
        /// Unique identifier of the organization with which the calendar is associated.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
        public Microsoft.Xrm.Sdk.EntityReference OrganizationId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("organizationid"); }
        }

        /// <summary>
        /// Unique identifier of the primary user of this calendar.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("primaryuserid")]
        public System.Nullable<System.Guid> PrimaryUserId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("primaryuserid"); }
            set
            {
                this.OnPropertyChanging("PrimaryUserId");
                this.SetAttributeValue("primaryuserid", value);
                this.OnPropertyChanged("PrimaryUserId");
            }
        }

        /// <summary>
        /// Calendar type, such as User work hour calendar, or Customer service hour calendar.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("type")]
        public Microsoft.Xrm.Sdk.OptionSetValue Type
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("type"); }
            set
            {
                this.OnPropertyChanging("Type");
                this.SetAttributeValue("type", value);
                this.OnPropertyChanged("Type");
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
        /// 1:N BusinessUnit_Calendar
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("BusinessUnit_Calendar")]
        public System.Collections.Generic.IEnumerable<BusinessUnit> BusinessUnit_Calendar
        {
            get { return this.GetRelatedEntities<BusinessUnit>("BusinessUnit_Calendar", null); }
            set
            {
                this.OnPropertyChanging("BusinessUnit_Calendar");
                this.SetRelatedEntities<BusinessUnit>("BusinessUnit_Calendar", null, value);
                this.OnPropertyChanged("BusinessUnit_Calendar");
            }
        }

        /// <summary>
        /// 1:N Calendar_Annotation
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Calendar_Annotation")]
        public System.Collections.Generic.IEnumerable<Annotation> Calendar_Annotation
        {
            get { return this.GetRelatedEntities<Annotation>("Calendar_Annotation", null); }
            set
            {
                this.OnPropertyChanging("Calendar_Annotation");
                this.SetRelatedEntities<Annotation>("Calendar_Annotation", null, value);
                this.OnPropertyChanged("Calendar_Annotation");
            }
        }

        /// <summary>
        /// 1:N Calendar_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Calendar_AsyncOperations")]
        public System.Collections.Generic.IEnumerable<AsyncOperation> Calendar_AsyncOperations
        {
            get { return this.GetRelatedEntities<AsyncOperation>("Calendar_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("Calendar_AsyncOperations");
                this.SetRelatedEntities<AsyncOperation>("Calendar_AsyncOperations", null, value);
                this.OnPropertyChanged("Calendar_AsyncOperations");
            }
        }

        /// <summary>
        /// 1:N Calendar_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Calendar_BulkDeleteFailures")]
        public System.Collections.Generic.IEnumerable<BulkDeleteFailure> Calendar_BulkDeleteFailures
        {
            get { return this.GetRelatedEntities<BulkDeleteFailure>("Calendar_BulkDeleteFailures", null); }
            set
            {
                this.OnPropertyChanging("Calendar_BulkDeleteFailures");
                this.SetRelatedEntities<BulkDeleteFailure>("Calendar_BulkDeleteFailures", null, value);
                this.OnPropertyChanged("Calendar_BulkDeleteFailures");
            }
        }

        /// <summary>
        /// 1:N calendar_calendar_rules
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
        /// 1:N calendar_customercalendar_holidaycalendar
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("calendar_customercalendar_holidaycalendar", Microsoft.Xrm.Sdk.EntityRole.Referenced)]
        public System.Collections.Generic.IEnumerable<Calendar> Referencedcalendar_customercalendar_holidaycalendar
        {
            get { return this.GetRelatedEntities<Calendar>("calendar_customercalendar_holidaycalendar", Microsoft.Xrm.Sdk.EntityRole.Referenced); }
            set
            {
                this.OnPropertyChanging("Referencedcalendar_customercalendar_holidaycalendar");
                this.SetRelatedEntities<Calendar>("calendar_customercalendar_holidaycalendar", Microsoft.Xrm.Sdk.EntityRole.Referenced, value);
                this.OnPropertyChanged("Referencedcalendar_customercalendar_holidaycalendar");
            }
        }

        /// <summary>
        /// 1:N calendar_equipment
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("calendar_equipment")]
        public System.Collections.Generic.IEnumerable<Equipment> calendar_equipment
        {
            get { return this.GetRelatedEntities<Equipment>("calendar_equipment", null); }
            set
            {
                this.OnPropertyChanging("calendar_equipment");
                this.SetRelatedEntities<Equipment>("calendar_equipment", null, value);
                this.OnPropertyChanged("calendar_equipment");
            }
        }

        /// <summary>
        /// 1:N calendar_organization
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("calendar_organization")]
        public System.Collections.Generic.IEnumerable<Organization> calendar_organization
        {
            get { return this.GetRelatedEntities<Organization>("calendar_organization", null); }
            set
            {
                this.OnPropertyChanging("calendar_organization");
                this.SetRelatedEntities<Organization>("calendar_organization", null, value);
                this.OnPropertyChanged("calendar_organization");
            }
        }

        /// <summary>
        /// 1:N calendar_services
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("calendar_services")]
        public System.Collections.Generic.IEnumerable<Service> calendar_services
        {
            get { return this.GetRelatedEntities<Service>("calendar_services", null); }
            set
            {
                this.OnPropertyChanging("calendar_services");
                this.SetRelatedEntities<Service>("calendar_services", null, value);
                this.OnPropertyChanged("calendar_services");
            }
        }

        /// <summary>
        /// 1:N calendar_system_users
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("calendar_system_users")]
        public System.Collections.Generic.IEnumerable<SystemUser> calendar_system_users
        {
            get { return this.GetRelatedEntities<SystemUser>("calendar_system_users", null); }
            set
            {
                this.OnPropertyChanging("calendar_system_users");
                this.SetRelatedEntities<SystemUser>("calendar_system_users", null, value);
                this.OnPropertyChanged("calendar_system_users");
            }
        }

        /// <summary>
        /// 1:N slabase_businesshoursid
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("slabase_businesshoursid")]
        public System.Collections.Generic.IEnumerable<SLA> slabase_businesshoursid
        {
            get { return this.GetRelatedEntities<SLA>("slabase_businesshoursid", null); }
            set
            {
                this.OnPropertyChanging("slabase_businesshoursid");
                this.SetRelatedEntities<SLA>("slabase_businesshoursid", null, value);
                this.OnPropertyChanged("slabase_businesshoursid");
            }
        }

        /// <summary>
        /// 1:N userentityinstancedata_calendar
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_calendar")]
        public System.Collections.Generic.IEnumerable<UserEntityInstanceData> userentityinstancedata_calendar
        {
            get { return this.GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_calendar", null); }
            set
            {
                this.OnPropertyChanging("userentityinstancedata_calendar");
                this.SetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_calendar", null, value);
                this.OnPropertyChanged("userentityinstancedata_calendar");
            }
        }

        /// <summary>
        /// N:1 business_unit_calendars
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("businessunitid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_calendars")]
        public BusinessUnit business_unit_calendars
        {
            get { return this.GetRelatedEntity<BusinessUnit>("business_unit_calendars", null); }
            set
            {
                this.OnPropertyChanging("business_unit_calendars");
                this.SetRelatedEntity<BusinessUnit>("business_unit_calendars", null, value);
                this.OnPropertyChanged("business_unit_calendars");
            }
        }

        /// <summary>
        /// N:1 calendar_customercalendar_holidaycalendar
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("holidayschedulecalendarid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("calendar_customercalendar_holidaycalendar", Microsoft.Xrm.Sdk.EntityRole.Referencing)]
        public Calendar Referencingcalendar_customercalendar_holidaycalendar
        {
            get { return this.GetRelatedEntity<Calendar>("calendar_customercalendar_holidaycalendar", Microsoft.Xrm.Sdk.EntityRole.Referencing); }
            set
            {
                this.OnPropertyChanging("Referencingcalendar_customercalendar_holidaycalendar");
                this.SetRelatedEntity<Calendar>("calendar_customercalendar_holidaycalendar", Microsoft.Xrm.Sdk.EntityRole.Referencing, value);
                this.OnPropertyChanged("Referencingcalendar_customercalendar_holidaycalendar");
            }
        }

        /// <summary>
        /// N:1 lk_calendar_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_calendar_createdby")]
        public SystemUser lk_calendar_createdby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_calendar_createdby", null); }
        }

        /// <summary>
        /// N:1 lk_calendar_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_calendar_createdonbehalfby")]
        public SystemUser lk_calendar_createdonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_calendar_createdonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_calendar_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_calendar_modifiedby")]
        public SystemUser lk_calendar_modifiedby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_calendar_modifiedby", null); }
        }

        /// <summary>
        /// N:1 lk_calendar_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_calendar_modifiedonbehalfby")]
        public SystemUser lk_calendar_modifiedonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_calendar_modifiedonbehalfby", null); }
        }

        /// <summary>
        /// N:1 organization_calendars
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_calendars")]
        public Organization organization_calendars
        {
            get { return this.GetRelatedEntity<Organization>("organization_calendars", null); }
        }
    }
}