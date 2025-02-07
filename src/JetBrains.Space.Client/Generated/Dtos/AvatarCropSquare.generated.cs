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

public sealed class AvatarCropSquare
     : IPropagatePropertyAccessPath
{
    public AvatarCropSquare() { }
    
    public AvatarCropSquare(int x, int y, int length)
    {
        X = x;
        Y = y;
        Length = length;
    }
    
    private PropertyValue<int> _x = new PropertyValue<int>(nameof(AvatarCropSquare), nameof(X));
    
    [Required]
    [JsonPropertyName("x")]
    public int X
    {
        get => _x.GetValue();
        set => _x.SetValue(value);
    }

    private PropertyValue<int> _y = new PropertyValue<int>(nameof(AvatarCropSquare), nameof(Y));
    
    [Required]
    [JsonPropertyName("y")]
    public int Y
    {
        get => _y.GetValue();
        set => _y.SetValue(value);
    }

    private PropertyValue<int> _length = new PropertyValue<int>(nameof(AvatarCropSquare), nameof(Length));
    
    [Required]
    [JsonPropertyName("length")]
    public int Length
    {
        get => _length.GetValue();
        set => _length.SetValue(value);
    }

    public  void SetAccessPath(string path, bool validateHasBeenSet)
    {
        _x.SetAccessPath(path, validateHasBeenSet);
        _y.SetAccessPath(path, validateHasBeenSet);
        _length.SetAccessPath(path, validateHasBeenSet);
    }

}

