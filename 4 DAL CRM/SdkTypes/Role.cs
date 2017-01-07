namespace __4_DAL_CRM
{
    /// <summary>
    /// Grouping of security privileges. Users are assigned roles that authorize their access to the Microsoft CRM system.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("role")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class Role : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public Role() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "role";

        public const int EntityTypeCode = 1036;

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
        /// Unique identifier of the business unit with which the role is associated.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("businessunitid")]
        public Microsoft.Xrm.Sdk.EntityReference BusinessUnitId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("businessunitid"); }
            set
            {
                this.OnPropertyChanging("BusinessUnitId");
                this.SetAttributeValue("businessunitid", value);
                this.OnPropertyChanged("BusinessUnitId");
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
        /// Unique identifier of the user who created the role.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby"); }
        }

        /// <summary>
        /// Date and time when the role was created.
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
        /// Unique identifier of the user who last modified the role.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby"); }
        }

        /// <summary>
        /// Date and time when the role was last modified.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
        public System.Nullable<System.DateTime> ModifiedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who last modified the role.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        /// Name of the role.
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
        /// Unique identifier of the organization associated with the role.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
        public System.Nullable<System.Guid> OrganizationId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("organizationid"); }
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
        /// Unique identifier of the parent role.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("parentroleid")]
        public Microsoft.Xrm.Sdk.EntityReference ParentRoleId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("parentroleid"); }
        }

        /// <summary>
        /// Unique identifier of the parent root role.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("parentrootroleid")]
        public Microsoft.Xrm.Sdk.EntityReference ParentRootRoleId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("parentrootroleid"); }
        }

        /// <summary>
        /// Unique identifier of the role.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("roleid")]
        public System.Nullable<System.Guid> RoleId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("roleid"); }
            set
            {
                this.OnPropertyChanging("RoleId");
                this.SetAttributeValue("roleid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("RoleId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("roleid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.RoleId = value; }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("roleidunique")]
        public System.Nullable<System.Guid> RoleIdUnique
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("roleidunique"); }
        }

        /// <summary>
        /// Unique identifier of the role template that is associated with the role.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("roletemplateid")]
        public Microsoft.Xrm.Sdk.EntityReference RoleTemplateId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("roletemplateid"); }
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
        /// Version number of the role.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
        public System.Nullable<long> VersionNumber
        {
            get { return this.GetAttributeValue<System.Nullable<long>>("versionnumber"); }
        }

        /// <summary>
        /// 1:N Role_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Role_AsyncOperations")]
        public System.Collections.Generic.IEnumerable<AsyncOperation> Role_AsyncOperations
        {
            get { return this.GetRelatedEntities<AsyncOperation>("Role_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("Role_AsyncOperations");
                this.SetRelatedEntities<AsyncOperation>("Role_AsyncOperations", null, value);
                this.OnPropertyChanged("Role_AsyncOperations");
            }
        }

        /// <summary>
        /// 1:N Role_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Role_BulkDeleteFailures")]
        public System.Collections.Generic.IEnumerable<BulkDeleteFailure> Role_BulkDeleteFailures
        {
            get { return this.GetRelatedEntities<BulkDeleteFailure>("Role_BulkDeleteFailures", null); }
            set
            {
                this.OnPropertyChanging("Role_BulkDeleteFailures");
                this.SetRelatedEntities<BulkDeleteFailure>("Role_BulkDeleteFailures", null, value);
                this.OnPropertyChanged("Role_BulkDeleteFailures");
            }
        }

        /// <summary>
        /// 1:N role_parent_role
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("role_parent_role", Microsoft.Xrm.Sdk.EntityRole.Referenced)]
        public System.Collections.Generic.IEnumerable<Role> Referencedrole_parent_role
        {
            get { return this.GetRelatedEntities<Role>("role_parent_role", Microsoft.Xrm.Sdk.EntityRole.Referenced); }
            set
            {
                this.OnPropertyChanging("Referencedrole_parent_role");
                this.SetRelatedEntities<Role>("role_parent_role", Microsoft.Xrm.Sdk.EntityRole.Referenced, value);
                this.OnPropertyChanged("Referencedrole_parent_role");
            }
        }

        /// <summary>
        /// 1:N role_parent_root_role
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("role_parent_root_role", Microsoft.Xrm.Sdk.EntityRole.Referenced)]
        public System.Collections.Generic.IEnumerable<Role> Referencedrole_parent_root_role
        {
            get { return this.GetRelatedEntities<Role>("role_parent_root_role", Microsoft.Xrm.Sdk.EntityRole.Referenced); }
            set
            {
                this.OnPropertyChanging("Referencedrole_parent_root_role");
                this.SetRelatedEntities<Role>("role_parent_root_role", Microsoft.Xrm.Sdk.EntityRole.Referenced, value);
                this.OnPropertyChanged("Referencedrole_parent_root_role");
            }
        }

        /// <summary>
        /// 1:N userentityinstancedata_role
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_role")]
        public System.Collections.Generic.IEnumerable<UserEntityInstanceData> userentityinstancedata_role
        {
            get { return this.GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_role", null); }
            set
            {
                this.OnPropertyChanging("userentityinstancedata_role");
                this.SetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_role", null, value);
                this.OnPropertyChanged("userentityinstancedata_role");
            }
        }

        /// <summary>
        /// N:N roleprivileges_association
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("roleprivileges_association")]
        public System.Collections.Generic.IEnumerable<Privilege> roleprivileges_association
        {
            get { return this.GetRelatedEntities<Privilege>("roleprivileges_association", null); }
            set
            {
                this.OnPropertyChanging("roleprivileges_association");
                this.SetRelatedEntities<Privilege>("roleprivileges_association", null, value);
                this.OnPropertyChanged("roleprivileges_association");
            }
        }

        /// <summary>
        /// N:N systemuserroles_association
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("systemuserroles_association")]
        public System.Collections.Generic.IEnumerable<SystemUser> systemuserroles_association
        {
            get { return this.GetRelatedEntities<SystemUser>("systemuserroles_association", null); }
            set
            {
                this.OnPropertyChanging("systemuserroles_association");
                this.SetRelatedEntities<SystemUser>("systemuserroles_association", null, value);
                this.OnPropertyChanged("systemuserroles_association");
            }
        }

        /// <summary>
        /// N:N teamroles_association
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("teamroles_association")]
        public System.Collections.Generic.IEnumerable<Team> teamroles_association
        {
            get { return this.GetRelatedEntities<Team>("teamroles_association", null); }
            set
            {
                this.OnPropertyChanging("teamroles_association");
                this.SetRelatedEntities<Team>("teamroles_association", null, value);
                this.OnPropertyChanged("teamroles_association");
            }
        }

        /// <summary>
        /// N:1 business_unit_roles
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("businessunitid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_roles")]
        public BusinessUnit business_unit_roles
        {
            get { return this.GetRelatedEntity<BusinessUnit>("business_unit_roles", null); }
            set
            {
                this.OnPropertyChanging("business_unit_roles");
                this.SetRelatedEntity<BusinessUnit>("business_unit_roles", null, value);
                this.OnPropertyChanged("business_unit_roles");
            }
        }

        /// <summary>
        /// N:1 lk_role_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_role_createdonbehalfby")]
        public SystemUser lk_role_createdonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_role_createdonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_role_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_role_modifiedonbehalfby")]
        public SystemUser lk_role_modifiedonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_role_modifiedonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_rolebase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_rolebase_createdby")]
        public SystemUser lk_rolebase_createdby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_rolebase_createdby", null); }
        }

        /// <summary>
        /// N:1 lk_rolebase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_rolebase_modifiedby")]
        public SystemUser lk_rolebase_modifiedby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_rolebase_modifiedby", null); }
        }

        /// <summary>
        /// N:1 organization_roles
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_roles")]
        public Organization organization_roles
        {
            get { return this.GetRelatedEntity<Organization>("organization_roles", null); }
        }

        /// <summary>
        /// N:1 role_parent_role
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("parentroleid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("role_parent_role", Microsoft.Xrm.Sdk.EntityRole.Referencing)]
        public Role Referencingrole_parent_role
        {
            get { return this.GetRelatedEntity<Role>("role_parent_role", Microsoft.Xrm.Sdk.EntityRole.Referencing); }
        }

        /// <summary>
        /// N:1 role_parent_root_role
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("parentrootroleid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("role_parent_root_role", Microsoft.Xrm.Sdk.EntityRole.Referencing)]
        public Role Referencingrole_parent_root_role
        {
            get { return this.GetRelatedEntity<Role>("role_parent_root_role", Microsoft.Xrm.Sdk.EntityRole.Referencing); }
        }
    }
}