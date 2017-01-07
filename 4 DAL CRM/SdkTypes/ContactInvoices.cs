namespace __4_DAL_CRM
{
    /// <summary>
    /// 
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("contactinvoices")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class ContactInvoices : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public ContactInvoices() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "contactinvoices";

        public const int EntityTypeCode = 17;

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
        /// Unique identifier of the invoices for the contact.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("contactinvoiceid")]
        public System.Nullable<System.Guid> ContactInvoiceId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("contactinvoiceid"); }
            set
            {
                this.OnPropertyChanging("ContactInvoiceId");
                this.SetAttributeValue("contactinvoiceid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("ContactInvoiceId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("contactinvoiceid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.ContactInvoiceId = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("invoiceid")]
        public System.Nullable<System.Guid> InvoiceId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("invoiceid"); }
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
        /// N:N contactinvoices_association
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("contactinvoices_association")]
        public System.Collections.Generic.IEnumerable<Invoice> contactinvoices_association
        {
            get { return this.GetRelatedEntities<Invoice>("contactinvoices_association", null); }
            set
            {
                this.OnPropertyChanging("contactinvoices_association");
                this.SetRelatedEntities<Invoice>("contactinvoices_association", null, value);
                this.OnPropertyChanged("contactinvoices_association");
            }
        }
    }
}