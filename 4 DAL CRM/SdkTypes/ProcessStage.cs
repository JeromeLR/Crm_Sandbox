using _4_DAL_CRM;

namespace __4_DAL_CRM
{
    /// <summary>
    /// Stage associated with a process.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("processstage")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class ProcessStage : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public ProcessStage() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "processstage";

        public const int EntityTypeCode = 4724;

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
        /// Enter the user or team who is assigned to manage the record. This field is updated every time the record is assigned to a different user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ownerid")]
        public Microsoft.Xrm.Sdk.EntityReference OwnerId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("ownerid"); }
        }

        /// <summary>
        /// Select the business unit that owns the record.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
        public System.Nullable<System.Guid> OwningBusinessUnit
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("owningbusinessunit"); }
        }

        /// <summary>
        /// Primary entity associated with the stage.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("primaryentitytypecode")]
        public string PrimaryEntityTypeCode
        {
            get { return this.GetAttributeValue<string>("primaryentitytypecode"); }
            set
            {
                this.OnPropertyChanging("PrimaryEntityTypeCode");
                this.SetAttributeValue("primaryentitytypecode", value);
                this.OnPropertyChanged("PrimaryEntityTypeCode");
            }
        }

        /// <summary>
        /// Shows the ID of the process.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("processid")]
        public Microsoft.Xrm.Sdk.EntityReference ProcessId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("processid"); }
            set
            {
                this.OnPropertyChanging("ProcessId");
                this.SetAttributeValue("processid", value);
                this.OnPropertyChanged("ProcessId");
            }
        }

        /// <summary>
        /// Shows the ID of the process stage record.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("processstageid")]
        public System.Nullable<System.Guid> ProcessStageId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("processstageid"); }
            set
            {
                this.OnPropertyChanging("ProcessStageId");
                this.SetAttributeValue("processstageid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("ProcessStageId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("processstageid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.ProcessStageId = value; }
        }

        /// <summary>
        /// Select the category of the sales process.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("stagecategory")]
        public Microsoft.Xrm.Sdk.OptionSetValue StageCategory
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("stagecategory"); }
            set
            {
                this.OnPropertyChanging("StageCategory");
                this.SetAttributeValue("stagecategory", value);
                this.OnPropertyChanged("StageCategory");
            }
        }

        /// <summary>
        /// Type a name for the process stage.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("stagename")]
        public string StageName
        {
            get { return this.GetAttributeValue<string>("stagename"); }
            set
            {
                this.OnPropertyChanging("StageName");
                this.SetAttributeValue("stagename", value);
                this.OnPropertyChanged("StageName");
            }
        }

        /// <summary>
        /// Version number of the process stage.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
        public System.Nullable<long> VersionNumber
        {
            get { return this.GetAttributeValue<System.Nullable<long>>("versionnumber"); }
        }

        /// <summary>
        /// 1:N processstage_account
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("processstage_account")]
        public System.Collections.Generic.IEnumerable<Account> processstage_account
        {
            get { return this.GetRelatedEntities<Account>("processstage_account", null); }
            set
            {
                this.OnPropertyChanging("processstage_account");
                this.SetRelatedEntities<Account>("processstage_account", null, value);
                this.OnPropertyChanged("processstage_account");
            }
        }

        /// <summary>
        /// 1:N processstage_appointments
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("processstage_appointments")]
        public System.Collections.Generic.IEnumerable<Appointment> processstage_appointments
        {
            get { return this.GetRelatedEntities<Appointment>("processstage_appointments", null); }
            set
            {
                this.OnPropertyChanging("processstage_appointments");
                this.SetRelatedEntities<Appointment>("processstage_appointments", null, value);
                this.OnPropertyChanged("processstage_appointments");
            }
        }

        /// <summary>
        /// 1:N processstage_campaignactivities
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("processstage_campaignactivities")]
        public System.Collections.Generic.IEnumerable<CampaignActivity> processstage_campaignactivities
        {
            get { return this.GetRelatedEntities<CampaignActivity>("processstage_campaignactivities", null); }
            set
            {
                this.OnPropertyChanging("processstage_campaignactivities");
                this.SetRelatedEntities<CampaignActivity>("processstage_campaignactivities", null, value);
                this.OnPropertyChanged("processstage_campaignactivities");
            }
        }

        /// <summary>
        /// 1:N processstage_campaignresponses
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("processstage_campaignresponses")]
        public System.Collections.Generic.IEnumerable<CampaignResponse> processstage_campaignresponses
        {
            get { return this.GetRelatedEntities<CampaignResponse>("processstage_campaignresponses", null); }
            set
            {
                this.OnPropertyChanging("processstage_campaignresponses");
                this.SetRelatedEntities<CampaignResponse>("processstage_campaignresponses", null, value);
                this.OnPropertyChanged("processstage_campaignresponses");
            }
        }

        /// <summary>
        /// 1:N processstage_campaigns
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("processstage_campaigns")]
        public System.Collections.Generic.IEnumerable<Campaign> processstage_campaigns
        {
            get { return this.GetRelatedEntities<Campaign>("processstage_campaigns", null); }
            set
            {
                this.OnPropertyChanging("processstage_campaigns");
                this.SetRelatedEntities<Campaign>("processstage_campaigns", null, value);
                this.OnPropertyChanged("processstage_campaigns");
            }
        }

        /// <summary>
        /// 1:N processstage_competitors
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("processstage_competitors")]
        public System.Collections.Generic.IEnumerable<Competitor> processstage_competitors
        {
            get { return this.GetRelatedEntities<Competitor>("processstage_competitors", null); }
            set
            {
                this.OnPropertyChanging("processstage_competitors");
                this.SetRelatedEntities<Competitor>("processstage_competitors", null, value);
                this.OnPropertyChanged("processstage_competitors");
            }
        }

        /// <summary>
        /// 1:N processstage_contact
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("processstage_contact")]
        public System.Collections.Generic.IEnumerable<Contact> processstage_contact
        {
            get { return this.GetRelatedEntities<Contact>("processstage_contact", null); }
            set
            {
                this.OnPropertyChanging("processstage_contact");
                this.SetRelatedEntities<Contact>("processstage_contact", null, value);
                this.OnPropertyChanged("processstage_contact");
            }
        }

        /// <summary>
        /// 1:N processstage_emails
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("processstage_emails")]
        public System.Collections.Generic.IEnumerable<Email> processstage_emails
        {
            get { return this.GetRelatedEntities<Email>("processstage_emails", null); }
            set
            {
                this.OnPropertyChanging("processstage_emails");
                this.SetRelatedEntities<Email>("processstage_emails", null, value);
                this.OnPropertyChanged("processstage_emails");
            }
        }

        /// <summary>
        /// 1:N processstage_faxes
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("processstage_faxes")]
        public System.Collections.Generic.IEnumerable<Fax> processstage_faxes
        {
            get { return this.GetRelatedEntities<Fax>("processstage_faxes", null); }
            set
            {
                this.OnPropertyChanging("processstage_faxes");
                this.SetRelatedEntities<Fax>("processstage_faxes", null, value);
                this.OnPropertyChanged("processstage_faxes");
            }
        }

        /// <summary>
        /// 1:N processstage_incident
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("processstage_incident")]
        public System.Collections.Generic.IEnumerable<Incident> processstage_incident
        {
            get { return this.GetRelatedEntities<Incident>("processstage_incident", null); }
            set
            {
                this.OnPropertyChanging("processstage_incident");
                this.SetRelatedEntities<Incident>("processstage_incident", null, value);
                this.OnPropertyChanged("processstage_incident");
            }
        }

        /// <summary>
        /// 1:N processstage_invoices
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("processstage_invoices")]
        public System.Collections.Generic.IEnumerable<Invoice> processstage_invoices
        {
            get { return this.GetRelatedEntities<Invoice>("processstage_invoices", null); }
            set
            {
                this.OnPropertyChanging("processstage_invoices");
                this.SetRelatedEntities<Invoice>("processstage_invoices", null, value);
                this.OnPropertyChanged("processstage_invoices");
            }
        }

        /// <summary>
        /// 1:N processstage_lead
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("processstage_lead")]
        public System.Collections.Generic.IEnumerable<Lead> processstage_lead
        {
            get { return this.GetRelatedEntities<Lead>("processstage_lead", null); }
            set
            {
                this.OnPropertyChanging("processstage_lead");
                this.SetRelatedEntities<Lead>("processstage_lead", null, value);
                this.OnPropertyChanged("processstage_lead");
            }
        }

        /// <summary>
        /// 1:N processstage_letters
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("processstage_letters")]
        public System.Collections.Generic.IEnumerable<Letter> processstage_letters
        {
            get { return this.GetRelatedEntities<Letter>("processstage_letters", null); }
            set
            {
                this.OnPropertyChanging("processstage_letters");
                this.SetRelatedEntities<Letter>("processstage_letters", null, value);
                this.OnPropertyChanged("processstage_letters");
            }
        }

        /// <summary>
        /// 1:N processstage_lists
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("processstage_lists")]
        public System.Collections.Generic.IEnumerable<List> processstage_lists
        {
            get { return this.GetRelatedEntities<List>("processstage_lists", null); }
            set
            {
                this.OnPropertyChanging("processstage_lists");
                this.SetRelatedEntities<List>("processstage_lists", null, value);
                this.OnPropertyChanged("processstage_lists");
            }
        }

        /// <summary>
        /// 1:N processstage_opportunity
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("processstage_opportunity")]
        public System.Collections.Generic.IEnumerable<Opportunity> processstage_opportunity
        {
            get { return this.GetRelatedEntities<Opportunity>("processstage_opportunity", null); }
            set
            {
                this.OnPropertyChanging("processstage_opportunity");
                this.SetRelatedEntities<Opportunity>("processstage_opportunity", null, value);
                this.OnPropertyChanged("processstage_opportunity");
            }
        }

        /// <summary>
        /// 1:N processstage_phonecalls
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("processstage_phonecalls")]
        public System.Collections.Generic.IEnumerable<PhoneCall> processstage_phonecalls
        {
            get { return this.GetRelatedEntities<PhoneCall>("processstage_phonecalls", null); }
            set
            {
                this.OnPropertyChanging("processstage_phonecalls");
                this.SetRelatedEntities<PhoneCall>("processstage_phonecalls", null, value);
                this.OnPropertyChanged("processstage_phonecalls");
            }
        }

        /// <summary>
        /// 1:N processstage_productpricelevels
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("processstage_productpricelevels")]
        public System.Collections.Generic.IEnumerable<ProductPriceLevel> processstage_productpricelevels
        {
            get { return this.GetRelatedEntities<ProductPriceLevel>("processstage_productpricelevels", null); }
            set
            {
                this.OnPropertyChanging("processstage_productpricelevels");
                this.SetRelatedEntities<ProductPriceLevel>("processstage_productpricelevels", null, value);
                this.OnPropertyChanged("processstage_productpricelevels");
            }
        }

        /// <summary>
        /// 1:N processstage_products
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("processstage_products")]
        public System.Collections.Generic.IEnumerable<Product> processstage_products
        {
            get { return this.GetRelatedEntities<Product>("processstage_products", null); }
            set
            {
                this.OnPropertyChanging("processstage_products");
                this.SetRelatedEntities<Product>("processstage_products", null, value);
                this.OnPropertyChanged("processstage_products");
            }
        }

        /// <summary>
        /// 1:N processstage_quotes
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("processstage_quotes")]
        public System.Collections.Generic.IEnumerable<Quote> processstage_quotes
        {
            get { return this.GetRelatedEntities<Quote>("processstage_quotes", null); }
            set
            {
                this.OnPropertyChanging("processstage_quotes");
                this.SetRelatedEntities<Quote>("processstage_quotes", null, value);
                this.OnPropertyChanged("processstage_quotes");
            }
        }

        /// <summary>
        /// 1:N processstage_recurringappointmentmasters
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("processstage_recurringappointmentmasters")]
        public System.Collections.Generic.IEnumerable<RecurringAppointmentMaster> processstage_recurringappointmentmasters
        {
            get { return this.GetRelatedEntities<RecurringAppointmentMaster>("processstage_recurringappointmentmasters", null); }
            set
            {
                this.OnPropertyChanging("processstage_recurringappointmentmasters");
                this.SetRelatedEntities<RecurringAppointmentMaster>("processstage_recurringappointmentmasters", null, value);
                this.OnPropertyChanged("processstage_recurringappointmentmasters");
            }
        }

        /// <summary>
        /// 1:N processstage_salesliteratures
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("processstage_salesliteratures")]
        public System.Collections.Generic.IEnumerable<SalesLiterature> processstage_salesliteratures
        {
            get { return this.GetRelatedEntities<SalesLiterature>("processstage_salesliteratures", null); }
            set
            {
                this.OnPropertyChanging("processstage_salesliteratures");
                this.SetRelatedEntities<SalesLiterature>("processstage_salesliteratures", null, value);
                this.OnPropertyChanged("processstage_salesliteratures");
            }
        }

        /// <summary>
        /// 1:N processstage_salesorders
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("processstage_salesorders")]
        public System.Collections.Generic.IEnumerable<SalesOrder> processstage_salesorders
        {
            get { return this.GetRelatedEntities<SalesOrder>("processstage_salesorders", null); }
            set
            {
                this.OnPropertyChanging("processstage_salesorders");
                this.SetRelatedEntities<SalesOrder>("processstage_salesorders", null, value);
                this.OnPropertyChanged("processstage_salesorders");
            }
        }

        /// <summary>
        /// 1:N processstage_systemusers
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("processstage_systemusers")]
        public System.Collections.Generic.IEnumerable<SystemUser> processstage_systemusers
        {
            get { return this.GetRelatedEntities<SystemUser>("processstage_systemusers", null); }
            set
            {
                this.OnPropertyChanging("processstage_systemusers");
                this.SetRelatedEntities<SystemUser>("processstage_systemusers", null, value);
                this.OnPropertyChanged("processstage_systemusers");
            }
        }

        /// <summary>
        /// 1:N processstage_tasks
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("processstage_tasks")]
        public System.Collections.Generic.IEnumerable<Task> processstage_tasks
        {
            get { return this.GetRelatedEntities<Task>("processstage_tasks", null); }
            set
            {
                this.OnPropertyChanging("processstage_tasks");
                this.SetRelatedEntities<Task>("processstage_tasks", null, value);
                this.OnPropertyChanged("processstage_tasks");
            }
        }

        /// <summary>
        /// 1:N processstage_teams
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("processstage_teams")]
        public System.Collections.Generic.IEnumerable<Team> processstage_teams
        {
            get { return this.GetRelatedEntities<Team>("processstage_teams", null); }
            set
            {
                this.OnPropertyChanging("processstage_teams");
                this.SetRelatedEntities<Team>("processstage_teams", null, value);
                this.OnPropertyChanged("processstage_teams");
            }
        }

        /// <summary>
        /// N:1 process_processstage
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("processid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("process_processstage")]
        public Workflow process_processstage
        {
            get { return this.GetRelatedEntity<Workflow>("process_processstage", null); }
            set
            {
                this.OnPropertyChanging("process_processstage");
                this.SetRelatedEntity<Workflow>("process_processstage", null, value);
                this.OnPropertyChanged("process_processstage");
            }
        }
    }
}