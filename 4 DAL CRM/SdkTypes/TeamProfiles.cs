namespace __4_DAL_CRM
{
    /// <summary>
    /// Team Profiles
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("teamprofiles")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class TeamProfiles : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public TeamProfiles() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "teamprofiles";

        public const int EntityTypeCode = 1203;

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
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("fieldsecurityprofileid")]
        public System.Nullable<System.Guid> FieldSecurityProfileId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("fieldsecurityprofileid"); }
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
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("teamprofileid")]
        public System.Nullable<System.Guid> TeamProfileId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("teamprofileid"); }
            set
            {
                this.OnPropertyChanging("TeamProfileId");
                this.SetAttributeValue("teamprofileid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("TeamProfileId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("teamprofileid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.TeamProfileId = value; }
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
        /// N:N teamprofiles_association
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("teamprofiles_association")]
        public System.Collections.Generic.IEnumerable<Team> teamprofiles_association
        {
            get { return this.GetRelatedEntities<Team>("teamprofiles_association", null); }
            set
            {
                this.OnPropertyChanging("teamprofiles_association");
                this.SetRelatedEntities<Team>("teamprofiles_association", null, value);
                this.OnPropertyChanged("teamprofiles_association");
            }
        }
    }
}