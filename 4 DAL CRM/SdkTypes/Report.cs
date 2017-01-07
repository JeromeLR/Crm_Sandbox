namespace __4_DAL_CRM
{
    /// <summary>
    /// Data summary in an easy-to-read layout.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("report")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class Report : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public Report() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "report";

        public const int EntityTypeCode = 9100;

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
        /// Binary report contents (base-64 encoded).
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("bodybinary")]
        public string BodyBinary
        {
            get { return this.GetAttributeValue<string>("bodybinary"); }
            set
            {
                this.OnPropertyChanging("BodyBinary");
                this.SetAttributeValue("bodybinary", value);
                this.OnPropertyChanged("BodyBinary");
            }
        }

        /// <summary>
        /// Text contents of the RDL file for a Reporting Services report.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("bodytext")]
        public string BodyText
        {
            get { return this.GetAttributeValue<string>("bodytext"); }
            set
            {
                this.OnPropertyChanging("BodyText");
                this.SetAttributeValue("bodytext", value);
                this.OnPropertyChanged("BodyText");
            }
        }

        /// <summary>
        /// URL for a linked report.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("bodyurl")]
        public string BodyUrl
        {
            get { return this.GetAttributeValue<string>("bodyurl"); }
            set
            {
                this.OnPropertyChanging("BodyUrl");
                this.SetAttributeValue("bodyurl", value);
                this.OnPropertyChanged("BodyUrl");
            }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("componentstate")]
        public Microsoft.Xrm.Sdk.OptionSetValue ComponentState
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("componentstate"); }
        }

        /// <summary>
        /// Unique identifier of the user who created the report.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby"); }
        }

        /// <summary>
        /// Major version number of Crm, used to identify the version of Crm in which report is created.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdinmajorversion")]
        public System.Nullable<int> CreatedInMajorVersion
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("createdinmajorversion"); }
            set
            {
                this.OnPropertyChanging("CreatedInMajorVersion");
                this.SetAttributeValue("createdinmajorversion", value);
                this.OnPropertyChanged("CreatedInMajorVersion");
            }
        }

        /// <summary>
        /// Date and time when the report was created.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
        public System.Nullable<System.DateTime> CreatedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who created the report.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        /// XML used to define a custom report.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("customreportxml")]
        public string CustomReportXml
        {
            get { return this.GetAttributeValue<string>("customreportxml"); }
        }

        /// <summary>
        /// Default filter for the report.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("defaultfilter")]
        public string DefaultFilter
        {
            get { return this.GetAttributeValue<string>("defaultfilter"); }
            set
            {
                this.OnPropertyChanging("DefaultFilter");
                this.SetAttributeValue("defaultfilter", value);
                this.OnPropertyChanged("DefaultFilter");
            }
        }

        /// <summary>
        /// Description of the report.
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
        /// File name of the report.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("filename")]
        public string FileName
        {
            get { return this.GetAttributeValue<string>("filename"); }
            set
            {
                this.OnPropertyChanging("FileName");
                this.SetAttributeValue("filename", value);
                this.OnPropertyChanged("FileName");
            }
        }

        /// <summary>
        /// File size of the report.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("filesize")]
        public System.Nullable<int> FileSize
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("filesize"); }
        }

        /// <summary>
        /// Version in which the report is introduced.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("introducedversion")]
        public string IntroducedVersion
        {
            get { return this.GetAttributeValue<string>("introducedversion"); }
            set
            {
                this.OnPropertyChanging("IntroducedVersion");
                this.SetAttributeValue("introducedversion", value);
                this.OnPropertyChanged("IntroducedVersion");
            }
        }

        /// <summary>
        /// Information that specifies whether this component can be customized.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("iscustomizable")]
        public Microsoft.Xrm.Sdk.BooleanManagedProperty IsCustomizable
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.BooleanManagedProperty>("iscustomizable"); }
            set
            {
                this.OnPropertyChanging("IsCustomizable");
                this.SetAttributeValue("iscustomizable", value);
                this.OnPropertyChanged("IsCustomizable");
            }
        }

        /// <summary>
        /// Information about whether the report is a custom report.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("iscustomreport")]
        public System.Nullable<bool> IsCustomReport
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("iscustomreport"); }
        }

        /// <summary>
        /// Indicates whether the solution component is part of a managed solution.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ismanaged")]
        public System.Nullable<bool> IsManaged
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("ismanaged"); }
        }

        /// <summary>
        /// Information about whether the report is personal or is available to all users.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ispersonal")]
        public System.Nullable<bool> IsPersonal
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("ispersonal"); }
            set
            {
                this.OnPropertyChanging("IsPersonal");
                this.SetAttributeValue("ispersonal", value);
                this.OnPropertyChanged("IsPersonal");
            }
        }

        /// <summary>
        /// Information about whether the report is a scheduled report.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isscheduledreport")]
        public System.Nullable<bool> IsScheduledReport
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("isscheduledreport"); }
        }

        /// <summary>
        /// Language in which the report will be displayed.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("languagecode")]
        public System.Nullable<int> LanguageCode
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("languagecode"); }
            set
            {
                this.OnPropertyChanging("LanguageCode");
                this.SetAttributeValue("languagecode", value);
                this.OnPropertyChanged("LanguageCode");
            }
        }

        /// <summary>
        /// MIME type of the report.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("mimetype")]
        public string MimeType
        {
            get { return this.GetAttributeValue<string>("mimetype"); }
            set
            {
                this.OnPropertyChanging("MimeType");
                this.SetAttributeValue("mimetype", value);
                this.OnPropertyChanged("MimeType");
            }
        }

        /// <summary>
        /// Unique identifier of the user who last modified the report.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby"); }
        }

        /// <summary>
        /// Date and time when the report was last modified.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
        public System.Nullable<System.DateTime> ModifiedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who last modified the report.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        /// Name of the report.
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
        /// Original Text contents of the RDL file for a Reporting Services report.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("originalbodytext")]
        public string OriginalBodyText
        {
            get { return this.GetAttributeValue<string>("originalbodytext"); }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("overwritetime")]
        public System.Nullable<System.DateTime> OverwriteTime
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("overwritetime"); }
        }

        /// <summary>
        /// Unique identifier of the user or team who owns the report.
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
        /// Unique identifier of the business unit that owns the report.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
        public Microsoft.Xrm.Sdk.EntityReference OwningBusinessUnit
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningbusinessunit"); }
        }

        /// <summary>
        /// Unique identifier of the team who owns the report.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
        public Microsoft.Xrm.Sdk.EntityReference OwningTeam
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningteam"); }
        }

        /// <summary>
        /// Unique identifier of the user who owns the report.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
        public Microsoft.Xrm.Sdk.EntityReference OwningUser
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owninguser"); }
        }

        /// <summary>
        /// Unique identifier of the parent report.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("parentreportid")]
        public Microsoft.Xrm.Sdk.EntityReference ParentReportId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("parentreportid"); }
            set
            {
                this.OnPropertyChanging("ParentReportId");
                this.SetAttributeValue("parentreportid", value);
                this.OnPropertyChanged("ParentReportId");
            }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("queryinfo")]
        public string QueryInfo
        {
            get { return this.GetAttributeValue<string>("queryinfo"); }
        }

        /// <summary>
        /// Unique identifier of the report.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("reportid")]
        public System.Nullable<System.Guid> ReportId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("reportid"); }
            set
            {
                this.OnPropertyChanging("ReportId");
                this.SetAttributeValue("reportid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("ReportId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("reportid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.ReportId = value; }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("reportidunique")]
        public System.Nullable<System.Guid> ReportIdUnique
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("reportidunique"); }
        }

        /// <summary>
        /// Name of the report on SRS.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("reportnameonsrs")]
        public string ReportNameOnSRS
        {
            get { return this.GetAttributeValue<string>("reportnameonsrs"); }
        }

        /// <summary>
        /// Type of the report.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("reporttypecode")]
        public Microsoft.Xrm.Sdk.OptionSetValue ReportTypeCode
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("reporttypecode"); }
            set
            {
                this.OnPropertyChanging("ReportTypeCode");
                this.SetAttributeValue("reporttypecode", value);
                this.OnPropertyChanged("ReportTypeCode");
            }
        }

        /// <summary>
        /// XML used for defining the report schedule.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("schedulexml")]
        public string ScheduleXml
        {
            get { return this.GetAttributeValue<string>("schedulexml"); }
        }

        /// <summary>
        /// Report signature date, used to identify a report for upgrades and hotfixes.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("signaturedate")]
        public System.Nullable<System.DateTime> SignatureDate
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("signaturedate"); }
            set
            {
                this.OnPropertyChanging("SignatureDate");
                this.SetAttributeValue("signaturedate", value);
                this.OnPropertyChanged("SignatureDate");
            }
        }

        /// <summary>
        /// Unique identifier of the report signature used to identify a report for upgrades and hotfixes.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("signatureid")]
        public System.Nullable<System.Guid> SignatureId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("signatureid"); }
            set
            {
                this.OnPropertyChanging("SignatureId");
                this.SetAttributeValue("signatureid", value);
                this.OnPropertyChanged("SignatureId");
            }
        }

        /// <summary>
        /// Report signature language code used to identify a report for upgrades and hotfixes.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("signaturelcid")]
        public System.Nullable<int> SignatureLcid
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("signaturelcid"); }
            set
            {
                this.OnPropertyChanging("SignatureLcid");
                this.SetAttributeValue("signaturelcid", value);
                this.OnPropertyChanged("SignatureLcid");
            }
        }

        /// <summary>
        /// Report signature major version, used to identify a report for upgrades and hotfixes.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("signaturemajorversion")]
        public System.Nullable<int> SignatureMajorVersion
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("signaturemajorversion"); }
            set
            {
                this.OnPropertyChanging("SignatureMajorVersion");
                this.SetAttributeValue("signaturemajorversion", value);
                this.OnPropertyChanged("SignatureMajorVersion");
            }
        }

        /// <summary>
        /// Report signature minor version, used to identify a report for upgrades and hotfixes.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("signatureminorversion")]
        public System.Nullable<int> SignatureMinorVersion
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("signatureminorversion"); }
            set
            {
                this.OnPropertyChanging("SignatureMinorVersion");
                this.SetAttributeValue("signatureminorversion", value);
                this.OnPropertyChanged("SignatureMinorVersion");
            }
        }

        /// <summary>
        /// Unique identifier of the associated solution.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("solutionid")]
        public System.Nullable<System.Guid> SolutionId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("solutionid"); }
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
        /// Version number of the report.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
        public System.Nullable<long> VersionNumber
        {
            get { return this.GetAttributeValue<System.Nullable<long>>("versionnumber"); }
        }

        /// <summary>
        /// 1:N Report_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Report_AsyncOperations")]
        public System.Collections.Generic.IEnumerable<AsyncOperation> Report_AsyncOperations
        {
            get { return this.GetRelatedEntities<AsyncOperation>("Report_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("Report_AsyncOperations");
                this.SetRelatedEntities<AsyncOperation>("Report_AsyncOperations", null, value);
                this.OnPropertyChanged("Report_AsyncOperations");
            }
        }

        /// <summary>
        /// 1:N report_parent_report
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("report_parent_report", Microsoft.Xrm.Sdk.EntityRole.Referenced)]
        public System.Collections.Generic.IEnumerable<Report> Referencedreport_parent_report
        {
            get { return this.GetRelatedEntities<Report>("report_parent_report", Microsoft.Xrm.Sdk.EntityRole.Referenced); }
            set
            {
                this.OnPropertyChanging("Referencedreport_parent_report");
                this.SetRelatedEntities<Report>("report_parent_report", Microsoft.Xrm.Sdk.EntityRole.Referenced, value);
                this.OnPropertyChanged("Referencedreport_parent_report");
            }
        }

        /// <summary>
        /// 1:N Report_ProcessSessions
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Report_ProcessSessions")]
        public System.Collections.Generic.IEnumerable<ProcessSession> Report_ProcessSessions
        {
            get { return this.GetRelatedEntities<ProcessSession>("Report_ProcessSessions", null); }
            set
            {
                this.OnPropertyChanging("Report_ProcessSessions");
                this.SetRelatedEntities<ProcessSession>("Report_ProcessSessions", null, value);
                this.OnPropertyChanged("Report_ProcessSessions");
            }
        }

        /// <summary>
        /// 1:N report_reportcategories
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("report_reportcategories")]
        public System.Collections.Generic.IEnumerable<ReportCategory> report_reportcategories
        {
            get { return this.GetRelatedEntities<ReportCategory>("report_reportcategories", null); }
            set
            {
                this.OnPropertyChanging("report_reportcategories");
                this.SetRelatedEntities<ReportCategory>("report_reportcategories", null, value);
                this.OnPropertyChanged("report_reportcategories");
            }
        }

        /// <summary>
        /// 1:N report_reportentities
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("report_reportentities")]
        public System.Collections.Generic.IEnumerable<ReportEntity> report_reportentities
        {
            get { return this.GetRelatedEntities<ReportEntity>("report_reportentities", null); }
            set
            {
                this.OnPropertyChanging("report_reportentities");
                this.SetRelatedEntities<ReportEntity>("report_reportentities", null, value);
                this.OnPropertyChanged("report_reportentities");
            }
        }

        /// <summary>
        /// 1:N report_reportlink
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("report_reportlink")]
        public System.Collections.Generic.IEnumerable<ReportLink> report_reportlink
        {
            get { return this.GetRelatedEntities<ReportLink>("report_reportlink", null); }
            set
            {
                this.OnPropertyChanging("report_reportlink");
                this.SetRelatedEntities<ReportLink>("report_reportlink", null, value);
                this.OnPropertyChanged("report_reportlink");
            }
        }

        /// <summary>
        /// 1:N report_reportlink_sub
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("report_reportlink_sub")]
        public System.Collections.Generic.IEnumerable<ReportLink> report_reportlink_sub
        {
            get { return this.GetRelatedEntities<ReportLink>("report_reportlink_sub", null); }
            set
            {
                this.OnPropertyChanging("report_reportlink_sub");
                this.SetRelatedEntities<ReportLink>("report_reportlink_sub", null, value);
                this.OnPropertyChanged("report_reportlink_sub");
            }
        }

        /// <summary>
        /// 1:N report_reportvisibility
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("report_reportvisibility")]
        public System.Collections.Generic.IEnumerable<ReportVisibility> report_reportvisibility
        {
            get { return this.GetRelatedEntities<ReportVisibility>("report_reportvisibility", null); }
            set
            {
                this.OnPropertyChanging("report_reportvisibility");
                this.SetRelatedEntities<ReportVisibility>("report_reportvisibility", null, value);
                this.OnPropertyChanged("report_reportvisibility");
            }
        }

        /// <summary>
        /// 1:N userentityinstancedata_report
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_report")]
        public System.Collections.Generic.IEnumerable<UserEntityInstanceData> userentityinstancedata_report
        {
            get { return this.GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_report", null); }
            set
            {
                this.OnPropertyChanging("userentityinstancedata_report");
                this.SetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_report", null, value);
                this.OnPropertyChanged("userentityinstancedata_report");
            }
        }

        /// <summary>
        /// N:1 business_unit_reports
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_reports")]
        public BusinessUnit business_unit_reports
        {
            get { return this.GetRelatedEntity<BusinessUnit>("business_unit_reports", null); }
        }

        /// <summary>
        /// N:1 lk_report_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_report_createdonbehalfby")]
        public SystemUser lk_report_createdonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_report_createdonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_report_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_report_modifiedonbehalfby")]
        public SystemUser lk_report_modifiedonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_report_modifiedonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_reportbase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_reportbase_createdby")]
        public SystemUser lk_reportbase_createdby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_reportbase_createdby", null); }
        }

        /// <summary>
        /// N:1 lk_reportbase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_reportbase_modifiedby")]
        public SystemUser lk_reportbase_modifiedby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_reportbase_modifiedby", null); }
        }

        /// <summary>
        /// N:1 report_parent_report
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("parentreportid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("report_parent_report", Microsoft.Xrm.Sdk.EntityRole.Referencing)]
        public Report Referencingreport_parent_report
        {
            get { return this.GetRelatedEntity<Report>("report_parent_report", Microsoft.Xrm.Sdk.EntityRole.Referencing); }
            set
            {
                this.OnPropertyChanging("Referencingreport_parent_report");
                this.SetRelatedEntity<Report>("report_parent_report", Microsoft.Xrm.Sdk.EntityRole.Referencing, value);
                this.OnPropertyChanged("Referencingreport_parent_report");
            }
        }
    }
}