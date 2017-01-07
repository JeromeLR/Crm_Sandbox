namespace __4_DAL_CRM
{
    /// <summary>
    /// Association between a competitor and a product offered by the competitor.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("competitorproduct")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class CompetitorProduct : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public CompetitorProduct() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "competitorproduct";

        public const int EntityTypeCode = 1006;

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
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("competitorid")]
        public System.Nullable<System.Guid> CompetitorId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("competitorid"); }
        }

        /// <summary>
        /// Unique identifier of the competitor product.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("competitorproductid")]
        public System.Nullable<System.Guid> CompetitorProductId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("competitorproductid"); }
            set
            {
                this.OnPropertyChanging("CompetitorProductId");
                this.SetAttributeValue("competitorproductid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("CompetitorProductId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("competitorproductid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.CompetitorProductId = value; }
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
        /// 1:N userentityinstancedata_competitorproduct
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_competitorproduct")]
        public System.Collections.Generic.IEnumerable<UserEntityInstanceData> userentityinstancedata_competitorproduct
        {
            get { return this.GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_competitorproduct", null); }
            set
            {
                this.OnPropertyChanging("userentityinstancedata_competitorproduct");
                this.SetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_competitorproduct", null, value);
                this.OnPropertyChanged("userentityinstancedata_competitorproduct");
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
    }
}