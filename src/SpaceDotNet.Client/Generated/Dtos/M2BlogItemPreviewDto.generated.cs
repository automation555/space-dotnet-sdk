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
    public class M2BlogItemPreviewDto
         : M2ItemContentDetailsDto, IClassNameConvertible
    {
        [JsonPropertyName("className")]
        public string? ClassName { get; set; }
        
        [Required]
        [JsonPropertyName("article")]
        public ArticleRecordDto Article { get; set; }        
        
        [Required]
        [JsonPropertyName("articlePreview")]
        public ArticlePreviewRecordDto ArticlePreview { get; set; }        
        
        [Required]
        [JsonPropertyName("articleDetails")]
        public ArticleDetailsRecordDto ArticleDetails { get; set; }        
        
        [Required]
        [JsonPropertyName("articleChannel")]
        public ArticleChannelRecordDto ArticleChannel { get; set; }        
        
    }
    
}
