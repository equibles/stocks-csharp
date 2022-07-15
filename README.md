# Equibles.Stocks - the C# library for the Stocks


<a name="frameworks-supported"></a>
## Frameworks supported
- .NET Core >=1.0
- .NET Framework >=4.6
- Mono/Xamarin >=vNext
- UWP >=10.0

<a name="dependencies"></a>
## Dependencies
- FubarCoder.RestSharp.Portable.Core >=4.0.7
- FubarCoder.RestSharp.Portable.HttpClient >=4.0.7
- Newtonsoft.Json >=10.0.3

<a name="installation"></a>
## Installation
Generate the DLL using your preferred tool

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using Equibles.Stocks.Api;
using Equibles.Stocks.Client;
using Equibles.Stocks.Model;
```
<a name="getting-started"></a>
## Getting Started

```csharp
using System;
using System.Diagnostics;
using Equibles.Stocks.Api;
using Equibles.Stocks.Client;
using Equibles.Stocks.Model;

namespace Example
{
    public class Example
    {
        public void main()
        {
            // Configure API key authorization: Query String
            Configuration.Default.ApiKey.Add("apiKey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("apiKey", "Bearer");

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

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://api.equibles.com*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*ExchangesApi* | [**CallList**](docs/ExchangesApi.md#calllist) | **GET** /stocks/exchanges/list | List Exchanges
*ExchangesApi* | [**Currencies**](docs/ExchangesApi.md#currencies) | **GET** /stocks/exchanges/currencies | List Currencies
*ExchangesApi* | [**Stocks**](docs/ExchangesApi.md#stocks) | **GET** /stocks/exchanges/stocks | List Stocks
*FundamentalsApi* | [**Dividends**](docs/FundamentalsApi.md#dividends) | **GET** /stocks/fundamentals/dividends | Dividends
*FundamentalsApi* | [**FinancialReports**](docs/FundamentalsApi.md#financialreports) | **GET** /stocks/fundamentals/financialreports | Financial Statements
*MetricsApi* | [**PriceToEarnings**](docs/MetricsApi.md#pricetoearnings) | **GET** /stocks/metrics/pricetoearnings | Historical P/E
*NewsApi* | [**CallList**](docs/NewsApi.md#calllist) | **GET** /stocks/news/list | List News
*NewsApi* | [**Publishers**](docs/NewsApi.md#publishers) | **GET** /stocks/news/publishers | List Publishers
*PerformanceApi* | [**CallList**](docs/PerformanceApi.md#calllist) | **GET** /stocks/performance/list | Performance
*PricesApi* | [**EndOfDay**](docs/PricesApi.md#endofday) | **GET** /stocks/prices/endofday | End Of Day Prices
*PricesApi* | [**Intraday**](docs/PricesApi.md#intraday) | **GET** /stocks/prices/intraday | Intraday Prices
*PricesApi* | [**Summary**](docs/PricesApi.md#summary) | **GET** /stocks/prices/summary | Latest trading day summary
*SectorsApi* | [**CallList**](docs/SectorsApi.md#calllist) | **GET** /stocks/sectors/list | List Sectors
*SectorsApi* | [**SearchStocks**](docs/SectorsApi.md#searchstocks) | **GET** /stocks/sectors/searchstocks | List Stocks
*StocksApi* | [**CallList**](docs/StocksApi.md#calllist) | **GET** /stocks/list | List Stocks
*StocksApi* | [**Officers**](docs/StocksApi.md#officers) | **GET** /stocks/officers | Officers
*StocksApi* | [**Profile**](docs/StocksApi.md#profile) | **GET** /stocks/profile | Profile
*StocksApi* | [**Screener**](docs/StocksApi.md#screener) | **POST** /stocks/screener | Screener
*StocksApi* | [**Search**](docs/StocksApi.md#search) | **GET** /stocks/search | Search
*StocksApi* | [**Splits**](docs/StocksApi.md#splits) | **GET** /stocks/splits | Splits
*TransactionsApi* | [**Insiders**](docs/TransactionsApi.md#insiders) | **GET** /stocks/transactions/insiders | Insider Transactions
*TransactionsApi* | [**Institutional**](docs/TransactionsApi.md#institutional) | **GET** /stocks/transactions/institutional | Institutional Transactions

<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.AssetType](docs/AssetType.md)
 - [Model.BalanceSheet](docs/BalanceSheet.md)
 - [Model.CashFlowStatement](docs/CashFlowStatement.md)
 - [Model.CurrenciesResponse](docs/CurrenciesResponse.md)
 - [Model.Currency](docs/Currency.md)
 - [Model.ErrorResponse](docs/ErrorResponse.md)
 - [Model.Exchange](docs/Exchange.md)
 - [Model.ExchangesResponse](docs/ExchangesResponse.md)
 - [Model.FinancialAssetsResponse](docs/FinancialAssetsResponse.md)
 - [Model.FinancialReport](docs/FinancialReport.md)
 - [Model.FiscalPeriod](docs/FiscalPeriod.md)
 - [Model.FundamentalsResponse](docs/FundamentalsResponse.md)
 - [Model.Image](docs/Image.md)
 - [Model.IncomeStatement](docs/IncomeStatement.md)
 - [Model.Industry](docs/Industry.md)
 - [Model.MetricNullablePointsResponse](docs/MetricNullablePointsResponse.md)
 - [Model.News](docs/News.md)
 - [Model.NewsResponse](docs/NewsResponse.md)
 - [Model.NullablePoint](docs/NullablePoint.md)
 - [Model.Officer](docs/Officer.md)
 - [Model.OfficersResponse](docs/OfficersResponse.md)
 - [Model.Performance](docs/Performance.md)
 - [Model.PerformanceResponse](docs/PerformanceResponse.md)
 - [Model.Price](docs/Price.md)
 - [Model.PriceSummary](docs/PriceSummary.md)
 - [Model.PriceSummaryResponse](docs/PriceSummaryResponse.md)
 - [Model.PricesResponse](docs/PricesResponse.md)
 - [Model.Publisher](docs/Publisher.md)
 - [Model.PublishersResponse](docs/PublishersResponse.md)
 - [Model.Recommendation](docs/Recommendation.md)
 - [Model.ResponseStatus](docs/ResponseStatus.md)
 - [Model.ScreenerRequest](docs/ScreenerRequest.md)
 - [Model.Sector](docs/Sector.md)
 - [Model.SectorsResponse](docs/SectorsResponse.md)
 - [Model.Sort](docs/Sort.md)
 - [Model.SplitsResponse](docs/SplitsResponse.md)
 - [Model.StockProfile](docs/StockProfile.md)
 - [Model.StockProfileResponse](docs/StockProfileResponse.md)
 - [Model.StockProfilesResponse](docs/StockProfilesResponse.md)
 - [Model.StockSplit](docs/StockSplit.md)
 - [Model.Transaction](docs/Transaction.md)
 - [Model.TransactionType](docs/TransactionType.md)
 - [Model.TransactionsResponse](docs/TransactionsResponse.md)

<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="Query String"></a>
### Query String

- **Type**: API key
- **API key parameter name**: apiKey
- **Location**: URL query string

