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
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Space.Client.Internal;
using JetBrains.Space.Common;
using JetBrains.Space.Common.Json.Serialization;
using JetBrains.Space.Common.Json.Serialization.Polymorphism;
using JetBrains.Space.Common.Types;

namespace JetBrains.Space.Client
{
    public sealed class OpenEnumCFValue
         : CFValue, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public override string? ClassName => "OpenEnumCFValue";
        
        public OpenEnumCFValue() { }
        
        public OpenEnumCFValue(EnumValueData? value = null)
        {
            Value = value;
        }
        
        private PropertyValue<EnumValueData?> _value = new PropertyValue<EnumValueData?>(nameof(OpenEnumCFValue), nameof(Value));
        
        [JsonPropertyName("value")]
        public EnumValueData? Value
        {
            get => _value.GetValue();
            set => _value.SetValue(value);
        }
    
        public override void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _value.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
