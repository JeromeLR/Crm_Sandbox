namespace __4_DAL_CRM
{
    /// <summary>
    /// In a data map, maps list values from the source file to Microsoft Dynamics CRM.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("picklistmapping")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class PickListMapping : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public PickListMapping() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "picklistmapping";

        public const int EntityTypeCode = 4418;

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
        /// Unique identifier of the column mapping with which this list value mapping is associated.
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
        /// Unique identifier of the user who created the list value mapping.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby"); }
        }

        /// <summary>
        /// Date and time when the list value mapping was created.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
        public System.Nullable<System.DateTime> CreatedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who created the picklistmapping.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        /// Unique identifier of the user who last modified the list value mapping.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby"); }
        }

        /// <summary>
        /// Date and time when the list value mapping was last modified.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
        public System.Nullable<System.DateTime> ModifiedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who last modified the picklistmapping.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        /// Unique identifier of the picklist mapping.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("picklistmappingid")]
        public System.Nullable<System.Guid> PickListMappingId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("picklistmappingid"); }
            set
            {
                this.OnPropertyChanging("PickListMappingId");
                this.SetAttributeValue("picklistmappingid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("PickListMappingId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("picklistmappingid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.PickListMappingId = value; }
        }

        /// <summary>
        /// Information about whether the list value mapping needs to be processed.
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
        /// Source value to be replaced.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sourcevalue")]
        public string SourceValue
        {
            get { return this.GetAttributeValue<string>("sourcevalue"); }
            set
            {
                this.OnPropertyChanging("SourceValue");
                this.SetAttributeValue("sourcevalue", value);
                this.OnPropertyChanged("SourceValue");
            }
        }

        /// <summary>
        /// Status of the picklist mapping.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
        public System.Nullable<PickListMappingState> StateCode
        {
            get
            {
                Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
                if ((optionSet != null))
                {
                    return ((PickListMappingState) (System.Enum.ToObject(typeof(PickListMappingState), optionSet.Value)));
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// Reason for the status of the picklist mapping.
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
        /// Microsoft Dynamics CRM list value with which to replace the source value.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("targetvalue")]
        public System.Nullable<int> TargetValue
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("targetvalue"); }
            set
            {
                this.OnPropertyChanging("TargetValue");
                this.SetAttributeValue("targetvalue", value);
                this.OnPropertyChanged("TargetValue");
            }
        }

        /// <summary>
        /// 1:N userentityinstancedata_picklistmapping
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_picklistmapping")]
        public System.Collections.Generic.IEnumerable<UserEntityInstanceData> userentityinstancedata_picklistmapping
        {
            get { return this.GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_picklistmapping", null); }
            set
            {
                this.OnPropertyChanging("userentityinstancedata_picklistmapping");
                this.SetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_picklistmapping", null, value);
                this.OnPropertyChanged("userentityinstancedata_picklistmapping");
            }
        }

        /// <summary>
        /// N:1 lk_picklistmapping_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_picklistmapping_createdby")]
        public SystemUser lk_picklistmapping_createdby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_picklistmapping_createdby", null); }
        }

        /// <summary>
        /// N:1 lk_picklistmapping_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_picklistmapping_createdonbehalfby")]
        public SystemUser lk_picklistmapping_createdonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_picklistmapping_createdonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_picklistmapping_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_picklistmapping_modifiedby")]
        public SystemUser lk_picklistmapping_modifiedby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_picklistmapping_modifiedby", null); }
        }

        /// <summary>
        /// N:1 lk_picklistmapping_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_picklistmapping_modifiedonbehalfby")]
        public SystemUser lk_picklistmapping_modifiedonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_picklistmapping_modifiedonbehalfby", null); }
        }

        /// <summary>
        /// N:1 PickListMapping_ColumnMapping
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("columnmappingid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("PickListMapping_ColumnMapping")]
        public ColumnMapping PickListMapping_ColumnMapping
        {
            get { return this.GetRelatedEntity<ColumnMapping>("PickListMapping_ColumnMapping", null); }
            set
            {
                this.OnPropertyChanging("PickListMapping_ColumnMapping");
                this.SetRelatedEntity<ColumnMapping>("PickListMapping_ColumnMapping", null, value);
                this.OnPropertyChanged("PickListMapping_ColumnMapping");
            }
        }
    }
}