namespace __4_DAL_CRM
{
    /// <summary>
    /// Information about products and their pricing information.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("product")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class Product : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public Product() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "product";

        public const int EntityTypeCode = 1024;

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
        /// Unique identifier of the user who created the product.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby"); }
        }

        /// <summary>
        /// Date and time when the product was created.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
        public System.Nullable<System.DateTime> CreatedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who created the product.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        /// Current cost for the product item. Used in price calculations.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("currentcost")]
        public Microsoft.Xrm.Sdk.Money CurrentCost
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("currentcost"); }
            set
            {
                this.OnPropertyChanging("CurrentCost");
                this.SetAttributeValue("currentcost", value);
                this.OnPropertyChanged("CurrentCost");
            }
        }

        /// <summary>
        /// Base currency equivalent of the current cost for the product item.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("currentcost_base")]
        public Microsoft.Xrm.Sdk.Money CurrentCost_Base
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("currentcost_base"); }
        }

        /// <summary>
        /// Default unit for the product.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("defaultuomid")]
        public Microsoft.Xrm.Sdk.EntityReference DefaultUoMId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("defaultuomid"); }
            set
            {
                this.OnPropertyChanging("DefaultUoMId");
                this.SetAttributeValue("defaultuomid", value);
                this.OnPropertyChanged("DefaultUoMId");
            }
        }

        /// <summary>
        /// Default unit group for the product.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("defaultuomscheduleid")]
        public Microsoft.Xrm.Sdk.EntityReference DefaultUoMScheduleId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("defaultuomscheduleid"); }
            set
            {
                this.OnPropertyChanging("DefaultUoMScheduleId");
                this.SetAttributeValue("defaultuomscheduleid", value);
                this.OnPropertyChanged("DefaultUoMScheduleId");
            }
        }

        /// <summary>
        /// Description of the product.
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
        /// Shows the default image for the record.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entityimage")]
        public byte[] EntityImage
        {
            get { return this.GetAttributeValue<byte[]>("entityimage"); }
            set
            {
                this.OnPropertyChanging("EntityImage");
                this.SetAttributeValue("entityimage", value);
                this.OnPropertyChanged("EntityImage");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entityimage_timestamp")]
        public System.Nullable<long> EntityImage_Timestamp
        {
            get { return this.GetAttributeValue<System.Nullable<long>>("entityimage_timestamp"); }
        }

        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entityimage_url")]
        public string EntityImage_URL
        {
            get { return this.GetAttributeValue<string>("entityimage_url"); }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entityimageid")]
        public System.Nullable<System.Guid> EntityImageId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("entityimageid"); }
        }

        /// <summary>
        /// Exchange rate for the currency associated with the product with respect to the base currency.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("exchangerate")]
        public System.Nullable<decimal> ExchangeRate
        {
            get { return this.GetAttributeValue<System.Nullable<decimal>>("exchangerate"); }
        }

        /// <summary>
        /// Hierarchy path of the product.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("hierarchypath")]
        public string HierarchyPath
        {
            get { return this.GetAttributeValue<string>("hierarchypath"); }
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
        /// Information that specifies whether the product is a kit.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("iskit")]
        public System.Nullable<bool> IsKit
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("iskit"); }
            set
            {
                this.OnPropertyChanging("IsKit");
                this.SetAttributeValue("iskit", value);
                this.OnPropertyChanged("IsKit");
            }
        }

        /// <summary>
        /// Information about whether the product is a stock item.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isstockitem")]
        public System.Nullable<bool> IsStockItem
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("isstockitem"); }
            set
            {
                this.OnPropertyChanging("IsStockItem");
                this.SetAttributeValue("isstockitem", value);
                this.OnPropertyChanged("IsStockItem");
            }
        }

        /// <summary>
        /// Unique identifier of the user who last modified the product.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby"); }
        }

        /// <summary>
        /// Date and time when the product was last modified.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
        public System.Nullable<System.DateTime> ModifiedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who last modified the product.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        /// Name of the product.
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
        /// Unique identifier of the organization associated with the product.
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
        /// Specifies the parent product family hierarchy.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("parentproductid")]
        public Microsoft.Xrm.Sdk.EntityReference ParentProductId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("parentproductid"); }
            set
            {
                this.OnPropertyChanging("ParentProductId");
                this.SetAttributeValue("parentproductid", value);
                this.OnPropertyChanged("ParentProductId");
            }
        }

        /// <summary>
        /// List price of the product.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("price")]
        public Microsoft.Xrm.Sdk.Money Price
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("price"); }
            set
            {
                this.OnPropertyChanging("Price");
                this.SetAttributeValue("price", value);
                this.OnPropertyChanged("Price");
            }
        }

        /// <summary>
        /// Base currency equivalent of the list price of the product
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("price_base")]
        public Microsoft.Xrm.Sdk.Money Price_Base
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("price_base"); }
        }

        /// <summary>
        /// Select the default price list for the product.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("pricelevelid")]
        public Microsoft.Xrm.Sdk.EntityReference PriceLevelId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("pricelevelid"); }
            set
            {
                this.OnPropertyChanging("PriceLevelId");
                this.SetAttributeValue("pricelevelid", value);
                this.OnPropertyChanged("PriceLevelId");
            }
        }

        /// <summary>
        /// Shows the ID of the process.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("processid")]
        public System.Nullable<System.Guid> ProcessId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("processid"); }
            set
            {
                this.OnPropertyChanging("ProcessId");
                this.SetAttributeValue("processid", value);
                this.OnPropertyChanged("ProcessId");
            }
        }

        /// <summary>
        /// Unique identifier of the product.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("productid")]
        public System.Nullable<System.Guid> ProductId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("productid"); }
            set
            {
                this.OnPropertyChanging("ProductId");
                this.SetAttributeValue("productid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("ProductId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("productid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.ProductId = value; }
        }

        /// <summary>
        /// User-defined product ID.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("productnumber")]
        public string ProductNumber
        {
            get { return this.GetAttributeValue<string>("productnumber"); }
            set
            {
                this.OnPropertyChanging("ProductNumber");
                this.SetAttributeValue("productnumber", value);
                this.OnPropertyChanged("ProductNumber");
            }
        }

        /// <summary>
        /// Product Structure.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("productstructure")]
        public Microsoft.Xrm.Sdk.OptionSetValue ProductStructure
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("productstructure"); }
            set
            {
                this.OnPropertyChanging("ProductStructure");
                this.SetAttributeValue("productstructure", value);
                this.OnPropertyChanged("ProductStructure");
            }
        }

        /// <summary>
        /// Type of product.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("producttypecode")]
        public Microsoft.Xrm.Sdk.OptionSetValue ProductTypeCode
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("producttypecode"); }
            set
            {
                this.OnPropertyChanging("ProductTypeCode");
                this.SetAttributeValue("producttypecode", value);
                this.OnPropertyChanged("ProductTypeCode");
            }
        }

        /// <summary>
        /// URL for the Website associated with the product.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("producturl")]
        public string ProductUrl
        {
            get { return this.GetAttributeValue<string>("producturl"); }
            set
            {
                this.OnPropertyChanging("ProductUrl");
                this.SetAttributeValue("producturl", value);
                this.OnPropertyChanged("ProductUrl");
            }
        }

        /// <summary>
        /// Number of decimal places that can be used in monetary amounts for the product.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("quantitydecimal")]
        public System.Nullable<int> QuantityDecimal
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("quantitydecimal"); }
            set
            {
                this.OnPropertyChanging("QuantityDecimal");
                this.SetAttributeValue("quantitydecimal", value);
                this.OnPropertyChanged("QuantityDecimal");
            }
        }

        /// <summary>
        /// Quantity of the product in stock.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("quantityonhand")]
        public System.Nullable<decimal> QuantityOnHand
        {
            get { return this.GetAttributeValue<System.Nullable<decimal>>("quantityonhand"); }
            set
            {
                this.OnPropertyChanging("QuantityOnHand");
                this.SetAttributeValue("quantityonhand", value);
                this.OnPropertyChanged("QuantityOnHand");
            }
        }

        /// <summary>
        /// Product size.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("size")]
        public string Size
        {
            get { return this.GetAttributeValue<string>("size"); }
            set
            {
                this.OnPropertyChanging("Size");
                this.SetAttributeValue("size", value);
                this.OnPropertyChanged("Size");
            }
        }

        /// <summary>
        /// Shows the ID of the stage.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("stageid")]
        public System.Nullable<System.Guid> StageId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("stageid"); }
            set
            {
                this.OnPropertyChanging("StageId");
                this.SetAttributeValue("stageid", value);
                this.OnPropertyChanged("StageId");
            }
        }

        /// <summary>
        /// Standard cost of the product.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("standardcost")]
        public Microsoft.Xrm.Sdk.Money StandardCost
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("standardcost"); }
            set
            {
                this.OnPropertyChanging("StandardCost");
                this.SetAttributeValue("standardcost", value);
                this.OnPropertyChanged("StandardCost");
            }
        }

        /// <summary>
        /// Base currency equivalent of the standard cost of the product.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("standardcost_base")]
        public Microsoft.Xrm.Sdk.Money StandardCost_Base
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("standardcost_base"); }
        }

        /// <summary>
        /// Status of the product.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
        public System.Nullable<ProductState> StateCode
        {
            get
            {
                Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
                if ((optionSet != null))
                {
                    return ((ProductState) (System.Enum.ToObject(typeof(ProductState), optionSet.Value)));
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// Reason for the status of the product.
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
        /// Stock volume of the product.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("stockvolume")]
        public System.Nullable<decimal> StockVolume
        {
            get { return this.GetAttributeValue<System.Nullable<decimal>>("stockvolume"); }
            set
            {
                this.OnPropertyChanging("StockVolume");
                this.SetAttributeValue("stockvolume", value);
                this.OnPropertyChanged("StockVolume");
            }
        }

        /// <summary>
        /// Stock weight of the product.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("stockweight")]
        public System.Nullable<decimal> StockWeight
        {
            get { return this.GetAttributeValue<System.Nullable<decimal>>("stockweight"); }
            set
            {
                this.OnPropertyChanging("StockWeight");
                this.SetAttributeValue("stockweight", value);
                this.OnPropertyChanged("StockWeight");
            }
        }

        /// <summary>
        /// Select a category for the product.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("subjectid")]
        public Microsoft.Xrm.Sdk.EntityReference SubjectId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("subjectid"); }
            set
            {
                this.OnPropertyChanging("SubjectId");
                this.SetAttributeValue("subjectid", value);
                this.OnPropertyChanged("SubjectId");
            }
        }

        /// <summary>
        /// Name of the product's supplier.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("suppliername")]
        public string SupplierName
        {
            get { return this.GetAttributeValue<string>("suppliername"); }
            set
            {
                this.OnPropertyChanging("SupplierName");
                this.SetAttributeValue("suppliername", value);
                this.OnPropertyChanged("SupplierName");
            }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("timezoneruleversionnumber")]
        public System.Nullable<int> TimeZoneRuleVersionNumber
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("timezoneruleversionnumber"); }
            set
            {
                this.OnPropertyChanging("TimeZoneRuleVersionNumber");
                this.SetAttributeValue("timezoneruleversionnumber", value);
                this.OnPropertyChanged("TimeZoneRuleVersionNumber");
            }
        }

        /// <summary>
        /// Unique identifier of the currency associated with the product.
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
        /// A comma separated list of string values representing the unique identifiers of stages in a Business Process Flow Instance in the order that they occur.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("traversedpath")]
        public string TraversedPath
        {
            get { return this.GetAttributeValue<string>("traversedpath"); }
            set
            {
                this.OnPropertyChanging("TraversedPath");
                this.SetAttributeValue("traversedpath", value);
                this.OnPropertyChanged("TraversedPath");
            }
        }

        /// <summary>
        /// Time zone code that was in use when the record was created.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("utcconversiontimezonecode")]
        public System.Nullable<int> UTCConversionTimeZoneCode
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("utcconversiontimezonecode"); }
            set
            {
                this.OnPropertyChanging("UTCConversionTimeZoneCode");
                this.SetAttributeValue("utcconversiontimezonecode", value);
                this.OnPropertyChanged("UTCConversionTimeZoneCode");
            }
        }

        /// <summary>
        /// Date from which this product is valid.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("validfromdate")]
        public System.Nullable<System.DateTime> ValidFromDate
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("validfromdate"); }
            set
            {
                this.OnPropertyChanging("ValidFromDate");
                this.SetAttributeValue("validfromdate", value);
                this.OnPropertyChanged("ValidFromDate");
            }
        }

        /// <summary>
        /// Date to which this product is valid.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("validtodate")]
        public System.Nullable<System.DateTime> ValidToDate
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("validtodate"); }
            set
            {
                this.OnPropertyChanging("ValidToDate");
                this.SetAttributeValue("validtodate", value);
                this.OnPropertyChanged("ValidToDate");
            }
        }

        /// <summary>
        /// Unique identifier of vendor supplying the product.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("vendorid")]
        public string VendorID
        {
            get { return this.GetAttributeValue<string>("vendorid"); }
            set
            {
                this.OnPropertyChanging("VendorID");
                this.SetAttributeValue("vendorid", value);
                this.OnPropertyChanged("VendorID");
            }
        }

        /// <summary>
        /// Name of the product vendor.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("vendorname")]
        public string VendorName
        {
            get { return this.GetAttributeValue<string>("vendorname"); }
            set
            {
                this.OnPropertyChanging("VendorName");
                this.SetAttributeValue("vendorname", value);
                this.OnPropertyChanged("VendorName");
            }
        }

        /// <summary>
        /// Unique part identifier in vendor catalog of this product.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("vendorpartnumber")]
        public string VendorPartNumber
        {
            get { return this.GetAttributeValue<string>("vendorpartnumber"); }
            set
            {
                this.OnPropertyChanging("VendorPartNumber");
                this.SetAttributeValue("vendorpartnumber", value);
                this.OnPropertyChanged("VendorPartNumber");
            }
        }

        /// <summary>
        /// Version number of the product.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
        public System.Nullable<long> VersionNumber
        {
            get { return this.GetAttributeValue<System.Nullable<long>>("versionnumber"); }
        }

        /// <summary>
        /// 1:N opportunity_products
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("opportunity_products")]
        public System.Collections.Generic.IEnumerable<OpportunityProduct> opportunity_products
        {
            get { return this.GetRelatedEntities<OpportunityProduct>("opportunity_products", null); }
            set
            {
                this.OnPropertyChanging("opportunity_products");
                this.SetRelatedEntities<OpportunityProduct>("opportunity_products", null, value);
                this.OnPropertyChanged("opportunity_products");
            }
        }

        /// <summary>
        /// 1:N Product_Annotation
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Product_Annotation")]
        public System.Collections.Generic.IEnumerable<Annotation> Product_Annotation
        {
            get { return this.GetRelatedEntities<Annotation>("Product_Annotation", null); }
            set
            {
                this.OnPropertyChanging("Product_Annotation");
                this.SetRelatedEntities<Annotation>("Product_Annotation", null, value);
                this.OnPropertyChanged("Product_Annotation");
            }
        }

        /// <summary>
        /// 1:N Product_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Product_AsyncOperations")]
        public System.Collections.Generic.IEnumerable<AsyncOperation> Product_AsyncOperations
        {
            get { return this.GetRelatedEntities<AsyncOperation>("Product_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("Product_AsyncOperations");
                this.SetRelatedEntities<AsyncOperation>("Product_AsyncOperations", null, value);
                this.OnPropertyChanged("Product_AsyncOperations");
            }
        }

        /// <summary>
        /// 1:N Product_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Product_BulkDeleteFailures")]
        public System.Collections.Generic.IEnumerable<BulkDeleteFailure> Product_BulkDeleteFailures
        {
            get { return this.GetRelatedEntities<BulkDeleteFailure>("Product_BulkDeleteFailures", null); }
            set
            {
                this.OnPropertyChanging("Product_BulkDeleteFailures");
                this.SetRelatedEntities<BulkDeleteFailure>("Product_BulkDeleteFailures", null, value);
                this.OnPropertyChanged("Product_BulkDeleteFailures");
            }
        }

        /// <summary>
        /// 1:N product_contract_line_items
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("product_contract_line_items")]
        public System.Collections.Generic.IEnumerable<ContractDetail> product_contract_line_items
        {
            get { return this.GetRelatedEntities<ContractDetail>("product_contract_line_items", null); }
            set
            {
                this.OnPropertyChanging("product_contract_line_items");
                this.SetRelatedEntities<ContractDetail>("product_contract_line_items", null, value);
                this.OnPropertyChanged("product_contract_line_items");
            }
        }

        /// <summary>
        /// 1:N Product_DynamicProperty
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Product_DynamicProperty")]
        public System.Collections.Generic.IEnumerable<DynamicProperty> Product_DynamicProperty
        {
            get { return this.GetRelatedEntities<DynamicProperty>("Product_DynamicProperty", null); }
            set
            {
                this.OnPropertyChanging("Product_DynamicProperty");
                this.SetRelatedEntities<DynamicProperty>("Product_DynamicProperty", null, value);
                this.OnPropertyChanged("Product_DynamicProperty");
            }
        }

        /// <summary>
        /// 1:N Product_DynamicPropertyAssociation
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Product_DynamicPropertyAssociation")]
        public System.Collections.Generic.IEnumerable<DynamicPropertyAssociation> Product_DynamicPropertyAssociation
        {
            get { return this.GetRelatedEntities<DynamicPropertyAssociation>("Product_DynamicPropertyAssociation", null); }
            set
            {
                this.OnPropertyChanging("Product_DynamicPropertyAssociation");
                this.SetRelatedEntities<DynamicPropertyAssociation>("Product_DynamicPropertyAssociation", null, value);
                this.OnPropertyChanged("Product_DynamicPropertyAssociation");
            }
        }

        /// <summary>
        /// 1:N product_incidents
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("product_incidents")]
        public System.Collections.Generic.IEnumerable<Incident> product_incidents
        {
            get { return this.GetRelatedEntities<Incident>("product_incidents", null); }
            set
            {
                this.OnPropertyChanging("product_incidents");
                this.SetRelatedEntities<Incident>("product_incidents", null, value);
                this.OnPropertyChanged("product_incidents");
            }
        }

        /// <summary>
        /// 1:N product_invoice_details
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("product_invoice_details")]
        public System.Collections.Generic.IEnumerable<InvoiceDetail> product_invoice_details
        {
            get { return this.GetRelatedEntities<InvoiceDetail>("product_invoice_details", null); }
            set
            {
                this.OnPropertyChanging("product_invoice_details");
                this.SetRelatedEntities<InvoiceDetail>("product_invoice_details", null, value);
                this.OnPropertyChanged("product_invoice_details");
            }
        }

        /// <summary>
        /// 1:N product_order_details
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("product_order_details")]
        public System.Collections.Generic.IEnumerable<SalesOrderDetail> product_order_details
        {
            get { return this.GetRelatedEntities<SalesOrderDetail>("product_order_details", null); }
            set
            {
                this.OnPropertyChanging("product_order_details");
                this.SetRelatedEntities<SalesOrderDetail>("product_order_details", null, value);
                this.OnPropertyChanged("product_order_details");
            }
        }

        /// <summary>
        /// 1:N product_parent_product
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("product_parent_product", Microsoft.Xrm.Sdk.EntityRole.Referenced)]
        public System.Collections.Generic.IEnumerable<Product> Referencedproduct_parent_product
        {
            get { return this.GetRelatedEntities<Product>("product_parent_product", Microsoft.Xrm.Sdk.EntityRole.Referenced); }
            set
            {
                this.OnPropertyChanging("Referencedproduct_parent_product");
                this.SetRelatedEntities<Product>("product_parent_product", Microsoft.Xrm.Sdk.EntityRole.Referenced, value);
                this.OnPropertyChanged("Referencedproduct_parent_product");
            }
        }

        /// <summary>
        /// 1:N product_price_levels
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("product_price_levels")]
        public System.Collections.Generic.IEnumerable<ProductPriceLevel> product_price_levels
        {
            get { return this.GetRelatedEntities<ProductPriceLevel>("product_price_levels", null); }
            set
            {
                this.OnPropertyChanging("product_price_levels");
                this.SetRelatedEntities<ProductPriceLevel>("product_price_levels", null, value);
                this.OnPropertyChanged("product_price_levels");
            }
        }

        /// <summary>
        /// 1:N product_principalobjectattributeaccess
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("product_principalobjectattributeaccess")]
        public System.Collections.Generic.IEnumerable<PrincipalObjectAttributeAccess> product_principalobjectattributeaccess
        {
            get { return this.GetRelatedEntities<PrincipalObjectAttributeAccess>("product_principalobjectattributeaccess", null); }
            set
            {
                this.OnPropertyChanging("product_principalobjectattributeaccess");
                this.SetRelatedEntities<PrincipalObjectAttributeAccess>("product_principalobjectattributeaccess", null, value);
                this.OnPropertyChanged("product_principalobjectattributeaccess");
            }
        }

        /// <summary>
        /// 1:N Product_ProcessSessions
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Product_ProcessSessions")]
        public System.Collections.Generic.IEnumerable<ProcessSession> Product_ProcessSessions
        {
            get { return this.GetRelatedEntities<ProcessSession>("Product_ProcessSessions", null); }
            set
            {
                this.OnPropertyChanging("Product_ProcessSessions");
                this.SetRelatedEntities<ProcessSession>("Product_ProcessSessions", null, value);
                this.OnPropertyChanged("Product_ProcessSessions");
            }
        }

        /// <summary>
        /// 1:N Product_ProductAssociation_AssocProd
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Product_ProductAssociation_AssocProd")]
        public System.Collections.Generic.IEnumerable<ProductAssociation> Product_ProductAssociation_AssocProd
        {
            get { return this.GetRelatedEntities<ProductAssociation>("Product_ProductAssociation_AssocProd", null); }
            set
            {
                this.OnPropertyChanging("Product_ProductAssociation_AssocProd");
                this.SetRelatedEntities<ProductAssociation>("Product_ProductAssociation_AssocProd", null, value);
                this.OnPropertyChanged("Product_ProductAssociation_AssocProd");
            }
        }

        /// <summary>
        /// 1:N Product_ProductAssociation_Prod
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Product_ProductAssociation_Prod")]
        public System.Collections.Generic.IEnumerable<ProductAssociation> Product_ProductAssociation_Prod
        {
            get { return this.GetRelatedEntities<ProductAssociation>("Product_ProductAssociation_Prod", null); }
            set
            {
                this.OnPropertyChanging("Product_ProductAssociation_Prod");
                this.SetRelatedEntities<ProductAssociation>("Product_ProductAssociation_Prod", null, value);
                this.OnPropertyChanged("Product_ProductAssociation_Prod");
            }
        }

        /// <summary>
        /// 1:N product_ProductSubstitute_productid
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("product_ProductSubstitute_productid")]
        public System.Collections.Generic.IEnumerable<ProductSubstitute> product_ProductSubstitute_productid
        {
            get { return this.GetRelatedEntities<ProductSubstitute>("product_ProductSubstitute_productid", null); }
            set
            {
                this.OnPropertyChanging("product_ProductSubstitute_productid");
                this.SetRelatedEntities<ProductSubstitute>("product_ProductSubstitute_productid", null, value);
                this.OnPropertyChanged("product_ProductSubstitute_productid");
            }
        }

        /// <summary>
        /// 1:N product_ProductSubstitute_substitutedproductid
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("product_ProductSubstitute_substitutedproductid")]
        public System.Collections.Generic.IEnumerable<ProductSubstitute> product_ProductSubstitute_substitutedproductid
        {
            get { return this.GetRelatedEntities<ProductSubstitute>("product_ProductSubstitute_substitutedproductid", null); }
            set
            {
                this.OnPropertyChanging("product_ProductSubstitute_substitutedproductid");
                this.SetRelatedEntities<ProductSubstitute>("product_ProductSubstitute_substitutedproductid", null, value);
                this.OnPropertyChanged("product_ProductSubstitute_substitutedproductid");
            }
        }

        /// <summary>
        /// 1:N product_quote_details
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("product_quote_details")]
        public System.Collections.Generic.IEnumerable<QuoteDetail> product_quote_details
        {
            get { return this.GetRelatedEntities<QuoteDetail>("product_quote_details", null); }
            set
            {
                this.OnPropertyChanging("product_quote_details");
                this.SetRelatedEntities<QuoteDetail>("product_quote_details", null, value);
                this.OnPropertyChanged("product_quote_details");
            }
        }

        /// <summary>
        /// 1:N Product_SharepointDocument
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Product_SharepointDocument")]
        public System.Collections.Generic.IEnumerable<SharePointDocument> Product_SharepointDocument
        {
            get { return this.GetRelatedEntities<SharePointDocument>("Product_SharepointDocument", null); }
            set
            {
                this.OnPropertyChanging("Product_SharepointDocument");
                this.SetRelatedEntities<SharePointDocument>("Product_SharepointDocument", null, value);
                this.OnPropertyChanged("Product_SharepointDocument");
            }
        }

        /// <summary>
        /// 1:N Product_SharepointDocumentLocation
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Product_SharepointDocumentLocation")]
        public System.Collections.Generic.IEnumerable<SharePointDocumentLocation> Product_SharepointDocumentLocation
        {
            get { return this.GetRelatedEntities<SharePointDocumentLocation>("Product_SharepointDocumentLocation", null); }
            set
            {
                this.OnPropertyChanging("Product_SharepointDocumentLocation");
                this.SetRelatedEntities<SharePointDocumentLocation>("Product_SharepointDocumentLocation", null, value);
                this.OnPropertyChanged("Product_SharepointDocumentLocation");
            }
        }

        /// <summary>
        /// 1:N userentityinstancedata_product
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_product")]
        public System.Collections.Generic.IEnumerable<UserEntityInstanceData> userentityinstancedata_product
        {
            get { return this.GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_product", null); }
            set
            {
                this.OnPropertyChanging("userentityinstancedata_product");
                this.SetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_product", null, value);
                this.OnPropertyChanged("userentityinstancedata_product");
            }
        }

        /// <summary>
        /// N:N campaignproduct_association
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("campaignproduct_association")]
        public System.Collections.Generic.IEnumerable<Campaign> campaignproduct_association
        {
            get { return this.GetRelatedEntities<Campaign>("campaignproduct_association", null); }
            set
            {
                this.OnPropertyChanging("campaignproduct_association");
                this.SetRelatedEntities<Campaign>("campaignproduct_association", null, value);
                this.OnPropertyChanged("campaignproduct_association");
            }
        }

        /// <summary>
        /// N:N competitorproduct_association
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("competitorproduct_association")]
        public System.Collections.Generic.IEnumerable<Competitor> competitorproduct_association
        {
            get { return this.GetRelatedEntities<Competitor>("competitorproduct_association", null); }
            set
            {
                this.OnPropertyChanging("competitorproduct_association");
                this.SetRelatedEntities<Competitor>("competitorproduct_association", null, value);
                this.OnPropertyChanged("competitorproduct_association");
            }
        }

        /// <summary>
        /// N:N leadproduct_association
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("leadproduct_association")]
        public System.Collections.Generic.IEnumerable<Lead> leadproduct_association
        {
            get { return this.GetRelatedEntities<Lead>("leadproduct_association", null); }
            set
            {
                this.OnPropertyChanging("leadproduct_association");
                this.SetRelatedEntities<Lead>("leadproduct_association", null, value);
                this.OnPropertyChanged("leadproduct_association");
            }
        }

        /// <summary>
        /// N:N product_entitlement_association
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("product_entitlement_association")]
        public System.Collections.Generic.IEnumerable<Entitlement> product_entitlement_association
        {
            get { return this.GetRelatedEntities<Entitlement>("product_entitlement_association", null); }
            set
            {
                this.OnPropertyChanging("product_entitlement_association");
                this.SetRelatedEntities<Entitlement>("product_entitlement_association", null, value);
                this.OnPropertyChanged("product_entitlement_association");
            }
        }

        /// <summary>
        /// N:N product_entitlementtemplate_association
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("product_entitlementtemplate_association")]
        public System.Collections.Generic.IEnumerable<EntitlementTemplate> product_entitlementtemplate_association
        {
            get { return this.GetRelatedEntities<EntitlementTemplate>("product_entitlementtemplate_association", null); }
            set
            {
                this.OnPropertyChanging("product_entitlementtemplate_association");
                this.SetRelatedEntities<EntitlementTemplate>("product_entitlementtemplate_association", null, value);
                this.OnPropertyChanged("product_entitlementtemplate_association");
            }
        }

        /// <summary>
        /// N:N productsalesliterature_association
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("productsalesliterature_association")]
        public System.Collections.Generic.IEnumerable<SalesLiterature> productsalesliterature_association
        {
            get { return this.GetRelatedEntities<SalesLiterature>("productsalesliterature_association", null); }
            set
            {
                this.OnPropertyChanging("productsalesliterature_association");
                this.SetRelatedEntities<SalesLiterature>("productsalesliterature_association", null, value);
                this.OnPropertyChanged("productsalesliterature_association");
            }
        }

        /// <summary>
        /// N:1 lk_product_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_product_createdonbehalfby")]
        public SystemUser lk_product_createdonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_product_createdonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_product_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_product_modifiedonbehalfby")]
        public SystemUser lk_product_modifiedonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_product_modifiedonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_productbase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_productbase_createdby")]
        public SystemUser lk_productbase_createdby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_productbase_createdby", null); }
        }

        /// <summary>
        /// N:1 lk_productbase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_productbase_modifiedby")]
        public SystemUser lk_productbase_modifiedby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_productbase_modifiedby", null); }
        }

        /// <summary>
        /// N:1 organization_products
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_products")]
        public Organization organization_products
        {
            get { return this.GetRelatedEntity<Organization>("organization_products", null); }
        }

        /// <summary>
        /// N:1 price_level_products
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("pricelevelid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("price_level_products")]
        public PriceLevel price_level_products
        {
            get { return this.GetRelatedEntity<PriceLevel>("price_level_products", null); }
            set
            {
                this.OnPropertyChanging("price_level_products");
                this.SetRelatedEntity<PriceLevel>("price_level_products", null, value);
                this.OnPropertyChanged("price_level_products");
            }
        }

        /// <summary>
        /// N:1 processstage_products
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("stageid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("processstage_products")]
        public ProcessStage processstage_products
        {
            get { return this.GetRelatedEntity<ProcessStage>("processstage_products", null); }
            set
            {
                this.OnPropertyChanging("processstage_products");
                this.SetRelatedEntity<ProcessStage>("processstage_products", null, value);
                this.OnPropertyChanged("processstage_products");
            }
        }

        /// <summary>
        /// N:1 product_parent_product
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("parentproductid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("product_parent_product", Microsoft.Xrm.Sdk.EntityRole.Referencing)]
        public Product Referencingproduct_parent_product
        {
            get { return this.GetRelatedEntity<Product>("product_parent_product", Microsoft.Xrm.Sdk.EntityRole.Referencing); }
            set
            {
                this.OnPropertyChanging("Referencingproduct_parent_product");
                this.SetRelatedEntity<Product>("product_parent_product", Microsoft.Xrm.Sdk.EntityRole.Referencing, value);
                this.OnPropertyChanged("Referencingproduct_parent_product");
            }
        }

        /// <summary>
        /// N:1 subject_products
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("subjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("subject_products")]
        public Subject subject_products
        {
            get { return this.GetRelatedEntity<Subject>("subject_products", null); }
            set
            {
                this.OnPropertyChanging("subject_products");
                this.SetRelatedEntity<Subject>("subject_products", null, value);
                this.OnPropertyChanged("subject_products");
            }
        }

        /// <summary>
        /// N:1 transactioncurrency_product
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("transactioncurrency_product")]
        public TransactionCurrency transactioncurrency_product
        {
            get { return this.GetRelatedEntity<TransactionCurrency>("transactioncurrency_product", null); }
            set
            {
                this.OnPropertyChanging("transactioncurrency_product");
                this.SetRelatedEntity<TransactionCurrency>("transactioncurrency_product", null, value);
                this.OnPropertyChanged("transactioncurrency_product");
            }
        }

        /// <summary>
        /// N:1 unit_of_measurement_products
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("defaultuomid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("unit_of_measurement_products")]
        public UoM unit_of_measurement_products
        {
            get { return this.GetRelatedEntity<UoM>("unit_of_measurement_products", null); }
            set
            {
                this.OnPropertyChanging("unit_of_measurement_products");
                this.SetRelatedEntity<UoM>("unit_of_measurement_products", null, value);
                this.OnPropertyChanged("unit_of_measurement_products");
            }
        }

        /// <summary>
        /// N:1 unit_of_measurement_schedule_products
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("defaultuomscheduleid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("unit_of_measurement_schedule_products")]
        public UoMSchedule unit_of_measurement_schedule_products
        {
            get { return this.GetRelatedEntity<UoMSchedule>("unit_of_measurement_schedule_products", null); }
            set
            {
                this.OnPropertyChanging("unit_of_measurement_schedule_products");
                this.SetRelatedEntity<UoMSchedule>("unit_of_measurement_schedule_products", null, value);
                this.OnPropertyChanged("unit_of_measurement_schedule_products");
            }
        }
    }
}