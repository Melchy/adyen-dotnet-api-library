/*
* Adyen Payment API
*
*
* The version of the OpenAPI document: 68
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

namespace Adyen.Model.Payment
{
    /// <summary>
    /// AdditionalDataRiskStandalone
    /// </summary>
    [DataContract(Name = "AdditionalDataRiskStandalone")]
    public partial class AdditionalDataRiskStandalone : IEquatable<AdditionalDataRiskStandalone>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdditionalDataRiskStandalone" /> class.
        /// </summary>
        /// <param name="payPalCountryCode">Shopper&#39;s country of residence in the form of ISO standard 3166 2-character country codes..</param>
        /// <param name="payPalEmailId">Shopper&#39;s email..</param>
        /// <param name="payPalFirstName">Shopper&#39;s first name..</param>
        /// <param name="payPalLastName">Shopper&#39;s last name..</param>
        /// <param name="payPalPayerId">Unique PayPal Customer Account identification number. Character length and limitations: 13 single-byte alphanumeric characters..</param>
        /// <param name="payPalPhone">Shopper&#39;s phone number..</param>
        /// <param name="payPalProtectionEligibility">Allowed values: * **Eligible** — Merchant is protected by PayPal&#39;s Seller Protection Policy for Unauthorized Payments and Item Not Received.  * **PartiallyEligible** — Merchant is protected by PayPal&#39;s Seller Protection Policy for Item Not Received.  * **Ineligible** — Merchant is not protected under the Seller Protection Policy..</param>
        /// <param name="payPalTransactionId">Unique transaction ID of the payment..</param>
        /// <param name="avsResultRaw">Raw AVS result received from the acquirer, where available. Example: D.</param>
        /// <param name="bin">The Bank Identification Number of a credit card, which is the first six digits of a card number. Required for [tokenized card request](https://docs.adyen.com/risk-management/standalone-risk#tokenised-pan-request)..</param>
        /// <param name="cvcResultRaw">Raw CVC result received from the acquirer, where available. Example: 1.</param>
        /// <param name="riskToken">Unique identifier or token for the shopper&#39;s card details..</param>
        /// <param name="threeDAuthenticated">A Boolean value indicating whether 3DS authentication was completed on this payment. Example: true.</param>
        /// <param name="threeDOffered">A Boolean value indicating whether 3DS was offered for this payment. Example: true.</param>
        /// <param name="tokenDataType">Required for PayPal payments only. The only supported value is: **paypal**..</param>
        public AdditionalDataRiskStandalone(string payPalCountryCode = default(string), string payPalEmailId = default(string), string payPalFirstName = default(string), string payPalLastName = default(string), string payPalPayerId = default(string), string payPalPhone = default(string), string payPalProtectionEligibility = default(string), string payPalTransactionId = default(string), string avsResultRaw = default(string), string bin = default(string), string cvcResultRaw = default(string), string riskToken = default(string), string threeDAuthenticated = default(string), string threeDOffered = default(string), string tokenDataType = default(string))
        {
            this.PayPalCountryCode = payPalCountryCode;
            this.PayPalEmailId = payPalEmailId;
            this.PayPalFirstName = payPalFirstName;
            this.PayPalLastName = payPalLastName;
            this.PayPalPayerId = payPalPayerId;
            this.PayPalPhone = payPalPhone;
            this.PayPalProtectionEligibility = payPalProtectionEligibility;
            this.PayPalTransactionId = payPalTransactionId;
            this.AvsResultRaw = avsResultRaw;
            this.Bin = bin;
            this.CvcResultRaw = cvcResultRaw;
            this.RiskToken = riskToken;
            this.ThreeDAuthenticated = threeDAuthenticated;
            this.ThreeDOffered = threeDOffered;
            this.TokenDataType = tokenDataType;
        }

        /// <summary>
        /// Shopper&#39;s country of residence in the form of ISO standard 3166 2-character country codes.
        /// </summary>
        /// <value>Shopper&#39;s country of residence in the form of ISO standard 3166 2-character country codes.</value>
        [DataMember(Name = "PayPal.CountryCode", EmitDefaultValue = false)]
        public string PayPalCountryCode { get; set; }

        /// <summary>
        /// Shopper&#39;s email.
        /// </summary>
        /// <value>Shopper&#39;s email.</value>
        [DataMember(Name = "PayPal.EmailId", EmitDefaultValue = false)]
        public string PayPalEmailId { get; set; }

        /// <summary>
        /// Shopper&#39;s first name.
        /// </summary>
        /// <value>Shopper&#39;s first name.</value>
        [DataMember(Name = "PayPal.FirstName", EmitDefaultValue = false)]
        public string PayPalFirstName { get; set; }

        /// <summary>
        /// Shopper&#39;s last name.
        /// </summary>
        /// <value>Shopper&#39;s last name.</value>
        [DataMember(Name = "PayPal.LastName", EmitDefaultValue = false)]
        public string PayPalLastName { get; set; }

        /// <summary>
        /// Unique PayPal Customer Account identification number. Character length and limitations: 13 single-byte alphanumeric characters.
        /// </summary>
        /// <value>Unique PayPal Customer Account identification number. Character length and limitations: 13 single-byte alphanumeric characters.</value>
        [DataMember(Name = "PayPal.PayerId", EmitDefaultValue = false)]
        public string PayPalPayerId { get; set; }

        /// <summary>
        /// Shopper&#39;s phone number.
        /// </summary>
        /// <value>Shopper&#39;s phone number.</value>
        [DataMember(Name = "PayPal.Phone", EmitDefaultValue = false)]
        public string PayPalPhone { get; set; }

        /// <summary>
        /// Allowed values: * **Eligible** — Merchant is protected by PayPal&#39;s Seller Protection Policy for Unauthorized Payments and Item Not Received.  * **PartiallyEligible** — Merchant is protected by PayPal&#39;s Seller Protection Policy for Item Not Received.  * **Ineligible** — Merchant is not protected under the Seller Protection Policy.
        /// </summary>
        /// <value>Allowed values: * **Eligible** — Merchant is protected by PayPal&#39;s Seller Protection Policy for Unauthorized Payments and Item Not Received.  * **PartiallyEligible** — Merchant is protected by PayPal&#39;s Seller Protection Policy for Item Not Received.  * **Ineligible** — Merchant is not protected under the Seller Protection Policy.</value>
        [DataMember(Name = "PayPal.ProtectionEligibility", EmitDefaultValue = false)]
        public string PayPalProtectionEligibility { get; set; }

        /// <summary>
        /// Unique transaction ID of the payment.
        /// </summary>
        /// <value>Unique transaction ID of the payment.</value>
        [DataMember(Name = "PayPal.TransactionId", EmitDefaultValue = false)]
        public string PayPalTransactionId { get; set; }

        /// <summary>
        /// Raw AVS result received from the acquirer, where available. Example: D
        /// </summary>
        /// <value>Raw AVS result received from the acquirer, where available. Example: D</value>
        [DataMember(Name = "avsResultRaw", EmitDefaultValue = false)]
        public string AvsResultRaw { get; set; }

        /// <summary>
        /// The Bank Identification Number of a credit card, which is the first six digits of a card number. Required for [tokenized card request](https://docs.adyen.com/risk-management/standalone-risk#tokenised-pan-request).
        /// </summary>
        /// <value>The Bank Identification Number of a credit card, which is the first six digits of a card number. Required for [tokenized card request](https://docs.adyen.com/risk-management/standalone-risk#tokenised-pan-request).</value>
        [DataMember(Name = "bin", EmitDefaultValue = false)]
        public string Bin { get; set; }

        /// <summary>
        /// Raw CVC result received from the acquirer, where available. Example: 1
        /// </summary>
        /// <value>Raw CVC result received from the acquirer, where available. Example: 1</value>
        [DataMember(Name = "cvcResultRaw", EmitDefaultValue = false)]
        public string CvcResultRaw { get; set; }

        /// <summary>
        /// Unique identifier or token for the shopper&#39;s card details.
        /// </summary>
        /// <value>Unique identifier or token for the shopper&#39;s card details.</value>
        [DataMember(Name = "riskToken", EmitDefaultValue = false)]
        public string RiskToken { get; set; }

        /// <summary>
        /// A Boolean value indicating whether 3DS authentication was completed on this payment. Example: true
        /// </summary>
        /// <value>A Boolean value indicating whether 3DS authentication was completed on this payment. Example: true</value>
        [DataMember(Name = "threeDAuthenticated", EmitDefaultValue = false)]
        public string ThreeDAuthenticated { get; set; }

        /// <summary>
        /// A Boolean value indicating whether 3DS was offered for this payment. Example: true
        /// </summary>
        /// <value>A Boolean value indicating whether 3DS was offered for this payment. Example: true</value>
        [DataMember(Name = "threeDOffered", EmitDefaultValue = false)]
        public string ThreeDOffered { get; set; }

        /// <summary>
        /// Required for PayPal payments only. The only supported value is: **paypal**.
        /// </summary>
        /// <value>Required for PayPal payments only. The only supported value is: **paypal**.</value>
        [DataMember(Name = "tokenDataType", EmitDefaultValue = false)]
        public string TokenDataType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AdditionalDataRiskStandalone {\n");
            sb.Append("  PayPalCountryCode: ").Append(PayPalCountryCode).Append("\n");
            sb.Append("  PayPalEmailId: ").Append(PayPalEmailId).Append("\n");
            sb.Append("  PayPalFirstName: ").Append(PayPalFirstName).Append("\n");
            sb.Append("  PayPalLastName: ").Append(PayPalLastName).Append("\n");
            sb.Append("  PayPalPayerId: ").Append(PayPalPayerId).Append("\n");
            sb.Append("  PayPalPhone: ").Append(PayPalPhone).Append("\n");
            sb.Append("  PayPalProtectionEligibility: ").Append(PayPalProtectionEligibility).Append("\n");
            sb.Append("  PayPalTransactionId: ").Append(PayPalTransactionId).Append("\n");
            sb.Append("  AvsResultRaw: ").Append(AvsResultRaw).Append("\n");
            sb.Append("  Bin: ").Append(Bin).Append("\n");
            sb.Append("  CvcResultRaw: ").Append(CvcResultRaw).Append("\n");
            sb.Append("  RiskToken: ").Append(RiskToken).Append("\n");
            sb.Append("  ThreeDAuthenticated: ").Append(ThreeDAuthenticated).Append("\n");
            sb.Append("  ThreeDOffered: ").Append(ThreeDOffered).Append("\n");
            sb.Append("  TokenDataType: ").Append(TokenDataType).Append("\n");
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
            return this.Equals(input as AdditionalDataRiskStandalone);
        }

        /// <summary>
        /// Returns true if AdditionalDataRiskStandalone instances are equal
        /// </summary>
        /// <param name="input">Instance of AdditionalDataRiskStandalone to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AdditionalDataRiskStandalone input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.PayPalCountryCode == input.PayPalCountryCode ||
                    (this.PayPalCountryCode != null &&
                    this.PayPalCountryCode.Equals(input.PayPalCountryCode))
                ) && 
                (
                    this.PayPalEmailId == input.PayPalEmailId ||
                    (this.PayPalEmailId != null &&
                    this.PayPalEmailId.Equals(input.PayPalEmailId))
                ) && 
                (
                    this.PayPalFirstName == input.PayPalFirstName ||
                    (this.PayPalFirstName != null &&
                    this.PayPalFirstName.Equals(input.PayPalFirstName))
                ) && 
                (
                    this.PayPalLastName == input.PayPalLastName ||
                    (this.PayPalLastName != null &&
                    this.PayPalLastName.Equals(input.PayPalLastName))
                ) && 
                (
                    this.PayPalPayerId == input.PayPalPayerId ||
                    (this.PayPalPayerId != null &&
                    this.PayPalPayerId.Equals(input.PayPalPayerId))
                ) && 
                (
                    this.PayPalPhone == input.PayPalPhone ||
                    (this.PayPalPhone != null &&
                    this.PayPalPhone.Equals(input.PayPalPhone))
                ) && 
                (
                    this.PayPalProtectionEligibility == input.PayPalProtectionEligibility ||
                    (this.PayPalProtectionEligibility != null &&
                    this.PayPalProtectionEligibility.Equals(input.PayPalProtectionEligibility))
                ) && 
                (
                    this.PayPalTransactionId == input.PayPalTransactionId ||
                    (this.PayPalTransactionId != null &&
                    this.PayPalTransactionId.Equals(input.PayPalTransactionId))
                ) && 
                (
                    this.AvsResultRaw == input.AvsResultRaw ||
                    (this.AvsResultRaw != null &&
                    this.AvsResultRaw.Equals(input.AvsResultRaw))
                ) && 
                (
                    this.Bin == input.Bin ||
                    (this.Bin != null &&
                    this.Bin.Equals(input.Bin))
                ) && 
                (
                    this.CvcResultRaw == input.CvcResultRaw ||
                    (this.CvcResultRaw != null &&
                    this.CvcResultRaw.Equals(input.CvcResultRaw))
                ) && 
                (
                    this.RiskToken == input.RiskToken ||
                    (this.RiskToken != null &&
                    this.RiskToken.Equals(input.RiskToken))
                ) && 
                (
                    this.ThreeDAuthenticated == input.ThreeDAuthenticated ||
                    (this.ThreeDAuthenticated != null &&
                    this.ThreeDAuthenticated.Equals(input.ThreeDAuthenticated))
                ) && 
                (
                    this.ThreeDOffered == input.ThreeDOffered ||
                    (this.ThreeDOffered != null &&
                    this.ThreeDOffered.Equals(input.ThreeDOffered))
                ) && 
                (
                    this.TokenDataType == input.TokenDataType ||
                    (this.TokenDataType != null &&
                    this.TokenDataType.Equals(input.TokenDataType))
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
                if (this.PayPalCountryCode != null)
                {
                    hashCode = (hashCode * 59) + this.PayPalCountryCode.GetHashCode();
                }
                if (this.PayPalEmailId != null)
                {
                    hashCode = (hashCode * 59) + this.PayPalEmailId.GetHashCode();
                }
                if (this.PayPalFirstName != null)
                {
                    hashCode = (hashCode * 59) + this.PayPalFirstName.GetHashCode();
                }
                if (this.PayPalLastName != null)
                {
                    hashCode = (hashCode * 59) + this.PayPalLastName.GetHashCode();
                }
                if (this.PayPalPayerId != null)
                {
                    hashCode = (hashCode * 59) + this.PayPalPayerId.GetHashCode();
                }
                if (this.PayPalPhone != null)
                {
                    hashCode = (hashCode * 59) + this.PayPalPhone.GetHashCode();
                }
                if (this.PayPalProtectionEligibility != null)
                {
                    hashCode = (hashCode * 59) + this.PayPalProtectionEligibility.GetHashCode();
                }
                if (this.PayPalTransactionId != null)
                {
                    hashCode = (hashCode * 59) + this.PayPalTransactionId.GetHashCode();
                }
                if (this.AvsResultRaw != null)
                {
                    hashCode = (hashCode * 59) + this.AvsResultRaw.GetHashCode();
                }
                if (this.Bin != null)
                {
                    hashCode = (hashCode * 59) + this.Bin.GetHashCode();
                }
                if (this.CvcResultRaw != null)
                {
                    hashCode = (hashCode * 59) + this.CvcResultRaw.GetHashCode();
                }
                if (this.RiskToken != null)
                {
                    hashCode = (hashCode * 59) + this.RiskToken.GetHashCode();
                }
                if (this.ThreeDAuthenticated != null)
                {
                    hashCode = (hashCode * 59) + this.ThreeDAuthenticated.GetHashCode();
                }
                if (this.ThreeDOffered != null)
                {
                    hashCode = (hashCode * 59) + this.ThreeDOffered.GetHashCode();
                }
                if (this.TokenDataType != null)
                {
                    hashCode = (hashCode * 59) + this.TokenDataType.GetHashCode();
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
