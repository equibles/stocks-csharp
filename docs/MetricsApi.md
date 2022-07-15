# Equibles.Stocks.Api.MetricsApi

All URIs are relative to *https://api.equibles.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**PriceToEarnings**](MetricsApi.md#pricetoearnings) | **GET** /stocks/metrics/pricetoearnings | Historical P/E

<a name="pricetoearnings"></a>
# **PriceToEarnings**
> MetricNullablePointsResponse PriceToEarnings (string apiKey, string fullTicker, int? page, int? pageSize)

Historical P/E

Get the price to earnings ratio over time for this stock.

### Example
```csharp
using System;
using System.Diagnostics;
using Equibles.Stocks.Api;
using Equibles.Stocks.Client;
using Equibles.Stocks.Model;

namespace Example
{
    public class PriceToEarningsExample
    {
        public void main()
        {
            // Configure API key authorization: Query String
            Configuration.Default.AddApiKey("apiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("apiKey", "Bearer");

            var apiInstance = new MetricsApi();
            var apiKey = apiKey_example;  // string | 
            var fullTicker = fullTicker_example;  // string | The fully qualified ticker of the stock. Example: AAPL.XNAS
            var page = 56;  // int? | The number of the page to request. (optional)  (default to 1)
            var pageSize = 56;  // int? | The number of elements in each page. Max value: 1000. (optional)  (default to 1000)

            try
            {
                // Historical P/E
                MetricNullablePointsResponse result = apiInstance.PriceToEarnings(apiKey, fullTicker, page, pageSize);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MetricsApi.PriceToEarnings: " + e.Message );
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
 **page** | **int?**| The number of the page to request. | [optional] [default to 1]
 **pageSize** | **int?**| The number of elements in each page. Max value: 1000. | [optional] [default to 1000]

### Return type

[**MetricNullablePointsResponse**](MetricNullablePointsResponse.md)

### Authorization

[Query String](../README.md#Query String)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
