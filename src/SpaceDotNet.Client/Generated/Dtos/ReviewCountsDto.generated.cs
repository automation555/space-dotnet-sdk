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
    public class ReviewCountsDto
    {
        [Required]
        [JsonPropertyName("opened")]
        public int Opened { get; set; }        
        
        [Required]
        [JsonPropertyName("closed")]
        public int Closed { get; set; }        
        
        [Required]
        [JsonPropertyName("authoredByMe")]
        public int AuthoredByMe { get; set; }        
        
        [Required]
        [JsonPropertyName("reviewedByMe")]
        public int ReviewedByMe { get; set; }        
        
        [Required]
        [JsonPropertyName("needsMyAttention")]
        public int NeedsMyAttention { get; set; }        
        
        [Required]
        [JsonPropertyName("needsMyReview")]
        public int NeedsMyReview { get; set; }        
        
    }
    
}
