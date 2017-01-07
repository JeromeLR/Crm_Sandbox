namespace __4_DAL_CRM
{
    /// <summary>
    /// User-owned dashboards.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("userform")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class UserForm : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public UserForm() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "userform";

        public const int EntityTypeCode = 1031;

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
        /// Type additional information to describe the form or dashboard, such as the filter criteria or intended audience.
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
        /// Shows the XML representation of the layout of the form or dashboard.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("formxml")]
        public string FormXml
        {
            get { return this.GetAttributeValue<string>("formxml"); }
            set
            {
                this.OnPropertyChanging("FormXml");
                this.SetAttributeValue("formxml", value);
                this.OnPropertyChanged("FormXml");
            }
        }

        /// <summary>
        /// Information that specifies whether the dashboard is enabled for tablet.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("istabletenabled")]
        public System.Nullable<bool> IsTabletEnabled
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("istabletenabled"); }
            set
            {
                this.OnPropertyChanging("IsTabletEnabled");
                this.SetAttributeValue("istabletenabled", value);
                this.OnPropertyChanged("IsTabletEnabled");
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
        /// Type a descriptive name for the form or dashboard.
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
        /// Shows the record type (entity) code that the form applies to.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objecttypecode")]
        public string ObjectTypeCode
        {
            get { return this.GetAttributeValue<string>("objecttypecode"); }
            set
            {
                this.OnPropertyChanging("ObjectTypeCode");
                this.SetAttributeValue("objecttypecode", value);
                this.OnPropertyChanged("ObjectTypeCode");
            }
        }

        /// <summary>
        /// Enter the user or team who is assigned to manage the record. This field is updated every time the record is assigned to a different user.
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
        /// Unique identifier of the team who owns the dashboard.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
        public Microsoft.Xrm.Sdk.EntityReference OwningTeam
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningteam"); }
        }

        /// <summary>
        /// Unique identifier of the user who owns the dashboard.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
        public Microsoft.Xrm.Sdk.EntityReference OwningUser
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owninguser"); }
        }

        /// <summary>
        /// Select the form type.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("type")]
        public Microsoft.Xrm.Sdk.OptionSetValue Type
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("type"); }
            set
            {
                this.OnPropertyChanging("Type");
                this.SetAttributeValue("type", value);
                this.OnPropertyChanged("Type");
            }
        }

        /// <summary>
        /// Unique identifier of the user dashboard.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("userformid")]
        public System.Nullable<System.Guid> UserFormId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("userformid"); }
            set
            {
                this.OnPropertyChanging("UserFormId");
                this.SetAttributeValue("userformid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("UserFormId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("userformid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.UserFormId = value; }
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
        /// 1:N socialinsightsconfiguration_userform
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("socialinsightsconfiguration_userform")]
        public System.Collections.Generic.IEnumerable<SocialInsightsConfiguration> socialinsightsconfiguration_userform
        {
            get { return this.GetRelatedEntities<SocialInsightsConfiguration>("socialinsightsconfiguration_userform", null); }
            set
            {
                this.OnPropertyChanging("socialinsightsconfiguration_userform");
                this.SetRelatedEntities<SocialInsightsConfiguration>("socialinsightsconfiguration_userform", null, value);
                this.OnPropertyChanged("socialinsightsconfiguration_userform");
            }
        }

        /// <summary>
        /// 1:N userentityinstancedata_userform
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_userform")]
        public System.Collections.Generic.IEnumerable<UserEntityInstanceData> userentityinstancedata_userform
        {
            get { return this.GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_userform", null); }
            set
            {
                this.OnPropertyChanging("userentityinstancedata_userform");
                this.SetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_userform", null, value);
                this.OnPropertyChanged("userentityinstancedata_userform");
            }
        }

        /// <summary>
        /// 1:N UserForm_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("UserForm_AsyncOperations")]
        public System.Collections.Generic.IEnumerable<AsyncOperation> UserForm_AsyncOperations
        {
            get { return this.GetRelatedEntities<AsyncOperation>("UserForm_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("UserForm_AsyncOperations");
                this.SetRelatedEntities<AsyncOperation>("UserForm_AsyncOperations", null, value);
                this.OnPropertyChanged("UserForm_AsyncOperations");
            }
        }

        /// <summary>
        /// 1:N UserForm_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("UserForm_BulkDeleteFailures")]
        public System.Collections.Generic.IEnumerable<BulkDeleteFailure> UserForm_BulkDeleteFailures
        {
            get { return this.GetRelatedEntities<BulkDeleteFailure>("UserForm_BulkDeleteFailures", null); }
            set
            {
                this.OnPropertyChanging("UserForm_BulkDeleteFailures");
                this.SetRelatedEntities<BulkDeleteFailure>("UserForm_BulkDeleteFailures", null, value);
                this.OnPropertyChanged("UserForm_BulkDeleteFailures");
            }
        }

        /// <summary>
        /// N:1 business_unit_userform
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_userform")]
        public BusinessUnit business_unit_userform
        {
            get { return this.GetRelatedEntity<BusinessUnit>("business_unit_userform", null); }
        }

        /// <summary>
        /// N:1 lk_userform_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_userform_createdby")]
        public SystemUser lk_userform_createdby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_userform_createdby", null); }
        }

        /// <summary>
        /// N:1 lk_userform_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_userform_modifiedby")]
        public SystemUser lk_userform_modifiedby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_userform_modifiedby", null); }
        }

        /// <summary>
        /// N:1 lk_userformbase_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_userformbase_createdonbehalfby")]
        public SystemUser lk_userformbase_createdonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_userformbase_createdonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_userformbase_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_userformbase_modifiedonbehalfby")]
        public SystemUser lk_userformbase_modifiedonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_userformbase_modifiedonbehalfby", null); }
        }

        /// <summary>
        /// N:1 team_userform
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_userform")]
        public Team team_userform
        {
            get { return this.GetRelatedEntity<Team>("team_userform", null); }
        }

        /// <summary>
        /// N:1 user_userform
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_userform")]
        public SystemUser user_userform
        {
            get { return this.GetRelatedEntity<SystemUser>("user_userform", null); }
        }
    }
}