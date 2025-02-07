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

namespace JetBrains.Space.Client.M2ChannelContactThreadPartialBuilder;

public static class M2ChannelContactThreadPartialExtensions
{
    public static Partial<M2ChannelContactThread> WithParent(this Partial<M2ChannelContactThread> it)
        => it.AddFieldName("parent");
    
    public static Partial<M2ChannelContactThread> WithParent(this Partial<M2ChannelContactThread> it, Func<Partial<M2ChannelRecord>, Partial<M2ChannelRecord>> partialBuilder)
        => it.AddFieldName("parent", partialBuilder(new Partial<M2ChannelRecord>(it)));
    
    public static Partial<M2ChannelContactThread> WithText(this Partial<M2ChannelContactThread> it)
        => it.AddFieldName("text");
    
    public static Partial<M2ChannelContactThread> WithMessageId(this Partial<M2ChannelContactThread> it)
        => it.AddFieldName("messageId");
    
    public static Partial<M2ChannelContactThread> WithAuthor(this Partial<M2ChannelContactThread> it)
        => it.AddFieldName("author");
    
    public static Partial<M2ChannelContactThread> WithAuthor(this Partial<M2ChannelContactThread> it, Func<Partial<TDMemberProfile>, Partial<TDMemberProfile>> partialBuilder)
        => it.AddFieldName("author", partialBuilder(new Partial<TDMemberProfile>(it)));
    
    public static Partial<M2ChannelContactThread> WithMessageAuthor(this Partial<M2ChannelContactThread> it)
        => it.AddFieldName("messageAuthor");
    
    public static Partial<M2ChannelContactThread> WithMessageAuthor(this Partial<M2ChannelContactThread> it, Func<Partial<CPrincipal>, Partial<CPrincipal>> partialBuilder)
        => it.AddFieldName("messageAuthor", partialBuilder(new Partial<CPrincipal>(it)));
    
    public static Partial<M2ChannelContactThread> WithAttachments(this Partial<M2ChannelContactThread> it)
        => it.AddFieldName("attachments");
    
}

