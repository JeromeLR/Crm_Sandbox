namespace __4_DAL_CRM
{
    /// <summary>
    /// Activity that is created automatically when an opportunity is closed, containing information such as the description of the closing and actual revenue.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("opportunityclose")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class OpportunityClose : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public OpportunityClose() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "opportunityclose";

        public const int EntityTypeCode = 4208;

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
        /// Unique identifier of the opportunity close activity.
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
        /// Actual duration of the opportunity close activity in minutes.
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
        /// Actual end time of the opportunity close activity.
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
        /// Actual revenue generated for the opportunity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("actualrevenue")]
        public Microsoft.Xrm.Sdk.Money ActualRevenue
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("actualrevenue"); }
            set
            {
                this.OnPropertyChanging("ActualRevenue");
                this.SetAttributeValue("actualrevenue", value);
                this.OnPropertyChanged("ActualRevenue");
            }
        }

        /// <summary>
        /// Shows the Actual Revenue field converted to the system's default base currency for reporting purposes. The calculation uses the exchange rate specified in the Currencies area.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("actualrevenue_base")]
        public Microsoft.Xrm.Sdk.Money ActualRevenue_Base
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("actualrevenue_base"); }
        }

        /// <summary>
        /// Actual start time of the opportunity close activity.
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
        /// Category of the opportunity close activity.
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
        /// Unique identifier of the competitor with which the opportunity close activity is associated.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("competitorid")]
        public Microsoft.Xrm.Sdk.EntityReference CompetitorId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("competitorid"); }
            set
            {
                this.OnPropertyChanging("CompetitorId");
                this.SetAttributeValue("competitorid", value);
                this.OnPropertyChanged("CompetitorId");
            }
        }

        /// <summary>
        /// Unique identifier of the user who created the opportunity close activity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby"); }
        }

        /// <summary>
        /// Date and time when the opportunity close activity was created.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
        public System.Nullable<System.DateTime> CreatedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who created the opportunityclose.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        /// Activity that is created automatically when an opportunity is closed, containing information such as the description of the closing and actual revenue.
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
        /// Information about whether the opportunity close activity was billed as part of resolving a case.
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
        /// Information that specifies if the opportunity close activity was created from a workflow rule.
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
        /// Unique identifier of the user who last modified the opportunity close activity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby"); }
        }

        /// <summary>
        /// Date and time when the opportunity close activity was last modified.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
        public System.Nullable<System.DateTime> ModifiedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who last modified the opportunityclose.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        /// Unique identifier of the opportunity closed.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("opportunityid")]
        public Microsoft.Xrm.Sdk.EntityReference OpportunityId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("opportunityid"); }
            set
            {
                this.OnPropertyChanging("OpportunityId");
                this.SetAttributeValue("opportunityid", value);
                this.OnPropertyChanged("OpportunityId");
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
        /// Unique identifier of the user or team who owns the opportunity close activity.
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
        /// Unique identifier of the business unit that owns the opportunity close activity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
        public Microsoft.Xrm.Sdk.EntityReference OwningBusinessUnit
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningbusinessunit"); }
        }

        /// <summary>
        /// Unique identifier of the team who owns the opportunity close activity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
        public Microsoft.Xrm.Sdk.EntityReference OwningTeam
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningteam"); }
        }

        /// <summary>
        /// Unique identifier of the user who owns the opportunity close activity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
        public Microsoft.Xrm.Sdk.EntityReference OwningUser
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owninguser"); }
        }

        /// <summary>
        /// Scheduled duration of the opportunity close activity, specified in minutes.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("scheduleddurationminutes")]
        public System.Nullable<int> ScheduledDurationMinutes
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("scheduleddurationminutes"); }
        }

        /// <summary>
        /// Scheduled end time of the opportunity close activity.
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
        /// Scheduled start time of the opportunity close activity.
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
        /// Unique identifier of the service with which the opportunity close activity is associated.
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
        /// Shows whether the opportunity close activity is open, completed, or canceled. By default, opportunity close activities are completed unless the opportunity is reactivated, which updates them to canceled.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
        public System.Nullable<OpportunityCloseState> StateCode
        {
            get
            {
                Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
                if ((optionSet != null))
                {
                    return ((OpportunityCloseState) (System.Enum.ToObject(typeof(OpportunityCloseState), optionSet.Value)));
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// Reason for the status of the opportunity close activity.
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
        /// Subcategory of the opportunity close activity.
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
        /// Subject associated with the opportunity close activity.
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
        /// Version number of the opportunity close activity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
        public System.Nullable<long> VersionNumber
        {
            get { return this.GetAttributeValue<System.Nullable<long>>("versionnumber"); }
        }

        /// <summary>
        /// 1:N opportunityclose_activity_parties
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("opportunityclose_activity_parties")]
        public System.Collections.Generic.IEnumerable<ActivityParty> opportunityclose_activity_parties
        {
            get { return this.GetRelatedEntities<ActivityParty>("opportunityclose_activity_parties", null); }
            set
            {
                this.OnPropertyChanging("opportunityclose_activity_parties");
                this.SetRelatedEntities<ActivityParty>("opportunityclose_activity_parties", null, value);
                this.OnPropertyChanged("opportunityclose_activity_parties");
            }
        }

        /// <summary>
        /// 1:N OpportunityClose_Annotation
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("OpportunityClose_Annotation")]
        public System.Collections.Generic.IEnumerable<Annotation> OpportunityClose_Annotation
        {
            get { return this.GetRelatedEntities<Annotation>("OpportunityClose_Annotation", null); }
            set
            {
                this.OnPropertyChanging("OpportunityClose_Annotation");
                this.SetRelatedEntities<Annotation>("OpportunityClose_Annotation", null, value);
                this.OnPropertyChanged("OpportunityClose_Annotation");
            }
        }

        /// <summary>
        /// 1:N OpportunityClose_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("OpportunityClose_AsyncOperations")]
        public System.Collections.Generic.IEnumerable<AsyncOperation> OpportunityClose_AsyncOperations
        {
            get { return this.GetRelatedEntities<AsyncOperation>("OpportunityClose_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("OpportunityClose_AsyncOperations");
                this.SetRelatedEntities<AsyncOperation>("OpportunityClose_AsyncOperations", null, value);
                this.OnPropertyChanged("OpportunityClose_AsyncOperations");
            }
        }

        /// <summary>
        /// 1:N OpportunityClose_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("OpportunityClose_BulkDeleteFailures")]
        public System.Collections.Generic.IEnumerable<BulkDeleteFailure> OpportunityClose_BulkDeleteFailures
        {
            get { return this.GetRelatedEntities<BulkDeleteFailure>("OpportunityClose_BulkDeleteFailures", null); }
            set
            {
                this.OnPropertyChanging("OpportunityClose_BulkDeleteFailures");
                this.SetRelatedEntities<BulkDeleteFailure>("OpportunityClose_BulkDeleteFailures", null, value);
                this.OnPropertyChanged("OpportunityClose_BulkDeleteFailures");
            }
        }

        /// <summary>
        /// 1:N userentityinstancedata_opportunityclose
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_opportunityclose")]
        public System.Collections.Generic.IEnumerable<UserEntityInstanceData> userentityinstancedata_opportunityclose
        {
            get { return this.GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_opportunityclose", null); }
            set
            {
                this.OnPropertyChanging("userentityinstancedata_opportunityclose");
                this.SetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_opportunityclose", null, value);
                this.OnPropertyChanged("userentityinstancedata_opportunityclose");
            }
        }

        /// <summary>
        /// N:1 activity_pointer_opportunity_close
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("activityid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("activity_pointer_opportunity_close")]
        public ActivityPointer activity_pointer_opportunity_close
        {
            get { return this.GetRelatedEntity<ActivityPointer>("activity_pointer_opportunity_close", null); }
            set
            {
                this.OnPropertyChanging("activity_pointer_opportunity_close");
                this.SetRelatedEntity<ActivityPointer>("activity_pointer_opportunity_close", null, value);
                this.OnPropertyChanged("activity_pointer_opportunity_close");
            }
        }

        /// <summary>
        /// N:1 business_unit_opportunity_close_activities
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_opportunity_close_activities")]
        public BusinessUnit business_unit_opportunity_close_activities
        {
            get { return this.GetRelatedEntity<BusinessUnit>("business_unit_opportunity_close_activities", null); }
        }

        /// <summary>
        /// N:1 competitor_opportunity_activities
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("competitorid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("competitor_opportunity_activities")]
        public Competitor competitor_opportunity_activities
        {
            get { return this.GetRelatedEntity<Competitor>("competitor_opportunity_activities", null); }
            set
            {
                this.OnPropertyChanging("competitor_opportunity_activities");
                this.SetRelatedEntity<Competitor>("competitor_opportunity_activities", null, value);
                this.OnPropertyChanged("competitor_opportunity_activities");
            }
        }

        /// <summary>
        /// N:1 lk_opportunityclose_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_opportunityclose_createdby")]
        public SystemUser lk_opportunityclose_createdby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_opportunityclose_createdby", null); }
        }

        /// <summary>
        /// N:1 lk_opportunityclose_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_opportunityclose_createdonbehalfby")]
        public SystemUser lk_opportunityclose_createdonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_opportunityclose_createdonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_opportunityclose_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_opportunityclose_modifiedby")]
        public SystemUser lk_opportunityclose_modifiedby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_opportunityclose_modifiedby", null); }
        }

        /// <summary>
        /// N:1 lk_opportunityclose_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_opportunityclose_modifiedonbehalfby")]
        public SystemUser lk_opportunityclose_modifiedonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_opportunityclose_modifiedonbehalfby", null); }
        }

        /// <summary>
        /// N:1 Opportunity_OpportunityClose
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("opportunityid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Opportunity_OpportunityClose")]
        public Opportunity Opportunity_OpportunityClose
        {
            get { return this.GetRelatedEntity<Opportunity>("Opportunity_OpportunityClose", null); }
            set
            {
                this.OnPropertyChanging("Opportunity_OpportunityClose");
                this.SetRelatedEntity<Opportunity>("Opportunity_OpportunityClose", null, value);
                this.OnPropertyChanged("Opportunity_OpportunityClose");
            }
        }

        /// <summary>
        /// N:1 service_opportunityclose
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("serviceid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("service_opportunityclose")]
        public Service service_opportunityclose
        {
            get { return this.GetRelatedEntity<Service>("service_opportunityclose", null); }
            set
            {
                this.OnPropertyChanging("service_opportunityclose");
                this.SetRelatedEntity<Service>("service_opportunityclose", null, value);
                this.OnPropertyChanged("service_opportunityclose");
            }
        }

        /// <summary>
        /// N:1 team_opportunityclose
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_opportunityclose")]
        public Team team_opportunityclose
        {
            get { return this.GetRelatedEntity<Team>("team_opportunityclose", null); }
        }

        /// <summary>
        /// N:1 transactioncurrency_opportunityclose
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("transactioncurrency_opportunityclose")]
        public TransactionCurrency transactioncurrency_opportunityclose
        {
            get { return this.GetRelatedEntity<TransactionCurrency>("transactioncurrency_opportunityclose", null); }
            set
            {
                this.OnPropertyChanging("transactioncurrency_opportunityclose");
                this.SetRelatedEntity<TransactionCurrency>("transactioncurrency_opportunityclose", null, value);
                this.OnPropertyChanged("transactioncurrency_opportunityclose");
            }
        }

        /// <summary>
        /// N:1 user_opportunityclose
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_opportunityclose")]
        public SystemUser user_opportunityclose
        {
            get { return this.GetRelatedEntity<SystemUser>("user_opportunityclose", null); }
        }
    }
}