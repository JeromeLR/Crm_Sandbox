namespace __4_DAL_CRM
{
    /// <summary>
    /// Stores user settings for entity views.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("userentityuisettings")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class UserEntityUISettings : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public UserEntityUISettings() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "userentityuisettings";

        public const int EntityTypeCode = 2500;

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
        /// Describes which entities are most recently inserted into email for this entity
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("insertintoemailmruxml")]
        public string InsertIntoEmailMRUXml
        {
            get { return this.GetAttributeValue<string>("insertintoemailmruxml"); }
            set
            {
                this.OnPropertyChanging("InsertIntoEmailMRUXml");
                this.SetAttributeValue("insertintoemailmruxml", value);
                this.OnPropertyChanged("InsertIntoEmailMRUXml");
            }
        }

        /// <summary>
        /// Describes which forms are most recently viewed for this entity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("lastviewedformxml")]
        public string LastViewedFormXml
        {
            get { return this.GetAttributeValue<string>("lastviewedformxml"); }
            set
            {
                this.OnPropertyChanging("LastViewedFormXml");
                this.SetAttributeValue("lastviewedformxml", value);
                this.OnPropertyChanged("LastViewedFormXml");
            }
        }

        /// <summary>
        /// List of most recently used lookup references for this entity
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("lookupmruxml")]
        public string LookupMRUXml
        {
            get { return this.GetAttributeValue<string>("lookupmruxml"); }
            set
            {
                this.OnPropertyChanging("LookupMRUXml");
                this.SetAttributeValue("lookupmruxml", value);
                this.OnPropertyChanged("LookupMRUXml");
            }
        }

        /// <summary>
        /// Describes which tabs are most recently used for this entity
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("mruxml")]
        public string MRUXml
        {
            get { return this.GetAttributeValue<string>("mruxml"); }
            set
            {
                this.OnPropertyChanging("MRUXml");
                this.SetAttributeValue("mruxml", value);
                this.OnPropertyChanged("MRUXml");
            }
        }

        /// <summary>
        /// Object Type Code
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
        /// Unique identifier of the user or team who owns the settings.
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
        /// Unique identifier of the business unit that owns this.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
        public Microsoft.Xrm.Sdk.EntityReference OwningBusinessUnit
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningbusinessunit"); }
        }

        /// <summary>
        /// Unique identifier of the team who owns this saved view.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
        public Microsoft.Xrm.Sdk.EntityReference OwningTeam
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningteam"); }
        }

        /// <summary>
        /// Unique identifier of the user who owns this saved view.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
        public Microsoft.Xrm.Sdk.EntityReference OwningUser
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owninguser"); }
        }

        /// <summary>
        /// Describes the reading pane formatting of this entity
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("readingpanexml")]
        public string ReadingPaneXml
        {
            get { return this.GetAttributeValue<string>("readingpanexml"); }
            set
            {
                this.OnPropertyChanging("ReadingPaneXml");
                this.SetAttributeValue("readingpanexml", value);
                this.OnPropertyChanged("ReadingPaneXml");
            }
        }

        /// <summary>
        /// Describes which objects are most recently viewed for this entity
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("recentlyviewedxml")]
        public string RecentlyViewedXml
        {
            get { return this.GetAttributeValue<string>("recentlyviewedxml"); }
            set
            {
                this.OnPropertyChanging("RecentlyViewedXml");
                this.SetAttributeValue("recentlyviewedxml", value);
                this.OnPropertyChanged("RecentlyViewedXml");
            }
        }

        /// <summary>
        /// Determines whether a record type is exposed in the Outlook Address Book
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("showinaddressbook")]
        public System.Nullable<bool> ShowInAddressBook
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("showinaddressbook"); }
            set
            {
                this.OnPropertyChanging("ShowInAddressBook");
                this.SetAttributeValue("showinaddressbook", value);
                this.OnPropertyChanged("ShowInAddressBook");
            }
        }

        /// <summary>
        /// Describes the tab ordering for this entity
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("taborderxml")]
        public string TabOrderXml
        {
            get { return this.GetAttributeValue<string>("taborderxml"); }
            set
            {
                this.OnPropertyChanging("TabOrderXml");
                this.SetAttributeValue("taborderxml", value);
                this.OnPropertyChanged("TabOrderXml");
            }
        }

        /// <summary>
        /// Unique identifier user entity
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("userentityuisettingsid")]
        public System.Nullable<System.Guid> UserEntityUISettingsId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("userentityuisettingsid"); }
            set
            {
                this.OnPropertyChanging("UserEntityUISettingsId");
                this.SetAttributeValue("userentityuisettingsid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("UserEntityUISettingsId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("userentityuisettingsid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.UserEntityUISettingsId = value; }
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
        /// 1:N userentityinstancedata_userentityuisettings
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_userentityuisettings")]
        public System.Collections.Generic.IEnumerable<UserEntityInstanceData> userentityinstancedata_userentityuisettings
        {
            get { return this.GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_userentityuisettings", null); }
            set
            {
                this.OnPropertyChanging("userentityinstancedata_userentityuisettings");
                this.SetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_userentityuisettings", null, value);
                this.OnPropertyChanged("userentityinstancedata_userentityuisettings");
            }
        }

        /// <summary>
        /// N:1 team_userentityuisettings
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_userentityuisettings")]
        public Team team_userentityuisettings
        {
            get { return this.GetRelatedEntity<Team>("team_userentityuisettings", null); }
        }

        /// <summary>
        /// N:1 userentityuisettings_businessunit
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityuisettings_businessunit")]
        public BusinessUnit userentityuisettings_businessunit
        {
            get { return this.GetRelatedEntity<BusinessUnit>("userentityuisettings_businessunit", null); }
        }

        /// <summary>
        /// N:1 userentityuisettings_owning_user
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityuisettings_owning_user")]
        public SystemUser userentityuisettings_owning_user
        {
            get { return this.GetRelatedEntity<SystemUser>("userentityuisettings_owning_user", null); }
        }
    }
}