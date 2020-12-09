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
    public sealed class ESBuiltinAuthModuleSettings
         : ESPasswordAuthModuleSettings, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public override string? ClassName => "ES_BuiltinAuthModuleSettings";
        
        public ESBuiltinAuthModuleSettings() { }
        
        public ESBuiltinAuthModuleSettings(PasswordStrength passwordStrengthPolicy, List<string>? domains = null)
        {
            PasswordStrengthPolicy = passwordStrengthPolicy;
            Domains = domains;
        }
        
        private PropertyValue<PasswordStrength> _passwordStrengthPolicy = new PropertyValue<PasswordStrength>(nameof(ESBuiltinAuthModuleSettings), nameof(PasswordStrengthPolicy));
        
        [Required]
        [JsonPropertyName("passwordStrengthPolicy")]
        public PasswordStrength PasswordStrengthPolicy
        {
            get => _passwordStrengthPolicy.GetValue();
            set => _passwordStrengthPolicy.SetValue(value);
        }
    
        private PropertyValue<List<string>?> _domains = new PropertyValue<List<string>?>(nameof(ESBuiltinAuthModuleSettings), nameof(Domains));
        
        [JsonPropertyName("domains")]
        public List<string>? Domains
        {
            get => _domains.GetValue();
            set => _domains.SetValue(value);
        }
    
        public override void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _passwordStrengthPolicy.SetAccessPath(path, validateHasBeenSet);
            _domains.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
