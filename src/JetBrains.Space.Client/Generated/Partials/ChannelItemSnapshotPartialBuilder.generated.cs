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

namespace JetBrains.Space.Client.ChannelItemSnapshotPartialBuilder;

public static class ChannelItemSnapshotPartialExtensions
{
    public static Partial<ChannelItemSnapshot> WithId(this Partial<ChannelItemSnapshot> it)
        => it.AddFieldName("id");
    
    public static Partial<ChannelItemSnapshot> WithChannelId(this Partial<ChannelItemSnapshot> it)
        => it.AddFieldName("channelId");
    
    public static Partial<ChannelItemSnapshot> WithText(this Partial<ChannelItemSnapshot> it)
        => it.AddFieldName("text");
    
    public static Partial<ChannelItemSnapshot> WithDetails(this Partial<ChannelItemSnapshot> it)
        => it.AddFieldName("details");
    
    public static Partial<ChannelItemSnapshot> WithDetails(this Partial<ChannelItemSnapshot> it, Func<Partial<M2ItemContentDetails>, Partial<M2ItemContentDetails>> partialBuilder)
        => it.AddFieldName("details", partialBuilder(new Partial<M2ItemContentDetails>(it)));
    
    public static Partial<ChannelItemSnapshot> WithAuthor(this Partial<ChannelItemSnapshot> it)
        => it.AddFieldName("author");
    
    public static Partial<ChannelItemSnapshot> WithAuthor(this Partial<ChannelItemSnapshot> it, Func<Partial<CPrincipal>, Partial<CPrincipal>> partialBuilder)
        => it.AddFieldName("author", partialBuilder(new Partial<CPrincipal>(it)));
    
    public static Partial<ChannelItemSnapshot> WithCreated(this Partial<ChannelItemSnapshot> it)
        => it.AddFieldName("created");
    
    public static Partial<ChannelItemSnapshot> WithTime(this Partial<ChannelItemSnapshot> it)
        => it.AddFieldName("time");
    
    public static Partial<ChannelItemSnapshot> WithAttachments(this Partial<ChannelItemSnapshot> it)
        => it.AddFieldName("attachments");
    
    public static Partial<ChannelItemSnapshot> WithAttachments(this Partial<ChannelItemSnapshot> it, Func<Partial<AttachmentInfo>, Partial<AttachmentInfo>> partialBuilder)
        => it.AddFieldName("attachments", partialBuilder(new Partial<AttachmentInfo>(it)));
    
}

