using _4_DAL_CRM;

namespace __4_DAL_CRM
{
    /// <summary>
    /// 
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("contactleads")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class ContactLeads : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public ContactLeads() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "contactleads";

        public const int EntityTypeCode = 22;

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
        /// Unique identifier of the leads for the contact.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("contactleadid")]
        public System.Nullable<System.Guid> ContactLeadId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("contactleadid"); }
            set
            {
                this.OnPropertyChanging("ContactLeadId");
                this.SetAttributeValue("contactleadid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("ContactLeadId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("contactleadid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.ContactLeadId = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("leadid")]
        public System.Nullable<System.Guid> LeadId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("leadid"); }
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
        /// N:N contactleads_association
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("contactleads_association")]
        public System.Collections.Generic.IEnumerable<Contact> contactleads_association
        {
            get { return this.GetRelatedEntities<Contact>("contactleads_association", null); }
            set
            {
                this.OnPropertyChanging("contactleads_association");
                this.SetRelatedEntities<Contact>("contactleads_association", null, value);
                this.OnPropertyChanged("contactleads_association");
            }
        }
    }
}