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
    /// DetailsRequest
    /// </summary>
    [DataContract(Name = "DetailsRequest")]
    public partial class DetailsRequest : IEquatable<DetailsRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DetailsRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DetailsRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DetailsRequest" /> class.
        /// </summary>
        /// <param name="authenticationData">authenticationData.</param>
        /// <param name="details">details (required).</param>
        /// <param name="paymentData">The &#x60;paymentData&#x60; value from the &#x60;/payments&#x60; response. Required if the &#x60;/payments&#x60; response returns this value. .</param>
        /// <param name="threeDSAuthenticationOnly">Change the &#x60;authenticationOnly&#x60; indicator originally set in the &#x60;/payments&#x60; request. Only needs to be set if you want to modify the value set previously..</param>
        public DetailsRequest(DetailsRequestAuthenticationData authenticationData = default(DetailsRequestAuthenticationData), PaymentCompletionDetails details = default(PaymentCompletionDetails), string paymentData = default(string), bool threeDSAuthenticationOnly = default(bool))
        {
            this.Details = details;
            this.AuthenticationData = authenticationData;
            this.PaymentData = paymentData;
            this.ThreeDSAuthenticationOnly = threeDSAuthenticationOnly;
        }

        /// <summary>
        /// Gets or Sets AuthenticationData
        /// </summary>
        [DataMember(Name = "authenticationData", EmitDefaultValue = false)]
        public DetailsRequestAuthenticationData AuthenticationData { get; set; }

        /// <summary>
        /// Gets or Sets Details
        /// </summary>
        [DataMember(Name = "details", IsRequired = false, EmitDefaultValue = false)]
        public PaymentCompletionDetails Details { get; set; }

        /// <summary>
        /// The &#x60;paymentData&#x60; value from the &#x60;/payments&#x60; response. Required if the &#x60;/payments&#x60; response returns this value. 
        /// </summary>
        /// <value>The &#x60;paymentData&#x60; value from the &#x60;/payments&#x60; response. Required if the &#x60;/payments&#x60; response returns this value. </value>
        [DataMember(Name = "paymentData", EmitDefaultValue = false)]
        public string PaymentData { get; set; }

        /// <summary>
        /// Change the &#x60;authenticationOnly&#x60; indicator originally set in the &#x60;/payments&#x60; request. Only needs to be set if you want to modify the value set previously.
        /// </summary>
        /// <value>Change the &#x60;authenticationOnly&#x60; indicator originally set in the &#x60;/payments&#x60; request. Only needs to be set if you want to modify the value set previously.</value>
        [DataMember(Name = "threeDSAuthenticationOnly", EmitDefaultValue = false)]
        [Obsolete]
        public bool ThreeDSAuthenticationOnly { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DetailsRequest {\n");
            sb.Append("  AuthenticationData: ").Append(AuthenticationData).Append("\n");
            sb.Append("  Details: ").Append(Details).Append("\n");
            sb.Append("  PaymentData: ").Append(PaymentData).Append("\n");
            sb.Append("  ThreeDSAuthenticationOnly: ").Append(ThreeDSAuthenticationOnly).Append("\n");
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
            return this.Equals(input as DetailsRequest);
        }

        /// <summary>
        /// Returns true if DetailsRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of DetailsRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DetailsRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AuthenticationData == input.AuthenticationData ||
                    (this.AuthenticationData != null &&
                    this.AuthenticationData.Equals(input.AuthenticationData))
                ) && 
                (
                    this.Details == input.Details ||
                    (this.Details != null &&
                    this.Details.Equals(input.Details))
                ) && 
                (
                    this.PaymentData == input.PaymentData ||
                    (this.PaymentData != null &&
                    this.PaymentData.Equals(input.PaymentData))
                ) && 
                (
                    this.ThreeDSAuthenticationOnly == input.ThreeDSAuthenticationOnly ||
                    this.ThreeDSAuthenticationOnly.Equals(input.ThreeDSAuthenticationOnly)
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
                if (this.AuthenticationData != null)
                {
                    hashCode = (hashCode * 59) + this.AuthenticationData.GetHashCode();
                }
                if (this.Details != null)
                {
                    hashCode = (hashCode * 59) + this.Details.GetHashCode();
                }
                if (this.PaymentData != null)
                {
                    hashCode = (hashCode * 59) + this.PaymentData.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ThreeDSAuthenticationOnly.GetHashCode();
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
            // PaymentData (string) maxLength
            if (this.PaymentData != null && this.PaymentData.Length > 100000)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PaymentData, length must be less than 100000.", new [] { "PaymentData" });
            }

            yield break;
        }
    }

}
