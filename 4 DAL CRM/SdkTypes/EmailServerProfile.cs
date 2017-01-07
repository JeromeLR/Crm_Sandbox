namespace __4_DAL_CRM
{
    /// <summary>
    /// Holds the Email Server Profiles of an organization
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("emailserverprofile")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class EmailServerProfile : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public EmailServerProfile() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "emailserverprofile";

        public const int EntityTypeCode = 9605;

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
        /// Type additional information that describes the email server profile.
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
        /// Unique identifier of the email server profile.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("emailserverprofileid")]
        public System.Nullable<System.Guid> EmailServerProfileId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("emailserverprofileid"); }
            set
            {
                this.OnPropertyChanging("EmailServerProfileId");
                this.SetAttributeValue("emailserverprofileid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("EmailServerProfileId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("emailserverprofileid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.EmailServerProfileId = value; }
        }

        /// <summary>
        /// Indicates the code page to use when encoding email content.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("encodingcodepage")]
        public string EncodingCodePage
        {
            get { return this.GetAttributeValue<string>("encodingcodepage"); }
            set
            {
                this.OnPropertyChanging("EncodingCodePage");
                this.SetAttributeValue("encodingcodepage", value);
                this.OnPropertyChanged("EncodingCodePage");
            }
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
        /// Select the version of Exchange that is on the email server.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("exchangeversion")]
        public Microsoft.Xrm.Sdk.OptionSetValue ExchangeVersion
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("exchangeversion"); }
            set
            {
                this.OnPropertyChanging("ExchangeVersion");
                this.SetAttributeValue("exchangeversion", value);
                this.OnPropertyChanged("ExchangeVersion");
            }
        }

        /// <summary>
        /// Select the incoming email authentication protocol that is used for connecting to the email server.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("incomingauthenticationprotocol")]
        public Microsoft.Xrm.Sdk.OptionSetValue IncomingAuthenticationProtocol
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("incomingauthenticationprotocol"); }
            set
            {
                this.OnPropertyChanging("IncomingAuthenticationProtocol");
                this.SetAttributeValue("incomingauthenticationprotocol", value);
                this.OnPropertyChanged("IncomingAuthenticationProtocol");
            }
        }

        /// <summary>
        /// Select how credentials will be retrieved for incoming email.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("incomingcredentialretrieval")]
        public Microsoft.Xrm.Sdk.OptionSetValue IncomingCredentialRetrieval
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("incomingcredentialretrieval"); }
            set
            {
                this.OnPropertyChanging("IncomingCredentialRetrieval");
                this.SetAttributeValue("incomingcredentialretrieval", value);
                this.OnPropertyChanged("IncomingCredentialRetrieval");
            }
        }

        /// <summary>
        /// Indicates the incoming partner application.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("incomingpartnerapplication")]
        public Microsoft.Xrm.Sdk.EntityReference IncomingPartnerApplication
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("incomingpartnerapplication"); }
        }

        /// <summary>
        /// Type the password for incoming email.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("incomingpassword")]
        public string IncomingPassword
        {
            get { return this.GetAttributeValue<string>("incomingpassword"); }
            set
            {
                this.OnPropertyChanging("IncomingPassword");
                this.SetAttributeValue("incomingpassword", value);
                this.OnPropertyChanged("IncomingPassword");
            }
        }

        /// <summary>
        /// Type the port number for incoming email.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("incomingportnumber")]
        public System.Nullable<int> IncomingPortNumber
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("incomingportnumber"); }
            set
            {
                this.OnPropertyChanging("IncomingPortNumber");
                this.SetAttributeValue("incomingportnumber", value);
                this.OnPropertyChanged("IncomingPortNumber");
            }
        }

        /// <summary>
        /// Type the location of the server for incoming email.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("incomingserverlocation")]
        public string IncomingServerLocation
        {
            get { return this.GetAttributeValue<string>("incomingserverlocation"); }
            set
            {
                this.OnPropertyChanging("IncomingServerLocation");
                this.SetAttributeValue("incomingserverlocation", value);
                this.OnPropertyChanged("IncomingServerLocation");
            }
        }

        /// <summary>
        /// Select whether to use impersonation to access the mailbox to process incoming emails.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("incominguseimpersonation")]
        public System.Nullable<bool> IncomingUseImpersonation
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("incominguseimpersonation"); }
            set
            {
                this.OnPropertyChanging("IncomingUseImpersonation");
                this.SetAttributeValue("incominguseimpersonation", value);
                this.OnPropertyChanged("IncomingUseImpersonation");
            }
        }

        /// <summary>
        /// Type the user name for incoming email.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("incomingusername")]
        public string IncomingUserName
        {
            get { return this.GetAttributeValue<string>("incomingusername"); }
            set
            {
                this.OnPropertyChanging("IncomingUserName");
                this.SetAttributeValue("incomingusername", value);
                this.OnPropertyChanged("IncomingUserName");
            }
        }

        /// <summary>
        /// Select whether to use the Secure Sockets Layer (SSL) protocol for incoming email.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("incomingusessl")]
        public System.Nullable<bool> IncomingUseSSL
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("incomingusessl"); }
            set
            {
                this.OnPropertyChanging("IncomingUseSSL");
                this.SetAttributeValue("incomingusessl", value);
                this.OnPropertyChanged("IncomingUseSSL");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isincomingpasswordset")]
        public System.Nullable<bool> IsIncomingPasswordSet
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("isincomingpasswordset"); }
        }

        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isoutgoingpasswordset")]
        public System.Nullable<bool> IsOutgoingPasswordSet
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("isoutgoingpasswordset"); }
        }

        /// <summary>
        /// Maximum number of concurrent connections allowed to the email server per authenticated user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("maxconcurrentconnections")]
        public System.Nullable<int> MaxConcurrentConnections
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("maxconcurrentconnections"); }
            set
            {
                this.OnPropertyChanging("MaxConcurrentConnections");
                this.SetAttributeValue("maxconcurrentconnections", value);
                this.OnPropertyChanged("MaxConcurrentConnections");
            }
        }

        /// <summary>
        /// Minimum polling interval, in minutes, for mailboxes that are associated with this email server profile.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("minpollingintervalinminutes")]
        public System.Nullable<int> MinPollingIntervalInMinutes
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("minpollingintervalinminutes"); }
            set
            {
                this.OnPropertyChanging("MinPollingIntervalInMinutes");
                this.SetAttributeValue("minpollingintervalinminutes", value);
                this.OnPropertyChanged("MinPollingIntervalInMinutes");
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
        /// Indicates whether to move undelivered incoming emails to the Undeliverable folder in Microsoft Exchange.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("moveundeliveredemails")]
        public System.Nullable<bool> MoveUndeliveredEmails
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("moveundeliveredemails"); }
            set
            {
                this.OnPropertyChanging("MoveUndeliveredEmails");
                this.SetAttributeValue("moveundeliveredemails", value);
                this.OnPropertyChanged("MoveUndeliveredEmails");
            }
        }

        /// <summary>
        /// Type the name of the email server profile record.
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
        /// Unique identifier of the organization associated with the record.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
        public Microsoft.Xrm.Sdk.EntityReference OrganizationId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("organizationid"); }
        }

        /// <summary>
        /// Select the outgoing email authentication protocol that is used for connecting to the email server.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("outgoingauthenticationprotocol")]
        public Microsoft.Xrm.Sdk.OptionSetValue OutgoingAuthenticationProtocol
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("outgoingauthenticationprotocol"); }
            set
            {
                this.OnPropertyChanging("OutgoingAuthenticationProtocol");
                this.SetAttributeValue("outgoingauthenticationprotocol", value);
                this.OnPropertyChanged("OutgoingAuthenticationProtocol");
            }
        }

        /// <summary>
        /// Indicates whether the email connector will grant delegate access permissions to the accessing user when required while processing outgoing emails.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("outgoingautograntdelegateaccess")]
        public System.Nullable<bool> OutgoingAutoGrantDelegateAccess
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("outgoingautograntdelegateaccess"); }
            set
            {
                this.OnPropertyChanging("OutgoingAutoGrantDelegateAccess");
                this.SetAttributeValue("outgoingautograntdelegateaccess", value);
                this.OnPropertyChanged("OutgoingAutoGrantDelegateAccess");
            }
        }

        /// <summary>
        /// Select how credentials will be retrieved for outgoing email.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("outgoingcredentialretrieval")]
        public Microsoft.Xrm.Sdk.OptionSetValue OutgoingCredentialRetrieval
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("outgoingcredentialretrieval"); }
            set
            {
                this.OnPropertyChanging("OutgoingCredentialRetrieval");
                this.SetAttributeValue("outgoingcredentialretrieval", value);
                this.OnPropertyChanged("OutgoingCredentialRetrieval");
            }
        }

        /// <summary>
        /// Indicates the outgoing partner application.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("outgoingpartnerapplication")]
        public Microsoft.Xrm.Sdk.EntityReference OutgoingPartnerApplication
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("outgoingpartnerapplication"); }
        }

        /// <summary>
        /// Type the password for outgoing email.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("outgoingpassword")]
        public string OutgoingPassword
        {
            get { return this.GetAttributeValue<string>("outgoingpassword"); }
            set
            {
                this.OnPropertyChanging("OutgoingPassword");
                this.SetAttributeValue("outgoingpassword", value);
                this.OnPropertyChanged("OutgoingPassword");
            }
        }

        /// <summary>
        /// Type the port number for outgoing email.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("outgoingportnumber")]
        public System.Nullable<int> OutgoingPortNumber
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("outgoingportnumber"); }
            set
            {
                this.OnPropertyChanging("OutgoingPortNumber");
                this.SetAttributeValue("outgoingportnumber", value);
                this.OnPropertyChanged("OutgoingPortNumber");
            }
        }

        /// <summary>
        /// Type the location of the server for outgoing email.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("outgoingserverlocation")]
        public string OutgoingServerLocation
        {
            get { return this.GetAttributeValue<string>("outgoingserverlocation"); }
            set
            {
                this.OnPropertyChanging("OutgoingServerLocation");
                this.SetAttributeValue("outgoingserverlocation", value);
                this.OnPropertyChanged("OutgoingServerLocation");
            }
        }

        /// <summary>
        /// Select whether to use impersonation for accessing the mailbox to process outgoing emails.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("outgoinguseimpersonation")]
        public System.Nullable<bool> OutgoingUseImpersonation
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("outgoinguseimpersonation"); }
            set
            {
                this.OnPropertyChanging("OutgoingUseImpersonation");
                this.SetAttributeValue("outgoinguseimpersonation", value);
                this.OnPropertyChanged("OutgoingUseImpersonation");
            }
        }

        /// <summary>
        /// Type the user name for outgoing email.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("outgoingusername")]
        public string OutgoingUsername
        {
            get { return this.GetAttributeValue<string>("outgoingusername"); }
            set
            {
                this.OnPropertyChanging("OutgoingUsername");
                this.SetAttributeValue("outgoingusername", value);
                this.OnPropertyChanged("OutgoingUsername");
            }
        }

        /// <summary>
        /// Select whether to use the Secure Sockets Layer (SSL) protocol for outgoing email.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("outgoingusessl")]
        public System.Nullable<bool> OutgoingUseSSL
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("outgoingusessl"); }
            set
            {
                this.OnPropertyChanging("OutgoingUseSSL");
                this.SetAttributeValue("outgoingusessl", value);
                this.OnPropertyChanged("OutgoingUseSSL");
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
        /// Shows the date and time after which email messages that are received will be processed for mailboxes associated with the email server profile.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("processemailsreceivedafter")]
        public System.Nullable<System.DateTime> ProcessEmailsReceivedAfter
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("processemailsreceivedafter"); }
            set
            {
                this.OnPropertyChanging("ProcessEmailsReceivedAfter");
                this.SetAttributeValue("processemailsreceivedafter", value);
                this.OnPropertyChanged("ProcessEmailsReceivedAfter");
            }
        }

        /// <summary>
        /// Select the profile's email server type.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("servertype")]
        public Microsoft.Xrm.Sdk.OptionSetValue ServerType
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("servertype"); }
            set
            {
                this.OnPropertyChanging("ServerType");
                this.SetAttributeValue("servertype", value);
                this.OnPropertyChanged("ServerType");
            }
        }

        /// <summary>
        /// Shows whether the email server profile is active or inactive.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
        public System.Nullable<EmailServerProfileState> StateCode
        {
            get
            {
                Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
                if ((optionSet != null))
                {
                    return ((EmailServerProfileState) (System.Enum.ToObject(typeof(EmailServerProfileState), optionSet.Value)));
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// Select the email server profile's status.
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
        /// Select whether to automatically discover the server location.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("useautodiscover")]
        public System.Nullable<bool> UseAutoDiscover
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("useautodiscover"); }
            set
            {
                this.OnPropertyChanging("UseAutoDiscover");
                this.SetAttributeValue("useautodiscover", value);
                this.OnPropertyChanged("UseAutoDiscover");
            }
        }

        /// <summary>
        /// Select whether to use the same settings for incoming and outgoing connections.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("usesamesettingsforoutgoingconnections")]
        public System.Nullable<bool> UseSameSettingsForOutgoingConnections
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("usesamesettingsforoutgoingconnections"); }
            set
            {
                this.OnPropertyChanging("UseSameSettingsForOutgoingConnections");
                this.SetAttributeValue("usesamesettingsforoutgoingconnections", value);
                this.OnPropertyChanged("UseSameSettingsForOutgoingConnections");
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
        /// 1:N EmailServerProfile_Annotation
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("EmailServerProfile_Annotation")]
        public System.Collections.Generic.IEnumerable<Annotation> EmailServerProfile_Annotation
        {
            get { return this.GetRelatedEntities<Annotation>("EmailServerProfile_Annotation", null); }
            set
            {
                this.OnPropertyChanging("EmailServerProfile_Annotation");
                this.SetRelatedEntities<Annotation>("EmailServerProfile_Annotation", null, value);
                this.OnPropertyChanged("EmailServerProfile_Annotation");
            }
        }

        /// <summary>
        /// 1:N emailserverprofile_asyncoperations
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("emailserverprofile_asyncoperations")]
        public System.Collections.Generic.IEnumerable<AsyncOperation> emailserverprofile_asyncoperations
        {
            get { return this.GetRelatedEntities<AsyncOperation>("emailserverprofile_asyncoperations", null); }
            set
            {
                this.OnPropertyChanging("emailserverprofile_asyncoperations");
                this.SetRelatedEntities<AsyncOperation>("emailserverprofile_asyncoperations", null, value);
                this.OnPropertyChanged("emailserverprofile_asyncoperations");
            }
        }

        /// <summary>
        /// 1:N emailserverprofile_bulkdeletefailures
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("emailserverprofile_bulkdeletefailures")]
        public System.Collections.Generic.IEnumerable<BulkDeleteFailure> emailserverprofile_bulkdeletefailures
        {
            get { return this.GetRelatedEntities<BulkDeleteFailure>("emailserverprofile_bulkdeletefailures", null); }
            set
            {
                this.OnPropertyChanging("emailserverprofile_bulkdeletefailures");
                this.SetRelatedEntities<BulkDeleteFailure>("emailserverprofile_bulkdeletefailures", null, value);
                this.OnPropertyChanged("emailserverprofile_bulkdeletefailures");
            }
        }

        /// <summary>
        /// 1:N emailserverprofile_duplicatebaserecord
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("emailserverprofile_duplicatebaserecord")]
        public System.Collections.Generic.IEnumerable<DuplicateRecord> emailserverprofile_duplicatebaserecord
        {
            get { return this.GetRelatedEntities<DuplicateRecord>("emailserverprofile_duplicatebaserecord", null); }
            set
            {
                this.OnPropertyChanging("emailserverprofile_duplicatebaserecord");
                this.SetRelatedEntities<DuplicateRecord>("emailserverprofile_duplicatebaserecord", null, value);
                this.OnPropertyChanged("emailserverprofile_duplicatebaserecord");
            }
        }

        /// <summary>
        /// 1:N emailserverprofile_duplicatematchingrecord
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("emailserverprofile_duplicatematchingrecord")]
        public System.Collections.Generic.IEnumerable<DuplicateRecord> emailserverprofile_duplicatematchingrecord
        {
            get { return this.GetRelatedEntities<DuplicateRecord>("emailserverprofile_duplicatematchingrecord", null); }
            set
            {
                this.OnPropertyChanging("emailserverprofile_duplicatematchingrecord");
                this.SetRelatedEntities<DuplicateRecord>("emailserverprofile_duplicatematchingrecord", null, value);
                this.OnPropertyChanged("emailserverprofile_duplicatematchingrecord");
            }
        }

        /// <summary>
        /// 1:N emailserverprofile_mailbox
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("emailserverprofile_mailbox")]
        public System.Collections.Generic.IEnumerable<Mailbox> emailserverprofile_mailbox
        {
            get { return this.GetRelatedEntities<Mailbox>("emailserverprofile_mailbox", null); }
            set
            {
                this.OnPropertyChanging("emailserverprofile_mailbox");
                this.SetRelatedEntities<Mailbox>("emailserverprofile_mailbox", null, value);
                this.OnPropertyChanged("emailserverprofile_mailbox");
            }
        }

        /// <summary>
        /// 1:N EmailServerProfile_Organization
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("EmailServerProfile_Organization")]
        public System.Collections.Generic.IEnumerable<Organization> EmailServerProfile_Organization
        {
            get { return this.GetRelatedEntities<Organization>("EmailServerProfile_Organization", null); }
            set
            {
                this.OnPropertyChanging("EmailServerProfile_Organization");
                this.SetRelatedEntities<Organization>("EmailServerProfile_Organization", null, value);
                this.OnPropertyChanged("EmailServerProfile_Organization");
            }
        }

        /// <summary>
        /// 1:N tracelog_EmailServerProfile
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("tracelog_EmailServerProfile")]
        public System.Collections.Generic.IEnumerable<TraceLog> tracelog_EmailServerProfile
        {
            get { return this.GetRelatedEntities<TraceLog>("tracelog_EmailServerProfile", null); }
            set
            {
                this.OnPropertyChanging("tracelog_EmailServerProfile");
                this.SetRelatedEntities<TraceLog>("tracelog_EmailServerProfile", null, value);
                this.OnPropertyChanged("tracelog_EmailServerProfile");
            }
        }

        /// <summary>
        /// N:1 business_unit_emailserverprofile
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_emailserverprofile")]
        public BusinessUnit business_unit_emailserverprofile
        {
            get { return this.GetRelatedEntity<BusinessUnit>("business_unit_emailserverprofile", null); }
        }

        /// <summary>
        /// N:1 lk_emailserverprofile_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_emailserverprofile_createdby")]
        public SystemUser lk_emailserverprofile_createdby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_emailserverprofile_createdby", null); }
        }

        /// <summary>
        /// N:1 lk_emailserverprofile_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_emailserverprofile_createdonbehalfby")]
        public SystemUser lk_emailserverprofile_createdonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_emailserverprofile_createdonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_emailserverprofile_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_emailserverprofile_modifiedby")]
        public SystemUser lk_emailserverprofile_modifiedby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_emailserverprofile_modifiedby", null); }
        }

        /// <summary>
        /// N:1 lk_emailserverprofile_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_emailserverprofile_modifiedonbehalfby")]
        public SystemUser lk_emailserverprofile_modifiedonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_emailserverprofile_modifiedonbehalfby", null); }
        }

        /// <summary>
        /// N:1 organization_emailserverprofile
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_emailserverprofile")]
        public Organization organization_emailserverprofile
        {
            get { return this.GetRelatedEntity<Organization>("organization_emailserverprofile", null); }
        }

        /// <summary>
        /// N:1 team_emailserverprofile
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_emailserverprofile")]
        public Team team_emailserverprofile
        {
            get { return this.GetRelatedEntity<Team>("team_emailserverprofile", null); }
        }
    }
}