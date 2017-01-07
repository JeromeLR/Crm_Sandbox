using _4_DAL_CRM;

namespace __4_DAL_CRM
{
    /// <summary>
    /// Service request case associated with a contract.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("incident")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class Incident : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public Incident() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "incident";

        public const int EntityTypeCode = 112;

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
        /// Unique identifier of the account with which the case is associated.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("accountid")]
        public Microsoft.Xrm.Sdk.EntityReference AccountId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("accountid"); }
        }

        /// <summary>
        /// This attribute is used for Sample Service Business Processes.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("activitiescomplete")]
        public System.Nullable<bool> ActivitiesComplete
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("activitiescomplete"); }
            set
            {
                this.OnPropertyChanging("ActivitiesComplete");
                this.SetAttributeValue("activitiescomplete", value);
                this.OnPropertyChanged("ActivitiesComplete");
            }
        }

        /// <summary>
        /// Type the number of service units that were actually required to resolve the case.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("actualserviceunits")]
        public System.Nullable<int> ActualServiceUnits
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("actualserviceunits"); }
            set
            {
                this.OnPropertyChanging("ActualServiceUnits");
                this.SetAttributeValue("actualserviceunits", value);
                this.OnPropertyChanged("ActualServiceUnits");
            }
        }

        /// <summary>
        /// Type the number of service units that were billed to the customer for the case.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("billedserviceunits")]
        public System.Nullable<int> BilledServiceUnits
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("billedserviceunits"); }
            set
            {
                this.OnPropertyChanging("BilledServiceUnits");
                this.SetAttributeValue("billedserviceunits", value);
                this.OnPropertyChanged("BilledServiceUnits");
            }
        }

        /// <summary>
        /// Details whether the profile is blocked or not.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("blockedprofile")]
        public System.Nullable<bool> BlockedProfile
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("blockedprofile"); }
            set
            {
                this.OnPropertyChanging("BlockedProfile");
                this.SetAttributeValue("blockedprofile", value);
                this.OnPropertyChanged("BlockedProfile");
            }
        }

        /// <summary>
        /// Select how contact about the case was originated, such as email, phone, or web, for use in reporting and analysis.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("caseorigincode")]
        public Microsoft.Xrm.Sdk.OptionSetValue CaseOriginCode
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("caseorigincode"); }
            set
            {
                this.OnPropertyChanging("CaseOriginCode");
                this.SetAttributeValue("caseorigincode", value);
                this.OnPropertyChanged("CaseOriginCode");
            }
        }

        /// <summary>
        /// Select the type of case to identify the incident for use in case routing and analysis.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("casetypecode")]
        public Microsoft.Xrm.Sdk.OptionSetValue CaseTypeCode
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("casetypecode"); }
            set
            {
                this.OnPropertyChanging("CaseTypeCode");
                this.SetAttributeValue("casetypecode", value);
                this.OnPropertyChanged("CaseTypeCode");
            }
        }

        /// <summary>
        /// This attribute is used for Sample Service Business Processes.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("checkemail")]
        public System.Nullable<bool> CheckEmail
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("checkemail"); }
            set
            {
                this.OnPropertyChanging("CheckEmail");
                this.SetAttributeValue("checkemail", value);
                this.OnPropertyChanged("CheckEmail");
            }
        }

        /// <summary>
        /// Unique identifier of the contact associated with the case.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("contactid")]
        public Microsoft.Xrm.Sdk.EntityReference ContactId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("contactid"); }
        }

        /// <summary>
        /// Choose the contract line that the case should be logged under to make sure the customer is charged correctly.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("contractdetailid")]
        public Microsoft.Xrm.Sdk.EntityReference ContractDetailId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("contractdetailid"); }
            set
            {
                this.OnPropertyChanging("ContractDetailId");
                this.SetAttributeValue("contractdetailid", value);
                this.OnPropertyChanged("ContractDetailId");
            }
        }

        /// <summary>
        /// Choose the service contract that the case should be logged under to make sure the customer is eligible for support services.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("contractid")]
        public Microsoft.Xrm.Sdk.EntityReference ContractId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("contractid"); }
            set
            {
                this.OnPropertyChanging("ContractId");
                this.SetAttributeValue("contractid", value);
                this.OnPropertyChanged("ContractId");
            }
        }

        /// <summary>
        /// Select the service level for the case to make sure the case is handled correctly.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("contractservicelevelcode")]
        public Microsoft.Xrm.Sdk.OptionSetValue ContractServiceLevelCode
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("contractservicelevelcode"); }
            set
            {
                this.OnPropertyChanging("ContractServiceLevelCode");
                this.SetAttributeValue("contractservicelevelcode", value);
                this.OnPropertyChanged("ContractServiceLevelCode");
            }
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
        /// Tells whether customer service representative has contacted the customer or not.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("customercontacted")]
        public System.Nullable<bool> CustomerContacted
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("customercontacted"); }
            set
            {
                this.OnPropertyChanging("CustomerContacted");
                this.SetAttributeValue("customercontacted", value);
                this.OnPropertyChanged("CustomerContacted");
            }
        }

        /// <summary>
        /// Select the customer account or contact to provide a quick link to additional customer details, such as account information, activities, and opportunities.
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
        /// Select the customer's level of satisfaction with the handling and resolution of the case.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("customersatisfactioncode")]
        public Microsoft.Xrm.Sdk.OptionSetValue CustomerSatisfactionCode
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("customersatisfactioncode"); }
            set
            {
                this.OnPropertyChanging("CustomerSatisfactionCode");
                this.SetAttributeValue("customersatisfactioncode", value);
                this.OnPropertyChanged("CustomerSatisfactionCode");
            }
        }

        /// <summary>
        /// Type additional information to describe the case to assist the service team in reaching a resolution.
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
        /// Choose the entitlement that is applicable for the case.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entitlementid")]
        public Microsoft.Xrm.Sdk.EntityReference EntitlementId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("entitlementid"); }
            set
            {
                this.OnPropertyChanging("EntitlementId");
                this.SetAttributeValue("entitlementid", value);
                this.OnPropertyChanged("EntitlementId");
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
        /// Indicates the date and time when the case was escalated.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("escalatedon")]
        public System.Nullable<System.DateTime> EscalatedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("escalatedon"); }
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
        /// Select an existing case for the customer that has been populated. For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("existingcase")]
        public Microsoft.Xrm.Sdk.EntityReference ExistingCase
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("existingcase"); }
            set
            {
                this.OnPropertyChanging("ExistingCase");
                this.SetAttributeValue("existingcase", value);
                this.OnPropertyChanged("ExistingCase");
            }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("firstresponsebykpiid")]
        public Microsoft.Xrm.Sdk.EntityReference FirstResponseByKPIId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("firstresponsebykpiid"); }
            set
            {
                this.OnPropertyChanging("FirstResponseByKPIId");
                this.SetAttributeValue("firstresponsebykpiid", value);
                this.OnPropertyChanged("FirstResponseByKPIId");
            }
        }

        /// <summary>
        /// Indicates if the first response has been sent.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("firstresponsesent")]
        public System.Nullable<bool> FirstResponseSent
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("firstresponsesent"); }
            set
            {
                this.OnPropertyChanging("FirstResponseSent");
                this.SetAttributeValue("firstresponsesent", value);
                this.OnPropertyChanged("FirstResponseSent");
            }
        }

        /// <summary>
        /// Shows the status of the initial response time for the case according to the terms of the SLA.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("firstresponseslastatus")]
        public Microsoft.Xrm.Sdk.OptionSetValue FirstResponseSLAStatus
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("firstresponseslastatus"); }
            set
            {
                this.OnPropertyChanging("FirstResponseSLAStatus");
                this.SetAttributeValue("firstresponseslastatus", value);
                this.OnPropertyChanged("FirstResponseSLAStatus");
            }
        }

        /// <summary>
        /// Enter the date by which a customer service representative has to follow up with the customer on this case.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("followupby")]
        public System.Nullable<System.DateTime> FollowupBy
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("followupby"); }
            set
            {
                this.OnPropertyChanging("FollowupBy");
                this.SetAttributeValue("followupby", value);
                this.OnPropertyChanged("FollowupBy");
            }
        }

        /// <summary>
        /// This attribute is used for Sample Service Business Processes.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("followuptaskcreated")]
        public System.Nullable<bool> FollowUpTaskCreated
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("followuptaskcreated"); }
            set
            {
                this.OnPropertyChanging("FollowUpTaskCreated");
                this.SetAttributeValue("followuptaskcreated", value);
                this.OnPropertyChanged("FollowUpTaskCreated");
            }
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
        /// Unique identifier of the case.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("incidentid")]
        public System.Nullable<System.Guid> IncidentId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("incidentid"); }
            set
            {
                this.OnPropertyChanging("IncidentId");
                this.SetAttributeValue("incidentid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("IncidentId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("incidentid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.IncidentId = value; }
        }

        /// <summary>
        /// Select the current stage of the service process for the case to assist service team members when they review or transfer a case.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("incidentstagecode")]
        public Microsoft.Xrm.Sdk.OptionSetValue IncidentStageCode
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("incidentstagecode"); }
            set
            {
                this.OnPropertyChanging("IncidentStageCode");
                this.SetAttributeValue("incidentstagecode", value);
                this.OnPropertyChanged("IncidentStageCode");
            }
        }

        /// <summary>
        /// Will contain the Influencer score coming from NetBreeze.
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
        /// For system use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isdecrementing")]
        public System.Nullable<bool> IsDecrementing
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("isdecrementing"); }
            set
            {
                this.OnPropertyChanging("IsDecrementing");
                this.SetAttributeValue("isdecrementing", value);
                this.OnPropertyChanged("IsDecrementing");
            }
        }

        /// <summary>
        /// Indicates if the case has been escalated.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isescalated")]
        public System.Nullable<bool> IsEscalated
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("isescalated"); }
            set
            {
                this.OnPropertyChanging("IsEscalated");
                this.SetAttributeValue("isescalated", value);
                this.OnPropertyChanged("IsEscalated");
            }
        }

        /// <summary>
        /// Choose the article that contains additional information or a resolution for the case, for reference during research or follow up with the customer.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("kbarticleid")]
        public Microsoft.Xrm.Sdk.EntityReference KbArticleId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("kbarticleid"); }
            set
            {
                this.OnPropertyChanging("KbArticleId");
                this.SetAttributeValue("kbarticleid", value);
                this.OnPropertyChanged("KbArticleId");
            }
        }

        /// <summary>
        /// Contains the date time stamp of the last on hold time.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("lastonholdtime")]
        public System.Nullable<System.DateTime> LastOnHoldTime
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("lastonholdtime"); }
            set
            {
                this.OnPropertyChanging("LastOnHoldTime");
                this.SetAttributeValue("lastonholdtime", value);
                this.OnPropertyChanged("LastOnHoldTime");
            }
        }

        /// <summary>
        /// Choose the primary case the current case was merged into.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("masterid")]
        public Microsoft.Xrm.Sdk.EntityReference MasterId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("masterid"); }
            set
            {
                this.OnPropertyChanging("MasterId");
                this.SetAttributeValue("masterid", value);
                this.OnPropertyChanged("MasterId");
            }
        }

        /// <summary>
        /// Tells whether the incident has been merged with another incident.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("merged")]
        public System.Nullable<bool> Merged
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("merged"); }
        }

        /// <summary>
        /// Shows whether the post originated as a public or private message.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("messagetypecode")]
        public Microsoft.Xrm.Sdk.OptionSetValue MessageTypeCode
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("messagetypecode"); }
            set
            {
                this.OnPropertyChanging("MessageTypeCode");
                this.SetAttributeValue("messagetypecode", value);
                this.OnPropertyChanged("MessageTypeCode");
            }
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
        /// Number of child incidents associated with the incident.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("numberofchildincidents")]
        public System.Nullable<int> NumberOfChildIncidents
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("numberofchildincidents"); }
        }

        /// <summary>
        /// Shows the duration in minutes for which the case was on hold.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("onholdtime")]
        public System.Nullable<int> OnHoldTime
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("onholdtime"); }
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
        /// Unique identifier of the business unit that owns the case.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
        public Microsoft.Xrm.Sdk.EntityReference OwningBusinessUnit
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningbusinessunit"); }
        }

        /// <summary>
        /// Unique identifier of the team who owns the case.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
        public Microsoft.Xrm.Sdk.EntityReference OwningTeam
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningteam"); }
        }

        /// <summary>
        /// Unique identifier of the user who owns the case.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
        public Microsoft.Xrm.Sdk.EntityReference OwningUser
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owninguser"); }
        }

        /// <summary>
        /// Choose the parent case for a case.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("parentcaseid")]
        public Microsoft.Xrm.Sdk.EntityReference ParentCaseId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("parentcaseid"); }
            set
            {
                this.OnPropertyChanging("ParentCaseId");
                this.SetAttributeValue("parentcaseid", value);
                this.OnPropertyChanged("ParentCaseId");
            }
        }

        /// <summary>
        /// Select a primary contact for this case.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("primarycontactid")]
        public Microsoft.Xrm.Sdk.EntityReference PrimaryContactId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("primarycontactid"); }
            set
            {
                this.OnPropertyChanging("PrimaryContactId");
                this.SetAttributeValue("primarycontactid", value);
                this.OnPropertyChanged("PrimaryContactId");
            }
        }

        /// <summary>
        /// Select the priority so that preferred customers or critical issues are handled quickly.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("prioritycode")]
        public Microsoft.Xrm.Sdk.OptionSetValue PriorityCode
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("prioritycode"); }
            set
            {
                this.OnPropertyChanging("PriorityCode");
                this.SetAttributeValue("prioritycode", value);
                this.OnPropertyChanged("PriorityCode");
            }
        }

        /// <summary>
        /// Shows the ID of the process.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("processid")]
        public System.Nullable<System.Guid> ProcessId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("processid"); }
            set
            {
                this.OnPropertyChanging("ProcessId");
                this.SetAttributeValue("processid", value);
                this.OnPropertyChanged("ProcessId");
            }
        }

        /// <summary>
        /// Choose the product associated with the case to identify warranty, service, or other product issues and be able to report the number of incidents for each product.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("productid")]
        public Microsoft.Xrm.Sdk.EntityReference ProductId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("productid"); }
            set
            {
                this.OnPropertyChanging("ProductId");
                this.SetAttributeValue("productid", value);
                this.OnPropertyChanged("ProductId");
            }
        }

        /// <summary>
        /// Type the serial number of the product that is associated with this case, so that the number of cases per product can be reported.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("productserialnumber")]
        public string ProductSerialNumber
        {
            get { return this.GetAttributeValue<string>("productserialnumber"); }
            set
            {
                this.OnPropertyChanging("ProductSerialNumber");
                this.SetAttributeValue("productserialnumber", value);
                this.OnPropertyChanged("ProductSerialNumber");
            }
        }

        /// <summary>
        /// Enter the date by when the case must be resolved.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("resolveby")]
        public System.Nullable<System.DateTime> ResolveBy
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("resolveby"); }
            set
            {
                this.OnPropertyChanging("ResolveBy");
                this.SetAttributeValue("resolveby", value);
                this.OnPropertyChanged("ResolveBy");
            }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("resolvebykpiid")]
        public Microsoft.Xrm.Sdk.EntityReference ResolveByKPIId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("resolvebykpiid"); }
            set
            {
                this.OnPropertyChanging("ResolveByKPIId");
                this.SetAttributeValue("resolvebykpiid", value);
                this.OnPropertyChanged("ResolveByKPIId");
            }
        }

        /// <summary>
        /// Shows the status of the resolution time for the case according to the terms of the SLA.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("resolvebyslastatus")]
        public Microsoft.Xrm.Sdk.OptionSetValue ResolveBySLAStatus
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("resolvebyslastatus"); }
            set
            {
                this.OnPropertyChanging("ResolveBySLAStatus");
                this.SetAttributeValue("resolvebyslastatus", value);
                this.OnPropertyChanged("ResolveBySLAStatus");
            }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("responseby")]
        public System.Nullable<System.DateTime> ResponseBy
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("responseby"); }
            set
            {
                this.OnPropertyChanging("ResponseBy");
                this.SetAttributeValue("responseby", value);
                this.OnPropertyChanged("ResponseBy");
            }
        }

        /// <summary>
        /// Choose an additional customer contact who can also help resolve the case.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("responsiblecontactid")]
        [System.ObsoleteAttribute()]
        public Microsoft.Xrm.Sdk.EntityReference ResponsibleContactId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("responsiblecontactid"); }
            set
            {
                this.OnPropertyChanging("ResponsibleContactId");
                this.SetAttributeValue("responsiblecontactid", value);
                this.OnPropertyChanged("ResponsibleContactId");
            }
        }

        /// <summary>
        /// Tells whether the incident has been routed to queue or not.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("routecase")]
        public System.Nullable<bool> RouteCase
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("routecase"); }
            set
            {
                this.OnPropertyChanging("RouteCase");
                this.SetAttributeValue("routecase", value);
                this.OnPropertyChanged("RouteCase");
            }
        }

        /// <summary>
        /// Value derived after assessing words commonly associated with a negative, neutral, or positive sentiment that occurs in a social post. Sentiment information can also be reported as numeric values.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sentimentvalue")]
        public System.Nullable<double> SentimentValue
        {
            get { return this.GetAttributeValue<System.Nullable<double>>("sentimentvalue"); }
            set
            {
                this.OnPropertyChanging("SentimentValue");
                this.SetAttributeValue("sentimentvalue", value);
                this.OnPropertyChanged("SentimentValue");
            }
        }

        /// <summary>
        /// Select the stage, in the case resolution process, that the case is in.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("servicestage")]
        public Microsoft.Xrm.Sdk.OptionSetValue ServiceStage
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("servicestage"); }
            set
            {
                this.OnPropertyChanging("ServiceStage");
                this.SetAttributeValue("servicestage", value);
                this.OnPropertyChanged("ServiceStage");
            }
        }

        /// <summary>
        /// Select the severity of this case to indicate the incident's impact on the customer's business.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("severitycode")]
        public Microsoft.Xrm.Sdk.OptionSetValue SeverityCode
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("severitycode"); }
            set
            {
                this.OnPropertyChanging("SeverityCode");
                this.SetAttributeValue("severitycode", value);
                this.OnPropertyChanged("SeverityCode");
            }
        }

        /// <summary>
        /// Last SLA that was invoked for this case.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("slainvokedid")]
        public Microsoft.Xrm.Sdk.EntityReference SLAInvokedId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("slainvokedid"); }
        }

        /// <summary>
        /// Unique identifier of the social profile with which the case is associated.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("socialprofileid")]
        public Microsoft.Xrm.Sdk.EntityReference SocialProfileId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("socialprofileid"); }
            set
            {
                this.OnPropertyChanging("SocialProfileId");
                this.SetAttributeValue("socialprofileid", value);
                this.OnPropertyChanged("SocialProfileId");
            }
        }

        /// <summary>
        /// Shows the ID of the stage.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("stageid")]
        public System.Nullable<System.Guid> StageId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("stageid"); }
            set
            {
                this.OnPropertyChanging("StageId");
                this.SetAttributeValue("stageid", value);
                this.OnPropertyChanged("StageId");
            }
        }

        /// <summary>
        /// Shows whether the case is active, resolved, or canceled. Resolved and canceled cases are read-only and can't be edited unless they are reactivated.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
        public System.Nullable<IncidentState> StateCode
        {
            get
            {
                Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
                if ((optionSet != null))
                {
                    return ((IncidentState) (System.Enum.ToObject(typeof(IncidentState), optionSet.Value)));
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// Select the case's status.
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
        /// Choose the subject for the case, such as catalog request or product complaint, so customer service managers can identify frequent requests or problem areas. Administrators can configure subjects under Business Management in the Settings area.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("subjectid")]
        public Microsoft.Xrm.Sdk.EntityReference SubjectId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("subjectid"); }
            set
            {
                this.OnPropertyChanging("SubjectId");
                this.SetAttributeValue("subjectid", value);
                this.OnPropertyChanged("SubjectId");
            }
        }

        /// <summary>
        /// Shows the case number for customer reference and searching capabilities. This cannot be modified.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ticketnumber")]
        public string TicketNumber
        {
            get { return this.GetAttributeValue<string>("ticketnumber"); }
            set
            {
                this.OnPropertyChanging("TicketNumber");
                this.SetAttributeValue("ticketnumber", value);
                this.OnPropertyChanged("TicketNumber");
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
        /// Type a subject or descriptive name, such as the request, issue, or company name, to identify the case in Microsoft Dynamics CRM views.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("title")]
        public string Title
        {
            get { return this.GetAttributeValue<string>("title"); }
            set
            {
                this.OnPropertyChanging("Title");
                this.SetAttributeValue("title", value);
                this.OnPropertyChanged("Title");
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
        /// A comma separated list of string values representing the unique identifiers of stages in a Business Process Flow Instance in the order that they occur.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("traversedpath")]
        public string TraversedPath
        {
            get { return this.GetAttributeValue<string>("traversedpath"); }
            set
            {
                this.OnPropertyChanging("TraversedPath");
                this.SetAttributeValue("traversedpath", value);
                this.OnPropertyChanged("TraversedPath");
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
        /// Version number of the case.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
        public System.Nullable<long> VersionNumber
        {
            get { return this.GetAttributeValue<System.Nullable<long>>("versionnumber"); }
        }

        /// <summary>
        /// 1:N incident_activity_parties
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("incident_activity_parties")]
        public System.Collections.Generic.IEnumerable<ActivityParty> incident_activity_parties
        {
            get { return this.GetRelatedEntities<ActivityParty>("incident_activity_parties", null); }
            set
            {
                this.OnPropertyChanging("incident_activity_parties");
                this.SetRelatedEntities<ActivityParty>("incident_activity_parties", null, value);
                this.OnPropertyChanged("incident_activity_parties");
            }
        }

        /// <summary>
        /// 1:N Incident_ActivityPointers
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Incident_ActivityPointers")]
        public System.Collections.Generic.IEnumerable<ActivityPointer> Incident_ActivityPointers
        {
            get { return this.GetRelatedEntities<ActivityPointer>("Incident_ActivityPointers", null); }
            set
            {
                this.OnPropertyChanging("Incident_ActivityPointers");
                this.SetRelatedEntities<ActivityPointer>("Incident_ActivityPointers", null, value);
                this.OnPropertyChanged("Incident_ActivityPointers");
            }
        }

        /// <summary>
        /// 1:N Incident_Annotation
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Incident_Annotation")]
        public System.Collections.Generic.IEnumerable<Annotation> Incident_Annotation
        {
            get { return this.GetRelatedEntities<Annotation>("Incident_Annotation", null); }
            set
            {
                this.OnPropertyChanging("Incident_Annotation");
                this.SetRelatedEntities<Annotation>("Incident_Annotation", null, value);
                this.OnPropertyChanged("Incident_Annotation");
            }
        }

        /// <summary>
        /// 1:N Incident_Appointments
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Incident_Appointments")]
        public System.Collections.Generic.IEnumerable<Appointment> Incident_Appointments
        {
            get { return this.GetRelatedEntities<Appointment>("Incident_Appointments", null); }
            set
            {
                this.OnPropertyChanging("Incident_Appointments");
                this.SetRelatedEntities<Appointment>("Incident_Appointments", null, value);
                this.OnPropertyChanged("Incident_Appointments");
            }
        }

        /// <summary>
        /// 1:N Incident_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Incident_AsyncOperations")]
        public System.Collections.Generic.IEnumerable<AsyncOperation> Incident_AsyncOperations
        {
            get { return this.GetRelatedEntities<AsyncOperation>("Incident_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("Incident_AsyncOperations");
                this.SetRelatedEntities<AsyncOperation>("Incident_AsyncOperations", null, value);
                this.OnPropertyChanged("Incident_AsyncOperations");
            }
        }

        /// <summary>
        /// 1:N Incident_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Incident_BulkDeleteFailures")]
        public System.Collections.Generic.IEnumerable<BulkDeleteFailure> Incident_BulkDeleteFailures
        {
            get { return this.GetRelatedEntities<BulkDeleteFailure>("Incident_BulkDeleteFailures", null); }
            set
            {
                this.OnPropertyChanging("Incident_BulkDeleteFailures");
                this.SetRelatedEntities<BulkDeleteFailure>("Incident_BulkDeleteFailures", null, value);
                this.OnPropertyChanged("Incident_BulkDeleteFailures");
            }
        }

        /// <summary>
        /// 1:N incident_connections1
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("incident_connections1")]
        public System.Collections.Generic.IEnumerable<Connection> incident_connections1
        {
            get { return this.GetRelatedEntities<Connection>("incident_connections1", null); }
            set
            {
                this.OnPropertyChanging("incident_connections1");
                this.SetRelatedEntities<Connection>("incident_connections1", null, value);
                this.OnPropertyChanged("incident_connections1");
            }
        }

        /// <summary>
        /// 1:N incident_connections2
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("incident_connections2")]
        public System.Collections.Generic.IEnumerable<Connection> incident_connections2
        {
            get { return this.GetRelatedEntities<Connection>("incident_connections2", null); }
            set
            {
                this.OnPropertyChanging("incident_connections2");
                this.SetRelatedEntities<Connection>("incident_connections2", null, value);
                this.OnPropertyChanged("incident_connections2");
            }
        }

        /// <summary>
        /// 1:N Incident_DuplicateBaseRecord
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Incident_DuplicateBaseRecord")]
        public System.Collections.Generic.IEnumerable<DuplicateRecord> Incident_DuplicateBaseRecord
        {
            get { return this.GetRelatedEntities<DuplicateRecord>("Incident_DuplicateBaseRecord", null); }
            set
            {
                this.OnPropertyChanging("Incident_DuplicateBaseRecord");
                this.SetRelatedEntities<DuplicateRecord>("Incident_DuplicateBaseRecord", null, value);
                this.OnPropertyChanged("Incident_DuplicateBaseRecord");
            }
        }

        /// <summary>
        /// 1:N Incident_DuplicateMatchingRecord
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Incident_DuplicateMatchingRecord")]
        public System.Collections.Generic.IEnumerable<DuplicateRecord> Incident_DuplicateMatchingRecord
        {
            get { return this.GetRelatedEntities<DuplicateRecord>("Incident_DuplicateMatchingRecord", null); }
            set
            {
                this.OnPropertyChanging("Incident_DuplicateMatchingRecord");
                this.SetRelatedEntities<DuplicateRecord>("Incident_DuplicateMatchingRecord", null, value);
                this.OnPropertyChanged("Incident_DuplicateMatchingRecord");
            }
        }

        /// <summary>
        /// 1:N Incident_Emails
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Incident_Emails")]
        public System.Collections.Generic.IEnumerable<Email> Incident_Emails
        {
            get { return this.GetRelatedEntities<Email>("Incident_Emails", null); }
            set
            {
                this.OnPropertyChanging("Incident_Emails");
                this.SetRelatedEntities<Email>("Incident_Emails", null, value);
                this.OnPropertyChanged("Incident_Emails");
            }
        }

        /// <summary>
        /// 1:N incident_existingcase
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("incident_existingcase", Microsoft.Xrm.Sdk.EntityRole.Referenced)]
        public System.Collections.Generic.IEnumerable<Incident> Referencedincident_existingcase
        {
            get { return this.GetRelatedEntities<Incident>("incident_existingcase", Microsoft.Xrm.Sdk.EntityRole.Referenced); }
            set
            {
                this.OnPropertyChanging("Referencedincident_existingcase");
                this.SetRelatedEntities<Incident>("incident_existingcase", Microsoft.Xrm.Sdk.EntityRole.Referenced, value);
                this.OnPropertyChanged("Referencedincident_existingcase");
            }
        }

        /// <summary>
        /// 1:N Incident_Faxes
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Incident_Faxes")]
        public System.Collections.Generic.IEnumerable<Fax> Incident_Faxes
        {
            get { return this.GetRelatedEntities<Fax>("Incident_Faxes", null); }
            set
            {
                this.OnPropertyChanging("Incident_Faxes");
                this.SetRelatedEntities<Fax>("Incident_Faxes", null, value);
                this.OnPropertyChanged("Incident_Faxes");
            }
        }

        /// <summary>
        /// 1:N Incident_IncidentResolutions
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Incident_IncidentResolutions")]
        public System.Collections.Generic.IEnumerable<IncidentResolution> Incident_IncidentResolutions
        {
            get { return this.GetRelatedEntities<IncidentResolution>("Incident_IncidentResolutions", null); }
            set
            {
                this.OnPropertyChanging("Incident_IncidentResolutions");
                this.SetRelatedEntities<IncidentResolution>("Incident_IncidentResolutions", null, value);
                this.OnPropertyChanged("Incident_IncidentResolutions");
            }
        }

        /// <summary>
        /// 1:N Incident_Letters
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Incident_Letters")]
        public System.Collections.Generic.IEnumerable<Letter> Incident_Letters
        {
            get { return this.GetRelatedEntities<Letter>("Incident_Letters", null); }
            set
            {
                this.OnPropertyChanging("Incident_Letters");
                this.SetRelatedEntities<Letter>("Incident_Letters", null, value);
                this.OnPropertyChanged("Incident_Letters");
            }
        }

        /// <summary>
        /// 1:N incident_master_incident
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("incident_master_incident", Microsoft.Xrm.Sdk.EntityRole.Referenced)]
        public System.Collections.Generic.IEnumerable<Incident> Referencedincident_master_incident
        {
            get { return this.GetRelatedEntities<Incident>("incident_master_incident", Microsoft.Xrm.Sdk.EntityRole.Referenced); }
            set
            {
                this.OnPropertyChanging("Referencedincident_master_incident");
                this.SetRelatedEntities<Incident>("incident_master_incident", Microsoft.Xrm.Sdk.EntityRole.Referenced, value);
                this.OnPropertyChanged("Referencedincident_master_incident");
            }
        }

        /// <summary>
        /// 1:N incident_parent_incident
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("incident_parent_incident", Microsoft.Xrm.Sdk.EntityRole.Referenced)]
        public System.Collections.Generic.IEnumerable<Incident> Referencedincident_parent_incident
        {
            get { return this.GetRelatedEntities<Incident>("incident_parent_incident", Microsoft.Xrm.Sdk.EntityRole.Referenced); }
            set
            {
                this.OnPropertyChanging("Referencedincident_parent_incident");
                this.SetRelatedEntities<Incident>("incident_parent_incident", Microsoft.Xrm.Sdk.EntityRole.Referenced, value);
                this.OnPropertyChanged("Referencedincident_parent_incident");
            }
        }

        /// <summary>
        /// 1:N Incident_Phonecalls
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Incident_Phonecalls")]
        public System.Collections.Generic.IEnumerable<PhoneCall> Incident_Phonecalls
        {
            get { return this.GetRelatedEntities<PhoneCall>("Incident_Phonecalls", null); }
            set
            {
                this.OnPropertyChanging("Incident_Phonecalls");
                this.SetRelatedEntities<PhoneCall>("Incident_Phonecalls", null, value);
                this.OnPropertyChanged("Incident_Phonecalls");
            }
        }

        /// <summary>
        /// 1:N incident_PostFollows
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("incident_PostFollows")]
        public System.Collections.Generic.IEnumerable<PostFollow> incident_PostFollows
        {
            get { return this.GetRelatedEntities<PostFollow>("incident_PostFollows", null); }
            set
            {
                this.OnPropertyChanging("incident_PostFollows");
                this.SetRelatedEntities<PostFollow>("incident_PostFollows", null, value);
                this.OnPropertyChanged("incident_PostFollows");
            }
        }

        /// <summary>
        /// 1:N incident_principalobjectattributeaccess
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("incident_principalobjectattributeaccess")]
        public System.Collections.Generic.IEnumerable<PrincipalObjectAttributeAccess> incident_principalobjectattributeaccess
        {
            get { return this.GetRelatedEntities<PrincipalObjectAttributeAccess>("incident_principalobjectattributeaccess", null); }
            set
            {
                this.OnPropertyChanging("incident_principalobjectattributeaccess");
                this.SetRelatedEntities<PrincipalObjectAttributeAccess>("incident_principalobjectattributeaccess", null, value);
                this.OnPropertyChanged("incident_principalobjectattributeaccess");
            }
        }

        /// <summary>
        /// 1:N Incident_ProcessSessions
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Incident_ProcessSessions")]
        public System.Collections.Generic.IEnumerable<ProcessSession> Incident_ProcessSessions
        {
            get { return this.GetRelatedEntities<ProcessSession>("Incident_ProcessSessions", null); }
            set
            {
                this.OnPropertyChanging("Incident_ProcessSessions");
                this.SetRelatedEntities<ProcessSession>("Incident_ProcessSessions", null, value);
                this.OnPropertyChanged("Incident_ProcessSessions");
            }
        }

        /// <summary>
        /// 1:N Incident_QueueItem
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Incident_QueueItem")]
        public System.Collections.Generic.IEnumerable<QueueItem> Incident_QueueItem
        {
            get { return this.GetRelatedEntities<QueueItem>("Incident_QueueItem", null); }
            set
            {
                this.OnPropertyChanging("Incident_QueueItem");
                this.SetRelatedEntities<QueueItem>("Incident_QueueItem", null, value);
                this.OnPropertyChanged("Incident_QueueItem");
            }
        }

        /// <summary>
        /// 1:N Incident_RecurringAppointmentMasters
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Incident_RecurringAppointmentMasters")]
        public System.Collections.Generic.IEnumerable<RecurringAppointmentMaster> Incident_RecurringAppointmentMasters
        {
            get { return this.GetRelatedEntities<RecurringAppointmentMaster>("Incident_RecurringAppointmentMasters", null); }
            set
            {
                this.OnPropertyChanging("Incident_RecurringAppointmentMasters");
                this.SetRelatedEntities<RecurringAppointmentMaster>("Incident_RecurringAppointmentMasters", null, value);
                this.OnPropertyChanged("Incident_RecurringAppointmentMasters");
            }
        }

        /// <summary>
        /// 1:N Incident_ServiceAppointments
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Incident_ServiceAppointments")]
        public System.Collections.Generic.IEnumerable<ServiceAppointment> Incident_ServiceAppointments
        {
            get { return this.GetRelatedEntities<ServiceAppointment>("Incident_ServiceAppointments", null); }
            set
            {
                this.OnPropertyChanging("Incident_ServiceAppointments");
                this.SetRelatedEntities<ServiceAppointment>("Incident_ServiceAppointments", null, value);
                this.OnPropertyChanged("Incident_ServiceAppointments");
            }
        }

        /// <summary>
        /// 1:N Incident_SocialActivities
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Incident_SocialActivities")]
        public System.Collections.Generic.IEnumerable<SocialActivity> Incident_SocialActivities
        {
            get { return this.GetRelatedEntities<SocialActivity>("Incident_SocialActivities", null); }
            set
            {
                this.OnPropertyChanging("Incident_SocialActivities");
                this.SetRelatedEntities<SocialActivity>("Incident_SocialActivities", null, value);
                this.OnPropertyChanged("Incident_SocialActivities");
            }
        }

        /// <summary>
        /// 1:N Incident_Tasks
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Incident_Tasks")]
        public System.Collections.Generic.IEnumerable<Task> Incident_Tasks
        {
            get { return this.GetRelatedEntities<Task>("Incident_Tasks", null); }
            set
            {
                this.OnPropertyChanging("Incident_Tasks");
                this.SetRelatedEntities<Task>("Incident_Tasks", null, value);
                this.OnPropertyChanged("Incident_Tasks");
            }
        }

        /// <summary>
        /// 1:N OriginatingCase_Lead
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("OriginatingCase_Lead")]
        public System.Collections.Generic.IEnumerable<Lead> OriginatingCase_Lead
        {
            get { return this.GetRelatedEntities<Lead>("OriginatingCase_Lead", null); }
            set
            {
                this.OnPropertyChanging("OriginatingCase_Lead");
                this.SetRelatedEntities<Lead>("OriginatingCase_Lead", null, value);
                this.OnPropertyChanged("OriginatingCase_Lead");
            }
        }

        /// <summary>
        /// 1:N slakpiinstance_incident
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("slakpiinstance_incident")]
        public System.Collections.Generic.IEnumerable<SLAKPIInstance> slakpiinstance_incident
        {
            get { return this.GetRelatedEntities<SLAKPIInstance>("slakpiinstance_incident", null); }
            set
            {
                this.OnPropertyChanging("slakpiinstance_incident");
                this.SetRelatedEntities<SLAKPIInstance>("slakpiinstance_incident", null, value);
                this.OnPropertyChanged("slakpiinstance_incident");
            }
        }

        /// <summary>
        /// 1:N userentityinstancedata_incident
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_incident")]
        public System.Collections.Generic.IEnumerable<UserEntityInstanceData> userentityinstancedata_incident
        {
            get { return this.GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_incident", null); }
            set
            {
                this.OnPropertyChanging("userentityinstancedata_incident");
                this.SetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_incident", null, value);
                this.OnPropertyChanged("userentityinstancedata_incident");
            }
        }

        /// <summary>
        /// N:1 business_unit_incidents
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_incidents")]
        public BusinessUnit business_unit_incidents
        {
            get { return this.GetRelatedEntity<BusinessUnit>("business_unit_incidents", null); }
        }

        /// <summary>
        /// N:1 contact_as_primary_contact
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("primarycontactid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("contact_as_primary_contact")]
        public Contact contact_as_primary_contact
        {
            get { return this.GetRelatedEntity<Contact>("contact_as_primary_contact", null); }
            set
            {
                this.OnPropertyChanging("contact_as_primary_contact");
                this.SetRelatedEntity<Contact>("contact_as_primary_contact", null, value);
                this.OnPropertyChanged("contact_as_primary_contact");
            }
        }

        /// <summary>
        /// N:1 contact_as_responsible_contact
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("responsiblecontactid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("contact_as_responsible_contact")]
        public Contact contact_as_responsible_contact
        {
            get { return this.GetRelatedEntity<Contact>("contact_as_responsible_contact", null); }
            set
            {
                this.OnPropertyChanging("contact_as_responsible_contact");
                this.SetRelatedEntity<Contact>("contact_as_responsible_contact", null, value);
                this.OnPropertyChanged("contact_as_responsible_contact");
            }
        }

        /// <summary>
        /// N:1 contract_cases
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("contractid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("contract_cases")]
        public Contract contract_cases
        {
            get { return this.GetRelatedEntity<Contract>("contract_cases", null); }
            set
            {
                this.OnPropertyChanging("contract_cases");
                this.SetRelatedEntity<Contract>("contract_cases", null, value);
                this.OnPropertyChanged("contract_cases");
            }
        }

        /// <summary>
        /// N:1 contract_detail_cases
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("contractdetailid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("contract_detail_cases")]
        public ContractDetail contract_detail_cases
        {
            get { return this.GetRelatedEntity<ContractDetail>("contract_detail_cases", null); }
            set
            {
                this.OnPropertyChanging("contract_detail_cases");
                this.SetRelatedEntity<ContractDetail>("contract_detail_cases", null, value);
                this.OnPropertyChanged("contract_detail_cases");
            }
        }

        /// <summary>
        /// N:1 entitlement_cases
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entitlementid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("entitlement_cases")]
        public Entitlement entitlement_cases
        {
            get { return this.GetRelatedEntity<Entitlement>("entitlement_cases", null); }
            set
            {
                this.OnPropertyChanging("entitlement_cases");
                this.SetRelatedEntity<Entitlement>("entitlement_cases", null, value);
                this.OnPropertyChanged("entitlement_cases");
            }
        }

        /// <summary>
        /// N:1 incident_customer_accounts
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("customerid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("incident_customer_accounts")]
        public Account incident_customer_accounts
        {
            get { return this.GetRelatedEntity<Account>("incident_customer_accounts", null); }
            set
            {
                this.OnPropertyChanging("incident_customer_accounts");
                this.SetRelatedEntity<Account>("incident_customer_accounts", null, value);
                this.OnPropertyChanged("incident_customer_accounts");
            }
        }

        /// <summary>
        /// N:1 incident_customer_contacts
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("customerid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("incident_customer_contacts")]
        public Contact incident_customer_contacts
        {
            get { return this.GetRelatedEntity<Contact>("incident_customer_contacts", null); }
            set
            {
                this.OnPropertyChanging("incident_customer_contacts");
                this.SetRelatedEntity<Contact>("incident_customer_contacts", null, value);
                this.OnPropertyChanged("incident_customer_contacts");
            }
        }

        /// <summary>
        /// N:1 incident_existingcase
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("existingcase")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("incident_existingcase", Microsoft.Xrm.Sdk.EntityRole.Referencing)]
        public Incident Referencingincident_existingcase
        {
            get { return this.GetRelatedEntity<Incident>("incident_existingcase", Microsoft.Xrm.Sdk.EntityRole.Referencing); }
            set
            {
                this.OnPropertyChanging("Referencingincident_existingcase");
                this.SetRelatedEntity<Incident>("incident_existingcase", Microsoft.Xrm.Sdk.EntityRole.Referencing, value);
                this.OnPropertyChanged("Referencingincident_existingcase");
            }
        }

        /// <summary>
        /// N:1 incident_master_incident
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("masterid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("incident_master_incident", Microsoft.Xrm.Sdk.EntityRole.Referencing)]
        public Incident Referencingincident_master_incident
        {
            get { return this.GetRelatedEntity<Incident>("incident_master_incident", Microsoft.Xrm.Sdk.EntityRole.Referencing); }
            set
            {
                this.OnPropertyChanging("Referencingincident_master_incident");
                this.SetRelatedEntity<Incident>("incident_master_incident", Microsoft.Xrm.Sdk.EntityRole.Referencing, value);
                this.OnPropertyChanged("Referencingincident_master_incident");
            }
        }

        /// <summary>
        /// N:1 incident_parent_incident
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("parentcaseid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("incident_parent_incident", Microsoft.Xrm.Sdk.EntityRole.Referencing)]
        public Incident Referencingincident_parent_incident
        {
            get { return this.GetRelatedEntity<Incident>("incident_parent_incident", Microsoft.Xrm.Sdk.EntityRole.Referencing); }
            set
            {
                this.OnPropertyChanging("Referencingincident_parent_incident");
                this.SetRelatedEntity<Incident>("incident_parent_incident", Microsoft.Xrm.Sdk.EntityRole.Referencing, value);
                this.OnPropertyChanged("Referencingincident_parent_incident");
            }
        }

        /// <summary>
        /// N:1 kbarticle_incidents
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("kbarticleid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("kbarticle_incidents")]
        public KbArticle kbarticle_incidents
        {
            get { return this.GetRelatedEntity<KbArticle>("kbarticle_incidents", null); }
            set
            {
                this.OnPropertyChanging("kbarticle_incidents");
                this.SetRelatedEntity<KbArticle>("kbarticle_incidents", null, value);
                this.OnPropertyChanged("kbarticle_incidents");
            }
        }

        /// <summary>
        /// N:1 lk_incidentbase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_incidentbase_createdby")]
        public SystemUser lk_incidentbase_createdby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_incidentbase_createdby", null); }
        }

        /// <summary>
        /// N:1 lk_incidentbase_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_incidentbase_createdonbehalfby")]
        public SystemUser lk_incidentbase_createdonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_incidentbase_createdonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_incidentbase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_incidentbase_modifiedby")]
        public SystemUser lk_incidentbase_modifiedby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_incidentbase_modifiedby", null); }
        }

        /// <summary>
        /// N:1 lk_incidentbase_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_incidentbase_modifiedonbehalfby")]
        public SystemUser lk_incidentbase_modifiedonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_incidentbase_modifiedonbehalfby", null); }
        }

        /// <summary>
        /// N:1 processstage_incident
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("stageid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("processstage_incident")]
        public ProcessStage processstage_incident
        {
            get { return this.GetRelatedEntity<ProcessStage>("processstage_incident", null); }
            set
            {
                this.OnPropertyChanging("processstage_incident");
                this.SetRelatedEntity<ProcessStage>("processstage_incident", null, value);
                this.OnPropertyChanged("processstage_incident");
            }
        }

        /// <summary>
        /// N:1 product_incidents
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("productid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("product_incidents")]
        public Product product_incidents
        {
            get { return this.GetRelatedEntity<Product>("product_incidents", null); }
            set
            {
                this.OnPropertyChanging("product_incidents");
                this.SetRelatedEntity<Product>("product_incidents", null, value);
                this.OnPropertyChanged("product_incidents");
            }
        }

        /// <summary>
        /// N:1 sla_cases
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("slainvokedid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("sla_cases")]
        public SLA sla_cases
        {
            get { return this.GetRelatedEntity<SLA>("sla_cases", null); }
        }

        /// <summary>
        /// N:1 slakpiinstance_incident_firstresponsebykpi
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("firstresponsebykpiid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("slakpiinstance_incident_firstresponsebykpi")]
        public SLAKPIInstance slakpiinstance_incident_firstresponsebykpi
        {
            get { return this.GetRelatedEntity<SLAKPIInstance>("slakpiinstance_incident_firstresponsebykpi", null); }
            set
            {
                this.OnPropertyChanging("slakpiinstance_incident_firstresponsebykpi");
                this.SetRelatedEntity<SLAKPIInstance>("slakpiinstance_incident_firstresponsebykpi", null, value);
                this.OnPropertyChanged("slakpiinstance_incident_firstresponsebykpi");
            }
        }

        /// <summary>
        /// N:1 slakpiinstance_incident_resolvebykpi
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("resolvebykpiid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("slakpiinstance_incident_resolvebykpi")]
        public SLAKPIInstance slakpiinstance_incident_resolvebykpi
        {
            get { return this.GetRelatedEntity<SLAKPIInstance>("slakpiinstance_incident_resolvebykpi", null); }
            set
            {
                this.OnPropertyChanging("slakpiinstance_incident_resolvebykpi");
                this.SetRelatedEntity<SLAKPIInstance>("slakpiinstance_incident_resolvebykpi", null, value);
                this.OnPropertyChanged("slakpiinstance_incident_resolvebykpi");
            }
        }

        /// <summary>
        /// N:1 socialprofile_cases
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("socialprofileid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("socialprofile_cases")]
        public SocialProfile socialprofile_cases
        {
            get { return this.GetRelatedEntity<SocialProfile>("socialprofile_cases", null); }
            set
            {
                this.OnPropertyChanging("socialprofile_cases");
                this.SetRelatedEntity<SocialProfile>("socialprofile_cases", null, value);
                this.OnPropertyChanged("socialprofile_cases");
            }
        }

        /// <summary>
        /// N:1 subject_incidents
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("subjectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("subject_incidents")]
        public Subject subject_incidents
        {
            get { return this.GetRelatedEntity<Subject>("subject_incidents", null); }
            set
            {
                this.OnPropertyChanging("subject_incidents");
                this.SetRelatedEntity<Subject>("subject_incidents", null, value);
                this.OnPropertyChanged("subject_incidents");
            }
        }

        /// <summary>
        /// N:1 system_user_incidents
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("system_user_incidents")]
        public SystemUser system_user_incidents
        {
            get { return this.GetRelatedEntity<SystemUser>("system_user_incidents", null); }
        }

        /// <summary>
        /// N:1 team_incidents
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_incidents")]
        public Team team_incidents
        {
            get { return this.GetRelatedEntity<Team>("team_incidents", null); }
        }

        /// <summary>
        /// N:1 TransactionCurrency_Incident
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("TransactionCurrency_Incident")]
        public TransactionCurrency TransactionCurrency_Incident
        {
            get { return this.GetRelatedEntity<TransactionCurrency>("TransactionCurrency_Incident", null); }
            set
            {
                this.OnPropertyChanging("TransactionCurrency_Incident");
                this.SetRelatedEntity<TransactionCurrency>("TransactionCurrency_Incident", null, value);
                this.OnPropertyChanged("TransactionCurrency_Incident");
            }
        }
    }
}