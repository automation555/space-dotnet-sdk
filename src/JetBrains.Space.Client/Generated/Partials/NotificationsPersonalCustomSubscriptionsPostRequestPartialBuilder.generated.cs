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

namespace JetBrains.Space.Client.NotificationsPersonalCustomSubscriptionsPostRequestPartialBuilder;

public static class NotificationsPersonalCustomSubscriptionsPostRequestPartialExtensions
{
    public static Partial<NotificationsPersonalCustomSubscriptionsPostRequest> WithProfile(this Partial<NotificationsPersonalCustomSubscriptionsPostRequest> it)
        => it.AddFieldName("profile");
    
    public static Partial<NotificationsPersonalCustomSubscriptionsPostRequest> WithProfile(this Partial<NotificationsPersonalCustomSubscriptionsPostRequest> it, Func<Partial<ProfileIdentifier>, Partial<ProfileIdentifier>> partialBuilder)
        => it.AddFieldName("profile", partialBuilder(new Partial<ProfileIdentifier>(it)));
    
    public static Partial<NotificationsPersonalCustomSubscriptionsPostRequest> WithName(this Partial<NotificationsPersonalCustomSubscriptionsPostRequest> it)
        => it.AddFieldName("name");
    
    public static Partial<NotificationsPersonalCustomSubscriptionsPostRequest> WithFeed(this Partial<NotificationsPersonalCustomSubscriptionsPostRequest> it)
        => it.AddFieldName("feed");
    
    public static Partial<NotificationsPersonalCustomSubscriptionsPostRequest> WithSubscription(this Partial<NotificationsPersonalCustomSubscriptionsPostRequest> it)
        => it.AddFieldName("subscription");
    
    public static Partial<NotificationsPersonalCustomSubscriptionsPostRequest> WithSubscription(this Partial<NotificationsPersonalCustomSubscriptionsPostRequest> it, Func<Partial<CustomGenericSubscriptionIn>, Partial<CustomGenericSubscriptionIn>> partialBuilder)
        => it.AddFieldName("subscription", partialBuilder(new Partial<CustomGenericSubscriptionIn>(it)));
    
}

