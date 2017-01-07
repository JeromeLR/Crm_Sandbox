namespace __4_DAL_CRM
{
    /// <summary>
    /// 
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("competitorsalesliterature")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class CompetitorSalesLiterature : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public CompetitorSalesLiterature() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "competitorsalesliterature";

        public const int EntityTypeCode = 26;

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
        /// Unique identifier of the sales literature for the competitor product.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("competitorsalesliteratureid")]
        public System.Nullable<System.Guid> CompetitorSalesLiteratureId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("competitorsalesliteratureid"); }
            set
            {
                this.OnPropertyChanging("CompetitorSalesLiteratureId");
                this.SetAttributeValue("competitorsalesliteratureid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("CompetitorSalesLiteratureId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("competitorsalesliteratureid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.CompetitorSalesLiteratureId = value; }
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
        /// 1:N userentityinstancedata_competitorsalesliterature
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_competitorsalesliterature")]
        public System.Collections.Generic.IEnumerable<UserEntityInstanceData> userentityinstancedata_competitorsalesliterature
        {
            get { return this.GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_competitorsalesliterature", null); }
            set
            {
                this.OnPropertyChanging("userentityinstancedata_competitorsalesliterature");
                this.SetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_competitorsalesliterature", null, value);
                this.OnPropertyChanged("userentityinstancedata_competitorsalesliterature");
            }
        }

        /// <summary>
        /// N:N competitorsalesliterature_association
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("competitorsalesliterature_association")]
        public System.Collections.Generic.IEnumerable<SalesLiterature> competitorsalesliterature_association
        {
            get { return this.GetRelatedEntities<SalesLiterature>("competitorsalesliterature_association", null); }
            set
            {
                this.OnPropertyChanging("competitorsalesliterature_association");
                this.SetRelatedEntities<SalesLiterature>("competitorsalesliterature_association", null, value);
                this.OnPropertyChanged("competitorsalesliterature_association");
            }
        }
    }
}