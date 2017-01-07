namespace __4_DAL_CRM
{
    /// <summary>
    /// Item in a marketing list.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("listmember")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class ListMember : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public ListMember() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "listmember";

        public const int EntityTypeCode = 4301;

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
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby"); }
        }

        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
        public System.Nullable<System.DateTime> CreatedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon"); }
        }

        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entityid")]
        public Microsoft.Xrm.Sdk.EntityReference EntityId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("entityid"); }
            set
            {
                this.OnPropertyChanging("EntityId");
                this.SetAttributeValue("entityid", value);
                this.OnPropertyChanged("EntityId");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entitytype")]
        public string EntityType
        {
            get { return this.GetAttributeValue<string>("entitytype"); }
            set
            {
                this.OnPropertyChanging("EntityType");
                this.SetAttributeValue("entitytype", value);
                this.OnPropertyChanged("EntityType");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("listid")]
        public Microsoft.Xrm.Sdk.EntityReference ListId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("listid"); }
            set
            {
                this.OnPropertyChanging("ListId");
                this.SetAttributeValue("listid", value);
                this.OnPropertyChanged("ListId");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("listmemberid")]
        public System.Nullable<System.Guid> ListMemberId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("listmemberid"); }
            set
            {
                this.OnPropertyChanging("ListMemberId");
                this.SetAttributeValue("listmemberid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("ListMemberId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("listmemberid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.ListMemberId = value; }
        }

        /// <summary>
        /// Unique identifier of the user who last modified the list member.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby"); }
        }

        /// <summary>
        /// Date and time when the list member was last modified.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
        public System.Nullable<System.DateTime> ModifiedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who last modified the listmember.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        /// Unique identifier of the user or team who owns the list member.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ownerid")]
        public Microsoft.Xrm.Sdk.EntityReference OwnerId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("ownerid"); }
        }

        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
        public System.Nullable<System.Guid> OwningBusinessUnit
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("owningbusinessunit"); }
        }

        /// <summary>
        /// 
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
        /// 1:N userentityinstancedata_listmember
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_listmember")]
        public System.Collections.Generic.IEnumerable<UserEntityInstanceData> userentityinstancedata_listmember
        {
            get { return this.GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_listmember", null); }
            set
            {
                this.OnPropertyChanging("userentityinstancedata_listmember");
                this.SetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_listmember", null, value);
                this.OnPropertyChanged("userentityinstancedata_listmember");
            }
        }

        /// <summary>
        /// N:N listaccount_association
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("listaccount_association")]
        public System.Collections.Generic.IEnumerable<List> listaccount_association
        {
            get { return this.GetRelatedEntities<List>("listaccount_association", null); }
            set
            {
                this.OnPropertyChanging("listaccount_association");
                this.SetRelatedEntities<List>("listaccount_association", null, value);
                this.OnPropertyChanged("listaccount_association");
            }
        }

        /// <summary>
        /// N:N listcontact_association
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("listcontact_association")]
        public System.Collections.Generic.IEnumerable<List> listcontact_association
        {
            get { return this.GetRelatedEntities<List>("listcontact_association", null); }
            set
            {
                this.OnPropertyChanging("listcontact_association");
                this.SetRelatedEntities<List>("listcontact_association", null, value);
                this.OnPropertyChanged("listcontact_association");
            }
        }

        /// <summary>
        /// N:N listlead_association
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("listlead_association")]
        public System.Collections.Generic.IEnumerable<List> listlead_association
        {
            get { return this.GetRelatedEntities<List>("listlead_association", null); }
            set
            {
                this.OnPropertyChanging("listlead_association");
                this.SetRelatedEntities<List>("listlead_association", null, value);
                this.OnPropertyChanged("listlead_association");
            }
        }

        /// <summary>
        /// N:1 lk_listmember_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_listmember_createdby")]
        public SystemUser lk_listmember_createdby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_listmember_createdby", null); }
        }

        /// <summary>
        /// N:1 lk_listmember_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_listmember_createdonbehalfby")]
        public SystemUser lk_listmember_createdonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_listmember_createdonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_listmember_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_listmember_modifiedby")]
        public SystemUser lk_listmember_modifiedby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_listmember_modifiedby", null); }
        }

        /// <summary>
        /// N:1 lk_listmember_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_listmember_modifiedonbehalfby")]
        public SystemUser lk_listmember_modifiedonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_listmember_modifiedonbehalfby", null); }
        }
    }
}