namespace __4_DAL_CRM
{
    /// <summary>
    /// Contains information regarding which views are available for users to display on their personal walls. Only an administrator can specify the views that users can choose from to display on their personal walls.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("msdyn_wallsavedquery")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class msdyn_wallsavedquery : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public msdyn_wallsavedquery() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "msdyn_wallsavedquery";

        public const int EntityTypeCode = 10003;

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
        /// Type of entity to which the corresponding views belong
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
        /// Information that indicates whether the entity is virtual, that is whether, it is generated by a plug-in, and no corresponding entity instance exists.
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
        /// Indicates that corresponding system view should be displayed on personal wall
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_isvisible")]
        public System.Nullable<bool> msdyn_IsVisible
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("msdyn_isvisible"); }
            set
            {
                this.OnPropertyChanging("msdyn_IsVisible");
                this.SetAttributeValue("msdyn_isvisible", value);
                this.OnPropertyChanged("msdyn_IsVisible");
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
        /// Type of entity to which the corresponding views belong.
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
        /// Unique identifier for Post Configuration associated with Wall View.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_postconfigurationid")]
        public Microsoft.Xrm.Sdk.EntityReference msdyn_postconfigurationid
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("msdyn_postconfigurationid"); }
            set
            {
                this.OnPropertyChanging("msdyn_postconfigurationid");
                this.SetAttributeValue("msdyn_postconfigurationid", value);
                this.OnPropertyChanged("msdyn_postconfigurationid");
            }
        }

        /// <summary>
        /// Unique identifier of the view that should be displayed on the personal wall for all users.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_savedqueryid")]
        public string msdyn_SavedQueryId
        {
            get { return this.GetAttributeValue<string>("msdyn_savedqueryid"); }
            set
            {
                this.OnPropertyChanging("msdyn_SavedQueryId");
                this.SetAttributeValue("msdyn_savedqueryid", value);
                this.OnPropertyChanged("msdyn_SavedQueryId");
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
        /// Unique identifier for entity instances
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_wallsavedqueryid")]
        public System.Nullable<System.Guid> msdyn_wallsavedqueryId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("msdyn_wallsavedqueryid"); }
            set
            {
                this.OnPropertyChanging("msdyn_wallsavedqueryId");
                this.SetAttributeValue("msdyn_wallsavedqueryid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("msdyn_wallsavedqueryId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_wallsavedqueryid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.msdyn_wallsavedqueryId = value; }
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
        /// Status of the Wall View
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
        public System.Nullable<msdyn_wallsavedqueryState> statecode
        {
            get
            {
                Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
                if ((optionSet != null))
                {
                    return ((msdyn_wallsavedqueryState) (System.Enum.ToObject(typeof(msdyn_wallsavedqueryState), optionSet.Value)));
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// Reason for the status of the Wall View
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
        /// 1:N msdyn_wallsavedquery_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_wallsavedquery_AsyncOperations")]
        public System.Collections.Generic.IEnumerable<AsyncOperation> msdyn_wallsavedquery_AsyncOperations
        {
            get { return this.GetRelatedEntities<AsyncOperation>("msdyn_wallsavedquery_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("msdyn_wallsavedquery_AsyncOperations");
                this.SetRelatedEntities<AsyncOperation>("msdyn_wallsavedquery_AsyncOperations", null, value);
                this.OnPropertyChanged("msdyn_wallsavedquery_AsyncOperations");
            }
        }

        /// <summary>
        /// 1:N msdyn_wallsavedquery_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_wallsavedquery_BulkDeleteFailures")]
        public System.Collections.Generic.IEnumerable<BulkDeleteFailure> msdyn_wallsavedquery_BulkDeleteFailures
        {
            get { return this.GetRelatedEntities<BulkDeleteFailure>("msdyn_wallsavedquery_BulkDeleteFailures", null); }
            set
            {
                this.OnPropertyChanging("msdyn_wallsavedquery_BulkDeleteFailures");
                this.SetRelatedEntities<BulkDeleteFailure>("msdyn_wallsavedquery_BulkDeleteFailures", null, value);
                this.OnPropertyChanged("msdyn_wallsavedquery_BulkDeleteFailures");
            }
        }

        /// <summary>
        /// 1:N msdyn_wallsavedquery_PrincipalObjectAttributeAccesses
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_wallsavedquery_PrincipalObjectAttributeAccesses")]
        public System.Collections.Generic.IEnumerable<PrincipalObjectAttributeAccess> msdyn_wallsavedquery_PrincipalObjectAttributeAccesses
        {
            get { return this.GetRelatedEntities<PrincipalObjectAttributeAccess>("msdyn_wallsavedquery_PrincipalObjectAttributeAccesses", null); }
            set
            {
                this.OnPropertyChanging("msdyn_wallsavedquery_PrincipalObjectAttributeAccesses");
                this.SetRelatedEntities<PrincipalObjectAttributeAccess>("msdyn_wallsavedquery_PrincipalObjectAttributeAccesses", null, value);
                this.OnPropertyChanged("msdyn_wallsavedquery_PrincipalObjectAttributeAccesses");
            }
        }

        /// <summary>
        /// 1:N msdyn_wallsavedquery_ProcessSession
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_wallsavedquery_ProcessSession")]
        public System.Collections.Generic.IEnumerable<ProcessSession> msdyn_wallsavedquery_ProcessSession
        {
            get { return this.GetRelatedEntities<ProcessSession>("msdyn_wallsavedquery_ProcessSession", null); }
            set
            {
                this.OnPropertyChanging("msdyn_wallsavedquery_ProcessSession");
                this.SetRelatedEntities<ProcessSession>("msdyn_wallsavedquery_ProcessSession", null, value);
                this.OnPropertyChanged("msdyn_wallsavedquery_ProcessSession");
            }
        }

        /// <summary>
        /// 1:N msdyn_wallsavedquery_UserEntityInstanceDatas
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_wallsavedquery_UserEntityInstanceDatas")]
        public System.Collections.Generic.IEnumerable<UserEntityInstanceData> msdyn_wallsavedquery_UserEntityInstanceDatas
        {
            get { return this.GetRelatedEntities<UserEntityInstanceData>("msdyn_wallsavedquery_UserEntityInstanceDatas", null); }
            set
            {
                this.OnPropertyChanging("msdyn_wallsavedquery_UserEntityInstanceDatas");
                this.SetRelatedEntities<UserEntityInstanceData>("msdyn_wallsavedquery_UserEntityInstanceDatas", null, value);
                this.OnPropertyChanged("msdyn_wallsavedquery_UserEntityInstanceDatas");
            }
        }

        /// <summary>
        /// 1:N msdyn_wallsavedquery_wallsavedqueryusersettings
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_wallsavedquery_wallsavedqueryusersettings")]
        public System.Collections.Generic.IEnumerable<msdyn_wallsavedqueryusersettings> msdyn_wallsavedquery_wallsavedqueryusersettings
        {
            get { return this.GetRelatedEntities<msdyn_wallsavedqueryusersettings>("msdyn_wallsavedquery_wallsavedqueryusersettings", null); }
            set
            {
                this.OnPropertyChanging("msdyn_wallsavedquery_wallsavedqueryusersettings");
                this.SetRelatedEntities<msdyn_wallsavedqueryusersettings>("msdyn_wallsavedquery_wallsavedqueryusersettings", null, value);
                this.OnPropertyChanged("msdyn_wallsavedquery_wallsavedqueryusersettings");
            }
        }

        /// <summary>
        /// N:1 lk_msdyn_wallsavedquery_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_msdyn_wallsavedquery_createdby")]
        public SystemUser lk_msdyn_wallsavedquery_createdby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_msdyn_wallsavedquery_createdby", null); }
        }

        /// <summary>
        /// N:1 lk_msdyn_wallsavedquery_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_msdyn_wallsavedquery_createdonbehalfby")]
        public SystemUser lk_msdyn_wallsavedquery_createdonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_msdyn_wallsavedquery_createdonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_msdyn_wallsavedquery_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_msdyn_wallsavedquery_modifiedby")]
        public SystemUser lk_msdyn_wallsavedquery_modifiedby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_msdyn_wallsavedquery_modifiedby", null); }
        }

        /// <summary>
        /// N:1 lk_msdyn_wallsavedquery_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_msdyn_wallsavedquery_modifiedonbehalfby")]
        public SystemUser lk_msdyn_wallsavedquery_modifiedonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_msdyn_wallsavedquery_modifiedonbehalfby", null); }
        }

        /// <summary>
        /// N:1 msdyn_postconfig_wallsavedquery
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_postconfigurationid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_postconfig_wallsavedquery")]
        public msdyn_PostConfig msdyn_postconfig_wallsavedquery
        {
            get { return this.GetRelatedEntity<msdyn_PostConfig>("msdyn_postconfig_wallsavedquery", null); }
            set
            {
                this.OnPropertyChanging("msdyn_postconfig_wallsavedquery");
                this.SetRelatedEntity<msdyn_PostConfig>("msdyn_postconfig_wallsavedquery", null, value);
                this.OnPropertyChanged("msdyn_postconfig_wallsavedquery");
            }
        }

        /// <summary>
        /// N:1 organization_msdyn_wallsavedquery
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_msdyn_wallsavedquery")]
        public Organization organization_msdyn_wallsavedquery
        {
            get { return this.GetRelatedEntity<Organization>("organization_msdyn_wallsavedquery", null); }
        }
    }
}