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

public sealed class RepositoryActivity
     : IPropagatePropertyAccessPath
{
    public RepositoryActivity() { }
    
    public RepositoryActivity(List<Pair<DateTime, int>> lastActivity)
    {
        LastActivity = lastActivity;
    }
    
    private PropertyValue<List<Pair<DateTime, int>>> _lastActivity = new PropertyValue<List<Pair<DateTime, int>>>(nameof(RepositoryActivity), nameof(LastActivity), new List<Pair<DateTime, int>>());
    
    [Required]
    [JsonPropertyName("lastActivity")]
    public List<Pair<DateTime, int>> LastActivity
    {
        get => _lastActivity.GetValue();
        set => _lastActivity.SetValue(value);
    }

    public  void SetAccessPath(string path, bool validateHasBeenSet)
    {
        _lastActivity.SetAccessPath(path, validateHasBeenSet);
    }

}

