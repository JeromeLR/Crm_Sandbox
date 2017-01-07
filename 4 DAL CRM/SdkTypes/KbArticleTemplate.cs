namespace __4_DAL_CRM
{
    /// <summary>
    /// Template for a knowledge base article that contains the standard attributes of an article.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("kbarticletemplate")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class KbArticleTemplate : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public KbArticleTemplate() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "kbarticletemplate";

        public const int EntityTypeCode = 1016;

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
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("componentstate")]
        public Microsoft.Xrm.Sdk.OptionSetValue ComponentState
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("componentstate"); }
        }

        /// <summary>
        /// Unique identifier of the user who created the knowledge base article template.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby"); }
        }

        /// <summary>
        /// Date and time when the knowledge base article template was created.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
        public System.Nullable<System.DateTime> CreatedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who created the kbarticletemplate.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        /// Description of the knowledge base article template.
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
        /// XML format of the knowledge base article template.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("formatxml")]
        public string FormatXml
        {
            get { return this.GetAttributeValue<string>("formatxml"); }
            set
            {
                this.OnPropertyChanging("FormatXml");
                this.SetAttributeValue("formatxml", value);
                this.OnPropertyChanged("FormatXml");
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
        /// Version in which the form is introduced.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("introducedversion")]
        public string IntroducedVersion
        {
            get { return this.GetAttributeValue<string>("introducedversion"); }
            set
            {
                this.OnPropertyChanging("IntroducedVersion");
                this.SetAttributeValue("introducedversion", value);
                this.OnPropertyChanged("IntroducedVersion");
            }
        }

        /// <summary>
        /// Information about whether the knowledge base article is active.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isactive")]
        public System.Nullable<bool> IsActive
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("isactive"); }
            set
            {
                this.OnPropertyChanging("IsActive");
                this.SetAttributeValue("isactive", value);
                this.OnPropertyChanged("IsActive");
            }
        }

        /// <summary>
        /// Information that specifies whether this component can be customized.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("iscustomizable")]
        public Microsoft.Xrm.Sdk.BooleanManagedProperty IsCustomizable
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.BooleanManagedProperty>("iscustomizable"); }
            set
            {
                this.OnPropertyChanging("IsCustomizable");
                this.SetAttributeValue("iscustomizable", value);
                this.OnPropertyChanged("IsCustomizable");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ismanaged")]
        public System.Nullable<bool> IsManaged
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("ismanaged"); }
        }

        /// <summary>
        /// Unique identifier of the knowledge base article template.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("kbarticletemplateid")]
        public System.Nullable<System.Guid> KbArticleTemplateId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("kbarticletemplateid"); }
            set
            {
                this.OnPropertyChanging("KbArticleTemplateId");
                this.SetAttributeValue("kbarticletemplateid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("KbArticleTemplateId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("kbarticletemplateid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.KbArticleTemplateId = value; }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("kbarticletemplateidunique")]
        public System.Nullable<System.Guid> KbArticleTemplateIdUnique
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("kbarticletemplateidunique"); }
        }

        /// <summary>
        /// Language of the Article Template
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
        /// Unique identifier of the user who last modified the knowledge base article template.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby"); }
        }

        /// <summary>
        /// Date and time when the knowledge base article template was last modified.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
        public System.Nullable<System.DateTime> ModifiedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who last modified the kbarticletemplate.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        /// Unique identifier of the organization associated with the template.
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
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("overwritetime")]
        public System.Nullable<System.DateTime> OverwriteTime
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("overwritetime"); }
        }

        /// <summary>
        /// Unique identifier of the associated solution.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("solutionid")]
        public System.Nullable<System.Guid> SolutionId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("solutionid"); }
        }

        /// <summary>
        /// XML structure of the knowledge base article.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("structurexml")]
        public string StructureXml
        {
            get { return this.GetAttributeValue<string>("structurexml"); }
            set
            {
                this.OnPropertyChanging("StructureXml");
                this.SetAttributeValue("structurexml", value);
                this.OnPropertyChanged("StructureXml");
            }
        }

        /// <summary>
        /// Title of the knowledge base article template.
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
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
        public System.Nullable<long> VersionNumber
        {
            get { return this.GetAttributeValue<System.Nullable<long>>("versionnumber"); }
        }

        /// <summary>
        /// 1:N kb_article_template_kb_articles
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("kb_article_template_kb_articles")]
        public System.Collections.Generic.IEnumerable<KbArticle> kb_article_template_kb_articles
        {
            get { return this.GetRelatedEntities<KbArticle>("kb_article_template_kb_articles", null); }
            set
            {
                this.OnPropertyChanging("kb_article_template_kb_articles");
                this.SetRelatedEntities<KbArticle>("kb_article_template_kb_articles", null, value);
                this.OnPropertyChanged("kb_article_template_kb_articles");
            }
        }

        /// <summary>
        /// 1:N KbArticleTemplate_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("KbArticleTemplate_AsyncOperations")]
        public System.Collections.Generic.IEnumerable<AsyncOperation> KbArticleTemplate_AsyncOperations
        {
            get { return this.GetRelatedEntities<AsyncOperation>("KbArticleTemplate_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("KbArticleTemplate_AsyncOperations");
                this.SetRelatedEntities<AsyncOperation>("KbArticleTemplate_AsyncOperations", null, value);
                this.OnPropertyChanged("KbArticleTemplate_AsyncOperations");
            }
        }

        /// <summary>
        /// 1:N KbArticleTemplate_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("KbArticleTemplate_BulkDeleteFailures")]
        public System.Collections.Generic.IEnumerable<BulkDeleteFailure> KbArticleTemplate_BulkDeleteFailures
        {
            get { return this.GetRelatedEntities<BulkDeleteFailure>("KbArticleTemplate_BulkDeleteFailures", null); }
            set
            {
                this.OnPropertyChanging("KbArticleTemplate_BulkDeleteFailures");
                this.SetRelatedEntities<BulkDeleteFailure>("KbArticleTemplate_BulkDeleteFailures", null, value);
                this.OnPropertyChanged("KbArticleTemplate_BulkDeleteFailures");
            }
        }

        /// <summary>
        /// 1:N KbArticleTemplate_ProcessSessions
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("KbArticleTemplate_ProcessSessions")]
        public System.Collections.Generic.IEnumerable<ProcessSession> KbArticleTemplate_ProcessSessions
        {
            get { return this.GetRelatedEntities<ProcessSession>("KbArticleTemplate_ProcessSessions", null); }
            set
            {
                this.OnPropertyChanging("KbArticleTemplate_ProcessSessions");
                this.SetRelatedEntities<ProcessSession>("KbArticleTemplate_ProcessSessions", null, value);
                this.OnPropertyChanged("KbArticleTemplate_ProcessSessions");
            }
        }

        /// <summary>
        /// 1:N userentityinstancedata_kbarticletemplate
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_kbarticletemplate")]
        public System.Collections.Generic.IEnumerable<UserEntityInstanceData> userentityinstancedata_kbarticletemplate
        {
            get { return this.GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_kbarticletemplate", null); }
            set
            {
                this.OnPropertyChanging("userentityinstancedata_kbarticletemplate");
                this.SetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_kbarticletemplate", null, value);
                this.OnPropertyChanged("userentityinstancedata_kbarticletemplate");
            }
        }

        /// <summary>
        /// N:1 lk_kbarticletemplate_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_kbarticletemplate_createdonbehalfby")]
        public SystemUser lk_kbarticletemplate_createdonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_kbarticletemplate_createdonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_kbarticletemplate_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_kbarticletemplate_modifiedonbehalfby")]
        public SystemUser lk_kbarticletemplate_modifiedonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_kbarticletemplate_modifiedonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_kbarticletemplatebase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_kbarticletemplatebase_createdby")]
        public SystemUser lk_kbarticletemplatebase_createdby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_kbarticletemplatebase_createdby", null); }
        }

        /// <summary>
        /// N:1 lk_kbarticletemplatebase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_kbarticletemplatebase_modifiedby")]
        public SystemUser lk_kbarticletemplatebase_modifiedby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_kbarticletemplatebase_modifiedby", null); }
        }

        /// <summary>
        /// N:1 organization_kb_article_templates
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_kb_article_templates")]
        public Organization organization_kb_article_templates
        {
            get { return this.GetRelatedEntity<Organization>("organization_kb_article_templates", null); }
        }
    }
}