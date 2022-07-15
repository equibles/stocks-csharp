/* 
 * Stocks
 *
 * <h3>Rate limits</h3>                     Free subscriptions are subject to daily limits. To know how much requests you have left look at the following headers in the response.<br />                     1. <strong>x-ratelimit-limit</strong> - The total number of requests that you are allowed to make in a given period (hour/day)<br />                     2. <strong>x-ratelimit-remaining</strong> - The number of remaining requests that you can perform in the current period.<br />                     3. <strong>x-ratelimit-reset</strong> - The number of seconds until the current period resets.<br />                     <br />                     <br />                     You don't have an API key? <a href=\"https://www.equibles.com/api/pricing\" target=\"_blank\">Get one for free here.</a>
 *
 * OpenAPI spec version: v1
 * Contact: contact@equibles.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using SwaggerDateConverter = Equibles.Stocks.Client.SwaggerDateConverter;

namespace Equibles.Stocks.Model
{
    /// <summary>
    /// IncomeStatement
    /// </summary>
    [DataContract]
        public partial class IncomeStatement :  IEquatable<IncomeStatement>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IncomeStatement" /> class.
        /// </summary>
        /// <param name="grossProfit">grossProfit.</param>
        /// <param name="revenue">revenue.</param>
        /// <param name="costOfRevenue">costOfRevenue.</param>
        /// <param name="costOfGoodsAndServicesSold">costOfGoodsAndServicesSold.</param>
        /// <param name="operatingIncome">operatingIncome.</param>
        /// <param name="sellingGeneralAndAdministrative">sellingGeneralAndAdministrative.</param>
        /// <param name="researchAndDevelopment">researchAndDevelopment.</param>
        /// <param name="operatingExpenses">operatingExpenses.</param>
        /// <param name="investmentIncomeNet">investmentIncomeNet.</param>
        /// <param name="netInterestIncome">netInterestIncome.</param>
        /// <param name="interestIncome">interestIncome.</param>
        /// <param name="interestExpense">interestExpense.</param>
        /// <param name="nonInterestIncome">nonInterestIncome.</param>
        /// <param name="otherNonOperatingIncome">otherNonOperatingIncome.</param>
        /// <param name="depreciation">depreciation.</param>
        /// <param name="depreciationAndAmortization">depreciationAndAmortization.</param>
        /// <param name="incomeBeforeTax">incomeBeforeTax.</param>
        /// <param name="incomeTaxExpense">incomeTaxExpense.</param>
        /// <param name="interestAndDebtExpense">interestAndDebtExpense.</param>
        /// <param name="netIncomeFromContinuingOperations">netIncomeFromContinuingOperations.</param>
        /// <param name="comprehensiveIncomeNetOfTax">comprehensiveIncomeNetOfTax.</param>
        /// <param name="ebit">ebit.</param>
        /// <param name="ebitda">ebitda.</param>
        /// <param name="netIncome">netIncome.</param>
        /// <param name="effectOfAccountingCharges">effectOfAccountingCharges.</param>
        /// <param name="taxProvision">taxProvision.</param>
        /// <param name="sellingAndMarketingExpenses">sellingAndMarketingExpenses.</param>
        /// <param name="extraordinaryItems">extraordinaryItems.</param>
        public IncomeStatement(long? grossProfit = default(long?), long? revenue = default(long?), long? costOfRevenue = default(long?), long? costOfGoodsAndServicesSold = default(long?), long? operatingIncome = default(long?), long? sellingGeneralAndAdministrative = default(long?), long? researchAndDevelopment = default(long?), long? operatingExpenses = default(long?), long? investmentIncomeNet = default(long?), long? netInterestIncome = default(long?), long? interestIncome = default(long?), long? interestExpense = default(long?), long? nonInterestIncome = default(long?), long? otherNonOperatingIncome = default(long?), long? depreciation = default(long?), long? depreciationAndAmortization = default(long?), long? incomeBeforeTax = default(long?), long? incomeTaxExpense = default(long?), long? interestAndDebtExpense = default(long?), long? netIncomeFromContinuingOperations = default(long?), long? comprehensiveIncomeNetOfTax = default(long?), long? ebit = default(long?), long? ebitda = default(long?), long? netIncome = default(long?), long? effectOfAccountingCharges = default(long?), long? taxProvision = default(long?), long? sellingAndMarketingExpenses = default(long?), long? extraordinaryItems = default(long?))
        {
            this.GrossProfit = grossProfit;
            this.Revenue = revenue;
            this.CostOfRevenue = costOfRevenue;
            this.CostOfGoodsAndServicesSold = costOfGoodsAndServicesSold;
            this.OperatingIncome = operatingIncome;
            this.SellingGeneralAndAdministrative = sellingGeneralAndAdministrative;
            this.ResearchAndDevelopment = researchAndDevelopment;
            this.OperatingExpenses = operatingExpenses;
            this.InvestmentIncomeNet = investmentIncomeNet;
            this.NetInterestIncome = netInterestIncome;
            this.InterestIncome = interestIncome;
            this.InterestExpense = interestExpense;
            this.NonInterestIncome = nonInterestIncome;
            this.OtherNonOperatingIncome = otherNonOperatingIncome;
            this.Depreciation = depreciation;
            this.DepreciationAndAmortization = depreciationAndAmortization;
            this.IncomeBeforeTax = incomeBeforeTax;
            this.IncomeTaxExpense = incomeTaxExpense;
            this.InterestAndDebtExpense = interestAndDebtExpense;
            this.NetIncomeFromContinuingOperations = netIncomeFromContinuingOperations;
            this.ComprehensiveIncomeNetOfTax = comprehensiveIncomeNetOfTax;
            this.Ebit = ebit;
            this.Ebitda = ebitda;
            this.NetIncome = netIncome;
            this.EffectOfAccountingCharges = effectOfAccountingCharges;
            this.TaxProvision = taxProvision;
            this.SellingAndMarketingExpenses = sellingAndMarketingExpenses;
            this.ExtraordinaryItems = extraordinaryItems;
        }
        
        /// <summary>
        /// Gets or Sets GrossProfit
        /// </summary>
        [DataMember(Name="grossProfit", EmitDefaultValue=false)]
        public long? GrossProfit { get; set; }

        /// <summary>
        /// Gets or Sets Revenue
        /// </summary>
        [DataMember(Name="revenue", EmitDefaultValue=false)]
        public long? Revenue { get; set; }

        /// <summary>
        /// Gets or Sets CostOfRevenue
        /// </summary>
        [DataMember(Name="costOfRevenue", EmitDefaultValue=false)]
        public long? CostOfRevenue { get; set; }

        /// <summary>
        /// Gets or Sets CostOfGoodsAndServicesSold
        /// </summary>
        [DataMember(Name="costOfGoodsAndServicesSold", EmitDefaultValue=false)]
        public long? CostOfGoodsAndServicesSold { get; set; }

        /// <summary>
        /// Gets or Sets OperatingIncome
        /// </summary>
        [DataMember(Name="operatingIncome", EmitDefaultValue=false)]
        public long? OperatingIncome { get; set; }

        /// <summary>
        /// Gets or Sets SellingGeneralAndAdministrative
        /// </summary>
        [DataMember(Name="sellingGeneralAndAdministrative", EmitDefaultValue=false)]
        public long? SellingGeneralAndAdministrative { get; set; }

        /// <summary>
        /// Gets or Sets ResearchAndDevelopment
        /// </summary>
        [DataMember(Name="researchAndDevelopment", EmitDefaultValue=false)]
        public long? ResearchAndDevelopment { get; set; }

        /// <summary>
        /// Gets or Sets OperatingExpenses
        /// </summary>
        [DataMember(Name="operatingExpenses", EmitDefaultValue=false)]
        public long? OperatingExpenses { get; set; }

        /// <summary>
        /// Gets or Sets InvestmentIncomeNet
        /// </summary>
        [DataMember(Name="investmentIncomeNet", EmitDefaultValue=false)]
        public long? InvestmentIncomeNet { get; set; }

        /// <summary>
        /// Gets or Sets NetInterestIncome
        /// </summary>
        [DataMember(Name="netInterestIncome", EmitDefaultValue=false)]
        public long? NetInterestIncome { get; set; }

        /// <summary>
        /// Gets or Sets InterestIncome
        /// </summary>
        [DataMember(Name="interestIncome", EmitDefaultValue=false)]
        public long? InterestIncome { get; set; }

        /// <summary>
        /// Gets or Sets InterestExpense
        /// </summary>
        [DataMember(Name="interestExpense", EmitDefaultValue=false)]
        public long? InterestExpense { get; set; }

        /// <summary>
        /// Gets or Sets NonInterestIncome
        /// </summary>
        [DataMember(Name="nonInterestIncome", EmitDefaultValue=false)]
        public long? NonInterestIncome { get; set; }

        /// <summary>
        /// Gets or Sets OtherNonOperatingIncome
        /// </summary>
        [DataMember(Name="otherNonOperatingIncome", EmitDefaultValue=false)]
        public long? OtherNonOperatingIncome { get; set; }

        /// <summary>
        /// Gets or Sets Depreciation
        /// </summary>
        [DataMember(Name="depreciation", EmitDefaultValue=false)]
        public long? Depreciation { get; set; }

        /// <summary>
        /// Gets or Sets DepreciationAndAmortization
        /// </summary>
        [DataMember(Name="depreciationAndAmortization", EmitDefaultValue=false)]
        public long? DepreciationAndAmortization { get; set; }

        /// <summary>
        /// Gets or Sets IncomeBeforeTax
        /// </summary>
        [DataMember(Name="incomeBeforeTax", EmitDefaultValue=false)]
        public long? IncomeBeforeTax { get; set; }

        /// <summary>
        /// Gets or Sets IncomeTaxExpense
        /// </summary>
        [DataMember(Name="incomeTaxExpense", EmitDefaultValue=false)]
        public long? IncomeTaxExpense { get; set; }

        /// <summary>
        /// Gets or Sets InterestAndDebtExpense
        /// </summary>
        [DataMember(Name="interestAndDebtExpense", EmitDefaultValue=false)]
        public long? InterestAndDebtExpense { get; set; }

        /// <summary>
        /// Gets or Sets NetIncomeFromContinuingOperations
        /// </summary>
        [DataMember(Name="netIncomeFromContinuingOperations", EmitDefaultValue=false)]
        public long? NetIncomeFromContinuingOperations { get; set; }

        /// <summary>
        /// Gets or Sets ComprehensiveIncomeNetOfTax
        /// </summary>
        [DataMember(Name="comprehensiveIncomeNetOfTax", EmitDefaultValue=false)]
        public long? ComprehensiveIncomeNetOfTax { get; set; }

        /// <summary>
        /// Gets or Sets Ebit
        /// </summary>
        [DataMember(Name="ebit", EmitDefaultValue=false)]
        public long? Ebit { get; set; }

        /// <summary>
        /// Gets or Sets Ebitda
        /// </summary>
        [DataMember(Name="ebitda", EmitDefaultValue=false)]
        public long? Ebitda { get; set; }

        /// <summary>
        /// Gets or Sets NetIncome
        /// </summary>
        [DataMember(Name="netIncome", EmitDefaultValue=false)]
        public long? NetIncome { get; set; }

        /// <summary>
        /// Gets or Sets EffectOfAccountingCharges
        /// </summary>
        [DataMember(Name="effectOfAccountingCharges", EmitDefaultValue=false)]
        public long? EffectOfAccountingCharges { get; set; }

        /// <summary>
        /// Gets or Sets TaxProvision
        /// </summary>
        [DataMember(Name="taxProvision", EmitDefaultValue=false)]
        public long? TaxProvision { get; set; }

        /// <summary>
        /// Gets or Sets SellingAndMarketingExpenses
        /// </summary>
        [DataMember(Name="sellingAndMarketingExpenses", EmitDefaultValue=false)]
        public long? SellingAndMarketingExpenses { get; set; }

        /// <summary>
        /// Gets or Sets ExtraordinaryItems
        /// </summary>
        [DataMember(Name="extraordinaryItems", EmitDefaultValue=false)]
        public long? ExtraordinaryItems { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IncomeStatement {\n");
            sb.Append("  GrossProfit: ").Append(GrossProfit).Append("\n");
            sb.Append("  Revenue: ").Append(Revenue).Append("\n");
            sb.Append("  CostOfRevenue: ").Append(CostOfRevenue).Append("\n");
            sb.Append("  CostOfGoodsAndServicesSold: ").Append(CostOfGoodsAndServicesSold).Append("\n");
            sb.Append("  OperatingIncome: ").Append(OperatingIncome).Append("\n");
            sb.Append("  SellingGeneralAndAdministrative: ").Append(SellingGeneralAndAdministrative).Append("\n");
            sb.Append("  ResearchAndDevelopment: ").Append(ResearchAndDevelopment).Append("\n");
            sb.Append("  OperatingExpenses: ").Append(OperatingExpenses).Append("\n");
            sb.Append("  InvestmentIncomeNet: ").Append(InvestmentIncomeNet).Append("\n");
            sb.Append("  NetInterestIncome: ").Append(NetInterestIncome).Append("\n");
            sb.Append("  InterestIncome: ").Append(InterestIncome).Append("\n");
            sb.Append("  InterestExpense: ").Append(InterestExpense).Append("\n");
            sb.Append("  NonInterestIncome: ").Append(NonInterestIncome).Append("\n");
            sb.Append("  OtherNonOperatingIncome: ").Append(OtherNonOperatingIncome).Append("\n");
            sb.Append("  Depreciation: ").Append(Depreciation).Append("\n");
            sb.Append("  DepreciationAndAmortization: ").Append(DepreciationAndAmortization).Append("\n");
            sb.Append("  IncomeBeforeTax: ").Append(IncomeBeforeTax).Append("\n");
            sb.Append("  IncomeTaxExpense: ").Append(IncomeTaxExpense).Append("\n");
            sb.Append("  InterestAndDebtExpense: ").Append(InterestAndDebtExpense).Append("\n");
            sb.Append("  NetIncomeFromContinuingOperations: ").Append(NetIncomeFromContinuingOperations).Append("\n");
            sb.Append("  ComprehensiveIncomeNetOfTax: ").Append(ComprehensiveIncomeNetOfTax).Append("\n");
            sb.Append("  Ebit: ").Append(Ebit).Append("\n");
            sb.Append("  Ebitda: ").Append(Ebitda).Append("\n");
            sb.Append("  NetIncome: ").Append(NetIncome).Append("\n");
            sb.Append("  EffectOfAccountingCharges: ").Append(EffectOfAccountingCharges).Append("\n");
            sb.Append("  TaxProvision: ").Append(TaxProvision).Append("\n");
            sb.Append("  SellingAndMarketingExpenses: ").Append(SellingAndMarketingExpenses).Append("\n");
            sb.Append("  ExtraordinaryItems: ").Append(ExtraordinaryItems).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as IncomeStatement);
        }

        /// <summary>
        /// Returns true if IncomeStatement instances are equal
        /// </summary>
        /// <param name="input">Instance of IncomeStatement to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IncomeStatement input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.GrossProfit == input.GrossProfit ||
                    (this.GrossProfit != null &&
                    this.GrossProfit.Equals(input.GrossProfit))
                ) && 
                (
                    this.Revenue == input.Revenue ||
                    (this.Revenue != null &&
                    this.Revenue.Equals(input.Revenue))
                ) && 
                (
                    this.CostOfRevenue == input.CostOfRevenue ||
                    (this.CostOfRevenue != null &&
                    this.CostOfRevenue.Equals(input.CostOfRevenue))
                ) && 
                (
                    this.CostOfGoodsAndServicesSold == input.CostOfGoodsAndServicesSold ||
                    (this.CostOfGoodsAndServicesSold != null &&
                    this.CostOfGoodsAndServicesSold.Equals(input.CostOfGoodsAndServicesSold))
                ) && 
                (
                    this.OperatingIncome == input.OperatingIncome ||
                    (this.OperatingIncome != null &&
                    this.OperatingIncome.Equals(input.OperatingIncome))
                ) && 
                (
                    this.SellingGeneralAndAdministrative == input.SellingGeneralAndAdministrative ||
                    (this.SellingGeneralAndAdministrative != null &&
                    this.SellingGeneralAndAdministrative.Equals(input.SellingGeneralAndAdministrative))
                ) && 
                (
                    this.ResearchAndDevelopment == input.ResearchAndDevelopment ||
                    (this.ResearchAndDevelopment != null &&
                    this.ResearchAndDevelopment.Equals(input.ResearchAndDevelopment))
                ) && 
                (
                    this.OperatingExpenses == input.OperatingExpenses ||
                    (this.OperatingExpenses != null &&
                    this.OperatingExpenses.Equals(input.OperatingExpenses))
                ) && 
                (
                    this.InvestmentIncomeNet == input.InvestmentIncomeNet ||
                    (this.InvestmentIncomeNet != null &&
                    this.InvestmentIncomeNet.Equals(input.InvestmentIncomeNet))
                ) && 
                (
                    this.NetInterestIncome == input.NetInterestIncome ||
                    (this.NetInterestIncome != null &&
                    this.NetInterestIncome.Equals(input.NetInterestIncome))
                ) && 
                (
                    this.InterestIncome == input.InterestIncome ||
                    (this.InterestIncome != null &&
                    this.InterestIncome.Equals(input.InterestIncome))
                ) && 
                (
                    this.InterestExpense == input.InterestExpense ||
                    (this.InterestExpense != null &&
                    this.InterestExpense.Equals(input.InterestExpense))
                ) && 
                (
                    this.NonInterestIncome == input.NonInterestIncome ||
                    (this.NonInterestIncome != null &&
                    this.NonInterestIncome.Equals(input.NonInterestIncome))
                ) && 
                (
                    this.OtherNonOperatingIncome == input.OtherNonOperatingIncome ||
                    (this.OtherNonOperatingIncome != null &&
                    this.OtherNonOperatingIncome.Equals(input.OtherNonOperatingIncome))
                ) && 
                (
                    this.Depreciation == input.Depreciation ||
                    (this.Depreciation != null &&
                    this.Depreciation.Equals(input.Depreciation))
                ) && 
                (
                    this.DepreciationAndAmortization == input.DepreciationAndAmortization ||
                    (this.DepreciationAndAmortization != null &&
                    this.DepreciationAndAmortization.Equals(input.DepreciationAndAmortization))
                ) && 
                (
                    this.IncomeBeforeTax == input.IncomeBeforeTax ||
                    (this.IncomeBeforeTax != null &&
                    this.IncomeBeforeTax.Equals(input.IncomeBeforeTax))
                ) && 
                (
                    this.IncomeTaxExpense == input.IncomeTaxExpense ||
                    (this.IncomeTaxExpense != null &&
                    this.IncomeTaxExpense.Equals(input.IncomeTaxExpense))
                ) && 
                (
                    this.InterestAndDebtExpense == input.InterestAndDebtExpense ||
                    (this.InterestAndDebtExpense != null &&
                    this.InterestAndDebtExpense.Equals(input.InterestAndDebtExpense))
                ) && 
                (
                    this.NetIncomeFromContinuingOperations == input.NetIncomeFromContinuingOperations ||
                    (this.NetIncomeFromContinuingOperations != null &&
                    this.NetIncomeFromContinuingOperations.Equals(input.NetIncomeFromContinuingOperations))
                ) && 
                (
                    this.ComprehensiveIncomeNetOfTax == input.ComprehensiveIncomeNetOfTax ||
                    (this.ComprehensiveIncomeNetOfTax != null &&
                    this.ComprehensiveIncomeNetOfTax.Equals(input.ComprehensiveIncomeNetOfTax))
                ) && 
                (
                    this.Ebit == input.Ebit ||
                    (this.Ebit != null &&
                    this.Ebit.Equals(input.Ebit))
                ) && 
                (
                    this.Ebitda == input.Ebitda ||
                    (this.Ebitda != null &&
                    this.Ebitda.Equals(input.Ebitda))
                ) && 
                (
                    this.NetIncome == input.NetIncome ||
                    (this.NetIncome != null &&
                    this.NetIncome.Equals(input.NetIncome))
                ) && 
                (
                    this.EffectOfAccountingCharges == input.EffectOfAccountingCharges ||
                    (this.EffectOfAccountingCharges != null &&
                    this.EffectOfAccountingCharges.Equals(input.EffectOfAccountingCharges))
                ) && 
                (
                    this.TaxProvision == input.TaxProvision ||
                    (this.TaxProvision != null &&
                    this.TaxProvision.Equals(input.TaxProvision))
                ) && 
                (
                    this.SellingAndMarketingExpenses == input.SellingAndMarketingExpenses ||
                    (this.SellingAndMarketingExpenses != null &&
                    this.SellingAndMarketingExpenses.Equals(input.SellingAndMarketingExpenses))
                ) && 
                (
                    this.ExtraordinaryItems == input.ExtraordinaryItems ||
                    (this.ExtraordinaryItems != null &&
                    this.ExtraordinaryItems.Equals(input.ExtraordinaryItems))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.GrossProfit != null)
                    hashCode = hashCode * 59 + this.GrossProfit.GetHashCode();
                if (this.Revenue != null)
                    hashCode = hashCode * 59 + this.Revenue.GetHashCode();
                if (this.CostOfRevenue != null)
                    hashCode = hashCode * 59 + this.CostOfRevenue.GetHashCode();
                if (this.CostOfGoodsAndServicesSold != null)
                    hashCode = hashCode * 59 + this.CostOfGoodsAndServicesSold.GetHashCode();
                if (this.OperatingIncome != null)
                    hashCode = hashCode * 59 + this.OperatingIncome.GetHashCode();
                if (this.SellingGeneralAndAdministrative != null)
                    hashCode = hashCode * 59 + this.SellingGeneralAndAdministrative.GetHashCode();
                if (this.ResearchAndDevelopment != null)
                    hashCode = hashCode * 59 + this.ResearchAndDevelopment.GetHashCode();
                if (this.OperatingExpenses != null)
                    hashCode = hashCode * 59 + this.OperatingExpenses.GetHashCode();
                if (this.InvestmentIncomeNet != null)
                    hashCode = hashCode * 59 + this.InvestmentIncomeNet.GetHashCode();
                if (this.NetInterestIncome != null)
                    hashCode = hashCode * 59 + this.NetInterestIncome.GetHashCode();
                if (this.InterestIncome != null)
                    hashCode = hashCode * 59 + this.InterestIncome.GetHashCode();
                if (this.InterestExpense != null)
                    hashCode = hashCode * 59 + this.InterestExpense.GetHashCode();
                if (this.NonInterestIncome != null)
                    hashCode = hashCode * 59 + this.NonInterestIncome.GetHashCode();
                if (this.OtherNonOperatingIncome != null)
                    hashCode = hashCode * 59 + this.OtherNonOperatingIncome.GetHashCode();
                if (this.Depreciation != null)
                    hashCode = hashCode * 59 + this.Depreciation.GetHashCode();
                if (this.DepreciationAndAmortization != null)
                    hashCode = hashCode * 59 + this.DepreciationAndAmortization.GetHashCode();
                if (this.IncomeBeforeTax != null)
                    hashCode = hashCode * 59 + this.IncomeBeforeTax.GetHashCode();
                if (this.IncomeTaxExpense != null)
                    hashCode = hashCode * 59 + this.IncomeTaxExpense.GetHashCode();
                if (this.InterestAndDebtExpense != null)
                    hashCode = hashCode * 59 + this.InterestAndDebtExpense.GetHashCode();
                if (this.NetIncomeFromContinuingOperations != null)
                    hashCode = hashCode * 59 + this.NetIncomeFromContinuingOperations.GetHashCode();
                if (this.ComprehensiveIncomeNetOfTax != null)
                    hashCode = hashCode * 59 + this.ComprehensiveIncomeNetOfTax.GetHashCode();
                if (this.Ebit != null)
                    hashCode = hashCode * 59 + this.Ebit.GetHashCode();
                if (this.Ebitda != null)
                    hashCode = hashCode * 59 + this.Ebitda.GetHashCode();
                if (this.NetIncome != null)
                    hashCode = hashCode * 59 + this.NetIncome.GetHashCode();
                if (this.EffectOfAccountingCharges != null)
                    hashCode = hashCode * 59 + this.EffectOfAccountingCharges.GetHashCode();
                if (this.TaxProvision != null)
                    hashCode = hashCode * 59 + this.TaxProvision.GetHashCode();
                if (this.SellingAndMarketingExpenses != null)
                    hashCode = hashCode * 59 + this.SellingAndMarketingExpenses.GetHashCode();
                if (this.ExtraordinaryItems != null)
                    hashCode = hashCode * 59 + this.ExtraordinaryItems.GetHashCode();
                return hashCode;
            }
        }
    }
}
