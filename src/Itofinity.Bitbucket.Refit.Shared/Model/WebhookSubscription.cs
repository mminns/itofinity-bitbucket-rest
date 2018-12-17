/* 
 * Bitbucket API
 *
 * Code against the Bitbucket API to automate simple tasks, embed Bitbucket data into your own site, build mobile or desktop apps, or even add custom UI add-ons into Bitbucket itself using the Connect framework.
 *
 * OpenAPI spec version: 2.0
 * Contact: support@bitbucket.org
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace Itofinity.Bitbucket.Refit.Model
{
    /// <summary>
    /// WebhookSubscription
    /// </summary>
    [DataContract]
    public partial class WebhookSubscription : ModelObject,  IEquatable<WebhookSubscription>, IValidatableObject
    {
        /// <summary>
        /// The type of entity, which is `repository` in the case of webhook subscriptions on repositories.
        /// </summary>
        /// <value>The type of entity, which is `repository` in the case of webhook subscriptions on repositories.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SubjectTypeEnum
        {
            
            /// <summary>
            /// Enum User for "user"
            /// </summary>
            [EnumMember(Value = "user")]
            User,
            
            /// <summary>
            /// Enum Repository for "repository"
            /// </summary>
            [EnumMember(Value = "repository")]
            Repository,
            
            /// <summary>
            /// Enum Team for "team"
            /// </summary>
            [EnumMember(Value = "team")]
            Team
        }


        /// <summary>
        /// Gets or Sets Events
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum EventsEnum
        {
            
            /// <summary>
            /// Enum Pullrequestunapproved for "pullrequest:unapproved"
            /// </summary>
            [EnumMember(Value = "pullrequest:unapproved")]
            Pullrequestunapproved,
            
            /// <summary>
            /// Enum Issuecommentcreated for "issue:comment_created"
            /// </summary>
            [EnumMember(Value = "issue:comment_created")]
            Issuecommentcreated,
            
            /// <summary>
            /// Enum Pullrequestapproved for "pullrequest:approved"
            /// </summary>
            [EnumMember(Value = "pullrequest:approved")]
            Pullrequestapproved,
            
            /// <summary>
            /// Enum Repocreated for "repo:created"
            /// </summary>
            [EnumMember(Value = "repo:created")]
            Repocreated,
            
            /// <summary>
            /// Enum Repodeleted for "repo:deleted"
            /// </summary>
            [EnumMember(Value = "repo:deleted")]
            Repodeleted,
            
            /// <summary>
            /// Enum Repoimported for "repo:imported"
            /// </summary>
            [EnumMember(Value = "repo:imported")]
            Repoimported,
            
            /// <summary>
            /// Enum Pullrequestcommentupdated for "pullrequest:comment_updated"
            /// </summary>
            [EnumMember(Value = "pullrequest:comment_updated")]
            Pullrequestcommentupdated,
            
            /// <summary>
            /// Enum Issueupdated for "issue:updated"
            /// </summary>
            [EnumMember(Value = "issue:updated")]
            Issueupdated,
            
            /// <summary>
            /// Enum Projectupdated for "project:updated"
            /// </summary>
            [EnumMember(Value = "project:updated")]
            Projectupdated,
            
            /// <summary>
            /// Enum Pullrequestcommentcreated for "pullrequest:comment_created"
            /// </summary>
            [EnumMember(Value = "pullrequest:comment_created")]
            Pullrequestcommentcreated,
            
            /// <summary>
            /// Enum Repocommitstatusupdated for "repo:commit_status_updated"
            /// </summary>
            [EnumMember(Value = "repo:commit_status_updated")]
            Repocommitstatusupdated,
            
            /// <summary>
            /// Enum Pullrequestupdated for "pullrequest:updated"
            /// </summary>
            [EnumMember(Value = "pullrequest:updated")]
            Pullrequestupdated,
            
            /// <summary>
            /// Enum Issuecreated for "issue:created"
            /// </summary>
            [EnumMember(Value = "issue:created")]
            Issuecreated,
            
            /// <summary>
            /// Enum Repofork for "repo:fork"
            /// </summary>
            [EnumMember(Value = "repo:fork")]
            Repofork,
            
            /// <summary>
            /// Enum Pullrequestcommentdeleted for "pullrequest:comment_deleted"
            /// </summary>
            [EnumMember(Value = "pullrequest:comment_deleted")]
            Pullrequestcommentdeleted,
            
            /// <summary>
            /// Enum Repocommitstatuscreated for "repo:commit_status_created"
            /// </summary>
            [EnumMember(Value = "repo:commit_status_created")]
            Repocommitstatuscreated,
            
            /// <summary>
            /// Enum Repoupdated for "repo:updated"
            /// </summary>
            [EnumMember(Value = "repo:updated")]
            Repoupdated,
            
            /// <summary>
            /// Enum Pullrequestrejected for "pullrequest:rejected"
            /// </summary>
            [EnumMember(Value = "pullrequest:rejected")]
            Pullrequestrejected,
            
            /// <summary>
            /// Enum Pullrequestfulfilled for "pullrequest:fulfilled"
            /// </summary>
            [EnumMember(Value = "pullrequest:fulfilled")]
            Pullrequestfulfilled,
            
            /// <summary>
            /// Enum Repopush for "repo:push"
            /// </summary>
            [EnumMember(Value = "repo:push")]
            Repopush,
            
            /// <summary>
            /// Enum Pullrequestcreated for "pullrequest:created"
            /// </summary>
            [EnumMember(Value = "pullrequest:created")]
            Pullrequestcreated,
            
            /// <summary>
            /// Enum Repotransfer for "repo:transfer"
            /// </summary>
            [EnumMember(Value = "repo:transfer")]
            Repotransfer,
            
            /// <summary>
            /// Enum Repocommitcommentcreated for "repo:commit_comment_created"
            /// </summary>
            [EnumMember(Value = "repo:commit_comment_created")]
            Repocommitcommentcreated
        }

        /// <summary>
        /// The type of entity, which is `repository` in the case of webhook subscriptions on repositories.
        /// </summary>
        /// <value>The type of entity, which is `repository` in the case of webhook subscriptions on repositories.</value>
        [DataMember(Name="subject_type", EmitDefaultValue=false)]
        public SubjectTypeEnum? SubjectType { get; set; }
        /// <summary>
        /// The events this webhook is subscribed to.
        /// </summary>
        /// <value>The events this webhook is subscribed to.</value>
        [DataMember(Name="events", EmitDefaultValue=false)]
        public List<EventsEnum> Events { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookSubscription" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WebhookSubscription() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookSubscription" /> class.
        /// </summary>
        /// <param name="Type">Type (required).</param>
        /// <param name="Uuid">The webhook&#39;s id.</param>
        /// <param name="Url">The URL events get delivered to..</param>
        /// <param name="Description">A user-defined description of the webhook..</param>
        /// <param name="SubjectType">The type of entity, which is &#x60;repository&#x60; in the case of webhook subscriptions on repositories..</param>
        /// <param name="Subject">Subject.</param>
        /// <param name="Active">Active.</param>
        /// <param name="CreatedAt">CreatedAt.</param>
        /// <param name="Events">The events this webhook is subscribed to..</param>
        public WebhookSubscription(string Type = default(string), string Uuid = default(string), string Url = default(string), string Description = default(string), SubjectTypeEnum? SubjectType = default(SubjectTypeEnum?), Object Subject = default(Object), bool? Active = default(bool?), DateTime? CreatedAt = default(DateTime?), List<EventsEnum> Events = default(List<EventsEnum>))
        {
            // to ensure "Type" is required (not null)
            if (Type == null)
            {
                throw new InvalidDataException("Type is a required property for WebhookSubscription and cannot be null");
            }
            else
            {
                this.Type = Type;
            }
            this.Uuid = Uuid;
            this.Url = Url;
            this.Description = Description;
            this.SubjectType = SubjectType;
            this.Subject = Subject;
            this.Active = Active;
            this.CreatedAt = CreatedAt;
            this.Events = Events;
        }
        
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }
        /// <summary>
        /// The webhook&#39;s id
        /// </summary>
        /// <value>The webhook&#39;s id</value>
        [DataMember(Name="uuid", EmitDefaultValue=false)]
        public string Uuid { get; set; }
        /// <summary>
        /// The URL events get delivered to.
        /// </summary>
        /// <value>The URL events get delivered to.</value>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; set; }
        /// <summary>
        /// A user-defined description of the webhook.
        /// </summary>
        /// <value>A user-defined description of the webhook.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }
        /// <summary>
        /// Gets or Sets Subject
        /// </summary>
        [DataMember(Name="subject", EmitDefaultValue=false)]
        public Object Subject { get; set; }
        /// <summary>
        /// Gets or Sets Active
        /// </summary>
        [DataMember(Name="active", EmitDefaultValue=false)]
        public bool? Active { get; set; }
        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name="created_at", EmitDefaultValue=false)]
        public DateTime? CreatedAt { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WebhookSubscription {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Uuid: ").Append(Uuid).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  SubjectType: ").Append(SubjectType).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Events: ").Append(Events).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public  new string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as WebhookSubscription);
        }

        /// <summary>
        /// Returns true if WebhookSubscription instances are equal
        /// </summary>
        /// <param name="other">Instance of WebhookSubscription to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WebhookSubscription other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.Uuid == other.Uuid ||
                    this.Uuid != null &&
                    this.Uuid.Equals(other.Uuid)
                ) && 
                (
                    this.Url == other.Url ||
                    this.Url != null &&
                    this.Url.Equals(other.Url)
                ) && 
                (
                    this.Description == other.Description ||
                    this.Description != null &&
                    this.Description.Equals(other.Description)
                ) && 
                (
                    this.SubjectType == other.SubjectType ||
                    this.SubjectType != null &&
                    this.SubjectType.Equals(other.SubjectType)
                ) && 
                (
                    this.Subject == other.Subject ||
                    this.Subject != null &&
                    this.Subject.Equals(other.Subject)
                ) && 
                (
                    this.Active == other.Active ||
                    this.Active != null &&
                    this.Active.Equals(other.Active)
                ) && 
                (
                    this.CreatedAt == other.CreatedAt ||
                    this.CreatedAt != null &&
                    this.CreatedAt.Equals(other.CreatedAt)
                ) && 
                (
                    this.Events == other.Events ||
                    this.Events != null &&
                    this.Events.SequenceEqual(other.Events)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.Uuid != null)
                    hash = hash * 59 + this.Uuid.GetHashCode();
                if (this.Url != null)
                    hash = hash * 59 + this.Url.GetHashCode();
                if (this.Description != null)
                    hash = hash * 59 + this.Description.GetHashCode();
                if (this.SubjectType != null)
                    hash = hash * 59 + this.SubjectType.GetHashCode();
                if (this.Subject != null)
                    hash = hash * 59 + this.Subject.GetHashCode();
                if (this.Active != null)
                    hash = hash * 59 + this.Active.GetHashCode();
                if (this.CreatedAt != null)
                    hash = hash * 59 + this.CreatedAt.GetHashCode();
                if (this.Events != null)
                    hash = hash * 59 + this.Events.GetHashCode();
                return hash;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
