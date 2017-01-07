namespace __4_DAL_CRM
{
    /// <summary>
    /// A component of a CRM solution.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("solutioncomponent")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class SolutionComponent : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public SolutionComponent() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "solutioncomponent";

        public const int EntityTypeCode = 7103;

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
        /// The object type code of the component.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("componenttype")]
        public Microsoft.Xrm.Sdk.OptionSetValue ComponentType
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("componenttype"); }
        }

        /// <summary>
        /// Unique identifier of the user who created the solution
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
        /// Indicates whether this component is metadata or data.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ismetadata")]
        public System.Nullable<bool> IsMetadata
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("ismetadata"); }
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
        /// Unique identifier of the object with which the component is associated.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
        public System.Nullable<System.Guid> ObjectId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("objectid"); }
        }

        /// <summary>
        /// Unique identifier of the solution component.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("solutioncomponentid")]
        public System.Nullable<System.Guid> SolutionComponentId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("solutioncomponentid"); }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("solutioncomponentid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { base.Id = value; }
        }

        /// <summary>
        /// Unique identifier of the solution.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("solutionid")]
        public Microsoft.Xrm.Sdk.EntityReference SolutionId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("solutionid"); }
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
        /// 1:N userentityinstancedata_solutioncomponent
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_solutioncomponent")]
        public System.Collections.Generic.IEnumerable<UserEntityInstanceData> userentityinstancedata_solutioncomponent
        {
            get { return this.GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_solutioncomponent", null); }
            set
            {
                this.OnPropertyChanging("userentityinstancedata_solutioncomponent");
                this.SetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_solutioncomponent", null, value);
                this.OnPropertyChanged("userentityinstancedata_solutioncomponent");
            }
        }

        /// <summary>
        /// N:1 lk_solutioncomponentbase_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_solutioncomponentbase_createdonbehalfby")]
        public SystemUser lk_solutioncomponentbase_createdonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_solutioncomponentbase_createdonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_solutioncomponentbase_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_solutioncomponentbase_modifiedonbehalfby")]
        public SystemUser lk_solutioncomponentbase_modifiedonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_solutioncomponentbase_modifiedonbehalfby", null); }
        }

        /// <summary>
        /// N:1 solution_solutioncomponent
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("solutionid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("solution_solutioncomponent")]
        public Solution solution_solutioncomponent
        {
            get { return this.GetRelatedEntity<Solution>("solution_solutioncomponent", null); }
        }
    }
}