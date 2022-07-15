# Equibles.Stocks.Api.ExchangesApi

All URIs are relative to *https://api.equibles.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CallList**](ExchangesApi.md#calllist) | **GET** /stocks/exchanges/list | List Exchanges
[**Currencies**](ExchangesApi.md#currencies) | **GET** /stocks/exchanges/currencies | List Currencies
[**Stocks**](ExchangesApi.md#stocks) | **GET** /stocks/exchanges/stocks | List Stocks

<a name="calllist"></a>
# **CallList**
> ExchangesResponse CallList (string apiKey)

List Exchanges

Get the list of all the exchanges supported by this API.

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

            var apiInstance = new ExchangesApi();
            var apiKey = apiKey_example;  // string | 

            try
            {
                // List Exchanges
                ExchangesResponse result = apiInstance.CallList(apiKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExchangesApi.CallList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **apiKey** | **string**|  | 

### Return type

[**ExchangesResponse**](ExchangesResponse.md)

### Authorization

[Query String](../README.md#Query String)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="currencies"></a>
# **Currencies**
> CurrenciesResponse Currencies (string apiKey)

List Currencies

Get the list of all the currencies supported by this API.

### Example
```csharp
using System;
using System.Diagnostics;
using Equibles.Stocks.Api;
using Equibles.Stocks.Client;
using Equibles.Stocks.Model;

namespace Example
{
    public class CurrenciesExample
    {
        public void main()
        {
            // Configure API key authorization: Query String
            Configuration.Default.AddApiKey("apiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("apiKey", "Bearer");

            var apiInstance = new ExchangesApi();
            var apiKey = apiKey_example;  // string | 

            try
            {
                // List Currencies
                CurrenciesResponse result = apiInstance.Currencies(apiKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExchangesApi.Currencies: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **apiKey** | **string**|  | 

### Return type

[**CurrenciesResponse**](CurrenciesResponse.md)

### Authorization

[Query String](../README.md#Query String)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="stocks"></a>
# **Stocks**
> FinancialAssetsResponse Stocks (string apiKey, string operatingMic)

List Stocks

List all the stocks in a given exchange.

### Example
```csharp
using System;
using System.Diagnostics;
using Equibles.Stocks.Api;
using Equibles.Stocks.Client;
using Equibles.Stocks.Model;

namespace Example
{
    public class StocksExample
    {
        public void main()
        {
            // Configure API key authorization: Query String
            Configuration.Default.AddApiKey("apiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("apiKey", "Bearer");

            var apiInstance = new ExchangesApi();
            var apiKey = apiKey_example;  // string | 
            var operatingMic = operatingMic_example;  // string | The operating MIC of the exchange to search.

            try
            {
                // List Stocks
                FinancialAssetsResponse result = apiInstance.Stocks(apiKey, operatingMic);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExchangesApi.Stocks: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **apiKey** | **string**|  | 
 **operatingMic** | **string**| The operating MIC of the exchange to search. | 

### Return type

[**FinancialAssetsResponse**](FinancialAssetsResponse.md)

### Authorization

[Query String](../README.md#Query String)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
