namespace __4_DAL_CRM
{
    /// <summary>
    /// SharePoint's Data Corresponding to a user , Record , Location and Page
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("sharepointdata")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class SharePointData : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public SharePointData() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "sharepointdata";

        public const int EntityTypeCode = 9509;

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
        /// Unique identifier of the user who created the SharePoint Data.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby"); }
        }

        /// <summary>
        /// Date and time when the SharePoint Data was created.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
        public System.Nullable<System.DateTime> CreatedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who created the SharePoint Data.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        /// SharePoint Data Serialized
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("data")]
        public string Data
        {
            get { return this.GetAttributeValue<string>("data"); }
            set
            {
                this.OnPropertyChanging("Data");
                this.SetAttributeValue("data", value);
                this.OnPropertyChanged("Data");
            }
        }

        /// <summary>
        /// Is valid
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isvalid")]
        public System.Nullable<bool> IsValid
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("isvalid"); }
        }

        /// <summary>
        /// Unique identifier of the user who created the SharePoint Data.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("location")]
        public Microsoft.Xrm.Sdk.EntityReference Location
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("location"); }
        }

        /// <summary>
        /// Unique identifier of the user who last modified the SharePoint Data.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby"); }
        }

        /// <summary>
        /// Date and time when the Sharepoint Data was last modified.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
        public System.Nullable<System.DateTime> ModifiedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who last modified the SharePoint Data.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        /// Next Page Token of the SharePoint document.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("nextpagetoken")]
        public string NextPageToken
        {
            get { return this.GetAttributeValue<string>("nextpagetoken"); }
        }

        /// <summary>
        /// Unique identifier of the organization associated with the SharePoint Data.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
        public Microsoft.Xrm.Sdk.EntityReference OrganizationId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("organizationid"); }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("overwritetime")]
        public System.Nullable<System.DateTime> OverwriteTime
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("overwritetime"); }
        }

        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("pagenumber")]
        public System.Nullable<int> PageNumber
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("pagenumber"); }
        }

        /// <summary>
        /// Previous Page Token of the SharePoint document.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("previouspagetoken")]
        public string PreviousPageToken
        {
            get { return this.GetAttributeValue<string>("previouspagetoken"); }
        }

        /// <summary>
        /// Regarding Object Id.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
        public string RegardingObjectId
        {
            get { return this.GetAttributeValue<string>("regardingobjectid"); }
        }

        /// <summary>
        /// Unique identifier of the SharePoint data record.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sharepointdataid")]
        public System.Nullable<System.Guid> SharePointDataId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("sharepointdataid"); }
            set
            {
                this.OnPropertyChanging("SharePointDataId");
                this.SetAttributeValue("sharepointdataid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("SharePointDataId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sharepointdataid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.SharePointDataId = value; }
        }

        /// <summary>
        /// Unique identifier of the user who created the SharePoint data.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("userid")]
        public Microsoft.Xrm.Sdk.EntityReference UserId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("userid"); }
        }

        /// <summary>
        /// N:1 lk_SharePointData_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_SharePointData_createdby")]
        public SystemUser lk_SharePointData_createdby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_SharePointData_createdby", null); }
        }

        /// <summary>
        /// N:1 lk_SharePointData_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_SharePointData_createdonbehalfby")]
        public SystemUser lk_SharePointData_createdonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_SharePointData_createdonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_SharePointData_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_SharePointData_modifiedby")]
        public SystemUser lk_SharePointData_modifiedby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_SharePointData_modifiedby", null); }
        }

        /// <summary>
        /// N:1 lk_SharePointData_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_SharePointData_modifiedonbehalfby")]
        public SystemUser lk_SharePointData_modifiedonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_SharePointData_modifiedonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_sharepointdata_user
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("userid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_sharepointdata_user")]
        public SystemUser lk_sharepointdata_user
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_sharepointdata_user", null); }
        }

        /// <summary>
        /// N:1 organization_sharepointdata
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_sharepointdata")]
        public Organization organization_sharepointdata
        {
            get { return this.GetRelatedEntity<Organization>("organization_sharepointdata", null); }
        }

        /// <summary>
        /// N:1 sharepointdata_sharepointdocumentlocation
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("location")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("sharepointdata_sharepointdocumentlocation")]
        public SharePointDocumentLocation sharepointdata_sharepointdocumentlocation
        {
            get { return this.GetRelatedEntity<SharePointDocumentLocation>("sharepointdata_sharepointdocumentlocation", null); }
        }
    }
}