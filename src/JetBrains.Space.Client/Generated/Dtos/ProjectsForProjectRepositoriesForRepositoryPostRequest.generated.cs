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

public class ProjectsForProjectRepositoriesForRepositoryPostRequest
     : IPropagatePropertyAccessPath
{
    public ProjectsForProjectRepositoriesForRepositoryPostRequest() { }
    
    public ProjectsForProjectRepositoriesForRepositoryPostRequest(string description = "", bool initialize = true, bool defaultSetup = false, string? defaultBranch = null)
    {
        Description = description;
        DefaultBranch = defaultBranch;
        IsInitialize = initialize;
        IsDefaultSetup = defaultSetup;
    }
    
    private PropertyValue<string> _description = new PropertyValue<string>(nameof(ProjectsForProjectRepositoriesForRepositoryPostRequest), nameof(Description));
    
    [JsonPropertyName("description")]
    public string Description
    {
        get => _description.GetValue();
        set => _description.SetValue(value);
    }

    private PropertyValue<string?> _defaultBranch = new PropertyValue<string?>(nameof(ProjectsForProjectRepositoriesForRepositoryPostRequest), nameof(DefaultBranch));
    
    [JsonPropertyName("defaultBranch")]
    public string? DefaultBranch
    {
        get => _defaultBranch.GetValue();
        set => _defaultBranch.SetValue(value);
    }

    private PropertyValue<bool> _initialize = new PropertyValue<bool>(nameof(ProjectsForProjectRepositoriesForRepositoryPostRequest), nameof(IsInitialize));
    
    [JsonPropertyName("initialize")]
    public bool IsInitialize
    {
        get => _initialize.GetValue();
        set => _initialize.SetValue(value);
    }

    private PropertyValue<bool> _defaultSetup = new PropertyValue<bool>(nameof(ProjectsForProjectRepositoriesForRepositoryPostRequest), nameof(IsDefaultSetup));
    
    [JsonPropertyName("defaultSetup")]
    public bool IsDefaultSetup
    {
        get => _defaultSetup.GetValue();
        set => _defaultSetup.SetValue(value);
    }

    public virtual void SetAccessPath(string path, bool validateHasBeenSet)
    {
        _description.SetAccessPath(path, validateHasBeenSet);
        _defaultBranch.SetAccessPath(path, validateHasBeenSet);
        _initialize.SetAccessPath(path, validateHasBeenSet);
        _defaultSetup.SetAccessPath(path, validateHasBeenSet);
    }

}

