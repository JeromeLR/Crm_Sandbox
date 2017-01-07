namespace __4_DAL_CRM
{
    /// <summary>
    /// User-submitted bulk deletion job.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("bulkdeleteoperation")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class BulkDeleteOperation : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public BulkDeleteOperation() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "bulkdeleteoperation";

        public const int EntityTypeCode = 4424;

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
        /// Unique identifier of the system job that created this record
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("asyncoperationid")]
        public Microsoft.Xrm.Sdk.EntityReference AsyncOperationId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("asyncoperationid"); }
        }

        /// <summary>
        /// Unique identifier of the bulk deletion job.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("bulkdeleteoperationid")]
        public System.Nullable<System.Guid> BulkDeleteOperationId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("bulkdeleteoperationid"); }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("bulkdeleteoperationid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { base.Id = value; }
        }

        /// <summary>
        /// Unique identifier of the user who created the bulk deletion job.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby"); }
        }

        /// <summary>
        /// Date and time when the bulk deletion job was created.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
        public System.Nullable<System.DateTime> CreatedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who created the bulkdeleteoperation.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        /// Number of records that could not be deleted by the bulk deletion job.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("failurecount")]
        public System.Nullable<int> FailureCount
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("failurecount"); }
        }

        /// <summary>
        /// Information about if recurrence is defined for the bulk deletion job.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isrecurring")]
        public System.Nullable<bool> IsRecurring
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("isrecurring"); }
        }

        /// <summary>
        /// Unique identifier of the user who last modified the bulk deletion job.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby"); }
        }

        /// <summary>
        /// Date and time when the bulk deletion job record was last modified.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
        public System.Nullable<System.DateTime> ModifiedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who last modified the bulkdeleteoperation.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        /// Name of the bulk deletion job.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("name")]
        public string Name
        {
            get { return this.GetAttributeValue<string>("name"); }
        }

        /// <summary>
        /// Next scheduled time for the bulk deletion job to run.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("nextrun")]
        public System.Nullable<System.DateTime> NextRun
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("nextrun"); }
        }

        /// <summary>
        /// Fetch XML of the ordered query set.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("orderedquerysetxml")]
        public string OrderedQuerySetXml
        {
            get { return this.GetAttributeValue<string>("orderedquerysetxml"); }
        }

        /// <summary>
        /// Unique identifier of the user or team who owns the bulk delete operation.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ownerid")]
        public Microsoft.Xrm.Sdk.EntityReference OwnerId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("ownerid"); }
        }

        /// <summary>
        /// Business unit that owns the bulk deletion job.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
        public Microsoft.Xrm.Sdk.EntityReference OwningBusinessUnit
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningbusinessunit"); }
        }

        /// <summary>
        /// Business user what owns the bulk delete operation.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
        public Microsoft.Xrm.Sdk.EntityReference OwningUser
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owninguser"); }
        }

        /// <summary>
        /// Index of the ordered query expression that defines the deletion set.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("processingqeindex")]
        public System.Nullable<int> ProcessingQEIndex
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("processingqeindex"); }
        }

        /// <summary>
        /// Status of the bulk deletion job.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
        public System.Nullable<BulkDeleteOperationState> StateCode
        {
            get
            {
                Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
                if ((optionSet != null))
                {
                    return ((BulkDeleteOperationState) (System.Enum.ToObject(typeof(BulkDeleteOperationState), optionSet.Value)));
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// Reason for the status of the bulk deletion job.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statuscode")]
        public Microsoft.Xrm.Sdk.OptionSetValue StatusCode
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statuscode"); }
        }

        /// <summary>
        /// Number of records deleted by the bulk deletion job.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("successcount")]
        public System.Nullable<int> SuccessCount
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("successcount"); }
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
        /// 1:N BulkDeleteOperation_BulkDeleteFailure
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("BulkDeleteOperation_BulkDeleteFailure")]
        public System.Collections.Generic.IEnumerable<BulkDeleteFailure> BulkDeleteOperation_BulkDeleteFailure
        {
            get { return this.GetRelatedEntities<BulkDeleteFailure>("BulkDeleteOperation_BulkDeleteFailure", null); }
            set
            {
                this.OnPropertyChanging("BulkDeleteOperation_BulkDeleteFailure");
                this.SetRelatedEntities<BulkDeleteFailure>("BulkDeleteOperation_BulkDeleteFailure", null, value);
                this.OnPropertyChanged("BulkDeleteOperation_BulkDeleteFailure");
            }
        }

        /// <summary>
        /// 1:N userentityinstancedata_bulkdeleteoperation
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_bulkdeleteoperation")]
        public System.Collections.Generic.IEnumerable<UserEntityInstanceData> userentityinstancedata_bulkdeleteoperation
        {
            get { return this.GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_bulkdeleteoperation", null); }
            set
            {
                this.OnPropertyChanging("userentityinstancedata_bulkdeleteoperation");
                this.SetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_bulkdeleteoperation", null, value);
                this.OnPropertyChanged("userentityinstancedata_bulkdeleteoperation");
            }
        }

        /// <summary>
        /// N:1 AsyncOperation_BulkDeleteOperation
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("asyncoperationid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("AsyncOperation_BulkDeleteOperation")]
        public AsyncOperation AsyncOperation_BulkDeleteOperation
        {
            get { return this.GetRelatedEntity<AsyncOperation>("AsyncOperation_BulkDeleteOperation", null); }
        }

        /// <summary>
        /// N:1 BulkDeleteOperation_BusinessUnit
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("BulkDeleteOperation_BusinessUnit")]
        public BusinessUnit BulkDeleteOperation_BusinessUnit
        {
            get { return this.GetRelatedEntity<BusinessUnit>("BulkDeleteOperation_BusinessUnit", null); }
        }

        /// <summary>
        /// N:1 lk_bulkdeleteoperation_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_bulkdeleteoperation_createdonbehalfby")]
        public SystemUser lk_bulkdeleteoperation_createdonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_bulkdeleteoperation_createdonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_bulkdeleteoperation_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_bulkdeleteoperation_modifiedonbehalfby")]
        public SystemUser lk_bulkdeleteoperation_modifiedonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_bulkdeleteoperation_modifiedonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_bulkdeleteoperationbase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_bulkdeleteoperationbase_createdby")]
        public SystemUser lk_bulkdeleteoperationbase_createdby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_bulkdeleteoperationbase_createdby", null); }
        }

        /// <summary>
        /// N:1 lk_bulkdeleteoperationbase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_bulkdeleteoperationbase_modifiedby")]
        public SystemUser lk_bulkdeleteoperationbase_modifiedby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_bulkdeleteoperationbase_modifiedby", null); }
        }
    }
}