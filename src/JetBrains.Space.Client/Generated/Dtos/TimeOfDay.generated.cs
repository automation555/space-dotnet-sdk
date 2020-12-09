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
    public sealed class TimeOfDay
         : IPropagatePropertyAccessPath
    {
        public TimeOfDay() { }
        
        public TimeOfDay(int hours, int minutes)
        {
            Hours = hours;
            Minutes = minutes;
        }
        
        private PropertyValue<int> _hours = new PropertyValue<int>(nameof(TimeOfDay), nameof(Hours));
        
        [Required]
        [JsonPropertyName("hours")]
        public int Hours
        {
            get => _hours.GetValue();
            set => _hours.SetValue(value);
        }
    
        private PropertyValue<int> _minutes = new PropertyValue<int>(nameof(TimeOfDay), nameof(Minutes));
        
        [Required]
        [JsonPropertyName("minutes")]
        public int Minutes
        {
            get => _minutes.GetValue();
            set => _minutes.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _hours.SetAccessPath(path, validateHasBeenSet);
            _minutes.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
