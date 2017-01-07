using _4_DAL_CRM;

namespace __4_DAL_CRM
{

    /// <summary>
    /// Person or group associated with an activity. An activity can have multiple activity parties.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("activityparty")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class ActivityParty : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public ActivityParty() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "activityparty";

        public const int EntityTypeCode = 135;

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
        /// Unique identifier of the activity associated with the activity party. (A "party" is any person who is associated with an activity.)
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("activityid")]
        public Microsoft.Xrm.Sdk.EntityReference ActivityId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("activityid"); }
            set
            {
                this.OnPropertyChanging("ActivityId");
                this.SetAttributeValue("activityid", value);
                this.OnPropertyChanged("ActivityId");
            }
        }

        /// <summary>
        /// Unique identifier of the activity party.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("activitypartyid")]
        public System.Nullable<System.Guid> ActivityPartyId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("activitypartyid"); }
            set
            {
                this.OnPropertyChanging("ActivityPartyId");
                this.SetAttributeValue("activitypartyid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("ActivityPartyId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("activitypartyid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.ActivityPartyId = value; }
        }

        /// <summary>
        /// Email address to which an email is delivered, and which is associated with the target entity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("addressused")]
        public string AddressUsed
        {
            get { return this.GetAttributeValue<string>("addressused"); }
            set
            {
                this.OnPropertyChanging("AddressUsed");
                this.SetAttributeValue("addressused", value);
                this.OnPropertyChanged("AddressUsed");
            }
        }

        /// <summary>
        /// Email address column number from associated party.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("addressusedemailcolumnnumber")]
        public System.Nullable<int> AddressUsedEmailColumnNumber
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("addressusedemailcolumnnumber"); }
        }

        /// <summary>
        /// Information about whether to allow sending email to the activity party.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("donotemail")]
        public System.Nullable<bool> DoNotEmail
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("donotemail"); }
        }

        /// <summary>
        /// Information about whether to allow sending faxes to the activity party.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("donotfax")]
        public System.Nullable<bool> DoNotFax
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("donotfax"); }
        }

        /// <summary>
        /// Information about whether to allow phone calls to the lead.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("donotphone")]
        public System.Nullable<bool> DoNotPhone
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("donotphone"); }
        }

        /// <summary>
        /// Information about whether to allow sending postal mail to the lead.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("donotpostalmail")]
        public System.Nullable<bool> DoNotPostalMail
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("donotpostalmail"); }
        }

        /// <summary>
        /// Amount of effort used by the resource in a service appointment activity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("effort")]
        public System.Nullable<double> Effort
        {
            get { return this.GetAttributeValue<System.Nullable<double>>("effort"); }
            set
            {
                this.OnPropertyChanging("Effort");
                this.SetAttributeValue("effort", value);
                this.OnPropertyChanged("Effort");
            }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("exchangeentryid")]
        public string ExchangeEntryId
        {
            get { return this.GetAttributeValue<string>("exchangeentryid"); }
            set
            {
                this.OnPropertyChanging("ExchangeEntryId");
                this.SetAttributeValue("exchangeentryid", value);
                this.OnPropertyChanged("ExchangeEntryId");
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
        /// Information about whether the underlying entity record is deleted.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ispartydeleted")]
        public System.Nullable<bool> IsPartyDeleted
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("ispartydeleted"); }
        }

        /// <summary>
        /// Unique identifier of the user or team who owns the activity_party.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ownerid")]
        public Microsoft.Xrm.Sdk.EntityReference OwnerId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("ownerid"); }
        }

        /// <summary>
        /// Role of the person in the activity, such as sender, to, cc, bcc, required, optional, organizer, regarding, or owner.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("participationtypemask")]
        public Microsoft.Xrm.Sdk.OptionSetValue ParticipationTypeMask
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("participationtypemask"); }
            set
            {
                this.OnPropertyChanging("ParticipationTypeMask");
                this.SetAttributeValue("participationtypemask", value);
                this.OnPropertyChanged("ParticipationTypeMask");
            }
        }

        /// <summary>
        /// Unique identifier of the party associated with the activity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("partyid")]
        public Microsoft.Xrm.Sdk.EntityReference PartyId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("partyid"); }
            set
            {
                this.OnPropertyChanging("PartyId");
                this.SetAttributeValue("partyid", value);
                this.OnPropertyChanged("PartyId");
            }
        }

        /// <summary>
        /// Unique identifier of the resource specification for the activity party.
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
        /// Scheduled end time of the activity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("scheduledend")]
        public System.Nullable<System.DateTime> ScheduledEnd
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("scheduledend"); }
        }

        /// <summary>
        /// Scheduled start time of the activity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("scheduledstart")]
        public System.Nullable<System.DateTime> ScheduledStart
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("scheduledstart"); }
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
        /// 1:N userentityinstancedata_activityparty
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_activityparty")]
        public System.Collections.Generic.IEnumerable<UserEntityInstanceData> userentityinstancedata_activityparty
        {
            get { return this.GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_activityparty", null); }
            set
            {
                this.OnPropertyChanging("userentityinstancedata_activityparty");
                this.SetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_activityparty", null, value);
                this.OnPropertyChanged("userentityinstancedata_activityparty");
            }
        }

        /// <summary>
        /// N:1 account_activity_parties
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("partyid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("account_activity_parties")]
        public Account account_activity_parties
        {
            get { return this.GetRelatedEntity<Account>("account_activity_parties", null); }
            set
            {
                this.OnPropertyChanging("account_activity_parties");
                this.SetRelatedEntity<Account>("account_activity_parties", null, value);
                this.OnPropertyChanged("account_activity_parties");
            }
        }

        /// <summary>
        /// N:1 ActivityPartyResourceSpec
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("resourcespecid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ActivityPartyResourceSpec")]
        public ResourceSpec ActivityPartyResourceSpec
        {
            get { return this.GetRelatedEntity<ResourceSpec>("ActivityPartyResourceSpec", null); }
            set
            {
                this.OnPropertyChanging("ActivityPartyResourceSpec");
                this.SetRelatedEntity<ResourceSpec>("ActivityPartyResourceSpec", null, value);
                this.OnPropertyChanged("ActivityPartyResourceSpec");
            }
        }

        /// <summary>
        /// N:1 activitypointer_activity_parties
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("activityid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("activitypointer_activity_parties")]
        public ActivityPointer activitypointer_activity_parties
        {
            get { return this.GetRelatedEntity<ActivityPointer>("activitypointer_activity_parties", null); }
            set
            {
                this.OnPropertyChanging("activitypointer_activity_parties");
                this.SetRelatedEntity<ActivityPointer>("activitypointer_activity_parties", null, value);
                this.OnPropertyChanged("activitypointer_activity_parties");
            }
        }

        /// <summary>
        /// N:1 appointment_activity_parties
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("activityid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("appointment_activity_parties")]
        public Appointment appointment_activity_parties
        {
            get { return this.GetRelatedEntity<Appointment>("appointment_activity_parties", null); }
            set
            {
                this.OnPropertyChanging("appointment_activity_parties");
                this.SetRelatedEntity<Appointment>("appointment_activity_parties", null, value);
                this.OnPropertyChanged("appointment_activity_parties");
            }
        }

        /// <summary>
        /// N:1 bulkoperation_activity_parties
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("partyid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("bulkoperation_activity_parties")]
        public BulkOperation bulkoperation_activity_parties
        {
            get { return this.GetRelatedEntity<BulkOperation>("bulkoperation_activity_parties", null); }
            set
            {
                this.OnPropertyChanging("bulkoperation_activity_parties");
                this.SetRelatedEntity<BulkOperation>("bulkoperation_activity_parties", null, value);
                this.OnPropertyChanged("bulkoperation_activity_parties");
            }
        }

        /// <summary>
        /// N:1 campaign_activity_parties
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("partyid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("campaign_activity_parties")]
        public Campaign campaign_activity_parties
        {
            get { return this.GetRelatedEntity<Campaign>("campaign_activity_parties", null); }
            set
            {
                this.OnPropertyChanging("campaign_activity_parties");
                this.SetRelatedEntity<Campaign>("campaign_activity_parties", null, value);
                this.OnPropertyChanged("campaign_activity_parties");
            }
        }

        /// <summary>
        /// N:1 campaignactivity_activity_parties
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("activityid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("campaignactivity_activity_parties")]
        public CampaignActivity campaignactivity_activity_parties
        {
            get { return this.GetRelatedEntity<CampaignActivity>("campaignactivity_activity_parties", null); }
            set
            {
                this.OnPropertyChanging("campaignactivity_activity_parties");
                this.SetRelatedEntity<CampaignActivity>("campaignactivity_activity_parties", null, value);
                this.OnPropertyChanged("campaignactivity_activity_parties");
            }
        }

        /// <summary>
        /// N:1 campaignactivity_activityparties
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("partyid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("campaignactivity_activityparties")]
        public CampaignActivity campaignactivity_activityparties
        {
            get { return this.GetRelatedEntity<CampaignActivity>("campaignactivity_activityparties", null); }
            set
            {
                this.OnPropertyChanging("campaignactivity_activityparties");
                this.SetRelatedEntity<CampaignActivity>("campaignactivity_activityparties", null, value);
                this.OnPropertyChanged("campaignactivity_activityparties");
            }
        }

        /// <summary>
        /// N:1 campaignresponse_activity_parties
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("activityid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("campaignresponse_activity_parties")]
        public CampaignResponse campaignresponse_activity_parties
        {
            get { return this.GetRelatedEntity<CampaignResponse>("campaignresponse_activity_parties", null); }
            set
            {
                this.OnPropertyChanging("campaignresponse_activity_parties");
                this.SetRelatedEntity<CampaignResponse>("campaignresponse_activity_parties", null, value);
                this.OnPropertyChanged("campaignresponse_activity_parties");
            }
        }

        /// <summary>
        /// N:1 contact_activity_parties
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("partyid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("contact_activity_parties")]
        public Contact contact_activity_parties
        {
            get { return this.GetRelatedEntity<Contact>("contact_activity_parties", null); }
            set
            {
                this.OnPropertyChanging("contact_activity_parties");
                this.SetRelatedEntity<Contact>("contact_activity_parties", null, value);
                this.OnPropertyChanged("contact_activity_parties");
            }
        }

        /// <summary>
        /// N:1 contract_activity_parties
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("partyid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("contract_activity_parties")]
        public Contract contract_activity_parties
        {
            get { return this.GetRelatedEntity<Contract>("contract_activity_parties", null); }
            set
            {
                this.OnPropertyChanging("contract_activity_parties");
                this.SetRelatedEntity<Contract>("contract_activity_parties", null, value);
                this.OnPropertyChanged("contract_activity_parties");
            }
        }

        /// <summary>
        /// N:1 email_activity_parties
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("activityid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("email_activity_parties")]
        public Email email_activity_parties
        {
            get { return this.GetRelatedEntity<Email>("email_activity_parties", null); }
            set
            {
                this.OnPropertyChanging("email_activity_parties");
                this.SetRelatedEntity<Email>("email_activity_parties", null, value);
                this.OnPropertyChanged("email_activity_parties");
            }
        }

        /// <summary>
        /// N:1 equipment_activity_parties
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("partyid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("equipment_activity_parties")]
        public Equipment equipment_activity_parties
        {
            get { return this.GetRelatedEntity<Equipment>("equipment_activity_parties", null); }
            set
            {
                this.OnPropertyChanging("equipment_activity_parties");
                this.SetRelatedEntity<Equipment>("equipment_activity_parties", null, value);
                this.OnPropertyChanged("equipment_activity_parties");
            }
        }

        /// <summary>
        /// N:1 fax_activity_parties
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("activityid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("fax_activity_parties")]
        public Fax fax_activity_parties
        {
            get { return this.GetRelatedEntity<Fax>("fax_activity_parties", null); }
            set
            {
                this.OnPropertyChanging("fax_activity_parties");
                this.SetRelatedEntity<Fax>("fax_activity_parties", null, value);
                this.OnPropertyChanged("fax_activity_parties");
            }
        }

        /// <summary>
        /// N:1 incident_activity_parties
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("partyid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("incident_activity_parties")]
        public Incident incident_activity_parties
        {
            get { return this.GetRelatedEntity<Incident>("incident_activity_parties", null); }
            set
            {
                this.OnPropertyChanging("incident_activity_parties");
                this.SetRelatedEntity<Incident>("incident_activity_parties", null, value);
                this.OnPropertyChanged("incident_activity_parties");
            }
        }

        /// <summary>
        /// N:1 incidentresolution_activity_parties
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("activityid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("incidentresolution_activity_parties")]
        public IncidentResolution incidentresolution_activity_parties
        {
            get { return this.GetRelatedEntity<IncidentResolution>("incidentresolution_activity_parties", null); }
            set
            {
                this.OnPropertyChanging("incidentresolution_activity_parties");
                this.SetRelatedEntity<IncidentResolution>("incidentresolution_activity_parties", null, value);
                this.OnPropertyChanged("incidentresolution_activity_parties");
            }
        }

        /// <summary>
        /// N:1 invoice_activity_parties
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("partyid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("invoice_activity_parties")]
        public Invoice invoice_activity_parties
        {
            get { return this.GetRelatedEntity<Invoice>("invoice_activity_parties", null); }
            set
            {
                this.OnPropertyChanging("invoice_activity_parties");
                this.SetRelatedEntity<Invoice>("invoice_activity_parties", null, value);
                this.OnPropertyChanged("invoice_activity_parties");
            }
        }

        /// <summary>
        /// N:1 lead_activity_parties
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("partyid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lead_activity_parties")]
        public Lead lead_activity_parties
        {
            get { return this.GetRelatedEntity<Lead>("lead_activity_parties", null); }
            set
            {
                this.OnPropertyChanging("lead_activity_parties");
                this.SetRelatedEntity<Lead>("lead_activity_parties", null, value);
                this.OnPropertyChanged("lead_activity_parties");
            }
        }

        /// <summary>
        /// N:1 letter_activity_parties
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("activityid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("letter_activity_parties")]
        public Letter letter_activity_parties
        {
            get { return this.GetRelatedEntity<Letter>("letter_activity_parties", null); }
            set
            {
                this.OnPropertyChanging("letter_activity_parties");
                this.SetRelatedEntity<Letter>("letter_activity_parties", null, value);
                this.OnPropertyChanged("letter_activity_parties");
            }
        }

        /// <summary>
        /// N:1 opportunity_activity_parties
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("partyid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("opportunity_activity_parties")]
        public Opportunity opportunity_activity_parties
        {
            get { return this.GetRelatedEntity<Opportunity>("opportunity_activity_parties", null); }
            set
            {
                this.OnPropertyChanging("opportunity_activity_parties");
                this.SetRelatedEntity<Opportunity>("opportunity_activity_parties", null, value);
                this.OnPropertyChanged("opportunity_activity_parties");
            }
        }

        /// <summary>
        /// N:1 opportunityclose_activity_parties
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("activityid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("opportunityclose_activity_parties")]
        public OpportunityClose opportunityclose_activity_parties
        {
            get { return this.GetRelatedEntity<OpportunityClose>("opportunityclose_activity_parties", null); }
            set
            {
                this.OnPropertyChanging("opportunityclose_activity_parties");
                this.SetRelatedEntity<OpportunityClose>("opportunityclose_activity_parties", null, value);
                this.OnPropertyChanged("opportunityclose_activity_parties");
            }
        }

        /// <summary>
        /// N:1 orderclose_activity_parties
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("activityid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("orderclose_activity_parties")]
        public OrderClose orderclose_activity_parties
        {
            get { return this.GetRelatedEntity<OrderClose>("orderclose_activity_parties", null); }
            set
            {
                this.OnPropertyChanging("orderclose_activity_parties");
                this.SetRelatedEntity<OrderClose>("orderclose_activity_parties", null, value);
                this.OnPropertyChanged("orderclose_activity_parties");
            }
        }

        /// <summary>
        /// N:1 phonecall_activity_parties
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("activityid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("phonecall_activity_parties")]
        public PhoneCall phonecall_activity_parties
        {
            get { return this.GetRelatedEntity<PhoneCall>("phonecall_activity_parties", null); }
            set
            {
                this.OnPropertyChanging("phonecall_activity_parties");
                this.SetRelatedEntity<PhoneCall>("phonecall_activity_parties", null, value);
                this.OnPropertyChanged("phonecall_activity_parties");
            }
        }

        /// <summary>
        /// N:1 queue_activity_parties
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("partyid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("queue_activity_parties")]
        public Queue queue_activity_parties
        {
            get { return this.GetRelatedEntity<Queue>("queue_activity_parties", null); }
            set
            {
                this.OnPropertyChanging("queue_activity_parties");
                this.SetRelatedEntity<Queue>("queue_activity_parties", null, value);
                this.OnPropertyChanged("queue_activity_parties");
            }
        }

        /// <summary>
        /// N:1 quote_activity_parties
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("partyid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("quote_activity_parties")]
        public Quote quote_activity_parties
        {
            get { return this.GetRelatedEntity<Quote>("quote_activity_parties", null); }
            set
            {
                this.OnPropertyChanging("quote_activity_parties");
                this.SetRelatedEntity<Quote>("quote_activity_parties", null, value);
                this.OnPropertyChanged("quote_activity_parties");
            }
        }

        /// <summary>
        /// N:1 quoteclose_activity_parties
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("activityid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("quoteclose_activity_parties")]
        public QuoteClose quoteclose_activity_parties
        {
            get { return this.GetRelatedEntity<QuoteClose>("quoteclose_activity_parties", null); }
            set
            {
                this.OnPropertyChanging("quoteclose_activity_parties");
                this.SetRelatedEntity<QuoteClose>("quoteclose_activity_parties", null, value);
                this.OnPropertyChanged("quoteclose_activity_parties");
            }
        }

        /// <summary>
        /// N:1 recurringappointmentmaster_activity_parties
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("activityid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("recurringappointmentmaster_activity_parties")]
        public RecurringAppointmentMaster recurringappointmentmaster_activity_parties
        {
            get { return this.GetRelatedEntity<RecurringAppointmentMaster>("recurringappointmentmaster_activity_parties", null); }
            set
            {
                this.OnPropertyChanging("recurringappointmentmaster_activity_parties");
                this.SetRelatedEntity<RecurringAppointmentMaster>("recurringappointmentmaster_activity_parties", null, value);
                this.OnPropertyChanged("recurringappointmentmaster_activity_parties");
            }
        }

        /// <summary>
        /// N:1 salesorder_activity_parties
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("partyid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("salesorder_activity_parties")]
        public SalesOrder salesorder_activity_parties
        {
            get { return this.GetRelatedEntity<SalesOrder>("salesorder_activity_parties", null); }
            set
            {
                this.OnPropertyChanging("salesorder_activity_parties");
                this.SetRelatedEntity<SalesOrder>("salesorder_activity_parties", null, value);
                this.OnPropertyChanged("salesorder_activity_parties");
            }
        }

        /// <summary>
        /// N:1 serviceappointment_activity_parties
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("activityid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("serviceappointment_activity_parties")]
        public ServiceAppointment serviceappointment_activity_parties
        {
            get { return this.GetRelatedEntity<ServiceAppointment>("serviceappointment_activity_parties", null); }
            set
            {
                this.OnPropertyChanging("serviceappointment_activity_parties");
                this.SetRelatedEntity<ServiceAppointment>("serviceappointment_activity_parties", null, value);
                this.OnPropertyChanged("serviceappointment_activity_parties");
            }
        }

        /// <summary>
        /// N:1 socialactivity_activity_parties
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("activityid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("socialactivity_activity_parties")]
        public SocialActivity socialactivity_activity_parties
        {
            get { return this.GetRelatedEntity<SocialActivity>("socialactivity_activity_parties", null); }
            set
            {
                this.OnPropertyChanging("socialactivity_activity_parties");
                this.SetRelatedEntity<SocialActivity>("socialactivity_activity_parties", null, value);
                this.OnPropertyChanged("socialactivity_activity_parties");
            }
        }

        /// <summary>
        /// N:1 system_user_activity_parties
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("partyid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("system_user_activity_parties")]
        public SystemUser system_user_activity_parties
        {
            get { return this.GetRelatedEntity<SystemUser>("system_user_activity_parties", null); }
            set
            {
                this.OnPropertyChanging("system_user_activity_parties");
                this.SetRelatedEntity<SystemUser>("system_user_activity_parties", null, value);
                this.OnPropertyChanged("system_user_activity_parties");
            }
        }

        /// <summary>
        /// N:1 task_activity_parties
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("activityid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("task_activity_parties")]
        public Task task_activity_parties
        {
            get { return this.GetRelatedEntity<Task>("task_activity_parties", null); }
            set
            {
                this.OnPropertyChanging("task_activity_parties");
                this.SetRelatedEntity<Task>("task_activity_parties", null, value);
                this.OnPropertyChanged("task_activity_parties");
            }
        }
    }
}