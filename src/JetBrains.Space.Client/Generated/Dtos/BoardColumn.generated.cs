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

public sealed class BoardColumn
     : IPropagatePropertyAccessPath
{
    public BoardColumn() { }
    
    public BoardColumn(string name, List<IssueStatus> statuses)
    {
        Name = name;
        Statuses = statuses;
    }
    
    private PropertyValue<string> _name = new PropertyValue<string>(nameof(BoardColumn), nameof(Name));
    
    [Required]
    [JsonPropertyName("name")]
    public string Name
    {
        get => _name.GetValue();
        set => _name.SetValue(value);
    }

    private PropertyValue<List<IssueStatus>> _statuses = new PropertyValue<List<IssueStatus>>(nameof(BoardColumn), nameof(Statuses), new List<IssueStatus>());
    
    [Required]
    [JsonPropertyName("statuses")]
    public List<IssueStatus> Statuses
    {
        get => _statuses.GetValue();
        set => _statuses.SetValue(value);
    }

    public  void SetAccessPath(string path, bool validateHasBeenSet)
    {
        _name.SetAccessPath(path, validateHasBeenSet);
        _statuses.SetAccessPath(path, validateHasBeenSet);
    }

}

