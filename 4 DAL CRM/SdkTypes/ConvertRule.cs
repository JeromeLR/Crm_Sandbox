namespace __4_DAL_CRM
{
    /// <summary>
    /// Defines the settings for automatic case creation.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("convertrule")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class ConvertRule : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public ConvertRule() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "convertrule";

        public const int EntityTypeCode = 9300;

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
        /// Choose whether items from unknown senders should be converted to cases.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("allowunknownsender")]
        public System.Nullable<bool> AllowUnknownSender
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("allowunknownsender"); }
            set
            {
                this.OnPropertyChanging("AllowUnknownSender");
                this.SetAttributeValue("allowunknownsender", value);
                this.OnPropertyChanged("AllowUnknownSender");
            }
        }

        /// <summary>
        /// Choose whether cases should be created for customers with active entitlements.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("checkactiveentitlement")]
        public System.Nullable<bool> CheckActiveEntitlement
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("checkactiveentitlement"); }
            set
            {
                this.OnPropertyChanging("CheckActiveEntitlement");
                this.SetAttributeValue("checkactiveentitlement", value);
                this.OnPropertyChanged("CheckActiveEntitlement");
            }
        }

        /// <summary>
        /// Information whether case needs to be created for black listed social profiles.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("checkblockedsocialprofile")]
        public System.Nullable<bool> CheckBlockedSocialProfile
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("checkblockedsocialprofile"); }
            set
            {
                this.OnPropertyChanging("CheckBlockedSocialProfile");
                this.SetAttributeValue("checkblockedsocialprofile", value);
                this.OnPropertyChanged("CheckBlockedSocialProfile");
            }
        }

        /// <summary>
        /// Information whether case needs to be created for direct messages.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("checkdirectmessages")]
        public System.Nullable<bool> CheckDirectMessages
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("checkdirectmessages"); }
            set
            {
                this.OnPropertyChanging("CheckDirectMessages");
                this.SetAttributeValue("checkdirectmessages", value);
                this.OnPropertyChanged("CheckDirectMessages");
            }
        }

        /// <summary>
        /// Choose whether an item related to a resolved case should be converted to a case.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("checkifresolved")]
        public System.Nullable<bool> CheckIfResolved
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("checkifresolved"); }
            set
            {
                this.OnPropertyChanging("CheckIfResolved");
                this.SetAttributeValue("checkifresolved", value);
                this.OnPropertyChanged("CheckIfResolved");
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
        /// Unique identifier for entity instances
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("convertruleid")]
        public System.Nullable<System.Guid> ConvertRuleId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("convertruleid"); }
            set
            {
                this.OnPropertyChanging("ConvertRuleId");
                this.SetAttributeValue("convertruleid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("ConvertRuleId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("convertruleid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.ConvertRuleId = value; }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("convertruleidunique")]
        public System.Nullable<System.Guid> ConvertRuleIdUnique
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("convertruleidunique"); }
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
        /// Type additional information to describe the rule for creating cases automatically.
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
        /// Type a title or name of the queue for which the setting is defined.
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
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("overwritetime")]
        public System.Nullable<System.DateTime> OverwriteTime
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("overwritetime"); }
        }

        /// <summary>
        /// Owner Id
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
        /// Shows the business unit that the convert rule owner belongs to.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
        public Microsoft.Xrm.Sdk.EntityReference OwningBusinessUnit
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningbusinessunit"); }
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
        /// Choose the queue that the rule is assigned to.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("queueid")]
        public Microsoft.Xrm.Sdk.EntityReference QueueId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("queueid"); }
            set
            {
                this.OnPropertyChanging("QueueId");
                this.SetAttributeValue("queueid", value);
                this.OnPropertyChanged("QueueId");
            }
        }

        /// <summary>
        /// If you want to create a new case for an item associated with a resolved case, type how long a case must remain resolved before a new case is created for the associated item.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("resolvedsince")]
        public System.Nullable<int> ResolvedSince
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("resolvedsince"); }
            set
            {
                this.OnPropertyChanging("ResolvedSince");
                this.SetAttributeValue("resolvedsince", value);
                this.OnPropertyChanged("ResolvedSince");
            }
        }

        /// <summary>
        /// Choose the email template to use to create an automatic response to the customer.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("responsetemplateid")]
        public Microsoft.Xrm.Sdk.EntityReference ResponseTemplateId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("responsetemplateid"); }
            set
            {
                this.OnPropertyChanging("ResponseTemplateId");
                this.SetAttributeValue("responsetemplateid", value);
                this.OnPropertyChanged("ResponseTemplateId");
            }
        }

        /// <summary>
        /// Choose whether to send an automatic email response to the customer after a case is created.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sendautomaticresponse")]
        public System.Nullable<bool> SendAutomaticResponse
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("sendautomaticresponse"); }
            set
            {
                this.OnPropertyChanging("SendAutomaticResponse");
                this.SetAttributeValue("sendautomaticresponse", value);
                this.OnPropertyChanged("SendAutomaticResponse");
            }
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
        /// Source of the case.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sourcetypecode")]
        public Microsoft.Xrm.Sdk.OptionSetValue SourceTypeCode
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("sourcetypecode"); }
            set
            {
                this.OnPropertyChanging("SourceTypeCode");
                this.SetAttributeValue("sourcetypecode", value);
                this.OnPropertyChanged("SourceTypeCode");
            }
        }

        /// <summary>
        /// Status of the Convert Rule
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
        public System.Nullable<ConvertRuleState> StateCode
        {
            get
            {
                Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
                if ((optionSet != null))
                {
                    return ((ConvertRuleState) (System.Enum.ToObject(typeof(ConvertRuleState), optionSet.Value)));
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// Reason for the status of the Convert Rule
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
        /// Unique identifier of the currency associated with the queue.
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
        /// Version number of the convert rule.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
        public System.Nullable<long> VersionNumber
        {
            get { return this.GetAttributeValue<System.Nullable<long>>("versionnumber"); }
        }

        /// <summary>
        /// Shows the workflow for this rule.
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
        /// 1:N ConvertRule_Annotation
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ConvertRule_Annotation")]
        public System.Collections.Generic.IEnumerable<Annotation> ConvertRule_Annotation
        {
            get { return this.GetRelatedEntities<Annotation>("ConvertRule_Annotation", null); }
            set
            {
                this.OnPropertyChanging("ConvertRule_Annotation");
                this.SetRelatedEntities<Annotation>("ConvertRule_Annotation", null, value);
                this.OnPropertyChanged("ConvertRule_Annotation");
            }
        }

        /// <summary>
        /// 1:N Convertrule_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Convertrule_AsyncOperations")]
        public System.Collections.Generic.IEnumerable<AsyncOperation> Convertrule_AsyncOperations
        {
            get { return this.GetRelatedEntities<AsyncOperation>("Convertrule_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("Convertrule_AsyncOperations");
                this.SetRelatedEntities<AsyncOperation>("Convertrule_AsyncOperations", null, value);
                this.OnPropertyChanged("Convertrule_AsyncOperations");
            }
        }

        /// <summary>
        /// 1:N convertrule_convertruleitem
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("convertrule_convertruleitem")]
        public System.Collections.Generic.IEnumerable<ConvertRuleItem> convertrule_convertruleitem
        {
            get { return this.GetRelatedEntities<ConvertRuleItem>("convertrule_convertruleitem", null); }
            set
            {
                this.OnPropertyChanging("convertrule_convertruleitem");
                this.SetRelatedEntities<ConvertRuleItem>("convertrule_convertruleitem", null, value);
                this.OnPropertyChanged("convertrule_convertruleitem");
            }
        }

        /// <summary>
        /// 1:N ConvertRule_ProcessSessions
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ConvertRule_ProcessSessions")]
        public System.Collections.Generic.IEnumerable<ProcessSession> ConvertRule_ProcessSessions
        {
            get { return this.GetRelatedEntities<ProcessSession>("ConvertRule_ProcessSessions", null); }
            set
            {
                this.OnPropertyChanging("ConvertRule_ProcessSessions");
                this.SetRelatedEntities<ProcessSession>("ConvertRule_ProcessSessions", null, value);
                this.OnPropertyChanged("ConvertRule_ProcessSessions");
            }
        }

        /// <summary>
        /// 1:N ConvertRule_userentityinstancedatas
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ConvertRule_userentityinstancedatas")]
        public System.Collections.Generic.IEnumerable<UserEntityInstanceData> ConvertRule_userentityinstancedatas
        {
            get { return this.GetRelatedEntities<UserEntityInstanceData>("ConvertRule_userentityinstancedatas", null); }
            set
            {
                this.OnPropertyChanging("ConvertRule_userentityinstancedatas");
                this.SetRelatedEntities<UserEntityInstanceData>("ConvertRule_userentityinstancedatas", null, value);
                this.OnPropertyChanged("ConvertRule_userentityinstancedatas");
            }
        }

        /// <summary>
        /// N:1 business_unit_convertrule
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_convertrule")]
        public BusinessUnit business_unit_convertrule
        {
            get { return this.GetRelatedEntity<BusinessUnit>("business_unit_convertrule", null); }
        }

        /// <summary>
        /// N:1 convertrule_queue
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("queueid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("convertrule_queue")]
        public Queue convertrule_queue
        {
            get { return this.GetRelatedEntity<Queue>("convertrule_queue", null); }
            set
            {
                this.OnPropertyChanging("convertrule_queue");
                this.SetRelatedEntity<Queue>("convertrule_queue", null, value);
                this.OnPropertyChanged("convertrule_queue");
            }
        }

        /// <summary>
        /// N:1 emailtemplate_convertrule
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("responsetemplateid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("emailtemplate_convertrule")]
        public Template emailtemplate_convertrule
        {
            get { return this.GetRelatedEntity<Template>("emailtemplate_convertrule", null); }
            set
            {
                this.OnPropertyChanging("emailtemplate_convertrule");
                this.SetRelatedEntity<Template>("emailtemplate_convertrule", null, value);
                this.OnPropertyChanged("emailtemplate_convertrule");
            }
        }

        /// <summary>
        /// N:1 lk_convertrule_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_convertrule_createdby")]
        public SystemUser lk_convertrule_createdby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_convertrule_createdby", null); }
        }

        /// <summary>
        /// N:1 lk_ConvertRule_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ConvertRule_createdonbehalfby")]
        public SystemUser lk_ConvertRule_createdonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_ConvertRule_createdonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_ConvertRule_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ConvertRule_modifiedby")]
        public SystemUser lk_ConvertRule_modifiedby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_ConvertRule_modifiedby", null); }
        }

        /// <summary>
        /// N:1 lk_ConvertRule_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ConvertRule_modifiedonbehalfby")]
        public SystemUser lk_ConvertRule_modifiedonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_ConvertRule_modifiedonbehalfby", null); }
        }

        /// <summary>
        /// N:1 team_convertrule
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_convertrule")]
        public Team team_convertrule
        {
            get { return this.GetRelatedEntity<Team>("team_convertrule", null); }
            set
            {
                this.OnPropertyChanging("team_convertrule");
                this.SetRelatedEntity<Team>("team_convertrule", null, value);
                this.OnPropertyChanged("team_convertrule");
            }
        }

        /// <summary>
        /// N:1 TransactionCurrency_ConvertRule
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("TransactionCurrency_ConvertRule")]
        public TransactionCurrency TransactionCurrency_ConvertRule
        {
            get { return this.GetRelatedEntity<TransactionCurrency>("TransactionCurrency_ConvertRule", null); }
            set
            {
                this.OnPropertyChanging("TransactionCurrency_ConvertRule");
                this.SetRelatedEntity<TransactionCurrency>("TransactionCurrency_ConvertRule", null, value);
                this.OnPropertyChanged("TransactionCurrency_ConvertRule");
            }
        }

        /// <summary>
        /// N:1 user_convertrule
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_convertrule")]
        public SystemUser user_convertrule
        {
            get { return this.GetRelatedEntity<SystemUser>("user_convertrule", null); }
            set
            {
                this.OnPropertyChanging("user_convertrule");
                this.SetRelatedEntity<SystemUser>("user_convertrule", null, value);
                this.OnPropertyChanged("user_convertrule");
            }
        }

        /// <summary>
        /// N:1 workflowid_convertrule
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("workflowid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("workflowid_convertrule")]
        public Workflow workflowid_convertrule
        {
            get { return this.GetRelatedEntity<Workflow>("workflowid_convertrule", null); }
            set
            {
                this.OnPropertyChanging("workflowid_convertrule");
                this.SetRelatedEntity<Workflow>("workflowid_convertrule", null, value);
                this.OnPropertyChanged("workflowid_convertrule");
            }
        }
    }
}