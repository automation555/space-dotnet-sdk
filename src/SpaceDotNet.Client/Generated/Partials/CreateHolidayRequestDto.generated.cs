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

namespace SpaceDotNet.Client.CreateHolidayRequestExtensions
{
    public static class CreateHolidayRequestDtoPartialExtensions
    {
        public static Partial<CreateHolidayRequestDto> WithCalendar(this Partial<CreateHolidayRequestDto> it)
            => it.AddFieldName("calendar");
        
        public static Partial<CreateHolidayRequestDto> WithName(this Partial<CreateHolidayRequestDto> it)
            => it.AddFieldName("name");
        
        public static Partial<CreateHolidayRequestDto> WithDate(this Partial<CreateHolidayRequestDto> it)
            => it.AddFieldName("date");
        
        public static Partial<CreateHolidayRequestDto> WithWorkingDay(this Partial<CreateHolidayRequestDto> it)
            => it.AddFieldName("workingDay");
        
    }
    
}
