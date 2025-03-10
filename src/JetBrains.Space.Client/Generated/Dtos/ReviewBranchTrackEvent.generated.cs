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

public sealed class ReviewBranchTrackEvent
     : FeedEvent, IClassNameConvertible, IPropagatePropertyAccessPath
{
    [JsonPropertyName("className")]
    public  string? ClassName => "ReviewBranchTrackEvent";
    
    public ReviewBranchTrackEvent() { }
    
    public ReviewBranchTrackEvent(string repository, string branch, bool track)
    {
        Repository = repository;
        Branch = branch;
        IsTrack = track;
    }
    
    private PropertyValue<string> _repository = new PropertyValue<string>(nameof(ReviewBranchTrackEvent), nameof(Repository));
    
    [Required]
    [JsonPropertyName("repository")]
    public string Repository
    {
        get => _repository.GetValue();
        set => _repository.SetValue(value);
    }

    private PropertyValue<string> _branch = new PropertyValue<string>(nameof(ReviewBranchTrackEvent), nameof(Branch));
    
    [Required]
    [JsonPropertyName("branch")]
    public string Branch
    {
        get => _branch.GetValue();
        set => _branch.SetValue(value);
    }

    private PropertyValue<bool> _track = new PropertyValue<bool>(nameof(ReviewBranchTrackEvent), nameof(IsTrack));
    
    [Required]
    [JsonPropertyName("track")]
    public bool IsTrack
    {
        get => _track.GetValue();
        set => _track.SetValue(value);
    }

    public  void SetAccessPath(string path, bool validateHasBeenSet)
    {
        _repository.SetAccessPath(path, validateHasBeenSet);
        _branch.SetAccessPath(path, validateHasBeenSet);
        _track.SetAccessPath(path, validateHasBeenSet);
    }

}

