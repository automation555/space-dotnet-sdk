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

public sealed class M2ChannelRdWsTimelineInfo
     : M2ChannelContactInfo, M2ChannelContentInfo, IClassNameConvertible, IPropagatePropertyAccessPath
{
    [JsonPropertyName("className")]
    public  string? ClassName => "M2ChannelRdWsTimelineInfo";
    
    public M2ChannelRdWsTimelineInfo() { }
    
    public M2ChannelRdWsTimelineInfo(ChannelSpecificDefaults notificationDefaults, string workspaceId, string workspaceName)
    {
        NotificationDefaults = notificationDefaults;
        WorkspaceId = workspaceId;
        WorkspaceName = workspaceName;
    }
    
    private PropertyValue<ChannelSpecificDefaults> _notificationDefaults = new PropertyValue<ChannelSpecificDefaults>(nameof(M2ChannelRdWsTimelineInfo), nameof(NotificationDefaults));
    
    [Required]
    [JsonPropertyName("notificationDefaults")]
    public ChannelSpecificDefaults NotificationDefaults
    {
        get => _notificationDefaults.GetValue();
        set => _notificationDefaults.SetValue(value);
    }

    private PropertyValue<string> _workspaceId = new PropertyValue<string>(nameof(M2ChannelRdWsTimelineInfo), nameof(WorkspaceId));
    
    [Required]
    [JsonPropertyName("workspaceId")]
    public string WorkspaceId
    {
        get => _workspaceId.GetValue();
        set => _workspaceId.SetValue(value);
    }

    private PropertyValue<string> _workspaceName = new PropertyValue<string>(nameof(M2ChannelRdWsTimelineInfo), nameof(WorkspaceName));
    
    [Required]
    [JsonPropertyName("workspaceName")]
    public string WorkspaceName
    {
        get => _workspaceName.GetValue();
        set => _workspaceName.SetValue(value);
    }

    public  void SetAccessPath(string path, bool validateHasBeenSet)
    {
        _notificationDefaults.SetAccessPath(path, validateHasBeenSet);
        _workspaceId.SetAccessPath(path, validateHasBeenSet);
        _workspaceName.SetAccessPath(path, validateHasBeenSet);
    }

}

