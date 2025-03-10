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

public sealed class HttpHeader
     : IPropagatePropertyAccessPath
{
    public HttpHeader() { }
    
    public HttpHeader(string name, bool maskedValue, List<string> values)
    {
        Name = name;
        IsMaskedValue = maskedValue;
        Values = values;
    }
    
    private PropertyValue<string> _name = new PropertyValue<string>(nameof(HttpHeader), nameof(Name));
    
    [Required]
    [JsonPropertyName("name")]
    public string Name
    {
        get => _name.GetValue();
        set => _name.SetValue(value);
    }

    private PropertyValue<bool> _maskedValue = new PropertyValue<bool>(nameof(HttpHeader), nameof(IsMaskedValue));
    
    [Required]
    [JsonPropertyName("maskedValue")]
    public bool IsMaskedValue
    {
        get => _maskedValue.GetValue();
        set => _maskedValue.SetValue(value);
    }

    private PropertyValue<List<string>> _values = new PropertyValue<List<string>>(nameof(HttpHeader), nameof(Values), new List<string>());
    
    [Required]
    [JsonPropertyName("values")]
    public List<string> Values
    {
        get => _values.GetValue();
        set => _values.SetValue(value);
    }

    public  void SetAccessPath(string path, bool validateHasBeenSet)
    {
        _name.SetAccessPath(path, validateHasBeenSet);
        _maskedValue.SetAccessPath(path, validateHasBeenSet);
        _values.SetAccessPath(path, validateHasBeenSet);
    }

}

