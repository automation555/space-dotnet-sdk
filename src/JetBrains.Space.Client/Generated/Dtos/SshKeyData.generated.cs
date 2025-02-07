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

public sealed class SshKeyData
     : IPropagatePropertyAccessPath
{
    public SshKeyData() { }
    
    public SshKeyData(string fingerprint, string publicKey, string comment, DateTime? lastUsed = null, string? lastResource = null)
    {
        Fingerprint = fingerprint;
        PublicKey = publicKey;
        Comment = comment;
        LastUsed = lastUsed;
        LastResource = lastResource;
    }
    
    private PropertyValue<string> _fingerprint = new PropertyValue<string>(nameof(SshKeyData), nameof(Fingerprint));
    
    [Required]
    [JsonPropertyName("fingerprint")]
    public string Fingerprint
    {
        get => _fingerprint.GetValue();
        set => _fingerprint.SetValue(value);
    }

    private PropertyValue<string> _publicKey = new PropertyValue<string>(nameof(SshKeyData), nameof(PublicKey));
    
    [Required]
    [JsonPropertyName("publicKey")]
    public string PublicKey
    {
        get => _publicKey.GetValue();
        set => _publicKey.SetValue(value);
    }

    private PropertyValue<string> _comment = new PropertyValue<string>(nameof(SshKeyData), nameof(Comment));
    
    [Required]
    [JsonPropertyName("comment")]
    public string Comment
    {
        get => _comment.GetValue();
        set => _comment.SetValue(value);
    }

    private PropertyValue<DateTime?> _lastUsed = new PropertyValue<DateTime?>(nameof(SshKeyData), nameof(LastUsed));
    
    [JsonPropertyName("lastUsed")]
    [JsonConverter(typeof(SpaceDateTimeConverter))]
    public DateTime? LastUsed
    {
        get => _lastUsed.GetValue();
        set => _lastUsed.SetValue(value);
    }

    private PropertyValue<string?> _lastResource = new PropertyValue<string?>(nameof(SshKeyData), nameof(LastResource));
    
    [JsonPropertyName("lastResource")]
    public string? LastResource
    {
        get => _lastResource.GetValue();
        set => _lastResource.SetValue(value);
    }

    public  void SetAccessPath(string path, bool validateHasBeenSet)
    {
        _fingerprint.SetAccessPath(path, validateHasBeenSet);
        _publicKey.SetAccessPath(path, validateHasBeenSet);
        _comment.SetAccessPath(path, validateHasBeenSet);
        _lastUsed.SetAccessPath(path, validateHasBeenSet);
        _lastResource.SetAccessPath(path, validateHasBeenSet);
    }

}

