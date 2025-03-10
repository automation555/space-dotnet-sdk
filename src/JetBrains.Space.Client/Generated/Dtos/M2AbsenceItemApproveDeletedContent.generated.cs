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

public sealed class M2AbsenceItemApproveDeletedContent
     : M2ItemContentDetails, IClassNameConvertible, IPropagatePropertyAccessPath
{
    [JsonPropertyName("className")]
    public  string? ClassName => "M2AbsenceItemApproveDeletedContent";
    
    public M2AbsenceItemApproveDeletedContent() { }
    
    public M2AbsenceItemApproveDeletedContent(AbsenceRecord absence, TDMemberProfile by, bool approve)
    {
        Absence = absence;
        By = by;
        IsApprove = approve;
    }
    
    private PropertyValue<AbsenceRecord> _absence = new PropertyValue<AbsenceRecord>(nameof(M2AbsenceItemApproveDeletedContent), nameof(Absence));
    
    [Required]
    [JsonPropertyName("absence")]
    public AbsenceRecord Absence
    {
        get => _absence.GetValue();
        set => _absence.SetValue(value);
    }

    private PropertyValue<TDMemberProfile> _by = new PropertyValue<TDMemberProfile>(nameof(M2AbsenceItemApproveDeletedContent), nameof(By));
    
    [Required]
    [JsonPropertyName("by")]
    public TDMemberProfile By
    {
        get => _by.GetValue();
        set => _by.SetValue(value);
    }

    private PropertyValue<bool> _approve = new PropertyValue<bool>(nameof(M2AbsenceItemApproveDeletedContent), nameof(IsApprove));
    
    [Required]
    [JsonPropertyName("approve")]
    public bool IsApprove
    {
        get => _approve.GetValue();
        set => _approve.SetValue(value);
    }

    public  void SetAccessPath(string path, bool validateHasBeenSet)
    {
        _absence.SetAccessPath(path, validateHasBeenSet);
        _by.SetAccessPath(path, validateHasBeenSet);
        _approve.SetAccessPath(path, validateHasBeenSet);
    }

}

