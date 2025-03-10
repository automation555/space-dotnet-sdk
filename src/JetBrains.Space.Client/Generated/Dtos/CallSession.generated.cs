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

public sealed class CallSession
     : IPropagatePropertyAccessPath
{
    public CallSession() { }
    
    public CallSession(string id, bool archived, Room room, string description, DateTime start, bool resourcesPrepared, DateTime? end = null, M2ChannelRecord? channel = null, ConnectionTopology? topology = null)
    {
        Id = id;
        IsArchived = archived;
        Room = room;
        Description = description;
        Start = start;
        End = end;
        Channel = channel;
        Topology = topology;
        IsResourcesPrepared = resourcesPrepared;
    }
    
    private PropertyValue<string> _id = new PropertyValue<string>(nameof(CallSession), nameof(Id));
    
    [Required]
    [JsonPropertyName("id")]
    public string Id
    {
        get => _id.GetValue();
        set => _id.SetValue(value);
    }

    private PropertyValue<bool> _archived = new PropertyValue<bool>(nameof(CallSession), nameof(IsArchived));
    
    [Required]
    [JsonPropertyName("archived")]
    public bool IsArchived
    {
        get => _archived.GetValue();
        set => _archived.SetValue(value);
    }

    private PropertyValue<Room> _room = new PropertyValue<Room>(nameof(CallSession), nameof(Room));
    
    [Required]
    [JsonPropertyName("room")]
    public Room Room
    {
        get => _room.GetValue();
        set => _room.SetValue(value);
    }

    private PropertyValue<string> _description = new PropertyValue<string>(nameof(CallSession), nameof(Description));
    
    [Required]
    [JsonPropertyName("description")]
    public string Description
    {
        get => _description.GetValue();
        set => _description.SetValue(value);
    }

    private PropertyValue<DateTime> _start = new PropertyValue<DateTime>(nameof(CallSession), nameof(Start));
    
    [Required]
    [JsonPropertyName("start")]
    [JsonConverter(typeof(SpaceDateTimeConverter))]
    public DateTime Start
    {
        get => _start.GetValue();
        set => _start.SetValue(value);
    }

    private PropertyValue<DateTime?> _end = new PropertyValue<DateTime?>(nameof(CallSession), nameof(End));
    
    [JsonPropertyName("end")]
    [JsonConverter(typeof(SpaceDateTimeConverter))]
    public DateTime? End
    {
        get => _end.GetValue();
        set => _end.SetValue(value);
    }

    private PropertyValue<M2ChannelRecord?> _channel = new PropertyValue<M2ChannelRecord?>(nameof(CallSession), nameof(Channel));
    
    [JsonPropertyName("channel")]
    public M2ChannelRecord? Channel
    {
        get => _channel.GetValue();
        set => _channel.SetValue(value);
    }

    private PropertyValue<ConnectionTopology?> _topology = new PropertyValue<ConnectionTopology?>(nameof(CallSession), nameof(Topology));
    
    [JsonPropertyName("topology")]
    public ConnectionTopology? Topology
    {
        get => _topology.GetValue();
        set => _topology.SetValue(value);
    }

    private PropertyValue<bool> _resourcesPrepared = new PropertyValue<bool>(nameof(CallSession), nameof(IsResourcesPrepared));
    
    [Required]
    [JsonPropertyName("resourcesPrepared")]
    public bool IsResourcesPrepared
    {
        get => _resourcesPrepared.GetValue();
        set => _resourcesPrepared.SetValue(value);
    }

    public  void SetAccessPath(string path, bool validateHasBeenSet)
    {
        _id.SetAccessPath(path, validateHasBeenSet);
        _archived.SetAccessPath(path, validateHasBeenSet);
        _room.SetAccessPath(path, validateHasBeenSet);
        _description.SetAccessPath(path, validateHasBeenSet);
        _start.SetAccessPath(path, validateHasBeenSet);
        _end.SetAccessPath(path, validateHasBeenSet);
        _channel.SetAccessPath(path, validateHasBeenSet);
        _topology.SetAccessPath(path, validateHasBeenSet);
        _resourcesPrepared.SetAccessPath(path, validateHasBeenSet);
    }

}

