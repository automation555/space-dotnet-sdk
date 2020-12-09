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
    public sealed class ContainerImagePlatform
         : IPropagatePropertyAccessPath
    {
        public ContainerImagePlatform() { }
        
        public ContainerImagePlatform(string os, string? osVersion = null, string? arch = null)
        {
            Os = os;
            OsVersion = osVersion;
            Arch = arch;
        }
        
        private PropertyValue<string> _os = new PropertyValue<string>(nameof(ContainerImagePlatform), nameof(Os));
        
        [Required]
        [JsonPropertyName("os")]
        public string Os
        {
            get => _os.GetValue();
            set => _os.SetValue(value);
        }
    
        private PropertyValue<string?> _osVersion = new PropertyValue<string?>(nameof(ContainerImagePlatform), nameof(OsVersion));
        
        [JsonPropertyName("osVersion")]
        public string? OsVersion
        {
            get => _osVersion.GetValue();
            set => _osVersion.SetValue(value);
        }
    
        private PropertyValue<string?> _arch = new PropertyValue<string?>(nameof(ContainerImagePlatform), nameof(Arch));
        
        [JsonPropertyName("arch")]
        public string? Arch
        {
            get => _arch.GetValue();
            set => _arch.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _os.SetAccessPath(path, validateHasBeenSet);
            _osVersion.SetAccessPath(path, validateHasBeenSet);
            _arch.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
