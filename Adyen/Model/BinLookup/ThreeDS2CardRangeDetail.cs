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
    /// ThreeDS2CardRangeDetail
    /// </summary>
    [DataContract(Name = "ThreeDS2CardRangeDetail")]
    public partial class ThreeDS2CardRangeDetail : IEquatable<ThreeDS2CardRangeDetail>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ThreeDS2CardRangeDetail" /> class.
        /// </summary>
        /// <param name="acsInfoInd">Provides additional information to the 3DS Server. Possible values: - 01 (Authentication is available at ACS) - 02 (Attempts supported by ACS or DS) - 03 (Decoupled authentication supported) - 04 (Whitelisting supported).</param>
        /// <param name="brandCode">Card brand..</param>
        /// <param name="endRange">BIN end range..</param>
        /// <param name="startRange">BIN start range..</param>
        /// <param name="threeDS2Versions">Supported 3D Secure protocol versions.</param>
        /// <param name="threeDSMethodURL">In a 3D Secure 2 browser-based flow, this is the URL where you should send the device fingerprint to..</param>
        public ThreeDS2CardRangeDetail(List<string> acsInfoInd = default(List<string>), string brandCode = default(string), string endRange = default(string), string startRange = default(string), List<string> threeDS2Versions = default(List<string>), string threeDSMethodURL = default(string))
        {
            this.AcsInfoInd = acsInfoInd;
            this.BrandCode = brandCode;
            this.EndRange = endRange;
            this.StartRange = startRange;
            this.ThreeDS2Versions = threeDS2Versions;
            this.ThreeDSMethodURL = threeDSMethodURL;
        }

        /// <summary>
        /// Provides additional information to the 3DS Server. Possible values: - 01 (Authentication is available at ACS) - 02 (Attempts supported by ACS or DS) - 03 (Decoupled authentication supported) - 04 (Whitelisting supported)
        /// </summary>
        /// <value>Provides additional information to the 3DS Server. Possible values: - 01 (Authentication is available at ACS) - 02 (Attempts supported by ACS or DS) - 03 (Decoupled authentication supported) - 04 (Whitelisting supported)</value>
        [DataMember(Name = "acsInfoInd", EmitDefaultValue = false)]
        public List<string> AcsInfoInd { get; set; }

        /// <summary>
        /// Card brand.
        /// </summary>
        /// <value>Card brand.</value>
        [DataMember(Name = "brandCode", EmitDefaultValue = false)]
        public string BrandCode { get; set; }

        /// <summary>
        /// BIN end range.
        /// </summary>
        /// <value>BIN end range.</value>
        [DataMember(Name = "endRange", EmitDefaultValue = false)]
        public string EndRange { get; set; }

        /// <summary>
        /// BIN start range.
        /// </summary>
        /// <value>BIN start range.</value>
        [DataMember(Name = "startRange", EmitDefaultValue = false)]
        public string StartRange { get; set; }

        /// <summary>
        /// Supported 3D Secure protocol versions
        /// </summary>
        /// <value>Supported 3D Secure protocol versions</value>
        [DataMember(Name = "threeDS2Versions", EmitDefaultValue = false)]
        public List<string> ThreeDS2Versions { get; set; }

        /// <summary>
        /// In a 3D Secure 2 browser-based flow, this is the URL where you should send the device fingerprint to.
        /// </summary>
        /// <value>In a 3D Secure 2 browser-based flow, this is the URL where you should send the device fingerprint to.</value>
        [DataMember(Name = "threeDSMethodURL", EmitDefaultValue = false)]
        public string ThreeDSMethodURL { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ThreeDS2CardRangeDetail {\n");
            sb.Append("  AcsInfoInd: ").Append(AcsInfoInd).Append("\n");
            sb.Append("  BrandCode: ").Append(BrandCode).Append("\n");
            sb.Append("  EndRange: ").Append(EndRange).Append("\n");
            sb.Append("  StartRange: ").Append(StartRange).Append("\n");
            sb.Append("  ThreeDS2Versions: ").Append(ThreeDS2Versions).Append("\n");
            sb.Append("  ThreeDSMethodURL: ").Append(ThreeDSMethodURL).Append("\n");
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
            return this.Equals(input as ThreeDS2CardRangeDetail);
        }

        /// <summary>
        /// Returns true if ThreeDS2CardRangeDetail instances are equal
        /// </summary>
        /// <param name="input">Instance of ThreeDS2CardRangeDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ThreeDS2CardRangeDetail input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AcsInfoInd == input.AcsInfoInd ||
                    this.AcsInfoInd != null &&
                    input.AcsInfoInd != null &&
                    this.AcsInfoInd.SequenceEqual(input.AcsInfoInd)
                ) && 
                (
                    this.BrandCode == input.BrandCode ||
                    (this.BrandCode != null &&
                    this.BrandCode.Equals(input.BrandCode))
                ) && 
                (
                    this.EndRange == input.EndRange ||
                    (this.EndRange != null &&
                    this.EndRange.Equals(input.EndRange))
                ) && 
                (
                    this.StartRange == input.StartRange ||
                    (this.StartRange != null &&
                    this.StartRange.Equals(input.StartRange))
                ) && 
                (
                    this.ThreeDS2Versions == input.ThreeDS2Versions ||
                    this.ThreeDS2Versions != null &&
                    input.ThreeDS2Versions != null &&
                    this.ThreeDS2Versions.SequenceEqual(input.ThreeDS2Versions)
                ) && 
                (
                    this.ThreeDSMethodURL == input.ThreeDSMethodURL ||
                    (this.ThreeDSMethodURL != null &&
                    this.ThreeDSMethodURL.Equals(input.ThreeDSMethodURL))
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
                if (this.AcsInfoInd != null)
                {
                    hashCode = (hashCode * 59) + this.AcsInfoInd.GetHashCode();
                }
                if (this.BrandCode != null)
                {
                    hashCode = (hashCode * 59) + this.BrandCode.GetHashCode();
                }
                if (this.EndRange != null)
                {
                    hashCode = (hashCode * 59) + this.EndRange.GetHashCode();
                }
                if (this.StartRange != null)
                {
                    hashCode = (hashCode * 59) + this.StartRange.GetHashCode();
                }
                if (this.ThreeDS2Versions != null)
                {
                    hashCode = (hashCode * 59) + this.ThreeDS2Versions.GetHashCode();
                }
                if (this.ThreeDSMethodURL != null)
                {
                    hashCode = (hashCode * 59) + this.ThreeDSMethodURL.GetHashCode();
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
