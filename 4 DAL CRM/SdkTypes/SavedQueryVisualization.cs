namespace __4_DAL_CRM
{
    /// <summary>
    /// System chart attached to an entity.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("savedqueryvisualization")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class SavedQueryVisualization : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public SavedQueryVisualization() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "savedqueryvisualization";

        public const int EntityTypeCode = 1111;

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
        /// Unique identifier of the user who created the system chart.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby"); }
        }

        /// <summary>
        /// Date and time when the system chart was created.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
        public System.Nullable<System.DateTime> CreatedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who created the system chart.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        /// XML string used to define the underlying data for the system chart.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("datadescription")]
        public string DataDescription
        {
            get { return this.GetAttributeValue<string>("datadescription"); }
            set
            {
                this.OnPropertyChanging("DataDescription");
                this.SetAttributeValue("datadescription", value);
                this.OnPropertyChanged("DataDescription");
            }
        }

        /// <summary>
        /// Description of the system chart.
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
        /// Indicates whether the system chart is the default chart for the entity.
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
        /// Indicates whether the solution component is part of a managed solution.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ismanaged")]
        public System.Nullable<bool> IsManaged
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("ismanaged"); }
        }

        /// <summary>
        /// Unique identifier of the user who last modified the system chart.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby"); }
        }

        /// <summary>
        /// Date and time when the system chart was last modified.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
        public System.Nullable<System.DateTime> ModifiedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who last modified the system chart.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        /// Name of the system chart.
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
        /// Unique identifier of the organization associated with the system chart.
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
        /// XML string used to define the presentation properties of the system chart.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("presentationdescription")]
        public string PresentationDescription
        {
            get { return this.GetAttributeValue<string>("presentationdescription"); }
            set
            {
                this.OnPropertyChanging("PresentationDescription");
                this.SetAttributeValue("presentationdescription", value);
                this.OnPropertyChanged("PresentationDescription");
            }
        }

        /// <summary>
        /// Type of entity with which the system chart is attached.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("primaryentitytypecode")]
        public string PrimaryEntityTypeCode
        {
            get { return this.GetAttributeValue<string>("primaryentitytypecode"); }
            set
            {
                this.OnPropertyChanging("PrimaryEntityTypeCode");
                this.SetAttributeValue("primaryentitytypecode", value);
                this.OnPropertyChanged("PrimaryEntityTypeCode");
            }
        }

        /// <summary>
        /// Unique identifier of the system chart.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("savedqueryvisualizationid")]
        public System.Nullable<System.Guid> SavedQueryVisualizationId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("savedqueryvisualizationid"); }
            set
            {
                this.OnPropertyChanging("SavedQueryVisualizationId");
                this.SetAttributeValue("savedqueryvisualizationid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("SavedQueryVisualizationId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("savedqueryvisualizationid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.SavedQueryVisualizationId = value; }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("savedqueryvisualizationidunique")]
        public System.Nullable<System.Guid> SavedQueryVisualizationIdUnique
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("savedqueryvisualizationidunique"); }
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
        /// Version number of the system chart.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
        public System.Nullable<long> VersionNumber
        {
            get { return this.GetAttributeValue<System.Nullable<long>>("versionnumber"); }
        }

        /// <summary>
        /// Unique identifier of the Web resource that will be displayed in the system chart.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("webresourceid")]
        public Microsoft.Xrm.Sdk.EntityReference WebResourceId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("webresourceid"); }
            set
            {
                this.OnPropertyChanging("WebResourceId");
                this.SetAttributeValue("webresourceid", value);
                this.OnPropertyChanged("WebResourceId");
            }
        }

        /// <summary>
        /// 1:N userentityinstancedata_savedqueryvisualization
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_savedqueryvisualization")]
        public System.Collections.Generic.IEnumerable<UserEntityInstanceData> userentityinstancedata_savedqueryvisualization
        {
            get { return this.GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_savedqueryvisualization", null); }
            set
            {
                this.OnPropertyChanging("userentityinstancedata_savedqueryvisualization");
                this.SetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_savedqueryvisualization", null, value);
                this.OnPropertyChanged("userentityinstancedata_savedqueryvisualization");
            }
        }

        /// <summary>
        /// N:1 lk_savedqueryvisualizationbase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_savedqueryvisualizationbase_createdby")]
        public SystemUser lk_savedqueryvisualizationbase_createdby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_savedqueryvisualizationbase_createdby", null); }
        }

        /// <summary>
        /// N:1 lk_savedqueryvisualizationbase_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_savedqueryvisualizationbase_createdonbehalfby")]
        public SystemUser lk_savedqueryvisualizationbase_createdonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_savedqueryvisualizationbase_createdonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_savedqueryvisualizationbase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_savedqueryvisualizationbase_modifiedby")]
        public SystemUser lk_savedqueryvisualizationbase_modifiedby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_savedqueryvisualizationbase_modifiedby", null); }
        }

        /// <summary>
        /// N:1 lk_savedqueryvisualizationbase_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_savedqueryvisualizationbase_modifiedonbehalfby")]
        public SystemUser lk_savedqueryvisualizationbase_modifiedonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_savedqueryvisualizationbase_modifiedonbehalfby", null); }
        }

        /// <summary>
        /// N:1 organization_saved_query_visualizations
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_saved_query_visualizations")]
        public Organization organization_saved_query_visualizations
        {
            get { return this.GetRelatedEntity<Organization>("organization_saved_query_visualizations", null); }
        }

        /// <summary>
        /// N:1 webresource_savedqueryvisualizations
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("webresourceid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("webresource_savedqueryvisualizations")]
        public WebResource webresource_savedqueryvisualizations
        {
            get { return this.GetRelatedEntity<WebResource>("webresource_savedqueryvisualizations", null); }
            set
            {
                this.OnPropertyChanging("webresource_savedqueryvisualizations");
                this.SetRelatedEntity<WebResource>("webresource_savedqueryvisualizations", null, value);
                this.OnPropertyChanged("webresource_savedqueryvisualizations");
            }
        }
    }
}