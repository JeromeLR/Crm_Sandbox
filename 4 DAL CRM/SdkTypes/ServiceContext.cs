using _4_DAL_CRM;

namespace __4_DAL_CRM
{
    /// <summary>
    /// Represents a source of entities bound to a CRM service. It tracks and manages changes made to the retrieved entities.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class ServiceContext : Microsoft.Xrm.Sdk.Client.OrganizationServiceContext
    {

        /// <summary>
        /// Constructor.
        /// </summary>
        public ServiceContext(Microsoft.Xrm.Sdk.IOrganizationService service) :
            base(service)
        {
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="Account"/> entities.
        /// </summary>
        public System.Linq.IQueryable<Account> AccountSet
        {
            get { return this.CreateQuery<Account>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="AccountLeads"/> entities.
        /// </summary>
        public System.Linq.IQueryable<AccountLeads> AccountLeadsSet
        {
            get { return this.CreateQuery<AccountLeads>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="ActivityMimeAttachment"/> entities.
        /// </summary>
        public System.Linq.IQueryable<ActivityMimeAttachment> ActivityMimeAttachmentSet
        {
            get { return this.CreateQuery<ActivityMimeAttachment>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="ActivityParty"/> entities.
        /// </summary>
        public System.Linq.IQueryable<ActivityParty> ActivityPartySet
        {
            get { return this.CreateQuery<ActivityParty>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="ActivityPointer"/> entities.
        /// </summary>
        public System.Linq.IQueryable<ActivityPointer> ActivityPointerSet
        {
            get { return this.CreateQuery<ActivityPointer>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="Annotation"/> entities.
        /// </summary>
        public System.Linq.IQueryable<Annotation> AnnotationSet
        {
            get { return this.CreateQuery<Annotation>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="AnnualFiscalCalendar"/> entities.
        /// </summary>
        public System.Linq.IQueryable<AnnualFiscalCalendar> AnnualFiscalCalendarSet
        {
            get { return this.CreateQuery<AnnualFiscalCalendar>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="Appointment"/> entities.
        /// </summary>
        public System.Linq.IQueryable<Appointment> AppointmentSet
        {
            get { return this.CreateQuery<Appointment>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="AsyncOperation"/> entities.
        /// </summary>
        public System.Linq.IQueryable<AsyncOperation> AsyncOperationSet
        {
            get { return this.CreateQuery<AsyncOperation>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="AttributeMap"/> entities.
        /// </summary>
        public System.Linq.IQueryable<AttributeMap> AttributeMapSet
        {
            get { return this.CreateQuery<AttributeMap>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="Audit"/> entities.
        /// </summary>
        public System.Linq.IQueryable<Audit> AuditSet
        {
            get { return this.CreateQuery<Audit>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="BulkDeleteFailure"/> entities.
        /// </summary>
        public System.Linq.IQueryable<BulkDeleteFailure> BulkDeleteFailureSet
        {
            get { return this.CreateQuery<BulkDeleteFailure>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="BulkDeleteOperation"/> entities.
        /// </summary>
        public System.Linq.IQueryable<BulkDeleteOperation> BulkDeleteOperationSet
        {
            get { return this.CreateQuery<BulkDeleteOperation>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="BulkOperation"/> entities.
        /// </summary>
        public System.Linq.IQueryable<BulkOperation> BulkOperationSet
        {
            get { return this.CreateQuery<BulkOperation>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="BulkOperationLog"/> entities.
        /// </summary>
        public System.Linq.IQueryable<BulkOperationLog> BulkOperationLogSet
        {
            get { return this.CreateQuery<BulkOperationLog>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="BusinessUnit"/> entities.
        /// </summary>
        public System.Linq.IQueryable<BusinessUnit> BusinessUnitSet
        {
            get { return this.CreateQuery<BusinessUnit>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="BusinessUnitNewsArticle"/> entities.
        /// </summary>
        public System.Linq.IQueryable<BusinessUnitNewsArticle> BusinessUnitNewsArticleSet
        {
            get { return this.CreateQuery<BusinessUnitNewsArticle>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="Calendar"/> entities.
        /// </summary>
        public System.Linq.IQueryable<Calendar> CalendarSet
        {
            get { return this.CreateQuery<Calendar>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="Campaign"/> entities.
        /// </summary>
        public System.Linq.IQueryable<Campaign> CampaignSet
        {
            get { return this.CreateQuery<Campaign>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="CampaignActivity"/> entities.
        /// </summary>
        public System.Linq.IQueryable<CampaignActivity> CampaignActivitySet
        {
            get { return this.CreateQuery<CampaignActivity>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="CampaignActivityItem"/> entities.
        /// </summary>
        public System.Linq.IQueryable<CampaignActivityItem> CampaignActivityItemSet
        {
            get { return this.CreateQuery<CampaignActivityItem>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="CampaignItem"/> entities.
        /// </summary>
        public System.Linq.IQueryable<CampaignItem> CampaignItemSet
        {
            get { return this.CreateQuery<CampaignItem>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="CampaignResponse"/> entities.
        /// </summary>
        public System.Linq.IQueryable<CampaignResponse> CampaignResponseSet
        {
            get { return this.CreateQuery<CampaignResponse>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="ColumnMapping"/> entities.
        /// </summary>
        public System.Linq.IQueryable<ColumnMapping> ColumnMappingSet
        {
            get { return this.CreateQuery<ColumnMapping>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="Competitor"/> entities.
        /// </summary>
        public System.Linq.IQueryable<Competitor> CompetitorSet
        {
            get { return this.CreateQuery<Competitor>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="CompetitorProduct"/> entities.
        /// </summary>
        public System.Linq.IQueryable<CompetitorProduct> CompetitorProductSet
        {
            get { return this.CreateQuery<CompetitorProduct>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="CompetitorSalesLiterature"/> entities.
        /// </summary>
        public System.Linq.IQueryable<CompetitorSalesLiterature> CompetitorSalesLiteratureSet
        {
            get { return this.CreateQuery<CompetitorSalesLiterature>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="Connection"/> entities.
        /// </summary>
        public System.Linq.IQueryable<Connection> ConnectionSet
        {
            get { return this.CreateQuery<Connection>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="ConnectionRole"/> entities.
        /// </summary>
        public System.Linq.IQueryable<ConnectionRole> ConnectionRoleSet
        {
            get { return this.CreateQuery<ConnectionRole>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="ConnectionRoleAssociation"/> entities.
        /// </summary>
        public System.Linq.IQueryable<ConnectionRoleAssociation> ConnectionRoleAssociationSet
        {
            get { return this.CreateQuery<ConnectionRoleAssociation>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="ConnectionRoleObjectTypeCode"/> entities.
        /// </summary>
        public System.Linq.IQueryable<ConnectionRoleObjectTypeCode> ConnectionRoleObjectTypeCodeSet
        {
            get { return this.CreateQuery<ConnectionRoleObjectTypeCode>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="ConstraintBasedGroup"/> entities.
        /// </summary>
        public System.Linq.IQueryable<ConstraintBasedGroup> ConstraintBasedGroupSet
        {
            get { return this.CreateQuery<ConstraintBasedGroup>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="Contact"/> entities.
        /// </summary>
        public System.Linq.IQueryable<Contact> ContactSet
        {
            get { return this.CreateQuery<Contact>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="ContactInvoices"/> entities.
        /// </summary>
        public System.Linq.IQueryable<ContactInvoices> ContactInvoicesSet
        {
            get { return this.CreateQuery<ContactInvoices>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="ContactLeads"/> entities.
        /// </summary>
        public System.Linq.IQueryable<ContactLeads> ContactLeadsSet
        {
            get { return this.CreateQuery<ContactLeads>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="ContactOrders"/> entities.
        /// </summary>
        public System.Linq.IQueryable<ContactOrders> ContactOrdersSet
        {
            get { return this.CreateQuery<ContactOrders>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="ContactQuotes"/> entities.
        /// </summary>
        public System.Linq.IQueryable<ContactQuotes> ContactQuotesSet
        {
            get { return this.CreateQuery<ContactQuotes>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="Contract"/> entities.
        /// </summary>
        public System.Linq.IQueryable<Contract> ContractSet
        {
            get { return this.CreateQuery<Contract>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="ContractDetail"/> entities.
        /// </summary>
        public System.Linq.IQueryable<ContractDetail> ContractDetailSet
        {
            get { return this.CreateQuery<ContractDetail>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="ContractTemplate"/> entities.
        /// </summary>
        public System.Linq.IQueryable<ContractTemplate> ContractTemplateSet
        {
            get { return this.CreateQuery<ContractTemplate>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="ConvertRule"/> entities.
        /// </summary>
        public System.Linq.IQueryable<ConvertRule> ConvertRuleSet
        {
            get { return this.CreateQuery<ConvertRule>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="ConvertRuleItem"/> entities.
        /// </summary>
        public System.Linq.IQueryable<ConvertRuleItem> ConvertRuleItemSet
        {
            get { return this.CreateQuery<ConvertRuleItem>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="CustomerAddress"/> entities.
        /// </summary>
        public System.Linq.IQueryable<CustomerAddress> CustomerAddressSet
        {
            get { return this.CreateQuery<CustomerAddress>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="CustomerOpportunityRole"/> entities.
        /// </summary>
        public System.Linq.IQueryable<CustomerOpportunityRole> CustomerOpportunityRoleSet
        {
            get { return this.CreateQuery<CustomerOpportunityRole>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="CustomerRelationship"/> entities.
        /// </summary>
        public System.Linq.IQueryable<CustomerRelationship> CustomerRelationshipSet
        {
            get { return this.CreateQuery<CustomerRelationship>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="Dependency"/> entities.
        /// </summary>
        public System.Linq.IQueryable<Dependency> DependencySet
        {
            get { return this.CreateQuery<Dependency>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="Discount"/> entities.
        /// </summary>
        public System.Linq.IQueryable<Discount> DiscountSet
        {
            get { return this.CreateQuery<Discount>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="DiscountType"/> entities.
        /// </summary>
        public System.Linq.IQueryable<DiscountType> DiscountTypeSet
        {
            get { return this.CreateQuery<DiscountType>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="DisplayString"/> entities.
        /// </summary>
        public System.Linq.IQueryable<DisplayString> DisplayStringSet
        {
            get { return this.CreateQuery<DisplayString>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="DuplicateRecord"/> entities.
        /// </summary>
        public System.Linq.IQueryable<DuplicateRecord> DuplicateRecordSet
        {
            get { return this.CreateQuery<DuplicateRecord>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="DuplicateRule"/> entities.
        /// </summary>
        public System.Linq.IQueryable<DuplicateRule> DuplicateRuleSet
        {
            get { return this.CreateQuery<DuplicateRule>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="DuplicateRuleCondition"/> entities.
        /// </summary>
        public System.Linq.IQueryable<DuplicateRuleCondition> DuplicateRuleConditionSet
        {
            get { return this.CreateQuery<DuplicateRuleCondition>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="DynamicProperty"/> entities.
        /// </summary>
        public System.Linq.IQueryable<DynamicProperty> DynamicPropertySet
        {
            get { return this.CreateQuery<DynamicProperty>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="DynamicPropertyAssociation"/> entities.
        /// </summary>
        public System.Linq.IQueryable<DynamicPropertyAssociation> DynamicPropertyAssociationSet
        {
            get { return this.CreateQuery<DynamicPropertyAssociation>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="DynamicPropertyInstance"/> entities.
        /// </summary>
        public System.Linq.IQueryable<DynamicPropertyInstance> DynamicPropertyInstanceSet
        {
            get { return this.CreateQuery<DynamicPropertyInstance>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="DynamicPropertyOptionSetItem"/> entities.
        /// </summary>
        public System.Linq.IQueryable<DynamicPropertyOptionSetItem> DynamicPropertyOptionSetItemSet
        {
            get { return this.CreateQuery<DynamicPropertyOptionSetItem>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="Email"/> entities.
        /// </summary>
        public System.Linq.IQueryable<Email> EmailSet
        {
            get { return this.CreateQuery<Email>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="EmailServerProfile"/> entities.
        /// </summary>
        public System.Linq.IQueryable<EmailServerProfile> EmailServerProfileSet
        {
            get { return this.CreateQuery<EmailServerProfile>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="Entitlement"/> entities.
        /// </summary>
        public System.Linq.IQueryable<Entitlement> EntitlementSet
        {
            get { return this.CreateQuery<Entitlement>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="EntitlementChannel"/> entities.
        /// </summary>
        public System.Linq.IQueryable<EntitlementChannel> EntitlementChannelSet
        {
            get { return this.CreateQuery<EntitlementChannel>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="EntitlementContacts"/> entities.
        /// </summary>
        public System.Linq.IQueryable<EntitlementContacts> EntitlementContactsSet
        {
            get { return this.CreateQuery<EntitlementContacts>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="EntitlementProducts"/> entities.
        /// </summary>
        public System.Linq.IQueryable<EntitlementProducts> EntitlementProductsSet
        {
            get { return this.CreateQuery<EntitlementProducts>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="EntitlementTemplate"/> entities.
        /// </summary>
        public System.Linq.IQueryable<EntitlementTemplate> EntitlementTemplateSet
        {
            get { return this.CreateQuery<EntitlementTemplate>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="EntitlementTemplateChannel"/> entities.
        /// </summary>
        public System.Linq.IQueryable<EntitlementTemplateChannel> EntitlementTemplateChannelSet
        {
            get { return this.CreateQuery<EntitlementTemplateChannel>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="EntitlementTemplateProducts"/> entities.
        /// </summary>
        public System.Linq.IQueryable<EntitlementTemplateProducts> EntitlementTemplateProductsSet
        {
            get { return this.CreateQuery<EntitlementTemplateProducts>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="EntityMap"/> entities.
        /// </summary>
        public System.Linq.IQueryable<EntityMap> EntityMapSet
        {
            get { return this.CreateQuery<EntityMap>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="Equipment"/> entities.
        /// </summary>
        public System.Linq.IQueryable<Equipment> EquipmentSet
        {
            get { return this.CreateQuery<Equipment>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="ExchangeSyncIdMapping"/> entities.
        /// </summary>
        public System.Linq.IQueryable<ExchangeSyncIdMapping> ExchangeSyncIdMappingSet
        {
            get { return this.CreateQuery<ExchangeSyncIdMapping>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="Fax"/> entities.
        /// </summary>
        public System.Linq.IQueryable<Fax> FaxSet
        {
            get { return this.CreateQuery<Fax>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="FieldPermission"/> entities.
        /// </summary>
        public System.Linq.IQueryable<FieldPermission> FieldPermissionSet
        {
            get { return this.CreateQuery<FieldPermission>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="FieldSecurityProfile"/> entities.
        /// </summary>
        public System.Linq.IQueryable<FieldSecurityProfile> FieldSecurityProfileSet
        {
            get { return this.CreateQuery<FieldSecurityProfile>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="FixedMonthlyFiscalCalendar"/> entities.
        /// </summary>
        public System.Linq.IQueryable<FixedMonthlyFiscalCalendar> FixedMonthlyFiscalCalendarSet
        {
            get { return this.CreateQuery<FixedMonthlyFiscalCalendar>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="Goal"/> entities.
        /// </summary>
        public System.Linq.IQueryable<Goal> GoalSet
        {
            get { return this.CreateQuery<Goal>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="GoalRollupQuery"/> entities.
        /// </summary>
        public System.Linq.IQueryable<GoalRollupQuery> GoalRollupQuerySet
        {
            get { return this.CreateQuery<GoalRollupQuery>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="HierarchyRule"/> entities.
        /// </summary>
        public System.Linq.IQueryable<HierarchyRule> HierarchyRuleSet
        {
            get { return this.CreateQuery<HierarchyRule>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="HierarchySecurityConfiguration"/> entities.
        /// </summary>
        public System.Linq.IQueryable<HierarchySecurityConfiguration> HierarchySecurityConfigurationSet
        {
            get { return this.CreateQuery<HierarchySecurityConfiguration>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="Import"/> entities.
        /// </summary>
        public System.Linq.IQueryable<Import> ImportSet
        {
            get { return this.CreateQuery<Import>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="ImportEntityMapping"/> entities.
        /// </summary>
        public System.Linq.IQueryable<ImportEntityMapping> ImportEntityMappingSet
        {
            get { return this.CreateQuery<ImportEntityMapping>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="ImportFile"/> entities.
        /// </summary>
        public System.Linq.IQueryable<ImportFile> ImportFileSet
        {
            get { return this.CreateQuery<ImportFile>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="ImportJob"/> entities.
        /// </summary>
        public System.Linq.IQueryable<ImportJob> ImportJobSet
        {
            get { return this.CreateQuery<ImportJob>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="ImportLog"/> entities.
        /// </summary>
        public System.Linq.IQueryable<ImportLog> ImportLogSet
        {
            get { return this.CreateQuery<ImportLog>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="ImportMap"/> entities.
        /// </summary>
        public System.Linq.IQueryable<ImportMap> ImportMapSet
        {
            get { return this.CreateQuery<ImportMap>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="Incident"/> entities.
        /// </summary>
        public System.Linq.IQueryable<Incident> IncidentSet
        {
            get { return this.CreateQuery<Incident>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="IncidentResolution"/> entities.
        /// </summary>
        public System.Linq.IQueryable<IncidentResolution> IncidentResolutionSet
        {
            get { return this.CreateQuery<IncidentResolution>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="InvalidDependency"/> entities.
        /// </summary>
        public System.Linq.IQueryable<InvalidDependency> InvalidDependencySet
        {
            get { return this.CreateQuery<InvalidDependency>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="Invoice"/> entities.
        /// </summary>
        public System.Linq.IQueryable<Invoice> InvoiceSet
        {
            get { return this.CreateQuery<Invoice>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="InvoiceDetail"/> entities.
        /// </summary>
        public System.Linq.IQueryable<InvoiceDetail> InvoiceDetailSet
        {
            get { return this.CreateQuery<InvoiceDetail>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="IsvConfig"/> entities.
        /// </summary>
        public System.Linq.IQueryable<IsvConfig> IsvConfigSet
        {
            get { return this.CreateQuery<IsvConfig>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="KbArticle"/> entities.
        /// </summary>
        public System.Linq.IQueryable<KbArticle> KbArticleSet
        {
            get { return this.CreateQuery<KbArticle>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="KbArticleComment"/> entities.
        /// </summary>
        public System.Linq.IQueryable<KbArticleComment> KbArticleCommentSet
        {
            get { return this.CreateQuery<KbArticleComment>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="KbArticleTemplate"/> entities.
        /// </summary>
        public System.Linq.IQueryable<KbArticleTemplate> KbArticleTemplateSet
        {
            get { return this.CreateQuery<KbArticleTemplate>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="Lead"/> entities.
        /// </summary>
        public System.Linq.IQueryable<Lead> LeadSet
        {
            get { return this.CreateQuery<Lead>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="LeadAddress"/> entities.
        /// </summary>
        public System.Linq.IQueryable<LeadAddress> LeadAddressSet
        {
            get { return this.CreateQuery<LeadAddress>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="LeadCompetitors"/> entities.
        /// </summary>
        public System.Linq.IQueryable<LeadCompetitors> LeadCompetitorsSet
        {
            get { return this.CreateQuery<LeadCompetitors>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="LeadProduct"/> entities.
        /// </summary>
        public System.Linq.IQueryable<LeadProduct> LeadProductSet
        {
            get { return this.CreateQuery<LeadProduct>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="Letter"/> entities.
        /// </summary>
        public System.Linq.IQueryable<Letter> LetterSet
        {
            get { return this.CreateQuery<Letter>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="License"/> entities.
        /// </summary>
        public System.Linq.IQueryable<License> LicenseSet
        {
            get { return this.CreateQuery<License>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="List"/> entities.
        /// </summary>
        public System.Linq.IQueryable<List> ListSet
        {
            get { return this.CreateQuery<List>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="ListMember"/> entities.
        /// </summary>
        public System.Linq.IQueryable<ListMember> ListMemberSet
        {
            get { return this.CreateQuery<ListMember>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="LookUpMapping"/> entities.
        /// </summary>
        public System.Linq.IQueryable<LookUpMapping> LookUpMappingSet
        {
            get { return this.CreateQuery<LookUpMapping>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="Mailbox"/> entities.
        /// </summary>
        public System.Linq.IQueryable<Mailbox> MailboxSet
        {
            get { return this.CreateQuery<Mailbox>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="MailMergeTemplate"/> entities.
        /// </summary>
        public System.Linq.IQueryable<MailMergeTemplate> MailMergeTemplateSet
        {
            get { return this.CreateQuery<MailMergeTemplate>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="Metric"/> entities.
        /// </summary>
        public System.Linq.IQueryable<Metric> MetricSet
        {
            get { return this.CreateQuery<Metric>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="MonthlyFiscalCalendar"/> entities.
        /// </summary>
        public System.Linq.IQueryable<MonthlyFiscalCalendar> MonthlyFiscalCalendarSet
        {
            get { return this.CreateQuery<MonthlyFiscalCalendar>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="msdyn_PostAlbum"/> entities.
        /// </summary>
        public System.Linq.IQueryable<msdyn_PostAlbum> msdyn_PostAlbumSet
        {
            get { return this.CreateQuery<msdyn_PostAlbum>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="msdyn_PostConfig"/> entities.
        /// </summary>
        public System.Linq.IQueryable<msdyn_PostConfig> msdyn_PostConfigSet
        {
            get { return this.CreateQuery<msdyn_PostConfig>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="msdyn_PostRuleConfig"/> entities.
        /// </summary>
        public System.Linq.IQueryable<msdyn_PostRuleConfig> msdyn_PostRuleConfigSet
        {
            get { return this.CreateQuery<msdyn_PostRuleConfig>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="msdyn_wallsavedquery"/> entities.
        /// </summary>
        public System.Linq.IQueryable<msdyn_wallsavedquery> msdyn_wallsavedquerySet
        {
            get { return this.CreateQuery<msdyn_wallsavedquery>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="msdyn_wallsavedqueryusersettings"/> entities.
        /// </summary>
        public System.Linq.IQueryable<msdyn_wallsavedqueryusersettings> msdyn_wallsavedqueryusersettingsSet
        {
            get { return this.CreateQuery<msdyn_wallsavedqueryusersettings>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="Opportunity"/> entities.
        /// </summary>
        public System.Linq.IQueryable<Opportunity> OpportunitySet
        {
            get { return this.CreateQuery<Opportunity>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="OpportunityClose"/> entities.
        /// </summary>
        public System.Linq.IQueryable<OpportunityClose> OpportunityCloseSet
        {
            get { return this.CreateQuery<OpportunityClose>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="OpportunityCompetitors"/> entities.
        /// </summary>
        public System.Linq.IQueryable<OpportunityCompetitors> OpportunityCompetitorsSet
        {
            get { return this.CreateQuery<OpportunityCompetitors>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="OpportunityProduct"/> entities.
        /// </summary>
        public System.Linq.IQueryable<OpportunityProduct> OpportunityProductSet
        {
            get { return this.CreateQuery<OpportunityProduct>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="OrderClose"/> entities.
        /// </summary>
        public System.Linq.IQueryable<OrderClose> OrderCloseSet
        {
            get { return this.CreateQuery<OrderClose>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="Organization"/> entities.
        /// </summary>
        public System.Linq.IQueryable<Organization> OrganizationSet
        {
            get { return this.CreateQuery<Organization>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="OrganizationUI"/> entities.
        /// </summary>
        public System.Linq.IQueryable<OrganizationUI> OrganizationUISet
        {
            get { return this.CreateQuery<OrganizationUI>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="OwnerMapping"/> entities.
        /// </summary>
        public System.Linq.IQueryable<OwnerMapping> OwnerMappingSet
        {
            get { return this.CreateQuery<OwnerMapping>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="PhoneCall"/> entities.
        /// </summary>
        public System.Linq.IQueryable<PhoneCall> PhoneCallSet
        {
            get { return this.CreateQuery<PhoneCall>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="PickListMapping"/> entities.
        /// </summary>
        public System.Linq.IQueryable<PickListMapping> PickListMappingSet
        {
            get { return this.CreateQuery<PickListMapping>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="PluginAssembly"/> entities.
        /// </summary>
        public System.Linq.IQueryable<PluginAssembly> PluginAssemblySet
        {
            get { return this.CreateQuery<PluginAssembly>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="PluginType"/> entities.
        /// </summary>
        public System.Linq.IQueryable<PluginType> PluginTypeSet
        {
            get { return this.CreateQuery<PluginType>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="PluginTypeStatistic"/> entities.
        /// </summary>
        public System.Linq.IQueryable<PluginTypeStatistic> PluginTypeStatisticSet
        {
            get { return this.CreateQuery<PluginTypeStatistic>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="Position"/> entities.
        /// </summary>
        public System.Linq.IQueryable<Position> PositionSet
        {
            get { return this.CreateQuery<Position>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="Post"/> entities.
        /// </summary>
        public System.Linq.IQueryable<Post> PostSet
        {
            get { return this.CreateQuery<Post>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="PostComment"/> entities.
        /// </summary>
        public System.Linq.IQueryable<PostComment> PostCommentSet
        {
            get { return this.CreateQuery<PostComment>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="PostFollow"/> entities.
        /// </summary>
        public System.Linq.IQueryable<PostFollow> PostFollowSet
        {
            get { return this.CreateQuery<PostFollow>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="PostLike"/> entities.
        /// </summary>
        public System.Linq.IQueryable<PostLike> PostLikeSet
        {
            get { return this.CreateQuery<PostLike>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="PriceLevel"/> entities.
        /// </summary>
        public System.Linq.IQueryable<PriceLevel> PriceLevelSet
        {
            get { return this.CreateQuery<PriceLevel>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="PrincipalEntityMap"/> entities.
        /// </summary>
        public System.Linq.IQueryable<PrincipalEntityMap> PrincipalEntityMapSet
        {
            get { return this.CreateQuery<PrincipalEntityMap>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="PrincipalObjectAttributeAccess"/> entities.
        /// </summary>
        public System.Linq.IQueryable<PrincipalObjectAttributeAccess> PrincipalObjectAttributeAccessSet
        {
            get { return this.CreateQuery<PrincipalObjectAttributeAccess>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="Privilege"/> entities.
        /// </summary>
        public System.Linq.IQueryable<Privilege> PrivilegeSet
        {
            get { return this.CreateQuery<Privilege>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="ProcessSession"/> entities.
        /// </summary>
        public System.Linq.IQueryable<ProcessSession> ProcessSessionSet
        {
            get { return this.CreateQuery<ProcessSession>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="ProcessStage"/> entities.
        /// </summary>
        public System.Linq.IQueryable<ProcessStage> ProcessStageSet
        {
            get { return this.CreateQuery<ProcessStage>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="ProcessTrigger"/> entities.
        /// </summary>
        public System.Linq.IQueryable<ProcessTrigger> ProcessTriggerSet
        {
            get { return this.CreateQuery<ProcessTrigger>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="Product"/> entities.
        /// </summary>
        public System.Linq.IQueryable<Product> ProductSet
        {
            get { return this.CreateQuery<Product>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="ProductAssociation"/> entities.
        /// </summary>
        public System.Linq.IQueryable<ProductAssociation> ProductAssociationSet
        {
            get { return this.CreateQuery<ProductAssociation>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="ProductPriceLevel"/> entities.
        /// </summary>
        public System.Linq.IQueryable<ProductPriceLevel> ProductPriceLevelSet
        {
            get { return this.CreateQuery<ProductPriceLevel>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="ProductSalesLiterature"/> entities.
        /// </summary>
        public System.Linq.IQueryable<ProductSalesLiterature> ProductSalesLiteratureSet
        {
            get { return this.CreateQuery<ProductSalesLiterature>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="ProductSubstitute"/> entities.
        /// </summary>
        public System.Linq.IQueryable<ProductSubstitute> ProductSubstituteSet
        {
            get { return this.CreateQuery<ProductSubstitute>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="Publisher"/> entities.
        /// </summary>
        public System.Linq.IQueryable<Publisher> PublisherSet
        {
            get { return this.CreateQuery<Publisher>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="PublisherAddress"/> entities.
        /// </summary>
        public System.Linq.IQueryable<PublisherAddress> PublisherAddressSet
        {
            get { return this.CreateQuery<PublisherAddress>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="QuarterlyFiscalCalendar"/> entities.
        /// </summary>
        public System.Linq.IQueryable<QuarterlyFiscalCalendar> QuarterlyFiscalCalendarSet
        {
            get { return this.CreateQuery<QuarterlyFiscalCalendar>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="Queue"/> entities.
        /// </summary>
        public System.Linq.IQueryable<Queue> QueueSet
        {
            get { return this.CreateQuery<Queue>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="QueueItem"/> entities.
        /// </summary>
        public System.Linq.IQueryable<QueueItem> QueueItemSet
        {
            get { return this.CreateQuery<QueueItem>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="QueueMembership"/> entities.
        /// </summary>
        public System.Linq.IQueryable<QueueMembership> QueueMembershipSet
        {
            get { return this.CreateQuery<QueueMembership>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="Quote"/> entities.
        /// </summary>
        public System.Linq.IQueryable<Quote> QuoteSet
        {
            get { return this.CreateQuery<Quote>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="QuoteClose"/> entities.
        /// </summary>
        public System.Linq.IQueryable<QuoteClose> QuoteCloseSet
        {
            get { return this.CreateQuery<QuoteClose>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="QuoteDetail"/> entities.
        /// </summary>
        public System.Linq.IQueryable<QuoteDetail> QuoteDetailSet
        {
            get { return this.CreateQuery<QuoteDetail>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="RecurrenceRule"/> entities.
        /// </summary>
        public System.Linq.IQueryable<RecurrenceRule> RecurrenceRuleSet
        {
            get { return this.CreateQuery<RecurrenceRule>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="RecurringAppointmentMaster"/> entities.
        /// </summary>
        public System.Linq.IQueryable<RecurringAppointmentMaster> RecurringAppointmentMasterSet
        {
            get { return this.CreateQuery<RecurringAppointmentMaster>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="RelationshipRole"/> entities.
        /// </summary>
        public System.Linq.IQueryable<RelationshipRole> RelationshipRoleSet
        {
            get { return this.CreateQuery<RelationshipRole>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="RelationshipRoleMap"/> entities.
        /// </summary>
        public System.Linq.IQueryable<RelationshipRoleMap> RelationshipRoleMapSet
        {
            get { return this.CreateQuery<RelationshipRoleMap>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="Report"/> entities.
        /// </summary>
        public System.Linq.IQueryable<Report> ReportSet
        {
            get { return this.CreateQuery<Report>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="ReportCategory"/> entities.
        /// </summary>
        public System.Linq.IQueryable<ReportCategory> ReportCategorySet
        {
            get { return this.CreateQuery<ReportCategory>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="ReportEntity"/> entities.
        /// </summary>
        public System.Linq.IQueryable<ReportEntity> ReportEntitySet
        {
            get { return this.CreateQuery<ReportEntity>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="ReportLink"/> entities.
        /// </summary>
        public System.Linq.IQueryable<ReportLink> ReportLinkSet
        {
            get { return this.CreateQuery<ReportLink>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="ReportVisibility"/> entities.
        /// </summary>
        public System.Linq.IQueryable<ReportVisibility> ReportVisibilitySet
        {
            get { return this.CreateQuery<ReportVisibility>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="Resource"/> entities.
        /// </summary>
        public System.Linq.IQueryable<Resource> ResourceSet
        {
            get { return this.CreateQuery<Resource>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="ResourceGroup"/> entities.
        /// </summary>
        public System.Linq.IQueryable<ResourceGroup> ResourceGroupSet
        {
            get { return this.CreateQuery<ResourceGroup>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="ResourceSpec"/> entities.
        /// </summary>
        public System.Linq.IQueryable<ResourceSpec> ResourceSpecSet
        {
            get { return this.CreateQuery<ResourceSpec>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="RibbonCustomization"/> entities.
        /// </summary>
        public System.Linq.IQueryable<RibbonCustomization> RibbonCustomizationSet
        {
            get { return this.CreateQuery<RibbonCustomization>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="Role"/> entities.
        /// </summary>
        public System.Linq.IQueryable<Role> RoleSet
        {
            get { return this.CreateQuery<Role>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="RolePrivileges"/> entities.
        /// </summary>
        public System.Linq.IQueryable<RolePrivileges> RolePrivilegesSet
        {
            get { return this.CreateQuery<RolePrivileges>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="RoleTemplatePrivileges"/> entities.
        /// </summary>
        public System.Linq.IQueryable<RoleTemplatePrivileges> RoleTemplatePrivilegesSet
        {
            get { return this.CreateQuery<RoleTemplatePrivileges>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="RollupField"/> entities.
        /// </summary>
        public System.Linq.IQueryable<RollupField> RollupFieldSet
        {
            get { return this.CreateQuery<RollupField>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="RoutingRule"/> entities.
        /// </summary>
        public System.Linq.IQueryable<RoutingRule> RoutingRuleSet
        {
            get { return this.CreateQuery<RoutingRule>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="RoutingRuleItem"/> entities.
        /// </summary>
        public System.Linq.IQueryable<RoutingRuleItem> RoutingRuleItemSet
        {
            get { return this.CreateQuery<RoutingRuleItem>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="SalesLiterature"/> entities.
        /// </summary>
        public System.Linq.IQueryable<SalesLiterature> SalesLiteratureSet
        {
            get { return this.CreateQuery<SalesLiterature>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="SalesLiteratureItem"/> entities.
        /// </summary>
        public System.Linq.IQueryable<SalesLiteratureItem> SalesLiteratureItemSet
        {
            get { return this.CreateQuery<SalesLiteratureItem>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="SalesOrder"/> entities.
        /// </summary>
        public System.Linq.IQueryable<SalesOrder> SalesOrderSet
        {
            get { return this.CreateQuery<SalesOrder>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="SalesOrderDetail"/> entities.
        /// </summary>
        public System.Linq.IQueryable<SalesOrderDetail> SalesOrderDetailSet
        {
            get { return this.CreateQuery<SalesOrderDetail>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="SavedQuery"/> entities.
        /// </summary>
        public System.Linq.IQueryable<SavedQuery> SavedQuerySet
        {
            get { return this.CreateQuery<SavedQuery>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="SavedQueryVisualization"/> entities.
        /// </summary>
        public System.Linq.IQueryable<SavedQueryVisualization> SavedQueryVisualizationSet
        {
            get { return this.CreateQuery<SavedQueryVisualization>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="SdkMessage"/> entities.
        /// </summary>
        public System.Linq.IQueryable<SdkMessage> SdkMessageSet
        {
            get { return this.CreateQuery<SdkMessage>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="SdkMessageFilter"/> entities.
        /// </summary>
        public System.Linq.IQueryable<SdkMessageFilter> SdkMessageFilterSet
        {
            get { return this.CreateQuery<SdkMessageFilter>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="SdkMessagePair"/> entities.
        /// </summary>
        public System.Linq.IQueryable<SdkMessagePair> SdkMessagePairSet
        {
            get { return this.CreateQuery<SdkMessagePair>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="SdkMessageProcessingStep"/> entities.
        /// </summary>
        public System.Linq.IQueryable<SdkMessageProcessingStep> SdkMessageProcessingStepSet
        {
            get { return this.CreateQuery<SdkMessageProcessingStep>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="SdkMessageProcessingStepImage"/> entities.
        /// </summary>
        public System.Linq.IQueryable<SdkMessageProcessingStepImage> SdkMessageProcessingStepImageSet
        {
            get { return this.CreateQuery<SdkMessageProcessingStepImage>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="SdkMessageProcessingStepSecureConfig"/> entities.
        /// </summary>
        public System.Linq.IQueryable<SdkMessageProcessingStepSecureConfig> SdkMessageProcessingStepSecureConfigSet
        {
            get { return this.CreateQuery<SdkMessageProcessingStepSecureConfig>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="SdkMessageRequest"/> entities.
        /// </summary>
        public System.Linq.IQueryable<SdkMessageRequest> SdkMessageRequestSet
        {
            get { return this.CreateQuery<SdkMessageRequest>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="SdkMessageRequestField"/> entities.
        /// </summary>
        public System.Linq.IQueryable<SdkMessageRequestField> SdkMessageRequestFieldSet
        {
            get { return this.CreateQuery<SdkMessageRequestField>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="SdkMessageResponse"/> entities.
        /// </summary>
        public System.Linq.IQueryable<SdkMessageResponse> SdkMessageResponseSet
        {
            get { return this.CreateQuery<SdkMessageResponse>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="SdkMessageResponseField"/> entities.
        /// </summary>
        public System.Linq.IQueryable<SdkMessageResponseField> SdkMessageResponseFieldSet
        {
            get { return this.CreateQuery<SdkMessageResponseField>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="SemiAnnualFiscalCalendar"/> entities.
        /// </summary>
        public System.Linq.IQueryable<SemiAnnualFiscalCalendar> SemiAnnualFiscalCalendarSet
        {
            get { return this.CreateQuery<SemiAnnualFiscalCalendar>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="Service"/> entities.
        /// </summary>
        public System.Linq.IQueryable<Service> ServiceSet
        {
            get { return this.CreateQuery<Service>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="ServiceAppointment"/> entities.
        /// </summary>
        public System.Linq.IQueryable<ServiceAppointment> ServiceAppointmentSet
        {
            get { return this.CreateQuery<ServiceAppointment>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="ServiceContractContacts"/> entities.
        /// </summary>
        public System.Linq.IQueryable<ServiceContractContacts> ServiceContractContactsSet
        {
            get { return this.CreateQuery<ServiceContractContacts>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="ServiceEndpoint"/> entities.
        /// </summary>
        public System.Linq.IQueryable<ServiceEndpoint> ServiceEndpointSet
        {
            get { return this.CreateQuery<ServiceEndpoint>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="SharePointData"/> entities.
        /// </summary>
        public System.Linq.IQueryable<SharePointData> SharePointDataSet
        {
            get { return this.CreateQuery<SharePointData>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="SharePointDocument"/> entities.
        /// </summary>
        public System.Linq.IQueryable<SharePointDocument> SharePointDocumentSet
        {
            get { return this.CreateQuery<SharePointDocument>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="SharePointDocumentLocation"/> entities.
        /// </summary>
        public System.Linq.IQueryable<SharePointDocumentLocation> SharePointDocumentLocationSet
        {
            get { return this.CreateQuery<SharePointDocumentLocation>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="SharePointSite"/> entities.
        /// </summary>
        public System.Linq.IQueryable<SharePointSite> SharePointSiteSet
        {
            get { return this.CreateQuery<SharePointSite>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="Site"/> entities.
        /// </summary>
        public System.Linq.IQueryable<Site> SiteSet
        {
            get { return this.CreateQuery<Site>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="SiteMap"/> entities.
        /// </summary>
        public System.Linq.IQueryable<SiteMap> SiteMapSet
        {
            get { return this.CreateQuery<SiteMap>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="SLA"/> entities.
        /// </summary>
        public System.Linq.IQueryable<SLA> SLASet
        {
            get { return this.CreateQuery<SLA>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="SLAItem"/> entities.
        /// </summary>
        public System.Linq.IQueryable<SLAItem> SLAItemSet
        {
            get { return this.CreateQuery<SLAItem>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="SLAKPIInstance"/> entities.
        /// </summary>
        public System.Linq.IQueryable<SLAKPIInstance> SLAKPIInstanceSet
        {
            get { return this.CreateQuery<SLAKPIInstance>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="SocialActivity"/> entities.
        /// </summary>
        public System.Linq.IQueryable<SocialActivity> SocialActivitySet
        {
            get { return this.CreateQuery<SocialActivity>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="SocialInsightsConfiguration"/> entities.
        /// </summary>
        public System.Linq.IQueryable<SocialInsightsConfiguration> SocialInsightsConfigurationSet
        {
            get { return this.CreateQuery<SocialInsightsConfiguration>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="SocialProfile"/> entities.
        /// </summary>
        public System.Linq.IQueryable<SocialProfile> SocialProfileSet
        {
            get { return this.CreateQuery<SocialProfile>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="Solution"/> entities.
        /// </summary>
        public System.Linq.IQueryable<Solution> SolutionSet
        {
            get { return this.CreateQuery<Solution>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="SolutionComponent"/> entities.
        /// </summary>
        public System.Linq.IQueryable<SolutionComponent> SolutionComponentSet
        {
            get { return this.CreateQuery<SolutionComponent>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="Subject"/> entities.
        /// </summary>
        public System.Linq.IQueryable<Subject> SubjectSet
        {
            get { return this.CreateQuery<Subject>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="SubscriptionManuallyTrackedObject"/> entities.
        /// </summary>
        public System.Linq.IQueryable<SubscriptionManuallyTrackedObject> SubscriptionManuallyTrackedObjectSet
        {
            get { return this.CreateQuery<SubscriptionManuallyTrackedObject>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="SubscriptionTrackingDeletedObject"/> entities.
        /// </summary>
        public System.Linq.IQueryable<SubscriptionTrackingDeletedObject> SubscriptionTrackingDeletedObjectSet
        {
            get { return this.CreateQuery<SubscriptionTrackingDeletedObject>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="SystemForm"/> entities.
        /// </summary>
        public System.Linq.IQueryable<SystemForm> SystemFormSet
        {
            get { return this.CreateQuery<SystemForm>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="SystemUser"/> entities.
        /// </summary>
        public System.Linq.IQueryable<SystemUser> SystemUserSet
        {
            get { return this.CreateQuery<SystemUser>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="SystemUserLicenses"/> entities.
        /// </summary>
        public System.Linq.IQueryable<SystemUserLicenses> SystemUserLicensesSet
        {
            get { return this.CreateQuery<SystemUserLicenses>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="SystemUserProfiles"/> entities.
        /// </summary>
        public System.Linq.IQueryable<SystemUserProfiles> SystemUserProfilesSet
        {
            get { return this.CreateQuery<SystemUserProfiles>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="SystemUserRoles"/> entities.
        /// </summary>
        public System.Linq.IQueryable<SystemUserRoles> SystemUserRolesSet
        {
            get { return this.CreateQuery<SystemUserRoles>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="SystemUserSyncMappingProfiles"/> entities.
        /// </summary>
        public System.Linq.IQueryable<SystemUserSyncMappingProfiles> SystemUserSyncMappingProfilesSet
        {
            get { return this.CreateQuery<SystemUserSyncMappingProfiles>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="Task"/> entities.
        /// </summary>
        public System.Linq.IQueryable<Task> TaskSet
        {
            get { return this.CreateQuery<Task>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="Team"/> entities.
        /// </summary>
        public System.Linq.IQueryable<Team> TeamSet
        {
            get { return this.CreateQuery<Team>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="TeamMembership"/> entities.
        /// </summary>
        public System.Linq.IQueryable<TeamMembership> TeamMembershipSet
        {
            get { return this.CreateQuery<TeamMembership>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="TeamProfiles"/> entities.
        /// </summary>
        public System.Linq.IQueryable<TeamProfiles> TeamProfilesSet
        {
            get { return this.CreateQuery<TeamProfiles>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="TeamRoles"/> entities.
        /// </summary>
        public System.Linq.IQueryable<TeamRoles> TeamRolesSet
        {
            get { return this.CreateQuery<TeamRoles>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="TeamSyncAttributeMappingProfiles"/> entities.
        /// </summary>
        public System.Linq.IQueryable<TeamSyncAttributeMappingProfiles> TeamSyncAttributeMappingProfilesSet
        {
            get { return this.CreateQuery<TeamSyncAttributeMappingProfiles>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="TeamTemplate"/> entities.
        /// </summary>
        public System.Linq.IQueryable<TeamTemplate> TeamTemplateSet
        {
            get { return this.CreateQuery<TeamTemplate>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="Template"/> entities.
        /// </summary>
        public System.Linq.IQueryable<Template> TemplateSet
        {
            get { return this.CreateQuery<Template>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="Territory"/> entities.
        /// </summary>
        public System.Linq.IQueryable<Territory> TerritorySet
        {
            get { return this.CreateQuery<Territory>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="TimeZoneDefinition"/> entities.
        /// </summary>
        public System.Linq.IQueryable<TimeZoneDefinition> TimeZoneDefinitionSet
        {
            get { return this.CreateQuery<TimeZoneDefinition>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="TimeZoneLocalizedName"/> entities.
        /// </summary>
        public System.Linq.IQueryable<TimeZoneLocalizedName> TimeZoneLocalizedNameSet
        {
            get { return this.CreateQuery<TimeZoneLocalizedName>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="TimeZoneRule"/> entities.
        /// </summary>
        public System.Linq.IQueryable<TimeZoneRule> TimeZoneRuleSet
        {
            get { return this.CreateQuery<TimeZoneRule>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="TraceLog"/> entities.
        /// </summary>
        public System.Linq.IQueryable<TraceLog> TraceLogSet
        {
            get { return this.CreateQuery<TraceLog>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="TransactionCurrency"/> entities.
        /// </summary>
        public System.Linq.IQueryable<TransactionCurrency> TransactionCurrencySet
        {
            get { return this.CreateQuery<TransactionCurrency>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="TransformationMapping"/> entities.
        /// </summary>
        public System.Linq.IQueryable<TransformationMapping> TransformationMappingSet
        {
            get { return this.CreateQuery<TransformationMapping>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="TransformationParameterMapping"/> entities.
        /// </summary>
        public System.Linq.IQueryable<TransformationParameterMapping> TransformationParameterMappingSet
        {
            get { return this.CreateQuery<TransformationParameterMapping>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="UoM"/> entities.
        /// </summary>
        public System.Linq.IQueryable<UoM> UoMSet
        {
            get { return this.CreateQuery<UoM>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="UoMSchedule"/> entities.
        /// </summary>
        public System.Linq.IQueryable<UoMSchedule> UoMScheduleSet
        {
            get { return this.CreateQuery<UoMSchedule>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="UserEntityInstanceData"/> entities.
        /// </summary>
        public System.Linq.IQueryable<UserEntityInstanceData> UserEntityInstanceDataSet
        {
            get { return this.CreateQuery<UserEntityInstanceData>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="UserEntityUISettings"/> entities.
        /// </summary>
        public System.Linq.IQueryable<UserEntityUISettings> UserEntityUISettingsSet
        {
            get { return this.CreateQuery<UserEntityUISettings>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="UserForm"/> entities.
        /// </summary>
        public System.Linq.IQueryable<UserForm> UserFormSet
        {
            get { return this.CreateQuery<UserForm>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="UserQuery"/> entities.
        /// </summary>
        public System.Linq.IQueryable<UserQuery> UserQuerySet
        {
            get { return this.CreateQuery<UserQuery>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="UserQueryVisualization"/> entities.
        /// </summary>
        public System.Linq.IQueryable<UserQueryVisualization> UserQueryVisualizationSet
        {
            get { return this.CreateQuery<UserQueryVisualization>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="UserSettings"/> entities.
        /// </summary>
        public System.Linq.IQueryable<UserSettings> UserSettingsSet
        {
            get { return this.CreateQuery<UserSettings>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="WebResource"/> entities.
        /// </summary>
        public System.Linq.IQueryable<WebResource> WebResourceSet
        {
            get { return this.CreateQuery<WebResource>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="Workflow"/> entities.
        /// </summary>
        public System.Linq.IQueryable<Workflow> WorkflowSet
        {
            get { return this.CreateQuery<Workflow>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="WorkflowDependency"/> entities.
        /// </summary>
        public System.Linq.IQueryable<WorkflowDependency> WorkflowDependencySet
        {
            get { return this.CreateQuery<WorkflowDependency>(); }
        }

        /// <summary>
        /// Gets a binding to the set of all <see cref="WorkflowLog"/> entities.
        /// </summary>
        public System.Linq.IQueryable<WorkflowLog> WorkflowLogSet
        {
            get { return this.CreateQuery<WorkflowLog>(); }
        }
    }
}