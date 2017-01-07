namespace __4_DAL_CRM
{
    /// <summary>
    /// Customized messages for an entity that has been renamed.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("displaystring")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class DisplayString : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public DisplayString() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "displaystring";

        public const int EntityTypeCode = 4102;

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
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("componentstate")]
        public Microsoft.Xrm.Sdk.OptionSetValue ComponentState
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("componentstate"); }
        }

        /// <summary>
        /// Unique identifier of the user who created the display string.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby"); }
        }

        /// <summary>
        /// Date and time when the display string was created.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
        public System.Nullable<System.DateTime> CreatedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who created the displaystring.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        /// Comment for a customized display string.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("customcomment")]
        public string CustomComment
        {
            get { return this.GetAttributeValue<string>("customcomment"); }
            set
            {
                this.OnPropertyChanging("CustomComment");
                this.SetAttributeValue("customcomment", value);
                this.OnPropertyChanged("CustomComment");
            }
        }

        /// <summary>
        /// Customized display string.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("customdisplaystring")]
        public string CustomDisplayString
        {
            get { return this.GetAttributeValue<string>("customdisplaystring"); }
            set
            {
                this.OnPropertyChanging("CustomDisplayString");
                this.SetAttributeValue("customdisplaystring", value);
                this.OnPropertyChanged("CustomDisplayString");
            }
        }

        /// <summary>
        /// Unique identifier of the display string.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("displaystringid")]
        public System.Nullable<System.Guid> DisplayStringId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("displaystringid"); }
            set
            {
                this.OnPropertyChanging("DisplayStringId");
                this.SetAttributeValue("displaystringid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("DisplayStringId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("displaystringid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.DisplayStringId = value; }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("displaystringidunique")]
        public System.Nullable<System.Guid> DisplayStringIdUnique
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("displaystringidunique"); }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("displaystringkey")]
        public string DisplayStringKey
        {
            get { return this.GetAttributeValue<string>("displaystringkey"); }
        }

        /// <summary>
        /// Parameters used for formatting the display string.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("formatparameters")]
        public System.Nullable<int> FormatParameters
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("formatparameters"); }
        }

        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ismanaged")]
        public System.Nullable<bool> IsManaged
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("ismanaged"); }
        }

        /// <summary>
        /// Language code of the display string.
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
        /// Unique identifier of the user who last modified the display string.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby"); }
        }

        /// <summary>
        /// Date and time when the display string was last modified.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
        public System.Nullable<System.DateTime> ModifiedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who last modified the displaystring.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        /// Unique identifier of the organization associated with the display string.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
        public Microsoft.Xrm.Sdk.EntityReference OrganizationId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("organizationid"); }
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
        /// Published display string.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("publisheddisplaystring")]
        public string PublishedDisplayString
        {
            get { return this.GetAttributeValue<string>("publisheddisplaystring"); }
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
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
        public System.Nullable<long> VersionNumber
        {
            get { return this.GetAttributeValue<System.Nullable<long>>("versionnumber"); }
        }

        /// <summary>
        /// 1:N DisplayString_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("DisplayString_AsyncOperations")]
        public System.Collections.Generic.IEnumerable<AsyncOperation> DisplayString_AsyncOperations
        {
            get { return this.GetRelatedEntities<AsyncOperation>("DisplayString_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("DisplayString_AsyncOperations");
                this.SetRelatedEntities<AsyncOperation>("DisplayString_AsyncOperations", null, value);
                this.OnPropertyChanged("DisplayString_AsyncOperations");
            }
        }

        /// <summary>
        /// 1:N DisplayString_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("DisplayString_BulkDeleteFailures")]
        public System.Collections.Generic.IEnumerable<BulkDeleteFailure> DisplayString_BulkDeleteFailures
        {
            get { return this.GetRelatedEntities<BulkDeleteFailure>("DisplayString_BulkDeleteFailures", null); }
            set
            {
                this.OnPropertyChanging("DisplayString_BulkDeleteFailures");
                this.SetRelatedEntities<BulkDeleteFailure>("DisplayString_BulkDeleteFailures", null, value);
                this.OnPropertyChanged("DisplayString_BulkDeleteFailures");
            }
        }

        /// <summary>
        /// 1:N userentityinstancedata_displaystring
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_displaystring")]
        public System.Collections.Generic.IEnumerable<UserEntityInstanceData> userentityinstancedata_displaystring
        {
            get { return this.GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_displaystring", null); }
            set
            {
                this.OnPropertyChanging("userentityinstancedata_displaystring");
                this.SetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_displaystring", null, value);
                this.OnPropertyChanged("userentityinstancedata_displaystring");
            }
        }

        /// <summary>
        /// N:1 lk_DisplayStringbase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_DisplayStringbase_createdby")]
        public SystemUser lk_DisplayStringbase_createdby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_DisplayStringbase_createdby", null); }
        }

        /// <summary>
        /// N:1 lk_DisplayStringbase_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_DisplayStringbase_createdonbehalfby")]
        public SystemUser lk_DisplayStringbase_createdonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_DisplayStringbase_createdonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_DisplayStringbase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_DisplayStringbase_modifiedby")]
        public SystemUser lk_DisplayStringbase_modifiedby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_DisplayStringbase_modifiedby", null); }
        }

        /// <summary>
        /// N:1 lk_DisplayStringbase_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_DisplayStringbase_modifiedonbehalfby")]
        public SystemUser lk_DisplayStringbase_modifiedonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_DisplayStringbase_modifiedonbehalfby", null); }
        }

        /// <summary>
        /// N:1 organization_custom_displaystrings
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_custom_displaystrings")]
        public Organization organization_custom_displaystrings
        {
            get { return this.GetRelatedEntity<Organization>("organization_custom_displaystrings", null); }
        }
    }
}