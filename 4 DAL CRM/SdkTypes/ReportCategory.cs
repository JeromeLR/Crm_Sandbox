namespace __4_DAL_CRM
{
    /// <summary>
    /// Categories related to a report. A report can be related to multiple categories.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("reportcategory")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class ReportCategory : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public ReportCategory() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "reportcategory";

        public const int EntityTypeCode = 9102;

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
        /// Category of the report.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("categorycode")]
        public Microsoft.Xrm.Sdk.OptionSetValue CategoryCode
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("categorycode"); }
            set
            {
                this.OnPropertyChanging("CategoryCode");
                this.SetAttributeValue("categorycode", value);
                this.OnPropertyChanged("CategoryCode");
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
        /// Unique identifier of the user who created the report category.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby"); }
        }

        /// <summary>
        /// Date and time when the report category record was created.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
        public System.Nullable<System.DateTime> CreatedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who created the report category.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        /// Exchange rate for the currency associated with the report category with respect to the base currency.
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
        /// Indicates whether the solution component is part of a managed solution.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ismanaged")]
        public System.Nullable<bool> IsManaged
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("ismanaged"); }
        }

        /// <summary>
        /// Unique identifier of the user who last modified the report category.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby"); }
        }

        /// <summary>
        /// Date and time when the report category was last modified.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
        public System.Nullable<System.DateTime> ModifiedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who last modified the report category.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby"); }
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
        /// Unique identifier of the user or team who owns the report category.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ownerid")]
        public Microsoft.Xrm.Sdk.EntityReference OwnerId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("ownerid"); }
        }

        /// <summary>
        /// Unique identifier of the business unit that owns the report category.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
        public System.Nullable<System.Guid> OwningBusinessUnit
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("owningbusinessunit"); }
        }

        /// <summary>
        /// Unique identifier of the user who owns the report category.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
        public System.Nullable<System.Guid> OwningUser
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("owninguser"); }
        }

        /// <summary>
        /// Unique identifier of the report category.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("reportcategoryid")]
        public System.Nullable<System.Guid> ReportCategoryId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("reportcategoryid"); }
            set
            {
                this.OnPropertyChanging("ReportCategoryId");
                this.SetAttributeValue("reportcategoryid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("ReportCategoryId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("reportcategoryid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.ReportCategoryId = value; }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("reportcategoryidunique")]
        public System.Nullable<System.Guid> ReportCategoryIdUnique
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("reportcategoryidunique"); }
        }

        /// <summary>
        /// Unique identifier of the report.
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
        /// Unique identifier of the currency associated with the Report category.
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
        /// Version number of the report category.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
        public System.Nullable<long> VersionNumber
        {
            get { return this.GetAttributeValue<System.Nullable<long>>("versionnumber"); }
        }

        /// <summary>
        /// 1:N reportcategory_principalobjectattributeaccess
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("reportcategory_principalobjectattributeaccess")]
        public System.Collections.Generic.IEnumerable<PrincipalObjectAttributeAccess> reportcategory_principalobjectattributeaccess
        {
            get { return this.GetRelatedEntities<PrincipalObjectAttributeAccess>("reportcategory_principalobjectattributeaccess", null); }
            set
            {
                this.OnPropertyChanging("reportcategory_principalobjectattributeaccess");
                this.SetRelatedEntities<PrincipalObjectAttributeAccess>("reportcategory_principalobjectattributeaccess", null, value);
                this.OnPropertyChanged("reportcategory_principalobjectattributeaccess");
            }
        }

        /// <summary>
        /// 1:N userentityinstancedata_reportcategory
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_reportcategory")]
        public System.Collections.Generic.IEnumerable<UserEntityInstanceData> userentityinstancedata_reportcategory
        {
            get { return this.GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_reportcategory", null); }
            set
            {
                this.OnPropertyChanging("userentityinstancedata_reportcategory");
                this.SetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_reportcategory", null, value);
                this.OnPropertyChanged("userentityinstancedata_reportcategory");
            }
        }

        /// <summary>
        /// N:1 lk_reportcategory_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_reportcategory_createdonbehalfby")]
        public SystemUser lk_reportcategory_createdonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_reportcategory_createdonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_reportcategory_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_reportcategory_modifiedonbehalfby")]
        public SystemUser lk_reportcategory_modifiedonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_reportcategory_modifiedonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_reportcategorybase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_reportcategorybase_createdby")]
        public SystemUser lk_reportcategorybase_createdby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_reportcategorybase_createdby", null); }
        }

        /// <summary>
        /// N:1 lk_reportcategorybase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_reportcategorybase_modifiedby")]
        public SystemUser lk_reportcategorybase_modifiedby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_reportcategorybase_modifiedby", null); }
        }

        /// <summary>
        /// N:1 report_reportcategories
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("reportid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("report_reportcategories")]
        public Report report_reportcategories
        {
            get { return this.GetRelatedEntity<Report>("report_reportcategories", null); }
            set
            {
                this.OnPropertyChanging("report_reportcategories");
                this.SetRelatedEntity<Report>("report_reportcategories", null, value);
                this.OnPropertyChanged("report_reportcategories");
            }
        }

        /// <summary>
        /// N:1 TransactionCurrency_ReportCategory
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("TransactionCurrency_ReportCategory")]
        public TransactionCurrency TransactionCurrency_ReportCategory
        {
            get { return this.GetRelatedEntity<TransactionCurrency>("TransactionCurrency_ReportCategory", null); }
            set
            {
                this.OnPropertyChanging("TransactionCurrency_ReportCategory");
                this.SetRelatedEntity<TransactionCurrency>("TransactionCurrency_ReportCategory", null, value);
                this.OnPropertyChanged("TransactionCurrency_ReportCategory");
            }
        }
    }
}