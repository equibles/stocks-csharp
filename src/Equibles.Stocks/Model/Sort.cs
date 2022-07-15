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
    /// Defines Sort
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
        public enum Sort
    {
        /// <summary>
        /// Enum Ascending for value: Ascending
        /// </summary>
        [EnumMember(Value = "Ascending")]
        Ascending = 1,
        /// <summary>
        /// Enum Descending for value: Descending
        /// </summary>
        [EnumMember(Value = "Descending")]
        Descending = 2    }
}
