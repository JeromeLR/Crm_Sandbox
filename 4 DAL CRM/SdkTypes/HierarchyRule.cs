namespace __4_DAL_CRM
{
    /// <summary>
    /// Organization-owned entity customizations including mapping Quick view form with Relationship Id
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("hierarchyrule")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class HierarchyRule : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public HierarchyRule() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "hierarchyrule";

        public const int EntityTypeCode = 8840;

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
        /// Description of the hierarchy rule.
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
        /// Unique identifier of the record type hierarchy rule.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("hierarchyruleid")]
        public System.Nullable<System.Guid> HierarchyRuleID
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("hierarchyruleid"); }
            set
            {
                this.OnPropertyChanging("HierarchyRuleID");
                this.SetAttributeValue("hierarchyruleid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("HierarchyRuleID");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("hierarchyruleid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.HierarchyRuleID = value; }
        }

        /// <summary>
        /// Unique identifier of the hierarchy rule used when synchronizing customizations for the Microsoft Dynamics CRM client for Outlook
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("hierarchyruleidunique")]
        public System.Nullable<System.Guid> HierarchyRuleIDUnique
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("hierarchyruleidunique"); }
        }

        /// <summary>
        /// Version in which the hierarchy rule is introduced.
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
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ismanaged")]
        public System.Nullable<bool> IsManaged
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("ismanaged"); }
        }

        /// <summary>
        /// Name of the hierarchy rule.
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
        /// Unique identifier of the organization.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
        public Microsoft.Xrm.Sdk.EntityReference OrganizationId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("organizationid"); }
        }

        /// <summary>
        /// Date and time when the record was created.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("overwritetime")]
        public System.Nullable<System.DateTime> OverwriteTime
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("overwritetime"); }
        }

        /// <summary>
        /// Form Id for the Primary Entity
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("primaryentityformid")]
        public System.Nullable<System.Guid> PrimaryEntityFormID
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("primaryentityformid"); }
            set
            {
                this.OnPropertyChanging("PrimaryEntityFormID");
                this.SetAttributeValue("primaryentityformid", value);
                this.OnPropertyChanged("PrimaryEntityFormID");
            }
        }

        /// <summary>
        /// Logical Name for the Primary entity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("primaryentitylogicalname")]
        public string PrimaryEntityLogicalName
        {
            get { return this.GetAttributeValue<string>("primaryentitylogicalname"); }
            set
            {
                this.OnPropertyChanging("PrimaryEntityLogicalName");
                this.SetAttributeValue("primaryentitylogicalname", value);
                this.OnPropertyChanged("PrimaryEntityLogicalName");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("publishedon")]
        public System.Nullable<System.DateTime> PublishedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("publishedon"); }
        }

        /// <summary>
        /// Form Id for the Related Entity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("relatedentityformid")]
        public System.Nullable<System.Guid> RelatedEntityFormId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("relatedentityformid"); }
        }

        /// <summary>
        /// Logical Name for the Related entity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("relatedentitylogicalname")]
        public string RelatedEntityLogicalName
        {
            get { return this.GetAttributeValue<string>("relatedentitylogicalname"); }
        }

        /// <summary>
        /// To show disabled records or not.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("showdisabled")]
        public System.Nullable<bool> ShowDisabled
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("showdisabled"); }
            set
            {
                this.OnPropertyChanging("ShowDisabled");
                this.SetAttributeValue("showdisabled", value);
                this.OnPropertyChanged("ShowDisabled");
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
        /// columns to sort in the primary entity
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sortby")]
        public System.Nullable<System.Guid> SortBy
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("sortby"); }
        }

        /// <summary>
        /// Version number of the Hierarchy rule.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
        public System.Nullable<long> VersionNumber
        {
            get { return this.GetAttributeValue<System.Nullable<long>>("versionnumber"); }
        }

        /// <summary>
        /// N:1 organization_hierarchyrules
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_hierarchyrules")]
        public Organization organization_hierarchyrules
        {
            get { return this.GetRelatedEntity<Organization>("organization_hierarchyrules", null); }
        }
    }
}