namespace __4_DAL_CRM
{
    /// <summary>
    /// 
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("hierarchysecurityconfiguration")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class HierarchySecurityConfiguration : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public HierarchySecurityConfiguration() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "hierarchysecurityconfiguration";

        public const int EntityTypeCode = 9919;

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
        /// Logical entity name of the entity that is configured for hierarchy security.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entityname")]
        public string EntityName
        {
            get { return this.GetAttributeValue<string>("entityname"); }
            set
            {
                this.OnPropertyChanging("EntityName");
                this.SetAttributeValue("entityname", value);
                this.OnPropertyChanged("EntityName");
            }
        }

        /// <summary>
        /// Shows the entity used for the Hierarchy Security Modeling Configuration.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("hierarchysecuritymodelingsettingid")]
        public System.Nullable<System.Guid> HierarchySecurityModelingSettingId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("hierarchysecuritymodelingsettingid"); }
            set
            {
                this.OnPropertyChanging("HierarchySecurityModelingSettingId");
                this.SetAttributeValue("hierarchysecuritymodelingsettingid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("HierarchySecurityModelingSettingId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("hierarchysecuritymodelingsettingid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.HierarchySecurityModelingSettingId = value; }
        }

        /// <summary>
        /// For internal use only.
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
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
        public System.Nullable<long> VersionNumber
        {
            get { return this.GetAttributeValue<System.Nullable<long>>("versionnumber"); }
            set
            {
                this.OnPropertyChanging("VersionNumber");
                this.SetAttributeValue("versionnumber", value);
                this.OnPropertyChanged("VersionNumber");
            }
        }
    }
}