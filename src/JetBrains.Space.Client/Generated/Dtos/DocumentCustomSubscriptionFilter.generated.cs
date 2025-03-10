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

public sealed class DocumentCustomSubscriptionFilter
     : SubscriptionFilter, IClassNameConvertible, IPropagatePropertyAccessPath
{
    [JsonPropertyName("className")]
    public  string? ClassName => "DocumentCustomSubscriptionFilter";
    
    public DocumentCustomSubscriptionFilter() { }
    
    public DocumentCustomSubscriptionFilter(List<KbDocumentItem> documents, PRProject? project = null, List<KBBook>? books = null, List<KbFolderItem>? folders = null)
    {
        Project = project;
        Books = books;
        Folders = folders;
        Documents = documents;
    }
    
    private PropertyValue<PRProject?> _project = new PropertyValue<PRProject?>(nameof(DocumentCustomSubscriptionFilter), nameof(Project));
    
    [JsonPropertyName("project")]
    public PRProject? Project
    {
        get => _project.GetValue();
        set => _project.SetValue(value);
    }

    private PropertyValue<List<KBBook>?> _books = new PropertyValue<List<KBBook>?>(nameof(DocumentCustomSubscriptionFilter), nameof(Books));
    
    [JsonPropertyName("books")]
    public List<KBBook>? Books
    {
        get => _books.GetValue();
        set => _books.SetValue(value);
    }

    private PropertyValue<List<KbFolderItem>?> _folders = new PropertyValue<List<KbFolderItem>?>(nameof(DocumentCustomSubscriptionFilter), nameof(Folders));
    
    [JsonPropertyName("folders")]
    public List<KbFolderItem>? Folders
    {
        get => _folders.GetValue();
        set => _folders.SetValue(value);
    }

    private PropertyValue<List<KbDocumentItem>> _documents = new PropertyValue<List<KbDocumentItem>>(nameof(DocumentCustomSubscriptionFilter), nameof(Documents), new List<KbDocumentItem>());
    
    [Required]
    [JsonPropertyName("documents")]
    public List<KbDocumentItem> Documents
    {
        get => _documents.GetValue();
        set => _documents.SetValue(value);
    }

    public  void SetAccessPath(string path, bool validateHasBeenSet)
    {
        _project.SetAccessPath(path, validateHasBeenSet);
        _books.SetAccessPath(path, validateHasBeenSet);
        _folders.SetAccessPath(path, validateHasBeenSet);
        _documents.SetAccessPath(path, validateHasBeenSet);
    }

}

