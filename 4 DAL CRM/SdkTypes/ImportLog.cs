namespace __4_DAL_CRM
{
    /// <summary>
    /// Failure reason and other detailed information for a record that failed to import.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("importlog")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class ImportLog : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public ImportLog() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "importlog";

        public const int EntityTypeCode = 4423;

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
        /// Additional information related to the error.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("additionalinfo")]
        public string AdditionalInfo
        {
            get { return this.GetAttributeValue<string>("additionalinfo"); }
            set
            {
                this.OnPropertyChanging("AdditionalInfo");
                this.SetAttributeValue("additionalinfo", value);
                this.OnPropertyChanged("AdditionalInfo");
            }
        }

        /// <summary>
        /// Value in the column.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("columnvalue")]
        public string ColumnValue
        {
            get { return this.GetAttributeValue<string>("columnvalue"); }
            set
            {
                this.OnPropertyChanging("ColumnValue");
                this.SetAttributeValue("columnvalue", value);
                this.OnPropertyChanged("ColumnValue");
            }
        }

        /// <summary>
        /// Unique identifier of the user who created the import log.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby"); }
        }

        /// <summary>
        /// Date and time when the import log was created.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
        public System.Nullable<System.DateTime> CreatedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who created the importlog.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        /// Description of an error.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("errordescription")]
        public string ErrorDescription
        {
            get { return this.GetAttributeValue<string>("errordescription"); }
            set
            {
                this.OnPropertyChanging("ErrorDescription");
                this.SetAttributeValue("errordescription", value);
                this.OnPropertyChanged("ErrorDescription");
            }
        }

        /// <summary>
        /// Error code of an error.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("errornumber")]
        public System.Nullable<int> ErrorNumber
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("errornumber"); }
            set
            {
                this.OnPropertyChanging("ErrorNumber");
                this.SetAttributeValue("errornumber", value);
                this.OnPropertyChanged("ErrorNumber");
            }
        }

        /// <summary>
        /// Name of the column heading.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("headercolumn")]
        public string HeaderColumn
        {
            get { return this.GetAttributeValue<string>("headercolumn"); }
            set
            {
                this.OnPropertyChanging("HeaderColumn");
                this.SetAttributeValue("headercolumn", value);
                this.OnPropertyChanged("HeaderColumn");
            }
        }

        /// <summary>
        /// Unique identifier of the import data for this import log.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("importdataid")]
        public Microsoft.Xrm.Sdk.EntityReference ImportDataId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("importdataid"); }
            set
            {
                this.OnPropertyChanging("ImportDataId");
                this.SetAttributeValue("importdataid", value);
                this.OnPropertyChanged("ImportDataId");
            }
        }

        /// <summary>
        /// Unique identifier of the import file for this import log.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("importfileid")]
        public Microsoft.Xrm.Sdk.EntityReference ImportFileId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("importfileid"); }
            set
            {
                this.OnPropertyChanging("ImportFileId");
                this.SetAttributeValue("importfileid", value);
                this.OnPropertyChanged("ImportFileId");
            }
        }

        /// <summary>
        /// Unique identifier of the import log.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("importlogid")]
        public System.Nullable<System.Guid> ImportLogId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("importlogid"); }
            set
            {
                this.OnPropertyChanging("ImportLogId");
                this.SetAttributeValue("importlogid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("ImportLogId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("importlogid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.ImportLogId = value; }
        }

        /// <summary>
        /// Original line number of the data used in this log.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("linenumber")]
        public System.Nullable<int> LineNumber
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("linenumber"); }
            set
            {
                this.OnPropertyChanging("LineNumber");
                this.SetAttributeValue("linenumber", value);
                this.OnPropertyChanged("LineNumber");
            }
        }

        /// <summary>
        /// Phase for which the log is recorded.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("logphasecode")]
        public Microsoft.Xrm.Sdk.OptionSetValue LogPhaseCode
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("logphasecode"); }
            set
            {
                this.OnPropertyChanging("LogPhaseCode");
                this.SetAttributeValue("logphasecode", value);
                this.OnPropertyChanged("LogPhaseCode");
            }
        }

        /// <summary>
        /// Unique identifier of the user who last modified the import log.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby"); }
        }

        /// <summary>
        /// Date and time when the import log was last modified.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
        public System.Nullable<System.DateTime> ModifiedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who last modified the importlog.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        /// Unique identifier of the user or team who owns the import log.
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
        /// Business unit that owns the import log.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
        public Microsoft.Xrm.Sdk.EntityReference OwningBusinessUnit
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningbusinessunit"); }
        }

        /// <summary>
        /// Unique identifier of the team who owns the import log.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
        public Microsoft.Xrm.Sdk.EntityReference OwningTeam
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningteam"); }
        }

        /// <summary>
        /// Unique identifier of the user who owns the import log.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
        public Microsoft.Xrm.Sdk.EntityReference OwningUser
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owninguser"); }
        }

        /// <summary>
        /// Sequence number of the error in this log.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sequencenumber")]
        public System.Nullable<int> SequenceNumber
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("sequencenumber"); }
        }

        /// <summary>
        /// Status of the import log.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
        public System.Nullable<ImportLogState> StateCode
        {
            get
            {
                Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
                if ((optionSet != null))
                {
                    return ((ImportLogState) (System.Enum.ToObject(typeof(ImportLogState), optionSet.Value)));
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// Reason for the status of the import log.
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
        /// 1:N ImportLog_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ImportLog_AsyncOperations")]
        public System.Collections.Generic.IEnumerable<AsyncOperation> ImportLog_AsyncOperations
        {
            get { return this.GetRelatedEntities<AsyncOperation>("ImportLog_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("ImportLog_AsyncOperations");
                this.SetRelatedEntities<AsyncOperation>("ImportLog_AsyncOperations", null, value);
                this.OnPropertyChanged("ImportLog_AsyncOperations");
            }
        }

        /// <summary>
        /// 1:N ImportLog_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ImportLog_BulkDeleteFailures")]
        public System.Collections.Generic.IEnumerable<BulkDeleteFailure> ImportLog_BulkDeleteFailures
        {
            get { return this.GetRelatedEntities<BulkDeleteFailure>("ImportLog_BulkDeleteFailures", null); }
            set
            {
                this.OnPropertyChanging("ImportLog_BulkDeleteFailures");
                this.SetRelatedEntities<BulkDeleteFailure>("ImportLog_BulkDeleteFailures", null, value);
                this.OnPropertyChanged("ImportLog_BulkDeleteFailures");
            }
        }

        /// <summary>
        /// 1:N userentityinstancedata_importlog
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_importlog")]
        public System.Collections.Generic.IEnumerable<UserEntityInstanceData> userentityinstancedata_importlog
        {
            get { return this.GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_importlog", null); }
            set
            {
                this.OnPropertyChanging("userentityinstancedata_importlog");
                this.SetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_importlog", null, value);
                this.OnPropertyChanged("userentityinstancedata_importlog");
            }
        }

        /// <summary>
        /// N:1 BusinessUnit_ImportLogs
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("BusinessUnit_ImportLogs")]
        public BusinessUnit BusinessUnit_ImportLogs
        {
            get { return this.GetRelatedEntity<BusinessUnit>("BusinessUnit_ImportLogs", null); }
        }

        /// <summary>
        /// N:1 ImportLog_ImportFile
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("importfileid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ImportLog_ImportFile")]
        public ImportFile ImportLog_ImportFile
        {
            get { return this.GetRelatedEntity<ImportFile>("ImportLog_ImportFile", null); }
            set
            {
                this.OnPropertyChanging("ImportLog_ImportFile");
                this.SetRelatedEntity<ImportFile>("ImportLog_ImportFile", null, value);
                this.OnPropertyChanged("ImportLog_ImportFile");
            }
        }

        /// <summary>
        /// N:1 lk_importlog_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_importlog_createdonbehalfby")]
        public SystemUser lk_importlog_createdonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_importlog_createdonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_importlog_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_importlog_modifiedonbehalfby")]
        public SystemUser lk_importlog_modifiedonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_importlog_modifiedonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_importlogbase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_importlogbase_createdby")]
        public SystemUser lk_importlogbase_createdby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_importlogbase_createdby", null); }
        }

        /// <summary>
        /// N:1 lk_importlogbase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_importlogbase_modifiedby")]
        public SystemUser lk_importlogbase_modifiedby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_importlogbase_modifiedby", null); }
        }

        /// <summary>
        /// N:1 SystemUser_ImportLogs
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SystemUser_ImportLogs")]
        public SystemUser SystemUser_ImportLogs
        {
            get { return this.GetRelatedEntity<SystemUser>("SystemUser_ImportLogs", null); }
        }

        /// <summary>
        /// N:1 team_ImportLogs
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_ImportLogs")]
        public Team team_ImportLogs
        {
            get { return this.GetRelatedEntity<Team>("team_ImportLogs", null); }
        }
    }
}