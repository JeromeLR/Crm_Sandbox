namespace __4_DAL_CRM
{
    /// <summary>
    /// Specifies the entity type that can play specific role in a connection.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("connectionroleobjecttypecode")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class ConnectionRoleObjectTypeCode : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public ConnectionRoleObjectTypeCode() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "connectionroleobjecttypecode";

        public const int EntityTypeCode = 3233;

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
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("associatedobjecttypecode")]
        public string AssociatedObjectTypeCode
        {
            get { return this.GetAttributeValue<string>("associatedobjecttypecode"); }
            set
            {
                this.OnPropertyChanging("AssociatedObjectTypeCode");
                this.SetAttributeValue("associatedobjecttypecode", value);
                this.OnPropertyChanged("AssociatedObjectTypeCode");
            }
        }

        /// <summary>
        /// Unique identifier of the connection role associated with the Connection Role Object Type Code.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("connectionroleid")]
        public Microsoft.Xrm.Sdk.EntityReference ConnectionRoleId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("connectionroleid"); }
            set
            {
                this.OnPropertyChanging("ConnectionRoleId");
                this.SetAttributeValue("connectionroleid", value);
                this.OnPropertyChanged("ConnectionRoleId");
            }
        }

        /// <summary>
        /// Unique identifier of the connection role object type association.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("connectionroleobjecttypecodeid")]
        public System.Nullable<System.Guid> ConnectionRoleObjectTypeCodeId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("connectionroleobjecttypecodeid"); }
            set
            {
                this.OnPropertyChanging("ConnectionRoleObjectTypeCodeId");
                this.SetAttributeValue("connectionroleobjecttypecodeid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("ConnectionRoleObjectTypeCodeId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("connectionroleobjecttypecodeid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.ConnectionRoleObjectTypeCodeId = value; }
        }

        /// <summary>
        /// Unique identifier of the organization associated with the connectionroleobjecttypecode.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
        public System.Nullable<System.Guid> OrganizationId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("organizationid"); }
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
        /// 1:N userentityinstancedata_connectionroleobjecttypecode
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_connectionroleobjecttypecode")]
        public System.Collections.Generic.IEnumerable<UserEntityInstanceData> userentityinstancedata_connectionroleobjecttypecode
        {
            get { return this.GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_connectionroleobjecttypecode", null); }
            set
            {
                this.OnPropertyChanging("userentityinstancedata_connectionroleobjecttypecode");
                this.SetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_connectionroleobjecttypecode", null, value);
                this.OnPropertyChanged("userentityinstancedata_connectionroleobjecttypecode");
            }
        }

        /// <summary>
        /// N:1 connection_role_connection_role_object_type_codes
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("connectionroleid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("connection_role_connection_role_object_type_codes")]
        public ConnectionRole connection_role_connection_role_object_type_codes
        {
            get { return this.GetRelatedEntity<ConnectionRole>("connection_role_connection_role_object_type_codes", null); }
            set
            {
                this.OnPropertyChanging("connection_role_connection_role_object_type_codes");
                this.SetRelatedEntity<ConnectionRole>("connection_role_connection_role_object_type_codes", null, value);
                this.OnPropertyChanged("connection_role_connection_role_object_type_codes");
            }
        }
    }
}