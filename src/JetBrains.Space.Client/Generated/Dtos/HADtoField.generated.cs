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
    public sealed class HADtoField
         : IPropagatePropertyAccessPath
    {
        public HADtoField() { }
        
        public HADtoField(HAField field, bool extension)
        {
            Field = field;
            IsExtension = extension;
        }
        
        private PropertyValue<HAField> _field = new PropertyValue<HAField>(nameof(HADtoField), nameof(Field));
        
        [Required]
        [JsonPropertyName("field")]
        public HAField Field
        {
            get => _field.GetValue();
            set => _field.SetValue(value);
        }
    
        private PropertyValue<bool> _extension = new PropertyValue<bool>(nameof(HADtoField), nameof(IsExtension));
        
        [Required]
        [JsonPropertyName("extension")]
        public bool IsExtension
        {
            get => _extension.GetValue();
            set => _extension.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _field.SetAccessPath(path, validateHasBeenSet);
            _extension.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
