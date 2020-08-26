// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

#nullable enable

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using SpaceDotNet.Client.Internal;
using SpaceDotNet.Common;
using SpaceDotNet.Common.Json.Serialization;
using SpaceDotNet.Common.Json.Serialization.Polymorphism;
using SpaceDotNet.Common.Types;

namespace SpaceDotNet.Client
{
    public sealed class CodeDiscussionRecordDto
         : IPropagatePropertyAccessPath
    {
        public CodeDiscussionRecordDto() { }
        
        public CodeDiscussionRecordDto(string id, string projectId, CodeDiscussionAnchorDto anchor, SpaceTime created, M2ChannelRecordDto channel, bool resolved, bool archived, CodeDiscussionSnippetDto? snippet = null, bool? pending = null, CodeReviewRecordDto? review = null, string? feedItemId = null, List<CodeReviewRecordDto>? reviews = null)
        {
            Id = id;
            ProjectId = projectId;
            Anchor = anchor;
            Created = created;
            Channel = channel;
            Resolved = resolved;
            Snippet = snippet;
            Pending = pending;
            Review = review;
            FeedItemId = feedItemId;
            Reviews = reviews;
            Archived = archived;
        }
        
        private PropertyValue<string> _id = new PropertyValue<string>(nameof(CodeDiscussionRecordDto), nameof(Id));
        
        [Required]
        [JsonPropertyName("id")]
        public string Id
        {
            get { return _id.GetValue(); }
            set { _id.SetValue(value); }
        }
    
        private PropertyValue<string> _projectId = new PropertyValue<string>(nameof(CodeDiscussionRecordDto), nameof(ProjectId));
        
        [Required]
        [JsonPropertyName("projectId")]
        public string ProjectId
        {
            get { return _projectId.GetValue(); }
            set { _projectId.SetValue(value); }
        }
    
        private PropertyValue<CodeDiscussionAnchorDto> _anchor = new PropertyValue<CodeDiscussionAnchorDto>(nameof(CodeDiscussionRecordDto), nameof(Anchor));
        
        [Required]
        [JsonPropertyName("anchor")]
        public CodeDiscussionAnchorDto Anchor
        {
            get { return _anchor.GetValue(); }
            set { _anchor.SetValue(value); }
        }
    
        private PropertyValue<SpaceTime> _created = new PropertyValue<SpaceTime>(nameof(CodeDiscussionRecordDto), nameof(Created));
        
        [Required]
        [JsonPropertyName("created")]
        public SpaceTime Created
        {
            get { return _created.GetValue(); }
            set { _created.SetValue(value); }
        }
    
        private PropertyValue<M2ChannelRecordDto> _channel = new PropertyValue<M2ChannelRecordDto>(nameof(CodeDiscussionRecordDto), nameof(Channel));
        
        [Required]
        [JsonPropertyName("channel")]
        public M2ChannelRecordDto Channel
        {
            get { return _channel.GetValue(); }
            set { _channel.SetValue(value); }
        }
    
        private PropertyValue<bool> _resolved = new PropertyValue<bool>(nameof(CodeDiscussionRecordDto), nameof(Resolved));
        
        [Required]
        [JsonPropertyName("resolved")]
        public bool Resolved
        {
            get { return _resolved.GetValue(); }
            set { _resolved.SetValue(value); }
        }
    
        private PropertyValue<CodeDiscussionSnippetDto?> _snippet = new PropertyValue<CodeDiscussionSnippetDto?>(nameof(CodeDiscussionRecordDto), nameof(Snippet));
        
        [JsonPropertyName("snippet")]
        public CodeDiscussionSnippetDto? Snippet
        {
            get { return _snippet.GetValue(); }
            set { _snippet.SetValue(value); }
        }
    
        private PropertyValue<bool?> _pending = new PropertyValue<bool?>(nameof(CodeDiscussionRecordDto), nameof(Pending));
        
        [JsonPropertyName("pending")]
        public bool? Pending
        {
            get { return _pending.GetValue(); }
            set { _pending.SetValue(value); }
        }
    
        private PropertyValue<CodeReviewRecordDto?> _review = new PropertyValue<CodeReviewRecordDto?>(nameof(CodeDiscussionRecordDto), nameof(Review));
        
        [JsonPropertyName("review")]
        public CodeReviewRecordDto? Review
        {
            get { return _review.GetValue(); }
            set { _review.SetValue(value); }
        }
    
        private PropertyValue<string?> _feedItemId = new PropertyValue<string?>(nameof(CodeDiscussionRecordDto), nameof(FeedItemId));
        
        [JsonPropertyName("feedItemId")]
        public string? FeedItemId
        {
            get { return _feedItemId.GetValue(); }
            set { _feedItemId.SetValue(value); }
        }
    
        private PropertyValue<List<CodeReviewRecordDto>?> _reviews = new PropertyValue<List<CodeReviewRecordDto>?>(nameof(CodeDiscussionRecordDto), nameof(Reviews));
        
        [JsonPropertyName("reviews")]
        public List<CodeReviewRecordDto>? Reviews
        {
            get { return _reviews.GetValue(); }
            set { _reviews.SetValue(value); }
        }
    
        private PropertyValue<bool> _archived = new PropertyValue<bool>(nameof(CodeDiscussionRecordDto), nameof(Archived));
        
        [Required]
        [JsonPropertyName("archived")]
        public bool Archived
        {
            get { return _archived.GetValue(); }
            set { _archived.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _id.SetAccessPath(path, validateHasBeenSet);
            _projectId.SetAccessPath(path, validateHasBeenSet);
            _anchor.SetAccessPath(path, validateHasBeenSet);
            _created.SetAccessPath(path, validateHasBeenSet);
            _channel.SetAccessPath(path, validateHasBeenSet);
            _resolved.SetAccessPath(path, validateHasBeenSet);
            _snippet.SetAccessPath(path, validateHasBeenSet);
            _pending.SetAccessPath(path, validateHasBeenSet);
            _review.SetAccessPath(path, validateHasBeenSet);
            _feedItemId.SetAccessPath(path, validateHasBeenSet);
            _reviews.SetAccessPath(path, validateHasBeenSet);
            _archived.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
