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
    /// Document
    /// </summary>
    [DataContract(Name = "Document")]
    public partial class Document : IEquatable<Document>, IValidatableObject
    {
        /// <summary>
        /// Type of document, used when providing an ID number or uploading a document. The possible values depend on the legal entity type.  When providing ID numbers: * For **individual**, the &#x60;type&#x60; values can be **driversLicense**, **identityCard**, **nationalIdNumber**, or **passport**.  When uploading photo IDs: * For **individual**, the &#x60;type&#x60; values can be **identityCard**, **driversLicense**, or **passport**.  When uploading other documents: * For **organization**, the &#x60;type&#x60; values can be **proofOfAddress**, **registrationDocument**, **vatDocument**, **proofOfOrganizationTaxInfo**, **proofOfOwnership**, or **proofOfIndustry**.   * For **individual**, the &#x60;type&#x60; values can be **identityCard**, **driversLicense**, **passport**, **proofOfNationalIdNumber**, **proofOfResidency**, **proofOfIndustry**, or **proofOfIndividualTaxId**.  * For **soleProprietorship**, the &#x60;type&#x60; values can be **constitutionalDocument**, **proofOfAddress**, or **proofOfIndustry**.  * Use **bankStatement** to upload documents for a [transfer instrument](https://docs.adyen.com/api-explorer/#/legalentity/latest/post/transferInstruments__resParam_id).
        /// </summary>
        /// <value>Type of document, used when providing an ID number or uploading a document. The possible values depend on the legal entity type.  When providing ID numbers: * For **individual**, the &#x60;type&#x60; values can be **driversLicense**, **identityCard**, **nationalIdNumber**, or **passport**.  When uploading photo IDs: * For **individual**, the &#x60;type&#x60; values can be **identityCard**, **driversLicense**, or **passport**.  When uploading other documents: * For **organization**, the &#x60;type&#x60; values can be **proofOfAddress**, **registrationDocument**, **vatDocument**, **proofOfOrganizationTaxInfo**, **proofOfOwnership**, or **proofOfIndustry**.   * For **individual**, the &#x60;type&#x60; values can be **identityCard**, **driversLicense**, **passport**, **proofOfNationalIdNumber**, **proofOfResidency**, **proofOfIndustry**, or **proofOfIndividualTaxId**.  * For **soleProprietorship**, the &#x60;type&#x60; values can be **constitutionalDocument**, **proofOfAddress**, or **proofOfIndustry**.  * Use **bankStatement** to upload documents for a [transfer instrument](https://docs.adyen.com/api-explorer/#/legalentity/latest/post/transferInstruments__resParam_id).</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum BankStatement for value: bankStatement
            /// </summary>
            [EnumMember(Value = "bankStatement")]
            BankStatement = 1,

            /// <summary>
            /// Enum DriversLicense for value: driversLicense
            /// </summary>
            [EnumMember(Value = "driversLicense")]
            DriversLicense = 2,

            /// <summary>
            /// Enum IdentityCard for value: identityCard
            /// </summary>
            [EnumMember(Value = "identityCard")]
            IdentityCard = 3,

            /// <summary>
            /// Enum NationalIdNumber for value: nationalIdNumber
            /// </summary>
            [EnumMember(Value = "nationalIdNumber")]
            NationalIdNumber = 4,

            /// <summary>
            /// Enum Passport for value: passport
            /// </summary>
            [EnumMember(Value = "passport")]
            Passport = 5,

            /// <summary>
            /// Enum ProofOfAddress for value: proofOfAddress
            /// </summary>
            [EnumMember(Value = "proofOfAddress")]
            ProofOfAddress = 6,

            /// <summary>
            /// Enum ProofOfNationalIdNumber for value: proofOfNationalIdNumber
            /// </summary>
            [EnumMember(Value = "proofOfNationalIdNumber")]
            ProofOfNationalIdNumber = 7,

            /// <summary>
            /// Enum ProofOfResidency for value: proofOfResidency
            /// </summary>
            [EnumMember(Value = "proofOfResidency")]
            ProofOfResidency = 8,

            /// <summary>
            /// Enum RegistrationDocument for value: registrationDocument
            /// </summary>
            [EnumMember(Value = "registrationDocument")]
            RegistrationDocument = 9,

            /// <summary>
            /// Enum VatDocument for value: vatDocument
            /// </summary>
            [EnumMember(Value = "vatDocument")]
            VatDocument = 10,

            /// <summary>
            /// Enum ProofOfOrganizationTaxInfo for value: proofOfOrganizationTaxInfo
            /// </summary>
            [EnumMember(Value = "proofOfOrganizationTaxInfo")]
            ProofOfOrganizationTaxInfo = 11,

            /// <summary>
            /// Enum ProofOfIndustry for value: proofOfIndustry
            /// </summary>
            [EnumMember(Value = "proofOfIndustry")]
            ProofOfIndustry = 12,

            /// <summary>
            /// Enum ConstitutionalDocument for value: constitutionalDocument
            /// </summary>
            [EnumMember(Value = "constitutionalDocument")]
            ConstitutionalDocument = 13

        }


        /// <summary>
        /// Type of document, used when providing an ID number or uploading a document. The possible values depend on the legal entity type.  When providing ID numbers: * For **individual**, the &#x60;type&#x60; values can be **driversLicense**, **identityCard**, **nationalIdNumber**, or **passport**.  When uploading photo IDs: * For **individual**, the &#x60;type&#x60; values can be **identityCard**, **driversLicense**, or **passport**.  When uploading other documents: * For **organization**, the &#x60;type&#x60; values can be **proofOfAddress**, **registrationDocument**, **vatDocument**, **proofOfOrganizationTaxInfo**, **proofOfOwnership**, or **proofOfIndustry**.   * For **individual**, the &#x60;type&#x60; values can be **identityCard**, **driversLicense**, **passport**, **proofOfNationalIdNumber**, **proofOfResidency**, **proofOfIndustry**, or **proofOfIndividualTaxId**.  * For **soleProprietorship**, the &#x60;type&#x60; values can be **constitutionalDocument**, **proofOfAddress**, or **proofOfIndustry**.  * Use **bankStatement** to upload documents for a [transfer instrument](https://docs.adyen.com/api-explorer/#/legalentity/latest/post/transferInstruments__resParam_id).
        /// </summary>
        /// <value>Type of document, used when providing an ID number or uploading a document. The possible values depend on the legal entity type.  When providing ID numbers: * For **individual**, the &#x60;type&#x60; values can be **driversLicense**, **identityCard**, **nationalIdNumber**, or **passport**.  When uploading photo IDs: * For **individual**, the &#x60;type&#x60; values can be **identityCard**, **driversLicense**, or **passport**.  When uploading other documents: * For **organization**, the &#x60;type&#x60; values can be **proofOfAddress**, **registrationDocument**, **vatDocument**, **proofOfOrganizationTaxInfo**, **proofOfOwnership**, or **proofOfIndustry**.   * For **individual**, the &#x60;type&#x60; values can be **identityCard**, **driversLicense**, **passport**, **proofOfNationalIdNumber**, **proofOfResidency**, **proofOfIndustry**, or **proofOfIndividualTaxId**.  * For **soleProprietorship**, the &#x60;type&#x60; values can be **constitutionalDocument**, **proofOfAddress**, or **proofOfIndustry**.  * Use **bankStatement** to upload documents for a [transfer instrument](https://docs.adyen.com/api-explorer/#/legalentity/latest/post/transferInstruments__resParam_id).</value>
        [DataMember(Name = "type", IsRequired = false, EmitDefaultValue = false)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Document" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Document() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Document" /> class.
        /// </summary>
        /// <param name="attachment">attachment.</param>
        /// <param name="attachments">Array that contains the document. The array supports multiple attachments for uploading different sides or pages of a document. (required).</param>
        /// <param name="description">Your description for the document. (required).</param>
        /// <param name="expiryDate">The expiry date of the document, in YYYY-MM-DD format..</param>
        /// <param name="fileName">The filename of the document..</param>
        /// <param name="issuerCountry">The two-character [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country code where the document was issued. For example, **US**..</param>
        /// <param name="issuerState">The state or province where the document was issued (AU only)..</param>
        /// <param name="number">The number in the document..</param>
        /// <param name="owner">owner (required).</param>
        /// <param name="type">Type of document, used when providing an ID number or uploading a document. The possible values depend on the legal entity type.  When providing ID numbers: * For **individual**, the &#x60;type&#x60; values can be **driversLicense**, **identityCard**, **nationalIdNumber**, or **passport**.  When uploading photo IDs: * For **individual**, the &#x60;type&#x60; values can be **identityCard**, **driversLicense**, or **passport**.  When uploading other documents: * For **organization**, the &#x60;type&#x60; values can be **proofOfAddress**, **registrationDocument**, **vatDocument**, **proofOfOrganizationTaxInfo**, **proofOfOwnership**, or **proofOfIndustry**.   * For **individual**, the &#x60;type&#x60; values can be **identityCard**, **driversLicense**, **passport**, **proofOfNationalIdNumber**, **proofOfResidency**, **proofOfIndustry**, or **proofOfIndividualTaxId**.  * For **soleProprietorship**, the &#x60;type&#x60; values can be **constitutionalDocument**, **proofOfAddress**, or **proofOfIndustry**.  * Use **bankStatement** to upload documents for a [transfer instrument](https://docs.adyen.com/api-explorer/#/legalentity/latest/post/transferInstruments__resParam_id). (required).</param>
        public Document(Attachment attachment = default(Attachment), List<Attachment> attachments = default(List<Attachment>), string description = default(string), string expiryDate = default(string), string fileName = default(string), string issuerCountry = default(string), string issuerState = default(string), string number = default(string), OwnerEntity owner = default(OwnerEntity), TypeEnum type = default(TypeEnum))
        {
            this.Attachments = attachments;
            this.Description = description;
            this.Owner = owner;
            this.Type = type;
            this.Attachment = attachment;
            this.ExpiryDate = expiryDate;
            this.FileName = fileName;
            this.IssuerCountry = issuerCountry;
            this.IssuerState = issuerState;
            this.Number = number;
        }

        /// <summary>
        /// Gets or Sets Attachment
        /// </summary>
        [DataMember(Name = "attachment", EmitDefaultValue = false)]
        public Attachment Attachment { get; set; }

        /// <summary>
        /// Array that contains the document. The array supports multiple attachments for uploading different sides or pages of a document.
        /// </summary>
        /// <value>Array that contains the document. The array supports multiple attachments for uploading different sides or pages of a document.</value>
        [DataMember(Name = "attachments", IsRequired = false, EmitDefaultValue = false)]
        public List<Attachment> Attachments { get; set; }

        /// <summary>
        /// The creation date of the document.
        /// </summary>
        /// <value>The creation date of the document.</value>
        [DataMember(Name = "creationDate", EmitDefaultValue = false)]
        public DateTime CreationDate { get; private set; }

        /// <summary>
        /// Your description for the document.
        /// </summary>
        /// <value>Your description for the document.</value>
        [DataMember(Name = "description", IsRequired = false, EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// The expiry date of the document, in YYYY-MM-DD format.
        /// </summary>
        /// <value>The expiry date of the document, in YYYY-MM-DD format.</value>
        [DataMember(Name = "expiryDate", EmitDefaultValue = false)]
        [Obsolete]
        public string ExpiryDate { get; set; }

        /// <summary>
        /// The filename of the document.
        /// </summary>
        /// <value>The filename of the document.</value>
        [DataMember(Name = "fileName", EmitDefaultValue = false)]
        public string FileName { get; set; }

        /// <summary>
        /// The unique identifier of the document.
        /// </summary>
        /// <value>The unique identifier of the document.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; private set; }

        /// <summary>
        /// The two-character [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country code where the document was issued. For example, **US**.
        /// </summary>
        /// <value>The two-character [ISO 3166-1 alpha-2](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2) country code where the document was issued. For example, **US**.</value>
        [DataMember(Name = "issuerCountry", EmitDefaultValue = false)]
        [Obsolete]
        public string IssuerCountry { get; set; }

        /// <summary>
        /// The state or province where the document was issued (AU only).
        /// </summary>
        /// <value>The state or province where the document was issued (AU only).</value>
        [DataMember(Name = "issuerState", EmitDefaultValue = false)]
        [Obsolete]
        public string IssuerState { get; set; }

        /// <summary>
        /// The modification date of the document.
        /// </summary>
        /// <value>The modification date of the document.</value>
        [DataMember(Name = "modificationDate", EmitDefaultValue = false)]
        public DateTime ModificationDate { get; private set; }

        /// <summary>
        /// The number in the document.
        /// </summary>
        /// <value>The number in the document.</value>
        [DataMember(Name = "number", EmitDefaultValue = false)]
        public string Number { get; set; }

        /// <summary>
        /// Gets or Sets Owner
        /// </summary>
        [DataMember(Name = "owner", IsRequired = false, EmitDefaultValue = false)]
        public OwnerEntity Owner { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Document {\n");
            sb.Append("  Attachment: ").Append(Attachment).Append("\n");
            sb.Append("  Attachments: ").Append(Attachments).Append("\n");
            sb.Append("  CreationDate: ").Append(CreationDate).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ExpiryDate: ").Append(ExpiryDate).Append("\n");
            sb.Append("  FileName: ").Append(FileName).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IssuerCountry: ").Append(IssuerCountry).Append("\n");
            sb.Append("  IssuerState: ").Append(IssuerState).Append("\n");
            sb.Append("  ModificationDate: ").Append(ModificationDate).Append("\n");
            sb.Append("  Number: ").Append(Number).Append("\n");
            sb.Append("  Owner: ").Append(Owner).Append("\n");
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
            return this.Equals(input as Document);
        }

        /// <summary>
        /// Returns true if Document instances are equal
        /// </summary>
        /// <param name="input">Instance of Document to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Document input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Attachment == input.Attachment ||
                    (this.Attachment != null &&
                    this.Attachment.Equals(input.Attachment))
                ) && 
                (
                    this.Attachments == input.Attachments ||
                    this.Attachments != null &&
                    input.Attachments != null &&
                    this.Attachments.SequenceEqual(input.Attachments)
                ) && 
                (
                    this.CreationDate == input.CreationDate ||
                    (this.CreationDate != null &&
                    this.CreationDate.Equals(input.CreationDate))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.ExpiryDate == input.ExpiryDate ||
                    (this.ExpiryDate != null &&
                    this.ExpiryDate.Equals(input.ExpiryDate))
                ) && 
                (
                    this.FileName == input.FileName ||
                    (this.FileName != null &&
                    this.FileName.Equals(input.FileName))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.IssuerCountry == input.IssuerCountry ||
                    (this.IssuerCountry != null &&
                    this.IssuerCountry.Equals(input.IssuerCountry))
                ) && 
                (
                    this.IssuerState == input.IssuerState ||
                    (this.IssuerState != null &&
                    this.IssuerState.Equals(input.IssuerState))
                ) && 
                (
                    this.ModificationDate == input.ModificationDate ||
                    (this.ModificationDate != null &&
                    this.ModificationDate.Equals(input.ModificationDate))
                ) && 
                (
                    this.Number == input.Number ||
                    (this.Number != null &&
                    this.Number.Equals(input.Number))
                ) && 
                (
                    this.Owner == input.Owner ||
                    (this.Owner != null &&
                    this.Owner.Equals(input.Owner))
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
                if (this.Attachment != null)
                {
                    hashCode = (hashCode * 59) + this.Attachment.GetHashCode();
                }
                if (this.Attachments != null)
                {
                    hashCode = (hashCode * 59) + this.Attachments.GetHashCode();
                }
                if (this.CreationDate != null)
                {
                    hashCode = (hashCode * 59) + this.CreationDate.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.ExpiryDate != null)
                {
                    hashCode = (hashCode * 59) + this.ExpiryDate.GetHashCode();
                }
                if (this.FileName != null)
                {
                    hashCode = (hashCode * 59) + this.FileName.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.IssuerCountry != null)
                {
                    hashCode = (hashCode * 59) + this.IssuerCountry.GetHashCode();
                }
                if (this.IssuerState != null)
                {
                    hashCode = (hashCode * 59) + this.IssuerState.GetHashCode();
                }
                if (this.ModificationDate != null)
                {
                    hashCode = (hashCode * 59) + this.ModificationDate.GetHashCode();
                }
                if (this.Number != null)
                {
                    hashCode = (hashCode * 59) + this.Number.GetHashCode();
                }
                if (this.Owner != null)
                {
                    hashCode = (hashCode * 59) + this.Owner.GetHashCode();
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
