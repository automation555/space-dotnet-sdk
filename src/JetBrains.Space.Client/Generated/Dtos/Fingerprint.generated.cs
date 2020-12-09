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
    public sealed class Fingerprint
         : IPropagatePropertyAccessPath
    {
        public Fingerprint() { }
        
        public Fingerprint(string md5, string sha1, string sha256, string sha384, string sha512)
        {
            Md5 = md5;
            Sha1 = sha1;
            Sha256 = sha256;
            Sha384 = sha384;
            Sha512 = sha512;
        }
        
        private PropertyValue<string> _md5 = new PropertyValue<string>(nameof(Fingerprint), nameof(Md5));
        
        [Required]
        [JsonPropertyName("md5")]
        public string Md5
        {
            get => _md5.GetValue();
            set => _md5.SetValue(value);
        }
    
        private PropertyValue<string> _sha1 = new PropertyValue<string>(nameof(Fingerprint), nameof(Sha1));
        
        [Required]
        [JsonPropertyName("sha1")]
        public string Sha1
        {
            get => _sha1.GetValue();
            set => _sha1.SetValue(value);
        }
    
        private PropertyValue<string> _sha256 = new PropertyValue<string>(nameof(Fingerprint), nameof(Sha256));
        
        [Required]
        [JsonPropertyName("sha256")]
        public string Sha256
        {
            get => _sha256.GetValue();
            set => _sha256.SetValue(value);
        }
    
        private PropertyValue<string> _sha384 = new PropertyValue<string>(nameof(Fingerprint), nameof(Sha384));
        
        [Required]
        [JsonPropertyName("sha384")]
        public string Sha384
        {
            get => _sha384.GetValue();
            set => _sha384.SetValue(value);
        }
    
        private PropertyValue<string> _sha512 = new PropertyValue<string>(nameof(Fingerprint), nameof(Sha512));
        
        [Required]
        [JsonPropertyName("sha512")]
        public string Sha512
        {
            get => _sha512.GetValue();
            set => _sha512.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _md5.SetAccessPath(path, validateHasBeenSet);
            _sha1.SetAccessPath(path, validateHasBeenSet);
            _sha256.SetAccessPath(path, validateHasBeenSet);
            _sha384.SetAccessPath(path, validateHasBeenSet);
            _sha512.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
