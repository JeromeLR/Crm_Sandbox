namespace __4_DAL_CRM
{
    /// <summary>
    /// Definition for time conversion between local time and Coordinated Universal Time (UTC) for a particular time zone at a particular time period.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("timezonerule")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class TimeZoneRule : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public TimeZoneRule() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "timezonerule";

        public const int EntityTypeCode = 4811;

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
        /// Base time bias of the time zone rule.
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
        /// Unique identifier of the user who created the time zone rule.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby"); }
        }

        /// <summary>
        /// Date and time when the time zone rule was created.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
        public System.Nullable<System.DateTime> CreatedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who created the timezonerule.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        /// Time bias in addition to the base bias for daylight savings time.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("daylightbias")]
        public System.Nullable<int> DaylightBias
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("daylightbias"); }
            set
            {
                this.OnPropertyChanging("DaylightBias");
                this.SetAttributeValue("daylightbias", value);
                this.OnPropertyChanged("DaylightBias");
            }
        }

        /// <summary>
        /// Day of the month when daylight savings time starts.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("daylightday")]
        public System.Nullable<int> DaylightDay
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("daylightday"); }
            set
            {
                this.OnPropertyChanging("DaylightDay");
                this.SetAttributeValue("daylightday", value);
                this.OnPropertyChanged("DaylightDay");
            }
        }

        /// <summary>
        /// Day of the week when daylight savings time starts.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("daylightdayofweek")]
        public System.Nullable<int> DaylightDayOfWeek
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("daylightdayofweek"); }
            set
            {
                this.OnPropertyChanging("DaylightDayOfWeek");
                this.SetAttributeValue("daylightdayofweek", value);
                this.OnPropertyChanged("DaylightDayOfWeek");
            }
        }

        /// <summary>
        /// Hour of the day when daylight savings time starts
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("daylighthour")]
        public System.Nullable<int> DaylightHour
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("daylighthour"); }
            set
            {
                this.OnPropertyChanging("DaylightHour");
                this.SetAttributeValue("daylighthour", value);
                this.OnPropertyChanged("DaylightHour");
            }
        }

        /// <summary>
        /// Minute of the hour when daylight savings time starts.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("daylightminute")]
        public System.Nullable<int> DaylightMinute
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("daylightminute"); }
            set
            {
                this.OnPropertyChanging("DaylightMinute");
                this.SetAttributeValue("daylightminute", value);
                this.OnPropertyChanged("DaylightMinute");
            }
        }

        /// <summary>
        /// Month when daylight savings time starts.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("daylightmonth")]
        public System.Nullable<int> DaylightMonth
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("daylightmonth"); }
            set
            {
                this.OnPropertyChanging("DaylightMonth");
                this.SetAttributeValue("daylightmonth", value);
                this.OnPropertyChanged("DaylightMonth");
            }
        }

        /// <summary>
        /// Second of the minute when daylight savings time starts
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("daylightsecond")]
        public System.Nullable<int> DaylightSecond
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("daylightsecond"); }
            set
            {
                this.OnPropertyChanging("DaylightSecond");
                this.SetAttributeValue("daylightsecond", value);
                this.OnPropertyChanged("DaylightSecond");
            }
        }

        /// <summary>
        /// Year when daylight savings times starts.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("daylightyear")]
        public System.Nullable<int> DaylightYear
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("daylightyear"); }
            set
            {
                this.OnPropertyChanging("DaylightYear");
                this.SetAttributeValue("daylightyear", value);
                this.OnPropertyChanged("DaylightYear");
            }
        }

        /// <summary>
        /// Time that this rule takes effect, in local time.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("effectivedatetime")]
        public System.Nullable<System.DateTime> EffectiveDateTime
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("effectivedatetime"); }
            set
            {
                this.OnPropertyChanging("EffectiveDateTime");
                this.SetAttributeValue("effectivedatetime", value);
                this.OnPropertyChanged("EffectiveDateTime");
            }
        }

        /// <summary>
        /// Unique identifier of the user who last modified the time zone rule.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby"); }
        }

        /// <summary>
        /// Date and time when the time zone rule was modified.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
        public System.Nullable<System.DateTime> ModifiedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who last modified the timezonerule.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        /// Unique identifier of the organization associated with the time zone rule.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
        public Microsoft.Xrm.Sdk.EntityReference OrganizationId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("organizationid"); }
        }

        /// <summary>
        /// Time bias in addition to the base bias for standard time.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("standardbias")]
        public System.Nullable<int> StandardBias
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("standardbias"); }
            set
            {
                this.OnPropertyChanging("StandardBias");
                this.SetAttributeValue("standardbias", value);
                this.OnPropertyChanged("StandardBias");
            }
        }

        /// <summary>
        /// Day of the month when standard time starts.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("standardday")]
        public System.Nullable<int> StandardDay
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("standardday"); }
            set
            {
                this.OnPropertyChanging("StandardDay");
                this.SetAttributeValue("standardday", value);
                this.OnPropertyChanged("StandardDay");
            }
        }

        /// <summary>
        /// Day of the week when standard time starts.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("standarddayofweek")]
        public System.Nullable<int> StandardDayOfWeek
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("standarddayofweek"); }
            set
            {
                this.OnPropertyChanging("StandardDayOfWeek");
                this.SetAttributeValue("standarddayofweek", value);
                this.OnPropertyChanged("StandardDayOfWeek");
            }
        }

        /// <summary>
        /// Hour of the day when standard time starts.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("standardhour")]
        public System.Nullable<int> StandardHour
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("standardhour"); }
            set
            {
                this.OnPropertyChanging("StandardHour");
                this.SetAttributeValue("standardhour", value);
                this.OnPropertyChanged("StandardHour");
            }
        }

        /// <summary>
        /// Minute of the hour when standard time starts.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("standardminute")]
        public System.Nullable<int> StandardMinute
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("standardminute"); }
            set
            {
                this.OnPropertyChanging("StandardMinute");
                this.SetAttributeValue("standardminute", value);
                this.OnPropertyChanged("StandardMinute");
            }
        }

        /// <summary>
        /// Month when standard time starts.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("standardmonth")]
        public System.Nullable<int> StandardMonth
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("standardmonth"); }
            set
            {
                this.OnPropertyChanging("StandardMonth");
                this.SetAttributeValue("standardmonth", value);
                this.OnPropertyChanged("StandardMonth");
            }
        }

        /// <summary>
        /// Second of the Minute when standard time starts.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("standardsecond")]
        public System.Nullable<int> StandardSecond
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("standardsecond"); }
            set
            {
                this.OnPropertyChanging("StandardSecond");
                this.SetAttributeValue("standardsecond", value);
                this.OnPropertyChanged("StandardSecond");
            }
        }

        /// <summary>
        /// Year when standard time starts.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("standardyear")]
        public System.Nullable<int> StandardYear
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("standardyear"); }
            set
            {
                this.OnPropertyChanging("StandardYear");
                this.SetAttributeValue("standardyear", value);
                this.OnPropertyChanged("StandardYear");
            }
        }

        /// <summary>
        /// Unique identifier of the time zone definition.
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
        /// Unique identifier of the time zone rule.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("timezoneruleid")]
        public System.Nullable<System.Guid> TimeZoneRuleId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("timezoneruleid"); }
            set
            {
                this.OnPropertyChanging("TimeZoneRuleId");
                this.SetAttributeValue("timezoneruleid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("TimeZoneRuleId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("timezoneruleid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.TimeZoneRuleId = value; }
        }

        /// <summary>
        /// For internal use only
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
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
        public System.Nullable<long> VersionNumber
        {
            get { return this.GetAttributeValue<System.Nullable<long>>("versionnumber"); }
        }

        /// <summary>
        /// 1:N userentityinstancedata_timezonerule
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_timezonerule")]
        public System.Collections.Generic.IEnumerable<UserEntityInstanceData> userentityinstancedata_timezonerule
        {
            get { return this.GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_timezonerule", null); }
            set
            {
                this.OnPropertyChanging("userentityinstancedata_timezonerule");
                this.SetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_timezonerule", null, value);
                this.OnPropertyChanged("userentityinstancedata_timezonerule");
            }
        }

        /// <summary>
        /// N:1 lk_timezonerule_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_timezonerule_createdby")]
        public SystemUser lk_timezonerule_createdby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_timezonerule_createdby", null); }
        }

        /// <summary>
        /// N:1 lk_timezonerule_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_timezonerule_createdonbehalfby")]
        public SystemUser lk_timezonerule_createdonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_timezonerule_createdonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_timezonerule_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_timezonerule_modifiedby")]
        public SystemUser lk_timezonerule_modifiedby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_timezonerule_modifiedby", null); }
        }

        /// <summary>
        /// N:1 lk_timezonerule_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_timezonerule_modifiedonbehalfby")]
        public SystemUser lk_timezonerule_modifiedonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_timezonerule_modifiedonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_timezonerule_timezonedefinitionid
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("timezonedefinitionid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_timezonerule_timezonedefinitionid")]
        public TimeZoneDefinition lk_timezonerule_timezonedefinitionid
        {
            get { return this.GetRelatedEntity<TimeZoneDefinition>("lk_timezonerule_timezonedefinitionid", null); }
            set
            {
                this.OnPropertyChanging("lk_timezonerule_timezonedefinitionid");
                this.SetRelatedEntity<TimeZoneDefinition>("lk_timezonerule_timezonedefinitionid", null, value);
                this.OnPropertyChanged("lk_timezonerule_timezonedefinitionid");
            }
        }
    }
}