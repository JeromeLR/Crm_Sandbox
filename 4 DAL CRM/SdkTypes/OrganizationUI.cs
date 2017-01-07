namespace __4_DAL_CRM
{
    /// <summary>
    /// Entity customizations including form layout and icons. Includes current and past versions.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("organizationui")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class OrganizationUI : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public OrganizationUI() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "organizationui";

        public const int EntityTypeCode = 1021;

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
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("componentstate")]
        public Microsoft.Xrm.Sdk.OptionSetValue ComponentState
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("componentstate"); }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("fieldxml")]
        public string FieldXml
        {
            get { return this.GetAttributeValue<string>("fieldxml"); }
            set
            {
                this.OnPropertyChanging("FieldXml");
                this.SetAttributeValue("fieldxml", value);
                this.OnPropertyChanged("FieldXml");
            }
        }

        /// <summary>
        /// Unique identifier of the record type form.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("formid")]
        public System.Nullable<System.Guid> FormId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("formid"); }
            set
            {
                this.OnPropertyChanging("FormId");
                this.SetAttributeValue("formid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("FormId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("formid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.FormId = value; }
        }

        /// <summary>
        /// Unique identifier of the form used when synchronizing customizations for the Microsoft Dynamics CRM client for Outlook.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("formidunique")]
        public System.Nullable<System.Guid> FormIdUnique
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("formidunique"); }
        }

        /// <summary>
        /// XML representation of the form layout.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("formxml")]
        public string FormXml
        {
            get { return this.GetAttributeValue<string>("formxml"); }
            set
            {
                this.OnPropertyChanging("FormXml");
                this.SetAttributeValue("formxml", value);
                this.OnPropertyChanged("FormXml");
            }
        }

        /// <summary>
        /// Binary representation of the icon used in record type grid views.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("gridicon")]
        public string GridIcon
        {
            get { return this.GetAttributeValue<string>("gridicon"); }
            set
            {
                this.OnPropertyChanging("GridIcon");
                this.SetAttributeValue("gridicon", value);
                this.OnPropertyChanged("GridIcon");
            }
        }

        /// <summary>
        /// Information that specifies whether this component can be customized.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("iscustomizable")]
        public Microsoft.Xrm.Sdk.BooleanManagedProperty IsCustomizable
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.BooleanManagedProperty>("iscustomizable"); }
            set
            {
                this.OnPropertyChanging("IsCustomizable");
                this.SetAttributeValue("iscustomizable", value);
                this.OnPropertyChanged("IsCustomizable");
            }
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
        /// Binary representation of the large icon used in the record type form.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("largeentityicon")]
        public string LargeEntityIcon
        {
            get { return this.GetAttributeValue<string>("largeentityicon"); }
            set
            {
                this.OnPropertyChanging("LargeEntityIcon");
                this.SetAttributeValue("largeentityicon", value);
                this.OnPropertyChanged("LargeEntityIcon");
            }
        }

        /// <summary>
        /// Code that represents the record type.
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
        /// Unique identifier of the organization.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
        public Microsoft.Xrm.Sdk.EntityReference OrganizationId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("organizationid"); }
        }

        /// <summary>
        /// Binary representation of the large icon used in the Microsoft Dynamics CRM client for Outlook for this record type.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("outlookshortcuticon")]
        public string OutlookShortcutIcon
        {
            get { return this.GetAttributeValue<string>("outlookshortcuticon"); }
            set
            {
                this.OnPropertyChanging("OutlookShortcutIcon");
                this.SetAttributeValue("outlookshortcuticon", value);
                this.OnPropertyChanged("OutlookShortcutIcon");
            }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("overwritetime")]
        public System.Nullable<System.DateTime> OverwriteTime
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("overwritetime"); }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("previewcolumnsetxml")]
        public string PreviewColumnsetXml
        {
            get { return this.GetAttributeValue<string>("previewcolumnsetxml"); }
            set
            {
                this.OnPropertyChanging("PreviewColumnsetXml");
                this.SetAttributeValue("previewcolumnsetxml", value);
                this.OnPropertyChanged("PreviewColumnsetXml");
            }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("previewxml")]
        public string PreviewXml
        {
            get { return this.GetAttributeValue<string>("previewxml"); }
            set
            {
                this.OnPropertyChanging("PreviewXml");
                this.SetAttributeValue("previewxml", value);
                this.OnPropertyChanged("PreviewXml");
            }
        }

        /// <summary>
        /// Unique identifier of the associated solution.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("solutionid")]
        public System.Nullable<System.Guid> SolutionId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("solutionid"); }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("version")]
        public System.Nullable<int> Version
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("version"); }
            set
            {
                this.OnPropertyChanging("Version");
                this.SetAttributeValue("version", value);
                this.OnPropertyChanged("Version");
            }
        }

        /// <summary>
        /// Represents a version of customizations to be synchronized with the Microsoft Dynamics CRM client for Outlook.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
        public System.Nullable<long> VersionNumber
        {
            get { return this.GetAttributeValue<System.Nullable<long>>("versionnumber"); }
        }

        /// <summary>
        /// N:1 lk_organizationui_organizationid
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_organizationui_organizationid")]
        public Organization lk_organizationui_organizationid
        {
            get { return this.GetRelatedEntity<Organization>("lk_organizationui_organizationid", null); }
        }
    }
}