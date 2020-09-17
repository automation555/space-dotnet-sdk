// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

#nullable enable
#pragma warning disable CS0108

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using SpaceDotNet.Client.Internal;
using SpaceDotNet.Common;
using SpaceDotNet.Common.Json.Serialization;
using SpaceDotNet.Common.Json.Serialization.Polymorphism;
using SpaceDotNet.Common.Types;

namespace SpaceDotNet.Client.ExtendedTypePartialBuilder
{
    public static class ExtendedTypePartialExtensions
    {
        public static Partial<ExtendedType> WithKey(this Partial<ExtendedType> it)
            => it.AddFieldName("key");
        
        public static Partial<ExtendedType> WithDisplayName(this Partial<ExtendedType> it)
            => it.AddFieldName("displayName");
        
        public static Partial<ExtendedType> WithApiClassName(this Partial<ExtendedType> it)
            => it.AddFieldName("apiClassName");
        
        public static Partial<ExtendedType> WithScopeType(this Partial<ExtendedType> it)
            => it.AddFieldName("scopeType");
        
        public static Partial<ExtendedType> WithScopeType(this Partial<ExtendedType> it, Func<Partial<ExtendedTypeScopeType>, Partial<ExtendedTypeScopeType>> partialBuilder)
            => it.AddFieldName("scopeType", partialBuilder(new Partial<ExtendedTypeScopeType>(it)));
        
    }
    
}
