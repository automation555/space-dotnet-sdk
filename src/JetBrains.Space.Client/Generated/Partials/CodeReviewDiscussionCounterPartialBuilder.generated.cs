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
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Space.Client.Internal;
using JetBrains.Space.Common;
using JetBrains.Space.Common.Json.Serialization;
using JetBrains.Space.Common.Json.Serialization.Polymorphism;
using JetBrains.Space.Common.Types;

namespace JetBrains.Space.Client.CodeReviewDiscussionCounterPartialBuilder
{
    public static class CodeReviewDiscussionCounterPartialExtensions
    {
        public static Partial<CodeReviewDiscussionCounter> WithId(this Partial<CodeReviewDiscussionCounter> it)
            => it.AddFieldName("id");
        
        public static Partial<CodeReviewDiscussionCounter> WithDiscussionCounter(this Partial<CodeReviewDiscussionCounter> it)
            => it.AddFieldName("discussionCounter");
        
        public static Partial<CodeReviewDiscussionCounter> WithDiscussionCounter(this Partial<CodeReviewDiscussionCounter> it, Func<Partial<Counter>, Partial<Counter>> partialBuilder)
            => it.AddFieldName("discussionCounter", partialBuilder(new Partial<Counter>(it)));
        
    }
    
}
