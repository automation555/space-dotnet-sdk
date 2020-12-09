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

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Space.Common;
using JetBrains.Space.Common.Json.Serialization;
using JetBrains.Space.Common.Json.Serialization.Polymorphism;
using JetBrains.Space.Common.Types;

namespace JetBrains.Space.Client.AllChannelsListEntryPartialBuilder
{
    public static class AllChannelsListEntryPartialExtensions
    {
        public static Partial<AllChannelsListEntry> WithChannelId(this Partial<AllChannelsListEntry> it)
            => it.AddFieldName("channelId");
        
        public static Partial<AllChannelsListEntry> WithName(this Partial<AllChannelsListEntry> it)
            => it.AddFieldName("name");
        
        public static Partial<AllChannelsListEntry> WithDescription(this Partial<AllChannelsListEntry> it)
            => it.AddFieldName("description");
        
        public static Partial<AllChannelsListEntry> WithAccess(this Partial<AllChannelsListEntry> it)
            => it.AddFieldName("access");
        
        public static Partial<AllChannelsListEntry> WithAccess(this Partial<AllChannelsListEntry> it, Func<Partial<M2Access>, Partial<M2Access>> partialBuilder)
            => it.AddFieldName("access", partialBuilder(new Partial<M2Access>(it)));
        
        public static Partial<AllChannelsListEntry> WithIcon(this Partial<AllChannelsListEntry> it)
            => it.AddFieldName("icon");
        
        public static Partial<AllChannelsListEntry> WithCreated(this Partial<AllChannelsListEntry> it)
            => it.AddFieldName("created");
        
        public static Partial<AllChannelsListEntry> WithSubscribers(this Partial<AllChannelsListEntry> it)
            => it.AddFieldName("subscribers");
        
        public static Partial<AllChannelsListEntry> WithIsSubscribed(this Partial<AllChannelsListEntry> it)
            => it.AddFieldName("subscribed");
        
    }
    
}
