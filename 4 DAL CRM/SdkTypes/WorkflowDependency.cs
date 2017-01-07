namespace __4_DAL_CRM
{
    /// <summary>
    /// Dependencies for a process.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("workflowdependency")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class WorkflowDependency : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public WorkflowDependency() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "workflowdependency";

        public const int EntityTypeCode = 4704;

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
        /// Unique identifier of the user who created the process dependency.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby"); }
        }

        /// <summary>
        /// Date and time when the process dependency was created.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
        public System.Nullable<System.DateTime> CreatedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who created the process dependency.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        /// Name of the entity used in the process.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("customentityname")]
        public string CustomEntityName
        {
            get { return this.GetAttributeValue<string>("customentityname"); }
            set
            {
                this.OnPropertyChanging("CustomEntityName");
                this.SetAttributeValue("customentityname", value);
                this.OnPropertyChanged("CustomEntityName");
            }
        }

        /// <summary>
        /// Name of the attribute used in the process.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("dependentattributename")]
        public string DependentAttributeName
        {
            get { return this.GetAttributeValue<string>("dependentattributename"); }
            set
            {
                this.OnPropertyChanging("DependentAttributeName");
                this.SetAttributeValue("dependentattributename", value);
                this.OnPropertyChanged("DependentAttributeName");
            }
        }

        /// <summary>
        /// Name of the entity used in the process.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("dependententityname")]
        public string DependentEntityName
        {
            get { return this.GetAttributeValue<string>("dependententityname"); }
            set
            {
                this.OnPropertyChanging("DependentEntityName");
                this.SetAttributeValue("dependententityname", value);
                this.OnPropertyChanged("DependentEntityName");
            }
        }

        /// <summary>
        /// Comma-separated list of attributes that will be passed to process instance.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entityattributes")]
        public string EntityAttributes
        {
            get { return this.GetAttributeValue<string>("entityattributes"); }
            set
            {
                this.OnPropertyChanging("EntityAttributes");
                this.SetAttributeValue("entityattributes", value);
                this.OnPropertyChanged("EntityAttributes");
            }
        }

        /// <summary>
        /// Unique identifier of the user who last modified the process dependency.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby"); }
        }

        /// <summary>
        /// Date and time when the process dependency was last modified.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
        public System.Nullable<System.DateTime> ModifiedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who last modified the process dependency.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        /// Unique identifier of the user or team who owns the parent workflow instance.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ownerid")]
        public Microsoft.Xrm.Sdk.EntityReference OwnerId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("ownerid"); }
        }

        /// <summary>
        /// Unique identifier of the business unit that owns the process dependency.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
        public System.Nullable<System.Guid> OwningBusinessUnit
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("owningbusinessunit"); }
        }

        /// <summary>
        /// Unique identifier of the user who owns the process dependency.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
        public System.Nullable<System.Guid> OwningUser
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("owninguser"); }
        }

        /// <summary>
        /// Name of the process parameter.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("parametername")]
        public string ParameterName
        {
            get { return this.GetAttributeValue<string>("parametername"); }
            set
            {
                this.OnPropertyChanging("ParameterName");
                this.SetAttributeValue("parametername", value);
                this.OnPropertyChanged("ParameterName");
            }
        }

        /// <summary>
        /// Fully qualified name of the CLR type of the local parameter.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("parametertype")]
        public string ParameterType
        {
            get { return this.GetAttributeValue<string>("parametertype"); }
            set
            {
                this.OnPropertyChanging("ParameterType");
                this.SetAttributeValue("parametertype", value);
                this.OnPropertyChanged("ParameterType");
            }
        }

        /// <summary>
        /// Attribute of the primary entity that specifies related entity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("relatedattributename")]
        public string RelatedAttributeName
        {
            get { return this.GetAttributeValue<string>("relatedattributename"); }
            set
            {
                this.OnPropertyChanging("RelatedAttributeName");
                this.SetAttributeValue("relatedattributename", value);
                this.OnPropertyChanged("RelatedAttributeName");
            }
        }

        /// <summary>
        /// Name of the related entity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("relatedentityname")]
        public string RelatedEntityName
        {
            get { return this.GetAttributeValue<string>("relatedentityname"); }
            set
            {
                this.OnPropertyChanging("RelatedEntityName");
                this.SetAttributeValue("relatedentityname", value);
                this.OnPropertyChanged("RelatedEntityName");
            }
        }

        /// <summary>
        /// Unique identifier of the SDK message.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sdkmessageid")]
        public Microsoft.Xrm.Sdk.EntityReference SdkMessageId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("sdkmessageid"); }
            set
            {
                this.OnPropertyChanging("SdkMessageId");
                this.SetAttributeValue("sdkmessageid", value);
                this.OnPropertyChanged("SdkMessageId");
            }
        }

        /// <summary>
        /// Type of the process dependency.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("type")]
        public Microsoft.Xrm.Sdk.OptionSetValue Type
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("type"); }
            set
            {
                this.OnPropertyChanging("Type");
                this.SetAttributeValue("type", value);
                this.OnPropertyChanged("Type");
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
        /// Unique identifier of the process dependency.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("workflowdependencyid")]
        public System.Nullable<System.Guid> WorkflowDependencyId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("workflowdependencyid"); }
            set
            {
                this.OnPropertyChanging("WorkflowDependencyId");
                this.SetAttributeValue("workflowdependencyid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("WorkflowDependencyId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("workflowdependencyid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.WorkflowDependencyId = value; }
        }

        /// <summary>
        /// Unique identifier of the process with which the dependency is associated.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("workflowid")]
        public Microsoft.Xrm.Sdk.EntityReference WorkflowId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("workflowid"); }
            set
            {
                this.OnPropertyChanging("WorkflowId");
                this.SetAttributeValue("workflowid", value);
                this.OnPropertyChanged("WorkflowId");
            }
        }

        /// <summary>
        /// 1:N userentityinstancedata_workflowdependency
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_workflowdependency")]
        public System.Collections.Generic.IEnumerable<UserEntityInstanceData> userentityinstancedata_workflowdependency
        {
            get { return this.GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_workflowdependency", null); }
            set
            {
                this.OnPropertyChanging("userentityinstancedata_workflowdependency");
                this.SetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_workflowdependency", null, value);
                this.OnPropertyChanged("userentityinstancedata_workflowdependency");
            }
        }

        /// <summary>
        /// N:1 sdkmessageid_workflow_dependency
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sdkmessageid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("sdkmessageid_workflow_dependency")]
        public SdkMessage sdkmessageid_workflow_dependency
        {
            get { return this.GetRelatedEntity<SdkMessage>("sdkmessageid_workflow_dependency", null); }
            set
            {
                this.OnPropertyChanging("sdkmessageid_workflow_dependency");
                this.SetRelatedEntity<SdkMessage>("sdkmessageid_workflow_dependency", null, value);
                this.OnPropertyChanged("sdkmessageid_workflow_dependency");
            }
        }

        /// <summary>
        /// N:1 workflow_dependencies
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("workflowid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("workflow_dependencies")]
        public Workflow workflow_dependencies
        {
            get { return this.GetRelatedEntity<Workflow>("workflow_dependencies", null); }
            set
            {
                this.OnPropertyChanging("workflow_dependencies");
                this.SetRelatedEntity<Workflow>("workflow_dependencies", null, value);
                this.OnPropertyChanged("workflow_dependencies");
            }
        }

        /// <summary>
        /// N:1 workflow_dependency_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("workflow_dependency_createdby")]
        public SystemUser workflow_dependency_createdby
        {
            get { return this.GetRelatedEntity<SystemUser>("workflow_dependency_createdby", null); }
        }

        /// <summary>
        /// N:1 workflow_dependency_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("workflow_dependency_createdonbehalfby")]
        public SystemUser workflow_dependency_createdonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("workflow_dependency_createdonbehalfby", null); }
        }

        /// <summary>
        /// N:1 workflow_dependency_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("workflow_dependency_modifiedby")]
        public SystemUser workflow_dependency_modifiedby
        {
            get { return this.GetRelatedEntity<SystemUser>("workflow_dependency_modifiedby", null); }
        }

        /// <summary>
        /// N:1 workflow_dependency_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("workflow_dependency_modifiedonbehalfby")]
        public SystemUser workflow_dependency_modifiedonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("workflow_dependency_modifiedonbehalfby", null); }
        }
    }
}