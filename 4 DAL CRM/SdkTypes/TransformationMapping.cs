namespace __4_DAL_CRM
{
    /// <summary>
    /// In a data map, maps the transformation of source attributes to Microsoft Dynamics CRM attributes.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("transformationmapping")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class TransformationMapping : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public TransformationMapping() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "transformationmapping";

        public const int EntityTypeCode = 4426;

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
        /// Unique identifier of the user who created the transformation mapping.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby"); }
        }

        /// <summary>
        /// Date and time when the transformation mapping was created.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
        public System.Nullable<System.DateTime> CreatedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who created the transformationmapping.
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
        /// Unique identifier of the user who last modified the mapping.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby"); }
        }

        /// <summary>
        /// Date and time when the transformation mapping was last modified.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
        public System.Nullable<System.DateTime> ModifiedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who last modified the transformationmapping.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        /// Information about whether the transformation mapping needs to be processed.
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
        /// Status of the transformation mapping.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
        public System.Nullable<TransformationMappingState> StateCode
        {
            get
            {
                Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
                if ((optionSet != null))
                {
                    return ((TransformationMappingState) (System.Enum.ToObject(typeof(TransformationMappingState), optionSet.Value)));
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// Reason for the status of the transformation mapping.
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
        /// Unique identifier of the transformation mapping.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transformationmappingid")]
        public System.Nullable<System.Guid> TransformationMappingId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("transformationmappingid"); }
            set
            {
                this.OnPropertyChanging("TransformationMappingId");
                this.SetAttributeValue("transformationmappingid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("TransformationMappingId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transformationmappingid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.TransformationMappingId = value; }
        }

        /// <summary>
        /// Type of transformation.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transformationtypename")]
        public string TransformationTypeName
        {
            get { return this.GetAttributeValue<string>("transformationtypename"); }
            set
            {
                this.OnPropertyChanging("TransformationTypeName");
                this.SetAttributeValue("transformationtypename", value);
                this.OnPropertyChanged("TransformationTypeName");
            }
        }

        /// <summary>
        /// 1:N TransformationParameterMapping_TransformationMapping
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("TransformationParameterMapping_TransformationMapping")]
        public System.Collections.Generic.IEnumerable<TransformationParameterMapping> TransformationParameterMapping_TransformationMapping
        {
            get { return this.GetRelatedEntities<TransformationParameterMapping>("TransformationParameterMapping_TransformationMapping", null); }
            set
            {
                this.OnPropertyChanging("TransformationParameterMapping_TransformationMapping");
                this.SetRelatedEntities<TransformationParameterMapping>("TransformationParameterMapping_TransformationMapping", null, value);
                this.OnPropertyChanged("TransformationParameterMapping_TransformationMapping");
            }
        }

        /// <summary>
        /// 1:N userentityinstancedata_transformationmapping
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_transformationmapping")]
        public System.Collections.Generic.IEnumerable<UserEntityInstanceData> userentityinstancedata_transformationmapping
        {
            get { return this.GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_transformationmapping", null); }
            set
            {
                this.OnPropertyChanging("userentityinstancedata_transformationmapping");
                this.SetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_transformationmapping", null, value);
                this.OnPropertyChanged("userentityinstancedata_transformationmapping");
            }
        }

        /// <summary>
        /// N:1 lk_transformationmapping_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_transformationmapping_createdby")]
        public SystemUser lk_transformationmapping_createdby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_transformationmapping_createdby", null); }
        }

        /// <summary>
        /// N:1 lk_transformationmapping_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_transformationmapping_createdonbehalfby")]
        public SystemUser lk_transformationmapping_createdonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_transformationmapping_createdonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_transformationmapping_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_transformationmapping_modifiedby")]
        public SystemUser lk_transformationmapping_modifiedby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_transformationmapping_modifiedby", null); }
        }

        /// <summary>
        /// N:1 lk_transformationmapping_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_transformationmapping_modifiedonbehalfby")]
        public SystemUser lk_transformationmapping_modifiedonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_transformationmapping_modifiedonbehalfby", null); }
        }

        /// <summary>
        /// N:1 TransformationMapping_ImportMap
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("importmapid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("TransformationMapping_ImportMap")]
        public ImportMap TransformationMapping_ImportMap
        {
            get { return this.GetRelatedEntity<ImportMap>("TransformationMapping_ImportMap", null); }
            set
            {
                this.OnPropertyChanging("TransformationMapping_ImportMap");
                this.SetRelatedEntity<ImportMap>("TransformationMapping_ImportMap", null, value);
                this.OnPropertyChanged("TransformationMapping_ImportMap");
            }
        }
    }
}