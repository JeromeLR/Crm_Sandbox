namespace __4_DAL_CRM
{
    /// <summary>
    /// SharePoint site from where documents can be managed in Microsoft Dynamics CRM.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("sharepointsite")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class SharePointSite : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public SharePointSite() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "sharepointsite";

        public const int EntityTypeCode = 9502;

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
        /// Absolute URL of the SharePoint site.
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
        /// Unique identifier of the user who created the SharePoint site record.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby"); }
        }

        /// <summary>
        /// Date and time when the SharePoint site record was created.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
        public System.Nullable<System.DateTime> CreatedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who created the SharePoint site record.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        /// Description of the SharePoint site record.
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
        /// Exchange rate between the currency associated with the SharePoint site record and the base currency.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("exchangerate")]
        public System.Nullable<decimal> ExchangeRate
        {
            get { return this.GetAttributeValue<System.Nullable<decimal>>("exchangerate"); }
        }

        /// <summary>
        /// Entity on which the folder structure for Microsoft Dynamics CRM records will be created in SharePoint.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("folderstructureentity")]
        public string FolderStructureEntity
        {
            get { return this.GetAttributeValue<string>("folderstructureentity"); }
            set
            {
                this.OnPropertyChanging("FolderStructureEntity");
                this.SetAttributeValue("folderstructureentity", value);
                this.OnPropertyChanged("FolderStructureEntity");
            }
        }

        /// <summary>
        /// Sequence number of the import that created this record.
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
        /// Indicates whether the SharePoint site is the default site or not.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isdefault")]
        public System.Nullable<bool> IsDefault
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("isdefault"); }
            set
            {
                this.OnPropertyChanging("IsDefault");
                this.SetAttributeValue("isdefault", value);
                this.OnPropertyChanged("IsDefault");
            }
        }

        /// <summary>
        /// Indicates if SharePoint Grid is present or not.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isgridpresent")]
        public System.Nullable<bool> IsGridPresent
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("isgridpresent"); }
            set
            {
                this.OnPropertyChanging("IsGridPresent");
                this.SetAttributeValue("isgridpresent", value);
                this.OnPropertyChanged("IsGridPresent");
            }
        }

        /// <summary>
        /// Allows embedding of Power BI Reports available in this SharePoint site.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ispowerbisite")]
        public System.Nullable<bool> IsPowerBISite
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("ispowerbisite"); }
            set
            {
                this.OnPropertyChanging("IsPowerBISite");
                this.SetAttributeValue("ispowerbisite", value);
                this.OnPropertyChanged("IsPowerBISite");
            }
        }

        /// <summary>
        /// Date and time when the SharePoint site URL was last validated.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("lastvalidated")]
        public System.Nullable<System.DateTime> LastValidated
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("lastvalidated"); }
            set
            {
                this.OnPropertyChanging("LastValidated");
                this.SetAttributeValue("lastvalidated", value);
                this.OnPropertyChanged("LastValidated");
            }
        }

        /// <summary>
        /// Unique identifier of the user who last modified the SharePoint site record.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby"); }
        }

        /// <summary>
        /// Date and time when the SharePoint site record was last modified.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
        public System.Nullable<System.DateTime> ModifiedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who modified the SharePoint site record.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        /// Name of the SharePoint site record.
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
        /// Unique identifier of the user or team who owns the SharePoint site.
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
        /// Unique identifier for the business unit that owns the document location record.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
        public Microsoft.Xrm.Sdk.EntityReference OwningBusinessUnit
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningbusinessunit"); }
        }

        /// <summary>
        /// Unique identifier of the team that owns the SharePoint site record.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
        public Microsoft.Xrm.Sdk.EntityReference OwningTeam
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningteam"); }
        }

        /// <summary>
        /// Unique identifier of the user who owns the SharePoint site record.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
        public Microsoft.Xrm.Sdk.EntityReference OwningUser
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owninguser"); }
        }

        /// <summary>
        /// Unique identifier of the parent SharePoint site.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("parentsite")]
        public Microsoft.Xrm.Sdk.EntityReference ParentSite
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("parentsite"); }
            set
            {
                this.OnPropertyChanging("ParentSite");
                this.SetAttributeValue("parentsite", value);
                this.OnPropertyChanged("ParentSite");
            }
        }

        /// <summary>
        /// Relative URL of the SharePoint site.
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
        /// Unique identifier of the SharePoint site in CRM
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sharepointsiteid")]
        public System.Nullable<System.Guid> SharePointSiteId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("sharepointsiteid"); }
            set
            {
                this.OnPropertyChanging("SharePointSiteId");
                this.SetAttributeValue("sharepointsiteid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("SharePointSiteId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sharepointsiteid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.SharePointSiteId = value; }
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
        /// Status of the SharePoint site record.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
        public System.Nullable<SharePointSiteState> StateCode
        {
            get
            {
                Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
                if ((optionSet != null))
                {
                    return ((SharePointSiteState) (System.Enum.ToObject(typeof(SharePointSiteState), optionSet.Value)));
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// Reason for the status of the SharePoint site record.
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
        /// Unique identifier of the currency associated with the SharePoint site record.
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
        /// Validation status of the SharePoint site URL.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("validationstatus")]
        public Microsoft.Xrm.Sdk.OptionSetValue ValidationStatus
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("validationstatus"); }
            set
            {
                this.OnPropertyChanging("ValidationStatus");
                this.SetAttributeValue("validationstatus", value);
                this.OnPropertyChanged("ValidationStatus");
            }
        }

        /// <summary>
        /// Reason for validation status of the URL
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("validationstatuserrorcode")]
        public Microsoft.Xrm.Sdk.OptionSetValue ValidationStatusErrorCode
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("validationstatuserrorcode"); }
            set
            {
                this.OnPropertyChanging("ValidationStatusErrorCode");
                this.SetAttributeValue("validationstatuserrorcode", value);
                this.OnPropertyChanged("ValidationStatusErrorCode");
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
        /// 1:N sharepointdocumentlocation_parent_sharepointsite
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("sharepointdocumentlocation_parent_sharepointsite")]
        public System.Collections.Generic.IEnumerable<SharePointDocumentLocation> sharepointdocumentlocation_parent_sharepointsite
        {
            get { return this.GetRelatedEntities<SharePointDocumentLocation>("sharepointdocumentlocation_parent_sharepointsite", null); }
            set
            {
                this.OnPropertyChanging("sharepointdocumentlocation_parent_sharepointsite");
                this.SetRelatedEntities<SharePointDocumentLocation>("sharepointdocumentlocation_parent_sharepointsite", null, value);
                this.OnPropertyChanged("sharepointdocumentlocation_parent_sharepointsite");
            }
        }

        /// <summary>
        /// 1:N SharePointSite_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SharePointSite_AsyncOperations")]
        public System.Collections.Generic.IEnumerable<AsyncOperation> SharePointSite_AsyncOperations
        {
            get { return this.GetRelatedEntities<AsyncOperation>("SharePointSite_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("SharePointSite_AsyncOperations");
                this.SetRelatedEntities<AsyncOperation>("SharePointSite_AsyncOperations", null, value);
                this.OnPropertyChanged("SharePointSite_AsyncOperations");
            }
        }

        /// <summary>
        /// 1:N SharePointSite_DuplicateBaseRecord
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SharePointSite_DuplicateBaseRecord")]
        public System.Collections.Generic.IEnumerable<DuplicateRecord> SharePointSite_DuplicateBaseRecord
        {
            get { return this.GetRelatedEntities<DuplicateRecord>("SharePointSite_DuplicateBaseRecord", null); }
            set
            {
                this.OnPropertyChanging("SharePointSite_DuplicateBaseRecord");
                this.SetRelatedEntities<DuplicateRecord>("SharePointSite_DuplicateBaseRecord", null, value);
                this.OnPropertyChanged("SharePointSite_DuplicateBaseRecord");
            }
        }

        /// <summary>
        /// 1:N SharePointSite_DuplicateMatchingRecord
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SharePointSite_DuplicateMatchingRecord")]
        public System.Collections.Generic.IEnumerable<DuplicateRecord> SharePointSite_DuplicateMatchingRecord
        {
            get { return this.GetRelatedEntities<DuplicateRecord>("SharePointSite_DuplicateMatchingRecord", null); }
            set
            {
                this.OnPropertyChanging("SharePointSite_DuplicateMatchingRecord");
                this.SetRelatedEntities<DuplicateRecord>("SharePointSite_DuplicateMatchingRecord", null, value);
                this.OnPropertyChanged("SharePointSite_DuplicateMatchingRecord");
            }
        }

        /// <summary>
        /// 1:N sharepointsite_parentsite_sharepointsite
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("sharepointsite_parentsite_sharepointsite", Microsoft.Xrm.Sdk.EntityRole.Referenced)]
        public System.Collections.Generic.IEnumerable<SharePointSite> Referencedsharepointsite_parentsite_sharepointsite
        {
            get { return this.GetRelatedEntities<SharePointSite>("sharepointsite_parentsite_sharepointsite", Microsoft.Xrm.Sdk.EntityRole.Referenced); }
            set
            {
                this.OnPropertyChanging("Referencedsharepointsite_parentsite_sharepointsite");
                this.SetRelatedEntities<SharePointSite>("sharepointsite_parentsite_sharepointsite", Microsoft.Xrm.Sdk.EntityRole.Referenced, value);
                this.OnPropertyChanged("Referencedsharepointsite_parentsite_sharepointsite");
            }
        }

        /// <summary>
        /// 1:N sharepointsite_principalobjectattributeaccess
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("sharepointsite_principalobjectattributeaccess")]
        public System.Collections.Generic.IEnumerable<PrincipalObjectAttributeAccess> sharepointsite_principalobjectattributeaccess
        {
            get { return this.GetRelatedEntities<PrincipalObjectAttributeAccess>("sharepointsite_principalobjectattributeaccess", null); }
            set
            {
                this.OnPropertyChanging("sharepointsite_principalobjectattributeaccess");
                this.SetRelatedEntities<PrincipalObjectAttributeAccess>("sharepointsite_principalobjectattributeaccess", null, value);
                this.OnPropertyChanged("sharepointsite_principalobjectattributeaccess");
            }
        }

        /// <summary>
        /// 1:N SharePointSite_ProcessSessions
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SharePointSite_ProcessSessions")]
        public System.Collections.Generic.IEnumerable<ProcessSession> SharePointSite_ProcessSessions
        {
            get { return this.GetRelatedEntities<ProcessSession>("SharePointSite_ProcessSessions", null); }
            set
            {
                this.OnPropertyChanging("SharePointSite_ProcessSessions");
                this.SetRelatedEntities<ProcessSession>("SharePointSite_ProcessSessions", null, value);
                this.OnPropertyChanged("SharePointSite_ProcessSessions");
            }
        }

        /// <summary>
        /// 1:N userentityinstancedata_sharepointsite
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_sharepointsite")]
        public System.Collections.Generic.IEnumerable<UserEntityInstanceData> userentityinstancedata_sharepointsite
        {
            get { return this.GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_sharepointsite", null); }
            set
            {
                this.OnPropertyChanging("userentityinstancedata_sharepointsite");
                this.SetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_sharepointsite", null, value);
                this.OnPropertyChanged("userentityinstancedata_sharepointsite");
            }
        }

        /// <summary>
        /// N:1 business_unit_sharepointsites
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_sharepointsites")]
        public BusinessUnit business_unit_sharepointsites
        {
            get { return this.GetRelatedEntity<BusinessUnit>("business_unit_sharepointsites", null); }
        }

        /// <summary>
        /// N:1 lk_sharepointsitebase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_sharepointsitebase_createdby")]
        public SystemUser lk_sharepointsitebase_createdby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_sharepointsitebase_createdby", null); }
        }

        /// <summary>
        /// N:1 lk_sharepointsitebase_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_sharepointsitebase_createdonbehalfby")]
        public SystemUser lk_sharepointsitebase_createdonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_sharepointsitebase_createdonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_sharepointsitebase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_sharepointsitebase_modifiedby")]
        public SystemUser lk_sharepointsitebase_modifiedby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_sharepointsitebase_modifiedby", null); }
        }

        /// <summary>
        /// N:1 lk_sharepointsitebase_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_sharepointsitebase_modifiedonbehalfby")]
        public SystemUser lk_sharepointsitebase_modifiedonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_sharepointsitebase_modifiedonbehalfby", null); }
        }

        /// <summary>
        /// N:1 sharepointsite_parentsite_sharepointsite
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("parentsite")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("sharepointsite_parentsite_sharepointsite", Microsoft.Xrm.Sdk.EntityRole.Referencing)]
        public SharePointSite Referencingsharepointsite_parentsite_sharepointsite
        {
            get { return this.GetRelatedEntity<SharePointSite>("sharepointsite_parentsite_sharepointsite", Microsoft.Xrm.Sdk.EntityRole.Referencing); }
            set
            {
                this.OnPropertyChanging("Referencingsharepointsite_parentsite_sharepointsite");
                this.SetRelatedEntity<SharePointSite>("sharepointsite_parentsite_sharepointsite", Microsoft.Xrm.Sdk.EntityRole.Referencing, value);
                this.OnPropertyChanged("Referencingsharepointsite_parentsite_sharepointsite");
            }
        }

        /// <summary>
        /// N:1 team_sharepointsite
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_sharepointsite")]
        public Team team_sharepointsite
        {
            get { return this.GetRelatedEntity<Team>("team_sharepointsite", null); }
        }

        /// <summary>
        /// N:1 TransactionCurrency_SharePointSite
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("TransactionCurrency_SharePointSite")]
        public TransactionCurrency TransactionCurrency_SharePointSite
        {
            get { return this.GetRelatedEntity<TransactionCurrency>("TransactionCurrency_SharePointSite", null); }
        }

        /// <summary>
        /// N:1 user_sharepointsite
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_sharepointsite")]
        public SystemUser user_sharepointsite
        {
            get { return this.GetRelatedEntity<SystemUser>("user_sharepointsite", null); }
        }
    }
}