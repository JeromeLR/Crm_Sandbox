namespace __4_DAL_CRM
{
    /// <summary>
    /// Position of a user in the hierarchy
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("position")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class Position : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public Position() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "position";

        public const int EntityTypeCode = 50;

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
        /// Unique identifier of the user who created the record.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby"); }
        }

        /// <summary>
        /// Date and time when the record was created.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
        public System.Nullable<System.DateTime> CreatedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who created the record.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        /// The description of the position.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("description")]
        public string Description
        {
            get { return this.GetAttributeValue<string>("description"); }
            set
            {
                this.OnPropertyChanging("Description");
                this.SetAttributeValue("description", value);
                this.OnPropertyChanged("Description");
            }
        }

        /// <summary>
        /// Exchange rate for the currency associated with the position with respect to the base currency.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("exchangerate")]
        public System.Nullable<decimal> ExchangeRate
        {
            get { return this.GetAttributeValue<System.Nullable<decimal>>("exchangerate"); }
        }

        /// <summary>
        /// Sequence number of the import that created this record.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("importsequencenumber")]
        public System.Nullable<int> ImportSequenceNumber
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("importsequencenumber"); }
            set
            {
                this.OnPropertyChanging("ImportSequenceNumber");
                this.SetAttributeValue("importsequencenumber", value);
                this.OnPropertyChanged("ImportSequenceNumber");
            }
        }

        /// <summary>
        /// Unique identifier of the user who modified the record.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby"); }
        }

        /// <summary>
        /// Date and time when the record was modified.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
        public System.Nullable<System.DateTime> ModifiedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who modified the record.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        /// The name of the position.
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
        /// Unique identifier for the organization
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
        public Microsoft.Xrm.Sdk.EntityReference OrganizationId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("organizationid"); }
        }

        /// <summary>
        /// Date and time that the record was migrated.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("overriddencreatedon")]
        public System.Nullable<System.DateTime> OverriddenCreatedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("overriddencreatedon"); }
            set
            {
                this.OnPropertyChanging("OverriddenCreatedOn");
                this.SetAttributeValue("overriddencreatedon", value);
                this.OnPropertyChanged("OverriddenCreatedOn");
            }
        }

        /// <summary>
        /// Parent position.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("parentpositionid")]
        public Microsoft.Xrm.Sdk.EntityReference ParentPositionId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("parentpositionid"); }
            set
            {
                this.OnPropertyChanging("ParentPositionId");
                this.SetAttributeValue("parentpositionid", value);
                this.OnPropertyChanged("ParentPositionId");
            }
        }

        /// <summary>
        /// Unique identifier for position entity instances
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("positionid")]
        public System.Nullable<System.Guid> PositionId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("positionid"); }
            set
            {
                this.OnPropertyChanging("PositionId");
                this.SetAttributeValue("positionid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("PositionId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("positionid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.PositionId = value; }
        }

        /// <summary>
        /// Status of the Position
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
        public System.Nullable<PositionState> statecode
        {
            get
            {
                Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
                if ((optionSet != null))
                {
                    return ((PositionState) (System.Enum.ToObject(typeof(PositionState), optionSet.Value)));
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.OnPropertyChanging("statecode");
                if ((value == null))
                {
                    this.SetAttributeValue("statecode", null);
                }
                else
                {
                    this.SetAttributeValue("statecode", new Microsoft.Xrm.Sdk.OptionSetValue(((int) (value))));
                }
                this.OnPropertyChanged("statecode");
            }
        }

        /// <summary>
        /// Reason for the status of the Position
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statuscode")]
        public Microsoft.Xrm.Sdk.OptionSetValue StatusCode
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statuscode"); }
            set
            {
                this.OnPropertyChanging("StatusCode");
                this.SetAttributeValue("statuscode", value);
                this.OnPropertyChanged("StatusCode");
            }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("timezoneruleversionnumber")]
        public System.Nullable<int> TimeZoneRuleVersionNumber
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("timezoneruleversionnumber"); }
            set
            {
                this.OnPropertyChanging("TimeZoneRuleVersionNumber");
                this.SetAttributeValue("timezoneruleversionnumber", value);
                this.OnPropertyChanged("TimeZoneRuleVersionNumber");
            }
        }

        /// <summary>
        /// Unique identifier of the currency associated with the position.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyid")]
        public Microsoft.Xrm.Sdk.EntityReference TransactionCurrencyId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("transactioncurrencyid"); }
            set
            {
                this.OnPropertyChanging("TransactionCurrencyId");
                this.SetAttributeValue("transactioncurrencyid", value);
                this.OnPropertyChanged("TransactionCurrencyId");
            }
        }

        /// <summary>
        /// Time zone code that was in use when the record was created.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("utcconversiontimezonecode")]
        public System.Nullable<int> UTCConversionTimeZoneCode
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("utcconversiontimezonecode"); }
            set
            {
                this.OnPropertyChanging("UTCConversionTimeZoneCode");
                this.SetAttributeValue("utcconversiontimezonecode", value);
                this.OnPropertyChanged("UTCConversionTimeZoneCode");
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
        /// 1:N position_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("position_AsyncOperations")]
        public System.Collections.Generic.IEnumerable<AsyncOperation> position_AsyncOperations
        {
            get { return this.GetRelatedEntities<AsyncOperation>("position_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("position_AsyncOperations");
                this.SetRelatedEntities<AsyncOperation>("position_AsyncOperations", null, value);
                this.OnPropertyChanged("position_AsyncOperations");
            }
        }

        /// <summary>
        /// 1:N position_connection1
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("position_connection1")]
        public System.Collections.Generic.IEnumerable<Connection> position_connection1
        {
            get { return this.GetRelatedEntities<Connection>("position_connection1", null); }
            set
            {
                this.OnPropertyChanging("position_connection1");
                this.SetRelatedEntities<Connection>("position_connection1", null, value);
                this.OnPropertyChanged("position_connection1");
            }
        }

        /// <summary>
        /// 1:N position_connection2
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("position_connection2")]
        public System.Collections.Generic.IEnumerable<Connection> position_connection2
        {
            get { return this.GetRelatedEntities<Connection>("position_connection2", null); }
            set
            {
                this.OnPropertyChanging("position_connection2");
                this.SetRelatedEntities<Connection>("position_connection2", null, value);
                this.OnPropertyChanged("position_connection2");
            }
        }

        /// <summary>
        /// 1:N position_parent_position
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("position_parent_position", Microsoft.Xrm.Sdk.EntityRole.Referenced)]
        public System.Collections.Generic.IEnumerable<Position> Referencedposition_parent_position
        {
            get { return this.GetRelatedEntities<Position>("position_parent_position", Microsoft.Xrm.Sdk.EntityRole.Referenced); }
            set
            {
                this.OnPropertyChanging("Referencedposition_parent_position");
                this.SetRelatedEntities<Position>("position_parent_position", Microsoft.Xrm.Sdk.EntityRole.Referenced, value);
                this.OnPropertyChanged("Referencedposition_parent_position");
            }
        }

        /// <summary>
        /// 1:N position_principalobjectattributeaccess
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("position_principalobjectattributeaccess")]
        public System.Collections.Generic.IEnumerable<PrincipalObjectAttributeAccess> position_principalobjectattributeaccess
        {
            get { return this.GetRelatedEntities<PrincipalObjectAttributeAccess>("position_principalobjectattributeaccess", null); }
            set
            {
                this.OnPropertyChanging("position_principalobjectattributeaccess");
                this.SetRelatedEntities<PrincipalObjectAttributeAccess>("position_principalobjectattributeaccess", null, value);
                this.OnPropertyChanged("position_principalobjectattributeaccess");
            }
        }

        /// <summary>
        /// 1:N position_ProcessSession
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("position_ProcessSession")]
        public System.Collections.Generic.IEnumerable<ProcessSession> position_ProcessSession
        {
            get { return this.GetRelatedEntities<ProcessSession>("position_ProcessSession", null); }
            set
            {
                this.OnPropertyChanging("position_ProcessSession");
                this.SetRelatedEntities<ProcessSession>("position_ProcessSession", null, value);
                this.OnPropertyChanged("position_ProcessSession");
            }
        }

        /// <summary>
        /// 1:N position_users
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("position_users")]
        public System.Collections.Generic.IEnumerable<SystemUser> position_users
        {
            get { return this.GetRelatedEntities<SystemUser>("position_users", null); }
            set
            {
                this.OnPropertyChanging("position_users");
                this.SetRelatedEntities<SystemUser>("position_users", null, value);
                this.OnPropertyChanged("position_users");
            }
        }

        /// <summary>
        /// N:1 lk_position_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_position_createdby")]
        public SystemUser lk_position_createdby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_position_createdby", null); }
        }

        /// <summary>
        /// N:1 lk_position_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_position_createdonbehalfby")]
        public SystemUser lk_position_createdonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_position_createdonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_position_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_position_modifiedby")]
        public SystemUser lk_position_modifiedby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_position_modifiedby", null); }
        }

        /// <summary>
        /// N:1 lk_position_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_position_modifiedonbehalfby")]
        public SystemUser lk_position_modifiedonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_position_modifiedonbehalfby", null); }
        }

        /// <summary>
        /// N:1 organization_position
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_position")]
        public Organization organization_position
        {
            get { return this.GetRelatedEntity<Organization>("organization_position", null); }
        }

        /// <summary>
        /// N:1 position_parent_position
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("parentpositionid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("position_parent_position", Microsoft.Xrm.Sdk.EntityRole.Referencing)]
        public Position Referencingposition_parent_position
        {
            get { return this.GetRelatedEntity<Position>("position_parent_position", Microsoft.Xrm.Sdk.EntityRole.Referencing); }
            set
            {
                this.OnPropertyChanging("Referencingposition_parent_position");
                this.SetRelatedEntity<Position>("position_parent_position", Microsoft.Xrm.Sdk.EntityRole.Referencing, value);
                this.OnPropertyChanged("Referencingposition_parent_position");
            }
        }

        /// <summary>
        /// N:1 transactioncurrency_position
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("transactioncurrency_position")]
        public TransactionCurrency transactioncurrency_position
        {
            get { return this.GetRelatedEntity<TransactionCurrency>("transactioncurrency_position", null); }
            set
            {
                this.OnPropertyChanging("transactioncurrency_position");
                this.SetRelatedEntity<TransactionCurrency>("transactioncurrency_position", null, value);
                this.OnPropertyChanged("transactioncurrency_position");
            }
        }
    }
}