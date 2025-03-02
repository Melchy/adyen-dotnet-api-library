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
    /// ResponseAdditionalDataOpi
    /// </summary>
    [DataContract(Name = "ResponseAdditionalDataOpi")]
    public partial class ResponseAdditionalDataOpi : IEquatable<ResponseAdditionalDataOpi>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseAdditionalDataOpi" /> class.
        /// </summary>
        /// <param name="opiTransToken">Returned in the response if you included &#x60;opi.includeTransToken: true&#x60; in an ecommerce payment request. This contains an Oracle Payment Interface token that you can store in your Oracle Opera database to identify tokenized ecommerce transactions. For more information and required settings, see [Oracle Opera](https://docs.adyen.com/plugins/oracle-opera#opi-token-ecommerce)..</param>
        public ResponseAdditionalDataOpi(string opiTransToken = default(string))
        {
            this.OpiTransToken = opiTransToken;
        }

        /// <summary>
        /// Returned in the response if you included &#x60;opi.includeTransToken: true&#x60; in an ecommerce payment request. This contains an Oracle Payment Interface token that you can store in your Oracle Opera database to identify tokenized ecommerce transactions. For more information and required settings, see [Oracle Opera](https://docs.adyen.com/plugins/oracle-opera#opi-token-ecommerce).
        /// </summary>
        /// <value>Returned in the response if you included &#x60;opi.includeTransToken: true&#x60; in an ecommerce payment request. This contains an Oracle Payment Interface token that you can store in your Oracle Opera database to identify tokenized ecommerce transactions. For more information and required settings, see [Oracle Opera](https://docs.adyen.com/plugins/oracle-opera#opi-token-ecommerce).</value>
        [DataMember(Name = "opi.transToken", EmitDefaultValue = false)]
        public string OpiTransToken { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ResponseAdditionalDataOpi {\n");
            sb.Append("  OpiTransToken: ").Append(OpiTransToken).Append("\n");
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
            return this.Equals(input as ResponseAdditionalDataOpi);
        }

        /// <summary>
        /// Returns true if ResponseAdditionalDataOpi instances are equal
        /// </summary>
        /// <param name="input">Instance of ResponseAdditionalDataOpi to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ResponseAdditionalDataOpi input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.OpiTransToken == input.OpiTransToken ||
                    (this.OpiTransToken != null &&
                    this.OpiTransToken.Equals(input.OpiTransToken))
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
                if (this.OpiTransToken != null)
                {
                    hashCode = (hashCode * 59) + this.OpiTransToken.GetHashCode();
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
