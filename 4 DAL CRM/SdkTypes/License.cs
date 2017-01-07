namespace __4_DAL_CRM
{
    /// <summary>
    /// Stores information about a Microsoft CRM license.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("license")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class License : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public License() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "license";

        public const int EntityTypeCode = 2027;

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
        /// Date and time when the license was installed.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("installedon")]
        public System.Nullable<System.DateTime> InstalledOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("installedon"); }
            set
            {
                this.OnPropertyChanging("InstalledOn");
                this.SetAttributeValue("installedon", value);
                this.OnPropertyChanged("InstalledOn");
            }
        }

        /// <summary>
        /// Unique identifier of the license.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("licenseid")]
        public System.Nullable<System.Guid> LicenseId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("licenseid"); }
            set
            {
                this.OnPropertyChanging("LicenseId");
                this.SetAttributeValue("licenseid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("LicenseId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("licenseid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.LicenseId = value; }
        }

        /// <summary>
        /// Key for the license.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("licensekey")]
        public string LicenseKey
        {
            get { return this.GetAttributeValue<string>("licensekey"); }
            set
            {
                this.OnPropertyChanging("LicenseKey");
                this.SetAttributeValue("licensekey", value);
                this.OnPropertyChanged("LicenseKey");
            }
        }

        /// <summary>
        /// Type of license, such as Professional, Standard, or Suite.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("licensetype")]
        public System.Nullable<System.Guid> LicenseType
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("licensetype"); }
            set
            {
                this.OnPropertyChanging("LicenseType");
                this.SetAttributeValue("licensetype", value);
                this.OnPropertyChanged("LicenseType");
            }
        }

        /// <summary>
        /// Unique identifier of the organization associated with the license.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
        public Microsoft.Xrm.Sdk.EntityReference OrganizationId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("organizationid"); }
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
        /// 1:N userentityinstancedata_license
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_license")]
        public System.Collections.Generic.IEnumerable<UserEntityInstanceData> userentityinstancedata_license
        {
            get { return this.GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_license", null); }
            set
            {
                this.OnPropertyChanging("userentityinstancedata_license");
                this.SetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_license", null, value);
                this.OnPropertyChanged("userentityinstancedata_license");
            }
        }

        /// <summary>
        /// N:1 organization_licenses
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_licenses")]
        public Organization organization_licenses
        {
            get { return this.GetRelatedEntity<Organization>("organization_licenses", null); }
        }
    }
}