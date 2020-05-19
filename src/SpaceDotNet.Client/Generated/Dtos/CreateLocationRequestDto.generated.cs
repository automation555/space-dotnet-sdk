// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

#nullable enable

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using SpaceDotNet.Client.Internal;
using SpaceDotNet.Common;
using SpaceDotNet.Common.Json.Serialization;
using SpaceDotNet.Common.Types;

namespace SpaceDotNet.Client
{
    public class CreateLocationRequestDto
    {
        [Required]
        [JsonPropertyName("name")]
        public string Name { get; set; }        
        
        [JsonPropertyName("timezone")]
        public string? Timezone { get; set; }        
        
        [JsonPropertyName("workdays")]
        public List<int>? Workdays { get; set; }        
        
        [JsonPropertyName("phones")]
        public List<string>? Phones { get; set; }        
        
        [JsonPropertyName("emails")]
        public List<string>? Emails { get; set; }        
        
        [JsonPropertyName("equipment")]
        public List<string>? Equipment { get; set; }        
        
        [JsonPropertyName("description")]
        public string? Description { get; set; }        
        
        [JsonPropertyName("address")]
        public string? Address { get; set; }        
        
        [JsonPropertyName("type")]
        public string? Type { get; set; }        
        
        [JsonPropertyName("parentId")]
        public string? ParentId { get; set; }        
        
    }
    
}
