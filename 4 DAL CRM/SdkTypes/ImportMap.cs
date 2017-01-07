namespace __4_DAL_CRM
{
    /// <summary>
    /// Data map used in import.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("importmap")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class ImportMap : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public ImportMap() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "importmap";

        public const int EntityTypeCode = 4411;

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
        /// Type additional information to describe the data map, such as the intended use or data source.
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
        /// Choose whether a data file can contain data for one or more record types.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entitiesperfile")]
        public Microsoft.Xrm.Sdk.OptionSetValue EntitiesPerFile
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("entitiesperfile"); }
            set
            {
                this.OnPropertyChanging("EntitiesPerFile");
                this.SetAttributeValue("entitiesperfile", value);
                this.OnPropertyChanged("EntitiesPerFile");
            }
        }

        /// <summary>
        /// Unique identifier of the data map.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("importmapid")]
        public System.Nullable<System.Guid> ImportMapId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("importmapid"); }
            set
            {
                this.OnPropertyChanging("ImportMapId");
                this.SetAttributeValue("importmapid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("ImportMapId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("importmapid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.ImportMapId = value; }
        }

        /// <summary>
        /// Select the type of data map to distinguish out-of-the-box data maps from custom maps.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("importmaptype")]
        public Microsoft.Xrm.Sdk.OptionSetValue ImportMapType
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("importmaptype"); }
            set
            {
                this.OnPropertyChanging("ImportMapType");
                this.SetAttributeValue("importmaptype", value);
                this.OnPropertyChanged("ImportMapType");
            }
        }

        /// <summary>
        /// Information about whether the data map is valid for use with data import.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isvalidforimport")]
        public System.Nullable<bool> IsValidForImport
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("isvalidforimport"); }
        }

        /// <summary>
        /// Information about whether this data map was created by the Data Migration Manager.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("iswizardcreated")]
        public System.Nullable<bool> IsWizardCreated
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("iswizardcreated"); }
            set
            {
                this.OnPropertyChanging("IsWizardCreated");
                this.SetAttributeValue("iswizardcreated", value);
                this.OnPropertyChanged("IsWizardCreated");
            }
        }

        /// <summary>
        /// Customizations XML
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("mapcustomizations")]
        public string MapCustomizations
        {
            get { return this.GetAttributeValue<string>("mapcustomizations"); }
            set
            {
                this.OnPropertyChanging("MapCustomizations");
                this.SetAttributeValue("mapcustomizations", value);
                this.OnPropertyChanged("MapCustomizations");
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
        /// Shows who last updated the record on behalf of another user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        /// Type a descriptive name for the data map.
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
        /// Business unit that owns the data map.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
        public Microsoft.Xrm.Sdk.EntityReference OwningBusinessUnit
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningbusinessunit"); }
        }

        /// <summary>
        /// Unique identifier of the team who owns the data map.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
        public Microsoft.Xrm.Sdk.EntityReference OwningTeam
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningteam"); }
        }

        /// <summary>
        /// Unique identifier of the user who owns the data map.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
        public Microsoft.Xrm.Sdk.EntityReference OwningUser
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owninguser"); }
        }

        /// <summary>
        /// Type the name of the migration source that this data map is used for.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("source")]
        public string Source
        {
            get { return this.GetAttributeValue<string>("source"); }
            set
            {
                this.OnPropertyChanging("Source");
                this.SetAttributeValue("source", value);
                this.OnPropertyChanged("Source");
            }
        }

        /// <summary>
        /// Select the migration source type that this data map is used for.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sourcetype")]
        public Microsoft.Xrm.Sdk.OptionSetValue SourceType
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("sourcetype"); }
            set
            {
                this.OnPropertyChanging("SourceType");
                this.SetAttributeValue("sourcetype", value);
                this.OnPropertyChanged("SourceType");
            }
        }

        /// <summary>
        /// Source user value for source Microsoft Dynamics CRM user link.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sourceuseridentifierforsourcecrmuserlink")]
        public string SourceUserIdentifierForSourceCRMUserLink
        {
            get { return this.GetAttributeValue<string>("sourceuseridentifierforsourcecrmuserlink"); }
            set
            {
                this.OnPropertyChanging("SourceUserIdentifierForSourceCRMUserLink");
                this.SetAttributeValue("sourceuseridentifierforsourcecrmuserlink", value);
                this.OnPropertyChanged("SourceUserIdentifierForSourceCRMUserLink");
            }
        }

        /// <summary>
        /// Column in the source file that uniquely identifies a user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sourceuseridentifierforsourcedatasourceuserlink")]
        public string SourceUserIdentifierForSourceDataSourceUserLink
        {
            get { return this.GetAttributeValue<string>("sourceuseridentifierforsourcedatasourceuserlink"); }
            set
            {
                this.OnPropertyChanging("SourceUserIdentifierForSourceDataSourceUserLink");
                this.SetAttributeValue("sourceuseridentifierforsourcedatasourceuserlink", value);
                this.OnPropertyChanged("SourceUserIdentifierForSourceDataSourceUserLink");
            }
        }

        /// <summary>
        /// Shows whether the data map is active or inactive. Inactive data maps are read-only and can't be edited.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
        public System.Nullable<ImportMapState> StateCode
        {
            get
            {
                Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
                if ((optionSet != null))
                {
                    return ((ImportMapState) (System.Enum.ToObject(typeof(ImportMapState), optionSet.Value)));
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// Select the data map's status.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statuscode")]
        public Microsoft.Xrm.Sdk.OptionSetValue StatusCode
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statuscode"); }
            set
            {
                this.OnPropertyChanging("StatusCode");
                this.SetAttributeValue("statuscode", value);
                this.OnPropertyChanged("StatusCode");
            }
        }

        /// <summary>
        /// Select the name of the Microsoft Dynamics CRM record type that this data map is defined for.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("targetentity")]
        public Microsoft.Xrm.Sdk.OptionSetValue TargetEntity
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("targetentity"); }
        }

        /// <summary>
        /// Microsoft Dynamics CRM user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("targetuseridentifierforsourcecrmuserlink")]
        public string TargetUserIdentifierForSourceCRMUserLink
        {
            get { return this.GetAttributeValue<string>("targetuseridentifierforsourcecrmuserlink"); }
            set
            {
                this.OnPropertyChanging("TargetUserIdentifierForSourceCRMUserLink");
                this.SetAttributeValue("targetuseridentifierforsourcecrmuserlink", value);
                this.OnPropertyChanged("TargetUserIdentifierForSourceCRMUserLink");
            }
        }

        /// <summary>
        /// 1:N ColumnMapping_ImportMap
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ColumnMapping_ImportMap")]
        public System.Collections.Generic.IEnumerable<ColumnMapping> ColumnMapping_ImportMap
        {
            get { return this.GetRelatedEntities<ColumnMapping>("ColumnMapping_ImportMap", null); }
            set
            {
                this.OnPropertyChanging("ColumnMapping_ImportMap");
                this.SetRelatedEntities<ColumnMapping>("ColumnMapping_ImportMap", null, value);
                this.OnPropertyChanged("ColumnMapping_ImportMap");
            }
        }

        /// <summary>
        /// 1:N ImportEntityMapping_ImportMap
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ImportEntityMapping_ImportMap")]
        public System.Collections.Generic.IEnumerable<ImportEntityMapping> ImportEntityMapping_ImportMap
        {
            get { return this.GetRelatedEntities<ImportEntityMapping>("ImportEntityMapping_ImportMap", null); }
            set
            {
                this.OnPropertyChanging("ImportEntityMapping_ImportMap");
                this.SetRelatedEntities<ImportEntityMapping>("ImportEntityMapping_ImportMap", null, value);
                this.OnPropertyChanged("ImportEntityMapping_ImportMap");
            }
        }

        /// <summary>
        /// 1:N ImportMap_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ImportMap_AsyncOperations")]
        public System.Collections.Generic.IEnumerable<AsyncOperation> ImportMap_AsyncOperations
        {
            get { return this.GetRelatedEntities<AsyncOperation>("ImportMap_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("ImportMap_AsyncOperations");
                this.SetRelatedEntities<AsyncOperation>("ImportMap_AsyncOperations", null, value);
                this.OnPropertyChanged("ImportMap_AsyncOperations");
            }
        }

        /// <summary>
        /// 1:N ImportMap_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ImportMap_BulkDeleteFailures")]
        public System.Collections.Generic.IEnumerable<BulkDeleteFailure> ImportMap_BulkDeleteFailures
        {
            get { return this.GetRelatedEntities<BulkDeleteFailure>("ImportMap_BulkDeleteFailures", null); }
            set
            {
                this.OnPropertyChanging("ImportMap_BulkDeleteFailures");
                this.SetRelatedEntities<BulkDeleteFailure>("ImportMap_BulkDeleteFailures", null, value);
                this.OnPropertyChanged("ImportMap_BulkDeleteFailures");
            }
        }

        /// <summary>
        /// 1:N ImportMap_ImportFile
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ImportMap_ImportFile")]
        public System.Collections.Generic.IEnumerable<ImportFile> ImportMap_ImportFile
        {
            get { return this.GetRelatedEntities<ImportFile>("ImportMap_ImportFile", null); }
            set
            {
                this.OnPropertyChanging("ImportMap_ImportFile");
                this.SetRelatedEntities<ImportFile>("ImportMap_ImportFile", null, value);
                this.OnPropertyChanged("ImportMap_ImportFile");
            }
        }

        /// <summary>
        /// 1:N OwnerMapping_ImportMap
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("OwnerMapping_ImportMap")]
        public System.Collections.Generic.IEnumerable<OwnerMapping> OwnerMapping_ImportMap
        {
            get { return this.GetRelatedEntities<OwnerMapping>("OwnerMapping_ImportMap", null); }
            set
            {
                this.OnPropertyChanging("OwnerMapping_ImportMap");
                this.SetRelatedEntities<OwnerMapping>("OwnerMapping_ImportMap", null, value);
                this.OnPropertyChanged("OwnerMapping_ImportMap");
            }
        }

        /// <summary>
        /// 1:N TransformationMapping_ImportMap
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("TransformationMapping_ImportMap")]
        public System.Collections.Generic.IEnumerable<TransformationMapping> TransformationMapping_ImportMap
        {
            get { return this.GetRelatedEntities<TransformationMapping>("TransformationMapping_ImportMap", null); }
            set
            {
                this.OnPropertyChanging("TransformationMapping_ImportMap");
                this.SetRelatedEntities<TransformationMapping>("TransformationMapping_ImportMap", null, value);
                this.OnPropertyChanged("TransformationMapping_ImportMap");
            }
        }

        /// <summary>
        /// 1:N userentityinstancedata_importmap
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_importmap")]
        public System.Collections.Generic.IEnumerable<UserEntityInstanceData> userentityinstancedata_importmap
        {
            get { return this.GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_importmap", null); }
            set
            {
                this.OnPropertyChanging("userentityinstancedata_importmap");
                this.SetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_importmap", null, value);
                this.OnPropertyChanged("userentityinstancedata_importmap");
            }
        }

        /// <summary>
        /// N:1 BusinessUnit_ImportMaps
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("BusinessUnit_ImportMaps")]
        public BusinessUnit BusinessUnit_ImportMaps
        {
            get { return this.GetRelatedEntity<BusinessUnit>("BusinessUnit_ImportMaps", null); }
        }

        /// <summary>
        /// N:1 lk_importmap_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_importmap_createdonbehalfby")]
        public SystemUser lk_importmap_createdonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_importmap_createdonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_importmap_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_importmap_modifiedonbehalfby")]
        public SystemUser lk_importmap_modifiedonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_importmap_modifiedonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_importmapbase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_importmapbase_createdby")]
        public SystemUser lk_importmapbase_createdby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_importmapbase_createdby", null); }
        }

        /// <summary>
        /// N:1 lk_importmapbase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_importmapbase_modifiedby")]
        public SystemUser lk_importmapbase_modifiedby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_importmapbase_modifiedby", null); }
        }

        /// <summary>
        /// N:1 SystemUser_ImportMaps
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SystemUser_ImportMaps")]
        public SystemUser SystemUser_ImportMaps
        {
            get { return this.GetRelatedEntity<SystemUser>("SystemUser_ImportMaps", null); }
        }

        /// <summary>
        /// N:1 team_ImportMaps
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_ImportMaps")]
        public Team team_ImportMaps
        {
            get { return this.GetRelatedEntity<Team>("team_ImportMaps", null); }
        }
    }
}