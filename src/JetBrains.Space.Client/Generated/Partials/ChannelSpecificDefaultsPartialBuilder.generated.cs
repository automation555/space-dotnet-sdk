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

namespace JetBrains.Space.Client.ChannelSpecificDefaultsPartialBuilder
{
    public static class ChannelSpecificDefaultsPartialExtensions
    {
        public static Partial<ChannelSpecificDefaults> WithFilter(this Partial<ChannelSpecificDefaults> it)
            => it.AddFieldName("filter");
        
        public static Partial<ChannelSpecificDefaults> WithFilter(this Partial<ChannelSpecificDefaults> it, Func<Partial<NotificationFilter>, Partial<NotificationFilter>> partialBuilder)
            => it.AddFieldName("filter", partialBuilder(new Partial<NotificationFilter>(it)));
        
        public static Partial<ChannelSpecificDefaults> WithIsPush(this Partial<ChannelSpecificDefaults> it)
            => it.AddFieldName("push");
        
        public static Partial<ChannelSpecificDefaults> WithEmail(this Partial<ChannelSpecificDefaults> it)
            => it.AddFieldName("email");
        
        public static Partial<ChannelSpecificDefaults> WithEmail(this Partial<ChannelSpecificDefaults> it, Func<Partial<M2EmailNotificationType>, Partial<M2EmailNotificationType>> partialBuilder)
            => it.AddFieldName("email", partialBuilder(new Partial<M2EmailNotificationType>(it)));
        
        public static Partial<ChannelSpecificDefaults> WithIsThreadsSubscribed(this Partial<ChannelSpecificDefaults> it)
            => it.AddFieldName("threadsSubscribed");
        
    }
    
}
