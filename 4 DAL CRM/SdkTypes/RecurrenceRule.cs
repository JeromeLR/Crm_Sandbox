namespace __4_DAL_CRM
{
    /// <summary>
    /// Recurrence Rule represents the pattern of incidence of recurring entities.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("recurrencerule")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class RecurrenceRule : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public RecurrenceRule() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "recurrencerule";

        public const int EntityTypeCode = 4250;

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
        /// Unique identifier of the user who created the recurrence rule.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby"); }
        }

        /// <summary>
        /// Date and time when the recurrence rule was created.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
        public System.Nullable<System.DateTime> CreatedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who created the recurrence rule.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        /// The day of the month on which the recurring appointment or task occurs.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("dayofmonth")]
        public System.Nullable<int> DayOfMonth
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("dayofmonth"); }
            set
            {
                this.OnPropertyChanging("DayOfMonth");
                this.SetAttributeValue("dayofmonth", value);
                this.OnPropertyChanged("DayOfMonth");
            }
        }

        /// <summary>
        /// Bitmask representing the days of the week on which the recurring appointment or task occurs.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("daysofweekmask")]
        public System.Nullable<int> DaysOfWeekMask
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("daysofweekmask"); }
            set
            {
                this.OnPropertyChanging("DaysOfWeekMask");
                this.SetAttributeValue("daysofweekmask", value);
                this.OnPropertyChanged("DaysOfWeekMask");
            }
        }

        /// <summary>
        /// Duration of the recurrence pattern in minutes.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("duration")]
        public System.Nullable<int> Duration
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("duration"); }
            set
            {
                this.OnPropertyChanging("Duration");
                this.SetAttributeValue("duration", value);
                this.OnPropertyChanged("Duration");
            }
        }

        /// <summary>
        /// The actual end date for expansion of the recurrence pattern.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("effectiveenddate")]
        public System.Nullable<System.DateTime> EffectiveEndDate
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("effectiveenddate"); }
            set
            {
                this.OnPropertyChanging("EffectiveEndDate");
                this.SetAttributeValue("effectiveenddate", value);
                this.OnPropertyChanged("EffectiveEndDate");
            }
        }

        /// <summary>
        /// The actual start date for expansion of the recurrence pattern.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("effectivestartdate")]
        public System.Nullable<System.DateTime> EffectiveStartDate
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("effectivestartdate"); }
            set
            {
                this.OnPropertyChanging("EffectiveStartDate");
                this.SetAttributeValue("effectivestartdate", value);
                this.OnPropertyChanged("EffectiveStartDate");
            }
        }

        /// <summary>
        /// End time of the associated activity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("endtime")]
        public System.Nullable<System.DateTime> EndTime
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("endtime"); }
            set
            {
                this.OnPropertyChanging("EndTime");
                this.SetAttributeValue("endtime", value);
                this.OnPropertyChanged("EndTime");
            }
        }

        /// <summary>
        /// First day Of week for the recurrence pattern.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("firstdayofweek")]
        public System.Nullable<int> FirstDayOfWeek
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("firstdayofweek"); }
            set
            {
                this.OnPropertyChanging("FirstDayOfWeek");
                this.SetAttributeValue("firstdayofweek", value);
                this.OnPropertyChanged("FirstDayOfWeek");
            }
        }

        /// <summary>
        /// Specifies the count for which the recurrence pattern is valid for a given interval.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("instance")]
        public Microsoft.Xrm.Sdk.OptionSetValue Instance
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("instance"); }
            set
            {
                this.OnPropertyChanging("Instance");
                this.SetAttributeValue("instance", value);
                this.OnPropertyChanged("Instance");
            }
        }

        /// <summary>
        /// Number of units of a given recurrence type between occurrences.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("interval")]
        public System.Nullable<int> Interval
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("interval"); }
            set
            {
                this.OnPropertyChanging("Interval");
                this.SetAttributeValue("interval", value);
                this.OnPropertyChanged("Interval");
            }
        }

        /// <summary>
        /// Specifies whether the monthly recurrence pattern is Nth monthly, valid only for monthly recurrence.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isnthmonthly")]
        public System.Nullable<bool> IsNthMonthly
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("isnthmonthly"); }
            set
            {
                this.OnPropertyChanging("IsNthMonthly");
                this.SetAttributeValue("isnthmonthly", value);
                this.OnPropertyChanged("IsNthMonthly");
            }
        }

        /// <summary>
        /// Specifies whether the yearly recurrence pattern is Nth yearly, valid only for yearly recurrence.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isnthyearly")]
        public System.Nullable<bool> IsNthYearly
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("isnthyearly"); }
            set
            {
                this.OnPropertyChanging("IsNthYearly");
                this.SetAttributeValue("isnthyearly", value);
                this.OnPropertyChanged("IsNthYearly");
            }
        }

        /// <summary>
        /// Valid only for task type recurrence,indicates whether task should be regenerated.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isregenerate")]
        public System.Nullable<bool> IsRegenerate
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("isregenerate"); }
            set
            {
                this.OnPropertyChanging("IsRegenerate");
                this.SetAttributeValue("isregenerate", value);
                this.OnPropertyChanged("IsRegenerate");
            }
        }

        /// <summary>
        /// Specifies whether the weekly recurrence pattern is actually a daily every weekday pattern, valid only for weekly recurrence.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isweekdaypattern")]
        public System.Nullable<bool> IsWeekDayPattern
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("isweekdaypattern"); }
            set
            {
                this.OnPropertyChanging("IsWeekDayPattern");
                this.SetAttributeValue("isweekdaypattern", value);
                this.OnPropertyChanged("IsWeekDayPattern");
            }
        }

        /// <summary>
        /// Unique identifier of the user who last modified the recurrence rule.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby"); }
        }

        /// <summary>
        /// Date and time when the recurrence rule was last modified.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
        public System.Nullable<System.DateTime> ModifiedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who modified the recurrence rule.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        /// Specifies the month of the year valid for the recurrence pattern.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("monthofyear")]
        public Microsoft.Xrm.Sdk.OptionSetValue MonthOfYear
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("monthofyear"); }
            set
            {
                this.OnPropertyChanging("MonthOfYear");
                this.SetAttributeValue("monthofyear", value);
                this.OnPropertyChanged("MonthOfYear");
            }
        }

        /// <summary>
        /// Unique identifier of the object with which the recurrence rule is associated.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
        public Microsoft.Xrm.Sdk.EntityReference ObjectId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("objectid"); }
            set
            {
                this.OnPropertyChanging("ObjectId");
                this.SetAttributeValue("objectid", value);
                this.OnPropertyChanged("ObjectId");
            }
        }

        /// <summary>
        /// Number of occurrences of the recurrence pattern.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("occurrences")]
        public System.Nullable<int> Occurrences
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("occurrences"); }
            set
            {
                this.OnPropertyChanging("Occurrences");
                this.SetAttributeValue("occurrences", value);
                this.OnPropertyChanged("Occurrences");
            }
        }

        /// <summary>
        /// Unique identifier of the user or team who owns the recurrence rule.
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
        /// Unique identifier of the business unit that owns the recurrence rule.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
        public Microsoft.Xrm.Sdk.EntityReference OwningBusinessUnit
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningbusinessunit"); }
        }

        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
        public Microsoft.Xrm.Sdk.EntityReference OwningTeam
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningteam"); }
        }

        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
        public Microsoft.Xrm.Sdk.EntityReference OwningUser
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owninguser"); }
        }

        /// <summary>
        /// End date of the Recurrence Range.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("patternenddate")]
        public System.Nullable<System.DateTime> PatternEndDate
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("patternenddate"); }
            set
            {
                this.OnPropertyChanging("PatternEndDate");
                this.SetAttributeValue("patternenddate", value);
                this.OnPropertyChanged("PatternEndDate");
            }
        }

        /// <summary>
        /// Pattern End Type of a recurring series.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("patternendtype")]
        public Microsoft.Xrm.Sdk.OptionSetValue PatternEndType
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("patternendtype"); }
            set
            {
                this.OnPropertyChanging("PatternEndType");
                this.SetAttributeValue("patternendtype", value);
                this.OnPropertyChanged("PatternEndType");
            }
        }

        /// <summary>
        /// Start date of the Recurrence Range.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("patternstartdate")]
        public System.Nullable<System.DateTime> PatternStartDate
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("patternstartdate"); }
            set
            {
                this.OnPropertyChanging("PatternStartDate");
                this.SetAttributeValue("patternstartdate", value);
                this.OnPropertyChanged("PatternStartDate");
            }
        }

        /// <summary>
        /// Type of Recurrence.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("recurrencepatterntype")]
        public Microsoft.Xrm.Sdk.OptionSetValue RecurrencePatternType
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("recurrencepatterntype"); }
            set
            {
                this.OnPropertyChanging("RecurrencePatternType");
                this.SetAttributeValue("recurrencepatterntype", value);
                this.OnPropertyChanged("RecurrencePatternType");
            }
        }

        /// <summary>
        /// Unique identifier of the entity associated with recurrence rule.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ruleid")]
        public System.Nullable<System.Guid> RuleId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("ruleid"); }
            set
            {
                this.OnPropertyChanging("RuleId");
                this.SetAttributeValue("ruleid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("RuleId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ruleid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.RuleId = value; }
        }

        /// <summary>
        /// Start time of the recurring activity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("starttime")]
        public System.Nullable<System.DateTime> StartTime
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("starttime"); }
            set
            {
                this.OnPropertyChanging("StartTime");
                this.SetAttributeValue("starttime", value);
                this.OnPropertyChanged("StartTime");
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
        /// 1:N recurrencerule_recurringappointmentmaster
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("recurrencerule_recurringappointmentmaster")]
        public System.Collections.Generic.IEnumerable<RecurringAppointmentMaster> recurrencerule_recurringappointmentmaster
        {
            get { return this.GetRelatedEntities<RecurringAppointmentMaster>("recurrencerule_recurringappointmentmaster", null); }
            set
            {
                this.OnPropertyChanging("recurrencerule_recurringappointmentmaster");
                this.SetRelatedEntities<RecurringAppointmentMaster>("recurrencerule_recurringappointmentmaster", null, value);
                this.OnPropertyChanged("recurrencerule_recurringappointmentmaster");
            }
        }

        /// <summary>
        /// N:1 activity_pointer_recurrencerule
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("activity_pointer_recurrencerule")]
        public ActivityPointer activity_pointer_recurrencerule
        {
            get { return this.GetRelatedEntity<ActivityPointer>("activity_pointer_recurrencerule", null); }
            set
            {
                this.OnPropertyChanging("activity_pointer_recurrencerule");
                this.SetRelatedEntity<ActivityPointer>("activity_pointer_recurrencerule", null, value);
                this.OnPropertyChanged("activity_pointer_recurrencerule");
            }
        }

        /// <summary>
        /// N:1 business_unit_recurrencerule
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_recurrencerule")]
        public BusinessUnit business_unit_recurrencerule
        {
            get { return this.GetRelatedEntity<BusinessUnit>("business_unit_recurrencerule", null); }
        }

        /// <summary>
        /// N:1 lk_recurrencerule_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_recurrencerule_createdby")]
        public SystemUser lk_recurrencerule_createdby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_recurrencerule_createdby", null); }
        }

        /// <summary>
        /// N:1 lk_recurrencerule_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_recurrencerule_modifiedby")]
        public SystemUser lk_recurrencerule_modifiedby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_recurrencerule_modifiedby", null); }
        }

        /// <summary>
        /// N:1 lk_recurrencerulebase_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_recurrencerulebase_createdonbehalfby")]
        public SystemUser lk_recurrencerulebase_createdonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_recurrencerulebase_createdonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_recurrencerulebase_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_recurrencerulebase_modifiedonbehalfby")]
        public SystemUser lk_recurrencerulebase_modifiedonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_recurrencerulebase_modifiedonbehalfby", null); }
        }
    }
}