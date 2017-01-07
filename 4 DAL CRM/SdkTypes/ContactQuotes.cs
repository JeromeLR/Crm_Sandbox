namespace __4_DAL_CRM
{
    /// <summary>
    /// 
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("contactquotes")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class ContactQuotes : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public ContactQuotes() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "contactquotes";

        public const int EntityTypeCode = 18;

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
        /// Unique identifier of the quotes for the contact.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("contactquoteid")]
        public System.Nullable<System.Guid> ContactQuoteId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("contactquoteid"); }
            set
            {
                this.OnPropertyChanging("ContactQuoteId");
                this.SetAttributeValue("contactquoteid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("ContactQuoteId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("contactquoteid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.ContactQuoteId = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("quoteid")]
        public System.Nullable<System.Guid> QuoteId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("quoteid"); }
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
        /// N:N contactquotes_association
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("contactquotes_association")]
        public System.Collections.Generic.IEnumerable<Quote> contactquotes_association
        {
            get { return this.GetRelatedEntities<Quote>("contactquotes_association", null); }
            set
            {
                this.OnPropertyChanging("contactquotes_association");
                this.SetRelatedEntities<Quote>("contactquotes_association", null, value);
                this.OnPropertyChanged("contactquotes_association");
            }
        }
    }
}