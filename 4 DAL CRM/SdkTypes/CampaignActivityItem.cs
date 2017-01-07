namespace __4_DAL_CRM
{
    /// <summary>
    /// Work item of a campaign activity, such as a list or sales literature.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("campaignactivityitem")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class CampaignActivityItem : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public CampaignActivityItem() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "campaignactivityitem";

        public const int EntityTypeCode = 4404;

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
        /// Unique identifier of the campaign activity for the item.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("campaignactivityid")]
        public Microsoft.Xrm.Sdk.EntityReference CampaignActivityId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("campaignactivityid"); }
            set
            {
                this.OnPropertyChanging("CampaignActivityId");
                this.SetAttributeValue("campaignactivityid", value);
                this.OnPropertyChanged("CampaignActivityId");
            }
        }

        /// <summary>
        /// Unique identifier of the campaign activity item.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("campaignactivityitemid")]
        public System.Nullable<System.Guid> CampaignActivityItemId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("campaignactivityitemid"); }
            set
            {
                this.OnPropertyChanging("CampaignActivityItemId");
                this.SetAttributeValue("campaignactivityitemid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("CampaignActivityItemId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("campaignactivityitemid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.CampaignActivityItemId = value; }
        }

        /// <summary>
        /// Unique identifier of the item.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("itemid")]
        public System.Nullable<System.Guid> ItemId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("itemid"); }
            set
            {
                this.OnPropertyChanging("ItemId");
                this.SetAttributeValue("itemid", value);
                this.OnPropertyChanged("ItemId");
            }
        }

        /// <summary>
        /// Identification of the type of the campaign activity item.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("itemobjecttypecode")]
        public string ItemObjectTypeCode
        {
            get { return this.GetAttributeValue<string>("itemobjecttypecode"); }
            set
            {
                this.OnPropertyChanging("ItemObjectTypeCode");
                this.SetAttributeValue("itemobjecttypecode", value);
                this.OnPropertyChanged("ItemObjectTypeCode");
            }
        }

        /// <summary>
        /// Unique identifier of the user or team who owns the campaign activity item.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ownerid")]
        public Microsoft.Xrm.Sdk.EntityReference OwnerId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("ownerid"); }
        }

        /// <summary>
        /// Unique identifier of the business unit that owns the campaign activity item.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
        public System.Nullable<System.Guid> OwningBusinessUnit
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("owningbusinessunit"); }
        }

        /// <summary>
        /// Unique identifier of the user that owns the campaign activity item.
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
        /// 1:N userentityinstancedata_campaignactivityitem
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_campaignactivityitem")]
        public System.Collections.Generic.IEnumerable<UserEntityInstanceData> userentityinstancedata_campaignactivityitem
        {
            get { return this.GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_campaignactivityitem", null); }
            set
            {
                this.OnPropertyChanging("userentityinstancedata_campaignactivityitem");
                this.SetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_campaignactivityitem", null, value);
                this.OnPropertyChanged("userentityinstancedata_campaignactivityitem");
            }
        }

        /// <summary>
        /// N:N campaignactivitylist_association
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("campaignactivitylist_association")]
        public System.Collections.Generic.IEnumerable<CampaignActivity> campaignactivitylist_association
        {
            get { return this.GetRelatedEntities<CampaignActivity>("campaignactivitylist_association", null); }
            set
            {
                this.OnPropertyChanging("campaignactivitylist_association");
                this.SetRelatedEntities<CampaignActivity>("campaignactivitylist_association", null, value);
                this.OnPropertyChanged("campaignactivitylist_association");
            }
        }

        /// <summary>
        /// N:N campaignactivitysalesliterature_association
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("campaignactivitysalesliterature_association")]
        public System.Collections.Generic.IEnumerable<CampaignActivity> campaignactivitysalesliterature_association
        {
            get { return this.GetRelatedEntities<CampaignActivity>("campaignactivitysalesliterature_association", null); }
            set
            {
                this.OnPropertyChanging("campaignactivitysalesliterature_association");
                this.SetRelatedEntities<CampaignActivity>("campaignactivitysalesliterature_association", null, value);
                this.OnPropertyChanged("campaignactivitysalesliterature_association");
            }
        }

        /// <summary>
        /// N:1 ActivityPointer_CampaignActivityItems
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("campaignactivityid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ActivityPointer_CampaignActivityItems")]
        public ActivityPointer ActivityPointer_CampaignActivityItems
        {
            get { return this.GetRelatedEntity<ActivityPointer>("ActivityPointer_CampaignActivityItems", null); }
            set
            {
                this.OnPropertyChanging("ActivityPointer_CampaignActivityItems");
                this.SetRelatedEntity<ActivityPointer>("ActivityPointer_CampaignActivityItems", null, value);
                this.OnPropertyChanged("ActivityPointer_CampaignActivityItems");
            }
        }
    }
}