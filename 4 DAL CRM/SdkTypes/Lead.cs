using _4_DAL_CRM;

namespace __4_DAL_CRM
{
    /// <summary>
    /// Prospect or potential sales opportunity. Leads are converted into accounts, contacts, or opportunities when they are qualified. Otherwise, they are deleted or archived.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("lead")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class Lead : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public Lead() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "lead";

        public const int EntityTypeCode = 4;

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
        /// Unique identifier of the account with which the lead is associated.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("accountid")]
        public Microsoft.Xrm.Sdk.EntityReference AccountId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("accountid"); }
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
        /// Type the UPS zone of the secondary address to make sure shipping charges are calculated correctly and deliveries are made promptly, if shipped by UPS.
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
        /// Information about the budget amount of the lead's company or organization.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("budgetamount")]
        public Microsoft.Xrm.Sdk.Money BudgetAmount
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("budgetamount"); }
            set
            {
                this.OnPropertyChanging("BudgetAmount");
                this.SetAttributeValue("budgetamount", value);
                this.OnPropertyChanged("BudgetAmount");
            }
        }

        /// <summary>
        /// Base currency equivalent of the estimated budget of the lead.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("budgetamount_base")]
        public Microsoft.Xrm.Sdk.Money BudgetAmount_Base
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("budgetamount_base"); }
        }

        /// <summary>
        /// Information about the budget status of the lead's company or organization.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("budgetstatus")]
        public Microsoft.Xrm.Sdk.OptionSetValue BudgetStatus
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("budgetstatus"); }
            set
            {
                this.OnPropertyChanging("BudgetStatus");
                this.SetAttributeValue("budgetstatus", value);
                this.OnPropertyChanged("BudgetStatus");
            }
        }

        /// <summary>
        /// Choose the campaign that the lead was generated from to track the effectiveness of marketing campaigns and identify communications received by the lead.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("campaignid")]
        public Microsoft.Xrm.Sdk.EntityReference CampaignId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("campaignid"); }
            set
            {
                this.OnPropertyChanging("CampaignId");
                this.SetAttributeValue("campaignid", value);
                this.OnPropertyChanged("CampaignId");
            }
        }

        /// <summary>
        /// Type the name of the company associated with the lead. This becomes the account name when the lead is qualified and converted to a customer account.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("companyname")]
        public string CompanyName
        {
            get { return this.GetAttributeValue<string>("companyname"); }
            set
            {
                this.OnPropertyChanging("CompanyName");
                this.SetAttributeValue("companyname", value);
                this.OnPropertyChanged("CompanyName");
            }
        }

        /// <summary>
        /// Select whether the lead confirmed interest in your offerings. This helps in determining the lead quality.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("confirminterest")]
        public System.Nullable<bool> ConfirmInterest
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("confirminterest"); }
            set
            {
                this.OnPropertyChanging("ConfirmInterest");
                this.SetAttributeValue("confirminterest", value);
                this.OnPropertyChanged("ConfirmInterest");
            }
        }

        /// <summary>
        /// Unique identifier of the contact with which the lead is associated.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("contactid")]
        public Microsoft.Xrm.Sdk.EntityReference ContactId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("contactid"); }
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
        /// Select the customer account or contact to provide a quick link to additional customer details, such as account information, activities, and opportunities.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("customerid")]
        public Microsoft.Xrm.Sdk.EntityReference CustomerId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("customerid"); }
            set
            {
                this.OnPropertyChanging("CustomerId");
                this.SetAttributeValue("customerid", value);
                this.OnPropertyChanged("CustomerId");
            }
        }

        /// <summary>
        /// Select whether your notes include information about who makes the purchase decisions at the lead's company.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("decisionmaker")]
        public System.Nullable<bool> DecisionMaker
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("decisionmaker"); }
            set
            {
                this.OnPropertyChanging("DecisionMaker");
                this.SetAttributeValue("decisionmaker", value);
                this.OnPropertyChanged("DecisionMaker");
            }
        }

        /// <summary>
        /// Type additional information to describe the lead, such as an excerpt from the company's website.
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
        /// Select whether the lead accepts bulk email sent through marketing campaigns or quick campaigns. If Do Not Allow is selected, the lead can be added to marketing lists, but will be excluded from the email.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("donotbulkemail")]
        public System.Nullable<bool> DoNotBulkEMail
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("donotbulkemail"); }
            set
            {
                this.OnPropertyChanging("DoNotBulkEMail");
                this.SetAttributeValue("donotbulkemail", value);
                this.OnPropertyChanged("DoNotBulkEMail");
            }
        }

        /// <summary>
        /// Select whether the lead allows direct email sent from Microsoft Dynamics CRM.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("donotemail")]
        public System.Nullable<bool> DoNotEMail
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("donotemail"); }
            set
            {
                this.OnPropertyChanging("DoNotEMail");
                this.SetAttributeValue("donotemail", value);
                this.OnPropertyChanged("DoNotEMail");
            }
        }

        /// <summary>
        /// Select whether the lead allows faxes.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("donotfax")]
        public System.Nullable<bool> DoNotFax
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("donotfax"); }
            set
            {
                this.OnPropertyChanging("DoNotFax");
                this.SetAttributeValue("donotfax", value);
                this.OnPropertyChanged("DoNotFax");
            }
        }

        /// <summary>
        /// Select whether the lead allows phone calls.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("donotphone")]
        public System.Nullable<bool> DoNotPhone
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("donotphone"); }
            set
            {
                this.OnPropertyChanging("DoNotPhone");
                this.SetAttributeValue("donotphone", value);
                this.OnPropertyChanged("DoNotPhone");
            }
        }

        /// <summary>
        /// Select whether the lead allows direct mail.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("donotpostalmail")]
        public System.Nullable<bool> DoNotPostalMail
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("donotpostalmail"); }
            set
            {
                this.OnPropertyChanging("DoNotPostalMail");
                this.SetAttributeValue("donotpostalmail", value);
                this.OnPropertyChanged("DoNotPostalMail");
            }
        }

        /// <summary>
        /// Select whether the lead accepts marketing materials, such as brochures or catalogs. Leads that opt out can be excluded from marketing initiatives.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("donotsendmm")]
        public System.Nullable<bool> DoNotSendMM
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("donotsendmm"); }
            set
            {
                this.OnPropertyChanging("DoNotSendMM");
                this.SetAttributeValue("donotsendmm", value);
                this.OnPropertyChanged("DoNotSendMM");
            }
        }

        /// <summary>
        /// Type the primary email address for the lead.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("emailaddress1")]
        public string EMailAddress1
        {
            get { return this.GetAttributeValue<string>("emailaddress1"); }
            set
            {
                this.OnPropertyChanging("EMailAddress1");
                this.SetAttributeValue("emailaddress1", value);
                this.OnPropertyChanged("EMailAddress1");
            }
        }

        /// <summary>
        /// Type the secondary email address for the lead.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("emailaddress2")]
        public string EMailAddress2
        {
            get { return this.GetAttributeValue<string>("emailaddress2"); }
            set
            {
                this.OnPropertyChanging("EMailAddress2");
                this.SetAttributeValue("emailaddress2", value);
                this.OnPropertyChanged("EMailAddress2");
            }
        }

        /// <summary>
        /// Type a third email address for the lead.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("emailaddress3")]
        public string EMailAddress3
        {
            get { return this.GetAttributeValue<string>("emailaddress3"); }
            set
            {
                this.OnPropertyChanging("EMailAddress3");
                this.SetAttributeValue("emailaddress3", value);
                this.OnPropertyChanged("EMailAddress3");
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
        /// Type the estimated revenue value that this lead will generate to assist in sales forecasting and planning.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("estimatedamount")]
        public Microsoft.Xrm.Sdk.Money EstimatedAmount
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("estimatedamount"); }
            set
            {
                this.OnPropertyChanging("EstimatedAmount");
                this.SetAttributeValue("estimatedamount", value);
                this.OnPropertyChanged("EstimatedAmount");
            }
        }

        /// <summary>
        /// Shows the Est. Value field converted to the system's default base currency. The calculation uses the exchange rate specified in the Currencies area.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("estimatedamount_base")]
        public Microsoft.Xrm.Sdk.Money EstimatedAmount_Base
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("estimatedamount_base"); }
        }

        /// <summary>
        /// Enter the expected close date for the lead, so that the sales team can schedule timely follow-up meetings to move the prospect to the next sales stage.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("estimatedclosedate")]
        public System.Nullable<System.DateTime> EstimatedCloseDate
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("estimatedclosedate"); }
            set
            {
                this.OnPropertyChanging("EstimatedCloseDate");
                this.SetAttributeValue("estimatedclosedate", value);
                this.OnPropertyChanged("EstimatedCloseDate");
            }
        }

        /// <summary>
        /// Type a numeric value of the lead's estimated value, such as a product quantity, if no revenue amount can be specified in the Est. Value field. This can be used for sales forecasting and planning.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("estimatedvalue")]
        public System.Nullable<double> EstimatedValue
        {
            get { return this.GetAttributeValue<System.Nullable<double>>("estimatedvalue"); }
            set
            {
                this.OnPropertyChanging("EstimatedValue");
                this.SetAttributeValue("estimatedvalue", value);
                this.OnPropertyChanged("EstimatedValue");
            }
        }

        /// <summary>
        /// Select whether the fit between the lead's requirements and your offerings was evaluated.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("evaluatefit")]
        public System.Nullable<bool> EvaluateFit
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("evaluatefit"); }
            set
            {
                this.OnPropertyChanging("EvaluateFit");
                this.SetAttributeValue("evaluatefit", value);
                this.OnPropertyChanged("EvaluateFit");
            }
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
        /// Type the fax number for the primary contact for the lead.
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
        /// Type the first name of the primary contact for the lead to make sure the prospect is addressed correctly in sales calls, email, and marketing campaigns.
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
        /// Combines and shows the lead's first and last names so the full name can be displayed in views and reports.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("fullname")]
        public string FullName
        {
            get { return this.GetAttributeValue<string>("fullname"); }
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
        /// Select the primary industry in which the lead's business is focused, for use in marketing segmentation and demographic analysis.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("industrycode")]
        public Microsoft.Xrm.Sdk.OptionSetValue IndustryCode
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("industrycode"); }
            set
            {
                this.OnPropertyChanging("IndustryCode");
                this.SetAttributeValue("industrycode", value);
                this.OnPropertyChanged("IndustryCode");
            }
        }

        /// <summary>
        /// Choose whether someone from the sales team contacted this lead earlier.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("initialcommunication")]
        public Microsoft.Xrm.Sdk.OptionSetValue InitialCommunication
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("initialcommunication"); }
            set
            {
                this.OnPropertyChanging("InitialCommunication");
                this.SetAttributeValue("initialcommunication", value);
                this.OnPropertyChanged("InitialCommunication");
            }
        }

        /// <summary>
        /// Type the job title of the primary contact for this lead to make sure the prospect is addressed correctly in sales calls, email, and marketing campaigns.
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
        /// Type the last name of the primary contact for the lead to make sure the prospect is addressed correctly in sales calls, email, and marketing campaigns.
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
        /// Shows the date when the lead was last included in a marketing campaign or quick campaign.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("lastusedincampaign")]
        public System.Nullable<System.DateTime> LastUsedInCampaign
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("lastusedincampaign"); }
            set
            {
                this.OnPropertyChanging("LastUsedInCampaign");
                this.SetAttributeValue("lastusedincampaign", value);
                this.OnPropertyChanged("LastUsedInCampaign");
            }
        }

        /// <summary>
        /// Unique identifier of the lead.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("leadid")]
        public System.Nullable<System.Guid> LeadId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("leadid"); }
            set
            {
                this.OnPropertyChanging("LeadId");
                this.SetAttributeValue("leadid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("LeadId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("leadid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.LeadId = value; }
        }

        /// <summary>
        /// Select a rating value to indicate the lead's potential to become a customer.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("leadqualitycode")]
        public Microsoft.Xrm.Sdk.OptionSetValue LeadQualityCode
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("leadqualitycode"); }
            set
            {
                this.OnPropertyChanging("LeadQualityCode");
                this.SetAttributeValue("leadqualitycode", value);
                this.OnPropertyChanged("LeadQualityCode");
            }
        }

        /// <summary>
        /// Select the primary marketing source that prompted the lead to contact you.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("leadsourcecode")]
        public Microsoft.Xrm.Sdk.OptionSetValue LeadSourceCode
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("leadsourcecode"); }
            set
            {
                this.OnPropertyChanging("LeadSourceCode");
                this.SetAttributeValue("leadsourcecode", value);
                this.OnPropertyChanged("LeadSourceCode");
            }
        }

        /// <summary>
        /// Unique identifier of the master lead for merge.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("masterid")]
        public Microsoft.Xrm.Sdk.EntityReference MasterId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("masterid"); }
        }

        /// <summary>
        /// Tells whether the lead has been merged with another lead.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("merged")]
        public System.Nullable<bool> Merged
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("merged"); }
        }

        /// <summary>
        /// Type the middle name or initial of the primary contact for the lead to make sure the prospect is addressed correctly.
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
        /// Type the mobile phone number for the primary contact for the lead.
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
        /// Choose how high the level of need is for the lead's company.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("need")]
        public Microsoft.Xrm.Sdk.OptionSetValue Need
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("need"); }
            set
            {
                this.OnPropertyChanging("Need");
                this.SetAttributeValue("need", value);
                this.OnPropertyChanged("Need");
            }
        }

        /// <summary>
        /// Type the number of employees that work at the company associated with the lead, for use in marketing segmentation and demographic analysis.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("numberofemployees")]
        public System.Nullable<int> NumberOfEmployees
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("numberofemployees"); }
            set
            {
                this.OnPropertyChanging("NumberOfEmployees");
                this.SetAttributeValue("numberofemployees", value);
                this.OnPropertyChanged("NumberOfEmployees");
            }
        }

        /// <summary>
        /// This attribute is used for Sample Service Business Processes.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("originatingcaseid")]
        public Microsoft.Xrm.Sdk.EntityReference OriginatingCaseId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("originatingcaseid"); }
            set
            {
                this.OnPropertyChanging("OriginatingCaseId");
                this.SetAttributeValue("originatingcaseid", value);
                this.OnPropertyChanged("OriginatingCaseId");
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
        /// Enter the user or team who is assigned to manage the record. This field is updated every time the record is assigned to a different user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ownerid")]
        public Microsoft.Xrm.Sdk.EntityReference OwnerId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("ownerid"); }
            set
            {
                this.OnPropertyChanging("OwnerId");
                this.SetAttributeValue("ownerid", value);
                this.OnPropertyChanged("OwnerId");
            }
        }

        /// <summary>
        /// Unique identifier of the business unit that owns the lead.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
        public Microsoft.Xrm.Sdk.EntityReference OwningBusinessUnit
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningbusinessunit"); }
        }

        /// <summary>
        /// Unique identifier of the team who owns the lead.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
        public Microsoft.Xrm.Sdk.EntityReference OwningTeam
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningteam"); }
        }

        /// <summary>
        /// Unique identifier of the user who owns the lead.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
        public Microsoft.Xrm.Sdk.EntityReference OwningUser
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owninguser"); }
        }

        /// <summary>
        /// Type the pager number for the primary contact for the lead.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("pager")]
        public string Pager
        {
            get { return this.GetAttributeValue<string>("pager"); }
            set
            {
                this.OnPropertyChanging("Pager");
                this.SetAttributeValue("pager", value);
                this.OnPropertyChanged("Pager");
            }
        }

        /// <summary>
        /// Choose an account to connect this lead to, so that the relationship is visible in reports and analytics.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("parentaccountid")]
        public Microsoft.Xrm.Sdk.EntityReference ParentAccountId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("parentaccountid"); }
            set
            {
                this.OnPropertyChanging("ParentAccountId");
                this.SetAttributeValue("parentaccountid", value);
                this.OnPropertyChanged("ParentAccountId");
            }
        }

        /// <summary>
        /// Choose a contact to connect this lead to, so that the relationship is visible in reports and analytics.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("parentcontactid")]
        public Microsoft.Xrm.Sdk.EntityReference ParentContactId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("parentcontactid"); }
            set
            {
                this.OnPropertyChanging("ParentContactId");
                this.SetAttributeValue("parentcontactid", value);
                this.OnPropertyChanged("ParentContactId");
            }
        }

        /// <summary>
        /// Shows whether the lead participates in workflow rules.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("participatesinworkflow")]
        public System.Nullable<bool> ParticipatesInWorkflow
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("participatesinworkflow"); }
            set
            {
                this.OnPropertyChanging("ParticipatesInWorkflow");
                this.SetAttributeValue("participatesinworkflow", value);
                this.OnPropertyChanged("ParticipatesInWorkflow");
            }
        }

        /// <summary>
        /// Select the preferred method of contact.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("preferredcontactmethodcode")]
        public Microsoft.Xrm.Sdk.OptionSetValue PreferredContactMethodCode
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("preferredcontactmethodcode"); }
            set
            {
                this.OnPropertyChanging("PreferredContactMethodCode");
                this.SetAttributeValue("preferredcontactmethodcode", value);
                this.OnPropertyChanged("PreferredContactMethodCode");
            }
        }

        /// <summary>
        /// Select the priority so that preferred customers or critical issues are handled quickly.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("prioritycode")]
        public Microsoft.Xrm.Sdk.OptionSetValue PriorityCode
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("prioritycode"); }
            set
            {
                this.OnPropertyChanging("PriorityCode");
                this.SetAttributeValue("prioritycode", value);
                this.OnPropertyChanged("PriorityCode");
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
        /// Choose whether an individual or a committee will be involved in the purchase process for the lead.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("purchaseprocess")]
        public Microsoft.Xrm.Sdk.OptionSetValue PurchaseProcess
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("purchaseprocess"); }
            set
            {
                this.OnPropertyChanging("PurchaseProcess");
                this.SetAttributeValue("purchaseprocess", value);
                this.OnPropertyChanged("PurchaseProcess");
            }
        }

        /// <summary>
        /// Choose how long the lead will likely take to make the purchase, so the sales team will be aware.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("purchasetimeframe")]
        public Microsoft.Xrm.Sdk.OptionSetValue PurchaseTimeFrame
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("purchasetimeframe"); }
            set
            {
                this.OnPropertyChanging("PurchaseTimeFrame");
                this.SetAttributeValue("purchasetimeframe", value);
                this.OnPropertyChanged("PurchaseTimeFrame");
            }
        }

        /// <summary>
        /// Type comments about the qualification or scoring of the lead.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("qualificationcomments")]
        public string QualificationComments
        {
            get { return this.GetAttributeValue<string>("qualificationcomments"); }
            set
            {
                this.OnPropertyChanging("QualificationComments");
                this.SetAttributeValue("qualificationcomments", value);
                this.OnPropertyChanged("QualificationComments");
            }
        }

        /// <summary>
        /// Choose the opportunity that the lead was qualified on and then converted to.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("qualifyingopportunityid")]
        public Microsoft.Xrm.Sdk.EntityReference QualifyingOpportunityId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("qualifyingopportunityid"); }
            set
            {
                this.OnPropertyChanging("QualifyingOpportunityId");
                this.SetAttributeValue("qualifyingopportunityid", value);
                this.OnPropertyChanged("QualifyingOpportunityId");
            }
        }

        /// <summary>
        /// Related Campaign Response.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("relatedobjectid")]
        public Microsoft.Xrm.Sdk.EntityReference RelatedObjectId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("relatedobjectid"); }
            set
            {
                this.OnPropertyChanging("RelatedObjectId");
                this.SetAttributeValue("relatedobjectid", value);
                this.OnPropertyChanged("RelatedObjectId");
            }
        }

        /// <summary>
        /// Type the annual revenue of the company associated with the lead to provide an understanding of the prospect's business.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("revenue")]
        public Microsoft.Xrm.Sdk.Money Revenue
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("revenue"); }
            set
            {
                this.OnPropertyChanging("Revenue");
                this.SetAttributeValue("revenue", value);
                this.OnPropertyChanged("Revenue");
            }
        }

        /// <summary>
        /// Shows the Annual Revenue field converted to the system's default base currency. The calculation uses the exchange rate specified in the Currencies area.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("revenue_base")]
        public Microsoft.Xrm.Sdk.Money Revenue_Base
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("revenue_base"); }
        }

        /// <summary>
        /// Select the sales stage of this lead to aid the sales team in their efforts to convert this lead to an opportunity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("salesstage")]
        public Microsoft.Xrm.Sdk.OptionSetValue SalesStage
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("salesstage"); }
            set
            {
                this.OnPropertyChanging("SalesStage");
                this.SetAttributeValue("salesstage", value);
                this.OnPropertyChanged("SalesStage");
            }
        }

        /// <summary>
        /// Select the sales process stage for the lead to help determine the probability of the lead converting to an opportunity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("salesstagecode")]
        public Microsoft.Xrm.Sdk.OptionSetValue SalesStageCode
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("salesstagecode"); }
            set
            {
                this.OnPropertyChanging("SalesStageCode");
                this.SetAttributeValue("salesstagecode", value);
                this.OnPropertyChanged("SalesStageCode");
            }
        }

        /// <summary>
        /// Type the salutation of the primary contact for this lead to make sure the prospect is addressed correctly in sales calls, email messages, and marketing campaigns.
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
        /// Enter the date and time of the prospecting follow-up meeting with the lead.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("schedulefollowup_prospect")]
        public System.Nullable<System.DateTime> ScheduleFollowUp_Prospect
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("schedulefollowup_prospect"); }
            set
            {
                this.OnPropertyChanging("ScheduleFollowUp_Prospect");
                this.SetAttributeValue("schedulefollowup_prospect", value);
                this.OnPropertyChanged("ScheduleFollowUp_Prospect");
            }
        }

        /// <summary>
        /// Enter the date and time of the qualifying follow-up meeting with the lead.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("schedulefollowup_qualify")]
        public System.Nullable<System.DateTime> ScheduleFollowUp_Qualify
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("schedulefollowup_qualify"); }
            set
            {
                this.OnPropertyChanging("ScheduleFollowUp_Qualify");
                this.SetAttributeValue("schedulefollowup_qualify", value);
                this.OnPropertyChanged("ScheduleFollowUp_Qualify");
            }
        }

        /// <summary>
        /// Type the Standard Industrial Classification (SIC) code that indicates the lead's primary industry of business for use in marketing segmentation and demographic analysis.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sic")]
        public string SIC
        {
            get { return this.GetAttributeValue<string>("sic"); }
            set
            {
                this.OnPropertyChanging("SIC");
                this.SetAttributeValue("sic", value);
                this.OnPropertyChanged("SIC");
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
        /// Shows whether the lead is open, qualified, or disqualified. Qualified and disqualified leads are read-only and can't be edited unless they are reactivated.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
        public System.Nullable<LeadState> StateCode
        {
            get
            {
                Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
                if ((optionSet != null))
                {
                    return ((LeadState) (System.Enum.ToObject(typeof(LeadState), optionSet.Value)));
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// Select the lead's status.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statuscode")]
        public Microsoft.Xrm.Sdk.OptionSetValue StatusCode
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statuscode"); }
            set
            {
                this.OnPropertyChanging("StatusCode");
                this.SetAttributeValue("statuscode", value);
                this.OnPropertyChanged("StatusCode");
            }
        }

        /// <summary>
        /// Type a subject or descriptive name, such as the expected order, company name, or marketing source list, to identify the lead.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("subject")]
        public string Subject
        {
            get { return this.GetAttributeValue<string>("subject"); }
            set
            {
                this.OnPropertyChanging("Subject");
                this.SetAttributeValue("subject", value);
                this.OnPropertyChanged("Subject");
            }
        }

        /// <summary>
        /// Type the work phone number for the primary contact for the lead.
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
        /// Type the home phone number for the primary contact for the lead.
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
        /// Type an alternate phone number for the primary contact for the lead.
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
        /// Version number of the lead.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
        public System.Nullable<long> VersionNumber
        {
            get { return this.GetAttributeValue<System.Nullable<long>>("versionnumber"); }
        }

        /// <summary>
        /// Type the website URL for the company associated with this lead.
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
        /// Type the phonetic spelling of the lead's company name, if the name is specified in Japanese, to make sure the name is pronounced correctly in phone calls with the prospect.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("yomicompanyname")]
        public string YomiCompanyName
        {
            get { return this.GetAttributeValue<string>("yomicompanyname"); }
            set
            {
                this.OnPropertyChanging("YomiCompanyName");
                this.SetAttributeValue("yomicompanyname", value);
                this.OnPropertyChanged("YomiCompanyName");
            }
        }

        /// <summary>
        /// Type the phonetic spelling of the lead's first name, if the name is specified in Japanese, to make sure the name is pronounced correctly in phone calls with the prospect.
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
        /// Combines and shows the lead's Yomi first and last names so the full phonetic name can be displayed in views and reports.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("yomifullname")]
        public string YomiFullName
        {
            get { return this.GetAttributeValue<string>("yomifullname"); }
        }

        /// <summary>
        /// Type the phonetic spelling of the lead's last name, if the name is specified in Japanese, to make sure the name is pronounced correctly in phone calls with the prospect.
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
        /// Type the phonetic spelling of the lead's middle name, if the name is specified in Japanese, to make sure the name is pronounced correctly in phone calls with the prospect.
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
        /// 1:N account_originating_lead
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("account_originating_lead")]
        public System.Collections.Generic.IEnumerable<Account> account_originating_lead
        {
            get { return this.GetRelatedEntities<Account>("account_originating_lead", null); }
            set
            {
                this.OnPropertyChanging("account_originating_lead");
                this.SetRelatedEntities<Account>("account_originating_lead", null, value);
                this.OnPropertyChanged("account_originating_lead");
            }
        }

        /// <summary>
        /// 1:N contact_originating_lead
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("contact_originating_lead")]
        public System.Collections.Generic.IEnumerable<Contact> contact_originating_lead
        {
            get { return this.GetRelatedEntities<Contact>("contact_originating_lead", null); }
            set
            {
                this.OnPropertyChanging("contact_originating_lead");
                this.SetRelatedEntities<Contact>("contact_originating_lead", null, value);
                this.OnPropertyChanged("contact_originating_lead");
            }
        }

        /// <summary>
        /// 1:N CreatedLead_BulkOperationLogs
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("CreatedLead_BulkOperationLogs")]
        public System.Collections.Generic.IEnumerable<BulkOperationLog> CreatedLead_BulkOperationLogs
        {
            get { return this.GetRelatedEntities<BulkOperationLog>("CreatedLead_BulkOperationLogs", null); }
            set
            {
                this.OnPropertyChanging("CreatedLead_BulkOperationLogs");
                this.SetRelatedEntities<BulkOperationLog>("CreatedLead_BulkOperationLogs", null, value);
                this.OnPropertyChanged("CreatedLead_BulkOperationLogs");
            }
        }

        /// <summary>
        /// 1:N lead_activity_parties
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lead_activity_parties")]
        public System.Collections.Generic.IEnumerable<ActivityParty> lead_activity_parties
        {
            get { return this.GetRelatedEntities<ActivityParty>("lead_activity_parties", null); }
            set
            {
                this.OnPropertyChanging("lead_activity_parties");
                this.SetRelatedEntities<ActivityParty>("lead_activity_parties", null, value);
                this.OnPropertyChanged("lead_activity_parties");
            }
        }

        /// <summary>
        /// 1:N Lead_ActivityPointers
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Lead_ActivityPointers")]
        public System.Collections.Generic.IEnumerable<ActivityPointer> Lead_ActivityPointers
        {
            get { return this.GetRelatedEntities<ActivityPointer>("Lead_ActivityPointers", null); }
            set
            {
                this.OnPropertyChanging("Lead_ActivityPointers");
                this.SetRelatedEntities<ActivityPointer>("Lead_ActivityPointers", null, value);
                this.OnPropertyChanged("Lead_ActivityPointers");
            }
        }

        /// <summary>
        /// 1:N lead_addresses
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lead_addresses")]
        public System.Collections.Generic.IEnumerable<LeadAddress> lead_addresses
        {
            get { return this.GetRelatedEntities<LeadAddress>("lead_addresses", null); }
            set
            {
                this.OnPropertyChanging("lead_addresses");
                this.SetRelatedEntities<LeadAddress>("lead_addresses", null, value);
                this.OnPropertyChanged("lead_addresses");
            }
        }

        /// <summary>
        /// 1:N Lead_Annotation
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Lead_Annotation")]
        public System.Collections.Generic.IEnumerable<Annotation> Lead_Annotation
        {
            get { return this.GetRelatedEntities<Annotation>("Lead_Annotation", null); }
            set
            {
                this.OnPropertyChanging("Lead_Annotation");
                this.SetRelatedEntities<Annotation>("Lead_Annotation", null, value);
                this.OnPropertyChanged("Lead_Annotation");
            }
        }

        /// <summary>
        /// 1:N Lead_Appointments
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Lead_Appointments")]
        public System.Collections.Generic.IEnumerable<Appointment> Lead_Appointments
        {
            get { return this.GetRelatedEntities<Appointment>("Lead_Appointments", null); }
            set
            {
                this.OnPropertyChanging("Lead_Appointments");
                this.SetRelatedEntities<Appointment>("Lead_Appointments", null, value);
                this.OnPropertyChanged("Lead_Appointments");
            }
        }

        /// <summary>
        /// 1:N Lead_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Lead_AsyncOperations")]
        public System.Collections.Generic.IEnumerable<AsyncOperation> Lead_AsyncOperations
        {
            get { return this.GetRelatedEntities<AsyncOperation>("Lead_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("Lead_AsyncOperations");
                this.SetRelatedEntities<AsyncOperation>("Lead_AsyncOperations", null, value);
                this.OnPropertyChanged("Lead_AsyncOperations");
            }
        }

        /// <summary>
        /// 1:N Lead_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Lead_BulkDeleteFailures")]
        public System.Collections.Generic.IEnumerable<BulkDeleteFailure> Lead_BulkDeleteFailures
        {
            get { return this.GetRelatedEntities<BulkDeleteFailure>("Lead_BulkDeleteFailures", null); }
            set
            {
                this.OnPropertyChanging("Lead_BulkDeleteFailures");
                this.SetRelatedEntities<BulkDeleteFailure>("Lead_BulkDeleteFailures", null, value);
                this.OnPropertyChanged("Lead_BulkDeleteFailures");
            }
        }

        /// <summary>
        /// 1:N lead_connections1
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lead_connections1")]
        public System.Collections.Generic.IEnumerable<Connection> lead_connections1
        {
            get { return this.GetRelatedEntities<Connection>("lead_connections1", null); }
            set
            {
                this.OnPropertyChanging("lead_connections1");
                this.SetRelatedEntities<Connection>("lead_connections1", null, value);
                this.OnPropertyChanged("lead_connections1");
            }
        }

        /// <summary>
        /// 1:N lead_connections2
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lead_connections2")]
        public System.Collections.Generic.IEnumerable<Connection> lead_connections2
        {
            get { return this.GetRelatedEntities<Connection>("lead_connections2", null); }
            set
            {
                this.OnPropertyChanging("lead_connections2");
                this.SetRelatedEntities<Connection>("lead_connections2", null, value);
                this.OnPropertyChanged("lead_connections2");
            }
        }

        /// <summary>
        /// 1:N Lead_DuplicateBaseRecord
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Lead_DuplicateBaseRecord")]
        public System.Collections.Generic.IEnumerable<DuplicateRecord> Lead_DuplicateBaseRecord
        {
            get { return this.GetRelatedEntities<DuplicateRecord>("Lead_DuplicateBaseRecord", null); }
            set
            {
                this.OnPropertyChanging("Lead_DuplicateBaseRecord");
                this.SetRelatedEntities<DuplicateRecord>("Lead_DuplicateBaseRecord", null, value);
                this.OnPropertyChanged("Lead_DuplicateBaseRecord");
            }
        }

        /// <summary>
        /// 1:N Lead_DuplicateMatchingRecord
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Lead_DuplicateMatchingRecord")]
        public System.Collections.Generic.IEnumerable<DuplicateRecord> Lead_DuplicateMatchingRecord
        {
            get { return this.GetRelatedEntities<DuplicateRecord>("Lead_DuplicateMatchingRecord", null); }
            set
            {
                this.OnPropertyChanging("Lead_DuplicateMatchingRecord");
                this.SetRelatedEntities<DuplicateRecord>("Lead_DuplicateMatchingRecord", null, value);
                this.OnPropertyChanged("Lead_DuplicateMatchingRecord");
            }
        }

        /// <summary>
        /// 1:N Lead_Email_EmailSender
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Lead_Email_EmailSender")]
        public System.Collections.Generic.IEnumerable<Email> Lead_Email_EmailSender
        {
            get { return this.GetRelatedEntities<Email>("Lead_Email_EmailSender", null); }
            set
            {
                this.OnPropertyChanging("Lead_Email_EmailSender");
                this.SetRelatedEntities<Email>("Lead_Email_EmailSender", null, value);
                this.OnPropertyChanged("Lead_Email_EmailSender");
            }
        }

        /// <summary>
        /// 1:N Lead_Emails
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Lead_Emails")]
        public System.Collections.Generic.IEnumerable<Email> Lead_Emails
        {
            get { return this.GetRelatedEntities<Email>("Lead_Emails", null); }
            set
            {
                this.OnPropertyChanging("Lead_Emails");
                this.SetRelatedEntities<Email>("Lead_Emails", null, value);
                this.OnPropertyChanged("Lead_Emails");
            }
        }

        /// <summary>
        /// 1:N Lead_Faxes
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Lead_Faxes")]
        public System.Collections.Generic.IEnumerable<Fax> Lead_Faxes
        {
            get { return this.GetRelatedEntities<Fax>("Lead_Faxes", null); }
            set
            {
                this.OnPropertyChanging("Lead_Faxes");
                this.SetRelatedEntities<Fax>("Lead_Faxes", null, value);
                this.OnPropertyChanged("Lead_Faxes");
            }
        }

        /// <summary>
        /// 1:N Lead_Letters
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Lead_Letters")]
        public System.Collections.Generic.IEnumerable<Letter> Lead_Letters
        {
            get { return this.GetRelatedEntities<Letter>("Lead_Letters", null); }
            set
            {
                this.OnPropertyChanging("Lead_Letters");
                this.SetRelatedEntities<Letter>("Lead_Letters", null, value);
                this.OnPropertyChanged("Lead_Letters");
            }
        }

        /// <summary>
        /// 1:N lead_master_lead
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lead_master_lead", Microsoft.Xrm.Sdk.EntityRole.Referenced)]
        public System.Collections.Generic.IEnumerable<Lead> Referencedlead_master_lead
        {
            get { return this.GetRelatedEntities<Lead>("lead_master_lead", Microsoft.Xrm.Sdk.EntityRole.Referenced); }
            set
            {
                this.OnPropertyChanging("Referencedlead_master_lead");
                this.SetRelatedEntities<Lead>("lead_master_lead", Microsoft.Xrm.Sdk.EntityRole.Referenced, value);
                this.OnPropertyChanged("Referencedlead_master_lead");
            }
        }

        /// <summary>
        /// 1:N Lead_Phonecalls
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Lead_Phonecalls")]
        public System.Collections.Generic.IEnumerable<PhoneCall> Lead_Phonecalls
        {
            get { return this.GetRelatedEntities<PhoneCall>("Lead_Phonecalls", null); }
            set
            {
                this.OnPropertyChanging("Lead_Phonecalls");
                this.SetRelatedEntities<PhoneCall>("Lead_Phonecalls", null, value);
                this.OnPropertyChanged("Lead_Phonecalls");
            }
        }

        /// <summary>
        /// 1:N lead_PostFollows
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lead_PostFollows")]
        public System.Collections.Generic.IEnumerable<PostFollow> lead_PostFollows
        {
            get { return this.GetRelatedEntities<PostFollow>("lead_PostFollows", null); }
            set
            {
                this.OnPropertyChanging("lead_PostFollows");
                this.SetRelatedEntities<PostFollow>("lead_PostFollows", null, value);
                this.OnPropertyChanged("lead_PostFollows");
            }
        }

        /// <summary>
        /// 1:N lead_principalobjectattributeaccess
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lead_principalobjectattributeaccess")]
        public System.Collections.Generic.IEnumerable<PrincipalObjectAttributeAccess> lead_principalobjectattributeaccess
        {
            get { return this.GetRelatedEntities<PrincipalObjectAttributeAccess>("lead_principalobjectattributeaccess", null); }
            set
            {
                this.OnPropertyChanging("lead_principalobjectattributeaccess");
                this.SetRelatedEntities<PrincipalObjectAttributeAccess>("lead_principalobjectattributeaccess", null, value);
                this.OnPropertyChanged("lead_principalobjectattributeaccess");
            }
        }

        /// <summary>
        /// 1:N Lead_ProcessSessions
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Lead_ProcessSessions")]
        public System.Collections.Generic.IEnumerable<ProcessSession> Lead_ProcessSessions
        {
            get { return this.GetRelatedEntities<ProcessSession>("Lead_ProcessSessions", null); }
            set
            {
                this.OnPropertyChanging("Lead_ProcessSessions");
                this.SetRelatedEntities<ProcessSession>("Lead_ProcessSessions", null, value);
                this.OnPropertyChanged("Lead_ProcessSessions");
            }
        }

        /// <summary>
        /// 1:N Lead_RecurringAppointmentMasters
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Lead_RecurringAppointmentMasters")]
        public System.Collections.Generic.IEnumerable<RecurringAppointmentMaster> Lead_RecurringAppointmentMasters
        {
            get { return this.GetRelatedEntities<RecurringAppointmentMaster>("Lead_RecurringAppointmentMasters", null); }
            set
            {
                this.OnPropertyChanging("Lead_RecurringAppointmentMasters");
                this.SetRelatedEntities<RecurringAppointmentMaster>("Lead_RecurringAppointmentMasters", null, value);
                this.OnPropertyChanged("Lead_RecurringAppointmentMasters");
            }
        }

        /// <summary>
        /// 1:N Lead_ServiceAppointments
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Lead_ServiceAppointments")]
        public System.Collections.Generic.IEnumerable<ServiceAppointment> Lead_ServiceAppointments
        {
            get { return this.GetRelatedEntities<ServiceAppointment>("Lead_ServiceAppointments", null); }
            set
            {
                this.OnPropertyChanging("Lead_ServiceAppointments");
                this.SetRelatedEntities<ServiceAppointment>("Lead_ServiceAppointments", null, value);
                this.OnPropertyChanged("Lead_ServiceAppointments");
            }
        }

        /// <summary>
        /// 1:N Lead_SharepointDocument
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Lead_SharepointDocument")]
        public System.Collections.Generic.IEnumerable<SharePointDocument> Lead_SharepointDocument
        {
            get { return this.GetRelatedEntities<SharePointDocument>("Lead_SharepointDocument", null); }
            set
            {
                this.OnPropertyChanging("Lead_SharepointDocument");
                this.SetRelatedEntities<SharePointDocument>("Lead_SharepointDocument", null, value);
                this.OnPropertyChanged("Lead_SharepointDocument");
            }
        }

        /// <summary>
        /// 1:N Lead_SharepointDocumentLocation
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Lead_SharepointDocumentLocation")]
        public System.Collections.Generic.IEnumerable<SharePointDocumentLocation> Lead_SharepointDocumentLocation
        {
            get { return this.GetRelatedEntities<SharePointDocumentLocation>("Lead_SharepointDocumentLocation", null); }
            set
            {
                this.OnPropertyChanging("Lead_SharepointDocumentLocation");
                this.SetRelatedEntities<SharePointDocumentLocation>("Lead_SharepointDocumentLocation", null, value);
                this.OnPropertyChanged("Lead_SharepointDocumentLocation");
            }
        }

        /// <summary>
        /// 1:N Lead_SocialActivities
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Lead_SocialActivities")]
        public System.Collections.Generic.IEnumerable<SocialActivity> Lead_SocialActivities
        {
            get { return this.GetRelatedEntities<SocialActivity>("Lead_SocialActivities", null); }
            set
            {
                this.OnPropertyChanging("Lead_SocialActivities");
                this.SetRelatedEntities<SocialActivity>("Lead_SocialActivities", null, value);
                this.OnPropertyChanged("Lead_SocialActivities");
            }
        }

        /// <summary>
        /// 1:N Lead_Tasks
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Lead_Tasks")]
        public System.Collections.Generic.IEnumerable<Task> Lead_Tasks
        {
            get { return this.GetRelatedEntities<Task>("Lead_Tasks", null); }
            set
            {
                this.OnPropertyChanging("Lead_Tasks");
                this.SetRelatedEntities<Task>("Lead_Tasks", null, value);
                this.OnPropertyChanged("Lead_Tasks");
            }
        }

        /// <summary>
        /// 1:N opportunity_originating_lead
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("opportunity_originating_lead")]
        public System.Collections.Generic.IEnumerable<Opportunity> opportunity_originating_lead
        {
            get { return this.GetRelatedEntities<Opportunity>("opportunity_originating_lead", null); }
            set
            {
                this.OnPropertyChanging("opportunity_originating_lead");
                this.SetRelatedEntities<Opportunity>("opportunity_originating_lead", null, value);
                this.OnPropertyChanged("opportunity_originating_lead");
            }
        }

        /// <summary>
        /// 1:N SourceLead_BulkOperationLogs
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SourceLead_BulkOperationLogs")]
        public System.Collections.Generic.IEnumerable<BulkOperationLog> SourceLead_BulkOperationLogs
        {
            get { return this.GetRelatedEntities<BulkOperationLog>("SourceLead_BulkOperationLogs", null); }
            set
            {
                this.OnPropertyChanging("SourceLead_BulkOperationLogs");
                this.SetRelatedEntities<BulkOperationLog>("SourceLead_BulkOperationLogs", null, value);
                this.OnPropertyChanged("SourceLead_BulkOperationLogs");
            }
        }

        /// <summary>
        /// 1:N userentityinstancedata_lead
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_lead")]
        public System.Collections.Generic.IEnumerable<UserEntityInstanceData> userentityinstancedata_lead
        {
            get { return this.GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_lead", null); }
            set
            {
                this.OnPropertyChanging("userentityinstancedata_lead");
                this.SetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_lead", null, value);
                this.OnPropertyChanged("userentityinstancedata_lead");
            }
        }

        /// <summary>
        /// N:N accountleads_association
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("accountleads_association")]
        public System.Collections.Generic.IEnumerable<Account> accountleads_association
        {
            get { return this.GetRelatedEntities<Account>("accountleads_association", null); }
            set
            {
                this.OnPropertyChanging("accountleads_association");
                this.SetRelatedEntities<Account>("accountleads_association", null, value);
                this.OnPropertyChanged("accountleads_association");
            }
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

        /// <summary>
        /// N:N leadcompetitors_association
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("leadcompetitors_association")]
        public System.Collections.Generic.IEnumerable<Competitor> leadcompetitors_association
        {
            get { return this.GetRelatedEntities<Competitor>("leadcompetitors_association", null); }
            set
            {
                this.OnPropertyChanging("leadcompetitors_association");
                this.SetRelatedEntities<Competitor>("leadcompetitors_association", null, value);
                this.OnPropertyChanged("leadcompetitors_association");
            }
        }

        /// <summary>
        /// N:N leadproduct_association
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("leadproduct_association")]
        public System.Collections.Generic.IEnumerable<Product> leadproduct_association
        {
            get { return this.GetRelatedEntities<Product>("leadproduct_association", null); }
            set
            {
                this.OnPropertyChanging("leadproduct_association");
                this.SetRelatedEntities<Product>("leadproduct_association", null, value);
                this.OnPropertyChanged("leadproduct_association");
            }
        }

        /// <summary>
        /// N:N listlead_association
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("listlead_association")]
        public System.Collections.Generic.IEnumerable<List> listlead_association
        {
            get { return this.GetRelatedEntities<List>("listlead_association", null); }
            set
            {
                this.OnPropertyChanging("listlead_association");
                this.SetRelatedEntities<List>("listlead_association", null, value);
                this.OnPropertyChanged("listlead_association");
            }
        }

        /// <summary>
        /// N:1 business_unit_leads
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_leads")]
        public BusinessUnit business_unit_leads
        {
            get { return this.GetRelatedEntity<BusinessUnit>("business_unit_leads", null); }
        }

        /// <summary>
        /// N:1 campaign_leads
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("campaignid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("campaign_leads")]
        public Campaign campaign_leads
        {
            get { return this.GetRelatedEntity<Campaign>("campaign_leads", null); }
            set
            {
                this.OnPropertyChanging("campaign_leads");
                this.SetRelatedEntity<Campaign>("campaign_leads", null, value);
                this.OnPropertyChanged("campaign_leads");
            }
        }

        /// <summary>
        /// N:1 CampaignResponse_Lead
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("relatedobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("CampaignResponse_Lead")]
        public CampaignResponse CampaignResponse_Lead
        {
            get { return this.GetRelatedEntity<CampaignResponse>("CampaignResponse_Lead", null); }
            set
            {
                this.OnPropertyChanging("CampaignResponse_Lead");
                this.SetRelatedEntity<CampaignResponse>("CampaignResponse_Lead", null, value);
                this.OnPropertyChanged("CampaignResponse_Lead");
            }
        }

        /// <summary>
        /// N:1 lead_customer_accounts
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("customerid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lead_customer_accounts")]
        public Account lead_customer_accounts
        {
            get { return this.GetRelatedEntity<Account>("lead_customer_accounts", null); }
            set
            {
                this.OnPropertyChanging("lead_customer_accounts");
                this.SetRelatedEntity<Account>("lead_customer_accounts", null, value);
                this.OnPropertyChanged("lead_customer_accounts");
            }
        }

        /// <summary>
        /// N:1 lead_customer_contacts
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("customerid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lead_customer_contacts")]
        public Contact lead_customer_contacts
        {
            get { return this.GetRelatedEntity<Contact>("lead_customer_contacts", null); }
            set
            {
                this.OnPropertyChanging("lead_customer_contacts");
                this.SetRelatedEntity<Contact>("lead_customer_contacts", null, value);
                this.OnPropertyChanged("lead_customer_contacts");
            }
        }

        /// <summary>
        /// N:1 lead_master_lead
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("masterid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lead_master_lead", Microsoft.Xrm.Sdk.EntityRole.Referencing)]
        public Lead Referencinglead_master_lead
        {
            get { return this.GetRelatedEntity<Lead>("lead_master_lead", Microsoft.Xrm.Sdk.EntityRole.Referencing); }
        }

        /// <summary>
        /// N:1 lead_owning_team
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lead_owning_team")]
        public Team lead_owning_team
        {
            get { return this.GetRelatedEntity<Team>("lead_owning_team", null); }
        }

        /// <summary>
        /// N:1 lead_owning_user
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lead_owning_user")]
        public SystemUser lead_owning_user
        {
            get { return this.GetRelatedEntity<SystemUser>("lead_owning_user", null); }
        }

        /// <summary>
        /// N:1 lead_parent_account
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("parentaccountid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lead_parent_account")]
        public Account lead_parent_account
        {
            get { return this.GetRelatedEntity<Account>("lead_parent_account", null); }
            set
            {
                this.OnPropertyChanging("lead_parent_account");
                this.SetRelatedEntity<Account>("lead_parent_account", null, value);
                this.OnPropertyChanged("lead_parent_account");
            }
        }

        /// <summary>
        /// N:1 lead_parent_contact
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("parentcontactid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lead_parent_contact")]
        public Contact lead_parent_contact
        {
            get { return this.GetRelatedEntity<Contact>("lead_parent_contact", null); }
            set
            {
                this.OnPropertyChanging("lead_parent_contact");
                this.SetRelatedEntity<Contact>("lead_parent_contact", null, value);
                this.OnPropertyChanged("lead_parent_contact");
            }
        }

        /// <summary>
        /// N:1 lead_qualifying_opportunity
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("qualifyingopportunityid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lead_qualifying_opportunity")]
        public Opportunity lead_qualifying_opportunity
        {
            get { return this.GetRelatedEntity<Opportunity>("lead_qualifying_opportunity", null); }
            set
            {
                this.OnPropertyChanging("lead_qualifying_opportunity");
                this.SetRelatedEntity<Opportunity>("lead_qualifying_opportunity", null, value);
                this.OnPropertyChanged("lead_qualifying_opportunity");
            }
        }

        /// <summary>
        /// N:1 lk_lead_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_lead_createdonbehalfby")]
        public SystemUser lk_lead_createdonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_lead_createdonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_lead_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_lead_modifiedonbehalfby")]
        public SystemUser lk_lead_modifiedonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_lead_modifiedonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_leadbase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_leadbase_createdby")]
        public SystemUser lk_leadbase_createdby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_leadbase_createdby", null); }
        }

        /// <summary>
        /// N:1 lk_leadbase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_leadbase_modifiedby")]
        public SystemUser lk_leadbase_modifiedby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_leadbase_modifiedby", null); }
        }

        /// <summary>
        /// N:1 OriginatingCase_Lead
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("originatingcaseid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("OriginatingCase_Lead")]
        public Incident OriginatingCase_Lead
        {
            get { return this.GetRelatedEntity<Incident>("OriginatingCase_Lead", null); }
            set
            {
                this.OnPropertyChanging("OriginatingCase_Lead");
                this.SetRelatedEntity<Incident>("OriginatingCase_Lead", null, value);
                this.OnPropertyChanged("OriginatingCase_Lead");
            }
        }

        /// <summary>
        /// N:1 processstage_lead
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("stageid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("processstage_lead")]
        public ProcessStage processstage_lead
        {
            get { return this.GetRelatedEntity<ProcessStage>("processstage_lead", null); }
            set
            {
                this.OnPropertyChanging("processstage_lead");
                this.SetRelatedEntity<ProcessStage>("processstage_lead", null, value);
                this.OnPropertyChanged("processstage_lead");
            }
        }

        /// <summary>
        /// N:1 transactioncurrency_lead
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("transactioncurrency_lead")]
        public TransactionCurrency transactioncurrency_lead
        {
            get { return this.GetRelatedEntity<TransactionCurrency>("transactioncurrency_lead", null); }
            set
            {
                this.OnPropertyChanging("transactioncurrency_lead");
                this.SetRelatedEntity<TransactionCurrency>("transactioncurrency_lead", null, value);
                this.OnPropertyChanged("transactioncurrency_lead");
            }
        }
    }
}