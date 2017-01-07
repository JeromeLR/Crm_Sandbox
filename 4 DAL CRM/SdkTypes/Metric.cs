namespace __4_DAL_CRM
{
    /// <summary>
    /// Type of measurement for a goal, such as money amount or count.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("metric")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class Metric : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public Metric() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "metric";

        public const int EntityTypeCode = 9603;

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
        /// Data type of the amount.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("amountdatatype")]
        public Microsoft.Xrm.Sdk.OptionSetValue AmountDataType
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("amountdatatype"); }
            set
            {
                this.OnPropertyChanging("AmountDataType");
                this.SetAttributeValue("amountdatatype", value);
                this.OnPropertyChanged("AmountDataType");
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
        /// Unique identifier of the delegate user who created the record.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        /// Description of the goal metric.
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
        /// Information that indicates whether the metric type is Count or Amount.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isamount")]
        public System.Nullable<bool> IsAmount
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("isamount"); }
            set
            {
                this.OnPropertyChanging("IsAmount");
                this.SetAttributeValue("isamount", value);
                this.OnPropertyChanged("IsAmount");
            }
        }

        /// <summary>
        /// Indicates whether the goal metric tracks stretch targets.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isstretchtracked")]
        public System.Nullable<bool> IsStretchTracked
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("isstretchtracked"); }
            set
            {
                this.OnPropertyChanging("IsStretchTracked");
                this.SetAttributeValue("isstretchtracked", value);
                this.OnPropertyChanged("IsStretchTracked");
            }
        }

        /// <summary>
        /// Unique identifier of the goal metric.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("metricid")]
        public System.Nullable<System.Guid> MetricId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("metricid"); }
            set
            {
                this.OnPropertyChanging("MetricId");
                this.SetAttributeValue("metricid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("MetricId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("metricid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.MetricId = value; }
        }

        /// <summary>
        /// Unique identifier of the user who modified the record.
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
        /// Unique identifier of the delegate user who modified the record.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        /// Name of the goal metric.
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
        /// Unique identifier of the organization.
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
        /// Status of the goal metric.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
        public System.Nullable<MetricState> StateCode
        {
            get
            {
                Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
                if ((optionSet != null))
                {
                    return ((MetricState) (System.Enum.ToObject(typeof(MetricState), optionSet.Value)));
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// Reason for the status of the goal metric.
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
        /// Version number of the goal metric.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
        public System.Nullable<long> VersionNumber
        {
            get { return this.GetAttributeValue<System.Nullable<long>>("versionnumber"); }
        }

        /// <summary>
        /// 1:N metric_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("metric_AsyncOperations")]
        public System.Collections.Generic.IEnumerable<AsyncOperation> metric_AsyncOperations
        {
            get { return this.GetRelatedEntities<AsyncOperation>("metric_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("metric_AsyncOperations");
                this.SetRelatedEntities<AsyncOperation>("metric_AsyncOperations", null, value);
                this.OnPropertyChanged("metric_AsyncOperations");
            }
        }

        /// <summary>
        /// 1:N metric_goal
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("metric_goal")]
        public System.Collections.Generic.IEnumerable<Goal> metric_goal
        {
            get { return this.GetRelatedEntities<Goal>("metric_goal", null); }
            set
            {
                this.OnPropertyChanging("metric_goal");
                this.SetRelatedEntities<Goal>("metric_goal", null, value);
                this.OnPropertyChanged("metric_goal");
            }
        }

        /// <summary>
        /// 1:N metric_ProcessSessions
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("metric_ProcessSessions")]
        public System.Collections.Generic.IEnumerable<ProcessSession> metric_ProcessSessions
        {
            get { return this.GetRelatedEntities<ProcessSession>("metric_ProcessSessions", null); }
            set
            {
                this.OnPropertyChanging("metric_ProcessSessions");
                this.SetRelatedEntities<ProcessSession>("metric_ProcessSessions", null, value);
                this.OnPropertyChanged("metric_ProcessSessions");
            }
        }

        /// <summary>
        /// 1:N metric_rollupfield
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("metric_rollupfield")]
        public System.Collections.Generic.IEnumerable<RollupField> metric_rollupfield
        {
            get { return this.GetRelatedEntities<RollupField>("metric_rollupfield", null); }
            set
            {
                this.OnPropertyChanging("metric_rollupfield");
                this.SetRelatedEntities<RollupField>("metric_rollupfield", null, value);
                this.OnPropertyChanged("metric_rollupfield");
            }
        }

        /// <summary>
        /// 1:N userentityinstancedata_metric
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_metric")]
        public System.Collections.Generic.IEnumerable<UserEntityInstanceData> userentityinstancedata_metric
        {
            get { return this.GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_metric", null); }
            set
            {
                this.OnPropertyChanging("userentityinstancedata_metric");
                this.SetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_metric", null, value);
                this.OnPropertyChanged("userentityinstancedata_metric");
            }
        }

        /// <summary>
        /// N:1 lk_metric_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_metric_createdby")]
        public SystemUser lk_metric_createdby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_metric_createdby", null); }
        }

        /// <summary>
        /// N:1 lk_metric_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_metric_createdonbehalfby")]
        public SystemUser lk_metric_createdonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_metric_createdonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_metric_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_metric_modifiedby")]
        public SystemUser lk_metric_modifiedby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_metric_modifiedby", null); }
        }

        /// <summary>
        /// N:1 lk_metric_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_metric_modifiedonbehalfby")]
        public SystemUser lk_metric_modifiedonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_metric_modifiedonbehalfby", null); }
        }

        /// <summary>
        /// N:1 organization_metric
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_metric")]
        public Organization organization_metric
        {
            get { return this.GetRelatedEntity<Organization>("organization_metric", null); }
        }
    }
}