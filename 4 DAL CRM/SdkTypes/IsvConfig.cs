namespace __4_DAL_CRM
{
    /// <summary>
    /// An XML document used to configure client extension controls.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("isvconfig")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class IsvConfig : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public IsvConfig() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "isvconfig";

        public const int EntityTypeCode = 4705;

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
        /// Structured XML data representing the customizations.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("configxml")]
        public string ConfigXML
        {
            get { return this.GetAttributeValue<string>("configxml"); }
            set
            {
                this.OnPropertyChanging("ConfigXML");
                this.SetAttributeValue("configxml", value);
                this.OnPropertyChanged("ConfigXML");
            }
        }

        /// <summary>
        /// Unique identifier of the user who created the ISV configuration.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby"); }
        }

        /// <summary>
        /// Date and time when the ISV configuration was created.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
        public System.Nullable<System.DateTime> CreatedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who created the isvconfig.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        /// Unique identifier of the ISV configuration.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isvconfigid")]
        public System.Nullable<System.Guid> IsvConfigId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("isvconfigid"); }
            set
            {
                this.OnPropertyChanging("IsvConfigId");
                this.SetAttributeValue("isvconfigid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("IsvConfigId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isvconfigid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.IsvConfigId = value; }
        }

        /// <summary>
        /// Unique identifier of the user who last modified the ISV configuration.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby"); }
        }

        /// <summary>
        /// Date and time when the ISV configuration was last modified.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
        public System.Nullable<System.DateTime> ModifiedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who last modified the isvconfig.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        /// Unique identifier of the organization associated with the ISV configuration XML.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
        public System.Nullable<System.Guid> OrganizationId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("organizationid"); }
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
        /// 1:N IsvConfig_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("IsvConfig_AsyncOperations")]
        public System.Collections.Generic.IEnumerable<AsyncOperation> IsvConfig_AsyncOperations
        {
            get { return this.GetRelatedEntities<AsyncOperation>("IsvConfig_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("IsvConfig_AsyncOperations");
                this.SetRelatedEntities<AsyncOperation>("IsvConfig_AsyncOperations", null, value);
                this.OnPropertyChanged("IsvConfig_AsyncOperations");
            }
        }

        /// <summary>
        /// 1:N IsvConfig_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("IsvConfig_BulkDeleteFailures")]
        public System.Collections.Generic.IEnumerable<BulkDeleteFailure> IsvConfig_BulkDeleteFailures
        {
            get { return this.GetRelatedEntities<BulkDeleteFailure>("IsvConfig_BulkDeleteFailures", null); }
            set
            {
                this.OnPropertyChanging("IsvConfig_BulkDeleteFailures");
                this.SetRelatedEntities<BulkDeleteFailure>("IsvConfig_BulkDeleteFailures", null, value);
                this.OnPropertyChanged("IsvConfig_BulkDeleteFailures");
            }
        }

        /// <summary>
        /// 1:N userentityinstancedata_isvconfig
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_isvconfig")]
        public System.Collections.Generic.IEnumerable<UserEntityInstanceData> userentityinstancedata_isvconfig
        {
            get { return this.GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_isvconfig", null); }
            set
            {
                this.OnPropertyChanging("userentityinstancedata_isvconfig");
                this.SetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_isvconfig", null, value);
                this.OnPropertyChanged("userentityinstancedata_isvconfig");
            }
        }

        /// <summary>
        /// N:1 lk_isvconfig_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_isvconfig_createdonbehalfby")]
        public SystemUser lk_isvconfig_createdonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_isvconfig_createdonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_isvconfig_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_isvconfig_modifiedonbehalfby")]
        public SystemUser lk_isvconfig_modifiedonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_isvconfig_modifiedonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_isvconfigbase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_isvconfigbase_createdby")]
        public SystemUser lk_isvconfigbase_createdby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_isvconfigbase_createdby", null); }
        }

        /// <summary>
        /// N:1 lk_isvconfigbase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_isvconfigbase_modifiedby")]
        public SystemUser lk_isvconfigbase_modifiedby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_isvconfigbase_modifiedby", null); }
        }

        /// <summary>
        /// N:1 organization_isvconfigs
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_isvconfigs")]
        public Organization organization_isvconfigs
        {
            get { return this.GetRelatedEntity<Organization>("organization_isvconfigs", null); }
        }
    }
}