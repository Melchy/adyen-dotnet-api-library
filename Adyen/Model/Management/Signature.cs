/*
* Management API
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

namespace Adyen.Model.Management
{
    /// <summary>
    /// Signature
    /// </summary>
    [DataContract(Name = "Signature")]
    public partial class Signature : IEquatable<Signature>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Signature" /> class.
        /// </summary>
        /// <param name="askSignatureOnScreen">If &#x60;skipSignature&#x60; is false, indicates whether the shopper should provide a signature on the display (**true**) or on the merchant receipt (**false**)..</param>
        /// <param name="deviceName">Name that identifies the terminal..</param>
        /// <param name="deviceSlogan">Slogan shown on the start screen of the device..</param>
        /// <param name="skipSignature">Skip asking for a signature. This is possible because all global card schemes (American Express, Diners, Discover, JCB, MasterCard, VISA, and UnionPay) regard a signature as optional..</param>
        public Signature(bool askSignatureOnScreen = default(bool), string deviceName = default(string), string deviceSlogan = default(string), bool skipSignature = default(bool))
        {
            this.AskSignatureOnScreen = askSignatureOnScreen;
            this.DeviceName = deviceName;
            this.DeviceSlogan = deviceSlogan;
            this.SkipSignature = skipSignature;
        }

        /// <summary>
        /// If &#x60;skipSignature&#x60; is false, indicates whether the shopper should provide a signature on the display (**true**) or on the merchant receipt (**false**).
        /// </summary>
        /// <value>If &#x60;skipSignature&#x60; is false, indicates whether the shopper should provide a signature on the display (**true**) or on the merchant receipt (**false**).</value>
        [DataMember(Name = "askSignatureOnScreen", EmitDefaultValue = false)]
        public bool AskSignatureOnScreen { get; set; }

        /// <summary>
        /// Name that identifies the terminal.
        /// </summary>
        /// <value>Name that identifies the terminal.</value>
        [DataMember(Name = "deviceName", EmitDefaultValue = false)]
        public string DeviceName { get; set; }

        /// <summary>
        /// Slogan shown on the start screen of the device.
        /// </summary>
        /// <value>Slogan shown on the start screen of the device.</value>
        [DataMember(Name = "deviceSlogan", EmitDefaultValue = false)]
        public string DeviceSlogan { get; set; }

        /// <summary>
        /// Skip asking for a signature. This is possible because all global card schemes (American Express, Diners, Discover, JCB, MasterCard, VISA, and UnionPay) regard a signature as optional.
        /// </summary>
        /// <value>Skip asking for a signature. This is possible because all global card schemes (American Express, Diners, Discover, JCB, MasterCard, VISA, and UnionPay) regard a signature as optional.</value>
        [DataMember(Name = "skipSignature", EmitDefaultValue = false)]
        public bool SkipSignature { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Signature {\n");
            sb.Append("  AskSignatureOnScreen: ").Append(AskSignatureOnScreen).Append("\n");
            sb.Append("  DeviceName: ").Append(DeviceName).Append("\n");
            sb.Append("  DeviceSlogan: ").Append(DeviceSlogan).Append("\n");
            sb.Append("  SkipSignature: ").Append(SkipSignature).Append("\n");
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
            return this.Equals(input as Signature);
        }

        /// <summary>
        /// Returns true if Signature instances are equal
        /// </summary>
        /// <param name="input">Instance of Signature to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Signature input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AskSignatureOnScreen == input.AskSignatureOnScreen ||
                    this.AskSignatureOnScreen.Equals(input.AskSignatureOnScreen)
                ) && 
                (
                    this.DeviceName == input.DeviceName ||
                    (this.DeviceName != null &&
                    this.DeviceName.Equals(input.DeviceName))
                ) && 
                (
                    this.DeviceSlogan == input.DeviceSlogan ||
                    (this.DeviceSlogan != null &&
                    this.DeviceSlogan.Equals(input.DeviceSlogan))
                ) && 
                (
                    this.SkipSignature == input.SkipSignature ||
                    this.SkipSignature.Equals(input.SkipSignature)
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
                hashCode = (hashCode * 59) + this.AskSignatureOnScreen.GetHashCode();
                if (this.DeviceName != null)
                {
                    hashCode = (hashCode * 59) + this.DeviceName.GetHashCode();
                }
                if (this.DeviceSlogan != null)
                {
                    hashCode = (hashCode * 59) + this.DeviceSlogan.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.SkipSignature.GetHashCode();
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
            // DeviceSlogan (string) maxLength
            if (this.DeviceSlogan != null && this.DeviceSlogan.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DeviceSlogan, length must be less than 50.", new [] { "DeviceSlogan" });
            }

            yield break;
        }
    }

}
