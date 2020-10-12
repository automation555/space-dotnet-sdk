// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

#nullable enable
#pragma warning disable CS0108

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using SpaceDotNet.Client.Internal;
using SpaceDotNet.Common;
using SpaceDotNet.Common.Json.Serialization;
using SpaceDotNet.Common.Json.Serialization.Polymorphism;
using SpaceDotNet.Common.Types;

namespace SpaceDotNet.Client.M2ChatReaderPartialBuilder
{
    public static class M2ChatReaderPartialExtensions
    {
        public static Partial<M2ChatReader> WithId(this Partial<M2ChatReader> it)
            => it.AddFieldName("id");
        
        public static Partial<M2ChatReader> WithUnreadCounter(this Partial<M2ChatReader> it)
            => it.AddFieldName("unreadCounter");
        
        public static Partial<M2ChatReader> WithReadTime(this Partial<M2ChatReader> it)
            => it.AddFieldName("readTime");
        
        public static Partial<M2ChatReader> WithIsHasUnread(this Partial<M2ChatReader> it)
            => it.AddFieldName("hasUnread");
        
        public static Partial<M2ChatReader> WithContact(this Partial<M2ChatReader> it)
            => it.AddFieldName("contact");
        
        public static Partial<M2ChatReader> WithContact(this Partial<M2ChatReader> it, Func<Partial<M2ChannelContact>, Partial<M2ChannelContact>> partialBuilder)
            => it.AddFieldName("contact", partialBuilder(new Partial<M2ChannelContact>(it)));
        
        public static Partial<M2ChatReader> WithLastMessage(this Partial<M2ChatReader> it)
            => it.AddFieldName("lastMessage");
        
        public static Partial<M2ChatReader> WithLastMessage(this Partial<M2ChatReader> it, Func<Partial<MessageInfo>, Partial<MessageInfo>> partialBuilder)
            => it.AddFieldName("lastMessage", partialBuilder(new Partial<MessageInfo>(it)));
        
        public static Partial<M2ChatReader> WithTotalMessages(this Partial<M2ChatReader> it)
            => it.AddFieldName("totalMessages");
        
        public static Partial<M2ChatReader> WithAuthors(this Partial<M2ChatReader> it)
            => it.AddFieldName("authors");
        
        public static Partial<M2ChatReader> WithAuthors(this Partial<M2ChatReader> it, Func<Partial<TDMemberProfile>, Partial<TDMemberProfile>> partialBuilder)
            => it.AddFieldName("authors", partialBuilder(new Partial<TDMemberProfile>(it)));
        
        public static Partial<M2ChatReader> WithIsArchived(this Partial<M2ChatReader> it)
            => it.AddFieldName("archived");
        
        public static Partial<M2ChatReader> WithIsGoto(this Partial<M2ChatReader> it)
            => it.AddFieldName("goto");
        
        public static Partial<M2ChatReader> WithIsPinned(this Partial<M2ChatReader> it)
            => it.AddFieldName("pinned");
        
        public static Partial<M2ChatReader> WithIsHidden(this Partial<M2ChatReader> it)
            => it.AddFieldName("hidden");
        
        public static Partial<M2ChatReader> WithPinnedPrevChannelId(this Partial<M2ChatReader> it)
            => it.AddFieldName("pinnedPrevChannelId");
        
        public static Partial<M2ChatReader> WithSubscribedSince(this Partial<M2ChatReader> it)
            => it.AddFieldName("subscribedSince");
        
        public static Partial<M2ChatReader> WithIsSubscribed(this Partial<M2ChatReader> it)
            => it.AddFieldName("subscribed");
        
        public static Partial<M2ChatReader> WithParentChannelId(this Partial<M2ChatReader> it)
            => it.AddFieldName("parentChannelId");
        
    }
    
}
