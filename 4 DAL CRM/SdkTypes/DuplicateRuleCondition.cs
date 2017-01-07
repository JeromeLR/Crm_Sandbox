namespace __4_DAL_CRM
{
    /// <summary>
    /// Condition of a duplicate detection rule.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("duplicaterulecondition")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class DuplicateRuleCondition : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public DuplicateRuleCondition() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "duplicaterulecondition";

        public const int EntityTypeCode = 4416;

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
        /// Field that is being compared.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("baseattributename")]
        public string BaseAttributeName
        {
            get { return this.GetAttributeValue<string>("baseattributename"); }
            set
            {
                this.OnPropertyChanging("BaseAttributeName");
                this.SetAttributeValue("baseattributename", value);
                this.OnPropertyChanged("BaseAttributeName");
            }
        }

        /// <summary>
        /// Unique identifier of the user who created the condition.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby"); }
        }

        /// <summary>
        /// Date and time when the condition was created.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
        public System.Nullable<System.DateTime> CreatedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who created the duplicate rule condition.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        /// Unique identifier of the condition.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("duplicateruleconditionid")]
        public System.Nullable<System.Guid> DuplicateRuleConditionId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("duplicateruleconditionid"); }
            set
            {
                this.OnPropertyChanging("DuplicateRuleConditionId");
                this.SetAttributeValue("duplicateruleconditionid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("DuplicateRuleConditionId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("duplicateruleconditionid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.DuplicateRuleConditionId = value; }
        }

        /// <summary>
        /// Determines whether to consider blank values as non-duplicate values
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ignoreblankvalues")]
        public System.Nullable<bool> IgnoreBlankValues
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("ignoreblankvalues"); }
            set
            {
                this.OnPropertyChanging("IgnoreBlankValues");
                this.SetAttributeValue("ignoreblankvalues", value);
                this.OnPropertyChanged("IgnoreBlankValues");
            }
        }

        /// <summary>
        /// Field that is being compared with the base field.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("matchingattributename")]
        public string MatchingAttributeName
        {
            get { return this.GetAttributeValue<string>("matchingattributename"); }
            set
            {
                this.OnPropertyChanging("MatchingAttributeName");
                this.SetAttributeValue("matchingattributename", value);
                this.OnPropertyChanged("MatchingAttributeName");
            }
        }

        /// <summary>
        /// Unique identifier of the user who last modified the condition.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby"); }
        }

        /// <summary>
        /// Date and time when the condition was last modified.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
        public System.Nullable<System.DateTime> ModifiedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who last modified the duplicate rule condition.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        /// Operator for this rule condition.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("operatorcode")]
        public Microsoft.Xrm.Sdk.OptionSetValue OperatorCode
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("operatorcode"); }
            set
            {
                this.OnPropertyChanging("OperatorCode");
                this.SetAttributeValue("operatorcode", value);
                this.OnPropertyChanged("OperatorCode");
            }
        }

        /// <summary>
        /// Parameter value of N if the operator is Same First Characters or Same Last Characters.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("operatorparam")]
        public System.Nullable<int> OperatorParam
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("operatorparam"); }
            set
            {
                this.OnPropertyChanging("OperatorParam");
                this.SetAttributeValue("operatorparam", value);
                this.OnPropertyChanged("OperatorParam");
            }
        }

        /// <summary>
        /// Unique identifier of the user or team who owns the duplicate rule condition.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ownerid")]
        public Microsoft.Xrm.Sdk.EntityReference OwnerId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("ownerid"); }
        }

        /// <summary>
        /// Unique identifier of the business unit that owns the condition.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
        public System.Nullable<System.Guid> OwningBusinessUnit
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("owningbusinessunit"); }
        }

        /// <summary>
        /// Unique identifier of the user who owns the condition.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
        public System.Nullable<System.Guid> OwningUser
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("owninguser"); }
        }

        /// <summary>
        /// Unique identifier of the object with which the condition is associated.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        public Microsoft.Xrm.Sdk.EntityReference RegardingObjectId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("regardingobjectid"); }
            set
            {
                this.OnPropertyChanging("RegardingObjectId");
                this.SetAttributeValue("regardingobjectid", value);
                this.OnPropertyChanged("RegardingObjectId");
            }
        }

        /// <summary>
        /// 1:N userentityinstancedata_duplicaterulecondition
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_duplicaterulecondition")]
        public System.Collections.Generic.IEnumerable<UserEntityInstanceData> userentityinstancedata_duplicaterulecondition
        {
            get { return this.GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_duplicaterulecondition", null); }
            set
            {
                this.OnPropertyChanging("userentityinstancedata_duplicaterulecondition");
                this.SetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_duplicaterulecondition", null, value);
                this.OnPropertyChanged("userentityinstancedata_duplicaterulecondition");
            }
        }

        /// <summary>
        /// N:1 DuplicateRule_DuplicateRuleConditions
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("DuplicateRule_DuplicateRuleConditions")]
        public DuplicateRule DuplicateRule_DuplicateRuleConditions
        {
            get { return this.GetRelatedEntity<DuplicateRule>("DuplicateRule_DuplicateRuleConditions", null); }
            set
            {
                this.OnPropertyChanging("DuplicateRule_DuplicateRuleConditions");
                this.SetRelatedEntity<DuplicateRule>("DuplicateRule_DuplicateRuleConditions", null, value);
                this.OnPropertyChanged("DuplicateRule_DuplicateRuleConditions");
            }
        }

        /// <summary>
        /// N:1 lk_duplicaterulecondition_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_duplicaterulecondition_createdonbehalfby")]
        public SystemUser lk_duplicaterulecondition_createdonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_duplicaterulecondition_createdonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_duplicaterulecondition_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_duplicaterulecondition_modifiedonbehalfby")]
        public SystemUser lk_duplicaterulecondition_modifiedonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_duplicaterulecondition_modifiedonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_duplicateruleconditionbase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_duplicateruleconditionbase_createdby")]
        public SystemUser lk_duplicateruleconditionbase_createdby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_duplicateruleconditionbase_createdby", null); }
        }

        /// <summary>
        /// N:1 lk_duplicateruleconditionbase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_duplicateruleconditionbase_modifiedby")]
        public SystemUser lk_duplicateruleconditionbase_modifiedby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_duplicateruleconditionbase_modifiedby", null); }
        }
    }
}