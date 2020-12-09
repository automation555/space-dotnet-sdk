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
    public sealed class ESApprovedScope
         : IPropagatePropertyAccessPath
    {
        public ESApprovedScope() { }
        
        public ESApprovedScope(string id, string scope, bool offlineAllowed)
        {
            Id = id;
            Scope = scope;
            IsOfflineAllowed = offlineAllowed;
        }
        
        private PropertyValue<string> _id = new PropertyValue<string>(nameof(ESApprovedScope), nameof(Id));
        
        [Required]
        [JsonPropertyName("id")]
        public string Id
        {
            get => _id.GetValue();
            set => _id.SetValue(value);
        }
    
        private PropertyValue<string> _scope = new PropertyValue<string>(nameof(ESApprovedScope), nameof(Scope));
        
        [Required]
        [JsonPropertyName("scope")]
        public string Scope
        {
            get => _scope.GetValue();
            set => _scope.SetValue(value);
        }
    
        private PropertyValue<bool> _offlineAllowed = new PropertyValue<bool>(nameof(ESApprovedScope), nameof(IsOfflineAllowed));
        
        [Required]
        [JsonPropertyName("offlineAllowed")]
        public bool IsOfflineAllowed
        {
            get => _offlineAllowed.GetValue();
            set => _offlineAllowed.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _id.SetAccessPath(path, validateHasBeenSet);
            _scope.SetAccessPath(path, validateHasBeenSet);
            _offlineAllowed.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
