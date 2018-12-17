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
    /// CommentInline
    /// </summary>
    [DataContract]
    public partial class CommentInline :  IEquatable<CommentInline>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CommentInline" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CommentInline() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CommentInline" /> class.
        /// </summary>
        /// <param name="To">The comment&#39;s anchor line in the new version of the file..</param>
        /// <param name="From">The comment&#39;s anchor line in the old version of the file..</param>
        /// <param name="Path">The path of the file this comment is anchored to. (required).</param>
        public CommentInline(int? To = default(int?), int? From = default(int?), string Path = default(string))
        {
            // to ensure "Path" is required (not null)
            if (Path == null)
            {
                throw new InvalidDataException("Path is a required property for CommentInline and cannot be null");
            }
            else
            {
                this.Path = Path;
            }
            this.To = To;
            this.From = From;
        }
        
        /// <summary>
        /// The comment&#39;s anchor line in the new version of the file.
        /// </summary>
        /// <value>The comment&#39;s anchor line in the new version of the file.</value>
        [DataMember(Name="to", EmitDefaultValue=false)]
        public int? To { get; set; }
        /// <summary>
        /// The comment&#39;s anchor line in the old version of the file.
        /// </summary>
        /// <value>The comment&#39;s anchor line in the old version of the file.</value>
        [DataMember(Name="from", EmitDefaultValue=false)]
        public int? From { get; set; }
        /// <summary>
        /// The path of the file this comment is anchored to.
        /// </summary>
        /// <value>The path of the file this comment is anchored to.</value>
        [DataMember(Name="path", EmitDefaultValue=false)]
        public string Path { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CommentInline {\n");
            sb.Append("  To: ").Append(To).Append("\n");
            sb.Append("  From: ").Append(From).Append("\n");
            sb.Append("  Path: ").Append(Path).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
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
            return this.Equals(obj as CommentInline);
        }

        /// <summary>
        /// Returns true if CommentInline instances are equal
        /// </summary>
        /// <param name="other">Instance of CommentInline to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CommentInline other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.To == other.To ||
                    this.To != null &&
                    this.To.Equals(other.To)
                ) && 
                (
                    this.From == other.From ||
                    this.From != null &&
                    this.From.Equals(other.From)
                ) && 
                (
                    this.Path == other.Path ||
                    this.Path != null &&
                    this.Path.Equals(other.Path)
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
                if (this.To != null)
                    hash = hash * 59 + this.To.GetHashCode();
                if (this.From != null)
                    hash = hash * 59 + this.From.GetHashCode();
                if (this.Path != null)
                    hash = hash * 59 + this.Path.GetHashCode();
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
            // To (int?) minimum
            if(this.To < (int?)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for To, must be a value greater than or equal to 1.", new [] { "To" });
            }

            // From (int?) minimum
            if(this.From < (int?)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for From, must be a value greater than or equal to 1.", new [] { "From" });
            }

            yield break;
        }
    }

}