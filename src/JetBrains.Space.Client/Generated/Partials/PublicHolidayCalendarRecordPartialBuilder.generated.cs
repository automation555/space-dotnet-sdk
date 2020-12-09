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

namespace JetBrains.Space.Client.PublicHolidayCalendarRecordPartialBuilder
{
    public static class PublicHolidayCalendarRecordPartialExtensions
    {
        public static Partial<PublicHolidayCalendarRecord> WithId(this Partial<PublicHolidayCalendarRecord> it)
            => it.AddFieldName("id");
        
        public static Partial<PublicHolidayCalendarRecord> WithIsArchived(this Partial<PublicHolidayCalendarRecord> it)
            => it.AddFieldName("archived");
        
        public static Partial<PublicHolidayCalendarRecord> WithName(this Partial<PublicHolidayCalendarRecord> it)
            => it.AddFieldName("name");
        
        public static Partial<PublicHolidayCalendarRecord> WithFirstDate(this Partial<PublicHolidayCalendarRecord> it)
            => it.AddFieldName("firstDate");
        
        public static Partial<PublicHolidayCalendarRecord> WithLastDate(this Partial<PublicHolidayCalendarRecord> it)
            => it.AddFieldName("lastDate");
        
        public static Partial<PublicHolidayCalendarRecord> WithEventsCount(this Partial<PublicHolidayCalendarRecord> it)
            => it.AddFieldName("eventsCount");
        
        public static Partial<PublicHolidayCalendarRecord> WithLocation(this Partial<PublicHolidayCalendarRecord> it)
            => it.AddFieldName("location");
        
        public static Partial<PublicHolidayCalendarRecord> WithLocation(this Partial<PublicHolidayCalendarRecord> it, Func<Partial<TDLocation>, Partial<TDLocation>> partialBuilder)
            => it.AddFieldName("location", partialBuilder(new Partial<TDLocation>(it)));
        
    }
    
}
