namespace __4_DAL_CRM
{
    /// <summary>
    /// A specific item in a queue, such as a case record or an activity record.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("queueitem")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class QueueItem : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public QueueItem() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "queueitem";

        public const int EntityTypeCode = 2029;

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
        /// Shows the date the record was assigned to the queue.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("enteredon")]
        public System.Nullable<System.DateTime> EnteredOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("enteredon"); }
        }

        /// <summary>
        /// Shows the conversion rate of the record's currency. The exchange rate is used to convert all money fields in the record from the local currency to the system's default currency.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("exchangerate")]
        public System.Nullable<decimal> ExchangeRate
        {
            get { return this.GetAttributeValue<System.Nullable<decimal>>("exchangerate"); }
        }

        /// <summary>
        /// Unique identifier of the data import or data migration that created this record.
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
        /// Unique identifier of the delegate user who last modified the queueitem.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        /// Choose the activity, case, or article assigned to the queue.
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
        /// Select the type of the queue item, such as activity, case, or appointment.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objecttypecode")]
        public Microsoft.Xrm.Sdk.OptionSetValue ObjectTypeCode
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("objecttypecode"); }
        }

        /// <summary>
        /// Unique identifier of the organization with which the queue item is associated.
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
        /// Unique identifier of the user or team who owns the queue item.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ownerid")]
        public Microsoft.Xrm.Sdk.EntityReference OwnerId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("ownerid"); }
        }

        /// <summary>
        /// Unique identifier of the business unit that owns the queue item.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
        public Microsoft.Xrm.Sdk.EntityReference OwningBusinessUnit
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningbusinessunit"); }
        }

        /// <summary>
        /// Unique identifier of the user who owns the queue item.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
        public Microsoft.Xrm.Sdk.EntityReference OwningUser
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owninguser"); }
        }

        /// <summary>
        /// Priority of the queue item.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("priority")]
        [System.ObsoleteAttribute()]
        public System.Nullable<int> Priority
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("priority"); }
            set
            {
                this.OnPropertyChanging("Priority");
                this.SetAttributeValue("priority", value);
                this.OnPropertyChanged("Priority");
            }
        }

        /// <summary>
        /// Choose the queue that the item is assigned to.
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
        /// Unique identifier of the queue item.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("queueitemid")]
        public System.Nullable<System.Guid> QueueItemId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("queueitemid"); }
            set
            {
                this.OnPropertyChanging("QueueItemId");
                this.SetAttributeValue("queueitemid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("QueueItemId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("queueitemid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.QueueItemId = value; }
        }

        /// <summary>
        /// Sender who created the queue item.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sender")]
        [System.ObsoleteAttribute()]
        public string Sender
        {
            get { return this.GetAttributeValue<string>("sender"); }
            set
            {
                this.OnPropertyChanging("Sender");
                this.SetAttributeValue("sender", value);
                this.OnPropertyChanged("Sender");
            }
        }

        /// <summary>
        /// Status of the queue item.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("state")]
        [System.ObsoleteAttribute()]
        public System.Nullable<int> State
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("state"); }
            set
            {
                this.OnPropertyChanging("State");
                this.SetAttributeValue("state", value);
                this.OnPropertyChanged("State");
            }
        }

        /// <summary>
        /// Shows whether the queue record is active or inactive. Inactive queue records are read-only and can't be edited unless they are reactivated.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
        public System.Nullable<QueueItemState> StateCode
        {
            get
            {
                Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
                if ((optionSet != null))
                {
                    return ((QueueItemState) (System.Enum.ToObject(typeof(QueueItemState), optionSet.Value)));
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// Reason for the status of the queue item.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("status")]
        [System.ObsoleteAttribute()]
        public System.Nullable<int> Status
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("status"); }
            set
            {
                this.OnPropertyChanging("Status");
                this.SetAttributeValue("status", value);
                this.OnPropertyChanged("Status");
            }
        }

        /// <summary>
        /// Select the item's status.
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
        /// Shows the title or name that describes the queue record. This value is copied from the record that was assigned to the queue.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("title")]
        public string Title
        {
            get { return this.GetAttributeValue<string>("title"); }
        }

        /// <summary>
        /// Recipients listed on the To line of the message for email queue items.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("torecipients")]
        [System.ObsoleteAttribute()]
        public string ToRecipients
        {
            get { return this.GetAttributeValue<string>("torecipients"); }
            set
            {
                this.OnPropertyChanging("ToRecipients");
                this.SetAttributeValue("torecipients", value);
                this.OnPropertyChanged("ToRecipients");
            }
        }

        /// <summary>
        /// Choose the local currency for the record to make sure budgets are reported in the correct currency.
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
        /// Version number of the queue item.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
        public System.Nullable<long> VersionNumber
        {
            get { return this.GetAttributeValue<System.Nullable<long>>("versionnumber"); }
        }

        /// <summary>
        /// Shows who is working on the queue item.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("workerid")]
        public Microsoft.Xrm.Sdk.EntityReference WorkerId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("workerid"); }
            set
            {
                this.OnPropertyChanging("WorkerId");
                this.SetAttributeValue("workerid", value);
                this.OnPropertyChanged("WorkerId");
            }
        }

        /// <summary>
        /// Shows the date and time when the queue item was last assigned to a user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("workeridmodifiedon")]
        public System.Nullable<System.DateTime> WorkerIdModifiedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("workeridmodifiedon"); }
        }

        /// <summary>
        /// 1:N QueueItem_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("QueueItem_AsyncOperations")]
        public System.Collections.Generic.IEnumerable<AsyncOperation> QueueItem_AsyncOperations
        {
            get { return this.GetRelatedEntities<AsyncOperation>("QueueItem_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("QueueItem_AsyncOperations");
                this.SetRelatedEntities<AsyncOperation>("QueueItem_AsyncOperations", null, value);
                this.OnPropertyChanged("QueueItem_AsyncOperations");
            }
        }

        /// <summary>
        /// 1:N QueueItem_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("QueueItem_BulkDeleteFailures")]
        public System.Collections.Generic.IEnumerable<BulkDeleteFailure> QueueItem_BulkDeleteFailures
        {
            get { return this.GetRelatedEntities<BulkDeleteFailure>("QueueItem_BulkDeleteFailures", null); }
            set
            {
                this.OnPropertyChanging("QueueItem_BulkDeleteFailures");
                this.SetRelatedEntities<BulkDeleteFailure>("QueueItem_BulkDeleteFailures", null, value);
                this.OnPropertyChanged("QueueItem_BulkDeleteFailures");
            }
        }

        /// <summary>
        /// 1:N queueitem_principalobjectattributeaccess
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("queueitem_principalobjectattributeaccess")]
        public System.Collections.Generic.IEnumerable<PrincipalObjectAttributeAccess> queueitem_principalobjectattributeaccess
        {
            get { return this.GetRelatedEntities<PrincipalObjectAttributeAccess>("queueitem_principalobjectattributeaccess", null); }
            set
            {
                this.OnPropertyChanging("queueitem_principalobjectattributeaccess");
                this.SetRelatedEntities<PrincipalObjectAttributeAccess>("queueitem_principalobjectattributeaccess", null, value);
                this.OnPropertyChanged("queueitem_principalobjectattributeaccess");
            }
        }

        /// <summary>
        /// 1:N QueueItem_ProcessSessions
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("QueueItem_ProcessSessions")]
        public System.Collections.Generic.IEnumerable<ProcessSession> QueueItem_ProcessSessions
        {
            get { return this.GetRelatedEntities<ProcessSession>("QueueItem_ProcessSessions", null); }
            set
            {
                this.OnPropertyChanging("QueueItem_ProcessSessions");
                this.SetRelatedEntities<ProcessSession>("QueueItem_ProcessSessions", null, value);
                this.OnPropertyChanged("QueueItem_ProcessSessions");
            }
        }

        /// <summary>
        /// 1:N userentityinstancedata_queueitem
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_queueitem")]
        public System.Collections.Generic.IEnumerable<UserEntityInstanceData> userentityinstancedata_queueitem
        {
            get { return this.GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_queueitem", null); }
            set
            {
                this.OnPropertyChanging("userentityinstancedata_queueitem");
                this.SetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_queueitem", null, value);
                this.OnPropertyChanged("userentityinstancedata_queueitem");
            }
        }

        /// <summary>
        /// N:1 ActivityPointer_QueueItem
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ActivityPointer_QueueItem")]
        public ActivityPointer ActivityPointer_QueueItem
        {
            get { return this.GetRelatedEntity<ActivityPointer>("ActivityPointer_QueueItem", null); }
            set
            {
                this.OnPropertyChanging("ActivityPointer_QueueItem");
                this.SetRelatedEntity<ActivityPointer>("ActivityPointer_QueueItem", null, value);
                this.OnPropertyChanged("ActivityPointer_QueueItem");
            }
        }

        /// <summary>
        /// N:1 Appointment_QueueItem
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Appointment_QueueItem")]
        public Appointment Appointment_QueueItem
        {
            get { return this.GetRelatedEntity<Appointment>("Appointment_QueueItem", null); }
            set
            {
                this.OnPropertyChanging("Appointment_QueueItem");
                this.SetRelatedEntity<Appointment>("Appointment_QueueItem", null, value);
                this.OnPropertyChanged("Appointment_QueueItem");
            }
        }

        /// <summary>
        /// N:1 BulkOperation_QueueItem
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("BulkOperation_QueueItem")]
        public BulkOperation BulkOperation_QueueItem
        {
            get { return this.GetRelatedEntity<BulkOperation>("BulkOperation_QueueItem", null); }
            set
            {
                this.OnPropertyChanging("BulkOperation_QueueItem");
                this.SetRelatedEntity<BulkOperation>("BulkOperation_QueueItem", null, value);
                this.OnPropertyChanged("BulkOperation_QueueItem");
            }
        }

        /// <summary>
        /// N:1 CampaignActivity_QueueItem
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("CampaignActivity_QueueItem")]
        public CampaignActivity CampaignActivity_QueueItem
        {
            get { return this.GetRelatedEntity<CampaignActivity>("CampaignActivity_QueueItem", null); }
            set
            {
                this.OnPropertyChanging("CampaignActivity_QueueItem");
                this.SetRelatedEntity<CampaignActivity>("CampaignActivity_QueueItem", null, value);
                this.OnPropertyChanged("CampaignActivity_QueueItem");
            }
        }

        /// <summary>
        /// N:1 CampaignResponse_QueueItem
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("CampaignResponse_QueueItem")]
        public CampaignResponse CampaignResponse_QueueItem
        {
            get { return this.GetRelatedEntity<CampaignResponse>("CampaignResponse_QueueItem", null); }
            set
            {
                this.OnPropertyChanging("CampaignResponse_QueueItem");
                this.SetRelatedEntity<CampaignResponse>("CampaignResponse_QueueItem", null, value);
                this.OnPropertyChanged("CampaignResponse_QueueItem");
            }
        }

        /// <summary>
        /// N:1 Email_QueueItem
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Email_QueueItem")]
        public Email Email_QueueItem
        {
            get { return this.GetRelatedEntity<Email>("Email_QueueItem", null); }
            set
            {
                this.OnPropertyChanging("Email_QueueItem");
                this.SetRelatedEntity<Email>("Email_QueueItem", null, value);
                this.OnPropertyChanged("Email_QueueItem");
            }
        }

        /// <summary>
        /// N:1 Fax_QueueItem
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Fax_QueueItem")]
        public Fax Fax_QueueItem
        {
            get { return this.GetRelatedEntity<Fax>("Fax_QueueItem", null); }
            set
            {
                this.OnPropertyChanging("Fax_QueueItem");
                this.SetRelatedEntity<Fax>("Fax_QueueItem", null, value);
                this.OnPropertyChanged("Fax_QueueItem");
            }
        }

        /// <summary>
        /// N:1 Incident_QueueItem
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Incident_QueueItem")]
        public Incident Incident_QueueItem
        {
            get { return this.GetRelatedEntity<Incident>("Incident_QueueItem", null); }
            set
            {
                this.OnPropertyChanging("Incident_QueueItem");
                this.SetRelatedEntity<Incident>("Incident_QueueItem", null, value);
                this.OnPropertyChanged("Incident_QueueItem");
            }
        }

        /// <summary>
        /// N:1 Letter_QueueItem
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Letter_QueueItem")]
        public Letter Letter_QueueItem
        {
            get { return this.GetRelatedEntity<Letter>("Letter_QueueItem", null); }
            set
            {
                this.OnPropertyChanging("Letter_QueueItem");
                this.SetRelatedEntity<Letter>("Letter_QueueItem", null, value);
                this.OnPropertyChanged("Letter_QueueItem");
            }
        }

        /// <summary>
        /// N:1 lk_queueitem_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_queueitem_createdonbehalfby")]
        public SystemUser lk_queueitem_createdonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_queueitem_createdonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_queueitem_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_queueitem_modifiedonbehalfby")]
        public SystemUser lk_queueitem_modifiedonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_queueitem_modifiedonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_queueitembase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_queueitembase_createdby")]
        public SystemUser lk_queueitembase_createdby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_queueitembase_createdby", null); }
        }

        /// <summary>
        /// N:1 lk_queueitembase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_queueitembase_modifiedby")]
        public SystemUser lk_queueitembase_modifiedby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_queueitembase_modifiedby", null); }
        }

        /// <summary>
        /// N:1 lk_queueitembase_workerid
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("workerid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_queueitembase_workerid")]
        public SystemUser lk_queueitembase_workerid
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_queueitembase_workerid", null); }
            set
            {
                this.OnPropertyChanging("lk_queueitembase_workerid");
                this.SetRelatedEntity<SystemUser>("lk_queueitembase_workerid", null, value);
                this.OnPropertyChanged("lk_queueitembase_workerid");
            }
        }

        /// <summary>
        /// N:1 organization_queueitems
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_queueitems")]
        public Organization organization_queueitems
        {
            get { return this.GetRelatedEntity<Organization>("organization_queueitems", null); }
        }

        /// <summary>
        /// N:1 PhoneCall_QueueItem
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("PhoneCall_QueueItem")]
        public PhoneCall PhoneCall_QueueItem
        {
            get { return this.GetRelatedEntity<PhoneCall>("PhoneCall_QueueItem", null); }
            set
            {
                this.OnPropertyChanging("PhoneCall_QueueItem");
                this.SetRelatedEntity<PhoneCall>("PhoneCall_QueueItem", null, value);
                this.OnPropertyChanged("PhoneCall_QueueItem");
            }
        }

        /// <summary>
        /// N:1 queue_entries
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("queueid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("queue_entries")]
        public Queue queue_entries
        {
            get { return this.GetRelatedEntity<Queue>("queue_entries", null); }
            set
            {
                this.OnPropertyChanging("queue_entries");
                this.SetRelatedEntity<Queue>("queue_entries", null, value);
                this.OnPropertyChanged("queue_entries");
            }
        }

        /// <summary>
        /// N:1 RecurringAppointmentMaster_QueueItem
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("RecurringAppointmentMaster_QueueItem")]
        public RecurringAppointmentMaster RecurringAppointmentMaster_QueueItem
        {
            get { return this.GetRelatedEntity<RecurringAppointmentMaster>("RecurringAppointmentMaster_QueueItem", null); }
            set
            {
                this.OnPropertyChanging("RecurringAppointmentMaster_QueueItem");
                this.SetRelatedEntity<RecurringAppointmentMaster>("RecurringAppointmentMaster_QueueItem", null, value);
                this.OnPropertyChanged("RecurringAppointmentMaster_QueueItem");
            }
        }

        /// <summary>
        /// N:1 ServiceAppointment_QueueItem
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ServiceAppointment_QueueItem")]
        public ServiceAppointment ServiceAppointment_QueueItem
        {
            get { return this.GetRelatedEntity<ServiceAppointment>("ServiceAppointment_QueueItem", null); }
            set
            {
                this.OnPropertyChanging("ServiceAppointment_QueueItem");
                this.SetRelatedEntity<ServiceAppointment>("ServiceAppointment_QueueItem", null, value);
                this.OnPropertyChanged("ServiceAppointment_QueueItem");
            }
        }

        /// <summary>
        /// N:1 SocialActivity_QueueItem
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SocialActivity_QueueItem")]
        public SocialActivity SocialActivity_QueueItem
        {
            get { return this.GetRelatedEntity<SocialActivity>("SocialActivity_QueueItem", null); }
            set
            {
                this.OnPropertyChanging("SocialActivity_QueueItem");
                this.SetRelatedEntity<SocialActivity>("SocialActivity_QueueItem", null, value);
                this.OnPropertyChanged("SocialActivity_QueueItem");
            }
        }

        /// <summary>
        /// N:1 Task_QueueItem
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Task_QueueItem")]
        public Task Task_QueueItem
        {
            get { return this.GetRelatedEntity<Task>("Task_QueueItem", null); }
            set
            {
                this.OnPropertyChanging("Task_QueueItem");
                this.SetRelatedEntity<Task>("Task_QueueItem", null, value);
                this.OnPropertyChanged("Task_QueueItem");
            }
        }

        /// <summary>
        /// N:1 team_queueitembase_workerid
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("workerid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_queueitembase_workerid")]
        public Team team_queueitembase_workerid
        {
            get { return this.GetRelatedEntity<Team>("team_queueitembase_workerid", null); }
            set
            {
                this.OnPropertyChanging("team_queueitembase_workerid");
                this.SetRelatedEntity<Team>("team_queueitembase_workerid", null, value);
                this.OnPropertyChanged("team_queueitembase_workerid");
            }
        }

        /// <summary>
        /// N:1 TransactionCurrency_QueueItem
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("TransactionCurrency_QueueItem")]
        public TransactionCurrency TransactionCurrency_QueueItem
        {
            get { return this.GetRelatedEntity<TransactionCurrency>("TransactionCurrency_QueueItem", null); }
            set
            {
                this.OnPropertyChanging("TransactionCurrency_QueueItem");
                this.SetRelatedEntity<TransactionCurrency>("TransactionCurrency_QueueItem", null, value);
                this.OnPropertyChanged("TransactionCurrency_QueueItem");
            }
        }
    }
}