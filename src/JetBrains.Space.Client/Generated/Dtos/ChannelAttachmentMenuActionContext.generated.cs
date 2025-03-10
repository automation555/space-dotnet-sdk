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

public sealed class ChannelAttachmentMenuActionContext
     : MenuActionContext, IClassNameConvertible, IPropagatePropertyAccessPath
{
    [JsonPropertyName("className")]
    public  string? ClassName => "ChannelAttachmentMenuActionContext";
    
    public ChannelAttachmentMenuActionContext() { }
    
    public ChannelAttachmentMenuActionContext(string menuId, string channelId)
    {
        MenuId = menuId;
        ChannelId = channelId;
    }
    
    private PropertyValue<string> _menuId = new PropertyValue<string>(nameof(ChannelAttachmentMenuActionContext), nameof(MenuId));
    
    [Required]
    [JsonPropertyName("menuId")]
    public string MenuId
    {
        get => _menuId.GetValue();
        set => _menuId.SetValue(value);
    }

    private PropertyValue<string> _channelId = new PropertyValue<string>(nameof(ChannelAttachmentMenuActionContext), nameof(ChannelId));
    
    [Required]
    [JsonPropertyName("channelId")]
    public string ChannelId
    {
        get => _channelId.GetValue();
        set => _channelId.SetValue(value);
    }

    public  void SetAccessPath(string path, bool validateHasBeenSet)
    {
        _menuId.SetAccessPath(path, validateHasBeenSet);
        _channelId.SetAccessPath(path, validateHasBeenSet);
    }

}

