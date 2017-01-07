namespace __4_DAL_CRM
{
    /// <summary>
    /// 
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("mailbox")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class Mailbox : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public Mailbox() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "mailbox";

        public const int EntityTypeCode = 9606;

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
        /// Choose the delivery method for the mailbox for appointments, contacts, and tasks.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("actdeliverymethod")]
        public Microsoft.Xrm.Sdk.OptionSetValue ACTDeliveryMethod
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("actdeliverymethod"); }
            set
            {
                this.OnPropertyChanging("ACTDeliveryMethod");
                this.SetAttributeValue("actdeliverymethod", value);
                this.OnPropertyChanged("ACTDeliveryMethod");
            }
        }

        /// <summary>
        /// Status of the Appointments, Contacts, and Tasks.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("actstatus")]
        public Microsoft.Xrm.Sdk.OptionSetValue ACTStatus
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("actstatus"); }
        }

        /// <summary>
        /// Choose whether to allow the email connector to use credentials.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("allowemailconnectortousecredentials")]
        public System.Nullable<bool> AllowEmailConnectorToUseCredentials
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("allowemailconnectortousecredentials"); }
            set
            {
                this.OnPropertyChanging("AllowEmailConnectorToUseCredentials");
                this.SetAttributeValue("allowemailconnectortousecredentials", value);
                this.OnPropertyChanged("AllowEmailConnectorToUseCredentials");
            }
        }

        /// <summary>
        /// Mailbox Total Duration in Average
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("averagetotalduration")]
        public System.Nullable<int> AverageTotalDuration
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("averagetotalduration"); }
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
        /// Type the email address of the mailbox.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("emailaddress")]
        public string EmailAddress
        {
            get { return this.GetAttributeValue<string>("emailaddress"); }
            set
            {
                this.OnPropertyChanging("EmailAddress");
                this.SetAttributeValue("emailaddress", value);
                this.OnPropertyChanged("EmailAddress");
            }
        }

        /// <summary>
        /// Shows the status of the email address.
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
        /// Select the email server profile of the mailbox.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("emailserverprofile")]
        public Microsoft.Xrm.Sdk.EntityReference EmailServerProfile
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("emailserverprofile"); }
            set
            {
                this.OnPropertyChanging("EmailServerProfile");
                this.SetAttributeValue("emailserverprofile", value);
                this.OnPropertyChanged("EmailServerProfile");
            }
        }

        /// <summary>
        /// Indicates whether the mailbox is enabled for Appointments, Contacts, and Tasks.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("enabledforact")]
        public System.Nullable<bool> EnabledForACT
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("enabledforact"); }
        }

        /// <summary>
        /// Choose whether the mailbox is enabled for receiving email.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("enabledforincomingemail")]
        public System.Nullable<bool> EnabledForIncomingEmail
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("enabledforincomingemail"); }
        }

        /// <summary>
        /// Choose whether the mailbox is enabled for sending email.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("enabledforoutgoingemail")]
        public System.Nullable<bool> EnabledForOutgoingEmail
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("enabledforoutgoingemail"); }
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
        /// Exchange web services endpoint URL for the mailbox.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ewsurl")]
        public string EWSURL
        {
            get { return this.GetAttributeValue<string>("ewsurl"); }
            set
            {
                this.OnPropertyChanging("EWSURL");
                this.SetAttributeValue("ewsurl", value);
                this.OnPropertyChanged("EWSURL");
            }
        }

        /// <summary>
        /// Contains the exchange synchronization state in XML format.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("exchangesyncstatexml")]
        public string ExchangeSyncStateXml
        {
            get { return this.GetAttributeValue<string>("exchangesyncstatexml"); }
            set
            {
                this.OnPropertyChanging("ExchangeSyncStateXml");
                this.SetAttributeValue("exchangesyncstatexml", value);
                this.OnPropertyChanged("ExchangeSyncStateXml");
            }
        }

        /// <summary>
        /// Unique identifier of the async host that is processing this mailbox.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("hostid")]
        public string HostId
        {
            get { return this.GetAttributeValue<string>("hostid"); }
        }

        /// <summary>
        /// Select how incoming email will be delivered to the mailbox.
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
        /// Select the status that will be assigned to incoming email messages.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("incomingemailstatus")]
        public Microsoft.Xrm.Sdk.OptionSetValue IncomingEmailStatus
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("incomingemailstatus"); }
        }

        /// <summary>
        /// Set the current organization as the synchronization organization.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isactsyncorgflagset")]
        public System.Nullable<bool> IsACTSyncOrgFlagSet
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("isactsyncorgflagset"); }
            set
            {
                this.OnPropertyChanging("IsACTSyncOrgFlagSet");
                this.SetAttributeValue("isactsyncorgflagset", value);
                this.OnPropertyChanged("IsACTSyncOrgFlagSet");
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
        /// Select whether the mailbox is a forward mailbox.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isforwardmailbox")]
        public System.Nullable<bool> IsForwardMailbox
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("isforwardmailbox"); }
        }

        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ispasswordset")]
        public System.Nullable<bool> IsPasswordSet
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("ispasswordset"); }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("itemsfailedforlastsync")]
        public System.Nullable<int> ItemsFailedForLastSync
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("itemsfailedforlastsync"); }
            set
            {
                this.OnPropertyChanging("ItemsFailedForLastSync");
                this.SetAttributeValue("itemsfailedforlastsync", value);
                this.OnPropertyChanged("ItemsFailedForLastSync");
            }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("itemsprocessedforlastsync")]
        public System.Nullable<int> ItemsProcessedForLastSync
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("itemsprocessedforlastsync"); }
            set
            {
                this.OnPropertyChanging("ItemsProcessedForLastSync");
                this.SetAttributeValue("itemsprocessedforlastsync", value);
                this.OnPropertyChanged("ItemsProcessedForLastSync");
            }
        }

        /// <summary>
        /// Shows the date and time when the Exchange web services URL was last discovered using the AutoDiscover service.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("lastautodiscoveredon")]
        public System.Nullable<System.DateTime> LastAutoDiscoveredOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("lastautodiscoveredon"); }
            set
            {
                this.OnPropertyChanging("LastAutoDiscoveredOn");
                this.SetAttributeValue("lastautodiscoveredon", value);
                this.OnPropertyChanged("LastAutoDiscoveredOn");
            }
        }

        /// <summary>
        /// Last Duration for the mailbox
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("lastduration")]
        public System.Nullable<int> LastDuration
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("lastduration"); }
        }

        /// <summary>
        /// Last Successful Sync Time
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("lastsuccessfulsynccompletedon")]
        public System.Nullable<System.DateTime> LastSuccessfulSyncCompletedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("lastsuccessfulsynccompletedon"); }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("lastsyncerror")]
        public string LastSyncError
        {
            get { return this.GetAttributeValue<string>("lastsyncerror"); }
            set
            {
                this.OnPropertyChanging("LastSyncError");
                this.SetAttributeValue("lastsyncerror", value);
                this.OnPropertyChanged("LastSyncError");
            }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("lastsyncerrorcode")]
        public System.Nullable<int> LastSyncErrorCode
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("lastsyncerrorcode"); }
            set
            {
                this.OnPropertyChanging("LastSyncErrorCode");
                this.SetAttributeValue("lastsyncerrorcode", value);
                this.OnPropertyChanged("LastSyncErrorCode");
            }
        }

        /// <summary>
        /// For internal use only
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("lastsyncerrorcount")]
        public System.Nullable<int> LastSyncErrorCount
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("lastsyncerrorcount"); }
            set
            {
                this.OnPropertyChanging("LastSyncErrorCount");
                this.SetAttributeValue("lastsyncerrorcount", value);
                this.OnPropertyChanged("LastSyncErrorCount");
            }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("lastsyncerrormachinename")]
        public string LastSyncErrorMachineName
        {
            get { return this.GetAttributeValue<string>("lastsyncerrormachinename"); }
            set
            {
                this.OnPropertyChanging("LastSyncErrorMachineName");
                this.SetAttributeValue("lastsyncerrormachinename", value);
                this.OnPropertyChanged("LastSyncErrorMachineName");
            }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("lastsyncerroroccurredon")]
        public System.Nullable<System.DateTime> LastSyncErrorOccurredOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("lastsyncerroroccurredon"); }
            set
            {
                this.OnPropertyChanging("LastSyncErrorOccurredOn");
                this.SetAttributeValue("lastsyncerroroccurredon", value);
                this.OnPropertyChanged("LastSyncErrorOccurredOn");
            }
        }

        /// <summary>
        /// Last Sync Start Time
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("lastsyncstartedon")]
        public System.Nullable<System.DateTime> LastSyncStartedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("lastsyncstartedon"); }
        }

        /// <summary>
        /// Unique identifier of the mailbox.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("mailboxid")]
        public System.Nullable<System.Guid> MailboxId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("mailboxid"); }
            set
            {
                this.OnPropertyChanging("MailboxId");
                this.SetAttributeValue("mailboxid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("MailboxId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("mailboxid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.MailboxId = value; }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("mailboxprocessingcontext")]
        public System.Nullable<int> MailboxProcessingContext
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("mailboxprocessingcontext"); }
            set
            {
                this.OnPropertyChanging("MailboxProcessingContext");
                this.SetAttributeValue("mailboxprocessingcontext", value);
                this.OnPropertyChanged("MailboxProcessingContext");
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
        /// Type the name of the mailbox.
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
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("noactcount")]
        public System.Nullable<int> NoACTCount
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("noactcount"); }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("noemailcount")]
        public System.Nullable<int> NoEmailCount
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("noemailcount"); }
        }

        /// <summary>
        /// Unique identifier of the organization associated with the record.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
        public Microsoft.Xrm.Sdk.EntityReference OrganizationId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("organizationid"); }
        }

        /// <summary>
        /// Indicates if the crm org is to be marked as primary syncing org for the mailbox record.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("orgmarkedasprimaryforexchangesync")]
        public System.Nullable<bool> OrgMarkedAsPrimaryForExchangeSync
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("orgmarkedasprimaryforexchangesync"); }
            set
            {
                this.OnPropertyChanging("OrgMarkedAsPrimaryForExchangeSync");
                this.SetAttributeValue("orgmarkedasprimaryforexchangesync", value);
                this.OnPropertyChanged("OrgMarkedAsPrimaryForExchangeSync");
            }
        }

        /// <summary>
        /// Select how outgoing email will be sent from the mailbox.
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
        /// Select the status of outgoing email messages.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("outgoingemailstatus")]
        public Microsoft.Xrm.Sdk.OptionSetValue OutgoingEmailStatus
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("outgoingemailstatus"); }
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
        /// Select the business unit that owns the record.
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
        /// Type the password for the mailbox.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("password")]
        public string Password
        {
            get { return this.GetAttributeValue<string>("password"); }
            set
            {
                this.OnPropertyChanging("Password");
                this.SetAttributeValue("password", value);
                this.OnPropertyChanged("Password");
            }
        }

        /// <summary>
        /// Shows the date and time when processing will begin on this mailbox.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("postponemailboxprocessinguntil")]
        public System.Nullable<System.DateTime> PostponeMailboxProcessingUntil
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("postponemailboxprocessinguntil"); }
        }

        /// <summary>
        /// Shows the date and time when the mailbox can start sending emails.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("postponesendinguntil")]
        public System.Nullable<System.DateTime> PostponeSendingUntil
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("postponesendinguntil"); }
            set
            {
                this.OnPropertyChanging("PostponeSendingUntil");
                this.SetAttributeValue("postponesendinguntil", value);
                this.OnPropertyChanged("PostponeSendingUntil");
            }
        }

        /// <summary>
        /// Shows the date and time when the next email configuration test will be run for a mailbox record.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("postponetestemailconfigurationuntil")]
        public System.Nullable<System.DateTime> PostponeTestEmailConfigurationUntil
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("postponetestemailconfigurationuntil"); }
            set
            {
                this.OnPropertyChanging("PostponeTestEmailConfigurationUntil");
                this.SetAttributeValue("postponetestemailconfigurationuntil", value);
                this.OnPropertyChanged("PostponeTestEmailConfigurationUntil");
            }
        }

        /// <summary>
        /// Select whether to delete emails from the mailbox after processing.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("processanddeleteemails")]
        public System.Nullable<bool> ProcessAndDeleteEmails
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("processanddeleteemails"); }
            set
            {
                this.OnPropertyChanging("ProcessAndDeleteEmails");
                this.SetAttributeValue("processanddeleteemails", value);
                this.OnPropertyChanged("ProcessAndDeleteEmails");
            }
        }

        /// <summary>
        /// The number of times mailbox has processed
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("processedtimes")]
        public System.Nullable<int> ProcessedTimes
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("processedtimes"); }
        }

        /// <summary>
        /// Shows the date and time to start processing email received by the mailbox.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("processemailreceivedafter")]
        public System.Nullable<System.DateTime> ProcessEmailReceivedAfter
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("processemailreceivedafter"); }
            set
            {
                this.OnPropertyChanging("ProcessEmailReceivedAfter");
                this.SetAttributeValue("processemailreceivedafter", value);
                this.OnPropertyChanged("ProcessEmailReceivedAfter");
            }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("receivingpostponeduntil")]
        public System.Nullable<System.DateTime> ReceivingPostponedUntil
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("receivingpostponeduntil"); }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("receivingpostponeduntilforact")]
        public System.Nullable<System.DateTime> ReceivingPostponedUntilForACT
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("receivingpostponeduntilforact"); }
        }

        /// <summary>
        /// Choose the user associated to the mailbox.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        public Microsoft.Xrm.Sdk.EntityReference RegardingObjectId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("regardingobjectid"); }
        }

        /// <summary>
        /// Shows whether the mailbox is active or inactive.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
        public System.Nullable<MailboxState> StateCode
        {
            get
            {
                Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
                if ((optionSet != null))
                {
                    return ((MailboxState) (System.Enum.ToObject(typeof(MailboxState), optionSet.Value)));
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// Select the mailbox's status.
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
        /// Shows the number of times an email configuration test has been performed.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("testemailconfigurationretrycount")]
        public System.Nullable<int> TestEmailConfigurationRetryCount
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("testemailconfigurationretrycount"); }
            set
            {
                this.OnPropertyChanging("TestEmailConfigurationRetryCount");
                this.SetAttributeValue("testemailconfigurationretrycount", value);
                this.OnPropertyChanged("TestEmailConfigurationRetryCount");
            }
        }

        /// <summary>
        /// Indicates if the email configuration test has been scheduled for a mailbox record.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("testemailconfigurationscheduled")]
        public System.Nullable<bool> TestEmailConfigurationScheduled
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("testemailconfigurationscheduled"); }
            set
            {
                this.OnPropertyChanging("TestEmailConfigurationScheduled");
                this.SetAttributeValue("testemailconfigurationscheduled", value);
                this.OnPropertyChanged("TestEmailConfigurationScheduled");
            }
        }

        /// <summary>
        /// Date and time when the last email configuration test was completed for a mailbox record.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("testmailboxaccesscompletedon")]
        public System.Nullable<System.DateTime> TestMailboxAccessCompletedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("testmailboxaccesscompletedon"); }
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
        /// Concatenation of transient failure counts of all mailbox operations.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transientfailurecount")]
        public System.Nullable<int> TransientFailureCount
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("transientfailurecount"); }
        }

        /// <summary>
        /// Shows the ID of the Undeliverable folder in the mailbox managed by Microsoft Exchange.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("undeliverablefolder")]
        public string UndeliverableFolder
        {
            get { return this.GetAttributeValue<string>("undeliverablefolder"); }
            set
            {
                this.OnPropertyChanging("UndeliverableFolder");
                this.SetAttributeValue("undeliverablefolder", value);
                this.OnPropertyChanged("UndeliverableFolder");
            }
        }

        /// <summary>
        /// Type a user name used for mailbox authentication.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("username")]
        public string Username
        {
            get { return this.GetAttributeValue<string>("username"); }
            set
            {
                this.OnPropertyChanging("Username");
                this.SetAttributeValue("username", value);
                this.OnPropertyChanged("Username");
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
        /// Version number of the mailbox.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
        public System.Nullable<long> VersionNumber
        {
            get { return this.GetAttributeValue<System.Nullable<long>>("versionnumber"); }
        }

        /// <summary>
        /// 1:N activitypointer_sendermailboxid_mailbox
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("activitypointer_sendermailboxid_mailbox")]
        public System.Collections.Generic.IEnumerable<ActivityPointer> activitypointer_sendermailboxid_mailbox
        {
            get { return this.GetRelatedEntities<ActivityPointer>("activitypointer_sendermailboxid_mailbox", null); }
            set
            {
                this.OnPropertyChanging("activitypointer_sendermailboxid_mailbox");
                this.SetRelatedEntities<ActivityPointer>("activitypointer_sendermailboxid_mailbox", null, value);
                this.OnPropertyChanged("activitypointer_sendermailboxid_mailbox");
            }
        }

        /// <summary>
        /// 1:N email_sendermailboxid_mailbox
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("email_sendermailboxid_mailbox")]
        public System.Collections.Generic.IEnumerable<Email> email_sendermailboxid_mailbox
        {
            get { return this.GetRelatedEntities<Email>("email_sendermailboxid_mailbox", null); }
            set
            {
                this.OnPropertyChanging("email_sendermailboxid_mailbox");
                this.SetRelatedEntities<Email>("email_sendermailboxid_mailbox", null, value);
                this.OnPropertyChanged("email_sendermailboxid_mailbox");
            }
        }

        /// <summary>
        /// 1:N Mailbox_Annotation
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Mailbox_Annotation")]
        public System.Collections.Generic.IEnumerable<Annotation> Mailbox_Annotation
        {
            get { return this.GetRelatedEntities<Annotation>("Mailbox_Annotation", null); }
            set
            {
                this.OnPropertyChanging("Mailbox_Annotation");
                this.SetRelatedEntities<Annotation>("Mailbox_Annotation", null, value);
                this.OnPropertyChanged("Mailbox_Annotation");
            }
        }

        /// <summary>
        /// 1:N mailbox_asyncoperations
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("mailbox_asyncoperations")]
        public System.Collections.Generic.IEnumerable<AsyncOperation> mailbox_asyncoperations
        {
            get { return this.GetRelatedEntities<AsyncOperation>("mailbox_asyncoperations", null); }
            set
            {
                this.OnPropertyChanging("mailbox_asyncoperations");
                this.SetRelatedEntities<AsyncOperation>("mailbox_asyncoperations", null, value);
                this.OnPropertyChanged("mailbox_asyncoperations");
            }
        }

        /// <summary>
        /// 1:N mailbox_processsessions
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("mailbox_processsessions")]
        public System.Collections.Generic.IEnumerable<ProcessSession> mailbox_processsessions
        {
            get { return this.GetRelatedEntities<ProcessSession>("mailbox_processsessions", null); }
            set
            {
                this.OnPropertyChanging("mailbox_processsessions");
                this.SetRelatedEntities<ProcessSession>("mailbox_processsessions", null, value);
                this.OnPropertyChanged("mailbox_processsessions");
            }
        }

        /// <summary>
        /// 1:N mailbox_userentityinstancedatas
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("mailbox_userentityinstancedatas")]
        public System.Collections.Generic.IEnumerable<UserEntityInstanceData> mailbox_userentityinstancedatas
        {
            get { return this.GetRelatedEntities<UserEntityInstanceData>("mailbox_userentityinstancedatas", null); }
            set
            {
                this.OnPropertyChanging("mailbox_userentityinstancedatas");
                this.SetRelatedEntities<UserEntityInstanceData>("mailbox_userentityinstancedatas", null, value);
                this.OnPropertyChanged("mailbox_userentityinstancedatas");
            }
        }

        /// <summary>
        /// 1:N queue_defaultmailbox_mailbox
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("queue_defaultmailbox_mailbox")]
        public System.Collections.Generic.IEnumerable<Queue> queue_defaultmailbox_mailbox
        {
            get { return this.GetRelatedEntities<Queue>("queue_defaultmailbox_mailbox", null); }
            set
            {
                this.OnPropertyChanging("queue_defaultmailbox_mailbox");
                this.SetRelatedEntities<Queue>("queue_defaultmailbox_mailbox", null, value);
                this.OnPropertyChanged("queue_defaultmailbox_mailbox");
            }
        }

        /// <summary>
        /// 1:N systemuser_defaultmailbox_mailbox
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("systemuser_defaultmailbox_mailbox")]
        public System.Collections.Generic.IEnumerable<SystemUser> systemuser_defaultmailbox_mailbox
        {
            get { return this.GetRelatedEntities<SystemUser>("systemuser_defaultmailbox_mailbox", null); }
            set
            {
                this.OnPropertyChanging("systemuser_defaultmailbox_mailbox");
                this.SetRelatedEntities<SystemUser>("systemuser_defaultmailbox_mailbox", null, value);
                this.OnPropertyChanged("systemuser_defaultmailbox_mailbox");
            }
        }

        /// <summary>
        /// 1:N tracelog_Mailbox
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("tracelog_Mailbox")]
        public System.Collections.Generic.IEnumerable<TraceLog> tracelog_Mailbox
        {
            get { return this.GetRelatedEntities<TraceLog>("tracelog_Mailbox", null); }
            set
            {
                this.OnPropertyChanging("tracelog_Mailbox");
                this.SetRelatedEntities<TraceLog>("tracelog_Mailbox", null, value);
                this.OnPropertyChanged("tracelog_Mailbox");
            }
        }

        /// <summary>
        /// N:1 business_unit_mailbox
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_mailbox")]
        public BusinessUnit business_unit_mailbox
        {
            get { return this.GetRelatedEntity<BusinessUnit>("business_unit_mailbox", null); }
        }

        /// <summary>
        /// N:1 emailserverprofile_mailbox
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("emailserverprofile")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("emailserverprofile_mailbox")]
        public EmailServerProfile emailserverprofile_mailbox
        {
            get { return this.GetRelatedEntity<EmailServerProfile>("emailserverprofile_mailbox", null); }
            set
            {
                this.OnPropertyChanging("emailserverprofile_mailbox");
                this.SetRelatedEntity<EmailServerProfile>("emailserverprofile_mailbox", null, value);
                this.OnPropertyChanged("emailserverprofile_mailbox");
            }
        }

        /// <summary>
        /// N:1 lk_mailbox_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_mailbox_createdby")]
        public SystemUser lk_mailbox_createdby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_mailbox_createdby", null); }
        }

        /// <summary>
        /// N:1 lk_mailbox_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_mailbox_createdonbehalfby")]
        public SystemUser lk_mailbox_createdonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_mailbox_createdonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_mailbox_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_mailbox_modifiedby")]
        public SystemUser lk_mailbox_modifiedby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_mailbox_modifiedby", null); }
        }

        /// <summary>
        /// N:1 lk_mailbox_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_mailbox_modifiedonbehalfby")]
        public SystemUser lk_mailbox_modifiedonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_mailbox_modifiedonbehalfby", null); }
        }

        /// <summary>
        /// N:1 mailbox_regarding_queue
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("mailbox_regarding_queue")]
        public Queue mailbox_regarding_queue
        {
            get { return this.GetRelatedEntity<Queue>("mailbox_regarding_queue", null); }
        }

        /// <summary>
        /// N:1 mailbox_regarding_systemuser
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("mailbox_regarding_systemuser")]
        public SystemUser mailbox_regarding_systemuser
        {
            get { return this.GetRelatedEntity<SystemUser>("mailbox_regarding_systemuser", null); }
        }

        /// <summary>
        /// N:1 organization_mailbox
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_mailbox")]
        public Organization organization_mailbox
        {
            get { return this.GetRelatedEntity<Organization>("organization_mailbox", null); }
        }

        /// <summary>
        /// N:1 team_mailbox
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_mailbox")]
        public Team team_mailbox
        {
            get { return this.GetRelatedEntity<Team>("team_mailbox", null); }
        }

        /// <summary>
        /// N:1 user_mailbox
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_mailbox")]
        public SystemUser user_mailbox
        {
            get { return this.GetRelatedEntity<SystemUser>("user_mailbox", null); }
        }
    }
}