# Equibles.Stocks.Api.NewsApi

All URIs are relative to *https://api.equibles.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CallList**](NewsApi.md#calllist) | **GET** /stocks/news/list | List News
[**Publishers**](NewsApi.md#publishers) | **GET** /stocks/news/publishers | List Publishers

<a name="calllist"></a>
# **CallList**
> NewsResponse CallList (string apiKey, string fullTicker, string publisherName, int? page, int? pageSize)

List News

Get the latest news for a stock.

### Example
```csharp
using System;
using System.Diagnostics;
using Equibles.Stocks.Api;
using Equibles.Stocks.Client;
using Equibles.Stocks.Model;

namespace Example
{
    public class CallListExample
    {
        public void main()
        {
            // Configure API key authorization: Query String
            Configuration.Default.AddApiKey("apiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("apiKey", "Bearer");

            var apiInstance = new NewsApi();
            var apiKey = apiKey_example;  // string | 
            var fullTicker = fullTicker_example;  // string | The fully qualified ticker of the stock used to filter the results. Example: AAPL.XNAS (optional) 
            var publisherName = publisherName_example;  // string | A news publisher used to filter the results. (optional) 
            var page = 56;  // int? | The number of the page to request. (optional)  (default to 1)
            var pageSize = 56;  // int? | The number of elements in each page. Max value: 500. (optional)  (default to 100)

            try
            {
                // List News
                NewsResponse result = apiInstance.CallList(apiKey, fullTicker, publisherName, page, pageSize);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NewsApi.CallList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **apiKey** | **string**|  | 
 **fullTicker** | **string**| The fully qualified ticker of the stock used to filter the results. Example: AAPL.XNAS | [optional] 
 **publisherName** | **string**| A news publisher used to filter the results. | [optional] 
 **page** | **int?**| The number of the page to request. | [optional] [default to 1]
 **pageSize** | **int?**| The number of elements in each page. Max value: 500. | [optional] [default to 100]

### Return type

[**NewsResponse**](NewsResponse.md)

### Authorization

[Query String](../README.md#Query String)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="publishers"></a>
# **Publishers**
> PublishersResponse Publishers (string apiKey, int? page, int? pageSize)

List Publishers

Get all the publishers.

### Example
```csharp
using System;
using System.Diagnostics;
using Equibles.Stocks.Api;
using Equibles.Stocks.Client;
using Equibles.Stocks.Model;

namespace Example
{
    public class PublishersExample
    {
        public void main()
        {
            // Configure API key authorization: Query String
            Configuration.Default.AddApiKey("apiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("apiKey", "Bearer");

            var apiInstance = new NewsApi();
            var apiKey = apiKey_example;  // string | 
            var page = 56;  // int? | The number of the page to request. (optional)  (default to 1)
            var pageSize = 56;  // int? | The number of elements in each page. Max value: 1000. (optional)  (default to 100)

            try
            {
                // List Publishers
                PublishersResponse result = apiInstance.Publishers(apiKey, page, pageSize);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NewsApi.Publishers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **apiKey** | **string**|  | 
 **page** | **int?**| The number of the page to request. | [optional] [default to 1]
 **pageSize** | **int?**| The number of elements in each page. Max value: 1000. | [optional] [default to 100]

### Return type

[**PublishersResponse**](PublishersResponse.md)

### Authorization

[Query String](../README.md#Query String)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
