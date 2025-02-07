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

public sealed class MavenChecksum
     : IPropagatePropertyAccessPath
{
    public MavenChecksum() { }
    
    public MavenChecksum(string algorithm, string value)
    {
        Algorithm = algorithm;
        Value = value;
    }
    
    private PropertyValue<string> _algorithm = new PropertyValue<string>(nameof(MavenChecksum), nameof(Algorithm));
    
    [Required]
    [JsonPropertyName("algorithm")]
    public string Algorithm
    {
        get => _algorithm.GetValue();
        set => _algorithm.SetValue(value);
    }

    private PropertyValue<string> _value = new PropertyValue<string>(nameof(MavenChecksum), nameof(Value));
    
    [Required]
    [JsonPropertyName("value")]
    public string Value
    {
        get => _value.GetValue();
        set => _value.SetValue(value);
    }

    public  void SetAccessPath(string path, bool validateHasBeenSet)
    {
        _algorithm.SetAccessPath(path, validateHasBeenSet);
        _value.SetAccessPath(path, validateHasBeenSet);
    }

}

