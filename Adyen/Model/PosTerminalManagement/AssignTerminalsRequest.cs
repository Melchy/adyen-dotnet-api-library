/*
* POS Terminal Management API
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

namespace Adyen.Model.PosTerminalManagement
{
    /// <summary>
    /// AssignTerminalsRequest
    /// </summary>
    [DataContract(Name = "AssignTerminalsRequest")]
    public partial class AssignTerminalsRequest : IEquatable<AssignTerminalsRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AssignTerminalsRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AssignTerminalsRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AssignTerminalsRequest" /> class.
        /// </summary>
        /// <param name="companyAccount">Your company account. To return terminals to the company inventory, specify only this parameter and the &#x60;terminals&#x60;. (required).</param>
        /// <param name="merchantAccount">Name of the merchant account. Specify this parameter to assign terminals to this merchant account or to a store under this merchant account..</param>
        /// <param name="merchantInventory">Boolean that indicates if you are assigning the terminals to the merchant inventory. Do not use when assigning terminals to a store. Required when assigning the terminal to a merchant account.  - Set this to **true** to assign the terminals to the merchant inventory. This also means that the terminals cannot be boarded.  - Set this to **false** to assign the terminals to the merchant account as in-store terminals. This makes the terminals ready to be boarded and to process payments through the specified merchant account..</param>
        /// <param name="store">The store code of the store that you want to assign the terminals to..</param>
        /// <param name="terminals">Array containing a list of terminal IDs that you want to assign or reassign to the merchant account or store, or that you want to return to the company inventory.  For example, &#x60;[\&quot;V400m-324689776\&quot;,\&quot;P400Plus-329127412\&quot;]&#x60;. (required).</param>
        public AssignTerminalsRequest(string companyAccount = default(string), string merchantAccount = default(string), bool merchantInventory = default(bool), string store = default(string), List<string> terminals = default(List<string>))
        {
            this.CompanyAccount = companyAccount;
            this.Terminals = terminals;
            this.MerchantAccount = merchantAccount;
            this.MerchantInventory = merchantInventory;
            this.Store = store;
        }

        /// <summary>
        /// Your company account. To return terminals to the company inventory, specify only this parameter and the &#x60;terminals&#x60;.
        /// </summary>
        /// <value>Your company account. To return terminals to the company inventory, specify only this parameter and the &#x60;terminals&#x60;.</value>
        [DataMember(Name = "companyAccount", IsRequired = false, EmitDefaultValue = false)]
        public string CompanyAccount { get; set; }

        /// <summary>
        /// Name of the merchant account. Specify this parameter to assign terminals to this merchant account or to a store under this merchant account.
        /// </summary>
        /// <value>Name of the merchant account. Specify this parameter to assign terminals to this merchant account or to a store under this merchant account.</value>
        [DataMember(Name = "merchantAccount", EmitDefaultValue = false)]
        public string MerchantAccount { get; set; }

        /// <summary>
        /// Boolean that indicates if you are assigning the terminals to the merchant inventory. Do not use when assigning terminals to a store. Required when assigning the terminal to a merchant account.  - Set this to **true** to assign the terminals to the merchant inventory. This also means that the terminals cannot be boarded.  - Set this to **false** to assign the terminals to the merchant account as in-store terminals. This makes the terminals ready to be boarded and to process payments through the specified merchant account.
        /// </summary>
        /// <value>Boolean that indicates if you are assigning the terminals to the merchant inventory. Do not use when assigning terminals to a store. Required when assigning the terminal to a merchant account.  - Set this to **true** to assign the terminals to the merchant inventory. This also means that the terminals cannot be boarded.  - Set this to **false** to assign the terminals to the merchant account as in-store terminals. This makes the terminals ready to be boarded and to process payments through the specified merchant account.</value>
        [DataMember(Name = "merchantInventory", EmitDefaultValue = false)]
        public bool MerchantInventory { get; set; }

        /// <summary>
        /// The store code of the store that you want to assign the terminals to.
        /// </summary>
        /// <value>The store code of the store that you want to assign the terminals to.</value>
        [DataMember(Name = "store", EmitDefaultValue = false)]
        public string Store { get; set; }

        /// <summary>
        /// Array containing a list of terminal IDs that you want to assign or reassign to the merchant account or store, or that you want to return to the company inventory.  For example, &#x60;[\&quot;V400m-324689776\&quot;,\&quot;P400Plus-329127412\&quot;]&#x60;.
        /// </summary>
        /// <value>Array containing a list of terminal IDs that you want to assign or reassign to the merchant account or store, or that you want to return to the company inventory.  For example, &#x60;[\&quot;V400m-324689776\&quot;,\&quot;P400Plus-329127412\&quot;]&#x60;.</value>
        [DataMember(Name = "terminals", IsRequired = false, EmitDefaultValue = false)]
        public List<string> Terminals { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AssignTerminalsRequest {\n");
            sb.Append("  CompanyAccount: ").Append(CompanyAccount).Append("\n");
            sb.Append("  MerchantAccount: ").Append(MerchantAccount).Append("\n");
            sb.Append("  MerchantInventory: ").Append(MerchantInventory).Append("\n");
            sb.Append("  Store: ").Append(Store).Append("\n");
            sb.Append("  Terminals: ").Append(Terminals).Append("\n");
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
            return this.Equals(input as AssignTerminalsRequest);
        }

        /// <summary>
        /// Returns true if AssignTerminalsRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of AssignTerminalsRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AssignTerminalsRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CompanyAccount == input.CompanyAccount ||
                    (this.CompanyAccount != null &&
                    this.CompanyAccount.Equals(input.CompanyAccount))
                ) && 
                (
                    this.MerchantAccount == input.MerchantAccount ||
                    (this.MerchantAccount != null &&
                    this.MerchantAccount.Equals(input.MerchantAccount))
                ) && 
                (
                    this.MerchantInventory == input.MerchantInventory ||
                    this.MerchantInventory.Equals(input.MerchantInventory)
                ) && 
                (
                    this.Store == input.Store ||
                    (this.Store != null &&
                    this.Store.Equals(input.Store))
                ) && 
                (
                    this.Terminals == input.Terminals ||
                    this.Terminals != null &&
                    input.Terminals != null &&
                    this.Terminals.SequenceEqual(input.Terminals)
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
                if (this.CompanyAccount != null)
                {
                    hashCode = (hashCode * 59) + this.CompanyAccount.GetHashCode();
                }
                if (this.MerchantAccount != null)
                {
                    hashCode = (hashCode * 59) + this.MerchantAccount.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.MerchantInventory.GetHashCode();
                if (this.Store != null)
                {
                    hashCode = (hashCode * 59) + this.Store.GetHashCode();
                }
                if (this.Terminals != null)
                {
                    hashCode = (hashCode * 59) + this.Terminals.GetHashCode();
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
