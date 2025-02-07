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

namespace JetBrains.Space.Client.GpgKeyDataPartialBuilder;

public static class GpgKeyDataPartialExtensions
{
    public static Partial<GpgKeyData> WithFingerprint(this Partial<GpgKeyData> it)
        => it.AddFieldName("fingerprint");
    
    public static Partial<GpgKeyData> WithPublicKey(this Partial<GpgKeyData> it)
        => it.AddFieldName("publicKey");
    
    public static Partial<GpgKeyData> WithUserId(this Partial<GpgKeyData> it)
        => it.AddFieldName("userId");
    
    public static Partial<GpgKeyData> WithIsVerified(this Partial<GpgKeyData> it)
        => it.AddFieldName("verified");
    
    public static Partial<GpgKeyData> WithComment(this Partial<GpgKeyData> it)
        => it.AddFieldName("comment");
    
    public static Partial<GpgKeyData> WithCreated(this Partial<GpgKeyData> it)
        => it.AddFieldName("created");
    
    public static Partial<GpgKeyData> WithAdded(this Partial<GpgKeyData> it)
        => it.AddFieldName("added");
    
    public static Partial<GpgKeyData> WithExpires(this Partial<GpgKeyData> it)
        => it.AddFieldName("expires");
    
    public static Partial<GpgKeyData> WithIsRevoked(this Partial<GpgKeyData> it)
        => it.AddFieldName("revoked");
    
    public static Partial<GpgKeyData> WithRevokeComment(this Partial<GpgKeyData> it)
        => it.AddFieldName("revokeComment");
    
}

