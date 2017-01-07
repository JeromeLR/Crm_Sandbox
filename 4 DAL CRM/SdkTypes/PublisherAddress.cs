namespace __4_DAL_CRM
{
    /// <summary>
    /// Address and shipping information. Used to store additional addresses for a publisher.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("publisheraddress")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class PublisherAddress : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public PublisherAddress() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "publisheraddress";

        public const int EntityTypeCode = 7102;

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
        /// Specifies which publisher address is applicable.
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
        /// Type of address for the publisher, such as billing, shipping, or primary address.
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
        /// City name in the publisher address.
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
        /// Country/region name in the publisher address.
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
        /// County name in the publisher address.
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
        /// Unique identifier of the user who created the publisher address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby"); }
        }

        /// <summary>
        /// Date and time when the publisher address was created.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
        public System.Nullable<System.DateTime> CreatedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who created the publisher address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        /// Fax number for the publisher address.
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
        /// Freight terms for the publisher address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("freighttermscode")]
        public Microsoft.Xrm.Sdk.OptionSetValue FreightTermsCode
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("freighttermscode"); }
            set
            {
                this.OnPropertyChanging("FreightTermsCode");
                this.SetAttributeValue("freighttermscode", value);
                this.OnPropertyChanged("FreightTermsCode");
            }
        }

        /// <summary>
        /// Unique identifier of the data import or data migration that created this record.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("importsequencenumber")]
        public System.Nullable<int> ImportSequenceNumber
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("importsequencenumber"); }
            set
            {
                this.OnPropertyChanging("ImportSequenceNumber");
                this.SetAttributeValue("importsequencenumber", value);
                this.OnPropertyChanged("ImportSequenceNumber");
            }
        }

        /// <summary>
        /// Latitude for the publisher address.
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
        /// Longitude for the publisher address.
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
        /// Unique identifier of the user who last modified the publisher address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby"); }
        }

        /// <summary>
        /// Date and time when the publisher address was last modified.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
        public System.Nullable<System.DateTime> ModifiedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who modified the publisher address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        /// Name used to identify the publisher address.
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
        /// Unique identifier of the parent object with which the publisher address is associated.
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
        /// ZIP Code or postal code in the publisher address.
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
        /// Post office box number in the publisher address.
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
        /// Name of the primary contact at the publisher address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("primarycontactname")]
        public string PrimaryContactName
        {
            get { return this.GetAttributeValue<string>("primarycontactname"); }
            set
            {
                this.OnPropertyChanging("PrimaryContactName");
                this.SetAttributeValue("primarycontactname", value);
                this.OnPropertyChanged("PrimaryContactName");
            }
        }

        /// <summary>
        /// Unique identifier of the publisher address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("publisheraddressid")]
        public System.Nullable<System.Guid> PublisherAddressId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("publisheraddressid"); }
            set
            {
                this.OnPropertyChanging("PublisherAddressId");
                this.SetAttributeValue("publisheraddressid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("PublisherAddressId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("publisheraddressid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.PublisherAddressId = value; }
        }

        /// <summary>
        /// Method of shipment for the publisher address.
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
        /// State or province in the publisher address.
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
        /// First telephone number for the publisher address.
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
        /// Second telephone number for the publisher address.
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
        /// Third telephone number for the publisher address.
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
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("timezoneruleversionnumber")]
        public System.Nullable<int> TimeZoneRuleVersionNumber
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("timezoneruleversionnumber"); }
            set
            {
                this.OnPropertyChanging("TimeZoneRuleVersionNumber");
                this.SetAttributeValue("timezoneruleversionnumber", value);
                this.OnPropertyChanged("TimeZoneRuleVersionNumber");
            }
        }

        /// <summary>
        /// United Parcel Service (UPS) zone for the address of the publisher.
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
        /// Time zone code that was in use when the record was created.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("utcconversiontimezonecode")]
        public System.Nullable<int> UTCConversionTimeZoneCode
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("utcconversiontimezonecode"); }
            set
            {
                this.OnPropertyChanging("UTCConversionTimeZoneCode");
                this.SetAttributeValue("utcconversiontimezonecode", value);
                this.OnPropertyChanged("UTCConversionTimeZoneCode");
            }
        }

        /// <summary>
        /// UTC offset for the address. This is the difference between local time and standard Coordinated Universal Time.
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
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
        public System.Nullable<long> VersionNumber
        {
            get { return this.GetAttributeValue<System.Nullable<long>>("versionnumber"); }
        }

        /// <summary>
        /// 1:N userentityinstancedata_publisheraddress
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_publisheraddress")]
        public System.Collections.Generic.IEnumerable<UserEntityInstanceData> userentityinstancedata_publisheraddress
        {
            get { return this.GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_publisheraddress", null); }
            set
            {
                this.OnPropertyChanging("userentityinstancedata_publisheraddress");
                this.SetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_publisheraddress", null, value);
                this.OnPropertyChanged("userentityinstancedata_publisheraddress");
            }
        }

        /// <summary>
        /// N:1 lk_publisheraddressbase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_publisheraddressbase_createdby")]
        public SystemUser lk_publisheraddressbase_createdby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_publisheraddressbase_createdby", null); }
        }

        /// <summary>
        /// N:1 lk_publisheraddressbase_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_publisheraddressbase_createdonbehalfby")]
        public SystemUser lk_publisheraddressbase_createdonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_publisheraddressbase_createdonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_publisheraddressbase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_publisheraddressbase_modifiedby")]
        public SystemUser lk_publisheraddressbase_modifiedby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_publisheraddressbase_modifiedby", null); }
        }

        /// <summary>
        /// N:1 lk_publisheraddressbase_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_publisheraddressbase_modifiedonbehalfby")]
        public SystemUser lk_publisheraddressbase_modifiedonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_publisheraddressbase_modifiedonbehalfby", null); }
        }

        /// <summary>
        /// N:1 Publisher_PublisherAddress
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("parentid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Publisher_PublisherAddress")]
        public Publisher Publisher_PublisherAddress
        {
            get { return this.GetRelatedEntity<Publisher>("Publisher_PublisherAddress", null); }
            set
            {
                this.OnPropertyChanging("Publisher_PublisherAddress");
                this.SetRelatedEntity<Publisher>("Publisher_PublisherAddress", null, value);
                this.OnPropertyChanged("Publisher_PublisherAddress");
            }
        }
    }
}