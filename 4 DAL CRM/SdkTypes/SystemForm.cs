namespace __4_DAL_CRM
{
    /// <summary>
    /// Organization-owned entity customizations including form layout and dashboards.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("systemform")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class SystemForm : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public SystemForm() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "systemform";

        public const int EntityTypeCode = 1030;

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
        /// Unique identifier of the parent form.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ancestorformid")]
        public Microsoft.Xrm.Sdk.EntityReference AncestorFormId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("ancestorformid"); }
            set
            {
                this.OnPropertyChanging("AncestorFormId");
                this.SetAttributeValue("ancestorformid", value);
                this.OnPropertyChanged("AncestorFormId");
            }
        }

        /// <summary>
        /// Information that specifies whether this component can be deleted.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("canbedeleted")]
        public Microsoft.Xrm.Sdk.BooleanManagedProperty CanBeDeleted
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.BooleanManagedProperty>("canbedeleted"); }
            set
            {
                this.OnPropertyChanging("CanBeDeleted");
                this.SetAttributeValue("canbedeleted", value);
                this.OnPropertyChanged("CanBeDeleted");
            }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("componentstate")]
        public Microsoft.Xrm.Sdk.OptionSetValue ComponentState
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("componentstate"); }
        }

        /// <summary>
        /// Description of the form or dashboard.
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
        /// Specifies the state of the form.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("formactivationstate")]
        public Microsoft.Xrm.Sdk.OptionSetValue FormActivationState
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("formactivationstate"); }
            set
            {
                this.OnPropertyChanging("FormActivationState");
                this.SetAttributeValue("formactivationstate", value);
                this.OnPropertyChanged("FormActivationState");
            }
        }

        /// <summary>
        /// Unique identifier of the record type form.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("formid")]
        public System.Nullable<System.Guid> FormId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("formid"); }
            set
            {
                this.OnPropertyChanging("FormId");
                this.SetAttributeValue("formid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("FormId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("formid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.FormId = value; }
        }

        /// <summary>
        /// Unique identifier of the form used when synchronizing customizations for the Microsoft Dynamics CRM client for Outlook.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("formidunique")]
        public System.Nullable<System.Guid> FormIdUnique
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("formidunique"); }
        }

        /// <summary>
        /// Specifies whether this form is in the updated UI layout in Microsoft Dynamics CRM 2015 or Microsoft Dynamics CRM Online 2015 Update.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("formpresentation")]
        public Microsoft.Xrm.Sdk.OptionSetValue FormPresentation
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("formpresentation"); }
            set
            {
                this.OnPropertyChanging("FormPresentation");
                this.SetAttributeValue("formpresentation", value);
                this.OnPropertyChanged("FormPresentation");
            }
        }

        /// <summary>
        /// XML representation of the form layout.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("formxml")]
        public string FormXml
        {
            get { return this.GetAttributeValue<string>("formxml"); }
            set
            {
                this.OnPropertyChanging("FormXml");
                this.SetAttributeValue("formxml", value);
                this.OnPropertyChanged("FormXml");
            }
        }

        /// <summary>
        /// Version in which the form is introduced.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("introducedversion")]
        public string IntroducedVersion
        {
            get { return this.GetAttributeValue<string>("introducedversion"); }
            set
            {
                this.OnPropertyChanging("IntroducedVersion");
                this.SetAttributeValue("introducedversion", value);
                this.OnPropertyChanged("IntroducedVersion");
            }
        }

        /// <summary>
        /// Specifies whether this form is merged with the updated UI layout in Microsoft Dynamics CRM 2015 or Microsoft Dynamics CRM Online 2015 Update.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isairmerged")]
        public System.Nullable<bool> IsAIRMerged
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("isairmerged"); }
            set
            {
                this.OnPropertyChanging("IsAIRMerged");
                this.SetAttributeValue("isairmerged", value);
                this.OnPropertyChanged("IsAIRMerged");
            }
        }

        /// <summary>
        /// Information that specifies whether this component can be customized.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("iscustomizable")]
        public Microsoft.Xrm.Sdk.BooleanManagedProperty IsCustomizable
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.BooleanManagedProperty>("iscustomizable"); }
            set
            {
                this.OnPropertyChanging("IsCustomizable");
                this.SetAttributeValue("iscustomizable", value);
                this.OnPropertyChanged("IsCustomizable");
            }
        }

        /// <summary>
        /// Information that specifies whether the form or the dashboard is the system default.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isdefault")]
        public System.Nullable<bool> IsDefault
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("isdefault"); }
            set
            {
                this.OnPropertyChanging("IsDefault");
                this.SetAttributeValue("isdefault", value);
                this.OnPropertyChanged("IsDefault");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ismanaged")]
        public System.Nullable<bool> IsManaged
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("ismanaged"); }
        }

        /// <summary>
        /// Information that specifies whether the dashboard is enabled for tablet.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("istabletenabled")]
        public System.Nullable<bool> IsTabletEnabled
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("istabletenabled"); }
            set
            {
                this.OnPropertyChanging("IsTabletEnabled");
                this.SetAttributeValue("istabletenabled", value);
                this.OnPropertyChanged("IsTabletEnabled");
            }
        }

        /// <summary>
        /// Name of the form.
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
        /// Code that represents the record type.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objecttypecode")]
        public string ObjectTypeCode
        {
            get { return this.GetAttributeValue<string>("objecttypecode"); }
            set
            {
                this.OnPropertyChanging("ObjectTypeCode");
                this.SetAttributeValue("objecttypecode", value);
                this.OnPropertyChanged("ObjectTypeCode");
            }
        }

        /// <summary>
        /// Unique identifier of the organization.
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
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("publishedon")]
        public System.Nullable<System.DateTime> PublishedOn
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("publishedon"); }
        }

        /// <summary>
        /// Unique identifier of the associated solution.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("solutionid")]
        public System.Nullable<System.Guid> SolutionId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("solutionid"); }
        }

        /// <summary>
        /// Type of the form, for example, Dashboard or Preview.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("type")]
        public Microsoft.Xrm.Sdk.OptionSetValue Type
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("type"); }
            set
            {
                this.OnPropertyChanging("Type");
                this.SetAttributeValue("type", value);
                this.OnPropertyChanged("Type");
            }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("version")]
        public System.Nullable<int> Version
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("version"); }
            set
            {
                this.OnPropertyChanging("Version");
                this.SetAttributeValue("version", value);
                this.OnPropertyChanged("Version");
            }
        }

        /// <summary>
        /// Represents a version of customizations to be synchronized with the Microsoft Dynamics CRM client for Outlook.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
        public System.Nullable<long> VersionNumber
        {
            get { return this.GetAttributeValue<System.Nullable<long>>("versionnumber"); }
        }

        /// <summary>
        /// 1:N form_ancestor_form
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("form_ancestor_form", Microsoft.Xrm.Sdk.EntityRole.Referenced)]
        public System.Collections.Generic.IEnumerable<SystemForm> Referencedform_ancestor_form
        {
            get { return this.GetRelatedEntities<SystemForm>("form_ancestor_form", Microsoft.Xrm.Sdk.EntityRole.Referenced); }
            set
            {
                this.OnPropertyChanging("Referencedform_ancestor_form");
                this.SetRelatedEntities<SystemForm>("form_ancestor_form", Microsoft.Xrm.Sdk.EntityRole.Referenced, value);
                this.OnPropertyChanged("Referencedform_ancestor_form");
            }
        }

        /// <summary>
        /// 1:N processtrigger_systemform
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("processtrigger_systemform")]
        public System.Collections.Generic.IEnumerable<ProcessTrigger> processtrigger_systemform
        {
            get { return this.GetRelatedEntities<ProcessTrigger>("processtrigger_systemform", null); }
            set
            {
                this.OnPropertyChanging("processtrigger_systemform");
                this.SetRelatedEntities<ProcessTrigger>("processtrigger_systemform", null, value);
                this.OnPropertyChanged("processtrigger_systemform");
            }
        }

        /// <summary>
        /// 1:N socialinsightsconfiguration_systemform
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("socialinsightsconfiguration_systemform")]
        public System.Collections.Generic.IEnumerable<SocialInsightsConfiguration> socialinsightsconfiguration_systemform
        {
            get { return this.GetRelatedEntities<SocialInsightsConfiguration>("socialinsightsconfiguration_systemform", null); }
            set
            {
                this.OnPropertyChanging("socialinsightsconfiguration_systemform");
                this.SetRelatedEntities<SocialInsightsConfiguration>("socialinsightsconfiguration_systemform", null, value);
                this.OnPropertyChanged("socialinsightsconfiguration_systemform");
            }
        }

        /// <summary>
        /// 1:N SystemForm_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SystemForm_AsyncOperations")]
        public System.Collections.Generic.IEnumerable<AsyncOperation> SystemForm_AsyncOperations
        {
            get { return this.GetRelatedEntities<AsyncOperation>("SystemForm_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("SystemForm_AsyncOperations");
                this.SetRelatedEntities<AsyncOperation>("SystemForm_AsyncOperations", null, value);
                this.OnPropertyChanged("SystemForm_AsyncOperations");
            }
        }

        /// <summary>
        /// 1:N SystemForm_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SystemForm_BulkDeleteFailures")]
        public System.Collections.Generic.IEnumerable<BulkDeleteFailure> SystemForm_BulkDeleteFailures
        {
            get { return this.GetRelatedEntities<BulkDeleteFailure>("SystemForm_BulkDeleteFailures", null); }
            set
            {
                this.OnPropertyChanging("SystemForm_BulkDeleteFailures");
                this.SetRelatedEntities<BulkDeleteFailure>("SystemForm_BulkDeleteFailures", null, value);
                this.OnPropertyChanged("SystemForm_BulkDeleteFailures");
            }
        }

        /// <summary>
        /// N:1 form_ancestor_form
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ancestorformid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("form_ancestor_form", Microsoft.Xrm.Sdk.EntityRole.Referencing)]
        public SystemForm Referencingform_ancestor_form
        {
            get { return this.GetRelatedEntity<SystemForm>("form_ancestor_form", Microsoft.Xrm.Sdk.EntityRole.Referencing); }
            set
            {
                this.OnPropertyChanging("Referencingform_ancestor_form");
                this.SetRelatedEntity<SystemForm>("form_ancestor_form", Microsoft.Xrm.Sdk.EntityRole.Referencing, value);
                this.OnPropertyChanged("Referencingform_ancestor_form");
            }
        }

        /// <summary>
        /// N:1 organization_systemforms
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_systemforms")]
        public Organization organization_systemforms
        {
            get { return this.GetRelatedEntity<Organization>("organization_systemforms", null); }
        }
    }
}