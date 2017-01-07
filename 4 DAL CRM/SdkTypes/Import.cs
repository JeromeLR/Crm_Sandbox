namespace __4_DAL_CRM
{
    /// <summary>
    /// Status and ownership information for an import job.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("import")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class Import : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public Import() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "import";

        public const int EntityTypeCode = 4410;

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
        /// Shows who created the record.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby"); }
        }

        /// <summary>
        /// Shows the date and time when the import was initiated.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
        public System.Nullable<System.DateTime> CreatedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon"); }
        }

        /// <summary>
        /// Shows who created the record on behalf of another user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        /// Type the email address that the import completion notification must be sent to.
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
        /// Unique identifier of the import job.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("importid")]
        public System.Nullable<System.Guid> ImportId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("importid"); }
            set
            {
                this.OnPropertyChanging("ImportId");
                this.SetAttributeValue("importid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("ImportId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("importid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.ImportId = value; }
        }

        /// <summary>
        /// Information about whether the source of this import job is data import or data migration.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isimport")]
        [System.ObsoleteAttribute()]
        public System.Nullable<bool> IsImport
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("isimport"); }
            set
            {
                this.OnPropertyChanging("IsImport");
                this.SetAttributeValue("isimport", value);
                this.OnPropertyChanged("IsImport");
            }
        }

        /// <summary>
        /// Select whether to create or update records in Microsoft Dynamics CRM during the import job.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modecode")]
        public Microsoft.Xrm.Sdk.OptionSetValue ModeCode
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("modecode"); }
            set
            {
                this.OnPropertyChanging("ModeCode");
                this.SetAttributeValue("modecode", value);
                this.OnPropertyChanged("ModeCode");
            }
        }

        /// <summary>
        /// Shows who last updated the record.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby"); }
        }

        /// <summary>
        /// Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics CRM options.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
        public System.Nullable<System.DateTime> ModifiedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon"); }
        }

        /// <summary>
        /// Shows who created the record on behalf of another user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        /// Shows the name of the import job, based on the import file and the entity being imported.
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
        /// Enter the user or team who is assigned to manage the record. This field is updated every time the record is assigned to a different user.
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
        /// Business unit that owns the import job.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
        public Microsoft.Xrm.Sdk.EntityReference OwningBusinessUnit
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningbusinessunit"); }
        }

        /// <summary>
        /// Unique identifier of the team who owns the import.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
        public Microsoft.Xrm.Sdk.EntityReference OwningTeam
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningteam"); }
        }

        /// <summary>
        /// Unique identifier of the user who owns the import.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
        public Microsoft.Xrm.Sdk.EntityReference OwningUser
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owninguser"); }
        }

        /// <summary>
        /// Select whether to send a notification email message to a selected user after the import is completed.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sendnotification")]
        public System.Nullable<bool> SendNotification
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("sendnotification"); }
            set
            {
                this.OnPropertyChanging("SendNotification");
                this.SetAttributeValue("sendnotification", value);
                this.OnPropertyChanged("SendNotification");
            }
        }

        /// <summary>
        /// Order in which the import was created.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sequence")]
        public System.Nullable<int> Sequence
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("sequence"); }
        }

        /// <summary>
        /// Shows the status of the import job. By default, import jobs are active and can't be deactivated.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
        public System.Nullable<ImportState> StateCode
        {
            get
            {
                Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
                if ((optionSet != null))
                {
                    return ((ImportState) (System.Enum.ToObject(typeof(ImportState), optionSet.Value)));
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// Shows the reason code that explains the import job's status to identify the job's stage of the import processes, from transforming the data to completed.
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
        /// 1:N Import_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Import_AsyncOperations")]
        public System.Collections.Generic.IEnumerable<AsyncOperation> Import_AsyncOperations
        {
            get { return this.GetRelatedEntities<AsyncOperation>("Import_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("Import_AsyncOperations");
                this.SetRelatedEntities<AsyncOperation>("Import_AsyncOperations", null, value);
                this.OnPropertyChanged("Import_AsyncOperations");
            }
        }

        /// <summary>
        /// 1:N Import_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Import_BulkDeleteFailures")]
        public System.Collections.Generic.IEnumerable<BulkDeleteFailure> Import_BulkDeleteFailures
        {
            get { return this.GetRelatedEntities<BulkDeleteFailure>("Import_BulkDeleteFailures", null); }
            set
            {
                this.OnPropertyChanging("Import_BulkDeleteFailures");
                this.SetRelatedEntities<BulkDeleteFailure>("Import_BulkDeleteFailures", null, value);
                this.OnPropertyChanged("Import_BulkDeleteFailures");
            }
        }

        /// <summary>
        /// 1:N Import_ImportFile
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Import_ImportFile")]
        public System.Collections.Generic.IEnumerable<ImportFile> Import_ImportFile
        {
            get { return this.GetRelatedEntities<ImportFile>("Import_ImportFile", null); }
            set
            {
                this.OnPropertyChanging("Import_ImportFile");
                this.SetRelatedEntities<ImportFile>("Import_ImportFile", null, value);
                this.OnPropertyChanged("Import_ImportFile");
            }
        }

        /// <summary>
        /// 1:N userentityinstancedata_import
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_import")]
        public System.Collections.Generic.IEnumerable<UserEntityInstanceData> userentityinstancedata_import
        {
            get { return this.GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_import", null); }
            set
            {
                this.OnPropertyChanging("userentityinstancedata_import");
                this.SetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_import", null, value);
                this.OnPropertyChanged("userentityinstancedata_import");
            }
        }

        /// <summary>
        /// N:1 BusinessUnit_Imports
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("BusinessUnit_Imports")]
        public BusinessUnit BusinessUnit_Imports
        {
            get { return this.GetRelatedEntity<BusinessUnit>("BusinessUnit_Imports", null); }
        }

        /// <summary>
        /// N:1 lk_import_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_import_createdonbehalfby")]
        public SystemUser lk_import_createdonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_import_createdonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_import_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_import_modifiedonbehalfby")]
        public SystemUser lk_import_modifiedonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_import_modifiedonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_importbase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_importbase_createdby")]
        public SystemUser lk_importbase_createdby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_importbase_createdby", null); }
        }

        /// <summary>
        /// N:1 lk_importbase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_importbase_modifiedby")]
        public SystemUser lk_importbase_modifiedby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_importbase_modifiedby", null); }
        }

        /// <summary>
        /// N:1 SystemUser_Imports
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SystemUser_Imports")]
        public SystemUser SystemUser_Imports
        {
            get { return this.GetRelatedEntity<SystemUser>("SystemUser_Imports", null); }
        }

        /// <summary>
        /// N:1 team_Imports
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_Imports")]
        public Team team_Imports
        {
            get { return this.GetRelatedEntity<Team>("team_Imports", null); }
        }
    }
}