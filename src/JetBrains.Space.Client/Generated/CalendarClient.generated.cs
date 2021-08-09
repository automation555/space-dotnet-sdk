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

namespace JetBrains.Space.Client
{
    public partial class CalendarClient : ISpaceClient
    {
        private readonly Connection _connection;
        
        public CalendarClient(Connection connection)
        {
            _connection = connection;
        }
        
        public AbsenceEventClient AbsenceEvents => new AbsenceEventClient(_connection);
        
        public partial class AbsenceEventClient : ISpaceClient
        {
            private readonly Connection _connection;
            
            public AbsenceEventClient(Connection connection)
            {
                _connection = connection;
            }
            
            /// <summary>
            /// Get/search absences. Parameters are applied as 'AND' filters.
            /// </summary>
            public async Task<List<AbsenceEvent>> GetAllAbsenceEventsAsync(DateTime dateFrom, DateTime dateTo, string? team = null, string? location = null, string? role = null, Func<Partial<AbsenceEvent>, Partial<AbsenceEvent>>? partial = null, CancellationToken cancellationToken = default)
            {
                var queryParameters = new NameValueCollection();
                queryParameters.Append("dateFrom", dateFrom.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture));
                queryParameters.Append("dateTo", dateTo.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture));
                if (team != null) queryParameters.Append("team", team);
                if (location != null) queryParameters.Append("location", location);
                if (role != null) queryParameters.Append("role", role);
                queryParameters.Append("$fields", (partial != null ? partial(new Partial<AbsenceEvent>()) : Partial<AbsenceEvent>.Default()).ToString());
                
                return await _connection.RequestResourceAsync<List<AbsenceEvent>>("GET", $"api/http/calendars/absence-events{queryParameters.ToQueryString()}", cancellationToken);
            }
            
        
        }
    
        public BirthdayEventClient BirthdayEvents => new BirthdayEventClient(_connection);
        
        public partial class BirthdayEventClient : ISpaceClient
        {
            private readonly Connection _connection;
            
            public BirthdayEventClient(Connection connection)
            {
                _connection = connection;
            }
            
            /// <summary>
            /// Get/search birthdays. Parameters are applied as 'AND' filters.
            /// </summary>
            public async Task<List<BirthdayEvent>> GetAllBirthdayEventsAsync(DateTime dateFrom, DateTime dateTo, string? team = null, string? location = null, string? role = null, Func<Partial<BirthdayEvent>, Partial<BirthdayEvent>>? partial = null, CancellationToken cancellationToken = default)
            {
                var queryParameters = new NameValueCollection();
                queryParameters.Append("dateFrom", dateFrom.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture));
                queryParameters.Append("dateTo", dateTo.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture));
                if (team != null) queryParameters.Append("team", team);
                if (location != null) queryParameters.Append("location", location);
                if (role != null) queryParameters.Append("role", role);
                queryParameters.Append("$fields", (partial != null ? partial(new Partial<BirthdayEvent>()) : Partial<BirthdayEvent>.Default()).ToString());
                
                return await _connection.RequestResourceAsync<List<BirthdayEvent>>("GET", $"api/http/calendars/birthday-events{queryParameters.ToQueryString()}", cancellationToken);
            }
            
        
            public StarredClient Starred => new StarredClient(_connection);
            
            public partial class StarredClient : ISpaceClient
            {
                private readonly Connection _connection;
                
                public StarredClient(Connection connection)
                {
                    _connection = connection;
                }
                
                /// <summary>
                /// Get/search birthdays in a specific time period for starred profiles.
                /// </summary>
                public async Task<List<BirthdayEvent>> GetAllStarredBirthdayEventsAsync(DateTime dateFrom, DateTime dateTo, Func<Partial<BirthdayEvent>, Partial<BirthdayEvent>>? partial = null, CancellationToken cancellationToken = default)
                {
                    var queryParameters = new NameValueCollection();
                    queryParameters.Append("dateFrom", dateFrom.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture));
                    queryParameters.Append("dateTo", dateTo.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture));
                    queryParameters.Append("$fields", (partial != null ? partial(new Partial<BirthdayEvent>()) : Partial<BirthdayEvent>.Default()).ToString());
                    
                    return await _connection.RequestResourceAsync<List<BirthdayEvent>>("GET", $"api/http/calendars/birthday-events/starred{queryParameters.ToQueryString()}", cancellationToken);
                }
                
            
            }
        
        }
    
        public EventParticipationClient EventParticipations => new EventParticipationClient(_connection);
        
        public partial class EventParticipationClient : ISpaceClient
        {
            private readonly Connection _connection;
            
            public EventParticipationClient(Connection connection)
            {
                _connection = connection;
            }
            
            /// <summary>
            /// Update RSVP / calendar event participation status for a calendar event attached to an article
            /// </summary>
            public async Task<MeetingRecord> UpdateEventParticipationAsync(string id, EventParticipationStatus newStatus, Func<Partial<MeetingRecord>, Partial<MeetingRecord>>? partial = null, CancellationToken cancellationToken = default)
            {
                var queryParameters = new NameValueCollection();
                queryParameters.Append("$fields", (partial != null ? partial(new Partial<MeetingRecord>()) : Partial<MeetingRecord>.Default()).ToString());
                
                return await _connection.RequestResourceAsync<CalendarsEventParticipationsForIdPatchRequest, MeetingRecord>("PATCH", $"api/http/calendars/event-participations/{id}{queryParameters.ToQueryString()}", 
                    new CalendarsEventParticipationsForIdPatchRequest
                    { 
                        NewStatus = newStatus,
                    }, cancellationToken);
            }
            
        
        }
    
        public EventClient Events => new EventClient(_connection);
        
        public partial class EventClient : ISpaceClient
        {
            private readonly Connection _connection;
            
            public EventClient(Connection connection)
            {
                _connection = connection;
            }
            
            /// <summary>
            /// Get calendar events attached to an article in a specific time period
            /// </summary>
            public async Task<List<MeetingRecord>> GetAllEventsAsync(DateTime dateFrom, DateTime dateTo, Func<Partial<MeetingRecord>, Partial<MeetingRecord>>? partial = null, CancellationToken cancellationToken = default)
            {
                var queryParameters = new NameValueCollection();
                queryParameters.Append("dateFrom", dateFrom.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture));
                queryParameters.Append("dateTo", dateTo.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture));
                queryParameters.Append("$fields", (partial != null ? partial(new Partial<MeetingRecord>()) : Partial<MeetingRecord>.Default()).ToString());
                
                return await _connection.RequestResourceAsync<List<MeetingRecord>>("GET", $"api/http/calendars/events{queryParameters.ToQueryString()}", cancellationToken);
            }
            
        
            /// <summary>
            /// Get a calendar event attached to an article
            /// </summary>
            public async Task<MeetingRecord> GetEventAsync(string id, Func<Partial<MeetingRecord>, Partial<MeetingRecord>>? partial = null, CancellationToken cancellationToken = default)
            {
                var queryParameters = new NameValueCollection();
                queryParameters.Append("$fields", (partial != null ? partial(new Partial<MeetingRecord>()) : Partial<MeetingRecord>.Default()).ToString());
                
                return await _connection.RequestResourceAsync<MeetingRecord>("GET", $"api/http/calendars/events/{id}{queryParameters.ToQueryString()}", cancellationToken);
            }
            
        
        }
    
        public HolidayClient Holidays => new HolidayClient(_connection);
        
        public partial class HolidayClient : ISpaceClient
        {
            private readonly Connection _connection;
            
            public HolidayClient(Connection connection)
            {
                _connection = connection;
            }
            
            /// <summary>
            /// Get/search holidays. Parameters are applied as 'AND' filters.
            /// </summary>
            public async Task<List<HolidaysEvent>> GetAllHolidaysAsync(DateTime startDate, DateTime endDate, string? team = null, string? location = null, string? role = null, bool? workingDays = null, Func<Partial<HolidaysEvent>, Partial<HolidaysEvent>>? partial = null, CancellationToken cancellationToken = default)
            {
                var queryParameters = new NameValueCollection();
                queryParameters.Append("startDate", startDate.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture));
                queryParameters.Append("endDate", endDate.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture));
                if (team != null) queryParameters.Append("team", team);
                if (location != null) queryParameters.Append("location", location);
                if (role != null) queryParameters.Append("role", role);
                if (workingDays != null) queryParameters.Append("workingDays", workingDays?.ToString("l"));
                queryParameters.Append("$fields", (partial != null ? partial(new Partial<HolidaysEvent>()) : Partial<HolidaysEvent>.Default()).ToString());
                
                return await _connection.RequestResourceAsync<List<HolidaysEvent>>("GET", $"api/http/calendars/holidays{queryParameters.ToQueryString()}", cancellationToken);
            }
            
        
        }
    
        public MeetingClient Meetings => new MeetingClient(_connection);
        
        public partial class MeetingClient : ISpaceClient
        {
            private readonly Connection _connection;
            
            public MeetingClient(Connection connection)
            {
                _connection = connection;
            }
            
            /// <summary>
            /// Create a meeting
            /// </summary>
            /// <remarks>
            /// Required permissions:
            /// <list type="bullet">
            /// <item>
            /// <term>Edit meetings</term>
            /// </item>
            /// </list>
            /// </remarks>
            public async Task<Meeting> CreateMeetingAsync(string summary, CalendarEventSpec occurrenceRule, List<string>? locations = null, List<string>? profiles = null, List<string>? externalParticipants = null, List<string>? teams = null, MeetingVisibility visibility = MeetingVisibility.EVERYONE, MeetingModificationPreference modificationPreference = MeetingModificationPreference.PARTICIPANTS, MeetingJoiningPreference joiningPreference = MeetingJoiningPreference.NOBODY, bool notifyOnExport = true, string? description = null, string? organizer = null, EventConferenceData? conferenceData = null, Func<Partial<Meeting>, Partial<Meeting>>? partial = null, CancellationToken cancellationToken = default)
            {
                var queryParameters = new NameValueCollection();
                queryParameters.Append("$fields", (partial != null ? partial(new Partial<Meeting>()) : Partial<Meeting>.Default()).ToString());
                
                return await _connection.RequestResourceAsync<CalendarsMeetingsPostRequest, Meeting>("POST", $"api/http/calendars/meetings{queryParameters.ToQueryString()}", 
                    new CalendarsMeetingsPostRequest
                    { 
                        Summary = summary,
                        Description = description,
                        OccurrenceRule = occurrenceRule,
                        Locations = (locations ?? new List<string>()),
                        Profiles = (profiles ?? new List<string>()),
                        ExternalParticipants = (externalParticipants ?? new List<string>()),
                        Teams = (teams ?? new List<string>()),
                        Visibility = visibility,
                        ModificationPreference = modificationPreference,
                        JoiningPreference = joiningPreference,
                        IsNotifyOnExport = notifyOnExport,
                        Organizer = organizer,
                        ConferenceData = conferenceData,
                    }, cancellationToken);
            }
            
        
            /// <summary>
            /// Search meetings by name, location, time period and other parameters. Parameters are applied as 'AND' filters while values in lists of locations, profiles and teams have 'OR' semantics.
            /// </summary>
            /// <remarks>
            /// Required permissions:
            /// <list type="bullet">
            /// <item>
            /// <term>View meetings</term>
            /// </item>
            /// </list>
            /// </remarks>
            public async Task<Batch<Meeting>> GetAllMeetingsAsync(string summaryQuery = "", List<string>? locationsQuery = null, List<string>? profiles = null, List<string>? teams = null, bool includePrivate = false, bool includeArchived = false, bool includeMeetingInstances = true, string? skip = null, int? top = 100, DateTime? startingAfter = null, DateTime? endingAfter = null, DateTime? endingBefore = null, DateTime? startingBefore = null, string? organizer = null, Func<Partial<Batch<Meeting>>, Partial<Batch<Meeting>>>? partial = null, CancellationToken cancellationToken = default)
            {
                var queryParameters = new NameValueCollection();
                if (skip != null) queryParameters.Append("$skip", skip);
                if (top != null) queryParameters.Append("$top", top?.ToString());
                queryParameters.Append("summaryQuery", summaryQuery);
                queryParameters.Append("locationsQuery", (locationsQuery ?? new List<string>()).Select(it => it));
                if (startingAfter != null) queryParameters.Append("startingAfter", startingAfter?.ToString("yyyy-MM-ddTHH:mm:ss.fffZ", CultureInfo.InvariantCulture));
                if (endingAfter != null) queryParameters.Append("endingAfter", endingAfter?.ToString("yyyy-MM-ddTHH:mm:ss.fffZ", CultureInfo.InvariantCulture));
                if (endingBefore != null) queryParameters.Append("endingBefore", endingBefore?.ToString("yyyy-MM-ddTHH:mm:ss.fffZ", CultureInfo.InvariantCulture));
                if (startingBefore != null) queryParameters.Append("startingBefore", startingBefore?.ToString("yyyy-MM-ddTHH:mm:ss.fffZ", CultureInfo.InvariantCulture));
                queryParameters.Append("profiles", (profiles ?? new List<string>()).Select(it => it));
                queryParameters.Append("teams", (teams ?? new List<string>()).Select(it => it));
                if (organizer != null) queryParameters.Append("organizer", organizer);
                queryParameters.Append("includePrivate", includePrivate.ToString("l"));
                queryParameters.Append("includeArchived", includeArchived.ToString("l"));
                queryParameters.Append("includeMeetingInstances", includeMeetingInstances.ToString("l"));
                queryParameters.Append("$fields", (partial != null ? partial(new Partial<Batch<Meeting>>()) : Partial<Batch<Meeting>>.Default()).ToString());
                
                return await _connection.RequestResourceAsync<Batch<Meeting>>("GET", $"api/http/calendars/meetings{queryParameters.ToQueryString()}", cancellationToken);
            }
            
            
            /// <summary>
            /// Search meetings by name, location, time period and other parameters. Parameters are applied as 'AND' filters while values in lists of locations, profiles and teams have 'OR' semantics.
            /// </summary>
            /// <remarks>
            /// Required permissions:
            /// <list type="bullet">
            /// <item>
            /// <term>View meetings</term>
            /// </item>
            /// </list>
            /// </remarks>
            public IAsyncEnumerable<Meeting> GetAllMeetingsAsyncEnumerable(string summaryQuery = "", List<string>? locationsQuery = null, List<string>? profiles = null, List<string>? teams = null, bool includePrivate = false, bool includeArchived = false, bool includeMeetingInstances = true, string? skip = null, int? top = 100, DateTime? startingAfter = null, DateTime? endingAfter = null, DateTime? endingBefore = null, DateTime? startingBefore = null, string? organizer = null, Func<Partial<Meeting>, Partial<Meeting>>? partial = null, CancellationToken cancellationToken = default)
                => BatchEnumerator.AllItems((batchSkip, batchCancellationToken) => GetAllMeetingsAsync(summaryQuery: summaryQuery, locationsQuery: locationsQuery, profiles: profiles, teams: teams, includePrivate: includePrivate, includeArchived: includeArchived, includeMeetingInstances: includeMeetingInstances, top: top, startingAfter: startingAfter, endingAfter: endingAfter, endingBefore: endingBefore, startingBefore: startingBefore, organizer: organizer, cancellationToken: cancellationToken, skip: batchSkip, partial: builder => Partial<Batch<Meeting>>.Default().WithNext().WithTotalCount().WithData(partial != null ? partial : _ => Partial<Meeting>.Default())), skip, cancellationToken);
        
            /// <summary>
            /// Search for the next meeting occurrence that starts after the provided time point or after the current time if it is not specified
            /// </summary>
            /// <remarks>
            /// Required permissions:
            /// <list type="bullet">
            /// <item>
            /// <term>View meetings</term>
            /// </item>
            /// </list>
            /// </remarks>
            public async Task<MeetingOccurrenceTime> GetNextMeetingOccurrenceAsync(string meetingId, DateTime? since = null, Func<Partial<MeetingOccurrenceTime>, Partial<MeetingOccurrenceTime>>? partial = null, CancellationToken cancellationToken = default)
            {
                var queryParameters = new NameValueCollection();
                queryParameters.Append("meetingId", meetingId);
                if (since != null) queryParameters.Append("since", since?.ToString("yyyy-MM-ddTHH:mm:ss.fffZ", CultureInfo.InvariantCulture));
                queryParameters.Append("$fields", (partial != null ? partial(new Partial<MeetingOccurrenceTime>()) : Partial<MeetingOccurrenceTime>.Default()).ToString());
                
                return await _connection.RequestResourceAsync<MeetingOccurrenceTime>("GET", $"api/http/calendars/meetings/next-occurrence{queryParameters.ToQueryString()}", cancellationToken);
            }
            
        
            /// <summary>
            /// Search for occurrences of a meeting that start in the provided time interval. Interval limits are inclusive, response is limited by the first 1_000 results by default.
            /// </summary>
            /// <remarks>
            /// Required permissions:
            /// <list type="bullet">
            /// <item>
            /// <term>View meetings</term>
            /// </item>
            /// </list>
            /// </remarks>
            public async Task<List<MeetingOccurrenceTime>> GetMeetingOccurrencesForPeriodAsync(string meetingId, DateTime since, DateTime until, int? limit = null, Func<Partial<MeetingOccurrenceTime>, Partial<MeetingOccurrenceTime>>? partial = null, CancellationToken cancellationToken = default)
            {
                var queryParameters = new NameValueCollection();
                queryParameters.Append("meetingId", meetingId);
                queryParameters.Append("since", since.ToString("yyyy-MM-ddTHH:mm:ss.fffZ", CultureInfo.InvariantCulture));
                queryParameters.Append("until", until.ToString("yyyy-MM-ddTHH:mm:ss.fffZ", CultureInfo.InvariantCulture));
                if (limit != null) queryParameters.Append("limit", limit?.ToString());
                queryParameters.Append("$fields", (partial != null ? partial(new Partial<MeetingOccurrenceTime>()) : Partial<MeetingOccurrenceTime>.Default()).ToString());
                
                return await _connection.RequestResourceAsync<List<MeetingOccurrenceTime>>("GET", $"api/http/calendars/meetings/occurrences{queryParameters.ToQueryString()}", cancellationToken);
            }
            
        
            /// <remarks>
            /// Required permissions:
            /// <list type="bullet">
            /// <item>
            /// <term>View meetings</term>
            /// </item>
            /// </list>
            /// </remarks>
            public async Task<List<EventParticipationStatus>> GetMeetingParticipationStatusesForProfilesAsync(string id, List<string> profileIds, Func<Partial<EventParticipationStatus>, Partial<EventParticipationStatus>>? partial = null, CancellationToken cancellationToken = default)
            {
                var queryParameters = new NameValueCollection();
                queryParameters.Append("id", id);
                queryParameters.Append("profileIds", profileIds.Select(it => it));
                queryParameters.Append("$fields", (partial != null ? partial(new Partial<EventParticipationStatus>()) : Partial<EventParticipationStatus>.Default()).ToString());
                
                return await _connection.RequestResourceAsync<List<EventParticipationStatus>>("GET", $"api/http/calendars/meetings/participation-statuses{queryParameters.ToQueryString()}", cancellationToken);
            }
            
        
            /// <remarks>
            /// Required permissions:
            /// <list type="bullet">
            /// <item>
            /// <term>View meetings</term>
            /// </item>
            /// </list>
            /// </remarks>
            public async Task<List<EventParticipationStatus>> GetRsvpStatusesForExternalUsersAsync(string id, List<string> emails, Func<Partial<EventParticipationStatus>, Partial<EventParticipationStatus>>? partial = null, CancellationToken cancellationToken = default)
            {
                var queryParameters = new NameValueCollection();
                queryParameters.Append("id", id);
                queryParameters.Append("emails", emails.Select(it => it));
                queryParameters.Append("$fields", (partial != null ? partial(new Partial<EventParticipationStatus>()) : Partial<EventParticipationStatus>.Default()).ToString());
                
                return await _connection.RequestResourceAsync<List<EventParticipationStatus>>("GET", $"api/http/calendars/meetings/participation-statuses-external{queryParameters.ToQueryString()}", cancellationToken);
            }
            
        
            /// <remarks>
            /// Required permissions:
            /// <list type="bullet">
            /// <item>
            /// <term>View meetings</term>
            /// </item>
            /// </list>
            /// </remarks>
            [Obsolete("Use 'getProfileParticipantRecords' instead (since 27.07.2021)")]
            public async Task<List<Pair<string, EventParticipationStatus>>> GetProfileParticipationStatusesForMeetingsAsync(string profileId, List<string> events, Func<Partial<Pair<string, EventParticipationStatus>>, Partial<Pair<string, EventParticipationStatus>>>? partial = null, CancellationToken cancellationToken = default)
            {
                var queryParameters = new NameValueCollection();
                queryParameters.Append("profileId", profileId);
                queryParameters.Append("events", events.Select(it => it));
                queryParameters.Append("$fields", (partial != null ? partial(new Partial<Pair<string, EventParticipationStatus>>()) : Partial<Pair<string, EventParticipationStatus>>.Default()).ToString());
                
                return await _connection.RequestResourceAsync<List<Pair<string, EventParticipationStatus>>>("GET", $"api/http/calendars/meetings/profile-participation{queryParameters.ToQueryString()}", cancellationToken);
            }
            
        
            /// <remarks>
            /// Required permissions:
            /// <list type="bullet">
            /// <item>
            /// <term>View meetings</term>
            /// </item>
            /// </list>
            /// </remarks>
            public async Task<List<MeetingRSVP>> GetProfileParticipationStatusRecordsForMeetingsAsync(string profileId, List<string> events, Func<Partial<MeetingRSVP>, Partial<MeetingRSVP>>? partial = null, CancellationToken cancellationToken = default)
            {
                var queryParameters = new NameValueCollection();
                queryParameters.Append("profileId", profileId);
                queryParameters.Append("events", events.Select(it => it));
                queryParameters.Append("$fields", (partial != null ? partial(new Partial<MeetingRSVP>()) : Partial<MeetingRSVP>.Default()).ToString());
                
                return await _connection.RequestResourceAsync<List<MeetingRSVP>>("GET", $"api/http/calendars/meetings/profile-participation-records{queryParameters.ToQueryString()}", cancellationToken);
            }
            
        
            /// <remarks>
            /// Required permissions:
            /// <list type="bullet">
            /// <item>
            /// <term>View meetings</term>
            /// </item>
            /// </list>
            /// </remarks>
            public async Task<Meeting> GetMeetingAsync(string id, Func<Partial<Meeting>, Partial<Meeting>>? partial = null, CancellationToken cancellationToken = default)
            {
                var queryParameters = new NameValueCollection();
                queryParameters.Append("$fields", (partial != null ? partial(new Partial<Meeting>()) : Partial<Meeting>.Default()).ToString());
                
                return await _connection.RequestResourceAsync<Meeting>("GET", $"api/http/calendars/meetings/{id}{queryParameters.ToQueryString()}", cancellationToken);
            }
            
        
            /// <summary>
            /// Patch a meeting. Only not-null parameters and not empty diffs will be applied.
            /// </summary>
            /// <remarks>
            /// Required permissions:
            /// <list type="bullet">
            /// <item>
            /// <term>Edit meetings</term>
            /// </item>
            /// </list>
            /// </remarks>
            public async Task<Meeting> UpdateMeetingAsync(string id, Diff locationsDiff, Diff profilesDiff, Diff externalParticipantsDiff, Diff teamsDiff, bool notifyOnExport = true, RecurrentModification modificationKind = RecurrentModification.All, string? summary = null, string? description = null, CalendarEventSpec? occurrenceRule = null, MeetingVisibility? visibility = null, MeetingModificationPreference? modificationPreference = null, MeetingJoiningPreference? joiningPreference = null, string? organizer = null, DateTime? targetDate = null, EventConferenceData? conferenceData = null, Func<Partial<Meeting>, Partial<Meeting>>? partial = null, CancellationToken cancellationToken = default)
            {
                var queryParameters = new NameValueCollection();
                queryParameters.Append("$fields", (partial != null ? partial(new Partial<Meeting>()) : Partial<Meeting>.Default()).ToString());
                
                return await _connection.RequestResourceAsync<CalendarsMeetingsForIdPatchRequest, Meeting>("PATCH", $"api/http/calendars/meetings/{id}{queryParameters.ToQueryString()}", 
                    new CalendarsMeetingsForIdPatchRequest
                    { 
                        Summary = summary,
                        Description = description,
                        OccurrenceRule = occurrenceRule,
                        LocationsDiff = locationsDiff,
                        ProfilesDiff = profilesDiff,
                        ExternalParticipantsDiff = externalParticipantsDiff,
                        TeamsDiff = teamsDiff,
                        Visibility = visibility,
                        ModificationPreference = modificationPreference,
                        JoiningPreference = joiningPreference,
                        IsNotifyOnExport = notifyOnExport,
                        Organizer = organizer,
                        TargetDate = targetDate,
                        ModificationKind = modificationKind,
                        ConferenceData = conferenceData,
                    }, cancellationToken);
            }
            
        
            /// <remarks>
            /// Required permissions:
            /// <list type="bullet">
            /// <item>
            /// <term>Edit meetings</term>
            /// </item>
            /// </list>
            /// </remarks>
            public async Task<Meeting> DeleteMeetingAsync(string id, RecurrentModification modificationKind = RecurrentModification.All, DateTime? targetDate = null, Func<Partial<Meeting>, Partial<Meeting>>? partial = null, CancellationToken cancellationToken = default)
            {
                var queryParameters = new NameValueCollection();
                if (targetDate != null) queryParameters.Append("targetDate", targetDate?.ToString("yyyy-MM-ddTHH:mm:ss.fffZ", CultureInfo.InvariantCulture));
                queryParameters.Append("modificationKind", modificationKind.ToEnumString());
                queryParameters.Append("$fields", (partial != null ? partial(new Partial<Meeting>()) : Partial<Meeting>.Default()).ToString());
                
                return await _connection.RequestResourceAsync<Meeting>("DELETE", $"api/http/calendars/meetings/{id}{queryParameters.ToQueryString()}", cancellationToken);
            }
            
        
        }
    
        public MembershipEventClient MembershipEvents => new MembershipEventClient(_connection);
        
        public partial class MembershipEventClient : ISpaceClient
        {
            private readonly Connection _connection;
            
            public MembershipEventClient(Connection connection)
            {
                _connection = connection;
            }
            
            /// <summary>
            /// Get/search membership events. Parameters are applied as 'AND' filters.
            /// </summary>
            /// <remarks>
            /// Required permissions:
            /// <list type="bullet">
            /// <item>
            /// <term>View memberships</term>
            /// </item>
            /// </list>
            /// </remarks>
            public async Task<List<MembershipEvent>> GetAllMembershipEventsAsync(DateTime dateFrom, DateTime dateTo, string? team = null, string? location = null, string? role = null, Func<Partial<MembershipEvent>, Partial<MembershipEvent>>? partial = null, CancellationToken cancellationToken = default)
            {
                var queryParameters = new NameValueCollection();
                queryParameters.Append("dateFrom", dateFrom.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture));
                queryParameters.Append("dateTo", dateTo.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture));
                if (team != null) queryParameters.Append("team", team);
                if (location != null) queryParameters.Append("location", location);
                if (role != null) queryParameters.Append("role", role);
                queryParameters.Append("$fields", (partial != null ? partial(new Partial<MembershipEvent>()) : Partial<MembershipEvent>.Default()).ToString());
                
                return await _connection.RequestResourceAsync<List<MembershipEvent>>("GET", $"api/http/calendars/membership-events{queryParameters.ToQueryString()}", cancellationToken);
            }
            
        
        }
    
        public NonWorkingDaysEventClient NonWorkingDaysEvents => new NonWorkingDaysEventClient(_connection);
        
        public partial class NonWorkingDaysEventClient : ISpaceClient
        {
            private readonly Connection _connection;
            
            public NonWorkingDaysEventClient(Connection connection)
            {
                _connection = connection;
            }
            
            /// <summary>
            /// Get/search non-working day events. Parameters are applied as 'AND' filters.
            /// </summary>
            public async Task<List<NonWorkingDaysEvent>> GetAllNonWorkingDaysEventsAsync(DateTime dateFrom, DateTime dateTo, string? member = null, string? team = null, string? location = null, string? role = null, Func<Partial<NonWorkingDaysEvent>, Partial<NonWorkingDaysEvent>>? partial = null, CancellationToken cancellationToken = default)
            {
                var queryParameters = new NameValueCollection();
                queryParameters.Append("dateFrom", dateFrom.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture));
                queryParameters.Append("dateTo", dateTo.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture));
                if (member != null) queryParameters.Append("member", member);
                if (team != null) queryParameters.Append("team", team);
                if (location != null) queryParameters.Append("location", location);
                if (role != null) queryParameters.Append("role", role);
                queryParameters.Append("$fields", (partial != null ? partial(new Partial<NonWorkingDaysEvent>()) : Partial<NonWorkingDaysEvent>.Default()).ToString());
                
                return await _connection.RequestResourceAsync<List<NonWorkingDaysEvent>>("GET", $"api/http/calendars/non-working-days-events{queryParameters.ToQueryString()}", cancellationToken);
            }
            
        
        }
    
    }
    
}
