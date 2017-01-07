namespace __4_DAL_CRM
{
    /// <summary>
    /// Grouping of units.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("uomschedule")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class UoMSchedule : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public UoMSchedule() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "uomschedule";

        public const int EntityTypeCode = 1056;

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
        /// Name of the base unit.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("baseuomname")]
        public string BaseUoMName
        {
            get { return this.GetAttributeValue<string>("baseuomname"); }
            set
            {
                this.OnPropertyChanging("BaseUoMName");
                this.SetAttributeValue("baseuomname", value);
                this.OnPropertyChanged("BaseUoMName");
            }
        }

        /// <summary>
        /// Unique identifier of the user who created the unit group.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby"); }
        }

        /// <summary>
        /// Date and time when the unit group was created.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
        public System.Nullable<System.DateTime> CreatedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who created the uomschedule.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        /// Description of the unit group.
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
        /// Unique identifier of the data import or data migration that created this record.
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
        /// Unique identifier of the user who last modified the unit group.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby"); }
        }

        /// <summary>
        /// Date and time when the unit group was last modified.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
        public System.Nullable<System.DateTime> ModifiedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who last modified the uomschedule.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        /// Name of the unit group.
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
        /// Unique identifier of the organization associated with the unit group.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
        public Microsoft.Xrm.Sdk.EntityReference OrganizationId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("organizationid"); }
        }

        /// <summary>
        /// Date and time that the record was migrated.
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
        /// Status of the Unit Group.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
        public System.Nullable<UoMScheduleState> StateCode
        {
            get
            {
                Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
                if ((optionSet != null))
                {
                    return ((UoMScheduleState) (System.Enum.ToObject(typeof(UoMScheduleState), optionSet.Value)));
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// Reason for the status of the Unit Group.
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
        /// Unique identifier for the unit group.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("uomscheduleid")]
        public System.Nullable<System.Guid> UoMScheduleId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("uomscheduleid"); }
            set
            {
                this.OnPropertyChanging("UoMScheduleId");
                this.SetAttributeValue("uomscheduleid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("UoMScheduleId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("uomscheduleid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.UoMScheduleId = value; }
        }

        /// <summary>
        /// Version number of the unit group.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
        public System.Nullable<long> VersionNumber
        {
            get { return this.GetAttributeValue<System.Nullable<long>>("versionnumber"); }
        }

        /// <summary>
        /// 1:N contract_detail_unit_of_measure_schedule
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("contract_detail_unit_of_measure_schedule")]
        public System.Collections.Generic.IEnumerable<ContractDetail> contract_detail_unit_of_measure_schedule
        {
            get { return this.GetRelatedEntities<ContractDetail>("contract_detail_unit_of_measure_schedule", null); }
            set
            {
                this.OnPropertyChanging("contract_detail_unit_of_measure_schedule");
                this.SetRelatedEntities<ContractDetail>("contract_detail_unit_of_measure_schedule", null, value);
                this.OnPropertyChanged("contract_detail_unit_of_measure_schedule");
            }
        }

        /// <summary>
        /// 1:N unit_of_measure_schedule_conversions
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("unit_of_measure_schedule_conversions")]
        public System.Collections.Generic.IEnumerable<UoM> unit_of_measure_schedule_conversions
        {
            get { return this.GetRelatedEntities<UoM>("unit_of_measure_schedule_conversions", null); }
            set
            {
                this.OnPropertyChanging("unit_of_measure_schedule_conversions");
                this.SetRelatedEntities<UoM>("unit_of_measure_schedule_conversions", null, value);
                this.OnPropertyChanged("unit_of_measure_schedule_conversions");
            }
        }

        /// <summary>
        /// 1:N unit_of_measure_schedule_product_price_level
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("unit_of_measure_schedule_product_price_level")]
        public System.Collections.Generic.IEnumerable<ProductPriceLevel> unit_of_measure_schedule_product_price_level
        {
            get { return this.GetRelatedEntities<ProductPriceLevel>("unit_of_measure_schedule_product_price_level", null); }
            set
            {
                this.OnPropertyChanging("unit_of_measure_schedule_product_price_level");
                this.SetRelatedEntities<ProductPriceLevel>("unit_of_measure_schedule_product_price_level", null, value);
                this.OnPropertyChanged("unit_of_measure_schedule_product_price_level");
            }
        }

        /// <summary>
        /// 1:N unit_of_measurement_schedule_products
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("unit_of_measurement_schedule_products")]
        public System.Collections.Generic.IEnumerable<Product> unit_of_measurement_schedule_products
        {
            get { return this.GetRelatedEntities<Product>("unit_of_measurement_schedule_products", null); }
            set
            {
                this.OnPropertyChanging("unit_of_measurement_schedule_products");
                this.SetRelatedEntities<Product>("unit_of_measurement_schedule_products", null, value);
                this.OnPropertyChanged("unit_of_measurement_schedule_products");
            }
        }

        /// <summary>
        /// 1:N UoMSchedule_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("UoMSchedule_AsyncOperations")]
        public System.Collections.Generic.IEnumerable<AsyncOperation> UoMSchedule_AsyncOperations
        {
            get { return this.GetRelatedEntities<AsyncOperation>("UoMSchedule_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("UoMSchedule_AsyncOperations");
                this.SetRelatedEntities<AsyncOperation>("UoMSchedule_AsyncOperations", null, value);
                this.OnPropertyChanged("UoMSchedule_AsyncOperations");
            }
        }

        /// <summary>
        /// 1:N UoMSchedule_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("UoMSchedule_BulkDeleteFailures")]
        public System.Collections.Generic.IEnumerable<BulkDeleteFailure> UoMSchedule_BulkDeleteFailures
        {
            get { return this.GetRelatedEntities<BulkDeleteFailure>("UoMSchedule_BulkDeleteFailures", null); }
            set
            {
                this.OnPropertyChanging("UoMSchedule_BulkDeleteFailures");
                this.SetRelatedEntities<BulkDeleteFailure>("UoMSchedule_BulkDeleteFailures", null, value);
                this.OnPropertyChanged("UoMSchedule_BulkDeleteFailures");
            }
        }

        /// <summary>
        /// 1:N userentityinstancedata_uomschedule
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_uomschedule")]
        public System.Collections.Generic.IEnumerable<UserEntityInstanceData> userentityinstancedata_uomschedule
        {
            get { return this.GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_uomschedule", null); }
            set
            {
                this.OnPropertyChanging("userentityinstancedata_uomschedule");
                this.SetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_uomschedule", null, value);
                this.OnPropertyChanged("userentityinstancedata_uomschedule");
            }
        }

        /// <summary>
        /// N:1 lk_uomschedule_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_uomschedule_createdonbehalfby")]
        public SystemUser lk_uomschedule_createdonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_uomschedule_createdonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_uomschedule_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_uomschedule_modifiedonbehalfby")]
        public SystemUser lk_uomschedule_modifiedonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_uomschedule_modifiedonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_uomschedulebase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_uomschedulebase_createdby")]
        public SystemUser lk_uomschedulebase_createdby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_uomschedulebase_createdby", null); }
        }

        /// <summary>
        /// N:1 lk_uomschedulebase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_uomschedulebase_modifiedby")]
        public SystemUser lk_uomschedulebase_modifiedby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_uomschedulebase_modifiedby", null); }
        }

        /// <summary>
        /// N:1 organization_uof_schedules
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_uof_schedules")]
        public Organization organization_uof_schedules
        {
            get { return this.GetRelatedEntity<Organization>("organization_uof_schedules", null); }
        }
    }
}