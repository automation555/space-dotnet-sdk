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

namespace JetBrains.Space.Client;

public class CalendarsMeetingsForIdPatchRequest
     : IPropagatePropertyAccessPath
{
    public CalendarsMeetingsForIdPatchRequest() { }
    
    public CalendarsMeetingsForIdPatchRequest(Diff locationsDiff, Diff profilesDiff, Diff externalParticipantsDiff, Diff teamsDiff, bool notifyOnExport = true, RecurrentModification modificationKind = RecurrentModification.All, string? summary = null, string? description = null, CalendarEventSpec? occurrenceRule = null, MeetingVisibility? visibility = null, MeetingModificationPreference? modificationPreference = null, MeetingJoiningPreference? joiningPreference = null, string? organizer = null, DateTime? targetDate = null, EventConferenceData? conferenceData = null)
    {
        Summary = summary;
        Description = description;
        OccurrenceRule = occurrenceRule;
        LocationsDiff = locationsDiff;
        ProfilesDiff = profilesDiff;
        ExternalParticipantsDiff = externalParticipantsDiff;
        TeamsDiff = teamsDiff;
        Visibility = visibility;
        ModificationPreference = modificationPreference;
        JoiningPreference = joiningPreference;
        IsNotifyOnExport = notifyOnExport;
        Organizer = organizer;
        TargetDate = targetDate;
        ModificationKind = modificationKind;
        ConferenceData = conferenceData;
    }
    
    private PropertyValue<string?> _summary = new PropertyValue<string?>(nameof(CalendarsMeetingsForIdPatchRequest), nameof(Summary));
    
    [JsonPropertyName("summary")]
    public string? Summary
    {
        get => _summary.GetValue();
        set => _summary.SetValue(value);
    }

    private PropertyValue<string?> _description = new PropertyValue<string?>(nameof(CalendarsMeetingsForIdPatchRequest), nameof(Description));
    
    [JsonPropertyName("description")]
    public string? Description
    {
        get => _description.GetValue();
        set => _description.SetValue(value);
    }

    private PropertyValue<CalendarEventSpec?> _occurrenceRule = new PropertyValue<CalendarEventSpec?>(nameof(CalendarsMeetingsForIdPatchRequest), nameof(OccurrenceRule));
    
    [JsonPropertyName("occurrenceRule")]
    public CalendarEventSpec? OccurrenceRule
    {
        get => _occurrenceRule.GetValue();
        set => _occurrenceRule.SetValue(value);
    }

    private PropertyValue<Diff> _locationsDiff = new PropertyValue<Diff>(nameof(CalendarsMeetingsForIdPatchRequest), nameof(LocationsDiff));
    
    [JsonPropertyName("locationsDiff")]
    public Diff LocationsDiff
    {
        get => _locationsDiff.GetValue();
        set => _locationsDiff.SetValue(value);
    }

    private PropertyValue<Diff> _profilesDiff = new PropertyValue<Diff>(nameof(CalendarsMeetingsForIdPatchRequest), nameof(ProfilesDiff));
    
    [JsonPropertyName("profilesDiff")]
    public Diff ProfilesDiff
    {
        get => _profilesDiff.GetValue();
        set => _profilesDiff.SetValue(value);
    }

    private PropertyValue<Diff> _externalParticipantsDiff = new PropertyValue<Diff>(nameof(CalendarsMeetingsForIdPatchRequest), nameof(ExternalParticipantsDiff));
    
    [JsonPropertyName("externalParticipantsDiff")]
    public Diff ExternalParticipantsDiff
    {
        get => _externalParticipantsDiff.GetValue();
        set => _externalParticipantsDiff.SetValue(value);
    }

    private PropertyValue<Diff> _teamsDiff = new PropertyValue<Diff>(nameof(CalendarsMeetingsForIdPatchRequest), nameof(TeamsDiff));
    
    [JsonPropertyName("teamsDiff")]
    public Diff TeamsDiff
    {
        get => _teamsDiff.GetValue();
        set => _teamsDiff.SetValue(value);
    }

    private PropertyValue<MeetingVisibility?> _visibility = new PropertyValue<MeetingVisibility?>(nameof(CalendarsMeetingsForIdPatchRequest), nameof(Visibility));
    
    [JsonPropertyName("visibility")]
    public MeetingVisibility? Visibility
    {
        get => _visibility.GetValue();
        set => _visibility.SetValue(value);
    }

    private PropertyValue<MeetingModificationPreference?> _modificationPreference = new PropertyValue<MeetingModificationPreference?>(nameof(CalendarsMeetingsForIdPatchRequest), nameof(ModificationPreference));
    
    [JsonPropertyName("modificationPreference")]
    public MeetingModificationPreference? ModificationPreference
    {
        get => _modificationPreference.GetValue();
        set => _modificationPreference.SetValue(value);
    }

    private PropertyValue<MeetingJoiningPreference?> _joiningPreference = new PropertyValue<MeetingJoiningPreference?>(nameof(CalendarsMeetingsForIdPatchRequest), nameof(JoiningPreference));
    
    [JsonPropertyName("joiningPreference")]
    public MeetingJoiningPreference? JoiningPreference
    {
        get => _joiningPreference.GetValue();
        set => _joiningPreference.SetValue(value);
    }

    private PropertyValue<bool> _notifyOnExport = new PropertyValue<bool>(nameof(CalendarsMeetingsForIdPatchRequest), nameof(IsNotifyOnExport));
    
    [JsonPropertyName("notifyOnExport")]
    public bool IsNotifyOnExport
    {
        get => _notifyOnExport.GetValue();
        set => _notifyOnExport.SetValue(value);
    }

    private PropertyValue<string?> _organizer = new PropertyValue<string?>(nameof(CalendarsMeetingsForIdPatchRequest), nameof(Organizer));
    
    [JsonPropertyName("organizer")]
    public string? Organizer
    {
        get => _organizer.GetValue();
        set => _organizer.SetValue(value);
    }

    private PropertyValue<DateTime?> _targetDate = new PropertyValue<DateTime?>(nameof(CalendarsMeetingsForIdPatchRequest), nameof(TargetDate));
    
    [JsonPropertyName("targetDate")]
    [JsonConverter(typeof(SpaceDateTimeConverter))]
    public DateTime? TargetDate
    {
        get => _targetDate.GetValue();
        set => _targetDate.SetValue(value);
    }

    private PropertyValue<RecurrentModification> _modificationKind = new PropertyValue<RecurrentModification>(nameof(CalendarsMeetingsForIdPatchRequest), nameof(ModificationKind), RecurrentModification.All);
    
    [JsonPropertyName("modificationKind")]
    public RecurrentModification ModificationKind
    {
        get => _modificationKind.GetValue();
        set => _modificationKind.SetValue(value);
    }

    private PropertyValue<EventConferenceData?> _conferenceData = new PropertyValue<EventConferenceData?>(nameof(CalendarsMeetingsForIdPatchRequest), nameof(ConferenceData));
    
    [JsonPropertyName("conferenceData")]
    public EventConferenceData? ConferenceData
    {
        get => _conferenceData.GetValue();
        set => _conferenceData.SetValue(value);
    }

    public virtual void SetAccessPath(string path, bool validateHasBeenSet)
    {
        _summary.SetAccessPath(path, validateHasBeenSet);
        _description.SetAccessPath(path, validateHasBeenSet);
        _occurrenceRule.SetAccessPath(path, validateHasBeenSet);
        _locationsDiff.SetAccessPath(path, validateHasBeenSet);
        _profilesDiff.SetAccessPath(path, validateHasBeenSet);
        _externalParticipantsDiff.SetAccessPath(path, validateHasBeenSet);
        _teamsDiff.SetAccessPath(path, validateHasBeenSet);
        _visibility.SetAccessPath(path, validateHasBeenSet);
        _modificationPreference.SetAccessPath(path, validateHasBeenSet);
        _joiningPreference.SetAccessPath(path, validateHasBeenSet);
        _notifyOnExport.SetAccessPath(path, validateHasBeenSet);
        _organizer.SetAccessPath(path, validateHasBeenSet);
        _targetDate.SetAccessPath(path, validateHasBeenSet);
        _modificationKind.SetAccessPath(path, validateHasBeenSet);
        _conferenceData.SetAccessPath(path, validateHasBeenSet);
    }

}

