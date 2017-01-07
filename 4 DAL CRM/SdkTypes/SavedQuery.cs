namespace __4_DAL_CRM
{
    /// <summary>
    /// Saved query against the database.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("savedquery")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class SavedQuery : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public SavedQuery() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "savedquery";

        public const int EntityTypeCode = 1039;

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
        /// Type the column name that will be used to group the results from the data collected across multiple records from a system view.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("advancedgroupby")]
        public string AdvancedGroupBy
        {
            get { return this.GetAttributeValue<string>("advancedgroupby"); }
            set
            {
                this.OnPropertyChanging("AdvancedGroupBy");
                this.SetAttributeValue("advancedgroupby", value);
                this.OnPropertyChanged("AdvancedGroupBy");
            }
        }

        /// <summary>
        /// Tells whether the view can be deleted.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("canbedeleted")]
        public Microsoft.Xrm.Sdk.BooleanManagedProperty CanBeDeleted
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.BooleanManagedProperty>("canbedeleted"); }
            set
            {
                this.OnPropertyChanging("CanBeDeleted");
                this.SetAttributeValue("canbedeleted", value);
                this.OnPropertyChanged("CanBeDeleted");
            }
        }

        /// <summary>
        /// Contains the columns and sorting criteria for the view, stored in XML format.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("columnsetxml")]
        public string ColumnSetXml
        {
            get { return this.GetAttributeValue<string>("columnsetxml"); }
            set
            {
                this.OnPropertyChanging("ColumnSetXml");
                this.SetAttributeValue("columnsetxml", value);
                this.OnPropertyChanged("ColumnSetXml");
            }
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
        /// Type information about how the items in the system view are formatted.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("conditionalformatting")]
        public string ConditionalFormatting
        {
            get { return this.GetAttributeValue<string>("conditionalformatting"); }
            set
            {
                this.OnPropertyChanging("ConditionalFormatting");
                this.SetAttributeValue("conditionalformatting", value);
                this.OnPropertyChanged("ConditionalFormatting");
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
        /// Type additional information to describe the view, such as the filter criteria or intended results set.
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
        /// String specifying the query in Fetch XML language.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("fetchxml")]
        public string FetchXml
        {
            get { return this.GetAttributeValue<string>("fetchxml"); }
            set
            {
                this.OnPropertyChanging("FetchXml");
                this.SetAttributeValue("fetchxml", value);
                this.OnPropertyChanged("FetchXml");
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
        /// Tells whether the component can be customized.
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
        /// Tells whether the view is the default view for the specified record type (entity).
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isdefault")]
        public System.Nullable<bool> IsDefault
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("isdefault"); }
            set
            {
                this.OnPropertyChanging("IsDefault");
                this.SetAttributeValue("isdefault", value);
                this.OnPropertyChanged("IsDefault");
            }
        }

        /// <summary>
        /// Tells whether the record is part of a managed solution.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ismanaged")]
        public System.Nullable<bool> IsManaged
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("ismanaged"); }
        }

        /// <summary>
        /// Indicates whether or not this is viewable by the entire organization.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isprivate")]
        [System.ObsoleteAttribute()]
        public System.Nullable<bool> IsPrivate
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("isprivate"); }
        }

        /// <summary>
        /// Choose whether the view is compatible with Quick Find. When users search for specific items, you define the fields that are searched in.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isquickfindquery")]
        public System.Nullable<bool> IsQuickFindQuery
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("isquickfindquery"); }
            set
            {
                this.OnPropertyChanging("IsQuickFindQuery");
                this.SetAttributeValue("isquickfindquery", value);
                this.OnPropertyChanged("IsQuickFindQuery");
            }
        }

        /// <summary>
        /// Tells whether the view was created by a user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isuserdefined")]
        public System.Nullable<bool> IsUserDefined
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("isuserdefined"); }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("layoutxml")]
        public string LayoutXml
        {
            get { return this.GetAttributeValue<string>("layoutxml"); }
            set
            {
                this.OnPropertyChanging("LayoutXml");
                this.SetAttributeValue("layoutxml", value);
                this.OnPropertyChanged("LayoutXml");
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
        /// Type a name for the view to describe what results the view will contain. This name is visible to users in the View list.
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
        /// Choose the ID of the organization that the record is associated with.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
        public Microsoft.Xrm.Sdk.EntityReference OrganizationId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("organizationid"); }
        }

        /// <summary>
        /// For the organization, type the tab order to determine how users navigate through the screen using only the Tab key.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationtaborder")]
        public System.Nullable<int> OrganizationTabOrder
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("organizationtaborder"); }
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
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("queryapi")]
        public string QueryAPI
        {
            get { return this.GetAttributeValue<string>("queryapi"); }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("queryappusage")]
        public System.Nullable<int> QueryAppUsage
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("queryappusage"); }
            set
            {
                this.OnPropertyChanging("QueryAppUsage");
                this.SetAttributeValue("queryappusage", value);
                this.OnPropertyChanged("QueryAppUsage");
            }
        }

        /// <summary>
        /// Shows the type of the query.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("querytype")]
        public System.Nullable<int> QueryType
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("querytype"); }
            set
            {
                this.OnPropertyChanging("QueryType");
                this.SetAttributeValue("querytype", value);
                this.OnPropertyChanged("QueryType");
            }
        }

        /// <summary>
        /// Type of entity displayed in the view.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("returnedtypecode")]
        public string ReturnedTypeCode
        {
            get { return this.GetAttributeValue<string>("returnedtypecode"); }
            set
            {
                this.OnPropertyChanging("ReturnedTypeCode");
                this.SetAttributeValue("returnedtypecode", value);
                this.OnPropertyChanged("ReturnedTypeCode");
            }
        }

        /// <summary>
        /// Unique identifier of the view.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("savedqueryid")]
        public System.Nullable<System.Guid> SavedQueryId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("savedqueryid"); }
            set
            {
                this.OnPropertyChanging("SavedQueryId");
                this.SetAttributeValue("savedqueryid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("SavedQueryId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("savedqueryid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.SavedQueryId = value; }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("savedqueryidunique")]
        public System.Nullable<System.Guid> SavedQueryIdUnique
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("savedqueryidunique"); }
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
        /// Shows the status of the view.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
        public System.Nullable<SavedQueryState> StateCode
        {
            get
            {
                Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
                if ((optionSet != null))
                {
                    return ((SavedQueryState) (System.Enum.ToObject(typeof(SavedQueryState), optionSet.Value)));
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// Shows the reason code that explains the status of the record.
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
        /// Version number of the view.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
        public System.Nullable<long> VersionNumber
        {
            get { return this.GetAttributeValue<System.Nullable<long>>("versionnumber"); }
        }

        /// <summary>
        /// 1:N SavedQuery_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SavedQuery_AsyncOperations")]
        public System.Collections.Generic.IEnumerable<AsyncOperation> SavedQuery_AsyncOperations
        {
            get { return this.GetRelatedEntities<AsyncOperation>("SavedQuery_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("SavedQuery_AsyncOperations");
                this.SetRelatedEntities<AsyncOperation>("SavedQuery_AsyncOperations", null, value);
                this.OnPropertyChanged("SavedQuery_AsyncOperations");
            }
        }

        /// <summary>
        /// 1:N SavedQuery_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SavedQuery_BulkDeleteFailures")]
        public System.Collections.Generic.IEnumerable<BulkDeleteFailure> SavedQuery_BulkDeleteFailures
        {
            get { return this.GetRelatedEntities<BulkDeleteFailure>("SavedQuery_BulkDeleteFailures", null); }
            set
            {
                this.OnPropertyChanging("SavedQuery_BulkDeleteFailures");
                this.SetRelatedEntities<BulkDeleteFailure>("SavedQuery_BulkDeleteFailures", null, value);
                this.OnPropertyChanged("SavedQuery_BulkDeleteFailures");
            }
        }

        /// <summary>
        /// 1:N userentityinstancedata_savedquery
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_savedquery")]
        public System.Collections.Generic.IEnumerable<UserEntityInstanceData> userentityinstancedata_savedquery
        {
            get { return this.GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_savedquery", null); }
            set
            {
                this.OnPropertyChanging("userentityinstancedata_savedquery");
                this.SetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_savedquery", null, value);
                this.OnPropertyChanged("userentityinstancedata_savedquery");
            }
        }

        /// <summary>
        /// N:1 lk_savedquery_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_savedquery_createdonbehalfby")]
        public SystemUser lk_savedquery_createdonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_savedquery_createdonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_savedquery_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_savedquery_modifiedonbehalfby")]
        public SystemUser lk_savedquery_modifiedonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_savedquery_modifiedonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_savedquerybase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_savedquerybase_createdby")]
        public SystemUser lk_savedquerybase_createdby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_savedquerybase_createdby", null); }
        }

        /// <summary>
        /// N:1 lk_savedquerybase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_savedquerybase_modifiedby")]
        public SystemUser lk_savedquerybase_modifiedby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_savedquerybase_modifiedby", null); }
        }

        /// <summary>
        /// N:1 organization_saved_queries
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_saved_queries")]
        public Organization organization_saved_queries
        {
            get { return this.GetRelatedEntity<Organization>("organization_saved_queries", null); }
        }
    }
}