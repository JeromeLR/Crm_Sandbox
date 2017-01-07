namespace __4_DAL_CRM
{
    /// <summary>
    /// 
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("leadproduct")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class LeadProduct : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public LeadProduct() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "leadproduct";

        public const int EntityTypeCode = 27;

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
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("leadid")]
        public System.Nullable<System.Guid> LeadId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("leadid"); }
        }

        /// <summary>
        /// Unique identifier of the lead product.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("leadproductid")]
        public System.Nullable<System.Guid> LeadProductId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("leadproductid"); }
            set
            {
                this.OnPropertyChanging("LeadProductId");
                this.SetAttributeValue("leadproductid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("LeadProductId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("leadproductid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.LeadProductId = value; }
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
        /// 1:N userentityinstancedata_leadproduct
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_leadproduct")]
        public System.Collections.Generic.IEnumerable<UserEntityInstanceData> userentityinstancedata_leadproduct
        {
            get { return this.GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_leadproduct", null); }
            set
            {
                this.OnPropertyChanging("userentityinstancedata_leadproduct");
                this.SetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_leadproduct", null, value);
                this.OnPropertyChanged("userentityinstancedata_leadproduct");
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
    }
}