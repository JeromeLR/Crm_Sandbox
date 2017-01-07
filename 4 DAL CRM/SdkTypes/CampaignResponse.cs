namespace __4_DAL_CRM
{
    /// <summary>
    /// Response from an existing or a potential new customer for a campaign.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("campaignresponse")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class CampaignResponse : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public CampaignResponse() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "campaignresponse";

        public const int EntityTypeCode = 4401;

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
        /// Unique identifier of the campaign response.
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
        /// Type of activity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("activitytypecode")]
        public string ActivityTypeCode
        {
            get { return this.GetAttributeValue<string>("activitytypecode"); }
        }

        /// <summary>
        /// Type the number of minutes spent on this activity. The duration is used in reporting.
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
        /// Enter the date when the campaign response was actually completed.
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
        /// Enter the actual start date and time for the campaign response.
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
        /// Type a category to identify the campaign response type, such as new business development or customer retention, to tie the campaign response to a business group or function.
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
        /// Select how the response was received, such as phone, letter, fax, or email.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("channeltypecode")]
        public Microsoft.Xrm.Sdk.OptionSetValue ChannelTypeCode
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("channeltypecode"); }
            set
            {
                this.OnPropertyChanging("ChannelTypeCode");
                this.SetAttributeValue("channeltypecode", value);
                this.OnPropertyChanged("ChannelTypeCode");
            }
        }

        /// <summary>
        /// Type the name of the company if the campaign response was received from a new prospect or customer.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("companyname")]
        public string CompanyName
        {
            get { return this.GetAttributeValue<string>("companyname"); }
            set
            {
                this.OnPropertyChanging("CompanyName");
                this.SetAttributeValue("companyname", value);
                this.OnPropertyChanged("CompanyName");
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
        /// Enter the account, contact, or lead that submitted the campaign response, if it was received from an existing prospect or customer.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("customer")]
        public System.Collections.Generic.IEnumerable<ActivityParty> Customer
        {
            get
            {
                Microsoft.Xrm.Sdk.EntityCollection collection = this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityCollection>("customer");
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
                this.OnPropertyChanging("Customer");
                if ((value == null))
                {
                    this.SetAttributeValue("customer", value);
                }
                else
                {
                    this.SetAttributeValue("customer", new Microsoft.Xrm.Sdk.EntityCollection(new System.Collections.Generic.List<Microsoft.Xrm.Sdk.Entity>(value)));
                }
                this.OnPropertyChanged("Customer");
            }
        }

        /// <summary>
        /// Type additional information to describe the campaign response, such as key discussion points or objectives.
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
        /// Type the responder's email address.
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
        /// Shows the conversion rate of the record's currency. The exchange rate is used to convert all money fields in the record from the local currency to the system's default currency.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("exchangerate")]
        public System.Nullable<decimal> ExchangeRate
        {
            get { return this.GetAttributeValue<System.Nullable<decimal>>("exchangerate"); }
        }

        /// <summary>
        /// Type the responder's fax number.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("fax")]
        public string Fax
        {
            get { return this.GetAttributeValue<string>("fax"); }
            set
            {
                this.OnPropertyChanging("Fax");
                this.SetAttributeValue("fax", value);
                this.OnPropertyChanged("Fax");
            }
        }

        /// <summary>
        /// Type the responder's first name if the campaign response was received from a new prospect or customer.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("firstname")]
        public string FirstName
        {
            get { return this.GetAttributeValue<string>("firstname"); }
            set
            {
                this.OnPropertyChanging("FirstName");
                this.SetAttributeValue("firstname", value);
                this.OnPropertyChanged("FirstName");
            }
        }

        /// <summary>
        /// For system use only.
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
        /// Specifies whether the campaign response was billed as part of resolving a case.
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
        /// Specifies whether the campaign response is created by a workflow rule.
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
        /// Type the responder's last name if the campaign response was received from a new prospect or customer.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("lastname")]
        public string LastName
        {
            get { return this.GetAttributeValue<string>("lastname"); }
            set
            {
                this.OnPropertyChanging("LastName");
                this.SetAttributeValue("lastname", value);
                this.OnPropertyChanged("LastName");
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
        /// Choose the phone call, email, fax, letter, or appointment activity that led the prospect or customer to respond to the campaign.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("originatingactivityid")]
        public Microsoft.Xrm.Sdk.EntityReference OriginatingActivityId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("originatingactivityid"); }
            set
            {
                this.OnPropertyChanging("OriginatingActivityId");
                this.SetAttributeValue("originatingactivityid", value);
                this.OnPropertyChanged("OriginatingActivityId");
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
        /// Unique identifier for the business unit that owns the campaign response.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
        public Microsoft.Xrm.Sdk.EntityReference OwningBusinessUnit
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningbusinessunit"); }
        }

        /// <summary>
        /// Unique identifier of the team who owns the campaign response.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
        public Microsoft.Xrm.Sdk.EntityReference OwningTeam
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningteam"); }
        }

        /// <summary>
        /// Unique identifier of the user who owns the campaign response.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
        public Microsoft.Xrm.Sdk.EntityReference OwningUser
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owninguser"); }
        }

        /// <summary>
        /// Enter the vendor account or contact to capture any third-party used to obtain the campaign response.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("partner")]
        public System.Collections.Generic.IEnumerable<ActivityParty> Partner
        {
            get
            {
                Microsoft.Xrm.Sdk.EntityCollection collection = this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityCollection>("partner");
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
                this.OnPropertyChanging("Partner");
                if ((value == null))
                {
                    this.SetAttributeValue("partner", value);
                }
                else
                {
                    this.SetAttributeValue("partner", new Microsoft.Xrm.Sdk.EntityCollection(new System.Collections.Generic.List<Microsoft.Xrm.Sdk.Entity>(value)));
                }
                this.OnPropertyChanged("Partner");
            }
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
        /// Type a promotional code to track sales related to the campaign response or to allow the responder to redeem a discount offer.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("promotioncodename")]
        public string PromotionCodeName
        {
            get { return this.GetAttributeValue<string>("promotioncodename"); }
            set
            {
                this.OnPropertyChanging("PromotionCodeName");
                this.SetAttributeValue("promotioncodename", value);
                this.OnPropertyChanged("PromotionCodeName");
            }
        }

        /// <summary>
        /// Enter the date when the campaign response was received.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("receivedon")]
        public System.Nullable<System.DateTime> ReceivedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("receivedon"); }
            set
            {
                this.OnPropertyChanging("ReceivedOn");
                this.SetAttributeValue("receivedon", value);
                this.OnPropertyChanged("ReceivedOn");
            }
        }

        /// <summary>
        /// Choose the parent campaign so that the campaign's response rate is tracked correctly.
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
        /// Select the type of response from the prospect or customer to indicate their interest in the campaign.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("responsecode")]
        public Microsoft.Xrm.Sdk.OptionSetValue ResponseCode
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("responsecode"); }
            set
            {
                this.OnPropertyChanging("ResponseCode");
                this.SetAttributeValue("responsecode", value);
                this.OnPropertyChanged("ResponseCode");
            }
        }

        /// <summary>
        /// Scheduled duration of the campaign response in minutes.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("scheduleddurationminutes")]
        public System.Nullable<int> ScheduledDurationMinutes
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("scheduleddurationminutes"); }
        }

        /// <summary>
        /// Enter the expected due date and time for the activity to be completed to provide details about the timing of the campaign response.
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
        /// Enter the expected start date and time for the activity to provide details about the timing of the campaign response.
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
        /// Shows whether the campaign response is open, closed, or canceled. Closed and canceled campaign responses are read-only and can't be edited.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
        public System.Nullable<CampaignResponseState> StateCode
        {
            get
            {
                Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
                if ((optionSet != null))
                {
                    return ((CampaignResponseState) (System.Enum.ToObject(typeof(CampaignResponseState), optionSet.Value)));
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// Select the campaign response's status.
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
        /// Type a subcategory to identify the campaign response type and relate the activity to a specific product, sales region, business group, or other function.
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
        /// Type a short description about the objective or primary topic of the campaign response.
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
        /// Type the responder's primary phone number.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("telephone")]
        public string Telephone
        {
            get { return this.GetAttributeValue<string>("telephone"); }
            set
            {
                this.OnPropertyChanging("Telephone");
                this.SetAttributeValue("telephone", value);
                this.OnPropertyChanged("Telephone");
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
        /// Version number of the campaign response.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
        public System.Nullable<long> VersionNumber
        {
            get { return this.GetAttributeValue<System.Nullable<long>>("versionnumber"); }
        }

        /// <summary>
        /// Type the phonetic spelling of the company name, if specified in Japanese, to make sure the name is pronounced correctly in phone calls and other communications.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("yomicompanyname")]
        public string YomiCompanyName
        {
            get { return this.GetAttributeValue<string>("yomicompanyname"); }
            set
            {
                this.OnPropertyChanging("YomiCompanyName");
                this.SetAttributeValue("yomicompanyname", value);
                this.OnPropertyChanged("YomiCompanyName");
            }
        }

        /// <summary>
        /// Type the phonetic spelling of the campaign responder's first name, if specified in Japanese, to make sure the name is pronounced correctly in phone calls and other communications.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("yomifirstname")]
        public string YomiFirstName
        {
            get { return this.GetAttributeValue<string>("yomifirstname"); }
            set
            {
                this.OnPropertyChanging("YomiFirstName");
                this.SetAttributeValue("yomifirstname", value);
                this.OnPropertyChanged("YomiFirstName");
            }
        }

        /// <summary>
        /// Type the phonetic spelling of the campaign responder's last name, if specified in Japanese, to make sure the name is pronounced correctly in phone calls and other communications.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("yomilastname")]
        public string YomiLastName
        {
            get { return this.GetAttributeValue<string>("yomilastname"); }
            set
            {
                this.OnPropertyChanging("YomiLastName");
                this.SetAttributeValue("yomilastname", value);
                this.OnPropertyChanged("YomiLastName");
            }
        }

        /// <summary>
        /// 1:N campaignresponse_activity_parties
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("campaignresponse_activity_parties")]
        public System.Collections.Generic.IEnumerable<ActivityParty> campaignresponse_activity_parties
        {
            get { return this.GetRelatedEntities<ActivityParty>("campaignresponse_activity_parties", null); }
            set
            {
                this.OnPropertyChanging("campaignresponse_activity_parties");
                this.SetRelatedEntities<ActivityParty>("campaignresponse_activity_parties", null, value);
                this.OnPropertyChanged("campaignresponse_activity_parties");
            }
        }

        /// <summary>
        /// 1:N CampaignResponse_Annotation
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("CampaignResponse_Annotation")]
        public System.Collections.Generic.IEnumerable<Annotation> CampaignResponse_Annotation
        {
            get { return this.GetRelatedEntities<Annotation>("CampaignResponse_Annotation", null); }
            set
            {
                this.OnPropertyChanging("CampaignResponse_Annotation");
                this.SetRelatedEntities<Annotation>("CampaignResponse_Annotation", null, value);
                this.OnPropertyChanged("CampaignResponse_Annotation");
            }
        }

        /// <summary>
        /// 1:N CampaignResponse_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("CampaignResponse_AsyncOperations")]
        public System.Collections.Generic.IEnumerable<AsyncOperation> CampaignResponse_AsyncOperations
        {
            get { return this.GetRelatedEntities<AsyncOperation>("CampaignResponse_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("CampaignResponse_AsyncOperations");
                this.SetRelatedEntities<AsyncOperation>("CampaignResponse_AsyncOperations", null, value);
                this.OnPropertyChanged("CampaignResponse_AsyncOperations");
            }
        }

        /// <summary>
        /// 1:N CampaignResponse_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("CampaignResponse_BulkDeleteFailures")]
        public System.Collections.Generic.IEnumerable<BulkDeleteFailure> CampaignResponse_BulkDeleteFailures
        {
            get { return this.GetRelatedEntities<BulkDeleteFailure>("CampaignResponse_BulkDeleteFailures", null); }
            set
            {
                this.OnPropertyChanging("CampaignResponse_BulkDeleteFailures");
                this.SetRelatedEntities<BulkDeleteFailure>("CampaignResponse_BulkDeleteFailures", null, value);
                this.OnPropertyChanged("CampaignResponse_BulkDeleteFailures");
            }
        }

        /// <summary>
        /// 1:N CampaignResponse_DuplicateBaseRecord
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("CampaignResponse_DuplicateBaseRecord")]
        public System.Collections.Generic.IEnumerable<DuplicateRecord> CampaignResponse_DuplicateBaseRecord
        {
            get { return this.GetRelatedEntities<DuplicateRecord>("CampaignResponse_DuplicateBaseRecord", null); }
            set
            {
                this.OnPropertyChanging("CampaignResponse_DuplicateBaseRecord");
                this.SetRelatedEntities<DuplicateRecord>("CampaignResponse_DuplicateBaseRecord", null, value);
                this.OnPropertyChanged("CampaignResponse_DuplicateBaseRecord");
            }
        }

        /// <summary>
        /// 1:N CampaignResponse_DuplicateMatchingRecord
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("CampaignResponse_DuplicateMatchingRecord")]
        public System.Collections.Generic.IEnumerable<DuplicateRecord> CampaignResponse_DuplicateMatchingRecord
        {
            get { return this.GetRelatedEntities<DuplicateRecord>("CampaignResponse_DuplicateMatchingRecord", null); }
            set
            {
                this.OnPropertyChanging("CampaignResponse_DuplicateMatchingRecord");
                this.SetRelatedEntities<DuplicateRecord>("CampaignResponse_DuplicateMatchingRecord", null, value);
                this.OnPropertyChanged("CampaignResponse_DuplicateMatchingRecord");
            }
        }

        /// <summary>
        /// 1:N CampaignResponse_Lead
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("CampaignResponse_Lead")]
        public System.Collections.Generic.IEnumerable<Lead> CampaignResponse_Lead
        {
            get { return this.GetRelatedEntities<Lead>("CampaignResponse_Lead", null); }
            set
            {
                this.OnPropertyChanging("CampaignResponse_Lead");
                this.SetRelatedEntities<Lead>("CampaignResponse_Lead", null, value);
                this.OnPropertyChanged("CampaignResponse_Lead");
            }
        }

        /// <summary>
        /// 1:N campaignresponse_principalobjectattributeaccess
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("campaignresponse_principalobjectattributeaccess")]
        public System.Collections.Generic.IEnumerable<PrincipalObjectAttributeAccess> campaignresponse_principalobjectattributeaccess
        {
            get { return this.GetRelatedEntities<PrincipalObjectAttributeAccess>("campaignresponse_principalobjectattributeaccess", null); }
            set
            {
                this.OnPropertyChanging("campaignresponse_principalobjectattributeaccess");
                this.SetRelatedEntities<PrincipalObjectAttributeAccess>("campaignresponse_principalobjectattributeaccess", null, value);
                this.OnPropertyChanged("campaignresponse_principalobjectattributeaccess");
            }
        }

        /// <summary>
        /// 1:N CampaignResponse_ProcessSessions
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("CampaignResponse_ProcessSessions")]
        public System.Collections.Generic.IEnumerable<ProcessSession> CampaignResponse_ProcessSessions
        {
            get { return this.GetRelatedEntities<ProcessSession>("CampaignResponse_ProcessSessions", null); }
            set
            {
                this.OnPropertyChanging("CampaignResponse_ProcessSessions");
                this.SetRelatedEntities<ProcessSession>("CampaignResponse_ProcessSessions", null, value);
                this.OnPropertyChanged("CampaignResponse_ProcessSessions");
            }
        }

        /// <summary>
        /// 1:N CampaignResponse_QueueItem
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("CampaignResponse_QueueItem")]
        public System.Collections.Generic.IEnumerable<QueueItem> CampaignResponse_QueueItem
        {
            get { return this.GetRelatedEntities<QueueItem>("CampaignResponse_QueueItem", null); }
            set
            {
                this.OnPropertyChanging("CampaignResponse_QueueItem");
                this.SetRelatedEntities<QueueItem>("CampaignResponse_QueueItem", null, value);
                this.OnPropertyChanged("CampaignResponse_QueueItem");
            }
        }

        /// <summary>
        /// 1:N userentityinstancedata_campaignresponse
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_campaignresponse")]
        public System.Collections.Generic.IEnumerable<UserEntityInstanceData> userentityinstancedata_campaignresponse
        {
            get { return this.GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_campaignresponse", null); }
            set
            {
                this.OnPropertyChanging("userentityinstancedata_campaignresponse");
                this.SetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_campaignresponse", null, value);
                this.OnPropertyChanged("userentityinstancedata_campaignresponse");
            }
        }

        /// <summary>
        /// N:1 activity_campaignresponse
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("originatingactivityid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("activity_campaignresponse")]
        public ActivityPointer activity_campaignresponse
        {
            get { return this.GetRelatedEntity<ActivityPointer>("activity_campaignresponse", null); }
            set
            {
                this.OnPropertyChanging("activity_campaignresponse");
                this.SetRelatedEntity<ActivityPointer>("activity_campaignresponse", null, value);
                this.OnPropertyChanged("activity_campaignresponse");
            }
        }

        /// <summary>
        /// N:1 activity_pointer_campaignresponse
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("activityid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("activity_pointer_campaignresponse")]
        public ActivityPointer activity_pointer_campaignresponse
        {
            get { return this.GetRelatedEntity<ActivityPointer>("activity_pointer_campaignresponse", null); }
            set
            {
                this.OnPropertyChanging("activity_pointer_campaignresponse");
                this.SetRelatedEntity<ActivityPointer>("activity_pointer_campaignresponse", null, value);
                this.OnPropertyChanged("activity_pointer_campaignresponse");
            }
        }

        /// <summary>
        /// N:1 appointment_campaignresponse
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("originatingactivityid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("appointment_campaignresponse")]
        public Appointment appointment_campaignresponse
        {
            get { return this.GetRelatedEntity<Appointment>("appointment_campaignresponse", null); }
            set
            {
                this.OnPropertyChanging("appointment_campaignresponse");
                this.SetRelatedEntity<Appointment>("appointment_campaignresponse", null, value);
                this.OnPropertyChanged("appointment_campaignresponse");
            }
        }

        /// <summary>
        /// N:1 BulkOperation_CampaignResponse
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("BulkOperation_CampaignResponse")]
        public BulkOperation BulkOperation_CampaignResponse
        {
            get { return this.GetRelatedEntity<BulkOperation>("BulkOperation_CampaignResponse", null); }
            set
            {
                this.OnPropertyChanging("BulkOperation_CampaignResponse");
                this.SetRelatedEntity<BulkOperation>("BulkOperation_CampaignResponse", null, value);
                this.OnPropertyChanged("BulkOperation_CampaignResponse");
            }
        }

        /// <summary>
        /// N:1 business_unit_campaignresponse_activities
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_campaignresponse_activities")]
        public BusinessUnit business_unit_campaignresponse_activities
        {
            get { return this.GetRelatedEntity<BusinessUnit>("business_unit_campaignresponse_activities", null); }
        }

        /// <summary>
        /// N:1 Campaign_CampaignResponses
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Campaign_CampaignResponses")]
        public Campaign Campaign_CampaignResponses
        {
            get { return this.GetRelatedEntity<Campaign>("Campaign_CampaignResponses", null); }
            set
            {
                this.OnPropertyChanging("Campaign_CampaignResponses");
                this.SetRelatedEntity<Campaign>("Campaign_CampaignResponses", null, value);
                this.OnPropertyChanged("Campaign_CampaignResponses");
            }
        }

        /// <summary>
        /// N:1 email_campaignresponse
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("originatingactivityid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("email_campaignresponse")]
        public Email email_campaignresponse
        {
            get { return this.GetRelatedEntity<Email>("email_campaignresponse", null); }
            set
            {
                this.OnPropertyChanging("email_campaignresponse");
                this.SetRelatedEntity<Email>("email_campaignresponse", null, value);
                this.OnPropertyChanged("email_campaignresponse");
            }
        }

        /// <summary>
        /// N:1 fax_campaignresponse
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("originatingactivityid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("fax_campaignresponse")]
        public Fax fax_campaignresponse
        {
            get { return this.GetRelatedEntity<Fax>("fax_campaignresponse", null); }
            set
            {
                this.OnPropertyChanging("fax_campaignresponse");
                this.SetRelatedEntity<Fax>("fax_campaignresponse", null, value);
                this.OnPropertyChanged("fax_campaignresponse");
            }
        }

        /// <summary>
        /// N:1 letter_campaignresponse
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("originatingactivityid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("letter_campaignresponse")]
        public Letter letter_campaignresponse
        {
            get { return this.GetRelatedEntity<Letter>("letter_campaignresponse", null); }
            set
            {
                this.OnPropertyChanging("letter_campaignresponse");
                this.SetRelatedEntity<Letter>("letter_campaignresponse", null, value);
                this.OnPropertyChanged("letter_campaignresponse");
            }
        }

        /// <summary>
        /// N:1 lk_campaignresponse_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_campaignresponse_createdby")]
        public SystemUser lk_campaignresponse_createdby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_campaignresponse_createdby", null); }
        }

        /// <summary>
        /// N:1 lk_campaignresponse_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_campaignresponse_createdonbehalfby")]
        public SystemUser lk_campaignresponse_createdonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_campaignresponse_createdonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_campaignresponse_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_campaignresponse_modifiedby")]
        public SystemUser lk_campaignresponse_modifiedby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_campaignresponse_modifiedby", null); }
        }

        /// <summary>
        /// N:1 lk_campaignresponse_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_campaignresponse_modifiedonbehalfby")]
        public SystemUser lk_campaignresponse_modifiedonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_campaignresponse_modifiedonbehalfby", null); }
        }

        /// <summary>
        /// N:1 phonecall_campaignresponse
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("originatingactivityid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("phonecall_campaignresponse")]
        public PhoneCall phonecall_campaignresponse
        {
            get { return this.GetRelatedEntity<PhoneCall>("phonecall_campaignresponse", null); }
            set
            {
                this.OnPropertyChanging("phonecall_campaignresponse");
                this.SetRelatedEntity<PhoneCall>("phonecall_campaignresponse", null, value);
                this.OnPropertyChanged("phonecall_campaignresponse");
            }
        }

        /// <summary>
        /// N:1 processstage_campaignresponses
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("stageid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("processstage_campaignresponses")]
        public ProcessStage processstage_campaignresponses
        {
            get { return this.GetRelatedEntity<ProcessStage>("processstage_campaignresponses", null); }
            set
            {
                this.OnPropertyChanging("processstage_campaignresponses");
                this.SetRelatedEntity<ProcessStage>("processstage_campaignresponses", null, value);
                this.OnPropertyChanged("processstage_campaignresponses");
            }
        }

        /// <summary>
        /// N:1 recurringappointmentmaster_campaignresponse
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("originatingactivityid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("recurringappointmentmaster_campaignresponse")]
        public RecurringAppointmentMaster recurringappointmentmaster_campaignresponse
        {
            get { return this.GetRelatedEntity<RecurringAppointmentMaster>("recurringappointmentmaster_campaignresponse", null); }
            set
            {
                this.OnPropertyChanging("recurringappointmentmaster_campaignresponse");
                this.SetRelatedEntity<RecurringAppointmentMaster>("recurringappointmentmaster_campaignresponse", null, value);
                this.OnPropertyChanged("recurringappointmentmaster_campaignresponse");
            }
        }

        /// <summary>
        /// N:1 team_campaignresponse
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_campaignresponse")]
        public Team team_campaignresponse
        {
            get { return this.GetRelatedEntity<Team>("team_campaignresponse", null); }
        }

        /// <summary>
        /// N:1 TransactionCurrency_CampaignResponse
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("TransactionCurrency_CampaignResponse")]
        public TransactionCurrency TransactionCurrency_CampaignResponse
        {
            get { return this.GetRelatedEntity<TransactionCurrency>("TransactionCurrency_CampaignResponse", null); }
            set
            {
                this.OnPropertyChanging("TransactionCurrency_CampaignResponse");
                this.SetRelatedEntity<TransactionCurrency>("TransactionCurrency_CampaignResponse", null, value);
                this.OnPropertyChanged("TransactionCurrency_CampaignResponse");
            }
        }

        /// <summary>
        /// N:1 user_campaignresponse
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_campaignresponse")]
        public SystemUser user_campaignresponse
        {
            get { return this.GetRelatedEntity<SystemUser>("user_campaignresponse", null); }
        }
    }
}