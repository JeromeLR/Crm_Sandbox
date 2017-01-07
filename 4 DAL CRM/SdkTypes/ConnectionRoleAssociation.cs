namespace __4_DAL_CRM
{
    /// <summary>
    /// 
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("connectionroleassociation")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class ConnectionRoleAssociation : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public ConnectionRoleAssociation() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "connectionroleassociation";

        public const int EntityTypeCode = 3232;

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
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("associatedconnectionroleid")]
        public System.Nullable<System.Guid> AssociatedConnectionRoleId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("associatedconnectionroleid"); }
            set
            {
                this.OnPropertyChanging("AssociatedConnectionRoleId");
                this.SetAttributeValue("associatedconnectionroleid", value);
                this.OnPropertyChanged("AssociatedConnectionRoleId");
            }
        }

        /// <summary>
        /// Unique identifier of the connection role association.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("connectionroleassociationid")]
        public System.Nullable<System.Guid> ConnectionRoleAssociationId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("connectionroleassociationid"); }
            set
            {
                this.OnPropertyChanging("ConnectionRoleAssociationId");
                this.SetAttributeValue("connectionroleassociationid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("ConnectionRoleAssociationId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("connectionroleassociationid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.ConnectionRoleAssociationId = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("connectionroleid")]
        public System.Nullable<System.Guid> ConnectionRoleId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("connectionroleid"); }
            set
            {
                this.OnPropertyChanging("ConnectionRoleId");
                this.SetAttributeValue("connectionroleid", value);
                this.OnPropertyChanged("ConnectionRoleId");
            }
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
        /// 1:N userentityinstancedata_connectionroleassociation
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_connectionroleassociation")]
        public System.Collections.Generic.IEnumerable<UserEntityInstanceData> userentityinstancedata_connectionroleassociation
        {
            get { return this.GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_connectionroleassociation", null); }
            set
            {
                this.OnPropertyChanging("userentityinstancedata_connectionroleassociation");
                this.SetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_connectionroleassociation", null, value);
                this.OnPropertyChanged("userentityinstancedata_connectionroleassociation");
            }
        }

        /// <summary>
        /// N:N connectionroleassociation_association
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("connectionroleassociation_association")]
        public System.Collections.Generic.IEnumerable<ConnectionRole> connectionroleassociation_association
        {
            get { return this.GetRelatedEntities<ConnectionRole>("connectionroleassociation_association", null); }
            set
            {
                this.OnPropertyChanging("connectionroleassociation_association");
                this.SetRelatedEntities<ConnectionRole>("connectionroleassociation_association", null, value);
                this.OnPropertyChanged("connectionroleassociation_association");
            }
        }
    }
}