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

namespace JetBrains.Space.Client.DocumentWebhookEventPartialBuilder;

public static class DocumentWebhookEventPartialExtensions
{
    public static Partial<DocumentWebhookEvent> WithMeta(this Partial<DocumentWebhookEvent> it)
        => it.AddFieldName("meta");
    
    public static Partial<DocumentWebhookEvent> WithMeta(this Partial<DocumentWebhookEvent> it, Func<Partial<KMetaMod>, Partial<KMetaMod>> partialBuilder)
        => it.AddFieldName("meta", partialBuilder(new Partial<KMetaMod>(it)));
    
    public static Partial<DocumentWebhookEvent> WithDocument(this Partial<DocumentWebhookEvent> it)
        => it.AddFieldName("document");
    
    public static Partial<DocumentWebhookEvent> WithChangeAuthors(this Partial<DocumentWebhookEvent> it)
        => it.AddFieldName("changeAuthors");
    
    public static Partial<DocumentWebhookEvent> WithChangeAuthors(this Partial<DocumentWebhookEvent> it, Func<Partial<CPrincipal>, Partial<CPrincipal>> partialBuilder)
        => it.AddFieldName("changeAuthors", partialBuilder(new Partial<CPrincipal>(it)));
    
    public static Partial<DocumentWebhookEvent> WithVersion(this Partial<DocumentWebhookEvent> it)
        => it.AddFieldName("version");
    
    public static Partial<DocumentWebhookEvent> WithBase(this Partial<DocumentWebhookEvent> it)
        => it.AddFieldName("base");
    
}

