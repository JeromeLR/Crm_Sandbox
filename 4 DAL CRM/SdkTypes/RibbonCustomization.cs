namespace __4_DAL_CRM
{
    /// <summary>
    /// Ribbon customizations for the application ribbon and entity ribbon templates.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("ribboncustomization")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class RibbonCustomization : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public RibbonCustomization() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "ribboncustomization";

        public const int EntityTypeCode = 1120;

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
        /// Specifies which entity's ribbons this customization applies to. If null, then the customizations apply to the global ribbons.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entity")]
        public string Entity
        {
            get { return this.GetAttributeValue<string>("entity"); }
            set
            {
                this.OnPropertyChanging("Entity");
                this.SetAttributeValue("entity", value);
                this.OnPropertyChanged("Entity");
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
        /// Unique identifier of the organization.
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
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("publishedon")]
        public System.Nullable<System.DateTime> PublishedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("publishedon"); }
        }

        /// <summary>
        /// Unique identifier.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ribboncustomizationid")]
        public System.Nullable<System.Guid> RibbonCustomizationId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("ribboncustomizationid"); }
            set
            {
                this.OnPropertyChanging("RibbonCustomizationId");
                this.SetAttributeValue("ribboncustomizationid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("RibbonCustomizationId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ribboncustomizationid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.RibbonCustomizationId = value; }
        }

        /// <summary>
        /// Unique identifier for this row.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ribboncustomizationuniqueid")]
        public System.Nullable<System.Guid> RibbonCustomizationUniqueId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("ribboncustomizationuniqueid"); }
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
        /// Represents a version of customizations to be synchronized with the Microsoft Dynamics CRM client for Outlook.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
        public System.Nullable<long> VersionNumber
        {
            get { return this.GetAttributeValue<System.Nullable<long>>("versionnumber"); }
        }

        /// <summary>
        /// 1:N userentityinstancedata_ribboncustomization
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_ribboncustomization")]
        public System.Collections.Generic.IEnumerable<UserEntityInstanceData> userentityinstancedata_ribboncustomization
        {
            get { return this.GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_ribboncustomization", null); }
            set
            {
                this.OnPropertyChanging("userentityinstancedata_ribboncustomization");
                this.SetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_ribboncustomization", null, value);
                this.OnPropertyChanged("userentityinstancedata_ribboncustomization");
            }
        }

        /// <summary>
        /// N:1 organization_ribbon_customization
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_ribbon_customization")]
        public Organization organization_ribbon_customization
        {
            get { return this.GetRelatedEntity<Organization>("organization_ribbon_customization", null); }
        }
    }
}