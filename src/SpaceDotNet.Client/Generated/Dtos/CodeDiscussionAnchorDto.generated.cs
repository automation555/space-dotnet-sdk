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
    public class CodeDiscussionAnchorDto
    {
        [Required]
        [JsonPropertyName("project")]
        public ProjectKeyDto Project { get; set; }        
        
        [Required]
        [JsonPropertyName("repository")]
        public string Repository { get; set; }        
        
        [Required]
        [JsonPropertyName("revision")]
        public string Revision { get; set; }        
        
        [JsonPropertyName("filename")]
        public string? Filename { get; set; }        
        
        [JsonPropertyName("line")]
        public int? Line { get; set; }        
        
        [JsonPropertyName("oldLine")]
        public int? OldLine { get; set; }        
        
        [JsonPropertyName("interpolatedLineState")]
        public InterpolatedLineState? InterpolatedLineState { get; set; }        
        
    }
    
}
