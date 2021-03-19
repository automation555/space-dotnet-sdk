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
    public sealed class RevisionsInReview
         : IPropagatePropertyAccessPath
    {
        public RevisionsInReview() { }
        
        public RevisionsInReview(RepositoryInReview repository, List<GitCommitWithGraph> commits)
        {
            Repository = repository;
            Commits = commits;
        }
        
        private PropertyValue<RepositoryInReview> _repository = new PropertyValue<RepositoryInReview>(nameof(RevisionsInReview), nameof(Repository));
        
        [Required]
        [JsonPropertyName("repository")]
        public RepositoryInReview Repository
        {
            get => _repository.GetValue();
            set => _repository.SetValue(value);
        }
    
        private PropertyValue<List<GitCommitWithGraph>> _commits = new PropertyValue<List<GitCommitWithGraph>>(nameof(RevisionsInReview), nameof(Commits), new List<GitCommitWithGraph>());
        
        [Required]
        [JsonPropertyName("commits")]
        public List<GitCommitWithGraph> Commits
        {
            get => _commits.GetValue();
            set => _commits.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _repository.SetAccessPath(path, validateHasBeenSet);
            _commits.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
