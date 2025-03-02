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
    /// CreateCompanyUserResponse
    /// </summary>
    [DataContract(Name = "CreateCompanyUserResponse")]
    public partial class CreateCompanyUserResponse : IEquatable<CreateCompanyUserResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCompanyUserResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateCompanyUserResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCompanyUserResponse" /> class.
        /// </summary>
        /// <param name="links">links.</param>
        /// <param name="accountGroups">The list of [account groups](https://docs.adyen.com/account/account-structure#account-groups) associated with this user..</param>
        /// <param name="active">Indicates whether this user is active..</param>
        /// <param name="associatedMerchantAccounts">The list of [merchant accounts](https://docs.adyen.com/account/account-structure#merchant-accounts) associated with this user..</param>
        /// <param name="authnApps">Set of authn apps available to this user.</param>
        /// <param name="email">The email address of the user. (required).</param>
        /// <param name="id">The unique identifier of the user. (required).</param>
        /// <param name="name">name.</param>
        /// <param name="roles">The list of [roles](https://docs.adyen.com/account/user-roles) for this user. (required).</param>
        /// <param name="timeZoneCode">The [tz database name](https://en.wikipedia.org/wiki/List_of_tz_database_time_zones) of the time zone of the user. For example, **Europe/Amsterdam**. (required).</param>
        /// <param name="username">The username for this user. (required).</param>
        public CreateCompanyUserResponse(Links links = default(Links), List<string> accountGroups = default(List<string>), bool active = default(bool), List<string> associatedMerchantAccounts = default(List<string>), List<string> authnApps = default(List<string>), string email = default(string), string id = default(string), Name name = default(Name), List<string> roles = default(List<string>), string timeZoneCode = default(string), string username = default(string))
        {
            this.Email = email;
            this.Id = id;
            this.Roles = roles;
            this.TimeZoneCode = timeZoneCode;
            this.Username = username;
            this.Links = links;
            this.AccountGroups = accountGroups;
            this.Active = active;
            this.AssociatedMerchantAccounts = associatedMerchantAccounts;
            this.AuthnApps = authnApps;
            this.Name = name;
        }

        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name = "_links", EmitDefaultValue = false)]
        public Links Links { get; set; }

        /// <summary>
        /// The list of [account groups](https://docs.adyen.com/account/account-structure#account-groups) associated with this user.
        /// </summary>
        /// <value>The list of [account groups](https://docs.adyen.com/account/account-structure#account-groups) associated with this user.</value>
        [DataMember(Name = "accountGroups", EmitDefaultValue = false)]
        public List<string> AccountGroups { get; set; }

        /// <summary>
        /// Indicates whether this user is active.
        /// </summary>
        /// <value>Indicates whether this user is active.</value>
        [DataMember(Name = "active", EmitDefaultValue = false)]
        public bool Active { get; set; }

        /// <summary>
        /// The list of [merchant accounts](https://docs.adyen.com/account/account-structure#merchant-accounts) associated with this user.
        /// </summary>
        /// <value>The list of [merchant accounts](https://docs.adyen.com/account/account-structure#merchant-accounts) associated with this user.</value>
        [DataMember(Name = "associatedMerchantAccounts", EmitDefaultValue = false)]
        public List<string> AssociatedMerchantAccounts { get; set; }

        /// <summary>
        /// Set of authn apps available to this user
        /// </summary>
        /// <value>Set of authn apps available to this user</value>
        [DataMember(Name = "authnApps", EmitDefaultValue = false)]
        public List<string> AuthnApps { get; set; }

        /// <summary>
        /// The email address of the user.
        /// </summary>
        /// <value>The email address of the user.</value>
        [DataMember(Name = "email", IsRequired = false, EmitDefaultValue = false)]
        public string Email { get; set; }

        /// <summary>
        /// The unique identifier of the user.
        /// </summary>
        /// <value>The unique identifier of the user.</value>
        [DataMember(Name = "id", IsRequired = false, EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public Name Name { get; set; }

        /// <summary>
        /// The list of [roles](https://docs.adyen.com/account/user-roles) for this user.
        /// </summary>
        /// <value>The list of [roles](https://docs.adyen.com/account/user-roles) for this user.</value>
        [DataMember(Name = "roles", IsRequired = false, EmitDefaultValue = false)]
        public List<string> Roles { get; set; }

        /// <summary>
        /// The [tz database name](https://en.wikipedia.org/wiki/List_of_tz_database_time_zones) of the time zone of the user. For example, **Europe/Amsterdam**.
        /// </summary>
        /// <value>The [tz database name](https://en.wikipedia.org/wiki/List_of_tz_database_time_zones) of the time zone of the user. For example, **Europe/Amsterdam**.</value>
        [DataMember(Name = "timeZoneCode", IsRequired = false, EmitDefaultValue = false)]
        public string TimeZoneCode { get; set; }

        /// <summary>
        /// The username for this user.
        /// </summary>
        /// <value>The username for this user.</value>
        [DataMember(Name = "username", IsRequired = false, EmitDefaultValue = false)]
        public string Username { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateCompanyUserResponse {\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  AccountGroups: ").Append(AccountGroups).Append("\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  AssociatedMerchantAccounts: ").Append(AssociatedMerchantAccounts).Append("\n");
            sb.Append("  AuthnApps: ").Append(AuthnApps).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Roles: ").Append(Roles).Append("\n");
            sb.Append("  TimeZoneCode: ").Append(TimeZoneCode).Append("\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
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
            return this.Equals(input as CreateCompanyUserResponse);
        }

        /// <summary>
        /// Returns true if CreateCompanyUserResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateCompanyUserResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateCompanyUserResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Links == input.Links ||
                    (this.Links != null &&
                    this.Links.Equals(input.Links))
                ) && 
                (
                    this.AccountGroups == input.AccountGroups ||
                    this.AccountGroups != null &&
                    input.AccountGroups != null &&
                    this.AccountGroups.SequenceEqual(input.AccountGroups)
                ) && 
                (
                    this.Active == input.Active ||
                    this.Active.Equals(input.Active)
                ) && 
                (
                    this.AssociatedMerchantAccounts == input.AssociatedMerchantAccounts ||
                    this.AssociatedMerchantAccounts != null &&
                    input.AssociatedMerchantAccounts != null &&
                    this.AssociatedMerchantAccounts.SequenceEqual(input.AssociatedMerchantAccounts)
                ) && 
                (
                    this.AuthnApps == input.AuthnApps ||
                    this.AuthnApps != null &&
                    input.AuthnApps != null &&
                    this.AuthnApps.SequenceEqual(input.AuthnApps)
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Roles == input.Roles ||
                    this.Roles != null &&
                    input.Roles != null &&
                    this.Roles.SequenceEqual(input.Roles)
                ) && 
                (
                    this.TimeZoneCode == input.TimeZoneCode ||
                    (this.TimeZoneCode != null &&
                    this.TimeZoneCode.Equals(input.TimeZoneCode))
                ) && 
                (
                    this.Username == input.Username ||
                    (this.Username != null &&
                    this.Username.Equals(input.Username))
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
                if (this.Links != null)
                {
                    hashCode = (hashCode * 59) + this.Links.GetHashCode();
                }
                if (this.AccountGroups != null)
                {
                    hashCode = (hashCode * 59) + this.AccountGroups.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Active.GetHashCode();
                if (this.AssociatedMerchantAccounts != null)
                {
                    hashCode = (hashCode * 59) + this.AssociatedMerchantAccounts.GetHashCode();
                }
                if (this.AuthnApps != null)
                {
                    hashCode = (hashCode * 59) + this.AuthnApps.GetHashCode();
                }
                if (this.Email != null)
                {
                    hashCode = (hashCode * 59) + this.Email.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Roles != null)
                {
                    hashCode = (hashCode * 59) + this.Roles.GetHashCode();
                }
                if (this.TimeZoneCode != null)
                {
                    hashCode = (hashCode * 59) + this.TimeZoneCode.GetHashCode();
                }
                if (this.Username != null)
                {
                    hashCode = (hashCode * 59) + this.Username.GetHashCode();
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
            // Username (string) maxLength
            if (this.Username != null && this.Username.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Username, length must be less than 255.", new [] { "Username" });
            }

            // Username (string) minLength
            if (this.Username != null && this.Username.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Username, length must be greater than 1.", new [] { "Username" });
            }

            yield break;
        }
    }

}
