namespace __4_DAL_CRM
{
    /// <summary>
    /// Business competing for the sale represented by a lead or opportunity.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("competitor")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class Competitor : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public Competitor() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "competitor";

        public const int EntityTypeCode = 123;

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
        /// Select the primary address type.
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
        /// Type the city for the primary address.
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
        /// Type the country or region for the primary address.
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
        /// Type the county for the primary address.
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
        /// Type the fax number associated with the primary address.
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
        /// Type the latitude value for the primary address for use in mapping and other applications.
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
        /// Type the first line of the primary address.
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
        /// Type the second line of the primary address.
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
        /// Type the third line of the primary address.
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
        /// Type the longitude value for the primary address for use in mapping and other applications.
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
        /// Type a descriptive name for the primary address, such as Corporate Headquarters.
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
        /// Type the ZIP Code or postal code for the primary address.
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
        /// Type the post office box number of the primary address.
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
        /// Select a shipping method for deliveries sent to this address.
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
        /// Type the state or province of the primary address.
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
        /// Type the main phone number associated with the primary address.
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
        /// Type a second phone number associated with the primary address.
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
        /// Type a third phone number associated with the primary address.
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
        /// Type the UPS zone of the primary address to make sure shipping charges are calculated correctly and deliveries are made promptly, if shipped by UPS.
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
        /// Select the time zone, or UTC offset, for this address so that other people can reference it when they contact someone at this address.
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
        /// Select the secondary address type.
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
        /// Type the city for the secondary address.
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
        /// Type the country or region for the secondary address.
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
        /// Type the county for the secondary address.
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
        /// Type the fax number associated with the secondary address.
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
        /// Type the latitude value for the secondary address for use in mapping and other applications.
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
        /// Type the first line of the secondary address.
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
        /// Type the second line of the secondary address.
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
        /// Type the third line of the secondary address.
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
        /// Type the longitude value for the secondary address for use in mapping and other applications.
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
        /// Type a descriptive name for the secondary address, such as Corporate Headquarters.
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
        /// Type the ZIP Code or postal code for the secondary address.
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
        /// Type the post office box number of the secondary address.
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
        /// Select a shipping method for deliveries sent to this address.
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
        /// Type the state or province of the secondary address.
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
        /// Type the main phone number associated with the secondary address.
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
        /// Type a second phone number associated with the secondary address.
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
        /// Type a third phone number associated with the secondary address.
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
        /// Type the UPS zone of the secondary address to make sure shipping charges are calculated correctly and deliveries are made promptly , if shipped by UPS.
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
        /// Select the time zone, or UTC offset, for this address so that other people can reference it when they contact someone at this address.
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
        /// Unique identifier of the competitor.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("competitorid")]
        public System.Nullable<System.Guid> CompetitorId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("competitorid"); }
            set
            {
                this.OnPropertyChanging("CompetitorId");
                this.SetAttributeValue("competitorid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("CompetitorId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("competitorid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.CompetitorId = value; }
        }

        /// <summary>
        /// Shows who created the record.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby"); }
        }

        /// <summary>
        /// Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics CRM options.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
        public System.Nullable<System.DateTime> CreatedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon"); }
        }

        /// <summary>
        /// Shows who created the record on behalf of another user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby"); }
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
        /// Shows the conversion rate of the record's currency. The exchange rate is used to convert all money fields in the record from the local currency to the system's default currency.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("exchangerate")]
        public System.Nullable<decimal> ExchangeRate
        {
            get { return this.GetAttributeValue<System.Nullable<decimal>>("exchangerate"); }
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
        /// Type the competitor's primary product, service, or specialty.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("keyproduct")]
        public string KeyProduct
        {
            get { return this.GetAttributeValue<string>("keyproduct"); }
            set
            {
                this.OnPropertyChanging("KeyProduct");
                this.SetAttributeValue("keyproduct", value);
                this.OnPropertyChanged("KeyProduct");
            }
        }

        /// <summary>
        /// Shows who last updated the record.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby"); }
        }

        /// <summary>
        /// Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics CRM options.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
        public System.Nullable<System.DateTime> ModifiedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon"); }
        }

        /// <summary>
        /// Shows who last updated the record on behalf of another user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        /// Type the company or business name used to identify the competitor in data views and related records.
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
        /// Type notes or other information about the competitive opportunities or selling points you can make.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("opportunities")]
        public string Opportunities
        {
            get { return this.GetAttributeValue<string>("opportunities"); }
            set
            {
                this.OnPropertyChanging("Opportunities");
                this.SetAttributeValue("opportunities", value);
                this.OnPropertyChanged("Opportunities");
            }
        }

        /// <summary>
        /// Unique identifier of the associated organization.
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
        /// Type notes or other information about the competitor's business, such as location, revenue, or distribution channel.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("overview")]
        public string Overview
        {
            get { return this.GetAttributeValue<string>("overview"); }
            set
            {
                this.OnPropertyChanging("Overview");
                this.SetAttributeValue("overview", value);
                this.OnPropertyChanged("Overview");
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
        /// Type the URL for the website used to obtain reference information about the competitor.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("referenceinfourl")]
        public string ReferenceInfoUrl
        {
            get { return this.GetAttributeValue<string>("referenceinfourl"); }
            set
            {
                this.OnPropertyChanging("ReferenceInfoUrl");
                this.SetAttributeValue("referenceinfourl", value);
                this.OnPropertyChanged("ReferenceInfoUrl");
            }
        }

        /// <summary>
        /// Type the amount of revenue reported in the competitor's annual report or other source.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("reportedrevenue")]
        public Microsoft.Xrm.Sdk.Money ReportedRevenue
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("reportedrevenue"); }
            set
            {
                this.OnPropertyChanging("ReportedRevenue");
                this.SetAttributeValue("reportedrevenue", value);
                this.OnPropertyChanged("ReportedRevenue");
            }
        }

        /// <summary>
        /// Shows the Reported Revenue field converted to the system's default base currency for reporting purposes. The calculations use the exchange rate specified in the Currencies area.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("reportedrevenue_base")]
        public Microsoft.Xrm.Sdk.Money ReportedRevenue_Base
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("reportedrevenue_base"); }
        }

        /// <summary>
        /// Type the quarter number during which the competitor's reported revenue was recorded or announced for use in reporting and analysis.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("reportingquarter")]
        public System.Nullable<int> ReportingQuarter
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("reportingquarter"); }
            set
            {
                this.OnPropertyChanging("ReportingQuarter");
                this.SetAttributeValue("reportingquarter", value);
                this.OnPropertyChanged("ReportingQuarter");
            }
        }

        /// <summary>
        /// Type the fiscal year during which the competitor's reported revenue was announced for use in reporting and analysis.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("reportingyear")]
        public System.Nullable<int> ReportingYear
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("reportingyear"); }
            set
            {
                this.OnPropertyChanging("ReportingYear");
                this.SetAttributeValue("reportingyear", value);
                this.OnPropertyChanged("ReportingYear");
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
        /// Type the stock exchange at which the competitor is listed to track their stock and financial performance of the company.
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
        /// Type notes or other information about the competitor's strengths, such as top-selling products and targeted industries or markets.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("strengths")]
        public string Strengths
        {
            get { return this.GetAttributeValue<string>("strengths"); }
            set
            {
                this.OnPropertyChanging("Strengths");
                this.SetAttributeValue("strengths", value);
                this.OnPropertyChanged("Strengths");
            }
        }

        /// <summary>
        /// Type notes or other information about the competitor's threats to your organization when you sell to the same prospect or customer.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("threats")]
        public string Threats
        {
            get { return this.GetAttributeValue<string>("threats"); }
            set
            {
                this.OnPropertyChanging("Threats");
                this.SetAttributeValue("threats", value);
                this.OnPropertyChanged("Threats");
            }
        }

        /// <summary>
        /// Type the stock exchange symbol for the competitor to track financial performance of the company. You can click the code entered in this field to access the latest trading information from MSN Money.
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
        /// Choose the local currency for the record to make sure budgets are reported in the correct currency.
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
        /// Version number of the competitor.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
        public System.Nullable<long> VersionNumber
        {
            get { return this.GetAttributeValue<System.Nullable<long>>("versionnumber"); }
        }

        /// <summary>
        /// Type notes or other information about the competitor's weaknesses or areas in which your organization outperforms the competitor.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("weaknesses")]
        public string Weaknesses
        {
            get { return this.GetAttributeValue<string>("weaknesses"); }
            set
            {
                this.OnPropertyChanging("Weaknesses");
                this.SetAttributeValue("weaknesses", value);
                this.OnPropertyChanged("Weaknesses");
            }
        }

        /// <summary>
        /// Type the website URL for the competitor.
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
        /// Type the percentage of your organization's lost opportunities that are won by the competitor to identify your strongest competitors.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("winpercentage")]
        public System.Nullable<double> WinPercentage
        {
            get { return this.GetAttributeValue<System.Nullable<double>>("winpercentage"); }
            set
            {
                this.OnPropertyChanging("WinPercentage");
                this.SetAttributeValue("winpercentage", value);
                this.OnPropertyChanged("WinPercentage");
            }
        }

        /// <summary>
        /// Type the phonetic spelling of the competitor's name, if specified in Japanese, to make sure the name is pronounced correctly in phone calls and other communications.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("yominame")]
        public string YomiName
        {
            get { return this.GetAttributeValue<string>("yominame"); }
            set
            {
                this.OnPropertyChanging("YomiName");
                this.SetAttributeValue("yominame", value);
                this.OnPropertyChanged("YomiName");
            }
        }

        /// <summary>
        /// 1:N Competitor_Annotation
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Competitor_Annotation")]
        public System.Collections.Generic.IEnumerable<Annotation> Competitor_Annotation
        {
            get { return this.GetRelatedEntities<Annotation>("Competitor_Annotation", null); }
            set
            {
                this.OnPropertyChanging("Competitor_Annotation");
                this.SetRelatedEntities<Annotation>("Competitor_Annotation", null, value);
                this.OnPropertyChanged("Competitor_Annotation");
            }
        }

        /// <summary>
        /// 1:N Competitor_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Competitor_AsyncOperations")]
        public System.Collections.Generic.IEnumerable<AsyncOperation> Competitor_AsyncOperations
        {
            get { return this.GetRelatedEntities<AsyncOperation>("Competitor_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("Competitor_AsyncOperations");
                this.SetRelatedEntities<AsyncOperation>("Competitor_AsyncOperations", null, value);
                this.OnPropertyChanged("Competitor_AsyncOperations");
            }
        }

        /// <summary>
        /// 1:N Competitor_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Competitor_BulkDeleteFailures")]
        public System.Collections.Generic.IEnumerable<BulkDeleteFailure> Competitor_BulkDeleteFailures
        {
            get { return this.GetRelatedEntities<BulkDeleteFailure>("Competitor_BulkDeleteFailures", null); }
            set
            {
                this.OnPropertyChanging("Competitor_BulkDeleteFailures");
                this.SetRelatedEntities<BulkDeleteFailure>("Competitor_BulkDeleteFailures", null, value);
                this.OnPropertyChanged("Competitor_BulkDeleteFailures");
            }
        }

        /// <summary>
        /// 1:N competitor_connections1
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("competitor_connections1")]
        public System.Collections.Generic.IEnumerable<Connection> competitor_connections1
        {
            get { return this.GetRelatedEntities<Connection>("competitor_connections1", null); }
            set
            {
                this.OnPropertyChanging("competitor_connections1");
                this.SetRelatedEntities<Connection>("competitor_connections1", null, value);
                this.OnPropertyChanged("competitor_connections1");
            }
        }

        /// <summary>
        /// 1:N competitor_connections2
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("competitor_connections2")]
        public System.Collections.Generic.IEnumerable<Connection> competitor_connections2
        {
            get { return this.GetRelatedEntities<Connection>("competitor_connections2", null); }
            set
            {
                this.OnPropertyChanging("competitor_connections2");
                this.SetRelatedEntities<Connection>("competitor_connections2", null, value);
                this.OnPropertyChanged("competitor_connections2");
            }
        }

        /// <summary>
        /// 1:N Competitor_DuplicateBaseRecord
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Competitor_DuplicateBaseRecord")]
        public System.Collections.Generic.IEnumerable<DuplicateRecord> Competitor_DuplicateBaseRecord
        {
            get { return this.GetRelatedEntities<DuplicateRecord>("Competitor_DuplicateBaseRecord", null); }
            set
            {
                this.OnPropertyChanging("Competitor_DuplicateBaseRecord");
                this.SetRelatedEntities<DuplicateRecord>("Competitor_DuplicateBaseRecord", null, value);
                this.OnPropertyChanged("Competitor_DuplicateBaseRecord");
            }
        }

        /// <summary>
        /// 1:N Competitor_DuplicateMatchingRecord
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Competitor_DuplicateMatchingRecord")]
        public System.Collections.Generic.IEnumerable<DuplicateRecord> Competitor_DuplicateMatchingRecord
        {
            get { return this.GetRelatedEntities<DuplicateRecord>("Competitor_DuplicateMatchingRecord", null); }
            set
            {
                this.OnPropertyChanging("Competitor_DuplicateMatchingRecord");
                this.SetRelatedEntities<DuplicateRecord>("Competitor_DuplicateMatchingRecord", null, value);
                this.OnPropertyChanged("Competitor_DuplicateMatchingRecord");
            }
        }

        /// <summary>
        /// 1:N competitor_opportunity_activities
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("competitor_opportunity_activities")]
        public System.Collections.Generic.IEnumerable<OpportunityClose> competitor_opportunity_activities
        {
            get { return this.GetRelatedEntities<OpportunityClose>("competitor_opportunity_activities", null); }
            set
            {
                this.OnPropertyChanging("competitor_opportunity_activities");
                this.SetRelatedEntities<OpportunityClose>("competitor_opportunity_activities", null, value);
                this.OnPropertyChanged("competitor_opportunity_activities");
            }
        }

        /// <summary>
        /// 1:N competitor_PostFollows
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("competitor_PostFollows")]
        public System.Collections.Generic.IEnumerable<PostFollow> competitor_PostFollows
        {
            get { return this.GetRelatedEntities<PostFollow>("competitor_PostFollows", null); }
            set
            {
                this.OnPropertyChanging("competitor_PostFollows");
                this.SetRelatedEntities<PostFollow>("competitor_PostFollows", null, value);
                this.OnPropertyChanged("competitor_PostFollows");
            }
        }

        /// <summary>
        /// 1:N competitor_principalobjectattributeaccess
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("competitor_principalobjectattributeaccess")]
        public System.Collections.Generic.IEnumerable<PrincipalObjectAttributeAccess> competitor_principalobjectattributeaccess
        {
            get { return this.GetRelatedEntities<PrincipalObjectAttributeAccess>("competitor_principalobjectattributeaccess", null); }
            set
            {
                this.OnPropertyChanging("competitor_principalobjectattributeaccess");
                this.SetRelatedEntities<PrincipalObjectAttributeAccess>("competitor_principalobjectattributeaccess", null, value);
                this.OnPropertyChanged("competitor_principalobjectattributeaccess");
            }
        }

        /// <summary>
        /// 1:N Competitor_ProcessSessions
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Competitor_ProcessSessions")]
        public System.Collections.Generic.IEnumerable<ProcessSession> Competitor_ProcessSessions
        {
            get { return this.GetRelatedEntities<ProcessSession>("Competitor_ProcessSessions", null); }
            set
            {
                this.OnPropertyChanging("Competitor_ProcessSessions");
                this.SetRelatedEntities<ProcessSession>("Competitor_ProcessSessions", null, value);
                this.OnPropertyChanged("Competitor_ProcessSessions");
            }
        }

        /// <summary>
        /// 1:N userentityinstancedata_competitor
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_competitor")]
        public System.Collections.Generic.IEnumerable<UserEntityInstanceData> userentityinstancedata_competitor
        {
            get { return this.GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_competitor", null); }
            set
            {
                this.OnPropertyChanging("userentityinstancedata_competitor");
                this.SetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_competitor", null, value);
                this.OnPropertyChanged("userentityinstancedata_competitor");
            }
        }

        /// <summary>
        /// N:N competitorproduct_association
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("competitorproduct_association")]
        public System.Collections.Generic.IEnumerable<Product> competitorproduct_association
        {
            get { return this.GetRelatedEntities<Product>("competitorproduct_association", null); }
            set
            {
                this.OnPropertyChanging("competitorproduct_association");
                this.SetRelatedEntities<Product>("competitorproduct_association", null, value);
                this.OnPropertyChanged("competitorproduct_association");
            }
        }

        /// <summary>
        /// N:N competitorsalesliterature_association
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("competitorsalesliterature_association")]
        public System.Collections.Generic.IEnumerable<SalesLiterature> competitorsalesliterature_association
        {
            get { return this.GetRelatedEntities<SalesLiterature>("competitorsalesliterature_association", null); }
            set
            {
                this.OnPropertyChanging("competitorsalesliterature_association");
                this.SetRelatedEntities<SalesLiterature>("competitorsalesliterature_association", null, value);
                this.OnPropertyChanged("competitorsalesliterature_association");
            }
        }

        /// <summary>
        /// N:N leadcompetitors_association
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("leadcompetitors_association")]
        public System.Collections.Generic.IEnumerable<Lead> leadcompetitors_association
        {
            get { return this.GetRelatedEntities<Lead>("leadcompetitors_association", null); }
            set
            {
                this.OnPropertyChanging("leadcompetitors_association");
                this.SetRelatedEntities<Lead>("leadcompetitors_association", null, value);
                this.OnPropertyChanged("leadcompetitors_association");
            }
        }

        /// <summary>
        /// N:N opportunitycompetitors_association
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("opportunitycompetitors_association")]
        public System.Collections.Generic.IEnumerable<Opportunity> opportunitycompetitors_association
        {
            get { return this.GetRelatedEntities<Opportunity>("opportunitycompetitors_association", null); }
            set
            {
                this.OnPropertyChanging("opportunitycompetitors_association");
                this.SetRelatedEntities<Opportunity>("opportunitycompetitors_association", null, value);
                this.OnPropertyChanged("opportunitycompetitors_association");
            }
        }

        /// <summary>
        /// N:1 lk_competitor_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_competitor_createdonbehalfby")]
        public SystemUser lk_competitor_createdonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_competitor_createdonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_competitor_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_competitor_modifiedonbehalfby")]
        public SystemUser lk_competitor_modifiedonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_competitor_modifiedonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_competitorbase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_competitorbase_createdby")]
        public SystemUser lk_competitorbase_createdby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_competitorbase_createdby", null); }
        }

        /// <summary>
        /// N:1 lk_competitorbase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_competitorbase_modifiedby")]
        public SystemUser lk_competitorbase_modifiedby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_competitorbase_modifiedby", null); }
        }

        /// <summary>
        /// N:1 organization_competitors
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_competitors")]
        public Organization organization_competitors
        {
            get { return this.GetRelatedEntity<Organization>("organization_competitors", null); }
        }

        /// <summary>
        /// N:1 processstage_competitors
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("stageid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("processstage_competitors")]
        public ProcessStage processstage_competitors
        {
            get { return this.GetRelatedEntity<ProcessStage>("processstage_competitors", null); }
            set
            {
                this.OnPropertyChanging("processstage_competitors");
                this.SetRelatedEntity<ProcessStage>("processstage_competitors", null, value);
                this.OnPropertyChanged("processstage_competitors");
            }
        }

        /// <summary>
        /// N:1 transactioncurrency_competitor
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("transactioncurrency_competitor")]
        public TransactionCurrency transactioncurrency_competitor
        {
            get { return this.GetRelatedEntity<TransactionCurrency>("transactioncurrency_competitor", null); }
            set
            {
                this.OnPropertyChanging("transactioncurrency_competitor");
                this.SetRelatedEntity<TransactionCurrency>("transactioncurrency_competitor", null, value);
                this.OnPropertyChanged("transactioncurrency_competitor");
            }
        }
    }
}