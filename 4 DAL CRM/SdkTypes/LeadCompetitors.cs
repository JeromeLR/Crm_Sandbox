namespace __4_DAL_CRM
{
    /// <summary>
    /// 
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("leadcompetitors")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class LeadCompetitors : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public LeadCompetitors() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "leadcompetitors";

        public const int EntityTypeCode = 24;

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
        /// Unique identifier of the lead competitor.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("leadcompetitorid")]
        public System.Nullable<System.Guid> LeadCompetitorId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("leadcompetitorid"); }
            set
            {
                this.OnPropertyChanging("LeadCompetitorId");
                this.SetAttributeValue("leadcompetitorid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("LeadCompetitorId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("leadcompetitorid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.LeadCompetitorId = value; }
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
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
        public System.Nullable<long> VersionNumber
        {
            get { return this.GetAttributeValue<System.Nullable<long>>("versionnumber"); }
        }

        /// <summary>
        /// N:N leadcompetitors_association
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("leadcompetitors_association")]
        public System.Collections.Generic.IEnumerable<Lead> leadcompetitors_association
        {
            get { return this.GetRelatedEntities<Lead>("leadcompetitors_association", null); }
            set
            {
                this.OnPropertyChanging("leadcompetitors_association");
                this.SetRelatedEntities<Lead>("leadcompetitors_association", null, value);
                this.OnPropertyChanged("leadcompetitors_association");
            }
        }
    }
}