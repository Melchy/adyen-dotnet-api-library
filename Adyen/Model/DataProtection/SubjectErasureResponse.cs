/*
* Adyen Data Protection API
*
*
* The version of the OpenAPI document: 1
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

namespace Adyen.Model.DataProtection
{
    /// <summary>
    /// SubjectErasureResponse
    /// </summary>
    [DataContract(Name = "SubjectErasureResponse")]
    public partial class SubjectErasureResponse : IEquatable<SubjectErasureResponse>, IValidatableObject
    {
        /// <summary>
        /// The result of this operation.
        /// </summary>
        /// <value>The result of this operation.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ResultEnum
        {
            /// <summary>
            /// Enum ACTIVERECURRINGTOKENEXISTS for value: ACTIVE_RECURRING_TOKEN_EXISTS
            /// </summary>
            [EnumMember(Value = "ACTIVE_RECURRING_TOKEN_EXISTS")]
            ACTIVERECURRINGTOKENEXISTS = 1,

            /// <summary>
            /// Enum ALREADYPROCESSED for value: ALREADY_PROCESSED
            /// </summary>
            [EnumMember(Value = "ALREADY_PROCESSED")]
            ALREADYPROCESSED = 2,

            /// <summary>
            /// Enum PAYMENTNOTFOUND for value: PAYMENT_NOT_FOUND
            /// </summary>
            [EnumMember(Value = "PAYMENT_NOT_FOUND")]
            PAYMENTNOTFOUND = 3,

            /// <summary>
            /// Enum SUCCESS for value: SUCCESS
            /// </summary>
            [EnumMember(Value = "SUCCESS")]
            SUCCESS = 4

        }


        /// <summary>
        /// The result of this operation.
        /// </summary>
        /// <value>The result of this operation.</value>
        [DataMember(Name = "result", EmitDefaultValue = false)]
        public ResultEnum? Result { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SubjectErasureResponse" /> class.
        /// </summary>
        /// <param name="result">The result of this operation..</param>
        public SubjectErasureResponse(ResultEnum? result = default(ResultEnum?))
        {
            this.Result = result;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SubjectErasureResponse {\n");
            sb.Append("  Result: ").Append(Result).Append("\n");
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
            return this.Equals(input as SubjectErasureResponse);
        }

        /// <summary>
        /// Returns true if SubjectErasureResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of SubjectErasureResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubjectErasureResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Result == input.Result ||
                    this.Result.Equals(input.Result)
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
                hashCode = (hashCode * 59) + this.Result.GetHashCode();
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
