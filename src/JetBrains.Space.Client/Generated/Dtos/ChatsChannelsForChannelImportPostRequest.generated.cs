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

public class ChatsChannelsForChannelImportPostRequest
     : IPropagatePropertyAccessPath
{
    public ChatsChannelsForChannelImportPostRequest() { }
    
    public ChatsChannelsForChannelImportPostRequest(List<MessageForImport> messages)
    {
        Messages = messages;
    }
    
    private PropertyValue<List<MessageForImport>> _messages = new PropertyValue<List<MessageForImport>>(nameof(ChatsChannelsForChannelImportPostRequest), nameof(Messages), new List<MessageForImport>());
    
    [Required]
    [JsonPropertyName("messages")]
    public List<MessageForImport> Messages
    {
        get => _messages.GetValue();
        set => _messages.SetValue(value);
    }

    public virtual void SetAccessPath(string path, bool validateHasBeenSet)
    {
        _messages.SetAccessPath(path, validateHasBeenSet);
    }

}

