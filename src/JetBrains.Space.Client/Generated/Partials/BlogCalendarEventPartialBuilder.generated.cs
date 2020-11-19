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
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Space.Client.Internal;
using JetBrains.Space.Common;
using JetBrains.Space.Common.Json.Serialization;
using JetBrains.Space.Common.Json.Serialization.Polymorphism;
using JetBrains.Space.Common.Types;

namespace JetBrains.Space.Client.BlogCalendarEventPartialBuilder
{
    public static class BlogCalendarEventPartialExtensions
    {
        public static Partial<BlogCalendarEvent> WithStarts(this Partial<BlogCalendarEvent> it)
            => it.AddFieldName("starts");
        
        public static Partial<BlogCalendarEvent> WithEnds(this Partial<BlogCalendarEvent> it)
            => it.AddFieldName("ends");
        
        public static Partial<BlogCalendarEvent> WithTimezone(this Partial<BlogCalendarEvent> it)
            => it.AddFieldName("timezone");
        
        public static Partial<BlogCalendarEvent> WithTimezone(this Partial<BlogCalendarEvent> it, Func<Partial<ATimeZone>, Partial<ATimeZone>> partialBuilder)
            => it.AddFieldName("timezone", partialBuilder(new Partial<ATimeZone>(it)));
        
        public static Partial<BlogCalendarEvent> WithRooms(this Partial<BlogCalendarEvent> it)
            => it.AddFieldName("rooms");
        
        public static Partial<BlogCalendarEvent> WithIsAllDay(this Partial<BlogCalendarEvent> it)
            => it.AddFieldName("allDay");
        
    }
    
}
