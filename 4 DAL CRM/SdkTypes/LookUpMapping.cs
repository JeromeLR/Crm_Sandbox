namespace __4_DAL_CRM
{
    /// <summary>
    /// In a data map, maps a lookup attribute in a source file to Microsoft Dynamics CRM.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("lookupmapping")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class LookUpMapping : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public LookUpMapping() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "lookupmapping";

        public const int EntityTypeCode = 4419;

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
        /// Unique identifier of the column mapping with which this lookup mapping is associated.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("columnmappingid")]
        public Microsoft.Xrm.Sdk.EntityReference ColumnMappingId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("columnmappingid"); }
            set
            {
                this.OnPropertyChanging("ColumnMappingId");
                this.SetAttributeValue("columnmappingid", value);
                this.OnPropertyChanged("ColumnMappingId");
            }
        }

        /// <summary>
        /// Unique identifier of the user who created the lookup mapping.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby"); }
        }

        /// <summary>
        /// Date and time when the lookup mapping was created.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
        public System.Nullable<System.DateTime> CreatedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who created the lookupmapping.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        /// Name of the field with which the lookup is associated.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("lookupattributename")]
        public string LookUpAttributeName
        {
            get { return this.GetAttributeValue<string>("lookupattributename"); }
            set
            {
                this.OnPropertyChanging("LookUpAttributeName");
                this.SetAttributeValue("lookupattributename", value);
                this.OnPropertyChanged("LookUpAttributeName");
            }
        }

        /// <summary>
        /// Name of the entity with which the lookup is associated.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("lookupentityname")]
        public string LookUpEntityName
        {
            get { return this.GetAttributeValue<string>("lookupentityname"); }
            set
            {
                this.OnPropertyChanging("LookUpEntityName");
                this.SetAttributeValue("lookupentityname", value);
                this.OnPropertyChanged("LookUpEntityName");
            }
        }

        /// <summary>
        /// Unique identifier of the lookup mapping.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("lookupmappingid")]
        public System.Nullable<System.Guid> LookUpMappingId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("lookupmappingid"); }
            set
            {
                this.OnPropertyChanging("LookUpMappingId");
                this.SetAttributeValue("lookupmappingid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("LookUpMappingId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("lookupmappingid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.LookUpMappingId = value; }
        }

        /// <summary>
        /// Lookup source code for lookup mapping.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("lookupsourcecode")]
        public Microsoft.Xrm.Sdk.OptionSetValue LookUpSourceCode
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("lookupsourcecode"); }
            set
            {
                this.OnPropertyChanging("LookUpSourceCode");
                this.SetAttributeValue("lookupsourcecode", value);
                this.OnPropertyChanged("LookUpSourceCode");
            }
        }

        /// <summary>
        /// Unique identifier of the user who last modified the lookup mapping.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby"); }
        }

        /// <summary>
        /// Date and time when the lookup mapping was last modified.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
        public System.Nullable<System.DateTime> ModifiedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who last modified the lookupmapping.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        /// Information about whether the lookup mapping has to be processed.
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
        /// Status of the lookup mapping.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
        public System.Nullable<LookUpMappingState> StateCode
        {
            get
            {
                Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
                if ((optionSet != null))
                {
                    return ((LookUpMappingState) (System.Enum.ToObject(typeof(LookUpMappingState), optionSet.Value)));
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// Reason for the status of the lookup mapping.
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
        /// Unique identifier of the transformation parameter mapping with which this lookup mapping is associated.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transformationparametermappingid")]
        public Microsoft.Xrm.Sdk.EntityReference TransformationParameterMappingId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("transformationparametermappingid"); }
            set
            {
                this.OnPropertyChanging("TransformationParameterMappingId");
                this.SetAttributeValue("transformationparametermappingid", value);
                this.OnPropertyChanged("TransformationParameterMappingId");
            }
        }

        /// <summary>
        /// 1:N userentityinstancedata_lookupmapping
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_lookupmapping")]
        public System.Collections.Generic.IEnumerable<UserEntityInstanceData> userentityinstancedata_lookupmapping
        {
            get { return this.GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_lookupmapping", null); }
            set
            {
                this.OnPropertyChanging("userentityinstancedata_lookupmapping");
                this.SetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_lookupmapping", null, value);
                this.OnPropertyChanged("userentityinstancedata_lookupmapping");
            }
        }

        /// <summary>
        /// N:1 lk_lookupmapping_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_lookupmapping_createdby")]
        public SystemUser lk_lookupmapping_createdby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_lookupmapping_createdby", null); }
        }

        /// <summary>
        /// N:1 lk_lookupmapping_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_lookupmapping_createdonbehalfby")]
        public SystemUser lk_lookupmapping_createdonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_lookupmapping_createdonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_lookupmapping_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_lookupmapping_modifiedby")]
        public SystemUser lk_lookupmapping_modifiedby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_lookupmapping_modifiedby", null); }
        }

        /// <summary>
        /// N:1 lk_lookupmapping_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_lookupmapping_modifiedonbehalfby")]
        public SystemUser lk_lookupmapping_modifiedonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_lookupmapping_modifiedonbehalfby", null); }
        }

        /// <summary>
        /// N:1 LookUpMapping_ColumnMapping
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("columnmappingid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("LookUpMapping_ColumnMapping")]
        public ColumnMapping LookUpMapping_ColumnMapping
        {
            get { return this.GetRelatedEntity<ColumnMapping>("LookUpMapping_ColumnMapping", null); }
            set
            {
                this.OnPropertyChanging("LookUpMapping_ColumnMapping");
                this.SetRelatedEntity<ColumnMapping>("LookUpMapping_ColumnMapping", null, value);
                this.OnPropertyChanged("LookUpMapping_ColumnMapping");
            }
        }

        /// <summary>
        /// N:1 LookUpMapping_TransformationParameterMapping
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transformationparametermappingid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("LookUpMapping_TransformationParameterMapping")]
        public TransformationParameterMapping LookUpMapping_TransformationParameterMapping
        {
            get { return this.GetRelatedEntity<TransformationParameterMapping>("LookUpMapping_TransformationParameterMapping", null); }
            set
            {
                this.OnPropertyChanging("LookUpMapping_TransformationParameterMapping");
                this.SetRelatedEntity<TransformationParameterMapping>("LookUpMapping_TransformationParameterMapping", null, value);
                this.OnPropertyChanged("LookUpMapping_TransformationParameterMapping");
            }
        }
    }
}