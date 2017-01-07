namespace __4_DAL_CRM
{
    /// <summary>
    /// Track changes to records for analysis, record keeping, and compliance.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("audit")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class Audit : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public Audit() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "audit";

        public const int EntityTypeCode = 4567;

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
        /// Actions the user can perform that cause a change
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("action")]
        public Microsoft.Xrm.Sdk.OptionSetValue Action
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("action"); }
        }

        /// <summary>
        /// Contains a CSV of the ColumnNumber metadata property of attributes
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("attributemask")]
        public string AttributeMask
        {
            get { return this.GetAttributeValue<string>("attributemask"); }
        }

        /// <summary>
        /// Unique identifier of the auditing instance
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("auditid")]
        public System.Nullable<System.Guid> AuditId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("auditid"); }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("auditid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { base.Id = value; }
        }

        /// <summary>
        /// Unique identifier of the calling user in case of an impersonated call
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("callinguserid")]
        public Microsoft.Xrm.Sdk.EntityReference CallingUserId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("callinguserid"); }
        }

        /// <summary>
        /// Date and time when the audit record was created.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
        public System.Nullable<System.DateTime> CreatedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon"); }
        }

        /// <summary>
        /// Unique identifier of the record that is being audited
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
        public Microsoft.Xrm.Sdk.EntityReference ObjectId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("objectid"); }
        }

        /// <summary>
        /// The action that causes the audit--it will be create, delete, or update
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("operation")]
        public Microsoft.Xrm.Sdk.OptionSetValue Operation
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("operation"); }
        }

        /// <summary>
        /// Unique identifier for multiple changes that are part of a single operation; this field contains the same GUID for all the audit rows generated in a single transaction
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactionid")]
        public System.Nullable<System.Guid> TransactionId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("transactionid"); }
        }

        /// <summary>
        /// Unique identifier of the user who caused a change
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("userid")]
        public Microsoft.Xrm.Sdk.EntityReference UserId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("userid"); }
        }

        /// <summary>
        /// 1:N userentityinstancedata_audit
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_audit")]
        public System.Collections.Generic.IEnumerable<UserEntityInstanceData> userentityinstancedata_audit
        {
            get { return this.GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_audit", null); }
            set
            {
                this.OnPropertyChanging("userentityinstancedata_audit");
                this.SetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_audit", null, value);
                this.OnPropertyChanged("userentityinstancedata_audit");
            }
        }

        /// <summary>
        /// N:1 lk_audit_callinguserid
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("callinguserid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_audit_callinguserid")]
        public SystemUser lk_audit_callinguserid
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_audit_callinguserid", null); }
        }

        /// <summary>
        /// N:1 lk_audit_userid
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("userid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_audit_userid")]
        public SystemUser lk_audit_userid
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_audit_userid", null); }
        }
    }
}