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
    public sealed class HAUrlParameterOptionConst
         : HAUrlParameterOption, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public override string? ClassName => "HA_UrlParameterOption.Const";
        
        public HAUrlParameterOptionConst() { }
        
        public HAUrlParameterOptionConst(string value, string optionName, HADeprecation? deprecation = null)
        {
            Value = value;
            OptionName = optionName;
            Deprecation = deprecation;
        }
        
        private PropertyValue<string> _value = new PropertyValue<string>(nameof(HAUrlParameterOptionConst), nameof(Value));
        
        [Required]
        [JsonPropertyName("value")]
        public string Value
        {
            get => _value.GetValue();
            set => _value.SetValue(value);
        }
    
        private PropertyValue<string> _optionName = new PropertyValue<string>(nameof(HAUrlParameterOptionConst), nameof(OptionName));
        
        [Required]
        [JsonPropertyName("optionName")]
        public string OptionName
        {
            get => _optionName.GetValue();
            set => _optionName.SetValue(value);
        }
    
        private PropertyValue<HADeprecation?> _deprecation = new PropertyValue<HADeprecation?>(nameof(HAUrlParameterOptionConst), nameof(Deprecation));
        
        [JsonPropertyName("deprecation")]
        public HADeprecation? Deprecation
        {
            get => _deprecation.GetValue();
            set => _deprecation.SetValue(value);
        }
    
        public override void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _value.SetAccessPath(path, validateHasBeenSet);
            _optionName.SetAccessPath(path, validateHasBeenSet);
            _deprecation.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
