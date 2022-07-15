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
    /// Price
    /// </summary>
    [DataContract]
        public partial class Price :  IEquatable<Price>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Price" /> class.
        /// </summary>
        /// <param name="close">close.</param>
        /// <param name="high">high.</param>
        /// <param name="low">low.</param>
        /// <param name="open">open.</param>
        /// <param name="volume">volume.</param>
        /// <param name="time">time.</param>
        public Price(double? close = default(double?), double? high = default(double?), double? low = default(double?), double? open = default(double?), long? volume = default(long?), DateTime? time = default(DateTime?))
        {
            this.Close = close;
            this.High = high;
            this.Low = low;
            this.Open = open;
            this.Volume = volume;
            this.Time = time;
        }
        
        /// <summary>
        /// Gets or Sets Close
        /// </summary>
        [DataMember(Name="close", EmitDefaultValue=false)]
        public double? Close { get; set; }

        /// <summary>
        /// Gets or Sets High
        /// </summary>
        [DataMember(Name="high", EmitDefaultValue=false)]
        public double? High { get; set; }

        /// <summary>
        /// Gets or Sets Low
        /// </summary>
        [DataMember(Name="low", EmitDefaultValue=false)]
        public double? Low { get; set; }

        /// <summary>
        /// Gets or Sets Open
        /// </summary>
        [DataMember(Name="open", EmitDefaultValue=false)]
        public double? Open { get; set; }

        /// <summary>
        /// Gets or Sets Volume
        /// </summary>
        [DataMember(Name="volume", EmitDefaultValue=false)]
        public long? Volume { get; set; }

        /// <summary>
        /// Gets or Sets Time
        /// </summary>
        [DataMember(Name="time", EmitDefaultValue=false)]
        public DateTime? Time { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Price {\n");
            sb.Append("  Close: ").Append(Close).Append("\n");
            sb.Append("  High: ").Append(High).Append("\n");
            sb.Append("  Low: ").Append(Low).Append("\n");
            sb.Append("  Open: ").Append(Open).Append("\n");
            sb.Append("  Volume: ").Append(Volume).Append("\n");
            sb.Append("  Time: ").Append(Time).Append("\n");
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
            return this.Equals(input as Price);
        }

        /// <summary>
        /// Returns true if Price instances are equal
        /// </summary>
        /// <param name="input">Instance of Price to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Price input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Close == input.Close ||
                    (this.Close != null &&
                    this.Close.Equals(input.Close))
                ) && 
                (
                    this.High == input.High ||
                    (this.High != null &&
                    this.High.Equals(input.High))
                ) && 
                (
                    this.Low == input.Low ||
                    (this.Low != null &&
                    this.Low.Equals(input.Low))
                ) && 
                (
                    this.Open == input.Open ||
                    (this.Open != null &&
                    this.Open.Equals(input.Open))
                ) && 
                (
                    this.Volume == input.Volume ||
                    (this.Volume != null &&
                    this.Volume.Equals(input.Volume))
                ) && 
                (
                    this.Time == input.Time ||
                    (this.Time != null &&
                    this.Time.Equals(input.Time))
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
                if (this.Close != null)
                    hashCode = hashCode * 59 + this.Close.GetHashCode();
                if (this.High != null)
                    hashCode = hashCode * 59 + this.High.GetHashCode();
                if (this.Low != null)
                    hashCode = hashCode * 59 + this.Low.GetHashCode();
                if (this.Open != null)
                    hashCode = hashCode * 59 + this.Open.GetHashCode();
                if (this.Volume != null)
                    hashCode = hashCode * 59 + this.Volume.GetHashCode();
                if (this.Time != null)
                    hashCode = hashCode * 59 + this.Time.GetHashCode();
                return hashCode;
            }
        }
    }
}