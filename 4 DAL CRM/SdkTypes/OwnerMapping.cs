namespace __4_DAL_CRM
{
    /// <summary>
    /// In a data map, maps ownership data from the source file to Microsoft Dynamics CRM.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("ownermapping")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class OwnerMapping : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public OwnerMapping() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "ownermapping";

        public const int EntityTypeCode = 4420;

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
        /// Unique identifier of the user who created the owner mapping.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby"); }
        }

        /// <summary>
        /// Date and time when the owner mapping was created.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
        public System.Nullable<System.DateTime> CreatedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who created the ownermapping.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        /// Unique identifier of the data map with which the owner mapping is associated.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("importmapid")]
        public Microsoft.Xrm.Sdk.EntityReference ImportMapId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("importmapid"); }
            set
            {
                this.OnPropertyChanging("ImportMapId");
                this.SetAttributeValue("importmapid", value);
                this.OnPropertyChanged("ImportMapId");
            }
        }

        /// <summary>
        /// Unique identifier of the user who last modified the lookup mapping.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby"); }
        }

        /// <summary>
        /// Date and time when the owner mapping was last modified.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
        public System.Nullable<System.DateTime> ModifiedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who last modified the ownermapping.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        /// Unique identifier of the owner mapping.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ownermappingid")]
        public System.Nullable<System.Guid> OwnerMappingId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("ownermappingid"); }
            set
            {
                this.OnPropertyChanging("OwnerMappingId");
                this.SetAttributeValue("ownermappingid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("OwnerMappingId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ownermappingid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.OwnerMappingId = value; }
        }

        /// <summary>
        /// Code that indicates whether the owner mapping has to be processed
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("processcode")]
        public Microsoft.Xrm.Sdk.OptionSetValue ProcessCode
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("processcode"); }
            set
            {
                this.OnPropertyChanging("ProcessCode");
                this.SetAttributeValue("processcode", value);
                this.OnPropertyChanged("ProcessCode");
            }
        }

        /// <summary>
        /// Source user name that has to be replaced
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sourcesystemusername")]
        public string SourceSystemUserName
        {
            get { return this.GetAttributeValue<string>("sourcesystemusername"); }
            set
            {
                this.OnPropertyChanging("SourceSystemUserName");
                this.SetAttributeValue("sourcesystemusername", value);
                this.OnPropertyChanged("SourceSystemUserName");
            }
        }

        /// <summary>
        /// Source user value for source Microsoft Dynamics CRM user link.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sourceuservalueforsourcecrmuserlink")]
        public string SourceUserValueForSourceCRMUserLink
        {
            get { return this.GetAttributeValue<string>("sourceuservalueforsourcecrmuserlink"); }
            set
            {
                this.OnPropertyChanging("SourceUserValueForSourceCRMUserLink");
                this.SetAttributeValue("sourceuservalueforsourcecrmuserlink", value);
                this.OnPropertyChanged("SourceUserValueForSourceCRMUserLink");
            }
        }

        /// <summary>
        /// Status of the owner mapping.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
        public System.Nullable<OwnerMappingState> StateCode
        {
            get
            {
                Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
                if ((optionSet != null))
                {
                    return ((OwnerMappingState) (System.Enum.ToObject(typeof(OwnerMappingState), optionSet.Value)));
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// Reason for the status of the owner mapping.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statuscode")]
        public Microsoft.Xrm.Sdk.OptionSetValue StatusCode
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statuscode"); }
            set
            {
                this.OnPropertyChanging("StatusCode");
                this.SetAttributeValue("statuscode", value);
                this.OnPropertyChanged("StatusCode");
            }
        }

        /// <summary>
        /// Microsoft Dynamics CRM logon name with which the source user name should be replaced.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("targetsystemuserdomainname")]
        public string TargetSystemUserDomainName
        {
            get { return this.GetAttributeValue<string>("targetsystemuserdomainname"); }
            set
            {
                this.OnPropertyChanging("TargetSystemUserDomainName");
                this.SetAttributeValue("targetsystemuserdomainname", value);
                this.OnPropertyChanged("TargetSystemUserDomainName");
            }
        }

        /// <summary>
        /// Unique identifier of the Microsoft Dynamics CRM user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("targetsystemuserid")]
        public Microsoft.Xrm.Sdk.EntityReference TargetSystemUserId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("targetsystemuserid"); }
            set
            {
                this.OnPropertyChanging("TargetSystemUserId");
                this.SetAttributeValue("targetsystemuserid", value);
                this.OnPropertyChanged("TargetSystemUserId");
            }
        }

        /// <summary>
        /// Microsoft Dynamics CRM user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("targetuservalueforsourcecrmuserlink")]
        public string TargetUserValueForSourceCRMUserLink
        {
            get { return this.GetAttributeValue<string>("targetuservalueforsourcecrmuserlink"); }
            set
            {
                this.OnPropertyChanging("TargetUserValueForSourceCRMUserLink");
                this.SetAttributeValue("targetuservalueforsourcecrmuserlink", value);
                this.OnPropertyChanged("TargetUserValueForSourceCRMUserLink");
            }
        }

        /// <summary>
        /// 1:N userentityinstancedata_ownermapping
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_ownermapping")]
        public System.Collections.Generic.IEnumerable<UserEntityInstanceData> userentityinstancedata_ownermapping
        {
            get { return this.GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_ownermapping", null); }
            set
            {
                this.OnPropertyChanging("userentityinstancedata_ownermapping");
                this.SetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_ownermapping", null, value);
                this.OnPropertyChanged("userentityinstancedata_ownermapping");
            }
        }

        /// <summary>
        /// N:1 lk_ownermapping_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ownermapping_createdby")]
        public SystemUser lk_ownermapping_createdby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_ownermapping_createdby", null); }
        }

        /// <summary>
        /// N:1 lk_ownermapping_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ownermapping_createdonbehalfby")]
        public SystemUser lk_ownermapping_createdonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_ownermapping_createdonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_ownermapping_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ownermapping_modifiedby")]
        public SystemUser lk_ownermapping_modifiedby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_ownermapping_modifiedby", null); }
        }

        /// <summary>
        /// N:1 lk_ownermapping_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ownermapping_modifiedonbehalfby")]
        public SystemUser lk_ownermapping_modifiedonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_ownermapping_modifiedonbehalfby", null); }
        }

        /// <summary>
        /// N:1 OwnerMapping_ImportMap
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("importmapid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("OwnerMapping_ImportMap")]
        public ImportMap OwnerMapping_ImportMap
        {
            get { return this.GetRelatedEntity<ImportMap>("OwnerMapping_ImportMap", null); }
            set
            {
                this.OnPropertyChanging("OwnerMapping_ImportMap");
                this.SetRelatedEntity<ImportMap>("OwnerMapping_ImportMap", null, value);
                this.OnPropertyChanged("OwnerMapping_ImportMap");
            }
        }

        /// <summary>
        /// N:1 OwnerMapping_SystemUser
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("targetsystemuserid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("OwnerMapping_SystemUser")]
        public SystemUser OwnerMapping_SystemUser
        {
            get { return this.GetRelatedEntity<SystemUser>("OwnerMapping_SystemUser", null); }
            set
            {
                this.OnPropertyChanging("OwnerMapping_SystemUser");
                this.SetRelatedEntity<SystemUser>("OwnerMapping_SystemUser", null, value);
                this.OnPropertyChanged("OwnerMapping_SystemUser");
            }
        }
    }
}