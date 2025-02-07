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

public sealed class ProjectTeamMemberRecord
     : IPropagatePropertyAccessPath
{
    public ProjectTeamMemberRecord() { }
    
    public ProjectTeamMemberRecord(string id, PRProject project, TDMemberProfile profile, DateTime since, bool archived, TDRole? position = null)
    {
        Id = id;
        Project = project;
        Profile = profile;
        Position = position;
        Since = since;
        IsArchived = archived;
    }
    
    private PropertyValue<string> _id = new PropertyValue<string>(nameof(ProjectTeamMemberRecord), nameof(Id));
    
    [Required]
    [JsonPropertyName("id")]
    public string Id
    {
        get => _id.GetValue();
        set => _id.SetValue(value);
    }

    private PropertyValue<PRProject> _project = new PropertyValue<PRProject>(nameof(ProjectTeamMemberRecord), nameof(Project));
    
    [Required]
    [JsonPropertyName("project")]
    public PRProject Project
    {
        get => _project.GetValue();
        set => _project.SetValue(value);
    }

    private PropertyValue<TDMemberProfile> _profile = new PropertyValue<TDMemberProfile>(nameof(ProjectTeamMemberRecord), nameof(Profile));
    
    [Required]
    [JsonPropertyName("profile")]
    public TDMemberProfile Profile
    {
        get => _profile.GetValue();
        set => _profile.SetValue(value);
    }

    private PropertyValue<TDRole?> _position = new PropertyValue<TDRole?>(nameof(ProjectTeamMemberRecord), nameof(Position));
    
    [JsonPropertyName("position")]
    public TDRole? Position
    {
        get => _position.GetValue();
        set => _position.SetValue(value);
    }

    private PropertyValue<DateTime> _since = new PropertyValue<DateTime>(nameof(ProjectTeamMemberRecord), nameof(Since));
    
    [Required]
    [JsonPropertyName("since")]
    [JsonConverter(typeof(SpaceDateTimeConverter))]
    public DateTime Since
    {
        get => _since.GetValue();
        set => _since.SetValue(value);
    }

    private PropertyValue<bool> _archived = new PropertyValue<bool>(nameof(ProjectTeamMemberRecord), nameof(IsArchived));
    
    [Required]
    [JsonPropertyName("archived")]
    public bool IsArchived
    {
        get => _archived.GetValue();
        set => _archived.SetValue(value);
    }

    public  void SetAccessPath(string path, bool validateHasBeenSet)
    {
        _id.SetAccessPath(path, validateHasBeenSet);
        _project.SetAccessPath(path, validateHasBeenSet);
        _profile.SetAccessPath(path, validateHasBeenSet);
        _position.SetAccessPath(path, validateHasBeenSet);
        _since.SetAccessPath(path, validateHasBeenSet);
        _archived.SetAccessPath(path, validateHasBeenSet);
    }

}

