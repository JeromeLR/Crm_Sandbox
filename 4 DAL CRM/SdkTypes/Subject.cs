namespace __4_DAL_CRM
{
    /// <summary>
    /// Information regarding subjects available in the system.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("subject")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class Subject : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public Subject() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "subject";

        public const int EntityTypeCode = 129;

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
        /// Unique identifier of the user who created the subject.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby"); }
        }

        /// <summary>
        /// Date and time when the subject was created.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
        public System.Nullable<System.DateTime> CreatedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who created the subject.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby"); }
        }

        /// <summary>
        /// Description of the subject.
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
        /// Information that specifies when the subject will be displayed in lists of subjects.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("featuremask")]
        public System.Nullable<int> FeatureMask
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("featuremask"); }
            set
            {
                this.OnPropertyChanging("FeatureMask");
                this.SetAttributeValue("featuremask", value);
                this.OnPropertyChanged("FeatureMask");
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
        /// Unique identifier of the user who last modified the subject.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby"); }
        }

        /// <summary>
        /// Date and time when the subject was last modified.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
        public System.Nullable<System.DateTime> ModifiedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon"); }
        }

        /// <summary>
        /// Unique identifier of the delegate user who last modified the subject.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby"); }
        }

        /// <summary>
        /// Unique identifier for the organization associated with the subject.
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
        /// Unique identifier of the parent subject.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("parentsubject")]
        public Microsoft.Xrm.Sdk.EntityReference ParentSubject
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("parentsubject"); }
            set
            {
                this.OnPropertyChanging("ParentSubject");
                this.SetAttributeValue("parentsubject", value);
                this.OnPropertyChanged("ParentSubject");
            }
        }

        /// <summary>
        /// Unique identifier of the subject.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("subjectid")]
        public System.Nullable<System.Guid> SubjectId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("subjectid"); }
            set
            {
                this.OnPropertyChanging("SubjectId");
                this.SetAttributeValue("subjectid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("SubjectId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("subjectid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.SubjectId = value; }
        }

        /// <summary>
        /// Title of the subject.
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
        /// Version number of the subject.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
        public System.Nullable<long> VersionNumber
        {
            get { return this.GetAttributeValue<System.Nullable<long>>("versionnumber"); }
        }

        /// <summary>
        /// 1:N Subject_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Subject_AsyncOperations")]
        public System.Collections.Generic.IEnumerable<AsyncOperation> Subject_AsyncOperations
        {
            get { return this.GetRelatedEntities<AsyncOperation>("Subject_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("Subject_AsyncOperations");
                this.SetRelatedEntities<AsyncOperation>("Subject_AsyncOperations", null, value);
                this.OnPropertyChanged("Subject_AsyncOperations");
            }
        }

        /// <summary>
        /// 1:N Subject_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Subject_BulkDeleteFailures")]
        public System.Collections.Generic.IEnumerable<BulkDeleteFailure> Subject_BulkDeleteFailures
        {
            get { return this.GetRelatedEntities<BulkDeleteFailure>("Subject_BulkDeleteFailures", null); }
            set
            {
                this.OnPropertyChanging("Subject_BulkDeleteFailures");
                this.SetRelatedEntities<BulkDeleteFailure>("Subject_BulkDeleteFailures", null, value);
                this.OnPropertyChanged("Subject_BulkDeleteFailures");
            }
        }

        /// <summary>
        /// 1:N subject_incidents
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("subject_incidents")]
        public System.Collections.Generic.IEnumerable<Incident> subject_incidents
        {
            get { return this.GetRelatedEntities<Incident>("subject_incidents", null); }
            set
            {
                this.OnPropertyChanging("subject_incidents");
                this.SetRelatedEntities<Incident>("subject_incidents", null, value);
                this.OnPropertyChanged("subject_incidents");
            }
        }

        /// <summary>
        /// 1:N subject_kb_articles
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("subject_kb_articles")]
        public System.Collections.Generic.IEnumerable<KbArticle> subject_kb_articles
        {
            get { return this.GetRelatedEntities<KbArticle>("subject_kb_articles", null); }
            set
            {
                this.OnPropertyChanging("subject_kb_articles");
                this.SetRelatedEntities<KbArticle>("subject_kb_articles", null, value);
                this.OnPropertyChanged("subject_kb_articles");
            }
        }

        /// <summary>
        /// 1:N subject_parent_subject
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("subject_parent_subject", Microsoft.Xrm.Sdk.EntityRole.Referenced)]
        public System.Collections.Generic.IEnumerable<Subject> Referencedsubject_parent_subject
        {
            get { return this.GetRelatedEntities<Subject>("subject_parent_subject", Microsoft.Xrm.Sdk.EntityRole.Referenced); }
            set
            {
                this.OnPropertyChanging("Referencedsubject_parent_subject");
                this.SetRelatedEntities<Subject>("subject_parent_subject", Microsoft.Xrm.Sdk.EntityRole.Referenced, value);
                this.OnPropertyChanged("Referencedsubject_parent_subject");
            }
        }

        /// <summary>
        /// 1:N Subject_ProcessSessions
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Subject_ProcessSessions")]
        public System.Collections.Generic.IEnumerable<ProcessSession> Subject_ProcessSessions
        {
            get { return this.GetRelatedEntities<ProcessSession>("Subject_ProcessSessions", null); }
            set
            {
                this.OnPropertyChanging("Subject_ProcessSessions");
                this.SetRelatedEntities<ProcessSession>("Subject_ProcessSessions", null, value);
                this.OnPropertyChanged("Subject_ProcessSessions");
            }
        }

        /// <summary>
        /// 1:N subject_products
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("subject_products")]
        public System.Collections.Generic.IEnumerable<Product> subject_products
        {
            get { return this.GetRelatedEntities<Product>("subject_products", null); }
            set
            {
                this.OnPropertyChanging("subject_products");
                this.SetRelatedEntities<Product>("subject_products", null, value);
                this.OnPropertyChanged("subject_products");
            }
        }

        /// <summary>
        /// 1:N subject_sales_literature
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("subject_sales_literature")]
        public System.Collections.Generic.IEnumerable<SalesLiterature> subject_sales_literature
        {
            get { return this.GetRelatedEntities<SalesLiterature>("subject_sales_literature", null); }
            set
            {
                this.OnPropertyChanging("subject_sales_literature");
                this.SetRelatedEntities<SalesLiterature>("subject_sales_literature", null, value);
                this.OnPropertyChanged("subject_sales_literature");
            }
        }

        /// <summary>
        /// 1:N userentityinstancedata_subject
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_subject")]
        public System.Collections.Generic.IEnumerable<UserEntityInstanceData> userentityinstancedata_subject
        {
            get { return this.GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_subject", null); }
            set
            {
                this.OnPropertyChanging("userentityinstancedata_subject");
                this.SetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_subject", null, value);
                this.OnPropertyChanged("userentityinstancedata_subject");
            }
        }

        /// <summary>
        /// N:1 lk_subject_createdonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_subject_createdonbehalfby")]
        public SystemUser lk_subject_createdonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_subject_createdonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_subject_modifiedonbehalfby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_subject_modifiedonbehalfby")]
        public SystemUser lk_subject_modifiedonbehalfby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_subject_modifiedonbehalfby", null); }
        }

        /// <summary>
        /// N:1 lk_subjectbase_createdby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_subjectbase_createdby")]
        public SystemUser lk_subjectbase_createdby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_subjectbase_createdby", null); }
        }

        /// <summary>
        /// N:1 lk_subjectbase_modifiedby
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_subjectbase_modifiedby")]
        public SystemUser lk_subjectbase_modifiedby
        {
            get { return this.GetRelatedEntity<SystemUser>("lk_subjectbase_modifiedby", null); }
        }

        /// <summary>
        /// N:1 organization_subjects
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_subjects")]
        public Organization organization_subjects
        {
            get { return this.GetRelatedEntity<Organization>("organization_subjects", null); }
        }

        /// <summary>
        /// N:1 subject_parent_subject
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("parentsubject")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("subject_parent_subject", Microsoft.Xrm.Sdk.EntityRole.Referencing)]
        public Subject Referencingsubject_parent_subject
        {
            get { return this.GetRelatedEntity<Subject>("subject_parent_subject", Microsoft.Xrm.Sdk.EntityRole.Referencing); }
            set
            {
                this.OnPropertyChanging("Referencingsubject_parent_subject");
                this.SetRelatedEntity<Subject>("subject_parent_subject", Microsoft.Xrm.Sdk.EntityRole.Referencing, value);
                this.OnPropertyChanged("Referencingsubject_parent_subject");
            }
        }
    }
}