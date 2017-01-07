using _4_DAL_CRM;

namespace __4_DAL_CRM
{
    /// <summary>
    /// Defines the amount and type of support a customer should receive.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("entitlement")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class Entitlement : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public Entitlement() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "entitlement";

        public const int EntityTypeCode = 9700;

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
        /// Unique identifier for Account associated with Entitlement.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("accountid")]
        public Microsoft.Xrm.Sdk.EntityReference AccountId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("accountid"); }
        }

        /// <summary>
        /// Select the type of entitlement terms.
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
        /// Unique identifier for Contact associated with Entitlement.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("contactid")]
        public Microsoft.Xrm.Sdk.EntityReference ContactId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("contactid"); }
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
        /// Unique identifier of the delegate user who created the entitlement.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        /// Choose a contact or account for which this entitlement has been defined.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("customerid")]
        public Microsoft.Xrm.Sdk.EntityReference CustomerId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("customerid"); }
            set
            {
                this.OnPropertyChanging("CustomerId");
                this.SetAttributeValue("customerid", value);
                this.OnPropertyChanged("CustomerId");
            }
        }

        /// <summary>
        /// Select whether to decrease the remaining terms when the case is created or when it is resolved.
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
        /// Type additional information to describe the Entitlement
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
        /// Enter the date when the entitlement ends.
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
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entitlementid")]
        public System.Nullable<System.Guid> EntitlementId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("entitlementid"); }
            set
            {
                this.OnPropertyChanging("EntitlementId");
                this.SetAttributeValue("entitlementid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("EntitlementId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entitlementid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.EntitlementId = value; }
        }

        /// <summary>
        /// Unique identifier for Entitlement Template associated with Entitlement.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entitlementtemplateid")]
        public Microsoft.Xrm.Sdk.EntityReference EntitlementTemplateId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("entitlementtemplateid"); }
            set
            {
                this.OnPropertyChanging("EntitlementTemplateId");
                this.SetAttributeValue("entitlementtemplateid", value);
                this.OnPropertyChanged("EntitlementTemplateId");
            }
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
        /// Type a meaningful name for the entitlement.
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
        /// Enter the user or team who owns the entitlement. This field is updated every time the item is assigned to a different user.
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
        /// Unique identifier of the Process.
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
        /// Type the total number of entitlement terms that are left.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("remainingterms")]
        public System.Nullable<decimal> RemainingTerms
        {
            get { return this.GetAttributeValue<System.Nullable<decimal>>("remainingterms"); }
            set
            {
                this.OnPropertyChanging("RemainingTerms");
                this.SetAttributeValue("remainingterms", value);
                this.OnPropertyChanged("RemainingTerms");
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
        /// Unique identifier of the Stage.
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
        /// For internal use only.
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
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
        public System.Nullable<EntitlementState> StateCode
        {
            get
            {
                Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
                if ((optionSet != null))
                {
                    return ((EntitlementState) (System.Enum.ToObject(typeof(EntitlementState), optionSet.Value)));
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// Select the reason code that explains the status of the entitlement.
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
        /// Version number of the entitlement item.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
        public System.Nullable<long> VersionNumber
        {
            get { return this.GetAttributeValue<System.Nullable<long>>("versionnumber"); }
        }

        /// <summary>
        /// 1:N entitlement_ActivityPointers
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("entitlement_ActivityPointers")]
        public System.Collections.Generic.IEnumerable<ActivityPointer> entitlement_ActivityPointers
        {
            get { return this.GetRelatedEntities<ActivityPointer>("entitlement_ActivityPointers", null); }
            set
            {
                this.OnPropertyChanging("entitlement_ActivityPointers");
                this.SetRelatedEntities<ActivityPointer>("entitlement_ActivityPointers", null, value);
                this.OnPropertyChanged("entitlement_ActivityPointers");
            }
        }

        /// <summary>
        /// 1:N entitlement_Annotations
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("entitlement_Annotations")]
        public System.Collections.Generic.IEnumerable<Annotation> entitlement_Annotations
        {
            get { return this.GetRelatedEntities<Annotation>("entitlement_Annotations", null); }
            set
            {
                this.OnPropertyChanging("entitlement_Annotations");
                this.SetRelatedEntities<Annotation>("entitlement_Annotations", null, value);
                this.OnPropertyChanged("entitlement_Annotations");
            }
        }

        /// <summary>
        /// 1:N entitlement_Appointments
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("entitlement_Appointments")]
        public System.Collections.Generic.IEnumerable<Appointment> entitlement_Appointments
        {
            get { return this.GetRelatedEntities<Appointment>("entitlement_Appointments", null); }
            set
            {
                this.OnPropertyChanging("entitlement_Appointments");
                this.SetRelatedEntities<Appointment>("entitlement_Appointments", null, value);
                this.OnPropertyChanged("entitlement_Appointments");
            }
        }

        /// <summary>
        /// 1:N entitlement_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("entitlement_AsyncOperations")]
        public System.Collections.Generic.IEnumerable<AsyncOperation> entitlement_AsyncOperations
        {
            get { return this.GetRelatedEntities<AsyncOperation>("entitlement_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("entitlement_AsyncOperations");
                this.SetRelatedEntities<AsyncOperation>("entitlement_AsyncOperations", null, value);
                this.OnPropertyChanged("entitlement_AsyncOperations");
            }
        }

        /// <summary>
        /// 1:N entitlement_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("entitlement_BulkDeleteFailures")]
        public System.Collections.Generic.IEnumerable<BulkDeleteFailure> entitlement_BulkDeleteFailures
        {
            get { return this.GetRelatedEntities<BulkDeleteFailure>("entitlement_BulkDeleteFailures", null); }
            set
            {
                this.OnPropertyChanging("entitlement_BulkDeleteFailures");
                this.SetRelatedEntities<BulkDeleteFailure>("entitlement_BulkDeleteFailures", null, value);
                this.OnPropertyChanged("entitlement_BulkDeleteFailures");
            }
        }

        /// <summary>
        /// 1:N entitlement_cases
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("entitlement_cases")]
        public System.Collections.Generic.IEnumerable<Incident> entitlement_cases
        {
            get { return this.GetRelatedEntities<Incident>("entitlement_cases", null); }
            set
            {
                this.OnPropertyChanging("entitlement_cases");
                this.SetRelatedEntities<Incident>("entitlement_cases", null, value);
                this.OnPropertyChanged("entitlement_cases");
            }
        }

        /// <summary>
        /// 1:N entitlement_connections1
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("entitlement_connections1")]
        public System.Collections.Generic.IEnumerable<Connection> entitlement_connections1
        {
            get { return this.GetRelatedEntities<Connection>("entitlement_connections1", null); }
            set
            {
                this.OnPropertyChanging("entitlement_connections1");
                this.SetRelatedEntities<Connection>("entitlement_connections1", null, value);
                this.OnPropertyChanged("entitlement_connections1");
            }
        }

        /// <summary>
        /// 1:N entitlement_connections2
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("entitlement_connections2")]
        public System.Collections.Generic.IEnumerable<Connection> entitlement_connections2
        {
            get { return this.GetRelatedEntities<Connection>("entitlement_connections2", null); }
            set
            {
                this.OnPropertyChanging("entitlement_connections2");
                this.SetRelatedEntities<Connection>("entitlement_connections2", null, value);
                this.OnPropertyChanged("entitlement_connections2");
            }
        }

        /// <summary>
        /// 1:N entitlement_DuplicateBaseRecord
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("entitlement_DuplicateBaseRecord")]
        public System.Collections.Generic.IEnumerable<DuplicateRecord> entitlement_DuplicateBaseRecord
        {
            get { return this.GetRelatedEntities<DuplicateRecord>("entitlement_DuplicateBaseRecord", null); }
            set
            {
                this.OnPropertyChanging("entitlement_DuplicateBaseRecord");
                this.SetRelatedEntities<DuplicateRecord>("entitlement_DuplicateBaseRecord", null, value);
                this.OnPropertyChanged("entitlement_DuplicateBaseRecord");
            }
        }

        /// <summary>
        /// 1:N entitlement_DuplicateMatchingRecord
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("entitlement_DuplicateMatchingRecord")]
        public System.Collections.Generic.IEnumerable<DuplicateRecord> entitlement_DuplicateMatchingRecord
        {
            get { return this.GetRelatedEntities<DuplicateRecord>("entitlement_DuplicateMatchingRecord", null); }
            set
            {
                this.OnPropertyChanging("entitlement_DuplicateMatchingRecord");
                this.SetRelatedEntities<DuplicateRecord>("entitlement_DuplicateMatchingRecord", null, value);
                this.OnPropertyChanged("entitlement_DuplicateMatchingRecord");
            }
        }

        /// <summary>
        /// 1:N entitlement_Emails
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("entitlement_Emails")]
        public System.Collections.Generic.IEnumerable<Email> entitlement_Emails
        {
            get { return this.GetRelatedEntities<Email>("entitlement_Emails", null); }
            set
            {
                this.OnPropertyChanging("entitlement_Emails");
                this.SetRelatedEntities<Email>("entitlement_Emails", null, value);
                this.OnPropertyChanged("entitlement_Emails");
            }
        }

        /// <summary>
        /// 1:N entitlement_entitlementchannel_EntitlementId
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("entitlement_entitlementchannel_EntitlementId")]
        public System.Collections.Generic.IEnumerable<EntitlementChannel> entitlement_entitlementchannel_EntitlementId
        {
            get { return this.GetRelatedEntities<EntitlementChannel>("entitlement_entitlementchannel_EntitlementId", null); }
            set
            {
                this.OnPropertyChanging("entitlement_entitlementchannel_EntitlementId");
                this.SetRelatedEntities<EntitlementChannel>("entitlement_entitlementchannel_EntitlementId", null, value);
                this.OnPropertyChanged("entitlement_entitlementchannel_EntitlementId");
            }
        }

        /// <summary>
        /// 1:N entitlement_Faxes
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("entitlement_Faxes")]
        public System.Collections.Generic.IEnumerable<Fax> entitlement_Faxes
        {
            get { return this.GetRelatedEntities<Fax>("entitlement_Faxes", null); }
            set
            {
                this.OnPropertyChanging("entitlement_Faxes");
                this.SetRelatedEntities<Fax>("entitlement_Faxes", null, value);
                this.OnPropertyChanged("entitlement_Faxes");
            }
        }

        /// <summary>
        /// 1:N entitlement_Letters
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("entitlement_Letters")]
        public System.Collections.Generic.IEnumerable<Letter> entitlement_Letters
        {
            get { return this.GetRelatedEntities<Letter>("entitlement_Letters", null); }
            set
            {
                this.OnPropertyChanging("entitlement_Letters");
                this.SetRelatedEntities<Letter>("entitlement_Letters", null, value);
                this.OnPropertyChanged("entitlement_Letters");
            }
        }

        /// <summary>
        /// 1:N entitlement_PhoneCalls
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("entitlement_PhoneCalls")]
        public System.Collections.Generic.IEnumerable<PhoneCall> entitlement_PhoneCalls
        {
            get { return this.GetRelatedEntities<PhoneCall>("entitlement_PhoneCalls", null); }
            set
            {
                this.OnPropertyChanging("entitlement_PhoneCalls");
                this.SetRelatedEntities<PhoneCall>("entitlement_PhoneCalls", null, value);
                this.OnPropertyChanged("entitlement_PhoneCalls");
            }
        }

        /// <summary>
        /// 1:N entitlement_PrincipalObjectAttributeAccesses
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("entitlement_PrincipalObjectAttributeAccesses")]
        public System.Collections.Generic.IEnumerable<PrincipalObjectAttributeAccess> entitlement_PrincipalObjectAttributeAccesses
        {
            get { return this.GetRelatedEntities<PrincipalObjectAttributeAccess>("entitlement_PrincipalObjectAttributeAccesses", null); }
            set
            {
                this.OnPropertyChanging("entitlement_PrincipalObjectAttributeAccesses");
                this.SetRelatedEntities<PrincipalObjectAttributeAccess>("entitlement_PrincipalObjectAttributeAccesses", null, value);
                this.OnPropertyChanged("entitlement_PrincipalObjectAttributeAccesses");
            }
        }

        /// <summary>
        /// 1:N entitlement_ProcessSession
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("entitlement_ProcessSession")]
        public System.Collections.Generic.IEnumerable<ProcessSession> entitlement_ProcessSession
        {
            get { return this.GetRelatedEntities<ProcessSession>("entitlement_ProcessSession", null); }
            set
            {
                this.OnPropertyChanging("entitlement_ProcessSession");
                this.SetRelatedEntities<ProcessSession>("entitlement_ProcessSession", null, value);
                this.OnPropertyChanged("entitlement_ProcessSession");
            }
        }

        /// <summary>
        /// 1:N entitlement_RecurringAppointmentMasters
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("entitlement_RecurringAppointmentMasters")]
        public System.Collections.Generic.IEnumerable<RecurringAppointmentMaster> entitlement_RecurringAppointmentMasters
        {
            get { return this.GetRelatedEntities<RecurringAppointmentMaster>("entitlement_RecurringAppointmentMasters", null); }
            set
            {
                this.OnPropertyChanging("entitlement_RecurringAppointmentMasters");
                this.SetRelatedEntities<RecurringAppointmentMaster>("entitlement_RecurringAppointmentMasters", null, value);
                this.OnPropertyChanged("entitlement_RecurringAppointmentMasters");
            }
        }

        /// <summary>
        /// 1:N entitlement_ServiceAppointments
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("entitlement_ServiceAppointments")]
        public System.Collections.Generic.IEnumerable<ServiceAppointment> entitlement_ServiceAppointments
        {
            get { return this.GetRelatedEntities<ServiceAppointment>("entitlement_ServiceAppointments", null); }
            set
            {
                this.OnPropertyChanging("entitlement_ServiceAppointments");
                this.SetRelatedEntities<ServiceAppointment>("entitlement_ServiceAppointments", null, value);
                this.OnPropertyChanged("entitlement_ServiceAppointments");
            }
        }

        /// <summary>
        /// 1:N entitlement_SocialActivities
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("entitlement_SocialActivities")]
        public System.Collections.Generic.IEnumerable<SocialActivity> entitlement_SocialActivities
        {
            get { return this.GetRelatedEntities<SocialActivity>("entitlement_SocialActivities", null); }
            set
            {
                this.OnPropertyChanging("entitlement_SocialActivities");
                this.SetRelatedEntities<SocialActivity>("entitlement_SocialActivities", null, value);
                this.OnPropertyChanged("entitlement_SocialActivities");
            }
        }

        /// <summary>
        /// 1:N entitlement_Tasks
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("entitlement_Tasks")]
        public System.Collections.Generic.IEnumerable<Task> entitlement_Tasks
        {
            get { return this.GetRelatedEntities<Task>("entitlement_Tasks", null); }
            set
            {
                this.OnPropertyChanging("entitlement_Tasks");
                this.SetRelatedEntities<Task>("entitlement_Tasks", null, value);
                this.OnPropertyChanged("entitlement_Tasks");
            }
        }

        /// <summary>
        /// 1:N entitlement_UserEntityInstanceDatas
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("entitlement_UserEntityInstanceDatas")]
        public System.Collections.Generic.IEnumerable<UserEntityInstanceData> entitlement_UserEntityInstanceDatas
        {
            get { return this.GetRelatedEntities<UserEntityInstanceData>("entitlement_UserEntityInstanceDatas", null); }
            set
            {
                this.OnPropertyChanging("entitlement_UserEntityInstanceDatas");
                this.SetRelatedEntities<UserEntityInstanceData>("entitlement_UserEntityInstanceDatas", null, value);
                this.OnPropertyChanged("entitlement_UserEntityInstanceDatas");
            }
        }

        /// <summary>
        /// N:N entitlementcontacts_association
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("entitlementcontacts_association")]
        public System.Collections.Generic.IEnumerable<Contact> entitlementcontacts_association
        {
            get { return this.GetRelatedEntities<Contact>("entitlementcontacts_association", null); }
            set
            {
                this.OnPropertyChanging("entitlementcontacts_association");
                this.SetRelatedEntities<Contact>("entitlementcontacts_association", null, value);
                this.OnPropertyChanged("entitlementcontacts_association");
            }
        }

        /// <summary>
        /// N:N product_entitlement_association
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("product_entitlement_association")]
        public System.Collections.Generic.IEnumerable<Product> product_entitlement_association
        {
            get { return this.GetRelatedEntities<Product>("product_entitlement_association", null); }
            set
            {
                this.OnPropertyChanging("product_entitlement_association");
                this.SetRelatedEntities<Product>("product_entitlement_association", null, value);
                this.OnPropertyChanged("product_entitlement_association");
            }
        }

        /// <summary>
        /// N:1 account_entitlement_Account
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("accountid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("account_entitlement_Account")]
        public Account account_entitlement_Account
        {
            get { return this.GetRelatedEntity<Account>("account_entitlement_Account", null); }
        }

        /// <summary>
        /// N:1 account_entitlement_Customer
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("customerid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("account_entitlement_Customer")]
        public Account account_entitlement_Customer
        {
            get { return this.GetRelatedEntity<Account>("account_entitlement_Customer", null); }
            set
            {
                this.OnPropertyChanging("account_entitlement_Customer");
                this.SetRelatedEntity<Account>("account_entitlement_Customer", null, value);
                this.OnPropertyChanged("account_entitlement_Customer");
            }
        }

        /// <summary>
        /// N:1 business_unit_entitlement
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_entitlement")]
        public BusinessUnit business_unit_entitlement
        {
            get { return this.GetRelatedEntity<BusinessUnit>("business_unit_entitlement", null); }
        }

        /// <summary>
        /// N:1 contact_entitlement_ContactId
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("contactid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("contact_entitlement_ContactId")]
        public Contact contact_entitlement_ContactId
        {
            get { return this.GetRelatedEntity<Contact>("contact_entitlement_ContactId", null); }
        }

        /// <summary>
        /// N:1 contact_entitlement_Customer
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("customerid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("contact_entitlement_Customer")]
        public Contact contact_entitlement_Customer
        {
            get { return this.GetRelatedEntity<Contact>("contact_entitlement_Customer", null); }
            set
            {
                this.OnPropertyChanging("contact_entitlement_Customer");
                this.SetRelatedEntity<Contact>("contact_entitlement_Customer", null, value);
                this.OnPropertyChanged("contact_entitlement_Customer");
            }
        }

        /// <summary>
        /// N:1 entitlementtemplateid_RelationShip
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entitlementtemplateid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("entitlementtemplateid_RelationShip")]
        public EntitlementTemplate entitlementtemplateid_RelationShip
        {
            get { return this.GetRelatedEntity<EntitlementTemplate>("entitlementtemplateid_RelationShip", null); }
            set
            {
                this.OnPropertyChanging("entitlementtemplateid_RelationShip");
                this.SetRelatedEntity<EntitlementTemplate>("entitlementtemplateid_RelationShip", null, value);
                this.OnPropertyChanged("entitlementtemplateid_RelationShip");
            }
        }

        /// <summary>
        /// N:1 lk_entitlement_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_entitlement_createdby")]
        public SystemUser lk_entitlement_createdby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_entitlement_createdby", null); }
        }

        /// <summary>
        /// N:1 lk_entitlement_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_entitlement_createdonbehalfby")]
        public SystemUser lk_entitlement_createdonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_entitlement_createdonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_entitlement_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_entitlement_modifiedby")]
        public SystemUser lk_entitlement_modifiedby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_entitlement_modifiedby", null); }
        }

        /// <summary>
        /// N:1 lk_entitlement_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_entitlement_modifiedonbehalfby")]
        public SystemUser lk_entitlement_modifiedonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_entitlement_modifiedonbehalfby", null); }
        }

        /// <summary>
        /// N:1 sla_entitlement
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("slaid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("sla_entitlement")]
        public SLA sla_entitlement
        {
            get { return this.GetRelatedEntity<SLA>("sla_entitlement", null); }
            set
            {
                this.OnPropertyChanging("sla_entitlement");
                this.SetRelatedEntity<SLA>("sla_entitlement", null, value);
                this.OnPropertyChanged("sla_entitlement");
            }
        }

        /// <summary>
        /// N:1 team_entitlement
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_entitlement")]
        public Team team_entitlement
        {
            get { return this.GetRelatedEntity<Team>("team_entitlement", null); }
        }

        /// <summary>
        /// N:1 TransactionCurrency_Entitlement
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("TransactionCurrency_Entitlement")]
        public TransactionCurrency TransactionCurrency_Entitlement
        {
            get { return this.GetRelatedEntity<TransactionCurrency>("TransactionCurrency_Entitlement", null); }
            set
            {
                this.OnPropertyChanging("TransactionCurrency_Entitlement");
                this.SetRelatedEntity<TransactionCurrency>("TransactionCurrency_Entitlement", null, value);
                this.OnPropertyChanged("TransactionCurrency_Entitlement");
            }
        }

        /// <summary>
        /// N:1 user_entitlement
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_entitlement")]
        public SystemUser user_entitlement
        {
            get { return this.GetRelatedEntity<SystemUser>("user_entitlement", null); }
        }
    }
}