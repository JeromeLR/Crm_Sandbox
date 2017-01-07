namespace __4_DAL_CRM
{
    /// <summary>
    /// Permission to perform an action in Microsoft CRM. The platform checks for the privilege and rejects the attempt if the user does not hold the privilege.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("privilege")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class Privilege : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public Privilege() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "privilege";

        public const int EntityTypeCode = 1023;

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
        /// Rights a user has to an instance of an entity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("accessright")]
        public System.Nullable<int> AccessRight
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("accessright"); }
            set
            {
                this.OnPropertyChanging("AccessRight");
                this.SetAttributeValue("accessright", value);
                this.OnPropertyChanged("AccessRight");
            }
        }

        /// <summary>
        /// Information that specifies whether the privilege applies to the user, the user's team, or objects shared by the user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("canbebasic")]
        public System.Nullable<bool> CanBeBasic
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("canbebasic"); }
            set
            {
                this.OnPropertyChanging("CanBeBasic");
                this.SetAttributeValue("canbebasic", value);
                this.OnPropertyChanged("CanBeBasic");
            }
        }

        /// <summary>
        /// Information that specifies whether the privilege applies to child business units of the business unit associated with the user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("canbedeep")]
        public System.Nullable<bool> CanBeDeep
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("canbedeep"); }
            set
            {
                this.OnPropertyChanging("CanBeDeep");
                this.SetAttributeValue("canbedeep", value);
                this.OnPropertyChanged("CanBeDeep");
            }
        }

        /// <summary>
        /// Information that specifies whether the privilege applies to the entire organization.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("canbeglobal")]
        public System.Nullable<bool> CanBeGlobal
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("canbeglobal"); }
            set
            {
                this.OnPropertyChanging("CanBeGlobal");
                this.SetAttributeValue("canbeglobal", value);
                this.OnPropertyChanged("CanBeGlobal");
            }
        }

        /// <summary>
        /// Information that specifies whether the privilege applies to the user's business unit.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("canbelocal")]
        public System.Nullable<bool> CanBeLocal
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("canbelocal"); }
            set
            {
                this.OnPropertyChanging("CanBeLocal");
                this.SetAttributeValue("canbelocal", value);
                this.OnPropertyChanged("CanBeLocal");
            }
        }

        /// <summary>
        /// Name of the privilege.
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
        /// Unique identifier of the privilege.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("privilegeid")]
        public System.Nullable<System.Guid> PrivilegeId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("privilegeid"); }
            set
            {
                this.OnPropertyChanging("PrivilegeId");
                this.SetAttributeValue("privilegeid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("PrivilegeId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("privilegeid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.PrivilegeId = value; }
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
        /// 1:N Privilege_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Privilege_AsyncOperations")]
        public System.Collections.Generic.IEnumerable<AsyncOperation> Privilege_AsyncOperations
        {
            get { return this.GetRelatedEntities<AsyncOperation>("Privilege_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("Privilege_AsyncOperations");
                this.SetRelatedEntities<AsyncOperation>("Privilege_AsyncOperations", null, value);
                this.OnPropertyChanged("Privilege_AsyncOperations");
            }
        }

        /// <summary>
        /// 1:N Privilege_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Privilege_BulkDeleteFailures")]
        public System.Collections.Generic.IEnumerable<BulkDeleteFailure> Privilege_BulkDeleteFailures
        {
            get { return this.GetRelatedEntities<BulkDeleteFailure>("Privilege_BulkDeleteFailures", null); }
            set
            {
                this.OnPropertyChanging("Privilege_BulkDeleteFailures");
                this.SetRelatedEntities<BulkDeleteFailure>("Privilege_BulkDeleteFailures", null, value);
                this.OnPropertyChanged("Privilege_BulkDeleteFailures");
            }
        }

        /// <summary>
        /// 1:N userentityinstancedata_privilege
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_privilege")]
        public System.Collections.Generic.IEnumerable<UserEntityInstanceData> userentityinstancedata_privilege
        {
            get { return this.GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_privilege", null); }
            set
            {
                this.OnPropertyChanging("userentityinstancedata_privilege");
                this.SetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_privilege", null, value);
                this.OnPropertyChanged("userentityinstancedata_privilege");
            }
        }

        /// <summary>
        /// N:N roleprivileges_association
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("roleprivileges_association")]
        public System.Collections.Generic.IEnumerable<Role> roleprivileges_association
        {
            get { return this.GetRelatedEntities<Role>("roleprivileges_association", null); }
            set
            {
                this.OnPropertyChanging("roleprivileges_association");
                this.SetRelatedEntities<Role>("roleprivileges_association", null, value);
                this.OnPropertyChanged("roleprivileges_association");
            }
        }
    }
}