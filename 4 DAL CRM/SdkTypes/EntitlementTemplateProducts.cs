namespace __4_DAL_CRM
{
    /// <summary>
    /// 
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("entitlementtemplateproducts")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class EntitlementTemplateProducts : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public EntitlementTemplateProducts() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "entitlementtemplateproducts";

        public const int EntityTypeCode = 4545;

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
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entitlementtemplateid")]
        public System.Nullable<System.Guid> EntitlementTemplateId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("entitlementtemplateid"); }
        }

        /// <summary>
        /// Unique identifier of the contacts for the EntitlementTemplates.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entitlementtemplateproductid")]
        public System.Nullable<System.Guid> EntitlementTemplateProductId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("entitlementtemplateproductid"); }
            set
            {
                this.OnPropertyChanging("EntitlementTemplateProductId");
                this.SetAttributeValue("entitlementtemplateproductid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("EntitlementTemplateProductId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entitlementtemplateproductid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.EntitlementTemplateProductId = value; }
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
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
        public System.Nullable<long> VersionNumber
        {
            get { return this.GetAttributeValue<System.Nullable<long>>("versionnumber"); }
        }

        /// <summary>
        /// N:N product_entitlementtemplate_association
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("product_entitlementtemplate_association")]
        public System.Collections.Generic.IEnumerable<Product> product_entitlementtemplate_association
        {
            get { return this.GetRelatedEntities<Product>("product_entitlementtemplate_association", null); }
            set
            {
                this.OnPropertyChanging("product_entitlementtemplate_association");
                this.SetRelatedEntities<Product>("product_entitlementtemplate_association", null, value);
                this.OnPropertyChanged("product_entitlementtemplate_association");
            }
        }
    }
}