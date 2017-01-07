using _4_DAL_CRM;

namespace __4_DAL_CRM
{
    /// <summary>
    /// Activity that is delivered using email protocols.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("email")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class Email : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public Email() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "email";

        public const int EntityTypeCode = 4202;

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
        /// Unique identifier of the email activity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("activityid")]
        public System.Nullable<System.Guid> ActivityId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("activityid"); }
            set
            {
                this.OnPropertyChanging("ActivityId");
                this.SetAttributeValue("activityid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("ActivityId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("activityid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.ActivityId = value; }
        }

        /// <summary>
        /// Shows the type of activity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("activitytypecode")]
        public string ActivityTypeCode
        {
            get { return this.GetAttributeValue<string>("activitytypecode"); }
        }

        /// <summary>
        /// Type the number of minutes spent creating and sending the email. The duration is used in reporting.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("actualdurationminutes")]
        public System.Nullable<int> ActualDurationMinutes
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("actualdurationminutes"); }
            set
            {
                this.OnPropertyChanging("ActualDurationMinutes");
                this.SetAttributeValue("actualdurationminutes", value);
                this.OnPropertyChanged("ActualDurationMinutes");
            }
        }

        /// <summary>
        /// Enter the actual end date and time of the email. By default, it displays the date and time when the activity was completed or canceled, but can be edited to capture the actual time to create and send the email.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("actualend")]
        public System.Nullable<System.DateTime> ActualEnd
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("actualend"); }
            set
            {
                this.OnPropertyChanging("ActualEnd");
                this.SetAttributeValue("actualend", value);
                this.OnPropertyChanged("ActualEnd");
            }
        }

        /// <summary>
        /// Enter the actual start date and time for the email. By default, it displays the date and time when the activity was created, but can be edited to capture the actual time to create and send the email.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("actualstart")]
        public System.Nullable<System.DateTime> ActualStart
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("actualstart"); }
            set
            {
                this.OnPropertyChanging("ActualStart");
                this.SetAttributeValue("actualstart", value);
                this.OnPropertyChanged("ActualStart");
            }
        }

        /// <summary>
        /// Shows the umber of attachments of the email message.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("attachmentcount")]
        public System.Nullable<int> AttachmentCount
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("attachmentcount"); }
        }

        /// <summary>
        /// Enter the recipients that are included on the email distribution, but are not displayed to other recipients.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("bcc")]
        public System.Collections.Generic.IEnumerable<ActivityParty> Bcc
        {
            get
            {
                Microsoft.Xrm.Sdk.EntityCollection collection = this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityCollection>("bcc");
                if (((collection != null)
                     && (collection.Entities != null)))
                {
                    return System.Linq.Enumerable.Cast<ActivityParty>(collection.Entities);
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.OnPropertyChanging("Bcc");
                if ((value == null))
                {
                    this.SetAttributeValue("bcc", value);
                }
                else
                {
                    this.SetAttributeValue("bcc", new Microsoft.Xrm.Sdk.EntityCollection(new System.Collections.Generic.List<Microsoft.Xrm.Sdk.Entity>(value)));
                }
                this.OnPropertyChanged("Bcc");
            }
        }

        /// <summary>
        /// Type a category to identify the email type, such as lead outreach, customer follow-up, or service alert, to tie the email to a business group or function.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("category")]
        public string Category
        {
            get { return this.GetAttributeValue<string>("category"); }
            set
            {
                this.OnPropertyChanging("Category");
                this.SetAttributeValue("category", value);
                this.OnPropertyChanged("Category");
            }
        }

        /// <summary>
        /// Enter the recipients that should be copied on the email.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("cc")]
        public System.Collections.Generic.IEnumerable<ActivityParty> Cc
        {
            get
            {
                Microsoft.Xrm.Sdk.EntityCollection collection = this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityCollection>("cc");
                if (((collection != null)
                     && (collection.Entities != null)))
                {
                    return System.Linq.Enumerable.Cast<ActivityParty>(collection.Entities);
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.OnPropertyChanging("Cc");
                if ((value == null))
                {
                    this.SetAttributeValue("cc", value);
                }
                else
                {
                    this.SetAttributeValue("cc", new Microsoft.Xrm.Sdk.EntityCollection(new System.Collections.Generic.List<Microsoft.Xrm.Sdk.Entity>(value)));
                }
                this.OnPropertyChanged("Cc");
            }
        }

        /// <summary>
        /// Indicates if the body is compressed.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("compressed")]
        public System.Nullable<bool> Compressed
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("compressed"); }
        }

        /// <summary>
        /// Identifier for all the email responses for this conversation.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("conversationindex")]
        public string ConversationIndex
        {
            get { return this.GetAttributeValue<string>("conversationindex"); }
        }

        /// <summary>
        /// Shows how an email is matched to an existing email in Microsoft Dynamics CRM. For system use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("correlationmethod")]
        public Microsoft.Xrm.Sdk.OptionSetValue CorrelationMethod
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("correlationmethod"); }
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
        /// Shows the count of the number of attempts made to send the email. The count is used as an indicator of email routing issues.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("deliveryattempts")]
        public System.Nullable<int> DeliveryAttempts
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("deliveryattempts"); }
            set
            {
                this.OnPropertyChanging("DeliveryAttempts");
                this.SetAttributeValue("deliveryattempts", value);
                this.OnPropertyChanged("DeliveryAttempts");
            }
        }

        /// <summary>
        /// Select the priority of delivery of the email to the email server.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("deliveryprioritycode")]
        public Microsoft.Xrm.Sdk.OptionSetValue DeliveryPriorityCode
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("deliveryprioritycode"); }
            set
            {
                this.OnPropertyChanging("DeliveryPriorityCode");
                this.SetAttributeValue("deliveryprioritycode", value);
                this.OnPropertyChanged("DeliveryPriorityCode");
            }
        }

        /// <summary>
        /// Select whether the sender should receive confirmation that the email was delivered.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("deliveryreceiptrequested")]
        public System.Nullable<bool> DeliveryReceiptRequested
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("deliveryreceiptrequested"); }
            set
            {
                this.OnPropertyChanging("DeliveryReceiptRequested");
                this.SetAttributeValue("deliveryreceiptrequested", value);
                this.OnPropertyChanged("DeliveryReceiptRequested");
            }
        }

        /// <summary>
        /// Type the greeting and message text of the email.
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
        /// Select the direction of the email as incoming or outbound.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("directioncode")]
        public System.Nullable<bool> DirectionCode
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("directioncode"); }
            set
            {
                this.OnPropertyChanging("DirectionCode");
                this.SetAttributeValue("directioncode", value);
                this.OnPropertyChanged("DirectionCode");
            }
        }

        /// <summary>
        /// Shows the sender of the email.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("emailsender")]
        public Microsoft.Xrm.Sdk.EntityReference EmailSender
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("emailsender"); }
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
        /// Enter the sender of the email.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("from")]
        public System.Collections.Generic.IEnumerable<ActivityParty> From
        {
            get
            {
                Microsoft.Xrm.Sdk.EntityCollection collection = this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityCollection>("from");
                if (((collection != null)
                     && (collection.Entities != null)))
                {
                    return System.Linq.Enumerable.Cast<ActivityParty>(collection.Entities);
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.OnPropertyChanging("From");
                if ((value == null))
                {
                    this.SetAttributeValue("from", value);
                }
                else
                {
                    this.SetAttributeValue("from", new Microsoft.Xrm.Sdk.EntityCollection(new System.Collections.Generic.List<Microsoft.Xrm.Sdk.Entity>(value)));
                }
                this.OnPropertyChanged("From");
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
        /// Type the ID of the email message that this email activity is a response to.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("inreplyto")]
        public string InReplyTo
        {
            get { return this.GetAttributeValue<string>("inreplyto"); }
        }

        /// <summary>
        /// Information regarding whether the email activity was billed as part of resolving a case.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isbilled")]
        public System.Nullable<bool> IsBilled
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("isbilled"); }
            set
            {
                this.OnPropertyChanging("IsBilled");
                this.SetAttributeValue("isbilled", value);
                this.OnPropertyChanged("IsBilled");
            }
        }

        /// <summary>
        /// Information regarding whether the activity is a regular activity type or event type.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isregularactivity")]
        public System.Nullable<bool> IsRegularActivity
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("isregularactivity"); }
        }

        /// <summary>
        /// Indication if the email was created by a workflow rule.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isworkflowcreated")]
        public System.Nullable<bool> IsWorkflowCreated
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("isworkflowcreated"); }
            set
            {
                this.OnPropertyChanging("IsWorkflowCreated");
                this.SetAttributeValue("isworkflowcreated", value);
                this.OnPropertyChanged("IsWorkflowCreated");
            }
        }

        /// <summary>
        /// Unique identifier of the email message. Used only for email that is received.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("messageid")]
        public string MessageId
        {
            get { return this.GetAttributeValue<string>("messageid"); }
            set
            {
                this.OnPropertyChanging("MessageId");
                this.SetAttributeValue("messageid", value);
                this.OnPropertyChanged("MessageId");
            }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("messageiddupcheck")]
        [System.ObsoleteAttribute()]
        public System.Nullable<System.Guid> MessageIdDupCheck
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("messageiddupcheck"); }
            set
            {
                this.OnPropertyChanging("MessageIdDupCheck");
                this.SetAttributeValue("messageiddupcheck", value);
                this.OnPropertyChanged("MessageIdDupCheck");
            }
        }

        /// <summary>
        /// MIME type of the email message data.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("mimetype")]
        public string MimeType
        {
            get { return this.GetAttributeValue<string>("mimetype"); }
            set
            {
                this.OnPropertyChanging("MimeType");
                this.SetAttributeValue("mimetype", value);
                this.OnPropertyChanged("MimeType");
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
        /// Select the notification code to identify issues with the email recipients or attachments, such as blocked attachments.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("notifications")]
        public Microsoft.Xrm.Sdk.OptionSetValue Notifications
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("notifications"); }
            set
            {
                this.OnPropertyChanging("Notifications");
                this.SetAttributeValue("notifications", value);
                this.OnPropertyChanged("Notifications");
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
        /// Unique identifier of the business unit that owns the email activity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
        public Microsoft.Xrm.Sdk.EntityReference OwningBusinessUnit
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningbusinessunit"); }
        }

        /// <summary>
        /// Unique identifier of the team who owns the email activity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
        public Microsoft.Xrm.Sdk.EntityReference OwningTeam
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningteam"); }
        }

        /// <summary>
        /// Unique identifier of the user who owns the email activity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
        public Microsoft.Xrm.Sdk.EntityReference OwningUser
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owninguser"); }
        }

        /// <summary>
        /// Select the activity that the email is associated with.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("parentactivityid")]
        public Microsoft.Xrm.Sdk.EntityReference ParentActivityId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("parentactivityid"); }
            set
            {
                this.OnPropertyChanging("ParentActivityId");
                this.SetAttributeValue("parentactivityid", value);
                this.OnPropertyChanged("ParentActivityId");
            }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("postponeemailprocessinguntil")]
        public System.Nullable<System.DateTime> PostponeEmailProcessingUntil
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("postponeemailprocessinguntil"); }
        }

        /// <summary>
        /// Select the priority so that preferred customers or critical issues are handled quickly.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("prioritycode")]
        public Microsoft.Xrm.Sdk.OptionSetValue PriorityCode
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("prioritycode"); }
            set
            {
                this.OnPropertyChanging("PriorityCode");
                this.SetAttributeValue("prioritycode", value);
                this.OnPropertyChanged("PriorityCode");
            }
        }

        /// <summary>
        /// Shows the ID of the process.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("processid")]
        public System.Nullable<System.Guid> ProcessId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("processid"); }
            set
            {
                this.OnPropertyChanging("ProcessId");
                this.SetAttributeValue("processid", value);
                this.OnPropertyChanged("ProcessId");
            }
        }

        /// <summary>
        /// Indicates that a read receipt is requested.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("readreceiptrequested")]
        public System.Nullable<bool> ReadReceiptRequested
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("readreceiptrequested"); }
            set
            {
                this.OnPropertyChanging("ReadReceiptRequested");
                this.SetAttributeValue("readreceiptrequested", value);
                this.OnPropertyChanged("ReadReceiptRequested");
            }
        }

        /// <summary>
        /// Unique identifier of the object with which the e-mail is associated.
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
        /// Scheduled duration of the email activity, specified in minutes.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("scheduleddurationminutes")]
        public System.Nullable<int> ScheduledDurationMinutes
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("scheduleddurationminutes"); }
        }

        /// <summary>
        /// Enter the expected due date and time for the activity to be completed to provide details about when the email will be sent.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("scheduledend")]
        public System.Nullable<System.DateTime> ScheduledEnd
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("scheduledend"); }
            set
            {
                this.OnPropertyChanging("ScheduledEnd");
                this.SetAttributeValue("scheduledend", value);
                this.OnPropertyChanged("ScheduledEnd");
            }
        }

        /// <summary>
        /// Enter the expected start date and time for the activity to provide details about the tentative time when the email activity must be initiated.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("scheduledstart")]
        public System.Nullable<System.DateTime> ScheduledStart
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("scheduledstart"); }
            set
            {
                this.OnPropertyChanging("ScheduledStart");
                this.SetAttributeValue("scheduledstart", value);
                this.OnPropertyChanged("ScheduledStart");
            }
        }

        /// <summary>
        /// Sender of the email.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sender")]
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
        /// Select the mailbox associated with the sender of the email message.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sendermailboxid")]
        public Microsoft.Xrm.Sdk.EntityReference SenderMailboxId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("sendermailboxid"); }
        }

        /// <summary>
        /// Shows the parent account of the sender of the email.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sendersaccount")]
        public Microsoft.Xrm.Sdk.EntityReference SendersAccount
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("sendersaccount"); }
        }

        /// <summary>
        /// Shows the date and time that the email was sent.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("senton")]
        public System.Nullable<System.DateTime> SentOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("senton"); }
        }

        /// <summary>
        /// Unique identifier for the associated service.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("serviceid")]
        public Microsoft.Xrm.Sdk.EntityReference ServiceId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("serviceid"); }
            set
            {
                this.OnPropertyChanging("ServiceId");
                this.SetAttributeValue("serviceid", value);
                this.OnPropertyChanged("ServiceId");
            }
        }

        /// <summary>
        /// Shows the ID of the stage.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("stageid")]
        public System.Nullable<System.Guid> StageId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("stageid"); }
            set
            {
                this.OnPropertyChanging("StageId");
                this.SetAttributeValue("stageid", value);
                this.OnPropertyChanged("StageId");
            }
        }

        /// <summary>
        /// Shows whether the email is open, completed, or canceled. Completed and canceled email is read-only and can't be edited.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
        public System.Nullable<EmailState> StateCode
        {
            get
            {
                Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
                if ((optionSet != null))
                {
                    return ((EmailState) (System.Enum.ToObject(typeof(EmailState), optionSet.Value)));
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// Select the email's status.
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
        /// Type a subcategory to identify the email type and relate the activity to a specific product, sales region, business group, or other function.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("subcategory")]
        public string Subcategory
        {
            get { return this.GetAttributeValue<string>("subcategory"); }
            set
            {
                this.OnPropertyChanging("Subcategory");
                this.SetAttributeValue("subcategory", value);
                this.OnPropertyChanged("Subcategory");
            }
        }

        /// <summary>
        /// Type a short description about the objective or primary topic of the email.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("subject")]
        public string Subject
        {
            get { return this.GetAttributeValue<string>("subject"); }
            set
            {
                this.OnPropertyChanging("Subject");
                this.SetAttributeValue("subject", value);
                this.OnPropertyChanged("Subject");
            }
        }

        /// <summary>
        /// Shows the Microsoft Office Outlook account for the user who submitted the email to Microsoft Dynamics CRM.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("submittedby")]
        public string SubmittedBy
        {
            get { return this.GetAttributeValue<string>("submittedby"); }
            set
            {
                this.OnPropertyChanging("SubmittedBy");
                this.SetAttributeValue("submittedby", value);
                this.OnPropertyChanged("SubmittedBy");
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
        /// Enter the account, contact, lead, queue, or user recipients for the email.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("to")]
        public System.Collections.Generic.IEnumerable<ActivityParty> To
        {
            get
            {
                Microsoft.Xrm.Sdk.EntityCollection collection = this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityCollection>("to");
                if (((collection != null)
                     && (collection.Entities != null)))
                {
                    return System.Linq.Enumerable.Cast<ActivityParty>(collection.Entities);
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.OnPropertyChanging("To");
                if ((value == null))
                {
                    this.SetAttributeValue("to", value);
                }
                else
                {
                    this.SetAttributeValue("to", new Microsoft.Xrm.Sdk.EntityCollection(new System.Collections.Generic.List<Microsoft.Xrm.Sdk.Entity>(value)));
                }
                this.OnPropertyChanged("To");
            }
        }

        /// <summary>
        /// Shows the email addresses corresponding to the recipients.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("torecipients")]
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
        /// Shows the tracking token assigned to the email to make sure responses are automatically tracked in Microsoft Dynamics CRM.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("trackingtoken")]
        public string TrackingToken
        {
            get { return this.GetAttributeValue<string>("trackingtoken"); }
            set
            {
                this.OnPropertyChanging("TrackingToken");
                this.SetAttributeValue("trackingtoken", value);
                this.OnPropertyChanged("TrackingToken");
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
        /// A comma separated list of string values representing the unique identifiers of stages in a Business Process Flow Instance in the order that they occur.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("traversedpath")]
        public string TraversedPath
        {
            get { return this.GetAttributeValue<string>("traversedpath"); }
            set
            {
                this.OnPropertyChanging("TraversedPath");
                this.SetAttributeValue("traversedpath", value);
                this.OnPropertyChanged("TraversedPath");
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
        /// Version number of the email message.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
        public System.Nullable<long> VersionNumber
        {
            get { return this.GetAttributeValue<System.Nullable<long>>("versionnumber"); }
        }

        /// <summary>
        /// 1:N email_activity_mime_attachment
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("email_activity_mime_attachment")]
        public System.Collections.Generic.IEnumerable<ActivityMimeAttachment> email_activity_mime_attachment
        {
            get { return this.GetRelatedEntities<ActivityMimeAttachment>("email_activity_mime_attachment", null); }
            set
            {
                this.OnPropertyChanging("email_activity_mime_attachment");
                this.SetRelatedEntities<ActivityMimeAttachment>("email_activity_mime_attachment", null, value);
                this.OnPropertyChanged("email_activity_mime_attachment");
            }
        }

        /// <summary>
        /// 1:N email_activity_parties
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("email_activity_parties")]
        public System.Collections.Generic.IEnumerable<ActivityParty> email_activity_parties
        {
            get { return this.GetRelatedEntities<ActivityParty>("email_activity_parties", null); }
            set
            {
                this.OnPropertyChanging("email_activity_parties");
                this.SetRelatedEntities<ActivityParty>("email_activity_parties", null, value);
                this.OnPropertyChanged("email_activity_parties");
            }
        }

        /// <summary>
        /// 1:N Email_Annotation
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Email_Annotation")]
        public System.Collections.Generic.IEnumerable<Annotation> Email_Annotation
        {
            get { return this.GetRelatedEntities<Annotation>("Email_Annotation", null); }
            set
            {
                this.OnPropertyChanging("Email_Annotation");
                this.SetRelatedEntities<Annotation>("Email_Annotation", null, value);
                this.OnPropertyChanged("Email_Annotation");
            }
        }

        /// <summary>
        /// 1:N Email_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Email_AsyncOperations")]
        public System.Collections.Generic.IEnumerable<AsyncOperation> Email_AsyncOperations
        {
            get { return this.GetRelatedEntities<AsyncOperation>("Email_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("Email_AsyncOperations");
                this.SetRelatedEntities<AsyncOperation>("Email_AsyncOperations", null, value);
                this.OnPropertyChanged("Email_AsyncOperations");
            }
        }

        /// <summary>
        /// 1:N Email_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Email_BulkDeleteFailures")]
        public System.Collections.Generic.IEnumerable<BulkDeleteFailure> Email_BulkDeleteFailures
        {
            get { return this.GetRelatedEntities<BulkDeleteFailure>("Email_BulkDeleteFailures", null); }
            set
            {
                this.OnPropertyChanging("Email_BulkDeleteFailures");
                this.SetRelatedEntities<BulkDeleteFailure>("Email_BulkDeleteFailures", null, value);
                this.OnPropertyChanged("Email_BulkDeleteFailures");
            }
        }

        /// <summary>
        /// 1:N email_campaignresponse
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("email_campaignresponse")]
        public System.Collections.Generic.IEnumerable<CampaignResponse> email_campaignresponse
        {
            get { return this.GetRelatedEntities<CampaignResponse>("email_campaignresponse", null); }
            set
            {
                this.OnPropertyChanging("email_campaignresponse");
                this.SetRelatedEntities<CampaignResponse>("email_campaignresponse", null, value);
                this.OnPropertyChanged("email_campaignresponse");
            }
        }

        /// <summary>
        /// 1:N email_connections1
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("email_connections1")]
        public System.Collections.Generic.IEnumerable<Connection> email_connections1
        {
            get { return this.GetRelatedEntities<Connection>("email_connections1", null); }
            set
            {
                this.OnPropertyChanging("email_connections1");
                this.SetRelatedEntities<Connection>("email_connections1", null, value);
                this.OnPropertyChanged("email_connections1");
            }
        }

        /// <summary>
        /// 1:N email_connections2
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("email_connections2")]
        public System.Collections.Generic.IEnumerable<Connection> email_connections2
        {
            get { return this.GetRelatedEntities<Connection>("email_connections2", null); }
            set
            {
                this.OnPropertyChanging("email_connections2");
                this.SetRelatedEntities<Connection>("email_connections2", null, value);
                this.OnPropertyChanged("email_connections2");
            }
        }

        /// <summary>
        /// 1:N Email_DuplicateBaseRecord
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Email_DuplicateBaseRecord")]
        public System.Collections.Generic.IEnumerable<DuplicateRecord> Email_DuplicateBaseRecord
        {
            get { return this.GetRelatedEntities<DuplicateRecord>("Email_DuplicateBaseRecord", null); }
            set
            {
                this.OnPropertyChanging("Email_DuplicateBaseRecord");
                this.SetRelatedEntities<DuplicateRecord>("Email_DuplicateBaseRecord", null, value);
                this.OnPropertyChanged("Email_DuplicateBaseRecord");
            }
        }

        /// <summary>
        /// 1:N Email_DuplicateMatchingRecord
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Email_DuplicateMatchingRecord")]
        public System.Collections.Generic.IEnumerable<DuplicateRecord> Email_DuplicateMatchingRecord
        {
            get { return this.GetRelatedEntities<DuplicateRecord>("Email_DuplicateMatchingRecord", null); }
            set
            {
                this.OnPropertyChanging("Email_DuplicateMatchingRecord");
                this.SetRelatedEntities<DuplicateRecord>("Email_DuplicateMatchingRecord", null, value);
                this.OnPropertyChanged("Email_DuplicateMatchingRecord");
            }
        }

        /// <summary>
        /// 1:N email_email_parentactivityid
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("email_email_parentactivityid", Microsoft.Xrm.Sdk.EntityRole.Referenced)]
        public System.Collections.Generic.IEnumerable<Email> Referencedemail_email_parentactivityid
        {
            get { return this.GetRelatedEntities<Email>("email_email_parentactivityid", Microsoft.Xrm.Sdk.EntityRole.Referenced); }
            set
            {
                this.OnPropertyChanging("Referencedemail_email_parentactivityid");
                this.SetRelatedEntities<Email>("email_email_parentactivityid", Microsoft.Xrm.Sdk.EntityRole.Referenced, value);
                this.OnPropertyChanged("Referencedemail_email_parentactivityid");
            }
        }

        /// <summary>
        /// 1:N email_principalobjectattributeaccess
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("email_principalobjectattributeaccess")]
        public System.Collections.Generic.IEnumerable<PrincipalObjectAttributeAccess> email_principalobjectattributeaccess
        {
            get { return this.GetRelatedEntities<PrincipalObjectAttributeAccess>("email_principalobjectattributeaccess", null); }
            set
            {
                this.OnPropertyChanging("email_principalobjectattributeaccess");
                this.SetRelatedEntities<PrincipalObjectAttributeAccess>("email_principalobjectattributeaccess", null, value);
                this.OnPropertyChanged("email_principalobjectattributeaccess");
            }
        }

        /// <summary>
        /// 1:N Email_ProcessSessions
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Email_ProcessSessions")]
        public System.Collections.Generic.IEnumerable<ProcessSession> Email_ProcessSessions
        {
            get { return this.GetRelatedEntities<ProcessSession>("Email_ProcessSessions", null); }
            set
            {
                this.OnPropertyChanging("Email_ProcessSessions");
                this.SetRelatedEntities<ProcessSession>("Email_ProcessSessions", null, value);
                this.OnPropertyChanged("Email_ProcessSessions");
            }
        }

        /// <summary>
        /// 1:N Email_QueueItem
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Email_QueueItem")]
        public System.Collections.Generic.IEnumerable<QueueItem> Email_QueueItem
        {
            get { return this.GetRelatedEntities<QueueItem>("Email_QueueItem", null); }
            set
            {
                this.OnPropertyChanging("Email_QueueItem");
                this.SetRelatedEntities<QueueItem>("Email_QueueItem", null, value);
                this.OnPropertyChanged("Email_QueueItem");
            }
        }

        /// <summary>
        /// 1:N userentityinstancedata_email
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_email")]
        public System.Collections.Generic.IEnumerable<UserEntityInstanceData> userentityinstancedata_email
        {
            get { return this.GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_email", null); }
            set
            {
                this.OnPropertyChanging("userentityinstancedata_email");
                this.SetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_email", null, value);
                this.OnPropertyChanged("userentityinstancedata_email");
            }
        }

        /// <summary>
        /// N:1 Account_Email_EmailSender
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("emailsender")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Account_Email_EmailSender")]
        public Account Account_Email_EmailSender
        {
            get { return this.GetRelatedEntity<Account>("Account_Email_EmailSender", null); }
        }

        /// <summary>
        /// N:1 Account_Email_SendersAccount
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sendersaccount")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Account_Email_SendersAccount")]
        public Account Account_Email_SendersAccount
        {
            get { return this.GetRelatedEntity<Account>("Account_Email_SendersAccount", null); }
        }

        /// <summary>
        /// N:1 Account_Emails
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Account_Emails")]
        public Account Account_Emails
        {
            get { return this.GetRelatedEntity<Account>("Account_Emails", null); }
            set
            {
                this.OnPropertyChanging("Account_Emails");
                this.SetRelatedEntity<Account>("Account_Emails", null, value);
                this.OnPropertyChanged("Account_Emails");
            }
        }

        /// <summary>
        /// N:1 activity_pointer_email
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("activityid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("activity_pointer_email")]
        public ActivityPointer activity_pointer_email
        {
            get { return this.GetRelatedEntity<ActivityPointer>("activity_pointer_email", null); }
            set
            {
                this.OnPropertyChanging("activity_pointer_email");
                this.SetRelatedEntity<ActivityPointer>("activity_pointer_email", null, value);
                this.OnPropertyChanged("activity_pointer_email");
            }
        }

        /// <summary>
        /// N:1 AsyncOperation_Emails
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("AsyncOperation_Emails")]
        public AsyncOperation AsyncOperation_Emails
        {
            get { return this.GetRelatedEntity<AsyncOperation>("AsyncOperation_Emails", null); }
            set
            {
                this.OnPropertyChanging("AsyncOperation_Emails");
                this.SetRelatedEntity<AsyncOperation>("AsyncOperation_Emails", null, value);
                this.OnPropertyChanged("AsyncOperation_Emails");
            }
        }

        /// <summary>
        /// N:1 BulkOperation_Email
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("BulkOperation_Email")]
        public BulkOperation BulkOperation_Email
        {
            get { return this.GetRelatedEntity<BulkOperation>("BulkOperation_Email", null); }
            set
            {
                this.OnPropertyChanging("BulkOperation_Email");
                this.SetRelatedEntity<BulkOperation>("BulkOperation_Email", null, value);
                this.OnPropertyChanged("BulkOperation_Email");
            }
        }

        /// <summary>
        /// N:1 business_unit_email_activities
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_email_activities")]
        public BusinessUnit business_unit_email_activities
        {
            get { return this.GetRelatedEntity<BusinessUnit>("business_unit_email_activities", null); }
        }

        /// <summary>
        /// N:1 Campaign_Emails
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Campaign_Emails")]
        public Campaign Campaign_Emails
        {
            get { return this.GetRelatedEntity<Campaign>("Campaign_Emails", null); }
            set
            {
                this.OnPropertyChanging("Campaign_Emails");
                this.SetRelatedEntity<Campaign>("Campaign_Emails", null, value);
                this.OnPropertyChanged("Campaign_Emails");
            }
        }

        /// <summary>
        /// N:1 CampaignActivity_Emails
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("CampaignActivity_Emails")]
        public CampaignActivity CampaignActivity_Emails
        {
            get { return this.GetRelatedEntity<CampaignActivity>("CampaignActivity_Emails", null); }
            set
            {
                this.OnPropertyChanging("CampaignActivity_Emails");
                this.SetRelatedEntity<CampaignActivity>("CampaignActivity_Emails", null, value);
                this.OnPropertyChanged("CampaignActivity_Emails");
            }
        }

        /// <summary>
        /// N:1 Contact_Email_EmailSender
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("emailsender")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Contact_Email_EmailSender")]
        public Contact Contact_Email_EmailSender
        {
            get { return this.GetRelatedEntity<Contact>("Contact_Email_EmailSender", null); }
        }

        /// <summary>
        /// N:1 Contact_Emails
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Contact_Emails")]
        public Contact Contact_Emails
        {
            get { return this.GetRelatedEntity<Contact>("Contact_Emails", null); }
            set
            {
                this.OnPropertyChanging("Contact_Emails");
                this.SetRelatedEntity<Contact>("Contact_Emails", null, value);
                this.OnPropertyChanged("Contact_Emails");
            }
        }

        /// <summary>
        /// N:1 Contract_Emails
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Contract_Emails")]
        public Contract Contract_Emails
        {
            get { return this.GetRelatedEntity<Contract>("Contract_Emails", null); }
            set
            {
                this.OnPropertyChanging("Contract_Emails");
                this.SetRelatedEntity<Contract>("Contract_Emails", null, value);
                this.OnPropertyChanged("Contract_Emails");
            }
        }

        /// <summary>
        /// N:1 email_email_parentactivityid
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("parentactivityid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("email_email_parentactivityid", Microsoft.Xrm.Sdk.EntityRole.Referencing)]
        public Email Referencingemail_email_parentactivityid
        {
            get { return this.GetRelatedEntity<Email>("email_email_parentactivityid", Microsoft.Xrm.Sdk.EntityRole.Referencing); }
            set
            {
                this.OnPropertyChanging("Referencingemail_email_parentactivityid");
                this.SetRelatedEntity<Email>("email_email_parentactivityid", Microsoft.Xrm.Sdk.EntityRole.Referencing, value);
                this.OnPropertyChanged("Referencingemail_email_parentactivityid");
            }
        }

        /// <summary>
        /// N:1 email_sendermailboxid_mailbox
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sendermailboxid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("email_sendermailboxid_mailbox")]
        public Mailbox email_sendermailboxid_mailbox
        {
            get { return this.GetRelatedEntity<Mailbox>("email_sendermailboxid_mailbox", null); }
        }

        /// <summary>
        /// N:1 entitlement_Emails
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("entitlement_Emails")]
        public Entitlement entitlement_Emails
        {
            get { return this.GetRelatedEntity<Entitlement>("entitlement_Emails", null); }
            set
            {
                this.OnPropertyChanging("entitlement_Emails");
                this.SetRelatedEntity<Entitlement>("entitlement_Emails", null, value);
                this.OnPropertyChanged("entitlement_Emails");
            }
        }

        /// <summary>
        /// N:1 entitlementtemplate_Emails
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("entitlementtemplate_Emails")]
        public EntitlementTemplate entitlementtemplate_Emails
        {
            get { return this.GetRelatedEntity<EntitlementTemplate>("entitlementtemplate_Emails", null); }
            set
            {
                this.OnPropertyChanging("entitlementtemplate_Emails");
                this.SetRelatedEntity<EntitlementTemplate>("entitlementtemplate_Emails", null, value);
                this.OnPropertyChanged("entitlementtemplate_Emails");
            }
        }

        /// <summary>
        /// N:1 Equipment_Email_EmailSender
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("emailsender")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Equipment_Email_EmailSender")]
        public Equipment Equipment_Email_EmailSender
        {
            get { return this.GetRelatedEntity<Equipment>("Equipment_Email_EmailSender", null); }
        }

        /// <summary>
        /// N:1 Incident_Emails
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Incident_Emails")]
        public Incident Incident_Emails
        {
            get { return this.GetRelatedEntity<Incident>("Incident_Emails", null); }
            set
            {
                this.OnPropertyChanging("Incident_Emails");
                this.SetRelatedEntity<Incident>("Incident_Emails", null, value);
                this.OnPropertyChanged("Incident_Emails");
            }
        }

        /// <summary>
        /// N:1 Invoice_Emails
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Invoice_Emails")]
        public Invoice Invoice_Emails
        {
            get { return this.GetRelatedEntity<Invoice>("Invoice_Emails", null); }
            set
            {
                this.OnPropertyChanging("Invoice_Emails");
                this.SetRelatedEntity<Invoice>("Invoice_Emails", null, value);
                this.OnPropertyChanged("Invoice_Emails");
            }
        }

        /// <summary>
        /// N:1 Lead_Email_EmailSender
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("emailsender")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Lead_Email_EmailSender")]
        public Lead Lead_Email_EmailSender
        {
            get { return this.GetRelatedEntity<Lead>("Lead_Email_EmailSender", null); }
        }

        /// <summary>
        /// N:1 Lead_Emails
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Lead_Emails")]
        public Lead Lead_Emails
        {
            get { return this.GetRelatedEntity<Lead>("Lead_Emails", null); }
            set
            {
                this.OnPropertyChanging("Lead_Emails");
                this.SetRelatedEntity<Lead>("Lead_Emails", null, value);
                this.OnPropertyChanged("Lead_Emails");
            }
        }

        /// <summary>
        /// N:1 lk_email_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_email_createdby")]
        public SystemUser lk_email_createdby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_email_createdby", null); }
        }

        /// <summary>
        /// N:1 lk_email_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_email_createdonbehalfby")]
        public SystemUser lk_email_createdonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_email_createdonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_email_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_email_modifiedby")]
        public SystemUser lk_email_modifiedby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_email_modifiedby", null); }
        }

        /// <summary>
        /// N:1 lk_email_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_email_modifiedonbehalfby")]
        public SystemUser lk_email_modifiedonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_email_modifiedonbehalfby", null); }
        }

        /// <summary>
        /// N:1 msdyn_postalbum_Emails
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_postalbum_Emails")]
        public msdyn_PostAlbum msdyn_postalbum_Emails
        {
            get { return this.GetRelatedEntity<msdyn_PostAlbum>("msdyn_postalbum_Emails", null); }
            set
            {
                this.OnPropertyChanging("msdyn_postalbum_Emails");
                this.SetRelatedEntity<msdyn_PostAlbum>("msdyn_postalbum_Emails", null, value);
                this.OnPropertyChanged("msdyn_postalbum_Emails");
            }
        }

        /// <summary>
        /// N:1 Opportunity_Emails
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Opportunity_Emails")]
        public Opportunity Opportunity_Emails
        {
            get { return this.GetRelatedEntity<Opportunity>("Opportunity_Emails", null); }
            set
            {
                this.OnPropertyChanging("Opportunity_Emails");
                this.SetRelatedEntity<Opportunity>("Opportunity_Emails", null, value);
                this.OnPropertyChanged("Opportunity_Emails");
            }
        }

        /// <summary>
        /// N:1 processstage_emails
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("stageid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("processstage_emails")]
        public ProcessStage processstage_emails
        {
            get { return this.GetRelatedEntity<ProcessStage>("processstage_emails", null); }
            set
            {
                this.OnPropertyChanging("processstage_emails");
                this.SetRelatedEntity<ProcessStage>("processstage_emails", null, value);
                this.OnPropertyChanged("processstage_emails");
            }
        }

        /// <summary>
        /// N:1 Queue_Email_EmailSender
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("emailsender")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Queue_Email_EmailSender")]
        public Queue Queue_Email_EmailSender
        {
            get { return this.GetRelatedEntity<Queue>("Queue_Email_EmailSender", null); }
        }

        /// <summary>
        /// N:1 Quote_Emails
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Quote_Emails")]
        public Quote Quote_Emails
        {
            get { return this.GetRelatedEntity<Quote>("Quote_Emails", null); }
            set
            {
                this.OnPropertyChanging("Quote_Emails");
                this.SetRelatedEntity<Quote>("Quote_Emails", null, value);
                this.OnPropertyChanged("Quote_Emails");
            }
        }

        /// <summary>
        /// N:1 SalesOrder_Emails
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SalesOrder_Emails")]
        public SalesOrder SalesOrder_Emails
        {
            get { return this.GetRelatedEntity<SalesOrder>("SalesOrder_Emails", null); }
            set
            {
                this.OnPropertyChanging("SalesOrder_Emails");
                this.SetRelatedEntity<SalesOrder>("SalesOrder_Emails", null, value);
                this.OnPropertyChanged("SalesOrder_Emails");
            }
        }

        /// <summary>
        /// N:1 service_emails
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("serviceid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("service_emails")]
        public Service service_emails
        {
            get { return this.GetRelatedEntity<Service>("service_emails", null); }
            set
            {
                this.OnPropertyChanging("service_emails");
                this.SetRelatedEntity<Service>("service_emails", null, value);
                this.OnPropertyChanged("service_emails");
            }
        }

        /// <summary>
        /// N:1 SystemUser_Email_EmailSender
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("emailsender")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SystemUser_Email_EmailSender")]
        public SystemUser SystemUser_Email_EmailSender
        {
            get { return this.GetRelatedEntity<SystemUser>("SystemUser_Email_EmailSender", null); }
        }

        /// <summary>
        /// N:1 team_email
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_email")]
        public Team team_email
        {
            get { return this.GetRelatedEntity<Team>("team_email", null); }
        }

        /// <summary>
        /// N:1 TransactionCurrency_Email
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("TransactionCurrency_Email")]
        public TransactionCurrency TransactionCurrency_Email
        {
            get { return this.GetRelatedEntity<TransactionCurrency>("TransactionCurrency_Email", null); }
            set
            {
                this.OnPropertyChanging("TransactionCurrency_Email");
                this.SetRelatedEntity<TransactionCurrency>("TransactionCurrency_Email", null, value);
                this.OnPropertyChanged("TransactionCurrency_Email");
            }
        }

        /// <summary>
        /// N:1 user_email
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_email")]
        public SystemUser user_email
        {
            get { return this.GetRelatedEntity<SystemUser>("user_email", null); }
        }
    }
}