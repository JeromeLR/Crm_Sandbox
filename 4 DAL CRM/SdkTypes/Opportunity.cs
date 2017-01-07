using _4_DAL_CRM;

namespace __4_DAL_CRM
{
    /// <summary>
    /// Potential revenue-generating event, or sale to an account, which needs to be tracked through a sales process to completion.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("opportunity")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class Opportunity : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public Opportunity() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "opportunity";

        public const int EntityTypeCode = 3;

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
        /// Unique identifier of the account with which the opportunity is associated.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("accountid")]
        public Microsoft.Xrm.Sdk.EntityReference AccountId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("accountid"); }
        }

        /// <summary>
        /// Shows the date and time when the opportunity was closed or canceled.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("actualclosedate")]
        public System.Nullable<System.DateTime> ActualCloseDate
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("actualclosedate"); }
            set
            {
                this.OnPropertyChanging("ActualCloseDate");
                this.SetAttributeValue("actualclosedate", value);
                this.OnPropertyChanged("ActualCloseDate");
            }
        }

        /// <summary>
        /// Type the actual revenue amount for the opportunity for reporting and analysis of estimated versus actual sales. Field defaults to the Est. Revenue value when an opportunity is won.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("actualvalue")]
        public Microsoft.Xrm.Sdk.Money ActualValue
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("actualvalue"); }
            set
            {
                this.OnPropertyChanging("ActualValue");
                this.SetAttributeValue("actualvalue", value);
                this.OnPropertyChanged("ActualValue");
            }
        }

        /// <summary>
        /// Shows the Actual Revenue field converted to the system's default base currency for reporting purposes. The calculation uses the exchange rate specified in the Currencies area.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("actualvalue_base")]
        public Microsoft.Xrm.Sdk.Money ActualValue_Base
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("actualvalue_base"); }
        }

        /// <summary>
        /// Type a value between 0 and 1,000,000,000,000 to indicate the lead's potential available budget.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("budgetamount")]
        public Microsoft.Xrm.Sdk.Money BudgetAmount
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("budgetamount"); }
            set
            {
                this.OnPropertyChanging("BudgetAmount");
                this.SetAttributeValue("budgetamount", value);
                this.OnPropertyChanged("BudgetAmount");
            }
        }

        /// <summary>
        /// Shows the budget amount converted to the system's base currency.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("budgetamount_base")]
        public Microsoft.Xrm.Sdk.Money BudgetAmount_Base
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("budgetamount_base"); }
        }

        /// <summary>
        /// Select the likely budget status for the lead's company. This may help determine the lead rating or your sales approach.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("budgetstatus")]
        public Microsoft.Xrm.Sdk.OptionSetValue BudgetStatus
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("budgetstatus"); }
            set
            {
                this.OnPropertyChanging("BudgetStatus");
                this.SetAttributeValue("budgetstatus", value);
                this.OnPropertyChanged("BudgetStatus");
            }
        }

        /// <summary>
        /// Shows the campaign that the opportunity was created from. The ID is used for tracking the success of the campaign.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("campaignid")]
        public Microsoft.Xrm.Sdk.EntityReference CampaignId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("campaignid"); }
            set
            {
                this.OnPropertyChanging("CampaignId");
                this.SetAttributeValue("campaignid", value);
                this.OnPropertyChanged("CampaignId");
            }
        }

        /// <summary>
        /// Choose whether the proposal feedback has been captured for the opportunity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("captureproposalfeedback")]
        public System.Nullable<bool> CaptureProposalFeedback
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("captureproposalfeedback"); }
            set
            {
                this.OnPropertyChanging("CaptureProposalFeedback");
                this.SetAttributeValue("captureproposalfeedback", value);
                this.OnPropertyChanged("CaptureProposalFeedback");
            }
        }

        /// <summary>
        /// Type a number from 0 to 100 that represents the likelihood of closing the opportunity. This can aid the sales team in their efforts to convert the opportunity in a sale.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("closeprobability")]
        public System.Nullable<int> CloseProbability
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("closeprobability"); }
            set
            {
                this.OnPropertyChanging("CloseProbability");
                this.SetAttributeValue("closeprobability", value);
                this.OnPropertyChanged("CloseProbability");
            }
        }

        /// <summary>
        /// Select whether a final proposal has been completed for the opportunity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("completefinalproposal")]
        public System.Nullable<bool> CompleteFinalProposal
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("completefinalproposal"); }
            set
            {
                this.OnPropertyChanging("CompleteFinalProposal");
                this.SetAttributeValue("completefinalproposal", value);
                this.OnPropertyChanged("CompleteFinalProposal");
            }
        }

        /// <summary>
        /// Select whether an internal review has been completed for this opportunity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("completeinternalreview")]
        public System.Nullable<bool> CompleteInternalReview
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("completeinternalreview"); }
            set
            {
                this.OnPropertyChanging("CompleteInternalReview");
                this.SetAttributeValue("completeinternalreview", value);
                this.OnPropertyChanged("CompleteInternalReview");
            }
        }

        /// <summary>
        /// Select whether the lead confirmed interest in your offerings. This helps in determining the lead quality and the probability of it turning into an opportunity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("confirminterest")]
        public System.Nullable<bool> ConfirmInterest
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("confirminterest"); }
            set
            {
                this.OnPropertyChanging("ConfirmInterest");
                this.SetAttributeValue("confirminterest", value);
                this.OnPropertyChanged("ConfirmInterest");
            }
        }

        /// <summary>
        /// Unique identifier of the contact associated with the opportunity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("contactid")]
        public Microsoft.Xrm.Sdk.EntityReference ContactId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("contactid"); }
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
        /// Type notes about the company or organization associated with the opportunity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("currentsituation")]
        public string CurrentSituation
        {
            get { return this.GetAttributeValue<string>("currentsituation"); }
            set
            {
                this.OnPropertyChanging("CurrentSituation");
                this.SetAttributeValue("currentsituation", value);
                this.OnPropertyChanged("CurrentSituation");
            }
        }

        /// <summary>
        /// Select the customer account or contact to provide a quick link to additional customer details, such as address, phone number, activities, and orders.
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
        /// Type some notes about the customer's requirements, to help the sales team identify products and services that could meet their requirements.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("customerneed")]
        public string CustomerNeed
        {
            get { return this.GetAttributeValue<string>("customerneed"); }
            set
            {
                this.OnPropertyChanging("CustomerNeed");
                this.SetAttributeValue("customerneed", value);
                this.OnPropertyChanged("CustomerNeed");
            }
        }

        /// <summary>
        /// Type notes about the customer's pain points to help the sales team identify products and services that could address these pain points.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("customerpainpoints")]
        public string CustomerPainPoints
        {
            get { return this.GetAttributeValue<string>("customerpainpoints"); }
            set
            {
                this.OnPropertyChanging("CustomerPainPoints");
                this.SetAttributeValue("customerpainpoints", value);
                this.OnPropertyChanged("CustomerPainPoints");
            }
        }

        /// <summary>
        /// Select whether your notes include information about who makes the purchase decisions at the lead's company.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("decisionmaker")]
        public System.Nullable<bool> DecisionMaker
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("decisionmaker"); }
            set
            {
                this.OnPropertyChanging("DecisionMaker");
                this.SetAttributeValue("decisionmaker", value);
                this.OnPropertyChanged("DecisionMaker");
            }
        }

        /// <summary>
        /// Type additional information to describe the opportunity, such as possible products to sell or past purchases from the customer.
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
        /// Select whether a proposal has been developed for the opportunity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("developproposal")]
        public System.Nullable<bool> DevelopProposal
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("developproposal"); }
            set
            {
                this.OnPropertyChanging("DevelopProposal");
                this.SetAttributeValue("developproposal", value);
                this.OnPropertyChanged("DevelopProposal");
            }
        }

        /// <summary>
        /// Type the discount amount for the opportunity if the customer is eligible for special savings.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("discountamount")]
        public Microsoft.Xrm.Sdk.Money DiscountAmount
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("discountamount"); }
            set
            {
                this.OnPropertyChanging("DiscountAmount");
                this.SetAttributeValue("discountamount", value);
                this.OnPropertyChanged("DiscountAmount");
            }
        }

        /// <summary>
        /// Shows the Opportunity Discount Amount field converted to the system's default base currency for reporting purposes. The calculation uses the exchange rate specified in the Currencies area.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("discountamount_base")]
        public Microsoft.Xrm.Sdk.Money DiscountAmount_Base
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("discountamount_base"); }
        }

        /// <summary>
        /// Type the discount rate that should be applied to the Product Totals field to include additional savings for the customer in the opportunity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("discountpercentage")]
        public System.Nullable<decimal> DiscountPercentage
        {
            get { return this.GetAttributeValue<System.Nullable<decimal>>("discountpercentage"); }
            set
            {
                this.OnPropertyChanging("DiscountPercentage");
                this.SetAttributeValue("discountpercentage", value);
                this.OnPropertyChanged("DiscountPercentage");
            }
        }

        /// <summary>
        /// Enter the expected closing date of the opportunity to help make accurate revenue forecasts.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("estimatedclosedate")]
        public System.Nullable<System.DateTime> EstimatedCloseDate
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("estimatedclosedate"); }
            set
            {
                this.OnPropertyChanging("EstimatedCloseDate");
                this.SetAttributeValue("estimatedclosedate", value);
                this.OnPropertyChanged("EstimatedCloseDate");
            }
        }

        /// <summary>
        /// Type the estimated revenue amount to indicate the potential sale or value of the opportunity for revenue forecasting. This field can be either system-populated or editable based on the selection in the Revenue field.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("estimatedvalue")]
        public Microsoft.Xrm.Sdk.Money EstimatedValue
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("estimatedvalue"); }
            set
            {
                this.OnPropertyChanging("EstimatedValue");
                this.SetAttributeValue("estimatedvalue", value);
                this.OnPropertyChanged("EstimatedValue");
            }
        }

        /// <summary>
        /// Shows the Actual Revenue field converted to the system's default base currency for reporting purposes. The calculation uses the exchange rate specified in the Currencies area.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("estimatedvalue_base")]
        public Microsoft.Xrm.Sdk.Money EstimatedValue_Base
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("estimatedvalue_base"); }
        }

        /// <summary>
        /// Select whether the fit between the lead's requirements and your offerings was evaluated.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("evaluatefit")]
        public System.Nullable<bool> EvaluateFit
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("evaluatefit"); }
            set
            {
                this.OnPropertyChanging("EvaluateFit");
                this.SetAttributeValue("evaluatefit", value);
                this.OnPropertyChanged("EvaluateFit");
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
        /// Choose whether the sales team has recorded detailed notes on the proposals and the account's responses.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("filedebrief")]
        public System.Nullable<bool> FileDebrief
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("filedebrief"); }
            set
            {
                this.OnPropertyChanging("FileDebrief");
                this.SetAttributeValue("filedebrief", value);
                this.OnPropertyChanged("FileDebrief");
            }
        }

        /// <summary>
        /// Enter the date and time when the final decision of the opportunity was made.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("finaldecisiondate")]
        public System.Nullable<System.DateTime> FinalDecisionDate
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("finaldecisiondate"); }
            set
            {
                this.OnPropertyChanging("FinalDecisionDate");
                this.SetAttributeValue("finaldecisiondate", value);
                this.OnPropertyChanged("FinalDecisionDate");
            }
        }

        /// <summary>
        /// Type the cost of freight or shipping for the products included in the opportunity for use in calculating the Total Amount field.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("freightamount")]
        public Microsoft.Xrm.Sdk.Money FreightAmount
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("freightamount"); }
            set
            {
                this.OnPropertyChanging("FreightAmount");
                this.SetAttributeValue("freightamount", value);
                this.OnPropertyChanged("FreightAmount");
            }
        }

        /// <summary>
        /// Shows the Freight Amount field converted to the system's default base currency for reporting purposes. The calculation uses the exchange rate specified in the Currencies area.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("freightamount_base")]
        public Microsoft.Xrm.Sdk.Money FreightAmount_Base
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("freightamount_base"); }
        }

        /// <summary>
        /// Select whether information about competitors is included.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("identifycompetitors")]
        public System.Nullable<bool> IdentifyCompetitors
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("identifycompetitors"); }
            set
            {
                this.OnPropertyChanging("IdentifyCompetitors");
                this.SetAttributeValue("identifycompetitors", value);
                this.OnPropertyChanged("IdentifyCompetitors");
            }
        }

        /// <summary>
        /// Select whether the customer contacts for this opportunity have been identified.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("identifycustomercontacts")]
        public System.Nullable<bool> IdentifyCustomerContacts
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("identifycustomercontacts"); }
            set
            {
                this.OnPropertyChanging("IdentifyCustomerContacts");
                this.SetAttributeValue("identifycustomercontacts", value);
                this.OnPropertyChanged("IdentifyCustomerContacts");
            }
        }

        /// <summary>
        /// Choose whether you have recorded who will pursue the opportunity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("identifypursuitteam")]
        public System.Nullable<bool> IdentifyPursuitTeam
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("identifypursuitteam"); }
            set
            {
                this.OnPropertyChanging("IdentifyPursuitTeam");
                this.SetAttributeValue("identifypursuitteam", value);
                this.OnPropertyChanged("IdentifyPursuitTeam");
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
        /// Choose whether someone from the sales team contacted this lead earlier.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("initialcommunication")]
        public Microsoft.Xrm.Sdk.OptionSetValue InitialCommunication
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("initialcommunication"); }
            set
            {
                this.OnPropertyChanging("InitialCommunication");
                this.SetAttributeValue("initialcommunication", value);
                this.OnPropertyChanged("InitialCommunication");
            }
        }

        /// <summary>
        /// Select whether the estimated revenue for the opportunity is calculated automatically based on the products entered or entered manually by a user.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isrevenuesystemcalculated")]
        public System.Nullable<bool> IsRevenueSystemCalculated
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("isrevenuesystemcalculated"); }
            set
            {
                this.OnPropertyChanging("IsRevenueSystemCalculated");
                this.SetAttributeValue("isrevenuesystemcalculated", value);
                this.OnPropertyChanged("IsRevenueSystemCalculated");
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
        /// Type a subject or descriptive name, such as the expected order or company name, for the opportunity.
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
        /// Choose how high the level of need is for the lead's company.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("need")]
        public Microsoft.Xrm.Sdk.OptionSetValue Need
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("need"); }
            set
            {
                this.OnPropertyChanging("Need");
                this.SetAttributeValue("need", value);
                this.OnPropertyChanged("Need");
            }
        }

        /// <summary>
        /// Unique identifier of the opportunity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("opportunityid")]
        public System.Nullable<System.Guid> OpportunityId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("opportunityid"); }
            set
            {
                this.OnPropertyChanging("OpportunityId");
                this.SetAttributeValue("opportunityid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("OpportunityId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("opportunityid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.OpportunityId = value; }
        }

        /// <summary>
        /// Select the expected value or priority of the opportunity based on revenue, customer status, or closing probability.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("opportunityratingcode")]
        public Microsoft.Xrm.Sdk.OptionSetValue OpportunityRatingCode
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("opportunityratingcode"); }
            set
            {
                this.OnPropertyChanging("OpportunityRatingCode");
                this.SetAttributeValue("opportunityratingcode", value);
                this.OnPropertyChanged("OpportunityRatingCode");
            }
        }

        /// <summary>
        /// Choose the lead that the opportunity was created from for reporting and analytics. The field is read-only after the opportunity is created and defaults to the correct lead when an opportunity is created from a converted lead.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("originatingleadid")]
        public Microsoft.Xrm.Sdk.EntityReference OriginatingLeadId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("originatingleadid"); }
            set
            {
                this.OnPropertyChanging("OriginatingLeadId");
                this.SetAttributeValue("originatingleadid", value);
                this.OnPropertyChanged("OriginatingLeadId");
            }
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
        /// Unique identifier of the business unit that owns the opportunity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
        public Microsoft.Xrm.Sdk.EntityReference OwningBusinessUnit
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningbusinessunit"); }
        }

        /// <summary>
        /// Unique identifier of the team who owns the opportunity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
        public Microsoft.Xrm.Sdk.EntityReference OwningTeam
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningteam"); }
        }

        /// <summary>
        /// Unique identifier of the user who owns the opportunity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
        public Microsoft.Xrm.Sdk.EntityReference OwningUser
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owninguser"); }
        }

        /// <summary>
        /// Choose an account to connect this opportunity to, so that the relationship is visible in reports and analytics, and to provide a quick link to additional details, such as financial information and activities.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("parentaccountid")]
        public Microsoft.Xrm.Sdk.EntityReference ParentAccountId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("parentaccountid"); }
            set
            {
                this.OnPropertyChanging("ParentAccountId");
                this.SetAttributeValue("parentaccountid", value);
                this.OnPropertyChanged("ParentAccountId");
            }
        }

        /// <summary>
        /// Choose a contact to connect this opportunity to, so that the relationship is visible in reports and analytics.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("parentcontactid")]
        public Microsoft.Xrm.Sdk.EntityReference ParentContactId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("parentcontactid"); }
            set
            {
                this.OnPropertyChanging("ParentContactId");
                this.SetAttributeValue("parentcontactid", value);
                this.OnPropertyChanged("ParentContactId");
            }
        }

        /// <summary>
        /// Information about whether the opportunity participates in workflow rules.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("participatesinworkflow")]
        public System.Nullable<bool> ParticipatesInWorkflow
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("participatesinworkflow"); }
            set
            {
                this.OnPropertyChanging("ParticipatesInWorkflow");
                this.SetAttributeValue("participatesinworkflow", value);
                this.OnPropertyChanged("ParticipatesInWorkflow");
            }
        }

        /// <summary>
        /// Select whether the final proposal has been presented to the account.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("presentfinalproposal")]
        public System.Nullable<bool> PresentFinalProposal
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("presentfinalproposal"); }
            set
            {
                this.OnPropertyChanging("PresentFinalProposal");
                this.SetAttributeValue("presentfinalproposal", value);
                this.OnPropertyChanged("PresentFinalProposal");
            }
        }

        /// <summary>
        /// Select whether a proposal for the opportunity has been presented to the account.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("presentproposal")]
        public System.Nullable<bool> PresentProposal
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("presentproposal"); }
            set
            {
                this.OnPropertyChanging("PresentProposal");
                this.SetAttributeValue("presentproposal", value);
                this.OnPropertyChanged("PresentProposal");
            }
        }

        /// <summary>
        /// Choose the price list associated with this record to make sure the products associated with the campaign are offered at the correct prices.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("pricelevelid")]
        public Microsoft.Xrm.Sdk.EntityReference PriceLevelId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("pricelevelid"); }
            set
            {
                this.OnPropertyChanging("PriceLevelId");
                this.SetAttributeValue("pricelevelid", value);
                this.OnPropertyChanged("PriceLevelId");
            }
        }

        /// <summary>
        /// Pricing error for the opportunity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("pricingerrorcode")]
        public Microsoft.Xrm.Sdk.OptionSetValue PricingErrorCode
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("pricingerrorcode"); }
            set
            {
                this.OnPropertyChanging("PricingErrorCode");
                this.SetAttributeValue("pricingerrorcode", value);
                this.OnPropertyChanged("PricingErrorCode");
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
        /// Type notes about the proposed solution for the opportunity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("proposedsolution")]
        public string ProposedSolution
        {
            get { return this.GetAttributeValue<string>("proposedsolution"); }
            set
            {
                this.OnPropertyChanging("ProposedSolution");
                this.SetAttributeValue("proposedsolution", value);
                this.OnPropertyChanged("ProposedSolution");
            }
        }

        /// <summary>
        /// Choose whether an individual or a committee will be involved in the purchase process for the lead.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("purchaseprocess")]
        public Microsoft.Xrm.Sdk.OptionSetValue PurchaseProcess
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("purchaseprocess"); }
            set
            {
                this.OnPropertyChanging("PurchaseProcess");
                this.SetAttributeValue("purchaseprocess", value);
                this.OnPropertyChanged("PurchaseProcess");
            }
        }

        /// <summary>
        /// Choose how long the lead will likely take to make the purchase.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("purchasetimeframe")]
        public Microsoft.Xrm.Sdk.OptionSetValue PurchaseTimeframe
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("purchasetimeframe"); }
            set
            {
                this.OnPropertyChanging("PurchaseTimeframe");
                this.SetAttributeValue("purchasetimeframe", value);
                this.OnPropertyChanged("PurchaseTimeframe");
            }
        }

        /// <summary>
        /// Select whether the decision about pursuing the opportunity has been made.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("pursuitdecision")]
        public System.Nullable<bool> PursuitDecision
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("pursuitdecision"); }
            set
            {
                this.OnPropertyChanging("PursuitDecision");
                this.SetAttributeValue("pursuitdecision", value);
                this.OnPropertyChanged("PursuitDecision");
            }
        }

        /// <summary>
        /// Type comments about the qualification or scoring of the lead.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("qualificationcomments")]
        public string QualificationComments
        {
            get { return this.GetAttributeValue<string>("qualificationcomments"); }
            set
            {
                this.OnPropertyChanging("QualificationComments");
                this.SetAttributeValue("qualificationcomments", value);
                this.OnPropertyChanged("QualificationComments");
            }
        }

        /// <summary>
        /// Type comments about the quotes associated with the opportunity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("quotecomments")]
        public string QuoteComments
        {
            get { return this.GetAttributeValue<string>("quotecomments"); }
            set
            {
                this.OnPropertyChanging("QuoteComments");
                this.SetAttributeValue("quotecomments", value);
                this.OnPropertyChanged("QuoteComments");
            }
        }

        /// <summary>
        /// Choose whether the proposal feedback has been captured and resolved for the opportunity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("resolvefeedback")]
        public System.Nullable<bool> ResolveFeedback
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("resolvefeedback"); }
            set
            {
                this.OnPropertyChanging("ResolveFeedback");
                this.SetAttributeValue("resolvefeedback", value);
                this.OnPropertyChanged("ResolveFeedback");
            }
        }

        /// <summary>
        /// Select the sales stage of this opportunity to aid the sales team in their efforts to win this opportunity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("salesstage")]
        public Microsoft.Xrm.Sdk.OptionSetValue SalesStage
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("salesstage"); }
            set
            {
                this.OnPropertyChanging("SalesStage");
                this.SetAttributeValue("salesstage", value);
                this.OnPropertyChanged("SalesStage");
            }
        }

        /// <summary>
        /// Select the sales process stage for the opportunity to indicate the probability of closing the opportunity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("salesstagecode")]
        public Microsoft.Xrm.Sdk.OptionSetValue SalesStageCode
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("salesstagecode"); }
            set
            {
                this.OnPropertyChanging("SalesStageCode");
                this.SetAttributeValue("salesstagecode", value);
                this.OnPropertyChanged("SalesStageCode");
            }
        }

        /// <summary>
        /// Enter the date and time of the prospecting follow-up meeting with the lead.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("schedulefollowup_prospect")]
        public System.Nullable<System.DateTime> ScheduleFollowup_Prospect
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("schedulefollowup_prospect"); }
            set
            {
                this.OnPropertyChanging("ScheduleFollowup_Prospect");
                this.SetAttributeValue("schedulefollowup_prospect", value);
                this.OnPropertyChanged("ScheduleFollowup_Prospect");
            }
        }

        /// <summary>
        /// Enter the date and time of the qualifying follow-up meeting with the lead.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("schedulefollowup_qualify")]
        public System.Nullable<System.DateTime> ScheduleFollowup_Qualify
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("schedulefollowup_qualify"); }
            set
            {
                this.OnPropertyChanging("ScheduleFollowup_Qualify");
                this.SetAttributeValue("schedulefollowup_qualify", value);
                this.OnPropertyChanged("ScheduleFollowup_Qualify");
            }
        }

        /// <summary>
        /// Enter the date and time of the proposal meeting for the opportunity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("scheduleproposalmeeting")]
        public System.Nullable<System.DateTime> ScheduleProposalMeeting
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("scheduleproposalmeeting"); }
            set
            {
                this.OnPropertyChanging("ScheduleProposalMeeting");
                this.SetAttributeValue("scheduleproposalmeeting", value);
                this.OnPropertyChanged("ScheduleProposalMeeting");
            }
        }

        /// <summary>
        /// Select whether a thank you note has been sent to the account for considering the proposal.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sendthankyounote")]
        public System.Nullable<bool> SendThankYouNote
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("sendthankyounote"); }
            set
            {
                this.OnPropertyChanging("SendThankYouNote");
                this.SetAttributeValue("sendthankyounote", value);
                this.OnPropertyChanged("SendThankYouNote");
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
        /// Shows whether the opportunity is open, won, or lost. Won and lost opportunities are read-only and can't be edited until they are reactivated.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
        public System.Nullable<OpportunityState> StateCode
        {
            get
            {
                Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
                if ((optionSet != null))
                {
                    return ((OpportunityState) (System.Enum.ToObject(typeof(OpportunityState), optionSet.Value)));
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// Select the opportunity's status.
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
        /// Shows the ID of the workflow step.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("stepid")]
        public System.Nullable<System.Guid> StepId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("stepid"); }
            set
            {
                this.OnPropertyChanging("StepId");
                this.SetAttributeValue("stepid", value);
                this.OnPropertyChanged("StepId");
            }
        }

        /// <summary>
        /// Shows the current phase in the sales pipeline for the opportunity. This is updated by a workflow.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("stepname")]
        public string StepName
        {
            get { return this.GetAttributeValue<string>("stepname"); }
            set
            {
                this.OnPropertyChanging("StepName");
                this.SetAttributeValue("stepname", value);
                this.OnPropertyChanged("StepName");
            }
        }

        /// <summary>
        /// Select when the opportunity is likely to be closed.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("timeline")]
        public Microsoft.Xrm.Sdk.OptionSetValue TimeLine
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("timeline"); }
            set
            {
                this.OnPropertyChanging("TimeLine");
                this.SetAttributeValue("timeline", value);
                this.OnPropertyChanged("TimeLine");
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
        /// Shows the total amount due, calculated as the sum of the products, discounts, freight, and taxes for the opportunity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("totalamount")]
        public Microsoft.Xrm.Sdk.Money TotalAmount
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("totalamount"); }
            set
            {
                this.OnPropertyChanging("TotalAmount");
                this.SetAttributeValue("totalamount", value);
                this.OnPropertyChanged("TotalAmount");
            }
        }

        /// <summary>
        /// Shows the Total Amount field converted to the system's default base currency for reporting purposes. The calculation uses the exchange rate specified in the Currencies area.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("totalamount_base")]
        public Microsoft.Xrm.Sdk.Money TotalAmount_Base
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("totalamount_base"); }
        }

        /// <summary>
        /// Shows the total product amount for the opportunity, minus any discounts. This value is added to freight and tax amounts in the calculation for the total amount of the opportunity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("totalamountlessfreight")]
        public Microsoft.Xrm.Sdk.Money TotalAmountLessFreight
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("totalamountlessfreight"); }
            set
            {
                this.OnPropertyChanging("TotalAmountLessFreight");
                this.SetAttributeValue("totalamountlessfreight", value);
                this.OnPropertyChanged("TotalAmountLessFreight");
            }
        }

        /// <summary>
        /// Shows the Total Pre-Freight Amount field converted to the system's default base currency for reporting purposes. The calculation uses the exchange rate specified in the Currencies area.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("totalamountlessfreight_base")]
        public Microsoft.Xrm.Sdk.Money TotalAmountLessFreight_Base
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("totalamountlessfreight_base"); }
        }

        /// <summary>
        /// Shows the total discount amount, based on the discount price and rate entered on the opportunity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("totaldiscountamount")]
        public Microsoft.Xrm.Sdk.Money TotalDiscountAmount
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("totaldiscountamount"); }
            set
            {
                this.OnPropertyChanging("TotalDiscountAmount");
                this.SetAttributeValue("totaldiscountamount", value);
                this.OnPropertyChanged("TotalDiscountAmount");
            }
        }

        /// <summary>
        /// Shows the Total Discount Amount field converted to the system's default base currency for reporting purposes. The calculation uses the exchange rate specified in the Currencies area.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("totaldiscountamount_base")]
        public Microsoft.Xrm.Sdk.Money TotalDiscountAmount_Base
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("totaldiscountamount_base"); }
        }

        /// <summary>
        /// Shows the sum of all existing and write-in products included on the opportunity, based on the specified price list and quantities.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("totallineitemamount")]
        public Microsoft.Xrm.Sdk.Money TotalLineItemAmount
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("totallineitemamount"); }
            set
            {
                this.OnPropertyChanging("TotalLineItemAmount");
                this.SetAttributeValue("totallineitemamount", value);
                this.OnPropertyChanged("TotalLineItemAmount");
            }
        }

        /// <summary>
        /// Shows the Total Detail Amount field converted to the system's default base currency for reporting purposes. The calculation uses the exchange rate specified in the Currencies area.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("totallineitemamount_base")]
        public Microsoft.Xrm.Sdk.Money TotalLineItemAmount_Base
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("totallineitemamount_base"); }
        }

        /// <summary>
        /// Shows the total of the Manual Discount amounts specified on all products included in the opportunity. This value is reflected in the Total Detail Amount field on the opportunity and is added to any discount amount or rate specified on the opportunity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("totallineitemdiscountamount")]
        public Microsoft.Xrm.Sdk.Money TotalLineItemDiscountAmount
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("totallineitemdiscountamount"); }
            set
            {
                this.OnPropertyChanging("TotalLineItemDiscountAmount");
                this.SetAttributeValue("totallineitemdiscountamount", value);
                this.OnPropertyChanged("TotalLineItemDiscountAmount");
            }
        }

        /// <summary>
        /// Shows the Total Line Item Discount Amount field to the system's default base currency for reporting purposes. The calculation uses the exchange rate specified in the Currencies area.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("totallineitemdiscountamount_base")]
        public Microsoft.Xrm.Sdk.Money TotalLineItemDiscountAmount_Base
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("totallineitemdiscountamount_base"); }
        }

        /// <summary>
        /// Shows the total of the Tax amounts specified on all products included in the opportunity, included in the Total Amount field calculation for the opportunity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("totaltax")]
        public Microsoft.Xrm.Sdk.Money TotalTax
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("totaltax"); }
            set
            {
                this.OnPropertyChanging("TotalTax");
                this.SetAttributeValue("totaltax", value);
                this.OnPropertyChanged("TotalTax");
            }
        }

        /// <summary>
        /// Shows the Total Tax field converted to the system's default base currency for reporting purposes. The calculation uses the exchange rate specified in the Currencies area.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("totaltax_base")]
        public Microsoft.Xrm.Sdk.Money TotalTax_Base
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("totaltax_base"); }
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
        /// Version number of the opportunity.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
        public System.Nullable<long> VersionNumber
        {
            get { return this.GetAttributeValue<System.Nullable<long>>("versionnumber"); }
        }

        /// <summary>
        /// 1:N CreatedOpportunity_BulkOperationLogs
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("CreatedOpportunity_BulkOperationLogs")]
        public System.Collections.Generic.IEnumerable<BulkOperationLog> CreatedOpportunity_BulkOperationLogs
        {
            get { return this.GetRelatedEntities<BulkOperationLog>("CreatedOpportunity_BulkOperationLogs", null); }
            set
            {
                this.OnPropertyChanging("CreatedOpportunity_BulkOperationLogs");
                this.SetRelatedEntities<BulkOperationLog>("CreatedOpportunity_BulkOperationLogs", null, value);
                this.OnPropertyChanged("CreatedOpportunity_BulkOperationLogs");
            }
        }

        /// <summary>
        /// 1:N lead_qualifying_opportunity
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lead_qualifying_opportunity")]
        public System.Collections.Generic.IEnumerable<Lead> lead_qualifying_opportunity
        {
            get { return this.GetRelatedEntities<Lead>("lead_qualifying_opportunity", null); }
            set
            {
                this.OnPropertyChanging("lead_qualifying_opportunity");
                this.SetRelatedEntities<Lead>("lead_qualifying_opportunity", null, value);
                this.OnPropertyChanged("lead_qualifying_opportunity");
            }
        }

        /// <summary>
        /// 1:N opportunity_activity_parties
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("opportunity_activity_parties")]
        public System.Collections.Generic.IEnumerable<ActivityParty> opportunity_activity_parties
        {
            get { return this.GetRelatedEntities<ActivityParty>("opportunity_activity_parties", null); }
            set
            {
                this.OnPropertyChanging("opportunity_activity_parties");
                this.SetRelatedEntities<ActivityParty>("opportunity_activity_parties", null, value);
                this.OnPropertyChanged("opportunity_activity_parties");
            }
        }

        /// <summary>
        /// 1:N Opportunity_ActivityPointers
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Opportunity_ActivityPointers")]
        public System.Collections.Generic.IEnumerable<ActivityPointer> Opportunity_ActivityPointers
        {
            get { return this.GetRelatedEntities<ActivityPointer>("Opportunity_ActivityPointers", null); }
            set
            {
                this.OnPropertyChanging("Opportunity_ActivityPointers");
                this.SetRelatedEntities<ActivityPointer>("Opportunity_ActivityPointers", null, value);
                this.OnPropertyChanged("Opportunity_ActivityPointers");
            }
        }

        /// <summary>
        /// 1:N Opportunity_Annotation
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Opportunity_Annotation")]
        public System.Collections.Generic.IEnumerable<Annotation> Opportunity_Annotation
        {
            get { return this.GetRelatedEntities<Annotation>("Opportunity_Annotation", null); }
            set
            {
                this.OnPropertyChanging("Opportunity_Annotation");
                this.SetRelatedEntities<Annotation>("Opportunity_Annotation", null, value);
                this.OnPropertyChanged("Opportunity_Annotation");
            }
        }

        /// <summary>
        /// 1:N Opportunity_Appointments
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Opportunity_Appointments")]
        public System.Collections.Generic.IEnumerable<Appointment> Opportunity_Appointments
        {
            get { return this.GetRelatedEntities<Appointment>("Opportunity_Appointments", null); }
            set
            {
                this.OnPropertyChanging("Opportunity_Appointments");
                this.SetRelatedEntities<Appointment>("Opportunity_Appointments", null, value);
                this.OnPropertyChanged("Opportunity_Appointments");
            }
        }

        /// <summary>
        /// 1:N Opportunity_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Opportunity_AsyncOperations")]
        public System.Collections.Generic.IEnumerable<AsyncOperation> Opportunity_AsyncOperations
        {
            get { return this.GetRelatedEntities<AsyncOperation>("Opportunity_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("Opportunity_AsyncOperations");
                this.SetRelatedEntities<AsyncOperation>("Opportunity_AsyncOperations", null, value);
                this.OnPropertyChanged("Opportunity_AsyncOperations");
            }
        }

        /// <summary>
        /// 1:N Opportunity_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Opportunity_BulkDeleteFailures")]
        public System.Collections.Generic.IEnumerable<BulkDeleteFailure> Opportunity_BulkDeleteFailures
        {
            get { return this.GetRelatedEntities<BulkDeleteFailure>("Opportunity_BulkDeleteFailures", null); }
            set
            {
                this.OnPropertyChanging("Opportunity_BulkDeleteFailures");
                this.SetRelatedEntities<BulkDeleteFailure>("Opportunity_BulkDeleteFailures", null, value);
                this.OnPropertyChanged("Opportunity_BulkDeleteFailures");
            }
        }

        /// <summary>
        /// 1:N opportunity_connections1
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("opportunity_connections1")]
        public System.Collections.Generic.IEnumerable<Connection> opportunity_connections1
        {
            get { return this.GetRelatedEntities<Connection>("opportunity_connections1", null); }
            set
            {
                this.OnPropertyChanging("opportunity_connections1");
                this.SetRelatedEntities<Connection>("opportunity_connections1", null, value);
                this.OnPropertyChanged("opportunity_connections1");
            }
        }

        /// <summary>
        /// 1:N opportunity_connections2
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("opportunity_connections2")]
        public System.Collections.Generic.IEnumerable<Connection> opportunity_connections2
        {
            get { return this.GetRelatedEntities<Connection>("opportunity_connections2", null); }
            set
            {
                this.OnPropertyChanging("opportunity_connections2");
                this.SetRelatedEntities<Connection>("opportunity_connections2", null, value);
                this.OnPropertyChanged("opportunity_connections2");
            }
        }

        /// <summary>
        /// 1:N opportunity_customer_opportunity_roles
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("opportunity_customer_opportunity_roles")]
        public System.Collections.Generic.IEnumerable<CustomerOpportunityRole> opportunity_customer_opportunity_roles
        {
            get { return this.GetRelatedEntities<CustomerOpportunityRole>("opportunity_customer_opportunity_roles", null); }
            set
            {
                this.OnPropertyChanging("opportunity_customer_opportunity_roles");
                this.SetRelatedEntities<CustomerOpportunityRole>("opportunity_customer_opportunity_roles", null, value);
                this.OnPropertyChanged("opportunity_customer_opportunity_roles");
            }
        }

        /// <summary>
        /// 1:N Opportunity_DuplicateBaseRecord
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Opportunity_DuplicateBaseRecord")]
        public System.Collections.Generic.IEnumerable<DuplicateRecord> Opportunity_DuplicateBaseRecord
        {
            get { return this.GetRelatedEntities<DuplicateRecord>("Opportunity_DuplicateBaseRecord", null); }
            set
            {
                this.OnPropertyChanging("Opportunity_DuplicateBaseRecord");
                this.SetRelatedEntities<DuplicateRecord>("Opportunity_DuplicateBaseRecord", null, value);
                this.OnPropertyChanged("Opportunity_DuplicateBaseRecord");
            }
        }

        /// <summary>
        /// 1:N Opportunity_DuplicateMatchingRecord
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Opportunity_DuplicateMatchingRecord")]
        public System.Collections.Generic.IEnumerable<DuplicateRecord> Opportunity_DuplicateMatchingRecord
        {
            get { return this.GetRelatedEntities<DuplicateRecord>("Opportunity_DuplicateMatchingRecord", null); }
            set
            {
                this.OnPropertyChanging("Opportunity_DuplicateMatchingRecord");
                this.SetRelatedEntities<DuplicateRecord>("Opportunity_DuplicateMatchingRecord", null, value);
                this.OnPropertyChanged("Opportunity_DuplicateMatchingRecord");
            }
        }

        /// <summary>
        /// 1:N Opportunity_Emails
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Opportunity_Emails")]
        public System.Collections.Generic.IEnumerable<Email> Opportunity_Emails
        {
            get { return this.GetRelatedEntities<Email>("Opportunity_Emails", null); }
            set
            {
                this.OnPropertyChanging("Opportunity_Emails");
                this.SetRelatedEntities<Email>("Opportunity_Emails", null, value);
                this.OnPropertyChanged("Opportunity_Emails");
            }
        }

        /// <summary>
        /// 1:N Opportunity_Faxes
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Opportunity_Faxes")]
        public System.Collections.Generic.IEnumerable<Fax> Opportunity_Faxes
        {
            get { return this.GetRelatedEntities<Fax>("Opportunity_Faxes", null); }
            set
            {
                this.OnPropertyChanging("Opportunity_Faxes");
                this.SetRelatedEntities<Fax>("Opportunity_Faxes", null, value);
                this.OnPropertyChanged("Opportunity_Faxes");
            }
        }

        /// <summary>
        /// 1:N opportunity_invoices
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("opportunity_invoices")]
        public System.Collections.Generic.IEnumerable<Invoice> opportunity_invoices
        {
            get { return this.GetRelatedEntities<Invoice>("opportunity_invoices", null); }
            set
            {
                this.OnPropertyChanging("opportunity_invoices");
                this.SetRelatedEntities<Invoice>("opportunity_invoices", null, value);
                this.OnPropertyChanged("opportunity_invoices");
            }
        }

        /// <summary>
        /// 1:N Opportunity_Letters
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Opportunity_Letters")]
        public System.Collections.Generic.IEnumerable<Letter> Opportunity_Letters
        {
            get { return this.GetRelatedEntities<Letter>("Opportunity_Letters", null); }
            set
            {
                this.OnPropertyChanging("Opportunity_Letters");
                this.SetRelatedEntities<Letter>("Opportunity_Letters", null, value);
                this.OnPropertyChanged("Opportunity_Letters");
            }
        }

        /// <summary>
        /// 1:N Opportunity_OpportunityClose
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Opportunity_OpportunityClose")]
        public System.Collections.Generic.IEnumerable<OpportunityClose> Opportunity_OpportunityClose
        {
            get { return this.GetRelatedEntities<OpportunityClose>("Opportunity_OpportunityClose", null); }
            set
            {
                this.OnPropertyChanging("Opportunity_OpportunityClose");
                this.SetRelatedEntities<OpportunityClose>("Opportunity_OpportunityClose", null, value);
                this.OnPropertyChanged("Opportunity_OpportunityClose");
            }
        }

        /// <summary>
        /// 1:N Opportunity_Phonecalls
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Opportunity_Phonecalls")]
        public System.Collections.Generic.IEnumerable<PhoneCall> Opportunity_Phonecalls
        {
            get { return this.GetRelatedEntities<PhoneCall>("Opportunity_Phonecalls", null); }
            set
            {
                this.OnPropertyChanging("Opportunity_Phonecalls");
                this.SetRelatedEntities<PhoneCall>("Opportunity_Phonecalls", null, value);
                this.OnPropertyChanged("Opportunity_Phonecalls");
            }
        }

        /// <summary>
        /// 1:N opportunity_PostFollows
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("opportunity_PostFollows")]
        public System.Collections.Generic.IEnumerable<PostFollow> opportunity_PostFollows
        {
            get { return this.GetRelatedEntities<PostFollow>("opportunity_PostFollows", null); }
            set
            {
                this.OnPropertyChanging("opportunity_PostFollows");
                this.SetRelatedEntities<PostFollow>("opportunity_PostFollows", null, value);
                this.OnPropertyChanged("opportunity_PostFollows");
            }
        }

        /// <summary>
        /// 1:N opportunity_principalobjectattributeaccess
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("opportunity_principalobjectattributeaccess")]
        public System.Collections.Generic.IEnumerable<PrincipalObjectAttributeAccess> opportunity_principalobjectattributeaccess
        {
            get { return this.GetRelatedEntities<PrincipalObjectAttributeAccess>("opportunity_principalobjectattributeaccess", null); }
            set
            {
                this.OnPropertyChanging("opportunity_principalobjectattributeaccess");
                this.SetRelatedEntities<PrincipalObjectAttributeAccess>("opportunity_principalobjectattributeaccess", null, value);
                this.OnPropertyChanged("opportunity_principalobjectattributeaccess");
            }
        }

        /// <summary>
        /// 1:N Opportunity_ProcessSessions
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Opportunity_ProcessSessions")]
        public System.Collections.Generic.IEnumerable<ProcessSession> Opportunity_ProcessSessions
        {
            get { return this.GetRelatedEntities<ProcessSession>("Opportunity_ProcessSessions", null); }
            set
            {
                this.OnPropertyChanging("Opportunity_ProcessSessions");
                this.SetRelatedEntities<ProcessSession>("Opportunity_ProcessSessions", null, value);
                this.OnPropertyChanged("Opportunity_ProcessSessions");
            }
        }

        /// <summary>
        /// 1:N opportunity_quotes
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("opportunity_quotes")]
        public System.Collections.Generic.IEnumerable<Quote> opportunity_quotes
        {
            get { return this.GetRelatedEntities<Quote>("opportunity_quotes", null); }
            set
            {
                this.OnPropertyChanging("opportunity_quotes");
                this.SetRelatedEntities<Quote>("opportunity_quotes", null, value);
                this.OnPropertyChanged("opportunity_quotes");
            }
        }

        /// <summary>
        /// 1:N Opportunity_RecurringAppointmentMasters
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Opportunity_RecurringAppointmentMasters")]
        public System.Collections.Generic.IEnumerable<RecurringAppointmentMaster> Opportunity_RecurringAppointmentMasters
        {
            get { return this.GetRelatedEntities<RecurringAppointmentMaster>("Opportunity_RecurringAppointmentMasters", null); }
            set
            {
                this.OnPropertyChanging("Opportunity_RecurringAppointmentMasters");
                this.SetRelatedEntities<RecurringAppointmentMaster>("Opportunity_RecurringAppointmentMasters", null, value);
                this.OnPropertyChanged("Opportunity_RecurringAppointmentMasters");
            }
        }

        /// <summary>
        /// 1:N opportunity_sales_orders
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("opportunity_sales_orders")]
        public System.Collections.Generic.IEnumerable<SalesOrder> opportunity_sales_orders
        {
            get { return this.GetRelatedEntities<SalesOrder>("opportunity_sales_orders", null); }
            set
            {
                this.OnPropertyChanging("opportunity_sales_orders");
                this.SetRelatedEntities<SalesOrder>("opportunity_sales_orders", null, value);
                this.OnPropertyChanged("opportunity_sales_orders");
            }
        }

        /// <summary>
        /// 1:N Opportunity_ServiceAppointments
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Opportunity_ServiceAppointments")]
        public System.Collections.Generic.IEnumerable<ServiceAppointment> Opportunity_ServiceAppointments
        {
            get { return this.GetRelatedEntities<ServiceAppointment>("Opportunity_ServiceAppointments", null); }
            set
            {
                this.OnPropertyChanging("Opportunity_ServiceAppointments");
                this.SetRelatedEntities<ServiceAppointment>("Opportunity_ServiceAppointments", null, value);
                this.OnPropertyChanged("Opportunity_ServiceAppointments");
            }
        }

        /// <summary>
        /// 1:N Opportunity_SharepointDocument
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Opportunity_SharepointDocument")]
        public System.Collections.Generic.IEnumerable<SharePointDocument> Opportunity_SharepointDocument
        {
            get { return this.GetRelatedEntities<SharePointDocument>("Opportunity_SharepointDocument", null); }
            set
            {
                this.OnPropertyChanging("Opportunity_SharepointDocument");
                this.SetRelatedEntities<SharePointDocument>("Opportunity_SharepointDocument", null, value);
                this.OnPropertyChanged("Opportunity_SharepointDocument");
            }
        }

        /// <summary>
        /// 1:N Opportunity_SharepointDocumentLocation
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Opportunity_SharepointDocumentLocation")]
        public System.Collections.Generic.IEnumerable<SharePointDocumentLocation> Opportunity_SharepointDocumentLocation
        {
            get { return this.GetRelatedEntities<SharePointDocumentLocation>("Opportunity_SharepointDocumentLocation", null); }
            set
            {
                this.OnPropertyChanging("Opportunity_SharepointDocumentLocation");
                this.SetRelatedEntities<SharePointDocumentLocation>("Opportunity_SharepointDocumentLocation", null, value);
                this.OnPropertyChanged("Opportunity_SharepointDocumentLocation");
            }
        }

        /// <summary>
        /// 1:N Opportunity_SocialActivities
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Opportunity_SocialActivities")]
        public System.Collections.Generic.IEnumerable<SocialActivity> Opportunity_SocialActivities
        {
            get { return this.GetRelatedEntities<SocialActivity>("Opportunity_SocialActivities", null); }
            set
            {
                this.OnPropertyChanging("Opportunity_SocialActivities");
                this.SetRelatedEntities<SocialActivity>("Opportunity_SocialActivities", null, value);
                this.OnPropertyChanged("Opportunity_SocialActivities");
            }
        }

        /// <summary>
        /// 1:N Opportunity_Tasks
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Opportunity_Tasks")]
        public System.Collections.Generic.IEnumerable<Task> Opportunity_Tasks
        {
            get { return this.GetRelatedEntities<Task>("Opportunity_Tasks", null); }
            set
            {
                this.OnPropertyChanging("Opportunity_Tasks");
                this.SetRelatedEntities<Task>("Opportunity_Tasks", null, value);
                this.OnPropertyChanged("Opportunity_Tasks");
            }
        }

        /// <summary>
        /// 1:N opportunity_Teams
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("opportunity_Teams")]
        public System.Collections.Generic.IEnumerable<Team> opportunity_Teams
        {
            get { return this.GetRelatedEntities<Team>("opportunity_Teams", null); }
            set
            {
                this.OnPropertyChanging("opportunity_Teams");
                this.SetRelatedEntities<Team>("opportunity_Teams", null, value);
                this.OnPropertyChanged("opportunity_Teams");
            }
        }

        /// <summary>
        /// 1:N product_opportunities
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("product_opportunities")]
        public System.Collections.Generic.IEnumerable<OpportunityProduct> product_opportunities
        {
            get { return this.GetRelatedEntities<OpportunityProduct>("product_opportunities", null); }
            set
            {
                this.OnPropertyChanging("product_opportunities");
                this.SetRelatedEntities<OpportunityProduct>("product_opportunities", null, value);
                this.OnPropertyChanged("product_opportunities");
            }
        }

        /// <summary>
        /// 1:N userentityinstancedata_opportunity
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_opportunity")]
        public System.Collections.Generic.IEnumerable<UserEntityInstanceData> userentityinstancedata_opportunity
        {
            get { return this.GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_opportunity", null); }
            set
            {
                this.OnPropertyChanging("userentityinstancedata_opportunity");
                this.SetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_opportunity", null, value);
                this.OnPropertyChanged("userentityinstancedata_opportunity");
            }
        }

        /// <summary>
        /// N:N opportunitycompetitors_association
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("opportunitycompetitors_association")]
        public System.Collections.Generic.IEnumerable<Competitor> opportunitycompetitors_association
        {
            get { return this.GetRelatedEntities<Competitor>("opportunitycompetitors_association", null); }
            set
            {
                this.OnPropertyChanging("opportunitycompetitors_association");
                this.SetRelatedEntities<Competitor>("opportunitycompetitors_association", null, value);
                this.OnPropertyChanged("opportunitycompetitors_association");
            }
        }

        /// <summary>
        /// N:1 business_unit_opportunities
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_opportunities")]
        public BusinessUnit business_unit_opportunities
        {
            get { return this.GetRelatedEntity<BusinessUnit>("business_unit_opportunities", null); }
        }

        /// <summary>
        /// N:1 campaign_opportunities
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("campaignid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("campaign_opportunities")]
        public Campaign campaign_opportunities
        {
            get { return this.GetRelatedEntity<Campaign>("campaign_opportunities", null); }
            set
            {
                this.OnPropertyChanging("campaign_opportunities");
                this.SetRelatedEntity<Campaign>("campaign_opportunities", null, value);
                this.OnPropertyChanged("campaign_opportunities");
            }
        }

        /// <summary>
        /// N:1 lk_opportunity_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_opportunity_createdonbehalfby")]
        public SystemUser lk_opportunity_createdonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_opportunity_createdonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_opportunity_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_opportunity_modifiedonbehalfby")]
        public SystemUser lk_opportunity_modifiedonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_opportunity_modifiedonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_opportunitybase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_opportunitybase_createdby")]
        public SystemUser lk_opportunitybase_createdby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_opportunitybase_createdby", null); }
        }

        /// <summary>
        /// N:1 lk_opportunitybase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_opportunitybase_modifiedby")]
        public SystemUser lk_opportunitybase_modifiedby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_opportunitybase_modifiedby", null); }
        }

        /// <summary>
        /// N:1 opportunity_customer_accounts
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("customerid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("opportunity_customer_accounts")]
        public Account opportunity_customer_accounts
        {
            get { return this.GetRelatedEntity<Account>("opportunity_customer_accounts", null); }
            set
            {
                this.OnPropertyChanging("opportunity_customer_accounts");
                this.SetRelatedEntity<Account>("opportunity_customer_accounts", null, value);
                this.OnPropertyChanged("opportunity_customer_accounts");
            }
        }

        /// <summary>
        /// N:1 opportunity_customer_contacts
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("customerid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("opportunity_customer_contacts")]
        public Contact opportunity_customer_contacts
        {
            get { return this.GetRelatedEntity<Contact>("opportunity_customer_contacts", null); }
            set
            {
                this.OnPropertyChanging("opportunity_customer_contacts");
                this.SetRelatedEntity<Contact>("opportunity_customer_contacts", null, value);
                this.OnPropertyChanged("opportunity_customer_contacts");
            }
        }

        /// <summary>
        /// N:1 opportunity_originating_lead
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("originatingleadid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("opportunity_originating_lead")]
        public Lead opportunity_originating_lead
        {
            get { return this.GetRelatedEntity<Lead>("opportunity_originating_lead", null); }
            set
            {
                this.OnPropertyChanging("opportunity_originating_lead");
                this.SetRelatedEntity<Lead>("opportunity_originating_lead", null, value);
                this.OnPropertyChanged("opportunity_originating_lead");
            }
        }

        /// <summary>
        /// N:1 opportunity_owning_user
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("opportunity_owning_user")]
        public SystemUser opportunity_owning_user
        {
            get { return this.GetRelatedEntity<SystemUser>("opportunity_owning_user", null); }
        }

        /// <summary>
        /// N:1 opportunity_parent_account
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("parentaccountid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("opportunity_parent_account")]
        public Account opportunity_parent_account
        {
            get { return this.GetRelatedEntity<Account>("opportunity_parent_account", null); }
            set
            {
                this.OnPropertyChanging("opportunity_parent_account");
                this.SetRelatedEntity<Account>("opportunity_parent_account", null, value);
                this.OnPropertyChanged("opportunity_parent_account");
            }
        }

        /// <summary>
        /// N:1 opportunity_parent_contact
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("parentcontactid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("opportunity_parent_contact")]
        public Contact opportunity_parent_contact
        {
            get { return this.GetRelatedEntity<Contact>("opportunity_parent_contact", null); }
            set
            {
                this.OnPropertyChanging("opportunity_parent_contact");
                this.SetRelatedEntity<Contact>("opportunity_parent_contact", null, value);
                this.OnPropertyChanged("opportunity_parent_contact");
            }
        }

        /// <summary>
        /// N:1 price_level_opportunties
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("pricelevelid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("price_level_opportunties")]
        public PriceLevel price_level_opportunties
        {
            get { return this.GetRelatedEntity<PriceLevel>("price_level_opportunties", null); }
            set
            {
                this.OnPropertyChanging("price_level_opportunties");
                this.SetRelatedEntity<PriceLevel>("price_level_opportunties", null, value);
                this.OnPropertyChanged("price_level_opportunties");
            }
        }

        /// <summary>
        /// N:1 processstage_opportunity
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("stageid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("processstage_opportunity")]
        public ProcessStage processstage_opportunity
        {
            get { return this.GetRelatedEntity<ProcessStage>("processstage_opportunity", null); }
            set
            {
                this.OnPropertyChanging("processstage_opportunity");
                this.SetRelatedEntity<ProcessStage>("processstage_opportunity", null, value);
                this.OnPropertyChanged("processstage_opportunity");
            }
        }

        /// <summary>
        /// N:1 team_opportunities
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_opportunities")]
        public Team team_opportunities
        {
            get { return this.GetRelatedEntity<Team>("team_opportunities", null); }
        }

        /// <summary>
        /// N:1 transactioncurrency_opportunity
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("transactioncurrency_opportunity")]
        public TransactionCurrency transactioncurrency_opportunity
        {
            get { return this.GetRelatedEntity<TransactionCurrency>("transactioncurrency_opportunity", null); }
            set
            {
                this.OnPropertyChanging("transactioncurrency_opportunity");
                this.SetRelatedEntity<TransactionCurrency>("transactioncurrency_opportunity", null, value);
                this.OnPropertyChanged("transactioncurrency_opportunity");
            }
        }
    }
}