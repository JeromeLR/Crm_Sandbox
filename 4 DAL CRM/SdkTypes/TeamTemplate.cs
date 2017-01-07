namespace __4_DAL_CRM
{
    /// <summary>
    /// Team template for an entity enabled for automatically created access teams.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("teamtemplate")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class TeamTemplate : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public TeamTemplate() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "teamtemplate";

        public const int EntityTypeCode = 92;

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
        /// Unique identifier of the user who created the team template.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby"); }
        }

        /// <summary>
        /// Date and time when the team template was created.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
        public System.Nullable<System.DateTime> CreatedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who created the team template.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        /// Default access rights mask for the access teams associated with entity instances.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("defaultaccessrightsmask")]
        public System.Nullable<int> DefaultAccessRightsMask
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("defaultaccessrightsmask"); }
            set
            {
                this.OnPropertyChanging("DefaultAccessRightsMask");
                this.SetAttributeValue("defaultaccessrightsmask", value);
                this.OnPropertyChanged("DefaultAccessRightsMask");
            }
        }

        /// <summary>
        /// Type additional information that describes the team.
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
        /// Information about whether this team template is user-defined or system-defined.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("issystem")]
        public System.Nullable<bool> IsSystem
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("issystem"); }
        }

        /// <summary>
        /// Unique identifier of the user who last modified the team template.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby"); }
        }

        /// <summary>
        /// Date and time when the team template was last modified.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
        public System.Nullable<System.DateTime> ModifiedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who modified the team template.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        /// Object type code of entity which is enabled for access teams
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objecttypecode")]
        public System.Nullable<int> ObjectTypeCode
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("objecttypecode"); }
            set
            {
                this.OnPropertyChanging("ObjectTypeCode");
                this.SetAttributeValue("objecttypecode", value);
                this.OnPropertyChanged("ObjectTypeCode");
            }
        }

        /// <summary>
        /// Unique identifier of the team template.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("teamtemplateid")]
        public System.Nullable<System.Guid> TeamTemplateId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("teamtemplateid"); }
            set
            {
                this.OnPropertyChanging("TeamTemplateId");
                this.SetAttributeValue("teamtemplateid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("TeamTemplateId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("teamtemplateid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.TeamTemplateId = value; }
        }

        /// <summary>
        /// Type the name of the team template.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("teamtemplatename")]
        public string TeamTemplateName
        {
            get { return this.GetAttributeValue<string>("teamtemplatename"); }
            set
            {
                this.OnPropertyChanging("TeamTemplateName");
                this.SetAttributeValue("teamtemplatename", value);
                this.OnPropertyChanged("TeamTemplateName");
            }
        }

        /// <summary>
        /// 1:N teamtemplate_Teams
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("teamtemplate_Teams")]
        public System.Collections.Generic.IEnumerable<Team> teamtemplate_Teams
        {
            get { return this.GetRelatedEntities<Team>("teamtemplate_Teams", null); }
            set
            {
                this.OnPropertyChanging("teamtemplate_Teams");
                this.SetRelatedEntities<Team>("teamtemplate_Teams", null, value);
                this.OnPropertyChanged("teamtemplate_Teams");
            }
        }

        /// <summary>
        /// N:1 lk_teamtemplate_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_teamtemplate_createdby")]
        public SystemUser lk_teamtemplate_createdby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_teamtemplate_createdby", null); }
        }

        /// <summary>
        /// N:1 lk_teamtemplate_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_teamtemplate_createdonbehalfby")]
        public SystemUser lk_teamtemplate_createdonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_teamtemplate_createdonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_teamtemplate_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_teamtemplate_modifiedby")]
        public SystemUser lk_teamtemplate_modifiedby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_teamtemplate_modifiedby", null); }
        }

        /// <summary>
        /// N:1 lk_teamtemplate_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_teamtemplate_modifiedonbehalfby")]
        public SystemUser lk_teamtemplate_modifiedonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_teamtemplate_modifiedonbehalfby", null); }
        }
    }
}