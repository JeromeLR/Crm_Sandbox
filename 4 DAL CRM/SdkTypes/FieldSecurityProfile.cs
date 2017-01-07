namespace __4_DAL_CRM
{
    /// <summary>
    /// Profile which defines access level for secured attributes
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("fieldsecurityprofile")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class FieldSecurityProfile : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public FieldSecurityProfile() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "fieldsecurityprofile";

        public const int EntityTypeCode = 1200;

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
        /// Unique identifier of the user who created the profile.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby"); }
        }

        /// <summary>
        /// Date and time when the profile was created.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
        public System.Nullable<System.DateTime> CreatedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who created the role.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        /// Description of the Profile
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
        /// Unique identifier of the profile.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("fieldsecurityprofileid")]
        public System.Nullable<System.Guid> FieldSecurityProfileId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("fieldsecurityprofileid"); }
            set
            {
                this.OnPropertyChanging("FieldSecurityProfileId");
                this.SetAttributeValue("fieldsecurityprofileid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("FieldSecurityProfileId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("fieldsecurityprofileid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.FieldSecurityProfileId = value; }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("fieldsecurityprofileidunique")]
        public System.Nullable<System.Guid> FieldSecurityProfileIdUnique
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("fieldsecurityprofileidunique"); }
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
        /// Unique identifier of the user who last modified the profile.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby"); }
        }

        /// <summary>
        /// Date and time when the profile was last modified.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
        public System.Nullable<System.DateTime> ModifiedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who last modified the profile.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        /// Name of the profile.
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
        /// Unique identifier of the associated organization.
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
        /// 1:N lk_fieldpermission_fieldsecurityprofileid
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_fieldpermission_fieldsecurityprofileid")]
        public System.Collections.Generic.IEnumerable<FieldPermission> lk_fieldpermission_fieldsecurityprofileid
        {
            get { return this.GetRelatedEntities<FieldPermission>("lk_fieldpermission_fieldsecurityprofileid", null); }
            set
            {
                this.OnPropertyChanging("lk_fieldpermission_fieldsecurityprofileid");
                this.SetRelatedEntities<FieldPermission>("lk_fieldpermission_fieldsecurityprofileid", null, value);
                this.OnPropertyChanged("lk_fieldpermission_fieldsecurityprofileid");
            }
        }

        /// <summary>
        /// 1:N userentityinstancedata_fieldsecurityprofile
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_fieldsecurityprofile")]
        public System.Collections.Generic.IEnumerable<UserEntityInstanceData> userentityinstancedata_fieldsecurityprofile
        {
            get { return this.GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_fieldsecurityprofile", null); }
            set
            {
                this.OnPropertyChanging("userentityinstancedata_fieldsecurityprofile");
                this.SetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_fieldsecurityprofile", null, value);
                this.OnPropertyChanged("userentityinstancedata_fieldsecurityprofile");
            }
        }

        /// <summary>
        /// N:N systemuserprofiles_association
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("systemuserprofiles_association")]
        public System.Collections.Generic.IEnumerable<SystemUser> systemuserprofiles_association
        {
            get { return this.GetRelatedEntities<SystemUser>("systemuserprofiles_association", null); }
            set
            {
                this.OnPropertyChanging("systemuserprofiles_association");
                this.SetRelatedEntities<SystemUser>("systemuserprofiles_association", null, value);
                this.OnPropertyChanged("systemuserprofiles_association");
            }
        }

        /// <summary>
        /// N:N teamprofiles_association
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("teamprofiles_association")]
        public System.Collections.Generic.IEnumerable<Team> teamprofiles_association
        {
            get { return this.GetRelatedEntities<Team>("teamprofiles_association", null); }
            set
            {
                this.OnPropertyChanging("teamprofiles_association");
                this.SetRelatedEntities<Team>("teamprofiles_association", null, value);
                this.OnPropertyChanged("teamprofiles_association");
            }
        }

        /// <summary>
        /// N:1 lk_fieldsecurityprofile_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_fieldsecurityprofile_createdby")]
        public SystemUser lk_fieldsecurityprofile_createdby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_fieldsecurityprofile_createdby", null); }
        }

        /// <summary>
        /// N:1 lk_fieldsecurityprofile_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_fieldsecurityprofile_createdonbehalfby")]
        public SystemUser lk_fieldsecurityprofile_createdonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_fieldsecurityprofile_createdonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_fieldsecurityprofile_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_fieldsecurityprofile_modifiedby")]
        public SystemUser lk_fieldsecurityprofile_modifiedby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_fieldsecurityprofile_modifiedby", null); }
        }

        /// <summary>
        /// N:1 lk_fieldsecurityprofile_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_fieldsecurityprofile_modifiedonbehalfby")]
        public SystemUser lk_fieldsecurityprofile_modifiedonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_fieldsecurityprofile_modifiedonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_fieldsecurityprofile_organizationid
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_fieldsecurityprofile_organizationid")]
        public Organization lk_fieldsecurityprofile_organizationid
        {
            get { return this.GetRelatedEntity<Organization>("lk_fieldsecurityprofile_organizationid", null); }
        }
    }
}