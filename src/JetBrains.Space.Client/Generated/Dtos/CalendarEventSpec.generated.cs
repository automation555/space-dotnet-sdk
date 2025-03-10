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

public sealed class CalendarEventSpec
     : IPropagatePropertyAccessPath
{
    public CalendarEventSpec() { }
    
    public CalendarEventSpec(DateTime start, DateTime end, bool allDay, ATimeZone timezone, RecurrenceRule? recurrenceRule = null, string? parentId = null, DateTime? initialMeetingStart = null, BusyStatus? busyStatus = null, string? nextChainId = null)
    {
        Start = start;
        End = end;
        RecurrenceRule = recurrenceRule;
        IsAllDay = allDay;
        Timezone = timezone;
        ParentId = parentId;
        InitialMeetingStart = initialMeetingStart;
        BusyStatus = busyStatus;
        NextChainId = nextChainId;
    }
    
    private PropertyValue<DateTime> _start = new PropertyValue<DateTime>(nameof(CalendarEventSpec), nameof(Start));
    
    [Required]
    [JsonPropertyName("start")]
    [JsonConverter(typeof(SpaceDateTimeConverter))]
    public DateTime Start
    {
        get => _start.GetValue();
        set => _start.SetValue(value);
    }

    private PropertyValue<DateTime> _end = new PropertyValue<DateTime>(nameof(CalendarEventSpec), nameof(End));
    
    [Required]
    [JsonPropertyName("end")]
    [JsonConverter(typeof(SpaceDateTimeConverter))]
    public DateTime End
    {
        get => _end.GetValue();
        set => _end.SetValue(value);
    }

    private PropertyValue<RecurrenceRule?> _recurrenceRule = new PropertyValue<RecurrenceRule?>(nameof(CalendarEventSpec), nameof(RecurrenceRule));
    
    [JsonPropertyName("recurrenceRule")]
    public RecurrenceRule? RecurrenceRule
    {
        get => _recurrenceRule.GetValue();
        set => _recurrenceRule.SetValue(value);
    }

    private PropertyValue<bool> _allDay = new PropertyValue<bool>(nameof(CalendarEventSpec), nameof(IsAllDay));
    
    [Required]
    [JsonPropertyName("allDay")]
    public bool IsAllDay
    {
        get => _allDay.GetValue();
        set => _allDay.SetValue(value);
    }

    private PropertyValue<ATimeZone> _timezone = new PropertyValue<ATimeZone>(nameof(CalendarEventSpec), nameof(Timezone));
    
    [Required]
    [JsonPropertyName("timezone")]
    public ATimeZone Timezone
    {
        get => _timezone.GetValue();
        set => _timezone.SetValue(value);
    }

    private PropertyValue<string?> _parentId = new PropertyValue<string?>(nameof(CalendarEventSpec), nameof(ParentId));
    
    [JsonPropertyName("parentId")]
    public string? ParentId
    {
        get => _parentId.GetValue();
        set => _parentId.SetValue(value);
    }

    private PropertyValue<DateTime?> _initialMeetingStart = new PropertyValue<DateTime?>(nameof(CalendarEventSpec), nameof(InitialMeetingStart));
    
    [JsonPropertyName("initialMeetingStart")]
    [JsonConverter(typeof(SpaceDateTimeConverter))]
    public DateTime? InitialMeetingStart
    {
        get => _initialMeetingStart.GetValue();
        set => _initialMeetingStart.SetValue(value);
    }

    private PropertyValue<BusyStatus?> _busyStatus = new PropertyValue<BusyStatus?>(nameof(CalendarEventSpec), nameof(BusyStatus));
    
    [JsonPropertyName("busyStatus")]
    public BusyStatus? BusyStatus
    {
        get => _busyStatus.GetValue();
        set => _busyStatus.SetValue(value);
    }

    private PropertyValue<string?> _nextChainId = new PropertyValue<string?>(nameof(CalendarEventSpec), nameof(NextChainId));
    
    [JsonPropertyName("nextChainId")]
    public string? NextChainId
    {
        get => _nextChainId.GetValue();
        set => _nextChainId.SetValue(value);
    }

    public  void SetAccessPath(string path, bool validateHasBeenSet)
    {
        _start.SetAccessPath(path, validateHasBeenSet);
        _end.SetAccessPath(path, validateHasBeenSet);
        _recurrenceRule.SetAccessPath(path, validateHasBeenSet);
        _allDay.SetAccessPath(path, validateHasBeenSet);
        _timezone.SetAccessPath(path, validateHasBeenSet);
        _parentId.SetAccessPath(path, validateHasBeenSet);
        _initialMeetingStart.SetAccessPath(path, validateHasBeenSet);
        _busyStatus.SetAccessPath(path, validateHasBeenSet);
        _nextChainId.SetAccessPath(path, validateHasBeenSet);
    }

}

