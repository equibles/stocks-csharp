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
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp.Portable;
using Equibles.Stocks.Client;
using Equibles.Stocks.Model;

namespace Equibles.Stocks.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
        public interface IPerformanceApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Performance
        /// </summary>
        /// <remarks>
        /// Returns the performance for a given stock.
        /// </remarks>
        /// <exception cref="Equibles.Stocks.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiKey"></param>
        /// <param name="fullTicker">The fully qualified ticker of the stock. Example: AAPL.XNAS</param>
        /// <returns>PerformanceResponse</returns>
        PerformanceResponse CallList (string apiKey, string fullTicker);

        /// <summary>
        /// Performance
        /// </summary>
        /// <remarks>
        /// Returns the performance for a given stock.
        /// </remarks>
        /// <exception cref="Equibles.Stocks.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiKey"></param>
        /// <param name="fullTicker">The fully qualified ticker of the stock. Example: AAPL.XNAS</param>
        /// <returns>ApiResponse of PerformanceResponse</returns>
        ApiResponse<PerformanceResponse> CallListWithHttpInfo (string apiKey, string fullTicker);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Performance
        /// </summary>
        /// <remarks>
        /// Returns the performance for a given stock.
        /// </remarks>
        /// <exception cref="Equibles.Stocks.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiKey"></param>
        /// <param name="fullTicker">The fully qualified ticker of the stock. Example: AAPL.XNAS</param>
        /// <returns>Task of PerformanceResponse</returns>
        System.Threading.Tasks.Task<PerformanceResponse> CallListAsync (string apiKey, string fullTicker);

        /// <summary>
        /// Performance
        /// </summary>
        /// <remarks>
        /// Returns the performance for a given stock.
        /// </remarks>
        /// <exception cref="Equibles.Stocks.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiKey"></param>
        /// <param name="fullTicker">The fully qualified ticker of the stock. Example: AAPL.XNAS</param>
        /// <returns>Task of ApiResponse (PerformanceResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PerformanceResponse>> CallListAsyncWithHttpInfo (string apiKey, string fullTicker);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
        public partial class PerformanceApi : IPerformanceApi
    {
        private Equibles.Stocks.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="PerformanceApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PerformanceApi(String basePath)
        {
            this.Configuration = new Equibles.Stocks.Client.Configuration { BasePath = basePath };

            ExceptionFactory = Equibles.Stocks.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PerformanceApi"/> class
        /// </summary>
        /// <returns></returns>
        public PerformanceApi()
        {
            this.Configuration = Equibles.Stocks.Client.Configuration.Default;

            ExceptionFactory = Equibles.Stocks.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PerformanceApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public PerformanceApi(Equibles.Stocks.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Equibles.Stocks.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = Equibles.Stocks.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Equibles.Stocks.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Equibles.Stocks.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Performance Returns the performance for a given stock.
        /// </summary>
        /// <exception cref="Equibles.Stocks.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiKey"></param>
        /// <param name="fullTicker">The fully qualified ticker of the stock. Example: AAPL.XNAS</param>
        /// <returns>PerformanceResponse</returns>
        public PerformanceResponse CallList (string apiKey, string fullTicker)
        {
             ApiResponse<PerformanceResponse> localVarResponse = CallListWithHttpInfo(apiKey, fullTicker);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Performance Returns the performance for a given stock.
        /// </summary>
        /// <exception cref="Equibles.Stocks.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiKey"></param>
        /// <param name="fullTicker">The fully qualified ticker of the stock. Example: AAPL.XNAS</param>
        /// <returns>ApiResponse of PerformanceResponse</returns>
        public ApiResponse< PerformanceResponse > CallListWithHttpInfo (string apiKey, string fullTicker)
        {
            // verify the required parameter 'apiKey' is set
            if (apiKey == null)
                throw new ApiException(400, "Missing required parameter 'apiKey' when calling PerformanceApi->CallList");
            // verify the required parameter 'fullTicker' is set
            if (fullTicker == null)
                throw new ApiException(400, "Missing required parameter 'fullTicker' when calling PerformanceApi->CallList");

            var localVarPath = "./stocks/performance/list";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (apiKey != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "apiKey", apiKey)); // query parameter
            if (fullTicker != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "fullTicker", fullTicker)); // query parameter
            // authentication (Query String) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("apiKey")))
            {
                localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "apiKey", this.Configuration.GetApiKeyWithPrefix("apiKey")));
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CallList", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PerformanceResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (PerformanceResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PerformanceResponse)));
        }

        /// <summary>
        /// Performance Returns the performance for a given stock.
        /// </summary>
        /// <exception cref="Equibles.Stocks.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiKey"></param>
        /// <param name="fullTicker">The fully qualified ticker of the stock. Example: AAPL.XNAS</param>
        /// <returns>Task of PerformanceResponse</returns>
        public async System.Threading.Tasks.Task<PerformanceResponse> CallListAsync (string apiKey, string fullTicker)
        {
             ApiResponse<PerformanceResponse> localVarResponse = await CallListAsyncWithHttpInfo(apiKey, fullTicker);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Performance Returns the performance for a given stock.
        /// </summary>
        /// <exception cref="Equibles.Stocks.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="apiKey"></param>
        /// <param name="fullTicker">The fully qualified ticker of the stock. Example: AAPL.XNAS</param>
        /// <returns>Task of ApiResponse (PerformanceResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PerformanceResponse>> CallListAsyncWithHttpInfo (string apiKey, string fullTicker)
        {
            // verify the required parameter 'apiKey' is set
            if (apiKey == null)
                throw new ApiException(400, "Missing required parameter 'apiKey' when calling PerformanceApi->CallList");
            // verify the required parameter 'fullTicker' is set
            if (fullTicker == null)
                throw new ApiException(400, "Missing required parameter 'fullTicker' when calling PerformanceApi->CallList");

            var localVarPath = "./stocks/performance/list";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (apiKey != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "apiKey", apiKey)); // query parameter
            if (fullTicker != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "fullTicker", fullTicker)); // query parameter
            // authentication (Query String) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("apiKey")))
            {
                localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "apiKey", this.Configuration.GetApiKeyWithPrefix("apiKey")));
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CallList", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PerformanceResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => string.Join(",", x.Value)),
                (PerformanceResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PerformanceResponse)));
        }

    }
}