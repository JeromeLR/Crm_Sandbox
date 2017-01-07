namespace __4_DAL_CRM
{
    /// <summary>
    /// Location or branch office where an organization does business. An organization can have multiple sites.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("site")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class Site : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public Site() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "site";

        public const int EntityTypeCode = 4009;

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
        /// Type of address for address 2, such as billing, shipping, or primary address.
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
        /// Unique identifier of the user who created the site.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby"); }
        }

        /// <summary>
        /// Date and time when the site was created.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
        public System.Nullable<System.DateTime> CreatedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who created the site.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        /// Email address for the site.
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
        /// Unique identifier of the user who last modified the site.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby"); }
        }

        /// <summary>
        /// Date and time when the site was last modified.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
        public System.Nullable<System.DateTime> ModifiedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who last modified the site.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        /// Name of the site.
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
        /// Unique identifier of the organization with which the site is associated.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
        public System.Nullable<System.Guid> OrganizationId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("organizationid"); }
        }

        /// <summary>
        /// Date and time that the record was migrated.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("overriddencreatedon")]
        public System.Nullable<System.DateTime> OverriddenCreatedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("overriddencreatedon"); }
            set
            {
                this.OnPropertyChanging("OverriddenCreatedOn");
                this.SetAttributeValue("overriddencreatedon", value);
                this.OnPropertyChanged("OverriddenCreatedOn");
            }
        }

        /// <summary>
        /// Unique identifier of the site.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("siteid")]
        public System.Nullable<System.Guid> SiteId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("siteid"); }
            set
            {
                this.OnPropertyChanging("SiteId");
                this.SetAttributeValue("siteid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("SiteId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("siteid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.SiteId = value; }
        }

        /// <summary>
        /// Local time zone for the site.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("timezonecode")]
        public System.Nullable<int> TimeZoneCode
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("timezonecode"); }
            set
            {
                this.OnPropertyChanging("TimeZoneCode");
                this.SetAttributeValue("timezonecode", value);
                this.OnPropertyChanged("TimeZoneCode");
            }
        }

        /// <summary>
        /// Version number of the site.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
        public System.Nullable<long> VersionNumber
        {
            get { return this.GetAttributeValue<System.Nullable<long>>("versionnumber"); }
        }

        /// <summary>
        /// 1:N Site_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Site_AsyncOperations")]
        public System.Collections.Generic.IEnumerable<AsyncOperation> Site_AsyncOperations
        {
            get { return this.GetRelatedEntities<AsyncOperation>("Site_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("Site_AsyncOperations");
                this.SetRelatedEntities<AsyncOperation>("Site_AsyncOperations", null, value);
                this.OnPropertyChanged("Site_AsyncOperations");
            }
        }

        /// <summary>
        /// 1:N Site_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Site_BulkDeleteFailures")]
        public System.Collections.Generic.IEnumerable<BulkDeleteFailure> Site_BulkDeleteFailures
        {
            get { return this.GetRelatedEntities<BulkDeleteFailure>("Site_BulkDeleteFailures", null); }
            set
            {
                this.OnPropertyChanging("Site_BulkDeleteFailures");
                this.SetRelatedEntities<BulkDeleteFailure>("Site_BulkDeleteFailures", null, value);
                this.OnPropertyChanged("Site_BulkDeleteFailures");
            }
        }

        /// <summary>
        /// 1:N site_equipment
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("site_equipment")]
        public System.Collections.Generic.IEnumerable<Equipment> site_equipment
        {
            get { return this.GetRelatedEntities<Equipment>("site_equipment", null); }
            set
            {
                this.OnPropertyChanging("site_equipment");
                this.SetRelatedEntities<Equipment>("site_equipment", null, value);
                this.OnPropertyChanged("site_equipment");
            }
        }

        /// <summary>
        /// 1:N Site_ProcessSessions
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Site_ProcessSessions")]
        public System.Collections.Generic.IEnumerable<ProcessSession> Site_ProcessSessions
        {
            get { return this.GetRelatedEntities<ProcessSession>("Site_ProcessSessions", null); }
            set
            {
                this.OnPropertyChanging("Site_ProcessSessions");
                this.SetRelatedEntities<ProcessSession>("Site_ProcessSessions", null, value);
                this.OnPropertyChanged("Site_ProcessSessions");
            }
        }

        /// <summary>
        /// 1:N site_resources
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("site_resources")]
        public System.Collections.Generic.IEnumerable<Resource> site_resources
        {
            get { return this.GetRelatedEntities<Resource>("site_resources", null); }
            set
            {
                this.OnPropertyChanging("site_resources");
                this.SetRelatedEntities<Resource>("site_resources", null, value);
                this.OnPropertyChanged("site_resources");
            }
        }

        /// <summary>
        /// 1:N site_service_appointments
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("site_service_appointments")]
        public System.Collections.Generic.IEnumerable<ServiceAppointment> site_service_appointments
        {
            get { return this.GetRelatedEntities<ServiceAppointment>("site_service_appointments", null); }
            set
            {
                this.OnPropertyChanging("site_service_appointments");
                this.SetRelatedEntities<ServiceAppointment>("site_service_appointments", null, value);
                this.OnPropertyChanged("site_service_appointments");
            }
        }

        /// <summary>
        /// 1:N site_system_users
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("site_system_users")]
        public System.Collections.Generic.IEnumerable<SystemUser> site_system_users
        {
            get { return this.GetRelatedEntities<SystemUser>("site_system_users", null); }
            set
            {
                this.OnPropertyChanging("site_system_users");
                this.SetRelatedEntities<SystemUser>("site_system_users", null, value);
                this.OnPropertyChanged("site_system_users");
            }
        }

        /// <summary>
        /// 1:N userentityinstancedata_site
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_site")]
        public System.Collections.Generic.IEnumerable<UserEntityInstanceData> userentityinstancedata_site
        {
            get { return this.GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_site", null); }
            set
            {
                this.OnPropertyChanging("userentityinstancedata_site");
                this.SetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_site", null, value);
                this.OnPropertyChanged("userentityinstancedata_site");
            }
        }

        /// <summary>
        /// N:1 lk_site_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_site_createdonbehalfby")]
        public SystemUser lk_site_createdonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_site_createdonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_site_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_site_modifiedonbehalfby")]
        public SystemUser lk_site_modifiedonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_site_modifiedonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_sitebase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_sitebase_createdby")]
        public SystemUser lk_sitebase_createdby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_sitebase_createdby", null); }
        }

        /// <summary>
        /// N:1 lk_sitebase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_sitebase_modifiedby")]
        public SystemUser lk_sitebase_modifiedby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_sitebase_modifiedby", null); }
        }

        /// <summary>
        /// N:1 organization_sites
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_sites")]
        public Organization organization_sites
        {
            get { return this.GetRelatedEntity<Organization>("organization_sites", null); }
        }
    }
}