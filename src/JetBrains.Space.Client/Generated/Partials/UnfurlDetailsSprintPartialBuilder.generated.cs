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

namespace JetBrains.Space.Client.UnfurlDetailsSprintPartialBuilder;

public static class UnfurlDetailsSprintPartialExtensions
{
    public static Partial<UnfurlDetailsSprint> WithProject(this Partial<UnfurlDetailsSprint> it)
        => it.AddFieldName("project");
    
    public static Partial<UnfurlDetailsSprint> WithProject(this Partial<UnfurlDetailsSprint> it, Func<Partial<PRProject>, Partial<PRProject>> partialBuilder)
        => it.AddFieldName("project", partialBuilder(new Partial<PRProject>(it)));
    
    public static Partial<UnfurlDetailsSprint> WithSprint(this Partial<UnfurlDetailsSprint> it)
        => it.AddFieldName("sprint");
    
    public static Partial<UnfurlDetailsSprint> WithSprint(this Partial<UnfurlDetailsSprint> it, Func<Partial<SprintRecord>, Partial<SprintRecord>> partialBuilder)
        => it.AddFieldName("sprint", partialBuilder(new Partial<SprintRecord>(it)));
    
}

