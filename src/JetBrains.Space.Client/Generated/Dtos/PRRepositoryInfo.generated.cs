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

public sealed class PRRepositoryInfo
     : IPropagatePropertyAccessPath
{
    public PRRepositoryInfo() { }
    
    public PRRepositoryInfo(string name, string description, RepositoryState state, string? id = null, DateTime? latestActivity = null, DateTime? proxyPushNotification = null, string? proxyPushNotificationBody = null, string? initProgress = null, string? readmeName = null, RepositoryActivity? monthlyActivity = null)
    {
        Id = id;
        Name = name;
        Description = description;
        LatestActivity = latestActivity;
        ProxyPushNotification = proxyPushNotification;
        ProxyPushNotificationBody = proxyPushNotificationBody;
        State = state;
        InitProgress = initProgress;
        ReadmeName = readmeName;
        MonthlyActivity = monthlyActivity;
    }
    
    private PropertyValue<string?> _id = new PropertyValue<string?>(nameof(PRRepositoryInfo), nameof(Id));
    
    [JsonPropertyName("id")]
    public string? Id
    {
        get => _id.GetValue();
        set => _id.SetValue(value);
    }

    private PropertyValue<string> _name = new PropertyValue<string>(nameof(PRRepositoryInfo), nameof(Name));
    
    [Required]
    [JsonPropertyName("name")]
    public string Name
    {
        get => _name.GetValue();
        set => _name.SetValue(value);
    }

    private PropertyValue<string> _description = new PropertyValue<string>(nameof(PRRepositoryInfo), nameof(Description));
    
    [Required]
    [JsonPropertyName("description")]
    public string Description
    {
        get => _description.GetValue();
        set => _description.SetValue(value);
    }

    private PropertyValue<DateTime?> _latestActivity = new PropertyValue<DateTime?>(nameof(PRRepositoryInfo), nameof(LatestActivity));
    
    [JsonPropertyName("latestActivity")]
    [JsonConverter(typeof(SpaceDateTimeConverter))]
    public DateTime? LatestActivity
    {
        get => _latestActivity.GetValue();
        set => _latestActivity.SetValue(value);
    }

    private PropertyValue<DateTime?> _proxyPushNotification = new PropertyValue<DateTime?>(nameof(PRRepositoryInfo), nameof(ProxyPushNotification));
    
    [JsonPropertyName("proxyPushNotification")]
    [JsonConverter(typeof(SpaceDateTimeConverter))]
    public DateTime? ProxyPushNotification
    {
        get => _proxyPushNotification.GetValue();
        set => _proxyPushNotification.SetValue(value);
    }

    private PropertyValue<string?> _proxyPushNotificationBody = new PropertyValue<string?>(nameof(PRRepositoryInfo), nameof(ProxyPushNotificationBody));
    
    [JsonPropertyName("proxyPushNotificationBody")]
    public string? ProxyPushNotificationBody
    {
        get => _proxyPushNotificationBody.GetValue();
        set => _proxyPushNotificationBody.SetValue(value);
    }

    private PropertyValue<RepositoryState> _state = new PropertyValue<RepositoryState>(nameof(PRRepositoryInfo), nameof(State));
    
    [Required]
    [JsonPropertyName("state")]
    public RepositoryState State
    {
        get => _state.GetValue();
        set => _state.SetValue(value);
    }

    private PropertyValue<string?> _initProgress = new PropertyValue<string?>(nameof(PRRepositoryInfo), nameof(InitProgress));
    
    [JsonPropertyName("initProgress")]
    public string? InitProgress
    {
        get => _initProgress.GetValue();
        set => _initProgress.SetValue(value);
    }

    private PropertyValue<string?> _readmeName = new PropertyValue<string?>(nameof(PRRepositoryInfo), nameof(ReadmeName));
    
    [JsonPropertyName("readmeName")]
    public string? ReadmeName
    {
        get => _readmeName.GetValue();
        set => _readmeName.SetValue(value);
    }

    private PropertyValue<RepositoryActivity?> _monthlyActivity = new PropertyValue<RepositoryActivity?>(nameof(PRRepositoryInfo), nameof(MonthlyActivity));
    
    [JsonPropertyName("monthlyActivity")]
    public RepositoryActivity? MonthlyActivity
    {
        get => _monthlyActivity.GetValue();
        set => _monthlyActivity.SetValue(value);
    }

    public  void SetAccessPath(string path, bool validateHasBeenSet)
    {
        _id.SetAccessPath(path, validateHasBeenSet);
        _name.SetAccessPath(path, validateHasBeenSet);
        _description.SetAccessPath(path, validateHasBeenSet);
        _latestActivity.SetAccessPath(path, validateHasBeenSet);
        _proxyPushNotification.SetAccessPath(path, validateHasBeenSet);
        _proxyPushNotificationBody.SetAccessPath(path, validateHasBeenSet);
        _state.SetAccessPath(path, validateHasBeenSet);
        _initProgress.SetAccessPath(path, validateHasBeenSet);
        _readmeName.SetAccessPath(path, validateHasBeenSet);
        _monthlyActivity.SetAccessPath(path, validateHasBeenSet);
    }

}

