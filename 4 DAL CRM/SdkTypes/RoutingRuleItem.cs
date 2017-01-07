namespace __4_DAL_CRM
{
    /// <summary>
    /// Please provide the description for entity
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("routingruleitem")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class RoutingRuleItem : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public RoutingRuleItem() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "routingruleitem";

        public const int EntityTypeCode = 8199;

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
        /// Show who is assigned on item.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("assignobjectid")]
        public Microsoft.Xrm.Sdk.EntityReference AssignObjectId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("assignobjectid"); }
            set
            {
                this.OnPropertyChanging("AssignObjectId");
                this.SetAttributeValue("assignobjectid", value);
                this.OnPropertyChanged("AssignObjectId");
            }
        }

        /// <summary>
        /// Shows the date and time when the item was last assigned to a user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("assignobjectidmodifiedon")]
        public System.Nullable<System.DateTime> AssignObjectIdModifiedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("assignobjectidmodifiedon"); }
            set
            {
                this.OnPropertyChanging("AssignObjectIdModifiedOn");
                this.SetAttributeValue("assignobjectidmodifiedon", value);
                this.OnPropertyChanged("AssignObjectIdModifiedOn");
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
        /// Condition for Rule item
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("conditionxml")]
        public string ConditionXml
        {
            get { return this.GetAttributeValue<string>("conditionxml"); }
            set
            {
                this.OnPropertyChanging("ConditionXml");
                this.SetAttributeValue("conditionxml", value);
                this.OnPropertyChanged("ConditionXml");
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
        /// Type additional information to describe the rule item.
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
        /// Exchange rate for the currency associated with the routing rule item with respect to the base currency.
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
        /// Name of the Routing Rule Item.
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
        /// Unique identifier of the organization associated with the routing rule item.
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
        /// Unique identifier for the business unit that owns the record
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
        public Microsoft.Xrm.Sdk.EntityReference OwningBusinessUnit
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningbusinessunit"); }
        }

        /// <summary>
        /// Unique identifier for the user that owns the record.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
        public Microsoft.Xrm.Sdk.EntityReference OwningUser
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owninguser"); }
        }

        /// <summary>
        /// Choose the Queue that the item is assigned to.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("routedqueueid")]
        public Microsoft.Xrm.Sdk.EntityReference RoutedQueueId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("routedqueueid"); }
            set
            {
                this.OnPropertyChanging("RoutedQueueId");
                this.SetAttributeValue("routedqueueid", value);
                this.OnPropertyChanged("RoutedQueueId");
            }
        }

        /// <summary>
        /// Unique identifier for Routing Rule associated with Rule Item.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("routingruleid")]
        public Microsoft.Xrm.Sdk.EntityReference RoutingRuleId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("routingruleid"); }
            set
            {
                this.OnPropertyChanging("RoutingRuleId");
                this.SetAttributeValue("routingruleid", value);
                this.OnPropertyChanged("RoutingRuleId");
            }
        }

        /// <summary>
        /// Unique identifier for entity instances
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("routingruleitemid")]
        public System.Nullable<System.Guid> RoutingRuleItemId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("routingruleitemid"); }
            set
            {
                this.OnPropertyChanging("RoutingRuleItemId");
                this.SetAttributeValue("routingruleitemid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("RoutingRuleItemId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("routingruleitemid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.RoutingRuleItemId = value; }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("routingruleitemidunique")]
        public System.Nullable<System.Guid> RoutingRuleItemIdUnique
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("routingruleitemidunique"); }
        }

        /// <summary>
        /// Sequence number of the routing rule item
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sequencenumber")]
        public System.Nullable<int> SequenceNumber
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("sequencenumber"); }
            set
            {
                this.OnPropertyChanging("SequenceNumber");
                this.SetAttributeValue("sequencenumber", value);
                this.OnPropertyChanged("SequenceNumber");
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
        /// Version number of the Routing Rule Item.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
        public System.Nullable<long> VersionNumber
        {
            get { return this.GetAttributeValue<System.Nullable<long>>("versionnumber"); }
        }

        /// <summary>
        /// 1:N routingruleitem_Annotation
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("routingruleitem_Annotation")]
        public System.Collections.Generic.IEnumerable<Annotation> routingruleitem_Annotation
        {
            get { return this.GetRelatedEntities<Annotation>("routingruleitem_Annotation", null); }
            set
            {
                this.OnPropertyChanging("routingruleitem_Annotation");
                this.SetRelatedEntities<Annotation>("routingruleitem_Annotation", null, value);
                this.OnPropertyChanged("routingruleitem_Annotation");
            }
        }

        /// <summary>
        /// 1:N routingruleitem_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("routingruleitem_AsyncOperations")]
        public System.Collections.Generic.IEnumerable<AsyncOperation> routingruleitem_AsyncOperations
        {
            get { return this.GetRelatedEntities<AsyncOperation>("routingruleitem_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("routingruleitem_AsyncOperations");
                this.SetRelatedEntities<AsyncOperation>("routingruleitem_AsyncOperations", null, value);
                this.OnPropertyChanged("routingruleitem_AsyncOperations");
            }
        }

        /// <summary>
        /// 1:N routingruleitem_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("routingruleitem_BulkDeleteFailures")]
        public System.Collections.Generic.IEnumerable<BulkDeleteFailure> routingruleitem_BulkDeleteFailures
        {
            get { return this.GetRelatedEntities<BulkDeleteFailure>("routingruleitem_BulkDeleteFailures", null); }
            set
            {
                this.OnPropertyChanging("routingruleitem_BulkDeleteFailures");
                this.SetRelatedEntities<BulkDeleteFailure>("routingruleitem_BulkDeleteFailures", null, value);
                this.OnPropertyChanged("routingruleitem_BulkDeleteFailures");
            }
        }

        /// <summary>
        /// 1:N routingruleitem_ProcessSessions
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("routingruleitem_ProcessSessions")]
        public System.Collections.Generic.IEnumerable<ProcessSession> routingruleitem_ProcessSessions
        {
            get { return this.GetRelatedEntities<ProcessSession>("routingruleitem_ProcessSessions", null); }
            set
            {
                this.OnPropertyChanging("routingruleitem_ProcessSessions");
                this.SetRelatedEntities<ProcessSession>("routingruleitem_ProcessSessions", null, value);
                this.OnPropertyChanged("routingruleitem_ProcessSessions");
            }
        }

        /// <summary>
        /// 1:N routingruleitem_userentityinstancedatas
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("routingruleitem_userentityinstancedatas")]
        public System.Collections.Generic.IEnumerable<UserEntityInstanceData> routingruleitem_userentityinstancedatas
        {
            get { return this.GetRelatedEntities<UserEntityInstanceData>("routingruleitem_userentityinstancedatas", null); }
            set
            {
                this.OnPropertyChanging("routingruleitem_userentityinstancedatas");
                this.SetRelatedEntities<UserEntityInstanceData>("routingruleitem_userentityinstancedatas", null, value);
                this.OnPropertyChanged("routingruleitem_userentityinstancedatas");
            }
        }

        /// <summary>
        /// N:1 lk_RoutingRuleItem_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_RoutingRuleItem_createdby")]
        public SystemUser lk_RoutingRuleItem_createdby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_RoutingRuleItem_createdby", null); }
        }

        /// <summary>
        /// N:1 lk_routingruleitem_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_routingruleitem_createdonbehalfby")]
        public SystemUser lk_routingruleitem_createdonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_routingruleitem_createdonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_routingruleitem_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_routingruleitem_modifiedby")]
        public SystemUser lk_routingruleitem_modifiedby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_routingruleitem_modifiedby", null); }
        }

        /// <summary>
        /// N:1 lk_routingruleitem_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_routingruleitem_modifiedonbehalfby")]
        public SystemUser lk_routingruleitem_modifiedonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_routingruleitem_modifiedonbehalfby", null); }
        }

        /// <summary>
        /// N:1 organization_routingruleitems
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_routingruleitems")]
        public Organization organization_routingruleitems
        {
            get { return this.GetRelatedEntity<Organization>("organization_routingruleitems", null); }
        }

        /// <summary>
        /// N:1 queue_routingruleitem
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("routedqueueid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("queue_routingruleitem")]
        public Queue queue_routingruleitem
        {
            get { return this.GetRelatedEntity<Queue>("queue_routingruleitem", null); }
            set
            {
                this.OnPropertyChanging("queue_routingruleitem");
                this.SetRelatedEntity<Queue>("queue_routingruleitem", null, value);
                this.OnPropertyChanged("queue_routingruleitem");
            }
        }

        /// <summary>
        /// N:1 routingrule_entries
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("routingruleid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("routingrule_entries")]
        public RoutingRule routingrule_entries
        {
            get { return this.GetRelatedEntity<RoutingRule>("routingrule_entries", null); }
            set
            {
                this.OnPropertyChanging("routingrule_entries");
                this.SetRelatedEntity<RoutingRule>("routingrule_entries", null, value);
                this.OnPropertyChanged("routingrule_entries");
            }
        }

        /// <summary>
        /// N:1 team_routingruleitem
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("assignobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_routingruleitem")]
        public Team team_routingruleitem
        {
            get { return this.GetRelatedEntity<Team>("team_routingruleitem", null); }
            set
            {
                this.OnPropertyChanging("team_routingruleitem");
                this.SetRelatedEntity<Team>("team_routingruleitem", null, value);
                this.OnPropertyChanged("team_routingruleitem");
            }
        }

        /// <summary>
        /// N:1 TransactionCurrency_routingruleitem
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("TransactionCurrency_routingruleitem")]
        public TransactionCurrency TransactionCurrency_routingruleitem
        {
            get { return this.GetRelatedEntity<TransactionCurrency>("TransactionCurrency_routingruleitem", null); }
            set
            {
                this.OnPropertyChanging("TransactionCurrency_routingruleitem");
                this.SetRelatedEntity<TransactionCurrency>("TransactionCurrency_routingruleitem", null, value);
                this.OnPropertyChanged("TransactionCurrency_routingruleitem");
            }
        }

        /// <summary>
        /// N:1 user_routingruleitem
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("assignobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_routingruleitem")]
        public SystemUser user_routingruleitem
        {
            get { return this.GetRelatedEntity<SystemUser>("user_routingruleitem", null); }
            set
            {
                this.OnPropertyChanging("user_routingruleitem");
                this.SetRelatedEntity<SystemUser>("user_routingruleitem", null, value);
                this.OnPropertyChanged("user_routingruleitem");
            }
        }
    }
}