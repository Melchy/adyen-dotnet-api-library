/*
* Legal Entity Management API
*
*
* The version of the OpenAPI document: 3
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

namespace Adyen.Model.LegalEntityManagement
{
    /// <summary>
    /// VerificationErrors
    /// </summary>
    [DataContract(Name = "VerificationErrors")]
    public partial class VerificationErrors : IEquatable<VerificationErrors>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VerificationErrors" /> class.
        /// </summary>
        /// <param name="problems">List of the verification errors..</param>
        public VerificationErrors(List<CapabilityProblem> problems = default(List<CapabilityProblem>))
        {
            this.Problems = problems;
        }

        /// <summary>
        /// List of the verification errors.
        /// </summary>
        /// <value>List of the verification errors.</value>
        [DataMember(Name = "problems", EmitDefaultValue = false)]
        public List<CapabilityProblem> Problems { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class VerificationErrors {\n");
            sb.Append("  Problems: ").Append(Problems).Append("\n");
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
            return this.Equals(input as VerificationErrors);
        }

        /// <summary>
        /// Returns true if VerificationErrors instances are equal
        /// </summary>
        /// <param name="input">Instance of VerificationErrors to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VerificationErrors input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Problems == input.Problems ||
                    this.Problems != null &&
                    input.Problems != null &&
                    this.Problems.SequenceEqual(input.Problems)
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
                if (this.Problems != null)
                {
                    hashCode = (hashCode * 59) + this.Problems.GetHashCode();
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
