namespace __4_DAL_CRM
{
    /// <summary>
    /// An invalid dependency in the CRM system.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("invaliddependency")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class InvalidDependency : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public InvalidDependency() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "invaliddependency";

        public const int EntityTypeCode = 7107;

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
        /// Unique identifier of the object that has an invalid dependency
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("existingcomponentid")]
        public System.Nullable<System.Guid> ExistingComponentId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("existingcomponentid"); }
        }

        /// <summary>
        /// Component type of the object that has an invalid dependency
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("existingcomponenttype")]
        public Microsoft.Xrm.Sdk.OptionSetValue ExistingComponentType
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("existingcomponenttype"); }
        }

        /// <summary>
        /// The dependency type of the invalid dependency.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("existingdependencytype")]
        public Microsoft.Xrm.Sdk.OptionSetValue ExistingDependencyType
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("existingdependencytype"); }
        }

        /// <summary>
        /// Unique identifier of the invalid dependency.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("invaliddependencyid")]
        public System.Nullable<System.Guid> InvalidDependencyId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("invaliddependencyid"); }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("invaliddependencyid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { base.Id = value; }
        }

        /// <summary>
        /// Indicates whether the existing node is the required component in the dependency
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isexistingnoderequiredcomponent")]
        public System.Nullable<bool> IsExistingNodeRequiredComponent
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("isexistingnoderequiredcomponent"); }
        }

        /// <summary>
        /// Unique identifier of the missing component.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("missingcomponentid")]
        public System.Nullable<System.Guid> MissingComponentId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("missingcomponentid"); }
            set
            {
                this.OnPropertyChanging("MissingComponentId");
                this.SetAttributeValue("missingcomponentid", value);
                this.OnPropertyChanged("MissingComponentId");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("missingcomponentinfo")]
        public string MissingComponentInfo
        {
            get { return this.GetAttributeValue<string>("missingcomponentinfo"); }
        }

        /// <summary>
        /// The lookup type of the missing component.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("missingcomponentlookuptype")]
        public System.Nullable<int> MissingComponentLookupType
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("missingcomponentlookuptype"); }
        }

        /// <summary>
        /// The object type code of the missing component.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("missingcomponenttype")]
        public Microsoft.Xrm.Sdk.OptionSetValue MissingComponentType
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("missingcomponenttype"); }
        }

        /// <summary>
        /// 1:N userentityinstancedata_invaliddependency
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_invaliddependency")]
        public System.Collections.Generic.IEnumerable<UserEntityInstanceData> userentityinstancedata_invaliddependency
        {
            get { return this.GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_invaliddependency", null); }
            set
            {
                this.OnPropertyChanging("userentityinstancedata_invaliddependency");
                this.SetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_invaliddependency", null, value);
                this.OnPropertyChanged("userentityinstancedata_invaliddependency");
            }
        }
    }
}