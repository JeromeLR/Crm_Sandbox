namespace __4_DAL_CRM
{
    /// <summary>
    /// Work item in a campaign, a list or sales literature.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("campaignitem")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class CampaignItem : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public CampaignItem() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "campaignitem";

        public const int EntityTypeCode = 4403;

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
        /// Unique identifier of the campaign that is associated with the individual item.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("campaignid")]
        public Microsoft.Xrm.Sdk.EntityReference CampaignId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("campaignid"); }
            set
            {
                this.OnPropertyChanging("CampaignId");
                this.SetAttributeValue("campaignid", value);
                this.OnPropertyChanged("CampaignId");
            }
        }

        /// <summary>
        /// Unique identifier of the campaign item.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("campaignitemid")]
        public System.Nullable<System.Guid> CampaignItemId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("campaignitemid"); }
            set
            {
                this.OnPropertyChanging("CampaignItemId");
                this.SetAttributeValue("campaignitemid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("CampaignItemId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("campaignitemid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.CampaignItemId = value; }
        }

        /// <summary>
        /// Unique identifier of the entity for the campaign item.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entityid")]
        public System.Nullable<System.Guid> EntityId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("entityid"); }
            set
            {
                this.OnPropertyChanging("EntityId");
                this.SetAttributeValue("entityid", value);
                this.OnPropertyChanged("EntityId");
            }
        }

        /// <summary>
        /// Object type of entity for the campaign item.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entitytype")]
        public string EntityType
        {
            get { return this.GetAttributeValue<string>("entitytype"); }
            set
            {
                this.OnPropertyChanging("EntityType");
                this.SetAttributeValue("entitytype", value);
                this.OnPropertyChanged("EntityType");
            }
        }

        /// <summary>
        /// Unique identifier of the user or team who owns the campaign item.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ownerid")]
        public Microsoft.Xrm.Sdk.EntityReference OwnerId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("ownerid"); }
        }

        /// <summary>
        /// Unique identifier of the business unit that owns the campaign item.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
        public System.Nullable<System.Guid> OwningBusinessUnit
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("owningbusinessunit"); }
        }

        /// <summary>
        /// Unique identifier of the user that owns the campaign item.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
        public System.Nullable<System.Guid> OwningUser
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("owninguser"); }
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
        /// 1:N userentityinstancedata_campaignitem
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_campaignitem")]
        public System.Collections.Generic.IEnumerable<UserEntityInstanceData> userentityinstancedata_campaignitem
        {
            get { return this.GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_campaignitem", null); }
            set
            {
                this.OnPropertyChanging("userentityinstancedata_campaignitem");
                this.SetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_campaignitem", null, value);
                this.OnPropertyChanged("userentityinstancedata_campaignitem");
            }
        }

        /// <summary>
        /// N:N campaigncampaign_association
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("campaigncampaign_association")]
        public System.Collections.Generic.IEnumerable<Campaign> campaigncampaign_association
        {
            get { return this.GetRelatedEntities<Campaign>("campaigncampaign_association", null); }
            set
            {
                this.OnPropertyChanging("campaigncampaign_association");
                this.SetRelatedEntities<Campaign>("campaigncampaign_association", null, value);
                this.OnPropertyChanged("campaigncampaign_association");
            }
        }

        /// <summary>
        /// N:N campaignlist_association
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("campaignlist_association")]
        public System.Collections.Generic.IEnumerable<Campaign> campaignlist_association
        {
            get { return this.GetRelatedEntities<Campaign>("campaignlist_association", null); }
            set
            {
                this.OnPropertyChanging("campaignlist_association");
                this.SetRelatedEntities<Campaign>("campaignlist_association", null, value);
                this.OnPropertyChanged("campaignlist_association");
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
        /// N:N campaignsalesliterature_association
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("campaignsalesliterature_association")]
        public System.Collections.Generic.IEnumerable<Campaign> campaignsalesliterature_association
        {
            get { return this.GetRelatedEntities<Campaign>("campaignsalesliterature_association", null); }
            set
            {
                this.OnPropertyChanging("campaignsalesliterature_association");
                this.SetRelatedEntities<Campaign>("campaignsalesliterature_association", null, value);
                this.OnPropertyChanged("campaignsalesliterature_association");
            }
        }
    }
}