namespace __4_DAL_CRM
{
    /// <summary>
    /// For internal use only.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("sdkmessageresponsefield")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class SdkMessageResponseField : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public SdkMessageResponseField() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "sdkmessageresponsefield";

        public const int EntityTypeCode = 4611;

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
        /// Common language runtime (CLR)-based formatter of the SDK message response field.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("clrformatter")]
        public string ClrFormatter
        {
            get { return this.GetAttributeValue<string>("clrformatter"); }
            set
            {
                this.OnPropertyChanging("ClrFormatter");
                this.SetAttributeValue("clrformatter", value);
                this.OnPropertyChanged("ClrFormatter");
            }
        }

        /// <summary>
        /// Unique identifier of the user who created the SDK message response field.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby"); }
        }

        /// <summary>
        /// Date and time when the SDK message response field was created.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
        public System.Nullable<System.DateTime> CreatedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who created the sdkmessageresponsefield.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        /// Customization level of the SDK message response field.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("customizationlevel")]
        public System.Nullable<int> CustomizationLevel
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("customizationlevel"); }
        }

        /// <summary>
        /// Formatter for the SDK message response field.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("formatter")]
        public string Formatter
        {
            get { return this.GetAttributeValue<string>("formatter"); }
            set
            {
                this.OnPropertyChanging("Formatter");
                this.SetAttributeValue("formatter", value);
                this.OnPropertyChanged("Formatter");
            }
        }

        /// <summary>
        /// Unique identifier of the user who last modified the SDK message response field.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby"); }
        }

        /// <summary>
        /// Date and time when the SDK message response field was last modified.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
        public System.Nullable<System.DateTime> ModifiedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who last modified the sdkmessageresponsefield.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        /// Name of the SDK message response field.
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
        /// Unique identifier of the organization with which the SDK message response field is associated.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
        public Microsoft.Xrm.Sdk.EntityReference OrganizationId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("organizationid"); }
        }

        /// <summary>
        /// Position of the Sdk message response field
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("position")]
        public System.Nullable<int> Position
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("position"); }
        }

        /// <summary>
        /// Public name of the SDK message response field.
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
        /// Unique identifier of the SDK message response field entity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sdkmessageresponsefieldid")]
        public System.Nullable<System.Guid> SdkMessageResponseFieldId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("sdkmessageresponsefieldid"); }
            set
            {
                this.OnPropertyChanging("SdkMessageResponseFieldId");
                this.SetAttributeValue("sdkmessageresponsefieldid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("SdkMessageResponseFieldId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sdkmessageresponsefieldid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.SdkMessageResponseFieldId = value; }
        }

        /// <summary>
        /// Unique identifier of the SDK message response field.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sdkmessageresponsefieldidunique")]
        public System.Nullable<System.Guid> SdkMessageResponseFieldIdUnique
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("sdkmessageresponsefieldidunique"); }
        }

        /// <summary>
        /// Unique identifier of the message response with which the SDK message response field is associated.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sdkmessageresponseid")]
        public Microsoft.Xrm.Sdk.EntityReference SdkMessageResponseId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("sdkmessageresponseid"); }
        }

        /// <summary>
        /// Actual value of the SDK message response field.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("value")]
        public string Value
        {
            get { return this.GetAttributeValue<string>("value"); }
            set
            {
                this.OnPropertyChanging("Value");
                this.SetAttributeValue("value", value);
                this.OnPropertyChanged("Value");
            }
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
        /// 1:N userentityinstancedata_sdkmessageresponsefield
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_sdkmessageresponsefield")]
        public System.Collections.Generic.IEnumerable<UserEntityInstanceData> userentityinstancedata_sdkmessageresponsefield
        {
            get { return this.GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_sdkmessageresponsefield", null); }
            set
            {
                this.OnPropertyChanging("userentityinstancedata_sdkmessageresponsefield");
                this.SetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_sdkmessageresponsefield", null, value);
                this.OnPropertyChanged("userentityinstancedata_sdkmessageresponsefield");
            }
        }

        /// <summary>
        /// N:1 createdby_sdkmessageresponsefield
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("createdby_sdkmessageresponsefield")]
        public SystemUser createdby_sdkmessageresponsefield
        {
            get { return this.GetRelatedEntity<SystemUser>("createdby_sdkmessageresponsefield", null); }
        }

        /// <summary>
        /// N:1 lk_sdkmessageresponsefield_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_sdkmessageresponsefield_createdonbehalfby")]
        public SystemUser lk_sdkmessageresponsefield_createdonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_sdkmessageresponsefield_createdonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_sdkmessageresponsefield_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_sdkmessageresponsefield_modifiedonbehalfby")]
        public SystemUser lk_sdkmessageresponsefield_modifiedonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_sdkmessageresponsefield_modifiedonbehalfby", null); }
        }

        /// <summary>
        /// N:1 messageresponse_sdkmessageresponsefield
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sdkmessageresponseid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("messageresponse_sdkmessageresponsefield")]
        public SdkMessageResponse messageresponse_sdkmessageresponsefield
        {
            get { return this.GetRelatedEntity<SdkMessageResponse>("messageresponse_sdkmessageresponsefield", null); }
        }

        /// <summary>
        /// N:1 modifiedby_sdkmessageresponsefield
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("modifiedby_sdkmessageresponsefield")]
        public SystemUser modifiedby_sdkmessageresponsefield
        {
            get { return this.GetRelatedEntity<SystemUser>("modifiedby_sdkmessageresponsefield", null); }
        }

        /// <summary>
        /// N:1 organization_sdkmessageresponsefield
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_sdkmessageresponsefield")]
        public Organization organization_sdkmessageresponsefield
        {
            get { return this.GetRelatedEntity<Organization>("organization_sdkmessageresponsefield", null); }
        }
    }
}