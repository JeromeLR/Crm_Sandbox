using _4_DAL_CRM;

namespace __4_DAL_CRM
{
    /// <summary>
    /// Document libraries or folders on a SharePoint server from where documents can be managed in Microsoft Dynamics CRM.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("sharepointdocumentlocation")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class SharePointDocumentLocation : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public SharePointDocumentLocation() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "sharepointdocumentlocation";

        public const int EntityTypeCode = 9508;

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
        /// Absolute URL of the SharePoint document location.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("absoluteurl")]
        public string AbsoluteURL
        {
            get { return this.GetAttributeValue<string>("absoluteurl"); }
            set
            {
                this.OnPropertyChanging("AbsoluteURL");
                this.SetAttributeValue("absoluteurl", value);
                this.OnPropertyChanged("AbsoluteURL");
            }
        }

        /// <summary>
        /// Unique identifier of the user who created the SharePoint document location record.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby"); }
        }

        /// <summary>
        /// Date and time when the SharePoint document location record was created.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
        public System.Nullable<System.DateTime> CreatedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who created the SharePoint document location record.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        /// Description of the SharePoint document location record.
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
        /// Exchange rate between the currency associated with the SharePoint document location record and the base currency.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("exchangerate")]
        public System.Nullable<decimal> ExchangeRate
        {
            get { return this.GetAttributeValue<System.Nullable<decimal>>("exchangerate"); }
        }

        /// <summary>
        /// Sequence number of the import that created the SharePoint document location record.
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
        /// Unique identifier of the user who last modified the SharePoint document location record.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby"); }
        }

        /// <summary>
        /// Date and time when the SharePoint document location record was last modified.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
        public System.Nullable<System.DateTime> ModifiedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who modified the SharePoint document location record.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        /// Name of the SharePoint document location record.
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
        /// Unique identifier of the user or team who owns the SharePoint document location record.
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
        /// Unique identifier of the business unit that owns the SharePoint document location record.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
        public Microsoft.Xrm.Sdk.EntityReference OwningBusinessUnit
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningbusinessunit"); }
        }

        /// <summary>
        /// Unique identifier of the team who owns the SharePoint document location record.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
        public Microsoft.Xrm.Sdk.EntityReference OwningTeam
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningteam"); }
        }

        /// <summary>
        /// Unique identifier of the user who owns the SharePoint document location record.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
        public Microsoft.Xrm.Sdk.EntityReference OwningUser
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owninguser"); }
        }

        /// <summary>
        /// Unique identifier of the parent site or location.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("parentsiteorlocation")]
        public Microsoft.Xrm.Sdk.EntityReference ParentSiteOrLocation
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("parentsiteorlocation"); }
            set
            {
                this.OnPropertyChanging("ParentSiteOrLocation");
                this.SetAttributeValue("parentsiteorlocation", value);
                this.OnPropertyChanged("ParentSiteOrLocation");
            }
        }

        /// <summary>
        /// Unique identifier of the object with which the SharePoint document location record is associated.
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
        /// Relative URL of the SharePoint document location.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("relativeurl")]
        public string RelativeUrl
        {
            get { return this.GetAttributeValue<string>("relativeurl"); }
            set
            {
                this.OnPropertyChanging("RelativeUrl");
                this.SetAttributeValue("relativeurl", value);
                this.OnPropertyChanged("RelativeUrl");
            }
        }

        /// <summary>
        /// Unique identifier of the SharePoint document location record.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sharepointdocumentlocationid")]
        public System.Nullable<System.Guid> SharePointDocumentLocationId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("sharepointdocumentlocationid"); }
            set
            {
                this.OnPropertyChanging("SharePointDocumentLocationId");
                this.SetAttributeValue("sharepointdocumentlocationid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("SharePointDocumentLocationId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sharepointdocumentlocationid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.SharePointDocumentLocationId = value; }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sitecollectionid")]
        public System.Nullable<System.Guid> SiteCollectionId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("sitecollectionid"); }
        }

        /// <summary>
        /// Status of the SharePoint document location record.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
        public System.Nullable<SharePointDocumentLocationState> StateCode
        {
            get
            {
                Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
                if ((optionSet != null))
                {
                    return ((SharePointDocumentLocationState) (System.Enum.ToObject(typeof(SharePointDocumentLocationState), optionSet.Value)));
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// Reason for the status of the SharePoint document location record.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statuscode")]
        public Microsoft.Xrm.Sdk.OptionSetValue StatusCode
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statuscode"); }
            set
            {
                this.OnPropertyChanging("StatusCode");
                this.SetAttributeValue("statuscode", value);
                this.OnPropertyChanged("StatusCode");
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
        /// Unique identifier of the currency associated with the SharePoint document location record.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyid")]
        public Microsoft.Xrm.Sdk.EntityReference TransactionCurrencyId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("transactioncurrencyid"); }
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
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
        public System.Nullable<long> VersionNumber
        {
            get { return this.GetAttributeValue<System.Nullable<long>>("versionnumber"); }
        }

        /// <summary>
        /// 1:N sharepointdata_sharepointdocumentlocation
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("sharepointdata_sharepointdocumentlocation")]
        public System.Collections.Generic.IEnumerable<SharePointData> sharepointdata_sharepointdocumentlocation
        {
            get { return this.GetRelatedEntities<SharePointData>("sharepointdata_sharepointdocumentlocation", null); }
            set
            {
                this.OnPropertyChanging("sharepointdata_sharepointdocumentlocation");
                this.SetRelatedEntities<SharePointData>("sharepointdata_sharepointdocumentlocation", null, value);
                this.OnPropertyChanged("sharepointdata_sharepointdocumentlocation");
            }
        }

        /// <summary>
        /// 1:N SharePointDocumentLocation_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SharePointDocumentLocation_AsyncOperations")]
        public System.Collections.Generic.IEnumerable<AsyncOperation> SharePointDocumentLocation_AsyncOperations
        {
            get { return this.GetRelatedEntities<AsyncOperation>("SharePointDocumentLocation_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("SharePointDocumentLocation_AsyncOperations");
                this.SetRelatedEntities<AsyncOperation>("SharePointDocumentLocation_AsyncOperations", null, value);
                this.OnPropertyChanged("SharePointDocumentLocation_AsyncOperations");
            }
        }

        /// <summary>
        /// 1:N SharePointDocumentLocation_DuplicateBaseRecord
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SharePointDocumentLocation_DuplicateBaseRecord")]
        public System.Collections.Generic.IEnumerable<DuplicateRecord> SharePointDocumentLocation_DuplicateBaseRecord
        {
            get { return this.GetRelatedEntities<DuplicateRecord>("SharePointDocumentLocation_DuplicateBaseRecord", null); }
            set
            {
                this.OnPropertyChanging("SharePointDocumentLocation_DuplicateBaseRecord");
                this.SetRelatedEntities<DuplicateRecord>("SharePointDocumentLocation_DuplicateBaseRecord", null, value);
                this.OnPropertyChanged("SharePointDocumentLocation_DuplicateBaseRecord");
            }
        }

        /// <summary>
        /// 1:N SharePointDocumentLocation_DuplicateMatchingRecord
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SharePointDocumentLocation_DuplicateMatchingRecord")]
        public System.Collections.Generic.IEnumerable<DuplicateRecord> SharePointDocumentLocation_DuplicateMatchingRecord
        {
            get { return this.GetRelatedEntities<DuplicateRecord>("SharePointDocumentLocation_DuplicateMatchingRecord", null); }
            set
            {
                this.OnPropertyChanging("SharePointDocumentLocation_DuplicateMatchingRecord");
                this.SetRelatedEntities<DuplicateRecord>("SharePointDocumentLocation_DuplicateMatchingRecord", null, value);
                this.OnPropertyChanged("SharePointDocumentLocation_DuplicateMatchingRecord");
            }
        }

        /// <summary>
        /// 1:N sharepointdocumentlocation_parent_sharepointdocumentlocation
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("sharepointdocumentlocation_parent_sharepointdocumentlocation", Microsoft.Xrm.Sdk.EntityRole.Referenced)]
        public System.Collections.Generic.IEnumerable<SharePointDocumentLocation> Referencedsharepointdocumentlocation_parent_sharepointdocumentlocation
        {
            get { return this.GetRelatedEntities<SharePointDocumentLocation>("sharepointdocumentlocation_parent_sharepointdocumentlocation", Microsoft.Xrm.Sdk.EntityRole.Referenced); }
            set
            {
                this.OnPropertyChanging("Referencedsharepointdocumentlocation_parent_sharepointdocumentlocation");
                this.SetRelatedEntities<SharePointDocumentLocation>("sharepointdocumentlocation_parent_sharepointdocumentlocation", Microsoft.Xrm.Sdk.EntityRole.Referenced, value);
                this.OnPropertyChanged("Referencedsharepointdocumentlocation_parent_sharepointdocumentlocation");
            }
        }

        /// <summary>
        /// 1:N sharepointdocumentlocation_principalobjectattributeaccess
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("sharepointdocumentlocation_principalobjectattributeaccess")]
        public System.Collections.Generic.IEnumerable<PrincipalObjectAttributeAccess> sharepointdocumentlocation_principalobjectattributeaccess
        {
            get { return this.GetRelatedEntities<PrincipalObjectAttributeAccess>("sharepointdocumentlocation_principalobjectattributeaccess", null); }
            set
            {
                this.OnPropertyChanging("sharepointdocumentlocation_principalobjectattributeaccess");
                this.SetRelatedEntities<PrincipalObjectAttributeAccess>("sharepointdocumentlocation_principalobjectattributeaccess", null, value);
                this.OnPropertyChanged("sharepointdocumentlocation_principalobjectattributeaccess");
            }
        }

        /// <summary>
        /// 1:N SharePointDocumentLocation_ProcessSessions
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SharePointDocumentLocation_ProcessSessions")]
        public System.Collections.Generic.IEnumerable<ProcessSession> SharePointDocumentLocation_ProcessSessions
        {
            get { return this.GetRelatedEntities<ProcessSession>("SharePointDocumentLocation_ProcessSessions", null); }
            set
            {
                this.OnPropertyChanging("SharePointDocumentLocation_ProcessSessions");
                this.SetRelatedEntities<ProcessSession>("SharePointDocumentLocation_ProcessSessions", null, value);
                this.OnPropertyChanged("SharePointDocumentLocation_ProcessSessions");
            }
        }

        /// <summary>
        /// 1:N userentityinstancedata_sharepointdocumentlocation
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_sharepointdocumentlocation")]
        public System.Collections.Generic.IEnumerable<UserEntityInstanceData> userentityinstancedata_sharepointdocumentlocation
        {
            get { return this.GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_sharepointdocumentlocation", null); }
            set
            {
                this.OnPropertyChanging("userentityinstancedata_sharepointdocumentlocation");
                this.SetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_sharepointdocumentlocation", null, value);
                this.OnPropertyChanged("userentityinstancedata_sharepointdocumentlocation");
            }
        }

        /// <summary>
        /// N:1 Account_SharepointDocumentLocation
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Account_SharepointDocumentLocation")]
        public Account Account_SharepointDocumentLocation
        {
            get { return this.GetRelatedEntity<Account>("Account_SharepointDocumentLocation", null); }
            set
            {
                this.OnPropertyChanging("Account_SharepointDocumentLocation");
                this.SetRelatedEntity<Account>("Account_SharepointDocumentLocation", null, value);
                this.OnPropertyChanged("Account_SharepointDocumentLocation");
            }
        }

        /// <summary>
        /// N:1 business_unit_sharepointdocumentlocation
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_sharepointdocumentlocation")]
        public BusinessUnit business_unit_sharepointdocumentlocation
        {
            get { return this.GetRelatedEntity<BusinessUnit>("business_unit_sharepointdocumentlocation", null); }
        }

        /// <summary>
        /// N:1 KbArticle_SharepointDocumentLocation
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("KbArticle_SharepointDocumentLocation")]
        public KbArticle KbArticle_SharepointDocumentLocation
        {
            get { return this.GetRelatedEntity<KbArticle>("KbArticle_SharepointDocumentLocation", null); }
            set
            {
                this.OnPropertyChanging("KbArticle_SharepointDocumentLocation");
                this.SetRelatedEntity<KbArticle>("KbArticle_SharepointDocumentLocation", null, value);
                this.OnPropertyChanged("KbArticle_SharepointDocumentLocation");
            }
        }

        /// <summary>
        /// N:1 Lead_SharepointDocumentLocation
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Lead_SharepointDocumentLocation")]
        public Lead Lead_SharepointDocumentLocation
        {
            get { return this.GetRelatedEntity<Lead>("Lead_SharepointDocumentLocation", null); }
            set
            {
                this.OnPropertyChanging("Lead_SharepointDocumentLocation");
                this.SetRelatedEntity<Lead>("Lead_SharepointDocumentLocation", null, value);
                this.OnPropertyChanged("Lead_SharepointDocumentLocation");
            }
        }

        /// <summary>
        /// N:1 lk_sharepointdocumentlocationbase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_sharepointdocumentlocationbase_createdby")]
        public SystemUser lk_sharepointdocumentlocationbase_createdby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_sharepointdocumentlocationbase_createdby", null); }
        }

        /// <summary>
        /// N:1 lk_sharepointdocumentlocationbase_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_sharepointdocumentlocationbase_createdonbehalfby")]
        public SystemUser lk_sharepointdocumentlocationbase_createdonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_sharepointdocumentlocationbase_createdonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_sharepointdocumentlocationbase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_sharepointdocumentlocationbase_modifiedby")]
        public SystemUser lk_sharepointdocumentlocationbase_modifiedby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_sharepointdocumentlocationbase_modifiedby", null); }
        }

        /// <summary>
        /// N:1 lk_sharepointdocumentlocationbase_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_sharepointdocumentlocationbase_modifiedonbehalfby")]
        public SystemUser lk_sharepointdocumentlocationbase_modifiedonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_sharepointdocumentlocationbase_modifiedonbehalfby", null); }
        }

        /// <summary>
        /// N:1 Opportunity_SharepointDocumentLocation
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Opportunity_SharepointDocumentLocation")]
        public Opportunity Opportunity_SharepointDocumentLocation
        {
            get { return this.GetRelatedEntity<Opportunity>("Opportunity_SharepointDocumentLocation", null); }
            set
            {
                this.OnPropertyChanging("Opportunity_SharepointDocumentLocation");
                this.SetRelatedEntity<Opportunity>("Opportunity_SharepointDocumentLocation", null, value);
                this.OnPropertyChanged("Opportunity_SharepointDocumentLocation");
            }
        }

        /// <summary>
        /// N:1 Product_SharepointDocumentLocation
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Product_SharepointDocumentLocation")]
        public Product Product_SharepointDocumentLocation
        {
            get { return this.GetRelatedEntity<Product>("Product_SharepointDocumentLocation", null); }
            set
            {
                this.OnPropertyChanging("Product_SharepointDocumentLocation");
                this.SetRelatedEntity<Product>("Product_SharepointDocumentLocation", null, value);
                this.OnPropertyChanged("Product_SharepointDocumentLocation");
            }
        }

        /// <summary>
        /// N:1 Quote_SharepointDocumentLocation
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Quote_SharepointDocumentLocation")]
        public Quote Quote_SharepointDocumentLocation
        {
            get { return this.GetRelatedEntity<Quote>("Quote_SharepointDocumentLocation", null); }
            set
            {
                this.OnPropertyChanging("Quote_SharepointDocumentLocation");
                this.SetRelatedEntity<Quote>("Quote_SharepointDocumentLocation", null, value);
                this.OnPropertyChanged("Quote_SharepointDocumentLocation");
            }
        }

        /// <summary>
        /// N:1 SalesLiterature_SharepointDocumentLocation
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SalesLiterature_SharepointDocumentLocation")]
        public SalesLiterature SalesLiterature_SharepointDocumentLocation
        {
            get { return this.GetRelatedEntity<SalesLiterature>("SalesLiterature_SharepointDocumentLocation", null); }
            set
            {
                this.OnPropertyChanging("SalesLiterature_SharepointDocumentLocation");
                this.SetRelatedEntity<SalesLiterature>("SalesLiterature_SharepointDocumentLocation", null, value);
                this.OnPropertyChanged("SalesLiterature_SharepointDocumentLocation");
            }
        }

        /// <summary>
        /// N:1 sharepointdocumentlocation_parent_sharepointdocumentlocation
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("parentsiteorlocation")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("sharepointdocumentlocation_parent_sharepointdocumentlocation", Microsoft.Xrm.Sdk.EntityRole.Referencing)]
        public SharePointDocumentLocation Referencingsharepointdocumentlocation_parent_sharepointdocumentlocation
        {
            get { return this.GetRelatedEntity<SharePointDocumentLocation>("sharepointdocumentlocation_parent_sharepointdocumentlocation", Microsoft.Xrm.Sdk.EntityRole.Referencing); }
            set
            {
                this.OnPropertyChanging("Referencingsharepointdocumentlocation_parent_sharepointdocumentlocation");
                this.SetRelatedEntity<SharePointDocumentLocation>("sharepointdocumentlocation_parent_sharepointdocumentlocation", Microsoft.Xrm.Sdk.EntityRole.Referencing, value);
                this.OnPropertyChanged("Referencingsharepointdocumentlocation_parent_sharepointdocumentlocation");
            }
        }

        /// <summary>
        /// N:1 sharepointdocumentlocation_parent_sharepointsite
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("parentsiteorlocation")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("sharepointdocumentlocation_parent_sharepointsite")]
        public SharePointSite sharepointdocumentlocation_parent_sharepointsite
        {
            get { return this.GetRelatedEntity<SharePointSite>("sharepointdocumentlocation_parent_sharepointsite", null); }
            set
            {
                this.OnPropertyChanging("sharepointdocumentlocation_parent_sharepointsite");
                this.SetRelatedEntity<SharePointSite>("sharepointdocumentlocation_parent_sharepointsite", null, value);
                this.OnPropertyChanged("sharepointdocumentlocation_parent_sharepointsite");
            }
        }

        /// <summary>
        /// N:1 team_sharepointdocumentlocation
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_sharepointdocumentlocation")]
        public Team team_sharepointdocumentlocation
        {
            get { return this.GetRelatedEntity<Team>("team_sharepointdocumentlocation", null); }
        }

        /// <summary>
        /// N:1 TransactionCurrency_SharePointDocumentLocation
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("TransactionCurrency_SharePointDocumentLocation")]
        public TransactionCurrency TransactionCurrency_SharePointDocumentLocation
        {
            get { return this.GetRelatedEntity<TransactionCurrency>("TransactionCurrency_SharePointDocumentLocation", null); }
        }

        /// <summary>
        /// N:1 user_sharepointdocumentlocation
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_sharepointdocumentlocation")]
        public SystemUser user_sharepointdocumentlocation
        {
            get { return this.GetRelatedEntity<SystemUser>("user_sharepointdocumentlocation", null); }
        }
    }
}