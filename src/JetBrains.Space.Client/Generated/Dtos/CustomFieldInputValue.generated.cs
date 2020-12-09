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
    public sealed class CustomFieldInputValue
         : IPropagatePropertyAccessPath
    {
        public CustomFieldInputValue() { }
        
        public CustomFieldInputValue(string fieldId, CFInputValue value)
        {
            FieldId = fieldId;
            Value = value;
        }
        
        private PropertyValue<string> _fieldId = new PropertyValue<string>(nameof(CustomFieldInputValue), nameof(FieldId));
        
        [Required]
        [JsonPropertyName("fieldId")]
        public string FieldId
        {
            get => _fieldId.GetValue();
            set => _fieldId.SetValue(value);
        }
    
        private PropertyValue<CFInputValue> _value = new PropertyValue<CFInputValue>(nameof(CustomFieldInputValue), nameof(Value));
        
        [Required]
        [JsonPropertyName("value")]
        public CFInputValue Value
        {
            get => _value.GetValue();
            set => _value.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _fieldId.SetAccessPath(path, validateHasBeenSet);
            _value.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
