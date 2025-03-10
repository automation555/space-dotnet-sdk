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

public sealed class UnfurlDetailsIssueTag
     : UnfurlDetails, IClassNameConvertible, IPropagatePropertyAccessPath
{
    [JsonPropertyName("className")]
    public  string? ClassName => "UnfurlDetailsIssueTag";
    
    public UnfurlDetailsIssueTag() { }
    
    public UnfurlDetailsIssueTag(PlanningTag tag, bool strikeThrough)
    {
        Tag = tag;
        IsStrikeThrough = strikeThrough;
    }
    
    private PropertyValue<PlanningTag> _tag = new PropertyValue<PlanningTag>(nameof(UnfurlDetailsIssueTag), nameof(Tag));
    
    [Required]
    [JsonPropertyName("tag")]
    public PlanningTag Tag
    {
        get => _tag.GetValue();
        set => _tag.SetValue(value);
    }

    private PropertyValue<bool> _strikeThrough = new PropertyValue<bool>(nameof(UnfurlDetailsIssueTag), nameof(IsStrikeThrough));
    
    [Required]
    [JsonPropertyName("strikeThrough")]
    public bool IsStrikeThrough
    {
        get => _strikeThrough.GetValue();
        set => _strikeThrough.SetValue(value);
    }

    public  void SetAccessPath(string path, bool validateHasBeenSet)
    {
        _tag.SetAccessPath(path, validateHasBeenSet);
        _strikeThrough.SetAccessPath(path, validateHasBeenSet);
    }

}

