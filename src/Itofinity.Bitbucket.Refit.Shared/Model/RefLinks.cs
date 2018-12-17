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
    /// RefLinks
    /// </summary>
    [DataContract]
    public partial class RefLinks :  IEquatable<RefLinks>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RefLinks" /> class.
        /// </summary>
        /// <param name="Self">Self.</param>
        /// <param name="Commits">Commits.</param>
        /// <param name="Html">Html.</param>
        public RefLinks(CommentLinksSelf Self = default(CommentLinksSelf), CommentLinksSelf Commits = default(CommentLinksSelf), CommentLinksSelf Html = default(CommentLinksSelf))
        {
            this.Self = Self;
            this.Commits = Commits;
            this.Html = Html;
        }
        
        /// <summary>
        /// Gets or Sets Self
        /// </summary>
        [DataMember(Name="self", EmitDefaultValue=false)]
        public CommentLinksSelf Self { get; set; }
        /// <summary>
        /// Gets or Sets Commits
        /// </summary>
        [DataMember(Name="commits", EmitDefaultValue=false)]
        public CommentLinksSelf Commits { get; set; }
        /// <summary>
        /// Gets or Sets Html
        /// </summary>
        [DataMember(Name="html", EmitDefaultValue=false)]
        public CommentLinksSelf Html { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RefLinks {\n");
            sb.Append("  Self: ").Append(Self).Append("\n");
            sb.Append("  Commits: ").Append(Commits).Append("\n");
            sb.Append("  Html: ").Append(Html).Append("\n");
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
            return this.Equals(obj as RefLinks);
        }

        /// <summary>
        /// Returns true if RefLinks instances are equal
        /// </summary>
        /// <param name="other">Instance of RefLinks to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RefLinks other)
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
                    this.Commits == other.Commits ||
                    this.Commits != null &&
                    this.Commits.Equals(other.Commits)
                ) && 
                (
                    this.Html == other.Html ||
                    this.Html != null &&
                    this.Html.Equals(other.Html)
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
                if (this.Commits != null)
                    hash = hash * 59 + this.Commits.GetHashCode();
                if (this.Html != null)
                    hash = hash * 59 + this.Html.GetHashCode();
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
