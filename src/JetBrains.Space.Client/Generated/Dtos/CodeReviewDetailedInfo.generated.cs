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

namespace JetBrains.Space.Client
{
    public sealed class CodeReviewDetailedInfo
         : IPropagatePropertyAccessPath
    {
        public CodeReviewDetailedInfo() { }
        
        public CodeReviewDetailedInfo(CodeReviewRecord shortInfo, List<RevisionsInReview> commits, CodeReviewDiscussionCounter discussionCounter, List<TrackedBranchesInReview> branches, CodeReviewUnboundDiscussionCounter? unboundDiscussionCounter = null)
        {
            ShortInfo = shortInfo;
            Commits = commits;
            DiscussionCounter = discussionCounter;
            UnboundDiscussionCounter = unboundDiscussionCounter;
            Branches = branches;
        }
        
        private PropertyValue<CodeReviewRecord> _shortInfo = new PropertyValue<CodeReviewRecord>(nameof(CodeReviewDetailedInfo), nameof(ShortInfo));
        
        [Required]
        [JsonPropertyName("shortInfo")]
        public CodeReviewRecord ShortInfo
        {
            get => _shortInfo.GetValue();
            set => _shortInfo.SetValue(value);
        }
    
        private PropertyValue<List<RevisionsInReview>> _commits = new PropertyValue<List<RevisionsInReview>>(nameof(CodeReviewDetailedInfo), nameof(Commits), new List<RevisionsInReview>());
        
        [Required]
        [JsonPropertyName("commits")]
        public List<RevisionsInReview> Commits
        {
            get => _commits.GetValue();
            set => _commits.SetValue(value);
        }
    
        private PropertyValue<CodeReviewDiscussionCounter> _discussionCounter = new PropertyValue<CodeReviewDiscussionCounter>(nameof(CodeReviewDetailedInfo), nameof(DiscussionCounter));
        
        [Required]
        [JsonPropertyName("discussionCounter")]
        public CodeReviewDiscussionCounter DiscussionCounter
        {
            get => _discussionCounter.GetValue();
            set => _discussionCounter.SetValue(value);
        }
    
        private PropertyValue<CodeReviewUnboundDiscussionCounter?> _unboundDiscussionCounter = new PropertyValue<CodeReviewUnboundDiscussionCounter?>(nameof(CodeReviewDetailedInfo), nameof(UnboundDiscussionCounter));
        
        [JsonPropertyName("unboundDiscussionCounter")]
        public CodeReviewUnboundDiscussionCounter? UnboundDiscussionCounter
        {
            get => _unboundDiscussionCounter.GetValue();
            set => _unboundDiscussionCounter.SetValue(value);
        }
    
        private PropertyValue<List<TrackedBranchesInReview>> _branches = new PropertyValue<List<TrackedBranchesInReview>>(nameof(CodeReviewDetailedInfo), nameof(Branches), new List<TrackedBranchesInReview>());
        
        [Required]
        [JsonPropertyName("branches")]
        public List<TrackedBranchesInReview> Branches
        {
            get => _branches.GetValue();
            set => _branches.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _shortInfo.SetAccessPath(path, validateHasBeenSet);
            _commits.SetAccessPath(path, validateHasBeenSet);
            _discussionCounter.SetAccessPath(path, validateHasBeenSet);
            _unboundDiscussionCounter.SetAccessPath(path, validateHasBeenSet);
            _branches.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
