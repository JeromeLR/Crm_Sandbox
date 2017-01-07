namespace __4_DAL_CRM
{
    /// <summary>
    /// Instance of a product added to a bundle or kit.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("productassociation")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class ProductAssociation : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public ProductAssociation() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "productassociation";

        public const int EntityTypeCode = 1025;

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
        /// Select a product to add to the bundle or kit.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("associatedproduct")]
        public Microsoft.Xrm.Sdk.EntityReference AssociatedProduct
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("associatedproduct"); }
            set
            {
                this.OnPropertyChanging("AssociatedProduct");
                this.SetAttributeValue("associatedproduct", value);
                this.OnPropertyChanged("AssociatedProduct");
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
        /// Shows the conversion rate of the record's currency. The exchange rate is used to convert all money fields in the record from the local currency to the system's default currency.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("exchangerate")]
        public System.Nullable<decimal> ExchangeRate
        {
            get { return this.GetAttributeValue<System.Nullable<decimal>>("exchangerate"); }
        }

        /// <summary>
        /// Shows the data import or data migration that created this record.
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
        /// Shows the organization associated with the record.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
        public Microsoft.Xrm.Sdk.EntityReference OrganizationId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("organizationid"); }
        }

        /// <summary>
        /// Shows the date and time that the record was migrated.
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
        /// Shows the unique identifier of the product association.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("productassociationid")]
        public System.Nullable<System.Guid> ProductAssociationId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("productassociationid"); }
            set
            {
                this.OnPropertyChanging("ProductAssociationId");
                this.SetAttributeValue("productassociationid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("ProductAssociationId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("productassociationid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.ProductAssociationId = value; }
        }

        /// <summary>
        /// Select a bundle or a kit.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("productid")]
        public Microsoft.Xrm.Sdk.EntityReference ProductId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("productid"); }
            set
            {
                this.OnPropertyChanging("ProductId");
                this.SetAttributeValue("productid", value);
                this.OnPropertyChanged("ProductId");
            }
        }

        /// <summary>
        /// Select whether the associated product is required or optional.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("productisrequired")]
        public Microsoft.Xrm.Sdk.OptionSetValue ProductIsRequired
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("productisrequired"); }
            set
            {
                this.OnPropertyChanging("ProductIsRequired");
                this.SetAttributeValue("productisrequired", value);
                this.OnPropertyChanged("ProductIsRequired");
            }
        }

        /// <summary>
        /// Shows whether the item has properties that can be customized.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("propertycustomizationstatus")]
        public Microsoft.Xrm.Sdk.OptionSetValue PropertyCustomizationStatus
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("propertycustomizationstatus"); }
            set
            {
                this.OnPropertyChanging("PropertyCustomizationStatus");
                this.SetAttributeValue("propertycustomizationstatus", value);
                this.OnPropertyChanged("PropertyCustomizationStatus");
            }
        }

        /// <summary>
        /// Type the quantity of the products added to the bundle or kit.
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
        /// Shows whether the associated product is active or inactive.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
        public System.Nullable<ProductAssociationState> statecode
        {
            get
            {
                Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
                if ((optionSet != null))
                {
                    return ((ProductAssociationState) (System.Enum.ToObject(typeof(ProductAssociationState), optionSet.Value)));
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// Select the associated product's status.
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
        /// Shows the currency associated with the record.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyid")]
        public Microsoft.Xrm.Sdk.EntityReference TransactionCurrencyId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("transactioncurrencyid"); }
            set
            {
                this.OnPropertyChanging("TransactionCurrencyId");
                this.SetAttributeValue("transactioncurrencyid", value);
                this.OnPropertyChanged("TransactionCurrencyId");
            }
        }

        /// <summary>
        /// Shows the unit of the product association.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("uomid")]
        public Microsoft.Xrm.Sdk.EntityReference UoMId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("uomid"); }
            set
            {
                this.OnPropertyChanging("UoMId");
                this.SetAttributeValue("uomid", value);
                this.OnPropertyChanged("UoMId");
            }
        }

        /// <summary>
        /// Shows the version number of the product association.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
        public System.Nullable<long> VersionNumber
        {
            get { return this.GetAttributeValue<System.Nullable<long>>("versionnumber"); }
        }

        /// <summary>
        /// 1:N ProductAssociation_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ProductAssociation_AsyncOperations")]
        public System.Collections.Generic.IEnumerable<AsyncOperation> ProductAssociation_AsyncOperations
        {
            get { return this.GetRelatedEntities<AsyncOperation>("ProductAssociation_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("ProductAssociation_AsyncOperations");
                this.SetRelatedEntities<AsyncOperation>("ProductAssociation_AsyncOperations", null, value);
                this.OnPropertyChanged("ProductAssociation_AsyncOperations");
            }
        }

        /// <summary>
        /// 1:N ProductAssociation_DynamicProperty
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ProductAssociation_DynamicProperty")]
        public System.Collections.Generic.IEnumerable<DynamicProperty> ProductAssociation_DynamicProperty
        {
            get { return this.GetRelatedEntities<DynamicProperty>("ProductAssociation_DynamicProperty", null); }
            set
            {
                this.OnPropertyChanging("ProductAssociation_DynamicProperty");
                this.SetRelatedEntities<DynamicProperty>("ProductAssociation_DynamicProperty", null, value);
                this.OnPropertyChanged("ProductAssociation_DynamicProperty");
            }
        }

        /// <summary>
        /// 1:N ProductAssociation_DynamicPropertyAssociation
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ProductAssociation_DynamicPropertyAssociation")]
        public System.Collections.Generic.IEnumerable<DynamicPropertyAssociation> ProductAssociation_DynamicPropertyAssociation
        {
            get { return this.GetRelatedEntities<DynamicPropertyAssociation>("ProductAssociation_DynamicPropertyAssociation", null); }
            set
            {
                this.OnPropertyChanging("ProductAssociation_DynamicPropertyAssociation");
                this.SetRelatedEntities<DynamicPropertyAssociation>("ProductAssociation_DynamicPropertyAssociation", null, value);
                this.OnPropertyChanged("ProductAssociation_DynamicPropertyAssociation");
            }
        }

        /// <summary>
        /// 1:N productAssociation_invoice_details
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("productAssociation_invoice_details")]
        public System.Collections.Generic.IEnumerable<InvoiceDetail> productAssociation_invoice_details
        {
            get { return this.GetRelatedEntities<InvoiceDetail>("productAssociation_invoice_details", null); }
            set
            {
                this.OnPropertyChanging("productAssociation_invoice_details");
                this.SetRelatedEntities<InvoiceDetail>("productAssociation_invoice_details", null, value);
                this.OnPropertyChanged("productAssociation_invoice_details");
            }
        }

        /// <summary>
        /// 1:N productAssociation_opportunity_product
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("productAssociation_opportunity_product")]
        public System.Collections.Generic.IEnumerable<OpportunityProduct> productAssociation_opportunity_product
        {
            get { return this.GetRelatedEntities<OpportunityProduct>("productAssociation_opportunity_product", null); }
            set
            {
                this.OnPropertyChanging("productAssociation_opportunity_product");
                this.SetRelatedEntities<OpportunityProduct>("productAssociation_opportunity_product", null, value);
                this.OnPropertyChanged("productAssociation_opportunity_product");
            }
        }

        /// <summary>
        /// 1:N ProductAssociation_PrincipalObjectAttributeAccess
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ProductAssociation_PrincipalObjectAttributeAccess")]
        public System.Collections.Generic.IEnumerable<PrincipalObjectAttributeAccess> ProductAssociation_PrincipalObjectAttributeAccess
        {
            get { return this.GetRelatedEntities<PrincipalObjectAttributeAccess>("ProductAssociation_PrincipalObjectAttributeAccess", null); }
            set
            {
                this.OnPropertyChanging("ProductAssociation_PrincipalObjectAttributeAccess");
                this.SetRelatedEntities<PrincipalObjectAttributeAccess>("ProductAssociation_PrincipalObjectAttributeAccess", null, value);
                this.OnPropertyChanged("ProductAssociation_PrincipalObjectAttributeAccess");
            }
        }

        /// <summary>
        /// 1:N ProductAssociation_ProcessSessions
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ProductAssociation_ProcessSessions")]
        public System.Collections.Generic.IEnumerable<ProcessSession> ProductAssociation_ProcessSessions
        {
            get { return this.GetRelatedEntities<ProcessSession>("ProductAssociation_ProcessSessions", null); }
            set
            {
                this.OnPropertyChanging("ProductAssociation_ProcessSessions");
                this.SetRelatedEntities<ProcessSession>("ProductAssociation_ProcessSessions", null, value);
                this.OnPropertyChanged("ProductAssociation_ProcessSessions");
            }
        }

        /// <summary>
        /// 1:N productAssociation_quote_details
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("productAssociation_quote_details")]
        public System.Collections.Generic.IEnumerable<QuoteDetail> productAssociation_quote_details
        {
            get { return this.GetRelatedEntities<QuoteDetail>("productAssociation_quote_details", null); }
            set
            {
                this.OnPropertyChanging("productAssociation_quote_details");
                this.SetRelatedEntities<QuoteDetail>("productAssociation_quote_details", null, value);
                this.OnPropertyChanged("productAssociation_quote_details");
            }
        }

        /// <summary>
        /// 1:N productAssociation_salesorder_details
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("productAssociation_salesorder_details")]
        public System.Collections.Generic.IEnumerable<SalesOrderDetail> productAssociation_salesorder_details
        {
            get { return this.GetRelatedEntities<SalesOrderDetail>("productAssociation_salesorder_details", null); }
            set
            {
                this.OnPropertyChanging("productAssociation_salesorder_details");
                this.SetRelatedEntities<SalesOrderDetail>("productAssociation_salesorder_details", null, value);
                this.OnPropertyChanged("productAssociation_salesorder_details");
            }
        }

        /// <summary>
        /// 1:N userentityinstancedata_productassociation
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_productassociation")]
        public System.Collections.Generic.IEnumerable<UserEntityInstanceData> userentityinstancedata_productassociation
        {
            get { return this.GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_productassociation", null); }
            set
            {
                this.OnPropertyChanging("userentityinstancedata_productassociation");
                this.SetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_productassociation", null, value);
                this.OnPropertyChanged("userentityinstancedata_productassociation");
            }
        }

        /// <summary>
        /// N:1 lk_ProductAssociate_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ProductAssociate_createdby")]
        public SystemUser lk_ProductAssociate_createdby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_ProductAssociate_createdby", null); }
        }

        /// <summary>
        /// N:1 lk_ProductAssociation_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ProductAssociation_createdonbehalfby")]
        public SystemUser lk_ProductAssociation_createdonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_ProductAssociation_createdonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_ProductAssociation_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ProductAssociation_modifiedby")]
        public SystemUser lk_ProductAssociation_modifiedby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_ProductAssociation_modifiedby", null); }
        }

        /// <summary>
        /// N:1 lk_ProductAssociation_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ProductAssociation_modifiedonbehalfby")]
        public SystemUser lk_ProductAssociation_modifiedonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_ProductAssociation_modifiedonbehalfby", null); }
        }

        /// <summary>
        /// N:1 organization_ProductAssociation
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_ProductAssociation")]
        public Organization organization_ProductAssociation
        {
            get { return this.GetRelatedEntity<Organization>("organization_ProductAssociation", null); }
        }

        /// <summary>
        /// N:1 Product_ProductAssociation_AssocProd
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("associatedproduct")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Product_ProductAssociation_AssocProd")]
        public Product Product_ProductAssociation_AssocProd
        {
            get { return this.GetRelatedEntity<Product>("Product_ProductAssociation_AssocProd", null); }
            set
            {
                this.OnPropertyChanging("Product_ProductAssociation_AssocProd");
                this.SetRelatedEntity<Product>("Product_ProductAssociation_AssocProd", null, value);
                this.OnPropertyChanged("Product_ProductAssociation_AssocProd");
            }
        }

        /// <summary>
        /// N:1 Product_ProductAssociation_Prod
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("productid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Product_ProductAssociation_Prod")]
        public Product Product_ProductAssociation_Prod
        {
            get { return this.GetRelatedEntity<Product>("Product_ProductAssociation_Prod", null); }
            set
            {
                this.OnPropertyChanging("Product_ProductAssociation_Prod");
                this.SetRelatedEntity<Product>("Product_ProductAssociation_Prod", null, value);
                this.OnPropertyChanged("Product_ProductAssociation_Prod");
            }
        }

        /// <summary>
        /// N:1 transactioncurrency_ProductAssociation
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("transactioncurrency_ProductAssociation")]
        public TransactionCurrency transactioncurrency_ProductAssociation
        {
            get { return this.GetRelatedEntity<TransactionCurrency>("transactioncurrency_ProductAssociation", null); }
            set
            {
                this.OnPropertyChanging("transactioncurrency_ProductAssociation");
                this.SetRelatedEntity<TransactionCurrency>("transactioncurrency_ProductAssociation", null, value);
                this.OnPropertyChanged("transactioncurrency_ProductAssociation");
            }
        }

        /// <summary>
        /// N:1 unit_of_measurement_productassociation
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("uomid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("unit_of_measurement_productassociation")]
        public UoM unit_of_measurement_productassociation
        {
            get { return this.GetRelatedEntity<UoM>("unit_of_measurement_productassociation", null); }
            set
            {
                this.OnPropertyChanging("unit_of_measurement_productassociation");
                this.SetRelatedEntity<UoM>("unit_of_measurement_productassociation", null, value);
                this.OnPropertyChanged("unit_of_measurement_productassociation");
            }
        }
    }
}