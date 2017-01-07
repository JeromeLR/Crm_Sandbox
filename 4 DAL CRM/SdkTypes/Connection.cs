using _4_DAL_CRM;

namespace __4_DAL_CRM
{
    /// <summary>
    /// Relationship between two entities.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("connection")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class Connection : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public Connection() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "connection";

        public const int EntityTypeCode = 3234;

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
        /// Unique identifier of the connection.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("connectionid")]
        public System.Nullable<System.Guid> ConnectionId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("connectionid"); }
            set
            {
                this.OnPropertyChanging("ConnectionId");
                this.SetAttributeValue("connectionid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("ConnectionId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("connectionid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.ConnectionId = value; }
        }

        /// <summary>
        /// Shows who created the record.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby"); }
        }

        /// <summary>
        /// Shows the date and time when the record was created. The date and time are displayed in the time zone selected in Microsoft Dynamics CRM options.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
        public System.Nullable<System.DateTime> CreatedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon"); }
        }

        /// <summary>
        /// Shows who created the record on behalf of another user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        /// Type additional information to describe the connection, such as the length or quality of the relationship.
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
        /// Enter the end date of the connection.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("effectiveend")]
        public System.Nullable<System.DateTime> EffectiveEnd
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("effectiveend"); }
            set
            {
                this.OnPropertyChanging("EffectiveEnd");
                this.SetAttributeValue("effectiveend", value);
                this.OnPropertyChanged("EffectiveEnd");
            }
        }

        /// <summary>
        /// Enter the start date of the connection.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("effectivestart")]
        public System.Nullable<System.DateTime> EffectiveStart
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("effectivestart"); }
            set
            {
                this.OnPropertyChanging("EffectiveStart");
                this.SetAttributeValue("effectivestart", value);
                this.OnPropertyChanged("EffectiveStart");
            }
        }

        /// <summary>
        /// The default image for the entity.
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
        /// Shows the conversion rate of the record's currency. The exchange rate is used to convert all money fields in the record from the local currency to the system's default currency.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("exchangerate")]
        public System.Nullable<decimal> ExchangeRate
        {
            get { return this.GetAttributeValue<System.Nullable<decimal>>("exchangerate"); }
        }

        /// <summary>
        /// Unique identifier of the data import or data migration that created this record.
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
        /// Indicates that this is the master record.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ismaster")]
        public System.Nullable<bool> IsMaster
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("ismaster"); }
        }

        /// <summary>
        /// Shows who last updated the record.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby"); }
        }

        /// <summary>
        /// Shows the date and time when the record was last updated. The date and time are displayed in the time zone selected in Microsoft Dynamics CRM options.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
        public System.Nullable<System.DateTime> ModifiedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon"); }
        }

        /// <summary>
        /// Shows who last updated the record on behalf of another user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        /// Name of the connection.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("name")]
        public string Name
        {
            get { return this.GetAttributeValue<string>("name"); }
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
        /// Enter the user or team who is assigned to manage the record. This field is updated every time the record is assigned to a different user.
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
        /// Shows the business unit that the record owner belongs to.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
        public Microsoft.Xrm.Sdk.EntityReference OwningBusinessUnit
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningbusinessunit"); }
        }

        /// <summary>
        /// Unique identifier of the team who owns the connection.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
        public Microsoft.Xrm.Sdk.EntityReference OwningTeam
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningteam"); }
        }

        /// <summary>
        /// Unique identifier of the user who owns the connection.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
        public Microsoft.Xrm.Sdk.EntityReference OwningUser
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owninguser"); }
        }

        /// <summary>
        /// Unique identifier of the source record.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("record1id")]
        public Microsoft.Xrm.Sdk.EntityReference Record1Id
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("record1id"); }
            set
            {
                this.OnPropertyChanging("Record1Id");
                this.SetAttributeValue("record1id", value);
                this.OnPropertyChanged("Record1Id");
            }
        }

        /// <summary>
        /// Shows the record type of the source record.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("record1objecttypecode")]
        public Microsoft.Xrm.Sdk.OptionSetValue Record1ObjectTypeCode
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("record1objecttypecode"); }
        }

        /// <summary>
        /// Choose the primary party's role or relationship with the second party.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("record1roleid")]
        public Microsoft.Xrm.Sdk.EntityReference Record1RoleId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("record1roleid"); }
            set
            {
                this.OnPropertyChanging("Record1RoleId");
                this.SetAttributeValue("record1roleid", value);
                this.OnPropertyChanged("Record1RoleId");
            }
        }

        /// <summary>
        /// Unique identifier of the target record.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("record2id")]
        public Microsoft.Xrm.Sdk.EntityReference Record2Id
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("record2id"); }
            set
            {
                this.OnPropertyChanging("Record2Id");
                this.SetAttributeValue("record2id", value);
                this.OnPropertyChanged("Record2Id");
            }
        }

        /// <summary>
        /// Shows the record type of the target record.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("record2objecttypecode")]
        public Microsoft.Xrm.Sdk.OptionSetValue Record2ObjectTypeCode
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("record2objecttypecode"); }
        }

        /// <summary>
        /// Choose the secondary party's role or relationship with the primary party.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("record2roleid")]
        public Microsoft.Xrm.Sdk.EntityReference Record2RoleId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("record2roleid"); }
            set
            {
                this.OnPropertyChanging("Record2RoleId");
                this.SetAttributeValue("record2roleid", value);
                this.OnPropertyChanged("Record2RoleId");
            }
        }

        /// <summary>
        /// Unique identifier for the reciprocal connection record.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("relatedconnectionid")]
        public Microsoft.Xrm.Sdk.EntityReference RelatedConnectionId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("relatedconnectionid"); }
        }

        /// <summary>
        /// Shows whether the connection is active or inactive. Inactive connections are read-only and can't be edited unless they are reactivated.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
        public System.Nullable<ConnectionState> StateCode
        {
            get
            {
                Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
                if ((optionSet != null))
                {
                    return ((ConnectionState) (System.Enum.ToObject(typeof(ConnectionState), optionSet.Value)));
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// Reason for the status of the connection.
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
        /// Choose the local currency for the record to make sure budgets are reported in the correct currency.
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
        /// Version number of the connection.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
        public System.Nullable<long> VersionNumber
        {
            get { return this.GetAttributeValue<System.Nullable<long>>("versionnumber"); }
        }

        /// <summary>
        /// 1:N Connection_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Connection_AsyncOperations")]
        public System.Collections.Generic.IEnumerable<AsyncOperation> Connection_AsyncOperations
        {
            get { return this.GetRelatedEntities<AsyncOperation>("Connection_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("Connection_AsyncOperations");
                this.SetRelatedEntities<AsyncOperation>("Connection_AsyncOperations", null, value);
                this.OnPropertyChanged("Connection_AsyncOperations");
            }
        }

        /// <summary>
        /// 1:N connection_principalobjectattributeaccess
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("connection_principalobjectattributeaccess")]
        public System.Collections.Generic.IEnumerable<PrincipalObjectAttributeAccess> connection_principalobjectattributeaccess
        {
            get { return this.GetRelatedEntities<PrincipalObjectAttributeAccess>("connection_principalobjectattributeaccess", null); }
            set
            {
                this.OnPropertyChanging("connection_principalobjectattributeaccess");
                this.SetRelatedEntities<PrincipalObjectAttributeAccess>("connection_principalobjectattributeaccess", null, value);
                this.OnPropertyChanged("connection_principalobjectattributeaccess");
            }
        }

        /// <summary>
        /// 1:N Connection_ProcessSessions
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Connection_ProcessSessions")]
        public System.Collections.Generic.IEnumerable<ProcessSession> Connection_ProcessSessions
        {
            get { return this.GetRelatedEntities<ProcessSession>("Connection_ProcessSessions", null); }
            set
            {
                this.OnPropertyChanging("Connection_ProcessSessions");
                this.SetRelatedEntities<ProcessSession>("Connection_ProcessSessions", null, value);
                this.OnPropertyChanged("Connection_ProcessSessions");
            }
        }

        /// <summary>
        /// 1:N connection_related_connection
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("connection_related_connection", Microsoft.Xrm.Sdk.EntityRole.Referenced)]
        public System.Collections.Generic.IEnumerable<Connection> Referencedconnection_related_connection
        {
            get { return this.GetRelatedEntities<Connection>("connection_related_connection", Microsoft.Xrm.Sdk.EntityRole.Referenced); }
            set
            {
                this.OnPropertyChanging("Referencedconnection_related_connection");
                this.SetRelatedEntities<Connection>("connection_related_connection", Microsoft.Xrm.Sdk.EntityRole.Referenced, value);
                this.OnPropertyChanged("Referencedconnection_related_connection");
            }
        }

        /// <summary>
        /// 1:N userentityinstancedata_connection
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_connection")]
        public System.Collections.Generic.IEnumerable<UserEntityInstanceData> userentityinstancedata_connection
        {
            get { return this.GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_connection", null); }
            set
            {
                this.OnPropertyChanging("userentityinstancedata_connection");
                this.SetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_connection", null, value);
                this.OnPropertyChanged("userentityinstancedata_connection");
            }
        }

        /// <summary>
        /// N:1 account_connections1
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("record1id")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("account_connections1")]
        public Account account_connections1
        {
            get { return this.GetRelatedEntity<Account>("account_connections1", null); }
            set
            {
                this.OnPropertyChanging("account_connections1");
                this.SetRelatedEntity<Account>("account_connections1", null, value);
                this.OnPropertyChanged("account_connections1");
            }
        }

        /// <summary>
        /// N:1 account_connections2
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("record2id")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("account_connections2")]
        public Account account_connections2
        {
            get { return this.GetRelatedEntity<Account>("account_connections2", null); }
            set
            {
                this.OnPropertyChanging("account_connections2");
                this.SetRelatedEntity<Account>("account_connections2", null, value);
                this.OnPropertyChanged("account_connections2");
            }
        }

        /// <summary>
        /// N:1 activitypointer_connections1
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("record1id")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("activitypointer_connections1")]
        public ActivityPointer activitypointer_connections1
        {
            get { return this.GetRelatedEntity<ActivityPointer>("activitypointer_connections1", null); }
            set
            {
                this.OnPropertyChanging("activitypointer_connections1");
                this.SetRelatedEntity<ActivityPointer>("activitypointer_connections1", null, value);
                this.OnPropertyChanged("activitypointer_connections1");
            }
        }

        /// <summary>
        /// N:1 activitypointer_connections2
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("record2id")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("activitypointer_connections2")]
        public ActivityPointer activitypointer_connections2
        {
            get { return this.GetRelatedEntity<ActivityPointer>("activitypointer_connections2", null); }
            set
            {
                this.OnPropertyChanging("activitypointer_connections2");
                this.SetRelatedEntity<ActivityPointer>("activitypointer_connections2", null, value);
                this.OnPropertyChanged("activitypointer_connections2");
            }
        }

        /// <summary>
        /// N:1 appointment_connections1
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("record1id")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("appointment_connections1")]
        public Appointment appointment_connections1
        {
            get { return this.GetRelatedEntity<Appointment>("appointment_connections1", null); }
            set
            {
                this.OnPropertyChanging("appointment_connections1");
                this.SetRelatedEntity<Appointment>("appointment_connections1", null, value);
                this.OnPropertyChanged("appointment_connections1");
            }
        }

        /// <summary>
        /// N:1 appointment_connections2
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("record2id")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("appointment_connections2")]
        public Appointment appointment_connections2
        {
            get { return this.GetRelatedEntity<Appointment>("appointment_connections2", null); }
            set
            {
                this.OnPropertyChanging("appointment_connections2");
                this.SetRelatedEntity<Appointment>("appointment_connections2", null, value);
                this.OnPropertyChanged("appointment_connections2");
            }
        }

        /// <summary>
        /// N:1 business_unit_connections
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_connections")]
        public BusinessUnit business_unit_connections
        {
            get { return this.GetRelatedEntity<BusinessUnit>("business_unit_connections", null); }
        }

        /// <summary>
        /// N:1 campaign_connections1
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("record1id")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("campaign_connections1")]
        public Campaign campaign_connections1
        {
            get { return this.GetRelatedEntity<Campaign>("campaign_connections1", null); }
            set
            {
                this.OnPropertyChanging("campaign_connections1");
                this.SetRelatedEntity<Campaign>("campaign_connections1", null, value);
                this.OnPropertyChanged("campaign_connections1");
            }
        }

        /// <summary>
        /// N:1 campaign_connections2
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("record2id")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("campaign_connections2")]
        public Campaign campaign_connections2
        {
            get { return this.GetRelatedEntity<Campaign>("campaign_connections2", null); }
            set
            {
                this.OnPropertyChanging("campaign_connections2");
                this.SetRelatedEntity<Campaign>("campaign_connections2", null, value);
                this.OnPropertyChanged("campaign_connections2");
            }
        }

        /// <summary>
        /// N:1 campaignactivity_connections1
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("record1id")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("campaignactivity_connections1")]
        public CampaignActivity campaignactivity_connections1
        {
            get { return this.GetRelatedEntity<CampaignActivity>("campaignactivity_connections1", null); }
            set
            {
                this.OnPropertyChanging("campaignactivity_connections1");
                this.SetRelatedEntity<CampaignActivity>("campaignactivity_connections1", null, value);
                this.OnPropertyChanged("campaignactivity_connections1");
            }
        }

        /// <summary>
        /// N:1 campaignactivity_connections2
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("record2id")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("campaignactivity_connections2")]
        public CampaignActivity campaignactivity_connections2
        {
            get { return this.GetRelatedEntity<CampaignActivity>("campaignactivity_connections2", null); }
            set
            {
                this.OnPropertyChanging("campaignactivity_connections2");
                this.SetRelatedEntity<CampaignActivity>("campaignactivity_connections2", null, value);
                this.OnPropertyChanged("campaignactivity_connections2");
            }
        }

        /// <summary>
        /// N:1 competitor_connections1
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("record1id")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("competitor_connections1")]
        public Competitor competitor_connections1
        {
            get { return this.GetRelatedEntity<Competitor>("competitor_connections1", null); }
            set
            {
                this.OnPropertyChanging("competitor_connections1");
                this.SetRelatedEntity<Competitor>("competitor_connections1", null, value);
                this.OnPropertyChanged("competitor_connections1");
            }
        }

        /// <summary>
        /// N:1 competitor_connections2
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("record2id")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("competitor_connections2")]
        public Competitor competitor_connections2
        {
            get { return this.GetRelatedEntity<Competitor>("competitor_connections2", null); }
            set
            {
                this.OnPropertyChanging("competitor_connections2");
                this.SetRelatedEntity<Competitor>("competitor_connections2", null, value);
                this.OnPropertyChanged("competitor_connections2");
            }
        }

        /// <summary>
        /// N:1 connection_related_connection
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("relatedconnectionid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("connection_related_connection", Microsoft.Xrm.Sdk.EntityRole.Referencing)]
        public Connection Referencingconnection_related_connection
        {
            get { return this.GetRelatedEntity<Connection>("connection_related_connection", Microsoft.Xrm.Sdk.EntityRole.Referencing); }
        }

        /// <summary>
        /// N:1 connection_role_connections1
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("record1roleid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("connection_role_connections1")]
        public ConnectionRole connection_role_connections1
        {
            get { return this.GetRelatedEntity<ConnectionRole>("connection_role_connections1", null); }
            set
            {
                this.OnPropertyChanging("connection_role_connections1");
                this.SetRelatedEntity<ConnectionRole>("connection_role_connections1", null, value);
                this.OnPropertyChanged("connection_role_connections1");
            }
        }

        /// <summary>
        /// N:1 connection_role_connections2
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("record2roleid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("connection_role_connections2")]
        public ConnectionRole connection_role_connections2
        {
            get { return this.GetRelatedEntity<ConnectionRole>("connection_role_connections2", null); }
            set
            {
                this.OnPropertyChanging("connection_role_connections2");
                this.SetRelatedEntity<ConnectionRole>("connection_role_connections2", null, value);
                this.OnPropertyChanged("connection_role_connections2");
            }
        }

        /// <summary>
        /// N:1 constraintbasedgroup_connections1
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("record1id")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("constraintbasedgroup_connections1")]
        public ConstraintBasedGroup constraintbasedgroup_connections1
        {
            get { return this.GetRelatedEntity<ConstraintBasedGroup>("constraintbasedgroup_connections1", null); }
            set
            {
                this.OnPropertyChanging("constraintbasedgroup_connections1");
                this.SetRelatedEntity<ConstraintBasedGroup>("constraintbasedgroup_connections1", null, value);
                this.OnPropertyChanged("constraintbasedgroup_connections1");
            }
        }

        /// <summary>
        /// N:1 constraintbasedgroup_connections2
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("record2id")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("constraintbasedgroup_connections2")]
        public ConstraintBasedGroup constraintbasedgroup_connections2
        {
            get { return this.GetRelatedEntity<ConstraintBasedGroup>("constraintbasedgroup_connections2", null); }
            set
            {
                this.OnPropertyChanging("constraintbasedgroup_connections2");
                this.SetRelatedEntity<ConstraintBasedGroup>("constraintbasedgroup_connections2", null, value);
                this.OnPropertyChanged("constraintbasedgroup_connections2");
            }
        }

        /// <summary>
        /// N:1 contact_connections1
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("record1id")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("contact_connections1")]
        public Contact contact_connections1
        {
            get { return this.GetRelatedEntity<Contact>("contact_connections1", null); }
            set
            {
                this.OnPropertyChanging("contact_connections1");
                this.SetRelatedEntity<Contact>("contact_connections1", null, value);
                this.OnPropertyChanged("contact_connections1");
            }
        }

        /// <summary>
        /// N:1 contact_connections2
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("record2id")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("contact_connections2")]
        public Contact contact_connections2
        {
            get { return this.GetRelatedEntity<Contact>("contact_connections2", null); }
            set
            {
                this.OnPropertyChanging("contact_connections2");
                this.SetRelatedEntity<Contact>("contact_connections2", null, value);
                this.OnPropertyChanged("contact_connections2");
            }
        }

        /// <summary>
        /// N:1 contract_connections1
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("record1id")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("contract_connections1")]
        public Contract contract_connections1
        {
            get { return this.GetRelatedEntity<Contract>("contract_connections1", null); }
            set
            {
                this.OnPropertyChanging("contract_connections1");
                this.SetRelatedEntity<Contract>("contract_connections1", null, value);
                this.OnPropertyChanged("contract_connections1");
            }
        }

        /// <summary>
        /// N:1 contract_connections2
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("record2id")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("contract_connections2")]
        public Contract contract_connections2
        {
            get { return this.GetRelatedEntity<Contract>("contract_connections2", null); }
            set
            {
                this.OnPropertyChanging("contract_connections2");
                this.SetRelatedEntity<Contract>("contract_connections2", null, value);
                this.OnPropertyChanged("contract_connections2");
            }
        }

        /// <summary>
        /// N:1 createdby_connection
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("createdby_connection")]
        public SystemUser createdby_connection
        {
            get { return this.GetRelatedEntity<SystemUser>("createdby_connection", null); }
        }

        /// <summary>
        /// N:1 email_connections1
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("record1id")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("email_connections1")]
        public Email email_connections1
        {
            get { return this.GetRelatedEntity<Email>("email_connections1", null); }
            set
            {
                this.OnPropertyChanging("email_connections1");
                this.SetRelatedEntity<Email>("email_connections1", null, value);
                this.OnPropertyChanged("email_connections1");
            }
        }

        /// <summary>
        /// N:1 email_connections2
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("record2id")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("email_connections2")]
        public Email email_connections2
        {
            get { return this.GetRelatedEntity<Email>("email_connections2", null); }
            set
            {
                this.OnPropertyChanging("email_connections2");
                this.SetRelatedEntity<Email>("email_connections2", null, value);
                this.OnPropertyChanged("email_connections2");
            }
        }

        /// <summary>
        /// N:1 entitlement_connections1
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("record1id")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("entitlement_connections1")]
        public Entitlement entitlement_connections1
        {
            get { return this.GetRelatedEntity<Entitlement>("entitlement_connections1", null); }
            set
            {
                this.OnPropertyChanging("entitlement_connections1");
                this.SetRelatedEntity<Entitlement>("entitlement_connections1", null, value);
                this.OnPropertyChanged("entitlement_connections1");
            }
        }

        /// <summary>
        /// N:1 entitlement_connections2
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("record2id")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("entitlement_connections2")]
        public Entitlement entitlement_connections2
        {
            get { return this.GetRelatedEntity<Entitlement>("entitlement_connections2", null); }
            set
            {
                this.OnPropertyChanging("entitlement_connections2");
                this.SetRelatedEntity<Entitlement>("entitlement_connections2", null, value);
                this.OnPropertyChanged("entitlement_connections2");
            }
        }

        /// <summary>
        /// N:1 equipment_connections1
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("record1id")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("equipment_connections1")]
        public Equipment equipment_connections1
        {
            get { return this.GetRelatedEntity<Equipment>("equipment_connections1", null); }
            set
            {
                this.OnPropertyChanging("equipment_connections1");
                this.SetRelatedEntity<Equipment>("equipment_connections1", null, value);
                this.OnPropertyChanged("equipment_connections1");
            }
        }

        /// <summary>
        /// N:1 equipment_connections2
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("record2id")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("equipment_connections2")]
        public Equipment equipment_connections2
        {
            get { return this.GetRelatedEntity<Equipment>("equipment_connections2", null); }
            set
            {
                this.OnPropertyChanging("equipment_connections2");
                this.SetRelatedEntity<Equipment>("equipment_connections2", null, value);
                this.OnPropertyChanged("equipment_connections2");
            }
        }

        /// <summary>
        /// N:1 fax_connections1
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("record1id")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("fax_connections1")]
        public Fax fax_connections1
        {
            get { return this.GetRelatedEntity<Fax>("fax_connections1", null); }
            set
            {
                this.OnPropertyChanging("fax_connections1");
                this.SetRelatedEntity<Fax>("fax_connections1", null, value);
                this.OnPropertyChanged("fax_connections1");
            }
        }

        /// <summary>
        /// N:1 fax_connections2
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("record2id")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("fax_connections2")]
        public Fax fax_connections2
        {
            get { return this.GetRelatedEntity<Fax>("fax_connections2", null); }
            set
            {
                this.OnPropertyChanging("fax_connections2");
                this.SetRelatedEntity<Fax>("fax_connections2", null, value);
                this.OnPropertyChanged("fax_connections2");
            }
        }

        /// <summary>
        /// N:1 goal_connections1
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("record1id")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("goal_connections1")]
        public Goal goal_connections1
        {
            get { return this.GetRelatedEntity<Goal>("goal_connections1", null); }
            set
            {
                this.OnPropertyChanging("goal_connections1");
                this.SetRelatedEntity<Goal>("goal_connections1", null, value);
                this.OnPropertyChanged("goal_connections1");
            }
        }

        /// <summary>
        /// N:1 goal_connections2
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("record2id")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("goal_connections2")]
        public Goal goal_connections2
        {
            get { return this.GetRelatedEntity<Goal>("goal_connections2", null); }
            set
            {
                this.OnPropertyChanging("goal_connections2");
                this.SetRelatedEntity<Goal>("goal_connections2", null, value);
                this.OnPropertyChanged("goal_connections2");
            }
        }

        /// <summary>
        /// N:1 incident_connections1
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("record1id")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("incident_connections1")]
        public Incident incident_connections1
        {
            get { return this.GetRelatedEntity<Incident>("incident_connections1", null); }
            set
            {
                this.OnPropertyChanging("incident_connections1");
                this.SetRelatedEntity<Incident>("incident_connections1", null, value);
                this.OnPropertyChanged("incident_connections1");
            }
        }

        /// <summary>
        /// N:1 incident_connections2
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("record2id")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("incident_connections2")]
        public Incident incident_connections2
        {
            get { return this.GetRelatedEntity<Incident>("incident_connections2", null); }
            set
            {
                this.OnPropertyChanging("incident_connections2");
                this.SetRelatedEntity<Incident>("incident_connections2", null, value);
                this.OnPropertyChanged("incident_connections2");
            }
        }

        /// <summary>
        /// N:1 invoice_connections1
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("record1id")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("invoice_connections1")]
        public Invoice invoice_connections1
        {
            get { return this.GetRelatedEntity<Invoice>("invoice_connections1", null); }
            set
            {
                this.OnPropertyChanging("invoice_connections1");
                this.SetRelatedEntity<Invoice>("invoice_connections1", null, value);
                this.OnPropertyChanged("invoice_connections1");
            }
        }

        /// <summary>
        /// N:1 invoice_connections2
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("record2id")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("invoice_connections2")]
        public Invoice invoice_connections2
        {
            get { return this.GetRelatedEntity<Invoice>("invoice_connections2", null); }
            set
            {
                this.OnPropertyChanging("invoice_connections2");
                this.SetRelatedEntity<Invoice>("invoice_connections2", null, value);
                this.OnPropertyChanged("invoice_connections2");
            }
        }

        /// <summary>
        /// N:1 lead_connections1
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("record1id")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lead_connections1")]
        public Lead lead_connections1
        {
            get { return this.GetRelatedEntity<Lead>("lead_connections1", null); }
            set
            {
                this.OnPropertyChanging("lead_connections1");
                this.SetRelatedEntity<Lead>("lead_connections1", null, value);
                this.OnPropertyChanged("lead_connections1");
            }
        }

        /// <summary>
        /// N:1 lead_connections2
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("record2id")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lead_connections2")]
        public Lead lead_connections2
        {
            get { return this.GetRelatedEntity<Lead>("lead_connections2", null); }
            set
            {
                this.OnPropertyChanging("lead_connections2");
                this.SetRelatedEntity<Lead>("lead_connections2", null, value);
                this.OnPropertyChanged("lead_connections2");
            }
        }

        /// <summary>
        /// N:1 letter_connections1
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("record1id")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("letter_connections1")]
        public Letter letter_connections1
        {
            get { return this.GetRelatedEntity<Letter>("letter_connections1", null); }
            set
            {
                this.OnPropertyChanging("letter_connections1");
                this.SetRelatedEntity<Letter>("letter_connections1", null, value);
                this.OnPropertyChanged("letter_connections1");
            }
        }

        /// <summary>
        /// N:1 letter_connections2
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("record2id")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("letter_connections2")]
        public Letter letter_connections2
        {
            get { return this.GetRelatedEntity<Letter>("letter_connections2", null); }
            set
            {
                this.OnPropertyChanging("letter_connections2");
                this.SetRelatedEntity<Letter>("letter_connections2", null, value);
                this.OnPropertyChanged("letter_connections2");
            }
        }

        /// <summary>
        /// N:1 list_connections1
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("record1id")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("list_connections1")]
        public List list_connections1
        {
            get { return this.GetRelatedEntity<List>("list_connections1", null); }
            set
            {
                this.OnPropertyChanging("list_connections1");
                this.SetRelatedEntity<List>("list_connections1", null, value);
                this.OnPropertyChanged("list_connections1");
            }
        }

        /// <summary>
        /// N:1 list_connections2
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("record2id")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("list_connections2")]
        public List list_connections2
        {
            get { return this.GetRelatedEntity<List>("list_connections2", null); }
            set
            {
                this.OnPropertyChanging("list_connections2");
                this.SetRelatedEntity<List>("list_connections2", null, value);
                this.OnPropertyChanged("list_connections2");
            }
        }

        /// <summary>
        /// N:1 lk_connectionbase_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_connectionbase_createdonbehalfby")]
        public SystemUser lk_connectionbase_createdonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_connectionbase_createdonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_connectionbase_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_connectionbase_modifiedonbehalfby")]
        public SystemUser lk_connectionbase_modifiedonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_connectionbase_modifiedonbehalfby", null); }
        }

        /// <summary>
        /// N:1 modifiedby_connection
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("modifiedby_connection")]
        public SystemUser modifiedby_connection
        {
            get { return this.GetRelatedEntity<SystemUser>("modifiedby_connection", null); }
        }

        /// <summary>
        /// N:1 msdyn_postalbum_connections1
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("record1id")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_postalbum_connections1")]
        public msdyn_PostAlbum msdyn_postalbum_connections1
        {
            get { return this.GetRelatedEntity<msdyn_PostAlbum>("msdyn_postalbum_connections1", null); }
            set
            {
                this.OnPropertyChanging("msdyn_postalbum_connections1");
                this.SetRelatedEntity<msdyn_PostAlbum>("msdyn_postalbum_connections1", null, value);
                this.OnPropertyChanged("msdyn_postalbum_connections1");
            }
        }

        /// <summary>
        /// N:1 msdyn_postalbum_connections2
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("record2id")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_postalbum_connections2")]
        public msdyn_PostAlbum msdyn_postalbum_connections2
        {
            get { return this.GetRelatedEntity<msdyn_PostAlbum>("msdyn_postalbum_connections2", null); }
            set
            {
                this.OnPropertyChanging("msdyn_postalbum_connections2");
                this.SetRelatedEntity<msdyn_PostAlbum>("msdyn_postalbum_connections2", null, value);
                this.OnPropertyChanged("msdyn_postalbum_connections2");
            }
        }

        /// <summary>
        /// N:1 opportunity_connections1
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("record1id")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("opportunity_connections1")]
        public Opportunity opportunity_connections1
        {
            get { return this.GetRelatedEntity<Opportunity>("opportunity_connections1", null); }
            set
            {
                this.OnPropertyChanging("opportunity_connections1");
                this.SetRelatedEntity<Opportunity>("opportunity_connections1", null, value);
                this.OnPropertyChanged("opportunity_connections1");
            }
        }

        /// <summary>
        /// N:1 opportunity_connections2
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("record2id")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("opportunity_connections2")]
        public Opportunity opportunity_connections2
        {
            get { return this.GetRelatedEntity<Opportunity>("opportunity_connections2", null); }
            set
            {
                this.OnPropertyChanging("opportunity_connections2");
                this.SetRelatedEntity<Opportunity>("opportunity_connections2", null, value);
                this.OnPropertyChanged("opportunity_connections2");
            }
        }

        /// <summary>
        /// N:1 phonecall_connections1
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("record1id")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("phonecall_connections1")]
        public PhoneCall phonecall_connections1
        {
            get { return this.GetRelatedEntity<PhoneCall>("phonecall_connections1", null); }
            set
            {
                this.OnPropertyChanging("phonecall_connections1");
                this.SetRelatedEntity<PhoneCall>("phonecall_connections1", null, value);
                this.OnPropertyChanged("phonecall_connections1");
            }
        }

        /// <summary>
        /// N:1 phonecall_connections2
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("record2id")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("phonecall_connections2")]
        public PhoneCall phonecall_connections2
        {
            get { return this.GetRelatedEntity<PhoneCall>("phonecall_connections2", null); }
            set
            {
                this.OnPropertyChanging("phonecall_connections2");
                this.SetRelatedEntity<PhoneCall>("phonecall_connections2", null, value);
                this.OnPropertyChanged("phonecall_connections2");
            }
        }

        /// <summary>
        /// N:1 position_connection1
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("record1id")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("position_connection1")]
        public Position position_connection1
        {
            get { return this.GetRelatedEntity<Position>("position_connection1", null); }
            set
            {
                this.OnPropertyChanging("position_connection1");
                this.SetRelatedEntity<Position>("position_connection1", null, value);
                this.OnPropertyChanged("position_connection1");
            }
        }

        /// <summary>
        /// N:1 position_connection2
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("record2id")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("position_connection2")]
        public Position position_connection2
        {
            get { return this.GetRelatedEntity<Position>("position_connection2", null); }
            set
            {
                this.OnPropertyChanging("position_connection2");
                this.SetRelatedEntity<Position>("position_connection2", null, value);
                this.OnPropertyChanged("position_connection2");
            }
        }

        /// <summary>
        /// N:1 pricelevel_connections1
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("record1id")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("pricelevel_connections1")]
        public PriceLevel pricelevel_connections1
        {
            get { return this.GetRelatedEntity<PriceLevel>("pricelevel_connections1", null); }
            set
            {
                this.OnPropertyChanging("pricelevel_connections1");
                this.SetRelatedEntity<PriceLevel>("pricelevel_connections1", null, value);
                this.OnPropertyChanged("pricelevel_connections1");
            }
        }

        /// <summary>
        /// N:1 pricelevel_connections2
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("record2id")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("pricelevel_connections2")]
        public PriceLevel pricelevel_connections2
        {
            get { return this.GetRelatedEntity<PriceLevel>("pricelevel_connections2", null); }
            set
            {
                this.OnPropertyChanging("pricelevel_connections2");
                this.SetRelatedEntity<PriceLevel>("pricelevel_connections2", null, value);
                this.OnPropertyChanged("pricelevel_connections2");
            }
        }

        /// <summary>
        /// N:1 processsession_connections1
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("record1id")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("processsession_connections1")]
        public ProcessSession processsession_connections1
        {
            get { return this.GetRelatedEntity<ProcessSession>("processsession_connections1", null); }
            set
            {
                this.OnPropertyChanging("processsession_connections1");
                this.SetRelatedEntity<ProcessSession>("processsession_connections1", null, value);
                this.OnPropertyChanged("processsession_connections1");
            }
        }

        /// <summary>
        /// N:1 processsession_connections2
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("record2id")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("processsession_connections2")]
        public ProcessSession processsession_connections2
        {
            get { return this.GetRelatedEntity<ProcessSession>("processsession_connections2", null); }
            set
            {
                this.OnPropertyChanging("processsession_connections2");
                this.SetRelatedEntity<ProcessSession>("processsession_connections2", null, value);
                this.OnPropertyChanged("processsession_connections2");
            }
        }

        /// <summary>
        /// N:1 quote_connections1
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("record1id")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("quote_connections1")]
        public Quote quote_connections1
        {
            get { return this.GetRelatedEntity<Quote>("quote_connections1", null); }
            set
            {
                this.OnPropertyChanging("quote_connections1");
                this.SetRelatedEntity<Quote>("quote_connections1", null, value);
                this.OnPropertyChanged("quote_connections1");
            }
        }

        /// <summary>
        /// N:1 quote_connections2
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("record2id")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("quote_connections2")]
        public Quote quote_connections2
        {
            get { return this.GetRelatedEntity<Quote>("quote_connections2", null); }
            set
            {
                this.OnPropertyChanging("quote_connections2");
                this.SetRelatedEntity<Quote>("quote_connections2", null, value);
                this.OnPropertyChanged("quote_connections2");
            }
        }

        /// <summary>
        /// N:1 recurringappointmentmaster_connections1
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("record1id")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("recurringappointmentmaster_connections1")]
        public RecurringAppointmentMaster recurringappointmentmaster_connections1
        {
            get { return this.GetRelatedEntity<RecurringAppointmentMaster>("recurringappointmentmaster_connections1", null); }
            set
            {
                this.OnPropertyChanging("recurringappointmentmaster_connections1");
                this.SetRelatedEntity<RecurringAppointmentMaster>("recurringappointmentmaster_connections1", null, value);
                this.OnPropertyChanged("recurringappointmentmaster_connections1");
            }
        }

        /// <summary>
        /// N:1 recurringappointmentmaster_connections2
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("record2id")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("recurringappointmentmaster_connections2")]
        public RecurringAppointmentMaster recurringappointmentmaster_connections2
        {
            get { return this.GetRelatedEntity<RecurringAppointmentMaster>("recurringappointmentmaster_connections2", null); }
            set
            {
                this.OnPropertyChanging("recurringappointmentmaster_connections2");
                this.SetRelatedEntity<RecurringAppointmentMaster>("recurringappointmentmaster_connections2", null, value);
                this.OnPropertyChanged("recurringappointmentmaster_connections2");
            }
        }

        /// <summary>
        /// N:1 resourcegroup_connections1
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("record1id")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("resourcegroup_connections1")]
        public ResourceGroup resourcegroup_connections1
        {
            get { return this.GetRelatedEntity<ResourceGroup>("resourcegroup_connections1", null); }
            set
            {
                this.OnPropertyChanging("resourcegroup_connections1");
                this.SetRelatedEntity<ResourceGroup>("resourcegroup_connections1", null, value);
                this.OnPropertyChanged("resourcegroup_connections1");
            }
        }

        /// <summary>
        /// N:1 resourcegroup_connections2
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("record2id")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("resourcegroup_connections2")]
        public ResourceGroup resourcegroup_connections2
        {
            get { return this.GetRelatedEntity<ResourceGroup>("resourcegroup_connections2", null); }
            set
            {
                this.OnPropertyChanging("resourcegroup_connections2");
                this.SetRelatedEntity<ResourceGroup>("resourcegroup_connections2", null, value);
                this.OnPropertyChanged("resourcegroup_connections2");
            }
        }

        /// <summary>
        /// N:1 salesorder_connections1
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("record1id")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("salesorder_connections1")]
        public SalesOrder salesorder_connections1
        {
            get { return this.GetRelatedEntity<SalesOrder>("salesorder_connections1", null); }
            set
            {
                this.OnPropertyChanging("salesorder_connections1");
                this.SetRelatedEntity<SalesOrder>("salesorder_connections1", null, value);
                this.OnPropertyChanged("salesorder_connections1");
            }
        }

        /// <summary>
        /// N:1 salesorder_connections2
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("record2id")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("salesorder_connections2")]
        public SalesOrder salesorder_connections2
        {
            get { return this.GetRelatedEntity<SalesOrder>("salesorder_connections2", null); }
            set
            {
                this.OnPropertyChanging("salesorder_connections2");
                this.SetRelatedEntity<SalesOrder>("salesorder_connections2", null, value);
                this.OnPropertyChanged("salesorder_connections2");
            }
        }

        /// <summary>
        /// N:1 serviceappointment_connections1
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("record1id")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("serviceappointment_connections1")]
        public ServiceAppointment serviceappointment_connections1
        {
            get { return this.GetRelatedEntity<ServiceAppointment>("serviceappointment_connections1", null); }
            set
            {
                this.OnPropertyChanging("serviceappointment_connections1");
                this.SetRelatedEntity<ServiceAppointment>("serviceappointment_connections1", null, value);
                this.OnPropertyChanged("serviceappointment_connections1");
            }
        }

        /// <summary>
        /// N:1 serviceappointment_connections2
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("record2id")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("serviceappointment_connections2")]
        public ServiceAppointment serviceappointment_connections2
        {
            get { return this.GetRelatedEntity<ServiceAppointment>("serviceappointment_connections2", null); }
            set
            {
                this.OnPropertyChanging("serviceappointment_connections2");
                this.SetRelatedEntity<ServiceAppointment>("serviceappointment_connections2", null, value);
                this.OnPropertyChanged("serviceappointment_connections2");
            }
        }

        /// <summary>
        /// N:1 socialactivity_connections1
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("record1id")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("socialactivity_connections1")]
        public SocialActivity socialactivity_connections1
        {
            get { return this.GetRelatedEntity<SocialActivity>("socialactivity_connections1", null); }
            set
            {
                this.OnPropertyChanging("socialactivity_connections1");
                this.SetRelatedEntity<SocialActivity>("socialactivity_connections1", null, value);
                this.OnPropertyChanged("socialactivity_connections1");
            }
        }

        /// <summary>
        /// N:1 socialactivity_connections2
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("record2id")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("socialactivity_connections2")]
        public SocialActivity socialactivity_connections2
        {
            get { return this.GetRelatedEntity<SocialActivity>("socialactivity_connections2", null); }
            set
            {
                this.OnPropertyChanging("socialactivity_connections2");
                this.SetRelatedEntity<SocialActivity>("socialactivity_connections2", null, value);
                this.OnPropertyChanged("socialactivity_connections2");
            }
        }

        /// <summary>
        /// N:1 socialprofile_connections1
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("record1id")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("socialprofile_connections1")]
        public SocialProfile socialprofile_connections1
        {
            get { return this.GetRelatedEntity<SocialProfile>("socialprofile_connections1", null); }
            set
            {
                this.OnPropertyChanging("socialprofile_connections1");
                this.SetRelatedEntity<SocialProfile>("socialprofile_connections1", null, value);
                this.OnPropertyChanged("socialprofile_connections1");
            }
        }

        /// <summary>
        /// N:1 socialprofile_connections2
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("record2id")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("socialprofile_connections2")]
        public SocialProfile socialprofile_connections2
        {
            get { return this.GetRelatedEntity<SocialProfile>("socialprofile_connections2", null); }
            set
            {
                this.OnPropertyChanging("socialprofile_connections2");
                this.SetRelatedEntity<SocialProfile>("socialprofile_connections2", null, value);
                this.OnPropertyChanged("socialprofile_connections2");
            }
        }

        /// <summary>
        /// N:1 systemuser_connections1
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("record1id")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("systemuser_connections1")]
        public SystemUser systemuser_connections1
        {
            get { return this.GetRelatedEntity<SystemUser>("systemuser_connections1", null); }
            set
            {
                this.OnPropertyChanging("systemuser_connections1");
                this.SetRelatedEntity<SystemUser>("systemuser_connections1", null, value);
                this.OnPropertyChanged("systemuser_connections1");
            }
        }

        /// <summary>
        /// N:1 systemuser_connections2
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("record2id")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("systemuser_connections2")]
        public SystemUser systemuser_connections2
        {
            get { return this.GetRelatedEntity<SystemUser>("systemuser_connections2", null); }
            set
            {
                this.OnPropertyChanging("systemuser_connections2");
                this.SetRelatedEntity<SystemUser>("systemuser_connections2", null, value);
                this.OnPropertyChanged("systemuser_connections2");
            }
        }

        /// <summary>
        /// N:1 task_connections1
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("record1id")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("task_connections1")]
        public Task task_connections1
        {
            get { return this.GetRelatedEntity<Task>("task_connections1", null); }
            set
            {
                this.OnPropertyChanging("task_connections1");
                this.SetRelatedEntity<Task>("task_connections1", null, value);
                this.OnPropertyChanged("task_connections1");
            }
        }

        /// <summary>
        /// N:1 task_connections2
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("record2id")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("task_connections2")]
        public Task task_connections2
        {
            get { return this.GetRelatedEntity<Task>("task_connections2", null); }
            set
            {
                this.OnPropertyChanging("task_connections2");
                this.SetRelatedEntity<Task>("task_connections2", null, value);
                this.OnPropertyChanged("task_connections2");
            }
        }

        /// <summary>
        /// N:1 team_connections1
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("record1id")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_connections1")]
        public Team team_connections1
        {
            get { return this.GetRelatedEntity<Team>("team_connections1", null); }
            set
            {
                this.OnPropertyChanging("team_connections1");
                this.SetRelatedEntity<Team>("team_connections1", null, value);
                this.OnPropertyChanged("team_connections1");
            }
        }

        /// <summary>
        /// N:1 team_connections2
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("record2id")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_connections2")]
        public Team team_connections2
        {
            get { return this.GetRelatedEntity<Team>("team_connections2", null); }
            set
            {
                this.OnPropertyChanging("team_connections2");
                this.SetRelatedEntity<Team>("team_connections2", null, value);
                this.OnPropertyChanged("team_connections2");
            }
        }

        /// <summary>
        /// N:1 territory_connections1
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("record1id")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("territory_connections1")]
        public Territory territory_connections1
        {
            get { return this.GetRelatedEntity<Territory>("territory_connections1", null); }
            set
            {
                this.OnPropertyChanging("territory_connections1");
                this.SetRelatedEntity<Territory>("territory_connections1", null, value);
                this.OnPropertyChanged("territory_connections1");
            }
        }

        /// <summary>
        /// N:1 territory_connections2
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("record2id")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("territory_connections2")]
        public Territory territory_connections2
        {
            get { return this.GetRelatedEntity<Territory>("territory_connections2", null); }
            set
            {
                this.OnPropertyChanging("territory_connections2");
                this.SetRelatedEntity<Territory>("territory_connections2", null, value);
                this.OnPropertyChanged("territory_connections2");
            }
        }

        /// <summary>
        /// N:1 TransactionCurrency_Connection
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("TransactionCurrency_Connection")]
        public TransactionCurrency TransactionCurrency_Connection
        {
            get { return this.GetRelatedEntity<TransactionCurrency>("TransactionCurrency_Connection", null); }
            set
            {
                this.OnPropertyChanging("TransactionCurrency_Connection");
                this.SetRelatedEntity<TransactionCurrency>("TransactionCurrency_Connection", null, value);
                this.OnPropertyChanged("TransactionCurrency_Connection");
            }
        }
    }
}