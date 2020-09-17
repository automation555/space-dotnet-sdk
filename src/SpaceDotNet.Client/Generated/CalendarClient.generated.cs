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

namespace SpaceDotNet.Client
{
    public partial class CalendarClient
    {
        private readonly Connection _connection;
        
        public CalendarClient(Connection connection)
        {
            _connection = connection;
        }
        
        public MeetingClient Meetings => new MeetingClient(_connection);
        
        public partial class MeetingClient
        {
            private readonly Connection _connection;
            
            public MeetingClient(Connection connection)
            {
                _connection = connection;
            }
            
            /// <summary>
            /// Create a meeting.
            /// </summary>
            public async Task<Meeting> CreateMeetingAsync(string summary, CalendarEventSpec occurrenceRule, List<string>? locations = null, List<string>? profiles = null, List<string>? externalParticipants = null, List<string>? teams = null, MeetingVisibility? visibility = null, MeetingModificationPreference? modificationPreference = null, MeetingJoiningPreference? joiningPreference = null, bool notifyOnExport = true, string? description = null, string? organizer = null, Func<Partial<Meeting>, Partial<Meeting>>? partial = null, CancellationToken cancellationToken = default)
                => await _connection.RequestResourceAsync<CalendarsMeetingsPostRequest, Meeting>("POST", $"api/http/calendars/meetings?$fields={(partial != null ? partial(new Partial<Meeting>()) : Partial<Meeting>.Default())}", 
                    new CalendarsMeetingsPostRequest { 
                        Summary = summary,
                        Description = description,
                        OccurrenceRule = occurrenceRule,
                        Locations = (locations ?? new List<string>()),
                        Profiles = (profiles ?? new List<string>()),
                        ExternalParticipants = (externalParticipants ?? new List<string>()),
                        Teams = (teams ?? new List<string>()),
                        Visibility = (visibility ?? MeetingVisibility.EVERYONE),
                        ModificationPreference = (modificationPreference ?? MeetingModificationPreference.PARTICIPANTS),
                        JoiningPreference = (joiningPreference ?? MeetingJoiningPreference.NOBODY),
                        IsNotifyOnExport = notifyOnExport,
                        Organizer = organizer,
                    }
            , cancellationToken);
        
            /// <summary>
            /// Search meetings by name, location, time period and other parameters. Parameters are applied as 'AND' filters while values in lists of locations, profiles and teams have 'OR' semantics.
            /// </summary>
            public async Task<Batch<Meeting>> GetAllMeetingsAsync(string summaryQuery = "", List<string>? locationsQuery = null, List<string>? profiles = null, List<string>? teams = null, bool includePrivate = false, bool includeArchived = false, bool includeMeetingInstances = true, string? skip = null, int? top = 100, SpaceTime? startingAfter = null, SpaceTime? endingAfter = null, SpaceTime? endingBefore = null, SpaceTime? startingBefore = null, string? organizer = null, Func<Partial<Batch<Meeting>>, Partial<Batch<Meeting>>>? partial = null, CancellationToken cancellationToken = default)
                => await _connection.RequestResourceAsync<Batch<Meeting>>("GET", $"api/http/calendars/meetings?$skip={skip?.ToString() ?? "null"}&$top={top?.ToString() ?? "null"}&summaryQuery={summaryQuery.ToString()}&locationsQuery={(locationsQuery ?? new List<string>()).JoinToString("locationsQuery", it => it.ToString())}&startingAfter={startingAfter?.ToString() ?? "null"}&endingAfter={endingAfter?.ToString() ?? "null"}&endingBefore={endingBefore?.ToString() ?? "null"}&startingBefore={startingBefore?.ToString() ?? "null"}&profiles={(profiles ?? new List<string>()).JoinToString("profiles", it => it.ToString())}&teams={(teams ?? new List<string>()).JoinToString("teams", it => it.ToString())}&organizer={organizer?.ToString() ?? "null"}&includePrivate={includePrivate.ToString().ToLowerInvariant()}&includeArchived={includeArchived.ToString().ToLowerInvariant()}&includeMeetingInstances={includeMeetingInstances.ToString().ToLowerInvariant()}&$fields={(partial != null ? partial(new Partial<Batch<Meeting>>()) : Partial<Batch<Meeting>>.Default())}", cancellationToken);
            
            /// <summary>
            /// Search meetings by name, location, time period and other parameters. Parameters are applied as 'AND' filters while values in lists of locations, profiles and teams have 'OR' semantics.
            /// </summary>
            public IAsyncEnumerable<Meeting> GetAllMeetingsAsyncEnumerable(string summaryQuery = "", List<string>? locationsQuery = null, List<string>? profiles = null, List<string>? teams = null, bool includePrivate = false, bool includeArchived = false, bool includeMeetingInstances = true, string? skip = null, int? top = 100, SpaceTime? startingAfter = null, SpaceTime? endingAfter = null, SpaceTime? endingBefore = null, SpaceTime? startingBefore = null, string? organizer = null, Func<Partial<Meeting>, Partial<Meeting>>? partial = null, CancellationToken cancellationToken = default)
                => BatchEnumerator.AllItems((batchSkip, batchCancellationToken) => GetAllMeetingsAsync(summaryQuery: summaryQuery, locationsQuery: locationsQuery, profiles: profiles, teams: teams, includePrivate: includePrivate, includeArchived: includeArchived, includeMeetingInstances: includeMeetingInstances, top: top, startingAfter: startingAfter, endingAfter: endingAfter, endingBefore: endingBefore, startingBefore: startingBefore, organizer: organizer, cancellationToken: cancellationToken, skip: batchSkip, partial: builder => Partial<Batch<Meeting>>.Default().WithNext().WithTotalCount().WithData(partial != null ? partial : _ => Partial<Meeting>.Default())), skip, cancellationToken);
        
            public async Task<Meeting> GetMeetingAsync(string id, Func<Partial<Meeting>, Partial<Meeting>>? partial = null, CancellationToken cancellationToken = default)
                => await _connection.RequestResourceAsync<Meeting>("GET", $"api/http/calendars/meetings/{id}?$fields={(partial != null ? partial(new Partial<Meeting>()) : Partial<Meeting>.Default())}", cancellationToken);
        
            /// <summary>
            /// Patch a meeting. Only not-null parameters and not empty diffs will be applied.
            /// </summary>
            public async Task<Meeting> UpdateMeetingAsync(string id, Diff locationsDiff, Diff profilesDiff, Diff externalParticipantsDiff, Diff teamsDiff, bool notifyOnExport = true, RecurrentModification? modificationKind = null, string? summary = null, string? description = null, CalendarEventSpec? occurrenceRule = null, MeetingVisibility? visibility = null, MeetingModificationPreference? modificationPreference = null, MeetingJoiningPreference? joiningPreference = null, string? organizer = null, SpaceTime? targetDate = null, Func<Partial<Meeting>, Partial<Meeting>>? partial = null, CancellationToken cancellationToken = default)
                => await _connection.RequestResourceAsync<CalendarsMeetingsForIdPatchRequest, Meeting>("PATCH", $"api/http/calendars/meetings/{id}?$fields={(partial != null ? partial(new Partial<Meeting>()) : Partial<Meeting>.Default())}", 
                    new CalendarsMeetingsForIdPatchRequest { 
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
                        ModificationKind = (modificationKind ?? RecurrentModification.All),
                    }
            , cancellationToken);
        
            public async Task<Meeting> DeleteMeetingAsync(string id, RecurrentModification? modificationKind = null, SpaceTime? targetDate = null, Func<Partial<Meeting>, Partial<Meeting>>? partial = null, CancellationToken cancellationToken = default)
                => await _connection.RequestResourceAsync<Meeting>("DELETE", $"api/http/calendars/meetings/{id}?targetDate={targetDate?.ToString() ?? "null"}&modificationKind={(modificationKind ?? RecurrentModification.All).ToString()}&$fields={(partial != null ? partial(new Partial<Meeting>()) : Partial<Meeting>.Default())}", cancellationToken);
        
        }
    
    }
    
}
