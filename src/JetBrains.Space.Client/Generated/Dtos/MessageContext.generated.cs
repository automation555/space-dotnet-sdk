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
#pragma warning disable 618

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Space.Common;
using JetBrains.Space.Common.Json.Serialization;
using JetBrains.Space.Common.Json.Serialization.Polymorphism;
using JetBrains.Space.Common.Types;

namespace JetBrains.Space.Client;

public sealed class MessageContext
     : IPropagatePropertyAccessPath
{
    public MessageContext() { }
    
    public MessageContext(string messageId, string channelId, string createdTime, string? messageData = null, ChatMessage? body = null, List<Attachment>? attachments = null, string? externalId = null)
    {
        MessageId = messageId;
        ChannelId = channelId;
        MessageData = messageData;
        Body = body;
        Attachments = attachments;
        ExternalId = externalId;
        CreatedTime = createdTime;
    }
    
    private PropertyValue<string> _messageId = new PropertyValue<string>(nameof(MessageContext), nameof(MessageId));
    
    [Required]
    [JsonPropertyName("messageId")]
    public string MessageId
    {
        get => _messageId.GetValue();
        set => _messageId.SetValue(value);
    }

    private PropertyValue<string> _channelId = new PropertyValue<string>(nameof(MessageContext), nameof(ChannelId));
    
    [Required]
    [JsonPropertyName("channelId")]
    public string ChannelId
    {
        get => _channelId.GetValue();
        set => _channelId.SetValue(value);
    }

    private PropertyValue<string?> _messageData = new PropertyValue<string?>(nameof(MessageContext), nameof(MessageData));
    
    [JsonPropertyName("messageData")]
    public string? MessageData
    {
        get => _messageData.GetValue();
        set => _messageData.SetValue(value);
    }

    private PropertyValue<ChatMessage?> _body = new PropertyValue<ChatMessage?>(nameof(MessageContext), nameof(Body));
    
    [JsonPropertyName("body")]
    public ChatMessage? Body
    {
        get => _body.GetValue();
        set => _body.SetValue(value);
    }

    private PropertyValue<List<Attachment>?> _attachments = new PropertyValue<List<Attachment>?>(nameof(MessageContext), nameof(Attachments));
    
    [JsonPropertyName("attachments")]
    public List<Attachment>? Attachments
    {
        get => _attachments.GetValue();
        set => _attachments.SetValue(value);
    }

    private PropertyValue<string?> _externalId = new PropertyValue<string?>(nameof(MessageContext), nameof(ExternalId));
    
    [JsonPropertyName("externalId")]
    public string? ExternalId
    {
        get => _externalId.GetValue();
        set => _externalId.SetValue(value);
    }

    private PropertyValue<string> _createdTime = new PropertyValue<string>(nameof(MessageContext), nameof(CreatedTime));
    
    [Required]
    [JsonPropertyName("createdTime")]
    public string CreatedTime
    {
        get => _createdTime.GetValue();
        set => _createdTime.SetValue(value);
    }

    public  void SetAccessPath(string path, bool validateHasBeenSet)
    {
        _messageId.SetAccessPath(path, validateHasBeenSet);
        _channelId.SetAccessPath(path, validateHasBeenSet);
        _messageData.SetAccessPath(path, validateHasBeenSet);
        _body.SetAccessPath(path, validateHasBeenSet);
        _attachments.SetAccessPath(path, validateHasBeenSet);
        _externalId.SetAccessPath(path, validateHasBeenSet);
        _createdTime.SetAccessPath(path, validateHasBeenSet);
    }

}

