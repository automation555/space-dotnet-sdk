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
    public sealed class Currency
         : IPropagatePropertyAccessPath
    {
        public Currency() { }
        
        public Currency(string code, bool signAsPrefix, string? sign = null)
        {
            Code = code;
            Sign = sign;
            IsSignAsPrefix = signAsPrefix;
        }
        
        private PropertyValue<string> _code = new PropertyValue<string>(nameof(Currency), nameof(Code));
        
        [Required]
        [JsonPropertyName("code")]
        public string Code
        {
            get => _code.GetValue();
            set => _code.SetValue(value);
        }
    
        private PropertyValue<string?> _sign = new PropertyValue<string?>(nameof(Currency), nameof(Sign));
        
        [JsonPropertyName("sign")]
        public string? Sign
        {
            get => _sign.GetValue();
            set => _sign.SetValue(value);
        }
    
        private PropertyValue<bool> _signAsPrefix = new PropertyValue<bool>(nameof(Currency), nameof(IsSignAsPrefix));
        
        [Required]
        [JsonPropertyName("signAsPrefix")]
        public bool IsSignAsPrefix
        {
            get => _signAsPrefix.GetValue();
            set => _signAsPrefix.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _code.SetAccessPath(path, validateHasBeenSet);
            _sign.SetAccessPath(path, validateHasBeenSet);
            _signAsPrefix.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
