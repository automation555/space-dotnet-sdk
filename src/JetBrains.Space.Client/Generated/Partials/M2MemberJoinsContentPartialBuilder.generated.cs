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

namespace JetBrains.Space.Client.M2MemberJoinsContentPartialBuilder
{
    public static class M2MemberJoinsContentPartialExtensions
    {
        public static Partial<M2MemberJoinsContent> WithMember(this Partial<M2MemberJoinsContent> it)
            => it.AddFieldName("member");
        
        public static Partial<M2MemberJoinsContent> WithMember(this Partial<M2MemberJoinsContent> it, Func<Partial<TDMemberProfile>, Partial<TDMemberProfile>> partialBuilder)
            => it.AddFieldName("member", partialBuilder(new Partial<TDMemberProfile>(it)));
        
    }
    
}
