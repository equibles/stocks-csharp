# Equibles.Stocks.Api.StocksApi

All URIs are relative to *https://api.equibles.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CallList**](StocksApi.md#calllist) | **GET** /stocks/list | List Stocks
[**Officers**](StocksApi.md#officers) | **GET** /stocks/officers | Officers
[**Profile**](StocksApi.md#profile) | **GET** /stocks/profile | Profile
[**Screener**](StocksApi.md#screener) | **POST** /stocks/screener | Screener
[**Search**](StocksApi.md#search) | **GET** /stocks/search | Search
[**Splits**](StocksApi.md#splits) | **GET** /stocks/splits | Splits

<a name="calllist"></a>
# **CallList**
> StockProfilesResponse CallList (string apiKey, int? page, int? pageSize)

List Stocks

Get a list of all the available stocks.

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

            var apiInstance = new StocksApi();
            var apiKey = apiKey_example;  // string | 
            var page = 56;  // int? | The number of the page to request. (optional)  (default to 1)
            var pageSize = 56;  // int? | The number of elements in each page. Max value: 100. (optional)  (default to 100)

            try
            {
                // List Stocks
                StockProfilesResponse result = apiInstance.CallList(apiKey, page, pageSize);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StocksApi.CallList: " + e.Message );
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
 **pageSize** | **int?**| The number of elements in each page. Max value: 100. | [optional] [default to 100]

### Return type

[**StockProfilesResponse**](StockProfilesResponse.md)

### Authorization

[Query String](../README.md#Query String)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="officers"></a>
# **Officers**
> OfficersResponse Officers (string apiKey, string fullTicker)

Officers

Get the officers of the company.

### Example
```csharp
using System;
using System.Diagnostics;
using Equibles.Stocks.Api;
using Equibles.Stocks.Client;
using Equibles.Stocks.Model;

namespace Example
{
    public class OfficersExample
    {
        public void main()
        {
            // Configure API key authorization: Query String
            Configuration.Default.AddApiKey("apiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("apiKey", "Bearer");

            var apiInstance = new StocksApi();
            var apiKey = apiKey_example;  // string | 
            var fullTicker = fullTicker_example;  // string | The fully qualified ticker of the stock. Example: AAPL.XNAS

            try
            {
                // Officers
                OfficersResponse result = apiInstance.Officers(apiKey, fullTicker);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StocksApi.Officers: " + e.Message );
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

[**OfficersResponse**](OfficersResponse.md)

### Authorization

[Query String](../README.md#Query String)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="profile"></a>
# **Profile**
> StockProfileResponse Profile (string apiKey, string fullTicker)

Profile

Returns the profile of a given stock.

### Example
```csharp
using System;
using System.Diagnostics;
using Equibles.Stocks.Api;
using Equibles.Stocks.Client;
using Equibles.Stocks.Model;

namespace Example
{
    public class ProfileExample
    {
        public void main()
        {
            // Configure API key authorization: Query String
            Configuration.Default.AddApiKey("apiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("apiKey", "Bearer");

            var apiInstance = new StocksApi();
            var apiKey = apiKey_example;  // string | 
            var fullTicker = fullTicker_example;  // string | The fully qualified ticker of the stock. Example: AAPL.XNAS

            try
            {
                // Profile
                StockProfileResponse result = apiInstance.Profile(apiKey, fullTicker);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StocksApi.Profile: " + e.Message );
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

[**StockProfileResponse**](StockProfileResponse.md)

### Authorization

[Query String](../README.md#Query String)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="screener"></a>
# **Screener**
> StockProfilesResponse Screener (ScreenerRequest body, string apiKey, int? page, int? pageSize)

Screener

Get a list of the stocks constraint to several criteria. You only need to fill the fields that you want to use as filters.

### Example
```csharp
using System;
using System.Diagnostics;
using Equibles.Stocks.Api;
using Equibles.Stocks.Client;
using Equibles.Stocks.Model;

namespace Example
{
    public class ScreenerExample
    {
        public void main()
        {
            // Configure API key authorization: Query String
            Configuration.Default.AddApiKey("apiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("apiKey", "Bearer");

            var apiInstance = new StocksApi();
            var body = new ScreenerRequest(); // ScreenerRequest | The criteria used to filter the search results. You only need to fill the fields that you want to use on the search.
            var apiKey = apiKey_example;  // string | 
            var page = 56;  // int? | The number of the page to request. (optional)  (default to 1)
            var pageSize = 56;  // int? | The number of elements in each page. Max value: 100. (optional)  (default to 100)

            try
            {
                // Screener
                StockProfilesResponse result = apiInstance.Screener(body, apiKey, page, pageSize);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StocksApi.Screener: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ScreenerRequest**](ScreenerRequest.md)| The criteria used to filter the search results. You only need to fill the fields that you want to use on the search. | 
 **apiKey** | **string**|  | 
 **page** | **int?**| The number of the page to request. | [optional] [default to 1]
 **pageSize** | **int?**| The number of elements in each page. Max value: 100. | [optional] [default to 100]

### Return type

[**StockProfilesResponse**](StockProfilesResponse.md)

### Authorization

[Query String](../README.md#Query String)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="search"></a>
# **Search**
> StockProfilesResponse Search (string apiKey, string text, int? page, int? pageSize)

Search

Search among all the available stocks.

### Example
```csharp
using System;
using System.Diagnostics;
using Equibles.Stocks.Api;
using Equibles.Stocks.Client;
using Equibles.Stocks.Model;

namespace Example
{
    public class SearchExample
    {
        public void main()
        {
            // Configure API key authorization: Query String
            Configuration.Default.AddApiKey("apiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("apiKey", "Bearer");

            var apiInstance = new StocksApi();
            var apiKey = apiKey_example;  // string | 
            var text = text_example;  // string | The text to search for.
            var page = 56;  // int? | The number of the page to request. (optional)  (default to 1)
            var pageSize = 56;  // int? | The number of elements in each page. Max value: 100. (optional)  (default to 100)

            try
            {
                // Search
                StockProfilesResponse result = apiInstance.Search(apiKey, text, page, pageSize);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StocksApi.Search: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **apiKey** | **string**|  | 
 **text** | **string**| The text to search for. | 
 **page** | **int?**| The number of the page to request. | [optional] [default to 1]
 **pageSize** | **int?**| The number of elements in each page. Max value: 100. | [optional] [default to 100]

### Return type

[**StockProfilesResponse**](StockProfilesResponse.md)

### Authorization

[Query String](../README.md#Query String)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="splits"></a>
# **Splits**
> SplitsResponse Splits (string apiKey, string fullTicker, int? page, int? pageSize)

Splits

Get all the splits for a given stock.

### Example
```csharp
using System;
using System.Diagnostics;
using Equibles.Stocks.Api;
using Equibles.Stocks.Client;
using Equibles.Stocks.Model;

namespace Example
{
    public class SplitsExample
    {
        public void main()
        {
            // Configure API key authorization: Query String
            Configuration.Default.AddApiKey("apiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("apiKey", "Bearer");

            var apiInstance = new StocksApi();
            var apiKey = apiKey_example;  // string | 
            var fullTicker = fullTicker_example;  // string | The fully qualified ticker of the stock. Example: AAPL.XNAS
            var page = 56;  // int? | The number of the page to request. (optional)  (default to 1)
            var pageSize = 56;  // int? | The number of elements in each page. Max value: 1000. (optional)  (default to 1000)

            try
            {
                // Splits
                SplitsResponse result = apiInstance.Splits(apiKey, fullTicker, page, pageSize);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StocksApi.Splits: " + e.Message );
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

[**SplitsResponse**](SplitsResponse.md)

### Authorization

[Query String](../README.md#Query String)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
