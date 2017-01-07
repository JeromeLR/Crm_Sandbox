namespace __4_DAL_CRM
{
    /// <summary>
    /// Task performed, or to be performed, by a user for planning or running a campaign.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("campaignactivity")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class CampaignActivity : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public CampaignActivity() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "campaignactivity";

        public const int EntityTypeCode = 4402;

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
        /// Unique identifier of the campaign activity.
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
        /// Type the actual cost of the campaign activity. The value entered is rolled up to the related campaign in the total cost calculations.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("actualcost")]
        public Microsoft.Xrm.Sdk.Money ActualCost
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("actualcost"); }
            set
            {
                this.OnPropertyChanging("ActualCost");
                this.SetAttributeValue("actualcost", value);
                this.OnPropertyChanged("ActualCost");
            }
        }

        /// <summary>
        /// Shows the Actual Cost field converted to the system's default base currency for reporting purposes. The calculations use the exchange rate specified in the Currencies area.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("actualcost_base")]
        public Microsoft.Xrm.Sdk.Money ActualCost_Base
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("actualcost_base"); }
        }

        /// <summary>
        /// Shows the value selected in the Duration field on the campaign activity. The duration is used to report the time spent on the activity.
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
        /// Enter the date when the campaign activity was actually completed.
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
        /// Enter the actual start date and time for the campaign activity to determine if the campaign activity started on the scheduled time.
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
        /// Type the allocated budget of the campaign activity for estimated versus actual cost reporting.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("budgetedcost")]
        public Microsoft.Xrm.Sdk.Money BudgetedCost
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("budgetedcost"); }
            set
            {
                this.OnPropertyChanging("BudgetedCost");
                this.SetAttributeValue("budgetedcost", value);
                this.OnPropertyChanged("BudgetedCost");
            }
        }

        /// <summary>
        /// Shows the Budget Allocated field converted to the system's default base currency. The calculations use the exchange rate specified in the Currencies area.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("budgetedcost_base")]
        public Microsoft.Xrm.Sdk.Money BudgetedCost_Base
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("budgetedcost_base"); }
        }

        /// <summary>
        /// Type a category to identify the campaign activity type, such as new business development or customer retention, to tie the campaign activity to a business group or function.
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
        /// Select how communications for this activity will be sent, such as phone, letter, fax, or email.
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
        /// Type additional information to describe the campaign activity, such as key talking points, objectives, or details about the target audience.
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
        /// Select whether to override the opt-out settings on leads, contacts, and accounts for the members of the target marketing lists of the campaign activity. If No is selected, marketing materials will be sent to members who have opted out.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("donotsendonoptout")]
        public System.Nullable<bool> DoNotSendOnOptOut
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("donotsendonoptout"); }
            set
            {
                this.OnPropertyChanging("DoNotSendOnOptOut");
                this.SetAttributeValue("donotsendonoptout", value);
                this.OnPropertyChanged("DoNotSendOnOptOut");
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
        /// Type the minimum number of days that must be passed before a marketing list member can be contacted in a campaign again. The campaign activity will not be applied to members contacted within the specified time period.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("excludeifcontactedinxdays")]
        public System.Nullable<int> ExcludeIfContactedInXDays
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("excludeifcontactedinxdays"); }
            set
            {
                this.OnPropertyChanging("ExcludeIfContactedInXDays");
                this.SetAttributeValue("excludeifcontactedinxdays", value);
                this.OnPropertyChanged("ExcludeIfContactedInXDays");
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
        /// Select whether inactive marketing list members will be excluded from the campaign activity distribution.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ignoreinactivelistmembers")]
        public System.Nullable<bool> IgnoreInactiveListMembers
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("ignoreinactivelistmembers"); }
            set
            {
                this.OnPropertyChanging("IgnoreInactiveListMembers");
                this.SetAttributeValue("ignoreinactivelistmembers", value);
                this.OnPropertyChanged("IgnoreInactiveListMembers");
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
        /// Information regarding whether the campaign activity was billed as part of resolving a case.
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
        /// Information about whether the campaign activity is created by a workflow rule.
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
        /// Unique identifier of the business unit that owns the campaign activity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
        public Microsoft.Xrm.Sdk.EntityReference OwningBusinessUnit
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningbusinessunit"); }
        }

        /// <summary>
        /// Unique identifier of the team who owns the campaign activity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
        public Microsoft.Xrm.Sdk.EntityReference OwningTeam
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningteam"); }
        }

        /// <summary>
        /// Unique identifier of the user who owns the campaign activity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
        public Microsoft.Xrm.Sdk.EntityReference OwningUser
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owninguser"); }
        }

        /// <summary>
        /// Enter the vendor accounts or contacts to capture any third-party suppliers used for the campaign activity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("partners")]
        public System.Collections.Generic.IEnumerable<ActivityParty> Partners
        {
            get
            {
                Microsoft.Xrm.Sdk.EntityCollection collection = this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityCollection>("partners");
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
                this.OnPropertyChanging("Partners");
                if ((value == null))
                {
                    this.SetAttributeValue("partners", value);
                }
                else
                {
                    this.SetAttributeValue("partners", new Microsoft.Xrm.Sdk.EntityCollection(new System.Collections.Generic.List<Microsoft.Xrm.Sdk.Entity>(value)));
                }
                this.OnPropertyChanged("Partners");
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
        /// Choose the parent campaign so that the campaign activity costs reflect in the correct campaign for reporting.
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
        /// Scheduled duration, specified in minutes, of the campaign activity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("scheduleddurationminutes")]
        public System.Nullable<int> ScheduledDurationMinutes
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("scheduleddurationminutes"); }
        }

        /// <summary>
        /// Enter the expected due date and time for the activity to be completed to provide details about the timing of the campaign activity.
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
        /// Enter the expected start date and time for the activity to provide details about timing of the campaign activity.
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
        /// Unique identifier of the associated service.
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
        /// Shows whether the campaign activity is open, completed, or canceled. Completed and canceled campaign activities are read-only and can't be edited.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
        public System.Nullable<CampaignActivityState> StateCode
        {
            get
            {
                Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
                if ((optionSet != null))
                {
                    return ((CampaignActivityState) (System.Enum.ToObject(typeof(CampaignActivityState), optionSet.Value)));
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// Select the campaign activity's status.
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
        /// Type a subcategory to identify the campaign activity type and relate the activity to a specific product, sales region, business group, or other function.
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
        /// Type a short description about the objective or primary topic of the campaign activity.
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
        /// Select the type of campaign activity to indicate the purpose of the activity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("typecode")]
        public Microsoft.Xrm.Sdk.OptionSetValue TypeCode
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("typecode"); }
            set
            {
                this.OnPropertyChanging("TypeCode");
                this.SetAttributeValue("typecode", value);
                this.OnPropertyChanged("TypeCode");
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
        /// Version number of the campaign activity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
        public System.Nullable<long> VersionNumber
        {
            get { return this.GetAttributeValue<System.Nullable<long>>("versionnumber"); }
        }

        /// <summary>
        /// 1:N campaignactivity_activity_parties
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("campaignactivity_activity_parties")]
        public System.Collections.Generic.IEnumerable<ActivityParty> campaignactivity_activity_parties
        {
            get { return this.GetRelatedEntities<ActivityParty>("campaignactivity_activity_parties", null); }
            set
            {
                this.OnPropertyChanging("campaignactivity_activity_parties");
                this.SetRelatedEntities<ActivityParty>("campaignactivity_activity_parties", null, value);
                this.OnPropertyChanged("campaignactivity_activity_parties");
            }
        }

        /// <summary>
        /// 1:N campaignactivity_activityparties
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("campaignactivity_activityparties")]
        public System.Collections.Generic.IEnumerable<ActivityParty> campaignactivity_activityparties
        {
            get { return this.GetRelatedEntities<ActivityParty>("campaignactivity_activityparties", null); }
            set
            {
                this.OnPropertyChanging("campaignactivity_activityparties");
                this.SetRelatedEntities<ActivityParty>("campaignactivity_activityparties", null, value);
                this.OnPropertyChanged("campaignactivity_activityparties");
            }
        }

        /// <summary>
        /// 1:N CampaignActivity_ActivityPointers
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("CampaignActivity_ActivityPointers")]
        public System.Collections.Generic.IEnumerable<ActivityPointer> CampaignActivity_ActivityPointers
        {
            get { return this.GetRelatedEntities<ActivityPointer>("CampaignActivity_ActivityPointers", null); }
            set
            {
                this.OnPropertyChanging("CampaignActivity_ActivityPointers");
                this.SetRelatedEntities<ActivityPointer>("CampaignActivity_ActivityPointers", null, value);
                this.OnPropertyChanged("CampaignActivity_ActivityPointers");
            }
        }

        /// <summary>
        /// 1:N CampaignActivity_Annotation
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("CampaignActivity_Annotation")]
        public System.Collections.Generic.IEnumerable<Annotation> CampaignActivity_Annotation
        {
            get { return this.GetRelatedEntities<Annotation>("CampaignActivity_Annotation", null); }
            set
            {
                this.OnPropertyChanging("CampaignActivity_Annotation");
                this.SetRelatedEntities<Annotation>("CampaignActivity_Annotation", null, value);
                this.OnPropertyChanged("CampaignActivity_Annotation");
            }
        }

        /// <summary>
        /// 1:N CampaignActivity_Appointments
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("CampaignActivity_Appointments")]
        public System.Collections.Generic.IEnumerable<Appointment> CampaignActivity_Appointments
        {
            get { return this.GetRelatedEntities<Appointment>("CampaignActivity_Appointments", null); }
            set
            {
                this.OnPropertyChanging("CampaignActivity_Appointments");
                this.SetRelatedEntities<Appointment>("CampaignActivity_Appointments", null, value);
                this.OnPropertyChanged("CampaignActivity_Appointments");
            }
        }

        /// <summary>
        /// 1:N CampaignActivity_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("CampaignActivity_AsyncOperations")]
        public System.Collections.Generic.IEnumerable<AsyncOperation> CampaignActivity_AsyncOperations
        {
            get { return this.GetRelatedEntities<AsyncOperation>("CampaignActivity_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("CampaignActivity_AsyncOperations");
                this.SetRelatedEntities<AsyncOperation>("CampaignActivity_AsyncOperations", null, value);
                this.OnPropertyChanged("CampaignActivity_AsyncOperations");
            }
        }

        /// <summary>
        /// 1:N CampaignActivity_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("CampaignActivity_BulkDeleteFailures")]
        public System.Collections.Generic.IEnumerable<BulkDeleteFailure> CampaignActivity_BulkDeleteFailures
        {
            get { return this.GetRelatedEntities<BulkDeleteFailure>("CampaignActivity_BulkDeleteFailures", null); }
            set
            {
                this.OnPropertyChanging("CampaignActivity_BulkDeleteFailures");
                this.SetRelatedEntities<BulkDeleteFailure>("CampaignActivity_BulkDeleteFailures", null, value);
                this.OnPropertyChanged("CampaignActivity_BulkDeleteFailures");
            }
        }

        /// <summary>
        /// 1:N CampaignActivity_BulkOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("CampaignActivity_BulkOperations")]
        public System.Collections.Generic.IEnumerable<BulkOperation> CampaignActivity_BulkOperations
        {
            get { return this.GetRelatedEntities<BulkOperation>("CampaignActivity_BulkOperations", null); }
            set
            {
                this.OnPropertyChanging("CampaignActivity_BulkOperations");
                this.SetRelatedEntities<BulkOperation>("CampaignActivity_BulkOperations", null, value);
                this.OnPropertyChanged("CampaignActivity_BulkOperations");
            }
        }

        /// <summary>
        /// 1:N campaignactivity_connections1
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("campaignactivity_connections1")]
        public System.Collections.Generic.IEnumerable<Connection> campaignactivity_connections1
        {
            get { return this.GetRelatedEntities<Connection>("campaignactivity_connections1", null); }
            set
            {
                this.OnPropertyChanging("campaignactivity_connections1");
                this.SetRelatedEntities<Connection>("campaignactivity_connections1", null, value);
                this.OnPropertyChanged("campaignactivity_connections1");
            }
        }

        /// <summary>
        /// 1:N campaignactivity_connections2
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("campaignactivity_connections2")]
        public System.Collections.Generic.IEnumerable<Connection> campaignactivity_connections2
        {
            get { return this.GetRelatedEntities<Connection>("campaignactivity_connections2", null); }
            set
            {
                this.OnPropertyChanging("campaignactivity_connections2");
                this.SetRelatedEntities<Connection>("campaignactivity_connections2", null, value);
                this.OnPropertyChanged("campaignactivity_connections2");
            }
        }

        /// <summary>
        /// 1:N CampaignActivity_Emails
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("CampaignActivity_Emails")]
        public System.Collections.Generic.IEnumerable<Email> CampaignActivity_Emails
        {
            get { return this.GetRelatedEntities<Email>("CampaignActivity_Emails", null); }
            set
            {
                this.OnPropertyChanging("CampaignActivity_Emails");
                this.SetRelatedEntities<Email>("CampaignActivity_Emails", null, value);
                this.OnPropertyChanged("CampaignActivity_Emails");
            }
        }

        /// <summary>
        /// 1:N CampaignActivity_Faxes
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("CampaignActivity_Faxes")]
        public System.Collections.Generic.IEnumerable<Fax> CampaignActivity_Faxes
        {
            get { return this.GetRelatedEntities<Fax>("CampaignActivity_Faxes", null); }
            set
            {
                this.OnPropertyChanging("CampaignActivity_Faxes");
                this.SetRelatedEntities<Fax>("CampaignActivity_Faxes", null, value);
                this.OnPropertyChanged("CampaignActivity_Faxes");
            }
        }

        /// <summary>
        /// 1:N CampaignActivity_Letters
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("CampaignActivity_Letters")]
        public System.Collections.Generic.IEnumerable<Letter> CampaignActivity_Letters
        {
            get { return this.GetRelatedEntities<Letter>("CampaignActivity_Letters", null); }
            set
            {
                this.OnPropertyChanging("CampaignActivity_Letters");
                this.SetRelatedEntities<Letter>("CampaignActivity_Letters", null, value);
                this.OnPropertyChanged("CampaignActivity_Letters");
            }
        }

        /// <summary>
        /// 1:N CampaignActivity_Phonecalls
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("CampaignActivity_Phonecalls")]
        public System.Collections.Generic.IEnumerable<PhoneCall> CampaignActivity_Phonecalls
        {
            get { return this.GetRelatedEntities<PhoneCall>("CampaignActivity_Phonecalls", null); }
            set
            {
                this.OnPropertyChanging("CampaignActivity_Phonecalls");
                this.SetRelatedEntities<PhoneCall>("CampaignActivity_Phonecalls", null, value);
                this.OnPropertyChanged("CampaignActivity_Phonecalls");
            }
        }

        /// <summary>
        /// 1:N campaignactivity_principalobjectattributeaccess
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("campaignactivity_principalobjectattributeaccess")]
        public System.Collections.Generic.IEnumerable<PrincipalObjectAttributeAccess> campaignactivity_principalobjectattributeaccess
        {
            get { return this.GetRelatedEntities<PrincipalObjectAttributeAccess>("campaignactivity_principalobjectattributeaccess", null); }
            set
            {
                this.OnPropertyChanging("campaignactivity_principalobjectattributeaccess");
                this.SetRelatedEntities<PrincipalObjectAttributeAccess>("campaignactivity_principalobjectattributeaccess", null, value);
                this.OnPropertyChanged("campaignactivity_principalobjectattributeaccess");
            }
        }

        /// <summary>
        /// 1:N CampaignActivity_ProcessSessions
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("CampaignActivity_ProcessSessions")]
        public System.Collections.Generic.IEnumerable<ProcessSession> CampaignActivity_ProcessSessions
        {
            get { return this.GetRelatedEntities<ProcessSession>("CampaignActivity_ProcessSessions", null); }
            set
            {
                this.OnPropertyChanging("CampaignActivity_ProcessSessions");
                this.SetRelatedEntities<ProcessSession>("CampaignActivity_ProcessSessions", null, value);
                this.OnPropertyChanged("CampaignActivity_ProcessSessions");
            }
        }

        /// <summary>
        /// 1:N CampaignActivity_QueueItem
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("CampaignActivity_QueueItem")]
        public System.Collections.Generic.IEnumerable<QueueItem> CampaignActivity_QueueItem
        {
            get { return this.GetRelatedEntities<QueueItem>("CampaignActivity_QueueItem", null); }
            set
            {
                this.OnPropertyChanging("CampaignActivity_QueueItem");
                this.SetRelatedEntities<QueueItem>("CampaignActivity_QueueItem", null, value);
                this.OnPropertyChanged("CampaignActivity_QueueItem");
            }
        }

        /// <summary>
        /// 1:N CampaignActivity_RecurringAppointmentMasters
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("CampaignActivity_RecurringAppointmentMasters")]
        public System.Collections.Generic.IEnumerable<RecurringAppointmentMaster> CampaignActivity_RecurringAppointmentMasters
        {
            get { return this.GetRelatedEntities<RecurringAppointmentMaster>("CampaignActivity_RecurringAppointmentMasters", null); }
            set
            {
                this.OnPropertyChanging("CampaignActivity_RecurringAppointmentMasters");
                this.SetRelatedEntities<RecurringAppointmentMaster>("CampaignActivity_RecurringAppointmentMasters", null, value);
                this.OnPropertyChanged("CampaignActivity_RecurringAppointmentMasters");
            }
        }

        /// <summary>
        /// 1:N CampaignActivity_Tasks
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("CampaignActivity_Tasks")]
        public System.Collections.Generic.IEnumerable<Task> CampaignActivity_Tasks
        {
            get { return this.GetRelatedEntities<Task>("CampaignActivity_Tasks", null); }
            set
            {
                this.OnPropertyChanging("CampaignActivity_Tasks");
                this.SetRelatedEntities<Task>("CampaignActivity_Tasks", null, value);
                this.OnPropertyChanged("CampaignActivity_Tasks");
            }
        }

        /// <summary>
        /// 1:N userentityinstancedata_campaignactivity
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_campaignactivity")]
        public System.Collections.Generic.IEnumerable<UserEntityInstanceData> userentityinstancedata_campaignactivity
        {
            get { return this.GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_campaignactivity", null); }
            set
            {
                this.OnPropertyChanging("userentityinstancedata_campaignactivity");
                this.SetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_campaignactivity", null, value);
                this.OnPropertyChanged("userentityinstancedata_campaignactivity");
            }
        }

        /// <summary>
        /// N:N campaignactivitylist_association
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("campaignactivitylist_association")]
        public System.Collections.Generic.IEnumerable<List> campaignactivitylist_association
        {
            get { return this.GetRelatedEntities<List>("campaignactivitylist_association", null); }
            set
            {
                this.OnPropertyChanging("campaignactivitylist_association");
                this.SetRelatedEntities<List>("campaignactivitylist_association", null, value);
                this.OnPropertyChanged("campaignactivitylist_association");
            }
        }

        /// <summary>
        /// N:N campaignactivitysalesliterature_association
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("campaignactivitysalesliterature_association")]
        public System.Collections.Generic.IEnumerable<SalesLiterature> campaignactivitysalesliterature_association
        {
            get { return this.GetRelatedEntities<SalesLiterature>("campaignactivitysalesliterature_association", null); }
            set
            {
                this.OnPropertyChanging("campaignactivitysalesliterature_association");
                this.SetRelatedEntities<SalesLiterature>("campaignactivitysalesliterature_association", null, value);
                this.OnPropertyChanged("campaignactivitysalesliterature_association");
            }
        }

        /// <summary>
        /// N:1 activity_pointer_campaignactivity
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("activityid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("activity_pointer_campaignactivity")]
        public ActivityPointer activity_pointer_campaignactivity
        {
            get { return this.GetRelatedEntity<ActivityPointer>("activity_pointer_campaignactivity", null); }
            set
            {
                this.OnPropertyChanging("activity_pointer_campaignactivity");
                this.SetRelatedEntity<ActivityPointer>("activity_pointer_campaignactivity", null, value);
                this.OnPropertyChanged("activity_pointer_campaignactivity");
            }
        }

        /// <summary>
        /// N:1 business_unit_campaignactivity_activities
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_campaignactivity_activities")]
        public BusinessUnit business_unit_campaignactivity_activities
        {
            get { return this.GetRelatedEntity<BusinessUnit>("business_unit_campaignactivity_activities", null); }
        }

        /// <summary>
        /// N:1 Campaign_CampaignActivities
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Campaign_CampaignActivities")]
        public Campaign Campaign_CampaignActivities
        {
            get { return this.GetRelatedEntity<Campaign>("Campaign_CampaignActivities", null); }
            set
            {
                this.OnPropertyChanging("Campaign_CampaignActivities");
                this.SetRelatedEntity<Campaign>("Campaign_CampaignActivities", null, value);
                this.OnPropertyChanged("Campaign_CampaignActivities");
            }
        }

        /// <summary>
        /// N:1 lk_campaignactivity_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_campaignactivity_createdby")]
        public SystemUser lk_campaignactivity_createdby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_campaignactivity_createdby", null); }
        }

        /// <summary>
        /// N:1 lk_campaignactivity_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_campaignactivity_createdonbehalfby")]
        public SystemUser lk_campaignactivity_createdonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_campaignactivity_createdonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_campaignactivity_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_campaignactivity_modifiedby")]
        public SystemUser lk_campaignactivity_modifiedby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_campaignactivity_modifiedby", null); }
        }

        /// <summary>
        /// N:1 lk_campaignactivity_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_campaignactivity_modifiedonbehalfby")]
        public SystemUser lk_campaignactivity_modifiedonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_campaignactivity_modifiedonbehalfby", null); }
        }

        /// <summary>
        /// N:1 processstage_campaignactivities
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("stageid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("processstage_campaignactivities")]
        public ProcessStage processstage_campaignactivities
        {
            get { return this.GetRelatedEntity<ProcessStage>("processstage_campaignactivities", null); }
            set
            {
                this.OnPropertyChanging("processstage_campaignactivities");
                this.SetRelatedEntity<ProcessStage>("processstage_campaignactivities", null, value);
                this.OnPropertyChanged("processstage_campaignactivities");
            }
        }

        /// <summary>
        /// N:1 team_campaignactivity
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_campaignactivity")]
        public Team team_campaignactivity
        {
            get { return this.GetRelatedEntity<Team>("team_campaignactivity", null); }
        }

        /// <summary>
        /// N:1 transactioncurrency_campaignactivity
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("transactioncurrency_campaignactivity")]
        public TransactionCurrency transactioncurrency_campaignactivity
        {
            get { return this.GetRelatedEntity<TransactionCurrency>("transactioncurrency_campaignactivity", null); }
        }

        /// <summary>
        /// N:1 user_campaignactivity
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_campaignactivity")]
        public SystemUser user_campaignactivity
        {
            get { return this.GetRelatedEntity<SystemUser>("user_campaignactivity", null); }
        }
    }
}