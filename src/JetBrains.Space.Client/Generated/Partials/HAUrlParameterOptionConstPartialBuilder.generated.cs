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

namespace JetBrains.Space.Client.HAUrlParameterOptionConstPartialBuilder;

public static class HAUrlParameterOptionConstPartialExtensions
{
    public static Partial<HAUrlParameterOptionConst> WithValue(this Partial<HAUrlParameterOptionConst> it)
        => it.AddFieldName("value");
    
    public static Partial<HAUrlParameterOptionConst> WithOptionName(this Partial<HAUrlParameterOptionConst> it)
        => it.AddFieldName("optionName");
    
    public static Partial<HAUrlParameterOptionConst> WithDeprecation(this Partial<HAUrlParameterOptionConst> it)
        => it.AddFieldName("deprecation");
    
    public static Partial<HAUrlParameterOptionConst> WithDeprecation(this Partial<HAUrlParameterOptionConst> it, Func<Partial<HADeprecation>, Partial<HADeprecation>> partialBuilder)
        => it.AddFieldName("deprecation", partialBuilder(new Partial<HADeprecation>(it)));
    
}

