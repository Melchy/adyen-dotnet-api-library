using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Adyen.Model.MarketPay
{
    /// <summary>
    /// ErrorFieldType
    /// </summary>
    [DataContract]
    public class ErrorFieldType : IEquatable<ErrorFieldType>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorFieldType" /> class.
        /// </summary>
        /// <param name="errorCode">The validation error code..</param>
        /// <param name="errorDescription">A description of the validation error..</param>
        /// <param name="fieldType">fieldType.</param>
        public ErrorFieldType(int? errorCode = default(int?), string errorDescription = default(string), FieldType fieldType = default(FieldType))
        {
            ErrorCode = errorCode;
            ErrorDescription = errorDescription;
            FieldType = fieldType;
        }

        /// <summary>
        /// The validation error code.
        /// </summary>
        /// <value>The validation error code.</value>
        [DataMember(Name = "errorCode", EmitDefaultValue = false)]
        public int? ErrorCode { get; set; }

        /// <summary>
        /// A description of the validation error.
        /// </summary>
        /// <value>A description of the validation error.</value>
        [DataMember(Name = "errorDescription", EmitDefaultValue = false)]
        public string ErrorDescription { get; set; }

        /// <summary>
        /// Gets or Sets FieldType
        /// </summary>
        [DataMember(Name = "fieldType", EmitDefaultValue = false)]
        public FieldType FieldType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ErrorFieldType {\n");
            sb.Append("  ErrorCode: ").Append(ErrorCode).Append("\n");
            sb.Append("  ErrorDescription: ").Append(ErrorDescription).Append("\n");
            sb.Append("  FieldType: ").Append(FieldType).Append("\n");
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
            return Equals(input as ErrorFieldType);
        }

        /// <summary>
        /// Returns true if ErrorFieldType instances are equal
        /// </summary>
        /// <param name="input">Instance of ErrorFieldType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ErrorFieldType input)
        {
            if (input == null)
                return false;

            return
                (
                    ErrorCode == input.ErrorCode ||
                    (ErrorCode != null &&
                    ErrorCode.Equals(input.ErrorCode))
                ) &&
                (
                    ErrorDescription == input.ErrorDescription ||
                    (ErrorDescription != null &&
                    ErrorDescription.Equals(input.ErrorDescription))
                ) &&
                (
                    FieldType == input.FieldType ||
                    (FieldType != null &&
                    FieldType.Equals(input.FieldType))
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
                if (ErrorCode != null)
                    hashCode = hashCode * 59 + ErrorCode.GetHashCode();
                if (ErrorDescription != null)
                    hashCode = hashCode * 59 + ErrorDescription.GetHashCode();
                if (FieldType != null)
                    hashCode = hashCode * 59 + FieldType.GetHashCode();
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
