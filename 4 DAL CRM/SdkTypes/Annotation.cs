using _4_DAL_CRM;

namespace __4_DAL_CRM
{
    /// <summary>
    /// Note that is attached to one or more objects, including other notes.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("annotation")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class Annotation : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public Annotation() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "annotation";

        public const int EntityTypeCode = 5;

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
        /// Unique identifier of the note.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("annotationid")]
        public System.Nullable<System.Guid> AnnotationId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("annotationid"); }
            set
            {
                this.OnPropertyChanging("AnnotationId");
                this.SetAttributeValue("annotationid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("AnnotationId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("annotationid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.AnnotationId = value; }
        }

        /// <summary>
        /// Unique identifier of the user who created the note.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby"); }
        }

        /// <summary>
        /// Date and time when the note was created.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
        public System.Nullable<System.DateTime> CreatedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who created the annotation.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        /// Contents of the note's attachment.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("documentbody")]
        public string DocumentBody
        {
            get { return this.GetAttributeValue<string>("documentbody"); }
            set
            {
                this.OnPropertyChanging("DocumentBody");
                this.SetAttributeValue("documentbody", value);
                this.OnPropertyChanged("DocumentBody");
            }
        }

        /// <summary>
        /// File name of the note.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("filename")]
        public string FileName
        {
            get { return this.GetAttributeValue<string>("filename"); }
            set
            {
                this.OnPropertyChanging("FileName");
                this.SetAttributeValue("filename", value);
                this.OnPropertyChanged("FileName");
            }
        }

        /// <summary>
        /// File size of the note.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("filesize")]
        public System.Nullable<int> FileSize
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("filesize"); }
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
        /// Specifies whether the note is an attachment.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isdocument")]
        public System.Nullable<bool> IsDocument
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("isdocument"); }
            set
            {
                this.OnPropertyChanging("IsDocument");
                this.SetAttributeValue("isdocument", value);
                this.OnPropertyChanged("IsDocument");
            }
        }

        /// <summary>
        /// Language identifier for the note.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("langid")]
        public string LangId
        {
            get { return this.GetAttributeValue<string>("langid"); }
            set
            {
                this.OnPropertyChanging("LangId");
                this.SetAttributeValue("langid", value);
                this.OnPropertyChanged("LangId");
            }
        }

        /// <summary>
        /// MIME type of the note's attachment.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("mimetype")]
        public string MimeType
        {
            get { return this.GetAttributeValue<string>("mimetype"); }
            set
            {
                this.OnPropertyChanging("MimeType");
                this.SetAttributeValue("mimetype", value);
                this.OnPropertyChanged("MimeType");
            }
        }

        /// <summary>
        /// Unique identifier of the user who last modified the note.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby"); }
        }

        /// <summary>
        /// Date and time when the note was last modified.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
        public System.Nullable<System.DateTime> ModifiedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who last modified the annotation.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        /// Text of the note.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("notetext")]
        public string NoteText
        {
            get { return this.GetAttributeValue<string>("notetext"); }
            set
            {
                this.OnPropertyChanging("NoteText");
                this.SetAttributeValue("notetext", value);
                this.OnPropertyChanged("NoteText");
            }
        }

        /// <summary>
        /// Unique identifier of the object with which the note is associated.
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
        /// Type of entity with which the note is associated.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objecttypecode")]
        public string ObjectTypeCode
        {
            get { return this.GetAttributeValue<string>("objecttypecode"); }
            set
            {
                this.OnPropertyChanging("ObjectTypeCode");
                this.SetAttributeValue("objecttypecode", value);
                this.OnPropertyChanged("ObjectTypeCode");
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
        /// Unique identifier of the user or team who owns the note.
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
        /// Unique identifier of the business unit that owns the note.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
        public Microsoft.Xrm.Sdk.EntityReference OwningBusinessUnit
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningbusinessunit"); }
        }

        /// <summary>
        /// Unique identifier of the team who owns the note.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
        public Microsoft.Xrm.Sdk.EntityReference OwningTeam
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningteam"); }
        }

        /// <summary>
        /// Unique identifier of the user who owns the note.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
        public Microsoft.Xrm.Sdk.EntityReference OwningUser
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owninguser"); }
        }

        /// <summary>
        /// workflow step id associated with the note.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("stepid")]
        public string StepId
        {
            get { return this.GetAttributeValue<string>("stepid"); }
            set
            {
                this.OnPropertyChanging("StepId");
                this.SetAttributeValue("stepid", value);
                this.OnPropertyChanged("StepId");
            }
        }

        /// <summary>
        /// Subject associated with the note.
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
        /// Version number of the note.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
        public System.Nullable<long> VersionNumber
        {
            get { return this.GetAttributeValue<System.Nullable<long>>("versionnumber"); }
        }

        /// <summary>
        /// 1:N Annotation_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Annotation_AsyncOperations")]
        public System.Collections.Generic.IEnumerable<AsyncOperation> Annotation_AsyncOperations
        {
            get { return this.GetRelatedEntities<AsyncOperation>("Annotation_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("Annotation_AsyncOperations");
                this.SetRelatedEntities<AsyncOperation>("Annotation_AsyncOperations", null, value);
                this.OnPropertyChanged("Annotation_AsyncOperations");
            }
        }

        /// <summary>
        /// 1:N Annotation_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Annotation_BulkDeleteFailures")]
        public System.Collections.Generic.IEnumerable<BulkDeleteFailure> Annotation_BulkDeleteFailures
        {
            get { return this.GetRelatedEntities<BulkDeleteFailure>("Annotation_BulkDeleteFailures", null); }
            set
            {
                this.OnPropertyChanging("Annotation_BulkDeleteFailures");
                this.SetRelatedEntities<BulkDeleteFailure>("Annotation_BulkDeleteFailures", null, value);
                this.OnPropertyChanged("Annotation_BulkDeleteFailures");
            }
        }

        /// <summary>
        /// 1:N Annotation_ProcessSessions
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Annotation_ProcessSessions")]
        public System.Collections.Generic.IEnumerable<ProcessSession> Annotation_ProcessSessions
        {
            get { return this.GetRelatedEntities<ProcessSession>("Annotation_ProcessSessions", null); }
            set
            {
                this.OnPropertyChanging("Annotation_ProcessSessions");
                this.SetRelatedEntities<ProcessSession>("Annotation_ProcessSessions", null, value);
                this.OnPropertyChanged("Annotation_ProcessSessions");
            }
        }

        /// <summary>
        /// 1:N userentityinstancedata_annotation
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_annotation")]
        public System.Collections.Generic.IEnumerable<UserEntityInstanceData> userentityinstancedata_annotation
        {
            get { return this.GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_annotation", null); }
            set
            {
                this.OnPropertyChanging("userentityinstancedata_annotation");
                this.SetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_annotation", null, value);
                this.OnPropertyChanged("userentityinstancedata_annotation");
            }
        }

        /// <summary>
        /// N:1 Account_Annotation
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Account_Annotation")]
        public Account Account_Annotation
        {
            get { return this.GetRelatedEntity<Account>("Account_Annotation", null); }
            set
            {
                this.OnPropertyChanging("Account_Annotation");
                this.SetRelatedEntity<Account>("Account_Annotation", null, value);
                this.OnPropertyChanged("Account_Annotation");
            }
        }

        /// <summary>
        /// N:1 annotation_owning_user
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("annotation_owning_user")]
        public SystemUser annotation_owning_user
        {
            get { return this.GetRelatedEntity<SystemUser>("annotation_owning_user", null); }
        }

        /// <summary>
        /// N:1 Appointment_Annotation
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Appointment_Annotation")]
        public Appointment Appointment_Annotation
        {
            get { return this.GetRelatedEntity<Appointment>("Appointment_Annotation", null); }
            set
            {
                this.OnPropertyChanging("Appointment_Annotation");
                this.SetRelatedEntity<Appointment>("Appointment_Annotation", null, value);
                this.OnPropertyChanged("Appointment_Annotation");
            }
        }

        /// <summary>
        /// N:1 business_unit_annotations
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_annotations")]
        public BusinessUnit business_unit_annotations
        {
            get { return this.GetRelatedEntity<BusinessUnit>("business_unit_annotations", null); }
        }

        /// <summary>
        /// N:1 Calendar_Annotation
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Calendar_Annotation")]
        public Calendar Calendar_Annotation
        {
            get { return this.GetRelatedEntity<Calendar>("Calendar_Annotation", null); }
            set
            {
                this.OnPropertyChanging("Calendar_Annotation");
                this.SetRelatedEntity<Calendar>("Calendar_Annotation", null, value);
                this.OnPropertyChanged("Calendar_Annotation");
            }
        }

        /// <summary>
        /// N:1 Campaign_Annotation
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Campaign_Annotation")]
        public Campaign Campaign_Annotation
        {
            get { return this.GetRelatedEntity<Campaign>("Campaign_Annotation", null); }
            set
            {
                this.OnPropertyChanging("Campaign_Annotation");
                this.SetRelatedEntity<Campaign>("Campaign_Annotation", null, value);
                this.OnPropertyChanged("Campaign_Annotation");
            }
        }

        /// <summary>
        /// N:1 CampaignActivity_Annotation
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("CampaignActivity_Annotation")]
        public CampaignActivity CampaignActivity_Annotation
        {
            get { return this.GetRelatedEntity<CampaignActivity>("CampaignActivity_Annotation", null); }
            set
            {
                this.OnPropertyChanging("CampaignActivity_Annotation");
                this.SetRelatedEntity<CampaignActivity>("CampaignActivity_Annotation", null, value);
                this.OnPropertyChanged("CampaignActivity_Annotation");
            }
        }

        /// <summary>
        /// N:1 CampaignResponse_Annotation
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("CampaignResponse_Annotation")]
        public CampaignResponse CampaignResponse_Annotation
        {
            get { return this.GetRelatedEntity<CampaignResponse>("CampaignResponse_Annotation", null); }
            set
            {
                this.OnPropertyChanging("CampaignResponse_Annotation");
                this.SetRelatedEntity<CampaignResponse>("CampaignResponse_Annotation", null, value);
                this.OnPropertyChanged("CampaignResponse_Annotation");
            }
        }

        /// <summary>
        /// N:1 Competitor_Annotation
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Competitor_Annotation")]
        public Competitor Competitor_Annotation
        {
            get { return this.GetRelatedEntity<Competitor>("Competitor_Annotation", null); }
            set
            {
                this.OnPropertyChanging("Competitor_Annotation");
                this.SetRelatedEntity<Competitor>("Competitor_Annotation", null, value);
                this.OnPropertyChanged("Competitor_Annotation");
            }
        }

        /// <summary>
        /// N:1 Contact_Annotation
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Contact_Annotation")]
        public Contact Contact_Annotation
        {
            get { return this.GetRelatedEntity<Contact>("Contact_Annotation", null); }
            set
            {
                this.OnPropertyChanging("Contact_Annotation");
                this.SetRelatedEntity<Contact>("Contact_Annotation", null, value);
                this.OnPropertyChanged("Contact_Annotation");
            }
        }

        /// <summary>
        /// N:1 Contract_Annotation
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Contract_Annotation")]
        public Contract Contract_Annotation
        {
            get { return this.GetRelatedEntity<Contract>("Contract_Annotation", null); }
            set
            {
                this.OnPropertyChanging("Contract_Annotation");
                this.SetRelatedEntity<Contract>("Contract_Annotation", null, value);
                this.OnPropertyChanged("Contract_Annotation");
            }
        }

        /// <summary>
        /// N:1 ContractDetail_Annotation
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ContractDetail_Annotation")]
        public ContractDetail ContractDetail_Annotation
        {
            get { return this.GetRelatedEntity<ContractDetail>("ContractDetail_Annotation", null); }
            set
            {
                this.OnPropertyChanging("ContractDetail_Annotation");
                this.SetRelatedEntity<ContractDetail>("ContractDetail_Annotation", null, value);
                this.OnPropertyChanged("ContractDetail_Annotation");
            }
        }

        /// <summary>
        /// N:1 ConvertRule_Annotation
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ConvertRule_Annotation")]
        public ConvertRule ConvertRule_Annotation
        {
            get { return this.GetRelatedEntity<ConvertRule>("ConvertRule_Annotation", null); }
            set
            {
                this.OnPropertyChanging("ConvertRule_Annotation");
                this.SetRelatedEntity<ConvertRule>("ConvertRule_Annotation", null, value);
                this.OnPropertyChanged("ConvertRule_Annotation");
            }
        }

        /// <summary>
        /// N:1 DuplicateRule_Annotation
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("DuplicateRule_Annotation")]
        public DuplicateRule DuplicateRule_Annotation
        {
            get { return this.GetRelatedEntity<DuplicateRule>("DuplicateRule_Annotation", null); }
            set
            {
                this.OnPropertyChanging("DuplicateRule_Annotation");
                this.SetRelatedEntity<DuplicateRule>("DuplicateRule_Annotation", null, value);
                this.OnPropertyChanged("DuplicateRule_Annotation");
            }
        }

        /// <summary>
        /// N:1 Email_Annotation
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Email_Annotation")]
        public Email Email_Annotation
        {
            get { return this.GetRelatedEntity<Email>("Email_Annotation", null); }
            set
            {
                this.OnPropertyChanging("Email_Annotation");
                this.SetRelatedEntity<Email>("Email_Annotation", null, value);
                this.OnPropertyChanged("Email_Annotation");
            }
        }

        /// <summary>
        /// N:1 EmailServerProfile_Annotation
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("EmailServerProfile_Annotation")]
        public EmailServerProfile EmailServerProfile_Annotation
        {
            get { return this.GetRelatedEntity<EmailServerProfile>("EmailServerProfile_Annotation", null); }
            set
            {
                this.OnPropertyChanging("EmailServerProfile_Annotation");
                this.SetRelatedEntity<EmailServerProfile>("EmailServerProfile_Annotation", null, value);
                this.OnPropertyChanged("EmailServerProfile_Annotation");
            }
        }

        /// <summary>
        /// N:1 entitlement_Annotations
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("entitlement_Annotations")]
        public Entitlement entitlement_Annotations
        {
            get { return this.GetRelatedEntity<Entitlement>("entitlement_Annotations", null); }
            set
            {
                this.OnPropertyChanging("entitlement_Annotations");
                this.SetRelatedEntity<Entitlement>("entitlement_Annotations", null, value);
                this.OnPropertyChanged("entitlement_Annotations");
            }
        }

        /// <summary>
        /// N:1 entitlementchannel_Annotations
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("entitlementchannel_Annotations")]
        public EntitlementChannel entitlementchannel_Annotations
        {
            get { return this.GetRelatedEntity<EntitlementChannel>("entitlementchannel_Annotations", null); }
            set
            {
                this.OnPropertyChanging("entitlementchannel_Annotations");
                this.SetRelatedEntity<EntitlementChannel>("entitlementchannel_Annotations", null, value);
                this.OnPropertyChanged("entitlementchannel_Annotations");
            }
        }

        /// <summary>
        /// N:1 entitlementtemplate_Annotations
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("entitlementtemplate_Annotations")]
        public EntitlementTemplate entitlementtemplate_Annotations
        {
            get { return this.GetRelatedEntity<EntitlementTemplate>("entitlementtemplate_Annotations", null); }
            set
            {
                this.OnPropertyChanging("entitlementtemplate_Annotations");
                this.SetRelatedEntity<EntitlementTemplate>("entitlementtemplate_Annotations", null, value);
                this.OnPropertyChanged("entitlementtemplate_Annotations");
            }
        }

        /// <summary>
        /// N:1 Equipment_Annotation
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Equipment_Annotation")]
        public Equipment Equipment_Annotation
        {
            get { return this.GetRelatedEntity<Equipment>("Equipment_Annotation", null); }
            set
            {
                this.OnPropertyChanging("Equipment_Annotation");
                this.SetRelatedEntity<Equipment>("Equipment_Annotation", null, value);
                this.OnPropertyChanged("Equipment_Annotation");
            }
        }

        /// <summary>
        /// N:1 Fax_Annotation
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Fax_Annotation")]
        public Fax Fax_Annotation
        {
            get { return this.GetRelatedEntity<Fax>("Fax_Annotation", null); }
            set
            {
                this.OnPropertyChanging("Fax_Annotation");
                this.SetRelatedEntity<Fax>("Fax_Annotation", null, value);
                this.OnPropertyChanged("Fax_Annotation");
            }
        }

        /// <summary>
        /// N:1 Goal_Annotation
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Goal_Annotation")]
        public Goal Goal_Annotation
        {
            get { return this.GetRelatedEntity<Goal>("Goal_Annotation", null); }
            set
            {
                this.OnPropertyChanging("Goal_Annotation");
                this.SetRelatedEntity<Goal>("Goal_Annotation", null, value);
                this.OnPropertyChanged("Goal_Annotation");
            }
        }

        /// <summary>
        /// N:1 Incident_Annotation
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Incident_Annotation")]
        public Incident Incident_Annotation
        {
            get { return this.GetRelatedEntity<Incident>("Incident_Annotation", null); }
            set
            {
                this.OnPropertyChanging("Incident_Annotation");
                this.SetRelatedEntity<Incident>("Incident_Annotation", null, value);
                this.OnPropertyChanged("Incident_Annotation");
            }
        }

        /// <summary>
        /// N:1 IncidentResolution_Annotation
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("IncidentResolution_Annotation")]
        public IncidentResolution IncidentResolution_Annotation
        {
            get { return this.GetRelatedEntity<IncidentResolution>("IncidentResolution_Annotation", null); }
            set
            {
                this.OnPropertyChanging("IncidentResolution_Annotation");
                this.SetRelatedEntity<IncidentResolution>("IncidentResolution_Annotation", null, value);
                this.OnPropertyChanged("IncidentResolution_Annotation");
            }
        }

        /// <summary>
        /// N:1 Invoice_Annotation
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Invoice_Annotation")]
        public Invoice Invoice_Annotation
        {
            get { return this.GetRelatedEntity<Invoice>("Invoice_Annotation", null); }
            set
            {
                this.OnPropertyChanging("Invoice_Annotation");
                this.SetRelatedEntity<Invoice>("Invoice_Annotation", null, value);
                this.OnPropertyChanged("Invoice_Annotation");
            }
        }

        /// <summary>
        /// N:1 KbArticle_Annotation
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("KbArticle_Annotation")]
        public KbArticle KbArticle_Annotation
        {
            get { return this.GetRelatedEntity<KbArticle>("KbArticle_Annotation", null); }
            set
            {
                this.OnPropertyChanging("KbArticle_Annotation");
                this.SetRelatedEntity<KbArticle>("KbArticle_Annotation", null, value);
                this.OnPropertyChanged("KbArticle_Annotation");
            }
        }

        /// <summary>
        /// N:1 Lead_Annotation
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Lead_Annotation")]
        public Lead Lead_Annotation
        {
            get { return this.GetRelatedEntity<Lead>("Lead_Annotation", null); }
            set
            {
                this.OnPropertyChanging("Lead_Annotation");
                this.SetRelatedEntity<Lead>("Lead_Annotation", null, value);
                this.OnPropertyChanged("Lead_Annotation");
            }
        }

        /// <summary>
        /// N:1 Letter_Annotation
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Letter_Annotation")]
        public Letter Letter_Annotation
        {
            get { return this.GetRelatedEntity<Letter>("Letter_Annotation", null); }
            set
            {
                this.OnPropertyChanging("Letter_Annotation");
                this.SetRelatedEntity<Letter>("Letter_Annotation", null, value);
                this.OnPropertyChanged("Letter_Annotation");
            }
        }

        /// <summary>
        /// N:1 List_Annotation
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("List_Annotation")]
        public List List_Annotation
        {
            get { return this.GetRelatedEntity<List>("List_Annotation", null); }
            set
            {
                this.OnPropertyChanging("List_Annotation");
                this.SetRelatedEntity<List>("List_Annotation", null, value);
                this.OnPropertyChanged("List_Annotation");
            }
        }

        /// <summary>
        /// N:1 lk_annotationbase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_annotationbase_createdby")]
        public SystemUser lk_annotationbase_createdby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_annotationbase_createdby", null); }
        }

        /// <summary>
        /// N:1 lk_annotationbase_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_annotationbase_createdonbehalfby")]
        public SystemUser lk_annotationbase_createdonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_annotationbase_createdonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_annotationbase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_annotationbase_modifiedby")]
        public SystemUser lk_annotationbase_modifiedby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_annotationbase_modifiedby", null); }
        }

        /// <summary>
        /// N:1 lk_annotationbase_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_annotationbase_modifiedonbehalfby")]
        public SystemUser lk_annotationbase_modifiedonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_annotationbase_modifiedonbehalfby", null); }
        }

        /// <summary>
        /// N:1 Mailbox_Annotation
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Mailbox_Annotation")]
        public Mailbox Mailbox_Annotation
        {
            get { return this.GetRelatedEntity<Mailbox>("Mailbox_Annotation", null); }
            set
            {
                this.OnPropertyChanging("Mailbox_Annotation");
                this.SetRelatedEntity<Mailbox>("Mailbox_Annotation", null, value);
                this.OnPropertyChanged("Mailbox_Annotation");
            }
        }

        /// <summary>
        /// N:1 msdyn_postalbum_Annotations
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_postalbum_Annotations")]
        public msdyn_PostAlbum msdyn_postalbum_Annotations
        {
            get { return this.GetRelatedEntity<msdyn_PostAlbum>("msdyn_postalbum_Annotations", null); }
            set
            {
                this.OnPropertyChanging("msdyn_postalbum_Annotations");
                this.SetRelatedEntity<msdyn_PostAlbum>("msdyn_postalbum_Annotations", null, value);
                this.OnPropertyChanged("msdyn_postalbum_Annotations");
            }
        }

        /// <summary>
        /// N:1 Opportunity_Annotation
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Opportunity_Annotation")]
        public Opportunity Opportunity_Annotation
        {
            get { return this.GetRelatedEntity<Opportunity>("Opportunity_Annotation", null); }
            set
            {
                this.OnPropertyChanging("Opportunity_Annotation");
                this.SetRelatedEntity<Opportunity>("Opportunity_Annotation", null, value);
                this.OnPropertyChanged("Opportunity_Annotation");
            }
        }

        /// <summary>
        /// N:1 OpportunityClose_Annotation
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("OpportunityClose_Annotation")]
        public OpportunityClose OpportunityClose_Annotation
        {
            get { return this.GetRelatedEntity<OpportunityClose>("OpportunityClose_Annotation", null); }
            set
            {
                this.OnPropertyChanging("OpportunityClose_Annotation");
                this.SetRelatedEntity<OpportunityClose>("OpportunityClose_Annotation", null, value);
                this.OnPropertyChanged("OpportunityClose_Annotation");
            }
        }

        /// <summary>
        /// N:1 OrderClose_Annotation
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("OrderClose_Annotation")]
        public OrderClose OrderClose_Annotation
        {
            get { return this.GetRelatedEntity<OrderClose>("OrderClose_Annotation", null); }
            set
            {
                this.OnPropertyChanging("OrderClose_Annotation");
                this.SetRelatedEntity<OrderClose>("OrderClose_Annotation", null, value);
                this.OnPropertyChanged("OrderClose_Annotation");
            }
        }

        /// <summary>
        /// N:1 PhoneCall_Annotation
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("PhoneCall_Annotation")]
        public PhoneCall PhoneCall_Annotation
        {
            get { return this.GetRelatedEntity<PhoneCall>("PhoneCall_Annotation", null); }
            set
            {
                this.OnPropertyChanging("PhoneCall_Annotation");
                this.SetRelatedEntity<PhoneCall>("PhoneCall_Annotation", null, value);
                this.OnPropertyChanged("PhoneCall_Annotation");
            }
        }

        /// <summary>
        /// N:1 Product_Annotation
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Product_Annotation")]
        public Product Product_Annotation
        {
            get { return this.GetRelatedEntity<Product>("Product_Annotation", null); }
            set
            {
                this.OnPropertyChanging("Product_Annotation");
                this.SetRelatedEntity<Product>("Product_Annotation", null, value);
                this.OnPropertyChanged("Product_Annotation");
            }
        }

        /// <summary>
        /// N:1 Quote_Annotation
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Quote_Annotation")]
        public Quote Quote_Annotation
        {
            get { return this.GetRelatedEntity<Quote>("Quote_Annotation", null); }
            set
            {
                this.OnPropertyChanging("Quote_Annotation");
                this.SetRelatedEntity<Quote>("Quote_Annotation", null, value);
                this.OnPropertyChanged("Quote_Annotation");
            }
        }

        /// <summary>
        /// N:1 QuoteClose_Annotation
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("QuoteClose_Annotation")]
        public QuoteClose QuoteClose_Annotation
        {
            get { return this.GetRelatedEntity<QuoteClose>("QuoteClose_Annotation", null); }
            set
            {
                this.OnPropertyChanging("QuoteClose_Annotation");
                this.SetRelatedEntity<QuoteClose>("QuoteClose_Annotation", null, value);
                this.OnPropertyChanged("QuoteClose_Annotation");
            }
        }

        /// <summary>
        /// N:1 RecurringAppointmentMaster_Annotation
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("RecurringAppointmentMaster_Annotation")]
        public RecurringAppointmentMaster RecurringAppointmentMaster_Annotation
        {
            get { return this.GetRelatedEntity<RecurringAppointmentMaster>("RecurringAppointmentMaster_Annotation", null); }
            set
            {
                this.OnPropertyChanging("RecurringAppointmentMaster_Annotation");
                this.SetRelatedEntity<RecurringAppointmentMaster>("RecurringAppointmentMaster_Annotation", null, value);
                this.OnPropertyChanged("RecurringAppointmentMaster_Annotation");
            }
        }

        /// <summary>
        /// N:1 ResourceSpec_Annotation
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ResourceSpec_Annotation")]
        public ResourceSpec ResourceSpec_Annotation
        {
            get { return this.GetRelatedEntity<ResourceSpec>("ResourceSpec_Annotation", null); }
            set
            {
                this.OnPropertyChanging("ResourceSpec_Annotation");
                this.SetRelatedEntity<ResourceSpec>("ResourceSpec_Annotation", null, value);
                this.OnPropertyChanged("ResourceSpec_Annotation");
            }
        }

        /// <summary>
        /// N:1 routingrule_Annotation
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("routingrule_Annotation")]
        public RoutingRule routingrule_Annotation
        {
            get { return this.GetRelatedEntity<RoutingRule>("routingrule_Annotation", null); }
            set
            {
                this.OnPropertyChanging("routingrule_Annotation");
                this.SetRelatedEntity<RoutingRule>("routingrule_Annotation", null, value);
                this.OnPropertyChanged("routingrule_Annotation");
            }
        }

        /// <summary>
        /// N:1 routingruleitem_Annotation
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("routingruleitem_Annotation")]
        public RoutingRuleItem routingruleitem_Annotation
        {
            get { return this.GetRelatedEntity<RoutingRuleItem>("routingruleitem_Annotation", null); }
            set
            {
                this.OnPropertyChanging("routingruleitem_Annotation");
                this.SetRelatedEntity<RoutingRuleItem>("routingruleitem_Annotation", null, value);
                this.OnPropertyChanged("routingruleitem_Annotation");
            }
        }

        /// <summary>
        /// N:1 SalesOrder_Annotation
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SalesOrder_Annotation")]
        public SalesOrder SalesOrder_Annotation
        {
            get { return this.GetRelatedEntity<SalesOrder>("SalesOrder_Annotation", null); }
            set
            {
                this.OnPropertyChanging("SalesOrder_Annotation");
                this.SetRelatedEntity<SalesOrder>("SalesOrder_Annotation", null, value);
                this.OnPropertyChanged("SalesOrder_Annotation");
            }
        }

        /// <summary>
        /// N:1 Service_Annotation
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Service_Annotation")]
        public Service Service_Annotation
        {
            get { return this.GetRelatedEntity<Service>("Service_Annotation", null); }
            set
            {
                this.OnPropertyChanging("Service_Annotation");
                this.SetRelatedEntity<Service>("Service_Annotation", null, value);
                this.OnPropertyChanged("Service_Annotation");
            }
        }

        /// <summary>
        /// N:1 ServiceAppointment_Annotation
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ServiceAppointment_Annotation")]
        public ServiceAppointment ServiceAppointment_Annotation
        {
            get { return this.GetRelatedEntity<ServiceAppointment>("ServiceAppointment_Annotation", null); }
            set
            {
                this.OnPropertyChanging("ServiceAppointment_Annotation");
                this.SetRelatedEntity<ServiceAppointment>("ServiceAppointment_Annotation", null, value);
                this.OnPropertyChanged("ServiceAppointment_Annotation");
            }
        }

        /// <summary>
        /// N:1 SharePointDocument_Annotation
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SharePointDocument_Annotation")]
        public SharePointDocument SharePointDocument_Annotation
        {
            get { return this.GetRelatedEntity<SharePointDocument>("SharePointDocument_Annotation", null); }
            set
            {
                this.OnPropertyChanging("SharePointDocument_Annotation");
                this.SetRelatedEntity<SharePointDocument>("SharePointDocument_Annotation", null, value);
                this.OnPropertyChanged("SharePointDocument_Annotation");
            }
        }

        /// <summary>
        /// N:1 sla_Annotation
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("sla_Annotation")]
        public SLA sla_Annotation
        {
            get { return this.GetRelatedEntity<SLA>("sla_Annotation", null); }
            set
            {
                this.OnPropertyChanging("sla_Annotation");
                this.SetRelatedEntity<SLA>("sla_Annotation", null, value);
                this.OnPropertyChanged("sla_Annotation");
            }
        }

        /// <summary>
        /// N:1 SocialActivity_Annotation
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SocialActivity_Annotation")]
        public SocialActivity SocialActivity_Annotation
        {
            get { return this.GetRelatedEntity<SocialActivity>("SocialActivity_Annotation", null); }
            set
            {
                this.OnPropertyChanging("SocialActivity_Annotation");
                this.SetRelatedEntity<SocialActivity>("SocialActivity_Annotation", null, value);
                this.OnPropertyChanged("SocialActivity_Annotation");
            }
        }

        /// <summary>
        /// N:1 Task_Annotation
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Task_Annotation")]
        public Task Task_Annotation
        {
            get { return this.GetRelatedEntity<Task>("Task_Annotation", null); }
            set
            {
                this.OnPropertyChanging("Task_Annotation");
                this.SetRelatedEntity<Task>("Task_Annotation", null, value);
                this.OnPropertyChanged("Task_Annotation");
            }
        }

        /// <summary>
        /// N:1 team_annotations
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_annotations")]
        public Team team_annotations
        {
            get { return this.GetRelatedEntity<Team>("team_annotations", null); }
        }

        /// <summary>
        /// N:1 Workflow_Annotation
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Workflow_Annotation")]
        public Workflow Workflow_Annotation
        {
            get { return this.GetRelatedEntity<Workflow>("Workflow_Annotation", null); }
            set
            {
                this.OnPropertyChanging("Workflow_Annotation");
                this.SetRelatedEntity<Workflow>("Workflow_Annotation", null, value);
                this.OnPropertyChanged("Workflow_Annotation");
            }
        }
    }
}