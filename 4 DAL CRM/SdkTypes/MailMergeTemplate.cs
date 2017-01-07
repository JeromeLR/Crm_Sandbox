namespace __4_DAL_CRM
{
    /// <summary>
    /// Template for a mail merge document that contains the standard attributes of that document.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("mailmergetemplate")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class MailMergeTemplate : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public MailMergeTemplate() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "mailmergetemplate";

        public const int EntityTypeCode = 9106;

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
        /// Body text of the mail merge template.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("body")]
        public string Body
        {
            get { return this.GetAttributeValue<string>("body"); }
            set
            {
                this.OnPropertyChanging("Body");
                this.SetAttributeValue("body", value);
                this.OnPropertyChanged("Body");
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
        /// Unique identifier of the user who created the mail merge template.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby"); }
        }

        /// <summary>
        /// Date and time when the mail merge template was created.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
        public System.Nullable<System.DateTime> CreatedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who created the mailmergetemplate.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        /// Default data fields associated with the mail merge template.
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
        /// Description of the mail merge template.
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
        /// Version of the Microsoft Office Word XML format used by the template.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("documentformat")]
        public Microsoft.Xrm.Sdk.OptionSetValue DocumentFormat
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("documentformat"); }
            set
            {
                this.OnPropertyChanging("DocumentFormat");
                this.SetAttributeValue("documentformat", value);
                this.OnPropertyChanged("DocumentFormat");
            }
        }

        /// <summary>
        /// Exchange rate for the currency associated with the mailmergetemplate with respect to the base currency.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("exchangerate")]
        public System.Nullable<decimal> ExchangeRate
        {
            get { return this.GetAttributeValue<System.Nullable<decimal>>("exchangerate"); }
        }

        /// <summary>
        /// File name of the mail merge template.
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
        /// File size of the mail merge template.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("filesize")]
        public System.Nullable<int> FileSize
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("filesize"); }
        }

        /// <summary>
        /// Version in which the form is introduced.
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
        /// Indicates whether the solution component is part of a managed solution.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ismanaged")]
        public System.Nullable<bool> IsManaged
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("ismanaged"); }
        }

        /// <summary>
        /// Information about whether the mail merge template is personal or is available to all users.
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
        /// Language of the mail merge template.
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
        /// Unique identifier of the mail merge template.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("mailmergetemplateid")]
        public System.Nullable<System.Guid> MailMergeTemplateId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("mailmergetemplateid"); }
            set
            {
                this.OnPropertyChanging("MailMergeTemplateId");
                this.SetAttributeValue("mailmergetemplateid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("MailMergeTemplateId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("mailmergetemplateid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.MailMergeTemplateId = value; }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("mailmergetemplateidunique")]
        public System.Nullable<System.Guid> MailMergeTemplateIdUnique
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("mailmergetemplateidunique"); }
        }

        /// <summary>
        /// Drop-down list for selecting the type of the mail merge.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("mailmergetype")]
        public Microsoft.Xrm.Sdk.OptionSetValue MailMergeType
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("mailmergetype"); }
            set
            {
                this.OnPropertyChanging("MailMergeType");
                this.SetAttributeValue("mailmergetype", value);
                this.OnPropertyChanged("MailMergeType");
            }
        }

        /// <summary>
        /// MIME type of the mail merge template.
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
        /// Unique identifier of the user who last modified the mail merge template.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby"); }
        }

        /// <summary>
        /// Date and time when the mail merge template was last modified.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
        public System.Nullable<System.DateTime> ModifiedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who last modified the mailmergetemplate.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        /// Name of the mail merge template.
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
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("overwritetime")]
        public System.Nullable<System.DateTime> OverwriteTime
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("overwritetime"); }
        }

        /// <summary>
        /// Unique identifier of the user or team who owns the mail merge template.
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
        /// Unique identifier of the business unit that owns the mail merge template.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
        public Microsoft.Xrm.Sdk.EntityReference OwningBusinessUnit
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningbusinessunit"); }
        }

        /// <summary>
        /// Unique identifier of the team who owns the mail merge template.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
        public Microsoft.Xrm.Sdk.EntityReference OwningTeam
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningteam"); }
        }

        /// <summary>
        /// Unique identifier of the user who owns the mail merge template.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
        public Microsoft.Xrm.Sdk.EntityReference OwningUser
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owninguser"); }
        }

        /// <summary>
        /// Parameter Xml.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("parameterxml")]
        public string ParameterXml
        {
            get { return this.GetAttributeValue<string>("parameterxml"); }
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
        /// Status of the mail merge template.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
        public System.Nullable<MailMergeTemplateState> StateCode
        {
            get
            {
                Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
                if ((optionSet != null))
                {
                    return ((MailMergeTemplateState) (System.Enum.ToObject(typeof(MailMergeTemplateState), optionSet.Value)));
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// Reason for the status of the mail merge template.
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
        /// Type of mail merge template.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("templatetypecode")]
        public string TemplateTypeCode
        {
            get { return this.GetAttributeValue<string>("templatetypecode"); }
            set
            {
                this.OnPropertyChanging("TemplateTypeCode");
                this.SetAttributeValue("templatetypecode", value);
                this.OnPropertyChanged("TemplateTypeCode");
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
        /// Unique identifier of the currency associated with the mailmergetemplate.
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
        /// Version number of the mail merge template.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
        public System.Nullable<long> VersionNumber
        {
            get { return this.GetAttributeValue<System.Nullable<long>>("versionnumber"); }
        }

        /// <summary>
        /// 1:N MailMergeTemplate_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("MailMergeTemplate_AsyncOperations")]
        public System.Collections.Generic.IEnumerable<AsyncOperation> MailMergeTemplate_AsyncOperations
        {
            get { return this.GetRelatedEntities<AsyncOperation>("MailMergeTemplate_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("MailMergeTemplate_AsyncOperations");
                this.SetRelatedEntities<AsyncOperation>("MailMergeTemplate_AsyncOperations", null, value);
                this.OnPropertyChanged("MailMergeTemplate_AsyncOperations");
            }
        }

        /// <summary>
        /// 1:N mailmergetemplate_principalobjectattributeaccess
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("mailmergetemplate_principalobjectattributeaccess")]
        public System.Collections.Generic.IEnumerable<PrincipalObjectAttributeAccess> mailmergetemplate_principalobjectattributeaccess
        {
            get { return this.GetRelatedEntities<PrincipalObjectAttributeAccess>("mailmergetemplate_principalobjectattributeaccess", null); }
            set
            {
                this.OnPropertyChanging("mailmergetemplate_principalobjectattributeaccess");
                this.SetRelatedEntities<PrincipalObjectAttributeAccess>("mailmergetemplate_principalobjectattributeaccess", null, value);
                this.OnPropertyChanged("mailmergetemplate_principalobjectattributeaccess");
            }
        }

        /// <summary>
        /// 1:N MailMergeTemplate_ProcessSessions
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("MailMergeTemplate_ProcessSessions")]
        public System.Collections.Generic.IEnumerable<ProcessSession> MailMergeTemplate_ProcessSessions
        {
            get { return this.GetRelatedEntities<ProcessSession>("MailMergeTemplate_ProcessSessions", null); }
            set
            {
                this.OnPropertyChanging("MailMergeTemplate_ProcessSessions");
                this.SetRelatedEntities<ProcessSession>("MailMergeTemplate_ProcessSessions", null, value);
                this.OnPropertyChanged("MailMergeTemplate_ProcessSessions");
            }
        }

        /// <summary>
        /// 1:N userentityinstancedata_mailmergetemplate
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_mailmergetemplate")]
        public System.Collections.Generic.IEnumerable<UserEntityInstanceData> userentityinstancedata_mailmergetemplate
        {
            get { return this.GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_mailmergetemplate", null); }
            set
            {
                this.OnPropertyChanging("userentityinstancedata_mailmergetemplate");
                this.SetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_mailmergetemplate", null, value);
                this.OnPropertyChanged("userentityinstancedata_mailmergetemplate");
            }
        }

        /// <summary>
        /// N:1 business_unit_mailmergetemplates
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_mailmergetemplates")]
        public BusinessUnit business_unit_mailmergetemplates
        {
            get { return this.GetRelatedEntity<BusinessUnit>("business_unit_mailmergetemplates", null); }
        }

        /// <summary>
        /// N:1 lk_mailmergetemplate_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_mailmergetemplate_createdonbehalfby")]
        public SystemUser lk_mailmergetemplate_createdonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_mailmergetemplate_createdonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_mailmergetemplate_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_mailmergetemplate_modifiedonbehalfby")]
        public SystemUser lk_mailmergetemplate_modifiedonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_mailmergetemplate_modifiedonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_mailmergetemplatebase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_mailmergetemplatebase_createdby")]
        public SystemUser lk_mailmergetemplatebase_createdby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_mailmergetemplatebase_createdby", null); }
        }

        /// <summary>
        /// N:1 lk_mailmergetemplatebase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_mailmergetemplatebase_modifiedby")]
        public SystemUser lk_mailmergetemplatebase_modifiedby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_mailmergetemplatebase_modifiedby", null); }
        }

        /// <summary>
        /// N:1 TransactionCurrency_MailMergeTemplate
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("TransactionCurrency_MailMergeTemplate")]
        public TransactionCurrency TransactionCurrency_MailMergeTemplate
        {
            get { return this.GetRelatedEntity<TransactionCurrency>("TransactionCurrency_MailMergeTemplate", null); }
            set
            {
                this.OnPropertyChanging("TransactionCurrency_MailMergeTemplate");
                this.SetRelatedEntity<TransactionCurrency>("TransactionCurrency_MailMergeTemplate", null, value);
                this.OnPropertyChanged("TransactionCurrency_MailMergeTemplate");
            }
        }
    }
}