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

public class ProjectsForProjectPlanningTagsPostRequest
     : IPropagatePropertyAccessPath
{
    public ProjectsForProjectPlanningTagsPostRequest() { }
    
    public ProjectsForProjectPlanningTagsPostRequest(List<string> path, string? parentTagId = null)
    {
        ParentTagId = parentTagId;
        Path = path;
    }
    
    private PropertyValue<string?> _parentTagId = new PropertyValue<string?>(nameof(ProjectsForProjectPlanningTagsPostRequest), nameof(ParentTagId));
    
    [JsonPropertyName("parentTagId")]
    public string? ParentTagId
    {
        get => _parentTagId.GetValue();
        set => _parentTagId.SetValue(value);
    }

    private PropertyValue<List<string>> _path = new PropertyValue<List<string>>(nameof(ProjectsForProjectPlanningTagsPostRequest), nameof(Path), new List<string>());
    
    [Required]
    [JsonPropertyName("path")]
    public List<string> Path
    {
        get => _path.GetValue();
        set => _path.SetValue(value);
    }

    public virtual void SetAccessPath(string path, bool validateHasBeenSet)
    {
        _parentTagId.SetAccessPath(path, validateHasBeenSet);
        _path.SetAccessPath(path, validateHasBeenSet);
    }

}

