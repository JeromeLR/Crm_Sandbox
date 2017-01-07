using _4_DAL_CRM;

namespace __4_DAL_CRM
{
    /// <summary>
    /// 
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("servicecontractcontacts")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class ServiceContractContacts : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public ServiceContractContacts() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "servicecontractcontacts";

        public const int EntityTypeCode = 20;

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
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("contractid")]
        public System.Nullable<System.Guid> ContractId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("contractid"); }
        }

        /// <summary>
        /// Unique identifier of the contact of the service contract.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("servicecontractcontactid")]
        public System.Nullable<System.Guid> ServiceContractContactId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("servicecontractcontactid"); }
            set
            {
                this.OnPropertyChanging("ServiceContractContactId");
                this.SetAttributeValue("servicecontractcontactid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("ServiceContractContactId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("servicecontractcontactid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.ServiceContractContactId = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("servicelevel")]
        public System.Nullable<int> ServiceLevel
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("servicelevel"); }
            set
            {
                this.OnPropertyChanging("ServiceLevel");
                this.SetAttributeValue("servicelevel", value);
                this.OnPropertyChanged("ServiceLevel");
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
        /// N:N servicecontractcontacts_association
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("servicecontractcontacts_association")]
        public System.Collections.Generic.IEnumerable<Contact> servicecontractcontacts_association
        {
            get { return this.GetRelatedEntities<Contact>("servicecontractcontacts_association", null); }
            set
            {
                this.OnPropertyChanging("servicecontractcontacts_association");
                this.SetRelatedEntities<Contact>("servicecontractcontacts_association", null, value);
                this.OnPropertyChanged("servicecontractcontacts_association");
            }
        }
    }
}