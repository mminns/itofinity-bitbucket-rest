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
    /// A user&#39;s permission for a given repository.
    /// </summary>
    [DataContract]
    public partial class RepositoryPermission :  IEquatable<RepositoryPermission>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Permission
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PermissionEnum
        {
            
            /// <summary>
            /// Enum Admin for "admin"
            /// </summary>
            [EnumMember(Value = "admin")]
            Admin,
            
            /// <summary>
            /// Enum Write for "write"
            /// </summary>
            [EnumMember(Value = "write")]
            Write,
            
            /// <summary>
            /// Enum Read for "read"
            /// </summary>
            [EnumMember(Value = "read")]
            Read
        }

        /// <summary>
        /// Gets or Sets Permission
        /// </summary>
        [DataMember(Name="permission", EmitDefaultValue=false)]
        public PermissionEnum? Permission { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryPermission" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RepositoryPermission() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryPermission" /> class.
        /// </summary>
        /// <param name="Type">Type (required).</param>
        /// <param name="Permission">Permission.</param>
        /// <param name="User">User.</param>
        /// <param name="Repository">Repository.</param>
        public RepositoryPermission(string Type = default(string), PermissionEnum? Permission = default(PermissionEnum?), User User = default(User), Repository Repository = default(Repository))
        {
            // to ensure "Type" is required (not null)
            if (Type == null)
            {
                throw new InvalidDataException("Type is a required property for RepositoryPermission and cannot be null");
            }
            else
            {
                this.Type = Type;
            }
            this.Permission = Permission;
            this.User = User;
            this.Repository = Repository;
        }
        
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }
        /// <summary>
        /// Gets or Sets User
        /// </summary>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public User User { get; set; }
        /// <summary>
        /// Gets or Sets Repository
        /// </summary>
        [DataMember(Name="repository", EmitDefaultValue=false)]
        public Repository Repository { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RepositoryPermission {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Permission: ").Append(Permission).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  Repository: ").Append(Repository).Append("\n");
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
            return this.Equals(obj as RepositoryPermission);
        }

        /// <summary>
        /// Returns true if RepositoryPermission instances are equal
        /// </summary>
        /// <param name="other">Instance of RepositoryPermission to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RepositoryPermission other)
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
                    this.Permission == other.Permission ||
                    this.Permission != null &&
                    this.Permission.Equals(other.Permission)
                ) && 
                (
                    this.User == other.User ||
                    this.User != null &&
                    this.User.Equals(other.User)
                ) && 
                (
                    this.Repository == other.Repository ||
                    this.Repository != null &&
                    this.Repository.Equals(other.Repository)
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
                if (this.Permission != null)
                    hash = hash * 59 + this.Permission.GetHashCode();
                if (this.User != null)
                    hash = hash * 59 + this.User.GetHashCode();
                if (this.Repository != null)
                    hash = hash * 59 + this.Repository.GetHashCode();
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
