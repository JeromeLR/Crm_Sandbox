namespace __4_DAL_CRM
{
    /// <summary>
    /// 
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("contactorders")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class ContactOrders : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public ContactOrders() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "contactorders";

        public const int EntityTypeCode = 19;

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
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("contactid")]
        public System.Nullable<System.Guid> ContactId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("contactid"); }
        }

        /// <summary>
        /// Unique identifier of the orders for the contact.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("contactorderid")]
        public System.Nullable<System.Guid> ContactOrderId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("contactorderid"); }
            set
            {
                this.OnPropertyChanging("ContactOrderId");
                this.SetAttributeValue("contactorderid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("ContactOrderId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("contactorderid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.ContactOrderId = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("salesorderid")]
        public System.Nullable<System.Guid> SalesOrderId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("salesorderid"); }
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
        /// N:N contactorders_association
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("contactorders_association")]
        public System.Collections.Generic.IEnumerable<SalesOrder> contactorders_association
        {
            get { return this.GetRelatedEntities<SalesOrder>("contactorders_association", null); }
            set
            {
                this.OnPropertyChanging("contactorders_association");
                this.SetRelatedEntities<SalesOrder>("contactorders_association", null, value);
                this.OnPropertyChanged("contactorders_association");
            }
        }
    }
}