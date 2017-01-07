namespace __4_DAL_CRM
{
    /// <summary>
    /// Storage of sales literature, which may contain one or more documents.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("salesliterature")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class SalesLiterature : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public SalesLiterature() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "salesliterature";

        public const int EntityTypeCode = 1038;

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
        /// Type additional information to describe the sales literature, such as the intended audience or primary messages.
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
        /// Choose the user who is responsible for maintaining or updating the sales literature.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("employeecontactid")]
        public Microsoft.Xrm.Sdk.EntityReference EmployeeContactId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("employeecontactid"); }
            set
            {
                this.OnPropertyChanging("EmployeeContactId");
                this.SetAttributeValue("employeecontactid", value);
                this.OnPropertyChanged("EmployeeContactId");
            }
        }

        /// <summary>
        /// The default image for the entity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entityimage")]
        public byte[] EntityImage
        {
            get { return this.GetAttributeValue<byte[]>("entityimage"); }
            set
            {
                this.OnPropertyChanging("EntityImage");
                this.SetAttributeValue("entityimage", value);
                this.OnPropertyChanged("EntityImage");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entityimage_timestamp")]
        public System.Nullable<long> EntityImage_Timestamp
        {
            get { return this.GetAttributeValue<System.Nullable<long>>("entityimage_timestamp"); }
        }

        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entityimage_url")]
        public string EntityImage_URL
        {
            get { return this.GetAttributeValue<string>("entityimage_url"); }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entityimageid")]
        public System.Nullable<System.Guid> EntityImageId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("entityimageid"); }
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
        /// Enter the expiration date or last day the sales literature can be distributed.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("expirationdate")]
        public System.Nullable<System.DateTime> ExpirationDate
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("expirationdate"); }
            set
            {
                this.OnPropertyChanging("ExpirationDate");
                this.SetAttributeValue("expirationdate", value);
                this.OnPropertyChanged("ExpirationDate");
            }
        }

        /// <summary>
        /// Tells whether the sales literature has one or more attachments.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("hasattachments")]
        public System.Nullable<bool> HasAttachments
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("hasattachments"); }
            set
            {
                this.OnPropertyChanging("HasAttachments");
                this.SetAttributeValue("hasattachments", value);
                this.OnPropertyChanged("HasAttachments");
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
        /// Select whether the sales literature can be distributed to prospects and customers or is for internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("iscustomerviewable")]
        public System.Nullable<bool> IsCustomerViewable
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("iscustomerviewable"); }
            set
            {
                this.OnPropertyChanging("IsCustomerViewable");
                this.SetAttributeValue("iscustomerviewable", value);
                this.OnPropertyChanged("IsCustomerViewable");
            }
        }

        /// <summary>
        /// Type one or more topics or keywords that can be used to search for the sales literature.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("keywords")]
        public string KeyWords
        {
            get { return this.GetAttributeValue<string>("keywords"); }
            set
            {
                this.OnPropertyChanging("KeyWords");
                this.SetAttributeValue("keywords", value);
                this.OnPropertyChanged("KeyWords");
            }
        }

        /// <summary>
        /// Select a category or type to help others identify the intended use of the sales literature.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("literaturetypecode")]
        public Microsoft.Xrm.Sdk.OptionSetValue LiteratureTypeCode
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("literaturetypecode"); }
            set
            {
                this.OnPropertyChanging("LiteratureTypeCode");
                this.SetAttributeValue("literaturetypecode", value);
                this.OnPropertyChanged("LiteratureTypeCode");
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
        /// Type a descriptive title for the sales literature.
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
        /// Choose the ID of the organization that the record is associated with.
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
        /// Shows the ID of the process.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("processid")]
        public System.Nullable<System.Guid> ProcessId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("processid"); }
            set
            {
                this.OnPropertyChanging("ProcessId");
                this.SetAttributeValue("processid", value);
                this.OnPropertyChanged("ProcessId");
            }
        }

        /// <summary>
        /// Unique identifier of the sales literature.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("salesliteratureid")]
        public System.Nullable<System.Guid> SalesLiteratureId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("salesliteratureid"); }
            set
            {
                this.OnPropertyChanging("SalesLiteratureId");
                this.SetAttributeValue("salesliteratureid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("SalesLiteratureId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("salesliteratureid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.SalesLiteratureId = value; }
        }

        /// <summary>
        /// Shows the ID of the stage.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("stageid")]
        public System.Nullable<System.Guid> StageId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("stageid"); }
            set
            {
                this.OnPropertyChanging("StageId");
                this.SetAttributeValue("stageid", value);
                this.OnPropertyChanged("StageId");
            }
        }

        /// <summary>
        /// Choose the subject for the sales literature to relate the item to a product or business group. Administrators can configure subjects under Business Management in the Settings area.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("subjectid")]
        public Microsoft.Xrm.Sdk.EntityReference SubjectId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("subjectid"); }
            set
            {
                this.OnPropertyChanging("SubjectId");
                this.SetAttributeValue("subjectid", value);
                this.OnPropertyChanged("SubjectId");
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
        /// A comma separated list of string values representing the unique identifiers of stages in a Business Process Flow Instance in the order that they occur.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("traversedpath")]
        public string TraversedPath
        {
            get { return this.GetAttributeValue<string>("traversedpath"); }
            set
            {
                this.OnPropertyChanging("TraversedPath");
                this.SetAttributeValue("traversedpath", value);
                this.OnPropertyChanged("TraversedPath");
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
        /// Version number of the sales literature.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
        public System.Nullable<long> VersionNumber
        {
            get { return this.GetAttributeValue<System.Nullable<long>>("versionnumber"); }
        }

        /// <summary>
        /// 1:N sales_literature_items
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("sales_literature_items")]
        public System.Collections.Generic.IEnumerable<SalesLiteratureItem> sales_literature_items
        {
            get { return this.GetRelatedEntities<SalesLiteratureItem>("sales_literature_items", null); }
            set
            {
                this.OnPropertyChanging("sales_literature_items");
                this.SetRelatedEntities<SalesLiteratureItem>("sales_literature_items", null, value);
                this.OnPropertyChanged("sales_literature_items");
            }
        }

        /// <summary>
        /// 1:N SalesLiterature_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SalesLiterature_AsyncOperations")]
        public System.Collections.Generic.IEnumerable<AsyncOperation> SalesLiterature_AsyncOperations
        {
            get { return this.GetRelatedEntities<AsyncOperation>("SalesLiterature_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("SalesLiterature_AsyncOperations");
                this.SetRelatedEntities<AsyncOperation>("SalesLiterature_AsyncOperations", null, value);
                this.OnPropertyChanged("SalesLiterature_AsyncOperations");
            }
        }

        /// <summary>
        /// 1:N SalesLiterature_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SalesLiterature_BulkDeleteFailures")]
        public System.Collections.Generic.IEnumerable<BulkDeleteFailure> SalesLiterature_BulkDeleteFailures
        {
            get { return this.GetRelatedEntities<BulkDeleteFailure>("SalesLiterature_BulkDeleteFailures", null); }
            set
            {
                this.OnPropertyChanging("SalesLiterature_BulkDeleteFailures");
                this.SetRelatedEntities<BulkDeleteFailure>("SalesLiterature_BulkDeleteFailures", null, value);
                this.OnPropertyChanged("SalesLiterature_BulkDeleteFailures");
            }
        }

        /// <summary>
        /// 1:N salesliterature_principalobjectattributeaccess
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("salesliterature_principalobjectattributeaccess")]
        public System.Collections.Generic.IEnumerable<PrincipalObjectAttributeAccess> salesliterature_principalobjectattributeaccess
        {
            get { return this.GetRelatedEntities<PrincipalObjectAttributeAccess>("salesliterature_principalobjectattributeaccess", null); }
            set
            {
                this.OnPropertyChanging("salesliterature_principalobjectattributeaccess");
                this.SetRelatedEntities<PrincipalObjectAttributeAccess>("salesliterature_principalobjectattributeaccess", null, value);
                this.OnPropertyChanged("salesliterature_principalobjectattributeaccess");
            }
        }

        /// <summary>
        /// 1:N SalesLiterature_ProcessSessions
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SalesLiterature_ProcessSessions")]
        public System.Collections.Generic.IEnumerable<ProcessSession> SalesLiterature_ProcessSessions
        {
            get { return this.GetRelatedEntities<ProcessSession>("SalesLiterature_ProcessSessions", null); }
            set
            {
                this.OnPropertyChanging("SalesLiterature_ProcessSessions");
                this.SetRelatedEntities<ProcessSession>("SalesLiterature_ProcessSessions", null, value);
                this.OnPropertyChanged("SalesLiterature_ProcessSessions");
            }
        }

        /// <summary>
        /// 1:N SalesLiterature_SharepointDocument
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SalesLiterature_SharepointDocument")]
        public System.Collections.Generic.IEnumerable<SharePointDocument> SalesLiterature_SharepointDocument
        {
            get { return this.GetRelatedEntities<SharePointDocument>("SalesLiterature_SharepointDocument", null); }
            set
            {
                this.OnPropertyChanging("SalesLiterature_SharepointDocument");
                this.SetRelatedEntities<SharePointDocument>("SalesLiterature_SharepointDocument", null, value);
                this.OnPropertyChanged("SalesLiterature_SharepointDocument");
            }
        }

        /// <summary>
        /// 1:N SalesLiterature_SharepointDocumentLocation
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SalesLiterature_SharepointDocumentLocation")]
        public System.Collections.Generic.IEnumerable<SharePointDocumentLocation> SalesLiterature_SharepointDocumentLocation
        {
            get { return this.GetRelatedEntities<SharePointDocumentLocation>("SalesLiterature_SharepointDocumentLocation", null); }
            set
            {
                this.OnPropertyChanging("SalesLiterature_SharepointDocumentLocation");
                this.SetRelatedEntities<SharePointDocumentLocation>("SalesLiterature_SharepointDocumentLocation", null, value);
                this.OnPropertyChanged("SalesLiterature_SharepointDocumentLocation");
            }
        }

        /// <summary>
        /// 1:N userentityinstancedata_salesliterature
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_salesliterature")]
        public System.Collections.Generic.IEnumerable<UserEntityInstanceData> userentityinstancedata_salesliterature
        {
            get { return this.GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_salesliterature", null); }
            set
            {
                this.OnPropertyChanging("userentityinstancedata_salesliterature");
                this.SetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_salesliterature", null, value);
                this.OnPropertyChanged("userentityinstancedata_salesliterature");
            }
        }

        /// <summary>
        /// N:N campaignactivitysalesliterature_association
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("campaignactivitysalesliterature_association")]
        public System.Collections.Generic.IEnumerable<CampaignActivity> campaignactivitysalesliterature_association
        {
            get { return this.GetRelatedEntities<CampaignActivity>("campaignactivitysalesliterature_association", null); }
            set
            {
                this.OnPropertyChanging("campaignactivitysalesliterature_association");
                this.SetRelatedEntities<CampaignActivity>("campaignactivitysalesliterature_association", null, value);
                this.OnPropertyChanged("campaignactivitysalesliterature_association");
            }
        }

        /// <summary>
        /// N:N campaignsalesliterature_association
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("campaignsalesliterature_association")]
        public System.Collections.Generic.IEnumerable<Campaign> campaignsalesliterature_association
        {
            get { return this.GetRelatedEntities<Campaign>("campaignsalesliterature_association", null); }
            set
            {
                this.OnPropertyChanging("campaignsalesliterature_association");
                this.SetRelatedEntities<Campaign>("campaignsalesliterature_association", null, value);
                this.OnPropertyChanged("campaignsalesliterature_association");
            }
        }

        /// <summary>
        /// N:N competitorsalesliterature_association
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("competitorsalesliterature_association")]
        public System.Collections.Generic.IEnumerable<Competitor> competitorsalesliterature_association
        {
            get { return this.GetRelatedEntities<Competitor>("competitorsalesliterature_association", null); }
            set
            {
                this.OnPropertyChanging("competitorsalesliterature_association");
                this.SetRelatedEntities<Competitor>("competitorsalesliterature_association", null, value);
                this.OnPropertyChanged("competitorsalesliterature_association");
            }
        }

        /// <summary>
        /// N:N productsalesliterature_association
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("productsalesliterature_association")]
        public System.Collections.Generic.IEnumerable<Product> productsalesliterature_association
        {
            get { return this.GetRelatedEntities<Product>("productsalesliterature_association", null); }
            set
            {
                this.OnPropertyChanging("productsalesliterature_association");
                this.SetRelatedEntities<Product>("productsalesliterature_association", null, value);
                this.OnPropertyChanged("productsalesliterature_association");
            }
        }

        /// <summary>
        /// N:1 lk_salesliterature_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_salesliterature_createdonbehalfby")]
        public SystemUser lk_salesliterature_createdonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_salesliterature_createdonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_salesliterature_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_salesliterature_modifiedonbehalfby")]
        public SystemUser lk_salesliterature_modifiedonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_salesliterature_modifiedonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_salesliteraturebase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_salesliteraturebase_createdby")]
        public SystemUser lk_salesliteraturebase_createdby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_salesliteraturebase_createdby", null); }
        }

        /// <summary>
        /// N:1 lk_salesliteraturebase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_salesliteraturebase_modifiedby")]
        public SystemUser lk_salesliteraturebase_modifiedby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_salesliteraturebase_modifiedby", null); }
        }

        /// <summary>
        /// N:1 organization_sales_literature
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_sales_literature")]
        public Organization organization_sales_literature
        {
            get { return this.GetRelatedEntity<Organization>("organization_sales_literature", null); }
        }

        /// <summary>
        /// N:1 processstage_salesliteratures
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("stageid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("processstage_salesliteratures")]
        public ProcessStage processstage_salesliteratures
        {
            get { return this.GetRelatedEntity<ProcessStage>("processstage_salesliteratures", null); }
            set
            {
                this.OnPropertyChanging("processstage_salesliteratures");
                this.SetRelatedEntity<ProcessStage>("processstage_salesliteratures", null, value);
                this.OnPropertyChanged("processstage_salesliteratures");
            }
        }

        /// <summary>
        /// N:1 subject_sales_literature
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("subjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("subject_sales_literature")]
        public Subject subject_sales_literature
        {
            get { return this.GetRelatedEntity<Subject>("subject_sales_literature", null); }
            set
            {
                this.OnPropertyChanging("subject_sales_literature");
                this.SetRelatedEntity<Subject>("subject_sales_literature", null, value);
                this.OnPropertyChanged("subject_sales_literature");
            }
        }

        /// <summary>
        /// N:1 system_user_sales_literature
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("employeecontactid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("system_user_sales_literature")]
        public SystemUser system_user_sales_literature
        {
            get { return this.GetRelatedEntity<SystemUser>("system_user_sales_literature", null); }
            set
            {
                this.OnPropertyChanging("system_user_sales_literature");
                this.SetRelatedEntity<SystemUser>("system_user_sales_literature", null, value);
                this.OnPropertyChanged("system_user_sales_literature");
            }
        }

        /// <summary>
        /// N:1 TransactionCurrency_SalesLiterature
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("TransactionCurrency_SalesLiterature")]
        public TransactionCurrency TransactionCurrency_SalesLiterature
        {
            get { return this.GetRelatedEntity<TransactionCurrency>("TransactionCurrency_SalesLiterature", null); }
            set
            {
                this.OnPropertyChanging("TransactionCurrency_SalesLiterature");
                this.SetRelatedEntity<TransactionCurrency>("TransactionCurrency_SalesLiterature", null, value);
                this.OnPropertyChanged("TransactionCurrency_SalesLiterature");
            }
        }
    }
}