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
    /// SnippetCommit
    /// </summary>
    [DataContract]
    public partial class SnippetCommit : BaseCommit,  IEquatable<SnippetCommit>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SnippetCommit" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SnippetCommit() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SnippetCommit" /> class.
        /// </summary>
        /// <param name="Type">Type (required).</param>
        /// <param name="Hash">Hash.</param>
        /// <param name="Date">Date.</param>
        /// <param name="Author">Author.</param>
        /// <param name="Message">Message.</param>
        /// <param name="Summary">Summary.</param>
        /// <param name="Parents">Parents.</param>
        /// <param name="Links">Links.</param>
        /// <param name="Snippet">Snippet.</param>
        public SnippetCommit(string Type = default(string), string Hash = default(string), DateTime? Date = default(DateTime?), Author Author = default(Author), string Message = default(string), CommentContent Summary = default(CommentContent), List<BaseCommit> Parents = default(List<BaseCommit>), SnippetCommitLinks Links = default(SnippetCommitLinks), Snippet Snippet = default(Snippet))
        {
            // to ensure "Type" is required (not null)
            if (Type == null)
            {
                throw new InvalidDataException("Type is a required property for SnippetCommit and cannot be null");
            }
            else
            {
                this.Type = Type;
            }
            this.Hash = Hash;
            this.Date = Date;
            this.Author = Author;
            this.Message = Message;
            this.Summary = Summary;
            this.Parents = Parents;
            this.Links = Links;
            this.Snippet = Snippet;
        }
        
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }
        /// <summary>
        /// Gets or Sets Hash
        /// </summary>
        [DataMember(Name="hash", EmitDefaultValue=false)]
        public string Hash { get; set; }
        /// <summary>
        /// Gets or Sets Date
        /// </summary>
        [DataMember(Name="date", EmitDefaultValue=false)]
        public DateTime? Date { get; set; }
        /// <summary>
        /// Gets or Sets Author
        /// </summary>
        [DataMember(Name="author", EmitDefaultValue=false)]
        public Author Author { get; set; }
        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; set; }
        /// <summary>
        /// Gets or Sets Summary
        /// </summary>
        [DataMember(Name="summary", EmitDefaultValue=false)]
        public CommentContent Summary { get; set; }
        /// <summary>
        /// Gets or Sets Parents
        /// </summary>
        [DataMember(Name="parents", EmitDefaultValue=false)]
        public List<BaseCommit> Parents { get; set; }
        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name="links", EmitDefaultValue=false)]
        public SnippetCommitLinks Links { get; set; }
        /// <summary>
        /// Gets or Sets Snippet
        /// </summary>
        [DataMember(Name="snippet", EmitDefaultValue=false)]
        public Snippet Snippet { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SnippetCommit {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Hash: ").Append(Hash).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  Author: ").Append(Author).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Summary: ").Append(Summary).Append("\n");
            sb.Append("  Parents: ").Append(Parents).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  Snippet: ").Append(Snippet).Append("\n");
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
            return this.Equals(obj as SnippetCommit);
        }

        /// <summary>
        /// Returns true if SnippetCommit instances are equal
        /// </summary>
        /// <param name="other">Instance of SnippetCommit to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SnippetCommit other)
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
                    this.Hash == other.Hash ||
                    this.Hash != null &&
                    this.Hash.Equals(other.Hash)
                ) && 
                (
                    this.Date == other.Date ||
                    this.Date != null &&
                    this.Date.Equals(other.Date)
                ) && 
                (
                    this.Author == other.Author ||
                    this.Author != null &&
                    this.Author.Equals(other.Author)
                ) && 
                (
                    this.Message == other.Message ||
                    this.Message != null &&
                    this.Message.Equals(other.Message)
                ) && 
                (
                    this.Summary == other.Summary ||
                    this.Summary != null &&
                    this.Summary.Equals(other.Summary)
                ) && 
                (
                    this.Parents == other.Parents ||
                    this.Parents != null &&
                    this.Parents.SequenceEqual(other.Parents)
                ) && 
                (
                    this.Links == other.Links ||
                    this.Links != null &&
                    this.Links.Equals(other.Links)
                ) && 
                (
                    this.Snippet == other.Snippet ||
                    this.Snippet != null &&
                    this.Snippet.Equals(other.Snippet)
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
                if (this.Hash != null)
                    hash = hash * 59 + this.Hash.GetHashCode();
                if (this.Date != null)
                    hash = hash * 59 + this.Date.GetHashCode();
                if (this.Author != null)
                    hash = hash * 59 + this.Author.GetHashCode();
                if (this.Message != null)
                    hash = hash * 59 + this.Message.GetHashCode();
                if (this.Summary != null)
                    hash = hash * 59 + this.Summary.GetHashCode();
                if (this.Parents != null)
                    hash = hash * 59 + this.Parents.GetHashCode();
                if (this.Links != null)
                    hash = hash * 59 + this.Links.GetHashCode();
                if (this.Snippet != null)
                    hash = hash * 59 + this.Snippet.GetHashCode();
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
            // Hash (string) pattern
            Regex regexHash = new Regex(@"[0-9a-f]{7,}?", RegexOptions.CultureInvariant);
            if (false == regexHash.Match(this.Hash).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Hash, must match a pattern of /[0-9a-f]{7,}?/.", new [] { "Hash" });
            }

            yield break;
        }
    }

}
