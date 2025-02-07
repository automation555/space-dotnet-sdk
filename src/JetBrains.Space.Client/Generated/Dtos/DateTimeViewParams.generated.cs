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

public sealed class DateTimeViewParams
     : IPropagatePropertyAccessPath
{
    public DateTimeViewParams() { }
    
    public DateTimeViewParams(UnfurlDateTimeFormat? format = null, UnfurlDateTimeStyle? style = null, string? template = null)
    {
        Format = format;
        Style = style;
        Template = template;
    }
    
    private PropertyValue<UnfurlDateTimeFormat?> _format = new PropertyValue<UnfurlDateTimeFormat?>(nameof(DateTimeViewParams), nameof(Format));
    
    [JsonPropertyName("format")]
    public UnfurlDateTimeFormat? Format
    {
        get => _format.GetValue();
        set => _format.SetValue(value);
    }

    private PropertyValue<UnfurlDateTimeStyle?> _style = new PropertyValue<UnfurlDateTimeStyle?>(nameof(DateTimeViewParams), nameof(Style));
    
    [JsonPropertyName("style")]
    public UnfurlDateTimeStyle? Style
    {
        get => _style.GetValue();
        set => _style.SetValue(value);
    }

    private PropertyValue<string?> _template = new PropertyValue<string?>(nameof(DateTimeViewParams), nameof(Template));
    
    [JsonPropertyName("template")]
    public string? Template
    {
        get => _template.GetValue();
        set => _template.SetValue(value);
    }

    public  void SetAccessPath(string path, bool validateHasBeenSet)
    {
        _format.SetAccessPath(path, validateHasBeenSet);
        _style.SetAccessPath(path, validateHasBeenSet);
        _template.SetAccessPath(path, validateHasBeenSet);
    }

}

