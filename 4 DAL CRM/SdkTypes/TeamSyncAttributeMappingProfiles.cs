namespace __4_DAL_CRM
{
    /// <summary>
    /// Team Sync-Attribute Mapping Profiles
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("teamsyncattributemappingprofiles")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class TeamSyncAttributeMappingProfiles : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public TeamSyncAttributeMappingProfiles() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "teamsyncattributemappingprofiles";

        public const int EntityTypeCode = 1403;

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
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("teamid")]
        public System.Nullable<System.Guid> TeamId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("teamid"); }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("teamsyncattributemappingprofileid")]
        public System.Nullable<System.Guid> TeamSyncAttributeMappingProfileId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("teamsyncattributemappingprofileid"); }
            set
            {
                this.OnPropertyChanging("TeamSyncAttributeMappingProfileId");
                this.SetAttributeValue("teamsyncattributemappingprofileid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("TeamSyncAttributeMappingProfileId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("teamsyncattributemappingprofileid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.TeamSyncAttributeMappingProfileId = value; }
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
        /// N:N teamsyncattributemappingprofiles_association
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("teamsyncattributemappingprofiles_association")]
        public System.Collections.Generic.IEnumerable<Team> teamsyncattributemappingprofiles_association
        {
            get { return this.GetRelatedEntities<Team>("teamsyncattributemappingprofiles_association", null); }
            set
            {
                this.OnPropertyChanging("teamsyncattributemappingprofiles_association");
                this.SetRelatedEntities<Team>("teamsyncattributemappingprofiles_association", null, value);
                this.OnPropertyChanged("teamsyncattributemappingprofiles_association");
            }
        }
    }
}