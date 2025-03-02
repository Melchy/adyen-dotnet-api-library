using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Adyen.Model.MarketPay
{
    /// <summary>
    /// IndividualDetails
    /// </summary>
    [DataContract]
        public class IndividualDetails :  IEquatable<IndividualDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IndividualDetails" /> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="personalData">personalData.</param>
        public IndividualDetails(ViasName name = default(ViasName), ViasPersonalData personalData = default(ViasPersonalData))
        {
            Name = name;
            PersonalData = personalData;
        }
        
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public ViasName Name { get; set; }

        /// <summary>
        /// Gets or Sets PersonalData
        /// </summary>
        [DataMember(Name="personalData", EmitDefaultValue=false)]
        public ViasPersonalData PersonalData { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IndividualDetails {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  PersonalData: ").Append(PersonalData).Append("\n");
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
            return Equals(input as IndividualDetails);
        }

        /// <summary>
        /// Returns true if IndividualDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of IndividualDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IndividualDetails input)
        {
            if (input == null)
                return false;

            return 
                (
                    Name == input.Name ||
                    (Name != null &&
                    Name.Equals(input.Name))
                ) && 
                (
                    PersonalData == input.PersonalData ||
                    (PersonalData != null &&
                    PersonalData.Equals(input.PersonalData))
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
                if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                if (PersonalData != null)
                    hashCode = hashCode * 59 + PersonalData.GetHashCode();
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
