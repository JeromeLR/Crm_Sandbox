namespace __4_DAL_CRM
{
    /// <summary>
    /// 
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("roletemplateprivileges")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class RoleTemplatePrivileges : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public RoleTemplatePrivileges() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "roletemplateprivileges";

        public const int EntityTypeCode = 28;

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
        /// Information about whether the role in the template applies to the user, the user's team, or objects shared by the user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isbasic")]
        public System.Nullable<bool> IsBasic
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("isbasic"); }
            set
            {
                this.OnPropertyChanging("IsBasic");
                this.SetAttributeValue("isbasic", value);
                this.OnPropertyChanged("IsBasic");
            }
        }

        /// <summary>
        /// Information about whether the role in the template applies to child business units of the business unit associated with the user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isdeep")]
        public System.Nullable<bool> IsDeep
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("isdeep"); }
            set
            {
                this.OnPropertyChanging("IsDeep");
                this.SetAttributeValue("isdeep", value);
                this.OnPropertyChanged("IsDeep");
            }
        }

        /// <summary>
        /// Information about whether the role in the template applies to the entire organization.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isglobal")]
        public System.Nullable<bool> IsGlobal
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("isglobal"); }
            set
            {
                this.OnPropertyChanging("IsGlobal");
                this.SetAttributeValue("isglobal", value);
                this.OnPropertyChanged("IsGlobal");
            }
        }

        /// <summary>
        /// Information about whether the role in the template applies to the user's business unit.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("islocal")]
        public System.Nullable<bool> IsLocal
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("islocal"); }
            set
            {
                this.OnPropertyChanging("IsLocal");
                this.SetAttributeValue("islocal", value);
                this.OnPropertyChanged("IsLocal");
            }
        }

        /// <summary>
        /// Unique identifier of the privilege assigned to the role template.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("privilegeid")]
        public System.Nullable<System.Guid> PrivilegeId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("privilegeid"); }
        }

        /// <summary>
        /// Unique identifier of the role template that is associated with the role privilege.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("roletemplateid")]
        public System.Nullable<System.Guid> RoleTemplateId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("roletemplateid"); }
        }

        /// <summary>
        /// Unique identifier of the role template privileges.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("roletemplateprivilegeid")]
        public System.Nullable<System.Guid> RoleTemplatePrivilegeId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("roletemplateprivilegeid"); }
            set
            {
                this.OnPropertyChanging("RoleTemplatePrivilegeId");
                this.SetAttributeValue("roletemplateprivilegeid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("RoleTemplatePrivilegeId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("roletemplateprivilegeid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.RoleTemplatePrivilegeId = value; }
        }
    }
}