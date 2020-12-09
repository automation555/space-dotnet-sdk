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
    public sealed class Job
         : IPropagatePropertyAccessPath
    {
        public Job() { }
        
        public Job(string id, string name, string repoName, bool archive)
        {
            Id = id;
            Name = name;
            RepoName = repoName;
            IsArchive = archive;
        }
        
        private PropertyValue<string> _id = new PropertyValue<string>(nameof(Job), nameof(Id));
        
        [Required]
        [JsonPropertyName("id")]
        public string Id
        {
            get => _id.GetValue();
            set => _id.SetValue(value);
        }
    
        private PropertyValue<string> _name = new PropertyValue<string>(nameof(Job), nameof(Name));
        
        [Required]
        [JsonPropertyName("name")]
        public string Name
        {
            get => _name.GetValue();
            set => _name.SetValue(value);
        }
    
        private PropertyValue<string> _repoName = new PropertyValue<string>(nameof(Job), nameof(RepoName));
        
        [Required]
        [JsonPropertyName("repoName")]
        public string RepoName
        {
            get => _repoName.GetValue();
            set => _repoName.SetValue(value);
        }
    
        private PropertyValue<bool> _archive = new PropertyValue<bool>(nameof(Job), nameof(IsArchive));
        
        [Required]
        [JsonPropertyName("archive")]
        public bool IsArchive
        {
            get => _archive.GetValue();
            set => _archive.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _id.SetAccessPath(path, validateHasBeenSet);
            _name.SetAccessPath(path, validateHasBeenSet);
            _repoName.SetAccessPath(path, validateHasBeenSet);
            _archive.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
