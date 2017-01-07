using _4_DAL_CRM;

namespace __4_DAL_CRM
{
    /// <summary>
    /// Record that was not deleted during a bulk deletion job.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("bulkdeletefailure")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class BulkDeleteFailure : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public BulkDeleteFailure() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "bulkdeletefailure";

        public const int EntityTypeCode = 4425;

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
        /// Unique identifier of the bulk deletion failure record.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("bulkdeletefailureid")]
        public System.Nullable<System.Guid> BulkDeleteFailureId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("bulkdeletefailureid"); }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("bulkdeletefailureid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { base.Id = value; }
        }

        /// <summary>
        /// Unique identifier of the bulk operation job which created this record
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("bulkdeleteoperationid")]
        public Microsoft.Xrm.Sdk.EntityReference BulkDeleteOperationId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("bulkdeleteoperationid"); }
        }

        /// <summary>
        /// Description of the error.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("errordescription")]
        public string ErrorDescription
        {
            get { return this.GetAttributeValue<string>("errordescription"); }
        }

        /// <summary>
        /// Error code for the failed bulk deletion.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("errornumber")]
        public System.Nullable<int> ErrorNumber
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("errornumber"); }
        }

        /// <summary>
        /// Index of the ordered query expression that retrieved this record.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("orderedqueryindex")]
        public System.Nullable<int> OrderedQueryIndex
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("orderedqueryindex"); }
        }

        /// <summary>
        /// Unique identifier of the user or team who owns the bulk operation log.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ownerid")]
        public Microsoft.Xrm.Sdk.EntityReference OwnerId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("ownerid"); }
        }

        /// <summary>
        /// Unique identifier of the business unit that owns the bulk deletion failure.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
        public System.Nullable<System.Guid> OwningBusinessUnit
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("owningbusinessunit"); }
        }

        /// <summary>
        /// Unique identifier of the user who owns the bulk deletion failure record.
        ///
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
        public System.Nullable<System.Guid> OwningUser
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("owninguser"); }
        }

        /// <summary>
        /// Unique identifier of the record that can not be deleted.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        public Microsoft.Xrm.Sdk.EntityReference RegardingObjectId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("regardingobjectid"); }
        }

        /// <summary>
        /// 1:N userentityinstancedata_bulkdeletefailure
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_bulkdeletefailure")]
        public System.Collections.Generic.IEnumerable<UserEntityInstanceData> userentityinstancedata_bulkdeletefailure
        {
            get { return this.GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_bulkdeletefailure", null); }
            set
            {
                this.OnPropertyChanging("userentityinstancedata_bulkdeletefailure");
                this.SetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_bulkdeletefailure", null, value);
                this.OnPropertyChanged("userentityinstancedata_bulkdeletefailure");
            }
        }

        /// <summary>
        /// N:1 Account_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Account_BulkDeleteFailures")]
        public Account Account_BulkDeleteFailures
        {
            get { return this.GetRelatedEntity<Account>("Account_BulkDeleteFailures", null); }
        }

        /// <summary>
        /// N:1 ActivityMimeAttachment_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ActivityMimeAttachment_BulkDeleteFailures")]
        public ActivityMimeAttachment ActivityMimeAttachment_BulkDeleteFailures
        {
            get { return this.GetRelatedEntity<ActivityMimeAttachment>("ActivityMimeAttachment_BulkDeleteFailures", null); }
        }

        /// <summary>
        /// N:1 ActivityPointer_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ActivityPointer_BulkDeleteFailures")]
        public ActivityPointer ActivityPointer_BulkDeleteFailures
        {
            get { return this.GetRelatedEntity<ActivityPointer>("ActivityPointer_BulkDeleteFailures", null); }
        }

        /// <summary>
        /// N:1 Annotation_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Annotation_BulkDeleteFailures")]
        public Annotation Annotation_BulkDeleteFailures
        {
            get { return this.GetRelatedEntity<Annotation>("Annotation_BulkDeleteFailures", null); }
        }

        /// <summary>
        /// N:1 AnnualFiscalCalendar_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("AnnualFiscalCalendar_BulkDeleteFailures")]
        public AnnualFiscalCalendar AnnualFiscalCalendar_BulkDeleteFailures
        {
            get { return this.GetRelatedEntity<AnnualFiscalCalendar>("AnnualFiscalCalendar_BulkDeleteFailures", null); }
        }

        /// <summary>
        /// N:1 Appointment_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Appointment_BulkDeleteFailures")]
        public Appointment Appointment_BulkDeleteFailures
        {
            get { return this.GetRelatedEntity<Appointment>("Appointment_BulkDeleteFailures", null); }
        }

        /// <summary>
        /// N:1 AttributeMap_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("AttributeMap_BulkDeleteFailures")]
        public AttributeMap AttributeMap_BulkDeleteFailures
        {
            get { return this.GetRelatedEntity<AttributeMap>("AttributeMap_BulkDeleteFailures", null); }
        }

        /// <summary>
        /// N:1 BulkDeleteOperation_BulkDeleteFailure
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("bulkdeleteoperationid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("BulkDeleteOperation_BulkDeleteFailure")]
        public BulkDeleteOperation BulkDeleteOperation_BulkDeleteFailure
        {
            get { return this.GetRelatedEntity<BulkDeleteOperation>("BulkDeleteOperation_BulkDeleteFailure", null); }
        }

        /// <summary>
        /// N:1 BulkOperation_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("BulkOperation_BulkDeleteFailures")]
        public BulkOperation BulkOperation_BulkDeleteFailures
        {
            get { return this.GetRelatedEntity<BulkOperation>("BulkOperation_BulkDeleteFailures", null); }
        }

        /// <summary>
        /// N:1 BulkOperationLog_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("BulkOperationLog_BulkDeleteFailures")]
        public BulkOperationLog BulkOperationLog_BulkDeleteFailures
        {
            get { return this.GetRelatedEntity<BulkOperationLog>("BulkOperationLog_BulkDeleteFailures", null); }
        }

        /// <summary>
        /// N:1 BusinessUnit_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("BusinessUnit_BulkDeleteFailures")]
        public BusinessUnit BusinessUnit_BulkDeleteFailures
        {
            get { return this.GetRelatedEntity<BusinessUnit>("BusinessUnit_BulkDeleteFailures", null); }
        }

        /// <summary>
        /// N:1 BusinessUnitNewsArticle_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("BusinessUnitNewsArticle_BulkDeleteFailures")]
        public BusinessUnitNewsArticle BusinessUnitNewsArticle_BulkDeleteFailures
        {
            get { return this.GetRelatedEntity<BusinessUnitNewsArticle>("BusinessUnitNewsArticle_BulkDeleteFailures", null); }
        }

        /// <summary>
        /// N:1 Calendar_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Calendar_BulkDeleteFailures")]
        public Calendar Calendar_BulkDeleteFailures
        {
            get { return this.GetRelatedEntity<Calendar>("Calendar_BulkDeleteFailures", null); }
        }

        /// <summary>
        /// N:1 Campaign_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Campaign_BulkDeleteFailures")]
        public Campaign Campaign_BulkDeleteFailures
        {
            get { return this.GetRelatedEntity<Campaign>("Campaign_BulkDeleteFailures", null); }
        }

        /// <summary>
        /// N:1 CampaignActivity_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("CampaignActivity_BulkDeleteFailures")]
        public CampaignActivity CampaignActivity_BulkDeleteFailures
        {
            get { return this.GetRelatedEntity<CampaignActivity>("CampaignActivity_BulkDeleteFailures", null); }
        }

        /// <summary>
        /// N:1 CampaignResponse_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("CampaignResponse_BulkDeleteFailures")]
        public CampaignResponse CampaignResponse_BulkDeleteFailures
        {
            get { return this.GetRelatedEntity<CampaignResponse>("CampaignResponse_BulkDeleteFailures", null); }
        }

        /// <summary>
        /// N:1 Competitor_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Competitor_BulkDeleteFailures")]
        public Competitor Competitor_BulkDeleteFailures
        {
            get { return this.GetRelatedEntity<Competitor>("Competitor_BulkDeleteFailures", null); }
        }

        /// <summary>
        /// N:1 ConstraintBasedGroup_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ConstraintBasedGroup_BulkDeleteFailures")]
        public ConstraintBasedGroup ConstraintBasedGroup_BulkDeleteFailures
        {
            get { return this.GetRelatedEntity<ConstraintBasedGroup>("ConstraintBasedGroup_BulkDeleteFailures", null); }
        }

        /// <summary>
        /// N:1 Contact_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Contact_BulkDeleteFailures")]
        public Contact Contact_BulkDeleteFailures
        {
            get { return this.GetRelatedEntity<Contact>("Contact_BulkDeleteFailures", null); }
        }

        /// <summary>
        /// N:1 Contract_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Contract_BulkDeleteFailures")]
        public Contract Contract_BulkDeleteFailures
        {
            get { return this.GetRelatedEntity<Contract>("Contract_BulkDeleteFailures", null); }
        }

        /// <summary>
        /// N:1 ContractDetail_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ContractDetail_BulkDeleteFailures")]
        public ContractDetail ContractDetail_BulkDeleteFailures
        {
            get { return this.GetRelatedEntity<ContractDetail>("ContractDetail_BulkDeleteFailures", null); }
        }

        /// <summary>
        /// N:1 ContractTemplate_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ContractTemplate_BulkDeleteFailures")]
        public ContractTemplate ContractTemplate_BulkDeleteFailures
        {
            get { return this.GetRelatedEntity<ContractTemplate>("ContractTemplate_BulkDeleteFailures", null); }
        }

        /// <summary>
        /// N:1 CustomerAddress_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("CustomerAddress_BulkDeleteFailures")]
        public CustomerAddress CustomerAddress_BulkDeleteFailures
        {
            get { return this.GetRelatedEntity<CustomerAddress>("CustomerAddress_BulkDeleteFailures", null); }
        }

        /// <summary>
        /// N:1 CustomerOpportunityRole_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("CustomerOpportunityRole_BulkDeleteFailures")]
        public CustomerOpportunityRole CustomerOpportunityRole_BulkDeleteFailures
        {
            get { return this.GetRelatedEntity<CustomerOpportunityRole>("CustomerOpportunityRole_BulkDeleteFailures", null); }
        }

        /// <summary>
        /// N:1 CustomerRelationship_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("CustomerRelationship_BulkDeleteFailures")]
        public CustomerRelationship CustomerRelationship_BulkDeleteFailures
        {
            get { return this.GetRelatedEntity<CustomerRelationship>("CustomerRelationship_BulkDeleteFailures", null); }
        }

        /// <summary>
        /// N:1 Discount_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Discount_BulkDeleteFailures")]
        public Discount Discount_BulkDeleteFailures
        {
            get { return this.GetRelatedEntity<Discount>("Discount_BulkDeleteFailures", null); }
        }

        /// <summary>
        /// N:1 DiscountType_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("DiscountType_BulkDeleteFailures")]
        public DiscountType DiscountType_BulkDeleteFailures
        {
            get { return this.GetRelatedEntity<DiscountType>("DiscountType_BulkDeleteFailures", null); }
        }

        /// <summary>
        /// N:1 DisplayString_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("DisplayString_BulkDeleteFailures")]
        public DisplayString DisplayString_BulkDeleteFailures
        {
            get { return this.GetRelatedEntity<DisplayString>("DisplayString_BulkDeleteFailures", null); }
        }

        /// <summary>
        /// N:1 Email_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Email_BulkDeleteFailures")]
        public Email Email_BulkDeleteFailures
        {
            get { return this.GetRelatedEntity<Email>("Email_BulkDeleteFailures", null); }
        }

        /// <summary>
        /// N:1 emailserverprofile_bulkdeletefailures
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("emailserverprofile_bulkdeletefailures")]
        public EmailServerProfile emailserverprofile_bulkdeletefailures
        {
            get { return this.GetRelatedEntity<EmailServerProfile>("emailserverprofile_bulkdeletefailures", null); }
        }

        /// <summary>
        /// N:1 entitlement_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("entitlement_BulkDeleteFailures")]
        public Entitlement entitlement_BulkDeleteFailures
        {
            get { return this.GetRelatedEntity<Entitlement>("entitlement_BulkDeleteFailures", null); }
        }

        /// <summary>
        /// N:1 entitlementchannel_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("entitlementchannel_BulkDeleteFailures")]
        public EntitlementChannel entitlementchannel_BulkDeleteFailures
        {
            get { return this.GetRelatedEntity<EntitlementChannel>("entitlementchannel_BulkDeleteFailures", null); }
        }

        /// <summary>
        /// N:1 entitlementtemplate_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("entitlementtemplate_BulkDeleteFailures")]
        public EntitlementTemplate entitlementtemplate_BulkDeleteFailures
        {
            get { return this.GetRelatedEntity<EntitlementTemplate>("entitlementtemplate_BulkDeleteFailures", null); }
        }

        /// <summary>
        /// N:1 EntityMap_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("EntityMap_BulkDeleteFailures")]
        public EntityMap EntityMap_BulkDeleteFailures
        {
            get { return this.GetRelatedEntity<EntityMap>("EntityMap_BulkDeleteFailures", null); }
        }

        /// <summary>
        /// N:1 Equipment_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Equipment_BulkDeleteFailures")]
        public Equipment Equipment_BulkDeleteFailures
        {
            get { return this.GetRelatedEntity<Equipment>("Equipment_BulkDeleteFailures", null); }
        }

        /// <summary>
        /// N:1 Fax_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Fax_BulkDeleteFailures")]
        public Fax Fax_BulkDeleteFailures
        {
            get { return this.GetRelatedEntity<Fax>("Fax_BulkDeleteFailures", null); }
        }

        /// <summary>
        /// N:1 FixedMonthlyFiscalCalendar_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("FixedMonthlyFiscalCalendar_BulkDeleteFailures")]
        public FixedMonthlyFiscalCalendar FixedMonthlyFiscalCalendar_BulkDeleteFailures
        {
            get { return this.GetRelatedEntity<FixedMonthlyFiscalCalendar>("FixedMonthlyFiscalCalendar_BulkDeleteFailures", null); }
        }

        /// <summary>
        /// N:1 Import_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Import_BulkDeleteFailures")]
        public Import Import_BulkDeleteFailures
        {
            get { return this.GetRelatedEntity<Import>("Import_BulkDeleteFailures", null); }
        }

        /// <summary>
        /// N:1 ImportFile_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ImportFile_BulkDeleteFailures")]
        public ImportFile ImportFile_BulkDeleteFailures
        {
            get { return this.GetRelatedEntity<ImportFile>("ImportFile_BulkDeleteFailures", null); }
        }

        /// <summary>
        /// N:1 ImportLog_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ImportLog_BulkDeleteFailures")]
        public ImportLog ImportLog_BulkDeleteFailures
        {
            get { return this.GetRelatedEntity<ImportLog>("ImportLog_BulkDeleteFailures", null); }
        }

        /// <summary>
        /// N:1 ImportMap_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ImportMap_BulkDeleteFailures")]
        public ImportMap ImportMap_BulkDeleteFailures
        {
            get { return this.GetRelatedEntity<ImportMap>("ImportMap_BulkDeleteFailures", null); }
        }

        /// <summary>
        /// N:1 Incident_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Incident_BulkDeleteFailures")]
        public Incident Incident_BulkDeleteFailures
        {
            get { return this.GetRelatedEntity<Incident>("Incident_BulkDeleteFailures", null); }
        }

        /// <summary>
        /// N:1 IncidentResolution_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("IncidentResolution_BulkDeleteFailures")]
        public IncidentResolution IncidentResolution_BulkDeleteFailures
        {
            get { return this.GetRelatedEntity<IncidentResolution>("IncidentResolution_BulkDeleteFailures", null); }
        }

        /// <summary>
        /// N:1 Invoice_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Invoice_BulkDeleteFailures")]
        public Invoice Invoice_BulkDeleteFailures
        {
            get { return this.GetRelatedEntity<Invoice>("Invoice_BulkDeleteFailures", null); }
        }

        /// <summary>
        /// N:1 InvoiceDetail_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("InvoiceDetail_BulkDeleteFailures")]
        public InvoiceDetail InvoiceDetail_BulkDeleteFailures
        {
            get { return this.GetRelatedEntity<InvoiceDetail>("InvoiceDetail_BulkDeleteFailures", null); }
        }

        /// <summary>
        /// N:1 IsvConfig_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("IsvConfig_BulkDeleteFailures")]
        public IsvConfig IsvConfig_BulkDeleteFailures
        {
            get { return this.GetRelatedEntity<IsvConfig>("IsvConfig_BulkDeleteFailures", null); }
        }

        /// <summary>
        /// N:1 KbArticle_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("KbArticle_BulkDeleteFailures")]
        public KbArticle KbArticle_BulkDeleteFailures
        {
            get { return this.GetRelatedEntity<KbArticle>("KbArticle_BulkDeleteFailures", null); }
        }

        /// <summary>
        /// N:1 KbArticleComment_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("KbArticleComment_BulkDeleteFailures")]
        public KbArticleComment KbArticleComment_BulkDeleteFailures
        {
            get { return this.GetRelatedEntity<KbArticleComment>("KbArticleComment_BulkDeleteFailures", null); }
        }

        /// <summary>
        /// N:1 KbArticleTemplate_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("KbArticleTemplate_BulkDeleteFailures")]
        public KbArticleTemplate KbArticleTemplate_BulkDeleteFailures
        {
            get { return this.GetRelatedEntity<KbArticleTemplate>("KbArticleTemplate_BulkDeleteFailures", null); }
        }

        /// <summary>
        /// N:1 Lead_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Lead_BulkDeleteFailures")]
        public Lead Lead_BulkDeleteFailures
        {
            get { return this.GetRelatedEntity<Lead>("Lead_BulkDeleteFailures", null); }
        }

        /// <summary>
        /// N:1 Letter_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Letter_BulkDeleteFailures")]
        public Letter Letter_BulkDeleteFailures
        {
            get { return this.GetRelatedEntity<Letter>("Letter_BulkDeleteFailures", null); }
        }

        /// <summary>
        /// N:1 List_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("List_BulkDeleteFailures")]
        public List List_BulkDeleteFailures
        {
            get { return this.GetRelatedEntity<List>("List_BulkDeleteFailures", null); }
        }

        /// <summary>
        /// N:1 MonthlyFiscalCalendar_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("MonthlyFiscalCalendar_BulkDeleteFailures")]
        public MonthlyFiscalCalendar MonthlyFiscalCalendar_BulkDeleteFailures
        {
            get { return this.GetRelatedEntity<MonthlyFiscalCalendar>("MonthlyFiscalCalendar_BulkDeleteFailures", null); }
        }

        /// <summary>
        /// N:1 msdyn_postalbum_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_postalbum_BulkDeleteFailures")]
        public msdyn_PostAlbum msdyn_postalbum_BulkDeleteFailures
        {
            get { return this.GetRelatedEntity<msdyn_PostAlbum>("msdyn_postalbum_BulkDeleteFailures", null); }
        }

        /// <summary>
        /// N:1 msdyn_postconfig_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_postconfig_BulkDeleteFailures")]
        public msdyn_PostConfig msdyn_postconfig_BulkDeleteFailures
        {
            get { return this.GetRelatedEntity<msdyn_PostConfig>("msdyn_postconfig_BulkDeleteFailures", null); }
        }

        /// <summary>
        /// N:1 msdyn_postruleconfig_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_postruleconfig_BulkDeleteFailures")]
        public msdyn_PostRuleConfig msdyn_postruleconfig_BulkDeleteFailures
        {
            get { return this.GetRelatedEntity<msdyn_PostRuleConfig>("msdyn_postruleconfig_BulkDeleteFailures", null); }
        }

        /// <summary>
        /// N:1 msdyn_wallsavedquery_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_wallsavedquery_BulkDeleteFailures")]
        public msdyn_wallsavedquery msdyn_wallsavedquery_BulkDeleteFailures
        {
            get { return this.GetRelatedEntity<msdyn_wallsavedquery>("msdyn_wallsavedquery_BulkDeleteFailures", null); }
        }

        /// <summary>
        /// N:1 msdyn_wallsavedqueryusersettings_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_wallsavedqueryusersettings_BulkDeleteFailures")]
        public msdyn_wallsavedqueryusersettings msdyn_wallsavedqueryusersettings_BulkDeleteFailures
        {
            get { return this.GetRelatedEntity<msdyn_wallsavedqueryusersettings>("msdyn_wallsavedqueryusersettings_BulkDeleteFailures", null); }
        }

        /// <summary>
        /// N:1 Opportunity_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Opportunity_BulkDeleteFailures")]
        public Opportunity Opportunity_BulkDeleteFailures
        {
            get { return this.GetRelatedEntity<Opportunity>("Opportunity_BulkDeleteFailures", null); }
        }

        /// <summary>
        /// N:1 OpportunityClose_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("OpportunityClose_BulkDeleteFailures")]
        public OpportunityClose OpportunityClose_BulkDeleteFailures
        {
            get { return this.GetRelatedEntity<OpportunityClose>("OpportunityClose_BulkDeleteFailures", null); }
        }

        /// <summary>
        /// N:1 OpportunityProduct_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("OpportunityProduct_BulkDeleteFailures")]
        public OpportunityProduct OpportunityProduct_BulkDeleteFailures
        {
            get { return this.GetRelatedEntity<OpportunityProduct>("OpportunityProduct_BulkDeleteFailures", null); }
        }

        /// <summary>
        /// N:1 OrderClose_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("OrderClose_BulkDeleteFailures")]
        public OrderClose OrderClose_BulkDeleteFailures
        {
            get { return this.GetRelatedEntity<OrderClose>("OrderClose_BulkDeleteFailures", null); }
        }

        /// <summary>
        /// N:1 Organization_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Organization_BulkDeleteFailures")]
        public Organization Organization_BulkDeleteFailures
        {
            get { return this.GetRelatedEntity<Organization>("Organization_BulkDeleteFailures", null); }
        }

        /// <summary>
        /// N:1 PhoneCall_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("PhoneCall_BulkDeleteFailures")]
        public PhoneCall PhoneCall_BulkDeleteFailures
        {
            get { return this.GetRelatedEntity<PhoneCall>("PhoneCall_BulkDeleteFailures", null); }
        }

        /// <summary>
        /// N:1 post_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("post_BulkDeleteFailures")]
        public Post post_BulkDeleteFailures
        {
            get { return this.GetRelatedEntity<Post>("post_BulkDeleteFailures", null); }
        }

        /// <summary>
        /// N:1 PriceLevel_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("PriceLevel_BulkDeleteFailures")]
        public PriceLevel PriceLevel_BulkDeleteFailures
        {
            get { return this.GetRelatedEntity<PriceLevel>("PriceLevel_BulkDeleteFailures", null); }
        }

        /// <summary>
        /// N:1 Privilege_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Privilege_BulkDeleteFailures")]
        public Privilege Privilege_BulkDeleteFailures
        {
            get { return this.GetRelatedEntity<Privilege>("Privilege_BulkDeleteFailures", null); }
        }

        /// <summary>
        /// N:1 Product_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Product_BulkDeleteFailures")]
        public Product Product_BulkDeleteFailures
        {
            get { return this.GetRelatedEntity<Product>("Product_BulkDeleteFailures", null); }
        }

        /// <summary>
        /// N:1 ProductPriceLevel_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ProductPriceLevel_BulkDeleteFailures")]
        public ProductPriceLevel ProductPriceLevel_BulkDeleteFailures
        {
            get { return this.GetRelatedEntity<ProductPriceLevel>("ProductPriceLevel_BulkDeleteFailures", null); }
        }

        /// <summary>
        /// N:1 ProductSubstitute_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ProductSubstitute_BulkDeleteFailures")]
        public ProductSubstitute ProductSubstitute_BulkDeleteFailures
        {
            get { return this.GetRelatedEntity<ProductSubstitute>("ProductSubstitute_BulkDeleteFailures", null); }
        }

        /// <summary>
        /// N:1 QuarterlyFiscalCalendar_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("QuarterlyFiscalCalendar_BulkDeleteFailures")]
        public QuarterlyFiscalCalendar QuarterlyFiscalCalendar_BulkDeleteFailures
        {
            get { return this.GetRelatedEntity<QuarterlyFiscalCalendar>("QuarterlyFiscalCalendar_BulkDeleteFailures", null); }
        }

        /// <summary>
        /// N:1 Queue_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Queue_BulkDeleteFailures")]
        public Queue Queue_BulkDeleteFailures
        {
            get { return this.GetRelatedEntity<Queue>("Queue_BulkDeleteFailures", null); }
        }

        /// <summary>
        /// N:1 QueueItem_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("QueueItem_BulkDeleteFailures")]
        public QueueItem QueueItem_BulkDeleteFailures
        {
            get { return this.GetRelatedEntity<QueueItem>("QueueItem_BulkDeleteFailures", null); }
        }

        /// <summary>
        /// N:1 Quote_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Quote_BulkDeleteFailures")]
        public Quote Quote_BulkDeleteFailures
        {
            get { return this.GetRelatedEntity<Quote>("Quote_BulkDeleteFailures", null); }
        }

        /// <summary>
        /// N:1 QuoteClose_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("QuoteClose_BulkDeleteFailures")]
        public QuoteClose QuoteClose_BulkDeleteFailures
        {
            get { return this.GetRelatedEntity<QuoteClose>("QuoteClose_BulkDeleteFailures", null); }
        }

        /// <summary>
        /// N:1 QuoteDetail_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("QuoteDetail_BulkDeleteFailures")]
        public QuoteDetail QuoteDetail_BulkDeleteFailures
        {
            get { return this.GetRelatedEntity<QuoteDetail>("QuoteDetail_BulkDeleteFailures", null); }
        }

        /// <summary>
        /// N:1 RecurringAppointmentMaster_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("RecurringAppointmentMaster_BulkDeleteFailures")]
        public RecurringAppointmentMaster RecurringAppointmentMaster_BulkDeleteFailures
        {
            get { return this.GetRelatedEntity<RecurringAppointmentMaster>("RecurringAppointmentMaster_BulkDeleteFailures", null); }
        }

        /// <summary>
        /// N:1 RelationshipRole_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("RelationshipRole_BulkDeleteFailures")]
        public RelationshipRole RelationshipRole_BulkDeleteFailures
        {
            get { return this.GetRelatedEntity<RelationshipRole>("RelationshipRole_BulkDeleteFailures", null); }
        }

        /// <summary>
        /// N:1 RelationshipRoleMap_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("RelationshipRoleMap_BulkDeleteFailures")]
        public RelationshipRoleMap RelationshipRoleMap_BulkDeleteFailures
        {
            get { return this.GetRelatedEntity<RelationshipRoleMap>("RelationshipRoleMap_BulkDeleteFailures", null); }
        }

        /// <summary>
        /// N:1 Resource_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Resource_BulkDeleteFailures")]
        public Resource Resource_BulkDeleteFailures
        {
            get { return this.GetRelatedEntity<Resource>("Resource_BulkDeleteFailures", null); }
        }

        /// <summary>
        /// N:1 ResourceGroup_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ResourceGroup_BulkDeleteFailures")]
        public ResourceGroup ResourceGroup_BulkDeleteFailures
        {
            get { return this.GetRelatedEntity<ResourceGroup>("ResourceGroup_BulkDeleteFailures", null); }
        }

        /// <summary>
        /// N:1 ResourceSpec_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ResourceSpec_BulkDeleteFailures")]
        public ResourceSpec ResourceSpec_BulkDeleteFailures
        {
            get { return this.GetRelatedEntity<ResourceSpec>("ResourceSpec_BulkDeleteFailures", null); }
        }

        /// <summary>
        /// N:1 Role_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Role_BulkDeleteFailures")]
        public Role Role_BulkDeleteFailures
        {
            get { return this.GetRelatedEntity<Role>("Role_BulkDeleteFailures", null); }
        }

        /// <summary>
        /// N:1 routingrule_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("routingrule_BulkDeleteFailures")]
        public RoutingRule routingrule_BulkDeleteFailures
        {
            get { return this.GetRelatedEntity<RoutingRule>("routingrule_BulkDeleteFailures", null); }
        }

        /// <summary>
        /// N:1 routingruleitem_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("routingruleitem_BulkDeleteFailures")]
        public RoutingRuleItem routingruleitem_BulkDeleteFailures
        {
            get { return this.GetRelatedEntity<RoutingRuleItem>("routingruleitem_BulkDeleteFailures", null); }
        }

        /// <summary>
        /// N:1 SalesLiterature_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SalesLiterature_BulkDeleteFailures")]
        public SalesLiterature SalesLiterature_BulkDeleteFailures
        {
            get { return this.GetRelatedEntity<SalesLiterature>("SalesLiterature_BulkDeleteFailures", null); }
        }

        /// <summary>
        /// N:1 SalesLiteratureItem_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SalesLiteratureItem_BulkDeleteFailures")]
        public SalesLiteratureItem SalesLiteratureItem_BulkDeleteFailures
        {
            get { return this.GetRelatedEntity<SalesLiteratureItem>("SalesLiteratureItem_BulkDeleteFailures", null); }
        }

        /// <summary>
        /// N:1 SalesOrder_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SalesOrder_BulkDeleteFailures")]
        public SalesOrder SalesOrder_BulkDeleteFailures
        {
            get { return this.GetRelatedEntity<SalesOrder>("SalesOrder_BulkDeleteFailures", null); }
        }

        /// <summary>
        /// N:1 SalesOrderDetail_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SalesOrderDetail_BulkDeleteFailures")]
        public SalesOrderDetail SalesOrderDetail_BulkDeleteFailures
        {
            get { return this.GetRelatedEntity<SalesOrderDetail>("SalesOrderDetail_BulkDeleteFailures", null); }
        }

        /// <summary>
        /// N:1 SavedQuery_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SavedQuery_BulkDeleteFailures")]
        public SavedQuery SavedQuery_BulkDeleteFailures
        {
            get { return this.GetRelatedEntity<SavedQuery>("SavedQuery_BulkDeleteFailures", null); }
        }

        /// <summary>
        /// N:1 SemiAnnualFiscalCalendar_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SemiAnnualFiscalCalendar_BulkDeleteFailures")]
        public SemiAnnualFiscalCalendar SemiAnnualFiscalCalendar_BulkDeleteFailures
        {
            get { return this.GetRelatedEntity<SemiAnnualFiscalCalendar>("SemiAnnualFiscalCalendar_BulkDeleteFailures", null); }
        }

        /// <summary>
        /// N:1 Service_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Service_BulkDeleteFailures")]
        public Service Service_BulkDeleteFailures
        {
            get { return this.GetRelatedEntity<Service>("Service_BulkDeleteFailures", null); }
        }

        /// <summary>
        /// N:1 ServiceAppointment_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ServiceAppointment_BulkDeleteFailures")]
        public ServiceAppointment ServiceAppointment_BulkDeleteFailures
        {
            get { return this.GetRelatedEntity<ServiceAppointment>("ServiceAppointment_BulkDeleteFailures", null); }
        }

        /// <summary>
        /// N:1 Site_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Site_BulkDeleteFailures")]
        public Site Site_BulkDeleteFailures
        {
            get { return this.GetRelatedEntity<Site>("Site_BulkDeleteFailures", null); }
        }

        /// <summary>
        /// N:1 slabase_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("slabase_BulkDeleteFailures")]
        public SLA slabase_BulkDeleteFailures
        {
            get { return this.GetRelatedEntity<SLA>("slabase_BulkDeleteFailures", null); }
        }

        /// <summary>
        /// N:1 SocialActivity_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SocialActivity_BulkDeleteFailures")]
        public SocialActivity SocialActivity_BulkDeleteFailures
        {
            get { return this.GetRelatedEntity<SocialActivity>("SocialActivity_BulkDeleteFailures", null); }
        }

        /// <summary>
        /// N:1 Subject_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Subject_BulkDeleteFailures")]
        public Subject Subject_BulkDeleteFailures
        {
            get { return this.GetRelatedEntity<Subject>("Subject_BulkDeleteFailures", null); }
        }

        /// <summary>
        /// N:1 SystemForm_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SystemForm_BulkDeleteFailures")]
        public SystemForm SystemForm_BulkDeleteFailures
        {
            get { return this.GetRelatedEntity<SystemForm>("SystemForm_BulkDeleteFailures", null); }
        }

        /// <summary>
        /// N:1 SystemUser_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SystemUser_BulkDeleteFailures")]
        public SystemUser SystemUser_BulkDeleteFailures
        {
            get { return this.GetRelatedEntity<SystemUser>("SystemUser_BulkDeleteFailures", null); }
        }

        /// <summary>
        /// N:1 Task_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Task_BulkDeleteFailures")]
        public Task Task_BulkDeleteFailures
        {
            get { return this.GetRelatedEntity<Task>("Task_BulkDeleteFailures", null); }
        }

        /// <summary>
        /// N:1 Team_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Team_BulkDeleteFailures")]
        public Team Team_BulkDeleteFailures
        {
            get { return this.GetRelatedEntity<Team>("Team_BulkDeleteFailures", null); }
        }

        /// <summary>
        /// N:1 Template_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Template_BulkDeleteFailures")]
        public Template Template_BulkDeleteFailures
        {
            get { return this.GetRelatedEntity<Template>("Template_BulkDeleteFailures", null); }
        }

        /// <summary>
        /// N:1 Territory_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Territory_BulkDeleteFailures")]
        public Territory Territory_BulkDeleteFailures
        {
            get { return this.GetRelatedEntity<Territory>("Territory_BulkDeleteFailures", null); }
        }

        /// <summary>
        /// N:1 UoM_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("UoM_BulkDeleteFailures")]
        public UoM UoM_BulkDeleteFailures
        {
            get { return this.GetRelatedEntity<UoM>("UoM_BulkDeleteFailures", null); }
        }

        /// <summary>
        /// N:1 UoMSchedule_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("UoMSchedule_BulkDeleteFailures")]
        public UoMSchedule UoMSchedule_BulkDeleteFailures
        {
            get { return this.GetRelatedEntity<UoMSchedule>("UoMSchedule_BulkDeleteFailures", null); }
        }

        /// <summary>
        /// N:1 UserForm_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("UserForm_BulkDeleteFailures")]
        public UserForm UserForm_BulkDeleteFailures
        {
            get { return this.GetRelatedEntity<UserForm>("UserForm_BulkDeleteFailures", null); }
        }

        /// <summary>
        /// N:1 UserQuery_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("UserQuery_BulkDeleteFailures")]
        public UserQuery UserQuery_BulkDeleteFailures
        {
            get { return this.GetRelatedEntity<UserQuery>("UserQuery_BulkDeleteFailures", null); }
        }
    }
}