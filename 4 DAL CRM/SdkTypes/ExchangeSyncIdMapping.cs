namespace __4_DAL_CRM
{
    /// <summary>
    /// The mapping used to keep track of the IDs for items synced between CRM and Exchange.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("exchangesyncidmapping")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class ExchangeSyncIdMapping : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public ExchangeSyncIdMapping() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "exchangesyncidmapping";

        public const int EntityTypeCode = 4120;

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
        /// Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics CRM options.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
        public System.Nullable<System.DateTime> CreatedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon"); }
        }

        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("exchangeentryid")]
        public string ExchangeEntryId
        {
            get { return this.GetAttributeValue<string>("exchangeentryid"); }
            set
            {
                this.OnPropertyChanging("ExchangeEntryId");
                this.SetAttributeValue("exchangeentryid", value);
                this.OnPropertyChanged("ExchangeEntryId");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("exchangesyncidmappingid")]
        public System.Nullable<System.Guid> ExchangeSyncIdmappingId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("exchangesyncidmappingid"); }
            set
            {
                this.OnPropertyChanging("ExchangeSyncIdmappingId");
                this.SetAttributeValue("exchangesyncidmappingid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("ExchangeSyncIdmappingId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("exchangesyncidmappingid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.ExchangeSyncIdmappingId = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("fromcrmchangetype")]
        public System.Nullable<int> FromCrmChangeType
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("fromcrmchangetype"); }
            set
            {
                this.OnPropertyChanging("FromCrmChangeType");
                this.SetAttributeValue("fromcrmchangetype", value);
                this.OnPropertyChanged("FromCrmChangeType");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isdeletedinexchange")]
        public System.Nullable<bool> IsDeletedInExchange
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("isdeletedinexchange"); }
            set
            {
                this.OnPropertyChanging("IsDeletedInExchange");
                this.SetAttributeValue("isdeletedinexchange", value);
                this.OnPropertyChanged("IsDeletedInExchange");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isunlinkedincrm")]
        public System.Nullable<bool> IsUnlinkedInCRM
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("isunlinkedincrm"); }
            set
            {
                this.OnPropertyChanging("IsUnlinkedInCRM");
                this.SetAttributeValue("isunlinkedincrm", value);
                this.OnPropertyChanged("IsUnlinkedInCRM");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("lastsyncerror")]
        public string LastSyncError
        {
            get { return this.GetAttributeValue<string>("lastsyncerror"); }
            set
            {
                this.OnPropertyChanging("LastSyncError");
                this.SetAttributeValue("lastsyncerror", value);
                this.OnPropertyChanged("LastSyncError");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("lastsyncerrorcode")]
        public System.Nullable<int> LastSyncErrorCode
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("lastsyncerrorcode"); }
            set
            {
                this.OnPropertyChanging("LastSyncErrorCode");
                this.SetAttributeValue("lastsyncerrorcode", value);
                this.OnPropertyChanged("LastSyncErrorCode");
            }
        }

        /// <summary>
        /// Last Sync Error Time
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("lastsyncerroroccurredon")]
        public System.Nullable<System.DateTime> LastSyncErrorOccurredOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("lastsyncerroroccurredon"); }
            set
            {
                this.OnPropertyChanging("LastSyncErrorOccurredOn");
                this.SetAttributeValue("lastsyncerroroccurredon", value);
                this.OnPropertyChanged("LastSyncErrorOccurredOn");
            }
        }

        /// <summary>
        /// Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics CRM options.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
        public System.Nullable<System.DateTime> ModifiedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon"); }
        }

        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
        public System.Nullable<System.Guid> ObjectId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("objectid"); }
            set
            {
                this.OnPropertyChanging("ObjectId");
                this.SetAttributeValue("objectid", value);
                this.OnPropertyChanged("ObjectId");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objecttypecode")]
        public System.Nullable<int> ObjectTypeCode
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("objecttypecode"); }
            set
            {
                this.OnPropertyChanging("ObjectTypeCode");
                this.SetAttributeValue("objecttypecode", value);
                this.OnPropertyChanged("ObjectTypeCode");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ownerid")]
        public Microsoft.Xrm.Sdk.EntityReference OwnerId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("ownerid"); }
            set
            {
                this.OnPropertyChanging("OwnerId");
                this.SetAttributeValue("ownerid", value);
                this.OnPropertyChanged("OwnerId");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
        public Microsoft.Xrm.Sdk.EntityReference OwningBusinessUnit
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningbusinessunit"); }
        }

        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
        public Microsoft.Xrm.Sdk.EntityReference OwningTeam
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningteam"); }
        }

        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
        public Microsoft.Xrm.Sdk.EntityReference OwningUser
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owninguser"); }
        }

        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("retries")]
        public System.Nullable<int> Retries
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("retries"); }
            set
            {
                this.OnPropertyChanging("Retries");
                this.SetAttributeValue("retries", value);
                this.OnPropertyChanged("Retries");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("tocrmchangetype")]
        public System.Nullable<int> ToCrmChangeType
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("tocrmchangetype"); }
            set
            {
                this.OnPropertyChanging("ToCrmChangeType");
                this.SetAttributeValue("tocrmchangetype", value);
                this.OnPropertyChanged("ToCrmChangeType");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("userdecision")]
        public System.Nullable<int> UserDecision
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("userdecision"); }
            set
            {
                this.OnPropertyChanging("UserDecision");
                this.SetAttributeValue("userdecision", value);
                this.OnPropertyChanged("UserDecision");
            }
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
        /// N:1 business_unit_exchangesyncidmapping
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_exchangesyncidmapping")]
        public BusinessUnit business_unit_exchangesyncidmapping
        {
            get { return this.GetRelatedEntity<BusinessUnit>("business_unit_exchangesyncidmapping", null); }
        }

        /// <summary>
        /// N:1 team_exchangesyncidmapping
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_exchangesyncidmapping")]
        public Team team_exchangesyncidmapping
        {
            get { return this.GetRelatedEntity<Team>("team_exchangesyncidmapping", null); }
        }

        /// <summary>
        /// N:1 user_exchangesyncidmapping
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_exchangesyncidmapping")]
        public SystemUser user_exchangesyncidmapping
        {
            get { return this.GetRelatedEntity<SystemUser>("user_exchangesyncidmapping", null); }
        }
    }
}