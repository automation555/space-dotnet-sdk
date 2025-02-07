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

public sealed class OpenPersonalFeedSettingsAction
     : ClientSideActionContext, IClassNameConvertible, IPropagatePropertyAccessPath
{
    [JsonPropertyName("className")]
    public  string? ClassName => "OpenPersonalFeedSettingsAction";
    
    public OpenPersonalFeedSettingsAction() { }
    
    public OpenPersonalFeedSettingsAction(string tab, string feed, string? feedId = null)
    {
        Tab = tab;
        Feed = feed;
        FeedId = feedId;
    }
    
    private PropertyValue<string> _tab = new PropertyValue<string>(nameof(OpenPersonalFeedSettingsAction), nameof(Tab));
    
    [Required]
    [JsonPropertyName("tab")]
    public string Tab
    {
        get => _tab.GetValue();
        set => _tab.SetValue(value);
    }

    private PropertyValue<string> _feed = new PropertyValue<string>(nameof(OpenPersonalFeedSettingsAction), nameof(Feed));
    
    [Required]
    [JsonPropertyName("feed")]
    public string Feed
    {
        get => _feed.GetValue();
        set => _feed.SetValue(value);
    }

    private PropertyValue<string?> _feedId = new PropertyValue<string?>(nameof(OpenPersonalFeedSettingsAction), nameof(FeedId));
    
    [JsonPropertyName("feedId")]
    public string? FeedId
    {
        get => _feedId.GetValue();
        set => _feedId.SetValue(value);
    }

    public  void SetAccessPath(string path, bool validateHasBeenSet)
    {
        _tab.SetAccessPath(path, validateHasBeenSet);
        _feed.SetAccessPath(path, validateHasBeenSet);
        _feedId.SetAccessPath(path, validateHasBeenSet);
    }

}

