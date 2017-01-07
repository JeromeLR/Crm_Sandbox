using _4_DAL_CRM;

namespace __4_DAL_CRM
{

    /// <summary>
    /// 
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("accountleads")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class AccountLeads : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public AccountLeads() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "accountleads";

        public const int EntityTypeCode = 16;

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
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("accountid")]
        public System.Nullable<System.Guid> AccountId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("accountid"); }
        }

        /// <summary>
        /// Unique identifier of the lead for the account.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("accountleadid")]
        public System.Nullable<System.Guid> AccountLeadId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("accountleadid"); }
            set
            {
                this.OnPropertyChanging("AccountLeadId");
                this.SetAttributeValue("accountleadid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("AccountLeadId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("accountleadid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.AccountLeadId = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("leadid")]
        public System.Nullable<System.Guid> LeadId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("leadid"); }
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
        /// N:N accountleads_association
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("accountleads_association")]
        public System.Collections.Generic.IEnumerable<Account> accountleads_association
        {
            get { return this.GetRelatedEntities<Account>("accountleads_association", null); }
            set
            {
                this.OnPropertyChanging("accountleads_association");
                this.SetRelatedEntities<Account>("accountleads_association", null, value);
                this.OnPropertyChanged("accountleads_association");
            }
        }
    }
}