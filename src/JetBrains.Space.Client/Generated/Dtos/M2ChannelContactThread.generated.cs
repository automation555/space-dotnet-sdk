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
    public sealed class M2ChannelContactThread
         : M2ChannelContactInfo, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public  string? ClassName => "M2ChannelContactThread";
        
        public M2ChannelContactThread() { }
        
        public M2ChannelContactThread(M2ChannelRecord parent, string? text = null, string? messageId = null, TDMemberProfile? author = null, CPrincipal? messageAuthor = null, string? attachments = null)
        {
            Parent = parent;
            Text = text;
            MessageId = messageId;
            Author = author;
            MessageAuthor = messageAuthor;
            Attachments = attachments;
        }
        
        private PropertyValue<M2ChannelRecord> _parent = new PropertyValue<M2ChannelRecord>(nameof(M2ChannelContactThread), nameof(Parent));
        
        [Required]
        [JsonPropertyName("parent")]
        public M2ChannelRecord Parent
        {
            get => _parent.GetValue();
            set => _parent.SetValue(value);
        }
    
        private PropertyValue<string?> _text = new PropertyValue<string?>(nameof(M2ChannelContactThread), nameof(Text));
        
        [JsonPropertyName("text")]
        public string? Text
        {
            get => _text.GetValue();
            set => _text.SetValue(value);
        }
    
        private PropertyValue<string?> _messageId = new PropertyValue<string?>(nameof(M2ChannelContactThread), nameof(MessageId));
        
        [JsonPropertyName("messageId")]
        public string? MessageId
        {
            get => _messageId.GetValue();
            set => _messageId.SetValue(value);
        }
    
        private PropertyValue<TDMemberProfile?> _author = new PropertyValue<TDMemberProfile?>(nameof(M2ChannelContactThread), nameof(Author));
        
        [JsonPropertyName("author")]
        public TDMemberProfile? Author
        {
            get => _author.GetValue();
            set => _author.SetValue(value);
        }
    
        private PropertyValue<CPrincipal?> _messageAuthor = new PropertyValue<CPrincipal?>(nameof(M2ChannelContactThread), nameof(MessageAuthor));
        
        [JsonPropertyName("messageAuthor")]
        public CPrincipal? MessageAuthor
        {
            get => _messageAuthor.GetValue();
            set => _messageAuthor.SetValue(value);
        }
    
        private PropertyValue<string?> _attachments = new PropertyValue<string?>(nameof(M2ChannelContactThread), nameof(Attachments));
        
        [JsonPropertyName("attachments")]
        public string? Attachments
        {
            get => _attachments.GetValue();
            set => _attachments.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _parent.SetAccessPath(path, validateHasBeenSet);
            _text.SetAccessPath(path, validateHasBeenSet);
            _messageId.SetAccessPath(path, validateHasBeenSet);
            _author.SetAccessPath(path, validateHasBeenSet);
            _messageAuthor.SetAccessPath(path, validateHasBeenSet);
            _attachments.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
