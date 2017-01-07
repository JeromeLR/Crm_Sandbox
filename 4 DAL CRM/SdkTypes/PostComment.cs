namespace __4_DAL_CRM
{
    /// <summary>
    /// A comment on an activity feed post.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("postcomment")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class PostComment : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public PostComment() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "postcomment";

        public const int EntityTypeCode = 8005;

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
        /// Unique identifier of the user who created the record.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby"); }
        }

        /// <summary>
        /// Date and time when the record was created.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
        public System.Nullable<System.DateTime> CreatedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who created the record.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby"); }
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
        /// Shows the ID of the post comment.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("postcommentid")]
        public System.Nullable<System.Guid> PostCommentId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("postcommentid"); }
            set
            {
                this.OnPropertyChanging("PostCommentId");
                this.SetAttributeValue("postcommentid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("PostCommentId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("postcommentid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.PostCommentId = value; }
        }

        /// <summary>
        /// Unique identifier of the post with which the comment is associated.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("postid")]
        public Microsoft.Xrm.Sdk.EntityReference PostId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("postid"); }
            set
            {
                this.OnPropertyChanging("PostId");
                this.SetAttributeValue("postid", value);
                this.OnPropertyChanged("PostId");
            }
        }

        /// <summary>
        /// Text of the comment.
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
        /// N:1 lk_postcomment_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_postcomment_createdby")]
        public SystemUser lk_postcomment_createdby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_postcomment_createdby", null); }
        }

        /// <summary>
        /// N:1 lk_postcomment_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_postcomment_createdonbehalfby")]
        public SystemUser lk_postcomment_createdonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_postcomment_createdonbehalfby", null); }
        }

        /// <summary>
        /// N:1 organization_PostComment
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_PostComment")]
        public Organization organization_PostComment
        {
            get { return this.GetRelatedEntity<Organization>("organization_PostComment", null); }
        }

        /// <summary>
        /// N:1 Post_Comments
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("postid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Post_Comments")]
        public Post Post_Comments
        {
            get { return this.GetRelatedEntity<Post>("Post_Comments", null); }
            set
            {
                this.OnPropertyChanging("Post_Comments");
                this.SetRelatedEntity<Post>("Post_Comments", null, value);
                this.OnPropertyChanged("Post_Comments");
            }
        }
    }
}