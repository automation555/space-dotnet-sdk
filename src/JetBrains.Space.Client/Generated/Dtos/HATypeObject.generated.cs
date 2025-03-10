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

public sealed class HATypeObject
     : HAType, IClassNameConvertible, IPropagatePropertyAccessPath
{
    [JsonPropertyName("className")]
    public override string? ClassName => "HA_Type.Object";
    
    public HATypeObject() { }
    
    public HATypeObject(List<HAField> fields, HATypeObjectKind kind, bool nullable, List<string> tags)
    {
        Fields = fields;
        Kind = kind;
        IsNullable = nullable;
        Tags = tags;
    }
    
    private PropertyValue<List<HAField>> _fields = new PropertyValue<List<HAField>>(nameof(HATypeObject), nameof(Fields), new List<HAField>());
    
    [Required]
    [JsonPropertyName("fields")]
    public List<HAField> Fields
    {
        get => _fields.GetValue();
        set => _fields.SetValue(value);
    }

    private PropertyValue<HATypeObjectKind> _kind = new PropertyValue<HATypeObjectKind>(nameof(HATypeObject), nameof(Kind));
    
    [Required]
    [JsonPropertyName("kind")]
    public HATypeObjectKind Kind
    {
        get => _kind.GetValue();
        set => _kind.SetValue(value);
    }

    private PropertyValue<bool> _nullable = new PropertyValue<bool>(nameof(HATypeObject), nameof(IsNullable));
    
    [Required]
    [JsonPropertyName("nullable")]
    public bool IsNullable
    {
        get => _nullable.GetValue();
        set => _nullable.SetValue(value);
    }

    private PropertyValue<List<string>> _tags = new PropertyValue<List<string>>(nameof(HATypeObject), nameof(Tags), new List<string>());
    
    [Required]
    [JsonPropertyName("tags")]
    public List<string> Tags
    {
        get => _tags.GetValue();
        set => _tags.SetValue(value);
    }

    public override void SetAccessPath(string path, bool validateHasBeenSet)
    {
        _fields.SetAccessPath(path, validateHasBeenSet);
        _kind.SetAccessPath(path, validateHasBeenSet);
        _nullable.SetAccessPath(path, validateHasBeenSet);
        _tags.SetAccessPath(path, validateHasBeenSet);
    }

}

