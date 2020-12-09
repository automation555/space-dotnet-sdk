// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

#nullable enable
#pragma warning disable CS1591
#pragma warning disable CS0108

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Space.Common;
using JetBrains.Space.Common.Json.Serialization;
using JetBrains.Space.Common.Json.Serialization.Polymorphism;
using JetBrains.Space.Common.Types;

namespace JetBrains.Space.Client
{
    public sealed class PurchasedBillingPlan
         : IPropagatePropertyAccessPath
    {
        public PurchasedBillingPlan() { }
        
        public PurchasedBillingPlan(string id, string plan, string billingPeriod, DateTime since, DateTime till, Currency currency, double addUserPrice, double addStoragePrice, double addBandwidthPrice, double addCiCreditPrice, int minActiveUsers, int prepaidUsers, int storagePerUser, int storageOverall, int bandwidthPerUser, int bandwidthOverall, int ciCredits, int ciCreditsReserve, int integrations, int searchHistory, double hardLimitAmount, string? jetSalesId = null)
        {
            Id = id;
            JetSalesId = jetSalesId;
            Plan = plan;
            BillingPeriod = billingPeriod;
            Since = since;
            Till = till;
            Currency = currency;
            AddUserPrice = addUserPrice;
            AddStoragePrice = addStoragePrice;
            AddBandwidthPrice = addBandwidthPrice;
            AddCiCreditPrice = addCiCreditPrice;
            MinActiveUsers = minActiveUsers;
            PrepaidUsers = prepaidUsers;
            StoragePerUser = storagePerUser;
            StorageOverall = storageOverall;
            BandwidthPerUser = bandwidthPerUser;
            BandwidthOverall = bandwidthOverall;
            CiCredits = ciCredits;
            CiCreditsReserve = ciCreditsReserve;
            Integrations = integrations;
            SearchHistory = searchHistory;
            HardLimitAmount = hardLimitAmount;
        }
        
        private PropertyValue<string> _id = new PropertyValue<string>(nameof(PurchasedBillingPlan), nameof(Id));
        
        [Required]
        [JsonPropertyName("id")]
        public string Id
        {
            get => _id.GetValue();
            set => _id.SetValue(value);
        }
    
        private PropertyValue<string?> _jetSalesId = new PropertyValue<string?>(nameof(PurchasedBillingPlan), nameof(JetSalesId));
        
        [JsonPropertyName("jetSalesId")]
        public string? JetSalesId
        {
            get => _jetSalesId.GetValue();
            set => _jetSalesId.SetValue(value);
        }
    
        private PropertyValue<string> _plan = new PropertyValue<string>(nameof(PurchasedBillingPlan), nameof(Plan));
        
        [Required]
        [JsonPropertyName("plan")]
        public string Plan
        {
            get => _plan.GetValue();
            set => _plan.SetValue(value);
        }
    
        private PropertyValue<string> _billingPeriod = new PropertyValue<string>(nameof(PurchasedBillingPlan), nameof(BillingPeriod));
        
        [Required]
        [JsonPropertyName("billingPeriod")]
        public string BillingPeriod
        {
            get => _billingPeriod.GetValue();
            set => _billingPeriod.SetValue(value);
        }
    
        private PropertyValue<DateTime> _since = new PropertyValue<DateTime>(nameof(PurchasedBillingPlan), nameof(Since));
        
        [Required]
        [JsonPropertyName("since")]
        [JsonConverter(typeof(SpaceDateConverter))]
        public DateTime Since
        {
            get => _since.GetValue();
            set => _since.SetValue(value);
        }
    
        private PropertyValue<DateTime> _till = new PropertyValue<DateTime>(nameof(PurchasedBillingPlan), nameof(Till));
        
        [Required]
        [JsonPropertyName("till")]
        [JsonConverter(typeof(SpaceDateConverter))]
        public DateTime Till
        {
            get => _till.GetValue();
            set => _till.SetValue(value);
        }
    
        private PropertyValue<Currency> _currency = new PropertyValue<Currency>(nameof(PurchasedBillingPlan), nameof(Currency));
        
        [Required]
        [JsonPropertyName("currency")]
        public Currency Currency
        {
            get => _currency.GetValue();
            set => _currency.SetValue(value);
        }
    
        private PropertyValue<double> _addUserPrice = new PropertyValue<double>(nameof(PurchasedBillingPlan), nameof(AddUserPrice));
        
        [Required]
        [JsonPropertyName("addUserPrice")]
        public double AddUserPrice
        {
            get => _addUserPrice.GetValue();
            set => _addUserPrice.SetValue(value);
        }
    
        private PropertyValue<double> _addStoragePrice = new PropertyValue<double>(nameof(PurchasedBillingPlan), nameof(AddStoragePrice));
        
        [Required]
        [JsonPropertyName("addStoragePrice")]
        public double AddStoragePrice
        {
            get => _addStoragePrice.GetValue();
            set => _addStoragePrice.SetValue(value);
        }
    
        private PropertyValue<double> _addBandwidthPrice = new PropertyValue<double>(nameof(PurchasedBillingPlan), nameof(AddBandwidthPrice));
        
        [Required]
        [JsonPropertyName("addBandwidthPrice")]
        public double AddBandwidthPrice
        {
            get => _addBandwidthPrice.GetValue();
            set => _addBandwidthPrice.SetValue(value);
        }
    
        private PropertyValue<double> _addCiCreditPrice = new PropertyValue<double>(nameof(PurchasedBillingPlan), nameof(AddCiCreditPrice));
        
        [Required]
        [JsonPropertyName("addCiCreditPrice")]
        public double AddCiCreditPrice
        {
            get => _addCiCreditPrice.GetValue();
            set => _addCiCreditPrice.SetValue(value);
        }
    
        private PropertyValue<int> _minActiveUsers = new PropertyValue<int>(nameof(PurchasedBillingPlan), nameof(MinActiveUsers));
        
        [Required]
        [JsonPropertyName("minActiveUsers")]
        public int MinActiveUsers
        {
            get => _minActiveUsers.GetValue();
            set => _minActiveUsers.SetValue(value);
        }
    
        private PropertyValue<int> _prepaidUsers = new PropertyValue<int>(nameof(PurchasedBillingPlan), nameof(PrepaidUsers));
        
        [Required]
        [JsonPropertyName("prepaidUsers")]
        public int PrepaidUsers
        {
            get => _prepaidUsers.GetValue();
            set => _prepaidUsers.SetValue(value);
        }
    
        private PropertyValue<int> _storagePerUser = new PropertyValue<int>(nameof(PurchasedBillingPlan), nameof(StoragePerUser));
        
        [Required]
        [JsonPropertyName("storagePerUser")]
        public int StoragePerUser
        {
            get => _storagePerUser.GetValue();
            set => _storagePerUser.SetValue(value);
        }
    
        private PropertyValue<int> _storageOverall = new PropertyValue<int>(nameof(PurchasedBillingPlan), nameof(StorageOverall));
        
        [Required]
        [JsonPropertyName("storageOverall")]
        public int StorageOverall
        {
            get => _storageOverall.GetValue();
            set => _storageOverall.SetValue(value);
        }
    
        private PropertyValue<int> _bandwidthPerUser = new PropertyValue<int>(nameof(PurchasedBillingPlan), nameof(BandwidthPerUser));
        
        [Required]
        [JsonPropertyName("bandwidthPerUser")]
        public int BandwidthPerUser
        {
            get => _bandwidthPerUser.GetValue();
            set => _bandwidthPerUser.SetValue(value);
        }
    
        private PropertyValue<int> _bandwidthOverall = new PropertyValue<int>(nameof(PurchasedBillingPlan), nameof(BandwidthOverall));
        
        [Required]
        [JsonPropertyName("bandwidthOverall")]
        public int BandwidthOverall
        {
            get => _bandwidthOverall.GetValue();
            set => _bandwidthOverall.SetValue(value);
        }
    
        private PropertyValue<int> _ciCredits = new PropertyValue<int>(nameof(PurchasedBillingPlan), nameof(CiCredits));
        
        [Required]
        [JsonPropertyName("ciCredits")]
        public int CiCredits
        {
            get => _ciCredits.GetValue();
            set => _ciCredits.SetValue(value);
        }
    
        private PropertyValue<int> _ciCreditsReserve = new PropertyValue<int>(nameof(PurchasedBillingPlan), nameof(CiCreditsReserve));
        
        [Required]
        [JsonPropertyName("ciCreditsReserve")]
        public int CiCreditsReserve
        {
            get => _ciCreditsReserve.GetValue();
            set => _ciCreditsReserve.SetValue(value);
        }
    
        private PropertyValue<int> _integrations = new PropertyValue<int>(nameof(PurchasedBillingPlan), nameof(Integrations));
        
        [Required]
        [JsonPropertyName("integrations")]
        public int Integrations
        {
            get => _integrations.GetValue();
            set => _integrations.SetValue(value);
        }
    
        private PropertyValue<int> _searchHistory = new PropertyValue<int>(nameof(PurchasedBillingPlan), nameof(SearchHistory));
        
        [Required]
        [JsonPropertyName("searchHistory")]
        public int SearchHistory
        {
            get => _searchHistory.GetValue();
            set => _searchHistory.SetValue(value);
        }
    
        private PropertyValue<double> _hardLimitAmount = new PropertyValue<double>(nameof(PurchasedBillingPlan), nameof(HardLimitAmount));
        
        [Required]
        [JsonPropertyName("hardLimitAmount")]
        public double HardLimitAmount
        {
            get => _hardLimitAmount.GetValue();
            set => _hardLimitAmount.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _id.SetAccessPath(path, validateHasBeenSet);
            _jetSalesId.SetAccessPath(path, validateHasBeenSet);
            _plan.SetAccessPath(path, validateHasBeenSet);
            _billingPeriod.SetAccessPath(path, validateHasBeenSet);
            _since.SetAccessPath(path, validateHasBeenSet);
            _till.SetAccessPath(path, validateHasBeenSet);
            _currency.SetAccessPath(path, validateHasBeenSet);
            _addUserPrice.SetAccessPath(path, validateHasBeenSet);
            _addStoragePrice.SetAccessPath(path, validateHasBeenSet);
            _addBandwidthPrice.SetAccessPath(path, validateHasBeenSet);
            _addCiCreditPrice.SetAccessPath(path, validateHasBeenSet);
            _minActiveUsers.SetAccessPath(path, validateHasBeenSet);
            _prepaidUsers.SetAccessPath(path, validateHasBeenSet);
            _storagePerUser.SetAccessPath(path, validateHasBeenSet);
            _storageOverall.SetAccessPath(path, validateHasBeenSet);
            _bandwidthPerUser.SetAccessPath(path, validateHasBeenSet);
            _bandwidthOverall.SetAccessPath(path, validateHasBeenSet);
            _ciCredits.SetAccessPath(path, validateHasBeenSet);
            _ciCreditsReserve.SetAccessPath(path, validateHasBeenSet);
            _integrations.SetAccessPath(path, validateHasBeenSet);
            _searchHistory.SetAccessPath(path, validateHasBeenSet);
            _hardLimitAmount.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
