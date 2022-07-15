# Equibles.Stocks.Api.SectorsApi

All URIs are relative to *https://api.equibles.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CallList**](SectorsApi.md#calllist) | **GET** /stocks/sectors/list | List Sectors
[**SearchStocks**](SectorsApi.md#searchstocks) | **GET** /stocks/sectors/searchstocks | List Stocks

<a name="calllist"></a>
# **CallList**
> SectorsResponse CallList (string apiKey)

List Sectors

Lists all the sectors.

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

            var apiInstance = new SectorsApi();
            var apiKey = apiKey_example;  // string | 

            try
            {
                // List Sectors
                SectorsResponse result = apiInstance.CallList(apiKey);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SectorsApi.CallList: " + e.Message );
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

[**SectorsResponse**](SectorsResponse.md)

### Authorization

[Query String](../README.md#Query String)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="searchstocks"></a>
# **SearchStocks**
> FinancialAssetsResponse SearchStocks (string apiKey, string sectorName, string industryName)

List Stocks

Lists all the stocks in a given sector/industry.

### Example
```csharp
using System;
using System.Diagnostics;
using Equibles.Stocks.Api;
using Equibles.Stocks.Client;
using Equibles.Stocks.Model;

namespace Example
{
    public class SearchStocksExample
    {
        public void main()
        {
            // Configure API key authorization: Query String
            Configuration.Default.AddApiKey("apiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("apiKey", "Bearer");

            var apiInstance = new SectorsApi();
            var apiKey = apiKey_example;  // string | 
            var sectorName = sectorName_example;  // string | The name of the sector to use as filter. (optional) 
            var industryName = industryName_example;  // string | The name of the industry to use as filter. (optional) 

            try
            {
                // List Stocks
                FinancialAssetsResponse result = apiInstance.SearchStocks(apiKey, sectorName, industryName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SectorsApi.SearchStocks: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **apiKey** | **string**|  | 
 **sectorName** | **string**| The name of the sector to use as filter. | [optional] 
 **industryName** | **string**| The name of the industry to use as filter. | [optional] 

### Return type

[**FinancialAssetsResponse**](FinancialAssetsResponse.md)

### Authorization

[Query String](../README.md#Query String)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
