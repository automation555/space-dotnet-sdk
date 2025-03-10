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

public sealed class TDLocation
     : IPropagatePropertyAccessPath
{
    public TDLocation() { }
    
    public TDLocation(string id, string name, List<string> phones, List<string> emails, string type, bool archived, ATimeZoneWithOffset? timezone = null, string? tz = null, List<int>? workdays = null, List<string>? equipment = null, string? description = null, string? address = null, TDLocation? parent = null, string? mapId = null, int? capacity = null, string? channelId = null, List<TDLocationEquipmentTypeRecord>? equipment2 = null)
    {
        Id = id;
        Name = name;
        Timezone = timezone;
        Tz = tz;
        Workdays = workdays;
        Phones = phones;
        Emails = emails;
        Equipment = equipment;
        Description = description;
        Address = address;
        Parent = parent;
        Type = type;
        MapId = mapId;
        Capacity = capacity;
        ChannelId = channelId;
        IsArchived = archived;
        Equipment2 = equipment2;
    }
    
    private PropertyValue<string> _id = new PropertyValue<string>(nameof(TDLocation), nameof(Id));
    
    [Required]
    [JsonPropertyName("id")]
    public string Id
    {
        get => _id.GetValue();
        set => _id.SetValue(value);
    }

    private PropertyValue<string> _name = new PropertyValue<string>(nameof(TDLocation), nameof(Name));
    
    [Required]
    [JsonPropertyName("name")]
    public string Name
    {
        get => _name.GetValue();
        set => _name.SetValue(value);
    }

    private PropertyValue<ATimeZoneWithOffset?> _timezone = new PropertyValue<ATimeZoneWithOffset?>(nameof(TDLocation), nameof(Timezone));
    
    [Obsolete("Use tz field that contains no specific offset for a timezone. Field timezone is always null (since 2019.0.1) (will be removed in a future version)")]
    [JsonPropertyName("timezone")]
    public ATimeZoneWithOffset? Timezone
    {
        get => _timezone.GetValue();
        set => _timezone.SetValue(value);
    }

    private PropertyValue<string?> _tz = new PropertyValue<string?>(nameof(TDLocation), nameof(Tz));
    
    [JsonPropertyName("tz")]
    public string? Tz
    {
        get => _tz.GetValue();
        set => _tz.SetValue(value);
    }

    private PropertyValue<List<int>?> _workdays = new PropertyValue<List<int>?>(nameof(TDLocation), nameof(Workdays));
    
    [JsonPropertyName("workdays")]
    public List<int>? Workdays
    {
        get => _workdays.GetValue();
        set => _workdays.SetValue(value);
    }

    private PropertyValue<List<string>> _phones = new PropertyValue<List<string>>(nameof(TDLocation), nameof(Phones), new List<string>());
    
    [Required]
    [JsonPropertyName("phones")]
    public List<string> Phones
    {
        get => _phones.GetValue();
        set => _phones.SetValue(value);
    }

    private PropertyValue<List<string>> _emails = new PropertyValue<List<string>>(nameof(TDLocation), nameof(Emails), new List<string>());
    
    [Required]
    [JsonPropertyName("emails")]
    public List<string> Emails
    {
        get => _emails.GetValue();
        set => _emails.SetValue(value);
    }

    private PropertyValue<List<string>?> _equipment = new PropertyValue<List<string>?>(nameof(TDLocation), nameof(Equipment));
    
    [JsonPropertyName("equipment")]
    public List<string>? Equipment
    {
        get => _equipment.GetValue();
        set => _equipment.SetValue(value);
    }

    private PropertyValue<string?> _description = new PropertyValue<string?>(nameof(TDLocation), nameof(Description));
    
    [JsonPropertyName("description")]
    public string? Description
    {
        get => _description.GetValue();
        set => _description.SetValue(value);
    }

    private PropertyValue<string?> _address = new PropertyValue<string?>(nameof(TDLocation), nameof(Address));
    
    [JsonPropertyName("address")]
    public string? Address
    {
        get => _address.GetValue();
        set => _address.SetValue(value);
    }

    private PropertyValue<TDLocation?> _parent = new PropertyValue<TDLocation?>(nameof(TDLocation), nameof(Parent));
    
    [JsonPropertyName("parent")]
    public TDLocation? Parent
    {
        get => _parent.GetValue();
        set => _parent.SetValue(value);
    }

    private PropertyValue<string> _type = new PropertyValue<string>(nameof(TDLocation), nameof(Type));
    
    [Required]
    [JsonPropertyName("type")]
    public string Type
    {
        get => _type.GetValue();
        set => _type.SetValue(value);
    }

    private PropertyValue<string?> _mapId = new PropertyValue<string?>(nameof(TDLocation), nameof(MapId));
    
    [JsonPropertyName("mapId")]
    public string? MapId
    {
        get => _mapId.GetValue();
        set => _mapId.SetValue(value);
    }

    private PropertyValue<int?> _capacity = new PropertyValue<int?>(nameof(TDLocation), nameof(Capacity));
    
    [JsonPropertyName("capacity")]
    public int? Capacity
    {
        get => _capacity.GetValue();
        set => _capacity.SetValue(value);
    }

    private PropertyValue<string?> _channelId = new PropertyValue<string?>(nameof(TDLocation), nameof(ChannelId));
    
    [JsonPropertyName("channelId")]
    public string? ChannelId
    {
        get => _channelId.GetValue();
        set => _channelId.SetValue(value);
    }

    private PropertyValue<bool> _archived = new PropertyValue<bool>(nameof(TDLocation), nameof(IsArchived));
    
    [Required]
    [JsonPropertyName("archived")]
    public bool IsArchived
    {
        get => _archived.GetValue();
        set => _archived.SetValue(value);
    }

    private PropertyValue<List<TDLocationEquipmentTypeRecord>?> _equipment2 = new PropertyValue<List<TDLocationEquipmentTypeRecord>?>(nameof(TDLocation), nameof(Equipment2));
    
    [JsonPropertyName("equipment2")]
    public List<TDLocationEquipmentTypeRecord>? Equipment2
    {
        get => _equipment2.GetValue();
        set => _equipment2.SetValue(value);
    }

    public  void SetAccessPath(string path, bool validateHasBeenSet)
    {
        _id.SetAccessPath(path, validateHasBeenSet);
        _name.SetAccessPath(path, validateHasBeenSet);
        _timezone.SetAccessPath(path, validateHasBeenSet);
        _tz.SetAccessPath(path, validateHasBeenSet);
        _workdays.SetAccessPath(path, validateHasBeenSet);
        _phones.SetAccessPath(path, validateHasBeenSet);
        _emails.SetAccessPath(path, validateHasBeenSet);
        _equipment.SetAccessPath(path, validateHasBeenSet);
        _description.SetAccessPath(path, validateHasBeenSet);
        _address.SetAccessPath(path, validateHasBeenSet);
        _parent.SetAccessPath(path, validateHasBeenSet);
        _type.SetAccessPath(path, validateHasBeenSet);
        _mapId.SetAccessPath(path, validateHasBeenSet);
        _capacity.SetAccessPath(path, validateHasBeenSet);
        _channelId.SetAccessPath(path, validateHasBeenSet);
        _archived.SetAccessPath(path, validateHasBeenSet);
        _equipment2.SetAccessPath(path, validateHasBeenSet);
    }

}

