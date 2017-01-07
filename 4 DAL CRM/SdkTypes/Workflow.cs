namespace __4_DAL_CRM
{
    /// <summary>
    /// Set of logical rules that define the steps necessary to automate a specific business process, task, or set of actions to be performed.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("workflow")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class Workflow : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public Workflow() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "workflow";

        public const int EntityTypeCode = 4703;

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
        /// Unique identifier of the latest activation record for the process.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("activeworkflowid")]
        public Microsoft.Xrm.Sdk.EntityReference ActiveWorkflowId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("activeworkflowid"); }
        }

        /// <summary>
        /// Indicates whether the asynchronous system job is automatically deleted on completion.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("asyncautodelete")]
        public System.Nullable<bool> AsyncAutoDelete
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("asyncautodelete"); }
            set
            {
                this.OnPropertyChanging("AsyncAutoDelete");
                this.SetAttributeValue("asyncautodelete", value);
                this.OnPropertyChanged("AsyncAutoDelete");
            }
        }

        /// <summary>
        /// Category of the process.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("category")]
        public Microsoft.Xrm.Sdk.OptionSetValue Category
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("category"); }
            set
            {
                this.OnPropertyChanging("Category");
                this.SetAttributeValue("category", value);
                this.OnPropertyChanged("Category");
            }
        }

        /// <summary>
        /// Business logic converted into client data
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("clientdata")]
        public string ClientData
        {
            get { return this.GetAttributeValue<string>("clientdata"); }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("componentstate")]
        public Microsoft.Xrm.Sdk.OptionSetValue ComponentState
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("componentstate"); }
        }

        /// <summary>
        /// Unique identifier of the user who created the process.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby"); }
        }

        /// <summary>
        /// Date and time when the process was created.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
        public System.Nullable<System.DateTime> CreatedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who created the process.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        /// Stage of the process when triggered on Create.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createstage")]
        public Microsoft.Xrm.Sdk.OptionSetValue CreateStage
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("createstage"); }
            set
            {
                this.OnPropertyChanging("CreateStage");
                this.SetAttributeValue("createstage", value);
                this.OnPropertyChanged("CreateStage");
            }
        }

        /// <summary>
        /// Stage of the process when triggered on Delete.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("deletestage")]
        public Microsoft.Xrm.Sdk.OptionSetValue DeleteStage
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("deletestage"); }
            set
            {
                this.OnPropertyChanging("DeleteStage");
                this.SetAttributeValue("deletestage", value);
                this.OnPropertyChanged("DeleteStage");
            }
        }

        /// <summary>
        /// Description of the process.
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
        /// Input parameters to the process.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("inputparameters")]
        public string InputParameters
        {
            get { return this.GetAttributeValue<string>("inputparameters"); }
            set
            {
                this.OnPropertyChanging("InputParameters");
                this.SetAttributeValue("inputparameters", value);
                this.OnPropertyChanged("InputParameters");
            }
        }

        /// <summary>
        /// Version in which the form is introduced.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("introducedversion")]
        public string IntroducedVersion
        {
            get { return this.GetAttributeValue<string>("introducedversion"); }
            set
            {
                this.OnPropertyChanging("IntroducedVersion");
                this.SetAttributeValue("introducedversion", value);
                this.OnPropertyChanged("IntroducedVersion");
            }
        }

        /// <summary>
        /// Indicates whether the process was created using the Microsoft Dynamics CRM Web application.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("iscrmuiworkflow")]
        public System.Nullable<bool> IsCrmUIWorkflow
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("iscrmuiworkflow"); }
        }

        /// <summary>
        /// Information that specifies whether this component can be customized.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("iscustomizable")]
        public Microsoft.Xrm.Sdk.BooleanManagedProperty IsCustomizable
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.BooleanManagedProperty>("iscustomizable"); }
            set
            {
                this.OnPropertyChanging("IsCustomizable");
                this.SetAttributeValue("iscustomizable", value);
                this.OnPropertyChanged("IsCustomizable");
            }
        }

        /// <summary>
        /// Indicates whether the solution component is part of a managed solution.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ismanaged")]
        public System.Nullable<bool> IsManaged
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("ismanaged"); }
        }

        /// <summary>
        /// Whether or not the steps in the process are executed in a single transaction.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("istransacted")]
        public System.Nullable<bool> IsTransacted
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("istransacted"); }
            set
            {
                this.OnPropertyChanging("IsTransacted");
                this.SetAttributeValue("istransacted", value);
                this.OnPropertyChanged("IsTransacted");
            }
        }

        /// <summary>
        /// Language of the process.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("languagecode")]
        public System.Nullable<int> LanguageCode
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("languagecode"); }
            set
            {
                this.OnPropertyChanging("LanguageCode");
                this.SetAttributeValue("languagecode", value);
                this.OnPropertyChanged("LanguageCode");
            }
        }

        /// <summary>
        /// Shows the mode of the process.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("mode")]
        public Microsoft.Xrm.Sdk.OptionSetValue Mode
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("mode"); }
            set
            {
                this.OnPropertyChanging("Mode");
                this.SetAttributeValue("mode", value);
                this.OnPropertyChanged("Mode");
            }
        }

        /// <summary>
        /// Unique identifier of the user who last modified the process.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby"); }
        }

        /// <summary>
        /// Date and time when the process was last modified.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
        public System.Nullable<System.DateTime> ModifiedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who last modified the process.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        /// Name of the process.
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
        /// Indicates whether the process is able to run as an on-demand process.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ondemand")]
        public System.Nullable<bool> OnDemand
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("ondemand"); }
            set
            {
                this.OnPropertyChanging("OnDemand");
                this.SetAttributeValue("ondemand", value);
                this.OnPropertyChanged("OnDemand");
            }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("overwritetime")]
        public System.Nullable<System.DateTime> OverwriteTime
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("overwritetime"); }
        }

        /// <summary>
        /// Unique identifier of the user or team who owns the process.
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
        /// Unique identifier of the business unit that owns the process.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
        public Microsoft.Xrm.Sdk.EntityReference OwningBusinessUnit
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningbusinessunit"); }
        }

        /// <summary>
        /// Unique identifier of the team who owns the process.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
        public Microsoft.Xrm.Sdk.EntityReference OwningTeam
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningteam"); }
        }

        /// <summary>
        /// Unique identifier of the user who owns the process.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
        public Microsoft.Xrm.Sdk.EntityReference OwningUser
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owninguser"); }
        }

        /// <summary>
        /// Unique identifier of the definition for process activation.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("parentworkflowid")]
        public Microsoft.Xrm.Sdk.EntityReference ParentWorkflowId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("parentworkflowid"); }
        }

        /// <summary>
        /// Unique identifier of the plug-in type.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("plugintypeid")]
        public Microsoft.Xrm.Sdk.EntityReference PluginTypeId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("plugintypeid"); }
        }

        /// <summary>
        /// Primary entity for the process. The process can be associated for one or more SDK operations defined on the primary entity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("primaryentity")]
        public string PrimaryEntity
        {
            get { return this.GetAttributeValue<string>("primaryentity"); }
            set
            {
                this.OnPropertyChanging("PrimaryEntity");
                this.SetAttributeValue("primaryentity", value);
                this.OnPropertyChanged("PrimaryEntity");
            }
        }

        /// <summary>
        /// Type the business process flow order.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("processorder")]
        public System.Nullable<int> ProcessOrder
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("processorder"); }
            set
            {
                this.OnPropertyChanging("ProcessOrder");
                this.SetAttributeValue("processorder", value);
                this.OnPropertyChanged("ProcessOrder");
            }
        }

        /// <summary>
        /// Contains the role assignment for the process.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("processroleassignment")]
        public string ProcessRoleAssignment
        {
            get { return this.GetAttributeValue<string>("processroleassignment"); }
            set
            {
                this.OnPropertyChanging("ProcessRoleAssignment");
                this.SetAttributeValue("processroleassignment", value);
                this.OnPropertyChanged("ProcessRoleAssignment");
            }
        }

        /// <summary>
        /// Indicates the rank for order of execution for the synchronous workflow.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rank")]
        public System.Nullable<int> Rank
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("rank"); }
            set
            {
                this.OnPropertyChanging("Rank");
                this.SetAttributeValue("rank", value);
                this.OnPropertyChanged("Rank");
            }
        }

        /// <summary>
        /// The renderer type of Workflow
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rendererobjecttypecode")]
        public string RendererObjectTypeCode
        {
            get { return this.GetAttributeValue<string>("rendererobjecttypecode"); }
            set
            {
                this.OnPropertyChanging("RendererObjectTypeCode");
                this.SetAttributeValue("rendererobjecttypecode", value);
                this.OnPropertyChanged("RendererObjectTypeCode");
            }
        }

        /// <summary>
        /// Specifies the system user account under which a workflow executes.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("runas")]
        public Microsoft.Xrm.Sdk.OptionSetValue RunAs
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("runas"); }
            set
            {
                this.OnPropertyChanging("RunAs");
                this.SetAttributeValue("runas", value);
                this.OnPropertyChanged("RunAs");
            }
        }

        /// <summary>
        /// Scope of the process.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("scope")]
        public Microsoft.Xrm.Sdk.OptionSetValue Scope
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("scope"); }
            set
            {
                this.OnPropertyChanging("Scope");
                this.SetAttributeValue("scope", value);
                this.OnPropertyChanged("Scope");
            }
        }

        /// <summary>
        /// Unique identifier of the SDK Message associated with this workflow.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sdkmessageid")]
        public Microsoft.Xrm.Sdk.EntityReference SdkMessageId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("sdkmessageid"); }
        }

        /// <summary>
        /// Unique identifier of the associated solution.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("solutionid")]
        public System.Nullable<System.Guid> SolutionId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("solutionid"); }
        }

        /// <summary>
        /// Status of the process.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
        public System.Nullable<WorkflowState> StateCode
        {
            get
            {
                Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
                if ((optionSet != null))
                {
                    return ((WorkflowState) (System.Enum.ToObject(typeof(WorkflowState), optionSet.Value)));
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// Additional information about status of the process.
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
        /// Indicates whether the process can be included in other processes as a child process.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("subprocess")]
        public System.Nullable<bool> Subprocess
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("subprocess"); }
            set
            {
                this.OnPropertyChanging("Subprocess");
                this.SetAttributeValue("subprocess", value);
                this.OnPropertyChanged("Subprocess");
            }
        }

        /// <summary>
        /// Select whether synchronous workflow failures will be saved to log files.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("syncworkflowlogonfailure")]
        public System.Nullable<bool> SyncWorkflowLogOnFailure
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("syncworkflowlogonfailure"); }
            set
            {
                this.OnPropertyChanging("SyncWorkflowLogOnFailure");
                this.SetAttributeValue("syncworkflowlogonfailure", value);
                this.OnPropertyChanged("SyncWorkflowLogOnFailure");
            }
        }

        /// <summary>
        /// Indicates whether the process will be triggered when the primary entity is created.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("triggeroncreate")]
        public System.Nullable<bool> TriggerOnCreate
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("triggeroncreate"); }
            set
            {
                this.OnPropertyChanging("TriggerOnCreate");
                this.SetAttributeValue("triggeroncreate", value);
                this.OnPropertyChanged("TriggerOnCreate");
            }
        }

        /// <summary>
        /// Indicates whether the process will be triggered on deletion of the primary entity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("triggerondelete")]
        public System.Nullable<bool> TriggerOnDelete
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("triggerondelete"); }
            set
            {
                this.OnPropertyChanging("TriggerOnDelete");
                this.SetAttributeValue("triggerondelete", value);
                this.OnPropertyChanged("TriggerOnDelete");
            }
        }

        /// <summary>
        /// Attributes that trigger the process when updated.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("triggeronupdateattributelist")]
        public string TriggerOnUpdateAttributeList
        {
            get { return this.GetAttributeValue<string>("triggeronupdateattributelist"); }
            set
            {
                this.OnPropertyChanging("TriggerOnUpdateAttributeList");
                this.SetAttributeValue("triggeronupdateattributelist", value);
                this.OnPropertyChanged("TriggerOnUpdateAttributeList");
            }
        }

        /// <summary>
        /// Type of the process.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("type")]
        public Microsoft.Xrm.Sdk.OptionSetValue Type
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("type"); }
            set
            {
                this.OnPropertyChanging("Type");
                this.SetAttributeValue("type", value);
                this.OnPropertyChanged("Type");
            }
        }

        /// <summary>
        /// Unique name of the process
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("uniquename")]
        public string UniqueName
        {
            get { return this.GetAttributeValue<string>("uniquename"); }
            set
            {
                this.OnPropertyChanging("UniqueName");
                this.SetAttributeValue("uniquename", value);
                this.OnPropertyChanged("UniqueName");
            }
        }

        /// <summary>
        /// Select the stage a process will be triggered on update.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("updatestage")]
        public Microsoft.Xrm.Sdk.OptionSetValue UpdateStage
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("updatestage"); }
            set
            {
                this.OnPropertyChanging("UpdateStage");
                this.SetAttributeValue("updatestage", value);
                this.OnPropertyChanged("UpdateStage");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
        public System.Nullable<long> VersionNumber
        {
            get { return this.GetAttributeValue<System.Nullable<long>>("versionnumber"); }
        }

        /// <summary>
        /// Unique identifier of the process.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("workflowid")]
        public System.Nullable<System.Guid> WorkflowId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("workflowid"); }
            set
            {
                this.OnPropertyChanging("WorkflowId");
                this.SetAttributeValue("workflowid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("WorkflowId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("workflowid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.WorkflowId = value; }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("workflowidunique")]
        public System.Nullable<System.Guid> WorkflowIdUnique
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("workflowidunique"); }
        }

        /// <summary>
        /// XAML that defines the process.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("xaml")]
        public string Xaml
        {
            get { return this.GetAttributeValue<string>("xaml"); }
            set
            {
                this.OnPropertyChanging("Xaml");
                this.SetAttributeValue("xaml", value);
                this.OnPropertyChanged("Xaml");
            }
        }

        /// <summary>
        /// 1:N lk_asyncoperation_workflowactivationid
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_asyncoperation_workflowactivationid")]
        public System.Collections.Generic.IEnumerable<AsyncOperation> lk_asyncoperation_workflowactivationid
        {
            get { return this.GetRelatedEntities<AsyncOperation>("lk_asyncoperation_workflowactivationid", null); }
            set
            {
                this.OnPropertyChanging("lk_asyncoperation_workflowactivationid");
                this.SetRelatedEntities<AsyncOperation>("lk_asyncoperation_workflowactivationid", null, value);
                this.OnPropertyChanged("lk_asyncoperation_workflowactivationid");
            }
        }

        /// <summary>
        /// 1:N lk_processsession_processid
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_processsession_processid")]
        public System.Collections.Generic.IEnumerable<ProcessSession> lk_processsession_processid
        {
            get { return this.GetRelatedEntities<ProcessSession>("lk_processsession_processid", null); }
            set
            {
                this.OnPropertyChanging("lk_processsession_processid");
                this.SetRelatedEntities<ProcessSession>("lk_processsession_processid", null, value);
                this.OnPropertyChanged("lk_processsession_processid");
            }
        }

        /// <summary>
        /// 1:N process_processstage
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("process_processstage")]
        public System.Collections.Generic.IEnumerable<ProcessStage> process_processstage
        {
            get { return this.GetRelatedEntities<ProcessStage>("process_processstage", null); }
            set
            {
                this.OnPropertyChanging("process_processstage");
                this.SetRelatedEntities<ProcessStage>("process_processstage", null, value);
                this.OnPropertyChanged("process_processstage");
            }
        }

        /// <summary>
        /// 1:N process_processtrigger
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("process_processtrigger")]
        public System.Collections.Generic.IEnumerable<ProcessTrigger> process_processtrigger
        {
            get { return this.GetRelatedEntities<ProcessTrigger>("process_processtrigger", null); }
            set
            {
                this.OnPropertyChanging("process_processtrigger");
                this.SetRelatedEntities<ProcessTrigger>("process_processtrigger", null, value);
                this.OnPropertyChanged("process_processtrigger");
            }
        }

        /// <summary>
        /// 1:N slabase_workflowid
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("slabase_workflowid")]
        public System.Collections.Generic.IEnumerable<SLA> slabase_workflowid
        {
            get { return this.GetRelatedEntities<SLA>("slabase_workflowid", null); }
            set
            {
                this.OnPropertyChanging("slabase_workflowid");
                this.SetRelatedEntities<SLA>("slabase_workflowid", null, value);
                this.OnPropertyChanged("slabase_workflowid");
            }
        }

        /// <summary>
        /// 1:N slaitembase_workflowid
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("slaitembase_workflowid")]
        public System.Collections.Generic.IEnumerable<SLAItem> slaitembase_workflowid
        {
            get { return this.GetRelatedEntities<SLAItem>("slaitembase_workflowid", null); }
            set
            {
                this.OnPropertyChanging("slaitembase_workflowid");
                this.SetRelatedEntities<SLAItem>("slaitembase_workflowid", null, value);
                this.OnPropertyChanged("slaitembase_workflowid");
            }
        }

        /// <summary>
        /// 1:N userentityinstancedata_workflow
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_workflow")]
        public System.Collections.Generic.IEnumerable<UserEntityInstanceData> userentityinstancedata_workflow
        {
            get { return this.GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_workflow", null); }
            set
            {
                this.OnPropertyChanging("userentityinstancedata_workflow");
                this.SetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_workflow", null, value);
                this.OnPropertyChanged("userentityinstancedata_workflow");
            }
        }

        /// <summary>
        /// 1:N workflow_active_workflow
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("workflow_active_workflow", Microsoft.Xrm.Sdk.EntityRole.Referenced)]
        public System.Collections.Generic.IEnumerable<Workflow> Referencedworkflow_active_workflow
        {
            get { return this.GetRelatedEntities<Workflow>("workflow_active_workflow", Microsoft.Xrm.Sdk.EntityRole.Referenced); }
            set
            {
                this.OnPropertyChanging("Referencedworkflow_active_workflow");
                this.SetRelatedEntities<Workflow>("workflow_active_workflow", Microsoft.Xrm.Sdk.EntityRole.Referenced, value);
                this.OnPropertyChanged("Referencedworkflow_active_workflow");
            }
        }

        /// <summary>
        /// 1:N Workflow_Annotation
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Workflow_Annotation")]
        public System.Collections.Generic.IEnumerable<Annotation> Workflow_Annotation
        {
            get { return this.GetRelatedEntities<Annotation>("Workflow_Annotation", null); }
            set
            {
                this.OnPropertyChanging("Workflow_Annotation");
                this.SetRelatedEntities<Annotation>("Workflow_Annotation", null, value);
                this.OnPropertyChanged("Workflow_Annotation");
            }
        }

        /// <summary>
        /// 1:N workflow_dependencies
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("workflow_dependencies")]
        public System.Collections.Generic.IEnumerable<WorkflowDependency> workflow_dependencies
        {
            get { return this.GetRelatedEntities<WorkflowDependency>("workflow_dependencies", null); }
            set
            {
                this.OnPropertyChanging("workflow_dependencies");
                this.SetRelatedEntities<WorkflowDependency>("workflow_dependencies", null, value);
                this.OnPropertyChanged("workflow_dependencies");
            }
        }

        /// <summary>
        /// 1:N workflow_parent_workflow
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("workflow_parent_workflow", Microsoft.Xrm.Sdk.EntityRole.Referenced)]
        public System.Collections.Generic.IEnumerable<Workflow> Referencedworkflow_parent_workflow
        {
            get { return this.GetRelatedEntities<Workflow>("workflow_parent_workflow", Microsoft.Xrm.Sdk.EntityRole.Referenced); }
            set
            {
                this.OnPropertyChanging("Referencedworkflow_parent_workflow");
                this.SetRelatedEntities<Workflow>("workflow_parent_workflow", Microsoft.Xrm.Sdk.EntityRole.Referenced, value);
                this.OnPropertyChanged("Referencedworkflow_parent_workflow");
            }
        }

        /// <summary>
        /// 1:N Workflow_routingrule
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Workflow_routingrule")]
        public System.Collections.Generic.IEnumerable<RoutingRule> Workflow_routingrule
        {
            get { return this.GetRelatedEntities<RoutingRule>("Workflow_routingrule", null); }
            set
            {
                this.OnPropertyChanging("Workflow_routingrule");
                this.SetRelatedEntities<RoutingRule>("Workflow_routingrule", null, value);
                this.OnPropertyChanged("Workflow_routingrule");
            }
        }

        /// <summary>
        /// 1:N workflowid_convertrule
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("workflowid_convertrule")]
        public System.Collections.Generic.IEnumerable<ConvertRule> workflowid_convertrule
        {
            get { return this.GetRelatedEntities<ConvertRule>("workflowid_convertrule", null); }
            set
            {
                this.OnPropertyChanging("workflowid_convertrule");
                this.SetRelatedEntities<ConvertRule>("workflowid_convertrule", null, value);
                this.OnPropertyChanged("workflowid_convertrule");
            }
        }

        /// <summary>
        /// N:1 business_unit_workflow
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_workflow")]
        public BusinessUnit business_unit_workflow
        {
            get { return this.GetRelatedEntity<BusinessUnit>("business_unit_workflow", null); }
        }

        /// <summary>
        /// N:1 system_user_workflow
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("system_user_workflow")]
        public SystemUser system_user_workflow
        {
            get { return this.GetRelatedEntity<SystemUser>("system_user_workflow", null); }
        }

        /// <summary>
        /// N:1 team_workflow
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_workflow")]
        public Team team_workflow
        {
            get { return this.GetRelatedEntity<Team>("team_workflow", null); }
        }

        /// <summary>
        /// N:1 workflow_active_workflow
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("activeworkflowid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("workflow_active_workflow", Microsoft.Xrm.Sdk.EntityRole.Referencing)]
        public Workflow Referencingworkflow_active_workflow
        {
            get { return this.GetRelatedEntity<Workflow>("workflow_active_workflow", Microsoft.Xrm.Sdk.EntityRole.Referencing); }
        }

        /// <summary>
        /// N:1 workflow_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("workflow_createdby")]
        public SystemUser workflow_createdby
        {
            get { return this.GetRelatedEntity<SystemUser>("workflow_createdby", null); }
        }

        /// <summary>
        /// N:1 workflow_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("workflow_createdonbehalfby")]
        public SystemUser workflow_createdonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("workflow_createdonbehalfby", null); }
        }

        /// <summary>
        /// N:1 workflow_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("workflow_modifiedby")]
        public SystemUser workflow_modifiedby
        {
            get { return this.GetRelatedEntity<SystemUser>("workflow_modifiedby", null); }
        }

        /// <summary>
        /// N:1 workflow_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("workflow_modifiedonbehalfby")]
        public SystemUser workflow_modifiedonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("workflow_modifiedonbehalfby", null); }
        }

        /// <summary>
        /// N:1 workflow_parent_workflow
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("parentworkflowid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("workflow_parent_workflow", Microsoft.Xrm.Sdk.EntityRole.Referencing)]
        public Workflow Referencingworkflow_parent_workflow
        {
            get { return this.GetRelatedEntity<Workflow>("workflow_parent_workflow", Microsoft.Xrm.Sdk.EntityRole.Referencing); }
        }
    }
}