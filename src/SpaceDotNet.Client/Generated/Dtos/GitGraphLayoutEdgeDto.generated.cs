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
    public class GitGraphLayoutEdgeDto
    {
        [Required]
        [JsonPropertyName("from")]
        public int From { get; set; }        
        
        [Required]
        [JsonPropertyName("to")]
        public int To { get; set; }        
        
        [Required]
        [JsonPropertyName("type")]
        public GitGraphEdgeType Type { get; set; }        
        
        [Required]
        [JsonPropertyName("style")]
        public GitGraphEdgeLineStyle Style { get; set; }        
        
        [Required]
        [JsonPropertyName("hasArrow")]
        public bool HasArrow { get; set; }        
        
        [Required]
        [JsonPropertyName("color")]
        public int Color { get; set; }        
        
    }
    
}
