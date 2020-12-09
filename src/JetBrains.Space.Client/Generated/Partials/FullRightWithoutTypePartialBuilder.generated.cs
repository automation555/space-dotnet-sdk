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

namespace JetBrains.Space.Client.FullRightWithoutTypePartialBuilder
{
    public static class FullRightWithoutTypePartialExtensions
    {
        public static Partial<FullRightWithoutType> WithCode(this Partial<FullRightWithoutType> it)
            => it.AddFieldName("code");
        
        public static Partial<FullRightWithoutType> WithTitle(this Partial<FullRightWithoutType> it)
            => it.AddFieldName("title");
        
        public static Partial<FullRightWithoutType> WithDescription(this Partial<FullRightWithoutType> it)
            => it.AddFieldName("description");
        
        public static Partial<FullRightWithoutType> WithIsGrantedForUsers(this Partial<FullRightWithoutType> it)
            => it.AddFieldName("grantedForUsers");
        
        public static Partial<FullRightWithoutType> WithFeatureFlag(this Partial<FullRightWithoutType> it)
            => it.AddFieldName("featureFlag");
        
        public static Partial<FullRightWithoutType> WithFeatureFlag(this Partial<FullRightWithoutType> it, Func<Partial<FeatureFlag>, Partial<FeatureFlag>> partialBuilder)
            => it.AddFieldName("featureFlag", partialBuilder(new Partial<FeatureFlag>(it)));
        
    }
    
}
