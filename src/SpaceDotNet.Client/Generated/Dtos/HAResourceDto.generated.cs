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
    public class HAResourceDto
    {
        [Required]
        [JsonPropertyName("id")]
        public string Id { get; set; }        
        
        [Required]
        [JsonPropertyName("path")]
        public HAPathDto Path { get; set; }        
        
        [Required]
        [JsonPropertyName("displaySingular")]
        public string DisplaySingular { get; set; }        
        
        [Required]
        [JsonPropertyName("displayPlural")]
        public string DisplayPlural { get; set; }        
        
        [JsonPropertyName("parentResource")]
        public HAResourceDto? ParentResource { get; set; }        
        
        [Required]
        [JsonPropertyName("endpoints")]
        public List<HAEndpointDto> Endpoints { get; set; }        
        
        [Required]
        [JsonPropertyName("nestedResources")]
        public List<HAResourceDto> NestedResources { get; set; }        
        
    }
    
}
