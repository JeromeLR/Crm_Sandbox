namespace __4_DAL_CRM
{
    /// <summary>
    /// Announcement associated with an organization.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("businessunitnewsarticle")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class BusinessUnitNewsArticle : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public BusinessUnitNewsArticle() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "businessunitnewsarticle";

        public const int EntityTypeCode = 132;

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
        /// Date and time for the announcement to become active.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("activeon")]
        public System.Nullable<System.DateTime> ActiveOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("activeon"); }
            set
            {
                this.OnPropertyChanging("ActiveOn");
                this.SetAttributeValue("activeon", value);
                this.OnPropertyChanged("ActiveOn");
            }
        }

        /// <summary>
        /// Date and time of the last day the announcement is active.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("activeuntil")]
        public System.Nullable<System.DateTime> ActiveUntil
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("activeuntil"); }
            set
            {
                this.OnPropertyChanging("ActiveUntil");
                this.SetAttributeValue("activeuntil", value);
                this.OnPropertyChanged("ActiveUntil");
            }
        }

        /// <summary>
        /// Title of the announcement.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("articletitle")]
        public string ArticleTitle
        {
            get { return this.GetAttributeValue<string>("articletitle"); }
            set
            {
                this.OnPropertyChanging("ArticleTitle");
                this.SetAttributeValue("articletitle", value);
                this.OnPropertyChanged("ArticleTitle");
            }
        }

        /// <summary>
        /// Type of announcement.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("articletypecode")]
        public Microsoft.Xrm.Sdk.OptionSetValue ArticleTypeCode
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("articletypecode"); }
            set
            {
                this.OnPropertyChanging("ArticleTypeCode");
                this.SetAttributeValue("articletypecode", value);
                this.OnPropertyChanged("ArticleTypeCode");
            }
        }

        /// <summary>
        /// URL for the Website on which the announcement is located.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("articleurl")]
        public string ArticleUrl
        {
            get { return this.GetAttributeValue<string>("articleurl"); }
            set
            {
                this.OnPropertyChanging("ArticleUrl");
                this.SetAttributeValue("articleurl", value);
                this.OnPropertyChanged("ArticleUrl");
            }
        }

        /// <summary>
        /// Unique identifier of the announcement.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("businessunitnewsarticleid")]
        public System.Nullable<System.Guid> BusinessUnitNewsArticleId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("businessunitnewsarticleid"); }
            set
            {
                this.OnPropertyChanging("BusinessUnitNewsArticleId");
                this.SetAttributeValue("businessunitnewsarticleid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("BusinessUnitNewsArticleId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("businessunitnewsarticleid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.BusinessUnitNewsArticleId = value; }
        }

        /// <summary>
        /// Unique identifier of the user who created the announcement.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby"); }
        }

        /// <summary>
        /// Date and time when the announcement was created.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
        public System.Nullable<System.DateTime> CreatedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who created the businessunitnewsarticle.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby"); }
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
        /// Unique identifier of the user who last modified the announcement.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby"); }
        }

        /// <summary>
        /// Date and time when the announcement was last modified.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
        public System.Nullable<System.DateTime> ModifiedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who last modified the businessunitnewsarticle.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        /// Text for the announcement.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("newsarticle")]
        public string NewsArticle
        {
            get { return this.GetAttributeValue<string>("newsarticle"); }
            set
            {
                this.OnPropertyChanging("NewsArticle");
                this.SetAttributeValue("newsarticle", value);
                this.OnPropertyChanged("NewsArticle");
            }
        }

        /// <summary>
        /// Unique identifier of the organization associated with the announcement.
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
        /// Information about whether to show the announcement on the Website home page.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("showonhomepage")]
        public System.Nullable<bool> ShowOnHomepage
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("showonhomepage"); }
            set
            {
                this.OnPropertyChanging("ShowOnHomepage");
                this.SetAttributeValue("showonhomepage", value);
                this.OnPropertyChanged("ShowOnHomepage");
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
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
        public System.Nullable<long> VersionNumber
        {
            get { return this.GetAttributeValue<System.Nullable<long>>("versionnumber"); }
        }

        /// <summary>
        /// 1:N BusinessUnitNewsArticle_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("BusinessUnitNewsArticle_AsyncOperations")]
        public System.Collections.Generic.IEnumerable<AsyncOperation> BusinessUnitNewsArticle_AsyncOperations
        {
            get { return this.GetRelatedEntities<AsyncOperation>("BusinessUnitNewsArticle_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("BusinessUnitNewsArticle_AsyncOperations");
                this.SetRelatedEntities<AsyncOperation>("BusinessUnitNewsArticle_AsyncOperations", null, value);
                this.OnPropertyChanged("BusinessUnitNewsArticle_AsyncOperations");
            }
        }

        /// <summary>
        /// 1:N BusinessUnitNewsArticle_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("BusinessUnitNewsArticle_BulkDeleteFailures")]
        public System.Collections.Generic.IEnumerable<BulkDeleteFailure> BusinessUnitNewsArticle_BulkDeleteFailures
        {
            get { return this.GetRelatedEntities<BulkDeleteFailure>("BusinessUnitNewsArticle_BulkDeleteFailures", null); }
            set
            {
                this.OnPropertyChanging("BusinessUnitNewsArticle_BulkDeleteFailures");
                this.SetRelatedEntities<BulkDeleteFailure>("BusinessUnitNewsArticle_BulkDeleteFailures", null, value);
                this.OnPropertyChanged("BusinessUnitNewsArticle_BulkDeleteFailures");
            }
        }

        /// <summary>
        /// 1:N BusinessUnitNewsArticle_ProcessSessions
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("BusinessUnitNewsArticle_ProcessSessions")]
        public System.Collections.Generic.IEnumerable<ProcessSession> BusinessUnitNewsArticle_ProcessSessions
        {
            get { return this.GetRelatedEntities<ProcessSession>("BusinessUnitNewsArticle_ProcessSessions", null); }
            set
            {
                this.OnPropertyChanging("BusinessUnitNewsArticle_ProcessSessions");
                this.SetRelatedEntities<ProcessSession>("BusinessUnitNewsArticle_ProcessSessions", null, value);
                this.OnPropertyChanged("BusinessUnitNewsArticle_ProcessSessions");
            }
        }

        /// <summary>
        /// 1:N userentityinstancedata_businessunitnewsarticle
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_businessunitnewsarticle")]
        public System.Collections.Generic.IEnumerable<UserEntityInstanceData> userentityinstancedata_businessunitnewsarticle
        {
            get { return this.GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_businessunitnewsarticle", null); }
            set
            {
                this.OnPropertyChanging("userentityinstancedata_businessunitnewsarticle");
                this.SetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_businessunitnewsarticle", null, value);
                this.OnPropertyChanged("userentityinstancedata_businessunitnewsarticle");
            }
        }

        /// <summary>
        /// N:1 lk_businessunitnewsarticle_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_businessunitnewsarticle_createdonbehalfby")]
        public SystemUser lk_businessunitnewsarticle_createdonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_businessunitnewsarticle_createdonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_businessunitnewsarticle_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_businessunitnewsarticle_modifiedonbehalfby")]
        public SystemUser lk_businessunitnewsarticle_modifiedonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_businessunitnewsarticle_modifiedonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_businessunitnewsarticlebase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_businessunitnewsarticlebase_createdby")]
        public SystemUser lk_businessunitnewsarticlebase_createdby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_businessunitnewsarticlebase_createdby", null); }
        }

        /// <summary>
        /// N:1 lk_businessunitnewsarticlebase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_businessunitnewsarticlebase_modifiedby")]
        public SystemUser lk_businessunitnewsarticlebase_modifiedby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_businessunitnewsarticlebase_modifiedby", null); }
        }

        /// <summary>
        /// N:1 organization_business_unit_news_articles
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_business_unit_news_articles")]
        public Organization organization_business_unit_news_articles
        {
            get { return this.GetRelatedEntity<Organization>("organization_business_unit_news_articles", null); }
        }
    }
}