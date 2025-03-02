/*
* Configuration API
*
*
* The version of the OpenAPI document: 2
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

namespace Adyen.Model.BalancePlatform
{
    /// <summary>
    /// TransactionRule
    /// </summary>
    [DataContract(Name = "TransactionRule")]
    public partial class TransactionRule : IEquatable<TransactionRule>, IValidatableObject
    {
        /// <summary>
        /// The [outcome](https://docs.adyen.com/issuing/transaction-rules#outcome) that will be applied when a transaction meets the conditions of the rule. If not provided, by default, this is set to **hardBlock**.  Possible values:   * **hardBlock**: the transaction is declined.  * **scoreBased**: the transaction is assigned the &#x60;score&#x60; you specified. Adyen calculates the total score and if it exceeds 100, the transaction is declined.
        /// </summary>
        /// <value>The [outcome](https://docs.adyen.com/issuing/transaction-rules#outcome) that will be applied when a transaction meets the conditions of the rule. If not provided, by default, this is set to **hardBlock**.  Possible values:   * **hardBlock**: the transaction is declined.  * **scoreBased**: the transaction is assigned the &#x60;score&#x60; you specified. Adyen calculates the total score and if it exceeds 100, the transaction is declined.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum OutcomeTypeEnum
        {
            /// <summary>
            /// Enum HardBlock for value: hardBlock
            /// </summary>
            [EnumMember(Value = "hardBlock")]
            HardBlock = 1,

            /// <summary>
            /// Enum ScoreBased for value: scoreBased
            /// </summary>
            [EnumMember(Value = "scoreBased")]
            ScoreBased = 2

        }


        /// <summary>
        /// The [outcome](https://docs.adyen.com/issuing/transaction-rules#outcome) that will be applied when a transaction meets the conditions of the rule. If not provided, by default, this is set to **hardBlock**.  Possible values:   * **hardBlock**: the transaction is declined.  * **scoreBased**: the transaction is assigned the &#x60;score&#x60; you specified. Adyen calculates the total score and if it exceeds 100, the transaction is declined.
        /// </summary>
        /// <value>The [outcome](https://docs.adyen.com/issuing/transaction-rules#outcome) that will be applied when a transaction meets the conditions of the rule. If not provided, by default, this is set to **hardBlock**.  Possible values:   * **hardBlock**: the transaction is declined.  * **scoreBased**: the transaction is assigned the &#x60;score&#x60; you specified. Adyen calculates the total score and if it exceeds 100, the transaction is declined.</value>
        [DataMember(Name = "outcomeType", EmitDefaultValue = false)]
        public OutcomeTypeEnum? OutcomeType { get; set; }
        /// <summary>
        /// Indicates the type of request to which the rule applies.  Possible values: **authorization**, **authentication**, **tokenization**.
        /// </summary>
        /// <value>Indicates the type of request to which the rule applies.  Possible values: **authorization**, **authentication**, **tokenization**.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RequestTypeEnum
        {
            /// <summary>
            /// Enum Authentication for value: authentication
            /// </summary>
            [EnumMember(Value = "authentication")]
            Authentication = 1,

            /// <summary>
            /// Enum Authorization for value: authorization
            /// </summary>
            [EnumMember(Value = "authorization")]
            Authorization = 2,

            /// <summary>
            /// Enum Tokenization for value: tokenization
            /// </summary>
            [EnumMember(Value = "tokenization")]
            Tokenization = 3

        }


        /// <summary>
        /// Indicates the type of request to which the rule applies.  Possible values: **authorization**, **authentication**, **tokenization**.
        /// </summary>
        /// <value>Indicates the type of request to which the rule applies.  Possible values: **authorization**, **authentication**, **tokenization**.</value>
        [DataMember(Name = "requestType", EmitDefaultValue = false)]
        public RequestTypeEnum? RequestType { get; set; }
        /// <summary>
        /// The status of the transaction rule. If you provide a &#x60;startDate&#x60; in the request, the rule is automatically created  with an **active** status.   Possible values: **active**, **inactive**.
        /// </summary>
        /// <value>The status of the transaction rule. If you provide a &#x60;startDate&#x60; in the request, the rule is automatically created  with an **active** status.   Possible values: **active**, **inactive**.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum Active for value: active
            /// </summary>
            [EnumMember(Value = "active")]
            Active = 1,

            /// <summary>
            /// Enum Inactive for value: inactive
            /// </summary>
            [EnumMember(Value = "inactive")]
            Inactive = 2

        }


        /// <summary>
        /// The status of the transaction rule. If you provide a &#x60;startDate&#x60; in the request, the rule is automatically created  with an **active** status.   Possible values: **active**, **inactive**.
        /// </summary>
        /// <value>The status of the transaction rule. If you provide a &#x60;startDate&#x60; in the request, the rule is automatically created  with an **active** status.   Possible values: **active**, **inactive**.</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// The [type of rule](https://docs.adyen.com/issuing/transaction-rules#rule-types), which defines if a rule blocks transactions based on individual characteristics or accumulates data.  Possible values:  * **blockList**: decline a transaction when the conditions are met.  * **maxUsage**: add the amount or number of transactions for the lifetime of a payment instrument, and then decline a transaction when the specified limits are met.  * **velocity**: add the amount or number of transactions based on a specified time interval, and then decline a transaction when the specified limits are met. 
        /// </summary>
        /// <value>The [type of rule](https://docs.adyen.com/issuing/transaction-rules#rule-types), which defines if a rule blocks transactions based on individual characteristics or accumulates data.  Possible values:  * **blockList**: decline a transaction when the conditions are met.  * **maxUsage**: add the amount or number of transactions for the lifetime of a payment instrument, and then decline a transaction when the specified limits are met.  * **velocity**: add the amount or number of transactions based on a specified time interval, and then decline a transaction when the specified limits are met. </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum AllowList for value: allowList
            /// </summary>
            [EnumMember(Value = "allowList")]
            AllowList = 1,

            /// <summary>
            /// Enum BlockList for value: blockList
            /// </summary>
            [EnumMember(Value = "blockList")]
            BlockList = 2,

            /// <summary>
            /// Enum MaxUsage for value: maxUsage
            /// </summary>
            [EnumMember(Value = "maxUsage")]
            MaxUsage = 3,

            /// <summary>
            /// Enum Velocity for value: velocity
            /// </summary>
            [EnumMember(Value = "velocity")]
            Velocity = 4

        }


        /// <summary>
        /// The [type of rule](https://docs.adyen.com/issuing/transaction-rules#rule-types), which defines if a rule blocks transactions based on individual characteristics or accumulates data.  Possible values:  * **blockList**: decline a transaction when the conditions are met.  * **maxUsage**: add the amount or number of transactions for the lifetime of a payment instrument, and then decline a transaction when the specified limits are met.  * **velocity**: add the amount or number of transactions based on a specified time interval, and then decline a transaction when the specified limits are met. 
        /// </summary>
        /// <value>The [type of rule](https://docs.adyen.com/issuing/transaction-rules#rule-types), which defines if a rule blocks transactions based on individual characteristics or accumulates data.  Possible values:  * **blockList**: decline a transaction when the conditions are met.  * **maxUsage**: add the amount or number of transactions for the lifetime of a payment instrument, and then decline a transaction when the specified limits are met.  * **velocity**: add the amount or number of transactions based on a specified time interval, and then decline a transaction when the specified limits are met. </value>
        [DataMember(Name = "type", IsRequired = false, EmitDefaultValue = false)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionRule" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TransactionRule() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionRule" /> class.
        /// </summary>
        /// <param name="aggregationLevel">The level at which data must be accumulated, used in rules with &#x60;type&#x60; **velocity** or **maxUsage**. The level must be the [same or lower in hierarchy](https://docs.adyen.com/issuing/transaction-rules#accumulate-data) than the &#x60;entityKey&#x60;.  If not provided, by default, the rule will accumulate data at the **paymentInstrument** level.  Possible values: **paymentInstrument**, **paymentInstrumentGroup**, **balanceAccount**, **accountHolder**, **balancePlatform**..</param>
        /// <param name="description">Your description for the transaction rule, maximum 300 characters. (required).</param>
        /// <param name="endDate">The date when the rule will stop being evaluated, in ISO 8601 extended offset date-time format. For example, **2020-12-18T10:15:30+01:00**.  If not provided, the rule will be evaluated until the rule status is set to **inactive**..</param>
        /// <param name="entityKey">entityKey (required).</param>
        /// <param name="id">The unique identifier of the transaction rule..</param>
        /// <param name="interval">interval (required).</param>
        /// <param name="outcomeType">The [outcome](https://docs.adyen.com/issuing/transaction-rules#outcome) that will be applied when a transaction meets the conditions of the rule. If not provided, by default, this is set to **hardBlock**.  Possible values:   * **hardBlock**: the transaction is declined.  * **scoreBased**: the transaction is assigned the &#x60;score&#x60; you specified. Adyen calculates the total score and if it exceeds 100, the transaction is declined..</param>
        /// <param name="reference">Your reference for the transaction rule, maximum 150 characters. (required).</param>
        /// <param name="requestType">Indicates the type of request to which the rule applies.  Possible values: **authorization**, **authentication**, **tokenization**..</param>
        /// <param name="ruleRestrictions">ruleRestrictions (required).</param>
        /// <param name="score">A positive or negative score applied to the transaction if it meets the conditions of the rule. Required when &#x60;outcomeType&#x60; is **scoreBased**.  The value must be between **-100** and **100**..</param>
        /// <param name="startDate">The date when the rule will start to be evaluated, in ISO 8601 extended offset date-time format. For example, **2020-12-18T10:15:30+01:00**.  If not provided when creating a transaction rule, the &#x60;startDate&#x60; is set to the date when the rule status is set to **active**.   .</param>
        /// <param name="status">The status of the transaction rule. If you provide a &#x60;startDate&#x60; in the request, the rule is automatically created  with an **active** status.   Possible values: **active**, **inactive**..</param>
        /// <param name="type">The [type of rule](https://docs.adyen.com/issuing/transaction-rules#rule-types), which defines if a rule blocks transactions based on individual characteristics or accumulates data.  Possible values:  * **blockList**: decline a transaction when the conditions are met.  * **maxUsage**: add the amount or number of transactions for the lifetime of a payment instrument, and then decline a transaction when the specified limits are met.  * **velocity**: add the amount or number of transactions based on a specified time interval, and then decline a transaction when the specified limits are met.  (required).</param>
        public TransactionRule(string aggregationLevel = default(string), string description = default(string), string endDate = default(string), TransactionRuleEntityKey entityKey = default(TransactionRuleEntityKey), string id = default(string), TransactionRuleInterval interval = default(TransactionRuleInterval), OutcomeTypeEnum? outcomeType = default(OutcomeTypeEnum?), string reference = default(string), RequestTypeEnum? requestType = default(RequestTypeEnum?), TransactionRuleRestrictions ruleRestrictions = default(TransactionRuleRestrictions), int? score = default(int?), string startDate = default(string), StatusEnum? status = default(StatusEnum?), TypeEnum type = default(TypeEnum))
        {
            this.Description = description;
            this.EntityKey = entityKey;
            this.Interval = interval;
            this.Reference = reference;
            this.RuleRestrictions = ruleRestrictions;
            this.Type = type;
            this.AggregationLevel = aggregationLevel;
            this.EndDate = endDate;
            this.Id = id;
            this.OutcomeType = outcomeType;
            this.RequestType = requestType;
            this.Score = score;
            this.StartDate = startDate;
            this.Status = status;
        }

        /// <summary>
        /// The level at which data must be accumulated, used in rules with &#x60;type&#x60; **velocity** or **maxUsage**. The level must be the [same or lower in hierarchy](https://docs.adyen.com/issuing/transaction-rules#accumulate-data) than the &#x60;entityKey&#x60;.  If not provided, by default, the rule will accumulate data at the **paymentInstrument** level.  Possible values: **paymentInstrument**, **paymentInstrumentGroup**, **balanceAccount**, **accountHolder**, **balancePlatform**.
        /// </summary>
        /// <value>The level at which data must be accumulated, used in rules with &#x60;type&#x60; **velocity** or **maxUsage**. The level must be the [same or lower in hierarchy](https://docs.adyen.com/issuing/transaction-rules#accumulate-data) than the &#x60;entityKey&#x60;.  If not provided, by default, the rule will accumulate data at the **paymentInstrument** level.  Possible values: **paymentInstrument**, **paymentInstrumentGroup**, **balanceAccount**, **accountHolder**, **balancePlatform**.</value>
        [DataMember(Name = "aggregationLevel", EmitDefaultValue = false)]
        public string AggregationLevel { get; set; }

        /// <summary>
        /// Your description for the transaction rule, maximum 300 characters.
        /// </summary>
        /// <value>Your description for the transaction rule, maximum 300 characters.</value>
        [DataMember(Name = "description", IsRequired = false, EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// The date when the rule will stop being evaluated, in ISO 8601 extended offset date-time format. For example, **2020-12-18T10:15:30+01:00**.  If not provided, the rule will be evaluated until the rule status is set to **inactive**.
        /// </summary>
        /// <value>The date when the rule will stop being evaluated, in ISO 8601 extended offset date-time format. For example, **2020-12-18T10:15:30+01:00**.  If not provided, the rule will be evaluated until the rule status is set to **inactive**.</value>
        [DataMember(Name = "endDate", EmitDefaultValue = false)]
        public string EndDate { get; set; }

        /// <summary>
        /// Gets or Sets EntityKey
        /// </summary>
        [DataMember(Name = "entityKey", IsRequired = false, EmitDefaultValue = false)]
        public TransactionRuleEntityKey EntityKey { get; set; }

        /// <summary>
        /// The unique identifier of the transaction rule.
        /// </summary>
        /// <value>The unique identifier of the transaction rule.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Interval
        /// </summary>
        [DataMember(Name = "interval", IsRequired = false, EmitDefaultValue = false)]
        public TransactionRuleInterval Interval { get; set; }

        /// <summary>
        /// Your reference for the transaction rule, maximum 150 characters.
        /// </summary>
        /// <value>Your reference for the transaction rule, maximum 150 characters.</value>
        [DataMember(Name = "reference", IsRequired = false, EmitDefaultValue = false)]
        public string Reference { get; set; }

        /// <summary>
        /// Gets or Sets RuleRestrictions
        /// </summary>
        [DataMember(Name = "ruleRestrictions", IsRequired = false, EmitDefaultValue = false)]
        public TransactionRuleRestrictions RuleRestrictions { get; set; }

        /// <summary>
        /// A positive or negative score applied to the transaction if it meets the conditions of the rule. Required when &#x60;outcomeType&#x60; is **scoreBased**.  The value must be between **-100** and **100**.
        /// </summary>
        /// <value>A positive or negative score applied to the transaction if it meets the conditions of the rule. Required when &#x60;outcomeType&#x60; is **scoreBased**.  The value must be between **-100** and **100**.</value>
        [DataMember(Name = "score", EmitDefaultValue = false)]
        public int? Score { get; set; }

        /// <summary>
        /// The date when the rule will start to be evaluated, in ISO 8601 extended offset date-time format. For example, **2020-12-18T10:15:30+01:00**.  If not provided when creating a transaction rule, the &#x60;startDate&#x60; is set to the date when the rule status is set to **active**.   
        /// </summary>
        /// <value>The date when the rule will start to be evaluated, in ISO 8601 extended offset date-time format. For example, **2020-12-18T10:15:30+01:00**.  If not provided when creating a transaction rule, the &#x60;startDate&#x60; is set to the date when the rule status is set to **active**.   </value>
        [DataMember(Name = "startDate", EmitDefaultValue = false)]
        public string StartDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TransactionRule {\n");
            sb.Append("  AggregationLevel: ").Append(AggregationLevel).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  EntityKey: ").Append(EntityKey).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Interval: ").Append(Interval).Append("\n");
            sb.Append("  OutcomeType: ").Append(OutcomeType).Append("\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
            sb.Append("  RequestType: ").Append(RequestType).Append("\n");
            sb.Append("  RuleRestrictions: ").Append(RuleRestrictions).Append("\n");
            sb.Append("  Score: ").Append(Score).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return this.Equals(input as TransactionRule);
        }

        /// <summary>
        /// Returns true if TransactionRule instances are equal
        /// </summary>
        /// <param name="input">Instance of TransactionRule to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransactionRule input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AggregationLevel == input.AggregationLevel ||
                    (this.AggregationLevel != null &&
                    this.AggregationLevel.Equals(input.AggregationLevel))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.EndDate == input.EndDate ||
                    (this.EndDate != null &&
                    this.EndDate.Equals(input.EndDate))
                ) && 
                (
                    this.EntityKey == input.EntityKey ||
                    (this.EntityKey != null &&
                    this.EntityKey.Equals(input.EntityKey))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Interval == input.Interval ||
                    (this.Interval != null &&
                    this.Interval.Equals(input.Interval))
                ) && 
                (
                    this.OutcomeType == input.OutcomeType ||
                    this.OutcomeType.Equals(input.OutcomeType)
                ) && 
                (
                    this.Reference == input.Reference ||
                    (this.Reference != null &&
                    this.Reference.Equals(input.Reference))
                ) && 
                (
                    this.RequestType == input.RequestType ||
                    this.RequestType.Equals(input.RequestType)
                ) && 
                (
                    this.RuleRestrictions == input.RuleRestrictions ||
                    (this.RuleRestrictions != null &&
                    this.RuleRestrictions.Equals(input.RuleRestrictions))
                ) && 
                (
                    this.Score == input.Score ||
                    this.Score.Equals(input.Score)
                ) && 
                (
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
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
                if (this.AggregationLevel != null)
                {
                    hashCode = (hashCode * 59) + this.AggregationLevel.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.EndDate != null)
                {
                    hashCode = (hashCode * 59) + this.EndDate.GetHashCode();
                }
                if (this.EntityKey != null)
                {
                    hashCode = (hashCode * 59) + this.EntityKey.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.Interval != null)
                {
                    hashCode = (hashCode * 59) + this.Interval.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.OutcomeType.GetHashCode();
                if (this.Reference != null)
                {
                    hashCode = (hashCode * 59) + this.Reference.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.RequestType.GetHashCode();
                if (this.RuleRestrictions != null)
                {
                    hashCode = (hashCode * 59) + this.RuleRestrictions.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Score.GetHashCode();
                if (this.StartDate != null)
                {
                    hashCode = (hashCode * 59) + this.StartDate.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Status.GetHashCode();
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
            // Description (string) maxLength
            if (this.Description != null && this.Description.Length > 300)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Description, length must be less than 300.", new [] { "Description" });
            }

            // Reference (string) maxLength
            if (this.Reference != null && this.Reference.Length > 150)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Reference, length must be less than 150.", new [] { "Reference" });
            }

            yield break;
        }
    }

}
