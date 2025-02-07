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

public sealed class KbFolderItem
     : IPropagatePropertyAccessPath
{
    public KbFolderItem() { }
    
    public KbFolderItem(KBBook book, string id, string name, List<string> path)
    {
        Book = book;
        Id = id;
        Name = name;
        Path = path;
    }
    
    private PropertyValue<KBBook> _book = new PropertyValue<KBBook>(nameof(KbFolderItem), nameof(Book));
    
    [Required]
    [JsonPropertyName("book")]
    public KBBook Book
    {
        get => _book.GetValue();
        set => _book.SetValue(value);
    }

    private PropertyValue<string> _id = new PropertyValue<string>(nameof(KbFolderItem), nameof(Id));
    
    [Required]
    [JsonPropertyName("id")]
    public string Id
    {
        get => _id.GetValue();
        set => _id.SetValue(value);
    }

    private PropertyValue<string> _name = new PropertyValue<string>(nameof(KbFolderItem), nameof(Name));
    
    [Required]
    [JsonPropertyName("name")]
    public string Name
    {
        get => _name.GetValue();
        set => _name.SetValue(value);
    }

    private PropertyValue<List<string>> _path = new PropertyValue<List<string>>(nameof(KbFolderItem), nameof(Path), new List<string>());
    
    [Required]
    [JsonPropertyName("path")]
    public List<string> Path
    {
        get => _path.GetValue();
        set => _path.SetValue(value);
    }

    public  void SetAccessPath(string path, bool validateHasBeenSet)
    {
        _book.SetAccessPath(path, validateHasBeenSet);
        _id.SetAccessPath(path, validateHasBeenSet);
        _name.SetAccessPath(path, validateHasBeenSet);
        _path.SetAccessPath(path, validateHasBeenSet);
    }

}

