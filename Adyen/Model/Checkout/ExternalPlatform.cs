/*
* Adyen Checkout API
*
*
* The version of the OpenAPI document: 70
* Contact: developer-experience@adyen.com
*
* NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
* https://openapi-generator.tech
* Do not edit the class manually.
*/

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Adyen.ApiSerialization.OpenAPIDateConverter;

namespace Adyen.Model.Checkout
{
    /// <summary>
    /// ExternalPlatform
    /// </summary>
    [DataContract(Name = "ExternalPlatform")]
    public partial class ExternalPlatform : IEquatable<ExternalPlatform>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalPlatform" /> class.
        /// </summary>
        /// <param name="integrator">External platform integrator..</param>
        /// <param name="name">Name of the field. For example, Name of External Platform..</param>
        /// <param name="version">Version of the field. For example, Version of External Platform..</param>
        public ExternalPlatform(string integrator = default(string), string name = default(string), string version = default(string))
        {
            this.Integrator = integrator;
            this.Name = name;
            this.Version = version;
        }

        /// <summary>
        /// External platform integrator.
        /// </summary>
        /// <value>External platform integrator.</value>
        [DataMember(Name = "integrator", EmitDefaultValue = false)]
        public string Integrator { get; set; }

        /// <summary>
        /// Name of the field. For example, Name of External Platform.
        /// </summary>
        /// <value>Name of the field. For example, Name of External Platform.</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Version of the field. For example, Version of External Platform.
        /// </summary>
        /// <value>Version of the field. For example, Version of External Platform.</value>
        [DataMember(Name = "version", EmitDefaultValue = false)]
        public string Version { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ExternalPlatform {\n");
            sb.Append("  Integrator: ").Append(Integrator).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ExternalPlatform);
        }

        /// <summary>
        /// Returns true if ExternalPlatform instances are equal
        /// </summary>
        /// <param name="input">Instance of ExternalPlatform to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExternalPlatform input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Integrator == input.Integrator ||
                    (this.Integrator != null &&
                    this.Integrator.Equals(input.Integrator))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Integrator != null)
                {
                    hashCode = (hashCode * 59) + this.Integrator.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Version != null)
                {
                    hashCode = (hashCode * 59) + this.Version.GetHashCode();
                }
                return hashCode;
            }
        }
        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
