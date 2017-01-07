namespace __4_DAL_CRM
{
    /// <summary>
    /// 
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("teamroles")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class TeamRoles : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public TeamRoles() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "teamroles";

        public const int EntityTypeCode = 40;

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
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("roleid")]
        public System.Nullable<System.Guid> RoleId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("roleid"); }
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
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("teamroleid")]
        public System.Nullable<System.Guid> TeamRoleId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("teamroleid"); }
            set
            {
                this.OnPropertyChanging("TeamRoleId");
                this.SetAttributeValue("teamroleid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("TeamRoleId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("teamroleid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.TeamRoleId = value; }
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
        /// N:N teamroles_association
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("teamroles_association")]
        public System.Collections.Generic.IEnumerable<Team> teamroles_association
        {
            get { return this.GetRelatedEntities<Team>("teamroles_association", null); }
            set
            {
                this.OnPropertyChanging("teamroles_association");
                this.SetRelatedEntities<Team>("teamroles_association", null, value);
                this.OnPropertyChanged("teamroles_association");
            }
        }
    }
}