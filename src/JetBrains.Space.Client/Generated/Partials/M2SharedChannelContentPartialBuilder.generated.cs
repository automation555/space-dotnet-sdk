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

namespace JetBrains.Space.Client.M2SharedChannelContentPartialBuilder
{
    public static class M2SharedChannelContentPartialExtensions
    {
        public static Partial<M2SharedChannelContent> WithName(this Partial<M2SharedChannelContent> it)
            => it.AddFieldName("name");
        
        public static Partial<M2SharedChannelContent> WithGroup(this Partial<M2SharedChannelContent> it)
            => it.AddFieldName("group");
        
        public static Partial<M2SharedChannelContent> WithAccess(this Partial<M2SharedChannelContent> it)
            => it.AddFieldName("access");
        
        public static Partial<M2SharedChannelContent> WithAccess(this Partial<M2SharedChannelContent> it, Func<Partial<M2Access>, Partial<M2Access>> partialBuilder)
            => it.AddFieldName("access", partialBuilder(new Partial<M2Access>(it)));
        
        public static Partial<M2SharedChannelContent> WithDescription(this Partial<M2SharedChannelContent> it)
            => it.AddFieldName("description");
        
        public static Partial<M2SharedChannelContent> WithIconId(this Partial<M2SharedChannelContent> it)
            => it.AddFieldName("iconId");
        
        public static Partial<M2SharedChannelContent> WithNotificationDefaults(this Partial<M2SharedChannelContent> it)
            => it.AddFieldName("notificationDefaults");
        
        public static Partial<M2SharedChannelContent> WithNotificationDefaults(this Partial<M2SharedChannelContent> it, Func<Partial<ChannelSpecificDefaults>, Partial<ChannelSpecificDefaults>> partialBuilder)
            => it.AddFieldName("notificationDefaults", partialBuilder(new Partial<ChannelSpecificDefaults>(it)));
        
        public static Partial<M2SharedChannelContent> WithTeams(this Partial<M2SharedChannelContent> it)
            => it.AddFieldName("teams");
        
        public static Partial<M2SharedChannelContent> WithTeams(this Partial<M2SharedChannelContent> it, Func<Partial<TDTeam>, Partial<TDTeam>> partialBuilder)
            => it.AddFieldName("teams", partialBuilder(new Partial<TDTeam>(it)));
        
        public static Partial<M2SharedChannelContent> WithCanEdit(this Partial<M2SharedChannelContent> it)
            => it.AddFieldName("canEdit");
        
    }
    
}
