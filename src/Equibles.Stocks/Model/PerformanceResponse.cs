/* 
 * Stocks
 *
 * <h3>Rate limits</h3>                     Free subscriptions are subject to daily limits. To know how much requests you have left look at the following headers in the response.<br />                     1. <strong>x-ratelimit-limit</strong> - The total number of requests that you are allowed to make in a given period (hour/day)<br />                     2. <strong>x-ratelimit-remaining</strong> - The number of remaining requests that you can perform in the current period.<br />                     3. <strong>x-ratelimit-reset</strong> - The number of seconds until the current period resets.<br />                     <br />                     <br />                     You don't have an API key? <a href=\"https://www.equibles.com/api/pricing\" target=\"_blank\">Get one for free here.</a>
 *
 * OpenAPI spec version: v1
 * Contact: contact@equibles.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using SwaggerDateConverter = Equibles.Stocks.Client.SwaggerDateConverter;

namespace Equibles.Stocks.Model
{
    /// <summary>
    /// PerformanceResponse
    /// </summary>
    [DataContract]
        public partial class PerformanceResponse :  IEquatable<PerformanceResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PerformanceResponse" /> class.
        /// </summary>
        /// <param name="status">status.</param>
        /// <param name="results">results.</param>
        public PerformanceResponse(ResponseStatus status = default(ResponseStatus), Performance results = default(Performance))
        {
            this.Status = status;
            this.Results = results;
        }
        
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public ResponseStatus Status { get; set; }

        /// <summary>
        /// Gets or Sets Results
        /// </summary>
        [DataMember(Name="results", EmitDefaultValue=false)]
        public Performance Results { get; set; }

        /// <summary>
        /// The total number of results in this response.
        /// </summary>
        /// <value>The total number of results in this response.</value>
        [DataMember(Name="count", EmitDefaultValue=false)]
        public int? Count { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PerformanceResponse {\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Results: ").Append(Results).Append("\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
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
            return this.Equals(input as PerformanceResponse);
        }

        /// <summary>
        /// Returns true if PerformanceResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of PerformanceResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PerformanceResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Results == input.Results ||
                    (this.Results != null &&
                    this.Results.Equals(input.Results))
                ) && 
                (
                    this.Count == input.Count ||
                    (this.Count != null &&
                    this.Count.Equals(input.Count))
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
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Results != null)
                    hashCode = hashCode * 59 + this.Results.GetHashCode();
                if (this.Count != null)
                    hashCode = hashCode * 59 + this.Count.GetHashCode();
                return hashCode;
            }
        }
    }
}
