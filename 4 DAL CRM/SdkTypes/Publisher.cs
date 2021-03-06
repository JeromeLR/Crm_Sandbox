namespace __4_DAL_CRM
{
    /// <summary>
    /// A publisher of a CRM solution.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("publisher")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class Publisher : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public Publisher() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "publisher";

        public const int EntityTypeCode = 7101;

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
        /// Unique identifier for address 1.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_addressid")]
        public System.Nullable<System.Guid> Address1_AddressId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("address1_addressid"); }
            set
            {
                this.OnPropertyChanging("Address1_AddressId");
                this.SetAttributeValue("address1_addressid", value);
                this.OnPropertyChanged("Address1_AddressId");
            }
        }

        /// <summary>
        /// Type of address for address 1, such as billing, shipping, or primary address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_addresstypecode")]
        public Microsoft.Xrm.Sdk.OptionSetValue Address1_AddressTypeCode
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("address1_addresstypecode"); }
            set
            {
                this.OnPropertyChanging("Address1_AddressTypeCode");
                this.SetAttributeValue("address1_addresstypecode", value);
                this.OnPropertyChanged("Address1_AddressTypeCode");
            }
        }

        /// <summary>
        /// City name for address 1.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_city")]
        public string Address1_City
        {
            get { return this.GetAttributeValue<string>("address1_city"); }
            set
            {
                this.OnPropertyChanging("Address1_City");
                this.SetAttributeValue("address1_city", value);
                this.OnPropertyChanged("Address1_City");
            }
        }

        /// <summary>
        /// Country/region name for address 1.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_country")]
        public string Address1_Country
        {
            get { return this.GetAttributeValue<string>("address1_country"); }
            set
            {
                this.OnPropertyChanging("Address1_Country");
                this.SetAttributeValue("address1_country", value);
                this.OnPropertyChanged("Address1_Country");
            }
        }

        /// <summary>
        /// County name for address 1.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_county")]
        public string Address1_County
        {
            get { return this.GetAttributeValue<string>("address1_county"); }
            set
            {
                this.OnPropertyChanging("Address1_County");
                this.SetAttributeValue("address1_county", value);
                this.OnPropertyChanged("Address1_County");
            }
        }

        /// <summary>
        /// Fax number for address 1.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_fax")]
        public string Address1_Fax
        {
            get { return this.GetAttributeValue<string>("address1_fax"); }
            set
            {
                this.OnPropertyChanging("Address1_Fax");
                this.SetAttributeValue("address1_fax", value);
                this.OnPropertyChanged("Address1_Fax");
            }
        }

        /// <summary>
        /// Latitude for address 1.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_latitude")]
        public System.Nullable<double> Address1_Latitude
        {
            get { return this.GetAttributeValue<System.Nullable<double>>("address1_latitude"); }
            set
            {
                this.OnPropertyChanging("Address1_Latitude");
                this.SetAttributeValue("address1_latitude", value);
                this.OnPropertyChanged("Address1_Latitude");
            }
        }

        /// <summary>
        /// First line for entering address 1 information.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_line1")]
        public string Address1_Line1
        {
            get { return this.GetAttributeValue<string>("address1_line1"); }
            set
            {
                this.OnPropertyChanging("Address1_Line1");
                this.SetAttributeValue("address1_line1", value);
                this.OnPropertyChanged("Address1_Line1");
            }
        }

        /// <summary>
        /// Second line for entering address 1 information.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_line2")]
        public string Address1_Line2
        {
            get { return this.GetAttributeValue<string>("address1_line2"); }
            set
            {
                this.OnPropertyChanging("Address1_Line2");
                this.SetAttributeValue("address1_line2", value);
                this.OnPropertyChanged("Address1_Line2");
            }
        }

        /// <summary>
        /// Third line for entering address 1 information.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_line3")]
        public string Address1_Line3
        {
            get { return this.GetAttributeValue<string>("address1_line3"); }
            set
            {
                this.OnPropertyChanging("Address1_Line3");
                this.SetAttributeValue("address1_line3", value);
                this.OnPropertyChanged("Address1_Line3");
            }
        }

        /// <summary>
        /// Longitude for address 1.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_longitude")]
        public System.Nullable<double> Address1_Longitude
        {
            get { return this.GetAttributeValue<System.Nullable<double>>("address1_longitude"); }
            set
            {
                this.OnPropertyChanging("Address1_Longitude");
                this.SetAttributeValue("address1_longitude", value);
                this.OnPropertyChanged("Address1_Longitude");
            }
        }

        /// <summary>
        /// Name to enter for address 1.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_name")]
        public string Address1_Name
        {
            get { return this.GetAttributeValue<string>("address1_name"); }
            set
            {
                this.OnPropertyChanging("Address1_Name");
                this.SetAttributeValue("address1_name", value);
                this.OnPropertyChanged("Address1_Name");
            }
        }

        /// <summary>
        /// ZIP Code or postal code for address 1.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_postalcode")]
        public string Address1_PostalCode
        {
            get { return this.GetAttributeValue<string>("address1_postalcode"); }
            set
            {
                this.OnPropertyChanging("Address1_PostalCode");
                this.SetAttributeValue("address1_postalcode", value);
                this.OnPropertyChanged("Address1_PostalCode");
            }
        }

        /// <summary>
        /// Post office box number for address 1.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_postofficebox")]
        public string Address1_PostOfficeBox
        {
            get { return this.GetAttributeValue<string>("address1_postofficebox"); }
            set
            {
                this.OnPropertyChanging("Address1_PostOfficeBox");
                this.SetAttributeValue("address1_postofficebox", value);
                this.OnPropertyChanged("Address1_PostOfficeBox");
            }
        }

        /// <summary>
        /// Method of shipment for address 1.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_shippingmethodcode")]
        public Microsoft.Xrm.Sdk.OptionSetValue Address1_ShippingMethodCode
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("address1_shippingmethodcode"); }
            set
            {
                this.OnPropertyChanging("Address1_ShippingMethodCode");
                this.SetAttributeValue("address1_shippingmethodcode", value);
                this.OnPropertyChanged("Address1_ShippingMethodCode");
            }
        }

        /// <summary>
        /// State or province for address 1.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_stateorprovince")]
        public string Address1_StateOrProvince
        {
            get { return this.GetAttributeValue<string>("address1_stateorprovince"); }
            set
            {
                this.OnPropertyChanging("Address1_StateOrProvince");
                this.SetAttributeValue("address1_stateorprovince", value);
                this.OnPropertyChanged("Address1_StateOrProvince");
            }
        }

        /// <summary>
        /// First telephone number associated with address 1.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_telephone1")]
        public string Address1_Telephone1
        {
            get { return this.GetAttributeValue<string>("address1_telephone1"); }
            set
            {
                this.OnPropertyChanging("Address1_Telephone1");
                this.SetAttributeValue("address1_telephone1", value);
                this.OnPropertyChanged("Address1_Telephone1");
            }
        }

        /// <summary>
        /// Second telephone number associated with address 1.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_telephone2")]
        public string Address1_Telephone2
        {
            get { return this.GetAttributeValue<string>("address1_telephone2"); }
            set
            {
                this.OnPropertyChanging("Address1_Telephone2");
                this.SetAttributeValue("address1_telephone2", value);
                this.OnPropertyChanged("Address1_Telephone2");
            }
        }

        /// <summary>
        /// Third telephone number associated with address 1.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_telephone3")]
        public string Address1_Telephone3
        {
            get { return this.GetAttributeValue<string>("address1_telephone3"); }
            set
            {
                this.OnPropertyChanging("Address1_Telephone3");
                this.SetAttributeValue("address1_telephone3", value);
                this.OnPropertyChanged("Address1_Telephone3");
            }
        }

        /// <summary>
        /// United Parcel Service (UPS) zone for address 1.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_upszone")]
        public string Address1_UPSZone
        {
            get { return this.GetAttributeValue<string>("address1_upszone"); }
            set
            {
                this.OnPropertyChanging("Address1_UPSZone");
                this.SetAttributeValue("address1_upszone", value);
                this.OnPropertyChanged("Address1_UPSZone");
            }
        }

        /// <summary>
        /// UTC offset for address 1. This is the difference between local time and standard Coordinated Universal Time.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_utcoffset")]
        public System.Nullable<int> Address1_UTCOffset
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("address1_utcoffset"); }
            set
            {
                this.OnPropertyChanging("Address1_UTCOffset");
                this.SetAttributeValue("address1_utcoffset", value);
                this.OnPropertyChanged("Address1_UTCOffset");
            }
        }

        /// <summary>
        /// Unique identifier for address 2.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_addressid")]
        public System.Nullable<System.Guid> Address2_AddressId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("address2_addressid"); }
            set
            {
                this.OnPropertyChanging("Address2_AddressId");
                this.SetAttributeValue("address2_addressid", value);
                this.OnPropertyChanged("Address2_AddressId");
            }
        }

        /// <summary>
        /// Type of address for address 2. such as billing, shipping, or primary address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_addresstypecode")]
        public Microsoft.Xrm.Sdk.OptionSetValue Address2_AddressTypeCode
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("address2_addresstypecode"); }
            set
            {
                this.OnPropertyChanging("Address2_AddressTypeCode");
                this.SetAttributeValue("address2_addresstypecode", value);
                this.OnPropertyChanged("Address2_AddressTypeCode");
            }
        }

        /// <summary>
        /// City name for address 2.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_city")]
        public string Address2_City
        {
            get { return this.GetAttributeValue<string>("address2_city"); }
            set
            {
                this.OnPropertyChanging("Address2_City");
                this.SetAttributeValue("address2_city", value);
                this.OnPropertyChanged("Address2_City");
            }
        }

        /// <summary>
        /// Country/region name for address 2.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_country")]
        public string Address2_Country
        {
            get { return this.GetAttributeValue<string>("address2_country"); }
            set
            {
                this.OnPropertyChanging("Address2_Country");
                this.SetAttributeValue("address2_country", value);
                this.OnPropertyChanged("Address2_Country");
            }
        }

        /// <summary>
        /// County name for address 2.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_county")]
        public string Address2_County
        {
            get { return this.GetAttributeValue<string>("address2_county"); }
            set
            {
                this.OnPropertyChanging("Address2_County");
                this.SetAttributeValue("address2_county", value);
                this.OnPropertyChanged("Address2_County");
            }
        }

        /// <summary>
        /// Fax number for address 2.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_fax")]
        public string Address2_Fax
        {
            get { return this.GetAttributeValue<string>("address2_fax"); }
            set
            {
                this.OnPropertyChanging("Address2_Fax");
                this.SetAttributeValue("address2_fax", value);
                this.OnPropertyChanged("Address2_Fax");
            }
        }

        /// <summary>
        /// Latitude for address 2.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_latitude")]
        public System.Nullable<double> Address2_Latitude
        {
            get { return this.GetAttributeValue<System.Nullable<double>>("address2_latitude"); }
            set
            {
                this.OnPropertyChanging("Address2_Latitude");
                this.SetAttributeValue("address2_latitude", value);
                this.OnPropertyChanged("Address2_Latitude");
            }
        }

        /// <summary>
        /// First line for entering address 2 information.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_line1")]
        public string Address2_Line1
        {
            get { return this.GetAttributeValue<string>("address2_line1"); }
            set
            {
                this.OnPropertyChanging("Address2_Line1");
                this.SetAttributeValue("address2_line1", value);
                this.OnPropertyChanged("Address2_Line1");
            }
        }

        /// <summary>
        /// Second line for entering address 2 information.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_line2")]
        public string Address2_Line2
        {
            get { return this.GetAttributeValue<string>("address2_line2"); }
            set
            {
                this.OnPropertyChanging("Address2_Line2");
                this.SetAttributeValue("address2_line2", value);
                this.OnPropertyChanged("Address2_Line2");
            }
        }

        /// <summary>
        /// Third line for entering address 2 information.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_line3")]
        public string Address2_Line3
        {
            get { return this.GetAttributeValue<string>("address2_line3"); }
            set
            {
                this.OnPropertyChanging("Address2_Line3");
                this.SetAttributeValue("address2_line3", value);
                this.OnPropertyChanged("Address2_Line3");
            }
        }

        /// <summary>
        /// Longitude for address 2.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_longitude")]
        public System.Nullable<double> Address2_Longitude
        {
            get { return this.GetAttributeValue<System.Nullable<double>>("address2_longitude"); }
            set
            {
                this.OnPropertyChanging("Address2_Longitude");
                this.SetAttributeValue("address2_longitude", value);
                this.OnPropertyChanged("Address2_Longitude");
            }
        }

        /// <summary>
        /// Name to enter for address 2.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_name")]
        public string Address2_Name
        {
            get { return this.GetAttributeValue<string>("address2_name"); }
            set
            {
                this.OnPropertyChanging("Address2_Name");
                this.SetAttributeValue("address2_name", value);
                this.OnPropertyChanged("Address2_Name");
            }
        }

        /// <summary>
        /// ZIP Code or postal code for address 2.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_postalcode")]
        public string Address2_PostalCode
        {
            get { return this.GetAttributeValue<string>("address2_postalcode"); }
            set
            {
                this.OnPropertyChanging("Address2_PostalCode");
                this.SetAttributeValue("address2_postalcode", value);
                this.OnPropertyChanged("Address2_PostalCode");
            }
        }

        /// <summary>
        /// Post office box number for address 2.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_postofficebox")]
        public string Address2_PostOfficeBox
        {
            get { return this.GetAttributeValue<string>("address2_postofficebox"); }
            set
            {
                this.OnPropertyChanging("Address2_PostOfficeBox");
                this.SetAttributeValue("address2_postofficebox", value);
                this.OnPropertyChanged("Address2_PostOfficeBox");
            }
        }

        /// <summary>
        /// Method of shipment for address 2.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_shippingmethodcode")]
        public Microsoft.Xrm.Sdk.OptionSetValue Address2_ShippingMethodCode
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("address2_shippingmethodcode"); }
            set
            {
                this.OnPropertyChanging("Address2_ShippingMethodCode");
                this.SetAttributeValue("address2_shippingmethodcode", value);
                this.OnPropertyChanged("Address2_ShippingMethodCode");
            }
        }

        /// <summary>
        /// State or province for address 2.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_stateorprovince")]
        public string Address2_StateOrProvince
        {
            get { return this.GetAttributeValue<string>("address2_stateorprovince"); }
            set
            {
                this.OnPropertyChanging("Address2_StateOrProvince");
                this.SetAttributeValue("address2_stateorprovince", value);
                this.OnPropertyChanged("Address2_StateOrProvince");
            }
        }

        /// <summary>
        /// First telephone number associated with address 2.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_telephone1")]
        public string Address2_Telephone1
        {
            get { return this.GetAttributeValue<string>("address2_telephone1"); }
            set
            {
                this.OnPropertyChanging("Address2_Telephone1");
                this.SetAttributeValue("address2_telephone1", value);
                this.OnPropertyChanged("Address2_Telephone1");
            }
        }

        /// <summary>
        /// Second telephone number associated with address 2.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_telephone2")]
        public string Address2_Telephone2
        {
            get { return this.GetAttributeValue<string>("address2_telephone2"); }
            set
            {
                this.OnPropertyChanging("Address2_Telephone2");
                this.SetAttributeValue("address2_telephone2", value);
                this.OnPropertyChanged("Address2_Telephone2");
            }
        }

        /// <summary>
        /// Third telephone number associated with address 2.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_telephone3")]
        public string Address2_Telephone3
        {
            get { return this.GetAttributeValue<string>("address2_telephone3"); }
            set
            {
                this.OnPropertyChanging("Address2_Telephone3");
                this.SetAttributeValue("address2_telephone3", value);
                this.OnPropertyChanged("Address2_Telephone3");
            }
        }

        /// <summary>
        /// United Parcel Service (UPS) zone for address 2.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_upszone")]
        public string Address2_UPSZone
        {
            get { return this.GetAttributeValue<string>("address2_upszone"); }
            set
            {
                this.OnPropertyChanging("Address2_UPSZone");
                this.SetAttributeValue("address2_upszone", value);
                this.OnPropertyChanged("Address2_UPSZone");
            }
        }

        /// <summary>
        /// UTC offset for address 2. This is the difference between local time and standard Coordinated Universal Time.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_utcoffset")]
        public System.Nullable<int> Address2_UTCOffset
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("address2_utcoffset"); }
            set
            {
                this.OnPropertyChanging("Address2_UTCOffset");
                this.SetAttributeValue("address2_utcoffset", value);
                this.OnPropertyChanged("Address2_UTCOffset");
            }
        }

        /// <summary>
        /// Unique identifier of the user who created the publisher.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby"); }
        }

        /// <summary>
        /// Date and time when the publisher was created.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
        public System.Nullable<System.DateTime> CreatedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who created the publisher.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        /// Default option value prefix used for newly created options for solutions associated with this publisher.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("customizationoptionvalueprefix")]
        public System.Nullable<int> CustomizationOptionValuePrefix
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("customizationoptionvalueprefix"); }
            set
            {
                this.OnPropertyChanging("CustomizationOptionValuePrefix");
                this.SetAttributeValue("customizationoptionvalueprefix", value);
                this.OnPropertyChanged("CustomizationOptionValuePrefix");
            }
        }

        /// <summary>
        /// Prefix used for new entities, attributes, and entity relationships for solutions associated with this publisher.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("customizationprefix")]
        public string CustomizationPrefix
        {
            get { return this.GetAttributeValue<string>("customizationprefix"); }
            set
            {
                this.OnPropertyChanging("CustomizationPrefix");
                this.SetAttributeValue("customizationprefix", value);
                this.OnPropertyChanged("CustomizationPrefix");
            }
        }

        /// <summary>
        /// Description of the solution.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("description")]
        public string Description
        {
            get { return this.GetAttributeValue<string>("description"); }
            set
            {
                this.OnPropertyChanging("Description");
                this.SetAttributeValue("description", value);
                this.OnPropertyChanged("Description");
            }
        }

        /// <summary>
        /// Email address for the publisher.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("emailaddress")]
        public string EMailAddress
        {
            get { return this.GetAttributeValue<string>("emailaddress"); }
            set
            {
                this.OnPropertyChanging("EMailAddress");
                this.SetAttributeValue("emailaddress", value);
                this.OnPropertyChanged("EMailAddress");
            }
        }

        /// <summary>
        /// Shows the default image for the record.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entityimage")]
        public byte[] EntityImage
        {
            get { return this.GetAttributeValue<byte[]>("entityimage"); }
            set
            {
                this.OnPropertyChanging("EntityImage");
                this.SetAttributeValue("entityimage", value);
                this.OnPropertyChanged("EntityImage");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entityimage_timestamp")]
        public System.Nullable<long> EntityImage_Timestamp
        {
            get { return this.GetAttributeValue<System.Nullable<long>>("entityimage_timestamp"); }
        }

        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entityimage_url")]
        public string EntityImage_URL
        {
            get { return this.GetAttributeValue<string>("entityimage_url"); }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entityimageid")]
        public System.Nullable<System.Guid> EntityImageId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("entityimageid"); }
        }

        /// <summary>
        /// User display name for this publisher.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("friendlyname")]
        public string FriendlyName
        {
            get { return this.GetAttributeValue<string>("friendlyname"); }
            set
            {
                this.OnPropertyChanging("FriendlyName");
                this.SetAttributeValue("friendlyname", value);
                this.OnPropertyChanged("FriendlyName");
            }
        }

        /// <summary>
        /// Indicates whether the publisher was created as part of a managed solution installation.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isreadonly")]
        public System.Nullable<bool> IsReadonly
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("isreadonly"); }
        }

        /// <summary>
        /// Unique identifier of the user who last modified the publisher.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby"); }
        }

        /// <summary>
        /// Date and time when the publisher was last modified.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
        public System.Nullable<System.DateTime> ModifiedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who modified the publisher.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        /// Unique identifier of the organization associated with the publisher.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
        public Microsoft.Xrm.Sdk.EntityReference OrganizationId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("organizationid"); }
        }

        /// <summary>
        /// Default locale of the publisher in Microsoft Pinpoint.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("pinpointpublisherdefaultlocale")]
        public string PinpointPublisherDefaultLocale
        {
            get { return this.GetAttributeValue<string>("pinpointpublisherdefaultlocale"); }
        }

        /// <summary>
        /// Identifier of the publisher in Microsoft Pinpoint.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("pinpointpublisherid")]
        public System.Nullable<long> PinpointPublisherId
        {
            get { return this.GetAttributeValue<System.Nullable<long>>("pinpointpublisherid"); }
        }

        /// <summary>
        /// Unique identifier of the publisher.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("publisherid")]
        public System.Nullable<System.Guid> PublisherId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("publisherid"); }
            set
            {
                this.OnPropertyChanging("PublisherId");
                this.SetAttributeValue("publisherid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("PublisherId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("publisherid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.PublisherId = value; }
        }

        /// <summary>
        /// URL for the supporting website of this publisher.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("supportingwebsiteurl")]
        public string SupportingWebsiteUrl
        {
            get { return this.GetAttributeValue<string>("supportingwebsiteurl"); }
            set
            {
                this.OnPropertyChanging("SupportingWebsiteUrl");
                this.SetAttributeValue("supportingwebsiteurl", value);
                this.OnPropertyChanged("SupportingWebsiteUrl");
            }
        }

        /// <summary>
        /// The unique name of this publisher.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("uniquename")]
        public string UniqueName
        {
            get { return this.GetAttributeValue<string>("uniquename"); }
            set
            {
                this.OnPropertyChanging("UniqueName");
                this.SetAttributeValue("uniquename", value);
                this.OnPropertyChanged("UniqueName");
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
        /// 1:N Publisher_DuplicateBaseRecord
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Publisher_DuplicateBaseRecord")]
        public System.Collections.Generic.IEnumerable<DuplicateRecord> Publisher_DuplicateBaseRecord
        {
            get { return this.GetRelatedEntities<DuplicateRecord>("Publisher_DuplicateBaseRecord", null); }
            set
            {
                this.OnPropertyChanging("Publisher_DuplicateBaseRecord");
                this.SetRelatedEntities<DuplicateRecord>("Publisher_DuplicateBaseRecord", null, value);
                this.OnPropertyChanged("Publisher_DuplicateBaseRecord");
            }
        }

        /// <summary>
        /// 1:N Publisher_DuplicateMatchingRecord
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Publisher_DuplicateMatchingRecord")]
        public System.Collections.Generic.IEnumerable<DuplicateRecord> Publisher_DuplicateMatchingRecord
        {
            get { return this.GetRelatedEntities<DuplicateRecord>("Publisher_DuplicateMatchingRecord", null); }
            set
            {
                this.OnPropertyChanging("Publisher_DuplicateMatchingRecord");
                this.SetRelatedEntities<DuplicateRecord>("Publisher_DuplicateMatchingRecord", null, value);
                this.OnPropertyChanged("Publisher_DuplicateMatchingRecord");
            }
        }

        /// <summary>
        /// 1:N Publisher_PublisherAddress
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Publisher_PublisherAddress")]
        public System.Collections.Generic.IEnumerable<PublisherAddress> Publisher_PublisherAddress
        {
            get { return this.GetRelatedEntities<PublisherAddress>("Publisher_PublisherAddress", null); }
            set
            {
                this.OnPropertyChanging("Publisher_PublisherAddress");
                this.SetRelatedEntities<PublisherAddress>("Publisher_PublisherAddress", null, value);
                this.OnPropertyChanged("Publisher_PublisherAddress");
            }
        }

        /// <summary>
        /// 1:N publisher_solution
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("publisher_solution")]
        public System.Collections.Generic.IEnumerable<Solution> publisher_solution
        {
            get { return this.GetRelatedEntities<Solution>("publisher_solution", null); }
            set
            {
                this.OnPropertyChanging("publisher_solution");
                this.SetRelatedEntities<Solution>("publisher_solution", null, value);
                this.OnPropertyChanged("publisher_solution");
            }
        }

        /// <summary>
        /// 1:N userentityinstancedata_publisher
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_publisher")]
        public System.Collections.Generic.IEnumerable<UserEntityInstanceData> userentityinstancedata_publisher
        {
            get { return this.GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_publisher", null); }
            set
            {
                this.OnPropertyChanging("userentityinstancedata_publisher");
                this.SetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_publisher", null, value);
                this.OnPropertyChanged("userentityinstancedata_publisher");
            }
        }

        /// <summary>
        /// N:1 lk_publisher_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_publisher_createdby")]
        public SystemUser lk_publisher_createdby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_publisher_createdby", null); }
        }

        /// <summary>
        /// N:1 lk_publisher_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_publisher_modifiedby")]
        public SystemUser lk_publisher_modifiedby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_publisher_modifiedby", null); }
        }

        /// <summary>
        /// N:1 lk_publisherbase_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_publisherbase_createdonbehalfby")]
        public SystemUser lk_publisherbase_createdonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_publisherbase_createdonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_publisherbase_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_publisherbase_modifiedonbehalfby")]
        public SystemUser lk_publisherbase_modifiedonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_publisherbase_modifiedonbehalfby", null); }
        }

        /// <summary>
        /// N:1 organization_publisher
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_publisher")]
        public Organization organization_publisher
        {
            get { return this.GetRelatedEntity<Organization>("organization_publisher", null); }
        }
    }
}