namespace __4_DAL_CRM
{
    /// <summary>
    /// Mapping of the primary associated objects between which the relationship role is valid.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("relationshiprolemap")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class RelationshipRoleMap : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public RelationshipRoleMap() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "relationshiprolemap";

        public const int EntityTypeCode = 4501;

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
        /// Type of the associated entity in the relationship role mapping.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("associateobjecttypecode")]
        public string AssociateObjectTypeCode
        {
            get { return this.GetAttributeValue<string>("associateobjecttypecode"); }
            set
            {
                this.OnPropertyChanging("AssociateObjectTypeCode");
                this.SetAttributeValue("associateobjecttypecode", value);
                this.OnPropertyChanged("AssociateObjectTypeCode");
            }
        }

        /// <summary>
        /// Unique identifier of the user who created the relationship role map.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby"); }
        }

        /// <summary>
        /// Date and time when the relationship role map was created.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
        public System.Nullable<System.DateTime> CreatedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who created the relationshiprolemap.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        /// Unique identifier of the user who last modified the relationship role map.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby"); }
        }

        /// <summary>
        /// Date and time when the relationship role map record was last modified.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
        public System.Nullable<System.DateTime> ModifiedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who last modified the relationshiprolemap.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        /// Unique identifier of the organization with which the relationship role map is associated.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
        public System.Nullable<System.Guid> OrganizationId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("organizationid"); }
        }

        /// <summary>
        /// Type of the primary entity in the relationship role mapping.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("primaryobjecttypecode")]
        public string PrimaryObjectTypeCode
        {
            get { return this.GetAttributeValue<string>("primaryobjecttypecode"); }
            set
            {
                this.OnPropertyChanging("PrimaryObjectTypeCode");
                this.SetAttributeValue("primaryobjecttypecode", value);
                this.OnPropertyChanged("PrimaryObjectTypeCode");
            }
        }

        /// <summary>
        /// Unique identifier of the relationship role. This relationship role is only valid in a relationship between an entity of type specified in the primaryobjecttypecode property and an entity of type specified in the associateobjecttypecode property.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("relationshiproleid")]
        public Microsoft.Xrm.Sdk.EntityReference RelationshipRoleId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("relationshiproleid"); }
            set
            {
                this.OnPropertyChanging("RelationshipRoleId");
                this.SetAttributeValue("relationshiproleid", value);
                this.OnPropertyChanged("RelationshipRoleId");
            }
        }

        /// <summary>
        /// Unique identifier of the relationship role map.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("relationshiprolemapid")]
        public System.Nullable<System.Guid> RelationshipRoleMapId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("relationshiprolemapid"); }
            set
            {
                this.OnPropertyChanging("RelationshipRoleMapId");
                this.SetAttributeValue("relationshiprolemapid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("RelationshipRoleMapId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("relationshiprolemapid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.RelationshipRoleMapId = value; }
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
        /// 1:N RelationshipRoleMap_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("RelationshipRoleMap_AsyncOperations")]
        public System.Collections.Generic.IEnumerable<AsyncOperation> RelationshipRoleMap_AsyncOperations
        {
            get { return this.GetRelatedEntities<AsyncOperation>("RelationshipRoleMap_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("RelationshipRoleMap_AsyncOperations");
                this.SetRelatedEntities<AsyncOperation>("RelationshipRoleMap_AsyncOperations", null, value);
                this.OnPropertyChanged("RelationshipRoleMap_AsyncOperations");
            }
        }

        /// <summary>
        /// 1:N RelationshipRoleMap_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("RelationshipRoleMap_BulkDeleteFailures")]
        public System.Collections.Generic.IEnumerable<BulkDeleteFailure> RelationshipRoleMap_BulkDeleteFailures
        {
            get { return this.GetRelatedEntities<BulkDeleteFailure>("RelationshipRoleMap_BulkDeleteFailures", null); }
            set
            {
                this.OnPropertyChanging("RelationshipRoleMap_BulkDeleteFailures");
                this.SetRelatedEntities<BulkDeleteFailure>("RelationshipRoleMap_BulkDeleteFailures", null, value);
                this.OnPropertyChanged("RelationshipRoleMap_BulkDeleteFailures");
            }
        }

        /// <summary>
        /// 1:N userentityinstancedata_relationshiprolemap
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_relationshiprolemap")]
        public System.Collections.Generic.IEnumerable<UserEntityInstanceData> userentityinstancedata_relationshiprolemap
        {
            get { return this.GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_relationshiprolemap", null); }
            set
            {
                this.OnPropertyChanging("userentityinstancedata_relationshiprolemap");
                this.SetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_relationshiprolemap", null, value);
                this.OnPropertyChanged("userentityinstancedata_relationshiprolemap");
            }
        }

        /// <summary>
        /// N:1 createdby_relationship_role_map
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("createdby_relationship_role_map")]
        public SystemUser createdby_relationship_role_map
        {
            get { return this.GetRelatedEntity<SystemUser>("createdby_relationship_role_map", null); }
        }

        /// <summary>
        /// N:1 lk_relationshiprolemap_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_relationshiprolemap_createdonbehalfby")]
        public SystemUser lk_relationshiprolemap_createdonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_relationshiprolemap_createdonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_relationshiprolemap_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_relationshiprolemap_modifiedonbehalfby")]
        public SystemUser lk_relationshiprolemap_modifiedonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_relationshiprolemap_modifiedonbehalfby", null); }
        }

        /// <summary>
        /// N:1 modifiedby_relationship_role_map
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("modifiedby_relationship_role_map")]
        public SystemUser modifiedby_relationship_role_map
        {
            get { return this.GetRelatedEntity<SystemUser>("modifiedby_relationship_role_map", null); }
        }

        /// <summary>
        /// N:1 relationship_role_relationship_role_map
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("relationshiproleid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("relationship_role_relationship_role_map")]
        public RelationshipRole relationship_role_relationship_role_map
        {
            get { return this.GetRelatedEntity<RelationshipRole>("relationship_role_relationship_role_map", null); }
            set
            {
                this.OnPropertyChanging("relationship_role_relationship_role_map");
                this.SetRelatedEntity<RelationshipRole>("relationship_role_relationship_role_map", null, value);
                this.OnPropertyChanged("relationship_role_relationship_role_map");
            }
        }
    }
}