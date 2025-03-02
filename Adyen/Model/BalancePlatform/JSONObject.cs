/*
* Configuration API
*
*
* The version of the OpenAPI document: 2
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

namespace Adyen.Model.BalancePlatform
{
    /// <summary>
    /// JSONObject
    /// </summary>
    [DataContract(Name = "JSONObject")]
    public partial class JSONObject : IEquatable<JSONObject>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JSONObject" /> class.
        /// </summary>
        /// <param name="paths">paths.</param>
        /// <param name="rootPath">rootPath.</param>
        public JSONObject(List<JSONPath> paths = default(List<JSONPath>), JSONPath rootPath = default(JSONPath))
        {
            this.Paths = paths;
            this.RootPath = rootPath;
        }

        /// <summary>
        /// Gets or Sets Paths
        /// </summary>
        [DataMember(Name = "paths", EmitDefaultValue = false)]
        public List<JSONPath> Paths { get; set; }

        /// <summary>
        /// Gets or Sets RootPath
        /// </summary>
        [DataMember(Name = "rootPath", EmitDefaultValue = false)]
        public JSONPath RootPath { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class JSONObject {\n");
            sb.Append("  Paths: ").Append(Paths).Append("\n");
            sb.Append("  RootPath: ").Append(RootPath).Append("\n");
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
            return this.Equals(input as JSONObject);
        }

        /// <summary>
        /// Returns true if JSONObject instances are equal
        /// </summary>
        /// <param name="input">Instance of JSONObject to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JSONObject input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Paths == input.Paths ||
                    this.Paths != null &&
                    input.Paths != null &&
                    this.Paths.SequenceEqual(input.Paths)
                ) && 
                (
                    this.RootPath == input.RootPath ||
                    (this.RootPath != null &&
                    this.RootPath.Equals(input.RootPath))
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
                if (this.Paths != null)
                {
                    hashCode = (hashCode * 59) + this.Paths.GetHashCode();
                }
                if (this.RootPath != null)
                {
                    hashCode = (hashCode * 59) + this.RootPath.GetHashCode();
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
