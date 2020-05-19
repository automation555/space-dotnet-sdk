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
    public class PushCommitStatusRequestDto
    {
        [JsonPropertyName("branch")]
        public string? Branch { get; set; }        
        
        [JsonPropertyName("changes")]
        public List<string>? Changes { get; set; }        
        
        [Required]
        [JsonPropertyName("executionStatus")]
        public ExecutionStatus ExecutionStatus { get; set; }        
        
        [Required]
        [JsonPropertyName("url")]
        public string Url { get; set; }        
        
        [Required]
        [JsonPropertyName("externalServiceName")]
        public string ExternalServiceName { get; set; }        
        
        [Required]
        [JsonPropertyName("taskName")]
        public string TaskName { get; set; }        
        
        [Required]
        [JsonPropertyName("taskId")]
        public string TaskId { get; set; }        
        
        [JsonPropertyName("timestamp")]
        public long? Timestamp { get; set; }        
        
        [JsonPropertyName("description")]
        public string? Description { get; set; }        
        
    }
    
}
