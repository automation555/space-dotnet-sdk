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
    public sealed class LastChanges
         : IPropagatePropertyAccessPath
    {
        public LastChanges() { }
        
        public LastChanges(List<RevisionInfo> lastChanges, int totalChanges)
        {
            LastChangesItems = lastChanges;
            TotalChanges = totalChanges;
        }
        
        private PropertyValue<List<RevisionInfo>> _lastChanges = new PropertyValue<List<RevisionInfo>>(nameof(LastChanges), nameof(LastChangesItems), new List<RevisionInfo>());
        
        [Required]
        [JsonPropertyName("lastChanges")]
        public List<RevisionInfo> LastChangesItems
        {
            get => _lastChanges.GetValue();
            set => _lastChanges.SetValue(value);
        }
    
        private PropertyValue<int> _totalChanges = new PropertyValue<int>(nameof(LastChanges), nameof(TotalChanges));
        
        [Required]
        [JsonPropertyName("totalChanges")]
        public int TotalChanges
        {
            get => _totalChanges.GetValue();
            set => _totalChanges.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _lastChanges.SetAccessPath(path, validateHasBeenSet);
            _totalChanges.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
