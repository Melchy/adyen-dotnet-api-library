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
    /// Split
    /// </summary>
    [DataContract(Name = "Split")]
    public partial class Split : IEquatable<Split>, IValidatableObject
    {
        /// <summary>
        /// The type of split. Possible values: **Default**, **PaymentFee**, **VAT**, **Commission**, **MarketPlace**, **BalanceAccount**, **Remainder**, **Surcharge**, **Tip**.
        /// </summary>
        /// <value>The type of split. Possible values: **Default**, **PaymentFee**, **VAT**, **Commission**, **MarketPlace**, **BalanceAccount**, **Remainder**, **Surcharge**, **Tip**.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum BalanceAccount for value: BalanceAccount
            /// </summary>
            [EnumMember(Value = "BalanceAccount")]
            BalanceAccount = 1,

            /// <summary>
            /// Enum Commission for value: Commission
            /// </summary>
            [EnumMember(Value = "Commission")]
            Commission = 2,

            /// <summary>
            /// Enum Default for value: Default
            /// </summary>
            [EnumMember(Value = "Default")]
            Default = 3,

            /// <summary>
            /// Enum MarketPlace for value: MarketPlace
            /// </summary>
            [EnumMember(Value = "MarketPlace")]
            MarketPlace = 4,

            /// <summary>
            /// Enum PaymentFee for value: PaymentFee
            /// </summary>
            [EnumMember(Value = "PaymentFee")]
            PaymentFee = 5,

            /// <summary>
            /// Enum Remainder for value: Remainder
            /// </summary>
            [EnumMember(Value = "Remainder")]
            Remainder = 6,

            /// <summary>
            /// Enum Surcharge for value: Surcharge
            /// </summary>
            [EnumMember(Value = "Surcharge")]
            Surcharge = 7,

            /// <summary>
            /// Enum Tip for value: Tip
            /// </summary>
            [EnumMember(Value = "Tip")]
            Tip = 8,

            /// <summary>
            /// Enum VAT for value: VAT
            /// </summary>
            [EnumMember(Value = "VAT")]
            VAT = 9,

            /// <summary>
            /// Enum Verification for value: Verification
            /// </summary>
            [EnumMember(Value = "Verification")]
            Verification = 10

        }


        /// <summary>
        /// The type of split. Possible values: **Default**, **PaymentFee**, **VAT**, **Commission**, **MarketPlace**, **BalanceAccount**, **Remainder**, **Surcharge**, **Tip**.
        /// </summary>
        /// <value>The type of split. Possible values: **Default**, **PaymentFee**, **VAT**, **Commission**, **MarketPlace**, **BalanceAccount**, **Remainder**, **Surcharge**, **Tip**.</value>
        [DataMember(Name = "type", IsRequired = false, EmitDefaultValue = false)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Split" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Split() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Split" /> class.
        /// </summary>
        /// <param name="account">Unique identifier of the account where the split amount should be sent. This is required if &#x60;type&#x60; is **MarketPlace** or **BalanceAccount**.  .</param>
        /// <param name="amount">amount (required).</param>
        /// <param name="description">A description of this split..</param>
        /// <param name="reference">Your reference for the split, which you can use to link the split to other operations such as captures and refunds.  This is required if &#x60;type&#x60; is **MarketPlace** or **BalanceAccount**. For the other types, we also recommend sending a reference so you can reconcile the split and the associated payment in the transaction overview and in the reports. If the reference is not provided, the split is reported as part of the aggregated [TransferBalance record type](https://docs.adyen.com/reporting/marketpay-payments-accounting-report) in Adyen for Platforms..</param>
        /// <param name="type">The type of split. Possible values: **Default**, **PaymentFee**, **VAT**, **Commission**, **MarketPlace**, **BalanceAccount**, **Remainder**, **Surcharge**, **Tip**. (required).</param>
        public Split(string account = default(string), SplitAmount amount = default(SplitAmount), string description = default(string), string reference = default(string), TypeEnum type = default(TypeEnum))
        {
            this.Amount = amount;
            this.Type = type;
            this.Account = account;
            this.Description = description;
            this.Reference = reference;
        }

        /// <summary>
        /// Unique identifier of the account where the split amount should be sent. This is required if &#x60;type&#x60; is **MarketPlace** or **BalanceAccount**.  
        /// </summary>
        /// <value>Unique identifier of the account where the split amount should be sent. This is required if &#x60;type&#x60; is **MarketPlace** or **BalanceAccount**.  </value>
        [DataMember(Name = "account", EmitDefaultValue = false)]
        public string Account { get; set; }

        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [DataMember(Name = "amount", IsRequired = false, EmitDefaultValue = false)]
        public SplitAmount Amount { get; set; }

        /// <summary>
        /// A description of this split.
        /// </summary>
        /// <value>A description of this split.</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Your reference for the split, which you can use to link the split to other operations such as captures and refunds.  This is required if &#x60;type&#x60; is **MarketPlace** or **BalanceAccount**. For the other types, we also recommend sending a reference so you can reconcile the split and the associated payment in the transaction overview and in the reports. If the reference is not provided, the split is reported as part of the aggregated [TransferBalance record type](https://docs.adyen.com/reporting/marketpay-payments-accounting-report) in Adyen for Platforms.
        /// </summary>
        /// <value>Your reference for the split, which you can use to link the split to other operations such as captures and refunds.  This is required if &#x60;type&#x60; is **MarketPlace** or **BalanceAccount**. For the other types, we also recommend sending a reference so you can reconcile the split and the associated payment in the transaction overview and in the reports. If the reference is not provided, the split is reported as part of the aggregated [TransferBalance record type](https://docs.adyen.com/reporting/marketpay-payments-accounting-report) in Adyen for Platforms.</value>
        [DataMember(Name = "reference", EmitDefaultValue = false)]
        public string Reference { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Split {\n");
            sb.Append("  Account: ").Append(Account).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as Split);
        }

        /// <summary>
        /// Returns true if Split instances are equal
        /// </summary>
        /// <param name="input">Instance of Split to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Split input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Account == input.Account ||
                    (this.Account != null &&
                    this.Account.Equals(input.Account))
                ) && 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Reference == input.Reference ||
                    (this.Reference != null &&
                    this.Reference.Equals(input.Reference))
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
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
                if (this.Account != null)
                {
                    hashCode = (hashCode * 59) + this.Account.GetHashCode();
                }
                if (this.Amount != null)
                {
                    hashCode = (hashCode * 59) + this.Amount.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.Reference != null)
                {
                    hashCode = (hashCode * 59) + this.Reference.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
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
