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
    public class TDMemberProfileDto
    {
        [Required]
        [JsonPropertyName("id")]
        public string Id { get; set; }        
        
        [Required]
        [JsonPropertyName("username")]
        public string Username { get; set; }        
        
        [Required]
        [JsonPropertyName("name")]
        public TDProfileNameDto Name { get; set; }        
        
        [Required]
        [JsonPropertyName("speaksEnglish")]
        public bool SpeaksEnglish { get; set; }        
        
        [JsonPropertyName("smallAvatar")]
        public string? SmallAvatar { get; set; }        
        
        [JsonPropertyName("avatar")]
        public string? Avatar { get; set; }        
        
        [JsonPropertyName("profilePicture")]
        public string? ProfilePicture { get; set; }        
        
        [Required]
        [JsonPropertyName("languages")]
        public List<TDProfileLanguageDto> Languages { get; set; }        
        
        [Required]
        [JsonPropertyName("archived")]
        public bool Archived { get; set; }        
        
        [Required]
        [JsonPropertyName("notAMember")]
        public bool NotAMember { get; set; }        
        
        [JsonPropertyName("joined")]
        public SpaceDate? Joined { get; set; }        
        
        [JsonPropertyName("left")]
        public SpaceDate? Left { get; set; }        
        
        [JsonPropertyName("leftAt")]
        public SpaceTime? LeftAt { get; set; }        
        
        [Required]
        [JsonPropertyName("absences")]
        public List<AbsenceRecordDto> Absences { get; set; }        
        
        [Required]
        [JsonPropertyName("emails")]
        public List<TDProfileEmailDto> Emails { get; set; }        
        
        [Required]
        [JsonPropertyName("links")]
        public List<string> Links { get; set; }        
        
        [Required]
        [JsonPropertyName("messengers")]
        public List<string> Messengers { get; set; }        
        
        [Required]
        [JsonPropertyName("phones")]
        public List<string> Phones { get; set; }        
        
        [Required]
        [JsonPropertyName("locations")]
        public List<TDMemberLocationDto> Locations { get; set; }        
        
        [Required]
        [JsonPropertyName("managers")]
        public List<TDMemberProfileDto> Managers { get; set; }        
        
        [Required]
        [JsonPropertyName("membershipHistory")]
        public List<TDMembershipDto> MembershipHistory { get; set; }        
        
        [Required]
        [JsonPropertyName("memberships")]
        public List<TDMembershipDto> Memberships { get; set; }        
        
        [JsonPropertyName("about")]
        public string? About { get; set; }        
        
        [JsonPropertyName("avatarCropSquare")]
        public AvatarCropSquareDto? AvatarCropSquare { get; set; }        
        
        [JsonPropertyName("birthday")]
        public SpaceDate? Birthday { get; set; }        
        
        [JsonPropertyName("gender")]
        public Gender? Gender { get; set; }        
        
    }
    
}
