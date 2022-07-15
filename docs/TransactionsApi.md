# Equibles.Stocks.Api.TransactionsApi

All URIs are relative to *https://api.equibles.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Insiders**](TransactionsApi.md#insiders) | **GET** /stocks/transactions/insiders | Insider Transactions
[**Institutional**](TransactionsApi.md#institutional) | **GET** /stocks/transactions/institutional | Institutional Transactions

<a name="insiders"></a>
# **Insiders**
> TransactionsResponse Insiders (string apiKey, string fullTicker, int? page, int? pageSize)

Insider Transactions

Lists the insider transactions for a given stock.

### Example
```csharp
using System;
using System.Diagnostics;
using Equibles.Stocks.Api;
using Equibles.Stocks.Client;
using Equibles.Stocks.Model;

namespace Example
{
    public class InsidersExample
    {
        public void main()
        {
            // Configure API key authorization: Query String
            Configuration.Default.AddApiKey("apiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("apiKey", "Bearer");

            var apiInstance = new TransactionsApi();
            var apiKey = apiKey_example;  // string | 
            var fullTicker = fullTicker_example;  // string | The fully qualified ticker of the stock. Example: AAPL.XNAS
            var page = 56;  // int? | The number of the page to request. (optional)  (default to 1)
            var pageSize = 56;  // int? | The number of elements in each page. Max value: 1000. (optional)  (default to 1000)

            try
            {
                // Insider Transactions
                TransactionsResponse result = apiInstance.Insiders(apiKey, fullTicker, page, pageSize);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionsApi.Insiders: " + e.Message );
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

[**TransactionsResponse**](TransactionsResponse.md)

### Authorization

[Query String](../README.md#Query String)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="institutional"></a>
# **Institutional**
> TransactionsResponse Institutional (string apiKey, string fullTicker, int? page, int? pageSize)

Institutional Transactions

Lists the institutional transactions for a given stock.

### Example
```csharp
using System;
using System.Diagnostics;
using Equibles.Stocks.Api;
using Equibles.Stocks.Client;
using Equibles.Stocks.Model;

namespace Example
{
    public class InstitutionalExample
    {
        public void main()
        {
            // Configure API key authorization: Query String
            Configuration.Default.AddApiKey("apiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("apiKey", "Bearer");

            var apiInstance = new TransactionsApi();
            var apiKey = apiKey_example;  // string | 
            var fullTicker = fullTicker_example;  // string | The fully qualified ticker of the stock. Example: AAPL.XNAS
            var page = 56;  // int? | The number of the page to request. (optional)  (default to 1)
            var pageSize = 56;  // int? | The number of elements in each page. Max value: 1000. (optional)  (default to 1000)

            try
            {
                // Institutional Transactions
                TransactionsResponse result = apiInstance.Institutional(apiKey, fullTicker, page, pageSize);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionsApi.Institutional: " + e.Message );
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

[**TransactionsResponse**](TransactionsResponse.md)

### Authorization

[Query String](../README.md#Query String)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
