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
#pragma warning disable 618

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
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
    public sealed class PackagesSubscriptionFilterIn
         : SubscriptionFilterIn, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public  string? ClassName => "PackagesSubscriptionFilterIn";
        
        public PackagesSubscriptionFilterIn() { }
        
        public PackagesSubscriptionFilterIn(List<string> namePattern, string? project = null, string? repository = null, string? versionPattern = null)
        {
            Project = project;
            Repository = repository;
            NamePattern = namePattern;
            VersionPattern = versionPattern;
        }
        
        private PropertyValue<string?> _project = new PropertyValue<string?>(nameof(PackagesSubscriptionFilterIn), nameof(Project));
        
        [JsonPropertyName("project")]
        public string? Project
        {
            get => _project.GetValue();
            set => _project.SetValue(value);
        }
    
        private PropertyValue<string?> _repository = new PropertyValue<string?>(nameof(PackagesSubscriptionFilterIn), nameof(Repository));
        
        [JsonPropertyName("repository")]
        public string? Repository
        {
            get => _repository.GetValue();
            set => _repository.SetValue(value);
        }
    
        private PropertyValue<List<string>> _namePattern = new PropertyValue<List<string>>(nameof(PackagesSubscriptionFilterIn), nameof(NamePattern), new List<string>());
        
        [Required]
        [JsonPropertyName("namePattern")]
        public List<string> NamePattern
        {
            get => _namePattern.GetValue();
            set => _namePattern.SetValue(value);
        }
    
        private PropertyValue<string?> _versionPattern = new PropertyValue<string?>(nameof(PackagesSubscriptionFilterIn), nameof(VersionPattern));
        
        [JsonPropertyName("versionPattern")]
        public string? VersionPattern
        {
            get => _versionPattern.GetValue();
            set => _versionPattern.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _project.SetAccessPath(path, validateHasBeenSet);
            _repository.SetAccessPath(path, validateHasBeenSet);
            _namePattern.SetAccessPath(path, validateHasBeenSet);
            _versionPattern.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
