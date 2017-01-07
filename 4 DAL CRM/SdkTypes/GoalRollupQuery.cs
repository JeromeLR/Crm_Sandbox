namespace __4_DAL_CRM
{
    /// <summary>
    /// Query that is used to filter the results of the goal rollup.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("goalrollupquery")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class GoalRollupQuery : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public GoalRollupQuery() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "goalrollupquery";

        public const int EntityTypeCode = 9602;

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
        /// String that specifies the condition criteria in FetchXML.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("fetchxml")]
        public string FetchXml
        {
            get { return this.GetAttributeValue<string>("fetchxml"); }
            set
            {
                this.OnPropertyChanging("FetchXml");
                this.SetAttributeValue("fetchxml", value);
                this.OnPropertyChanged("FetchXml");
            }
        }

        /// <summary>
        /// Unique identifier of the rollup query.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("goalrollupqueryid")]
        public System.Nullable<System.Guid> GoalRollupQueryId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("goalrollupqueryid"); }
            set
            {
                this.OnPropertyChanging("GoalRollupQueryId");
                this.SetAttributeValue("goalrollupqueryid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("GoalRollupQueryId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("goalrollupqueryid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.GoalRollupQueryId = value; }
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
        /// Type a descriptive name for the goal rollup query.
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
        /// Unique identifier of the business unit that owns the record.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
        public Microsoft.Xrm.Sdk.EntityReference OwningBusinessUnit
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningbusinessunit"); }
        }

        /// <summary>
        /// Unique identifier of the team who owns the record.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
        public Microsoft.Xrm.Sdk.EntityReference OwningTeam
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningteam"); }
        }

        /// <summary>
        /// Unique identifier of the user who owns the record.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
        public Microsoft.Xrm.Sdk.EntityReference OwningUser
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owninguser"); }
        }

        /// <summary>
        /// Enter the record type of the rollup query.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("queryentitytype")]
        public string QueryEntityType
        {
            get { return this.GetAttributeValue<string>("queryentitytype"); }
            set
            {
                this.OnPropertyChanging("QueryEntityType");
                this.SetAttributeValue("queryentitytype", value);
                this.OnPropertyChanged("QueryEntityType");
            }
        }

        /// <summary>
        /// Shows whether the goal rollup query is active or inactive.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
        public System.Nullable<GoalRollupQueryState> StateCode
        {
            get
            {
                Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
                if ((optionSet != null))
                {
                    return ((GoalRollupQueryState) (System.Enum.ToObject(typeof(GoalRollupQueryState), optionSet.Value)));
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// Select the goal rollup query's status.
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
        /// Version number of the goal rollup query.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
        public System.Nullable<long> VersionNumber
        {
            get { return this.GetAttributeValue<System.Nullable<long>>("versionnumber"); }
        }

        /// <summary>
        /// 1:N goal_rollupquery_actualdecimal
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("goal_rollupquery_actualdecimal")]
        public System.Collections.Generic.IEnumerable<Goal> goal_rollupquery_actualdecimal
        {
            get { return this.GetRelatedEntities<Goal>("goal_rollupquery_actualdecimal", null); }
            set
            {
                this.OnPropertyChanging("goal_rollupquery_actualdecimal");
                this.SetRelatedEntities<Goal>("goal_rollupquery_actualdecimal", null, value);
                this.OnPropertyChanged("goal_rollupquery_actualdecimal");
            }
        }

        /// <summary>
        /// 1:N goal_rollupquery_actualmoney
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("goal_rollupquery_actualmoney")]
        public System.Collections.Generic.IEnumerable<Goal> goal_rollupquery_actualmoney
        {
            get { return this.GetRelatedEntities<Goal>("goal_rollupquery_actualmoney", null); }
            set
            {
                this.OnPropertyChanging("goal_rollupquery_actualmoney");
                this.SetRelatedEntities<Goal>("goal_rollupquery_actualmoney", null, value);
                this.OnPropertyChanged("goal_rollupquery_actualmoney");
            }
        }

        /// <summary>
        /// 1:N goal_rollupquery_customdecimal
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("goal_rollupquery_customdecimal")]
        public System.Collections.Generic.IEnumerable<Goal> goal_rollupquery_customdecimal
        {
            get { return this.GetRelatedEntities<Goal>("goal_rollupquery_customdecimal", null); }
            set
            {
                this.OnPropertyChanging("goal_rollupquery_customdecimal");
                this.SetRelatedEntities<Goal>("goal_rollupquery_customdecimal", null, value);
                this.OnPropertyChanged("goal_rollupquery_customdecimal");
            }
        }

        /// <summary>
        /// 1:N goal_rollupquery_customint
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("goal_rollupquery_customint")]
        public System.Collections.Generic.IEnumerable<Goal> goal_rollupquery_customint
        {
            get { return this.GetRelatedEntities<Goal>("goal_rollupquery_customint", null); }
            set
            {
                this.OnPropertyChanging("goal_rollupquery_customint");
                this.SetRelatedEntities<Goal>("goal_rollupquery_customint", null, value);
                this.OnPropertyChanged("goal_rollupquery_customint");
            }
        }

        /// <summary>
        /// 1:N goal_rollupquery_custommoney
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("goal_rollupquery_custommoney")]
        public System.Collections.Generic.IEnumerable<Goal> goal_rollupquery_custommoney
        {
            get { return this.GetRelatedEntities<Goal>("goal_rollupquery_custommoney", null); }
            set
            {
                this.OnPropertyChanging("goal_rollupquery_custommoney");
                this.SetRelatedEntities<Goal>("goal_rollupquery_custommoney", null, value);
                this.OnPropertyChanged("goal_rollupquery_custommoney");
            }
        }

        /// <summary>
        /// 1:N goal_rollupquery_inprogressdecimal
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("goal_rollupquery_inprogressdecimal")]
        public System.Collections.Generic.IEnumerable<Goal> goal_rollupquery_inprogressdecimal
        {
            get { return this.GetRelatedEntities<Goal>("goal_rollupquery_inprogressdecimal", null); }
            set
            {
                this.OnPropertyChanging("goal_rollupquery_inprogressdecimal");
                this.SetRelatedEntities<Goal>("goal_rollupquery_inprogressdecimal", null, value);
                this.OnPropertyChanged("goal_rollupquery_inprogressdecimal");
            }
        }

        /// <summary>
        /// 1:N goal_rollupquery_inprogressint
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("goal_rollupquery_inprogressint")]
        public System.Collections.Generic.IEnumerable<Goal> goal_rollupquery_inprogressint
        {
            get { return this.GetRelatedEntities<Goal>("goal_rollupquery_inprogressint", null); }
            set
            {
                this.OnPropertyChanging("goal_rollupquery_inprogressint");
                this.SetRelatedEntities<Goal>("goal_rollupquery_inprogressint", null, value);
                this.OnPropertyChanged("goal_rollupquery_inprogressint");
            }
        }

        /// <summary>
        /// 1:N goal_rollupquery_inprogressmoney
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("goal_rollupquery_inprogressmoney")]
        public System.Collections.Generic.IEnumerable<Goal> goal_rollupquery_inprogressmoney
        {
            get { return this.GetRelatedEntities<Goal>("goal_rollupquery_inprogressmoney", null); }
            set
            {
                this.OnPropertyChanging("goal_rollupquery_inprogressmoney");
                this.SetRelatedEntities<Goal>("goal_rollupquery_inprogressmoney", null, value);
                this.OnPropertyChanged("goal_rollupquery_inprogressmoney");
            }
        }

        /// <summary>
        /// 1:N goalrollupquery_actualint
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("goalrollupquery_actualint")]
        public System.Collections.Generic.IEnumerable<Goal> goalrollupquery_actualint
        {
            get { return this.GetRelatedEntities<Goal>("goalrollupquery_actualint", null); }
            set
            {
                this.OnPropertyChanging("goalrollupquery_actualint");
                this.SetRelatedEntities<Goal>("goalrollupquery_actualint", null, value);
                this.OnPropertyChanged("goalrollupquery_actualint");
            }
        }

        /// <summary>
        /// 1:N goalrollupquery_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("goalrollupquery_AsyncOperations")]
        public System.Collections.Generic.IEnumerable<AsyncOperation> goalrollupquery_AsyncOperations
        {
            get { return this.GetRelatedEntities<AsyncOperation>("goalrollupquery_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("goalrollupquery_AsyncOperations");
                this.SetRelatedEntities<AsyncOperation>("goalrollupquery_AsyncOperations", null, value);
                this.OnPropertyChanged("goalrollupquery_AsyncOperations");
            }
        }

        /// <summary>
        /// 1:N GoalRollupQuery_DuplicateBaseRecord
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("GoalRollupQuery_DuplicateBaseRecord")]
        public System.Collections.Generic.IEnumerable<DuplicateRecord> GoalRollupQuery_DuplicateBaseRecord
        {
            get { return this.GetRelatedEntities<DuplicateRecord>("GoalRollupQuery_DuplicateBaseRecord", null); }
            set
            {
                this.OnPropertyChanging("GoalRollupQuery_DuplicateBaseRecord");
                this.SetRelatedEntities<DuplicateRecord>("GoalRollupQuery_DuplicateBaseRecord", null, value);
                this.OnPropertyChanged("GoalRollupQuery_DuplicateBaseRecord");
            }
        }

        /// <summary>
        /// 1:N GoalRollupQuery_DuplicateMatchingRecord
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("GoalRollupQuery_DuplicateMatchingRecord")]
        public System.Collections.Generic.IEnumerable<DuplicateRecord> GoalRollupQuery_DuplicateMatchingRecord
        {
            get { return this.GetRelatedEntities<DuplicateRecord>("GoalRollupQuery_DuplicateMatchingRecord", null); }
            set
            {
                this.OnPropertyChanging("GoalRollupQuery_DuplicateMatchingRecord");
                this.SetRelatedEntities<DuplicateRecord>("GoalRollupQuery_DuplicateMatchingRecord", null, value);
                this.OnPropertyChanged("GoalRollupQuery_DuplicateMatchingRecord");
            }
        }

        /// <summary>
        /// 1:N goalrollupquery_ProcessSessions
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("goalrollupquery_ProcessSessions")]
        public System.Collections.Generic.IEnumerable<ProcessSession> goalrollupquery_ProcessSessions
        {
            get { return this.GetRelatedEntities<ProcessSession>("goalrollupquery_ProcessSessions", null); }
            set
            {
                this.OnPropertyChanging("goalrollupquery_ProcessSessions");
                this.SetRelatedEntities<ProcessSession>("goalrollupquery_ProcessSessions", null, value);
                this.OnPropertyChanged("goalrollupquery_ProcessSessions");
            }
        }

        /// <summary>
        /// 1:N userentityinstancedata_goalrollupquery
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_goalrollupquery")]
        public System.Collections.Generic.IEnumerable<UserEntityInstanceData> userentityinstancedata_goalrollupquery
        {
            get { return this.GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_goalrollupquery", null); }
            set
            {
                this.OnPropertyChanging("userentityinstancedata_goalrollupquery");
                this.SetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_goalrollupquery", null, value);
                this.OnPropertyChanged("userentityinstancedata_goalrollupquery");
            }
        }

        /// <summary>
        /// N:1 business_unit_goalrollupquery
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_goalrollupquery")]
        public BusinessUnit business_unit_goalrollupquery
        {
            get { return this.GetRelatedEntity<BusinessUnit>("business_unit_goalrollupquery", null); }
        }

        /// <summary>
        /// N:1 lk_goalrollupquery_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_goalrollupquery_createdby")]
        public SystemUser lk_goalrollupquery_createdby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_goalrollupquery_createdby", null); }
        }

        /// <summary>
        /// N:1 lk_goalrollupquery_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_goalrollupquery_createdonbehalfby")]
        public SystemUser lk_goalrollupquery_createdonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_goalrollupquery_createdonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_goalrollupquery_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_goalrollupquery_modifiedby")]
        public SystemUser lk_goalrollupquery_modifiedby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_goalrollupquery_modifiedby", null); }
        }

        /// <summary>
        /// N:1 lk_goalrollupquery_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_goalrollupquery_modifiedonbehalfby")]
        public SystemUser lk_goalrollupquery_modifiedonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_goalrollupquery_modifiedonbehalfby", null); }
        }

        /// <summary>
        /// N:1 team_goalrollupquery
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_goalrollupquery")]
        public Team team_goalrollupquery
        {
            get { return this.GetRelatedEntity<Team>("team_goalrollupquery", null); }
        }
    }
}