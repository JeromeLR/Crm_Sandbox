namespace __4_DAL_CRM
{
    /// <summary>
    /// Contains predefined customer support terms that can be used to created entitlements for customers.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("entitlementtemplate")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class EntitlementTemplate : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public EntitlementTemplate() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "entitlementtemplate";

        public const int EntityTypeCode = 9702;

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
        /// Select whether the entitlement allocation is based on number of cases or number of hours.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("allocationtypecode")]
        public Microsoft.Xrm.Sdk.OptionSetValue AllocationTypeCode
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("allocationtypecode"); }
            set
            {
                this.OnPropertyChanging("AllocationTypeCode");
                this.SetAttributeValue("allocationtypecode", value);
                this.OnPropertyChanged("AllocationTypeCode");
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
        /// Date and time when the entitlement was created.
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
        /// Information about whether to decrease the remaining terms when the case is created or when it is resolved
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("decreaseremainingon")]
        public Microsoft.Xrm.Sdk.OptionSetValue DecreaseRemainingOn
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("decreaseremainingon"); }
            set
            {
                this.OnPropertyChanging("DecreaseRemainingOn");
                this.SetAttributeValue("decreaseremainingon", value);
                this.OnPropertyChanged("DecreaseRemainingOn");
            }
        }

        /// <summary>
        /// Type additional information to describe the account, such as an excerpt from the company's website.
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
        /// Enter the date and time when the entitlement ends.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("enddate")]
        public System.Nullable<System.DateTime> EndDate
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("enddate"); }
            set
            {
                this.OnPropertyChanging("EndDate");
                this.SetAttributeValue("enddate", value);
                this.OnPropertyChanged("EndDate");
            }
        }

        /// <summary>
        /// Unique identifier for entity instances
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entitlementtemplateid")]
        public System.Nullable<System.Guid> EntitlementTemplateId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("entitlementtemplateid"); }
            set
            {
                this.OnPropertyChanging("EntitlementTemplateId");
                this.SetAttributeValue("entitlementtemplateid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("EntitlementTemplateId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entitlementtemplateid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.EntitlementTemplateId = value; }
        }

        /// <summary>
        /// Exchange rate for the currency associated with the contact with respect to the base currency.
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
        /// Select the access someone will have to the knowledge base on the portal.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("kbaccesslevel")]
        public Microsoft.Xrm.Sdk.OptionSetValue KbAccessLevel
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("kbaccesslevel"); }
            set
            {
                this.OnPropertyChanging("KbAccessLevel");
                this.SetAttributeValue("kbaccesslevel", value);
                this.OnPropertyChanged("KbAccessLevel");
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
        /// Type a descriptive name for the entitlement template.
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
        /// Unique identifier of the organization associated with the entitlement template.
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
        /// Tells whether case creation is restricted based on entitlement terms.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("restrictcasecreation")]
        public System.Nullable<bool> RestrictCaseCreation
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("restrictcasecreation"); }
            set
            {
                this.OnPropertyChanging("RestrictCaseCreation");
                this.SetAttributeValue("restrictcasecreation", value);
                this.OnPropertyChanged("RestrictCaseCreation");
            }
        }

        /// <summary>
        /// Choose the service level agreement (SLA) associated with the entitlement.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("slaid")]
        public Microsoft.Xrm.Sdk.EntityReference SLAId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("slaid"); }
            set
            {
                this.OnPropertyChanging("SLAId");
                this.SetAttributeValue("slaid", value);
                this.OnPropertyChanged("SLAId");
            }
        }

        /// <summary>
        /// Enter the date and time when the entitlement begins.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("startdate")]
        public System.Nullable<System.DateTime> StartDate
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("startdate"); }
            set
            {
                this.OnPropertyChanging("StartDate");
                this.SetAttributeValue("startdate", value);
                this.OnPropertyChanged("StartDate");
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
        /// Type the total number of entitlement terms.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("totalterms")]
        public System.Nullable<decimal> TotalTerms
        {
            get { return this.GetAttributeValue<System.Nullable<decimal>>("totalterms"); }
            set
            {
                this.OnPropertyChanging("TotalTerms");
                this.SetAttributeValue("totalterms", value);
                this.OnPropertyChanged("TotalTerms");
            }
        }

        /// <summary>
        /// Unique identifier of the currency associated with the contact.
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
        /// Version number of the entitlement template item.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
        public System.Nullable<long> VersionNumber
        {
            get { return this.GetAttributeValue<System.Nullable<long>>("versionnumber"); }
        }

        /// <summary>
        /// 1:N entitlementtemplate_ActivityPointers
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("entitlementtemplate_ActivityPointers")]
        public System.Collections.Generic.IEnumerable<ActivityPointer> entitlementtemplate_ActivityPointers
        {
            get { return this.GetRelatedEntities<ActivityPointer>("entitlementtemplate_ActivityPointers", null); }
            set
            {
                this.OnPropertyChanging("entitlementtemplate_ActivityPointers");
                this.SetRelatedEntities<ActivityPointer>("entitlementtemplate_ActivityPointers", null, value);
                this.OnPropertyChanged("entitlementtemplate_ActivityPointers");
            }
        }

        /// <summary>
        /// 1:N entitlementtemplate_Annotations
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("entitlementtemplate_Annotations")]
        public System.Collections.Generic.IEnumerable<Annotation> entitlementtemplate_Annotations
        {
            get { return this.GetRelatedEntities<Annotation>("entitlementtemplate_Annotations", null); }
            set
            {
                this.OnPropertyChanging("entitlementtemplate_Annotations");
                this.SetRelatedEntities<Annotation>("entitlementtemplate_Annotations", null, value);
                this.OnPropertyChanged("entitlementtemplate_Annotations");
            }
        }

        /// <summary>
        /// 1:N entitlementtemplate_Appointments
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("entitlementtemplate_Appointments")]
        public System.Collections.Generic.IEnumerable<Appointment> entitlementtemplate_Appointments
        {
            get { return this.GetRelatedEntities<Appointment>("entitlementtemplate_Appointments", null); }
            set
            {
                this.OnPropertyChanging("entitlementtemplate_Appointments");
                this.SetRelatedEntities<Appointment>("entitlementtemplate_Appointments", null, value);
                this.OnPropertyChanged("entitlementtemplate_Appointments");
            }
        }

        /// <summary>
        /// 1:N entitlementtemplate_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("entitlementtemplate_AsyncOperations")]
        public System.Collections.Generic.IEnumerable<AsyncOperation> entitlementtemplate_AsyncOperations
        {
            get { return this.GetRelatedEntities<AsyncOperation>("entitlementtemplate_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("entitlementtemplate_AsyncOperations");
                this.SetRelatedEntities<AsyncOperation>("entitlementtemplate_AsyncOperations", null, value);
                this.OnPropertyChanged("entitlementtemplate_AsyncOperations");
            }
        }

        /// <summary>
        /// 1:N entitlementtemplate_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("entitlementtemplate_BulkDeleteFailures")]
        public System.Collections.Generic.IEnumerable<BulkDeleteFailure> entitlementtemplate_BulkDeleteFailures
        {
            get { return this.GetRelatedEntities<BulkDeleteFailure>("entitlementtemplate_BulkDeleteFailures", null); }
            set
            {
                this.OnPropertyChanging("entitlementtemplate_BulkDeleteFailures");
                this.SetRelatedEntities<BulkDeleteFailure>("entitlementtemplate_BulkDeleteFailures", null, value);
                this.OnPropertyChanged("entitlementtemplate_BulkDeleteFailures");
            }
        }

        /// <summary>
        /// 1:N entitlementtemplate_DuplicateBaseRecord
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("entitlementtemplate_DuplicateBaseRecord")]
        public System.Collections.Generic.IEnumerable<DuplicateRecord> entitlementtemplate_DuplicateBaseRecord
        {
            get { return this.GetRelatedEntities<DuplicateRecord>("entitlementtemplate_DuplicateBaseRecord", null); }
            set
            {
                this.OnPropertyChanging("entitlementtemplate_DuplicateBaseRecord");
                this.SetRelatedEntities<DuplicateRecord>("entitlementtemplate_DuplicateBaseRecord", null, value);
                this.OnPropertyChanged("entitlementtemplate_DuplicateBaseRecord");
            }
        }

        /// <summary>
        /// 1:N entitlementtemplate_DuplicateMatchingRecord
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("entitlementtemplate_DuplicateMatchingRecord")]
        public System.Collections.Generic.IEnumerable<DuplicateRecord> entitlementtemplate_DuplicateMatchingRecord
        {
            get { return this.GetRelatedEntities<DuplicateRecord>("entitlementtemplate_DuplicateMatchingRecord", null); }
            set
            {
                this.OnPropertyChanging("entitlementtemplate_DuplicateMatchingRecord");
                this.SetRelatedEntities<DuplicateRecord>("entitlementtemplate_DuplicateMatchingRecord", null, value);
                this.OnPropertyChanged("entitlementtemplate_DuplicateMatchingRecord");
            }
        }

        /// <summary>
        /// 1:N entitlementtemplate_Emails
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("entitlementtemplate_Emails")]
        public System.Collections.Generic.IEnumerable<Email> entitlementtemplate_Emails
        {
            get { return this.GetRelatedEntities<Email>("entitlementtemplate_Emails", null); }
            set
            {
                this.OnPropertyChanging("entitlementtemplate_Emails");
                this.SetRelatedEntities<Email>("entitlementtemplate_Emails", null, value);
                this.OnPropertyChanged("entitlementtemplate_Emails");
            }
        }

        /// <summary>
        /// 1:N entitlementtemplate_entitlementchannel_entitlementtemplateid
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("entitlementtemplate_entitlementchannel_entitlementtemplateid")]
        public System.Collections.Generic.IEnumerable<EntitlementTemplateChannel> entitlementtemplate_entitlementchannel_entitlementtemplateid
        {
            get { return this.GetRelatedEntities<EntitlementTemplateChannel>("entitlementtemplate_entitlementchannel_entitlementtemplateid", null); }
            set
            {
                this.OnPropertyChanging("entitlementtemplate_entitlementchannel_entitlementtemplateid");
                this.SetRelatedEntities<EntitlementTemplateChannel>("entitlementtemplate_entitlementchannel_entitlementtemplateid", null, value);
                this.OnPropertyChanged("entitlementtemplate_entitlementchannel_entitlementtemplateid");
            }
        }

        /// <summary>
        /// 1:N entitlementtemplate_Faxes
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("entitlementtemplate_Faxes")]
        public System.Collections.Generic.IEnumerable<Fax> entitlementtemplate_Faxes
        {
            get { return this.GetRelatedEntities<Fax>("entitlementtemplate_Faxes", null); }
            set
            {
                this.OnPropertyChanging("entitlementtemplate_Faxes");
                this.SetRelatedEntities<Fax>("entitlementtemplate_Faxes", null, value);
                this.OnPropertyChanged("entitlementtemplate_Faxes");
            }
        }

        /// <summary>
        /// 1:N entitlementtemplate_Letters
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("entitlementtemplate_Letters")]
        public System.Collections.Generic.IEnumerable<Letter> entitlementtemplate_Letters
        {
            get { return this.GetRelatedEntities<Letter>("entitlementtemplate_Letters", null); }
            set
            {
                this.OnPropertyChanging("entitlementtemplate_Letters");
                this.SetRelatedEntities<Letter>("entitlementtemplate_Letters", null, value);
                this.OnPropertyChanged("entitlementtemplate_Letters");
            }
        }

        /// <summary>
        /// 1:N entitlementtemplate_PhoneCalls
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("entitlementtemplate_PhoneCalls")]
        public System.Collections.Generic.IEnumerable<PhoneCall> entitlementtemplate_PhoneCalls
        {
            get { return this.GetRelatedEntities<PhoneCall>("entitlementtemplate_PhoneCalls", null); }
            set
            {
                this.OnPropertyChanging("entitlementtemplate_PhoneCalls");
                this.SetRelatedEntities<PhoneCall>("entitlementtemplate_PhoneCalls", null, value);
                this.OnPropertyChanged("entitlementtemplate_PhoneCalls");
            }
        }

        /// <summary>
        /// 1:N entitlementtemplate_PrincipalObjectAttributeAccesses
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("entitlementtemplate_PrincipalObjectAttributeAccesses")]
        public System.Collections.Generic.IEnumerable<PrincipalObjectAttributeAccess> entitlementtemplate_PrincipalObjectAttributeAccesses
        {
            get { return this.GetRelatedEntities<PrincipalObjectAttributeAccess>("entitlementtemplate_PrincipalObjectAttributeAccesses", null); }
            set
            {
                this.OnPropertyChanging("entitlementtemplate_PrincipalObjectAttributeAccesses");
                this.SetRelatedEntities<PrincipalObjectAttributeAccess>("entitlementtemplate_PrincipalObjectAttributeAccesses", null, value);
                this.OnPropertyChanged("entitlementtemplate_PrincipalObjectAttributeAccesses");
            }
        }

        /// <summary>
        /// 1:N entitlementtemplate_ProcessSession
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("entitlementtemplate_ProcessSession")]
        public System.Collections.Generic.IEnumerable<ProcessSession> entitlementtemplate_ProcessSession
        {
            get { return this.GetRelatedEntities<ProcessSession>("entitlementtemplate_ProcessSession", null); }
            set
            {
                this.OnPropertyChanging("entitlementtemplate_ProcessSession");
                this.SetRelatedEntities<ProcessSession>("entitlementtemplate_ProcessSession", null, value);
                this.OnPropertyChanged("entitlementtemplate_ProcessSession");
            }
        }

        /// <summary>
        /// 1:N entitlementtemplate_RecurringAppointmentMasters
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("entitlementtemplate_RecurringAppointmentMasters")]
        public System.Collections.Generic.IEnumerable<RecurringAppointmentMaster> entitlementtemplate_RecurringAppointmentMasters
        {
            get { return this.GetRelatedEntities<RecurringAppointmentMaster>("entitlementtemplate_RecurringAppointmentMasters", null); }
            set
            {
                this.OnPropertyChanging("entitlementtemplate_RecurringAppointmentMasters");
                this.SetRelatedEntities<RecurringAppointmentMaster>("entitlementtemplate_RecurringAppointmentMasters", null, value);
                this.OnPropertyChanged("entitlementtemplate_RecurringAppointmentMasters");
            }
        }

        /// <summary>
        /// 1:N entitlementtemplate_ServiceAppointments
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("entitlementtemplate_ServiceAppointments")]
        public System.Collections.Generic.IEnumerable<ServiceAppointment> entitlementtemplate_ServiceAppointments
        {
            get { return this.GetRelatedEntities<ServiceAppointment>("entitlementtemplate_ServiceAppointments", null); }
            set
            {
                this.OnPropertyChanging("entitlementtemplate_ServiceAppointments");
                this.SetRelatedEntities<ServiceAppointment>("entitlementtemplate_ServiceAppointments", null, value);
                this.OnPropertyChanged("entitlementtemplate_ServiceAppointments");
            }
        }

        /// <summary>
        /// 1:N entitlementtemplate_SocialActivities
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("entitlementtemplate_SocialActivities")]
        public System.Collections.Generic.IEnumerable<SocialActivity> entitlementtemplate_SocialActivities
        {
            get { return this.GetRelatedEntities<SocialActivity>("entitlementtemplate_SocialActivities", null); }
            set
            {
                this.OnPropertyChanging("entitlementtemplate_SocialActivities");
                this.SetRelatedEntities<SocialActivity>("entitlementtemplate_SocialActivities", null, value);
                this.OnPropertyChanged("entitlementtemplate_SocialActivities");
            }
        }

        /// <summary>
        /// 1:N entitlementtemplate_Tasks
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("entitlementtemplate_Tasks")]
        public System.Collections.Generic.IEnumerable<Task> entitlementtemplate_Tasks
        {
            get { return this.GetRelatedEntities<Task>("entitlementtemplate_Tasks", null); }
            set
            {
                this.OnPropertyChanging("entitlementtemplate_Tasks");
                this.SetRelatedEntities<Task>("entitlementtemplate_Tasks", null, value);
                this.OnPropertyChanged("entitlementtemplate_Tasks");
            }
        }

        /// <summary>
        /// 1:N entitlementtemplate_UserEntityInstanceDatas
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("entitlementtemplate_UserEntityInstanceDatas")]
        public System.Collections.Generic.IEnumerable<UserEntityInstanceData> entitlementtemplate_UserEntityInstanceDatas
        {
            get { return this.GetRelatedEntities<UserEntityInstanceData>("entitlementtemplate_UserEntityInstanceDatas", null); }
            set
            {
                this.OnPropertyChanging("entitlementtemplate_UserEntityInstanceDatas");
                this.SetRelatedEntities<UserEntityInstanceData>("entitlementtemplate_UserEntityInstanceDatas", null, value);
                this.OnPropertyChanged("entitlementtemplate_UserEntityInstanceDatas");
            }
        }

        /// <summary>
        /// 1:N entitlementtemplateid_RelationShip
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("entitlementtemplateid_RelationShip")]
        public System.Collections.Generic.IEnumerable<Entitlement> entitlementtemplateid_RelationShip
        {
            get { return this.GetRelatedEntities<Entitlement>("entitlementtemplateid_RelationShip", null); }
            set
            {
                this.OnPropertyChanging("entitlementtemplateid_RelationShip");
                this.SetRelatedEntities<Entitlement>("entitlementtemplateid_RelationShip", null, value);
                this.OnPropertyChanged("entitlementtemplateid_RelationShip");
            }
        }

        /// <summary>
        /// N:N product_entitlementtemplate_association
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("product_entitlementtemplate_association")]
        public System.Collections.Generic.IEnumerable<Product> product_entitlementtemplate_association
        {
            get { return this.GetRelatedEntities<Product>("product_entitlementtemplate_association", null); }
            set
            {
                this.OnPropertyChanging("product_entitlementtemplate_association");
                this.SetRelatedEntities<Product>("product_entitlementtemplate_association", null, value);
                this.OnPropertyChanged("product_entitlementtemplate_association");
            }
        }

        /// <summary>
        /// N:1 entitlementtemplate_organization
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("entitlementtemplate_organization")]
        public Organization entitlementtemplate_organization
        {
            get { return this.GetRelatedEntity<Organization>("entitlementtemplate_organization", null); }
        }

        /// <summary>
        /// N:1 lk_entitlementtemplate_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_entitlementtemplate_createdby")]
        public SystemUser lk_entitlementtemplate_createdby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_entitlementtemplate_createdby", null); }
        }

        /// <summary>
        /// N:1 lk_entitlementtemplate_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_entitlementtemplate_createdonbehalfby")]
        public SystemUser lk_entitlementtemplate_createdonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_entitlementtemplate_createdonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_entitlementtemplate_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_entitlementtemplate_modifiedby")]
        public SystemUser lk_entitlementtemplate_modifiedby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_entitlementtemplate_modifiedby", null); }
        }

        /// <summary>
        /// N:1 lk_entitlementtemplate_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_entitlementtemplate_modifiedonbehalfby")]
        public SystemUser lk_entitlementtemplate_modifiedonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_entitlementtemplate_modifiedonbehalfby", null); }
        }

        /// <summary>
        /// N:1 sla_entitlementtemplate
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("slaid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("sla_entitlementtemplate")]
        public SLA sla_entitlementtemplate
        {
            get { return this.GetRelatedEntity<SLA>("sla_entitlementtemplate", null); }
            set
            {
                this.OnPropertyChanging("sla_entitlementtemplate");
                this.SetRelatedEntity<SLA>("sla_entitlementtemplate", null, value);
                this.OnPropertyChanged("sla_entitlementtemplate");
            }
        }

        /// <summary>
        /// N:1 TransactionCurrency_entitlementtemplate
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("TransactionCurrency_entitlementtemplate")]
        public TransactionCurrency TransactionCurrency_entitlementtemplate
        {
            get { return this.GetRelatedEntity<TransactionCurrency>("TransactionCurrency_entitlementtemplate", null); }
            set
            {
                this.OnPropertyChanging("TransactionCurrency_entitlementtemplate");
                this.SetRelatedEntity<TransactionCurrency>("TransactionCurrency_entitlementtemplate", null, value);
                this.OnPropertyChanged("TransactionCurrency_entitlementtemplate");
            }
        }
    }
}