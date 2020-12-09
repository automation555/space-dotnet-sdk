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
    public sealed class MergeRequestMergedEvent
         : FeedEvent, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public  string? ClassName => "MergeRequestMergedEvent";
        
        public MergeRequestMergedEvent() { }
        
        public MergeRequestMergedEvent(string repository, string sourceBranch, string targetBranch)
        {
            Repository = repository;
            SourceBranch = sourceBranch;
            TargetBranch = targetBranch;
        }
        
        private PropertyValue<string> _repository = new PropertyValue<string>(nameof(MergeRequestMergedEvent), nameof(Repository));
        
        [Required]
        [JsonPropertyName("repository")]
        public string Repository
        {
            get => _repository.GetValue();
            set => _repository.SetValue(value);
        }
    
        private PropertyValue<string> _sourceBranch = new PropertyValue<string>(nameof(MergeRequestMergedEvent), nameof(SourceBranch));
        
        [Required]
        [JsonPropertyName("sourceBranch")]
        public string SourceBranch
        {
            get => _sourceBranch.GetValue();
            set => _sourceBranch.SetValue(value);
        }
    
        private PropertyValue<string> _targetBranch = new PropertyValue<string>(nameof(MergeRequestMergedEvent), nameof(TargetBranch));
        
        [Required]
        [JsonPropertyName("targetBranch")]
        public string TargetBranch
        {
            get => _targetBranch.GetValue();
            set => _targetBranch.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _repository.SetAccessPath(path, validateHasBeenSet);
            _sourceBranch.SetAccessPath(path, validateHasBeenSet);
            _targetBranch.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
