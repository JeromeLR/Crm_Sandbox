using _4_DAL_CRM;

namespace __4_DAL_CRM
{
    /// <summary>
    /// Group of existing or potential customers created for a marketing campaign or other sales purposes.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("list")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class List : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public List() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "list";

        public const int EntityTypeCode = 4300;

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
        /// Type the cost of obtaining the marketing list.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("cost")]
        public Microsoft.Xrm.Sdk.Money Cost
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("cost"); }
            set
            {
                this.OnPropertyChanging("Cost");
                this.SetAttributeValue("cost", value);
                this.OnPropertyChanged("Cost");
            }
        }

        /// <summary>
        /// Shows the Cost field converted to the system's default base currency for reporting purposes. The calculation uses the exchange rate specified in the Currencies area.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("cost_base")]
        public Microsoft.Xrm.Sdk.Money Cost_Base
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("cost_base"); }
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
        /// Select the type of members that this marketing list will contain: accounts, contacts, or leads. Each list can have only one member type and this value can't be changed after the marketing list is created.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdfromcode")]
        public Microsoft.Xrm.Sdk.OptionSetValue CreatedFromCode
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("createdfromcode"); }
            set
            {
                this.OnPropertyChanging("CreatedFromCode");
                this.SetAttributeValue("createdfromcode", value);
                this.OnPropertyChanged("CreatedFromCode");
            }
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
        /// Type additional information to describe the marketing list, such as the intended use or date of the last update.
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
        /// Select whether to override the opt-out settings on leads, contacts, and accounts for the members of the target marketing lists of the campaign activity. If No is selected, those who have chosen to opt out won't be excluded from the list. This means they will receive marketing materials.
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
        /// Select whether inactive accounts, contacts, or leads should be excluded from the campaign activity distribution when the marketing list is included in a campaign.
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
        /// Shows the date and time when the marketing list was last used in a campaign or in the creation of activities or opportunities.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("lastusedon")]
        public System.Nullable<System.DateTime> LastUsedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("lastusedon"); }
        }

        /// <summary>
        /// Unique identifier of the marketing list.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("listid")]
        public System.Nullable<System.Guid> ListId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("listid"); }
            set
            {
                this.OnPropertyChanging("ListId");
                this.SetAttributeValue("listid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("ListId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("listid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.ListId = value; }
        }

        /// <summary>
        /// Type a name for the marketing list so that it is identified correctly in lists.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("listname")]
        public string ListName
        {
            get { return this.GetAttributeValue<string>("listname"); }
            set
            {
                this.OnPropertyChanging("ListName");
                this.SetAttributeValue("listname", value);
                this.OnPropertyChanged("ListName");
            }
        }

        /// <summary>
        /// Select whether the marketing list is locked. If Yes is selected, no additional members can be added to the marketing list.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("lockstatus")]
        public System.Nullable<bool> LockStatus
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("lockstatus"); }
            set
            {
                this.OnPropertyChanging("LockStatus");
                this.SetAttributeValue("lockstatus", value);
                this.OnPropertyChanged("LockStatus");
            }
        }

        /// <summary>
        /// Shows the sum of all members in the marketing list.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("membercount")]
        public System.Nullable<int> MemberCount
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("membercount"); }
        }

        /// <summary>
        /// Type of the members that can be stored in the marketing list.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("membertype")]
        public System.Nullable<int> MemberType
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("membertype"); }
            set
            {
                this.OnPropertyChanging("MemberType");
                this.SetAttributeValue("membertype", value);
                this.OnPropertyChanged("MemberType");
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
        /// Unique identifier of the business unit that owns the marketing list.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
        public Microsoft.Xrm.Sdk.EntityReference OwningBusinessUnit
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningbusinessunit"); }
        }

        /// <summary>
        /// Unique identifier of the team who owns the marketing list.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
        public Microsoft.Xrm.Sdk.EntityReference OwningTeam
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningteam"); }
        }

        /// <summary>
        /// Unique identifier of the user who owns the marketing list.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
        public Microsoft.Xrm.Sdk.EntityReference OwningUser
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owninguser"); }
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
        /// Type the intended use of the marketing list to identify its key segments, target offers, or business group.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("purpose")]
        public string Purpose
        {
            get { return this.GetAttributeValue<string>("purpose"); }
            set
            {
                this.OnPropertyChanging("Purpose");
                this.SetAttributeValue("purpose", value);
                this.OnPropertyChanged("Purpose");
            }
        }

        /// <summary>
        /// Query used for retrieving members of marketing list.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("query")]
        public string Query
        {
            get { return this.GetAttributeValue<string>("query"); }
            set
            {
                this.OnPropertyChanging("Query");
                this.SetAttributeValue("query", value);
                this.OnPropertyChanged("Query");
            }
        }

        /// <summary>
        /// Type the source of the marketing list, such as a third-party supplier or internal database.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("source")]
        public string Source
        {
            get { return this.GetAttributeValue<string>("source"); }
            set
            {
                this.OnPropertyChanging("Source");
                this.SetAttributeValue("source", value);
                this.OnPropertyChanged("Source");
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
        /// Shows whether the marketing list is active or inactive. Inactive marketing lists are read-only and can't be edited unless they are reactivated.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
        public System.Nullable<ListState> StateCode
        {
            get
            {
                Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
                if ((optionSet != null))
                {
                    return ((ListState) (System.Enum.ToObject(typeof(ListState), optionSet.Value)));
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// Select the marketing list's status.
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
        /// Select whether you want the marketing list to be static or dynamic. The members in a static marketing list are unchanging. A dynamic marketing list is based on a dynamic query that retrieves the updated list of members
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("type")]
        public System.Nullable<bool> Type
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("type"); }
            set
            {
                this.OnPropertyChanging("Type");
                this.SetAttributeValue("type", value);
                this.OnPropertyChanged("Type");
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
        /// Version number of the marketing list.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
        public System.Nullable<long> VersionNumber
        {
            get { return this.GetAttributeValue<System.Nullable<long>>("versionnumber"); }
        }

        /// <summary>
        /// 1:N List_Annotation
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("List_Annotation")]
        public System.Collections.Generic.IEnumerable<Annotation> List_Annotation
        {
            get { return this.GetRelatedEntities<Annotation>("List_Annotation", null); }
            set
            {
                this.OnPropertyChanging("List_Annotation");
                this.SetRelatedEntities<Annotation>("List_Annotation", null, value);
                this.OnPropertyChanged("List_Annotation");
            }
        }

        /// <summary>
        /// 1:N List_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("List_AsyncOperations")]
        public System.Collections.Generic.IEnumerable<AsyncOperation> List_AsyncOperations
        {
            get { return this.GetRelatedEntities<AsyncOperation>("List_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("List_AsyncOperations");
                this.SetRelatedEntities<AsyncOperation>("List_AsyncOperations", null, value);
                this.OnPropertyChanged("List_AsyncOperations");
            }
        }

        /// <summary>
        /// 1:N List_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("List_BulkDeleteFailures")]
        public System.Collections.Generic.IEnumerable<BulkDeleteFailure> List_BulkDeleteFailures
        {
            get { return this.GetRelatedEntities<BulkDeleteFailure>("List_BulkDeleteFailures", null); }
            set
            {
                this.OnPropertyChanging("List_BulkDeleteFailures");
                this.SetRelatedEntities<BulkDeleteFailure>("List_BulkDeleteFailures", null, value);
                this.OnPropertyChanged("List_BulkDeleteFailures");
            }
        }

        /// <summary>
        /// 1:N List_BulkOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("List_BulkOperations")]
        public System.Collections.Generic.IEnumerable<BulkOperation> List_BulkOperations
        {
            get { return this.GetRelatedEntities<BulkOperation>("List_BulkOperations", null); }
            set
            {
                this.OnPropertyChanging("List_BulkOperations");
                this.SetRelatedEntities<BulkOperation>("List_BulkOperations", null, value);
                this.OnPropertyChanged("List_BulkOperations");
            }
        }

        /// <summary>
        /// 1:N list_connections1
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("list_connections1")]
        public System.Collections.Generic.IEnumerable<Connection> list_connections1
        {
            get { return this.GetRelatedEntities<Connection>("list_connections1", null); }
            set
            {
                this.OnPropertyChanging("list_connections1");
                this.SetRelatedEntities<Connection>("list_connections1", null, value);
                this.OnPropertyChanged("list_connections1");
            }
        }

        /// <summary>
        /// 1:N list_connections2
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("list_connections2")]
        public System.Collections.Generic.IEnumerable<Connection> list_connections2
        {
            get { return this.GetRelatedEntities<Connection>("list_connections2", null); }
            set
            {
                this.OnPropertyChanging("list_connections2");
                this.SetRelatedEntities<Connection>("list_connections2", null, value);
                this.OnPropertyChanged("list_connections2");
            }
        }

        /// <summary>
        /// 1:N List_DuplicateBaseRecord
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("List_DuplicateBaseRecord")]
        public System.Collections.Generic.IEnumerable<DuplicateRecord> List_DuplicateBaseRecord
        {
            get { return this.GetRelatedEntities<DuplicateRecord>("List_DuplicateBaseRecord", null); }
            set
            {
                this.OnPropertyChanging("List_DuplicateBaseRecord");
                this.SetRelatedEntities<DuplicateRecord>("List_DuplicateBaseRecord", null, value);
                this.OnPropertyChanged("List_DuplicateBaseRecord");
            }
        }

        /// <summary>
        /// 1:N List_DuplicateMatchingRecord
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("List_DuplicateMatchingRecord")]
        public System.Collections.Generic.IEnumerable<DuplicateRecord> List_DuplicateMatchingRecord
        {
            get { return this.GetRelatedEntities<DuplicateRecord>("List_DuplicateMatchingRecord", null); }
            set
            {
                this.OnPropertyChanging("List_DuplicateMatchingRecord");
                this.SetRelatedEntities<DuplicateRecord>("List_DuplicateMatchingRecord", null, value);
                this.OnPropertyChanged("List_DuplicateMatchingRecord");
            }
        }

        /// <summary>
        /// 1:N list_principalobjectattributeaccess
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("list_principalobjectattributeaccess")]
        public System.Collections.Generic.IEnumerable<PrincipalObjectAttributeAccess> list_principalobjectattributeaccess
        {
            get { return this.GetRelatedEntities<PrincipalObjectAttributeAccess>("list_principalobjectattributeaccess", null); }
            set
            {
                this.OnPropertyChanging("list_principalobjectattributeaccess");
                this.SetRelatedEntities<PrincipalObjectAttributeAccess>("list_principalobjectattributeaccess", null, value);
                this.OnPropertyChanged("list_principalobjectattributeaccess");
            }
        }

        /// <summary>
        /// 1:N List_ProcessSessions
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("List_ProcessSessions")]
        public System.Collections.Generic.IEnumerable<ProcessSession> List_ProcessSessions
        {
            get { return this.GetRelatedEntities<ProcessSession>("List_ProcessSessions", null); }
            set
            {
                this.OnPropertyChanging("List_ProcessSessions");
                this.SetRelatedEntities<ProcessSession>("List_ProcessSessions", null, value);
                this.OnPropertyChanged("List_ProcessSessions");
            }
        }

        /// <summary>
        /// 1:N userentityinstancedata_list
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_list")]
        public System.Collections.Generic.IEnumerable<UserEntityInstanceData> userentityinstancedata_list
        {
            get { return this.GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_list", null); }
            set
            {
                this.OnPropertyChanging("userentityinstancedata_list");
                this.SetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_list", null, value);
                this.OnPropertyChanged("userentityinstancedata_list");
            }
        }

        /// <summary>
        /// N:N campaignactivitylist_association
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("campaignactivitylist_association")]
        public System.Collections.Generic.IEnumerable<CampaignActivity> campaignactivitylist_association
        {
            get { return this.GetRelatedEntities<CampaignActivity>("campaignactivitylist_association", null); }
            set
            {
                this.OnPropertyChanging("campaignactivitylist_association");
                this.SetRelatedEntities<CampaignActivity>("campaignactivitylist_association", null, value);
                this.OnPropertyChanged("campaignactivitylist_association");
            }
        }

        /// <summary>
        /// N:N campaignlist_association
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("campaignlist_association")]
        public System.Collections.Generic.IEnumerable<Campaign> campaignlist_association
        {
            get { return this.GetRelatedEntities<Campaign>("campaignlist_association", null); }
            set
            {
                this.OnPropertyChanging("campaignlist_association");
                this.SetRelatedEntities<Campaign>("campaignlist_association", null, value);
                this.OnPropertyChanged("campaignlist_association");
            }
        }

        /// <summary>
        /// N:N listaccount_association
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("listaccount_association")]
        public System.Collections.Generic.IEnumerable<Account> listaccount_association
        {
            get { return this.GetRelatedEntities<Account>("listaccount_association", null); }
            set
            {
                this.OnPropertyChanging("listaccount_association");
                this.SetRelatedEntities<Account>("listaccount_association", null, value);
                this.OnPropertyChanged("listaccount_association");
            }
        }

        /// <summary>
        /// N:N listcontact_association
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("listcontact_association")]
        public System.Collections.Generic.IEnumerable<Contact> listcontact_association
        {
            get { return this.GetRelatedEntities<Contact>("listcontact_association", null); }
            set
            {
                this.OnPropertyChanging("listcontact_association");
                this.SetRelatedEntities<Contact>("listcontact_association", null, value);
                this.OnPropertyChanged("listcontact_association");
            }
        }

        /// <summary>
        /// N:N listlead_association
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("listlead_association")]
        public System.Collections.Generic.IEnumerable<Lead> listlead_association
        {
            get { return this.GetRelatedEntities<Lead>("listlead_association", null); }
            set
            {
                this.OnPropertyChanging("listlead_association");
                this.SetRelatedEntities<Lead>("listlead_association", null, value);
                this.OnPropertyChanged("listlead_association");
            }
        }

        /// <summary>
        /// N:1 business_unit_list
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_list")]
        public BusinessUnit business_unit_list
        {
            get { return this.GetRelatedEntity<BusinessUnit>("business_unit_list", null); }
        }

        /// <summary>
        /// N:1 lk_list_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_list_createdby")]
        public SystemUser lk_list_createdby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_list_createdby", null); }
        }

        /// <summary>
        /// N:1 lk_list_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_list_createdonbehalfby")]
        public SystemUser lk_list_createdonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_list_createdonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_list_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_list_modifiedby")]
        public SystemUser lk_list_modifiedby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_list_modifiedby", null); }
        }

        /// <summary>
        /// N:1 lk_list_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_list_modifiedonbehalfby")]
        public SystemUser lk_list_modifiedonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_list_modifiedonbehalfby", null); }
        }

        /// <summary>
        /// N:1 processstage_lists
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("stageid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("processstage_lists")]
        public ProcessStage processstage_lists
        {
            get { return this.GetRelatedEntity<ProcessStage>("processstage_lists", null); }
            set
            {
                this.OnPropertyChanging("processstage_lists");
                this.SetRelatedEntity<ProcessStage>("processstage_lists", null, value);
                this.OnPropertyChanged("processstage_lists");
            }
        }

        /// <summary>
        /// N:1 team_list
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_list")]
        public Team team_list
        {
            get { return this.GetRelatedEntity<Team>("team_list", null); }
        }

        /// <summary>
        /// N:1 transactioncurrency_list
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("transactioncurrency_list")]
        public TransactionCurrency transactioncurrency_list
        {
            get { return this.GetRelatedEntity<TransactionCurrency>("transactioncurrency_list", null); }
            set
            {
                this.OnPropertyChanging("transactioncurrency_list");
                this.SetRelatedEntity<TransactionCurrency>("transactioncurrency_list", null, value);
                this.OnPropertyChanged("transactioncurrency_list");
            }
        }

        /// <summary>
        /// N:1 user_list
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_list")]
        public SystemUser user_list
        {
            get { return this.GetRelatedEntity<SystemUser>("user_list", null); }
        }
    }
}