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

namespace JetBrains.Space.Client.ChatMessageBlockPartialBuilder;

public static class ChatMessageBlockPartialExtensions
{
    public static Partial<ChatMessageBlock> WithStyle(this Partial<ChatMessageBlock> it)
        => it.AddFieldName("style");
    
    public static Partial<ChatMessageBlock> WithStyle(this Partial<ChatMessageBlock> it, Func<Partial<MessageStyle>, Partial<MessageStyle>> partialBuilder)
        => it.AddFieldName("style", partialBuilder(new Partial<MessageStyle>(it)));
    
    public static Partial<ChatMessageBlock> WithOutline(this Partial<ChatMessageBlock> it)
        => it.AddFieldName("outline");
    
    public static Partial<ChatMessageBlock> WithOutline(this Partial<ChatMessageBlock> it, Func<Partial<MessageOutline>, Partial<MessageOutline>> partialBuilder)
        => it.AddFieldName("outline", partialBuilder(new Partial<MessageOutline>(it)));
    
    public static Partial<ChatMessageBlock> WithSections(this Partial<ChatMessageBlock> it)
        => it.AddFieldName("sections");
    
    public static Partial<ChatMessageBlock> WithSections(this Partial<ChatMessageBlock> it, Func<Partial<MessageSectionElement>, Partial<MessageSectionElement>> partialBuilder)
        => it.AddFieldName("sections", partialBuilder(new Partial<MessageSectionElement>(it)));
    
    public static Partial<ChatMessageBlock> WithMessageData(this Partial<ChatMessageBlock> it)
        => it.AddFieldName("messageData");
    
}

