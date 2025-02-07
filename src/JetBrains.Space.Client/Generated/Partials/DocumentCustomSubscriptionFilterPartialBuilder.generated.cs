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

namespace JetBrains.Space.Client.DocumentCustomSubscriptionFilterPartialBuilder;

public static class DocumentCustomSubscriptionFilterPartialExtensions
{
    public static Partial<DocumentCustomSubscriptionFilter> WithProject(this Partial<DocumentCustomSubscriptionFilter> it)
        => it.AddFieldName("project");
    
    public static Partial<DocumentCustomSubscriptionFilter> WithProject(this Partial<DocumentCustomSubscriptionFilter> it, Func<Partial<PRProject>, Partial<PRProject>> partialBuilder)
        => it.AddFieldName("project", partialBuilder(new Partial<PRProject>(it)));
    
    public static Partial<DocumentCustomSubscriptionFilter> WithBooks(this Partial<DocumentCustomSubscriptionFilter> it)
        => it.AddFieldName("books");
    
    public static Partial<DocumentCustomSubscriptionFilter> WithBooks(this Partial<DocumentCustomSubscriptionFilter> it, Func<Partial<KBBook>, Partial<KBBook>> partialBuilder)
        => it.AddFieldName("books", partialBuilder(new Partial<KBBook>(it)));
    
    public static Partial<DocumentCustomSubscriptionFilter> WithFolders(this Partial<DocumentCustomSubscriptionFilter> it)
        => it.AddFieldName("folders");
    
    public static Partial<DocumentCustomSubscriptionFilter> WithFolders(this Partial<DocumentCustomSubscriptionFilter> it, Func<Partial<KbFolderItem>, Partial<KbFolderItem>> partialBuilder)
        => it.AddFieldName("folders", partialBuilder(new Partial<KbFolderItem>(it)));
    
    public static Partial<DocumentCustomSubscriptionFilter> WithDocuments(this Partial<DocumentCustomSubscriptionFilter> it)
        => it.AddFieldName("documents");
    
    public static Partial<DocumentCustomSubscriptionFilter> WithDocuments(this Partial<DocumentCustomSubscriptionFilter> it, Func<Partial<KbDocumentItem>, Partial<KbDocumentItem>> partialBuilder)
        => it.AddFieldName("documents", partialBuilder(new Partial<KbDocumentItem>(it)));
    
}

