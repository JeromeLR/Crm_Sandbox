namespace __4_DAL_CRM
{
    /// <summary>
    /// 
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("queuemembership")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class QueueMembership : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public QueueMembership() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "queuemembership";

        public const int EntityTypeCode = 1213;

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
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("queueid")]
        public System.Nullable<System.Guid> QueueId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("queueid"); }
        }

        /// <summary>
        /// Unique identifier of the queue membership.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("queuemembershipid")]
        public System.Nullable<System.Guid> QueueMembershipId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("queuemembershipid"); }
            set
            {
                this.OnPropertyChanging("QueueMembershipId");
                this.SetAttributeValue("queuemembershipid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("QueueMembershipId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("queuemembershipid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.QueueMembershipId = value; }
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
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
        public System.Nullable<long> VersionNumber
        {
            get { return this.GetAttributeValue<System.Nullable<long>>("versionnumber"); }
        }

        /// <summary>
        /// N:N queuemembership_association
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("queuemembership_association")]
        public System.Collections.Generic.IEnumerable<Queue> queuemembership_association
        {
            get { return this.GetRelatedEntities<Queue>("queuemembership_association", null); }
            set
            {
                this.OnPropertyChanging("queuemembership_association");
                this.SetRelatedEntities<Queue>("queuemembership_association", null, value);
                this.OnPropertyChanged("queuemembership_association");
            }
        }
    }
}