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
    public sealed class ResponsibilityRecord
         : IPropagatePropertyAccessPath
    {
        public ResponsibilityRecord() { }
        
        public ResponsibilityRecord(string responsibilityId, string summary, List<AssignedPerson> assignedPeople, string? notes = null)
        {
            ResponsibilityId = responsibilityId;
            Summary = summary;
            Notes = notes;
            AssignedPeople = assignedPeople;
        }
        
        private PropertyValue<string> _responsibilityId = new PropertyValue<string>(nameof(ResponsibilityRecord), nameof(ResponsibilityId));
        
        [Required]
        [JsonPropertyName("responsibilityId")]
        public string ResponsibilityId
        {
            get => _responsibilityId.GetValue();
            set => _responsibilityId.SetValue(value);
        }
    
        private PropertyValue<string> _summary = new PropertyValue<string>(nameof(ResponsibilityRecord), nameof(Summary));
        
        [Required]
        [JsonPropertyName("summary")]
        public string Summary
        {
            get => _summary.GetValue();
            set => _summary.SetValue(value);
        }
    
        private PropertyValue<string?> _notes = new PropertyValue<string?>(nameof(ResponsibilityRecord), nameof(Notes));
        
        [JsonPropertyName("notes")]
        public string? Notes
        {
            get => _notes.GetValue();
            set => _notes.SetValue(value);
        }
    
        private PropertyValue<List<AssignedPerson>> _assignedPeople = new PropertyValue<List<AssignedPerson>>(nameof(ResponsibilityRecord), nameof(AssignedPeople), new List<AssignedPerson>());
        
        [Required]
        [JsonPropertyName("assignedPeople")]
        public List<AssignedPerson> AssignedPeople
        {
            get => _assignedPeople.GetValue();
            set => _assignedPeople.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _responsibilityId.SetAccessPath(path, validateHasBeenSet);
            _summary.SetAccessPath(path, validateHasBeenSet);
            _notes.SetAccessPath(path, validateHasBeenSet);
            _assignedPeople.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
