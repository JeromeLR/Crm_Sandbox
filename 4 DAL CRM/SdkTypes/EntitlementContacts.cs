using _4_DAL_CRM;

namespace __4_DAL_CRM
{
    /// <summary>
    /// 
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("entitlementcontacts")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class EntitlementContacts : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public EntitlementContacts() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "entitlementcontacts";

        public const int EntityTypeCode = 7272;

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
        /// Unique identifier of the contacts for the entitlements.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entitlementcontactid")]
        public System.Nullable<System.Guid> EntitlementContactId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("entitlementcontactid"); }
            set
            {
                this.OnPropertyChanging("EntitlementContactId");
                this.SetAttributeValue("entitlementcontactid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("EntitlementContactId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entitlementcontactid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.EntitlementContactId = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entitlementid")]
        public System.Nullable<System.Guid> EntitlementId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("entitlementid"); }
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
        /// N:N entitlementcontacts_association
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("entitlementcontacts_association")]
        public System.Collections.Generic.IEnumerable<Contact> entitlementcontacts_association
        {
            get { return this.GetRelatedEntities<Contact>("entitlementcontacts_association", null); }
            set
            {
                this.OnPropertyChanging("entitlementcontacts_association");
                this.SetRelatedEntities<Contact>("entitlementcontacts_association", null, value);
                this.OnPropertyChanged("entitlementcontacts_association");
            }
        }
    }
}