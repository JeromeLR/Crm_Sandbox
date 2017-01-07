namespace __4_DAL_CRM
{
    /// <summary>
    /// Contains user personalization information regarding which of the administrator’s selected views to display on a user’s personal wall.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("msdyn_wallsavedqueryusersettings")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class msdyn_wallsavedqueryusersettings : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public msdyn_wallsavedqueryusersettings() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "msdyn_wallsavedqueryusersettings";

        public const int EntityTypeCode = 10004;

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
        /// XML blob that stores personalization data for the user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_data")]
        public string msdyn_data
        {
            get { return this.GetAttributeValue<string>("msdyn_data"); }
            set
            {
                this.OnPropertyChanging("msdyn_data");
                this.SetAttributeValue("msdyn_data", value);
                this.OnPropertyChanged("msdyn_data");
            }
        }

        /// <summary>
        /// Indicates that view is selected by default if value is greater than 0. Also contains information which specific filter is applied.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_default")]
        public System.Nullable<int> msdyn_default
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("msdyn_default"); }
            set
            {
                this.OnPropertyChanging("msdyn_default");
                this.SetAttributeValue("msdyn_default", value);
                this.OnPropertyChanged("msdyn_default");
            }
        }

        /// <summary>
        /// Display name of the entity to which the corresponding views belong.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_entitydisplayname")]
        public string msdyn_entitydisplayname
        {
            get { return this.GetAttributeValue<string>("msdyn_entitydisplayname"); }
            set
            {
                this.OnPropertyChanging("msdyn_entitydisplayname");
                this.SetAttributeValue("msdyn_entitydisplayname", value);
                this.OnPropertyChanged("msdyn_entitydisplayname");
            }
        }

        /// <summary>
        /// Name of the entity to which the corresponding views belong.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_entityname")]
        public string msdyn_entityname
        {
            get { return this.GetAttributeValue<string>("msdyn_entityname"); }
            set
            {
                this.OnPropertyChanging("msdyn_entityname");
                this.SetAttributeValue("msdyn_entityname", value);
                this.OnPropertyChanged("msdyn_entityname");
            }
        }

        /// <summary>
        /// Indicates that wall should be included in response to avoid roundtrips to server
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_includewallinresponse")]
        public System.Nullable<bool> msdyn_includewallinresponse
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("msdyn_includewallinresponse"); }
            set
            {
                this.OnPropertyChanging("msdyn_includewallinresponse");
                this.SetAttributeValue("msdyn_includewallinresponse", value);
                this.OnPropertyChanged("msdyn_includewallinresponse");
            }
        }

        /// <summary>
        /// Indicates that corresponding view is following view
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_isfollowing")]
        public System.Nullable<bool> msdyn_isfollowing
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("msdyn_isfollowing"); }
            set
            {
                this.OnPropertyChanging("msdyn_isfollowing");
                this.SetAttributeValue("msdyn_isfollowing", value);
                this.OnPropertyChanged("msdyn_isfollowing");
            }
        }

        /// <summary>
        /// Indicates that the record is virtual
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_isvirtual")]
        public System.Nullable<bool> msdyn_IsVirtual
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("msdyn_isvirtual"); }
            set
            {
                this.OnPropertyChanging("msdyn_IsVirtual");
                this.SetAttributeValue("msdyn_isvirtual", value);
                this.OnPropertyChanged("msdyn_IsVirtual");
            }
        }

        /// <summary>
        /// Information that indicates whether the corresponding view should be displayed on the personal wall for this user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_isvisible")]
        public System.Nullable<bool> msdyn_isvisible
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("msdyn_isvisible"); }
            set
            {
                this.OnPropertyChanging("msdyn_isvisible");
                this.SetAttributeValue("msdyn_isvisible", value);
                this.OnPropertyChanged("msdyn_isvisible");
            }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_isvisiblebit")]
        public System.Nullable<int> msdyn_isvisiblebit
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("msdyn_isvisiblebit"); }
            set
            {
                this.OnPropertyChanging("msdyn_isvisiblebit");
                this.SetAttributeValue("msdyn_isvisiblebit", value);
                this.OnPropertyChanged("msdyn_isvisiblebit");
            }
        }

        /// <summary>
        /// Virtual column which contains entity type code for the entities returned by corresponding savedquery
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_otc")]
        public System.Nullable<int> msdyn_otc
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("msdyn_otc"); }
            set
            {
                this.OnPropertyChanging("msdyn_otc");
                this.SetAttributeValue("msdyn_otc", value);
                this.OnPropertyChanged("msdyn_otc");
            }
        }

        /// <summary>
        /// Name of the corresponding view.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_savedqueryname")]
        public string msdyn_savedqueryname
        {
            get { return this.GetAttributeValue<string>("msdyn_savedqueryname"); }
            set
            {
                this.OnPropertyChanging("msdyn_savedqueryname");
                this.SetAttributeValue("msdyn_savedqueryname", value);
                this.OnPropertyChanged("msdyn_savedqueryname");
            }
        }

        /// <summary>
        /// Sort order to be used when displaying the filter on the user’s personal wall.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_sortorder")]
        public System.Nullable<int> msdyn_sortorder
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("msdyn_sortorder"); }
            set
            {
                this.OnPropertyChanging("msdyn_sortorder");
                this.SetAttributeValue("msdyn_sortorder", value);
                this.OnPropertyChanged("msdyn_sortorder");
            }
        }

        /// <summary>
        /// Reserved to support different view types. Currently not used.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_type")]
        public System.Nullable<int> msdyn_type
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("msdyn_type"); }
            set
            {
                this.OnPropertyChanging("msdyn_type");
                this.SetAttributeValue("msdyn_type", value);
                this.OnPropertyChanged("msdyn_type");
            }
        }

        /// <summary>
        /// Unique identifier for User associated with Wall View User Setting.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_userid")]
        public Microsoft.Xrm.Sdk.EntityReference msdyn_userid
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("msdyn_userid"); }
            set
            {
                this.OnPropertyChanging("msdyn_userid");
                this.SetAttributeValue("msdyn_userid", value);
                this.OnPropertyChanged("msdyn_userid");
            }
        }

        /// <summary>
        /// Unique identifier for Wall View associated with Wall View User Setting.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_wallsavedqueryid")]
        public Microsoft.Xrm.Sdk.EntityReference msdyn_wallsavedqueryid
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("msdyn_wallsavedqueryid"); }
            set
            {
                this.OnPropertyChanging("msdyn_wallsavedqueryid");
                this.SetAttributeValue("msdyn_wallsavedqueryid", value);
                this.OnPropertyChanged("msdyn_wallsavedqueryid");
            }
        }

        /// <summary>
        /// Unique identifier for entity instances
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_wallsavedqueryusersettingsid")]
        public System.Nullable<System.Guid> msdyn_wallsavedqueryusersettingsId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("msdyn_wallsavedqueryusersettingsid"); }
            set
            {
                this.OnPropertyChanging("msdyn_wallsavedqueryusersettingsId");
                this.SetAttributeValue("msdyn_wallsavedqueryusersettingsid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("msdyn_wallsavedqueryusersettingsId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_wallsavedqueryusersettingsid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.msdyn_wallsavedqueryusersettingsId = value; }
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
        /// Owner Id
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
        /// Unique identifier for the business unit that owns the record
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
        public Microsoft.Xrm.Sdk.EntityReference OwningBusinessUnit
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningbusinessunit"); }
        }

        /// <summary>
        /// Unique identifier for the team that owns the record.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
        public Microsoft.Xrm.Sdk.EntityReference OwningTeam
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningteam"); }
        }

        /// <summary>
        /// Unique identifier for the user that owns the record.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
        public Microsoft.Xrm.Sdk.EntityReference OwningUser
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owninguser"); }
        }

        /// <summary>
        /// Status of the Wall View User Setting
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
        public System.Nullable<msdyn_wallsavedqueryusersettingsState> statecode
        {
            get
            {
                Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
                if ((optionSet != null))
                {
                    return ((msdyn_wallsavedqueryusersettingsState) (System.Enum.ToObject(typeof(msdyn_wallsavedqueryusersettingsState), optionSet.Value)));
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// Reason for the status of the Wall View User Setting
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
        /// 1:N msdyn_wallsavedqueryusersettings_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_wallsavedqueryusersettings_AsyncOperations")]
        public System.Collections.Generic.IEnumerable<AsyncOperation> msdyn_wallsavedqueryusersettings_AsyncOperations
        {
            get { return this.GetRelatedEntities<AsyncOperation>("msdyn_wallsavedqueryusersettings_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("msdyn_wallsavedqueryusersettings_AsyncOperations");
                this.SetRelatedEntities<AsyncOperation>("msdyn_wallsavedqueryusersettings_AsyncOperations", null, value);
                this.OnPropertyChanged("msdyn_wallsavedqueryusersettings_AsyncOperations");
            }
        }

        /// <summary>
        /// 1:N msdyn_wallsavedqueryusersettings_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_wallsavedqueryusersettings_BulkDeleteFailures")]
        public System.Collections.Generic.IEnumerable<BulkDeleteFailure> msdyn_wallsavedqueryusersettings_BulkDeleteFailures
        {
            get { return this.GetRelatedEntities<BulkDeleteFailure>("msdyn_wallsavedqueryusersettings_BulkDeleteFailures", null); }
            set
            {
                this.OnPropertyChanging("msdyn_wallsavedqueryusersettings_BulkDeleteFailures");
                this.SetRelatedEntities<BulkDeleteFailure>("msdyn_wallsavedqueryusersettings_BulkDeleteFailures", null, value);
                this.OnPropertyChanged("msdyn_wallsavedqueryusersettings_BulkDeleteFailures");
            }
        }

        /// <summary>
        /// 1:N msdyn_wallsavedqueryusersettings_PrincipalObjectAttributeAccesses
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_wallsavedqueryusersettings_PrincipalObjectAttributeAccesses")]
        public System.Collections.Generic.IEnumerable<PrincipalObjectAttributeAccess> msdyn_wallsavedqueryusersettings_PrincipalObjectAttributeAccesses
        {
            get { return this.GetRelatedEntities<PrincipalObjectAttributeAccess>("msdyn_wallsavedqueryusersettings_PrincipalObjectAttributeAccesses", null); }
            set
            {
                this.OnPropertyChanging("msdyn_wallsavedqueryusersettings_PrincipalObjectAttributeAccesses");
                this.SetRelatedEntities<PrincipalObjectAttributeAccess>("msdyn_wallsavedqueryusersettings_PrincipalObjectAttributeAccesses", null, value);
                this.OnPropertyChanged("msdyn_wallsavedqueryusersettings_PrincipalObjectAttributeAccesses");
            }
        }

        /// <summary>
        /// 1:N msdyn_wallsavedqueryusersettings_ProcessSession
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_wallsavedqueryusersettings_ProcessSession")]
        public System.Collections.Generic.IEnumerable<ProcessSession> msdyn_wallsavedqueryusersettings_ProcessSession
        {
            get { return this.GetRelatedEntities<ProcessSession>("msdyn_wallsavedqueryusersettings_ProcessSession", null); }
            set
            {
                this.OnPropertyChanging("msdyn_wallsavedqueryusersettings_ProcessSession");
                this.SetRelatedEntities<ProcessSession>("msdyn_wallsavedqueryusersettings_ProcessSession", null, value);
                this.OnPropertyChanged("msdyn_wallsavedqueryusersettings_ProcessSession");
            }
        }

        /// <summary>
        /// 1:N msdyn_wallsavedqueryusersettings_UserEntityInstanceDatas
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_wallsavedqueryusersettings_UserEntityInstanceDatas")]
        public System.Collections.Generic.IEnumerable<UserEntityInstanceData> msdyn_wallsavedqueryusersettings_UserEntityInstanceDatas
        {
            get { return this.GetRelatedEntities<UserEntityInstanceData>("msdyn_wallsavedqueryusersettings_UserEntityInstanceDatas", null); }
            set
            {
                this.OnPropertyChanging("msdyn_wallsavedqueryusersettings_UserEntityInstanceDatas");
                this.SetRelatedEntities<UserEntityInstanceData>("msdyn_wallsavedqueryusersettings_UserEntityInstanceDatas", null, value);
                this.OnPropertyChanged("msdyn_wallsavedqueryusersettings_UserEntityInstanceDatas");
            }
        }

        /// <summary>
        /// N:1 business_unit_msdyn_wallsavedqueryusersettings
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_msdyn_wallsavedqueryusersettings")]
        public BusinessUnit business_unit_msdyn_wallsavedqueryusersettings
        {
            get { return this.GetRelatedEntity<BusinessUnit>("business_unit_msdyn_wallsavedqueryusersettings", null); }
        }

        /// <summary>
        /// N:1 lk_msdyn_wallsavedqueryusersettings_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_msdyn_wallsavedqueryusersettings_createdby")]
        public SystemUser lk_msdyn_wallsavedqueryusersettings_createdby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_msdyn_wallsavedqueryusersettings_createdby", null); }
        }

        /// <summary>
        /// N:1 lk_msdyn_wallsavedqueryusersettings_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_msdyn_wallsavedqueryusersettings_createdonbehalfby")]
        public SystemUser lk_msdyn_wallsavedqueryusersettings_createdonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_msdyn_wallsavedqueryusersettings_createdonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_msdyn_wallsavedqueryusersettings_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_msdyn_wallsavedqueryusersettings_modifiedby")]
        public SystemUser lk_msdyn_wallsavedqueryusersettings_modifiedby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_msdyn_wallsavedqueryusersettings_modifiedby", null); }
        }

        /// <summary>
        /// N:1 lk_msdyn_wallsavedqueryusersettings_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_msdyn_wallsavedqueryusersettings_modifiedonbehalfby")]
        public SystemUser lk_msdyn_wallsavedqueryusersettings_modifiedonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_msdyn_wallsavedqueryusersettings_modifiedonbehalfby", null); }
        }

        /// <summary>
        /// N:1 msdyn_systemuser_wallsavedqueryusersettings_userid
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_userid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_systemuser_wallsavedqueryusersettings_userid")]
        public SystemUser msdyn_systemuser_wallsavedqueryusersettings_userid
        {
            get { return this.GetRelatedEntity<SystemUser>("msdyn_systemuser_wallsavedqueryusersettings_userid", null); }
            set
            {
                this.OnPropertyChanging("msdyn_systemuser_wallsavedqueryusersettings_userid");
                this.SetRelatedEntity<SystemUser>("msdyn_systemuser_wallsavedqueryusersettings_userid", null, value);
                this.OnPropertyChanged("msdyn_systemuser_wallsavedqueryusersettings_userid");
            }
        }

        /// <summary>
        /// N:1 msdyn_wallsavedquery_wallsavedqueryusersettings
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_wallsavedqueryid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_wallsavedquery_wallsavedqueryusersettings")]
        public msdyn_wallsavedquery msdyn_wallsavedquery_wallsavedqueryusersettings
        {
            get { return this.GetRelatedEntity<msdyn_wallsavedquery>("msdyn_wallsavedquery_wallsavedqueryusersettings", null); }
            set
            {
                this.OnPropertyChanging("msdyn_wallsavedquery_wallsavedqueryusersettings");
                this.SetRelatedEntity<msdyn_wallsavedquery>("msdyn_wallsavedquery_wallsavedqueryusersettings", null, value);
                this.OnPropertyChanged("msdyn_wallsavedquery_wallsavedqueryusersettings");
            }
        }

        /// <summary>
        /// N:1 team_msdyn_wallsavedqueryusersettings
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_msdyn_wallsavedqueryusersettings")]
        public Team team_msdyn_wallsavedqueryusersettings
        {
            get { return this.GetRelatedEntity<Team>("team_msdyn_wallsavedqueryusersettings", null); }
        }

        /// <summary>
        /// N:1 user_msdyn_wallsavedqueryusersettings
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_msdyn_wallsavedqueryusersettings")]
        public SystemUser user_msdyn_wallsavedqueryusersettings
        {
            get { return this.GetRelatedEntity<SystemUser>("user_msdyn_wallsavedqueryusersettings", null); }
        }
    }
}