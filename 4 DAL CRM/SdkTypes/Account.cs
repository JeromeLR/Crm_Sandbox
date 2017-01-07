using System;
using __4_DAL_CRM;
using Microsoft.Xrm.Sdk;
using TestCRM.SDK;

// ReSharper disable once CheckNamespace
namespace _4_DAL_CRM
{
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("account")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class Account : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public Account() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "account";

        public const int EntityTypeCode = 1;

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;

        private void OnPropertyChanged(string propertyName)
        {
            if ((PropertyChanged != null))
            {
                PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
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
        /// Select a category to indicate whether the customer account is standard or preferred.
        /// </summary>
        [AttributeLogicalName("accountcategorycode")]
        public Microsoft.Xrm.Sdk.OptionSetValue AccountCategoryCode
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("accountcategorycode");
            }
            set
            {
                this.OnPropertyChanging("AccountCategoryCode");
                this.SetAttributeValue("accountcategorycode", value);
                this.OnPropertyChanged("AccountCategoryCode");
            }
        }

        /// <summary>
        /// Select a classification code to indicate the potential value of the customer account based on the projected return on investment, cooperation level, sales cycle length or other criteria.
        /// </summary>
        [AttributeLogicalName("accountclassificationcode")]
        public Microsoft.Xrm.Sdk.OptionSetValue AccountClassificationCode
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("accountclassificationcode");
            }
            set
            {
                this.OnPropertyChanging("AccountClassificationCode");
                this.SetAttributeValue("accountclassificationcode", value);
                this.OnPropertyChanged("AccountClassificationCode");
            }
        }

        /// <summary>
        /// Unique identifier of the account.
        /// </summary>
        [AttributeLogicalName("accountid")]
        public System.Nullable<System.Guid> AccountId
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<System.Guid>>("accountid");
            }
            set
            {
                this.OnPropertyChanging("AccountId");
                this.SetAttributeValue("accountid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("AccountId");
            }
        }

        [AttributeLogicalName("accountid")]
        public override System.Guid Id
        {
            get
            {
                return base.Id;
            }
            set
            {
                this.AccountId = value;
            }
        }

        /// <summary>
        /// Type an ID number or code for the account to quickly search and identify the account in system views.
        /// </summary>
        [AttributeLogicalName("accountnumber")]
        public string AccountNumber
        {
            get
            {
                return this.GetAttributeValue<string>("accountnumber");
            }
            set
            {
                this.OnPropertyChanging("AccountNumber");
                this.SetAttributeValue("accountnumber", value);
                this.OnPropertyChanged("AccountNumber");
            }
        }

        /// <summary>
        /// Select a rating to indicate the value of the customer account.
        /// </summary>
        [AttributeLogicalName("accountratingcode")]
        public Microsoft.Xrm.Sdk.OptionSetValue AccountRatingCode
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("accountratingcode");
            }
            set
            {
                this.OnPropertyChanging("AccountRatingCode");
                this.SetAttributeValue("accountratingcode", value);
                this.OnPropertyChanged("AccountRatingCode");
            }
        }

        /// <summary>
        /// Unique identifier for address 1.
        /// </summary>
        [AttributeLogicalName("address1_addressid")]
        public System.Nullable<System.Guid> Address1_AddressId
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<System.Guid>>("address1_addressid");
            }
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
        [AttributeLogicalName("address1_addresstypecode")]
        public Microsoft.Xrm.Sdk.OptionSetValue Address1_AddressTypeCode
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("address1_addresstypecode");
            }
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
        [AttributeLogicalName("address1_city")]
        public string Address1_City
        {
            get
            {
                return this.GetAttributeValue<string>("address1_city");
            }
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
        [AttributeLogicalName("address1_composite")]
        public string Address1_Composite
        {
            get
            {
                return this.GetAttributeValue<string>("address1_composite");
            }
        }

        /// <summary>
        /// Type the country or region for the primary address.
        /// </summary>
        [AttributeLogicalName("address1_country")]
        public string Address1_Country
        {
            get
            {
                return this.GetAttributeValue<string>("address1_country");
            }
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
        [AttributeLogicalName("address1_county")]
        public string Address1_County
        {
            get
            {
                return this.GetAttributeValue<string>("address1_county");
            }
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
        [AttributeLogicalName("address1_fax")]
        public string Address1_Fax
        {
            get
            {
                return this.GetAttributeValue<string>("address1_fax");
            }
            set
            {
                this.OnPropertyChanging("Address1_Fax");
                this.SetAttributeValue("address1_fax", value);
                this.OnPropertyChanged("Address1_Fax");
            }
        }

        /// <summary>
        /// Select the freight terms for the primary address to make sure shipping orders are processed correctly.
        /// </summary>
        [AttributeLogicalName("address1_freighttermscode")]
        public Microsoft.Xrm.Sdk.OptionSetValue Address1_FreightTermsCode
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("address1_freighttermscode");
            }
            set
            {
                this.OnPropertyChanging("Address1_FreightTermsCode");
                this.SetAttributeValue("address1_freighttermscode", value);
                this.OnPropertyChanged("Address1_FreightTermsCode");
            }
        }

        /// <summary>
        /// Type the latitude value for the primary address for use in mapping and other applications.
        /// </summary>
        [AttributeLogicalName("address1_latitude")]
        public System.Nullable<double> Address1_Latitude
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<double>>("address1_latitude");
            }
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
        [AttributeLogicalName("address1_line1")]
        public string Address1_Line1
        {
            get
            {
                return this.GetAttributeValue<string>("address1_line1");
            }
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
        [AttributeLogicalName("address1_line2")]
        public string Address1_Line2
        {
            get
            {
                return this.GetAttributeValue<string>("address1_line2");
            }
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
        [AttributeLogicalName("address1_line3")]
        public string Address1_Line3
        {
            get
            {
                return this.GetAttributeValue<string>("address1_line3");
            }
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
        [AttributeLogicalName("address1_longitude")]
        public System.Nullable<double> Address1_Longitude
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<double>>("address1_longitude");
            }
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
        [AttributeLogicalName("address1_name")]
        public string Address1_Name
        {
            get
            {
                return this.GetAttributeValue<string>("address1_name");
            }
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
        [AttributeLogicalName("address1_postalcode")]
        public string Address1_PostalCode
        {
            get
            {
                return this.GetAttributeValue<string>("address1_postalcode");
            }
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
        [AttributeLogicalName("address1_postofficebox")]
        public string Address1_PostOfficeBox
        {
            get
            {
                return this.GetAttributeValue<string>("address1_postofficebox");
            }
            set
            {
                this.OnPropertyChanging("Address1_PostOfficeBox");
                this.SetAttributeValue("address1_postofficebox", value);
                this.OnPropertyChanged("Address1_PostOfficeBox");
            }
        }

        /// <summary>
        /// Type the name of the main contact at the account's primary address.
        /// </summary>
        [AttributeLogicalName("address1_primarycontactname")]
        public string Address1_PrimaryContactName
        {
            get
            {
                return this.GetAttributeValue<string>("address1_primarycontactname");
            }
            set
            {
                this.OnPropertyChanging("Address1_PrimaryContactName");
                this.SetAttributeValue("address1_primarycontactname", value);
                this.OnPropertyChanged("Address1_PrimaryContactName");
            }
        }

        /// <summary>
        /// Select a shipping method for deliveries sent to this address.
        /// </summary>
        [AttributeLogicalName("address1_shippingmethodcode")]
        public Microsoft.Xrm.Sdk.OptionSetValue Address1_ShippingMethodCode
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("address1_shippingmethodcode");
            }
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
        [AttributeLogicalName("address1_stateorprovince")]
        public string Address1_StateOrProvince
        {
            get
            {
                return this.GetAttributeValue<string>("address1_stateorprovince");
            }
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
        [AttributeLogicalName("address1_telephone1")]
        public string Address1_Telephone1
        {
            get
            {
                return this.GetAttributeValue<string>("address1_telephone1");
            }
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
        [AttributeLogicalName("address1_telephone2")]
        public string Address1_Telephone2
        {
            get
            {
                return this.GetAttributeValue<string>("address1_telephone2");
            }
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
        [AttributeLogicalName("address1_telephone3")]
        public string Address1_Telephone3
        {
            get
            {
                return this.GetAttributeValue<string>("address1_telephone3");
            }
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
        [AttributeLogicalName("address1_upszone")]
        public string Address1_UPSZone
        {
            get
            {
                return this.GetAttributeValue<string>("address1_upszone");
            }
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
        [AttributeLogicalName("address1_utcoffset")]
        public System.Nullable<int> Address1_UTCOffset
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("address1_utcoffset");
            }
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
        [AttributeLogicalName("address2_addressid")]
        public System.Nullable<System.Guid> Address2_AddressId
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<System.Guid>>("address2_addressid");
            }
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
        [AttributeLogicalName("address2_addresstypecode")]
        public Microsoft.Xrm.Sdk.OptionSetValue Address2_AddressTypeCode
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("address2_addresstypecode");
            }
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
        [AttributeLogicalName("address2_city")]
        public string Address2_City
        {
            get
            {
                return this.GetAttributeValue<string>("address2_city");
            }
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
        [AttributeLogicalName("address2_composite")]
        public string Address2_Composite
        {
            get
            {
                return this.GetAttributeValue<string>("address2_composite");
            }
        }

        /// <summary>
        /// Type the country or region for the secondary address.
        /// </summary>
        [AttributeLogicalName("address2_country")]
        public string Address2_Country
        {
            get
            {
                return this.GetAttributeValue<string>("address2_country");
            }
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
        [AttributeLogicalName("address2_county")]
        public string Address2_County
        {
            get
            {
                return this.GetAttributeValue<string>("address2_county");
            }
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
        [AttributeLogicalName("address2_fax")]
        public string Address2_Fax
        {
            get
            {
                return this.GetAttributeValue<string>("address2_fax");
            }
            set
            {
                this.OnPropertyChanging("Address2_Fax");
                this.SetAttributeValue("address2_fax", value);
                this.OnPropertyChanged("Address2_Fax");
            }
        }

        /// <summary>
        /// Select the freight terms for the secondary address to make sure shipping orders are processed correctly.
        /// </summary>
        [AttributeLogicalName("address2_freighttermscode")]
        public Microsoft.Xrm.Sdk.OptionSetValue Address2_FreightTermsCode
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("address2_freighttermscode");
            }
            set
            {
                this.OnPropertyChanging("Address2_FreightTermsCode");
                this.SetAttributeValue("address2_freighttermscode", value);
                this.OnPropertyChanged("Address2_FreightTermsCode");
            }
        }

        /// <summary>
        /// Type the latitude value for the secondary address for use in mapping and other applications.
        /// </summary>
        [AttributeLogicalName("address2_latitude")]
        public System.Nullable<double> Address2_Latitude
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<double>>("address2_latitude");
            }
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
        [AttributeLogicalName("address2_line1")]
        public string Address2_Line1
        {
            get
            {
                return this.GetAttributeValue<string>("address2_line1");
            }
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
        [AttributeLogicalName("address2_line2")]
        public string Address2_Line2
        {
            get
            {
                return this.GetAttributeValue<string>("address2_line2");
            }
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
        [AttributeLogicalName("address2_line3")]
        public string Address2_Line3
        {
            get
            {
                return this.GetAttributeValue<string>("address2_line3");
            }
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
        [AttributeLogicalName("address2_longitude")]
        public System.Nullable<double> Address2_Longitude
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<double>>("address2_longitude");
            }
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
        [AttributeLogicalName("address2_name")]
        public string Address2_Name
        {
            get
            {
                return this.GetAttributeValue<string>("address2_name");
            }
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
        [AttributeLogicalName("address2_postalcode")]
        public string Address2_PostalCode
        {
            get
            {
                return this.GetAttributeValue<string>("address2_postalcode");
            }
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
        [AttributeLogicalName("address2_postofficebox")]
        public string Address2_PostOfficeBox
        {
            get
            {
                return this.GetAttributeValue<string>("address2_postofficebox");
            }
            set
            {
                this.OnPropertyChanging("Address2_PostOfficeBox");
                this.SetAttributeValue("address2_postofficebox", value);
                this.OnPropertyChanged("Address2_PostOfficeBox");
            }
        }

        /// <summary>
        /// Type the name of the main contact at the account's secondary address.
        /// </summary>
        [AttributeLogicalName("address2_primarycontactname")]
        public string Address2_PrimaryContactName
        {
            get
            {
                return this.GetAttributeValue<string>("address2_primarycontactname");
            }
            set
            {
                this.OnPropertyChanging("Address2_PrimaryContactName");
                this.SetAttributeValue("address2_primarycontactname", value);
                this.OnPropertyChanged("Address2_PrimaryContactName");
            }
        }

        /// <summary>
        /// Select a shipping method for deliveries sent to this address.
        /// </summary>
        [AttributeLogicalName("address2_shippingmethodcode")]
        public Microsoft.Xrm.Sdk.OptionSetValue Address2_ShippingMethodCode
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("address2_shippingmethodcode");
            }
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
        [AttributeLogicalName("address2_stateorprovince")]
        public string Address2_StateOrProvince
        {
            get
            {
                return this.GetAttributeValue<string>("address2_stateorprovince");
            }
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
        [AttributeLogicalName("address2_telephone1")]
        public string Address2_Telephone1
        {
            get
            {
                return this.GetAttributeValue<string>("address2_telephone1");
            }
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
        [AttributeLogicalName("address2_telephone2")]
        public string Address2_Telephone2
        {
            get
            {
                return this.GetAttributeValue<string>("address2_telephone2");
            }
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
        [AttributeLogicalName("address2_telephone3")]
        public string Address2_Telephone3
        {
            get
            {
                return this.GetAttributeValue<string>("address2_telephone3");
            }
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
        [AttributeLogicalName("address2_upszone")]
        public string Address2_UPSZone
        {
            get
            {
                return this.GetAttributeValue<string>("address2_upszone");
            }
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
        [AttributeLogicalName("address2_utcoffset")]
        public System.Nullable<int> Address2_UTCOffset
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("address2_utcoffset");
            }
            set
            {
                this.OnPropertyChanging("Address2_UTCOffset");
                this.SetAttributeValue("address2_utcoffset", value);
                this.OnPropertyChanged("Address2_UTCOffset");
            }
        }

        /// <summary>
        /// For system use only.
        /// </summary>
        [AttributeLogicalName("aging30")]
        public Microsoft.Xrm.Sdk.Money Aging30
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("aging30");
            }
        }

        /// <summary>
        /// The base currency equivalent of the aging 30 field.
        /// </summary>
        [AttributeLogicalName("aging30_base")]
        public Microsoft.Xrm.Sdk.Money Aging30_Base
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("aging30_base");
            }
        }

        /// <summary>
        /// For system use only.
        /// </summary>
        [AttributeLogicalName("aging60")]
        public Microsoft.Xrm.Sdk.Money Aging60
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("aging60");
            }
        }

        /// <summary>
        /// The base currency equivalent of the aging 60 field.
        /// </summary>
        [AttributeLogicalName("aging60_base")]
        public Microsoft.Xrm.Sdk.Money Aging60_Base
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("aging60_base");
            }
        }

        /// <summary>
        /// For system use only.
        /// </summary>
        [AttributeLogicalName("aging90")]
        public Microsoft.Xrm.Sdk.Money Aging90
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("aging90");
            }
        }

        /// <summary>
        /// The base currency equivalent of the aging 90 field.
        /// </summary>
        [AttributeLogicalName("aging90_base")]
        public Microsoft.Xrm.Sdk.Money Aging90_Base
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("aging90_base");
            }
        }

        /// <summary>
        /// Select the legal designation or other business type of the account for contracts or reporting purposes.
        /// </summary>
        [AttributeLogicalName("businesstypecode")]
        public Microsoft.Xrm.Sdk.OptionSetValue BusinessTypeCode
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("businesstypecode");
            }
            set
            {
                this.OnPropertyChanging("BusinessTypeCode");
                this.SetAttributeValue("businesstypecode", value);
                this.OnPropertyChanged("BusinessTypeCode");
            }
        }

        /// <summary>
        /// Shows who created the record.
        /// </summary>
        [AttributeLogicalName("createdby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedBy
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby");
            }
        }

        /// <summary>
        /// Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics CRM options.
        /// </summary>
        [AttributeLogicalName("createdon")]
        public System.Nullable<System.DateTime> CreatedOn
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon");
            }
        }

        /// <summary>
        /// Shows who created the record on behalf of another user.
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby");
            }
        }

        /// <summary>
        /// Type the credit limit of the account. This is a useful reference when you address invoice and accounting issues with the customer.
        /// </summary>
        [AttributeLogicalName("creditlimit")]
        public Microsoft.Xrm.Sdk.Money CreditLimit
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("creditlimit");
            }
            set
            {
                this.OnPropertyChanging("CreditLimit");
                this.SetAttributeValue("creditlimit", value);
                this.OnPropertyChanged("CreditLimit");
            }
        }

        /// <summary>
        /// Shows the credit limit converted to the system's default base currency for reporting purposes.
        /// </summary>
        [AttributeLogicalName("creditlimit_base")]
        public Microsoft.Xrm.Sdk.Money CreditLimit_Base
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("creditlimit_base");
            }
        }

        /// <summary>
        /// Select whether the credit for the account is on hold. This is a useful reference while addressing the invoice and accounting issues with the customer.
        /// </summary>
        [AttributeLogicalName("creditonhold")]
        public System.Nullable<bool> CreditOnHold
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("creditonhold");
            }
            set
            {
                this.OnPropertyChanging("CreditOnHold");
                this.SetAttributeValue("creditonhold", value);
                this.OnPropertyChanged("CreditOnHold");
            }
        }

        /// <summary>
        /// Select the size category or range of the account for segmentation and reporting purposes.
        /// </summary>
        [AttributeLogicalName("customersizecode")]
        public Microsoft.Xrm.Sdk.OptionSetValue CustomerSizeCode
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("customersizecode");
            }
            set
            {
                this.OnPropertyChanging("CustomerSizeCode");
                this.SetAttributeValue("customersizecode", value);
                this.OnPropertyChanged("CustomerSizeCode");
            }
        }

        /// <summary>
        /// Select the category that best describes the relationship between the account and your organization.
        /// </summary>
        [AttributeLogicalName("customertypecode")]
        public Microsoft.Xrm.Sdk.OptionSetValue CustomerTypeCode
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("customertypecode");
            }
            set
            {
                this.OnPropertyChanging("CustomerTypeCode");
                this.SetAttributeValue("customertypecode", value);
                this.OnPropertyChanged("CustomerTypeCode");
            }
        }

        /// <summary>
        /// Choose the default price list associated with the account to make sure the correct product prices for this customer are applied in sales opportunities, quotes, and orders.
        /// </summary>
        [AttributeLogicalName("defaultpricelevelid")]
        public Microsoft.Xrm.Sdk.EntityReference DefaultPriceLevelId
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("defaultpricelevelid");
            }
            set
            {
                this.OnPropertyChanging("DefaultPriceLevelId");
                this.SetAttributeValue("defaultpricelevelid", value);
                this.OnPropertyChanged("DefaultPriceLevelId");
            }
        }

        /// <summary>
        /// Type additional information to describe the account, such as an excerpt from the company's website.
        /// </summary>
        [AttributeLogicalName("description")]
        public string Description
        {
            get
            {
                return this.GetAttributeValue<string>("description");
            }
            set
            {
                this.OnPropertyChanging("Description");
                this.SetAttributeValue("description", value);
                this.OnPropertyChanged("Description");
            }
        }

        /// <summary>
        /// Select whether the account allows bulk email sent through campaigns. If Do Not Allow is selected, the account can be added to marketing lists, but is excluded from email.
        /// </summary>
        [AttributeLogicalName("donotbulkemail")]
        public System.Nullable<bool> DoNotBulkEMail
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("donotbulkemail");
            }
            set
            {
                this.OnPropertyChanging("DoNotBulkEMail");
                this.SetAttributeValue("donotbulkemail", value);
                this.OnPropertyChanged("DoNotBulkEMail");
            }
        }

        /// <summary>
        /// Select whether the account allows bulk postal mail sent through marketing campaigns or quick campaigns. If Do Not Allow is selected, the account can be added to marketing lists, but will be excluded from the postal mail.
        /// </summary>
        [AttributeLogicalName("donotbulkpostalmail")]
        public System.Nullable<bool> DoNotBulkPostalMail
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("donotbulkpostalmail");
            }
            set
            {
                this.OnPropertyChanging("DoNotBulkPostalMail");
                this.SetAttributeValue("donotbulkpostalmail", value);
                this.OnPropertyChanged("DoNotBulkPostalMail");
            }
        }

        /// <summary>
        /// Select whether the account allows direct email sent from Microsoft Dynamics CRM.
        /// </summary>
        [AttributeLogicalName("donotemail")]
        public System.Nullable<bool> DoNotEMail
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("donotemail");
            }
            set
            {
                this.OnPropertyChanging("DoNotEMail");
                this.SetAttributeValue("donotemail", value);
                this.OnPropertyChanged("DoNotEMail");
            }
        }

        /// <summary>
        /// Select whether the account allows faxes. If Do Not Allow is selected, the account will be excluded from fax activities distributed in marketing campaigns.
        /// </summary>
        [AttributeLogicalName("donotfax")]
        public System.Nullable<bool> DoNotFax
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("donotfax");
            }
            set
            {
                this.OnPropertyChanging("DoNotFax");
                this.SetAttributeValue("donotfax", value);
                this.OnPropertyChanged("DoNotFax");
            }
        }

        /// <summary>
        /// Select whether the account allows phone calls. If Do Not Allow is selected, the account will be excluded from phone call activities distributed in marketing campaigns.
        /// </summary>
        [AttributeLogicalName("donotphone")]
        public System.Nullable<bool> DoNotPhone
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("donotphone");
            }
            set
            {
                this.OnPropertyChanging("DoNotPhone");
                this.SetAttributeValue("donotphone", value);
                this.OnPropertyChanged("DoNotPhone");
            }
        }

        /// <summary>
        /// Select whether the account allows direct mail. If Do Not Allow is selected, the account will be excluded from letter activities distributed in marketing campaigns.
        /// </summary>
        [AttributeLogicalName("donotpostalmail")]
        public System.Nullable<bool> DoNotPostalMail
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("donotpostalmail");
            }
            set
            {
                this.OnPropertyChanging("DoNotPostalMail");
                this.SetAttributeValue("donotpostalmail", value);
                this.OnPropertyChanged("DoNotPostalMail");
            }
        }

        /// <summary>
        /// Select whether the account accepts marketing materials, such as brochures or catalogs.
        /// </summary>
        [AttributeLogicalName("donotsendmm")]
        public System.Nullable<bool> DoNotSendMM
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("donotsendmm");
            }
            set
            {
                this.OnPropertyChanging("DoNotSendMM");
                this.SetAttributeValue("donotsendmm", value);
                this.OnPropertyChanged("DoNotSendMM");
            }
        }

        /// <summary>
        /// Type the primary email address for the account.
        /// </summary>
        [AttributeLogicalName("emailaddress1")]
        public string EMailAddress1
        {
            get
            {
                return this.GetAttributeValue<string>("emailaddress1");
            }
            set
            {
                this.OnPropertyChanging("EMailAddress1");
                this.SetAttributeValue("emailaddress1", value);
                this.OnPropertyChanged("EMailAddress1");
            }
        }

        /// <summary>
        /// Type the secondary email address for the account.
        /// </summary>
        [AttributeLogicalName("emailaddress2")]
        public string EMailAddress2
        {
            get
            {
                return this.GetAttributeValue<string>("emailaddress2");
            }
            set
            {
                this.OnPropertyChanging("EMailAddress2");
                this.SetAttributeValue("emailaddress2", value);
                this.OnPropertyChanged("EMailAddress2");
            }
        }

        /// <summary>
        /// Type an alternate email address for the account.
        /// </summary>
        [AttributeLogicalName("emailaddress3")]
        public string EMailAddress3
        {
            get
            {
                return this.GetAttributeValue<string>("emailaddress3");
            }
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
        [AttributeLogicalName("entityimage")]
        public byte[] EntityImage
        {
            get
            {
                return this.GetAttributeValue<byte[]>("entityimage");
            }
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
        [AttributeLogicalName("entityimage_timestamp")]
        public System.Nullable<long> EntityImage_Timestamp
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<long>>("entityimage_timestamp");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [AttributeLogicalName("entityimage_url")]
        public string EntityImage_URL
        {
            get
            {
                return this.GetAttributeValue<string>("entityimage_url");
            }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [AttributeLogicalName("entityimageid")]
        public System.Nullable<System.Guid> EntityImageId
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<System.Guid>>("entityimageid");
            }
        }

        /// <summary>
        /// Shows the conversion rate of the record's currency. The exchange rate is used to convert all money fields in the record from the local currency to the system's default currency.
        /// </summary>
        [AttributeLogicalName("exchangerate")]
        public System.Nullable<decimal> ExchangeRate
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<decimal>>("exchangerate");
            }
        }

        /// <summary>
        /// Type the fax number for the account.
        /// </summary>
        [AttributeLogicalName("fax")]
        public string Fax
        {
            get
            {
                return this.GetAttributeValue<string>("fax");
            }
            set
            {
                this.OnPropertyChanging("Fax");
                this.SetAttributeValue("fax", value);
                this.OnPropertyChanged("Fax");
            }
        }

        /// <summary>
        /// Type the URL for the account's FTP site to enable users to access data and share documents.
        /// </summary>
        [AttributeLogicalName("ftpsiteurl")]
        public string FtpSiteURL
        {
            get
            {
                return this.GetAttributeValue<string>("ftpsiteurl");
            }
            set
            {
                this.OnPropertyChanging("FtpSiteURL");
                this.SetAttributeValue("ftpsiteurl", value);
                this.OnPropertyChanged("FtpSiteURL");
            }
        }

        /// <summary>
        /// Unique identifier of the data import or data migration that created this record.
        /// </summary>
        [AttributeLogicalName("importsequencenumber")]
        public System.Nullable<int> ImportSequenceNumber
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("importsequencenumber");
            }
            set
            {
                this.OnPropertyChanging("ImportSequenceNumber");
                this.SetAttributeValue("importsequencenumber", value);
                this.OnPropertyChanged("ImportSequenceNumber");
            }
        }

        /// <summary>
        /// Select the account's primary industry for use in marketing segmentation and demographic analysis.
        /// </summary>
        [AttributeLogicalName("industrycode")]
        public Microsoft.Xrm.Sdk.OptionSetValue IndustryCode
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("industrycode");
            }
            set
            {
                this.OnPropertyChanging("IndustryCode");
                this.SetAttributeValue("industrycode", value);
                this.OnPropertyChanged("IndustryCode");
            }
        }

        /// <summary>
        /// Shows the date when the account was last included in a marketing campaign or quick campaign.
        /// </summary>
        [AttributeLogicalName("lastusedincampaign")]
        public System.Nullable<System.DateTime> LastUsedInCampaign
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("lastusedincampaign");
            }
            set
            {
                this.OnPropertyChanging("LastUsedInCampaign");
                this.SetAttributeValue("lastusedincampaign", value);
                this.OnPropertyChanged("LastUsedInCampaign");
            }
        }

        /// <summary>
        /// Type the market capitalization of the account to identify the company's equity, used as an indicator in financial performance analysis.
        /// </summary>
        [AttributeLogicalName("marketcap")]
        public Microsoft.Xrm.Sdk.Money MarketCap
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("marketcap");
            }
            set
            {
                this.OnPropertyChanging("MarketCap");
                this.SetAttributeValue("marketcap", value);
                this.OnPropertyChanged("MarketCap");
            }
        }

        /// <summary>
        /// Shows the market capitalization converted to the system's default base currency.
        /// </summary>
        [AttributeLogicalName("marketcap_base")]
        public Microsoft.Xrm.Sdk.Money MarketCap_Base
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("marketcap_base");
            }
        }

        /// <summary>
        /// Shows the master account that the account was merged with.
        /// </summary>
        [AttributeLogicalName("masterid")]
        public Microsoft.Xrm.Sdk.EntityReference MasterId
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("masterid");
            }
        }

        /// <summary>
        /// Shows whether the account has been merged with another account.
        /// </summary>
        [AttributeLogicalName("merged")]
        public System.Nullable<bool> Merged
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("merged");
            }
        }

        /// <summary>
        /// Shows who last updated the record.
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby");
            }
        }

        /// <summary>
        /// Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics CRM options.
        /// </summary>
        [AttributeLogicalName("modifiedon")]
        public System.Nullable<System.DateTime> ModifiedOn
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon");
            }
        }

        /// <summary>
        /// Shows who created the record on behalf of another user.
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby");
            }
        }

        /// <summary>
        /// Type the company or business name.
        /// </summary>
        [AttributeLogicalName("name")]
        public string Name
        {
            get
            {
                return this.GetAttributeValue<string>("name");
            }
            set
            {
                this.OnPropertyChanging("Name");
                this.SetAttributeValue("name", value);
                this.OnPropertyChanged("Name");
            }
        }

        /// <summary>
        /// Type the number of employees that work at the account for use in marketing segmentation and demographic analysis.
        /// </summary>
        [AttributeLogicalName("numberofemployees")]
        public System.Nullable<int> NumberOfEmployees
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("numberofemployees");
            }
            set
            {
                this.OnPropertyChanging("NumberOfEmployees");
                this.SetAttributeValue("numberofemployees", value);
                this.OnPropertyChanged("NumberOfEmployees");
            }
        }

        /// <summary>
        /// Number of open opportunities against an account and its child accounts.
        /// </summary>
        [AttributeLogicalName("opendeals")]
        public System.Nullable<int> OpenDeals
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("opendeals");
            }
        }

        /// <summary>
        /// The date time for Open Deals.
        /// </summary>
        [AttributeLogicalName("opendeals_date")]
        public System.Nullable<System.DateTime> OpenDeals_Date
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("opendeals_date");
            }
        }

        /// <summary>
        /// State of Open Deals.
        /// </summary>
        [AttributeLogicalName("opendeals_state")]
        public System.Nullable<int> OpenDeals_State
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("opendeals_state");
            }
        }

        /// <summary>
        /// Sum of open revenue against an account and its child accounts.
        /// </summary>
        [AttributeLogicalName("openrevenue")]
        public Microsoft.Xrm.Sdk.Money OpenRevenue
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("openrevenue");
            }
        }

        /// <summary>
        /// Sum of open revenue against an account and its child accounts.
        /// </summary>
        [AttributeLogicalName("openrevenue_base")]
        public Microsoft.Xrm.Sdk.Money OpenRevenue_Base
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("openrevenue_base");
            }
        }

        /// <summary>
        /// The date time for Open Revenue.
        /// </summary>
        [AttributeLogicalName("openrevenue_date")]
        public System.Nullable<System.DateTime> OpenRevenue_Date
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("openrevenue_date");
            }
        }

        /// <summary>
        /// State of Open Revenue.
        /// </summary>
        [AttributeLogicalName("openrevenue_state")]
        public System.Nullable<int> OpenRevenue_State
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("openrevenue_state");
            }
        }

        /// <summary>
        /// Shows the lead that the account was created from if the account was created by converting a lead in Microsoft Dynamics CRM. This is used to relate the account to data on the originating lead for use in reporting and analytics.
        /// </summary>
        [AttributeLogicalName("originatingleadid")]
        public Microsoft.Xrm.Sdk.EntityReference OriginatingLeadId
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("originatingleadid");
            }
            set
            {
                this.OnPropertyChanging("OriginatingLeadId");
                this.SetAttributeValue("originatingleadid", value);
                this.OnPropertyChanged("OriginatingLeadId");
            }
        }

        /// <summary>
        /// Date and time that the record was migrated.
        /// </summary>
        [AttributeLogicalName("overriddencreatedon")]
        public System.Nullable<System.DateTime> OverriddenCreatedOn
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<System.DateTime>>("overriddencreatedon");
            }
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
        [AttributeLogicalName("ownerid")]
        public Microsoft.Xrm.Sdk.EntityReference OwnerId
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("ownerid");
            }
            set
            {
                this.OnPropertyChanging("OwnerId");
                this.SetAttributeValue("ownerid", value);
                this.OnPropertyChanged("OwnerId");
            }
        }

        /// <summary>
        /// Select the account's ownership structure, such as public or private.
        /// </summary>
        [AttributeLogicalName("ownershipcode")]
        public Microsoft.Xrm.Sdk.OptionSetValue OwnershipCode
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("ownershipcode");
            }
            set
            {
                this.OnPropertyChanging("OwnershipCode");
                this.SetAttributeValue("ownershipcode", value);
                this.OnPropertyChanged("OwnershipCode");
            }
        }

        /// <summary>
        /// Shows the business unit that the record owner belongs to.
        /// </summary>
        [AttributeLogicalName("owningbusinessunit")]
        public Microsoft.Xrm.Sdk.EntityReference OwningBusinessUnit
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningbusinessunit");
            }
        }

        /// <summary>
        /// Unique identifier of the team who owns the account.
        /// </summary>
        [AttributeLogicalName("owningteam")]
        public Microsoft.Xrm.Sdk.EntityReference OwningTeam
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningteam");
            }
        }

        /// <summary>
        /// Unique identifier of the user who owns the account.
        /// </summary>
        [AttributeLogicalName("owninguser")]
        public Microsoft.Xrm.Sdk.EntityReference OwningUser
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owninguser");
            }
        }

        /// <summary>
        /// Choose the parent account associated with this account to show parent and child businesses in reporting and analytics.
        /// </summary>
        [AttributeLogicalName("parentaccountid")]
        public Microsoft.Xrm.Sdk.EntityReference ParentAccountId
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("parentaccountid");
            }
            set
            {
                this.OnPropertyChanging("ParentAccountId");
                this.SetAttributeValue("parentaccountid", value);
                this.OnPropertyChanged("ParentAccountId");
            }
        }

        /// <summary>
        /// For system use only. Legacy Microsoft Dynamics CRM 3.0 workflow data.
        /// </summary>
        [AttributeLogicalName("participatesinworkflow")]
        public System.Nullable<bool> ParticipatesInWorkflow
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<bool>>("participatesinworkflow");
            }
            set
            {
                this.OnPropertyChanging("ParticipatesInWorkflow");
                this.SetAttributeValue("participatesinworkflow", value);
                this.OnPropertyChanged("ParticipatesInWorkflow");
            }
        }

        /// <summary>
        /// Select the payment terms to indicate when the customer needs to pay the total amount.
        /// </summary>
        [AttributeLogicalName("paymenttermscode")]
        public Microsoft.Xrm.Sdk.OptionSetValue PaymentTermsCode
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("paymenttermscode");
            }
            set
            {
                this.OnPropertyChanging("PaymentTermsCode");
                this.SetAttributeValue("paymenttermscode", value);
                this.OnPropertyChanged("PaymentTermsCode");
            }
        }

        /// <summary>
        /// Select the preferred day of the week for service appointments.
        /// </summary>
        [AttributeLogicalName("preferredappointmentdaycode")]
        public Microsoft.Xrm.Sdk.OptionSetValue PreferredAppointmentDayCode
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("preferredappointmentdaycode");
            }
            set
            {
                this.OnPropertyChanging("PreferredAppointmentDayCode");
                this.SetAttributeValue("preferredappointmentdaycode", value);
                this.OnPropertyChanged("PreferredAppointmentDayCode");
            }
        }

        /// <summary>
        /// Select the preferred time of day for service appointments.
        /// </summary>
        [AttributeLogicalName("preferredappointmenttimecode")]
        public Microsoft.Xrm.Sdk.OptionSetValue PreferredAppointmentTimeCode
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("preferredappointmenttimecode");
            }
            set
            {
                this.OnPropertyChanging("PreferredAppointmentTimeCode");
                this.SetAttributeValue("preferredappointmenttimecode", value);
                this.OnPropertyChanged("PreferredAppointmentTimeCode");
            }
        }

        /// <summary>
        /// Select the preferred method of contact.
        /// </summary>
        [AttributeLogicalName("preferredcontactmethodcode")]
        public Microsoft.Xrm.Sdk.OptionSetValue PreferredContactMethodCode
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("preferredcontactmethodcode");
            }
            set
            {
                this.OnPropertyChanging("PreferredContactMethodCode");
                this.SetAttributeValue("preferredcontactmethodcode", value);
                this.OnPropertyChanged("PreferredContactMethodCode");
            }
        }

        /// <summary>
        /// Choose the account's preferred service facility or equipment to make sure services are scheduled correctly for the customer.
        /// </summary>
        [AttributeLogicalName("preferredequipmentid")]
        public Microsoft.Xrm.Sdk.EntityReference PreferredEquipmentId
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("preferredequipmentid");
            }
            set
            {
                this.OnPropertyChanging("PreferredEquipmentId");
                this.SetAttributeValue("preferredequipmentid", value);
                this.OnPropertyChanged("PreferredEquipmentId");
            }
        }

        /// <summary>
        /// Choose the account's preferred service for reference when you schedule service activities.
        /// </summary>
        [AttributeLogicalName("preferredserviceid")]
        public Microsoft.Xrm.Sdk.EntityReference PreferredServiceId
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("preferredserviceid");
            }
            set
            {
                this.OnPropertyChanging("PreferredServiceId");
                this.SetAttributeValue("preferredserviceid", value);
                this.OnPropertyChanged("PreferredServiceId");
            }
        }

        /// <summary>
        /// Choose the preferred service representative for reference when you schedule service activities for the account.
        /// </summary>
        [AttributeLogicalName("preferredsystemuserid")]
        public Microsoft.Xrm.Sdk.EntityReference PreferredSystemUserId
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("preferredsystemuserid");
            }
            set
            {
                this.OnPropertyChanging("PreferredSystemUserId");
                this.SetAttributeValue("preferredsystemuserid", value);
                this.OnPropertyChanged("PreferredSystemUserId");
            }
        }

        /// <summary>
        /// Choose the primary contact for the account to provide quick access to contact details.
        /// </summary>
        [AttributeLogicalName("primarycontactid")]
        public Microsoft.Xrm.Sdk.EntityReference PrimaryContactId
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("primarycontactid");
            }
            set
            {
                this.OnPropertyChanging("PrimaryContactId");
                this.SetAttributeValue("primarycontactid", value);
                this.OnPropertyChanged("PrimaryContactId");
            }
        }

        /// <summary>
        /// Shows the ID of the process.
        /// </summary>
        [AttributeLogicalName("processid")]
        public System.Nullable<System.Guid> ProcessId
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<System.Guid>>("processid");
            }
            set
            {
                this.OnPropertyChanging("ProcessId");
                this.SetAttributeValue("processid", value);
                this.OnPropertyChanged("ProcessId");
            }
        }

        /// <summary>
        /// Type the annual revenue for the account, used as an indicator in financial performance analysis.
        /// </summary>
        [AttributeLogicalName("revenue")]
        public Microsoft.Xrm.Sdk.Money Revenue
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("revenue");
            }
            set
            {
                this.OnPropertyChanging("Revenue");
                this.SetAttributeValue("revenue", value);
                this.OnPropertyChanged("Revenue");
            }
        }

        /// <summary>
        /// Shows the annual revenue converted to the system's default base currency. The calculations use the exchange rate specified in the Currencies area.
        /// </summary>
        [AttributeLogicalName("revenue_base")]
        public Microsoft.Xrm.Sdk.Money Revenue_Base
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("revenue_base");
            }
        }

        /// <summary>
        /// Type the number of shares available to the public for the account. This number is used as an indicator in financial performance analysis.
        /// </summary>
        [AttributeLogicalName("sharesoutstanding")]
        public System.Nullable<int> SharesOutstanding
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("sharesoutstanding");
            }
            set
            {
                this.OnPropertyChanging("SharesOutstanding");
                this.SetAttributeValue("sharesoutstanding", value);
                this.OnPropertyChanged("SharesOutstanding");
            }
        }

        /// <summary>
        /// Select a shipping method for deliveries sent to the account's address to designate the preferred carrier or other delivery option.
        /// </summary>
        [AttributeLogicalName("shippingmethodcode")]
        public Microsoft.Xrm.Sdk.OptionSetValue ShippingMethodCode
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("shippingmethodcode");
            }
            set
            {
                this.OnPropertyChanging("ShippingMethodCode");
                this.SetAttributeValue("shippingmethodcode", value);
                this.OnPropertyChanged("ShippingMethodCode");
            }
        }

        /// <summary>
        /// Type the Standard Industrial Classification (SIC) code that indicates the account's primary industry of business, for use in marketing segmentation and demographic analysis.
        /// </summary>
        [AttributeLogicalName("sic")]
        public string SIC
        {
            get
            {
                return this.GetAttributeValue<string>("sic");
            }
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
        [AttributeLogicalName("stageid")]
        public System.Nullable<System.Guid> StageId
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<System.Guid>>("stageid");
            }
            set
            {
                this.OnPropertyChanging("StageId");
                this.SetAttributeValue("stageid", value);
                this.OnPropertyChanged("StageId");
            }
        }

        /// <summary>
        /// Shows whether the account is active or inactive. Inactive accounts are read-only and can't be edited unless they are reactivated.
        /// </summary>
        [AttributeLogicalName("statecode")]
        public System.Nullable<AccountState> StateCode
        {
            get
            {
                Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
                if ((optionSet != null))
                {
                    return ((AccountState)(System.Enum.ToObject(typeof(AccountState), optionSet.Value)));
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// Select the account's status.
        /// </summary>
        [AttributeLogicalName("statuscode")]
        public Microsoft.Xrm.Sdk.OptionSetValue StatusCode
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statuscode");
            }
            set
            {
                this.OnPropertyChanging("StatusCode");
                this.SetAttributeValue("statuscode", value);
                this.OnPropertyChanged("StatusCode");
            }
        }

        /// <summary>
        /// Type the stock exchange at which the account is listed to track their stock and financial performance of the company.
        /// </summary>
        [AttributeLogicalName("stockexchange")]
        public string StockExchange
        {
            get
            {
                return this.GetAttributeValue<string>("stockexchange");
            }
            set
            {
                this.OnPropertyChanging("StockExchange");
                this.SetAttributeValue("stockexchange", value);
                this.OnPropertyChanged("StockExchange");
            }
        }

        /// <summary>
        /// Type the main phone number for this account.
        /// </summary>
        [AttributeLogicalName("telephone1")]
        public string Telephone1
        {
            get
            {
                return this.GetAttributeValue<string>("telephone1");
            }
            set
            {
                this.OnPropertyChanging("Telephone1");
                this.SetAttributeValue("telephone1", value);
                this.OnPropertyChanged("Telephone1");
            }
        }

        /// <summary>
        /// Type a second phone number for this account.
        /// </summary>
        [AttributeLogicalName("telephone2")]
        public string Telephone2
        {
            get
            {
                return this.GetAttributeValue<string>("telephone2");
            }
            set
            {
                this.OnPropertyChanging("Telephone2");
                this.SetAttributeValue("telephone2", value);
                this.OnPropertyChanged("Telephone2");
            }
        }

        /// <summary>
        /// Type a third phone number for this account.
        /// </summary>
        [AttributeLogicalName("telephone3")]
        public string Telephone3
        {
            get
            {
                return this.GetAttributeValue<string>("telephone3");
            }
            set
            {
                this.OnPropertyChanging("Telephone3");
                this.SetAttributeValue("telephone3", value);
                this.OnPropertyChanged("Telephone3");
            }
        }

        /// <summary>
        /// Select a region or territory for the account for use in segmentation and analysis.
        /// </summary>
        [AttributeLogicalName("territorycode")]
        public Microsoft.Xrm.Sdk.OptionSetValue TerritoryCode
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("territorycode");
            }
            set
            {
                this.OnPropertyChanging("TerritoryCode");
                this.SetAttributeValue("territorycode", value);
                this.OnPropertyChanged("TerritoryCode");
            }
        }

        /// <summary>
        /// Choose the sales region or territory for the account to make sure the account is assigned to the correct representative and for use in segmentation and analysis.
        /// </summary>
        [AttributeLogicalName("territoryid")]
        public Microsoft.Xrm.Sdk.EntityReference TerritoryId
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("territoryid");
            }
            set
            {
                this.OnPropertyChanging("TerritoryId");
                this.SetAttributeValue("territoryid", value);
                this.OnPropertyChanged("TerritoryId");
            }
        }

        /// <summary>
        /// Type the stock exchange symbol for the account to track financial performance of the company. You can click the code entered in this field to access the latest trading information from MSN Money.
        /// </summary>
        [AttributeLogicalName("tickersymbol")]
        public string TickerSymbol
        {
            get
            {
                return this.GetAttributeValue<string>("tickersymbol");
            }
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
        [AttributeLogicalName("timezoneruleversionnumber")]
        public System.Nullable<int> TimeZoneRuleVersionNumber
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("timezoneruleversionnumber");
            }
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
        [AttributeLogicalName("transactioncurrencyid")]
        public Microsoft.Xrm.Sdk.EntityReference TransactionCurrencyId
        {
            get
            {
                return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("transactioncurrencyid");
            }
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
        [AttributeLogicalName("traversedpath")]
        public string TraversedPath
        {
            get
            {
                return this.GetAttributeValue<string>("traversedpath");
            }
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
        [AttributeLogicalName("utcconversiontimezonecode")]
        public System.Nullable<int> UTCConversionTimeZoneCode
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<int>>("utcconversiontimezonecode");
            }
            set
            {
                this.OnPropertyChanging("UTCConversionTimeZoneCode");
                this.SetAttributeValue("utcconversiontimezonecode", value);
                this.OnPropertyChanged("UTCConversionTimeZoneCode");
            }
        }

        /// <summary>
        /// Version number of the account.
        /// </summary>
        [AttributeLogicalName("versionnumber")]
        public System.Nullable<long> VersionNumber
        {
            get
            {
                return this.GetAttributeValue<System.Nullable<long>>("versionnumber");
            }
        }

        /// <summary>
        /// Type the account's website URL to get quick details about the company profile.
        /// </summary>
        [AttributeLogicalName("websiteurl")]
        public string WebSiteURL
        {
            get
            {
                return this.GetAttributeValue<string>("websiteurl");
            }
            set
            {
                this.OnPropertyChanging("WebSiteURL");
                this.SetAttributeValue("websiteurl", value);
                this.OnPropertyChanged("WebSiteURL");
            }
        }

        /// <summary>
        /// Type the phonetic spelling of the company name, if specified in Japanese, to make sure the name is pronounced correctly in phone calls and other communications.
        /// </summary>
        [AttributeLogicalName("yominame")]
        public string YomiName
        {
            get
            {
                return this.GetAttributeValue<string>("yominame");
            }
            set
            {
                this.OnPropertyChanging("YomiName");
                this.SetAttributeValue("yominame", value);
                this.OnPropertyChanged("YomiName");
            }
        }

        /// <summary>
        /// 1:N account_activity_parties
        /// </summary>
        [RelationshipSchemaName("account_activity_parties")]
        public System.Collections.Generic.IEnumerable<ActivityParty> account_activity_parties
        {
            get
            {
                return this.GetRelatedEntities<ActivityParty>("account_activity_parties", null);
            }
            set
            {
                this.OnPropertyChanging("account_activity_parties");
                this.SetRelatedEntities<ActivityParty>("account_activity_parties", null, value);
                this.OnPropertyChanged("account_activity_parties");
            }
        }

        /// <summary>
        /// 1:N Account_ActivityPointers
        /// </summary>
        [RelationshipSchemaName("Account_ActivityPointers")]
        public System.Collections.Generic.IEnumerable<ActivityPointer> Account_ActivityPointers
        {
            get
            {
                return this.GetRelatedEntities<ActivityPointer>("Account_ActivityPointers", null);
            }
            set
            {
                this.OnPropertyChanging("Account_ActivityPointers");
                this.SetRelatedEntities<ActivityPointer>("Account_ActivityPointers", null, value);
                this.OnPropertyChanged("Account_ActivityPointers");
            }
        }

        /// <summary>
        /// 1:N Account_Annotation
        /// </summary>
        [RelationshipSchemaName("Account_Annotation")]
        public System.Collections.Generic.IEnumerable<Annotation> Account_Annotation
        {
            get
            {
                return this.GetRelatedEntities<Annotation>("Account_Annotation", null);
            }
            set
            {
                this.OnPropertyChanging("Account_Annotation");
                this.SetRelatedEntities<Annotation>("Account_Annotation", null, value);
                this.OnPropertyChanged("Account_Annotation");
            }
        }

        /// <summary>
        /// 1:N Account_Appointments
        /// </summary>
        [RelationshipSchemaName("Account_Appointments")]
        public System.Collections.Generic.IEnumerable<Appointment> Account_Appointments
        {
            get
            {
                return this.GetRelatedEntities<Appointment>("Account_Appointments", null);
            }
            set
            {
                this.OnPropertyChanging("Account_Appointments");
                this.SetRelatedEntities<Appointment>("Account_Appointments", null, value);
                this.OnPropertyChanged("Account_Appointments");
            }
        }

        /// <summary>
        /// 1:N Account_AsyncOperations
        /// </summary>
        [RelationshipSchemaName("Account_AsyncOperations")]
        public System.Collections.Generic.IEnumerable<AsyncOperation> Account_AsyncOperations
        {
            get
            {
                return this.GetRelatedEntities<AsyncOperation>("Account_AsyncOperations", null);
            }
            set
            {
                this.OnPropertyChanging("Account_AsyncOperations");
                this.SetRelatedEntities<AsyncOperation>("Account_AsyncOperations", null, value);
                this.OnPropertyChanged("Account_AsyncOperations");
            }
        }

        /// <summary>
        /// 1:N Account_BulkDeleteFailures
        /// </summary>
        [RelationshipSchemaName("Account_BulkDeleteFailures")]
        public System.Collections.Generic.IEnumerable<BulkDeleteFailure> Account_BulkDeleteFailures
        {
            get
            {
                return this.GetRelatedEntities<BulkDeleteFailure>("Account_BulkDeleteFailures", null);
            }
            set
            {
                this.OnPropertyChanging("Account_BulkDeleteFailures");
                this.SetRelatedEntities<BulkDeleteFailure>("Account_BulkDeleteFailures", null, value);
                this.OnPropertyChanged("Account_BulkDeleteFailures");
            }
        }

        /// <summary>
        /// 1:N account_connections1
        /// </summary>
        [RelationshipSchemaName("account_connections1")]
        public System.Collections.Generic.IEnumerable<Connection> account_connections1
        {
            get
            {
                return this.GetRelatedEntities<Connection>("account_connections1", null);
            }
            set
            {
                this.OnPropertyChanging("account_connections1");
                this.SetRelatedEntities<Connection>("account_connections1", null, value);
                this.OnPropertyChanged("account_connections1");
            }
        }

        /// <summary>
        /// 1:N account_connections2
        /// </summary>
        [RelationshipSchemaName("account_connections2")]
        public System.Collections.Generic.IEnumerable<Connection> account_connections2
        {
            get
            {
                return this.GetRelatedEntities<Connection>("account_connections2", null);
            }
            set
            {
                this.OnPropertyChanging("account_connections2");
                this.SetRelatedEntities<Connection>("account_connections2", null, value);
                this.OnPropertyChanged("account_connections2");
            }
        }

        /// <summary>
        /// 1:N account_customer_opportunity_roles
        /// </summary>
        [RelationshipSchemaName("account_customer_opportunity_roles")]
        public System.Collections.Generic.IEnumerable<CustomerOpportunityRole> account_customer_opportunity_roles
        {
            get
            {
                return this.GetRelatedEntities<CustomerOpportunityRole>("account_customer_opportunity_roles", null);
            }
            set
            {
                this.OnPropertyChanging("account_customer_opportunity_roles");
                this.SetRelatedEntities<CustomerOpportunityRole>("account_customer_opportunity_roles", null, value);
                this.OnPropertyChanged("account_customer_opportunity_roles");
            }
        }

        /// <summary>
        /// 1:N account_customer_relationship_customer
        /// </summary>
        [RelationshipSchemaName("account_customer_relationship_customer")]
        public System.Collections.Generic.IEnumerable<CustomerRelationship> account_customer_relationship_customer
        {
            get
            {
                return this.GetRelatedEntities<CustomerRelationship>("account_customer_relationship_customer", null);
            }
            set
            {
                this.OnPropertyChanging("account_customer_relationship_customer");
                this.SetRelatedEntities<CustomerRelationship>("account_customer_relationship_customer", null, value);
                this.OnPropertyChanged("account_customer_relationship_customer");
            }
        }

        /// <summary>
        /// 1:N account_customer_relationship_partner
        /// </summary>
        [RelationshipSchemaName("account_customer_relationship_partner")]
        public System.Collections.Generic.IEnumerable<CustomerRelationship> account_customer_relationship_partner
        {
            get
            {
                return this.GetRelatedEntities<CustomerRelationship>("account_customer_relationship_partner", null);
            }
            set
            {
                this.OnPropertyChanging("account_customer_relationship_partner");
                this.SetRelatedEntities<CustomerRelationship>("account_customer_relationship_partner", null, value);
                this.OnPropertyChanged("account_customer_relationship_partner");
            }
        }

        /// <summary>
        /// 1:N Account_CustomerAddress
        /// </summary>
        [RelationshipSchemaName("Account_CustomerAddress")]
        public System.Collections.Generic.IEnumerable<CustomerAddress> Account_CustomerAddress
        {
            get
            {
                return this.GetRelatedEntities<CustomerAddress>("Account_CustomerAddress", null);
            }
            set
            {
                this.OnPropertyChanging("Account_CustomerAddress");
                this.SetRelatedEntities<CustomerAddress>("Account_CustomerAddress", null, value);
                this.OnPropertyChanged("Account_CustomerAddress");
            }
        }

        /// <summary>
        /// 1:N Account_DuplicateBaseRecord
        /// </summary>
        [RelationshipSchemaName("Account_DuplicateBaseRecord")]
        public System.Collections.Generic.IEnumerable<DuplicateRecord> Account_DuplicateBaseRecord
        {
            get
            {
                return this.GetRelatedEntities<DuplicateRecord>("Account_DuplicateBaseRecord", null);
            }
            set
            {
                this.OnPropertyChanging("Account_DuplicateBaseRecord");
                this.SetRelatedEntities<DuplicateRecord>("Account_DuplicateBaseRecord", null, value);
                this.OnPropertyChanged("Account_DuplicateBaseRecord");
            }
        }

        /// <summary>
        /// 1:N Account_DuplicateMatchingRecord
        /// </summary>
        [RelationshipSchemaName("Account_DuplicateMatchingRecord")]
        public System.Collections.Generic.IEnumerable<DuplicateRecord> Account_DuplicateMatchingRecord
        {
            get
            {
                return this.GetRelatedEntities<DuplicateRecord>("Account_DuplicateMatchingRecord", null);
            }
            set
            {
                this.OnPropertyChanging("Account_DuplicateMatchingRecord");
                this.SetRelatedEntities<DuplicateRecord>("Account_DuplicateMatchingRecord", null, value);
                this.OnPropertyChanged("Account_DuplicateMatchingRecord");
            }
        }

        /// <summary>
        /// 1:N Account_Email_EmailSender
        /// </summary>
        [RelationshipSchemaName("Account_Email_EmailSender")]
        public System.Collections.Generic.IEnumerable<Email> Account_Email_EmailSender
        {
            get
            {
                return this.GetRelatedEntities<Email>("Account_Email_EmailSender", null);
            }
            set
            {
                this.OnPropertyChanging("Account_Email_EmailSender");
                this.SetRelatedEntities<Email>("Account_Email_EmailSender", null, value);
                this.OnPropertyChanged("Account_Email_EmailSender");
            }
        }

        /// <summary>
        /// 1:N Account_Email_SendersAccount
        /// </summary>
        [RelationshipSchemaName("Account_Email_SendersAccount")]
        public System.Collections.Generic.IEnumerable<Email> Account_Email_SendersAccount
        {
            get
            {
                return this.GetRelatedEntities<Email>("Account_Email_SendersAccount", null);
            }
            set
            {
                this.OnPropertyChanging("Account_Email_SendersAccount");
                this.SetRelatedEntities<Email>("Account_Email_SendersAccount", null, value);
                this.OnPropertyChanged("Account_Email_SendersAccount");
            }
        }

        /// <summary>
        /// 1:N Account_Emails
        /// </summary>
        [RelationshipSchemaName("Account_Emails")]
        public System.Collections.Generic.IEnumerable<Email> Account_Emails
        {
            get
            {
                return this.GetRelatedEntities<Email>("Account_Emails", null);
            }
            set
            {
                this.OnPropertyChanging("Account_Emails");
                this.SetRelatedEntities<Email>("Account_Emails", null, value);
                this.OnPropertyChanged("Account_Emails");
            }
        }

        /// <summary>
        /// 1:N account_entitlement_Account
        /// </summary>
        [RelationshipSchemaName("account_entitlement_Account")]
        public System.Collections.Generic.IEnumerable<Entitlement> account_entitlement_Account
        {
            get
            {
                return this.GetRelatedEntities<Entitlement>("account_entitlement_Account", null);
            }
            set
            {
                this.OnPropertyChanging("account_entitlement_Account");
                this.SetRelatedEntities<Entitlement>("account_entitlement_Account", null, value);
                this.OnPropertyChanged("account_entitlement_Account");
            }
        }

        /// <summary>
        /// 1:N account_entitlement_Customer
        /// </summary>
        [RelationshipSchemaName("account_entitlement_Customer")]
        public System.Collections.Generic.IEnumerable<Entitlement> account_entitlement_Customer
        {
            get
            {
                return this.GetRelatedEntities<Entitlement>("account_entitlement_Customer", null);
            }
            set
            {
                this.OnPropertyChanging("account_entitlement_Customer");
                this.SetRelatedEntities<Entitlement>("account_entitlement_Customer", null, value);
                this.OnPropertyChanged("account_entitlement_Customer");
            }
        }

        /// <summary>
        /// 1:N Account_Faxes
        /// </summary>
        [RelationshipSchemaName("Account_Faxes")]
        public System.Collections.Generic.IEnumerable<Fax> Account_Faxes
        {
            get
            {
                return this.GetRelatedEntities<Fax>("Account_Faxes", null);
            }
            set
            {
                this.OnPropertyChanging("Account_Faxes");
                this.SetRelatedEntities<Fax>("Account_Faxes", null, value);
                this.OnPropertyChanged("Account_Faxes");
            }
        }

        /// <summary>
        /// 1:N Account_Letters
        /// </summary>
        [RelationshipSchemaName("Account_Letters")]
        public System.Collections.Generic.IEnumerable<Letter> Account_Letters
        {
            get
            {
                return this.GetRelatedEntities<Letter>("Account_Letters", null);
            }
            set
            {
                this.OnPropertyChanging("Account_Letters");
                this.SetRelatedEntities<Letter>("Account_Letters", null, value);
                this.OnPropertyChanged("Account_Letters");
            }
        }

        /// <summary>
        /// 1:N account_master_account
        /// </summary>
        [RelationshipSchemaName("account_master_account", Microsoft.Xrm.Sdk.EntityRole.Referenced)]
        public System.Collections.Generic.IEnumerable<Account> Referencedaccount_master_account
        {
            get
            {
                return this.GetRelatedEntities<Account>("account_master_account", Microsoft.Xrm.Sdk.EntityRole.Referenced);
            }
            set
            {
                this.OnPropertyChanging("Referencedaccount_master_account");
                this.SetRelatedEntities<Account>("account_master_account", Microsoft.Xrm.Sdk.EntityRole.Referenced, value);
                this.OnPropertyChanged("Referencedaccount_master_account");
            }
        }

        /// <summary>
        /// 1:N account_parent_account
        /// </summary>
        [RelationshipSchemaName("account_parent_account", Microsoft.Xrm.Sdk.EntityRole.Referenced)]
        public System.Collections.Generic.IEnumerable<Account> Referencedaccount_parent_account
        {
            get
            {
                return this.GetRelatedEntities<Account>("account_parent_account", Microsoft.Xrm.Sdk.EntityRole.Referenced);
            }
            set
            {
                this.OnPropertyChanging("Referencedaccount_parent_account");
                this.SetRelatedEntities<Account>("account_parent_account", Microsoft.Xrm.Sdk.EntityRole.Referenced, value);
                this.OnPropertyChanged("Referencedaccount_parent_account");
            }
        }

        /// <summary>
        /// 1:N Account_Phonecalls
        /// </summary>
        [RelationshipSchemaName("Account_Phonecalls")]
        public System.Collections.Generic.IEnumerable<PhoneCall> Account_Phonecalls
        {
            get
            {
                return this.GetRelatedEntities<PhoneCall>("Account_Phonecalls", null);
            }
            set
            {
                this.OnPropertyChanging("Account_Phonecalls");
                this.SetRelatedEntities<PhoneCall>("Account_Phonecalls", null, value);
                this.OnPropertyChanged("Account_Phonecalls");
            }
        }

        /// <summary>
        /// 1:N account_PostFollows
        /// </summary>
        [RelationshipSchemaName("account_PostFollows")]
        public System.Collections.Generic.IEnumerable<PostFollow> account_PostFollows
        {
            get
            {
                return this.GetRelatedEntities<PostFollow>("account_PostFollows", null);
            }
            set
            {
                this.OnPropertyChanging("account_PostFollows");
                this.SetRelatedEntities<PostFollow>("account_PostFollows", null, value);
                this.OnPropertyChanged("account_PostFollows");
            }
        }

        /// <summary>
        /// 1:N account_principalobjectattributeaccess
        /// </summary>
        [RelationshipSchemaName("account_principalobjectattributeaccess")]
        public System.Collections.Generic.IEnumerable<PrincipalObjectAttributeAccess> account_principalobjectattributeaccess
        {
            get
            {
                return this.GetRelatedEntities<PrincipalObjectAttributeAccess>("account_principalobjectattributeaccess", null);
            }
            set
            {
                this.OnPropertyChanging("account_principalobjectattributeaccess");
                this.SetRelatedEntities<PrincipalObjectAttributeAccess>("account_principalobjectattributeaccess", null, value);
                this.OnPropertyChanged("account_principalobjectattributeaccess");
            }
        }

        /// <summary>
        /// 1:N Account_ProcessSessions
        /// </summary>
        [RelationshipSchemaName("Account_ProcessSessions")]
        public System.Collections.Generic.IEnumerable<ProcessSession> Account_ProcessSessions
        {
            get
            {
                return this.GetRelatedEntities<ProcessSession>("Account_ProcessSessions", null);
            }
            set
            {
                this.OnPropertyChanging("Account_ProcessSessions");
                this.SetRelatedEntities<ProcessSession>("Account_ProcessSessions", null, value);
                this.OnPropertyChanged("Account_ProcessSessions");
            }
        }

        /// <summary>
        /// 1:N Account_RecurringAppointmentMasters
        /// </summary>
        [RelationshipSchemaName("Account_RecurringAppointmentMasters")]
        public System.Collections.Generic.IEnumerable<RecurringAppointmentMaster> Account_RecurringAppointmentMasters
        {
            get
            {
                return this.GetRelatedEntities<RecurringAppointmentMaster>("Account_RecurringAppointmentMasters", null);
            }
            set
            {
                this.OnPropertyChanging("Account_RecurringAppointmentMasters");
                this.SetRelatedEntities<RecurringAppointmentMaster>("Account_RecurringAppointmentMasters", null, value);
                this.OnPropertyChanged("Account_RecurringAppointmentMasters");
            }
        }

        /// <summary>
        /// 1:N Account_ServiceAppointments
        /// </summary>
        [RelationshipSchemaName("Account_ServiceAppointments")]
        public System.Collections.Generic.IEnumerable<ServiceAppointment> Account_ServiceAppointments
        {
            get
            {
                return this.GetRelatedEntities<ServiceAppointment>("Account_ServiceAppointments", null);
            }
            set
            {
                this.OnPropertyChanging("Account_ServiceAppointments");
                this.SetRelatedEntities<ServiceAppointment>("Account_ServiceAppointments", null, value);
                this.OnPropertyChanged("Account_ServiceAppointments");
            }
        }

        /// <summary>
        /// 1:N Account_SharepointDocument
        /// </summary>
        [RelationshipSchemaName("Account_SharepointDocument")]
        public System.Collections.Generic.IEnumerable<SharePointDocument> Account_SharepointDocument
        {
            get
            {
                return this.GetRelatedEntities<SharePointDocument>("Account_SharepointDocument", null);
            }
            set
            {
                this.OnPropertyChanging("Account_SharepointDocument");
                this.SetRelatedEntities<SharePointDocument>("Account_SharepointDocument", null, value);
                this.OnPropertyChanged("Account_SharepointDocument");
            }
        }

        /// <summary>
        /// 1:N Account_SharepointDocumentLocation
        /// </summary>
        [RelationshipSchemaName("Account_SharepointDocumentLocation")]
        public System.Collections.Generic.IEnumerable<SharePointDocumentLocation> Account_SharepointDocumentLocation
        {
            get
            {
                return this.GetRelatedEntities<SharePointDocumentLocation>("Account_SharepointDocumentLocation", null);
            }
            set
            {
                this.OnPropertyChanging("Account_SharepointDocumentLocation");
                this.SetRelatedEntities<SharePointDocumentLocation>("Account_SharepointDocumentLocation", null, value);
                this.OnPropertyChanged("Account_SharepointDocumentLocation");
            }
        }

        /// <summary>
        /// 1:N Account_SocialActivities
        /// </summary>
        [RelationshipSchemaName("Account_SocialActivities")]
        public System.Collections.Generic.IEnumerable<SocialActivity> Account_SocialActivities
        {
            get
            {
                return this.GetRelatedEntities<SocialActivity>("Account_SocialActivities", null);
            }
            set
            {
                this.OnPropertyChanging("Account_SocialActivities");
                this.SetRelatedEntities<SocialActivity>("Account_SocialActivities", null, value);
                this.OnPropertyChanged("Account_SocialActivities");
            }
        }

        /// <summary>
        /// 1:N Account_Tasks
        /// </summary>
        [RelationshipSchemaName("Account_Tasks")]
        public System.Collections.Generic.IEnumerable<Task> Account_Tasks
        {
            get
            {
                return this.GetRelatedEntities<Task>("Account_Tasks", null);
            }
            set
            {
                this.OnPropertyChanging("Account_Tasks");
                this.SetRelatedEntities<Task>("Account_Tasks", null, value);
                this.OnPropertyChanged("Account_Tasks");
            }
        }

        /// <summary>
        /// 1:N contact_customer_accounts
        /// </summary>
        [RelationshipSchemaName("contact_customer_accounts")]
        public System.Collections.Generic.IEnumerable<Contact> contact_customer_accounts
        {
            get
            {
                return this.GetRelatedEntities<Contact>("contact_customer_accounts", null);
            }
            set
            {
                this.OnPropertyChanging("contact_customer_accounts");
                this.SetRelatedEntities<Contact>("contact_customer_accounts", null, value);
                this.OnPropertyChanged("contact_customer_accounts");
            }
        }

        /// <summary>
        /// 1:N contract_billingcustomer_accounts
        /// </summary>
        [RelationshipSchemaName("contract_billingcustomer_accounts")]
        public System.Collections.Generic.IEnumerable<Contract> contract_billingcustomer_accounts
        {
            get
            {
                return this.GetRelatedEntities<Contract>("contract_billingcustomer_accounts", null);
            }
            set
            {
                this.OnPropertyChanging("contract_billingcustomer_accounts");
                this.SetRelatedEntities<Contract>("contract_billingcustomer_accounts", null, value);
                this.OnPropertyChanged("contract_billingcustomer_accounts");
            }
        }

        /// <summary>
        /// 1:N contract_customer_accounts
        /// </summary>
        [RelationshipSchemaName("contract_customer_accounts")]
        public System.Collections.Generic.IEnumerable<Contract> contract_customer_accounts
        {
            get
            {
                return this.GetRelatedEntities<Contract>("contract_customer_accounts", null);
            }
            set
            {
                this.OnPropertyChanging("contract_customer_accounts");
                this.SetRelatedEntities<Contract>("contract_customer_accounts", null, value);
                this.OnPropertyChanged("contract_customer_accounts");
            }
        }

        /// <summary>
        /// 1:N contractlineitem_customer_accounts
        /// </summary>
        [RelationshipSchemaName("contractlineitem_customer_accounts")]
        public System.Collections.Generic.IEnumerable<ContractDetail> contractlineitem_customer_accounts
        {
            get
            {
                return this.GetRelatedEntities<ContractDetail>("contractlineitem_customer_accounts", null);
            }
            set
            {
                this.OnPropertyChanging("contractlineitem_customer_accounts");
                this.SetRelatedEntities<ContractDetail>("contractlineitem_customer_accounts", null, value);
                this.OnPropertyChanged("contractlineitem_customer_accounts");
            }
        }

        /// <summary>
        /// 1:N CreatedAccount_BulkOperationLogs2
        /// </summary>
        [RelationshipSchemaName("CreatedAccount_BulkOperationLogs2")]
        public System.Collections.Generic.IEnumerable<BulkOperationLog> CreatedAccount_BulkOperationLogs2
        {
            get
            {
                return this.GetRelatedEntities<BulkOperationLog>("CreatedAccount_BulkOperationLogs2", null);
            }
            set
            {
                this.OnPropertyChanging("CreatedAccount_BulkOperationLogs2");
                this.SetRelatedEntities<BulkOperationLog>("CreatedAccount_BulkOperationLogs2", null, value);
                this.OnPropertyChanged("CreatedAccount_BulkOperationLogs2");
            }
        }

        /// <summary>
        /// 1:N incident_customer_accounts
        /// </summary>
        [RelationshipSchemaName("incident_customer_accounts")]
        public System.Collections.Generic.IEnumerable<Incident> incident_customer_accounts
        {
            get
            {
                return this.GetRelatedEntities<Incident>("incident_customer_accounts", null);
            }
            set
            {
                this.OnPropertyChanging("incident_customer_accounts");
                this.SetRelatedEntities<Incident>("incident_customer_accounts", null, value);
                this.OnPropertyChanged("incident_customer_accounts");
            }
        }

        /// <summary>
        /// 1:N invoice_customer_accounts
        /// </summary>
        [RelationshipSchemaName("invoice_customer_accounts")]
        public System.Collections.Generic.IEnumerable<Invoice> invoice_customer_accounts
        {
            get
            {
                return this.GetRelatedEntities<Invoice>("invoice_customer_accounts", null);
            }
            set
            {
                this.OnPropertyChanging("invoice_customer_accounts");
                this.SetRelatedEntities<Invoice>("invoice_customer_accounts", null, value);
                this.OnPropertyChanged("invoice_customer_accounts");
            }
        }

        /// <summary>
        /// 1:N lead_customer_accounts
        /// </summary>
        [RelationshipSchemaName("lead_customer_accounts")]
        public System.Collections.Generic.IEnumerable<Lead> lead_customer_accounts
        {
            get
            {
                return this.GetRelatedEntities<Lead>("lead_customer_accounts", null);
            }
            set
            {
                this.OnPropertyChanging("lead_customer_accounts");
                this.SetRelatedEntities<Lead>("lead_customer_accounts", null, value);
                this.OnPropertyChanged("lead_customer_accounts");
            }
        }

        /// <summary>
        /// 1:N lead_parent_account
        /// </summary>
        [RelationshipSchemaName("lead_parent_account")]
        public System.Collections.Generic.IEnumerable<Lead> lead_parent_account
        {
            get
            {
                return this.GetRelatedEntities<Lead>("lead_parent_account", null);
            }
            set
            {
                this.OnPropertyChanging("lead_parent_account");
                this.SetRelatedEntities<Lead>("lead_parent_account", null, value);
                this.OnPropertyChanged("lead_parent_account");
            }
        }

        /// <summary>
        /// 1:N opportunity_customer_accounts
        /// </summary>
        [RelationshipSchemaName("opportunity_customer_accounts")]
        public System.Collections.Generic.IEnumerable<Opportunity> opportunity_customer_accounts
        {
            get
            {
                return this.GetRelatedEntities<Opportunity>("opportunity_customer_accounts", null);
            }
            set
            {
                this.OnPropertyChanging("opportunity_customer_accounts");
                this.SetRelatedEntities<Opportunity>("opportunity_customer_accounts", null, value);
                this.OnPropertyChanged("opportunity_customer_accounts");
            }
        }

        /// <summary>
        /// 1:N opportunity_parent_account
        /// </summary>
        [RelationshipSchemaName("opportunity_parent_account")]
        public System.Collections.Generic.IEnumerable<Opportunity> opportunity_parent_account
        {
            get
            {
                return this.GetRelatedEntities<Opportunity>("opportunity_parent_account", null);
            }
            set
            {
                this.OnPropertyChanging("opportunity_parent_account");
                this.SetRelatedEntities<Opportunity>("opportunity_parent_account", null, value);
                this.OnPropertyChanged("opportunity_parent_account");
            }
        }

        /// <summary>
        /// 1:N order_customer_accounts
        /// </summary>
        [RelationshipSchemaName("order_customer_accounts")]
        public System.Collections.Generic.IEnumerable<SalesOrder> order_customer_accounts
        {
            get
            {
                return this.GetRelatedEntities<SalesOrder>("order_customer_accounts", null);
            }
            set
            {
                this.OnPropertyChanging("order_customer_accounts");
                this.SetRelatedEntities<SalesOrder>("order_customer_accounts", null, value);
                this.OnPropertyChanged("order_customer_accounts");
            }
        }

        /// <summary>
        /// 1:N quote_customer_accounts
        /// </summary>
        [RelationshipSchemaName("quote_customer_accounts")]
        public System.Collections.Generic.IEnumerable<Quote> quote_customer_accounts
        {
            get
            {
                return this.GetRelatedEntities<Quote>("quote_customer_accounts", null);
            }
            set
            {
                this.OnPropertyChanging("quote_customer_accounts");
                this.SetRelatedEntities<Quote>("quote_customer_accounts", null, value);
                this.OnPropertyChanged("quote_customer_accounts");
            }
        }

        /// <summary>
        /// 1:N SocialActivity_PostAuthor_accounts
        /// </summary>
        [RelationshipSchemaName("SocialActivity_PostAuthor_accounts")]
        public System.Collections.Generic.IEnumerable<SocialActivity> SocialActivity_PostAuthor_accounts
        {
            get
            {
                return this.GetRelatedEntities<SocialActivity>("SocialActivity_PostAuthor_accounts", null);
            }
            set
            {
                this.OnPropertyChanging("SocialActivity_PostAuthor_accounts");
                this.SetRelatedEntities<SocialActivity>("SocialActivity_PostAuthor_accounts", null, value);
                this.OnPropertyChanged("SocialActivity_PostAuthor_accounts");
            }
        }

        /// <summary>
        /// 1:N SocialActivity_PostAuthorAccount_accounts
        /// </summary>
        [RelationshipSchemaName("SocialActivity_PostAuthorAccount_accounts")]
        public System.Collections.Generic.IEnumerable<SocialActivity> SocialActivity_PostAuthorAccount_accounts
        {
            get
            {
                return this.GetRelatedEntities<SocialActivity>("SocialActivity_PostAuthorAccount_accounts", null);
            }
            set
            {
                this.OnPropertyChanging("SocialActivity_PostAuthorAccount_accounts");
                this.SetRelatedEntities<SocialActivity>("SocialActivity_PostAuthorAccount_accounts", null, value);
                this.OnPropertyChanged("SocialActivity_PostAuthorAccount_accounts");
            }
        }

        /// <summary>
        /// 1:N Socialprofile_customer_accounts
        /// </summary>
        [RelationshipSchemaName("Socialprofile_customer_accounts")]
        public System.Collections.Generic.IEnumerable<SocialProfile> Socialprofile_customer_accounts
        {
            get
            {
                return this.GetRelatedEntities<SocialProfile>("Socialprofile_customer_accounts", null);
            }
            set
            {
                this.OnPropertyChanging("Socialprofile_customer_accounts");
                this.SetRelatedEntities<SocialProfile>("Socialprofile_customer_accounts", null, value);
                this.OnPropertyChanged("Socialprofile_customer_accounts");
            }
        }

        /// <summary>
        /// 1:N SourceAccount_BulkOperationLogs
        /// </summary>
        [RelationshipSchemaName("SourceAccount_BulkOperationLogs")]
        public System.Collections.Generic.IEnumerable<BulkOperationLog> SourceAccount_BulkOperationLogs
        {
            get
            {
                return this.GetRelatedEntities<BulkOperationLog>("SourceAccount_BulkOperationLogs", null);
            }
            set
            {
                this.OnPropertyChanging("SourceAccount_BulkOperationLogs");
                this.SetRelatedEntities<BulkOperationLog>("SourceAccount_BulkOperationLogs", null, value);
                this.OnPropertyChanged("SourceAccount_BulkOperationLogs");
            }
        }

        /// <summary>
        /// 1:N userentityinstancedata_account
        /// </summary>
        [RelationshipSchemaName("userentityinstancedata_account")]
        public System.Collections.Generic.IEnumerable<UserEntityInstanceData> userentityinstancedata_account
        {
            get
            {
                return this.GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_account", null);
            }
            set
            {
                this.OnPropertyChanging("userentityinstancedata_account");
                this.SetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_account", null, value);
                this.OnPropertyChanged("userentityinstancedata_account");
            }
        }

        /// <summary>
        /// N:N accountleads_association
        /// </summary>
        [RelationshipSchemaName("accountleads_association")]
        public System.Collections.Generic.IEnumerable<Lead> accountleads_association
        {
            get
            {
                return this.GetRelatedEntities<Lead>("accountleads_association", null);
            }
            set
            {
                this.OnPropertyChanging("accountleads_association");
                this.SetRelatedEntities<Lead>("accountleads_association", null, value);
                this.OnPropertyChanged("accountleads_association");
            }
        }

        /// <summary>
        /// N:N listaccount_association
        /// </summary>
        [RelationshipSchemaName("listaccount_association")]
        public System.Collections.Generic.IEnumerable<List> listaccount_association
        {
            get
            {
                return this.GetRelatedEntities<List>("listaccount_association", null);
            }
            set
            {
                this.OnPropertyChanging("listaccount_association");
                this.SetRelatedEntities<List>("listaccount_association", null, value);
                this.OnPropertyChanged("listaccount_association");
            }
        }

        /// <summary>
        /// N:1 account_master_account
        /// </summary>
        [AttributeLogicalName("masterid")]
        [RelationshipSchemaName("account_master_account", Microsoft.Xrm.Sdk.EntityRole.Referencing)]
        public Account Referencingaccount_master_account
        {
            get
            {
                return this.GetRelatedEntity<Account>("account_master_account", Microsoft.Xrm.Sdk.EntityRole.Referencing);
            }
        }

        /// <summary>
        /// N:1 account_originating_lead
        /// </summary>
        [AttributeLogicalName("originatingleadid")]
        [RelationshipSchemaName("account_originating_lead")]
        public Lead account_originating_lead
        {
            get
            {
                return this.GetRelatedEntity<Lead>("account_originating_lead", null);
            }
            set
            {
                this.OnPropertyChanging("account_originating_lead");
                this.SetRelatedEntity<Lead>("account_originating_lead", null, value);
                this.OnPropertyChanged("account_originating_lead");
            }
        }

        /// <summary>
        /// N:1 account_parent_account
        /// </summary>
        [AttributeLogicalName("parentaccountid")]
        [RelationshipSchemaName("account_parent_account", Microsoft.Xrm.Sdk.EntityRole.Referencing)]
        public Account Referencingaccount_parent_account
        {
            get
            {
                return this.GetRelatedEntity<Account>("account_parent_account", Microsoft.Xrm.Sdk.EntityRole.Referencing);
            }
            set
            {
                this.OnPropertyChanging("Referencingaccount_parent_account");
                this.SetRelatedEntity<Account>("account_parent_account", Microsoft.Xrm.Sdk.EntityRole.Referencing, value);
                this.OnPropertyChanged("Referencingaccount_parent_account");
            }
        }

        /// <summary>
        /// N:1 account_primary_contact
        /// </summary>
        [AttributeLogicalName("primarycontactid")]
        [RelationshipSchemaName("account_primary_contact")]
        public Contact account_primary_contact
        {
            get
            {
                return this.GetRelatedEntity<Contact>("account_primary_contact", null);
            }
            set
            {
                this.OnPropertyChanging("account_primary_contact");
                this.SetRelatedEntity<Contact>("account_primary_contact", null, value);
                this.OnPropertyChanged("account_primary_contact");
            }
        }

        /// <summary>
        /// N:1 business_unit_accounts
        /// </summary>
        [AttributeLogicalName("owningbusinessunit")]
        [RelationshipSchemaName("business_unit_accounts")]
        public BusinessUnit business_unit_accounts
        {
            get
            {
                return this.GetRelatedEntity<BusinessUnit>("business_unit_accounts", null);
            }
        }

        /// <summary>
        /// N:1 equipment_accounts
        /// </summary>
        [AttributeLogicalName("preferredequipmentid")]
        [RelationshipSchemaName("equipment_accounts")]
        public Equipment equipment_accounts
        {
            get
            {
                return this.GetRelatedEntity<Equipment>("equipment_accounts", null);
            }
            set
            {
                this.OnPropertyChanging("equipment_accounts");
                this.SetRelatedEntity<Equipment>("equipment_accounts", null, value);
                this.OnPropertyChanged("equipment_accounts");
            }
        }

        /// <summary>
        /// N:1 lk_accountbase_createdby
        /// </summary>
        [AttributeLogicalName("createdby")]
        [RelationshipSchemaName("lk_accountbase_createdby")]
        public SystemUser lk_accountbase_createdby
        {
            get
            {
                return this.GetRelatedEntity<SystemUser>("lk_accountbase_createdby", null);
            }
        }

        /// <summary>
        /// N:1 lk_accountbase_createdonbehalfby
        /// </summary>
        [AttributeLogicalName("createdonbehalfby")]
        [RelationshipSchemaName("lk_accountbase_createdonbehalfby")]
        public SystemUser lk_accountbase_createdonbehalfby
        {
            get
            {
                return this.GetRelatedEntity<SystemUser>("lk_accountbase_createdonbehalfby", null);
            }
        }

        /// <summary>
        /// N:1 lk_accountbase_modifiedby
        /// </summary>
        [AttributeLogicalName("modifiedby")]
        [RelationshipSchemaName("lk_accountbase_modifiedby")]
        public SystemUser lk_accountbase_modifiedby
        {
            get
            {
                return this.GetRelatedEntity<SystemUser>("lk_accountbase_modifiedby", null);
            }
        }

        /// <summary>
        /// N:1 lk_accountbase_modifiedonbehalfby
        /// </summary>
        [AttributeLogicalName("modifiedonbehalfby")]
        [RelationshipSchemaName("lk_accountbase_modifiedonbehalfby")]
        public SystemUser lk_accountbase_modifiedonbehalfby
        {
            get
            {
                return this.GetRelatedEntity<SystemUser>("lk_accountbase_modifiedonbehalfby", null);
            }
        }

        /// <summary>
        /// N:1 price_level_accounts
        /// </summary>
        [AttributeLogicalName("defaultpricelevelid")]
        [RelationshipSchemaName("price_level_accounts")]
        public PriceLevel price_level_accounts
        {
            get
            {
                return this.GetRelatedEntity<PriceLevel>("price_level_accounts", null);
            }
            set
            {
                this.OnPropertyChanging("price_level_accounts");
                this.SetRelatedEntity<PriceLevel>("price_level_accounts", null, value);
                this.OnPropertyChanged("price_level_accounts");
            }
        }

        /// <summary>
        /// N:1 processstage_account
        /// </summary>
        [AttributeLogicalName("stageid")]
        [RelationshipSchemaName("processstage_account")]
        public ProcessStage processstage_account
        {
            get
            {
                return this.GetRelatedEntity<ProcessStage>("processstage_account", null);
            }
            set
            {
                this.OnPropertyChanging("processstage_account");
                this.SetRelatedEntity<ProcessStage>("processstage_account", null, value);
                this.OnPropertyChanged("processstage_account");
            }
        }

        /// <summary>
        /// N:1 service_accounts
        /// </summary>
        [AttributeLogicalName("preferredserviceid")]
        [RelationshipSchemaName("service_accounts")]
        public Service service_accounts
        {
            get
            {
                return this.GetRelatedEntity<Service>("service_accounts", null);
            }
            set
            {
                this.OnPropertyChanging("service_accounts");
                this.SetRelatedEntity<Service>("service_accounts", null, value);
                this.OnPropertyChanged("service_accounts");
            }
        }

        /// <summary>
        /// N:1 system_user_accounts
        /// </summary>
        [AttributeLogicalName("preferredsystemuserid")]
        [RelationshipSchemaName("system_user_accounts")]
        public SystemUser system_user_accounts
        {
            get
            {
                return this.GetRelatedEntity<SystemUser>("system_user_accounts", null);
            }
            set
            {
                this.OnPropertyChanging("system_user_accounts");
                this.SetRelatedEntity<SystemUser>("system_user_accounts", null, value);
                this.OnPropertyChanged("system_user_accounts");
            }
        }

        /// <summary>
        /// N:1 team_accounts
        /// </summary>
        [AttributeLogicalName("owningteam")]
        [RelationshipSchemaName("team_accounts")]
        public Team team_accounts
        {
            get
            {
                return this.GetRelatedEntity<Team>("team_accounts", null);
            }
        }

        /// <summary>
        /// N:1 territory_accounts
        /// </summary>
        [AttributeLogicalName("territoryid")]
        [RelationshipSchemaName("territory_accounts")]
        public Territory territory_accounts
        {
            get
            {
                return this.GetRelatedEntity<Territory>("territory_accounts", null);
            }
            set
            {
                this.OnPropertyChanging("territory_accounts");
                this.SetRelatedEntity<Territory>("territory_accounts", null, value);
                this.OnPropertyChanged("territory_accounts");
            }
        }

        /// <summary>
        /// N:1 transactioncurrency_account
        /// </summary>
        [AttributeLogicalName("transactioncurrencyid")]
        [RelationshipSchemaName("transactioncurrency_account")]
        public TransactionCurrency transactioncurrency_account
        {
            get
            {
                return this.GetRelatedEntity<TransactionCurrency>("transactioncurrency_account", null);
            }
            set
            {
                this.OnPropertyChanging("transactioncurrency_account");
                this.SetRelatedEntity<TransactionCurrency>("transactioncurrency_account", null, value);
                this.OnPropertyChanged("transactioncurrency_account");
            }
        }

        /// <summary>
        /// N:1 user_accounts
        /// </summary>
        [AttributeLogicalName("owninguser")]
        [RelationshipSchemaName("user_accounts")]
        public SystemUser user_accounts
        {
            get
            {
                return this.GetRelatedEntity<SystemUser>("user_accounts", null);
            }
        }

        

    }
}