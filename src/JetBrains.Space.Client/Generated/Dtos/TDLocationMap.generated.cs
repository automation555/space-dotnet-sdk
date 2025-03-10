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

public sealed class TDLocationMap
     : IPropagatePropertyAccessPath
{
    public TDLocationMap() { }
    
    public TDLocationMap(string id, string picture, DateTime created, int? width = null, int? height = null)
    {
        Id = id;
        Picture = picture;
        Created = created;
        Width = width;
        Height = height;
    }
    
    private PropertyValue<string> _id = new PropertyValue<string>(nameof(TDLocationMap), nameof(Id));
    
    [Required]
    [JsonPropertyName("id")]
    public string Id
    {
        get => _id.GetValue();
        set => _id.SetValue(value);
    }

    private PropertyValue<string> _picture = new PropertyValue<string>(nameof(TDLocationMap), nameof(Picture));
    
    [Required]
    [JsonPropertyName("picture")]
    public string Picture
    {
        get => _picture.GetValue();
        set => _picture.SetValue(value);
    }

    private PropertyValue<DateTime> _created = new PropertyValue<DateTime>(nameof(TDLocationMap), nameof(Created));
    
    [Required]
    [JsonPropertyName("created")]
    [JsonConverter(typeof(SpaceDateTimeConverter))]
    public DateTime Created
    {
        get => _created.GetValue();
        set => _created.SetValue(value);
    }

    private PropertyValue<int?> _width = new PropertyValue<int?>(nameof(TDLocationMap), nameof(Width));
    
    [JsonPropertyName("width")]
    public int? Width
    {
        get => _width.GetValue();
        set => _width.SetValue(value);
    }

    private PropertyValue<int?> _height = new PropertyValue<int?>(nameof(TDLocationMap), nameof(Height));
    
    [JsonPropertyName("height")]
    public int? Height
    {
        get => _height.GetValue();
        set => _height.SetValue(value);
    }

    public  void SetAccessPath(string path, bool validateHasBeenSet)
    {
        _id.SetAccessPath(path, validateHasBeenSet);
        _picture.SetAccessPath(path, validateHasBeenSet);
        _created.SetAccessPath(path, validateHasBeenSet);
        _width.SetAccessPath(path, validateHasBeenSet);
        _height.SetAccessPath(path, validateHasBeenSet);
    }

}

