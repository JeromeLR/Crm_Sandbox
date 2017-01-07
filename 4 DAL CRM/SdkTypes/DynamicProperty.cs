namespace __4_DAL_CRM
{
    /// <summary>
    /// Information about a product property.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("dynamicproperty")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class DynamicProperty : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public DynamicProperty() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "dynamicproperty";

        public const int EntityTypeCode = 1048;

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
        /// Shows the property in the product family that this property is being inherited from.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("basedynamicpropertyid")]
        public Microsoft.Xrm.Sdk.EntityReference BaseDynamicPropertyId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("basedynamicpropertyid"); }
            set
            {
                this.OnPropertyChanging("BaseDynamicPropertyId");
                this.SetAttributeValue("basedynamicpropertyid", value);
                this.OnPropertyChanged("BaseDynamicPropertyId");
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
        /// Shows the date and time when the record was created.
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
        /// Select the data type of the property.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("datatype")]
        public Microsoft.Xrm.Sdk.OptionSetValue DataType
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("datatype"); }
            set
            {
                this.OnPropertyChanging("DataType");
                this.SetAttributeValue("datatype", value);
                this.OnPropertyChanged("DataType");
            }
        }

        /// <summary>
        /// Shows the default value of the property for a decimal data type.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("defaultvaluedecimal")]
        public System.Nullable<decimal> DefaultValueDecimal
        {
            get { return this.GetAttributeValue<System.Nullable<decimal>>("defaultvaluedecimal"); }
            set
            {
                this.OnPropertyChanging("DefaultValueDecimal");
                this.SetAttributeValue("defaultvaluedecimal", value);
                this.OnPropertyChanged("DefaultValueDecimal");
            }
        }

        /// <summary>
        /// Shows the default value of the property for a double data type.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("defaultvaluedouble")]
        public System.Nullable<double> DefaultValueDouble
        {
            get { return this.GetAttributeValue<System.Nullable<double>>("defaultvaluedouble"); }
            set
            {
                this.OnPropertyChanging("DefaultValueDouble");
                this.SetAttributeValue("defaultvaluedouble", value);
                this.OnPropertyChanged("DefaultValueDouble");
            }
        }

        /// <summary>
        /// Shows the default value of the property for a whole number data type.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("defaultvalueinteger")]
        public System.Nullable<int> DefaultValueInteger
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("defaultvalueinteger"); }
            set
            {
                this.OnPropertyChanging("DefaultValueInteger");
                this.SetAttributeValue("defaultvalueinteger", value);
                this.OnPropertyChanged("DefaultValueInteger");
            }
        }

        /// <summary>
        /// Shows the default value of the property.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("defaultvalueoptionset")]
        public Microsoft.Xrm.Sdk.EntityReference DefaultValueOptionSet
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("defaultvalueoptionset"); }
            set
            {
                this.OnPropertyChanging("DefaultValueOptionSet");
                this.SetAttributeValue("defaultvalueoptionset", value);
                this.OnPropertyChanged("DefaultValueOptionSet");
            }
        }

        /// <summary>
        /// Shows the default value of the property for a string data type.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("defaultvaluestring")]
        public string DefaultValueString
        {
            get { return this.GetAttributeValue<string>("defaultvaluestring"); }
            set
            {
                this.OnPropertyChanging("DefaultValueString");
                this.SetAttributeValue("defaultvaluestring", value);
                this.OnPropertyChanged("DefaultValueString");
            }
        }

        /// <summary>
        /// Type a description for the property.
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
        /// Internal Use Only
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("dmtimportstate")]
        public System.Nullable<int> DMTImportState
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("dmtimportstate"); }
            set
            {
                this.OnPropertyChanging("DMTImportState");
                this.SetAttributeValue("dmtimportstate", value);
                this.OnPropertyChanged("DMTImportState");
            }
        }

        /// <summary>
        /// Shows the unique identifier of the property.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("dynamicpropertyid")]
        public System.Nullable<System.Guid> DynamicPropertyId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("dynamicpropertyid"); }
            set
            {
                this.OnPropertyChanging("DynamicPropertyId");
                this.SetAttributeValue("dynamicpropertyid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("DynamicPropertyId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("dynamicpropertyid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.DynamicPropertyId = value; }
        }

        /// <summary>
        /// Unique identifier of the data import or data migration that created this property.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("importsequencenumber")]
        public System.Nullable<int> ImportSequenceNumber
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("importsequencenumber"); }
            set
            {
                this.OnPropertyChanging("ImportSequenceNumber");
                this.SetAttributeValue("importsequencenumber", value);
                this.OnPropertyChanged("ImportSequenceNumber");
            }
        }

        /// <summary>
        /// Defines whether the attribute is hidden or shown.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ishidden")]
        public System.Nullable<bool> IsHidden
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("ishidden"); }
            set
            {
                this.OnPropertyChanging("IsHidden");
                this.SetAttributeValue("ishidden", value);
                this.OnPropertyChanged("IsHidden");
            }
        }

        /// <summary>
        /// Defines whether the attribute is read-only or if it can be edited.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isreadonly")]
        public System.Nullable<bool> IsReadOnly
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("isreadonly"); }
            set
            {
                this.OnPropertyChanging("IsReadOnly");
                this.SetAttributeValue("isreadonly", value);
                this.OnPropertyChanged("IsReadOnly");
            }
        }

        /// <summary>
        /// Defines whether the attribute is mandatory.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isrequired")]
        public System.Nullable<bool> IsRequired
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("isrequired"); }
            set
            {
                this.OnPropertyChanging("IsRequired");
                this.SetAttributeValue("isrequired", value);
                this.OnPropertyChanged("IsRequired");
            }
        }

        /// <summary>
        /// Shows the maximum allowed length of the property for a string data type.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("maxlengthstring")]
        public System.Nullable<int> MaxLengthString
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("maxlengthstring"); }
            set
            {
                this.OnPropertyChanging("MaxLengthString");
                this.SetAttributeValue("maxlengthstring", value);
                this.OnPropertyChanged("MaxLengthString");
            }
        }

        /// <summary>
        /// Shows the maximum allowed value of the property for a decimal data type.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("maxvaluedecimal")]
        public System.Nullable<decimal> MaxValueDecimal
        {
            get { return this.GetAttributeValue<System.Nullable<decimal>>("maxvaluedecimal"); }
            set
            {
                this.OnPropertyChanging("MaxValueDecimal");
                this.SetAttributeValue("maxvaluedecimal", value);
                this.OnPropertyChanged("MaxValueDecimal");
            }
        }

        /// <summary>
        /// Shows the maximum allowed value of the property for a double data type.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("maxvaluedouble")]
        public System.Nullable<double> MaxValueDouble
        {
            get { return this.GetAttributeValue<System.Nullable<double>>("maxvaluedouble"); }
            set
            {
                this.OnPropertyChanging("MaxValueDouble");
                this.SetAttributeValue("maxvaluedouble", value);
                this.OnPropertyChanged("MaxValueDouble");
            }
        }

        /// <summary>
        /// Shows the maximum allowed value of the property for a whole number data type.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("maxvalueinteger")]
        public System.Nullable<int> MaxValueInteger
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("maxvalueinteger"); }
            set
            {
                this.OnPropertyChanging("MaxValueInteger");
                this.SetAttributeValue("maxvalueinteger", value);
                this.OnPropertyChanged("MaxValueInteger");
            }
        }

        /// <summary>
        /// Shows the minimum allowed value of the property for a decimal data type.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("minvaluedecimal")]
        public System.Nullable<decimal> MinValueDecimal
        {
            get { return this.GetAttributeValue<System.Nullable<decimal>>("minvaluedecimal"); }
            set
            {
                this.OnPropertyChanging("MinValueDecimal");
                this.SetAttributeValue("minvaluedecimal", value);
                this.OnPropertyChanged("MinValueDecimal");
            }
        }

        /// <summary>
        /// Shows the minimum allowed value of the property for a double data type.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("minvaluedouble")]
        public System.Nullable<double> MinValueDouble
        {
            get { return this.GetAttributeValue<System.Nullable<double>>("minvaluedouble"); }
            set
            {
                this.OnPropertyChanging("MinValueDouble");
                this.SetAttributeValue("minvaluedouble", value);
                this.OnPropertyChanged("MinValueDouble");
            }
        }

        /// <summary>
        /// Shows the minimum allowed value of the property for a whole number data type.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("minvalueinteger")]
        public System.Nullable<int> MinValueInteger
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("minvalueinteger"); }
            set
            {
                this.OnPropertyChanging("MinValueInteger");
                this.SetAttributeValue("minvalueinteger", value);
                this.OnPropertyChanged("MinValueInteger");
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
        /// Shows the date and time when the record was last updated.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
        public System.Nullable<System.DateTime> ModifiedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon"); }
        }

        /// <summary>
        /// Shows who created the record on behalf of another user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        /// Type the name of the property.
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
        /// Unique identifier of the organization associated with the property.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
        public Microsoft.Xrm.Sdk.EntityReference OrganizationId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("organizationid"); }
        }

        /// <summary>
        /// Date and time that the attribute was migrated.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("overriddencreatedon")]
        public System.Nullable<System.DateTime> OverriddenCreatedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("overriddencreatedon"); }
            set
            {
                this.OnPropertyChanging("OverriddenCreatedOn");
                this.SetAttributeValue("overriddencreatedon", value);
                this.OnPropertyChanged("OverriddenCreatedOn");
            }
        }

        /// <summary>
        /// Shows the related overwritten property.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("overwrittendynamicpropertyid")]
        public System.Nullable<System.Guid> OverwrittenDynamicPropertyId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("overwrittendynamicpropertyid"); }
            set
            {
                this.OnPropertyChanging("OverwrittenDynamicPropertyId");
                this.SetAttributeValue("overwrittendynamicpropertyid", value);
                this.OnPropertyChanged("OverwrittenDynamicPropertyId");
            }
        }

        /// <summary>
        /// Shows the allowed precision of the property for a whole number data type.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("precision")]
        public System.Nullable<int> Precision
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("precision"); }
            set
            {
                this.OnPropertyChanging("Precision");
                this.SetAttributeValue("precision", value);
                this.OnPropertyChanged("Precision");
            }
        }

        /// <summary>
        /// Choose the product that the property is associated with.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        public Microsoft.Xrm.Sdk.EntityReference RegardingObjectId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("regardingobjectid"); }
            set
            {
                this.OnPropertyChanging("RegardingObjectId");
                this.SetAttributeValue("regardingobjectid", value);
                this.OnPropertyChanged("RegardingObjectId");
            }
        }

        /// <summary>
        /// Shows the root property that this property is derived from.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rootdynamicpropertyid")]
        public System.Nullable<System.Guid> RootDynamicPropertyId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("rootdynamicpropertyid"); }
            set
            {
                this.OnPropertyChanging("RootDynamicPropertyId");
                this.SetAttributeValue("rootdynamicpropertyid", value);
                this.OnPropertyChanged("RootDynamicPropertyId");
            }
        }

        /// <summary>
        /// Shows the state of the property.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
        public System.Nullable<DynamicPropertyState> statecode
        {
            get
            {
                Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
                if ((optionSet != null))
                {
                    return ((DynamicPropertyState) (System.Enum.ToObject(typeof(DynamicPropertyState), optionSet.Value)));
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.OnPropertyChanging("statecode");
                if ((value == null))
                {
                    this.SetAttributeValue("statecode", null);
                }
                else
                {
                    this.SetAttributeValue("statecode", new Microsoft.Xrm.Sdk.OptionSetValue(((int) (value))));
                }
                this.OnPropertyChanged("statecode");
            }
        }

        /// <summary>
        /// Shows whether the property is active or inactive.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statuscode")]
        public Microsoft.Xrm.Sdk.OptionSetValue statuscode
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statuscode"); }
            set
            {
                this.OnPropertyChanging("statuscode");
                this.SetAttributeValue("statuscode", value);
                this.OnPropertyChanged("statuscode");
            }
        }

        /// <summary>
        /// Version number of the property.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
        public System.Nullable<long> VersionNumber
        {
            get { return this.GetAttributeValue<System.Nullable<long>>("versionnumber"); }
        }

        /// <summary>
        /// 1:N dynamicproperty_base_dynamicproperty
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("dynamicproperty_base_dynamicproperty", Microsoft.Xrm.Sdk.EntityRole.Referenced)]
        public System.Collections.Generic.IEnumerable<DynamicProperty> Referenceddynamicproperty_base_dynamicproperty
        {
            get { return this.GetRelatedEntities<DynamicProperty>("dynamicproperty_base_dynamicproperty", Microsoft.Xrm.Sdk.EntityRole.Referenced); }
            set
            {
                this.OnPropertyChanging("Referenceddynamicproperty_base_dynamicproperty");
                this.SetRelatedEntities<DynamicProperty>("dynamicproperty_base_dynamicproperty", Microsoft.Xrm.Sdk.EntityRole.Referenced, value);
                this.OnPropertyChanged("Referenceddynamicproperty_base_dynamicproperty");
            }
        }

        /// <summary>
        /// 1:N Dynamicproperty_DynamicPropertyAssociation
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Dynamicproperty_DynamicPropertyAssociation")]
        public System.Collections.Generic.IEnumerable<DynamicPropertyAssociation> Dynamicproperty_DynamicPropertyAssociation
        {
            get { return this.GetRelatedEntities<DynamicPropertyAssociation>("Dynamicproperty_DynamicPropertyAssociation", null); }
            set
            {
                this.OnPropertyChanging("Dynamicproperty_DynamicPropertyAssociation");
                this.SetRelatedEntities<DynamicPropertyAssociation>("Dynamicproperty_DynamicPropertyAssociation", null, value);
                this.OnPropertyChanged("Dynamicproperty_DynamicPropertyAssociation");
            }
        }

        /// <summary>
        /// 1:N DynamicProperty_DynamicPropertyInstance
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("DynamicProperty_DynamicPropertyInstance")]
        public System.Collections.Generic.IEnumerable<DynamicPropertyInstance> DynamicProperty_DynamicPropertyInstance
        {
            get { return this.GetRelatedEntities<DynamicPropertyInstance>("DynamicProperty_DynamicPropertyInstance", null); }
            set
            {
                this.OnPropertyChanging("DynamicProperty_DynamicPropertyInstance");
                this.SetRelatedEntities<DynamicPropertyInstance>("DynamicProperty_DynamicPropertyInstance", null, value);
                this.OnPropertyChanged("DynamicProperty_DynamicPropertyInstance");
            }
        }

        /// <summary>
        /// 1:N DynamicProperty_DynamicPropertyOptionSetItem
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("DynamicProperty_DynamicPropertyOptionSetItem")]
        public System.Collections.Generic.IEnumerable<DynamicPropertyOptionSetItem> DynamicProperty_DynamicPropertyOptionSetItem
        {
            get { return this.GetRelatedEntities<DynamicPropertyOptionSetItem>("DynamicProperty_DynamicPropertyOptionSetItem", null); }
            set
            {
                this.OnPropertyChanging("DynamicProperty_DynamicPropertyOptionSetItem");
                this.SetRelatedEntities<DynamicPropertyOptionSetItem>("DynamicProperty_DynamicPropertyOptionSetItem", null, value);
                this.OnPropertyChanged("DynamicProperty_DynamicPropertyOptionSetItem");
            }
        }

        /// <summary>
        /// N:1 DefaultValueOptionSet_DynamicProperty
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("defaultvalueoptionset")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("DefaultValueOptionSet_DynamicProperty")]
        public DynamicPropertyOptionSetItem DefaultValueOptionSet_DynamicProperty
        {
            get { return this.GetRelatedEntity<DynamicPropertyOptionSetItem>("DefaultValueOptionSet_DynamicProperty", null); }
            set
            {
                this.OnPropertyChanging("DefaultValueOptionSet_DynamicProperty");
                this.SetRelatedEntity<DynamicPropertyOptionSetItem>("DefaultValueOptionSet_DynamicProperty", null, value);
                this.OnPropertyChanged("DefaultValueOptionSet_DynamicProperty");
            }
        }

        /// <summary>
        /// N:1 dynamicproperty_base_dynamicproperty
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("basedynamicpropertyid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("dynamicproperty_base_dynamicproperty", Microsoft.Xrm.Sdk.EntityRole.Referencing)]
        public DynamicProperty Referencingdynamicproperty_base_dynamicproperty
        {
            get { return this.GetRelatedEntity<DynamicProperty>("dynamicproperty_base_dynamicproperty", Microsoft.Xrm.Sdk.EntityRole.Referencing); }
            set
            {
                this.OnPropertyChanging("Referencingdynamicproperty_base_dynamicproperty");
                this.SetRelatedEntity<DynamicProperty>("dynamicproperty_base_dynamicproperty", Microsoft.Xrm.Sdk.EntityRole.Referencing, value);
                this.OnPropertyChanged("Referencingdynamicproperty_base_dynamicproperty");
            }
        }

        /// <summary>
        /// N:1 dynamicproperty_organization
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("dynamicproperty_organization")]
        public Organization dynamicproperty_organization
        {
            get { return this.GetRelatedEntity<Organization>("dynamicproperty_organization", null); }
        }

        /// <summary>
        /// N:1 lk_DynamicProperty_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_DynamicProperty_createdby")]
        public SystemUser lk_DynamicProperty_createdby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_DynamicProperty_createdby", null); }
        }

        /// <summary>
        /// N:1 lk_DynamicProperty_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_DynamicProperty_createdonbehalfby")]
        public SystemUser lk_DynamicProperty_createdonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_DynamicProperty_createdonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_DynamicProperty_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_DynamicProperty_modifiedby")]
        public SystemUser lk_DynamicProperty_modifiedby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_DynamicProperty_modifiedby", null); }
        }

        /// <summary>
        /// N:1 lk_DynamicProperty_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_DynamicProperty_modifiedonbehalfby")]
        public SystemUser lk_DynamicProperty_modifiedonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_DynamicProperty_modifiedonbehalfby", null); }
        }

        /// <summary>
        /// N:1 Product_DynamicProperty
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Product_DynamicProperty")]
        public Product Product_DynamicProperty
        {
            get { return this.GetRelatedEntity<Product>("Product_DynamicProperty", null); }
            set
            {
                this.OnPropertyChanging("Product_DynamicProperty");
                this.SetRelatedEntity<Product>("Product_DynamicProperty", null, value);
                this.OnPropertyChanged("Product_DynamicProperty");
            }
        }

        /// <summary>
        /// N:1 ProductAssociation_DynamicProperty
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ProductAssociation_DynamicProperty")]
        public ProductAssociation ProductAssociation_DynamicProperty
        {
            get { return this.GetRelatedEntity<ProductAssociation>("ProductAssociation_DynamicProperty", null); }
            set
            {
                this.OnPropertyChanging("ProductAssociation_DynamicProperty");
                this.SetRelatedEntity<ProductAssociation>("ProductAssociation_DynamicProperty", null, value);
                this.OnPropertyChanged("ProductAssociation_DynamicProperty");
            }
        }
    }
}