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

public class NotificationsChannelSubscriptionsForIdPatchRequest
     : IPropagatePropertyAccessPath
{
    public NotificationsChannelSubscriptionsForIdPatchRequest() { }
    
    public NotificationsChannelSubscriptionsForIdPatchRequest(string? name = null, bool? enabled = null, CustomGenericSubscriptionIn? subscription = null)
    {
        Name = name;
        IsEnabled = enabled;
        Subscription = subscription;
    }
    
    private PropertyValue<string?> _name = new PropertyValue<string?>(nameof(NotificationsChannelSubscriptionsForIdPatchRequest), nameof(Name));
    
    [JsonPropertyName("name")]
    public string? Name
    {
        get => _name.GetValue();
        set => _name.SetValue(value);
    }

    private PropertyValue<bool?> _enabled = new PropertyValue<bool?>(nameof(NotificationsChannelSubscriptionsForIdPatchRequest), nameof(IsEnabled));
    
    [JsonPropertyName("enabled")]
    public bool? IsEnabled
    {
        get => _enabled.GetValue();
        set => _enabled.SetValue(value);
    }

    private PropertyValue<CustomGenericSubscriptionIn?> _subscription = new PropertyValue<CustomGenericSubscriptionIn?>(nameof(NotificationsChannelSubscriptionsForIdPatchRequest), nameof(Subscription));
    
    [JsonPropertyName("subscription")]
    public CustomGenericSubscriptionIn? Subscription
    {
        get => _subscription.GetValue();
        set => _subscription.SetValue(value);
    }

    public virtual void SetAccessPath(string path, bool validateHasBeenSet)
    {
        _name.SetAccessPath(path, validateHasBeenSet);
        _enabled.SetAccessPath(path, validateHasBeenSet);
        _subscription.SetAccessPath(path, validateHasBeenSet);
    }

}

