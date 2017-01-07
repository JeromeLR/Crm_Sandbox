namespace __4_DAL_CRM
{
    /// <summary>
    /// Mapping for columns in a data map.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("columnmapping")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class ColumnMapping : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public ColumnMapping() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "columnmapping";

        public const int EntityTypeCode = 4417;

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
        /// Unique identifier of the column mapping.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("columnmappingid")]
        public System.Nullable<System.Guid> ColumnMappingId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("columnmappingid"); }
            set
            {
                this.OnPropertyChanging("ColumnMappingId");
                this.SetAttributeValue("columnmappingid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("ColumnMappingId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("columnmappingid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.ColumnMappingId = value; }
        }

        /// <summary>
        /// Unique identifier of the user who created the column mapping.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby"); }
        }

        /// <summary>
        /// Date and time when the column mapping was created.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
        public System.Nullable<System.DateTime> CreatedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who created the columnmapping.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby"); }
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
        /// Unique identifier of the user who last modified the column mapping.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby"); }
        }

        /// <summary>
        /// Date and time when the column mapping was last modified.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
        public System.Nullable<System.DateTime> ModifiedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who last modified the columnmapping.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        /// Information about whether the column mapping needs to be processed.
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
        /// Name of the source attribute.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sourceattributename")]
        public string SourceAttributeName
        {
            get { return this.GetAttributeValue<string>("sourceattributename"); }
            set
            {
                this.OnPropertyChanging("SourceAttributeName");
                this.SetAttributeValue("sourceattributename", value);
                this.OnPropertyChanged("SourceAttributeName");
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
        /// Status of the column mapping.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
        public System.Nullable<ColumnMappingState> StateCode
        {
            get
            {
                Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
                if ((optionSet != null))
                {
                    return ((ColumnMappingState) (System.Enum.ToObject(typeof(ColumnMappingState), optionSet.Value)));
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// Reason for the status of the column mapping.
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
        /// Name of the Microsoft Dynamics CRM attribute.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("targetattributename")]
        public string TargetAttributeName
        {
            get { return this.GetAttributeValue<string>("targetattributename"); }
            set
            {
                this.OnPropertyChanging("TargetAttributeName");
                this.SetAttributeValue("targetattributename", value);
                this.OnPropertyChanged("TargetAttributeName");
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
        /// 1:N LookUpMapping_ColumnMapping
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("LookUpMapping_ColumnMapping")]
        public System.Collections.Generic.IEnumerable<LookUpMapping> LookUpMapping_ColumnMapping
        {
            get { return this.GetRelatedEntities<LookUpMapping>("LookUpMapping_ColumnMapping", null); }
            set
            {
                this.OnPropertyChanging("LookUpMapping_ColumnMapping");
                this.SetRelatedEntities<LookUpMapping>("LookUpMapping_ColumnMapping", null, value);
                this.OnPropertyChanged("LookUpMapping_ColumnMapping");
            }
        }

        /// <summary>
        /// 1:N PickListMapping_ColumnMapping
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("PickListMapping_ColumnMapping")]
        public System.Collections.Generic.IEnumerable<PickListMapping> PickListMapping_ColumnMapping
        {
            get { return this.GetRelatedEntities<PickListMapping>("PickListMapping_ColumnMapping", null); }
            set
            {
                this.OnPropertyChanging("PickListMapping_ColumnMapping");
                this.SetRelatedEntities<PickListMapping>("PickListMapping_ColumnMapping", null, value);
                this.OnPropertyChanged("PickListMapping_ColumnMapping");
            }
        }

        /// <summary>
        /// 1:N userentityinstancedata_columnmapping
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_columnmapping")]
        public System.Collections.Generic.IEnumerable<UserEntityInstanceData> userentityinstancedata_columnmapping
        {
            get { return this.GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_columnmapping", null); }
            set
            {
                this.OnPropertyChanging("userentityinstancedata_columnmapping");
                this.SetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_columnmapping", null, value);
                this.OnPropertyChanged("userentityinstancedata_columnmapping");
            }
        }

        /// <summary>
        /// N:1 ColumnMapping_ImportMap
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("importmapid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ColumnMapping_ImportMap")]
        public ImportMap ColumnMapping_ImportMap
        {
            get { return this.GetRelatedEntity<ImportMap>("ColumnMapping_ImportMap", null); }
            set
            {
                this.OnPropertyChanging("ColumnMapping_ImportMap");
                this.SetRelatedEntity<ImportMap>("ColumnMapping_ImportMap", null, value);
                this.OnPropertyChanged("ColumnMapping_ImportMap");
            }
        }

        /// <summary>
        /// N:1 lk_columnmapping_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_columnmapping_createdby")]
        public SystemUser lk_columnmapping_createdby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_columnmapping_createdby", null); }
        }

        /// <summary>
        /// N:1 lk_columnmapping_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_columnmapping_createdonbehalfby")]
        public SystemUser lk_columnmapping_createdonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_columnmapping_createdonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_columnmapping_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_columnmapping_modifiedby")]
        public SystemUser lk_columnmapping_modifiedby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_columnmapping_modifiedby", null); }
        }

        /// <summary>
        /// N:1 lk_columnmapping_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_columnmapping_modifiedonbehalfby")]
        public SystemUser lk_columnmapping_modifiedonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_columnmapping_modifiedonbehalfby", null); }
        }
    }
}