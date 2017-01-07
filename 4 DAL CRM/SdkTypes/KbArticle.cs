namespace __4_DAL_CRM
{
    /// <summary>
    /// Structured content that is part of the knowledge base.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("kbarticle")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class KbArticle : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public KbArticle() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "kbarticle";

        public const int EntityTypeCode = 127;

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
        /// Shows the article content and formatting, stored as XML.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("articlexml")]
        public string ArticleXml
        {
            get { return this.GetAttributeValue<string>("articlexml"); }
            set
            {
                this.OnPropertyChanging("ArticleXml");
                this.SetAttributeValue("articlexml", value);
                this.OnPropertyChanged("ArticleXml");
            }
        }

        /// <summary>
        /// Comments regarding the knowledge base article.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("comments")]
        public string Comments
        {
            get { return this.GetAttributeValue<string>("comments"); }
            set
            {
                this.OnPropertyChanging("Comments");
                this.SetAttributeValue("comments", value);
                this.OnPropertyChanged("Comments");
            }
        }

        /// <summary>
        /// Description of the content of the knowledge base article.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("content")]
        public string Content
        {
            get { return this.GetAttributeValue<string>("content"); }
        }

        /// <summary>
        /// Unique identifier of the user who created the knowledge base article.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby"); }
        }

        /// <summary>
        /// Date and time when the knowledge base article was created.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
        public System.Nullable<System.DateTime> CreatedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who created the article.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        /// Type additional information that describes the knowledge base article.
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
        /// Shows the ID of the article.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("kbarticleid")]
        public System.Nullable<System.Guid> KbArticleId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("kbarticleid"); }
            set
            {
                this.OnPropertyChanging("KbArticleId");
                this.SetAttributeValue("kbarticleid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("KbArticleId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("kbarticleid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.KbArticleId = value; }
        }

        /// <summary>
        /// Choose the template that you want to use as a base for creating the new article.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("kbarticletemplateid")]
        public Microsoft.Xrm.Sdk.EntityReference KbArticleTemplateId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("kbarticletemplateid"); }
            set
            {
                this.OnPropertyChanging("KbArticleTemplateId");
                this.SetAttributeValue("kbarticletemplateid", value);
                this.OnPropertyChanged("KbArticleTemplateId");
            }
        }

        /// <summary>
        /// Keywords to be used for searches in knowledge base articles.
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
        /// Select which language the article must be available in. This list is based on the list of language packs that are installed in your Microsoft Dynamics CRM environment.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("languagecode")]
        public System.Nullable<int> LanguageCode
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("languagecode"); }
            set
            {
                this.OnPropertyChanging("LanguageCode");
                this.SetAttributeValue("languagecode", value);
                this.OnPropertyChanged("LanguageCode");
            }
        }

        /// <summary>
        /// Unique identifier of the user who last modified the knowledge base article.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby"); }
        }

        /// <summary>
        /// Date and time when the knowledge base article was last modified.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
        public System.Nullable<System.DateTime> ModifiedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who last modified the kbarticle.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        /// Knowledge base article number.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("number")]
        public string Number
        {
            get { return this.GetAttributeValue<string>("number"); }
        }

        /// <summary>
        /// Unique identifier of the organization associated with the article.
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
        /// Shows whether the knowledge base article is in draft, unapproved, or published status. Published articles are read-only and can't be edited unless they are unpublished.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
        public System.Nullable<KbArticleState> StateCode
        {
            get
            {
                Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
                if ((optionSet != null))
                {
                    return ((KbArticleState) (System.Enum.ToObject(typeof(KbArticleState), optionSet.Value)));
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// Select the article's status.
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
        /// Choose the subject of the article to assist with article searches. You can configure subjects under Business Management in the Settings area.
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
        /// Type a subject or descriptive name for the article to assist with article searches.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("title")]
        public string Title
        {
            get { return this.GetAttributeValue<string>("title"); }
            set
            {
                this.OnPropertyChanging("Title");
                this.SetAttributeValue("title", value);
                this.OnPropertyChanged("Title");
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
        /// Title of the knowledge base article.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
        public System.Nullable<long> VersionNumber
        {
            get { return this.GetAttributeValue<System.Nullable<long>>("versionnumber"); }
        }

        /// <summary>
        /// 1:N KbArticle_Annotation
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("KbArticle_Annotation")]
        public System.Collections.Generic.IEnumerable<Annotation> KbArticle_Annotation
        {
            get { return this.GetRelatedEntities<Annotation>("KbArticle_Annotation", null); }
            set
            {
                this.OnPropertyChanging("KbArticle_Annotation");
                this.SetRelatedEntities<Annotation>("KbArticle_Annotation", null, value);
                this.OnPropertyChanged("KbArticle_Annotation");
            }
        }

        /// <summary>
        /// 1:N KbArticle_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("KbArticle_AsyncOperations")]
        public System.Collections.Generic.IEnumerable<AsyncOperation> KbArticle_AsyncOperations
        {
            get { return this.GetRelatedEntities<AsyncOperation>("KbArticle_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("KbArticle_AsyncOperations");
                this.SetRelatedEntities<AsyncOperation>("KbArticle_AsyncOperations", null, value);
                this.OnPropertyChanged("KbArticle_AsyncOperations");
            }
        }

        /// <summary>
        /// 1:N KbArticle_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("KbArticle_BulkDeleteFailures")]
        public System.Collections.Generic.IEnumerable<BulkDeleteFailure> KbArticle_BulkDeleteFailures
        {
            get { return this.GetRelatedEntities<BulkDeleteFailure>("KbArticle_BulkDeleteFailures", null); }
            set
            {
                this.OnPropertyChanging("KbArticle_BulkDeleteFailures");
                this.SetRelatedEntities<BulkDeleteFailure>("KbArticle_BulkDeleteFailures", null, value);
                this.OnPropertyChanged("KbArticle_BulkDeleteFailures");
            }
        }

        /// <summary>
        /// 1:N kbarticle_comments
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("kbarticle_comments")]
        public System.Collections.Generic.IEnumerable<KbArticleComment> kbarticle_comments
        {
            get { return this.GetRelatedEntities<KbArticleComment>("kbarticle_comments", null); }
            set
            {
                this.OnPropertyChanging("kbarticle_comments");
                this.SetRelatedEntities<KbArticleComment>("kbarticle_comments", null, value);
                this.OnPropertyChanged("kbarticle_comments");
            }
        }

        /// <summary>
        /// 1:N KbArticle_DuplicateBaseRecord
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("KbArticle_DuplicateBaseRecord")]
        public System.Collections.Generic.IEnumerable<DuplicateRecord> KbArticle_DuplicateBaseRecord
        {
            get { return this.GetRelatedEntities<DuplicateRecord>("KbArticle_DuplicateBaseRecord", null); }
            set
            {
                this.OnPropertyChanging("KbArticle_DuplicateBaseRecord");
                this.SetRelatedEntities<DuplicateRecord>("KbArticle_DuplicateBaseRecord", null, value);
                this.OnPropertyChanged("KbArticle_DuplicateBaseRecord");
            }
        }

        /// <summary>
        /// 1:N KbArticle_DuplicateMatchingRecord
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("KbArticle_DuplicateMatchingRecord")]
        public System.Collections.Generic.IEnumerable<DuplicateRecord> KbArticle_DuplicateMatchingRecord
        {
            get { return this.GetRelatedEntities<DuplicateRecord>("KbArticle_DuplicateMatchingRecord", null); }
            set
            {
                this.OnPropertyChanging("KbArticle_DuplicateMatchingRecord");
                this.SetRelatedEntities<DuplicateRecord>("KbArticle_DuplicateMatchingRecord", null, value);
                this.OnPropertyChanged("KbArticle_DuplicateMatchingRecord");
            }
        }

        /// <summary>
        /// 1:N kbarticle_incidents
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("kbarticle_incidents")]
        public System.Collections.Generic.IEnumerable<Incident> kbarticle_incidents
        {
            get { return this.GetRelatedEntities<Incident>("kbarticle_incidents", null); }
            set
            {
                this.OnPropertyChanging("kbarticle_incidents");
                this.SetRelatedEntities<Incident>("kbarticle_incidents", null, value);
                this.OnPropertyChanged("kbarticle_incidents");
            }
        }

        /// <summary>
        /// 1:N kbarticle_principalobjectattributeaccess
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("kbarticle_principalobjectattributeaccess")]
        public System.Collections.Generic.IEnumerable<PrincipalObjectAttributeAccess> kbarticle_principalobjectattributeaccess
        {
            get { return this.GetRelatedEntities<PrincipalObjectAttributeAccess>("kbarticle_principalobjectattributeaccess", null); }
            set
            {
                this.OnPropertyChanging("kbarticle_principalobjectattributeaccess");
                this.SetRelatedEntities<PrincipalObjectAttributeAccess>("kbarticle_principalobjectattributeaccess", null, value);
                this.OnPropertyChanged("kbarticle_principalobjectattributeaccess");
            }
        }

        /// <summary>
        /// 1:N KbArticle_ProcessSessions
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("KbArticle_ProcessSessions")]
        public System.Collections.Generic.IEnumerable<ProcessSession> KbArticle_ProcessSessions
        {
            get { return this.GetRelatedEntities<ProcessSession>("KbArticle_ProcessSessions", null); }
            set
            {
                this.OnPropertyChanging("KbArticle_ProcessSessions");
                this.SetRelatedEntities<ProcessSession>("KbArticle_ProcessSessions", null, value);
                this.OnPropertyChanged("KbArticle_ProcessSessions");
            }
        }

        /// <summary>
        /// 1:N KbArticle_SharepointDocument
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("KbArticle_SharepointDocument")]
        public System.Collections.Generic.IEnumerable<SharePointDocument> KbArticle_SharepointDocument
        {
            get { return this.GetRelatedEntities<SharePointDocument>("KbArticle_SharepointDocument", null); }
            set
            {
                this.OnPropertyChanging("KbArticle_SharepointDocument");
                this.SetRelatedEntities<SharePointDocument>("KbArticle_SharepointDocument", null, value);
                this.OnPropertyChanged("KbArticle_SharepointDocument");
            }
        }

        /// <summary>
        /// 1:N KbArticle_SharepointDocumentLocation
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("KbArticle_SharepointDocumentLocation")]
        public System.Collections.Generic.IEnumerable<SharePointDocumentLocation> KbArticle_SharepointDocumentLocation
        {
            get { return this.GetRelatedEntities<SharePointDocumentLocation>("KbArticle_SharepointDocumentLocation", null); }
            set
            {
                this.OnPropertyChanging("KbArticle_SharepointDocumentLocation");
                this.SetRelatedEntities<SharePointDocumentLocation>("KbArticle_SharepointDocumentLocation", null, value);
                this.OnPropertyChanged("KbArticle_SharepointDocumentLocation");
            }
        }

        /// <summary>
        /// 1:N userentityinstancedata_kbarticle
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_kbarticle")]
        public System.Collections.Generic.IEnumerable<UserEntityInstanceData> userentityinstancedata_kbarticle
        {
            get { return this.GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_kbarticle", null); }
            set
            {
                this.OnPropertyChanging("userentityinstancedata_kbarticle");
                this.SetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_kbarticle", null, value);
                this.OnPropertyChanged("userentityinstancedata_kbarticle");
            }
        }

        /// <summary>
        /// N:1 kb_article_template_kb_articles
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("kbarticletemplateid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("kb_article_template_kb_articles")]
        public KbArticleTemplate kb_article_template_kb_articles
        {
            get { return this.GetRelatedEntity<KbArticleTemplate>("kb_article_template_kb_articles", null); }
            set
            {
                this.OnPropertyChanging("kb_article_template_kb_articles");
                this.SetRelatedEntity<KbArticleTemplate>("kb_article_template_kb_articles", null, value);
                this.OnPropertyChanged("kb_article_template_kb_articles");
            }
        }

        /// <summary>
        /// N:1 lk_kbarticle_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_kbarticle_createdonbehalfby")]
        public SystemUser lk_kbarticle_createdonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_kbarticle_createdonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_kbarticle_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_kbarticle_modifiedonbehalfby")]
        public SystemUser lk_kbarticle_modifiedonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_kbarticle_modifiedonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_kbarticlebase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_kbarticlebase_createdby")]
        public SystemUser lk_kbarticlebase_createdby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_kbarticlebase_createdby", null); }
        }

        /// <summary>
        /// N:1 lk_kbarticlebase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_kbarticlebase_modifiedby")]
        public SystemUser lk_kbarticlebase_modifiedby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_kbarticlebase_modifiedby", null); }
        }

        /// <summary>
        /// N:1 organization_kb_articles
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_kb_articles")]
        public Organization organization_kb_articles
        {
            get { return this.GetRelatedEntity<Organization>("organization_kb_articles", null); }
        }

        /// <summary>
        /// N:1 subject_kb_articles
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("subjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("subject_kb_articles")]
        public Subject subject_kb_articles
        {
            get { return this.GetRelatedEntity<Subject>("subject_kb_articles", null); }
            set
            {
                this.OnPropertyChanging("subject_kb_articles");
                this.SetRelatedEntity<Subject>("subject_kb_articles", null, value);
                this.OnPropertyChanged("subject_kb_articles");
            }
        }

        /// <summary>
        /// N:1 TransactionCurrency_KbArticle
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("TransactionCurrency_KbArticle")]
        public TransactionCurrency TransactionCurrency_KbArticle
        {
            get { return this.GetRelatedEntity<TransactionCurrency>("TransactionCurrency_KbArticle", null); }
            set
            {
                this.OnPropertyChanging("TransactionCurrency_KbArticle");
                this.SetRelatedEntity<TransactionCurrency>("TransactionCurrency_KbArticle", null, value);
                this.OnPropertyChanged("TransactionCurrency_KbArticle");
            }
        }
    }
}