namespace __4_DAL_CRM
{
    /// <summary>
    /// For internal use only.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("sdkmessagerequest")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class SdkMessageRequest : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public SdkMessageRequest() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "sdkmessagerequest";

        public const int EntityTypeCode = 4609;

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
        /// Unique identifier of the user who created the SDK message request.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby"); }
        }

        /// <summary>
        /// Date and time when the SDK message request was created.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
        public System.Nullable<System.DateTime> CreatedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who created the sdkmessagerequest.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        /// Customization level of the SDK message request.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("customizationlevel")]
        public System.Nullable<int> CustomizationLevel
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("customizationlevel"); }
        }

        /// <summary>
        /// Unique identifier of the user who last modified the SDK message request.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby"); }
        }

        /// <summary>
        /// Date and time when the SDK message request was last modified.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
        public System.Nullable<System.DateTime> ModifiedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who last modified the sdkmessagerequest.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        /// Name of the SDK message request.
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
        /// Unique identifier of the organization with which the SDK message request is associated.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
        public Microsoft.Xrm.Sdk.EntityReference OrganizationId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("organizationid"); }
        }

        /// <summary>
        /// Type of entity with which the SDK request is associated.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("primaryobjecttypecode")]
        public string PrimaryObjectTypeCode
        {
            get { return this.GetAttributeValue<string>("primaryobjecttypecode"); }
        }

        /// <summary>
        /// Unique identifier of the message pair with which the SDK message request is associated.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sdkmessagepairid")]
        public Microsoft.Xrm.Sdk.EntityReference SdkMessagePairId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("sdkmessagepairid"); }
        }

        /// <summary>
        /// Unique identifier of the SDK message request entity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sdkmessagerequestid")]
        public System.Nullable<System.Guid> SdkMessageRequestId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("sdkmessagerequestid"); }
            set
            {
                this.OnPropertyChanging("SdkMessageRequestId");
                this.SetAttributeValue("sdkmessagerequestid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("SdkMessageRequestId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sdkmessagerequestid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.SdkMessageRequestId = value; }
        }

        /// <summary>
        /// Unique identifier of the SDK message request.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sdkmessagerequestidunique")]
        public System.Nullable<System.Guid> SdkMessageRequestIdUnique
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("sdkmessagerequestidunique"); }
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
        /// 1:N messagerequest_sdkmessagerequestfield
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("messagerequest_sdkmessagerequestfield")]
        public System.Collections.Generic.IEnumerable<SdkMessageRequestField> messagerequest_sdkmessagerequestfield
        {
            get { return this.GetRelatedEntities<SdkMessageRequestField>("messagerequest_sdkmessagerequestfield", null); }
            set
            {
                this.OnPropertyChanging("messagerequest_sdkmessagerequestfield");
                this.SetRelatedEntities<SdkMessageRequestField>("messagerequest_sdkmessagerequestfield", null, value);
                this.OnPropertyChanged("messagerequest_sdkmessagerequestfield");
            }
        }

        /// <summary>
        /// 1:N messagerequest_sdkmessageresponse
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("messagerequest_sdkmessageresponse")]
        public System.Collections.Generic.IEnumerable<SdkMessageResponse> messagerequest_sdkmessageresponse
        {
            get { return this.GetRelatedEntities<SdkMessageResponse>("messagerequest_sdkmessageresponse", null); }
            set
            {
                this.OnPropertyChanging("messagerequest_sdkmessageresponse");
                this.SetRelatedEntities<SdkMessageResponse>("messagerequest_sdkmessageresponse", null, value);
                this.OnPropertyChanged("messagerequest_sdkmessageresponse");
            }
        }

        /// <summary>
        /// 1:N userentityinstancedata_sdkmessagerequest
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_sdkmessagerequest")]
        public System.Collections.Generic.IEnumerable<UserEntityInstanceData> userentityinstancedata_sdkmessagerequest
        {
            get { return this.GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_sdkmessagerequest", null); }
            set
            {
                this.OnPropertyChanging("userentityinstancedata_sdkmessagerequest");
                this.SetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_sdkmessagerequest", null, value);
                this.OnPropertyChanged("userentityinstancedata_sdkmessagerequest");
            }
        }

        /// <summary>
        /// N:1 createdby_sdkmessagerequest
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("createdby_sdkmessagerequest")]
        public SystemUser createdby_sdkmessagerequest
        {
            get { return this.GetRelatedEntity<SystemUser>("createdby_sdkmessagerequest", null); }
        }

        /// <summary>
        /// N:1 lk_sdkmessagerequest_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_sdkmessagerequest_createdonbehalfby")]
        public SystemUser lk_sdkmessagerequest_createdonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_sdkmessagerequest_createdonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_sdkmessagerequest_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_sdkmessagerequest_modifiedonbehalfby")]
        public SystemUser lk_sdkmessagerequest_modifiedonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_sdkmessagerequest_modifiedonbehalfby", null); }
        }

        /// <summary>
        /// N:1 messagepair_sdkmessagerequest
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sdkmessagepairid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("messagepair_sdkmessagerequest")]
        public SdkMessagePair messagepair_sdkmessagerequest
        {
            get { return this.GetRelatedEntity<SdkMessagePair>("messagepair_sdkmessagerequest", null); }
        }

        /// <summary>
        /// N:1 modifiedby_sdkmessagerequest
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("modifiedby_sdkmessagerequest")]
        public SystemUser modifiedby_sdkmessagerequest
        {
            get { return this.GetRelatedEntity<SystemUser>("modifiedby_sdkmessagerequest", null); }
        }

        /// <summary>
        /// N:1 organization_sdkmessagerequest
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_sdkmessagerequest")]
        public Organization organization_sdkmessagerequest
        {
            get { return this.GetRelatedEntity<Organization>("organization_sdkmessagerequest", null); }
        }
    }
}