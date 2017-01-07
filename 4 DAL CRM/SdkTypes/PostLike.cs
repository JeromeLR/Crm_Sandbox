namespace __4_DAL_CRM
{
    /// <summary>
    /// A like on an activity feed post.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("postlike")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class PostLike : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public PostLike() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "postlike";

        public const int EntityTypeCode = 8006;

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
        /// Unique identifier of the post with which the like is associated.
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
        /// Shows the ID of the post like.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("postlikeid")]
        public System.Nullable<System.Guid> PostLikeId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("postlikeid"); }
            set
            {
                this.OnPropertyChanging("PostLikeId");
                this.SetAttributeValue("postlikeid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("PostLikeId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("postlikeid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.PostLikeId = value; }
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
        /// N:1 lk_postlike_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_postlike_createdby")]
        public SystemUser lk_postlike_createdby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_postlike_createdby", null); }
        }

        /// <summary>
        /// N:1 lk_postlike_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_postlike_createdonbehalfby")]
        public SystemUser lk_postlike_createdonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_postlike_createdonbehalfby", null); }
        }

        /// <summary>
        /// N:1 organization_postlike
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_postlike")]
        public Organization organization_postlike
        {
            get { return this.GetRelatedEntity<Organization>("organization_postlike", null); }
        }

        /// <summary>
        /// N:1 Post_Likes
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("postid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Post_Likes")]
        public Post Post_Likes
        {
            get { return this.GetRelatedEntity<Post>("Post_Likes", null); }
            set
            {
                this.OnPropertyChanging("Post_Likes");
                this.SetRelatedEntity<Post>("Post_Likes", null, value);
                this.OnPropertyChanged("Post_Likes");
            }
        }
    }
}