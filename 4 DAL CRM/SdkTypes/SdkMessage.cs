namespace __4_DAL_CRM
{
    /// <summary>
    /// Message that is supported by the SDK.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("sdkmessage")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class SdkMessage : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public SdkMessage() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "sdkmessage";

        public const int EntityTypeCode = 4606;

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
        /// Information about whether the SDK message is automatically transacted.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("autotransact")]
        public System.Nullable<bool> AutoTransact
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("autotransact"); }
            set
            {
                this.OnPropertyChanging("AutoTransact");
                this.SetAttributeValue("autotransact", value);
                this.OnPropertyChanged("AutoTransact");
            }
        }

        /// <summary>
        /// Identifies where a method will be exposed. 0 - Server, 1 - Client, 2 - both.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("availability")]
        public System.Nullable<int> Availability
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("availability"); }
            set
            {
                this.OnPropertyChanging("Availability");
                this.SetAttributeValue("availability", value);
                this.OnPropertyChanged("Availability");
            }
        }

        /// <summary>
        /// If this is a categorized method, this is the name, otherwise None.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("categoryname")]
        public string CategoryName
        {
            get { return this.GetAttributeValue<string>("categoryname"); }
            set
            {
                this.OnPropertyChanging("CategoryName");
                this.SetAttributeValue("categoryname", value);
                this.OnPropertyChanged("CategoryName");
            }
        }

        /// <summary>
        /// Unique identifier of the user who created the SDK message.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby"); }
        }

        /// <summary>
        /// Date and time when the SDK message was created.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
        public System.Nullable<System.DateTime> CreatedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who created the sdkmessage.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        /// Customization level of the SDK message.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("customizationlevel")]
        public System.Nullable<int> CustomizationLevel
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("customizationlevel"); }
        }

        /// <summary>
        /// Indicates whether the SDK message should have its requests expanded per primary entity defined in its filters.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("expand")]
        public System.Nullable<bool> Expand
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("expand"); }
            set
            {
                this.OnPropertyChanging("Expand");
                this.SetAttributeValue("expand", value);
                this.OnPropertyChanged("Expand");
            }
        }

        /// <summary>
        /// Information about whether the SDK message is active.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isactive")]
        public System.Nullable<bool> IsActive
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("isactive"); }
            set
            {
                this.OnPropertyChanging("IsActive");
                this.SetAttributeValue("isactive", value);
                this.OnPropertyChanged("IsActive");
            }
        }

        /// <summary>
        /// Indicates whether the SDK message is private.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isprivate")]
        public System.Nullable<bool> IsPrivate
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("isprivate"); }
            set
            {
                this.OnPropertyChanging("IsPrivate");
                this.SetAttributeValue("isprivate", value);
                this.OnPropertyChanged("IsPrivate");
            }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isvalidforexecuteasync")]
        public System.Nullable<bool> IsValidForExecuteAsync
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("isvalidforexecuteasync"); }
        }

        /// <summary>
        /// Unique identifier of the user who last modified the SDK message.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby"); }
        }

        /// <summary>
        /// Date and time when the SDK message was last modified.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
        public System.Nullable<System.DateTime> ModifiedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who last modified the sdkmessage.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        /// Name of the SDK message.
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
        /// Unique identifier of the organization with which the SDK message is associated.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
        public Microsoft.Xrm.Sdk.EntityReference OrganizationId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("organizationid"); }
        }

        /// <summary>
        /// Unique identifier of the SDK message entity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sdkmessageid")]
        public System.Nullable<System.Guid> SdkMessageId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("sdkmessageid"); }
            set
            {
                this.OnPropertyChanging("SdkMessageId");
                this.SetAttributeValue("sdkmessageid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("SdkMessageId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sdkmessageid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.SdkMessageId = value; }
        }

        /// <summary>
        /// Unique identifier of the SDK message.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sdkmessageidunique")]
        public System.Nullable<System.Guid> SdkMessageIdUnique
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("sdkmessageidunique"); }
        }

        /// <summary>
        /// Indicates whether the SDK message is a template.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("template")]
        public System.Nullable<bool> Template
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("template"); }
            set
            {
                this.OnPropertyChanging("Template");
                this.SetAttributeValue("template", value);
                this.OnPropertyChanged("Template");
            }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("throttlesettings")]
        public string ThrottleSettings
        {
            get { return this.GetAttributeValue<string>("throttlesettings"); }
        }

        /// <summary>
        /// Number that identifies a specific revision of the SDK message. 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
        public System.Nullable<long> VersionNumber
        {
            get { return this.GetAttributeValue<System.Nullable<long>>("versionnumber"); }
        }

        /// <summary>
        /// 1:N message_sdkmessagepair
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("message_sdkmessagepair")]
        public System.Collections.Generic.IEnumerable<SdkMessagePair> message_sdkmessagepair
        {
            get { return this.GetRelatedEntities<SdkMessagePair>("message_sdkmessagepair", null); }
            set
            {
                this.OnPropertyChanging("message_sdkmessagepair");
                this.SetRelatedEntities<SdkMessagePair>("message_sdkmessagepair", null, value);
                this.OnPropertyChanged("message_sdkmessagepair");
            }
        }

        /// <summary>
        /// 1:N sdkmessageid_sdkmessagefilter
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("sdkmessageid_sdkmessagefilter")]
        public System.Collections.Generic.IEnumerable<SdkMessageFilter> sdkmessageid_sdkmessagefilter
        {
            get { return this.GetRelatedEntities<SdkMessageFilter>("sdkmessageid_sdkmessagefilter", null); }
            set
            {
                this.OnPropertyChanging("sdkmessageid_sdkmessagefilter");
                this.SetRelatedEntities<SdkMessageFilter>("sdkmessageid_sdkmessagefilter", null, value);
                this.OnPropertyChanged("sdkmessageid_sdkmessagefilter");
            }
        }

        /// <summary>
        /// 1:N sdkmessageid_sdkmessageprocessingstep
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("sdkmessageid_sdkmessageprocessingstep")]
        public System.Collections.Generic.IEnumerable<SdkMessageProcessingStep> sdkmessageid_sdkmessageprocessingstep
        {
            get { return this.GetRelatedEntities<SdkMessageProcessingStep>("sdkmessageid_sdkmessageprocessingstep", null); }
            set
            {
                this.OnPropertyChanging("sdkmessageid_sdkmessageprocessingstep");
                this.SetRelatedEntities<SdkMessageProcessingStep>("sdkmessageid_sdkmessageprocessingstep", null, value);
                this.OnPropertyChanged("sdkmessageid_sdkmessageprocessingstep");
            }
        }

        /// <summary>
        /// 1:N sdkmessageid_workflow_dependency
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("sdkmessageid_workflow_dependency")]
        public System.Collections.Generic.IEnumerable<WorkflowDependency> sdkmessageid_workflow_dependency
        {
            get { return this.GetRelatedEntities<WorkflowDependency>("sdkmessageid_workflow_dependency", null); }
            set
            {
                this.OnPropertyChanging("sdkmessageid_workflow_dependency");
                this.SetRelatedEntities<WorkflowDependency>("sdkmessageid_workflow_dependency", null, value);
                this.OnPropertyChanged("sdkmessageid_workflow_dependency");
            }
        }

        /// <summary>
        /// 1:N userentityinstancedata_sdkmessage
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_sdkmessage")]
        public System.Collections.Generic.IEnumerable<UserEntityInstanceData> userentityinstancedata_sdkmessage
        {
            get { return this.GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_sdkmessage", null); }
            set
            {
                this.OnPropertyChanging("userentityinstancedata_sdkmessage");
                this.SetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_sdkmessage", null, value);
                this.OnPropertyChanged("userentityinstancedata_sdkmessage");
            }
        }

        /// <summary>
        /// N:1 createdby_sdkmessage
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("createdby_sdkmessage")]
        public SystemUser createdby_sdkmessage
        {
            get { return this.GetRelatedEntity<SystemUser>("createdby_sdkmessage", null); }
        }

        /// <summary>
        /// N:1 lk_sdkmessage_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_sdkmessage_createdonbehalfby")]
        public SystemUser lk_sdkmessage_createdonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_sdkmessage_createdonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_sdkmessage_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_sdkmessage_modifiedonbehalfby")]
        public SystemUser lk_sdkmessage_modifiedonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_sdkmessage_modifiedonbehalfby", null); }
        }

        /// <summary>
        /// N:1 modifiedby_sdkmessage
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("modifiedby_sdkmessage")]
        public SystemUser modifiedby_sdkmessage
        {
            get { return this.GetRelatedEntity<SystemUser>("modifiedby_sdkmessage", null); }
        }

        /// <summary>
        /// N:1 organization_sdkmessage
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_sdkmessage")]
        public Organization organization_sdkmessage
        {
            get { return this.GetRelatedEntity<Organization>("organization_sdkmessage", null); }
        }
    }
}