using _4_DAL_CRM;

namespace __4_DAL_CRM
{
    /// <summary>
    /// Log used to track bulk operation execution, successes, and failures.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("bulkoperationlog")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class BulkOperationLog : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public BulkOperationLog() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "bulkoperationlog";

        public const int EntityTypeCode = 4405;

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
        /// Shows the data value at which an error occurred during the quick campaign.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("additionalinfo")]
        public string AdditionalInfo
        {
            get { return this.GetAttributeValue<string>("additionalinfo"); }
            set
            {
                this.OnPropertyChanging("AdditionalInfo");
                this.SetAttributeValue("additionalinfo", value);
                this.OnPropertyChanged("AdditionalInfo");
            }
        }

        /// <summary>
        /// Shows the quick campaign record that the log applies to. This information is used to relate log data to the parent quick campaign.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("bulkoperationid")]
        public Microsoft.Xrm.Sdk.EntityReference BulkOperationId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("bulkoperationid"); }
            set
            {
                this.OnPropertyChanging("BulkOperationId");
                this.SetAttributeValue("bulkoperationid", value);
                this.OnPropertyChanged("BulkOperationId");
            }
        }

        /// <summary>
        /// Unique identifier of the bulk operation log.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("bulkoperationlogid")]
        public System.Nullable<System.Guid> BulkOperationLogId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("bulkoperationlogid"); }
            set
            {
                this.OnPropertyChanging("BulkOperationLogId");
                this.SetAttributeValue("bulkoperationlogid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("BulkOperationLogId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("bulkoperationlogid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.BulkOperationLogId = value; }
        }

        /// <summary>
        /// Choose the activity or other item created by the bulk operation.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdobjectid")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedObjectId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdobjectid"); }
            set
            {
                this.OnPropertyChanging("CreatedObjectId");
                this.SetAttributeValue("createdobjectid", value);
                this.OnPropertyChanged("CreatedObjectId");
            }
        }

        /// <summary>
        /// Shows the error code that is used to troubleshoot issues in the bulk operation.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("errornumber")]
        public System.Nullable<int> ErrorNumber
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("errornumber"); }
        }

        /// <summary>
        /// Unique identifier of the user or team who owns the bulk operation log.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ownerid")]
        public Microsoft.Xrm.Sdk.EntityReference OwnerId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("ownerid"); }
        }

        /// <summary>
        /// Unique identifier of the business unit that owns the bulk operation log.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
        public System.Nullable<System.Guid> OwningBusinessUnit
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("owningbusinessunit"); }
        }

        /// <summary>
        /// Unique identifier of the user who owns the bulk operation log.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
        public System.Nullable<System.Guid> OwningUser
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("owninguser"); }
        }

        /// <summary>
        /// Choose the account, contact, lead, or list that the bulk operation log item applies to.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        public Microsoft.Xrm.Sdk.EntityReference RegardingObjectId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("regardingobjectid"); }
            set
            {
                this.OnPropertyChanging("RegardingObjectId");
                this.SetAttributeValue("regardingobjectid", value);
                this.OnPropertyChanged("RegardingObjectId");
            }
        }

        /// <summary>
        /// 1:N BulkOperationLog_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("BulkOperationLog_AsyncOperations")]
        public System.Collections.Generic.IEnumerable<AsyncOperation> BulkOperationLog_AsyncOperations
        {
            get { return this.GetRelatedEntities<AsyncOperation>("BulkOperationLog_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("BulkOperationLog_AsyncOperations");
                this.SetRelatedEntities<AsyncOperation>("BulkOperationLog_AsyncOperations", null, value);
                this.OnPropertyChanged("BulkOperationLog_AsyncOperations");
            }
        }

        /// <summary>
        /// 1:N BulkOperationLog_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("BulkOperationLog_BulkDeleteFailures")]
        public System.Collections.Generic.IEnumerable<BulkDeleteFailure> BulkOperationLog_BulkDeleteFailures
        {
            get { return this.GetRelatedEntities<BulkDeleteFailure>("BulkOperationLog_BulkDeleteFailures", null); }
            set
            {
                this.OnPropertyChanging("BulkOperationLog_BulkDeleteFailures");
                this.SetRelatedEntities<BulkDeleteFailure>("BulkOperationLog_BulkDeleteFailures", null, value);
                this.OnPropertyChanged("BulkOperationLog_BulkDeleteFailures");
            }
        }

        /// <summary>
        /// 1:N userentityinstancedata_bulkoperationlog
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_bulkoperationlog")]
        public System.Collections.Generic.IEnumerable<UserEntityInstanceData> userentityinstancedata_bulkoperationlog
        {
            get { return this.GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_bulkoperationlog", null); }
            set
            {
                this.OnPropertyChanging("userentityinstancedata_bulkoperationlog");
                this.SetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_bulkoperationlog", null, value);
                this.OnPropertyChanged("userentityinstancedata_bulkoperationlog");
            }
        }

        /// <summary>
        /// N:1 activity_pointer_BulkOperation_logs
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("bulkoperationid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("activity_pointer_BulkOperation_logs")]
        public ActivityPointer activity_pointer_BulkOperation_logs
        {
            get { return this.GetRelatedEntity<ActivityPointer>("activity_pointer_BulkOperation_logs", null); }
            set
            {
                this.OnPropertyChanging("activity_pointer_BulkOperation_logs");
                this.SetRelatedEntity<ActivityPointer>("activity_pointer_BulkOperation_logs", null, value);
                this.OnPropertyChanged("activity_pointer_BulkOperation_logs");
            }
        }

        /// <summary>
        /// N:1 BulkOperation_logs
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("bulkoperationid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("BulkOperation_logs")]
        public BulkOperation BulkOperation_logs
        {
            get { return this.GetRelatedEntity<BulkOperation>("BulkOperation_logs", null); }
            set
            {
                this.OnPropertyChanging("BulkOperation_logs");
                this.SetRelatedEntity<BulkOperation>("BulkOperation_logs", null, value);
                this.OnPropertyChanged("BulkOperation_logs");
            }
        }

        /// <summary>
        /// N:1 CreatedAccount_BulkOperationLogs2
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("CreatedAccount_BulkOperationLogs2")]
        public Account CreatedAccount_BulkOperationLogs2
        {
            get { return this.GetRelatedEntity<Account>("CreatedAccount_BulkOperationLogs2", null); }
            set
            {
                this.OnPropertyChanging("CreatedAccount_BulkOperationLogs2");
                this.SetRelatedEntity<Account>("CreatedAccount_BulkOperationLogs2", null, value);
                this.OnPropertyChanged("CreatedAccount_BulkOperationLogs2");
            }
        }

        /// <summary>
        /// N:1 CreatedActivity_BulkOperationLogs
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("CreatedActivity_BulkOperationLogs")]
        public ActivityPointer CreatedActivity_BulkOperationLogs
        {
            get { return this.GetRelatedEntity<ActivityPointer>("CreatedActivity_BulkOperationLogs", null); }
            set
            {
                this.OnPropertyChanging("CreatedActivity_BulkOperationLogs");
                this.SetRelatedEntity<ActivityPointer>("CreatedActivity_BulkOperationLogs", null, value);
                this.OnPropertyChanged("CreatedActivity_BulkOperationLogs");
            }
        }

        /// <summary>
        /// N:1 CreatedContact_BulkOperationLogs
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("CreatedContact_BulkOperationLogs")]
        public Contact CreatedContact_BulkOperationLogs
        {
            get { return this.GetRelatedEntity<Contact>("CreatedContact_BulkOperationLogs", null); }
            set
            {
                this.OnPropertyChanging("CreatedContact_BulkOperationLogs");
                this.SetRelatedEntity<Contact>("CreatedContact_BulkOperationLogs", null, value);
                this.OnPropertyChanged("CreatedContact_BulkOperationLogs");
            }
        }

        /// <summary>
        /// N:1 CreatedLead_BulkOperationLogs
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("CreatedLead_BulkOperationLogs")]
        public Lead CreatedLead_BulkOperationLogs
        {
            get { return this.GetRelatedEntity<Lead>("CreatedLead_BulkOperationLogs", null); }
            set
            {
                this.OnPropertyChanging("CreatedLead_BulkOperationLogs");
                this.SetRelatedEntity<Lead>("CreatedLead_BulkOperationLogs", null, value);
                this.OnPropertyChanged("CreatedLead_BulkOperationLogs");
            }
        }

        /// <summary>
        /// N:1 CreatedOpportunity_BulkOperationLogs
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("CreatedOpportunity_BulkOperationLogs")]
        public Opportunity CreatedOpportunity_BulkOperationLogs
        {
            get { return this.GetRelatedEntity<Opportunity>("CreatedOpportunity_BulkOperationLogs", null); }
            set
            {
                this.OnPropertyChanging("CreatedOpportunity_BulkOperationLogs");
                this.SetRelatedEntity<Opportunity>("CreatedOpportunity_BulkOperationLogs", null, value);
                this.OnPropertyChanged("CreatedOpportunity_BulkOperationLogs");
            }
        }

        /// <summary>
        /// N:1 SourceAccount_BulkOperationLogs
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SourceAccount_BulkOperationLogs")]
        public Account SourceAccount_BulkOperationLogs
        {
            get { return this.GetRelatedEntity<Account>("SourceAccount_BulkOperationLogs", null); }
            set
            {
                this.OnPropertyChanging("SourceAccount_BulkOperationLogs");
                this.SetRelatedEntity<Account>("SourceAccount_BulkOperationLogs", null, value);
                this.OnPropertyChanged("SourceAccount_BulkOperationLogs");
            }
        }

        /// <summary>
        /// N:1 SourceContact_BulkOperationLogs
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SourceContact_BulkOperationLogs")]
        public Contact SourceContact_BulkOperationLogs
        {
            get { return this.GetRelatedEntity<Contact>("SourceContact_BulkOperationLogs", null); }
            set
            {
                this.OnPropertyChanging("SourceContact_BulkOperationLogs");
                this.SetRelatedEntity<Contact>("SourceContact_BulkOperationLogs", null, value);
                this.OnPropertyChanged("SourceContact_BulkOperationLogs");
            }
        }

        /// <summary>
        /// N:1 SourceLead_BulkOperationLogs
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SourceLead_BulkOperationLogs")]
        public Lead SourceLead_BulkOperationLogs
        {
            get { return this.GetRelatedEntity<Lead>("SourceLead_BulkOperationLogs", null); }
            set
            {
                this.OnPropertyChanging("SourceLead_BulkOperationLogs");
                this.SetRelatedEntity<Lead>("SourceLead_BulkOperationLogs", null, value);
                this.OnPropertyChanged("SourceLead_BulkOperationLogs");
            }
        }
    }
}