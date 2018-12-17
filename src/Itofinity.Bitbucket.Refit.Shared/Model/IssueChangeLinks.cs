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
    /// IssueChangeLinks
    /// </summary>
    [DataContract]
    public partial class IssueChangeLinks :  IEquatable<IssueChangeLinks>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IssueChangeLinks" /> class.
        /// </summary>
        /// <param name="Self">Self.</param>
        /// <param name="Issue">Issue.</param>
        public IssueChangeLinks(CommentLinksSelf Self = default(CommentLinksSelf), CommentLinksSelf Issue = default(CommentLinksSelf))
        {
            this.Self = Self;
            this.Issue = Issue;
        }
        
        /// <summary>
        /// Gets or Sets Self
        /// </summary>
        [DataMember(Name="self", EmitDefaultValue=false)]
        public CommentLinksSelf Self { get; set; }
        /// <summary>
        /// Gets or Sets Issue
        /// </summary>
        [DataMember(Name="issue", EmitDefaultValue=false)]
        public CommentLinksSelf Issue { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IssueChangeLinks {\n");
            sb.Append("  Self: ").Append(Self).Append("\n");
            sb.Append("  Issue: ").Append(Issue).Append("\n");
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
            return this.Equals(obj as IssueChangeLinks);
        }

        /// <summary>
        /// Returns true if IssueChangeLinks instances are equal
        /// </summary>
        /// <param name="other">Instance of IssueChangeLinks to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IssueChangeLinks other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Self == other.Self ||
                    this.Self != null &&
                    this.Self.Equals(other.Self)
                ) && 
                (
                    this.Issue == other.Issue ||
                    this.Issue != null &&
                    this.Issue.Equals(other.Issue)
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
                if (this.Self != null)
                    hash = hash * 59 + this.Self.GetHashCode();
                if (this.Issue != null)
                    hash = hash * 59 + this.Issue.GetHashCode();
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
