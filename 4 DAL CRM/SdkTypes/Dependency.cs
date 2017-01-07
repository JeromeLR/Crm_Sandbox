namespace __4_DAL_CRM
{
    /// <summary>
    /// A component dependency in CRM.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("dependency")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class Dependency : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public Dependency() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "dependency";

        public const int EntityTypeCode = 7105;

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
        /// Unique identifier of a dependency.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("dependencyid")]
        public System.Nullable<System.Guid> DependencyId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("dependencyid"); }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("dependencyid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { base.Id = value; }
        }

        /// <summary>
        /// The dependency type of the dependency.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("dependencytype")]
        public Microsoft.Xrm.Sdk.OptionSetValue DependencyType
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("dependencytype"); }
        }

        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("dependentcomponentbasesolutionid")]
        public System.Nullable<System.Guid> DependentComponentBaseSolutionId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("dependentcomponentbasesolutionid"); }
        }

        /// <summary>
        /// Unique identifier of the dependent component's node.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("dependentcomponentnodeid")]
        public Microsoft.Xrm.Sdk.EntityReference DependentComponentNodeId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("dependentcomponentnodeid"); }
        }

        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("dependentcomponentobjectid")]
        public System.Nullable<System.Guid> DependentComponentObjectId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("dependentcomponentobjectid"); }
        }

        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("dependentcomponentparentid")]
        public System.Nullable<System.Guid> DependentComponentParentId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("dependentcomponentparentid"); }
        }

        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("dependentcomponenttype")]
        public Microsoft.Xrm.Sdk.OptionSetValue DependentComponentType
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("dependentcomponenttype"); }
        }

        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("requiredcomponentbasesolutionid")]
        public System.Nullable<System.Guid> RequiredComponentBaseSolutionId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("requiredcomponentbasesolutionid"); }
        }

        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("requiredcomponentintroducedversion")]
        public System.Nullable<double> RequiredComponentIntroducedVersion
        {
            get { return this.GetAttributeValue<System.Nullable<double>>("requiredcomponentintroducedversion"); }
        }

        /// <summary>
        /// Unique identifier of the required component's node
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("requiredcomponentnodeid")]
        public Microsoft.Xrm.Sdk.EntityReference RequiredComponentNodeId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("requiredcomponentnodeid"); }
        }

        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("requiredcomponentobjectid")]
        public System.Nullable<System.Guid> RequiredComponentObjectId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("requiredcomponentobjectid"); }
        }

        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("requiredcomponentparentid")]
        public System.Nullable<System.Guid> RequiredComponentParentId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("requiredcomponentparentid"); }
        }

        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("requiredcomponenttype")]
        public Microsoft.Xrm.Sdk.OptionSetValue RequiredComponentType
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("requiredcomponenttype"); }
        }

        /// <summary>
        /// 1:N userentityinstancedata_dependency
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_dependency")]
        public System.Collections.Generic.IEnumerable<UserEntityInstanceData> userentityinstancedata_dependency
        {
            get { return this.GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_dependency", null); }
            set
            {
                this.OnPropertyChanging("userentityinstancedata_dependency");
                this.SetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_dependency", null, value);
                this.OnPropertyChanged("userentityinstancedata_dependency");
            }
        }
    }
}