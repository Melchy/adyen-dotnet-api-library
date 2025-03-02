using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Adyen.Model.MarketPay
{
    /// <summary>
    /// CreateAccountResponse
    /// </summary>
    [DataContract]
        public class CreateAccountResponse :  IEquatable<CreateAccountResponse>, IValidatableObject
    {
        /// <summary>
        /// The status of the account. &gt;Permitted values: &#x60;Active&#x60;.
        /// </summary>
        /// <value>The status of the account. &gt;Permitted values: &#x60;Active&#x60;.</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum StatusEnum
        {
            /// <summary>
            /// Enum Active for value: Active
            /// </summary>
            [EnumMember(Value = "Active")]
            Active = 1,
            /// <summary>
            /// Enum Closed for value: Closed
            /// </summary>
            [EnumMember(Value = "Closed")]
            Closed = 2,
            /// <summary>
            /// Enum Inactive for value: Inactive
            /// </summary>
            [EnumMember(Value = "Inactive")]
            Inactive = 3,
            /// <summary>
            /// Enum Suspended for value: Suspended
            /// </summary>
            [EnumMember(Value = "Suspended")]
            Suspended = 4        }
        /// <summary>
        /// The status of the account. &gt;Permitted values: &#x60;Active&#x60;.
        /// </summary>
        /// <value>The status of the account. &gt;Permitted values: &#x60;Active&#x60;.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateAccountResponse" /> class.
        /// </summary>
        /// <param name="accountCode">The code of the new account. (required).</param>
        /// <param name="accountHolderCode">The code of the account holder. (required).</param>
        /// <param name="description">The description of the account..</param>
        /// <param name="invalidFields">A list of fields that caused the &#x60;/createAccount&#x60; request to fail..</param>
        /// <param name="metadata">metadata.</param>
        /// <param name="payoutSchedule">payoutSchedule.</param>
        /// <param name="pspReference">The reference of a request.  Can be used to uniquely identify the request. (required).</param>
        /// <param name="resultCode">The result code..</param>
        /// <param name="status">The status of the account. &gt;Permitted values: &#x60;Active&#x60;. (required).</param>
        public CreateAccountResponse(string accountCode = default(string), string accountHolderCode = default(string), string description = default(string), List<ErrorFieldType> invalidFields = default(List<ErrorFieldType>), Dictionary<string, string> metadata = default(Dictionary<string, string>), PayoutScheduleResponse payoutSchedule = default(PayoutScheduleResponse), string pspReference = default(string), string resultCode = default(string), StatusEnum status = default(StatusEnum))
        {
            // to ensure "accountCode" is required (not null)
            if (accountCode == null)
            {
                throw new InvalidDataException("accountCode is a required property for CreateAccountResponse and cannot be null");
            }

            AccountCode = accountCode;
            // to ensure "accountHolderCode" is required (not null)
            if (accountHolderCode == null)
            {
                throw new InvalidDataException("accountHolderCode is a required property for CreateAccountResponse and cannot be null");
            }

            AccountHolderCode = accountHolderCode;
            // to ensure "pspReference" is required (not null)
            if (pspReference == null)
            {
                throw new InvalidDataException("pspReference is a required property for CreateAccountResponse and cannot be null");
            }

            PspReference = pspReference;

            Status = status;
            Description = description;
            InvalidFields = invalidFields;
            Metadata = metadata;
            PayoutSchedule = payoutSchedule;
            ResultCode = resultCode;
        }
        
        /// <summary>
        /// The code of the new account.
        /// </summary>
        /// <value>The code of the new account.</value>
        [DataMember(Name="accountCode", EmitDefaultValue=false)]
        public string AccountCode { get; set; }

        /// <summary>
        /// The code of the account holder.
        /// </summary>
        /// <value>The code of the account holder.</value>
        [DataMember(Name="accountHolderCode", EmitDefaultValue=false)]
        public string AccountHolderCode { get; set; }

        /// <summary>
        /// The description of the account.
        /// </summary>
        /// <value>The description of the account.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// A list of fields that caused the &#x60;/createAccount&#x60; request to fail.
        /// </summary>
        /// <value>A list of fields that caused the &#x60;/createAccount&#x60; request to fail.</value>
        [DataMember(Name="invalidFields", EmitDefaultValue=false)]
        public List<ErrorFieldType> InvalidFields { get; set; }

        /// <summary>
        /// Gets or Sets Metadata
        /// </summary>
        [DataMember(Name="metadata", EmitDefaultValue=false)]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Gets or Sets PayoutSchedule
        /// </summary>
        [DataMember(Name="payoutSchedule", EmitDefaultValue=false)]
        public PayoutScheduleResponse PayoutSchedule { get; set; }

        /// <summary>
        /// The reference of a request.  Can be used to uniquely identify the request.
        /// </summary>
        /// <value>The reference of a request.  Can be used to uniquely identify the request.</value>
        [DataMember(Name="pspReference", EmitDefaultValue=false)]
        public string PspReference { get; set; }

        /// <summary>
        /// The result code.
        /// </summary>
        /// <value>The result code.</value>
        [DataMember(Name="resultCode", EmitDefaultValue=false)]
        public string ResultCode { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateAccountResponse {\n");
            sb.Append("  AccountCode: ").Append(AccountCode).Append("\n");
            sb.Append("  AccountHolderCode: ").Append(AccountHolderCode).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  InvalidFields: ").Append(InvalidFields).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  PayoutSchedule: ").Append(PayoutSchedule).Append("\n");
            sb.Append("  PspReference: ").Append(PspReference).Append("\n");
            sb.Append("  ResultCode: ").Append(ResultCode).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return Equals(input as CreateAccountResponse);
        }

        /// <summary>
        /// Returns true if CreateAccountResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateAccountResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateAccountResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    AccountCode == input.AccountCode ||
                    (AccountCode != null &&
                    AccountCode.Equals(input.AccountCode))
                ) && 
                (
                    AccountHolderCode == input.AccountHolderCode ||
                    (AccountHolderCode != null &&
                    AccountHolderCode.Equals(input.AccountHolderCode))
                ) && 
                (
                    Description == input.Description ||
                    (Description != null &&
                    Description.Equals(input.Description))
                ) && 
                (
                    InvalidFields == input.InvalidFields ||
                    InvalidFields != null &&
                    input.InvalidFields != null &&
                    InvalidFields.SequenceEqual(input.InvalidFields)
                ) && 
                (
                    Metadata == input.Metadata ||
                    Metadata != null &&
                    input.Metadata != null &&
                    Metadata.SequenceEqual(input.Metadata)
                ) && 
                (
                    PayoutSchedule == input.PayoutSchedule ||
                    (PayoutSchedule != null &&
                    PayoutSchedule.Equals(input.PayoutSchedule))
                ) && 
                (
                    PspReference == input.PspReference ||
                    (PspReference != null &&
                    PspReference.Equals(input.PspReference))
                ) && 
                (
                    ResultCode == input.ResultCode ||
                    (ResultCode != null &&
                    ResultCode.Equals(input.ResultCode))
                ) && 
                (
                    Status == input.Status ||
                    Status.Equals(input.Status)
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
                if (AccountCode != null)
                    hashCode = hashCode * 59 + AccountCode.GetHashCode();
                if (AccountHolderCode != null)
                    hashCode = hashCode * 59 + AccountHolderCode.GetHashCode();
                if (Description != null)
                    hashCode = hashCode * 59 + Description.GetHashCode();
                if (InvalidFields != null)
                    hashCode = hashCode * 59 + InvalidFields.GetHashCode();
                if (Metadata != null)
                    hashCode = hashCode * 59 + Metadata.GetHashCode();
                if (PayoutSchedule != null)
                    hashCode = hashCode * 59 + PayoutSchedule.GetHashCode();
                if (PspReference != null)
                    hashCode = hashCode * 59 + PspReference.GetHashCode();
                if (ResultCode != null)
                    hashCode = hashCode * 59 + ResultCode.GetHashCode();
                hashCode = hashCode * 59 + Status.GetHashCode();
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
