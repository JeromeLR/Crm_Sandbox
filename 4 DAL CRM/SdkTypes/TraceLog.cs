namespace __4_DAL_CRM
{
    /// <summary>
    /// A trace log.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("tracelog")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class TraceLog : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public TraceLog() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "tracelog";

        public const int EntityTypeCode = 8050;

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
        /// Indicates if this trace log can be deleted.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("canbedeleted")]
        public System.Nullable<bool> CanBeDeleted
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("canbedeleted"); }
            set
            {
                this.OnPropertyChanging("CanBeDeleted");
                this.SetAttributeValue("canbedeleted", value);
                this.OnPropertyChanged("CanBeDeleted");
            }
        }

        /// <summary>
        /// Indicates the collation level
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("collationlevel")]
        public System.Nullable<int> CollationLevel
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("collationlevel"); }
            set
            {
                this.OnPropertyChanging("CollationLevel");
                this.SetAttributeValue("collationlevel", value);
                this.OnPropertyChanged("CollationLevel");
            }
        }

        /// <summary>
        /// Unique identifier of the user who created the trace.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby"); }
        }

        /// <summary>
        /// Date and time when the trace was created.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
        public System.Nullable<System.DateTime> CreatedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who created the trace.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        /// Tells if this traceLog is created uniquely(only one) for the associated entity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isunique")]
        public System.Nullable<bool> IsUnique
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("isunique"); }
            set
            {
                this.OnPropertyChanging("IsUnique");
                this.SetAttributeValue("isunique", value);
                this.OnPropertyChanged("IsUnique");
            }
        }

        /// <summary>
        /// Information about the trace level.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("level")]
        public Microsoft.Xrm.Sdk.OptionSetValue Level
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("level"); }
            set
            {
                this.OnPropertyChanging("Level");
                this.SetAttributeValue("level", value);
                this.OnPropertyChanged("Level");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("machinename")]
        public string MachineName
        {
            get { return this.GetAttributeValue<string>("machinename"); }
            set
            {
                this.OnPropertyChanging("MachineName");
                this.SetAttributeValue("machinename", value);
                this.OnPropertyChanged("MachineName");
            }
        }

        /// <summary>
        /// Unique identifier of the user who modified the trace.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby"); }
        }

        /// <summary>
        /// Date and time when the trace was modified.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
        public System.Nullable<System.DateTime> ModifiedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who modified the trace.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        /// Unique identifier of the organization associated with the trace.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
        public Microsoft.Xrm.Sdk.EntityReference OrganizationId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("organizationid"); }
        }

        /// <summary>
        /// Indicates the parent ID of the trace log.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("parenttracelogid")]
        public Microsoft.Xrm.Sdk.EntityReference ParentTraceLogId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("parenttracelogid"); }
            set
            {
                this.OnPropertyChanging("ParentTraceLogId");
                this.SetAttributeValue("parenttracelogid", value);
                this.OnPropertyChanged("ParentTraceLogId");
            }
        }

        /// <summary>
        /// Unique identifier of the object the trace is regarding.
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
        /// Unique identifier of the user or team who owns the regarding object.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectownerid")]
        public Microsoft.Xrm.Sdk.EntityReference RegardingObjectOwnerId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("regardingobjectownerid"); }
        }

        /// <summary>
        /// Unique identifier of the business unit that owns the regarding object.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectowningbusinessunit")]
        public Microsoft.Xrm.Sdk.EntityReference RegardingObjectOwningBusinessUnit
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("regardingobjectowningbusinessunit"); }
        }

        /// <summary>
        /// Text of the trace.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("text")]
        public string Text
        {
            get { return this.GetAttributeValue<string>("text"); }
            set
            {
                this.OnPropertyChanging("Text");
                this.SetAttributeValue("text", value);
                this.OnPropertyChanged("Text");
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
        /// XML representation of the trace actions.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("traceactionxml")]
        public string TraceActionXml
        {
            get { return this.GetAttributeValue<string>("traceactionxml"); }
            set
            {
                this.OnPropertyChanging("TraceActionXml");
                this.SetAttributeValue("traceactionxml", value);
                this.OnPropertyChanged("TraceActionXml");
            }
        }

        /// <summary>
        /// Trace code for the trace.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("tracecode")]
        public System.Nullable<int> TraceCode
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("tracecode"); }
            set
            {
                this.OnPropertyChanging("TraceCode");
                this.SetAttributeValue("tracecode", value);
                this.OnPropertyChanged("TraceCode");
            }
        }

        /// <summary>
        /// XML representation of the trace details.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("tracedetailxml")]
        public string TraceDetailXml
        {
            get { return this.GetAttributeValue<string>("tracedetailxml"); }
            set
            {
                this.OnPropertyChanging("TraceDetailXml");
                this.SetAttributeValue("tracedetailxml", value);
                this.OnPropertyChanged("TraceDetailXml");
            }
        }

        /// <summary>
        /// Unique identifier of the trace.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("tracelogid")]
        public System.Nullable<System.Guid> TraceLogId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("tracelogid"); }
            set
            {
                this.OnPropertyChanging("TraceLogId");
                this.SetAttributeValue("tracelogid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("TraceLogId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("tracelogid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.TraceLogId = value; }
        }

        /// <summary>
        /// Stores the hash of the entity object associated with this tracelog. Hash is computed using the object type code and its id.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("traceparameterhash")]
        public System.Nullable<int> TraceParameterHash
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("traceparameterhash"); }
        }

        /// <summary>
        /// XML representation of the trace parameters.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("traceparameterxml")]
        public string TraceParameterXml
        {
            get { return this.GetAttributeValue<string>("traceparameterxml"); }
            set
            {
                this.OnPropertyChanging("TraceParameterXml");
                this.SetAttributeValue("traceparameterxml", value);
                this.OnPropertyChanged("TraceParameterXml");
            }
        }

        /// <summary>
        /// Time zone code that was in use when the trace was created.
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
        /// 1:N tracelog_parent_tracelog
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("tracelog_parent_tracelog", Microsoft.Xrm.Sdk.EntityRole.Referenced)]
        public System.Collections.Generic.IEnumerable<TraceLog> Referencedtracelog_parent_tracelog
        {
            get { return this.GetRelatedEntities<TraceLog>("tracelog_parent_tracelog", Microsoft.Xrm.Sdk.EntityRole.Referenced); }
            set
            {
                this.OnPropertyChanging("Referencedtracelog_parent_tracelog");
                this.SetRelatedEntities<TraceLog>("tracelog_parent_tracelog", Microsoft.Xrm.Sdk.EntityRole.Referenced, value);
                this.OnPropertyChanged("Referencedtracelog_parent_tracelog");
            }
        }

        /// <summary>
        /// N:1 lk_tracelog_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_tracelog_createdby")]
        public SystemUser lk_tracelog_createdby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_tracelog_createdby", null); }
        }

        /// <summary>
        /// N:1 lk_tracelog_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_tracelog_createdonbehalfby")]
        public SystemUser lk_tracelog_createdonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_tracelog_createdonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_tracelog_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_tracelog_modifiedby")]
        public SystemUser lk_tracelog_modifiedby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_tracelog_modifiedby", null); }
        }

        /// <summary>
        /// N:1 lk_tracelog_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_tracelog_modifiedonbehalfby")]
        public SystemUser lk_tracelog_modifiedonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_tracelog_modifiedonbehalfby", null); }
        }

        /// <summary>
        /// N:1 organization_tracelog
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_tracelog")]
        public Organization organization_tracelog
        {
            get { return this.GetRelatedEntity<Organization>("organization_tracelog", null); }
        }

        /// <summary>
        /// N:1 tracelog_EmailServerProfile
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("tracelog_EmailServerProfile")]
        public EmailServerProfile tracelog_EmailServerProfile
        {
            get { return this.GetRelatedEntity<EmailServerProfile>("tracelog_EmailServerProfile", null); }
            set
            {
                this.OnPropertyChanging("tracelog_EmailServerProfile");
                this.SetRelatedEntity<EmailServerProfile>("tracelog_EmailServerProfile", null, value);
                this.OnPropertyChanged("tracelog_EmailServerProfile");
            }
        }

        /// <summary>
        /// N:1 tracelog_Mailbox
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("tracelog_Mailbox")]
        public Mailbox tracelog_Mailbox
        {
            get { return this.GetRelatedEntity<Mailbox>("tracelog_Mailbox", null); }
            set
            {
                this.OnPropertyChanging("tracelog_Mailbox");
                this.SetRelatedEntity<Mailbox>("tracelog_Mailbox", null, value);
                this.OnPropertyChanged("tracelog_Mailbox");
            }
        }

        /// <summary>
        /// N:1 tracelog_parent_tracelog
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("parenttracelogid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("tracelog_parent_tracelog", Microsoft.Xrm.Sdk.EntityRole.Referencing)]
        public TraceLog Referencingtracelog_parent_tracelog
        {
            get { return this.GetRelatedEntity<TraceLog>("tracelog_parent_tracelog", Microsoft.Xrm.Sdk.EntityRole.Referencing); }
            set
            {
                this.OnPropertyChanging("Referencingtracelog_parent_tracelog");
                this.SetRelatedEntity<TraceLog>("tracelog_parent_tracelog", Microsoft.Xrm.Sdk.EntityRole.Referencing, value);
                this.OnPropertyChanged("Referencingtracelog_parent_tracelog");
            }
        }
    }
}