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

public sealed class M2MembershipCreatedContent
     : M2MembershipContent, IClassNameConvertible, IPropagatePropertyAccessPath
{
    [JsonPropertyName("className")]
    public override string? ClassName => "M2MembershipCreatedContent";
    
    public M2MembershipCreatedContent() { }
    
    public M2MembershipCreatedContent(TDMembership membership)
    {
        Membership = membership;
    }
    
    private PropertyValue<TDMembership> _membership = new PropertyValue<TDMembership>(nameof(M2MembershipCreatedContent), nameof(Membership));
    
    [Required]
    [JsonPropertyName("membership")]
    public TDMembership Membership
    {
        get => _membership.GetValue();
        set => _membership.SetValue(value);
    }

    public override void SetAccessPath(string path, bool validateHasBeenSet)
    {
        _membership.SetAccessPath(path, validateHasBeenSet);
    }

}

