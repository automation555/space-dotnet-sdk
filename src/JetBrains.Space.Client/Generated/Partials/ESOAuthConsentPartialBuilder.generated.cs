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

namespace JetBrains.Space.Client.ESOAuthConsentPartialBuilder;

public static class ESOAuthConsentPartialExtensions
{
    public static Partial<ESOAuthConsent> WithClientApplication(this Partial<ESOAuthConsent> it)
        => it.AddFieldName("clientApplication");
    
    public static Partial<ESOAuthConsent> WithClientApplication(this Partial<ESOAuthConsent> it, Func<Partial<ESApp>, Partial<ESApp>> partialBuilder)
        => it.AddFieldName("clientApplication", partialBuilder(new Partial<ESApp>(it)));
    
    public static Partial<ESOAuthConsent> WithApprovedScopes(this Partial<ESOAuthConsent> it)
        => it.AddFieldName("approvedScopes");
    
    public static Partial<ESOAuthConsent> WithApprovedScopes(this Partial<ESOAuthConsent> it, Func<Partial<ESApprovedScope>, Partial<ESApprovedScope>> partialBuilder)
        => it.AddFieldName("approvedScopes", partialBuilder(new Partial<ESApprovedScope>(it)));
    
    public static Partial<ESOAuthConsent> WithRefreshTokens(this Partial<ESOAuthConsent> it)
        => it.AddFieldName("refreshTokens");
    
    public static Partial<ESOAuthConsent> WithRefreshTokens(this Partial<ESOAuthConsent> it, Func<Partial<ESRefreshToken>, Partial<ESRefreshToken>> partialBuilder)
        => it.AddFieldName("refreshTokens", partialBuilder(new Partial<ESRefreshToken>(it)));
    
}

