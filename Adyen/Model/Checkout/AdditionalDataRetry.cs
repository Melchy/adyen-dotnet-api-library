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
    /// AdditionalDataRetry
    /// </summary>
    [DataContract(Name = "AdditionalDataRetry")]
    public partial class AdditionalDataRetry : IEquatable<AdditionalDataRetry>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdditionalDataRetry" /> class.
        /// </summary>
        /// <param name="retryChainAttemptNumber">The number of times the transaction (not order) has been retried between different payment service providers. For instance, the &#x60;chainAttemptNumber&#x60; set to 2 means that this transaction has been recently tried on another provider before being sent to Adyen.  &gt; If you submit &#x60;retry.chainAttemptNumber&#x60;, &#x60;retry.orderAttemptNumber&#x60;, and &#x60;retry.skipRetry&#x60; values, we also recommend you provide the &#x60;merchantOrderReference&#x60; to facilitate linking payment attempts together..</param>
        /// <param name="retryOrderAttemptNumber">The index of the attempt to bill a particular order, which is identified by the &#x60;merchantOrderReference&#x60; field. For example, if a recurring transaction fails and is retried one day later, then the order number for these attempts would be 1 and 2, respectively.  &gt; If you submit &#x60;retry.chainAttemptNumber&#x60;, &#x60;retry.orderAttemptNumber&#x60;, and &#x60;retry.skipRetry&#x60; values, we also recommend you provide the &#x60;merchantOrderReference&#x60; to facilitate linking payment attempts together..</param>
        /// <param name="retrySkipRetry">The Boolean value indicating whether Adyen should skip or retry this transaction, if possible.  &gt; If you submit &#x60;retry.chainAttemptNumber&#x60;, &#x60;retry.orderAttemptNumber&#x60;, and &#x60;retry.skipRetry&#x60; values, we also recommend you provide the &#x60;merchantOrderReference&#x60; to facilitate linking payment attempts together..</param>
        public AdditionalDataRetry(string retryChainAttemptNumber = default(string), string retryOrderAttemptNumber = default(string), string retrySkipRetry = default(string))
        {
            this.RetryChainAttemptNumber = retryChainAttemptNumber;
            this.RetryOrderAttemptNumber = retryOrderAttemptNumber;
            this.RetrySkipRetry = retrySkipRetry;
        }

        /// <summary>
        /// The number of times the transaction (not order) has been retried between different payment service providers. For instance, the &#x60;chainAttemptNumber&#x60; set to 2 means that this transaction has been recently tried on another provider before being sent to Adyen.  &gt; If you submit &#x60;retry.chainAttemptNumber&#x60;, &#x60;retry.orderAttemptNumber&#x60;, and &#x60;retry.skipRetry&#x60; values, we also recommend you provide the &#x60;merchantOrderReference&#x60; to facilitate linking payment attempts together.
        /// </summary>
        /// <value>The number of times the transaction (not order) has been retried between different payment service providers. For instance, the &#x60;chainAttemptNumber&#x60; set to 2 means that this transaction has been recently tried on another provider before being sent to Adyen.  &gt; If you submit &#x60;retry.chainAttemptNumber&#x60;, &#x60;retry.orderAttemptNumber&#x60;, and &#x60;retry.skipRetry&#x60; values, we also recommend you provide the &#x60;merchantOrderReference&#x60; to facilitate linking payment attempts together.</value>
        [DataMember(Name = "retry.chainAttemptNumber", EmitDefaultValue = false)]
        public string RetryChainAttemptNumber { get; set; }

        /// <summary>
        /// The index of the attempt to bill a particular order, which is identified by the &#x60;merchantOrderReference&#x60; field. For example, if a recurring transaction fails and is retried one day later, then the order number for these attempts would be 1 and 2, respectively.  &gt; If you submit &#x60;retry.chainAttemptNumber&#x60;, &#x60;retry.orderAttemptNumber&#x60;, and &#x60;retry.skipRetry&#x60; values, we also recommend you provide the &#x60;merchantOrderReference&#x60; to facilitate linking payment attempts together.
        /// </summary>
        /// <value>The index of the attempt to bill a particular order, which is identified by the &#x60;merchantOrderReference&#x60; field. For example, if a recurring transaction fails and is retried one day later, then the order number for these attempts would be 1 and 2, respectively.  &gt; If you submit &#x60;retry.chainAttemptNumber&#x60;, &#x60;retry.orderAttemptNumber&#x60;, and &#x60;retry.skipRetry&#x60; values, we also recommend you provide the &#x60;merchantOrderReference&#x60; to facilitate linking payment attempts together.</value>
        [DataMember(Name = "retry.orderAttemptNumber", EmitDefaultValue = false)]
        public string RetryOrderAttemptNumber { get; set; }

        /// <summary>
        /// The Boolean value indicating whether Adyen should skip or retry this transaction, if possible.  &gt; If you submit &#x60;retry.chainAttemptNumber&#x60;, &#x60;retry.orderAttemptNumber&#x60;, and &#x60;retry.skipRetry&#x60; values, we also recommend you provide the &#x60;merchantOrderReference&#x60; to facilitate linking payment attempts together.
        /// </summary>
        /// <value>The Boolean value indicating whether Adyen should skip or retry this transaction, if possible.  &gt; If you submit &#x60;retry.chainAttemptNumber&#x60;, &#x60;retry.orderAttemptNumber&#x60;, and &#x60;retry.skipRetry&#x60; values, we also recommend you provide the &#x60;merchantOrderReference&#x60; to facilitate linking payment attempts together.</value>
        [DataMember(Name = "retry.skipRetry", EmitDefaultValue = false)]
        public string RetrySkipRetry { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AdditionalDataRetry {\n");
            sb.Append("  RetryChainAttemptNumber: ").Append(RetryChainAttemptNumber).Append("\n");
            sb.Append("  RetryOrderAttemptNumber: ").Append(RetryOrderAttemptNumber).Append("\n");
            sb.Append("  RetrySkipRetry: ").Append(RetrySkipRetry).Append("\n");
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
            return this.Equals(input as AdditionalDataRetry);
        }

        /// <summary>
        /// Returns true if AdditionalDataRetry instances are equal
        /// </summary>
        /// <param name="input">Instance of AdditionalDataRetry to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AdditionalDataRetry input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.RetryChainAttemptNumber == input.RetryChainAttemptNumber ||
                    (this.RetryChainAttemptNumber != null &&
                    this.RetryChainAttemptNumber.Equals(input.RetryChainAttemptNumber))
                ) && 
                (
                    this.RetryOrderAttemptNumber == input.RetryOrderAttemptNumber ||
                    (this.RetryOrderAttemptNumber != null &&
                    this.RetryOrderAttemptNumber.Equals(input.RetryOrderAttemptNumber))
                ) && 
                (
                    this.RetrySkipRetry == input.RetrySkipRetry ||
                    (this.RetrySkipRetry != null &&
                    this.RetrySkipRetry.Equals(input.RetrySkipRetry))
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
                if (this.RetryChainAttemptNumber != null)
                {
                    hashCode = (hashCode * 59) + this.RetryChainAttemptNumber.GetHashCode();
                }
                if (this.RetryOrderAttemptNumber != null)
                {
                    hashCode = (hashCode * 59) + this.RetryOrderAttemptNumber.GetHashCode();
                }
                if (this.RetrySkipRetry != null)
                {
                    hashCode = (hashCode * 59) + this.RetrySkipRetry.GetHashCode();
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
