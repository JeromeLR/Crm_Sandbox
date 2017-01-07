namespace __4_DAL_CRM
{
    /// <summary>
    /// Links and dependencies between reports. A report may drill through to another report, or it may have another report as a sub-report.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("reportlink")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class ReportLink : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public ReportLink() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "reportlink";

        public const int EntityTypeCode = 9104;

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
        /// Unique identifier of the user who created the report link.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby"); }
        }

        /// <summary>
        /// Date and time when the report link record was created.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
        public System.Nullable<System.DateTime> CreatedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who created the reportlink.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby"); }
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
        /// Unique identifier of the linked report.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("linkedreportid")]
        public Microsoft.Xrm.Sdk.EntityReference LinkedReportId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("linkedreportid"); }
            set
            {
                this.OnPropertyChanging("LinkedReportId");
                this.SetAttributeValue("linkedreportid", value);
                this.OnPropertyChanged("LinkedReportId");
            }
        }

        /// <summary>
        /// Name of the linked report.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("linkedreportname")]
        public string LinkedReportName
        {
            get { return this.GetAttributeValue<string>("linkedreportname"); }
            set
            {
                this.OnPropertyChanging("LinkedReportName");
                this.SetAttributeValue("linkedreportname", value);
                this.OnPropertyChanged("LinkedReportName");
            }
        }

        /// <summary>
        /// Link type of the report.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("linktypecode")]
        public Microsoft.Xrm.Sdk.OptionSetValue LinkTypeCode
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("linktypecode"); }
            set
            {
                this.OnPropertyChanging("LinkTypeCode");
                this.SetAttributeValue("linktypecode", value);
                this.OnPropertyChanged("LinkTypeCode");
            }
        }

        /// <summary>
        /// Unique identifier of the user who last modified the report link.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby"); }
        }

        /// <summary>
        /// Date and time when the report link was last modified.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
        public System.Nullable<System.DateTime> ModifiedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who last modified the reportlink.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        /// Unique identifier of the user or team who owns the report link.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ownerid")]
        public Microsoft.Xrm.Sdk.EntityReference OwnerId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("ownerid"); }
        }

        /// <summary>
        /// Unique identifier of the business unit that owns the report link.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
        public System.Nullable<System.Guid> OwningBusinessUnit
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("owningbusinessunit"); }
        }

        /// <summary>
        /// Unique identifier of the user who owns the report link.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
        public System.Nullable<System.Guid> OwningUser
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("owninguser"); }
        }

        /// <summary>
        /// Unique identifier of the main report.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("reportid")]
        public Microsoft.Xrm.Sdk.EntityReference ReportId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("reportid"); }
            set
            {
                this.OnPropertyChanging("ReportId");
                this.SetAttributeValue("reportid", value);
                this.OnPropertyChanged("ReportId");
            }
        }

        /// <summary>
        /// Unique identifier of the report link.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("reportlinkid")]
        public System.Nullable<System.Guid> ReportLinkId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("reportlinkid"); }
            set
            {
                this.OnPropertyChanging("ReportLinkId");
                this.SetAttributeValue("reportlinkid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("ReportLinkId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("reportlinkid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.ReportLinkId = value; }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("reportlinkidunique")]
        public System.Nullable<System.Guid> ReportLinkIdUnique
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("reportlinkidunique"); }
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
        /// 1:N userentityinstancedata_reportlink
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_reportlink")]
        public System.Collections.Generic.IEnumerable<UserEntityInstanceData> userentityinstancedata_reportlink
        {
            get { return this.GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_reportlink", null); }
            set
            {
                this.OnPropertyChanging("userentityinstancedata_reportlink");
                this.SetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_reportlink", null, value);
                this.OnPropertyChanged("userentityinstancedata_reportlink");
            }
        }

        /// <summary>
        /// N:1 lk_reportlink_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_reportlink_createdonbehalfby")]
        public SystemUser lk_reportlink_createdonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_reportlink_createdonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_reportlink_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_reportlink_modifiedonbehalfby")]
        public SystemUser lk_reportlink_modifiedonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_reportlink_modifiedonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_reportlinkbase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_reportlinkbase_createdby")]
        public SystemUser lk_reportlinkbase_createdby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_reportlinkbase_createdby", null); }
        }

        /// <summary>
        /// N:1 lk_reportlinkbase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_reportlinkbase_modifiedby")]
        public SystemUser lk_reportlinkbase_modifiedby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_reportlinkbase_modifiedby", null); }
        }

        /// <summary>
        /// N:1 report_reportlink
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("reportid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("report_reportlink")]
        public Report report_reportlink
        {
            get { return this.GetRelatedEntity<Report>("report_reportlink", null); }
            set
            {
                this.OnPropertyChanging("report_reportlink");
                this.SetRelatedEntity<Report>("report_reportlink", null, value);
                this.OnPropertyChanged("report_reportlink");
            }
        }

        /// <summary>
        /// N:1 report_reportlink_sub
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("linkedreportid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("report_reportlink_sub")]
        public Report report_reportlink_sub
        {
            get { return this.GetRelatedEntity<Report>("report_reportlink_sub", null); }
            set
            {
                this.OnPropertyChanging("report_reportlink_sub");
                this.SetRelatedEntity<Report>("report_reportlink_sub", null, value);
                this.OnPropertyChanged("report_reportlink_sub");
            }
        }
    }
}