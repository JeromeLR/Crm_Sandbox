namespace __4_DAL_CRM
{
    /// <summary>
    /// Activity generated when a quote is closed.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("quoteclose")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class QuoteClose : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public QuoteClose() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "quoteclose";

        public const int EntityTypeCode = 4211;

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
        /// Unique identifier of the quote close activity.
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
        /// Actual duration of the quote close activity in minutes.
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
        /// Actual end time of the quote close activity.
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
        /// Actual start time of the quote close activity.
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
        /// Category of the quote close activity.
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
        /// Unique identifier of the user who created the quote close activity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby"); }
        }

        /// <summary>
        /// Date and time when the quote close activity was created.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
        public System.Nullable<System.DateTime> CreatedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who created the quoteclose.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        /// Activity generated when a quote is closed.
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
        /// Information about whether the quote close activity was billed as part of resolving a case.
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
        /// Information that specifies if the quote close activity was created from a workflow rule.
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
        /// Unique identifier of the user who last modified the quote close activity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby"); }
        }

        /// <summary>
        /// Date and time when the quote close activity was last modified.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
        public System.Nullable<System.DateTime> ModifiedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who last modified the quoteclose.
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
        /// Unique identifier of the user or team who owns the quote close activity.
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
        /// Unique identifier of the business unit that owns the quote close activity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
        public Microsoft.Xrm.Sdk.EntityReference OwningBusinessUnit
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningbusinessunit"); }
        }

        /// <summary>
        /// Unique identifier of the team who owns the quote close activity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
        public Microsoft.Xrm.Sdk.EntityReference OwningTeam
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningteam"); }
        }

        /// <summary>
        /// Unique identifier of the user who owns the quote close activity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
        public Microsoft.Xrm.Sdk.EntityReference OwningUser
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owninguser"); }
        }

        /// <summary>
        /// Unique identifier of the quote with which the quote close activity is associated.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("quoteid")]
        public Microsoft.Xrm.Sdk.EntityReference QuoteId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("quoteid"); }
            set
            {
                this.OnPropertyChanging("QuoteId");
                this.SetAttributeValue("quoteid", value);
                this.OnPropertyChanged("QuoteId");
            }
        }

        /// <summary>
        /// Quote number.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("quotenumber")]
        public string QuoteNumber
        {
            get { return this.GetAttributeValue<string>("quotenumber"); }
            set
            {
                this.OnPropertyChanging("QuoteNumber");
                this.SetAttributeValue("quotenumber", value);
                this.OnPropertyChanged("QuoteNumber");
            }
        }

        /// <summary>
        /// Quote revision number.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("revision")]
        public System.Nullable<int> Revision
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("revision"); }
            set
            {
                this.OnPropertyChanging("Revision");
                this.SetAttributeValue("revision", value);
                this.OnPropertyChanged("Revision");
            }
        }

        /// <summary>
        /// Scheduled duration of the quote close activity, specified in minutes.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("scheduleddurationminutes")]
        public System.Nullable<int> ScheduledDurationMinutes
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("scheduleddurationminutes"); }
        }

        /// <summary>
        /// Scheduled end time of the quote close activity.
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
        /// Scheduled start time of the quote close activity.
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
        /// Unique identifier of the service with which the quote close activity is associated.
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
        /// Shows whether the quote close activity is open, completed, or canceled. By default, quote close activities are completed.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
        public System.Nullable<QuoteCloseState> StateCode
        {
            get
            {
                Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
                if ((optionSet != null))
                {
                    return ((QuoteCloseState) (System.Enum.ToObject(typeof(QuoteCloseState), optionSet.Value)));
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// Reason for the status of the quote close activity.
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
        /// Subcategory of the quote close activity.
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
        /// Subject associated with the quote close activity.
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
        /// Version number of the quote close activity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
        public System.Nullable<long> VersionNumber
        {
            get { return this.GetAttributeValue<System.Nullable<long>>("versionnumber"); }
        }

        /// <summary>
        /// 1:N quoteclose_activity_parties
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("quoteclose_activity_parties")]
        public System.Collections.Generic.IEnumerable<ActivityParty> quoteclose_activity_parties
        {
            get { return this.GetRelatedEntities<ActivityParty>("quoteclose_activity_parties", null); }
            set
            {
                this.OnPropertyChanging("quoteclose_activity_parties");
                this.SetRelatedEntities<ActivityParty>("quoteclose_activity_parties", null, value);
                this.OnPropertyChanged("quoteclose_activity_parties");
            }
        }

        /// <summary>
        /// 1:N QuoteClose_Annotation
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("QuoteClose_Annotation")]
        public System.Collections.Generic.IEnumerable<Annotation> QuoteClose_Annotation
        {
            get { return this.GetRelatedEntities<Annotation>("QuoteClose_Annotation", null); }
            set
            {
                this.OnPropertyChanging("QuoteClose_Annotation");
                this.SetRelatedEntities<Annotation>("QuoteClose_Annotation", null, value);
                this.OnPropertyChanged("QuoteClose_Annotation");
            }
        }

        /// <summary>
        /// 1:N QuoteClose_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("QuoteClose_AsyncOperations")]
        public System.Collections.Generic.IEnumerable<AsyncOperation> QuoteClose_AsyncOperations
        {
            get { return this.GetRelatedEntities<AsyncOperation>("QuoteClose_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("QuoteClose_AsyncOperations");
                this.SetRelatedEntities<AsyncOperation>("QuoteClose_AsyncOperations", null, value);
                this.OnPropertyChanged("QuoteClose_AsyncOperations");
            }
        }

        /// <summary>
        /// 1:N QuoteClose_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("QuoteClose_BulkDeleteFailures")]
        public System.Collections.Generic.IEnumerable<BulkDeleteFailure> QuoteClose_BulkDeleteFailures
        {
            get { return this.GetRelatedEntities<BulkDeleteFailure>("QuoteClose_BulkDeleteFailures", null); }
            set
            {
                this.OnPropertyChanging("QuoteClose_BulkDeleteFailures");
                this.SetRelatedEntities<BulkDeleteFailure>("QuoteClose_BulkDeleteFailures", null, value);
                this.OnPropertyChanged("QuoteClose_BulkDeleteFailures");
            }
        }

        /// <summary>
        /// 1:N userentityinstancedata_quoteclose
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_quoteclose")]
        public System.Collections.Generic.IEnumerable<UserEntityInstanceData> userentityinstancedata_quoteclose
        {
            get { return this.GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_quoteclose", null); }
            set
            {
                this.OnPropertyChanging("userentityinstancedata_quoteclose");
                this.SetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_quoteclose", null, value);
                this.OnPropertyChanged("userentityinstancedata_quoteclose");
            }
        }

        /// <summary>
        /// N:1 activity_pointer_quote_close
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("activityid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("activity_pointer_quote_close")]
        public ActivityPointer activity_pointer_quote_close
        {
            get { return this.GetRelatedEntity<ActivityPointer>("activity_pointer_quote_close", null); }
            set
            {
                this.OnPropertyChanging("activity_pointer_quote_close");
                this.SetRelatedEntity<ActivityPointer>("activity_pointer_quote_close", null, value);
                this.OnPropertyChanged("activity_pointer_quote_close");
            }
        }

        /// <summary>
        /// N:1 business_unit_quote_close_activities
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_quote_close_activities")]
        public BusinessUnit business_unit_quote_close_activities
        {
            get { return this.GetRelatedEntity<BusinessUnit>("business_unit_quote_close_activities", null); }
        }

        /// <summary>
        /// N:1 lk_quoteclose_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_quoteclose_createdby")]
        public SystemUser lk_quoteclose_createdby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_quoteclose_createdby", null); }
        }

        /// <summary>
        /// N:1 lk_quoteclose_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_quoteclose_createdonbehalfby")]
        public SystemUser lk_quoteclose_createdonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_quoteclose_createdonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_quoteclose_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_quoteclose_modifiedby")]
        public SystemUser lk_quoteclose_modifiedby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_quoteclose_modifiedby", null); }
        }

        /// <summary>
        /// N:1 lk_quoteclose_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_quoteclose_modifiedonbehalfby")]
        public SystemUser lk_quoteclose_modifiedonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_quoteclose_modifiedonbehalfby", null); }
        }

        /// <summary>
        /// N:1 Quote_QuoteClose
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("quoteid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Quote_QuoteClose")]
        public Quote Quote_QuoteClose
        {
            get { return this.GetRelatedEntity<Quote>("Quote_QuoteClose", null); }
            set
            {
                this.OnPropertyChanging("Quote_QuoteClose");
                this.SetRelatedEntity<Quote>("Quote_QuoteClose", null, value);
                this.OnPropertyChanged("Quote_QuoteClose");
            }
        }

        /// <summary>
        /// N:1 service_quoteclose
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("serviceid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("service_quoteclose")]
        public Service service_quoteclose
        {
            get { return this.GetRelatedEntity<Service>("service_quoteclose", null); }
            set
            {
                this.OnPropertyChanging("service_quoteclose");
                this.SetRelatedEntity<Service>("service_quoteclose", null, value);
                this.OnPropertyChanged("service_quoteclose");
            }
        }

        /// <summary>
        /// N:1 team_quoteclose
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_quoteclose")]
        public Team team_quoteclose
        {
            get { return this.GetRelatedEntity<Team>("team_quoteclose", null); }
        }

        /// <summary>
        /// N:1 user_quoteclose
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_quoteclose")]
        public SystemUser user_quoteclose
        {
            get { return this.GetRelatedEntity<SystemUser>("user_quoteclose", null); }
        }
    }
}