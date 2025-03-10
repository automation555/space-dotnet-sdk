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

namespace JetBrains.Space.Client.ApplicationUnfurlPatternPartialBuilder;

public static class ApplicationUnfurlPatternPartialExtensions
{
    public static Partial<ApplicationUnfurlPattern> WithPrefix(this Partial<ApplicationUnfurlPattern> it)
        => it.AddFieldName("prefix");
    
    public static Partial<ApplicationUnfurlPattern> WithLinkReplacement(this Partial<ApplicationUnfurlPattern> it)
        => it.AddFieldName("linkReplacement");
    
    public static Partial<ApplicationUnfurlPattern> WithStatus(this Partial<ApplicationUnfurlPattern> it)
        => it.AddFieldName("status");
    
    public static Partial<ApplicationUnfurlPattern> WithStatus(this Partial<ApplicationUnfurlPattern> it, Func<Partial<RightStatus>, Partial<RightStatus>> partialBuilder)
        => it.AddFieldName("status", partialBuilder(new Partial<RightStatus>(it)));
    
    public static Partial<ApplicationUnfurlPattern> WithModificationAuthor(this Partial<ApplicationUnfurlPattern> it)
        => it.AddFieldName("modificationAuthor");
    
    public static Partial<ApplicationUnfurlPattern> WithModificationAuthor(this Partial<ApplicationUnfurlPattern> it, Func<Partial<CPrincipal>, Partial<CPrincipal>> partialBuilder)
        => it.AddFieldName("modificationAuthor", partialBuilder(new Partial<CPrincipal>(it)));
    
    public static Partial<ApplicationUnfurlPattern> WithModificationTimestamp(this Partial<ApplicationUnfurlPattern> it)
        => it.AddFieldName("modificationTimestamp");
    
}

