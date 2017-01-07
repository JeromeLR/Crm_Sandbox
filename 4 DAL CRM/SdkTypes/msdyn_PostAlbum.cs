namespace __4_DAL_CRM
{
    /// <summary>
    /// Contains user profile images that are stored as attachments and displayed in posts.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("msdyn_postalbum")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class msdyn_PostAlbum : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public msdyn_PostAlbum() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "msdyn_postalbum";

        public const int EntityTypeCode = 10000;

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
        /// The name of the custom entity.
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
        /// Unique identifier for entity instances
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_postalbumid")]
        public System.Nullable<System.Guid> msdyn_PostAlbumId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("msdyn_postalbumid"); }
            set
            {
                this.OnPropertyChanging("msdyn_PostAlbumId");
                this.SetAttributeValue("msdyn_postalbumid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("msdyn_PostAlbumId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_postalbumid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.msdyn_PostAlbumId = value; }
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
        /// Status of the Profile Album
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
        public System.Nullable<msdyn_PostAlbumState> statecode
        {
            get
            {
                Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
                if ((optionSet != null))
                {
                    return ((msdyn_PostAlbumState) (System.Enum.ToObject(typeof(msdyn_PostAlbumState), optionSet.Value)));
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// Reason for the status of the Profile Album
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
        /// 1:N msdyn_postalbum_ActivityPointers
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_postalbum_ActivityPointers")]
        public System.Collections.Generic.IEnumerable<ActivityPointer> msdyn_postalbum_ActivityPointers
        {
            get { return this.GetRelatedEntities<ActivityPointer>("msdyn_postalbum_ActivityPointers", null); }
            set
            {
                this.OnPropertyChanging("msdyn_postalbum_ActivityPointers");
                this.SetRelatedEntities<ActivityPointer>("msdyn_postalbum_ActivityPointers", null, value);
                this.OnPropertyChanged("msdyn_postalbum_ActivityPointers");
            }
        }

        /// <summary>
        /// 1:N msdyn_postalbum_Annotations
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_postalbum_Annotations")]
        public System.Collections.Generic.IEnumerable<Annotation> msdyn_postalbum_Annotations
        {
            get { return this.GetRelatedEntities<Annotation>("msdyn_postalbum_Annotations", null); }
            set
            {
                this.OnPropertyChanging("msdyn_postalbum_Annotations");
                this.SetRelatedEntities<Annotation>("msdyn_postalbum_Annotations", null, value);
                this.OnPropertyChanged("msdyn_postalbum_Annotations");
            }
        }

        /// <summary>
        /// 1:N msdyn_postalbum_Appointments
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_postalbum_Appointments")]
        public System.Collections.Generic.IEnumerable<Appointment> msdyn_postalbum_Appointments
        {
            get { return this.GetRelatedEntities<Appointment>("msdyn_postalbum_Appointments", null); }
            set
            {
                this.OnPropertyChanging("msdyn_postalbum_Appointments");
                this.SetRelatedEntities<Appointment>("msdyn_postalbum_Appointments", null, value);
                this.OnPropertyChanged("msdyn_postalbum_Appointments");
            }
        }

        /// <summary>
        /// 1:N msdyn_postalbum_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_postalbum_AsyncOperations")]
        public System.Collections.Generic.IEnumerable<AsyncOperation> msdyn_postalbum_AsyncOperations
        {
            get { return this.GetRelatedEntities<AsyncOperation>("msdyn_postalbum_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("msdyn_postalbum_AsyncOperations");
                this.SetRelatedEntities<AsyncOperation>("msdyn_postalbum_AsyncOperations", null, value);
                this.OnPropertyChanged("msdyn_postalbum_AsyncOperations");
            }
        }

        /// <summary>
        /// 1:N msdyn_postalbum_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_postalbum_BulkDeleteFailures")]
        public System.Collections.Generic.IEnumerable<BulkDeleteFailure> msdyn_postalbum_BulkDeleteFailures
        {
            get { return this.GetRelatedEntities<BulkDeleteFailure>("msdyn_postalbum_BulkDeleteFailures", null); }
            set
            {
                this.OnPropertyChanging("msdyn_postalbum_BulkDeleteFailures");
                this.SetRelatedEntities<BulkDeleteFailure>("msdyn_postalbum_BulkDeleteFailures", null, value);
                this.OnPropertyChanged("msdyn_postalbum_BulkDeleteFailures");
            }
        }

        /// <summary>
        /// 1:N msdyn_postalbum_connections1
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_postalbum_connections1")]
        public System.Collections.Generic.IEnumerable<Connection> msdyn_postalbum_connections1
        {
            get { return this.GetRelatedEntities<Connection>("msdyn_postalbum_connections1", null); }
            set
            {
                this.OnPropertyChanging("msdyn_postalbum_connections1");
                this.SetRelatedEntities<Connection>("msdyn_postalbum_connections1", null, value);
                this.OnPropertyChanged("msdyn_postalbum_connections1");
            }
        }

        /// <summary>
        /// 1:N msdyn_postalbum_connections2
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_postalbum_connections2")]
        public System.Collections.Generic.IEnumerable<Connection> msdyn_postalbum_connections2
        {
            get { return this.GetRelatedEntities<Connection>("msdyn_postalbum_connections2", null); }
            set
            {
                this.OnPropertyChanging("msdyn_postalbum_connections2");
                this.SetRelatedEntities<Connection>("msdyn_postalbum_connections2", null, value);
                this.OnPropertyChanged("msdyn_postalbum_connections2");
            }
        }

        /// <summary>
        /// 1:N msdyn_postalbum_DuplicateBaseRecord
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_postalbum_DuplicateBaseRecord")]
        public System.Collections.Generic.IEnumerable<DuplicateRecord> msdyn_postalbum_DuplicateBaseRecord
        {
            get { return this.GetRelatedEntities<DuplicateRecord>("msdyn_postalbum_DuplicateBaseRecord", null); }
            set
            {
                this.OnPropertyChanging("msdyn_postalbum_DuplicateBaseRecord");
                this.SetRelatedEntities<DuplicateRecord>("msdyn_postalbum_DuplicateBaseRecord", null, value);
                this.OnPropertyChanged("msdyn_postalbum_DuplicateBaseRecord");
            }
        }

        /// <summary>
        /// 1:N msdyn_postalbum_DuplicateMatchingRecord
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_postalbum_DuplicateMatchingRecord")]
        public System.Collections.Generic.IEnumerable<DuplicateRecord> msdyn_postalbum_DuplicateMatchingRecord
        {
            get { return this.GetRelatedEntities<DuplicateRecord>("msdyn_postalbum_DuplicateMatchingRecord", null); }
            set
            {
                this.OnPropertyChanging("msdyn_postalbum_DuplicateMatchingRecord");
                this.SetRelatedEntities<DuplicateRecord>("msdyn_postalbum_DuplicateMatchingRecord", null, value);
                this.OnPropertyChanged("msdyn_postalbum_DuplicateMatchingRecord");
            }
        }

        /// <summary>
        /// 1:N msdyn_postalbum_Emails
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_postalbum_Emails")]
        public System.Collections.Generic.IEnumerable<Email> msdyn_postalbum_Emails
        {
            get { return this.GetRelatedEntities<Email>("msdyn_postalbum_Emails", null); }
            set
            {
                this.OnPropertyChanging("msdyn_postalbum_Emails");
                this.SetRelatedEntities<Email>("msdyn_postalbum_Emails", null, value);
                this.OnPropertyChanged("msdyn_postalbum_Emails");
            }
        }

        /// <summary>
        /// 1:N msdyn_postalbum_Faxes
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_postalbum_Faxes")]
        public System.Collections.Generic.IEnumerable<Fax> msdyn_postalbum_Faxes
        {
            get { return this.GetRelatedEntities<Fax>("msdyn_postalbum_Faxes", null); }
            set
            {
                this.OnPropertyChanging("msdyn_postalbum_Faxes");
                this.SetRelatedEntities<Fax>("msdyn_postalbum_Faxes", null, value);
                this.OnPropertyChanged("msdyn_postalbum_Faxes");
            }
        }

        /// <summary>
        /// 1:N msdyn_postalbum_Letters
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_postalbum_Letters")]
        public System.Collections.Generic.IEnumerable<Letter> msdyn_postalbum_Letters
        {
            get { return this.GetRelatedEntities<Letter>("msdyn_postalbum_Letters", null); }
            set
            {
                this.OnPropertyChanging("msdyn_postalbum_Letters");
                this.SetRelatedEntities<Letter>("msdyn_postalbum_Letters", null, value);
                this.OnPropertyChanged("msdyn_postalbum_Letters");
            }
        }

        /// <summary>
        /// 1:N msdyn_postalbum_PhoneCalls
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_postalbum_PhoneCalls")]
        public System.Collections.Generic.IEnumerable<PhoneCall> msdyn_postalbum_PhoneCalls
        {
            get { return this.GetRelatedEntities<PhoneCall>("msdyn_postalbum_PhoneCalls", null); }
            set
            {
                this.OnPropertyChanging("msdyn_postalbum_PhoneCalls");
                this.SetRelatedEntities<PhoneCall>("msdyn_postalbum_PhoneCalls", null, value);
                this.OnPropertyChanged("msdyn_postalbum_PhoneCalls");
            }
        }

        /// <summary>
        /// 1:N msdyn_postalbum_PrincipalObjectAttributeAccesses
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_postalbum_PrincipalObjectAttributeAccesses")]
        public System.Collections.Generic.IEnumerable<PrincipalObjectAttributeAccess> msdyn_postalbum_PrincipalObjectAttributeAccesses
        {
            get { return this.GetRelatedEntities<PrincipalObjectAttributeAccess>("msdyn_postalbum_PrincipalObjectAttributeAccesses", null); }
            set
            {
                this.OnPropertyChanging("msdyn_postalbum_PrincipalObjectAttributeAccesses");
                this.SetRelatedEntities<PrincipalObjectAttributeAccess>("msdyn_postalbum_PrincipalObjectAttributeAccesses", null, value);
                this.OnPropertyChanged("msdyn_postalbum_PrincipalObjectAttributeAccesses");
            }
        }

        /// <summary>
        /// 1:N msdyn_postalbum_ProcessSession
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_postalbum_ProcessSession")]
        public System.Collections.Generic.IEnumerable<ProcessSession> msdyn_postalbum_ProcessSession
        {
            get { return this.GetRelatedEntities<ProcessSession>("msdyn_postalbum_ProcessSession", null); }
            set
            {
                this.OnPropertyChanging("msdyn_postalbum_ProcessSession");
                this.SetRelatedEntities<ProcessSession>("msdyn_postalbum_ProcessSession", null, value);
                this.OnPropertyChanged("msdyn_postalbum_ProcessSession");
            }
        }

        /// <summary>
        /// 1:N msdyn_postalbum_RecurringAppointmentMasters
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_postalbum_RecurringAppointmentMasters")]
        public System.Collections.Generic.IEnumerable<RecurringAppointmentMaster> msdyn_postalbum_RecurringAppointmentMasters
        {
            get { return this.GetRelatedEntities<RecurringAppointmentMaster>("msdyn_postalbum_RecurringAppointmentMasters", null); }
            set
            {
                this.OnPropertyChanging("msdyn_postalbum_RecurringAppointmentMasters");
                this.SetRelatedEntities<RecurringAppointmentMaster>("msdyn_postalbum_RecurringAppointmentMasters", null, value);
                this.OnPropertyChanged("msdyn_postalbum_RecurringAppointmentMasters");
            }
        }

        /// <summary>
        /// 1:N msdyn_postalbum_ServiceAppointments
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_postalbum_ServiceAppointments")]
        public System.Collections.Generic.IEnumerable<ServiceAppointment> msdyn_postalbum_ServiceAppointments
        {
            get { return this.GetRelatedEntities<ServiceAppointment>("msdyn_postalbum_ServiceAppointments", null); }
            set
            {
                this.OnPropertyChanging("msdyn_postalbum_ServiceAppointments");
                this.SetRelatedEntities<ServiceAppointment>("msdyn_postalbum_ServiceAppointments", null, value);
                this.OnPropertyChanged("msdyn_postalbum_ServiceAppointments");
            }
        }

        /// <summary>
        /// 1:N msdyn_postalbum_SocialActivities
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_postalbum_SocialActivities")]
        public System.Collections.Generic.IEnumerable<SocialActivity> msdyn_postalbum_SocialActivities
        {
            get { return this.GetRelatedEntities<SocialActivity>("msdyn_postalbum_SocialActivities", null); }
            set
            {
                this.OnPropertyChanging("msdyn_postalbum_SocialActivities");
                this.SetRelatedEntities<SocialActivity>("msdyn_postalbum_SocialActivities", null, value);
                this.OnPropertyChanged("msdyn_postalbum_SocialActivities");
            }
        }

        /// <summary>
        /// 1:N msdyn_postalbum_Tasks
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_postalbum_Tasks")]
        public System.Collections.Generic.IEnumerable<Task> msdyn_postalbum_Tasks
        {
            get { return this.GetRelatedEntities<Task>("msdyn_postalbum_Tasks", null); }
            set
            {
                this.OnPropertyChanging("msdyn_postalbum_Tasks");
                this.SetRelatedEntities<Task>("msdyn_postalbum_Tasks", null, value);
                this.OnPropertyChanged("msdyn_postalbum_Tasks");
            }
        }

        /// <summary>
        /// 1:N msdyn_postalbum_UserEntityInstanceDatas
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_postalbum_UserEntityInstanceDatas")]
        public System.Collections.Generic.IEnumerable<UserEntityInstanceData> msdyn_postalbum_UserEntityInstanceDatas
        {
            get { return this.GetRelatedEntities<UserEntityInstanceData>("msdyn_postalbum_UserEntityInstanceDatas", null); }
            set
            {
                this.OnPropertyChanging("msdyn_postalbum_UserEntityInstanceDatas");
                this.SetRelatedEntities<UserEntityInstanceData>("msdyn_postalbum_UserEntityInstanceDatas", null, value);
                this.OnPropertyChanged("msdyn_postalbum_UserEntityInstanceDatas");
            }
        }

        /// <summary>
        /// N:1 business_unit_msdyn_postalbum
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_msdyn_postalbum")]
        public BusinessUnit business_unit_msdyn_postalbum
        {
            get { return this.GetRelatedEntity<BusinessUnit>("business_unit_msdyn_postalbum", null); }
        }

        /// <summary>
        /// N:1 lk_msdyn_postalbum_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_msdyn_postalbum_createdby")]
        public SystemUser lk_msdyn_postalbum_createdby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_msdyn_postalbum_createdby", null); }
        }

        /// <summary>
        /// N:1 lk_msdyn_postalbum_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_msdyn_postalbum_createdonbehalfby")]
        public SystemUser lk_msdyn_postalbum_createdonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_msdyn_postalbum_createdonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_msdyn_postalbum_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_msdyn_postalbum_modifiedby")]
        public SystemUser lk_msdyn_postalbum_modifiedby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_msdyn_postalbum_modifiedby", null); }
        }

        /// <summary>
        /// N:1 lk_msdyn_postalbum_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_msdyn_postalbum_modifiedonbehalfby")]
        public SystemUser lk_msdyn_postalbum_modifiedonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_msdyn_postalbum_modifiedonbehalfby", null); }
        }

        /// <summary>
        /// N:1 team_msdyn_postalbum
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_msdyn_postalbum")]
        public Team team_msdyn_postalbum
        {
            get { return this.GetRelatedEntity<Team>("team_msdyn_postalbum", null); }
        }

        /// <summary>
        /// N:1 user_msdyn_postalbum
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_msdyn_postalbum")]
        public SystemUser user_msdyn_postalbum
        {
            get { return this.GetRelatedEntity<SystemUser>("user_msdyn_postalbum", null); }
        }
    }
}