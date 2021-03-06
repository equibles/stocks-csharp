# Equibles.Stocks.Model.ScreenerRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SearchQuery** | **string** | A textual search term. | [optional] 
**ExchangeIds** | **List&lt;int?&gt;** | The ids of the exchanges to use. | [optional] 
**SectorIds** | **List&lt;int?&gt;** | The ids of the sectors to use. | [optional] 
**IndustryIds** | **List&lt;int?&gt;** | The ids of the industries to use. | [optional] 
**MarketCapMin** | **double?** | The minimum market capitalization. | [optional] 
**MarketCapMax** | **double?** | The maximum market capitalization. | [optional] 
**BetaMin** | **double?** | The minimum price beta for a 5 year period calculated monthly. | [optional] 
**BetaMax** | **double?** | The maximum price beta for a 5 year period calculated monthly. | [optional] 
**ForwardDividendMin** | **double?** | The minimum current dividend value. | [optional] 
**ForwardDividendMax** | **double?** | The maximum current dividend value. | [optional] 
**ForwardDividendYieldMin** | **double?** | The minimum current dividend percentage. | [optional] 
**ForwardDividendYieldMax** | **double?** | The maximum current dividend percentage. | [optional] 
**ShortRatioMin** | **double?** | The minimum short ratio. | [optional] 
**ShortRatioMax** | **double?** | The maximum short ratio. | [optional] 
**SharesShortPercentageMin** | **double?** | The minimum percentage of shares short. | [optional] 
**SharesShortPercentageMax** | **double?** | The maximum percentage of shares short. | [optional] 
**SharesShortPreviousMonthPercentageMin** | **double?** | The minimum percentage of shares short on the last month. | [optional] 
**SharesShortPreviousMonthPercentageMax** | **double?** | The maximum percentage of shares short on the last month. | [optional] 
**AnalystRecommendationMin** | **Recommendation** |  | [optional] 
**AnalystRecommendationMax** | **Recommendation** |  | [optional] 
**PerformanceOneDayMin** | **double?** | The minimum stock price percentage change in the last day. | [optional] 
**PerformanceOneDayMax** | **double?** | The maximum stock price percentage change in the last day. | [optional] 
**PerformanceOneWeekMin** | **double?** | The minimum stock price percentage change in the last week. | [optional] 
**PerformanceOneWeekMax** | **double?** | The maximum stock price percentage change in the last week. | [optional] 
**PerformanceTwoWeeksMin** | **double?** | The minimum stock price percentage change in the last two weeks. | [optional] 
**PerformanceTwoWeeksMax** | **double?** | The maximum stock price percentage change in the last two weeks. | [optional] 
**PerformanceOneMonthMin** | **double?** | The minimum stock price percentage change in the last month. | [optional] 
**PerformanceOneMonthMax** | **double?** | The maximum stock price percentage change in the last month. | [optional] 
**PerformanceThreeMonthsMin** | **double?** | The minimum stock price percentage change in the last three months. | [optional] 
**PerformanceThreeMonthsMax** | **double?** | The maximum stock price percentage change in the last three months. | [optional] 
**PerformanceOneYearMin** | **double?** | The minimum stock price percentage change in the last year. | [optional] 
**PerformanceOneYearMax** | **double?** | The maximum stock price percentage change in the last year. | [optional] 
**PerformanceThreeYearsMin** | **double?** | The minimum stock price percentage change in the last three years. | [optional] 
**PerformanceThreeYearsMax** | **double?** | The maximum stock price percentage change in the last three years. | [optional] 
**PerformanceFiveYearsMin** | **double?** | The minimum stock price percentage change in the last five years. | [optional] 
**PerformanceFiveYearsMax** | **double?** | The maximum stock price percentage change in the last five years. | [optional] 
**PerformanceTenYearsMin** | **double?** | The minimum stock price percentage change in the last ten years. | [optional] 
**PerformanceTenYearsMax** | **double?** | The maximum stock price percentage change in the last ten years. | [optional] 
**PerformanceTwentyYearsMin** | **double?** | The minimum stock price percentage change in the last twenty years. | [optional] 
**PerformanceTwentyYearsMax** | **double?** | The maximum stock price percentage change in the last twenty years. | [optional] 
**EpsGrowthOneYearMin** | **double?** | The minimum EPS growth in the last year. | [optional] 
**EpsGrowthOneYearMax** | **double?** | The maximum EPS growth in the last year. | [optional] 
**EpsGrowthTwoYearsMin** | **double?** | The minimum EPS growth in the last two years. This value is annualized. | [optional] 
**EpsGrowthTwoYearsMax** | **double?** | The maximum EPS growth in the last two years. This value is annualized. | [optional] 
**EpsGrowthThreeYearsMin** | **double?** | The minimum EPS growth in the last three years. This value is annualized. | [optional] 
**EpsGrowthThreeYearsMax** | **double?** | The maximum EPS growth in the last three years. This value is annualized. | [optional] 
**EpsGrowthFiveYearsMin** | **double?** | The minimum EPS growth in the last five years. This value is annualized. | [optional] 
**EpsGrowthFiveYearsMax** | **double?** | The maximum EPS growth in the last five years. This value is annualized. | [optional] 
**EpsGrowthTenYearsMin** | **double?** | The minimum EPS growth in the last ten years. This value is annualized. | [optional] 
**EpsGrowthTenYearsMax** | **double?** | The maximum EPS growth in the last ten years. This value is annualized. | [optional] 
**EpsGrowthTwentyYearsMin** | **double?** | The minimum EPS growth in the last twenty years. This value is annualized. | [optional] 
**EpsGrowthTwentyYearsMax** | **double?** | The maximum EPS growth in the last twenty years. This value is annualized. | [optional] 
**PeMin** | **double?** | The minimum price to earnings value. | [optional] 
**PeMax** | **double?** | The maximum price to earnings value. | [optional] 
**PegMin** | **double?** | The minimum price to earnings to growth value. | [optional] 
**PegMax** | **double?** | The maximum price to earnings to growth value. | [optional] 
**PriceFcfMin** | **double?** | The minimum price to free cash flow value. | [optional] 
**PriceFcfMax** | **double?** | The maximum price to free cash flow value. | [optional] 
**BookValuePerShareMin** | **double?** | The minimum book value per share. | [optional] 
**BookValuePerShareMax** | **double?** | The maximum book value per share. | [optional] 
**PriceBookValuePerShareMin** | **double?** | The minimum price to book value. | [optional] 
**PriceBookValuePerShareMax** | **double?** | The maximum price to book value. | [optional] 
**PayoutMin** | **double?** | The minimum payout ratio (as percentage). | [optional] 
**PayoutMax** | **double?** | The maximum payout ratio (as percentage). | [optional] 
**DebtToEquityMin** | **double?** | The minimum debt to equity ratio (as percentage). | [optional] 
**DebtToEquityMax** | **double?** | The maximum debt to equity ratio (as percentage). | [optional] 
**GrossMarginMin** | **double?** | The minimum gross margin (as percentage). | [optional] 
**GrossMarginMax** | **double?** | The maximum gross margin (as percentage). | [optional] 
**OperatingMarginMin** | **double?** | The minimum operating margin (as percentage). | [optional] 
**OperatingMarginMax** | **double?** | The maximum operating margin (as percentage). | [optional] 
**ProfitMarginMin** | **double?** | The minimum profit margin (as percentage). | [optional] 
**ProfitMarginMax** | **double?** | The maximum profit margin (as percentage). | [optional] 
**PriceToSalesMin** | **double?** | The minimum price to sales ratio. | [optional] 
**PriceToSalesMax** | **double?** | The maximum price to sales ratio. | [optional] 
**BuybacksThreeMonthsMin** | **double?** | The minimum percentage of shares bought back in the last 3 months. Negative values represent dilution of shares. | [optional] 
**BuybacksThreeMonthsMax** | **double?** | The maximum percentage of shares bought back in the last 3 months. Negative values represent dilution of shares. | [optional] 
**BuybacksSixMonthsMin** | **double?** | The minimum percentage of shares bought back in the last 6 months. Negative values represent dilution of shares. | [optional] 
**BuybacksSixMonthsMax** | **double?** |  | [optional] 
**BuybacksOneYearMin** | **double?** | The minimum percentage of shares bought back in the last year. Negative values represent dilution of shares. | [optional] 
**BuybacksOneYearMax** | **double?** | The maximum percentage of shares bought back in the last year. Negative values represent dilution of shares. | [optional] 
**BuybacksTwoYearsMin** | **double?** | The minimum percentage of shares bought back in the last 2 years. Negative values represent dilution of shares. | [optional] 
**BuybacksTwoYearsMax** | **double?** | The maximum percentage of shares bought back in the last 2 years. Negative values represent dilution of shares. | [optional] 
**BuybacksThreeYearsMin** | **double?** | The minimum percentage of shares bought back in the last 3 years. Negative values represent dilution of shares. | [optional] 
**BuybacksThreeYearsMax** | **double?** | The maximum percentage of shares bought back in the last 3 years. Negative values represent dilution of shares. | [optional] 
**BuybacksFiveYearsMin** | **double?** | The minimum percentage of shares bought back in the last 5 years. Negative values represent dilution of shares. | [optional] 
**BuybacksFiveYearsMax** | **double?** | The maximum percentage of shares bought back in the last 5 years. Negative values represent dilution of shares. | [optional] 
**BuybacksTenYearsMin** | **double?** | The minimum percentage of shares bought back in the last 10 years. Negative values represent dilution of shares. | [optional] 
**BuybacksTenYearsMax** | **double?** | The maximum percentage of shares bought back in the last 10 years. Negative values represent dilution of shares. | [optional] 
**BuybacksTwentyYearsMin** | **double?** | The minimum percentage of shares bought back in the last 20 years. Negative values represent dilution of shares. | [optional] 
**BuybacksTwentyYearsMax** | **double?** | The maximum percentage of shares bought back in the last 20 years. Negative values represent dilution of shares. | [optional] 
**PotentialUpside** | **double?** | The upside potential according to the analysts&#x27; target price consensus (as percentage). I.e. If the stock price is $100 and the analysts&#x27; target price consensus is $150 then the potential upside is 50%. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

