namespace __4_DAL_CRM
{
    /// <summary>
    /// Saved database query that is owned by a user.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("userquery")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class UserQuery : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public UserQuery() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "userquery";

        public const int EntityTypeCode = 4230;

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
        /// Type the column name that will be used to group the results from the data collected across multiple records from a user view.
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
        /// Shows the columns and sorting criteria for the saved view, stored in XML format.
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
        /// Type information about how the items in the user view are formatted.
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
        /// Type additional information to describe the saved view, such as the filter criteria or intended results set.
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
        /// Contains the Fetch XML query that defines the entities and attributes included in the saved view.
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
        /// Type a descriptive name for the saved view.
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
        /// Shows the business unit that the record owner belongs to.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
        public Microsoft.Xrm.Sdk.EntityReference OwningBusinessUnit
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningbusinessunit"); }
        }

        /// <summary>
        /// Unique identifier of the team who owns this saved view.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
        public Microsoft.Xrm.Sdk.EntityReference OwningTeam
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningteam"); }
        }

        /// <summary>
        /// Unique identifier of the user who owns this saved view.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
        public Microsoft.Xrm.Sdk.EntityReference OwningUser
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owninguser"); }
        }

        /// <summary>
        /// Choose the ID of the saved query that the record was created from.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("parentqueryid")]
        public Microsoft.Xrm.Sdk.EntityReference ParentQueryId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("parentqueryid"); }
            set
            {
                this.OnPropertyChanging("ParentQueryId");
                this.SetAttributeValue("parentqueryid", value);
                this.OnPropertyChanged("ParentQueryId");
            }
        }

        /// <summary>
        /// Shows the code for the query type to indicate whether the saved view is an address book filter, advanced search, or other view.
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
        /// Type of entity that the saved view displays.
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
        /// Shows whether the saved view is active or inactive.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
        public System.Nullable<UserQueryState> StateCode
        {
            get
            {
                Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
                if ((optionSet != null))
                {
                    return ((UserQueryState) (System.Enum.ToObject(typeof(UserQueryState), optionSet.Value)));
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// Select the item's status.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statuscode")]
        public Microsoft.Xrm.Sdk.OptionSetValue StatusCode
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statuscode"); }
        }

        /// <summary>
        /// Unique identifier of the saved view.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("userqueryid")]
        public System.Nullable<System.Guid> UserQueryId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("userqueryid"); }
            set
            {
                this.OnPropertyChanging("UserQueryId");
                this.SetAttributeValue("userqueryid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("UserQueryId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("userqueryid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.UserQueryId = value; }
        }

        /// <summary>
        /// Version number of the saved view.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
        public System.Nullable<long> VersionNumber
        {
            get { return this.GetAttributeValue<System.Nullable<long>>("versionnumber"); }
        }

        /// <summary>
        /// 1:N userentityinstancedata_userquery
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_userquery")]
        public System.Collections.Generic.IEnumerable<UserEntityInstanceData> userentityinstancedata_userquery
        {
            get { return this.GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_userquery", null); }
            set
            {
                this.OnPropertyChanging("userentityinstancedata_userquery");
                this.SetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_userquery", null, value);
                this.OnPropertyChanged("userentityinstancedata_userquery");
            }
        }

        /// <summary>
        /// 1:N UserQuery_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("UserQuery_AsyncOperations")]
        public System.Collections.Generic.IEnumerable<AsyncOperation> UserQuery_AsyncOperations
        {
            get { return this.GetRelatedEntities<AsyncOperation>("UserQuery_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("UserQuery_AsyncOperations");
                this.SetRelatedEntities<AsyncOperation>("UserQuery_AsyncOperations", null, value);
                this.OnPropertyChanged("UserQuery_AsyncOperations");
            }
        }

        /// <summary>
        /// 1:N UserQuery_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("UserQuery_BulkDeleteFailures")]
        public System.Collections.Generic.IEnumerable<BulkDeleteFailure> UserQuery_BulkDeleteFailures
        {
            get { return this.GetRelatedEntities<BulkDeleteFailure>("UserQuery_BulkDeleteFailures", null); }
            set
            {
                this.OnPropertyChanging("UserQuery_BulkDeleteFailures");
                this.SetRelatedEntities<BulkDeleteFailure>("UserQuery_BulkDeleteFailures", null, value);
                this.OnPropertyChanged("UserQuery_BulkDeleteFailures");
            }
        }

        /// <summary>
        /// N:1 business_unit_userquery
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_userquery")]
        public BusinessUnit business_unit_userquery
        {
            get { return this.GetRelatedEntity<BusinessUnit>("business_unit_userquery", null); }
        }

        /// <summary>
        /// N:1 lk_userquery_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_userquery_createdby")]
        public SystemUser lk_userquery_createdby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_userquery_createdby", null); }
        }

        /// <summary>
        /// N:1 lk_userquery_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_userquery_createdonbehalfby")]
        public SystemUser lk_userquery_createdonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_userquery_createdonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_userquery_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_userquery_modifiedby")]
        public SystemUser lk_userquery_modifiedby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_userquery_modifiedby", null); }
        }

        /// <summary>
        /// N:1 lk_userquery_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_userquery_modifiedonbehalfby")]
        public SystemUser lk_userquery_modifiedonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_userquery_modifiedonbehalfby", null); }
        }

        /// <summary>
        /// N:1 team_userquery
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_userquery")]
        public Team team_userquery
        {
            get { return this.GetRelatedEntity<Team>("team_userquery", null); }
        }

        /// <summary>
        /// N:1 user_userquery
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_userquery")]
        public SystemUser user_userquery
        {
            get { return this.GetRelatedEntity<SystemUser>("user_userquery", null); }
        }
    }
}