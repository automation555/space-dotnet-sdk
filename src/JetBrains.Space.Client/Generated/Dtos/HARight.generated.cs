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

public sealed class HARight
     : IPropagatePropertyAccessPath
{
    public HARight() { }
    
    public HARight(string title, string? description = null)
    {
        Title = title;
        Description = description;
    }
    
    private PropertyValue<string> _title = new PropertyValue<string>(nameof(HARight), nameof(Title));
    
    [Required]
    [JsonPropertyName("title")]
    public string Title
    {
        get => _title.GetValue();
        set => _title.SetValue(value);
    }

    private PropertyValue<string?> _description = new PropertyValue<string?>(nameof(HARight), nameof(Description));
    
    [JsonPropertyName("description")]
    public string? Description
    {
        get => _description.GetValue();
        set => _description.SetValue(value);
    }

    public  void SetAccessPath(string path, bool validateHasBeenSet)
    {
        _title.SetAccessPath(path, validateHasBeenSet);
        _description.SetAccessPath(path, validateHasBeenSet);
    }

}

