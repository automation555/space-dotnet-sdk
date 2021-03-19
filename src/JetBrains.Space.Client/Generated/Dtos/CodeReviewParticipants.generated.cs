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
    public sealed class CodeReviewParticipants
         : IPropagatePropertyAccessPath
    {
        public CodeReviewParticipants() { }
        
        public CodeReviewParticipants(string id, List<CodeReviewParticipantRecord> reviewers, List<CodeReviewParticipantRecord> authors, List<CodeReviewParticipantRecord> watchers, List<CodeReviewParticipant>? participants = null)
        {
            Id = id;
            Participants = participants;
            Reviewers = reviewers;
            Authors = authors;
            Watchers = watchers;
        }
        
        private PropertyValue<string> _id = new PropertyValue<string>(nameof(CodeReviewParticipants), nameof(Id));
        
        [Required]
        [JsonPropertyName("id")]
        public string Id
        {
            get => _id.GetValue();
            set => _id.SetValue(value);
        }
    
        private PropertyValue<List<CodeReviewParticipant>?> _participants = new PropertyValue<List<CodeReviewParticipant>?>(nameof(CodeReviewParticipants), nameof(Participants));
        
        [JsonPropertyName("participants")]
        public List<CodeReviewParticipant>? Participants
        {
            get => _participants.GetValue();
            set => _participants.SetValue(value);
        }
    
        private PropertyValue<List<CodeReviewParticipantRecord>> _reviewers = new PropertyValue<List<CodeReviewParticipantRecord>>(nameof(CodeReviewParticipants), nameof(Reviewers), new List<CodeReviewParticipantRecord>());
        
        [Required]
        [Obsolete("Use participants (since 2020-11-03) (marked for removal)")]
        [JsonPropertyName("reviewers")]
        public List<CodeReviewParticipantRecord> Reviewers
        {
            get => _reviewers.GetValue();
            set => _reviewers.SetValue(value);
        }
    
        private PropertyValue<List<CodeReviewParticipantRecord>> _authors = new PropertyValue<List<CodeReviewParticipantRecord>>(nameof(CodeReviewParticipants), nameof(Authors), new List<CodeReviewParticipantRecord>());
        
        [Required]
        [Obsolete("Use participants (since 2020-11-03) (marked for removal)")]
        [JsonPropertyName("authors")]
        public List<CodeReviewParticipantRecord> Authors
        {
            get => _authors.GetValue();
            set => _authors.SetValue(value);
        }
    
        private PropertyValue<List<CodeReviewParticipantRecord>> _watchers = new PropertyValue<List<CodeReviewParticipantRecord>>(nameof(CodeReviewParticipants), nameof(Watchers), new List<CodeReviewParticipantRecord>());
        
        [Required]
        [Obsolete("Use participants (since 2020-11-03) (marked for removal)")]
        [JsonPropertyName("watchers")]
        public List<CodeReviewParticipantRecord> Watchers
        {
            get => _watchers.GetValue();
            set => _watchers.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _id.SetAccessPath(path, validateHasBeenSet);
            _participants.SetAccessPath(path, validateHasBeenSet);
            _reviewers.SetAccessPath(path, validateHasBeenSet);
            _authors.SetAccessPath(path, validateHasBeenSet);
            _watchers.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
