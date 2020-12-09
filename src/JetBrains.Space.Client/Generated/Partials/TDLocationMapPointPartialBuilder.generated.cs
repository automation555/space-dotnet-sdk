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

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Space.Common;
using JetBrains.Space.Common.Json.Serialization;
using JetBrains.Space.Common.Json.Serialization.Polymorphism;
using JetBrains.Space.Common.Types;

namespace JetBrains.Space.Client.TDLocationMapPointPartialBuilder
{
    public static class TDLocationMapPointPartialExtensions
    {
        public static Partial<TDLocationMapPoint> WithId(this Partial<TDLocationMapPoint> it)
            => it.AddFieldName("id");
        
        public static Partial<TDLocationMapPoint> WithMapId(this Partial<TDLocationMapPoint> it)
            => it.AddFieldName("mapId");
        
        public static Partial<TDLocationMapPoint> WithX(this Partial<TDLocationMapPoint> it)
            => it.AddFieldName("x");
        
        public static Partial<TDLocationMapPoint> WithY(this Partial<TDLocationMapPoint> it)
            => it.AddFieldName("y");
        
        public static Partial<TDLocationMapPoint> WithCreated(this Partial<TDLocationMapPoint> it)
            => it.AddFieldName("created");
        
        public static Partial<TDLocationMapPoint> WithMemberLocation(this Partial<TDLocationMapPoint> it)
            => it.AddFieldName("memberLocation");
        
        public static Partial<TDLocationMapPoint> WithIsDeleted(this Partial<TDLocationMapPoint> it)
            => it.AddFieldName("deleted");
        
    }
    
}
