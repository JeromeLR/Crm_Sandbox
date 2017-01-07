namespace __4_DAL_CRM
{
    /// <summary>
    /// 
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("entitlementproducts")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class EntitlementProducts : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public EntitlementProducts() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "entitlementproducts";

        public const int EntityTypeCode = 6363;

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
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entitlementid")]
        public System.Nullable<System.Guid> EntitlementId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("entitlementid"); }
        }

        /// <summary>
        /// Unique identifier of the contacts for the entitlements.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entitlementproductid")]
        public System.Nullable<System.Guid> EntitlementProductId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("entitlementproductid"); }
            set
            {
                this.OnPropertyChanging("EntitlementProductId");
                this.SetAttributeValue("entitlementproductid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("EntitlementProductId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entitlementproductid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.EntitlementProductId = value; }
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
        /// N:N product_entitlement_association
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("product_entitlement_association")]
        public System.Collections.Generic.IEnumerable<Product> product_entitlement_association
        {
            get { return this.GetRelatedEntities<Product>("product_entitlement_association", null); }
            set
            {
                this.OnPropertyChanging("product_entitlement_association");
                this.SetRelatedEntities<Product>("product_entitlement_association", null, value);
                this.OnPropertyChanged("product_entitlement_association");
            }
        }
    }
}