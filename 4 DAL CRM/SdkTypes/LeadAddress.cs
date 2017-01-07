namespace __4_DAL_CRM
{
    /// <summary>
    /// Address information for a lead.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("leadaddress")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class LeadAddress : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public LeadAddress() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "leadaddress";

        public const int EntityTypeCode = 1017;

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
        /// Information about the address for the lead.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("addressnumber")]
        public System.Nullable<int> AddressNumber
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("addressnumber"); }
            set
            {
                this.OnPropertyChanging("AddressNumber");
                this.SetAttributeValue("addressnumber", value);
                this.OnPropertyChanged("AddressNumber");
            }
        }

        /// <summary>
        /// Type of address for the lead address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("addresstypecode")]
        public Microsoft.Xrm.Sdk.OptionSetValue AddressTypeCode
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("addresstypecode"); }
            set
            {
                this.OnPropertyChanging("AddressTypeCode");
                this.SetAttributeValue("addresstypecode", value);
                this.OnPropertyChanged("AddressTypeCode");
            }
        }

        /// <summary>
        /// City name in the address for the lead.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("city")]
        public string City
        {
            get { return this.GetAttributeValue<string>("city"); }
            set
            {
                this.OnPropertyChanging("City");
                this.SetAttributeValue("city", value);
                this.OnPropertyChanged("City");
            }
        }

        /// <summary>
        /// Shows the complete address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("composite")]
        public string Composite
        {
            get { return this.GetAttributeValue<string>("composite"); }
        }

        /// <summary>
        /// Country/region name in the address for the lead.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("country")]
        public string Country
        {
            get { return this.GetAttributeValue<string>("country"); }
            set
            {
                this.OnPropertyChanging("Country");
                this.SetAttributeValue("country", value);
                this.OnPropertyChanged("Country");
            }
        }

        /// <summary>
        /// County name in the address for the lead.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("county")]
        public string County
        {
            get { return this.GetAttributeValue<string>("county"); }
            set
            {
                this.OnPropertyChanging("County");
                this.SetAttributeValue("county", value);
                this.OnPropertyChanged("County");
            }
        }

        /// <summary>
        /// Unique identifier of the user who created the lead address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby"); }
        }

        /// <summary>
        /// Date and time when the lead address was created.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
        public System.Nullable<System.DateTime> CreatedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who created the leadaddress.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        /// Exchange rate for the currency associated with the leadaddress with respect to the base currency.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("exchangerate")]
        public System.Nullable<decimal> ExchangeRate
        {
            get { return this.GetAttributeValue<System.Nullable<decimal>>("exchangerate"); }
        }

        /// <summary>
        /// Fax number for the address for the lead.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("fax")]
        public string Fax
        {
            get { return this.GetAttributeValue<string>("fax"); }
            set
            {
                this.OnPropertyChanging("Fax");
                this.SetAttributeValue("fax", value);
                this.OnPropertyChanged("Fax");
            }
        }

        /// <summary>
        /// Latitude for the address for the lead.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("latitude")]
        public System.Nullable<double> Latitude
        {
            get { return this.GetAttributeValue<System.Nullable<double>>("latitude"); }
            set
            {
                this.OnPropertyChanging("Latitude");
                this.SetAttributeValue("latitude", value);
                this.OnPropertyChanged("Latitude");
            }
        }

        /// <summary>
        /// Unique identifier of the lead address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("leadaddressid")]
        public System.Nullable<System.Guid> LeadAddressId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("leadaddressid"); }
            set
            {
                this.OnPropertyChanging("LeadAddressId");
                this.SetAttributeValue("leadaddressid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("LeadAddressId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("leadaddressid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.LeadAddressId = value; }
        }

        /// <summary>
        /// First line for entering address information.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("line1")]
        public string Line1
        {
            get { return this.GetAttributeValue<string>("line1"); }
            set
            {
                this.OnPropertyChanging("Line1");
                this.SetAttributeValue("line1", value);
                this.OnPropertyChanged("Line1");
            }
        }

        /// <summary>
        /// Second line for entering address information.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("line2")]
        public string Line2
        {
            get { return this.GetAttributeValue<string>("line2"); }
            set
            {
                this.OnPropertyChanging("Line2");
                this.SetAttributeValue("line2", value);
                this.OnPropertyChanged("Line2");
            }
        }

        /// <summary>
        /// Third line for entering address information.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("line3")]
        public string Line3
        {
            get { return this.GetAttributeValue<string>("line3"); }
            set
            {
                this.OnPropertyChanging("Line3");
                this.SetAttributeValue("line3", value);
                this.OnPropertyChanged("Line3");
            }
        }

        /// <summary>
        /// Longitude for the address for the lead.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("longitude")]
        public System.Nullable<double> Longitude
        {
            get { return this.GetAttributeValue<System.Nullable<double>>("longitude"); }
            set
            {
                this.OnPropertyChanging("Longitude");
                this.SetAttributeValue("longitude", value);
                this.OnPropertyChanged("Longitude");
            }
        }

        /// <summary>
        /// Unique identifier of the user who last modified the lead address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby"); }
        }

        /// <summary>
        /// Date and time when the lead address was last modified.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
        public System.Nullable<System.DateTime> ModifiedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who last modified the leadaddress.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        /// Name used to identify the lead address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("name")]
        public string Name
        {
            get { return this.GetAttributeValue<string>("name"); }
            set
            {
                this.OnPropertyChanging("Name");
                this.SetAttributeValue("name", value);
                this.OnPropertyChanged("Name");
            }
        }

        /// <summary>
        /// Unique identifier of the parent object with which the lead address is associated.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("parentid")]
        public Microsoft.Xrm.Sdk.EntityReference ParentId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("parentid"); }
            set
            {
                this.OnPropertyChanging("ParentId");
                this.SetAttributeValue("parentid", value);
                this.OnPropertyChanged("ParentId");
            }
        }

        /// <summary>
        /// ZIP Code or postal code in the address for the lead.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("postalcode")]
        public string PostalCode
        {
            get { return this.GetAttributeValue<string>("postalcode"); }
            set
            {
                this.OnPropertyChanging("PostalCode");
                this.SetAttributeValue("postalcode", value);
                this.OnPropertyChanged("PostalCode");
            }
        }

        /// <summary>
        /// Post office box number in the address for the lead.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("postofficebox")]
        public string PostOfficeBox
        {
            get { return this.GetAttributeValue<string>("postofficebox"); }
            set
            {
                this.OnPropertyChanging("PostOfficeBox");
                this.SetAttributeValue("postofficebox", value);
                this.OnPropertyChanged("PostOfficeBox");
            }
        }

        /// <summary>
        /// Method of shipment for the lead.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("shippingmethodcode")]
        public Microsoft.Xrm.Sdk.OptionSetValue ShippingMethodCode
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("shippingmethodcode"); }
            set
            {
                this.OnPropertyChanging("ShippingMethodCode");
                this.SetAttributeValue("shippingmethodcode", value);
                this.OnPropertyChanged("ShippingMethodCode");
            }
        }

        /// <summary>
        /// State or province in the address for the lead.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("stateorprovince")]
        public string StateOrProvince
        {
            get { return this.GetAttributeValue<string>("stateorprovince"); }
            set
            {
                this.OnPropertyChanging("StateOrProvince");
                this.SetAttributeValue("stateorprovince", value);
                this.OnPropertyChanged("StateOrProvince");
            }
        }

        /// <summary>
        /// First telephone number for the lead address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("telephone1")]
        public string Telephone1
        {
            get { return this.GetAttributeValue<string>("telephone1"); }
            set
            {
                this.OnPropertyChanging("Telephone1");
                this.SetAttributeValue("telephone1", value);
                this.OnPropertyChanged("Telephone1");
            }
        }

        /// <summary>
        /// Second telephone number for the lead address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("telephone2")]
        public string Telephone2
        {
            get { return this.GetAttributeValue<string>("telephone2"); }
            set
            {
                this.OnPropertyChanging("Telephone2");
                this.SetAttributeValue("telephone2", value);
                this.OnPropertyChanged("Telephone2");
            }
        }

        /// <summary>
        /// Third telephone number for the lead address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("telephone3")]
        public string Telephone3
        {
            get { return this.GetAttributeValue<string>("telephone3"); }
            set
            {
                this.OnPropertyChanging("Telephone3");
                this.SetAttributeValue("telephone3", value);
                this.OnPropertyChanged("Telephone3");
            }
        }

        /// <summary>
        /// Unique identifier of the currency associated with the leadaddress.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyid")]
        public Microsoft.Xrm.Sdk.EntityReference TransactionCurrencyId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("transactioncurrencyid"); }
            set
            {
                this.OnPropertyChanging("TransactionCurrencyId");
                this.SetAttributeValue("transactioncurrencyid", value);
                this.OnPropertyChanged("TransactionCurrencyId");
            }
        }

        /// <summary>
        /// United Parcel Service (UPS) zone for the address of the lead.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("upszone")]
        public string UPSZone
        {
            get { return this.GetAttributeValue<string>("upszone"); }
            set
            {
                this.OnPropertyChanging("UPSZone");
                this.SetAttributeValue("upszone", value);
                this.OnPropertyChanged("UPSZone");
            }
        }

        /// <summary>
        /// UTC offset for the lead address. This is the difference between local time and standard Coordinated Universal Time.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("utcoffset")]
        public System.Nullable<int> UTCOffset
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("utcoffset"); }
            set
            {
                this.OnPropertyChanging("UTCOffset");
                this.SetAttributeValue("utcoffset", value);
                this.OnPropertyChanged("UTCOffset");
            }
        }

        /// <summary>
        /// Version number of the lead address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
        public System.Nullable<long> VersionNumber
        {
            get { return this.GetAttributeValue<System.Nullable<long>>("versionnumber"); }
        }

        /// <summary>
        /// 1:N userentityinstancedata_leadaddress
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_leadaddress")]
        public System.Collections.Generic.IEnumerable<UserEntityInstanceData> userentityinstancedata_leadaddress
        {
            get { return this.GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_leadaddress", null); }
            set
            {
                this.OnPropertyChanging("userentityinstancedata_leadaddress");
                this.SetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_leadaddress", null, value);
                this.OnPropertyChanged("userentityinstancedata_leadaddress");
            }
        }

        /// <summary>
        /// N:1 lead_addresses
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("parentid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lead_addresses")]
        public Lead lead_addresses
        {
            get { return this.GetRelatedEntity<Lead>("lead_addresses", null); }
            set
            {
                this.OnPropertyChanging("lead_addresses");
                this.SetRelatedEntity<Lead>("lead_addresses", null, value);
                this.OnPropertyChanged("lead_addresses");
            }
        }

        /// <summary>
        /// N:1 lk_leadaddress_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_leadaddress_createdonbehalfby")]
        public SystemUser lk_leadaddress_createdonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_leadaddress_createdonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_leadaddress_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_leadaddress_modifiedonbehalfby")]
        public SystemUser lk_leadaddress_modifiedonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_leadaddress_modifiedonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_leadaddressbase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_leadaddressbase_createdby")]
        public SystemUser lk_leadaddressbase_createdby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_leadaddressbase_createdby", null); }
        }

        /// <summary>
        /// N:1 lk_leadaddressbase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_leadaddressbase_modifiedby")]
        public SystemUser lk_leadaddressbase_modifiedby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_leadaddressbase_modifiedby", null); }
        }

        /// <summary>
        /// N:1 TransactionCurrency_LeadAddress
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("TransactionCurrency_LeadAddress")]
        public TransactionCurrency TransactionCurrency_LeadAddress
        {
            get { return this.GetRelatedEntity<TransactionCurrency>("TransactionCurrency_LeadAddress", null); }
            set
            {
                this.OnPropertyChanging("TransactionCurrency_LeadAddress");
                this.SetRelatedEntity<TransactionCurrency>("TransactionCurrency_LeadAddress", null, value);
                this.OnPropertyChanged("TransactionCurrency_LeadAddress");
            }
        }
    }
}