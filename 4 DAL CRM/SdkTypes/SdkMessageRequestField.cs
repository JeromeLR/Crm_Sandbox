namespace __4_DAL_CRM
{
    /// <summary>
    /// For internal use only.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("sdkmessagerequestfield")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class SdkMessageRequestField : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public SdkMessageRequestField() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "sdkmessagerequestfield";

        public const int EntityTypeCode = 4614;

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
        /// Common language runtime (CLR)-based parser for the SDK message request field.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("clrparser")]
        public string ClrParser
        {
            get { return this.GetAttributeValue<string>("clrparser"); }
            set
            {
                this.OnPropertyChanging("ClrParser");
                this.SetAttributeValue("clrparser", value);
                this.OnPropertyChanged("ClrParser");
            }
        }

        /// <summary>
        /// Unique identifier of the user who created the SDK message request field.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby"); }
        }

        /// <summary>
        /// Date and time when the SDK message request field was created.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
        public System.Nullable<System.DateTime> CreatedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who created the sdkmessagerequestfield.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        /// Customization level of the SDK message request field.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("customizationlevel")]
        public System.Nullable<int> CustomizationLevel
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("customizationlevel"); }
        }

        /// <summary>
        /// Indicates how field contents are used during message processing. 1 - Primary entity, 2- Secondary entity
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("fieldmask")]
        public System.Nullable<int> FieldMask
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("fieldmask"); }
        }

        /// <summary>
        /// Unique identifier of the user who last modified the SDK message request field.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby"); }
        }

        /// <summary>
        /// Date and time when the SDK message request field was last modified.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
        public System.Nullable<System.DateTime> ModifiedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who last modified the sdkmessagerequestfield.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        /// Name of the SDK message request field.
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
        /// Information about whether SDK message request field is optional.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("optional")]
        public System.Nullable<bool> Optional
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("optional"); }
            set
            {
                this.OnPropertyChanging("Optional");
                this.SetAttributeValue("optional", value);
                this.OnPropertyChanged("Optional");
            }
        }

        /// <summary>
        /// Unique identifier of the organization with which the SDK message request field is associated.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
        public Microsoft.Xrm.Sdk.EntityReference OrganizationId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("organizationid"); }
        }

        /// <summary>
        /// Parser for the SDK message request field.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("parser")]
        public string Parser
        {
            get { return this.GetAttributeValue<string>("parser"); }
            set
            {
                this.OnPropertyChanging("Parser");
                this.SetAttributeValue("parser", value);
                this.OnPropertyChanged("Parser");
            }
        }

        /// <summary>
        /// Position of the Sdk message request field
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("position")]
        public System.Nullable<int> Position
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("position"); }
        }

        /// <summary>
        /// Public name of the SDK message request field.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("publicname")]
        public string PublicName
        {
            get { return this.GetAttributeValue<string>("publicname"); }
            set
            {
                this.OnPropertyChanging("PublicName");
                this.SetAttributeValue("publicname", value);
                this.OnPropertyChanged("PublicName");
            }
        }

        /// <summary>
        /// Unique identifier of the SDK message request field entity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sdkmessagerequestfieldid")]
        public System.Nullable<System.Guid> SdkMessageRequestFieldId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("sdkmessagerequestfieldid"); }
            set
            {
                this.OnPropertyChanging("SdkMessageRequestFieldId");
                this.SetAttributeValue("sdkmessagerequestfieldid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("SdkMessageRequestFieldId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sdkmessagerequestfieldid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.SdkMessageRequestFieldId = value; }
        }

        /// <summary>
        /// Entity identifier of the SDK message request field.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sdkmessagerequestfieldidunique")]
        public System.Nullable<System.Guid> SdkMessageRequestFieldIdUnique
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("sdkmessagerequestfieldidunique"); }
        }

        /// <summary>
        /// Unique identifier of the message request with which the SDK message request field is associated.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sdkmessagerequestid")]
        public Microsoft.Xrm.Sdk.EntityReference SdkMessageRequestId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("sdkmessagerequestid"); }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
        public System.Nullable<long> VersionNumber
        {
            get { return this.GetAttributeValue<System.Nullable<long>>("versionnumber"); }
        }

        /// <summary>
        /// 1:N userentityinstancedata_sdkmessagerequestfield
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_sdkmessagerequestfield")]
        public System.Collections.Generic.IEnumerable<UserEntityInstanceData> userentityinstancedata_sdkmessagerequestfield
        {
            get { return this.GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_sdkmessagerequestfield", null); }
            set
            {
                this.OnPropertyChanging("userentityinstancedata_sdkmessagerequestfield");
                this.SetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_sdkmessagerequestfield", null, value);
                this.OnPropertyChanged("userentityinstancedata_sdkmessagerequestfield");
            }
        }

        /// <summary>
        /// N:1 createdby_sdkmessagerequestfield
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("createdby_sdkmessagerequestfield")]
        public SystemUser createdby_sdkmessagerequestfield
        {
            get { return this.GetRelatedEntity<SystemUser>("createdby_sdkmessagerequestfield", null); }
        }

        /// <summary>
        /// N:1 lk_sdkmessagerequestfield_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_sdkmessagerequestfield_createdonbehalfby")]
        public SystemUser lk_sdkmessagerequestfield_createdonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_sdkmessagerequestfield_createdonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_sdkmessagerequestfield_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_sdkmessagerequestfield_modifiedonbehalfby")]
        public SystemUser lk_sdkmessagerequestfield_modifiedonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_sdkmessagerequestfield_modifiedonbehalfby", null); }
        }

        /// <summary>
        /// N:1 messagerequest_sdkmessagerequestfield
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sdkmessagerequestid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("messagerequest_sdkmessagerequestfield")]
        public SdkMessageRequest messagerequest_sdkmessagerequestfield
        {
            get { return this.GetRelatedEntity<SdkMessageRequest>("messagerequest_sdkmessagerequestfield", null); }
        }

        /// <summary>
        /// N:1 modifiedby_sdkmessagerequestfield
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("modifiedby_sdkmessagerequestfield")]
        public SystemUser modifiedby_sdkmessagerequestfield
        {
            get { return this.GetRelatedEntity<SystemUser>("modifiedby_sdkmessagerequestfield", null); }
        }

        /// <summary>
        /// N:1 organization_sdkmessagerequestfield
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_sdkmessagerequestfield")]
        public Organization organization_sdkmessagerequestfield
        {
            get { return this.GetRelatedEntity<Organization>("organization_sdkmessagerequestfield", null); }
        }
    }
}