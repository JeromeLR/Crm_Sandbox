namespace __4_DAL_CRM
{
    /// <summary>
    /// Field to be rolled up to calculate the actual and in-progress values against the goal.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("rollupfield")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class RollupField : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public RollupField() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "rollupfield";

        public const int EntityTypeCode = 9604;

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
        /// Select a date field for the selected record type, such as Actual Closed Date for the Opportunity record type. A record participates in the goal rollup, if the selected date falls between the start date and the end date for the goal.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("dateattribute")]
        public string DateAttribute
        {
            get { return this.GetAttributeValue<string>("dateattribute"); }
            set
            {
                this.OnPropertyChanging("DateAttribute");
                this.SetAttributeValue("dateattribute", value);
                this.OnPropertyChanged("DateAttribute");
            }
        }

        /// <summary>
        /// Select the record type that contains the date field that will be considered while rolling up data to the goal.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entityfordateattribute")]
        public string EntityForDateAttribute
        {
            get { return this.GetAttributeValue<string>("entityfordateattribute"); }
            set
            {
                this.OnPropertyChanging("EntityForDateAttribute");
                this.SetAttributeValue("entityfordateattribute", value);
                this.OnPropertyChanged("EntityForDateAttribute");
            }
        }

        /// <summary>
        /// Select a rollup field where the metric rollup data will be displayed in the goal. The options are an integer or money, depending on the Metric Type you chose for the goal metric.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("goalattribute")]
        public string GoalAttribute
        {
            get { return this.GetAttributeValue<string>("goalattribute"); }
            set
            {
                this.OnPropertyChanging("GoalAttribute");
                this.SetAttributeValue("goalattribute", value);
                this.OnPropertyChanged("GoalAttribute");
            }
        }

        /// <summary>
        /// Sequence number of the import that created this record.
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
        /// Tells whether the state or status belongs to the parent entity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isstateparententityattribute")]
        public System.Nullable<bool> IsStateParentEntityAttribute
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("isstateparententityattribute"); }
            set
            {
                this.OnPropertyChanging("IsStateParentEntityAttribute");
                this.SetAttributeValue("isstateparententityattribute", value);
                this.OnPropertyChanged("IsStateParentEntityAttribute");
            }
        }

        /// <summary>
        /// Unique identifier of the goal metric associated with the rollup field.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("metricid")]
        public Microsoft.Xrm.Sdk.EntityReference MetricId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("metricid"); }
            set
            {
                this.OnPropertyChanging("MetricId");
                this.SetAttributeValue("metricid", value);
                this.OnPropertyChanged("MetricId");
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
        /// Choose the ID of the organization that the record is associated with.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
        public Microsoft.Xrm.Sdk.EntityReference OrganizationId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("organizationid"); }
        }

        /// <summary>
        /// Unique identifier of the rollup field.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rollupfieldid")]
        public System.Nullable<System.Guid> RollupFieldId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("rollupfieldid"); }
            set
            {
                this.OnPropertyChanging("RollupFieldId");
                this.SetAttributeValue("rollupfieldid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("RollupFieldId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rollupfieldid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.RollupFieldId = value; }
        }

        /// <summary>
        /// Type the name of the field that the data for the goal rolls up from.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sourceattribute")]
        public string SourceAttribute
        {
            get { return this.GetAttributeValue<string>("sourceattribute"); }
            set
            {
                this.OnPropertyChanging("SourceAttribute");
                this.SetAttributeValue("sourceattribute", value);
                this.OnPropertyChanged("SourceAttribute");
            }
        }

        /// <summary>
        /// Type the name of the record type (entity) that the data for the goal must roll up from.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sourceentity")]
        public string SourceEntity
        {
            get { return this.GetAttributeValue<string>("sourceentity"); }
            set
            {
                this.OnPropertyChanging("SourceEntity");
                this.SetAttributeValue("sourceentity", value);
                this.OnPropertyChanged("SourceEntity");
            }
        }

        /// <summary>
        /// Select the state of the records you want to use as the source of the rollup data for the metric.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sourcestate")]
        public System.Nullable<int> SourceState
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("sourcestate"); }
            set
            {
                this.OnPropertyChanging("SourceState");
                this.SetAttributeValue("sourcestate", value);
                this.OnPropertyChanged("SourceState");
            }
        }

        /// <summary>
        /// Select the status of the records you want to use as the source of the rollup data for the metric.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sourcestatus")]
        public System.Nullable<int> SourceStatus
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("sourcestatus"); }
            set
            {
                this.OnPropertyChanging("SourceStatus");
                this.SetAttributeValue("sourcestatus", value);
                this.OnPropertyChanged("SourceStatus");
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
        /// Version number of the rollup field.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
        public System.Nullable<long> VersionNumber
        {
            get { return this.GetAttributeValue<System.Nullable<long>>("versionnumber"); }
        }

        /// <summary>
        /// 1:N rollupfield_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("rollupfield_AsyncOperations")]
        public System.Collections.Generic.IEnumerable<AsyncOperation> rollupfield_AsyncOperations
        {
            get { return this.GetRelatedEntities<AsyncOperation>("rollupfield_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("rollupfield_AsyncOperations");
                this.SetRelatedEntities<AsyncOperation>("rollupfield_AsyncOperations", null, value);
                this.OnPropertyChanged("rollupfield_AsyncOperations");
            }
        }

        /// <summary>
        /// 1:N rollupfield_ProcessSessions
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("rollupfield_ProcessSessions")]
        public System.Collections.Generic.IEnumerable<ProcessSession> rollupfield_ProcessSessions
        {
            get { return this.GetRelatedEntities<ProcessSession>("rollupfield_ProcessSessions", null); }
            set
            {
                this.OnPropertyChanging("rollupfield_ProcessSessions");
                this.SetRelatedEntities<ProcessSession>("rollupfield_ProcessSessions", null, value);
                this.OnPropertyChanged("rollupfield_ProcessSessions");
            }
        }

        /// <summary>
        /// 1:N userentityinstancedata_rollupfield
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_rollupfield")]
        public System.Collections.Generic.IEnumerable<UserEntityInstanceData> userentityinstancedata_rollupfield
        {
            get { return this.GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_rollupfield", null); }
            set
            {
                this.OnPropertyChanging("userentityinstancedata_rollupfield");
                this.SetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_rollupfield", null, value);
                this.OnPropertyChanged("userentityinstancedata_rollupfield");
            }
        }

        /// <summary>
        /// N:1 lk_rollupfield_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_rollupfield_createdby")]
        public SystemUser lk_rollupfield_createdby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_rollupfield_createdby", null); }
        }

        /// <summary>
        /// N:1 lk_rollupfield_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_rollupfield_createdonbehalfby")]
        public SystemUser lk_rollupfield_createdonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_rollupfield_createdonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_rollupfield_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_rollupfield_modifiedby")]
        public SystemUser lk_rollupfield_modifiedby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_rollupfield_modifiedby", null); }
        }

        /// <summary>
        /// N:1 lk_rollupfield_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_rollupfield_modifiedonbehalfby")]
        public SystemUser lk_rollupfield_modifiedonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_rollupfield_modifiedonbehalfby", null); }
        }

        /// <summary>
        /// N:1 metric_rollupfield
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("metricid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("metric_rollupfield")]
        public Metric metric_rollupfield
        {
            get { return this.GetRelatedEntity<Metric>("metric_rollupfield", null); }
            set
            {
                this.OnPropertyChanging("metric_rollupfield");
                this.SetRelatedEntity<Metric>("metric_rollupfield", null, value);
                this.OnPropertyChanged("metric_rollupfield");
            }
        }
    }
}