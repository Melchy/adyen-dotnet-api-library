/*
* Adyen Checkout API
*
*
* The version of the OpenAPI document: 70
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

namespace Adyen.Model.Checkout
{
    /// <summary>
    /// ShopperInput
    /// </summary>
    [DataContract(Name = "ShopperInput")]
    public partial class ShopperInput : IEquatable<ShopperInput>, IValidatableObject
    {
        /// <summary>
        /// Specifies visibility of billing address fields.  Permitted values: * editable * hidden * readOnly
        /// </summary>
        /// <value>Specifies visibility of billing address fields.  Permitted values: * editable * hidden * readOnly</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum BillingAddressEnum
        {
            /// <summary>
            /// Enum Editable for value: editable
            /// </summary>
            [EnumMember(Value = "editable")]
            Editable = 1,

            /// <summary>
            /// Enum Hidden for value: hidden
            /// </summary>
            [EnumMember(Value = "hidden")]
            Hidden = 2,

            /// <summary>
            /// Enum ReadOnly for value: readOnly
            /// </summary>
            [EnumMember(Value = "readOnly")]
            ReadOnly = 3

        }


        /// <summary>
        /// Specifies visibility of billing address fields.  Permitted values: * editable * hidden * readOnly
        /// </summary>
        /// <value>Specifies visibility of billing address fields.  Permitted values: * editable * hidden * readOnly</value>
        [DataMember(Name = "billingAddress", EmitDefaultValue = false)]
        public BillingAddressEnum? BillingAddress { get; set; }
        /// <summary>
        /// Specifies visibility of delivery address fields.  Permitted values: * editable * hidden * readOnly
        /// </summary>
        /// <value>Specifies visibility of delivery address fields.  Permitted values: * editable * hidden * readOnly</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DeliveryAddressEnum
        {
            /// <summary>
            /// Enum Editable for value: editable
            /// </summary>
            [EnumMember(Value = "editable")]
            Editable = 1,

            /// <summary>
            /// Enum Hidden for value: hidden
            /// </summary>
            [EnumMember(Value = "hidden")]
            Hidden = 2,

            /// <summary>
            /// Enum ReadOnly for value: readOnly
            /// </summary>
            [EnumMember(Value = "readOnly")]
            ReadOnly = 3

        }


        /// <summary>
        /// Specifies visibility of delivery address fields.  Permitted values: * editable * hidden * readOnly
        /// </summary>
        /// <value>Specifies visibility of delivery address fields.  Permitted values: * editable * hidden * readOnly</value>
        [DataMember(Name = "deliveryAddress", EmitDefaultValue = false)]
        public DeliveryAddressEnum? DeliveryAddress { get; set; }
        /// <summary>
        /// Specifies visibility of personal details.  Permitted values: * editable * hidden * readOnly
        /// </summary>
        /// <value>Specifies visibility of personal details.  Permitted values: * editable * hidden * readOnly</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PersonalDetailsEnum
        {
            /// <summary>
            /// Enum Editable for value: editable
            /// </summary>
            [EnumMember(Value = "editable")]
            Editable = 1,

            /// <summary>
            /// Enum Hidden for value: hidden
            /// </summary>
            [EnumMember(Value = "hidden")]
            Hidden = 2,

            /// <summary>
            /// Enum ReadOnly for value: readOnly
            /// </summary>
            [EnumMember(Value = "readOnly")]
            ReadOnly = 3

        }


        /// <summary>
        /// Specifies visibility of personal details.  Permitted values: * editable * hidden * readOnly
        /// </summary>
        /// <value>Specifies visibility of personal details.  Permitted values: * editable * hidden * readOnly</value>
        [DataMember(Name = "personalDetails", EmitDefaultValue = false)]
        public PersonalDetailsEnum? PersonalDetails { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ShopperInput" /> class.
        /// </summary>
        /// <param name="billingAddress">Specifies visibility of billing address fields.  Permitted values: * editable * hidden * readOnly.</param>
        /// <param name="deliveryAddress">Specifies visibility of delivery address fields.  Permitted values: * editable * hidden * readOnly.</param>
        /// <param name="personalDetails">Specifies visibility of personal details.  Permitted values: * editable * hidden * readOnly.</param>
        public ShopperInput(BillingAddressEnum? billingAddress = default(BillingAddressEnum?), DeliveryAddressEnum? deliveryAddress = default(DeliveryAddressEnum?), PersonalDetailsEnum? personalDetails = default(PersonalDetailsEnum?))
        {
            this.BillingAddress = billingAddress;
            this.DeliveryAddress = deliveryAddress;
            this.PersonalDetails = personalDetails;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ShopperInput {\n");
            sb.Append("  BillingAddress: ").Append(BillingAddress).Append("\n");
            sb.Append("  DeliveryAddress: ").Append(DeliveryAddress).Append("\n");
            sb.Append("  PersonalDetails: ").Append(PersonalDetails).Append("\n");
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
            return this.Equals(input as ShopperInput);
        }

        /// <summary>
        /// Returns true if ShopperInput instances are equal
        /// </summary>
        /// <param name="input">Instance of ShopperInput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShopperInput input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.BillingAddress == input.BillingAddress ||
                    this.BillingAddress.Equals(input.BillingAddress)
                ) && 
                (
                    this.DeliveryAddress == input.DeliveryAddress ||
                    this.DeliveryAddress.Equals(input.DeliveryAddress)
                ) && 
                (
                    this.PersonalDetails == input.PersonalDetails ||
                    this.PersonalDetails.Equals(input.PersonalDetails)
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
                hashCode = (hashCode * 59) + this.BillingAddress.GetHashCode();
                hashCode = (hashCode * 59) + this.DeliveryAddress.GetHashCode();
                hashCode = (hashCode * 59) + this.PersonalDetails.GetHashCode();
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
