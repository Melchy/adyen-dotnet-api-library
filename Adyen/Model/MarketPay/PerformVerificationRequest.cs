using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Adyen.Model.MarketPay
{
    /// <summary>
    /// PerformVerificationRequest
    /// </summary>
    [DataContract]
        public class PerformVerificationRequest :  IEquatable<PerformVerificationRequest>, IValidatableObject
    {
        /// <summary>
        /// The state required for the account holder. &gt; Permitted values: &#x60;Processing&#x60;, &#x60;Payout&#x60;.
        /// </summary>
        /// <value>The state required for the account holder. &gt; Permitted values: &#x60;Processing&#x60;, &#x60;Payout&#x60;.</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum AccountStateTypeEnum
        {
            /// <summary>
            /// Enum LimitedPayout for value: LimitedPayout
            /// </summary>
            [EnumMember(Value = "LimitedPayout")]
            LimitedPayout = 1,
            /// <summary>
            /// Enum LimitedProcessing for value: LimitedProcessing
            /// </summary>
            [EnumMember(Value = "LimitedProcessing")]
            LimitedProcessing = 2,
            /// <summary>
            /// Enum LimitlessPayout for value: LimitlessPayout
            /// </summary>
            [EnumMember(Value = "LimitlessPayout")]
            LimitlessPayout = 3,
            /// <summary>
            /// Enum LimitlessProcessing for value: LimitlessProcessing
            /// </summary>
            [EnumMember(Value = "LimitlessProcessing")]
            LimitlessProcessing = 4,
            /// <summary>
            /// Enum Payout for value: Payout
            /// </summary>
            [EnumMember(Value = "Payout")]
            Payout = 5,
            /// <summary>
            /// Enum Processing for value: Processing
            /// </summary>
            [EnumMember(Value = "Processing")]
            Processing = 6        }
        /// <summary>
        /// The state required for the account holder. &gt; Permitted values: &#x60;Processing&#x60;, &#x60;Payout&#x60;.
        /// </summary>
        /// <value>The state required for the account holder. &gt; Permitted values: &#x60;Processing&#x60;, &#x60;Payout&#x60;.</value>
        [DataMember(Name="accountStateType", EmitDefaultValue=false)]
        public AccountStateTypeEnum AccountStateType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PerformVerificationRequest" /> class.
        /// </summary>
        /// <param name="accountHolderCode">The code of the account holder to verify. (required).</param>
        /// <param name="accountStateType">The state required for the account holder. &gt; Permitted values: &#x60;Processing&#x60;, &#x60;Payout&#x60;. (required).</param>
        /// <param name="tier">The tier required for the account holder. (required).</param>
        public PerformVerificationRequest(string accountHolderCode = default(string), AccountStateTypeEnum accountStateType = default(AccountStateTypeEnum), int? tier = default(int?))
        {
            // to ensure "accountHolderCode" is required (not null)
            if (accountHolderCode == null)
            {
                throw new InvalidDataException("accountHolderCode is a required property for PerformVerificationRequest and cannot be null");
            }

            AccountHolderCode = accountHolderCode;
            // to ensure "tier" is required (not null)
            if (tier == null)
            {
                throw new InvalidDataException("tier is a required property for PerformVerificationRequest and cannot be null");
            }

            Tier = tier;
            AccountStateType = accountStateType;
        }

        /// <summary>
        /// The code of the account holder to verify.
        /// </summary>
        /// <value>The code of the account holder to verify.</value>
        [DataMember(Name="accountHolderCode", EmitDefaultValue=false)]
        public string AccountHolderCode { get; set; }


        /// <summary>
        /// The tier required for the account holder.
        /// </summary>
        /// <value>The tier required for the account holder.</value>
        [DataMember(Name="tier", EmitDefaultValue=false)]
        public int? Tier { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PerformVerificationRequest {\n");
            sb.Append("  AccountHolderCode: ").Append(AccountHolderCode).Append("\n");
            sb.Append("  AccountStateType: ").Append(AccountStateType).Append("\n");
            sb.Append("  Tier: ").Append(Tier).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return Equals(input as PerformVerificationRequest);
        }

        /// <summary>
        /// Returns true if PerformVerificationRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of PerformVerificationRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PerformVerificationRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    AccountHolderCode == input.AccountHolderCode ||
                    (AccountHolderCode != null &&
                    AccountHolderCode.Equals(input.AccountHolderCode))
                ) && 
                (
                    AccountStateType == input.AccountStateType ||
                    AccountStateType.Equals(input.AccountStateType)
                ) && 
                (
                    Tier == input.Tier ||
                    (Tier != null &&
                    Tier.Equals(input.Tier))
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
                if (AccountHolderCode != null)
                    hashCode = hashCode * 59 + AccountHolderCode.GetHashCode();
                hashCode = hashCode * 59 + AccountStateType.GetHashCode();
                if (Tier != null)
                    hashCode = hashCode * 59 + Tier.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
