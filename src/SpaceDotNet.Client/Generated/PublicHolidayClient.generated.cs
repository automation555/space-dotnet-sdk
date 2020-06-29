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

namespace SpaceDotNet.Client
{
    public partial class PublicHolidayClient
    {
        private readonly Connection _connection;
        
        public PublicHolidayClient(Connection connection)
        {
            _connection = connection;
        }
        
        public CalendarClient Calendars => new CalendarClient(_connection);
        
        public partial class CalendarClient
        {
            private readonly Connection _connection;
            
            public CalendarClient(Connection connection)
            {
                _connection = connection;
            }
            
            /// <summary>
            /// Create a public holiday calendar for a location.
            /// </summary>
            public async Task<PublicHolidayCalendarRecordDto> CreateCalendarAsync(string name, string location, Func<Partial<PublicHolidayCalendarRecordDto>, Partial<PublicHolidayCalendarRecordDto>>? partial = null)
                => await _connection.RequestResourceAsync<PublicHolidaysCalendarsRequest, PublicHolidayCalendarRecordDto>("POST", $"api/http/public-holidays/calendars?$fields={(partial != null ? partial(new Partial<PublicHolidayCalendarRecordDto>()) : Partial<PublicHolidayCalendarRecordDto>.Default())}", new PublicHolidaysCalendarsRequest{ Name = name, Location = location });
        
            /// <summary>
            /// Import holidays in a public holiday calendar, using an attachment (.ics format) as the source.
            /// </summary>
            public async Task<string> ImportAsync(string calendar, string attachmentId)
                => await _connection.RequestResourceAsync<PublicHolidaysCalendarsImportRequest, string>("POST", $"api/http/public-holidays/calendars/import", new PublicHolidaysCalendarsImportRequest{ Calendar = calendar, AttachmentId = attachmentId });
        
            /// <summary>
            /// Get all public holiday calendars.
            /// </summary>
            public async Task<Batch<PublicHolidayCalendarRecordDto>> GetAllCalendarsAsync(string? skip = null, int? top = null, Func<Partial<Batch<PublicHolidayCalendarRecordDto>>, Partial<Batch<PublicHolidayCalendarRecordDto>>>? partial = null)
                => await _connection.RequestResourceAsync<Batch<PublicHolidayCalendarRecordDto>>("GET", $"api/http/public-holidays/calendars?$skip={skip?.ToString() ?? "null"}&$top={top?.ToString() ?? "null"}&$fields={(partial != null ? partial(new Partial<Batch<PublicHolidayCalendarRecordDto>>()) : Partial<Batch<PublicHolidayCalendarRecordDto>>.Default())}");
            
            /// <summary>
            /// Get all public holiday calendars.
            /// </summary>
            public IAsyncEnumerable<PublicHolidayCalendarRecordDto> GetAllCalendarsAsyncEnumerable(string? skip = null, int? top = null, Func<Partial<PublicHolidayCalendarRecordDto>, Partial<PublicHolidayCalendarRecordDto>>? partial = null)
                => BatchEnumerator.AllItems(batchSkip => GetAllCalendarsAsync(top: top, skip: batchSkip, partial: builder => Partial<Batch<PublicHolidayCalendarRecordDto>>.Default().WithNext().WithTotalCount().WithData(partial != null ? partial : _ => Partial<PublicHolidayCalendarRecordDto>.Default())), skip);
        
            /// <summary>
            /// Update an existing public holiday calendar.
            /// </summary>
            public async Task<PublicHolidayCalendarRecordDto> UpdateCalendarAsync(string id, string name, string location, Func<Partial<PublicHolidayCalendarRecordDto>, Partial<PublicHolidayCalendarRecordDto>>? partial = null)
                => await _connection.RequestResourceAsync<PublicHolidaysCalendarsForIdRequest, PublicHolidayCalendarRecordDto>("PATCH", $"api/http/public-holidays/calendars/{id}?$fields={(partial != null ? partial(new Partial<PublicHolidayCalendarRecordDto>()) : Partial<PublicHolidayCalendarRecordDto>.Default())}", new PublicHolidaysCalendarsForIdRequest{ Name = name, Location = location });
        
            /// <summary>
            /// Delete 
            /// </summary>
            public async Task DeleteCalendarAsync(string id)
                => await _connection.RequestResourceAsync("DELETE", $"api/http/public-holidays/calendars/{id}");
        
        }
    
        public HolidayClient Holidays => new HolidayClient(_connection);
        
        public partial class HolidayClient
        {
            private readonly Connection _connection;
            
            public HolidayClient(Connection connection)
            {
                _connection = connection;
            }
            
            /// <summary>
            /// Add a holiday to a public holiday calendar, and specify if it is a working day or not.
            /// </summary>
            public async Task<PublicHolidayDto> CreateHolidayAsync(string calendar, string name, SpaceDate date, bool workingDay, Func<Partial<PublicHolidayDto>, Partial<PublicHolidayDto>>? partial = null)
                => await _connection.RequestResourceAsync<PublicHolidaysHolidaysRequest, PublicHolidayDto>("POST", $"api/http/public-holidays/holidays?$fields={(partial != null ? partial(new Partial<PublicHolidayDto>()) : Partial<PublicHolidayDto>.Default())}", new PublicHolidaysHolidaysRequest{ Calendar = calendar, Name = name, Date = date, WorkingDay = workingDay });
        
            /// <summary>
            /// Get/search all holidays in a public holiday calendar. Parameters are applied as 'AND' filters.
            /// </summary>
            public async Task<Batch<PublicHolidayDto>> GetAllHolidaysAsync(string? skip = null, int? top = null, string? calendar = null, string? location = null, SpaceDate? startDate = null, SpaceDate? endDate = null, Func<Partial<Batch<PublicHolidayDto>>, Partial<Batch<PublicHolidayDto>>>? partial = null)
                => await _connection.RequestResourceAsync<Batch<PublicHolidayDto>>("GET", $"api/http/public-holidays/holidays?$skip={skip?.ToString() ?? "null"}&$top={top?.ToString() ?? "null"}&calendar={calendar?.ToString() ?? "null"}&location={location?.ToString() ?? "null"}&startDate={startDate?.ToString() ?? "null"}&endDate={endDate?.ToString() ?? "null"}&$fields={(partial != null ? partial(new Partial<Batch<PublicHolidayDto>>()) : Partial<Batch<PublicHolidayDto>>.Default())}");
            
            /// <summary>
            /// Get/search all holidays in a public holiday calendar. Parameters are applied as 'AND' filters.
            /// </summary>
            public IAsyncEnumerable<PublicHolidayDto> GetAllHolidaysAsyncEnumerable(string? skip = null, int? top = null, string? calendar = null, string? location = null, SpaceDate? startDate = null, SpaceDate? endDate = null, Func<Partial<PublicHolidayDto>, Partial<PublicHolidayDto>>? partial = null)
                => BatchEnumerator.AllItems(batchSkip => GetAllHolidaysAsync(top: top, calendar: calendar, location: location, startDate: startDate, endDate: endDate, skip: batchSkip, partial: builder => Partial<Batch<PublicHolidayDto>>.Default().WithNext().WithTotalCount().WithData(partial != null ? partial : _ => Partial<PublicHolidayDto>.Default())), skip);
        
            /// <summary>
            /// Update a holiday in a public holiday calendar. Optional parameters will be ignored when not specified, and updated otherwise.
            /// </summary>
            public async Task<PublicHolidayDto> UpdateHolidayAsync(string id, string? calendar = null, string? name = null, SpaceDate? date = null, bool? workingDay = null, Func<Partial<PublicHolidayDto>, Partial<PublicHolidayDto>>? partial = null)
                => await _connection.RequestResourceAsync<PublicHolidaysHolidaysForIdRequest, PublicHolidayDto>("PATCH", $"api/http/public-holidays/holidays/{id}?$fields={(partial != null ? partial(new Partial<PublicHolidayDto>()) : Partial<PublicHolidayDto>.Default())}", new PublicHolidaysHolidaysForIdRequest{ Calendar = calendar, Name = name, Date = date, WorkingDay = workingDay });
        
            /// <summary>
            /// Delete a holiday from a public holiday calendar.
            /// </summary>
            public async Task DeleteHolidayAsync(string id)
                => await _connection.RequestResourceAsync("DELETE", $"api/http/public-holidays/holidays/{id}");
        
            public ProfileHolidayClient ProfileHolidays => new ProfileHolidayClient(_connection);
            
            public partial class ProfileHolidayClient
            {
                private readonly Connection _connection;
                
                public ProfileHolidayClient(Connection connection)
                {
                    _connection = connection;
                }
                
                /// <summary>
                /// Get holidays observed in the location(s) of the current profile during the selected period.
                /// </summary>
                public async Task<List<PublicHolidayDto>> GetAllProfileHolidaysAsync(SpaceDate startDate, SpaceDate endDate, string profile, bool? workingDays = null, Func<Partial<PublicHolidayDto>, Partial<PublicHolidayDto>>? partial = null)
                    => await _connection.RequestResourceAsync<List<PublicHolidayDto>>("GET", $"api/http/public-holidays/holidays/profile-holidays?startDate={startDate.ToString()}&endDate={endDate.ToString()}&profile={profile.ToString()}&workingDays={workingDays?.ToString()?.ToLowerInvariant() ?? "null"}&$fields={(partial != null ? partial(new Partial<PublicHolidayDto>()) : Partial<PublicHolidayDto>.Default())}");
            
            }
        
            public RelatedHolidayClient RelatedHolidays => new RelatedHolidayClient(_connection);
            
            public partial class RelatedHolidayClient
            {
                private readonly Connection _connection;
                
                public RelatedHolidayClient(Connection connection)
                {
                    _connection = connection;
                }
                
                /// <summary>
                /// Search related holidays in all public holiday calendars, during the selected period.
                /// </summary>
                public async Task<Batch<PublicHolidayDto>> GetAllRelatedHolidaysAsync(string? skip = null, int? top = null, SpaceDate? startDate = null, SpaceDate? endDate = null, Func<Partial<Batch<PublicHolidayDto>>, Partial<Batch<PublicHolidayDto>>>? partial = null)
                    => await _connection.RequestResourceAsync<Batch<PublicHolidayDto>>("GET", $"api/http/public-holidays/holidays/related-holidays?$skip={skip?.ToString() ?? "null"}&$top={top?.ToString() ?? "null"}&startDate={startDate?.ToString() ?? "null"}&endDate={endDate?.ToString() ?? "null"}&$fields={(partial != null ? partial(new Partial<Batch<PublicHolidayDto>>()) : Partial<Batch<PublicHolidayDto>>.Default())}");
                
                /// <summary>
                /// Search related holidays in all public holiday calendars, during the selected period.
                /// </summary>
                public IAsyncEnumerable<PublicHolidayDto> GetAllRelatedHolidaysAsyncEnumerable(string? skip = null, int? top = null, SpaceDate? startDate = null, SpaceDate? endDate = null, Func<Partial<PublicHolidayDto>, Partial<PublicHolidayDto>>? partial = null)
                    => BatchEnumerator.AllItems(batchSkip => GetAllRelatedHolidaysAsync(top: top, startDate: startDate, endDate: endDate, skip: batchSkip, partial: builder => Partial<Batch<PublicHolidayDto>>.Default().WithNext().WithTotalCount().WithData(partial != null ? partial : _ => Partial<PublicHolidayDto>.Default())), skip);
            
            }
        
        }
    
    }
    
}
