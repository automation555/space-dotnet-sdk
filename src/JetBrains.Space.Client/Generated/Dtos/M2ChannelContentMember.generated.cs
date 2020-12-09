// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

#nullable enable
#pragma warning disable CS1591
#pragma warning disable CS0108

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Space.Common;
using JetBrains.Space.Common.Json.Serialization;
using JetBrains.Space.Common.Json.Serialization.Polymorphism;
using JetBrains.Space.Common.Types;

namespace JetBrains.Space.Client
{
    public sealed class M2ChannelContentMember
         : M2ChannelContactInfo, M2ChannelContentInfo, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public  string? ClassName => "M2ChannelContentMember";
        
        public M2ChannelContentMember() { }
        
        public M2ChannelContentMember(TDMemberProfile member, ChannelSpecificDefaults notificationDefaults, ProfileAbsencesRecord? memberAbsences = null, ProfileMembershipRecord? memberTeams = null)
        {
            Member = member;
            NotificationDefaults = notificationDefaults;
            MemberAbsences = memberAbsences;
            MemberTeams = memberTeams;
        }
        
        private PropertyValue<TDMemberProfile> _member = new PropertyValue<TDMemberProfile>(nameof(M2ChannelContentMember), nameof(Member));
        
        [Required]
        [JsonPropertyName("member")]
        public TDMemberProfile Member
        {
            get => _member.GetValue();
            set => _member.SetValue(value);
        }
    
        private PropertyValue<ChannelSpecificDefaults> _notificationDefaults = new PropertyValue<ChannelSpecificDefaults>(nameof(M2ChannelContentMember), nameof(NotificationDefaults));
        
        [Required]
        [JsonPropertyName("notificationDefaults")]
        public ChannelSpecificDefaults NotificationDefaults
        {
            get => _notificationDefaults.GetValue();
            set => _notificationDefaults.SetValue(value);
        }
    
        private PropertyValue<ProfileAbsencesRecord?> _memberAbsences = new PropertyValue<ProfileAbsencesRecord?>(nameof(M2ChannelContentMember), nameof(MemberAbsences));
        
        [JsonPropertyName("memberAbsences")]
        public ProfileAbsencesRecord? MemberAbsences
        {
            get => _memberAbsences.GetValue();
            set => _memberAbsences.SetValue(value);
        }
    
        private PropertyValue<ProfileMembershipRecord?> _memberTeams = new PropertyValue<ProfileMembershipRecord?>(nameof(M2ChannelContentMember), nameof(MemberTeams));
        
        [JsonPropertyName("memberTeams")]
        public ProfileMembershipRecord? MemberTeams
        {
            get => _memberTeams.GetValue();
            set => _memberTeams.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _member.SetAccessPath(path, validateHasBeenSet);
            _notificationDefaults.SetAccessPath(path, validateHasBeenSet);
            _memberAbsences.SetAccessPath(path, validateHasBeenSet);
            _memberTeams.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
