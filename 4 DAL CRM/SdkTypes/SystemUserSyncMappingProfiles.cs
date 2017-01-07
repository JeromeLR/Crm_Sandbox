namespace __4_DAL_CRM
{
    /// <summary>
    /// 
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("systemusersyncmappingprofiles")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class SystemUserSyncMappingProfiles : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public SystemUserSyncMappingProfiles() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "systemusersyncmappingprofiles";

        public const int EntityTypeCode = 1402;

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
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("syncattributemappingprofileid")]
        public System.Nullable<System.Guid> SyncAttributeMappingProfileId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("syncattributemappingprofileid"); }
        }

        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("systemuserid")]
        public System.Nullable<System.Guid> SystemUserId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("systemuserid"); }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("systemusersyncmappingprofileid")]
        public System.Nullable<System.Guid> SystemUserSyncMappingProfileId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("systemusersyncmappingprofileid"); }
            set
            {
                this.OnPropertyChanging("SystemUserSyncMappingProfileId");
                this.SetAttributeValue("systemusersyncmappingprofileid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("SystemUserSyncMappingProfileId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("systemusersyncmappingprofileid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.SystemUserSyncMappingProfileId = value; }
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
        /// N:N systemusersyncmappingprofiles_association
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("systemusersyncmappingprofiles_association")]
        public System.Collections.Generic.IEnumerable<SystemUser> systemusersyncmappingprofiles_association
        {
            get { return this.GetRelatedEntities<SystemUser>("systemusersyncmappingprofiles_association", null); }
            set
            {
                this.OnPropertyChanging("systemusersyncmappingprofiles_association");
                this.SetRelatedEntities<SystemUser>("systemusersyncmappingprofiles_association", null, value);
                this.OnPropertyChanged("systemusersyncmappingprofiles_association");
            }
        }
    }
}