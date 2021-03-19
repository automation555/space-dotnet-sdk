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
    public sealed class IntListCFValue
         : CFValue, CFInputValue, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public override string? ClassName => "IntListCFValue";
        
        public IntListCFValue() { }
        
        public IntListCFValue(List<int> values)
        {
            Values = values;
        }
        
        private PropertyValue<List<int>> _values = new PropertyValue<List<int>>(nameof(IntListCFValue), nameof(Values), new List<int>());
        
        [Required]
        [JsonPropertyName("values")]
        public List<int> Values
        {
            get => _values.GetValue();
            set => _values.SetValue(value);
        }
    
        public override void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _values.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
