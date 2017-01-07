namespace __4_DAL_CRM
{
    /// <summary>
    /// Contains information about a tracked support KPI for a specific customer.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("slaitem")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class SLAItem : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public SLAItem() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "slaitem";

        public const int EntityTypeCode = 9751;

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
        /// Condition for SLA item
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("applicablewhenxml")]
        public string ApplicableWhenXml
        {
            get { return this.GetAttributeValue<string>("applicablewhenxml"); }
            set
            {
                this.OnPropertyChanging("ApplicableWhenXml");
                this.SetAttributeValue("applicablewhenxml", value);
                this.OnPropertyChanged("ApplicableWhenXml");
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
        /// Type additional information to describe the SLA Item
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
        /// Exchange rate between the currency associated with the SLA Item record and the base currency.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("exchangerate")]
        public System.Nullable<decimal> ExchangeRate
        {
            get { return this.GetAttributeValue<System.Nullable<decimal>>("exchangerate"); }
        }

        /// <summary>
        /// Select how soon the success criteria must be met until the SLA item is considered failed and failure actions are initiated. The actual duration is based on the business hours as specified in the associated SLA record.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("failureafter")]
        public System.Nullable<int> FailureAfter
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("failureafter"); }
            set
            {
                this.OnPropertyChanging("FailureAfter");
                this.SetAttributeValue("failureafter", value);
                this.OnPropertyChanged("FailureAfter");
            }
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
        /// Shows who created the record on behalf of another user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        /// Type a descriptive name of the service level agreement (SLA) item.
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
        /// Enter the user or team who owns the SLA. This field is updated every time the item is assigned to a different user.
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
        /// Unique identifier of the user who owns the SLA Item record.
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
        /// Select the service level agreement (SLA) key performance indicator (KPI) that this SLA Item is created for.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("relatedfield")]
        public string RelatedField
        {
            get { return this.GetAttributeValue<string>("relatedfield"); }
            set
            {
                this.OnPropertyChanging("RelatedField");
                this.SetAttributeValue("relatedfield", value);
                this.OnPropertyChanged("RelatedField");
            }
        }

        /// <summary>
        /// Select the time zone, or UTC offset, for this address so that other people can reference it when they contact someone at this address.
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
        /// Unique identifier for SLA associated with SLA Item.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("slaid")]
        public Microsoft.Xrm.Sdk.EntityReference SLAId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("slaid"); }
            set
            {
                this.OnPropertyChanging("SLAId");
                this.SetAttributeValue("slaid", value);
                this.OnPropertyChanged("SLAId");
            }
        }

        /// <summary>
        /// Unique identifier of the SLA Item.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("slaitemid")]
        public System.Nullable<System.Guid> SLAItemId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("slaitemid"); }
            set
            {
                this.OnPropertyChanging("SLAItemId");
                this.SetAttributeValue("slaitemid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("SLAItemId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("slaitemid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.SLAItemId = value; }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("slaitemidunique")]
        public System.Nullable<System.Guid> SLAItemIdUnique
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("slaitemidunique"); }
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
        /// Condition for SLA item
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("successconditionsxml")]
        public string SuccessConditionsXml
        {
            get { return this.GetAttributeValue<string>("successconditionsxml"); }
            set
            {
                this.OnPropertyChanging("SuccessConditionsXml");
                this.SetAttributeValue("successconditionsxml", value);
                this.OnPropertyChanged("SuccessConditionsXml");
            }
        }

        /// <summary>
        /// Unique identifier of the currency associated with the SLA Item record.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyid")]
        public Microsoft.Xrm.Sdk.EntityReference TransactionCurrencyId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("transactioncurrencyid"); }
        }

        /// <summary>
        /// Version number of the SLA Item.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
        public System.Nullable<long> VersionNumber
        {
            get { return this.GetAttributeValue<System.Nullable<long>>("versionnumber"); }
        }

        /// <summary>
        /// Select how soon the success criteria must be met before warning actions are initiated. The actual duration is based on the business hours as specified in the associated SLA record.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("warnafter")]
        public System.Nullable<int> WarnAfter
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("warnafter"); }
            set
            {
                this.OnPropertyChanging("WarnAfter");
                this.SetAttributeValue("warnafter", value);
                this.OnPropertyChanged("WarnAfter");
            }
        }

        /// <summary>
        /// Workflow associated with the SLA Item.
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
        /// N:1 lk_slaitembase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_slaitembase_createdby")]
        public SystemUser lk_slaitembase_createdby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_slaitembase_createdby", null); }
        }

        /// <summary>
        /// N:1 lk_slaitembase_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_slaitembase_createdonbehalfby")]
        public SystemUser lk_slaitembase_createdonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_slaitembase_createdonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_slaitembase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_slaitembase_modifiedby")]
        public SystemUser lk_slaitembase_modifiedby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_slaitembase_modifiedby", null); }
        }

        /// <summary>
        /// N:1 lk_slaitembase_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_slaitembase_modifiedonbehalfby")]
        public SystemUser lk_slaitembase_modifiedonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_slaitembase_modifiedonbehalfby", null); }
        }

        /// <summary>
        /// N:1 sla_slaitem_slaId
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("slaid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("sla_slaitem_slaId")]
        public SLA sla_slaitem_slaId
        {
            get { return this.GetRelatedEntity<SLA>("sla_slaitem_slaId", null); }
            set
            {
                this.OnPropertyChanging("sla_slaitem_slaId");
                this.SetRelatedEntity<SLA>("sla_slaitem_slaId", null, value);
                this.OnPropertyChanged("sla_slaitem_slaId");
            }
        }

        /// <summary>
        /// N:1 slaitembase_workflowid
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("workflowid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("slaitembase_workflowid")]
        public Workflow slaitembase_workflowid
        {
            get { return this.GetRelatedEntity<Workflow>("slaitembase_workflowid", null); }
            set
            {
                this.OnPropertyChanging("slaitembase_workflowid");
                this.SetRelatedEntity<Workflow>("slaitembase_workflowid", null, value);
                this.OnPropertyChanged("slaitembase_workflowid");
            }
        }

        /// <summary>
        /// N:1 TransactionCurrency_SLAItem
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("TransactionCurrency_SLAItem")]
        public TransactionCurrency TransactionCurrency_SLAItem
        {
            get { return this.GetRelatedEntity<TransactionCurrency>("TransactionCurrency_SLAItem", null); }
        }
    }
}