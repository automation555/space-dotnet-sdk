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
    public sealed class ChannelParticipant
         : IPropagatePropertyAccessPath
    {
        public ChannelParticipant() { }
        
        public ChannelParticipant(CPrincipal principal, int messageCount, int? pendingMessageCount = null)
        {
            Principal = principal;
            MessageCount = messageCount;
            PendingMessageCount = pendingMessageCount;
        }
        
        private PropertyValue<CPrincipal> _principal = new PropertyValue<CPrincipal>(nameof(ChannelParticipant), nameof(Principal));
        
        [Required]
        [JsonPropertyName("principal")]
        public CPrincipal Principal
        {
            get => _principal.GetValue();
            set => _principal.SetValue(value);
        }
    
        private PropertyValue<int> _messageCount = new PropertyValue<int>(nameof(ChannelParticipant), nameof(MessageCount));
        
        [Required]
        [JsonPropertyName("messageCount")]
        public int MessageCount
        {
            get => _messageCount.GetValue();
            set => _messageCount.SetValue(value);
        }
    
        private PropertyValue<int?> _pendingMessageCount = new PropertyValue<int?>(nameof(ChannelParticipant), nameof(PendingMessageCount));
        
        [JsonPropertyName("pendingMessageCount")]
        public int? PendingMessageCount
        {
            get => _pendingMessageCount.GetValue();
            set => _pendingMessageCount.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _principal.SetAccessPath(path, validateHasBeenSet);
            _messageCount.SetAccessPath(path, validateHasBeenSet);
            _pendingMessageCount.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
