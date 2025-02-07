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

public sealed class GitFile
     : IPropagatePropertyAccessPath
{
    public GitFile() { }
    
    public GitFile(string commit, string path, string blob, GitEntryType type)
    {
        Commit = commit;
        Path = path;
        Blob = blob;
        Type = type;
    }
    
    private PropertyValue<string> _commit = new PropertyValue<string>(nameof(GitFile), nameof(Commit));
    
    [Required]
    [JsonPropertyName("commit")]
    public string Commit
    {
        get => _commit.GetValue();
        set => _commit.SetValue(value);
    }

    private PropertyValue<string> _path = new PropertyValue<string>(nameof(GitFile), nameof(Path));
    
    [Required]
    [JsonPropertyName("path")]
    public string Path
    {
        get => _path.GetValue();
        set => _path.SetValue(value);
    }

    private PropertyValue<string> _blob = new PropertyValue<string>(nameof(GitFile), nameof(Blob));
    
    [Required]
    [JsonPropertyName("blob")]
    public string Blob
    {
        get => _blob.GetValue();
        set => _blob.SetValue(value);
    }

    private PropertyValue<GitEntryType> _type = new PropertyValue<GitEntryType>(nameof(GitFile), nameof(Type));
    
    [Required]
    [JsonPropertyName("type")]
    public GitEntryType Type
    {
        get => _type.GetValue();
        set => _type.SetValue(value);
    }

    public  void SetAccessPath(string path, bool validateHasBeenSet)
    {
        _commit.SetAccessPath(path, validateHasBeenSet);
        _path.SetAccessPath(path, validateHasBeenSet);
        _blob.SetAccessPath(path, validateHasBeenSet);
        _type.SetAccessPath(path, validateHasBeenSet);
    }

}

