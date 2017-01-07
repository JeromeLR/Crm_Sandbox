using _4_DAL_CRM;

namespace __4_DAL_CRM
{
    /// <summary>
    /// Defines CRM security principals (users and teams) access rights to secured field for an entity instance.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("principalobjectattributeaccess")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class PrincipalObjectAttributeAccess : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public PrincipalObjectAttributeAccess() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "principalobjectattributeaccess";

        public const int EntityTypeCode = 44;

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
        /// Unique identifier of the shared secured field
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("attributeid")]
        public System.Nullable<System.Guid> AttributeId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("attributeid"); }
            set
            {
                this.OnPropertyChanging("AttributeId");
                this.SetAttributeValue("attributeid", value);
                this.OnPropertyChanged("AttributeId");
            }
        }

        /// <summary>
        /// Unique identifier of the entity instance with shared secured field
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
        public Microsoft.Xrm.Sdk.EntityReference ObjectId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("objectid"); }
            set
            {
                this.OnPropertyChanging("ObjectId");
                this.SetAttributeValue("objectid", value);
                this.OnPropertyChanged("ObjectId");
            }
        }

        /// <summary>
        /// Unique identifier of the associated organization.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
        public Microsoft.Xrm.Sdk.EntityReference OrganizationId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("organizationid"); }
        }

        /// <summary>
        /// Unique identifier of the principal to which secured field is shared
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("principalid")]
        public Microsoft.Xrm.Sdk.EntityReference PrincipalId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("principalid"); }
            set
            {
                this.OnPropertyChanging("PrincipalId");
                this.SetAttributeValue("principalid", value);
                this.OnPropertyChanged("PrincipalId");
            }
        }

        /// <summary>
        /// Unique identifier of the shared secured field instance
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("principalobjectattributeaccessid")]
        public System.Nullable<System.Guid> PrincipalObjectAttributeAccessId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("principalobjectattributeaccessid"); }
            set
            {
                this.OnPropertyChanging("PrincipalObjectAttributeAccessId");
                this.SetAttributeValue("principalobjectattributeaccessid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("PrincipalObjectAttributeAccessId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("principalobjectattributeaccessid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.PrincipalObjectAttributeAccessId = value; }
        }

        /// <summary>
        /// Read permission for secured field instance
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("readaccess")]
        public System.Nullable<bool> ReadAccess
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("readaccess"); }
            set
            {
                this.OnPropertyChanging("ReadAccess");
                this.SetAttributeValue("readaccess", value);
                this.OnPropertyChanged("ReadAccess");
            }
        }

        /// <summary>
        /// Update permission for secured field instance
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("updateaccess")]
        public System.Nullable<bool> UpdateAccess
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("updateaccess"); }
            set
            {
                this.OnPropertyChanging("UpdateAccess");
                this.SetAttributeValue("updateaccess", value);
                this.OnPropertyChanged("UpdateAccess");
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
        /// 1:N userentityinstancedata_principalobjectattributeaccess
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_principalobjectattributeaccess")]
        public System.Collections.Generic.IEnumerable<UserEntityInstanceData> userentityinstancedata_principalobjectattributeaccess
        {
            get { return this.GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_principalobjectattributeaccess", null); }
            set
            {
                this.OnPropertyChanging("userentityinstancedata_principalobjectattributeaccess");
                this.SetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_principalobjectattributeaccess", null, value);
                this.OnPropertyChanged("userentityinstancedata_principalobjectattributeaccess");
            }
        }

        /// <summary>
        /// N:1 account_principalobjectattributeaccess
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("account_principalobjectattributeaccess")]
        public Account account_principalobjectattributeaccess
        {
            get { return this.GetRelatedEntity<Account>("account_principalobjectattributeaccess", null); }
            set
            {
                this.OnPropertyChanging("account_principalobjectattributeaccess");
                this.SetRelatedEntity<Account>("account_principalobjectattributeaccess", null, value);
                this.OnPropertyChanged("account_principalobjectattributeaccess");
            }
        }

        /// <summary>
        /// N:1 appointment_principalobjectattributeaccess
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("appointment_principalobjectattributeaccess")]
        public Appointment appointment_principalobjectattributeaccess
        {
            get { return this.GetRelatedEntity<Appointment>("appointment_principalobjectattributeaccess", null); }
            set
            {
                this.OnPropertyChanging("appointment_principalobjectattributeaccess");
                this.SetRelatedEntity<Appointment>("appointment_principalobjectattributeaccess", null, value);
                this.OnPropertyChanged("appointment_principalobjectattributeaccess");
            }
        }

        /// <summary>
        /// N:1 businessunit_principalobjectattributeaccess
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("businessunit_principalobjectattributeaccess")]
        public BusinessUnit businessunit_principalobjectattributeaccess
        {
            get { return this.GetRelatedEntity<BusinessUnit>("businessunit_principalobjectattributeaccess", null); }
            set
            {
                this.OnPropertyChanging("businessunit_principalobjectattributeaccess");
                this.SetRelatedEntity<BusinessUnit>("businessunit_principalobjectattributeaccess", null, value);
                this.OnPropertyChanged("businessunit_principalobjectattributeaccess");
            }
        }

        /// <summary>
        /// N:1 campaign_principalobjectattributeaccess
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("campaign_principalobjectattributeaccess")]
        public Campaign campaign_principalobjectattributeaccess
        {
            get { return this.GetRelatedEntity<Campaign>("campaign_principalobjectattributeaccess", null); }
            set
            {
                this.OnPropertyChanging("campaign_principalobjectattributeaccess");
                this.SetRelatedEntity<Campaign>("campaign_principalobjectattributeaccess", null, value);
                this.OnPropertyChanged("campaign_principalobjectattributeaccess");
            }
        }

        /// <summary>
        /// N:1 campaignactivity_principalobjectattributeaccess
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("campaignactivity_principalobjectattributeaccess")]
        public CampaignActivity campaignactivity_principalobjectattributeaccess
        {
            get { return this.GetRelatedEntity<CampaignActivity>("campaignactivity_principalobjectattributeaccess", null); }
            set
            {
                this.OnPropertyChanging("campaignactivity_principalobjectattributeaccess");
                this.SetRelatedEntity<CampaignActivity>("campaignactivity_principalobjectattributeaccess", null, value);
                this.OnPropertyChanged("campaignactivity_principalobjectattributeaccess");
            }
        }

        /// <summary>
        /// N:1 campaignresponse_principalobjectattributeaccess
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("campaignresponse_principalobjectattributeaccess")]
        public CampaignResponse campaignresponse_principalobjectattributeaccess
        {
            get { return this.GetRelatedEntity<CampaignResponse>("campaignresponse_principalobjectattributeaccess", null); }
            set
            {
                this.OnPropertyChanging("campaignresponse_principalobjectattributeaccess");
                this.SetRelatedEntity<CampaignResponse>("campaignresponse_principalobjectattributeaccess", null, value);
                this.OnPropertyChanged("campaignresponse_principalobjectattributeaccess");
            }
        }

        /// <summary>
        /// N:1 competitor_principalobjectattributeaccess
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("competitor_principalobjectattributeaccess")]
        public Competitor competitor_principalobjectattributeaccess
        {
            get { return this.GetRelatedEntity<Competitor>("competitor_principalobjectattributeaccess", null); }
            set
            {
                this.OnPropertyChanging("competitor_principalobjectattributeaccess");
                this.SetRelatedEntity<Competitor>("competitor_principalobjectattributeaccess", null, value);
                this.OnPropertyChanged("competitor_principalobjectattributeaccess");
            }
        }

        /// <summary>
        /// N:1 connection_principalobjectattributeaccess
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("connection_principalobjectattributeaccess")]
        public Connection connection_principalobjectattributeaccess
        {
            get { return this.GetRelatedEntity<Connection>("connection_principalobjectattributeaccess", null); }
            set
            {
                this.OnPropertyChanging("connection_principalobjectattributeaccess");
                this.SetRelatedEntity<Connection>("connection_principalobjectattributeaccess", null, value);
                this.OnPropertyChanged("connection_principalobjectattributeaccess");
            }
        }

        /// <summary>
        /// N:1 contact_principalobjectattributeaccess
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("contact_principalobjectattributeaccess")]
        public Contact contact_principalobjectattributeaccess
        {
            get { return this.GetRelatedEntity<Contact>("contact_principalobjectattributeaccess", null); }
            set
            {
                this.OnPropertyChanging("contact_principalobjectattributeaccess");
                this.SetRelatedEntity<Contact>("contact_principalobjectattributeaccess", null, value);
                this.OnPropertyChanged("contact_principalobjectattributeaccess");
            }
        }

        /// <summary>
        /// N:1 contract_principalobjectattributeaccess
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("contract_principalobjectattributeaccess")]
        public Contract contract_principalobjectattributeaccess
        {
            get { return this.GetRelatedEntity<Contract>("contract_principalobjectattributeaccess", null); }
            set
            {
                this.OnPropertyChanging("contract_principalobjectattributeaccess");
                this.SetRelatedEntity<Contract>("contract_principalobjectattributeaccess", null, value);
                this.OnPropertyChanged("contract_principalobjectattributeaccess");
            }
        }

        /// <summary>
        /// N:1 contractdetail_principalobjectattributeaccess
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("contractdetail_principalobjectattributeaccess")]
        public ContractDetail contractdetail_principalobjectattributeaccess
        {
            get { return this.GetRelatedEntity<ContractDetail>("contractdetail_principalobjectattributeaccess", null); }
            set
            {
                this.OnPropertyChanging("contractdetail_principalobjectattributeaccess");
                this.SetRelatedEntity<ContractDetail>("contractdetail_principalobjectattributeaccess", null, value);
                this.OnPropertyChanged("contractdetail_principalobjectattributeaccess");
            }
        }

        /// <summary>
        /// N:1 customeraddress_principalobjectattributeaccess
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("customeraddress_principalobjectattributeaccess")]
        public CustomerAddress customeraddress_principalobjectattributeaccess
        {
            get { return this.GetRelatedEntity<CustomerAddress>("customeraddress_principalobjectattributeaccess", null); }
            set
            {
                this.OnPropertyChanging("customeraddress_principalobjectattributeaccess");
                this.SetRelatedEntity<CustomerAddress>("customeraddress_principalobjectattributeaccess", null, value);
                this.OnPropertyChanged("customeraddress_principalobjectattributeaccess");
            }
        }

        /// <summary>
        /// N:1 email_principalobjectattributeaccess
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("email_principalobjectattributeaccess")]
        public Email email_principalobjectattributeaccess
        {
            get { return this.GetRelatedEntity<Email>("email_principalobjectattributeaccess", null); }
            set
            {
                this.OnPropertyChanging("email_principalobjectattributeaccess");
                this.SetRelatedEntity<Email>("email_principalobjectattributeaccess", null, value);
                this.OnPropertyChanged("email_principalobjectattributeaccess");
            }
        }

        /// <summary>
        /// N:1 entitlement_PrincipalObjectAttributeAccesses
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("entitlement_PrincipalObjectAttributeAccesses")]
        public Entitlement entitlement_PrincipalObjectAttributeAccesses
        {
            get { return this.GetRelatedEntity<Entitlement>("entitlement_PrincipalObjectAttributeAccesses", null); }
            set
            {
                this.OnPropertyChanging("entitlement_PrincipalObjectAttributeAccesses");
                this.SetRelatedEntity<Entitlement>("entitlement_PrincipalObjectAttributeAccesses", null, value);
                this.OnPropertyChanged("entitlement_PrincipalObjectAttributeAccesses");
            }
        }

        /// <summary>
        /// N:1 entitlementtemplate_PrincipalObjectAttributeAccesses
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("entitlementtemplate_PrincipalObjectAttributeAccesses")]
        public EntitlementTemplate entitlementtemplate_PrincipalObjectAttributeAccesses
        {
            get { return this.GetRelatedEntity<EntitlementTemplate>("entitlementtemplate_PrincipalObjectAttributeAccesses", null); }
            set
            {
                this.OnPropertyChanging("entitlementtemplate_PrincipalObjectAttributeAccesses");
                this.SetRelatedEntity<EntitlementTemplate>("entitlementtemplate_PrincipalObjectAttributeAccesses", null, value);
                this.OnPropertyChanged("entitlementtemplate_PrincipalObjectAttributeAccesses");
            }
        }

        /// <summary>
        /// N:1 equipment_principalobjectattributeaccess
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("equipment_principalobjectattributeaccess")]
        public Equipment equipment_principalobjectattributeaccess
        {
            get { return this.GetRelatedEntity<Equipment>("equipment_principalobjectattributeaccess", null); }
            set
            {
                this.OnPropertyChanging("equipment_principalobjectattributeaccess");
                this.SetRelatedEntity<Equipment>("equipment_principalobjectattributeaccess", null, value);
                this.OnPropertyChanged("equipment_principalobjectattributeaccess");
            }
        }

        /// <summary>
        /// N:1 fax_principalobjectattributeaccess
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("fax_principalobjectattributeaccess")]
        public Fax fax_principalobjectattributeaccess
        {
            get { return this.GetRelatedEntity<Fax>("fax_principalobjectattributeaccess", null); }
            set
            {
                this.OnPropertyChanging("fax_principalobjectattributeaccess");
                this.SetRelatedEntity<Fax>("fax_principalobjectattributeaccess", null, value);
                this.OnPropertyChanged("fax_principalobjectattributeaccess");
            }
        }

        /// <summary>
        /// N:1 goal_principalobjectattributeaccess
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("goal_principalobjectattributeaccess")]
        public Goal goal_principalobjectattributeaccess
        {
            get { return this.GetRelatedEntity<Goal>("goal_principalobjectattributeaccess", null); }
            set
            {
                this.OnPropertyChanging("goal_principalobjectattributeaccess");
                this.SetRelatedEntity<Goal>("goal_principalobjectattributeaccess", null, value);
                this.OnPropertyChanged("goal_principalobjectattributeaccess");
            }
        }

        /// <summary>
        /// N:1 incident_principalobjectattributeaccess
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("incident_principalobjectattributeaccess")]
        public Incident incident_principalobjectattributeaccess
        {
            get { return this.GetRelatedEntity<Incident>("incident_principalobjectattributeaccess", null); }
            set
            {
                this.OnPropertyChanging("incident_principalobjectattributeaccess");
                this.SetRelatedEntity<Incident>("incident_principalobjectattributeaccess", null, value);
                this.OnPropertyChanged("incident_principalobjectattributeaccess");
            }
        }

        /// <summary>
        /// N:1 invoice_principalobjectattributeaccess
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("invoice_principalobjectattributeaccess")]
        public Invoice invoice_principalobjectattributeaccess
        {
            get { return this.GetRelatedEntity<Invoice>("invoice_principalobjectattributeaccess", null); }
            set
            {
                this.OnPropertyChanging("invoice_principalobjectattributeaccess");
                this.SetRelatedEntity<Invoice>("invoice_principalobjectattributeaccess", null, value);
                this.OnPropertyChanged("invoice_principalobjectattributeaccess");
            }
        }

        /// <summary>
        /// N:1 invoicedetail_principalobjectattributeaccess
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("invoicedetail_principalobjectattributeaccess")]
        public InvoiceDetail invoicedetail_principalobjectattributeaccess
        {
            get { return this.GetRelatedEntity<InvoiceDetail>("invoicedetail_principalobjectattributeaccess", null); }
            set
            {
                this.OnPropertyChanging("invoicedetail_principalobjectattributeaccess");
                this.SetRelatedEntity<InvoiceDetail>("invoicedetail_principalobjectattributeaccess", null, value);
                this.OnPropertyChanged("invoicedetail_principalobjectattributeaccess");
            }
        }

        /// <summary>
        /// N:1 kbarticle_principalobjectattributeaccess
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("kbarticle_principalobjectattributeaccess")]
        public KbArticle kbarticle_principalobjectattributeaccess
        {
            get { return this.GetRelatedEntity<KbArticle>("kbarticle_principalobjectattributeaccess", null); }
            set
            {
                this.OnPropertyChanging("kbarticle_principalobjectattributeaccess");
                this.SetRelatedEntity<KbArticle>("kbarticle_principalobjectattributeaccess", null, value);
                this.OnPropertyChanged("kbarticle_principalobjectattributeaccess");
            }
        }

        /// <summary>
        /// N:1 lead_principalobjectattributeaccess
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lead_principalobjectattributeaccess")]
        public Lead lead_principalobjectattributeaccess
        {
            get { return this.GetRelatedEntity<Lead>("lead_principalobjectattributeaccess", null); }
            set
            {
                this.OnPropertyChanging("lead_principalobjectattributeaccess");
                this.SetRelatedEntity<Lead>("lead_principalobjectattributeaccess", null, value);
                this.OnPropertyChanged("lead_principalobjectattributeaccess");
            }
        }

        /// <summary>
        /// N:1 letter_principalobjectattributeaccess
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("letter_principalobjectattributeaccess")]
        public Letter letter_principalobjectattributeaccess
        {
            get { return this.GetRelatedEntity<Letter>("letter_principalobjectattributeaccess", null); }
            set
            {
                this.OnPropertyChanging("letter_principalobjectattributeaccess");
                this.SetRelatedEntity<Letter>("letter_principalobjectattributeaccess", null, value);
                this.OnPropertyChanged("letter_principalobjectattributeaccess");
            }
        }

        /// <summary>
        /// N:1 list_principalobjectattributeaccess
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("list_principalobjectattributeaccess")]
        public List list_principalobjectattributeaccess
        {
            get { return this.GetRelatedEntity<List>("list_principalobjectattributeaccess", null); }
            set
            {
                this.OnPropertyChanging("list_principalobjectattributeaccess");
                this.SetRelatedEntity<List>("list_principalobjectattributeaccess", null, value);
                this.OnPropertyChanged("list_principalobjectattributeaccess");
            }
        }

        /// <summary>
        /// N:1 lk_principalobjectattributeaccess_organizationid
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_principalobjectattributeaccess_organizationid")]
        public Organization lk_principalobjectattributeaccess_organizationid
        {
            get { return this.GetRelatedEntity<Organization>("lk_principalobjectattributeaccess_organizationid", null); }
        }

        /// <summary>
        /// N:1 mailmergetemplate_principalobjectattributeaccess
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("mailmergetemplate_principalobjectattributeaccess")]
        public MailMergeTemplate mailmergetemplate_principalobjectattributeaccess
        {
            get { return this.GetRelatedEntity<MailMergeTemplate>("mailmergetemplate_principalobjectattributeaccess", null); }
            set
            {
                this.OnPropertyChanging("mailmergetemplate_principalobjectattributeaccess");
                this.SetRelatedEntity<MailMergeTemplate>("mailmergetemplate_principalobjectattributeaccess", null, value);
                this.OnPropertyChanged("mailmergetemplate_principalobjectattributeaccess");
            }
        }

        /// <summary>
        /// N:1 msdyn_postalbum_PrincipalObjectAttributeAccesses
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_postalbum_PrincipalObjectAttributeAccesses")]
        public msdyn_PostAlbum msdyn_postalbum_PrincipalObjectAttributeAccesses
        {
            get { return this.GetRelatedEntity<msdyn_PostAlbum>("msdyn_postalbum_PrincipalObjectAttributeAccesses", null); }
            set
            {
                this.OnPropertyChanging("msdyn_postalbum_PrincipalObjectAttributeAccesses");
                this.SetRelatedEntity<msdyn_PostAlbum>("msdyn_postalbum_PrincipalObjectAttributeAccesses", null, value);
                this.OnPropertyChanged("msdyn_postalbum_PrincipalObjectAttributeAccesses");
            }
        }

        /// <summary>
        /// N:1 msdyn_postconfig_PrincipalObjectAttributeAccesses
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_postconfig_PrincipalObjectAttributeAccesses")]
        public msdyn_PostConfig msdyn_postconfig_PrincipalObjectAttributeAccesses
        {
            get { return this.GetRelatedEntity<msdyn_PostConfig>("msdyn_postconfig_PrincipalObjectAttributeAccesses", null); }
            set
            {
                this.OnPropertyChanging("msdyn_postconfig_PrincipalObjectAttributeAccesses");
                this.SetRelatedEntity<msdyn_PostConfig>("msdyn_postconfig_PrincipalObjectAttributeAccesses", null, value);
                this.OnPropertyChanged("msdyn_postconfig_PrincipalObjectAttributeAccesses");
            }
        }

        /// <summary>
        /// N:1 msdyn_postruleconfig_PrincipalObjectAttributeAccesses
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_postruleconfig_PrincipalObjectAttributeAccesses")]
        public msdyn_PostRuleConfig msdyn_postruleconfig_PrincipalObjectAttributeAccesses
        {
            get { return this.GetRelatedEntity<msdyn_PostRuleConfig>("msdyn_postruleconfig_PrincipalObjectAttributeAccesses", null); }
            set
            {
                this.OnPropertyChanging("msdyn_postruleconfig_PrincipalObjectAttributeAccesses");
                this.SetRelatedEntity<msdyn_PostRuleConfig>("msdyn_postruleconfig_PrincipalObjectAttributeAccesses", null, value);
                this.OnPropertyChanged("msdyn_postruleconfig_PrincipalObjectAttributeAccesses");
            }
        }

        /// <summary>
        /// N:1 msdyn_wallsavedquery_PrincipalObjectAttributeAccesses
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_wallsavedquery_PrincipalObjectAttributeAccesses")]
        public msdyn_wallsavedquery msdyn_wallsavedquery_PrincipalObjectAttributeAccesses
        {
            get { return this.GetRelatedEntity<msdyn_wallsavedquery>("msdyn_wallsavedquery_PrincipalObjectAttributeAccesses", null); }
            set
            {
                this.OnPropertyChanging("msdyn_wallsavedquery_PrincipalObjectAttributeAccesses");
                this.SetRelatedEntity<msdyn_wallsavedquery>("msdyn_wallsavedquery_PrincipalObjectAttributeAccesses", null, value);
                this.OnPropertyChanged("msdyn_wallsavedquery_PrincipalObjectAttributeAccesses");
            }
        }

        /// <summary>
        /// N:1 msdyn_wallsavedqueryusersettings_PrincipalObjectAttributeAccesses
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_wallsavedqueryusersettings_PrincipalObjectAttributeAccesses")]
        public msdyn_wallsavedqueryusersettings msdyn_wallsavedqueryusersettings_PrincipalObjectAttributeAccesses
        {
            get { return this.GetRelatedEntity<msdyn_wallsavedqueryusersettings>("msdyn_wallsavedqueryusersettings_PrincipalObjectAttributeAccesses", null); }
            set
            {
                this.OnPropertyChanging("msdyn_wallsavedqueryusersettings_PrincipalObjectAttributeAccesses");
                this.SetRelatedEntity<msdyn_wallsavedqueryusersettings>("msdyn_wallsavedqueryusersettings_PrincipalObjectAttributeAccesses", null, value);
                this.OnPropertyChanged("msdyn_wallsavedqueryusersettings_PrincipalObjectAttributeAccesses");
            }
        }

        /// <summary>
        /// N:1 opportunity_principalobjectattributeaccess
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("opportunity_principalobjectattributeaccess")]
        public Opportunity opportunity_principalobjectattributeaccess
        {
            get { return this.GetRelatedEntity<Opportunity>("opportunity_principalobjectattributeaccess", null); }
            set
            {
                this.OnPropertyChanging("opportunity_principalobjectattributeaccess");
                this.SetRelatedEntity<Opportunity>("opportunity_principalobjectattributeaccess", null, value);
                this.OnPropertyChanged("opportunity_principalobjectattributeaccess");
            }
        }

        /// <summary>
        /// N:1 opportunityproduct_principalobjectattributeaccess
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("opportunityproduct_principalobjectattributeaccess")]
        public OpportunityProduct opportunityproduct_principalobjectattributeaccess
        {
            get { return this.GetRelatedEntity<OpportunityProduct>("opportunityproduct_principalobjectattributeaccess", null); }
            set
            {
                this.OnPropertyChanging("opportunityproduct_principalobjectattributeaccess");
                this.SetRelatedEntity<OpportunityProduct>("opportunityproduct_principalobjectattributeaccess", null, value);
                this.OnPropertyChanged("opportunityproduct_principalobjectattributeaccess");
            }
        }

        /// <summary>
        /// N:1 phonecall_principalobjectattributeaccess
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("phonecall_principalobjectattributeaccess")]
        public PhoneCall phonecall_principalobjectattributeaccess
        {
            get { return this.GetRelatedEntity<PhoneCall>("phonecall_principalobjectattributeaccess", null); }
            set
            {
                this.OnPropertyChanging("phonecall_principalobjectattributeaccess");
                this.SetRelatedEntity<PhoneCall>("phonecall_principalobjectattributeaccess", null, value);
                this.OnPropertyChanged("phonecall_principalobjectattributeaccess");
            }
        }

        /// <summary>
        /// N:1 position_principalobjectattributeaccess
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("position_principalobjectattributeaccess")]
        public Position position_principalobjectattributeaccess
        {
            get { return this.GetRelatedEntity<Position>("position_principalobjectattributeaccess", null); }
            set
            {
                this.OnPropertyChanging("position_principalobjectattributeaccess");
                this.SetRelatedEntity<Position>("position_principalobjectattributeaccess", null, value);
                this.OnPropertyChanged("position_principalobjectattributeaccess");
            }
        }

        /// <summary>
        /// N:1 pricelevel_principalobjectattributeaccess
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("pricelevel_principalobjectattributeaccess")]
        public PriceLevel pricelevel_principalobjectattributeaccess
        {
            get { return this.GetRelatedEntity<PriceLevel>("pricelevel_principalobjectattributeaccess", null); }
            set
            {
                this.OnPropertyChanging("pricelevel_principalobjectattributeaccess");
                this.SetRelatedEntity<PriceLevel>("pricelevel_principalobjectattributeaccess", null, value);
                this.OnPropertyChanged("pricelevel_principalobjectattributeaccess");
            }
        }

        /// <summary>
        /// N:1 product_principalobjectattributeaccess
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("product_principalobjectattributeaccess")]
        public Product product_principalobjectattributeaccess
        {
            get { return this.GetRelatedEntity<Product>("product_principalobjectattributeaccess", null); }
            set
            {
                this.OnPropertyChanging("product_principalobjectattributeaccess");
                this.SetRelatedEntity<Product>("product_principalobjectattributeaccess", null, value);
                this.OnPropertyChanged("product_principalobjectattributeaccess");
            }
        }

        /// <summary>
        /// N:1 ProductAssociation_PrincipalObjectAttributeAccess
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ProductAssociation_PrincipalObjectAttributeAccess")]
        public ProductAssociation ProductAssociation_PrincipalObjectAttributeAccess
        {
            get { return this.GetRelatedEntity<ProductAssociation>("ProductAssociation_PrincipalObjectAttributeAccess", null); }
            set
            {
                this.OnPropertyChanging("ProductAssociation_PrincipalObjectAttributeAccess");
                this.SetRelatedEntity<ProductAssociation>("ProductAssociation_PrincipalObjectAttributeAccess", null, value);
                this.OnPropertyChanged("ProductAssociation_PrincipalObjectAttributeAccess");
            }
        }

        /// <summary>
        /// N:1 ProductSubstitute_PrincipalObjectAttributeAccess
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ProductSubstitute_PrincipalObjectAttributeAccess")]
        public ProductSubstitute ProductSubstitute_PrincipalObjectAttributeAccess
        {
            get { return this.GetRelatedEntity<ProductSubstitute>("ProductSubstitute_PrincipalObjectAttributeAccess", null); }
            set
            {
                this.OnPropertyChanging("ProductSubstitute_PrincipalObjectAttributeAccess");
                this.SetRelatedEntity<ProductSubstitute>("ProductSubstitute_PrincipalObjectAttributeAccess", null, value);
                this.OnPropertyChanged("ProductSubstitute_PrincipalObjectAttributeAccess");
            }
        }

        /// <summary>
        /// N:1 queue_principalobjectattributeaccess
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("queue_principalobjectattributeaccess")]
        public Queue queue_principalobjectattributeaccess
        {
            get { return this.GetRelatedEntity<Queue>("queue_principalobjectattributeaccess", null); }
            set
            {
                this.OnPropertyChanging("queue_principalobjectattributeaccess");
                this.SetRelatedEntity<Queue>("queue_principalobjectattributeaccess", null, value);
                this.OnPropertyChanged("queue_principalobjectattributeaccess");
            }
        }

        /// <summary>
        /// N:1 queueitem_principalobjectattributeaccess
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("queueitem_principalobjectattributeaccess")]
        public QueueItem queueitem_principalobjectattributeaccess
        {
            get { return this.GetRelatedEntity<QueueItem>("queueitem_principalobjectattributeaccess", null); }
            set
            {
                this.OnPropertyChanging("queueitem_principalobjectattributeaccess");
                this.SetRelatedEntity<QueueItem>("queueitem_principalobjectattributeaccess", null, value);
                this.OnPropertyChanged("queueitem_principalobjectattributeaccess");
            }
        }

        /// <summary>
        /// N:1 quote_principalobjectattributeaccess
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("quote_principalobjectattributeaccess")]
        public Quote quote_principalobjectattributeaccess
        {
            get { return this.GetRelatedEntity<Quote>("quote_principalobjectattributeaccess", null); }
            set
            {
                this.OnPropertyChanging("quote_principalobjectattributeaccess");
                this.SetRelatedEntity<Quote>("quote_principalobjectattributeaccess", null, value);
                this.OnPropertyChanged("quote_principalobjectattributeaccess");
            }
        }

        /// <summary>
        /// N:1 quotedetail_principalobjectattributeaccess
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("quotedetail_principalobjectattributeaccess")]
        public QuoteDetail quotedetail_principalobjectattributeaccess
        {
            get { return this.GetRelatedEntity<QuoteDetail>("quotedetail_principalobjectattributeaccess", null); }
            set
            {
                this.OnPropertyChanging("quotedetail_principalobjectattributeaccess");
                this.SetRelatedEntity<QuoteDetail>("quotedetail_principalobjectattributeaccess", null, value);
                this.OnPropertyChanged("quotedetail_principalobjectattributeaccess");
            }
        }

        /// <summary>
        /// N:1 recurringappointmentmaster_principalobjectattributeaccess
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("recurringappointmentmaster_principalobjectattributeaccess")]
        public RecurringAppointmentMaster recurringappointmentmaster_principalobjectattributeaccess
        {
            get { return this.GetRelatedEntity<RecurringAppointmentMaster>("recurringappointmentmaster_principalobjectattributeaccess", null); }
            set
            {
                this.OnPropertyChanging("recurringappointmentmaster_principalobjectattributeaccess");
                this.SetRelatedEntity<RecurringAppointmentMaster>("recurringappointmentmaster_principalobjectattributeaccess", null, value);
                this.OnPropertyChanged("recurringappointmentmaster_principalobjectattributeaccess");
            }
        }

        /// <summary>
        /// N:1 reportcategory_principalobjectattributeaccess
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("reportcategory_principalobjectattributeaccess")]
        public ReportCategory reportcategory_principalobjectattributeaccess
        {
            get { return this.GetRelatedEntity<ReportCategory>("reportcategory_principalobjectattributeaccess", null); }
            set
            {
                this.OnPropertyChanging("reportcategory_principalobjectattributeaccess");
                this.SetRelatedEntity<ReportCategory>("reportcategory_principalobjectattributeaccess", null, value);
                this.OnPropertyChanged("reportcategory_principalobjectattributeaccess");
            }
        }

        /// <summary>
        /// N:1 salesliterature_principalobjectattributeaccess
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("salesliterature_principalobjectattributeaccess")]
        public SalesLiterature salesliterature_principalobjectattributeaccess
        {
            get { return this.GetRelatedEntity<SalesLiterature>("salesliterature_principalobjectattributeaccess", null); }
            set
            {
                this.OnPropertyChanging("salesliterature_principalobjectattributeaccess");
                this.SetRelatedEntity<SalesLiterature>("salesliterature_principalobjectattributeaccess", null, value);
                this.OnPropertyChanged("salesliterature_principalobjectattributeaccess");
            }
        }

        /// <summary>
        /// N:1 salesorder_principalobjectattributeaccess
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("salesorder_principalobjectattributeaccess")]
        public SalesOrder salesorder_principalobjectattributeaccess
        {
            get { return this.GetRelatedEntity<SalesOrder>("salesorder_principalobjectattributeaccess", null); }
            set
            {
                this.OnPropertyChanging("salesorder_principalobjectattributeaccess");
                this.SetRelatedEntity<SalesOrder>("salesorder_principalobjectattributeaccess", null, value);
                this.OnPropertyChanged("salesorder_principalobjectattributeaccess");
            }
        }

        /// <summary>
        /// N:1 salesorderdetail_principalobjectattributeaccess
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("salesorderdetail_principalobjectattributeaccess")]
        public SalesOrderDetail salesorderdetail_principalobjectattributeaccess
        {
            get { return this.GetRelatedEntity<SalesOrderDetail>("salesorderdetail_principalobjectattributeaccess", null); }
            set
            {
                this.OnPropertyChanging("salesorderdetail_principalobjectattributeaccess");
                this.SetRelatedEntity<SalesOrderDetail>("salesorderdetail_principalobjectattributeaccess", null, value);
                this.OnPropertyChanged("salesorderdetail_principalobjectattributeaccess");
            }
        }

        /// <summary>
        /// N:1 serviceappointment_principalobjectattributeaccess
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("serviceappointment_principalobjectattributeaccess")]
        public ServiceAppointment serviceappointment_principalobjectattributeaccess
        {
            get { return this.GetRelatedEntity<ServiceAppointment>("serviceappointment_principalobjectattributeaccess", null); }
            set
            {
                this.OnPropertyChanging("serviceappointment_principalobjectattributeaccess");
                this.SetRelatedEntity<ServiceAppointment>("serviceappointment_principalobjectattributeaccess", null, value);
                this.OnPropertyChanged("serviceappointment_principalobjectattributeaccess");
            }
        }

        /// <summary>
        /// N:1 sharepointdocumentlocation_principalobjectattributeaccess
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("sharepointdocumentlocation_principalobjectattributeaccess")]
        public SharePointDocumentLocation sharepointdocumentlocation_principalobjectattributeaccess
        {
            get { return this.GetRelatedEntity<SharePointDocumentLocation>("sharepointdocumentlocation_principalobjectattributeaccess", null); }
            set
            {
                this.OnPropertyChanging("sharepointdocumentlocation_principalobjectattributeaccess");
                this.SetRelatedEntity<SharePointDocumentLocation>("sharepointdocumentlocation_principalobjectattributeaccess", null, value);
                this.OnPropertyChanged("sharepointdocumentlocation_principalobjectattributeaccess");
            }
        }

        /// <summary>
        /// N:1 sharepointsite_principalobjectattributeaccess
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("sharepointsite_principalobjectattributeaccess")]
        public SharePointSite sharepointsite_principalobjectattributeaccess
        {
            get { return this.GetRelatedEntity<SharePointSite>("sharepointsite_principalobjectattributeaccess", null); }
            set
            {
                this.OnPropertyChanging("sharepointsite_principalobjectattributeaccess");
                this.SetRelatedEntity<SharePointSite>("sharepointsite_principalobjectattributeaccess", null, value);
                this.OnPropertyChanged("sharepointsite_principalobjectattributeaccess");
            }
        }

        /// <summary>
        /// N:1 socialactivity_principalobjectattributeaccess
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("socialactivity_principalobjectattributeaccess")]
        public SocialActivity socialactivity_principalobjectattributeaccess
        {
            get { return this.GetRelatedEntity<SocialActivity>("socialactivity_principalobjectattributeaccess", null); }
            set
            {
                this.OnPropertyChanging("socialactivity_principalobjectattributeaccess");
                this.SetRelatedEntity<SocialActivity>("socialactivity_principalobjectattributeaccess", null, value);
                this.OnPropertyChanged("socialactivity_principalobjectattributeaccess");
            }
        }

        /// <summary>
        /// N:1 socialprofile_principalobjectattributeaccess
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("socialprofile_principalobjectattributeaccess")]
        public SocialProfile socialprofile_principalobjectattributeaccess
        {
            get { return this.GetRelatedEntity<SocialProfile>("socialprofile_principalobjectattributeaccess", null); }
            set
            {
                this.OnPropertyChanging("socialprofile_principalobjectattributeaccess");
                this.SetRelatedEntity<SocialProfile>("socialprofile_principalobjectattributeaccess", null, value);
                this.OnPropertyChanged("socialprofile_principalobjectattributeaccess");
            }
        }

        /// <summary>
        /// N:1 systemuser_principalobjectattributeaccess
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("systemuser_principalobjectattributeaccess")]
        public SystemUser systemuser_principalobjectattributeaccess
        {
            get { return this.GetRelatedEntity<SystemUser>("systemuser_principalobjectattributeaccess", null); }
            set
            {
                this.OnPropertyChanging("systemuser_principalobjectattributeaccess");
                this.SetRelatedEntity<SystemUser>("systemuser_principalobjectattributeaccess", null, value);
                this.OnPropertyChanged("systemuser_principalobjectattributeaccess");
            }
        }

        /// <summary>
        /// N:1 systemuser_principalobjectattributeaccess_principalid
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("principalid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("systemuser_principalobjectattributeaccess_principalid")]
        public SystemUser systemuser_principalobjectattributeaccess_principalid
        {
            get { return this.GetRelatedEntity<SystemUser>("systemuser_principalobjectattributeaccess_principalid", null); }
            set
            {
                this.OnPropertyChanging("systemuser_principalobjectattributeaccess_principalid");
                this.SetRelatedEntity<SystemUser>("systemuser_principalobjectattributeaccess_principalid", null, value);
                this.OnPropertyChanged("systemuser_principalobjectattributeaccess_principalid");
            }
        }

        /// <summary>
        /// N:1 task_principalobjectattributeaccess
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("task_principalobjectattributeaccess")]
        public Task task_principalobjectattributeaccess
        {
            get { return this.GetRelatedEntity<Task>("task_principalobjectattributeaccess", null); }
            set
            {
                this.OnPropertyChanging("task_principalobjectattributeaccess");
                this.SetRelatedEntity<Task>("task_principalobjectattributeaccess", null, value);
                this.OnPropertyChanged("task_principalobjectattributeaccess");
            }
        }

        /// <summary>
        /// N:1 team_principalobjectattributeaccess
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_principalobjectattributeaccess")]
        public Team team_principalobjectattributeaccess
        {
            get { return this.GetRelatedEntity<Team>("team_principalobjectattributeaccess", null); }
            set
            {
                this.OnPropertyChanging("team_principalobjectattributeaccess");
                this.SetRelatedEntity<Team>("team_principalobjectattributeaccess", null, value);
                this.OnPropertyChanged("team_principalobjectattributeaccess");
            }
        }

        /// <summary>
        /// N:1 team_principalobjectattributeaccess_principalid
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("principalid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_principalobjectattributeaccess_principalid")]
        public Team team_principalobjectattributeaccess_principalid
        {
            get { return this.GetRelatedEntity<Team>("team_principalobjectattributeaccess_principalid", null); }
            set
            {
                this.OnPropertyChanging("team_principalobjectattributeaccess_principalid");
                this.SetRelatedEntity<Team>("team_principalobjectattributeaccess_principalid", null, value);
                this.OnPropertyChanged("team_principalobjectattributeaccess_principalid");
            }
        }

        /// <summary>
        /// N:1 territory_principalobjectattributeaccess
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("territory_principalobjectattributeaccess")]
        public Territory territory_principalobjectattributeaccess
        {
            get { return this.GetRelatedEntity<Territory>("territory_principalobjectattributeaccess", null); }
            set
            {
                this.OnPropertyChanging("territory_principalobjectattributeaccess");
                this.SetRelatedEntity<Territory>("territory_principalobjectattributeaccess", null, value);
                this.OnPropertyChanged("territory_principalobjectattributeaccess");
            }
        }
    }
}