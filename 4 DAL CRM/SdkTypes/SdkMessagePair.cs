namespace __4_DAL_CRM
{
    /// <summary>
    /// For internal use only.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("sdkmessagepair")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class SdkMessagePair : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public SdkMessagePair() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "sdkmessagepair";

        public const int EntityTypeCode = 4613;

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
        /// Unique identifier of the user who created the SDK message pair.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby"); }
        }

        /// <summary>
        /// Date and time when the SDK message pair was created.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
        public System.Nullable<System.DateTime> CreatedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who created the sdkmessagepair.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        /// Customization level of the SDK message filter.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("customizationlevel")]
        public System.Nullable<int> CustomizationLevel
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("customizationlevel"); }
        }

        /// <summary>
        /// Endpoint that the message pair is associated with.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("endpoint")]
        public string Endpoint
        {
            get { return this.GetAttributeValue<string>("endpoint"); }
            set
            {
                this.OnPropertyChanging("Endpoint");
                this.SetAttributeValue("endpoint", value);
                this.OnPropertyChanged("Endpoint");
            }
        }

        /// <summary>
        /// Unique identifier of the user who last modified the SDK message pair.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby"); }
        }

        /// <summary>
        /// Date and time when the SDK message pair was last modified.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
        public System.Nullable<System.DateTime> ModifiedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who last modified the sdkmessagepair.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        /// Namespace that the message pair is associated with.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("namespace")]
        public string Namespace
        {
            get { return this.GetAttributeValue<string>("namespace"); }
            set
            {
                this.OnPropertyChanging("Namespace");
                this.SetAttributeValue("namespace", value);
                this.OnPropertyChanged("Namespace");
            }
        }

        /// <summary>
        /// Unique identifier of the organization with which the SDK message pair is associated.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
        public Microsoft.Xrm.Sdk.EntityReference OrganizationId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("organizationid"); }
        }

        /// <summary>
        /// Unique identifier of the message with which the SDK message pair is associated.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sdkmessageid")]
        public Microsoft.Xrm.Sdk.EntityReference SdkMessageId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("sdkmessageid"); }
        }

        /// <summary>
        /// Unique identifier of the SDK message pair entity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sdkmessagepairid")]
        public System.Nullable<System.Guid> SdkMessagePairId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("sdkmessagepairid"); }
            set
            {
                this.OnPropertyChanging("SdkMessagePairId");
                this.SetAttributeValue("sdkmessagepairid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("SdkMessagePairId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sdkmessagepairid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.SdkMessagePairId = value; }
        }

        /// <summary>
        /// Unique identifier of the SDK message pair.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sdkmessagepairidunique")]
        public System.Nullable<System.Guid> SdkMessagePairIdUnique
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("sdkmessagepairidunique"); }
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
        /// 1:N messagepair_sdkmessagerequest
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("messagepair_sdkmessagerequest")]
        public System.Collections.Generic.IEnumerable<SdkMessageRequest> messagepair_sdkmessagerequest
        {
            get { return this.GetRelatedEntities<SdkMessageRequest>("messagepair_sdkmessagerequest", null); }
            set
            {
                this.OnPropertyChanging("messagepair_sdkmessagerequest");
                this.SetRelatedEntities<SdkMessageRequest>("messagepair_sdkmessagerequest", null, value);
                this.OnPropertyChanged("messagepair_sdkmessagerequest");
            }
        }

        /// <summary>
        /// 1:N userentityinstancedata_sdkmessagepair
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_sdkmessagepair")]
        public System.Collections.Generic.IEnumerable<UserEntityInstanceData> userentityinstancedata_sdkmessagepair
        {
            get { return this.GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_sdkmessagepair", null); }
            set
            {
                this.OnPropertyChanging("userentityinstancedata_sdkmessagepair");
                this.SetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_sdkmessagepair", null, value);
                this.OnPropertyChanged("userentityinstancedata_sdkmessagepair");
            }
        }

        /// <summary>
        /// N:1 createdby_sdkmessagepair
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("createdby_sdkmessagepair")]
        public SystemUser createdby_sdkmessagepair
        {
            get { return this.GetRelatedEntity<SystemUser>("createdby_sdkmessagepair", null); }
        }

        /// <summary>
        /// N:1 lk_sdkmessagepair_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_sdkmessagepair_createdonbehalfby")]
        public SystemUser lk_sdkmessagepair_createdonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_sdkmessagepair_createdonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_sdkmessagepair_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_sdkmessagepair_modifiedonbehalfby")]
        public SystemUser lk_sdkmessagepair_modifiedonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_sdkmessagepair_modifiedonbehalfby", null); }
        }

        /// <summary>
        /// N:1 message_sdkmessagepair
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sdkmessageid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("message_sdkmessagepair")]
        public SdkMessage message_sdkmessagepair
        {
            get { return this.GetRelatedEntity<SdkMessage>("message_sdkmessagepair", null); }
        }

        /// <summary>
        /// N:1 modifiedby_sdkmessagepair
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("modifiedby_sdkmessagepair")]
        public SystemUser modifiedby_sdkmessagepair
        {
            get { return this.GetRelatedEntity<SystemUser>("modifiedby_sdkmessagepair", null); }
        }

        /// <summary>
        /// N:1 organization_sdkmessagepair
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_sdkmessagepair")]
        public Organization organization_sdkmessagepair
        {
            get { return this.GetRelatedEntity<Organization>("organization_sdkmessagepair", null); }
        }
    }
}