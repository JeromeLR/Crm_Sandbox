namespace __4_DAL_CRM
{
    /// <summary>
    /// Time zone definition, including name and time zone code.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("timezonedefinition")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class TimeZoneDefinition : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public TimeZoneDefinition() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "timezonedefinition";

        public const int EntityTypeCode = 4810;

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
        /// Base time bias of the time zone.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("bias")]
        public System.Nullable<int> Bias
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("bias"); }
            set
            {
                this.OnPropertyChanging("Bias");
                this.SetAttributeValue("bias", value);
                this.OnPropertyChanged("Bias");
            }
        }

        /// <summary>
        /// Unique identifier of the user who created the time zone record.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby"); }
        }

        /// <summary>
        /// Date and time when the time zone record was created.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
        public System.Nullable<System.DateTime> CreatedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who created the timezonedefinition.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        /// Time zone name for the daylight time.
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
        /// Unique identifier of the user who last modified the time zone record.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby"); }
        }

        /// <summary>
        /// Date and time when the time zone record was modified.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
        public System.Nullable<System.DateTime> ModifiedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who last modified the timezonedefinition.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        /// Unique identifier of the organization associated with the time zone definition.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
        public Microsoft.Xrm.Sdk.EntityReference OrganizationId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("organizationid"); }
        }

        /// <summary>
        /// Order an entry for a time zone definition is retired. 0 for the latest entry.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("retiredorder")]
        public System.Nullable<int> RetiredOrder
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("retiredorder"); }
            set
            {
                this.OnPropertyChanging("RetiredOrder");
                this.SetAttributeValue("retiredorder", value);
                this.OnPropertyChanged("RetiredOrder");
            }
        }

        /// <summary>
        /// Time zone name for the standard time.
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
        /// Time zone identification code.
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
        /// Unique identifier of the time zone record.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("timezonedefinitionid")]
        public System.Nullable<System.Guid> TimeZoneDefinitionId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("timezonedefinitionid"); }
            set
            {
                this.OnPropertyChanging("TimeZoneDefinitionId");
                this.SetAttributeValue("timezonedefinitionid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("TimeZoneDefinitionId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("timezonedefinitionid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.TimeZoneDefinitionId = value; }
        }

        /// <summary>
        /// Display name for the time zone in the Microsoft Windows registry.
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
        /// 1:N lk_timezonelocalizedname_timezonedefinitionid
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_timezonelocalizedname_timezonedefinitionid")]
        public System.Collections.Generic.IEnumerable<TimeZoneLocalizedName> lk_timezonelocalizedname_timezonedefinitionid
        {
            get { return this.GetRelatedEntities<TimeZoneLocalizedName>("lk_timezonelocalizedname_timezonedefinitionid", null); }
            set
            {
                this.OnPropertyChanging("lk_timezonelocalizedname_timezonedefinitionid");
                this.SetRelatedEntities<TimeZoneLocalizedName>("lk_timezonelocalizedname_timezonedefinitionid", null, value);
                this.OnPropertyChanged("lk_timezonelocalizedname_timezonedefinitionid");
            }
        }

        /// <summary>
        /// 1:N lk_timezonerule_timezonedefinitionid
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_timezonerule_timezonedefinitionid")]
        public System.Collections.Generic.IEnumerable<TimeZoneRule> lk_timezonerule_timezonedefinitionid
        {
            get { return this.GetRelatedEntities<TimeZoneRule>("lk_timezonerule_timezonedefinitionid", null); }
            set
            {
                this.OnPropertyChanging("lk_timezonerule_timezonedefinitionid");
                this.SetRelatedEntities<TimeZoneRule>("lk_timezonerule_timezonedefinitionid", null, value);
                this.OnPropertyChanged("lk_timezonerule_timezonedefinitionid");
            }
        }

        /// <summary>
        /// 1:N userentityinstancedata_timezonedefinition
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_timezonedefinition")]
        public System.Collections.Generic.IEnumerable<UserEntityInstanceData> userentityinstancedata_timezonedefinition
        {
            get { return this.GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_timezonedefinition", null); }
            set
            {
                this.OnPropertyChanging("userentityinstancedata_timezonedefinition");
                this.SetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_timezonedefinition", null, value);
                this.OnPropertyChanged("userentityinstancedata_timezonedefinition");
            }
        }

        /// <summary>
        /// N:1 lk_timezonedefinition_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_timezonedefinition_createdby")]
        public SystemUser lk_timezonedefinition_createdby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_timezonedefinition_createdby", null); }
        }

        /// <summary>
        /// N:1 lk_timezonedefinition_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_timezonedefinition_createdonbehalfby")]
        public SystemUser lk_timezonedefinition_createdonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_timezonedefinition_createdonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_timezonedefinition_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_timezonedefinition_modifiedby")]
        public SystemUser lk_timezonedefinition_modifiedby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_timezonedefinition_modifiedby", null); }
        }

        /// <summary>
        /// N:1 lk_timezonedefinition_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_timezonedefinition_modifiedonbehalfby")]
        public SystemUser lk_timezonedefinition_modifiedonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_timezonedefinition_modifiedonbehalfby", null); }
        }
    }
}