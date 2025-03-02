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
    /// RepaymentTerm
    /// </summary>
    [DataContract(Name = "RepaymentTerm")]
    public partial class RepaymentTerm : IEquatable<RepaymentTerm>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RepaymentTerm" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RepaymentTerm() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RepaymentTerm" /> class.
        /// </summary>
        /// <param name="estimatedDays">The estimated term for repaying the grant, in days. (required).</param>
        /// <param name="maximumDays">The maximum term for repaying the grant, in days. Only applies when &#x60;contractType&#x60; is **loan**..</param>
        public RepaymentTerm(int? estimatedDays = default(int?), int? maximumDays = default(int?))
        {
            this.EstimatedDays = estimatedDays;
            this.MaximumDays = maximumDays;
        }

        /// <summary>
        /// The estimated term for repaying the grant, in days.
        /// </summary>
        /// <value>The estimated term for repaying the grant, in days.</value>
        [DataMember(Name = "estimatedDays", IsRequired = false, EmitDefaultValue = false)]
        public int? EstimatedDays { get; set; }

        /// <summary>
        /// The maximum term for repaying the grant, in days. Only applies when &#x60;contractType&#x60; is **loan**.
        /// </summary>
        /// <value>The maximum term for repaying the grant, in days. Only applies when &#x60;contractType&#x60; is **loan**.</value>
        [DataMember(Name = "maximumDays", EmitDefaultValue = false)]
        public int? MaximumDays { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RepaymentTerm {\n");
            sb.Append("  EstimatedDays: ").Append(EstimatedDays).Append("\n");
            sb.Append("  MaximumDays: ").Append(MaximumDays).Append("\n");
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
            return this.Equals(input as RepaymentTerm);
        }

        /// <summary>
        /// Returns true if RepaymentTerm instances are equal
        /// </summary>
        /// <param name="input">Instance of RepaymentTerm to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RepaymentTerm input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.EstimatedDays == input.EstimatedDays ||
                    this.EstimatedDays.Equals(input.EstimatedDays)
                ) && 
                (
                    this.MaximumDays == input.MaximumDays ||
                    this.MaximumDays.Equals(input.MaximumDays)
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
                hashCode = (hashCode * 59) + this.EstimatedDays.GetHashCode();
                hashCode = (hashCode * 59) + this.MaximumDays.GetHashCode();
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
