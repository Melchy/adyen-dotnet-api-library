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
    /// DifferentCurrenciesRestriction
    /// </summary>
    [DataContract(Name = "DifferentCurrenciesRestriction")]
    public partial class DifferentCurrenciesRestriction : IEquatable<DifferentCurrenciesRestriction>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DifferentCurrenciesRestriction" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DifferentCurrenciesRestriction() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DifferentCurrenciesRestriction" /> class.
        /// </summary>
        /// <param name="operation">Defines how the condition must be evaluated. (required).</param>
        /// <param name="value">Checks the currency of the payment against the currency of the payment instrument.  Possible values:  - **true**: The currency of the payment is different from the currency of the payment instrument.  - **false**: The currencies are the same.  .</param>
        public DifferentCurrenciesRestriction(string operation = default(string), bool value = default(bool))
        {
            this.Operation = operation;
            this.Value = value;
        }

        /// <summary>
        /// Defines how the condition must be evaluated.
        /// </summary>
        /// <value>Defines how the condition must be evaluated.</value>
        [DataMember(Name = "operation", IsRequired = false, EmitDefaultValue = false)]
        public string Operation { get; set; }

        /// <summary>
        /// Checks the currency of the payment against the currency of the payment instrument.  Possible values:  - **true**: The currency of the payment is different from the currency of the payment instrument.  - **false**: The currencies are the same.  
        /// </summary>
        /// <value>Checks the currency of the payment against the currency of the payment instrument.  Possible values:  - **true**: The currency of the payment is different from the currency of the payment instrument.  - **false**: The currencies are the same.  </value>
        [DataMember(Name = "value", EmitDefaultValue = false)]
        public bool Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DifferentCurrenciesRestriction {\n");
            sb.Append("  Operation: ").Append(Operation).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return this.Equals(input as DifferentCurrenciesRestriction);
        }

        /// <summary>
        /// Returns true if DifferentCurrenciesRestriction instances are equal
        /// </summary>
        /// <param name="input">Instance of DifferentCurrenciesRestriction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DifferentCurrenciesRestriction input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Operation == input.Operation ||
                    (this.Operation != null &&
                    this.Operation.Equals(input.Operation))
                ) && 
                (
                    this.Value == input.Value ||
                    this.Value.Equals(input.Value)
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
                if (this.Operation != null)
                {
                    hashCode = (hashCode * 59) + this.Operation.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Value.GetHashCode();
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
