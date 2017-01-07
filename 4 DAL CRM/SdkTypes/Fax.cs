using _4_DAL_CRM;

namespace __4_DAL_CRM
{
    /// <summary>
    /// Activity that tracks call outcome and number of pages for a fax and optionally stores an electronic copy of the document.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("fax")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class Fax : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public Fax() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "fax";

        public const int EntityTypeCode = 4204;

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
        /// Unique identifier of the fax activity.
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
        /// Type the number of minutes spent creating and sending the fax. The duration is used in reporting.
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
        /// Enter the actual end date and time of the fax. By default, it displays the date and time when the activity was completed or canceled, but can be edited to capture the actual time to create and send the fax.
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
        /// Enter the actual start date and time for the fax. By default, it displays the date and time when the activity was created, but can be edited to capture the actual time to create and send the fax.
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
        /// Type the billing code for the fax to make sure the fax is charged to the correct sender or customer account.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("billingcode")]
        public string BillingCode
        {
            get { return this.GetAttributeValue<string>("billingcode"); }
            set
            {
                this.OnPropertyChanging("BillingCode");
                this.SetAttributeValue("billingcode", value);
                this.OnPropertyChanged("BillingCode");
            }
        }

        /// <summary>
        /// Type a category to identify the fax type, such as sales offer or press release, to tie the fax to a business group or function.
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
        /// Type the name of the cover page to use when sending the fax.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("coverpagename")]
        public string CoverPageName
        {
            get { return this.GetAttributeValue<string>("coverpagename"); }
            set
            {
                this.OnPropertyChanging("CoverPageName");
                this.SetAttributeValue("coverpagename", value);
                this.OnPropertyChanged("CoverPageName");
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
        /// Type additional information to describe the fax, such as the primary message or the products and services featured.
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
        /// Select the direction of the fax as incoming or outbound.
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
        /// Shows the conversion rate of the record's currency. The exchange rate is used to convert all money fields in the record from the local currency to the system's default currency.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("exchangerate")]
        public System.Nullable<decimal> ExchangeRate
        {
            get { return this.GetAttributeValue<System.Nullable<decimal>>("exchangerate"); }
        }

        /// <summary>
        /// Type the recipient's fax number.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("faxnumber")]
        public string FaxNumber
        {
            get { return this.GetAttributeValue<string>("faxnumber"); }
            set
            {
                this.OnPropertyChanging("FaxNumber");
                this.SetAttributeValue("faxnumber", value);
                this.OnPropertyChanged("FaxNumber");
            }
        }

        /// <summary>
        /// Enter the account, contact, lead, queue, or user who sent the fax.
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
        /// Information regarding whether the fax activity was billed as part of resolving a case.
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
        /// Indication of whether the fax activity was created by a workflow rule.
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
        /// Shows who last updated the record on behalf of another user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        /// Type the number of pages included in the fax.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("numberofpages")]
        public System.Nullable<int> NumberOfPages
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("numberofpages"); }
            set
            {
                this.OnPropertyChanging("NumberOfPages");
                this.SetAttributeValue("numberofpages", value);
                this.OnPropertyChanged("NumberOfPages");
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
        /// Unique identifier of the business unit that owns the fax activity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
        public Microsoft.Xrm.Sdk.EntityReference OwningBusinessUnit
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningbusinessunit"); }
        }

        /// <summary>
        /// Unique identifier of the team that owns the fax activity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
        public Microsoft.Xrm.Sdk.EntityReference OwningTeam
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningteam"); }
        }

        /// <summary>
        /// Unique identifier of the user that owns the fax activity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
        public Microsoft.Xrm.Sdk.EntityReference OwningUser
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owninguser"); }
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
        /// Unique identifier of the object with which the fax activity is associated.
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
        /// Shows the expected duration of the fax activity, in minutes.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("scheduleddurationminutes")]
        public System.Nullable<int> ScheduledDurationMinutes
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("scheduleddurationminutes"); }
        }

        /// <summary>
        /// Enter the expected due date and time.
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
        /// Enter the expected due date and time.
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
        /// Unique identifier for an associated service.
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
        /// Shows whether the fax activity is open, completed, or canceled. Completed and canceled fax activities are read-only and can't be edited.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
        public System.Nullable<FaxState> StateCode
        {
            get
            {
                Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
                if ((optionSet != null))
                {
                    return ((FaxState) (System.Enum.ToObject(typeof(FaxState), optionSet.Value)));
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// Select the fax's status.
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
        /// Type a subcategory to identify the fax type to relate the activity to a specific product, sales region, business group, or other function.
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
        /// Type a short description about the objective or primary topic of the fax.
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
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("subscriptionid")]
        public System.Nullable<System.Guid> SubscriptionId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("subscriptionid"); }
            set
            {
                this.OnPropertyChanging("SubscriptionId");
                this.SetAttributeValue("subscriptionid", value);
                this.OnPropertyChanged("SubscriptionId");
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
        /// Enter the account, contact, lead, queue, or user recipients for the fax.
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
        /// Type the Transmitting Subscriber ID (TSID) associated with a send action. This is typically a combination of the recipient's fax or phone number and company name.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("tsid")]
        public string Tsid
        {
            get { return this.GetAttributeValue<string>("tsid"); }
            set
            {
                this.OnPropertyChanging("Tsid");
                this.SetAttributeValue("tsid", value);
                this.OnPropertyChanged("Tsid");
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
        /// Version number of the fax.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
        public System.Nullable<long> VersionNumber
        {
            get { return this.GetAttributeValue<System.Nullable<long>>("versionnumber"); }
        }

        /// <summary>
        /// 1:N fax_activity_parties
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("fax_activity_parties")]
        public System.Collections.Generic.IEnumerable<ActivityParty> fax_activity_parties
        {
            get { return this.GetRelatedEntities<ActivityParty>("fax_activity_parties", null); }
            set
            {
                this.OnPropertyChanging("fax_activity_parties");
                this.SetRelatedEntities<ActivityParty>("fax_activity_parties", null, value);
                this.OnPropertyChanged("fax_activity_parties");
            }
        }

        /// <summary>
        /// 1:N Fax_Annotation
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Fax_Annotation")]
        public System.Collections.Generic.IEnumerable<Annotation> Fax_Annotation
        {
            get { return this.GetRelatedEntities<Annotation>("Fax_Annotation", null); }
            set
            {
                this.OnPropertyChanging("Fax_Annotation");
                this.SetRelatedEntities<Annotation>("Fax_Annotation", null, value);
                this.OnPropertyChanged("Fax_Annotation");
            }
        }

        /// <summary>
        /// 1:N Fax_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Fax_AsyncOperations")]
        public System.Collections.Generic.IEnumerable<AsyncOperation> Fax_AsyncOperations
        {
            get { return this.GetRelatedEntities<AsyncOperation>("Fax_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("Fax_AsyncOperations");
                this.SetRelatedEntities<AsyncOperation>("Fax_AsyncOperations", null, value);
                this.OnPropertyChanged("Fax_AsyncOperations");
            }
        }

        /// <summary>
        /// 1:N Fax_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Fax_BulkDeleteFailures")]
        public System.Collections.Generic.IEnumerable<BulkDeleteFailure> Fax_BulkDeleteFailures
        {
            get { return this.GetRelatedEntities<BulkDeleteFailure>("Fax_BulkDeleteFailures", null); }
            set
            {
                this.OnPropertyChanging("Fax_BulkDeleteFailures");
                this.SetRelatedEntities<BulkDeleteFailure>("Fax_BulkDeleteFailures", null, value);
                this.OnPropertyChanged("Fax_BulkDeleteFailures");
            }
        }

        /// <summary>
        /// 1:N fax_campaignresponse
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("fax_campaignresponse")]
        public System.Collections.Generic.IEnumerable<CampaignResponse> fax_campaignresponse
        {
            get { return this.GetRelatedEntities<CampaignResponse>("fax_campaignresponse", null); }
            set
            {
                this.OnPropertyChanging("fax_campaignresponse");
                this.SetRelatedEntities<CampaignResponse>("fax_campaignresponse", null, value);
                this.OnPropertyChanged("fax_campaignresponse");
            }
        }

        /// <summary>
        /// 1:N fax_connections1
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("fax_connections1")]
        public System.Collections.Generic.IEnumerable<Connection> fax_connections1
        {
            get { return this.GetRelatedEntities<Connection>("fax_connections1", null); }
            set
            {
                this.OnPropertyChanging("fax_connections1");
                this.SetRelatedEntities<Connection>("fax_connections1", null, value);
                this.OnPropertyChanged("fax_connections1");
            }
        }

        /// <summary>
        /// 1:N fax_connections2
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("fax_connections2")]
        public System.Collections.Generic.IEnumerable<Connection> fax_connections2
        {
            get { return this.GetRelatedEntities<Connection>("fax_connections2", null); }
            set
            {
                this.OnPropertyChanging("fax_connections2");
                this.SetRelatedEntities<Connection>("fax_connections2", null, value);
                this.OnPropertyChanged("fax_connections2");
            }
        }

        /// <summary>
        /// 1:N Fax_DuplicateBaseRecord
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Fax_DuplicateBaseRecord")]
        public System.Collections.Generic.IEnumerable<DuplicateRecord> Fax_DuplicateBaseRecord
        {
            get { return this.GetRelatedEntities<DuplicateRecord>("Fax_DuplicateBaseRecord", null); }
            set
            {
                this.OnPropertyChanging("Fax_DuplicateBaseRecord");
                this.SetRelatedEntities<DuplicateRecord>("Fax_DuplicateBaseRecord", null, value);
                this.OnPropertyChanged("Fax_DuplicateBaseRecord");
            }
        }

        /// <summary>
        /// 1:N Fax_DuplicateMatchingRecord
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Fax_DuplicateMatchingRecord")]
        public System.Collections.Generic.IEnumerable<DuplicateRecord> Fax_DuplicateMatchingRecord
        {
            get { return this.GetRelatedEntities<DuplicateRecord>("Fax_DuplicateMatchingRecord", null); }
            set
            {
                this.OnPropertyChanging("Fax_DuplicateMatchingRecord");
                this.SetRelatedEntities<DuplicateRecord>("Fax_DuplicateMatchingRecord", null, value);
                this.OnPropertyChanged("Fax_DuplicateMatchingRecord");
            }
        }

        /// <summary>
        /// 1:N fax_principalobjectattributeaccess
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("fax_principalobjectattributeaccess")]
        public System.Collections.Generic.IEnumerable<PrincipalObjectAttributeAccess> fax_principalobjectattributeaccess
        {
            get { return this.GetRelatedEntities<PrincipalObjectAttributeAccess>("fax_principalobjectattributeaccess", null); }
            set
            {
                this.OnPropertyChanging("fax_principalobjectattributeaccess");
                this.SetRelatedEntities<PrincipalObjectAttributeAccess>("fax_principalobjectattributeaccess", null, value);
                this.OnPropertyChanged("fax_principalobjectattributeaccess");
            }
        }

        /// <summary>
        /// 1:N Fax_ProcessSessions
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Fax_ProcessSessions")]
        public System.Collections.Generic.IEnumerable<ProcessSession> Fax_ProcessSessions
        {
            get { return this.GetRelatedEntities<ProcessSession>("Fax_ProcessSessions", null); }
            set
            {
                this.OnPropertyChanging("Fax_ProcessSessions");
                this.SetRelatedEntities<ProcessSession>("Fax_ProcessSessions", null, value);
                this.OnPropertyChanged("Fax_ProcessSessions");
            }
        }

        /// <summary>
        /// 1:N Fax_QueueItem
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Fax_QueueItem")]
        public System.Collections.Generic.IEnumerable<QueueItem> Fax_QueueItem
        {
            get { return this.GetRelatedEntities<QueueItem>("Fax_QueueItem", null); }
            set
            {
                this.OnPropertyChanging("Fax_QueueItem");
                this.SetRelatedEntities<QueueItem>("Fax_QueueItem", null, value);
                this.OnPropertyChanged("Fax_QueueItem");
            }
        }

        /// <summary>
        /// 1:N userentityinstancedata_fax
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_fax")]
        public System.Collections.Generic.IEnumerable<UserEntityInstanceData> userentityinstancedata_fax
        {
            get { return this.GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_fax", null); }
            set
            {
                this.OnPropertyChanging("userentityinstancedata_fax");
                this.SetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_fax", null, value);
                this.OnPropertyChanged("userentityinstancedata_fax");
            }
        }

        /// <summary>
        /// N:1 Account_Faxes
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Account_Faxes")]
        public Account Account_Faxes
        {
            get { return this.GetRelatedEntity<Account>("Account_Faxes", null); }
            set
            {
                this.OnPropertyChanging("Account_Faxes");
                this.SetRelatedEntity<Account>("Account_Faxes", null, value);
                this.OnPropertyChanged("Account_Faxes");
            }
        }

        /// <summary>
        /// N:1 activity_pointer_fax
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("activityid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("activity_pointer_fax")]
        public ActivityPointer activity_pointer_fax
        {
            get { return this.GetRelatedEntity<ActivityPointer>("activity_pointer_fax", null); }
            set
            {
                this.OnPropertyChanging("activity_pointer_fax");
                this.SetRelatedEntity<ActivityPointer>("activity_pointer_fax", null, value);
                this.OnPropertyChanged("activity_pointer_fax");
            }
        }

        /// <summary>
        /// N:1 BulkOperation_Faxes
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("BulkOperation_Faxes")]
        public BulkOperation BulkOperation_Faxes
        {
            get { return this.GetRelatedEntity<BulkOperation>("BulkOperation_Faxes", null); }
            set
            {
                this.OnPropertyChanging("BulkOperation_Faxes");
                this.SetRelatedEntity<BulkOperation>("BulkOperation_Faxes", null, value);
                this.OnPropertyChanged("BulkOperation_Faxes");
            }
        }

        /// <summary>
        /// N:1 business_unit_fax_activities
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_fax_activities")]
        public BusinessUnit business_unit_fax_activities
        {
            get { return this.GetRelatedEntity<BusinessUnit>("business_unit_fax_activities", null); }
        }

        /// <summary>
        /// N:1 Campaign_Faxes
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Campaign_Faxes")]
        public Campaign Campaign_Faxes
        {
            get { return this.GetRelatedEntity<Campaign>("Campaign_Faxes", null); }
            set
            {
                this.OnPropertyChanging("Campaign_Faxes");
                this.SetRelatedEntity<Campaign>("Campaign_Faxes", null, value);
                this.OnPropertyChanged("Campaign_Faxes");
            }
        }

        /// <summary>
        /// N:1 CampaignActivity_Faxes
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("CampaignActivity_Faxes")]
        public CampaignActivity CampaignActivity_Faxes
        {
            get { return this.GetRelatedEntity<CampaignActivity>("CampaignActivity_Faxes", null); }
            set
            {
                this.OnPropertyChanging("CampaignActivity_Faxes");
                this.SetRelatedEntity<CampaignActivity>("CampaignActivity_Faxes", null, value);
                this.OnPropertyChanged("CampaignActivity_Faxes");
            }
        }

        /// <summary>
        /// N:1 Contact_Faxes
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Contact_Faxes")]
        public Contact Contact_Faxes
        {
            get { return this.GetRelatedEntity<Contact>("Contact_Faxes", null); }
            set
            {
                this.OnPropertyChanging("Contact_Faxes");
                this.SetRelatedEntity<Contact>("Contact_Faxes", null, value);
                this.OnPropertyChanged("Contact_Faxes");
            }
        }

        /// <summary>
        /// N:1 Contract_Faxes
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Contract_Faxes")]
        public Contract Contract_Faxes
        {
            get { return this.GetRelatedEntity<Contract>("Contract_Faxes", null); }
            set
            {
                this.OnPropertyChanging("Contract_Faxes");
                this.SetRelatedEntity<Contract>("Contract_Faxes", null, value);
                this.OnPropertyChanged("Contract_Faxes");
            }
        }

        /// <summary>
        /// N:1 entitlement_Faxes
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("entitlement_Faxes")]
        public Entitlement entitlement_Faxes
        {
            get { return this.GetRelatedEntity<Entitlement>("entitlement_Faxes", null); }
            set
            {
                this.OnPropertyChanging("entitlement_Faxes");
                this.SetRelatedEntity<Entitlement>("entitlement_Faxes", null, value);
                this.OnPropertyChanged("entitlement_Faxes");
            }
        }

        /// <summary>
        /// N:1 entitlementtemplate_Faxes
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("entitlementtemplate_Faxes")]
        public EntitlementTemplate entitlementtemplate_Faxes
        {
            get { return this.GetRelatedEntity<EntitlementTemplate>("entitlementtemplate_Faxes", null); }
            set
            {
                this.OnPropertyChanging("entitlementtemplate_Faxes");
                this.SetRelatedEntity<EntitlementTemplate>("entitlementtemplate_Faxes", null, value);
                this.OnPropertyChanged("entitlementtemplate_Faxes");
            }
        }

        /// <summary>
        /// N:1 Incident_Faxes
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Incident_Faxes")]
        public Incident Incident_Faxes
        {
            get { return this.GetRelatedEntity<Incident>("Incident_Faxes", null); }
            set
            {
                this.OnPropertyChanging("Incident_Faxes");
                this.SetRelatedEntity<Incident>("Incident_Faxes", null, value);
                this.OnPropertyChanged("Incident_Faxes");
            }
        }

        /// <summary>
        /// N:1 Invoice_Faxes
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Invoice_Faxes")]
        public Invoice Invoice_Faxes
        {
            get { return this.GetRelatedEntity<Invoice>("Invoice_Faxes", null); }
            set
            {
                this.OnPropertyChanging("Invoice_Faxes");
                this.SetRelatedEntity<Invoice>("Invoice_Faxes", null, value);
                this.OnPropertyChanged("Invoice_Faxes");
            }
        }

        /// <summary>
        /// N:1 Lead_Faxes
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Lead_Faxes")]
        public Lead Lead_Faxes
        {
            get { return this.GetRelatedEntity<Lead>("Lead_Faxes", null); }
            set
            {
                this.OnPropertyChanging("Lead_Faxes");
                this.SetRelatedEntity<Lead>("Lead_Faxes", null, value);
                this.OnPropertyChanged("Lead_Faxes");
            }
        }

        /// <summary>
        /// N:1 lk_fax_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_fax_createdby")]
        public SystemUser lk_fax_createdby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_fax_createdby", null); }
        }

        /// <summary>
        /// N:1 lk_fax_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_fax_createdonbehalfby")]
        public SystemUser lk_fax_createdonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_fax_createdonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_fax_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_fax_modifiedby")]
        public SystemUser lk_fax_modifiedby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_fax_modifiedby", null); }
        }

        /// <summary>
        /// N:1 lk_fax_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_fax_modifiedonbehalfby")]
        public SystemUser lk_fax_modifiedonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_fax_modifiedonbehalfby", null); }
        }

        /// <summary>
        /// N:1 msdyn_postalbum_Faxes
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_postalbum_Faxes")]
        public msdyn_PostAlbum msdyn_postalbum_Faxes
        {
            get { return this.GetRelatedEntity<msdyn_PostAlbum>("msdyn_postalbum_Faxes", null); }
            set
            {
                this.OnPropertyChanging("msdyn_postalbum_Faxes");
                this.SetRelatedEntity<msdyn_PostAlbum>("msdyn_postalbum_Faxes", null, value);
                this.OnPropertyChanged("msdyn_postalbum_Faxes");
            }
        }

        /// <summary>
        /// N:1 Opportunity_Faxes
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Opportunity_Faxes")]
        public Opportunity Opportunity_Faxes
        {
            get { return this.GetRelatedEntity<Opportunity>("Opportunity_Faxes", null); }
            set
            {
                this.OnPropertyChanging("Opportunity_Faxes");
                this.SetRelatedEntity<Opportunity>("Opportunity_Faxes", null, value);
                this.OnPropertyChanged("Opportunity_Faxes");
            }
        }

        /// <summary>
        /// N:1 processstage_faxes
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("stageid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("processstage_faxes")]
        public ProcessStage processstage_faxes
        {
            get { return this.GetRelatedEntity<ProcessStage>("processstage_faxes", null); }
            set
            {
                this.OnPropertyChanging("processstage_faxes");
                this.SetRelatedEntity<ProcessStage>("processstage_faxes", null, value);
                this.OnPropertyChanged("processstage_faxes");
            }
        }

        /// <summary>
        /// N:1 Quote_Faxes
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Quote_Faxes")]
        public Quote Quote_Faxes
        {
            get { return this.GetRelatedEntity<Quote>("Quote_Faxes", null); }
            set
            {
                this.OnPropertyChanging("Quote_Faxes");
                this.SetRelatedEntity<Quote>("Quote_Faxes", null, value);
                this.OnPropertyChanged("Quote_Faxes");
            }
        }

        /// <summary>
        /// N:1 SalesOrder_Faxes
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SalesOrder_Faxes")]
        public SalesOrder SalesOrder_Faxes
        {
            get { return this.GetRelatedEntity<SalesOrder>("SalesOrder_Faxes", null); }
            set
            {
                this.OnPropertyChanging("SalesOrder_Faxes");
                this.SetRelatedEntity<SalesOrder>("SalesOrder_Faxes", null, value);
                this.OnPropertyChanged("SalesOrder_Faxes");
            }
        }

        /// <summary>
        /// N:1 service_faxes
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("serviceid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("service_faxes")]
        public Service service_faxes
        {
            get { return this.GetRelatedEntity<Service>("service_faxes", null); }
            set
            {
                this.OnPropertyChanging("service_faxes");
                this.SetRelatedEntity<Service>("service_faxes", null, value);
                this.OnPropertyChanged("service_faxes");
            }
        }

        /// <summary>
        /// N:1 team_fax
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_fax")]
        public Team team_fax
        {
            get { return this.GetRelatedEntity<Team>("team_fax", null); }
        }

        /// <summary>
        /// N:1 TransactionCurrency_Fax
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("TransactionCurrency_Fax")]
        public TransactionCurrency TransactionCurrency_Fax
        {
            get { return this.GetRelatedEntity<TransactionCurrency>("TransactionCurrency_Fax", null); }
            set
            {
                this.OnPropertyChanging("TransactionCurrency_Fax");
                this.SetRelatedEntity<TransactionCurrency>("TransactionCurrency_Fax", null, value);
                this.OnPropertyChanged("TransactionCurrency_Fax");
            }
        }

        /// <summary>
        /// N:1 user_fax
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_fax")]
        public SystemUser user_fax
        {
            get { return this.GetRelatedEntity<SystemUser>("user_fax", null); }
        }
    }
}