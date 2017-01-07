using _4_DAL_CRM;

namespace __4_DAL_CRM
{
    /// <summary>
    /// Resource that can be scheduled.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("equipment")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class Equipment : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public Equipment() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "equipment";

        public const int EntityTypeCode = 4000;

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
        /// Unique identifier of the associated business unit.
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
        /// Fiscal calendar associated with the facility/equipment.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("calendarid")]
        public Microsoft.Xrm.Sdk.EntityReference CalendarId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("calendarid"); }
            set
            {
                this.OnPropertyChanging("CalendarId");
                this.SetAttributeValue("calendarid", value);
                this.OnPropertyChanged("CalendarId");
            }
        }

        /// <summary>
        /// Unique identifier of the user who created the facility/equipment entry.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby"); }
        }

        /// <summary>
        /// Date and time when the facility/equipment entry was created.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
        public System.Nullable<System.DateTime> CreatedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who created the equipment.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        /// Description of the facility/equipment.
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
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("displayinserviceviews")]
        public System.Nullable<bool> DisplayInServiceViews
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("displayinserviceviews"); }
            set
            {
                this.OnPropertyChanging("DisplayInServiceViews");
                this.SetAttributeValue("displayinserviceviews", value);
                this.OnPropertyChanged("DisplayInServiceViews");
            }
        }

        /// <summary>
        /// Email address of person to contact about the use of the facility/equipment.
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
        /// Unique identifier of the facility/equipment.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("equipmentid")]
        public System.Nullable<System.Guid> EquipmentId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("equipmentid"); }
            set
            {
                this.OnPropertyChanging("EquipmentId");
                this.SetAttributeValue("equipmentid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("EquipmentId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("equipmentid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.EquipmentId = value; }
        }

        /// <summary>
        /// Exchange rate for the currency associated with the equipment with respect to the base currency.
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
        /// Whether the facility/equipment is disabled or operational.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isdisabled")]
        public System.Nullable<bool> IsDisabled
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("isdisabled"); }
            set
            {
                this.OnPropertyChanging("IsDisabled");
                this.SetAttributeValue("isdisabled", value);
                this.OnPropertyChanged("IsDisabled");
            }
        }

        /// <summary>
        /// Unique identifier of the user who last modified the facility/equipment.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby"); }
        }

        /// <summary>
        /// Date and time when the facility/equipment entry was last modified.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
        public System.Nullable<System.DateTime> ModifiedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who last modified the equipment.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        /// Name of the facility/equipment.
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
        /// Unique identifier of the parent business unit.
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
        /// Site where the facility/equipment is located.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("siteid")]
        public Microsoft.Xrm.Sdk.EntityReference SiteId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("siteid"); }
            set
            {
                this.OnPropertyChanging("SiteId");
                this.SetAttributeValue("siteid", value);
                this.OnPropertyChanged("SiteId");
            }
        }

        /// <summary>
        /// Skills needed to operate the facility/equipment.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("skills")]
        public string Skills
        {
            get { return this.GetAttributeValue<string>("skills"); }
            set
            {
                this.OnPropertyChanging("Skills");
                this.SetAttributeValue("skills", value);
                this.OnPropertyChanged("Skills");
            }
        }

        /// <summary>
        /// Local time zone where the facility/equipment is located.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("timezonecode")]
        public System.Nullable<int> TimeZoneCode
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("timezonecode"); }
            set
            {
                this.OnPropertyChanging("TimeZoneCode");
                this.SetAttributeValue("timezonecode", value);
                this.OnPropertyChanged("TimeZoneCode");
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
        /// Unique identifier of the currency associated with the equipment.
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
        /// Version number of the equipment.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
        public System.Nullable<long> VersionNumber
        {
            get { return this.GetAttributeValue<System.Nullable<long>>("versionnumber"); }
        }

        /// <summary>
        /// 1:N equipment_accounts
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("equipment_accounts")]
        public System.Collections.Generic.IEnumerable<Account> equipment_accounts
        {
            get { return this.GetRelatedEntities<Account>("equipment_accounts", null); }
            set
            {
                this.OnPropertyChanging("equipment_accounts");
                this.SetRelatedEntities<Account>("equipment_accounts", null, value);
                this.OnPropertyChanged("equipment_accounts");
            }
        }

        /// <summary>
        /// 1:N equipment_activity_parties
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("equipment_activity_parties")]
        public System.Collections.Generic.IEnumerable<ActivityParty> equipment_activity_parties
        {
            get { return this.GetRelatedEntities<ActivityParty>("equipment_activity_parties", null); }
            set
            {
                this.OnPropertyChanging("equipment_activity_parties");
                this.SetRelatedEntities<ActivityParty>("equipment_activity_parties", null, value);
                this.OnPropertyChanged("equipment_activity_parties");
            }
        }

        /// <summary>
        /// 1:N Equipment_Annotation
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Equipment_Annotation")]
        public System.Collections.Generic.IEnumerable<Annotation> Equipment_Annotation
        {
            get { return this.GetRelatedEntities<Annotation>("Equipment_Annotation", null); }
            set
            {
                this.OnPropertyChanging("Equipment_Annotation");
                this.SetRelatedEntities<Annotation>("Equipment_Annotation", null, value);
                this.OnPropertyChanged("Equipment_Annotation");
            }
        }

        /// <summary>
        /// 1:N Equipment_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Equipment_AsyncOperations")]
        public System.Collections.Generic.IEnumerable<AsyncOperation> Equipment_AsyncOperations
        {
            get { return this.GetRelatedEntities<AsyncOperation>("Equipment_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("Equipment_AsyncOperations");
                this.SetRelatedEntities<AsyncOperation>("Equipment_AsyncOperations", null, value);
                this.OnPropertyChanged("Equipment_AsyncOperations");
            }
        }

        /// <summary>
        /// 1:N Equipment_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Equipment_BulkDeleteFailures")]
        public System.Collections.Generic.IEnumerable<BulkDeleteFailure> Equipment_BulkDeleteFailures
        {
            get { return this.GetRelatedEntities<BulkDeleteFailure>("Equipment_BulkDeleteFailures", null); }
            set
            {
                this.OnPropertyChanging("Equipment_BulkDeleteFailures");
                this.SetRelatedEntities<BulkDeleteFailure>("Equipment_BulkDeleteFailures", null, value);
                this.OnPropertyChanged("Equipment_BulkDeleteFailures");
            }
        }

        /// <summary>
        /// 1:N equipment_connections1
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("equipment_connections1")]
        public System.Collections.Generic.IEnumerable<Connection> equipment_connections1
        {
            get { return this.GetRelatedEntities<Connection>("equipment_connections1", null); }
            set
            {
                this.OnPropertyChanging("equipment_connections1");
                this.SetRelatedEntities<Connection>("equipment_connections1", null, value);
                this.OnPropertyChanged("equipment_connections1");
            }
        }

        /// <summary>
        /// 1:N equipment_connections2
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("equipment_connections2")]
        public System.Collections.Generic.IEnumerable<Connection> equipment_connections2
        {
            get { return this.GetRelatedEntities<Connection>("equipment_connections2", null); }
            set
            {
                this.OnPropertyChanging("equipment_connections2");
                this.SetRelatedEntities<Connection>("equipment_connections2", null, value);
                this.OnPropertyChanged("equipment_connections2");
            }
        }

        /// <summary>
        /// 1:N equipment_contacts
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("equipment_contacts")]
        public System.Collections.Generic.IEnumerable<Contact> equipment_contacts
        {
            get { return this.GetRelatedEntities<Contact>("equipment_contacts", null); }
            set
            {
                this.OnPropertyChanging("equipment_contacts");
                this.SetRelatedEntities<Contact>("equipment_contacts", null, value);
                this.OnPropertyChanged("equipment_contacts");
            }
        }

        /// <summary>
        /// 1:N Equipment_DuplicateBaseRecord
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Equipment_DuplicateBaseRecord")]
        public System.Collections.Generic.IEnumerable<DuplicateRecord> Equipment_DuplicateBaseRecord
        {
            get { return this.GetRelatedEntities<DuplicateRecord>("Equipment_DuplicateBaseRecord", null); }
            set
            {
                this.OnPropertyChanging("Equipment_DuplicateBaseRecord");
                this.SetRelatedEntities<DuplicateRecord>("Equipment_DuplicateBaseRecord", null, value);
                this.OnPropertyChanged("Equipment_DuplicateBaseRecord");
            }
        }

        /// <summary>
        /// 1:N Equipment_DuplicateMatchingRecord
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Equipment_DuplicateMatchingRecord")]
        public System.Collections.Generic.IEnumerable<DuplicateRecord> Equipment_DuplicateMatchingRecord
        {
            get { return this.GetRelatedEntities<DuplicateRecord>("Equipment_DuplicateMatchingRecord", null); }
            set
            {
                this.OnPropertyChanging("Equipment_DuplicateMatchingRecord");
                this.SetRelatedEntities<DuplicateRecord>("Equipment_DuplicateMatchingRecord", null, value);
                this.OnPropertyChanged("Equipment_DuplicateMatchingRecord");
            }
        }

        /// <summary>
        /// 1:N Equipment_Email_EmailSender
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Equipment_Email_EmailSender")]
        public System.Collections.Generic.IEnumerable<Email> Equipment_Email_EmailSender
        {
            get { return this.GetRelatedEntities<Email>("Equipment_Email_EmailSender", null); }
            set
            {
                this.OnPropertyChanging("Equipment_Email_EmailSender");
                this.SetRelatedEntities<Email>("Equipment_Email_EmailSender", null, value);
                this.OnPropertyChanged("Equipment_Email_EmailSender");
            }
        }

        /// <summary>
        /// 1:N equipment_principalobjectattributeaccess
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("equipment_principalobjectattributeaccess")]
        public System.Collections.Generic.IEnumerable<PrincipalObjectAttributeAccess> equipment_principalobjectattributeaccess
        {
            get { return this.GetRelatedEntities<PrincipalObjectAttributeAccess>("equipment_principalobjectattributeaccess", null); }
            set
            {
                this.OnPropertyChanging("equipment_principalobjectattributeaccess");
                this.SetRelatedEntities<PrincipalObjectAttributeAccess>("equipment_principalobjectattributeaccess", null, value);
                this.OnPropertyChanged("equipment_principalobjectattributeaccess");
            }
        }

        /// <summary>
        /// 1:N Equipment_ProcessSessions
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Equipment_ProcessSessions")]
        public System.Collections.Generic.IEnumerable<ProcessSession> Equipment_ProcessSessions
        {
            get { return this.GetRelatedEntities<ProcessSession>("Equipment_ProcessSessions", null); }
            set
            {
                this.OnPropertyChanging("Equipment_ProcessSessions");
                this.SetRelatedEntities<ProcessSession>("Equipment_ProcessSessions", null, value);
                this.OnPropertyChanged("Equipment_ProcessSessions");
            }
        }

        /// <summary>
        /// 1:N equipment_resources
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("equipment_resources")]
        public System.Collections.Generic.IEnumerable<Resource> equipment_resources
        {
            get { return this.GetRelatedEntities<Resource>("equipment_resources", null); }
            set
            {
                this.OnPropertyChanging("equipment_resources");
                this.SetRelatedEntities<Resource>("equipment_resources", null, value);
                this.OnPropertyChanged("equipment_resources");
            }
        }

        /// <summary>
        /// 1:N userentityinstancedata_equipment
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_equipment")]
        public System.Collections.Generic.IEnumerable<UserEntityInstanceData> userentityinstancedata_equipment
        {
            get { return this.GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_equipment", null); }
            set
            {
                this.OnPropertyChanging("userentityinstancedata_equipment");
                this.SetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_equipment", null, value);
                this.OnPropertyChanged("userentityinstancedata_equipment");
            }
        }

        /// <summary>
        /// N:1 business_unit_equipment
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("businessunitid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_equipment")]
        public BusinessUnit business_unit_equipment
        {
            get { return this.GetRelatedEntity<BusinessUnit>("business_unit_equipment", null); }
            set
            {
                this.OnPropertyChanging("business_unit_equipment");
                this.SetRelatedEntity<BusinessUnit>("business_unit_equipment", null, value);
                this.OnPropertyChanged("business_unit_equipment");
            }
        }

        /// <summary>
        /// N:1 calendar_equipment
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("calendarid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("calendar_equipment")]
        public Calendar calendar_equipment
        {
            get { return this.GetRelatedEntity<Calendar>("calendar_equipment", null); }
            set
            {
                this.OnPropertyChanging("calendar_equipment");
                this.SetRelatedEntity<Calendar>("calendar_equipment", null, value);
                this.OnPropertyChanged("calendar_equipment");
            }
        }

        /// <summary>
        /// N:1 equipment_systemuser
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("businessunitid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("equipment_systemuser")]
        public SystemUser equipment_systemuser
        {
            get { return this.GetRelatedEntity<SystemUser>("equipment_systemuser", null); }
            set
            {
                this.OnPropertyChanging("equipment_systemuser");
                this.SetRelatedEntity<SystemUser>("equipment_systemuser", null, value);
                this.OnPropertyChanged("equipment_systemuser");
            }
        }

        /// <summary>
        /// N:1 lk_equipment_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_equipment_createdby")]
        public SystemUser lk_equipment_createdby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_equipment_createdby", null); }
        }

        /// <summary>
        /// N:1 lk_equipment_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_equipment_createdonbehalfby")]
        public SystemUser lk_equipment_createdonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_equipment_createdonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_equipment_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_equipment_modifiedby")]
        public SystemUser lk_equipment_modifiedby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_equipment_modifiedby", null); }
        }

        /// <summary>
        /// N:1 lk_equipment_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_equipment_modifiedonbehalfby")]
        public SystemUser lk_equipment_modifiedonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_equipment_modifiedonbehalfby", null); }
        }

        /// <summary>
        /// N:1 organization_equipment
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_equipment")]
        public Organization organization_equipment
        {
            get { return this.GetRelatedEntity<Organization>("organization_equipment", null); }
        }

        /// <summary>
        /// N:1 site_equipment
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("siteid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("site_equipment")]
        public Site site_equipment
        {
            get { return this.GetRelatedEntity<Site>("site_equipment", null); }
            set
            {
                this.OnPropertyChanging("site_equipment");
                this.SetRelatedEntity<Site>("site_equipment", null, value);
                this.OnPropertyChanged("site_equipment");
            }
        }

        /// <summary>
        /// N:1 TransactionCurrency_Equipment
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("TransactionCurrency_Equipment")]
        public TransactionCurrency TransactionCurrency_Equipment
        {
            get { return this.GetRelatedEntity<TransactionCurrency>("TransactionCurrency_Equipment", null); }
            set
            {
                this.OnPropertyChanging("TransactionCurrency_Equipment");
                this.SetRelatedEntity<TransactionCurrency>("TransactionCurrency_Equipment", null, value);
                this.OnPropertyChanged("TransactionCurrency_Equipment");
            }
        }
    }
}