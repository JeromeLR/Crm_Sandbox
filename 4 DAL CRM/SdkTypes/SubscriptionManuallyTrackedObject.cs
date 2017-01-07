namespace __4_DAL_CRM
{
    /// <summary>
    /// For internal use only.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("subscriptionmanuallytrackedobject")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class SubscriptionManuallyTrackedObject : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public SubscriptionManuallyTrackedObject() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "subscriptionmanuallytrackedobject";

        public const int EntityTypeCode = 37;

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
        /// Unique identifier of the object with which the subscription is associated.
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
        /// Type code of the object with which the subscription is associated.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objecttypecode")]
        public string ObjectTypeCode
        {
            get { return this.GetAttributeValue<string>("objecttypecode"); }
            set
            {
                this.OnPropertyChanging("ObjectTypeCode");
                this.SetAttributeValue("objecttypecode", value);
                this.OnPropertyChanged("ObjectTypeCode");
            }
        }

        /// <summary>
        /// Unique identifier of the subscription.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("subscriptionid")]
        public System.Nullable<System.Guid> SubscriptionId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("subscriptionid"); }
            set
            {
                this.OnPropertyChanging("SubscriptionId");
                this.SetAttributeValue("subscriptionid", value);
                this.OnPropertyChanged("SubscriptionId");
            }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("subscriptionmanuallytrackedobjectid")]
        public System.Nullable<System.Guid> SubscriptionManuallyTrackedObjectId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("subscriptionmanuallytrackedobjectid"); }
            set
            {
                this.OnPropertyChanging("SubscriptionManuallyTrackedObjectId");
                this.SetAttributeValue("subscriptionmanuallytrackedobjectid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("SubscriptionManuallyTrackedObjectId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("subscriptionmanuallytrackedobjectid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.SubscriptionManuallyTrackedObjectId = value; }
        }

        /// <summary>
        /// Information that specifies if the object is tracked.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("track")]
        public System.Nullable<bool> Track
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("track"); }
            set
            {
                this.OnPropertyChanging("Track");
                this.SetAttributeValue("track", value);
                this.OnPropertyChanged("Track");
            }
        }

        /// <summary>
        /// Version number of the subscription manually tracked object.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
        public System.Nullable<long> VersionNumber
        {
            get { return this.GetAttributeValue<System.Nullable<long>>("versionnumber"); }
        }

        /// <summary>
        /// 1:N userentityinstancedata_subscriptionmanuallytrackedobject
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_subscriptionmanuallytrackedobject")]
        public System.Collections.Generic.IEnumerable<UserEntityInstanceData> userentityinstancedata_subscriptionmanuallytrackedobject
        {
            get { return this.GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_subscriptionmanuallytrackedobject", null); }
            set
            {
                this.OnPropertyChanging("userentityinstancedata_subscriptionmanuallytrackedobject");
                this.SetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_subscriptionmanuallytrackedobject", null, value);
                this.OnPropertyChanged("userentityinstancedata_subscriptionmanuallytrackedobject");
            }
        }
    }
}