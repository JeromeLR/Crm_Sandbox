using _4_DAL_CRM;

namespace __4_DAL_CRM
{
    /// <summary>
    /// Represents a user following the activity feed of an object.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("postfollow")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class PostFollow : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public PostFollow() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "postfollow";

        public const int EntityTypeCode = 8003;

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
        /// Unique identifier for the business unit that owns the record.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
        public Microsoft.Xrm.Sdk.EntityReference OwningBusinessUnit
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningbusinessunit"); }
        }

        /// <summary>
        /// Unique identifier of the team who owns the follow.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
        public Microsoft.Xrm.Sdk.EntityReference OwningTeam
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningteam"); }
        }

        /// <summary>
        /// Unique identifier for the user who owns the record.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
        public Microsoft.Xrm.Sdk.EntityReference OwningUser
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owninguser"); }
        }

        /// <summary>
        /// Shows the ID of the post follow.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("postfollowid")]
        public System.Nullable<System.Guid> PostFollowId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("postfollowid"); }
            set
            {
                this.OnPropertyChanging("PostFollowId");
                this.SetAttributeValue("postfollowid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("PostFollowId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("postfollowid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.PostFollowId = value; }
        }

        /// <summary>
        /// Choose the parent record for the followed post to identify the customer, opportunity, case, or other record type that the post most closely relates to.
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
        /// Internal Use Only
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("yammerpoststate")]
        public System.Nullable<int> YammerPostState
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("yammerpoststate"); }
        }

        /// <summary>
        /// 1:N PostFollow_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("PostFollow_AsyncOperations")]
        public System.Collections.Generic.IEnumerable<AsyncOperation> PostFollow_AsyncOperations
        {
            get { return this.GetRelatedEntities<AsyncOperation>("PostFollow_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("PostFollow_AsyncOperations");
                this.SetRelatedEntities<AsyncOperation>("PostFollow_AsyncOperations", null, value);
                this.OnPropertyChanged("PostFollow_AsyncOperations");
            }
        }

        /// <summary>
        /// N:1 account_PostFollows
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("account_PostFollows")]
        public Account account_PostFollows
        {
            get { return this.GetRelatedEntity<Account>("account_PostFollows", null); }
            set
            {
                this.OnPropertyChanging("account_PostFollows");
                this.SetRelatedEntity<Account>("account_PostFollows", null, value);
                this.OnPropertyChanged("account_PostFollows");
            }
        }

        /// <summary>
        /// N:1 appointment_PostFollows
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("appointment_PostFollows")]
        public Appointment appointment_PostFollows
        {
            get { return this.GetRelatedEntity<Appointment>("appointment_PostFollows", null); }
            set
            {
                this.OnPropertyChanging("appointment_PostFollows");
                this.SetRelatedEntity<Appointment>("appointment_PostFollows", null, value);
                this.OnPropertyChanged("appointment_PostFollows");
            }
        }

        /// <summary>
        /// N:1 business_unit_postfollows
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_postfollows")]
        public BusinessUnit business_unit_postfollows
        {
            get { return this.GetRelatedEntity<BusinessUnit>("business_unit_postfollows", null); }
        }

        /// <summary>
        /// N:1 competitor_PostFollows
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("competitor_PostFollows")]
        public Competitor competitor_PostFollows
        {
            get { return this.GetRelatedEntity<Competitor>("competitor_PostFollows", null); }
            set
            {
                this.OnPropertyChanging("competitor_PostFollows");
                this.SetRelatedEntity<Competitor>("competitor_PostFollows", null, value);
                this.OnPropertyChanged("competitor_PostFollows");
            }
        }

        /// <summary>
        /// N:1 contact_PostFollows
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("contact_PostFollows")]
        public Contact contact_PostFollows
        {
            get { return this.GetRelatedEntity<Contact>("contact_PostFollows", null); }
            set
            {
                this.OnPropertyChanging("contact_PostFollows");
                this.SetRelatedEntity<Contact>("contact_PostFollows", null, value);
                this.OnPropertyChanged("contact_PostFollows");
            }
        }

        /// <summary>
        /// N:1 incident_PostFollows
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("incident_PostFollows")]
        public Incident incident_PostFollows
        {
            get { return this.GetRelatedEntity<Incident>("incident_PostFollows", null); }
            set
            {
                this.OnPropertyChanging("incident_PostFollows");
                this.SetRelatedEntity<Incident>("incident_PostFollows", null, value);
                this.OnPropertyChanged("incident_PostFollows");
            }
        }

        /// <summary>
        /// N:1 lead_PostFollows
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lead_PostFollows")]
        public Lead lead_PostFollows
        {
            get { return this.GetRelatedEntity<Lead>("lead_PostFollows", null); }
            set
            {
                this.OnPropertyChanging("lead_PostFollows");
                this.SetRelatedEntity<Lead>("lead_PostFollows", null, value);
                this.OnPropertyChanged("lead_PostFollows");
            }
        }

        /// <summary>
        /// N:1 lk_PostFollow_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_PostFollow_createdby")]
        public SystemUser lk_PostFollow_createdby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_PostFollow_createdby", null); }
        }

        /// <summary>
        /// N:1 lk_postfollow_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_postfollow_createdonbehalfby")]
        public SystemUser lk_postfollow_createdonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_postfollow_createdonbehalfby", null); }
        }

        /// <summary>
        /// N:1 opportunity_PostFollows
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("opportunity_PostFollows")]
        public Opportunity opportunity_PostFollows
        {
            get { return this.GetRelatedEntity<Opportunity>("opportunity_PostFollows", null); }
            set
            {
                this.OnPropertyChanging("opportunity_PostFollows");
                this.SetRelatedEntity<Opportunity>("opportunity_PostFollows", null, value);
                this.OnPropertyChanged("opportunity_PostFollows");
            }
        }

        /// <summary>
        /// N:1 OwningTeam_postfollows
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("OwningTeam_postfollows")]
        public Team OwningTeam_postfollows
        {
            get { return this.GetRelatedEntity<Team>("OwningTeam_postfollows", null); }
        }

        /// <summary>
        /// N:1 phonecall_PostFollows
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("phonecall_PostFollows")]
        public PhoneCall phonecall_PostFollows
        {
            get { return this.GetRelatedEntity<PhoneCall>("phonecall_PostFollows", null); }
            set
            {
                this.OnPropertyChanging("phonecall_PostFollows");
                this.SetRelatedEntity<PhoneCall>("phonecall_PostFollows", null, value);
                this.OnPropertyChanged("phonecall_PostFollows");
            }
        }

        /// <summary>
        /// N:1 processsession_PostFollows
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("processsession_PostFollows")]
        public ProcessSession processsession_PostFollows
        {
            get { return this.GetRelatedEntity<ProcessSession>("processsession_PostFollows", null); }
            set
            {
                this.OnPropertyChanging("processsession_PostFollows");
                this.SetRelatedEntity<ProcessSession>("processsession_PostFollows", null, value);
                this.OnPropertyChanged("processsession_PostFollows");
            }
        }

        /// <summary>
        /// N:1 queue_PostFollows
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("queue_PostFollows")]
        public Queue queue_PostFollows
        {
            get { return this.GetRelatedEntity<Queue>("queue_PostFollows", null); }
            set
            {
                this.OnPropertyChanging("queue_PostFollows");
                this.SetRelatedEntity<Queue>("queue_PostFollows", null, value);
                this.OnPropertyChanged("queue_PostFollows");
            }
        }

        /// <summary>
        /// N:1 recurringappointmentmaster_PostFollows
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("recurringappointmentmaster_PostFollows")]
        public RecurringAppointmentMaster recurringappointmentmaster_PostFollows
        {
            get { return this.GetRelatedEntity<RecurringAppointmentMaster>("recurringappointmentmaster_PostFollows", null); }
            set
            {
                this.OnPropertyChanging("recurringappointmentmaster_PostFollows");
                this.SetRelatedEntity<RecurringAppointmentMaster>("recurringappointmentmaster_PostFollows", null, value);
                this.OnPropertyChanged("recurringappointmentmaster_PostFollows");
            }
        }

        /// <summary>
        /// N:1 systemuser_PostFollows
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("systemuser_PostFollows")]
        public SystemUser systemuser_PostFollows
        {
            get { return this.GetRelatedEntity<SystemUser>("systemuser_PostFollows", null); }
            set
            {
                this.OnPropertyChanging("systemuser_PostFollows");
                this.SetRelatedEntity<SystemUser>("systemuser_PostFollows", null, value);
                this.OnPropertyChanged("systemuser_PostFollows");
            }
        }

        /// <summary>
        /// N:1 task_PostFollows
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("task_PostFollows")]
        public Task task_PostFollows
        {
            get { return this.GetRelatedEntity<Task>("task_PostFollows", null); }
            set
            {
                this.OnPropertyChanging("task_PostFollows");
                this.SetRelatedEntity<Task>("task_PostFollows", null, value);
                this.OnPropertyChanged("task_PostFollows");
            }
        }

        /// <summary>
        /// N:1 user_owner_postfollows
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_owner_postfollows")]
        public SystemUser user_owner_postfollows
        {
            get { return this.GetRelatedEntity<SystemUser>("user_owner_postfollows", null); }
        }
    }
}