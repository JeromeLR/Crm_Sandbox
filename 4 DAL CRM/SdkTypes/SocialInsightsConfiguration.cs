namespace __4_DAL_CRM
{
    /// <summary>
    /// Configuration for the social insights.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("socialinsightsconfiguration")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class SocialInsightsConfiguration : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public SocialInsightsConfiguration() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "socialinsightsconfiguration";

        public const int EntityTypeCode = 1300;

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
        /// Id of the control.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("controlid")]
        public string ControlId
        {
            get { return this.GetAttributeValue<string>("controlid"); }
            set
            {
                this.OnPropertyChanging("ControlId");
                this.SetAttributeValue("controlid", value);
                this.OnPropertyChanged("ControlId");
            }
        }

        /// <summary>
        /// Unique identifier of the user who created the record.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby"); }
        }

        /// <summary>
        /// Date and time when the record was created.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
        public System.Nullable<System.DateTime> CreatedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who created the record.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        /// Unique identifier of the form with which the like is associated.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("formid")]
        public Microsoft.Xrm.Sdk.EntityReference FormId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("formid"); }
            set
            {
                this.OnPropertyChanging("FormId");
                this.SetAttributeValue("formid", value);
                this.OnPropertyChanged("FormId");
            }
        }

        /// <summary>
        /// Unique identifier of the user who modified the record.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby"); }
        }

        /// <summary>
        /// Date and time when the record was modified.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
        public System.Nullable<System.DateTime> ModifiedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who modified the record.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        /// Unique identifier of the organization associated with the solution.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
        public Microsoft.Xrm.Sdk.EntityReference OrganizationId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("organizationid"); }
        }

        /// <summary>
        /// Unique identifier of the associated record.
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
        /// Data Item Id for social data.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("socialdataitemid")]
        public string SocialDataItemId
        {
            get { return this.GetAttributeValue<string>("socialdataitemid"); }
            set
            {
                this.OnPropertyChanging("SocialDataItemId");
                this.SetAttributeValue("socialdataitemid", value);
                this.OnPropertyChanged("SocialDataItemId");
            }
        }

        /// <summary>
        /// Type of social data item.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("socialdataitemtype")]
        public Microsoft.Xrm.Sdk.OptionSetValue SocialDataItemType
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("socialdataitemtype"); }
            set
            {
                this.OnPropertyChanging("SocialDataItemType");
                this.SetAttributeValue("socialdataitemtype", value);
                this.OnPropertyChanged("SocialDataItemType");
            }
        }

        /// <summary>
        /// Parameters used to render social data.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("socialdataparameters")]
        public string SocialDataParameters
        {
            get { return this.GetAttributeValue<string>("socialdataparameters"); }
            set
            {
                this.OnPropertyChanging("SocialDataParameters");
                this.SetAttributeValue("socialdataparameters", value);
                this.OnPropertyChanged("SocialDataParameters");
            }
        }

        /// <summary>
        /// Shows the ID of the social insights configuration.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("socialinsightsconfigurationid")]
        public System.Nullable<System.Guid> SocialInsightsConfigurationId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("socialinsightsconfigurationid"); }
            set
            {
                this.OnPropertyChanging("SocialInsightsConfigurationId");
                this.SetAttributeValue("socialinsightsconfigurationid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("SocialInsightsConfigurationId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("socialinsightsconfigurationid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.SocialInsightsConfigurationId = value; }
        }

        /// <summary>
        /// N:1 lk_socialinsightsconfiguration_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_socialinsightsconfiguration_createdby")]
        public SystemUser lk_socialinsightsconfiguration_createdby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_socialinsightsconfiguration_createdby", null); }
        }

        /// <summary>
        /// N:1 lk_socialinsightsconfiguration_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_socialinsightsconfiguration_createdonbehalfby")]
        public SystemUser lk_socialinsightsconfiguration_createdonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_socialinsightsconfiguration_createdonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_socialinsightsconfiguration_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_socialinsightsconfiguration_modifiedby")]
        public SystemUser lk_socialinsightsconfiguration_modifiedby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_socialinsightsconfiguration_modifiedby", null); }
        }

        /// <summary>
        /// N:1 lk_socialinsightsconfiguration_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_socialinsightsconfiguration_modifiedonbehalfby")]
        public SystemUser lk_socialinsightsconfiguration_modifiedonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_socialinsightsconfiguration_modifiedonbehalfby", null); }
        }

        /// <summary>
        /// N:1 organization_socialinsightsconfiguration
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_socialinsightsconfiguration")]
        public Organization organization_socialinsightsconfiguration
        {
            get { return this.GetRelatedEntity<Organization>("organization_socialinsightsconfiguration", null); }
        }

        /// <summary>
        /// N:1 socialinsightsconfiguration_systemform
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("formid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("socialinsightsconfiguration_systemform")]
        public SystemForm socialinsightsconfiguration_systemform
        {
            get { return this.GetRelatedEntity<SystemForm>("socialinsightsconfiguration_systemform", null); }
            set
            {
                this.OnPropertyChanging("socialinsightsconfiguration_systemform");
                this.SetRelatedEntity<SystemForm>("socialinsightsconfiguration_systemform", null, value);
                this.OnPropertyChanged("socialinsightsconfiguration_systemform");
            }
        }

        /// <summary>
        /// N:1 socialinsightsconfiguration_userform
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("formid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("socialinsightsconfiguration_userform")]
        public UserForm socialinsightsconfiguration_userform
        {
            get { return this.GetRelatedEntity<UserForm>("socialinsightsconfiguration_userform", null); }
            set
            {
                this.OnPropertyChanging("socialinsightsconfiguration_userform");
                this.SetRelatedEntity<UserForm>("socialinsightsconfiguration_userform", null, value);
                this.OnPropertyChanged("socialinsightsconfiguration_userform");
            }
        }
    }
}