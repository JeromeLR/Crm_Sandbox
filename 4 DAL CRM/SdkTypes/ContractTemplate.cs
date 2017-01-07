namespace __4_DAL_CRM
{
    /// <summary>
    /// Template for a contract containing the standard attributes of a contract.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("contracttemplate")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class ContractTemplate : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public ContractTemplate() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "contracttemplate";

        public const int EntityTypeCode = 2011;

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
        /// Abbreviation of the contract template name.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("abbreviation")]
        public string Abbreviation
        {
            get { return this.GetAttributeValue<string>("abbreviation"); }
            set
            {
                this.OnPropertyChanging("Abbreviation");
                this.SetAttributeValue("abbreviation", value);
                this.OnPropertyChanged("Abbreviation");
            }
        }

        /// <summary>
        /// Criteria for the contracts based on the template, such as number of cases, time, or coverage dates.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("allotmenttypecode")]
        public Microsoft.Xrm.Sdk.OptionSetValue AllotmentTypeCode
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("allotmenttypecode"); }
            set
            {
                this.OnPropertyChanging("AllotmentTypeCode");
                this.SetAttributeValue("allotmenttypecode", value);
                this.OnPropertyChanged("AllotmentTypeCode");
            }
        }

        /// <summary>
        /// How often the customer or account is to be billed in contracts that are based on the template.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("billingfrequencycode")]
        public Microsoft.Xrm.Sdk.OptionSetValue BillingFrequencyCode
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("billingfrequencycode"); }
            set
            {
                this.OnPropertyChanging("BillingFrequencyCode");
                this.SetAttributeValue("billingfrequencycode", value);
                this.OnPropertyChanged("BillingFrequencyCode");
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
        /// Unique identifier of the level of service specified in contracts that are based on the template.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("contractservicelevelcode")]
        public Microsoft.Xrm.Sdk.OptionSetValue ContractServiceLevelCode
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("contractservicelevelcode"); }
            set
            {
                this.OnPropertyChanging("ContractServiceLevelCode");
                this.SetAttributeValue("contractservicelevelcode", value);
                this.OnPropertyChanged("ContractServiceLevelCode");
            }
        }

        /// <summary>
        /// Unique identifier of the contract template.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("contracttemplateid")]
        public System.Nullable<System.Guid> ContractTemplateId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("contracttemplateid"); }
            set
            {
                this.OnPropertyChanging("ContractTemplateId");
                this.SetAttributeValue("contracttemplateid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("ContractTemplateId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("contracttemplateid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.ContractTemplateId = value; }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("contracttemplateidunique")]
        public System.Nullable<System.Guid> ContractTemplateIdUnique
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("contracttemplateidunique"); }
        }

        /// <summary>
        /// Unique identifier of the user who created the contract template.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby"); }
        }

        /// <summary>
        /// Date and time when the contract template was created.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
        public System.Nullable<System.DateTime> CreatedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who created the contracttemplate.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        /// Description of the contract template.
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
        /// Days of the week and times for which contracts based on the template are effective.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("effectivitycalendar")]
        public string EffectivityCalendar
        {
            get { return this.GetAttributeValue<string>("effectivitycalendar"); }
            set
            {
                this.OnPropertyChanging("EffectivityCalendar");
                this.SetAttributeValue("effectivitycalendar", value);
                this.OnPropertyChanged("EffectivityCalendar");
            }
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
        /// Unique identifier of the user who last modified the contract template.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby"); }
        }

        /// <summary>
        /// Date and time when the contract template was last modified.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
        public System.Nullable<System.DateTime> ModifiedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who last modified the contracttemplate.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        /// Name of the contract template.
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
        /// Unique identifier of the organization associated with the contract template.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
        public Microsoft.Xrm.Sdk.EntityReference OrganizationId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("organizationid"); }
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
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("overwritetime")]
        public System.Nullable<System.DateTime> OverwriteTime
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("overwritetime"); }
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
        /// Specifies whether the discount is a percentage or a monetary amount in contracts based on the template.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("usediscountaspercentage")]
        public System.Nullable<bool> UseDiscountAsPercentage
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("usediscountaspercentage"); }
            set
            {
                this.OnPropertyChanging("UseDiscountAsPercentage");
                this.SetAttributeValue("usediscountaspercentage", value);
                this.OnPropertyChanged("UseDiscountAsPercentage");
            }
        }

        /// <summary>
        /// Version number of the contract template.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
        public System.Nullable<long> VersionNumber
        {
            get { return this.GetAttributeValue<System.Nullable<long>>("versionnumber"); }
        }

        /// <summary>
        /// 1:N contract_template_contracts
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("contract_template_contracts")]
        public System.Collections.Generic.IEnumerable<Contract> contract_template_contracts
        {
            get { return this.GetRelatedEntities<Contract>("contract_template_contracts", null); }
            set
            {
                this.OnPropertyChanging("contract_template_contracts");
                this.SetRelatedEntities<Contract>("contract_template_contracts", null, value);
                this.OnPropertyChanged("contract_template_contracts");
            }
        }

        /// <summary>
        /// 1:N ContractTemplate_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ContractTemplate_AsyncOperations")]
        public System.Collections.Generic.IEnumerable<AsyncOperation> ContractTemplate_AsyncOperations
        {
            get { return this.GetRelatedEntities<AsyncOperation>("ContractTemplate_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("ContractTemplate_AsyncOperations");
                this.SetRelatedEntities<AsyncOperation>("ContractTemplate_AsyncOperations", null, value);
                this.OnPropertyChanged("ContractTemplate_AsyncOperations");
            }
        }

        /// <summary>
        /// 1:N ContractTemplate_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ContractTemplate_BulkDeleteFailures")]
        public System.Collections.Generic.IEnumerable<BulkDeleteFailure> ContractTemplate_BulkDeleteFailures
        {
            get { return this.GetRelatedEntities<BulkDeleteFailure>("ContractTemplate_BulkDeleteFailures", null); }
            set
            {
                this.OnPropertyChanging("ContractTemplate_BulkDeleteFailures");
                this.SetRelatedEntities<BulkDeleteFailure>("ContractTemplate_BulkDeleteFailures", null, value);
                this.OnPropertyChanged("ContractTemplate_BulkDeleteFailures");
            }
        }

        /// <summary>
        /// 1:N ContractTemplate_ProcessSessions
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ContractTemplate_ProcessSessions")]
        public System.Collections.Generic.IEnumerable<ProcessSession> ContractTemplate_ProcessSessions
        {
            get { return this.GetRelatedEntities<ProcessSession>("ContractTemplate_ProcessSessions", null); }
            set
            {
                this.OnPropertyChanging("ContractTemplate_ProcessSessions");
                this.SetRelatedEntities<ProcessSession>("ContractTemplate_ProcessSessions", null, value);
                this.OnPropertyChanged("ContractTemplate_ProcessSessions");
            }
        }

        /// <summary>
        /// 1:N userentityinstancedata_contracttemplate
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_contracttemplate")]
        public System.Collections.Generic.IEnumerable<UserEntityInstanceData> userentityinstancedata_contracttemplate
        {
            get { return this.GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_contracttemplate", null); }
            set
            {
                this.OnPropertyChanging("userentityinstancedata_contracttemplate");
                this.SetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_contracttemplate", null, value);
                this.OnPropertyChanged("userentityinstancedata_contracttemplate");
            }
        }

        /// <summary>
        /// N:1 lk_contracttemplate_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_contracttemplate_createdonbehalfby")]
        public SystemUser lk_contracttemplate_createdonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_contracttemplate_createdonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_contracttemplate_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_contracttemplate_modifiedonbehalfby")]
        public SystemUser lk_contracttemplate_modifiedonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_contracttemplate_modifiedonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_contracttemplatebase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_contracttemplatebase_createdby")]
        public SystemUser lk_contracttemplatebase_createdby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_contracttemplatebase_createdby", null); }
        }

        /// <summary>
        /// N:1 lk_contracttemplatebase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_contracttemplatebase_modifiedby")]
        public SystemUser lk_contracttemplatebase_modifiedby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_contracttemplatebase_modifiedby", null); }
        }

        /// <summary>
        /// N:1 organization_contract_templates
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_contract_templates")]
        public Organization organization_contract_templates
        {
            get { return this.GetRelatedEntity<Organization>("organization_contract_templates", null); }
        }
    }
}