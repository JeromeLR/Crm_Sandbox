namespace __4_DAL_CRM
{
    /// <summary>
    /// Unit of measure.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("uom")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class UoM : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public UoM() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "uom";

        public const int EntityTypeCode = 1055;

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
        /// Choose the base or primary unit on which the unit is based.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("baseuom")]
        public Microsoft.Xrm.Sdk.EntityReference BaseUoM
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("baseuom"); }
            set
            {
                this.OnPropertyChanging("BaseUoM");
                this.SetAttributeValue("baseuom", value);
                this.OnPropertyChanged("BaseUoM");
            }
        }

        /// <summary>
        /// Unique identifier of the user who created the unit.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby"); }
        }

        /// <summary>
        /// Date and time when the unit was created.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
        public System.Nullable<System.DateTime> CreatedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who created the uom.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby"); }
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
        /// Tells whether the unit is the base unit for the associated unit group.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isschedulebaseuom")]
        public System.Nullable<bool> IsScheduleBaseUoM
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("isschedulebaseuom"); }
        }

        /// <summary>
        /// Unique identifier of the user who last modified the unit.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby"); }
        }

        /// <summary>
        /// Date and time when the unit was last modified.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
        public System.Nullable<System.DateTime> ModifiedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who last modified the uom.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        /// Type a descriptive title or name for the unit of measure.
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
        /// Unique identifier of the organization associated with the unit of measure.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
        public System.Nullable<System.Guid> OrganizationId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("organizationid"); }
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
        /// Unit quantity for the product.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("quantity")]
        public System.Nullable<decimal> Quantity
        {
            get { return this.GetAttributeValue<System.Nullable<decimal>>("quantity"); }
            set
            {
                this.OnPropertyChanging("Quantity");
                this.SetAttributeValue("quantity", value);
                this.OnPropertyChanged("Quantity");
            }
        }

        /// <summary>
        /// Unique identifier of the unit.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("uomid")]
        public System.Nullable<System.Guid> UoMId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("uomid"); }
            set
            {
                this.OnPropertyChanging("UoMId");
                this.SetAttributeValue("uomid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("UoMId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("uomid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.UoMId = value; }
        }

        /// <summary>
        /// Choose the ID of the unit group that the unit is associated with.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("uomscheduleid")]
        public Microsoft.Xrm.Sdk.EntityReference UoMScheduleId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("uomscheduleid"); }
            set
            {
                this.OnPropertyChanging("UoMScheduleId");
                this.SetAttributeValue("uomscheduleid", value);
                this.OnPropertyChanged("UoMScheduleId");
            }
        }

        /// <summary>
        /// Version number of the unit.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
        public System.Nullable<long> VersionNumber
        {
            get { return this.GetAttributeValue<System.Nullable<long>>("versionnumber"); }
        }

        /// <summary>
        /// 1:N unit_of_measurement_base_unit
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("unit_of_measurement_base_unit", Microsoft.Xrm.Sdk.EntityRole.Referenced)]
        public System.Collections.Generic.IEnumerable<UoM> Referencedunit_of_measurement_base_unit
        {
            get { return this.GetRelatedEntities<UoM>("unit_of_measurement_base_unit", Microsoft.Xrm.Sdk.EntityRole.Referenced); }
            set
            {
                this.OnPropertyChanging("Referencedunit_of_measurement_base_unit");
                this.SetRelatedEntities<UoM>("unit_of_measurement_base_unit", Microsoft.Xrm.Sdk.EntityRole.Referenced, value);
                this.OnPropertyChanged("Referencedunit_of_measurement_base_unit");
            }
        }

        /// <summary>
        /// 1:N unit_of_measurement_contract_line_items
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("unit_of_measurement_contract_line_items")]
        public System.Collections.Generic.IEnumerable<ContractDetail> unit_of_measurement_contract_line_items
        {
            get { return this.GetRelatedEntities<ContractDetail>("unit_of_measurement_contract_line_items", null); }
            set
            {
                this.OnPropertyChanging("unit_of_measurement_contract_line_items");
                this.SetRelatedEntities<ContractDetail>("unit_of_measurement_contract_line_items", null, value);
                this.OnPropertyChanged("unit_of_measurement_contract_line_items");
            }
        }

        /// <summary>
        /// 1:N unit_of_measurement_invoice_details
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("unit_of_measurement_invoice_details")]
        public System.Collections.Generic.IEnumerable<InvoiceDetail> unit_of_measurement_invoice_details
        {
            get { return this.GetRelatedEntities<InvoiceDetail>("unit_of_measurement_invoice_details", null); }
            set
            {
                this.OnPropertyChanging("unit_of_measurement_invoice_details");
                this.SetRelatedEntities<InvoiceDetail>("unit_of_measurement_invoice_details", null, value);
                this.OnPropertyChanged("unit_of_measurement_invoice_details");
            }
        }

        /// <summary>
        /// 1:N unit_of_measurement_opportunity_products
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("unit_of_measurement_opportunity_products")]
        public System.Collections.Generic.IEnumerable<OpportunityProduct> unit_of_measurement_opportunity_products
        {
            get { return this.GetRelatedEntities<OpportunityProduct>("unit_of_measurement_opportunity_products", null); }
            set
            {
                this.OnPropertyChanging("unit_of_measurement_opportunity_products");
                this.SetRelatedEntities<OpportunityProduct>("unit_of_measurement_opportunity_products", null, value);
                this.OnPropertyChanged("unit_of_measurement_opportunity_products");
            }
        }

        /// <summary>
        /// 1:N unit_of_measurement_order_details
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("unit_of_measurement_order_details")]
        public System.Collections.Generic.IEnumerable<SalesOrderDetail> unit_of_measurement_order_details
        {
            get { return this.GetRelatedEntities<SalesOrderDetail>("unit_of_measurement_order_details", null); }
            set
            {
                this.OnPropertyChanging("unit_of_measurement_order_details");
                this.SetRelatedEntities<SalesOrderDetail>("unit_of_measurement_order_details", null, value);
                this.OnPropertyChanged("unit_of_measurement_order_details");
            }
        }

        /// <summary>
        /// 1:N unit_of_measurement_product_price_levels
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("unit_of_measurement_product_price_levels")]
        public System.Collections.Generic.IEnumerable<ProductPriceLevel> unit_of_measurement_product_price_levels
        {
            get { return this.GetRelatedEntities<ProductPriceLevel>("unit_of_measurement_product_price_levels", null); }
            set
            {
                this.OnPropertyChanging("unit_of_measurement_product_price_levels");
                this.SetRelatedEntities<ProductPriceLevel>("unit_of_measurement_product_price_levels", null, value);
                this.OnPropertyChanged("unit_of_measurement_product_price_levels");
            }
        }

        /// <summary>
        /// 1:N unit_of_measurement_productassociation
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("unit_of_measurement_productassociation")]
        public System.Collections.Generic.IEnumerable<ProductAssociation> unit_of_measurement_productassociation
        {
            get { return this.GetRelatedEntities<ProductAssociation>("unit_of_measurement_productassociation", null); }
            set
            {
                this.OnPropertyChanging("unit_of_measurement_productassociation");
                this.SetRelatedEntities<ProductAssociation>("unit_of_measurement_productassociation", null, value);
                this.OnPropertyChanged("unit_of_measurement_productassociation");
            }
        }

        /// <summary>
        /// 1:N unit_of_measurement_products
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("unit_of_measurement_products")]
        public System.Collections.Generic.IEnumerable<Product> unit_of_measurement_products
        {
            get { return this.GetRelatedEntities<Product>("unit_of_measurement_products", null); }
            set
            {
                this.OnPropertyChanging("unit_of_measurement_products");
                this.SetRelatedEntities<Product>("unit_of_measurement_products", null, value);
                this.OnPropertyChanged("unit_of_measurement_products");
            }
        }

        /// <summary>
        /// 1:N unit_of_measurement_quote_details
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("unit_of_measurement_quote_details")]
        public System.Collections.Generic.IEnumerable<QuoteDetail> unit_of_measurement_quote_details
        {
            get { return this.GetRelatedEntities<QuoteDetail>("unit_of_measurement_quote_details", null); }
            set
            {
                this.OnPropertyChanging("unit_of_measurement_quote_details");
                this.SetRelatedEntities<QuoteDetail>("unit_of_measurement_quote_details", null, value);
                this.OnPropertyChanged("unit_of_measurement_quote_details");
            }
        }

        /// <summary>
        /// 1:N UoM_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("UoM_AsyncOperations")]
        public System.Collections.Generic.IEnumerable<AsyncOperation> UoM_AsyncOperations
        {
            get { return this.GetRelatedEntities<AsyncOperation>("UoM_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("UoM_AsyncOperations");
                this.SetRelatedEntities<AsyncOperation>("UoM_AsyncOperations", null, value);
                this.OnPropertyChanged("UoM_AsyncOperations");
            }
        }

        /// <summary>
        /// 1:N UoM_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("UoM_BulkDeleteFailures")]
        public System.Collections.Generic.IEnumerable<BulkDeleteFailure> UoM_BulkDeleteFailures
        {
            get { return this.GetRelatedEntities<BulkDeleteFailure>("UoM_BulkDeleteFailures", null); }
            set
            {
                this.OnPropertyChanging("UoM_BulkDeleteFailures");
                this.SetRelatedEntities<BulkDeleteFailure>("UoM_BulkDeleteFailures", null, value);
                this.OnPropertyChanged("UoM_BulkDeleteFailures");
            }
        }

        /// <summary>
        /// 1:N userentityinstancedata_uom
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_uom")]
        public System.Collections.Generic.IEnumerable<UserEntityInstanceData> userentityinstancedata_uom
        {
            get { return this.GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_uom", null); }
            set
            {
                this.OnPropertyChanging("userentityinstancedata_uom");
                this.SetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_uom", null, value);
                this.OnPropertyChanged("userentityinstancedata_uom");
            }
        }

        /// <summary>
        /// N:1 lk_uom_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_uom_createdonbehalfby")]
        public SystemUser lk_uom_createdonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_uom_createdonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_uom_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_uom_modifiedonbehalfby")]
        public SystemUser lk_uom_modifiedonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_uom_modifiedonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_uombase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_uombase_createdby")]
        public SystemUser lk_uombase_createdby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_uombase_createdby", null); }
        }

        /// <summary>
        /// N:1 lk_uombase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_uombase_modifiedby")]
        public SystemUser lk_uombase_modifiedby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_uombase_modifiedby", null); }
        }

        /// <summary>
        /// N:1 unit_of_measure_schedule_conversions
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("uomscheduleid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("unit_of_measure_schedule_conversions")]
        public UoMSchedule unit_of_measure_schedule_conversions
        {
            get { return this.GetRelatedEntity<UoMSchedule>("unit_of_measure_schedule_conversions", null); }
            set
            {
                this.OnPropertyChanging("unit_of_measure_schedule_conversions");
                this.SetRelatedEntity<UoMSchedule>("unit_of_measure_schedule_conversions", null, value);
                this.OnPropertyChanged("unit_of_measure_schedule_conversions");
            }
        }

        /// <summary>
        /// N:1 unit_of_measurement_base_unit
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("baseuom")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("unit_of_measurement_base_unit", Microsoft.Xrm.Sdk.EntityRole.Referencing)]
        public UoM Referencingunit_of_measurement_base_unit
        {
            get { return this.GetRelatedEntity<UoM>("unit_of_measurement_base_unit", Microsoft.Xrm.Sdk.EntityRole.Referencing); }
            set
            {
                this.OnPropertyChanging("Referencingunit_of_measurement_base_unit");
                this.SetRelatedEntity<UoM>("unit_of_measurement_base_unit", Microsoft.Xrm.Sdk.EntityRole.Referencing, value);
                this.OnPropertyChanged("Referencingunit_of_measurement_base_unit");
            }
        }
    }
}