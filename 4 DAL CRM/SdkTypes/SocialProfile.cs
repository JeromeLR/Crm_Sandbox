using _4_DAL_CRM;

namespace __4_DAL_CRM
{
    /// <summary>
    /// This entity is used to store social profile information of its associated account and contacts on different social channels.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("socialprofile")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class SocialProfile : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public SocialProfile() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "socialprofile";

        public const int EntityTypeCode = 99;

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
        /// Identifies if the social profile has been blocked.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("blocked")]
        public System.Nullable<bool> Blocked
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("blocked"); }
            set
            {
                this.OnPropertyChanging("Blocked");
                this.SetAttributeValue("blocked", value);
                this.OnPropertyChanged("Blocked");
            }
        }

        /// <summary>
        /// Identifies where the social profile originated from, such as Twitter, or Facebook.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("community")]
        public Microsoft.Xrm.Sdk.OptionSetValue Community
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("community"); }
            set
            {
                this.OnPropertyChanging("Community");
                this.SetAttributeValue("community", value);
                this.OnPropertyChanged("Community");
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
        /// Shows the customer that this social profile belongs to.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("customerid")]
        public Microsoft.Xrm.Sdk.EntityReference CustomerId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("customerid"); }
            set
            {
                this.OnPropertyChanging("CustomerId");
                this.SetAttributeValue("customerid", value);
                this.OnPropertyChanged("CustomerId");
            }
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
        /// Shows the score that determines the online social influence of the social profile.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("influencescore")]
        public System.Nullable<double> InfluenceScore
        {
            get { return this.GetAttributeValue<System.Nullable<double>>("influencescore"); }
            set
            {
                this.OnPropertyChanging("InfluenceScore");
                this.SetAttributeValue("influencescore", value);
                this.OnPropertyChanged("InfluenceScore");
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
        /// Shows the user or team that is assigned to manage the record. This field is updated every time the record is assigned to a different user.
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
        /// Unique identifier for the business unit that owns the record
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
        public Microsoft.Xrm.Sdk.EntityReference OwningBusinessUnit
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningbusinessunit"); }
        }

        /// <summary>
        /// Unique identifier of the team who owns the contact.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
        public Microsoft.Xrm.Sdk.EntityReference OwningTeam
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningteam"); }
        }

        /// <summary>
        /// Unique identifier of the user who owns the contact.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
        public Microsoft.Xrm.Sdk.EntityReference OwningUser
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owninguser"); }
        }

        /// <summary>
        /// Shows the display name of the customer on this social profile.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("profilefullname")]
        public string ProfileFullName
        {
            get { return this.GetAttributeValue<string>("profilefullname"); }
            set
            {
                this.OnPropertyChanging("ProfileFullName");
                this.SetAttributeValue("profilefullname", value);
                this.OnPropertyChanged("ProfileFullName");
            }
        }

        /// <summary>
        /// Shows the customer that this social profile belongs to.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("profilelink")]
        public string ProfileLink
        {
            get { return this.GetAttributeValue<string>("profilelink"); }
            set
            {
                this.OnPropertyChanging("ProfileLink");
                this.SetAttributeValue("profilelink", value);
                this.OnPropertyChanged("ProfileLink");
            }
        }

        /// <summary>
        /// Shows the name of the social profile on the corresponding social channel.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("profilename")]
        public string ProfileName
        {
            get { return this.GetAttributeValue<string>("profilename"); }
            set
            {
                this.OnPropertyChanging("ProfileName");
                this.SetAttributeValue("profilename", value);
                this.OnPropertyChanged("ProfileName");
            }
        }

        /// <summary>
        /// Unique Identifier of the social profile name.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("socialprofileid")]
        public System.Nullable<System.Guid> SocialProfileId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("socialprofileid"); }
            set
            {
                this.OnPropertyChanging("SocialProfileId");
                this.SetAttributeValue("socialprofileid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("SocialProfileId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("socialprofileid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.SocialProfileId = value; }
        }

        /// <summary>
        /// Status of the Social Profile
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
        public System.Nullable<SocialProfileState> StateCode
        {
            get
            {
                Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
                if ((optionSet != null))
                {
                    return ((SocialProfileState) (System.Enum.ToObject(typeof(SocialProfileState), optionSet.Value)));
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// Reason for the status of the Social Profile
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
        /// Unique ID of the Profile ID
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("uniqueprofileid")]
        public string UniqueProfileID
        {
            get { return this.GetAttributeValue<string>("uniqueprofileid"); }
            set
            {
                this.OnPropertyChanging("UniqueProfileID");
                this.SetAttributeValue("uniqueprofileid", value);
                this.OnPropertyChanged("UniqueProfileID");
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
        /// Version number of the social profile.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
        public System.Nullable<long> VersionNumber
        {
            get { return this.GetAttributeValue<System.Nullable<long>>("versionnumber"); }
        }

        /// <summary>
        /// 1:N SocialProfile_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SocialProfile_AsyncOperations")]
        public System.Collections.Generic.IEnumerable<AsyncOperation> SocialProfile_AsyncOperations
        {
            get { return this.GetRelatedEntities<AsyncOperation>("SocialProfile_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("SocialProfile_AsyncOperations");
                this.SetRelatedEntities<AsyncOperation>("SocialProfile_AsyncOperations", null, value);
                this.OnPropertyChanged("SocialProfile_AsyncOperations");
            }
        }

        /// <summary>
        /// 1:N socialprofile_cases
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("socialprofile_cases")]
        public System.Collections.Generic.IEnumerable<Incident> socialprofile_cases
        {
            get { return this.GetRelatedEntities<Incident>("socialprofile_cases", null); }
            set
            {
                this.OnPropertyChanging("socialprofile_cases");
                this.SetRelatedEntities<Incident>("socialprofile_cases", null, value);
                this.OnPropertyChanged("socialprofile_cases");
            }
        }

        /// <summary>
        /// 1:N socialprofile_connections1
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("socialprofile_connections1")]
        public System.Collections.Generic.IEnumerable<Connection> socialprofile_connections1
        {
            get { return this.GetRelatedEntities<Connection>("socialprofile_connections1", null); }
            set
            {
                this.OnPropertyChanging("socialprofile_connections1");
                this.SetRelatedEntities<Connection>("socialprofile_connections1", null, value);
                this.OnPropertyChanged("socialprofile_connections1");
            }
        }

        /// <summary>
        /// 1:N socialprofile_connections2
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("socialprofile_connections2")]
        public System.Collections.Generic.IEnumerable<Connection> socialprofile_connections2
        {
            get { return this.GetRelatedEntities<Connection>("socialprofile_connections2", null); }
            set
            {
                this.OnPropertyChanging("socialprofile_connections2");
                this.SetRelatedEntities<Connection>("socialprofile_connections2", null, value);
                this.OnPropertyChanged("socialprofile_connections2");
            }
        }

        /// <summary>
        /// 1:N SocialProfile_DuplicateBaseRecord
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SocialProfile_DuplicateBaseRecord")]
        public System.Collections.Generic.IEnumerable<DuplicateRecord> SocialProfile_DuplicateBaseRecord
        {
            get { return this.GetRelatedEntities<DuplicateRecord>("SocialProfile_DuplicateBaseRecord", null); }
            set
            {
                this.OnPropertyChanging("SocialProfile_DuplicateBaseRecord");
                this.SetRelatedEntities<DuplicateRecord>("SocialProfile_DuplicateBaseRecord", null, value);
                this.OnPropertyChanged("SocialProfile_DuplicateBaseRecord");
            }
        }

        /// <summary>
        /// 1:N SocialProfile_DuplicateMatchingRecord
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SocialProfile_DuplicateMatchingRecord")]
        public System.Collections.Generic.IEnumerable<DuplicateRecord> SocialProfile_DuplicateMatchingRecord
        {
            get { return this.GetRelatedEntities<DuplicateRecord>("SocialProfile_DuplicateMatchingRecord", null); }
            set
            {
                this.OnPropertyChanging("SocialProfile_DuplicateMatchingRecord");
                this.SetRelatedEntities<DuplicateRecord>("SocialProfile_DuplicateMatchingRecord", null, value);
                this.OnPropertyChanged("SocialProfile_DuplicateMatchingRecord");
            }
        }

        /// <summary>
        /// 1:N socialprofile_principalobjectattributeaccess
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("socialprofile_principalobjectattributeaccess")]
        public System.Collections.Generic.IEnumerable<PrincipalObjectAttributeAccess> socialprofile_principalobjectattributeaccess
        {
            get { return this.GetRelatedEntities<PrincipalObjectAttributeAccess>("socialprofile_principalobjectattributeaccess", null); }
            set
            {
                this.OnPropertyChanging("socialprofile_principalobjectattributeaccess");
                this.SetRelatedEntities<PrincipalObjectAttributeAccess>("socialprofile_principalobjectattributeaccess", null, value);
                this.OnPropertyChanged("socialprofile_principalobjectattributeaccess");
            }
        }

        /// <summary>
        /// 1:N SocialProfile_ProcessSessions
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SocialProfile_ProcessSessions")]
        public System.Collections.Generic.IEnumerable<ProcessSession> SocialProfile_ProcessSessions
        {
            get { return this.GetRelatedEntities<ProcessSession>("SocialProfile_ProcessSessions", null); }
            set
            {
                this.OnPropertyChanging("SocialProfile_ProcessSessions");
                this.SetRelatedEntities<ProcessSession>("SocialProfile_ProcessSessions", null, value);
                this.OnPropertyChanged("SocialProfile_ProcessSessions");
            }
        }

        /// <summary>
        /// 1:N Socialprofile_SocialActivities
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Socialprofile_SocialActivities")]
        public System.Collections.Generic.IEnumerable<SocialActivity> Socialprofile_SocialActivities
        {
            get { return this.GetRelatedEntities<SocialActivity>("Socialprofile_SocialActivities", null); }
            set
            {
                this.OnPropertyChanging("Socialprofile_SocialActivities");
                this.SetRelatedEntities<SocialActivity>("Socialprofile_SocialActivities", null, value);
                this.OnPropertyChanged("Socialprofile_SocialActivities");
            }
        }

        /// <summary>
        /// N:1 business_unit_socialprofiles
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_socialprofiles")]
        public BusinessUnit business_unit_socialprofiles
        {
            get { return this.GetRelatedEntity<BusinessUnit>("business_unit_socialprofiles", null); }
        }

        /// <summary>
        /// N:1 lk_SocialProfile_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_SocialProfile_createdonbehalfby")]
        public SystemUser lk_SocialProfile_createdonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_SocialProfile_createdonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_SocialProfile_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_SocialProfile_modifiedonbehalfby")]
        public SystemUser lk_SocialProfile_modifiedonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_SocialProfile_modifiedonbehalfby", null); }
        }

        /// <summary>
        /// N:1 Socialprofile_customer_accounts
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("customerid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Socialprofile_customer_accounts")]
        public Account Socialprofile_customer_accounts
        {
            get { return this.GetRelatedEntity<Account>("Socialprofile_customer_accounts", null); }
            set
            {
                this.OnPropertyChanging("Socialprofile_customer_accounts");
                this.SetRelatedEntity<Account>("Socialprofile_customer_accounts", null, value);
                this.OnPropertyChanged("Socialprofile_customer_accounts");
            }
        }

        /// <summary>
        /// N:1 Socialprofile_customer_contacts
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("customerid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Socialprofile_customer_contacts")]
        public Contact Socialprofile_customer_contacts
        {
            get { return this.GetRelatedEntity<Contact>("Socialprofile_customer_contacts", null); }
            set
            {
                this.OnPropertyChanging("Socialprofile_customer_contacts");
                this.SetRelatedEntity<Contact>("Socialprofile_customer_contacts", null, value);
                this.OnPropertyChanged("Socialprofile_customer_contacts");
            }
        }

        /// <summary>
        /// N:1 socialProfile_owning_user
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("socialProfile_owning_user")]
        public SystemUser socialProfile_owning_user
        {
            get { return this.GetRelatedEntity<SystemUser>("socialProfile_owning_user", null); }
        }

        /// <summary>
        /// N:1 transactioncurrency_SocialProfile
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("transactioncurrency_SocialProfile")]
        public TransactionCurrency transactioncurrency_SocialProfile
        {
            get { return this.GetRelatedEntity<TransactionCurrency>("transactioncurrency_SocialProfile", null); }
            set
            {
                this.OnPropertyChanging("transactioncurrency_SocialProfile");
                this.SetRelatedEntity<TransactionCurrency>("transactioncurrency_SocialProfile", null, value);
                this.OnPropertyChanged("transactioncurrency_SocialProfile");
            }
        }
    }
}