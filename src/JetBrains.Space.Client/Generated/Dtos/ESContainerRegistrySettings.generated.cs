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

public sealed class ESContainerRegistrySettings
     : ESPackageRepositorySettings, IClassNameConvertible, IPropagatePropertyAccessPath
{
    [JsonPropertyName("className")]
    public override string? ClassName => "ES_ContainerRegistrySettings";
    
    public ESContainerRegistrySettings() { }
    
    public ESContainerRegistrySettings(bool immutableTags, RetentionPolicyParams? retentionPolicyParams = null, bool? immutablePackageVersions = null)
    {
        IsImmutableTags = immutableTags;
        RetentionPolicyParams = retentionPolicyParams;
        IsImmutablePackageVersions = immutablePackageVersions;
    }
    
    private PropertyValue<bool> _immutableTags = new PropertyValue<bool>(nameof(ESContainerRegistrySettings), nameof(IsImmutableTags));
    
    [Required]
    [JsonPropertyName("immutableTags")]
    public bool IsImmutableTags
    {
        get => _immutableTags.GetValue();
        set => _immutableTags.SetValue(value);
    }

    private PropertyValue<RetentionPolicyParams?> _retentionPolicyParams = new PropertyValue<RetentionPolicyParams?>(nameof(ESContainerRegistrySettings), nameof(RetentionPolicyParams));
    
    [JsonPropertyName("retentionPolicyParams")]
    public RetentionPolicyParams? RetentionPolicyParams
    {
        get => _retentionPolicyParams.GetValue();
        set => _retentionPolicyParams.SetValue(value);
    }

    private PropertyValue<bool?> _immutablePackageVersions = new PropertyValue<bool?>(nameof(ESContainerRegistrySettings), nameof(IsImmutablePackageVersions));
    
    [JsonPropertyName("immutablePackageVersions")]
    public bool? IsImmutablePackageVersions
    {
        get => _immutablePackageVersions.GetValue();
        set => _immutablePackageVersions.SetValue(value);
    }

    public override void SetAccessPath(string path, bool validateHasBeenSet)
    {
        _immutableTags.SetAccessPath(path, validateHasBeenSet);
        _retentionPolicyParams.SetAccessPath(path, validateHasBeenSet);
        _immutablePackageVersions.SetAccessPath(path, validateHasBeenSet);
    }

}

