# Equibles.Stocks.Api.PricesApi

All URIs are relative to *https://api.equibles.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**EndOfDay**](PricesApi.md#endofday) | **GET** /stocks/prices/endofday | End Of Day Prices
[**Intraday**](PricesApi.md#intraday) | **GET** /stocks/prices/intraday | Intraday Prices
[**Summary**](PricesApi.md#summary) | **GET** /stocks/prices/summary | Latest trading day summary

<a name="endofday"></a>
# **EndOfDay**
> PricesResponse EndOfDay (string apiKey, string fullTicker, DateTime? startTime, DateTime? endTime, Sort sort, int? page, int? pageSize)

End Of Day Prices

Lists the end of day prices for a given stock.

### Example
```csharp
using System;
using System.Diagnostics;
using Equibles.Stocks.Api;
using Equibles.Stocks.Client;
using Equibles.Stocks.Model;

namespace Example
{
    public class EndOfDayExample
    {
        public void main()
        {
            // Configure API key authorization: Query String
            Configuration.Default.AddApiKey("apiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("apiKey", "Bearer");

            var apiInstance = new PricesApi();
            var apiKey = apiKey_example;  // string | 
            var fullTicker = fullTicker_example;  // string | The fully qualified ticker of the stock. Example: AAPL.XNAS
            var startTime = 2013-10-20T19:20:30+01:00;  // DateTime? | The start time of the window. UTC time formatted according to ISO 8601 (i.e: 2022-02-01T13:45:17) (optional) 
            var endTime = 2013-10-20T19:20:30+01:00;  // DateTime? | The end time of the window. UTC time formatted according to ISO 8601 (i.e: 2022-02-01T13:45:17) (optional) 
            var sort = new Sort(); // Sort | The method of sorting the results. The sorting is based on the time axis. (optional) 
            var page = 56;  // int? | The number of the page to request. (optional)  (default to 1)
            var pageSize = 56;  // int? | The number of elements in each page. Max value: 50000. (optional)  (default to 1000)

            try
            {
                // End Of Day Prices
                PricesResponse result = apiInstance.EndOfDay(apiKey, fullTicker, startTime, endTime, sort, page, pageSize);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PricesApi.EndOfDay: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **apiKey** | **string**|  | 
 **fullTicker** | **string**| The fully qualified ticker of the stock. Example: AAPL.XNAS | 
 **startTime** | **DateTime?**| The start time of the window. UTC time formatted according to ISO 8601 (i.e: 2022-02-01T13:45:17) | [optional] 
 **endTime** | **DateTime?**| The end time of the window. UTC time formatted according to ISO 8601 (i.e: 2022-02-01T13:45:17) | [optional] 
 **sort** | [**Sort**](Sort.md)| The method of sorting the results. The sorting is based on the time axis. | [optional] 
 **page** | **int?**| The number of the page to request. | [optional] [default to 1]
 **pageSize** | **int?**| The number of elements in each page. Max value: 50000. | [optional] [default to 1000]

### Return type

[**PricesResponse**](PricesResponse.md)

### Authorization

[Query String](../README.md#Query String)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="intraday"></a>
# **Intraday**
> PricesResponse Intraday (string apiKey, string fullTicker, DateTime? startTime, DateTime? endTime, Sort sort, int? page, int? pageSize)

Intraday Prices

Lists the intraday prices for a given stock with one minute precision.

### Example
```csharp
using System;
using System.Diagnostics;
using Equibles.Stocks.Api;
using Equibles.Stocks.Client;
using Equibles.Stocks.Model;

namespace Example
{
    public class IntradayExample
    {
        public void main()
        {
            // Configure API key authorization: Query String
            Configuration.Default.AddApiKey("apiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("apiKey", "Bearer");

            var apiInstance = new PricesApi();
            var apiKey = apiKey_example;  // string | 
            var fullTicker = fullTicker_example;  // string | The fully qualified ticker of the stock. Example: AAPL.XNAS
            var startTime = 2013-10-20T19:20:30+01:00;  // DateTime? | The start time of the window. UTC time formatted according to ISO 8601 (i.e: 2022-02-01T13:45:17) (optional) 
            var endTime = 2013-10-20T19:20:30+01:00;  // DateTime? | The end time of the window. UTC time formatted according to ISO 8601 (i.e: 2022-02-01T13:45:17) (optional) 
            var sort = new Sort(); // Sort | The method of sorting the results. The sorting is based on the time axis. (optional) 
            var page = 56;  // int? | The number of the page to request. (optional)  (default to 1)
            var pageSize = 56;  // int? | The number of elements in each page. Max value: 50000. (optional)  (default to 1000)

            try
            {
                // Intraday Prices
                PricesResponse result = apiInstance.Intraday(apiKey, fullTicker, startTime, endTime, sort, page, pageSize);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PricesApi.Intraday: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **apiKey** | **string**|  | 
 **fullTicker** | **string**| The fully qualified ticker of the stock. Example: AAPL.XNAS | 
 **startTime** | **DateTime?**| The start time of the window. UTC time formatted according to ISO 8601 (i.e: 2022-02-01T13:45:17) | [optional] 
 **endTime** | **DateTime?**| The end time of the window. UTC time formatted according to ISO 8601 (i.e: 2022-02-01T13:45:17) | [optional] 
 **sort** | [**Sort**](Sort.md)| The method of sorting the results. The sorting is based on the time axis. | [optional] 
 **page** | **int?**| The number of the page to request. | [optional] [default to 1]
 **pageSize** | **int?**| The number of elements in each page. Max value: 50000. | [optional] [default to 1000]

### Return type

[**PricesResponse**](PricesResponse.md)

### Authorization

[Query String](../README.md#Query String)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="summary"></a>
# **Summary**
> PriceSummaryResponse Summary (string apiKey, string fullTicker)

Latest trading day summary

A summary of the latest trading day

### Example
```csharp
using System;
using System.Diagnostics;
using Equibles.Stocks.Api;
using Equibles.Stocks.Client;
using Equibles.Stocks.Model;

namespace Example
{
    public class SummaryExample
    {
        public void main()
        {
            // Configure API key authorization: Query String
            Configuration.Default.AddApiKey("apiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("apiKey", "Bearer");

            var apiInstance = new PricesApi();
            var apiKey = apiKey_example;  // string | 
            var fullTicker = fullTicker_example;  // string | The fully qualified ticker of the stock. Example: AAPL.XNAS

            try
            {
                // Latest trading day summary
                PriceSummaryResponse result = apiInstance.Summary(apiKey, fullTicker);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PricesApi.Summary: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **apiKey** | **string**|  | 
 **fullTicker** | **string**| The fully qualified ticker of the stock. Example: AAPL.XNAS | 

### Return type

[**PriceSummaryResponse**](PriceSummaryResponse.md)

### Authorization

[Query String](../README.md#Query String)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
