namespace __4_DAL_CRM
{
    /// <summary>
    /// Resource group or team whose members can be scheduled for a service.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("resourcegroup")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class ResourceGroup : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public ResourceGroup() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "resourcegroup";

        public const int EntityTypeCode = 4005;

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
        /// Unique identifier of the business unit with which the scheduling group is associated.
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
        /// Scheduling group type code.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("grouptypecode")]
        public Microsoft.Xrm.Sdk.OptionSetValue GroupTypeCode
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("grouptypecode"); }
        }

        /// <summary>
        /// Name of the scheduling group.
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
        /// Type of entity with which the scheduling group is associated.
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
        /// Unique identifier of the organization associated with the scheduling group.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
        public Microsoft.Xrm.Sdk.EntityReference OrganizationId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("organizationid"); }
        }

        /// <summary>
        /// Unique identifier of the scheduling group.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("resourcegroupid")]
        public System.Nullable<System.Guid> ResourceGroupId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("resourcegroupid"); }
            set
            {
                this.OnPropertyChanging("ResourceGroupId");
                this.SetAttributeValue("resourcegroupid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("ResourceGroupId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("resourcegroupid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.ResourceGroupId = value; }
        }

        /// <summary>
        /// Version number of the scheduling group.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
        public System.Nullable<long> VersionNumber
        {
            get { return this.GetAttributeValue<System.Nullable<long>>("versionnumber"); }
        }

        /// <summary>
        /// 1:N ResourceGroup_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ResourceGroup_AsyncOperations")]
        public System.Collections.Generic.IEnumerable<AsyncOperation> ResourceGroup_AsyncOperations
        {
            get { return this.GetRelatedEntities<AsyncOperation>("ResourceGroup_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("ResourceGroup_AsyncOperations");
                this.SetRelatedEntities<AsyncOperation>("ResourceGroup_AsyncOperations", null, value);
                this.OnPropertyChanged("ResourceGroup_AsyncOperations");
            }
        }

        /// <summary>
        /// 1:N ResourceGroup_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ResourceGroup_BulkDeleteFailures")]
        public System.Collections.Generic.IEnumerable<BulkDeleteFailure> ResourceGroup_BulkDeleteFailures
        {
            get { return this.GetRelatedEntities<BulkDeleteFailure>("ResourceGroup_BulkDeleteFailures", null); }
            set
            {
                this.OnPropertyChanging("ResourceGroup_BulkDeleteFailures");
                this.SetRelatedEntities<BulkDeleteFailure>("ResourceGroup_BulkDeleteFailures", null, value);
                this.OnPropertyChanged("ResourceGroup_BulkDeleteFailures");
            }
        }

        /// <summary>
        /// 1:N resourcegroup_connections1
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("resourcegroup_connections1")]
        public System.Collections.Generic.IEnumerable<Connection> resourcegroup_connections1
        {
            get { return this.GetRelatedEntities<Connection>("resourcegroup_connections1", null); }
            set
            {
                this.OnPropertyChanging("resourcegroup_connections1");
                this.SetRelatedEntities<Connection>("resourcegroup_connections1", null, value);
                this.OnPropertyChanged("resourcegroup_connections1");
            }
        }

        /// <summary>
        /// 1:N resourcegroup_connections2
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("resourcegroup_connections2")]
        public System.Collections.Generic.IEnumerable<Connection> resourcegroup_connections2
        {
            get { return this.GetRelatedEntities<Connection>("resourcegroup_connections2", null); }
            set
            {
                this.OnPropertyChanging("resourcegroup_connections2");
                this.SetRelatedEntities<Connection>("resourcegroup_connections2", null, value);
                this.OnPropertyChanged("resourcegroup_connections2");
            }
        }

        /// <summary>
        /// 1:N ResourceGroup_DuplicateBaseRecord
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ResourceGroup_DuplicateBaseRecord")]
        public System.Collections.Generic.IEnumerable<DuplicateRecord> ResourceGroup_DuplicateBaseRecord
        {
            get { return this.GetRelatedEntities<DuplicateRecord>("ResourceGroup_DuplicateBaseRecord", null); }
            set
            {
                this.OnPropertyChanging("ResourceGroup_DuplicateBaseRecord");
                this.SetRelatedEntities<DuplicateRecord>("ResourceGroup_DuplicateBaseRecord", null, value);
                this.OnPropertyChanged("ResourceGroup_DuplicateBaseRecord");
            }
        }

        /// <summary>
        /// 1:N ResourceGroup_DuplicateMatchingRecord
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ResourceGroup_DuplicateMatchingRecord")]
        public System.Collections.Generic.IEnumerable<DuplicateRecord> ResourceGroup_DuplicateMatchingRecord
        {
            get { return this.GetRelatedEntities<DuplicateRecord>("ResourceGroup_DuplicateMatchingRecord", null); }
            set
            {
                this.OnPropertyChanging("ResourceGroup_DuplicateMatchingRecord");
                this.SetRelatedEntities<DuplicateRecord>("ResourceGroup_DuplicateMatchingRecord", null, value);
                this.OnPropertyChanged("ResourceGroup_DuplicateMatchingRecord");
            }
        }

        /// <summary>
        /// 1:N userentityinstancedata_resourcegroup
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_resourcegroup")]
        public System.Collections.Generic.IEnumerable<UserEntityInstanceData> userentityinstancedata_resourcegroup
        {
            get { return this.GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_resourcegroup", null); }
            set
            {
                this.OnPropertyChanging("userentityinstancedata_resourcegroup");
                this.SetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_resourcegroup", null, value);
                this.OnPropertyChanged("userentityinstancedata_resourcegroup");
            }
        }

        /// <summary>
        /// N:1 business_unit_resource_groups
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("businessunitid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_resource_groups")]
        public BusinessUnit business_unit_resource_groups
        {
            get { return this.GetRelatedEntity<BusinessUnit>("business_unit_resource_groups", null); }
            set
            {
                this.OnPropertyChanging("business_unit_resource_groups");
                this.SetRelatedEntity<BusinessUnit>("business_unit_resource_groups", null, value);
                this.OnPropertyChanged("business_unit_resource_groups");
            }
        }

        /// <summary>
        /// N:1 constraintbasedgroup_resource_groups
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("resourcegroupid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("constraintbasedgroup_resource_groups")]
        public ConstraintBasedGroup constraintbasedgroup_resource_groups
        {
            get { return this.GetRelatedEntity<ConstraintBasedGroup>("constraintbasedgroup_resource_groups", null); }
            set
            {
                this.OnPropertyChanging("constraintbasedgroup_resource_groups");
                this.SetRelatedEntity<ConstraintBasedGroup>("constraintbasedgroup_resource_groups", null, value);
                this.OnPropertyChanged("constraintbasedgroup_resource_groups");
            }
        }

        /// <summary>
        /// N:1 organization_resource_groups
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_resource_groups")]
        public Organization organization_resource_groups
        {
            get { return this.GetRelatedEntity<Organization>("organization_resource_groups", null); }
        }

        /// <summary>
        /// N:1 team_resource_groups
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("resourcegroupid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_resource_groups")]
        public Team team_resource_groups
        {
            get { return this.GetRelatedEntity<Team>("team_resource_groups", null); }
            set
            {
                this.OnPropertyChanging("team_resource_groups");
                this.SetRelatedEntity<Team>("team_resource_groups", null, value);
                this.OnPropertyChanged("team_resource_groups");
            }
        }
    }
}