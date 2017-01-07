namespace __4_DAL_CRM
{
    /// <summary>
    /// Localized name of the time zone.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("timezonelocalizedname")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class TimeZoneLocalizedName : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public TimeZoneLocalizedName() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "timezonelocalizedname";

        public const int EntityTypeCode = 4812;

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
        /// Unique identifier of the user who created the record.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby"); }
        }

        /// <summary>
        /// Date and time when the record was created.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
        public System.Nullable<System.DateTime> CreatedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who created the timezonelocalizedname.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        /// Unique identifier of the culture that the UI names are encoded in.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("cultureid")]
        public System.Nullable<int> CultureId
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("cultureid"); }
            set
            {
                this.OnPropertyChanging("CultureId");
                this.SetAttributeValue("cultureid", value);
                this.OnPropertyChanged("CultureId");
            }
        }

        /// <summary>
        /// Name of the time zone for the daylight time.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("daylightname")]
        public string DaylightName
        {
            get { return this.GetAttributeValue<string>("daylightname"); }
            set
            {
                this.OnPropertyChanging("DaylightName");
                this.SetAttributeValue("daylightname", value);
                this.OnPropertyChanged("DaylightName");
            }
        }

        /// <summary>
        /// Unique identifier of the user who last modified the time zone localized name.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby"); }
        }

        /// <summary>
        /// Date and time when the record was modified.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
        public System.Nullable<System.DateTime> ModifiedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who last modified the timezonelocalizedname.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        /// Unique identifier of the organization associated with the time zone localized name.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
        public Microsoft.Xrm.Sdk.EntityReference OrganizationId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("organizationid"); }
        }

        /// <summary>
        /// Name of the time zone for the standard time.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("standardname")]
        public string StandardName
        {
            get { return this.GetAttributeValue<string>("standardname"); }
            set
            {
                this.OnPropertyChanging("StandardName");
                this.SetAttributeValue("standardname", value);
                this.OnPropertyChanged("StandardName");
            }
        }

        /// <summary>
        /// Unique identifier of time zone definition entity instances.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("timezonedefinitionid")]
        public Microsoft.Xrm.Sdk.EntityReference TimeZoneDefinitionId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("timezonedefinitionid"); }
            set
            {
                this.OnPropertyChanging("TimeZoneDefinitionId");
                this.SetAttributeValue("timezonedefinitionid", value);
                this.OnPropertyChanged("TimeZoneDefinitionId");
            }
        }

        /// <summary>
        /// Unique identifier of entity instances.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("timezonelocalizednameid")]
        public System.Nullable<System.Guid> TimeZoneLocalizedNameId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("timezonelocalizednameid"); }
            set
            {
                this.OnPropertyChanging("TimeZoneLocalizedNameId");
                this.SetAttributeValue("timezonelocalizednameid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("TimeZoneLocalizedNameId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("timezonelocalizednameid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.TimeZoneLocalizedNameId = value; }
        }

        /// <summary>
        /// Unique display name for the time zone in the Microsoft Windows registry.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("userinterfacename")]
        public string UserInterfaceName
        {
            get { return this.GetAttributeValue<string>("userinterfacename"); }
            set
            {
                this.OnPropertyChanging("UserInterfaceName");
                this.SetAttributeValue("userinterfacename", value);
                this.OnPropertyChanged("UserInterfaceName");
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
        /// 1:N userentityinstancedata_timezonelocalizedname
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_timezonelocalizedname")]
        public System.Collections.Generic.IEnumerable<UserEntityInstanceData> userentityinstancedata_timezonelocalizedname
        {
            get { return this.GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_timezonelocalizedname", null); }
            set
            {
                this.OnPropertyChanging("userentityinstancedata_timezonelocalizedname");
                this.SetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_timezonelocalizedname", null, value);
                this.OnPropertyChanged("userentityinstancedata_timezonelocalizedname");
            }
        }

        /// <summary>
        /// N:1 lk_timezonelocalizedname_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_timezonelocalizedname_createdby")]
        public SystemUser lk_timezonelocalizedname_createdby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_timezonelocalizedname_createdby", null); }
        }

        /// <summary>
        /// N:1 lk_timezonelocalizedname_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_timezonelocalizedname_createdonbehalfby")]
        public SystemUser lk_timezonelocalizedname_createdonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_timezonelocalizedname_createdonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_timezonelocalizedname_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_timezonelocalizedname_modifiedby")]
        public SystemUser lk_timezonelocalizedname_modifiedby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_timezonelocalizedname_modifiedby", null); }
        }

        /// <summary>
        /// N:1 lk_timezonelocalizedname_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_timezonelocalizedname_modifiedonbehalfby")]
        public SystemUser lk_timezonelocalizedname_modifiedonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_timezonelocalizedname_modifiedonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_timezonelocalizedname_timezonedefinitionid
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("timezonedefinitionid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_timezonelocalizedname_timezonedefinitionid")]
        public TimeZoneDefinition lk_timezonelocalizedname_timezonedefinitionid
        {
            get { return this.GetRelatedEntity<TimeZoneDefinition>("lk_timezonelocalizedname_timezonedefinitionid", null); }
            set
            {
                this.OnPropertyChanging("lk_timezonelocalizedname_timezonedefinitionid");
                this.SetRelatedEntity<TimeZoneDefinition>("lk_timezonelocalizedname_timezonedefinitionid", null, value);
                this.OnPropertyChanged("lk_timezonelocalizedname_timezonedefinitionid");
            }
        }
    }
}