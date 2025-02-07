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

public class ApplicationsForApplicationAuthorizationsAuthorizedRightsPatchRequest
     : IPropagatePropertyAccessPath
{
    public ApplicationsForApplicationAuthorizationsAuthorizedRightsPatchRequest() { }
    
    public ApplicationsForApplicationAuthorizationsAuthorizedRightsPatchRequest(PermissionContextIdentifier contextIdentifier, List<RightUpdate> updates)
    {
        ContextIdentifier = contextIdentifier;
        Updates = updates;
    }
    
    private PropertyValue<PermissionContextIdentifier> _contextIdentifier = new PropertyValue<PermissionContextIdentifier>(nameof(ApplicationsForApplicationAuthorizationsAuthorizedRightsPatchRequest), nameof(ContextIdentifier));
    
    [Required]
    [JsonPropertyName("contextIdentifier")]
    public PermissionContextIdentifier ContextIdentifier
    {
        get => _contextIdentifier.GetValue();
        set => _contextIdentifier.SetValue(value);
    }

    private PropertyValue<List<RightUpdate>> _updates = new PropertyValue<List<RightUpdate>>(nameof(ApplicationsForApplicationAuthorizationsAuthorizedRightsPatchRequest), nameof(Updates), new List<RightUpdate>());
    
    [Required]
    [JsonPropertyName("updates")]
    public List<RightUpdate> Updates
    {
        get => _updates.GetValue();
        set => _updates.SetValue(value);
    }

    public virtual void SetAccessPath(string path, bool validateHasBeenSet)
    {
        _contextIdentifier.SetAccessPath(path, validateHasBeenSet);
        _updates.SetAccessPath(path, validateHasBeenSet);
    }

}

