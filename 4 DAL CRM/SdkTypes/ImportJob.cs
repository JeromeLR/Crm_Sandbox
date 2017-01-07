namespace __4_DAL_CRM
{
    /// <summary>
    /// For internal use only.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("importjob")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class ImportJob : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public ImportJob() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "importjob";

        public const int EntityTypeCode = 9107;

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
        /// Date and time when the import job was completed.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("completedon")]
        public System.Nullable<System.DateTime> CompletedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("completedon"); }
        }

        /// <summary>
        /// Unique identifier of the user who created the importJob.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby"); }
        }

        /// <summary>
        /// Date and time when the import job record was created.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
        public System.Nullable<System.DateTime> CreatedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who created the import job record.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        /// Unstructured data associated with the import job.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("data")]
        public string Data
        {
            get { return this.GetAttributeValue<string>("data"); }
            set
            {
                this.OnPropertyChanging("Data");
                this.SetAttributeValue("data", value);
                this.OnPropertyChanged("Data");
            }
        }

        /// <summary>
        /// Unique identifier of the import job.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("importjobid")]
        public System.Nullable<System.Guid> ImportJobId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("importjobid"); }
            set
            {
                this.OnPropertyChanging("ImportJobId");
                this.SetAttributeValue("importjobid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("ImportJobId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("importjobid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.ImportJobId = value; }
        }

        /// <summary>
        /// Unique identifier of the user who modified the importJob.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby"); }
        }

        /// <summary>
        /// Date and time when the import job was last modified.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
        public System.Nullable<System.DateTime> ModifiedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who modified the import job record.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        /// Name of the import job.
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
        /// Unique identifier of the organization associated with the importjob.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
        public Microsoft.Xrm.Sdk.EntityReference OrganizationId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("organizationid"); }
        }

        /// <summary>
        /// Import Progress Percentage.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("progress")]
        public System.Nullable<double> Progress
        {
            get { return this.GetAttributeValue<System.Nullable<double>>("progress"); }
            set
            {
                this.OnPropertyChanging("Progress");
                this.SetAttributeValue("progress", value);
                this.OnPropertyChanged("Progress");
            }
        }

        /// <summary>
        /// Unique identifier of the solution.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("solutionname")]
        public string SolutionName
        {
            get { return this.GetAttributeValue<string>("solutionname"); }
            set
            {
                this.OnPropertyChanging("SolutionName");
                this.SetAttributeValue("solutionname", value);
                this.OnPropertyChanged("SolutionName");
            }
        }

        /// <summary>
        /// Date and time when the import job was started.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("startedon")]
        public System.Nullable<System.DateTime> StartedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("startedon"); }
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
        /// 1:N userentityinstancedata_importjob
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_importjob")]
        public System.Collections.Generic.IEnumerable<UserEntityInstanceData> userentityinstancedata_importjob
        {
            get { return this.GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_importjob", null); }
            set
            {
                this.OnPropertyChanging("userentityinstancedata_importjob");
                this.SetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_importjob", null, value);
                this.OnPropertyChanged("userentityinstancedata_importjob");
            }
        }

        /// <summary>
        /// N:1 lk_importjobbase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_importjobbase_createdby")]
        public SystemUser lk_importjobbase_createdby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_importjobbase_createdby", null); }
        }

        /// <summary>
        /// N:1 lk_importjobbase_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_importjobbase_createdonbehalfby")]
        public SystemUser lk_importjobbase_createdonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_importjobbase_createdonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_importjobbase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_importjobbase_modifiedby")]
        public SystemUser lk_importjobbase_modifiedby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_importjobbase_modifiedby", null); }
        }

        /// <summary>
        /// N:1 lk_importjobbase_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_importjobbase_modifiedonbehalfby")]
        public SystemUser lk_importjobbase_modifiedonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_importjobbase_modifiedonbehalfby", null); }
        }

        /// <summary>
        /// N:1 organization_importjob
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_importjob")]
        public Organization organization_importjob
        {
            get { return this.GetRelatedEntity<Organization>("organization_importjob", null); }
        }
    }
}