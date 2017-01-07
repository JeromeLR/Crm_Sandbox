namespace __4_DAL_CRM
{
    /// <summary>
    /// An activity feed post.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("post")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class Post : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public Post() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "post";

        public const int EntityTypeCode = 8000;

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
        /// Unique identifier of the user who modified the record.
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
        /// Unique identifier of the delegate user who modified the record.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        /// Unique identifier of the organization associated with the solution.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
        public Microsoft.Xrm.Sdk.EntityReference OrganizationId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("organizationid"); }
        }

        /// <summary>
        /// Unique identifier for entity instances
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("postid")]
        public System.Nullable<System.Guid> PostId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("postid"); }
            set
            {
                this.OnPropertyChanging("PostId");
                this.SetAttributeValue("postid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("PostId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("postid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.PostId = value; }
        }

        /// <summary>
        /// Choose the parent record for the post to identify the customer, opportunity, case, or other record that the post most closely relates to.
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
        /// Unique identifier of the user or team who owns the regarding object.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectownerid")]
        public Microsoft.Xrm.Sdk.EntityReference RegardingObjectOwnerId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("regardingobjectownerid"); }
        }

        /// <summary>
        /// Unique identifier of the business unit that owns the regarding object.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectowningbusinessunit")]
        public Microsoft.Xrm.Sdk.EntityReference RegardingObjectOwningBusinessUnit
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("regardingobjectowningbusinessunit"); }
        }

        /// <summary>
        /// Select whether the post was created manually or automatically.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("source")]
        public Microsoft.Xrm.Sdk.OptionSetValue Source
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("source"); }
            set
            {
                this.OnPropertyChanging("Source");
                this.SetAttributeValue("source", value);
                this.OnPropertyChanged("Source");
            }
        }

        /// <summary>
        /// Shows the text of a post. If this is a manual post, it appears in plain text. If this is an auto post, it appears in XML.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("text")]
        public string Text
        {
            get { return this.GetAttributeValue<string>("text"); }
            set
            {
                this.OnPropertyChanging("Text");
                this.SetAttributeValue("text", value);
                this.OnPropertyChanged("Text");
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
        /// Select the post type.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("type")]
        public Microsoft.Xrm.Sdk.OptionSetValue Type
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("type"); }
            set
            {
                this.OnPropertyChanging("Type");
                this.SetAttributeValue("type", value);
                this.OnPropertyChanged("Type");
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
        /// 1:N post_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("post_AsyncOperations")]
        public System.Collections.Generic.IEnumerable<AsyncOperation> post_AsyncOperations
        {
            get { return this.GetRelatedEntities<AsyncOperation>("post_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("post_AsyncOperations");
                this.SetRelatedEntities<AsyncOperation>("post_AsyncOperations", null, value);
                this.OnPropertyChanged("post_AsyncOperations");
            }
        }

        /// <summary>
        /// 1:N post_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("post_BulkDeleteFailures")]
        public System.Collections.Generic.IEnumerable<BulkDeleteFailure> post_BulkDeleteFailures
        {
            get { return this.GetRelatedEntities<BulkDeleteFailure>("post_BulkDeleteFailures", null); }
            set
            {
                this.OnPropertyChanging("post_BulkDeleteFailures");
                this.SetRelatedEntities<BulkDeleteFailure>("post_BulkDeleteFailures", null, value);
                this.OnPropertyChanged("post_BulkDeleteFailures");
            }
        }

        /// <summary>
        /// 1:N Post_Comments
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Post_Comments")]
        public System.Collections.Generic.IEnumerable<PostComment> Post_Comments
        {
            get { return this.GetRelatedEntities<PostComment>("Post_Comments", null); }
            set
            {
                this.OnPropertyChanging("Post_Comments");
                this.SetRelatedEntities<PostComment>("Post_Comments", null, value);
                this.OnPropertyChanged("Post_Comments");
            }
        }

        /// <summary>
        /// 1:N Post_Likes
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Post_Likes")]
        public System.Collections.Generic.IEnumerable<PostLike> Post_Likes
        {
            get { return this.GetRelatedEntities<PostLike>("Post_Likes", null); }
            set
            {
                this.OnPropertyChanging("Post_Likes");
                this.SetRelatedEntities<PostLike>("Post_Likes", null, value);
                this.OnPropertyChanged("Post_Likes");
            }
        }

        /// <summary>
        /// N:1 lk_post_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_post_createdby")]
        public SystemUser lk_post_createdby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_post_createdby", null); }
        }

        /// <summary>
        /// N:1 lk_post_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_post_createdonbehalfby")]
        public SystemUser lk_post_createdonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_post_createdonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_post_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_post_modifiedby")]
        public SystemUser lk_post_modifiedby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_post_modifiedby", null); }
        }

        /// <summary>
        /// N:1 lk_post_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_post_modifiedonbehalfby")]
        public SystemUser lk_post_modifiedonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_post_modifiedonbehalfby", null); }
        }

        /// <summary>
        /// N:1 organization_post
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_post")]
        public Organization organization_post
        {
            get { return this.GetRelatedEntity<Organization>("organization_post", null); }
        }
    }
}