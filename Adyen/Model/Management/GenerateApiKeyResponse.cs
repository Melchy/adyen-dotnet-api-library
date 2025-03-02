/*
* Management API
*
*
* The version of the OpenAPI document: 1
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

namespace Adyen.Model.Management
{
    /// <summary>
    /// GenerateApiKeyResponse
    /// </summary>
    [DataContract(Name = "GenerateApiKeyResponse")]
    public partial class GenerateApiKeyResponse : IEquatable<GenerateApiKeyResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateApiKeyResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GenerateApiKeyResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateApiKeyResponse" /> class.
        /// </summary>
        /// <param name="apiKey">The generated API key. (required).</param>
        public GenerateApiKeyResponse(string apiKey = default(string))
        {
            this.ApiKey = apiKey;
        }

        /// <summary>
        /// The generated API key.
        /// </summary>
        /// <value>The generated API key.</value>
        [DataMember(Name = "apiKey", IsRequired = false, EmitDefaultValue = false)]
        public string ApiKey { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GenerateApiKeyResponse {\n");
            sb.Append("  ApiKey: ").Append(ApiKey).Append("\n");
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
            return this.Equals(input as GenerateApiKeyResponse);
        }

        /// <summary>
        /// Returns true if GenerateApiKeyResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of GenerateApiKeyResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GenerateApiKeyResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ApiKey == input.ApiKey ||
                    (this.ApiKey != null &&
                    this.ApiKey.Equals(input.ApiKey))
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
                if (this.ApiKey != null)
                {
                    hashCode = (hashCode * 59) + this.ApiKey.GetHashCode();
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
