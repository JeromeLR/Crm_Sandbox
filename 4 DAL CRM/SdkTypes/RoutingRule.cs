namespace __4_DAL_CRM
{
    /// <summary>
    /// Define Routing Rule to route cases to right people at the right time
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("routingrule")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class RoutingRule : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public RoutingRule() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "routingrule";

        public const int EntityTypeCode = 8181;

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
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("componentstate")]
        public Microsoft.Xrm.Sdk.OptionSetValue ComponentState
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("componentstate"); }
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
        /// Type a short description about the objective of the routing rule.
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
        /// Exchange rate for the currency associated with the queue with respect to the base currency.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("exchangerate")]
        public System.Nullable<decimal> ExchangeRate
        {
            get { return this.GetAttributeValue<System.Nullable<decimal>>("exchangerate"); }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ismanaged")]
        public System.Nullable<bool> IsManaged
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("ismanaged"); }
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
        /// Name of the Routing Rule.
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
        ///  the organization associated with the Routing Rule 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
        public Microsoft.Xrm.Sdk.EntityReference OrganizationId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("organizationid"); }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("overwritetime")]
        public System.Nullable<System.DateTime> OverwriteTime
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("overwritetime"); }
        }

        /// <summary>
        /// For internal use only.
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
        /// For internal use only
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
        public Microsoft.Xrm.Sdk.EntityReference OwningBusinessUnit
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningbusinessunit"); }
            set
            {
                this.OnPropertyChanging("OwningBusinessUnit");
                this.SetAttributeValue("owningbusinessunit", value);
                this.OnPropertyChanged("OwningBusinessUnit");
            }
        }

        /// <summary>
        /// Unique identifier for the team that owns the record.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
        public Microsoft.Xrm.Sdk.EntityReference OwningTeam
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningteam"); }
            set
            {
                this.OnPropertyChanging("OwningTeam");
                this.SetAttributeValue("owningteam", value);
                this.OnPropertyChanged("OwningTeam");
            }
        }

        /// <summary>
        /// Unique identifier for the user that owns the record.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
        public Microsoft.Xrm.Sdk.EntityReference OwningUser
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owninguser"); }
            set
            {
                this.OnPropertyChanging("OwningUser");
                this.SetAttributeValue("owninguser", value);
                this.OnPropertyChanged("OwningUser");
            }
        }

        /// <summary>
        /// Unique identifier for entity instances
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("routingruleid")]
        public System.Nullable<System.Guid> RoutingRuleId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("routingruleid"); }
            set
            {
                this.OnPropertyChanging("RoutingRuleId");
                this.SetAttributeValue("routingruleid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("RoutingRuleId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("routingruleid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.RoutingRuleId = value; }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("routingruleidunique")]
        public System.Nullable<System.Guid> RoutingRuleIdUnique
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("routingruleidunique"); }
        }

        /// <summary>
        /// Unique identifier of the associated solution.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("solutionid")]
        public System.Nullable<System.Guid> SolutionId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("solutionid"); }
        }

        /// <summary>
        /// Status of the Routing Rule
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
        public System.Nullable<RoutingRuleState> StateCode
        {
            get
            {
                Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
                if ((optionSet != null))
                {
                    return ((RoutingRuleState) (System.Enum.ToObject(typeof(RoutingRuleState), optionSet.Value)));
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// Reason for the status of the Routing Rule
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
        /// Unique identifier of the currency associated with the Routing Rule.
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
        /// Version number of the Routing Rule.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
        public System.Nullable<long> VersionNumber
        {
            get { return this.GetAttributeValue<System.Nullable<long>>("versionnumber"); }
        }

        /// <summary>
        /// Unique identifier for Workflow.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("workflowid")]
        public Microsoft.Xrm.Sdk.EntityReference WorkflowId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("workflowid"); }
            set
            {
                this.OnPropertyChanging("WorkflowId");
                this.SetAttributeValue("workflowid", value);
                this.OnPropertyChanged("WorkflowId");
            }
        }

        /// <summary>
        /// 1:N routingrule_Annotation
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("routingrule_Annotation")]
        public System.Collections.Generic.IEnumerable<Annotation> routingrule_Annotation
        {
            get { return this.GetRelatedEntities<Annotation>("routingrule_Annotation", null); }
            set
            {
                this.OnPropertyChanging("routingrule_Annotation");
                this.SetRelatedEntities<Annotation>("routingrule_Annotation", null, value);
                this.OnPropertyChanged("routingrule_Annotation");
            }
        }

        /// <summary>
        /// 1:N routingrule_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("routingrule_AsyncOperations")]
        public System.Collections.Generic.IEnumerable<AsyncOperation> routingrule_AsyncOperations
        {
            get { return this.GetRelatedEntities<AsyncOperation>("routingrule_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("routingrule_AsyncOperations");
                this.SetRelatedEntities<AsyncOperation>("routingrule_AsyncOperations", null, value);
                this.OnPropertyChanged("routingrule_AsyncOperations");
            }
        }

        /// <summary>
        /// 1:N routingrule_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("routingrule_BulkDeleteFailures")]
        public System.Collections.Generic.IEnumerable<BulkDeleteFailure> routingrule_BulkDeleteFailures
        {
            get { return this.GetRelatedEntities<BulkDeleteFailure>("routingrule_BulkDeleteFailures", null); }
            set
            {
                this.OnPropertyChanging("routingrule_BulkDeleteFailures");
                this.SetRelatedEntities<BulkDeleteFailure>("routingrule_BulkDeleteFailures", null, value);
                this.OnPropertyChanged("routingrule_BulkDeleteFailures");
            }
        }

        /// <summary>
        /// 1:N routingrule_entries
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("routingrule_entries")]
        public System.Collections.Generic.IEnumerable<RoutingRuleItem> routingrule_entries
        {
            get { return this.GetRelatedEntities<RoutingRuleItem>("routingrule_entries", null); }
            set
            {
                this.OnPropertyChanging("routingrule_entries");
                this.SetRelatedEntities<RoutingRuleItem>("routingrule_entries", null, value);
                this.OnPropertyChanged("routingrule_entries");
            }
        }

        /// <summary>
        /// 1:N routingrule_ProcessSessions
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("routingrule_ProcessSessions")]
        public System.Collections.Generic.IEnumerable<ProcessSession> routingrule_ProcessSessions
        {
            get { return this.GetRelatedEntities<ProcessSession>("routingrule_ProcessSessions", null); }
            set
            {
                this.OnPropertyChanging("routingrule_ProcessSessions");
                this.SetRelatedEntities<ProcessSession>("routingrule_ProcessSessions", null, value);
                this.OnPropertyChanged("routingrule_ProcessSessions");
            }
        }

        /// <summary>
        /// 1:N routingrule_userentityinstancedatas
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("routingrule_userentityinstancedatas")]
        public System.Collections.Generic.IEnumerable<UserEntityInstanceData> routingrule_userentityinstancedatas
        {
            get { return this.GetRelatedEntities<UserEntityInstanceData>("routingrule_userentityinstancedatas", null); }
            set
            {
                this.OnPropertyChanging("routingrule_userentityinstancedatas");
                this.SetRelatedEntities<UserEntityInstanceData>("routingrule_userentityinstancedatas", null, value);
                this.OnPropertyChanged("routingrule_userentityinstancedatas");
            }
        }

        /// <summary>
        /// N:1 business_unit_routingrule
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_routingrule")]
        public BusinessUnit business_unit_routingrule
        {
            get { return this.GetRelatedEntity<BusinessUnit>("business_unit_routingrule", null); }
            set
            {
                this.OnPropertyChanging("business_unit_routingrule");
                this.SetRelatedEntity<BusinessUnit>("business_unit_routingrule", null, value);
                this.OnPropertyChanged("business_unit_routingrule");
            }
        }

        /// <summary>
        /// N:1 lk_routingrule_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_routingrule_createdby")]
        public SystemUser lk_routingrule_createdby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_routingrule_createdby", null); }
        }

        /// <summary>
        /// N:1 lk_routingrule_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_routingrule_createdonbehalfby")]
        public SystemUser lk_routingrule_createdonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_routingrule_createdonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_routingrule_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_routingrule_modifiedby")]
        public SystemUser lk_routingrule_modifiedby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_routingrule_modifiedby", null); }
        }

        /// <summary>
        /// N:1 lk_routingrule_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_routingrule_modifiedonbehalfby")]
        public SystemUser lk_routingrule_modifiedonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_routingrule_modifiedonbehalfby", null); }
        }

        /// <summary>
        /// N:1 organization_RoutingRules
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_RoutingRules")]
        public Organization organization_RoutingRules
        {
            get { return this.GetRelatedEntity<Organization>("organization_RoutingRules", null); }
        }

        /// <summary>
        /// N:1 team_routingrule
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_routingrule")]
        public Team team_routingrule
        {
            get { return this.GetRelatedEntity<Team>("team_routingrule", null); }
            set
            {
                this.OnPropertyChanging("team_routingrule");
                this.SetRelatedEntity<Team>("team_routingrule", null, value);
                this.OnPropertyChanged("team_routingrule");
            }
        }

        /// <summary>
        /// N:1 TransactionCurrency_Routingrule
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("TransactionCurrency_Routingrule")]
        public TransactionCurrency TransactionCurrency_Routingrule
        {
            get { return this.GetRelatedEntity<TransactionCurrency>("TransactionCurrency_Routingrule", null); }
            set
            {
                this.OnPropertyChanging("TransactionCurrency_Routingrule");
                this.SetRelatedEntity<TransactionCurrency>("TransactionCurrency_Routingrule", null, value);
                this.OnPropertyChanged("TransactionCurrency_Routingrule");
            }
        }

        /// <summary>
        /// N:1 user_routingrule
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_routingrule")]
        public SystemUser user_routingrule
        {
            get { return this.GetRelatedEntity<SystemUser>("user_routingrule", null); }
            set
            {
                this.OnPropertyChanging("user_routingrule");
                this.SetRelatedEntity<SystemUser>("user_routingrule", null, value);
                this.OnPropertyChanged("user_routingrule");
            }
        }

        /// <summary>
        /// N:1 Workflow_routingrule
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("workflowid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Workflow_routingrule")]
        public Workflow Workflow_routingrule
        {
            get { return this.GetRelatedEntity<Workflow>("Workflow_routingrule", null); }
            set
            {
                this.OnPropertyChanging("Workflow_routingrule");
                this.SetRelatedEntity<Workflow>("Workflow_routingrule", null, value);
                this.OnPropertyChanged("Workflow_routingrule");
            }
        }
    }
}