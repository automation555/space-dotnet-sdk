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

public class PermissionsCheckPermissionPostRequest
     : IPropagatePropertyAccessPath
{
    public PermissionsCheckPermissionPostRequest() { }
    
    public PermissionsCheckPermissionPostRequest(PrincipalIn principal, string uniqueRightCode, PermissionTarget target)
    {
        Principal = principal;
        UniqueRightCode = uniqueRightCode;
        Target = target;
    }
    
    private PropertyValue<PrincipalIn> _principal = new PropertyValue<PrincipalIn>(nameof(PermissionsCheckPermissionPostRequest), nameof(Principal));
    
    [Required]
    [JsonPropertyName("principal")]
    public PrincipalIn Principal
    {
        get => _principal.GetValue();
        set => _principal.SetValue(value);
    }

    private PropertyValue<string> _uniqueRightCode = new PropertyValue<string>(nameof(PermissionsCheckPermissionPostRequest), nameof(UniqueRightCode));
    
    [Required]
    [JsonPropertyName("uniqueRightCode")]
    public string UniqueRightCode
    {
        get => _uniqueRightCode.GetValue();
        set => _uniqueRightCode.SetValue(value);
    }

    private PropertyValue<PermissionTarget> _target = new PropertyValue<PermissionTarget>(nameof(PermissionsCheckPermissionPostRequest), nameof(Target));
    
    [Required]
    [JsonPropertyName("target")]
    public PermissionTarget Target
    {
        get => _target.GetValue();
        set => _target.SetValue(value);
    }

    public virtual void SetAccessPath(string path, bool validateHasBeenSet)
    {
        _principal.SetAccessPath(path, validateHasBeenSet);
        _uniqueRightCode.SetAccessPath(path, validateHasBeenSet);
        _target.SetAccessPath(path, validateHasBeenSet);
    }

}

