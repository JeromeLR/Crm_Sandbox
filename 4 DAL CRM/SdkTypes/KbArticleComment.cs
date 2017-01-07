namespace __4_DAL_CRM
{
    /// <summary>
    /// Comment on a knowledge base article.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("kbarticlecomment")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class KbArticleComment : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public KbArticleComment() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "kbarticlecomment";

        public const int EntityTypeCode = 1082;

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
        /// Comment text for the knowledge base article.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("commenttext")]
        public string CommentText
        {
            get { return this.GetAttributeValue<string>("commenttext"); }
            set
            {
                this.OnPropertyChanging("CommentText");
                this.SetAttributeValue("commenttext", value);
                this.OnPropertyChanged("CommentText");
            }
        }

        /// <summary>
        /// Unique identifier of the user who created the knowledge base article comment.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby"); }
        }

        /// <summary>
        /// Date and time when the knowledge base article comment was created.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
        public System.Nullable<System.DateTime> CreatedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who created the kbarticlecomment.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        /// Unique identifier of the knowledge base article comment.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("kbarticlecommentid")]
        public System.Nullable<System.Guid> KbArticleCommentId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("kbarticlecommentid"); }
            set
            {
                this.OnPropertyChanging("KbArticleCommentId");
                this.SetAttributeValue("kbarticlecommentid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("KbArticleCommentId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("kbarticlecommentid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.KbArticleCommentId = value; }
        }

        /// <summary>
        /// Unique identifier of the knowledge base article to which the comment applies.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("kbarticleid")]
        public Microsoft.Xrm.Sdk.EntityReference KbArticleId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("kbarticleid"); }
            set
            {
                this.OnPropertyChanging("KbArticleId");
                this.SetAttributeValue("kbarticleid", value);
                this.OnPropertyChanged("KbArticleId");
            }
        }

        /// <summary>
        /// Unique identifier of the user who last modified the knowledge base article comment.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby"); }
        }

        /// <summary>
        /// Date and time when the knowledge base article comment was last modified.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
        public System.Nullable<System.DateTime> ModifiedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who last modified the kbarticlecomment.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        /// Unique identifier of the organization with which the article comment is associated.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
        public System.Nullable<System.Guid> OrganizationId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("organizationid"); }
        }

        /// <summary>
        /// Title of the knowledge base article comment.
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
        /// 1:N KbArticleComment_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("KbArticleComment_AsyncOperations")]
        public System.Collections.Generic.IEnumerable<AsyncOperation> KbArticleComment_AsyncOperations
        {
            get { return this.GetRelatedEntities<AsyncOperation>("KbArticleComment_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("KbArticleComment_AsyncOperations");
                this.SetRelatedEntities<AsyncOperation>("KbArticleComment_AsyncOperations", null, value);
                this.OnPropertyChanged("KbArticleComment_AsyncOperations");
            }
        }

        /// <summary>
        /// 1:N KbArticleComment_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("KbArticleComment_BulkDeleteFailures")]
        public System.Collections.Generic.IEnumerable<BulkDeleteFailure> KbArticleComment_BulkDeleteFailures
        {
            get { return this.GetRelatedEntities<BulkDeleteFailure>("KbArticleComment_BulkDeleteFailures", null); }
            set
            {
                this.OnPropertyChanging("KbArticleComment_BulkDeleteFailures");
                this.SetRelatedEntities<BulkDeleteFailure>("KbArticleComment_BulkDeleteFailures", null, value);
                this.OnPropertyChanged("KbArticleComment_BulkDeleteFailures");
            }
        }

        /// <summary>
        /// 1:N KbArticleComment_ProcessSessions
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("KbArticleComment_ProcessSessions")]
        public System.Collections.Generic.IEnumerable<ProcessSession> KbArticleComment_ProcessSessions
        {
            get { return this.GetRelatedEntities<ProcessSession>("KbArticleComment_ProcessSessions", null); }
            set
            {
                this.OnPropertyChanging("KbArticleComment_ProcessSessions");
                this.SetRelatedEntities<ProcessSession>("KbArticleComment_ProcessSessions", null, value);
                this.OnPropertyChanged("KbArticleComment_ProcessSessions");
            }
        }

        /// <summary>
        /// 1:N userentityinstancedata_kbarticlecomment
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_kbarticlecomment")]
        public System.Collections.Generic.IEnumerable<UserEntityInstanceData> userentityinstancedata_kbarticlecomment
        {
            get { return this.GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_kbarticlecomment", null); }
            set
            {
                this.OnPropertyChanging("userentityinstancedata_kbarticlecomment");
                this.SetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_kbarticlecomment", null, value);
                this.OnPropertyChanged("userentityinstancedata_kbarticlecomment");
            }
        }

        /// <summary>
        /// N:1 kbarticle_comments
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("kbarticleid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("kbarticle_comments")]
        public KbArticle kbarticle_comments
        {
            get { return this.GetRelatedEntity<KbArticle>("kbarticle_comments", null); }
            set
            {
                this.OnPropertyChanging("kbarticle_comments");
                this.SetRelatedEntity<KbArticle>("kbarticle_comments", null, value);
                this.OnPropertyChanged("kbarticle_comments");
            }
        }

        /// <summary>
        /// N:1 lk_kbarticlecomment_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_kbarticlecomment_createdonbehalfby")]
        public SystemUser lk_kbarticlecomment_createdonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_kbarticlecomment_createdonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_kbarticlecomment_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_kbarticlecomment_modifiedonbehalfby")]
        public SystemUser lk_kbarticlecomment_modifiedonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_kbarticlecomment_modifiedonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_kbarticlecommentbase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_kbarticlecommentbase_createdby")]
        public SystemUser lk_kbarticlecommentbase_createdby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_kbarticlecommentbase_createdby", null); }
        }

        /// <summary>
        /// N:1 lk_kbarticlecommentbase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_kbarticlecommentbase_modifiedby")]
        public SystemUser lk_kbarticlecommentbase_modifiedby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_kbarticlecommentbase_modifiedby", null); }
        }
    }
}