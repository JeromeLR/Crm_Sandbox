namespace __4_DAL_CRM
{
    /// <summary>
    /// Rule used to identify potential duplicates.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("duplicaterule")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class DuplicateRule : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public DuplicateRule() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "duplicaterule";

        public const int EntityTypeCode = 4414;

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
        /// Database table that stores match codes for the record type being evaluated for potential duplicates.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("baseentitymatchcodetable")]
        public string BaseEntityMatchCodeTable
        {
            get { return this.GetAttributeValue<string>("baseentitymatchcodetable"); }
        }

        /// <summary>
        /// Record type of the record being evaluated for potential duplicates.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("baseentityname")]
        public string BaseEntityName
        {
            get { return this.GetAttributeValue<string>("baseentityname"); }
            set
            {
                this.OnPropertyChanging("BaseEntityName");
                this.SetAttributeValue("baseentityname", value);
                this.OnPropertyChanged("BaseEntityName");
            }
        }

        /// <summary>
        /// Record type of the record being evaluated for potential duplicates.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("baseentitytypecode")]
        public Microsoft.Xrm.Sdk.OptionSetValue BaseEntityTypeCode
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("baseentitytypecode"); }
        }

        /// <summary>
        /// Unique identifier of the user who created the duplicate detection rule.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby"); }
        }

        /// <summary>
        /// Date and time when the duplicate detection rule was created.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
        public System.Nullable<System.DateTime> CreatedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who created the duplicaterule.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        /// Description of the duplicate detection rule.
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
        /// Unique identifier of the duplicate detection rule.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("duplicateruleid")]
        public System.Nullable<System.Guid> DuplicateRuleId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("duplicateruleid"); }
            set
            {
                this.OnPropertyChanging("DuplicateRuleId");
                this.SetAttributeValue("duplicateruleid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("DuplicateRuleId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("duplicateruleid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.DuplicateRuleId = value; }
        }

        /// <summary>
        /// Determines whether to flag inactive records as duplicates
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("excludeinactiverecords")]
        public System.Nullable<bool> ExcludeInactiveRecords
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("excludeinactiverecords"); }
            set
            {
                this.OnPropertyChanging("ExcludeInactiveRecords");
                this.SetAttributeValue("excludeinactiverecords", value);
                this.OnPropertyChanged("ExcludeInactiveRecords");
            }
        }

        /// <summary>
        /// Indicates if the operator is case-sensitive.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("iscasesensitive")]
        public System.Nullable<bool> IsCaseSensitive
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("iscasesensitive"); }
            set
            {
                this.OnPropertyChanging("IsCaseSensitive");
                this.SetAttributeValue("iscasesensitive", value);
                this.OnPropertyChanged("IsCaseSensitive");
            }
        }

        /// <summary>
        /// Database table that stores match codes for potential duplicate records.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("matchingentitymatchcodetable")]
        public string MatchingEntityMatchCodeTable
        {
            get { return this.GetAttributeValue<string>("matchingentitymatchcodetable"); }
        }

        /// <summary>
        /// Record type of the records being evaluated as potential duplicates.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("matchingentityname")]
        public string MatchingEntityName
        {
            get { return this.GetAttributeValue<string>("matchingentityname"); }
            set
            {
                this.OnPropertyChanging("MatchingEntityName");
                this.SetAttributeValue("matchingentityname", value);
                this.OnPropertyChanged("MatchingEntityName");
            }
        }

        /// <summary>
        /// Record type of the records being evaluated as potential duplicates.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("matchingentitytypecode")]
        public Microsoft.Xrm.Sdk.OptionSetValue MatchingEntityTypeCode
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("matchingentitytypecode"); }
        }

        /// <summary>
        /// Unique identifier of the user who last modified the duplicate detection rule.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby"); }
        }

        /// <summary>
        /// Date and time when the duplicate detection rule was last modified.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
        public System.Nullable<System.DateTime> ModifiedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who last modified the duplicaterule.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        /// Name of the duplicate detection rule.
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
        /// Unique identifier of the user or team who owns the duplicate detection rule.
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
        /// Unique identifier of the business unit that owns duplicate detection rule.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
        public Microsoft.Xrm.Sdk.EntityReference OwningBusinessUnit
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningbusinessunit"); }
        }

        /// <summary>
        /// Unique identifier of the team who owns the duplicate detection rule.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
        public Microsoft.Xrm.Sdk.EntityReference OwningTeam
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningteam"); }
        }

        /// <summary>
        /// Unique identifier of the user who owns the duplicate detection rule.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
        public Microsoft.Xrm.Sdk.EntityReference OwningUser
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owninguser"); }
        }

        /// <summary>
        /// Status of the duplicate detection rule.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
        public System.Nullable<DuplicateRuleState> StateCode
        {
            get
            {
                Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
                if ((optionSet != null))
                {
                    return ((DuplicateRuleState) (System.Enum.ToObject(typeof(DuplicateRuleState), optionSet.Value)));
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// Reason for the status of the duplicate detection rule.
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
        /// 1:N DuplicateRule_Annotation
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("DuplicateRule_Annotation")]
        public System.Collections.Generic.IEnumerable<Annotation> DuplicateRule_Annotation
        {
            get { return this.GetRelatedEntities<Annotation>("DuplicateRule_Annotation", null); }
            set
            {
                this.OnPropertyChanging("DuplicateRule_Annotation");
                this.SetRelatedEntities<Annotation>("DuplicateRule_Annotation", null, value);
                this.OnPropertyChanged("DuplicateRule_Annotation");
            }
        }

        /// <summary>
        /// 1:N DuplicateRule_DuplicateBaseRecord
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("DuplicateRule_DuplicateBaseRecord")]
        public System.Collections.Generic.IEnumerable<DuplicateRecord> DuplicateRule_DuplicateBaseRecord
        {
            get { return this.GetRelatedEntities<DuplicateRecord>("DuplicateRule_DuplicateBaseRecord", null); }
            set
            {
                this.OnPropertyChanging("DuplicateRule_DuplicateBaseRecord");
                this.SetRelatedEntities<DuplicateRecord>("DuplicateRule_DuplicateBaseRecord", null, value);
                this.OnPropertyChanged("DuplicateRule_DuplicateBaseRecord");
            }
        }

        /// <summary>
        /// 1:N DuplicateRule_DuplicateRuleConditions
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("DuplicateRule_DuplicateRuleConditions")]
        public System.Collections.Generic.IEnumerable<DuplicateRuleCondition> DuplicateRule_DuplicateRuleConditions
        {
            get { return this.GetRelatedEntities<DuplicateRuleCondition>("DuplicateRule_DuplicateRuleConditions", null); }
            set
            {
                this.OnPropertyChanging("DuplicateRule_DuplicateRuleConditions");
                this.SetRelatedEntities<DuplicateRuleCondition>("DuplicateRule_DuplicateRuleConditions", null, value);
                this.OnPropertyChanged("DuplicateRule_DuplicateRuleConditions");
            }
        }

        /// <summary>
        /// 1:N userentityinstancedata_duplicaterule
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_duplicaterule")]
        public System.Collections.Generic.IEnumerable<UserEntityInstanceData> userentityinstancedata_duplicaterule
        {
            get { return this.GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_duplicaterule", null); }
            set
            {
                this.OnPropertyChanging("userentityinstancedata_duplicaterule");
                this.SetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_duplicaterule", null, value);
                this.OnPropertyChanged("userentityinstancedata_duplicaterule");
            }
        }

        /// <summary>
        /// N:1 BusinessUnit_DuplicateRules
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("BusinessUnit_DuplicateRules")]
        public BusinessUnit BusinessUnit_DuplicateRules
        {
            get { return this.GetRelatedEntity<BusinessUnit>("BusinessUnit_DuplicateRules", null); }
        }

        /// <summary>
        /// N:1 lk_duplicaterule_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_duplicaterule_createdonbehalfby")]
        public SystemUser lk_duplicaterule_createdonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_duplicaterule_createdonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_duplicaterule_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_duplicaterule_modifiedonbehalfby")]
        public SystemUser lk_duplicaterule_modifiedonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_duplicaterule_modifiedonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_duplicaterulebase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_duplicaterulebase_createdby")]
        public SystemUser lk_duplicaterulebase_createdby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_duplicaterulebase_createdby", null); }
        }

        /// <summary>
        /// N:1 lk_duplicaterulebase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_duplicaterulebase_modifiedby")]
        public SystemUser lk_duplicaterulebase_modifiedby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_duplicaterulebase_modifiedby", null); }
        }

        /// <summary>
        /// N:1 SystemUser_DuplicateRules
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SystemUser_DuplicateRules")]
        public SystemUser SystemUser_DuplicateRules
        {
            get { return this.GetRelatedEntity<SystemUser>("SystemUser_DuplicateRules", null); }
        }

        /// <summary>
        /// N:1 team_DuplicateRules
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_DuplicateRules")]
        public Team team_DuplicateRules
        {
            get { return this.GetRelatedEntity<Team>("team_DuplicateRules", null); }
        }
    }
}