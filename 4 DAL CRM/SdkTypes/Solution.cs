namespace __4_DAL_CRM
{
    /// <summary>
    /// A solution which contains CRM customizations.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("solution")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class Solution : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public Solution() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "solution";

        public const int EntityTypeCode = 7100;

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
        /// A link to an optional configuration page for this solution.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("configurationpageid")]
        public Microsoft.Xrm.Sdk.EntityReference ConfigurationPageId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("configurationpageid"); }
            set
            {
                this.OnPropertyChanging("ConfigurationPageId");
                this.SetAttributeValue("configurationpageid", value);
                this.OnPropertyChanged("ConfigurationPageId");
            }
        }

        /// <summary>
        /// Unique identifier of the user who created the solution.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby"); }
        }

        /// <summary>
        /// Date and time when the solution was created.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
        public System.Nullable<System.DateTime> CreatedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who created the solution.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        /// Description of the solution.
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
        /// User display name for the solution.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("friendlyname")]
        public string FriendlyName
        {
            get { return this.GetAttributeValue<string>("friendlyname"); }
            set
            {
                this.OnPropertyChanging("FriendlyName");
                this.SetAttributeValue("friendlyname", value);
                this.OnPropertyChanged("FriendlyName");
            }
        }

        /// <summary>
        /// Date and time when the solution was installed/upgraded.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("installedon")]
        public System.Nullable<System.DateTime> InstalledOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("installedon"); }
        }

        /// <summary>
        /// Indicates whether the solution is managed or unmanaged.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ismanaged")]
        public System.Nullable<bool> IsManaged
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("ismanaged"); }
        }

        /// <summary>
        /// Indicates whether the solution is visible outside of the platform.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isvisible")]
        public System.Nullable<bool> IsVisible
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("isvisible"); }
        }

        /// <summary>
        /// Unique identifier of the user who last modified the solution.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby"); }
        }

        /// <summary>
        /// Date and time when the solution was last modified.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
        public System.Nullable<System.DateTime> ModifiedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who modified the solution.
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
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("pinpointassetid")]
        public string PinpointAssetId
        {
            get { return this.GetAttributeValue<string>("pinpointassetid"); }
        }

        /// <summary>
        /// Identifier of the publisher of this solution in Microsoft Pinpoint.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("pinpointpublisherid")]
        public System.Nullable<long> PinpointPublisherId
        {
            get { return this.GetAttributeValue<System.Nullable<long>>("pinpointpublisherid"); }
        }

        /// <summary>
        /// Default locale of the solution in Microsoft Pinpoint.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("pinpointsolutiondefaultlocale")]
        public string PinpointSolutionDefaultLocale
        {
            get { return this.GetAttributeValue<string>("pinpointsolutiondefaultlocale"); }
        }

        /// <summary>
        /// Identifier of the solution in Microsoft Pinpoint.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("pinpointsolutionid")]
        public System.Nullable<long> PinpointSolutionId
        {
            get { return this.GetAttributeValue<System.Nullable<long>>("pinpointsolutionid"); }
        }

        /// <summary>
        /// Unique identifier of the publisher.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("publisherid")]
        public Microsoft.Xrm.Sdk.EntityReference PublisherId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("publisherid"); }
            set
            {
                this.OnPropertyChanging("PublisherId");
                this.SetAttributeValue("publisherid", value);
                this.OnPropertyChanged("PublisherId");
            }
        }

        /// <summary>
        /// Unique identifier of the solution.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("solutionid")]
        public System.Nullable<System.Guid> SolutionId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("solutionid"); }
            set
            {
                this.OnPropertyChanging("SolutionId");
                this.SetAttributeValue("solutionid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("SolutionId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("solutionid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.SolutionId = value; }
        }

        /// <summary>
        /// The unique name of this solution
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("uniquename")]
        public string UniqueName
        {
            get { return this.GetAttributeValue<string>("uniquename"); }
            set
            {
                this.OnPropertyChanging("UniqueName");
                this.SetAttributeValue("uniquename", value);
                this.OnPropertyChanged("UniqueName");
            }
        }

        /// <summary>
        /// Solution version, used to identify a solution for upgrades and hotfixes.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("version")]
        public string Version
        {
            get { return this.GetAttributeValue<string>("version"); }
            set
            {
                this.OnPropertyChanging("Version");
                this.SetAttributeValue("version", value);
                this.OnPropertyChanged("Version");
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
        /// 1:N solution_solutioncomponent
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("solution_solutioncomponent")]
        public System.Collections.Generic.IEnumerable<SolutionComponent> solution_solutioncomponent
        {
            get { return this.GetRelatedEntities<SolutionComponent>("solution_solutioncomponent", null); }
            set
            {
                this.OnPropertyChanging("solution_solutioncomponent");
                this.SetRelatedEntities<SolutionComponent>("solution_solutioncomponent", null, value);
                this.OnPropertyChanged("solution_solutioncomponent");
            }
        }

        /// <summary>
        /// 1:N userentityinstancedata_solution
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_solution")]
        public System.Collections.Generic.IEnumerable<UserEntityInstanceData> userentityinstancedata_solution
        {
            get { return this.GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_solution", null); }
            set
            {
                this.OnPropertyChanging("userentityinstancedata_solution");
                this.SetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_solution", null, value);
                this.OnPropertyChanged("userentityinstancedata_solution");
            }
        }

        /// <summary>
        /// N:1 lk_solution_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_solution_createdby")]
        public SystemUser lk_solution_createdby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_solution_createdby", null); }
        }

        /// <summary>
        /// N:1 lk_solution_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_solution_modifiedby")]
        public SystemUser lk_solution_modifiedby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_solution_modifiedby", null); }
        }

        /// <summary>
        /// N:1 lk_solutionbase_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_solutionbase_createdonbehalfby")]
        public SystemUser lk_solutionbase_createdonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_solutionbase_createdonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_solutionbase_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_solutionbase_modifiedonbehalfby")]
        public SystemUser lk_solutionbase_modifiedonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_solutionbase_modifiedonbehalfby", null); }
        }

        /// <summary>
        /// N:1 organization_solution
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_solution")]
        public Organization organization_solution
        {
            get { return this.GetRelatedEntity<Organization>("organization_solution", null); }
        }

        /// <summary>
        /// N:1 publisher_solution
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("publisherid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("publisher_solution")]
        public Publisher publisher_solution
        {
            get { return this.GetRelatedEntity<Publisher>("publisher_solution", null); }
            set
            {
                this.OnPropertyChanging("publisher_solution");
                this.SetRelatedEntity<Publisher>("publisher_solution", null, value);
                this.OnPropertyChanged("publisher_solution");
            }
        }

        /// <summary>
        /// N:1 solution_configuration_webresource
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("configurationpageid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("solution_configuration_webresource")]
        public WebResource solution_configuration_webresource
        {
            get { return this.GetRelatedEntity<WebResource>("solution_configuration_webresource", null); }
            set
            {
                this.OnPropertyChanging("solution_configuration_webresource");
                this.SetRelatedEntity<WebResource>("solution_configuration_webresource", null, value);
                this.OnPropertyChanged("solution_configuration_webresource");
            }
        }
    }
}