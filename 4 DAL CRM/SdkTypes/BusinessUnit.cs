using _4_DAL_CRM;

namespace __4_DAL_CRM
{
    /// <summary>
    /// Business, division, or department in the Microsoft Dynamics CRM database.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("businessunit")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class BusinessUnit : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public BusinessUnit() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "businessunit";

        public const int EntityTypeCode = 10;

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
        /// Unique identifier of the business unit.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("businessunitid")]
        public System.Nullable<System.Guid> BusinessUnitId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("businessunitid"); }
            set
            {
                this.OnPropertyChanging("BusinessUnitId");
                this.SetAttributeValue("businessunitid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("BusinessUnitId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("businessunitid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.BusinessUnitId = value; }
        }

        /// <summary>
        /// Fiscal calendar associated with the business unit.
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
        /// Name of the business unit cost center.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("costcenter")]
        public string CostCenter
        {
            get { return this.GetAttributeValue<string>("costcenter"); }
            set
            {
                this.OnPropertyChanging("CostCenter");
                this.SetAttributeValue("costcenter", value);
                this.OnPropertyChanged("CostCenter");
            }
        }

        /// <summary>
        /// Unique identifier of the user who created the business unit.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby"); }
        }

        /// <summary>
        /// Date and time when the business unit was created.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
        public System.Nullable<System.DateTime> CreatedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who created the businessunit.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        /// Credit limit for the business unit.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("creditlimit")]
        public System.Nullable<double> CreditLimit
        {
            get { return this.GetAttributeValue<System.Nullable<double>>("creditlimit"); }
            set
            {
                this.OnPropertyChanging("CreditLimit");
                this.SetAttributeValue("creditlimit", value);
                this.OnPropertyChanged("CreditLimit");
            }
        }

        /// <summary>
        /// Description of the business unit.
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
        /// Reason for disabling the business unit.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("disabledreason")]
        public string DisabledReason
        {
            get { return this.GetAttributeValue<string>("disabledreason"); }
        }

        /// <summary>
        /// Name of the division to which the business unit belongs.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("divisionname")]
        public string DivisionName
        {
            get { return this.GetAttributeValue<string>("divisionname"); }
            set
            {
                this.OnPropertyChanging("DivisionName");
                this.SetAttributeValue("divisionname", value);
                this.OnPropertyChanged("DivisionName");
            }
        }

        /// <summary>
        /// Email address for the business unit.
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
        /// Exchange rate for the currency associated with the businessunit with respect to the base currency.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("exchangerate")]
        public System.Nullable<decimal> ExchangeRate
        {
            get { return this.GetAttributeValue<System.Nullable<decimal>>("exchangerate"); }
        }

        /// <summary>
        /// Alternative name under which the business unit can be filed.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("fileasname")]
        public string FileAsName
        {
            get { return this.GetAttributeValue<string>("fileasname"); }
            set
            {
                this.OnPropertyChanging("FileAsName");
                this.SetAttributeValue("fileasname", value);
                this.OnPropertyChanged("FileAsName");
            }
        }

        /// <summary>
        /// FTP site URL for the business unit.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ftpsiteurl")]
        public string FtpSiteUrl
        {
            get { return this.GetAttributeValue<string>("ftpsiteurl"); }
            set
            {
                this.OnPropertyChanging("FtpSiteUrl");
                this.SetAttributeValue("ftpsiteurl", value);
                this.OnPropertyChanged("FtpSiteUrl");
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
        /// Inheritance mask for the business unit.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("inheritancemask")]
        public System.Nullable<int> InheritanceMask
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("inheritancemask"); }
            set
            {
                this.OnPropertyChanging("InheritanceMask");
                this.SetAttributeValue("inheritancemask", value);
                this.OnPropertyChanged("InheritanceMask");
            }
        }

        /// <summary>
        /// Information about whether the business unit is enabled or disabled.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isdisabled")]
        public System.Nullable<bool> IsDisabled
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("isdisabled"); }
        }

        /// <summary>
        /// Unique identifier of the user who last modified the business unit.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby"); }
        }

        /// <summary>
        /// Date and time when the business unit was last modified.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
        public System.Nullable<System.DateTime> ModifiedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who last modified the businessunit.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        /// Name of the business unit.
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
        /// Unique identifier of the organization associated with the business unit.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
        public Microsoft.Xrm.Sdk.EntityReference OrganizationId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("organizationid"); }
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
        /// Unique identifier for the parent business unit.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("parentbusinessunitid")]
        public Microsoft.Xrm.Sdk.EntityReference ParentBusinessUnitId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("parentbusinessunitid"); }
            set
            {
                this.OnPropertyChanging("ParentBusinessUnitId");
                this.SetAttributeValue("parentbusinessunitid", value);
                this.OnPropertyChanged("ParentBusinessUnitId");
            }
        }

        /// <summary>
        /// Picture or diagram of the business unit.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("picture")]
        public string Picture
        {
            get { return this.GetAttributeValue<string>("picture"); }
            set
            {
                this.OnPropertyChanging("Picture");
                this.SetAttributeValue("picture", value);
                this.OnPropertyChanged("Picture");
            }
        }

        /// <summary>
        /// Stock exchange on which the business is listed.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("stockexchange")]
        public string StockExchange
        {
            get { return this.GetAttributeValue<string>("stockexchange"); }
            set
            {
                this.OnPropertyChanging("StockExchange");
                this.SetAttributeValue("stockexchange", value);
                this.OnPropertyChanged("StockExchange");
            }
        }

        /// <summary>
        /// Stock exchange ticker symbol for the business unit.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("tickersymbol")]
        public string TickerSymbol
        {
            get { return this.GetAttributeValue<string>("tickersymbol"); }
            set
            {
                this.OnPropertyChanging("TickerSymbol");
                this.SetAttributeValue("tickersymbol", value);
                this.OnPropertyChanged("TickerSymbol");
            }
        }

        /// <summary>
        /// Unique identifier of the currency associated with the businessunit.
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
        /// UTC offset for the business unit. This is the difference between local time and standard Coordinated Universal Time.
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
        /// Version number of the business unit.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
        public System.Nullable<long> VersionNumber
        {
            get { return this.GetAttributeValue<System.Nullable<long>>("versionnumber"); }
        }

        /// <summary>
        /// Website URL for the business unit.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("websiteurl")]
        public string WebSiteUrl
        {
            get { return this.GetAttributeValue<string>("websiteurl"); }
            set
            {
                this.OnPropertyChanging("WebSiteUrl");
                this.SetAttributeValue("websiteurl", value);
                this.OnPropertyChanged("WebSiteUrl");
            }
        }

        /// <summary>
        /// Information about whether workflow or sales process rules have been suspended.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("workflowsuspended")]
        public System.Nullable<bool> WorkflowSuspended
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("workflowsuspended"); }
            set
            {
                this.OnPropertyChanging("WorkflowSuspended");
                this.SetAttributeValue("workflowsuspended", value);
                this.OnPropertyChanged("WorkflowSuspended");
            }
        }

        /// <summary>
        /// 1:N BulkDeleteOperation_BusinessUnit
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("BulkDeleteOperation_BusinessUnit")]
        public System.Collections.Generic.IEnumerable<BulkDeleteOperation> BulkDeleteOperation_BusinessUnit
        {
            get { return this.GetRelatedEntities<BulkDeleteOperation>("BulkDeleteOperation_BusinessUnit", null); }
            set
            {
                this.OnPropertyChanging("BulkDeleteOperation_BusinessUnit");
                this.SetRelatedEntities<BulkDeleteOperation>("BulkDeleteOperation_BusinessUnit", null, value);
                this.OnPropertyChanged("BulkDeleteOperation_BusinessUnit");
            }
        }

        /// <summary>
        /// 1:N business_customer_opportunity_roles
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_customer_opportunity_roles")]
        public System.Collections.Generic.IEnumerable<CustomerOpportunityRole> business_customer_opportunity_roles
        {
            get { return this.GetRelatedEntities<CustomerOpportunityRole>("business_customer_opportunity_roles", null); }
            set
            {
                this.OnPropertyChanging("business_customer_opportunity_roles");
                this.SetRelatedEntities<CustomerOpportunityRole>("business_customer_opportunity_roles", null, value);
                this.OnPropertyChanged("business_customer_opportunity_roles");
            }
        }

        /// <summary>
        /// 1:N business_unit_accounts
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_accounts")]
        public System.Collections.Generic.IEnumerable<Account> business_unit_accounts
        {
            get { return this.GetRelatedEntities<Account>("business_unit_accounts", null); }
            set
            {
                this.OnPropertyChanging("business_unit_accounts");
                this.SetRelatedEntities<Account>("business_unit_accounts", null, value);
                this.OnPropertyChanged("business_unit_accounts");
            }
        }

        /// <summary>
        /// 1:N business_unit_activitypointer
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_activitypointer")]
        public System.Collections.Generic.IEnumerable<ActivityPointer> business_unit_activitypointer
        {
            get { return this.GetRelatedEntities<ActivityPointer>("business_unit_activitypointer", null); }
            set
            {
                this.OnPropertyChanging("business_unit_activitypointer");
                this.SetRelatedEntities<ActivityPointer>("business_unit_activitypointer", null, value);
                this.OnPropertyChanged("business_unit_activitypointer");
            }
        }

        /// <summary>
        /// 1:N business_unit_annotations
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_annotations")]
        public System.Collections.Generic.IEnumerable<Annotation> business_unit_annotations
        {
            get { return this.GetRelatedEntities<Annotation>("business_unit_annotations", null); }
            set
            {
                this.OnPropertyChanging("business_unit_annotations");
                this.SetRelatedEntities<Annotation>("business_unit_annotations", null, value);
                this.OnPropertyChanged("business_unit_annotations");
            }
        }

        /// <summary>
        /// 1:N business_unit_appointment_activities
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_appointment_activities")]
        public System.Collections.Generic.IEnumerable<Appointment> business_unit_appointment_activities
        {
            get { return this.GetRelatedEntities<Appointment>("business_unit_appointment_activities", null); }
            set
            {
                this.OnPropertyChanging("business_unit_appointment_activities");
                this.SetRelatedEntities<Appointment>("business_unit_appointment_activities", null, value);
                this.OnPropertyChanged("business_unit_appointment_activities");
            }
        }

        /// <summary>
        /// 1:N business_unit_asyncoperation
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_asyncoperation")]
        public System.Collections.Generic.IEnumerable<AsyncOperation> business_unit_asyncoperation
        {
            get { return this.GetRelatedEntities<AsyncOperation>("business_unit_asyncoperation", null); }
            set
            {
                this.OnPropertyChanging("business_unit_asyncoperation");
                this.SetRelatedEntities<AsyncOperation>("business_unit_asyncoperation", null, value);
                this.OnPropertyChanged("business_unit_asyncoperation");
            }
        }

        /// <summary>
        /// 1:N business_unit_BulkOperation_activities
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_BulkOperation_activities")]
        public System.Collections.Generic.IEnumerable<BulkOperation> business_unit_BulkOperation_activities
        {
            get { return this.GetRelatedEntities<BulkOperation>("business_unit_BulkOperation_activities", null); }
            set
            {
                this.OnPropertyChanging("business_unit_BulkOperation_activities");
                this.SetRelatedEntities<BulkOperation>("business_unit_BulkOperation_activities", null, value);
                this.OnPropertyChanged("business_unit_BulkOperation_activities");
            }
        }

        /// <summary>
        /// 1:N business_unit_calendars
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_calendars")]
        public System.Collections.Generic.IEnumerable<Calendar> business_unit_calendars
        {
            get { return this.GetRelatedEntities<Calendar>("business_unit_calendars", null); }
            set
            {
                this.OnPropertyChanging("business_unit_calendars");
                this.SetRelatedEntities<Calendar>("business_unit_calendars", null, value);
                this.OnPropertyChanged("business_unit_calendars");
            }
        }

        /// <summary>
        /// 1:N business_unit_campaignactivity_activities
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_campaignactivity_activities")]
        public System.Collections.Generic.IEnumerable<CampaignActivity> business_unit_campaignactivity_activities
        {
            get { return this.GetRelatedEntities<CampaignActivity>("business_unit_campaignactivity_activities", null); }
            set
            {
                this.OnPropertyChanging("business_unit_campaignactivity_activities");
                this.SetRelatedEntities<CampaignActivity>("business_unit_campaignactivity_activities", null, value);
                this.OnPropertyChanged("business_unit_campaignactivity_activities");
            }
        }

        /// <summary>
        /// 1:N business_unit_campaignresponse_activities
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_campaignresponse_activities")]
        public System.Collections.Generic.IEnumerable<CampaignResponse> business_unit_campaignresponse_activities
        {
            get { return this.GetRelatedEntities<CampaignResponse>("business_unit_campaignresponse_activities", null); }
            set
            {
                this.OnPropertyChanging("business_unit_campaignresponse_activities");
                this.SetRelatedEntities<CampaignResponse>("business_unit_campaignresponse_activities", null, value);
                this.OnPropertyChanged("business_unit_campaignresponse_activities");
            }
        }

        /// <summary>
        /// 1:N business_unit_connections
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_connections")]
        public System.Collections.Generic.IEnumerable<Connection> business_unit_connections
        {
            get { return this.GetRelatedEntities<Connection>("business_unit_connections", null); }
            set
            {
                this.OnPropertyChanging("business_unit_connections");
                this.SetRelatedEntities<Connection>("business_unit_connections", null, value);
                this.OnPropertyChanged("business_unit_connections");
            }
        }

        /// <summary>
        /// 1:N business_unit_constraint_based_groups
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_constraint_based_groups")]
        public System.Collections.Generic.IEnumerable<ConstraintBasedGroup> business_unit_constraint_based_groups
        {
            get { return this.GetRelatedEntities<ConstraintBasedGroup>("business_unit_constraint_based_groups", null); }
            set
            {
                this.OnPropertyChanging("business_unit_constraint_based_groups");
                this.SetRelatedEntities<ConstraintBasedGroup>("business_unit_constraint_based_groups", null, value);
                this.OnPropertyChanged("business_unit_constraint_based_groups");
            }
        }

        /// <summary>
        /// 1:N business_unit_contacts
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_contacts")]
        public System.Collections.Generic.IEnumerable<Contact> business_unit_contacts
        {
            get { return this.GetRelatedEntities<Contact>("business_unit_contacts", null); }
            set
            {
                this.OnPropertyChanging("business_unit_contacts");
                this.SetRelatedEntities<Contact>("business_unit_contacts", null, value);
                this.OnPropertyChanged("business_unit_contacts");
            }
        }

        /// <summary>
        /// 1:N business_unit_convertrule
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_convertrule")]
        public System.Collections.Generic.IEnumerable<ConvertRule> business_unit_convertrule
        {
            get { return this.GetRelatedEntities<ConvertRule>("business_unit_convertrule", null); }
            set
            {
                this.OnPropertyChanging("business_unit_convertrule");
                this.SetRelatedEntities<ConvertRule>("business_unit_convertrule", null, value);
                this.OnPropertyChanged("business_unit_convertrule");
            }
        }

        /// <summary>
        /// 1:N business_unit_customer_relationship
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_customer_relationship")]
        public System.Collections.Generic.IEnumerable<CustomerRelationship> business_unit_customer_relationship
        {
            get { return this.GetRelatedEntities<CustomerRelationship>("business_unit_customer_relationship", null); }
            set
            {
                this.OnPropertyChanging("business_unit_customer_relationship");
                this.SetRelatedEntities<CustomerRelationship>("business_unit_customer_relationship", null, value);
                this.OnPropertyChanged("business_unit_customer_relationship");
            }
        }

        /// <summary>
        /// 1:N business_unit_dynamicproperyinstance
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_dynamicproperyinstance")]
        public System.Collections.Generic.IEnumerable<DynamicPropertyInstance> business_unit_dynamicproperyinstance
        {
            get { return this.GetRelatedEntities<DynamicPropertyInstance>("business_unit_dynamicproperyinstance", null); }
            set
            {
                this.OnPropertyChanging("business_unit_dynamicproperyinstance");
                this.SetRelatedEntities<DynamicPropertyInstance>("business_unit_dynamicproperyinstance", null, value);
                this.OnPropertyChanged("business_unit_dynamicproperyinstance");
            }
        }

        /// <summary>
        /// 1:N business_unit_email_activities
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_email_activities")]
        public System.Collections.Generic.IEnumerable<Email> business_unit_email_activities
        {
            get { return this.GetRelatedEntities<Email>("business_unit_email_activities", null); }
            set
            {
                this.OnPropertyChanging("business_unit_email_activities");
                this.SetRelatedEntities<Email>("business_unit_email_activities", null, value);
                this.OnPropertyChanged("business_unit_email_activities");
            }
        }

        /// <summary>
        /// 1:N business_unit_emailserverprofile
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_emailserverprofile")]
        public System.Collections.Generic.IEnumerable<EmailServerProfile> business_unit_emailserverprofile
        {
            get { return this.GetRelatedEntities<EmailServerProfile>("business_unit_emailserverprofile", null); }
            set
            {
                this.OnPropertyChanging("business_unit_emailserverprofile");
                this.SetRelatedEntities<EmailServerProfile>("business_unit_emailserverprofile", null, value);
                this.OnPropertyChanged("business_unit_emailserverprofile");
            }
        }

        /// <summary>
        /// 1:N business_unit_entitlement
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_entitlement")]
        public System.Collections.Generic.IEnumerable<Entitlement> business_unit_entitlement
        {
            get { return this.GetRelatedEntities<Entitlement>("business_unit_entitlement", null); }
            set
            {
                this.OnPropertyChanging("business_unit_entitlement");
                this.SetRelatedEntities<Entitlement>("business_unit_entitlement", null, value);
                this.OnPropertyChanged("business_unit_entitlement");
            }
        }

        /// <summary>
        /// 1:N business_unit_equipment
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_equipment")]
        public System.Collections.Generic.IEnumerable<Equipment> business_unit_equipment
        {
            get { return this.GetRelatedEntities<Equipment>("business_unit_equipment", null); }
            set
            {
                this.OnPropertyChanging("business_unit_equipment");
                this.SetRelatedEntities<Equipment>("business_unit_equipment", null, value);
                this.OnPropertyChanged("business_unit_equipment");
            }
        }

        /// <summary>
        /// 1:N business_unit_exchangesyncidmapping
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_exchangesyncidmapping")]
        public System.Collections.Generic.IEnumerable<ExchangeSyncIdMapping> business_unit_exchangesyncidmapping
        {
            get { return this.GetRelatedEntities<ExchangeSyncIdMapping>("business_unit_exchangesyncidmapping", null); }
            set
            {
                this.OnPropertyChanging("business_unit_exchangesyncidmapping");
                this.SetRelatedEntities<ExchangeSyncIdMapping>("business_unit_exchangesyncidmapping", null, value);
                this.OnPropertyChanged("business_unit_exchangesyncidmapping");
            }
        }

        /// <summary>
        /// 1:N business_unit_fax_activities
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_fax_activities")]
        public System.Collections.Generic.IEnumerable<Fax> business_unit_fax_activities
        {
            get { return this.GetRelatedEntities<Fax>("business_unit_fax_activities", null); }
            set
            {
                this.OnPropertyChanging("business_unit_fax_activities");
                this.SetRelatedEntities<Fax>("business_unit_fax_activities", null, value);
                this.OnPropertyChanged("business_unit_fax_activities");
            }
        }

        /// <summary>
        /// 1:N business_unit_goal
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_goal")]
        public System.Collections.Generic.IEnumerable<Goal> business_unit_goal
        {
            get { return this.GetRelatedEntities<Goal>("business_unit_goal", null); }
            set
            {
                this.OnPropertyChanging("business_unit_goal");
                this.SetRelatedEntities<Goal>("business_unit_goal", null, value);
                this.OnPropertyChanged("business_unit_goal");
            }
        }

        /// <summary>
        /// 1:N business_unit_goalrollupquery
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_goalrollupquery")]
        public System.Collections.Generic.IEnumerable<GoalRollupQuery> business_unit_goalrollupquery
        {
            get { return this.GetRelatedEntities<GoalRollupQuery>("business_unit_goalrollupquery", null); }
            set
            {
                this.OnPropertyChanging("business_unit_goalrollupquery");
                this.SetRelatedEntities<GoalRollupQuery>("business_unit_goalrollupquery", null, value);
                this.OnPropertyChanged("business_unit_goalrollupquery");
            }
        }

        /// <summary>
        /// 1:N business_unit_incident_resolution_activities
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_incident_resolution_activities")]
        public System.Collections.Generic.IEnumerable<IncidentResolution> business_unit_incident_resolution_activities
        {
            get { return this.GetRelatedEntities<IncidentResolution>("business_unit_incident_resolution_activities", null); }
            set
            {
                this.OnPropertyChanging("business_unit_incident_resolution_activities");
                this.SetRelatedEntities<IncidentResolution>("business_unit_incident_resolution_activities", null, value);
                this.OnPropertyChanged("business_unit_incident_resolution_activities");
            }
        }

        /// <summary>
        /// 1:N business_unit_incidents
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_incidents")]
        public System.Collections.Generic.IEnumerable<Incident> business_unit_incidents
        {
            get { return this.GetRelatedEntities<Incident>("business_unit_incidents", null); }
            set
            {
                this.OnPropertyChanging("business_unit_incidents");
                this.SetRelatedEntities<Incident>("business_unit_incidents", null, value);
                this.OnPropertyChanged("business_unit_incidents");
            }
        }

        /// <summary>
        /// 1:N business_unit_invoices
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_invoices")]
        public System.Collections.Generic.IEnumerable<Invoice> business_unit_invoices
        {
            get { return this.GetRelatedEntities<Invoice>("business_unit_invoices", null); }
            set
            {
                this.OnPropertyChanging("business_unit_invoices");
                this.SetRelatedEntities<Invoice>("business_unit_invoices", null, value);
                this.OnPropertyChanged("business_unit_invoices");
            }
        }

        /// <summary>
        /// 1:N business_unit_leads
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_leads")]
        public System.Collections.Generic.IEnumerable<Lead> business_unit_leads
        {
            get { return this.GetRelatedEntities<Lead>("business_unit_leads", null); }
            set
            {
                this.OnPropertyChanging("business_unit_leads");
                this.SetRelatedEntities<Lead>("business_unit_leads", null, value);
                this.OnPropertyChanged("business_unit_leads");
            }
        }

        /// <summary>
        /// 1:N business_unit_letter_activities
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_letter_activities")]
        public System.Collections.Generic.IEnumerable<Letter> business_unit_letter_activities
        {
            get { return this.GetRelatedEntities<Letter>("business_unit_letter_activities", null); }
            set
            {
                this.OnPropertyChanging("business_unit_letter_activities");
                this.SetRelatedEntities<Letter>("business_unit_letter_activities", null, value);
                this.OnPropertyChanged("business_unit_letter_activities");
            }
        }

        /// <summary>
        /// 1:N business_unit_list
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_list")]
        public System.Collections.Generic.IEnumerable<List> business_unit_list
        {
            get { return this.GetRelatedEntities<List>("business_unit_list", null); }
            set
            {
                this.OnPropertyChanging("business_unit_list");
                this.SetRelatedEntities<List>("business_unit_list", null, value);
                this.OnPropertyChanged("business_unit_list");
            }
        }

        /// <summary>
        /// 1:N business_unit_mailbox
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_mailbox")]
        public System.Collections.Generic.IEnumerable<Mailbox> business_unit_mailbox
        {
            get { return this.GetRelatedEntities<Mailbox>("business_unit_mailbox", null); }
            set
            {
                this.OnPropertyChanging("business_unit_mailbox");
                this.SetRelatedEntities<Mailbox>("business_unit_mailbox", null, value);
                this.OnPropertyChanged("business_unit_mailbox");
            }
        }

        /// <summary>
        /// 1:N business_unit_mailmergetemplates
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_mailmergetemplates")]
        public System.Collections.Generic.IEnumerable<MailMergeTemplate> business_unit_mailmergetemplates
        {
            get { return this.GetRelatedEntities<MailMergeTemplate>("business_unit_mailmergetemplates", null); }
            set
            {
                this.OnPropertyChanging("business_unit_mailmergetemplates");
                this.SetRelatedEntities<MailMergeTemplate>("business_unit_mailmergetemplates", null, value);
                this.OnPropertyChanged("business_unit_mailmergetemplates");
            }
        }

        /// <summary>
        /// 1:N business_unit_msdyn_postalbum
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_msdyn_postalbum")]
        public System.Collections.Generic.IEnumerable<msdyn_PostAlbum> business_unit_msdyn_postalbum
        {
            get { return this.GetRelatedEntities<msdyn_PostAlbum>("business_unit_msdyn_postalbum", null); }
            set
            {
                this.OnPropertyChanging("business_unit_msdyn_postalbum");
                this.SetRelatedEntities<msdyn_PostAlbum>("business_unit_msdyn_postalbum", null, value);
                this.OnPropertyChanged("business_unit_msdyn_postalbum");
            }
        }

        /// <summary>
        /// 1:N business_unit_msdyn_wallsavedqueryusersettings
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_msdyn_wallsavedqueryusersettings")]
        public System.Collections.Generic.IEnumerable<msdyn_wallsavedqueryusersettings> business_unit_msdyn_wallsavedqueryusersettings
        {
            get { return this.GetRelatedEntities<msdyn_wallsavedqueryusersettings>("business_unit_msdyn_wallsavedqueryusersettings", null); }
            set
            {
                this.OnPropertyChanging("business_unit_msdyn_wallsavedqueryusersettings");
                this.SetRelatedEntities<msdyn_wallsavedqueryusersettings>("business_unit_msdyn_wallsavedqueryusersettings", null, value);
                this.OnPropertyChanged("business_unit_msdyn_wallsavedqueryusersettings");
            }
        }

        /// <summary>
        /// 1:N business_unit_opportunities
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_opportunities")]
        public System.Collections.Generic.IEnumerable<Opportunity> business_unit_opportunities
        {
            get { return this.GetRelatedEntities<Opportunity>("business_unit_opportunities", null); }
            set
            {
                this.OnPropertyChanging("business_unit_opportunities");
                this.SetRelatedEntities<Opportunity>("business_unit_opportunities", null, value);
                this.OnPropertyChanged("business_unit_opportunities");
            }
        }

        /// <summary>
        /// 1:N business_unit_opportunity_close_activities
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_opportunity_close_activities")]
        public System.Collections.Generic.IEnumerable<OpportunityClose> business_unit_opportunity_close_activities
        {
            get { return this.GetRelatedEntities<OpportunityClose>("business_unit_opportunity_close_activities", null); }
            set
            {
                this.OnPropertyChanging("business_unit_opportunity_close_activities");
                this.SetRelatedEntities<OpportunityClose>("business_unit_opportunity_close_activities", null, value);
                this.OnPropertyChanged("business_unit_opportunity_close_activities");
            }
        }

        /// <summary>
        /// 1:N business_unit_order_close_activities
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_order_close_activities")]
        public System.Collections.Generic.IEnumerable<OrderClose> business_unit_order_close_activities
        {
            get { return this.GetRelatedEntities<OrderClose>("business_unit_order_close_activities", null); }
            set
            {
                this.OnPropertyChanging("business_unit_order_close_activities");
                this.SetRelatedEntities<OrderClose>("business_unit_order_close_activities", null, value);
                this.OnPropertyChanged("business_unit_order_close_activities");
            }
        }

        /// <summary>
        /// 1:N business_unit_orders
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_orders")]
        public System.Collections.Generic.IEnumerable<SalesOrder> business_unit_orders
        {
            get { return this.GetRelatedEntities<SalesOrder>("business_unit_orders", null); }
            set
            {
                this.OnPropertyChanging("business_unit_orders");
                this.SetRelatedEntities<SalesOrder>("business_unit_orders", null, value);
                this.OnPropertyChanged("business_unit_orders");
            }
        }

        /// <summary>
        /// 1:N business_unit_parent_business_unit
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_parent_business_unit", Microsoft.Xrm.Sdk.EntityRole.Referenced)]
        public System.Collections.Generic.IEnumerable<BusinessUnit> Referencedbusiness_unit_parent_business_unit
        {
            get { return this.GetRelatedEntities<BusinessUnit>("business_unit_parent_business_unit", Microsoft.Xrm.Sdk.EntityRole.Referenced); }
            set
            {
                this.OnPropertyChanging("Referencedbusiness_unit_parent_business_unit");
                this.SetRelatedEntities<BusinessUnit>("business_unit_parent_business_unit", Microsoft.Xrm.Sdk.EntityRole.Referenced, value);
                this.OnPropertyChanged("Referencedbusiness_unit_parent_business_unit");
            }
        }

        /// <summary>
        /// 1:N business_unit_phone_call_activities
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_phone_call_activities")]
        public System.Collections.Generic.IEnumerable<PhoneCall> business_unit_phone_call_activities
        {
            get { return this.GetRelatedEntities<PhoneCall>("business_unit_phone_call_activities", null); }
            set
            {
                this.OnPropertyChanging("business_unit_phone_call_activities");
                this.SetRelatedEntities<PhoneCall>("business_unit_phone_call_activities", null, value);
                this.OnPropertyChanged("business_unit_phone_call_activities");
            }
        }

        /// <summary>
        /// 1:N business_unit_postfollows
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_postfollows")]
        public System.Collections.Generic.IEnumerable<PostFollow> business_unit_postfollows
        {
            get { return this.GetRelatedEntities<PostFollow>("business_unit_postfollows", null); }
            set
            {
                this.OnPropertyChanging("business_unit_postfollows");
                this.SetRelatedEntities<PostFollow>("business_unit_postfollows", null, value);
                this.OnPropertyChanged("business_unit_postfollows");
            }
        }

        /// <summary>
        /// 1:N business_unit_queues
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_queues")]
        public System.Collections.Generic.IEnumerable<Queue> business_unit_queues
        {
            get { return this.GetRelatedEntities<Queue>("business_unit_queues", null); }
            set
            {
                this.OnPropertyChanging("business_unit_queues");
                this.SetRelatedEntities<Queue>("business_unit_queues", null, value);
                this.OnPropertyChanged("business_unit_queues");
            }
        }

        /// <summary>
        /// 1:N business_unit_queues2
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_queues2")]
        public System.Collections.Generic.IEnumerable<Queue> business_unit_queues2
        {
            get { return this.GetRelatedEntities<Queue>("business_unit_queues2", null); }
            set
            {
                this.OnPropertyChanging("business_unit_queues2");
                this.SetRelatedEntities<Queue>("business_unit_queues2", null, value);
                this.OnPropertyChanged("business_unit_queues2");
            }
        }

        /// <summary>
        /// 1:N business_unit_quote_close_activities
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_quote_close_activities")]
        public System.Collections.Generic.IEnumerable<QuoteClose> business_unit_quote_close_activities
        {
            get { return this.GetRelatedEntities<QuoteClose>("business_unit_quote_close_activities", null); }
            set
            {
                this.OnPropertyChanging("business_unit_quote_close_activities");
                this.SetRelatedEntities<QuoteClose>("business_unit_quote_close_activities", null, value);
                this.OnPropertyChanged("business_unit_quote_close_activities");
            }
        }

        /// <summary>
        /// 1:N business_unit_quotes
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_quotes")]
        public System.Collections.Generic.IEnumerable<Quote> business_unit_quotes
        {
            get { return this.GetRelatedEntities<Quote>("business_unit_quotes", null); }
            set
            {
                this.OnPropertyChanging("business_unit_quotes");
                this.SetRelatedEntities<Quote>("business_unit_quotes", null, value);
                this.OnPropertyChanged("business_unit_quotes");
            }
        }

        /// <summary>
        /// 1:N business_unit_recurrencerule
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_recurrencerule")]
        public System.Collections.Generic.IEnumerable<RecurrenceRule> business_unit_recurrencerule
        {
            get { return this.GetRelatedEntities<RecurrenceRule>("business_unit_recurrencerule", null); }
            set
            {
                this.OnPropertyChanging("business_unit_recurrencerule");
                this.SetRelatedEntities<RecurrenceRule>("business_unit_recurrencerule", null, value);
                this.OnPropertyChanged("business_unit_recurrencerule");
            }
        }

        /// <summary>
        /// 1:N business_unit_recurringappointmentmaster_activities
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_recurringappointmentmaster_activities")]
        public System.Collections.Generic.IEnumerable<RecurringAppointmentMaster> business_unit_recurringappointmentmaster_activities
        {
            get { return this.GetRelatedEntities<RecurringAppointmentMaster>("business_unit_recurringappointmentmaster_activities", null); }
            set
            {
                this.OnPropertyChanging("business_unit_recurringappointmentmaster_activities");
                this.SetRelatedEntities<RecurringAppointmentMaster>("business_unit_recurringappointmentmaster_activities", null, value);
                this.OnPropertyChanged("business_unit_recurringappointmentmaster_activities");
            }
        }

        /// <summary>
        /// 1:N business_unit_reports
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_reports")]
        public System.Collections.Generic.IEnumerable<Report> business_unit_reports
        {
            get { return this.GetRelatedEntities<Report>("business_unit_reports", null); }
            set
            {
                this.OnPropertyChanging("business_unit_reports");
                this.SetRelatedEntities<Report>("business_unit_reports", null, value);
                this.OnPropertyChanged("business_unit_reports");
            }
        }

        /// <summary>
        /// 1:N business_unit_resource_groups
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_resource_groups")]
        public System.Collections.Generic.IEnumerable<ResourceGroup> business_unit_resource_groups
        {
            get { return this.GetRelatedEntities<ResourceGroup>("business_unit_resource_groups", null); }
            set
            {
                this.OnPropertyChanging("business_unit_resource_groups");
                this.SetRelatedEntities<ResourceGroup>("business_unit_resource_groups", null, value);
                this.OnPropertyChanged("business_unit_resource_groups");
            }
        }

        /// <summary>
        /// 1:N business_unit_resource_specs
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_resource_specs")]
        public System.Collections.Generic.IEnumerable<ResourceSpec> business_unit_resource_specs
        {
            get { return this.GetRelatedEntities<ResourceSpec>("business_unit_resource_specs", null); }
            set
            {
                this.OnPropertyChanging("business_unit_resource_specs");
                this.SetRelatedEntities<ResourceSpec>("business_unit_resource_specs", null, value);
                this.OnPropertyChanged("business_unit_resource_specs");
            }
        }

        /// <summary>
        /// 1:N business_unit_resources
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_resources")]
        public System.Collections.Generic.IEnumerable<Resource> business_unit_resources
        {
            get { return this.GetRelatedEntities<Resource>("business_unit_resources", null); }
            set
            {
                this.OnPropertyChanging("business_unit_resources");
                this.SetRelatedEntities<Resource>("business_unit_resources", null, value);
                this.OnPropertyChanged("business_unit_resources");
            }
        }

        /// <summary>
        /// 1:N business_unit_roles
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_roles")]
        public System.Collections.Generic.IEnumerable<Role> business_unit_roles
        {
            get { return this.GetRelatedEntities<Role>("business_unit_roles", null); }
            set
            {
                this.OnPropertyChanging("business_unit_roles");
                this.SetRelatedEntities<Role>("business_unit_roles", null, value);
                this.OnPropertyChanged("business_unit_roles");
            }
        }

        /// <summary>
        /// 1:N business_unit_routingrule
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_routingrule")]
        public System.Collections.Generic.IEnumerable<RoutingRule> business_unit_routingrule
        {
            get { return this.GetRelatedEntities<RoutingRule>("business_unit_routingrule", null); }
            set
            {
                this.OnPropertyChanging("business_unit_routingrule");
                this.SetRelatedEntities<RoutingRule>("business_unit_routingrule", null, value);
                this.OnPropertyChanged("business_unit_routingrule");
            }
        }

        /// <summary>
        /// 1:N business_unit_service_appointments
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_service_appointments")]
        public System.Collections.Generic.IEnumerable<ServiceAppointment> business_unit_service_appointments
        {
            get { return this.GetRelatedEntities<ServiceAppointment>("business_unit_service_appointments", null); }
            set
            {
                this.OnPropertyChanging("business_unit_service_appointments");
                this.SetRelatedEntities<ServiceAppointment>("business_unit_service_appointments", null, value);
                this.OnPropertyChanged("business_unit_service_appointments");
            }
        }

        /// <summary>
        /// 1:N business_unit_service_contracts
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_service_contracts")]
        public System.Collections.Generic.IEnumerable<Contract> business_unit_service_contracts
        {
            get { return this.GetRelatedEntities<Contract>("business_unit_service_contracts", null); }
            set
            {
                this.OnPropertyChanging("business_unit_service_contracts");
                this.SetRelatedEntities<Contract>("business_unit_service_contracts", null, value);
                this.OnPropertyChanged("business_unit_service_contracts");
            }
        }

        /// <summary>
        /// 1:N business_unit_sharepointdocument
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_sharepointdocument")]
        public System.Collections.Generic.IEnumerable<SharePointDocument> business_unit_sharepointdocument
        {
            get { return this.GetRelatedEntities<SharePointDocument>("business_unit_sharepointdocument", null); }
            set
            {
                this.OnPropertyChanging("business_unit_sharepointdocument");
                this.SetRelatedEntities<SharePointDocument>("business_unit_sharepointdocument", null, value);
                this.OnPropertyChanged("business_unit_sharepointdocument");
            }
        }

        /// <summary>
        /// 1:N business_unit_sharepointdocument2
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_sharepointdocument2")]
        public System.Collections.Generic.IEnumerable<SharePointDocument> business_unit_sharepointdocument2
        {
            get { return this.GetRelatedEntities<SharePointDocument>("business_unit_sharepointdocument2", null); }
            set
            {
                this.OnPropertyChanging("business_unit_sharepointdocument2");
                this.SetRelatedEntities<SharePointDocument>("business_unit_sharepointdocument2", null, value);
                this.OnPropertyChanged("business_unit_sharepointdocument2");
            }
        }

        /// <summary>
        /// 1:N business_unit_sharepointdocumentlocation
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_sharepointdocumentlocation")]
        public System.Collections.Generic.IEnumerable<SharePointDocumentLocation> business_unit_sharepointdocumentlocation
        {
            get { return this.GetRelatedEntities<SharePointDocumentLocation>("business_unit_sharepointdocumentlocation", null); }
            set
            {
                this.OnPropertyChanging("business_unit_sharepointdocumentlocation");
                this.SetRelatedEntities<SharePointDocumentLocation>("business_unit_sharepointdocumentlocation", null, value);
                this.OnPropertyChanged("business_unit_sharepointdocumentlocation");
            }
        }

        /// <summary>
        /// 1:N business_unit_sharepointsites
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_sharepointsites")]
        public System.Collections.Generic.IEnumerable<SharePointSite> business_unit_sharepointsites
        {
            get { return this.GetRelatedEntities<SharePointSite>("business_unit_sharepointsites", null); }
            set
            {
                this.OnPropertyChanging("business_unit_sharepointsites");
                this.SetRelatedEntities<SharePointSite>("business_unit_sharepointsites", null, value);
                this.OnPropertyChanged("business_unit_sharepointsites");
            }
        }

        /// <summary>
        /// 1:N business_unit_slabase
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_slabase")]
        public System.Collections.Generic.IEnumerable<SLA> business_unit_slabase
        {
            get { return this.GetRelatedEntities<SLA>("business_unit_slabase", null); }
            set
            {
                this.OnPropertyChanging("business_unit_slabase");
                this.SetRelatedEntities<SLA>("business_unit_slabase", null, value);
                this.OnPropertyChanged("business_unit_slabase");
            }
        }

        /// <summary>
        /// 1:N business_unit_slakpiinstance
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_slakpiinstance")]
        public System.Collections.Generic.IEnumerable<SLAKPIInstance> business_unit_slakpiinstance
        {
            get { return this.GetRelatedEntities<SLAKPIInstance>("business_unit_slakpiinstance", null); }
            set
            {
                this.OnPropertyChanging("business_unit_slakpiinstance");
                this.SetRelatedEntities<SLAKPIInstance>("business_unit_slakpiinstance", null, value);
                this.OnPropertyChanged("business_unit_slakpiinstance");
            }
        }

        /// <summary>
        /// 1:N business_unit_socialactivity
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_socialactivity")]
        public System.Collections.Generic.IEnumerable<SocialActivity> business_unit_socialactivity
        {
            get { return this.GetRelatedEntities<SocialActivity>("business_unit_socialactivity", null); }
            set
            {
                this.OnPropertyChanging("business_unit_socialactivity");
                this.SetRelatedEntities<SocialActivity>("business_unit_socialactivity", null, value);
                this.OnPropertyChanged("business_unit_socialactivity");
            }
        }

        /// <summary>
        /// 1:N business_unit_socialprofiles
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_socialprofiles")]
        public System.Collections.Generic.IEnumerable<SocialProfile> business_unit_socialprofiles
        {
            get { return this.GetRelatedEntities<SocialProfile>("business_unit_socialprofiles", null); }
            set
            {
                this.OnPropertyChanging("business_unit_socialprofiles");
                this.SetRelatedEntities<SocialProfile>("business_unit_socialprofiles", null, value);
                this.OnPropertyChanged("business_unit_socialprofiles");
            }
        }

        /// <summary>
        /// 1:N business_unit_system_users
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_system_users")]
        public System.Collections.Generic.IEnumerable<SystemUser> business_unit_system_users
        {
            get { return this.GetRelatedEntities<SystemUser>("business_unit_system_users", null); }
            set
            {
                this.OnPropertyChanging("business_unit_system_users");
                this.SetRelatedEntities<SystemUser>("business_unit_system_users", null, value);
                this.OnPropertyChanged("business_unit_system_users");
            }
        }

        /// <summary>
        /// 1:N business_unit_task_activities
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_task_activities")]
        public System.Collections.Generic.IEnumerable<Task> business_unit_task_activities
        {
            get { return this.GetRelatedEntities<Task>("business_unit_task_activities", null); }
            set
            {
                this.OnPropertyChanging("business_unit_task_activities");
                this.SetRelatedEntities<Task>("business_unit_task_activities", null, value);
                this.OnPropertyChanged("business_unit_task_activities");
            }
        }

        /// <summary>
        /// 1:N business_unit_teams
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_teams")]
        public System.Collections.Generic.IEnumerable<Team> business_unit_teams
        {
            get { return this.GetRelatedEntities<Team>("business_unit_teams", null); }
            set
            {
                this.OnPropertyChanging("business_unit_teams");
                this.SetRelatedEntities<Team>("business_unit_teams", null, value);
                this.OnPropertyChanged("business_unit_teams");
            }
        }

        /// <summary>
        /// 1:N business_unit_templates
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_templates")]
        public System.Collections.Generic.IEnumerable<Template> business_unit_templates
        {
            get { return this.GetRelatedEntities<Template>("business_unit_templates", null); }
            set
            {
                this.OnPropertyChanging("business_unit_templates");
                this.SetRelatedEntities<Template>("business_unit_templates", null, value);
                this.OnPropertyChanged("business_unit_templates");
            }
        }

        /// <summary>
        /// 1:N business_unit_user_settings
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_user_settings")]
        public System.Collections.Generic.IEnumerable<UserSettings> business_unit_user_settings
        {
            get { return this.GetRelatedEntities<UserSettings>("business_unit_user_settings", null); }
            set
            {
                this.OnPropertyChanging("business_unit_user_settings");
                this.SetRelatedEntities<UserSettings>("business_unit_user_settings", null, value);
                this.OnPropertyChanged("business_unit_user_settings");
            }
        }

        /// <summary>
        /// 1:N business_unit_userform
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_userform")]
        public System.Collections.Generic.IEnumerable<UserForm> business_unit_userform
        {
            get { return this.GetRelatedEntities<UserForm>("business_unit_userform", null); }
            set
            {
                this.OnPropertyChanging("business_unit_userform");
                this.SetRelatedEntities<UserForm>("business_unit_userform", null, value);
                this.OnPropertyChanged("business_unit_userform");
            }
        }

        /// <summary>
        /// 1:N business_unit_userquery
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_userquery")]
        public System.Collections.Generic.IEnumerable<UserQuery> business_unit_userquery
        {
            get { return this.GetRelatedEntities<UserQuery>("business_unit_userquery", null); }
            set
            {
                this.OnPropertyChanging("business_unit_userquery");
                this.SetRelatedEntities<UserQuery>("business_unit_userquery", null, value);
                this.OnPropertyChanged("business_unit_userquery");
            }
        }

        /// <summary>
        /// 1:N business_unit_userqueryvisualizations
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_userqueryvisualizations")]
        public System.Collections.Generic.IEnumerable<UserQueryVisualization> business_unit_userqueryvisualizations
        {
            get { return this.GetRelatedEntities<UserQueryVisualization>("business_unit_userqueryvisualizations", null); }
            set
            {
                this.OnPropertyChanging("business_unit_userqueryvisualizations");
                this.SetRelatedEntities<UserQueryVisualization>("business_unit_userqueryvisualizations", null, value);
                this.OnPropertyChanged("business_unit_userqueryvisualizations");
            }
        }

        /// <summary>
        /// 1:N business_unit_workflow
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_workflow")]
        public System.Collections.Generic.IEnumerable<Workflow> business_unit_workflow
        {
            get { return this.GetRelatedEntities<Workflow>("business_unit_workflow", null); }
            set
            {
                this.OnPropertyChanging("business_unit_workflow");
                this.SetRelatedEntities<Workflow>("business_unit_workflow", null, value);
                this.OnPropertyChanged("business_unit_workflow");
            }
        }

        /// <summary>
        /// 1:N business_unit_workflowlogs
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_workflowlogs")]
        public System.Collections.Generic.IEnumerable<WorkflowLog> business_unit_workflowlogs
        {
            get { return this.GetRelatedEntities<WorkflowLog>("business_unit_workflowlogs", null); }
            set
            {
                this.OnPropertyChanging("business_unit_workflowlogs");
                this.SetRelatedEntities<WorkflowLog>("business_unit_workflowlogs", null, value);
                this.OnPropertyChanged("business_unit_workflowlogs");
            }
        }

        /// <summary>
        /// 1:N BusinessUnit_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("BusinessUnit_AsyncOperations")]
        public System.Collections.Generic.IEnumerable<AsyncOperation> BusinessUnit_AsyncOperations
        {
            get { return this.GetRelatedEntities<AsyncOperation>("BusinessUnit_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("BusinessUnit_AsyncOperations");
                this.SetRelatedEntities<AsyncOperation>("BusinessUnit_AsyncOperations", null, value);
                this.OnPropertyChanged("BusinessUnit_AsyncOperations");
            }
        }

        /// <summary>
        /// 1:N BusinessUnit_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("BusinessUnit_BulkDeleteFailures")]
        public System.Collections.Generic.IEnumerable<BulkDeleteFailure> BusinessUnit_BulkDeleteFailures
        {
            get { return this.GetRelatedEntities<BulkDeleteFailure>("BusinessUnit_BulkDeleteFailures", null); }
            set
            {
                this.OnPropertyChanging("BusinessUnit_BulkDeleteFailures");
                this.SetRelatedEntities<BulkDeleteFailure>("BusinessUnit_BulkDeleteFailures", null, value);
                this.OnPropertyChanged("BusinessUnit_BulkDeleteFailures");
            }
        }

        /// <summary>
        /// 1:N BusinessUnit_Campaigns
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("BusinessUnit_Campaigns")]
        public System.Collections.Generic.IEnumerable<Campaign> BusinessUnit_Campaigns
        {
            get { return this.GetRelatedEntities<Campaign>("BusinessUnit_Campaigns", null); }
            set
            {
                this.OnPropertyChanging("BusinessUnit_Campaigns");
                this.SetRelatedEntities<Campaign>("BusinessUnit_Campaigns", null, value);
                this.OnPropertyChanged("BusinessUnit_Campaigns");
            }
        }

        /// <summary>
        /// 1:N BusinessUnit_DuplicateRules
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("BusinessUnit_DuplicateRules")]
        public System.Collections.Generic.IEnumerable<DuplicateRule> BusinessUnit_DuplicateRules
        {
            get { return this.GetRelatedEntities<DuplicateRule>("BusinessUnit_DuplicateRules", null); }
            set
            {
                this.OnPropertyChanging("BusinessUnit_DuplicateRules");
                this.SetRelatedEntities<DuplicateRule>("BusinessUnit_DuplicateRules", null, value);
                this.OnPropertyChanged("BusinessUnit_DuplicateRules");
            }
        }

        /// <summary>
        /// 1:N BusinessUnit_ImportFiles
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("BusinessUnit_ImportFiles")]
        public System.Collections.Generic.IEnumerable<ImportFile> BusinessUnit_ImportFiles
        {
            get { return this.GetRelatedEntities<ImportFile>("BusinessUnit_ImportFiles", null); }
            set
            {
                this.OnPropertyChanging("BusinessUnit_ImportFiles");
                this.SetRelatedEntities<ImportFile>("BusinessUnit_ImportFiles", null, value);
                this.OnPropertyChanged("BusinessUnit_ImportFiles");
            }
        }

        /// <summary>
        /// 1:N BusinessUnit_ImportLogs
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("BusinessUnit_ImportLogs")]
        public System.Collections.Generic.IEnumerable<ImportLog> BusinessUnit_ImportLogs
        {
            get { return this.GetRelatedEntities<ImportLog>("BusinessUnit_ImportLogs", null); }
            set
            {
                this.OnPropertyChanging("BusinessUnit_ImportLogs");
                this.SetRelatedEntities<ImportLog>("BusinessUnit_ImportLogs", null, value);
                this.OnPropertyChanged("BusinessUnit_ImportLogs");
            }
        }

        /// <summary>
        /// 1:N BusinessUnit_ImportMaps
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("BusinessUnit_ImportMaps")]
        public System.Collections.Generic.IEnumerable<ImportMap> BusinessUnit_ImportMaps
        {
            get { return this.GetRelatedEntities<ImportMap>("BusinessUnit_ImportMaps", null); }
            set
            {
                this.OnPropertyChanging("BusinessUnit_ImportMaps");
                this.SetRelatedEntities<ImportMap>("BusinessUnit_ImportMaps", null, value);
                this.OnPropertyChanged("BusinessUnit_ImportMaps");
            }
        }

        /// <summary>
        /// 1:N BusinessUnit_Imports
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("BusinessUnit_Imports")]
        public System.Collections.Generic.IEnumerable<Import> BusinessUnit_Imports
        {
            get { return this.GetRelatedEntities<Import>("BusinessUnit_Imports", null); }
            set
            {
                this.OnPropertyChanging("BusinessUnit_Imports");
                this.SetRelatedEntities<Import>("BusinessUnit_Imports", null, value);
                this.OnPropertyChanged("BusinessUnit_Imports");
            }
        }

        /// <summary>
        /// 1:N businessunit_principalobjectattributeaccess
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("businessunit_principalobjectattributeaccess")]
        public System.Collections.Generic.IEnumerable<PrincipalObjectAttributeAccess> businessunit_principalobjectattributeaccess
        {
            get { return this.GetRelatedEntities<PrincipalObjectAttributeAccess>("businessunit_principalobjectattributeaccess", null); }
            set
            {
                this.OnPropertyChanging("businessunit_principalobjectattributeaccess");
                this.SetRelatedEntities<PrincipalObjectAttributeAccess>("businessunit_principalobjectattributeaccess", null, value);
                this.OnPropertyChanged("businessunit_principalobjectattributeaccess");
            }
        }

        /// <summary>
        /// 1:N BusinessUnit_ProcessSessions
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("BusinessUnit_ProcessSessions")]
        public System.Collections.Generic.IEnumerable<ProcessSession> BusinessUnit_ProcessSessions
        {
            get { return this.GetRelatedEntities<ProcessSession>("BusinessUnit_ProcessSessions", null); }
            set
            {
                this.OnPropertyChanging("BusinessUnit_ProcessSessions");
                this.SetRelatedEntities<ProcessSession>("BusinessUnit_ProcessSessions", null, value);
                this.OnPropertyChanged("BusinessUnit_ProcessSessions");
            }
        }

        /// <summary>
        /// 1:N Owning_businessunit_processsessions
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Owning_businessunit_processsessions")]
        public System.Collections.Generic.IEnumerable<ProcessSession> Owning_businessunit_processsessions
        {
            get { return this.GetRelatedEntities<ProcessSession>("Owning_businessunit_processsessions", null); }
            set
            {
                this.OnPropertyChanging("Owning_businessunit_processsessions");
                this.SetRelatedEntities<ProcessSession>("Owning_businessunit_processsessions", null, value);
                this.OnPropertyChanged("Owning_businessunit_processsessions");
            }
        }

        /// <summary>
        /// 1:N userentityinstancedata_businessunit
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_businessunit")]
        public System.Collections.Generic.IEnumerable<UserEntityInstanceData> userentityinstancedata_businessunit
        {
            get { return this.GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_businessunit", null); }
            set
            {
                this.OnPropertyChanging("userentityinstancedata_businessunit");
                this.SetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_businessunit", null, value);
                this.OnPropertyChanged("userentityinstancedata_businessunit");
            }
        }

        /// <summary>
        /// 1:N userentityuisettings_businessunit
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityuisettings_businessunit")]
        public System.Collections.Generic.IEnumerable<UserEntityUISettings> userentityuisettings_businessunit
        {
            get { return this.GetRelatedEntities<UserEntityUISettings>("userentityuisettings_businessunit", null); }
            set
            {
                this.OnPropertyChanging("userentityuisettings_businessunit");
                this.SetRelatedEntities<UserEntityUISettings>("userentityuisettings_businessunit", null, value);
                this.OnPropertyChanged("userentityuisettings_businessunit");
            }
        }

        /// <summary>
        /// N:1 business_unit_parent_business_unit
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("parentbusinessunitid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_parent_business_unit", Microsoft.Xrm.Sdk.EntityRole.Referencing)]
        public BusinessUnit Referencingbusiness_unit_parent_business_unit
        {
            get { return this.GetRelatedEntity<BusinessUnit>("business_unit_parent_business_unit", Microsoft.Xrm.Sdk.EntityRole.Referencing); }
            set
            {
                this.OnPropertyChanging("Referencingbusiness_unit_parent_business_unit");
                this.SetRelatedEntity<BusinessUnit>("business_unit_parent_business_unit", Microsoft.Xrm.Sdk.EntityRole.Referencing, value);
                this.OnPropertyChanged("Referencingbusiness_unit_parent_business_unit");
            }
        }

        /// <summary>
        /// N:1 BusinessUnit_Calendar
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("calendarid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("BusinessUnit_Calendar")]
        public Calendar BusinessUnit_Calendar
        {
            get { return this.GetRelatedEntity<Calendar>("BusinessUnit_Calendar", null); }
            set
            {
                this.OnPropertyChanging("BusinessUnit_Calendar");
                this.SetRelatedEntity<Calendar>("BusinessUnit_Calendar", null, value);
                this.OnPropertyChanged("BusinessUnit_Calendar");
            }
        }

        /// <summary>
        /// N:1 lk_businessunit_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_businessunit_createdonbehalfby")]
        public SystemUser lk_businessunit_createdonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_businessunit_createdonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_businessunit_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_businessunit_modifiedonbehalfby")]
        public SystemUser lk_businessunit_modifiedonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_businessunit_modifiedonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_businessunitbase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_businessunitbase_createdby")]
        public SystemUser lk_businessunitbase_createdby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_businessunitbase_createdby", null); }
        }

        /// <summary>
        /// N:1 lk_businessunitbase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_businessunitbase_modifiedby")]
        public SystemUser lk_businessunitbase_modifiedby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_businessunitbase_modifiedby", null); }
        }

        /// <summary>
        /// N:1 organization_business_units
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_business_units")]
        public Organization organization_business_units
        {
            get { return this.GetRelatedEntity<Organization>("organization_business_units", null); }
        }

        /// <summary>
        /// N:1 TransactionCurrency_BusinessUnit
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("TransactionCurrency_BusinessUnit")]
        public TransactionCurrency TransactionCurrency_BusinessUnit
        {
            get { return this.GetRelatedEntity<TransactionCurrency>("TransactionCurrency_BusinessUnit", null); }
            set
            {
                this.OnPropertyChanging("TransactionCurrency_BusinessUnit");
                this.SetRelatedEntity<TransactionCurrency>("TransactionCurrency_BusinessUnit", null, value);
                this.OnPropertyChanged("TransactionCurrency_BusinessUnit");
            }
        }
    }
}