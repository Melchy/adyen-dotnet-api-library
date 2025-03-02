using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Adyen.Model.MarketPay
{
    /// <summary>
    /// TransferFundsRequest
    /// </summary>
    [DataContract]
    public class TransferFundsRequest : IEquatable<TransferFundsRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransferFundsRequest" /> class.
        /// </summary>
        /// <param name="amount">amount (required).</param>
        /// <param name="destinationAccountCode">The code of the account to which the funds are to be credited. &gt;The state of the Account Holder of this account must be Active. (required).</param>
        /// <param name="merchantReference">A value that can be supplied at the discretion of the executing user in order to link multiple transactions to one another..</param>
        /// <param name="sourceAccountCode">The code of the account from which the funds are to be debited. &gt;The state of the Account Holder of this account must be Active and allow payouts. (required).</param>
        /// <param name="transferCode">The code related to the type of transfer being performed. &gt;The permitted codes differ for each platform account and are defined in their service level agreement. (required).</param>
        public TransferFundsRequest(Amount amount = default(Amount), string destinationAccountCode = default(string), string merchantReference = default(string), string sourceAccountCode = default(string), string transferCode = default(string))
        {
            // to ensure "amount" is required (not null)
            if (amount == null)
            {
                throw new InvalidDataException("amount is a required property for TransferFundsRequest and cannot be null");
            }

            Amount = amount;
            // to ensure "destinationAccountCode" is required (not null)
            if (destinationAccountCode == null)
            {
                throw new InvalidDataException("destinationAccountCode is a required property for TransferFundsRequest and cannot be null");
            }

            DestinationAccountCode = destinationAccountCode;
            // to ensure "sourceAccountCode" is required (not null)
            if (sourceAccountCode == null)
            {
                throw new InvalidDataException("sourceAccountCode is a required property for TransferFundsRequest and cannot be null");
            }

            SourceAccountCode = sourceAccountCode;
            // to ensure "transferCode" is required (not null)
            if (transferCode == null)
            {
                throw new InvalidDataException("transferCode is a required property for TransferFundsRequest and cannot be null");
            }

            TransferCode = transferCode;
            MerchantReference = merchantReference;
        }

        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [DataMember(Name = "amount", EmitDefaultValue = false)]
        public Amount Amount { get; set; }

        /// <summary>
        /// The code of the account to which the funds are to be credited. &gt;The state of the Account Holder of this account must be Active.
        /// </summary>
        /// <value>The code of the account to which the funds are to be credited. &gt;The state of the Account Holder of this account must be Active.</value>
        [DataMember(Name = "destinationAccountCode", EmitDefaultValue = false)]
        public string DestinationAccountCode { get; set; }

        /// <summary>
        /// A value that can be supplied at the discretion of the executing user in order to link multiple transactions to one another.
        /// </summary>
        /// <value>A value that can be supplied at the discretion of the executing user in order to link multiple transactions to one another.</value>
        [DataMember(Name = "merchantReference", EmitDefaultValue = false)]
        public string MerchantReference { get; set; }

        /// <summary>
        /// The code of the account from which the funds are to be debited. &gt;The state of the Account Holder of this account must be Active and allow payouts.
        /// </summary>
        /// <value>The code of the account from which the funds are to be debited. &gt;The state of the Account Holder of this account must be Active and allow payouts.</value>
        [DataMember(Name = "sourceAccountCode", EmitDefaultValue = false)]
        public string SourceAccountCode { get; set; }

        /// <summary>
        /// The code related to the type of transfer being performed. &gt;The permitted codes differ for each platform account and are defined in their service level agreement.
        /// </summary>
        /// <value>The code related to the type of transfer being performed. &gt;The permitted codes differ for each platform account and are defined in their service level agreement.</value>
        [DataMember(Name = "transferCode", EmitDefaultValue = false)]
        public string TransferCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransferFundsRequest {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  DestinationAccountCode: ").Append(DestinationAccountCode).Append("\n");
            sb.Append("  MerchantReference: ").Append(MerchantReference).Append("\n");
            sb.Append("  SourceAccountCode: ").Append(SourceAccountCode).Append("\n");
            sb.Append("  TransferCode: ").Append(TransferCode).Append("\n");
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
            return Equals(input as TransferFundsRequest);
        }

        /// <summary>
        /// Returns true if TransferFundsRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of TransferFundsRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransferFundsRequest input)
        {
            if (input == null)
                return false;

            return
                (
                    Amount == input.Amount ||
                    (Amount != null &&
                    Amount.Equals(input.Amount))
                ) &&
                (
                    DestinationAccountCode == input.DestinationAccountCode ||
                    (DestinationAccountCode != null &&
                    DestinationAccountCode.Equals(input.DestinationAccountCode))
                ) &&
                (
                    MerchantReference == input.MerchantReference ||
                    (MerchantReference != null &&
                    MerchantReference.Equals(input.MerchantReference))
                ) &&
                (
                    SourceAccountCode == input.SourceAccountCode ||
                    (SourceAccountCode != null &&
                    SourceAccountCode.Equals(input.SourceAccountCode))
                ) &&
                (
                    TransferCode == input.TransferCode ||
                    (TransferCode != null &&
                    TransferCode.Equals(input.TransferCode))
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
                if (Amount != null)
                    hashCode = hashCode * 59 + Amount.GetHashCode();
                if (DestinationAccountCode != null)
                    hashCode = hashCode * 59 + DestinationAccountCode.GetHashCode();
                if (MerchantReference != null)
                    hashCode = hashCode * 59 + MerchantReference.GetHashCode();
                if (SourceAccountCode != null)
                    hashCode = hashCode * 59 + SourceAccountCode.GetHashCode();
                if (TransferCode != null)
                    hashCode = hashCode * 59 + TransferCode.GetHashCode();
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
