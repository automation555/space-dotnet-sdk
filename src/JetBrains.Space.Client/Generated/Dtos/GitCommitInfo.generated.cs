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

public sealed class GitCommitInfo
     : IPropagatePropertyAccessPath
{
    public GitCommitInfo() { }
    
    public GitCommitInfo(string id, string message, long authorDate, long commitDate, GitAuthorInfo author, GitAuthorInfo committer, List<string> parents, List<string> heads, TDMemberProfile? authorProfile = null, TDMemberProfile? committerProfile = null, GitCommitSignature? signature = null)
    {
        Id = id;
        Message = message;
        AuthorDate = authorDate;
        CommitDate = commitDate;
        Author = author;
        AuthorProfile = authorProfile;
        Committer = committer;
        CommitterProfile = committerProfile;
        Parents = parents;
        Heads = heads;
        Signature = signature;
    }
    
    private PropertyValue<string> _id = new PropertyValue<string>(nameof(GitCommitInfo), nameof(Id));
    
    [Required]
    [JsonPropertyName("id")]
    public string Id
    {
        get => _id.GetValue();
        set => _id.SetValue(value);
    }

    private PropertyValue<string> _message = new PropertyValue<string>(nameof(GitCommitInfo), nameof(Message));
    
    [Required]
    [JsonPropertyName("message")]
    public string Message
    {
        get => _message.GetValue();
        set => _message.SetValue(value);
    }

    private PropertyValue<long> _authorDate = new PropertyValue<long>(nameof(GitCommitInfo), nameof(AuthorDate));
    
    [Required]
    [JsonPropertyName("authorDate")]
    public long AuthorDate
    {
        get => _authorDate.GetValue();
        set => _authorDate.SetValue(value);
    }

    private PropertyValue<long> _commitDate = new PropertyValue<long>(nameof(GitCommitInfo), nameof(CommitDate));
    
    [Required]
    [JsonPropertyName("commitDate")]
    public long CommitDate
    {
        get => _commitDate.GetValue();
        set => _commitDate.SetValue(value);
    }

    private PropertyValue<GitAuthorInfo> _author = new PropertyValue<GitAuthorInfo>(nameof(GitCommitInfo), nameof(Author));
    
    [Required]
    [JsonPropertyName("author")]
    public GitAuthorInfo Author
    {
        get => _author.GetValue();
        set => _author.SetValue(value);
    }

    private PropertyValue<TDMemberProfile?> _authorProfile = new PropertyValue<TDMemberProfile?>(nameof(GitCommitInfo), nameof(AuthorProfile));
    
    [JsonPropertyName("authorProfile")]
    public TDMemberProfile? AuthorProfile
    {
        get => _authorProfile.GetValue();
        set => _authorProfile.SetValue(value);
    }

    private PropertyValue<GitAuthorInfo> _committer = new PropertyValue<GitAuthorInfo>(nameof(GitCommitInfo), nameof(Committer));
    
    [Required]
    [JsonPropertyName("committer")]
    public GitAuthorInfo Committer
    {
        get => _committer.GetValue();
        set => _committer.SetValue(value);
    }

    private PropertyValue<TDMemberProfile?> _committerProfile = new PropertyValue<TDMemberProfile?>(nameof(GitCommitInfo), nameof(CommitterProfile));
    
    [JsonPropertyName("committerProfile")]
    public TDMemberProfile? CommitterProfile
    {
        get => _committerProfile.GetValue();
        set => _committerProfile.SetValue(value);
    }

    private PropertyValue<List<string>> _parents = new PropertyValue<List<string>>(nameof(GitCommitInfo), nameof(Parents), new List<string>());
    
    [Required]
    [JsonPropertyName("parents")]
    public List<string> Parents
    {
        get => _parents.GetValue();
        set => _parents.SetValue(value);
    }

    private PropertyValue<List<string>> _heads = new PropertyValue<List<string>>(nameof(GitCommitInfo), nameof(Heads), new List<string>());
    
    [Required]
    [JsonPropertyName("heads")]
    public List<string> Heads
    {
        get => _heads.GetValue();
        set => _heads.SetValue(value);
    }

    private PropertyValue<GitCommitSignature?> _signature = new PropertyValue<GitCommitSignature?>(nameof(GitCommitInfo), nameof(Signature));
    
    [JsonPropertyName("signature")]
    public GitCommitSignature? Signature
    {
        get => _signature.GetValue();
        set => _signature.SetValue(value);
    }

    public  void SetAccessPath(string path, bool validateHasBeenSet)
    {
        _id.SetAccessPath(path, validateHasBeenSet);
        _message.SetAccessPath(path, validateHasBeenSet);
        _authorDate.SetAccessPath(path, validateHasBeenSet);
        _commitDate.SetAccessPath(path, validateHasBeenSet);
        _author.SetAccessPath(path, validateHasBeenSet);
        _authorProfile.SetAccessPath(path, validateHasBeenSet);
        _committer.SetAccessPath(path, validateHasBeenSet);
        _committerProfile.SetAccessPath(path, validateHasBeenSet);
        _parents.SetAccessPath(path, validateHasBeenSet);
        _heads.SetAccessPath(path, validateHasBeenSet);
        _signature.SetAccessPath(path, validateHasBeenSet);
    }

}

