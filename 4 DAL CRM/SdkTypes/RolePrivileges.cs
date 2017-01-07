namespace __4_DAL_CRM
{
    /// <summary>
    /// Group of privileges used to categorize users to provide appropriate access to entities.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("roleprivileges")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class RolePrivileges : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public RolePrivileges() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "roleprivileges";

        public const int EntityTypeCode = 12;

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
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("componentstate")]
        public Microsoft.Xrm.Sdk.OptionSetValue ComponentState
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("componentstate"); }
        }

        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ismanaged")]
        public System.Nullable<bool> IsManaged
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("ismanaged"); }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("overwritetime")]
        public System.Nullable<System.DateTime> OverwriteTime
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("overwritetime"); }
        }

        /// <summary>
        /// System-generated attribute that stores the privileges associated with the role.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("privilegedepthmask")]
        public System.Nullable<int> PrivilegeDepthMask
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("privilegedepthmask"); }
            set
            {
                this.OnPropertyChanging("PrivilegeDepthMask");
                this.SetAttributeValue("privilegedepthmask", value);
                this.OnPropertyChanged("PrivilegeDepthMask");
            }
        }

        /// <summary>
        /// Unique identifier of the privilege associated with the role.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("privilegeid")]
        public System.Nullable<System.Guid> PrivilegeId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("privilegeid"); }
        }

        /// <summary>
        /// Unique identifier of the role that is associated with the role privilege.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("roleid")]
        public System.Nullable<System.Guid> RoleId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("roleid"); }
        }

        /// <summary>
        /// Unique identifier of the role privilege.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("roleprivilegeid")]
        public System.Nullable<System.Guid> RolePrivilegeId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("roleprivilegeid"); }
            set
            {
                this.OnPropertyChanging("RolePrivilegeId");
                this.SetAttributeValue("roleprivilegeid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("RolePrivilegeId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("roleprivilegeid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.RolePrivilegeId = value; }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("roleprivilegeidunique")]
        public System.Nullable<System.Guid> RolePrivilegeIdUnique
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("roleprivilegeidunique"); }
        }

        /// <summary>
        /// Unique identifier of the associated solution.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("solutionid")]
        public System.Nullable<System.Guid> SolutionId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("solutionid"); }
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
        /// N:N roleprivileges_association
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("roleprivileges_association")]
        public System.Collections.Generic.IEnumerable<Privilege> roleprivileges_association
        {
            get { return this.GetRelatedEntities<Privilege>("roleprivileges_association", null); }
            set
            {
                this.OnPropertyChanging("roleprivileges_association");
                this.SetRelatedEntities<Privilege>("roleprivileges_association", null, value);
                this.OnPropertyChanged("roleprivileges_association");
            }
        }
    }
}