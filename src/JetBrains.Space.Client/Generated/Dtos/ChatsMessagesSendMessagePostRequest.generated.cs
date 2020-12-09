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
    public class ChatsMessagesSendMessagePostRequest
         : IPropagatePropertyAccessPath
    {
        public ChatsMessagesSendMessagePostRequest() { }
        
        public ChatsMessagesSendMessagePostRequest(MessageRecipient recipient, ChatMessage content, bool? unfurlLinks = null, List<AttachmentIn>? attachments = null, string? externalId = null)
        {
            Recipient = recipient;
            Content = content;
            IsUnfurlLinks = unfurlLinks;
            Attachments = attachments;
            ExternalId = externalId;
        }
        
        private PropertyValue<MessageRecipient> _recipient = new PropertyValue<MessageRecipient>(nameof(ChatsMessagesSendMessagePostRequest), nameof(Recipient));
        
        [Required]
        [JsonPropertyName("recipient")]
        public MessageRecipient Recipient
        {
            get => _recipient.GetValue();
            set => _recipient.SetValue(value);
        }
    
        private PropertyValue<ChatMessage> _content = new PropertyValue<ChatMessage>(nameof(ChatsMessagesSendMessagePostRequest), nameof(Content));
        
        [Required]
        [JsonPropertyName("content")]
        public ChatMessage Content
        {
            get => _content.GetValue();
            set => _content.SetValue(value);
        }
    
        private PropertyValue<bool?> _unfurlLinks = new PropertyValue<bool?>(nameof(ChatsMessagesSendMessagePostRequest), nameof(IsUnfurlLinks));
        
        [JsonPropertyName("unfurlLinks")]
        public bool? IsUnfurlLinks
        {
            get => _unfurlLinks.GetValue();
            set => _unfurlLinks.SetValue(value);
        }
    
        private PropertyValue<List<AttachmentIn>?> _attachments = new PropertyValue<List<AttachmentIn>?>(nameof(ChatsMessagesSendMessagePostRequest), nameof(Attachments));
        
        [JsonPropertyName("attachments")]
        public List<AttachmentIn>? Attachments
        {
            get => _attachments.GetValue();
            set => _attachments.SetValue(value);
        }
    
        private PropertyValue<string?> _externalId = new PropertyValue<string?>(nameof(ChatsMessagesSendMessagePostRequest), nameof(ExternalId));
        
        [JsonPropertyName("externalId")]
        public string? ExternalId
        {
            get => _externalId.GetValue();
            set => _externalId.SetValue(value);
        }
    
        public virtual void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _recipient.SetAccessPath(path, validateHasBeenSet);
            _content.SetAccessPath(path, validateHasBeenSet);
            _unfurlLinks.SetAccessPath(path, validateHasBeenSet);
            _attachments.SetAccessPath(path, validateHasBeenSet);
            _externalId.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
