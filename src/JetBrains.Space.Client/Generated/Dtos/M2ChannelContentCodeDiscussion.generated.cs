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
    public sealed class M2ChannelContentCodeDiscussion
         : M2ChannelContactInfo, M2ChannelContentInfo, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public  string? ClassName => "M2ChannelContentCodeDiscussion";
        
        public M2ChannelContentCodeDiscussion() { }
        
        public M2ChannelContentCodeDiscussion(string codeDiscussionId, ChannelSpecificDefaults notificationDefaults, CodeDiscussionRecord? codeDiscussion = null)
        {
            CodeDiscussionId = codeDiscussionId;
            NotificationDefaults = notificationDefaults;
            CodeDiscussion = codeDiscussion;
        }
        
        private PropertyValue<string> _codeDiscussionId = new PropertyValue<string>(nameof(M2ChannelContentCodeDiscussion), nameof(CodeDiscussionId));
        
        [Required]
        [JsonPropertyName("codeDiscussionId")]
        public string CodeDiscussionId
        {
            get => _codeDiscussionId.GetValue();
            set => _codeDiscussionId.SetValue(value);
        }
    
        private PropertyValue<ChannelSpecificDefaults> _notificationDefaults = new PropertyValue<ChannelSpecificDefaults>(nameof(M2ChannelContentCodeDiscussion), nameof(NotificationDefaults));
        
        [Required]
        [JsonPropertyName("notificationDefaults")]
        public ChannelSpecificDefaults NotificationDefaults
        {
            get => _notificationDefaults.GetValue();
            set => _notificationDefaults.SetValue(value);
        }
    
        private PropertyValue<CodeDiscussionRecord?> _codeDiscussion = new PropertyValue<CodeDiscussionRecord?>(nameof(M2ChannelContentCodeDiscussion), nameof(CodeDiscussion));
        
        [JsonPropertyName("codeDiscussion")]
        public CodeDiscussionRecord? CodeDiscussion
        {
            get => _codeDiscussion.GetValue();
            set => _codeDiscussion.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _codeDiscussionId.SetAccessPath(path, validateHasBeenSet);
            _notificationDefaults.SetAccessPath(path, validateHasBeenSet);
            _codeDiscussion.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
