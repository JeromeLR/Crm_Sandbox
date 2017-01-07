using _4_DAL_CRM;

namespace __4_DAL_CRM
{
    /// <summary>
    /// Information that is generated when a dialog is run. Every time that you run a dialog, a dialog session is created.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("processsession")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class ProcessSession : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public ProcessSession() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "processsession";

        public const int EntityTypeCode = 4710;

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
        /// Name of the activity that is being executed.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("activityname")]
        public string ActivityName
        {
            get { return this.GetAttributeValue<string>("activityname"); }
            set
            {
                this.OnPropertyChanging("ActivityName");
                this.SetAttributeValue("activityname", value);
                this.OnPropertyChanged("ActivityName");
            }
        }

        /// <summary>
        /// Unique identifier of the user who canceled the dialog session.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("canceledby")]
        public Microsoft.Xrm.Sdk.EntityReference CanceledBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("canceledby"); }
        }

        /// <summary>
        /// Date and time when the dialog session was canceled.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("canceledon")]
        public System.Nullable<System.DateTime> CanceledOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("canceledon"); }
            set
            {
                this.OnPropertyChanging("CanceledOn");
                this.SetAttributeValue("canceledon", value);
                this.OnPropertyChanged("CanceledOn");
            }
        }

        /// <summary>
        /// User comments.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("comments")]
        public string Comments
        {
            get { return this.GetAttributeValue<string>("comments"); }
            set
            {
                this.OnPropertyChanging("Comments");
                this.SetAttributeValue("comments", value);
                this.OnPropertyChanged("Comments");
            }
        }

        /// <summary>
        /// Unique identifier of the user who completed the dialog session.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("completedby")]
        public Microsoft.Xrm.Sdk.EntityReference CompletedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("completedby"); }
        }

        /// <summary>
        /// Date and time when the dialog session was completed.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("completedon")]
        public System.Nullable<System.DateTime> CompletedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("completedon"); }
            set
            {
                this.OnPropertyChanging("CompletedOn");
                this.SetAttributeValue("completedon", value);
                this.OnPropertyChanged("CompletedOn");
            }
        }

        /// <summary>
        /// Unique identifier of the user who started the dialog session.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby"); }
        }

        /// <summary>
        /// Date and time when the dialog session was created.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
        public System.Nullable<System.DateTime> CreatedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who created the dialog session.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        /// Error code related to the dialog session.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("errorcode")]
        public System.Nullable<int> ErrorCode
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("errorcode"); }
            set
            {
                this.OnPropertyChanging("ErrorCode");
                this.SetAttributeValue("errorcode", value);
                this.OnPropertyChanged("ErrorCode");
            }
        }

        /// <summary>
        /// Unique identifier of the user who ran the dialog process.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("executedby")]
        public Microsoft.Xrm.Sdk.EntityReference ExecutedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("executedby"); }
            set
            {
                this.OnPropertyChanging("ExecutedBy");
                this.SetAttributeValue("executedby", value);
                this.OnPropertyChanged("ExecutedBy");
            }
        }

        /// <summary>
        /// Date and time when the dialog process was run.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("executedon")]
        public System.Nullable<System.DateTime> ExecutedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("executedon"); }
        }

        /// <summary>
        /// Input arguments for the child dialog process.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("inputarguments")]
        public string InputArguments
        {
            get { return this.GetAttributeValue<string>("inputarguments"); }
            set
            {
                this.OnPropertyChanging("InputArguments");
                this.SetAttributeValue("inputarguments", value);
                this.OnPropertyChanged("InputArguments");
            }
        }

        /// <summary>
        /// Unique identifier of the user who last modified the dialog session.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby"); }
        }

        /// <summary>
        /// Date and time when the dialog session was last modified.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
        public System.Nullable<System.DateTime> ModifiedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who modified the dialog session.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        /// Name of the dialog session.
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
        /// Unique identifier of the succeeding linked dialog session.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("nextlinkedsessionid")]
        public Microsoft.Xrm.Sdk.EntityReference NextLinkedSessionId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("nextlinkedsessionid"); }
            set
            {
                this.OnPropertyChanging("NextLinkedSessionId");
                this.SetAttributeValue("nextlinkedsessionid", value);
                this.OnPropertyChanged("NextLinkedSessionId");
            }
        }

        /// <summary>
        /// Unique identifier of the originating dialog session.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("originatingsessionid")]
        public Microsoft.Xrm.Sdk.EntityReference OriginatingSessionId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("originatingsessionid"); }
            set
            {
                this.OnPropertyChanging("OriginatingSessionId");
                this.SetAttributeValue("originatingsessionid", value);
                this.OnPropertyChanged("OriginatingSessionId");
            }
        }

        /// <summary>
        /// Unique identifier of the user or team who owns the dialog session.
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
        /// Unique identifier of the business unit that owns the dialog session.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
        public Microsoft.Xrm.Sdk.EntityReference OwningBusinessUnit
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningbusinessunit"); }
        }

        /// <summary>
        /// Unique identifier of the team who owns the dialog session.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
        public Microsoft.Xrm.Sdk.EntityReference OwningTeam
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningteam"); }
        }

        /// <summary>
        /// Unique identifier of the user who owns the dialog session.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
        public Microsoft.Xrm.Sdk.EntityReference OwningUser
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owninguser"); }
        }

        /// <summary>
        /// Unique identifier of the preceding linked dialog session.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("previouslinkedsessionid")]
        public Microsoft.Xrm.Sdk.EntityReference PreviousLinkedSessionId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("previouslinkedsessionid"); }
            set
            {
                this.OnPropertyChanging("PreviousLinkedSessionId");
                this.SetAttributeValue("previouslinkedsessionid", value);
                this.OnPropertyChanged("PreviousLinkedSessionId");
            }
        }

        /// <summary>
        /// Select the process activation record that is related to the dialog session.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("processid")]
        public Microsoft.Xrm.Sdk.EntityReference ProcessId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("processid"); }
            set
            {
                this.OnPropertyChanging("ProcessId");
                this.SetAttributeValue("processid", value);
                this.OnPropertyChanged("ProcessId");
            }
        }

        /// <summary>
        /// Unique identifier of the dialog session.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("processsessionid")]
        public System.Nullable<System.Guid> ProcessSessionId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("processsessionid"); }
            set
            {
                this.OnPropertyChanging("ProcessSessionId");
                this.SetAttributeValue("processsessionid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("ProcessSessionId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("processsessionid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.ProcessSessionId = value; }
        }

        /// <summary>
        /// Name of the dialog stage.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("processstagename")]
        public string ProcessStageName
        {
            get { return this.GetAttributeValue<string>("processstagename"); }
            set
            {
                this.OnPropertyChanging("ProcessStageName");
                this.SetAttributeValue("processstagename", value);
                this.OnPropertyChanged("ProcessStageName");
            }
        }

        /// <summary>
        /// State of the dialog process.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("processstate")]
        public string ProcessState
        {
            get { return this.GetAttributeValue<string>("processstate"); }
            set
            {
                this.OnPropertyChanging("ProcessState");
                this.SetAttributeValue("processstate", value);
                this.OnPropertyChanged("ProcessState");
            }
        }

        /// <summary>
        /// Unique identifier of the object with which the dialog session is associated.
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
        /// Unique identifier of the user who started the dialog session.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("startedby")]
        public Microsoft.Xrm.Sdk.EntityReference StartedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("startedby"); }
        }

        /// <summary>
        /// Date and time when the dialog session was started.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("startedon")]
        public System.Nullable<System.DateTime> StartedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("startedon"); }
            set
            {
                this.OnPropertyChanging("StartedOn");
                this.SetAttributeValue("startedon", value);
                this.OnPropertyChanged("StartedOn");
            }
        }

        /// <summary>
        /// Status of the dialog session.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
        public System.Nullable<ProcessSessionState> StateCode
        {
            get
            {
                Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
                if ((optionSet != null))
                {
                    return ((ProcessSessionState) (System.Enum.ToObject(typeof(ProcessSessionState), optionSet.Value)));
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// Reason for the status of the dialog session.
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
        /// Name of the dialog step.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("stepname")]
        public string StepName
        {
            get { return this.GetAttributeValue<string>("stepname"); }
            set
            {
                this.OnPropertyChanging("StepName");
                this.SetAttributeValue("stepname", value);
                this.OnPropertyChanged("StepName");
            }
        }

        /// <summary>
        /// 1:N lk_processsession_nextlinkedsessionid
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_processsession_nextlinkedsessionid", Microsoft.Xrm.Sdk.EntityRole.Referenced)]
        public System.Collections.Generic.IEnumerable<ProcessSession> Referencedlk_processsession_nextlinkedsessionid
        {
            get { return this.GetRelatedEntities<ProcessSession>("lk_processsession_nextlinkedsessionid", Microsoft.Xrm.Sdk.EntityRole.Referenced); }
            set
            {
                this.OnPropertyChanging("Referencedlk_processsession_nextlinkedsessionid");
                this.SetRelatedEntities<ProcessSession>("lk_processsession_nextlinkedsessionid", Microsoft.Xrm.Sdk.EntityRole.Referenced, value);
                this.OnPropertyChanged("Referencedlk_processsession_nextlinkedsessionid");
            }
        }

        /// <summary>
        /// 1:N lk_processsession_originatingsessionid
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_processsession_originatingsessionid", Microsoft.Xrm.Sdk.EntityRole.Referenced)]
        public System.Collections.Generic.IEnumerable<ProcessSession> Referencedlk_processsession_originatingsessionid
        {
            get { return this.GetRelatedEntities<ProcessSession>("lk_processsession_originatingsessionid", Microsoft.Xrm.Sdk.EntityRole.Referenced); }
            set
            {
                this.OnPropertyChanging("Referencedlk_processsession_originatingsessionid");
                this.SetRelatedEntities<ProcessSession>("lk_processsession_originatingsessionid", Microsoft.Xrm.Sdk.EntityRole.Referenced, value);
                this.OnPropertyChanged("Referencedlk_processsession_originatingsessionid");
            }
        }

        /// <summary>
        /// 1:N lk_processsession_previouslinkedsessionid
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_processsession_previouslinkedsessionid", Microsoft.Xrm.Sdk.EntityRole.Referenced)]
        public System.Collections.Generic.IEnumerable<ProcessSession> Referencedlk_processsession_previouslinkedsessionid
        {
            get { return this.GetRelatedEntities<ProcessSession>("lk_processsession_previouslinkedsessionid", Microsoft.Xrm.Sdk.EntityRole.Referenced); }
            set
            {
                this.OnPropertyChanging("Referencedlk_processsession_previouslinkedsessionid");
                this.SetRelatedEntities<ProcessSession>("lk_processsession_previouslinkedsessionid", Microsoft.Xrm.Sdk.EntityRole.Referenced, value);
                this.OnPropertyChanged("Referencedlk_processsession_previouslinkedsessionid");
            }
        }

        /// <summary>
        /// 1:N lk_workflowlog_processsession
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_workflowlog_processsession")]
        public System.Collections.Generic.IEnumerable<WorkflowLog> lk_workflowlog_processsession
        {
            get { return this.GetRelatedEntities<WorkflowLog>("lk_workflowlog_processsession", null); }
            set
            {
                this.OnPropertyChanging("lk_workflowlog_processsession");
                this.SetRelatedEntities<WorkflowLog>("lk_workflowlog_processsession", null, value);
                this.OnPropertyChanged("lk_workflowlog_processsession");
            }
        }

        /// <summary>
        /// 1:N lk_workflowlog_processsession_childworkflow
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_workflowlog_processsession_childworkflow")]
        public System.Collections.Generic.IEnumerable<WorkflowLog> lk_workflowlog_processsession_childworkflow
        {
            get { return this.GetRelatedEntities<WorkflowLog>("lk_workflowlog_processsession_childworkflow", null); }
            set
            {
                this.OnPropertyChanging("lk_workflowlog_processsession_childworkflow");
                this.SetRelatedEntities<WorkflowLog>("lk_workflowlog_processsession_childworkflow", null, value);
                this.OnPropertyChanged("lk_workflowlog_processsession_childworkflow");
            }
        }

        /// <summary>
        /// 1:N processsession_connections1
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("processsession_connections1")]
        public System.Collections.Generic.IEnumerable<Connection> processsession_connections1
        {
            get { return this.GetRelatedEntities<Connection>("processsession_connections1", null); }
            set
            {
                this.OnPropertyChanging("processsession_connections1");
                this.SetRelatedEntities<Connection>("processsession_connections1", null, value);
                this.OnPropertyChanged("processsession_connections1");
            }
        }

        /// <summary>
        /// 1:N processsession_connections2
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("processsession_connections2")]
        public System.Collections.Generic.IEnumerable<Connection> processsession_connections2
        {
            get { return this.GetRelatedEntities<Connection>("processsession_connections2", null); }
            set
            {
                this.OnPropertyChanging("processsession_connections2");
                this.SetRelatedEntities<Connection>("processsession_connections2", null, value);
                this.OnPropertyChanged("processsession_connections2");
            }
        }

        /// <summary>
        /// 1:N processsession_PostFollows
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("processsession_PostFollows")]
        public System.Collections.Generic.IEnumerable<PostFollow> processsession_PostFollows
        {
            get { return this.GetRelatedEntities<PostFollow>("processsession_PostFollows", null); }
            set
            {
                this.OnPropertyChanging("processsession_PostFollows");
                this.SetRelatedEntities<PostFollow>("processsession_PostFollows", null, value);
                this.OnPropertyChanged("processsession_PostFollows");
            }
        }

        /// <summary>
        /// 1:N userentityinstancedata_processsession
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_processsession")]
        public System.Collections.Generic.IEnumerable<UserEntityInstanceData> userentityinstancedata_processsession
        {
            get { return this.GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_processsession", null); }
            set
            {
                this.OnPropertyChanging("userentityinstancedata_processsession");
                this.SetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_processsession", null, value);
                this.OnPropertyChanged("userentityinstancedata_processsession");
            }
        }

        /// <summary>
        /// N:1 Account_ProcessSessions
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Account_ProcessSessions")]
        public Account Account_ProcessSessions
        {
            get { return this.GetRelatedEntity<Account>("Account_ProcessSessions", null); }
            set
            {
                this.OnPropertyChanging("Account_ProcessSessions");
                this.SetRelatedEntity<Account>("Account_ProcessSessions", null, value);
                this.OnPropertyChanged("Account_ProcessSessions");
            }
        }

        /// <summary>
        /// N:1 Annotation_ProcessSessions
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Annotation_ProcessSessions")]
        public Annotation Annotation_ProcessSessions
        {
            get { return this.GetRelatedEntity<Annotation>("Annotation_ProcessSessions", null); }
            set
            {
                this.OnPropertyChanging("Annotation_ProcessSessions");
                this.SetRelatedEntity<Annotation>("Annotation_ProcessSessions", null, value);
                this.OnPropertyChanged("Annotation_ProcessSessions");
            }
        }

        /// <summary>
        /// N:1 Appointment_ProcessSessions
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Appointment_ProcessSessions")]
        public Appointment Appointment_ProcessSessions
        {
            get { return this.GetRelatedEntity<Appointment>("Appointment_ProcessSessions", null); }
            set
            {
                this.OnPropertyChanging("Appointment_ProcessSessions");
                this.SetRelatedEntity<Appointment>("Appointment_ProcessSessions", null, value);
                this.OnPropertyChanged("Appointment_ProcessSessions");
            }
        }

        /// <summary>
        /// N:1 BusinessUnit_ProcessSessions
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("BusinessUnit_ProcessSessions")]
        public BusinessUnit BusinessUnit_ProcessSessions
        {
            get { return this.GetRelatedEntity<BusinessUnit>("BusinessUnit_ProcessSessions", null); }
            set
            {
                this.OnPropertyChanging("BusinessUnit_ProcessSessions");
                this.SetRelatedEntity<BusinessUnit>("BusinessUnit_ProcessSessions", null, value);
                this.OnPropertyChanged("BusinessUnit_ProcessSessions");
            }
        }

        /// <summary>
        /// N:1 BusinessUnitNewsArticle_ProcessSessions
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("BusinessUnitNewsArticle_ProcessSessions")]
        public BusinessUnitNewsArticle BusinessUnitNewsArticle_ProcessSessions
        {
            get { return this.GetRelatedEntity<BusinessUnitNewsArticle>("BusinessUnitNewsArticle_ProcessSessions", null); }
            set
            {
                this.OnPropertyChanging("BusinessUnitNewsArticle_ProcessSessions");
                this.SetRelatedEntity<BusinessUnitNewsArticle>("BusinessUnitNewsArticle_ProcessSessions", null, value);
                this.OnPropertyChanged("BusinessUnitNewsArticle_ProcessSessions");
            }
        }

        /// <summary>
        /// N:1 Campaign_ProcessSessions
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Campaign_ProcessSessions")]
        public Campaign Campaign_ProcessSessions
        {
            get { return this.GetRelatedEntity<Campaign>("Campaign_ProcessSessions", null); }
            set
            {
                this.OnPropertyChanging("Campaign_ProcessSessions");
                this.SetRelatedEntity<Campaign>("Campaign_ProcessSessions", null, value);
                this.OnPropertyChanged("Campaign_ProcessSessions");
            }
        }

        /// <summary>
        /// N:1 CampaignActivity_ProcessSessions
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("CampaignActivity_ProcessSessions")]
        public CampaignActivity CampaignActivity_ProcessSessions
        {
            get { return this.GetRelatedEntity<CampaignActivity>("CampaignActivity_ProcessSessions", null); }
            set
            {
                this.OnPropertyChanging("CampaignActivity_ProcessSessions");
                this.SetRelatedEntity<CampaignActivity>("CampaignActivity_ProcessSessions", null, value);
                this.OnPropertyChanged("CampaignActivity_ProcessSessions");
            }
        }

        /// <summary>
        /// N:1 CampaignResponse_ProcessSessions
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("CampaignResponse_ProcessSessions")]
        public CampaignResponse CampaignResponse_ProcessSessions
        {
            get { return this.GetRelatedEntity<CampaignResponse>("CampaignResponse_ProcessSessions", null); }
            set
            {
                this.OnPropertyChanging("CampaignResponse_ProcessSessions");
                this.SetRelatedEntity<CampaignResponse>("CampaignResponse_ProcessSessions", null, value);
                this.OnPropertyChanged("CampaignResponse_ProcessSessions");
            }
        }

        /// <summary>
        /// N:1 Competitor_ProcessSessions
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Competitor_ProcessSessions")]
        public Competitor Competitor_ProcessSessions
        {
            get { return this.GetRelatedEntity<Competitor>("Competitor_ProcessSessions", null); }
            set
            {
                this.OnPropertyChanging("Competitor_ProcessSessions");
                this.SetRelatedEntity<Competitor>("Competitor_ProcessSessions", null, value);
                this.OnPropertyChanged("Competitor_ProcessSessions");
            }
        }

        /// <summary>
        /// N:1 Connection_ProcessSessions
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Connection_ProcessSessions")]
        public Connection Connection_ProcessSessions
        {
            get { return this.GetRelatedEntity<Connection>("Connection_ProcessSessions", null); }
            set
            {
                this.OnPropertyChanging("Connection_ProcessSessions");
                this.SetRelatedEntity<Connection>("Connection_ProcessSessions", null, value);
                this.OnPropertyChanged("Connection_ProcessSessions");
            }
        }

        /// <summary>
        /// N:1 ConnectionRole_ProcessSessions
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ConnectionRole_ProcessSessions")]
        public ConnectionRole ConnectionRole_ProcessSessions
        {
            get { return this.GetRelatedEntity<ConnectionRole>("ConnectionRole_ProcessSessions", null); }
            set
            {
                this.OnPropertyChanging("ConnectionRole_ProcessSessions");
                this.SetRelatedEntity<ConnectionRole>("ConnectionRole_ProcessSessions", null, value);
                this.OnPropertyChanged("ConnectionRole_ProcessSessions");
            }
        }

        /// <summary>
        /// N:1 ConstraintBasedGroup_ProcessSessions
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ConstraintBasedGroup_ProcessSessions")]
        public ConstraintBasedGroup ConstraintBasedGroup_ProcessSessions
        {
            get { return this.GetRelatedEntity<ConstraintBasedGroup>("ConstraintBasedGroup_ProcessSessions", null); }
            set
            {
                this.OnPropertyChanging("ConstraintBasedGroup_ProcessSessions");
                this.SetRelatedEntity<ConstraintBasedGroup>("ConstraintBasedGroup_ProcessSessions", null, value);
                this.OnPropertyChanged("ConstraintBasedGroup_ProcessSessions");
            }
        }

        /// <summary>
        /// N:1 Contact_ProcessSessions
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Contact_ProcessSessions")]
        public Contact Contact_ProcessSessions
        {
            get { return this.GetRelatedEntity<Contact>("Contact_ProcessSessions", null); }
            set
            {
                this.OnPropertyChanging("Contact_ProcessSessions");
                this.SetRelatedEntity<Contact>("Contact_ProcessSessions", null, value);
                this.OnPropertyChanged("Contact_ProcessSessions");
            }
        }

        /// <summary>
        /// N:1 Contract_ProcessSessions
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Contract_ProcessSessions")]
        public Contract Contract_ProcessSessions
        {
            get { return this.GetRelatedEntity<Contract>("Contract_ProcessSessions", null); }
            set
            {
                this.OnPropertyChanging("Contract_ProcessSessions");
                this.SetRelatedEntity<Contract>("Contract_ProcessSessions", null, value);
                this.OnPropertyChanged("Contract_ProcessSessions");
            }
        }

        /// <summary>
        /// N:1 ContractDetail_ProcessSessions
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ContractDetail_ProcessSessions")]
        public ContractDetail ContractDetail_ProcessSessions
        {
            get { return this.GetRelatedEntity<ContractDetail>("ContractDetail_ProcessSessions", null); }
            set
            {
                this.OnPropertyChanging("ContractDetail_ProcessSessions");
                this.SetRelatedEntity<ContractDetail>("ContractDetail_ProcessSessions", null, value);
                this.OnPropertyChanged("ContractDetail_ProcessSessions");
            }
        }

        /// <summary>
        /// N:1 ContractTemplate_ProcessSessions
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ContractTemplate_ProcessSessions")]
        public ContractTemplate ContractTemplate_ProcessSessions
        {
            get { return this.GetRelatedEntity<ContractTemplate>("ContractTemplate_ProcessSessions", null); }
            set
            {
                this.OnPropertyChanging("ContractTemplate_ProcessSessions");
                this.SetRelatedEntity<ContractTemplate>("ContractTemplate_ProcessSessions", null, value);
                this.OnPropertyChanged("ContractTemplate_ProcessSessions");
            }
        }

        /// <summary>
        /// N:1 ConvertRule_ProcessSessions
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ConvertRule_ProcessSessions")]
        public ConvertRule ConvertRule_ProcessSessions
        {
            get { return this.GetRelatedEntity<ConvertRule>("ConvertRule_ProcessSessions", null); }
            set
            {
                this.OnPropertyChanging("ConvertRule_ProcessSessions");
                this.SetRelatedEntity<ConvertRule>("ConvertRule_ProcessSessions", null, value);
                this.OnPropertyChanged("ConvertRule_ProcessSessions");
            }
        }

        /// <summary>
        /// N:1 CustomerAddress_ProcessSessions
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("CustomerAddress_ProcessSessions")]
        public CustomerAddress CustomerAddress_ProcessSessions
        {
            get { return this.GetRelatedEntity<CustomerAddress>("CustomerAddress_ProcessSessions", null); }
            set
            {
                this.OnPropertyChanging("CustomerAddress_ProcessSessions");
                this.SetRelatedEntity<CustomerAddress>("CustomerAddress_ProcessSessions", null, value);
                this.OnPropertyChanged("CustomerAddress_ProcessSessions");
            }
        }

        /// <summary>
        /// N:1 CustomerOpportunityRole_ProcessSessions
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("CustomerOpportunityRole_ProcessSessions")]
        public CustomerOpportunityRole CustomerOpportunityRole_ProcessSessions
        {
            get { return this.GetRelatedEntity<CustomerOpportunityRole>("CustomerOpportunityRole_ProcessSessions", null); }
            set
            {
                this.OnPropertyChanging("CustomerOpportunityRole_ProcessSessions");
                this.SetRelatedEntity<CustomerOpportunityRole>("CustomerOpportunityRole_ProcessSessions", null, value);
                this.OnPropertyChanged("CustomerOpportunityRole_ProcessSessions");
            }
        }

        /// <summary>
        /// N:1 CustomerRelationship_ProcessSessions
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("CustomerRelationship_ProcessSessions")]
        public CustomerRelationship CustomerRelationship_ProcessSessions
        {
            get { return this.GetRelatedEntity<CustomerRelationship>("CustomerRelationship_ProcessSessions", null); }
            set
            {
                this.OnPropertyChanging("CustomerRelationship_ProcessSessions");
                this.SetRelatedEntity<CustomerRelationship>("CustomerRelationship_ProcessSessions", null, value);
                this.OnPropertyChanged("CustomerRelationship_ProcessSessions");
            }
        }

        /// <summary>
        /// N:1 Discount_ProcessSessions
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Discount_ProcessSessions")]
        public Discount Discount_ProcessSessions
        {
            get { return this.GetRelatedEntity<Discount>("Discount_ProcessSessions", null); }
            set
            {
                this.OnPropertyChanging("Discount_ProcessSessions");
                this.SetRelatedEntity<Discount>("Discount_ProcessSessions", null, value);
                this.OnPropertyChanged("Discount_ProcessSessions");
            }
        }

        /// <summary>
        /// N:1 DiscountType_ProcessSessions
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("DiscountType_ProcessSessions")]
        public DiscountType DiscountType_ProcessSessions
        {
            get { return this.GetRelatedEntity<DiscountType>("DiscountType_ProcessSessions", null); }
            set
            {
                this.OnPropertyChanging("DiscountType_ProcessSessions");
                this.SetRelatedEntity<DiscountType>("DiscountType_ProcessSessions", null, value);
                this.OnPropertyChanged("DiscountType_ProcessSessions");
            }
        }

        /// <summary>
        /// N:1 Email_ProcessSessions
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Email_ProcessSessions")]
        public Email Email_ProcessSessions
        {
            get { return this.GetRelatedEntity<Email>("Email_ProcessSessions", null); }
            set
            {
                this.OnPropertyChanging("Email_ProcessSessions");
                this.SetRelatedEntity<Email>("Email_ProcessSessions", null, value);
                this.OnPropertyChanged("Email_ProcessSessions");
            }
        }

        /// <summary>
        /// N:1 entitlement_ProcessSession
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("entitlement_ProcessSession")]
        public Entitlement entitlement_ProcessSession
        {
            get { return this.GetRelatedEntity<Entitlement>("entitlement_ProcessSession", null); }
            set
            {
                this.OnPropertyChanging("entitlement_ProcessSession");
                this.SetRelatedEntity<Entitlement>("entitlement_ProcessSession", null, value);
                this.OnPropertyChanged("entitlement_ProcessSession");
            }
        }

        /// <summary>
        /// N:1 entitlementchannel_ProcessSession
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("entitlementchannel_ProcessSession")]
        public EntitlementChannel entitlementchannel_ProcessSession
        {
            get { return this.GetRelatedEntity<EntitlementChannel>("entitlementchannel_ProcessSession", null); }
            set
            {
                this.OnPropertyChanging("entitlementchannel_ProcessSession");
                this.SetRelatedEntity<EntitlementChannel>("entitlementchannel_ProcessSession", null, value);
                this.OnPropertyChanged("entitlementchannel_ProcessSession");
            }
        }

        /// <summary>
        /// N:1 entitlementtemplate_ProcessSession
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("entitlementtemplate_ProcessSession")]
        public EntitlementTemplate entitlementtemplate_ProcessSession
        {
            get { return this.GetRelatedEntity<EntitlementTemplate>("entitlementtemplate_ProcessSession", null); }
            set
            {
                this.OnPropertyChanging("entitlementtemplate_ProcessSession");
                this.SetRelatedEntity<EntitlementTemplate>("entitlementtemplate_ProcessSession", null, value);
                this.OnPropertyChanged("entitlementtemplate_ProcessSession");
            }
        }

        /// <summary>
        /// N:1 Equipment_ProcessSessions
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Equipment_ProcessSessions")]
        public Equipment Equipment_ProcessSessions
        {
            get { return this.GetRelatedEntity<Equipment>("Equipment_ProcessSessions", null); }
            set
            {
                this.OnPropertyChanging("Equipment_ProcessSessions");
                this.SetRelatedEntity<Equipment>("Equipment_ProcessSessions", null, value);
                this.OnPropertyChanged("Equipment_ProcessSessions");
            }
        }

        /// <summary>
        /// N:1 Fax_ProcessSessions
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Fax_ProcessSessions")]
        public Fax Fax_ProcessSessions
        {
            get { return this.GetRelatedEntity<Fax>("Fax_ProcessSessions", null); }
            set
            {
                this.OnPropertyChanging("Fax_ProcessSessions");
                this.SetRelatedEntity<Fax>("Fax_ProcessSessions", null, value);
                this.OnPropertyChanged("Fax_ProcessSessions");
            }
        }

        /// <summary>
        /// N:1 Goal_ProcessSessions
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Goal_ProcessSessions")]
        public Goal Goal_ProcessSessions
        {
            get { return this.GetRelatedEntity<Goal>("Goal_ProcessSessions", null); }
            set
            {
                this.OnPropertyChanging("Goal_ProcessSessions");
                this.SetRelatedEntity<Goal>("Goal_ProcessSessions", null, value);
                this.OnPropertyChanged("Goal_ProcessSessions");
            }
        }

        /// <summary>
        /// N:1 goalrollupquery_ProcessSessions
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("goalrollupquery_ProcessSessions")]
        public GoalRollupQuery goalrollupquery_ProcessSessions
        {
            get { return this.GetRelatedEntity<GoalRollupQuery>("goalrollupquery_ProcessSessions", null); }
            set
            {
                this.OnPropertyChanging("goalrollupquery_ProcessSessions");
                this.SetRelatedEntity<GoalRollupQuery>("goalrollupquery_ProcessSessions", null, value);
                this.OnPropertyChanged("goalrollupquery_ProcessSessions");
            }
        }

        /// <summary>
        /// N:1 Incident_ProcessSessions
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Incident_ProcessSessions")]
        public Incident Incident_ProcessSessions
        {
            get { return this.GetRelatedEntity<Incident>("Incident_ProcessSessions", null); }
            set
            {
                this.OnPropertyChanging("Incident_ProcessSessions");
                this.SetRelatedEntity<Incident>("Incident_ProcessSessions", null, value);
                this.OnPropertyChanged("Incident_ProcessSessions");
            }
        }

        /// <summary>
        /// N:1 Invoice_ProcessSessions
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Invoice_ProcessSessions")]
        public Invoice Invoice_ProcessSessions
        {
            get { return this.GetRelatedEntity<Invoice>("Invoice_ProcessSessions", null); }
            set
            {
                this.OnPropertyChanging("Invoice_ProcessSessions");
                this.SetRelatedEntity<Invoice>("Invoice_ProcessSessions", null, value);
                this.OnPropertyChanged("Invoice_ProcessSessions");
            }
        }

        /// <summary>
        /// N:1 InvoiceDetail_ProcessSessions
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("InvoiceDetail_ProcessSessions")]
        public InvoiceDetail InvoiceDetail_ProcessSessions
        {
            get { return this.GetRelatedEntity<InvoiceDetail>("InvoiceDetail_ProcessSessions", null); }
            set
            {
                this.OnPropertyChanging("InvoiceDetail_ProcessSessions");
                this.SetRelatedEntity<InvoiceDetail>("InvoiceDetail_ProcessSessions", null, value);
                this.OnPropertyChanged("InvoiceDetail_ProcessSessions");
            }
        }

        /// <summary>
        /// N:1 KbArticle_ProcessSessions
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("KbArticle_ProcessSessions")]
        public KbArticle KbArticle_ProcessSessions
        {
            get { return this.GetRelatedEntity<KbArticle>("KbArticle_ProcessSessions", null); }
            set
            {
                this.OnPropertyChanging("KbArticle_ProcessSessions");
                this.SetRelatedEntity<KbArticle>("KbArticle_ProcessSessions", null, value);
                this.OnPropertyChanged("KbArticle_ProcessSessions");
            }
        }

        /// <summary>
        /// N:1 KbArticleComment_ProcessSessions
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("KbArticleComment_ProcessSessions")]
        public KbArticleComment KbArticleComment_ProcessSessions
        {
            get { return this.GetRelatedEntity<KbArticleComment>("KbArticleComment_ProcessSessions", null); }
            set
            {
                this.OnPropertyChanging("KbArticleComment_ProcessSessions");
                this.SetRelatedEntity<KbArticleComment>("KbArticleComment_ProcessSessions", null, value);
                this.OnPropertyChanged("KbArticleComment_ProcessSessions");
            }
        }

        /// <summary>
        /// N:1 KbArticleTemplate_ProcessSessions
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("KbArticleTemplate_ProcessSessions")]
        public KbArticleTemplate KbArticleTemplate_ProcessSessions
        {
            get { return this.GetRelatedEntity<KbArticleTemplate>("KbArticleTemplate_ProcessSessions", null); }
            set
            {
                this.OnPropertyChanging("KbArticleTemplate_ProcessSessions");
                this.SetRelatedEntity<KbArticleTemplate>("KbArticleTemplate_ProcessSessions", null, value);
                this.OnPropertyChanged("KbArticleTemplate_ProcessSessions");
            }
        }

        /// <summary>
        /// N:1 Lead_ProcessSessions
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Lead_ProcessSessions")]
        public Lead Lead_ProcessSessions
        {
            get { return this.GetRelatedEntity<Lead>("Lead_ProcessSessions", null); }
            set
            {
                this.OnPropertyChanging("Lead_ProcessSessions");
                this.SetRelatedEntity<Lead>("Lead_ProcessSessions", null, value);
                this.OnPropertyChanged("Lead_ProcessSessions");
            }
        }

        /// <summary>
        /// N:1 Letter_ProcessSessions
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Letter_ProcessSessions")]
        public Letter Letter_ProcessSessions
        {
            get { return this.GetRelatedEntity<Letter>("Letter_ProcessSessions", null); }
            set
            {
                this.OnPropertyChanging("Letter_ProcessSessions");
                this.SetRelatedEntity<Letter>("Letter_ProcessSessions", null, value);
                this.OnPropertyChanged("Letter_ProcessSessions");
            }
        }

        /// <summary>
        /// N:1 List_ProcessSessions
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("List_ProcessSessions")]
        public List List_ProcessSessions
        {
            get { return this.GetRelatedEntity<List>("List_ProcessSessions", null); }
            set
            {
                this.OnPropertyChanging("List_ProcessSessions");
                this.SetRelatedEntity<List>("List_ProcessSessions", null, value);
                this.OnPropertyChanged("List_ProcessSessions");
            }
        }

        /// <summary>
        /// N:1 lk_processsession_canceledby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("canceledby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_processsession_canceledby")]
        public SystemUser lk_processsession_canceledby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_processsession_canceledby", null); }
        }

        /// <summary>
        /// N:1 lk_processsession_completedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("completedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_processsession_completedby")]
        public SystemUser lk_processsession_completedby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_processsession_completedby", null); }
        }

        /// <summary>
        /// N:1 lk_processsession_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_processsession_createdby")]
        public SystemUser lk_processsession_createdby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_processsession_createdby", null); }
        }

        /// <summary>
        /// N:1 lk_processsession_executedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("executedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_processsession_executedby")]
        public SystemUser lk_processsession_executedby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_processsession_executedby", null); }
            set
            {
                this.OnPropertyChanging("lk_processsession_executedby");
                this.SetRelatedEntity<SystemUser>("lk_processsession_executedby", null, value);
                this.OnPropertyChanged("lk_processsession_executedby");
            }
        }

        /// <summary>
        /// N:1 lk_processsession_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_processsession_modifiedby")]
        public SystemUser lk_processsession_modifiedby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_processsession_modifiedby", null); }
        }

        /// <summary>
        /// N:1 lk_processsession_nextlinkedsessionid
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("nextlinkedsessionid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_processsession_nextlinkedsessionid", Microsoft.Xrm.Sdk.EntityRole.Referencing)]
        public ProcessSession Referencinglk_processsession_nextlinkedsessionid
        {
            get { return this.GetRelatedEntity<ProcessSession>("lk_processsession_nextlinkedsessionid", Microsoft.Xrm.Sdk.EntityRole.Referencing); }
            set
            {
                this.OnPropertyChanging("Referencinglk_processsession_nextlinkedsessionid");
                this.SetRelatedEntity<ProcessSession>("lk_processsession_nextlinkedsessionid", Microsoft.Xrm.Sdk.EntityRole.Referencing, value);
                this.OnPropertyChanged("Referencinglk_processsession_nextlinkedsessionid");
            }
        }

        /// <summary>
        /// N:1 lk_processsession_originatingsessionid
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("originatingsessionid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_processsession_originatingsessionid", Microsoft.Xrm.Sdk.EntityRole.Referencing)]
        public ProcessSession Referencinglk_processsession_originatingsessionid
        {
            get { return this.GetRelatedEntity<ProcessSession>("lk_processsession_originatingsessionid", Microsoft.Xrm.Sdk.EntityRole.Referencing); }
            set
            {
                this.OnPropertyChanging("Referencinglk_processsession_originatingsessionid");
                this.SetRelatedEntity<ProcessSession>("lk_processsession_originatingsessionid", Microsoft.Xrm.Sdk.EntityRole.Referencing, value);
                this.OnPropertyChanged("Referencinglk_processsession_originatingsessionid");
            }
        }

        /// <summary>
        /// N:1 lk_processsession_previouslinkedsessionid
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("previouslinkedsessionid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_processsession_previouslinkedsessionid", Microsoft.Xrm.Sdk.EntityRole.Referencing)]
        public ProcessSession Referencinglk_processsession_previouslinkedsessionid
        {
            get { return this.GetRelatedEntity<ProcessSession>("lk_processsession_previouslinkedsessionid", Microsoft.Xrm.Sdk.EntityRole.Referencing); }
            set
            {
                this.OnPropertyChanging("Referencinglk_processsession_previouslinkedsessionid");
                this.SetRelatedEntity<ProcessSession>("lk_processsession_previouslinkedsessionid", Microsoft.Xrm.Sdk.EntityRole.Referencing, value);
                this.OnPropertyChanged("Referencinglk_processsession_previouslinkedsessionid");
            }
        }

        /// <summary>
        /// N:1 lk_processsession_processid
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("processid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_processsession_processid")]
        public Workflow lk_processsession_processid
        {
            get { return this.GetRelatedEntity<Workflow>("lk_processsession_processid", null); }
            set
            {
                this.OnPropertyChanging("lk_processsession_processid");
                this.SetRelatedEntity<Workflow>("lk_processsession_processid", null, value);
                this.OnPropertyChanged("lk_processsession_processid");
            }
        }

        /// <summary>
        /// N:1 lk_processsession_startedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("startedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_processsession_startedby")]
        public SystemUser lk_processsession_startedby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_processsession_startedby", null); }
        }

        /// <summary>
        /// N:1 lk_processsessionbase_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_processsessionbase_createdonbehalfby")]
        public SystemUser lk_processsessionbase_createdonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_processsessionbase_createdonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_processsessionbase_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_processsessionbase_modifiedonbehalfby")]
        public SystemUser lk_processsessionbase_modifiedonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_processsessionbase_modifiedonbehalfby", null); }
        }

        /// <summary>
        /// N:1 mailbox_processsessions
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("mailbox_processsessions")]
        public Mailbox mailbox_processsessions
        {
            get { return this.GetRelatedEntity<Mailbox>("mailbox_processsessions", null); }
            set
            {
                this.OnPropertyChanging("mailbox_processsessions");
                this.SetRelatedEntity<Mailbox>("mailbox_processsessions", null, value);
                this.OnPropertyChanged("mailbox_processsessions");
            }
        }

        /// <summary>
        /// N:1 MailMergeTemplate_ProcessSessions
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("MailMergeTemplate_ProcessSessions")]
        public MailMergeTemplate MailMergeTemplate_ProcessSessions
        {
            get { return this.GetRelatedEntity<MailMergeTemplate>("MailMergeTemplate_ProcessSessions", null); }
            set
            {
                this.OnPropertyChanging("MailMergeTemplate_ProcessSessions");
                this.SetRelatedEntity<MailMergeTemplate>("MailMergeTemplate_ProcessSessions", null, value);
                this.OnPropertyChanged("MailMergeTemplate_ProcessSessions");
            }
        }

        /// <summary>
        /// N:1 metric_ProcessSessions
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("metric_ProcessSessions")]
        public Metric metric_ProcessSessions
        {
            get { return this.GetRelatedEntity<Metric>("metric_ProcessSessions", null); }
            set
            {
                this.OnPropertyChanging("metric_ProcessSessions");
                this.SetRelatedEntity<Metric>("metric_ProcessSessions", null, value);
                this.OnPropertyChanged("metric_ProcessSessions");
            }
        }

        /// <summary>
        /// N:1 msdyn_postalbum_ProcessSession
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_postalbum_ProcessSession")]
        public msdyn_PostAlbum msdyn_postalbum_ProcessSession
        {
            get { return this.GetRelatedEntity<msdyn_PostAlbum>("msdyn_postalbum_ProcessSession", null); }
            set
            {
                this.OnPropertyChanging("msdyn_postalbum_ProcessSession");
                this.SetRelatedEntity<msdyn_PostAlbum>("msdyn_postalbum_ProcessSession", null, value);
                this.OnPropertyChanged("msdyn_postalbum_ProcessSession");
            }
        }

        /// <summary>
        /// N:1 msdyn_postconfig_ProcessSession
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_postconfig_ProcessSession")]
        public msdyn_PostConfig msdyn_postconfig_ProcessSession
        {
            get { return this.GetRelatedEntity<msdyn_PostConfig>("msdyn_postconfig_ProcessSession", null); }
            set
            {
                this.OnPropertyChanging("msdyn_postconfig_ProcessSession");
                this.SetRelatedEntity<msdyn_PostConfig>("msdyn_postconfig_ProcessSession", null, value);
                this.OnPropertyChanged("msdyn_postconfig_ProcessSession");
            }
        }

        /// <summary>
        /// N:1 msdyn_postruleconfig_ProcessSession
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_postruleconfig_ProcessSession")]
        public msdyn_PostRuleConfig msdyn_postruleconfig_ProcessSession
        {
            get { return this.GetRelatedEntity<msdyn_PostRuleConfig>("msdyn_postruleconfig_ProcessSession", null); }
            set
            {
                this.OnPropertyChanging("msdyn_postruleconfig_ProcessSession");
                this.SetRelatedEntity<msdyn_PostRuleConfig>("msdyn_postruleconfig_ProcessSession", null, value);
                this.OnPropertyChanged("msdyn_postruleconfig_ProcessSession");
            }
        }

        /// <summary>
        /// N:1 msdyn_wallsavedquery_ProcessSession
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_wallsavedquery_ProcessSession")]
        public msdyn_wallsavedquery msdyn_wallsavedquery_ProcessSession
        {
            get { return this.GetRelatedEntity<msdyn_wallsavedquery>("msdyn_wallsavedquery_ProcessSession", null); }
            set
            {
                this.OnPropertyChanging("msdyn_wallsavedquery_ProcessSession");
                this.SetRelatedEntity<msdyn_wallsavedquery>("msdyn_wallsavedquery_ProcessSession", null, value);
                this.OnPropertyChanged("msdyn_wallsavedquery_ProcessSession");
            }
        }

        /// <summary>
        /// N:1 msdyn_wallsavedqueryusersettings_ProcessSession
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_wallsavedqueryusersettings_ProcessSession")]
        public msdyn_wallsavedqueryusersettings msdyn_wallsavedqueryusersettings_ProcessSession
        {
            get { return this.GetRelatedEntity<msdyn_wallsavedqueryusersettings>("msdyn_wallsavedqueryusersettings_ProcessSession", null); }
            set
            {
                this.OnPropertyChanging("msdyn_wallsavedqueryusersettings_ProcessSession");
                this.SetRelatedEntity<msdyn_wallsavedqueryusersettings>("msdyn_wallsavedqueryusersettings_ProcessSession", null, value);
                this.OnPropertyChanged("msdyn_wallsavedqueryusersettings_ProcessSession");
            }
        }

        /// <summary>
        /// N:1 Opportunity_ProcessSessions
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Opportunity_ProcessSessions")]
        public Opportunity Opportunity_ProcessSessions
        {
            get { return this.GetRelatedEntity<Opportunity>("Opportunity_ProcessSessions", null); }
            set
            {
                this.OnPropertyChanging("Opportunity_ProcessSessions");
                this.SetRelatedEntity<Opportunity>("Opportunity_ProcessSessions", null, value);
                this.OnPropertyChanged("Opportunity_ProcessSessions");
            }
        }

        /// <summary>
        /// N:1 OpportunityProduct_ProcessSessions
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("OpportunityProduct_ProcessSessions")]
        public OpportunityProduct OpportunityProduct_ProcessSessions
        {
            get { return this.GetRelatedEntity<OpportunityProduct>("OpportunityProduct_ProcessSessions", null); }
            set
            {
                this.OnPropertyChanging("OpportunityProduct_ProcessSessions");
                this.SetRelatedEntity<OpportunityProduct>("OpportunityProduct_ProcessSessions", null, value);
                this.OnPropertyChanged("OpportunityProduct_ProcessSessions");
            }
        }

        /// <summary>
        /// N:1 Owning_businessunit_processsessions
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Owning_businessunit_processsessions")]
        public BusinessUnit Owning_businessunit_processsessions
        {
            get { return this.GetRelatedEntity<BusinessUnit>("Owning_businessunit_processsessions", null); }
        }

        /// <summary>
        /// N:1 PhoneCall_ProcessSessions
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("PhoneCall_ProcessSessions")]
        public PhoneCall PhoneCall_ProcessSessions
        {
            get { return this.GetRelatedEntity<PhoneCall>("PhoneCall_ProcessSessions", null); }
            set
            {
                this.OnPropertyChanging("PhoneCall_ProcessSessions");
                this.SetRelatedEntity<PhoneCall>("PhoneCall_ProcessSessions", null, value);
                this.OnPropertyChanged("PhoneCall_ProcessSessions");
            }
        }

        /// <summary>
        /// N:1 position_ProcessSession
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("position_ProcessSession")]
        public Position position_ProcessSession
        {
            get { return this.GetRelatedEntity<Position>("position_ProcessSession", null); }
            set
            {
                this.OnPropertyChanging("position_ProcessSession");
                this.SetRelatedEntity<Position>("position_ProcessSession", null, value);
                this.OnPropertyChanged("position_ProcessSession");
            }
        }

        /// <summary>
        /// N:1 PriceLevel_ProcessSessions
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("PriceLevel_ProcessSessions")]
        public PriceLevel PriceLevel_ProcessSessions
        {
            get { return this.GetRelatedEntity<PriceLevel>("PriceLevel_ProcessSessions", null); }
            set
            {
                this.OnPropertyChanging("PriceLevel_ProcessSessions");
                this.SetRelatedEntity<PriceLevel>("PriceLevel_ProcessSessions", null, value);
                this.OnPropertyChanged("PriceLevel_ProcessSessions");
            }
        }

        /// <summary>
        /// N:1 Product_ProcessSessions
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Product_ProcessSessions")]
        public Product Product_ProcessSessions
        {
            get { return this.GetRelatedEntity<Product>("Product_ProcessSessions", null); }
            set
            {
                this.OnPropertyChanging("Product_ProcessSessions");
                this.SetRelatedEntity<Product>("Product_ProcessSessions", null, value);
                this.OnPropertyChanged("Product_ProcessSessions");
            }
        }

        /// <summary>
        /// N:1 ProductAssociation_ProcessSessions
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ProductAssociation_ProcessSessions")]
        public ProductAssociation ProductAssociation_ProcessSessions
        {
            get { return this.GetRelatedEntity<ProductAssociation>("ProductAssociation_ProcessSessions", null); }
            set
            {
                this.OnPropertyChanging("ProductAssociation_ProcessSessions");
                this.SetRelatedEntity<ProductAssociation>("ProductAssociation_ProcessSessions", null, value);
                this.OnPropertyChanged("ProductAssociation_ProcessSessions");
            }
        }

        /// <summary>
        /// N:1 ProductPriceLevel_ProcessSessions
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ProductPriceLevel_ProcessSessions")]
        public ProductPriceLevel ProductPriceLevel_ProcessSessions
        {
            get { return this.GetRelatedEntity<ProductPriceLevel>("ProductPriceLevel_ProcessSessions", null); }
            set
            {
                this.OnPropertyChanging("ProductPriceLevel_ProcessSessions");
                this.SetRelatedEntity<ProductPriceLevel>("ProductPriceLevel_ProcessSessions", null, value);
                this.OnPropertyChanged("ProductPriceLevel_ProcessSessions");
            }
        }

        /// <summary>
        /// N:1 ProductSubstitute_ProcessSession
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ProductSubstitute_ProcessSession")]
        public ProductSubstitute ProductSubstitute_ProcessSession
        {
            get { return this.GetRelatedEntity<ProductSubstitute>("ProductSubstitute_ProcessSession", null); }
            set
            {
                this.OnPropertyChanging("ProductSubstitute_ProcessSession");
                this.SetRelatedEntity<ProductSubstitute>("ProductSubstitute_ProcessSession", null, value);
                this.OnPropertyChanged("ProductSubstitute_ProcessSession");
            }
        }

        /// <summary>
        /// N:1 Queue_ProcessSessions
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Queue_ProcessSessions")]
        public Queue Queue_ProcessSessions
        {
            get { return this.GetRelatedEntity<Queue>("Queue_ProcessSessions", null); }
            set
            {
                this.OnPropertyChanging("Queue_ProcessSessions");
                this.SetRelatedEntity<Queue>("Queue_ProcessSessions", null, value);
                this.OnPropertyChanged("Queue_ProcessSessions");
            }
        }

        /// <summary>
        /// N:1 QueueItem_ProcessSessions
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("QueueItem_ProcessSessions")]
        public QueueItem QueueItem_ProcessSessions
        {
            get { return this.GetRelatedEntity<QueueItem>("QueueItem_ProcessSessions", null); }
            set
            {
                this.OnPropertyChanging("QueueItem_ProcessSessions");
                this.SetRelatedEntity<QueueItem>("QueueItem_ProcessSessions", null, value);
                this.OnPropertyChanged("QueueItem_ProcessSessions");
            }
        }

        /// <summary>
        /// N:1 Quote_ProcessSessions
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Quote_ProcessSessions")]
        public Quote Quote_ProcessSessions
        {
            get { return this.GetRelatedEntity<Quote>("Quote_ProcessSessions", null); }
            set
            {
                this.OnPropertyChanging("Quote_ProcessSessions");
                this.SetRelatedEntity<Quote>("Quote_ProcessSessions", null, value);
                this.OnPropertyChanged("Quote_ProcessSessions");
            }
        }

        /// <summary>
        /// N:1 QuoteDetail_ProcessSessions
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("QuoteDetail_ProcessSessions")]
        public QuoteDetail QuoteDetail_ProcessSessions
        {
            get { return this.GetRelatedEntity<QuoteDetail>("QuoteDetail_ProcessSessions", null); }
            set
            {
                this.OnPropertyChanging("QuoteDetail_ProcessSessions");
                this.SetRelatedEntity<QuoteDetail>("QuoteDetail_ProcessSessions", null, value);
                this.OnPropertyChanged("QuoteDetail_ProcessSessions");
            }
        }

        /// <summary>
        /// N:1 RecurringAppointmentMaster_ProcessSessions
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("RecurringAppointmentMaster_ProcessSessions")]
        public RecurringAppointmentMaster RecurringAppointmentMaster_ProcessSessions
        {
            get { return this.GetRelatedEntity<RecurringAppointmentMaster>("RecurringAppointmentMaster_ProcessSessions", null); }
            set
            {
                this.OnPropertyChanging("RecurringAppointmentMaster_ProcessSessions");
                this.SetRelatedEntity<RecurringAppointmentMaster>("RecurringAppointmentMaster_ProcessSessions", null, value);
                this.OnPropertyChanged("RecurringAppointmentMaster_ProcessSessions");
            }
        }

        /// <summary>
        /// N:1 RelationshipRole_ProcessSessions
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("RelationshipRole_ProcessSessions")]
        public RelationshipRole RelationshipRole_ProcessSessions
        {
            get { return this.GetRelatedEntity<RelationshipRole>("RelationshipRole_ProcessSessions", null); }
            set
            {
                this.OnPropertyChanging("RelationshipRole_ProcessSessions");
                this.SetRelatedEntity<RelationshipRole>("RelationshipRole_ProcessSessions", null, value);
                this.OnPropertyChanged("RelationshipRole_ProcessSessions");
            }
        }

        /// <summary>
        /// N:1 Report_ProcessSessions
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Report_ProcessSessions")]
        public Report Report_ProcessSessions
        {
            get { return this.GetRelatedEntity<Report>("Report_ProcessSessions", null); }
            set
            {
                this.OnPropertyChanging("Report_ProcessSessions");
                this.SetRelatedEntity<Report>("Report_ProcessSessions", null, value);
                this.OnPropertyChanged("Report_ProcessSessions");
            }
        }

        /// <summary>
        /// N:1 rollupfield_ProcessSessions
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("rollupfield_ProcessSessions")]
        public RollupField rollupfield_ProcessSessions
        {
            get { return this.GetRelatedEntity<RollupField>("rollupfield_ProcessSessions", null); }
            set
            {
                this.OnPropertyChanging("rollupfield_ProcessSessions");
                this.SetRelatedEntity<RollupField>("rollupfield_ProcessSessions", null, value);
                this.OnPropertyChanged("rollupfield_ProcessSessions");
            }
        }

        /// <summary>
        /// N:1 routingrule_ProcessSessions
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("routingrule_ProcessSessions")]
        public RoutingRule routingrule_ProcessSessions
        {
            get { return this.GetRelatedEntity<RoutingRule>("routingrule_ProcessSessions", null); }
            set
            {
                this.OnPropertyChanging("routingrule_ProcessSessions");
                this.SetRelatedEntity<RoutingRule>("routingrule_ProcessSessions", null, value);
                this.OnPropertyChanged("routingrule_ProcessSessions");
            }
        }

        /// <summary>
        /// N:1 routingruleitem_ProcessSessions
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("routingruleitem_ProcessSessions")]
        public RoutingRuleItem routingruleitem_ProcessSessions
        {
            get { return this.GetRelatedEntity<RoutingRuleItem>("routingruleitem_ProcessSessions", null); }
            set
            {
                this.OnPropertyChanging("routingruleitem_ProcessSessions");
                this.SetRelatedEntity<RoutingRuleItem>("routingruleitem_ProcessSessions", null, value);
                this.OnPropertyChanged("routingruleitem_ProcessSessions");
            }
        }

        /// <summary>
        /// N:1 SalesLiterature_ProcessSessions
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SalesLiterature_ProcessSessions")]
        public SalesLiterature SalesLiterature_ProcessSessions
        {
            get { return this.GetRelatedEntity<SalesLiterature>("SalesLiterature_ProcessSessions", null); }
            set
            {
                this.OnPropertyChanging("SalesLiterature_ProcessSessions");
                this.SetRelatedEntity<SalesLiterature>("SalesLiterature_ProcessSessions", null, value);
                this.OnPropertyChanged("SalesLiterature_ProcessSessions");
            }
        }

        /// <summary>
        /// N:1 SalesLiteratureItem_ProcessSessions
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SalesLiteratureItem_ProcessSessions")]
        public SalesLiteratureItem SalesLiteratureItem_ProcessSessions
        {
            get { return this.GetRelatedEntity<SalesLiteratureItem>("SalesLiteratureItem_ProcessSessions", null); }
            set
            {
                this.OnPropertyChanging("SalesLiteratureItem_ProcessSessions");
                this.SetRelatedEntity<SalesLiteratureItem>("SalesLiteratureItem_ProcessSessions", null, value);
                this.OnPropertyChanged("SalesLiteratureItem_ProcessSessions");
            }
        }

        /// <summary>
        /// N:1 SalesOrder_ProcessSessions
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SalesOrder_ProcessSessions")]
        public SalesOrder SalesOrder_ProcessSessions
        {
            get { return this.GetRelatedEntity<SalesOrder>("SalesOrder_ProcessSessions", null); }
            set
            {
                this.OnPropertyChanging("SalesOrder_ProcessSessions");
                this.SetRelatedEntity<SalesOrder>("SalesOrder_ProcessSessions", null, value);
                this.OnPropertyChanged("SalesOrder_ProcessSessions");
            }
        }

        /// <summary>
        /// N:1 SalesOrderDetail_ProcessSessions
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SalesOrderDetail_ProcessSessions")]
        public SalesOrderDetail SalesOrderDetail_ProcessSessions
        {
            get { return this.GetRelatedEntity<SalesOrderDetail>("SalesOrderDetail_ProcessSessions", null); }
            set
            {
                this.OnPropertyChanging("SalesOrderDetail_ProcessSessions");
                this.SetRelatedEntity<SalesOrderDetail>("SalesOrderDetail_ProcessSessions", null, value);
                this.OnPropertyChanged("SalesOrderDetail_ProcessSessions");
            }
        }

        /// <summary>
        /// N:1 Service_ProcessSessions
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Service_ProcessSessions")]
        public Service Service_ProcessSessions
        {
            get { return this.GetRelatedEntity<Service>("Service_ProcessSessions", null); }
            set
            {
                this.OnPropertyChanging("Service_ProcessSessions");
                this.SetRelatedEntity<Service>("Service_ProcessSessions", null, value);
                this.OnPropertyChanged("Service_ProcessSessions");
            }
        }

        /// <summary>
        /// N:1 ServiceAppointment_ProcessSessions
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ServiceAppointment_ProcessSessions")]
        public ServiceAppointment ServiceAppointment_ProcessSessions
        {
            get { return this.GetRelatedEntity<ServiceAppointment>("ServiceAppointment_ProcessSessions", null); }
            set
            {
                this.OnPropertyChanging("ServiceAppointment_ProcessSessions");
                this.SetRelatedEntity<ServiceAppointment>("ServiceAppointment_ProcessSessions", null, value);
                this.OnPropertyChanged("ServiceAppointment_ProcessSessions");
            }
        }

        /// <summary>
        /// N:1 SharePointDocumentLocation_ProcessSessions
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SharePointDocumentLocation_ProcessSessions")]
        public SharePointDocumentLocation SharePointDocumentLocation_ProcessSessions
        {
            get { return this.GetRelatedEntity<SharePointDocumentLocation>("SharePointDocumentLocation_ProcessSessions", null); }
            set
            {
                this.OnPropertyChanging("SharePointDocumentLocation_ProcessSessions");
                this.SetRelatedEntity<SharePointDocumentLocation>("SharePointDocumentLocation_ProcessSessions", null, value);
                this.OnPropertyChanged("SharePointDocumentLocation_ProcessSessions");
            }
        }

        /// <summary>
        /// N:1 SharePointSite_ProcessSessions
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SharePointSite_ProcessSessions")]
        public SharePointSite SharePointSite_ProcessSessions
        {
            get { return this.GetRelatedEntity<SharePointSite>("SharePointSite_ProcessSessions", null); }
            set
            {
                this.OnPropertyChanging("SharePointSite_ProcessSessions");
                this.SetRelatedEntity<SharePointSite>("SharePointSite_ProcessSessions", null, value);
                this.OnPropertyChanged("SharePointSite_ProcessSessions");
            }
        }

        /// <summary>
        /// N:1 Site_ProcessSessions
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Site_ProcessSessions")]
        public Site Site_ProcessSessions
        {
            get { return this.GetRelatedEntity<Site>("Site_ProcessSessions", null); }
            set
            {
                this.OnPropertyChanging("Site_ProcessSessions");
                this.SetRelatedEntity<Site>("Site_ProcessSessions", null, value);
                this.OnPropertyChanged("Site_ProcessSessions");
            }
        }

        /// <summary>
        /// N:1 slabase_ProcessSessions
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("slabase_ProcessSessions")]
        public SLA slabase_ProcessSessions
        {
            get { return this.GetRelatedEntity<SLA>("slabase_ProcessSessions", null); }
            set
            {
                this.OnPropertyChanging("slabase_ProcessSessions");
                this.SetRelatedEntity<SLA>("slabase_ProcessSessions", null, value);
                this.OnPropertyChanged("slabase_ProcessSessions");
            }
        }

        /// <summary>
        /// N:1 SocialActivity_ProcessSessions
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SocialActivity_ProcessSessions")]
        public SocialActivity SocialActivity_ProcessSessions
        {
            get { return this.GetRelatedEntity<SocialActivity>("SocialActivity_ProcessSessions", null); }
            set
            {
                this.OnPropertyChanging("SocialActivity_ProcessSessions");
                this.SetRelatedEntity<SocialActivity>("SocialActivity_ProcessSessions", null, value);
                this.OnPropertyChanged("SocialActivity_ProcessSessions");
            }
        }

        /// <summary>
        /// N:1 SocialProfile_ProcessSessions
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SocialProfile_ProcessSessions")]
        public SocialProfile SocialProfile_ProcessSessions
        {
            get { return this.GetRelatedEntity<SocialProfile>("SocialProfile_ProcessSessions", null); }
            set
            {
                this.OnPropertyChanging("SocialProfile_ProcessSessions");
                this.SetRelatedEntity<SocialProfile>("SocialProfile_ProcessSessions", null, value);
                this.OnPropertyChanged("SocialProfile_ProcessSessions");
            }
        }

        /// <summary>
        /// N:1 Subject_ProcessSessions
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Subject_ProcessSessions")]
        public Subject Subject_ProcessSessions
        {
            get { return this.GetRelatedEntity<Subject>("Subject_ProcessSessions", null); }
            set
            {
                this.OnPropertyChanging("Subject_ProcessSessions");
                this.SetRelatedEntity<Subject>("Subject_ProcessSessions", null, value);
                this.OnPropertyChanged("Subject_ProcessSessions");
            }
        }

        /// <summary>
        /// N:1 SystemUser_ProcessSessions
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SystemUser_ProcessSessions")]
        public SystemUser SystemUser_ProcessSessions
        {
            get { return this.GetRelatedEntity<SystemUser>("SystemUser_ProcessSessions", null); }
            set
            {
                this.OnPropertyChanging("SystemUser_ProcessSessions");
                this.SetRelatedEntity<SystemUser>("SystemUser_ProcessSessions", null, value);
                this.OnPropertyChanged("SystemUser_ProcessSessions");
            }
        }

        /// <summary>
        /// N:1 Task_ProcessSessions
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Task_ProcessSessions")]
        public Task Task_ProcessSessions
        {
            get { return this.GetRelatedEntity<Task>("Task_ProcessSessions", null); }
            set
            {
                this.OnPropertyChanging("Task_ProcessSessions");
                this.SetRelatedEntity<Task>("Task_ProcessSessions", null, value);
                this.OnPropertyChanged("Task_ProcessSessions");
            }
        }

        /// <summary>
        /// N:1 team_processsession
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_processsession")]
        public Team team_processsession
        {
            get { return this.GetRelatedEntity<Team>("team_processsession", null); }
        }

        /// <summary>
        /// N:1 Team_ProcessSessions
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Team_ProcessSessions")]
        public Team Team_ProcessSessions
        {
            get { return this.GetRelatedEntity<Team>("Team_ProcessSessions", null); }
            set
            {
                this.OnPropertyChanging("Team_ProcessSessions");
                this.SetRelatedEntity<Team>("Team_ProcessSessions", null, value);
                this.OnPropertyChanged("Team_ProcessSessions");
            }
        }

        /// <summary>
        /// N:1 Template_ProcessSessions
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Template_ProcessSessions")]
        public Template Template_ProcessSessions
        {
            get { return this.GetRelatedEntity<Template>("Template_ProcessSessions", null); }
            set
            {
                this.OnPropertyChanging("Template_ProcessSessions");
                this.SetRelatedEntity<Template>("Template_ProcessSessions", null, value);
                this.OnPropertyChanged("Template_ProcessSessions");
            }
        }

        /// <summary>
        /// N:1 Territory_ProcessSessions
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Territory_ProcessSessions")]
        public Territory Territory_ProcessSessions
        {
            get { return this.GetRelatedEntity<Territory>("Territory_ProcessSessions", null); }
            set
            {
                this.OnPropertyChanging("Territory_ProcessSessions");
                this.SetRelatedEntity<Territory>("Territory_ProcessSessions", null, value);
                this.OnPropertyChanged("Territory_ProcessSessions");
            }
        }

        /// <summary>
        /// N:1 TransactionCurrency_ProcessSessions
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("TransactionCurrency_ProcessSessions")]
        public TransactionCurrency TransactionCurrency_ProcessSessions
        {
            get { return this.GetRelatedEntity<TransactionCurrency>("TransactionCurrency_ProcessSessions", null); }
            set
            {
                this.OnPropertyChanging("TransactionCurrency_ProcessSessions");
                this.SetRelatedEntity<TransactionCurrency>("TransactionCurrency_ProcessSessions", null, value);
                this.OnPropertyChanged("TransactionCurrency_ProcessSessions");
            }
        }
    }
}