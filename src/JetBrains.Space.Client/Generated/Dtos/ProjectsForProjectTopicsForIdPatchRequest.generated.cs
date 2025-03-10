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

public class ProjectsForProjectTopicsForIdPatchRequest
     : IPropagatePropertyAccessPath
{
    public ProjectsForProjectTopicsForIdPatchRequest() { }
    
    public ProjectsForProjectTopicsForIdPatchRequest(string? name = null, string? parentTopicId = null)
    {
        Name = (name ?? string.Empty);
        ParentTopicId = parentTopicId;
    }
    
    private PropertyValue<string> _name = new PropertyValue<string>(nameof(ProjectsForProjectTopicsForIdPatchRequest), nameof(Name), string.Empty);
    
    [JsonPropertyName("name")]
    public string Name
    {
        get => _name.GetValue();
        set => _name.SetValue(value);
    }

    private PropertyValue<string?> _parentTopicId = new PropertyValue<string?>(nameof(ProjectsForProjectTopicsForIdPatchRequest), nameof(ParentTopicId));
    
    [JsonPropertyName("parentTopicId")]
    public string? ParentTopicId
    {
        get => _parentTopicId.GetValue();
        set => _parentTopicId.SetValue(value);
    }

    public virtual void SetAccessPath(string path, bool validateHasBeenSet)
    {
        _name.SetAccessPath(path, validateHasBeenSet);
        _parentTopicId.SetAccessPath(path, validateHasBeenSet);
    }

}

