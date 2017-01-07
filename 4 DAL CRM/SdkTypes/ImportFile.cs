namespace __4_DAL_CRM
{
    /// <summary>
    /// File name of file used for import.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("importfile")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class ImportFile : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public ImportFile() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "importfile";

        public const int EntityTypeCode = 4412;

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
        /// Shows the secondary column headers. The additional headers are used during the process of transforming the import file into import data records.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("additionalheaderrow")]
        public string AdditionalHeaderRow
        {
            get { return this.GetAttributeValue<string>("additionalheaderrow"); }
        }

        /// <summary>
        /// Shows the date and time when the import associated with the import file was completed.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("completedon")]
        public System.Nullable<System.DateTime> CompletedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("completedon"); }
        }

        /// <summary>
        /// Stores the content of the import file, stored as comma-separated values.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("content")]
        public string Content
        {
            get { return this.GetAttributeValue<string>("content"); }
            set
            {
                this.OnPropertyChanging("Content");
                this.SetAttributeValue("content", value);
                this.OnPropertyChanged("Content");
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
        /// Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics CRM options.
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
        /// Select the single-character data delimiter used in the import file. This is typically a single or double quotation mark.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("datadelimitercode")]
        public Microsoft.Xrm.Sdk.OptionSetValue DataDelimiterCode
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("datadelimitercode"); }
            set
            {
                this.OnPropertyChanging("DataDelimiterCode");
                this.SetAttributeValue("datadelimitercode", value);
                this.OnPropertyChanged("DataDelimiterCode");
            }
        }

        /// <summary>
        /// Select whether duplicate-detection rules should be run against the import job.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("enableduplicatedetection")]
        public System.Nullable<bool> EnableDuplicateDetection
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("enableduplicatedetection"); }
            set
            {
                this.OnPropertyChanging("EnableDuplicateDetection");
                this.SetAttributeValue("enableduplicatedetection", value);
                this.OnPropertyChanged("EnableDuplicateDetection");
            }
        }

        /// <summary>
        /// Shows the number of records in the import file that cannot be imported.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("failurecount")]
        public System.Nullable<int> FailureCount
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("failurecount"); }
        }

        /// <summary>
        /// Select the character that is used to separate each field in the import file. Typically, it is a comma.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("fielddelimitercode")]
        public Microsoft.Xrm.Sdk.OptionSetValue FieldDelimiterCode
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("fielddelimitercode"); }
            set
            {
                this.OnPropertyChanging("FieldDelimiterCode");
                this.SetAttributeValue("fielddelimitercode", value);
                this.OnPropertyChanged("FieldDelimiterCode");
            }
        }

        /// <summary>
        /// Shows the type of source file that is uploaded for import.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("filetypecode")]
        public Microsoft.Xrm.Sdk.OptionSetValue FileTypeCode
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("filetypecode"); }
            set
            {
                this.OnPropertyChanging("FileTypeCode");
                this.SetAttributeValue("filetypecode", value);
                this.OnPropertyChanged("FileTypeCode");
            }
        }

        /// <summary>
        /// Shows a list of each column header in the import file separated by a comma. The header is used for parsing the file during the import job.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("headerrow")]
        public string HeaderRow
        {
            get { return this.GetAttributeValue<string>("headerrow"); }
        }

        /// <summary>
        /// Unique identifier of the import file.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("importfileid")]
        public System.Nullable<System.Guid> ImportFileId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("importfileid"); }
            set
            {
                this.OnPropertyChanging("ImportFileId");
                this.SetAttributeValue("importfileid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("ImportFileId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("importfileid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.ImportFileId = value; }
        }

        /// <summary>
        /// Choose the import job that the file was uploaded for.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("importid")]
        public Microsoft.Xrm.Sdk.EntityReference ImportId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("importid"); }
            set
            {
                this.OnPropertyChanging("ImportId");
                this.SetAttributeValue("importid", value);
                this.OnPropertyChanged("ImportId");
            }
        }

        /// <summary>
        /// Choose a data map to match the import file and its column headers with the record types and fields in Microsoft Dynamics CRM. If the column headers in the file match the display names of the target fields in Microsoft Dynamics CRM, we import the data automatically. If not, you can manually define matches during import.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("importmapid")]
        public Microsoft.Xrm.Sdk.EntityReference ImportMapId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("importmapid"); }
            set
            {
                this.OnPropertyChanging("ImportMapId");
                this.SetAttributeValue("importmapid", value);
                this.OnPropertyChanged("ImportMapId");
            }
        }

        /// <summary>
        /// Select whether the first row of the import file contains column headings, which are used for data mapping during the import job.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isfirstrowheader")]
        public System.Nullable<bool> IsFirstRowHeader
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("isfirstrowheader"); }
            set
            {
                this.OnPropertyChanging("IsFirstRowHeader");
                this.SetAttributeValue("isfirstrowheader", value);
                this.OnPropertyChanged("IsFirstRowHeader");
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
        /// Shows the name of the import file. This name is based on the name of the uploaded file.
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
        /// Enter the user who is assigned to follow up with or manage the import file. This field is updated every time the import file is assigned to a different user.
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
        /// Shows the business unit that the record owner belongs to.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
        public Microsoft.Xrm.Sdk.EntityReference OwningBusinessUnit
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningbusinessunit"); }
        }

        /// <summary>
        /// Unique identifier of the team who owns the import file.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
        public Microsoft.Xrm.Sdk.EntityReference OwningTeam
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningteam"); }
        }

        /// <summary>
        /// Unique identifier of the user who owns the import file.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
        public Microsoft.Xrm.Sdk.EntityReference OwningUser
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owninguser"); }
        }

        /// <summary>
        /// Shows the prefix applied to each column after the import file is parsed.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("parsedtablecolumnprefix")]
        public string ParsedTableColumnPrefix
        {
            get { return this.GetAttributeValue<string>("parsedtablecolumnprefix"); }
        }

        /// <summary>
        /// Shows the number of columns included in the parsed import file.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("parsedtablecolumnsnumber")]
        public System.Nullable<int> ParsedTableColumnsNumber
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("parsedtablecolumnsnumber"); }
        }

        /// <summary>
        /// Shows the name of the table that contains the parsed data from the import file.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("parsedtablename")]
        public string ParsedTableName
        {
            get { return this.GetAttributeValue<string>("parsedtablename"); }
        }

        /// <summary>
        /// Shows the number of records in this file that had failures during the import.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("partialfailurecount")]
        public System.Nullable<int> PartialFailureCount
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("partialfailurecount"); }
        }

        /// <summary>
        /// Tells whether the import file should be ignored or processed during the import.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("processcode")]
        public Microsoft.Xrm.Sdk.OptionSetValue ProcessCode
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("processcode"); }
            set
            {
                this.OnPropertyChanging("ProcessCode");
                this.SetAttributeValue("processcode", value);
                this.OnPropertyChanged("ProcessCode");
            }
        }

        /// <summary>
        /// Shows the import file's processing status code. This indicates whether the data in the import file has been parsed, transformed, or imported.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("processingstatus")]
        public Microsoft.Xrm.Sdk.OptionSetValue ProcessingStatus
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("processingstatus"); }
        }

        /// <summary>
        /// Shows the progress code for the processing of the import file. This field is used when a paused import job is resumed.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("progresscounter")]
        public System.Nullable<int> ProgressCounter
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("progresscounter"); }
        }

        /// <summary>
        /// Choose the user that the records created during the import job should be assigned to.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("recordsownerid")]
        public Microsoft.Xrm.Sdk.EntityReference RecordsOwnerId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("recordsownerid"); }
            set
            {
                this.OnPropertyChanging("RecordsOwnerId");
                this.SetAttributeValue("recordsownerid", value);
                this.OnPropertyChanged("RecordsOwnerId");
            }
        }

        /// <summary>
        /// Shows the columns that are mapped to a related record type (entity) of the primary record type (entity) included in the import file.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("relatedentitycolumns")]
        public string RelatedEntityColumns
        {
            get { return this.GetAttributeValue<string>("relatedentitycolumns"); }
            set
            {
                this.OnPropertyChanging("RelatedEntityColumns");
                this.SetAttributeValue("relatedentitycolumns", value);
                this.OnPropertyChanged("RelatedEntityColumns");
            }
        }

        /// <summary>
        /// Shows the size of the import file, in kilobytes.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("size")]
        public string Size
        {
            get { return this.GetAttributeValue<string>("size"); }
            set
            {
                this.OnPropertyChanging("Size");
                this.SetAttributeValue("size", value);
                this.OnPropertyChanged("Size");
            }
        }

        /// <summary>
        /// Shows the name of the data source file uploaded in the import job.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("source")]
        public string Source
        {
            get { return this.GetAttributeValue<string>("source"); }
            set
            {
                this.OnPropertyChanging("Source");
                this.SetAttributeValue("source", value);
                this.OnPropertyChanged("Source");
            }
        }

        /// <summary>
        /// Shows the record type (entity) of the source data.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sourceentityname")]
        public string SourceEntityName
        {
            get { return this.GetAttributeValue<string>("sourceentityname"); }
            set
            {
                this.OnPropertyChanging("SourceEntityName");
                this.SetAttributeValue("sourceentityname", value);
                this.OnPropertyChanged("SourceEntityName");
            }
        }

        /// <summary>
        /// Shows the status of the import file record. By default, all records are active and can't be deactivated.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
        public System.Nullable<ImportFileState> StateCode
        {
            get
            {
                Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
                if ((optionSet != null))
                {
                    return ((ImportFileState) (System.Enum.ToObject(typeof(ImportFileState), optionSet.Value)));
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// Shows the reason code that explains the import file's status to identify the stage of the import process, from parsing the data to completed.
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
        /// Shows the number of records in the import file that are imported successfully.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("successcount")]
        public System.Nullable<int> SuccessCount
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("successcount"); }
        }

        /// <summary>
        /// Select the target record type (entity) for the records that will be created during the import job.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("targetentityname")]
        public string TargetEntityName
        {
            get { return this.GetAttributeValue<string>("targetentityname"); }
            set
            {
                this.OnPropertyChanging("TargetEntityName");
                this.SetAttributeValue("targetentityname", value);
                this.OnPropertyChanged("TargetEntityName");
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
        /// Shows the total number of records in the import file.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("totalcount")]
        public System.Nullable<int> TotalCount
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("totalcount"); }
        }

        /// <summary>
        /// Tells whether an automatic system map was applied to the import file, which automatically maps the import data to the target entity in Microsoft Dynamics CRM.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("usesystemmap")]
        public System.Nullable<bool> UseSystemMap
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("usesystemmap"); }
            set
            {
                this.OnPropertyChanging("UseSystemMap");
                this.SetAttributeValue("usesystemmap", value);
                this.OnPropertyChanged("UseSystemMap");
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
        /// 1:N ImportFile_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ImportFile_AsyncOperations")]
        public System.Collections.Generic.IEnumerable<AsyncOperation> ImportFile_AsyncOperations
        {
            get { return this.GetRelatedEntities<AsyncOperation>("ImportFile_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("ImportFile_AsyncOperations");
                this.SetRelatedEntities<AsyncOperation>("ImportFile_AsyncOperations", null, value);
                this.OnPropertyChanged("ImportFile_AsyncOperations");
            }
        }

        /// <summary>
        /// 1:N ImportFile_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ImportFile_BulkDeleteFailures")]
        public System.Collections.Generic.IEnumerable<BulkDeleteFailure> ImportFile_BulkDeleteFailures
        {
            get { return this.GetRelatedEntities<BulkDeleteFailure>("ImportFile_BulkDeleteFailures", null); }
            set
            {
                this.OnPropertyChanging("ImportFile_BulkDeleteFailures");
                this.SetRelatedEntities<BulkDeleteFailure>("ImportFile_BulkDeleteFailures", null, value);
                this.OnPropertyChanged("ImportFile_BulkDeleteFailures");
            }
        }

        /// <summary>
        /// 1:N ImportLog_ImportFile
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ImportLog_ImportFile")]
        public System.Collections.Generic.IEnumerable<ImportLog> ImportLog_ImportFile
        {
            get { return this.GetRelatedEntities<ImportLog>("ImportLog_ImportFile", null); }
            set
            {
                this.OnPropertyChanging("ImportLog_ImportFile");
                this.SetRelatedEntities<ImportLog>("ImportLog_ImportFile", null, value);
                this.OnPropertyChanged("ImportLog_ImportFile");
            }
        }

        /// <summary>
        /// 1:N userentityinstancedata_importfile
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_importfile")]
        public System.Collections.Generic.IEnumerable<UserEntityInstanceData> userentityinstancedata_importfile
        {
            get { return this.GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_importfile", null); }
            set
            {
                this.OnPropertyChanging("userentityinstancedata_importfile");
                this.SetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_importfile", null, value);
                this.OnPropertyChanged("userentityinstancedata_importfile");
            }
        }

        /// <summary>
        /// N:1 BusinessUnit_ImportFiles
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("BusinessUnit_ImportFiles")]
        public BusinessUnit BusinessUnit_ImportFiles
        {
            get { return this.GetRelatedEntity<BusinessUnit>("BusinessUnit_ImportFiles", null); }
        }

        /// <summary>
        /// N:1 Import_ImportFile
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("importid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Import_ImportFile")]
        public Import Import_ImportFile
        {
            get { return this.GetRelatedEntity<Import>("Import_ImportFile", null); }
            set
            {
                this.OnPropertyChanging("Import_ImportFile");
                this.SetRelatedEntity<Import>("Import_ImportFile", null, value);
                this.OnPropertyChanged("Import_ImportFile");
            }
        }

        /// <summary>
        /// N:1 ImportFile_SystemUser
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("recordsownerid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ImportFile_SystemUser")]
        public SystemUser ImportFile_SystemUser
        {
            get { return this.GetRelatedEntity<SystemUser>("ImportFile_SystemUser", null); }
            set
            {
                this.OnPropertyChanging("ImportFile_SystemUser");
                this.SetRelatedEntity<SystemUser>("ImportFile_SystemUser", null, value);
                this.OnPropertyChanged("ImportFile_SystemUser");
            }
        }

        /// <summary>
        /// N:1 ImportFile_Team
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("recordsownerid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ImportFile_Team")]
        public Team ImportFile_Team
        {
            get { return this.GetRelatedEntity<Team>("ImportFile_Team", null); }
            set
            {
                this.OnPropertyChanging("ImportFile_Team");
                this.SetRelatedEntity<Team>("ImportFile_Team", null, value);
                this.OnPropertyChanged("ImportFile_Team");
            }
        }

        /// <summary>
        /// N:1 ImportMap_ImportFile
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("importmapid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ImportMap_ImportFile")]
        public ImportMap ImportMap_ImportFile
        {
            get { return this.GetRelatedEntity<ImportMap>("ImportMap_ImportFile", null); }
            set
            {
                this.OnPropertyChanging("ImportMap_ImportFile");
                this.SetRelatedEntity<ImportMap>("ImportMap_ImportFile", null, value);
                this.OnPropertyChanged("ImportMap_ImportFile");
            }
        }

        /// <summary>
        /// N:1 lk_importfilebase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_importfilebase_createdby")]
        public SystemUser lk_importfilebase_createdby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_importfilebase_createdby", null); }
        }

        /// <summary>
        /// N:1 lk_importfilebase_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_importfilebase_createdonbehalfby")]
        public SystemUser lk_importfilebase_createdonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_importfilebase_createdonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_importfilebase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_importfilebase_modifiedby")]
        public SystemUser lk_importfilebase_modifiedby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_importfilebase_modifiedby", null); }
        }

        /// <summary>
        /// N:1 lk_importfilebase_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_importfilebase_modifiedonbehalfby")]
        public SystemUser lk_importfilebase_modifiedonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_importfilebase_modifiedonbehalfby", null); }
        }

        /// <summary>
        /// N:1 SystemUser_ImportFiles
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SystemUser_ImportFiles")]
        public SystemUser SystemUser_ImportFiles
        {
            get { return this.GetRelatedEntity<SystemUser>("SystemUser_ImportFiles", null); }
        }

        /// <summary>
        /// N:1 team_ImportFiles
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_ImportFiles")]
        public Team team_ImportFiles
        {
            get { return this.GetRelatedEntity<Team>("team_ImportFiles", null); }
        }
    }
}