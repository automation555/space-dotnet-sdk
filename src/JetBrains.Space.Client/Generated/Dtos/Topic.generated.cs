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

public sealed class Topic
     : IPropagatePropertyAccessPath
{
    public Topic() { }
    
    public Topic(string id, bool archived, string name, List<TDMemberProfile> responsible, Topic? parent = null, PRProject? project = null)
    {
        Id = id;
        IsArchived = archived;
        Name = name;
        Parent = parent;
        Project = project;
        Responsible = responsible;
    }
    
    private PropertyValue<string> _id = new PropertyValue<string>(nameof(Topic), nameof(Id));
    
    [Required]
    [JsonPropertyName("id")]
    public string Id
    {
        get => _id.GetValue();
        set => _id.SetValue(value);
    }

    private PropertyValue<bool> _archived = new PropertyValue<bool>(nameof(Topic), nameof(IsArchived));
    
    [Required]
    [JsonPropertyName("archived")]
    public bool IsArchived
    {
        get => _archived.GetValue();
        set => _archived.SetValue(value);
    }

    private PropertyValue<string> _name = new PropertyValue<string>(nameof(Topic), nameof(Name));
    
    [Required]
    [JsonPropertyName("name")]
    public string Name
    {
        get => _name.GetValue();
        set => _name.SetValue(value);
    }

    private PropertyValue<Topic?> _parent = new PropertyValue<Topic?>(nameof(Topic), nameof(Parent));
    
    [JsonPropertyName("parent")]
    public Topic? Parent
    {
        get => _parent.GetValue();
        set => _parent.SetValue(value);
    }

    private PropertyValue<PRProject?> _project = new PropertyValue<PRProject?>(nameof(Topic), nameof(Project));
    
    [JsonPropertyName("project")]
    public PRProject? Project
    {
        get => _project.GetValue();
        set => _project.SetValue(value);
    }

    private PropertyValue<List<TDMemberProfile>> _responsible = new PropertyValue<List<TDMemberProfile>>(nameof(Topic), nameof(Responsible), new List<TDMemberProfile>());
    
    [Required]
    [JsonPropertyName("responsible")]
    public List<TDMemberProfile> Responsible
    {
        get => _responsible.GetValue();
        set => _responsible.SetValue(value);
    }

    public  void SetAccessPath(string path, bool validateHasBeenSet)
    {
        _id.SetAccessPath(path, validateHasBeenSet);
        _archived.SetAccessPath(path, validateHasBeenSet);
        _name.SetAccessPath(path, validateHasBeenSet);
        _parent.SetAccessPath(path, validateHasBeenSet);
        _project.SetAccessPath(path, validateHasBeenSet);
        _responsible.SetAccessPath(path, validateHasBeenSet);
    }

}

