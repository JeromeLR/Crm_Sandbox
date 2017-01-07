namespace __4_DAL_CRM
{
    /// <summary>
    /// For internal use only.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("sdkmessageresponse")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class SdkMessageResponse : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public SdkMessageResponse() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "sdkmessageresponse";

        public const int EntityTypeCode = 4610;

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
        /// Unique identifier of the user who created the SDK message response.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby"); }
        }

        /// <summary>
        /// Date and time when the SDK message response was created.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
        public System.Nullable<System.DateTime> CreatedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who created the sdkmessageresponse.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        /// Customization level of the SDK message response.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("customizationlevel")]
        public System.Nullable<int> CustomizationLevel
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("customizationlevel"); }
        }

        /// <summary>
        /// Unique identifier of the user who last modified the SDK message response.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby"); }
        }

        /// <summary>
        /// Date and time when the SDK message response was last modified.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
        public System.Nullable<System.DateTime> ModifiedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who last modified the sdkmessageresponse.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        /// Unique identifier of the organization with which the SDK message response is associated.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
        public Microsoft.Xrm.Sdk.EntityReference OrganizationId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("organizationid"); }
        }

        /// <summary>
        /// Unique identifier of the message request with which the SDK message response is associated.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sdkmessagerequestid")]
        public Microsoft.Xrm.Sdk.EntityReference SdkMessageRequestId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("sdkmessagerequestid"); }
        }

        /// <summary>
        /// Unique identifier of the SDK message response entity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sdkmessageresponseid")]
        public System.Nullable<System.Guid> SdkMessageResponseId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("sdkmessageresponseid"); }
            set
            {
                this.OnPropertyChanging("SdkMessageResponseId");
                this.SetAttributeValue("sdkmessageresponseid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("SdkMessageResponseId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sdkmessageresponseid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.SdkMessageResponseId = value; }
        }

        /// <summary>
        /// Unique identifier of the SDK message response.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sdkmessageresponseidunique")]
        public System.Nullable<System.Guid> SdkMessageResponseIdUnique
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("sdkmessageresponseidunique"); }
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
        /// 1:N messageresponse_sdkmessageresponsefield
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("messageresponse_sdkmessageresponsefield")]
        public System.Collections.Generic.IEnumerable<SdkMessageResponseField> messageresponse_sdkmessageresponsefield
        {
            get { return this.GetRelatedEntities<SdkMessageResponseField>("messageresponse_sdkmessageresponsefield", null); }
            set
            {
                this.OnPropertyChanging("messageresponse_sdkmessageresponsefield");
                this.SetRelatedEntities<SdkMessageResponseField>("messageresponse_sdkmessageresponsefield", null, value);
                this.OnPropertyChanged("messageresponse_sdkmessageresponsefield");
            }
        }

        /// <summary>
        /// 1:N userentityinstancedata_sdkmessageresponse
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_sdkmessageresponse")]
        public System.Collections.Generic.IEnumerable<UserEntityInstanceData> userentityinstancedata_sdkmessageresponse
        {
            get { return this.GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_sdkmessageresponse", null); }
            set
            {
                this.OnPropertyChanging("userentityinstancedata_sdkmessageresponse");
                this.SetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_sdkmessageresponse", null, value);
                this.OnPropertyChanged("userentityinstancedata_sdkmessageresponse");
            }
        }

        /// <summary>
        /// N:1 createdby_sdkmessageresponse
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("createdby_sdkmessageresponse")]
        public SystemUser createdby_sdkmessageresponse
        {
            get { return this.GetRelatedEntity<SystemUser>("createdby_sdkmessageresponse", null); }
        }

        /// <summary>
        /// N:1 lk_sdkmessageresponse_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_sdkmessageresponse_createdonbehalfby")]
        public SystemUser lk_sdkmessageresponse_createdonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_sdkmessageresponse_createdonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_sdkmessageresponse_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_sdkmessageresponse_modifiedonbehalfby")]
        public SystemUser lk_sdkmessageresponse_modifiedonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_sdkmessageresponse_modifiedonbehalfby", null); }
        }

        /// <summary>
        /// N:1 messagerequest_sdkmessageresponse
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sdkmessagerequestid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("messagerequest_sdkmessageresponse")]
        public SdkMessageRequest messagerequest_sdkmessageresponse
        {
            get { return this.GetRelatedEntity<SdkMessageRequest>("messagerequest_sdkmessageresponse", null); }
        }

        /// <summary>
        /// N:1 modifiedby_sdkmessageresponse
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("modifiedby_sdkmessageresponse")]
        public SystemUser modifiedby_sdkmessageresponse
        {
            get { return this.GetRelatedEntity<SystemUser>("modifiedby_sdkmessageresponse", null); }
        }

        /// <summary>
        /// N:1 organization_sdkmessageresponse
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_sdkmessageresponse")]
        public Organization organization_sdkmessageresponse
        {
            get { return this.GetRelatedEntity<Organization>("organization_sdkmessageresponse", null); }
        }
    }
}