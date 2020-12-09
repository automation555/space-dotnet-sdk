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

namespace JetBrains.Space.Client.CodeReviewDetailedInfoPartialBuilder
{
    public static class CodeReviewDetailedInfoPartialExtensions
    {
        public static Partial<CodeReviewDetailedInfo> WithShortInfo(this Partial<CodeReviewDetailedInfo> it)
            => it.AddFieldName("shortInfo");
        
        public static Partial<CodeReviewDetailedInfo> WithShortInfo(this Partial<CodeReviewDetailedInfo> it, Func<Partial<CodeReviewRecord>, Partial<CodeReviewRecord>> partialBuilder)
            => it.AddFieldName("shortInfo", partialBuilder(new Partial<CodeReviewRecord>(it)));
        
        public static Partial<CodeReviewDetailedInfo> WithCommits(this Partial<CodeReviewDetailedInfo> it)
            => it.AddFieldName("commits");
        
        public static Partial<CodeReviewDetailedInfo> WithCommits(this Partial<CodeReviewDetailedInfo> it, Func<Partial<RevisionsInReview>, Partial<RevisionsInReview>> partialBuilder)
            => it.AddFieldName("commits", partialBuilder(new Partial<RevisionsInReview>(it)));
        
        public static Partial<CodeReviewDetailedInfo> WithDiscussionCounter(this Partial<CodeReviewDetailedInfo> it)
            => it.AddFieldName("discussionCounter");
        
        public static Partial<CodeReviewDetailedInfo> WithDiscussionCounter(this Partial<CodeReviewDetailedInfo> it, Func<Partial<CodeReviewDiscussionCounter>, Partial<CodeReviewDiscussionCounter>> partialBuilder)
            => it.AddFieldName("discussionCounter", partialBuilder(new Partial<CodeReviewDiscussionCounter>(it)));
        
        public static Partial<CodeReviewDetailedInfo> WithBranches(this Partial<CodeReviewDetailedInfo> it)
            => it.AddFieldName("branches");
        
        public static Partial<CodeReviewDetailedInfo> WithBranches(this Partial<CodeReviewDetailedInfo> it, Func<Partial<TrackedBranchesInReview>, Partial<TrackedBranchesInReview>> partialBuilder)
            => it.AddFieldName("branches", partialBuilder(new Partial<TrackedBranchesInReview>(it)));
        
    }
    
}
