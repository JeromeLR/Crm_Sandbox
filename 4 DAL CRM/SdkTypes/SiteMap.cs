namespace __4_DAL_CRM
{
    /// <summary>
    /// XML data used to control the application navigation pane.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("sitemap")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class SiteMap : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public SiteMap() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "sitemap";

        public const int EntityTypeCode = 4709;

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
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("componentstate")]
        public Microsoft.Xrm.Sdk.OptionSetValue ComponentState
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("componentstate"); }
        }

        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ismanaged")]
        public System.Nullable<bool> IsManaged
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("ismanaged"); }
        }

        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
        public Microsoft.Xrm.Sdk.EntityReference OrganizationId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("organizationid"); }
        }

        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("overwritetime")]
        public System.Nullable<System.DateTime> OverwriteTime
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("overwritetime"); }
        }

        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sitemapid")]
        public System.Nullable<System.Guid> SiteMapId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("sitemapid"); }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sitemapid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { base.Id = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sitemapidunique")]
        public System.Nullable<System.Guid> SiteMapIdUnique
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("sitemapidunique"); }
        }

        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sitemapxml")]
        public string SiteMapXml
        {
            get { return this.GetAttributeValue<string>("sitemapxml"); }
            set
            {
                this.OnPropertyChanging("SiteMapXml");
                this.SetAttributeValue("sitemapxml", value);
                this.OnPropertyChanged("SiteMapXml");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("solutionid")]
        public System.Nullable<System.Guid> SolutionId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("solutionid"); }
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
        /// 1:N userentityinstancedata_sitemap
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_sitemap")]
        public System.Collections.Generic.IEnumerable<UserEntityInstanceData> userentityinstancedata_sitemap
        {
            get { return this.GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_sitemap", null); }
            set
            {
                this.OnPropertyChanging("userentityinstancedata_sitemap");
                this.SetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_sitemap", null, value);
                this.OnPropertyChanged("userentityinstancedata_sitemap");
            }
        }

        /// <summary>
        /// N:1 organization_sitemap
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_sitemap")]
        public Organization organization_sitemap
        {
            get { return this.GetRelatedEntity<Organization>("organization_sitemap", null); }
        }
    }
}