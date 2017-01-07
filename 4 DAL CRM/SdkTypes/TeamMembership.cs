namespace __4_DAL_CRM
{
    /// <summary>
    /// 
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("teammembership")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class TeamMembership : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public TeamMembership() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "teammembership";

        public const int EntityTypeCode = 23;

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
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("systemuserid")]
        public System.Nullable<System.Guid> SystemUserId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("systemuserid"); }
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
        /// Unique identifier of the team membership.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("teammembershipid")]
        public System.Nullable<System.Guid> TeamMembershipId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("teammembershipid"); }
            set
            {
                this.OnPropertyChanging("TeamMembershipId");
                this.SetAttributeValue("teammembershipid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("TeamMembershipId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("teammembershipid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.TeamMembershipId = value; }
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
        /// 1:N userentityinstancedata_teammembership
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_teammembership")]
        public System.Collections.Generic.IEnumerable<UserEntityInstanceData> userentityinstancedata_teammembership
        {
            get { return this.GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_teammembership", null); }
            set
            {
                this.OnPropertyChanging("userentityinstancedata_teammembership");
                this.SetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_teammembership", null, value);
                this.OnPropertyChanged("userentityinstancedata_teammembership");
            }
        }

        /// <summary>
        /// N:N teammembership_association
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("teammembership_association")]
        public System.Collections.Generic.IEnumerable<Team> teammembership_association
        {
            get { return this.GetRelatedEntities<Team>("teammembership_association", null); }
            set
            {
                this.OnPropertyChanging("teammembership_association");
                this.SetRelatedEntities<Team>("teammembership_association", null, value);
                this.OnPropertyChanged("teammembership_association");
            }
        }
    }
}