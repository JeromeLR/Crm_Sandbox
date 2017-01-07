namespace __4_DAL_CRM
{
    /// <summary>
    /// Data equivalent to files used in Web development. Web resources provide client-side components that are used to provide custom user interface elements.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("webresource")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class WebResource : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public WebResource() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "webresource";

        public const int EntityTypeCode = 9333;

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
        /// Information that specifies whether this component can be deleted.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("canbedeleted")]
        public Microsoft.Xrm.Sdk.BooleanManagedProperty CanBeDeleted
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.BooleanManagedProperty>("canbedeleted"); }
            set
            {
                this.OnPropertyChanging("CanBeDeleted");
                this.SetAttributeValue("canbedeleted", value);
                this.OnPropertyChanged("CanBeDeleted");
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
        /// Bytes of the web resource, in Base64 format.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("content")]
        public string Content
        {
            get { return this.GetAttributeValue<string>("content"); }
            set
            {
                this.OnPropertyChanging("Content");
                this.SetAttributeValue("content", value);
                this.OnPropertyChanged("Content");
            }
        }

        /// <summary>
        /// Unique identifier of the user who created the web resource.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby"); }
        }

        /// <summary>
        /// Date and time when the web resource was created.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
        public System.Nullable<System.DateTime> CreatedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who created the web resource.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        /// Description of the web resource.
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
        /// Display name of the web resource.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("displayname")]
        public string DisplayName
        {
            get { return this.GetAttributeValue<string>("displayname"); }
            set
            {
                this.OnPropertyChanging("DisplayName");
                this.SetAttributeValue("displayname", value);
                this.OnPropertyChanged("DisplayName");
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
        /// Information that specifies whether this web resource is enabled for mobile client.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isenabledformobileclient")]
        public System.Nullable<bool> IsEnabledForMobileClient
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("isenabledformobileclient"); }
            set
            {
                this.OnPropertyChanging("IsEnabledForMobileClient");
                this.SetAttributeValue("isenabledformobileclient", value);
                this.OnPropertyChanged("IsEnabledForMobileClient");
            }
        }

        /// <summary>
        /// Information that specifies whether this component should be hidden.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ishidden")]
        public Microsoft.Xrm.Sdk.BooleanManagedProperty IsHidden
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.BooleanManagedProperty>("ishidden"); }
            set
            {
                this.OnPropertyChanging("IsHidden");
                this.SetAttributeValue("ishidden", value);
                this.OnPropertyChanged("IsHidden");
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
        /// Language of the web resource.
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
        /// Unique identifier of the user who last modified the web resource.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby"); }
        }

        /// <summary>
        /// Date and time when the web resource was last modified.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
        public System.Nullable<System.DateTime> ModifiedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who modified the web resource.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        /// Name of the web resource.
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
        /// Unique identifier of the organization associated with the web resource.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
        public Microsoft.Xrm.Sdk.EntityReference OrganizationId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("organizationid"); }
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
        /// Silverlight runtime version number required by a silverlight web resource.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("silverlightversion")]
        public string SilverlightVersion
        {
            get { return this.GetAttributeValue<string>("silverlightversion"); }
            set
            {
                this.OnPropertyChanging("SilverlightVersion");
                this.SetAttributeValue("silverlightversion", value);
                this.OnPropertyChanged("SilverlightVersion");
            }
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
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
        public System.Nullable<long> VersionNumber
        {
            get { return this.GetAttributeValue<System.Nullable<long>>("versionnumber"); }
        }

        /// <summary>
        /// Unique identifier of the web resource.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("webresourceid")]
        public System.Nullable<System.Guid> WebResourceId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("webresourceid"); }
            set
            {
                this.OnPropertyChanging("WebResourceId");
                this.SetAttributeValue("webresourceid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("WebResourceId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("webresourceid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.WebResourceId = value; }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("webresourceidunique")]
        public System.Nullable<System.Guid> WebResourceIdUnique
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("webresourceidunique"); }
        }

        /// <summary>
        /// Drop-down list for selecting the type of the web resource.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("webresourcetype")]
        public Microsoft.Xrm.Sdk.OptionSetValue WebResourceType
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("webresourcetype"); }
            set
            {
                this.OnPropertyChanging("WebResourceType");
                this.SetAttributeValue("webresourcetype", value);
                this.OnPropertyChanged("WebResourceType");
            }
        }

        /// <summary>
        /// 1:N solution_configuration_webresource
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("solution_configuration_webresource")]
        public System.Collections.Generic.IEnumerable<Solution> solution_configuration_webresource
        {
            get { return this.GetRelatedEntities<Solution>("solution_configuration_webresource", null); }
            set
            {
                this.OnPropertyChanging("solution_configuration_webresource");
                this.SetRelatedEntities<Solution>("solution_configuration_webresource", null, value);
                this.OnPropertyChanged("solution_configuration_webresource");
            }
        }

        /// <summary>
        /// 1:N userentityinstancedata_webresource
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_webresource")]
        public System.Collections.Generic.IEnumerable<UserEntityInstanceData> userentityinstancedata_webresource
        {
            get { return this.GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_webresource", null); }
            set
            {
                this.OnPropertyChanging("userentityinstancedata_webresource");
                this.SetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_webresource", null, value);
                this.OnPropertyChanged("userentityinstancedata_webresource");
            }
        }

        /// <summary>
        /// 1:N webresource_savedqueryvisualizations
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("webresource_savedqueryvisualizations")]
        public System.Collections.Generic.IEnumerable<SavedQueryVisualization> webresource_savedqueryvisualizations
        {
            get { return this.GetRelatedEntities<SavedQueryVisualization>("webresource_savedqueryvisualizations", null); }
            set
            {
                this.OnPropertyChanging("webresource_savedqueryvisualizations");
                this.SetRelatedEntities<SavedQueryVisualization>("webresource_savedqueryvisualizations", null, value);
                this.OnPropertyChanged("webresource_savedqueryvisualizations");
            }
        }

        /// <summary>
        /// 1:N webresource_userqueryvisualizations
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("webresource_userqueryvisualizations")]
        public System.Collections.Generic.IEnumerable<UserQueryVisualization> webresource_userqueryvisualizations
        {
            get { return this.GetRelatedEntities<UserQueryVisualization>("webresource_userqueryvisualizations", null); }
            set
            {
                this.OnPropertyChanging("webresource_userqueryvisualizations");
                this.SetRelatedEntities<UserQueryVisualization>("webresource_userqueryvisualizations", null, value);
                this.OnPropertyChanged("webresource_userqueryvisualizations");
            }
        }

        /// <summary>
        /// N:1 lk_webresourcebase_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_webresourcebase_createdonbehalfby")]
        public SystemUser lk_webresourcebase_createdonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_webresourcebase_createdonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_webresourcebase_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_webresourcebase_modifiedonbehalfby")]
        public SystemUser lk_webresourcebase_modifiedonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_webresourcebase_modifiedonbehalfby", null); }
        }

        /// <summary>
        /// N:1 webresource_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("webresource_createdby")]
        public SystemUser webresource_createdby
        {
            get { return this.GetRelatedEntity<SystemUser>("webresource_createdby", null); }
        }

        /// <summary>
        /// N:1 webresource_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("webresource_modifiedby")]
        public SystemUser webresource_modifiedby
        {
            get { return this.GetRelatedEntity<SystemUser>("webresource_modifiedby", null); }
        }

        /// <summary>
        /// N:1 webresource_organization
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("webresource_organization")]
        public Organization webresource_organization
        {
            get { return this.GetRelatedEntity<Organization>("webresource_organization", null); }
        }
    }
}