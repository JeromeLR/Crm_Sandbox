using _4_DAL_CRM;

namespace __4_DAL_CRM
{
    /// <summary>
    /// Person with access to the Microsoft CRM system and who owns objects in the Microsoft CRM database.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("systemuser")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class SystemUser : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {
        /// <summary>
        /// Default Constructor.
        /// </summary>
        public SystemUser() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "systemuser";

        public const int EntityTypeCode = 8;

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
        /// Type of user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("accessmode")]
        public Microsoft.Xrm.Sdk.OptionSetValue AccessMode
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("accessmode"); }
            set
            {
                this.OnPropertyChanging("AccessMode");
                this.SetAttributeValue("accessmode", value);
                this.OnPropertyChanged("AccessMode");
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
        /// Shows the complete primary address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address1_composite")]
        public string Address1_Composite
        {
            get { return this.GetAttributeValue<string>("address1_composite"); }
        }

        /// <summary>
        /// Country/region name in address 1.
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
        /// Shows the complete secondary address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("address2_composite")]
        public string Address2_Composite
        {
            get { return this.GetAttributeValue<string>("address2_composite"); }
        }

        /// <summary>
        /// Country/region name in address 2.
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
        /// Unique identifier of the business unit with which the user is associated.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("businessunitid")]
        public Microsoft.Xrm.Sdk.EntityReference BusinessUnitId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("businessunitid"); }
            set
            {
                this.OnPropertyChanging("BusinessUnitId");
                this.SetAttributeValue("businessunitid", value);
                this.OnPropertyChanged("BusinessUnitId");
            }
        }

        /// <summary>
        /// Fiscal calendar associated with the user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("calendarid")]
        public Microsoft.Xrm.Sdk.EntityReference CalendarId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("calendarid"); }
            set
            {
                this.OnPropertyChanging("CalendarId");
                this.SetAttributeValue("calendarid", value);
                this.OnPropertyChanged("CalendarId");
            }
        }

        /// <summary>
        /// License type of user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("caltype")]
        public Microsoft.Xrm.Sdk.OptionSetValue CALType
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("caltype"); }
            set
            {
                this.OnPropertyChanging("CALType");
                this.SetAttributeValue("caltype", value);
                this.OnPropertyChanged("CALType");
            }
        }

        /// <summary>
        /// Unique identifier of the user who created the user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby"); }
        }

        /// <summary>
        /// Date and time when the user was created.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
        public System.Nullable<System.DateTime> CreatedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who created the systemuser.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        /// Indicates if default outlook filters have been populated.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("defaultfilterspopulated")]
        public System.Nullable<bool> DefaultFiltersPopulated
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("defaultfilterspopulated"); }
        }

        /// <summary>
        /// Select the mailbox associated with this user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("defaultmailbox")]
        public Microsoft.Xrm.Sdk.EntityReference DefaultMailbox
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("defaultmailbox"); }
        }

        /// <summary>
        /// Reason for disabling the user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("disabledreason")]
        public string DisabledReason
        {
            get { return this.GetAttributeValue<string>("disabledreason"); }
        }

        /// <summary>
        /// Whether to display the user in service views.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("displayinserviceviews")]
        public System.Nullable<bool> DisplayInServiceViews
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("displayinserviceviews"); }
            set
            {
                this.OnPropertyChanging("DisplayInServiceViews");
                this.SetAttributeValue("displayinserviceviews", value);
                this.OnPropertyChanged("DisplayInServiceViews");
            }
        }

        /// <summary>
        /// Active Directory domain of which the user is a member.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("domainname")]
        public string DomainName
        {
            get { return this.GetAttributeValue<string>("domainname"); }
            set
            {
                this.OnPropertyChanging("DomainName");
                this.SetAttributeValue("domainname", value);
                this.OnPropertyChanged("DomainName");
            }
        }

        /// <summary>
        /// Shows the status of the primary email address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("emailrouteraccessapproval")]
        public Microsoft.Xrm.Sdk.OptionSetValue EmailRouterAccessApproval
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("emailrouteraccessapproval"); }
            set
            {
                this.OnPropertyChanging("EmailRouterAccessApproval");
                this.SetAttributeValue("emailrouteraccessapproval", value);
                this.OnPropertyChanged("EmailRouterAccessApproval");
            }
        }

        /// <summary>
        /// Employee identifier for the user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("employeeid")]
        public string EmployeeId
        {
            get { return this.GetAttributeValue<string>("employeeid"); }
            set
            {
                this.OnPropertyChanging("EmployeeId");
                this.SetAttributeValue("employeeid", value);
                this.OnPropertyChanged("EmployeeId");
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
        /// Exchange rate for the currency associated with the systemuser with respect to the base currency.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("exchangerate")]
        public System.Nullable<decimal> ExchangeRate
        {
            get { return this.GetAttributeValue<System.Nullable<decimal>>("exchangerate"); }
        }

        /// <summary>
        /// First name of the user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("firstname")]
        public string FirstName
        {
            get { return this.GetAttributeValue<string>("firstname"); }
            set
            {
                this.OnPropertyChanging("FirstName");
                this.SetAttributeValue("firstname", value);
                this.OnPropertyChanged("FirstName");
            }
        }

        /// <summary>
        /// Full name of the user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("fullname")]
        public string FullName
        {
            get { return this.GetAttributeValue<string>("fullname"); }
        }

        /// <summary>
        /// Government identifier for the user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("governmentid")]
        public string GovernmentId
        {
            get { return this.GetAttributeValue<string>("governmentid"); }
            set
            {
                this.OnPropertyChanging("GovernmentId");
                this.SetAttributeValue("governmentid", value);
                this.OnPropertyChanged("GovernmentId");
            }
        }

        /// <summary>
        /// Home phone number for the user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("homephone")]
        public string HomePhone
        {
            get { return this.GetAttributeValue<string>("homephone"); }
            set
            {
                this.OnPropertyChanging("HomePhone");
                this.SetAttributeValue("homephone", value);
                this.OnPropertyChanged("HomePhone");
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
        /// Incoming email delivery method for the user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("incomingemaildeliverymethod")]
        public Microsoft.Xrm.Sdk.OptionSetValue IncomingEmailDeliveryMethod
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("incomingemaildeliverymethod"); }
            set
            {
                this.OnPropertyChanging("IncomingEmailDeliveryMethod");
                this.SetAttributeValue("incomingemaildeliverymethod", value);
                this.OnPropertyChanged("IncomingEmailDeliveryMethod");
            }
        }

        /// <summary>
        /// Internal email address for the user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("internalemailaddress")]
        public string InternalEMailAddress
        {
            get { return this.GetAttributeValue<string>("internalemailaddress"); }
            set
            {
                this.OnPropertyChanging("InternalEMailAddress");
                this.SetAttributeValue("internalemailaddress", value);
                this.OnPropertyChanged("InternalEMailAddress");
            }
        }

        /// <summary>
        /// User invitation status.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("invitestatuscode")]
        public Microsoft.Xrm.Sdk.OptionSetValue InviteStatusCode
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("invitestatuscode"); }
            set
            {
                this.OnPropertyChanging("InviteStatusCode");
                this.SetAttributeValue("invitestatuscode", value);
                this.OnPropertyChanged("InviteStatusCode");
            }
        }

        /// <summary>
        /// Information about whether the user is enabled.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isdisabled")]
        public System.Nullable<bool> IsDisabled
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("isdisabled"); }
        }

        /// <summary>
        /// Shows the status of approval of the email address by O365 Admin.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isemailaddressapprovedbyo365admin")]
        public System.Nullable<bool> IsEmailAddressApprovedByO365Admin
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("isemailaddressapprovedbyo365admin"); }
        }

        /// <summary>
        /// Check if user is an integration user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isintegrationuser")]
        public System.Nullable<bool> IsIntegrationUser
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("isintegrationuser"); }
            set
            {
                this.OnPropertyChanging("IsIntegrationUser");
                this.SetAttributeValue("isintegrationuser", value);
                this.OnPropertyChanged("IsIntegrationUser");
            }
        }

        /// <summary>
        /// Information about whether the user is licensed.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("islicensed")]
        public System.Nullable<bool> IsLicensed
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("islicensed"); }
            set
            {
                this.OnPropertyChanging("IsLicensed");
                this.SetAttributeValue("islicensed", value);
                this.OnPropertyChanged("IsLicensed");
            }
        }

        /// <summary>
        /// Information about whether the user is synced with the directory.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("issyncwithdirectory")]
        public System.Nullable<bool> IsSyncWithDirectory
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("issyncwithdirectory"); }
            set
            {
                this.OnPropertyChanging("IsSyncWithDirectory");
                this.SetAttributeValue("issyncwithdirectory", value);
                this.OnPropertyChanged("IsSyncWithDirectory");
            }
        }

        /// <summary>
        /// Job title of the user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("jobtitle")]
        public string JobTitle
        {
            get { return this.GetAttributeValue<string>("jobtitle"); }
            set
            {
                this.OnPropertyChanging("JobTitle");
                this.SetAttributeValue("jobtitle", value);
                this.OnPropertyChanged("JobTitle");
            }
        }

        /// <summary>
        /// Last name of the user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("lastname")]
        public string LastName
        {
            get { return this.GetAttributeValue<string>("lastname"); }
            set
            {
                this.OnPropertyChanging("LastName");
                this.SetAttributeValue("lastname", value);
                this.OnPropertyChanged("LastName");
            }
        }

        /// <summary>
        /// Middle name of the user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("middlename")]
        public string MiddleName
        {
            get { return this.GetAttributeValue<string>("middlename"); }
            set
            {
                this.OnPropertyChanging("MiddleName");
                this.SetAttributeValue("middlename", value);
                this.OnPropertyChanged("MiddleName");
            }
        }

        /// <summary>
        /// Mobile alert email address for the user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("mobilealertemail")]
        public string MobileAlertEMail
        {
            get { return this.GetAttributeValue<string>("mobilealertemail"); }
            set
            {
                this.OnPropertyChanging("MobileAlertEMail");
                this.SetAttributeValue("mobilealertemail", value);
                this.OnPropertyChanged("MobileAlertEMail");
            }
        }

        /// <summary>
        /// Mobile phone number for the user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("mobilephone")]
        public string MobilePhone
        {
            get { return this.GetAttributeValue<string>("mobilephone"); }
            set
            {
                this.OnPropertyChanging("MobilePhone");
                this.SetAttributeValue("mobilephone", value);
                this.OnPropertyChanged("MobilePhone");
            }
        }

        /// <summary>
        /// Unique identifier of the user who last modified the user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby"); }
        }

        /// <summary>
        /// Date and time when the user was last modified.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
        public System.Nullable<System.DateTime> ModifiedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who last modified the systemuser.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        /// Nickname of the user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("nickname")]
        public string NickName
        {
            get { return this.GetAttributeValue<string>("nickname"); }
            set
            {
                this.OnPropertyChanging("NickName");
                this.SetAttributeValue("nickname", value);
                this.OnPropertyChanged("NickName");
            }
        }

        /// <summary>
        /// Unique identifier of the organization associated with the user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
        public System.Nullable<System.Guid> OrganizationId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("organizationid"); }
        }

        /// <summary>
        /// Outgoing email delivery method for the user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("outgoingemaildeliverymethod")]
        public Microsoft.Xrm.Sdk.OptionSetValue OutgoingEmailDeliveryMethod
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("outgoingemaildeliverymethod"); }
            set
            {
                this.OnPropertyChanging("OutgoingEmailDeliveryMethod");
                this.SetAttributeValue("outgoingemaildeliverymethod", value);
                this.OnPropertyChanged("OutgoingEmailDeliveryMethod");
            }
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
        /// Unique identifier of the manager of the user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("parentsystemuserid")]
        public Microsoft.Xrm.Sdk.EntityReference ParentSystemUserId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("parentsystemuserid"); }
            set
            {
                this.OnPropertyChanging("ParentSystemUserId");
                this.SetAttributeValue("parentsystemuserid", value);
                this.OnPropertyChanged("ParentSystemUserId");
            }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("passporthi")]
        public System.Nullable<int> PassportHi
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("passporthi"); }
            set
            {
                this.OnPropertyChanging("PassportHi");
                this.SetAttributeValue("passporthi", value);
                this.OnPropertyChanged("PassportHi");
            }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("passportlo")]
        public System.Nullable<int> PassportLo
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("passportlo"); }
            set
            {
                this.OnPropertyChanging("PassportLo");
                this.SetAttributeValue("passportlo", value);
                this.OnPropertyChanged("PassportLo");
            }
        }

        /// <summary>
        /// Personal email address of the user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("personalemailaddress")]
        public string PersonalEMailAddress
        {
            get { return this.GetAttributeValue<string>("personalemailaddress"); }
            set
            {
                this.OnPropertyChanging("PersonalEMailAddress");
                this.SetAttributeValue("personalemailaddress", value);
                this.OnPropertyChanged("PersonalEMailAddress");
            }
        }

        /// <summary>
        /// URL for the Website on which a photo of the user is located.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("photourl")]
        public string PhotoUrl
        {
            get { return this.GetAttributeValue<string>("photourl"); }
            set
            {
                this.OnPropertyChanging("PhotoUrl");
                this.SetAttributeValue("photourl", value);
                this.OnPropertyChanged("PhotoUrl");
            }
        }

        /// <summary>
        /// User's position in hierarchical security model.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("positionid")]
        public Microsoft.Xrm.Sdk.EntityReference PositionId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("positionid"); }
            set
            {
                this.OnPropertyChanging("PositionId");
                this.SetAttributeValue("positionid", value);
                this.OnPropertyChanged("PositionId");
            }
        }

        /// <summary>
        /// Preferred address for the user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("preferredaddresscode")]
        public Microsoft.Xrm.Sdk.OptionSetValue PreferredAddressCode
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("preferredaddresscode"); }
            set
            {
                this.OnPropertyChanging("PreferredAddressCode");
                this.SetAttributeValue("preferredaddresscode", value);
                this.OnPropertyChanged("PreferredAddressCode");
            }
        }

        /// <summary>
        /// Preferred email address for the user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("preferredemailcode")]
        public Microsoft.Xrm.Sdk.OptionSetValue PreferredEmailCode
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("preferredemailcode"); }
            set
            {
                this.OnPropertyChanging("PreferredEmailCode");
                this.SetAttributeValue("preferredemailcode", value);
                this.OnPropertyChanged("PreferredEmailCode");
            }
        }

        /// <summary>
        /// Preferred phone number for the user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("preferredphonecode")]
        public Microsoft.Xrm.Sdk.OptionSetValue PreferredPhoneCode
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("preferredphonecode"); }
            set
            {
                this.OnPropertyChanging("PreferredPhoneCode");
                this.SetAttributeValue("preferredphonecode", value);
                this.OnPropertyChanged("PreferredPhoneCode");
            }
        }

        /// <summary>
        /// Shows the ID of the process.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("processid")]
        public System.Nullable<System.Guid> ProcessId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("processid"); }
            set
            {
                this.OnPropertyChanging("ProcessId");
                this.SetAttributeValue("processid", value);
                this.OnPropertyChanged("ProcessId");
            }
        }

        /// <summary>
        /// Unique identifier of the default queue for the user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("queueid")]
        public Microsoft.Xrm.Sdk.EntityReference QueueId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("queueid"); }
            set
            {
                this.OnPropertyChanging("QueueId");
                this.SetAttributeValue("queueid", value);
                this.OnPropertyChanged("QueueId");
            }
        }

        /// <summary>
        /// Salutation for correspondence with the user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("salutation")]
        public string Salutation
        {
            get { return this.GetAttributeValue<string>("salutation"); }
            set
            {
                this.OnPropertyChanging("Salutation");
                this.SetAttributeValue("salutation", value);
                this.OnPropertyChanged("Salutation");
            }
        }

        /// <summary>
        /// Check if user is a setup user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("setupuser")]
        public System.Nullable<bool> SetupUser
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("setupuser"); }
            set
            {
                this.OnPropertyChanging("SetupUser");
                this.SetAttributeValue("setupuser", value);
                this.OnPropertyChanged("SetupUser");
            }
        }

        /// <summary>
        /// Site at which the user is located.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("siteid")]
        public Microsoft.Xrm.Sdk.EntityReference SiteId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("siteid"); }
            set
            {
                this.OnPropertyChanging("SiteId");
                this.SetAttributeValue("siteid", value);
                this.OnPropertyChanged("SiteId");
            }
        }

        /// <summary>
        /// Skill set of the user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("skills")]
        public string Skills
        {
            get { return this.GetAttributeValue<string>("skills"); }
            set
            {
                this.OnPropertyChanging("Skills");
                this.SetAttributeValue("skills", value);
                this.OnPropertyChanged("Skills");
            }
        }

        /// <summary>
        /// Shows the ID of the stage.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("stageid")]
        public System.Nullable<System.Guid> StageId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("stageid"); }
            set
            {
                this.OnPropertyChanging("StageId");
                this.SetAttributeValue("stageid", value);
                this.OnPropertyChanged("StageId");
            }
        }

        /// <summary>
        /// Unique identifier for the user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("systemuserid")]
        public System.Nullable<System.Guid> SystemUserId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("systemuserid"); }
            set
            {
                this.OnPropertyChanging("SystemUserId");
                this.SetAttributeValue("systemuserid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("SystemUserId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("systemuserid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.SystemUserId = value; }
        }

        /// <summary>
        /// Unique identifier of the territory to which the user is assigned.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("territoryid")]
        public Microsoft.Xrm.Sdk.EntityReference TerritoryId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("territoryid"); }
            set
            {
                this.OnPropertyChanging("TerritoryId");
                this.SetAttributeValue("territoryid", value);
                this.OnPropertyChanged("TerritoryId");
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
        /// Title of the user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("title")]
        public string Title
        {
            get { return this.GetAttributeValue<string>("title"); }
            set
            {
                this.OnPropertyChanging("Title");
                this.SetAttributeValue("title", value);
                this.OnPropertyChanged("Title");
            }
        }

        /// <summary>
        /// Unique identifier of the currency associated with the systemuser.
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
        /// A comma separated list of string values representing the unique identifiers of stages in a Business Process Flow Instance in the order that they occur.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("traversedpath")]
        public string TraversedPath
        {
            get { return this.GetAttributeValue<string>("traversedpath"); }
            set
            {
                this.OnPropertyChanging("TraversedPath");
                this.SetAttributeValue("traversedpath", value);
                this.OnPropertyChanged("TraversedPath");
            }
        }

        /// <summary>
        /// Shows the type of user license.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("userlicensetype")]
        public System.Nullable<int> UserLicenseType
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("userlicensetype"); }
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
        /// Version number of the user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
        public System.Nullable<long> VersionNumber
        {
            get { return this.GetAttributeValue<System.Nullable<long>>("versionnumber"); }
        }

        /// <summary>
        /// Windows Live ID
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("windowsliveid")]
        public string WindowsLiveID
        {
            get { return this.GetAttributeValue<string>("windowsliveid"); }
            set
            {
                this.OnPropertyChanging("WindowsLiveID");
                this.SetAttributeValue("windowsliveid", value);
                this.OnPropertyChanged("WindowsLiveID");
            }
        }

        /// <summary>
        /// User's Yammer login email address
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("yammeremailaddress")]
        public string YammerEmailAddress
        {
            get { return this.GetAttributeValue<string>("yammeremailaddress"); }
            set
            {
                this.OnPropertyChanging("YammerEmailAddress");
                this.SetAttributeValue("yammeremailaddress", value);
                this.OnPropertyChanged("YammerEmailAddress");
            }
        }

        /// <summary>
        /// User's Yammer ID
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("yammeruserid")]
        public string YammerUserId
        {
            get { return this.GetAttributeValue<string>("yammeruserid"); }
            set
            {
                this.OnPropertyChanging("YammerUserId");
                this.SetAttributeValue("yammeruserid", value);
                this.OnPropertyChanged("YammerUserId");
            }
        }

        /// <summary>
        /// Pronunciation of the first name of the user, written in phonetic hiragana or katakana characters.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("yomifirstname")]
        public string YomiFirstName
        {
            get { return this.GetAttributeValue<string>("yomifirstname"); }
            set
            {
                this.OnPropertyChanging("YomiFirstName");
                this.SetAttributeValue("yomifirstname", value);
                this.OnPropertyChanged("YomiFirstName");
            }
        }

        /// <summary>
        /// Pronunciation of the full name of the user, written in phonetic hiragana or katakana characters.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("yomifullname")]
        public string YomiFullName
        {
            get { return this.GetAttributeValue<string>("yomifullname"); }
        }

        /// <summary>
        /// Pronunciation of the last name of the user, written in phonetic hiragana or katakana characters.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("yomilastname")]
        public string YomiLastName
        {
            get { return this.GetAttributeValue<string>("yomilastname"); }
            set
            {
                this.OnPropertyChanging("YomiLastName");
                this.SetAttributeValue("yomilastname", value);
                this.OnPropertyChanged("YomiLastName");
            }
        }

        /// <summary>
        /// Pronunciation of the middle name of the user, written in phonetic hiragana or katakana characters.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("yomimiddlename")]
        public string YomiMiddleName
        {
            get { return this.GetAttributeValue<string>("yomimiddlename"); }
            set
            {
                this.OnPropertyChanging("YomiMiddleName");
                this.SetAttributeValue("yomimiddlename", value);
                this.OnPropertyChanged("YomiMiddleName");
            }
        }

        /// <summary>
        /// 1:N annotation_owning_user
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("annotation_owning_user")]
        public System.Collections.Generic.IEnumerable<Annotation> annotation_owning_user
        {
            get { return this.GetRelatedEntities<Annotation>("annotation_owning_user", null); }
            set
            {
                this.OnPropertyChanging("annotation_owning_user");
                this.SetRelatedEntities<Annotation>("annotation_owning_user", null, value);
                this.OnPropertyChanged("annotation_owning_user");
            }
        }

        /// <summary>
        /// 1:N constraintbasedgroup_systemuser
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("constraintbasedgroup_systemuser")]
        public System.Collections.Generic.IEnumerable<ConstraintBasedGroup> constraintbasedgroup_systemuser
        {
            get { return this.GetRelatedEntities<ConstraintBasedGroup>("constraintbasedgroup_systemuser", null); }
            set
            {
                this.OnPropertyChanging("constraintbasedgroup_systemuser");
                this.SetRelatedEntities<ConstraintBasedGroup>("constraintbasedgroup_systemuser", null, value);
                this.OnPropertyChanged("constraintbasedgroup_systemuser");
            }
        }

        /// <summary>
        /// 1:N contact_owning_user
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("contact_owning_user")]
        public System.Collections.Generic.IEnumerable<Contact> contact_owning_user
        {
            get { return this.GetRelatedEntities<Contact>("contact_owning_user", null); }
            set
            {
                this.OnPropertyChanging("contact_owning_user");
                this.SetRelatedEntities<Contact>("contact_owning_user", null, value);
                this.OnPropertyChanged("contact_owning_user");
            }
        }

        /// <summary>
        /// 1:N createdby_attributemap
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("createdby_attributemap")]
        public System.Collections.Generic.IEnumerable<AttributeMap> createdby_attributemap
        {
            get { return this.GetRelatedEntities<AttributeMap>("createdby_attributemap", null); }
            set
            {
                this.OnPropertyChanging("createdby_attributemap");
                this.SetRelatedEntities<AttributeMap>("createdby_attributemap", null, value);
                this.OnPropertyChanged("createdby_attributemap");
            }
        }

        /// <summary>
        /// 1:N createdby_connection
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("createdby_connection")]
        public System.Collections.Generic.IEnumerable<Connection> createdby_connection
        {
            get { return this.GetRelatedEntities<Connection>("createdby_connection", null); }
            set
            {
                this.OnPropertyChanging("createdby_connection");
                this.SetRelatedEntities<Connection>("createdby_connection", null, value);
                this.OnPropertyChanged("createdby_connection");
            }
        }

        /// <summary>
        /// 1:N createdby_connection_role
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("createdby_connection_role")]
        public System.Collections.Generic.IEnumerable<ConnectionRole> createdby_connection_role
        {
            get { return this.GetRelatedEntities<ConnectionRole>("createdby_connection_role", null); }
            set
            {
                this.OnPropertyChanging("createdby_connection_role");
                this.SetRelatedEntities<ConnectionRole>("createdby_connection_role", null, value);
                this.OnPropertyChanged("createdby_connection_role");
            }
        }

        /// <summary>
        /// 1:N createdby_customer_relationship
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("createdby_customer_relationship")]
        public System.Collections.Generic.IEnumerable<CustomerRelationship> createdby_customer_relationship
        {
            get { return this.GetRelatedEntities<CustomerRelationship>("createdby_customer_relationship", null); }
            set
            {
                this.OnPropertyChanging("createdby_customer_relationship");
                this.SetRelatedEntities<CustomerRelationship>("createdby_customer_relationship", null, value);
                this.OnPropertyChanged("createdby_customer_relationship");
            }
        }

        /// <summary>
        /// 1:N createdby_entitymap
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("createdby_entitymap")]
        public System.Collections.Generic.IEnumerable<EntityMap> createdby_entitymap
        {
            get { return this.GetRelatedEntities<EntityMap>("createdby_entitymap", null); }
            set
            {
                this.OnPropertyChanging("createdby_entitymap");
                this.SetRelatedEntities<EntityMap>("createdby_entitymap", null, value);
                this.OnPropertyChanged("createdby_entitymap");
            }
        }

        /// <summary>
        /// 1:N createdby_pluginassembly
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("createdby_pluginassembly")]
        public System.Collections.Generic.IEnumerable<PluginAssembly> createdby_pluginassembly
        {
            get { return this.GetRelatedEntities<PluginAssembly>("createdby_pluginassembly", null); }
            set
            {
                this.OnPropertyChanging("createdby_pluginassembly");
                this.SetRelatedEntities<PluginAssembly>("createdby_pluginassembly", null, value);
                this.OnPropertyChanged("createdby_pluginassembly");
            }
        }

        /// <summary>
        /// 1:N createdby_plugintype
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("createdby_plugintype")]
        public System.Collections.Generic.IEnumerable<PluginType> createdby_plugintype
        {
            get { return this.GetRelatedEntities<PluginType>("createdby_plugintype", null); }
            set
            {
                this.OnPropertyChanging("createdby_plugintype");
                this.SetRelatedEntities<PluginType>("createdby_plugintype", null, value);
                this.OnPropertyChanged("createdby_plugintype");
            }
        }

        /// <summary>
        /// 1:N createdby_plugintypestatistic
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("createdby_plugintypestatistic")]
        public System.Collections.Generic.IEnumerable<PluginTypeStatistic> createdby_plugintypestatistic
        {
            get { return this.GetRelatedEntities<PluginTypeStatistic>("createdby_plugintypestatistic", null); }
            set
            {
                this.OnPropertyChanging("createdby_plugintypestatistic");
                this.SetRelatedEntities<PluginTypeStatistic>("createdby_plugintypestatistic", null, value);
                this.OnPropertyChanged("createdby_plugintypestatistic");
            }
        }

        /// <summary>
        /// 1:N createdby_relationship_role
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("createdby_relationship_role")]
        public System.Collections.Generic.IEnumerable<RelationshipRole> createdby_relationship_role
        {
            get { return this.GetRelatedEntities<RelationshipRole>("createdby_relationship_role", null); }
            set
            {
                this.OnPropertyChanging("createdby_relationship_role");
                this.SetRelatedEntities<RelationshipRole>("createdby_relationship_role", null, value);
                this.OnPropertyChanged("createdby_relationship_role");
            }
        }

        /// <summary>
        /// 1:N createdby_relationship_role_map
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("createdby_relationship_role_map")]
        public System.Collections.Generic.IEnumerable<RelationshipRoleMap> createdby_relationship_role_map
        {
            get { return this.GetRelatedEntities<RelationshipRoleMap>("createdby_relationship_role_map", null); }
            set
            {
                this.OnPropertyChanging("createdby_relationship_role_map");
                this.SetRelatedEntities<RelationshipRoleMap>("createdby_relationship_role_map", null, value);
                this.OnPropertyChanged("createdby_relationship_role_map");
            }
        }

        /// <summary>
        /// 1:N createdby_sdkmessage
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("createdby_sdkmessage")]
        public System.Collections.Generic.IEnumerable<SdkMessage> createdby_sdkmessage
        {
            get { return this.GetRelatedEntities<SdkMessage>("createdby_sdkmessage", null); }
            set
            {
                this.OnPropertyChanging("createdby_sdkmessage");
                this.SetRelatedEntities<SdkMessage>("createdby_sdkmessage", null, value);
                this.OnPropertyChanged("createdby_sdkmessage");
            }
        }

        /// <summary>
        /// 1:N createdby_sdkmessagefilter
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("createdby_sdkmessagefilter")]
        public System.Collections.Generic.IEnumerable<SdkMessageFilter> createdby_sdkmessagefilter
        {
            get { return this.GetRelatedEntities<SdkMessageFilter>("createdby_sdkmessagefilter", null); }
            set
            {
                this.OnPropertyChanging("createdby_sdkmessagefilter");
                this.SetRelatedEntities<SdkMessageFilter>("createdby_sdkmessagefilter", null, value);
                this.OnPropertyChanged("createdby_sdkmessagefilter");
            }
        }

        /// <summary>
        /// 1:N createdby_sdkmessagepair
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("createdby_sdkmessagepair")]
        public System.Collections.Generic.IEnumerable<SdkMessagePair> createdby_sdkmessagepair
        {
            get { return this.GetRelatedEntities<SdkMessagePair>("createdby_sdkmessagepair", null); }
            set
            {
                this.OnPropertyChanging("createdby_sdkmessagepair");
                this.SetRelatedEntities<SdkMessagePair>("createdby_sdkmessagepair", null, value);
                this.OnPropertyChanged("createdby_sdkmessagepair");
            }
        }

        /// <summary>
        /// 1:N createdby_sdkmessageprocessingstep
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("createdby_sdkmessageprocessingstep")]
        public System.Collections.Generic.IEnumerable<SdkMessageProcessingStep> createdby_sdkmessageprocessingstep
        {
            get { return this.GetRelatedEntities<SdkMessageProcessingStep>("createdby_sdkmessageprocessingstep", null); }
            set
            {
                this.OnPropertyChanging("createdby_sdkmessageprocessingstep");
                this.SetRelatedEntities<SdkMessageProcessingStep>("createdby_sdkmessageprocessingstep", null, value);
                this.OnPropertyChanged("createdby_sdkmessageprocessingstep");
            }
        }

        /// <summary>
        /// 1:N createdby_sdkmessageprocessingstepimage
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("createdby_sdkmessageprocessingstepimage")]
        public System.Collections.Generic.IEnumerable<SdkMessageProcessingStepImage> createdby_sdkmessageprocessingstepimage
        {
            get { return this.GetRelatedEntities<SdkMessageProcessingStepImage>("createdby_sdkmessageprocessingstepimage", null); }
            set
            {
                this.OnPropertyChanging("createdby_sdkmessageprocessingstepimage");
                this.SetRelatedEntities<SdkMessageProcessingStepImage>("createdby_sdkmessageprocessingstepimage", null, value);
                this.OnPropertyChanged("createdby_sdkmessageprocessingstepimage");
            }
        }

        /// <summary>
        /// 1:N createdby_sdkmessageprocessingstepsecureconfig
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("createdby_sdkmessageprocessingstepsecureconfig")]
        public System.Collections.Generic.IEnumerable<SdkMessageProcessingStepSecureConfig> createdby_sdkmessageprocessingstepsecureconfig
        {
            get { return this.GetRelatedEntities<SdkMessageProcessingStepSecureConfig>("createdby_sdkmessageprocessingstepsecureconfig", null); }
            set
            {
                this.OnPropertyChanging("createdby_sdkmessageprocessingstepsecureconfig");
                this.SetRelatedEntities<SdkMessageProcessingStepSecureConfig>("createdby_sdkmessageprocessingstepsecureconfig", null, value);
                this.OnPropertyChanged("createdby_sdkmessageprocessingstepsecureconfig");
            }
        }

        /// <summary>
        /// 1:N createdby_sdkmessagerequest
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("createdby_sdkmessagerequest")]
        public System.Collections.Generic.IEnumerable<SdkMessageRequest> createdby_sdkmessagerequest
        {
            get { return this.GetRelatedEntities<SdkMessageRequest>("createdby_sdkmessagerequest", null); }
            set
            {
                this.OnPropertyChanging("createdby_sdkmessagerequest");
                this.SetRelatedEntities<SdkMessageRequest>("createdby_sdkmessagerequest", null, value);
                this.OnPropertyChanged("createdby_sdkmessagerequest");
            }
        }

        /// <summary>
        /// 1:N createdby_sdkmessagerequestfield
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("createdby_sdkmessagerequestfield")]
        public System.Collections.Generic.IEnumerable<SdkMessageRequestField> createdby_sdkmessagerequestfield
        {
            get { return this.GetRelatedEntities<SdkMessageRequestField>("createdby_sdkmessagerequestfield", null); }
            set
            {
                this.OnPropertyChanging("createdby_sdkmessagerequestfield");
                this.SetRelatedEntities<SdkMessageRequestField>("createdby_sdkmessagerequestfield", null, value);
                this.OnPropertyChanged("createdby_sdkmessagerequestfield");
            }
        }

        /// <summary>
        /// 1:N createdby_sdkmessageresponse
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("createdby_sdkmessageresponse")]
        public System.Collections.Generic.IEnumerable<SdkMessageResponse> createdby_sdkmessageresponse
        {
            get { return this.GetRelatedEntities<SdkMessageResponse>("createdby_sdkmessageresponse", null); }
            set
            {
                this.OnPropertyChanging("createdby_sdkmessageresponse");
                this.SetRelatedEntities<SdkMessageResponse>("createdby_sdkmessageresponse", null, value);
                this.OnPropertyChanged("createdby_sdkmessageresponse");
            }
        }

        /// <summary>
        /// 1:N createdby_sdkmessageresponsefield
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("createdby_sdkmessageresponsefield")]
        public System.Collections.Generic.IEnumerable<SdkMessageResponseField> createdby_sdkmessageresponsefield
        {
            get { return this.GetRelatedEntities<SdkMessageResponseField>("createdby_sdkmessageresponsefield", null); }
            set
            {
                this.OnPropertyChanging("createdby_sdkmessageresponsefield");
                this.SetRelatedEntities<SdkMessageResponseField>("createdby_sdkmessageresponsefield", null, value);
                this.OnPropertyChanged("createdby_sdkmessageresponsefield");
            }
        }

        /// <summary>
        /// 1:N createdby_serviceendpoint
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("createdby_serviceendpoint")]
        public System.Collections.Generic.IEnumerable<ServiceEndpoint> createdby_serviceendpoint
        {
            get { return this.GetRelatedEntities<ServiceEndpoint>("createdby_serviceendpoint", null); }
            set
            {
                this.OnPropertyChanging("createdby_serviceendpoint");
                this.SetRelatedEntities<ServiceEndpoint>("createdby_serviceendpoint", null, value);
                this.OnPropertyChanged("createdby_serviceendpoint");
            }
        }

        /// <summary>
        /// 1:N createdonbehalfby_attributemap
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("createdonbehalfby_attributemap")]
        public System.Collections.Generic.IEnumerable<AttributeMap> createdonbehalfby_attributemap
        {
            get { return this.GetRelatedEntities<AttributeMap>("createdonbehalfby_attributemap", null); }
            set
            {
                this.OnPropertyChanging("createdonbehalfby_attributemap");
                this.SetRelatedEntities<AttributeMap>("createdonbehalfby_attributemap", null, value);
                this.OnPropertyChanged("createdonbehalfby_attributemap");
            }
        }

        /// <summary>
        /// 1:N createdonbehalfby_customer_relationship
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("createdonbehalfby_customer_relationship")]
        public System.Collections.Generic.IEnumerable<CustomerRelationship> createdonbehalfby_customer_relationship
        {
            get { return this.GetRelatedEntities<CustomerRelationship>("createdonbehalfby_customer_relationship", null); }
            set
            {
                this.OnPropertyChanging("createdonbehalfby_customer_relationship");
                this.SetRelatedEntities<CustomerRelationship>("createdonbehalfby_customer_relationship", null, value);
                this.OnPropertyChanged("createdonbehalfby_customer_relationship");
            }
        }

        /// <summary>
        /// 1:N Dynamicpropertyinsatance_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Dynamicpropertyinsatance_createdby")]
        public System.Collections.Generic.IEnumerable<DynamicPropertyInstance> Dynamicpropertyinsatance_createdby
        {
            get { return this.GetRelatedEntities<DynamicPropertyInstance>("Dynamicpropertyinsatance_createdby", null); }
            set
            {
                this.OnPropertyChanging("Dynamicpropertyinsatance_createdby");
                this.SetRelatedEntities<DynamicPropertyInstance>("Dynamicpropertyinsatance_createdby", null, value);
                this.OnPropertyChanged("Dynamicpropertyinsatance_createdby");
            }
        }

        /// <summary>
        /// 1:N equipment_systemuser
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("equipment_systemuser")]
        public System.Collections.Generic.IEnumerable<Equipment> equipment_systemuser
        {
            get { return this.GetRelatedEntities<Equipment>("equipment_systemuser", null); }
            set
            {
                this.OnPropertyChanging("equipment_systemuser");
                this.SetRelatedEntities<Equipment>("equipment_systemuser", null, value);
                this.OnPropertyChanged("equipment_systemuser");
            }
        }

        /// <summary>
        /// 1:N impersonatinguserid_sdkmessageprocessingstep
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("impersonatinguserid_sdkmessageprocessingstep")]
        public System.Collections.Generic.IEnumerable<SdkMessageProcessingStep> impersonatinguserid_sdkmessageprocessingstep
        {
            get { return this.GetRelatedEntities<SdkMessageProcessingStep>("impersonatinguserid_sdkmessageprocessingstep", null); }
            set
            {
                this.OnPropertyChanging("impersonatinguserid_sdkmessageprocessingstep");
                this.SetRelatedEntities<SdkMessageProcessingStep>("impersonatinguserid_sdkmessageprocessingstep", null, value);
                this.OnPropertyChanged("impersonatinguserid_sdkmessageprocessingstep");
            }
        }

        /// <summary>
        /// 1:N ImportFile_SystemUser
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ImportFile_SystemUser")]
        public System.Collections.Generic.IEnumerable<ImportFile> ImportFile_SystemUser
        {
            get { return this.GetRelatedEntities<ImportFile>("ImportFile_SystemUser", null); }
            set
            {
                this.OnPropertyChanging("ImportFile_SystemUser");
                this.SetRelatedEntities<ImportFile>("ImportFile_SystemUser", null, value);
                this.OnPropertyChanged("ImportFile_SystemUser");
            }
        }

        /// <summary>
        /// 1:N lead_owning_user
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lead_owning_user")]
        public System.Collections.Generic.IEnumerable<Lead> lead_owning_user
        {
            get { return this.GetRelatedEntities<Lead>("lead_owning_user", null); }
            set
            {
                this.OnPropertyChanging("lead_owning_user");
                this.SetRelatedEntities<Lead>("lead_owning_user", null, value);
                this.OnPropertyChanged("lead_owning_user");
            }
        }

        /// <summary>
        /// 1:N lk_accountbase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_accountbase_createdby")]
        public System.Collections.Generic.IEnumerable<Account> lk_accountbase_createdby
        {
            get { return this.GetRelatedEntities<Account>("lk_accountbase_createdby", null); }
            set
            {
                this.OnPropertyChanging("lk_accountbase_createdby");
                this.SetRelatedEntities<Account>("lk_accountbase_createdby", null, value);
                this.OnPropertyChanged("lk_accountbase_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_accountbase_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_accountbase_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<Account> lk_accountbase_createdonbehalfby
        {
            get { return this.GetRelatedEntities<Account>("lk_accountbase_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_accountbase_createdonbehalfby");
                this.SetRelatedEntities<Account>("lk_accountbase_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_accountbase_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_accountbase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_accountbase_modifiedby")]
        public System.Collections.Generic.IEnumerable<Account> lk_accountbase_modifiedby
        {
            get { return this.GetRelatedEntities<Account>("lk_accountbase_modifiedby", null); }
            set
            {
                this.OnPropertyChanging("lk_accountbase_modifiedby");
                this.SetRelatedEntities<Account>("lk_accountbase_modifiedby", null, value);
                this.OnPropertyChanged("lk_accountbase_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_accountbase_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_accountbase_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<Account> lk_accountbase_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<Account>("lk_accountbase_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_accountbase_modifiedonbehalfby");
                this.SetRelatedEntities<Account>("lk_accountbase_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_accountbase_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_activitypointer_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_activitypointer_createdby")]
        public System.Collections.Generic.IEnumerable<ActivityPointer> lk_activitypointer_createdby
        {
            get { return this.GetRelatedEntities<ActivityPointer>("lk_activitypointer_createdby", null); }
            set
            {
                this.OnPropertyChanging("lk_activitypointer_createdby");
                this.SetRelatedEntities<ActivityPointer>("lk_activitypointer_createdby", null, value);
                this.OnPropertyChanged("lk_activitypointer_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_activitypointer_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_activitypointer_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<ActivityPointer> lk_activitypointer_createdonbehalfby
        {
            get { return this.GetRelatedEntities<ActivityPointer>("lk_activitypointer_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_activitypointer_createdonbehalfby");
                this.SetRelatedEntities<ActivityPointer>("lk_activitypointer_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_activitypointer_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_activitypointer_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_activitypointer_modifiedby")]
        public System.Collections.Generic.IEnumerable<ActivityPointer> lk_activitypointer_modifiedby
        {
            get { return this.GetRelatedEntities<ActivityPointer>("lk_activitypointer_modifiedby", null); }
            set
            {
                this.OnPropertyChanging("lk_activitypointer_modifiedby");
                this.SetRelatedEntities<ActivityPointer>("lk_activitypointer_modifiedby", null, value);
                this.OnPropertyChanged("lk_activitypointer_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_activitypointer_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_activitypointer_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<ActivityPointer> lk_activitypointer_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<ActivityPointer>("lk_activitypointer_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_activitypointer_modifiedonbehalfby");
                this.SetRelatedEntities<ActivityPointer>("lk_activitypointer_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_activitypointer_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_annotationbase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_annotationbase_createdby")]
        public System.Collections.Generic.IEnumerable<Annotation> lk_annotationbase_createdby
        {
            get { return this.GetRelatedEntities<Annotation>("lk_annotationbase_createdby", null); }
            set
            {
                this.OnPropertyChanging("lk_annotationbase_createdby");
                this.SetRelatedEntities<Annotation>("lk_annotationbase_createdby", null, value);
                this.OnPropertyChanged("lk_annotationbase_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_annotationbase_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_annotationbase_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<Annotation> lk_annotationbase_createdonbehalfby
        {
            get { return this.GetRelatedEntities<Annotation>("lk_annotationbase_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_annotationbase_createdonbehalfby");
                this.SetRelatedEntities<Annotation>("lk_annotationbase_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_annotationbase_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_annotationbase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_annotationbase_modifiedby")]
        public System.Collections.Generic.IEnumerable<Annotation> lk_annotationbase_modifiedby
        {
            get { return this.GetRelatedEntities<Annotation>("lk_annotationbase_modifiedby", null); }
            set
            {
                this.OnPropertyChanging("lk_annotationbase_modifiedby");
                this.SetRelatedEntities<Annotation>("lk_annotationbase_modifiedby", null, value);
                this.OnPropertyChanged("lk_annotationbase_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_annotationbase_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_annotationbase_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<Annotation> lk_annotationbase_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<Annotation>("lk_annotationbase_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_annotationbase_modifiedonbehalfby");
                this.SetRelatedEntities<Annotation>("lk_annotationbase_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_annotationbase_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_annualfiscalcalendar_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_annualfiscalcalendar_createdby")]
        public System.Collections.Generic.IEnumerable<AnnualFiscalCalendar> lk_annualfiscalcalendar_createdby
        {
            get { return this.GetRelatedEntities<AnnualFiscalCalendar>("lk_annualfiscalcalendar_createdby", null); }
            set
            {
                this.OnPropertyChanging("lk_annualfiscalcalendar_createdby");
                this.SetRelatedEntities<AnnualFiscalCalendar>("lk_annualfiscalcalendar_createdby", null, value);
                this.OnPropertyChanged("lk_annualfiscalcalendar_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_annualfiscalcalendar_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_annualfiscalcalendar_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<AnnualFiscalCalendar> lk_annualfiscalcalendar_createdonbehalfby
        {
            get { return this.GetRelatedEntities<AnnualFiscalCalendar>("lk_annualfiscalcalendar_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_annualfiscalcalendar_createdonbehalfby");
                this.SetRelatedEntities<AnnualFiscalCalendar>("lk_annualfiscalcalendar_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_annualfiscalcalendar_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_annualfiscalcalendar_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_annualfiscalcalendar_modifiedby")]
        public System.Collections.Generic.IEnumerable<AnnualFiscalCalendar> lk_annualfiscalcalendar_modifiedby
        {
            get { return this.GetRelatedEntities<AnnualFiscalCalendar>("lk_annualfiscalcalendar_modifiedby", null); }
            set
            {
                this.OnPropertyChanging("lk_annualfiscalcalendar_modifiedby");
                this.SetRelatedEntities<AnnualFiscalCalendar>("lk_annualfiscalcalendar_modifiedby", null, value);
                this.OnPropertyChanged("lk_annualfiscalcalendar_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_annualfiscalcalendar_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_annualfiscalcalendar_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<AnnualFiscalCalendar> lk_annualfiscalcalendar_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<AnnualFiscalCalendar>("lk_annualfiscalcalendar_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_annualfiscalcalendar_modifiedonbehalfby");
                this.SetRelatedEntities<AnnualFiscalCalendar>("lk_annualfiscalcalendar_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_annualfiscalcalendar_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_annualfiscalcalendar_salespersonid
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_annualfiscalcalendar_salespersonid")]
        public System.Collections.Generic.IEnumerable<AnnualFiscalCalendar> lk_annualfiscalcalendar_salespersonid
        {
            get { return this.GetRelatedEntities<AnnualFiscalCalendar>("lk_annualfiscalcalendar_salespersonid", null); }
            set
            {
                this.OnPropertyChanging("lk_annualfiscalcalendar_salespersonid");
                this.SetRelatedEntities<AnnualFiscalCalendar>("lk_annualfiscalcalendar_salespersonid", null, value);
                this.OnPropertyChanged("lk_annualfiscalcalendar_salespersonid");
            }
        }

        /// <summary>
        /// 1:N lk_appointment_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_appointment_createdby")]
        public System.Collections.Generic.IEnumerable<Appointment> lk_appointment_createdby
        {
            get { return this.GetRelatedEntities<Appointment>("lk_appointment_createdby", null); }
            set
            {
                this.OnPropertyChanging("lk_appointment_createdby");
                this.SetRelatedEntities<Appointment>("lk_appointment_createdby", null, value);
                this.OnPropertyChanged("lk_appointment_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_appointment_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_appointment_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<Appointment> lk_appointment_createdonbehalfby
        {
            get { return this.GetRelatedEntities<Appointment>("lk_appointment_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_appointment_createdonbehalfby");
                this.SetRelatedEntities<Appointment>("lk_appointment_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_appointment_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_appointment_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_appointment_modifiedby")]
        public System.Collections.Generic.IEnumerable<Appointment> lk_appointment_modifiedby
        {
            get { return this.GetRelatedEntities<Appointment>("lk_appointment_modifiedby", null); }
            set
            {
                this.OnPropertyChanging("lk_appointment_modifiedby");
                this.SetRelatedEntities<Appointment>("lk_appointment_modifiedby", null, value);
                this.OnPropertyChanged("lk_appointment_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_appointment_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_appointment_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<Appointment> lk_appointment_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<Appointment>("lk_appointment_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_appointment_modifiedonbehalfby");
                this.SetRelatedEntities<Appointment>("lk_appointment_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_appointment_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_asyncoperation_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_asyncoperation_createdby")]
        public System.Collections.Generic.IEnumerable<AsyncOperation> lk_asyncoperation_createdby
        {
            get { return this.GetRelatedEntities<AsyncOperation>("lk_asyncoperation_createdby", null); }
            set
            {
                this.OnPropertyChanging("lk_asyncoperation_createdby");
                this.SetRelatedEntities<AsyncOperation>("lk_asyncoperation_createdby", null, value);
                this.OnPropertyChanged("lk_asyncoperation_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_asyncoperation_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_asyncoperation_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<AsyncOperation> lk_asyncoperation_createdonbehalfby
        {
            get { return this.GetRelatedEntities<AsyncOperation>("lk_asyncoperation_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_asyncoperation_createdonbehalfby");
                this.SetRelatedEntities<AsyncOperation>("lk_asyncoperation_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_asyncoperation_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_asyncoperation_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_asyncoperation_modifiedby")]
        public System.Collections.Generic.IEnumerable<AsyncOperation> lk_asyncoperation_modifiedby
        {
            get { return this.GetRelatedEntities<AsyncOperation>("lk_asyncoperation_modifiedby", null); }
            set
            {
                this.OnPropertyChanging("lk_asyncoperation_modifiedby");
                this.SetRelatedEntities<AsyncOperation>("lk_asyncoperation_modifiedby", null, value);
                this.OnPropertyChanged("lk_asyncoperation_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_asyncoperation_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_asyncoperation_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<AsyncOperation> lk_asyncoperation_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<AsyncOperation>("lk_asyncoperation_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_asyncoperation_modifiedonbehalfby");
                this.SetRelatedEntities<AsyncOperation>("lk_asyncoperation_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_asyncoperation_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_audit_callinguserid
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_audit_callinguserid")]
        public System.Collections.Generic.IEnumerable<Audit> lk_audit_callinguserid
        {
            get { return this.GetRelatedEntities<Audit>("lk_audit_callinguserid", null); }
            set
            {
                this.OnPropertyChanging("lk_audit_callinguserid");
                this.SetRelatedEntities<Audit>("lk_audit_callinguserid", null, value);
                this.OnPropertyChanged("lk_audit_callinguserid");
            }
        }

        /// <summary>
        /// 1:N lk_audit_userid
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_audit_userid")]
        public System.Collections.Generic.IEnumerable<Audit> lk_audit_userid
        {
            get { return this.GetRelatedEntities<Audit>("lk_audit_userid", null); }
            set
            {
                this.OnPropertyChanging("lk_audit_userid");
                this.SetRelatedEntities<Audit>("lk_audit_userid", null, value);
                this.OnPropertyChanged("lk_audit_userid");
            }
        }

        /// <summary>
        /// 1:N lk_bulkdeleteoperation_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_bulkdeleteoperation_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<BulkDeleteOperation> lk_bulkdeleteoperation_createdonbehalfby
        {
            get { return this.GetRelatedEntities<BulkDeleteOperation>("lk_bulkdeleteoperation_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_bulkdeleteoperation_createdonbehalfby");
                this.SetRelatedEntities<BulkDeleteOperation>("lk_bulkdeleteoperation_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_bulkdeleteoperation_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_bulkdeleteoperation_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_bulkdeleteoperation_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<BulkDeleteOperation> lk_bulkdeleteoperation_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<BulkDeleteOperation>("lk_bulkdeleteoperation_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_bulkdeleteoperation_modifiedonbehalfby");
                this.SetRelatedEntities<BulkDeleteOperation>("lk_bulkdeleteoperation_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_bulkdeleteoperation_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_bulkdeleteoperationbase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_bulkdeleteoperationbase_createdby")]
        public System.Collections.Generic.IEnumerable<BulkDeleteOperation> lk_bulkdeleteoperationbase_createdby
        {
            get { return this.GetRelatedEntities<BulkDeleteOperation>("lk_bulkdeleteoperationbase_createdby", null); }
            set
            {
                this.OnPropertyChanging("lk_bulkdeleteoperationbase_createdby");
                this.SetRelatedEntities<BulkDeleteOperation>("lk_bulkdeleteoperationbase_createdby", null, value);
                this.OnPropertyChanged("lk_bulkdeleteoperationbase_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_bulkdeleteoperationbase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_bulkdeleteoperationbase_modifiedby")]
        public System.Collections.Generic.IEnumerable<BulkDeleteOperation> lk_bulkdeleteoperationbase_modifiedby
        {
            get { return this.GetRelatedEntities<BulkDeleteOperation>("lk_bulkdeleteoperationbase_modifiedby", null); }
            set
            {
                this.OnPropertyChanging("lk_bulkdeleteoperationbase_modifiedby");
                this.SetRelatedEntities<BulkDeleteOperation>("lk_bulkdeleteoperationbase_modifiedby", null, value);
                this.OnPropertyChanged("lk_bulkdeleteoperationbase_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_BulkOperation_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_BulkOperation_createdby")]
        public System.Collections.Generic.IEnumerable<BulkOperation> lk_BulkOperation_createdby
        {
            get { return this.GetRelatedEntities<BulkOperation>("lk_BulkOperation_createdby", null); }
            set
            {
                this.OnPropertyChanging("lk_BulkOperation_createdby");
                this.SetRelatedEntities<BulkOperation>("lk_BulkOperation_createdby", null, value);
                this.OnPropertyChanged("lk_BulkOperation_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_BulkOperation_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_BulkOperation_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<BulkOperation> lk_BulkOperation_createdonbehalfby
        {
            get { return this.GetRelatedEntities<BulkOperation>("lk_BulkOperation_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_BulkOperation_createdonbehalfby");
                this.SetRelatedEntities<BulkOperation>("lk_BulkOperation_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_BulkOperation_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_BulkOperation_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_BulkOperation_modifiedby")]
        public System.Collections.Generic.IEnumerable<BulkOperation> lk_BulkOperation_modifiedby
        {
            get { return this.GetRelatedEntities<BulkOperation>("lk_BulkOperation_modifiedby", null); }
            set
            {
                this.OnPropertyChanging("lk_BulkOperation_modifiedby");
                this.SetRelatedEntities<BulkOperation>("lk_BulkOperation_modifiedby", null, value);
                this.OnPropertyChanged("lk_BulkOperation_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_BulkOperation_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_BulkOperation_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<BulkOperation> lk_BulkOperation_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<BulkOperation>("lk_BulkOperation_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_BulkOperation_modifiedonbehalfby");
                this.SetRelatedEntities<BulkOperation>("lk_BulkOperation_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_BulkOperation_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_businessunit_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_businessunit_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<BusinessUnit> lk_businessunit_createdonbehalfby
        {
            get { return this.GetRelatedEntities<BusinessUnit>("lk_businessunit_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_businessunit_createdonbehalfby");
                this.SetRelatedEntities<BusinessUnit>("lk_businessunit_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_businessunit_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_businessunit_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_businessunit_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<BusinessUnit> lk_businessunit_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<BusinessUnit>("lk_businessunit_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_businessunit_modifiedonbehalfby");
                this.SetRelatedEntities<BusinessUnit>("lk_businessunit_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_businessunit_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_businessunitbase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_businessunitbase_createdby")]
        public System.Collections.Generic.IEnumerable<BusinessUnit> lk_businessunitbase_createdby
        {
            get { return this.GetRelatedEntities<BusinessUnit>("lk_businessunitbase_createdby", null); }
            set
            {
                this.OnPropertyChanging("lk_businessunitbase_createdby");
                this.SetRelatedEntities<BusinessUnit>("lk_businessunitbase_createdby", null, value);
                this.OnPropertyChanged("lk_businessunitbase_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_businessunitbase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_businessunitbase_modifiedby")]
        public System.Collections.Generic.IEnumerable<BusinessUnit> lk_businessunitbase_modifiedby
        {
            get { return this.GetRelatedEntities<BusinessUnit>("lk_businessunitbase_modifiedby", null); }
            set
            {
                this.OnPropertyChanging("lk_businessunitbase_modifiedby");
                this.SetRelatedEntities<BusinessUnit>("lk_businessunitbase_modifiedby", null, value);
                this.OnPropertyChanged("lk_businessunitbase_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_businessunitnewsarticle_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_businessunitnewsarticle_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<BusinessUnitNewsArticle> lk_businessunitnewsarticle_createdonbehalfby
        {
            get { return this.GetRelatedEntities<BusinessUnitNewsArticle>("lk_businessunitnewsarticle_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_businessunitnewsarticle_createdonbehalfby");
                this.SetRelatedEntities<BusinessUnitNewsArticle>("lk_businessunitnewsarticle_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_businessunitnewsarticle_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_businessunitnewsarticle_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_businessunitnewsarticle_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<BusinessUnitNewsArticle> lk_businessunitnewsarticle_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<BusinessUnitNewsArticle>("lk_businessunitnewsarticle_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_businessunitnewsarticle_modifiedonbehalfby");
                this.SetRelatedEntities<BusinessUnitNewsArticle>("lk_businessunitnewsarticle_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_businessunitnewsarticle_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_businessunitnewsarticlebase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_businessunitnewsarticlebase_createdby")]
        public System.Collections.Generic.IEnumerable<BusinessUnitNewsArticle> lk_businessunitnewsarticlebase_createdby
        {
            get { return this.GetRelatedEntities<BusinessUnitNewsArticle>("lk_businessunitnewsarticlebase_createdby", null); }
            set
            {
                this.OnPropertyChanging("lk_businessunitnewsarticlebase_createdby");
                this.SetRelatedEntities<BusinessUnitNewsArticle>("lk_businessunitnewsarticlebase_createdby", null, value);
                this.OnPropertyChanged("lk_businessunitnewsarticlebase_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_businessunitnewsarticlebase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_businessunitnewsarticlebase_modifiedby")]
        public System.Collections.Generic.IEnumerable<BusinessUnitNewsArticle> lk_businessunitnewsarticlebase_modifiedby
        {
            get { return this.GetRelatedEntities<BusinessUnitNewsArticle>("lk_businessunitnewsarticlebase_modifiedby", null); }
            set
            {
                this.OnPropertyChanging("lk_businessunitnewsarticlebase_modifiedby");
                this.SetRelatedEntities<BusinessUnitNewsArticle>("lk_businessunitnewsarticlebase_modifiedby", null, value);
                this.OnPropertyChanged("lk_businessunitnewsarticlebase_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_calendar_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_calendar_createdby")]
        public System.Collections.Generic.IEnumerable<Calendar> lk_calendar_createdby
        {
            get { return this.GetRelatedEntities<Calendar>("lk_calendar_createdby", null); }
            set
            {
                this.OnPropertyChanging("lk_calendar_createdby");
                this.SetRelatedEntities<Calendar>("lk_calendar_createdby", null, value);
                this.OnPropertyChanged("lk_calendar_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_calendar_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_calendar_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<Calendar> lk_calendar_createdonbehalfby
        {
            get { return this.GetRelatedEntities<Calendar>("lk_calendar_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_calendar_createdonbehalfby");
                this.SetRelatedEntities<Calendar>("lk_calendar_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_calendar_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_calendar_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_calendar_modifiedby")]
        public System.Collections.Generic.IEnumerable<Calendar> lk_calendar_modifiedby
        {
            get { return this.GetRelatedEntities<Calendar>("lk_calendar_modifiedby", null); }
            set
            {
                this.OnPropertyChanging("lk_calendar_modifiedby");
                this.SetRelatedEntities<Calendar>("lk_calendar_modifiedby", null, value);
                this.OnPropertyChanged("lk_calendar_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_calendar_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_calendar_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<Calendar> lk_calendar_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<Calendar>("lk_calendar_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_calendar_modifiedonbehalfby");
                this.SetRelatedEntities<Calendar>("lk_calendar_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_calendar_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_campaign_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_campaign_createdby")]
        public System.Collections.Generic.IEnumerable<Campaign> lk_campaign_createdby
        {
            get { return this.GetRelatedEntities<Campaign>("lk_campaign_createdby", null); }
            set
            {
                this.OnPropertyChanging("lk_campaign_createdby");
                this.SetRelatedEntities<Campaign>("lk_campaign_createdby", null, value);
                this.OnPropertyChanged("lk_campaign_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_campaign_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_campaign_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<Campaign> lk_campaign_createdonbehalfby
        {
            get { return this.GetRelatedEntities<Campaign>("lk_campaign_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_campaign_createdonbehalfby");
                this.SetRelatedEntities<Campaign>("lk_campaign_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_campaign_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_campaign_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_campaign_modifiedby")]
        public System.Collections.Generic.IEnumerable<Campaign> lk_campaign_modifiedby
        {
            get { return this.GetRelatedEntities<Campaign>("lk_campaign_modifiedby", null); }
            set
            {
                this.OnPropertyChanging("lk_campaign_modifiedby");
                this.SetRelatedEntities<Campaign>("lk_campaign_modifiedby", null, value);
                this.OnPropertyChanged("lk_campaign_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_campaign_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_campaign_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<Campaign> lk_campaign_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<Campaign>("lk_campaign_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_campaign_modifiedonbehalfby");
                this.SetRelatedEntities<Campaign>("lk_campaign_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_campaign_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_campaignactivity_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_campaignactivity_createdby")]
        public System.Collections.Generic.IEnumerable<CampaignActivity> lk_campaignactivity_createdby
        {
            get { return this.GetRelatedEntities<CampaignActivity>("lk_campaignactivity_createdby", null); }
            set
            {
                this.OnPropertyChanging("lk_campaignactivity_createdby");
                this.SetRelatedEntities<CampaignActivity>("lk_campaignactivity_createdby", null, value);
                this.OnPropertyChanged("lk_campaignactivity_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_campaignactivity_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_campaignactivity_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<CampaignActivity> lk_campaignactivity_createdonbehalfby
        {
            get { return this.GetRelatedEntities<CampaignActivity>("lk_campaignactivity_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_campaignactivity_createdonbehalfby");
                this.SetRelatedEntities<CampaignActivity>("lk_campaignactivity_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_campaignactivity_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_campaignactivity_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_campaignactivity_modifiedby")]
        public System.Collections.Generic.IEnumerable<CampaignActivity> lk_campaignactivity_modifiedby
        {
            get { return this.GetRelatedEntities<CampaignActivity>("lk_campaignactivity_modifiedby", null); }
            set
            {
                this.OnPropertyChanging("lk_campaignactivity_modifiedby");
                this.SetRelatedEntities<CampaignActivity>("lk_campaignactivity_modifiedby", null, value);
                this.OnPropertyChanged("lk_campaignactivity_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_campaignactivity_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_campaignactivity_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<CampaignActivity> lk_campaignactivity_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<CampaignActivity>("lk_campaignactivity_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_campaignactivity_modifiedonbehalfby");
                this.SetRelatedEntities<CampaignActivity>("lk_campaignactivity_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_campaignactivity_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_campaignresponse_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_campaignresponse_createdby")]
        public System.Collections.Generic.IEnumerable<CampaignResponse> lk_campaignresponse_createdby
        {
            get { return this.GetRelatedEntities<CampaignResponse>("lk_campaignresponse_createdby", null); }
            set
            {
                this.OnPropertyChanging("lk_campaignresponse_createdby");
                this.SetRelatedEntities<CampaignResponse>("lk_campaignresponse_createdby", null, value);
                this.OnPropertyChanged("lk_campaignresponse_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_campaignresponse_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_campaignresponse_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<CampaignResponse> lk_campaignresponse_createdonbehalfby
        {
            get { return this.GetRelatedEntities<CampaignResponse>("lk_campaignresponse_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_campaignresponse_createdonbehalfby");
                this.SetRelatedEntities<CampaignResponse>("lk_campaignresponse_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_campaignresponse_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_campaignresponse_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_campaignresponse_modifiedby")]
        public System.Collections.Generic.IEnumerable<CampaignResponse> lk_campaignresponse_modifiedby
        {
            get { return this.GetRelatedEntities<CampaignResponse>("lk_campaignresponse_modifiedby", null); }
            set
            {
                this.OnPropertyChanging("lk_campaignresponse_modifiedby");
                this.SetRelatedEntities<CampaignResponse>("lk_campaignresponse_modifiedby", null, value);
                this.OnPropertyChanged("lk_campaignresponse_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_campaignresponse_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_campaignresponse_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<CampaignResponse> lk_campaignresponse_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<CampaignResponse>("lk_campaignresponse_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_campaignresponse_modifiedonbehalfby");
                this.SetRelatedEntities<CampaignResponse>("lk_campaignresponse_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_campaignresponse_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_columnmapping_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_columnmapping_createdby")]
        public System.Collections.Generic.IEnumerable<ColumnMapping> lk_columnmapping_createdby
        {
            get { return this.GetRelatedEntities<ColumnMapping>("lk_columnmapping_createdby", null); }
            set
            {
                this.OnPropertyChanging("lk_columnmapping_createdby");
                this.SetRelatedEntities<ColumnMapping>("lk_columnmapping_createdby", null, value);
                this.OnPropertyChanged("lk_columnmapping_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_columnmapping_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_columnmapping_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<ColumnMapping> lk_columnmapping_createdonbehalfby
        {
            get { return this.GetRelatedEntities<ColumnMapping>("lk_columnmapping_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_columnmapping_createdonbehalfby");
                this.SetRelatedEntities<ColumnMapping>("lk_columnmapping_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_columnmapping_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_columnmapping_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_columnmapping_modifiedby")]
        public System.Collections.Generic.IEnumerable<ColumnMapping> lk_columnmapping_modifiedby
        {
            get { return this.GetRelatedEntities<ColumnMapping>("lk_columnmapping_modifiedby", null); }
            set
            {
                this.OnPropertyChanging("lk_columnmapping_modifiedby");
                this.SetRelatedEntities<ColumnMapping>("lk_columnmapping_modifiedby", null, value);
                this.OnPropertyChanged("lk_columnmapping_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_columnmapping_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_columnmapping_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<ColumnMapping> lk_columnmapping_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<ColumnMapping>("lk_columnmapping_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_columnmapping_modifiedonbehalfby");
                this.SetRelatedEntities<ColumnMapping>("lk_columnmapping_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_columnmapping_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_competitor_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_competitor_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<Competitor> lk_competitor_createdonbehalfby
        {
            get { return this.GetRelatedEntities<Competitor>("lk_competitor_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_competitor_createdonbehalfby");
                this.SetRelatedEntities<Competitor>("lk_competitor_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_competitor_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_competitor_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_competitor_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<Competitor> lk_competitor_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<Competitor>("lk_competitor_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_competitor_modifiedonbehalfby");
                this.SetRelatedEntities<Competitor>("lk_competitor_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_competitor_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_competitorbase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_competitorbase_createdby")]
        public System.Collections.Generic.IEnumerable<Competitor> lk_competitorbase_createdby
        {
            get { return this.GetRelatedEntities<Competitor>("lk_competitorbase_createdby", null); }
            set
            {
                this.OnPropertyChanging("lk_competitorbase_createdby");
                this.SetRelatedEntities<Competitor>("lk_competitorbase_createdby", null, value);
                this.OnPropertyChanged("lk_competitorbase_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_competitorbase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_competitorbase_modifiedby")]
        public System.Collections.Generic.IEnumerable<Competitor> lk_competitorbase_modifiedby
        {
            get { return this.GetRelatedEntities<Competitor>("lk_competitorbase_modifiedby", null); }
            set
            {
                this.OnPropertyChanging("lk_competitorbase_modifiedby");
                this.SetRelatedEntities<Competitor>("lk_competitorbase_modifiedby", null, value);
                this.OnPropertyChanged("lk_competitorbase_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_connectionbase_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_connectionbase_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<Connection> lk_connectionbase_createdonbehalfby
        {
            get { return this.GetRelatedEntities<Connection>("lk_connectionbase_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_connectionbase_createdonbehalfby");
                this.SetRelatedEntities<Connection>("lk_connectionbase_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_connectionbase_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_connectionbase_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_connectionbase_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<Connection> lk_connectionbase_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<Connection>("lk_connectionbase_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_connectionbase_modifiedonbehalfby");
                this.SetRelatedEntities<Connection>("lk_connectionbase_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_connectionbase_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_connectionrolebase_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_connectionrolebase_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<ConnectionRole> lk_connectionrolebase_createdonbehalfby
        {
            get { return this.GetRelatedEntities<ConnectionRole>("lk_connectionrolebase_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_connectionrolebase_createdonbehalfby");
                this.SetRelatedEntities<ConnectionRole>("lk_connectionrolebase_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_connectionrolebase_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_connectionrolebase_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_connectionrolebase_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<ConnectionRole> lk_connectionrolebase_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<ConnectionRole>("lk_connectionrolebase_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_connectionrolebase_modifiedonbehalfby");
                this.SetRelatedEntities<ConnectionRole>("lk_connectionrolebase_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_connectionrolebase_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_constraintbasedgroup_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_constraintbasedgroup_createdby")]
        public System.Collections.Generic.IEnumerable<ConstraintBasedGroup> lk_constraintbasedgroup_createdby
        {
            get { return this.GetRelatedEntities<ConstraintBasedGroup>("lk_constraintbasedgroup_createdby", null); }
            set
            {
                this.OnPropertyChanging("lk_constraintbasedgroup_createdby");
                this.SetRelatedEntities<ConstraintBasedGroup>("lk_constraintbasedgroup_createdby", null, value);
                this.OnPropertyChanged("lk_constraintbasedgroup_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_constraintbasedgroup_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_constraintbasedgroup_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<ConstraintBasedGroup> lk_constraintbasedgroup_createdonbehalfby
        {
            get { return this.GetRelatedEntities<ConstraintBasedGroup>("lk_constraintbasedgroup_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_constraintbasedgroup_createdonbehalfby");
                this.SetRelatedEntities<ConstraintBasedGroup>("lk_constraintbasedgroup_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_constraintbasedgroup_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_constraintbasedgroup_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_constraintbasedgroup_modifiedby")]
        public System.Collections.Generic.IEnumerable<ConstraintBasedGroup> lk_constraintbasedgroup_modifiedby
        {
            get { return this.GetRelatedEntities<ConstraintBasedGroup>("lk_constraintbasedgroup_modifiedby", null); }
            set
            {
                this.OnPropertyChanging("lk_constraintbasedgroup_modifiedby");
                this.SetRelatedEntities<ConstraintBasedGroup>("lk_constraintbasedgroup_modifiedby", null, value);
                this.OnPropertyChanged("lk_constraintbasedgroup_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_constraintbasedgroup_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_constraintbasedgroup_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<ConstraintBasedGroup> lk_constraintbasedgroup_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<ConstraintBasedGroup>("lk_constraintbasedgroup_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_constraintbasedgroup_modifiedonbehalfby");
                this.SetRelatedEntities<ConstraintBasedGroup>("lk_constraintbasedgroup_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_constraintbasedgroup_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_contact_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_contact_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<Contact> lk_contact_createdonbehalfby
        {
            get { return this.GetRelatedEntities<Contact>("lk_contact_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_contact_createdonbehalfby");
                this.SetRelatedEntities<Contact>("lk_contact_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_contact_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_contact_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_contact_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<Contact> lk_contact_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<Contact>("lk_contact_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_contact_modifiedonbehalfby");
                this.SetRelatedEntities<Contact>("lk_contact_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_contact_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_contactbase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_contactbase_createdby")]
        public System.Collections.Generic.IEnumerable<Contact> lk_contactbase_createdby
        {
            get { return this.GetRelatedEntities<Contact>("lk_contactbase_createdby", null); }
            set
            {
                this.OnPropertyChanging("lk_contactbase_createdby");
                this.SetRelatedEntities<Contact>("lk_contactbase_createdby", null, value);
                this.OnPropertyChanged("lk_contactbase_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_contactbase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_contactbase_modifiedby")]
        public System.Collections.Generic.IEnumerable<Contact> lk_contactbase_modifiedby
        {
            get { return this.GetRelatedEntities<Contact>("lk_contactbase_modifiedby", null); }
            set
            {
                this.OnPropertyChanging("lk_contactbase_modifiedby");
                this.SetRelatedEntities<Contact>("lk_contactbase_modifiedby", null, value);
                this.OnPropertyChanged("lk_contactbase_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_contract_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_contract_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<Contract> lk_contract_createdonbehalfby
        {
            get { return this.GetRelatedEntities<Contract>("lk_contract_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_contract_createdonbehalfby");
                this.SetRelatedEntities<Contract>("lk_contract_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_contract_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_contract_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_contract_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<Contract> lk_contract_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<Contract>("lk_contract_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_contract_modifiedonbehalfby");
                this.SetRelatedEntities<Contract>("lk_contract_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_contract_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_contractbase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_contractbase_createdby")]
        public System.Collections.Generic.IEnumerable<Contract> lk_contractbase_createdby
        {
            get { return this.GetRelatedEntities<Contract>("lk_contractbase_createdby", null); }
            set
            {
                this.OnPropertyChanging("lk_contractbase_createdby");
                this.SetRelatedEntities<Contract>("lk_contractbase_createdby", null, value);
                this.OnPropertyChanged("lk_contractbase_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_contractbase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_contractbase_modifiedby")]
        public System.Collections.Generic.IEnumerable<Contract> lk_contractbase_modifiedby
        {
            get { return this.GetRelatedEntities<Contract>("lk_contractbase_modifiedby", null); }
            set
            {
                this.OnPropertyChanging("lk_contractbase_modifiedby");
                this.SetRelatedEntities<Contract>("lk_contractbase_modifiedby", null, value);
                this.OnPropertyChanged("lk_contractbase_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_contractdetail_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_contractdetail_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<ContractDetail> lk_contractdetail_createdonbehalfby
        {
            get { return this.GetRelatedEntities<ContractDetail>("lk_contractdetail_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_contractdetail_createdonbehalfby");
                this.SetRelatedEntities<ContractDetail>("lk_contractdetail_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_contractdetail_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_contractdetail_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_contractdetail_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<ContractDetail> lk_contractdetail_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<ContractDetail>("lk_contractdetail_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_contractdetail_modifiedonbehalfby");
                this.SetRelatedEntities<ContractDetail>("lk_contractdetail_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_contractdetail_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_contractdetailbase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_contractdetailbase_createdby")]
        public System.Collections.Generic.IEnumerable<ContractDetail> lk_contractdetailbase_createdby
        {
            get { return this.GetRelatedEntities<ContractDetail>("lk_contractdetailbase_createdby", null); }
            set
            {
                this.OnPropertyChanging("lk_contractdetailbase_createdby");
                this.SetRelatedEntities<ContractDetail>("lk_contractdetailbase_createdby", null, value);
                this.OnPropertyChanged("lk_contractdetailbase_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_contractdetailbase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_contractdetailbase_modifiedby")]
        public System.Collections.Generic.IEnumerable<ContractDetail> lk_contractdetailbase_modifiedby
        {
            get { return this.GetRelatedEntities<ContractDetail>("lk_contractdetailbase_modifiedby", null); }
            set
            {
                this.OnPropertyChanging("lk_contractdetailbase_modifiedby");
                this.SetRelatedEntities<ContractDetail>("lk_contractdetailbase_modifiedby", null, value);
                this.OnPropertyChanged("lk_contractdetailbase_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_contracttemplate_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_contracttemplate_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<ContractTemplate> lk_contracttemplate_createdonbehalfby
        {
            get { return this.GetRelatedEntities<ContractTemplate>("lk_contracttemplate_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_contracttemplate_createdonbehalfby");
                this.SetRelatedEntities<ContractTemplate>("lk_contracttemplate_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_contracttemplate_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_contracttemplate_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_contracttemplate_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<ContractTemplate> lk_contracttemplate_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<ContractTemplate>("lk_contracttemplate_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_contracttemplate_modifiedonbehalfby");
                this.SetRelatedEntities<ContractTemplate>("lk_contracttemplate_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_contracttemplate_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_contracttemplatebase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_contracttemplatebase_createdby")]
        public System.Collections.Generic.IEnumerable<ContractTemplate> lk_contracttemplatebase_createdby
        {
            get { return this.GetRelatedEntities<ContractTemplate>("lk_contracttemplatebase_createdby", null); }
            set
            {
                this.OnPropertyChanging("lk_contracttemplatebase_createdby");
                this.SetRelatedEntities<ContractTemplate>("lk_contracttemplatebase_createdby", null, value);
                this.OnPropertyChanged("lk_contracttemplatebase_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_contracttemplatebase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_contracttemplatebase_modifiedby")]
        public System.Collections.Generic.IEnumerable<ContractTemplate> lk_contracttemplatebase_modifiedby
        {
            get { return this.GetRelatedEntities<ContractTemplate>("lk_contracttemplatebase_modifiedby", null); }
            set
            {
                this.OnPropertyChanging("lk_contracttemplatebase_modifiedby");
                this.SetRelatedEntities<ContractTemplate>("lk_contracttemplatebase_modifiedby", null, value);
                this.OnPropertyChanged("lk_contracttemplatebase_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_convertrule_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_convertrule_createdby")]
        public System.Collections.Generic.IEnumerable<ConvertRule> lk_convertrule_createdby
        {
            get { return this.GetRelatedEntities<ConvertRule>("lk_convertrule_createdby", null); }
            set
            {
                this.OnPropertyChanging("lk_convertrule_createdby");
                this.SetRelatedEntities<ConvertRule>("lk_convertrule_createdby", null, value);
                this.OnPropertyChanged("lk_convertrule_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_ConvertRule_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ConvertRule_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<ConvertRule> lk_ConvertRule_createdonbehalfby
        {
            get { return this.GetRelatedEntities<ConvertRule>("lk_ConvertRule_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_ConvertRule_createdonbehalfby");
                this.SetRelatedEntities<ConvertRule>("lk_ConvertRule_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_ConvertRule_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_ConvertRule_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ConvertRule_modifiedby")]
        public System.Collections.Generic.IEnumerable<ConvertRule> lk_ConvertRule_modifiedby
        {
            get { return this.GetRelatedEntities<ConvertRule>("lk_ConvertRule_modifiedby", null); }
            set
            {
                this.OnPropertyChanging("lk_ConvertRule_modifiedby");
                this.SetRelatedEntities<ConvertRule>("lk_ConvertRule_modifiedby", null, value);
                this.OnPropertyChanged("lk_ConvertRule_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_ConvertRule_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ConvertRule_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<ConvertRule> lk_ConvertRule_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<ConvertRule>("lk_ConvertRule_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_ConvertRule_modifiedonbehalfby");
                this.SetRelatedEntities<ConvertRule>("lk_ConvertRule_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_ConvertRule_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_convertruleitembase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_convertruleitembase_createdby")]
        public System.Collections.Generic.IEnumerable<ConvertRuleItem> lk_convertruleitembase_createdby
        {
            get { return this.GetRelatedEntities<ConvertRuleItem>("lk_convertruleitembase_createdby", null); }
            set
            {
                this.OnPropertyChanging("lk_convertruleitembase_createdby");
                this.SetRelatedEntities<ConvertRuleItem>("lk_convertruleitembase_createdby", null, value);
                this.OnPropertyChanged("lk_convertruleitembase_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_convertruleitembase_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_convertruleitembase_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<ConvertRuleItem> lk_convertruleitembase_createdonbehalfby
        {
            get { return this.GetRelatedEntities<ConvertRuleItem>("lk_convertruleitembase_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_convertruleitembase_createdonbehalfby");
                this.SetRelatedEntities<ConvertRuleItem>("lk_convertruleitembase_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_convertruleitembase_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_convertruleitembase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_convertruleitembase_modifiedby")]
        public System.Collections.Generic.IEnumerable<ConvertRuleItem> lk_convertruleitembase_modifiedby
        {
            get { return this.GetRelatedEntities<ConvertRuleItem>("lk_convertruleitembase_modifiedby", null); }
            set
            {
                this.OnPropertyChanging("lk_convertruleitembase_modifiedby");
                this.SetRelatedEntities<ConvertRuleItem>("lk_convertruleitembase_modifiedby", null, value);
                this.OnPropertyChanged("lk_convertruleitembase_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_convertruleitembase_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_convertruleitembase_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<ConvertRuleItem> lk_convertruleitembase_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<ConvertRuleItem>("lk_convertruleitembase_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_convertruleitembase_modifiedonbehalfby");
                this.SetRelatedEntities<ConvertRuleItem>("lk_convertruleitembase_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_convertruleitembase_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_customeraddress_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_customeraddress_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<CustomerAddress> lk_customeraddress_createdonbehalfby
        {
            get { return this.GetRelatedEntities<CustomerAddress>("lk_customeraddress_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_customeraddress_createdonbehalfby");
                this.SetRelatedEntities<CustomerAddress>("lk_customeraddress_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_customeraddress_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_customeraddress_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_customeraddress_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<CustomerAddress> lk_customeraddress_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<CustomerAddress>("lk_customeraddress_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_customeraddress_modifiedonbehalfby");
                this.SetRelatedEntities<CustomerAddress>("lk_customeraddress_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_customeraddress_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_customeraddressbase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_customeraddressbase_createdby")]
        public System.Collections.Generic.IEnumerable<CustomerAddress> lk_customeraddressbase_createdby
        {
            get { return this.GetRelatedEntities<CustomerAddress>("lk_customeraddressbase_createdby", null); }
            set
            {
                this.OnPropertyChanging("lk_customeraddressbase_createdby");
                this.SetRelatedEntities<CustomerAddress>("lk_customeraddressbase_createdby", null, value);
                this.OnPropertyChanged("lk_customeraddressbase_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_customeraddressbase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_customeraddressbase_modifiedby")]
        public System.Collections.Generic.IEnumerable<CustomerAddress> lk_customeraddressbase_modifiedby
        {
            get { return this.GetRelatedEntities<CustomerAddress>("lk_customeraddressbase_modifiedby", null); }
            set
            {
                this.OnPropertyChanging("lk_customeraddressbase_modifiedby");
                this.SetRelatedEntities<CustomerAddress>("lk_customeraddressbase_modifiedby", null, value);
                this.OnPropertyChanged("lk_customeraddressbase_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_customeropportunityrole_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_customeropportunityrole_createdby")]
        public System.Collections.Generic.IEnumerable<CustomerOpportunityRole> lk_customeropportunityrole_createdby
        {
            get { return this.GetRelatedEntities<CustomerOpportunityRole>("lk_customeropportunityrole_createdby", null); }
            set
            {
                this.OnPropertyChanging("lk_customeropportunityrole_createdby");
                this.SetRelatedEntities<CustomerOpportunityRole>("lk_customeropportunityrole_createdby", null, value);
                this.OnPropertyChanged("lk_customeropportunityrole_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_customeropportunityrole_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_customeropportunityrole_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<CustomerOpportunityRole> lk_customeropportunityrole_createdonbehalfby
        {
            get { return this.GetRelatedEntities<CustomerOpportunityRole>("lk_customeropportunityrole_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_customeropportunityrole_createdonbehalfby");
                this.SetRelatedEntities<CustomerOpportunityRole>("lk_customeropportunityrole_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_customeropportunityrole_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_customeropportunityrole_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_customeropportunityrole_modifiedby")]
        public System.Collections.Generic.IEnumerable<CustomerOpportunityRole> lk_customeropportunityrole_modifiedby
        {
            get { return this.GetRelatedEntities<CustomerOpportunityRole>("lk_customeropportunityrole_modifiedby", null); }
            set
            {
                this.OnPropertyChanging("lk_customeropportunityrole_modifiedby");
                this.SetRelatedEntities<CustomerOpportunityRole>("lk_customeropportunityrole_modifiedby", null, value);
                this.OnPropertyChanged("lk_customeropportunityrole_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_customeropportunityrole_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_customeropportunityrole_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<CustomerOpportunityRole> lk_customeropportunityrole_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<CustomerOpportunityRole>("lk_customeropportunityrole_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_customeropportunityrole_modifiedonbehalfby");
                this.SetRelatedEntities<CustomerOpportunityRole>("lk_customeropportunityrole_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_customeropportunityrole_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_discount_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_discount_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<Discount> lk_discount_createdonbehalfby
        {
            get { return this.GetRelatedEntities<Discount>("lk_discount_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_discount_createdonbehalfby");
                this.SetRelatedEntities<Discount>("lk_discount_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_discount_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_discount_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_discount_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<Discount> lk_discount_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<Discount>("lk_discount_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_discount_modifiedonbehalfby");
                this.SetRelatedEntities<Discount>("lk_discount_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_discount_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_discountbase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_discountbase_createdby")]
        public System.Collections.Generic.IEnumerable<Discount> lk_discountbase_createdby
        {
            get { return this.GetRelatedEntities<Discount>("lk_discountbase_createdby", null); }
            set
            {
                this.OnPropertyChanging("lk_discountbase_createdby");
                this.SetRelatedEntities<Discount>("lk_discountbase_createdby", null, value);
                this.OnPropertyChanged("lk_discountbase_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_discountbase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_discountbase_modifiedby")]
        public System.Collections.Generic.IEnumerable<Discount> lk_discountbase_modifiedby
        {
            get { return this.GetRelatedEntities<Discount>("lk_discountbase_modifiedby", null); }
            set
            {
                this.OnPropertyChanging("lk_discountbase_modifiedby");
                this.SetRelatedEntities<Discount>("lk_discountbase_modifiedby", null, value);
                this.OnPropertyChanged("lk_discountbase_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_discounttype_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_discounttype_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<DiscountType> lk_discounttype_createdonbehalfby
        {
            get { return this.GetRelatedEntities<DiscountType>("lk_discounttype_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_discounttype_createdonbehalfby");
                this.SetRelatedEntities<DiscountType>("lk_discounttype_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_discounttype_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_discounttype_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_discounttype_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<DiscountType> lk_discounttype_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<DiscountType>("lk_discounttype_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_discounttype_modifiedonbehalfby");
                this.SetRelatedEntities<DiscountType>("lk_discounttype_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_discounttype_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_discounttypebase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_discounttypebase_createdby")]
        public System.Collections.Generic.IEnumerable<DiscountType> lk_discounttypebase_createdby
        {
            get { return this.GetRelatedEntities<DiscountType>("lk_discounttypebase_createdby", null); }
            set
            {
                this.OnPropertyChanging("lk_discounttypebase_createdby");
                this.SetRelatedEntities<DiscountType>("lk_discounttypebase_createdby", null, value);
                this.OnPropertyChanged("lk_discounttypebase_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_discounttypebase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_discounttypebase_modifiedby")]
        public System.Collections.Generic.IEnumerable<DiscountType> lk_discounttypebase_modifiedby
        {
            get { return this.GetRelatedEntities<DiscountType>("lk_discounttypebase_modifiedby", null); }
            set
            {
                this.OnPropertyChanging("lk_discounttypebase_modifiedby");
                this.SetRelatedEntities<DiscountType>("lk_discounttypebase_modifiedby", null, value);
                this.OnPropertyChanged("lk_discounttypebase_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_DisplayStringbase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_DisplayStringbase_createdby")]
        public System.Collections.Generic.IEnumerable<DisplayString> lk_DisplayStringbase_createdby
        {
            get { return this.GetRelatedEntities<DisplayString>("lk_DisplayStringbase_createdby", null); }
            set
            {
                this.OnPropertyChanging("lk_DisplayStringbase_createdby");
                this.SetRelatedEntities<DisplayString>("lk_DisplayStringbase_createdby", null, value);
                this.OnPropertyChanged("lk_DisplayStringbase_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_DisplayStringbase_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_DisplayStringbase_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<DisplayString> lk_DisplayStringbase_createdonbehalfby
        {
            get { return this.GetRelatedEntities<DisplayString>("lk_DisplayStringbase_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_DisplayStringbase_createdonbehalfby");
                this.SetRelatedEntities<DisplayString>("lk_DisplayStringbase_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_DisplayStringbase_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_DisplayStringbase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_DisplayStringbase_modifiedby")]
        public System.Collections.Generic.IEnumerable<DisplayString> lk_DisplayStringbase_modifiedby
        {
            get { return this.GetRelatedEntities<DisplayString>("lk_DisplayStringbase_modifiedby", null); }
            set
            {
                this.OnPropertyChanging("lk_DisplayStringbase_modifiedby");
                this.SetRelatedEntities<DisplayString>("lk_DisplayStringbase_modifiedby", null, value);
                this.OnPropertyChanged("lk_DisplayStringbase_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_DisplayStringbase_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_DisplayStringbase_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<DisplayString> lk_DisplayStringbase_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<DisplayString>("lk_DisplayStringbase_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_DisplayStringbase_modifiedonbehalfby");
                this.SetRelatedEntities<DisplayString>("lk_DisplayStringbase_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_DisplayStringbase_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_duplicaterule_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_duplicaterule_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<DuplicateRule> lk_duplicaterule_createdonbehalfby
        {
            get { return this.GetRelatedEntities<DuplicateRule>("lk_duplicaterule_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_duplicaterule_createdonbehalfby");
                this.SetRelatedEntities<DuplicateRule>("lk_duplicaterule_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_duplicaterule_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_duplicaterule_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_duplicaterule_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<DuplicateRule> lk_duplicaterule_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<DuplicateRule>("lk_duplicaterule_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_duplicaterule_modifiedonbehalfby");
                this.SetRelatedEntities<DuplicateRule>("lk_duplicaterule_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_duplicaterule_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_duplicaterulebase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_duplicaterulebase_createdby")]
        public System.Collections.Generic.IEnumerable<DuplicateRule> lk_duplicaterulebase_createdby
        {
            get { return this.GetRelatedEntities<DuplicateRule>("lk_duplicaterulebase_createdby", null); }
            set
            {
                this.OnPropertyChanging("lk_duplicaterulebase_createdby");
                this.SetRelatedEntities<DuplicateRule>("lk_duplicaterulebase_createdby", null, value);
                this.OnPropertyChanged("lk_duplicaterulebase_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_duplicaterulebase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_duplicaterulebase_modifiedby")]
        public System.Collections.Generic.IEnumerable<DuplicateRule> lk_duplicaterulebase_modifiedby
        {
            get { return this.GetRelatedEntities<DuplicateRule>("lk_duplicaterulebase_modifiedby", null); }
            set
            {
                this.OnPropertyChanging("lk_duplicaterulebase_modifiedby");
                this.SetRelatedEntities<DuplicateRule>("lk_duplicaterulebase_modifiedby", null, value);
                this.OnPropertyChanged("lk_duplicaterulebase_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_duplicaterulecondition_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_duplicaterulecondition_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<DuplicateRuleCondition> lk_duplicaterulecondition_createdonbehalfby
        {
            get { return this.GetRelatedEntities<DuplicateRuleCondition>("lk_duplicaterulecondition_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_duplicaterulecondition_createdonbehalfby");
                this.SetRelatedEntities<DuplicateRuleCondition>("lk_duplicaterulecondition_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_duplicaterulecondition_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_duplicaterulecondition_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_duplicaterulecondition_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<DuplicateRuleCondition> lk_duplicaterulecondition_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<DuplicateRuleCondition>("lk_duplicaterulecondition_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_duplicaterulecondition_modifiedonbehalfby");
                this.SetRelatedEntities<DuplicateRuleCondition>("lk_duplicaterulecondition_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_duplicaterulecondition_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_duplicateruleconditionbase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_duplicateruleconditionbase_createdby")]
        public System.Collections.Generic.IEnumerable<DuplicateRuleCondition> lk_duplicateruleconditionbase_createdby
        {
            get { return this.GetRelatedEntities<DuplicateRuleCondition>("lk_duplicateruleconditionbase_createdby", null); }
            set
            {
                this.OnPropertyChanging("lk_duplicateruleconditionbase_createdby");
                this.SetRelatedEntities<DuplicateRuleCondition>("lk_duplicateruleconditionbase_createdby", null, value);
                this.OnPropertyChanged("lk_duplicateruleconditionbase_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_duplicateruleconditionbase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_duplicateruleconditionbase_modifiedby")]
        public System.Collections.Generic.IEnumerable<DuplicateRuleCondition> lk_duplicateruleconditionbase_modifiedby
        {
            get { return this.GetRelatedEntities<DuplicateRuleCondition>("lk_duplicateruleconditionbase_modifiedby", null); }
            set
            {
                this.OnPropertyChanging("lk_duplicateruleconditionbase_modifiedby");
                this.SetRelatedEntities<DuplicateRuleCondition>("lk_duplicateruleconditionbase_modifiedby", null, value);
                this.OnPropertyChanged("lk_duplicateruleconditionbase_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_DynamicProperty_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_DynamicProperty_createdby")]
        public System.Collections.Generic.IEnumerable<DynamicProperty> lk_DynamicProperty_createdby
        {
            get { return this.GetRelatedEntities<DynamicProperty>("lk_DynamicProperty_createdby", null); }
            set
            {
                this.OnPropertyChanging("lk_DynamicProperty_createdby");
                this.SetRelatedEntities<DynamicProperty>("lk_DynamicProperty_createdby", null, value);
                this.OnPropertyChanged("lk_DynamicProperty_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_DynamicProperty_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_DynamicProperty_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<DynamicProperty> lk_DynamicProperty_createdonbehalfby
        {
            get { return this.GetRelatedEntities<DynamicProperty>("lk_DynamicProperty_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_DynamicProperty_createdonbehalfby");
                this.SetRelatedEntities<DynamicProperty>("lk_DynamicProperty_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_DynamicProperty_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_DynamicProperty_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_DynamicProperty_modifiedby")]
        public System.Collections.Generic.IEnumerable<DynamicProperty> lk_DynamicProperty_modifiedby
        {
            get { return this.GetRelatedEntities<DynamicProperty>("lk_DynamicProperty_modifiedby", null); }
            set
            {
                this.OnPropertyChanging("lk_DynamicProperty_modifiedby");
                this.SetRelatedEntities<DynamicProperty>("lk_DynamicProperty_modifiedby", null, value);
                this.OnPropertyChanged("lk_DynamicProperty_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_DynamicProperty_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_DynamicProperty_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<DynamicProperty> lk_DynamicProperty_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<DynamicProperty>("lk_DynamicProperty_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_DynamicProperty_modifiedonbehalfby");
                this.SetRelatedEntities<DynamicProperty>("lk_DynamicProperty_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_DynamicProperty_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_DynamicPropertyAssociationattribute_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_DynamicPropertyAssociationattribute_createdby")]
        public System.Collections.Generic.IEnumerable<DynamicPropertyAssociation> lk_DynamicPropertyAssociationattribute_createdby
        {
            get { return this.GetRelatedEntities<DynamicPropertyAssociation>("lk_DynamicPropertyAssociationattribute_createdby", null); }
            set
            {
                this.OnPropertyChanging("lk_DynamicPropertyAssociationattribute_createdby");
                this.SetRelatedEntities<DynamicPropertyAssociation>("lk_DynamicPropertyAssociationattribute_createdby", null, value);
                this.OnPropertyChanged("lk_DynamicPropertyAssociationattribute_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_DynamicPropertyAssociationattribute_CreatedOnBehalfBy
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_DynamicPropertyAssociationattribute_CreatedOnBehalfBy")]
        public System.Collections.Generic.IEnumerable<DynamicPropertyAssociation> lk_DynamicPropertyAssociationattribute_CreatedOnBehalfBy
        {
            get { return this.GetRelatedEntities<DynamicPropertyAssociation>("lk_DynamicPropertyAssociationattribute_CreatedOnBehalfBy", null); }
            set
            {
                this.OnPropertyChanging("lk_DynamicPropertyAssociationattribute_CreatedOnBehalfBy");
                this.SetRelatedEntities<DynamicPropertyAssociation>("lk_DynamicPropertyAssociationattribute_CreatedOnBehalfBy", null, value);
                this.OnPropertyChanged("lk_DynamicPropertyAssociationattribute_CreatedOnBehalfBy");
            }
        }

        /// <summary>
        /// 1:N lk_DynamicPropertyAssociationattribute_ModifiedBy
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_DynamicPropertyAssociationattribute_ModifiedBy")]
        public System.Collections.Generic.IEnumerable<DynamicPropertyAssociation> lk_DynamicPropertyAssociationattribute_ModifiedBy
        {
            get { return this.GetRelatedEntities<DynamicPropertyAssociation>("lk_DynamicPropertyAssociationattribute_ModifiedBy", null); }
            set
            {
                this.OnPropertyChanging("lk_DynamicPropertyAssociationattribute_ModifiedBy");
                this.SetRelatedEntities<DynamicPropertyAssociation>("lk_DynamicPropertyAssociationattribute_ModifiedBy", null, value);
                this.OnPropertyChanged("lk_DynamicPropertyAssociationattribute_ModifiedBy");
            }
        }

        /// <summary>
        /// 1:N lk_DynamicPropertyAssociationattribute_ModifiedOnBehalfBy
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_DynamicPropertyAssociationattribute_ModifiedOnBehalfBy")]
        public System.Collections.Generic.IEnumerable<DynamicPropertyAssociation> lk_DynamicPropertyAssociationattribute_ModifiedOnBehalfBy
        {
            get { return this.GetRelatedEntities<DynamicPropertyAssociation>("lk_DynamicPropertyAssociationattribute_ModifiedOnBehalfBy", null); }
            set
            {
                this.OnPropertyChanging("lk_DynamicPropertyAssociationattribute_ModifiedOnBehalfBy");
                this.SetRelatedEntities<DynamicPropertyAssociation>("lk_DynamicPropertyAssociationattribute_ModifiedOnBehalfBy", null, value);
                this.OnPropertyChanged("lk_DynamicPropertyAssociationattribute_ModifiedOnBehalfBy");
            }
        }

        /// <summary>
        /// 1:N lk_Dynamicpropertyinsatanceattribute_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_Dynamicpropertyinsatanceattribute_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<DynamicPropertyInstance> lk_Dynamicpropertyinsatanceattribute_createdonbehalfby
        {
            get { return this.GetRelatedEntities<DynamicPropertyInstance>("lk_Dynamicpropertyinsatanceattribute_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_Dynamicpropertyinsatanceattribute_createdonbehalfby");
                this.SetRelatedEntities<DynamicPropertyInstance>("lk_Dynamicpropertyinsatanceattribute_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_Dynamicpropertyinsatanceattribute_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_Dynamicpropertyinsatanceattribute_ModifiedBy
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_Dynamicpropertyinsatanceattribute_ModifiedBy")]
        public System.Collections.Generic.IEnumerable<DynamicPropertyInstance> lk_Dynamicpropertyinsatanceattribute_ModifiedBy
        {
            get { return this.GetRelatedEntities<DynamicPropertyInstance>("lk_Dynamicpropertyinsatanceattribute_ModifiedBy", null); }
            set
            {
                this.OnPropertyChanging("lk_Dynamicpropertyinsatanceattribute_ModifiedBy");
                this.SetRelatedEntities<DynamicPropertyInstance>("lk_Dynamicpropertyinsatanceattribute_ModifiedBy", null, value);
                this.OnPropertyChanged("lk_Dynamicpropertyinsatanceattribute_ModifiedBy");
            }
        }

        /// <summary>
        /// 1:N lk_Dynamicpropertyinsatanceattribute_ModifiedOnBehalfBy
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_Dynamicpropertyinsatanceattribute_ModifiedOnBehalfBy")]
        public System.Collections.Generic.IEnumerable<DynamicPropertyInstance> lk_Dynamicpropertyinsatanceattribute_ModifiedOnBehalfBy
        {
            get { return this.GetRelatedEntities<DynamicPropertyInstance>("lk_Dynamicpropertyinsatanceattribute_ModifiedOnBehalfBy", null); }
            set
            {
                this.OnPropertyChanging("lk_Dynamicpropertyinsatanceattribute_ModifiedOnBehalfBy");
                this.SetRelatedEntities<DynamicPropertyInstance>("lk_Dynamicpropertyinsatanceattribute_ModifiedOnBehalfBy", null, value);
                this.OnPropertyChanged("lk_Dynamicpropertyinsatanceattribute_ModifiedOnBehalfBy");
            }
        }

        /// <summary>
        /// 1:N lk_DynamicPropertyOptionSetItem_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_DynamicPropertyOptionSetItem_createdby")]
        public System.Collections.Generic.IEnumerable<DynamicPropertyOptionSetItem> lk_DynamicPropertyOptionSetItem_createdby
        {
            get { return this.GetRelatedEntities<DynamicPropertyOptionSetItem>("lk_DynamicPropertyOptionSetItem_createdby", null); }
            set
            {
                this.OnPropertyChanging("lk_DynamicPropertyOptionSetItem_createdby");
                this.SetRelatedEntities<DynamicPropertyOptionSetItem>("lk_DynamicPropertyOptionSetItem_createdby", null, value);
                this.OnPropertyChanged("lk_DynamicPropertyOptionSetItem_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_DynamicPropertyOptionSetItem_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_DynamicPropertyOptionSetItem_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<DynamicPropertyOptionSetItem> lk_DynamicPropertyOptionSetItem_createdonbehalfby
        {
            get { return this.GetRelatedEntities<DynamicPropertyOptionSetItem>("lk_DynamicPropertyOptionSetItem_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_DynamicPropertyOptionSetItem_createdonbehalfby");
                this.SetRelatedEntities<DynamicPropertyOptionSetItem>("lk_DynamicPropertyOptionSetItem_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_DynamicPropertyOptionSetItem_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_DynamicPropertyOptionSetItem_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_DynamicPropertyOptionSetItem_modifiedby")]
        public System.Collections.Generic.IEnumerable<DynamicPropertyOptionSetItem> lk_DynamicPropertyOptionSetItem_modifiedby
        {
            get { return this.GetRelatedEntities<DynamicPropertyOptionSetItem>("lk_DynamicPropertyOptionSetItem_modifiedby", null); }
            set
            {
                this.OnPropertyChanging("lk_DynamicPropertyOptionSetItem_modifiedby");
                this.SetRelatedEntities<DynamicPropertyOptionSetItem>("lk_DynamicPropertyOptionSetItem_modifiedby", null, value);
                this.OnPropertyChanged("lk_DynamicPropertyOptionSetItem_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_DynamicPropertyOptionSetItem_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_DynamicPropertyOptionSetItem_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<DynamicPropertyOptionSetItem> lk_DynamicPropertyOptionSetItem_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<DynamicPropertyOptionSetItem>("lk_DynamicPropertyOptionSetItem_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_DynamicPropertyOptionSetItem_modifiedonbehalfby");
                this.SetRelatedEntities<DynamicPropertyOptionSetItem>("lk_DynamicPropertyOptionSetItem_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_DynamicPropertyOptionSetItem_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_email_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_email_createdby")]
        public System.Collections.Generic.IEnumerable<Email> lk_email_createdby
        {
            get { return this.GetRelatedEntities<Email>("lk_email_createdby", null); }
            set
            {
                this.OnPropertyChanging("lk_email_createdby");
                this.SetRelatedEntities<Email>("lk_email_createdby", null, value);
                this.OnPropertyChanged("lk_email_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_email_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_email_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<Email> lk_email_createdonbehalfby
        {
            get { return this.GetRelatedEntities<Email>("lk_email_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_email_createdonbehalfby");
                this.SetRelatedEntities<Email>("lk_email_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_email_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_email_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_email_modifiedby")]
        public System.Collections.Generic.IEnumerable<Email> lk_email_modifiedby
        {
            get { return this.GetRelatedEntities<Email>("lk_email_modifiedby", null); }
            set
            {
                this.OnPropertyChanging("lk_email_modifiedby");
                this.SetRelatedEntities<Email>("lk_email_modifiedby", null, value);
                this.OnPropertyChanged("lk_email_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_email_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_email_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<Email> lk_email_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<Email>("lk_email_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_email_modifiedonbehalfby");
                this.SetRelatedEntities<Email>("lk_email_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_email_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_emailserverprofile_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_emailserverprofile_createdby")]
        public System.Collections.Generic.IEnumerable<EmailServerProfile> lk_emailserverprofile_createdby
        {
            get { return this.GetRelatedEntities<EmailServerProfile>("lk_emailserverprofile_createdby", null); }
            set
            {
                this.OnPropertyChanging("lk_emailserverprofile_createdby");
                this.SetRelatedEntities<EmailServerProfile>("lk_emailserverprofile_createdby", null, value);
                this.OnPropertyChanged("lk_emailserverprofile_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_emailserverprofile_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_emailserverprofile_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<EmailServerProfile> lk_emailserverprofile_createdonbehalfby
        {
            get { return this.GetRelatedEntities<EmailServerProfile>("lk_emailserverprofile_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_emailserverprofile_createdonbehalfby");
                this.SetRelatedEntities<EmailServerProfile>("lk_emailserverprofile_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_emailserverprofile_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_emailserverprofile_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_emailserverprofile_modifiedby")]
        public System.Collections.Generic.IEnumerable<EmailServerProfile> lk_emailserverprofile_modifiedby
        {
            get { return this.GetRelatedEntities<EmailServerProfile>("lk_emailserverprofile_modifiedby", null); }
            set
            {
                this.OnPropertyChanging("lk_emailserverprofile_modifiedby");
                this.SetRelatedEntities<EmailServerProfile>("lk_emailserverprofile_modifiedby", null, value);
                this.OnPropertyChanged("lk_emailserverprofile_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_emailserverprofile_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_emailserverprofile_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<EmailServerProfile> lk_emailserverprofile_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<EmailServerProfile>("lk_emailserverprofile_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_emailserverprofile_modifiedonbehalfby");
                this.SetRelatedEntities<EmailServerProfile>("lk_emailserverprofile_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_emailserverprofile_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_entitlement_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_entitlement_createdby")]
        public System.Collections.Generic.IEnumerable<Entitlement> lk_entitlement_createdby
        {
            get { return this.GetRelatedEntities<Entitlement>("lk_entitlement_createdby", null); }
            set
            {
                this.OnPropertyChanging("lk_entitlement_createdby");
                this.SetRelatedEntities<Entitlement>("lk_entitlement_createdby", null, value);
                this.OnPropertyChanged("lk_entitlement_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_entitlement_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_entitlement_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<Entitlement> lk_entitlement_createdonbehalfby
        {
            get { return this.GetRelatedEntities<Entitlement>("lk_entitlement_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_entitlement_createdonbehalfby");
                this.SetRelatedEntities<Entitlement>("lk_entitlement_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_entitlement_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_entitlement_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_entitlement_modifiedby")]
        public System.Collections.Generic.IEnumerable<Entitlement> lk_entitlement_modifiedby
        {
            get { return this.GetRelatedEntities<Entitlement>("lk_entitlement_modifiedby", null); }
            set
            {
                this.OnPropertyChanging("lk_entitlement_modifiedby");
                this.SetRelatedEntities<Entitlement>("lk_entitlement_modifiedby", null, value);
                this.OnPropertyChanged("lk_entitlement_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_entitlement_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_entitlement_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<Entitlement> lk_entitlement_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<Entitlement>("lk_entitlement_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_entitlement_modifiedonbehalfby");
                this.SetRelatedEntities<Entitlement>("lk_entitlement_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_entitlement_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_entitlementchannel_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_entitlementchannel_createdby")]
        public System.Collections.Generic.IEnumerable<EntitlementChannel> lk_entitlementchannel_createdby
        {
            get { return this.GetRelatedEntities<EntitlementChannel>("lk_entitlementchannel_createdby", null); }
            set
            {
                this.OnPropertyChanging("lk_entitlementchannel_createdby");
                this.SetRelatedEntities<EntitlementChannel>("lk_entitlementchannel_createdby", null, value);
                this.OnPropertyChanged("lk_entitlementchannel_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_entitlementchannel_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_entitlementchannel_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<EntitlementChannel> lk_entitlementchannel_createdonbehalfby
        {
            get { return this.GetRelatedEntities<EntitlementChannel>("lk_entitlementchannel_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_entitlementchannel_createdonbehalfby");
                this.SetRelatedEntities<EntitlementChannel>("lk_entitlementchannel_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_entitlementchannel_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_entitlementchannel_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_entitlementchannel_modifiedby")]
        public System.Collections.Generic.IEnumerable<EntitlementChannel> lk_entitlementchannel_modifiedby
        {
            get { return this.GetRelatedEntities<EntitlementChannel>("lk_entitlementchannel_modifiedby", null); }
            set
            {
                this.OnPropertyChanging("lk_entitlementchannel_modifiedby");
                this.SetRelatedEntities<EntitlementChannel>("lk_entitlementchannel_modifiedby", null, value);
                this.OnPropertyChanged("lk_entitlementchannel_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_entitlementchannel_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_entitlementchannel_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<EntitlementChannel> lk_entitlementchannel_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<EntitlementChannel>("lk_entitlementchannel_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_entitlementchannel_modifiedonbehalfby");
                this.SetRelatedEntities<EntitlementChannel>("lk_entitlementchannel_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_entitlementchannel_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_entitlementtemplate_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_entitlementtemplate_createdby")]
        public System.Collections.Generic.IEnumerable<EntitlementTemplate> lk_entitlementtemplate_createdby
        {
            get { return this.GetRelatedEntities<EntitlementTemplate>("lk_entitlementtemplate_createdby", null); }
            set
            {
                this.OnPropertyChanging("lk_entitlementtemplate_createdby");
                this.SetRelatedEntities<EntitlementTemplate>("lk_entitlementtemplate_createdby", null, value);
                this.OnPropertyChanged("lk_entitlementtemplate_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_entitlementtemplate_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_entitlementtemplate_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<EntitlementTemplate> lk_entitlementtemplate_createdonbehalfby
        {
            get { return this.GetRelatedEntities<EntitlementTemplate>("lk_entitlementtemplate_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_entitlementtemplate_createdonbehalfby");
                this.SetRelatedEntities<EntitlementTemplate>("lk_entitlementtemplate_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_entitlementtemplate_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_entitlementtemplate_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_entitlementtemplate_modifiedby")]
        public System.Collections.Generic.IEnumerable<EntitlementTemplate> lk_entitlementtemplate_modifiedby
        {
            get { return this.GetRelatedEntities<EntitlementTemplate>("lk_entitlementtemplate_modifiedby", null); }
            set
            {
                this.OnPropertyChanging("lk_entitlementtemplate_modifiedby");
                this.SetRelatedEntities<EntitlementTemplate>("lk_entitlementtemplate_modifiedby", null, value);
                this.OnPropertyChanged("lk_entitlementtemplate_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_entitlementtemplate_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_entitlementtemplate_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<EntitlementTemplate> lk_entitlementtemplate_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<EntitlementTemplate>("lk_entitlementtemplate_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_entitlementtemplate_modifiedonbehalfby");
                this.SetRelatedEntities<EntitlementTemplate>("lk_entitlementtemplate_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_entitlementtemplate_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_entitlementtemplatechannel_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_entitlementtemplatechannel_createdby")]
        public System.Collections.Generic.IEnumerable<EntitlementTemplateChannel> lk_entitlementtemplatechannel_createdby
        {
            get { return this.GetRelatedEntities<EntitlementTemplateChannel>("lk_entitlementtemplatechannel_createdby", null); }
            set
            {
                this.OnPropertyChanging("lk_entitlementtemplatechannel_createdby");
                this.SetRelatedEntities<EntitlementTemplateChannel>("lk_entitlementtemplatechannel_createdby", null, value);
                this.OnPropertyChanged("lk_entitlementtemplatechannel_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_entitlementtemplatechannel_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_entitlementtemplatechannel_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<EntitlementTemplateChannel> lk_entitlementtemplatechannel_createdonbehalfby
        {
            get { return this.GetRelatedEntities<EntitlementTemplateChannel>("lk_entitlementtemplatechannel_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_entitlementtemplatechannel_createdonbehalfby");
                this.SetRelatedEntities<EntitlementTemplateChannel>("lk_entitlementtemplatechannel_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_entitlementtemplatechannel_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_entitlementtemplatechannel_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_entitlementtemplatechannel_modifiedby")]
        public System.Collections.Generic.IEnumerable<EntitlementTemplateChannel> lk_entitlementtemplatechannel_modifiedby
        {
            get { return this.GetRelatedEntities<EntitlementTemplateChannel>("lk_entitlementtemplatechannel_modifiedby", null); }
            set
            {
                this.OnPropertyChanging("lk_entitlementtemplatechannel_modifiedby");
                this.SetRelatedEntities<EntitlementTemplateChannel>("lk_entitlementtemplatechannel_modifiedby", null, value);
                this.OnPropertyChanged("lk_entitlementtemplatechannel_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_entitlementtemplatechannel_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_entitlementtemplatechannel_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<EntitlementTemplateChannel> lk_entitlementtemplatechannel_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<EntitlementTemplateChannel>("lk_entitlementtemplatechannel_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_entitlementtemplatechannel_modifiedonbehalfby");
                this.SetRelatedEntities<EntitlementTemplateChannel>("lk_entitlementtemplatechannel_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_entitlementtemplatechannel_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_entitymap_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_entitymap_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<EntityMap> lk_entitymap_createdonbehalfby
        {
            get { return this.GetRelatedEntities<EntityMap>("lk_entitymap_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_entitymap_createdonbehalfby");
                this.SetRelatedEntities<EntityMap>("lk_entitymap_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_entitymap_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_entitymap_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_entitymap_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<EntityMap> lk_entitymap_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<EntityMap>("lk_entitymap_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_entitymap_modifiedonbehalfby");
                this.SetRelatedEntities<EntityMap>("lk_entitymap_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_entitymap_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_equipment_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_equipment_createdby")]
        public System.Collections.Generic.IEnumerable<Equipment> lk_equipment_createdby
        {
            get { return this.GetRelatedEntities<Equipment>("lk_equipment_createdby", null); }
            set
            {
                this.OnPropertyChanging("lk_equipment_createdby");
                this.SetRelatedEntities<Equipment>("lk_equipment_createdby", null, value);
                this.OnPropertyChanged("lk_equipment_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_equipment_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_equipment_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<Equipment> lk_equipment_createdonbehalfby
        {
            get { return this.GetRelatedEntities<Equipment>("lk_equipment_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_equipment_createdonbehalfby");
                this.SetRelatedEntities<Equipment>("lk_equipment_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_equipment_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_equipment_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_equipment_modifiedby")]
        public System.Collections.Generic.IEnumerable<Equipment> lk_equipment_modifiedby
        {
            get { return this.GetRelatedEntities<Equipment>("lk_equipment_modifiedby", null); }
            set
            {
                this.OnPropertyChanging("lk_equipment_modifiedby");
                this.SetRelatedEntities<Equipment>("lk_equipment_modifiedby", null, value);
                this.OnPropertyChanged("lk_equipment_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_equipment_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_equipment_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<Equipment> lk_equipment_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<Equipment>("lk_equipment_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_equipment_modifiedonbehalfby");
                this.SetRelatedEntities<Equipment>("lk_equipment_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_equipment_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_fax_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_fax_createdby")]
        public System.Collections.Generic.IEnumerable<Fax> lk_fax_createdby
        {
            get { return this.GetRelatedEntities<Fax>("lk_fax_createdby", null); }
            set
            {
                this.OnPropertyChanging("lk_fax_createdby");
                this.SetRelatedEntities<Fax>("lk_fax_createdby", null, value);
                this.OnPropertyChanged("lk_fax_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_fax_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_fax_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<Fax> lk_fax_createdonbehalfby
        {
            get { return this.GetRelatedEntities<Fax>("lk_fax_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_fax_createdonbehalfby");
                this.SetRelatedEntities<Fax>("lk_fax_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_fax_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_fax_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_fax_modifiedby")]
        public System.Collections.Generic.IEnumerable<Fax> lk_fax_modifiedby
        {
            get { return this.GetRelatedEntities<Fax>("lk_fax_modifiedby", null); }
            set
            {
                this.OnPropertyChanging("lk_fax_modifiedby");
                this.SetRelatedEntities<Fax>("lk_fax_modifiedby", null, value);
                this.OnPropertyChanged("lk_fax_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_fax_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_fax_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<Fax> lk_fax_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<Fax>("lk_fax_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_fax_modifiedonbehalfby");
                this.SetRelatedEntities<Fax>("lk_fax_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_fax_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_fieldsecurityprofile_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_fieldsecurityprofile_createdby")]
        public System.Collections.Generic.IEnumerable<FieldSecurityProfile> lk_fieldsecurityprofile_createdby
        {
            get { return this.GetRelatedEntities<FieldSecurityProfile>("lk_fieldsecurityprofile_createdby", null); }
            set
            {
                this.OnPropertyChanging("lk_fieldsecurityprofile_createdby");
                this.SetRelatedEntities<FieldSecurityProfile>("lk_fieldsecurityprofile_createdby", null, value);
                this.OnPropertyChanged("lk_fieldsecurityprofile_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_fieldsecurityprofile_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_fieldsecurityprofile_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<FieldSecurityProfile> lk_fieldsecurityprofile_createdonbehalfby
        {
            get { return this.GetRelatedEntities<FieldSecurityProfile>("lk_fieldsecurityprofile_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_fieldsecurityprofile_createdonbehalfby");
                this.SetRelatedEntities<FieldSecurityProfile>("lk_fieldsecurityprofile_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_fieldsecurityprofile_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_fieldsecurityprofile_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_fieldsecurityprofile_modifiedby")]
        public System.Collections.Generic.IEnumerable<FieldSecurityProfile> lk_fieldsecurityprofile_modifiedby
        {
            get { return this.GetRelatedEntities<FieldSecurityProfile>("lk_fieldsecurityprofile_modifiedby", null); }
            set
            {
                this.OnPropertyChanging("lk_fieldsecurityprofile_modifiedby");
                this.SetRelatedEntities<FieldSecurityProfile>("lk_fieldsecurityprofile_modifiedby", null, value);
                this.OnPropertyChanged("lk_fieldsecurityprofile_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_fieldsecurityprofile_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_fieldsecurityprofile_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<FieldSecurityProfile> lk_fieldsecurityprofile_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<FieldSecurityProfile>("lk_fieldsecurityprofile_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_fieldsecurityprofile_modifiedonbehalfby");
                this.SetRelatedEntities<FieldSecurityProfile>("lk_fieldsecurityprofile_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_fieldsecurityprofile_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_fixedmonthlyfiscalcalendar_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_fixedmonthlyfiscalcalendar_createdby")]
        public System.Collections.Generic.IEnumerable<FixedMonthlyFiscalCalendar> lk_fixedmonthlyfiscalcalendar_createdby
        {
            get { return this.GetRelatedEntities<FixedMonthlyFiscalCalendar>("lk_fixedmonthlyfiscalcalendar_createdby", null); }
            set
            {
                this.OnPropertyChanging("lk_fixedmonthlyfiscalcalendar_createdby");
                this.SetRelatedEntities<FixedMonthlyFiscalCalendar>("lk_fixedmonthlyfiscalcalendar_createdby", null, value);
                this.OnPropertyChanged("lk_fixedmonthlyfiscalcalendar_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_fixedmonthlyfiscalcalendar_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_fixedmonthlyfiscalcalendar_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<FixedMonthlyFiscalCalendar> lk_fixedmonthlyfiscalcalendar_createdonbehalfby
        {
            get { return this.GetRelatedEntities<FixedMonthlyFiscalCalendar>("lk_fixedmonthlyfiscalcalendar_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_fixedmonthlyfiscalcalendar_createdonbehalfby");
                this.SetRelatedEntities<FixedMonthlyFiscalCalendar>("lk_fixedmonthlyfiscalcalendar_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_fixedmonthlyfiscalcalendar_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_fixedmonthlyfiscalcalendar_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_fixedmonthlyfiscalcalendar_modifiedby")]
        public System.Collections.Generic.IEnumerable<FixedMonthlyFiscalCalendar> lk_fixedmonthlyfiscalcalendar_modifiedby
        {
            get { return this.GetRelatedEntities<FixedMonthlyFiscalCalendar>("lk_fixedmonthlyfiscalcalendar_modifiedby", null); }
            set
            {
                this.OnPropertyChanging("lk_fixedmonthlyfiscalcalendar_modifiedby");
                this.SetRelatedEntities<FixedMonthlyFiscalCalendar>("lk_fixedmonthlyfiscalcalendar_modifiedby", null, value);
                this.OnPropertyChanged("lk_fixedmonthlyfiscalcalendar_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_fixedmonthlyfiscalcalendar_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_fixedmonthlyfiscalcalendar_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<FixedMonthlyFiscalCalendar> lk_fixedmonthlyfiscalcalendar_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<FixedMonthlyFiscalCalendar>("lk_fixedmonthlyfiscalcalendar_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_fixedmonthlyfiscalcalendar_modifiedonbehalfby");
                this.SetRelatedEntities<FixedMonthlyFiscalCalendar>("lk_fixedmonthlyfiscalcalendar_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_fixedmonthlyfiscalcalendar_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_fixedmonthlyfiscalcalendar_salespersonid
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_fixedmonthlyfiscalcalendar_salespersonid")]
        public System.Collections.Generic.IEnumerable<FixedMonthlyFiscalCalendar> lk_fixedmonthlyfiscalcalendar_salespersonid
        {
            get { return this.GetRelatedEntities<FixedMonthlyFiscalCalendar>("lk_fixedmonthlyfiscalcalendar_salespersonid", null); }
            set
            {
                this.OnPropertyChanging("lk_fixedmonthlyfiscalcalendar_salespersonid");
                this.SetRelatedEntities<FixedMonthlyFiscalCalendar>("lk_fixedmonthlyfiscalcalendar_salespersonid", null, value);
                this.OnPropertyChanged("lk_fixedmonthlyfiscalcalendar_salespersonid");
            }
        }

        /// <summary>
        /// 1:N lk_goal_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_goal_createdby")]
        public System.Collections.Generic.IEnumerable<Goal> lk_goal_createdby
        {
            get { return this.GetRelatedEntities<Goal>("lk_goal_createdby", null); }
            set
            {
                this.OnPropertyChanging("lk_goal_createdby");
                this.SetRelatedEntities<Goal>("lk_goal_createdby", null, value);
                this.OnPropertyChanged("lk_goal_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_goal_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_goal_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<Goal> lk_goal_createdonbehalfby
        {
            get { return this.GetRelatedEntities<Goal>("lk_goal_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_goal_createdonbehalfby");
                this.SetRelatedEntities<Goal>("lk_goal_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_goal_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_goal_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_goal_modifiedby")]
        public System.Collections.Generic.IEnumerable<Goal> lk_goal_modifiedby
        {
            get { return this.GetRelatedEntities<Goal>("lk_goal_modifiedby", null); }
            set
            {
                this.OnPropertyChanging("lk_goal_modifiedby");
                this.SetRelatedEntities<Goal>("lk_goal_modifiedby", null, value);
                this.OnPropertyChanged("lk_goal_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_goal_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_goal_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<Goal> lk_goal_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<Goal>("lk_goal_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_goal_modifiedonbehalfby");
                this.SetRelatedEntities<Goal>("lk_goal_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_goal_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_goalrollupquery_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_goalrollupquery_createdby")]
        public System.Collections.Generic.IEnumerable<GoalRollupQuery> lk_goalrollupquery_createdby
        {
            get { return this.GetRelatedEntities<GoalRollupQuery>("lk_goalrollupquery_createdby", null); }
            set
            {
                this.OnPropertyChanging("lk_goalrollupquery_createdby");
                this.SetRelatedEntities<GoalRollupQuery>("lk_goalrollupquery_createdby", null, value);
                this.OnPropertyChanged("lk_goalrollupquery_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_goalrollupquery_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_goalrollupquery_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<GoalRollupQuery> lk_goalrollupquery_createdonbehalfby
        {
            get { return this.GetRelatedEntities<GoalRollupQuery>("lk_goalrollupquery_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_goalrollupquery_createdonbehalfby");
                this.SetRelatedEntities<GoalRollupQuery>("lk_goalrollupquery_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_goalrollupquery_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_goalrollupquery_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_goalrollupquery_modifiedby")]
        public System.Collections.Generic.IEnumerable<GoalRollupQuery> lk_goalrollupquery_modifiedby
        {
            get { return this.GetRelatedEntities<GoalRollupQuery>("lk_goalrollupquery_modifiedby", null); }
            set
            {
                this.OnPropertyChanging("lk_goalrollupquery_modifiedby");
                this.SetRelatedEntities<GoalRollupQuery>("lk_goalrollupquery_modifiedby", null, value);
                this.OnPropertyChanged("lk_goalrollupquery_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_goalrollupquery_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_goalrollupquery_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<GoalRollupQuery> lk_goalrollupquery_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<GoalRollupQuery>("lk_goalrollupquery_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_goalrollupquery_modifiedonbehalfby");
                this.SetRelatedEntities<GoalRollupQuery>("lk_goalrollupquery_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_goalrollupquery_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_import_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_import_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<Import> lk_import_createdonbehalfby
        {
            get { return this.GetRelatedEntities<Import>("lk_import_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_import_createdonbehalfby");
                this.SetRelatedEntities<Import>("lk_import_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_import_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_import_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_import_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<Import> lk_import_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<Import>("lk_import_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_import_modifiedonbehalfby");
                this.SetRelatedEntities<Import>("lk_import_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_import_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_importbase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_importbase_createdby")]
        public System.Collections.Generic.IEnumerable<Import> lk_importbase_createdby
        {
            get { return this.GetRelatedEntities<Import>("lk_importbase_createdby", null); }
            set
            {
                this.OnPropertyChanging("lk_importbase_createdby");
                this.SetRelatedEntities<Import>("lk_importbase_createdby", null, value);
                this.OnPropertyChanged("lk_importbase_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_importbase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_importbase_modifiedby")]
        public System.Collections.Generic.IEnumerable<Import> lk_importbase_modifiedby
        {
            get { return this.GetRelatedEntities<Import>("lk_importbase_modifiedby", null); }
            set
            {
                this.OnPropertyChanging("lk_importbase_modifiedby");
                this.SetRelatedEntities<Import>("lk_importbase_modifiedby", null, value);
                this.OnPropertyChanged("lk_importbase_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_importentitymapping_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_importentitymapping_createdby")]
        public System.Collections.Generic.IEnumerable<ImportEntityMapping> lk_importentitymapping_createdby
        {
            get { return this.GetRelatedEntities<ImportEntityMapping>("lk_importentitymapping_createdby", null); }
            set
            {
                this.OnPropertyChanging("lk_importentitymapping_createdby");
                this.SetRelatedEntities<ImportEntityMapping>("lk_importentitymapping_createdby", null, value);
                this.OnPropertyChanged("lk_importentitymapping_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_importentitymapping_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_importentitymapping_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<ImportEntityMapping> lk_importentitymapping_createdonbehalfby
        {
            get { return this.GetRelatedEntities<ImportEntityMapping>("lk_importentitymapping_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_importentitymapping_createdonbehalfby");
                this.SetRelatedEntities<ImportEntityMapping>("lk_importentitymapping_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_importentitymapping_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_importentitymapping_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_importentitymapping_modifiedby")]
        public System.Collections.Generic.IEnumerable<ImportEntityMapping> lk_importentitymapping_modifiedby
        {
            get { return this.GetRelatedEntities<ImportEntityMapping>("lk_importentitymapping_modifiedby", null); }
            set
            {
                this.OnPropertyChanging("lk_importentitymapping_modifiedby");
                this.SetRelatedEntities<ImportEntityMapping>("lk_importentitymapping_modifiedby", null, value);
                this.OnPropertyChanged("lk_importentitymapping_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_importentitymapping_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_importentitymapping_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<ImportEntityMapping> lk_importentitymapping_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<ImportEntityMapping>("lk_importentitymapping_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_importentitymapping_modifiedonbehalfby");
                this.SetRelatedEntities<ImportEntityMapping>("lk_importentitymapping_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_importentitymapping_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_importfilebase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_importfilebase_createdby")]
        public System.Collections.Generic.IEnumerable<ImportFile> lk_importfilebase_createdby
        {
            get { return this.GetRelatedEntities<ImportFile>("lk_importfilebase_createdby", null); }
            set
            {
                this.OnPropertyChanging("lk_importfilebase_createdby");
                this.SetRelatedEntities<ImportFile>("lk_importfilebase_createdby", null, value);
                this.OnPropertyChanged("lk_importfilebase_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_importfilebase_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_importfilebase_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<ImportFile> lk_importfilebase_createdonbehalfby
        {
            get { return this.GetRelatedEntities<ImportFile>("lk_importfilebase_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_importfilebase_createdonbehalfby");
                this.SetRelatedEntities<ImportFile>("lk_importfilebase_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_importfilebase_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_importfilebase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_importfilebase_modifiedby")]
        public System.Collections.Generic.IEnumerable<ImportFile> lk_importfilebase_modifiedby
        {
            get { return this.GetRelatedEntities<ImportFile>("lk_importfilebase_modifiedby", null); }
            set
            {
                this.OnPropertyChanging("lk_importfilebase_modifiedby");
                this.SetRelatedEntities<ImportFile>("lk_importfilebase_modifiedby", null, value);
                this.OnPropertyChanged("lk_importfilebase_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_importfilebase_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_importfilebase_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<ImportFile> lk_importfilebase_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<ImportFile>("lk_importfilebase_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_importfilebase_modifiedonbehalfby");
                this.SetRelatedEntities<ImportFile>("lk_importfilebase_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_importfilebase_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_importjobbase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_importjobbase_createdby")]
        public System.Collections.Generic.IEnumerable<ImportJob> lk_importjobbase_createdby
        {
            get { return this.GetRelatedEntities<ImportJob>("lk_importjobbase_createdby", null); }
            set
            {
                this.OnPropertyChanging("lk_importjobbase_createdby");
                this.SetRelatedEntities<ImportJob>("lk_importjobbase_createdby", null, value);
                this.OnPropertyChanged("lk_importjobbase_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_importjobbase_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_importjobbase_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<ImportJob> lk_importjobbase_createdonbehalfby
        {
            get { return this.GetRelatedEntities<ImportJob>("lk_importjobbase_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_importjobbase_createdonbehalfby");
                this.SetRelatedEntities<ImportJob>("lk_importjobbase_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_importjobbase_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_importjobbase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_importjobbase_modifiedby")]
        public System.Collections.Generic.IEnumerable<ImportJob> lk_importjobbase_modifiedby
        {
            get { return this.GetRelatedEntities<ImportJob>("lk_importjobbase_modifiedby", null); }
            set
            {
                this.OnPropertyChanging("lk_importjobbase_modifiedby");
                this.SetRelatedEntities<ImportJob>("lk_importjobbase_modifiedby", null, value);
                this.OnPropertyChanged("lk_importjobbase_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_importjobbase_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_importjobbase_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<ImportJob> lk_importjobbase_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<ImportJob>("lk_importjobbase_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_importjobbase_modifiedonbehalfby");
                this.SetRelatedEntities<ImportJob>("lk_importjobbase_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_importjobbase_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_importlog_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_importlog_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<ImportLog> lk_importlog_createdonbehalfby
        {
            get { return this.GetRelatedEntities<ImportLog>("lk_importlog_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_importlog_createdonbehalfby");
                this.SetRelatedEntities<ImportLog>("lk_importlog_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_importlog_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_importlog_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_importlog_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<ImportLog> lk_importlog_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<ImportLog>("lk_importlog_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_importlog_modifiedonbehalfby");
                this.SetRelatedEntities<ImportLog>("lk_importlog_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_importlog_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_importlogbase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_importlogbase_createdby")]
        public System.Collections.Generic.IEnumerable<ImportLog> lk_importlogbase_createdby
        {
            get { return this.GetRelatedEntities<ImportLog>("lk_importlogbase_createdby", null); }
            set
            {
                this.OnPropertyChanging("lk_importlogbase_createdby");
                this.SetRelatedEntities<ImportLog>("lk_importlogbase_createdby", null, value);
                this.OnPropertyChanged("lk_importlogbase_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_importlogbase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_importlogbase_modifiedby")]
        public System.Collections.Generic.IEnumerable<ImportLog> lk_importlogbase_modifiedby
        {
            get { return this.GetRelatedEntities<ImportLog>("lk_importlogbase_modifiedby", null); }
            set
            {
                this.OnPropertyChanging("lk_importlogbase_modifiedby");
                this.SetRelatedEntities<ImportLog>("lk_importlogbase_modifiedby", null, value);
                this.OnPropertyChanged("lk_importlogbase_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_importmap_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_importmap_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<ImportMap> lk_importmap_createdonbehalfby
        {
            get { return this.GetRelatedEntities<ImportMap>("lk_importmap_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_importmap_createdonbehalfby");
                this.SetRelatedEntities<ImportMap>("lk_importmap_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_importmap_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_importmap_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_importmap_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<ImportMap> lk_importmap_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<ImportMap>("lk_importmap_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_importmap_modifiedonbehalfby");
                this.SetRelatedEntities<ImportMap>("lk_importmap_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_importmap_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_importmapbase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_importmapbase_createdby")]
        public System.Collections.Generic.IEnumerable<ImportMap> lk_importmapbase_createdby
        {
            get { return this.GetRelatedEntities<ImportMap>("lk_importmapbase_createdby", null); }
            set
            {
                this.OnPropertyChanging("lk_importmapbase_createdby");
                this.SetRelatedEntities<ImportMap>("lk_importmapbase_createdby", null, value);
                this.OnPropertyChanged("lk_importmapbase_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_importmapbase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_importmapbase_modifiedby")]
        public System.Collections.Generic.IEnumerable<ImportMap> lk_importmapbase_modifiedby
        {
            get { return this.GetRelatedEntities<ImportMap>("lk_importmapbase_modifiedby", null); }
            set
            {
                this.OnPropertyChanging("lk_importmapbase_modifiedby");
                this.SetRelatedEntities<ImportMap>("lk_importmapbase_modifiedby", null, value);
                this.OnPropertyChanged("lk_importmapbase_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_incidentbase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_incidentbase_createdby")]
        public System.Collections.Generic.IEnumerable<Incident> lk_incidentbase_createdby
        {
            get { return this.GetRelatedEntities<Incident>("lk_incidentbase_createdby", null); }
            set
            {
                this.OnPropertyChanging("lk_incidentbase_createdby");
                this.SetRelatedEntities<Incident>("lk_incidentbase_createdby", null, value);
                this.OnPropertyChanged("lk_incidentbase_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_incidentbase_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_incidentbase_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<Incident> lk_incidentbase_createdonbehalfby
        {
            get { return this.GetRelatedEntities<Incident>("lk_incidentbase_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_incidentbase_createdonbehalfby");
                this.SetRelatedEntities<Incident>("lk_incidentbase_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_incidentbase_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_incidentbase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_incidentbase_modifiedby")]
        public System.Collections.Generic.IEnumerable<Incident> lk_incidentbase_modifiedby
        {
            get { return this.GetRelatedEntities<Incident>("lk_incidentbase_modifiedby", null); }
            set
            {
                this.OnPropertyChanging("lk_incidentbase_modifiedby");
                this.SetRelatedEntities<Incident>("lk_incidentbase_modifiedby", null, value);
                this.OnPropertyChanged("lk_incidentbase_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_incidentbase_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_incidentbase_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<Incident> lk_incidentbase_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<Incident>("lk_incidentbase_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_incidentbase_modifiedonbehalfby");
                this.SetRelatedEntities<Incident>("lk_incidentbase_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_incidentbase_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_incidentresolution_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_incidentresolution_createdby")]
        public System.Collections.Generic.IEnumerable<IncidentResolution> lk_incidentresolution_createdby
        {
            get { return this.GetRelatedEntities<IncidentResolution>("lk_incidentresolution_createdby", null); }
            set
            {
                this.OnPropertyChanging("lk_incidentresolution_createdby");
                this.SetRelatedEntities<IncidentResolution>("lk_incidentresolution_createdby", null, value);
                this.OnPropertyChanged("lk_incidentresolution_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_incidentresolution_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_incidentresolution_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<IncidentResolution> lk_incidentresolution_createdonbehalfby
        {
            get { return this.GetRelatedEntities<IncidentResolution>("lk_incidentresolution_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_incidentresolution_createdonbehalfby");
                this.SetRelatedEntities<IncidentResolution>("lk_incidentresolution_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_incidentresolution_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_incidentresolution_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_incidentresolution_modifiedby")]
        public System.Collections.Generic.IEnumerable<IncidentResolution> lk_incidentresolution_modifiedby
        {
            get { return this.GetRelatedEntities<IncidentResolution>("lk_incidentresolution_modifiedby", null); }
            set
            {
                this.OnPropertyChanging("lk_incidentresolution_modifiedby");
                this.SetRelatedEntities<IncidentResolution>("lk_incidentresolution_modifiedby", null, value);
                this.OnPropertyChanged("lk_incidentresolution_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_incidentresolution_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_incidentresolution_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<IncidentResolution> lk_incidentresolution_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<IncidentResolution>("lk_incidentresolution_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_incidentresolution_modifiedonbehalfby");
                this.SetRelatedEntities<IncidentResolution>("lk_incidentresolution_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_incidentresolution_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_invoice_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_invoice_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<Invoice> lk_invoice_createdonbehalfby
        {
            get { return this.GetRelatedEntities<Invoice>("lk_invoice_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_invoice_createdonbehalfby");
                this.SetRelatedEntities<Invoice>("lk_invoice_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_invoice_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_invoice_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_invoice_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<Invoice> lk_invoice_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<Invoice>("lk_invoice_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_invoice_modifiedonbehalfby");
                this.SetRelatedEntities<Invoice>("lk_invoice_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_invoice_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_invoicebase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_invoicebase_createdby")]
        public System.Collections.Generic.IEnumerable<Invoice> lk_invoicebase_createdby
        {
            get { return this.GetRelatedEntities<Invoice>("lk_invoicebase_createdby", null); }
            set
            {
                this.OnPropertyChanging("lk_invoicebase_createdby");
                this.SetRelatedEntities<Invoice>("lk_invoicebase_createdby", null, value);
                this.OnPropertyChanged("lk_invoicebase_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_invoicebase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_invoicebase_modifiedby")]
        public System.Collections.Generic.IEnumerable<Invoice> lk_invoicebase_modifiedby
        {
            get { return this.GetRelatedEntities<Invoice>("lk_invoicebase_modifiedby", null); }
            set
            {
                this.OnPropertyChanging("lk_invoicebase_modifiedby");
                this.SetRelatedEntities<Invoice>("lk_invoicebase_modifiedby", null, value);
                this.OnPropertyChanged("lk_invoicebase_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_invoicedetail_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_invoicedetail_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<InvoiceDetail> lk_invoicedetail_createdonbehalfby
        {
            get { return this.GetRelatedEntities<InvoiceDetail>("lk_invoicedetail_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_invoicedetail_createdonbehalfby");
                this.SetRelatedEntities<InvoiceDetail>("lk_invoicedetail_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_invoicedetail_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_invoicedetail_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_invoicedetail_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<InvoiceDetail> lk_invoicedetail_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<InvoiceDetail>("lk_invoicedetail_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_invoicedetail_modifiedonbehalfby");
                this.SetRelatedEntities<InvoiceDetail>("lk_invoicedetail_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_invoicedetail_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_invoicedetailbase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_invoicedetailbase_createdby")]
        public System.Collections.Generic.IEnumerable<InvoiceDetail> lk_invoicedetailbase_createdby
        {
            get { return this.GetRelatedEntities<InvoiceDetail>("lk_invoicedetailbase_createdby", null); }
            set
            {
                this.OnPropertyChanging("lk_invoicedetailbase_createdby");
                this.SetRelatedEntities<InvoiceDetail>("lk_invoicedetailbase_createdby", null, value);
                this.OnPropertyChanged("lk_invoicedetailbase_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_invoicedetailbase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_invoicedetailbase_modifiedby")]
        public System.Collections.Generic.IEnumerable<InvoiceDetail> lk_invoicedetailbase_modifiedby
        {
            get { return this.GetRelatedEntities<InvoiceDetail>("lk_invoicedetailbase_modifiedby", null); }
            set
            {
                this.OnPropertyChanging("lk_invoicedetailbase_modifiedby");
                this.SetRelatedEntities<InvoiceDetail>("lk_invoicedetailbase_modifiedby", null, value);
                this.OnPropertyChanged("lk_invoicedetailbase_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_isvconfig_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_isvconfig_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<IsvConfig> lk_isvconfig_createdonbehalfby
        {
            get { return this.GetRelatedEntities<IsvConfig>("lk_isvconfig_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_isvconfig_createdonbehalfby");
                this.SetRelatedEntities<IsvConfig>("lk_isvconfig_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_isvconfig_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_isvconfig_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_isvconfig_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<IsvConfig> lk_isvconfig_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<IsvConfig>("lk_isvconfig_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_isvconfig_modifiedonbehalfby");
                this.SetRelatedEntities<IsvConfig>("lk_isvconfig_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_isvconfig_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_isvconfigbase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_isvconfigbase_createdby")]
        public System.Collections.Generic.IEnumerable<IsvConfig> lk_isvconfigbase_createdby
        {
            get { return this.GetRelatedEntities<IsvConfig>("lk_isvconfigbase_createdby", null); }
            set
            {
                this.OnPropertyChanging("lk_isvconfigbase_createdby");
                this.SetRelatedEntities<IsvConfig>("lk_isvconfigbase_createdby", null, value);
                this.OnPropertyChanged("lk_isvconfigbase_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_isvconfigbase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_isvconfigbase_modifiedby")]
        public System.Collections.Generic.IEnumerable<IsvConfig> lk_isvconfigbase_modifiedby
        {
            get { return this.GetRelatedEntities<IsvConfig>("lk_isvconfigbase_modifiedby", null); }
            set
            {
                this.OnPropertyChanging("lk_isvconfigbase_modifiedby");
                this.SetRelatedEntities<IsvConfig>("lk_isvconfigbase_modifiedby", null, value);
                this.OnPropertyChanged("lk_isvconfigbase_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_kbarticle_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_kbarticle_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<KbArticle> lk_kbarticle_createdonbehalfby
        {
            get { return this.GetRelatedEntities<KbArticle>("lk_kbarticle_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_kbarticle_createdonbehalfby");
                this.SetRelatedEntities<KbArticle>("lk_kbarticle_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_kbarticle_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_kbarticle_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_kbarticle_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<KbArticle> lk_kbarticle_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<KbArticle>("lk_kbarticle_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_kbarticle_modifiedonbehalfby");
                this.SetRelatedEntities<KbArticle>("lk_kbarticle_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_kbarticle_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_kbarticlebase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_kbarticlebase_createdby")]
        public System.Collections.Generic.IEnumerable<KbArticle> lk_kbarticlebase_createdby
        {
            get { return this.GetRelatedEntities<KbArticle>("lk_kbarticlebase_createdby", null); }
            set
            {
                this.OnPropertyChanging("lk_kbarticlebase_createdby");
                this.SetRelatedEntities<KbArticle>("lk_kbarticlebase_createdby", null, value);
                this.OnPropertyChanged("lk_kbarticlebase_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_kbarticlebase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_kbarticlebase_modifiedby")]
        public System.Collections.Generic.IEnumerable<KbArticle> lk_kbarticlebase_modifiedby
        {
            get { return this.GetRelatedEntities<KbArticle>("lk_kbarticlebase_modifiedby", null); }
            set
            {
                this.OnPropertyChanging("lk_kbarticlebase_modifiedby");
                this.SetRelatedEntities<KbArticle>("lk_kbarticlebase_modifiedby", null, value);
                this.OnPropertyChanged("lk_kbarticlebase_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_kbarticlecomment_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_kbarticlecomment_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<KbArticleComment> lk_kbarticlecomment_createdonbehalfby
        {
            get { return this.GetRelatedEntities<KbArticleComment>("lk_kbarticlecomment_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_kbarticlecomment_createdonbehalfby");
                this.SetRelatedEntities<KbArticleComment>("lk_kbarticlecomment_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_kbarticlecomment_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_kbarticlecomment_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_kbarticlecomment_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<KbArticleComment> lk_kbarticlecomment_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<KbArticleComment>("lk_kbarticlecomment_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_kbarticlecomment_modifiedonbehalfby");
                this.SetRelatedEntities<KbArticleComment>("lk_kbarticlecomment_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_kbarticlecomment_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_kbarticlecommentbase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_kbarticlecommentbase_createdby")]
        public System.Collections.Generic.IEnumerable<KbArticleComment> lk_kbarticlecommentbase_createdby
        {
            get { return this.GetRelatedEntities<KbArticleComment>("lk_kbarticlecommentbase_createdby", null); }
            set
            {
                this.OnPropertyChanging("lk_kbarticlecommentbase_createdby");
                this.SetRelatedEntities<KbArticleComment>("lk_kbarticlecommentbase_createdby", null, value);
                this.OnPropertyChanged("lk_kbarticlecommentbase_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_kbarticlecommentbase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_kbarticlecommentbase_modifiedby")]
        public System.Collections.Generic.IEnumerable<KbArticleComment> lk_kbarticlecommentbase_modifiedby
        {
            get { return this.GetRelatedEntities<KbArticleComment>("lk_kbarticlecommentbase_modifiedby", null); }
            set
            {
                this.OnPropertyChanging("lk_kbarticlecommentbase_modifiedby");
                this.SetRelatedEntities<KbArticleComment>("lk_kbarticlecommentbase_modifiedby", null, value);
                this.OnPropertyChanged("lk_kbarticlecommentbase_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_kbarticletemplate_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_kbarticletemplate_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<KbArticleTemplate> lk_kbarticletemplate_createdonbehalfby
        {
            get { return this.GetRelatedEntities<KbArticleTemplate>("lk_kbarticletemplate_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_kbarticletemplate_createdonbehalfby");
                this.SetRelatedEntities<KbArticleTemplate>("lk_kbarticletemplate_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_kbarticletemplate_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_kbarticletemplate_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_kbarticletemplate_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<KbArticleTemplate> lk_kbarticletemplate_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<KbArticleTemplate>("lk_kbarticletemplate_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_kbarticletemplate_modifiedonbehalfby");
                this.SetRelatedEntities<KbArticleTemplate>("lk_kbarticletemplate_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_kbarticletemplate_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_kbarticletemplatebase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_kbarticletemplatebase_createdby")]
        public System.Collections.Generic.IEnumerable<KbArticleTemplate> lk_kbarticletemplatebase_createdby
        {
            get { return this.GetRelatedEntities<KbArticleTemplate>("lk_kbarticletemplatebase_createdby", null); }
            set
            {
                this.OnPropertyChanging("lk_kbarticletemplatebase_createdby");
                this.SetRelatedEntities<KbArticleTemplate>("lk_kbarticletemplatebase_createdby", null, value);
                this.OnPropertyChanged("lk_kbarticletemplatebase_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_kbarticletemplatebase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_kbarticletemplatebase_modifiedby")]
        public System.Collections.Generic.IEnumerable<KbArticleTemplate> lk_kbarticletemplatebase_modifiedby
        {
            get { return this.GetRelatedEntities<KbArticleTemplate>("lk_kbarticletemplatebase_modifiedby", null); }
            set
            {
                this.OnPropertyChanging("lk_kbarticletemplatebase_modifiedby");
                this.SetRelatedEntities<KbArticleTemplate>("lk_kbarticletemplatebase_modifiedby", null, value);
                this.OnPropertyChanged("lk_kbarticletemplatebase_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_lead_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_lead_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<Lead> lk_lead_createdonbehalfby
        {
            get { return this.GetRelatedEntities<Lead>("lk_lead_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_lead_createdonbehalfby");
                this.SetRelatedEntities<Lead>("lk_lead_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_lead_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_lead_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_lead_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<Lead> lk_lead_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<Lead>("lk_lead_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_lead_modifiedonbehalfby");
                this.SetRelatedEntities<Lead>("lk_lead_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_lead_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_leadaddress_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_leadaddress_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<LeadAddress> lk_leadaddress_createdonbehalfby
        {
            get { return this.GetRelatedEntities<LeadAddress>("lk_leadaddress_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_leadaddress_createdonbehalfby");
                this.SetRelatedEntities<LeadAddress>("lk_leadaddress_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_leadaddress_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_leadaddress_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_leadaddress_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<LeadAddress> lk_leadaddress_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<LeadAddress>("lk_leadaddress_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_leadaddress_modifiedonbehalfby");
                this.SetRelatedEntities<LeadAddress>("lk_leadaddress_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_leadaddress_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_leadaddressbase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_leadaddressbase_createdby")]
        public System.Collections.Generic.IEnumerable<LeadAddress> lk_leadaddressbase_createdby
        {
            get { return this.GetRelatedEntities<LeadAddress>("lk_leadaddressbase_createdby", null); }
            set
            {
                this.OnPropertyChanging("lk_leadaddressbase_createdby");
                this.SetRelatedEntities<LeadAddress>("lk_leadaddressbase_createdby", null, value);
                this.OnPropertyChanged("lk_leadaddressbase_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_leadaddressbase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_leadaddressbase_modifiedby")]
        public System.Collections.Generic.IEnumerable<LeadAddress> lk_leadaddressbase_modifiedby
        {
            get { return this.GetRelatedEntities<LeadAddress>("lk_leadaddressbase_modifiedby", null); }
            set
            {
                this.OnPropertyChanging("lk_leadaddressbase_modifiedby");
                this.SetRelatedEntities<LeadAddress>("lk_leadaddressbase_modifiedby", null, value);
                this.OnPropertyChanged("lk_leadaddressbase_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_leadbase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_leadbase_createdby")]
        public System.Collections.Generic.IEnumerable<Lead> lk_leadbase_createdby
        {
            get { return this.GetRelatedEntities<Lead>("lk_leadbase_createdby", null); }
            set
            {
                this.OnPropertyChanging("lk_leadbase_createdby");
                this.SetRelatedEntities<Lead>("lk_leadbase_createdby", null, value);
                this.OnPropertyChanged("lk_leadbase_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_leadbase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_leadbase_modifiedby")]
        public System.Collections.Generic.IEnumerable<Lead> lk_leadbase_modifiedby
        {
            get { return this.GetRelatedEntities<Lead>("lk_leadbase_modifiedby", null); }
            set
            {
                this.OnPropertyChanging("lk_leadbase_modifiedby");
                this.SetRelatedEntities<Lead>("lk_leadbase_modifiedby", null, value);
                this.OnPropertyChanged("lk_leadbase_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_letter_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_letter_createdby")]
        public System.Collections.Generic.IEnumerable<Letter> lk_letter_createdby
        {
            get { return this.GetRelatedEntities<Letter>("lk_letter_createdby", null); }
            set
            {
                this.OnPropertyChanging("lk_letter_createdby");
                this.SetRelatedEntities<Letter>("lk_letter_createdby", null, value);
                this.OnPropertyChanged("lk_letter_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_letter_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_letter_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<Letter> lk_letter_createdonbehalfby
        {
            get { return this.GetRelatedEntities<Letter>("lk_letter_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_letter_createdonbehalfby");
                this.SetRelatedEntities<Letter>("lk_letter_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_letter_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_letter_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_letter_modifiedby")]
        public System.Collections.Generic.IEnumerable<Letter> lk_letter_modifiedby
        {
            get { return this.GetRelatedEntities<Letter>("lk_letter_modifiedby", null); }
            set
            {
                this.OnPropertyChanging("lk_letter_modifiedby");
                this.SetRelatedEntities<Letter>("lk_letter_modifiedby", null, value);
                this.OnPropertyChanged("lk_letter_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_letter_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_letter_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<Letter> lk_letter_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<Letter>("lk_letter_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_letter_modifiedonbehalfby");
                this.SetRelatedEntities<Letter>("lk_letter_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_letter_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_list_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_list_createdby")]
        public System.Collections.Generic.IEnumerable<List> lk_list_createdby
        {
            get { return this.GetRelatedEntities<List>("lk_list_createdby", null); }
            set
            {
                this.OnPropertyChanging("lk_list_createdby");
                this.SetRelatedEntities<List>("lk_list_createdby", null, value);
                this.OnPropertyChanged("lk_list_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_list_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_list_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<List> lk_list_createdonbehalfby
        {
            get { return this.GetRelatedEntities<List>("lk_list_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_list_createdonbehalfby");
                this.SetRelatedEntities<List>("lk_list_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_list_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_list_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_list_modifiedby")]
        public System.Collections.Generic.IEnumerable<List> lk_list_modifiedby
        {
            get { return this.GetRelatedEntities<List>("lk_list_modifiedby", null); }
            set
            {
                this.OnPropertyChanging("lk_list_modifiedby");
                this.SetRelatedEntities<List>("lk_list_modifiedby", null, value);
                this.OnPropertyChanged("lk_list_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_list_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_list_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<List> lk_list_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<List>("lk_list_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_list_modifiedonbehalfby");
                this.SetRelatedEntities<List>("lk_list_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_list_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_listmember_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_listmember_createdby")]
        public System.Collections.Generic.IEnumerable<ListMember> lk_listmember_createdby
        {
            get { return this.GetRelatedEntities<ListMember>("lk_listmember_createdby", null); }
            set
            {
                this.OnPropertyChanging("lk_listmember_createdby");
                this.SetRelatedEntities<ListMember>("lk_listmember_createdby", null, value);
                this.OnPropertyChanged("lk_listmember_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_listmember_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_listmember_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<ListMember> lk_listmember_createdonbehalfby
        {
            get { return this.GetRelatedEntities<ListMember>("lk_listmember_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_listmember_createdonbehalfby");
                this.SetRelatedEntities<ListMember>("lk_listmember_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_listmember_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_listmember_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_listmember_modifiedby")]
        public System.Collections.Generic.IEnumerable<ListMember> lk_listmember_modifiedby
        {
            get { return this.GetRelatedEntities<ListMember>("lk_listmember_modifiedby", null); }
            set
            {
                this.OnPropertyChanging("lk_listmember_modifiedby");
                this.SetRelatedEntities<ListMember>("lk_listmember_modifiedby", null, value);
                this.OnPropertyChanged("lk_listmember_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_listmember_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_listmember_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<ListMember> lk_listmember_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<ListMember>("lk_listmember_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_listmember_modifiedonbehalfby");
                this.SetRelatedEntities<ListMember>("lk_listmember_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_listmember_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_lookupmapping_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_lookupmapping_createdby")]
        public System.Collections.Generic.IEnumerable<LookUpMapping> lk_lookupmapping_createdby
        {
            get { return this.GetRelatedEntities<LookUpMapping>("lk_lookupmapping_createdby", null); }
            set
            {
                this.OnPropertyChanging("lk_lookupmapping_createdby");
                this.SetRelatedEntities<LookUpMapping>("lk_lookupmapping_createdby", null, value);
                this.OnPropertyChanged("lk_lookupmapping_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_lookupmapping_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_lookupmapping_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<LookUpMapping> lk_lookupmapping_createdonbehalfby
        {
            get { return this.GetRelatedEntities<LookUpMapping>("lk_lookupmapping_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_lookupmapping_createdonbehalfby");
                this.SetRelatedEntities<LookUpMapping>("lk_lookupmapping_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_lookupmapping_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_lookupmapping_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_lookupmapping_modifiedby")]
        public System.Collections.Generic.IEnumerable<LookUpMapping> lk_lookupmapping_modifiedby
        {
            get { return this.GetRelatedEntities<LookUpMapping>("lk_lookupmapping_modifiedby", null); }
            set
            {
                this.OnPropertyChanging("lk_lookupmapping_modifiedby");
                this.SetRelatedEntities<LookUpMapping>("lk_lookupmapping_modifiedby", null, value);
                this.OnPropertyChanged("lk_lookupmapping_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_lookupmapping_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_lookupmapping_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<LookUpMapping> lk_lookupmapping_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<LookUpMapping>("lk_lookupmapping_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_lookupmapping_modifiedonbehalfby");
                this.SetRelatedEntities<LookUpMapping>("lk_lookupmapping_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_lookupmapping_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_mailbox_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_mailbox_createdby")]
        public System.Collections.Generic.IEnumerable<Mailbox> lk_mailbox_createdby
        {
            get { return this.GetRelatedEntities<Mailbox>("lk_mailbox_createdby", null); }
            set
            {
                this.OnPropertyChanging("lk_mailbox_createdby");
                this.SetRelatedEntities<Mailbox>("lk_mailbox_createdby", null, value);
                this.OnPropertyChanged("lk_mailbox_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_mailbox_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_mailbox_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<Mailbox> lk_mailbox_createdonbehalfby
        {
            get { return this.GetRelatedEntities<Mailbox>("lk_mailbox_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_mailbox_createdonbehalfby");
                this.SetRelatedEntities<Mailbox>("lk_mailbox_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_mailbox_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_mailbox_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_mailbox_modifiedby")]
        public System.Collections.Generic.IEnumerable<Mailbox> lk_mailbox_modifiedby
        {
            get { return this.GetRelatedEntities<Mailbox>("lk_mailbox_modifiedby", null); }
            set
            {
                this.OnPropertyChanging("lk_mailbox_modifiedby");
                this.SetRelatedEntities<Mailbox>("lk_mailbox_modifiedby", null, value);
                this.OnPropertyChanged("lk_mailbox_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_mailbox_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_mailbox_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<Mailbox> lk_mailbox_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<Mailbox>("lk_mailbox_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_mailbox_modifiedonbehalfby");
                this.SetRelatedEntities<Mailbox>("lk_mailbox_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_mailbox_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_mailmergetemplate_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_mailmergetemplate_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<MailMergeTemplate> lk_mailmergetemplate_createdonbehalfby
        {
            get { return this.GetRelatedEntities<MailMergeTemplate>("lk_mailmergetemplate_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_mailmergetemplate_createdonbehalfby");
                this.SetRelatedEntities<MailMergeTemplate>("lk_mailmergetemplate_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_mailmergetemplate_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_mailmergetemplate_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_mailmergetemplate_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<MailMergeTemplate> lk_mailmergetemplate_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<MailMergeTemplate>("lk_mailmergetemplate_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_mailmergetemplate_modifiedonbehalfby");
                this.SetRelatedEntities<MailMergeTemplate>("lk_mailmergetemplate_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_mailmergetemplate_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_mailmergetemplatebase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_mailmergetemplatebase_createdby")]
        public System.Collections.Generic.IEnumerable<MailMergeTemplate> lk_mailmergetemplatebase_createdby
        {
            get { return this.GetRelatedEntities<MailMergeTemplate>("lk_mailmergetemplatebase_createdby", null); }
            set
            {
                this.OnPropertyChanging("lk_mailmergetemplatebase_createdby");
                this.SetRelatedEntities<MailMergeTemplate>("lk_mailmergetemplatebase_createdby", null, value);
                this.OnPropertyChanged("lk_mailmergetemplatebase_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_mailmergetemplatebase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_mailmergetemplatebase_modifiedby")]
        public System.Collections.Generic.IEnumerable<MailMergeTemplate> lk_mailmergetemplatebase_modifiedby
        {
            get { return this.GetRelatedEntities<MailMergeTemplate>("lk_mailmergetemplatebase_modifiedby", null); }
            set
            {
                this.OnPropertyChanging("lk_mailmergetemplatebase_modifiedby");
                this.SetRelatedEntities<MailMergeTemplate>("lk_mailmergetemplatebase_modifiedby", null, value);
                this.OnPropertyChanged("lk_mailmergetemplatebase_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_metric_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_metric_createdby")]
        public System.Collections.Generic.IEnumerable<Metric> lk_metric_createdby
        {
            get { return this.GetRelatedEntities<Metric>("lk_metric_createdby", null); }
            set
            {
                this.OnPropertyChanging("lk_metric_createdby");
                this.SetRelatedEntities<Metric>("lk_metric_createdby", null, value);
                this.OnPropertyChanged("lk_metric_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_metric_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_metric_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<Metric> lk_metric_createdonbehalfby
        {
            get { return this.GetRelatedEntities<Metric>("lk_metric_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_metric_createdonbehalfby");
                this.SetRelatedEntities<Metric>("lk_metric_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_metric_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_metric_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_metric_modifiedby")]
        public System.Collections.Generic.IEnumerable<Metric> lk_metric_modifiedby
        {
            get { return this.GetRelatedEntities<Metric>("lk_metric_modifiedby", null); }
            set
            {
                this.OnPropertyChanging("lk_metric_modifiedby");
                this.SetRelatedEntities<Metric>("lk_metric_modifiedby", null, value);
                this.OnPropertyChanged("lk_metric_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_metric_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_metric_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<Metric> lk_metric_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<Metric>("lk_metric_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_metric_modifiedonbehalfby");
                this.SetRelatedEntities<Metric>("lk_metric_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_metric_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_monthlyfiscalcalendar_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_monthlyfiscalcalendar_createdby")]
        public System.Collections.Generic.IEnumerable<MonthlyFiscalCalendar> lk_monthlyfiscalcalendar_createdby
        {
            get { return this.GetRelatedEntities<MonthlyFiscalCalendar>("lk_monthlyfiscalcalendar_createdby", null); }
            set
            {
                this.OnPropertyChanging("lk_monthlyfiscalcalendar_createdby");
                this.SetRelatedEntities<MonthlyFiscalCalendar>("lk_monthlyfiscalcalendar_createdby", null, value);
                this.OnPropertyChanged("lk_monthlyfiscalcalendar_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_monthlyfiscalcalendar_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_monthlyfiscalcalendar_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<MonthlyFiscalCalendar> lk_monthlyfiscalcalendar_createdonbehalfby
        {
            get { return this.GetRelatedEntities<MonthlyFiscalCalendar>("lk_monthlyfiscalcalendar_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_monthlyfiscalcalendar_createdonbehalfby");
                this.SetRelatedEntities<MonthlyFiscalCalendar>("lk_monthlyfiscalcalendar_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_monthlyfiscalcalendar_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_monthlyfiscalcalendar_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_monthlyfiscalcalendar_modifiedby")]
        public System.Collections.Generic.IEnumerable<MonthlyFiscalCalendar> lk_monthlyfiscalcalendar_modifiedby
        {
            get { return this.GetRelatedEntities<MonthlyFiscalCalendar>("lk_monthlyfiscalcalendar_modifiedby", null); }
            set
            {
                this.OnPropertyChanging("lk_monthlyfiscalcalendar_modifiedby");
                this.SetRelatedEntities<MonthlyFiscalCalendar>("lk_monthlyfiscalcalendar_modifiedby", null, value);
                this.OnPropertyChanged("lk_monthlyfiscalcalendar_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_monthlyfiscalcalendar_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_monthlyfiscalcalendar_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<MonthlyFiscalCalendar> lk_monthlyfiscalcalendar_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<MonthlyFiscalCalendar>("lk_monthlyfiscalcalendar_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_monthlyfiscalcalendar_modifiedonbehalfby");
                this.SetRelatedEntities<MonthlyFiscalCalendar>("lk_monthlyfiscalcalendar_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_monthlyfiscalcalendar_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_monthlyfiscalcalendar_salespersonid
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_monthlyfiscalcalendar_salespersonid")]
        public System.Collections.Generic.IEnumerable<MonthlyFiscalCalendar> lk_monthlyfiscalcalendar_salespersonid
        {
            get { return this.GetRelatedEntities<MonthlyFiscalCalendar>("lk_monthlyfiscalcalendar_salespersonid", null); }
            set
            {
                this.OnPropertyChanging("lk_monthlyfiscalcalendar_salespersonid");
                this.SetRelatedEntities<MonthlyFiscalCalendar>("lk_monthlyfiscalcalendar_salespersonid", null, value);
                this.OnPropertyChanged("lk_monthlyfiscalcalendar_salespersonid");
            }
        }

        /// <summary>
        /// 1:N lk_msdyn_postalbum_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_msdyn_postalbum_createdby")]
        public System.Collections.Generic.IEnumerable<msdyn_PostAlbum> lk_msdyn_postalbum_createdby
        {
            get { return this.GetRelatedEntities<msdyn_PostAlbum>("lk_msdyn_postalbum_createdby", null); }
            set
            {
                this.OnPropertyChanging("lk_msdyn_postalbum_createdby");
                this.SetRelatedEntities<msdyn_PostAlbum>("lk_msdyn_postalbum_createdby", null, value);
                this.OnPropertyChanged("lk_msdyn_postalbum_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_msdyn_postalbum_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_msdyn_postalbum_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<msdyn_PostAlbum> lk_msdyn_postalbum_createdonbehalfby
        {
            get { return this.GetRelatedEntities<msdyn_PostAlbum>("lk_msdyn_postalbum_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_msdyn_postalbum_createdonbehalfby");
                this.SetRelatedEntities<msdyn_PostAlbum>("lk_msdyn_postalbum_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_msdyn_postalbum_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_msdyn_postalbum_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_msdyn_postalbum_modifiedby")]
        public System.Collections.Generic.IEnumerable<msdyn_PostAlbum> lk_msdyn_postalbum_modifiedby
        {
            get { return this.GetRelatedEntities<msdyn_PostAlbum>("lk_msdyn_postalbum_modifiedby", null); }
            set
            {
                this.OnPropertyChanging("lk_msdyn_postalbum_modifiedby");
                this.SetRelatedEntities<msdyn_PostAlbum>("lk_msdyn_postalbum_modifiedby", null, value);
                this.OnPropertyChanged("lk_msdyn_postalbum_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_msdyn_postalbum_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_msdyn_postalbum_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<msdyn_PostAlbum> lk_msdyn_postalbum_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<msdyn_PostAlbum>("lk_msdyn_postalbum_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_msdyn_postalbum_modifiedonbehalfby");
                this.SetRelatedEntities<msdyn_PostAlbum>("lk_msdyn_postalbum_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_msdyn_postalbum_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_msdyn_postconfig_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_msdyn_postconfig_createdby")]
        public System.Collections.Generic.IEnumerable<msdyn_PostConfig> lk_msdyn_postconfig_createdby
        {
            get { return this.GetRelatedEntities<msdyn_PostConfig>("lk_msdyn_postconfig_createdby", null); }
            set
            {
                this.OnPropertyChanging("lk_msdyn_postconfig_createdby");
                this.SetRelatedEntities<msdyn_PostConfig>("lk_msdyn_postconfig_createdby", null, value);
                this.OnPropertyChanged("lk_msdyn_postconfig_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_msdyn_postconfig_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_msdyn_postconfig_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<msdyn_PostConfig> lk_msdyn_postconfig_createdonbehalfby
        {
            get { return this.GetRelatedEntities<msdyn_PostConfig>("lk_msdyn_postconfig_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_msdyn_postconfig_createdonbehalfby");
                this.SetRelatedEntities<msdyn_PostConfig>("lk_msdyn_postconfig_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_msdyn_postconfig_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_msdyn_postconfig_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_msdyn_postconfig_modifiedby")]
        public System.Collections.Generic.IEnumerable<msdyn_PostConfig> lk_msdyn_postconfig_modifiedby
        {
            get { return this.GetRelatedEntities<msdyn_PostConfig>("lk_msdyn_postconfig_modifiedby", null); }
            set
            {
                this.OnPropertyChanging("lk_msdyn_postconfig_modifiedby");
                this.SetRelatedEntities<msdyn_PostConfig>("lk_msdyn_postconfig_modifiedby", null, value);
                this.OnPropertyChanged("lk_msdyn_postconfig_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_msdyn_postconfig_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_msdyn_postconfig_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<msdyn_PostConfig> lk_msdyn_postconfig_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<msdyn_PostConfig>("lk_msdyn_postconfig_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_msdyn_postconfig_modifiedonbehalfby");
                this.SetRelatedEntities<msdyn_PostConfig>("lk_msdyn_postconfig_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_msdyn_postconfig_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_msdyn_postruleconfig_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_msdyn_postruleconfig_createdby")]
        public System.Collections.Generic.IEnumerable<msdyn_PostRuleConfig> lk_msdyn_postruleconfig_createdby
        {
            get { return this.GetRelatedEntities<msdyn_PostRuleConfig>("lk_msdyn_postruleconfig_createdby", null); }
            set
            {
                this.OnPropertyChanging("lk_msdyn_postruleconfig_createdby");
                this.SetRelatedEntities<msdyn_PostRuleConfig>("lk_msdyn_postruleconfig_createdby", null, value);
                this.OnPropertyChanged("lk_msdyn_postruleconfig_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_msdyn_postruleconfig_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_msdyn_postruleconfig_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<msdyn_PostRuleConfig> lk_msdyn_postruleconfig_createdonbehalfby
        {
            get { return this.GetRelatedEntities<msdyn_PostRuleConfig>("lk_msdyn_postruleconfig_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_msdyn_postruleconfig_createdonbehalfby");
                this.SetRelatedEntities<msdyn_PostRuleConfig>("lk_msdyn_postruleconfig_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_msdyn_postruleconfig_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_msdyn_postruleconfig_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_msdyn_postruleconfig_modifiedby")]
        public System.Collections.Generic.IEnumerable<msdyn_PostRuleConfig> lk_msdyn_postruleconfig_modifiedby
        {
            get { return this.GetRelatedEntities<msdyn_PostRuleConfig>("lk_msdyn_postruleconfig_modifiedby", null); }
            set
            {
                this.OnPropertyChanging("lk_msdyn_postruleconfig_modifiedby");
                this.SetRelatedEntities<msdyn_PostRuleConfig>("lk_msdyn_postruleconfig_modifiedby", null, value);
                this.OnPropertyChanged("lk_msdyn_postruleconfig_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_msdyn_postruleconfig_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_msdyn_postruleconfig_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<msdyn_PostRuleConfig> lk_msdyn_postruleconfig_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<msdyn_PostRuleConfig>("lk_msdyn_postruleconfig_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_msdyn_postruleconfig_modifiedonbehalfby");
                this.SetRelatedEntities<msdyn_PostRuleConfig>("lk_msdyn_postruleconfig_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_msdyn_postruleconfig_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_msdyn_wallsavedquery_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_msdyn_wallsavedquery_createdby")]
        public System.Collections.Generic.IEnumerable<msdyn_wallsavedquery> lk_msdyn_wallsavedquery_createdby
        {
            get { return this.GetRelatedEntities<msdyn_wallsavedquery>("lk_msdyn_wallsavedquery_createdby", null); }
            set
            {
                this.OnPropertyChanging("lk_msdyn_wallsavedquery_createdby");
                this.SetRelatedEntities<msdyn_wallsavedquery>("lk_msdyn_wallsavedquery_createdby", null, value);
                this.OnPropertyChanged("lk_msdyn_wallsavedquery_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_msdyn_wallsavedquery_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_msdyn_wallsavedquery_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<msdyn_wallsavedquery> lk_msdyn_wallsavedquery_createdonbehalfby
        {
            get { return this.GetRelatedEntities<msdyn_wallsavedquery>("lk_msdyn_wallsavedquery_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_msdyn_wallsavedquery_createdonbehalfby");
                this.SetRelatedEntities<msdyn_wallsavedquery>("lk_msdyn_wallsavedquery_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_msdyn_wallsavedquery_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_msdyn_wallsavedquery_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_msdyn_wallsavedquery_modifiedby")]
        public System.Collections.Generic.IEnumerable<msdyn_wallsavedquery> lk_msdyn_wallsavedquery_modifiedby
        {
            get { return this.GetRelatedEntities<msdyn_wallsavedquery>("lk_msdyn_wallsavedquery_modifiedby", null); }
            set
            {
                this.OnPropertyChanging("lk_msdyn_wallsavedquery_modifiedby");
                this.SetRelatedEntities<msdyn_wallsavedquery>("lk_msdyn_wallsavedquery_modifiedby", null, value);
                this.OnPropertyChanged("lk_msdyn_wallsavedquery_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_msdyn_wallsavedquery_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_msdyn_wallsavedquery_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<msdyn_wallsavedquery> lk_msdyn_wallsavedquery_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<msdyn_wallsavedquery>("lk_msdyn_wallsavedquery_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_msdyn_wallsavedquery_modifiedonbehalfby");
                this.SetRelatedEntities<msdyn_wallsavedquery>("lk_msdyn_wallsavedquery_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_msdyn_wallsavedquery_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_msdyn_wallsavedqueryusersettings_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_msdyn_wallsavedqueryusersettings_createdby")]
        public System.Collections.Generic.IEnumerable<msdyn_wallsavedqueryusersettings> lk_msdyn_wallsavedqueryusersettings_createdby
        {
            get { return this.GetRelatedEntities<msdyn_wallsavedqueryusersettings>("lk_msdyn_wallsavedqueryusersettings_createdby", null); }
            set
            {
                this.OnPropertyChanging("lk_msdyn_wallsavedqueryusersettings_createdby");
                this.SetRelatedEntities<msdyn_wallsavedqueryusersettings>("lk_msdyn_wallsavedqueryusersettings_createdby", null, value);
                this.OnPropertyChanged("lk_msdyn_wallsavedqueryusersettings_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_msdyn_wallsavedqueryusersettings_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_msdyn_wallsavedqueryusersettings_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<msdyn_wallsavedqueryusersettings> lk_msdyn_wallsavedqueryusersettings_createdonbehalfby
        {
            get { return this.GetRelatedEntities<msdyn_wallsavedqueryusersettings>("lk_msdyn_wallsavedqueryusersettings_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_msdyn_wallsavedqueryusersettings_createdonbehalfby");
                this.SetRelatedEntities<msdyn_wallsavedqueryusersettings>("lk_msdyn_wallsavedqueryusersettings_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_msdyn_wallsavedqueryusersettings_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_msdyn_wallsavedqueryusersettings_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_msdyn_wallsavedqueryusersettings_modifiedby")]
        public System.Collections.Generic.IEnumerable<msdyn_wallsavedqueryusersettings> lk_msdyn_wallsavedqueryusersettings_modifiedby
        {
            get { return this.GetRelatedEntities<msdyn_wallsavedqueryusersettings>("lk_msdyn_wallsavedqueryusersettings_modifiedby", null); }
            set
            {
                this.OnPropertyChanging("lk_msdyn_wallsavedqueryusersettings_modifiedby");
                this.SetRelatedEntities<msdyn_wallsavedqueryusersettings>("lk_msdyn_wallsavedqueryusersettings_modifiedby", null, value);
                this.OnPropertyChanged("lk_msdyn_wallsavedqueryusersettings_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_msdyn_wallsavedqueryusersettings_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_msdyn_wallsavedqueryusersettings_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<msdyn_wallsavedqueryusersettings> lk_msdyn_wallsavedqueryusersettings_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<msdyn_wallsavedqueryusersettings>("lk_msdyn_wallsavedqueryusersettings_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_msdyn_wallsavedqueryusersettings_modifiedonbehalfby");
                this.SetRelatedEntities<msdyn_wallsavedqueryusersettings>("lk_msdyn_wallsavedqueryusersettings_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_msdyn_wallsavedqueryusersettings_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_opportunity_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_opportunity_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<Opportunity> lk_opportunity_createdonbehalfby
        {
            get { return this.GetRelatedEntities<Opportunity>("lk_opportunity_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_opportunity_createdonbehalfby");
                this.SetRelatedEntities<Opportunity>("lk_opportunity_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_opportunity_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_opportunity_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_opportunity_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<Opportunity> lk_opportunity_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<Opportunity>("lk_opportunity_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_opportunity_modifiedonbehalfby");
                this.SetRelatedEntities<Opportunity>("lk_opportunity_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_opportunity_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_opportunitybase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_opportunitybase_createdby")]
        public System.Collections.Generic.IEnumerable<Opportunity> lk_opportunitybase_createdby
        {
            get { return this.GetRelatedEntities<Opportunity>("lk_opportunitybase_createdby", null); }
            set
            {
                this.OnPropertyChanging("lk_opportunitybase_createdby");
                this.SetRelatedEntities<Opportunity>("lk_opportunitybase_createdby", null, value);
                this.OnPropertyChanged("lk_opportunitybase_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_opportunitybase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_opportunitybase_modifiedby")]
        public System.Collections.Generic.IEnumerable<Opportunity> lk_opportunitybase_modifiedby
        {
            get { return this.GetRelatedEntities<Opportunity>("lk_opportunitybase_modifiedby", null); }
            set
            {
                this.OnPropertyChanging("lk_opportunitybase_modifiedby");
                this.SetRelatedEntities<Opportunity>("lk_opportunitybase_modifiedby", null, value);
                this.OnPropertyChanged("lk_opportunitybase_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_opportunityclose_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_opportunityclose_createdby")]
        public System.Collections.Generic.IEnumerable<OpportunityClose> lk_opportunityclose_createdby
        {
            get { return this.GetRelatedEntities<OpportunityClose>("lk_opportunityclose_createdby", null); }
            set
            {
                this.OnPropertyChanging("lk_opportunityclose_createdby");
                this.SetRelatedEntities<OpportunityClose>("lk_opportunityclose_createdby", null, value);
                this.OnPropertyChanged("lk_opportunityclose_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_opportunityclose_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_opportunityclose_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<OpportunityClose> lk_opportunityclose_createdonbehalfby
        {
            get { return this.GetRelatedEntities<OpportunityClose>("lk_opportunityclose_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_opportunityclose_createdonbehalfby");
                this.SetRelatedEntities<OpportunityClose>("lk_opportunityclose_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_opportunityclose_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_opportunityclose_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_opportunityclose_modifiedby")]
        public System.Collections.Generic.IEnumerable<OpportunityClose> lk_opportunityclose_modifiedby
        {
            get { return this.GetRelatedEntities<OpportunityClose>("lk_opportunityclose_modifiedby", null); }
            set
            {
                this.OnPropertyChanging("lk_opportunityclose_modifiedby");
                this.SetRelatedEntities<OpportunityClose>("lk_opportunityclose_modifiedby", null, value);
                this.OnPropertyChanged("lk_opportunityclose_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_opportunityclose_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_opportunityclose_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<OpportunityClose> lk_opportunityclose_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<OpportunityClose>("lk_opportunityclose_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_opportunityclose_modifiedonbehalfby");
                this.SetRelatedEntities<OpportunityClose>("lk_opportunityclose_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_opportunityclose_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_opportunityproduct_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_opportunityproduct_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<OpportunityProduct> lk_opportunityproduct_createdonbehalfby
        {
            get { return this.GetRelatedEntities<OpportunityProduct>("lk_opportunityproduct_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_opportunityproduct_createdonbehalfby");
                this.SetRelatedEntities<OpportunityProduct>("lk_opportunityproduct_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_opportunityproduct_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_opportunityproduct_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_opportunityproduct_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<OpportunityProduct> lk_opportunityproduct_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<OpportunityProduct>("lk_opportunityproduct_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_opportunityproduct_modifiedonbehalfby");
                this.SetRelatedEntities<OpportunityProduct>("lk_opportunityproduct_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_opportunityproduct_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_opportunityproductbase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_opportunityproductbase_createdby")]
        public System.Collections.Generic.IEnumerable<OpportunityProduct> lk_opportunityproductbase_createdby
        {
            get { return this.GetRelatedEntities<OpportunityProduct>("lk_opportunityproductbase_createdby", null); }
            set
            {
                this.OnPropertyChanging("lk_opportunityproductbase_createdby");
                this.SetRelatedEntities<OpportunityProduct>("lk_opportunityproductbase_createdby", null, value);
                this.OnPropertyChanged("lk_opportunityproductbase_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_opportunityproductbase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_opportunityproductbase_modifiedby")]
        public System.Collections.Generic.IEnumerable<OpportunityProduct> lk_opportunityproductbase_modifiedby
        {
            get { return this.GetRelatedEntities<OpportunityProduct>("lk_opportunityproductbase_modifiedby", null); }
            set
            {
                this.OnPropertyChanging("lk_opportunityproductbase_modifiedby");
                this.SetRelatedEntities<OpportunityProduct>("lk_opportunityproductbase_modifiedby", null, value);
                this.OnPropertyChanged("lk_opportunityproductbase_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_orderclose_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_orderclose_createdby")]
        public System.Collections.Generic.IEnumerable<OrderClose> lk_orderclose_createdby
        {
            get { return this.GetRelatedEntities<OrderClose>("lk_orderclose_createdby", null); }
            set
            {
                this.OnPropertyChanging("lk_orderclose_createdby");
                this.SetRelatedEntities<OrderClose>("lk_orderclose_createdby", null, value);
                this.OnPropertyChanged("lk_orderclose_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_orderclose_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_orderclose_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<OrderClose> lk_orderclose_createdonbehalfby
        {
            get { return this.GetRelatedEntities<OrderClose>("lk_orderclose_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_orderclose_createdonbehalfby");
                this.SetRelatedEntities<OrderClose>("lk_orderclose_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_orderclose_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_orderclose_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_orderclose_modifiedby")]
        public System.Collections.Generic.IEnumerable<OrderClose> lk_orderclose_modifiedby
        {
            get { return this.GetRelatedEntities<OrderClose>("lk_orderclose_modifiedby", null); }
            set
            {
                this.OnPropertyChanging("lk_orderclose_modifiedby");
                this.SetRelatedEntities<OrderClose>("lk_orderclose_modifiedby", null, value);
                this.OnPropertyChanged("lk_orderclose_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_orderclose_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_orderclose_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<OrderClose> lk_orderclose_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<OrderClose>("lk_orderclose_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_orderclose_modifiedonbehalfby");
                this.SetRelatedEntities<OrderClose>("lk_orderclose_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_orderclose_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_organization_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_organization_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<Organization> lk_organization_createdonbehalfby
        {
            get { return this.GetRelatedEntities<Organization>("lk_organization_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_organization_createdonbehalfby");
                this.SetRelatedEntities<Organization>("lk_organization_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_organization_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_organization_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_organization_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<Organization> lk_organization_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<Organization>("lk_organization_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_organization_modifiedonbehalfby");
                this.SetRelatedEntities<Organization>("lk_organization_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_organization_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_organizationbase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_organizationbase_createdby")]
        public System.Collections.Generic.IEnumerable<Organization> lk_organizationbase_createdby
        {
            get { return this.GetRelatedEntities<Organization>("lk_organizationbase_createdby", null); }
            set
            {
                this.OnPropertyChanging("lk_organizationbase_createdby");
                this.SetRelatedEntities<Organization>("lk_organizationbase_createdby", null, value);
                this.OnPropertyChanged("lk_organizationbase_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_organizationbase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_organizationbase_modifiedby")]
        public System.Collections.Generic.IEnumerable<Organization> lk_organizationbase_modifiedby
        {
            get { return this.GetRelatedEntities<Organization>("lk_organizationbase_modifiedby", null); }
            set
            {
                this.OnPropertyChanging("lk_organizationbase_modifiedby");
                this.SetRelatedEntities<Organization>("lk_organizationbase_modifiedby", null, value);
                this.OnPropertyChanged("lk_organizationbase_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_ownermapping_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ownermapping_createdby")]
        public System.Collections.Generic.IEnumerable<OwnerMapping> lk_ownermapping_createdby
        {
            get { return this.GetRelatedEntities<OwnerMapping>("lk_ownermapping_createdby", null); }
            set
            {
                this.OnPropertyChanging("lk_ownermapping_createdby");
                this.SetRelatedEntities<OwnerMapping>("lk_ownermapping_createdby", null, value);
                this.OnPropertyChanged("lk_ownermapping_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_ownermapping_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ownermapping_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<OwnerMapping> lk_ownermapping_createdonbehalfby
        {
            get { return this.GetRelatedEntities<OwnerMapping>("lk_ownermapping_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_ownermapping_createdonbehalfby");
                this.SetRelatedEntities<OwnerMapping>("lk_ownermapping_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_ownermapping_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_ownermapping_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ownermapping_modifiedby")]
        public System.Collections.Generic.IEnumerable<OwnerMapping> lk_ownermapping_modifiedby
        {
            get { return this.GetRelatedEntities<OwnerMapping>("lk_ownermapping_modifiedby", null); }
            set
            {
                this.OnPropertyChanging("lk_ownermapping_modifiedby");
                this.SetRelatedEntities<OwnerMapping>("lk_ownermapping_modifiedby", null, value);
                this.OnPropertyChanged("lk_ownermapping_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_ownermapping_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ownermapping_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<OwnerMapping> lk_ownermapping_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<OwnerMapping>("lk_ownermapping_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_ownermapping_modifiedonbehalfby");
                this.SetRelatedEntities<OwnerMapping>("lk_ownermapping_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_ownermapping_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_phonecall_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_phonecall_createdby")]
        public System.Collections.Generic.IEnumerable<PhoneCall> lk_phonecall_createdby
        {
            get { return this.GetRelatedEntities<PhoneCall>("lk_phonecall_createdby", null); }
            set
            {
                this.OnPropertyChanging("lk_phonecall_createdby");
                this.SetRelatedEntities<PhoneCall>("lk_phonecall_createdby", null, value);
                this.OnPropertyChanged("lk_phonecall_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_phonecall_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_phonecall_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<PhoneCall> lk_phonecall_createdonbehalfby
        {
            get { return this.GetRelatedEntities<PhoneCall>("lk_phonecall_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_phonecall_createdonbehalfby");
                this.SetRelatedEntities<PhoneCall>("lk_phonecall_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_phonecall_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_phonecall_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_phonecall_modifiedby")]
        public System.Collections.Generic.IEnumerable<PhoneCall> lk_phonecall_modifiedby
        {
            get { return this.GetRelatedEntities<PhoneCall>("lk_phonecall_modifiedby", null); }
            set
            {
                this.OnPropertyChanging("lk_phonecall_modifiedby");
                this.SetRelatedEntities<PhoneCall>("lk_phonecall_modifiedby", null, value);
                this.OnPropertyChanged("lk_phonecall_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_phonecall_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_phonecall_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<PhoneCall> lk_phonecall_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<PhoneCall>("lk_phonecall_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_phonecall_modifiedonbehalfby");
                this.SetRelatedEntities<PhoneCall>("lk_phonecall_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_phonecall_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_picklistmapping_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_picklistmapping_createdby")]
        public System.Collections.Generic.IEnumerable<PickListMapping> lk_picklistmapping_createdby
        {
            get { return this.GetRelatedEntities<PickListMapping>("lk_picklistmapping_createdby", null); }
            set
            {
                this.OnPropertyChanging("lk_picklistmapping_createdby");
                this.SetRelatedEntities<PickListMapping>("lk_picklistmapping_createdby", null, value);
                this.OnPropertyChanged("lk_picklistmapping_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_picklistmapping_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_picklistmapping_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<PickListMapping> lk_picklistmapping_createdonbehalfby
        {
            get { return this.GetRelatedEntities<PickListMapping>("lk_picklistmapping_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_picklistmapping_createdonbehalfby");
                this.SetRelatedEntities<PickListMapping>("lk_picklistmapping_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_picklistmapping_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_picklistmapping_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_picklistmapping_modifiedby")]
        public System.Collections.Generic.IEnumerable<PickListMapping> lk_picklistmapping_modifiedby
        {
            get { return this.GetRelatedEntities<PickListMapping>("lk_picklistmapping_modifiedby", null); }
            set
            {
                this.OnPropertyChanging("lk_picklistmapping_modifiedby");
                this.SetRelatedEntities<PickListMapping>("lk_picklistmapping_modifiedby", null, value);
                this.OnPropertyChanged("lk_picklistmapping_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_picklistmapping_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_picklistmapping_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<PickListMapping> lk_picklistmapping_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<PickListMapping>("lk_picklistmapping_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_picklistmapping_modifiedonbehalfby");
                this.SetRelatedEntities<PickListMapping>("lk_picklistmapping_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_picklistmapping_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_pluginassembly_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_pluginassembly_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<PluginAssembly> lk_pluginassembly_createdonbehalfby
        {
            get { return this.GetRelatedEntities<PluginAssembly>("lk_pluginassembly_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_pluginassembly_createdonbehalfby");
                this.SetRelatedEntities<PluginAssembly>("lk_pluginassembly_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_pluginassembly_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_pluginassembly_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_pluginassembly_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<PluginAssembly> lk_pluginassembly_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<PluginAssembly>("lk_pluginassembly_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_pluginassembly_modifiedonbehalfby");
                this.SetRelatedEntities<PluginAssembly>("lk_pluginassembly_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_pluginassembly_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_plugintype_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_plugintype_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<PluginType> lk_plugintype_createdonbehalfby
        {
            get { return this.GetRelatedEntities<PluginType>("lk_plugintype_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_plugintype_createdonbehalfby");
                this.SetRelatedEntities<PluginType>("lk_plugintype_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_plugintype_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_plugintype_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_plugintype_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<PluginType> lk_plugintype_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<PluginType>("lk_plugintype_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_plugintype_modifiedonbehalfby");
                this.SetRelatedEntities<PluginType>("lk_plugintype_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_plugintype_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_plugintypestatisticbase_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_plugintypestatisticbase_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<PluginTypeStatistic> lk_plugintypestatisticbase_createdonbehalfby
        {
            get { return this.GetRelatedEntities<PluginTypeStatistic>("lk_plugintypestatisticbase_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_plugintypestatisticbase_createdonbehalfby");
                this.SetRelatedEntities<PluginTypeStatistic>("lk_plugintypestatisticbase_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_plugintypestatisticbase_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_plugintypestatisticbase_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_plugintypestatisticbase_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<PluginTypeStatistic> lk_plugintypestatisticbase_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<PluginTypeStatistic>("lk_plugintypestatisticbase_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_plugintypestatisticbase_modifiedonbehalfby");
                this.SetRelatedEntities<PluginTypeStatistic>("lk_plugintypestatisticbase_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_plugintypestatisticbase_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_position_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_position_createdby")]
        public System.Collections.Generic.IEnumerable<Position> lk_position_createdby
        {
            get { return this.GetRelatedEntities<Position>("lk_position_createdby", null); }
            set
            {
                this.OnPropertyChanging("lk_position_createdby");
                this.SetRelatedEntities<Position>("lk_position_createdby", null, value);
                this.OnPropertyChanged("lk_position_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_position_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_position_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<Position> lk_position_createdonbehalfby
        {
            get { return this.GetRelatedEntities<Position>("lk_position_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_position_createdonbehalfby");
                this.SetRelatedEntities<Position>("lk_position_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_position_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_position_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_position_modifiedby")]
        public System.Collections.Generic.IEnumerable<Position> lk_position_modifiedby
        {
            get { return this.GetRelatedEntities<Position>("lk_position_modifiedby", null); }
            set
            {
                this.OnPropertyChanging("lk_position_modifiedby");
                this.SetRelatedEntities<Position>("lk_position_modifiedby", null, value);
                this.OnPropertyChanged("lk_position_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_position_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_position_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<Position> lk_position_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<Position>("lk_position_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_position_modifiedonbehalfby");
                this.SetRelatedEntities<Position>("lk_position_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_position_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_post_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_post_createdby")]
        public System.Collections.Generic.IEnumerable<Post> lk_post_createdby
        {
            get { return this.GetRelatedEntities<Post>("lk_post_createdby", null); }
            set
            {
                this.OnPropertyChanging("lk_post_createdby");
                this.SetRelatedEntities<Post>("lk_post_createdby", null, value);
                this.OnPropertyChanged("lk_post_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_post_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_post_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<Post> lk_post_createdonbehalfby
        {
            get { return this.GetRelatedEntities<Post>("lk_post_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_post_createdonbehalfby");
                this.SetRelatedEntities<Post>("lk_post_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_post_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_post_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_post_modifiedby")]
        public System.Collections.Generic.IEnumerable<Post> lk_post_modifiedby
        {
            get { return this.GetRelatedEntities<Post>("lk_post_modifiedby", null); }
            set
            {
                this.OnPropertyChanging("lk_post_modifiedby");
                this.SetRelatedEntities<Post>("lk_post_modifiedby", null, value);
                this.OnPropertyChanged("lk_post_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_post_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_post_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<Post> lk_post_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<Post>("lk_post_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_post_modifiedonbehalfby");
                this.SetRelatedEntities<Post>("lk_post_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_post_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_postcomment_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_postcomment_createdby")]
        public System.Collections.Generic.IEnumerable<PostComment> lk_postcomment_createdby
        {
            get { return this.GetRelatedEntities<PostComment>("lk_postcomment_createdby", null); }
            set
            {
                this.OnPropertyChanging("lk_postcomment_createdby");
                this.SetRelatedEntities<PostComment>("lk_postcomment_createdby", null, value);
                this.OnPropertyChanged("lk_postcomment_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_postcomment_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_postcomment_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<PostComment> lk_postcomment_createdonbehalfby
        {
            get { return this.GetRelatedEntities<PostComment>("lk_postcomment_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_postcomment_createdonbehalfby");
                this.SetRelatedEntities<PostComment>("lk_postcomment_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_postcomment_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_PostFollow_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_PostFollow_createdby")]
        public System.Collections.Generic.IEnumerable<PostFollow> lk_PostFollow_createdby
        {
            get { return this.GetRelatedEntities<PostFollow>("lk_PostFollow_createdby", null); }
            set
            {
                this.OnPropertyChanging("lk_PostFollow_createdby");
                this.SetRelatedEntities<PostFollow>("lk_PostFollow_createdby", null, value);
                this.OnPropertyChanged("lk_PostFollow_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_postfollow_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_postfollow_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<PostFollow> lk_postfollow_createdonbehalfby
        {
            get { return this.GetRelatedEntities<PostFollow>("lk_postfollow_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_postfollow_createdonbehalfby");
                this.SetRelatedEntities<PostFollow>("lk_postfollow_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_postfollow_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_postlike_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_postlike_createdby")]
        public System.Collections.Generic.IEnumerable<PostLike> lk_postlike_createdby
        {
            get { return this.GetRelatedEntities<PostLike>("lk_postlike_createdby", null); }
            set
            {
                this.OnPropertyChanging("lk_postlike_createdby");
                this.SetRelatedEntities<PostLike>("lk_postlike_createdby", null, value);
                this.OnPropertyChanged("lk_postlike_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_postlike_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_postlike_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<PostLike> lk_postlike_createdonbehalfby
        {
            get { return this.GetRelatedEntities<PostLike>("lk_postlike_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_postlike_createdonbehalfby");
                this.SetRelatedEntities<PostLike>("lk_postlike_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_postlike_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_pricelevel_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_pricelevel_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<PriceLevel> lk_pricelevel_createdonbehalfby
        {
            get { return this.GetRelatedEntities<PriceLevel>("lk_pricelevel_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_pricelevel_createdonbehalfby");
                this.SetRelatedEntities<PriceLevel>("lk_pricelevel_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_pricelevel_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_pricelevel_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_pricelevel_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<PriceLevel> lk_pricelevel_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<PriceLevel>("lk_pricelevel_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_pricelevel_modifiedonbehalfby");
                this.SetRelatedEntities<PriceLevel>("lk_pricelevel_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_pricelevel_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_pricelevelbase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_pricelevelbase_createdby")]
        public System.Collections.Generic.IEnumerable<PriceLevel> lk_pricelevelbase_createdby
        {
            get { return this.GetRelatedEntities<PriceLevel>("lk_pricelevelbase_createdby", null); }
            set
            {
                this.OnPropertyChanging("lk_pricelevelbase_createdby");
                this.SetRelatedEntities<PriceLevel>("lk_pricelevelbase_createdby", null, value);
                this.OnPropertyChanged("lk_pricelevelbase_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_pricelevelbase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_pricelevelbase_modifiedby")]
        public System.Collections.Generic.IEnumerable<PriceLevel> lk_pricelevelbase_modifiedby
        {
            get { return this.GetRelatedEntities<PriceLevel>("lk_pricelevelbase_modifiedby", null); }
            set
            {
                this.OnPropertyChanging("lk_pricelevelbase_modifiedby");
                this.SetRelatedEntities<PriceLevel>("lk_pricelevelbase_modifiedby", null, value);
                this.OnPropertyChanged("lk_pricelevelbase_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_processsession_canceledby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_processsession_canceledby")]
        public System.Collections.Generic.IEnumerable<ProcessSession> lk_processsession_canceledby
        {
            get { return this.GetRelatedEntities<ProcessSession>("lk_processsession_canceledby", null); }
            set
            {
                this.OnPropertyChanging("lk_processsession_canceledby");
                this.SetRelatedEntities<ProcessSession>("lk_processsession_canceledby", null, value);
                this.OnPropertyChanged("lk_processsession_canceledby");
            }
        }

        /// <summary>
        /// 1:N lk_processsession_completedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_processsession_completedby")]
        public System.Collections.Generic.IEnumerable<ProcessSession> lk_processsession_completedby
        {
            get { return this.GetRelatedEntities<ProcessSession>("lk_processsession_completedby", null); }
            set
            {
                this.OnPropertyChanging("lk_processsession_completedby");
                this.SetRelatedEntities<ProcessSession>("lk_processsession_completedby", null, value);
                this.OnPropertyChanged("lk_processsession_completedby");
            }
        }

        /// <summary>
        /// 1:N lk_processsession_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_processsession_createdby")]
        public System.Collections.Generic.IEnumerable<ProcessSession> lk_processsession_createdby
        {
            get { return this.GetRelatedEntities<ProcessSession>("lk_processsession_createdby", null); }
            set
            {
                this.OnPropertyChanging("lk_processsession_createdby");
                this.SetRelatedEntities<ProcessSession>("lk_processsession_createdby", null, value);
                this.OnPropertyChanged("lk_processsession_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_processsession_executedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_processsession_executedby")]
        public System.Collections.Generic.IEnumerable<ProcessSession> lk_processsession_executedby
        {
            get { return this.GetRelatedEntities<ProcessSession>("lk_processsession_executedby", null); }
            set
            {
                this.OnPropertyChanging("lk_processsession_executedby");
                this.SetRelatedEntities<ProcessSession>("lk_processsession_executedby", null, value);
                this.OnPropertyChanged("lk_processsession_executedby");
            }
        }

        /// <summary>
        /// 1:N lk_processsession_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_processsession_modifiedby")]
        public System.Collections.Generic.IEnumerable<ProcessSession> lk_processsession_modifiedby
        {
            get { return this.GetRelatedEntities<ProcessSession>("lk_processsession_modifiedby", null); }
            set
            {
                this.OnPropertyChanging("lk_processsession_modifiedby");
                this.SetRelatedEntities<ProcessSession>("lk_processsession_modifiedby", null, value);
                this.OnPropertyChanged("lk_processsession_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_processsession_startedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_processsession_startedby")]
        public System.Collections.Generic.IEnumerable<ProcessSession> lk_processsession_startedby
        {
            get { return this.GetRelatedEntities<ProcessSession>("lk_processsession_startedby", null); }
            set
            {
                this.OnPropertyChanging("lk_processsession_startedby");
                this.SetRelatedEntities<ProcessSession>("lk_processsession_startedby", null, value);
                this.OnPropertyChanged("lk_processsession_startedby");
            }
        }

        /// <summary>
        /// 1:N lk_processsessionbase_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_processsessionbase_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<ProcessSession> lk_processsessionbase_createdonbehalfby
        {
            get { return this.GetRelatedEntities<ProcessSession>("lk_processsessionbase_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_processsessionbase_createdonbehalfby");
                this.SetRelatedEntities<ProcessSession>("lk_processsessionbase_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_processsessionbase_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_processsessionbase_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_processsessionbase_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<ProcessSession> lk_processsessionbase_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<ProcessSession>("lk_processsessionbase_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_processsessionbase_modifiedonbehalfby");
                this.SetRelatedEntities<ProcessSession>("lk_processsessionbase_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_processsessionbase_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_processtriggerbase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_processtriggerbase_createdby")]
        public System.Collections.Generic.IEnumerable<ProcessTrigger> lk_processtriggerbase_createdby
        {
            get { return this.GetRelatedEntities<ProcessTrigger>("lk_processtriggerbase_createdby", null); }
            set
            {
                this.OnPropertyChanging("lk_processtriggerbase_createdby");
                this.SetRelatedEntities<ProcessTrigger>("lk_processtriggerbase_createdby", null, value);
                this.OnPropertyChanged("lk_processtriggerbase_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_processtriggerbase_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_processtriggerbase_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<ProcessTrigger> lk_processtriggerbase_createdonbehalfby
        {
            get { return this.GetRelatedEntities<ProcessTrigger>("lk_processtriggerbase_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_processtriggerbase_createdonbehalfby");
                this.SetRelatedEntities<ProcessTrigger>("lk_processtriggerbase_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_processtriggerbase_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_processtriggerbase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_processtriggerbase_modifiedby")]
        public System.Collections.Generic.IEnumerable<ProcessTrigger> lk_processtriggerbase_modifiedby
        {
            get { return this.GetRelatedEntities<ProcessTrigger>("lk_processtriggerbase_modifiedby", null); }
            set
            {
                this.OnPropertyChanging("lk_processtriggerbase_modifiedby");
                this.SetRelatedEntities<ProcessTrigger>("lk_processtriggerbase_modifiedby", null, value);
                this.OnPropertyChanged("lk_processtriggerbase_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_processtriggerbase_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_processtriggerbase_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<ProcessTrigger> lk_processtriggerbase_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<ProcessTrigger>("lk_processtriggerbase_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_processtriggerbase_modifiedonbehalfby");
                this.SetRelatedEntities<ProcessTrigger>("lk_processtriggerbase_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_processtriggerbase_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_product_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_product_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<Product> lk_product_createdonbehalfby
        {
            get { return this.GetRelatedEntities<Product>("lk_product_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_product_createdonbehalfby");
                this.SetRelatedEntities<Product>("lk_product_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_product_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_product_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_product_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<Product> lk_product_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<Product>("lk_product_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_product_modifiedonbehalfby");
                this.SetRelatedEntities<Product>("lk_product_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_product_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_ProductAssociate_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ProductAssociate_createdby")]
        public System.Collections.Generic.IEnumerable<ProductAssociation> lk_ProductAssociate_createdby
        {
            get { return this.GetRelatedEntities<ProductAssociation>("lk_ProductAssociate_createdby", null); }
            set
            {
                this.OnPropertyChanging("lk_ProductAssociate_createdby");
                this.SetRelatedEntities<ProductAssociation>("lk_ProductAssociate_createdby", null, value);
                this.OnPropertyChanged("lk_ProductAssociate_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_ProductAssociation_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ProductAssociation_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<ProductAssociation> lk_ProductAssociation_createdonbehalfby
        {
            get { return this.GetRelatedEntities<ProductAssociation>("lk_ProductAssociation_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_ProductAssociation_createdonbehalfby");
                this.SetRelatedEntities<ProductAssociation>("lk_ProductAssociation_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_ProductAssociation_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_ProductAssociation_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ProductAssociation_modifiedby")]
        public System.Collections.Generic.IEnumerable<ProductAssociation> lk_ProductAssociation_modifiedby
        {
            get { return this.GetRelatedEntities<ProductAssociation>("lk_ProductAssociation_modifiedby", null); }
            set
            {
                this.OnPropertyChanging("lk_ProductAssociation_modifiedby");
                this.SetRelatedEntities<ProductAssociation>("lk_ProductAssociation_modifiedby", null, value);
                this.OnPropertyChanged("lk_ProductAssociation_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_ProductAssociation_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ProductAssociation_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<ProductAssociation> lk_ProductAssociation_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<ProductAssociation>("lk_ProductAssociation_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_ProductAssociation_modifiedonbehalfby");
                this.SetRelatedEntities<ProductAssociation>("lk_ProductAssociation_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_ProductAssociation_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_productbase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_productbase_createdby")]
        public System.Collections.Generic.IEnumerable<Product> lk_productbase_createdby
        {
            get { return this.GetRelatedEntities<Product>("lk_productbase_createdby", null); }
            set
            {
                this.OnPropertyChanging("lk_productbase_createdby");
                this.SetRelatedEntities<Product>("lk_productbase_createdby", null, value);
                this.OnPropertyChanged("lk_productbase_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_productbase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_productbase_modifiedby")]
        public System.Collections.Generic.IEnumerable<Product> lk_productbase_modifiedby
        {
            get { return this.GetRelatedEntities<Product>("lk_productbase_modifiedby", null); }
            set
            {
                this.OnPropertyChanging("lk_productbase_modifiedby");
                this.SetRelatedEntities<Product>("lk_productbase_modifiedby", null, value);
                this.OnPropertyChanged("lk_productbase_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_productpricelevel_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_productpricelevel_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<ProductPriceLevel> lk_productpricelevel_createdonbehalfby
        {
            get { return this.GetRelatedEntities<ProductPriceLevel>("lk_productpricelevel_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_productpricelevel_createdonbehalfby");
                this.SetRelatedEntities<ProductPriceLevel>("lk_productpricelevel_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_productpricelevel_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_productpricelevel_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_productpricelevel_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<ProductPriceLevel> lk_productpricelevel_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<ProductPriceLevel>("lk_productpricelevel_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_productpricelevel_modifiedonbehalfby");
                this.SetRelatedEntities<ProductPriceLevel>("lk_productpricelevel_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_productpricelevel_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_productpricelevelbase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_productpricelevelbase_createdby")]
        public System.Collections.Generic.IEnumerable<ProductPriceLevel> lk_productpricelevelbase_createdby
        {
            get { return this.GetRelatedEntities<ProductPriceLevel>("lk_productpricelevelbase_createdby", null); }
            set
            {
                this.OnPropertyChanging("lk_productpricelevelbase_createdby");
                this.SetRelatedEntities<ProductPriceLevel>("lk_productpricelevelbase_createdby", null, value);
                this.OnPropertyChanged("lk_productpricelevelbase_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_productpricelevelbase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_productpricelevelbase_modifiedby")]
        public System.Collections.Generic.IEnumerable<ProductPriceLevel> lk_productpricelevelbase_modifiedby
        {
            get { return this.GetRelatedEntities<ProductPriceLevel>("lk_productpricelevelbase_modifiedby", null); }
            set
            {
                this.OnPropertyChanging("lk_productpricelevelbase_modifiedby");
                this.SetRelatedEntities<ProductPriceLevel>("lk_productpricelevelbase_modifiedby", null, value);
                this.OnPropertyChanged("lk_productpricelevelbase_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_ProductSubstitute_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ProductSubstitute_createdby")]
        public System.Collections.Generic.IEnumerable<ProductSubstitute> lk_ProductSubstitute_createdby
        {
            get { return this.GetRelatedEntities<ProductSubstitute>("lk_ProductSubstitute_createdby", null); }
            set
            {
                this.OnPropertyChanging("lk_ProductSubstitute_createdby");
                this.SetRelatedEntities<ProductSubstitute>("lk_ProductSubstitute_createdby", null, value);
                this.OnPropertyChanged("lk_ProductSubstitute_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_ProductSubstitute_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ProductSubstitute_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<ProductSubstitute> lk_ProductSubstitute_createdonbehalfby
        {
            get { return this.GetRelatedEntities<ProductSubstitute>("lk_ProductSubstitute_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_ProductSubstitute_createdonbehalfby");
                this.SetRelatedEntities<ProductSubstitute>("lk_ProductSubstitute_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_ProductSubstitute_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_ProductSubstitute_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ProductSubstitute_modifiedby")]
        public System.Collections.Generic.IEnumerable<ProductSubstitute> lk_ProductSubstitute_modifiedby
        {
            get { return this.GetRelatedEntities<ProductSubstitute>("lk_ProductSubstitute_modifiedby", null); }
            set
            {
                this.OnPropertyChanging("lk_ProductSubstitute_modifiedby");
                this.SetRelatedEntities<ProductSubstitute>("lk_ProductSubstitute_modifiedby", null, value);
                this.OnPropertyChanged("lk_ProductSubstitute_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_ProductSubstitute_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ProductSubstitute_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<ProductSubstitute> lk_ProductSubstitute_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<ProductSubstitute>("lk_ProductSubstitute_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_ProductSubstitute_modifiedonbehalfby");
                this.SetRelatedEntities<ProductSubstitute>("lk_ProductSubstitute_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_ProductSubstitute_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_publisher_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_publisher_createdby")]
        public System.Collections.Generic.IEnumerable<Publisher> lk_publisher_createdby
        {
            get { return this.GetRelatedEntities<Publisher>("lk_publisher_createdby", null); }
            set
            {
                this.OnPropertyChanging("lk_publisher_createdby");
                this.SetRelatedEntities<Publisher>("lk_publisher_createdby", null, value);
                this.OnPropertyChanged("lk_publisher_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_publisher_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_publisher_modifiedby")]
        public System.Collections.Generic.IEnumerable<Publisher> lk_publisher_modifiedby
        {
            get { return this.GetRelatedEntities<Publisher>("lk_publisher_modifiedby", null); }
            set
            {
                this.OnPropertyChanging("lk_publisher_modifiedby");
                this.SetRelatedEntities<Publisher>("lk_publisher_modifiedby", null, value);
                this.OnPropertyChanged("lk_publisher_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_publisheraddressbase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_publisheraddressbase_createdby")]
        public System.Collections.Generic.IEnumerable<PublisherAddress> lk_publisheraddressbase_createdby
        {
            get { return this.GetRelatedEntities<PublisherAddress>("lk_publisheraddressbase_createdby", null); }
            set
            {
                this.OnPropertyChanging("lk_publisheraddressbase_createdby");
                this.SetRelatedEntities<PublisherAddress>("lk_publisheraddressbase_createdby", null, value);
                this.OnPropertyChanged("lk_publisheraddressbase_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_publisheraddressbase_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_publisheraddressbase_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<PublisherAddress> lk_publisheraddressbase_createdonbehalfby
        {
            get { return this.GetRelatedEntities<PublisherAddress>("lk_publisheraddressbase_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_publisheraddressbase_createdonbehalfby");
                this.SetRelatedEntities<PublisherAddress>("lk_publisheraddressbase_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_publisheraddressbase_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_publisheraddressbase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_publisheraddressbase_modifiedby")]
        public System.Collections.Generic.IEnumerable<PublisherAddress> lk_publisheraddressbase_modifiedby
        {
            get { return this.GetRelatedEntities<PublisherAddress>("lk_publisheraddressbase_modifiedby", null); }
            set
            {
                this.OnPropertyChanging("lk_publisheraddressbase_modifiedby");
                this.SetRelatedEntities<PublisherAddress>("lk_publisheraddressbase_modifiedby", null, value);
                this.OnPropertyChanged("lk_publisheraddressbase_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_publisheraddressbase_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_publisheraddressbase_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<PublisherAddress> lk_publisheraddressbase_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<PublisherAddress>("lk_publisheraddressbase_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_publisheraddressbase_modifiedonbehalfby");
                this.SetRelatedEntities<PublisherAddress>("lk_publisheraddressbase_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_publisheraddressbase_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_publisherbase_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_publisherbase_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<Publisher> lk_publisherbase_createdonbehalfby
        {
            get { return this.GetRelatedEntities<Publisher>("lk_publisherbase_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_publisherbase_createdonbehalfby");
                this.SetRelatedEntities<Publisher>("lk_publisherbase_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_publisherbase_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_publisherbase_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_publisherbase_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<Publisher> lk_publisherbase_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<Publisher>("lk_publisherbase_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_publisherbase_modifiedonbehalfby");
                this.SetRelatedEntities<Publisher>("lk_publisherbase_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_publisherbase_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_quarterlyfiscalcalendar_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_quarterlyfiscalcalendar_createdby")]
        public System.Collections.Generic.IEnumerable<QuarterlyFiscalCalendar> lk_quarterlyfiscalcalendar_createdby
        {
            get { return this.GetRelatedEntities<QuarterlyFiscalCalendar>("lk_quarterlyfiscalcalendar_createdby", null); }
            set
            {
                this.OnPropertyChanging("lk_quarterlyfiscalcalendar_createdby");
                this.SetRelatedEntities<QuarterlyFiscalCalendar>("lk_quarterlyfiscalcalendar_createdby", null, value);
                this.OnPropertyChanged("lk_quarterlyfiscalcalendar_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_quarterlyfiscalcalendar_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_quarterlyfiscalcalendar_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<QuarterlyFiscalCalendar> lk_quarterlyfiscalcalendar_createdonbehalfby
        {
            get { return this.GetRelatedEntities<QuarterlyFiscalCalendar>("lk_quarterlyfiscalcalendar_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_quarterlyfiscalcalendar_createdonbehalfby");
                this.SetRelatedEntities<QuarterlyFiscalCalendar>("lk_quarterlyfiscalcalendar_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_quarterlyfiscalcalendar_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_quarterlyfiscalcalendar_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_quarterlyfiscalcalendar_modifiedby")]
        public System.Collections.Generic.IEnumerable<QuarterlyFiscalCalendar> lk_quarterlyfiscalcalendar_modifiedby
        {
            get { return this.GetRelatedEntities<QuarterlyFiscalCalendar>("lk_quarterlyfiscalcalendar_modifiedby", null); }
            set
            {
                this.OnPropertyChanging("lk_quarterlyfiscalcalendar_modifiedby");
                this.SetRelatedEntities<QuarterlyFiscalCalendar>("lk_quarterlyfiscalcalendar_modifiedby", null, value);
                this.OnPropertyChanged("lk_quarterlyfiscalcalendar_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_quarterlyfiscalcalendar_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_quarterlyfiscalcalendar_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<QuarterlyFiscalCalendar> lk_quarterlyfiscalcalendar_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<QuarterlyFiscalCalendar>("lk_quarterlyfiscalcalendar_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_quarterlyfiscalcalendar_modifiedonbehalfby");
                this.SetRelatedEntities<QuarterlyFiscalCalendar>("lk_quarterlyfiscalcalendar_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_quarterlyfiscalcalendar_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_quarterlyfiscalcalendar_salespersonid
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_quarterlyfiscalcalendar_salespersonid")]
        public System.Collections.Generic.IEnumerable<QuarterlyFiscalCalendar> lk_quarterlyfiscalcalendar_salespersonid
        {
            get { return this.GetRelatedEntities<QuarterlyFiscalCalendar>("lk_quarterlyfiscalcalendar_salespersonid", null); }
            set
            {
                this.OnPropertyChanging("lk_quarterlyfiscalcalendar_salespersonid");
                this.SetRelatedEntities<QuarterlyFiscalCalendar>("lk_quarterlyfiscalcalendar_salespersonid", null, value);
                this.OnPropertyChanged("lk_quarterlyfiscalcalendar_salespersonid");
            }
        }

        /// <summary>
        /// 1:N lk_queue_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_queue_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<Queue> lk_queue_createdonbehalfby
        {
            get { return this.GetRelatedEntities<Queue>("lk_queue_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_queue_createdonbehalfby");
                this.SetRelatedEntities<Queue>("lk_queue_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_queue_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_queue_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_queue_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<Queue> lk_queue_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<Queue>("lk_queue_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_queue_modifiedonbehalfby");
                this.SetRelatedEntities<Queue>("lk_queue_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_queue_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_queuebase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_queuebase_createdby")]
        public System.Collections.Generic.IEnumerable<Queue> lk_queuebase_createdby
        {
            get { return this.GetRelatedEntities<Queue>("lk_queuebase_createdby", null); }
            set
            {
                this.OnPropertyChanging("lk_queuebase_createdby");
                this.SetRelatedEntities<Queue>("lk_queuebase_createdby", null, value);
                this.OnPropertyChanged("lk_queuebase_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_queuebase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_queuebase_modifiedby")]
        public System.Collections.Generic.IEnumerable<Queue> lk_queuebase_modifiedby
        {
            get { return this.GetRelatedEntities<Queue>("lk_queuebase_modifiedby", null); }
            set
            {
                this.OnPropertyChanging("lk_queuebase_modifiedby");
                this.SetRelatedEntities<Queue>("lk_queuebase_modifiedby", null, value);
                this.OnPropertyChanged("lk_queuebase_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_queueitem_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_queueitem_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<QueueItem> lk_queueitem_createdonbehalfby
        {
            get { return this.GetRelatedEntities<QueueItem>("lk_queueitem_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_queueitem_createdonbehalfby");
                this.SetRelatedEntities<QueueItem>("lk_queueitem_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_queueitem_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_queueitem_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_queueitem_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<QueueItem> lk_queueitem_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<QueueItem>("lk_queueitem_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_queueitem_modifiedonbehalfby");
                this.SetRelatedEntities<QueueItem>("lk_queueitem_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_queueitem_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_queueitembase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_queueitembase_createdby")]
        public System.Collections.Generic.IEnumerable<QueueItem> lk_queueitembase_createdby
        {
            get { return this.GetRelatedEntities<QueueItem>("lk_queueitembase_createdby", null); }
            set
            {
                this.OnPropertyChanging("lk_queueitembase_createdby");
                this.SetRelatedEntities<QueueItem>("lk_queueitembase_createdby", null, value);
                this.OnPropertyChanged("lk_queueitembase_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_queueitembase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_queueitembase_modifiedby")]
        public System.Collections.Generic.IEnumerable<QueueItem> lk_queueitembase_modifiedby
        {
            get { return this.GetRelatedEntities<QueueItem>("lk_queueitembase_modifiedby", null); }
            set
            {
                this.OnPropertyChanging("lk_queueitembase_modifiedby");
                this.SetRelatedEntities<QueueItem>("lk_queueitembase_modifiedby", null, value);
                this.OnPropertyChanged("lk_queueitembase_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_queueitembase_workerid
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_queueitembase_workerid")]
        public System.Collections.Generic.IEnumerable<QueueItem> lk_queueitembase_workerid
        {
            get { return this.GetRelatedEntities<QueueItem>("lk_queueitembase_workerid", null); }
            set
            {
                this.OnPropertyChanging("lk_queueitembase_workerid");
                this.SetRelatedEntities<QueueItem>("lk_queueitembase_workerid", null, value);
                this.OnPropertyChanged("lk_queueitembase_workerid");
            }
        }

        /// <summary>
        /// 1:N lk_quote_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_quote_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<Quote> lk_quote_createdonbehalfby
        {
            get { return this.GetRelatedEntities<Quote>("lk_quote_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_quote_createdonbehalfby");
                this.SetRelatedEntities<Quote>("lk_quote_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_quote_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_quote_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_quote_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<Quote> lk_quote_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<Quote>("lk_quote_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_quote_modifiedonbehalfby");
                this.SetRelatedEntities<Quote>("lk_quote_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_quote_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_quotebase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_quotebase_createdby")]
        public System.Collections.Generic.IEnumerable<Quote> lk_quotebase_createdby
        {
            get { return this.GetRelatedEntities<Quote>("lk_quotebase_createdby", null); }
            set
            {
                this.OnPropertyChanging("lk_quotebase_createdby");
                this.SetRelatedEntities<Quote>("lk_quotebase_createdby", null, value);
                this.OnPropertyChanged("lk_quotebase_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_quotebase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_quotebase_modifiedby")]
        public System.Collections.Generic.IEnumerable<Quote> lk_quotebase_modifiedby
        {
            get { return this.GetRelatedEntities<Quote>("lk_quotebase_modifiedby", null); }
            set
            {
                this.OnPropertyChanging("lk_quotebase_modifiedby");
                this.SetRelatedEntities<Quote>("lk_quotebase_modifiedby", null, value);
                this.OnPropertyChanged("lk_quotebase_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_quoteclose_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_quoteclose_createdby")]
        public System.Collections.Generic.IEnumerable<QuoteClose> lk_quoteclose_createdby
        {
            get { return this.GetRelatedEntities<QuoteClose>("lk_quoteclose_createdby", null); }
            set
            {
                this.OnPropertyChanging("lk_quoteclose_createdby");
                this.SetRelatedEntities<QuoteClose>("lk_quoteclose_createdby", null, value);
                this.OnPropertyChanged("lk_quoteclose_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_quoteclose_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_quoteclose_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<QuoteClose> lk_quoteclose_createdonbehalfby
        {
            get { return this.GetRelatedEntities<QuoteClose>("lk_quoteclose_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_quoteclose_createdonbehalfby");
                this.SetRelatedEntities<QuoteClose>("lk_quoteclose_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_quoteclose_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_quoteclose_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_quoteclose_modifiedby")]
        public System.Collections.Generic.IEnumerable<QuoteClose> lk_quoteclose_modifiedby
        {
            get { return this.GetRelatedEntities<QuoteClose>("lk_quoteclose_modifiedby", null); }
            set
            {
                this.OnPropertyChanging("lk_quoteclose_modifiedby");
                this.SetRelatedEntities<QuoteClose>("lk_quoteclose_modifiedby", null, value);
                this.OnPropertyChanged("lk_quoteclose_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_quoteclose_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_quoteclose_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<QuoteClose> lk_quoteclose_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<QuoteClose>("lk_quoteclose_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_quoteclose_modifiedonbehalfby");
                this.SetRelatedEntities<QuoteClose>("lk_quoteclose_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_quoteclose_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_quotedetail_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_quotedetail_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<QuoteDetail> lk_quotedetail_createdonbehalfby
        {
            get { return this.GetRelatedEntities<QuoteDetail>("lk_quotedetail_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_quotedetail_createdonbehalfby");
                this.SetRelatedEntities<QuoteDetail>("lk_quotedetail_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_quotedetail_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_quotedetail_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_quotedetail_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<QuoteDetail> lk_quotedetail_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<QuoteDetail>("lk_quotedetail_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_quotedetail_modifiedonbehalfby");
                this.SetRelatedEntities<QuoteDetail>("lk_quotedetail_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_quotedetail_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_quotedetailbase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_quotedetailbase_createdby")]
        public System.Collections.Generic.IEnumerable<QuoteDetail> lk_quotedetailbase_createdby
        {
            get { return this.GetRelatedEntities<QuoteDetail>("lk_quotedetailbase_createdby", null); }
            set
            {
                this.OnPropertyChanging("lk_quotedetailbase_createdby");
                this.SetRelatedEntities<QuoteDetail>("lk_quotedetailbase_createdby", null, value);
                this.OnPropertyChanged("lk_quotedetailbase_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_quotedetailbase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_quotedetailbase_modifiedby")]
        public System.Collections.Generic.IEnumerable<QuoteDetail> lk_quotedetailbase_modifiedby
        {
            get { return this.GetRelatedEntities<QuoteDetail>("lk_quotedetailbase_modifiedby", null); }
            set
            {
                this.OnPropertyChanging("lk_quotedetailbase_modifiedby");
                this.SetRelatedEntities<QuoteDetail>("lk_quotedetailbase_modifiedby", null, value);
                this.OnPropertyChanged("lk_quotedetailbase_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_recurrencerule_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_recurrencerule_createdby")]
        public System.Collections.Generic.IEnumerable<RecurrenceRule> lk_recurrencerule_createdby
        {
            get { return this.GetRelatedEntities<RecurrenceRule>("lk_recurrencerule_createdby", null); }
            set
            {
                this.OnPropertyChanging("lk_recurrencerule_createdby");
                this.SetRelatedEntities<RecurrenceRule>("lk_recurrencerule_createdby", null, value);
                this.OnPropertyChanged("lk_recurrencerule_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_recurrencerule_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_recurrencerule_modifiedby")]
        public System.Collections.Generic.IEnumerable<RecurrenceRule> lk_recurrencerule_modifiedby
        {
            get { return this.GetRelatedEntities<RecurrenceRule>("lk_recurrencerule_modifiedby", null); }
            set
            {
                this.OnPropertyChanging("lk_recurrencerule_modifiedby");
                this.SetRelatedEntities<RecurrenceRule>("lk_recurrencerule_modifiedby", null, value);
                this.OnPropertyChanged("lk_recurrencerule_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_recurrencerulebase_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_recurrencerulebase_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<RecurrenceRule> lk_recurrencerulebase_createdonbehalfby
        {
            get { return this.GetRelatedEntities<RecurrenceRule>("lk_recurrencerulebase_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_recurrencerulebase_createdonbehalfby");
                this.SetRelatedEntities<RecurrenceRule>("lk_recurrencerulebase_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_recurrencerulebase_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_recurrencerulebase_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_recurrencerulebase_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<RecurrenceRule> lk_recurrencerulebase_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<RecurrenceRule>("lk_recurrencerulebase_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_recurrencerulebase_modifiedonbehalfby");
                this.SetRelatedEntities<RecurrenceRule>("lk_recurrencerulebase_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_recurrencerulebase_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_recurringappointmentmaster_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_recurringappointmentmaster_createdby")]
        public System.Collections.Generic.IEnumerable<RecurringAppointmentMaster> lk_recurringappointmentmaster_createdby
        {
            get { return this.GetRelatedEntities<RecurringAppointmentMaster>("lk_recurringappointmentmaster_createdby", null); }
            set
            {
                this.OnPropertyChanging("lk_recurringappointmentmaster_createdby");
                this.SetRelatedEntities<RecurringAppointmentMaster>("lk_recurringappointmentmaster_createdby", null, value);
                this.OnPropertyChanged("lk_recurringappointmentmaster_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_recurringappointmentmaster_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_recurringappointmentmaster_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<RecurringAppointmentMaster> lk_recurringappointmentmaster_createdonbehalfby
        {
            get { return this.GetRelatedEntities<RecurringAppointmentMaster>("lk_recurringappointmentmaster_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_recurringappointmentmaster_createdonbehalfby");
                this.SetRelatedEntities<RecurringAppointmentMaster>("lk_recurringappointmentmaster_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_recurringappointmentmaster_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_recurringappointmentmaster_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_recurringappointmentmaster_modifiedby")]
        public System.Collections.Generic.IEnumerable<RecurringAppointmentMaster> lk_recurringappointmentmaster_modifiedby
        {
            get { return this.GetRelatedEntities<RecurringAppointmentMaster>("lk_recurringappointmentmaster_modifiedby", null); }
            set
            {
                this.OnPropertyChanging("lk_recurringappointmentmaster_modifiedby");
                this.SetRelatedEntities<RecurringAppointmentMaster>("lk_recurringappointmentmaster_modifiedby", null, value);
                this.OnPropertyChanged("lk_recurringappointmentmaster_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_recurringappointmentmaster_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_recurringappointmentmaster_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<RecurringAppointmentMaster> lk_recurringappointmentmaster_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<RecurringAppointmentMaster>("lk_recurringappointmentmaster_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_recurringappointmentmaster_modifiedonbehalfby");
                this.SetRelatedEntities<RecurringAppointmentMaster>("lk_recurringappointmentmaster_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_recurringappointmentmaster_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_relationshiprole_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_relationshiprole_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<RelationshipRole> lk_relationshiprole_createdonbehalfby
        {
            get { return this.GetRelatedEntities<RelationshipRole>("lk_relationshiprole_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_relationshiprole_createdonbehalfby");
                this.SetRelatedEntities<RelationshipRole>("lk_relationshiprole_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_relationshiprole_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_relationshiprole_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_relationshiprole_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<RelationshipRole> lk_relationshiprole_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<RelationshipRole>("lk_relationshiprole_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_relationshiprole_modifiedonbehalfby");
                this.SetRelatedEntities<RelationshipRole>("lk_relationshiprole_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_relationshiprole_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_relationshiprolemap_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_relationshiprolemap_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<RelationshipRoleMap> lk_relationshiprolemap_createdonbehalfby
        {
            get { return this.GetRelatedEntities<RelationshipRoleMap>("lk_relationshiprolemap_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_relationshiprolemap_createdonbehalfby");
                this.SetRelatedEntities<RelationshipRoleMap>("lk_relationshiprolemap_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_relationshiprolemap_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_relationshiprolemap_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_relationshiprolemap_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<RelationshipRoleMap> lk_relationshiprolemap_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<RelationshipRoleMap>("lk_relationshiprolemap_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_relationshiprolemap_modifiedonbehalfby");
                this.SetRelatedEntities<RelationshipRoleMap>("lk_relationshiprolemap_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_relationshiprolemap_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_report_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_report_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<Report> lk_report_createdonbehalfby
        {
            get { return this.GetRelatedEntities<Report>("lk_report_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_report_createdonbehalfby");
                this.SetRelatedEntities<Report>("lk_report_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_report_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_report_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_report_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<Report> lk_report_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<Report>("lk_report_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_report_modifiedonbehalfby");
                this.SetRelatedEntities<Report>("lk_report_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_report_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_reportbase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_reportbase_createdby")]
        public System.Collections.Generic.IEnumerable<Report> lk_reportbase_createdby
        {
            get { return this.GetRelatedEntities<Report>("lk_reportbase_createdby", null); }
            set
            {
                this.OnPropertyChanging("lk_reportbase_createdby");
                this.SetRelatedEntities<Report>("lk_reportbase_createdby", null, value);
                this.OnPropertyChanged("lk_reportbase_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_reportbase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_reportbase_modifiedby")]
        public System.Collections.Generic.IEnumerable<Report> lk_reportbase_modifiedby
        {
            get { return this.GetRelatedEntities<Report>("lk_reportbase_modifiedby", null); }
            set
            {
                this.OnPropertyChanging("lk_reportbase_modifiedby");
                this.SetRelatedEntities<Report>("lk_reportbase_modifiedby", null, value);
                this.OnPropertyChanged("lk_reportbase_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_reportcategory_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_reportcategory_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<ReportCategory> lk_reportcategory_createdonbehalfby
        {
            get { return this.GetRelatedEntities<ReportCategory>("lk_reportcategory_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_reportcategory_createdonbehalfby");
                this.SetRelatedEntities<ReportCategory>("lk_reportcategory_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_reportcategory_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_reportcategory_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_reportcategory_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<ReportCategory> lk_reportcategory_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<ReportCategory>("lk_reportcategory_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_reportcategory_modifiedonbehalfby");
                this.SetRelatedEntities<ReportCategory>("lk_reportcategory_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_reportcategory_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_reportcategorybase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_reportcategorybase_createdby")]
        public System.Collections.Generic.IEnumerable<ReportCategory> lk_reportcategorybase_createdby
        {
            get { return this.GetRelatedEntities<ReportCategory>("lk_reportcategorybase_createdby", null); }
            set
            {
                this.OnPropertyChanging("lk_reportcategorybase_createdby");
                this.SetRelatedEntities<ReportCategory>("lk_reportcategorybase_createdby", null, value);
                this.OnPropertyChanged("lk_reportcategorybase_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_reportcategorybase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_reportcategorybase_modifiedby")]
        public System.Collections.Generic.IEnumerable<ReportCategory> lk_reportcategorybase_modifiedby
        {
            get { return this.GetRelatedEntities<ReportCategory>("lk_reportcategorybase_modifiedby", null); }
            set
            {
                this.OnPropertyChanging("lk_reportcategorybase_modifiedby");
                this.SetRelatedEntities<ReportCategory>("lk_reportcategorybase_modifiedby", null, value);
                this.OnPropertyChanged("lk_reportcategorybase_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_reportentity_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_reportentity_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<ReportEntity> lk_reportentity_createdonbehalfby
        {
            get { return this.GetRelatedEntities<ReportEntity>("lk_reportentity_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_reportentity_createdonbehalfby");
                this.SetRelatedEntities<ReportEntity>("lk_reportentity_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_reportentity_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_reportentity_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_reportentity_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<ReportEntity> lk_reportentity_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<ReportEntity>("lk_reportentity_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_reportentity_modifiedonbehalfby");
                this.SetRelatedEntities<ReportEntity>("lk_reportentity_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_reportentity_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_reportentitybase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_reportentitybase_createdby")]
        public System.Collections.Generic.IEnumerable<ReportEntity> lk_reportentitybase_createdby
        {
            get { return this.GetRelatedEntities<ReportEntity>("lk_reportentitybase_createdby", null); }
            set
            {
                this.OnPropertyChanging("lk_reportentitybase_createdby");
                this.SetRelatedEntities<ReportEntity>("lk_reportentitybase_createdby", null, value);
                this.OnPropertyChanged("lk_reportentitybase_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_reportentitybase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_reportentitybase_modifiedby")]
        public System.Collections.Generic.IEnumerable<ReportEntity> lk_reportentitybase_modifiedby
        {
            get { return this.GetRelatedEntities<ReportEntity>("lk_reportentitybase_modifiedby", null); }
            set
            {
                this.OnPropertyChanging("lk_reportentitybase_modifiedby");
                this.SetRelatedEntities<ReportEntity>("lk_reportentitybase_modifiedby", null, value);
                this.OnPropertyChanged("lk_reportentitybase_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_reportlink_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_reportlink_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<ReportLink> lk_reportlink_createdonbehalfby
        {
            get { return this.GetRelatedEntities<ReportLink>("lk_reportlink_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_reportlink_createdonbehalfby");
                this.SetRelatedEntities<ReportLink>("lk_reportlink_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_reportlink_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_reportlink_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_reportlink_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<ReportLink> lk_reportlink_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<ReportLink>("lk_reportlink_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_reportlink_modifiedonbehalfby");
                this.SetRelatedEntities<ReportLink>("lk_reportlink_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_reportlink_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_reportlinkbase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_reportlinkbase_createdby")]
        public System.Collections.Generic.IEnumerable<ReportLink> lk_reportlinkbase_createdby
        {
            get { return this.GetRelatedEntities<ReportLink>("lk_reportlinkbase_createdby", null); }
            set
            {
                this.OnPropertyChanging("lk_reportlinkbase_createdby");
                this.SetRelatedEntities<ReportLink>("lk_reportlinkbase_createdby", null, value);
                this.OnPropertyChanged("lk_reportlinkbase_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_reportlinkbase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_reportlinkbase_modifiedby")]
        public System.Collections.Generic.IEnumerable<ReportLink> lk_reportlinkbase_modifiedby
        {
            get { return this.GetRelatedEntities<ReportLink>("lk_reportlinkbase_modifiedby", null); }
            set
            {
                this.OnPropertyChanging("lk_reportlinkbase_modifiedby");
                this.SetRelatedEntities<ReportLink>("lk_reportlinkbase_modifiedby", null, value);
                this.OnPropertyChanged("lk_reportlinkbase_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_reportvisibility_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_reportvisibility_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<ReportVisibility> lk_reportvisibility_createdonbehalfby
        {
            get { return this.GetRelatedEntities<ReportVisibility>("lk_reportvisibility_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_reportvisibility_createdonbehalfby");
                this.SetRelatedEntities<ReportVisibility>("lk_reportvisibility_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_reportvisibility_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_reportvisibility_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_reportvisibility_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<ReportVisibility> lk_reportvisibility_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<ReportVisibility>("lk_reportvisibility_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_reportvisibility_modifiedonbehalfby");
                this.SetRelatedEntities<ReportVisibility>("lk_reportvisibility_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_reportvisibility_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_reportvisibilitybase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_reportvisibilitybase_createdby")]
        public System.Collections.Generic.IEnumerable<ReportVisibility> lk_reportvisibilitybase_createdby
        {
            get { return this.GetRelatedEntities<ReportVisibility>("lk_reportvisibilitybase_createdby", null); }
            set
            {
                this.OnPropertyChanging("lk_reportvisibilitybase_createdby");
                this.SetRelatedEntities<ReportVisibility>("lk_reportvisibilitybase_createdby", null, value);
                this.OnPropertyChanged("lk_reportvisibilitybase_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_reportvisibilitybase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_reportvisibilitybase_modifiedby")]
        public System.Collections.Generic.IEnumerable<ReportVisibility> lk_reportvisibilitybase_modifiedby
        {
            get { return this.GetRelatedEntities<ReportVisibility>("lk_reportvisibilitybase_modifiedby", null); }
            set
            {
                this.OnPropertyChanging("lk_reportvisibilitybase_modifiedby");
                this.SetRelatedEntities<ReportVisibility>("lk_reportvisibilitybase_modifiedby", null, value);
                this.OnPropertyChanged("lk_reportvisibilitybase_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_resourcespec_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_resourcespec_createdby")]
        public System.Collections.Generic.IEnumerable<ResourceSpec> lk_resourcespec_createdby
        {
            get { return this.GetRelatedEntities<ResourceSpec>("lk_resourcespec_createdby", null); }
            set
            {
                this.OnPropertyChanging("lk_resourcespec_createdby");
                this.SetRelatedEntities<ResourceSpec>("lk_resourcespec_createdby", null, value);
                this.OnPropertyChanged("lk_resourcespec_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_resourcespec_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_resourcespec_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<ResourceSpec> lk_resourcespec_createdonbehalfby
        {
            get { return this.GetRelatedEntities<ResourceSpec>("lk_resourcespec_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_resourcespec_createdonbehalfby");
                this.SetRelatedEntities<ResourceSpec>("lk_resourcespec_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_resourcespec_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_resourcespec_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_resourcespec_modifiedby")]
        public System.Collections.Generic.IEnumerable<ResourceSpec> lk_resourcespec_modifiedby
        {
            get { return this.GetRelatedEntities<ResourceSpec>("lk_resourcespec_modifiedby", null); }
            set
            {
                this.OnPropertyChanging("lk_resourcespec_modifiedby");
                this.SetRelatedEntities<ResourceSpec>("lk_resourcespec_modifiedby", null, value);
                this.OnPropertyChanged("lk_resourcespec_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_resourcespec_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_resourcespec_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<ResourceSpec> lk_resourcespec_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<ResourceSpec>("lk_resourcespec_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_resourcespec_modifiedonbehalfby");
                this.SetRelatedEntities<ResourceSpec>("lk_resourcespec_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_resourcespec_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_role_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_role_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<Role> lk_role_createdonbehalfby
        {
            get { return this.GetRelatedEntities<Role>("lk_role_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_role_createdonbehalfby");
                this.SetRelatedEntities<Role>("lk_role_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_role_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_role_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_role_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<Role> lk_role_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<Role>("lk_role_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_role_modifiedonbehalfby");
                this.SetRelatedEntities<Role>("lk_role_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_role_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_rolebase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_rolebase_createdby")]
        public System.Collections.Generic.IEnumerable<Role> lk_rolebase_createdby
        {
            get { return this.GetRelatedEntities<Role>("lk_rolebase_createdby", null); }
            set
            {
                this.OnPropertyChanging("lk_rolebase_createdby");
                this.SetRelatedEntities<Role>("lk_rolebase_createdby", null, value);
                this.OnPropertyChanged("lk_rolebase_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_rolebase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_rolebase_modifiedby")]
        public System.Collections.Generic.IEnumerable<Role> lk_rolebase_modifiedby
        {
            get { return this.GetRelatedEntities<Role>("lk_rolebase_modifiedby", null); }
            set
            {
                this.OnPropertyChanging("lk_rolebase_modifiedby");
                this.SetRelatedEntities<Role>("lk_rolebase_modifiedby", null, value);
                this.OnPropertyChanged("lk_rolebase_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_rollupfield_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_rollupfield_createdby")]
        public System.Collections.Generic.IEnumerable<RollupField> lk_rollupfield_createdby
        {
            get { return this.GetRelatedEntities<RollupField>("lk_rollupfield_createdby", null); }
            set
            {
                this.OnPropertyChanging("lk_rollupfield_createdby");
                this.SetRelatedEntities<RollupField>("lk_rollupfield_createdby", null, value);
                this.OnPropertyChanged("lk_rollupfield_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_rollupfield_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_rollupfield_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<RollupField> lk_rollupfield_createdonbehalfby
        {
            get { return this.GetRelatedEntities<RollupField>("lk_rollupfield_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_rollupfield_createdonbehalfby");
                this.SetRelatedEntities<RollupField>("lk_rollupfield_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_rollupfield_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_rollupfield_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_rollupfield_modifiedby")]
        public System.Collections.Generic.IEnumerable<RollupField> lk_rollupfield_modifiedby
        {
            get { return this.GetRelatedEntities<RollupField>("lk_rollupfield_modifiedby", null); }
            set
            {
                this.OnPropertyChanging("lk_rollupfield_modifiedby");
                this.SetRelatedEntities<RollupField>("lk_rollupfield_modifiedby", null, value);
                this.OnPropertyChanged("lk_rollupfield_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_rollupfield_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_rollupfield_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<RollupField> lk_rollupfield_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<RollupField>("lk_rollupfield_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_rollupfield_modifiedonbehalfby");
                this.SetRelatedEntities<RollupField>("lk_rollupfield_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_rollupfield_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_routingrule_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_routingrule_createdby")]
        public System.Collections.Generic.IEnumerable<RoutingRule> lk_routingrule_createdby
        {
            get { return this.GetRelatedEntities<RoutingRule>("lk_routingrule_createdby", null); }
            set
            {
                this.OnPropertyChanging("lk_routingrule_createdby");
                this.SetRelatedEntities<RoutingRule>("lk_routingrule_createdby", null, value);
                this.OnPropertyChanged("lk_routingrule_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_routingrule_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_routingrule_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<RoutingRule> lk_routingrule_createdonbehalfby
        {
            get { return this.GetRelatedEntities<RoutingRule>("lk_routingrule_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_routingrule_createdonbehalfby");
                this.SetRelatedEntities<RoutingRule>("lk_routingrule_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_routingrule_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_routingrule_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_routingrule_modifiedby")]
        public System.Collections.Generic.IEnumerable<RoutingRule> lk_routingrule_modifiedby
        {
            get { return this.GetRelatedEntities<RoutingRule>("lk_routingrule_modifiedby", null); }
            set
            {
                this.OnPropertyChanging("lk_routingrule_modifiedby");
                this.SetRelatedEntities<RoutingRule>("lk_routingrule_modifiedby", null, value);
                this.OnPropertyChanged("lk_routingrule_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_routingrule_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_routingrule_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<RoutingRule> lk_routingrule_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<RoutingRule>("lk_routingrule_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_routingrule_modifiedonbehalfby");
                this.SetRelatedEntities<RoutingRule>("lk_routingrule_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_routingrule_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_RoutingRuleItem_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_RoutingRuleItem_createdby")]
        public System.Collections.Generic.IEnumerable<RoutingRuleItem> lk_RoutingRuleItem_createdby
        {
            get { return this.GetRelatedEntities<RoutingRuleItem>("lk_RoutingRuleItem_createdby", null); }
            set
            {
                this.OnPropertyChanging("lk_RoutingRuleItem_createdby");
                this.SetRelatedEntities<RoutingRuleItem>("lk_RoutingRuleItem_createdby", null, value);
                this.OnPropertyChanged("lk_RoutingRuleItem_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_routingruleitem_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_routingruleitem_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<RoutingRuleItem> lk_routingruleitem_createdonbehalfby
        {
            get { return this.GetRelatedEntities<RoutingRuleItem>("lk_routingruleitem_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_routingruleitem_createdonbehalfby");
                this.SetRelatedEntities<RoutingRuleItem>("lk_routingruleitem_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_routingruleitem_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_routingruleitem_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_routingruleitem_modifiedby")]
        public System.Collections.Generic.IEnumerable<RoutingRuleItem> lk_routingruleitem_modifiedby
        {
            get { return this.GetRelatedEntities<RoutingRuleItem>("lk_routingruleitem_modifiedby", null); }
            set
            {
                this.OnPropertyChanging("lk_routingruleitem_modifiedby");
                this.SetRelatedEntities<RoutingRuleItem>("lk_routingruleitem_modifiedby", null, value);
                this.OnPropertyChanged("lk_routingruleitem_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_routingruleitem_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_routingruleitem_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<RoutingRuleItem> lk_routingruleitem_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<RoutingRuleItem>("lk_routingruleitem_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_routingruleitem_modifiedonbehalfby");
                this.SetRelatedEntities<RoutingRuleItem>("lk_routingruleitem_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_routingruleitem_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_salesliterature_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_salesliterature_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<SalesLiterature> lk_salesliterature_createdonbehalfby
        {
            get { return this.GetRelatedEntities<SalesLiterature>("lk_salesliterature_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_salesliterature_createdonbehalfby");
                this.SetRelatedEntities<SalesLiterature>("lk_salesliterature_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_salesliterature_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_salesliterature_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_salesliterature_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<SalesLiterature> lk_salesliterature_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<SalesLiterature>("lk_salesliterature_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_salesliterature_modifiedonbehalfby");
                this.SetRelatedEntities<SalesLiterature>("lk_salesliterature_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_salesliterature_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_salesliteraturebase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_salesliteraturebase_createdby")]
        public System.Collections.Generic.IEnumerable<SalesLiterature> lk_salesliteraturebase_createdby
        {
            get { return this.GetRelatedEntities<SalesLiterature>("lk_salesliteraturebase_createdby", null); }
            set
            {
                this.OnPropertyChanging("lk_salesliteraturebase_createdby");
                this.SetRelatedEntities<SalesLiterature>("lk_salesliteraturebase_createdby", null, value);
                this.OnPropertyChanged("lk_salesliteraturebase_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_salesliteraturebase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_salesliteraturebase_modifiedby")]
        public System.Collections.Generic.IEnumerable<SalesLiterature> lk_salesliteraturebase_modifiedby
        {
            get { return this.GetRelatedEntities<SalesLiterature>("lk_salesliteraturebase_modifiedby", null); }
            set
            {
                this.OnPropertyChanging("lk_salesliteraturebase_modifiedby");
                this.SetRelatedEntities<SalesLiterature>("lk_salesliteraturebase_modifiedby", null, value);
                this.OnPropertyChanged("lk_salesliteraturebase_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_salesliteratureitem_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_salesliteratureitem_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<SalesLiteratureItem> lk_salesliteratureitem_createdonbehalfby
        {
            get { return this.GetRelatedEntities<SalesLiteratureItem>("lk_salesliteratureitem_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_salesliteratureitem_createdonbehalfby");
                this.SetRelatedEntities<SalesLiteratureItem>("lk_salesliteratureitem_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_salesliteratureitem_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_salesliteratureitem_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_salesliteratureitem_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<SalesLiteratureItem> lk_salesliteratureitem_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<SalesLiteratureItem>("lk_salesliteratureitem_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_salesliteratureitem_modifiedonbehalfby");
                this.SetRelatedEntities<SalesLiteratureItem>("lk_salesliteratureitem_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_salesliteratureitem_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_salesliteratureitembase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_salesliteratureitembase_createdby")]
        public System.Collections.Generic.IEnumerable<SalesLiteratureItem> lk_salesliteratureitembase_createdby
        {
            get { return this.GetRelatedEntities<SalesLiteratureItem>("lk_salesliteratureitembase_createdby", null); }
            set
            {
                this.OnPropertyChanging("lk_salesliteratureitembase_createdby");
                this.SetRelatedEntities<SalesLiteratureItem>("lk_salesliteratureitembase_createdby", null, value);
                this.OnPropertyChanged("lk_salesliteratureitembase_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_salesliteratureitembase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_salesliteratureitembase_modifiedby")]
        public System.Collections.Generic.IEnumerable<SalesLiteratureItem> lk_salesliteratureitembase_modifiedby
        {
            get { return this.GetRelatedEntities<SalesLiteratureItem>("lk_salesliteratureitembase_modifiedby", null); }
            set
            {
                this.OnPropertyChanging("lk_salesliteratureitembase_modifiedby");
                this.SetRelatedEntities<SalesLiteratureItem>("lk_salesliteratureitembase_modifiedby", null, value);
                this.OnPropertyChanged("lk_salesliteratureitembase_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_salesorder_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_salesorder_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<SalesOrder> lk_salesorder_createdonbehalfby
        {
            get { return this.GetRelatedEntities<SalesOrder>("lk_salesorder_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_salesorder_createdonbehalfby");
                this.SetRelatedEntities<SalesOrder>("lk_salesorder_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_salesorder_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_salesorder_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_salesorder_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<SalesOrder> lk_salesorder_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<SalesOrder>("lk_salesorder_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_salesorder_modifiedonbehalfby");
                this.SetRelatedEntities<SalesOrder>("lk_salesorder_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_salesorder_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_salesorderbase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_salesorderbase_createdby")]
        public System.Collections.Generic.IEnumerable<SalesOrder> lk_salesorderbase_createdby
        {
            get { return this.GetRelatedEntities<SalesOrder>("lk_salesorderbase_createdby", null); }
            set
            {
                this.OnPropertyChanging("lk_salesorderbase_createdby");
                this.SetRelatedEntities<SalesOrder>("lk_salesorderbase_createdby", null, value);
                this.OnPropertyChanged("lk_salesorderbase_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_salesorderbase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_salesorderbase_modifiedby")]
        public System.Collections.Generic.IEnumerable<SalesOrder> lk_salesorderbase_modifiedby
        {
            get { return this.GetRelatedEntities<SalesOrder>("lk_salesorderbase_modifiedby", null); }
            set
            {
                this.OnPropertyChanging("lk_salesorderbase_modifiedby");
                this.SetRelatedEntities<SalesOrder>("lk_salesorderbase_modifiedby", null, value);
                this.OnPropertyChanged("lk_salesorderbase_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_salesorderdetail_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_salesorderdetail_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<SalesOrderDetail> lk_salesorderdetail_createdonbehalfby
        {
            get { return this.GetRelatedEntities<SalesOrderDetail>("lk_salesorderdetail_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_salesorderdetail_createdonbehalfby");
                this.SetRelatedEntities<SalesOrderDetail>("lk_salesorderdetail_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_salesorderdetail_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_salesorderdetail_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_salesorderdetail_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<SalesOrderDetail> lk_salesorderdetail_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<SalesOrderDetail>("lk_salesorderdetail_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_salesorderdetail_modifiedonbehalfby");
                this.SetRelatedEntities<SalesOrderDetail>("lk_salesorderdetail_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_salesorderdetail_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_salesorderdetailbase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_salesorderdetailbase_createdby")]
        public System.Collections.Generic.IEnumerable<SalesOrderDetail> lk_salesorderdetailbase_createdby
        {
            get { return this.GetRelatedEntities<SalesOrderDetail>("lk_salesorderdetailbase_createdby", null); }
            set
            {
                this.OnPropertyChanging("lk_salesorderdetailbase_createdby");
                this.SetRelatedEntities<SalesOrderDetail>("lk_salesorderdetailbase_createdby", null, value);
                this.OnPropertyChanged("lk_salesorderdetailbase_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_salesorderdetailbase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_salesorderdetailbase_modifiedby")]
        public System.Collections.Generic.IEnumerable<SalesOrderDetail> lk_salesorderdetailbase_modifiedby
        {
            get { return this.GetRelatedEntities<SalesOrderDetail>("lk_salesorderdetailbase_modifiedby", null); }
            set
            {
                this.OnPropertyChanging("lk_salesorderdetailbase_modifiedby");
                this.SetRelatedEntities<SalesOrderDetail>("lk_salesorderdetailbase_modifiedby", null, value);
                this.OnPropertyChanged("lk_salesorderdetailbase_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_savedquery_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_savedquery_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<SavedQuery> lk_savedquery_createdonbehalfby
        {
            get { return this.GetRelatedEntities<SavedQuery>("lk_savedquery_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_savedquery_createdonbehalfby");
                this.SetRelatedEntities<SavedQuery>("lk_savedquery_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_savedquery_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_savedquery_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_savedquery_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<SavedQuery> lk_savedquery_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<SavedQuery>("lk_savedquery_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_savedquery_modifiedonbehalfby");
                this.SetRelatedEntities<SavedQuery>("lk_savedquery_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_savedquery_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_savedquerybase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_savedquerybase_createdby")]
        public System.Collections.Generic.IEnumerable<SavedQuery> lk_savedquerybase_createdby
        {
            get { return this.GetRelatedEntities<SavedQuery>("lk_savedquerybase_createdby", null); }
            set
            {
                this.OnPropertyChanging("lk_savedquerybase_createdby");
                this.SetRelatedEntities<SavedQuery>("lk_savedquerybase_createdby", null, value);
                this.OnPropertyChanged("lk_savedquerybase_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_savedquerybase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_savedquerybase_modifiedby")]
        public System.Collections.Generic.IEnumerable<SavedQuery> lk_savedquerybase_modifiedby
        {
            get { return this.GetRelatedEntities<SavedQuery>("lk_savedquerybase_modifiedby", null); }
            set
            {
                this.OnPropertyChanging("lk_savedquerybase_modifiedby");
                this.SetRelatedEntities<SavedQuery>("lk_savedquerybase_modifiedby", null, value);
                this.OnPropertyChanged("lk_savedquerybase_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_savedqueryvisualizationbase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_savedqueryvisualizationbase_createdby")]
        public System.Collections.Generic.IEnumerable<SavedQueryVisualization> lk_savedqueryvisualizationbase_createdby
        {
            get { return this.GetRelatedEntities<SavedQueryVisualization>("lk_savedqueryvisualizationbase_createdby", null); }
            set
            {
                this.OnPropertyChanging("lk_savedqueryvisualizationbase_createdby");
                this.SetRelatedEntities<SavedQueryVisualization>("lk_savedqueryvisualizationbase_createdby", null, value);
                this.OnPropertyChanged("lk_savedqueryvisualizationbase_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_savedqueryvisualizationbase_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_savedqueryvisualizationbase_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<SavedQueryVisualization> lk_savedqueryvisualizationbase_createdonbehalfby
        {
            get { return this.GetRelatedEntities<SavedQueryVisualization>("lk_savedqueryvisualizationbase_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_savedqueryvisualizationbase_createdonbehalfby");
                this.SetRelatedEntities<SavedQueryVisualization>("lk_savedqueryvisualizationbase_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_savedqueryvisualizationbase_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_savedqueryvisualizationbase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_savedqueryvisualizationbase_modifiedby")]
        public System.Collections.Generic.IEnumerable<SavedQueryVisualization> lk_savedqueryvisualizationbase_modifiedby
        {
            get { return this.GetRelatedEntities<SavedQueryVisualization>("lk_savedqueryvisualizationbase_modifiedby", null); }
            set
            {
                this.OnPropertyChanging("lk_savedqueryvisualizationbase_modifiedby");
                this.SetRelatedEntities<SavedQueryVisualization>("lk_savedqueryvisualizationbase_modifiedby", null, value);
                this.OnPropertyChanged("lk_savedqueryvisualizationbase_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_savedqueryvisualizationbase_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_savedqueryvisualizationbase_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<SavedQueryVisualization> lk_savedqueryvisualizationbase_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<SavedQueryVisualization>("lk_savedqueryvisualizationbase_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_savedqueryvisualizationbase_modifiedonbehalfby");
                this.SetRelatedEntities<SavedQueryVisualization>("lk_savedqueryvisualizationbase_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_savedqueryvisualizationbase_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_sdkmessage_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_sdkmessage_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<SdkMessage> lk_sdkmessage_createdonbehalfby
        {
            get { return this.GetRelatedEntities<SdkMessage>("lk_sdkmessage_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_sdkmessage_createdonbehalfby");
                this.SetRelatedEntities<SdkMessage>("lk_sdkmessage_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_sdkmessage_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_sdkmessage_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_sdkmessage_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<SdkMessage> lk_sdkmessage_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<SdkMessage>("lk_sdkmessage_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_sdkmessage_modifiedonbehalfby");
                this.SetRelatedEntities<SdkMessage>("lk_sdkmessage_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_sdkmessage_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_sdkmessagefilter_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_sdkmessagefilter_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<SdkMessageFilter> lk_sdkmessagefilter_createdonbehalfby
        {
            get { return this.GetRelatedEntities<SdkMessageFilter>("lk_sdkmessagefilter_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_sdkmessagefilter_createdonbehalfby");
                this.SetRelatedEntities<SdkMessageFilter>("lk_sdkmessagefilter_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_sdkmessagefilter_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_sdkmessagefilter_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_sdkmessagefilter_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<SdkMessageFilter> lk_sdkmessagefilter_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<SdkMessageFilter>("lk_sdkmessagefilter_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_sdkmessagefilter_modifiedonbehalfby");
                this.SetRelatedEntities<SdkMessageFilter>("lk_sdkmessagefilter_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_sdkmessagefilter_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_sdkmessagepair_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_sdkmessagepair_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<SdkMessagePair> lk_sdkmessagepair_createdonbehalfby
        {
            get { return this.GetRelatedEntities<SdkMessagePair>("lk_sdkmessagepair_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_sdkmessagepair_createdonbehalfby");
                this.SetRelatedEntities<SdkMessagePair>("lk_sdkmessagepair_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_sdkmessagepair_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_sdkmessagepair_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_sdkmessagepair_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<SdkMessagePair> lk_sdkmessagepair_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<SdkMessagePair>("lk_sdkmessagepair_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_sdkmessagepair_modifiedonbehalfby");
                this.SetRelatedEntities<SdkMessagePair>("lk_sdkmessagepair_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_sdkmessagepair_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_sdkmessageprocessingstep_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_sdkmessageprocessingstep_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<SdkMessageProcessingStep> lk_sdkmessageprocessingstep_createdonbehalfby
        {
            get { return this.GetRelatedEntities<SdkMessageProcessingStep>("lk_sdkmessageprocessingstep_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_sdkmessageprocessingstep_createdonbehalfby");
                this.SetRelatedEntities<SdkMessageProcessingStep>("lk_sdkmessageprocessingstep_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_sdkmessageprocessingstep_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_sdkmessageprocessingstep_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_sdkmessageprocessingstep_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<SdkMessageProcessingStep> lk_sdkmessageprocessingstep_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<SdkMessageProcessingStep>("lk_sdkmessageprocessingstep_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_sdkmessageprocessingstep_modifiedonbehalfby");
                this.SetRelatedEntities<SdkMessageProcessingStep>("lk_sdkmessageprocessingstep_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_sdkmessageprocessingstep_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_sdkmessageprocessingstepimage_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_sdkmessageprocessingstepimage_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<SdkMessageProcessingStepImage> lk_sdkmessageprocessingstepimage_createdonbehalfby
        {
            get { return this.GetRelatedEntities<SdkMessageProcessingStepImage>("lk_sdkmessageprocessingstepimage_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_sdkmessageprocessingstepimage_createdonbehalfby");
                this.SetRelatedEntities<SdkMessageProcessingStepImage>("lk_sdkmessageprocessingstepimage_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_sdkmessageprocessingstepimage_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_sdkmessageprocessingstepimage_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_sdkmessageprocessingstepimage_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<SdkMessageProcessingStepImage> lk_sdkmessageprocessingstepimage_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<SdkMessageProcessingStepImage>("lk_sdkmessageprocessingstepimage_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_sdkmessageprocessingstepimage_modifiedonbehalfby");
                this.SetRelatedEntities<SdkMessageProcessingStepImage>("lk_sdkmessageprocessingstepimage_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_sdkmessageprocessingstepimage_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_sdkmessageprocessingstepsecureconfig_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_sdkmessageprocessingstepsecureconfig_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<SdkMessageProcessingStepSecureConfig> lk_sdkmessageprocessingstepsecureconfig_createdonbehalfby
        {
            get { return this.GetRelatedEntities<SdkMessageProcessingStepSecureConfig>("lk_sdkmessageprocessingstepsecureconfig_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_sdkmessageprocessingstepsecureconfig_createdonbehalfby");
                this.SetRelatedEntities<SdkMessageProcessingStepSecureConfig>("lk_sdkmessageprocessingstepsecureconfig_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_sdkmessageprocessingstepsecureconfig_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_sdkmessageprocessingstepsecureconfig_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_sdkmessageprocessingstepsecureconfig_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<SdkMessageProcessingStepSecureConfig> lk_sdkmessageprocessingstepsecureconfig_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<SdkMessageProcessingStepSecureConfig>("lk_sdkmessageprocessingstepsecureconfig_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_sdkmessageprocessingstepsecureconfig_modifiedonbehalfby");
                this.SetRelatedEntities<SdkMessageProcessingStepSecureConfig>("lk_sdkmessageprocessingstepsecureconfig_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_sdkmessageprocessingstepsecureconfig_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_sdkmessagerequest_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_sdkmessagerequest_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<SdkMessageRequest> lk_sdkmessagerequest_createdonbehalfby
        {
            get { return this.GetRelatedEntities<SdkMessageRequest>("lk_sdkmessagerequest_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_sdkmessagerequest_createdonbehalfby");
                this.SetRelatedEntities<SdkMessageRequest>("lk_sdkmessagerequest_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_sdkmessagerequest_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_sdkmessagerequest_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_sdkmessagerequest_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<SdkMessageRequest> lk_sdkmessagerequest_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<SdkMessageRequest>("lk_sdkmessagerequest_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_sdkmessagerequest_modifiedonbehalfby");
                this.SetRelatedEntities<SdkMessageRequest>("lk_sdkmessagerequest_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_sdkmessagerequest_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_sdkmessagerequestfield_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_sdkmessagerequestfield_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<SdkMessageRequestField> lk_sdkmessagerequestfield_createdonbehalfby
        {
            get { return this.GetRelatedEntities<SdkMessageRequestField>("lk_sdkmessagerequestfield_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_sdkmessagerequestfield_createdonbehalfby");
                this.SetRelatedEntities<SdkMessageRequestField>("lk_sdkmessagerequestfield_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_sdkmessagerequestfield_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_sdkmessagerequestfield_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_sdkmessagerequestfield_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<SdkMessageRequestField> lk_sdkmessagerequestfield_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<SdkMessageRequestField>("lk_sdkmessagerequestfield_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_sdkmessagerequestfield_modifiedonbehalfby");
                this.SetRelatedEntities<SdkMessageRequestField>("lk_sdkmessagerequestfield_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_sdkmessagerequestfield_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_sdkmessageresponse_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_sdkmessageresponse_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<SdkMessageResponse> lk_sdkmessageresponse_createdonbehalfby
        {
            get { return this.GetRelatedEntities<SdkMessageResponse>("lk_sdkmessageresponse_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_sdkmessageresponse_createdonbehalfby");
                this.SetRelatedEntities<SdkMessageResponse>("lk_sdkmessageresponse_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_sdkmessageresponse_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_sdkmessageresponse_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_sdkmessageresponse_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<SdkMessageResponse> lk_sdkmessageresponse_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<SdkMessageResponse>("lk_sdkmessageresponse_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_sdkmessageresponse_modifiedonbehalfby");
                this.SetRelatedEntities<SdkMessageResponse>("lk_sdkmessageresponse_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_sdkmessageresponse_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_sdkmessageresponsefield_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_sdkmessageresponsefield_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<SdkMessageResponseField> lk_sdkmessageresponsefield_createdonbehalfby
        {
            get { return this.GetRelatedEntities<SdkMessageResponseField>("lk_sdkmessageresponsefield_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_sdkmessageresponsefield_createdonbehalfby");
                this.SetRelatedEntities<SdkMessageResponseField>("lk_sdkmessageresponsefield_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_sdkmessageresponsefield_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_sdkmessageresponsefield_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_sdkmessageresponsefield_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<SdkMessageResponseField> lk_sdkmessageresponsefield_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<SdkMessageResponseField>("lk_sdkmessageresponsefield_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_sdkmessageresponsefield_modifiedonbehalfby");
                this.SetRelatedEntities<SdkMessageResponseField>("lk_sdkmessageresponsefield_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_sdkmessageresponsefield_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_semiannualfiscalcalendar_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_semiannualfiscalcalendar_createdby")]
        public System.Collections.Generic.IEnumerable<SemiAnnualFiscalCalendar> lk_semiannualfiscalcalendar_createdby
        {
            get { return this.GetRelatedEntities<SemiAnnualFiscalCalendar>("lk_semiannualfiscalcalendar_createdby", null); }
            set
            {
                this.OnPropertyChanging("lk_semiannualfiscalcalendar_createdby");
                this.SetRelatedEntities<SemiAnnualFiscalCalendar>("lk_semiannualfiscalcalendar_createdby", null, value);
                this.OnPropertyChanged("lk_semiannualfiscalcalendar_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_semiannualfiscalcalendar_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_semiannualfiscalcalendar_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<SemiAnnualFiscalCalendar> lk_semiannualfiscalcalendar_createdonbehalfby
        {
            get { return this.GetRelatedEntities<SemiAnnualFiscalCalendar>("lk_semiannualfiscalcalendar_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_semiannualfiscalcalendar_createdonbehalfby");
                this.SetRelatedEntities<SemiAnnualFiscalCalendar>("lk_semiannualfiscalcalendar_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_semiannualfiscalcalendar_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_semiannualfiscalcalendar_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_semiannualfiscalcalendar_modifiedby")]
        public System.Collections.Generic.IEnumerable<SemiAnnualFiscalCalendar> lk_semiannualfiscalcalendar_modifiedby
        {
            get { return this.GetRelatedEntities<SemiAnnualFiscalCalendar>("lk_semiannualfiscalcalendar_modifiedby", null); }
            set
            {
                this.OnPropertyChanging("lk_semiannualfiscalcalendar_modifiedby");
                this.SetRelatedEntities<SemiAnnualFiscalCalendar>("lk_semiannualfiscalcalendar_modifiedby", null, value);
                this.OnPropertyChanged("lk_semiannualfiscalcalendar_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_semiannualfiscalcalendar_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_semiannualfiscalcalendar_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<SemiAnnualFiscalCalendar> lk_semiannualfiscalcalendar_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<SemiAnnualFiscalCalendar>("lk_semiannualfiscalcalendar_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_semiannualfiscalcalendar_modifiedonbehalfby");
                this.SetRelatedEntities<SemiAnnualFiscalCalendar>("lk_semiannualfiscalcalendar_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_semiannualfiscalcalendar_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_semiannualfiscalcalendar_salespersonid
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_semiannualfiscalcalendar_salespersonid")]
        public System.Collections.Generic.IEnumerable<SemiAnnualFiscalCalendar> lk_semiannualfiscalcalendar_salespersonid
        {
            get { return this.GetRelatedEntities<SemiAnnualFiscalCalendar>("lk_semiannualfiscalcalendar_salespersonid", null); }
            set
            {
                this.OnPropertyChanging("lk_semiannualfiscalcalendar_salespersonid");
                this.SetRelatedEntities<SemiAnnualFiscalCalendar>("lk_semiannualfiscalcalendar_salespersonid", null, value);
                this.OnPropertyChanged("lk_semiannualfiscalcalendar_salespersonid");
            }
        }

        /// <summary>
        /// 1:N lk_service_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_service_createdby")]
        public System.Collections.Generic.IEnumerable<Service> lk_service_createdby
        {
            get { return this.GetRelatedEntities<Service>("lk_service_createdby", null); }
            set
            {
                this.OnPropertyChanging("lk_service_createdby");
                this.SetRelatedEntities<Service>("lk_service_createdby", null, value);
                this.OnPropertyChanged("lk_service_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_service_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_service_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<Service> lk_service_createdonbehalfby
        {
            get { return this.GetRelatedEntities<Service>("lk_service_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_service_createdonbehalfby");
                this.SetRelatedEntities<Service>("lk_service_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_service_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_service_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_service_modifiedby")]
        public System.Collections.Generic.IEnumerable<Service> lk_service_modifiedby
        {
            get { return this.GetRelatedEntities<Service>("lk_service_modifiedby", null); }
            set
            {
                this.OnPropertyChanging("lk_service_modifiedby");
                this.SetRelatedEntities<Service>("lk_service_modifiedby", null, value);
                this.OnPropertyChanged("lk_service_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_service_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_service_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<Service> lk_service_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<Service>("lk_service_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_service_modifiedonbehalfby");
                this.SetRelatedEntities<Service>("lk_service_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_service_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_serviceappointment_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_serviceappointment_createdby")]
        public System.Collections.Generic.IEnumerable<ServiceAppointment> lk_serviceappointment_createdby
        {
            get { return this.GetRelatedEntities<ServiceAppointment>("lk_serviceappointment_createdby", null); }
            set
            {
                this.OnPropertyChanging("lk_serviceappointment_createdby");
                this.SetRelatedEntities<ServiceAppointment>("lk_serviceappointment_createdby", null, value);
                this.OnPropertyChanged("lk_serviceappointment_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_serviceappointment_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_serviceappointment_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<ServiceAppointment> lk_serviceappointment_createdonbehalfby
        {
            get { return this.GetRelatedEntities<ServiceAppointment>("lk_serviceappointment_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_serviceappointment_createdonbehalfby");
                this.SetRelatedEntities<ServiceAppointment>("lk_serviceappointment_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_serviceappointment_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_serviceappointment_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_serviceappointment_modifiedby")]
        public System.Collections.Generic.IEnumerable<ServiceAppointment> lk_serviceappointment_modifiedby
        {
            get { return this.GetRelatedEntities<ServiceAppointment>("lk_serviceappointment_modifiedby", null); }
            set
            {
                this.OnPropertyChanging("lk_serviceappointment_modifiedby");
                this.SetRelatedEntities<ServiceAppointment>("lk_serviceappointment_modifiedby", null, value);
                this.OnPropertyChanged("lk_serviceappointment_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_serviceappointment_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_serviceappointment_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<ServiceAppointment> lk_serviceappointment_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<ServiceAppointment>("lk_serviceappointment_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_serviceappointment_modifiedonbehalfby");
                this.SetRelatedEntities<ServiceAppointment>("lk_serviceappointment_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_serviceappointment_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_serviceendpointbase_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_serviceendpointbase_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<ServiceEndpoint> lk_serviceendpointbase_createdonbehalfby
        {
            get { return this.GetRelatedEntities<ServiceEndpoint>("lk_serviceendpointbase_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_serviceendpointbase_createdonbehalfby");
                this.SetRelatedEntities<ServiceEndpoint>("lk_serviceendpointbase_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_serviceendpointbase_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_serviceendpointbase_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_serviceendpointbase_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<ServiceEndpoint> lk_serviceendpointbase_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<ServiceEndpoint>("lk_serviceendpointbase_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_serviceendpointbase_modifiedonbehalfby");
                this.SetRelatedEntities<ServiceEndpoint>("lk_serviceendpointbase_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_serviceendpointbase_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_SharePointData_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_SharePointData_createdby")]
        public System.Collections.Generic.IEnumerable<SharePointData> lk_SharePointData_createdby
        {
            get { return this.GetRelatedEntities<SharePointData>("lk_SharePointData_createdby", null); }
            set
            {
                this.OnPropertyChanging("lk_SharePointData_createdby");
                this.SetRelatedEntities<SharePointData>("lk_SharePointData_createdby", null, value);
                this.OnPropertyChanged("lk_SharePointData_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_SharePointData_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_SharePointData_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<SharePointData> lk_SharePointData_createdonbehalfby
        {
            get { return this.GetRelatedEntities<SharePointData>("lk_SharePointData_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_SharePointData_createdonbehalfby");
                this.SetRelatedEntities<SharePointData>("lk_SharePointData_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_SharePointData_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_SharePointData_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_SharePointData_modifiedby")]
        public System.Collections.Generic.IEnumerable<SharePointData> lk_SharePointData_modifiedby
        {
            get { return this.GetRelatedEntities<SharePointData>("lk_SharePointData_modifiedby", null); }
            set
            {
                this.OnPropertyChanging("lk_SharePointData_modifiedby");
                this.SetRelatedEntities<SharePointData>("lk_SharePointData_modifiedby", null, value);
                this.OnPropertyChanged("lk_SharePointData_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_SharePointData_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_SharePointData_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<SharePointData> lk_SharePointData_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<SharePointData>("lk_SharePointData_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_SharePointData_modifiedonbehalfby");
                this.SetRelatedEntities<SharePointData>("lk_SharePointData_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_SharePointData_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_sharepointdata_user
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_sharepointdata_user")]
        public System.Collections.Generic.IEnumerable<SharePointData> lk_sharepointdata_user
        {
            get { return this.GetRelatedEntities<SharePointData>("lk_sharepointdata_user", null); }
            set
            {
                this.OnPropertyChanging("lk_sharepointdata_user");
                this.SetRelatedEntities<SharePointData>("lk_sharepointdata_user", null, value);
                this.OnPropertyChanged("lk_sharepointdata_user");
            }
        }

        /// <summary>
        /// 1:N lk_sharepointdocumentbase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_sharepointdocumentbase_createdby")]
        public System.Collections.Generic.IEnumerable<SharePointDocument> lk_sharepointdocumentbase_createdby
        {
            get { return this.GetRelatedEntities<SharePointDocument>("lk_sharepointdocumentbase_createdby", null); }
            set
            {
                this.OnPropertyChanging("lk_sharepointdocumentbase_createdby");
                this.SetRelatedEntities<SharePointDocument>("lk_sharepointdocumentbase_createdby", null, value);
                this.OnPropertyChanged("lk_sharepointdocumentbase_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_sharepointdocumentbase_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_sharepointdocumentbase_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<SharePointDocument> lk_sharepointdocumentbase_createdonbehalfby
        {
            get { return this.GetRelatedEntities<SharePointDocument>("lk_sharepointdocumentbase_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_sharepointdocumentbase_createdonbehalfby");
                this.SetRelatedEntities<SharePointDocument>("lk_sharepointdocumentbase_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_sharepointdocumentbase_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_sharepointdocumentbase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_sharepointdocumentbase_modifiedby")]
        public System.Collections.Generic.IEnumerable<SharePointDocument> lk_sharepointdocumentbase_modifiedby
        {
            get { return this.GetRelatedEntities<SharePointDocument>("lk_sharepointdocumentbase_modifiedby", null); }
            set
            {
                this.OnPropertyChanging("lk_sharepointdocumentbase_modifiedby");
                this.SetRelatedEntities<SharePointDocument>("lk_sharepointdocumentbase_modifiedby", null, value);
                this.OnPropertyChanged("lk_sharepointdocumentbase_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_sharepointdocumentbase_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_sharepointdocumentbase_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<SharePointDocument> lk_sharepointdocumentbase_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<SharePointDocument>("lk_sharepointdocumentbase_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_sharepointdocumentbase_modifiedonbehalfby");
                this.SetRelatedEntities<SharePointDocument>("lk_sharepointdocumentbase_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_sharepointdocumentbase_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_sharepointdocumentlocationbase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_sharepointdocumentlocationbase_createdby")]
        public System.Collections.Generic.IEnumerable<SharePointDocumentLocation> lk_sharepointdocumentlocationbase_createdby
        {
            get { return this.GetRelatedEntities<SharePointDocumentLocation>("lk_sharepointdocumentlocationbase_createdby", null); }
            set
            {
                this.OnPropertyChanging("lk_sharepointdocumentlocationbase_createdby");
                this.SetRelatedEntities<SharePointDocumentLocation>("lk_sharepointdocumentlocationbase_createdby", null, value);
                this.OnPropertyChanged("lk_sharepointdocumentlocationbase_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_sharepointdocumentlocationbase_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_sharepointdocumentlocationbase_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<SharePointDocumentLocation> lk_sharepointdocumentlocationbase_createdonbehalfby
        {
            get { return this.GetRelatedEntities<SharePointDocumentLocation>("lk_sharepointdocumentlocationbase_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_sharepointdocumentlocationbase_createdonbehalfby");
                this.SetRelatedEntities<SharePointDocumentLocation>("lk_sharepointdocumentlocationbase_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_sharepointdocumentlocationbase_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_sharepointdocumentlocationbase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_sharepointdocumentlocationbase_modifiedby")]
        public System.Collections.Generic.IEnumerable<SharePointDocumentLocation> lk_sharepointdocumentlocationbase_modifiedby
        {
            get { return this.GetRelatedEntities<SharePointDocumentLocation>("lk_sharepointdocumentlocationbase_modifiedby", null); }
            set
            {
                this.OnPropertyChanging("lk_sharepointdocumentlocationbase_modifiedby");
                this.SetRelatedEntities<SharePointDocumentLocation>("lk_sharepointdocumentlocationbase_modifiedby", null, value);
                this.OnPropertyChanged("lk_sharepointdocumentlocationbase_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_sharepointdocumentlocationbase_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_sharepointdocumentlocationbase_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<SharePointDocumentLocation> lk_sharepointdocumentlocationbase_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<SharePointDocumentLocation>("lk_sharepointdocumentlocationbase_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_sharepointdocumentlocationbase_modifiedonbehalfby");
                this.SetRelatedEntities<SharePointDocumentLocation>("lk_sharepointdocumentlocationbase_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_sharepointdocumentlocationbase_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_sharepointsitebase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_sharepointsitebase_createdby")]
        public System.Collections.Generic.IEnumerable<SharePointSite> lk_sharepointsitebase_createdby
        {
            get { return this.GetRelatedEntities<SharePointSite>("lk_sharepointsitebase_createdby", null); }
            set
            {
                this.OnPropertyChanging("lk_sharepointsitebase_createdby");
                this.SetRelatedEntities<SharePointSite>("lk_sharepointsitebase_createdby", null, value);
                this.OnPropertyChanged("lk_sharepointsitebase_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_sharepointsitebase_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_sharepointsitebase_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<SharePointSite> lk_sharepointsitebase_createdonbehalfby
        {
            get { return this.GetRelatedEntities<SharePointSite>("lk_sharepointsitebase_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_sharepointsitebase_createdonbehalfby");
                this.SetRelatedEntities<SharePointSite>("lk_sharepointsitebase_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_sharepointsitebase_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_sharepointsitebase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_sharepointsitebase_modifiedby")]
        public System.Collections.Generic.IEnumerable<SharePointSite> lk_sharepointsitebase_modifiedby
        {
            get { return this.GetRelatedEntities<SharePointSite>("lk_sharepointsitebase_modifiedby", null); }
            set
            {
                this.OnPropertyChanging("lk_sharepointsitebase_modifiedby");
                this.SetRelatedEntities<SharePointSite>("lk_sharepointsitebase_modifiedby", null, value);
                this.OnPropertyChanged("lk_sharepointsitebase_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_sharepointsitebase_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_sharepointsitebase_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<SharePointSite> lk_sharepointsitebase_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<SharePointSite>("lk_sharepointsitebase_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_sharepointsitebase_modifiedonbehalfby");
                this.SetRelatedEntities<SharePointSite>("lk_sharepointsitebase_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_sharepointsitebase_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_site_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_site_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<Site> lk_site_createdonbehalfby
        {
            get { return this.GetRelatedEntities<Site>("lk_site_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_site_createdonbehalfby");
                this.SetRelatedEntities<Site>("lk_site_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_site_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_site_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_site_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<Site> lk_site_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<Site>("lk_site_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_site_modifiedonbehalfby");
                this.SetRelatedEntities<Site>("lk_site_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_site_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_sitebase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_sitebase_createdby")]
        public System.Collections.Generic.IEnumerable<Site> lk_sitebase_createdby
        {
            get { return this.GetRelatedEntities<Site>("lk_sitebase_createdby", null); }
            set
            {
                this.OnPropertyChanging("lk_sitebase_createdby");
                this.SetRelatedEntities<Site>("lk_sitebase_createdby", null, value);
                this.OnPropertyChanged("lk_sitebase_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_sitebase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_sitebase_modifiedby")]
        public System.Collections.Generic.IEnumerable<Site> lk_sitebase_modifiedby
        {
            get { return this.GetRelatedEntities<Site>("lk_sitebase_modifiedby", null); }
            set
            {
                this.OnPropertyChanging("lk_sitebase_modifiedby");
                this.SetRelatedEntities<Site>("lk_sitebase_modifiedby", null, value);
                this.OnPropertyChanged("lk_sitebase_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_slabase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_slabase_createdby")]
        public System.Collections.Generic.IEnumerable<SLA> lk_slabase_createdby
        {
            get { return this.GetRelatedEntities<SLA>("lk_slabase_createdby", null); }
            set
            {
                this.OnPropertyChanging("lk_slabase_createdby");
                this.SetRelatedEntities<SLA>("lk_slabase_createdby", null, value);
                this.OnPropertyChanged("lk_slabase_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_slabase_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_slabase_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<SLA> lk_slabase_createdonbehalfby
        {
            get { return this.GetRelatedEntities<SLA>("lk_slabase_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_slabase_createdonbehalfby");
                this.SetRelatedEntities<SLA>("lk_slabase_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_slabase_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_slabase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_slabase_modifiedby")]
        public System.Collections.Generic.IEnumerable<SLA> lk_slabase_modifiedby
        {
            get { return this.GetRelatedEntities<SLA>("lk_slabase_modifiedby", null); }
            set
            {
                this.OnPropertyChanging("lk_slabase_modifiedby");
                this.SetRelatedEntities<SLA>("lk_slabase_modifiedby", null, value);
                this.OnPropertyChanged("lk_slabase_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_slabase_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_slabase_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<SLA> lk_slabase_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<SLA>("lk_slabase_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_slabase_modifiedonbehalfby");
                this.SetRelatedEntities<SLA>("lk_slabase_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_slabase_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_slaitembase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_slaitembase_createdby")]
        public System.Collections.Generic.IEnumerable<SLAItem> lk_slaitembase_createdby
        {
            get { return this.GetRelatedEntities<SLAItem>("lk_slaitembase_createdby", null); }
            set
            {
                this.OnPropertyChanging("lk_slaitembase_createdby");
                this.SetRelatedEntities<SLAItem>("lk_slaitembase_createdby", null, value);
                this.OnPropertyChanged("lk_slaitembase_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_slaitembase_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_slaitembase_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<SLAItem> lk_slaitembase_createdonbehalfby
        {
            get { return this.GetRelatedEntities<SLAItem>("lk_slaitembase_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_slaitembase_createdonbehalfby");
                this.SetRelatedEntities<SLAItem>("lk_slaitembase_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_slaitembase_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_slaitembase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_slaitembase_modifiedby")]
        public System.Collections.Generic.IEnumerable<SLAItem> lk_slaitembase_modifiedby
        {
            get { return this.GetRelatedEntities<SLAItem>("lk_slaitembase_modifiedby", null); }
            set
            {
                this.OnPropertyChanging("lk_slaitembase_modifiedby");
                this.SetRelatedEntities<SLAItem>("lk_slaitembase_modifiedby", null, value);
                this.OnPropertyChanged("lk_slaitembase_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_slaitembase_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_slaitembase_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<SLAItem> lk_slaitembase_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<SLAItem>("lk_slaitembase_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_slaitembase_modifiedonbehalfby");
                this.SetRelatedEntities<SLAItem>("lk_slaitembase_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_slaitembase_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_slakpiinstancebase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_slakpiinstancebase_createdby")]
        public System.Collections.Generic.IEnumerable<SLAKPIInstance> lk_slakpiinstancebase_createdby
        {
            get { return this.GetRelatedEntities<SLAKPIInstance>("lk_slakpiinstancebase_createdby", null); }
            set
            {
                this.OnPropertyChanging("lk_slakpiinstancebase_createdby");
                this.SetRelatedEntities<SLAKPIInstance>("lk_slakpiinstancebase_createdby", null, value);
                this.OnPropertyChanged("lk_slakpiinstancebase_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_slakpiinstancebase_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_slakpiinstancebase_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<SLAKPIInstance> lk_slakpiinstancebase_createdonbehalfby
        {
            get { return this.GetRelatedEntities<SLAKPIInstance>("lk_slakpiinstancebase_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_slakpiinstancebase_createdonbehalfby");
                this.SetRelatedEntities<SLAKPIInstance>("lk_slakpiinstancebase_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_slakpiinstancebase_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_slakpiinstancebase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_slakpiinstancebase_modifiedby")]
        public System.Collections.Generic.IEnumerable<SLAKPIInstance> lk_slakpiinstancebase_modifiedby
        {
            get { return this.GetRelatedEntities<SLAKPIInstance>("lk_slakpiinstancebase_modifiedby", null); }
            set
            {
                this.OnPropertyChanging("lk_slakpiinstancebase_modifiedby");
                this.SetRelatedEntities<SLAKPIInstance>("lk_slakpiinstancebase_modifiedby", null, value);
                this.OnPropertyChanged("lk_slakpiinstancebase_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_slakpiinstancebase_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_slakpiinstancebase_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<SLAKPIInstance> lk_slakpiinstancebase_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<SLAKPIInstance>("lk_slakpiinstancebase_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_slakpiinstancebase_modifiedonbehalfby");
                this.SetRelatedEntities<SLAKPIInstance>("lk_slakpiinstancebase_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_slakpiinstancebase_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_socialactivity_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_socialactivity_createdby")]
        public System.Collections.Generic.IEnumerable<SocialActivity> lk_socialactivity_createdby
        {
            get { return this.GetRelatedEntities<SocialActivity>("lk_socialactivity_createdby", null); }
            set
            {
                this.OnPropertyChanging("lk_socialactivity_createdby");
                this.SetRelatedEntities<SocialActivity>("lk_socialactivity_createdby", null, value);
                this.OnPropertyChanged("lk_socialactivity_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_socialactivity_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_socialactivity_modifiedby")]
        public System.Collections.Generic.IEnumerable<SocialActivity> lk_socialactivity_modifiedby
        {
            get { return this.GetRelatedEntities<SocialActivity>("lk_socialactivity_modifiedby", null); }
            set
            {
                this.OnPropertyChanging("lk_socialactivity_modifiedby");
                this.SetRelatedEntities<SocialActivity>("lk_socialactivity_modifiedby", null, value);
                this.OnPropertyChanged("lk_socialactivity_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_socialactivitybase_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_socialactivitybase_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<SocialActivity> lk_socialactivitybase_createdonbehalfby
        {
            get { return this.GetRelatedEntities<SocialActivity>("lk_socialactivitybase_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_socialactivitybase_createdonbehalfby");
                this.SetRelatedEntities<SocialActivity>("lk_socialactivitybase_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_socialactivitybase_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_socialactivitybase_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_socialactivitybase_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<SocialActivity> lk_socialactivitybase_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<SocialActivity>("lk_socialactivitybase_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_socialactivitybase_modifiedonbehalfby");
                this.SetRelatedEntities<SocialActivity>("lk_socialactivitybase_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_socialactivitybase_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_socialinsightsconfiguration_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_socialinsightsconfiguration_createdby")]
        public System.Collections.Generic.IEnumerable<SocialInsightsConfiguration> lk_socialinsightsconfiguration_createdby
        {
            get { return this.GetRelatedEntities<SocialInsightsConfiguration>("lk_socialinsightsconfiguration_createdby", null); }
            set
            {
                this.OnPropertyChanging("lk_socialinsightsconfiguration_createdby");
                this.SetRelatedEntities<SocialInsightsConfiguration>("lk_socialinsightsconfiguration_createdby", null, value);
                this.OnPropertyChanged("lk_socialinsightsconfiguration_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_socialinsightsconfiguration_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_socialinsightsconfiguration_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<SocialInsightsConfiguration> lk_socialinsightsconfiguration_createdonbehalfby
        {
            get { return this.GetRelatedEntities<SocialInsightsConfiguration>("lk_socialinsightsconfiguration_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_socialinsightsconfiguration_createdonbehalfby");
                this.SetRelatedEntities<SocialInsightsConfiguration>("lk_socialinsightsconfiguration_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_socialinsightsconfiguration_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_socialinsightsconfiguration_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_socialinsightsconfiguration_modifiedby")]
        public System.Collections.Generic.IEnumerable<SocialInsightsConfiguration> lk_socialinsightsconfiguration_modifiedby
        {
            get { return this.GetRelatedEntities<SocialInsightsConfiguration>("lk_socialinsightsconfiguration_modifiedby", null); }
            set
            {
                this.OnPropertyChanging("lk_socialinsightsconfiguration_modifiedby");
                this.SetRelatedEntities<SocialInsightsConfiguration>("lk_socialinsightsconfiguration_modifiedby", null, value);
                this.OnPropertyChanged("lk_socialinsightsconfiguration_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_socialinsightsconfiguration_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_socialinsightsconfiguration_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<SocialInsightsConfiguration> lk_socialinsightsconfiguration_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<SocialInsightsConfiguration>("lk_socialinsightsconfiguration_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_socialinsightsconfiguration_modifiedonbehalfby");
                this.SetRelatedEntities<SocialInsightsConfiguration>("lk_socialinsightsconfiguration_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_socialinsightsconfiguration_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_SocialProfile_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_SocialProfile_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<SocialProfile> lk_SocialProfile_createdonbehalfby
        {
            get { return this.GetRelatedEntities<SocialProfile>("lk_SocialProfile_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_SocialProfile_createdonbehalfby");
                this.SetRelatedEntities<SocialProfile>("lk_SocialProfile_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_SocialProfile_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_SocialProfile_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_SocialProfile_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<SocialProfile> lk_SocialProfile_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<SocialProfile>("lk_SocialProfile_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_SocialProfile_modifiedonbehalfby");
                this.SetRelatedEntities<SocialProfile>("lk_SocialProfile_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_SocialProfile_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_solution_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_solution_createdby")]
        public System.Collections.Generic.IEnumerable<Solution> lk_solution_createdby
        {
            get { return this.GetRelatedEntities<Solution>("lk_solution_createdby", null); }
            set
            {
                this.OnPropertyChanging("lk_solution_createdby");
                this.SetRelatedEntities<Solution>("lk_solution_createdby", null, value);
                this.OnPropertyChanged("lk_solution_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_solution_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_solution_modifiedby")]
        public System.Collections.Generic.IEnumerable<Solution> lk_solution_modifiedby
        {
            get { return this.GetRelatedEntities<Solution>("lk_solution_modifiedby", null); }
            set
            {
                this.OnPropertyChanging("lk_solution_modifiedby");
                this.SetRelatedEntities<Solution>("lk_solution_modifiedby", null, value);
                this.OnPropertyChanged("lk_solution_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_solutionbase_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_solutionbase_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<Solution> lk_solutionbase_createdonbehalfby
        {
            get { return this.GetRelatedEntities<Solution>("lk_solutionbase_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_solutionbase_createdonbehalfby");
                this.SetRelatedEntities<Solution>("lk_solutionbase_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_solutionbase_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_solutionbase_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_solutionbase_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<Solution> lk_solutionbase_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<Solution>("lk_solutionbase_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_solutionbase_modifiedonbehalfby");
                this.SetRelatedEntities<Solution>("lk_solutionbase_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_solutionbase_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_solutioncomponentbase_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_solutioncomponentbase_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<SolutionComponent> lk_solutioncomponentbase_createdonbehalfby
        {
            get { return this.GetRelatedEntities<SolutionComponent>("lk_solutioncomponentbase_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_solutioncomponentbase_createdonbehalfby");
                this.SetRelatedEntities<SolutionComponent>("lk_solutioncomponentbase_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_solutioncomponentbase_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_solutioncomponentbase_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_solutioncomponentbase_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<SolutionComponent> lk_solutioncomponentbase_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<SolutionComponent>("lk_solutioncomponentbase_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_solutioncomponentbase_modifiedonbehalfby");
                this.SetRelatedEntities<SolutionComponent>("lk_solutioncomponentbase_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_solutioncomponentbase_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_subject_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_subject_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<Subject> lk_subject_createdonbehalfby
        {
            get { return this.GetRelatedEntities<Subject>("lk_subject_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_subject_createdonbehalfby");
                this.SetRelatedEntities<Subject>("lk_subject_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_subject_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_subject_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_subject_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<Subject> lk_subject_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<Subject>("lk_subject_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_subject_modifiedonbehalfby");
                this.SetRelatedEntities<Subject>("lk_subject_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_subject_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_subjectbase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_subjectbase_createdby")]
        public System.Collections.Generic.IEnumerable<Subject> lk_subjectbase_createdby
        {
            get { return this.GetRelatedEntities<Subject>("lk_subjectbase_createdby", null); }
            set
            {
                this.OnPropertyChanging("lk_subjectbase_createdby");
                this.SetRelatedEntities<Subject>("lk_subjectbase_createdby", null, value);
                this.OnPropertyChanged("lk_subjectbase_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_subjectbase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_subjectbase_modifiedby")]
        public System.Collections.Generic.IEnumerable<Subject> lk_subjectbase_modifiedby
        {
            get { return this.GetRelatedEntities<Subject>("lk_subjectbase_modifiedby", null); }
            set
            {
                this.OnPropertyChanging("lk_subjectbase_modifiedby");
                this.SetRelatedEntities<Subject>("lk_subjectbase_modifiedby", null, value);
                this.OnPropertyChanged("lk_subjectbase_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_systemuser_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_systemuser_createdonbehalfby", Microsoft.Xrm.Sdk.EntityRole.Referenced)]
        public System.Collections.Generic.IEnumerable<SystemUser> Referencedlk_systemuser_createdonbehalfby
        {
            get { return this.GetRelatedEntities<SystemUser>("lk_systemuser_createdonbehalfby", Microsoft.Xrm.Sdk.EntityRole.Referenced); }
            set
            {
                this.OnPropertyChanging("Referencedlk_systemuser_createdonbehalfby");
                this.SetRelatedEntities<SystemUser>("lk_systemuser_createdonbehalfby", Microsoft.Xrm.Sdk.EntityRole.Referenced, value);
                this.OnPropertyChanged("Referencedlk_systemuser_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_systemuser_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_systemuser_modifiedonbehalfby", Microsoft.Xrm.Sdk.EntityRole.Referenced)]
        public System.Collections.Generic.IEnumerable<SystemUser> Referencedlk_systemuser_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<SystemUser>("lk_systemuser_modifiedonbehalfby", Microsoft.Xrm.Sdk.EntityRole.Referenced); }
            set
            {
                this.OnPropertyChanging("Referencedlk_systemuser_modifiedonbehalfby");
                this.SetRelatedEntities<SystemUser>("lk_systemuser_modifiedonbehalfby", Microsoft.Xrm.Sdk.EntityRole.Referenced, value);
                this.OnPropertyChanged("Referencedlk_systemuser_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_systemuserbase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_systemuserbase_createdby", Microsoft.Xrm.Sdk.EntityRole.Referenced)]
        public System.Collections.Generic.IEnumerable<SystemUser> Referencedlk_systemuserbase_createdby
        {
            get { return this.GetRelatedEntities<SystemUser>("lk_systemuserbase_createdby", Microsoft.Xrm.Sdk.EntityRole.Referenced); }
            set
            {
                this.OnPropertyChanging("Referencedlk_systemuserbase_createdby");
                this.SetRelatedEntities<SystemUser>("lk_systemuserbase_createdby", Microsoft.Xrm.Sdk.EntityRole.Referenced, value);
                this.OnPropertyChanged("Referencedlk_systemuserbase_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_systemuserbase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_systemuserbase_modifiedby", Microsoft.Xrm.Sdk.EntityRole.Referenced)]
        public System.Collections.Generic.IEnumerable<SystemUser> Referencedlk_systemuserbase_modifiedby
        {
            get { return this.GetRelatedEntities<SystemUser>("lk_systemuserbase_modifiedby", Microsoft.Xrm.Sdk.EntityRole.Referenced); }
            set
            {
                this.OnPropertyChanging("Referencedlk_systemuserbase_modifiedby");
                this.SetRelatedEntities<SystemUser>("lk_systemuserbase_modifiedby", Microsoft.Xrm.Sdk.EntityRole.Referenced, value);
                this.OnPropertyChanged("Referencedlk_systemuserbase_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_task_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_task_createdby")]
        public System.Collections.Generic.IEnumerable<Task> lk_task_createdby
        {
            get { return this.GetRelatedEntities<Task>("lk_task_createdby", null); }
            set
            {
                this.OnPropertyChanging("lk_task_createdby");
                this.SetRelatedEntities<Task>("lk_task_createdby", null, value);
                this.OnPropertyChanged("lk_task_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_task_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_task_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<Task> lk_task_createdonbehalfby
        {
            get { return this.GetRelatedEntities<Task>("lk_task_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_task_createdonbehalfby");
                this.SetRelatedEntities<Task>("lk_task_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_task_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_task_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_task_modifiedby")]
        public System.Collections.Generic.IEnumerable<Task> lk_task_modifiedby
        {
            get { return this.GetRelatedEntities<Task>("lk_task_modifiedby", null); }
            set
            {
                this.OnPropertyChanging("lk_task_modifiedby");
                this.SetRelatedEntities<Task>("lk_task_modifiedby", null, value);
                this.OnPropertyChanged("lk_task_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_task_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_task_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<Task> lk_task_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<Task>("lk_task_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_task_modifiedonbehalfby");
                this.SetRelatedEntities<Task>("lk_task_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_task_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_team_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_team_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<Team> lk_team_createdonbehalfby
        {
            get { return this.GetRelatedEntities<Team>("lk_team_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_team_createdonbehalfby");
                this.SetRelatedEntities<Team>("lk_team_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_team_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_team_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_team_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<Team> lk_team_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<Team>("lk_team_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_team_modifiedonbehalfby");
                this.SetRelatedEntities<Team>("lk_team_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_team_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_teambase_administratorid
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_teambase_administratorid")]
        public System.Collections.Generic.IEnumerable<Team> lk_teambase_administratorid
        {
            get { return this.GetRelatedEntities<Team>("lk_teambase_administratorid", null); }
            set
            {
                this.OnPropertyChanging("lk_teambase_administratorid");
                this.SetRelatedEntities<Team>("lk_teambase_administratorid", null, value);
                this.OnPropertyChanged("lk_teambase_administratorid");
            }
        }

        /// <summary>
        /// 1:N lk_teambase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_teambase_createdby")]
        public System.Collections.Generic.IEnumerable<Team> lk_teambase_createdby
        {
            get { return this.GetRelatedEntities<Team>("lk_teambase_createdby", null); }
            set
            {
                this.OnPropertyChanging("lk_teambase_createdby");
                this.SetRelatedEntities<Team>("lk_teambase_createdby", null, value);
                this.OnPropertyChanged("lk_teambase_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_teambase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_teambase_modifiedby")]
        public System.Collections.Generic.IEnumerable<Team> lk_teambase_modifiedby
        {
            get { return this.GetRelatedEntities<Team>("lk_teambase_modifiedby", null); }
            set
            {
                this.OnPropertyChanging("lk_teambase_modifiedby");
                this.SetRelatedEntities<Team>("lk_teambase_modifiedby", null, value);
                this.OnPropertyChanged("lk_teambase_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_teamtemplate_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_teamtemplate_createdby")]
        public System.Collections.Generic.IEnumerable<TeamTemplate> lk_teamtemplate_createdby
        {
            get { return this.GetRelatedEntities<TeamTemplate>("lk_teamtemplate_createdby", null); }
            set
            {
                this.OnPropertyChanging("lk_teamtemplate_createdby");
                this.SetRelatedEntities<TeamTemplate>("lk_teamtemplate_createdby", null, value);
                this.OnPropertyChanged("lk_teamtemplate_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_teamtemplate_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_teamtemplate_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<TeamTemplate> lk_teamtemplate_createdonbehalfby
        {
            get { return this.GetRelatedEntities<TeamTemplate>("lk_teamtemplate_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_teamtemplate_createdonbehalfby");
                this.SetRelatedEntities<TeamTemplate>("lk_teamtemplate_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_teamtemplate_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_teamtemplate_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_teamtemplate_modifiedby")]
        public System.Collections.Generic.IEnumerable<TeamTemplate> lk_teamtemplate_modifiedby
        {
            get { return this.GetRelatedEntities<TeamTemplate>("lk_teamtemplate_modifiedby", null); }
            set
            {
                this.OnPropertyChanging("lk_teamtemplate_modifiedby");
                this.SetRelatedEntities<TeamTemplate>("lk_teamtemplate_modifiedby", null, value);
                this.OnPropertyChanged("lk_teamtemplate_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_teamtemplate_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_teamtemplate_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<TeamTemplate> lk_teamtemplate_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<TeamTemplate>("lk_teamtemplate_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_teamtemplate_modifiedonbehalfby");
                this.SetRelatedEntities<TeamTemplate>("lk_teamtemplate_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_teamtemplate_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_templatebase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_templatebase_createdby")]
        public System.Collections.Generic.IEnumerable<Template> lk_templatebase_createdby
        {
            get { return this.GetRelatedEntities<Template>("lk_templatebase_createdby", null); }
            set
            {
                this.OnPropertyChanging("lk_templatebase_createdby");
                this.SetRelatedEntities<Template>("lk_templatebase_createdby", null, value);
                this.OnPropertyChanged("lk_templatebase_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_templatebase_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_templatebase_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<Template> lk_templatebase_createdonbehalfby
        {
            get { return this.GetRelatedEntities<Template>("lk_templatebase_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_templatebase_createdonbehalfby");
                this.SetRelatedEntities<Template>("lk_templatebase_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_templatebase_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_templatebase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_templatebase_modifiedby")]
        public System.Collections.Generic.IEnumerable<Template> lk_templatebase_modifiedby
        {
            get { return this.GetRelatedEntities<Template>("lk_templatebase_modifiedby", null); }
            set
            {
                this.OnPropertyChanging("lk_templatebase_modifiedby");
                this.SetRelatedEntities<Template>("lk_templatebase_modifiedby", null, value);
                this.OnPropertyChanged("lk_templatebase_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_templatebase_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_templatebase_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<Template> lk_templatebase_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<Template>("lk_templatebase_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_templatebase_modifiedonbehalfby");
                this.SetRelatedEntities<Template>("lk_templatebase_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_templatebase_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_territory_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_territory_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<Territory> lk_territory_createdonbehalfby
        {
            get { return this.GetRelatedEntities<Territory>("lk_territory_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_territory_createdonbehalfby");
                this.SetRelatedEntities<Territory>("lk_territory_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_territory_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_territory_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_territory_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<Territory> lk_territory_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<Territory>("lk_territory_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_territory_modifiedonbehalfby");
                this.SetRelatedEntities<Territory>("lk_territory_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_territory_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_territorybase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_territorybase_createdby")]
        public System.Collections.Generic.IEnumerable<Territory> lk_territorybase_createdby
        {
            get { return this.GetRelatedEntities<Territory>("lk_territorybase_createdby", null); }
            set
            {
                this.OnPropertyChanging("lk_territorybase_createdby");
                this.SetRelatedEntities<Territory>("lk_territorybase_createdby", null, value);
                this.OnPropertyChanged("lk_territorybase_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_territorybase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_territorybase_modifiedby")]
        public System.Collections.Generic.IEnumerable<Territory> lk_territorybase_modifiedby
        {
            get { return this.GetRelatedEntities<Territory>("lk_territorybase_modifiedby", null); }
            set
            {
                this.OnPropertyChanging("lk_territorybase_modifiedby");
                this.SetRelatedEntities<Territory>("lk_territorybase_modifiedby", null, value);
                this.OnPropertyChanged("lk_territorybase_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_timezonedefinition_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_timezonedefinition_createdby")]
        public System.Collections.Generic.IEnumerable<TimeZoneDefinition> lk_timezonedefinition_createdby
        {
            get { return this.GetRelatedEntities<TimeZoneDefinition>("lk_timezonedefinition_createdby", null); }
            set
            {
                this.OnPropertyChanging("lk_timezonedefinition_createdby");
                this.SetRelatedEntities<TimeZoneDefinition>("lk_timezonedefinition_createdby", null, value);
                this.OnPropertyChanged("lk_timezonedefinition_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_timezonedefinition_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_timezonedefinition_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<TimeZoneDefinition> lk_timezonedefinition_createdonbehalfby
        {
            get { return this.GetRelatedEntities<TimeZoneDefinition>("lk_timezonedefinition_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_timezonedefinition_createdonbehalfby");
                this.SetRelatedEntities<TimeZoneDefinition>("lk_timezonedefinition_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_timezonedefinition_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_timezonedefinition_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_timezonedefinition_modifiedby")]
        public System.Collections.Generic.IEnumerable<TimeZoneDefinition> lk_timezonedefinition_modifiedby
        {
            get { return this.GetRelatedEntities<TimeZoneDefinition>("lk_timezonedefinition_modifiedby", null); }
            set
            {
                this.OnPropertyChanging("lk_timezonedefinition_modifiedby");
                this.SetRelatedEntities<TimeZoneDefinition>("lk_timezonedefinition_modifiedby", null, value);
                this.OnPropertyChanged("lk_timezonedefinition_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_timezonedefinition_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_timezonedefinition_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<TimeZoneDefinition> lk_timezonedefinition_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<TimeZoneDefinition>("lk_timezonedefinition_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_timezonedefinition_modifiedonbehalfby");
                this.SetRelatedEntities<TimeZoneDefinition>("lk_timezonedefinition_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_timezonedefinition_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_timezonelocalizedname_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_timezonelocalizedname_createdby")]
        public System.Collections.Generic.IEnumerable<TimeZoneLocalizedName> lk_timezonelocalizedname_createdby
        {
            get { return this.GetRelatedEntities<TimeZoneLocalizedName>("lk_timezonelocalizedname_createdby", null); }
            set
            {
                this.OnPropertyChanging("lk_timezonelocalizedname_createdby");
                this.SetRelatedEntities<TimeZoneLocalizedName>("lk_timezonelocalizedname_createdby", null, value);
                this.OnPropertyChanged("lk_timezonelocalizedname_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_timezonelocalizedname_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_timezonelocalizedname_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<TimeZoneLocalizedName> lk_timezonelocalizedname_createdonbehalfby
        {
            get { return this.GetRelatedEntities<TimeZoneLocalizedName>("lk_timezonelocalizedname_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_timezonelocalizedname_createdonbehalfby");
                this.SetRelatedEntities<TimeZoneLocalizedName>("lk_timezonelocalizedname_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_timezonelocalizedname_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_timezonelocalizedname_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_timezonelocalizedname_modifiedby")]
        public System.Collections.Generic.IEnumerable<TimeZoneLocalizedName> lk_timezonelocalizedname_modifiedby
        {
            get { return this.GetRelatedEntities<TimeZoneLocalizedName>("lk_timezonelocalizedname_modifiedby", null); }
            set
            {
                this.OnPropertyChanging("lk_timezonelocalizedname_modifiedby");
                this.SetRelatedEntities<TimeZoneLocalizedName>("lk_timezonelocalizedname_modifiedby", null, value);
                this.OnPropertyChanged("lk_timezonelocalizedname_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_timezonelocalizedname_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_timezonelocalizedname_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<TimeZoneLocalizedName> lk_timezonelocalizedname_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<TimeZoneLocalizedName>("lk_timezonelocalizedname_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_timezonelocalizedname_modifiedonbehalfby");
                this.SetRelatedEntities<TimeZoneLocalizedName>("lk_timezonelocalizedname_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_timezonelocalizedname_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_timezonerule_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_timezonerule_createdby")]
        public System.Collections.Generic.IEnumerable<TimeZoneRule> lk_timezonerule_createdby
        {
            get { return this.GetRelatedEntities<TimeZoneRule>("lk_timezonerule_createdby", null); }
            set
            {
                this.OnPropertyChanging("lk_timezonerule_createdby");
                this.SetRelatedEntities<TimeZoneRule>("lk_timezonerule_createdby", null, value);
                this.OnPropertyChanged("lk_timezonerule_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_timezonerule_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_timezonerule_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<TimeZoneRule> lk_timezonerule_createdonbehalfby
        {
            get { return this.GetRelatedEntities<TimeZoneRule>("lk_timezonerule_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_timezonerule_createdonbehalfby");
                this.SetRelatedEntities<TimeZoneRule>("lk_timezonerule_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_timezonerule_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_timezonerule_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_timezonerule_modifiedby")]
        public System.Collections.Generic.IEnumerable<TimeZoneRule> lk_timezonerule_modifiedby
        {
            get { return this.GetRelatedEntities<TimeZoneRule>("lk_timezonerule_modifiedby", null); }
            set
            {
                this.OnPropertyChanging("lk_timezonerule_modifiedby");
                this.SetRelatedEntities<TimeZoneRule>("lk_timezonerule_modifiedby", null, value);
                this.OnPropertyChanged("lk_timezonerule_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_timezonerule_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_timezonerule_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<TimeZoneRule> lk_timezonerule_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<TimeZoneRule>("lk_timezonerule_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_timezonerule_modifiedonbehalfby");
                this.SetRelatedEntities<TimeZoneRule>("lk_timezonerule_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_timezonerule_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_tracelog_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_tracelog_createdby")]
        public System.Collections.Generic.IEnumerable<TraceLog> lk_tracelog_createdby
        {
            get { return this.GetRelatedEntities<TraceLog>("lk_tracelog_createdby", null); }
            set
            {
                this.OnPropertyChanging("lk_tracelog_createdby");
                this.SetRelatedEntities<TraceLog>("lk_tracelog_createdby", null, value);
                this.OnPropertyChanged("lk_tracelog_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_tracelog_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_tracelog_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<TraceLog> lk_tracelog_createdonbehalfby
        {
            get { return this.GetRelatedEntities<TraceLog>("lk_tracelog_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_tracelog_createdonbehalfby");
                this.SetRelatedEntities<TraceLog>("lk_tracelog_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_tracelog_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_tracelog_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_tracelog_modifiedby")]
        public System.Collections.Generic.IEnumerable<TraceLog> lk_tracelog_modifiedby
        {
            get { return this.GetRelatedEntities<TraceLog>("lk_tracelog_modifiedby", null); }
            set
            {
                this.OnPropertyChanging("lk_tracelog_modifiedby");
                this.SetRelatedEntities<TraceLog>("lk_tracelog_modifiedby", null, value);
                this.OnPropertyChanged("lk_tracelog_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_tracelog_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_tracelog_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<TraceLog> lk_tracelog_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<TraceLog>("lk_tracelog_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_tracelog_modifiedonbehalfby");
                this.SetRelatedEntities<TraceLog>("lk_tracelog_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_tracelog_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_transactioncurrency_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_transactioncurrency_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<TransactionCurrency> lk_transactioncurrency_createdonbehalfby
        {
            get { return this.GetRelatedEntities<TransactionCurrency>("lk_transactioncurrency_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_transactioncurrency_createdonbehalfby");
                this.SetRelatedEntities<TransactionCurrency>("lk_transactioncurrency_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_transactioncurrency_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_transactioncurrency_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_transactioncurrency_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<TransactionCurrency> lk_transactioncurrency_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<TransactionCurrency>("lk_transactioncurrency_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_transactioncurrency_modifiedonbehalfby");
                this.SetRelatedEntities<TransactionCurrency>("lk_transactioncurrency_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_transactioncurrency_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_transactioncurrencybase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_transactioncurrencybase_createdby")]
        public System.Collections.Generic.IEnumerable<TransactionCurrency> lk_transactioncurrencybase_createdby
        {
            get { return this.GetRelatedEntities<TransactionCurrency>("lk_transactioncurrencybase_createdby", null); }
            set
            {
                this.OnPropertyChanging("lk_transactioncurrencybase_createdby");
                this.SetRelatedEntities<TransactionCurrency>("lk_transactioncurrencybase_createdby", null, value);
                this.OnPropertyChanged("lk_transactioncurrencybase_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_transactioncurrencybase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_transactioncurrencybase_modifiedby")]
        public System.Collections.Generic.IEnumerable<TransactionCurrency> lk_transactioncurrencybase_modifiedby
        {
            get { return this.GetRelatedEntities<TransactionCurrency>("lk_transactioncurrencybase_modifiedby", null); }
            set
            {
                this.OnPropertyChanging("lk_transactioncurrencybase_modifiedby");
                this.SetRelatedEntities<TransactionCurrency>("lk_transactioncurrencybase_modifiedby", null, value);
                this.OnPropertyChanged("lk_transactioncurrencybase_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_transformationmapping_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_transformationmapping_createdby")]
        public System.Collections.Generic.IEnumerable<TransformationMapping> lk_transformationmapping_createdby
        {
            get { return this.GetRelatedEntities<TransformationMapping>("lk_transformationmapping_createdby", null); }
            set
            {
                this.OnPropertyChanging("lk_transformationmapping_createdby");
                this.SetRelatedEntities<TransformationMapping>("lk_transformationmapping_createdby", null, value);
                this.OnPropertyChanged("lk_transformationmapping_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_transformationmapping_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_transformationmapping_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<TransformationMapping> lk_transformationmapping_createdonbehalfby
        {
            get { return this.GetRelatedEntities<TransformationMapping>("lk_transformationmapping_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_transformationmapping_createdonbehalfby");
                this.SetRelatedEntities<TransformationMapping>("lk_transformationmapping_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_transformationmapping_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_transformationmapping_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_transformationmapping_modifiedby")]
        public System.Collections.Generic.IEnumerable<TransformationMapping> lk_transformationmapping_modifiedby
        {
            get { return this.GetRelatedEntities<TransformationMapping>("lk_transformationmapping_modifiedby", null); }
            set
            {
                this.OnPropertyChanging("lk_transformationmapping_modifiedby");
                this.SetRelatedEntities<TransformationMapping>("lk_transformationmapping_modifiedby", null, value);
                this.OnPropertyChanged("lk_transformationmapping_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_transformationmapping_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_transformationmapping_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<TransformationMapping> lk_transformationmapping_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<TransformationMapping>("lk_transformationmapping_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_transformationmapping_modifiedonbehalfby");
                this.SetRelatedEntities<TransformationMapping>("lk_transformationmapping_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_transformationmapping_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_transformationparametermapping_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_transformationparametermapping_createdby")]
        public System.Collections.Generic.IEnumerable<TransformationParameterMapping> lk_transformationparametermapping_createdby
        {
            get { return this.GetRelatedEntities<TransformationParameterMapping>("lk_transformationparametermapping_createdby", null); }
            set
            {
                this.OnPropertyChanging("lk_transformationparametermapping_createdby");
                this.SetRelatedEntities<TransformationParameterMapping>("lk_transformationparametermapping_createdby", null, value);
                this.OnPropertyChanged("lk_transformationparametermapping_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_transformationparametermapping_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_transformationparametermapping_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<TransformationParameterMapping> lk_transformationparametermapping_createdonbehalfby
        {
            get { return this.GetRelatedEntities<TransformationParameterMapping>("lk_transformationparametermapping_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_transformationparametermapping_createdonbehalfby");
                this.SetRelatedEntities<TransformationParameterMapping>("lk_transformationparametermapping_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_transformationparametermapping_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_transformationparametermapping_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_transformationparametermapping_modifiedby")]
        public System.Collections.Generic.IEnumerable<TransformationParameterMapping> lk_transformationparametermapping_modifiedby
        {
            get { return this.GetRelatedEntities<TransformationParameterMapping>("lk_transformationparametermapping_modifiedby", null); }
            set
            {
                this.OnPropertyChanging("lk_transformationparametermapping_modifiedby");
                this.SetRelatedEntities<TransformationParameterMapping>("lk_transformationparametermapping_modifiedby", null, value);
                this.OnPropertyChanged("lk_transformationparametermapping_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_transformationparametermapping_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_transformationparametermapping_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<TransformationParameterMapping> lk_transformationparametermapping_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<TransformationParameterMapping>("lk_transformationparametermapping_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_transformationparametermapping_modifiedonbehalfby");
                this.SetRelatedEntities<TransformationParameterMapping>("lk_transformationparametermapping_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_transformationparametermapping_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_uom_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_uom_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<UoM> lk_uom_createdonbehalfby
        {
            get { return this.GetRelatedEntities<UoM>("lk_uom_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_uom_createdonbehalfby");
                this.SetRelatedEntities<UoM>("lk_uom_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_uom_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_uom_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_uom_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<UoM> lk_uom_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<UoM>("lk_uom_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_uom_modifiedonbehalfby");
                this.SetRelatedEntities<UoM>("lk_uom_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_uom_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_uombase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_uombase_createdby")]
        public System.Collections.Generic.IEnumerable<UoM> lk_uombase_createdby
        {
            get { return this.GetRelatedEntities<UoM>("lk_uombase_createdby", null); }
            set
            {
                this.OnPropertyChanging("lk_uombase_createdby");
                this.SetRelatedEntities<UoM>("lk_uombase_createdby", null, value);
                this.OnPropertyChanged("lk_uombase_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_uombase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_uombase_modifiedby")]
        public System.Collections.Generic.IEnumerable<UoM> lk_uombase_modifiedby
        {
            get { return this.GetRelatedEntities<UoM>("lk_uombase_modifiedby", null); }
            set
            {
                this.OnPropertyChanging("lk_uombase_modifiedby");
                this.SetRelatedEntities<UoM>("lk_uombase_modifiedby", null, value);
                this.OnPropertyChanged("lk_uombase_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_uomschedule_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_uomschedule_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<UoMSchedule> lk_uomschedule_createdonbehalfby
        {
            get { return this.GetRelatedEntities<UoMSchedule>("lk_uomschedule_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_uomschedule_createdonbehalfby");
                this.SetRelatedEntities<UoMSchedule>("lk_uomschedule_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_uomschedule_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_uomschedule_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_uomschedule_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<UoMSchedule> lk_uomschedule_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<UoMSchedule>("lk_uomschedule_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_uomschedule_modifiedonbehalfby");
                this.SetRelatedEntities<UoMSchedule>("lk_uomschedule_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_uomschedule_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_uomschedulebase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_uomschedulebase_createdby")]
        public System.Collections.Generic.IEnumerable<UoMSchedule> lk_uomschedulebase_createdby
        {
            get { return this.GetRelatedEntities<UoMSchedule>("lk_uomschedulebase_createdby", null); }
            set
            {
                this.OnPropertyChanging("lk_uomschedulebase_createdby");
                this.SetRelatedEntities<UoMSchedule>("lk_uomschedulebase_createdby", null, value);
                this.OnPropertyChanged("lk_uomschedulebase_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_uomschedulebase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_uomschedulebase_modifiedby")]
        public System.Collections.Generic.IEnumerable<UoMSchedule> lk_uomschedulebase_modifiedby
        {
            get { return this.GetRelatedEntities<UoMSchedule>("lk_uomschedulebase_modifiedby", null); }
            set
            {
                this.OnPropertyChanging("lk_uomschedulebase_modifiedby");
                this.SetRelatedEntities<UoMSchedule>("lk_uomschedulebase_modifiedby", null, value);
                this.OnPropertyChanged("lk_uomschedulebase_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_userform_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_userform_createdby")]
        public System.Collections.Generic.IEnumerable<UserForm> lk_userform_createdby
        {
            get { return this.GetRelatedEntities<UserForm>("lk_userform_createdby", null); }
            set
            {
                this.OnPropertyChanging("lk_userform_createdby");
                this.SetRelatedEntities<UserForm>("lk_userform_createdby", null, value);
                this.OnPropertyChanged("lk_userform_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_userform_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_userform_modifiedby")]
        public System.Collections.Generic.IEnumerable<UserForm> lk_userform_modifiedby
        {
            get { return this.GetRelatedEntities<UserForm>("lk_userform_modifiedby", null); }
            set
            {
                this.OnPropertyChanging("lk_userform_modifiedby");
                this.SetRelatedEntities<UserForm>("lk_userform_modifiedby", null, value);
                this.OnPropertyChanged("lk_userform_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_userformbase_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_userformbase_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<UserForm> lk_userformbase_createdonbehalfby
        {
            get { return this.GetRelatedEntities<UserForm>("lk_userformbase_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_userformbase_createdonbehalfby");
                this.SetRelatedEntities<UserForm>("lk_userformbase_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_userformbase_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_userformbase_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_userformbase_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<UserForm> lk_userformbase_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<UserForm>("lk_userformbase_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_userformbase_modifiedonbehalfby");
                this.SetRelatedEntities<UserForm>("lk_userformbase_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_userformbase_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_userquery_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_userquery_createdby")]
        public System.Collections.Generic.IEnumerable<UserQuery> lk_userquery_createdby
        {
            get { return this.GetRelatedEntities<UserQuery>("lk_userquery_createdby", null); }
            set
            {
                this.OnPropertyChanging("lk_userquery_createdby");
                this.SetRelatedEntities<UserQuery>("lk_userquery_createdby", null, value);
                this.OnPropertyChanged("lk_userquery_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_userquery_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_userquery_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<UserQuery> lk_userquery_createdonbehalfby
        {
            get { return this.GetRelatedEntities<UserQuery>("lk_userquery_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_userquery_createdonbehalfby");
                this.SetRelatedEntities<UserQuery>("lk_userquery_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_userquery_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_userquery_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_userquery_modifiedby")]
        public System.Collections.Generic.IEnumerable<UserQuery> lk_userquery_modifiedby
        {
            get { return this.GetRelatedEntities<UserQuery>("lk_userquery_modifiedby", null); }
            set
            {
                this.OnPropertyChanging("lk_userquery_modifiedby");
                this.SetRelatedEntities<UserQuery>("lk_userquery_modifiedby", null, value);
                this.OnPropertyChanged("lk_userquery_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_userquery_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_userquery_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<UserQuery> lk_userquery_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<UserQuery>("lk_userquery_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_userquery_modifiedonbehalfby");
                this.SetRelatedEntities<UserQuery>("lk_userquery_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_userquery_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_userqueryvisualization_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_userqueryvisualization_createdby")]
        public System.Collections.Generic.IEnumerable<UserQueryVisualization> lk_userqueryvisualization_createdby
        {
            get { return this.GetRelatedEntities<UserQueryVisualization>("lk_userqueryvisualization_createdby", null); }
            set
            {
                this.OnPropertyChanging("lk_userqueryvisualization_createdby");
                this.SetRelatedEntities<UserQueryVisualization>("lk_userqueryvisualization_createdby", null, value);
                this.OnPropertyChanged("lk_userqueryvisualization_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_userqueryvisualization_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_userqueryvisualization_modifiedby")]
        public System.Collections.Generic.IEnumerable<UserQueryVisualization> lk_userqueryvisualization_modifiedby
        {
            get { return this.GetRelatedEntities<UserQueryVisualization>("lk_userqueryvisualization_modifiedby", null); }
            set
            {
                this.OnPropertyChanging("lk_userqueryvisualization_modifiedby");
                this.SetRelatedEntities<UserQueryVisualization>("lk_userqueryvisualization_modifiedby", null, value);
                this.OnPropertyChanged("lk_userqueryvisualization_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_userqueryvisualizationbase_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_userqueryvisualizationbase_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<UserQueryVisualization> lk_userqueryvisualizationbase_createdonbehalfby
        {
            get { return this.GetRelatedEntities<UserQueryVisualization>("lk_userqueryvisualizationbase_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_userqueryvisualizationbase_createdonbehalfby");
                this.SetRelatedEntities<UserQueryVisualization>("lk_userqueryvisualizationbase_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_userqueryvisualizationbase_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_userqueryvisualizationbase_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_userqueryvisualizationbase_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<UserQueryVisualization> lk_userqueryvisualizationbase_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<UserQueryVisualization>("lk_userqueryvisualizationbase_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_userqueryvisualizationbase_modifiedonbehalfby");
                this.SetRelatedEntities<UserQueryVisualization>("lk_userqueryvisualizationbase_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_userqueryvisualizationbase_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_usersettings_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_usersettings_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<UserSettings> lk_usersettings_createdonbehalfby
        {
            get { return this.GetRelatedEntities<UserSettings>("lk_usersettings_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_usersettings_createdonbehalfby");
                this.SetRelatedEntities<UserSettings>("lk_usersettings_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_usersettings_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_usersettings_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_usersettings_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<UserSettings> lk_usersettings_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<UserSettings>("lk_usersettings_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_usersettings_modifiedonbehalfby");
                this.SetRelatedEntities<UserSettings>("lk_usersettings_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_usersettings_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_usersettingsbase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_usersettingsbase_createdby")]
        public System.Collections.Generic.IEnumerable<UserSettings> lk_usersettingsbase_createdby
        {
            get { return this.GetRelatedEntities<UserSettings>("lk_usersettingsbase_createdby", null); }
            set
            {
                this.OnPropertyChanging("lk_usersettingsbase_createdby");
                this.SetRelatedEntities<UserSettings>("lk_usersettingsbase_createdby", null, value);
                this.OnPropertyChanged("lk_usersettingsbase_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_usersettingsbase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_usersettingsbase_modifiedby")]
        public System.Collections.Generic.IEnumerable<UserSettings> lk_usersettingsbase_modifiedby
        {
            get { return this.GetRelatedEntities<UserSettings>("lk_usersettingsbase_modifiedby", null); }
            set
            {
                this.OnPropertyChanging("lk_usersettingsbase_modifiedby");
                this.SetRelatedEntities<UserSettings>("lk_usersettingsbase_modifiedby", null, value);
                this.OnPropertyChanged("lk_usersettingsbase_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_webresourcebase_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_webresourcebase_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<WebResource> lk_webresourcebase_createdonbehalfby
        {
            get { return this.GetRelatedEntities<WebResource>("lk_webresourcebase_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_webresourcebase_createdonbehalfby");
                this.SetRelatedEntities<WebResource>("lk_webresourcebase_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_webresourcebase_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_webresourcebase_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_webresourcebase_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<WebResource> lk_webresourcebase_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<WebResource>("lk_webresourcebase_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_webresourcebase_modifiedonbehalfby");
                this.SetRelatedEntities<WebResource>("lk_webresourcebase_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_webresourcebase_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_workflowlog_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_workflowlog_createdby")]
        public System.Collections.Generic.IEnumerable<WorkflowLog> lk_workflowlog_createdby
        {
            get { return this.GetRelatedEntities<WorkflowLog>("lk_workflowlog_createdby", null); }
            set
            {
                this.OnPropertyChanging("lk_workflowlog_createdby");
                this.SetRelatedEntities<WorkflowLog>("lk_workflowlog_createdby", null, value);
                this.OnPropertyChanged("lk_workflowlog_createdby");
            }
        }

        /// <summary>
        /// 1:N lk_workflowlog_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_workflowlog_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<WorkflowLog> lk_workflowlog_createdonbehalfby
        {
            get { return this.GetRelatedEntities<WorkflowLog>("lk_workflowlog_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_workflowlog_createdonbehalfby");
                this.SetRelatedEntities<WorkflowLog>("lk_workflowlog_createdonbehalfby", null, value);
                this.OnPropertyChanged("lk_workflowlog_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N lk_workflowlog_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_workflowlog_modifiedby")]
        public System.Collections.Generic.IEnumerable<WorkflowLog> lk_workflowlog_modifiedby
        {
            get { return this.GetRelatedEntities<WorkflowLog>("lk_workflowlog_modifiedby", null); }
            set
            {
                this.OnPropertyChanging("lk_workflowlog_modifiedby");
                this.SetRelatedEntities<WorkflowLog>("lk_workflowlog_modifiedby", null, value);
                this.OnPropertyChanged("lk_workflowlog_modifiedby");
            }
        }

        /// <summary>
        /// 1:N lk_workflowlog_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_workflowlog_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<WorkflowLog> lk_workflowlog_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<WorkflowLog>("lk_workflowlog_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("lk_workflowlog_modifiedonbehalfby");
                this.SetRelatedEntities<WorkflowLog>("lk_workflowlog_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("lk_workflowlog_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N mailbox_regarding_systemuser
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("mailbox_regarding_systemuser")]
        public System.Collections.Generic.IEnumerable<Mailbox> mailbox_regarding_systemuser
        {
            get { return this.GetRelatedEntities<Mailbox>("mailbox_regarding_systemuser", null); }
            set
            {
                this.OnPropertyChanging("mailbox_regarding_systemuser");
                this.SetRelatedEntities<Mailbox>("mailbox_regarding_systemuser", null, value);
                this.OnPropertyChanged("mailbox_regarding_systemuser");
            }
        }

        /// <summary>
        /// 1:N modifiedby_attributemap
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("modifiedby_attributemap")]
        public System.Collections.Generic.IEnumerable<AttributeMap> modifiedby_attributemap
        {
            get { return this.GetRelatedEntities<AttributeMap>("modifiedby_attributemap", null); }
            set
            {
                this.OnPropertyChanging("modifiedby_attributemap");
                this.SetRelatedEntities<AttributeMap>("modifiedby_attributemap", null, value);
                this.OnPropertyChanged("modifiedby_attributemap");
            }
        }

        /// <summary>
        /// 1:N modifiedby_connection
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("modifiedby_connection")]
        public System.Collections.Generic.IEnumerable<Connection> modifiedby_connection
        {
            get { return this.GetRelatedEntities<Connection>("modifiedby_connection", null); }
            set
            {
                this.OnPropertyChanging("modifiedby_connection");
                this.SetRelatedEntities<Connection>("modifiedby_connection", null, value);
                this.OnPropertyChanged("modifiedby_connection");
            }
        }

        /// <summary>
        /// 1:N modifiedby_connection_role
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("modifiedby_connection_role")]
        public System.Collections.Generic.IEnumerable<ConnectionRole> modifiedby_connection_role
        {
            get { return this.GetRelatedEntities<ConnectionRole>("modifiedby_connection_role", null); }
            set
            {
                this.OnPropertyChanging("modifiedby_connection_role");
                this.SetRelatedEntities<ConnectionRole>("modifiedby_connection_role", null, value);
                this.OnPropertyChanged("modifiedby_connection_role");
            }
        }

        /// <summary>
        /// 1:N modifiedby_customer_relationship
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("modifiedby_customer_relationship")]
        public System.Collections.Generic.IEnumerable<CustomerRelationship> modifiedby_customer_relationship
        {
            get { return this.GetRelatedEntities<CustomerRelationship>("modifiedby_customer_relationship", null); }
            set
            {
                this.OnPropertyChanging("modifiedby_customer_relationship");
                this.SetRelatedEntities<CustomerRelationship>("modifiedby_customer_relationship", null, value);
                this.OnPropertyChanged("modifiedby_customer_relationship");
            }
        }

        /// <summary>
        /// 1:N modifiedby_entitymap
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("modifiedby_entitymap")]
        public System.Collections.Generic.IEnumerable<EntityMap> modifiedby_entitymap
        {
            get { return this.GetRelatedEntities<EntityMap>("modifiedby_entitymap", null); }
            set
            {
                this.OnPropertyChanging("modifiedby_entitymap");
                this.SetRelatedEntities<EntityMap>("modifiedby_entitymap", null, value);
                this.OnPropertyChanged("modifiedby_entitymap");
            }
        }

        /// <summary>
        /// 1:N modifiedby_pluginassembly
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("modifiedby_pluginassembly")]
        public System.Collections.Generic.IEnumerable<PluginAssembly> modifiedby_pluginassembly
        {
            get { return this.GetRelatedEntities<PluginAssembly>("modifiedby_pluginassembly", null); }
            set
            {
                this.OnPropertyChanging("modifiedby_pluginassembly");
                this.SetRelatedEntities<PluginAssembly>("modifiedby_pluginassembly", null, value);
                this.OnPropertyChanged("modifiedby_pluginassembly");
            }
        }

        /// <summary>
        /// 1:N modifiedby_plugintype
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("modifiedby_plugintype")]
        public System.Collections.Generic.IEnumerable<PluginType> modifiedby_plugintype
        {
            get { return this.GetRelatedEntities<PluginType>("modifiedby_plugintype", null); }
            set
            {
                this.OnPropertyChanging("modifiedby_plugintype");
                this.SetRelatedEntities<PluginType>("modifiedby_plugintype", null, value);
                this.OnPropertyChanged("modifiedby_plugintype");
            }
        }

        /// <summary>
        /// 1:N modifiedby_plugintypestatistic
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("modifiedby_plugintypestatistic")]
        public System.Collections.Generic.IEnumerable<PluginTypeStatistic> modifiedby_plugintypestatistic
        {
            get { return this.GetRelatedEntities<PluginTypeStatistic>("modifiedby_plugintypestatistic", null); }
            set
            {
                this.OnPropertyChanging("modifiedby_plugintypestatistic");
                this.SetRelatedEntities<PluginTypeStatistic>("modifiedby_plugintypestatistic", null, value);
                this.OnPropertyChanged("modifiedby_plugintypestatistic");
            }
        }

        /// <summary>
        /// 1:N modifiedby_relationship_role
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("modifiedby_relationship_role")]
        public System.Collections.Generic.IEnumerable<RelationshipRole> modifiedby_relationship_role
        {
            get { return this.GetRelatedEntities<RelationshipRole>("modifiedby_relationship_role", null); }
            set
            {
                this.OnPropertyChanging("modifiedby_relationship_role");
                this.SetRelatedEntities<RelationshipRole>("modifiedby_relationship_role", null, value);
                this.OnPropertyChanged("modifiedby_relationship_role");
            }
        }

        /// <summary>
        /// 1:N modifiedby_relationship_role_map
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("modifiedby_relationship_role_map")]
        public System.Collections.Generic.IEnumerable<RelationshipRoleMap> modifiedby_relationship_role_map
        {
            get { return this.GetRelatedEntities<RelationshipRoleMap>("modifiedby_relationship_role_map", null); }
            set
            {
                this.OnPropertyChanging("modifiedby_relationship_role_map");
                this.SetRelatedEntities<RelationshipRoleMap>("modifiedby_relationship_role_map", null, value);
                this.OnPropertyChanged("modifiedby_relationship_role_map");
            }
        }

        /// <summary>
        /// 1:N modifiedby_sdkmessage
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("modifiedby_sdkmessage")]
        public System.Collections.Generic.IEnumerable<SdkMessage> modifiedby_sdkmessage
        {
            get { return this.GetRelatedEntities<SdkMessage>("modifiedby_sdkmessage", null); }
            set
            {
                this.OnPropertyChanging("modifiedby_sdkmessage");
                this.SetRelatedEntities<SdkMessage>("modifiedby_sdkmessage", null, value);
                this.OnPropertyChanged("modifiedby_sdkmessage");
            }
        }

        /// <summary>
        /// 1:N modifiedby_sdkmessagefilter
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("modifiedby_sdkmessagefilter")]
        public System.Collections.Generic.IEnumerable<SdkMessageFilter> modifiedby_sdkmessagefilter
        {
            get { return this.GetRelatedEntities<SdkMessageFilter>("modifiedby_sdkmessagefilter", null); }
            set
            {
                this.OnPropertyChanging("modifiedby_sdkmessagefilter");
                this.SetRelatedEntities<SdkMessageFilter>("modifiedby_sdkmessagefilter", null, value);
                this.OnPropertyChanged("modifiedby_sdkmessagefilter");
            }
        }

        /// <summary>
        /// 1:N modifiedby_sdkmessagepair
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("modifiedby_sdkmessagepair")]
        public System.Collections.Generic.IEnumerable<SdkMessagePair> modifiedby_sdkmessagepair
        {
            get { return this.GetRelatedEntities<SdkMessagePair>("modifiedby_sdkmessagepair", null); }
            set
            {
                this.OnPropertyChanging("modifiedby_sdkmessagepair");
                this.SetRelatedEntities<SdkMessagePair>("modifiedby_sdkmessagepair", null, value);
                this.OnPropertyChanged("modifiedby_sdkmessagepair");
            }
        }

        /// <summary>
        /// 1:N modifiedby_sdkmessageprocessingstep
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("modifiedby_sdkmessageprocessingstep")]
        public System.Collections.Generic.IEnumerable<SdkMessageProcessingStep> modifiedby_sdkmessageprocessingstep
        {
            get { return this.GetRelatedEntities<SdkMessageProcessingStep>("modifiedby_sdkmessageprocessingstep", null); }
            set
            {
                this.OnPropertyChanging("modifiedby_sdkmessageprocessingstep");
                this.SetRelatedEntities<SdkMessageProcessingStep>("modifiedby_sdkmessageprocessingstep", null, value);
                this.OnPropertyChanged("modifiedby_sdkmessageprocessingstep");
            }
        }

        /// <summary>
        /// 1:N modifiedby_sdkmessageprocessingstepimage
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("modifiedby_sdkmessageprocessingstepimage")]
        public System.Collections.Generic.IEnumerable<SdkMessageProcessingStepImage> modifiedby_sdkmessageprocessingstepimage
        {
            get { return this.GetRelatedEntities<SdkMessageProcessingStepImage>("modifiedby_sdkmessageprocessingstepimage", null); }
            set
            {
                this.OnPropertyChanging("modifiedby_sdkmessageprocessingstepimage");
                this.SetRelatedEntities<SdkMessageProcessingStepImage>("modifiedby_sdkmessageprocessingstepimage", null, value);
                this.OnPropertyChanged("modifiedby_sdkmessageprocessingstepimage");
            }
        }

        /// <summary>
        /// 1:N modifiedby_sdkmessageprocessingstepsecureconfig
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("modifiedby_sdkmessageprocessingstepsecureconfig")]
        public System.Collections.Generic.IEnumerable<SdkMessageProcessingStepSecureConfig> modifiedby_sdkmessageprocessingstepsecureconfig
        {
            get { return this.GetRelatedEntities<SdkMessageProcessingStepSecureConfig>("modifiedby_sdkmessageprocessingstepsecureconfig", null); }
            set
            {
                this.OnPropertyChanging("modifiedby_sdkmessageprocessingstepsecureconfig");
                this.SetRelatedEntities<SdkMessageProcessingStepSecureConfig>("modifiedby_sdkmessageprocessingstepsecureconfig", null, value);
                this.OnPropertyChanged("modifiedby_sdkmessageprocessingstepsecureconfig");
            }
        }

        /// <summary>
        /// 1:N modifiedby_sdkmessagerequest
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("modifiedby_sdkmessagerequest")]
        public System.Collections.Generic.IEnumerable<SdkMessageRequest> modifiedby_sdkmessagerequest
        {
            get { return this.GetRelatedEntities<SdkMessageRequest>("modifiedby_sdkmessagerequest", null); }
            set
            {
                this.OnPropertyChanging("modifiedby_sdkmessagerequest");
                this.SetRelatedEntities<SdkMessageRequest>("modifiedby_sdkmessagerequest", null, value);
                this.OnPropertyChanged("modifiedby_sdkmessagerequest");
            }
        }

        /// <summary>
        /// 1:N modifiedby_sdkmessagerequestfield
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("modifiedby_sdkmessagerequestfield")]
        public System.Collections.Generic.IEnumerable<SdkMessageRequestField> modifiedby_sdkmessagerequestfield
        {
            get { return this.GetRelatedEntities<SdkMessageRequestField>("modifiedby_sdkmessagerequestfield", null); }
            set
            {
                this.OnPropertyChanging("modifiedby_sdkmessagerequestfield");
                this.SetRelatedEntities<SdkMessageRequestField>("modifiedby_sdkmessagerequestfield", null, value);
                this.OnPropertyChanged("modifiedby_sdkmessagerequestfield");
            }
        }

        /// <summary>
        /// 1:N modifiedby_sdkmessageresponse
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("modifiedby_sdkmessageresponse")]
        public System.Collections.Generic.IEnumerable<SdkMessageResponse> modifiedby_sdkmessageresponse
        {
            get { return this.GetRelatedEntities<SdkMessageResponse>("modifiedby_sdkmessageresponse", null); }
            set
            {
                this.OnPropertyChanging("modifiedby_sdkmessageresponse");
                this.SetRelatedEntities<SdkMessageResponse>("modifiedby_sdkmessageresponse", null, value);
                this.OnPropertyChanged("modifiedby_sdkmessageresponse");
            }
        }

        /// <summary>
        /// 1:N modifiedby_sdkmessageresponsefield
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("modifiedby_sdkmessageresponsefield")]
        public System.Collections.Generic.IEnumerable<SdkMessageResponseField> modifiedby_sdkmessageresponsefield
        {
            get { return this.GetRelatedEntities<SdkMessageResponseField>("modifiedby_sdkmessageresponsefield", null); }
            set
            {
                this.OnPropertyChanging("modifiedby_sdkmessageresponsefield");
                this.SetRelatedEntities<SdkMessageResponseField>("modifiedby_sdkmessageresponsefield", null, value);
                this.OnPropertyChanged("modifiedby_sdkmessageresponsefield");
            }
        }

        /// <summary>
        /// 1:N modifiedby_serviceendpoint
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("modifiedby_serviceendpoint")]
        public System.Collections.Generic.IEnumerable<ServiceEndpoint> modifiedby_serviceendpoint
        {
            get { return this.GetRelatedEntities<ServiceEndpoint>("modifiedby_serviceendpoint", null); }
            set
            {
                this.OnPropertyChanging("modifiedby_serviceendpoint");
                this.SetRelatedEntities<ServiceEndpoint>("modifiedby_serviceendpoint", null, value);
                this.OnPropertyChanged("modifiedby_serviceendpoint");
            }
        }

        /// <summary>
        /// 1:N modifiedonbehalfby_attributemap
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("modifiedonbehalfby_attributemap")]
        public System.Collections.Generic.IEnumerable<AttributeMap> modifiedonbehalfby_attributemap
        {
            get { return this.GetRelatedEntities<AttributeMap>("modifiedonbehalfby_attributemap", null); }
            set
            {
                this.OnPropertyChanging("modifiedonbehalfby_attributemap");
                this.SetRelatedEntities<AttributeMap>("modifiedonbehalfby_attributemap", null, value);
                this.OnPropertyChanged("modifiedonbehalfby_attributemap");
            }
        }

        /// <summary>
        /// 1:N modifiedonbehalfby_customer_relationship
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("modifiedonbehalfby_customer_relationship")]
        public System.Collections.Generic.IEnumerable<CustomerRelationship> modifiedonbehalfby_customer_relationship
        {
            get { return this.GetRelatedEntities<CustomerRelationship>("modifiedonbehalfby_customer_relationship", null); }
            set
            {
                this.OnPropertyChanging("modifiedonbehalfby_customer_relationship");
                this.SetRelatedEntities<CustomerRelationship>("modifiedonbehalfby_customer_relationship", null, value);
                this.OnPropertyChanged("modifiedonbehalfby_customer_relationship");
            }
        }

        /// <summary>
        /// 1:N msdyn_systemuser_wallsavedqueryusersettings_userid
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_systemuser_wallsavedqueryusersettings_userid")]
        public System.Collections.Generic.IEnumerable<msdyn_wallsavedqueryusersettings> msdyn_systemuser_wallsavedqueryusersettings_userid
        {
            get { return this.GetRelatedEntities<msdyn_wallsavedqueryusersettings>("msdyn_systemuser_wallsavedqueryusersettings_userid", null); }
            set
            {
                this.OnPropertyChanging("msdyn_systemuser_wallsavedqueryusersettings_userid");
                this.SetRelatedEntities<msdyn_wallsavedqueryusersettings>("msdyn_systemuser_wallsavedqueryusersettings_userid", null, value);
                this.OnPropertyChanged("msdyn_systemuser_wallsavedqueryusersettings_userid");
            }
        }

        /// <summary>
        /// 1:N opportunity_owning_user
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("opportunity_owning_user")]
        public System.Collections.Generic.IEnumerable<Opportunity> opportunity_owning_user
        {
            get { return this.GetRelatedEntities<Opportunity>("opportunity_owning_user", null); }
            set
            {
                this.OnPropertyChanging("opportunity_owning_user");
                this.SetRelatedEntities<Opportunity>("opportunity_owning_user", null, value);
                this.OnPropertyChanged("opportunity_owning_user");
            }
        }

        /// <summary>
        /// 1:N OwnerMapping_SystemUser
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("OwnerMapping_SystemUser")]
        public System.Collections.Generic.IEnumerable<OwnerMapping> OwnerMapping_SystemUser
        {
            get { return this.GetRelatedEntities<OwnerMapping>("OwnerMapping_SystemUser", null); }
            set
            {
                this.OnPropertyChanging("OwnerMapping_SystemUser");
                this.SetRelatedEntities<OwnerMapping>("OwnerMapping_SystemUser", null, value);
                this.OnPropertyChanged("OwnerMapping_SystemUser");
            }
        }

        /// <summary>
        /// 1:N OwningUser_Dynamicpropertyinsatance
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("OwningUser_Dynamicpropertyinsatance")]
        public System.Collections.Generic.IEnumerable<DynamicPropertyInstance> OwningUser_Dynamicpropertyinsatance
        {
            get { return this.GetRelatedEntities<DynamicPropertyInstance>("OwningUser_Dynamicpropertyinsatance", null); }
            set
            {
                this.OnPropertyChanging("OwningUser_Dynamicpropertyinsatance");
                this.SetRelatedEntities<DynamicPropertyInstance>("OwningUser_Dynamicpropertyinsatance", null, value);
                this.OnPropertyChanged("OwningUser_Dynamicpropertyinsatance");
            }
        }

        /// <summary>
        /// 1:N queue_primary_user
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("queue_primary_user")]
        public System.Collections.Generic.IEnumerable<Queue> queue_primary_user
        {
            get { return this.GetRelatedEntities<Queue>("queue_primary_user", null); }
            set
            {
                this.OnPropertyChanging("queue_primary_user");
                this.SetRelatedEntities<Queue>("queue_primary_user", null, value);
                this.OnPropertyChanged("queue_primary_user");
            }
        }

        /// <summary>
        /// 1:N socialProfile_owning_user
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("socialProfile_owning_user")]
        public System.Collections.Generic.IEnumerable<SocialProfile> socialProfile_owning_user
        {
            get { return this.GetRelatedEntities<SocialProfile>("socialProfile_owning_user", null); }
            set
            {
                this.OnPropertyChanging("socialProfile_owning_user");
                this.SetRelatedEntities<SocialProfile>("socialProfile_owning_user", null, value);
                this.OnPropertyChanged("socialProfile_owning_user");
            }
        }

        /// <summary>
        /// 1:N system_user_accounts
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("system_user_accounts")]
        public System.Collections.Generic.IEnumerable<Account> system_user_accounts
        {
            get { return this.GetRelatedEntities<Account>("system_user_accounts", null); }
            set
            {
                this.OnPropertyChanging("system_user_accounts");
                this.SetRelatedEntities<Account>("system_user_accounts", null, value);
                this.OnPropertyChanged("system_user_accounts");
            }
        }

        /// <summary>
        /// 1:N system_user_activity_parties
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("system_user_activity_parties")]
        public System.Collections.Generic.IEnumerable<ActivityParty> system_user_activity_parties
        {
            get { return this.GetRelatedEntities<ActivityParty>("system_user_activity_parties", null); }
            set
            {
                this.OnPropertyChanging("system_user_activity_parties");
                this.SetRelatedEntities<ActivityParty>("system_user_activity_parties", null, value);
                this.OnPropertyChanged("system_user_activity_parties");
            }
        }

        /// <summary>
        /// 1:N system_user_asyncoperation
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("system_user_asyncoperation")]
        public System.Collections.Generic.IEnumerable<AsyncOperation> system_user_asyncoperation
        {
            get { return this.GetRelatedEntities<AsyncOperation>("system_user_asyncoperation", null); }
            set
            {
                this.OnPropertyChanging("system_user_asyncoperation");
                this.SetRelatedEntities<AsyncOperation>("system_user_asyncoperation", null, value);
                this.OnPropertyChanged("system_user_asyncoperation");
            }
        }

        /// <summary>
        /// 1:N system_user_contacts
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("system_user_contacts")]
        public System.Collections.Generic.IEnumerable<Contact> system_user_contacts
        {
            get { return this.GetRelatedEntities<Contact>("system_user_contacts", null); }
            set
            {
                this.OnPropertyChanging("system_user_contacts");
                this.SetRelatedEntities<Contact>("system_user_contacts", null, value);
                this.OnPropertyChanged("system_user_contacts");
            }
        }

        /// <summary>
        /// 1:N system_user_email_templates
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("system_user_email_templates")]
        public System.Collections.Generic.IEnumerable<Template> system_user_email_templates
        {
            get { return this.GetRelatedEntities<Template>("system_user_email_templates", null); }
            set
            {
                this.OnPropertyChanging("system_user_email_templates");
                this.SetRelatedEntities<Template>("system_user_email_templates", null, value);
                this.OnPropertyChanged("system_user_email_templates");
            }
        }

        /// <summary>
        /// 1:N system_user_incidents
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("system_user_incidents")]
        public System.Collections.Generic.IEnumerable<Incident> system_user_incidents
        {
            get { return this.GetRelatedEntities<Incident>("system_user_incidents", null); }
            set
            {
                this.OnPropertyChanging("system_user_incidents");
                this.SetRelatedEntities<Incident>("system_user_incidents", null, value);
                this.OnPropertyChanged("system_user_incidents");
            }
        }

        /// <summary>
        /// 1:N system_user_invoicedetail
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("system_user_invoicedetail")]
        public System.Collections.Generic.IEnumerable<InvoiceDetail> system_user_invoicedetail
        {
            get { return this.GetRelatedEntities<InvoiceDetail>("system_user_invoicedetail", null); }
            set
            {
                this.OnPropertyChanging("system_user_invoicedetail");
                this.SetRelatedEntities<InvoiceDetail>("system_user_invoicedetail", null, value);
                this.OnPropertyChanged("system_user_invoicedetail");
            }
        }

        /// <summary>
        /// 1:N system_user_invoices
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("system_user_invoices")]
        public System.Collections.Generic.IEnumerable<Invoice> system_user_invoices
        {
            get { return this.GetRelatedEntities<Invoice>("system_user_invoices", null); }
            set
            {
                this.OnPropertyChanging("system_user_invoices");
                this.SetRelatedEntities<Invoice>("system_user_invoices", null, value);
                this.OnPropertyChanged("system_user_invoices");
            }
        }

        /// <summary>
        /// 1:N system_user_orders
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("system_user_orders")]
        public System.Collections.Generic.IEnumerable<SalesOrder> system_user_orders
        {
            get { return this.GetRelatedEntities<SalesOrder>("system_user_orders", null); }
            set
            {
                this.OnPropertyChanging("system_user_orders");
                this.SetRelatedEntities<SalesOrder>("system_user_orders", null, value);
                this.OnPropertyChanged("system_user_orders");
            }
        }

        /// <summary>
        /// 1:N system_user_quotedetail
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("system_user_quotedetail")]
        public System.Collections.Generic.IEnumerable<QuoteDetail> system_user_quotedetail
        {
            get { return this.GetRelatedEntities<QuoteDetail>("system_user_quotedetail", null); }
            set
            {
                this.OnPropertyChanging("system_user_quotedetail");
                this.SetRelatedEntities<QuoteDetail>("system_user_quotedetail", null, value);
                this.OnPropertyChanged("system_user_quotedetail");
            }
        }

        /// <summary>
        /// 1:N system_user_quotes
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("system_user_quotes")]
        public System.Collections.Generic.IEnumerable<Quote> system_user_quotes
        {
            get { return this.GetRelatedEntities<Quote>("system_user_quotes", null); }
            set
            {
                this.OnPropertyChanging("system_user_quotes");
                this.SetRelatedEntities<Quote>("system_user_quotes", null, value);
                this.OnPropertyChanged("system_user_quotes");
            }
        }

        /// <summary>
        /// 1:N system_user_sales_literature
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("system_user_sales_literature")]
        public System.Collections.Generic.IEnumerable<SalesLiterature> system_user_sales_literature
        {
            get { return this.GetRelatedEntities<SalesLiterature>("system_user_sales_literature", null); }
            set
            {
                this.OnPropertyChanging("system_user_sales_literature");
                this.SetRelatedEntities<SalesLiterature>("system_user_sales_literature", null, value);
                this.OnPropertyChanged("system_user_sales_literature");
            }
        }

        /// <summary>
        /// 1:N system_user_salesorderdetail
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("system_user_salesorderdetail")]
        public System.Collections.Generic.IEnumerable<SalesOrderDetail> system_user_salesorderdetail
        {
            get { return this.GetRelatedEntities<SalesOrderDetail>("system_user_salesorderdetail", null); }
            set
            {
                this.OnPropertyChanging("system_user_salesorderdetail");
                this.SetRelatedEntities<SalesOrderDetail>("system_user_salesorderdetail", null, value);
                this.OnPropertyChanged("system_user_salesorderdetail");
            }
        }

        /// <summary>
        /// 1:N system_user_service_appointments
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("system_user_service_appointments")]
        public System.Collections.Generic.IEnumerable<ServiceAppointment> system_user_service_appointments
        {
            get { return this.GetRelatedEntities<ServiceAppointment>("system_user_service_appointments", null); }
            set
            {
                this.OnPropertyChanging("system_user_service_appointments");
                this.SetRelatedEntities<ServiceAppointment>("system_user_service_appointments", null, value);
                this.OnPropertyChanged("system_user_service_appointments");
            }
        }

        /// <summary>
        /// 1:N system_user_service_contracts
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("system_user_service_contracts")]
        public System.Collections.Generic.IEnumerable<Contract> system_user_service_contracts
        {
            get { return this.GetRelatedEntities<Contract>("system_user_service_contracts", null); }
            set
            {
                this.OnPropertyChanging("system_user_service_contracts");
                this.SetRelatedEntities<Contract>("system_user_service_contracts", null, value);
                this.OnPropertyChanged("system_user_service_contracts");
            }
        }

        /// <summary>
        /// 1:N system_user_territories
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("system_user_territories")]
        public System.Collections.Generic.IEnumerable<Territory> system_user_territories
        {
            get { return this.GetRelatedEntities<Territory>("system_user_territories", null); }
            set
            {
                this.OnPropertyChanging("system_user_territories");
                this.SetRelatedEntities<Territory>("system_user_territories", null, value);
                this.OnPropertyChanged("system_user_territories");
            }
        }

        /// <summary>
        /// 1:N system_user_workflow
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("system_user_workflow")]
        public System.Collections.Generic.IEnumerable<Workflow> system_user_workflow
        {
            get { return this.GetRelatedEntities<Workflow>("system_user_workflow", null); }
            set
            {
                this.OnPropertyChanging("system_user_workflow");
                this.SetRelatedEntities<Workflow>("system_user_workflow", null, value);
                this.OnPropertyChanged("system_user_workflow");
            }
        }

        /// <summary>
        /// 1:N SystemUser_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SystemUser_AsyncOperations")]
        public System.Collections.Generic.IEnumerable<AsyncOperation> SystemUser_AsyncOperations
        {
            get { return this.GetRelatedEntities<AsyncOperation>("SystemUser_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("SystemUser_AsyncOperations");
                this.SetRelatedEntities<AsyncOperation>("SystemUser_AsyncOperations", null, value);
                this.OnPropertyChanged("SystemUser_AsyncOperations");
            }
        }

        /// <summary>
        /// 1:N SystemUser_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SystemUser_BulkDeleteFailures")]
        public System.Collections.Generic.IEnumerable<BulkDeleteFailure> SystemUser_BulkDeleteFailures
        {
            get { return this.GetRelatedEntities<BulkDeleteFailure>("SystemUser_BulkDeleteFailures", null); }
            set
            {
                this.OnPropertyChanging("SystemUser_BulkDeleteFailures");
                this.SetRelatedEntities<BulkDeleteFailure>("SystemUser_BulkDeleteFailures", null, value);
                this.OnPropertyChanged("SystemUser_BulkDeleteFailures");
            }
        }

        /// <summary>
        /// 1:N SystemUser_Campaigns
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SystemUser_Campaigns")]
        public System.Collections.Generic.IEnumerable<Campaign> SystemUser_Campaigns
        {
            get { return this.GetRelatedEntities<Campaign>("SystemUser_Campaigns", null); }
            set
            {
                this.OnPropertyChanging("SystemUser_Campaigns");
                this.SetRelatedEntities<Campaign>("SystemUser_Campaigns", null, value);
                this.OnPropertyChanged("SystemUser_Campaigns");
            }
        }

        /// <summary>
        /// 1:N systemuser_connections1
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("systemuser_connections1")]
        public System.Collections.Generic.IEnumerable<Connection> systemuser_connections1
        {
            get { return this.GetRelatedEntities<Connection>("systemuser_connections1", null); }
            set
            {
                this.OnPropertyChanging("systemuser_connections1");
                this.SetRelatedEntities<Connection>("systemuser_connections1", null, value);
                this.OnPropertyChanged("systemuser_connections1");
            }
        }

        /// <summary>
        /// 1:N systemuser_connections2
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("systemuser_connections2")]
        public System.Collections.Generic.IEnumerable<Connection> systemuser_connections2
        {
            get { return this.GetRelatedEntities<Connection>("systemuser_connections2", null); }
            set
            {
                this.OnPropertyChanging("systemuser_connections2");
                this.SetRelatedEntities<Connection>("systemuser_connections2", null, value);
                this.OnPropertyChanged("systemuser_connections2");
            }
        }

        /// <summary>
        /// 1:N SystemUser_DuplicateBaseRecord
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SystemUser_DuplicateBaseRecord")]
        public System.Collections.Generic.IEnumerable<DuplicateRecord> SystemUser_DuplicateBaseRecord
        {
            get { return this.GetRelatedEntities<DuplicateRecord>("SystemUser_DuplicateBaseRecord", null); }
            set
            {
                this.OnPropertyChanging("SystemUser_DuplicateBaseRecord");
                this.SetRelatedEntities<DuplicateRecord>("SystemUser_DuplicateBaseRecord", null, value);
                this.OnPropertyChanged("SystemUser_DuplicateBaseRecord");
            }
        }

        /// <summary>
        /// 1:N SystemUser_DuplicateMatchingRecord
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SystemUser_DuplicateMatchingRecord")]
        public System.Collections.Generic.IEnumerable<DuplicateRecord> SystemUser_DuplicateMatchingRecord
        {
            get { return this.GetRelatedEntities<DuplicateRecord>("SystemUser_DuplicateMatchingRecord", null); }
            set
            {
                this.OnPropertyChanging("SystemUser_DuplicateMatchingRecord");
                this.SetRelatedEntities<DuplicateRecord>("SystemUser_DuplicateMatchingRecord", null, value);
                this.OnPropertyChanged("SystemUser_DuplicateMatchingRecord");
            }
        }

        /// <summary>
        /// 1:N SystemUser_DuplicateRules
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SystemUser_DuplicateRules")]
        public System.Collections.Generic.IEnumerable<DuplicateRule> SystemUser_DuplicateRules
        {
            get { return this.GetRelatedEntities<DuplicateRule>("SystemUser_DuplicateRules", null); }
            set
            {
                this.OnPropertyChanging("SystemUser_DuplicateRules");
                this.SetRelatedEntities<DuplicateRule>("SystemUser_DuplicateRules", null, value);
                this.OnPropertyChanged("SystemUser_DuplicateRules");
            }
        }

        /// <summary>
        /// 1:N SystemUser_Email_EmailSender
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SystemUser_Email_EmailSender")]
        public System.Collections.Generic.IEnumerable<Email> SystemUser_Email_EmailSender
        {
            get { return this.GetRelatedEntities<Email>("SystemUser_Email_EmailSender", null); }
            set
            {
                this.OnPropertyChanging("SystemUser_Email_EmailSender");
                this.SetRelatedEntities<Email>("SystemUser_Email_EmailSender", null, value);
                this.OnPropertyChanged("SystemUser_Email_EmailSender");
            }
        }

        /// <summary>
        /// 1:N SystemUser_ImportFiles
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SystemUser_ImportFiles")]
        public System.Collections.Generic.IEnumerable<ImportFile> SystemUser_ImportFiles
        {
            get { return this.GetRelatedEntities<ImportFile>("SystemUser_ImportFiles", null); }
            set
            {
                this.OnPropertyChanging("SystemUser_ImportFiles");
                this.SetRelatedEntities<ImportFile>("SystemUser_ImportFiles", null, value);
                this.OnPropertyChanged("SystemUser_ImportFiles");
            }
        }

        /// <summary>
        /// 1:N SystemUser_ImportLogs
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SystemUser_ImportLogs")]
        public System.Collections.Generic.IEnumerable<ImportLog> SystemUser_ImportLogs
        {
            get { return this.GetRelatedEntities<ImportLog>("SystemUser_ImportLogs", null); }
            set
            {
                this.OnPropertyChanging("SystemUser_ImportLogs");
                this.SetRelatedEntities<ImportLog>("SystemUser_ImportLogs", null, value);
                this.OnPropertyChanged("SystemUser_ImportLogs");
            }
        }

        /// <summary>
        /// 1:N SystemUser_ImportMaps
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SystemUser_ImportMaps")]
        public System.Collections.Generic.IEnumerable<ImportMap> SystemUser_ImportMaps
        {
            get { return this.GetRelatedEntities<ImportMap>("SystemUser_ImportMaps", null); }
            set
            {
                this.OnPropertyChanging("SystemUser_ImportMaps");
                this.SetRelatedEntities<ImportMap>("SystemUser_ImportMaps", null, value);
                this.OnPropertyChanged("SystemUser_ImportMaps");
            }
        }

        /// <summary>
        /// 1:N SystemUser_Imports
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SystemUser_Imports")]
        public System.Collections.Generic.IEnumerable<Import> SystemUser_Imports
        {
            get { return this.GetRelatedEntities<Import>("SystemUser_Imports", null); }
            set
            {
                this.OnPropertyChanging("SystemUser_Imports");
                this.SetRelatedEntities<Import>("SystemUser_Imports", null, value);
                this.OnPropertyChanged("SystemUser_Imports");
            }
        }

        /// <summary>
        /// 1:N systemuser_PostFollows
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("systemuser_PostFollows")]
        public System.Collections.Generic.IEnumerable<PostFollow> systemuser_PostFollows
        {
            get { return this.GetRelatedEntities<PostFollow>("systemuser_PostFollows", null); }
            set
            {
                this.OnPropertyChanging("systemuser_PostFollows");
                this.SetRelatedEntities<PostFollow>("systemuser_PostFollows", null, value);
                this.OnPropertyChanged("systemuser_PostFollows");
            }
        }

        /// <summary>
        /// 1:N systemuser_principalobjectattributeaccess
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("systemuser_principalobjectattributeaccess")]
        public System.Collections.Generic.IEnumerable<PrincipalObjectAttributeAccess> systemuser_principalobjectattributeaccess
        {
            get { return this.GetRelatedEntities<PrincipalObjectAttributeAccess>("systemuser_principalobjectattributeaccess", null); }
            set
            {
                this.OnPropertyChanging("systemuser_principalobjectattributeaccess");
                this.SetRelatedEntities<PrincipalObjectAttributeAccess>("systemuser_principalobjectattributeaccess", null, value);
                this.OnPropertyChanged("systemuser_principalobjectattributeaccess");
            }
        }

        /// <summary>
        /// 1:N systemuser_principalobjectattributeaccess_principalid
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("systemuser_principalobjectattributeaccess_principalid")]
        public System.Collections.Generic.IEnumerable<PrincipalObjectAttributeAccess> systemuser_principalobjectattributeaccess_principalid
        {
            get { return this.GetRelatedEntities<PrincipalObjectAttributeAccess>("systemuser_principalobjectattributeaccess_principalid", null); }
            set
            {
                this.OnPropertyChanging("systemuser_principalobjectattributeaccess_principalid");
                this.SetRelatedEntities<PrincipalObjectAttributeAccess>("systemuser_principalobjectattributeaccess_principalid", null, value);
                this.OnPropertyChanged("systemuser_principalobjectattributeaccess_principalid");
            }
        }

        /// <summary>
        /// 1:N SystemUser_ProcessSessions
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SystemUser_ProcessSessions")]
        public System.Collections.Generic.IEnumerable<ProcessSession> SystemUser_ProcessSessions
        {
            get { return this.GetRelatedEntities<ProcessSession>("SystemUser_ProcessSessions", null); }
            set
            {
                this.OnPropertyChanging("SystemUser_ProcessSessions");
                this.SetRelatedEntities<ProcessSession>("SystemUser_ProcessSessions", null, value);
                this.OnPropertyChanged("SystemUser_ProcessSessions");
            }
        }

        /// <summary>
        /// 1:N systemuser_resources
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("systemuser_resources")]
        public System.Collections.Generic.IEnumerable<Resource> systemuser_resources
        {
            get { return this.GetRelatedEntities<Resource>("systemuser_resources", null); }
            set
            {
                this.OnPropertyChanging("systemuser_resources");
                this.SetRelatedEntities<Resource>("systemuser_resources", null, value);
                this.OnPropertyChanged("systemuser_resources");
            }
        }

        /// <summary>
        /// 1:N user_accounts
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_accounts")]
        public System.Collections.Generic.IEnumerable<Account> user_accounts
        {
            get { return this.GetRelatedEntities<Account>("user_accounts", null); }
            set
            {
                this.OnPropertyChanging("user_accounts");
                this.SetRelatedEntities<Account>("user_accounts", null, value);
                this.OnPropertyChanged("user_accounts");
            }
        }

        /// <summary>
        /// 1:N user_activity
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_activity")]
        public System.Collections.Generic.IEnumerable<ActivityPointer> user_activity
        {
            get { return this.GetRelatedEntities<ActivityPointer>("user_activity", null); }
            set
            {
                this.OnPropertyChanging("user_activity");
                this.SetRelatedEntities<ActivityPointer>("user_activity", null, value);
                this.OnPropertyChanged("user_activity");
            }
        }

        /// <summary>
        /// 1:N user_appointment
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_appointment")]
        public System.Collections.Generic.IEnumerable<Appointment> user_appointment
        {
            get { return this.GetRelatedEntities<Appointment>("user_appointment", null); }
            set
            {
                this.OnPropertyChanging("user_appointment");
                this.SetRelatedEntities<Appointment>("user_appointment", null, value);
                this.OnPropertyChanged("user_appointment");
            }
        }

        /// <summary>
        /// 1:N user_BulkOperation
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_BulkOperation")]
        public System.Collections.Generic.IEnumerable<BulkOperation> user_BulkOperation
        {
            get { return this.GetRelatedEntities<BulkOperation>("user_BulkOperation", null); }
            set
            {
                this.OnPropertyChanging("user_BulkOperation");
                this.SetRelatedEntities<BulkOperation>("user_BulkOperation", null, value);
                this.OnPropertyChanged("user_BulkOperation");
            }
        }

        /// <summary>
        /// 1:N user_campaignactivity
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_campaignactivity")]
        public System.Collections.Generic.IEnumerable<CampaignActivity> user_campaignactivity
        {
            get { return this.GetRelatedEntities<CampaignActivity>("user_campaignactivity", null); }
            set
            {
                this.OnPropertyChanging("user_campaignactivity");
                this.SetRelatedEntities<CampaignActivity>("user_campaignactivity", null, value);
                this.OnPropertyChanged("user_campaignactivity");
            }
        }

        /// <summary>
        /// 1:N user_campaignresponse
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_campaignresponse")]
        public System.Collections.Generic.IEnumerable<CampaignResponse> user_campaignresponse
        {
            get { return this.GetRelatedEntities<CampaignResponse>("user_campaignresponse", null); }
            set
            {
                this.OnPropertyChanging("user_campaignresponse");
                this.SetRelatedEntities<CampaignResponse>("user_campaignresponse", null, value);
                this.OnPropertyChanged("user_campaignresponse");
            }
        }

        /// <summary>
        /// 1:N user_convertrule
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_convertrule")]
        public System.Collections.Generic.IEnumerable<ConvertRule> user_convertrule
        {
            get { return this.GetRelatedEntities<ConvertRule>("user_convertrule", null); }
            set
            {
                this.OnPropertyChanging("user_convertrule");
                this.SetRelatedEntities<ConvertRule>("user_convertrule", null, value);
                this.OnPropertyChanged("user_convertrule");
            }
        }

        /// <summary>
        /// 1:N user_customer_opportunity_roles
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_customer_opportunity_roles")]
        public System.Collections.Generic.IEnumerable<CustomerOpportunityRole> user_customer_opportunity_roles
        {
            get { return this.GetRelatedEntities<CustomerOpportunityRole>("user_customer_opportunity_roles", null); }
            set
            {
                this.OnPropertyChanging("user_customer_opportunity_roles");
                this.SetRelatedEntities<CustomerOpportunityRole>("user_customer_opportunity_roles", null, value);
                this.OnPropertyChanged("user_customer_opportunity_roles");
            }
        }

        /// <summary>
        /// 1:N user_customer_relationship
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_customer_relationship")]
        public System.Collections.Generic.IEnumerable<CustomerRelationship> user_customer_relationship
        {
            get { return this.GetRelatedEntities<CustomerRelationship>("user_customer_relationship", null); }
            set
            {
                this.OnPropertyChanging("user_customer_relationship");
                this.SetRelatedEntities<CustomerRelationship>("user_customer_relationship", null, value);
                this.OnPropertyChanged("user_customer_relationship");
            }
        }

        /// <summary>
        /// 1:N user_email
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_email")]
        public System.Collections.Generic.IEnumerable<Email> user_email
        {
            get { return this.GetRelatedEntities<Email>("user_email", null); }
            set
            {
                this.OnPropertyChanging("user_email");
                this.SetRelatedEntities<Email>("user_email", null, value);
                this.OnPropertyChanged("user_email");
            }
        }

        /// <summary>
        /// 1:N user_entitlement
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_entitlement")]
        public System.Collections.Generic.IEnumerable<Entitlement> user_entitlement
        {
            get { return this.GetRelatedEntities<Entitlement>("user_entitlement", null); }
            set
            {
                this.OnPropertyChanging("user_entitlement");
                this.SetRelatedEntities<Entitlement>("user_entitlement", null, value);
                this.OnPropertyChanged("user_entitlement");
            }
        }

        /// <summary>
        /// 1:N user_exchangesyncidmapping
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_exchangesyncidmapping")]
        public System.Collections.Generic.IEnumerable<ExchangeSyncIdMapping> user_exchangesyncidmapping
        {
            get { return this.GetRelatedEntities<ExchangeSyncIdMapping>("user_exchangesyncidmapping", null); }
            set
            {
                this.OnPropertyChanging("user_exchangesyncidmapping");
                this.SetRelatedEntities<ExchangeSyncIdMapping>("user_exchangesyncidmapping", null, value);
                this.OnPropertyChanged("user_exchangesyncidmapping");
            }
        }

        /// <summary>
        /// 1:N user_fax
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_fax")]
        public System.Collections.Generic.IEnumerable<Fax> user_fax
        {
            get { return this.GetRelatedEntities<Fax>("user_fax", null); }
            set
            {
                this.OnPropertyChanging("user_fax");
                this.SetRelatedEntities<Fax>("user_fax", null, value);
                this.OnPropertyChanged("user_fax");
            }
        }

        /// <summary>
        /// 1:N user_goal
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_goal")]
        public System.Collections.Generic.IEnumerable<Goal> user_goal
        {
            get { return this.GetRelatedEntities<Goal>("user_goal", null); }
            set
            {
                this.OnPropertyChanging("user_goal");
                this.SetRelatedEntities<Goal>("user_goal", null, value);
                this.OnPropertyChanged("user_goal");
            }
        }

        /// <summary>
        /// 1:N user_goal_goalowner
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_goal_goalowner")]
        public System.Collections.Generic.IEnumerable<Goal> user_goal_goalowner
        {
            get { return this.GetRelatedEntities<Goal>("user_goal_goalowner", null); }
            set
            {
                this.OnPropertyChanging("user_goal_goalowner");
                this.SetRelatedEntities<Goal>("user_goal_goalowner", null, value);
                this.OnPropertyChanged("user_goal_goalowner");
            }
        }

        /// <summary>
        /// 1:N user_incidentresolution
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_incidentresolution")]
        public System.Collections.Generic.IEnumerable<IncidentResolution> user_incidentresolution
        {
            get { return this.GetRelatedEntities<IncidentResolution>("user_incidentresolution", null); }
            set
            {
                this.OnPropertyChanging("user_incidentresolution");
                this.SetRelatedEntities<IncidentResolution>("user_incidentresolution", null, value);
                this.OnPropertyChanged("user_incidentresolution");
            }
        }

        /// <summary>
        /// 1:N user_letter
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_letter")]
        public System.Collections.Generic.IEnumerable<Letter> user_letter
        {
            get { return this.GetRelatedEntities<Letter>("user_letter", null); }
            set
            {
                this.OnPropertyChanging("user_letter");
                this.SetRelatedEntities<Letter>("user_letter", null, value);
                this.OnPropertyChanged("user_letter");
            }
        }

        /// <summary>
        /// 1:N user_list
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_list")]
        public System.Collections.Generic.IEnumerable<List> user_list
        {
            get { return this.GetRelatedEntities<List>("user_list", null); }
            set
            {
                this.OnPropertyChanging("user_list");
                this.SetRelatedEntities<List>("user_list", null, value);
                this.OnPropertyChanged("user_list");
            }
        }

        /// <summary>
        /// 1:N user_mailbox
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_mailbox")]
        public System.Collections.Generic.IEnumerable<Mailbox> user_mailbox
        {
            get { return this.GetRelatedEntities<Mailbox>("user_mailbox", null); }
            set
            {
                this.OnPropertyChanging("user_mailbox");
                this.SetRelatedEntities<Mailbox>("user_mailbox", null, value);
                this.OnPropertyChanged("user_mailbox");
            }
        }

        /// <summary>
        /// 1:N user_msdyn_postalbum
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_msdyn_postalbum")]
        public System.Collections.Generic.IEnumerable<msdyn_PostAlbum> user_msdyn_postalbum
        {
            get { return this.GetRelatedEntities<msdyn_PostAlbum>("user_msdyn_postalbum", null); }
            set
            {
                this.OnPropertyChanging("user_msdyn_postalbum");
                this.SetRelatedEntities<msdyn_PostAlbum>("user_msdyn_postalbum", null, value);
                this.OnPropertyChanged("user_msdyn_postalbum");
            }
        }

        /// <summary>
        /// 1:N user_msdyn_wallsavedqueryusersettings
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_msdyn_wallsavedqueryusersettings")]
        public System.Collections.Generic.IEnumerable<msdyn_wallsavedqueryusersettings> user_msdyn_wallsavedqueryusersettings
        {
            get { return this.GetRelatedEntities<msdyn_wallsavedqueryusersettings>("user_msdyn_wallsavedqueryusersettings", null); }
            set
            {
                this.OnPropertyChanging("user_msdyn_wallsavedqueryusersettings");
                this.SetRelatedEntities<msdyn_wallsavedqueryusersettings>("user_msdyn_wallsavedqueryusersettings", null, value);
                this.OnPropertyChanged("user_msdyn_wallsavedqueryusersettings");
            }
        }

        /// <summary>
        /// 1:N user_opportunityclose
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_opportunityclose")]
        public System.Collections.Generic.IEnumerable<OpportunityClose> user_opportunityclose
        {
            get { return this.GetRelatedEntities<OpportunityClose>("user_opportunityclose", null); }
            set
            {
                this.OnPropertyChanging("user_opportunityclose");
                this.SetRelatedEntities<OpportunityClose>("user_opportunityclose", null, value);
                this.OnPropertyChanged("user_opportunityclose");
            }
        }

        /// <summary>
        /// 1:N user_orderclose
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_orderclose")]
        public System.Collections.Generic.IEnumerable<OrderClose> user_orderclose
        {
            get { return this.GetRelatedEntities<OrderClose>("user_orderclose", null); }
            set
            {
                this.OnPropertyChanging("user_orderclose");
                this.SetRelatedEntities<OrderClose>("user_orderclose", null, value);
                this.OnPropertyChanged("user_orderclose");
            }
        }

        /// <summary>
        /// 1:N user_owner_postfollows
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_owner_postfollows")]
        public System.Collections.Generic.IEnumerable<PostFollow> user_owner_postfollows
        {
            get { return this.GetRelatedEntities<PostFollow>("user_owner_postfollows", null); }
            set
            {
                this.OnPropertyChanging("user_owner_postfollows");
                this.SetRelatedEntities<PostFollow>("user_owner_postfollows", null, value);
                this.OnPropertyChanged("user_owner_postfollows");
            }
        }

        /// <summary>
        /// 1:N user_parent_user
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_parent_user", Microsoft.Xrm.Sdk.EntityRole.Referenced)]
        public System.Collections.Generic.IEnumerable<SystemUser> Referenceduser_parent_user
        {
            get { return this.GetRelatedEntities<SystemUser>("user_parent_user", Microsoft.Xrm.Sdk.EntityRole.Referenced); }
            set
            {
                this.OnPropertyChanging("Referenceduser_parent_user");
                this.SetRelatedEntities<SystemUser>("user_parent_user", Microsoft.Xrm.Sdk.EntityRole.Referenced, value);
                this.OnPropertyChanged("Referenceduser_parent_user");
            }
        }

        /// <summary>
        /// 1:N user_phonecall
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_phonecall")]
        public System.Collections.Generic.IEnumerable<PhoneCall> user_phonecall
        {
            get { return this.GetRelatedEntities<PhoneCall>("user_phonecall", null); }
            set
            {
                this.OnPropertyChanging("user_phonecall");
                this.SetRelatedEntities<PhoneCall>("user_phonecall", null, value);
                this.OnPropertyChanged("user_phonecall");
            }
        }

        /// <summary>
        /// 1:N user_quoteclose
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_quoteclose")]
        public System.Collections.Generic.IEnumerable<QuoteClose> user_quoteclose
        {
            get { return this.GetRelatedEntities<QuoteClose>("user_quoteclose", null); }
            set
            {
                this.OnPropertyChanging("user_quoteclose");
                this.SetRelatedEntities<QuoteClose>("user_quoteclose", null, value);
                this.OnPropertyChanged("user_quoteclose");
            }
        }

        /// <summary>
        /// 1:N user_recurringappointmentmaster
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_recurringappointmentmaster")]
        public System.Collections.Generic.IEnumerable<RecurringAppointmentMaster> user_recurringappointmentmaster
        {
            get { return this.GetRelatedEntities<RecurringAppointmentMaster>("user_recurringappointmentmaster", null); }
            set
            {
                this.OnPropertyChanging("user_recurringappointmentmaster");
                this.SetRelatedEntities<RecurringAppointmentMaster>("user_recurringappointmentmaster", null, value);
                this.OnPropertyChanged("user_recurringappointmentmaster");
            }
        }

        /// <summary>
        /// 1:N user_routingrule
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_routingrule")]
        public System.Collections.Generic.IEnumerable<RoutingRule> user_routingrule
        {
            get { return this.GetRelatedEntities<RoutingRule>("user_routingrule", null); }
            set
            {
                this.OnPropertyChanging("user_routingrule");
                this.SetRelatedEntities<RoutingRule>("user_routingrule", null, value);
                this.OnPropertyChanged("user_routingrule");
            }
        }

        /// <summary>
        /// 1:N user_routingruleitem
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_routingruleitem")]
        public System.Collections.Generic.IEnumerable<RoutingRuleItem> user_routingruleitem
        {
            get { return this.GetRelatedEntities<RoutingRuleItem>("user_routingruleitem", null); }
            set
            {
                this.OnPropertyChanging("user_routingruleitem");
                this.SetRelatedEntities<RoutingRuleItem>("user_routingruleitem", null, value);
                this.OnPropertyChanged("user_routingruleitem");
            }
        }

        /// <summary>
        /// 1:N user_settings
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_settings")]
        public System.Collections.Generic.IEnumerable<UserSettings> user_settings
        {
            get { return this.GetRelatedEntities<UserSettings>("user_settings", null); }
            set
            {
                this.OnPropertyChanging("user_settings");
                this.SetRelatedEntities<UserSettings>("user_settings", null, value);
                this.OnPropertyChanged("user_settings");
            }
        }

        /// <summary>
        /// 1:N user_sharepointdocumentlocation
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_sharepointdocumentlocation")]
        public System.Collections.Generic.IEnumerable<SharePointDocumentLocation> user_sharepointdocumentlocation
        {
            get { return this.GetRelatedEntities<SharePointDocumentLocation>("user_sharepointdocumentlocation", null); }
            set
            {
                this.OnPropertyChanging("user_sharepointdocumentlocation");
                this.SetRelatedEntities<SharePointDocumentLocation>("user_sharepointdocumentlocation", null, value);
                this.OnPropertyChanged("user_sharepointdocumentlocation");
            }
        }

        /// <summary>
        /// 1:N user_sharepointsite
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_sharepointsite")]
        public System.Collections.Generic.IEnumerable<SharePointSite> user_sharepointsite
        {
            get { return this.GetRelatedEntities<SharePointSite>("user_sharepointsite", null); }
            set
            {
                this.OnPropertyChanging("user_sharepointsite");
                this.SetRelatedEntities<SharePointSite>("user_sharepointsite", null, value);
                this.OnPropertyChanged("user_sharepointsite");
            }
        }

        /// <summary>
        /// 1:N user_slabase
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_slabase")]
        public System.Collections.Generic.IEnumerable<SLA> user_slabase
        {
            get { return this.GetRelatedEntities<SLA>("user_slabase", null); }
            set
            {
                this.OnPropertyChanging("user_slabase");
                this.SetRelatedEntities<SLA>("user_slabase", null, value);
                this.OnPropertyChanged("user_slabase");
            }
        }

        /// <summary>
        /// 1:N user_socialactivity
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_socialactivity")]
        public System.Collections.Generic.IEnumerable<SocialActivity> user_socialactivity
        {
            get { return this.GetRelatedEntities<SocialActivity>("user_socialactivity", null); }
            set
            {
                this.OnPropertyChanging("user_socialactivity");
                this.SetRelatedEntities<SocialActivity>("user_socialactivity", null, value);
                this.OnPropertyChanged("user_socialactivity");
            }
        }

        /// <summary>
        /// 1:N user_task
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_task")]
        public System.Collections.Generic.IEnumerable<Task> user_task
        {
            get { return this.GetRelatedEntities<Task>("user_task", null); }
            set
            {
                this.OnPropertyChanging("user_task");
                this.SetRelatedEntities<Task>("user_task", null, value);
                this.OnPropertyChanged("user_task");
            }
        }

        /// <summary>
        /// 1:N user_userform
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_userform")]
        public System.Collections.Generic.IEnumerable<UserForm> user_userform
        {
            get { return this.GetRelatedEntities<UserForm>("user_userform", null); }
            set
            {
                this.OnPropertyChanging("user_userform");
                this.SetRelatedEntities<UserForm>("user_userform", null, value);
                this.OnPropertyChanged("user_userform");
            }
        }

        /// <summary>
        /// 1:N user_userquery
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_userquery")]
        public System.Collections.Generic.IEnumerable<UserQuery> user_userquery
        {
            get { return this.GetRelatedEntities<UserQuery>("user_userquery", null); }
            set
            {
                this.OnPropertyChanging("user_userquery");
                this.SetRelatedEntities<UserQuery>("user_userquery", null, value);
                this.OnPropertyChanged("user_userquery");
            }
        }

        /// <summary>
        /// 1:N user_userqueryvisualizations
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_userqueryvisualizations")]
        public System.Collections.Generic.IEnumerable<UserQueryVisualization> user_userqueryvisualizations
        {
            get { return this.GetRelatedEntities<UserQueryVisualization>("user_userqueryvisualizations", null); }
            set
            {
                this.OnPropertyChanging("user_userqueryvisualizations");
                this.SetRelatedEntities<UserQueryVisualization>("user_userqueryvisualizations", null, value);
                this.OnPropertyChanged("user_userqueryvisualizations");
            }
        }

        /// <summary>
        /// 1:N userentityinstancedata_owning_user
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_owning_user")]
        public System.Collections.Generic.IEnumerable<UserEntityInstanceData> userentityinstancedata_owning_user
        {
            get { return this.GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_owning_user", null); }
            set
            {
                this.OnPropertyChanging("userentityinstancedata_owning_user");
                this.SetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_owning_user", null, value);
                this.OnPropertyChanged("userentityinstancedata_owning_user");
            }
        }

        /// <summary>
        /// 1:N userentityinstancedata_systemuser
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_systemuser")]
        public System.Collections.Generic.IEnumerable<UserEntityInstanceData> userentityinstancedata_systemuser
        {
            get { return this.GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_systemuser", null); }
            set
            {
                this.OnPropertyChanging("userentityinstancedata_systemuser");
                this.SetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_systemuser", null, value);
                this.OnPropertyChanged("userentityinstancedata_systemuser");
            }
        }

        /// <summary>
        /// 1:N userentityuisettings_owning_user
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityuisettings_owning_user")]
        public System.Collections.Generic.IEnumerable<UserEntityUISettings> userentityuisettings_owning_user
        {
            get { return this.GetRelatedEntities<UserEntityUISettings>("userentityuisettings_owning_user", null); }
            set
            {
                this.OnPropertyChanging("userentityuisettings_owning_user");
                this.SetRelatedEntities<UserEntityUISettings>("userentityuisettings_owning_user", null, value);
                this.OnPropertyChanged("userentityuisettings_owning_user");
            }
        }

        /// <summary>
        /// 1:N webresource_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("webresource_createdby")]
        public System.Collections.Generic.IEnumerable<WebResource> webresource_createdby
        {
            get { return this.GetRelatedEntities<WebResource>("webresource_createdby", null); }
            set
            {
                this.OnPropertyChanging("webresource_createdby");
                this.SetRelatedEntities<WebResource>("webresource_createdby", null, value);
                this.OnPropertyChanged("webresource_createdby");
            }
        }

        /// <summary>
        /// 1:N webresource_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("webresource_modifiedby")]
        public System.Collections.Generic.IEnumerable<WebResource> webresource_modifiedby
        {
            get { return this.GetRelatedEntities<WebResource>("webresource_modifiedby", null); }
            set
            {
                this.OnPropertyChanging("webresource_modifiedby");
                this.SetRelatedEntities<WebResource>("webresource_modifiedby", null, value);
                this.OnPropertyChanged("webresource_modifiedby");
            }
        }

        /// <summary>
        /// 1:N workflow_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("workflow_createdby")]
        public System.Collections.Generic.IEnumerable<Workflow> workflow_createdby
        {
            get { return this.GetRelatedEntities<Workflow>("workflow_createdby", null); }
            set
            {
                this.OnPropertyChanging("workflow_createdby");
                this.SetRelatedEntities<Workflow>("workflow_createdby", null, value);
                this.OnPropertyChanged("workflow_createdby");
            }
        }

        /// <summary>
        /// 1:N workflow_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("workflow_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<Workflow> workflow_createdonbehalfby
        {
            get { return this.GetRelatedEntities<Workflow>("workflow_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("workflow_createdonbehalfby");
                this.SetRelatedEntities<Workflow>("workflow_createdonbehalfby", null, value);
                this.OnPropertyChanged("workflow_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N workflow_dependency_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("workflow_dependency_createdby")]
        public System.Collections.Generic.IEnumerable<WorkflowDependency> workflow_dependency_createdby
        {
            get { return this.GetRelatedEntities<WorkflowDependency>("workflow_dependency_createdby", null); }
            set
            {
                this.OnPropertyChanging("workflow_dependency_createdby");
                this.SetRelatedEntities<WorkflowDependency>("workflow_dependency_createdby", null, value);
                this.OnPropertyChanged("workflow_dependency_createdby");
            }
        }

        /// <summary>
        /// 1:N workflow_dependency_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("workflow_dependency_createdonbehalfby")]
        public System.Collections.Generic.IEnumerable<WorkflowDependency> workflow_dependency_createdonbehalfby
        {
            get { return this.GetRelatedEntities<WorkflowDependency>("workflow_dependency_createdonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("workflow_dependency_createdonbehalfby");
                this.SetRelatedEntities<WorkflowDependency>("workflow_dependency_createdonbehalfby", null, value);
                this.OnPropertyChanged("workflow_dependency_createdonbehalfby");
            }
        }

        /// <summary>
        /// 1:N workflow_dependency_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("workflow_dependency_modifiedby")]
        public System.Collections.Generic.IEnumerable<WorkflowDependency> workflow_dependency_modifiedby
        {
            get { return this.GetRelatedEntities<WorkflowDependency>("workflow_dependency_modifiedby", null); }
            set
            {
                this.OnPropertyChanging("workflow_dependency_modifiedby");
                this.SetRelatedEntities<WorkflowDependency>("workflow_dependency_modifiedby", null, value);
                this.OnPropertyChanged("workflow_dependency_modifiedby");
            }
        }

        /// <summary>
        /// 1:N workflow_dependency_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("workflow_dependency_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<WorkflowDependency> workflow_dependency_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<WorkflowDependency>("workflow_dependency_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("workflow_dependency_modifiedonbehalfby");
                this.SetRelatedEntities<WorkflowDependency>("workflow_dependency_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("workflow_dependency_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// 1:N workflow_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("workflow_modifiedby")]
        public System.Collections.Generic.IEnumerable<Workflow> workflow_modifiedby
        {
            get { return this.GetRelatedEntities<Workflow>("workflow_modifiedby", null); }
            set
            {
                this.OnPropertyChanging("workflow_modifiedby");
                this.SetRelatedEntities<Workflow>("workflow_modifiedby", null, value);
                this.OnPropertyChanged("workflow_modifiedby");
            }
        }

        /// <summary>
        /// 1:N workflow_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("workflow_modifiedonbehalfby")]
        public System.Collections.Generic.IEnumerable<Workflow> workflow_modifiedonbehalfby
        {
            get { return this.GetRelatedEntities<Workflow>("workflow_modifiedonbehalfby", null); }
            set
            {
                this.OnPropertyChanging("workflow_modifiedonbehalfby");
                this.SetRelatedEntities<Workflow>("workflow_modifiedonbehalfby", null, value);
                this.OnPropertyChanged("workflow_modifiedonbehalfby");
            }
        }

        /// <summary>
        /// N:N queuemembership_association
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("queuemembership_association")]
        public System.Collections.Generic.IEnumerable<Queue> queuemembership_association
        {
            get { return this.GetRelatedEntities<Queue>("queuemembership_association", null); }
            set
            {
                this.OnPropertyChanging("queuemembership_association");
                this.SetRelatedEntities<Queue>("queuemembership_association", null, value);
                this.OnPropertyChanged("queuemembership_association");
            }
        }

        /// <summary>
        /// N:N systemuserprofiles_association
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("systemuserprofiles_association")]
        public System.Collections.Generic.IEnumerable<FieldSecurityProfile> systemuserprofiles_association
        {
            get { return this.GetRelatedEntities<FieldSecurityProfile>("systemuserprofiles_association", null); }
            set
            {
                this.OnPropertyChanging("systemuserprofiles_association");
                this.SetRelatedEntities<FieldSecurityProfile>("systemuserprofiles_association", null, value);
                this.OnPropertyChanged("systemuserprofiles_association");
            }
        }

        /// <summary>
        /// N:N systemuserroles_association
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("systemuserroles_association")]
        public System.Collections.Generic.IEnumerable<Role> systemuserroles_association
        {
            get { return this.GetRelatedEntities<Role>("systemuserroles_association", null); }
            set
            {
                this.OnPropertyChanging("systemuserroles_association");
                this.SetRelatedEntities<Role>("systemuserroles_association", null, value);
                this.OnPropertyChanged("systemuserroles_association");
            }
        }

        /// <summary>
        /// N:N teammembership_association
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("teammembership_association")]
        public System.Collections.Generic.IEnumerable<Team> teammembership_association
        {
            get { return this.GetRelatedEntities<Team>("teammembership_association", null); }
            set
            {
                this.OnPropertyChanging("teammembership_association");
                this.SetRelatedEntities<Team>("teammembership_association", null, value);
                this.OnPropertyChanged("teammembership_association");
            }
        }

        /// <summary>
        /// N:1 business_unit_system_users
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("businessunitid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_system_users")]
        public BusinessUnit business_unit_system_users
        {
            get { return this.GetRelatedEntity<BusinessUnit>("business_unit_system_users", null); }
            set
            {
                this.OnPropertyChanging("business_unit_system_users");
                this.SetRelatedEntity<BusinessUnit>("business_unit_system_users", null, value);
                this.OnPropertyChanged("business_unit_system_users");
            }
        }

        /// <summary>
        /// N:1 calendar_system_users
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("calendarid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("calendar_system_users")]
        public Calendar calendar_system_users
        {
            get { return this.GetRelatedEntity<Calendar>("calendar_system_users", null); }
            set
            {
                this.OnPropertyChanging("calendar_system_users");
                this.SetRelatedEntity<Calendar>("calendar_system_users", null, value);
                this.OnPropertyChanged("calendar_system_users");
            }
        }

        /// <summary>
        /// N:1 lk_systemuser_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_systemuser_createdonbehalfby", Microsoft.Xrm.Sdk.EntityRole.Referencing)]
        public SystemUser Referencinglk_systemuser_createdonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_systemuser_createdonbehalfby", Microsoft.Xrm.Sdk.EntityRole.Referencing); }
        }

        /// <summary>
        /// N:1 lk_systemuser_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_systemuser_modifiedonbehalfby", Microsoft.Xrm.Sdk.EntityRole.Referencing)]
        public SystemUser Referencinglk_systemuser_modifiedonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_systemuser_modifiedonbehalfby", Microsoft.Xrm.Sdk.EntityRole.Referencing); }
        }

        /// <summary>
        /// N:1 lk_systemuserbase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_systemuserbase_createdby", Microsoft.Xrm.Sdk.EntityRole.Referencing)]
        public SystemUser Referencinglk_systemuserbase_createdby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_systemuserbase_createdby", Microsoft.Xrm.Sdk.EntityRole.Referencing); }
        }

        /// <summary>
        /// N:1 lk_systemuserbase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_systemuserbase_modifiedby", Microsoft.Xrm.Sdk.EntityRole.Referencing)]
        public SystemUser Referencinglk_systemuserbase_modifiedby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_systemuserbase_modifiedby", Microsoft.Xrm.Sdk.EntityRole.Referencing); }
        }

        /// <summary>
        /// N:1 organization_system_users
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_system_users")]
        public Organization organization_system_users
        {
            get { return this.GetRelatedEntity<Organization>("organization_system_users", null); }
        }

        /// <summary>
        /// N:1 position_users
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("positionid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("position_users")]
        public Position position_users
        {
            get { return this.GetRelatedEntity<Position>("position_users", null); }
            set
            {
                this.OnPropertyChanging("position_users");
                this.SetRelatedEntity<Position>("position_users", null, value);
                this.OnPropertyChanged("position_users");
            }
        }

        /// <summary>
        /// N:1 processstage_systemusers
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("stageid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("processstage_systemusers")]
        public ProcessStage processstage_systemusers
        {
            get { return this.GetRelatedEntity<ProcessStage>("processstage_systemusers", null); }
            set
            {
                this.OnPropertyChanging("processstage_systemusers");
                this.SetRelatedEntity<ProcessStage>("processstage_systemusers", null, value);
                this.OnPropertyChanged("processstage_systemusers");
            }
        }

        /// <summary>
        /// N:1 queue_system_user
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("queueid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("queue_system_user")]
        public Queue queue_system_user
        {
            get { return this.GetRelatedEntity<Queue>("queue_system_user", null); }
            set
            {
                this.OnPropertyChanging("queue_system_user");
                this.SetRelatedEntity<Queue>("queue_system_user", null, value);
                this.OnPropertyChanged("queue_system_user");
            }
        }

        /// <summary>
        /// N:1 site_system_users
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("siteid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("site_system_users")]
        public Site site_system_users
        {
            get { return this.GetRelatedEntity<Site>("site_system_users", null); }
            set
            {
                this.OnPropertyChanging("site_system_users");
                this.SetRelatedEntity<Site>("site_system_users", null, value);
                this.OnPropertyChanged("site_system_users");
            }
        }

        /// <summary>
        /// N:1 systemuser_defaultmailbox_mailbox
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("defaultmailbox")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("systemuser_defaultmailbox_mailbox")]
        public Mailbox systemuser_defaultmailbox_mailbox
        {
            get { return this.GetRelatedEntity<Mailbox>("systemuser_defaultmailbox_mailbox", null); }
        }

        /// <summary>
        /// N:1 territory_system_users
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("territoryid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("territory_system_users")]
        public Territory territory_system_users
        {
            get { return this.GetRelatedEntity<Territory>("territory_system_users", null); }
            set
            {
                this.OnPropertyChanging("territory_system_users");
                this.SetRelatedEntity<Territory>("territory_system_users", null, value);
                this.OnPropertyChanged("territory_system_users");
            }
        }

        /// <summary>
        /// N:1 TransactionCurrency_SystemUser
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("TransactionCurrency_SystemUser")]
        public TransactionCurrency TransactionCurrency_SystemUser
        {
            get { return this.GetRelatedEntity<TransactionCurrency>("TransactionCurrency_SystemUser", null); }
            set
            {
                this.OnPropertyChanging("TransactionCurrency_SystemUser");
                this.SetRelatedEntity<TransactionCurrency>("TransactionCurrency_SystemUser", null, value);
                this.OnPropertyChanged("TransactionCurrency_SystemUser");
            }
        }

        /// <summary>
        /// N:1 user_parent_user
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("parentsystemuserid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_parent_user", Microsoft.Xrm.Sdk.EntityRole.Referencing)]
        public SystemUser Referencinguser_parent_user
        {
            get { return this.GetRelatedEntity<SystemUser>("user_parent_user", Microsoft.Xrm.Sdk.EntityRole.Referencing); }
            set
            {
                this.OnPropertyChanging("Referencinguser_parent_user");
                this.SetRelatedEntity<SystemUser>("user_parent_user", Microsoft.Xrm.Sdk.EntityRole.Referencing, value);
                this.OnPropertyChanged("Referencinguser_parent_user");
            }
        }
    }

}
