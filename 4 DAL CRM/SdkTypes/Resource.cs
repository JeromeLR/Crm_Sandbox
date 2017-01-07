namespace __4_DAL_CRM
{
    /// <summary>
    /// User or facility/equipment that can be scheduled for a service.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("resource")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class Resource : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public Resource() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "resource";

        public const int EntityTypeCode = 4002;

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
        /// Unique identifier of the business unit with which the resource is associated.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("businessunitid")]
        public Microsoft.Xrm.Sdk.EntityReference BusinessUnitId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("businessunitid"); }
            set
            {
                this.OnPropertyChanging("BusinessUnitId");
                this.SetAttributeValue("businessunitid", value);
                this.OnPropertyChanged("BusinessUnitId");
            }
        }

        /// <summary>
        /// Unique identifier of the calendar for the resource.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("calendarid")]
        public System.Nullable<System.Guid> CalendarId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("calendarid"); }
            set
            {
                this.OnPropertyChanging("CalendarId");
                this.SetAttributeValue("calendarid", value);
                this.OnPropertyChanged("CalendarId");
            }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("displayinserviceviews")]
        public System.Nullable<bool> DisplayInServiceViews
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("displayinserviceviews"); }
            set
            {
                this.OnPropertyChanging("DisplayInServiceViews");
                this.SetAttributeValue("displayinserviceviews", value);
                this.OnPropertyChanged("DisplayInServiceViews");
            }
        }

        /// <summary>
        /// Shows the default image for the record.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entityimage")]
        public byte[] EntityImage
        {
            get { return this.GetAttributeValue<byte[]>("entityimage"); }
            set
            {
                this.OnPropertyChanging("EntityImage");
                this.SetAttributeValue("entityimage", value);
                this.OnPropertyChanged("EntityImage");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entityimage_timestamp")]
        public System.Nullable<long> EntityImage_Timestamp
        {
            get { return this.GetAttributeValue<System.Nullable<long>>("entityimage_timestamp"); }
        }

        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entityimage_url")]
        public string EntityImage_URL
        {
            get { return this.GetAttributeValue<string>("entityimage_url"); }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entityimageid")]
        public System.Nullable<System.Guid> EntityImageId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("entityimageid"); }
        }

        /// <summary>
        /// Information about whether the resource is enabled.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isdisabled")]
        public System.Nullable<bool> IsDisabled
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("isdisabled"); }
            set
            {
                this.OnPropertyChanging("IsDisabled");
                this.SetAttributeValue("isdisabled", value);
                this.OnPropertyChanged("IsDisabled");
            }
        }

        /// <summary>
        /// Name of the resource.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("name")]
        public string Name
        {
            get { return this.GetAttributeValue<string>("name"); }
            set
            {
                this.OnPropertyChanging("Name");
                this.SetAttributeValue("name", value);
                this.OnPropertyChanged("Name");
            }
        }

        /// <summary>
        /// Type of entity with which the resource is associated.
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
        /// Unique identifier of the organization with which the resource is associated.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
        public Microsoft.Xrm.Sdk.EntityReference OrganizationId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("organizationid"); }
        }

        /// <summary>
        /// Unique identifier of the resource.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("resourceid")]
        public System.Nullable<System.Guid> ResourceId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("resourceid"); }
            set
            {
                this.OnPropertyChanging("ResourceId");
                this.SetAttributeValue("resourceid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("ResourceId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("resourceid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.ResourceId = value; }
        }

        /// <summary>
        /// Unique identifier of the site at which the resource is located.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("siteid")]
        public Microsoft.Xrm.Sdk.EntityReference SiteId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("siteid"); }
            set
            {
                this.OnPropertyChanging("SiteId");
                this.SetAttributeValue("siteid", value);
                this.OnPropertyChanged("SiteId");
            }
        }

        /// <summary>
        /// Version number of the resource.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
        public System.Nullable<long> VersionNumber
        {
            get { return this.GetAttributeValue<System.Nullable<long>>("versionnumber"); }
        }

        /// <summary>
        /// 1:N Resource_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Resource_AsyncOperations")]
        public System.Collections.Generic.IEnumerable<AsyncOperation> Resource_AsyncOperations
        {
            get { return this.GetRelatedEntities<AsyncOperation>("Resource_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("Resource_AsyncOperations");
                this.SetRelatedEntities<AsyncOperation>("Resource_AsyncOperations", null, value);
                this.OnPropertyChanged("Resource_AsyncOperations");
            }
        }

        /// <summary>
        /// 1:N Resource_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Resource_BulkDeleteFailures")]
        public System.Collections.Generic.IEnumerable<BulkDeleteFailure> Resource_BulkDeleteFailures
        {
            get { return this.GetRelatedEntities<BulkDeleteFailure>("Resource_BulkDeleteFailures", null); }
            set
            {
                this.OnPropertyChanging("Resource_BulkDeleteFailures");
                this.SetRelatedEntities<BulkDeleteFailure>("Resource_BulkDeleteFailures", null, value);
                this.OnPropertyChanged("Resource_BulkDeleteFailures");
            }
        }

        /// <summary>
        /// 1:N userentityinstancedata_resource
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_resource")]
        public System.Collections.Generic.IEnumerable<UserEntityInstanceData> userentityinstancedata_resource
        {
            get { return this.GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_resource", null); }
            set
            {
                this.OnPropertyChanging("userentityinstancedata_resource");
                this.SetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_resource", null, value);
                this.OnPropertyChanged("userentityinstancedata_resource");
            }
        }

        /// <summary>
        /// N:1 business_unit_resources
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("businessunitid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_resources")]
        public BusinessUnit business_unit_resources
        {
            get { return this.GetRelatedEntity<BusinessUnit>("business_unit_resources", null); }
            set
            {
                this.OnPropertyChanging("business_unit_resources");
                this.SetRelatedEntity<BusinessUnit>("business_unit_resources", null, value);
                this.OnPropertyChanged("business_unit_resources");
            }
        }

        /// <summary>
        /// N:1 equipment_resources
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("resourceid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("equipment_resources")]
        public Equipment equipment_resources
        {
            get { return this.GetRelatedEntity<Equipment>("equipment_resources", null); }
            set
            {
                this.OnPropertyChanging("equipment_resources");
                this.SetRelatedEntity<Equipment>("equipment_resources", null, value);
                this.OnPropertyChanged("equipment_resources");
            }
        }

        /// <summary>
        /// N:1 organization_resources
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_resources")]
        public Organization organization_resources
        {
            get { return this.GetRelatedEntity<Organization>("organization_resources", null); }
        }

        /// <summary>
        /// N:1 resourcespec_resources
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("resourceid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("resourcespec_resources")]
        public ResourceSpec resourcespec_resources
        {
            get { return this.GetRelatedEntity<ResourceSpec>("resourcespec_resources", null); }
            set
            {
                this.OnPropertyChanging("resourcespec_resources");
                this.SetRelatedEntity<ResourceSpec>("resourcespec_resources", null, value);
                this.OnPropertyChanged("resourcespec_resources");
            }
        }

        /// <summary>
        /// N:1 site_resources
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("siteid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("site_resources")]
        public Site site_resources
        {
            get { return this.GetRelatedEntity<Site>("site_resources", null); }
            set
            {
                this.OnPropertyChanging("site_resources");
                this.SetRelatedEntity<Site>("site_resources", null, value);
                this.OnPropertyChanged("site_resources");
            }
        }

        /// <summary>
        /// N:1 systemuser_resources
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("resourceid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("systemuser_resources")]
        public SystemUser systemuser_resources
        {
            get { return this.GetRelatedEntity<SystemUser>("systemuser_resources", null); }
            set
            {
                this.OnPropertyChanging("systemuser_resources");
                this.SetRelatedEntity<SystemUser>("systemuser_resources", null, value);
                this.OnPropertyChanged("systemuser_resources");
            }
        }
    }
}