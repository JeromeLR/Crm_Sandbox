﻿namespace __4_DAL_CRM
{
    /// <summary>
    /// MIME attachment for an activity.
    /// </summary>
    [System.Runtime.Serialization.DataContractAttribute()]
    [Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("activitymimeattachment")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("CrmSvcUtil", "7.0.0000.3048")]
    public partial class ActivityMimeAttachment : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
    {

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public ActivityMimeAttachment() :
            base(EntityLogicalName)
        {
        }

        public const string EntityLogicalName = "activitymimeattachment";

        public const int EntityTypeCode = 1001;

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
        /// Unique identifier of the activity with which the attachment is associated.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("activityid")]
        [System.ObsoleteAttribute()]
        public Microsoft.Xrm.Sdk.EntityReference ActivityId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("activityid"); }
            set
            {
                this.OnPropertyChanging("ActivityId");
                this.SetAttributeValue("activityid", value);
                this.OnPropertyChanged("ActivityId");
            }
        }

        /// <summary>
        /// Unique identifier of the attachment.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("activitymimeattachmentid")]
        public System.Nullable<System.Guid> ActivityMimeAttachmentId
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("activitymimeattachmentid"); }
            set
            {
                this.OnPropertyChanging("ActivityMimeAttachmentId");
                this.SetAttributeValue("activitymimeattachmentid", value);
                if (value.HasValue)
                {
                    base.Id = value.Value;
                }
                else
                {
                    base.Id = System.Guid.Empty;
                }
                this.OnPropertyChanged("ActivityMimeAttachmentId");
            }
        }

        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("activitymimeattachmentid")]
        public override System.Guid Id
        {
            get { return base.Id; }
            set { this.ActivityMimeAttachmentId = value; }
        }

        /// <summary>
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("activitymimeattachmentidunique")]
        public System.Nullable<System.Guid> ActivityMimeAttachmentIdUnique
        {
            get { return this.GetAttributeValue<System.Nullable<System.Guid>>("activitymimeattachmentidunique"); }
            set
            {
                this.OnPropertyChanging("ActivityMimeAttachmentIdUnique");
                this.SetAttributeValue("activitymimeattachmentidunique", value);
                this.OnPropertyChanged("ActivityMimeAttachmentIdUnique");
            }
        }

        /// <summary>
        /// For internal use only
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("attachmentcontentid")]
        public string AttachmentContentId
        {
            get { return this.GetAttributeValue<string>("attachmentcontentid"); }
            set
            {
                this.OnPropertyChanging("AttachmentContentId");
                this.SetAttributeValue("attachmentcontentid", value);
                this.OnPropertyChanged("AttachmentContentId");
            }
        }

        /// <summary>
        /// Unique identifier of the attachment with which this activitymimeattachment is associated.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("attachmentid")]
        public Microsoft.Xrm.Sdk.EntityReference AttachmentId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("attachmentid"); }
            set
            {
                this.OnPropertyChanging("AttachmentId");
                this.SetAttributeValue("attachmentid", value);
                this.OnPropertyChanged("AttachmentId");
            }
        }

        /// <summary>
        /// Number of the attachment.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("attachmentnumber")]
        public System.Nullable<int> AttachmentNumber
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("attachmentnumber"); }
            set
            {
                this.OnPropertyChanging("AttachmentNumber");
                this.SetAttributeValue("attachmentnumber", value);
                this.OnPropertyChanged("AttachmentNumber");
            }
        }

        /// <summary>
        /// Contents of the attachment.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("body")]
        public string Body
        {
            get { return this.GetAttributeValue<string>("body"); }
            set
            {
                this.OnPropertyChanging("Body");
                this.SetAttributeValue("body", value);
                this.OnPropertyChanged("Body");
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
        /// File name of the attachment.
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
        /// File size of the attachment.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("filesize")]
        public System.Nullable<int> FileSize
        {
            get { return this.GetAttributeValue<System.Nullable<int>>("filesize"); }
        }

        /// <summary>
        /// Indicates whether the solution component is part of a managed solution.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ismanaged")]
        public System.Nullable<bool> IsManaged
        {
            get { return this.GetAttributeValue<System.Nullable<bool>>("ismanaged"); }
        }

        /// <summary>
        /// MIME type of the attachment.
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
        /// Unique identifier of the record with which the attachment is associated
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
        public Microsoft.Xrm.Sdk.EntityReference ObjectId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("objectid"); }
            set
            {
                this.OnPropertyChanging("ObjectId");
                this.SetAttributeValue("objectid", value);
                this.OnPropertyChanged("ObjectId");
            }
        }

        /// <summary>
        /// Object Type Code of the entity that is associated with the attachment.
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
        /// For internal use only.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("overwritetime")]
        public System.Nullable<System.DateTime> OverwriteTime
        {
            get { return this.GetAttributeValue<System.Nullable<System.DateTime>>("overwritetime"); }
        }

        /// <summary>
        /// Unique identifier of the user or team who owns the activity_mime_attachment.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ownerid")]
        public Microsoft.Xrm.Sdk.EntityReference OwnerId
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("ownerid"); }
        }

        /// <summary>
        /// Unique identifier of the business unit that owns the activity mime attachment.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
        public Microsoft.Xrm.Sdk.EntityReference OwningBusinessUnit
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningbusinessunit"); }
        }

        /// <summary>
        /// Unique identifier of the user who owns the activity mime attachment.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
        public Microsoft.Xrm.Sdk.EntityReference OwningUser
        {
            get { return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owninguser"); }
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
        /// Descriptive subject for the attachment.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("subject")]
        public string Subject
        {
            get { return this.GetAttributeValue<string>("subject"); }
            set
            {
                this.OnPropertyChanging("Subject");
                this.SetAttributeValue("subject", value);
                this.OnPropertyChanged("Subject");
            }
        }

        /// <summary>
        /// Version number of the activity mime attachment.
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
        public System.Nullable<long> VersionNumber
        {
            get { return this.GetAttributeValue<System.Nullable<long>>("versionnumber"); }
        }

        /// <summary>
        /// 1:N ActivityMimeAttachment_AsyncOperations
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ActivityMimeAttachment_AsyncOperations")]
        public System.Collections.Generic.IEnumerable<AsyncOperation> ActivityMimeAttachment_AsyncOperations
        {
            get { return this.GetRelatedEntities<AsyncOperation>("ActivityMimeAttachment_AsyncOperations", null); }
            set
            {
                this.OnPropertyChanging("ActivityMimeAttachment_AsyncOperations");
                this.SetRelatedEntities<AsyncOperation>("ActivityMimeAttachment_AsyncOperations", null, value);
                this.OnPropertyChanged("ActivityMimeAttachment_AsyncOperations");
            }
        }

        /// <summary>
        /// 1:N ActivityMimeAttachment_BulkDeleteFailures
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ActivityMimeAttachment_BulkDeleteFailures")]
        public System.Collections.Generic.IEnumerable<BulkDeleteFailure> ActivityMimeAttachment_BulkDeleteFailures
        {
            get { return this.GetRelatedEntities<BulkDeleteFailure>("ActivityMimeAttachment_BulkDeleteFailures", null); }
            set
            {
                this.OnPropertyChanging("ActivityMimeAttachment_BulkDeleteFailures");
                this.SetRelatedEntities<BulkDeleteFailure>("ActivityMimeAttachment_BulkDeleteFailures", null, value);
                this.OnPropertyChanged("ActivityMimeAttachment_BulkDeleteFailures");
            }
        }

        /// <summary>
        /// 1:N userentityinstancedata_activitymimeattachment
        /// </summary>
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_activitymimeattachment")]
        public System.Collections.Generic.IEnumerable<UserEntityInstanceData> userentityinstancedata_activitymimeattachment
        {
            get { return this.GetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_activitymimeattachment", null); }
            set
            {
                this.OnPropertyChanging("userentityinstancedata_activitymimeattachment");
                this.SetRelatedEntities<UserEntityInstanceData>("userentityinstancedata_activitymimeattachment", null, value);
                this.OnPropertyChanged("userentityinstancedata_activitymimeattachment");
            }
        }

        /// <summary>
        /// N:1 activity_pointer_activity_mime_attachment
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("activity_pointer_activity_mime_attachment")]
        public ActivityPointer activity_pointer_activity_mime_attachment
        {
            get { return this.GetRelatedEntity<ActivityPointer>("activity_pointer_activity_mime_attachment", null); }
            set
            {
                this.OnPropertyChanging("activity_pointer_activity_mime_attachment");
                this.SetRelatedEntity<ActivityPointer>("activity_pointer_activity_mime_attachment", null, value);
                this.OnPropertyChanged("activity_pointer_activity_mime_attachment");
            }
        }

        /// <summary>
        /// N:1 appointment_activity_mime_attachment
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("appointment_activity_mime_attachment")]
        public Appointment appointment_activity_mime_attachment
        {
            get { return this.GetRelatedEntity<Appointment>("appointment_activity_mime_attachment", null); }
            set
            {
                this.OnPropertyChanging("appointment_activity_mime_attachment");
                this.SetRelatedEntity<Appointment>("appointment_activity_mime_attachment", null, value);
                this.OnPropertyChanged("appointment_activity_mime_attachment");
            }
        }

        /// <summary>
        /// N:1 email_activity_mime_attachment
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("email_activity_mime_attachment")]
        public Email email_activity_mime_attachment
        {
            get { return this.GetRelatedEntity<Email>("email_activity_mime_attachment", null); }
            set
            {
                this.OnPropertyChanging("email_activity_mime_attachment");
                this.SetRelatedEntity<Email>("email_activity_mime_attachment", null, value);
                this.OnPropertyChanged("email_activity_mime_attachment");
            }
        }

        /// <summary>
        /// N:1 template_activity_mime_attachments
        /// </summary>
        [Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
        [Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("template_activity_mime_attachments")]
        public Template template_activity_mime_attachments
        {
            get { return this.GetRelatedEntity<Template>("template_activity_mime_attachments", null); }
            set
            {
                this.OnPropertyChanging("template_activity_mime_attachments");
                this.SetRelatedEntity<Template>("template_activity_mime_attachments", null, value);
                this.OnPropertyChanged("template_activity_mime_attachments");
            }
        }
    }
}