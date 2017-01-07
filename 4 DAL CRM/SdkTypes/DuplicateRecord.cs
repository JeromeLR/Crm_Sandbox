using _4_DAL_CRM;

namespace __4_DAL_CRM
{
    /// <summary>
    /// Potential duplicate record.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("duplicaterecord")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class DuplicateRecord : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public DuplicateRecord() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "duplicaterecord";

        public const int EntityTypeCode = 4415;

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
        /// Unique identifier of the system job that created this record.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("asyncoperationid")]
        public Microsoft.Xrm.Sdk.EntityReference AsyncOperationId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("asyncoperationid"); }
        }

        /// <summary>
        /// Unique identifier of the base record.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("baserecordid")]
        public Microsoft.Xrm.Sdk.EntityReference BaseRecordId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("baserecordid"); }
        }

        /// <summary>
        /// Date and time when the duplicate record was created.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
        public System.Nullable<System.DateTime> CreatedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon"); }
        }

        /// <summary>
        /// Unique identifier of the duplicate record.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("duplicateid")]
        public System.Nullable<System.Guid> DuplicateId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("duplicateid"); }
            set
            {
                this.OnPropertyChanging("DuplicateId");
                this.SetAttributeValue("duplicateid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("DuplicateId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("duplicateid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.DuplicateId = value; }
        }

        /// <summary>
        /// Unique identifier of the potential duplicate record.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("duplicaterecordid")]
        public Microsoft.Xrm.Sdk.EntityReference DuplicateRecordId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("duplicaterecordid"); }
        }

        /// <summary>
        /// Unique identifier of the duplicate rule against which this duplicate was found.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("duplicateruleid")]
        public Microsoft.Xrm.Sdk.EntityReference DuplicateRuleId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("duplicateruleid"); }
        }

        /// <summary>
        /// Unique identifier of the user or team who owns the duplicate record.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ownerid")]
        public Microsoft.Xrm.Sdk.EntityReference OwnerId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("ownerid"); }
        }

        /// <summary>
        /// Unique identifier of the business unit that owns the duplicate record.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
        public System.Nullable<System.Guid> OwningBusinessUnit
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("owningbusinessunit"); }
        }

        /// <summary>
        /// Unique identifier of the user who owns the duplicate record.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
        public System.Nullable<System.Guid> OwningUser
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("owninguser"); }
        }

        /// <summary>
        /// 1:N userentityinstancedata_duplicaterecord
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_duplicaterecord")]
        public System.Collections.Generic.IEnumerable<UserEntityInstanceData> userentityinstancedata_duplicaterecord
        {
            get { return this.GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_duplicaterecord", null); }
            set
            {
                this.OnPropertyChanging("userentityinstancedata_duplicaterecord");
                this.SetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_duplicaterecord", null, value);
                this.OnPropertyChanged("userentityinstancedata_duplicaterecord");
            }
        }

        /// <summary>
        /// N:1 Account_DuplicateBaseRecord
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("baserecordid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Account_DuplicateBaseRecord")]
        public Account Account_DuplicateBaseRecord
        {
            get { return this.GetRelatedEntity<Account>("Account_DuplicateBaseRecord", null); }
        }

        /// <summary>
        /// N:1 Account_DuplicateMatchingRecord
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("duplicaterecordid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Account_DuplicateMatchingRecord")]
        public Account Account_DuplicateMatchingRecord
        {
            get { return this.GetRelatedEntity<Account>("Account_DuplicateMatchingRecord", null); }
        }

        /// <summary>
        /// N:1 Appointment_DuplicateBaseRecord
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("baserecordid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Appointment_DuplicateBaseRecord")]
        public Appointment Appointment_DuplicateBaseRecord
        {
            get { return this.GetRelatedEntity<Appointment>("Appointment_DuplicateBaseRecord", null); }
        }

        /// <summary>
        /// N:1 Appointment_DuplicateMatchingRecord
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("duplicaterecordid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Appointment_DuplicateMatchingRecord")]
        public Appointment Appointment_DuplicateMatchingRecord
        {
            get { return this.GetRelatedEntity<Appointment>("Appointment_DuplicateMatchingRecord", null); }
        }

        /// <summary>
        /// N:1 AsyncOperation_DuplicateBaseRecord
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("asyncoperationid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("AsyncOperation_DuplicateBaseRecord")]
        public AsyncOperation AsyncOperation_DuplicateBaseRecord
        {
            get { return this.GetRelatedEntity<AsyncOperation>("AsyncOperation_DuplicateBaseRecord", null); }
        }

        /// <summary>
        /// N:1 Campaign_DuplicateBaseRecord
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("baserecordid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Campaign_DuplicateBaseRecord")]
        public Campaign Campaign_DuplicateBaseRecord
        {
            get { return this.GetRelatedEntity<Campaign>("Campaign_DuplicateBaseRecord", null); }
        }

        /// <summary>
        /// N:1 Campaign_DuplicateMatchingRecord
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("duplicaterecordid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Campaign_DuplicateMatchingRecord")]
        public Campaign Campaign_DuplicateMatchingRecord
        {
            get { return this.GetRelatedEntity<Campaign>("Campaign_DuplicateMatchingRecord", null); }
        }

        /// <summary>
        /// N:1 CampaignResponse_DuplicateBaseRecord
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("baserecordid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("CampaignResponse_DuplicateBaseRecord")]
        public CampaignResponse CampaignResponse_DuplicateBaseRecord
        {
            get { return this.GetRelatedEntity<CampaignResponse>("CampaignResponse_DuplicateBaseRecord", null); }
        }

        /// <summary>
        /// N:1 CampaignResponse_DuplicateMatchingRecord
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("duplicaterecordid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("CampaignResponse_DuplicateMatchingRecord")]
        public CampaignResponse CampaignResponse_DuplicateMatchingRecord
        {
            get { return this.GetRelatedEntity<CampaignResponse>("CampaignResponse_DuplicateMatchingRecord", null); }
        }

        /// <summary>
        /// N:1 Competitor_DuplicateBaseRecord
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("baserecordid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Competitor_DuplicateBaseRecord")]
        public Competitor Competitor_DuplicateBaseRecord
        {
            get { return this.GetRelatedEntity<Competitor>("Competitor_DuplicateBaseRecord", null); }
        }

        /// <summary>
        /// N:1 Competitor_DuplicateMatchingRecord
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("duplicaterecordid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Competitor_DuplicateMatchingRecord")]
        public Competitor Competitor_DuplicateMatchingRecord
        {
            get { return this.GetRelatedEntity<Competitor>("Competitor_DuplicateMatchingRecord", null); }
        }

        /// <summary>
        /// N:1 Contact_DuplicateBaseRecord
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("baserecordid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Contact_DuplicateBaseRecord")]
        public Contact Contact_DuplicateBaseRecord
        {
            get { return this.GetRelatedEntity<Contact>("Contact_DuplicateBaseRecord", null); }
        }

        /// <summary>
        /// N:1 Contact_DuplicateMatchingRecord
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("duplicaterecordid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Contact_DuplicateMatchingRecord")]
        public Contact Contact_DuplicateMatchingRecord
        {
            get { return this.GetRelatedEntity<Contact>("Contact_DuplicateMatchingRecord", null); }
        }

        /// <summary>
        /// N:1 Contract_DuplicateBaseRecord
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("baserecordid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Contract_DuplicateBaseRecord")]
        public Contract Contract_DuplicateBaseRecord
        {
            get { return this.GetRelatedEntity<Contract>("Contract_DuplicateBaseRecord", null); }
        }

        /// <summary>
        /// N:1 Contract_DuplicateMatchingRecord
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("duplicaterecordid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Contract_DuplicateMatchingRecord")]
        public Contract Contract_DuplicateMatchingRecord
        {
            get { return this.GetRelatedEntity<Contract>("Contract_DuplicateMatchingRecord", null); }
        }

        /// <summary>
        /// N:1 DuplicateRule_DuplicateBaseRecord
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("duplicateruleid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("DuplicateRule_DuplicateBaseRecord")]
        public DuplicateRule DuplicateRule_DuplicateBaseRecord
        {
            get { return this.GetRelatedEntity<DuplicateRule>("DuplicateRule_DuplicateBaseRecord", null); }
        }

        /// <summary>
        /// N:1 Email_DuplicateBaseRecord
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("baserecordid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Email_DuplicateBaseRecord")]
        public Email Email_DuplicateBaseRecord
        {
            get { return this.GetRelatedEntity<Email>("Email_DuplicateBaseRecord", null); }
        }

        /// <summary>
        /// N:1 Email_DuplicateMatchingRecord
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("duplicaterecordid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Email_DuplicateMatchingRecord")]
        public Email Email_DuplicateMatchingRecord
        {
            get { return this.GetRelatedEntity<Email>("Email_DuplicateMatchingRecord", null); }
        }

        /// <summary>
        /// N:1 emailserverprofile_duplicatebaserecord
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("baserecordid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("emailserverprofile_duplicatebaserecord")]
        public EmailServerProfile emailserverprofile_duplicatebaserecord
        {
            get { return this.GetRelatedEntity<EmailServerProfile>("emailserverprofile_duplicatebaserecord", null); }
        }

        /// <summary>
        /// N:1 emailserverprofile_duplicatematchingrecord
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("duplicaterecordid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("emailserverprofile_duplicatematchingrecord")]
        public EmailServerProfile emailserverprofile_duplicatematchingrecord
        {
            get { return this.GetRelatedEntity<EmailServerProfile>("emailserverprofile_duplicatematchingrecord", null); }
        }

        /// <summary>
        /// N:1 entitlement_DuplicateBaseRecord
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("baserecordid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("entitlement_DuplicateBaseRecord")]
        public Entitlement entitlement_DuplicateBaseRecord
        {
            get { return this.GetRelatedEntity<Entitlement>("entitlement_DuplicateBaseRecord", null); }
        }

        /// <summary>
        /// N:1 entitlement_DuplicateMatchingRecord
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("duplicaterecordid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("entitlement_DuplicateMatchingRecord")]
        public Entitlement entitlement_DuplicateMatchingRecord
        {
            get { return this.GetRelatedEntity<Entitlement>("entitlement_DuplicateMatchingRecord", null); }
        }

        /// <summary>
        /// N:1 entitlementchannel_DuplicateBaseRecord
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("baserecordid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("entitlementchannel_DuplicateBaseRecord")]
        public EntitlementChannel entitlementchannel_DuplicateBaseRecord
        {
            get { return this.GetRelatedEntity<EntitlementChannel>("entitlementchannel_DuplicateBaseRecord", null); }
        }

        /// <summary>
        /// N:1 entitlementchannel_DuplicateMatchingRecord
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("duplicaterecordid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("entitlementchannel_DuplicateMatchingRecord")]
        public EntitlementChannel entitlementchannel_DuplicateMatchingRecord
        {
            get { return this.GetRelatedEntity<EntitlementChannel>("entitlementchannel_DuplicateMatchingRecord", null); }
        }

        /// <summary>
        /// N:1 entitlementtemplate_DuplicateBaseRecord
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("baserecordid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("entitlementtemplate_DuplicateBaseRecord")]
        public EntitlementTemplate entitlementtemplate_DuplicateBaseRecord
        {
            get { return this.GetRelatedEntity<EntitlementTemplate>("entitlementtemplate_DuplicateBaseRecord", null); }
        }

        /// <summary>
        /// N:1 entitlementtemplate_DuplicateMatchingRecord
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("duplicaterecordid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("entitlementtemplate_DuplicateMatchingRecord")]
        public EntitlementTemplate entitlementtemplate_DuplicateMatchingRecord
        {
            get { return this.GetRelatedEntity<EntitlementTemplate>("entitlementtemplate_DuplicateMatchingRecord", null); }
        }

        /// <summary>
        /// N:1 Equipment_DuplicateBaseRecord
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("baserecordid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Equipment_DuplicateBaseRecord")]
        public Equipment Equipment_DuplicateBaseRecord
        {
            get { return this.GetRelatedEntity<Equipment>("Equipment_DuplicateBaseRecord", null); }
        }

        /// <summary>
        /// N:1 Equipment_DuplicateMatchingRecord
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("duplicaterecordid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Equipment_DuplicateMatchingRecord")]
        public Equipment Equipment_DuplicateMatchingRecord
        {
            get { return this.GetRelatedEntity<Equipment>("Equipment_DuplicateMatchingRecord", null); }
        }

        /// <summary>
        /// N:1 Fax_DuplicateBaseRecord
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("baserecordid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Fax_DuplicateBaseRecord")]
        public Fax Fax_DuplicateBaseRecord
        {
            get { return this.GetRelatedEntity<Fax>("Fax_DuplicateBaseRecord", null); }
        }

        /// <summary>
        /// N:1 Fax_DuplicateMatchingRecord
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("duplicaterecordid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Fax_DuplicateMatchingRecord")]
        public Fax Fax_DuplicateMatchingRecord
        {
            get { return this.GetRelatedEntity<Fax>("Fax_DuplicateMatchingRecord", null); }
        }

        /// <summary>
        /// N:1 Goal_DuplicateBaseRecord
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("baserecordid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Goal_DuplicateBaseRecord")]
        public Goal Goal_DuplicateBaseRecord
        {
            get { return this.GetRelatedEntity<Goal>("Goal_DuplicateBaseRecord", null); }
        }

        /// <summary>
        /// N:1 Goal_DuplicateMatchingRecord
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("duplicaterecordid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Goal_DuplicateMatchingRecord")]
        public Goal Goal_DuplicateMatchingRecord
        {
            get { return this.GetRelatedEntity<Goal>("Goal_DuplicateMatchingRecord", null); }
        }

        /// <summary>
        /// N:1 GoalRollupQuery_DuplicateBaseRecord
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("baserecordid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("GoalRollupQuery_DuplicateBaseRecord")]
        public GoalRollupQuery GoalRollupQuery_DuplicateBaseRecord
        {
            get { return this.GetRelatedEntity<GoalRollupQuery>("GoalRollupQuery_DuplicateBaseRecord", null); }
        }

        /// <summary>
        /// N:1 GoalRollupQuery_DuplicateMatchingRecord
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("duplicaterecordid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("GoalRollupQuery_DuplicateMatchingRecord")]
        public GoalRollupQuery GoalRollupQuery_DuplicateMatchingRecord
        {
            get { return this.GetRelatedEntity<GoalRollupQuery>("GoalRollupQuery_DuplicateMatchingRecord", null); }
        }

        /// <summary>
        /// N:1 Incident_DuplicateBaseRecord
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("baserecordid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Incident_DuplicateBaseRecord")]
        public Incident Incident_DuplicateBaseRecord
        {
            get { return this.GetRelatedEntity<Incident>("Incident_DuplicateBaseRecord", null); }
        }

        /// <summary>
        /// N:1 Incident_DuplicateMatchingRecord
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("duplicaterecordid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Incident_DuplicateMatchingRecord")]
        public Incident Incident_DuplicateMatchingRecord
        {
            get { return this.GetRelatedEntity<Incident>("Incident_DuplicateMatchingRecord", null); }
        }

        /// <summary>
        /// N:1 KbArticle_DuplicateBaseRecord
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("baserecordid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("KbArticle_DuplicateBaseRecord")]
        public KbArticle KbArticle_DuplicateBaseRecord
        {
            get { return this.GetRelatedEntity<KbArticle>("KbArticle_DuplicateBaseRecord", null); }
        }

        /// <summary>
        /// N:1 KbArticle_DuplicateMatchingRecord
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("duplicaterecordid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("KbArticle_DuplicateMatchingRecord")]
        public KbArticle KbArticle_DuplicateMatchingRecord
        {
            get { return this.GetRelatedEntity<KbArticle>("KbArticle_DuplicateMatchingRecord", null); }
        }

        /// <summary>
        /// N:1 Lead_DuplicateBaseRecord
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("baserecordid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Lead_DuplicateBaseRecord")]
        public Lead Lead_DuplicateBaseRecord
        {
            get { return this.GetRelatedEntity<Lead>("Lead_DuplicateBaseRecord", null); }
        }

        /// <summary>
        /// N:1 Lead_DuplicateMatchingRecord
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("duplicaterecordid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Lead_DuplicateMatchingRecord")]
        public Lead Lead_DuplicateMatchingRecord
        {
            get { return this.GetRelatedEntity<Lead>("Lead_DuplicateMatchingRecord", null); }
        }

        /// <summary>
        /// N:1 Letter_DuplicateBaseRecord
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("baserecordid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Letter_DuplicateBaseRecord")]
        public Letter Letter_DuplicateBaseRecord
        {
            get { return this.GetRelatedEntity<Letter>("Letter_DuplicateBaseRecord", null); }
        }

        /// <summary>
        /// N:1 Letter_DuplicateMatchingRecord
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("duplicaterecordid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Letter_DuplicateMatchingRecord")]
        public Letter Letter_DuplicateMatchingRecord
        {
            get { return this.GetRelatedEntity<Letter>("Letter_DuplicateMatchingRecord", null); }
        }

        /// <summary>
        /// N:1 List_DuplicateBaseRecord
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("baserecordid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("List_DuplicateBaseRecord")]
        public List List_DuplicateBaseRecord
        {
            get { return this.GetRelatedEntity<List>("List_DuplicateBaseRecord", null); }
        }

        /// <summary>
        /// N:1 List_DuplicateMatchingRecord
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("duplicaterecordid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("List_DuplicateMatchingRecord")]
        public List List_DuplicateMatchingRecord
        {
            get { return this.GetRelatedEntity<List>("List_DuplicateMatchingRecord", null); }
        }

        /// <summary>
        /// N:1 msdyn_postalbum_DuplicateBaseRecord
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("baserecordid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_postalbum_DuplicateBaseRecord")]
        public msdyn_PostAlbum msdyn_postalbum_DuplicateBaseRecord
        {
            get { return this.GetRelatedEntity<msdyn_PostAlbum>("msdyn_postalbum_DuplicateBaseRecord", null); }
        }

        /// <summary>
        /// N:1 msdyn_postalbum_DuplicateMatchingRecord
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("duplicaterecordid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_postalbum_DuplicateMatchingRecord")]
        public msdyn_PostAlbum msdyn_postalbum_DuplicateMatchingRecord
        {
            get { return this.GetRelatedEntity<msdyn_PostAlbum>("msdyn_postalbum_DuplicateMatchingRecord", null); }
        }

        /// <summary>
        /// N:1 Opportunity_DuplicateBaseRecord
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("baserecordid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Opportunity_DuplicateBaseRecord")]
        public Opportunity Opportunity_DuplicateBaseRecord
        {
            get { return this.GetRelatedEntity<Opportunity>("Opportunity_DuplicateBaseRecord", null); }
        }

        /// <summary>
        /// N:1 Opportunity_DuplicateMatchingRecord
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("duplicaterecordid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Opportunity_DuplicateMatchingRecord")]
        public Opportunity Opportunity_DuplicateMatchingRecord
        {
            get { return this.GetRelatedEntity<Opportunity>("Opportunity_DuplicateMatchingRecord", null); }
        }

        /// <summary>
        /// N:1 PhoneCall_DuplicateBaseRecord
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("baserecordid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("PhoneCall_DuplicateBaseRecord")]
        public PhoneCall PhoneCall_DuplicateBaseRecord
        {
            get { return this.GetRelatedEntity<PhoneCall>("PhoneCall_DuplicateBaseRecord", null); }
        }

        /// <summary>
        /// N:1 PhoneCall_DuplicateMatchingRecord
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("duplicaterecordid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("PhoneCall_DuplicateMatchingRecord")]
        public PhoneCall PhoneCall_DuplicateMatchingRecord
        {
            get { return this.GetRelatedEntity<PhoneCall>("PhoneCall_DuplicateMatchingRecord", null); }
        }

        /// <summary>
        /// N:1 Publisher_DuplicateBaseRecord
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("baserecordid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Publisher_DuplicateBaseRecord")]
        public Publisher Publisher_DuplicateBaseRecord
        {
            get { return this.GetRelatedEntity<Publisher>("Publisher_DuplicateBaseRecord", null); }
        }

        /// <summary>
        /// N:1 Publisher_DuplicateMatchingRecord
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("duplicaterecordid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Publisher_DuplicateMatchingRecord")]
        public Publisher Publisher_DuplicateMatchingRecord
        {
            get { return this.GetRelatedEntity<Publisher>("Publisher_DuplicateMatchingRecord", null); }
        }

        /// <summary>
        /// N:1 Queue_DuplicateBaseRecord
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("baserecordid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Queue_DuplicateBaseRecord")]
        public Queue Queue_DuplicateBaseRecord
        {
            get { return this.GetRelatedEntity<Queue>("Queue_DuplicateBaseRecord", null); }
        }

        /// <summary>
        /// N:1 Queue_DuplicateMatchingRecord
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("duplicaterecordid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Queue_DuplicateMatchingRecord")]
        public Queue Queue_DuplicateMatchingRecord
        {
            get { return this.GetRelatedEntity<Queue>("Queue_DuplicateMatchingRecord", null); }
        }

        /// <summary>
        /// N:1 Quote_DuplicateBaseRecord
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("baserecordid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Quote_DuplicateBaseRecord")]
        public Quote Quote_DuplicateBaseRecord
        {
            get { return this.GetRelatedEntity<Quote>("Quote_DuplicateBaseRecord", null); }
        }

        /// <summary>
        /// N:1 Quote_DuplicateMatchingRecord
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("duplicaterecordid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Quote_DuplicateMatchingRecord")]
        public Quote Quote_DuplicateMatchingRecord
        {
            get { return this.GetRelatedEntity<Quote>("Quote_DuplicateMatchingRecord", null); }
        }

        /// <summary>
        /// N:1 RecurringAppointmentMaster_DuplicateBaseRecord
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("baserecordid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("RecurringAppointmentMaster_DuplicateBaseRecord")]
        public RecurringAppointmentMaster RecurringAppointmentMaster_DuplicateBaseRecord
        {
            get { return this.GetRelatedEntity<RecurringAppointmentMaster>("RecurringAppointmentMaster_DuplicateBaseRecord", null); }
        }

        /// <summary>
        /// N:1 RecurringAppointmentMaster_DuplicateMatchingRecord
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("duplicaterecordid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("RecurringAppointmentMaster_DuplicateMatchingRecord")]
        public RecurringAppointmentMaster RecurringAppointmentMaster_DuplicateMatchingRecord
        {
            get { return this.GetRelatedEntity<RecurringAppointmentMaster>("RecurringAppointmentMaster_DuplicateMatchingRecord", null); }
        }

        /// <summary>
        /// N:1 ResourceGroup_DuplicateBaseRecord
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("baserecordid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ResourceGroup_DuplicateBaseRecord")]
        public ResourceGroup ResourceGroup_DuplicateBaseRecord
        {
            get { return this.GetRelatedEntity<ResourceGroup>("ResourceGroup_DuplicateBaseRecord", null); }
        }

        /// <summary>
        /// N:1 ResourceGroup_DuplicateMatchingRecord
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("duplicaterecordid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ResourceGroup_DuplicateMatchingRecord")]
        public ResourceGroup ResourceGroup_DuplicateMatchingRecord
        {
            get { return this.GetRelatedEntity<ResourceGroup>("ResourceGroup_DuplicateMatchingRecord", null); }
        }

        /// <summary>
        /// N:1 Service_DuplicateBaseRecord
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("baserecordid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Service_DuplicateBaseRecord")]
        public Service Service_DuplicateBaseRecord
        {
            get { return this.GetRelatedEntity<Service>("Service_DuplicateBaseRecord", null); }
        }

        /// <summary>
        /// N:1 Service_DuplicateMatchingRecord
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("duplicaterecordid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Service_DuplicateMatchingRecord")]
        public Service Service_DuplicateMatchingRecord
        {
            get { return this.GetRelatedEntity<Service>("Service_DuplicateMatchingRecord", null); }
        }

        /// <summary>
        /// N:1 SharePointDocumentLocation_DuplicateBaseRecord
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("baserecordid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SharePointDocumentLocation_DuplicateBaseRecord")]
        public SharePointDocumentLocation SharePointDocumentLocation_DuplicateBaseRecord
        {
            get { return this.GetRelatedEntity<SharePointDocumentLocation>("SharePointDocumentLocation_DuplicateBaseRecord", null); }
        }

        /// <summary>
        /// N:1 SharePointDocumentLocation_DuplicateMatchingRecord
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("duplicaterecordid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SharePointDocumentLocation_DuplicateMatchingRecord")]
        public SharePointDocumentLocation SharePointDocumentLocation_DuplicateMatchingRecord
        {
            get { return this.GetRelatedEntity<SharePointDocumentLocation>("SharePointDocumentLocation_DuplicateMatchingRecord", null); }
        }

        /// <summary>
        /// N:1 SharePointSite_DuplicateBaseRecord
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("baserecordid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SharePointSite_DuplicateBaseRecord")]
        public SharePointSite SharePointSite_DuplicateBaseRecord
        {
            get { return this.GetRelatedEntity<SharePointSite>("SharePointSite_DuplicateBaseRecord", null); }
        }

        /// <summary>
        /// N:1 SharePointSite_DuplicateMatchingRecord
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("duplicaterecordid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SharePointSite_DuplicateMatchingRecord")]
        public SharePointSite SharePointSite_DuplicateMatchingRecord
        {
            get { return this.GetRelatedEntity<SharePointSite>("SharePointSite_DuplicateMatchingRecord", null); }
        }

        /// <summary>
        /// N:1 SocialActivity_DuplicateBaseRecord
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("baserecordid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SocialActivity_DuplicateBaseRecord")]
        public SocialActivity SocialActivity_DuplicateBaseRecord
        {
            get { return this.GetRelatedEntity<SocialActivity>("SocialActivity_DuplicateBaseRecord", null); }
        }

        /// <summary>
        /// N:1 SocialActivity_DuplicateMatchingRecord
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("duplicaterecordid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SocialActivity_DuplicateMatchingRecord")]
        public SocialActivity SocialActivity_DuplicateMatchingRecord
        {
            get { return this.GetRelatedEntity<SocialActivity>("SocialActivity_DuplicateMatchingRecord", null); }
        }

        /// <summary>
        /// N:1 SocialProfile_DuplicateBaseRecord
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("baserecordid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SocialProfile_DuplicateBaseRecord")]
        public SocialProfile SocialProfile_DuplicateBaseRecord
        {
            get { return this.GetRelatedEntity<SocialProfile>("SocialProfile_DuplicateBaseRecord", null); }
        }

        /// <summary>
        /// N:1 SocialProfile_DuplicateMatchingRecord
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("duplicaterecordid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SocialProfile_DuplicateMatchingRecord")]
        public SocialProfile SocialProfile_DuplicateMatchingRecord
        {
            get { return this.GetRelatedEntity<SocialProfile>("SocialProfile_DuplicateMatchingRecord", null); }
        }

        /// <summary>
        /// N:1 SystemUser_DuplicateBaseRecord
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("baserecordid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SystemUser_DuplicateBaseRecord")]
        public SystemUser SystemUser_DuplicateBaseRecord
        {
            get { return this.GetRelatedEntity<SystemUser>("SystemUser_DuplicateBaseRecord", null); }
        }

        /// <summary>
        /// N:1 SystemUser_DuplicateMatchingRecord
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("duplicaterecordid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SystemUser_DuplicateMatchingRecord")]
        public SystemUser SystemUser_DuplicateMatchingRecord
        {
            get { return this.GetRelatedEntity<SystemUser>("SystemUser_DuplicateMatchingRecord", null); }
        }

        /// <summary>
        /// N:1 Task_DuplicateBaseRecord
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("baserecordid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Task_DuplicateBaseRecord")]
        public Task Task_DuplicateBaseRecord
        {
            get { return this.GetRelatedEntity<Task>("Task_DuplicateBaseRecord", null); }
        }

        /// <summary>
        /// N:1 Task_DuplicateMatchingRecord
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("duplicaterecordid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Task_DuplicateMatchingRecord")]
        public Task Task_DuplicateMatchingRecord
        {
            get { return this.GetRelatedEntity<Task>("Task_DuplicateMatchingRecord", null); }
        }

        /// <summary>
        /// N:1 Team_DuplicateBaseRecord
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("baserecordid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Team_DuplicateBaseRecord")]
        public Team Team_DuplicateBaseRecord
        {
            get { return this.GetRelatedEntity<Team>("Team_DuplicateBaseRecord", null); }
        }

        /// <summary>
        /// N:1 Team_DuplicateMatchingRecord
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("duplicaterecordid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Team_DuplicateMatchingRecord")]
        public Team Team_DuplicateMatchingRecord
        {
            get { return this.GetRelatedEntity<Team>("Team_DuplicateMatchingRecord", null); }
        }

        /// <summary>
        /// N:1 Territory_DuplicateBaseRecord
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("baserecordid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Territory_DuplicateBaseRecord")]
        public Territory Territory_DuplicateBaseRecord
        {
            get { return this.GetRelatedEntity<Territory>("Territory_DuplicateBaseRecord", null); }
        }

        /// <summary>
        /// N:1 Territory_DuplicateMatchingRecord
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("duplicaterecordid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Territory_DuplicateMatchingRecord")]
        public Territory Territory_DuplicateMatchingRecord
        {
            get { return this.GetRelatedEntity<Territory>("Territory_DuplicateMatchingRecord", null); }
        }

        /// <summary>
        /// N:1 TransactionCurrency_DuplicateBaseRecord
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("baserecordid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("TransactionCurrency_DuplicateBaseRecord")]
        public TransactionCurrency TransactionCurrency_DuplicateBaseRecord
        {
            get { return this.GetRelatedEntity<TransactionCurrency>("TransactionCurrency_DuplicateBaseRecord", null); }
        }

        /// <summary>
        /// N:1 TransactionCurrency_DuplicateMatchingRecord
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("duplicaterecordid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("TransactionCurrency_DuplicateMatchingRecord")]
        public TransactionCurrency TransactionCurrency_DuplicateMatchingRecord
        {
            get { return this.GetRelatedEntity<TransactionCurrency>("TransactionCurrency_DuplicateMatchingRecord", null); }
        }
    }
}