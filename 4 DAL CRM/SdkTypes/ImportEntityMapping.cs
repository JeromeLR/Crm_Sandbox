namespace __4_DAL_CRM
{
    /// <summary>
    /// Mapping for entities in a data map.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("importentitymapping")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class ImportEntityMapping : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public ImportEntityMapping() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "importentitymapping";

        public const int EntityTypeCode = 4428;

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
        /// Unique identifier of the user who created the import entity mapping.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby"); }
        }

        /// <summary>
        /// Date and time when the import entity mapping was created.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
        public System.Nullable<System.DateTime> CreatedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who created the importentitymapping.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        /// Information about whether the entity needs to be processed to find and delete duplicate records.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("dedupe")]
        public Microsoft.Xrm.Sdk.OptionSetValue DeDupe
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("dedupe"); }
            set
            {
                this.OnPropertyChanging("DeDupe");
                this.SetAttributeValue("dedupe", value);
                this.OnPropertyChanged("DeDupe");
            }
        }

        /// <summary>
        /// Unique identifier of the import entity mapping.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("importentitymappingid")]
        public System.Nullable<System.Guid> ImportEntityMappingId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("importentitymappingid"); }
            set
            {
                this.OnPropertyChanging("ImportEntityMappingId");
                this.SetAttributeValue("importentitymappingid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("ImportEntityMappingId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("importentitymappingid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.ImportEntityMappingId = value; }
        }

        /// <summary>
        /// Unique identifier of the associated data map.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("importmapid")]
        public Microsoft.Xrm.Sdk.EntityReference ImportMapId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("importmapid"); }
            set
            {
                this.OnPropertyChanging("ImportMapId");
                this.SetAttributeValue("importmapid", value);
                this.OnPropertyChanged("ImportMapId");
            }
        }

        /// <summary>
        /// Unique identifier of the user who last modified the import entity mapping.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby"); }
        }

        /// <summary>
        /// Date and time when the import entity mapping was last modified.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
        public System.Nullable<System.DateTime> ModifiedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who last modified the importentitymapping.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        /// Information about whether the import entity mapping needs to be processed.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("processcode")]
        public Microsoft.Xrm.Sdk.OptionSetValue ProcessCode
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("processcode"); }
            set
            {
                this.OnPropertyChanging("ProcessCode");
                this.SetAttributeValue("processcode", value);
                this.OnPropertyChanged("ProcessCode");
            }
        }

        /// <summary>
        /// Name of the source entity.
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
        /// Status of the import entity mapping.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
        public System.Nullable<ImportEntityMappingState> StateCode
        {
            get
            {
                Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
                if ((optionSet != null))
                {
                    return ((ImportEntityMappingState) (System.Enum.ToObject(typeof(ImportEntityMappingState), optionSet.Value)));
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// Reason for the status of the import entity mapping.
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
        /// 1:N userentityinstancedata_importentitymapping
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_importentitymapping")]
        public System.Collections.Generic.IEnumerable<UserEntityInstanceData> userentityinstancedata_importentitymapping
        {
            get { return this.GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_importentitymapping", null); }
            set
            {
                this.OnPropertyChanging("userentityinstancedata_importentitymapping");
                this.SetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_importentitymapping", null, value);
                this.OnPropertyChanged("userentityinstancedata_importentitymapping");
            }
        }

        /// <summary>
        /// N:1 ImportEntityMapping_ImportMap
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("importmapid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ImportEntityMapping_ImportMap")]
        public ImportMap ImportEntityMapping_ImportMap
        {
            get { return this.GetRelatedEntity<ImportMap>("ImportEntityMapping_ImportMap", null); }
            set
            {
                this.OnPropertyChanging("ImportEntityMapping_ImportMap");
                this.SetRelatedEntity<ImportMap>("ImportEntityMapping_ImportMap", null, value);
                this.OnPropertyChanged("ImportEntityMapping_ImportMap");
            }
        }

        /// <summary>
        /// N:1 lk_importentitymapping_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_importentitymapping_createdby")]
        public SystemUser lk_importentitymapping_createdby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_importentitymapping_createdby", null); }
        }

        /// <summary>
        /// N:1 lk_importentitymapping_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_importentitymapping_createdonbehalfby")]
        public SystemUser lk_importentitymapping_createdonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_importentitymapping_createdonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_importentitymapping_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_importentitymapping_modifiedby")]
        public SystemUser lk_importentitymapping_modifiedby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_importentitymapping_modifiedby", null); }
        }

        /// <summary>
        /// N:1 lk_importentitymapping_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_importentitymapping_modifiedonbehalfby")]
        public SystemUser lk_importentitymapping_modifiedonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_importentitymapping_modifiedonbehalfby", null); }
        }
    }
}