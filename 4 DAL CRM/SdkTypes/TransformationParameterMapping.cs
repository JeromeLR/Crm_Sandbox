namespace __4_DAL_CRM
{
    /// <summary>
    /// In a data map, defines parameters for a transformation.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("transformationparametermapping")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class TransformationParameterMapping : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public TransformationParameterMapping() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "transformationparametermapping";

        public const int EntityTypeCode = 4427;

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
        /// Unique identifier of the user who created the parameter mapping.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby"); }
        }

        /// <summary>
        /// Date and time when the transformation parameter mapping was created.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
        public System.Nullable<System.DateTime> CreatedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who created the transformationparametermapping.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        /// Transformation data for transformation parameter
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("data")]
        public string Data
        {
            get { return this.GetAttributeValue<string>("data"); }
            set
            {
                this.OnPropertyChanging("Data");
                this.SetAttributeValue("data", value);
                this.OnPropertyChanged("Data");
            }
        }

        /// <summary>
        /// Data type of the transformation parameter.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("datatypecode")]
        public Microsoft.Xrm.Sdk.OptionSetValue DataTypeCode
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("datatypecode"); }
            set
            {
                this.OnPropertyChanging("DataTypeCode");
                this.SetAttributeValue("datatypecode", value);
                this.OnPropertyChanged("DataTypeCode");
            }
        }

        /// <summary>
        /// Unique identifier of the user who last modified the transformation parameter mapping.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby"); }
        }

        /// <summary>
        /// Date and time when the transformation parameter mapping was last modified.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
        public System.Nullable<System.DateTime> ModifiedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who last modified the transformationparametermapping.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        /// Index of the array if the input parameter is an array.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("parameterarrayindex")]
        public System.Nullable<int> ParameterArrayIndex
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("parameterarrayindex"); }
            set
            {
                this.OnPropertyChanging("ParameterArrayIndex");
                this.SetAttributeValue("parameterarrayindex", value);
                this.OnPropertyChanged("ParameterArrayIndex");
            }
        }

        /// <summary>
        /// Parameter sequence number.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("parametersequence")]
        public System.Nullable<int> ParameterSequence
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("parametersequence"); }
            set
            {
                this.OnPropertyChanging("ParameterSequence");
                this.SetAttributeValue("parametersequence", value);
                this.OnPropertyChanged("ParameterSequence");
            }
        }

        /// <summary>
        /// Type of transformation parameter.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("parametertypecode")]
        public Microsoft.Xrm.Sdk.OptionSetValue ParameterTypeCode
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("parametertypecode"); }
            set
            {
                this.OnPropertyChanging("ParameterTypeCode");
                this.SetAttributeValue("parametertypecode", value);
                this.OnPropertyChanged("ParameterTypeCode");
            }
        }

        /// <summary>
        /// Unique identifier of the transformation with which the parameter is associated.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transformationmappingid")]
        public Microsoft.Xrm.Sdk.EntityReference TransformationMappingId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("transformationmappingid"); }
            set
            {
                this.OnPropertyChanging("TransformationMappingId");
                this.SetAttributeValue("transformationmappingid", value);
                this.OnPropertyChanged("TransformationMappingId");
            }
        }

        /// <summary>
        /// Unique identifier of the transformation parameter mapping.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transformationparametermappingid")]
        public System.Nullable<System.Guid> TransformationParameterMappingId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("transformationparametermappingid"); }
            set
            {
                this.OnPropertyChanging("TransformationParameterMappingId");
                this.SetAttributeValue("transformationparametermappingid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("TransformationParameterMappingId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transformationparametermappingid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.TransformationParameterMappingId = value; }
        }

        /// <summary>
        /// 1:N LookUpMapping_TransformationParameterMapping
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("LookUpMapping_TransformationParameterMapping")]
        public System.Collections.Generic.IEnumerable<LookUpMapping> LookUpMapping_TransformationParameterMapping
        {
            get { return this.GetRelatedEntities<LookUpMapping>("LookUpMapping_TransformationParameterMapping", null); }
            set
            {
                this.OnPropertyChanging("LookUpMapping_TransformationParameterMapping");
                this.SetRelatedEntities<LookUpMapping>("LookUpMapping_TransformationParameterMapping", null, value);
                this.OnPropertyChanged("LookUpMapping_TransformationParameterMapping");
            }
        }

        /// <summary>
        /// 1:N userentityinstancedata_transformationparametermapping
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_transformationparametermapping")]
        public System.Collections.Generic.IEnumerable<UserEntityInstanceData> userentityinstancedata_transformationparametermapping
        {
            get { return this.GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_transformationparametermapping", null); }
            set
            {
                this.OnPropertyChanging("userentityinstancedata_transformationparametermapping");
                this.SetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_transformationparametermapping", null, value);
                this.OnPropertyChanged("userentityinstancedata_transformationparametermapping");
            }
        }

        /// <summary>
        /// N:1 lk_transformationparametermapping_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_transformationparametermapping_createdby")]
        public SystemUser lk_transformationparametermapping_createdby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_transformationparametermapping_createdby", null); }
        }

        /// <summary>
        /// N:1 lk_transformationparametermapping_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_transformationparametermapping_createdonbehalfby")]
        public SystemUser lk_transformationparametermapping_createdonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_transformationparametermapping_createdonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_transformationparametermapping_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_transformationparametermapping_modifiedby")]
        public SystemUser lk_transformationparametermapping_modifiedby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_transformationparametermapping_modifiedby", null); }
        }

        /// <summary>
        /// N:1 lk_transformationparametermapping_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_transformationparametermapping_modifiedonbehalfby")]
        public SystemUser lk_transformationparametermapping_modifiedonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_transformationparametermapping_modifiedonbehalfby", null); }
        }

        /// <summary>
        /// N:1 TransformationParameterMapping_TransformationMapping
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transformationmappingid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("TransformationParameterMapping_TransformationMapping")]
        public TransformationMapping TransformationParameterMapping_TransformationMapping
        {
            get { return this.GetRelatedEntity<TransformationMapping>("TransformationParameterMapping_TransformationMapping", null); }
            set
            {
                this.OnPropertyChanging("TransformationParameterMapping_TransformationMapping");
                this.SetRelatedEntity<TransformationMapping>("TransformationParameterMapping_TransformationMapping", null, value);
                this.OnPropertyChanged("TransformationParameterMapping_TransformationMapping");
            }
        }
    }
}