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
    public class M2PrivateConversationChannelContentDto
         : M2ChannelContactInfoDto, M2ChannelContentInfoDto, IClassNameConvertible
    {
        [JsonPropertyName("className")]
        public string? ClassName { get; set; }
        
        [Required]
        [JsonPropertyName("channelId")]
        public string ChannelId { get; set; }        
        
        [JsonPropertyName("subject")]
        public string? Subject { get; set; }        
        
        [Required]
        [JsonPropertyName("members")]
        public List<TDMemberProfileDto> Members { get; set; }        
        
        [JsonPropertyName("notificationDefaults")]
        public ChannelSpecificDefaultsDto? NotificationDefaults { get; set; }        
        
    }
    
}
