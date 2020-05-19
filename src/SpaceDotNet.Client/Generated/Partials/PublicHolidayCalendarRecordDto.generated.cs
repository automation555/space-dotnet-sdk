// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

#nullable enable

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using SpaceDotNet.Client.Internal;
using SpaceDotNet.Common;
using SpaceDotNet.Common.Json.Serialization;
using SpaceDotNet.Common.Types;

namespace SpaceDotNet.Client.PublicHolidayCalendarRecordExtensions
{
    public static class PublicHolidayCalendarRecordDtoPartialExtensions
    {
        public static Partial<PublicHolidayCalendarRecordDto> WithId(this Partial<PublicHolidayCalendarRecordDto> it)
            => it.AddFieldName("id");
        
        public static Partial<PublicHolidayCalendarRecordDto> WithArchived(this Partial<PublicHolidayCalendarRecordDto> it)
            => it.AddFieldName("archived");
        
        public static Partial<PublicHolidayCalendarRecordDto> WithName(this Partial<PublicHolidayCalendarRecordDto> it)
            => it.AddFieldName("name");
        
        public static Partial<PublicHolidayCalendarRecordDto> WithFirstDate(this Partial<PublicHolidayCalendarRecordDto> it)
            => it.AddFieldName("firstDate");
        
        public static Partial<PublicHolidayCalendarRecordDto> WithLastDate(this Partial<PublicHolidayCalendarRecordDto> it)
            => it.AddFieldName("lastDate");
        
        public static Partial<PublicHolidayCalendarRecordDto> WithEventsCount(this Partial<PublicHolidayCalendarRecordDto> it)
            => it.AddFieldName("eventsCount");
        
        public static Partial<PublicHolidayCalendarRecordDto> WithLocation(this Partial<PublicHolidayCalendarRecordDto> it)
            => it.AddFieldName("location");
        
        public static Partial<PublicHolidayCalendarRecordDto> WithLocation(this Partial<PublicHolidayCalendarRecordDto> it, Func<Partial<TDLocationDto>, Partial<TDLocationDto>> partialBuilder)
            => it.AddFieldName("location", partialBuilder(new Partial<TDLocationDto>()));
        
    }
    
}
