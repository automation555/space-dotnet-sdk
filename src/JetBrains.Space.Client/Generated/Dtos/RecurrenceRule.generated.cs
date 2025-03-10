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

public sealed class RecurrenceRule
     : IPropagatePropertyAccessPath
{
    public RecurrenceRule() { }
    
    public RecurrenceRule(RecurrenceRuleFreq freq, RecurrenceRuleEnds ends)
    {
        Freq = freq;
        Ends = ends;
    }
    
    private PropertyValue<RecurrenceRuleFreq> _freq = new PropertyValue<RecurrenceRuleFreq>(nameof(RecurrenceRule), nameof(Freq));
    
    [Required]
    [JsonPropertyName("freq")]
    public RecurrenceRuleFreq Freq
    {
        get => _freq.GetValue();
        set => _freq.SetValue(value);
    }

    private PropertyValue<RecurrenceRuleEnds> _ends = new PropertyValue<RecurrenceRuleEnds>(nameof(RecurrenceRule), nameof(Ends));
    
    [Required]
    [JsonPropertyName("ends")]
    public RecurrenceRuleEnds Ends
    {
        get => _ends.GetValue();
        set => _ends.SetValue(value);
    }

    public  void SetAccessPath(string path, bool validateHasBeenSet)
    {
        _freq.SetAccessPath(path, validateHasBeenSet);
        _ends.SetAccessPath(path, validateHasBeenSet);
    }

}

