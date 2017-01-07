namespace __4_DAL_CRM
{
    /// <summary>
    /// Map CRM security principals (users and teams) to user/team owned entities with basic read privilege.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("principalentitymap")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class PrincipalEntityMap : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public PrincipalEntityMap() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "principalentitymap";

        public const int EntityTypeCode = 41;

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
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objecttypecode")]
        public string ObjectTypeCode
        {
            get { return this.GetAttributeValue<string>("objecttypecode"); }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("principalentitymapid")]
        public System.Nullable<System.Guid> PrincipalEntityMapId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("principalentitymapid"); }
            set
            {
                this.OnPropertyChanging("PrincipalEntityMapId");
                this.SetAttributeValue("principalentitymapid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("PrincipalEntityMapId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("principalentitymapid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.PrincipalEntityMapId = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("principalid")]
        public System.Nullable<System.Guid> PrincipalId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("principalid"); }
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
        /// 1:N userentityinstancedata_principalentitymap
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_principalentitymap")]
        public System.Collections.Generic.IEnumerable<UserEntityInstanceData> userentityinstancedata_principalentitymap
        {
            get { return this.GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_principalentitymap", null); }
            set
            {
                this.OnPropertyChanging("userentityinstancedata_principalentitymap");
                this.SetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_principalentitymap", null, value);
                this.OnPropertyChanged("userentityinstancedata_principalentitymap");
            }
        }
    }
}