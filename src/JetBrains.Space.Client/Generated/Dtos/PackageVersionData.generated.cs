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
    public sealed class PackageVersionData
         : IPropagatePropertyAccessPath
    {
        public PackageVersionData() { }
        
        public PackageVersionData(PackageType type, string repository, string name, string version, bool pinned, List<string>? tags = null, long? created = null, long? updated = null, long? downloads = null, string? comment = null)
        {
            Type = type;
            Repository = repository;
            Name = name;
            Version = version;
            Tags = tags;
            Created = created;
            Updated = updated;
            Downloads = downloads;
            IsPinned = pinned;
            Comment = comment;
        }
        
        private PropertyValue<PackageType> _type = new PropertyValue<PackageType>(nameof(PackageVersionData), nameof(Type));
        
        [Required]
        [JsonPropertyName("type")]
        public PackageType Type
        {
            get => _type.GetValue();
            set => _type.SetValue(value);
        }
    
        private PropertyValue<string> _repository = new PropertyValue<string>(nameof(PackageVersionData), nameof(Repository));
        
        [Required]
        [JsonPropertyName("repository")]
        public string Repository
        {
            get => _repository.GetValue();
            set => _repository.SetValue(value);
        }
    
        private PropertyValue<string> _name = new PropertyValue<string>(nameof(PackageVersionData), nameof(Name));
        
        [Required]
        [JsonPropertyName("name")]
        public string Name
        {
            get => _name.GetValue();
            set => _name.SetValue(value);
        }
    
        private PropertyValue<string> _version = new PropertyValue<string>(nameof(PackageVersionData), nameof(Version));
        
        [Required]
        [JsonPropertyName("version")]
        public string Version
        {
            get => _version.GetValue();
            set => _version.SetValue(value);
        }
    
        private PropertyValue<List<string>?> _tags = new PropertyValue<List<string>?>(nameof(PackageVersionData), nameof(Tags));
        
        [JsonPropertyName("tags")]
        public List<string>? Tags
        {
            get => _tags.GetValue();
            set => _tags.SetValue(value);
        }
    
        private PropertyValue<long?> _created = new PropertyValue<long?>(nameof(PackageVersionData), nameof(Created));
        
        [JsonPropertyName("created")]
        public long? Created
        {
            get => _created.GetValue();
            set => _created.SetValue(value);
        }
    
        private PropertyValue<long?> _updated = new PropertyValue<long?>(nameof(PackageVersionData), nameof(Updated));
        
        [JsonPropertyName("updated")]
        public long? Updated
        {
            get => _updated.GetValue();
            set => _updated.SetValue(value);
        }
    
        private PropertyValue<long?> _downloads = new PropertyValue<long?>(nameof(PackageVersionData), nameof(Downloads));
        
        [JsonPropertyName("downloads")]
        public long? Downloads
        {
            get => _downloads.GetValue();
            set => _downloads.SetValue(value);
        }
    
        private PropertyValue<bool> _pinned = new PropertyValue<bool>(nameof(PackageVersionData), nameof(IsPinned));
        
        [Required]
        [JsonPropertyName("pinned")]
        public bool IsPinned
        {
            get => _pinned.GetValue();
            set => _pinned.SetValue(value);
        }
    
        private PropertyValue<string?> _comment = new PropertyValue<string?>(nameof(PackageVersionData), nameof(Comment));
        
        [JsonPropertyName("comment")]
        public string? Comment
        {
            get => _comment.GetValue();
            set => _comment.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _type.SetAccessPath(path, validateHasBeenSet);
            _repository.SetAccessPath(path, validateHasBeenSet);
            _name.SetAccessPath(path, validateHasBeenSet);
            _version.SetAccessPath(path, validateHasBeenSet);
            _tags.SetAccessPath(path, validateHasBeenSet);
            _created.SetAccessPath(path, validateHasBeenSet);
            _updated.SetAccessPath(path, validateHasBeenSet);
            _downloads.SetAccessPath(path, validateHasBeenSet);
            _pinned.SetAccessPath(path, validateHasBeenSet);
            _comment.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
