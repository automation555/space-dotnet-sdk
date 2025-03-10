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

public sealed class BlogCommonSubscriptionFilterIn
     : SubscriptionFilterIn, IClassNameConvertible, IPropagatePropertyAccessPath
{
    [JsonPropertyName("className")]
    public  string? ClassName => "BlogCommonSubscriptionFilterIn";
    
    public BlogCommonSubscriptionFilterIn() { }
    
    public BlogCommonSubscriptionFilterIn(List<string> teams, List<string> locations, List<string> authors)
    {
        Teams = teams;
        Locations = locations;
        Authors = authors;
    }
    
    private PropertyValue<List<string>> _teams = new PropertyValue<List<string>>(nameof(BlogCommonSubscriptionFilterIn), nameof(Teams), new List<string>());
    
    [Required]
    [JsonPropertyName("teams")]
    public List<string> Teams
    {
        get => _teams.GetValue();
        set => _teams.SetValue(value);
    }

    private PropertyValue<List<string>> _locations = new PropertyValue<List<string>>(nameof(BlogCommonSubscriptionFilterIn), nameof(Locations), new List<string>());
    
    [Required]
    [JsonPropertyName("locations")]
    public List<string> Locations
    {
        get => _locations.GetValue();
        set => _locations.SetValue(value);
    }

    private PropertyValue<List<string>> _authors = new PropertyValue<List<string>>(nameof(BlogCommonSubscriptionFilterIn), nameof(Authors), new List<string>());
    
    [Required]
    [JsonPropertyName("authors")]
    public List<string> Authors
    {
        get => _authors.GetValue();
        set => _authors.SetValue(value);
    }

    public  void SetAccessPath(string path, bool validateHasBeenSet)
    {
        _teams.SetAccessPath(path, validateHasBeenSet);
        _locations.SetAccessPath(path, validateHasBeenSet);
        _authors.SetAccessPath(path, validateHasBeenSet);
    }

}

