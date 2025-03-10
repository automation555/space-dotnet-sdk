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

public sealed class EnumListCFInputValue
     : CFInputValue, IClassNameConvertible, IPropagatePropertyAccessPath
{
    [JsonPropertyName("className")]
    public  string? ClassName => "EnumListCFInputValue";
    
    public EnumListCFInputValue() { }
    
    public EnumListCFInputValue(List<CFEnumValueIdentifier> enumValueIdentifiers)
    {
        EnumValueIdentifiers = enumValueIdentifiers;
    }
    
    private PropertyValue<List<CFEnumValueIdentifier>> _enumValueIdentifiers = new PropertyValue<List<CFEnumValueIdentifier>>(nameof(EnumListCFInputValue), nameof(EnumValueIdentifiers), new List<CFEnumValueIdentifier>());
    
    [Required]
    [JsonPropertyName("enumValueIdentifiers")]
    public List<CFEnumValueIdentifier> EnumValueIdentifiers
    {
        get => _enumValueIdentifiers.GetValue();
        set => _enumValueIdentifiers.SetValue(value);
    }

    public  void SetAccessPath(string path, bool validateHasBeenSet)
    {
        _enumValueIdentifiers.SetAccessPath(path, validateHasBeenSet);
    }

}

