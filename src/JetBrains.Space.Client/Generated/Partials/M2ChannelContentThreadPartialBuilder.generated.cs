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

namespace JetBrains.Space.Client.M2ChannelContentThreadPartialBuilder
{
    public static class M2ChannelContentThreadPartialExtensions
    {
        public static Partial<M2ChannelContentThread> WithRecord(this Partial<M2ChannelContentThread> it)
            => it.AddFieldName("record");
        
        public static Partial<M2ChannelContentThread> WithRecord(this Partial<M2ChannelContentThread> it, Func<Partial<ChannelItemRecord>, Partial<ChannelItemRecord>> partialBuilder)
            => it.AddFieldName("record", partialBuilder(new Partial<ChannelItemRecord>(it)));
        
        public static Partial<M2ChannelContentThread> WithParent(this Partial<M2ChannelContentThread> it)
            => it.AddFieldName("parent");
        
        public static Partial<M2ChannelContentThread> WithParent(this Partial<M2ChannelContentThread> it, Func<Partial<M2ChannelRecord>, Partial<M2ChannelRecord>> partialBuilder)
            => it.AddFieldName("parent", partialBuilder(new Partial<M2ChannelRecord>(it)));
        
    }
    
}
