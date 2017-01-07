namespace __4_DAL_CRM
{
    /// <summary>
    /// 
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("productsalesliterature")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class ProductSalesLiterature : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public ProductSalesLiterature() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "productsalesliterature";

        public const int EntityTypeCode = 21;

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
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("productid")]
        public System.Nullable<System.Guid> ProductId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("productid"); }
        }

        /// <summary>
        /// Unique identifier of the product sales literature associated with this price list.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("productsalesliteratureid")]
        public System.Nullable<System.Guid> ProductSalesLiteratureId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("productsalesliteratureid"); }
            set
            {
                this.OnPropertyChanging("ProductSalesLiteratureId");
                this.SetAttributeValue("productsalesliteratureid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("ProductSalesLiteratureId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("productsalesliteratureid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.ProductSalesLiteratureId = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("salesliteratureid")]
        public System.Nullable<System.Guid> SalesLiteratureId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("salesliteratureid"); }
        }

        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
        public System.Nullable<long> VersionNumber
        {
            get { return this.GetAttributeValue<System.Nullable<long>>("versionnumber"); }
        }

        /// <summary>
        /// 1:N userentityinstancedata_productsalesliterature
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_productsalesliterature")]
        public System.Collections.Generic.IEnumerable<UserEntityInstanceData> userentityinstancedata_productsalesliterature
        {
            get { return this.GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_productsalesliterature", null); }
            set
            {
                this.OnPropertyChanging("userentityinstancedata_productsalesliterature");
                this.SetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_productsalesliterature", null, value);
                this.OnPropertyChanged("userentityinstancedata_productsalesliterature");
            }
        }

        /// <summary>
        /// N:N productsalesliterature_association
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("productsalesliterature_association")]
        public System.Collections.Generic.IEnumerable<Product> productsalesliterature_association
        {
            get { return this.GetRelatedEntities<Product>("productsalesliterature_association", null); }
            set
            {
                this.OnPropertyChanging("productsalesliterature_association");
                this.SetRelatedEntities<Product>("productsalesliterature_association", null, value);
                this.OnPropertyChanged("productsalesliterature_association");
            }
        }
    }
}