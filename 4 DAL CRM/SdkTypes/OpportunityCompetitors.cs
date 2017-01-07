namespace __4_DAL_CRM
{
    /// <summary>
    /// 
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("opportunitycompetitors")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class OpportunityCompetitors : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public OpportunityCompetitors() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "opportunitycompetitors";

        public const int EntityTypeCode = 25;

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
        /// Unique identifier of the opportunity competitor.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("opportunitycompetitorid")]
        public System.Nullable<System.Guid> OpportunityCompetitorId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("opportunitycompetitorid"); }
            set
            {
                this.OnPropertyChanging("OpportunityCompetitorId");
                this.SetAttributeValue("opportunitycompetitorid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("OpportunityCompetitorId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("opportunitycompetitorid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.OpportunityCompetitorId = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("opportunityid")]
        public System.Nullable<System.Guid> OpportunityId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("opportunityid"); }
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
        /// N:N opportunitycompetitors_association
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("opportunitycompetitors_association")]
        public System.Collections.Generic.IEnumerable<Opportunity> opportunitycompetitors_association
        {
            get { return this.GetRelatedEntities<Opportunity>("opportunitycompetitors_association", null); }
            set
            {
                this.OnPropertyChanging("opportunitycompetitors_association");
                this.SetRelatedEntities<Opportunity>("opportunitycompetitors_association", null, value);
                this.OnPropertyChanged("opportunitycompetitors_association");
            }
        }
    }
}