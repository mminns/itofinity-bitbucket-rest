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

namespace Itofinity.Bitbucket.Rest.Model
{
    /// <summary>
    /// Pullrequest
    /// </summary>
    [DataContract]
    public partial class Pullrequest : ModelObject,  IEquatable<Pullrequest>, IValidatableObject
    {
        /// <summary>
        /// The pull request's current status.
        /// </summary>
        /// <value>The pull request's current status.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StateEnum
        {
            
            /// <summary>
            /// Enum MERGED for "MERGED"
            /// </summary>
            [EnumMember(Value = "MERGED")]
            MERGED,
            
            /// <summary>
            /// Enum SUPERSEDED for "SUPERSEDED"
            /// </summary>
            [EnumMember(Value = "SUPERSEDED")]
            SUPERSEDED,
            
            /// <summary>
            /// Enum OPEN for "OPEN"
            /// </summary>
            [EnumMember(Value = "OPEN")]
            OPEN,
            
            /// <summary>
            /// Enum DECLINED for "DECLINED"
            /// </summary>
            [EnumMember(Value = "DECLINED")]
            DECLINED
        }

        /// <summary>
        /// The pull request's current status.
        /// </summary>
        /// <value>The pull request's current status.</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public StateEnum? State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Pullrequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Pullrequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Pullrequest" /> class.
        /// </summary>
        /// <param name="Type">Type (required).</param>
        /// <param name="Links">Links.</param>
        /// <param name="Id">The pull request&#39;s unique ID. Note that pull request IDs are only unique within their associated repository..</param>
        /// <param name="Title">Title of the pull request..</param>
        /// <param name="Rendered">Rendered.</param>
        /// <param name="Summary">Summary.</param>
        /// <param name="State">The pull request&#39;s current status..</param>
        /// <param name="Author">Author.</param>
        /// <param name="Source">Source.</param>
        /// <param name="Destination">Destination.</param>
        /// <param name="MergeCommit">MergeCommit.</param>
        /// <param name="CommentCount">The number of comments for a specific pull request..</param>
        /// <param name="TaskCount">The number of open tasks for a specific pull request..</param>
        /// <param name="CloseSourceBranch">A boolean flag indicating if merging the pull request closes the source branch..</param>
        /// <param name="ClosedBy">ClosedBy.</param>
        /// <param name="Reason">Explains why a pull request was declined. This field is only applicable to pull requests in rejected state..</param>
        /// <param name="CreatedOn">The ISO8601 timestamp the request was created..</param>
        /// <param name="UpdatedOn">The ISO8601 timestamp the request was last updated..</param>
        /// <param name="Reviewers">The list of users that were added as reviewers on this pull request when it was created. For performance reasons, the API only includes this list on a pull request&#39;s &#x60;self&#x60; URL..</param>
        /// <param name="Participants">        The list of users that are collaborating on this pull request.         Collaborators are user that:          * are added to the pull request as a reviewer (part of the reviewers           list)         * are not explicit reviewers, but have commented on the pull request         * are not explicit reviewers, but have approved the pull request          Each user is wrapped in an object that indicates the user&#39;s role and         whether they have approved the pull request. For performance reasons,         the API only returns this list when an API requests a pull request by         id.         .</param>
        public Pullrequest(string Type = default(string), PullrequestLinks Links = default(PullrequestLinks), int? Id = default(int?), string Title = default(string), PullrequestRendered Rendered = default(PullrequestRendered), CommentContent Summary = default(CommentContent), StateEnum? State = default(StateEnum?), Account Author = default(Account), PullrequestEndpoint Source = default(PullrequestEndpoint), PullrequestEndpoint Destination = default(PullrequestEndpoint), PullrequestEndpointCommit MergeCommit = default(PullrequestEndpointCommit), int? CommentCount = default(int?), int? TaskCount = default(int?), bool? CloseSourceBranch = default(bool?), Account ClosedBy = default(Account), string Reason = default(string), DateTime? CreatedOn = default(DateTime?), DateTime? UpdatedOn = default(DateTime?), List<Account> Reviewers = default(List<Account>), List<Participant> Participants = default(List<Participant>))
        {
            // to ensure "Type" is required (not null)
            if (Type == null)
            {
                throw new InvalidDataException("Type is a required property for Pullrequest and cannot be null");
            }
            else
            {
                this.Type = Type;
            }
            this.Links = Links;
            this.Id = Id;
            this.Title = Title;
            this.Rendered = Rendered;
            this.Summary = Summary;
            this.State = State;
            this.Author = Author;
            this.Source = Source;
            this.Destination = Destination;
            this.MergeCommit = MergeCommit;
            this.CommentCount = CommentCount;
            this.TaskCount = TaskCount;
            this.CloseSourceBranch = CloseSourceBranch;
            this.ClosedBy = ClosedBy;
            this.Reason = Reason;
            this.CreatedOn = CreatedOn;
            this.UpdatedOn = UpdatedOn;
            this.Reviewers = Reviewers;
            this.Participants = Participants;
        }
        
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }
        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name="links", EmitDefaultValue=false)]
        public PullrequestLinks Links { get; set; }
        /// <summary>
        /// The pull request&#39;s unique ID. Note that pull request IDs are only unique within their associated repository.
        /// </summary>
        /// <value>The pull request&#39;s unique ID. Note that pull request IDs are only unique within their associated repository.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }
        /// <summary>
        /// Title of the pull request.
        /// </summary>
        /// <value>Title of the pull request.</value>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }
        /// <summary>
        /// Gets or Sets Rendered
        /// </summary>
        [DataMember(Name="rendered", EmitDefaultValue=false)]
        public PullrequestRendered Rendered { get; set; }
        /// <summary>
        /// Gets or Sets Summary
        /// </summary>
        [DataMember(Name="summary", EmitDefaultValue=false)]
        public CommentContent Summary { get; set; }
        /// <summary>
        /// Gets or Sets Author
        /// </summary>
        [DataMember(Name="author", EmitDefaultValue=false)]
        public Account Author { get; set; }
        /// <summary>
        /// Gets or Sets Source
        /// </summary>
        [DataMember(Name="source", EmitDefaultValue=false)]
        public PullrequestEndpoint Source { get; set; }
        /// <summary>
        /// Gets or Sets Destination
        /// </summary>
        [DataMember(Name="destination", EmitDefaultValue=false)]
        public PullrequestEndpoint Destination { get; set; }
        /// <summary>
        /// Gets or Sets MergeCommit
        /// </summary>
        [DataMember(Name="merge_commit", EmitDefaultValue=false)]
        public PullrequestEndpointCommit MergeCommit { get; set; }
        /// <summary>
        /// The number of comments for a specific pull request.
        /// </summary>
        /// <value>The number of comments for a specific pull request.</value>
        [DataMember(Name="comment_count", EmitDefaultValue=false)]
        public int? CommentCount { get; set; }
        /// <summary>
        /// The number of open tasks for a specific pull request.
        /// </summary>
        /// <value>The number of open tasks for a specific pull request.</value>
        [DataMember(Name="task_count", EmitDefaultValue=false)]
        public int? TaskCount { get; set; }
        /// <summary>
        /// A boolean flag indicating if merging the pull request closes the source branch.
        /// </summary>
        /// <value>A boolean flag indicating if merging the pull request closes the source branch.</value>
        [DataMember(Name="close_source_branch", EmitDefaultValue=false)]
        public bool? CloseSourceBranch { get; set; }
        /// <summary>
        /// Gets or Sets ClosedBy
        /// </summary>
        [DataMember(Name="closed_by", EmitDefaultValue=false)]
        public Account ClosedBy { get; set; }
        /// <summary>
        /// Explains why a pull request was declined. This field is only applicable to pull requests in rejected state.
        /// </summary>
        /// <value>Explains why a pull request was declined. This field is only applicable to pull requests in rejected state.</value>
        [DataMember(Name="reason", EmitDefaultValue=false)]
        public string Reason { get; set; }
        /// <summary>
        /// The ISO8601 timestamp the request was created.
        /// </summary>
        /// <value>The ISO8601 timestamp the request was created.</value>
        [DataMember(Name="created_on", EmitDefaultValue=false)]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// The ISO8601 timestamp the request was last updated.
        /// </summary>
        /// <value>The ISO8601 timestamp the request was last updated.</value>
        [DataMember(Name="updated_on", EmitDefaultValue=false)]
        public DateTime? UpdatedOn { get; set; }
        /// <summary>
        /// The list of users that were added as reviewers on this pull request when it was created. For performance reasons, the API only includes this list on a pull request&#39;s &#x60;self&#x60; URL.
        /// </summary>
        /// <value>The list of users that were added as reviewers on this pull request when it was created. For performance reasons, the API only includes this list on a pull request&#39;s &#x60;self&#x60; URL.</value>
        [DataMember(Name="reviewers", EmitDefaultValue=false)]
        public List<Account> Reviewers { get; set; }
        /// <summary>
        ///         The list of users that are collaborating on this pull request.         Collaborators are user that:          * are added to the pull request as a reviewer (part of the reviewers           list)         * are not explicit reviewers, but have commented on the pull request         * are not explicit reviewers, but have approved the pull request          Each user is wrapped in an object that indicates the user&#39;s role and         whether they have approved the pull request. For performance reasons,         the API only returns this list when an API requests a pull request by         id.         
        /// </summary>
        /// <value>        The list of users that are collaborating on this pull request.         Collaborators are user that:          * are added to the pull request as a reviewer (part of the reviewers           list)         * are not explicit reviewers, but have commented on the pull request         * are not explicit reviewers, but have approved the pull request          Each user is wrapped in an object that indicates the user&#39;s role and         whether they have approved the pull request. For performance reasons,         the API only returns this list when an API requests a pull request by         id.         </value>
        [DataMember(Name="participants", EmitDefaultValue=false)]
        public List<Participant> Participants { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Pullrequest {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Rendered: ").Append(Rendered).Append("\n");
            sb.Append("  Summary: ").Append(Summary).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Author: ").Append(Author).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  Destination: ").Append(Destination).Append("\n");
            sb.Append("  MergeCommit: ").Append(MergeCommit).Append("\n");
            sb.Append("  CommentCount: ").Append(CommentCount).Append("\n");
            sb.Append("  TaskCount: ").Append(TaskCount).Append("\n");
            sb.Append("  CloseSourceBranch: ").Append(CloseSourceBranch).Append("\n");
            sb.Append("  ClosedBy: ").Append(ClosedBy).Append("\n");
            sb.Append("  Reason: ").Append(Reason).Append("\n");
            sb.Append("  CreatedOn: ").Append(CreatedOn).Append("\n");
            sb.Append("  UpdatedOn: ").Append(UpdatedOn).Append("\n");
            sb.Append("  Reviewers: ").Append(Reviewers).Append("\n");
            sb.Append("  Participants: ").Append(Participants).Append("\n");
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
            return this.Equals(obj as Pullrequest);
        }

        /// <summary>
        /// Returns true if Pullrequest instances are equal
        /// </summary>
        /// <param name="other">Instance of Pullrequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Pullrequest other)
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
                    this.Links == other.Links ||
                    this.Links != null &&
                    this.Links.Equals(other.Links)
                ) && 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Title == other.Title ||
                    this.Title != null &&
                    this.Title.Equals(other.Title)
                ) && 
                (
                    this.Rendered == other.Rendered ||
                    this.Rendered != null &&
                    this.Rendered.Equals(other.Rendered)
                ) && 
                (
                    this.Summary == other.Summary ||
                    this.Summary != null &&
                    this.Summary.Equals(other.Summary)
                ) && 
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
                ) && 
                (
                    this.Author == other.Author ||
                    this.Author != null &&
                    this.Author.Equals(other.Author)
                ) && 
                (
                    this.Source == other.Source ||
                    this.Source != null &&
                    this.Source.Equals(other.Source)
                ) && 
                (
                    this.Destination == other.Destination ||
                    this.Destination != null &&
                    this.Destination.Equals(other.Destination)
                ) && 
                (
                    this.MergeCommit == other.MergeCommit ||
                    this.MergeCommit != null &&
                    this.MergeCommit.Equals(other.MergeCommit)
                ) && 
                (
                    this.CommentCount == other.CommentCount ||
                    this.CommentCount != null &&
                    this.CommentCount.Equals(other.CommentCount)
                ) && 
                (
                    this.TaskCount == other.TaskCount ||
                    this.TaskCount != null &&
                    this.TaskCount.Equals(other.TaskCount)
                ) && 
                (
                    this.CloseSourceBranch == other.CloseSourceBranch ||
                    this.CloseSourceBranch != null &&
                    this.CloseSourceBranch.Equals(other.CloseSourceBranch)
                ) && 
                (
                    this.ClosedBy == other.ClosedBy ||
                    this.ClosedBy != null &&
                    this.ClosedBy.Equals(other.ClosedBy)
                ) && 
                (
                    this.Reason == other.Reason ||
                    this.Reason != null &&
                    this.Reason.Equals(other.Reason)
                ) && 
                (
                    this.CreatedOn == other.CreatedOn ||
                    this.CreatedOn != null &&
                    this.CreatedOn.Equals(other.CreatedOn)
                ) && 
                (
                    this.UpdatedOn == other.UpdatedOn ||
                    this.UpdatedOn != null &&
                    this.UpdatedOn.Equals(other.UpdatedOn)
                ) && 
                (
                    this.Reviewers == other.Reviewers ||
                    this.Reviewers != null &&
                    this.Reviewers.SequenceEqual(other.Reviewers)
                ) && 
                (
                    this.Participants == other.Participants ||
                    this.Participants != null &&
                    this.Participants.SequenceEqual(other.Participants)
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
                if (this.Links != null)
                    hash = hash * 59 + this.Links.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.Title != null)
                    hash = hash * 59 + this.Title.GetHashCode();
                if (this.Rendered != null)
                    hash = hash * 59 + this.Rendered.GetHashCode();
                if (this.Summary != null)
                    hash = hash * 59 + this.Summary.GetHashCode();
                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();
                if (this.Author != null)
                    hash = hash * 59 + this.Author.GetHashCode();
                if (this.Source != null)
                    hash = hash * 59 + this.Source.GetHashCode();
                if (this.Destination != null)
                    hash = hash * 59 + this.Destination.GetHashCode();
                if (this.MergeCommit != null)
                    hash = hash * 59 + this.MergeCommit.GetHashCode();
                if (this.CommentCount != null)
                    hash = hash * 59 + this.CommentCount.GetHashCode();
                if (this.TaskCount != null)
                    hash = hash * 59 + this.TaskCount.GetHashCode();
                if (this.CloseSourceBranch != null)
                    hash = hash * 59 + this.CloseSourceBranch.GetHashCode();
                if (this.ClosedBy != null)
                    hash = hash * 59 + this.ClosedBy.GetHashCode();
                if (this.Reason != null)
                    hash = hash * 59 + this.Reason.GetHashCode();
                if (this.CreatedOn != null)
                    hash = hash * 59 + this.CreatedOn.GetHashCode();
                if (this.UpdatedOn != null)
                    hash = hash * 59 + this.UpdatedOn.GetHashCode();
                if (this.Reviewers != null)
                    hash = hash * 59 + this.Reviewers.GetHashCode();
                if (this.Participants != null)
                    hash = hash * 59 + this.Participants.GetHashCode();
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
            // CommentCount (int?) minimum
            if(this.CommentCount < (int?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CommentCount, must be a value greater than or equal to 0.", new [] { "CommentCount" });
            }

            // TaskCount (int?) minimum
            if(this.TaskCount < (int?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TaskCount, must be a value greater than or equal to 0.", new [] { "TaskCount" });
            }

            yield break;
        }
    }

}