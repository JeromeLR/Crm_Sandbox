namespace __4_DAL_CRM
{
    /// <summary>
    /// Group of privileges used to categorize users to provide appropriate access to secured columns.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("fieldpermission")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class FieldPermission : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public FieldPermission() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "fieldpermission";

        public const int EntityTypeCode = 1201;

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
        /// Attribute Name.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("attributelogicalname")]
        public string AttributeLogicalName
        {
            get { return this.GetAttributeValue<string>("attributelogicalname"); }
            set
            {
                this.OnPropertyChanging("AttributeLogicalName");
                this.SetAttributeValue("attributelogicalname", value);
                this.OnPropertyChanged("AttributeLogicalName");
            }
        }

        /// <summary>
        /// Can this Profile create the attribute
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("cancreate")]
        public Microsoft.Xrm.Sdk.OptionSetValue CanCreate
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("cancreate"); }
            set
            {
                this.OnPropertyChanging("CanCreate");
                this.SetAttributeValue("cancreate", value);
                this.OnPropertyChanged("CanCreate");
            }
        }

        /// <summary>
        /// Can this Profile read the attribute
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("canread")]
        public Microsoft.Xrm.Sdk.OptionSetValue CanRead
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("canread"); }
            set
            {
                this.OnPropertyChanging("CanRead");
                this.SetAttributeValue("canread", value);
                this.OnPropertyChanged("CanRead");
            }
        }

        /// <summary>
        /// Can this Profile update the attribute
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("canupdate")]
        public Microsoft.Xrm.Sdk.OptionSetValue CanUpdate
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("canupdate"); }
            set
            {
                this.OnPropertyChanging("CanUpdate");
                this.SetAttributeValue("canupdate", value);
                this.OnPropertyChanged("CanUpdate");
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
        /// Entity name.
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
        /// Unique identifier of the Field Permission.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("fieldpermissionid")]
        public System.Nullable<System.Guid> FieldPermissionId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("fieldpermissionid"); }
            set
            {
                this.OnPropertyChanging("FieldPermissionId");
                this.SetAttributeValue("fieldpermissionid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("FieldPermissionId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("fieldpermissionid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.FieldPermissionId = value; }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("fieldpermissionidunique")]
        public System.Nullable<System.Guid> FieldPermissionIdUnique
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("fieldpermissionidunique"); }
        }

        /// <summary>
        /// Unique identifier of profile to which this privilege belongs.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("fieldsecurityprofileid")]
        public Microsoft.Xrm.Sdk.EntityReference FieldSecurityProfileId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("fieldsecurityprofileid"); }
            set
            {
                this.OnPropertyChanging("FieldSecurityProfileId");
                this.SetAttributeValue("fieldsecurityprofileid", value);
                this.OnPropertyChanged("FieldSecurityProfileId");
            }
        }

        /// <summary>
        /// Indicates whether the solution component is part of a managed solution.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ismanaged")]
        public System.Nullable<bool> IsManaged
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("ismanaged"); }
        }

        /// <summary>
        /// Unique identifier for the organization
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
        public Microsoft.Xrm.Sdk.EntityReference OrganizationId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("organizationid"); }
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
        /// Unique identifier of the associated solution.
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
        /// 1:N userentityinstancedata_fieldpermission
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_fieldpermission")]
        public System.Collections.Generic.IEnumerable<UserEntityInstanceData> userentityinstancedata_fieldpermission
        {
            get { return this.GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_fieldpermission", null); }
            set
            {
                this.OnPropertyChanging("userentityinstancedata_fieldpermission");
                this.SetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_fieldpermission", null, value);
                this.OnPropertyChanged("userentityinstancedata_fieldpermission");
            }
        }

        /// <summary>
        /// N:1 lk_fieldpermission_fieldsecurityprofileid
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("fieldsecurityprofileid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_fieldpermission_fieldsecurityprofileid")]
        public FieldSecurityProfile lk_fieldpermission_fieldsecurityprofileid
        {
            get { return this.GetRelatedEntity<FieldSecurityProfile>("lk_fieldpermission_fieldsecurityprofileid", null); }
            set
            {
                this.OnPropertyChanging("lk_fieldpermission_fieldsecurityprofileid");
                this.SetRelatedEntity<FieldSecurityProfile>("lk_fieldpermission_fieldsecurityprofileid", null, value);
                this.OnPropertyChanged("lk_fieldpermission_fieldsecurityprofileid");
            }
        }
    }
}