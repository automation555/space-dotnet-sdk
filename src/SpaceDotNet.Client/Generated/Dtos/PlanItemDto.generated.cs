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
    public class PlanItemDto
    {
        [Required]
        [JsonPropertyName("id")]
        public string Id { get; set; }        
        
        [Required]
        [JsonPropertyName("checklistId")]
        public string ChecklistId { get; set; }        
        
        [JsonPropertyName("tag")]
        public PlanningTagDto? Tag { get; set; }        
        
        [JsonPropertyName("simpleText")]
        public string? SimpleText { get; set; }        
        
        [JsonPropertyName("simpleDone")]
        public bool? SimpleDone { get; set; }        
        
        [JsonPropertyName("issue")]
        public IssueDto? Issue { get; set; }        
        
        [JsonPropertyName("issueProblem")]
        public string? IssueProblem { get; set; }        
        
        [JsonPropertyName("canEditIssue")]
        public bool? CanEditIssue { get; set; }        
        
        [Required]
        [JsonPropertyName("hasChildren")]
        public bool HasChildren { get; set; }        
        
        [Required]
        [JsonPropertyName("children")]
        public List<PlanItemDto> Children { get; set; }        
        
    }
    
}
