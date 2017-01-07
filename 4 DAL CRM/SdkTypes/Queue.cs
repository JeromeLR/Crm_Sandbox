namespace __4_DAL_CRM
{
    /// <summary>
    /// A list of records requiring action, such as accounts, cases, and activities.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("queue")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class Queue : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public Queue() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "queue";

        public const int EntityTypeCode = 2020;

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
        /// This attribute is no longer used. The data is now in the Mailbox.AllowEmailConnectorToUseCredentials attribute.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("allowemailcredentials")]
        [System.ObsoleteAttribute()]
        public System.Nullable<bool> AllowEmailCredentials
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("allowemailcredentials"); }
        }

        /// <summary>
        /// Unique identifier of the business unit with which the queue is associated.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("businessunitid")]
        [System.ObsoleteAttribute()]
        public Microsoft.Xrm.Sdk.EntityReference BusinessUnitId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("businessunitid"); }
            set
            {
                this.OnPropertyChanging("BusinessUnitId");
                this.SetAttributeValue("businessunitid", value);
                this.OnPropertyChanged("BusinessUnitId");
            }
        }

        /// <summary>
        /// Unique identifier of the user who created the queue record.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby"); }
        }

        /// <summary>
        /// Date and time when the queue was created.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
        public System.Nullable<System.DateTime> CreatedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who created the queue.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        /// Select the mailbox associated with this queue.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("defaultmailbox")]
        public Microsoft.Xrm.Sdk.EntityReference DefaultMailbox
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("defaultmailbox"); }
        }

        /// <summary>
        /// Description of the queue.
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
        /// Email address that is associated with the queue.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("emailaddress")]
        public string EMailAddress
        {
            get { return this.GetAttributeValue<string>("emailaddress"); }
            set
            {
                this.OnPropertyChanging("EMailAddress");
                this.SetAttributeValue("emailaddress", value);
                this.OnPropertyChanged("EMailAddress");
            }
        }

        /// <summary>
        /// This attribute is no longer used. The data is now in the Mailbox.Password attribute.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("emailpassword")]
        [System.ObsoleteAttribute()]
        public string EmailPassword
        {
            get { return this.GetAttributeValue<string>("emailpassword"); }
        }

        /// <summary>
        /// Shows the status of the primary email address.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("emailrouteraccessapproval")]
        public Microsoft.Xrm.Sdk.OptionSetValue EmailRouterAccessApproval
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("emailrouteraccessapproval"); }
            set
            {
                this.OnPropertyChanging("EmailRouterAccessApproval");
                this.SetAttributeValue("emailrouteraccessapproval", value);
                this.OnPropertyChanged("EmailRouterAccessApproval");
            }
        }

        /// <summary>
        /// This attribute is no longer used. The data is now in the Mailbox.UserName attribute.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("emailusername")]
        [System.ObsoleteAttribute()]
        public string EmailUsername
        {
            get { return this.GetAttributeValue<string>("emailusername"); }
        }

        /// <summary>
        /// The default image for the entity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entityimage")]
        public byte[] EntityImage
        {
            get { return this.GetAttributeValue<byte[]>("entityimage"); }
            set
            {
                this.OnPropertyChanging("EntityImage");
                this.SetAttributeValue("entityimage", value);
                this.OnPropertyChanged("EntityImage");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entityimage_timestamp")]
        public System.Nullable<long> EntityImage_Timestamp
        {
            get { return this.GetAttributeValue<System.Nullable<long>>("entityimage_timestamp"); }
        }

        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entityimage_url")]
        public string EntityImage_URL
        {
            get { return this.GetAttributeValue<string>("entityimage_url"); }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entityimageid")]
        public System.Nullable<System.Guid> EntityImageId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("entityimageid"); }
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
        /// Information that specifies whether a queue is to ignore unsolicited email (deprecated).
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ignoreunsolicitedemail")]
        public System.Nullable<bool> IgnoreUnsolicitedEmail
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("ignoreunsolicitedemail"); }
            set
            {
                this.OnPropertyChanging("IgnoreUnsolicitedEmail");
                this.SetAttributeValue("ignoreunsolicitedemail", value);
                this.OnPropertyChanged("IgnoreUnsolicitedEmail");
            }
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
        /// Incoming email delivery method for the queue.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("incomingemaildeliverymethod")]
        public Microsoft.Xrm.Sdk.OptionSetValue IncomingEmailDeliveryMethod
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("incomingemaildeliverymethod"); }
            set
            {
                this.OnPropertyChanging("IncomingEmailDeliveryMethod");
                this.SetAttributeValue("incomingemaildeliverymethod", value);
                this.OnPropertyChanged("IncomingEmailDeliveryMethod");
            }
        }

        /// <summary>
        /// Convert Incoming Email To Activities
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("incomingemailfilteringmethod")]
        public Microsoft.Xrm.Sdk.OptionSetValue IncomingEmailFilteringMethod
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("incomingemailfilteringmethod"); }
            set
            {
                this.OnPropertyChanging("IncomingEmailFilteringMethod");
                this.SetAttributeValue("incomingemailfilteringmethod", value);
                this.OnPropertyChanged("IncomingEmailFilteringMethod");
            }
        }

        /// <summary>
        /// Shows the status of approval of the email address by O365 Admin.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isemailaddressapprovedbyo365admin")]
        public System.Nullable<bool> IsEmailAddressApprovedByO365Admin
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("isemailaddressapprovedbyo365admin"); }
        }

        /// <summary>
        /// Indication of whether a queue is the fax delivery queue.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isfaxqueue")]
        [System.ObsoleteAttribute()]
        public System.Nullable<bool> IsFaxQueue
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("isfaxqueue"); }
        }

        /// <summary>
        /// Unique identifier of the user who last modified the queue.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby"); }
        }

        /// <summary>
        /// Date and time when the queue was last modified.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
        public System.Nullable<System.DateTime> ModifiedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who last modified the queue.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        /// Name of the queue.
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
        /// Number of Queue items associated with the queue.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("numberofitems")]
        public System.Nullable<int> NumberOfItems
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("numberofitems"); }
        }

        /// <summary>
        /// Number of Members associated with the queue.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("numberofmembers")]
        public System.Nullable<int> NumberOfMembers
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("numberofmembers"); }
        }

        /// <summary>
        /// Unique identifier of the organization associated with the queue.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
        public Microsoft.Xrm.Sdk.EntityReference OrganizationId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("organizationid"); }
        }

        /// <summary>
        /// Outgoing email delivery method for the queue.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("outgoingemaildeliverymethod")]
        public Microsoft.Xrm.Sdk.OptionSetValue OutgoingEmailDeliveryMethod
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("outgoingemaildeliverymethod"); }
            set
            {
                this.OnPropertyChanging("OutgoingEmailDeliveryMethod");
                this.SetAttributeValue("outgoingemaildeliverymethod", value);
                this.OnPropertyChanged("OutgoingEmailDeliveryMethod");
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
        /// Unique identifier of the user or team who owns the queue.
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
        /// Unique identifier of the business unit that owns the queue.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
        public Microsoft.Xrm.Sdk.EntityReference OwningBusinessUnit
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningbusinessunit"); }
        }

        /// <summary>
        /// Unique identifier of the team who owns the queue.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
        public Microsoft.Xrm.Sdk.EntityReference OwningTeam
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningteam"); }
        }

        /// <summary>
        /// Unique identifier of the user who owns the queue.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
        public Microsoft.Xrm.Sdk.EntityReference OwningUser
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owninguser"); }
        }

        /// <summary>
        /// Unique identifier of the owner of the queue.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("primaryuserid")]
        [System.ObsoleteAttribute()]
        public Microsoft.Xrm.Sdk.EntityReference PrimaryUserId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("primaryuserid"); }
            set
            {
                this.OnPropertyChanging("PrimaryUserId");
                this.SetAttributeValue("primaryuserid", value);
                this.OnPropertyChanged("PrimaryUserId");
            }
        }

        /// <summary>
        /// Unique identifier of the queue.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("queueid")]
        public System.Nullable<System.Guid> QueueId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("queueid"); }
            set
            {
                this.OnPropertyChanging("QueueId");
                this.SetAttributeValue("queueid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("QueueId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("queueid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.QueueId = value; }
        }

        /// <summary>
        /// Type of queue that is automatically assigned when a user or queue is created. The type can be public, private, or work in process.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("queuetypecode")]
        public Microsoft.Xrm.Sdk.OptionSetValue QueueTypeCode
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("queuetypecode"); }
        }

        /// <summary>
        /// Select whether the queue is public or private. A public queue can be viewed by all. A private queue can be viewed only by the members added to the queue.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("queueviewtype")]
        public Microsoft.Xrm.Sdk.OptionSetValue QueueViewType
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("queueviewtype"); }
            set
            {
                this.OnPropertyChanging("QueueViewType");
                this.SetAttributeValue("queueviewtype", value);
                this.OnPropertyChanged("QueueViewType");
            }
        }

        /// <summary>
        /// Status of the queue.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
        public System.Nullable<QueueState> StateCode
        {
            get
            {
                Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
                if ((optionSet != null))
                {
                    return ((QueueState) (System.Enum.ToObject(typeof(QueueState), optionSet.Value)));
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// Reason for the status of the queue.
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
        /// Version number of the queue.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
        public System.Nullable<long> VersionNumber
        {
            get { return this.GetAttributeValue<System.Nullable<long>>("versionnumber"); }
        }

        /// <summary>
        /// 1:N convertrule_queue
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("convertrule_queue")]
        public System.Collections.Generic.IEnumerable<ConvertRule> convertrule_queue
        {
            get { return this.GetRelatedEntities<ConvertRule>("convertrule_queue", null); }
            set
            {
                this.OnPropertyChanging("convertrule_queue");
                this.SetRelatedEntities<ConvertRule>("convertrule_queue", null, value);
                this.OnPropertyChanged("convertrule_queue");
            }
        }

        /// <summary>
        /// 1:N mailbox_regarding_queue
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("mailbox_regarding_queue")]
        public System.Collections.Generic.IEnumerable<Mailbox> mailbox_regarding_queue
        {
            get { return this.GetRelatedEntities<Mailbox>("mailbox_regarding_queue", null); }
            set
            {
                this.OnPropertyChanging("mailbox_regarding_queue");
                this.SetRelatedEntities<Mailbox>("mailbox_regarding_queue", null, value);
                this.OnPropertyChanged("mailbox_regarding_queue");
            }
        }

        /// <summary>
        /// 1:N queue_activity_parties
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("queue_activity_parties")]
        public System.Collections.Generic.IEnumerable<ActivityParty> queue_activity_parties
        {
            get { return this.GetRelatedEntities<ActivityParty>("queue_activity_parties", null); }
            set
            {
                this.OnPropertyChanging("queue_activity_parties");
                this.SetRelatedEntities<ActivityParty>("queue_activity_parties", null, value);
                this.OnPropertyChanged("queue_activity_parties");
            }
        }

        /// <summary>
        /// 1:N Queue_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Queue_AsyncOperations")]
        public System.Collections.Generic.IEnumerable<AsyncOperation> Queue_AsyncOperations
        {
            get { return this.GetRelatedEntities<AsyncOperation>("Queue_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("Queue_AsyncOperations");
                this.SetRelatedEntities<AsyncOperation>("Queue_AsyncOperations", null, value);
                this.OnPropertyChanged("Queue_AsyncOperations");
            }
        }

        /// <summary>
        /// 1:N Queue_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Queue_BulkDeleteFailures")]
        public System.Collections.Generic.IEnumerable<BulkDeleteFailure> Queue_BulkDeleteFailures
        {
            get { return this.GetRelatedEntities<BulkDeleteFailure>("Queue_BulkDeleteFailures", null); }
            set
            {
                this.OnPropertyChanging("Queue_BulkDeleteFailures");
                this.SetRelatedEntities<BulkDeleteFailure>("Queue_BulkDeleteFailures", null, value);
                this.OnPropertyChanged("Queue_BulkDeleteFailures");
            }
        }

        /// <summary>
        /// 1:N queue_convertruleitem
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("queue_convertruleitem")]
        public System.Collections.Generic.IEnumerable<ConvertRuleItem> queue_convertruleitem
        {
            get { return this.GetRelatedEntities<ConvertRuleItem>("queue_convertruleitem", null); }
            set
            {
                this.OnPropertyChanging("queue_convertruleitem");
                this.SetRelatedEntities<ConvertRuleItem>("queue_convertruleitem", null, value);
                this.OnPropertyChanged("queue_convertruleitem");
            }
        }

        /// <summary>
        /// 1:N Queue_DuplicateBaseRecord
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Queue_DuplicateBaseRecord")]
        public System.Collections.Generic.IEnumerable<DuplicateRecord> Queue_DuplicateBaseRecord
        {
            get { return this.GetRelatedEntities<DuplicateRecord>("Queue_DuplicateBaseRecord", null); }
            set
            {
                this.OnPropertyChanging("Queue_DuplicateBaseRecord");
                this.SetRelatedEntities<DuplicateRecord>("Queue_DuplicateBaseRecord", null, value);
                this.OnPropertyChanged("Queue_DuplicateBaseRecord");
            }
        }

        /// <summary>
        /// 1:N Queue_DuplicateMatchingRecord
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Queue_DuplicateMatchingRecord")]
        public System.Collections.Generic.IEnumerable<DuplicateRecord> Queue_DuplicateMatchingRecord
        {
            get { return this.GetRelatedEntities<DuplicateRecord>("Queue_DuplicateMatchingRecord", null); }
            set
            {
                this.OnPropertyChanging("Queue_DuplicateMatchingRecord");
                this.SetRelatedEntities<DuplicateRecord>("Queue_DuplicateMatchingRecord", null, value);
                this.OnPropertyChanged("Queue_DuplicateMatchingRecord");
            }
        }

        /// <summary>
        /// 1:N Queue_Email_EmailSender
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Queue_Email_EmailSender")]
        public System.Collections.Generic.IEnumerable<Email> Queue_Email_EmailSender
        {
            get { return this.GetRelatedEntities<Email>("Queue_Email_EmailSender", null); }
            set
            {
                this.OnPropertyChanging("Queue_Email_EmailSender");
                this.SetRelatedEntities<Email>("Queue_Email_EmailSender", null, value);
                this.OnPropertyChanged("Queue_Email_EmailSender");
            }
        }

        /// <summary>
        /// 1:N queue_entries
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("queue_entries")]
        public System.Collections.Generic.IEnumerable<QueueItem> queue_entries
        {
            get { return this.GetRelatedEntities<QueueItem>("queue_entries", null); }
            set
            {
                this.OnPropertyChanging("queue_entries");
                this.SetRelatedEntities<QueueItem>("queue_entries", null, value);
                this.OnPropertyChanged("queue_entries");
            }
        }

        /// <summary>
        /// 1:N queue_PostFollows
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("queue_PostFollows")]
        public System.Collections.Generic.IEnumerable<PostFollow> queue_PostFollows
        {
            get { return this.GetRelatedEntities<PostFollow>("queue_PostFollows", null); }
            set
            {
                this.OnPropertyChanging("queue_PostFollows");
                this.SetRelatedEntities<PostFollow>("queue_PostFollows", null, value);
                this.OnPropertyChanged("queue_PostFollows");
            }
        }

        /// <summary>
        /// 1:N queue_principalobjectattributeaccess
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("queue_principalobjectattributeaccess")]
        public System.Collections.Generic.IEnumerable<PrincipalObjectAttributeAccess> queue_principalobjectattributeaccess
        {
            get { return this.GetRelatedEntities<PrincipalObjectAttributeAccess>("queue_principalobjectattributeaccess", null); }
            set
            {
                this.OnPropertyChanging("queue_principalobjectattributeaccess");
                this.SetRelatedEntities<PrincipalObjectAttributeAccess>("queue_principalobjectattributeaccess", null, value);
                this.OnPropertyChanged("queue_principalobjectattributeaccess");
            }
        }

        /// <summary>
        /// 1:N Queue_ProcessSessions
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Queue_ProcessSessions")]
        public System.Collections.Generic.IEnumerable<ProcessSession> Queue_ProcessSessions
        {
            get { return this.GetRelatedEntities<ProcessSession>("Queue_ProcessSessions", null); }
            set
            {
                this.OnPropertyChanging("Queue_ProcessSessions");
                this.SetRelatedEntities<ProcessSession>("Queue_ProcessSessions", null, value);
                this.OnPropertyChanged("Queue_ProcessSessions");
            }
        }

        /// <summary>
        /// 1:N queue_routingruleitem
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("queue_routingruleitem")]
        public System.Collections.Generic.IEnumerable<RoutingRuleItem> queue_routingruleitem
        {
            get { return this.GetRelatedEntities<RoutingRuleItem>("queue_routingruleitem", null); }
            set
            {
                this.OnPropertyChanging("queue_routingruleitem");
                this.SetRelatedEntities<RoutingRuleItem>("queue_routingruleitem", null, value);
                this.OnPropertyChanged("queue_routingruleitem");
            }
        }

        /// <summary>
        /// 1:N queue_system_user
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("queue_system_user")]
        public System.Collections.Generic.IEnumerable<SystemUser> queue_system_user
        {
            get { return this.GetRelatedEntities<SystemUser>("queue_system_user", null); }
            set
            {
                this.OnPropertyChanging("queue_system_user");
                this.SetRelatedEntities<SystemUser>("queue_system_user", null, value);
                this.OnPropertyChanged("queue_system_user");
            }
        }

        /// <summary>
        /// 1:N queue_team
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("queue_team")]
        public System.Collections.Generic.IEnumerable<Team> queue_team
        {
            get { return this.GetRelatedEntities<Team>("queue_team", null); }
            set
            {
                this.OnPropertyChanging("queue_team");
                this.SetRelatedEntities<Team>("queue_team", null, value);
                this.OnPropertyChanged("queue_team");
            }
        }

        /// <summary>
        /// 1:N userentityinstancedata_queue
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_queue")]
        public System.Collections.Generic.IEnumerable<UserEntityInstanceData> userentityinstancedata_queue
        {
            get { return this.GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_queue", null); }
            set
            {
                this.OnPropertyChanging("userentityinstancedata_queue");
                this.SetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_queue", null, value);
                this.OnPropertyChanged("userentityinstancedata_queue");
            }
        }

        /// <summary>
        /// N:N queuemembership_association
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("queuemembership_association")]
        public System.Collections.Generic.IEnumerable<SystemUser> queuemembership_association
        {
            get { return this.GetRelatedEntities<SystemUser>("queuemembership_association", null); }
            set
            {
                this.OnPropertyChanging("queuemembership_association");
                this.SetRelatedEntities<SystemUser>("queuemembership_association", null, value);
                this.OnPropertyChanged("queuemembership_association");
            }
        }

        /// <summary>
        /// N:1 business_unit_queues
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("businessunitid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_queues")]
        public BusinessUnit business_unit_queues
        {
            get { return this.GetRelatedEntity<BusinessUnit>("business_unit_queues", null); }
            set
            {
                this.OnPropertyChanging("business_unit_queues");
                this.SetRelatedEntity<BusinessUnit>("business_unit_queues", null, value);
                this.OnPropertyChanged("business_unit_queues");
            }
        }

        /// <summary>
        /// N:1 business_unit_queues2
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_queues2")]
        public BusinessUnit business_unit_queues2
        {
            get { return this.GetRelatedEntity<BusinessUnit>("business_unit_queues2", null); }
        }

        /// <summary>
        /// N:1 lk_queue_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_queue_createdonbehalfby")]
        public SystemUser lk_queue_createdonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_queue_createdonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_queue_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_queue_modifiedonbehalfby")]
        public SystemUser lk_queue_modifiedonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_queue_modifiedonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_queuebase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_queuebase_createdby")]
        public SystemUser lk_queuebase_createdby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_queuebase_createdby", null); }
        }

        /// <summary>
        /// N:1 lk_queuebase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_queuebase_modifiedby")]
        public SystemUser lk_queuebase_modifiedby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_queuebase_modifiedby", null); }
        }

        /// <summary>
        /// N:1 organization_queues
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_queues")]
        public Organization organization_queues
        {
            get { return this.GetRelatedEntity<Organization>("organization_queues", null); }
        }

        /// <summary>
        /// N:1 queue_defaultmailbox_mailbox
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("defaultmailbox")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("queue_defaultmailbox_mailbox")]
        public Mailbox queue_defaultmailbox_mailbox
        {
            get { return this.GetRelatedEntity<Mailbox>("queue_defaultmailbox_mailbox", null); }
        }

        /// <summary>
        /// N:1 queue_primary_user
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("primaryuserid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("queue_primary_user")]
        public SystemUser queue_primary_user
        {
            get { return this.GetRelatedEntity<SystemUser>("queue_primary_user", null); }
            set
            {
                this.OnPropertyChanging("queue_primary_user");
                this.SetRelatedEntity<SystemUser>("queue_primary_user", null, value);
                this.OnPropertyChanged("queue_primary_user");
            }
        }

        /// <summary>
        /// N:1 TransactionCurrency_Queue
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("TransactionCurrency_Queue")]
        public TransactionCurrency TransactionCurrency_Queue
        {
            get { return this.GetRelatedEntity<TransactionCurrency>("TransactionCurrency_Queue", null); }
            set
            {
                this.OnPropertyChanging("TransactionCurrency_Queue");
                this.SetRelatedEntity<TransactionCurrency>("TransactionCurrency_Queue", null, value);
                this.OnPropertyChanged("TransactionCurrency_Queue");
            }
        }
    }
}