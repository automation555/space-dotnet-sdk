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
    public sealed class ContainerPackageVersionDetails
         : PackageVersionDetails, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public  string? ClassName => "ContainerPackageVersionDetails";
        
        public ContainerPackageVersionDetails() { }
        
        public ContainerPackageVersionDetails(PackageType type, string repository, string name, string version, long created, long downloads, bool pinned, long diskSize, int schemaVersion, string mediaType, string manifestType, List<string>? tags = null, long? accessed = null, string? comment = null, CPrincipal? author = null, List<CPrincipal>? authors = null, PackageOrigin? origin = null, Dictionary<string, string>? metadata = null, ContainerImage? image = null, ContainerHelmChart? chart = null)
        {
            Type = type;
            Repository = repository;
            Name = name;
            Version = version;
            Tags = tags;
            Created = created;
            Accessed = accessed;
            Downloads = downloads;
            IsPinned = pinned;
            Comment = comment;
            DiskSize = diskSize;
            Author = author;
            Authors = authors;
            Origin = origin;
            Metadata = metadata;
            SchemaVersion = schemaVersion;
            MediaType = mediaType;
            ManifestType = manifestType;
            Image = image;
            Chart = chart;
        }
        
        private PropertyValue<PackageType> _type = new PropertyValue<PackageType>(nameof(ContainerPackageVersionDetails), nameof(Type));
        
        [Required]
        [JsonPropertyName("type")]
        public PackageType Type
        {
            get => _type.GetValue();
            set => _type.SetValue(value);
        }
    
        private PropertyValue<string> _repository = new PropertyValue<string>(nameof(ContainerPackageVersionDetails), nameof(Repository));
        
        [Required]
        [JsonPropertyName("repository")]
        public string Repository
        {
            get => _repository.GetValue();
            set => _repository.SetValue(value);
        }
    
        private PropertyValue<string> _name = new PropertyValue<string>(nameof(ContainerPackageVersionDetails), nameof(Name));
        
        [Required]
        [JsonPropertyName("name")]
        public string Name
        {
            get => _name.GetValue();
            set => _name.SetValue(value);
        }
    
        private PropertyValue<string> _version = new PropertyValue<string>(nameof(ContainerPackageVersionDetails), nameof(Version));
        
        [Required]
        [JsonPropertyName("version")]
        public string Version
        {
            get => _version.GetValue();
            set => _version.SetValue(value);
        }
    
        private PropertyValue<List<string>?> _tags = new PropertyValue<List<string>?>(nameof(ContainerPackageVersionDetails), nameof(Tags));
        
        [JsonPropertyName("tags")]
        public List<string>? Tags
        {
            get => _tags.GetValue();
            set => _tags.SetValue(value);
        }
    
        private PropertyValue<long> _created = new PropertyValue<long>(nameof(ContainerPackageVersionDetails), nameof(Created));
        
        [Required]
        [JsonPropertyName("created")]
        public long Created
        {
            get => _created.GetValue();
            set => _created.SetValue(value);
        }
    
        private PropertyValue<long?> _accessed = new PropertyValue<long?>(nameof(ContainerPackageVersionDetails), nameof(Accessed));
        
        [JsonPropertyName("accessed")]
        public long? Accessed
        {
            get => _accessed.GetValue();
            set => _accessed.SetValue(value);
        }
    
        private PropertyValue<long> _downloads = new PropertyValue<long>(nameof(ContainerPackageVersionDetails), nameof(Downloads));
        
        [Required]
        [JsonPropertyName("downloads")]
        public long Downloads
        {
            get => _downloads.GetValue();
            set => _downloads.SetValue(value);
        }
    
        private PropertyValue<bool> _pinned = new PropertyValue<bool>(nameof(ContainerPackageVersionDetails), nameof(IsPinned));
        
        [Required]
        [JsonPropertyName("pinned")]
        public bool IsPinned
        {
            get => _pinned.GetValue();
            set => _pinned.SetValue(value);
        }
    
        private PropertyValue<string?> _comment = new PropertyValue<string?>(nameof(ContainerPackageVersionDetails), nameof(Comment));
        
        [JsonPropertyName("comment")]
        public string? Comment
        {
            get => _comment.GetValue();
            set => _comment.SetValue(value);
        }
    
        private PropertyValue<long> _diskSize = new PropertyValue<long>(nameof(ContainerPackageVersionDetails), nameof(DiskSize));
        
        [Required]
        [JsonPropertyName("diskSize")]
        public long DiskSize
        {
            get => _diskSize.GetValue();
            set => _diskSize.SetValue(value);
        }
    
        private PropertyValue<CPrincipal?> _author = new PropertyValue<CPrincipal?>(nameof(ContainerPackageVersionDetails), nameof(Author));
        
        [JsonPropertyName("author")]
        public CPrincipal? Author
        {
            get => _author.GetValue();
            set => _author.SetValue(value);
        }
    
        private PropertyValue<List<CPrincipal>?> _authors = new PropertyValue<List<CPrincipal>?>(nameof(ContainerPackageVersionDetails), nameof(Authors));
        
        [JsonPropertyName("authors")]
        public List<CPrincipal>? Authors
        {
            get => _authors.GetValue();
            set => _authors.SetValue(value);
        }
    
        private PropertyValue<PackageOrigin?> _origin = new PropertyValue<PackageOrigin?>(nameof(ContainerPackageVersionDetails), nameof(Origin));
        
        [JsonPropertyName("origin")]
        public PackageOrigin? Origin
        {
            get => _origin.GetValue();
            set => _origin.SetValue(value);
        }
    
        private PropertyValue<Dictionary<string, string>?> _metadata = new PropertyValue<Dictionary<string, string>?>(nameof(ContainerPackageVersionDetails), nameof(Metadata));
        
        [JsonPropertyName("metadata")]
        public Dictionary<string, string>? Metadata
        {
            get => _metadata.GetValue();
            set => _metadata.SetValue(value);
        }
    
        private PropertyValue<int> _schemaVersion = new PropertyValue<int>(nameof(ContainerPackageVersionDetails), nameof(SchemaVersion));
        
        [Required]
        [JsonPropertyName("schemaVersion")]
        public int SchemaVersion
        {
            get => _schemaVersion.GetValue();
            set => _schemaVersion.SetValue(value);
        }
    
        private PropertyValue<string> _mediaType = new PropertyValue<string>(nameof(ContainerPackageVersionDetails), nameof(MediaType));
        
        [Required]
        [JsonPropertyName("mediaType")]
        public string MediaType
        {
            get => _mediaType.GetValue();
            set => _mediaType.SetValue(value);
        }
    
        private PropertyValue<string> _manifestType = new PropertyValue<string>(nameof(ContainerPackageVersionDetails), nameof(ManifestType));
        
        [Required]
        [JsonPropertyName("manifestType")]
        public string ManifestType
        {
            get => _manifestType.GetValue();
            set => _manifestType.SetValue(value);
        }
    
        private PropertyValue<ContainerImage?> _image = new PropertyValue<ContainerImage?>(nameof(ContainerPackageVersionDetails), nameof(Image));
        
        [JsonPropertyName("image")]
        public ContainerImage? Image
        {
            get => _image.GetValue();
            set => _image.SetValue(value);
        }
    
        private PropertyValue<ContainerHelmChart?> _chart = new PropertyValue<ContainerHelmChart?>(nameof(ContainerPackageVersionDetails), nameof(Chart));
        
        [JsonPropertyName("chart")]
        public ContainerHelmChart? Chart
        {
            get => _chart.GetValue();
            set => _chart.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _type.SetAccessPath(path, validateHasBeenSet);
            _repository.SetAccessPath(path, validateHasBeenSet);
            _name.SetAccessPath(path, validateHasBeenSet);
            _version.SetAccessPath(path, validateHasBeenSet);
            _tags.SetAccessPath(path, validateHasBeenSet);
            _created.SetAccessPath(path, validateHasBeenSet);
            _accessed.SetAccessPath(path, validateHasBeenSet);
            _downloads.SetAccessPath(path, validateHasBeenSet);
            _pinned.SetAccessPath(path, validateHasBeenSet);
            _comment.SetAccessPath(path, validateHasBeenSet);
            _diskSize.SetAccessPath(path, validateHasBeenSet);
            _author.SetAccessPath(path, validateHasBeenSet);
            _authors.SetAccessPath(path, validateHasBeenSet);
            _origin.SetAccessPath(path, validateHasBeenSet);
            _metadata.SetAccessPath(path, validateHasBeenSet);
            _schemaVersion.SetAccessPath(path, validateHasBeenSet);
            _mediaType.SetAccessPath(path, validateHasBeenSet);
            _manifestType.SetAccessPath(path, validateHasBeenSet);
            _image.SetAccessPath(path, validateHasBeenSet);
            _chart.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
