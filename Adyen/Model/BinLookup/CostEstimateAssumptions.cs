/*
* Adyen BinLookup API
*
*
* The version of the OpenAPI document: 54
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

namespace Adyen.Model.BinLookup
{
    /// <summary>
    /// CostEstimateAssumptions
    /// </summary>
    [DataContract(Name = "CostEstimateAssumptions")]
    public partial class CostEstimateAssumptions : IEquatable<CostEstimateAssumptions>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CostEstimateAssumptions" /> class.
        /// </summary>
        /// <param name="assume3DSecureAuthenticated">If true, the cardholder is expected to successfully authorise via 3D Secure..</param>
        /// <param name="assumeLevel3Data">If true, the transaction is expected to have valid Level 3 data..</param>
        /// <param name="installments">If not zero, the number of installments..</param>
        public CostEstimateAssumptions(bool assume3DSecureAuthenticated = default(bool), bool assumeLevel3Data = default(bool), int? installments = default(int?))
        {
            this.Assume3DSecureAuthenticated = assume3DSecureAuthenticated;
            this.AssumeLevel3Data = assumeLevel3Data;
            this.Installments = installments;
        }

        /// <summary>
        /// If true, the cardholder is expected to successfully authorise via 3D Secure.
        /// </summary>
        /// <value>If true, the cardholder is expected to successfully authorise via 3D Secure.</value>
        [DataMember(Name = "assume3DSecureAuthenticated", EmitDefaultValue = false)]
        public bool Assume3DSecureAuthenticated { get; set; }

        /// <summary>
        /// If true, the transaction is expected to have valid Level 3 data.
        /// </summary>
        /// <value>If true, the transaction is expected to have valid Level 3 data.</value>
        [DataMember(Name = "assumeLevel3Data", EmitDefaultValue = false)]
        public bool AssumeLevel3Data { get; set; }

        /// <summary>
        /// If not zero, the number of installments.
        /// </summary>
        /// <value>If not zero, the number of installments.</value>
        [DataMember(Name = "installments", EmitDefaultValue = false)]
        public int? Installments { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CostEstimateAssumptions {\n");
            sb.Append("  Assume3DSecureAuthenticated: ").Append(Assume3DSecureAuthenticated).Append("\n");
            sb.Append("  AssumeLevel3Data: ").Append(AssumeLevel3Data).Append("\n");
            sb.Append("  Installments: ").Append(Installments).Append("\n");
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
            return this.Equals(input as CostEstimateAssumptions);
        }

        /// <summary>
        /// Returns true if CostEstimateAssumptions instances are equal
        /// </summary>
        /// <param name="input">Instance of CostEstimateAssumptions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CostEstimateAssumptions input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Assume3DSecureAuthenticated == input.Assume3DSecureAuthenticated ||
                    this.Assume3DSecureAuthenticated.Equals(input.Assume3DSecureAuthenticated)
                ) && 
                (
                    this.AssumeLevel3Data == input.AssumeLevel3Data ||
                    this.AssumeLevel3Data.Equals(input.AssumeLevel3Data)
                ) && 
                (
                    this.Installments == input.Installments ||
                    this.Installments.Equals(input.Installments)
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
                hashCode = (hashCode * 59) + this.Assume3DSecureAuthenticated.GetHashCode();
                hashCode = (hashCode * 59) + this.AssumeLevel3Data.GetHashCode();
                hashCode = (hashCode * 59) + this.Installments.GetHashCode();
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
