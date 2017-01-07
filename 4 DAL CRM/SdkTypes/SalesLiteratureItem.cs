namespace __4_DAL_CRM
{
    /// <summary>
    /// Item in the sales literature collection.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("salesliteratureitem")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class SalesLiteratureItem : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public SalesLiteratureItem() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "salesliteratureitem";

        public const int EntityTypeCode = 1070;

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
        /// Abstract of the document.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("abstract")]
        public string Abstract
        {
            get { return this.GetAttributeValue<string>("abstract"); }
            set
            {
                this.OnPropertyChanging("Abstract");
                this.SetAttributeValue("abstract", value);
                this.OnPropertyChanged("Abstract");
            }
        }

        /// <summary>
        /// URL of the Website on which the document is located.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("attacheddocumenturl")]
        public string AttachedDocumentUrl
        {
            get { return this.GetAttributeValue<string>("attacheddocumenturl"); }
            set
            {
                this.OnPropertyChanging("AttachedDocumentUrl");
                this.SetAttributeValue("attacheddocumenturl", value);
                this.OnPropertyChanged("AttachedDocumentUrl");
            }
        }

        /// <summary>
        /// Author name for the document.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("authorname")]
        public string AuthorName
        {
            get { return this.GetAttributeValue<string>("authorname"); }
            set
            {
                this.OnPropertyChanging("AuthorName");
                this.SetAttributeValue("authorname", value);
                this.OnPropertyChanged("AuthorName");
            }
        }

        /// <summary>
        /// Unique identifier of the user who created the document.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby"); }
        }

        /// <summary>
        /// Date and time when the document was created.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
        public System.Nullable<System.DateTime> CreatedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who created the salesliteratureitem.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        /// Shows the encoded contents of the sales literature document attachment.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("documentbody")]
        public string DocumentBody
        {
            get { return this.GetAttributeValue<string>("documentbody"); }
            set
            {
                this.OnPropertyChanging("DocumentBody");
                this.SetAttributeValue("documentbody", value);
                this.OnPropertyChanged("DocumentBody");
            }
        }

        /// <summary>
        /// File name of the document.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("filename")]
        public string FileName
        {
            get { return this.GetAttributeValue<string>("filename"); }
            set
            {
                this.OnPropertyChanging("FileName");
                this.SetAttributeValue("filename", value);
                this.OnPropertyChanged("FileName");
            }
        }

        /// <summary>
        /// File size of the document.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("filesize")]
        public System.Nullable<int> FileSize
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("filesize"); }
        }

        /// <summary>
        /// Select the file type of the document.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("filetypecode")]
        public Microsoft.Xrm.Sdk.OptionSetValue FileTypeCode
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("filetypecode"); }
            set
            {
                this.OnPropertyChanging("FileTypeCode");
                this.SetAttributeValue("filetypecode", value);
                this.OnPropertyChanged("FileTypeCode");
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
        /// Tells whether the document can be shared with customers or is for internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("iscustomerviewable")]
        public System.Nullable<bool> IsCustomerViewable
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("iscustomerviewable"); }
            set
            {
                this.OnPropertyChanging("IsCustomerViewable");
                this.SetAttributeValue("iscustomerviewable", value);
                this.OnPropertyChanged("IsCustomerViewable");
            }
        }

        /// <summary>
        /// Keywords to use for searches in documents.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("keywords")]
        public string KeyWords
        {
            get { return this.GetAttributeValue<string>("keywords"); }
            set
            {
                this.OnPropertyChanging("KeyWords");
                this.SetAttributeValue("keywords", value);
                this.OnPropertyChanged("KeyWords");
            }
        }

        /// <summary>
        /// Shows the file type of the sales literature document attachment, such as text or document.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("mimetype")]
        public string MimeType
        {
            get { return this.GetAttributeValue<string>("mimetype"); }
            set
            {
                this.OnPropertyChanging("MimeType");
                this.SetAttributeValue("mimetype", value);
                this.OnPropertyChanged("MimeType");
            }
        }

        /// <summary>
        /// Unique identifier of the user who last modified the document.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby"); }
        }

        /// <summary>
        /// Date and time when the document was last modified.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
        public System.Nullable<System.DateTime> ModifiedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who last modified the salesliteratureitem.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        /// Unique identifier of the organization associated with the document.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
        public System.Nullable<System.Guid> OrganizationId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("organizationid"); }
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
        /// Unique identifier of the sales literature that is associated with the individual item.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("salesliteratureid")]
        public Microsoft.Xrm.Sdk.EntityReference SalesLiteratureId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("salesliteratureid"); }
            set
            {
                this.OnPropertyChanging("SalesLiteratureId");
                this.SetAttributeValue("salesliteratureid", value);
                this.OnPropertyChanged("SalesLiteratureId");
            }
        }

        /// <summary>
        /// Unique identifier for the document.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("salesliteratureitemid")]
        public System.Nullable<System.Guid> SalesLiteratureItemId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("salesliteratureitemid"); }
            set
            {
                this.OnPropertyChanging("SalesLiteratureItemId");
                this.SetAttributeValue("salesliteratureitemid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("SalesLiteratureItemId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("salesliteratureitemid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.SalesLiteratureItemId = value; }
        }

        /// <summary>
        /// Type the title or name that describes the document.
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
        /// Version number of the sales literature item.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
        public System.Nullable<long> VersionNumber
        {
            get { return this.GetAttributeValue<System.Nullable<long>>("versionnumber"); }
        }

        /// <summary>
        /// 1:N SalesLiteratureItem_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SalesLiteratureItem_AsyncOperations")]
        public System.Collections.Generic.IEnumerable<AsyncOperation> SalesLiteratureItem_AsyncOperations
        {
            get { return this.GetRelatedEntities<AsyncOperation>("SalesLiteratureItem_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("SalesLiteratureItem_AsyncOperations");
                this.SetRelatedEntities<AsyncOperation>("SalesLiteratureItem_AsyncOperations", null, value);
                this.OnPropertyChanged("SalesLiteratureItem_AsyncOperations");
            }
        }

        /// <summary>
        /// 1:N SalesLiteratureItem_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SalesLiteratureItem_BulkDeleteFailures")]
        public System.Collections.Generic.IEnumerable<BulkDeleteFailure> SalesLiteratureItem_BulkDeleteFailures
        {
            get { return this.GetRelatedEntities<BulkDeleteFailure>("SalesLiteratureItem_BulkDeleteFailures", null); }
            set
            {
                this.OnPropertyChanging("SalesLiteratureItem_BulkDeleteFailures");
                this.SetRelatedEntities<BulkDeleteFailure>("SalesLiteratureItem_BulkDeleteFailures", null, value);
                this.OnPropertyChanged("SalesLiteratureItem_BulkDeleteFailures");
            }
        }

        /// <summary>
        /// 1:N SalesLiteratureItem_ProcessSessions
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SalesLiteratureItem_ProcessSessions")]
        public System.Collections.Generic.IEnumerable<ProcessSession> SalesLiteratureItem_ProcessSessions
        {
            get { return this.GetRelatedEntities<ProcessSession>("SalesLiteratureItem_ProcessSessions", null); }
            set
            {
                this.OnPropertyChanging("SalesLiteratureItem_ProcessSessions");
                this.SetRelatedEntities<ProcessSession>("SalesLiteratureItem_ProcessSessions", null, value);
                this.OnPropertyChanged("SalesLiteratureItem_ProcessSessions");
            }
        }

        /// <summary>
        /// 1:N userentityinstancedata_salesliteratureitem
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_salesliteratureitem")]
        public System.Collections.Generic.IEnumerable<UserEntityInstanceData> userentityinstancedata_salesliteratureitem
        {
            get { return this.GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_salesliteratureitem", null); }
            set
            {
                this.OnPropertyChanging("userentityinstancedata_salesliteratureitem");
                this.SetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_salesliteratureitem", null, value);
                this.OnPropertyChanged("userentityinstancedata_salesliteratureitem");
            }
        }

        /// <summary>
        /// N:1 lk_salesliteratureitem_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_salesliteratureitem_createdonbehalfby")]
        public SystemUser lk_salesliteratureitem_createdonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_salesliteratureitem_createdonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_salesliteratureitem_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_salesliteratureitem_modifiedonbehalfby")]
        public SystemUser lk_salesliteratureitem_modifiedonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_salesliteratureitem_modifiedonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_salesliteratureitembase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_salesliteratureitembase_createdby")]
        public SystemUser lk_salesliteratureitembase_createdby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_salesliteratureitembase_createdby", null); }
        }

        /// <summary>
        /// N:1 lk_salesliteratureitembase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_salesliteratureitembase_modifiedby")]
        public SystemUser lk_salesliteratureitembase_modifiedby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_salesliteratureitembase_modifiedby", null); }
        }

        /// <summary>
        /// N:1 sales_literature_items
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("salesliteratureid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("sales_literature_items")]
        public SalesLiterature sales_literature_items
        {
            get { return this.GetRelatedEntity<SalesLiterature>("sales_literature_items", null); }
            set
            {
                this.OnPropertyChanging("sales_literature_items");
                this.SetRelatedEntity<SalesLiterature>("sales_literature_items", null, value);
                this.OnPropertyChanged("sales_literature_items");
            }
        }
    }
}