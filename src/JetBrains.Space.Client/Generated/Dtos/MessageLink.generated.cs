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

public sealed class MessageLink
     : IPropagatePropertyAccessPath
{
    public MessageLink() { }
    
    public MessageLink(string channelKey, string channelId, string messageId)
    {
        ChannelKey = channelKey;
        ChannelId = channelId;
        MessageId = messageId;
    }
    
    private PropertyValue<string> _channelKey = new PropertyValue<string>(nameof(MessageLink), nameof(ChannelKey));
    
    [Required]
    [JsonPropertyName("channelKey")]
    public string ChannelKey
    {
        get => _channelKey.GetValue();
        set => _channelKey.SetValue(value);
    }

    private PropertyValue<string> _channelId = new PropertyValue<string>(nameof(MessageLink), nameof(ChannelId));
    
    [Required]
    [JsonPropertyName("channelId")]
    public string ChannelId
    {
        get => _channelId.GetValue();
        set => _channelId.SetValue(value);
    }

    private PropertyValue<string> _messageId = new PropertyValue<string>(nameof(MessageLink), nameof(MessageId));
    
    [Required]
    [JsonPropertyName("messageId")]
    public string MessageId
    {
        get => _messageId.GetValue();
        set => _messageId.SetValue(value);
    }

    public  void SetAccessPath(string path, bool validateHasBeenSet)
    {
        _channelKey.SetAccessPath(path, validateHasBeenSet);
        _channelId.SetAccessPath(path, validateHasBeenSet);
        _messageId.SetAccessPath(path, validateHasBeenSet);
    }

}

