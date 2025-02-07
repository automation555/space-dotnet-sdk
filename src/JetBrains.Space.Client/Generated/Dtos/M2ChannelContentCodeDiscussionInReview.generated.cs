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

public sealed class M2ChannelContentCodeDiscussionInReview
     : ChannelContactThread, IClassNameConvertible, IPropagatePropertyAccessPath
{
    [JsonPropertyName("className")]
    public  string? ClassName => "M2ChannelContentCodeDiscussionInReview";
    
    public M2ChannelContentCodeDiscussionInReview() { }
    
    public M2ChannelContentCodeDiscussionInReview(ChannelSpecificDefaults notificationDefaults, CodeDiscussionRecord codeDiscussion, M2ChannelRecord parent, string messageId)
    {
        NotificationDefaults = notificationDefaults;
        CodeDiscussion = codeDiscussion;
        Parent = parent;
        MessageId = messageId;
    }
    
    private PropertyValue<ChannelSpecificDefaults> _notificationDefaults = new PropertyValue<ChannelSpecificDefaults>(nameof(M2ChannelContentCodeDiscussionInReview), nameof(NotificationDefaults));
    
    [Required]
    [JsonPropertyName("notificationDefaults")]
    public ChannelSpecificDefaults NotificationDefaults
    {
        get => _notificationDefaults.GetValue();
        set => _notificationDefaults.SetValue(value);
    }

    private PropertyValue<CodeDiscussionRecord> _codeDiscussion = new PropertyValue<CodeDiscussionRecord>(nameof(M2ChannelContentCodeDiscussionInReview), nameof(CodeDiscussion));
    
    [Required]
    [JsonPropertyName("codeDiscussion")]
    public CodeDiscussionRecord CodeDiscussion
    {
        get => _codeDiscussion.GetValue();
        set => _codeDiscussion.SetValue(value);
    }

    private PropertyValue<M2ChannelRecord> _parent = new PropertyValue<M2ChannelRecord>(nameof(M2ChannelContentCodeDiscussionInReview), nameof(Parent));
    
    [Required]
    [JsonPropertyName("parent")]
    public M2ChannelRecord Parent
    {
        get => _parent.GetValue();
        set => _parent.SetValue(value);
    }

    private PropertyValue<string> _messageId = new PropertyValue<string>(nameof(M2ChannelContentCodeDiscussionInReview), nameof(MessageId));
    
    [Required]
    [JsonPropertyName("messageId")]
    public string MessageId
    {
        get => _messageId.GetValue();
        set => _messageId.SetValue(value);
    }

    public  void SetAccessPath(string path, bool validateHasBeenSet)
    {
        _notificationDefaults.SetAccessPath(path, validateHasBeenSet);
        _codeDiscussion.SetAccessPath(path, validateHasBeenSet);
        _parent.SetAccessPath(path, validateHasBeenSet);
        _messageId.SetAccessPath(path, validateHasBeenSet);
    }

}

