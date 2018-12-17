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
    /// A paginated list of branch restriction rules.
    /// </summary>
    [DataContract]
    public partial class PaginatedBranchrestrictions :  IEquatable<PaginatedBranchrestrictions>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaginatedBranchrestrictions" /> class.
        /// </summary>
        /// <param name="Size">Total number of objects in the response. This is an optional element that is not provided in all responses, as it can be expensive to compute..</param>
        /// <param name="Page">Page number of the current results. This is an optional element that is not provided in all responses..</param>
        /// <param name="Pagelen">Current number of objects on the existing page. The default value is 10 with 100 being the maximum allowed value. Individual APIs may enforce different values..</param>
        /// <param name="Next">Link to the next page if it exists. The last page of a collection does not have this value. Use this link to navigate the result set and refrain from constructing your own URLs..</param>
        /// <param name="Previous">Link to previous page if it exists. A collections first page does not have this value. This is an optional element that is not provided in all responses. Some result sets strictly support forward navigation and never provide previous links. Clients must anticipate that backwards navigation is not always available. Use this link to navigate the result set and refrain from constructing your own URLs..</param>
        /// <param name="Values">Values.</param>
        public PaginatedBranchrestrictions(int? Size = default(int?), int? Page = default(int?), int? Pagelen = default(int?), string Next = default(string), string Previous = default(string), List<Branchrestriction> Values = default(List<Branchrestriction>))
        {
            this.Size = Size;
            this.Page = Page;
            this.Pagelen = Pagelen;
            this.Next = Next;
            this.Previous = Previous;
            this.Values = Values;
        }
        
        /// <summary>
        /// Total number of objects in the response. This is an optional element that is not provided in all responses, as it can be expensive to compute.
        /// </summary>
        /// <value>Total number of objects in the response. This is an optional element that is not provided in all responses, as it can be expensive to compute.</value>
        [DataMember(Name="size", EmitDefaultValue=false)]
        public int? Size { get; set; }
        /// <summary>
        /// Page number of the current results. This is an optional element that is not provided in all responses.
        /// </summary>
        /// <value>Page number of the current results. This is an optional element that is not provided in all responses.</value>
        [DataMember(Name="page", EmitDefaultValue=false)]
        public int? Page { get; set; }
        /// <summary>
        /// Current number of objects on the existing page. The default value is 10 with 100 being the maximum allowed value. Individual APIs may enforce different values.
        /// </summary>
        /// <value>Current number of objects on the existing page. The default value is 10 with 100 being the maximum allowed value. Individual APIs may enforce different values.</value>
        [DataMember(Name="pagelen", EmitDefaultValue=false)]
        public int? Pagelen { get; set; }
        /// <summary>
        /// Link to the next page if it exists. The last page of a collection does not have this value. Use this link to navigate the result set and refrain from constructing your own URLs.
        /// </summary>
        /// <value>Link to the next page if it exists. The last page of a collection does not have this value. Use this link to navigate the result set and refrain from constructing your own URLs.</value>
        [DataMember(Name="next", EmitDefaultValue=false)]
        public string Next { get; set; }
        /// <summary>
        /// Link to previous page if it exists. A collections first page does not have this value. This is an optional element that is not provided in all responses. Some result sets strictly support forward navigation and never provide previous links. Clients must anticipate that backwards navigation is not always available. Use this link to navigate the result set and refrain from constructing your own URLs.
        /// </summary>
        /// <value>Link to previous page if it exists. A collections first page does not have this value. This is an optional element that is not provided in all responses. Some result sets strictly support forward navigation and never provide previous links. Clients must anticipate that backwards navigation is not always available. Use this link to navigate the result set and refrain from constructing your own URLs.</value>
        [DataMember(Name="previous", EmitDefaultValue=false)]
        public string Previous { get; set; }
        /// <summary>
        /// Gets or Sets Values
        /// </summary>
        [DataMember(Name="values", EmitDefaultValue=false)]
        public List<Branchrestriction> Values { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaginatedBranchrestrictions {\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  Page: ").Append(Page).Append("\n");
            sb.Append("  Pagelen: ").Append(Pagelen).Append("\n");
            sb.Append("  Next: ").Append(Next).Append("\n");
            sb.Append("  Previous: ").Append(Previous).Append("\n");
            sb.Append("  Values: ").Append(Values).Append("\n");
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
            return this.Equals(obj as PaginatedBranchrestrictions);
        }

        /// <summary>
        /// Returns true if PaginatedBranchrestrictions instances are equal
        /// </summary>
        /// <param name="other">Instance of PaginatedBranchrestrictions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaginatedBranchrestrictions other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Size == other.Size ||
                    this.Size != null &&
                    this.Size.Equals(other.Size)
                ) && 
                (
                    this.Page == other.Page ||
                    this.Page != null &&
                    this.Page.Equals(other.Page)
                ) && 
                (
                    this.Pagelen == other.Pagelen ||
                    this.Pagelen != null &&
                    this.Pagelen.Equals(other.Pagelen)
                ) && 
                (
                    this.Next == other.Next ||
                    this.Next != null &&
                    this.Next.Equals(other.Next)
                ) && 
                (
                    this.Previous == other.Previous ||
                    this.Previous != null &&
                    this.Previous.Equals(other.Previous)
                ) && 
                (
                    this.Values == other.Values ||
                    this.Values != null &&
                    this.Values.SequenceEqual(other.Values)
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
                if (this.Size != null)
                    hash = hash * 59 + this.Size.GetHashCode();
                if (this.Page != null)
                    hash = hash * 59 + this.Page.GetHashCode();
                if (this.Pagelen != null)
                    hash = hash * 59 + this.Pagelen.GetHashCode();
                if (this.Next != null)
                    hash = hash * 59 + this.Next.GetHashCode();
                if (this.Previous != null)
                    hash = hash * 59 + this.Previous.GetHashCode();
                if (this.Values != null)
                    hash = hash * 59 + this.Values.GetHashCode();
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
            // Size (int?) minimum
            if(this.Size < (int?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Size, must be a value greater than or equal to 0.", new [] { "Size" });
            }

            // Page (int?) minimum
            if(this.Page < (int?)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Page, must be a value greater than or equal to 1.", new [] { "Page" });
            }

            // Pagelen (int?) minimum
            if(this.Pagelen < (int?)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Pagelen, must be a value greater than or equal to 1.", new [] { "Pagelen" });
            }

            yield break;
        }
    }

}
