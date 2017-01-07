namespace __4_DAL_CRM
{
    /// <summary>
    /// Container for campaign activities and responses, sales literature, products, and lists to create, plan, execute, and track the results of a specific marketing campaign through its life.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("campaign")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class Campaign : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public Campaign() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "campaign";

        public const int EntityTypeCode = 4400;

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
        /// Enter the date when the campaign was closed or completed.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("actualend")]
        public System.Nullable<System.DateTime> ActualEnd
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("actualend"); }
            set
            {
                this.OnPropertyChanging("ActualEnd");
                this.SetAttributeValue("actualend", value);
                this.OnPropertyChanged("ActualEnd");
            }
        }

        /// <summary>
        /// Enter the actual start date and time for the campaign.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("actualstart")]
        public System.Nullable<System.DateTime> ActualStart
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("actualstart"); }
            set
            {
                this.OnPropertyChanging("ActualStart");
                this.SetAttributeValue("actualstart", value);
                this.OnPropertyChanged("ActualStart");
            }
        }

        /// <summary>
        /// Type the amount budgeted for the campaign to define a limit for how much you can spend.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("budgetedcost")]
        public Microsoft.Xrm.Sdk.Money BudgetedCost
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("budgetedcost"); }
            set
            {
                this.OnPropertyChanging("BudgetedCost");
                this.SetAttributeValue("budgetedcost", value);
                this.OnPropertyChanged("BudgetedCost");
            }
        }

        /// <summary>
        /// Shows the Budget Allocated field converted to the system's default base currency. The calculations use the exchange rate specified in the Currencies area.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("budgetedcost_base")]
        public Microsoft.Xrm.Sdk.Money BudgetedCost_Base
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("budgetedcost_base"); }
        }

        /// <summary>
        /// Unique identifier of the campaign.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("campaignid")]
        public System.Nullable<System.Guid> CampaignId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("campaignid"); }
            set
            {
                this.OnPropertyChanging("CampaignId");
                this.SetAttributeValue("campaignid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("CampaignId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("campaignid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.CampaignId = value; }
        }

        /// <summary>
        /// Type a number or other tracking code to identify the campaign. If no value is entered, a code will be generated automatically.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("codename")]
        public string CodeName
        {
            get { return this.GetAttributeValue<string>("codename"); }
            set
            {
                this.OnPropertyChanging("CodeName");
                this.SetAttributeValue("codename", value);
                this.OnPropertyChanged("CodeName");
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
        /// Type additional information to describe the campaign, such as the products or services offered or the targeted audience.
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
        /// Type the expected response rate for the campaign as a full number between 0 and 100.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("expectedresponse")]
        public System.Nullable<int> ExpectedResponse
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("expectedresponse"); }
            set
            {
                this.OnPropertyChanging("ExpectedResponse");
                this.SetAttributeValue("expectedresponse", value);
                this.OnPropertyChanged("ExpectedResponse");
            }
        }

        /// <summary>
        /// Type the expected revenue for the campaign for return on investment projections and post-campaign reporting.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("expectedrevenue")]
        public Microsoft.Xrm.Sdk.Money ExpectedRevenue
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("expectedrevenue"); }
            set
            {
                this.OnPropertyChanging("ExpectedRevenue");
                this.SetAttributeValue("expectedrevenue", value);
                this.OnPropertyChanged("ExpectedRevenue");
            }
        }

        /// <summary>
        /// Shows the estimated revenue converted to the system's default base currency. The calculations use the exchange rate specified in the Currencies area.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("expectedrevenue_base")]
        public Microsoft.Xrm.Sdk.Money ExpectedRevenue_Base
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("expectedrevenue_base"); }
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
        /// Select whether the campaign is a template that can be copied when you create future campaigns.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("istemplate")]
        public System.Nullable<bool> IsTemplate
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("istemplate"); }
            set
            {
                this.OnPropertyChanging("IsTemplate");
                this.SetAttributeValue("istemplate", value);
                this.OnPropertyChanged("IsTemplate");
            }
        }

        /// <summary>
        /// Type the promotional message or marketing copy for the campaign.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("message")]
        public string Message
        {
            get { return this.GetAttributeValue<string>("message"); }
            set
            {
                this.OnPropertyChanging("Message");
                this.SetAttributeValue("message", value);
                this.OnPropertyChanged("Message");
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
        /// Shows who created the record on behalf of another user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        /// Type a name for the campaign so that it is identified correctly in lists.
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
        /// Type the objective of the campaign, including products, services, discounts, and pricing.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objective")]
        public string Objective
        {
            get { return this.GetAttributeValue<string>("objective"); }
            set
            {
                this.OnPropertyChanging("Objective");
                this.SetAttributeValue("objective", value);
                this.OnPropertyChanged("Objective");
            }
        }

        /// <summary>
        /// Type the sum of any miscellaneous campaign costs not included in the campaign activities to make sure the actual cost of the campaign is calculated correctly.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("othercost")]
        public Microsoft.Xrm.Sdk.Money OtherCost
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("othercost"); }
            set
            {
                this.OnPropertyChanging("OtherCost");
                this.SetAttributeValue("othercost", value);
                this.OnPropertyChanged("OtherCost");
            }
        }

        /// <summary>
        /// Shows the Miscellaneous Costs field converted to the system's default base currency for reporting purposes. The calculations use the exchange rate specified in the Currencies area.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("othercost_base")]
        public Microsoft.Xrm.Sdk.Money OtherCost_Base
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("othercost_base"); }
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
        /// Unique identifier of the team who owns the campaign.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
        public Microsoft.Xrm.Sdk.EntityReference OwningTeam
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningteam"); }
        }

        /// <summary>
        /// Unique identifier of the user who owns the campaign.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
        public Microsoft.Xrm.Sdk.EntityReference OwningUser
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owninguser"); }
        }

        /// <summary>
        /// Choose the price list associated with this item to make sure the products associated with the campaign are offered at the correct prices.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("pricelistid")]
        public Microsoft.Xrm.Sdk.EntityReference PriceListId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("pricelistid"); }
            set
            {
                this.OnPropertyChanging("PriceListId");
                this.SetAttributeValue("pricelistid", value);
                this.OnPropertyChanged("PriceListId");
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
        /// Type a promotional code to track sales related to the campaign or allow customers to redeem a discount offer.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("promotioncodename")]
        public string PromotionCodeName
        {
            get { return this.GetAttributeValue<string>("promotioncodename"); }
            set
            {
                this.OnPropertyChanging("PromotionCodeName");
                this.SetAttributeValue("promotioncodename", value);
                this.OnPropertyChanged("PromotionCodeName");
            }
        }

        /// <summary>
        /// Enter the date when the campaign is scheduled to end.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("proposedend")]
        public System.Nullable<System.DateTime> ProposedEnd
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("proposedend"); }
            set
            {
                this.OnPropertyChanging("ProposedEnd");
                this.SetAttributeValue("proposedend", value);
                this.OnPropertyChanged("ProposedEnd");
            }
        }

        /// <summary>
        /// Enter the date when the campaign is scheduled to start.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("proposedstart")]
        public System.Nullable<System.DateTime> ProposedStart
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("proposedstart"); }
            set
            {
                this.OnPropertyChanging("ProposedStart");
                this.SetAttributeValue("proposedstart", value);
                this.OnPropertyChanged("ProposedStart");
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
        /// Shows the status of the campaign. By default, campaigns are active and can't be deactivated.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
        public System.Nullable<CampaignState> StateCode
        {
            get
            {
                Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
                if ((optionSet != null))
                {
                    return ((CampaignState) (System.Enum.ToObject(typeof(CampaignState), optionSet.Value)));
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// Select the campaign's status.
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
        /// Shows the sum of the amounts entered in the Total Cost of Campaign Activities and Miscellaneous Costs fields.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("totalactualcost")]
        public Microsoft.Xrm.Sdk.Money TotalActualCost
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("totalactualcost"); }
        }

        /// <summary>
        /// Shows the Total Cost of Campaign field converted to the system's default base currency for reporting purposes. The calculations use the exchange rate specified in the Currencies area.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("totalactualcost_base")]
        public Microsoft.Xrm.Sdk.Money TotalActualCost_Base
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("totalactualcost_base"); }
        }

        /// <summary>
        /// Shows the sum of the values entered in the Actual Cost field on all campaign activities related to the campaign.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("totalcampaignactivityactualcost")]
        public Microsoft.Xrm.Sdk.Money TotalCampaignActivityActualCost
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("totalcampaignactivityactualcost"); }
        }

        /// <summary>
        /// Shows the Total Cost of Campaign Activities field converted to the system's default base currency. The calculations use the exchange rate specified in the Currencies area.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("totalcampaignactivityactualcost_base")]
        public Microsoft.Xrm.Sdk.Money TotalCampaignActivityActualCost_Base
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("totalcampaignactivityactualcost_base"); }
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
        /// Select the type of the campaign.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("typecode")]
        public Microsoft.Xrm.Sdk.OptionSetValue TypeCode
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("typecode"); }
            set
            {
                this.OnPropertyChanging("TypeCode");
                this.SetAttributeValue("typecode", value);
                this.OnPropertyChanged("TypeCode");
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
        /// Version number of the campaign.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
        public System.Nullable<long> VersionNumber
        {
            get { return this.GetAttributeValue<System.Nullable<long>>("versionnumber"); }
        }

        /// <summary>
        /// 1:N campaign_activity_parties
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("campaign_activity_parties")]
        public System.Collections.Generic.IEnumerable<ActivityParty> campaign_activity_parties
        {
            get { return this.GetRelatedEntities<ActivityParty>("campaign_activity_parties", null); }
            set
            {
                this.OnPropertyChanging("campaign_activity_parties");
                this.SetRelatedEntities<ActivityParty>("campaign_activity_parties", null, value);
                this.OnPropertyChanged("campaign_activity_parties");
            }
        }

        /// <summary>
        /// 1:N Campaign_ActivityPointers
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Campaign_ActivityPointers")]
        public System.Collections.Generic.IEnumerable<ActivityPointer> Campaign_ActivityPointers
        {
            get { return this.GetRelatedEntities<ActivityPointer>("Campaign_ActivityPointers", null); }
            set
            {
                this.OnPropertyChanging("Campaign_ActivityPointers");
                this.SetRelatedEntities<ActivityPointer>("Campaign_ActivityPointers", null, value);
                this.OnPropertyChanged("Campaign_ActivityPointers");
            }
        }

        /// <summary>
        /// 1:N Campaign_Annotation
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Campaign_Annotation")]
        public System.Collections.Generic.IEnumerable<Annotation> Campaign_Annotation
        {
            get { return this.GetRelatedEntities<Annotation>("Campaign_Annotation", null); }
            set
            {
                this.OnPropertyChanging("Campaign_Annotation");
                this.SetRelatedEntities<Annotation>("Campaign_Annotation", null, value);
                this.OnPropertyChanged("Campaign_Annotation");
            }
        }

        /// <summary>
        /// 1:N Campaign_Appointments
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Campaign_Appointments")]
        public System.Collections.Generic.IEnumerable<Appointment> Campaign_Appointments
        {
            get { return this.GetRelatedEntities<Appointment>("Campaign_Appointments", null); }
            set
            {
                this.OnPropertyChanging("Campaign_Appointments");
                this.SetRelatedEntities<Appointment>("Campaign_Appointments", null, value);
                this.OnPropertyChanged("Campaign_Appointments");
            }
        }

        /// <summary>
        /// 1:N Campaign_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Campaign_AsyncOperations")]
        public System.Collections.Generic.IEnumerable<AsyncOperation> Campaign_AsyncOperations
        {
            get { return this.GetRelatedEntities<AsyncOperation>("Campaign_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("Campaign_AsyncOperations");
                this.SetRelatedEntities<AsyncOperation>("Campaign_AsyncOperations", null, value);
                this.OnPropertyChanged("Campaign_AsyncOperations");
            }
        }

        /// <summary>
        /// 1:N Campaign_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Campaign_BulkDeleteFailures")]
        public System.Collections.Generic.IEnumerable<BulkDeleteFailure> Campaign_BulkDeleteFailures
        {
            get { return this.GetRelatedEntities<BulkDeleteFailure>("Campaign_BulkDeleteFailures", null); }
            set
            {
                this.OnPropertyChanging("Campaign_BulkDeleteFailures");
                this.SetRelatedEntities<BulkDeleteFailure>("Campaign_BulkDeleteFailures", null, value);
                this.OnPropertyChanged("Campaign_BulkDeleteFailures");
            }
        }

        /// <summary>
        /// 1:N Campaign_CampaignActivities
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Campaign_CampaignActivities")]
        public System.Collections.Generic.IEnumerable<CampaignActivity> Campaign_CampaignActivities
        {
            get { return this.GetRelatedEntities<CampaignActivity>("Campaign_CampaignActivities", null); }
            set
            {
                this.OnPropertyChanging("Campaign_CampaignActivities");
                this.SetRelatedEntities<CampaignActivity>("Campaign_CampaignActivities", null, value);
                this.OnPropertyChanged("Campaign_CampaignActivities");
            }
        }

        /// <summary>
        /// 1:N Campaign_CampaignResponses
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Campaign_CampaignResponses")]
        public System.Collections.Generic.IEnumerable<CampaignResponse> Campaign_CampaignResponses
        {
            get { return this.GetRelatedEntities<CampaignResponse>("Campaign_CampaignResponses", null); }
            set
            {
                this.OnPropertyChanging("Campaign_CampaignResponses");
                this.SetRelatedEntities<CampaignResponse>("Campaign_CampaignResponses", null, value);
                this.OnPropertyChanged("Campaign_CampaignResponses");
            }
        }

        /// <summary>
        /// 1:N campaign_connections1
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("campaign_connections1")]
        public System.Collections.Generic.IEnumerable<Connection> campaign_connections1
        {
            get { return this.GetRelatedEntities<Connection>("campaign_connections1", null); }
            set
            {
                this.OnPropertyChanging("campaign_connections1");
                this.SetRelatedEntities<Connection>("campaign_connections1", null, value);
                this.OnPropertyChanged("campaign_connections1");
            }
        }

        /// <summary>
        /// 1:N campaign_connections2
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("campaign_connections2")]
        public System.Collections.Generic.IEnumerable<Connection> campaign_connections2
        {
            get { return this.GetRelatedEntities<Connection>("campaign_connections2", null); }
            set
            {
                this.OnPropertyChanging("campaign_connections2");
                this.SetRelatedEntities<Connection>("campaign_connections2", null, value);
                this.OnPropertyChanged("campaign_connections2");
            }
        }

        /// <summary>
        /// 1:N Campaign_DuplicateBaseRecord
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Campaign_DuplicateBaseRecord")]
        public System.Collections.Generic.IEnumerable<DuplicateRecord> Campaign_DuplicateBaseRecord
        {
            get { return this.GetRelatedEntities<DuplicateRecord>("Campaign_DuplicateBaseRecord", null); }
            set
            {
                this.OnPropertyChanging("Campaign_DuplicateBaseRecord");
                this.SetRelatedEntities<DuplicateRecord>("Campaign_DuplicateBaseRecord", null, value);
                this.OnPropertyChanged("Campaign_DuplicateBaseRecord");
            }
        }

        /// <summary>
        /// 1:N Campaign_DuplicateMatchingRecord
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Campaign_DuplicateMatchingRecord")]
        public System.Collections.Generic.IEnumerable<DuplicateRecord> Campaign_DuplicateMatchingRecord
        {
            get { return this.GetRelatedEntities<DuplicateRecord>("Campaign_DuplicateMatchingRecord", null); }
            set
            {
                this.OnPropertyChanging("Campaign_DuplicateMatchingRecord");
                this.SetRelatedEntities<DuplicateRecord>("Campaign_DuplicateMatchingRecord", null, value);
                this.OnPropertyChanged("Campaign_DuplicateMatchingRecord");
            }
        }

        /// <summary>
        /// 1:N Campaign_Emails
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Campaign_Emails")]
        public System.Collections.Generic.IEnumerable<Email> Campaign_Emails
        {
            get { return this.GetRelatedEntities<Email>("Campaign_Emails", null); }
            set
            {
                this.OnPropertyChanging("Campaign_Emails");
                this.SetRelatedEntities<Email>("Campaign_Emails", null, value);
                this.OnPropertyChanged("Campaign_Emails");
            }
        }

        /// <summary>
        /// 1:N Campaign_Faxes
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Campaign_Faxes")]
        public System.Collections.Generic.IEnumerable<Fax> Campaign_Faxes
        {
            get { return this.GetRelatedEntities<Fax>("Campaign_Faxes", null); }
            set
            {
                this.OnPropertyChanging("Campaign_Faxes");
                this.SetRelatedEntities<Fax>("Campaign_Faxes", null, value);
                this.OnPropertyChanged("Campaign_Faxes");
            }
        }

        /// <summary>
        /// 1:N campaign_leads
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("campaign_leads")]
        public System.Collections.Generic.IEnumerable<Lead> campaign_leads
        {
            get { return this.GetRelatedEntities<Lead>("campaign_leads", null); }
            set
            {
                this.OnPropertyChanging("campaign_leads");
                this.SetRelatedEntities<Lead>("campaign_leads", null, value);
                this.OnPropertyChanged("campaign_leads");
            }
        }

        /// <summary>
        /// 1:N Campaign_Letters
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Campaign_Letters")]
        public System.Collections.Generic.IEnumerable<Letter> Campaign_Letters
        {
            get { return this.GetRelatedEntities<Letter>("Campaign_Letters", null); }
            set
            {
                this.OnPropertyChanging("Campaign_Letters");
                this.SetRelatedEntities<Letter>("Campaign_Letters", null, value);
                this.OnPropertyChanged("Campaign_Letters");
            }
        }

        /// <summary>
        /// 1:N campaign_opportunities
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("campaign_opportunities")]
        public System.Collections.Generic.IEnumerable<Opportunity> campaign_opportunities
        {
            get { return this.GetRelatedEntities<Opportunity>("campaign_opportunities", null); }
            set
            {
                this.OnPropertyChanging("campaign_opportunities");
                this.SetRelatedEntities<Opportunity>("campaign_opportunities", null, value);
                this.OnPropertyChanged("campaign_opportunities");
            }
        }

        /// <summary>
        /// 1:N campaign_orders
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("campaign_orders")]
        public System.Collections.Generic.IEnumerable<SalesOrder> campaign_orders
        {
            get { return this.GetRelatedEntities<SalesOrder>("campaign_orders", null); }
            set
            {
                this.OnPropertyChanging("campaign_orders");
                this.SetRelatedEntities<SalesOrder>("campaign_orders", null, value);
                this.OnPropertyChanged("campaign_orders");
            }
        }

        /// <summary>
        /// 1:N Campaign_Phonecalls
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Campaign_Phonecalls")]
        public System.Collections.Generic.IEnumerable<PhoneCall> Campaign_Phonecalls
        {
            get { return this.GetRelatedEntities<PhoneCall>("Campaign_Phonecalls", null); }
            set
            {
                this.OnPropertyChanging("Campaign_Phonecalls");
                this.SetRelatedEntities<PhoneCall>("Campaign_Phonecalls", null, value);
                this.OnPropertyChanged("Campaign_Phonecalls");
            }
        }

        /// <summary>
        /// 1:N campaign_principalobjectattributeaccess
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("campaign_principalobjectattributeaccess")]
        public System.Collections.Generic.IEnumerable<PrincipalObjectAttributeAccess> campaign_principalobjectattributeaccess
        {
            get { return this.GetRelatedEntities<PrincipalObjectAttributeAccess>("campaign_principalobjectattributeaccess", null); }
            set
            {
                this.OnPropertyChanging("campaign_principalobjectattributeaccess");
                this.SetRelatedEntities<PrincipalObjectAttributeAccess>("campaign_principalobjectattributeaccess", null, value);
                this.OnPropertyChanged("campaign_principalobjectattributeaccess");
            }
        }

        /// <summary>
        /// 1:N Campaign_ProcessSessions
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Campaign_ProcessSessions")]
        public System.Collections.Generic.IEnumerable<ProcessSession> Campaign_ProcessSessions
        {
            get { return this.GetRelatedEntities<ProcessSession>("Campaign_ProcessSessions", null); }
            set
            {
                this.OnPropertyChanging("Campaign_ProcessSessions");
                this.SetRelatedEntities<ProcessSession>("Campaign_ProcessSessions", null, value);
                this.OnPropertyChanged("Campaign_ProcessSessions");
            }
        }

        /// <summary>
        /// 1:N campaign_quotes
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("campaign_quotes")]
        public System.Collections.Generic.IEnumerable<Quote> campaign_quotes
        {
            get { return this.GetRelatedEntities<Quote>("campaign_quotes", null); }
            set
            {
                this.OnPropertyChanging("campaign_quotes");
                this.SetRelatedEntities<Quote>("campaign_quotes", null, value);
                this.OnPropertyChanged("campaign_quotes");
            }
        }

        /// <summary>
        /// 1:N Campaign_RecurringAppointmentMasters
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Campaign_RecurringAppointmentMasters")]
        public System.Collections.Generic.IEnumerable<RecurringAppointmentMaster> Campaign_RecurringAppointmentMasters
        {
            get { return this.GetRelatedEntities<RecurringAppointmentMaster>("Campaign_RecurringAppointmentMasters", null); }
            set
            {
                this.OnPropertyChanging("Campaign_RecurringAppointmentMasters");
                this.SetRelatedEntities<RecurringAppointmentMaster>("Campaign_RecurringAppointmentMasters", null, value);
                this.OnPropertyChanged("Campaign_RecurringAppointmentMasters");
            }
        }

        /// <summary>
        /// 1:N Campaign_ServiceAppointments
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Campaign_ServiceAppointments")]
        public System.Collections.Generic.IEnumerable<ServiceAppointment> Campaign_ServiceAppointments
        {
            get { return this.GetRelatedEntities<ServiceAppointment>("Campaign_ServiceAppointments", null); }
            set
            {
                this.OnPropertyChanging("Campaign_ServiceAppointments");
                this.SetRelatedEntities<ServiceAppointment>("Campaign_ServiceAppointments", null, value);
                this.OnPropertyChanged("Campaign_ServiceAppointments");
            }
        }

        /// <summary>
        /// 1:N Campaign_Tasks
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Campaign_Tasks")]
        public System.Collections.Generic.IEnumerable<Task> Campaign_Tasks
        {
            get { return this.GetRelatedEntities<Task>("Campaign_Tasks", null); }
            set
            {
                this.OnPropertyChanging("Campaign_Tasks");
                this.SetRelatedEntities<Task>("Campaign_Tasks", null, value);
                this.OnPropertyChanged("Campaign_Tasks");
            }
        }

        /// <summary>
        /// 1:N userentityinstancedata_campaign
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_campaign")]
        public System.Collections.Generic.IEnumerable<UserEntityInstanceData> userentityinstancedata_campaign
        {
            get { return this.GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_campaign", null); }
            set
            {
                this.OnPropertyChanging("userentityinstancedata_campaign");
                this.SetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_campaign", null, value);
                this.OnPropertyChanged("userentityinstancedata_campaign");
            }
        }

        /// <summary>
        /// N:N campaigncampaign_association
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("campaigncampaign_association", Microsoft.Xrm.Sdk.EntityRole.Referencing)]
        public System.Collections.Generic.IEnumerable<Campaign> Referencingcampaigncampaign_association
        {
            get { return this.GetRelatedEntities<Campaign>("campaigncampaign_association", Microsoft.Xrm.Sdk.EntityRole.Referencing); }
            set
            {
                this.OnPropertyChanging("Referencingcampaigncampaign_association");
                this.SetRelatedEntities<Campaign>("campaigncampaign_association", Microsoft.Xrm.Sdk.EntityRole.Referencing, value);
                this.OnPropertyChanged("Referencingcampaigncampaign_association");
            }
        }

        /// <summary>
        /// N:N campaigncampaign_association
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("campaigncampaign_association", Microsoft.Xrm.Sdk.EntityRole.Referenced)]
        public System.Collections.Generic.IEnumerable<Campaign> Referencedcampaigncampaign_association
        {
            get { return this.GetRelatedEntities<Campaign>("campaigncampaign_association", Microsoft.Xrm.Sdk.EntityRole.Referenced); }
            set
            {
                this.OnPropertyChanging("Referencedcampaigncampaign_association");
                this.SetRelatedEntities<Campaign>("campaigncampaign_association", Microsoft.Xrm.Sdk.EntityRole.Referenced, value);
                this.OnPropertyChanged("Referencedcampaigncampaign_association");
            }
        }

        /// <summary>
        /// N:N campaignlist_association
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("campaignlist_association")]
        public System.Collections.Generic.IEnumerable<List> campaignlist_association
        {
            get { return this.GetRelatedEntities<List>("campaignlist_association", null); }
            set
            {
                this.OnPropertyChanging("campaignlist_association");
                this.SetRelatedEntities<List>("campaignlist_association", null, value);
                this.OnPropertyChanged("campaignlist_association");
            }
        }

        /// <summary>
        /// N:N campaignproduct_association
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("campaignproduct_association")]
        public System.Collections.Generic.IEnumerable<Product> campaignproduct_association
        {
            get { return this.GetRelatedEntities<Product>("campaignproduct_association", null); }
            set
            {
                this.OnPropertyChanging("campaignproduct_association");
                this.SetRelatedEntities<Product>("campaignproduct_association", null, value);
                this.OnPropertyChanged("campaignproduct_association");
            }
        }

        /// <summary>
        /// N:N campaignsalesliterature_association
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("campaignsalesliterature_association")]
        public System.Collections.Generic.IEnumerable<SalesLiterature> campaignsalesliterature_association
        {
            get { return this.GetRelatedEntities<SalesLiterature>("campaignsalesliterature_association", null); }
            set
            {
                this.OnPropertyChanging("campaignsalesliterature_association");
                this.SetRelatedEntities<SalesLiterature>("campaignsalesliterature_association", null, value);
                this.OnPropertyChanged("campaignsalesliterature_association");
            }
        }

        /// <summary>
        /// N:1 BusinessUnit_Campaigns
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("BusinessUnit_Campaigns")]
        public BusinessUnit BusinessUnit_Campaigns
        {
            get { return this.GetRelatedEntity<BusinessUnit>("BusinessUnit_Campaigns", null); }
        }

        /// <summary>
        /// N:1 lk_campaign_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_campaign_createdby")]
        public SystemUser lk_campaign_createdby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_campaign_createdby", null); }
        }

        /// <summary>
        /// N:1 lk_campaign_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_campaign_createdonbehalfby")]
        public SystemUser lk_campaign_createdonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_campaign_createdonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_campaign_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_campaign_modifiedby")]
        public SystemUser lk_campaign_modifiedby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_campaign_modifiedby", null); }
        }

        /// <summary>
        /// N:1 lk_campaign_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_campaign_modifiedonbehalfby")]
        public SystemUser lk_campaign_modifiedonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_campaign_modifiedonbehalfby", null); }
        }

        /// <summary>
        /// N:1 PriceList_Campaigns
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("pricelistid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("PriceList_Campaigns")]
        public PriceLevel PriceList_Campaigns
        {
            get { return this.GetRelatedEntity<PriceLevel>("PriceList_Campaigns", null); }
            set
            {
                this.OnPropertyChanging("PriceList_Campaigns");
                this.SetRelatedEntity<PriceLevel>("PriceList_Campaigns", null, value);
                this.OnPropertyChanged("PriceList_Campaigns");
            }
        }

        /// <summary>
        /// N:1 processstage_campaigns
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("stageid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("processstage_campaigns")]
        public ProcessStage processstage_campaigns
        {
            get { return this.GetRelatedEntity<ProcessStage>("processstage_campaigns", null); }
            set
            {
                this.OnPropertyChanging("processstage_campaigns");
                this.SetRelatedEntity<ProcessStage>("processstage_campaigns", null, value);
                this.OnPropertyChanged("processstage_campaigns");
            }
        }

        /// <summary>
        /// N:1 SystemUser_Campaigns
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SystemUser_Campaigns")]
        public SystemUser SystemUser_Campaigns
        {
            get { return this.GetRelatedEntity<SystemUser>("SystemUser_Campaigns", null); }
        }

        /// <summary>
        /// N:1 team_Campaigns
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_Campaigns")]
        public Team team_Campaigns
        {
            get { return this.GetRelatedEntity<Team>("team_Campaigns", null); }
        }

        /// <summary>
        /// N:1 transactioncurrency_campaign
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("transactioncurrency_campaign")]
        public TransactionCurrency transactioncurrency_campaign
        {
            get { return this.GetRelatedEntity<TransactionCurrency>("transactioncurrency_campaign", null); }
            set
            {
                this.OnPropertyChanging("transactioncurrency_campaign");
                this.SetRelatedEntity<TransactionCurrency>("transactioncurrency_campaign", null, value);
                this.OnPropertyChanged("transactioncurrency_campaign");
            }
        }
    }
}