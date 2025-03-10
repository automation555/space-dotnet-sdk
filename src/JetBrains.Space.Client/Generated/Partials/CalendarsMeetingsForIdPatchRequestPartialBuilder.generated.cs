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

namespace JetBrains.Space.Client.CalendarsMeetingsForIdPatchRequestPartialBuilder;

public static class CalendarsMeetingsForIdPatchRequestPartialExtensions
{
    public static Partial<CalendarsMeetingsForIdPatchRequest> WithSummary(this Partial<CalendarsMeetingsForIdPatchRequest> it)
        => it.AddFieldName("summary");
    
    public static Partial<CalendarsMeetingsForIdPatchRequest> WithDescription(this Partial<CalendarsMeetingsForIdPatchRequest> it)
        => it.AddFieldName("description");
    
    public static Partial<CalendarsMeetingsForIdPatchRequest> WithOccurrenceRule(this Partial<CalendarsMeetingsForIdPatchRequest> it)
        => it.AddFieldName("occurrenceRule");
    
    public static Partial<CalendarsMeetingsForIdPatchRequest> WithOccurrenceRule(this Partial<CalendarsMeetingsForIdPatchRequest> it, Func<Partial<CalendarEventSpec>, Partial<CalendarEventSpec>> partialBuilder)
        => it.AddFieldName("occurrenceRule", partialBuilder(new Partial<CalendarEventSpec>(it)));
    
    public static Partial<CalendarsMeetingsForIdPatchRequest> WithLocationsDiff(this Partial<CalendarsMeetingsForIdPatchRequest> it)
        => it.AddFieldName("locationsDiff");
    
    public static Partial<CalendarsMeetingsForIdPatchRequest> WithLocationsDiff(this Partial<CalendarsMeetingsForIdPatchRequest> it, Func<Partial<Diff>, Partial<Diff>> partialBuilder)
        => it.AddFieldName("locationsDiff", partialBuilder(new Partial<Diff>(it)));
    
    public static Partial<CalendarsMeetingsForIdPatchRequest> WithProfilesDiff(this Partial<CalendarsMeetingsForIdPatchRequest> it)
        => it.AddFieldName("profilesDiff");
    
    public static Partial<CalendarsMeetingsForIdPatchRequest> WithProfilesDiff(this Partial<CalendarsMeetingsForIdPatchRequest> it, Func<Partial<Diff>, Partial<Diff>> partialBuilder)
        => it.AddFieldName("profilesDiff", partialBuilder(new Partial<Diff>(it)));
    
    public static Partial<CalendarsMeetingsForIdPatchRequest> WithExternalParticipantsDiff(this Partial<CalendarsMeetingsForIdPatchRequest> it)
        => it.AddFieldName("externalParticipantsDiff");
    
    public static Partial<CalendarsMeetingsForIdPatchRequest> WithExternalParticipantsDiff(this Partial<CalendarsMeetingsForIdPatchRequest> it, Func<Partial<Diff>, Partial<Diff>> partialBuilder)
        => it.AddFieldName("externalParticipantsDiff", partialBuilder(new Partial<Diff>(it)));
    
    public static Partial<CalendarsMeetingsForIdPatchRequest> WithTeamsDiff(this Partial<CalendarsMeetingsForIdPatchRequest> it)
        => it.AddFieldName("teamsDiff");
    
    public static Partial<CalendarsMeetingsForIdPatchRequest> WithTeamsDiff(this Partial<CalendarsMeetingsForIdPatchRequest> it, Func<Partial<Diff>, Partial<Diff>> partialBuilder)
        => it.AddFieldName("teamsDiff", partialBuilder(new Partial<Diff>(it)));
    
    public static Partial<CalendarsMeetingsForIdPatchRequest> WithVisibility(this Partial<CalendarsMeetingsForIdPatchRequest> it)
        => it.AddFieldName("visibility");
    
    public static Partial<CalendarsMeetingsForIdPatchRequest> WithVisibility(this Partial<CalendarsMeetingsForIdPatchRequest> it, Func<Partial<MeetingVisibility>, Partial<MeetingVisibility>> partialBuilder)
        => it.AddFieldName("visibility", partialBuilder(new Partial<MeetingVisibility>(it)));
    
    public static Partial<CalendarsMeetingsForIdPatchRequest> WithModificationPreference(this Partial<CalendarsMeetingsForIdPatchRequest> it)
        => it.AddFieldName("modificationPreference");
    
    public static Partial<CalendarsMeetingsForIdPatchRequest> WithModificationPreference(this Partial<CalendarsMeetingsForIdPatchRequest> it, Func<Partial<MeetingModificationPreference>, Partial<MeetingModificationPreference>> partialBuilder)
        => it.AddFieldName("modificationPreference", partialBuilder(new Partial<MeetingModificationPreference>(it)));
    
    public static Partial<CalendarsMeetingsForIdPatchRequest> WithJoiningPreference(this Partial<CalendarsMeetingsForIdPatchRequest> it)
        => it.AddFieldName("joiningPreference");
    
    public static Partial<CalendarsMeetingsForIdPatchRequest> WithJoiningPreference(this Partial<CalendarsMeetingsForIdPatchRequest> it, Func<Partial<MeetingJoiningPreference>, Partial<MeetingJoiningPreference>> partialBuilder)
        => it.AddFieldName("joiningPreference", partialBuilder(new Partial<MeetingJoiningPreference>(it)));
    
    public static Partial<CalendarsMeetingsForIdPatchRequest> WithIsNotifyOnExport(this Partial<CalendarsMeetingsForIdPatchRequest> it)
        => it.AddFieldName("notifyOnExport");
    
    public static Partial<CalendarsMeetingsForIdPatchRequest> WithOrganizer(this Partial<CalendarsMeetingsForIdPatchRequest> it)
        => it.AddFieldName("organizer");
    
    public static Partial<CalendarsMeetingsForIdPatchRequest> WithTargetDate(this Partial<CalendarsMeetingsForIdPatchRequest> it)
        => it.AddFieldName("targetDate");
    
    public static Partial<CalendarsMeetingsForIdPatchRequest> WithModificationKind(this Partial<CalendarsMeetingsForIdPatchRequest> it)
        => it.AddFieldName("modificationKind");
    
    public static Partial<CalendarsMeetingsForIdPatchRequest> WithModificationKind(this Partial<CalendarsMeetingsForIdPatchRequest> it, Func<Partial<RecurrentModification>, Partial<RecurrentModification>> partialBuilder)
        => it.AddFieldName("modificationKind", partialBuilder(new Partial<RecurrentModification>(it)));
    
    public static Partial<CalendarsMeetingsForIdPatchRequest> WithConferenceData(this Partial<CalendarsMeetingsForIdPatchRequest> it)
        => it.AddFieldName("conferenceData");
    
    public static Partial<CalendarsMeetingsForIdPatchRequest> WithConferenceData(this Partial<CalendarsMeetingsForIdPatchRequest> it, Func<Partial<EventConferenceData>, Partial<EventConferenceData>> partialBuilder)
        => it.AddFieldName("conferenceData", partialBuilder(new Partial<EventConferenceData>(it)));
    
}

