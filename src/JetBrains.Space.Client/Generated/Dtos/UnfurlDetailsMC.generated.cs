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

public sealed class UnfurlDetailsMC
     : UnfurlDetails, IClassNameConvertible, IPropagatePropertyAccessPath
{
    [JsonPropertyName("className")]
    public  string? ClassName => "UnfurlDetailsMC";
    
    public UnfurlDetailsMC() { }
    
    public UnfurlDetailsMC(MCMessage message, List<AttachmentInfo>? inlineUnfurls = null)
    {
        Message = message;
        InlineUnfurls = inlineUnfurls;
    }
    
    private PropertyValue<MCMessage> _message = new PropertyValue<MCMessage>(nameof(UnfurlDetailsMC), nameof(Message));
    
    [Required]
    [JsonPropertyName("message")]
    public MCMessage Message
    {
        get => _message.GetValue();
        set => _message.SetValue(value);
    }

    private PropertyValue<List<AttachmentInfo>?> _inlineUnfurls = new PropertyValue<List<AttachmentInfo>?>(nameof(UnfurlDetailsMC), nameof(InlineUnfurls));
    
    [JsonPropertyName("inlineUnfurls")]
    public List<AttachmentInfo>? InlineUnfurls
    {
        get => _inlineUnfurls.GetValue();
        set => _inlineUnfurls.SetValue(value);
    }

    public  void SetAccessPath(string path, bool validateHasBeenSet)
    {
        _message.SetAccessPath(path, validateHasBeenSet);
        _inlineUnfurls.SetAccessPath(path, validateHasBeenSet);
    }

}

