using _4_DAL_CRM;

namespace __4_DAL_CRM
{
    /// <summary>
    /// Collection of system users that routinely collaborate. Teams can be used to simplify record sharing and provide team members with common access to organization data when team members belong to different Business Units.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("team")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class Team : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public Team() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "team";

        public const int EntityTypeCode = 9;

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
        /// Unique identifier of the user primary responsible for the team.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("administratorid")]
        public Microsoft.Xrm.Sdk.EntityReference AdministratorId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("administratorid"); }
            set
            {
                this.OnPropertyChanging("AdministratorId");
                this.SetAttributeValue("administratorid", value);
                this.OnPropertyChanged("AdministratorId");
            }
        }

        /// <summary>
        /// Unique identifier of the business unit with which the team is associated.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("businessunitid")]
        public Microsoft.Xrm.Sdk.EntityReference BusinessUnitId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("businessunitid"); }
            set
            {
                this.OnPropertyChanging("BusinessUnitId");
                this.SetAttributeValue("businessunitid", value);
                this.OnPropertyChanged("BusinessUnitId");
            }
        }

        /// <summary>
        /// Unique identifier of the user who created the team.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby"); }
        }

        /// <summary>
        /// Date and time when the team was created.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
        public System.Nullable<System.DateTime> CreatedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who created the team.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        /// Description of the team.
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
        /// Email address for the team.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("emailaddress")]
        public string EMailAddress
        {
            get { return this.GetAttributeValue<string>("emailaddress"); }
            set
            {
                this.OnPropertyChanging("EMailAddress");
                this.SetAttributeValue("emailaddress", value);
                this.OnPropertyChanged("EMailAddress");
            }
        }

        /// <summary>
        /// Exchange rate for the currency associated with the team with respect to the base currency.
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
        /// Information about whether the team is a default business unit team.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isdefault")]
        public System.Nullable<bool> IsDefault
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("isdefault"); }
        }

        /// <summary>
        /// Unique identifier of the user who last modified the team.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby"); }
        }

        /// <summary>
        /// Date and time when the team was last modified.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
        public System.Nullable<System.DateTime> ModifiedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who last modified the team.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        /// Name of the team.
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
        /// Unique identifier of the organization associated with the team.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
        public System.Nullable<System.Guid> OrganizationId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("organizationid"); }
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
        /// Unique identifier of the default queue for the team.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("queueid")]
        public Microsoft.Xrm.Sdk.EntityReference QueueId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("queueid"); }
            set
            {
                this.OnPropertyChanging("QueueId");
                this.SetAttributeValue("queueid", value);
                this.OnPropertyChanged("QueueId");
            }
        }

        /// <summary>
        /// Choose the record that the team relates to.
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
        /// Select whether the team will be managed by the system.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("systemmanaged")]
        public System.Nullable<bool> SystemManaged
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("systemmanaged"); }
        }

        /// <summary>
        /// Unique identifier for the team.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("teamid")]
        public System.Nullable<System.Guid> TeamId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("teamid"); }
            set
            {
                this.OnPropertyChanging("TeamId");
                this.SetAttributeValue("teamid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("TeamId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("teamid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.TeamId = value; }
        }

        /// <summary>
        /// Shows the team template that is associated with the team.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("teamtemplateid")]
        public Microsoft.Xrm.Sdk.EntityReference TeamTemplateId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("teamtemplateid"); }
            set
            {
                this.OnPropertyChanging("TeamTemplateId");
                this.SetAttributeValue("teamtemplateid", value);
                this.OnPropertyChanged("TeamTemplateId");
            }
        }

        /// <summary>
        /// Select the team type.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("teamtype")]
        public Microsoft.Xrm.Sdk.OptionSetValue TeamType
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("teamtype"); }
            set
            {
                this.OnPropertyChanging("TeamType");
                this.SetAttributeValue("teamtype", value);
                this.OnPropertyChanged("TeamType");
            }
        }

        /// <summary>
        /// Unique identifier of the currency associated with the team.
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
        /// Version number of the team.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
        public System.Nullable<long> VersionNumber
        {
            get { return this.GetAttributeValue<System.Nullable<long>>("versionnumber"); }
        }

        /// <summary>
        /// Pronunciation of the full name of the team, written in phonetic hiragana or katakana characters.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("yominame")]
        public string YomiName
        {
            get { return this.GetAttributeValue<string>("yominame"); }
            set
            {
                this.OnPropertyChanging("YomiName");
                this.SetAttributeValue("yominame", value);
                this.OnPropertyChanged("YomiName");
            }
        }

        /// <summary>
        /// 1:N ImportFile_Team
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ImportFile_Team")]
        public System.Collections.Generic.IEnumerable<ImportFile> ImportFile_Team
        {
            get { return this.GetRelatedEntities<ImportFile>("ImportFile_Team", null); }
            set
            {
                this.OnPropertyChanging("ImportFile_Team");
                this.SetRelatedEntities<ImportFile>("ImportFile_Team", null, value);
                this.OnPropertyChanged("ImportFile_Team");
            }
        }

        /// <summary>
        /// 1:N lead_owning_team
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lead_owning_team")]
        public System.Collections.Generic.IEnumerable<Lead> lead_owning_team
        {
            get { return this.GetRelatedEntities<Lead>("lead_owning_team", null); }
            set
            {
                this.OnPropertyChanging("lead_owning_team");
                this.SetRelatedEntities<Lead>("lead_owning_team", null, value);
                this.OnPropertyChanged("lead_owning_team");
            }
        }

        /// <summary>
        /// 1:N OwningTeam_postfollows
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("OwningTeam_postfollows")]
        public System.Collections.Generic.IEnumerable<PostFollow> OwningTeam_postfollows
        {
            get { return this.GetRelatedEntities<PostFollow>("OwningTeam_postfollows", null); }
            set
            {
                this.OnPropertyChanging("OwningTeam_postfollows");
                this.SetRelatedEntities<PostFollow>("OwningTeam_postfollows", null, value);
                this.OnPropertyChanged("OwningTeam_postfollows");
            }
        }

        /// <summary>
        /// 1:N team_accounts
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_accounts")]
        public System.Collections.Generic.IEnumerable<Account> team_accounts
        {
            get { return this.GetRelatedEntities<Account>("team_accounts", null); }
            set
            {
                this.OnPropertyChanging("team_accounts");
                this.SetRelatedEntities<Account>("team_accounts", null, value);
                this.OnPropertyChanged("team_accounts");
            }
        }

        /// <summary>
        /// 1:N team_activity
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_activity")]
        public System.Collections.Generic.IEnumerable<ActivityPointer> team_activity
        {
            get { return this.GetRelatedEntities<ActivityPointer>("team_activity", null); }
            set
            {
                this.OnPropertyChanging("team_activity");
                this.SetRelatedEntities<ActivityPointer>("team_activity", null, value);
                this.OnPropertyChanged("team_activity");
            }
        }

        /// <summary>
        /// 1:N team_annotations
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_annotations")]
        public System.Collections.Generic.IEnumerable<Annotation> team_annotations
        {
            get { return this.GetRelatedEntities<Annotation>("team_annotations", null); }
            set
            {
                this.OnPropertyChanging("team_annotations");
                this.SetRelatedEntities<Annotation>("team_annotations", null, value);
                this.OnPropertyChanged("team_annotations");
            }
        }

        /// <summary>
        /// 1:N team_appointment
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_appointment")]
        public System.Collections.Generic.IEnumerable<Appointment> team_appointment
        {
            get { return this.GetRelatedEntities<Appointment>("team_appointment", null); }
            set
            {
                this.OnPropertyChanging("team_appointment");
                this.SetRelatedEntities<Appointment>("team_appointment", null, value);
                this.OnPropertyChanged("team_appointment");
            }
        }

        /// <summary>
        /// 1:N team_asyncoperation
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_asyncoperation")]
        public System.Collections.Generic.IEnumerable<AsyncOperation> team_asyncoperation
        {
            get { return this.GetRelatedEntities<AsyncOperation>("team_asyncoperation", null); }
            set
            {
                this.OnPropertyChanging("team_asyncoperation");
                this.SetRelatedEntities<AsyncOperation>("team_asyncoperation", null, value);
                this.OnPropertyChanged("team_asyncoperation");
            }
        }

        /// <summary>
        /// 1:N Team_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Team_AsyncOperations")]
        public System.Collections.Generic.IEnumerable<AsyncOperation> Team_AsyncOperations
        {
            get { return this.GetRelatedEntities<AsyncOperation>("Team_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("Team_AsyncOperations");
                this.SetRelatedEntities<AsyncOperation>("Team_AsyncOperations", null, value);
                this.OnPropertyChanged("Team_AsyncOperations");
            }
        }

        /// <summary>
        /// 1:N Team_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Team_BulkDeleteFailures")]
        public System.Collections.Generic.IEnumerable<BulkDeleteFailure> Team_BulkDeleteFailures
        {
            get { return this.GetRelatedEntities<BulkDeleteFailure>("Team_BulkDeleteFailures", null); }
            set
            {
                this.OnPropertyChanging("Team_BulkDeleteFailures");
                this.SetRelatedEntities<BulkDeleteFailure>("Team_BulkDeleteFailures", null, value);
                this.OnPropertyChanged("Team_BulkDeleteFailures");
            }
        }

        /// <summary>
        /// 1:N team_BulkOperation
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_BulkOperation")]
        public System.Collections.Generic.IEnumerable<BulkOperation> team_BulkOperation
        {
            get { return this.GetRelatedEntities<BulkOperation>("team_BulkOperation", null); }
            set
            {
                this.OnPropertyChanging("team_BulkOperation");
                this.SetRelatedEntities<BulkOperation>("team_BulkOperation", null, value);
                this.OnPropertyChanged("team_BulkOperation");
            }
        }

        /// <summary>
        /// 1:N team_campaignactivity
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_campaignactivity")]
        public System.Collections.Generic.IEnumerable<CampaignActivity> team_campaignactivity
        {
            get { return this.GetRelatedEntities<CampaignActivity>("team_campaignactivity", null); }
            set
            {
                this.OnPropertyChanging("team_campaignactivity");
                this.SetRelatedEntities<CampaignActivity>("team_campaignactivity", null, value);
                this.OnPropertyChanged("team_campaignactivity");
            }
        }

        /// <summary>
        /// 1:N team_campaignresponse
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_campaignresponse")]
        public System.Collections.Generic.IEnumerable<CampaignResponse> team_campaignresponse
        {
            get { return this.GetRelatedEntities<CampaignResponse>("team_campaignresponse", null); }
            set
            {
                this.OnPropertyChanging("team_campaignresponse");
                this.SetRelatedEntities<CampaignResponse>("team_campaignresponse", null, value);
                this.OnPropertyChanged("team_campaignresponse");
            }
        }

        /// <summary>
        /// 1:N team_Campaigns
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_Campaigns")]
        public System.Collections.Generic.IEnumerable<Campaign> team_Campaigns
        {
            get { return this.GetRelatedEntities<Campaign>("team_Campaigns", null); }
            set
            {
                this.OnPropertyChanging("team_Campaigns");
                this.SetRelatedEntities<Campaign>("team_Campaigns", null, value);
                this.OnPropertyChanged("team_Campaigns");
            }
        }

        /// <summary>
        /// 1:N team_connections1
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_connections1")]
        public System.Collections.Generic.IEnumerable<Connection> team_connections1
        {
            get { return this.GetRelatedEntities<Connection>("team_connections1", null); }
            set
            {
                this.OnPropertyChanging("team_connections1");
                this.SetRelatedEntities<Connection>("team_connections1", null, value);
                this.OnPropertyChanged("team_connections1");
            }
        }

        /// <summary>
        /// 1:N team_connections2
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_connections2")]
        public System.Collections.Generic.IEnumerable<Connection> team_connections2
        {
            get { return this.GetRelatedEntities<Connection>("team_connections2", null); }
            set
            {
                this.OnPropertyChanging("team_connections2");
                this.SetRelatedEntities<Connection>("team_connections2", null, value);
                this.OnPropertyChanged("team_connections2");
            }
        }

        /// <summary>
        /// 1:N team_contacts
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_contacts")]
        public System.Collections.Generic.IEnumerable<Contact> team_contacts
        {
            get { return this.GetRelatedEntities<Contact>("team_contacts", null); }
            set
            {
                this.OnPropertyChanging("team_contacts");
                this.SetRelatedEntities<Contact>("team_contacts", null, value);
                this.OnPropertyChanged("team_contacts");
            }
        }

        /// <summary>
        /// 1:N team_convertrule
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_convertrule")]
        public System.Collections.Generic.IEnumerable<ConvertRule> team_convertrule
        {
            get { return this.GetRelatedEntities<ConvertRule>("team_convertrule", null); }
            set
            {
                this.OnPropertyChanging("team_convertrule");
                this.SetRelatedEntities<ConvertRule>("team_convertrule", null, value);
                this.OnPropertyChanged("team_convertrule");
            }
        }

        /// <summary>
        /// 1:N team_customer_opportunity_roles
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_customer_opportunity_roles")]
        public System.Collections.Generic.IEnumerable<CustomerOpportunityRole> team_customer_opportunity_roles
        {
            get { return this.GetRelatedEntities<CustomerOpportunityRole>("team_customer_opportunity_roles", null); }
            set
            {
                this.OnPropertyChanging("team_customer_opportunity_roles");
                this.SetRelatedEntities<CustomerOpportunityRole>("team_customer_opportunity_roles", null, value);
                this.OnPropertyChanged("team_customer_opportunity_roles");
            }
        }

        /// <summary>
        /// 1:N team_customer_relationship
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_customer_relationship")]
        public System.Collections.Generic.IEnumerable<CustomerRelationship> team_customer_relationship
        {
            get { return this.GetRelatedEntities<CustomerRelationship>("team_customer_relationship", null); }
            set
            {
                this.OnPropertyChanging("team_customer_relationship");
                this.SetRelatedEntities<CustomerRelationship>("team_customer_relationship", null, value);
                this.OnPropertyChanged("team_customer_relationship");
            }
        }

        /// <summary>
        /// 1:N Team_DuplicateBaseRecord
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Team_DuplicateBaseRecord")]
        public System.Collections.Generic.IEnumerable<DuplicateRecord> Team_DuplicateBaseRecord
        {
            get { return this.GetRelatedEntities<DuplicateRecord>("Team_DuplicateBaseRecord", null); }
            set
            {
                this.OnPropertyChanging("Team_DuplicateBaseRecord");
                this.SetRelatedEntities<DuplicateRecord>("Team_DuplicateBaseRecord", null, value);
                this.OnPropertyChanged("Team_DuplicateBaseRecord");
            }
        }

        /// <summary>
        /// 1:N Team_DuplicateMatchingRecord
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Team_DuplicateMatchingRecord")]
        public System.Collections.Generic.IEnumerable<DuplicateRecord> Team_DuplicateMatchingRecord
        {
            get { return this.GetRelatedEntities<DuplicateRecord>("Team_DuplicateMatchingRecord", null); }
            set
            {
                this.OnPropertyChanging("Team_DuplicateMatchingRecord");
                this.SetRelatedEntities<DuplicateRecord>("Team_DuplicateMatchingRecord", null, value);
                this.OnPropertyChanged("Team_DuplicateMatchingRecord");
            }
        }

        /// <summary>
        /// 1:N team_DuplicateRules
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_DuplicateRules")]
        public System.Collections.Generic.IEnumerable<DuplicateRule> team_DuplicateRules
        {
            get { return this.GetRelatedEntities<DuplicateRule>("team_DuplicateRules", null); }
            set
            {
                this.OnPropertyChanging("team_DuplicateRules");
                this.SetRelatedEntities<DuplicateRule>("team_DuplicateRules", null, value);
                this.OnPropertyChanged("team_DuplicateRules");
            }
        }

        /// <summary>
        /// 1:N team_DynamicPropertyInstance
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_DynamicPropertyInstance")]
        public System.Collections.Generic.IEnumerable<DynamicPropertyInstance> team_DynamicPropertyInstance
        {
            get { return this.GetRelatedEntities<DynamicPropertyInstance>("team_DynamicPropertyInstance", null); }
            set
            {
                this.OnPropertyChanging("team_DynamicPropertyInstance");
                this.SetRelatedEntities<DynamicPropertyInstance>("team_DynamicPropertyInstance", null, value);
                this.OnPropertyChanged("team_DynamicPropertyInstance");
            }
        }

        /// <summary>
        /// 1:N team_email
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_email")]
        public System.Collections.Generic.IEnumerable<Email> team_email
        {
            get { return this.GetRelatedEntities<Email>("team_email", null); }
            set
            {
                this.OnPropertyChanging("team_email");
                this.SetRelatedEntities<Email>("team_email", null, value);
                this.OnPropertyChanged("team_email");
            }
        }

        /// <summary>
        /// 1:N team_email_templates
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_email_templates")]
        public System.Collections.Generic.IEnumerable<Template> team_email_templates
        {
            get { return this.GetRelatedEntities<Template>("team_email_templates", null); }
            set
            {
                this.OnPropertyChanging("team_email_templates");
                this.SetRelatedEntities<Template>("team_email_templates", null, value);
                this.OnPropertyChanged("team_email_templates");
            }
        }

        /// <summary>
        /// 1:N team_emailserverprofile
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_emailserverprofile")]
        public System.Collections.Generic.IEnumerable<EmailServerProfile> team_emailserverprofile
        {
            get { return this.GetRelatedEntities<EmailServerProfile>("team_emailserverprofile", null); }
            set
            {
                this.OnPropertyChanging("team_emailserverprofile");
                this.SetRelatedEntities<EmailServerProfile>("team_emailserverprofile", null, value);
                this.OnPropertyChanged("team_emailserverprofile");
            }
        }

        /// <summary>
        /// 1:N team_entitlement
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_entitlement")]
        public System.Collections.Generic.IEnumerable<Entitlement> team_entitlement
        {
            get { return this.GetRelatedEntities<Entitlement>("team_entitlement", null); }
            set
            {
                this.OnPropertyChanging("team_entitlement");
                this.SetRelatedEntities<Entitlement>("team_entitlement", null, value);
                this.OnPropertyChanged("team_entitlement");
            }
        }

        /// <summary>
        /// 1:N team_exchangesyncidmapping
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_exchangesyncidmapping")]
        public System.Collections.Generic.IEnumerable<ExchangeSyncIdMapping> team_exchangesyncidmapping
        {
            get { return this.GetRelatedEntities<ExchangeSyncIdMapping>("team_exchangesyncidmapping", null); }
            set
            {
                this.OnPropertyChanging("team_exchangesyncidmapping");
                this.SetRelatedEntities<ExchangeSyncIdMapping>("team_exchangesyncidmapping", null, value);
                this.OnPropertyChanged("team_exchangesyncidmapping");
            }
        }

        /// <summary>
        /// 1:N team_fax
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_fax")]
        public System.Collections.Generic.IEnumerable<Fax> team_fax
        {
            get { return this.GetRelatedEntities<Fax>("team_fax", null); }
            set
            {
                this.OnPropertyChanging("team_fax");
                this.SetRelatedEntities<Fax>("team_fax", null, value);
                this.OnPropertyChanged("team_fax");
            }
        }

        /// <summary>
        /// 1:N team_goal
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_goal")]
        public System.Collections.Generic.IEnumerable<Goal> team_goal
        {
            get { return this.GetRelatedEntities<Goal>("team_goal", null); }
            set
            {
                this.OnPropertyChanging("team_goal");
                this.SetRelatedEntities<Goal>("team_goal", null, value);
                this.OnPropertyChanged("team_goal");
            }
        }

        /// <summary>
        /// 1:N team_goal_goalowner
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_goal_goalowner")]
        public System.Collections.Generic.IEnumerable<Goal> team_goal_goalowner
        {
            get { return this.GetRelatedEntities<Goal>("team_goal_goalowner", null); }
            set
            {
                this.OnPropertyChanging("team_goal_goalowner");
                this.SetRelatedEntities<Goal>("team_goal_goalowner", null, value);
                this.OnPropertyChanged("team_goal_goalowner");
            }
        }

        /// <summary>
        /// 1:N team_goalrollupquery
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_goalrollupquery")]
        public System.Collections.Generic.IEnumerable<GoalRollupQuery> team_goalrollupquery
        {
            get { return this.GetRelatedEntities<GoalRollupQuery>("team_goalrollupquery", null); }
            set
            {
                this.OnPropertyChanging("team_goalrollupquery");
                this.SetRelatedEntities<GoalRollupQuery>("team_goalrollupquery", null, value);
                this.OnPropertyChanged("team_goalrollupquery");
            }
        }

        /// <summary>
        /// 1:N team_ImportFiles
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_ImportFiles")]
        public System.Collections.Generic.IEnumerable<ImportFile> team_ImportFiles
        {
            get { return this.GetRelatedEntities<ImportFile>("team_ImportFiles", null); }
            set
            {
                this.OnPropertyChanging("team_ImportFiles");
                this.SetRelatedEntities<ImportFile>("team_ImportFiles", null, value);
                this.OnPropertyChanged("team_ImportFiles");
            }
        }

        /// <summary>
        /// 1:N team_ImportLogs
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_ImportLogs")]
        public System.Collections.Generic.IEnumerable<ImportLog> team_ImportLogs
        {
            get { return this.GetRelatedEntities<ImportLog>("team_ImportLogs", null); }
            set
            {
                this.OnPropertyChanging("team_ImportLogs");
                this.SetRelatedEntities<ImportLog>("team_ImportLogs", null, value);
                this.OnPropertyChanged("team_ImportLogs");
            }
        }

        /// <summary>
        /// 1:N team_ImportMaps
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_ImportMaps")]
        public System.Collections.Generic.IEnumerable<ImportMap> team_ImportMaps
        {
            get { return this.GetRelatedEntities<ImportMap>("team_ImportMaps", null); }
            set
            {
                this.OnPropertyChanging("team_ImportMaps");
                this.SetRelatedEntities<ImportMap>("team_ImportMaps", null, value);
                this.OnPropertyChanged("team_ImportMaps");
            }
        }

        /// <summary>
        /// 1:N team_Imports
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_Imports")]
        public System.Collections.Generic.IEnumerable<Import> team_Imports
        {
            get { return this.GetRelatedEntities<Import>("team_Imports", null); }
            set
            {
                this.OnPropertyChanging("team_Imports");
                this.SetRelatedEntities<Import>("team_Imports", null, value);
                this.OnPropertyChanged("team_Imports");
            }
        }

        /// <summary>
        /// 1:N team_incidentresolution
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_incidentresolution")]
        public System.Collections.Generic.IEnumerable<IncidentResolution> team_incidentresolution
        {
            get { return this.GetRelatedEntities<IncidentResolution>("team_incidentresolution", null); }
            set
            {
                this.OnPropertyChanging("team_incidentresolution");
                this.SetRelatedEntities<IncidentResolution>("team_incidentresolution", null, value);
                this.OnPropertyChanged("team_incidentresolution");
            }
        }

        /// <summary>
        /// 1:N team_incidents
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_incidents")]
        public System.Collections.Generic.IEnumerable<Incident> team_incidents
        {
            get { return this.GetRelatedEntities<Incident>("team_incidents", null); }
            set
            {
                this.OnPropertyChanging("team_incidents");
                this.SetRelatedEntities<Incident>("team_incidents", null, value);
                this.OnPropertyChanged("team_incidents");
            }
        }

        /// <summary>
        /// 1:N team_invoices
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_invoices")]
        public System.Collections.Generic.IEnumerable<Invoice> team_invoices
        {
            get { return this.GetRelatedEntities<Invoice>("team_invoices", null); }
            set
            {
                this.OnPropertyChanging("team_invoices");
                this.SetRelatedEntities<Invoice>("team_invoices", null, value);
                this.OnPropertyChanged("team_invoices");
            }
        }

        /// <summary>
        /// 1:N team_letter
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_letter")]
        public System.Collections.Generic.IEnumerable<Letter> team_letter
        {
            get { return this.GetRelatedEntities<Letter>("team_letter", null); }
            set
            {
                this.OnPropertyChanging("team_letter");
                this.SetRelatedEntities<Letter>("team_letter", null, value);
                this.OnPropertyChanged("team_letter");
            }
        }

        /// <summary>
        /// 1:N team_list
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_list")]
        public System.Collections.Generic.IEnumerable<List> team_list
        {
            get { return this.GetRelatedEntities<List>("team_list", null); }
            set
            {
                this.OnPropertyChanging("team_list");
                this.SetRelatedEntities<List>("team_list", null, value);
                this.OnPropertyChanged("team_list");
            }
        }

        /// <summary>
        /// 1:N team_mailbox
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_mailbox")]
        public System.Collections.Generic.IEnumerable<Mailbox> team_mailbox
        {
            get { return this.GetRelatedEntities<Mailbox>("team_mailbox", null); }
            set
            {
                this.OnPropertyChanging("team_mailbox");
                this.SetRelatedEntities<Mailbox>("team_mailbox", null, value);
                this.OnPropertyChanged("team_mailbox");
            }
        }

        /// <summary>
        /// 1:N team_msdyn_postalbum
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_msdyn_postalbum")]
        public System.Collections.Generic.IEnumerable<msdyn_PostAlbum> team_msdyn_postalbum
        {
            get { return this.GetRelatedEntities<msdyn_PostAlbum>("team_msdyn_postalbum", null); }
            set
            {
                this.OnPropertyChanging("team_msdyn_postalbum");
                this.SetRelatedEntities<msdyn_PostAlbum>("team_msdyn_postalbum", null, value);
                this.OnPropertyChanged("team_msdyn_postalbum");
            }
        }

        /// <summary>
        /// 1:N team_msdyn_wallsavedqueryusersettings
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_msdyn_wallsavedqueryusersettings")]
        public System.Collections.Generic.IEnumerable<msdyn_wallsavedqueryusersettings> team_msdyn_wallsavedqueryusersettings
        {
            get { return this.GetRelatedEntities<msdyn_wallsavedqueryusersettings>("team_msdyn_wallsavedqueryusersettings", null); }
            set
            {
                this.OnPropertyChanging("team_msdyn_wallsavedqueryusersettings");
                this.SetRelatedEntities<msdyn_wallsavedqueryusersettings>("team_msdyn_wallsavedqueryusersettings", null, value);
                this.OnPropertyChanged("team_msdyn_wallsavedqueryusersettings");
            }
        }

        /// <summary>
        /// 1:N team_opportunities
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_opportunities")]
        public System.Collections.Generic.IEnumerable<Opportunity> team_opportunities
        {
            get { return this.GetRelatedEntities<Opportunity>("team_opportunities", null); }
            set
            {
                this.OnPropertyChanging("team_opportunities");
                this.SetRelatedEntities<Opportunity>("team_opportunities", null, value);
                this.OnPropertyChanged("team_opportunities");
            }
        }

        /// <summary>
        /// 1:N team_opportunityclose
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_opportunityclose")]
        public System.Collections.Generic.IEnumerable<OpportunityClose> team_opportunityclose
        {
            get { return this.GetRelatedEntities<OpportunityClose>("team_opportunityclose", null); }
            set
            {
                this.OnPropertyChanging("team_opportunityclose");
                this.SetRelatedEntities<OpportunityClose>("team_opportunityclose", null, value);
                this.OnPropertyChanged("team_opportunityclose");
            }
        }

        /// <summary>
        /// 1:N team_orderclose
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_orderclose")]
        public System.Collections.Generic.IEnumerable<OrderClose> team_orderclose
        {
            get { return this.GetRelatedEntities<OrderClose>("team_orderclose", null); }
            set
            {
                this.OnPropertyChanging("team_orderclose");
                this.SetRelatedEntities<OrderClose>("team_orderclose", null, value);
                this.OnPropertyChanged("team_orderclose");
            }
        }

        /// <summary>
        /// 1:N team_orders
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_orders")]
        public System.Collections.Generic.IEnumerable<SalesOrder> team_orders
        {
            get { return this.GetRelatedEntities<SalesOrder>("team_orders", null); }
            set
            {
                this.OnPropertyChanging("team_orders");
                this.SetRelatedEntities<SalesOrder>("team_orders", null, value);
                this.OnPropertyChanged("team_orders");
            }
        }

        /// <summary>
        /// 1:N team_phonecall
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_phonecall")]
        public System.Collections.Generic.IEnumerable<PhoneCall> team_phonecall
        {
            get { return this.GetRelatedEntities<PhoneCall>("team_phonecall", null); }
            set
            {
                this.OnPropertyChanging("team_phonecall");
                this.SetRelatedEntities<PhoneCall>("team_phonecall", null, value);
                this.OnPropertyChanged("team_phonecall");
            }
        }

        /// <summary>
        /// 1:N team_principalobjectattributeaccess
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_principalobjectattributeaccess")]
        public System.Collections.Generic.IEnumerable<PrincipalObjectAttributeAccess> team_principalobjectattributeaccess
        {
            get { return this.GetRelatedEntities<PrincipalObjectAttributeAccess>("team_principalobjectattributeaccess", null); }
            set
            {
                this.OnPropertyChanging("team_principalobjectattributeaccess");
                this.SetRelatedEntities<PrincipalObjectAttributeAccess>("team_principalobjectattributeaccess", null, value);
                this.OnPropertyChanged("team_principalobjectattributeaccess");
            }
        }

        /// <summary>
        /// 1:N team_principalobjectattributeaccess_principalid
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_principalobjectattributeaccess_principalid")]
        public System.Collections.Generic.IEnumerable<PrincipalObjectAttributeAccess> team_principalobjectattributeaccess_principalid
        {
            get { return this.GetRelatedEntities<PrincipalObjectAttributeAccess>("team_principalobjectattributeaccess_principalid", null); }
            set
            {
                this.OnPropertyChanging("team_principalobjectattributeaccess_principalid");
                this.SetRelatedEntities<PrincipalObjectAttributeAccess>("team_principalobjectattributeaccess_principalid", null, value);
                this.OnPropertyChanged("team_principalobjectattributeaccess_principalid");
            }
        }

        /// <summary>
        /// 1:N team_processsession
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_processsession")]
        public System.Collections.Generic.IEnumerable<ProcessSession> team_processsession
        {
            get { return this.GetRelatedEntities<ProcessSession>("team_processsession", null); }
            set
            {
                this.OnPropertyChanging("team_processsession");
                this.SetRelatedEntities<ProcessSession>("team_processsession", null, value);
                this.OnPropertyChanged("team_processsession");
            }
        }

        /// <summary>
        /// 1:N Team_ProcessSessions
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Team_ProcessSessions")]
        public System.Collections.Generic.IEnumerable<ProcessSession> Team_ProcessSessions
        {
            get { return this.GetRelatedEntities<ProcessSession>("Team_ProcessSessions", null); }
            set
            {
                this.OnPropertyChanging("Team_ProcessSessions");
                this.SetRelatedEntities<ProcessSession>("Team_ProcessSessions", null, value);
                this.OnPropertyChanged("Team_ProcessSessions");
            }
        }

        /// <summary>
        /// 1:N team_queueitembase_workerid
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_queueitembase_workerid")]
        public System.Collections.Generic.IEnumerable<QueueItem> team_queueitembase_workerid
        {
            get { return this.GetRelatedEntities<QueueItem>("team_queueitembase_workerid", null); }
            set
            {
                this.OnPropertyChanging("team_queueitembase_workerid");
                this.SetRelatedEntities<QueueItem>("team_queueitembase_workerid", null, value);
                this.OnPropertyChanged("team_queueitembase_workerid");
            }
        }

        /// <summary>
        /// 1:N team_quoteclose
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_quoteclose")]
        public System.Collections.Generic.IEnumerable<QuoteClose> team_quoteclose
        {
            get { return this.GetRelatedEntities<QuoteClose>("team_quoteclose", null); }
            set
            {
                this.OnPropertyChanging("team_quoteclose");
                this.SetRelatedEntities<QuoteClose>("team_quoteclose", null, value);
                this.OnPropertyChanged("team_quoteclose");
            }
        }

        /// <summary>
        /// 1:N team_quotes
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_quotes")]
        public System.Collections.Generic.IEnumerable<Quote> team_quotes
        {
            get { return this.GetRelatedEntities<Quote>("team_quotes", null); }
            set
            {
                this.OnPropertyChanging("team_quotes");
                this.SetRelatedEntities<Quote>("team_quotes", null, value);
                this.OnPropertyChanged("team_quotes");
            }
        }

        /// <summary>
        /// 1:N team_recurringappointmentmaster
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_recurringappointmentmaster")]
        public System.Collections.Generic.IEnumerable<RecurringAppointmentMaster> team_recurringappointmentmaster
        {
            get { return this.GetRelatedEntities<RecurringAppointmentMaster>("team_recurringappointmentmaster", null); }
            set
            {
                this.OnPropertyChanging("team_recurringappointmentmaster");
                this.SetRelatedEntities<RecurringAppointmentMaster>("team_recurringappointmentmaster", null, value);
                this.OnPropertyChanged("team_recurringappointmentmaster");
            }
        }

        /// <summary>
        /// 1:N team_resource_groups
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_resource_groups")]
        public System.Collections.Generic.IEnumerable<ResourceGroup> team_resource_groups
        {
            get { return this.GetRelatedEntities<ResourceGroup>("team_resource_groups", null); }
            set
            {
                this.OnPropertyChanging("team_resource_groups");
                this.SetRelatedEntities<ResourceGroup>("team_resource_groups", null, value);
                this.OnPropertyChanged("team_resource_groups");
            }
        }

        /// <summary>
        /// 1:N team_resource_specs
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_resource_specs")]
        public System.Collections.Generic.IEnumerable<ResourceSpec> team_resource_specs
        {
            get { return this.GetRelatedEntities<ResourceSpec>("team_resource_specs", null); }
            set
            {
                this.OnPropertyChanging("team_resource_specs");
                this.SetRelatedEntities<ResourceSpec>("team_resource_specs", null, value);
                this.OnPropertyChanged("team_resource_specs");
            }
        }

        /// <summary>
        /// 1:N team_routingrule
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_routingrule")]
        public System.Collections.Generic.IEnumerable<RoutingRule> team_routingrule
        {
            get { return this.GetRelatedEntities<RoutingRule>("team_routingrule", null); }
            set
            {
                this.OnPropertyChanging("team_routingrule");
                this.SetRelatedEntities<RoutingRule>("team_routingrule", null, value);
                this.OnPropertyChanged("team_routingrule");
            }
        }

        /// <summary>
        /// 1:N team_routingruleitem
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_routingruleitem")]
        public System.Collections.Generic.IEnumerable<RoutingRuleItem> team_routingruleitem
        {
            get { return this.GetRelatedEntities<RoutingRuleItem>("team_routingruleitem", null); }
            set
            {
                this.OnPropertyChanging("team_routingruleitem");
                this.SetRelatedEntities<RoutingRuleItem>("team_routingruleitem", null, value);
                this.OnPropertyChanged("team_routingruleitem");
            }
        }

        /// <summary>
        /// 1:N team_service_appointments
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_service_appointments")]
        public System.Collections.Generic.IEnumerable<ServiceAppointment> team_service_appointments
        {
            get { return this.GetRelatedEntities<ServiceAppointment>("team_service_appointments", null); }
            set
            {
                this.OnPropertyChanging("team_service_appointments");
                this.SetRelatedEntities<ServiceAppointment>("team_service_appointments", null, value);
                this.OnPropertyChanged("team_service_appointments");
            }
        }

        /// <summary>
        /// 1:N team_service_contracts
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_service_contracts")]
        public System.Collections.Generic.IEnumerable<Contract> team_service_contracts
        {
            get { return this.GetRelatedEntities<Contract>("team_service_contracts", null); }
            set
            {
                this.OnPropertyChanging("team_service_contracts");
                this.SetRelatedEntities<Contract>("team_service_contracts", null, value);
                this.OnPropertyChanged("team_service_contracts");
            }
        }

        /// <summary>
        /// 1:N team_sharepointdocumentlocation
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_sharepointdocumentlocation")]
        public System.Collections.Generic.IEnumerable<SharePointDocumentLocation> team_sharepointdocumentlocation
        {
            get { return this.GetRelatedEntities<SharePointDocumentLocation>("team_sharepointdocumentlocation", null); }
            set
            {
                this.OnPropertyChanging("team_sharepointdocumentlocation");
                this.SetRelatedEntities<SharePointDocumentLocation>("team_sharepointdocumentlocation", null, value);
                this.OnPropertyChanged("team_sharepointdocumentlocation");
            }
        }

        /// <summary>
        /// 1:N team_sharepointsite
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_sharepointsite")]
        public System.Collections.Generic.IEnumerable<SharePointSite> team_sharepointsite
        {
            get { return this.GetRelatedEntities<SharePointSite>("team_sharepointsite", null); }
            set
            {
                this.OnPropertyChanging("team_sharepointsite");
                this.SetRelatedEntities<SharePointSite>("team_sharepointsite", null, value);
                this.OnPropertyChanged("team_sharepointsite");
            }
        }

        /// <summary>
        /// 1:N team_slaBase
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_slaBase")]
        public System.Collections.Generic.IEnumerable<SLA> team_slaBase
        {
            get { return this.GetRelatedEntities<SLA>("team_slaBase", null); }
            set
            {
                this.OnPropertyChanging("team_slaBase");
                this.SetRelatedEntities<SLA>("team_slaBase", null, value);
                this.OnPropertyChanged("team_slaBase");
            }
        }

        /// <summary>
        /// 1:N team_socialactivity
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_socialactivity")]
        public System.Collections.Generic.IEnumerable<SocialActivity> team_socialactivity
        {
            get { return this.GetRelatedEntities<SocialActivity>("team_socialactivity", null); }
            set
            {
                this.OnPropertyChanging("team_socialactivity");
                this.SetRelatedEntities<SocialActivity>("team_socialactivity", null, value);
                this.OnPropertyChanged("team_socialactivity");
            }
        }

        /// <summary>
        /// 1:N team_task
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_task")]
        public System.Collections.Generic.IEnumerable<Task> team_task
        {
            get { return this.GetRelatedEntities<Task>("team_task", null); }
            set
            {
                this.OnPropertyChanging("team_task");
                this.SetRelatedEntities<Task>("team_task", null, value);
                this.OnPropertyChanged("team_task");
            }
        }

        /// <summary>
        /// 1:N team_userentityinstancedata
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_userentityinstancedata")]
        public System.Collections.Generic.IEnumerable<UserEntityInstanceData> team_userentityinstancedata
        {
            get { return this.GetRelatedEntities<UserEntityInstanceData>("team_userentityinstancedata", null); }
            set
            {
                this.OnPropertyChanging("team_userentityinstancedata");
                this.SetRelatedEntities<UserEntityInstanceData>("team_userentityinstancedata", null, value);
                this.OnPropertyChanged("team_userentityinstancedata");
            }
        }

        /// <summary>
        /// 1:N team_userentityuisettings
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_userentityuisettings")]
        public System.Collections.Generic.IEnumerable<UserEntityUISettings> team_userentityuisettings
        {
            get { return this.GetRelatedEntities<UserEntityUISettings>("team_userentityuisettings", null); }
            set
            {
                this.OnPropertyChanging("team_userentityuisettings");
                this.SetRelatedEntities<UserEntityUISettings>("team_userentityuisettings", null, value);
                this.OnPropertyChanged("team_userentityuisettings");
            }
        }

        /// <summary>
        /// 1:N team_userform
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_userform")]
        public System.Collections.Generic.IEnumerable<UserForm> team_userform
        {
            get { return this.GetRelatedEntities<UserForm>("team_userform", null); }
            set
            {
                this.OnPropertyChanging("team_userform");
                this.SetRelatedEntities<UserForm>("team_userform", null, value);
                this.OnPropertyChanged("team_userform");
            }
        }

        /// <summary>
        /// 1:N team_userquery
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_userquery")]
        public System.Collections.Generic.IEnumerable<UserQuery> team_userquery
        {
            get { return this.GetRelatedEntities<UserQuery>("team_userquery", null); }
            set
            {
                this.OnPropertyChanging("team_userquery");
                this.SetRelatedEntities<UserQuery>("team_userquery", null, value);
                this.OnPropertyChanged("team_userquery");
            }
        }

        /// <summary>
        /// 1:N team_userqueryvisualizations
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_userqueryvisualizations")]
        public System.Collections.Generic.IEnumerable<UserQueryVisualization> team_userqueryvisualizations
        {
            get { return this.GetRelatedEntities<UserQueryVisualization>("team_userqueryvisualizations", null); }
            set
            {
                this.OnPropertyChanging("team_userqueryvisualizations");
                this.SetRelatedEntities<UserQueryVisualization>("team_userqueryvisualizations", null, value);
                this.OnPropertyChanged("team_userqueryvisualizations");
            }
        }

        /// <summary>
        /// 1:N team_workflow
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_workflow")]
        public System.Collections.Generic.IEnumerable<Workflow> team_workflow
        {
            get { return this.GetRelatedEntities<Workflow>("team_workflow", null); }
            set
            {
                this.OnPropertyChanging("team_workflow");
                this.SetRelatedEntities<Workflow>("team_workflow", null, value);
                this.OnPropertyChanged("team_workflow");
            }
        }

        /// <summary>
        /// 1:N team_workflowlog
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_workflowlog")]
        public System.Collections.Generic.IEnumerable<WorkflowLog> team_workflowlog
        {
            get { return this.GetRelatedEntities<WorkflowLog>("team_workflowlog", null); }
            set
            {
                this.OnPropertyChanging("team_workflowlog");
                this.SetRelatedEntities<WorkflowLog>("team_workflowlog", null, value);
                this.OnPropertyChanged("team_workflowlog");
            }
        }

        /// <summary>
        /// 1:N userentityinstancedata_team
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_team")]
        public System.Collections.Generic.IEnumerable<UserEntityInstanceData> userentityinstancedata_team
        {
            get { return this.GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_team", null); }
            set
            {
                this.OnPropertyChanging("userentityinstancedata_team");
                this.SetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_team", null, value);
                this.OnPropertyChanged("userentityinstancedata_team");
            }
        }

        /// <summary>
        /// N:N teammembership_association
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("teammembership_association")]
        public System.Collections.Generic.IEnumerable<SystemUser> teammembership_association
        {
            get { return this.GetRelatedEntities<SystemUser>("teammembership_association", null); }
            set
            {
                this.OnPropertyChanging("teammembership_association");
                this.SetRelatedEntities<SystemUser>("teammembership_association", null, value);
                this.OnPropertyChanged("teammembership_association");
            }
        }

        /// <summary>
        /// N:N teamprofiles_association
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("teamprofiles_association")]
        public System.Collections.Generic.IEnumerable<FieldSecurityProfile> teamprofiles_association
        {
            get { return this.GetRelatedEntities<FieldSecurityProfile>("teamprofiles_association", null); }
            set
            {
                this.OnPropertyChanging("teamprofiles_association");
                this.SetRelatedEntities<FieldSecurityProfile>("teamprofiles_association", null, value);
                this.OnPropertyChanged("teamprofiles_association");
            }
        }

        /// <summary>
        /// N:N teamroles_association
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("teamroles_association")]
        public System.Collections.Generic.IEnumerable<Role> teamroles_association
        {
            get { return this.GetRelatedEntities<Role>("teamroles_association", null); }
            set
            {
                this.OnPropertyChanging("teamroles_association");
                this.SetRelatedEntities<Role>("teamroles_association", null, value);
                this.OnPropertyChanged("teamroles_association");
            }
        }

        /// <summary>
        /// N:1 business_unit_teams
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("businessunitid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_teams")]
        public BusinessUnit business_unit_teams
        {
            get { return this.GetRelatedEntity<BusinessUnit>("business_unit_teams", null); }
            set
            {
                this.OnPropertyChanging("business_unit_teams");
                this.SetRelatedEntity<BusinessUnit>("business_unit_teams", null, value);
                this.OnPropertyChanged("business_unit_teams");
            }
        }

        /// <summary>
        /// N:1 lk_team_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_team_createdonbehalfby")]
        public SystemUser lk_team_createdonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_team_createdonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_team_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_team_modifiedonbehalfby")]
        public SystemUser lk_team_modifiedonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_team_modifiedonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_teambase_administratorid
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("administratorid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_teambase_administratorid")]
        public SystemUser lk_teambase_administratorid
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_teambase_administratorid", null); }
            set
            {
                this.OnPropertyChanging("lk_teambase_administratorid");
                this.SetRelatedEntity<SystemUser>("lk_teambase_administratorid", null, value);
                this.OnPropertyChanged("lk_teambase_administratorid");
            }
        }

        /// <summary>
        /// N:1 lk_teambase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_teambase_createdby")]
        public SystemUser lk_teambase_createdby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_teambase_createdby", null); }
        }

        /// <summary>
        /// N:1 lk_teambase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_teambase_modifiedby")]
        public SystemUser lk_teambase_modifiedby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_teambase_modifiedby", null); }
        }

        /// <summary>
        /// N:1 opportunity_Teams
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("opportunity_Teams")]
        public Opportunity opportunity_Teams
        {
            get { return this.GetRelatedEntity<Opportunity>("opportunity_Teams", null); }
            set
            {
                this.OnPropertyChanging("opportunity_Teams");
                this.SetRelatedEntity<Opportunity>("opportunity_Teams", null, value);
                this.OnPropertyChanged("opportunity_Teams");
            }
        }

        /// <summary>
        /// N:1 organization_teams
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_teams")]
        public Organization organization_teams
        {
            get { return this.GetRelatedEntity<Organization>("organization_teams", null); }
        }

        /// <summary>
        /// N:1 processstage_teams
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("stageid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("processstage_teams")]
        public ProcessStage processstage_teams
        {
            get { return this.GetRelatedEntity<ProcessStage>("processstage_teams", null); }
            set
            {
                this.OnPropertyChanging("processstage_teams");
                this.SetRelatedEntity<ProcessStage>("processstage_teams", null, value);
                this.OnPropertyChanged("processstage_teams");
            }
        }

        /// <summary>
        /// N:1 queue_team
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("queueid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("queue_team")]
        public Queue queue_team
        {
            get { return this.GetRelatedEntity<Queue>("queue_team", null); }
            set
            {
                this.OnPropertyChanging("queue_team");
                this.SetRelatedEntity<Queue>("queue_team", null, value);
                this.OnPropertyChanged("queue_team");
            }
        }

        /// <summary>
        /// N:1 teamtemplate_Teams
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("teamtemplateid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("teamtemplate_Teams")]
        public TeamTemplate teamtemplate_Teams
        {
            get { return this.GetRelatedEntity<TeamTemplate>("teamtemplate_Teams", null); }
            set
            {
                this.OnPropertyChanging("teamtemplate_Teams");
                this.SetRelatedEntity<TeamTemplate>("teamtemplate_Teams", null, value);
                this.OnPropertyChanged("teamtemplate_Teams");
            }
        }

        /// <summary>
        /// N:1 TransactionCurrency_Team
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("TransactionCurrency_Team")]
        public TransactionCurrency TransactionCurrency_Team
        {
            get { return this.GetRelatedEntity<TransactionCurrency>("TransactionCurrency_Team", null); }
            set
            {
                this.OnPropertyChanging("TransactionCurrency_Team");
                this.SetRelatedEntity<TransactionCurrency>("TransactionCurrency_Team", null, value);
                this.OnPropertyChanged("TransactionCurrency_Team");
            }
        }
    }
}