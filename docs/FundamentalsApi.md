# Equibles.Stocks.Api.FundamentalsApi

All URIs are relative to *https://api.equibles.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Dividends**](FundamentalsApi.md#dividends) | **GET** /stocks/fundamentals/dividends | Dividends
[**FinancialReports**](FundamentalsApi.md#financialreports) | **GET** /stocks/fundamentals/financialreports | Financial Statements

<a name="dividends"></a>
# **Dividends**
> FundamentalsResponse Dividends (string apiKey, string fullTicker, int? page, int? pageSize)

Dividends

Get the dividends for a given stock.

### Example
```csharp
using System;
using System.Diagnostics;
using Equibles.Stocks.Api;
using Equibles.Stocks.Client;
using Equibles.Stocks.Model;

namespace Example
{
    public class DividendsExample
    {
        public void main()
        {
            // Configure API key authorization: Query String
            Configuration.Default.AddApiKey("apiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("apiKey", "Bearer");

            var apiInstance = new FundamentalsApi();
            var apiKey = apiKey_example;  // string | 
            var fullTicker = fullTicker_example;  // string | The fully qualified ticker of the stock. Example: AAPL.XNAS
            var page = 56;  // int? | The number of the page to request. (optional)  (default to 1)
            var pageSize = 56;  // int? | The number of elements in each page. Max value: 1000. (optional)  (default to 1000)

            try
            {
                // Dividends
                FundamentalsResponse result = apiInstance.Dividends(apiKey, fullTicker, page, pageSize);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FundamentalsApi.Dividends: " + e.Message );
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

[**FundamentalsResponse**](FundamentalsResponse.md)

### Authorization

[Query String](../README.md#Query String)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="financialreports"></a>
# **FinancialReports**
> FundamentalsResponse FinancialReports (string apiKey, string fullTicker, int? year, FiscalPeriod fiscalPeriod, int? page, int? pageSize)

Financial Statements

List the financial statements for a given stock.

### Example
```csharp
using System;
using System.Diagnostics;
using Equibles.Stocks.Api;
using Equibles.Stocks.Client;
using Equibles.Stocks.Model;

namespace Example
{
    public class FinancialReportsExample
    {
        public void main()
        {
            // Configure API key authorization: Query String
            Configuration.Default.AddApiKey("apiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("apiKey", "Bearer");

            var apiInstance = new FundamentalsApi();
            var apiKey = apiKey_example;  // string | 
            var fullTicker = fullTicker_example;  // string | The fully qualified ticker of the stock. Example: AAPL.XNAS
            var year = 56;  // int? | The year of the report.
            var fiscalPeriod = new FiscalPeriod(); // FiscalPeriod | The fiscal period of the report.
            var page = 56;  // int? | The number of the page to request. (optional)  (default to 1)
            var pageSize = 56;  // int? | The number of elements in each page. Max value: 50. (optional)  (default to 50)

            try
            {
                // Financial Statements
                FundamentalsResponse result = apiInstance.FinancialReports(apiKey, fullTicker, year, fiscalPeriod, page, pageSize);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FundamentalsApi.FinancialReports: " + e.Message );
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
 **year** | **int?**| The year of the report. | 
 **fiscalPeriod** | [**FiscalPeriod**](FiscalPeriod.md)| The fiscal period of the report. | 
 **page** | **int?**| The number of the page to request. | [optional] [default to 1]
 **pageSize** | **int?**| The number of elements in each page. Max value: 50. | [optional] [default to 50]

### Return type

[**FundamentalsResponse**](FundamentalsResponse.md)

### Authorization

[Query String](../README.md#Query String)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
