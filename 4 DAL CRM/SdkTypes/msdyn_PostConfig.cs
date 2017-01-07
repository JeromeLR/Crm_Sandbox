namespace __4_DAL_CRM
{
    /// <summary>
    /// Enable or disable entities for Activity Feeds and Yammer collaboration.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("msdyn_postconfig")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class msdyn_PostConfig : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public msdyn_PostConfig() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "msdyn_postconfig";

        public const int EntityTypeCode = 10001;

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
        /// Enables or disables the wall on the entity form.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_configurewall")]
        public System.Nullable<bool> msdyn_ConfigureWall
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("msdyn_configurewall"); }
            set
            {
                this.OnPropertyChanging("msdyn_ConfigureWall");
                this.SetAttributeValue("msdyn_configurewall", value);
                this.OnPropertyChanged("msdyn_ConfigureWall");
            }
        }

        /// <summary>
        /// Display name of the entity configured by this object.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_entitydisplayname")]
        public string msdyn_EntityDisplayName
        {
            get { return this.GetAttributeValue<string>("msdyn_entitydisplayname"); }
            set
            {
                this.OnPropertyChanging("msdyn_EntityDisplayName");
                this.SetAttributeValue("msdyn_entitydisplayname", value);
                this.OnPropertyChanged("msdyn_EntityDisplayName");
            }
        }

        /// <summary>
        /// Logical name of the entity configured by this object.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_entityname")]
        public string msdyn_EntityName
        {
            get { return this.GetAttributeValue<string>("msdyn_entityname"); }
            set
            {
                this.OnPropertyChanging("msdyn_EntityName");
                this.SetAttributeValue("msdyn_entityname", value);
                this.OnPropertyChanged("msdyn_EntityName");
            }
        }

        /// <summary>
        /// Identifier for the view of records that a user follows.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_followingviewid")]
        public string msdyn_FollowingViewId
        {
            get { return this.GetAttributeValue<string>("msdyn_followingviewid"); }
            set
            {
                this.OnPropertyChanging("msdyn_FollowingViewId");
                this.SetAttributeValue("msdyn_followingviewid", value);
                this.OnPropertyChanged("msdyn_FollowingViewId");
            }
        }

        /// <summary>
        /// Identifier for the view of records that a user follows.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_followingviewid2")]
        public string msdyn_FollowingViewId2
        {
            get { return this.GetAttributeValue<string>("msdyn_followingviewid2"); }
            set
            {
                this.OnPropertyChanging("msdyn_FollowingViewId2");
                this.SetAttributeValue("msdyn_followingviewid2", value);
                this.OnPropertyChanged("msdyn_FollowingViewId2");
            }
        }

        /// <summary>
        /// Object Type Code of the entity
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_otc")]
        public System.Nullable<int> msdyn_Otc
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("msdyn_otc"); }
            set
            {
                this.OnPropertyChanging("msdyn_Otc");
                this.SetAttributeValue("msdyn_otc", value);
                this.OnPropertyChanged("msdyn_Otc");
            }
        }

        /// <summary>
        /// Unique identifier of the post configuration for this rule.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_postconfigid")]
        public System.Nullable<System.Guid> msdyn_PostConfigId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("msdyn_postconfigid"); }
            set
            {
                this.OnPropertyChanging("msdyn_PostConfigId");
                this.SetAttributeValue("msdyn_postconfigid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("msdyn_PostConfigId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_postconfigid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.msdyn_PostConfigId = value; }
        }

        /// <summary>
        /// Information about the success or failure of the configuration.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_status")]
        public string msdyn_Status
        {
            get { return this.GetAttributeValue<string>("msdyn_status"); }
            set
            {
                this.OnPropertyChanging("msdyn_Status");
                this.SetAttributeValue("msdyn_status", value);
                this.OnPropertyChanged("msdyn_Status");
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
        /// Status of the Post Configuration
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
        public System.Nullable<msdyn_PostConfigState> statecode
        {
            get
            {
                Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
                if ((optionSet != null))
                {
                    return ((msdyn_PostConfigState) (System.Enum.ToObject(typeof(msdyn_PostConfigState), optionSet.Value)));
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// Reason for the status of the Post Configuration
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
        /// 1:N msdyn_postconfig_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_postconfig_AsyncOperations")]
        public System.Collections.Generic.IEnumerable<AsyncOperation> msdyn_postconfig_AsyncOperations
        {
            get { return this.GetRelatedEntities<AsyncOperation>("msdyn_postconfig_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("msdyn_postconfig_AsyncOperations");
                this.SetRelatedEntities<AsyncOperation>("msdyn_postconfig_AsyncOperations", null, value);
                this.OnPropertyChanged("msdyn_postconfig_AsyncOperations");
            }
        }

        /// <summary>
        /// 1:N msdyn_postconfig_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_postconfig_BulkDeleteFailures")]
        public System.Collections.Generic.IEnumerable<BulkDeleteFailure> msdyn_postconfig_BulkDeleteFailures
        {
            get { return this.GetRelatedEntities<BulkDeleteFailure>("msdyn_postconfig_BulkDeleteFailures", null); }
            set
            {
                this.OnPropertyChanging("msdyn_postconfig_BulkDeleteFailures");
                this.SetRelatedEntities<BulkDeleteFailure>("msdyn_postconfig_BulkDeleteFailures", null, value);
                this.OnPropertyChanged("msdyn_postconfig_BulkDeleteFailures");
            }
        }

        /// <summary>
        /// 1:N msdyn_postconfig_msdyn_postruleconfig
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_postconfig_msdyn_postruleconfig")]
        public System.Collections.Generic.IEnumerable<msdyn_PostRuleConfig> msdyn_postconfig_msdyn_postruleconfig
        {
            get { return this.GetRelatedEntities<msdyn_PostRuleConfig>("msdyn_postconfig_msdyn_postruleconfig", null); }
            set
            {
                this.OnPropertyChanging("msdyn_postconfig_msdyn_postruleconfig");
                this.SetRelatedEntities<msdyn_PostRuleConfig>("msdyn_postconfig_msdyn_postruleconfig", null, value);
                this.OnPropertyChanged("msdyn_postconfig_msdyn_postruleconfig");
            }
        }

        /// <summary>
        /// 1:N msdyn_postconfig_PrincipalObjectAttributeAccesses
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_postconfig_PrincipalObjectAttributeAccesses")]
        public System.Collections.Generic.IEnumerable<PrincipalObjectAttributeAccess> msdyn_postconfig_PrincipalObjectAttributeAccesses
        {
            get { return this.GetRelatedEntities<PrincipalObjectAttributeAccess>("msdyn_postconfig_PrincipalObjectAttributeAccesses", null); }
            set
            {
                this.OnPropertyChanging("msdyn_postconfig_PrincipalObjectAttributeAccesses");
                this.SetRelatedEntities<PrincipalObjectAttributeAccess>("msdyn_postconfig_PrincipalObjectAttributeAccesses", null, value);
                this.OnPropertyChanged("msdyn_postconfig_PrincipalObjectAttributeAccesses");
            }
        }

        /// <summary>
        /// 1:N msdyn_postconfig_ProcessSession
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_postconfig_ProcessSession")]
        public System.Collections.Generic.IEnumerable<ProcessSession> msdyn_postconfig_ProcessSession
        {
            get { return this.GetRelatedEntities<ProcessSession>("msdyn_postconfig_ProcessSession", null); }
            set
            {
                this.OnPropertyChanging("msdyn_postconfig_ProcessSession");
                this.SetRelatedEntities<ProcessSession>("msdyn_postconfig_ProcessSession", null, value);
                this.OnPropertyChanged("msdyn_postconfig_ProcessSession");
            }
        }

        /// <summary>
        /// 1:N msdyn_postconfig_UserEntityInstanceDatas
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_postconfig_UserEntityInstanceDatas")]
        public System.Collections.Generic.IEnumerable<UserEntityInstanceData> msdyn_postconfig_UserEntityInstanceDatas
        {
            get { return this.GetRelatedEntities<UserEntityInstanceData>("msdyn_postconfig_UserEntityInstanceDatas", null); }
            set
            {
                this.OnPropertyChanging("msdyn_postconfig_UserEntityInstanceDatas");
                this.SetRelatedEntities<UserEntityInstanceData>("msdyn_postconfig_UserEntityInstanceDatas", null, value);
                this.OnPropertyChanged("msdyn_postconfig_UserEntityInstanceDatas");
            }
        }

        /// <summary>
        /// 1:N msdyn_postconfig_wallsavedquery
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_postconfig_wallsavedquery")]
        public System.Collections.Generic.IEnumerable<msdyn_wallsavedquery> msdyn_postconfig_wallsavedquery
        {
            get { return this.GetRelatedEntities<msdyn_wallsavedquery>("msdyn_postconfig_wallsavedquery", null); }
            set
            {
                this.OnPropertyChanging("msdyn_postconfig_wallsavedquery");
                this.SetRelatedEntities<msdyn_wallsavedquery>("msdyn_postconfig_wallsavedquery", null, value);
                this.OnPropertyChanged("msdyn_postconfig_wallsavedquery");
            }
        }

        /// <summary>
        /// N:1 lk_msdyn_postconfig_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_msdyn_postconfig_createdby")]
        public SystemUser lk_msdyn_postconfig_createdby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_msdyn_postconfig_createdby", null); }
        }

        /// <summary>
        /// N:1 lk_msdyn_postconfig_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_msdyn_postconfig_createdonbehalfby")]
        public SystemUser lk_msdyn_postconfig_createdonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_msdyn_postconfig_createdonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_msdyn_postconfig_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_msdyn_postconfig_modifiedby")]
        public SystemUser lk_msdyn_postconfig_modifiedby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_msdyn_postconfig_modifiedby", null); }
        }

        /// <summary>
        /// N:1 lk_msdyn_postconfig_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_msdyn_postconfig_modifiedonbehalfby")]
        public SystemUser lk_msdyn_postconfig_modifiedonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_msdyn_postconfig_modifiedonbehalfby", null); }
        }

        /// <summary>
        /// N:1 organization_msdyn_postconfig
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_msdyn_postconfig")]
        public Organization organization_msdyn_postconfig
        {
            get { return this.GetRelatedEntity<Organization>("organization_msdyn_postconfig", null); }
        }
    }
}