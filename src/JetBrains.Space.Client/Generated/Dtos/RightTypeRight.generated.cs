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

public sealed class RightTypeRight
     : IPropagatePropertyAccessPath
{
    public RightTypeRight() { }
    
    public RightTypeRight(RightType rightType, List<FullRightWithoutType> rights)
    {
        RightType = rightType;
        Rights = rights;
    }
    
    private PropertyValue<RightType> _rightType = new PropertyValue<RightType>(nameof(RightTypeRight), nameof(RightType));
    
    [Required]
    [JsonPropertyName("rightType")]
    public RightType RightType
    {
        get => _rightType.GetValue();
        set => _rightType.SetValue(value);
    }

    private PropertyValue<List<FullRightWithoutType>> _rights = new PropertyValue<List<FullRightWithoutType>>(nameof(RightTypeRight), nameof(Rights), new List<FullRightWithoutType>());
    
    [Required]
    [JsonPropertyName("rights")]
    public List<FullRightWithoutType> Rights
    {
        get => _rights.GetValue();
        set => _rights.SetValue(value);
    }

    public  void SetAccessPath(string path, bool validateHasBeenSet)
    {
        _rightType.SetAccessPath(path, validateHasBeenSet);
        _rights.SetAccessPath(path, validateHasBeenSet);
    }

}

