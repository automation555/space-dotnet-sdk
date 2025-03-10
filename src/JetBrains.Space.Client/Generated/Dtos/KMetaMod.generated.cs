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

public sealed class KMetaMod
     : IPropagatePropertyAccessPath
{
    public KMetaMod() { }
    
    public KMetaMod(CPrincipal principal, DateTime timestamp, string method)
    {
        Principal = principal;
        Timestamp = timestamp;
        Method = method;
    }
    
    private PropertyValue<CPrincipal> _principal = new PropertyValue<CPrincipal>(nameof(KMetaMod), nameof(Principal));
    
    [Required]
    [JsonPropertyName("principal")]
    public CPrincipal Principal
    {
        get => _principal.GetValue();
        set => _principal.SetValue(value);
    }

    private PropertyValue<DateTime> _timestamp = new PropertyValue<DateTime>(nameof(KMetaMod), nameof(Timestamp));
    
    [Required]
    [JsonPropertyName("timestamp")]
    [JsonConverter(typeof(SpaceDateTimeConverter))]
    public DateTime Timestamp
    {
        get => _timestamp.GetValue();
        set => _timestamp.SetValue(value);
    }

    private PropertyValue<string> _method = new PropertyValue<string>(nameof(KMetaMod), nameof(Method));
    
    [Required]
    [JsonPropertyName("method")]
    public string Method
    {
        get => _method.GetValue();
        set => _method.SetValue(value);
    }

    public  void SetAccessPath(string path, bool validateHasBeenSet)
    {
        _principal.SetAccessPath(path, validateHasBeenSet);
        _timestamp.SetAccessPath(path, validateHasBeenSet);
        _method.SetAccessPath(path, validateHasBeenSet);
    }

}

