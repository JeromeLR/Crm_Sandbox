namespace __4_DAL_CRM
{
    /// <summary>
    /// Group or collection of people, equipment, and/or facilities that can be scheduled.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("constraintbasedgroup")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class ConstraintBasedGroup : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public ConstraintBasedGroup() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "constraintbasedgroup";

        public const int EntityTypeCode = 4007;

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
        /// Shows the business unit that the record owner belongs to.
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
        /// Unique identifier of the resource group.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("constraintbasedgroupid")]
        public System.Nullable<System.Guid> ConstraintBasedGroupId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("constraintbasedgroupid"); }
            set
            {
                this.OnPropertyChanging("ConstraintBasedGroupId");
                this.SetAttributeValue("constraintbasedgroupid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("ConstraintBasedGroupId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("constraintbasedgroupid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.ConstraintBasedGroupId = value; }
        }

        /// <summary>
        /// Shows the constraints defined for the users, equipment, teams, and other resource groups included as resources for the group, stored in XML format.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("constraints")]
        public string Constraints
        {
            get { return this.GetAttributeValue<string>("constraints"); }
            set
            {
                this.OnPropertyChanging("Constraints");
                this.SetAttributeValue("constraints", value);
                this.OnPropertyChanged("Constraints");
            }
        }

        /// <summary>
        /// Unique identifier of the user who created the resource group.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby"); }
        }

        /// <summary>
        /// Date and time when the resource group was created.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
        public System.Nullable<System.DateTime> CreatedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who created the constraintbasedgroup.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        /// Type additional information to describe the resource group, such as the intended use or associated resource types.
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
        /// Shows whether the resource group is static, dynamic or hidden. Hidden groups are for system use only and are not viewable in Microsoft Dynamics CRM.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("grouptypecode")]
        public Microsoft.Xrm.Sdk.OptionSetValue GroupTypeCode
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("grouptypecode"); }
            set
            {
                this.OnPropertyChanging("GroupTypeCode");
                this.SetAttributeValue("grouptypecode", value);
                this.OnPropertyChanged("GroupTypeCode");
            }
        }

        /// <summary>
        /// Unique identifier of the user who last modified the resource group.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby"); }
        }

        /// <summary>
        /// Date and time when the resource group was last modified.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
        public System.Nullable<System.DateTime> ModifiedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who last modified the constraintbasedgroup.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        /// Type a title or name that describes the resource group.
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
        /// Unique identifier of the organization associated with the resource group.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
        public Microsoft.Xrm.Sdk.EntityReference OrganizationId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("organizationid"); }
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
        /// 1:N constraint_based_group_resource_specs
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("constraint_based_group_resource_specs")]
        public System.Collections.Generic.IEnumerable<ResourceSpec> constraint_based_group_resource_specs
        {
            get { return this.GetRelatedEntities<ResourceSpec>("constraint_based_group_resource_specs", null); }
            set
            {
                this.OnPropertyChanging("constraint_based_group_resource_specs");
                this.SetRelatedEntities<ResourceSpec>("constraint_based_group_resource_specs", null, value);
                this.OnPropertyChanged("constraint_based_group_resource_specs");
            }
        }

        /// <summary>
        /// 1:N ConstraintBasedGroup_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ConstraintBasedGroup_AsyncOperations")]
        public System.Collections.Generic.IEnumerable<AsyncOperation> ConstraintBasedGroup_AsyncOperations
        {
            get { return this.GetRelatedEntities<AsyncOperation>("ConstraintBasedGroup_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("ConstraintBasedGroup_AsyncOperations");
                this.SetRelatedEntities<AsyncOperation>("ConstraintBasedGroup_AsyncOperations", null, value);
                this.OnPropertyChanged("ConstraintBasedGroup_AsyncOperations");
            }
        }

        /// <summary>
        /// 1:N ConstraintBasedGroup_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ConstraintBasedGroup_BulkDeleteFailures")]
        public System.Collections.Generic.IEnumerable<BulkDeleteFailure> ConstraintBasedGroup_BulkDeleteFailures
        {
            get { return this.GetRelatedEntities<BulkDeleteFailure>("ConstraintBasedGroup_BulkDeleteFailures", null); }
            set
            {
                this.OnPropertyChanging("ConstraintBasedGroup_BulkDeleteFailures");
                this.SetRelatedEntities<BulkDeleteFailure>("ConstraintBasedGroup_BulkDeleteFailures", null, value);
                this.OnPropertyChanged("ConstraintBasedGroup_BulkDeleteFailures");
            }
        }

        /// <summary>
        /// 1:N constraintbasedgroup_connections1
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("constraintbasedgroup_connections1")]
        public System.Collections.Generic.IEnumerable<Connection> constraintbasedgroup_connections1
        {
            get { return this.GetRelatedEntities<Connection>("constraintbasedgroup_connections1", null); }
            set
            {
                this.OnPropertyChanging("constraintbasedgroup_connections1");
                this.SetRelatedEntities<Connection>("constraintbasedgroup_connections1", null, value);
                this.OnPropertyChanged("constraintbasedgroup_connections1");
            }
        }

        /// <summary>
        /// 1:N constraintbasedgroup_connections2
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("constraintbasedgroup_connections2")]
        public System.Collections.Generic.IEnumerable<Connection> constraintbasedgroup_connections2
        {
            get { return this.GetRelatedEntities<Connection>("constraintbasedgroup_connections2", null); }
            set
            {
                this.OnPropertyChanging("constraintbasedgroup_connections2");
                this.SetRelatedEntities<Connection>("constraintbasedgroup_connections2", null, value);
                this.OnPropertyChanged("constraintbasedgroup_connections2");
            }
        }

        /// <summary>
        /// 1:N ConstraintBasedGroup_ProcessSessions
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ConstraintBasedGroup_ProcessSessions")]
        public System.Collections.Generic.IEnumerable<ProcessSession> ConstraintBasedGroup_ProcessSessions
        {
            get { return this.GetRelatedEntities<ProcessSession>("ConstraintBasedGroup_ProcessSessions", null); }
            set
            {
                this.OnPropertyChanging("ConstraintBasedGroup_ProcessSessions");
                this.SetRelatedEntities<ProcessSession>("ConstraintBasedGroup_ProcessSessions", null, value);
                this.OnPropertyChanged("ConstraintBasedGroup_ProcessSessions");
            }
        }

        /// <summary>
        /// 1:N constraintbasedgroup_resource_groups
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("constraintbasedgroup_resource_groups")]
        public System.Collections.Generic.IEnumerable<ResourceGroup> constraintbasedgroup_resource_groups
        {
            get { return this.GetRelatedEntities<ResourceGroup>("constraintbasedgroup_resource_groups", null); }
            set
            {
                this.OnPropertyChanging("constraintbasedgroup_resource_groups");
                this.SetRelatedEntities<ResourceGroup>("constraintbasedgroup_resource_groups", null, value);
                this.OnPropertyChanged("constraintbasedgroup_resource_groups");
            }
        }

        /// <summary>
        /// 1:N userentityinstancedata_constraintbasedgroup
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_constraintbasedgroup")]
        public System.Collections.Generic.IEnumerable<UserEntityInstanceData> userentityinstancedata_constraintbasedgroup
        {
            get { return this.GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_constraintbasedgroup", null); }
            set
            {
                this.OnPropertyChanging("userentityinstancedata_constraintbasedgroup");
                this.SetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_constraintbasedgroup", null, value);
                this.OnPropertyChanged("userentityinstancedata_constraintbasedgroup");
            }
        }

        /// <summary>
        /// N:1 business_unit_constraint_based_groups
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("businessunitid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_constraint_based_groups")]
        public BusinessUnit business_unit_constraint_based_groups
        {
            get { return this.GetRelatedEntity<BusinessUnit>("business_unit_constraint_based_groups", null); }
            set
            {
                this.OnPropertyChanging("business_unit_constraint_based_groups");
                this.SetRelatedEntity<BusinessUnit>("business_unit_constraint_based_groups", null, value);
                this.OnPropertyChanged("business_unit_constraint_based_groups");
            }
        }

        /// <summary>
        /// N:1 constraintbasedgroup_systemuser
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("businessunitid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("constraintbasedgroup_systemuser")]
        public SystemUser constraintbasedgroup_systemuser
        {
            get { return this.GetRelatedEntity<SystemUser>("constraintbasedgroup_systemuser", null); }
            set
            {
                this.OnPropertyChanging("constraintbasedgroup_systemuser");
                this.SetRelatedEntity<SystemUser>("constraintbasedgroup_systemuser", null, value);
                this.OnPropertyChanged("constraintbasedgroup_systemuser");
            }
        }

        /// <summary>
        /// N:1 lk_constraintbasedgroup_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_constraintbasedgroup_createdby")]
        public SystemUser lk_constraintbasedgroup_createdby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_constraintbasedgroup_createdby", null); }
        }

        /// <summary>
        /// N:1 lk_constraintbasedgroup_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_constraintbasedgroup_createdonbehalfby")]
        public SystemUser lk_constraintbasedgroup_createdonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_constraintbasedgroup_createdonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_constraintbasedgroup_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_constraintbasedgroup_modifiedby")]
        public SystemUser lk_constraintbasedgroup_modifiedby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_constraintbasedgroup_modifiedby", null); }
        }

        /// <summary>
        /// N:1 lk_constraintbasedgroup_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_constraintbasedgroup_modifiedonbehalfby")]
        public SystemUser lk_constraintbasedgroup_modifiedonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_constraintbasedgroup_modifiedonbehalfby", null); }
        }

        /// <summary>
        /// N:1 organization_constraint_based_groups
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_constraint_based_groups")]
        public Organization organization_constraint_based_groups
        {
            get { return this.GetRelatedEntity<Organization>("organization_constraint_based_groups", null); }
        }
    }
}