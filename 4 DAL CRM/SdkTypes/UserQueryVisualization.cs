namespace __4_DAL_CRM
{
    /// <summary>
    /// Chart attached to an entity.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("userqueryvisualization")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class UserQueryVisualization : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public UserQueryVisualization() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "userqueryvisualization";

        public const int EntityTypeCode = 1112;

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
        /// Shows the fields that are used to display data in a chart, stored in XML format.
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
        /// Type additional information to describe the chart, such as the filter criteria or intended audience.
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
        /// Select whether the chart is the default chart for the view that it is associated with.
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
        /// Shows who last updated the record.
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
        /// Shows who created the record on behalf of another user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        /// Type a descriptive name for the chart.
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
        /// Enter the user or team who is assigned to manage the record. This field is updated every time the record is assigned to a different user.
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
        /// Shows the business unit that the record owner belongs to.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
        public Microsoft.Xrm.Sdk.EntityReference OwningBusinessUnit
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningbusinessunit"); }
        }

        /// <summary>
        /// Unique identifier of the team who owns the user chart.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
        public Microsoft.Xrm.Sdk.EntityReference OwningTeam
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningteam"); }
        }

        /// <summary>
        /// Unique identifier of the team who owns the user chart.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
        public Microsoft.Xrm.Sdk.EntityReference OwningUser
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owninguser"); }
        }

        /// <summary>
        /// Contains the chart's formatting details and presentation properties, stored in XML format.
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
        /// Type of entity which the user chart is attached.
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
        /// Unique identifier of the user chart.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("userqueryvisualizationid")]
        public System.Nullable<System.Guid> UserQueryVisualizationId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("userqueryvisualizationid"); }
            set
            {
                this.OnPropertyChanging("UserQueryVisualizationId");
                this.SetAttributeValue("userqueryvisualizationid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("UserQueryVisualizationId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("userqueryvisualizationid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.UserQueryVisualizationId = value; }
        }

        /// <summary>
        /// Version number of the user chart.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
        public System.Nullable<long> VersionNumber
        {
            get { return this.GetAttributeValue<System.Nullable<long>>("versionnumber"); }
        }

        /// <summary>
        /// Shows the web resource that will be displayed in the chart to the user.
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
        /// 1:N userentityinstancedata_userqueryvisualization
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_userqueryvisualization")]
        public System.Collections.Generic.IEnumerable<UserEntityInstanceData> userentityinstancedata_userqueryvisualization
        {
            get { return this.GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_userqueryvisualization", null); }
            set
            {
                this.OnPropertyChanging("userentityinstancedata_userqueryvisualization");
                this.SetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_userqueryvisualization", null, value);
                this.OnPropertyChanged("userentityinstancedata_userqueryvisualization");
            }
        }

        /// <summary>
        /// N:1 business_unit_userqueryvisualizations
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_userqueryvisualizations")]
        public BusinessUnit business_unit_userqueryvisualizations
        {
            get { return this.GetRelatedEntity<BusinessUnit>("business_unit_userqueryvisualizations", null); }
        }

        /// <summary>
        /// N:1 lk_userqueryvisualization_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_userqueryvisualization_createdby")]
        public SystemUser lk_userqueryvisualization_createdby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_userqueryvisualization_createdby", null); }
        }

        /// <summary>
        /// N:1 lk_userqueryvisualization_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_userqueryvisualization_modifiedby")]
        public SystemUser lk_userqueryvisualization_modifiedby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_userqueryvisualization_modifiedby", null); }
        }

        /// <summary>
        /// N:1 lk_userqueryvisualizationbase_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_userqueryvisualizationbase_createdonbehalfby")]
        public SystemUser lk_userqueryvisualizationbase_createdonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_userqueryvisualizationbase_createdonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_userqueryvisualizationbase_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_userqueryvisualizationbase_modifiedonbehalfby")]
        public SystemUser lk_userqueryvisualizationbase_modifiedonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_userqueryvisualizationbase_modifiedonbehalfby", null); }
        }

        /// <summary>
        /// N:1 team_userqueryvisualizations
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_userqueryvisualizations")]
        public Team team_userqueryvisualizations
        {
            get { return this.GetRelatedEntity<Team>("team_userqueryvisualizations", null); }
        }

        /// <summary>
        /// N:1 user_userqueryvisualizations
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_userqueryvisualizations")]
        public SystemUser user_userqueryvisualizations
        {
            get { return this.GetRelatedEntity<SystemUser>("user_userqueryvisualizations", null); }
        }

        /// <summary>
        /// N:1 webresource_userqueryvisualizations
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("webresourceid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("webresource_userqueryvisualizations")]
        public WebResource webresource_userqueryvisualizations
        {
            get { return this.GetRelatedEntity<WebResource>("webresource_userqueryvisualizations", null); }
            set
            {
                this.OnPropertyChanging("webresource_userqueryvisualizations");
                this.SetRelatedEntity<WebResource>("webresource_userqueryvisualizations", null, value);
                this.OnPropertyChanged("webresource_userqueryvisualizations");
            }
        }
    }
}