namespace __4_DAL_CRM
{
    /// <summary>
    /// Represents a mapping between two related entities so that data from one record can be copied into the form of a new related record.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("entitymap")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class EntityMap : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public EntityMap() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "entitymap";

        public const int EntityTypeCode = 4600;

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
        /// Unique identifier of the user who created the entity map.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby"); }
        }

        /// <summary>
        /// Date and time when the entity map was created.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
        public System.Nullable<System.DateTime> CreatedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who created the entitymap.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        /// Unique identifier of the entity map.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entitymapid")]
        public System.Nullable<System.Guid> EntityMapId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("entitymapid"); }
            set
            {
                this.OnPropertyChanging("EntityMapId");
                this.SetAttributeValue("entitymapid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("EntityMapId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entitymapid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.EntityMapId = value; }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entitymapidunique")]
        public System.Nullable<System.Guid> EntityMapIdUnique
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("entitymapidunique"); }
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
        /// Unique identifier of the user who last modified the entity map.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby"); }
        }

        /// <summary>
        /// Date and time when the entity map was last modified.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
        public System.Nullable<System.DateTime> ModifiedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who last modified the entitymap.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        /// Unique identifier of the organization with which the entity map is associated.
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
        /// Name of the source entity for the entity mapping.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sourceentityname")]
        public string SourceEntityName
        {
            get { return this.GetAttributeValue<string>("sourceentityname"); }
            set
            {
                this.OnPropertyChanging("SourceEntityName");
                this.SetAttributeValue("sourceentityname", value);
                this.OnPropertyChanged("SourceEntityName");
            }
        }

        /// <summary>
        /// Name of the Microsoft Dynamics CRM entity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("targetentityname")]
        public string TargetEntityName
        {
            get { return this.GetAttributeValue<string>("targetentityname"); }
            set
            {
                this.OnPropertyChanging("TargetEntityName");
                this.SetAttributeValue("targetentityname", value);
                this.OnPropertyChanged("TargetEntityName");
            }
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
        /// 1:N entity_map_attribute_maps
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("entity_map_attribute_maps")]
        public System.Collections.Generic.IEnumerable<AttributeMap> entity_map_attribute_maps
        {
            get { return this.GetRelatedEntities<AttributeMap>("entity_map_attribute_maps", null); }
            set
            {
                this.OnPropertyChanging("entity_map_attribute_maps");
                this.SetRelatedEntities<AttributeMap>("entity_map_attribute_maps", null, value);
                this.OnPropertyChanged("entity_map_attribute_maps");
            }
        }

        /// <summary>
        /// 1:N EntityMap_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("EntityMap_AsyncOperations")]
        public System.Collections.Generic.IEnumerable<AsyncOperation> EntityMap_AsyncOperations
        {
            get { return this.GetRelatedEntities<AsyncOperation>("EntityMap_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("EntityMap_AsyncOperations");
                this.SetRelatedEntities<AsyncOperation>("EntityMap_AsyncOperations", null, value);
                this.OnPropertyChanged("EntityMap_AsyncOperations");
            }
        }

        /// <summary>
        /// 1:N EntityMap_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("EntityMap_BulkDeleteFailures")]
        public System.Collections.Generic.IEnumerable<BulkDeleteFailure> EntityMap_BulkDeleteFailures
        {
            get { return this.GetRelatedEntities<BulkDeleteFailure>("EntityMap_BulkDeleteFailures", null); }
            set
            {
                this.OnPropertyChanging("EntityMap_BulkDeleteFailures");
                this.SetRelatedEntities<BulkDeleteFailure>("EntityMap_BulkDeleteFailures", null, value);
                this.OnPropertyChanged("EntityMap_BulkDeleteFailures");
            }
        }

        /// <summary>
        /// 1:N userentityinstancedata_entitymap
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_entitymap")]
        public System.Collections.Generic.IEnumerable<UserEntityInstanceData> userentityinstancedata_entitymap
        {
            get { return this.GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_entitymap", null); }
            set
            {
                this.OnPropertyChanging("userentityinstancedata_entitymap");
                this.SetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_entitymap", null, value);
                this.OnPropertyChanged("userentityinstancedata_entitymap");
            }
        }

        /// <summary>
        /// N:1 createdby_entitymap
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("createdby_entitymap")]
        public SystemUser createdby_entitymap
        {
            get { return this.GetRelatedEntity<SystemUser>("createdby_entitymap", null); }
        }

        /// <summary>
        /// N:1 lk_entitymap_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_entitymap_createdonbehalfby")]
        public SystemUser lk_entitymap_createdonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_entitymap_createdonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_entitymap_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_entitymap_modifiedonbehalfby")]
        public SystemUser lk_entitymap_modifiedonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_entitymap_modifiedonbehalfby", null); }
        }

        /// <summary>
        /// N:1 modifiedby_entitymap
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("modifiedby_entitymap")]
        public SystemUser modifiedby_entitymap
        {
            get { return this.GetRelatedEntity<SystemUser>("modifiedby_entitymap", null); }
        }

        /// <summary>
        /// N:1 organization_entitymap
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_entitymap")]
        public Organization organization_entitymap
        {
            get { return this.GetRelatedEntity<Organization>("organization_entitymap", null); }
        }
    }
}