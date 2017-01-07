namespace __4_DAL_CRM
{
    /// <summary>
    /// Enable or disable system post rules for an entity for Activity Feeds and Yammer.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("msdyn_postruleconfig")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class msdyn_PostRuleConfig : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public msdyn_PostRuleConfig() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "msdyn_postruleconfig";

        public const int EntityTypeCode = 10002;

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
        /// Unique identifier of the user who created the record.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby"); }
        }

        /// <summary>
        /// Date and time when the record was created.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
        public System.Nullable<System.DateTime> CreatedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who created the record.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        /// Sequence number of the import that created this record.
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
        /// Unique identifier of the user who modified the record.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby"); }
        }

        /// <summary>
        /// Date and time when the record was modified.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
        public System.Nullable<System.DateTime> ModifiedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who modified the record.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        /// Internal Use Only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_formatid")]
        public string msdyn_FormatId
        {
            get { return this.GetAttributeValue<string>("msdyn_formatid"); }
            set
            {
                this.OnPropertyChanging("msdyn_FormatId");
                this.SetAttributeValue("msdyn_formatid", value);
                this.OnPropertyChanged("msdyn_FormatId");
            }
        }

        /// <summary>
        /// Name of the rule.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_name")]
        public string msdyn_name
        {
            get { return this.GetAttributeValue<string>("msdyn_name"); }
            set
            {
                this.OnPropertyChanging("msdyn_name");
                this.SetAttributeValue("msdyn_name", value);
                this.OnPropertyChanged("msdyn_name");
            }
        }

        /// <summary>
        /// Entity that is enabled for Activity feeds.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_postconfigid")]
        public Microsoft.Xrm.Sdk.EntityReference msdyn_PostConfigId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("msdyn_postconfigid"); }
            set
            {
                this.OnPropertyChanging("msdyn_PostConfigId");
                this.SetAttributeValue("msdyn_postconfigid", value);
                this.OnPropertyChanged("msdyn_PostConfigId");
            }
        }

        /// <summary>
        /// Unique identifier of the post rule configuration.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_postruleconfigid")]
        public System.Nullable<System.Guid> msdyn_PostRuleConfigId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("msdyn_postruleconfigid"); }
            set
            {
                this.OnPropertyChanging("msdyn_PostRuleConfigId");
                this.SetAttributeValue("msdyn_postruleconfigid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("msdyn_PostRuleConfigId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_postruleconfigid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.msdyn_PostRuleConfigId = value; }
        }

        /// <summary>
        /// Determine whether to post this message to the Yammer Activity Stream. Please do not check this box if this message contains sensitive information requiring Microsoft Dynamics CRM access.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_posttoyammer")]
        public System.Nullable<bool> msdyn_PostToYammer
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("msdyn_posttoyammer"); }
            set
            {
                this.OnPropertyChanging("msdyn_PostToYammer");
                this.SetAttributeValue("msdyn_posttoyammer", value);
                this.OnPropertyChanged("msdyn_PostToYammer");
            }
        }

        /// <summary>
        /// Identifier in the format WebResourceName:SchemaName of the definition for this rule.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_ruleid")]
        public string msdyn_RuleId
        {
            get { return this.GetAttributeValue<string>("msdyn_ruleid"); }
            set
            {
                this.OnPropertyChanging("msdyn_RuleId");
                this.SetAttributeValue("msdyn_ruleid", value);
                this.OnPropertyChanged("msdyn_RuleId");
            }
        }

        /// <summary>
        /// Internal Use Only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_rulesource")]
        public string msdyn_RuleSource
        {
            get { return this.GetAttributeValue<string>("msdyn_rulesource"); }
            set
            {
                this.OnPropertyChanging("msdyn_RuleSource");
                this.SetAttributeValue("msdyn_rulesource", value);
                this.OnPropertyChanged("msdyn_RuleSource");
            }
        }

        /// <summary>
        /// Unique identifier of the SDK message processing step for this rule.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_stepid")]
        public string msdyn_StepId
        {
            get { return this.GetAttributeValue<string>("msdyn_stepid"); }
            set
            {
                this.OnPropertyChanging("msdyn_StepId");
                this.SetAttributeValue("msdyn_stepid", value);
                this.OnPropertyChanged("msdyn_StepId");
            }
        }

        /// <summary>
        /// Unique identifier for the organization
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
        public Microsoft.Xrm.Sdk.EntityReference OrganizationId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("organizationid"); }
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
        /// Status of the Post Rule Configuration
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
        public System.Nullable<msdyn_PostRuleConfigState> statecode
        {
            get
            {
                Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
                if ((optionSet != null))
                {
                    return ((msdyn_PostRuleConfigState) (System.Enum.ToObject(typeof(msdyn_PostRuleConfigState), optionSet.Value)));
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// Reason for the status of the Post Rule Configuration
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statuscode")]
        public Microsoft.Xrm.Sdk.OptionSetValue statuscode
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statuscode"); }
            set
            {
                this.OnPropertyChanging("statuscode");
                this.SetAttributeValue("statuscode", value);
                this.OnPropertyChanged("statuscode");
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
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
        public System.Nullable<long> VersionNumber
        {
            get { return this.GetAttributeValue<System.Nullable<long>>("versionnumber"); }
        }

        /// <summary>
        /// 1:N msdyn_postruleconfig_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_postruleconfig_AsyncOperations")]
        public System.Collections.Generic.IEnumerable<AsyncOperation> msdyn_postruleconfig_AsyncOperations
        {
            get { return this.GetRelatedEntities<AsyncOperation>("msdyn_postruleconfig_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("msdyn_postruleconfig_AsyncOperations");
                this.SetRelatedEntities<AsyncOperation>("msdyn_postruleconfig_AsyncOperations", null, value);
                this.OnPropertyChanged("msdyn_postruleconfig_AsyncOperations");
            }
        }

        /// <summary>
        /// 1:N msdyn_postruleconfig_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_postruleconfig_BulkDeleteFailures")]
        public System.Collections.Generic.IEnumerable<BulkDeleteFailure> msdyn_postruleconfig_BulkDeleteFailures
        {
            get { return this.GetRelatedEntities<BulkDeleteFailure>("msdyn_postruleconfig_BulkDeleteFailures", null); }
            set
            {
                this.OnPropertyChanging("msdyn_postruleconfig_BulkDeleteFailures");
                this.SetRelatedEntities<BulkDeleteFailure>("msdyn_postruleconfig_BulkDeleteFailures", null, value);
                this.OnPropertyChanged("msdyn_postruleconfig_BulkDeleteFailures");
            }
        }

        /// <summary>
        /// 1:N msdyn_postruleconfig_PrincipalObjectAttributeAccesses
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_postruleconfig_PrincipalObjectAttributeAccesses")]
        public System.Collections.Generic.IEnumerable<PrincipalObjectAttributeAccess> msdyn_postruleconfig_PrincipalObjectAttributeAccesses
        {
            get { return this.GetRelatedEntities<PrincipalObjectAttributeAccess>("msdyn_postruleconfig_PrincipalObjectAttributeAccesses", null); }
            set
            {
                this.OnPropertyChanging("msdyn_postruleconfig_PrincipalObjectAttributeAccesses");
                this.SetRelatedEntities<PrincipalObjectAttributeAccess>("msdyn_postruleconfig_PrincipalObjectAttributeAccesses", null, value);
                this.OnPropertyChanged("msdyn_postruleconfig_PrincipalObjectAttributeAccesses");
            }
        }

        /// <summary>
        /// 1:N msdyn_postruleconfig_ProcessSession
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_postruleconfig_ProcessSession")]
        public System.Collections.Generic.IEnumerable<ProcessSession> msdyn_postruleconfig_ProcessSession
        {
            get { return this.GetRelatedEntities<ProcessSession>("msdyn_postruleconfig_ProcessSession", null); }
            set
            {
                this.OnPropertyChanging("msdyn_postruleconfig_ProcessSession");
                this.SetRelatedEntities<ProcessSession>("msdyn_postruleconfig_ProcessSession", null, value);
                this.OnPropertyChanged("msdyn_postruleconfig_ProcessSession");
            }
        }

        /// <summary>
        /// 1:N msdyn_postruleconfig_UserEntityInstanceDatas
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_postruleconfig_UserEntityInstanceDatas")]
        public System.Collections.Generic.IEnumerable<UserEntityInstanceData> msdyn_postruleconfig_UserEntityInstanceDatas
        {
            get { return this.GetRelatedEntities<UserEntityInstanceData>("msdyn_postruleconfig_UserEntityInstanceDatas", null); }
            set
            {
                this.OnPropertyChanging("msdyn_postruleconfig_UserEntityInstanceDatas");
                this.SetRelatedEntities<UserEntityInstanceData>("msdyn_postruleconfig_UserEntityInstanceDatas", null, value);
                this.OnPropertyChanged("msdyn_postruleconfig_UserEntityInstanceDatas");
            }
        }

        /// <summary>
        /// N:1 lk_msdyn_postruleconfig_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_msdyn_postruleconfig_createdby")]
        public SystemUser lk_msdyn_postruleconfig_createdby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_msdyn_postruleconfig_createdby", null); }
        }

        /// <summary>
        /// N:1 lk_msdyn_postruleconfig_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_msdyn_postruleconfig_createdonbehalfby")]
        public SystemUser lk_msdyn_postruleconfig_createdonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_msdyn_postruleconfig_createdonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_msdyn_postruleconfig_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_msdyn_postruleconfig_modifiedby")]
        public SystemUser lk_msdyn_postruleconfig_modifiedby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_msdyn_postruleconfig_modifiedby", null); }
        }

        /// <summary>
        /// N:1 lk_msdyn_postruleconfig_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_msdyn_postruleconfig_modifiedonbehalfby")]
        public SystemUser lk_msdyn_postruleconfig_modifiedonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_msdyn_postruleconfig_modifiedonbehalfby", null); }
        }

        /// <summary>
        /// N:1 msdyn_postconfig_msdyn_postruleconfig
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_postconfigid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_postconfig_msdyn_postruleconfig")]
        public msdyn_PostConfig msdyn_postconfig_msdyn_postruleconfig
        {
            get { return this.GetRelatedEntity<msdyn_PostConfig>("msdyn_postconfig_msdyn_postruleconfig", null); }
            set
            {
                this.OnPropertyChanging("msdyn_postconfig_msdyn_postruleconfig");
                this.SetRelatedEntity<msdyn_PostConfig>("msdyn_postconfig_msdyn_postruleconfig", null, value);
                this.OnPropertyChanged("msdyn_postconfig_msdyn_postruleconfig");
            }
        }

        /// <summary>
        /// N:1 organization_msdyn_postruleconfig
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_msdyn_postruleconfig")]
        public Organization organization_msdyn_postruleconfig
        {
            get { return this.GetRelatedEntity<Organization>("organization_msdyn_postruleconfig", null); }
        }
    }
}