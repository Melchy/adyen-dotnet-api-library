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
    /// PciSigningResponse
    /// </summary>
    [DataContract(Name = "PciSigningResponse")]
    public partial class PciSigningResponse : IEquatable<PciSigningResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PciSigningResponse" /> class.
        /// </summary>
        /// <param name="pciQuestionnaireIds">The unique identifiers of the signed PCI documents..</param>
        /// <param name="signedBy">The [legal entity ID](https://docs.adyen.com/api-explorer/#/legalentity/latest/post/legalEntities__resParam_id) of the individual who signed the PCI questionnaire..</param>
        public PciSigningResponse(List<string> pciQuestionnaireIds = default(List<string>), string signedBy = default(string))
        {
            this.PciQuestionnaireIds = pciQuestionnaireIds;
            this.SignedBy = signedBy;
        }

        /// <summary>
        /// The unique identifiers of the signed PCI documents.
        /// </summary>
        /// <value>The unique identifiers of the signed PCI documents.</value>
        [DataMember(Name = "pciQuestionnaireIds", EmitDefaultValue = false)]
        public List<string> PciQuestionnaireIds { get; set; }

        /// <summary>
        /// The [legal entity ID](https://docs.adyen.com/api-explorer/#/legalentity/latest/post/legalEntities__resParam_id) of the individual who signed the PCI questionnaire.
        /// </summary>
        /// <value>The [legal entity ID](https://docs.adyen.com/api-explorer/#/legalentity/latest/post/legalEntities__resParam_id) of the individual who signed the PCI questionnaire.</value>
        [DataMember(Name = "signedBy", EmitDefaultValue = false)]
        public string SignedBy { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PciSigningResponse {\n");
            sb.Append("  PciQuestionnaireIds: ").Append(PciQuestionnaireIds).Append("\n");
            sb.Append("  SignedBy: ").Append(SignedBy).Append("\n");
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
            return this.Equals(input as PciSigningResponse);
        }

        /// <summary>
        /// Returns true if PciSigningResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of PciSigningResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PciSigningResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.PciQuestionnaireIds == input.PciQuestionnaireIds ||
                    this.PciQuestionnaireIds != null &&
                    input.PciQuestionnaireIds != null &&
                    this.PciQuestionnaireIds.SequenceEqual(input.PciQuestionnaireIds)
                ) && 
                (
                    this.SignedBy == input.SignedBy ||
                    (this.SignedBy != null &&
                    this.SignedBy.Equals(input.SignedBy))
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
                if (this.PciQuestionnaireIds != null)
                {
                    hashCode = (hashCode * 59) + this.PciQuestionnaireIds.GetHashCode();
                }
                if (this.SignedBy != null)
                {
                    hashCode = (hashCode * 59) + this.SignedBy.GetHashCode();
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
