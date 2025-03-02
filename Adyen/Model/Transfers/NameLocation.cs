/*
* Transfers API
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

namespace Adyen.Model.Transfers
{
    /// <summary>
    /// NameLocation
    /// </summary>
    [DataContract(Name = "NameLocation")]
    public partial class NameLocation : IEquatable<NameLocation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NameLocation" /> class.
        /// </summary>
        /// <param name="city">The city where the merchant is located..</param>
        /// <param name="country">The country where the merchant is located in [three-letter country code](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-3) format..</param>
        /// <param name="countryOfOrigin">The home country in [three-digit country code](https://en.wikipedia.org/wiki/ISO_3166-1_numeric) format, used for government-controlled merchants such as embassies..</param>
        /// <param name="name">The name of the merchant&#39;s shop or service..</param>
        /// <param name="rawData">The raw data..</param>
        /// <param name="state">The state where the merchant is located..</param>
        public NameLocation(string city = default(string), string country = default(string), string countryOfOrigin = default(string), string name = default(string), string rawData = default(string), string state = default(string))
        {
            this.City = city;
            this.Country = country;
            this.CountryOfOrigin = countryOfOrigin;
            this.Name = name;
            this.RawData = rawData;
            this.State = state;
        }

        /// <summary>
        /// The city where the merchant is located.
        /// </summary>
        /// <value>The city where the merchant is located.</value>
        [DataMember(Name = "city", EmitDefaultValue = false)]
        public string City { get; set; }

        /// <summary>
        /// The country where the merchant is located in [three-letter country code](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-3) format.
        /// </summary>
        /// <value>The country where the merchant is located in [three-letter country code](https://en.wikipedia.org/wiki/ISO_3166-1_alpha-3) format.</value>
        [DataMember(Name = "country", EmitDefaultValue = false)]
        public string Country { get; set; }

        /// <summary>
        /// The home country in [three-digit country code](https://en.wikipedia.org/wiki/ISO_3166-1_numeric) format, used for government-controlled merchants such as embassies.
        /// </summary>
        /// <value>The home country in [three-digit country code](https://en.wikipedia.org/wiki/ISO_3166-1_numeric) format, used for government-controlled merchants such as embassies.</value>
        [DataMember(Name = "countryOfOrigin", EmitDefaultValue = false)]
        public string CountryOfOrigin { get; set; }

        /// <summary>
        /// The name of the merchant&#39;s shop or service.
        /// </summary>
        /// <value>The name of the merchant&#39;s shop or service.</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// The raw data.
        /// </summary>
        /// <value>The raw data.</value>
        [DataMember(Name = "rawData", EmitDefaultValue = false)]
        public string RawData { get; set; }

        /// <summary>
        /// The state where the merchant is located.
        /// </summary>
        /// <value>The state where the merchant is located.</value>
        [DataMember(Name = "state", EmitDefaultValue = false)]
        public string State { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NameLocation {\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  CountryOfOrigin: ").Append(CountryOfOrigin).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  RawData: ").Append(RawData).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
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
            return this.Equals(input as NameLocation);
        }

        /// <summary>
        /// Returns true if NameLocation instances are equal
        /// </summary>
        /// <param name="input">Instance of NameLocation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NameLocation input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.City == input.City ||
                    (this.City != null &&
                    this.City.Equals(input.City))
                ) && 
                (
                    this.Country == input.Country ||
                    (this.Country != null &&
                    this.Country.Equals(input.Country))
                ) && 
                (
                    this.CountryOfOrigin == input.CountryOfOrigin ||
                    (this.CountryOfOrigin != null &&
                    this.CountryOfOrigin.Equals(input.CountryOfOrigin))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.RawData == input.RawData ||
                    (this.RawData != null &&
                    this.RawData.Equals(input.RawData))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
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
                if (this.City != null)
                {
                    hashCode = (hashCode * 59) + this.City.GetHashCode();
                }
                if (this.Country != null)
                {
                    hashCode = (hashCode * 59) + this.Country.GetHashCode();
                }
                if (this.CountryOfOrigin != null)
                {
                    hashCode = (hashCode * 59) + this.CountryOfOrigin.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.RawData != null)
                {
                    hashCode = (hashCode * 59) + this.RawData.GetHashCode();
                }
                if (this.State != null)
                {
                    hashCode = (hashCode * 59) + this.State.GetHashCode();
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
