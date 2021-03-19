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
    public sealed class ESOAuthConsent
         : IPropagatePropertyAccessPath
    {
        public ESOAuthConsent() { }
        
        public ESOAuthConsent(ESApp clientApplication, List<ESApprovedScope> approvedScopes, List<ESRefreshToken> refreshTokens, ESService? clientService = null)
        {
            ClientService = clientService;
            ClientApplication = clientApplication;
            ApprovedScopes = approvedScopes;
            RefreshTokens = refreshTokens;
        }
        
        private PropertyValue<ESService?> _clientService = new PropertyValue<ESService?>(nameof(ESOAuthConsent), nameof(ClientService));
        
        [JsonPropertyName("clientService")]
        public ESService? ClientService
        {
            get => _clientService.GetValue();
            set => _clientService.SetValue(value);
        }
    
        private PropertyValue<ESApp> _clientApplication = new PropertyValue<ESApp>(nameof(ESOAuthConsent), nameof(ClientApplication));
        
        [Required]
        [JsonPropertyName("clientApplication")]
        public ESApp ClientApplication
        {
            get => _clientApplication.GetValue();
            set => _clientApplication.SetValue(value);
        }
    
        private PropertyValue<List<ESApprovedScope>> _approvedScopes = new PropertyValue<List<ESApprovedScope>>(nameof(ESOAuthConsent), nameof(ApprovedScopes), new List<ESApprovedScope>());
        
        [Required]
        [JsonPropertyName("approvedScopes")]
        public List<ESApprovedScope> ApprovedScopes
        {
            get => _approvedScopes.GetValue();
            set => _approvedScopes.SetValue(value);
        }
    
        private PropertyValue<List<ESRefreshToken>> _refreshTokens = new PropertyValue<List<ESRefreshToken>>(nameof(ESOAuthConsent), nameof(RefreshTokens), new List<ESRefreshToken>());
        
        [Required]
        [JsonPropertyName("refreshTokens")]
        public List<ESRefreshToken> RefreshTokens
        {
            get => _refreshTokens.GetValue();
            set => _refreshTokens.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _clientService.SetAccessPath(path, validateHasBeenSet);
            _clientApplication.SetAccessPath(path, validateHasBeenSet);
            _approvedScopes.SetAccessPath(path, validateHasBeenSet);
            _refreshTokens.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
